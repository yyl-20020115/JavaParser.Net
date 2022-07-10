using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.tools.rmi;

[SourceFile("AppletServer.java")]
internal class ExportedObject : Object
{
	public int identifier;

	public object @object;

	public Method[] methods;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(256)]
	internal ExportedObject()
	{
	}
}
