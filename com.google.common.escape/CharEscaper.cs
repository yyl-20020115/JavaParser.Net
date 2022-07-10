using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using javax.annotation;

namespace com.google.common.escape;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/escape/ElementTypesAreNonnullByDefault;"
})]
public abstract class CharEscaper : Escaper
{
	private const int DEST_PAD_MULTIPLIER = 2;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal abstract char[] escape(char ch);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		48, 167, 102, 99, 98, 195, 167, 175, 100, 165,
		101, 230, 69, 105, 101, 105, 201, 101, 107, 197,
		101, 108, 133, 229, 31, 234, 101, 102, 101, 102,
		165, 138, 107, 131
	})]
	protected internal string escapeSlow(string s, int index)
	{
		int num = String.instancehelper_length(s);
		char[] array = Platform.charBufferFromThreadLocal();
		int num2 = array.Length;
		int num3 = 0;
		int num4 = 0;
		while (index < num)
		{
			char[] array2 = escape(String.instancehelper_charAt(s, index));
			if (array2 != null)
			{
				int num5 = array2.Length;
				int num6 = index - num4;
				int num7 = num3 + num6 + num5;
				if (num2 < num7)
				{
					num2 = num7 + 2 * (num - index);
					array = growBuffer(array, num3, num2);
				}
				if (num6 > 0)
				{
					String.instancehelper_getChars(s, num4, index, array, num3);
					num3 += num6;
				}
				if (num5 > 0)
				{
					ByteCodeHelper.arraycopy_primitive_2(array2, 0, array, num3, num5);
					num3 += num5;
				}
				num4 = index + 1;
			}
			index++;
		}
		int num8 = num - num4;
		if (num8 > 0)
		{
			int num5 = num3 + num8;
			if (num2 < num5)
			{
				array = growBuffer(array, num3, num5);
			}
			String.instancehelper_getChars(s, num4, num, array, num3);
			num3 = num5;
		}
		string result = String.newhelper(array, 0, num3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 114, 100, 144, 103, 100, 138 })]
	private static char[] growBuffer(char[] P_0, int P_1, int P_2)
	{
		if (P_2 < 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("Cannot increase internal buffer any further");
		}
		char[] array = new char[P_2];
		if (P_1 > 0)
		{
			ByteCodeHelper.arraycopy_primitive_2(P_0, 0, array, 0, P_1);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	protected internal CharEscaper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 135, 103, 102, 111, 11, 230, 69 })]
	public override string escape(string @string)
	{
		Preconditions.checkNotNull(@string);
		int num = String.instancehelper_length(@string);
		for (int i = 0; i < num; i++)
		{
			if (escape(String.instancehelper_charAt(@string, i)) != null)
			{
				string result = escapeSlow(@string, i);
				_ = null;
				return result;
			}
		}
		return @string;
	}
}
