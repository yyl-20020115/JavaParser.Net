using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;

namespace javassist.expr;

public class Handler : Expr
{
	private static string EXCEPTION_NAME;

	private ExceptionTable etable;

	private int index;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 116, 103, 103 })]
	protected internal Handler(ExceptionTable et, int nth, CodeIterator it, CtClass declaring, MethodInfo m)
		: base(et.handlerPc(nth), it, declaring, m)
	{
		etable = et;
		index = nth;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 40, 114, 99, 98, 103, 104 })]
	public virtual CtClass getType()
	{
		int num = etable.catchType(index);
		if (num == 0)
		{
			return null;
		}
		ConstPool constPool = getConstPool();
		string classInfo = constPool.getClassInfo(num);
		CtClass ctClass = thisClass.getClassPool().getCtClass(classInfo);
		_ = null;
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
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
	[LineNumberTable(82)]
	public override CtClass[] mayThrow()
	{
		CtClass[] result = base.mayThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(102)]
	public virtual bool isFinally()
	{
		return (etable.catchType(index) == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(112)]
	public override void replace(string statement)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("not implemented yet");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		73,
		167,
		103,
		108,
		108,
		103,
		103,
		172,
		103,
		110,
		105,
		104,
		103,
		136,
		115,
		107,
		112,
		40,
		165,
		108,
		140,
		115,
		115,
		byte.MaxValue,
		22,
		71,
		226,
		59,
		98,
		141,
		98,
		141
	})]
	public virtual void insertBefore(string src)
	{
		base.edited = true;
		getConstPool();
		CodeAttribute codeAttribute = iterator.get();
		Javac javac = new Javac(thisClass);
		Bytecode bytecode = javac.getBytecode();
		bytecode.setStackDepth(1);
		bytecode.setMaxLocals(codeAttribute.getMaxLocals());
		NotFoundException ex;
		CompileError compileError;
		try
		{
			try
			{
				CtClass type = getType();
				int n = javac.recordVariable(type, EXCEPTION_NAME);
				javac.recordReturnType(type, useResultVar: false);
				bytecode.addAstore(n);
				javac.compileStmnt(src);
				bytecode.addAload(n);
				int num = etable.handlerPc(index);
				bytecode.addOpcode(167);
				bytecode.addIndex(num - iterator.getCodeLength() - bytecode.currentPc() + 1);
				maxStack = bytecode.getMaxStack();
				maxLocals = bytecode.getMaxLocals();
				int num2 = iterator.append(bytecode.get());
				iterator.append(bytecode.getExceptionTable(), num2);
				etable.setHandlerPc(index, num2);
				return;
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (CompileError x2)
		{
			compileError = ByteCodeHelper.MapException<CompileError>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_011f;
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
		IL_011f:
		CompileError e2 = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e2);
	}

	static Handler()
	{
		EXCEPTION_NAME = "$1";
	}
}
