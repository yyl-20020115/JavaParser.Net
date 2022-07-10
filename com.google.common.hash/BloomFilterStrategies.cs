using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.math;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.math;
using java.util;
using java.util.concurrent.atomic;
using javax.annotation;

namespace com.google.common.hash;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/common/hash/BloomFilterStrategies;>;Lcom/google/common/hash/BloomFilter$Strategy;")]
[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.hash.BloomFilter$Strategy" })]
internal abstract class BloomFilterStrategies : java.lang.Enum, BloomFilter.Strategy, Serializable.__Interface
{
	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)48,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class _1 : BloomFilterStrategies
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(47)]
		internal _1(string P_0, int P_1)
			: base(P_0, P_1, null)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;ILcom/google/common/hash/BloomFilterStrategies$LockFreeBitArray;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			4, 104, 114, 99, 134, 99, 104, 136, 101, 134,
			252, 58, 232, 72
		})]
		public override bool put([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/hash/ParametricNullness;"
		})] object P_0, Funnel P_1, int P_2, LockFreeBitArray P_3)
		{
			long num = P_3.bitSize();
			long num2 = Hashing.murmur3_128().hashObject(P_0, P_1).asLong();
			int num3 = (int)num2;
			int num4 = (int)((ulong)num2 >> 32);
			int num5 = 0;
			for (int i = 1; i <= P_2; i++)
			{
				int num6 = num3 + i * num4;
				if (num6 < 0)
				{
					num6 ^= -1;
				}
				int num7 = num5;
				long num8 = num6;
				num5 = num7 | (P_3.set((num != -1) ? (num8 % num) : 0) ? 1 : 0);
			}
			return (byte)num5 != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;ILcom/google/common/hash/BloomFilterStrategies$LockFreeBitArray;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			27, 104, 114, 99, 134, 104, 136, 101, 134, 121,
			226, 57, 232, 74
		})]
		public override bool mightContain([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/hash/ParametricNullness;"
		})] object P_0, Funnel P_1, int P_2, LockFreeBitArray P_3)
		{
			long num = P_3.bitSize();
			long num2 = Hashing.murmur3_128().hashObject(P_0, P_1).asLong();
			int num3 = (int)num2;
			int num4 = (int)((ulong)num2 >> 32);
			for (int i = 1; i <= P_2; i++)
			{
				int num5 = num3 + i * num4;
				if (num5 < 0)
				{
					num5 ^= -1;
				}
				long num6 = num5;
				if (!P_3.get((num != -1) ? (num6 % num) : 0))
				{
					return false;
				}
			}
			return true;
		}

		[HideFromJava]
		static _1()
		{
			BloomFilterStrategies.___003Cclinit_003E();
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)56,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class _2 : BloomFilterStrategies
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(101)]
		internal _2(string P_0, int P_1)
			: base(P_0, P_1, null)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(146)]
		private long lowerEight(byte[] P_0)
		{
			long result = Longs.fromBytes(P_0[7], P_0[6], P_0[5], P_0[4], P_0[3], P_0[2], P_0[1], P_0[0]);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(151)]
		private long upperEight(byte[] P_0)
		{
			long result = Longs.fromBytes(P_0[15], P_0[14], P_0[13], P_0[12], P_0[11], P_0[10], P_0[9], P_0[8]);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;ILcom/google/common/hash/BloomFilterStrategies$LockFreeBitArray;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 56, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			58, 104, 114, 104, 136, 99, 99, 136, 127, 6,
			230, 61, 232, 69
		})]
		public override bool put([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/hash/ParametricNullness;"
		})] object P_0, Funnel P_1, int P_2, LockFreeBitArray P_3)
		{
			long num = P_3.bitSize();
			byte[] bytesInternal = Hashing.murmur3_128().hashObject(P_0, P_1).getBytesInternal();
			long num2 = lowerEight(bytesInternal);
			long num3 = upperEight(bytesInternal);
			int num4 = 0;
			long num5 = num2;
			for (int i = 0; i < P_2; i++)
			{
				int num6 = num4;
				long num7 = num5 & 0x7FFFFFFFFFFFFFFFL;
				num4 = num6 | (P_3.set((num != -1) ? (num7 % num) : 0) ? 1 : 0);
				num5 += num3;
			}
			return (byte)num4 != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;ILcom/google/common/hash/BloomFilterStrategies$LockFreeBitArray;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 56, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			79, 104, 114, 104, 136, 99, 136, 127, 3, 130,
			230, 59, 232, 71
		})]
		public override bool mightContain([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/hash/ParametricNullness;"
		})] object P_0, Funnel P_1, int P_2, LockFreeBitArray P_3)
		{
			long num = P_3.bitSize();
			byte[] bytesInternal = Hashing.murmur3_128().hashObject(P_0, P_1).getBytesInternal();
			long num2 = lowerEight(bytesInternal);
			long num3 = upperEight(bytesInternal);
			long num4 = num2;
			for (int i = 0; i < P_2; i++)
			{
				long num5 = num4 & 0x7FFFFFFFFFFFFFFFL;
				if (!P_3.get((num != -1) ? (num5 % num) : 0))
				{
					return false;
				}
				num4 += num3;
			}
			return true;
		}

		[HideFromJava]
		static _2()
		{
			BloomFilterStrategies.___003Cclinit_003E();
		}
	}

	internal sealed class LockFreeBitArray : java.lang.Object
	{
		private const int LONG_ADDRESSABLE_BITS = 6;

		[Modifiers(Modifiers.Final)]
		internal AtomicLongArray data;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LongAddable m_bitCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(247)]
		internal virtual LockFreeBitArray copy()
		{
			LockFreeBitArray result = new LockFreeBitArray(toPlainArray(data));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(243)]
		internal virtual long bitCount()
		{
			long result = this.m_bitCount.sum();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(231)]
		internal virtual long bitSize()
		{
			return data.length() * 64u;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 146, 102, 157, 107, 229, 60, 229, 69, 112,
			51, 166
		})]
		internal virtual void putAll(LockFreeBitArray P_0)
		{
			Preconditions.checkArgument(data.length() == P_0.data.length(), "BitArrays must be of equal length (%s != %s)", data.length(), P_0.data.length());
			for (int i = 0; i < data.length(); i++)
			{
				putData(i, P_0.data.get(i));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 186, 104, 135, 158 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is LockFreeBitArray)
			{
				LockFreeBitArray lockFreeBitArray = (LockFreeBitArray)P_0;
				bool result = Arrays.equals(toPlainArray(data), toPlainArray(lockFreeBitArray.data));
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 117, 104, 175, 106, 116, 107 })]
		internal LockFreeBitArray(long P_0)
		{
			Preconditions.checkArgument(P_0 > 0, (object)"data length is zero!");
			data = new AtomicLongArray(Ints.checkedCast(LongMath.divide(P_0, 64L, RoundingMode.CEILING)));
			this.m_bitCount = LongAddables.create();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 163, 130, 109, 100, 100, 98, 130, 144, 99,
			110, 143
		})]
		internal virtual void putData(int P_0, long P_1)
		{
			int num = 1;
			long num2;
			long num3;
			do
			{
				num2 = data.get(P_0);
				num3 = num2 | P_1;
				if (num2 == num3)
				{
					num = 0;
					break;
				}
			}
			while (!data.compareAndSet(P_0, num2, num3));
			if (num != 0)
			{
				int num4 = Long.bitCount(num3) - Long.bitCount(num2);
				this.m_bitCount.add(num4);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 108, 108, 103, 42, 166 })]
		public static long[] toPlainArray(AtomicLongArray P_0)
		{
			long[] array = new long[P_0.length()];
			for (int i = 0; i < (nint)array.LongLength; i++)
			{
				array[i] = P_0.get(i);
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 127, 104, 111, 108, 107, 99, 115, 43, 168, 110 })]
		internal LockFreeBitArray(long[] P_0)
		{
			Preconditions.checkArgument((nint)P_0.LongLength > 0, (object)"data length is zero!");
			data = new AtomicLongArray(P_0);
			this.m_bitCount = LongAddables.create();
			long num = 0L;
			int num2 = P_0.Length;
			for (int i = 0; i < num2; i++)
			{
				long i2 = P_0[i];
				num += Long.bitCount(i2);
			}
			this.m_bitCount.add(num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 76, 105, 162, 101, 233, 69, 109, 100, 100,
			130, 176, 107
		})]
		internal virtual bool set(long P_0)
		{
			if (get(P_0))
			{
				return false;
			}
			int i = (int)((ulong)P_0 >> 6);
			long num = 1L << (int)P_0;
			long num2;
			long num3;
			do
			{
				num2 = data.get(i);
				num3 = num2 | num;
				if (num2 == num3)
				{
					return false;
				}
			}
			while (!data.compareAndSet(i, num2, num3));
			this.m_bitCount.increment();
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(213)]
		internal virtual bool get(long P_0)
		{
			return (data.get((int)((ulong)P_0 >> 6)) & (1L << (int)P_0)) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(295)]
		internal virtual int dataLength()
		{
			int result = data.length();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(311)]
		public override int hashCode()
		{
			int result = Arrays.hashCode(toPlainArray(data));
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static BloomFilterStrategies MURMUR128_MITZ_32;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static BloomFilterStrategies MURMUR128_MITZ_64;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static BloomFilterStrategies[] _0024VALUES;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	public static BloomFilterStrategies[] values()
	{
		return (BloomFilterStrategies[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()V")]
	[LineNumberTable(41)]
	private BloomFilterStrategies(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	private static BloomFilterStrategies[] _0024values()
	{
		return new BloomFilterStrategies[2] { MURMUR128_MITZ_32, MURMUR128_MITZ_64 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	public static BloomFilterStrategies valueOf(string P_0)
	{
		return (BloomFilterStrategies)java.lang.Enum.valueOf(ClassLiteral<BloomFilterStrategies>.Value, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(41)]
	internal BloomFilterStrategies(string P_0, int P_1, _1 P_2)
		: this(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[LineNumberTable(new byte[] { 159, 189, 240, 118, 240, 3 })]
	static BloomFilterStrategies()
	{
		MURMUR128_MITZ_32 = new _1("MURMUR128_MITZ_32", 0);
		MURMUR128_MITZ_64 = new _2("MURMUR128_MITZ_64", 1);
		_0024VALUES = _0024values();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract bool put(object P_0, Funnel P_1, int P_2, LockFreeBitArray P_3);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract bool mightContain(object P_0, Funnel P_1, int P_2, LockFreeBitArray P_3);

	int BloomFilter.Strategy.BloomFilter_0024Strategy_003A_003Aordinal()
	{
		return ordinal();
	}
}
