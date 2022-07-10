using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.tools.reflect;

[SourceFile("Compiler.java")]
internal class CompiledClass : Object
{
	public string classname;

	public string metaobject;

	public string classobject;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(24)]
	internal CompiledClass()
	{
	}
}
