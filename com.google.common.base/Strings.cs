using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util.logging;
using javax.annotation;

namespace com.google.common.@base;

[ConstantPool(new object[]
{
	(byte)128,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Strings : java.lang.Object
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 128, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		160, 156, 136, 99, 146, 103, 43, 230, 70, 114,
		98, 98, 104, 110, 101, 130, 127, 6, 110, 101,
		101, 191, 10, 101, 108, 110, 101, 108, 144, 169
	})]
	public static string lenientFormat([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string template, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] params object[] args)
	{
		template = java.lang.String.valueOf(template);
		if (args == null)
		{
			args = new object[1] { "(Object[])null" };
		}
		else
		{
			for (int i = 0; i < (nint)args.LongLength; i++)
			{
				args[i] = lenientToString(args[i]);
			}
		}
		StringBuilder stringBuilder = new StringBuilder((int)(java.lang.String.instancehelper_length(template) + 16 * (nint)args.LongLength));
		int num = 0;
		int num2 = 0;
		CharSequence s = default(CharSequence);
		int end;
		int start;
		object obj;
		while (num2 < (nint)args.LongLength)
		{
			int num3 = java.lang.String.instancehelper_indexOf(template, "%s", num);
			if (num3 == -1)
			{
				break;
			}
			string __003Cref_003E = template;
			int num4 = num;
			end = num3;
			start = num4;
			obj = (s.___003Cref_003E = __003Cref_003E);
			stringBuilder.append(s, start, end);
			object[] array = args;
			int num5 = num2;
			num2++;
			stringBuilder.append(array[num5]);
			num = num3 + 2;
		}
		string __003Cref_003E2 = template;
		int num6 = num;
		end = java.lang.String.instancehelper_length(template);
		start = num6;
		obj = (s.___003Cref_003E = __003Cref_003E2);
		stringBuilder.append(s, start, end);
		if (num2 < (nint)args.LongLength)
		{
			stringBuilder.append(" [");
			object[] array2 = args;
			int num7 = num2;
			num2++;
			stringBuilder.append(array2[num7]);
			while (num2 < (nint)args.LongLength)
			{
				stringBuilder.append(", ");
				object[] array3 = args;
				int num8 = num2;
				num2++;
				stringBuilder.append(array3[num8]);
			}
			stringBuilder.append(']');
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159,
		85,
		106,
		105,
		118,
		127,
		0,
		byte.MaxValue,
		0,
		61
	})]
	internal static bool validSurrogatePairAt(CharSequence P_0, int P_1)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		int result;
		if (P_1 >= 0)
		{
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (P_1 <= charSequence2.length() - 2)
			{
				int i = P_1;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (Character.isHighSurrogate(charSequence2.charAt(i)))
				{
					i = P_1 + 1;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					if (Character.isLowSurrogate(charSequence2.charAt(i)))
					{
						result = 1;
						goto IL_0067;
					}
				}
			}
		}
		result = 0;
		goto IL_0067;
		IL_0067:
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 196, 99, 166, 127, 2, 129, 97, 159, 59,
		127, 31, 101
	})]
	private static string lenientToString([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		//Discarded unreachable code: IL_0011
		if (P_0 == null)
		{
			return "null";
		}
		java.lang.Exception ex2;
		try
		{
			return java.lang.Object.instancehelper_toString(P_0);
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception ex3 = ex2;
		string name = java.lang.Object.instancehelper_getClass(P_0).getName();
		string text = Integer.toHexString(java.lang.System.identityHashCode(P_0));
		int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(name)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string text2 = new StringBuilder(num).append(name).append('@').append(text)
			.toString();
		Logger logger = Logger.getLogger("com.google.common.base.Strings", Strings.___003CGetCallerID_003E());
		Level wARNING = Level.WARNING;
		string text3 = java.lang.String.valueOf(text2);
		string msg;
		if (java.lang.String.instancehelper_length(text3) != 0)
		{
			msg = java.lang.String.instancehelper_concat("Exception during lenientFormat for ", text3);
		}
		else
		{
			string text4 = "Exception during lenientFormat for ";
			text4 = text4;
			msg = java.lang.String.newhelper(text4);
		}
		logger.log(wARNING, msg, ex3);
		name = java.lang.Object.instancehelper_getClass(ex3).getName();
		num = 9 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(name));
		num = num;
		return new StringBuilder(num).append("<").append(text2).append(" threw ")
			.append(name)
			.append(">")
			.toString();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	private Strings()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	public static string nullToEmpty([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string @string)
	{
		string result = Platform.nullToEmpty(@string);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static string emptyToNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string @string)
	{
		string result = Platform.emptyToNull(@string);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public static bool isNullOrEmpty([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string @string)
	{
		bool result = Platform.stringIsNullOrEmpty(@string);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 119, 162, 103, 105, 130, 103, 107, 40, 166,
		104
	})]
	public static string padStart(string @string, int minLength, char padChar)
	{
		Preconditions.checkNotNull(@string);
		if (java.lang.String.instancehelper_length(@string) >= minLength)
		{
			return @string;
		}
		StringBuilder stringBuilder = new StringBuilder(minLength);
		for (int i = java.lang.String.instancehelper_length(@string); i < minLength; i++)
		{
			stringBuilder.append(padChar);
		}
		stringBuilder.append(@string);
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 111, 130, 103, 105, 130, 103, 104, 107, 40,
		166
	})]
	public static string padEnd(string @string, int minLength, char padChar)
	{
		Preconditions.checkNotNull(@string);
		if (java.lang.String.instancehelper_length(@string) >= minLength)
		{
			return @string;
		}
		StringBuilder stringBuilder = new StringBuilder(minLength);
		stringBuilder.append(@string);
		for (int i = java.lang.String.instancehelper_length(@string); i < minLength; i++)
		{
			stringBuilder.append(padChar);
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		103, 135, 100, 114, 204, 103, 102, 99, 101, 191,
		12, 104, 139, 107, 46, 168, 112
	})]
	public static string repeat(string @string, int count)
	{
		Preconditions.checkNotNull(@string);
		if (count <= 1)
		{
			Preconditions.checkArgument(count >= 0, "invalid count: %s", count);
			return (count != 0) ? @string : "";
		}
		int num = java.lang.String.instancehelper_length(@string);
		long num2 = (long)num * (long)count;
		int num3 = (int)num2;
		if (num3 != num2)
		{
			int num4 = 51;
			num4 = num4;
			string s = new StringBuilder(num4).append("Required array size too large: ").append(num2).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ArrayIndexOutOfBoundsException(s);
		}
		char[] array = new char[num3];
		java.lang.String.instancehelper_getChars(@string, 0, num, array, 0);
		int num5;
		for (num5 = num; num5 < num3 - num5; num5 <<= 1)
		{
			ByteCodeHelper.arraycopy_primitive_2(array, 0, array, num5, num5);
		}
		ByteCodeHelper.arraycopy_primitive_2(array, 0, array, num5, num3 - num5);
		string result = java.lang.String.newhelper(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 96, 148, 103, 135, 127, 14, 99, 127, 27,
		136, 127, 37, 134
	})]
	public static string commonPrefix(CharSequence a, CharSequence b)
	{
		CharSequence charSequence = a;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = b;
		object __003Cref_003E2 = charSequence2.___003Cref_003E;
		Preconditions.checkNotNull(__003Cref_003E);
		Preconditions.checkNotNull(__003Cref_003E2);
		CharSequence charSequence3 = default(CharSequence);
		object obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		int a2 = charSequence3.length();
		obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
		int num = java.lang.Math.min(a2, charSequence3.length());
		int i;
		int i2;
		for (i = 0; i < num; i++)
		{
			i2 = i;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			char num2 = charSequence3.charAt(i2);
			i2 = i;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			if (num2 != charSequence3.charAt(i2))
			{
				break;
			}
		}
		i2 = i - 1;
		obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		if (!validSurrogatePairAt(charSequence3, i2))
		{
			i2 = i - 1;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			if (!validSurrogatePairAt(charSequence3, i2))
			{
				goto IL_00de;
			}
		}
		i += -1;
		goto IL_00de;
		IL_00de:
		int i3 = i;
		i2 = 0;
		obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		obj = (charSequence3.___003Cref_003E = charSequence3.subSequence(i2, i3).___003Cref_003E);
		string result = charSequence3.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 90, 84, 103, 135, 127, 14, 99, 127, 74,
		139, 127, 25, 127, 21, 134
	})]
	public static string commonSuffix(CharSequence a, CharSequence b)
	{
		CharSequence charSequence = a;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = b;
		object __003Cref_003E2 = charSequence2.___003Cref_003E;
		Preconditions.checkNotNull(__003Cref_003E);
		Preconditions.checkNotNull(__003Cref_003E2);
		CharSequence charSequence3 = default(CharSequence);
		object obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		int a2 = charSequence3.length();
		obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
		int num = java.lang.Math.min(a2, charSequence3.length());
		int i;
		int i2;
		for (i = 0; i < num; i++)
		{
			obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			i2 = charSequence3.length() - i - 1;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			char num2 = charSequence3.charAt(i2);
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			i2 = charSequence3.length() - i - 1;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			if (num2 != charSequence3.charAt(i2))
			{
				break;
			}
		}
		obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		i2 = charSequence3.length() - i - 1;
		obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		if (!validSurrogatePairAt(charSequence3, i2))
		{
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			i2 = charSequence3.length() - i - 1;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			if (!validSurrogatePairAt(charSequence3, i2))
			{
				goto IL_0138;
			}
		}
		i += -1;
		goto IL_0138;
		IL_0138:
		obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		int num3 = charSequence3.length() - i;
		obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		int i3 = charSequence3.length();
		i2 = num3;
		obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		obj = (charSequence3.___003Cref_003E = charSequence3.subSequence(i2, i3).___003Cref_003E);
		string result = charSequence3.toString();
		_ = null;
		return result;
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
