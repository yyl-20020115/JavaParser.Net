using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.nio.charset;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Charsets : Object
{
	internal static Charset ___003C_003EUS_ASCII;

	internal static Charset ___003C_003EISO_8859_1;

	internal static Charset ___003C_003EUTF_8;

	internal static Charset ___003C_003EUTF_16BE;

	internal static Charset ___003C_003EUTF_16LE;

	internal static Charset ___003C_003EUTF_16;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Charset US_ASCII
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUS_ASCII;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Charset ISO_8859_1
	{
		[HideFromJava]
		get
		{
			return ___003C_003EISO_8859_1;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Charset UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Charset UTF_16BE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUTF_16BE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Charset UTF_16LE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUTF_16LE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Charset UTF_16
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUTF_16;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	private Charsets()
	{
	}

	[LineNumberTable(new byte[]
	{
		159, 188, 239, 73, 239, 73, 239, 74, 239, 74,
		239, 75
	})]
	static Charsets()
	{
		___003C_003EUS_ASCII = Charset.forName("US-ASCII");
		___003C_003EISO_8859_1 = Charset.forName("ISO-8859-1");
		___003C_003EUTF_8 = Charset.forName("UTF-8");
		___003C_003EUTF_16BE = Charset.forName("UTF-16BE");
		___003C_003EUTF_16LE = Charset.forName("UTF-16LE");
		___003C_003EUTF_16 = Charset.forName("UTF-16");
	}
}
