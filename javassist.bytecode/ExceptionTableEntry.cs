using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ExceptionTable.java")]
internal class ExceptionTableEntry : Object
{
	internal int startPc;

	internal int endPc;

	internal int handlerPc;

	internal int catchType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 104, 103, 103, 103, 104 })]
	internal ExceptionTableEntry(int P_0, int P_1, int P_2, int P_3)
	{
		startPc = P_0;
		endPc = P_1;
		handlerPc = P_2;
		catchType = P_3;
	}
}
