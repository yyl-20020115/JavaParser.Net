using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Ascii : Object
{
	public const byte NUL = 0;

	public const byte SOH = 1;

	public const byte STX = 2;

	public const byte ETX = 3;

	public const byte EOT = 4;

	public const byte ENQ = 5;

	public const byte ACK = 6;

	public const byte BEL = 7;

	public const byte BS = 8;

	public const byte HT = 9;

	public const byte LF = 10;

	public const byte NL = 10;

	public const byte VT = 11;

	public const byte FF = 12;

	public const byte CR = 13;

	public const byte SO = 14;

	public const byte SI = 15;

	public const byte DLE = 16;

	public const byte DC1 = 17;

	public const byte XON = 17;

	public const byte DC2 = 18;

	public const byte DC3 = 19;

	public const byte XOFF = 19;

	public const byte DC4 = 20;

	public const byte NAK = 21;

	public const byte SYN = 22;

	public const byte ETB = 23;

	public const byte CAN = 24;

	public const byte EM = 25;

	public const byte SUB = 26;

	public const byte ESC = 27;

	public const byte FS = 28;

	public const byte GS = 29;

	public const byte RS = 30;

	public const byte US = 31;

	public const byte SP = 32;

	public const byte SPACE = 32;

	public const byte DEL = 127;

	public const char MIN = '\0';

	public const char MAX = '\u007f';

	private const char CASE_MASK = ' ';

	public static bool isUpperCase(char c)
	{
		return (c >= 'A' && c <= 'Z') ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 38, 103, 105, 110, 103, 100, 100, 104, 232,
		61, 230, 70, 233, 55, 233, 76
	})]
	public static string toLowerCase(string @string)
	{
		int num = String.instancehelper_length(@string);
		for (int i = 0; i < num; i++)
		{
			if (!isUpperCase(String.instancehelper_charAt(@string, i)))
			{
				continue;
			}
			char[] array = String.instancehelper_toCharArray(@string);
			for (; i < num; i++)
			{
				int num2 = array[i];
				if (isUpperCase((char)num2))
				{
					array[i] = (char)((uint)num2 ^ 0x20u);
				}
			}
			string result = String.valueOf(array);
			_ = null;
			return result;
		}
		return @string;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(447)]
	public static char toLowerCase(char c)
	{
		return (!isUpperCase(c)) ? c : ((char)(c ^ 0x20u));
	}

	public static bool isLowerCase(char c)
	{
		return (c >= 'a' && c <= 'z') ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 86, 103, 105, 110, 103, 100, 100, 104, 232,
		61, 230, 70, 233, 55, 233, 76
	})]
	public static string toUpperCase(string @string)
	{
		int num = String.instancehelper_length(@string);
		for (int i = 0; i < num; i++)
		{
			if (!isLowerCase(String.instancehelper_charAt(@string, i)))
			{
				continue;
			}
			char[] array = String.instancehelper_toCharArray(@string);
			for (; i < num; i++)
			{
				int num2 = array[i];
				if (isLowerCase((char)num2))
				{
					array[i] = (char)((uint)num2 ^ 0x20u);
				}
			}
			string result = String.valueOf(array);
			_ = null;
			return result;
		}
		return @string;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(495)]
	public static char toUpperCase(char c)
	{
		return (!isLowerCase(c)) ? c : ((char)(c ^ 0x20u));
	}

	private static int getAlphaIndex(char P_0)
	{
		return (ushort)((P_0 | 0x20) - 97);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	private Ascii()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 34, 74, 104, 142, 120, 106, 63, 2, 168 })]
	public static string toLowerCase(CharSequence chars)
	{
		CharSequence charSequence = chars;
		object __003Cref_003E = charSequence.___003Cref_003E;
		if (__003Cref_003E is string)
		{
			string result = toLowerCase((string)__003Cref_003E);
			_ = null;
			return result;
		}
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		char[] array = new char[charSequence2.length()];
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			int num = i;
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			array[num] = toLowerCase(charSequence2.charAt(i2));
		}
		string result2 = String.valueOf(array);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 22, 74, 104, 142, 120, 106, 63, 2, 168 })]
	public static string toUpperCase(CharSequence chars)
	{
		CharSequence charSequence = chars;
		object __003Cref_003E = charSequence.___003Cref_003E;
		if (__003Cref_003E is string)
		{
			string result = toUpperCase((string)__003Cref_003E);
			_ = null;
			return result;
		}
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		char[] array = new char[charSequence2.length()];
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			int num = i;
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			array[num] = toUpperCase(charSequence2.charAt(i2));
		}
		string result2 = String.valueOf(array);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 5, 170, 174, 201, 206, 229, 60, 229, 70,
		123, 122, 106, 163, 163, 105, 126, 101, 231, 61
	})]
	public static string truncate(CharSequence seq, int maxLength, string truncationIndicator)
	{
		CharSequence charSequence = seq;
		object obj = charSequence.___003Cref_003E;
		object obj2 = obj;
		CharSequence.Cast(obj2);
		Preconditions.checkNotNull(obj2);
		int num = maxLength - String.instancehelper_length(truncationIndicator);
		Preconditions.checkArgument(num >= 0, "maxLength (%s) must be >= length of the truncation indicator (%s)", maxLength, String.instancehelper_length(truncationIndicator));
		object obj3 = obj;
		CharSequence.Cast(obj3);
		CharSequence s = default(CharSequence);
		object obj4 = (s.___003Cref_003E = obj3);
		if (s.length() <= maxLength)
		{
			object obj5 = obj;
			CharSequence.Cast(obj5);
			obj4 = (s.___003Cref_003E = obj5);
			string text = s.toString();
			if (String.instancehelper_length(text) <= maxLength)
			{
				return text;
			}
			obj = text;
		}
		StringBuilder stringBuilder = new StringBuilder(maxLength);
		object __003Cref_003E = obj;
		int end = num;
		int start = 0;
		obj4 = (s.___003Cref_003E = __003Cref_003E);
		string result = stringBuilder.append(s, start, end).append(truncationIndicator).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 248, 180, 117, 100, 130, 119, 130, 108, 123,
		123, 102, 130, 169, 113, 130, 226, 52, 235, 78
	})]
	public static bool equalsIgnoreCase(CharSequence s1, CharSequence s2)
	{
		CharSequence charSequence = s1;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = s2;
		object __003Cref_003E2 = charSequence2.___003Cref_003E;
		CharSequence charSequence3 = default(CharSequence);
		object obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		int num = charSequence3.length();
		if (__003Cref_003E == __003Cref_003E2)
		{
			return true;
		}
		obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
		if (num != charSequence3.length())
		{
			return false;
		}
		for (int i = 0; i < num; i++)
		{
			int i2 = i;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			int num2 = charSequence3.charAt(i2);
			i2 = i;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			int num3 = charSequence3.charAt(i2);
			if (num2 != num3)
			{
				int alphaIndex = getAlphaIndex((char)num2);
				if (alphaIndex >= 26 || alphaIndex != getAlphaIndex((char)num3))
				{
					return false;
				}
			}
		}
		return true;
	}
}
