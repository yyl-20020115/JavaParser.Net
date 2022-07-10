using System.Runtime.CompilerServices;
using com.google.common.escape;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.html;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/html/ElementTypesAreNonnullByDefault;"
})]
public sealed class HtmlEscapers : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Escaper HTML_ESCAPER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	public static Escaper htmlEscaper()
	{
		return HTML_ESCAPER;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	private HtmlEscapers()
	{
	}

	[LineNumberTable(new byte[] { 10, 108, 140, 108, 108, 108, 101, 234, 56 })]
	static HtmlEscapers()
	{
		HTML_ESCAPER = Escapers.builder().addEscape('"', "&quot;").addEscape('\'', "&#39;")
			.addEscape('&', "&amp;")
			.addEscape('<', "&lt;")
			.addEscape('>', "&gt;")
			.build();
	}
}
