using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using java.lang;
using java.math;
using java.util;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
public sealed class Quantiles : Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	public sealed class Scale : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int scale;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(180)]
		public virtual ScaleAndIndex index(int index)
		{
			ScaleAndIndex result = new ScaleAndIndex(scale, index, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(165)]
		internal Scale(int P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 119, 104, 110, 103 })]
		private Scale(int P_0)
		{
			Preconditions.checkArgument(P_0 > 0, (object)"Quantile scale must be positive");
			scale = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(193)]
		public virtual ScaleAndIndexes indexes(params int[] indexes)
		{
			ScaleAndIndexes result = new ScaleAndIndexes(scale, (int[])indexes.Clone(), null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<Ljava/lang/Integer;>;)Lcom/google/common/math/Quantiles$ScaleAndIndexes;")]
		[LineNumberTable(206)]
		public virtual ScaleAndIndexes indexes(Collection indexes)
		{
			ScaleAndIndexes result = new ScaleAndIndexes(scale, Ints.toArray(indexes), null);
			_ = null;
			return result;
		}
	}

	public sealed class ScaleAndIndex : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int scale;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(216)]
		internal ScaleAndIndex(int P_0, int P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 107, 104, 103, 103, 103 })]
		private ScaleAndIndex(int P_0, int P_1)
		{
			access_0024300(P_1, P_0);
			scale = P_0;
			index = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 167, 111, 104, 234, 74, 206, 116, 110, 108,
			99, 132, 112
		})]
		public virtual double computeInPlace(params double[] dataset)
		{
			Preconditions.checkArgument((nint)dataset.LongLength > 0, (object)"Cannot calculate quantiles of an empty dataset");
			if (access_0024600(dataset))
			{
				return double.NaN;
			}
			long num = (long)index * (long)((nint)dataset.LongLength - 1);
			int num2 = (int)LongMath.divide(num, scale, RoundingMode.DOWN);
			int num3 = (int)(num - (long)num2 * (long)scale);
			access_0024700(num2, dataset, 0, (int)((nint)dataset.LongLength - 1));
			if (num3 == 0)
			{
				return dataset[num2];
			}
			access_0024700(num2 + 1, dataset, num2 + 1, (int)((nint)dataset.LongLength - 1));
			double result = access_0024800(dataset[num2], dataset[num2 + 1], num3, scale);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+Ljava/lang/Number;>;)D")]
		[LineNumberTable(236)]
		public virtual double compute(Collection dataset)
		{
			double result = computeInPlace(Doubles.toArray(dataset));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(247)]
		public virtual double compute(params double[] dataset)
		{
			double result = computeInPlace((double[])dataset.Clone());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(259)]
		public virtual double compute(params long[] dataset)
		{
			double result = computeInPlace(access_0024400(dataset));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(270)]
		public virtual double compute(params int[] dataset)
		{
			double result = computeInPlace(access_0024500(dataset));
			_ = null;
			return result;
		}
	}

	public sealed class ScaleAndIndexes : Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int scale;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int[] indexes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(315)]
		internal ScaleAndIndexes(int P_0, int[] P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 206, 104, 112, 40, 166, 111, 103, 103 })]
		private ScaleAndIndexes(int P_0, int[] P_1)
		{
			int num = P_1.Length;
			for (int i = 0; i < num; i++)
			{
				int num2 = P_1[i];
				access_0024300(num2, P_0);
			}
			Preconditions.checkArgument((nint)P_1.LongLength > 0, (object)"Indexes must be a non empty array");
			scale = P_0;
			indexes = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([D)Ljava/util/Map<Ljava/lang/Integer;Ljava/lang/Double;>;")]
		[LineNumberTable(new byte[]
		{
			161, 28, 111, 104, 102, 117, 60, 166, 233, 72,
			110, 141, 112, 98, 177, 242, 69, 118, 113, 103,
			102, 102, 100, 100, 104, 228, 48, 235, 83, 105,
			145, 103, 113, 103, 102, 100, 159, 2, 107, 63,
			4, 230, 58, 235, 74
		})]
		public virtual Map computeInPlace(params double[] dataset)
		{
			Preconditions.checkArgument((nint)dataset.LongLength > 0, (object)"Cannot calculate quantiles of an empty dataset");
			int[] array;
			int i;
			if (access_0024600(dataset))
			{
				LinkedHashMap linkedHashMap = new LinkedHashMap();
				array = indexes;
				int num = array.Length;
				for (i = 0; i < num; i++)
				{
					int i2 = array[i];
					((Map)linkedHashMap).put((object)Integer.valueOf(i2), (object)Double.valueOf(double.NaN));
				}
				Map result = Collections.unmodifiableMap(linkedHashMap);
				_ = null;
				return result;
			}
			int[] array2 = new int[(nint)indexes.LongLength];
			array = new int[(nint)indexes.LongLength];
			int[] array3 = new int[(nint)indexes.LongLength * 2];
			i = 0;
			for (int i2 = 0; i2 < (nint)indexes.LongLength; i2++)
			{
				long num2 = (long)indexes[i2] * (long)((nint)dataset.LongLength - 1);
				int num3 = (int)LongMath.divide(num2, scale, RoundingMode.DOWN);
				int num4 = (int)(num2 - (long)num3 * (long)scale);
				array2[i2] = num3;
				array[i2] = num4;
				array3[i] = num3;
				i++;
				if (num4 != 0)
				{
					array3[i] = num3 + 1;
					i++;
				}
			}
			Arrays.sort(array3, 0, i);
			access_0024900(array3, 0, i - 1, dataset, 0, (int)((nint)dataset.LongLength - 1));
			LinkedHashMap linkedHashMap2 = new LinkedHashMap();
			for (int j = 0; j < (nint)indexes.LongLength; j++)
			{
				int num5 = array2[j];
				int num3 = array[j];
				if (num3 == 0)
				{
					((Map)linkedHashMap2).put((object)Integer.valueOf(indexes[j]), (object)Double.valueOf(dataset[num5]));
				}
				else
				{
					((Map)linkedHashMap2).put((object)Integer.valueOf(indexes[j]), (object)Double.valueOf(access_0024800(dataset[num5], dataset[num5 + 1], num3, scale)));
				}
			}
			Map result2 = Collections.unmodifiableMap(linkedHashMap2);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+Ljava/lang/Number;>;)Ljava/util/Map<Ljava/lang/Integer;Ljava/lang/Double;>;")]
		[LineNumberTable(341)]
		public virtual Map compute(Collection dataset)
		{
			Map result = computeInPlace(Doubles.toArray(dataset));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([D)Ljava/util/Map<Ljava/lang/Integer;Ljava/lang/Double;>;")]
		[LineNumberTable(355)]
		public virtual Map compute(params double[] dataset)
		{
			Map result = computeInPlace((double[])dataset.Clone());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([J)Ljava/util/Map<Ljava/lang/Integer;Ljava/lang/Double;>;")]
		[LineNumberTable(370)]
		public virtual Map compute(params long[] dataset)
		{
			Map result = computeInPlace(access_0024400(dataset));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([I)Ljava/util/Map<Ljava/lang/Integer;Ljava/lang/Double;>;")]
		[LineNumberTable(384)]
		public virtual Map compute(params int[] dataset)
		{
			Map result = computeInPlace(access_0024500(dataset));
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 253, 109, 164, 171, 100, 106, 134, 100, 206,
		100, 106, 134, 100, 144
	})]
	private static void selectAllInPlace(int[] P_0, int P_1, int P_2, double[] P_3, int P_4, int P_5)
	{
		int num = chooseNextSelection(P_0, P_1, P_2, P_4, P_5);
		int num2 = P_0[num];
		selectInPlace(num2, P_3, P_4, P_5);
		int i;
		for (i = num - 1; i >= P_1 && P_0[i] == num2; i += -1)
		{
		}
		if (i >= P_1)
		{
			selectAllInPlace(P_0, P_1, i, P_3, P_4, num2 - 1);
		}
		int j;
		for (j = num + 1; j <= P_2 && P_0[j] == num2; j++)
		{
		}
		if (j <= P_2)
		{
			selectAllInPlace(P_0, j, P_2, P_3, num2 + 1, P_5);
		}
	}

	private static double interpolate(double P_0, double P_1, double P_2, double P_3)
	{
		if (P_0 == double.NegativeInfinity)
		{
			if (P_1 == double.PositiveInfinity)
			{
				return double.NaN;
			}
			return double.NegativeInfinity;
		}
		if (P_1 == double.PositiveInfinity)
		{
			return double.PositiveInfinity;
		}
		return P_0 + (P_1 - P_0) * P_2 / P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 164, 100, 98, 104, 104, 2, 230, 69, 100,
		138, 225, 69, 100, 105, 100, 133, 100, 133, 98
	})]
	private static void selectInPlace(int P_0, double[] P_1, int P_2, int P_3)
	{
		if (P_0 == P_2)
		{
			int num = P_2;
			for (int i = P_2 + 1; i <= P_3; i++)
			{
				if (P_1[num] > P_1[i])
				{
					num = i;
				}
			}
			if (num != P_2)
			{
				swap(P_1, num, P_2);
			}
			return;
		}
		while (P_3 > P_2)
		{
			int num = partition(P_1, P_2, P_3);
			if (num >= P_0)
			{
				P_3 = num - 1;
			}
			if (num <= P_0)
			{
				P_2 = num + 1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 86, 111, 104, 2, 230, 69 })]
	private static bool containsNaN(params double[] P_0)
	{
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			double v = P_0[i];
			if (Double.isNaN(v))
			{
				return true;
			}
		}
		return false;
	}

	[LineNumberTable(new byte[] { 161, 132, 99, 103, 102, 39, 166 })]
	private static double[] intsToDoubles(int[] P_0)
	{
		int num = P_0.Length;
		double[] array = new double[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = P_0[i];
		}
		return array;
	}

	[LineNumberTable(new byte[] { 161, 123, 99, 103, 102, 39, 166 })]
	private static double[] longsToDoubles(long[] P_0)
	{
		int num = P_0.Length;
		double[] array = new double[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = P_0[i];
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 116, 104, 191, 12 })]
	private static void checkIndex(int P_0, int P_1)
	{
		if (P_0 < 0 || P_0 > P_1)
		{
			int num = 70;
			num = num;
			string s = new StringBuilder(num).append("Quantile indexes must be between 0 and the scale, which is ").append(P_1).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(156)]
	public static Scale scale(int scale)
	{
		Scale result = new Scale(scale, null);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 162, 69, 100, 102, 100 })]
	private static void swap(double[] P_0, int P_1, int P_2)
	{
		double num = P_0[P_1];
		P_0[P_1] = P_0[P_2];
		P_0[P_2] = num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 200, 104, 196, 98, 102, 102, 104, 228, 61,
		230, 74, 104
	})]
	private static int partition(double[] P_0, int P_1, int P_2)
	{
		movePivotToStartOfSlice(P_0, P_1, P_2);
		double num = P_0[P_1];
		int num2 = P_2;
		for (int i = P_2; i > P_1; i += -1)
		{
			if (P_0[i] > num)
			{
				swap(P_0, num2, i);
				num2 += -1;
			}
		}
		swap(P_0, P_1, num2);
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 227, 230, 69, 105, 105, 105, 132, 106, 132,
		170
	})]
	private static void movePivotToStartOfSlice(double[] P_0, int P_1, int P_2)
	{
		int num = (int)((uint)(P_1 + P_2) >> 1);
		int num2 = ((P_0[P_2] < P_0[num]) ? 1 : 0);
		int num3 = ((P_0[num] < P_0[P_1]) ? 1 : 0);
		int num4 = ((P_0[P_2] < P_0[P_1]) ? 1 : 0);
		if (num2 == num3)
		{
			swap(P_0, num, P_1);
		}
		else if (num2 != num4)
		{
			swap(P_0, P_1, P_2);
		}
	}

	[LineNumberTable(new byte[]
	{
		162, 33, 100, 226, 69, 231, 71, 98, 98, 102,
		102, 102, 100, 102, 132, 130, 162, 111, 130
	})]
	private static int chooseNextSelection(int[] P_0, int P_1, int P_2, int P_3, int P_4)
	{
		if (P_1 == P_2)
		{
			return P_1;
		}
		int num = (int)((uint)(P_3 + P_4) >> 1);
		int num2 = P_1;
		int num3 = P_2;
		while (num3 > num2 + 1)
		{
			int num4 = (int)((uint)(num2 + num3) >> 1);
			if (P_0[num4] > num)
			{
				num3 = num4;
				continue;
			}
			if (P_0[num4] < num)
			{
				num2 = num4;
				continue;
			}
			return num4;
		}
		if (P_3 + P_4 - P_0[num2] - P_0[num3] > 0)
		{
			return num3;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(132)]
	public Quantiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(136)]
	public static ScaleAndIndex median()
	{
		ScaleAndIndex result = scale(2).index(1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(141)]
	public static Scale quartiles()
	{
		Scale result = scale(4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(146)]
	public static Scale percentiles()
	{
		Scale result = scale(100);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(132)]
	internal static void access_0024300(int P_0, int P_1)
	{
		checkIndex(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(132)]
	internal static double[] access_0024400(long[] P_0)
	{
		double[] result = longsToDoubles(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(132)]
	internal static double[] access_0024500(int[] P_0)
	{
		double[] result = intsToDoubles(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(132)]
	internal static bool access_0024600(double[] P_0)
	{
		bool result = containsNaN(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(132)]
	internal static void access_0024700(int P_0, double[] P_1, int P_2, int P_3)
	{
		selectInPlace(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(132)]
	internal static double access_0024800(double P_0, double P_1, double P_2, double P_3)
	{
		double result = interpolate(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(132)]
	internal static void access_0024900(int[] P_0, int P_1, int P_2, double[] P_3, int P_4, int P_5)
	{
		selectAllInPlace(P_0, P_1, P_2, P_3, P_4, P_5);
	}
}
