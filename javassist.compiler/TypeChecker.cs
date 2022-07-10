using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler.ast;

namespace javassist.compiler;

[Implements(new string[] { "javassist.bytecode.Opcode", "javassist.compiler.TokenId" })]
public class TypeChecker : Visitor, Opcode, TokenId
{
	internal const string javaLangObject = "java.lang.Object";

	internal const string jvmJavaLangObject = "java/lang/Object";

	internal const string jvmJavaLangString = "java/lang/String";

	internal const string jvmJavaLangClass = "java/lang/Class";

	protected internal int exprType;

	protected internal int arrayDim;

	protected internal string className;

	protected internal MemberResolver resolver;

	protected internal CtClass thisClass;

	protected internal MethodInfo thisMethod;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 75, 104, 103, 114, 105, 101, 104, 103, 103,
		101, 113, 99, 98, 98, 109, 105, 98, 104, 109,
		100, 163
	})]
	internal static ASTree stripPlusExpr(ASTree P_0)
	{
		if (P_0 is BinExpr)
		{
			BinExpr binExpr = (BinExpr)P_0;
			if (binExpr.getOperator() == 43 && binExpr.oprand2() == null)
			{
				ASTree left = binExpr.getLeft();
				_ = null;
				return left;
			}
		}
		else if (P_0 is Expr)
		{
			Expr expr = (Expr)P_0;
			switch (expr.getOperator())
			{
			case 35:
			{
				ASTree constantFieldValue = getConstantFieldValue((Member)expr.oprand2());
				if (constantFieldValue != null)
				{
					return constantFieldValue;
				}
				break;
			}
			case 43:
				if (expr.getRight() == null)
				{
					ASTree left2 = expr.getLeft();
					_ = null;
					return left2;
				}
				break;
			}
		}
		else if (P_0 is Member)
		{
			ASTree constantFieldValue2 = getConstantFieldValue((Member)P_0);
			if (constantFieldValue2 != null)
			{
				return constantFieldValue2;
			}
		}
		return P_0;
	}

	public virtual void setThisMethod(MethodInfo m)
	{
		thisMethod = m;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 113, 104, 103, 106, 103, 122, 211 })]
	internal static string isDotSuper(ASTree P_0)
	{
		if (P_0 is Expr)
		{
			Expr expr = (Expr)P_0;
			if (expr.getOperator() == 46)
			{
				ASTree aSTree = expr.oprand2();
				if (aSTree is Keyword && ((Keyword)aSTree).get() == 336)
				{
					string result = ((Symbol)expr.oprand1()).get();
					_ = null;
					return result;
				}
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 109, 99, 130, 103, 99, 130, 104, 110, 112,
		104, 109, 148, 104, 117, 148, 104, 109, 51, 161
	})]
	public static ASTree getConstantFieldValue(CtField f)
	{
		if (f == null)
		{
			return null;
		}
		object constantValue = f.getConstantValue();
		if (constantValue == null)
		{
			return null;
		}
		if (constantValue is string)
		{
			StringL result = new StringL((string)constantValue);
			_ = null;
			return result;
		}
		if (constantValue is Double || constantValue is Float)
		{
			int tokenId = ((!(constantValue is Double)) ? 404 : 405);
			DoubleConst result2 = new DoubleConst(((Number)constantValue).doubleValue(), tokenId);
			_ = null;
			return result2;
		}
		if (constantValue is Number)
		{
			int tokenId = ((!(constantValue is Long)) ? 402 : 403);
			IntConst result3 = new IntConst(((Number)constantValue).longValue(), tokenId);
			_ = null;
			return result3;
		}
		if (constantValue is Boolean)
		{
			Keyword result4 = new Keyword((!((Boolean)constantValue).booleanValue()) ? 411 : 410);
			_ = null;
			return result4;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		52, 104, 105, 104, 168, 210, 2, 97, 166, 104,
		105, 142
	})]
	protected internal static StringBuilder typeToString(StringBuilder sbuf, int type, int dim, string cname)
	{
		string str;
		switch (type)
		{
		case 307:
			str = MemberResolver.jvmToJavaName(cname);
			break;
		case 412:
			str = "Object";
			break;
		default:
			{
				try
				{
					str = MemberResolver.getTypeName(type);
				}
				catch (CompileError)
				{
					goto IL_0030;
				}
				break;
			}
			IL_0030:
			_ = null;
			str = "?";
			break;
		}
		sbuf.append(str);
		while (true)
		{
			int num = dim;
			dim += -1;
			if (num <= 0)
			{
				break;
			}
			sbuf.append("[]");
		}
		return sbuf;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 65, 103, 103, 103, 103, 99, 135, 105, 139,
		104, 100, 136, 103, 103, 104, 143, 135
	})]
	public virtual void atNewArrayExpr(NewExpr expr)
	{
		int arrayType = expr.getArrayType();
		ASTList arraySize = expr.getArraySize();
		ASTList aSTList = expr.getClassName();
		expr.getInitializer()?.accept(this);
		if (arraySize.length() > 1)
		{
			atMultiNewArray(arrayType, aSTList, arraySize);
			return;
		}
		arraySize.head()?.accept(this);
		exprType = arrayType;
		arrayDim = 1;
		if (arrayType == 307)
		{
			className = resolveClassName(aSTList);
		}
		else
		{
			className = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 133, 104, 103, 103, 103, 138, 119, 135, 103,
		104, 138, 109, 159, 7, 159, 11, 173, 110, 104
	})]
	public virtual MemberResolver.Method atMethodCallCore(CtClass targetClass, string mname, ASTList args)
	{
		int methodArgsLength = getMethodArgsLength(args);
		int[] array = new int[methodArgsLength];
		int[] array2 = new int[methodArgsLength];
		string[] array3 = new string[methodArgsLength];
		atMethodArgs(args, array, array2, array3);
		MemberResolver.Method method = resolver.lookupMethod(targetClass, thisClass, thisMethod, mname, array, array2, array3);
		string name;
		if (method == null)
		{
			name = targetClass.getName();
			string str = argTypesToString(array, array2, array3);
			string s = ((!String.instancehelper_equals(mname, "<init>")) ? new StringBuilder().append(mname).append(str).append(" not found in ")
				.append(name)
				.toString() : new StringBuilder().append("cannot find constructor ").append(name).append(str)
				.toString());
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		name = method.info.getDescriptor();
		setReturnType(name);
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 104, 103, 101, 103, 99, 130, 100, 231, 58,
		234, 73, 103, 103, 104, 143, 103
	})]
	protected internal virtual void atMultiNewArray(int type, ASTList classname, ASTList size)
	{
		int num = size.length();
		int num2 = 0;
		while (size != null)
		{
			ASTree aSTree = size.head();
			if (aSTree == null)
			{
				break;
			}
			num2++;
			aSTree.accept(this);
			size = size.tail();
		}
		exprType = type;
		arrayDim = num;
		if (type == 307)
		{
			className = resolveClassName(classname);
		}
		else
		{
			className = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(153)]
	protected internal virtual string resolveClassName(ASTList name)
	{
		string result = resolver.resolveClassName(name);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 153, 104, 104, 136, 101, 135, 104, 103, 103,
		103
	})]
	private void atVariableAssign(Expr P_0, int P_1, Variable P_2, Declarator P_3, ASTree P_4)
	{
		int type = P_3.getType();
		int num = P_3.getArrayDim();
		string text = P_3.getClassName();
		if (P_1 != 61)
		{
			atVariable(P_2);
		}
		P_4.accept(this);
		exprType = type;
		arrayDim = num;
		className = text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 169, 114, 103, 103, 103, 104, 103, 103, 103 })]
	private void atArrayAssign(Expr P_0, int P_1, Expr P_2, ASTree P_3)
	{
		atArrayRead(P_2.oprand1(), P_2.oprand2());
		int num = exprType;
		int num2 = arrayDim;
		string text = className;
		P_3.accept(this);
		exprType = num;
		arrayDim = num2;
		className = text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 182, 104, 103, 103, 103, 103, 104, 103, 103,
		103
	})]
	protected internal virtual void atFieldAssign(Expr expr, int op, ASTree left, ASTree right)
	{
		CtField ctField = fieldAccess(left);
		atFieldRead(ctField);
		int num = exprType;
		int num2 = arrayDim;
		string text = className;
		right.accept(this);
		exprType = num;
		arrayDim = num2;
		className = text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 140, 103, 108, 108, 108 })]
	public override void atVariable(Variable v)
	{
		Declarator declarator = v.getDeclarator();
		exprType = declarator.getType();
		arrayDim = declarator.getArrayDim();
		className = declarator.getClassName();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 84, 103, 103, 103, 103, 103, 103, 105, 103 })]
	public virtual void atArrayRead(ASTree array, ASTree index)
	{
		array.accept(this);
		int num = exprType;
		int num2 = arrayDim;
		string text = className;
		index.accept(this);
		exprType = num;
		arrayDim = num2 - 1;
		className = text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162,
		235,
		107,
		103,
		135,
		109,
		109,
		135,
		144,
		129,
		173,
		107,
		104,
		105,
		102,
		110,
		104,
		120,
		105,
		131,
		137,
		byte.MaxValue,
		2,
		75,
		226,
		55,
		98,
		112,
		232,
		70,
		176,
		131,
		117,
		110,
		42,
		byte.MaxValue,
		5,
		69,
		2,
		98,
		228,
		83,
		105,
		105,
		149,
		100,
		200
	})]
	protected internal virtual CtField fieldAccess(ASTree expr)
	{
		//Discarded unreachable code: IL_003d, IL_0143
		if (expr is Member)
		{
			Member member = (Member)expr;
			string name = member.get();
			try
			{
				CtField field = thisClass.getField(name);
				if (Modifier.isStatic(field.getModifiers()))
				{
					member.setField(field);
				}
				return field;
			}
			catch (NotFoundException)
			{
			}
			_ = null;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoFieldException(name, expr);
		}
		if (expr is Expr)
		{
			Expr expr2 = (Expr)expr;
			NoFieldException ex2;
			CompileError compileError;
			CompileError compileError2;
			NoFieldException ex3;
			CompileError compileError3;
			ASTree aSTree;
			switch (expr2.getOperator())
			{
			case 35:
			{
				Member member2 = (Member)expr2.oprand2();
				CtField ctField = resolver.lookupField(((Symbol)expr2.oprand1()).get(), member2);
				member2.setField(ctField);
				return ctField;
			}
			case 46:
				{
					try
					{
						expr2.oprand1().accept(this);
					}
					catch (NoFieldException x)
					{
						ex2 = ByteCodeHelper.MapException<NoFieldException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_00da;
					}
					compileError = null;
					try
					{
						if (exprType == 307 && arrayDim == 0)
						{
							return resolver.lookupFieldByJvmName(className, (Symbol)expr2.oprand2());
						}
					}
					catch (CompileError x2)
					{
						compileError2 = ByteCodeHelper.MapException<CompileError>(x2, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_0159;
					}
					goto IL_0166;
				}
				IL_00da:
				ex3 = ex2;
				if (ex3.getExpr() != expr2.oprand1())
				{
					throw Throwable.___003Cunmap_003E(ex3);
				}
				return fieldAccess2(expr2, ex3.getField());
				IL_0159:
				compileError3 = compileError2;
				compileError = compileError3;
				goto IL_0166;
				IL_0166:
				aSTree = expr2.oprand1();
				if (aSTree is Symbol)
				{
					return fieldAccess2(expr2, ((Symbol)aSTree).get());
				}
				if (compileError != null)
				{
					throw Throwable.___003Cunmap_003E(compileError);
				}
				break;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad field access");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 209, 103, 135, 98, 98, 105, 102, 100, 175,
		103, 141, 102, 156, 103
	})]
	private void atFieldRead(CtField P_0)
	{
		FieldInfo fieldInfo = P_0.getFieldInfo2();
		string descriptor = fieldInfo.getDescriptor();
		int num = 0;
		int num2 = 0;
		int num3;
		for (num3 = String.instancehelper_charAt(descriptor, num); num3 == 91; num3 = String.instancehelper_charAt(descriptor, num))
		{
			num2++;
			num++;
		}
		arrayDim = num2;
		exprType = MemberResolver.descToType((char)num3);
		if (num3 == 76)
		{
			className = String.instancehelper_substring(descriptor, num + 1, String.instancehelper_indexOf(descriptor, 59, num + 1));
		}
		else
		{
			className = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 166, 103, 104, 103, 108, 103, 103, 108, 107,
		110, 98, 101, 115, 112, 103, 108, 108, 130, 135,
		107, 103
	})]
	private void booleanExpr(ASTree P_0)
	{
		switch (CodeGen.getCompOperator(P_0))
		{
		case 358:
		{
			BinExpr binExpr = (BinExpr)P_0;
			binExpr.oprand1().accept(this);
			int num = exprType;
			int num2 = arrayDim;
			binExpr.oprand2().accept(this);
			if (num2 == 0 && arrayDim == 0)
			{
				insertCast(binExpr, num, exprType);
			}
			break;
		}
		case 33:
			((Expr)P_0).oprand1().accept(this);
			break;
		case 368:
		case 369:
		{
			BinExpr binExpr = (BinExpr)P_0;
			binExpr.oprand1().accept(this);
			binExpr.oprand2().accept(this);
			break;
		}
		default:
			P_0.accept(this);
			break;
		}
		exprType = 301;
		arrayDim = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 4, 103, 103, 163, 103, 162, 104, 109, 99,
		103, 107, 103, 107, 138, 130, 135, 103, 104, 104,
		135, 109, 130, 159, 33, 103, 159, 6, 106, 107,
		103, 107, 145, 106
	})]
	private Expr atPlusExpr(BinExpr P_0)
	{
		ASTree aSTree = P_0.oprand1();
		ASTree aSTree2 = P_0.oprand2();
		if (aSTree2 == null)
		{
			aSTree.accept(this);
			return null;
		}
		if (isPlusExpr(aSTree))
		{
			Expr expr = atPlusExpr((BinExpr)aSTree);
			if (expr != null)
			{
				aSTree2.accept(this);
				exprType = 307;
				arrayDim = 0;
				className = "java/lang/StringBuffer";
				Expr result = makeAppendCall(expr, aSTree2);
				_ = null;
				return result;
			}
		}
		else
		{
			aSTree.accept(this);
		}
		int num = exprType;
		int num2 = arrayDim;
		string anObject = className;
		aSTree2.accept(this);
		if (isConstant(P_0, 43, aSTree, aSTree2))
		{
			return null;
		}
		if ((num == 307 && num2 == 0 && String.instancehelper_equals("java/lang/String", anObject)) || (exprType == 307 && arrayDim == 0 && String.instancehelper_equals("java/lang/String", className)))
		{
			ASTList aSTList = ASTList.make(new Symbol("java"), new Symbol("lang"), new Symbol("StringBuffer"));
			NewExpr newExpr = new NewExpr(aSTList, null);
			exprType = 307;
			arrayDim = 0;
			className = "java/lang/StringBuffer";
			Expr result2 = makeAppendCall(makeAppendCall(newExpr, aSTree), aSTree2);
			_ = null;
			return result2;
		}
		computeBinExprType(P_0, 43, num);
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 52, 104, 105, 98, 118, 124, 119, 104, 113,
		104, 143, 99, 98, 104, 103, 103, 103
	})]
	private bool isConstant(BinExpr P_0, int P_1, ASTree P_2, ASTree P_3)
	{
		P_2 = stripPlusExpr(P_2);
		P_3 = stripPlusExpr(P_3);
		ASTree aSTree = null;
		if (P_2 is StringL && P_3 is StringL && P_1 == 43)
		{
			aSTree = new StringL(new StringBuilder().append(((StringL)P_2).get()).append(((StringL)P_3).get()).toString());
		}
		else if (P_2 is IntConst)
		{
			aSTree = ((IntConst)P_2).compute(P_1, P_3);
		}
		else if (P_2 is DoubleConst)
		{
			aSTree = ((DoubleConst)P_2).compute(P_1, P_3);
		}
		if (aSTree == null)
		{
			return false;
		}
		P_0.setOperator(43);
		P_0.setOprand1(aSTree);
		P_0.setOprand2(null);
		aSTree.accept(this);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 153, 103, 120, 137, 137, 122, 107 })]
	private void computeBinExprType(BinExpr P_0, int P_1, int P_2)
	{
		int num = exprType;
		if (P_1 == 364 || P_1 == 366 || P_1 == 370)
		{
			exprType = P_2;
		}
		else
		{
			insertCast(P_0, P_2, num);
		}
		if (CodeGen.isP_INT(exprType) && exprType != 301)
		{
			exprType = 324;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 135, 104, 103, 103, 166 })]
	private static bool isPlusExpr(ASTree P_0)
	{
		if (P_0 is BinExpr)
		{
			BinExpr binExpr = (BinExpr)P_0;
			int @operator = binExpr.getOperator();
			return @operator == 43;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(515)]
	private static Expr makeAppendCall(ASTree P_0, ASTree P_1)
	{
		CallExpr result = CallExpr.makeCall(Expr.make(46, P_0, new Member("append")), new ASTList(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(475)]
	private static ASTree getConstantFieldValue(Member P_0)
	{
		ASTree constantFieldValue = getConstantFieldValue(P_0.getField());
		_ = null;
		return constantFieldValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 193, 105, 149, 103 })]
	private void insertCast(BinExpr P_0, int P_1, int P_2)
	{
		if (CodeGen.rightIsStrong(P_1, P_2))
		{
			P_0.setLeft(new CastExpr(P_2, 0, P_0.oprand1()));
		}
		else
		{
			exprType = P_1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 73, 108, 104, 145, 107, 103 })]
	public virtual void atArrayLength(Expr expr)
	{
		expr.oprand1().accept(this);
		if (arrayDim == 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoFieldException("length", expr);
		}
		exprType = 324;
		arrayDim = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 205, 111 })]
	private void atFieldRead(ASTree P_0)
	{
		atFieldRead(fieldAccess(P_0));
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public virtual void atClassObject(Expr expr)
	{
		exprType = 307;
		arrayDim = 0;
		className = "java/lang/Class";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 97, 104, 99, 136, 104, 108, 108, 108, 133,
		107, 103, 106, 146, 103, 127, 1, 139, 193, 137
	})]
	private void atPlusPlus(int P_0, ASTree P_1, Expr P_2)
	{
		if (P_1 == null)
		{
			P_1 = P_2.oprand2();
		}
		if (P_1 is Variable)
		{
			Declarator declarator = ((Variable)P_1).getDeclarator();
			exprType = declarator.getType();
			arrayDim = declarator.getArrayDim();
			return;
		}
		if (P_1 is Expr)
		{
			Expr expr = (Expr)P_1;
			if (expr.getOperator() == 65)
			{
				atArrayRead(expr.oprand1(), expr.oprand2());
				int num = exprType;
				if (num == 324 || num == 303 || num == 306 || num == 334)
				{
					exprType = 324;
				}
				return;
			}
		}
		atFieldPlusPlus(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(129)]
	protected internal static void fatal()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("fatal");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 6, 104, 104, 103, 103, 101, 101, 101, 135,
		130, 103, 98, 104, 103, 101, 143, 98, 130, 130,
		104
	})]
	private bool isConstant(Expr P_0, int P_1, ASTree P_2)
	{
		P_2 = stripPlusExpr(P_2);
		if (P_2 is IntConst)
		{
			IntConst intConst = (IntConst)P_2;
			long num = intConst.get();
			switch (P_1)
			{
			case 45:
				num = -num;
				break;
			case 126:
				num ^= -1;
				break;
			default:
				return false;
			}
			intConst.set(num);
		}
		else
		{
			if (!(P_2 is DoubleConst))
			{
				return false;
			}
			DoubleConst doubleConst = (DoubleConst)P_2;
			if (P_1 != 45)
			{
				return false;
			}
			doubleConst.set(0.0 - doubleConst.get());
		}
		P_0.setOperator(43);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(728)]
	private static void badMethod()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad method");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(786)]
	public virtual int getMethodArgsLength(ASTList args)
	{
		int result = ASTList.length(args);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 165, 98, 99, 103, 103, 105, 105, 106, 100,
		104, 98
	})]
	public virtual void atMethodArgs(ASTList args, int[] types, int[] dims, string[] cnames)
	{
		int num = 0;
		while (args != null)
		{
			ASTree aSTree = args.head();
			aSTree.accept(this);
			types[num] = exprType;
			dims[num] = arrayDim;
			cnames[num] = className;
			num++;
			args = args.tail();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		27, 102, 105, 99, 100, 130, 112, 104, 235, 70,
		105
	})]
	protected internal static string argTypesToString(int[] types, int[] dims, string[] cnames)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append('(');
		int num = types.Length;
		if (num > 0)
		{
			int num2 = 0;
			while (true)
			{
				typeToString(stringBuilder, types[num2], dims[num2], cnames[num2]);
				num2++;
				if (num2 >= num)
				{
					break;
				}
				stringBuilder.append(',');
			}
		}
		stringBuilder.append(')');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 178, 105, 100, 133, 108, 98, 101, 100, 174,
		103, 101, 108, 100, 133, 107, 112, 130, 108, 135
	})]
	internal virtual void setReturnType(string P_0)
	{
		int num = String.instancehelper_indexOf(P_0, 41);
		if (num < 0)
		{
			badMethod();
		}
		num++;
		int num2 = String.instancehelper_charAt(P_0, num);
		int num3 = 0;
		while (num2 == 91)
		{
			num3++;
			num++;
			num2 = String.instancehelper_charAt(P_0, num);
		}
		arrayDim = num3;
		if (num2 == 76)
		{
			int num4 = String.instancehelper_indexOf(P_0, 59, num + 1);
			if (num4 < 0)
			{
				badMethod();
			}
			exprType = 307;
			className = String.instancehelper_substring(P_0, num + 1, num4);
		}
		else
		{
			exprType = MemberResolver.descToType((char)num2);
			className = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 58, 108, 111, 104, 113, 103 })]
	private CtField fieldAccess2(Expr P_0, string P_1)
	{
		Member member = (Member)P_0.oprand2();
		CtField ctField = resolver.lookupFieldByJvmName2(P_1, member, P_0);
		P_0.setOperator(35);
		P_0.setOprand1(new Symbol(MemberResolver.jvmToJavaName(P_1)));
		member.setField(ctField);
		return ctField;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 126, 104, 103, 103, 127, 1, 107 })]
	protected internal virtual void atFieldPlusPlus(ASTree oprand)
	{
		CtField ctField = fieldAccess(oprand);
		atFieldRead(ctField);
		int num = exprType;
		if (num == 324 || num == 303 || num == 306 || num == 334)
		{
			exprType = 324;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(136)]
	protected internal virtual string getThisName()
	{
		string result = MemberResolver.javaToJvmName(thisClass.getName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 93, 102, 42 })]
	protected internal virtual string getSuperName()
	{
		string result = MemberResolver.javaToJvmName(MemberResolver.getSuperclass(thisClass).getName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 104, 108, 103, 103 })]
	public TypeChecker(CtClass cc, ClassPool cp)
	{
		resolver = new MemberResolver(cp);
		thisClass = cc;
		thisMethod = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(160)]
	protected internal virtual string resolveClassName(string jvmName)
	{
		string result = resolver.resolveJvmClassName(jvmName);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 115, 104, 137, 114, 103, 103, 110, 107, 103, 140 })]
	public override void atNewExpr(NewExpr expr)
	{
		if (expr.isArray())
		{
			atNewArrayExpr(expr);
			return;
		}
		CtClass ctClass = resolver.lookupClassByName(expr.getClassName());
		string name = ctClass.getName();
		ASTList arguments = expr.getArguments();
		atMethodCallCore(ctClass, "<init>", arguments);
		exprType = 307;
		arrayDim = 0;
		className = MemberResolver.javaToJvmName(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 160, 90, 98, 99, 103, 103, 99, 103, 98 })]
	public override void atArrayInit(ArrayInit init)
	{
		ASTList aSTList = init;
		while (aSTList != null)
		{
			ASTree aSTree = aSTList.head();
			aSTList = aSTList.tail();
			aSTree?.accept(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 125, 103, 103, 103, 104, 111, 38, 199, 104,
		103, 106, 113, 193, 140
	})]
	public override void atAssignExpr(AssignExpr expr)
	{
		int @operator = expr.getOperator();
		ASTree aSTree = expr.oprand1();
		ASTree aSTree2 = expr.oprand2();
		if (aSTree is Variable)
		{
			atVariableAssign(expr, @operator, (Variable)aSTree, ((Variable)aSTree).getDeclarator(), aSTree2);
			return;
		}
		if (aSTree is Expr)
		{
			Expr expr2 = (Expr)aSTree;
			if (expr2.getOperator() == 65)
			{
				atArrayAssign(expr, @operator, (Expr)aSTree, aSTree2);
				return;
			}
		}
		atFieldAssign(expr, @operator, aSTree, aSTree2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 195, 108, 108, 103, 135, 103, 140, 108, 110,
		122, 110, 115, 135
	})]
	public override void atCondExpr(CondExpr expr)
	{
		booleanExpr(expr.condExpr());
		expr.thenExpr().accept(this);
		int num = exprType;
		int num2 = arrayDim;
		_ = className;
		expr.elseExpr().accept(this);
		if (num2 == 0 && num2 == arrayDim)
		{
			if (CodeGen.rightIsStrong(num, exprType))
			{
				expr.setThen(new CastExpr(exprType, 0, expr.thenExpr()));
			}
			else if (CodeGen.rightIsStrong(exprType, num))
			{
				expr.setElse(new CastExpr(num, 0, expr.elseExpr()));
				exprType = num;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 220, 103, 103, 167, 101, 104, 195, 153, 103,
		103, 139, 130, 104, 104, 104, 104, 104, 110, 106,
		226, 69, 137
	})]
	public override void atBinExpr(BinExpr expr)
	{
		int @operator = expr.getOperator();
		int num = CodeGen.lookupBinOp(@operator);
		if (num >= 0)
		{
			if (@operator == 43)
			{
				Expr expr2 = atPlusExpr(expr);
				if (expr2 != null)
				{
					CallExpr oprand = CallExpr.makeCall(Expr.make(46, expr2, new Member("toString")), null);
					expr.setOprand1(oprand);
					expr.setOprand2(null);
					className = "java/lang/String";
				}
				return;
			}
			ASTree aSTree = expr.oprand1();
			ASTree aSTree2 = expr.oprand2();
			aSTree.accept(this);
			int num2 = exprType;
			aSTree2.accept(this);
			if (!isConstant(expr, @operator, aSTree, aSTree2))
			{
				computeBinExprType(expr, @operator, num2);
			}
		}
		else
		{
			booleanExpr(expr);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 201, 109, 108, 108, 108, 103 })]
	public override void atCastExpr(CastExpr expr)
	{
		string text = resolveClassName(expr.getClassName());
		expr.getOprand().accept(this);
		exprType = expr.getType();
		arrayDim = expr.getArrayDim();
		className = text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 210, 108, 107, 103 })]
	public override void atInstanceOfExpr(InstanceOfExpr expr)
	{
		expr.getOprand().accept(this);
		exprType = 301;
		arrayDim = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 220, 103, 103, 104, 113, 141, 242, 69, 226,
		61, 129, 103, 98, 109, 137, 103, 101, 101, 113,
		109, 137, 103, 101, 101, 114, 112, 107, 101, 105,
		101, 135, 103, 107, 106, 109, 139
	})]
	public override void atExpr(Expr expr)
	{
		int @operator = expr.getOperator();
		ASTree aSTree = expr.oprand1();
		switch (@operator)
		{
		case 46:
		{
			string @this = ((Symbol)expr.oprand2()).get();
			if (String.instancehelper_equals(@this, "length"))
			{
				try
				{
					atArrayLength(expr);
					break;
				}
				catch (NoFieldException)
				{
				}
				_ = null;
				atFieldRead(expr);
			}
			else if (String.instancehelper_equals(@this, "class"))
			{
				atClassObject(expr);
			}
			else
			{
				atFieldRead(expr);
			}
			break;
		}
		case 35:
		{
			string @this = ((Symbol)expr.oprand2()).get();
			if (String.instancehelper_equals(@this, "class"))
			{
				atClassObject(expr);
			}
			else
			{
				atFieldRead(expr);
			}
			break;
		}
		case 65:
			atArrayRead(aSTree, expr.oprand2());
			break;
		case 362:
		case 363:
			atPlusPlus(@operator, aSTree, expr);
			break;
		case 33:
			booleanExpr(expr);
			break;
		case 67:
			fatal();
			break;
		default:
			aSTree.accept(this);
			if (!isConstant(expr, @operator, aSTree) && (@operator == 45 || @operator == 126) && CodeGen.isP_INT(exprType))
			{
				exprType = 324;
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 35, 98, 98, 103, 140, 104, 108, 140, 104,
		102, 114, 145, 140, 107, 104, 114, 105, 102, 104,
		155, 105, 105, 105, 100, 211, 252, 77, 226, 53,
		98, 107, 168, 107, 103, 109, 105, 215, 105, 116,
		109, 148, 133, 130, 101, 130, 133, 100, 103, 104
	})]
	public override void atCallExpr(CallExpr expr)
	{
		string mname = null;
		CtClass targetClass = null;
		ASTree aSTree = expr.oprand1();
		ASTList args = (ASTList)expr.oprand2();
		if (aSTree is Member)
		{
			mname = ((Member)aSTree).get();
			targetClass = thisClass;
		}
		else if (aSTree is Keyword)
		{
			mname = "<init>";
			targetClass = ((((Keyword)aSTree).get() != 336) ? thisClass : MemberResolver.getSuperclass(thisClass));
		}
		else if (aSTree is Expr)
		{
			Expr expr2 = (Expr)aSTree;
			mname = ((Symbol)expr2.oprand2()).get();
			ASTree aSTree2;
			NoFieldException ex;
			NoFieldException ex2;
			switch (expr2.getOperator())
			{
			case 35:
				targetClass = resolver.lookupClass(((Symbol)expr2.oprand1()).get(), notCheckInner: false);
				break;
			case 46:
			{
				aSTree2 = expr2.oprand1();
				string text = isDotSuper(aSTree2);
				if (text != null)
				{
					targetClass = MemberResolver.getSuperInterface(thisClass, text);
					break;
				}
				try
				{
					aSTree2.accept(this);
				}
				catch (NoFieldException x)
				{
					ex = ByteCodeHelper.MapException<NoFieldException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0115;
				}
				goto IL_016f;
			}
			default:
				{
					badMethod();
					break;
				}
				IL_016f:
				if (arrayDim > 0)
				{
					targetClass = resolver.lookupClass("java.lang.Object", notCheckInner: true);
				}
				else if (exprType == 307)
				{
					targetClass = resolver.lookupClassByJvmName(className);
				}
				else
				{
					badMethod();
				}
				break;
				IL_0115:
				ex2 = ex;
				if (ex2.getExpr() != aSTree2)
				{
					throw Throwable.___003Cunmap_003E(ex2);
				}
				exprType = 307;
				arrayDim = 0;
				className = ex2.getField();
				expr2.setOperator(35);
				expr2.setOprand1(new Symbol(MemberResolver.jvmToJavaName(className)));
				goto IL_016f;
			}
		}
		else
		{
			fatal();
		}
		MemberResolver.Method method = atMethodCallCore(targetClass, mname, args);
		expr.setMethod(method);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 135, 105 })]
	public override void atMember(Member mem)
	{
		atFieldRead(mem);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 148, 103, 103, 191, 28, 107, 130, 107, 162,
		107, 104, 142, 108, 130, 135
	})]
	public override void atKeyword(Keyword k)
	{
		arrayDim = 0;
		int num = k.get();
		switch (num)
		{
		case 410:
		case 411:
			exprType = 301;
			break;
		case 412:
			exprType = 412;
			break;
		case 336:
		case 339:
			exprType = 307;
			if (num == 339)
			{
				className = getThisName();
			}
			else
			{
				className = getSuperName();
			}
			break;
		default:
			fatal();
			break;
		}
	}

	[Throws(new string[] { "javassist.compiler.CompileError" })]
	public override void atStringL(StringL s)
	{
		exprType = 307;
		arrayDim = 0;
		className = "java/lang/String";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 180, 103, 103, 112, 156, 107 })]
	public override void atIntConst(IntConst i)
	{
		arrayDim = 0;
		int type = i.getType();
		if (type == 402 || type == 401)
		{
			exprType = ((type != 402) ? 306 : 324);
		}
		else
		{
			exprType = 326;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 190, 103, 109, 141, 107 })]
	public override void atDoubleConst(DoubleConst d)
	{
		arrayDim = 0;
		if (d.getType() == 405)
		{
			exprType = 312;
		}
		else
		{
			exprType = 317;
		}
	}
}
