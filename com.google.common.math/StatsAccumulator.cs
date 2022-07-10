using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
public sealed class StatsAccumulator : Object
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

	private long m_count;

	private double m_mean;

	private double m_sumOfSquaresOfDeltas;

	private double m_min;

	private double m_max;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 200, 104, 108, 108, 112 })]
	public StatsAccumulator()
	{
		this.m_count = 0L;
		this.m_mean = 0.0;
		this.m_sumOfSquaresOfDeltas = 0.0;
		this.m_min = double.NaN;
		this.m_max = double.NaN;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		3, 106, 104, 105, 105, 105, 108, 181, 111, 150,
		107, 119, 121, 98, 116, 144, 116, 148
	})]
	public virtual void add(double value)
	{
		if (this.m_count == 0)
		{
			this.m_count = 1L;
			this.m_mean = value;
			this.m_min = value;
			this.m_max = value;
			if (!Doubles.isFinite(value))
			{
				this.m_sumOfSquaresOfDeltas = double.NaN;
			}
			return;
		}
		this.m_count++;
		if (Doubles.isFinite(value) && Doubles.isFinite(this.m_mean))
		{
			double num = value - this.m_mean;
			this.m_mean += num / (double)this.m_count;
			this.m_sumOfSquaresOfDeltas += num * (value - this.m_mean);
		}
		else
		{
			this.m_mean = calculateNewMeanNonFinite(this.m_mean, value);
			this.m_sumOfSquaresOfDeltas = double.NaN;
		}
		this.m_min = Math.min(this.m_min, value);
		this.m_max = Math.max(this.m_max, value);
	}

	public virtual long count()
	{
		return this.m_count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 133, 114 })]
	public virtual double mean()
	{
		Preconditions.checkState(this.m_count != 0);
		return this.m_mean;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 121, 106, 129, 127, 7 })]
	public virtual void addAll(Stats values)
	{
		if (values.count() != 0)
		{
			merge(values.count(), values.mean(), values.sumOfSquaresOfDeltas(), values.min(), values.max());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(220)]
	public virtual Stats snapshot()
	{
		Stats result = new Stats(this.m_count, this.m_mean, this.m_sumOfSquaresOfDeltas, this.m_min, this.m_max);
		_ = null;
		return result;
	}

	internal virtual double sumOfSquaresOfDeltas()
	{
		return this.m_sumOfSquaresOfDeltas;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Number;>;)V")]
	[LineNumberTable(new byte[] { 34, 123, 108, 98 })]
	public virtual void addAll(Iterable values)
	{
		Iterator iterator = values.iterator();
		while (iterator.hasNext())
		{
			Number number = (Number)iterator.next();
			add(number.doubleValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<+Ljava/lang/Number;>;)V")]
	[LineNumberTable(new byte[] { 46, 104, 152 })]
	public virtual void addAll(Iterator values)
	{
		while (values.hasNext())
		{
			add(((Number)values.next()).doubleValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 57, 111, 39, 166 })]
	public virtual void addAll(params double[] values)
	{
		int num = values.Length;
		for (int i = 0; i < num; i++)
		{
			double value = values[i];
			add(value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 68, 111, 40, 166 })]
	public virtual void addAll(params int[] values)
	{
		int num = values.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = values[i];
			add(num2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 80, 111, 40, 166 })]
	public virtual void addAll(params long[] values)
	{
		int num = values.Length;
		for (int i = 0; i < num; i++)
		{
			long num2 = values[i];
			add(num2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 48, 137, 99, 143, 163 })]
	internal static double calculateNewMeanNonFinite(double P_0, double P_1)
	{
		if (Doubles.isFinite(P_0))
		{
			return P_1;
		}
		if (Doubles.isFinite(P_1) || P_0 == P_1)
		{
			return P_0;
		}
		return double.NaN;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 70, 106, 129, 127, 7 })]
	public virtual void addAll(StatsAccumulator values)
	{
		if (values.count() != 0)
		{
			merge(values.count(), values.mean(), values.sumOfSquaresOfDeltas(), values.min(), values.max());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 82, 106, 103, 105, 105, 106, 143, 110, 150,
		107, 122, 127, 0, 98, 116, 144, 117, 149
	})]
	private void merge(long P_0, double P_1, double P_2, double P_3, double P_4)
	{
		if (this.m_count == 0)
		{
			this.m_count = P_0;
			this.m_mean = P_1;
			this.m_sumOfSquaresOfDeltas = P_2;
			this.m_min = P_3;
			this.m_max = P_4;
			return;
		}
		this.m_count += P_0;
		if (Doubles.isFinite(this.m_mean) && Doubles.isFinite(P_1))
		{
			double num = P_1 - this.m_mean;
			this.m_mean += num * (double)P_0 / (double)this.m_count;
			this.m_sumOfSquaresOfDeltas += P_2 + num * (P_1 - this.m_mean) * (double)P_0;
		}
		else
		{
			this.m_mean = calculateNewMeanNonFinite(this.m_mean, P_1);
			this.m_sumOfSquaresOfDeltas = double.NaN;
		}
		this.m_min = Math.min(this.m_min, P_3);
		this.m_max = Math.max(this.m_max, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 3, 114 })]
	public virtual double min()
	{
		Preconditions.checkState(this.m_count != 0);
		return this.m_min;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 21, 114 })]
	public virtual double max()
	{
		Preconditions.checkState(this.m_count != 0);
		return this.m_max;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 169, 114, 109, 138, 106, 134 })]
	public double populationVariance()
	{
		Preconditions.checkState(this.m_count != 0);
		if (Double.isNaN(this.m_sumOfSquaresOfDeltas))
		{
			return double.NaN;
		}
		if (this.m_count == 1)
		{
			return 0.0;
		}
		return DoubleUtils.ensureNonNegative(this.m_sumOfSquaresOfDeltas) / (double)this.m_count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 216, 111, 109, 138 })]
	public double sampleVariance()
	{
		Preconditions.checkState(this.m_count > 1);
		if (Double.isNaN(this.m_sumOfSquaresOfDeltas))
		{
			return double.NaN;
		}
		return DoubleUtils.ensureNonNegative(this.m_sumOfSquaresOfDeltas) / (double)(this.m_count - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 92, 127, 18 })]
	public virtual void addAll(DoubleStream values)
	{
		addAll((StatsAccumulator)values.collect(new ___003C_003EAnon0(), new ___003C_003EAnon1(), new ___003C_003EAnon2()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 102, 127, 18 })]
	public virtual void addAll(IntStream values)
	{
		addAll((StatsAccumulator)values.collect(new ___003C_003EAnon0(), new ___003C_003EAnon3(), new ___003C_003EAnon2()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 113, 127, 18 })]
	public virtual void addAll(LongStream values)
	{
		addAll((StatsAccumulator)values.collect(new ___003C_003EAnon0(), new ___003C_003EAnon4(), new ___003C_003EAnon2()));
	}

	public double sum()
	{
		return this.m_mean * (double)this.m_count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(310)]
	public double populationStandardDeviation()
	{
		double result = Math.sqrt(populationVariance());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(356)]
	public double sampleStandardDeviation()
	{
		double result = Math.sqrt(sampleVariance());
		_ = null;
		return result;
	}
}
