using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
public sealed class PairedStatsAccumulator : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private StatsAccumulator m_xStats;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private StatsAccumulator m_yStats;

	private double sumOfProductsOfDeltas;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(100)]
	public virtual long count()
	{
		long result = this.m_xStats.count();
		_ = null;
		return result;
	}

	private double ensurePositive(double P_0)
	{
		if (P_0 > 0.0)
		{
			return P_0;
		}
		return double.Epsilon;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(241)]
	private static double ensureInUnitRange(double P_0)
	{
		double result = Doubles.constrainToRange(P_0, -1.0, 1.0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 178, 200, 107, 107 })]
	public PairedStatsAccumulator()
	{
		this.m_xStats = new StatsAccumulator();
		this.m_yStats = new StatsAccumulator();
		sumOfProductsOfDeltas = 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 109, 114, 111, 191, 14, 144, 111 })]
	public virtual void add(double x, double y)
	{
		this.m_xStats.add(x);
		if (Doubles.isFinite(x) && Doubles.isFinite(y))
		{
			if (this.m_xStats.count() > 1)
			{
				sumOfProductsOfDeltas += (x - this.m_xStats.mean()) * (y - this.m_yStats.mean());
			}
		}
		else
		{
			sumOfProductsOfDeltas = double.NaN;
		}
		this.m_yStats.add(y);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		23, 106, 161, 113, 111, 239, 69, 104, 102, 119,
		120, 143, 115
	})]
	public virtual void addAll(PairedStats values)
	{
		if (values.count() != 0)
		{
			this.m_xStats.addAll(values.xStats());
			if (this.m_yStats.count() == 0)
			{
				sumOfProductsOfDeltas = values.sumOfProductsOfDeltas();
			}
			else
			{
				sumOfProductsOfDeltas += values.sumOfProductsOfDeltas() + (values.xStats().mean() - this.m_xStats.mean()) * (values.yStats().mean() - this.m_yStats.mean()) * (double)values.count();
			}
			this.m_yStats.addAll(values.yStats());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(95)]
	public virtual PairedStats snapshot()
	{
		PairedStats result = new PairedStats(this.m_xStats.snapshot(), this.m_yStats.snapshot(), sumOfProductsOfDeltas);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(105)]
	public virtual Stats xStats()
	{
		Stats result = this.m_xStats.snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(110)]
	public virtual Stats yStats()
	{
		Stats result = this.m_yStats.snapshot();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 78, 114 })]
	public virtual double populationCovariance()
	{
		Preconditions.checkState(count() != 0);
		return sumOfProductsOfDeltas / (double)count();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 96, 111 })]
	public double sampleCovariance()
	{
		Preconditions.checkState(count() > 1);
		return sumOfProductsOfDeltas / (double)(count() - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 117, 111, 109, 138, 109, 109, 109, 173, 100, 103 })]
	public double pearsonsCorrelationCoefficient()
	{
		Preconditions.checkState(count() > 1);
		if (Double.isNaN(sumOfProductsOfDeltas))
		{
			return double.NaN;
		}
		double num = this.m_xStats.sumOfSquaresOfDeltas();
		double num2 = this.m_yStats.sumOfSquaresOfDeltas();
		Preconditions.checkState(num > 0.0);
		Preconditions.checkState(num2 > 0.0);
		double a = ensurePositive(num * num2);
		double result = ensureInUnitRange(sumOfProductsOfDeltas / Math.sqrt(a));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 100, 111, 109, 136, 109, 104, 114, 127, 4,
		39, 161, 179, 119
	})]
	public LinearTransformation leastSquaresFit()
	{
		Preconditions.checkState(count() > 1);
		if (Double.isNaN(sumOfProductsOfDeltas))
		{
			LinearTransformation result = LinearTransformation.forNaN();
			_ = null;
			return result;
		}
		double num = this.m_xStats.sumOfSquaresOfDeltas();
		if (num > 0.0)
		{
			if (this.m_yStats.sumOfSquaresOfDeltas() > 0.0)
			{
				LinearTransformation result2 = LinearTransformation.mapping(this.m_xStats.mean(), this.m_yStats.mean()).withSlope(sumOfProductsOfDeltas / num);
				_ = null;
				return result2;
			}
			LinearTransformation result3 = LinearTransformation.horizontal(this.m_yStats.mean());
			_ = null;
			return result3;
		}
		Preconditions.checkState(this.m_yStats.sumOfSquaresOfDeltas() > 0.0);
		LinearTransformation result4 = LinearTransformation.vertical(this.m_xStats.mean());
		_ = null;
		return result4;
	}
}
