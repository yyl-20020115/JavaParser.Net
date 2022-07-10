using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.math;

namespace com.google.common.math;

[Signature("<X:Ljava/lang/Number;:Ljava/lang/Comparable<TX;>;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ToDoubleRounder : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024java_0024math_0024RoundingMode;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(51)]
		static _1()
		{
			_0024SwitchMap_0024java_0024math_0024RoundingMode = new int[(nint)RoundingMode.values().LongLength];
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.DOWN.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			_ = null;
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.HALF_EVEN.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			_ = null;
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.HALF_DOWN.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			_ = null;
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.HALF_UP.ordinal()] = 4;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00ae;
			}
			goto IL_00b4;
			IL_00ae:
			_ = null;
			goto IL_00b4;
			IL_00b4:
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.FLOOR.ordinal()] = 5;
			}
			catch (System.Exception x5)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x5, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00d7;
			}
			goto IL_00dd;
			IL_00d7:
			_ = null;
			goto IL_00dd;
			IL_00dd:
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.CEILING.ordinal()] = 6;
			}
			catch (System.Exception x6)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x6, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0100;
			}
			goto IL_0106;
			IL_0100:
			_ = null;
			goto IL_0106;
			IL_0106:
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.UP.ordinal()] = 7;
			}
			catch (System.Exception x7)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x7, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0129;
			}
			goto IL_012f;
			IL_0129:
			_ = null;
			goto IL_012f;
			IL_012f:
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.UNNECESSARY.ordinal()] = 8;
				return;
			}
			catch (System.Exception x8)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x8, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}

		_1()
		{
			throw null;
		}
	}

	[Signature("(TX;)D")]
	internal abstract double roundToDoubleArbitrarily(Number P_0);

	[Signature("(TX;)I")]
	internal abstract int sign(Number P_0);

	[Signature("(DLjava/math/RoundingMode;)TX;")]
	internal abstract Number toX(double P_0, RoundingMode P_1);

	[Signature("(TX;TX;)TX;")]
	internal abstract Number minus(Number P_0, Number P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	internal ToDoubleRounder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TX;Ljava/math/RoundingMode;)D")]
	[LineNumberTable(new byte[]
	{
		159,
		189,
		108,
		108,
		105,
		107,
		byte.MaxValue,
		25,
		69,
		147,
		108,
		107,
		9,
		193,
		108,
		107,
		9,
		193,
		130,
		191,
		31,
		109,
		110,
		159,
		25,
		109,
		130,
		101,
		99,
		8,
		193,
		145,
		106,
		101,
		99,
		8,
		193,
		177,
		106,
		145,
		101,
		99,
		8,
		225,
		77,
		101,
		99,
		99,
		105,
		109,
		131,
		145,
		99,
		99,
		105,
		109,
		131,
		175,
		107,
		107,
		112,
		101,
		99,
		101,
		163,
		223,
		2,
		112,
		100,
		2,
		193,
		145,
		145,
		208
	})]
	internal double roundToDouble(Number P_0, RoundingMode P_1)
	{
		Preconditions.checkNotNull((object)P_0, (object)"x");
		Preconditions.checkNotNull((object)P_1, (object)"mode");
		double num = roundToDoubleArbitrarily(P_0);
		if (java.lang.Double.isInfinite(num))
		{
			switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[P_1.ordinal()])
			{
			case 1:
			case 2:
			case 3:
			case 4:
				return double.MaxValue * (double)sign(P_0);
			case 5:
				return (num != double.PositiveInfinity) ? double.NegativeInfinity : double.MaxValue;
			case 6:
				return (num != double.PositiveInfinity) ? double.MinValue : double.PositiveInfinity;
			case 7:
				return num;
			case 8:
			{
				string text = java.lang.String.valueOf(P_0);
				int num2 = 44 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num2 = num2;
				string s = new StringBuilder(num2).append(text).append(" cannot be represented precisely as a double").toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.ArithmeticException(s);
			}
			}
		}
		Number number = toX(num, RoundingMode.UNNECESSARY);
		int num3 = Comparable.__Helper.compareTo((IComparable)P_0, number);
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[P_1.ordinal()])
		{
		case 8:
			MathPreconditions.checkRoundingUnnecessary((num3 == 0) ? true : false);
			return num;
		case 5:
		{
			double result3 = ((num3 < 0) ? DoubleUtils.nextDown(num) : num);
			_ = null;
			return result3;
		}
		case 6:
		{
			double result6 = ((num3 > 0) ? java.lang.Math.nextUp(num) : num);
			_ = null;
			return result6;
		}
		case 1:
		{
			if (sign(P_0) < 0)
			{
				double result4 = ((num3 > 0) ? java.lang.Math.nextUp(num) : num);
				_ = null;
				return result4;
			}
			double result5 = ((num3 < 0) ? DoubleUtils.nextDown(num) : num);
			_ = null;
			return result5;
		}
		case 7:
		{
			if (sign(P_0) < 0)
			{
				double result = ((num3 < 0) ? DoubleUtils.nextDown(num) : num);
				_ = null;
				return result;
			}
			double result2 = ((num3 > 0) ? java.lang.Math.nextUp(num) : num);
			_ = null;
			return result2;
		}
		case 2:
		case 3:
		case 4:
		{
			double num4;
			Number number2;
			double num5;
			Number number3;
			if (num3 >= 0)
			{
				num4 = num;
				number2 = number;
				num5 = java.lang.Math.nextUp(num);
				if (num5 == double.PositiveInfinity)
				{
					return num4;
				}
				number3 = toX(num5, RoundingMode.CEILING);
			}
			else
			{
				num5 = num;
				number3 = number;
				num4 = DoubleUtils.nextDown(num);
				if (num4 == double.NegativeInfinity)
				{
					return num5;
				}
				number2 = toX(num4, RoundingMode.FLOOR);
			}
			Number number4 = minus(P_0, number2);
			Number number5 = minus(number3, P_0);
			int num6 = Comparable.__Helper.compareTo((IComparable)number4, number5);
			if (num6 < 0)
			{
				return num4;
			}
			if (num6 > 0)
			{
				return num5;
			}
			switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[P_1.ordinal()])
			{
			case 2:
			{
				DoubleConverter converter = default(DoubleConverter);
				return ((DoubleConverter.ToLong(num4, ref converter) & 1) != 0) ? num5 : num4;
			}
			case 3:
				return (sign(P_0) < 0) ? num5 : num4;
			case 4:
				return (sign(P_0) < 0) ? num4 : num5;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError("impossible");
			}
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("impossible");
		}
	}
}
