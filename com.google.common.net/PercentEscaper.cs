using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.escape;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.net;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/net/ElementTypesAreNonnullByDefault;"
})]
public sealed class PercentEscaper : UnicodeEscaper
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static char[] PLUS_SIGN;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static char[] UPPER_HEX_DIGITS;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool plusForSpace;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool[] safeOctets;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 61, 98, 103, 115, 41, 168, 106, 120, 38, 168 })]
	private static bool[] createSafeOctets(string P_0)
	{
		int num = -1;
		char[] array = String.instancehelper_toCharArray(P_0);
		char[] array2 = array;
		int num2 = array2.Length;
		int i;
		for (i = 0; i < num2; i++)
		{
			int a = array2[i];
			num = Math.max(a, num);
		}
		bool[] array3 = new bool[num + 1];
		char[] array4 = array;
		i = array4.Length;
		for (int a = 0; a < i; a++)
		{
			int num3 = array4[a];
			array3[num3] = true;
		}
		return array3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 121, 98, 168, 135, 109, 176, 178, 127, 1,
		176, 103, 108
	})]
	public PercentEscaper(string safeChars, bool plusForSpace)
	{
		Preconditions.checkNotNull(safeChars);
		if (String.instancehelper_matches(safeChars, ".*[0-9A-Za-z].*"))
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException("Alphanumeric characters are always 'safe' and should not be explicitly specified");
		}
		safeChars = String.instancehelper_concat(String.valueOf(safeChars), "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
		if (plusForSpace)
		{
			string @this = safeChars;
			CharSequence s = default(CharSequence);
			object obj = (s.___003Cref_003E = " ");
			if (String.instancehelper_contains(@this, s))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException("plusForSpace cannot be specified when space is a 'safe' character");
			}
		}
		this.plusForSpace = plusForSpace;
		safeOctets = createSafeOctets(safeChars);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 110, 106, 103, 100, 118, 118, 226, 61, 231,
		70
	})]
	protected internal override int nextEscapeIndex(CharSequence csq, int index, int end)
	{
		CharSequence charSequence = csq;
		object __003Cref_003E = charSequence.___003Cref_003E;
		Preconditions.checkNotNull(__003Cref_003E);
		CharSequence charSequence2 = default(CharSequence);
		while (index < end)
		{
			int i = index;
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num = charSequence2.charAt(i);
			if (num >= (nint)safeOctets.LongLength || !safeOctets[num])
			{
				break;
			}
			index++;
		}
		return index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 95, 103, 103, 102, 104, 116, 235, 61, 230, 70 })]
	public override string escape(string s)
	{
		Preconditions.checkNotNull(s);
		int num = String.instancehelper_length(s);
		for (int i = 0; i < num; i++)
		{
			int num2 = String.instancehelper_charAt(s, i);
			if (num2 >= (nint)safeOctets.LongLength || !safeOctets[num2])
			{
				string result = escapeSlow(s, i);
				_ = null;
				return result;
			}
		}
		return s;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		112, 116, 98, 109, 102, 165, 103, 101, 109, 108,
		98, 168, 103, 101, 101, 109, 101, 110, 101, 109,
		101, 109, 98, 171, 104, 101, 101, 101, 101, 109,
		101, 110, 101, 109, 101, 110, 101, 106, 98, 107,
		168, 101, 101, 101, 101, 102, 110, 101, 111, 101,
		109, 101, 110, 101, 109, 101, 110, 101, 108, 162
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal override char[] escape(int cp)
	{
		if (cp < (nint)safeOctets.LongLength && safeOctets[cp])
		{
			return null;
		}
		if (cp == 32 && plusForSpace)
		{
			return PLUS_SIGN;
		}
		if (cp <= 127)
		{
			char[] array = new char[3];
			array[0] = '%';
			array[2] = UPPER_HEX_DIGITS[cp & 0xF];
			array[1] = UPPER_HEX_DIGITS[(uint)cp >> 4];
			return array;
		}
		if (cp <= 2047)
		{
			char[] array = new char[6]
			{
				'%',
				'\0',
				'\0',
				'%',
				'\0',
				UPPER_HEX_DIGITS[cp & 0xF]
			};
			cp = (int)((uint)cp >> 4);
			array[4] = UPPER_HEX_DIGITS[8 | (cp & 3)];
			cp = (int)((uint)cp >> 2);
			array[2] = UPPER_HEX_DIGITS[cp & 0xF];
			cp = (int)((uint)cp >> 4);
			array[1] = UPPER_HEX_DIGITS[0xC | cp];
			return array;
		}
		if (cp <= 65535)
		{
			char[] array = new char[9]
			{
				'%',
				'E',
				'\0',
				'%',
				'\0',
				'\0',
				'%',
				'\0',
				UPPER_HEX_DIGITS[cp & 0xF]
			};
			cp = (int)((uint)cp >> 4);
			array[7] = UPPER_HEX_DIGITS[8 | (cp & 3)];
			cp = (int)((uint)cp >> 2);
			array[5] = UPPER_HEX_DIGITS[cp & 0xF];
			cp = (int)((uint)cp >> 4);
			array[4] = UPPER_HEX_DIGITS[8 | (cp & 3)];
			cp = (int)((uint)cp >> 2);
			array[2] = UPPER_HEX_DIGITS[cp];
			return array;
		}
		if (cp <= 1114111)
		{
			char[] array = new char[12]
			{
				'%',
				'F',
				'\0',
				'%',
				'\0',
				'\0',
				'%',
				'\0',
				'\0',
				'%',
				'\0',
				UPPER_HEX_DIGITS[cp & 0xF]
			};
			cp = (int)((uint)cp >> 4);
			array[10] = UPPER_HEX_DIGITS[8 | (cp & 3)];
			cp = (int)((uint)cp >> 2);
			array[8] = UPPER_HEX_DIGITS[cp & 0xF];
			cp = (int)((uint)cp >> 4);
			array[7] = UPPER_HEX_DIGITS[8 | (cp & 3)];
			cp = (int)((uint)cp >> 2);
			array[5] = UPPER_HEX_DIGITS[cp & 0xF];
			cp = (int)((uint)cp >> 4);
			array[4] = UPPER_HEX_DIGITS[8 | (cp & 3)];
			cp = (int)((uint)cp >> 2);
			array[2] = UPPER_HEX_DIGITS[cp & 7];
			return array;
		}
		int i = cp;
		int num = 43;
		num = num;
		string s = new StringBuilder(num).append("Invalid unicode character value ").append(i).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[LineNumberTable(new byte[] { 7, 176 })]
	static PercentEscaper()
	{
		PLUS_SIGN = new char[1] { '+' };
		UPPER_HEX_DIGITS = String.instancehelper_toCharArray("0123456789ABCDEF");
	}
}
