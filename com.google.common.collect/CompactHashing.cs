using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)107,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class CompactHashing : Object
{
	internal const byte UNSET = 0;

	private const int HASH_TABLE_BITS_MAX_BITS = 5;

	internal const int MODIFICATION_COUNT_INCREMENT = 32;

	internal const int HASH_TABLE_BITS_MASK = 31;

	internal const int MAX_SIZE = 1073741823;

	internal const int DEFAULT_SIZE = 3;

	private const int MIN_HASH_TABLE_SIZE = 4;

	private const int BYTE_MAX_SIZE = 256;

	private const int BYTE_MASK = 255;

	private const int SHORT_MAX_SIZE = 65536;

	private const int SHORT_MASK = 65535;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(72)]
	internal static int tableSize(int P_0)
	{
		int result = Math.max(4, Hashing.closedTableSize(P_0 + 1, 1.0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 27, 141, 104, 159, 12, 104, 103, 104, 135 })]
	internal static object createTable(int P_0)
	{
		if (P_0 < 2 || P_0 > 1073741824 || Integer.highestOneBit(P_0) != P_0)
		{
			int num = 52;
			num = num;
			string s = new StringBuilder(num).append("must be power of 2 between 2^1 and 2^30: ").append(P_0).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		if (P_0 <= 256)
		{
			return new byte[P_0];
		}
		if (P_0 <= 65536)
		{
			return new short[P_0];
		}
		return new int[P_0];
	}

	internal static int maskCombine(int P_0, int P_1, int P_2)
	{
		return (P_0 & (P_2 ^ -1)) | (P_1 & P_2);
	}

	[LineNumberTable(new byte[] { 57, 104, 105, 104, 143 })]
	internal static int tableGet(object P_0, int P_1)
	{
		if (P_0 is byte[])
		{
			return ((byte[])P_0)[P_1];
		}
		if (P_0 is short[])
		{
			return ((short[])P_0)[P_1] & 0xFFFF;
		}
		return ((int[])P_0)[P_1];
	}

	internal static int newCapacity(int P_0)
	{
		return ((P_0 >= 32) ? 2 : 4) * (P_0 + 1);
	}

	[LineNumberTable(new byte[] { 74, 104, 108, 104, 140, 137 })]
	internal static void tableSet(object P_0, int P_1, int P_2)
	{
		if (P_0 is byte[])
		{
			((byte[])P_0)[P_1] = (byte)(sbyte)P_2;
		}
		else if (P_0 is short[])
		{
			((short[])P_0)[P_1] = (short)P_2;
		}
		else
		{
			((int[])P_0)[P_1] = P_2;
		}
	}

	internal static int getHashPrefix(int P_0, int P_1)
	{
		return P_0 & (P_1 ^ -1);
	}

	internal static int getNext(int P_0, int P_1)
	{
		return P_0 & P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 5, 1, 0, 0, 0, 107, 0,
		0, 22, 6, 1, 0, 0, 0, 107, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		117, 103, 100, 104, 99, 130, 104, 131, 101, 103,
		113, 113, 103, 106, 133, 171, 178, 131, 100, 105,
		102
	})]
	internal static int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1, int P_2, object P_3, int[] P_4, object[] P_5, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object[] P_6)
	{
		int num = Hashing.smearedHash(P_0);
		int num2 = num & P_2;
		int num3 = tableGet(P_3, num2);
		if (num3 == 0)
		{
			return -1;
		}
		int hashPrefix = getHashPrefix(num, P_2);
		int num4 = -1;
		do
		{
			int num5 = num3 - 1;
			int num6 = P_4[num5];
			if (getHashPrefix(num6, P_2) == hashPrefix && com.google.common.@base.Objects.equal(P_0, P_5[num5]) && (P_6 == null || com.google.common.@base.Objects.equal(P_1, P_6[num5])))
			{
				int next = getNext(num6, P_2);
				if (num4 == -1)
				{
					tableSet(P_3, num2, next);
				}
				else
				{
					P_4[num4] = maskCombine(P_4[num4], next, P_2);
				}
				return num5;
			}
			num4 = num5;
			num3 = getNext(num6, P_2);
		}
		while (num3 != 0);
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 42, 104, 110, 104, 142, 142 })]
	internal static void tableClear(object P_0)
	{
		if (P_0 is byte[])
		{
			Arrays.fill((byte[])P_0, 0);
		}
		else if (P_0 is short[])
		{
			Arrays.fill((short[])P_0, 0);
		}
		else
		{
			Arrays.fill((int[])P_0, 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(34)]
	private CompactHashing()
	{
	}
}
