using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.nio;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Java8Compatibility : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 103 })]
	internal static void flip(Buffer P_0)
	{
		P_0.flip();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 170, 103 })]
	internal static void clear(Buffer P_0)
	{
		P_0.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 178, 104 })]
	internal static void limit(Buffer P_0, int P_1)
	{
		P_0.limit(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 182, 103 })]
	internal static void mark(Buffer P_0)
	{
		P_0.mark();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 186, 104 })]
	internal static void position(Buffer P_0, int P_1)
	{
		P_0.position(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 190, 103 })]
	internal static void reset(Buffer P_0)
	{
		P_0.reset();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	private Java8Compatibility()
	{
	}
}
