using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.nio;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.math;

[Serializable]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class Stats : java.lang.Object, Serializable.__Interface, ISerializable
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Supplier
	{
		internal ___003C_003EAnon0()
		{
		}

		public object get()
		{
			StatsAccumulator result = new StatsAccumulator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : ObjDoubleConsumer
	{
		internal ___003C_003EAnon1()
		{
		}

		public void accept(object P_0, double P_1)
		{
			((StatsAccumulator)P_0).add(P_1);
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BiConsumer
	{
		internal ___003C_003EAnon2()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((StatsAccumulator)P_0).addAll((StatsAccumulator)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : ObjIntConsumer
	{
		internal ___003C_003EAnon3()
		{
		}

		public void accept(object P_0, int P_1)
		{
			((StatsAccumulator)P_0).add(P_1);
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : ObjLongConsumer
	{
		internal ___003C_003EAnon4()
		{
		}

		public void accept(object P_0, long P_1)
		{
			((StatsAccumulator)P_0).add(P_1);
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon5 : BiConsumer
	{
		internal ___003C_003EAnon5()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toStats_00240((StatsAccumulator)P_0, (Number)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon6 : BinaryOperator
	{
		internal ___003C_003EAnon6()
		{
		}

		public object apply(object P_0, object P_1)
		{
			StatsAccumulator result = lambda_0024toStats_00241((StatsAccumulator)P_0, (StatsAccumulator)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon7 : java.util.function.Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			Stats result = ((StatsAccumulator)P_0).snapshot();
			_ = null;
			return result;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long m_count;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private double m_mean;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private double m_sumOfSquaresOfDeltas;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private double m_min;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private double m_max;

	internal const int BYTES = 40;

	private const long serialVersionUID = 0L;

	public virtual long count()
	{
		return this.m_count;
	}

	internal virtual double sumOfSquaresOfDeltas()
	{
		return this.m_sumOfSquaresOfDeltas;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 142, 114 })]
	public virtual double mean()
	{
		Preconditions.checkState(this.m_count != 0);
		return this.m_mean;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 51, 99, 130, 110, 130, 103, 119, 120, 120,
		120, 246, 60
	})]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (((object)this).GetType() != obj.GetType())
		{
			return false;
		}
		Stats stats = (Stats)obj;
		return (this.m_count == stats.m_count && java.lang.Double.doubleToLongBits(this.m_mean) == java.lang.Double.doubleToLongBits(stats.m_mean) && java.lang.Double.doubleToLongBits(this.m_sumOfSquaresOfDeltas) == java.lang.Double.doubleToLongBits(stats.m_sumOfSquaresOfDeltas) && java.lang.Double.doubleToLongBits(this.m_min) == java.lang.Double.doubleToLongBits(stats.m_min) && java.lang.Double.doubleToLongBits(this.m_max) == java.lang.Double.doubleToLongBits(stats.m_max)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 237, 103, 97, 180, 229, 60, 229, 69, 103,
		107, 107, 107, 107, 102
	})]
	internal virtual void writeTo(ByteBuffer P_0)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument(P_0.remaining() >= 40, "Expected at least Stats.BYTES = %s remaining , got %s", 40, P_0.remaining());
		P_0.putLong(this.m_count).putDouble(this.m_mean).putDouble(this.m_sumOfSquaresOfDeltas)
			.putDouble(this.m_min)
			.putDouble(this.m_max);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 23, 103, 97, 180, 229, 60, 229, 69, 97,
		102, 102, 102, 102, 236, 59
	})]
	internal static Stats readFrom(ByteBuffer P_0)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument(P_0.remaining() >= 40, "Expected at least Stats.BYTES = %s remaining , got %s", 40, P_0.remaining());
		Stats result = new Stats(P_0.getLong(), P_0.getDouble(), P_0.getDouble(), P_0.getDouble(), P_0.getDouble());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 178, 111, 109, 138, 106, 134 })]
	public virtual double populationVariance()
	{
		Preconditions.checkState(this.m_count > 0);
		if (java.lang.Double.isNaN(this.m_sumOfSquaresOfDeltas))
		{
			return double.NaN;
		}
		if (this.m_count == 1)
		{
			return 0.0;
		}
		return DoubleUtils.ensureNonNegative(this.m_sumOfSquaresOfDeltas) / (double)count();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 225, 111, 109, 138 })]
	public virtual double sampleVariance()
	{
		Preconditions.checkState(this.m_count > 1);
		if (java.lang.Double.isNaN(this.m_sumOfSquaresOfDeltas))
		{
			return double.NaN;
		}
		return DoubleUtils.ensureNonNegative(this.m_sumOfSquaresOfDeltas) / (double)(this.m_count - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(319)]
	public virtual double populationStandardDeviation()
	{
		double result = java.lang.Math.sqrt(populationVariance());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<+Ljava/lang/Number;>;)D")]
	[LineNumberTable(new byte[]
	{
		161, 120, 107, 99, 114, 104, 114, 101, 144, 140,
		137, 98
	})]
	public static double meanOf(Iterator values)
	{
		Preconditions.checkArgument(values.hasNext());
		long num = 1L;
		double num2 = ((Number)values.next()).doubleValue();
		while (values.hasNext())
		{
			double num3 = ((Number)values.next()).doubleValue();
			num++;
			num2 = ((!Doubles.isFinite(num3) || !Doubles.isFinite(num2)) ? StatsAccumulator.calculateNewMeanNonFinite(num2, num3) : (num2 + (num3 - num2) / (double)num));
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 40, 104, 103, 105, 105, 106, 106 })]
	internal Stats(long P_0, double P_1, double P_2, double P_3, double P_4)
	{
		this.m_count = P_0;
		this.m_mean = P_1;
		this.m_sumOfSquaresOfDeltas = P_2;
		this.m_min = P_3;
		this.m_max = P_4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(220)]
	private static void lambda_0024toStats_00240(StatsAccumulator P_0, Number P_1)
	{
		P_0.add(P_1.doubleValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 160, 108, 103 })]
	private static StatsAccumulator lambda_0024toStats_00241(StatsAccumulator P_0, StatsAccumulator P_1)
	{
		P_0.addAll(P_1);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Number;>;)Lcom/google/common/math/Stats;")]
	[LineNumberTable(new byte[] { 55, 102, 103 })]
	public static Stats of(Iterable values)
	{
		StatsAccumulator statsAccumulator = new StatsAccumulator();
		statsAccumulator.addAll(values);
		Stats result = statsAccumulator.snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<+Ljava/lang/Number;>;)Lcom/google/common/math/Stats;")]
	[LineNumberTable(new byte[] { 68, 102, 103 })]
	public static Stats of(Iterator values)
	{
		StatsAccumulator statsAccumulator = new StatsAccumulator();
		statsAccumulator.addAll(values);
		Stats result = statsAccumulator.snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 79, 102, 103 })]
	public static Stats of(params double[] values)
	{
		StatsAccumulator statsAccumulator = new StatsAccumulator();
		statsAccumulator.addAll(values);
		Stats result = statsAccumulator.snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 90, 102, 103 })]
	public static Stats of(params int[] values)
	{
		StatsAccumulator statsAccumulator = new StatsAccumulator();
		statsAccumulator.addAll(values);
		Stats result = statsAccumulator.snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 102, 102, 103 })]
	public static Stats of(params long[] values)
	{
		StatsAccumulator statsAccumulator = new StatsAccumulator();
		statsAccumulator.addAll(values);
		Stats result = statsAccumulator.snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 118, 127, 0, 106, 7 })]
	public static Stats of(DoubleStream values)
	{
		Stats result = ((StatsAccumulator)values.collect(new ___003C_003EAnon0(), new ___003C_003EAnon1(), new ___003C_003EAnon2())).snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 70, 127, 0, 106, 7 })]
	public static Stats of(IntStream values)
	{
		Stats result = ((StatsAccumulator)values.collect(new ___003C_003EAnon0(), new ___003C_003EAnon3(), new ___003C_003EAnon2())).snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 87, 127, 0, 106, 7 })]
	public static Stats of(LongStream values)
	{
		Stats result = ((StatsAccumulator)values.collect(new ___003C_003EAnon0(), new ___003C_003EAnon4(), new ___003C_003EAnon2())).snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/stream/Collector<Ljava/lang/Number;Lcom/google/common/math/StatsAccumulator;Lcom/google/common/math/Stats;>;")]
	[LineNumberTable(218)]
	public static Collector toStats()
	{
		Collector result = Collector.of(new ___003C_003EAnon0(), new ___003C_003EAnon5(), new ___003C_003EAnon6(), new ___003C_003EAnon7(), Collector.Characteristics.UNORDERED);
		_ = null;
		return result;
	}

	public virtual double sum()
	{
		return this.m_mean * (double)this.m_count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(365)]
	public virtual double sampleStandardDeviation()
	{
		double result = java.lang.Math.sqrt(sampleVariance());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 12, 114 })]
	public virtual double min()
	{
		Preconditions.checkState(this.m_count != 0);
		return this.m_min;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 30, 114 })]
	public virtual double max()
	{
		Preconditions.checkState(this.m_count != 0);
		return this.m_max;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(443)]
	public override int hashCode()
	{
		int result = com.google.common.@base.Objects.hashCode(Long.valueOf(this.m_count), java.lang.Double.valueOf(this.m_mean), java.lang.Double.valueOf(this.m_sumOfSquaresOfDeltas), java.lang.Double.valueOf(this.m_min), java.lang.Double.valueOf(this.m_max));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 78, 106, 113, 112, 107, 117, 112, 101, 231,
		58, 225, 72
	})]
	public override string toString()
	{
		if (count() > 0)
		{
			string result = MoreObjects.toStringHelper(this).add("count", this.m_count).add("mean", this.m_mean)
				.add("populationStandardDeviation", populationStandardDeviation())
				.add("min", this.m_min)
				.add("max", this.m_max)
				.toString();
			_ = null;
			return result;
		}
		string result2 = MoreObjects.toStringHelper(this).add("count", this.m_count).toString();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Number;>;)D")]
	[LineNumberTable(476)]
	public static double meanOf(Iterable values)
	{
		double result = meanOf(values.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 146, 106, 100, 103, 100, 144, 142, 233, 58,
		230, 73
	})]
	public static double meanOf(params double[] values)
	{
		Preconditions.checkArgument((nint)values.LongLength > 0);
		double num = values[0];
		for (int i = 1; i < (nint)values.LongLength; i++)
		{
			double num2 = values[i];
			num = ((!Doubles.isFinite(num2) || !Doubles.isFinite(num)) ? StatsAccumulator.calculateNewMeanNonFinite(num, num2) : (num + (num2 - num) / (double)(i + 1)));
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 170, 106, 101, 103, 101, 144, 142, 233, 58,
		230, 73
	})]
	public static double meanOf(params int[] values)
	{
		Preconditions.checkArgument((nint)values.LongLength > 0);
		double num = values[0];
		for (int i = 1; i < (nint)values.LongLength; i++)
		{
			double num2 = values[i];
			num = ((!Doubles.isFinite(num2) || !Doubles.isFinite(num)) ? StatsAccumulator.calculateNewMeanNonFinite(num, num2) : (num + (num2 - num) / (double)(i + 1)));
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 195, 106, 101, 103, 101, 144, 142, 233, 58,
		230, 73
	})]
	public static double meanOf(params long[] values)
	{
		Preconditions.checkArgument((nint)values.LongLength > 0);
		double num = values[0];
		for (int i = 1; i < (nint)values.LongLength; i++)
		{
			double num2 = values[i];
			num = ((!Doubles.isFinite(num2) || !Doubles.isFinite(num)) ? StatsAccumulator.calculateNewMeanNonFinite(num, num2) : (num + (num2 - num) / (double)(i + 1)));
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 221, 114, 103 })]
	public virtual byte[] toByteArray()
	{
		ByteBuffer byteBuffer = ByteBuffer.allocate(40).order(ByteOrder.LITTLE_ENDIAN);
		writeTo(byteBuffer);
		byte[] result = byteBuffer.array();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 3, 103, 244, 69 })]
	public static Stats fromByteArray(byte[] byteArray)
	{
		Preconditions.checkNotNull(byteArray);
		Preconditions.checkArgument((nint)byteArray.LongLength == 40, "Expected Stats.BYTES = %s remaining , got %s", 40, byteArray.Length);
		Stats result = readFrom(ByteBuffer.wrap(byteArray).order(ByteOrder.LITTLE_ENDIAN));
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(Stats P_0)
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
	protected Stats(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
