using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;
using javassist.compiler.ast;

namespace javassist.expr;

public class Cast : Expr
{
	internal class ProceedForCast : Object, ProceedHandler
	{
		internal int index;

		internal CtClass retType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 110, 104, 103, 103 })]
		internal ProceedForCast(int P_0, CtClass P_1)
		{
			index = P_0;
			retType = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 119, 106, 208, 121, 107, 108, 110 })]
		public virtual void doit(JvstCodeGen P_0, Bytecode P_1, ASTList P_2)
		{
			if (P_0.getMethodArgsLength(P_2) != 1)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CompileError("$proceed() cannot take more than one parameter for cast");
			}
			P_0.atMethodArgs(P_2, new int[1], new int[1], new string[1]);
			P_1.addOpcode(192);
			P_1.addIndex(index);
			P_0.setType(retType);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "javassist.compiler.CompileError" })]
		[LineNumberTable(new byte[] { 160, 70, 121, 110 })]
		public virtual void setReturnType(JvstTypeChecker P_0, ASTList P_1)
		{
			P_0.atMethodArgs(P_1, new int[1], new int[1], new string[1]);
			P_0.setType(retType);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 32, 103, 103, 111, 104 })]
	public virtual CtClass getType()
	{
		ConstPool constPool = getConstPool();
		int num = currentPos;
		int index = iterator.u16bitAt(num + 1);
		string classInfo = constPool.getClassInfo(index);
		CtClass ctClass = thisClass.getClassPool().getCtClass(classInfo);
		_ = null;
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 109 })]
	protected internal Cast(int pos, CodeIterator i, CtClass declaring, MethodInfo m)
		: base(pos, i, declaring, m)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	public override CtBehavior where()
	{
		CtBehavior result = base.where();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	public override int getLineNumber()
	{
		int lineNumber = base.getLineNumber();
		_ = null;
		return lineNumber;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public override string getFileName()
	{
		string fileName = base.getFileName();
		_ = null;
		return fileName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(97)]
	public override CtClass[] mayThrow()
	{
		CtClass[] result = base.mayThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		60,
		140,
		103,
		103,
		143,
		108,
		108,
		173,
		110,
		104,
		136,
		105,
		108,
		37,
		134,
		107,
		206,
		137,
		104,
		108,
		138,
		105,
		140,
		103,
		140,
		byte.MaxValue,
		18,
		70,
		226,
		60,
		111,
		111,
		97,
		144
	})]
	public override void replace(string statement)
	{
		thisClass.getClassFile();
		getConstPool();
		int num = currentPos;
		int num2 = iterator.u16bitAt(num + 1);
		Javac javac = new Javac(thisClass);
		ClassPool classPool = thisClass.getClassPool();
		CodeAttribute codeAttribute = iterator.get();
		CompileError compileError;
		NotFoundException ex;
		try
		{
			try
			{
				try
				{
					CtClass[] array = new CtClass[1] { classPool.get("java.lang.Object") };
					CtClass type = getType();
					int num3 = codeAttribute.getMaxLocals();
					javac.recordParams("java.lang.Object", array, use0: true, num3, withinStatic());
					int n = javac.recordReturnType(type, useResultVar: true);
					javac.recordProceed(new ProceedForCast(num2, type));
					Expr.checkResultValue(type, statement);
					Bytecode bytecode = javac.getBytecode();
					Expr.storeStack(array, true, num3, bytecode);
					javac.recordLocalVariables(codeAttribute, num);
					bytecode.addConstZero(type);
					bytecode.addStore(n, type);
					javac.compileStmnt(statement);
					bytecode.addLoad(n, type);
					replace0(num, bytecode, 3);
					return;
				}
				catch (CompileError x)
				{
					compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (NotFoundException x2)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_011e;
			}
		}
		catch (BadBytecode)
		{
			goto IL_0122;
		}
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_0122:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("broken method");
		IL_011e:
		NotFoundException e2 = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}
}
