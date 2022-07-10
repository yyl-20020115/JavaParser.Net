using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Fingerprint2011 : AbstractNonStreamingHashFunction
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static HashFunction FINGERPRINT_2011;

	private const long K0 = -6505348102511208375L;

	private const long K1 = -8261664234251669945L;

	private const long K2 = -4288712594273399085L;

	private const long K3 = -4132994306676758123L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 101, 116, 101, 139, 169, 119, 124, 106 })]
	internal static long fingerprint(byte[] P_0, int P_1, int P_2)
	{
		long num = ((P_2 <= 32) ? murmurHash64WithSeed(P_0, P_1, P_2, -1397348546323613475L) : ((P_2 > 64) ? fullFingerprint(P_0, P_1, P_2) : hashLength33To64(P_0, P_1, P_2)));
		long num2 = ((P_2 < 8) ? (-6505348102511208375L) : LittleEndianByteArray.load64(P_0, P_1));
		long num3 = ((P_2 < 9) ? (-6505348102511208375L) : LittleEndianByteArray.load64(P_0, P_1 + P_2 - 8));
		num = hash128to64(num + num3, num2);
		return (num != 0 && num != 1) ? num : (num + -2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		124, 106, 130, 102, 100, 136, 104, 108, 109, 103,
		230, 60, 232, 71, 99, 108, 103, 166, 107, 105
	})]
	internal static long murmurHash64WithSeed(byte[] P_0, int P_1, int P_2, long P_3)
	{
		long num = -4132994306676758123L;
		int num2 = 7;
		int num3 = P_2 & (num2 ^ -1);
		int num4 = P_2 & num2;
		long num5 = P_3 ^ (P_2 * num);
		for (int i = 0; i < num3; i += 8)
		{
			long num6 = LittleEndianByteArray.load64(P_0, P_1 + i);
			long num7 = shiftMix(num6 * num) * num;
			num5 ^= num7;
			num5 *= num;
		}
		if (num4 != 0)
		{
			long num8 = LittleEndianByteArray.load64Safely(P_0, P_1 + num3, num4);
			num5 ^= num8;
			num5 *= num;
		}
		num5 = shiftMix(num5) * num;
		return shiftMix(num5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		100, 107, 127, 3, 107, 105, 108, 106, 109, 101,
		110, 120, 108, 107, 105, 111, 106, 111, 101, 110,
		127, 7
	})]
	private static long hashLength33To64(byte[] P_0, int P_1, int P_2)
	{
		long num = LittleEndianByteArray.load64(P_0, P_1 + 24);
		long num2 = LittleEndianByteArray.load64(P_0, P_1) + (P_2 + LittleEndianByteArray.load64(P_0, P_1 + P_2 - 16)) * -6505348102511208375L;
		long num3 = Long.rotateRight(num2 + num, 52);
		long num4 = Long.rotateRight(num2, 37);
		num2 += LittleEndianByteArray.load64(P_0, P_1 + 8);
		num4 += Long.rotateRight(num2, 7);
		num2 += LittleEndianByteArray.load64(P_0, P_1 + 16);
		long num5 = num2 + num;
		long num6 = num3 + Long.rotateRight(num2, 31) + num4;
		num2 = LittleEndianByteArray.load64(P_0, P_1 + 16) + LittleEndianByteArray.load64(P_0, P_1 + P_2 - 32);
		num = LittleEndianByteArray.load64(P_0, P_1 + P_2 - 8);
		num3 = Long.rotateRight(num2 + num, 52);
		num4 = Long.rotateRight(num2, 37);
		num2 += LittleEndianByteArray.load64(P_0, P_1 + P_2 - 24);
		num4 += Long.rotateRight(num2, 7);
		num2 += LittleEndianByteArray.load64(P_0, P_1 + P_2 - 16);
		long num7 = num2 + num;
		long num8 = num3 + Long.rotateRight(num2, 31) + num4;
		long num9 = shiftMix((num5 + num8) * -4288712594273399085L + (num7 + num6) * -6505348102511208375L);
		return shiftMix(num9 * -6505348102511208375L + num6) * -4288712594273399085L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		69, 104, 119, 119, 103, 104, 112, 127, 4, 117,
		117, 179, 136, 127, 5, 127, 3, 103, 102, 110,
		123, 115, 99, 98, 99, 102, 102, 102
	})]
	private static long fullFingerprint(byte[] P_0, int P_1, int P_2)
	{
		long num = LittleEndianByteArray.load64(P_0, P_1);
		long num2 = LittleEndianByteArray.load64(P_0, P_1 + P_2 - 16) ^ -8261664234251669945L;
		long num3 = LittleEndianByteArray.load64(P_0, P_1 + P_2 - 56) ^ -6505348102511208375L;
		long[] array = new long[2];
		long[] array2 = new long[2];
		weakHashLength32WithSeeds(P_0, P_1 + P_2 - 64, P_2, num2, array);
		weakHashLength32WithSeeds(P_0, P_1 + P_2 - 32, P_2 * -8261664234251669945L, -6505348102511208375L, array2);
		num3 += shiftMix(array[1]) * -8261664234251669945L;
		num = Long.rotateRight(num3 + num, 39) * -8261664234251669945L;
		num2 = Long.rotateRight(num2, 33) * -8261664234251669945L;
		P_2 = (P_2 - 1) & -64;
		do
		{
			num = Long.rotateRight(num + num2 + array[0] + LittleEndianByteArray.load64(P_0, P_1 + 16), 37) * -8261664234251669945L;
			num2 = Long.rotateRight(num2 + array[1] + LittleEndianByteArray.load64(P_0, P_1 + 48), 42) * -8261664234251669945L;
			num ^= array2[1];
			num2 ^= array[0];
			num3 = Long.rotateRight(num3 ^ array2[0], 33);
			weakHashLength32WithSeeds(P_0, P_1, array[1] * -8261664234251669945L, num + array2[0], array);
			weakHashLength32WithSeeds(P_0, P_1 + 32, num3 + array2[1], num2, array2);
			long num4 = num3;
			num3 = num;
			num = num4;
			P_1 += 64;
			P_2 += -64;
		}
		while (P_2 != 0);
		long result = hash128to64(hash128to64(array[0], array2[0]) + shiftMix(num2) * -8261664234251669945L + num3, hash128to64(array[1], array2[1]) + num);
		_ = null;
		return result;
	}

	internal static long hash128to64(long P_0, long P_1)
	{
		long num = (P_1 ^ P_0) * -4132994306676758123L;
		num ^= (long)((ulong)num >> 47);
		long num2 = (P_0 ^ num) * -4132994306676758123L;
		num2 ^= (long)((ulong)num2 >> 47);
		return num2 * -4132994306676758123L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		48, 104, 106, 107, 139, 101, 110, 99, 101, 101,
		108, 103, 104
	})]
	private static void weakHashLength32WithSeeds(byte[] P_0, int P_1, long P_2, long P_3, long[] P_4)
	{
		long num = LittleEndianByteArray.load64(P_0, P_1);
		long num2 = LittleEndianByteArray.load64(P_0, P_1 + 8);
		long num3 = LittleEndianByteArray.load64(P_0, P_1 + 16);
		long num4 = LittleEndianByteArray.load64(P_0, P_1 + 24);
		P_2 += num;
		P_3 = Long.rotateRight(P_3 + P_2 + num4, 51);
		long num5 = P_2;
		P_2 += num2;
		P_2 += num3;
		P_3 += Long.rotateRight(P_2, 23);
		P_4[0] = P_2 + num4;
		P_4[1] = P_3 + num5;
	}

	private static long shiftMix(long P_0)
	{
		return P_0 ^ (long)((ulong)P_0 >> 47);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(32)]
	internal Fingerprint2011()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 185, 107 })]
	public override HashCode hashBytes(byte[] P_0, int P_1, int P_2)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		HashCode result = HashCode.fromLong(fingerprint(P_0, P_1, P_2));
		_ = null;
		return result;
	}

	public override int bits()
	{
		return 64;
	}

	public override string toString()
	{
		return "Hashing.fingerprint2011()";
	}

	[LineNumberTable(33)]
	static Fingerprint2011()
	{
		FINGERPRINT_2011 = new Fingerprint2011();
	}
}
