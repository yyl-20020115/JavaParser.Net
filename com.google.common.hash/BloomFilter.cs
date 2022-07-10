using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.math;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.math;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.hash;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Predicate<TT;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 190, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)190,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
public sealed class BloomFilter : java.lang.Object, com.google.common.@base.Predicate, java.util.function.Predicate, Serializable.__Interface, ISerializable
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
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 57, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)57,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class SerialForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		internal long[] data;

		[Modifiers(Modifiers.Final)]
		internal int numHashFunctions;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/hash/Funnel<-TT;>;")]
		internal Funnel funnel;

		[Modifiers(Modifiers.Final)]
		internal Strategy strategy;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/hash/BloomFilter<TT;>;)V")]
		[LineNumberTable(new byte[] { 161, 177, 104, 118, 108, 108, 108 })]
		internal SerialForm(BloomFilter P_0)
		{
			data = BloomFilterStrategies.LockFreeBitArray.toPlainArray(access_0024000(P_0).data);
			numHashFunctions = access_0024100(P_0);
			funnel = access_0024200(P_0);
			strategy = access_0024300(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(555)]
		internal virtual object readResolve()
		{
			BloomFilter result = new BloomFilter(new BloomFilterStrategies.LockFreeBitArray(data), numHashFunctions, funnel, strategy, null);
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SerialForm(SerializationInfo P_0, StreamingContext P_1)
		{
			Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(SerialForm))
			{
				return this;
			}
			return readResolve();
		}
	}

	[ConstantPool(new object[]
	{
		(byte)12,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal interface Strategy : Serializable.__Interface
	{
		[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;ILcom/google/common/hash/BloomFilterStrategies$LockFreeBitArray;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 12, 0, 0 })]
		virtual bool mightContain([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/hash/ParametricNullness;"
		})] object P_0, Funnel P_1, int P_2, BloomFilterStrategies.LockFreeBitArray P_3);

		[Signature("<T:Ljava/lang/Object;>(TT;Lcom/google/common/hash/Funnel<-TT;>;ILcom/google/common/hash/BloomFilterStrategies$LockFreeBitArray;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 12, 0, 0 })]
		virtual bool put([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/hash/ParametricNullness;"
		})] object P_0, Funnel P_1, int P_2, BloomFilterStrategies.LockFreeBitArray P_3);

		virtual int ordinal();
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Supplier
	{
		private readonly Funnel arg_00241;

		private readonly long arg_00242;

		private readonly double arg_00243;

		internal ___003C_003EAnon0(Funnel P_0, long P_1, double P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public object get()
		{
			BloomFilter result = lambda_0024toBloomFilter_00240(arg_00241, arg_00242, arg_00243);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : BiConsumer
	{
		internal ___003C_003EAnon1()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((BloomFilter)P_0).put(P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BinaryOperator
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0, object P_1)
		{
			BloomFilter result = lambda_0024toBloomFilter_00241((BloomFilter)P_0, (BloomFilter)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private BloomFilterStrategies.LockFreeBitArray bits;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int numHashFunctions;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/hash/Funnel<-TT;>;")]
	private Funnel funnel;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Strategy strategy;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/hash/BloomFilterStrategies$LockFreeBitArray;ILcom/google/common/hash/Funnel<-TT;>;Lcom/google/common/hash/BloomFilter$Strategy;)V")]
	[LineNumberTable(new byte[] { 73, 104, 111, 150, 113, 103, 113, 114 })]
	private BloomFilter(BloomFilterStrategies.LockFreeBitArray P_0, int P_1, Funnel P_2, Strategy P_3)
	{
		Preconditions.checkArgument(P_1 > 0, "numHashFunctions (%s) must be > 0", P_1);
		Preconditions.checkArgument(P_1 <= 255, "numHashFunctions (%s) must be <= 255", P_1);
		bits = (BloomFilterStrategies.LockFreeBitArray)Preconditions.checkNotNull(P_0);
		numHashFunctions = P_1;
		funnel = (Funnel)Preconditions.checkNotNull(P_2);
		strategy = (Strategy)Preconditions.checkNotNull(P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)Z")]
	[LineNumberTable(148)]
	public virtual bool mightContain([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/hash/ParametricNullness;"
	})] object @object)
	{
		bool result = strategy.mightContain(@object, funnel, numHashFunctions, bits);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(217)]
	internal virtual long bitSize()
	{
		long result = bits.bitSize();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/hash/Funnel<-TT;>;JD)Ljava/util/stream/Collector<TT;*Lcom/google/common/hash/BloomFilter<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 190, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 235, 103, 147, 122, 122 })]
	public static Collector toBloomFilter(Funnel funnel, long expectedInsertions, double fpp)
	{
		Preconditions.checkNotNull(funnel);
		Preconditions.checkArgument(expectedInsertions >= 0, "Expected insertions (%s) must be >= 0", expectedInsertions);
		Preconditions.checkArgument(fpp > 0.0, "False positive probability (%s) must be > 0.0", java.lang.Double.valueOf(fpp));
		Preconditions.checkArgument(fpp < 1.0, "False positive probability (%s) must be < 1.0", java.lang.Double.valueOf(fpp));
		Collector result = Collector.of(new ___003C_003EAnon0(funnel, expectedInsertions, fpp), new ___003C_003EAnon1(), new ___003C_003EAnon2(), Collector.Characteristics.UNORDERED, Collector.Characteristics.CONCURRENT);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/hash/Funnel<-TT;>;JD)Lcom/google/common/hash/BloomFilter<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 190, 0, 0 })]
	[LineNumberTable(413)]
	public static BloomFilter create(Funnel funnel, long expectedInsertions, double fpp)
	{
		BloomFilter result = create(funnel, expectedInsertions, fpp, BloomFilterStrategies.MURMUR128_MITZ_64);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/hash/Funnel<-TT;>;JDLcom/google/common/hash/BloomFilter$Strategy;)Lcom/google/common/hash/BloomFilter<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 190, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		161, 49, 103, 147, 122, 122, 135, 105, 228, 71,
		105, 136, 127, 5, 98
	})]
	internal static BloomFilter create(Funnel P_0, long P_1, double P_2, Strategy P_3)
	{
		//Discarded unreachable code: IL_0083
		Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument(P_1 >= 0, "Expected insertions (%s) must be >= 0", P_1);
		Preconditions.checkArgument(P_2 > 0.0, "False positive probability (%s) must be > 0.0", java.lang.Double.valueOf(P_2));
		Preconditions.checkArgument(P_2 < 1.0, "False positive probability (%s) must be < 1.0", java.lang.Double.valueOf(P_2));
		Preconditions.checkNotNull(P_3);
		if (P_1 == 0)
		{
			P_1 = 1L;
		}
		long num = optimalNumOfBits(P_1, P_2);
		int num2 = optimalNumOfHashFunctions(P_1, num);
		IllegalArgumentException ex;
		try
		{
			return new BloomFilter(new BloomFilterStrategies.LockFreeBitArray(num), num2, P_0, P_3);
		}
		catch (IllegalArgumentException x)
		{
			ex = ByteCodeHelper.MapException<IllegalArgumentException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IllegalArgumentException cause = ex;
		int num3 = 57;
		num3 = num3;
		string message = new StringBuilder(num3).append("Could not create BloomFilter of ").append(num).append(" bits")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(message, cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 161, 105, 139 })]
	internal static long optimalNumOfBits(long P_0, double P_1)
	{
		if (P_1 == 0.0)
		{
			P_1 = double.Epsilon;
		}
		return ByteCodeHelper.d2l((double)(-P_0) * java.lang.Math.log(P_1) / (java.lang.Math.log(2.0) * java.lang.Math.log(2.0)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(516)]
	internal static int optimalNumOfHashFunctions(long P_0, long P_1)
	{
		int result = java.lang.Math.max(1, (int)java.lang.Math.round((double)P_1 / (double)P_0 * java.lang.Math.log(2.0)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/hash/Funnel<-TT;>;J)Lcom/google/common/hash/BloomFilter<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 190, 0, 0 })]
	[LineNumberTable(489)]
	public static BloomFilter create(Funnel funnel, long expectedInsertions)
	{
		BloomFilter result = create(funnel, expectedInsertions, 0.03);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/hash/BloomFilter<TT;>;)V")]
	[LineNumberTable(new byte[]
	{
		160,
		140,
		103,
		113,
		byte.MaxValue,
		5,
		69,
		97,
		147,
		102,
		229,
		60,
		229,
		69,
		108,
		54,
		229,
		69,
		108,
		54,
		229,
		69,
		115
	})]
	public virtual void putAll(BloomFilter that)
	{
		Preconditions.checkNotNull(that);
		Preconditions.checkArgument(this != that, (object)"Cannot combine a BloomFilter with itself.");
		Preconditions.checkArgument(numHashFunctions == that.numHashFunctions, "BloomFilters must have the same number of hash functions (%s != %s)", numHashFunctions, that.numHashFunctions);
		Preconditions.checkArgument(bitSize() == that.bitSize(), "BloomFilters must have the same size underlying bit arrays (%s != %s)", bitSize(), that.bitSize());
		Preconditions.checkArgument(java.lang.Object.instancehelper_equals(strategy, that.strategy), "BloomFilters must have equal strategies (%s != %s)", strategy, that.strategy);
		Preconditions.checkArgument(java.lang.Object.instancehelper_equals(funnel, that.funnel), "BloomFilters must have equal funnels (%s != %s)", funnel, that.funnel);
		bits.putAll(that.bits);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(355)]
	private static BloomFilter lambda_0024toBloomFilter_00240(Funnel P_0, long P_1, double P_2)
	{
		BloomFilter result = create(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)Z")]
	[LineNumberTable(174)]
	public virtual bool put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/hash/ParametricNullness;"
	})] object @object)
	{
		bool result = strategy.put(@object, funnel, numHashFunctions, bits);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 160, 244, 103 })]
	private static BloomFilter lambda_0024toBloomFilter_00241(BloomFilter P_0, BloomFilter P_1)
	{
		P_0.putAll(P_1);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/hash/BloomFilter<TT;>;")]
	[LineNumberTable(140)]
	public virtual BloomFilter copy()
	{
		BloomFilter result = new BloomFilter(bits.copy(), numHashFunctions, funnel, strategy);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TT;)Z")]
	[LineNumberTable(158)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual bool apply([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/hash/ParametricNullness;"
	})] object input)
	{
		bool result = mightContain(input);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(189)]
	public virtual double expectedFpp()
	{
		double result = java.lang.Math.pow((double)bits.bitCount() / (double)bitSize(), numHashFunctions);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 86, 108, 236, 72, 103, 98, 54 })]
	public virtual long approximateElementCount()
	{
		long num = bits.bitSize();
		long num2 = bits.bitCount();
		double num3 = (double)num2 / (double)num;
		long result = DoubleMath.roundToLong((0.0 - java.lang.Math.log1p(0.0 - num3)) * (double)num / (double)numHashFunctions, RoundingMode.HALF_UP);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/hash/BloomFilter<TT;>;)Z")]
	[LineNumberTable(new byte[] { 160, 122, 103, 147, 121, 115, 235, 60 })]
	public virtual bool isCompatible(BloomFilter that)
	{
		Preconditions.checkNotNull(that);
		return (this != that && numHashFunctions == that.numHashFunctions && bitSize() == that.bitSize() && java.lang.Object.instancehelper_equals(strategy, that.strategy) && java.lang.Object.instancehelper_equals(funnel, that.funnel)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 167, 100, 130, 104, 103, 122, 115, 115, 235,
		61, 225, 69
	})]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		if (@object == this)
		{
			return true;
		}
		if (@object is BloomFilter)
		{
			BloomFilter bloomFilter = (BloomFilter)@object;
			return (numHashFunctions == bloomFilter.numHashFunctions && java.lang.Object.instancehelper_equals(funnel, bloomFilter.funnel) && bits.equals(bloomFilter.bits) && java.lang.Object.instancehelper_equals(strategy, bloomFilter.strategy)) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(296)]
	public override int hashCode()
	{
		int result = Objects.hashCode(Integer.valueOf(numHashFunctions), funnel, strategy, bits);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/hash/Funnel<-TT;>;J)Ljava/util/stream/Collector<TT;*Lcom/google/common/hash/BloomFilter<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 190, 0, 0 })]
	[LineNumberTable(322)]
	public static Collector toBloomFilter(Funnel funnel, long expectedInsertions)
	{
		Collector result = toBloomFilter(funnel, expectedInsertions, 0.03);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/hash/Funnel<-TT;>;ID)Lcom/google/common/hash/BloomFilter<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 190, 0, 0 })]
	[LineNumberTable(387)]
	public static BloomFilter create(Funnel funnel, int expectedInsertions, double fpp)
	{
		BloomFilter result = create(funnel, (long)expectedInsertions, fpp);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/hash/Funnel<-TT;>;I)Lcom/google/common/hash/BloomFilter<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 190, 0, 0 })]
	[LineNumberTable(464)]
	public static BloomFilter create(Funnel funnel, int expectedInsertions)
	{
		BloomFilter result = create(funnel, (long)expectedInsertions);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(538)]
	private object writeReplace()
	{
		SerialForm result = new SerialForm(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 161, 204, 103, 120, 115, 118, 117, 55, 166 })]
	public virtual void writeTo(OutputStream @out)
	{
		DataOutputStream dataOutputStream = new DataOutputStream(@out);
		dataOutputStream.writeByte((sbyte)SignedBytes.checkedCast(strategy.ordinal()));
		dataOutputStream.writeByte((sbyte)UnsignedBytes.checkedCast(numHashFunctions));
		dataOutputStream.writeInt(bits.data.length());
		for (int i = 0; i < bits.data.length(); i++)
		{
			dataOutputStream.writeLong(bits.data.get(i));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/io/InputStream;Lcom/google/common/hash/Funnel<-TT;>;)Lcom/google/common/hash/BloomFilter<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 190, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		161,
		226,
		108,
		108,
		98,
		98,
		130,
		199,
		104,
		109,
		135,
		137,
		113,
		104,
		47,
		200,
		127,
		12,
		98,
		byte.MaxValue,
		54,
		72
	})]
	public static BloomFilter readFrom(InputStream @in, Funnel funnel)
	{
		//Discarded unreachable code: IL_0087
		Preconditions.checkNotNull((object)@in, (object)"InputStream");
		Preconditions.checkNotNull((object)funnel, (object)"Funnel");
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		RuntimeException ex2;
		int i;
		try
		{
			DataInputStream dataInputStream = new DataInputStream(@in);
			num = (sbyte)dataInputStream.readByte();
			num2 = UnsignedBytes.toInt((byte)(sbyte)dataInputStream.readByte());
			num3 = dataInputStream.readInt();
			BloomFilterStrategies bloomFilterStrategies = BloomFilterStrategies.values()[num];
			BloomFilterStrategies.LockFreeBitArray lockFreeBitArray = new BloomFilterStrategies.LockFreeBitArray(LongMath.checkedMultiply(num3, 64L));
			for (i = 0; i < num3; i++)
			{
				lockFreeBitArray.putData(i, dataInputStream.readLong());
			}
			return new BloomFilter(lockFreeBitArray, num2, funnel, bloomFilterStrategies);
		}
		catch (System.Exception x)
		{
			RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		RuntimeException cause = ex2;
		int i2 = num;
		i = num2;
		int i3 = num3;
		int num4 = 134;
		num4 = num4;
		string message = new StringBuilder(num4).append("Unable to deserialize BloomFilter from InputStream. strategyOrdinal: ").append(i2).append(" numHashFunctions: ")
			.append(i)
			.append(" dataLength: ")
			.append(i3)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IOException(message, cause);
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(70)]
	internal static BloomFilterStrategies.LockFreeBitArray access_0024000(BloomFilter P_0)
	{
		return P_0.bits;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(70)]
	internal static int access_0024100(BloomFilter P_0)
	{
		return P_0.numHashFunctions;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(70)]
	internal static Funnel access_0024200(BloomFilter P_0)
	{
		return P_0.funnel;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(70)]
	internal static Strategy access_0024300(BloomFilter P_0)
	{
		return P_0.strategy;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(70)]
	internal BloomFilter(BloomFilterStrategies.LockFreeBitArray P_0, int P_1, Funnel P_2, Strategy P_3, _1 P_4)
		: this(P_0, P_1, P_2, P_3)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool test(object P_0)
	{
		return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
	{
		return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Predicate negate()
	{
		return java.util.function.Predicate._003Cdefault_003Enegate(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
	{
		return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
	}

	[HideFromJava]
	public static implicit operator Serializable(BloomFilter P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
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
	protected BloomFilter(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
