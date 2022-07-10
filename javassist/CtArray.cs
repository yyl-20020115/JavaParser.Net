using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace javassist;

internal sealed class CtArray : CtClass
{
	protected internal ClassPool pool;

	private CtClass[] interfaces;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 171, 233, 80, 231, 49, 103 })]
	internal CtArray(string P_0, ClassPool P_1)
		: base(P_0)
	{
		interfaces = null;
		pool = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 46, 103 })]
	public override CtClass getComponentType()
	{
		string name = base.getName();
		CtClass result = pool.get(String.instancehelper_substring(name, 0, String.instancehelper_length(name) - 2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 12, 104, 171, 109, 103, 59, 198 })]
	public override CtClass[] getInterfaces()
	{
		if (interfaces == null)
		{
			Class[] array = ClassLiteral<object[]>.Value.getInterfaces();
			interfaces = new CtClass[(nint)array.LongLength];
			for (int i = 0; i < (nint)array.LongLength; i++)
			{
				interfaces[i] = pool.get(array[i].getName());
			}
		}
		return interfaces;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(103)]
	public override CtClass getSuperclass()
	{
		CtClass result = pool.get("java.lang.Object");
		_ = null;
		return result;
	}

	public override ClassPool getClassPool()
	{
		return pool;
	}

	public override bool isArray()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 0, 131, 187, 99 })]
	public override int getModifiers()
	{
		int num = 16;
		try
		{
			num |= getComponentType().getModifiers() & 7;
			return num;
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		27, 105, 130, 103, 109, 130, 103, 103, 107, 2,
		198, 105, 54
	})]
	public override bool subtypeOf(CtClass P_0)
	{
		if (base.subtypeOf(P_0))
		{
			return true;
		}
		string name = P_0.getName();
		if (String.instancehelper_equals(name, "java.lang.Object"))
		{
			return true;
		}
		CtClass[] array = getInterfaces();
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			if (array[i].subtypeOf(P_0))
			{
				return true;
			}
		}
		return (P_0.isArray() && getComponentType().subtypeOf(P_0.getComponentType())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 60, 154, 97 })]
	public override CtMethod[] getMethods()
	{
		//Discarded unreachable code: IL_000d
		try
		{
			return getSuperclass().getMethods();
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		return base.getMethods();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(121)]
	public override CtMethod getMethod(string P_0, string P_1)
	{
		CtMethod method = getSuperclass().getMethod(P_0, P_1);
		_ = null;
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 78, 154, 97 })]
	public override CtConstructor[] getConstructors()
	{
		//Discarded unreachable code: IL_000d
		try
		{
			return getSuperclass().getConstructors();
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		return base.getConstructors();
	}

	[HideFromJava]
	static CtArray()
	{
		CtClass.___003Cclinit_003E();
	}
}
