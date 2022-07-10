using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.math;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
public class BigDecimalMath : Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Lcom/google/common/math/ToDoubleRounder<Ljava/math/BigDecimal;>;")]
	internal class BigDecimalToDoubleRounder : ToDoubleRounder
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static BigDecimalToDoubleRounder INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(79)]
		internal virtual BigDecimal minus(BigDecimal P_0, BigDecimal P_1)
		{
			BigDecimal result = P_0.subtract(P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(74)]
		internal new virtual BigDecimal toX(double P_0, RoundingMode P_1)
		{
			BigDecimal result = new BigDecimal(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(69)]
		internal virtual int sign(BigDecimal P_0)
		{
			int result = P_0.signum();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(64)]
		internal virtual double roundToDoubleArbitrarily(BigDecimal P_0)
		{
			double result = P_0.doubleValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(60)]
		private BigDecimalToDoubleRounder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(57)]
		internal override Number minus(Number P_0, Number P_1)
		{
			BigDecimal result = minus((BigDecimal)P_0, (BigDecimal)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(57)]
		internal override Number toX(double P_0, RoundingMode P_1)
		{
			BigDecimal result = toX(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(57)]
		internal override int sign(Number P_0)
		{
			int result = sign((BigDecimal)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(57)]
		internal override double roundToDoubleArbitrarily(Number P_0)
		{
			double result = roundToDoubleArbitrarily((BigDecimal)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(58)]
		static BigDecimalToDoubleRounder()
		{
			INSTANCE = new BigDecimalToDoubleRounder();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(30)]
	private BigDecimalMath()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	public static double roundToDouble(BigDecimal x, RoundingMode mode)
	{
		double result = BigDecimalToDoubleRounder.INSTANCE.roundToDouble(x, mode);
		_ = null;
		return result;
	}
}
