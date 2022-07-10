using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Utf8 : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 122, 138, 115, 99, 108, 121, 105, 143, 134,
		146, 127, 1, 146, 230, 52, 235, 80
	})]
	private static int encodedLengthGeneral(CharSequence P_0, int P_1)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence seq = default(CharSequence);
		object obj = (seq.___003Cref_003E = __003Cref_003E);
		int num = seq.length();
		int num2 = 0;
		for (int i = P_1; i < num; i++)
		{
			int i2 = i;
			obj = (seq.___003Cref_003E = __003Cref_003E);
			int num3 = seq.charAt(i2);
			if (num3 < 2048)
			{
				num2 += (int)((uint)(127 - num3) >> 31);
				continue;
			}
			num2 += 2;
			if (55296 <= num3 && num3 <= 57343)
			{
				i2 = i;
				obj = (seq.___003Cref_003E = __003Cref_003E);
				if (Character.codePointAt(seq, i2) == num3)
				{
					string s = unpairedSurrogateMsg(i);
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new IllegalArgumentException(s);
				}
				i++;
			}
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(198)]
	private static string unpairedSurrogateMsg(int P_0)
	{
		int num = 39;
		num = num;
		string result = new StringBuilder(num).append("Unpaired surrogate at index ").append(P_0).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 77, 100, 137, 102, 102, 11, 230, 69 })]
	public static bool isWellFormed(byte[] bytes, int off, int len)
	{
		int num = off + len;
		Preconditions.checkPositionIndexes(off, num, bytes.Length);
		for (int i = off; i < num; i++)
		{
			if (bytes[i] < 0)
			{
				bool result = isWellFormedSlowPath(bytes, i, num);
				_ = null;
				return result;
			}
		}
		return true;
	}

	[LineNumberTable(new byte[]
	{
		89,
		226,
		70,
		100,
		130,
		140,
		133,
		100,
		194,
		115,
		130,
		133,
		102,
		130,
		104,
		byte.MaxValue,
		5,
		71,
		130,
		130,
		102,
		130,
		104,
		byte.MaxValue,
		10,
		74,
		162
	})]
	private static bool isWellFormedSlowPath(byte[] P_0, int P_1, int P_2)
	{
		int num = P_1;
		while (true)
		{
			if (num >= P_2)
			{
				return true;
			}
			int num2 = num;
			num++;
			int num3;
			if ((num3 = P_0[num2]) >= 0)
			{
				continue;
			}
			if (num3 < -32)
			{
				if (num == P_2)
				{
					return false;
				}
				if (num3 >= -62)
				{
					int num4 = num;
					num++;
					if (P_0[num4] <= -65)
					{
						continue;
					}
				}
				return false;
			}
			int num6;
			if (num3 < -16)
			{
				if (num + 1 >= P_2)
				{
					return false;
				}
				int num5 = num;
				num++;
				num6 = P_0[num5];
				if (num6 <= -65 && (num3 != -32 || num6 >= -96) && (num3 != -19 || -96 > num6))
				{
					int num7 = num;
					num++;
					if (P_0[num7] <= -65)
					{
						continue;
					}
				}
				return false;
			}
			if (num + 2 >= P_2)
			{
				return false;
			}
			int num8 = num;
			num++;
			num6 = P_0[num8];
			if (num6 > -65 || (num3 << 28) + (num6 - -112) >> 30 != 0)
			{
				break;
			}
			int num9 = num;
			num++;
			if (P_0[num9] > -65)
			{
				break;
			}
			int num10 = num;
			num++;
			if (P_0[num10] > -65)
			{
				break;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 129, 106, 115, 100, 163, 127, 5, 200, 105,
		121, 105, 143, 127, 2, 226, 58, 235, 74, 134,
		191, 32
	})]
	public static int encodedLength(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		int num2 = num;
		int i;
		for (i = 0; i < num; i++)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (charSequence2.charAt(i2) >= '\u0080')
			{
				break;
			}
		}
		for (; i < num; i++)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num3 = charSequence2.charAt(i2);
			if (num3 < 2048)
			{
				num2 += (int)((uint)(127 - num3) >> 31);
				continue;
			}
			int num4 = num2;
			i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			num2 = num4 + encodedLengthGeneral(charSequence2, i2);
			break;
		}
		if (num2 < num)
		{
			long lng = num2 + 4294967296L;
			int i2 = 54;
			i2 = i2;
			string s = new StringBuilder(i2).append("UTF-8 length does not fit in int: ").append(lng).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(114)]
	public static bool isWellFormed(byte[] bytes)
	{
		bool result = isWellFormed(bytes, 0, bytes.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(201)]
	private Utf8()
	{
	}
}
