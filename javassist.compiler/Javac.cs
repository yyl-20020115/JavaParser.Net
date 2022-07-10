using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler.ast;

namespace javassist.compiler;

public class Javac : Object
{
	[SpecialName]
	[IKVM.Attributes.EnclosingMethod(null, "recordProceed", "(Ljava.lang.String;Ljava.lang.String;)V")]
	internal class _1 : Object, ProceedHandler
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024m;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ASTree val_0024texpr;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Javac this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(444)]
		internal _1(Javac P_0, string P_1, ASTree P_2)
		{
			this_00240 = P_0;
			val_0024m = P_1;
			val_0024texpr = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 161, 79, 108, 104, 148, 104, 103, 104 })]
		public virtual void doit(JvstCodeGen P_0, Bytecode P_1, ASTList P_2)
		{
			ASTree aSTree = new Member(val_0024m);
			if (val_0024texpr != null)
			{
				aSTree = Expr.make(46, val_0024texpr, (Member)aSTree);
			}
			CallExpr expr = CallExpr.makeCall(aSTree, P_2);
			P_0.compileExpr(expr);
			P_0.addNullIfVoid();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 161, 92, 108, 104, 148, 104, 103, 104 })]
		public virtual void setReturnType(JvstTypeChecker P_0, ASTList P_1)
		{
			ASTree aSTree = new Member(val_0024m);
			if (val_0024texpr != null)
			{
				aSTree = Expr.make(46, val_0024texpr, (Member)aSTree);
			}
			CallExpr callExpr = CallExpr.makeCall(aSTree, P_1);
			callExpr.accept(P_0);
			P_0.addNullIfVoid();
		}
	}

	[SpecialName]
	[IKVM.Attributes.EnclosingMethod(null, "recordStaticProceed", "(Ljava.lang.String;Ljava.lang.String;)V")]
	internal class _2 : Object, ProceedHandler
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024c;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024m;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Javac this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(490)]
		internal _2(Javac P_0, string P_1, string P_2)
		{
			this_00240 = P_0;
			val_0024c = P_1;
			val_0024m = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 161, 125, 158, 104, 103, 104 })]
		public virtual void doit(JvstCodeGen P_0, Bytecode P_1, ASTList P_2)
		{
			Expr target = Expr.make(35, new Symbol(val_0024c), new Member(val_0024m));
			CallExpr expr = CallExpr.makeCall(target, P_2);
			P_0.compileExpr(expr);
			P_0.addNullIfVoid();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 161, 136, 158, 104, 103, 104 })]
		public virtual void setReturnType(JvstTypeChecker P_0, ASTList P_1)
		{
			Expr target = Expr.make(35, new Symbol(val_0024c), new Member(val_0024m));
			CallExpr callExpr = CallExpr.makeCall(target, P_1);
			callExpr.accept(P_0);
			P_0.addNullIfVoid();
		}
	}

	[SpecialName]
	[IKVM.Attributes.EnclosingMethod(null, "recordSpecialProceed", "(Ljava.lang.String;Ljava.lang.String;Ljava.lang.String;Ljava.lang.String;I)V")]
	internal class _3 : Object, ProceedHandler
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ASTree val_0024texpr;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024methodIndex;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024descriptor;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024classname;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024methodname;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Javac this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[IKVM.Attributes.Signature("()V")]
		[LineNumberTable(536)]
		internal _3(Javac P_0, ASTree P_1, int P_2, string P_3, string P_4, string P_5)
		{
			this_00240 = P_0;
			val_0024texpr = P_1;
			val_0024methodIndex = P_2;
			val_0024descriptor = P_3;
			val_0024classname = P_4;
			val_0024methodname = P_5;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 161, 171, 123 })]
		public virtual void doit(JvstCodeGen P_0, Bytecode P_1, ASTList P_2)
		{
			P_0.compileInvokeSpecial(val_0024texpr, val_0024methodIndex, val_0024descriptor, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 161, 178, 127, 2 })]
		public virtual void setReturnType(JvstTypeChecker P_0, ASTList P_1)
		{
			P_0.compileInvokeSpecial(val_0024texpr, val_0024classname, val_0024methodname, val_0024descriptor, P_1);
		}
	}

	public class CtFieldWithInit : CtField
	{
		private ASTree init;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.CannotCompileException" })]
		[LineNumberTable(new byte[] { 73, 107, 103 })]
		internal CtFieldWithInit(CtClass P_0, string P_1, CtClass P_2)
			: base(P_0, P_1, P_2)
		{
			init = null;
		}

		protected internal virtual void setInit(ASTree i)
		{
			init = i;
		}

		protected internal override ASTree getInitAST()
		{
			return init;
		}
	}

	internal JvstCodeGen gen;

	internal SymbolTable stable;

	private Bytecode bytecode;

	public const string param0Name = "$0";

	public const string resultVarName = "$_";

	public const string proceedName = "$proceed";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 159, 1 })]
	public Javac(CtClass thisClass)
	{
		Bytecode.___003Cclinit_003E();
		this._002Ector(new Bytecode(thisClass.getClassFile2().getConstPool(), 0, 0), thisClass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 70, 113, 109, 130, 233, 92, 115 })]
	public virtual void recordProceed(string target, string method)
	{
		Parser.___003Cclinit_003E();
		Parser parser = new Parser(new Lex(target));
		ASTree aSTree = parser.parseExpression(stable);
		_1 h = new _1(this, method, aSTree);
		gen.setProceedHandler(h, "$proceed");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 86, 103, 179, 104, 113, 174, 134, 105, 137,
		99, 145, 113, 109, 106, 104, 176, 99, 104, 147,
		176, 159, 2, 98
	})]
	public virtual Bytecode compileBody(CtBehavior method, string src)
	{
		//Discarded unreachable code: IL_00e3
		NotFoundException ex;
		try
		{
			int modifiers = method.getModifiers();
			recordParams(method.getParameterTypes(), Modifier.isStatic(modifiers));
			CtClass ctClass;
			if (method is CtMethod)
			{
				gen.setThisMethod((CtMethod)method);
				ctClass = ((CtMethod)method).getReturnType();
			}
			else
			{
				ctClass = CtClass.voidType;
			}
			recordReturnType(ctClass, useResultVar: false);
			int isVoid = ((ctClass == CtClass.voidType) ? 1 : 0);
			if (src == null)
			{
				makeDefaultBody(bytecode, ctClass);
			}
			else
			{
				Parser.___003Cclinit_003E();
				Parser parser = new Parser(new Lex(src));
				SymbolTable tbl = new SymbolTable(stable);
				Stmnt s = parser.parseStatement(tbl);
				if (parser.hasMore())
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CompileError("the method/constructor body must be surrounded by {}");
				}
				int isCons = 0;
				if (method is CtConstructor)
				{
					isCons = ((!((CtConstructor)method).isClassInitializer()) ? 1 : 0);
				}
				gen.atMethodBody(s, (byte)isCons != 0, (byte)isVoid != 0);
			}
			return bytecode;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException @this = ex;
		string s2 = Throwable.instancehelper_toString(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(339)]
	public virtual int recordParams(CtClass[] @params, bool isStatic)
	{
		int result = gen.recordParams(@params, isStatic, "$", "$args", "$$", stable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160,
		194,
		134,
		107,
		99,
		130,
		103,
		102,
		104,
		100,
		byte.MaxValue,
		1,
		61,
		230,
		71
	})]
	public virtual bool recordParamNames(CodeAttribute ca, int numOfLocalVars)
	{
		LocalVariableAttribute localVariableAttribute = (LocalVariableAttribute)ca.getAttribute("LocalVariableTable");
		if (localVariableAttribute == null)
		{
			return false;
		}
		int num = localVariableAttribute.tableLength();
		for (int i = 0; i < num; i++)
		{
			int num2 = localVariableAttribute.index(i);
			if (num2 < numOfLocalVars)
			{
				gen.recordVariable(localVariableAttribute.descriptor(i), localVariableAttribute.variableName(i), num2, stable);
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		160, 164, 134, 107, 99, 130, 103, 105, 104, 105,
		107, 118, 43, 229, 60, 233, 72
	})]
	public virtual bool recordLocalVariables(CodeAttribute ca, int pc)
	{
		LocalVariableAttribute localVariableAttribute = (LocalVariableAttribute)ca.getAttribute("LocalVariableTable");
		if (localVariableAttribute == null)
		{
			return false;
		}
		int num = localVariableAttribute.tableLength();
		for (int i = 0; i < num; i++)
		{
			int num2 = localVariableAttribute.startPc(i);
			int num3 = localVariableAttribute.codeLength(i);
			if (num2 <= pc && pc < num2 + num3)
			{
				gen.recordVariable(localVariableAttribute.descriptor(i), localVariableAttribute.variableName(i), localVariableAttribute.index(i), stable);
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 159, 42, 98, 108, 108, 49 })]
	public virtual int recordReturnType(CtClass type, bool useResultVar)
	{
		gen.recordType(type);
		int result = gen.recordReturnType(type, "$r", (!useResultVar) ? null : "$_", stable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 203, 113, 108, 104, 104, 99, 108, 98 })]
	public virtual void compileStmnt(string src)
	{
		Parser.___003Cclinit_003E();
		Parser parser = new Parser(new Lex(src));
		SymbolTable tbl = new SymbolTable(stable);
		while (parser.hasMore())
		{
			parser.parseStatement(tbl)?.accept(gen);
		}
	}

	public virtual Bytecode getBytecode()
	{
		return bytecode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 23, 104, 120, 107, 103 })]
	public Javac(Bytecode b, CtClass thisClass)
	{
		JvstCodeGen.___003Cclinit_003E();
		gen = new JvstCodeGen(b, thisClass, thisClass.getClassPool());
		stable = new SymbolTable();
		bytecode = b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(425)]
	public virtual int recordVariable(CtClass type, string name)
	{
		int result = gen.recordVariable(type, name, stable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 11, 110 })]
	public virtual void setMaxLocals(int max)
	{
		gen.setMaxLocals(max);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		47, 113, 141, 104, 111, 110, 104, 104, 103, 37,
		133, 159, 13, 98, 146, 98
	})]
	public virtual CtMember compile(string src)
	{
		//Discarded unreachable code: IL_0067
		Parser.___003Cclinit_003E();
		Parser parser = new Parser(new Lex(src));
		ASTList aSTList = parser.parseMember1(stable);
		BadBytecode badBytecode;
		CannotCompileException ex;
		try
		{
			try
			{
				if (aSTList is FieldDecl)
				{
					return compileField((FieldDecl)aSTList);
				}
				CtBehavior ctBehavior = compileMethod(parser, (MethodDecl)aSTList);
				CtClass declaringClass = ctBehavior.getDeclaringClass();
				ctBehavior.getMethodInfo2().rebuildStackMapIf6(declaringClass.getClassPool(), declaringClass.getClassFile2());
				return ctBehavior;
			}
			catch (BadBytecode x)
			{
				badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (CannotCompileException x2)
		{
			ex = ByteCodeHelper.MapException<CannotCompileException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_008b;
		}
		BadBytecode @this = badBytecode;
		string s = Throwable.instancehelper_getMessage(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
		IL_008b:
		CannotCompileException this2 = ex;
		string s2 = Throwable.instancehelper_getMessage(this2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 222, 109, 105 })]
	public virtual void compileExpr(string src)
	{
		ASTree e = parseExpr(src, stable);
		compileExpr(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 232, 113 })]
	public static ASTree parseExpr(string src, SymbolTable st)
	{
		Parser.___003Cclinit_003E();
		Parser parser = new Parser(new Lex(src));
		ASTree result = parser.parseExpression(st);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 246, 99, 110 })]
	public virtual void compileExpr(ASTree e)
	{
		if (e != null)
		{
			gen.compileExpr(e);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 89, 103, 114, 123, 113, 104, 140 })]
	private CtField compileField(FieldDecl P_0)
	{
		Declarator declarator = P_0.getDeclarator();
		CtFieldWithInit ctFieldWithInit = new CtFieldWithInit(gen.resolver.lookupClass(declarator), declarator.getVariable().get(), gen.getThisClass());
		ctFieldWithInit.setModifiers(MemberResolver.getModifiers(P_0.getModifiers()));
		if (P_0.getInit() != null)
		{
			ctFieldWithInit.setInit(P_0.getInit());
		}
		return ctFieldWithInit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		102, 108, 109, 109, 110, 143, 104, 103, 107, 103,
		108, 108, 37, 133, 103, 136, 104, 116, 106, 117,
		108, 104, 109, 108, 104, 109, 37, 167, 142, 104,
		159, 1, 98
	})]
	private CtBehavior compileMethod(Parser P_0, MethodDecl P_1)
	{
		//Discarded unreachable code: IL_0138
		int modifiers = MemberResolver.getModifiers(P_1.getModifiers());
		CtClass[] array = gen.makeParamList(P_1);
		CtClass[] exceptionTypes = gen.makeThrowsList(P_1);
		recordParams(array, Modifier.isStatic(modifiers));
		P_1 = P_0.parseMethod2(stable, P_1);
		NotFoundException ex;
		try
		{
			if (P_1.isConstructor())
			{
				CtConstructor ctConstructor = new CtConstructor(array, gen.getThisClass());
				ctConstructor.setModifiers(modifiers);
				P_1.accept(gen);
				ctConstructor.getMethodInfo().setCodeAttribute(bytecode.toCodeAttribute());
				ctConstructor.setExceptionTypes(exceptionTypes);
				return ctConstructor;
			}
			Declarator @return = P_1.getReturn();
			CtClass ctClass = gen.resolver.lookupClass(@return);
			recordReturnType(ctClass, useResultVar: false);
			CtMethod ctMethod = new CtMethod(ctClass, @return.getVariable().get(), array, gen.getThisClass());
			ctMethod.setModifiers(modifiers);
			gen.setThisMethod(ctMethod);
			P_1.accept(gen);
			if (P_1.getBody() != null)
			{
				ctMethod.getMethodInfo().setCodeAttribute(bytecode.toCodeAttribute());
			}
			else
			{
				ctMethod.setModifiers(modifiers | 0x400);
			}
			ctMethod.setExceptionTypes(exceptionTypes);
			return ctMethod;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException @this = ex;
		string s = Throwable.instancehelper_toString(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 127, 107, 103, 103, 104, 101, 104, 101, 104,
		101, 104, 132, 98, 130, 102, 162, 99, 135, 105
	})]
	private static void makeDefaultBody(Bytecode P_0, CtClass P_1)
	{
		int num;
		int num2;
		if (P_1 is CtPrimitiveType)
		{
			CtPrimitiveType ctPrimitiveType = (CtPrimitiveType)P_1;
			num = ctPrimitiveType.getReturnOp();
			num2 = num switch
			{
				175 => 14, 
				174 => 11, 
				173 => 9, 
				177 => 0, 
				_ => 3, 
			};
		}
		else
		{
			num = 176;
			num2 = 1;
		}
		if (num2 != 0)
		{
			P_0.addOpcode(num2);
		}
		P_0.addOpcode(num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(367)]
	public virtual int recordParams(string target, CtClass[] @params, bool use0, int varNo, bool isStatic)
	{
		int result = gen.recordParams(@params, isStatic, "$", "$args", "$$", use0, varNo, target, stable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 43, 110 })]
	public virtual void recordType(CtClass t)
	{
		gen.recordType(t);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 117, 98, 130, 233, 88, 115 })]
	public virtual void recordStaticProceed(string targetClass, string method)
	{
		_2 h = new _2(this, targetClass, method);
		gen.setProceedHandler(h, "$proceed");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 161, 163, 113, 141, 238, 81, 115 })]
	public virtual void recordSpecialProceed(string target, string classname, string methodname, string descriptor, int methodIndex)
	{
		Parser.___003Cclinit_003E();
		Parser parser = new Parser(new Lex(target));
		ASTree aSTree = parser.parseExpression(stable);
		_3 h = new _3(this, aSTree, methodIndex, descriptor, classname, methodname);
		gen.setProceedHandler(h, "$proceed");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 190, 115 })]
	public virtual void recordProceed(ProceedHandler h)
	{
		gen.setProceedHandler(h, "$proceed");
	}
}
