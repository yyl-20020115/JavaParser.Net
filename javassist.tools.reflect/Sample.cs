using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.tools.reflect;

public class Sample : Object
{
	private Metaobject _metaobject;

	private static ClassMetaobject _classobject;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(22)]
	public Sample()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 159, 170, 103, 99, 107 })]
	public virtual object trap(object[] args, int identifier)
	{
		Metaobject metaobject = _metaobject;
		if (metaobject == null)
		{
			object result = ClassMetaobject.invoke(this, identifier, args);
			_ = null;
			return result;
		}
		object result2 = metaobject.trapMethodcall(identifier, args);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(37)]
	public static object trapStatic(object[] args, int identifier)
	{
		object result = _classobject.trapMethodcall(identifier, args);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 101, 110 })]
	public static object trapRead(object[] args, string name)
	{
		if (args[0] == null)
		{
			object result = _classobject.trapFieldRead(name);
			_ = null;
			return result;
		}
		object result2 = ((Metalevel)args[0])._getMetaobject().trapFieldRead(name);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 105, 99, 144, 143 })]
	public static object trapWrite(object[] args, string name)
	{
		Metalevel metalevel = (Metalevel)args[0];
		if (metalevel == null)
		{
			_classobject.trapFieldWrite(name, args[1]);
		}
		else
		{
			metalevel._getMetaobject().trapFieldWrite(name, args[1]);
		}
		return null;
	}
}
