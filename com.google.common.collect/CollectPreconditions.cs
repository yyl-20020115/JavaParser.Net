using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.collect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class CollectPreconditions : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 100, 159, 30 })]
	internal static int checkNonnegative(int P_0, string P_1)
	{
		if (P_0 < 0)
		{
			int num = 40 + String.instancehelper_length(String.valueOf(P_1));
			num = num;
			string s = new StringBuilder(num).append(P_1).append(" cannot be negative but was: ").append(P_0)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 126, 66, 109 })]
	internal static void checkRemove(bool P_0)
	{
		Preconditions.checkState(P_0, (object)"no calls to next() since the last call to remove()");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(27)]
	internal CollectPreconditions()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 172, 99, 127, 31, 99, 159, 41 })]
	internal static void checkEntryNotNull(object P_0, object P_1)
	{
		if (P_0 == null)
		{
			string text = String.valueOf(P_1);
			int num = 24 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("null key in entry: null=").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s);
		}
		if (P_1 == null)
		{
			string text = String.valueOf(P_0);
			int num = 26 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s2 = new StringBuilder(num).append("null value in entry: ").append(text).append("=null")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NullPointerException(s2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 101, 159, 30 })]
	internal static long checkNonnegative(long P_0, string P_1)
	{
		if (P_0 < 0)
		{
			int num = 49 + String.instancehelper_length(String.valueOf(P_1));
			num = num;
			string s = new StringBuilder(num).append(P_1).append(" cannot be negative but was: ").append(P_0)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 100, 159, 30 })]
	internal static void checkPositive(int P_0, string P_1)
	{
		if (P_0 <= 0)
		{
			int num = 38 + String.instancehelper_length(String.valueOf(P_1));
			num = num;
			string s = new StringBuilder(num).append(P_1).append(" must be positive but was: ").append(P_0)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}
}
