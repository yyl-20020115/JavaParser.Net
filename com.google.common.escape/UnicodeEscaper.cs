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
public abstract class UnicodeEscaper : Escaper
{
	private const int DEST_PAD = 32;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 109, 74, 98, 103, 127, 3, 111, 130, 112,
		101
	})]
	protected internal virtual int nextEscapeIndex(CharSequence csq, int start, int end)
	{
		CharSequence charSequence = csq;
		object __003Cref_003E = charSequence.___003Cref_003E;
		int i;
		CharSequence seq = default(CharSequence);
		int num;
		for (i = start; i < end; i += ((!Character.isSupplementaryCodePoint(num)) ? 1 : 2))
		{
			int index = i;
			object obj = (seq.___003Cref_003E = __003Cref_003E);
			num = codePointAt(seq, index, end);
			if (num < 0 || escape(num) != null)
			{
				break;
			}
		}
		return i;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		109, 167, 102, 98, 130, 103, 127, 5, 101, 240,
		69, 106, 113, 103, 197, 106, 102, 107, 170, 101,
		106, 133, 102, 109, 166, 131, 127, 7, 197, 101,
		101, 102, 102, 138, 106, 131
	})]
	protected internal string escapeSlow(string s, int index)
	{
		int num = String.instancehelper_length(s);
		char[] array = Platform.charBufferFromThreadLocal();
		int num2 = 0;
		int num3 = 0;
		CharSequence charSequence = default(CharSequence);
		int num5;
		while (index < num)
		{
			int num4 = index;
			int end = num;
			int index2 = num4;
			object obj = (charSequence.___003Cref_003E = s);
			num5 = codePointAt(charSequence, index2, end);
			if (num5 < 0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException("Trailing high surrogate at end of input");
			}
			char[] array2 = escape(num5);
			int num6 = index + ((!Character.isSupplementaryCodePoint(num5)) ? 1 : 2);
			if (array2 != null)
			{
				int num7 = index - num3;
				int num8 = (int)(num2 + num7 + (nint)array2.LongLength);
				if ((nint)array.LongLength < num8)
				{
					int num9 = num8 + (num - index) + 32;
					array = growBuffer(array, num2, num9);
				}
				if (num7 > 0)
				{
					String.instancehelper_getChars(s, num3, index, array, num2);
					num2 += num7;
				}
				if ((nint)array2.LongLength > 0)
				{
					ByteCodeHelper.arraycopy_primitive_2(array2, 0, array, num2, array2.Length);
					num2 = (int)(num2 + (nint)array2.LongLength);
				}
				num3 = num6;
			}
			end = num;
			index2 = num6;
			obj = (charSequence.___003Cref_003E = s);
			index = nextEscapeIndex(charSequence, index2, end);
		}
		num5 = num - num3;
		if (num5 > 0)
		{
			int num10 = num2 + num5;
			if ((nint)array.LongLength < num10)
			{
				array = growBuffer(array, num2, num10);
			}
			String.instancehelper_getChars(s, num3, num, array, num2);
			num2 = num10;
		}
		string result = String.newhelper(array, 0, num2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159,
		81,
		170,
		103,
		103,
		123,
		146,
		99,
		140,
		100,
		164,
		118,
		105,
		140,
		byte.MaxValue,
		102,
		75,
		byte.MaxValue,
		104,
		76
	})]
	protected internal static int codePointAt(CharSequence seq, int index, int end)
	{
		CharSequence charSequence = seq;
		object __003Cref_003E = charSequence.___003Cref_003E;
		Preconditions.checkNotNull(__003Cref_003E);
		if (index < end)
		{
			int num = index;
			index++;
			int i = num;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num2 = charSequence2.charAt(i);
			if (num2 < 55296 || num2 > 57343)
			{
				return num2;
			}
			int num3;
			int i2;
			if (num2 <= 56319)
			{
				if (index == end)
				{
					return -num2;
				}
				i = index;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				num3 = charSequence2.charAt(i);
				if (Character.isLowSurrogate((char)num3))
				{
					int result = Character.toCodePoint((char)num2, (char)num3);
					_ = null;
					return result;
				}
				i2 = num3;
				int i3 = index;
				string text = String.valueOf(__003Cref_003E);
				i = 89 + String.instancehelper_length(String.valueOf(text));
				i = i;
				string s = new StringBuilder(i).append("Expected low surrogate but got char '").append((char)num3).append("' with value ")
					.append(i2)
					.append(" at index ")
					.append(i3)
					.append(" in '")
					.append(text)
					.append("'")
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
			num3 = num2;
			i2 = index - 1;
			string text2 = String.valueOf(__003Cref_003E);
			i = 88 + String.instancehelper_length(String.valueOf(text2));
			i = i;
			string s2 = new StringBuilder(i).append("Unexpected low surrogate character '").append((char)num2).append("' with value ")
				.append(num3)
				.append(" at index ")
				.append(i2)
				.append(" in '")
				.append(text2)
				.append("'")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s2);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IndexOutOfBoundsException("Index exceeds specified range");
	}

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal abstract char[] escape(int i);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 180, 100, 144, 103, 100, 138 })]
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
	[LineNumberTable(59)]
	protected internal UnicodeEscaper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 53, 103, 103, 127, 0 })]
	public override string escape(string @string)
	{
		Preconditions.checkNotNull(@string);
		int num = String.instancehelper_length(@string);
		int end = num;
		int start = 0;
		CharSequence csq = default(CharSequence);
		object obj = (csq.___003Cref_003E = @string);
		int num2 = nextEscapeIndex(csq, start, end);
		string result = ((num2 != num) ? escapeSlow(@string, num2) : @string);
		_ = null;
		return result;
	}
}
