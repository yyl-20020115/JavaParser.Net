using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javassist.bytecode;

namespace javassist.compiler;

public class AccessorMaker : Object
{
	private CtClass clazz;

	private int uniqueNumber;

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljava/lang/String;Ljava/lang/Object;>;")]
	private Map accessors;

	internal const string lastParamType = "javassist.runtime.Inner";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 104, 103, 103, 107 })]
	public AccessorMaker(CtClass c)
	{
		clazz = c;
		uniqueNumber = 1;
		accessors = new HashMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 155, 127, 14, 105 })]
	private string findAccessorName(ClassFile P_0)
	{
		string text;
		do
		{
			StringBuilder stringBuilder = new StringBuilder().append("access$");
			int num = uniqueNumber;
			uniqueNumber = num + 1;
			text = stringBuilder.append(num).toString();
		}
		while (P_0.getMethod(text) != null);
		return text;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		6,
		123,
		114,
		99,
		130,
		108,
		140,
		103,
		109,
		142,
		104,
		109,
		104,
		100,
		144,
		106,
		104,
		104,
		99,
		106,
		51,
		136,
		107,
		147,
		104,
		110,
		byte.MaxValue,
		11,
		71,
		226,
		59,
		98,
		141,
		98,
		173,
		110
	})]
	public virtual string getConstructor(CtClass c, string desc, MethodInfo orig)
	{
		string key = new StringBuilder().append("<init>:").append(desc).toString();
		string text = (string)accessors.get(key);
		if (text != null)
		{
			return text;
		}
		text = Descriptor.appendParameter("javassist.runtime.Inner", desc);
		ClassFile classFile = clazz.getClassFile();
		CannotCompileException ex;
		NotFoundException ex2;
		try
		{
			try
			{
				ConstPool constPool = classFile.getConstPool();
				ClassPool classPool = clazz.getClassPool();
				MethodInfo methodInfo = new MethodInfo(constPool, "<init>", text);
				methodInfo.setAccessFlags(0);
				methodInfo.addAttribute(new SyntheticAttribute(constPool));
				ExceptionsAttribute exceptionsAttribute = orig.getExceptionsAttribute();
				if (exceptionsAttribute != null)
				{
					methodInfo.addAttribute(exceptionsAttribute.copy(constPool, null));
				}
				CtClass[] parameterTypes = Descriptor.getParameterTypes(desc, classPool);
				Bytecode bytecode = new Bytecode(constPool);
				bytecode.addAload(0);
				int num = 1;
				for (int i = 0; i < (nint)parameterTypes.LongLength; i++)
				{
					num += bytecode.addLoad(num, parameterTypes[i]);
				}
				bytecode.setMaxLocals(num + 1);
				bytecode.addInvokespecial(clazz, "<init>", desc);
				bytecode.addReturn(null);
				methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
				classFile.addMethod(methodInfo);
			}
			catch (CannotCompileException x)
			{
				ex = ByteCodeHelper.MapException<CannotCompileException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0135;
			}
		}
		catch (NotFoundException x2)
		{
			ex2 = ByteCodeHelper.MapException<NotFoundException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0139;
		}
		accessors.put(key, text);
		return text;
		IL_0139:
		NotFoundException e = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(e);
		IL_0135:
		CannotCompileException e2 = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(e2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		65,
		127,
		2,
		114,
		99,
		130,
		108,
		136,
		103,
		109,
		138,
		104,
		109,
		105,
		100,
		144,
		106,
		99,
		104,
		106,
		51,
		168,
		105,
		100,
		145,
		143,
		111,
		110,
		byte.MaxValue,
		11,
		71,
		226,
		59,
		98,
		141,
		98,
		173,
		110
	})]
	public virtual string getMethodAccessor(string name, string desc, string accDesc, MethodInfo orig)
	{
		string key = new StringBuilder().append(name).append(":").append(desc)
			.toString();
		string text = (string)accessors.get(key);
		if (text != null)
		{
			return text;
		}
		ClassFile classFile = clazz.getClassFile();
		text = findAccessorName(classFile);
		CannotCompileException ex;
		NotFoundException ex2;
		try
		{
			try
			{
				ConstPool constPool = classFile.getConstPool();
				ClassPool classPool = clazz.getClassPool();
				MethodInfo methodInfo = new MethodInfo(constPool, text, accDesc);
				methodInfo.setAccessFlags(8);
				methodInfo.addAttribute(new SyntheticAttribute(constPool));
				ExceptionsAttribute exceptionsAttribute = orig.getExceptionsAttribute();
				if (exceptionsAttribute != null)
				{
					methodInfo.addAttribute(exceptionsAttribute.copy(constPool, null));
				}
				CtClass[] parameterTypes = Descriptor.getParameterTypes(accDesc, classPool);
				int num = 0;
				Bytecode bytecode = new Bytecode(constPool);
				for (int i = 0; i < (nint)parameterTypes.LongLength; i++)
				{
					num += bytecode.addLoad(num, parameterTypes[i]);
				}
				bytecode.setMaxLocals(num);
				if ((object)desc == accDesc)
				{
					bytecode.addInvokestatic(clazz, name, desc);
				}
				else
				{
					bytecode.addInvokevirtual(clazz, name, desc);
				}
				bytecode.addReturn(Descriptor.getReturnType(desc, classPool));
				methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
				classFile.addMethod(methodInfo);
			}
			catch (CannotCompileException x)
			{
				ex = ByteCodeHelper.MapException<CannotCompileException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0142;
			}
		}
		catch (NotFoundException x2)
		{
			ex2 = ByteCodeHelper.MapException<NotFoundException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0146;
		}
		accessors.put(key, text);
		return text;
		IL_0146:
		NotFoundException e = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(e);
		IL_0142:
		CannotCompileException e2 = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(e2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 101, 130, 103, 123, 109, 99, 135, 109, 138,
		105, 109, 136, 99, 159, 0, 159, 24, 109, 104,
		110, 105, 99, 177, 104, 111, 168, 112, 110, 105,
		111, 159, 12, 98, 141, 98
	})]
	public virtual MethodInfo getFieldGetter(FieldInfo finfo, bool is_static)
	{
		//Discarded unreachable code: IL_0162
		string name = finfo.getName();
		string key = new StringBuilder().append(name).append(":getter").toString();
		object obj = accessors.get(key);
		if (obj != null)
		{
			return (MethodInfo)obj;
		}
		ClassFile classFile = clazz.getClassFile();
		string methodname = findAccessorName(classFile);
		CannotCompileException ex;
		NotFoundException ex2;
		try
		{
			try
			{
				ConstPool constPool = classFile.getConstPool();
				ClassPool classPool = clazz.getClassPool();
				string descriptor = finfo.getDescriptor();
				string desc = ((!is_static) ? new StringBuilder().append("(").append(Descriptor.of(clazz)).append(")")
					.append(descriptor)
					.toString() : new StringBuilder().append("()").append(descriptor).toString());
				MethodInfo methodInfo = new MethodInfo(constPool, methodname, desc);
				methodInfo.setAccessFlags(8);
				methodInfo.addAttribute(new SyntheticAttribute(constPool));
				Bytecode bytecode = new Bytecode(constPool);
				if (is_static)
				{
					bytecode.addGetstatic(Bytecode.___003C_003ETHIS, name, descriptor);
				}
				else
				{
					bytecode.addAload(0);
					bytecode.addGetfield(Bytecode.___003C_003ETHIS, name, descriptor);
					bytecode.setMaxLocals(1);
				}
				bytecode.addReturn(Descriptor.toCtClass(descriptor, classPool));
				methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
				classFile.addMethod(methodInfo);
				accessors.put(key, methodInfo);
				return methodInfo;
			}
			catch (CannotCompileException x)
			{
				ex = ByteCodeHelper.MapException<CannotCompileException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (NotFoundException x2)
		{
			ex2 = ByteCodeHelper.MapException<NotFoundException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0184;
		}
		CannotCompileException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(e);
		IL_0184:
		NotFoundException e2 = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(e2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[]
	{
		159, 88, 98, 103, 123, 109, 99, 135, 109, 138,
		105, 109, 136, 99, 159, 10, 159, 24, 109, 104,
		110, 137, 99, 115, 177, 104, 149, 175, 104, 105,
		110, 105, 111, 159, 12, 98, 141, 98
	})]
	public virtual MethodInfo getFieldSetter(FieldInfo finfo, bool is_static)
	{
		//Discarded unreachable code: IL_018d
		string name = finfo.getName();
		string key = new StringBuilder().append(name).append(":setter").toString();
		object obj = accessors.get(key);
		if (obj != null)
		{
			return (MethodInfo)obj;
		}
		ClassFile classFile = clazz.getClassFile();
		string methodname = findAccessorName(classFile);
		CannotCompileException ex;
		NotFoundException ex2;
		try
		{
			try
			{
				ConstPool constPool = classFile.getConstPool();
				ClassPool classPool = clazz.getClassPool();
				string descriptor = finfo.getDescriptor();
				string desc = ((!is_static) ? new StringBuilder().append("(").append(Descriptor.of(clazz)).append(descriptor)
					.append(")V")
					.toString() : new StringBuilder().append("(").append(descriptor).append(")V")
					.toString());
				MethodInfo methodInfo = new MethodInfo(constPool, methodname, desc);
				methodInfo.setAccessFlags(8);
				methodInfo.addAttribute(new SyntheticAttribute(constPool));
				Bytecode bytecode = new Bytecode(constPool);
				int maxLocals;
				if (is_static)
				{
					maxLocals = bytecode.addLoad(0, Descriptor.toCtClass(descriptor, classPool));
					bytecode.addPutstatic(Bytecode.___003C_003ETHIS, name, descriptor);
				}
				else
				{
					bytecode.addAload(0);
					maxLocals = bytecode.addLoad(1, Descriptor.toCtClass(descriptor, classPool)) + 1;
					bytecode.addPutfield(Bytecode.___003C_003ETHIS, name, descriptor);
				}
				bytecode.addReturn(null);
				bytecode.setMaxLocals(maxLocals);
				methodInfo.setCodeAttribute(bytecode.toCodeAttribute());
				classFile.addMethod(methodInfo);
				accessors.put(key, methodInfo);
				return methodInfo;
			}
			catch (CannotCompileException x)
			{
				ex = ByteCodeHelper.MapException<CannotCompileException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (NotFoundException x2)
		{
			ex2 = ByteCodeHelper.MapException<NotFoundException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_01af;
		}
		CannotCompileException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(e);
		IL_01af:
		NotFoundException e2 = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CompileError(e2);
	}
}
