using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.nio.charset;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.net;

[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/net/ElementTypesAreNonnullByDefault;"
})]
public sealed class MediaType : Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Tokenizer : Object
	{
		[Modifiers(Modifiers.Final)]
		internal string input;

		internal int position;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1127)]
		internal virtual bool hasMore()
		{
			return (position >= 0 && position < String.instancehelper_length(input)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 210, 107, 103, 127, 11 })]
		internal virtual string consumeTokenIfPresent(CharMatcher P_0)
		{
			Preconditions.checkState(hasMore());
			int num = position;
			CharMatcher charMatcher = P_0.negate();
			string __003Cref_003E = input;
			int start = num;
			CharSequence sequence = default(CharSequence);
			object obj = (sequence.___003Cref_003E = __003Cref_003E);
			position = charMatcher.indexIn(sequence, start);
			string result = ((!hasMore()) ? String.instancehelper_substring(input, num) : String.instancehelper_substring(input, num, position));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 240, 107 })]
		internal virtual char previewChar()
		{
			Preconditions.checkState(hasMore());
			char result = String.instancehelper_charAt(input, position);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 204, 8, 167, 103 })]
		internal Tokenizer(string P_0)
		{
			position = 0;
			input = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 217, 103, 104, 113 })]
		internal virtual string consumeToken(CharMatcher P_0)
		{
			int num = position;
			string result = consumeTokenIfPresent(P_0);
			Preconditions.checkState(position != num);
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 224, 107, 103, 108, 110 })]
		internal virtual char consumeCharacter(CharMatcher P_0)
		{
			Preconditions.checkState(hasMore());
			int num = previewChar();
			Preconditions.checkState(P_0.matches((char)num));
			position++;
			return (char)num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 120, 162, 107, 110, 110 })]
		internal virtual char consumeCharacter(char P_0)
		{
			Preconditions.checkState(hasMore());
			Preconditions.checkState(previewChar() == P_0);
			position++;
			return P_0;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			ImmutableMultiset result = ImmutableMultiset.copyOf((Collection)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : com.google.common.@base.Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			string result = lambda_0024computeToString_00240((string)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	private const string CHARSET_ATTRIBUTE = "charset";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableListMultimap<Ljava/lang/String;Ljava/lang/String;>;")]
	private static ImmutableListMultimap UTF_8_CONSTANT_PARAMETERS;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher TOKEN_MATCHER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher QUOTED_TEXT_MATCHER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static CharMatcher LINEAR_WHITE_SPACE;

	private const string APPLICATION_TYPE = "application";

	private const string AUDIO_TYPE = "audio";

	private const string IMAGE_TYPE = "image";

	private const string TEXT_TYPE = "text";

	private const string VIDEO_TYPE = "video";

	private const string FONT_TYPE = "font";

	private const string WILDCARD = "*";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/Map<Lcom/google/common/net/MediaType;Lcom/google/common/net/MediaType;>;")]
	private static Map KNOWN_TYPES;

	internal static MediaType ___003C_003EANY_TYPE;

	internal static MediaType ___003C_003EANY_TEXT_TYPE;

	internal static MediaType ___003C_003EANY_IMAGE_TYPE;

	internal static MediaType ___003C_003EANY_AUDIO_TYPE;

	internal static MediaType ___003C_003EANY_VIDEO_TYPE;

	internal static MediaType ___003C_003EANY_APPLICATION_TYPE;

	internal static MediaType ___003C_003EANY_FONT_TYPE;

	internal static MediaType ___003C_003ECACHE_MANIFEST_UTF_8;

	internal static MediaType ___003C_003ECSS_UTF_8;

	internal static MediaType ___003C_003ECSV_UTF_8;

	internal static MediaType ___003C_003EHTML_UTF_8;

	internal static MediaType ___003C_003EI_CALENDAR_UTF_8;

	internal static MediaType ___003C_003EPLAIN_TEXT_UTF_8;

	internal static MediaType ___003C_003ETEXT_JAVASCRIPT_UTF_8;

	internal static MediaType ___003C_003ETSV_UTF_8;

	internal static MediaType ___003C_003EVCARD_UTF_8;

	internal static MediaType ___003C_003EWML_UTF_8;

	internal static MediaType ___003C_003EXML_UTF_8;

	internal static MediaType ___003C_003EVTT_UTF_8;

	internal static MediaType ___003C_003EBMP;

	internal static MediaType ___003C_003ECRW;

	internal static MediaType ___003C_003EGIF;

	internal static MediaType ___003C_003EICO;

	internal static MediaType ___003C_003EJPEG;

	internal static MediaType ___003C_003EPNG;

	internal static MediaType ___003C_003EPSD;

	internal static MediaType ___003C_003ESVG_UTF_8;

	internal static MediaType ___003C_003ETIFF;

	internal static MediaType ___003C_003EWEBP;

	internal static MediaType ___003C_003EHEIF;

	internal static MediaType ___003C_003EJP2K;

	internal static MediaType ___003C_003EMP4_AUDIO;

	internal static MediaType ___003C_003EMPEG_AUDIO;

	internal static MediaType ___003C_003EOGG_AUDIO;

	internal static MediaType ___003C_003EWEBM_AUDIO;

	internal static MediaType ___003C_003EL16_AUDIO;

	internal static MediaType ___003C_003EL24_AUDIO;

	internal static MediaType ___003C_003EBASIC_AUDIO;

	internal static MediaType ___003C_003EAAC_AUDIO;

	internal static MediaType ___003C_003EVORBIS_AUDIO;

	internal static MediaType ___003C_003EWMA_AUDIO;

	internal static MediaType ___003C_003EWAX_AUDIO;

	internal static MediaType ___003C_003EVND_REAL_AUDIO;

	internal static MediaType ___003C_003EVND_WAVE_AUDIO;

	internal static MediaType ___003C_003EMP4_VIDEO;

	internal static MediaType ___003C_003EMPEG_VIDEO;

	internal static MediaType ___003C_003EOGG_VIDEO;

	internal static MediaType ___003C_003EQUICKTIME;

	internal static MediaType ___003C_003EWEBM_VIDEO;

	internal static MediaType ___003C_003EWMV;

	internal static MediaType ___003C_003EFLV_VIDEO;

	internal static MediaType ___003C_003ETHREE_GPP_VIDEO;

	internal static MediaType ___003C_003ETHREE_GPP2_VIDEO;

	internal static MediaType ___003C_003EAPPLICATION_XML_UTF_8;

	internal static MediaType ___003C_003EATOM_UTF_8;

	internal static MediaType ___003C_003EBZIP2;

	internal static MediaType ___003C_003EDART_UTF_8;

	internal static MediaType ___003C_003EAPPLE_PASSBOOK;

	internal static MediaType ___003C_003EEOT;

	internal static MediaType ___003C_003EEPUB;

	internal static MediaType ___003C_003EFORM_DATA;

	internal static MediaType ___003C_003EKEY_ARCHIVE;

	internal static MediaType ___003C_003EAPPLICATION_BINARY;

	internal static MediaType ___003C_003EGEO_JSON;

	internal static MediaType ___003C_003EGZIP;

	internal static MediaType ___003C_003EHAL_JSON;

	internal static MediaType ___003C_003EJAVASCRIPT_UTF_8;

	internal static MediaType ___003C_003EJOSE;

	internal static MediaType ___003C_003EJOSE_JSON;

	internal static MediaType ___003C_003EJSON_UTF_8;

	internal static MediaType ___003C_003EMANIFEST_JSON_UTF_8;

	internal static MediaType ___003C_003EKML;

	internal static MediaType ___003C_003EKMZ;

	internal static MediaType ___003C_003EMBOX;

	internal static MediaType ___003C_003EAPPLE_MOBILE_CONFIG;

	internal static MediaType ___003C_003EMICROSOFT_EXCEL;

	internal static MediaType ___003C_003EMICROSOFT_OUTLOOK;

	internal static MediaType ___003C_003EMICROSOFT_POWERPOINT;

	internal static MediaType ___003C_003EMICROSOFT_WORD;

	internal static MediaType ___003C_003EMEDIA_PRESENTATION_DESCRIPTION;

	internal static MediaType ___003C_003EWASM_APPLICATION;

	internal static MediaType ___003C_003ENACL_APPLICATION;

	internal static MediaType ___003C_003ENACL_PORTABLE_APPLICATION;

	internal static MediaType ___003C_003EOCTET_STREAM;

	internal static MediaType ___003C_003EOGG_CONTAINER;

	internal static MediaType ___003C_003EOOXML_DOCUMENT;

	internal static MediaType ___003C_003EOOXML_PRESENTATION;

	internal static MediaType ___003C_003EOOXML_SHEET;

	internal static MediaType ___003C_003EOPENDOCUMENT_GRAPHICS;

	internal static MediaType ___003C_003EOPENDOCUMENT_PRESENTATION;

	internal static MediaType ___003C_003EOPENDOCUMENT_SPREADSHEET;

	internal static MediaType ___003C_003EOPENDOCUMENT_TEXT;

	internal static MediaType ___003C_003EOPENSEARCH_DESCRIPTION_UTF_8;

	internal static MediaType ___003C_003EPDF;

	internal static MediaType ___003C_003EPOSTSCRIPT;

	internal static MediaType ___003C_003EPROTOBUF;

	internal static MediaType ___003C_003ERDF_XML_UTF_8;

	internal static MediaType ___003C_003ERTF_UTF_8;

	internal static MediaType ___003C_003ESFNT;

	internal static MediaType ___003C_003ESHOCKWAVE_FLASH;

	internal static MediaType ___003C_003ESKETCHUP;

	internal static MediaType ___003C_003ESOAP_XML_UTF_8;

	internal static MediaType ___003C_003ETAR;

	internal static MediaType ___003C_003EWOFF;

	internal static MediaType ___003C_003EWOFF2;

	internal static MediaType ___003C_003EXHTML_UTF_8;

	internal static MediaType ___003C_003EXRD_UTF_8;

	internal static MediaType ___003C_003EZIP;

	internal static MediaType ___003C_003EFONT_COLLECTION;

	internal static MediaType ___003C_003EFONT_OTF;

	internal static MediaType ___003C_003EFONT_SFNT;

	internal static MediaType ___003C_003EFONT_TTF;

	internal static MediaType ___003C_003EFONT_WOFF;

	internal static MediaType ___003C_003EFONT_WOFF2;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string m_type;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string m_subtype;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableListMultimap<Ljava/lang/String;Ljava/lang/String;>;")]
	private ImmutableListMultimap m_parameters;

	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new string m_toString;

	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	private new int m_hashCode;

	[Signature("Lcom/google/common/base/Optional<Ljava/nio/charset/Charset;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private com.google.common.@base.Optional parsedCharset;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Joiner.MapJoiner PARAMETER_JOINER;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ANY_TYPE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EANY_TYPE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ANY_TEXT_TYPE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EANY_TEXT_TYPE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ANY_IMAGE_TYPE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EANY_IMAGE_TYPE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ANY_AUDIO_TYPE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EANY_AUDIO_TYPE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ANY_VIDEO_TYPE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EANY_VIDEO_TYPE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ANY_APPLICATION_TYPE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EANY_APPLICATION_TYPE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ANY_FONT_TYPE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EANY_FONT_TYPE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType CACHE_MANIFEST_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECACHE_MANIFEST_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType CSS_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECSS_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType CSV_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECSV_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType HTML_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EHTML_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType I_CALENDAR_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EI_CALENDAR_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType PLAIN_TEXT_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPLAIN_TEXT_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType TEXT_JAVASCRIPT_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETEXT_JAVASCRIPT_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType TSV_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETSV_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType VCARD_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EVCARD_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WML_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWML_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType XML_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EXML_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType VTT_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EVTT_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType BMP
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBMP;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType CRW
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECRW;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType GIF
	{
		[HideFromJava]
		get
		{
			return ___003C_003EGIF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ICO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EICO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType JPEG
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJPEG;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType PNG
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPNG;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType PSD
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPSD;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType SVG_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESVG_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType TIFF
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETIFF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WEBP
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWEBP;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType HEIF
	{
		[HideFromJava]
		get
		{
			return ___003C_003EHEIF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType JP2K
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJP2K;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MP4_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMP4_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MPEG_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMPEG_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OGG_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOGG_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WEBM_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWEBM_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType L16_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EL16_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType L24_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EL24_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType BASIC_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBASIC_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType AAC_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EAAC_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType VORBIS_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EVORBIS_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WMA_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWMA_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WAX_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWAX_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType VND_REAL_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EVND_REAL_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType VND_WAVE_AUDIO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EVND_WAVE_AUDIO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MP4_VIDEO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMP4_VIDEO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MPEG_VIDEO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMPEG_VIDEO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OGG_VIDEO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOGG_VIDEO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType QUICKTIME
	{
		[HideFromJava]
		get
		{
			return ___003C_003EQUICKTIME;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WEBM_VIDEO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWEBM_VIDEO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WMV
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWMV;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType FLV_VIDEO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFLV_VIDEO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType THREE_GPP_VIDEO
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETHREE_GPP_VIDEO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType THREE_GPP2_VIDEO
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETHREE_GPP2_VIDEO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType APPLICATION_XML_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EAPPLICATION_XML_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ATOM_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EATOM_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType BZIP2
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBZIP2;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType DART_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EDART_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType APPLE_PASSBOOK
	{
		[HideFromJava]
		get
		{
			return ___003C_003EAPPLE_PASSBOOK;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType EOT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EEOT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType EPUB
	{
		[HideFromJava]
		get
		{
			return ___003C_003EEPUB;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType FORM_DATA
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFORM_DATA;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType KEY_ARCHIVE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EKEY_ARCHIVE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType APPLICATION_BINARY
	{
		[HideFromJava]
		get
		{
			return ___003C_003EAPPLICATION_BINARY;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType GEO_JSON
	{
		[HideFromJava]
		get
		{
			return ___003C_003EGEO_JSON;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType GZIP
	{
		[HideFromJava]
		get
		{
			return ___003C_003EGZIP;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType HAL_JSON
	{
		[HideFromJava]
		get
		{
			return ___003C_003EHAL_JSON;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType JAVASCRIPT_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJAVASCRIPT_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType JOSE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJOSE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType JOSE_JSON
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJOSE_JSON;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType JSON_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EJSON_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MANIFEST_JSON_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMANIFEST_JSON_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType KML
	{
		[HideFromJava]
		get
		{
			return ___003C_003EKML;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType KMZ
	{
		[HideFromJava]
		get
		{
			return ___003C_003EKMZ;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MBOX
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMBOX;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType APPLE_MOBILE_CONFIG
	{
		[HideFromJava]
		get
		{
			return ___003C_003EAPPLE_MOBILE_CONFIG;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MICROSOFT_EXCEL
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMICROSOFT_EXCEL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MICROSOFT_OUTLOOK
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMICROSOFT_OUTLOOK;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MICROSOFT_POWERPOINT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMICROSOFT_POWERPOINT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MICROSOFT_WORD
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMICROSOFT_WORD;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType MEDIA_PRESENTATION_DESCRIPTION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMEDIA_PRESENTATION_DESCRIPTION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WASM_APPLICATION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWASM_APPLICATION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType NACL_APPLICATION
	{
		[HideFromJava]
		get
		{
			return ___003C_003ENACL_APPLICATION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType NACL_PORTABLE_APPLICATION
	{
		[HideFromJava]
		get
		{
			return ___003C_003ENACL_PORTABLE_APPLICATION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OCTET_STREAM
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOCTET_STREAM;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OGG_CONTAINER
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOGG_CONTAINER;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OOXML_DOCUMENT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOOXML_DOCUMENT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OOXML_PRESENTATION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOOXML_PRESENTATION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OOXML_SHEET
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOOXML_SHEET;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OPENDOCUMENT_GRAPHICS
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOPENDOCUMENT_GRAPHICS;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OPENDOCUMENT_PRESENTATION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOPENDOCUMENT_PRESENTATION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OPENDOCUMENT_SPREADSHEET
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOPENDOCUMENT_SPREADSHEET;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OPENDOCUMENT_TEXT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOPENDOCUMENT_TEXT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType OPENSEARCH_DESCRIPTION_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOPENSEARCH_DESCRIPTION_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType PDF
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPDF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType POSTSCRIPT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPOSTSCRIPT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType PROTOBUF
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPROTOBUF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType RDF_XML_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ERDF_XML_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType RTF_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ERTF_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType SFNT
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESFNT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType SHOCKWAVE_FLASH
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESHOCKWAVE_FLASH;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType SKETCHUP
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESKETCHUP;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType SOAP_XML_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESOAP_XML_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType TAR
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETAR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WOFF
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWOFF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType WOFF2
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWOFF2;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType XHTML_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EXHTML_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType XRD_UTF_8
	{
		[HideFromJava]
		get
		{
			return ___003C_003EXRD_UTF_8;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType ZIP
	{
		[HideFromJava]
		get
		{
			return ___003C_003EZIP;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType FONT_COLLECTION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFONT_COLLECTION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType FONT_OTF
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFONT_OTF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType FONT_SFNT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFONT_SFNT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType FONT_TTF
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFONT_TTF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType FONT_WOFF
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFONT_WOFF;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static MediaType FONT_WOFF2
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFONT_WOFF2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;Ljava/lang/String;Lcom/google/common/collect/ImmutableListMultimap<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 162, 144, 104, 103, 103, 103 })]
	private MediaType(string P_0, string P_1, ImmutableListMultimap P_2)
	{
		this.m_type = P_0;
		this.m_subtype = P_1;
		this.m_parameters = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 72, 109 })]
	private static MediaType addKnownType(MediaType P_0)
	{
		KNOWN_TYPES.put(P_0, P_0);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 64, 109, 107 })]
	public static MediaType create(string type, string subtype)
	{
		MediaType mediaType = create(type, subtype, ImmutableListMultimap.of());
		mediaType.parsedCharset = com.google.common.@base.Optional.absent();
		return mediaType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;Ljava/lang/String;Lcom/google/common/collect/Multimap<Ljava/lang/String;Ljava/lang/String;>;)Lcom/google/common/net/MediaType;")]
	[LineNumberTable(new byte[]
	{
		163, 71, 103, 103, 103, 103, 103, 102, 61, 165,
		102, 127, 2, 115, 124, 98, 143
	})]
	private static MediaType create(string P_0, string P_1, Multimap P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		string text = normalizeToken(P_0);
		string text2 = normalizeToken(P_1);
		Preconditions.checkArgument((!String.instancehelper_equals("*", text) || String.instancehelper_equals("*", text2)) ? true : false, (object)"A wildcard type cannot be used with a non-wildcard subtype");
		ImmutableListMultimap.Builder builder = ImmutableListMultimap.builder();
		Iterator iterator = P_2.entries().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			string text3 = normalizeToken((string)entry.getKey());
			builder.put(text3, normalizeParameterValue(text3, (string)entry.getValue()));
		}
		MediaType mediaType = new MediaType(text, text2, builder.build());
		return (MediaType)MoreObjects.firstNonNull((MediaType)KNOWN_TYPES.get(mediaType), mediaType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 144, 127, 1, 113 })]
	private static string normalizeToken(string P_0)
	{
		CharMatcher tOKEN_MATCHER = TOKEN_MATCHER;
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = P_0);
		Preconditions.checkArgument(tOKEN_MATCHER.matchesAllOf(sequence));
		Preconditions.checkArgument((!String.instancehelper_isEmpty(P_0)) ? true : false);
		string result = Ascii.toLowerCase(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 150, 103, 127, 7 })]
	private static string normalizeParameterValue(string P_0, string P_1)
	{
		Preconditions.checkNotNull(P_1);
		CharMatcher charMatcher = CharMatcher.ascii();
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = P_1);
		Preconditions.checkArgument(charMatcher.matchesAllOf(sequence), "parameter values must be ASCII: %s", P_1);
		return (!String.instancehelper_equals("charset", P_0)) ? P_1 : Ascii.toLowerCase(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;Ljava/lang/Iterable<Ljava/lang/String;>;)Lcom/google/common/net/MediaType;")]
	[LineNumberTable(new byte[]
	{
		162, 222, 103, 103, 103, 102, 127, 6, 109, 106,
		148, 98, 127, 0, 112, 98, 153, 109, 173
	})]
	public virtual MediaType withParameters(string attribute, Iterable values)
	{
		Preconditions.checkNotNull(attribute);
		Preconditions.checkNotNull(values);
		string text = normalizeToken(attribute);
		ImmutableListMultimap.Builder builder = ImmutableListMultimap.builder();
		UnmodifiableIterator unmodifiableIterator = this.m_parameters.entries().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Map.Entry entry = (Map.Entry)((Iterator)unmodifiableIterator).next();
			string text2 = (string)entry.getKey();
			if (!String.instancehelper_equals(text, text2))
			{
				builder.put(text2, (string)entry.getValue());
			}
		}
		Iterator iterator = values.iterator();
		while (iterator.hasNext())
		{
			string text3 = (string)iterator.next();
			builder.put(text, normalizeParameterValue(text, text3));
		}
		MediaType mediaType = new MediaType(this.m_type, this.m_subtype, builder.build());
		if (!String.instancehelper_equals(text, "charset"))
		{
			mediaType.parsedCharset = parsedCharset;
		}
		return (MediaType)MoreObjects.firstNonNull((MediaType)KNOWN_TYPES.get(mediaType), mediaType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(879)]
	public virtual MediaType withParameter(string attribute, string value)
	{
		MediaType result = withParameters(attribute, ImmutableSet.of(value));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<Ljava/lang/String;Lcom/google/common/collect/ImmutableMultiset<Ljava/lang/String;>;>;")]
	[LineNumberTable(792)]
	private Map parametersAsMap()
	{
		Map result = Maps.transformValues(this.m_parameters.asMap(), new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 37, 127, 4, 109, 108, 112, 230, 70, 146 })]
	private string computeToString()
	{
		StringBuilder stringBuilder = new StringBuilder().append(this.m_type).append('/').append(this.m_subtype);
		if (!this.m_parameters.isEmpty())
		{
			stringBuilder.append("; ");
			ListMultimap listMultimap = Multimaps.transformValues(this.m_parameters, new ___003C_003EAnon1());
			PARAMETER_JOINER.appendTo(stringBuilder, listMultimap.entries());
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 53, 118, 107, 104, 111, 137, 232, 59, 230,
		71
	})]
	private static string escapeAndQuote(string P_0)
	{
		StringBuilder stringBuilder = new StringBuilder(String.instancehelper_length(P_0) + 16).append('"');
		for (int i = 0; i < String.instancehelper_length(P_0); i++)
		{
			int num = String.instancehelper_charAt(P_0, i);
			if (num == 13 || num == 92 || num == 34)
			{
				stringBuilder.append('\\');
			}
			stringBuilder.append((char)num);
		}
		string result = stringBuilder.append('"').toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 59, 98, 112, 107 })]
	private static MediaType createConstant(string P_0, string P_1)
	{
		MediaType mediaType = addKnownType(new MediaType(P_0, P_1, ImmutableListMultimap.of()));
		mediaType.parsedCharset = com.google.common.@base.Optional.absent();
		return mediaType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 66, 114, 112 })]
	private static MediaType createConstantUtf8(string P_0, string P_1)
	{
		MediaType mediaType = addKnownType(new MediaType(P_0, P_1, UTF_8_CONSTANT_PARAMETERS));
		mediaType.parsedCharset = com.google.common.@base.Optional.of(Charsets.___003C_003EUTF_8);
		return mediaType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 164, 44, 127, 6, 99, 8 })]
	private static string lambda_0024computeToString_00240(string P_0)
	{
		CharMatcher tOKEN_MATCHER = TOKEN_MATCHER;
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = P_0);
		string result = ((!tOKEN_MATCHER.matchesAllOf(sequence) || String.instancehelper_isEmpty(P_0)) ? escapeAndQuote(P_0) : P_0);
		_ = null;
		return result;
	}

	public virtual string type()
	{
		return this.m_type;
	}

	public virtual string subtype()
	{
		return this.m_subtype;
	}

	[Signature("()Lcom/google/common/collect/ImmutableListMultimap<Ljava/lang/String;Ljava/lang/String;>;")]
	public virtual ImmutableListMultimap parameters()
	{
		return this.m_parameters;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Optional<Ljava/nio/charset/Charset;>;")]
	[LineNumberTable(new byte[]
	{
		162, 179, 103, 102, 98, 102, 127, 14, 99, 98,
		113, 105, 191, 61, 101, 135
	})]
	public virtual com.google.common.@base.Optional charset()
	{
		com.google.common.@base.Optional optional = parsedCharset;
		if (optional == null)
		{
			string text = null;
			optional = com.google.common.@base.Optional.absent();
			UnmodifiableIterator unmodifiableIterator = this.m_parameters.get("charset").iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				string text2 = (string)((Iterator)unmodifiableIterator).next();
				if (text == null)
				{
					text = text2;
					optional = com.google.common.@base.Optional.of(Charset.forName(text));
				}
				else if (!String.instancehelper_equals(text, text2))
				{
					string text3 = text;
					int num = 35 + String.instancehelper_length(String.valueOf(text3)) + String.instancehelper_length(String.valueOf(text2));
					num = num;
					string s = new StringBuilder(num).append("Multiple charset values defined: ").append(text3).append(", ")
						.append(text2)
						.toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new IllegalStateException(s);
				}
			}
			parsedCharset = optional;
		}
		return optional;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(828)]
	public virtual MediaType withoutParameters()
	{
		MediaType result = ((!this.m_parameters.isEmpty()) ? create(this.m_type, this.m_subtype) : this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multimap<Ljava/lang/String;Ljava/lang/String;>;)Lcom/google/common/net/MediaType;")]
	[LineNumberTable(837)]
	public virtual MediaType withParameters(Multimap parameters)
	{
		MediaType result = create(this.m_type, this.m_subtype, parameters);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 10, 103, 146, 108 })]
	public virtual MediaType withCharset(Charset charset)
	{
		Preconditions.checkNotNull(charset);
		MediaType mediaType = withParameter("charset", charset.name());
		mediaType.parsedCharset = com.google.common.@base.Optional.of(charset);
		return mediaType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(901)]
	public virtual bool hasWildcard()
	{
		return (String.instancehelper_equals("*", this.m_type) || String.instancehelper_equals("*", this.m_subtype)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 52, 127, 17, 127, 1, 27 })]
	public virtual bool @is(MediaType mediaTypeRange)
	{
		return ((String.instancehelper_equals(mediaTypeRange.m_type, "*") || String.instancehelper_equals(mediaTypeRange.m_type, this.m_type)) && (String.instancehelper_equals(mediaTypeRange.m_subtype, "*") || String.instancehelper_equals(mediaTypeRange.m_subtype, this.m_subtype)) && this.m_parameters.entries().containsAll(mediaTypeRange.m_parameters.entries())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(977)]
	internal static MediaType createApplicationType(string P_0)
	{
		MediaType result = create("application", P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(986)]
	internal static MediaType createAudioType(string P_0)
	{
		MediaType result = create("audio", P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(995)]
	internal static MediaType createFontType(string P_0)
	{
		MediaType result = create("font", P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1004)]
	internal static MediaType createImageType(string P_0)
	{
		MediaType result = create("image", P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1013)]
	internal static MediaType createTextType(string P_0)
	{
		MediaType result = create("text", P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1022)]
	internal static MediaType createVideoType(string P_0)
	{
		MediaType result = create("video", P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 162, 103, 135, 108, 105, 108, 102, 107, 108,
		105, 108, 109, 137, 109, 105, 103, 106, 106, 105,
		149, 181, 105, 105, 98, 141, 107, 101, 127, 9,
		98
	})]
	public static MediaType parse(string input)
	{
		//Discarded unreachable code: IL_011b
		Preconditions.checkNotNull(input);
		Tokenizer tokenizer = new Tokenizer(input);
		IllegalStateException ex;
		try
		{
			string text = tokenizer.consumeToken(TOKEN_MATCHER);
			tokenizer.consumeCharacter('/');
			string text2 = tokenizer.consumeToken(TOKEN_MATCHER);
			ImmutableListMultimap.Builder builder = ImmutableListMultimap.builder();
			while (tokenizer.hasMore())
			{
				tokenizer.consumeTokenIfPresent(LINEAR_WHITE_SPACE);
				tokenizer.consumeCharacter(';');
				tokenizer.consumeTokenIfPresent(LINEAR_WHITE_SPACE);
				string key = tokenizer.consumeToken(TOKEN_MATCHER);
				tokenizer.consumeCharacter('=');
				string value;
				if ('"' == tokenizer.previewChar())
				{
					tokenizer.consumeCharacter('"');
					StringBuilder stringBuilder = new StringBuilder();
					while ('"' != tokenizer.previewChar())
					{
						if ('\\' == tokenizer.previewChar())
						{
							tokenizer.consumeCharacter('\\');
							stringBuilder.append(tokenizer.consumeCharacter(CharMatcher.ascii()));
						}
						else
						{
							stringBuilder.append(tokenizer.consumeToken(QUOTED_TEXT_MATCHER));
						}
					}
					value = stringBuilder.toString();
					tokenizer.consumeCharacter('"');
				}
				else
				{
					value = tokenizer.consumeToken(TOKEN_MATCHER);
				}
				builder.put(key, value);
			}
			return create(text, text2, builder.build());
		}
		catch (IllegalStateException x)
		{
			ex = ByteCodeHelper.MapException<IllegalStateException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IllegalStateException cause = ex;
		int num = 18 + String.instancehelper_length(String.valueOf(input));
		num = num;
		string message = new StringBuilder(num).append("Could not parse '").append(input).append("'")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(message, cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 251, 100, 98, 104, 103, 127, 0, 136, 246,
		61, 225, 69
	})]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is MediaType)
		{
			MediaType mediaType = (MediaType)obj;
			return (String.instancehelper_equals(this.m_type, mediaType.m_type) && String.instancehelper_equals(this.m_subtype, mediaType.m_subtype) && parametersAsMap().equals(mediaType.parametersAsMap())) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 11, 103, 99, 127, 8, 135 })]
	public override int hashCode()
	{
		int num = this.m_hashCode;
		if (num == 0)
		{
			num = (this.m_hashCode = com.google.common.@base.Objects.hashCode(this.m_type, this.m_subtype, parametersAsMap()));
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 28, 103, 99, 103, 135 })]
	public override string toString()
	{
		string text = this.m_toString;
		if (text == null)
		{
			text = (this.m_toString = computeToString());
		}
		return text;
	}

	[LineNumberTable(new byte[]
	{
		28,
		106,
		212,
		101,
		113,
		111,
		159,
		0,
		byte.MaxValue,
		10,
		70,
		byte.MaxValue,
		0,
		76,
		234,
		94,
		116,
		116,
		116,
		116,
		116,
		244,
		71,
		180,
		106,
		106,
		116,
		116,
		116,
		116,
		244,
		71,
		244,
		71,
		148,
		244,
		72,
		244,
		71,
		244,
		72,
		244,
		73,
		244,
		75,
		148,
		116,
		116,
		116,
		244,
		83,
		148,
		116,
		244,
		71,
		244,
		71,
		244,
		71,
		180,
		116,
		116,
		116,
		244,
		71,
		244,
		71,
		244,
		72,
		244,
		72,
		244,
		71,
		244,
		73,
		244,
		73,
		244,
		72,
		244,
		71,
		180,
		116,
		116,
		116,
		116,
		116,
		244,
		73,
		244,
		73,
		244,
		73,
		244,
		74,
		148,
		116,
		244,
		72,
		244,
		71,
		106,
		234,
		73,
		244,
		75,
		148,
		106,
		234,
		73,
		244,
		76,
		244,
		72,
		148,
		244,
		72,
		244,
		71,
		106,
		234,
		72,
		244,
		72,
		148,
		244,
		71,
		106,
		234,
		69,
		244,
		70,
		244,
		71,
		244,
		71,
		106,
		170,
		244,
		71,
		106,
		170,
		106,
		170,
		244,
		75,
		106,
		234,
		72,
		244,
		73,
		244,
		73,
		106,
		138,
		148,
		116,
		106,
		138,
		106,
		138,
		106,
		106,
		106,
		106,
		106,
		106,
		106,
		106,
		106,
		234,
		73,
		106,
		138,
		116,
		244,
		71,
		244,
		74,
		148,
		244,
		73,
		148,
		106,
		234,
		72,
		244,
		77,
		148,
		244,
		73,
		244,
		73,
		148,
		244,
		74,
		148,
		244,
		74,
		244,
		72,
		244,
		74,
		244,
		72,
		244,
		74,
		244,
		74,
		244,
		161,
		143
	})]
	static MediaType()
	{
		UTF_8_CONSTANT_PARAMETERS = ImmutableListMultimap.of("charset", Ascii.toLowerCase(Charsets.___003C_003EUTF_8.name()));
		CharMatcher charMatcher = CharMatcher.ascii().and(CharMatcher.javaIsoControl().negate()).and(CharMatcher.isNot(' '));
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = "()<>@,;:\\\"/[]?=");
		TOKEN_MATCHER = charMatcher.and(CharMatcher.noneOf(sequence));
		CharMatcher charMatcher2 = CharMatcher.ascii();
		obj = (sequence.___003Cref_003E = "\"\\\r");
		QUOTED_TEXT_MATCHER = charMatcher2.and(CharMatcher.noneOf(sequence));
		obj = (sequence.___003Cref_003E = " \t\r\n");
		LINEAR_WHITE_SPACE = CharMatcher.anyOf(sequence);
		KNOWN_TYPES = Maps.newHashMap();
		___003C_003EANY_TYPE = createConstant("*", "*");
		___003C_003EANY_TEXT_TYPE = createConstant("text", "*");
		___003C_003EANY_IMAGE_TYPE = createConstant("image", "*");
		___003C_003EANY_AUDIO_TYPE = createConstant("audio", "*");
		___003C_003EANY_VIDEO_TYPE = createConstant("video", "*");
		___003C_003EANY_APPLICATION_TYPE = createConstant("application", "*");
		___003C_003EANY_FONT_TYPE = createConstant("font", "*");
		___003C_003ECACHE_MANIFEST_UTF_8 = createConstantUtf8("text", "cache-manifest");
		___003C_003ECSS_UTF_8 = createConstantUtf8("text", "css");
		___003C_003ECSV_UTF_8 = createConstantUtf8("text", "csv");
		___003C_003EHTML_UTF_8 = createConstantUtf8("text", "html");
		___003C_003EI_CALENDAR_UTF_8 = createConstantUtf8("text", "calendar");
		___003C_003EPLAIN_TEXT_UTF_8 = createConstantUtf8("text", "plain");
		___003C_003ETEXT_JAVASCRIPT_UTF_8 = createConstantUtf8("text", "javascript");
		___003C_003ETSV_UTF_8 = createConstantUtf8("text", "tab-separated-values");
		___003C_003EVCARD_UTF_8 = createConstantUtf8("text", "vcard");
		___003C_003EWML_UTF_8 = createConstantUtf8("text", "vnd.wap.wml");
		___003C_003EXML_UTF_8 = createConstantUtf8("text", "xml");
		___003C_003EVTT_UTF_8 = createConstantUtf8("text", "vtt");
		___003C_003EBMP = createConstant("image", "bmp");
		___003C_003ECRW = createConstant("image", "x-canon-crw");
		___003C_003EGIF = createConstant("image", "gif");
		___003C_003EICO = createConstant("image", "vnd.microsoft.icon");
		___003C_003EJPEG = createConstant("image", "jpeg");
		___003C_003EPNG = createConstant("image", "png");
		___003C_003EPSD = createConstant("image", "vnd.adobe.photoshop");
		___003C_003ESVG_UTF_8 = createConstantUtf8("image", "svg+xml");
		___003C_003ETIFF = createConstant("image", "tiff");
		___003C_003EWEBP = createConstant("image", "webp");
		___003C_003EHEIF = createConstant("image", "heif");
		___003C_003EJP2K = createConstant("image", "jp2");
		___003C_003EMP4_AUDIO = createConstant("audio", "mp4");
		___003C_003EMPEG_AUDIO = createConstant("audio", "mpeg");
		___003C_003EOGG_AUDIO = createConstant("audio", "ogg");
		___003C_003EWEBM_AUDIO = createConstant("audio", "webm");
		___003C_003EL16_AUDIO = createConstant("audio", "l16");
		___003C_003EL24_AUDIO = createConstant("audio", "l24");
		___003C_003EBASIC_AUDIO = createConstant("audio", "basic");
		___003C_003EAAC_AUDIO = createConstant("audio", "aac");
		___003C_003EVORBIS_AUDIO = createConstant("audio", "vorbis");
		___003C_003EWMA_AUDIO = createConstant("audio", "x-ms-wma");
		___003C_003EWAX_AUDIO = createConstant("audio", "x-ms-wax");
		___003C_003EVND_REAL_AUDIO = createConstant("audio", "vnd.rn-realaudio");
		___003C_003EVND_WAVE_AUDIO = createConstant("audio", "vnd.wave");
		___003C_003EMP4_VIDEO = createConstant("video", "mp4");
		___003C_003EMPEG_VIDEO = createConstant("video", "mpeg");
		___003C_003EOGG_VIDEO = createConstant("video", "ogg");
		___003C_003EQUICKTIME = createConstant("video", "quicktime");
		___003C_003EWEBM_VIDEO = createConstant("video", "webm");
		___003C_003EWMV = createConstant("video", "x-ms-wmv");
		___003C_003EFLV_VIDEO = createConstant("video", "x-flv");
		___003C_003ETHREE_GPP_VIDEO = createConstant("video", "3gpp");
		___003C_003ETHREE_GPP2_VIDEO = createConstant("video", "3gpp2");
		___003C_003EAPPLICATION_XML_UTF_8 = createConstantUtf8("application", "xml");
		___003C_003EATOM_UTF_8 = createConstantUtf8("application", "atom+xml");
		___003C_003EBZIP2 = createConstant("application", "x-bzip2");
		___003C_003EDART_UTF_8 = createConstantUtf8("application", "dart");
		___003C_003EAPPLE_PASSBOOK = createConstant("application", "vnd.apple.pkpass");
		___003C_003EEOT = createConstant("application", "vnd.ms-fontobject");
		___003C_003EEPUB = createConstant("application", "epub+zip");
		___003C_003EFORM_DATA = createConstant("application", "x-www-form-urlencoded");
		___003C_003EKEY_ARCHIVE = createConstant("application", "pkcs12");
		___003C_003EAPPLICATION_BINARY = createConstant("application", "binary");
		___003C_003EGEO_JSON = createConstant("application", "geo+json");
		___003C_003EGZIP = createConstant("application", "x-gzip");
		___003C_003EHAL_JSON = createConstant("application", "hal+json");
		___003C_003EJAVASCRIPT_UTF_8 = createConstantUtf8("application", "javascript");
		___003C_003EJOSE = createConstant("application", "jose");
		___003C_003EJOSE_JSON = createConstant("application", "jose+json");
		___003C_003EJSON_UTF_8 = createConstantUtf8("application", "json");
		___003C_003EMANIFEST_JSON_UTF_8 = createConstantUtf8("application", "manifest+json");
		___003C_003EKML = createConstant("application", "vnd.google-earth.kml+xml");
		___003C_003EKMZ = createConstant("application", "vnd.google-earth.kmz");
		___003C_003EMBOX = createConstant("application", "mbox");
		___003C_003EAPPLE_MOBILE_CONFIG = createConstant("application", "x-apple-aspen-config");
		___003C_003EMICROSOFT_EXCEL = createConstant("application", "vnd.ms-excel");
		___003C_003EMICROSOFT_OUTLOOK = createConstant("application", "vnd.ms-outlook");
		___003C_003EMICROSOFT_POWERPOINT = createConstant("application", "vnd.ms-powerpoint");
		___003C_003EMICROSOFT_WORD = createConstant("application", "msword");
		___003C_003EMEDIA_PRESENTATION_DESCRIPTION = createConstant("application", "dash+xml");
		___003C_003EWASM_APPLICATION = createConstant("application", "wasm");
		___003C_003ENACL_APPLICATION = createConstant("application", "x-nacl");
		___003C_003ENACL_PORTABLE_APPLICATION = createConstant("application", "x-pnacl");
		___003C_003EOCTET_STREAM = createConstant("application", "octet-stream");
		___003C_003EOGG_CONTAINER = createConstant("application", "ogg");
		___003C_003EOOXML_DOCUMENT = createConstant("application", "vnd.openxmlformats-officedocument.wordprocessingml.document");
		___003C_003EOOXML_PRESENTATION = createConstant("application", "vnd.openxmlformats-officedocument.presentationml.presentation");
		___003C_003EOOXML_SHEET = createConstant("application", "vnd.openxmlformats-officedocument.spreadsheetml.sheet");
		___003C_003EOPENDOCUMENT_GRAPHICS = createConstant("application", "vnd.oasis.opendocument.graphics");
		___003C_003EOPENDOCUMENT_PRESENTATION = createConstant("application", "vnd.oasis.opendocument.presentation");
		___003C_003EOPENDOCUMENT_SPREADSHEET = createConstant("application", "vnd.oasis.opendocument.spreadsheet");
		___003C_003EOPENDOCUMENT_TEXT = createConstant("application", "vnd.oasis.opendocument.text");
		___003C_003EOPENSEARCH_DESCRIPTION_UTF_8 = createConstantUtf8("application", "opensearchdescription+xml");
		___003C_003EPDF = createConstant("application", "pdf");
		___003C_003EPOSTSCRIPT = createConstant("application", "postscript");
		___003C_003EPROTOBUF = createConstant("application", "protobuf");
		___003C_003ERDF_XML_UTF_8 = createConstantUtf8("application", "rdf+xml");
		___003C_003ERTF_UTF_8 = createConstantUtf8("application", "rtf");
		___003C_003ESFNT = createConstant("application", "font-sfnt");
		___003C_003ESHOCKWAVE_FLASH = createConstant("application", "x-shockwave-flash");
		___003C_003ESKETCHUP = createConstant("application", "vnd.sketchup.skp");
		___003C_003ESOAP_XML_UTF_8 = createConstantUtf8("application", "soap+xml");
		___003C_003ETAR = createConstant("application", "x-tar");
		___003C_003EWOFF = createConstant("application", "font-woff");
		___003C_003EWOFF2 = createConstant("application", "font-woff2");
		___003C_003EXHTML_UTF_8 = createConstantUtf8("application", "xhtml+xml");
		___003C_003EXRD_UTF_8 = createConstantUtf8("application", "xrd+xml");
		___003C_003EZIP = createConstant("application", "zip");
		___003C_003EFONT_COLLECTION = createConstant("font", "collection");
		___003C_003EFONT_OTF = createConstant("font", "otf");
		___003C_003EFONT_SFNT = createConstant("font", "sfnt");
		___003C_003EFONT_TTF = createConstant("font", "ttf");
		___003C_003EFONT_WOFF = createConstant("font", "woff");
		___003C_003EFONT_WOFF2 = createConstant("font", "woff2");
		PARAMETER_JOINER = Joiner.on("; ").withKeyValueSeparator("=");
	}
}
