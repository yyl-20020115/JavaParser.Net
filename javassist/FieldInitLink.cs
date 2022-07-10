using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist;

[SourceFile("CtClassType.java")]
internal class FieldInitLink : Object
{
	internal FieldInitLink next;

	internal CtField field;

	internal CtField.Initializer init;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 220, 104, 103, 103, 103 })]
	internal FieldInitLink(CtField P_0, CtField.Initializer P_1)
	{
		next = null;
		field = P_0;
		init = P_1;
	}
}
