using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.runtime;

public class DotClass : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(25)]
	public DotClass()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(27)]
	public static java.lang.NoClassDefFoundError fail(java.lang.ClassNotFoundException e)
	{
		java.lang.NoClassDefFoundError result = new java.lang.NoClassDefFoundError(Throwable.instancehelper_getMessage(e));
		_ = null;
		return result;
	}
}
