using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.primitives;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.nio;
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
internal sealed class Murmur3_128HashFunction : AbstractHashFunction, Serializable.__Interface, ISerializable
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Murmur3_128Hasher : AbstractStreamingHasher
	{
		private const int CHUNK_SIZE = 16;

		private const long C1 = -8663945395140668459L;

		private const long C2 = 5545529020109919103L;

		private long h1;

		private long h2;

		private int length;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 61, 147, 115, 115, 150, 147, 115, 115, 118 })]
		private void bmix64(long P_0, long P_1)
		{
			h1 ^= mixK1(P_0);
			h1 = Long.rotateLeft(h1, 27);
			h1 += h2;
			h1 = h1 * 5 + 1390208809u;
			h2 ^= mixK2(P_1);
			h2 = Long.rotateLeft(h2, 31);
			h2 += h1;
			h2 = h2 * 5 + 944331445u;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 87, 109, 106, 109 })]
		private static long mixK1(long P_0)
		{
			P_0 *= -8663945395140668459L;
			P_0 = Long.rotateLeft(P_0, 31);
			P_0 *= 5545529020109919103L;
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 94, 109, 106, 109 })]
		private static long mixK2(long P_0)
		{
			P_0 *= 5545529020109919103L;
			P_0 = Long.rotateLeft(P_0, 33);
			P_0 *= -8663945395140668459L;
			return P_0;
		}

		private static long fmix64(long P_0)
		{
			P_0 ^= (long)((ulong)P_0 >> 33);
			P_0 *= -49064778989728563L;
			P_0 ^= (long)((ulong)P_0 >> 33);
			P_0 *= -4265267296055464877L;
			P_0 ^= (long)((ulong)P_0 >> 33);
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 46, 106, 104, 104, 103 })]
		internal Murmur3_128Hasher(int P_0)
			: base(16)
		{
			h1 = P_0;
			h2 = P_0;
			length = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 54, 103, 103, 104, 111 })]
		protected internal override void process(ByteBuffer P_0)
		{
			long @long = P_0.getLong();
			long long2 = P_0.getLong();
			bmix64(@long, long2);
			length += 16;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			76, 99, 99, 115, 159, 47, 149, 149, 149, 149,
			149, 148, 145, 105, 133, 148, 148, 148, 148, 148,
			147, 113, 130, 144, 115, 115
		})]
		protected internal override void processRemaining(ByteBuffer P_0)
		{
			long num = 0L;
			long num2 = 0L;
			length += P_0.remaining();
			switch (P_0.remaining())
			{
			case 15:
				num2 ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(14)) << 48;
				goto case 14;
			case 14:
				num2 ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(13)) << 40;
				goto case 13;
			case 13:
				num2 ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(12)) << 32;
				goto case 12;
			case 12:
				num2 ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(11)) << 24;
				goto case 11;
			case 11:
				num2 ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(10)) << 16;
				goto case 10;
			case 10:
				num2 ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(9)) << 8;
				goto case 9;
			case 9:
				num2 ^= UnsignedBytes.toInt((byte)(sbyte)P_0.get(8));
				goto case 8;
			case 8:
				num ^= P_0.getLong();
				break;
			case 7:
				num ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(6)) << 48;
				goto case 6;
			case 6:
				num ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(5)) << 40;
				goto case 5;
			case 5:
				num ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(4)) << 32;
				goto case 4;
			case 4:
				num ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(3)) << 24;
				goto case 3;
			case 3:
				num ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(2)) << 16;
				goto case 2;
			case 2:
				num ^= (long)UnsignedBytes.toInt((byte)(sbyte)P_0.get(1)) << 8;
				goto case 1;
			case 1:
				num ^= UnsignedBytes.toInt((byte)(sbyte)P_0.get(0));
				break;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError("Should never get here.");
			}
			h1 ^= mixK1(num);
			h2 ^= mixK2(num2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			121, 116, 148, 115, 147, 113, 145, 115, 147, 103,
			106, 107, 107, 101, 229, 59
		})]
		protected internal override HashCode makeHash()
		{
			h1 ^= length;
			h2 ^= length;
			h1 += h2;
			h2 += h1;
			h1 = fmix64(h1);
			h2 = fmix64(h2);
			h1 += h2;
			h2 += h1;
			HashCode result = HashCode.fromBytesNoCopy(ByteBuffer.wrap(new byte[16]).order(ByteOrder.LITTLE_ENDIAN).putLong(h1)
				.putLong(h2)
				.array());
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static HashFunction MURMUR3_128;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static HashFunction GOOD_FAST_HASH_128;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int seed;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 104, 103 })]
	internal Murmur3_128HashFunction(int P_0)
	{
		seed = P_0;
	}

	public override int bits()
	{
		return 128;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	public override Hasher newHasher()
	{
		Murmur3_128Hasher result = new Murmur3_128Hasher(seed);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(70)]
	public override string toString()
	{
		int i = seed;
		int num = 32;
		num = num;
		string result = new StringBuilder(num).append("Hashing.murmur3_128(").append(i).append(")")
			.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 25, 104, 103, 143 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is Murmur3_128HashFunction)
		{
			Murmur3_128HashFunction murmur3_128HashFunction = (Murmur3_128HashFunction)P_0;
			return seed == murmur3_128HashFunction.seed;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(84)]
	public override int hashCode()
	{
		return java.lang.Object.instancehelper_hashCode(java.lang.Object.instancehelper_getClass(this)) ^ seed;
	}

	[LineNumberTable(new byte[] { 159, 188, 139 })]
	static Murmur3_128HashFunction()
	{
		MURMUR3_128 = new Murmur3_128HashFunction(0);
		GOOD_FAST_HASH_128 = new Murmur3_128HashFunction(Hashing.GOOD_FAST_HASH_SEED);
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
	protected Murmur3_128HashFunction(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
