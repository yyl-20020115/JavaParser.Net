using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
internal sealed class ParseRequest : Object
{
	[Modifiers(Modifiers.Final)]
	internal string rawValue;

	[Modifiers(Modifiers.Final)]
	internal int radix;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 168, 104, 103, 103 })]
	private ParseRequest(string P_0, int P_1)
	{
		rawValue = P_0;
		radix = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 174, 104, 240, 70, 104, 122, 104, 101, 101,
		104, 101, 110, 104, 132, 98, 163
	})]
	internal static ParseRequest fromString(string P_0)
	{
		if (String.instancehelper_length(P_0) == 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NumberFormatException("empty string");
		}
		int num = String.instancehelper_charAt(P_0, 0);
		string text;
		int num2;
		if (String.instancehelper_startsWith(P_0, "0x") || String.instancehelper_startsWith(P_0, "0X"))
		{
			text = String.instancehelper_substring(P_0, 2);
			num2 = 16;
		}
		else if (num == 35)
		{
			text = String.instancehelper_substring(P_0, 1);
			num2 = 16;
		}
		else if (num == 48 && String.instancehelper_length(P_0) > 1)
		{
			text = String.instancehelper_substring(P_0, 1);
			num2 = 8;
		}
		else
		{
			text = P_0;
			num2 = 10;
		}
		ParseRequest result = new ParseRequest(text, num2);
		_ = null;
		return result;
	}
}
