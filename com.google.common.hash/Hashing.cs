using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.security;
using java.util;
using java.util.function;
using java.util.zip;
using javax.annotation;
using javax.crypto.spec;

namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
public sealed class Hashing : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/hash/Hashing$ChecksumType;>;Lcom/google/common/hash/ImmutableSupplier<Ljava/util/zip/Checksum;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[Immutable(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/Immutable;"
	})]
	[Implements(new string[] { "com.google.common.hash.ImmutableSupplier" })]
	internal abstract class ChecksumType : java.lang.Enum, ImmutableSupplier, com.google.common.@base.Supplier, java.util.function.Supplier
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : ChecksumType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(429)]
			internal _1(string P_0, int P_1, string P_2)
				: base(P_0, P_1, P_2, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(432)]
			public new virtual Checksum get()
			{
				CRC32 result = new CRC32();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(429)]
			public override object get()
			{
				Checksum result = get();
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				ChecksumType.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : ChecksumType
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(435)]
			internal _2(string P_0, int P_1, string P_2)
				: base(P_0, P_1, P_2, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(438)]
			public new virtual Checksum get()
			{
				Adler32 result = new Adler32();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(435)]
			public override object get()
			{
				Checksum result = get();
				_ = null;
				return result;
			}

			[HideFromJava]
			static _2()
			{
				ChecksumType.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ChecksumType CRC_32;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ChecksumType ADLER_32;

		[Modifiers(Modifiers.Public | Modifiers.Final)]
		public HashFunction hashFunction;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static ChecksumType[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/String;)V")]
		[LineNumberTable(new byte[] { 161, 74, 106, 111 })]
		private ChecksumType(string P_0, int P_1, string P_2)
			: base(P_0, P_1)
		{
			hashFunction = new ChecksumHashFunction(this, 32, P_2);
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(427)]
		private static ChecksumType[] _0024values()
		{
			return new ChecksumType[2] { CRC_32, ADLER_32 };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(427)]
		public static ChecksumType[] values()
		{
			return (ChecksumType[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(427)]
		public static ChecksumType valueOf(string P_0)
		{
			return (ChecksumType)java.lang.Enum.valueOf(ClassLiteral<ChecksumType>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(428)]
		internal ChecksumType(string P_0, int P_1, string P_2, Hashing._1 P_3)
			: this(P_0, P_1, P_2)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 161, 59, 245, 70, 245, 56 })]
		static ChecksumType()
		{
			CRC_32 = new _1("CRC_32", 0, "Hashing.crc32()");
			ADLER_32 = new _2("ADLER_32", 1, "Hashing.adler32()");
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract object get();
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ConcatenatedHashFunction : AbstractCompositeHashFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(672)]
		internal ConcatenatedHashFunction(HashFunction[] P_0, Hashing._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 49, 103, 111, 97, 156, 230, 61, 37, 230,
			71
		})]
		private ConcatenatedHashFunction(params HashFunction[] P_0)
			: base(P_0)
		{
			int num = P_0.Length;
			for (int i = 0; i < num; i++)
			{
				HashFunction hashFunction = P_0[i];
				int num2 = hashFunction.bits();
				Preconditions.checkArgument((8 == -1 || num2 % 8 == 0) ? true : false, "the number of bits (%s) in hashFunction (%s) must be divisible by 8", hashFunction.bits(), hashFunction);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 72, 98, 117, 42, 166 })]
		public override int bits()
		{
			int num = 0;
			HashFunction[] array = functions;
			int num2 = array.Length;
			for (int i = 0; i < num2; i++)
			{
				HashFunction hashFunction = array[i];
				num += hashFunction.bits();
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 61, 110, 98, 115, 105, 21, 200 })]
		internal override HashCode makeHash(Hasher[] P_0)
		{
			byte[] array = new byte[bits() / 8];
			int num = 0;
			int num2 = P_0.Length;
			for (int i = 0; i < num2; i++)
			{
				Hasher hasher = P_0[i];
				HashCode hashCode = hasher.hash();
				num += hashCode.writeBytesTo(array, num, hashCode.bits() / 8);
			}
			HashCode result = HashCode.fromBytesNoCopy(array);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 81, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is ConcatenatedHashFunction)
			{
				ConcatenatedHashFunction concatenatedHashFunction = (ConcatenatedHashFunction)P_0;
				bool result = Arrays.equals(functions, concatenatedHashFunction.functions);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(716)]
		public override int hashCode()
		{
			int result = Arrays.hashCode(functions);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class LinearCongruentialGenerator : java.lang.Object
	{
		private long state;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 101, 104, 103 })]
		public LinearCongruentialGenerator(long P_0)
		{
			state = P_0;
		}

		public virtual double nextDouble()
		{
			state = 2862933555777941757L * state + 1;
			return (double)((int)((ulong)state >> 33) + 1) / 2147483648.0;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Md5Holder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static HashFunction MD5;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(220)]
		private Md5Holder()
		{
		}

		[LineNumberTable(221)]
		static Md5Holder()
		{
			MD5 = new MessageDigestHashFunction("MD5", "Hashing.md5()");
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Sha1Holder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static HashFunction SHA_1;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(241)]
		private Sha1Holder()
		{
		}

		[LineNumberTable(242)]
		static Sha1Holder()
		{
			SHA_1 = new MessageDigestHashFunction("SHA-1", "Hashing.sha1()");
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Sha256Holder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static HashFunction SHA_256;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(250)]
		private Sha256Holder()
		{
		}

		[LineNumberTable(251)]
		static Sha256Holder()
		{
			SHA_256 = new MessageDigestHashFunction("SHA-256", "Hashing.sha256()");
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Sha384Holder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static HashFunction SHA_384;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(264)]
		private Sha384Holder()
		{
		}

		[LineNumberTable(265)]
		static Sha384Holder()
		{
			SHA_384 = new MessageDigestHashFunction("SHA-384", "Hashing.sha384()");
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Sha512Holder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static HashFunction SHA_512;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(274)]
		private Sha512Holder()
		{
		}

		[LineNumberTable(275)]
		static Sha512Holder()
		{
			SHA_512 = new MessageDigestHashFunction("SHA-512", "Hashing.sha512()");
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static int GOOD_FAST_HASH_SEED;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(180)]
	public static HashFunction murmur3_128()
	{
		return Murmur3_128HashFunction.MURMUR3_128;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 1, 110 })]
	internal static int checkPositiveAndMakeMultipleOf32(int P_0)
	{
		Preconditions.checkArgument(P_0 > 0, (object)"Number of bits must be positive");
		return (P_0 + 31) & -32;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(169)]
	public static HashFunction murmur3_128(int seed)
	{
		Murmur3_128HashFunction result = new Murmur3_128HashFunction(seed);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 6, 146, 15 })]
	private static string hmacToString(string P_0, Key P_1)
	{
		string result = java.lang.String.format("Hashing.%s(Key[algorithm=%s, format=%s])", P_0, P_1.getAlgorithm(), P_1.getFormat());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(288)]
	public static HashFunction hmacMd5(Key key)
	{
		MacHashFunction result = new MacHashFunction("HmacMD5", key, hmacToString("hmacMd5", key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(312)]
	public static HashFunction hmacSha1(Key key)
	{
		MacHashFunction result = new MacHashFunction("HmacSHA1", key, hmacToString("hmacSha1", key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(336)]
	public static HashFunction hmacSha256(Key key)
	{
		MacHashFunction result = new MacHashFunction("HmacSHA256", key, hmacToString("hmacSha256", key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(360)]
	public static HashFunction hmacSha512(Key key)
	{
		MacHashFunction result = new MacHashFunction("HmacSHA512", key, hmacToString("hmacSha512", key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 190, 111, 103, 226, 69, 113, 104, 132 })]
	public static int consistentHash(long input, int buckets)
	{
		Preconditions.checkArgument(buckets > 0, "buckets must be positive: %s", buckets);
		LinearCongruentialGenerator linearCongruentialGenerator = new LinearCongruentialGenerator(input);
		int num = 0;
		while (true)
		{
			int num2 = ByteCodeHelper.d2i((double)(num + 1) / linearCongruentialGenerator.nextDouble());
			if (num2 < 0 || num2 >= buckets)
			{
				break;
			}
			num = num2;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		15, 135, 101, 134, 104, 198, 107, 103, 104, 102,
		104, 104, 10, 200
	})]
	public static HashFunction goodFastHash(int minimumBits)
	{
		int num = checkPositiveAndMakeMultipleOf32(minimumBits);
		if (num == 32)
		{
			return Murmur3_32HashFunction.GOOD_FAST_HASH_32;
		}
		if (num <= 128)
		{
			return Murmur3_128HashFunction.GOOD_FAST_HASH_128;
		}
		int num2 = (num + 127) / 128;
		HashFunction[] array = new HashFunction[num2];
		array[0] = Murmur3_128HashFunction.GOOD_FAST_HASH_128;
		int num3 = GOOD_FAST_HASH_SEED;
		for (int i = 1; i < num2; i++)
		{
			num3 += 1500450271;
			array[i] = murmur3_128(num3);
		}
		ConcatenatedHashFunction result = new ConcatenatedHashFunction(array, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(108)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static HashFunction murmur3_32(int seed)
	{
		Murmur3_32HashFunction result = new Murmur3_32HashFunction(seed, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(126)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static HashFunction murmur3_32()
	{
		return Murmur3_32HashFunction.MURMUR3_32;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(142)]
	public static HashFunction murmur3_32_fixed(int seed)
	{
		Murmur3_32HashFunction result = new Murmur3_32HashFunction(seed, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(158)]
	public static HashFunction murmur3_32_fixed()
	{
		return Murmur3_32HashFunction.MURMUR3_32_FIXED;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(190)]
	public static HashFunction sipHash24()
	{
		return SipHashFunction.SIP_HASH_24;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(200)]
	public static HashFunction sipHash24(long k0, long k1)
	{
		SipHashFunction result = new SipHashFunction(2, 4, k0, k1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(217)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static HashFunction md5()
	{
		return Md5Holder.MD5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(238)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static HashFunction sha1()
	{
		return Sha1Holder.SHA_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(247)]
	public static HashFunction sha256()
	{
		return Sha256Holder.SHA_256;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(261)]
	public static HashFunction sha384()
	{
		return Sha384Holder.SHA_384;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(271)]
	public static HashFunction sha512()
	{
		return Sha512Holder.SHA_512;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(300)]
	public static HashFunction hmacMd5(byte[] key)
	{
		HashFunction result = hmacMd5(new SecretKeySpec((byte[])Preconditions.checkNotNull(key), "HmacMD5"));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(324)]
	public static HashFunction hmacSha1(byte[] key)
	{
		HashFunction result = hmacSha1(new SecretKeySpec((byte[])Preconditions.checkNotNull(key), "HmacSHA1"));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(348)]
	public static HashFunction hmacSha256(byte[] key)
	{
		HashFunction result = hmacSha256(new SecretKeySpec((byte[])Preconditions.checkNotNull(key), "HmacSHA256"));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(372)]
	public static HashFunction hmacSha512(byte[] key)
	{
		HashFunction result = hmacSha512(new SecretKeySpec((byte[])Preconditions.checkNotNull(key), "HmacSHA512"));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(392)]
	public static HashFunction crc32c()
	{
		return Crc32cHashFunction.CRC_32_C;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(408)]
	public static HashFunction crc32()
	{
		return ChecksumType.CRC_32.hashFunction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(424)]
	public static HashFunction adler32()
	{
		return ChecksumType.ADLER_32.hashFunction;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(468)]
	public static HashFunction farmHashFingerprint64()
	{
		return FarmHashFingerprint64.FARMHASH_FINGERPRINT_64;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(492)]
	public static HashFunction fingerprint2011()
	{
		return Fingerprint2011.FINGERPRINT_2011;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(526)]
	public static int consistentHash(HashCode hashCode, int buckets)
	{
		int result = consistentHash(hashCode.padToLong(), buckets);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<Lcom/google/common/hash/HashCode;>;)Lcom/google/common/hash/HashCode;")]
	[LineNumberTable(new byte[]
	{
		161, 216, 103, 112, 113, 105, 124, 105, 145, 106,
		50, 168, 101
	})]
	public static HashCode combineOrdered(Iterable hashCodes)
	{
		Iterator iterator = hashCodes.iterator();
		Preconditions.checkArgument(iterator.hasNext(), (object)"Must be at least 1 hash code to combine.");
		int num = ((HashCode)iterator.next()).bits();
		byte[] array = new byte[num / 8];
		Iterator iterator2 = hashCodes.iterator();
		while (iterator2.hasNext())
		{
			HashCode hashCode = (HashCode)iterator2.next();
			byte[] array2 = hashCode.asBytes();
			Preconditions.checkArgument((nint)array2.LongLength == (nint)array.LongLength, (object)"All hashcodes must have the same bit length.");
			for (int i = 0; i < (nint)array2.LongLength; i++)
			{
				array[i] = (byte)(sbyte)((array[i] * 37) ^ array2[i]);
			}
		}
		HashCode result = HashCode.fromBytesNoCopy(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<Lcom/google/common/hash/HashCode;>;)Lcom/google/common/hash/HashCode;")]
	[LineNumberTable(new byte[]
	{
		161, 241, 103, 112, 120, 126, 104, 145, 106, 56,
		168, 101
	})]
	public static HashCode combineUnordered(Iterable hashCodes)
	{
		Iterator iterator = hashCodes.iterator();
		Preconditions.checkArgument(iterator.hasNext(), (object)"Must be at least 1 hash code to combine.");
		byte[] array = new byte[((HashCode)iterator.next()).bits() / 8];
		Iterator iterator2 = hashCodes.iterator();
		while (iterator2.hasNext())
		{
			HashCode hashCode = (HashCode)iterator2.next();
			byte[] array2 = hashCode.asBytes();
			Preconditions.checkArgument((nint)array2.LongLength == (nint)array.LongLength, (object)"All hashcodes must have the same bit length.");
			for (int i = 0; i < (nint)array2.LongLength; i++)
			{
				int num = i;
				byte[] array3 = array;
				array3[num] = (byte)(sbyte)(array3[num] + array2[i]);
			}
		}
		HashCode result = HashCode.fromBytesNoCopy(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 18, 102, 104, 104, 104 })]
	public static HashFunction concatenating(HashFunction first, HashFunction second, params HashFunction[] rest)
	{
		ArrayList arrayList = new ArrayList();
		((List)arrayList).add((object)first);
		((List)arrayList).add((object)second);
		Collections.addAll(arrayList, rest);
		ConcatenatedHashFunction result = new ConcatenatedHashFunction((HashFunction[])((List)arrayList).toArray((object[])new HashFunction[0]), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<Lcom/google/common/hash/HashFunction;>;)Lcom/google/common/hash/HashFunction;")]
	[LineNumberTable(new byte[] { 162, 36, 135, 102, 123, 104, 98, 124 })]
	public static HashFunction concatenating(Iterable hashFunctions)
	{
		Preconditions.checkNotNull(hashFunctions);
		ArrayList arrayList = new ArrayList();
		Iterator iterator = hashFunctions.iterator();
		while (iterator.hasNext())
		{
			HashFunction e = (HashFunction)iterator.next();
			((List)arrayList).add((object)e);
		}
		Preconditions.checkArgument((!((List)arrayList).isEmpty()) ? true : false, "number of hash functions (%s) must be > 0", ((List)arrayList).size());
		ConcatenatedHashFunction result = new ConcatenatedHashFunction((HashFunction[])((List)arrayList).toArray((object[])new HashFunction[0]), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(737)]
	private Hashing()
	{
	}

	[LineNumberTable(91)]
	static Hashing()
	{
		GOOD_FAST_HASH_SEED = (int)java.lang.System.currentTimeMillis();
	}
}
