using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javassist.bytecode;
using javassist.compiler.ast;

namespace javassist.compiler;

public class MemberCodeGen : CodeGen
{
	internal class JsrHook : ReturnHook
	{
		[IKVM.Attributes.Signature("Ljava/util/List<[I>;")]
		internal List jsrList;

		internal CodeGen cgen;

		internal int var;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 68, 105, 107, 103, 103 })]
		internal JsrHook(CodeGen P_0)
			: base(P_0)
		{
			jsrList = new ArrayList();
			cgen = P_0;
			var = -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 84, 107, 127, 5, 105 })]
		private void jsrJmp(Bytecode P_0)
		{
			P_0.addOpcode(167);
			jsrList.add(new int[2]
			{
				P_0.currentPc(),
				var
			});
			P_0.addIndex(0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 75, 105, 113, 172 })]
		private int getVar(int P_0)
		{
			if (var < 0)
			{
				var = cgen.getMaxLocals();
				cgen.incMaxLocals(P_0);
			}
			return var;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			91, 159, 10, 103, 133, 109, 103, 108, 133, 109,
			103, 108, 133, 109, 103, 108, 130, 109, 103, 108,
			130, 109, 103, 108, 130, 176
		})]
		protected internal override bool doit(Bytecode P_0, int P_1)
		{
			switch (P_1)
			{
			case 177:
				jsrJmp(P_0);
				break;
			case 176:
				P_0.addAstore(getVar(1));
				jsrJmp(P_0);
				P_0.addAload(var);
				break;
			case 172:
				P_0.addIstore(getVar(1));
				jsrJmp(P_0);
				P_0.addIload(var);
				break;
			case 173:
				P_0.addLstore(getVar(2));
				jsrJmp(P_0);
				P_0.addLload(var);
				break;
			case 175:
				P_0.addDstore(getVar(2));
				jsrJmp(P_0);
				P_0.addDload(var);
				break;
			case 174:
				P_0.addFstore(getVar(1));
				jsrJmp(P_0);
				P_0.addFload(var);
				break;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException("fatal");
			}
			return false;
		}
	}

	internal class JsrHook2 : ReturnHook
	{
		internal int var;

		internal int target;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 69, 105, 105, 105 })]
		internal JsrHook2(CodeGen P_0, int[] P_1)
			: base(P_0)
		{
			target = P_1[0];
			var = P_1[1];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 76, 159, 7, 130, 108, 130, 108, 130, 108,
			130, 108, 130, 108, 130, 176, 107, 117
		})]
		protected internal override bool doit(Bytecode P_0, int P_1)
		{
			switch (P_1)
			{
			case 176:
				P_0.addAstore(var);
				break;
			case 172:
				P_0.addIstore(var);
				break;
			case 173:
				P_0.addLstore(var);
				break;
			case 175:
				P_0.addDstore(var);
				break;
			case 174:
				P_0.addFstore(var);
				break;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException("fatal");
			case 177:
				break;
			}
			P_0.addOpcode(167);
			P_0.addIndex(target - P_0.currentPc() + 3);
			return true;
		}
	}

	protected internal MemberResolver resolver;

	protected internal CtClass thisClass;

	protected internal MethodInfo thisMethod;

	protected internal bool resultStatic;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	public virtual CtClass getThisClass()
	{
		return thisClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 164, 22, 103, 99, 137, 98, 108, 99, 125, 201 })]
	public virtual CtClass[] makeParamList(MethodDecl md)
	{
		ASTList aSTList = md.getParams();
		CtClass[] array;
		if (aSTList == null)
		{
			array = new CtClass[0];
		}
		else
		{
			int num = 0;
			array = new CtClass[aSTList.length()];
			while (aSTList != null)
			{
				CtClass[] array2 = array;
				int num2 = num;
				num++;
				array2[num2] = resolver.lookupClass((Declarator)aSTList.head());
				aSTList = aSTList.tail();
			}
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 164, 39, 103, 99, 98, 98, 108, 99, 125, 169 })]
	public virtual CtClass[] makeThrowsList(MethodDecl md)
	{
		ASTList aSTList = md.getThrows();
		if (aSTList == null)
		{
			return null;
		}
		int num = 0;
		CtClass[] array = new CtClass[aSTList.length()];
		while (aSTList != null)
		{
			int num2 = num;
			num++;
			array[num2] = resolver.lookupClassByName((ASTList)aSTList.head());
			aSTList = aSTList.tail();
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 108, 104, 115 })]
	public virtual void setThisMethod(CtMethod m)
	{
		thisMethod = m.getMethodInfo2();
		if (typeChecker != null)
		{
			typeChecker.setThisMethod(thisMethod);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[IKVM.Attributes.Signature("(Ljava/util/List<[I>;Ljavassist/compiler/ast/Stmnt;)V")]
	[LineNumberTable(new byte[]
	{
		160, 192, 103, 126, 100, 113, 105, 103, 104, 104,
		107, 144, 101
	})]
	private void addFinally(List P_0, Stmnt P_1)
	{
		Bytecode bytecode = base.bytecode;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			int[] array = (int[])iterator.next();
			int num = array[0];
			bytecode.write16bit(num, bytecode.currentPc() - num + 1);
			JsrHook2 jsrHook = new JsrHook2(this, array);
			P_1.accept(this);
			jsrHook.remove(this);
			if (!hasReturned)
			{
				bytecode.addOpcode(167);
				bytecode.addIndex(num + 3 - bytecode.currentPc());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 227, 103, 103, 103, 103, 105, 99, 208, 107,
		161, 104, 116
	})]
	public virtual void atNewArrayExpr(NewExpr expr)
	{
		int arrayType = expr.getArrayType();
		ASTList arraySize = expr.getArraySize();
		ASTList aSTList = expr.getClassName();
		ArrayInit initializer = expr.getInitializer();
		if (arraySize.length() > 1)
		{
			if (initializer != null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("sorry, multi-dimensional array initializer for new is not supported");
			}
			atMultiNewArray(arrayType, aSTList, arraySize);
		}
		else
		{
			ASTree aSTree = arraySize.head();
			atNewArrayExpr2(arrayType, aSTree, Declarator.astToClassName(aSTList, '/'), initializer);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 252, 166, 104, 103, 104, 136, 112, 109, 194,
		172, 140, 100, 191, 1, 132, 109, 137, 127, 1,
		145, 173, 144
	})]
	public virtual void atMethodCallCore(CtClass targetClass, string mname, ASTList args, bool isStatic, bool isSpecial, int aload0pos, MemberResolver.Method found)
	{
		int num = (isStatic ? 1 : 0);
		int methodArgsLength = getMethodArgsLength(args);
		int[] array = new int[methodArgsLength];
		int[] array2 = new int[methodArgsLength];
		string[] array3 = new string[methodArgsLength];
		if (num == 0 && found != null && found.isStatic())
		{
			bytecode.addOpcode(87);
			num = 1;
		}
		bytecode.getStackDepth();
		atMethodArgs(args, array, array2, array3);
		if (found == null)
		{
			found = resolver.lookupMethod(targetClass, thisClass, thisMethod, mname, array, array2, array3);
		}
		if (found == null)
		{
			string s = ((!String.instancehelper_equals(mname, "<init>")) ? new StringBuilder().append("Method ").append(mname).append(" not found in ")
				.append(targetClass.getName())
				.toString() : "constructor not found");
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		atMethodCallCore2(targetClass, mname, (byte)num != 0, isSpecial, aload0pos, found);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 85, 103, 101, 103, 99, 130, 100, 103, 109,
		240, 56, 234, 76, 103, 103, 104, 109, 175, 136,
		110
	})]
	protected internal virtual void atMultiNewArray(int type, ASTList classname, ASTList size)
	{
		int dim = size.length();
		int num = 0;
		while (size != null)
		{
			ASTree aSTree = size.head();
			if (aSTree == null)
			{
				break;
			}
			num++;
			aSTree.accept(this);
			if (exprType != 324)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("bad type for array size");
			}
			size = size.tail();
		}
		exprType = type;
		arrayDim = dim;
		string desc;
		if (type == 307)
		{
			className = resolveClassName(classname);
			desc = CodeGen.toJvmArrayName(className, dim);
		}
		else
		{
			desc = CodeGen.toJvmTypeName(type, dim);
		}
		bytecode.addMultiNewarray(desc, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 247, 100, 99, 144, 137, 99, 104, 108, 130,
		176, 104, 104, 182, 98, 98, 159, 67, 98, 130,
		98, 130, 98, 130, 98, 130, 98, 130, 99, 130,
		99, 130, 99, 130, 197, 112, 172, 103, 104, 99,
		104, 109, 109, 108, 104, 141, 114, 231, 56, 232,
		76, 103, 103, 103
	})]
	private void atNewArrayExpr2(int P_0, ASTree P_1, string P_2, ArrayInit P_3)
	{
		if (P_3 == null)
		{
			if (P_1 == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("no array size");
			}
			P_1.accept(this);
		}
		else
		{
			if (P_1 != null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("unnecessary array size specified for new");
			}
			int n = P_3.size();
			bytecode.addIconst(n);
		}
		string classname;
		if (P_0 == 307)
		{
			classname = resolveClassName(P_2);
			bytecode.addAnewarray(MemberResolver.jvmToJavaName(classname));
		}
		else
		{
			classname = null;
			int code = 0;
			switch (P_0)
			{
			case 301:
				code = 4;
				break;
			case 306:
				code = 5;
				break;
			case 317:
				code = 6;
				break;
			case 312:
				code = 7;
				break;
			case 303:
				code = 8;
				break;
			case 334:
				code = 9;
				break;
			case 324:
				code = 10;
				break;
			case 326:
				code = 11;
				break;
			default:
				badNewExpr();
				break;
			}
			bytecode.addOpcode(188);
			bytecode.add(code);
		}
		if (P_3 != null)
		{
			int code = P_3.size();
			ASTList aSTList = P_3;
			for (int i = 0; i < code; i++)
			{
				bytecode.addOpcode(89);
				bytecode.addIconst(i);
				aSTList.head().accept(this);
				if (!CodeGen.isRefType(P_0))
				{
					atNumCastExpr(exprType, P_0);
				}
				bytecode.addOpcode(CodeGen.getArrayWriteOp(P_0, 0));
				aSTList = aSTList.tail();
			}
		}
		exprType = P_0;
		arrayDim = 1;
		className = classname;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(1205)]
	protected internal override string resolveClassName(string jvmName)
	{
		string result = resolver.resolveJvmClassName(jvmName);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(437)]
	private static void badNewExpr()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad new expression");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(1197)]
	protected internal override string resolveClassName(ASTList name)
	{
		string result = resolver.resolveClassName(name);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(573)]
	private static void badMethod()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad method");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(771)]
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
		162, 150, 98, 99, 103, 103, 105, 105, 106, 100,
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
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 238, 69, 104, 104, 104, 136, 112, 98, 100,
		159, 11, 120, 119, 106, 108, 209, 105, 105, 132,
		98, 98, 100, 102, 175, 107, 207, 99, 102, 227,
		70, 98, 101, 144, 163, 148, 99, 148, 110, 109,
		130, 104, 107, 113, 130, 99, 159, 6, 175, 109
	})]
	private void atMethodCallCore2(CtClass P_0, string P_1, bool P_2, bool P_3, int P_4, MemberResolver.Method P_5)
	{
		int num = (P_2 ? 1 : 0);
		int num2 = (P_3 ? 1 : 0);
		CtClass ctClass = P_5.declaring;
		MethodInfo info = P_5.info;
		string text = info.getDescriptor();
		int num3 = info.getAccessFlags();
		if (String.instancehelper_equals(P_1, "<init>"))
		{
			num2 = 1;
			if (ctClass != P_0)
			{
				string s = new StringBuilder().append("no such constructor: ").append(P_0.getName()).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError(s);
			}
			if (ctClass != thisClass && AccessFlag.isPrivate(num3) && (ctClass.getClassFile().getMajorVersion() < 52 || !isFromSameDeclaringClass(ctClass, thisClass)))
			{
				text = getAccessibleConstructor(text, ctClass, info);
				bytecode.addOpcode(1);
			}
		}
		else if (AccessFlag.isPrivate(num3))
		{
			if (ctClass == thisClass)
			{
				num2 = 1;
			}
			else
			{
				num2 = 0;
				num = 1;
				string desc = text;
				if ((num3 & 8) == 0)
				{
					text = Descriptor.insertParameter(ctClass.getName(), desc);
				}
				num3 = AccessFlag.setPackage(num3) | 8;
				P_1 = getAccessiblePrivate(P_1, desc, text, info, ctClass);
			}
		}
		int num4 = 0;
		if (((uint)num3 & 8u) != 0)
		{
			if (num == 0)
			{
				num = 1;
				if (P_4 >= 0)
				{
					bytecode.write(P_4, 0);
				}
				else
				{
					num4 = 1;
				}
			}
			bytecode.addInvokestatic(ctClass, P_1, text);
		}
		else if (num2 != 0)
		{
			bytecode.addInvokespecial(P_0, P_1, text);
		}
		else
		{
			if (!Modifier.isPublic(ctClass.getModifiers()) || ctClass.isInterface() != P_0.isInterface())
			{
				ctClass = P_0;
			}
			if (ctClass.isInterface())
			{
				int count = Descriptor.paramSize(text) + 1;
				bytecode.addInvokeinterface(ctClass, P_1, text, count);
			}
			else
			{
				if (num != 0)
				{
					string s2 = new StringBuilder().append(P_1).append(" is not static").toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CompileError(s2);
				}
				bytecode.addInvokevirtual(ctClass, P_1, text);
			}
		}
		setReturnType(text, (byte)num != 0, (byte)num4 != 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 134, 99, 104, 100, 180, 99 })]
	private bool isEnclosing(CtClass P_0, CtClass P_1)
	{
		//Discarded unreachable code: IL_0014
		try
		{
			while (P_1 != null)
			{
				P_1 = P_1.getDeclaringClass();
				if (P_1 == P_0)
				{
					return true;
				}
			}
		}
		catch (NotFoundException)
		{
			goto IL_001f;
		}
		goto IL_0026;
		IL_001f:
		_ = null;
		goto IL_0026;
		IL_0026:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 254, 99, 106, 100, 181, 99 })]
	private bool isFromSameDeclaringClass(CtClass P_0, CtClass P_1)
	{
		try
		{
			while (P_0 != null)
			{
				if (isEnclosing(P_0, P_1))
				{
					return true;
				}
				P_0 = P_0.getDeclaringClass();
			}
		}
		catch (NotFoundException)
		{
			goto IL_0023;
		}
		goto IL_0029;
		IL_0023:
		_ = null;
		goto IL_0029;
		IL_0029:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 122, 111, 103, 99, 172, 112 })]
	protected internal virtual string getAccessibleConstructor(string desc, CtClass declClass, MethodInfo minfo)
	{
		if (isEnclosing(declClass, thisClass))
		{
			AccessorMaker accessorMaker = declClass.getAccessorMaker();
			if (accessorMaker != null)
			{
				string constructor = accessorMaker.getConstructor(declClass, desc, minfo);
				_ = null;
				return constructor;
			}
		}
		string s = new StringBuilder().append("the called constructor is private in ").append(declClass.getName()).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 162, 98, 112, 104, 99, 206 })]
	protected internal virtual string getAccessiblePrivate(string methodName, string desc, string newDesc, MethodInfo minfo, CtClass declClass)
	{
		if (isEnclosing(declClass, thisClass))
		{
			AccessorMaker accessorMaker = declClass.getAccessorMaker();
			if (accessorMaker != null)
			{
				string methodAccessor = accessorMaker.getMethodAccessor(methodName, desc, newDesc, minfo);
				_ = null;
				return methodAccessor;
			}
		}
		string s = new StringBuilder().append("Method ").append(methodName).append(" is private")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 201, 164, 105, 100, 133, 108, 99, 101, 102,
		174, 104, 101, 109, 101, 133, 107, 113, 130, 108,
		167, 104, 102, 99, 107, 109, 109, 143, 105, 143,
		109, 207
	})]
	internal virtual void setReturnType(string P_0, bool P_1, bool P_2)
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
		int num4;
		if (num2 == 76)
		{
			num4 = String.instancehelper_indexOf(P_0, 59, num + 1);
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
		num4 = exprType;
		if (P_1 && P_2)
		{
			if (CodeGen.is2word(num4, num3))
			{
				bytecode.addOpcode(93);
				bytecode.addOpcode(88);
				bytecode.addOpcode(87);
			}
			else if (num4 == 344)
			{
				bytecode.addOpcode(87);
			}
			else
			{
				bytecode.addOpcode(95);
				bytecode.addOpcode(87);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 131, 130, 107, 108, 130, 248, 69, 226, 61,
		129, 173, 108, 99, 104, 191, 6, 140, 103, 130,
		107, 104, 105, 230, 69, 121, 42, 135, 103, 131,
		105, 131, 237, 69, 117, 110, 42, 137, 110, 123,
		133, 133, 110, 100, 141, 104, 159, 1, 98, 112,
		232, 70, 110, 105, 114, 103, 195, 101, 130, 133,
		103
	})]
	protected internal virtual CtField fieldAccess(ASTree expr, bool acceptLength)
	{
		//Discarded unreachable code: IL_0197
		string text;
		if (expr is Member)
		{
			text = ((Member)expr).get();
			_ = null;
			CtField field;
			try
			{
				field = thisClass.getField(text);
			}
			catch (NotFoundException)
			{
				goto IL_0030;
			}
			int num = (Modifier.isStatic(field.getModifiers()) ? 1 : 0);
			if (num == 0)
			{
				if (inStaticMethod)
				{
					string s = new StringBuilder().append("not available in a static method: ").append(text).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CompileError(s);
				}
				bytecode.addAload(0);
			}
			resultStatic = (byte)num != 0;
			return field;
		}
		if (expr is Expr)
		{
			Expr expr2 = (Expr)expr;
			switch (expr2.getOperator())
			{
			case 35:
			{
				CtField ctField = resolver.lookupField(((Symbol)expr2.oprand1()).get(), (Symbol)expr2.oprand2());
				resultStatic = true;
				return ctField;
			}
			case 46:
			{
				CtField ctField = null;
				NoFieldException ex2;
				try
				{
					expr2.oprand1().accept(this);
					if (exprType == 307 && arrayDim == 0)
					{
						ctField = resolver.lookupFieldByJvmName(className, (Symbol)expr2.oprand2());
					}
					else
					{
						if (acceptLength && arrayDim > 0 && String.instancehelper_equals(((Symbol)expr2.oprand2()).get(), "length"))
						{
							return null;
						}
						badLvalue();
					}
					int num2 = (Modifier.isStatic(ctField.getModifiers()) ? 1 : 0);
					if (num2 != 0)
					{
						bytecode.addOpcode(87);
					}
					resultStatic = (byte)num2 != 0;
					return ctField;
				}
				catch (NoFieldException x)
				{
					ex2 = ByteCodeHelper.MapException<NoFieldException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
				NoFieldException ex3 = ex2;
				if (ex3.getExpr() != expr2.oprand1())
				{
					throw Throwable.___003Cunmap_003E(ex3);
				}
				Symbol fieldSym = (Symbol)expr2.oprand2();
				string field2 = ex3.getField();
				ctField = resolver.lookupFieldByJvmName2(field2, fieldSym, expr);
				resultStatic = true;
				return ctField;
			}
			}
			badLvalue();
		}
		else
		{
			badLvalue();
		}
		resultStatic = false;
		return null;
		IL_0030:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoFieldException(text, expr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 118, 135, 98, 98, 104, 101, 100, 174, 103,
		140, 101, 156, 135, 115
	})]
	private bool setFieldType(FieldInfo P_0)
	{
		string descriptor = P_0.getDescriptor();
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
		return (num2 == 0 && (num3 == 74 || num3 == 68)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 97, 113, 112, 103, 111, 103, 99, 130, 127,
		6, 191, 5
	})]
	private AccessorMaker isAccessibleField(CtField P_0, FieldInfo P_1)
	{
		if (AccessFlag.isPrivate(P_1.getAccessFlags()) && P_0.getDeclaringClass() != thisClass)
		{
			CtClass declaringClass = P_0.getDeclaringClass();
			if (isEnclosing(declaringClass, thisClass))
			{
				AccessorMaker accessorMaker = declaringClass.getAccessorMaker();
				if (accessorMaker != null)
				{
					return accessorMaker;
				}
			}
			string s = new StringBuilder().append("Field ").append(P_0.getName()).append(" in ")
				.append(declaringClass.getName())
				.append(" is private.")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(s);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 141, 108, 108, 104, 103, 104 })]
	private int addFieldrefInfo(CtField P_0, FieldInfo P_1)
	{
		ConstPool constPool = bytecode.getConstPool();
		string name = P_0.getDeclaringClass().getName();
		int classInfo = constPool.addClassInfo(name);
		string name2 = P_1.getName();
		string descriptor = P_1.getDescriptor();
		int result = constPool.addFieldrefInfo(classInfo, name2, descriptor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 161, 66, 103, 104, 105, 99, 106, 117, 37,
		133, 130, 106, 99, 112, 180, 112, 178, 109
	})]
	private int atFieldRead(CtField P_0, bool P_1)
	{
		FieldInfo fieldInfo = P_0.getFieldInfo2();
		int num = (setFieldType(fieldInfo) ? 1 : 0);
		AccessorMaker accessorMaker = isAccessibleField(P_0, fieldInfo);
		if (accessorMaker != null)
		{
			MethodInfo fieldGetter = accessorMaker.getFieldGetter(fieldInfo, P_1);
			bytecode.addInvokestatic(P_0.getDeclaringClass(), fieldGetter.getName(), fieldGetter.getDescriptor());
			return 0;
		}
		int num2 = addFieldrefInfo(P_0, fieldInfo);
		if (P_1)
		{
			bytecode.add(178);
			bytecode.growStack((num == 0) ? 1 : 2);
		}
		else
		{
			bytecode.add(180);
			bytecode.growStack((num != 0) ? 1 : 0);
		}
		bytecode.addIndex(num2);
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 177, 69, 99, 99, 112, 181, 112, 180, 174,
		103, 135, 104, 107, 112, 37, 167
	})]
	private void atFieldAssignCore(CtField P_0, bool P_1, int P_2, bool P_3)
	{
		if (P_2 != 0)
		{
			if (P_1)
			{
				bytecode.add(179);
				bytecode.growStack((!P_3) ? (-1) : (-2));
			}
			else
			{
				bytecode.add(181);
				bytecode.growStack((!P_3) ? (-2) : (-3));
			}
			bytecode.addIndex(P_2);
		}
		else
		{
			CtClass declaringClass = P_0.getDeclaringClass();
			AccessorMaker accessorMaker = declaringClass.getAccessorMaker();
			FieldInfo fieldInfo = P_0.getFieldInfo2();
			MethodInfo fieldSetter = accessorMaker.getFieldSetter(fieldInfo, P_1);
			bytecode.addInvokestatic(declaringClass, fieldSetter.getName(), fieldSetter.getDescriptor());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		163, 35, 105, 99, 105, 161, 103, 103, 99, 139,
		103, 141
	})]
	protected internal override void atFieldRead(ASTree expr)
	{
		CtField ctField = fieldAccess(expr, acceptLength: true);
		if (ctField == null)
		{
			atArrayLength(expr);
			return;
		}
		int num = (resultStatic ? 1 : 0);
		ASTree constantFieldValue = TypeChecker.getConstantFieldValue(ctField);
		if (constantFieldValue == null)
		{
			atFieldRead(ctField, (byte)num != 0);
			return;
		}
		constantFieldValue.accept(this);
		setFieldType(ctField.getFieldInfo2());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 52, 104, 144, 112, 107, 103 })]
	private void atArrayLength(ASTree P_0)
	{
		if (arrayDim == 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError(".length applied to a non array");
		}
		bytecode.addOpcode(190);
		exprType = 324;
		arrayDim = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 108, 99, 102 })]
	public virtual int getMajorVersion()
	{
		ClassFile classFile = thisClass.getClassFile2();
		if (classFile == null)
		{
			return ClassFile.___003C_003EMAJOR_VERSION;
		}
		int majorVersion = classFile.getMajorVersion();
		_ = null;
		return majorVersion;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(1155)]
	private static void badLvalue()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("bad l-value");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 10, 105, 108, 103, 103 })]
	public MemberCodeGen(Bytecode b, CtClass cc, ClassPool cp)
		: base(b)
	{
		resolver = new MemberResolver(cp);
		thisClass = cc;
		thisMethod = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(93)]
	protected internal override string getThisName()
	{
		string result = MemberResolver.javaToJvmName(thisClass.getName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 51, 102, 42 })]
	protected internal override string getSuperName()
	{
		string result = MemberResolver.javaToJvmName(MemberResolver.getSuperclass(thisClass).getName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 57, 108, 159, 3 })]
	protected internal override void insertDefaultSuperCall()
	{
		bytecode.addAload(0);
		bytecode.addInvokespecial(MemberResolver.getSuperclass(thisClass), "<init>", "()V");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 106, 103, 108, 99, 129, 113, 118, 135, 99,
		99, 136, 104, 103, 104, 102, 144, 110, 100, 107,
		115, 167, 104, 103, 134, 109, 103, 110, 142, 137,
		116, 115, 114, 103, 104, 103, 100, 136, 104, 107,
		115, 103, 131, 133, 102, 136, 104, 109, 103, 104,
		103, 103, 104, 104, 171, 174, 104, 106, 110, 99,
		100, 137
	})]
	protected internal override void atTryStmnt(Stmnt st)
	{
		Bytecode bytecode = base.bytecode;
		Stmnt stmnt = (Stmnt)st.getLeft();
		if (stmnt == null)
		{
			return;
		}
		ASTList aSTList = (ASTList)st.getRight().getLeft();
		Stmnt stmnt2 = (Stmnt)st.getRight().getRight().getLeft();
		ArrayList arrayList = new ArrayList();
		JsrHook jsrHook = null;
		if (stmnt2 != null)
		{
			jsrHook = new JsrHook(this);
		}
		int num = bytecode.currentPc();
		stmnt.accept(this);
		int num2 = bytecode.currentPc();
		if (num == num2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CompileError("empty try block");
		}
		int num3 = ((!hasReturned) ? 1 : 0);
		if (num3 != 0)
		{
			bytecode.addOpcode(167);
			((List)arrayList).add((object)Integer.valueOf(bytecode.currentPc()));
			bytecode.addIndex(0);
		}
		int maxLocals = getMaxLocals();
		incMaxLocals(1);
		while (aSTList != null)
		{
			Pair pair = (Pair)aSTList.head();
			aSTList = aSTList.tail();
			Declarator declarator = (Declarator)pair.getLeft();
			Stmnt stmnt3 = (Stmnt)pair.getRight();
			declarator.setLocalVar(maxLocals);
			CtClass ctClass = resolver.lookupClassByJvmName(declarator.getClassName());
			declarator.setClassName(MemberResolver.javaToJvmName(ctClass.getName()));
			bytecode.addExceptionHandler(num, num2, bytecode.currentPc(), ctClass);
			bytecode.growStack(1);
			bytecode.addAstore(maxLocals);
			hasReturned = false;
			stmnt3?.accept(this);
			if (!hasReturned)
			{
				bytecode.addOpcode(167);
				((List)arrayList).add((object)Integer.valueOf(bytecode.currentPc()));
				bytecode.addIndex(0);
				num3 = 1;
			}
		}
		int num4;
		if (stmnt2 != null)
		{
			jsrHook.remove(this);
			num4 = bytecode.currentPc();
			bytecode.addExceptionHandler(num, num4, num4, 0);
			bytecode.growStack(1);
			bytecode.addAstore(maxLocals);
			hasReturned = false;
			stmnt2.accept(this);
			if (!hasReturned)
			{
				bytecode.addAload(maxLocals);
				bytecode.addOpcode(191);
			}
			addFinally(jsrHook.jsrList, stmnt2);
		}
		num4 = bytecode.currentPc();
		patchGoto(arrayList, num4);
		hasReturned = ((num3 == 0) ? true : false);
		if (stmnt2 != null && num3 != 0)
		{
			stmnt2.accept(this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 208, 104, 140, 114, 103, 103, 108, 141, 177,
		107, 103, 140
	})]
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
		bytecode.addNew(name);
		bytecode.addOpcode(89);
		atMethodCallCore(ctClass, "<init>", arguments, isStatic: false, isSpecial: true, -1, null);
		exprType = 307;
		arrayDim = 0;
		className = MemberResolver.javaToJvmName(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 73, 109 })]
	protected internal override void atArrayVariableAssign(ArrayInit init, int varType, int varArray, string varClass)
	{
		atNewArrayExpr2(varType, null, varClass, init);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(448)]
	public override void atArrayInit(ArrayInit init)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError("array initializer is not supported");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		161, 112, 98, 98, 103, 108, 99, 99, 131, 104,
		104, 108, 103, 117, 136, 109, 177, 104, 99, 102,
		103, 104, 112, 140, 117, 140, 107, 104, 114, 105,
		102, 104, 118, 136, 105, 105, 105, 100, 99, 142,
		117, 136, 109, 209, 105, 115, 163, 252, 75, 226,
		55, 98, 107, 168, 107, 103, 109, 163, 105, 116,
		109, 148, 133, 130, 101, 130, 133, 145
	})]
	public override void atCallExpr(CallExpr expr)
	{
		string mname = null;
		CtClass ctClass = null;
		ASTree aSTree = expr.oprand1();
		ASTList args = (ASTList)expr.oprand2();
		int isStatic = 0;
		int isSpecial = 0;
		int aload0pos = -1;
		MemberResolver.Method method = expr.getMethod();
		if (aSTree is Member)
		{
			mname = ((Member)aSTree).get();
			ctClass = thisClass;
			if (inStaticMethod || (method != null && method.isStatic()))
			{
				isStatic = 1;
			}
			else
			{
				aload0pos = bytecode.currentPc();
				bytecode.addAload(0);
			}
		}
		else if (aSTree is Keyword)
		{
			isSpecial = 1;
			mname = "<init>";
			ctClass = thisClass;
			if (inStaticMethod)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("a constructor cannot be static");
			}
			bytecode.addAload(0);
			if (((Keyword)aSTree).get() == 336)
			{
				ctClass = MemberResolver.getSuperclass(ctClass);
			}
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
				ctClass = resolver.lookupClass(((Symbol)expr2.oprand1()).get(), notCheckInner: false);
				isStatic = 1;
				break;
			case 46:
			{
				aSTree2 = expr2.oprand1();
				string text = TypeChecker.isDotSuper(aSTree2);
				if (text != null)
				{
					isSpecial = 1;
					ctClass = MemberResolver.getSuperInterface(thisClass, text);
					if (inStaticMethod || (method != null && method.isStatic()))
					{
						isStatic = 1;
						break;
					}
					aload0pos = bytecode.currentPc();
					bytecode.addAload(0);
					break;
				}
				if (aSTree2 is Keyword && ((Keyword)aSTree2).get() == 336)
				{
					isSpecial = 1;
				}
				try
				{
					aSTree2.accept(this);
				}
				catch (NoFieldException x)
				{
					ex = ByteCodeHelper.MapException<NoFieldException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_01d7;
				}
				goto IL_0214;
			}
			default:
				{
					badMethod();
					break;
				}
				IL_0214:
				if (arrayDim > 0)
				{
					ctClass = resolver.lookupClass("java.lang.Object", notCheckInner: true);
				}
				else if (exprType == 307)
				{
					ctClass = resolver.lookupClassByJvmName(className);
				}
				else
				{
					badMethod();
				}
				break;
				IL_01d7:
				ex2 = ex;
				if (ex2.getExpr() != aSTree2)
				{
					throw Throwable.___003Cunmap_003E(ex2);
				}
				exprType = 307;
				arrayDim = 0;
				className = ex2.getField();
				isStatic = 1;
				goto IL_0214;
			}
		}
		else
		{
			CodeGen.fatal();
		}
		atMethodCallCore(ctClass, mname, args, (byte)isStatic != 0, (byte)isSpecial != 0, aload0pos, method);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 189, 131, 105, 103, 104, 173, 101, 103, 104,
		106, 100, 140, 99, 130, 138, 104, 104, 136, 144,
		107, 131, 99, 142, 140, 173, 140, 104, 104, 104
	})]
	protected internal override void atFieldAssign(Expr expr, int op, ASTree left, ASTree right, bool doDup)
	{
		CtField ctField = fieldAccess(left, acceptLength: false);
		int num = (resultStatic ? 1 : 0);
		if (op != 61 && num == 0)
		{
			bytecode.addOpcode(89);
		}
		int num2;
		if (op == 61)
		{
			FieldInfo fieldInfo = ctField.getFieldInfo2();
			setFieldType(fieldInfo);
			AccessorMaker accessorMaker = isAccessibleField(ctField, fieldInfo);
			num2 = ((accessorMaker == null) ? addFieldrefInfo(ctField, fieldInfo) : 0);
		}
		else
		{
			num2 = atFieldRead(ctField, (byte)num != 0);
		}
		int type = exprType;
		int dim = arrayDim;
		string cname = className;
		atAssignCore(expr, op, right, type, dim, cname);
		int num3 = (CodeGen.is2word(type, dim) ? 1 : 0);
		if (doDup)
		{
			int code = ((num == 0) ? ((num3 == 0) ? 90 : 93) : ((num3 == 0) ? 89 : 92));
			bytecode.addOpcode(code);
		}
		atFieldAssignCore(ctField, (byte)num != 0, num2, (byte)num3 != 0);
		exprType = type;
		arrayDim = dim;
		className = cname;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 29, 105 })]
	public override void atMember(Member mem)
	{
		atFieldRead(mem);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 163, 151, 106, 137, 126 })]
	protected internal override void atClassObject2(string cname)
	{
		if (getMajorVersion() < 49)
		{
			base.atClassObject2(cname);
		}
		else
		{
			bytecode.addLdc(bytecode.getConstPool().addClassInfo(cname));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		158, 137, 69, 105, 103, 99, 141, 106, 104, 175,
		99, 142, 140, 109, 110
	})]
	protected internal override void atFieldPlusPlus(int token, bool isPost, ASTree oprand, Expr expr, bool doDup)
	{
		CtField ctField = fieldAccess(oprand, acceptLength: false);
		int num = (resultStatic ? 1 : 0);
		if (num == 0)
		{
			bytecode.addOpcode(89);
		}
		int num2 = atFieldRead(ctField, (byte)num != 0);
		int type = exprType;
		int num3 = (CodeGen.is2word(type, arrayDim) ? 1 : 0);
		int dup_code = ((num == 0) ? ((num3 == 0) ? 90 : 93) : ((num3 == 0) ? 89 : 92));
		atPlusPlusCore(dup_code, doDup, token, isPost, expr);
		atFieldAssignCore(ctField, (byte)num != 0, num2, (byte)num3 != 0);
	}

	[HideFromJava]
	static MemberCodeGen()
	{
		CodeGen.___003Cclinit_003E();
	}
}
