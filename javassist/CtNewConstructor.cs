using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;

namespace javassist;

public class CtNewConstructor : Object
{
	public const int PASS_NONE = 0;

	public const int PASS_ARRAY = 1;

	public const int PASS_PARAMS = 2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(201)]
	public static CtConstructor make(CtClass[] parameters, CtClass[] exceptions, CtClass declaring)
	{
		CtConstructor result = make(parameters, exceptions, 2, null, null, declaring);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(317)]
	public static CtConstructor make(CtClass[] parameters, CtClass[] exceptions, int howto, CtMethod body, CtMethod.ConstParameter cparam, CtClass declaring)
	{
		CtConstructor result = CtNewWrappedConstructor.wrapped(parameters, exceptions, howto, body, cparam, declaring);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	public CtNewConstructor()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		19,
		135,
		104,
		136,
		byte.MaxValue,
		1,
		69,
		2,
		98,
		173
	})]
	public static CtConstructor make(string src, CtClass declaring)
	{
		//Discarded unreachable code: IL_0021
		Javac javac = new Javac(declaring);
		CompileError compileError;
		try
		{
			CtMember ctMember = javac.compile(src);
			if (ctMember is CtConstructor)
			{
				return (CtConstructor)ctMember;
			}
		}
		catch (CompileError x)
		{
			compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0033;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("not a constructor");
		IL_0033:
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 52, 104, 103, 103, 151, 97 })]
	public static CtConstructor make(CtClass[] parameters, CtClass[] exceptions, string body, CtClass declaring)
	{
		//Discarded unreachable code: IL_0019
		NotFoundException ex;
		try
		{
			CtConstructor ctConstructor = new CtConstructor(parameters, declaring);
			ctConstructor.setExceptionTypes(exceptions);
			ctConstructor.setBody(body);
			return ctConstructor;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(128)]
	public static CtConstructor copy(CtConstructor c, CtClass declaring, ClassMap map)
	{
		CtConstructor result = new CtConstructor(c, declaring, map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		90,
		141,
		108,
		105,
		135,
		byte.MaxValue,
		9,
		69,
		2,
		98,
		173,
		171,
		113
	})]
	public static CtConstructor defaultConstructor(CtClass declaring)
	{
		CtConstructor ctConstructor = new CtConstructor((CtClass[])null, declaring);
		ConstPool constPool = declaring.getClassFile2().getConstPool();
		Bytecode bytecode = new Bytecode(constPool, 1, 1);
		bytecode.addAload(0);
		NotFoundException ex;
		try
		{
			bytecode.addInvokespecial(declaring.getSuperclass(), "<init>", "()V");
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_004e;
		}
		bytecode.add(177);
		ctConstructor.getMethodInfo2().setCodeAttribute(bytecode.toCodeAttribute());
		return ctConstructor;
		IL_004e:
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(182)]
	public static CtConstructor skeleton(CtClass[] parameters, CtClass[] exceptions, CtClass declaring)
	{
		CtConstructor result = make(parameters, exceptions, 0, null, null, declaring);
		_ = null;
		return result;
	}
}
