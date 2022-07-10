using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist;

[SourceFile("ClassPoolTail.java")]
internal sealed class ClassPathList : Object
{
	internal ClassPathList next;

	internal ClassPath path;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 104, 103, 103 })]
	internal ClassPathList(ClassPath P_0, ClassPathList P_1)
	{
		next = P_1;
		path = P_0;
	}
}
