using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.nio;
using javax.annotation;

namespace com.google.common.math;

[Serializable]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class PairedStats : java.lang.Object, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Stats m_xStats;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Stats m_yStats;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private double m_sumOfProductsOfDeltas;

	private const int BYTES = 88;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	public virtual long count()
	{
		long result = this.m_xStats.count();
		_ = null;
		return result;
	}

	public virtual Stats xStats()
	{
		return this.m_xStats;
	}

	public virtual Stats yStats()
	{
		return this.m_yStats;
	}

	private static double ensurePositive(double P_0)
	{
		if (P_0 > 0.0)
		{
			return P_0;
		}
		return double.Epsilon;
	}

	private static double ensureInUnitRange(double P_0)
	{
		if (P_0 >= 1.0)
		{
			return 1.0;
		}
		if (P_0 <= -1.0)
		{
			return -1.0;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 47, 114 })]
	public virtual double populationCovariance()
	{
		Preconditions.checkState(count() != 0);
		return this.m_sumOfProductsOfDeltas / (double)count();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 104, 103, 103, 105 })]
	internal PairedStats(Stats P_0, Stats P_1, double P_2)
	{
		this.m_xStats = P_0;
		this.m_yStats = P_1;
		this.m_sumOfProductsOfDeltas = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 65, 111 })]
	public virtual double sampleCovariance()
	{
		Preconditions.checkState(count() > 1);
		return this.m_sumOfProductsOfDeltas / (double)(count() - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 86, 111, 109, 138, 109, 109, 109, 173, 99, 103 })]
	public virtual double pearsonsCorrelationCoefficient()
	{
		Preconditions.checkState(count() > 1);
		if (java.lang.Double.isNaN(this.m_sumOfProductsOfDeltas))
		{
			return double.NaN;
		}
		double num = xStats().sumOfSquaresOfDeltas();
		double num2 = yStats().sumOfSquaresOfDeltas();
		Preconditions.checkState(num > 0.0);
		Preconditions.checkState(num2 > 0.0);
		double a = ensurePositive(num * num2);
		double result = ensureInUnitRange(this.m_sumOfProductsOfDeltas / java.lang.Math.sqrt(a));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 69, 111, 109, 136, 109, 104, 114, 127, 4,
		39, 161, 179, 119
	})]
	public virtual LinearTransformation leastSquaresFit()
	{
		Preconditions.checkState(count() > 1);
		if (java.lang.Double.isNaN(this.m_sumOfProductsOfDeltas))
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
				LinearTransformation result2 = LinearTransformation.mapping(this.m_xStats.mean(), this.m_yStats.mean()).withSlope(this.m_sumOfProductsOfDeltas / num);
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 104, 99, 130, 110, 130, 103, 127, 0, 109,
		22
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
		PairedStats pairedStats = (PairedStats)obj;
		return (this.m_xStats.equals(pairedStats.m_xStats) && this.m_yStats.equals(pairedStats.m_yStats) && java.lang.Double.doubleToLongBits(this.m_sumOfProductsOfDeltas) == java.lang.Double.doubleToLongBits(pairedStats.m_sumOfProductsOfDeltas)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(238)]
	public override int hashCode()
	{
		int result = Objects.hashCode(this.m_xStats, this.m_yStats, java.lang.Double.valueOf(this.m_sumOfProductsOfDeltas));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 129, 106, 113, 112, 107, 106, 231, 60, 225,
		70, 113, 112, 101, 231, 61
	})]
	public override string toString()
	{
		if (count() > 0)
		{
			string result = MoreObjects.toStringHelper(this).add("xStats", this.m_xStats).add("yStats", this.m_yStats)
				.add("populationCovariance", populationCovariance())
				.toString();
			_ = null;
			return result;
		}
		string result2 = MoreObjects.toStringHelper(this).add("xStats", this.m_xStats).add("yStats", this.m_yStats)
			.toString();
		_ = null;
		return result2;
	}

	internal virtual double sumOfProductsOfDeltas()
	{
		return this.m_sumOfProductsOfDeltas;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 177, 114, 108, 108, 109 })]
	public virtual byte[] toByteArray()
	{
		ByteBuffer byteBuffer = ByteBuffer.allocate(88).order(ByteOrder.LITTLE_ENDIAN);
		this.m_xStats.writeTo(byteBuffer);
		this.m_yStats.writeTo(byteBuffer);
		byteBuffer.putDouble(this.m_sumOfProductsOfDeltas);
		byte[] result = byteBuffer.array();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 192, 103, 244, 69, 113, 103, 103, 104 })]
	public static PairedStats fromByteArray(byte[] byteArray)
	{
		Preconditions.checkNotNull(byteArray);
		Preconditions.checkArgument((nint)byteArray.LongLength == 88, "Expected PairedStats.BYTES = %s, got %s", 88, byteArray.Length);
		ByteBuffer byteBuffer = ByteBuffer.wrap(byteArray).order(ByteOrder.LITTLE_ENDIAN);
		Stats stats = Stats.readFrom(byteBuffer);
		Stats stats2 = Stats.readFrom(byteBuffer);
		double num = byteBuffer.getDouble();
		PairedStats result = new PairedStats(stats, stats2, num);
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(PairedStats P_0)
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
	protected PairedStats(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
