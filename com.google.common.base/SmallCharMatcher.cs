using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SmallCharMatcher : CharMatcher.NamedFastMatcher
{
	internal const int MAX_SIZE = 1023;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char[] table;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool containsZero;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long filter;

	private const int C1 = -862048943;

	private const int C2 = 461845907;

	private const double DESIRED_LOAD_FACTOR = 0.5;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		39, 99, 103, 136, 108, 102, 142, 107, 172, 102,
		103, 162, 235, 53, 238, 78
	})]
	internal static CharMatcher from(BitSet P_0, string P_1)
	{
		long num = 0L;
		int num2 = P_0.cardinality();
		int num3 = (P_0.get(0) ? 1 : 0);
		char[] array = new char[chooseTableSize(num2)];
		int num4 = (int)((nint)array.LongLength - 1);
		for (int num5 = P_0.nextSetBit(0); num5 != -1; num5 = P_0.nextSetBit(num5 + 1))
		{
			num |= 1L << num5;
			int num6 = smear(num5) & num4;
			while (array[num6] != 0)
			{
				num6 = (num6 + 1) & num4;
			}
			array[num6] = (char)num5;
		}
		SmallCharMatcher result = new SmallCharMatcher(array, num, (byte)num3 != 0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 25, 100, 194, 107, 112, 134 })]
	internal static int chooseTableSize(int P_0)
	{
		if (P_0 == 1)
		{
			return 2;
		}
		int num = Integer.highestOneBit(P_0 - 1) << 1;
		while ((double)num * 0.5 < (double)P_0)
		{
			num <<= 1;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	internal static int smear(int P_0)
	{
		return 461845907 * Integer.rotateLeft(P_0 * -862048943, 15);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 133, 98, 106, 103, 103, 103 })]
	private SmallCharMatcher(char[] P_0, long P_1, bool P_2, string P_3)
		: base(P_3)
	{
		table = P_0;
		filter = P_1;
		containsZero = P_2;
	}

	private bool checkFilter(int P_0)
	{
		return 1 == (1 & (filter >> P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 114, 130, 99, 135, 105, 130, 106, 105, 130,
		106, 98, 107, 130, 166, 100
	})]
	public override bool matches(char P_0)
	{
		if (P_0 == '\0')
		{
			return containsZero;
		}
		if (!checkFilter(P_0))
		{
			return false;
		}
		int num = (int)((nint)table.LongLength - 1);
		int num2 = smear(P_0) & num;
		int num3 = num2;
		do
		{
			if (table[num3] == '\0')
			{
				return false;
			}
			if (table[num3] == P_0)
			{
				return true;
			}
			num3 = (num3 + 1) & num;
		}
		while (num3 != num2);
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 88, 104, 135, 116, 99, 7, 230, 69 })]
	internal override void setBits(BitSet P_0)
	{
		if (containsZero)
		{
			P_0.set(0);
		}
		char[] array = table;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			int num2 = array[i];
			if (num2 != 0)
			{
				P_0.set(num2);
			}
		}
	}
}
