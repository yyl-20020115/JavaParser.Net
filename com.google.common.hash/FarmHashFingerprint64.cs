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
internal sealed class FarmHashFingerprint64 : AbstractNonStreamingHashFunction
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static HashFunction FARMHASH_FINGERPRINT_64;

	private const long K0 = -4348849565147123417L;

	private const long K1 = -5435081209227447693L;

	private const long K2 = -7286425919675154353L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 20, 101, 101, 139, 139, 101, 139 })]
	internal static long fingerprint(byte[] P_0, int P_1, int P_2)
	{
		if (P_2 <= 32)
		{
			if (P_2 <= 16)
			{
				long result = hashLength0to16(P_0, P_1, P_2);
				_ = null;
				return result;
			}
			long result2 = hashLength17to32(P_0, P_1, P_2);
			_ = null;
			return result2;
		}
		if (P_2 <= 64)
		{
			long result3 = hashLength33To64(P_0, P_1, P_2);
			_ = null;
			return result3;
		}
		long result4 = hashLength65Plus(P_0, P_1, P_2);
		_ = null;
		return result4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		69, 100, 111, 114, 108, 109, 110, 140, 100, 111,
		112, 159, 3, 100, 101, 105, 105, 117, 110, 159,
		12
	})]
	private static long hashLength0to16(byte[] P_0, int P_1, int P_2)
	{
		if (P_2 >= 8)
		{
			long num = -7286425919675154353L + P_2 * 2;
			long num2 = LittleEndianByteArray.load64(P_0, P_1) + -7286425919675154353L;
			long num3 = LittleEndianByteArray.load64(P_0, P_1 + P_2 - 8);
			long num4 = Long.rotateRight(num3, 37) * num + num2;
			long num5 = (Long.rotateRight(num2, 25) + num3) * num;
			long result = hashLength16(num4, num5, num);
			_ = null;
			return result;
		}
		if (P_2 >= 4)
		{
			long num = -7286425919675154353L + P_2 * 2;
			long num2 = LittleEndianByteArray.load32(P_0, P_1) & 0xFFFFFFFFu;
			long result2 = hashLength16(P_2 + (num2 << 3), LittleEndianByteArray.load32(P_0, P_1 + P_2 - 4) & 0xFFFFFFFFu, num);
			_ = null;
			return result2;
		}
		if (P_2 > 0)
		{
			int num6 = P_0[P_1];
			int num7 = P_0[P_1 + (P_2 >> 1)];
			int num8 = P_0[P_1 + (P_2 - 1)];
			int num9 = (num6 & 0xFF) + ((num7 & 0xFF) << 8);
			int num10 = P_2 + ((num8 & 0xFF) << 2);
			return shiftMix((num9 * -7286425919675154353L) ^ (num10 * -4348849565147123417L)) * -7286425919675154353L;
		}
		return -7286425919675154353L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 94, 111, 114, 106, 110, 120, 101, 63, 9 })]
	private static long hashLength17to32(byte[] P_0, int P_1, int P_2)
	{
		long num = -7286425919675154353L + P_2 * 2;
		long num2 = LittleEndianByteArray.load64(P_0, P_1) * -5435081209227447693L;
		long num3 = LittleEndianByteArray.load64(P_0, P_1 + 8);
		long num4 = LittleEndianByteArray.load64(P_0, P_1 + P_2 - 8) * num;
		long num5 = LittleEndianByteArray.load64(P_0, P_1 + P_2 - 16) * -7286425919675154353L;
		long result = hashLength16(Long.rotateRight(num2 + num3, 43) + Long.rotateRight(num4, 30) + num5, num2 + Long.rotateRight(num3 + -7286425919675154353L, 18) + num4, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		104, 111, 114, 106, 110, 120, 120, 127, 1, 110,
		108, 115, 115, 103, 63, 5
	})]
	private static long hashLength33To64(byte[] P_0, int P_1, int P_2)
	{
		long num = -7286425919675154353L + P_2 * 2;
		long num2 = LittleEndianByteArray.load64(P_0, P_1) * -7286425919675154353L;
		long num3 = LittleEndianByteArray.load64(P_0, P_1 + 8);
		long num4 = LittleEndianByteArray.load64(P_0, P_1 + P_2 - 8) * num;
		long num5 = LittleEndianByteArray.load64(P_0, P_1 + P_2 - 16) * -7286425919675154353L;
		long num6 = Long.rotateRight(num2 + num3, 43) + Long.rotateRight(num4, 30) + num5;
		long num7 = hashLength16(num6, num2 + Long.rotateRight(num3 + -7286425919675154353L, 18) + num4, num);
		long num8 = LittleEndianByteArray.load64(P_0, P_1 + 16) * num;
		long num9 = LittleEndianByteArray.load64(P_0, P_1 + 24);
		long num10 = (num6 + LittleEndianByteArray.load64(P_0, P_1 + P_2 - 32)) * num;
		long num11 = (num7 + LittleEndianByteArray.load64(P_0, P_1 + P_2 - 24)) * num;
		long result = hashLength16(Long.rotateRight(num8 + num9, 43) + Long.rotateRight(num10, 30) + num11, num8 + Long.rotateRight(num9 + num2, 18) + num10, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		123, 131, 131, 113, 127, 0, 104, 104, 180, 109,
		142, 127, 5, 127, 4, 103, 114, 120, 125, 126,
		99, 98, 99, 102, 104, 150, 100, 121, 118, 118,
		125, 124, 107, 118, 113, 118, 126, 106, 127, 3,
		9
	})]
	private static long hashLength65Plus(byte[] P_0, int P_1, int P_2)
	{
		int num = 81;
		long num2 = num;
		long num3 = num * -5435081209227447693L + 113u;
		long num4 = shiftMix(num3 * -7286425919675154353L + 113u) * -7286425919675154353L;
		long[] array = new long[2];
		long[] array2 = new long[2];
		num2 = num2 * -7286425919675154353L + LittleEndianByteArray.load64(P_0, P_1);
		int num5 = P_1 + (P_2 - 1) / 64 * 64;
		int num6 = num5 + ((P_2 - 1) & 0x3F) - 63;
		long num7;
		do
		{
			num2 = Long.rotateRight(num2 + num3 + array[0] + LittleEndianByteArray.load64(P_0, P_1 + 8), 37) * -5435081209227447693L;
			num3 = Long.rotateRight(num3 + array[1] + LittleEndianByteArray.load64(P_0, P_1 + 48), 42) * -5435081209227447693L;
			num2 ^= array2[1];
			num3 += array[0] + LittleEndianByteArray.load64(P_0, P_1 + 40);
			num4 = Long.rotateRight(num4 + array2[0], 33) * -5435081209227447693L;
			weakHashLength32WithSeeds(P_0, P_1, array[1] * -5435081209227447693L, num2 + array2[0], array);
			weakHashLength32WithSeeds(P_0, P_1 + 32, num4 + array2[1], num3 + LittleEndianByteArray.load64(P_0, P_1 + 16), array2);
			num7 = num2;
			num2 = num4;
			num4 = num7;
			P_1 += 64;
		}
		while (P_1 != num5);
		num7 = -5435081209227447693L + ((num4 & 0xFFu) << 1);
		P_1 = num6;
		int num8 = 0;
		long[] array3 = array2;
		array3[num8] += (P_2 - 1) & 0x3F;
		num8 = 0;
		array3 = array;
		array3[num8] += array2[0];
		num8 = 0;
		array3 = array2;
		array3[num8] += array[0];
		num2 = Long.rotateRight(num2 + num3 + array[0] + LittleEndianByteArray.load64(P_0, P_1 + 8), 37) * num7;
		num3 = Long.rotateRight(num3 + array[1] + LittleEndianByteArray.load64(P_0, P_1 + 48), 42) * num7;
		num2 ^= array2[1] * 9u;
		num3 += array[0] * 9u + LittleEndianByteArray.load64(P_0, P_1 + 40);
		num4 = Long.rotateRight(num4 + array2[0], 33) * num7;
		weakHashLength32WithSeeds(P_0, P_1, array[1] * num7, num2 + array2[0], array);
		weakHashLength32WithSeeds(P_0, P_1 + 32, num4 + array2[1], num3 + LittleEndianByteArray.load64(P_0, P_1 + 16), array2);
		long result = hashLength16(hashLength16(array[0], array2[0], num7) + shiftMix(num3) * -4348849565147123417L + num2, hashLength16(array[1], array2[1], num7) + num4, num7);
		_ = null;
		return result;
	}

	private static long hashLength16(long P_0, long P_1, long P_2)
	{
		long num = (P_0 ^ P_1) * P_2;
		num ^= (long)((ulong)num >> 47);
		long num2 = (P_1 ^ num) * P_2;
		num2 ^= (long)((ulong)num2 >> 47);
		return num2 * P_2;
	}

	private static long shiftMix(long P_0)
	{
		return P_0 ^ (long)((ulong)P_0 >> 47);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		53, 104, 106, 107, 139, 101, 110, 99, 101, 101,
		108, 103, 104
	})]
	private static void weakHashLength32WithSeeds(byte[] P_0, int P_1, long P_2, long P_3, long[] P_4)
	{
		long num = LittleEndianByteArray.load64(P_0, P_1);
		long num2 = LittleEndianByteArray.load64(P_0, P_1 + 8);
		long num3 = LittleEndianByteArray.load64(P_0, P_1 + 16);
		long num4 = LittleEndianByteArray.load64(P_0, P_1 + 24);
		P_2 += num;
		P_3 = Long.rotateRight(P_3 + P_2 + num4, 21);
		long num5 = P_2;
		P_2 += num2;
		P_2 += num3;
		P_3 += Long.rotateRight(P_2, 44);
		P_4[0] = P_2 + num4;
		P_4[1] = P_3 + num5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	internal FarmHashFingerprint64()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 107 })]
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
		return "Hashing.farmHashFingerprint64()";
	}

	[LineNumberTable(43)]
	static FarmHashFingerprint64()
	{
		FARMHASH_FINGERPRINT_64 = new FarmHashFingerprint64();
	}
}
