using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode;
using javassist.compiler.ast;

namespace javassist.compiler;

public class JvstCodeGen : MemberCodeGen
{
	internal string paramArrayName;

	internal string paramListName;

	internal CtClass[] paramTypeList;

	private int paramVarBase;

	private bool useParam0;

	private string param0Type;

	public const string sigName = "$sig";

	public const string dollarTypeName = "$type";

	public const string clazzName = "$class";

	private CtClass dollarType;

	internal CtClass returnType;

	internal string returnCastName;

	private string returnVarName;

	public const string wrapperCastName = "$w";

	internal string proceedName;

	public const string cflowName = "$cflow";

	internal ProceedHandler procHandler;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 251, 99, 103, 107, 130, 103, 99, 103, 107,
		105, 104, 103, 106, 105, 104, 104, 104, 106, 102,
		100, 110, 37, 165, 130, 103, 165, 232, 44, 233,
		87
	})]
	public static int compileParameterList(Bytecode code, CtClass[] @params, int regno)
	{
		if (@params == null)
		{
			code.addIconst(0);
			code.addAnewarray("java.lang.Object");
			return 1;
		}
		CtClass[] array = new CtClass[1];
		int num = @params.Length;
		code.addIconst(num);
		code.addAnewarray("java.lang.Object");
		for (int i = 0; i < num; i++)
		{
			code.addOpcode(89);
			code.addIconst(i);
			if (@params[i].isPrimitive())
			{
				CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)@params[i];
				string wrapperName = ctPrimitiveType.getWrapperName();
				code.addNew(wrapperName);
				code.addOpcode(89);
				int num2 = code.addLoad(regno, ctPrimitiveType);
				regno += num2;
				array[0] = ctPrimitiveType;
				code.addInvokespecial(wrapperName, "<init>", Descriptor.ofMethod(CtClass.voidType, array));
			}
			else
			{
				code.addAload(regno);
				regno++;
			}
			code.addOpcode(83);
		}
		return 8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 33, 109, 108, 107, 103, 139 })]
	public virtual void addNullIfVoid()
	{
		if (exprType == 344)
		{
			bytecode.addOpcode(1);
			exprType = 307;
			arrayDim = 0;
			className = "java/lang/Object";
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		9, 235, 44, 103, 103, 103, 103, 103, 199, 103,
		103, 103, 167, 135, 199, 112
	})]
	public JvstCodeGen(Bytecode b, CtClass cc, ClassPool cp)
		: base(b, cc, cp)
	{
		paramArrayName = null;
		paramListName = null;
		paramTypeList = null;
		paramVarBase = 0;
		useParam0 = false;
		param0Type = null;
		dollarType = null;
		returnType = null;
		returnCastName = null;
		returnVarName = null;
		proceedName = null;
		procHandler = null;
		setTypeChecker(new JvstTypeChecker(cc, cp, this));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 222, 98, 109, 134, 103, 98, 104, 99, 146,
		178, 145, 108
	})]
	public virtual void recordVariable(string typeDesc, string varName, int varNo, SymbolTable tbl)
	{
		int num = 0;
		int c;
		while ((c = String.instancehelper_charAt(typeDesc, num)) == 91)
		{
			num++;
		}
		int num2 = MemberResolver.descToType((char)c);
		string jvmClassName = null;
		if (num2 == 307)
		{
			jvmClassName = ((num != 0) ? String.instancehelper_substring(typeDesc, num + 1, String.instancehelper_length(typeDesc) - 1) : String.instancehelper_substring(typeDesc, 1, String.instancehelper_length(typeDesc) - 1));
		}
		Declarator value = new Declarator(num2, jvmClassName, num, varNo, new Symbol(varName));
		tbl.append(varName, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 159, 21, 162, 113, 39 })]
	public virtual int recordParams(CtClass[] @params, bool isStatic, string prefix, string paramVarName, string paramsName, SymbolTable tbl)
	{
		int result = recordParams(@params, isStatic, prefix, paramVarName, paramsName, (!isStatic) ? true : false, 0, getThisName(), tbl);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 13, 133, 103, 104, 104, 104, 135, 100, 141,
		103, 99, 99, 123, 103, 152, 170, 105, 63, 10,
		168, 105, 135
	})]
	public virtual int recordParams(CtClass[] @params, bool isStatic, string prefix, string paramVarName, string paramsName, bool use0, int paramBase, string target, SymbolTable tbl)
	{
		paramTypeList = @params;
		paramArrayName = paramVarName;
		paramListName = paramsName;
		paramVarBase = paramBase;
		useParam0 = use0;
		if (target != null)
		{
			param0Type = MemberResolver.jvmToJavaName(target);
		}
		inStaticMethod = isStatic;
		int num = paramBase;
		if (use0)
		{
			string text = new StringBuilder().append(prefix).append("0").toString();
			string jvmClassName = MemberResolver.javaToJvmName(target);
			int var = num;
			num++;
			Declarator value = new Declarator(307, jvmClassName, 0, var, new Symbol(text));
			tbl.append(text, value);
		}
		for (int i = 0; i < (nint)@params.LongLength; i++)
		{
			num += recordVar(@params[i], new StringBuilder().append(prefix).append(i + 1).toString(), num, tbl);
		}
		if (getMaxLocals() < num)
		{
			setMaxLocals(num);
		}
		return num;
	}

	public virtual void recordType(CtClass t)
	{
		dollarType = t;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 89, 103, 103, 103, 99, 98, 103, 110, 103 })]
	public virtual int recordReturnType(CtClass type, string castName, string resultName, SymbolTable tbl)
	{
		returnType = type;
		returnCastName = castName;
		returnVarName = resultName;
		if (resultName == null)
		{
			return -1;
		}
		int maxLocals = getMaxLocals();
		int maxLocals2 = maxLocals + recordVar(type, resultName, maxLocals, tbl);
		setMaxLocals(maxLocals2);
		return maxLocals;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 185, 99, 98, 103, 109, 103 })]
	public virtual int recordVariable(CtClass type, string varName, SymbolTable tbl)
	{
		if (varName == null)
		{
			return -1;
		}
		int maxLocals = getMaxLocals();
		int maxLocals2 = maxLocals + recordVar(type, varName, maxLocals, tbl);
		setMaxLocals(maxLocals2);
		return maxLocals;
	}

	public virtual void setProceedHandler(ProceedHandler h, string name)
	{
		proceedName = name;
		procHandler = h;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 48, 103, 105, 154, 109, 105, 104 })]
	internal virtual void compileInvokeSpecial(ASTree P_0, int P_1, string P_2, ASTList P_3)
	{
		P_0.accept(this);
		int methodArgsLength = getMethodArgsLength(P_3);
		atMethodArgs(P_3, new int[methodArgsLength], new int[methodArgsLength], new string[methodArgsLength]);
		bytecode.addInvokespecial(P_1, P_2);
		setReturnType(P_2, false, false);
		addNullIfVoid();
	}

	private int indexOfParam1()
	{
		return paramVarBase + (useParam0 ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 80, 150, 107, 103, 107 })]
	private void callGetType(string P_0)
	{
		bytecode.addInvokestatic("javassist/runtime/Desc", P_0, "(Ljava/lang/String;)Ljava/lang/Class;");
		exprType = 307;
		arrayDim = 0;
		className = "java/lang/Class";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		111, 99, 129, 103, 99, 102, 104, 103, 104, 106,
		107, 250, 58, 230, 72
	})]
	protected internal virtual void atAssignParamList(CtClass[] @params, Bytecode code)
	{
		if (@params != null)
		{
			int num = indexOfParam1();
			int num2 = @params.Length;
			for (int i = 0; i < num2; i++)
			{
				code.addOpcode(89);
				code.addIconst(i);
				code.addOpcode(50);
				compileUnwrapValue(@params[i], code);
				code.addStore(num, @params[i]);
				num += ((!CodeGen.is2word(exprType, arrayDim)) ? 1 : 2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 33, 104, 104, 161, 109, 159, 11, 104, 135,
		103, 103, 105, 37, 133, 103, 130, 103, 137
	})]
	protected internal virtual void compileUnwrapValue(CtClass type, Bytecode code)
	{
		if (type == CtClass.voidType)
		{
			addNullIfVoid();
			return;
		}
		if (exprType == 344)
		{
			string s = new StringBuilder().append("invalid type for ").append(returnCastName).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		if (type is CtPrimitiveType)
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)type;
			string wrapperName = ctPrimitiveType.getWrapperName();
			code.addCheckcast(wrapperName);
			code.addInvokevirtual(wrapperName, ctPrimitiveType.getGetMethodName(), ctPrimitiveType.getGetMethodDescriptor());
			setType(type);
		}
		else
		{
			code.addCheckcast(type);
			setType(type);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 88, 108, 127, 4, 116, 109, 108, 108, 109,
		103, 103, 103, 130, 112
	})]
	protected internal virtual void atCastToRtype(CastExpr expr)
	{
		expr.getOprand().accept(this);
		if (exprType == 344 || CodeGen.isRefType(exprType) || arrayDim > 0)
		{
			compileUnwrapValue(returnType, bytecode);
			return;
		}
		if (returnType is CtPrimitiveType)
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)returnType;
			int num = MemberResolver.descToType(ctPrimitiveType.getDescriptor());
			atNumCastExpr(exprType, num);
			exprType = num;
			arrayDim = 0;
			className = null;
			return;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("invalid cast");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 104, 108, 118, 129, 126, 107, 103, 103, 108,
		109, 105, 143, 141, 109, 124, 57, 165, 107, 103,
		139
	})]
	protected internal virtual void atCastToWrapper(CastExpr expr)
	{
		expr.getOprand().accept(this);
		if (CodeGen.isRefType(exprType) || arrayDim > 0)
		{
			return;
		}
		CtClass ctClass = resolver.lookupClass(exprType, arrayDim, className);
		if (ctClass is CtPrimitiveType)
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)ctClass;
			string wrapperName = ctPrimitiveType.getWrapperName();
			bytecode.addNew(wrapperName);
			bytecode.addOpcode(89);
			if (ctPrimitiveType.getDataSize() > 1)
			{
				bytecode.addOpcode(94);
			}
			else
			{
				bytecode.addOpcode(93);
			}
			bytecode.addOpcode(88);
			bytecode.addInvokespecial(wrapperName, "<init>", new StringBuilder().append("(").append(ctPrimitiveType.getDescriptor()).append(")V")
				.toString());
			exprType = 307;
			arrayDim = 0;
			className = "java/lang/Object";
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 153, 102, 107, 144, 108, 103, 114, 99, 159,
		6, 159, 1, 154, 107, 103, 103
	})]
	protected internal virtual void atCflow(ASTList cname)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (cname == null || cname.tail() != null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("bad $cflow");
		}
		makeCflowName(stringBuilder, cname.head());
		string text = stringBuilder.toString();
		object[] array = resolver.getClassPool().lookupCflow(text);
		if (array == null)
		{
			string s = new StringBuilder().append("no such $cflow: ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		bytecode.addGetstatic((string)array[0], (string)array[1], "Ljavassist/runtime/Cflow;");
		bytecode.addInvokevirtual("javassist.runtime.Cflow", "value", "()I");
		exprType = 324;
		arrayDim = 0;
		className = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 180, 104, 114, 129, 104, 103, 106, 108, 105,
		110, 193
	})]
	private static void makeCflowName(StringBuilder P_0, ASTree P_1)
	{
		if (P_1 is Symbol)
		{
			P_0.append(((Symbol)P_1).get());
			return;
		}
		if (P_1 is Expr)
		{
			Expr expr = (Expr)P_1;
			if (expr.getOperator() == 46)
			{
				makeCflowName(P_0, expr.oprand1());
				P_0.append('.');
				makeCflowName(P_0, expr.oprand2());
				return;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad $cflow");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 60, 106 })]
	public virtual void setType(CtClass type)
	{
		setType(type, 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 221, 103, 98, 99, 103, 123, 104, 172, 132,
		104, 130
	})]
	public override int getMethodArgsLength(ASTList args)
	{
		string anObject = paramListName;
		int num = 0;
		while (args != null)
		{
			ASTree aSTree = args.head();
			if (aSTree is Member && String.instancehelper_equals(((Member)aSTree).get(), anObject))
			{
				if (paramTypeList != null)
				{
					num = (int)(num + (nint)paramTypeList.LongLength);
				}
			}
			else
			{
				num++;
			}
			args = args.tail();
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 241, 103, 103, 98, 102, 103, 127, 2, 102,
		100, 104, 105, 102, 116, 104, 105, 105, 106, 228,
		57, 232, 73, 162, 103, 105, 105, 106, 164, 104,
		101
	})]
	public override void atMethodArgs(ASTList args, int[] types, int[] dims, string[] cnames)
	{
		CtClass[] array = paramTypeList;
		string anObject = paramListName;
		int num = 0;
		while (args != null)
		{
			ASTree aSTree = args.head();
			if (aSTree is Member && String.instancehelper_equals(((Member)aSTree).get(), anObject))
			{
				if (array != null)
				{
					int num2 = array.Length;
					int num3 = indexOfParam1();
					for (int i = 0; i < num2; i++)
					{
						CtClass type = array[i];
						num3 += bytecode.addLoad(num3, type);
						setType(type);
						types[num] = exprType;
						dims[num] = arrayDim;
						cnames[num] = className;
						num++;
					}
				}
			}
			else
			{
				aSTree.accept(this);
				types[num] = exprType;
				dims[num] = arrayDim;
				cnames[num] = className;
				num++;
			}
			args = args.tail();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 196, 104, 107, 103, 173, 135, 191, 0, 105 })]
	private int recordVar(CtClass P_0, string P_1, int P_2, SymbolTable P_3)
	{
		if (P_0 == CtClass.voidType)
		{
			exprType = 307;
			arrayDim = 0;
			className = "java/lang/Object";
		}
		else
		{
			setType(P_0);
		}
		Declarator value = new Declarator(exprType, className, arrayDim, P_2, new Symbol(P_1));
		P_3.append(P_1, value);
		return (!CodeGen.is2word(exprType, arrayDim)) ? 1 : 2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		162, 64, 104, 103, 113, 103, 103, 101, 136, 218,
		2, 97, 191, 11, 107, 103, 145
	})]
	private void setType(CtClass P_0, int P_1)
	{
		if (P_0.isPrimitive())
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)P_0;
			exprType = MemberResolver.descToType(ctPrimitiveType.getDescriptor());
			arrayDim = P_1;
			className = null;
			return;
		}
		if (P_0.isArray())
		{
			try
			{
				setType(P_0.getComponentType(), P_1 + 1);
				return;
			}
			catch (NotFoundException)
			{
			}
			_ = null;
			string s = new StringBuilder().append("undefined type: ").append(P_0.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		exprType = 307;
		arrayDim = P_1;
		className = MemberResolver.javaToJvmName(P_0.getName());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		46, 103, 110, 120, 107, 103, 144, 109, 124, 154,
		107, 103, 144, 109, 104, 144, 118, 141, 109, 104,
		144, 113, 173, 105
	})]
	public override void atMember(Member mem)
	{
		string @this = mem.get();
		if (String.instancehelper_equals(@this, paramArrayName))
		{
			compileParameterList(bytecode, paramTypeList, indexOfParam1());
			exprType = 307;
			arrayDim = 1;
			className = "java/lang/Object";
		}
		else if (String.instancehelper_equals(@this, "$sig"))
		{
			bytecode.addLdc(Descriptor.ofMethod(returnType, paramTypeList));
			bytecode.addInvokestatic("javassist/runtime/Desc", "getParams", "(Ljava/lang/String;)[Ljava/lang/Class;");
			exprType = 307;
			arrayDim = 1;
			className = "java/lang/Class";
		}
		else if (String.instancehelper_equals(@this, "$type"))
		{
			if (dollarType == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("$type is not available");
			}
			bytecode.addLdc(Descriptor.of(dollarType));
			callGetType("getType");
		}
		else if (String.instancehelper_equals(@this, "$class"))
		{
			if (param0Type == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("$class is not available");
			}
			bytecode.addLdc(param0Type);
			callGetType("getClazz");
		}
		else
		{
			base.atMember(mem);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 107, 99, 113, 117, 101, 159, 11, 104, 118,
		159, 11, 114, 99, 175, 110
	})]
	protected internal override void atFieldAssign(Expr expr, int op, ASTree left, ASTree right, bool doDup)
	{
		if (left is Member && String.instancehelper_equals(((Member)left).get(), paramArrayName))
		{
			if (op != 61)
			{
				string s = new StringBuilder().append("bad operator for ").append(paramArrayName).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError(s);
			}
			right.accept(this);
			if (arrayDim != 1 || exprType != 307)
			{
				string s2 = new StringBuilder().append("invalid type for ").append(paramArrayName).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError(s2);
			}
			atAssignParamList(paramTypeList, bytecode);
			if (!doDup)
			{
				bytecode.addOpcode(87);
			}
		}
		else
		{
			base.atFieldAssign(expr, op, left, right, doDup);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 64, 103, 110, 103, 112, 108, 110, 105, 129,
		109, 105, 225, 69, 105
	})]
	public override void atCastExpr(CastExpr expr)
	{
		ASTList aSTList = expr.getClassName();
		if (aSTList != null && expr.getArrayDim() == 0)
		{
			ASTree aSTree = aSTList.head();
			if (aSTree is Symbol && aSTList.tail() == null)
			{
				string @this = ((Symbol)aSTree).get();
				if (String.instancehelper_equals(@this, returnCastName))
				{
					atCastToRtype(expr);
					return;
				}
				if (String.instancehelper_equals(@this, "$w"))
				{
					atCastToWrapper(expr);
					return;
				}
			}
		}
		base.atCastExpr(expr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 134, 103, 104, 108, 118, 127, 0, 129, 109,
		115, 193, 105
	})]
	public override void atCallExpr(CallExpr expr)
	{
		ASTree aSTree = expr.oprand1();
		if (aSTree is Member)
		{
			string @this = ((Member)aSTree).get();
			if (procHandler != null && String.instancehelper_equals(@this, proceedName))
			{
				procHandler.doit(this, bytecode, (ASTList)expr.oprand2());
				return;
			}
			if (String.instancehelper_equals(@this, "$cflow"))
			{
				atCflow((ASTList)expr.oprand2());
				return;
			}
		}
		base.atCallExpr(expr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 201, 108, 103, 103, 110, 54, 161 })]
	public virtual bool isParamListName(ASTList args)
	{
		if (paramTypeList != null && args != null && args.tail() == null)
		{
			ASTree aSTree = args.head();
			return (aSTree is Member && String.instancehelper_equals(((Member)aSTree).get(), paramListName)) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 62, 103, 112, 103, 115, 111, 109, 141, 162,
		105
	})]
	protected internal override void atReturnStmnt(Stmnt st)
	{
		ASTree aSTree = st.getLeft();
		if (aSTree != null && returnType == CtClass.voidType)
		{
			compileExpr(aSTree);
			if (CodeGen.is2word(exprType, arrayDim))
			{
				bytecode.addOpcode(88);
			}
			else if (exprType != 344)
			{
				bytecode.addOpcode(87);
			}
			aSTree = null;
		}
		atReturnStmnt2(aSTree);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 87, 117, 104, 103, 104, 42, 133, 130, 112 })]
	public virtual void doNumCast(CtClass type)
	{
		if (arrayDim == 0 && !CodeGen.isRefType(exprType))
		{
			if (!(type is CtPrimitiveType))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("type mismatch");
			}
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)type;
			atNumCastExpr(exprType, MemberResolver.descToType(ctPrimitiveType.getDescriptor()));
		}
	}

	[HideFromJava]
	static JvstCodeGen()
	{
		MemberCodeGen.___003Cclinit_003E();
	}
}
