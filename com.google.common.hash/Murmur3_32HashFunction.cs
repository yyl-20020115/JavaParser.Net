using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.nio;
using java.nio.charset;
using javax.annotation;

namespace com.google.common.hash;

[Serializable]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class Murmur3_32HashFunction : AbstractHashFunction, Serializable.__Interface, ISerializable
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Murmur3_32Hasher : AbstractHasher
	{
		private int h1;

		private long buffer;

		private int shift;

		private int length;

		private bool isDone;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 172, 127, 0, 112, 142, 106, 125, 111, 143 })]
		private void update(int P_0, long P_1)
		{
			buffer |= (P_1 & 0xFFFFFFFFu) << shift;
			shift += P_0 * 8;
			length += P_0;
			if (shift >= 32)
			{
				h1 = access_0024100(h1, access_0024000((int)buffer));
				buffer = (long)((ulong)buffer >> 32);
				shift -= 32;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 68, 163, 111 })]
		public override Hasher putByte(byte P_0)
		{
			int num = (sbyte)P_0;
			update(1, num & 0xFF);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 218, 105 })]
		public override Hasher putInt(int P_0)
		{
			update(4, P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			159, 54, 74, 112, 115, 163, 107, 121, 123, 123,
			123, 127, 5, 123, 198, 133, 105, 121, 105, 111,
			105, 115, 114, 147, 126, 134, 127, 36, 130, 102,
			238, 48, 235, 83, 130
		})]
		public override Hasher putString(CharSequence P_0, Charset P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj;
			if (!Charsets.___003C_003EUTF_8.equals(P_1))
			{
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				Hasher result = base.putString(charSequence2, P_1);
				_ = null;
				return result;
			}
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num = charSequence2.length();
			int i;
			for (i = 0; i + 4 <= num; i += 4)
			{
				int i2 = i;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num2 = charSequence2.charAt(i2);
				i2 = i + 1;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num3 = charSequence2.charAt(i2);
				i2 = i + 2;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num4 = charSequence2.charAt(i2);
				i2 = i + 3;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num5 = charSequence2.charAt(i2);
				if (num2 >= 128 || num3 >= 128 || num4 >= 128 || num5 >= 128)
				{
					break;
				}
				update(4, num2 | (num3 << 8) | (num4 << 16) | (num5 << 24));
			}
			for (; i < num; i++)
			{
				int i2 = i;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num2 = charSequence2.charAt(i2);
				if (num2 < 128)
				{
					update(1, num2);
					continue;
				}
				if (num2 < 2048)
				{
					update(2, access_0024300((char)num2));
					continue;
				}
				if (num2 < 55296 || num2 > 57343)
				{
					update(3, access_0024400((char)num2));
					continue;
				}
				i2 = i;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				int num3 = Character.codePointAt(charSequence2, i2);
				if (num3 == num2)
				{
					int num6 = i;
					int i3 = num;
					i2 = num6;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					obj = (charSequence2.___003Cref_003E = charSequence2.subSequence(i2, i3).___003Cref_003E);
					base.putBytes(java.lang.String.instancehelper_getBytes(charSequence2.toString(), P_1));
					return this;
				}
				i++;
				update(4, access_0024500(num3));
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 56, 98, 105 })]
		public override Hasher putChar(char P_0)
		{
			update(2, (int)P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 224, 106, 107 })]
		public override Hasher putLong(long P_0)
		{
			update(4, (int)P_0);
			update(4, (long)((ulong)P_0 >> 32));
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 204, 103, 108, 105, 143, 104, 144, 104 })]
		public override Hasher putBytes(ByteBuffer P_0)
		{
			ByteOrder bo = P_0.order();
			P_0.order(ByteOrder.LITTLE_ENDIAN);
			while (P_0.remaining() >= 4)
			{
				this.putInt(P_0.getInt());
			}
			while (P_0.hasRemaining())
			{
				this.putByte((byte)(sbyte)P_0.get());
			}
			P_0.order(bo);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 191, 139, 104, 49, 166, 100, 44, 166 })]
		public override Hasher putBytes(byte[] P_0, int P_1, int P_2)
		{
			Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
			int i;
			for (i = 0; i + 4 <= P_2; i += 4)
			{
				update(4, access_0024200(P_0, P_1 + i));
			}
			for (; i < P_2; i++)
			{
				this.putByte(P_0[P_1 + i]);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 164, 104, 103, 103, 103 })]
		internal Murmur3_32Hasher(int P_0)
		{
			h1 = P_0;
			length = 0;
			isDone = false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 27, 113, 103, 121 })]
		public override HashCode hash()
		{
			Preconditions.checkState((!isDone) ? true : false);
			isDone = true;
			h1 ^= access_0024000((int)buffer);
			HashCode result = access_0024600(h1, length);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(270)]
		public override PrimitiveSink putString(CharSequence P_0, Charset P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			Hasher result = this.putString(charSequence2, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(270)]
		public override PrimitiveSink putChar(char P_0)
		{
			Hasher result = this.putChar(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(270)]
		public override PrimitiveSink putLong(long P_0)
		{
			Hasher result = this.putLong(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(270)]
		public override PrimitiveSink putInt(int P_0)
		{
			Hasher result = this.putInt(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(270)]
		public override PrimitiveSink putBytes(ByteBuffer P_0)
		{
			Hasher result = this.putBytes(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(270)]
		public override PrimitiveSink putBytes(byte[] P_0, int P_1, int P_2)
		{
			Hasher result = this.putBytes(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(270)]
		public override PrimitiveSink putByte(byte P_0)
		{
			int num = (sbyte)P_0;
			Hasher result = this.putByte((byte)num);
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static HashFunction MURMUR3_32;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static HashFunction MURMUR3_32_FIXED;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static HashFunction GOOD_FAST_HASH_32;

	private const int CHUNK_SIZE = 4;

	private const int C1 = -862048943;

	private const int C2 = 461845907;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int seed;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool supplementaryPlaneFix;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 124, 130, 104, 103, 103 })]
	internal Murmur3_32HashFunction(int P_0, bool P_1)
	{
		seed = P_0;
		supplementaryPlaneFix = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(55)]
	internal static int access_0024000(int P_0)
	{
		int result = mixK1(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(55)]
	internal static int access_0024100(int P_0, int P_1)
	{
		int result = mixH1(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(55)]
	internal static int access_0024200(byte[] P_0, int P_1)
	{
		int intLittleEndian = getIntLittleEndian(P_0, P_1);
		_ = null;
		return intLittleEndian;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(55)]
	internal static long access_0024300(char P_0)
	{
		long result = charToTwoUtf8Bytes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(55)]
	internal static long access_0024400(char P_0)
	{
		long result = charToThreeUtf8Bytes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(55)]
	internal static long access_0024500(int P_0)
	{
		long result = codePointToFourUtf8Bytes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(55)]
	internal static HashCode access_0024600(int P_0, int P_1)
	{
		HashCode result = fmix(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 147, 101, 104, 105, 104, 105, 104 })]
	private static HashCode fmix(int P_0, int P_1)
	{
		P_0 ^= P_1;
		P_0 ^= (int)((uint)P_0 >> 16);
		P_0 *= -2048144789;
		P_0 ^= (int)((uint)P_0 >> 13);
		P_0 *= -1028477387;
		P_0 ^= (int)((uint)P_0 >> 16);
		HashCode result = HashCode.fromInt(P_0);
		_ = null;
		return result;
	}

	private static long codePointToFourUtf8Bytes(int P_0)
	{
		return 0xF0u | (int)((uint)P_0 >> 18) | ((0x80u | (int)(0x3F & ((uint)P_0 >> 12))) << 8) | ((0x80u | (int)(0x3F & ((uint)P_0 >> 6))) << 16) | ((0x80u | (0x3F & P_0)) << 24);
	}

	private static long charToThreeUtf8Bytes(char P_0)
	{
		return 0xE0u | (int)((uint)P_0 >> 12) | (int)((0x80 | (0x3F & ((uint)P_0 >> 6))) << 8) | ((0x80 | (0x3F & P_0)) << 16);
	}

	private static long charToTwoUtf8Bytes(char P_0)
	{
		return 0xC0u | (int)((uint)P_0 >> 6) | ((0x80 | (0x3F & P_0)) << 8);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(242)]
	private static int getIntLittleEndian(byte[] P_0, int P_1)
	{
		int result = Ints.fromBytes(P_0[P_1 + 3], P_0[P_1 + 2], P_0[P_1 + 1], P_0[P_1]);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 139, 101, 106, 107 })]
	private static int mixH1(int P_0, int P_1)
	{
		P_0 ^= P_1;
		P_0 = Integer.rotateLeft(P_0, 13);
		P_0 = P_0 * 5 + -430675100;
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 132, 105, 106, 105 })]
	private static int mixK1(int P_0)
	{
		P_0 *= -862048943;
		P_0 = Integer.rotateLeft(P_0, 15);
		P_0 *= 461845907;
		return P_0;
	}

	public override int bits()
	{
		return 32;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(86)]
	public override Hasher newHasher()
	{
		Murmur3_32Hasher result = new Murmur3_32Hasher(seed);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(91)]
	public override string toString()
	{
		int i = seed;
		int num = 31;
		num = num;
		string result = new StringBuilder(num).append("Hashing.murmur3_32(").append(i).append(")")
			.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 46, 104, 103, 159, 2 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is Murmur3_32HashFunction)
		{
			Murmur3_32HashFunction murmur3_32HashFunction = (Murmur3_32HashFunction)P_0;
			return (seed == murmur3_32HashFunction.seed && supplementaryPlaneFix == murmur3_32HashFunction.supplementaryPlaneFix) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(105)]
	public override int hashCode()
	{
		return java.lang.Object.instancehelper_hashCode(java.lang.Object.instancehelper_getClass(this)) ^ seed;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 60, 103, 141 })]
	public override HashCode hashInt(int P_0)
	{
		int num = mixK1(P_0);
		int num2 = mixH1(seed, num);
		HashCode result = fmix(num2, 4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 68, 99, 134, 103, 141, 103, 136 })]
	public override HashCode hashLong(long P_0)
	{
		int num = (int)P_0;
		int num2 = (int)((ulong)P_0 >> 32);
		int num3 = mixK1(num);
		int num4 = mixH1(seed, num3);
		num3 = mixK1(num2);
		num4 = mixH1(num4, num3);
		HashCode result = fmix(num4, 8);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 109, 74, 167, 123, 127, 25, 105, 233, 61,
		233, 71, 120, 127, 14, 103, 164
	})]
	public override HashCode hashUnencodedChars(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		int num = seed;
		int num2 = 1;
		CharSequence charSequence2 = default(CharSequence);
		object obj;
		while (true)
		{
			int num3 = num2;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (num3 >= charSequence2.length())
			{
				break;
			}
			int i = num2 - 1;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			char num4 = charSequence2.charAt(i);
			i = num2;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num5 = (int)(num4 | ((uint)charSequence2.charAt(i) << 16));
			num5 = mixK1(num5);
			num = mixH1(num, num5);
			num2 += 2;
		}
		obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		if ((charSequence2.length() & 1) == 1)
		{
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int i = charSequence2.length() - 1;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			num2 = charSequence2.charAt(i);
			num2 = mixK1(num2);
			num ^= num2;
		}
		int num6 = num;
		obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		HashCode result = fmix(num6, 2 * charSequence2.length());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 104, 138, 112, 115, 104, 99, 163, 107, 121,
		123, 123, 123, 127, 8, 117, 105, 107, 102, 198,
		133, 100, 99, 105, 121, 105, 110, 102, 107, 105,
		114, 103, 107, 114, 114, 103, 139, 126, 134, 159,
		1, 102, 114, 104, 135, 166, 102, 106, 107, 103,
		231, 32, 235, 100, 106, 103, 140
	})]
	public override HashCode hashString(CharSequence P_0, Charset P_1)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence seq = default(CharSequence);
		object obj;
		if (!Charsets.___003C_003EUTF_8.equals(P_1))
		{
			obj = (seq.___003Cref_003E = __003Cref_003E);
			HashCode result = base.hashBytes(java.lang.String.instancehelper_getBytes(seq.toString(), P_1));
			_ = null;
			return result;
		}
		obj = (seq.___003Cref_003E = __003Cref_003E);
		int num = seq.length();
		int num2 = seed;
		int i = 0;
		int num3 = 0;
		int num6;
		int num7;
		while (i + 4 <= num)
		{
			int i2 = i;
			obj = (seq.___003Cref_003E = __003Cref_003E);
			int num4 = seq.charAt(i2);
			i2 = i + 1;
			obj = (seq.___003Cref_003E = __003Cref_003E);
			int num5 = seq.charAt(i2);
			i2 = i + 2;
			obj = (seq.___003Cref_003E = __003Cref_003E);
			num6 = seq.charAt(i2);
			i2 = i + 3;
			obj = (seq.___003Cref_003E = __003Cref_003E);
			num7 = seq.charAt(i2);
			if (num4 >= 128 || num5 >= 128 || num6 >= 128 || num7 >= 128)
			{
				break;
			}
			int num8 = num4 | (num5 << 8) | (num6 << 16) | (num7 << 24);
			num8 = mixK1(num8);
			num2 = mixH1(num2, num8);
			i += 4;
			num3 += 4;
		}
		long num9 = 0L;
		num6 = 0;
		for (; i < num; i++)
		{
			int i2 = i;
			obj = (seq.___003Cref_003E = __003Cref_003E);
			num7 = seq.charAt(i2);
			if (num7 < 128)
			{
				num9 |= (long)num7 << num6;
				num6 += 8;
				num3++;
			}
			else if (num7 < 2048)
			{
				num9 |= charToTwoUtf8Bytes((char)num7) << num6;
				num6 += 16;
				num3 += 2;
			}
			else if (num7 < 55296 || num7 > 57343)
			{
				num9 |= charToThreeUtf8Bytes((char)num7) << num6;
				num6 += 24;
				num3 += 3;
			}
			else
			{
				i2 = i;
				obj = (seq.___003Cref_003E = __003Cref_003E);
				int num8 = Character.codePointAt(seq, i2);
				if (num8 == num7)
				{
					obj = (seq.___003Cref_003E = __003Cref_003E);
					HashCode result2 = base.hashBytes(java.lang.String.instancehelper_getBytes(seq.toString(), P_1));
					_ = null;
					return result2;
				}
				i++;
				num9 |= codePointToFourUtf8Bytes(num8) << num6;
				if (supplementaryPlaneFix)
				{
					num6 += 32;
				}
				num3 += 4;
			}
			if (num6 >= 32)
			{
				int num8 = mixK1((int)num9);
				num2 = mixH1(num2, num8);
				num9 = (long)((ulong)num9 >> 32);
				num6 += -32;
			}
		}
		num7 = mixK1((int)num9);
		num2 ^= num7;
		HashCode result3 = fmix(num2, num3);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 111, 107, 135, 104, 111, 8, 230, 69, 98,
		102, 50, 170, 105
	})]
	public override HashCode hashBytes(byte[] P_0, int P_1, int P_2)
	{
		Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		int num = seed;
		int i;
		int num2;
		for (i = 0; i + 4 <= P_2; i += 4)
		{
			num2 = mixK1(getIntLittleEndian(P_0, P_1 + i));
			num = mixH1(num, num2);
		}
		num2 = 0;
		int num3 = 0;
		while (i < P_2)
		{
			num2 ^= UnsignedBytes.toInt(P_0[P_1 + i]) << num3;
			i++;
			num3 += 8;
		}
		num ^= mixK1(num2);
		HashCode result = fmix(num, P_2);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 6, 140, 236, 69 })]
	static Murmur3_32HashFunction()
	{
		MURMUR3_32 = new Murmur3_32HashFunction(0, false);
		MURMUR3_32_FIXED = new Murmur3_32HashFunction(0, true);
		GOOD_FAST_HASH_32 = new Murmur3_32HashFunction(Hashing.GOOD_FAST_HASH_SEED, true);
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Murmur3_32HashFunction(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
