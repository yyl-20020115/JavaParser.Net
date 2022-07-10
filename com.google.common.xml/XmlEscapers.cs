using System.Runtime.CompilerServices;
using com.google.common.escape;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.xml;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/xml/ElementTypesAreNonnullByDefault;"
})]
public class XmlEscapers : Object
{
	private const char MIN_ASCII_CONTROL_CHAR = '\0';

	private const char MAX_ASCII_CONTROL_CHAR = '\u001f';

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Escaper XML_ESCAPER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Escaper XML_CONTENT_ESCAPER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Escaper XML_ATTRIBUTE_ESCAPER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	private XmlEscapers()
	{
	}

	public static Escaper xmlContentEscaper()
	{
		return XML_CONTENT_ESCAPER;
	}

	public static Escaper xmlAttributeEscaper()
	{
		return XML_ATTRIBUTE_ESCAPER;
	}

	[LineNumberTable(new byte[]
	{
		56, 198, 141, 236, 75, 103, 111, 13, 231, 72,
		110, 110, 110, 107, 110, 110, 107, 110, 110, 110,
		107
	})]
	static XmlEscapers()
	{
		Escapers.Builder builder = Escapers.builder();
		builder.setSafeRange('\0', '\ufffd');
		builder.setUnsafeReplacement("\ufffd");
		for (int num = 0; num <= 31; num = (ushort)(num + 1))
		{
			if (num != 9 && num != 10 && num != 13)
			{
				builder.addEscape((char)num, "\ufffd");
			}
		}
		builder.addEscape('&', "&amp;");
		builder.addEscape('<', "&lt;");
		builder.addEscape('>', "&gt;");
		XML_CONTENT_ESCAPER = builder.build();
		builder.addEscape('\'', "&apos;");
		builder.addEscape('"', "&quot;");
		XML_ESCAPER = builder.build();
		builder.addEscape('\t', "&#x9;");
		builder.addEscape('\n', "&#xA;");
		builder.addEscape('\r', "&#xD;");
		XML_ATTRIBUTE_ESCAPER = builder.build();
	}
}
