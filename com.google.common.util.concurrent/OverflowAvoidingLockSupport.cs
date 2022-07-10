using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent.locks;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class OverflowAvoidingLockSupport : Object
{
	internal const long MAX_NANOSECONDS_THRESHOLD = 2147483647999999999L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 178, 119 })]
	internal static void parkNanos([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, long P_1)
	{
		LockSupport.parkNanos(P_0, Math.min(P_1, 2147483647999999999L));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	private OverflowAvoidingLockSupport()
	{
	}
}
