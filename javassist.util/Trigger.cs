using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.util;

[SourceFile("HotSwapper.java")]
internal class Trigger : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(39)]
	internal Trigger()
	{
	}

	internal virtual void doSwap()
	{
	}
}
