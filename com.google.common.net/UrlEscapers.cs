using System.Runtime.CompilerServices;
using com.google.common.escape;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.net;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/net/ElementTypesAreNonnullByDefault;"
})]
public sealed class UrlEscapers : Object
{
	internal const string URL_FORM_PARAMETER_OTHER_SAFE_CHARS = "-_.*";

	internal const string URL_PATH_OTHER_SAFE_CHARS_LACKING_PLUS = "-._~!$'()*,;&=@:";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Escaper URL_FORM_PARAMETER_ESCAPER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Escaper URL_PATH_SEGMENT_ESCAPER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Escaper URL_FRAGMENT_ESCAPER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(34)]
	private UrlEscapers()
	{
	}

	public static Escaper urlFormParameterEscaper()
	{
		return URL_FORM_PARAMETER_ESCAPER;
	}

	public static Escaper urlPathSegmentEscaper()
	{
		return URL_PATH_SEGMENT_ESCAPER;
	}

	public static Escaper urlFragmentEscaper()
	{
		return URL_FRAGMENT_ESCAPER;
	}

	[LineNumberTable(new byte[] { 28, 240, 100, 240, 96 })]
	static UrlEscapers()
	{
		URL_FORM_PARAMETER_ESCAPER = new PercentEscaper("-_.*", plusForSpace: true);
		URL_PATH_SEGMENT_ESCAPER = new PercentEscaper("-._~!$'()*,;&=@:+", plusForSpace: false);
		URL_FRAGMENT_ESCAPER = new PercentEscaper("-._~!$'()*,;&=@:+/?", plusForSpace: false);
	}
}
