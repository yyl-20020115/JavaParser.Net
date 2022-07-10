using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javax.annotation;

namespace com.google.common.collect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Hashing : Object
{
	private const long C1 = -862048943L;

	private const long C2 = 461845907L;

	private const int MAX_TABLE_SIZE = 1073741824;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	internal static int smearedHash([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		int result = smear((P_0 != null) ? Object.instancehelper_hashCode(P_0) : 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 105, 135, 109, 100, 141 })]
	internal static int closedTableSize(int P_0, double P_1)
	{
		P_0 = Math.max(P_0, 2);
		int num = Integer.highestOneBit(P_0);
		if (P_0 > ByteCodeHelper.d2i(P_1 * (double)num))
		{
			num <<= 1;
			return (num <= 0) ? 1073741824 : num;
		}
		return num;
	}

	internal static bool needsResizing(int P_0, int P_1, double P_2)
	{
		return ((double)P_0 > P_2 * (double)P_1 && P_1 < 1073741824) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	internal static int smear(int P_0)
	{
		return (int)(461845907u * Integer.rotateLeft((int)((long)P_0 * -862048943L), 15));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(33)]
	private Hashing()
	{
	}
}
