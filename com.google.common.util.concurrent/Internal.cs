using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.time;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Internal : java.lang.Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 178, 127, 0, 97 })]
	internal static long toNanosSaturated(Duration P_0)
	{
		//Discarded unreachable code: IL_0008
		try
		{
			return P_0.toNanos();
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.ArithmeticException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		return (!P_0.isNegative()) ? long.MaxValue : long.MinValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	private Internal()
	{
	}
}
