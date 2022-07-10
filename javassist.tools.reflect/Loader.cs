using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace javassist.tools.reflect;

public class Loader : javassist.Loader
{
	protected internal Reflection reflection;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 81, 104, 139, 107, 102, 111 })]
	public Loader()
	{
		delegateLoadingOf("javassist.tools.reflect.Loader");
		reflection = new Reflection();
		ClassPool @default = ClassPool.getDefault();
		addTranslator(@default, reflection);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 73, 102, 105 })]
	public new static void main(string[] args)
	{
		Loader loader = new Loader();
		loader.run(args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(160)]
	public virtual bool makeReflective(string clazz, string metaobject, string metaclass)
	{
		bool result = reflection.makeReflective(clazz, metaobject, metaclass);
		_ = null;
		return result;
	}

	[HideFromJava]
	static Loader()
	{
		javassist.Loader.___003Cclinit_003E();
	}
}
