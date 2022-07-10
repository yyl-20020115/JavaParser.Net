using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javassist.bytecode;
using javassist.compiler;

namespace javassist;

public class CtNewMethod : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(50)]
	public static CtMethod make(string src, CtClass declaring)
	{
		CtMethod result = make(src, declaring, null, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		24, 135, 99, 136, 104, 104, 223, 1, 2, 98,
		173
	})]
	public static CtMethod make(string src, CtClass declaring, string delegateObj, string delegateMethod)
	{
		//Discarded unreachable code: IL_002c
		Javac javac = new Javac(declaring);
		CompileError compileError;
		try
		{
			if (delegateMethod != null)
			{
				javac.recordProceed(delegateObj, delegateMethod);
			}
			CtMember ctMember = javac.compile(src);
			if (ctMember is CtMethod)
			{
				return (CtMethod)ctMember;
			}
		}
		catch (CompileError x)
		{
			compileError = ByteCodeHelper.MapException<CompileError>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_003e;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException("not a method");
		IL_003e:
		CompileError e = compileError;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 89, 139, 103, 104, 104, 151, 97 })]
	public static CtMethod make(int modifiers, CtClass returnType, string mname, CtClass[] parameters, CtClass[] exceptions, string body, CtClass declaring)
	{
		//Discarded unreachable code: IL_0025
		NotFoundException ex;
		try
		{
			CtMethod ctMethod = new CtMethod(returnType, mname, parameters, declaring);
			ctMethod.setModifiers(modifiers);
			ctMethod.setExceptionTypes(exceptions);
			ctMethod.setBody(body);
			return ctMethod;
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
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 227, 103, 103, 103, 108, 106, 141, 104, 100,
		102, 42, 165, 106, 109, 104, 136, 100, 108, 173,
		107, 108, 171, 109, 111, 113, 142
	})]
	private static CtMethod delegator0(CtMethod P_0, CtClass P_1)
	{
		MethodInfo methodInfo = P_0.getMethodInfo2();
		string name = methodInfo.getName();
		string descriptor = methodInfo.getDescriptor();
		ConstPool constPool = P_1.getClassFile2().getConstPool();
		MethodInfo methodInfo2 = new MethodInfo(constPool, name, descriptor);
		methodInfo2.setAccessFlags(methodInfo.getAccessFlags());
		ExceptionsAttribute exceptionsAttribute = methodInfo.getExceptionsAttribute();
		if (exceptionsAttribute != null)
		{
			methodInfo2.setExceptionsAttribute((ExceptionsAttribute)exceptionsAttribute.copy(constPool, null));
		}
		Bytecode bytecode = new Bytecode(constPool, 0, 0);
		int num = (Modifier.isStatic(P_0.getModifiers()) ? 1 : 0);
		CtClass declaringClass = P_0.getDeclaringClass();
		CtClass[] parameterTypes = P_0.getParameterTypes();
		int num2;
		if (num != 0)
		{
			num2 = bytecode.addLoadParameters(parameterTypes, 0);
			bytecode.addInvokestatic(declaringClass, name, descriptor);
		}
		else
		{
			bytecode.addLoad(0, declaringClass);
			num2 = bytecode.addLoadParameters(parameterTypes, 1);
			bytecode.addInvokespecial(declaringClass, name, descriptor);
		}
		bytecode.addReturn(P_0.getReturnType());
		num2++;
		bytecode.setMaxLocals(num2);
		bytecode.setMaxStack((num2 >= 2) ? num2 : 2);
		methodInfo2.setCodeAttribute(bytecode.toCodeAttribute());
		CtMethod result = new CtMethod(methodInfo2, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	public CtNewMethod()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(111)]
	public static CtMethod make(CtClass returnType, string mname, CtClass[] parameters, CtClass[] exceptions, string body, CtClass declaring)
	{
		CtMethod result = make(1, returnType, mname, parameters, exceptions, body, declaring);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(168)]
	public static CtMethod copy(CtMethod src, CtClass declaring, ClassMap map)
	{
		CtMethod result = new CtMethod(src, declaring, map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 76, 105, 103 })]
	public static CtMethod copy(CtMethod src, string name, CtClass declaring, ClassMap map)
	{
		CtMethod ctMethod = new CtMethod(src, declaring, map);
		ctMethod.setName(name);
		return ctMethod;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 160, 99, 107, 103 })]
	public static CtMethod abstractMethod(CtClass returnType, string mname, CtClass[] parameters, CtClass[] exceptions, CtClass declaring)
	{
		CtMethod ctMethod = new CtMethod(returnType, mname, parameters, declaring);
		ctMethod.setExceptionTypes(exceptions);
		return ctMethod;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160, 116, 103, 103, 123, 103, 106, 136, 138, 104,
		106, 104, 177, 143, 223, 2, 2, 98, 173, 110,
		136
	})]
	public static CtMethod getter(string methodName, CtField field)
	{
		FieldInfo fieldInfo = field.getFieldInfo2();
		string descriptor = fieldInfo.getDescriptor();
		string desc = new StringBuilder().append("()").append(descriptor).toString();
		ConstPool constPool = fieldInfo.getConstPool();
		MethodInfo methodInfo = new MethodInfo(constPool, methodName, desc);
		methodInfo.setAccessFlags(1);
		Bytecode bytecode = new Bytecode(constPool, 2, 1);
		NotFoundException ex;
		try
		{
			string name = fieldInfo.getName();
			if ((fieldInfo.getAccessFlags() & 8) == 0)
			{
				bytecode.addAload(0);
				bytecode.addGetfield(Bytecode.___003C_003ETHIS, name, descriptor);
			}
			else
			{
				bytecode.addGetstatic(Bytecode.___003C_003ETHIS, name, descriptor);
			}
			bytecode.addReturn(field.getType());
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00a3;
		}
		methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
		CtClass declaringClass = field.getDeclaringClass();
		return new CtMethod(methodInfo, declaringClass);
		IL_00a3:
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		160, 159, 103, 103, 127, 6, 103, 106, 136, 138,
		104, 106, 104, 111, 177, 111, 175, 220, 2, 98,
		173, 110, 136
	})]
	public static CtMethod setter(string methodName, CtField field)
	{
		FieldInfo fieldInfo = field.getFieldInfo2();
		string descriptor = fieldInfo.getDescriptor();
		string desc = new StringBuilder().append("(").append(descriptor).append(")V")
			.toString();
		ConstPool constPool = fieldInfo.getConstPool();
		MethodInfo methodInfo = new MethodInfo(constPool, methodName, desc);
		methodInfo.setAccessFlags(1);
		Bytecode bytecode = new Bytecode(constPool, 3, 3);
		NotFoundException ex;
		try
		{
			string name = fieldInfo.getName();
			if ((fieldInfo.getAccessFlags() & 8) == 0)
			{
				bytecode.addAload(0);
				bytecode.addLoad(1, field.getType());
				bytecode.addPutfield(Bytecode.___003C_003ETHIS, name, descriptor);
			}
			else
			{
				bytecode.addLoad(1, field.getType());
				bytecode.addPutstatic(Bytecode.___003C_003ETHIS, name, descriptor);
			}
			bytecode.addReturn(null);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00c6;
		}
		methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
		CtClass declaringClass = field.getDeclaringClass();
		return new CtMethod(methodInfo, declaringClass);
		IL_00c6:
		NotFoundException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 217, 157, 97 })]
	public static CtMethod delegator(CtMethod @delegate, CtClass declaring)
	{
		//Discarded unreachable code: IL_0009
		NotFoundException ex;
		try
		{
			return delegator0(@delegate, declaring);
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
	[LineNumberTable(480)]
	public static CtMethod wrapped(CtClass returnType, string mname, CtClass[] parameterTypes, CtClass[] exceptionTypes, CtMethod body, CtMethod.ConstParameter constParam, CtClass declaring)
	{
		CtMethod result = CtNewWrappedMethod.wrapped(returnType, mname, parameterTypes, exceptionTypes, body, constParam, declaring);
		_ = null;
		return result;
	}
}
