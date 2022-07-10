using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.math;
using java.util;
using javax.json.spi;
using javax.json.stream;

namespace javax.json;

public sealed class Json : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(346)]
	public static JsonPointer createPointer(string jsonPointer)
	{
		JsonPointer result = JsonProvider.provider().createPointer(jsonPointer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 35, 104 })]
	private Json()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(95)]
	public static JsonParser createParser(Reader reader)
	{
		JsonParser result = JsonProvider.provider().createParser(reader);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(109)]
	public static JsonParser createParser(InputStream @in)
	{
		JsonParser result = JsonProvider.provider().createParser(@in);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(119)]
	public static JsonGenerator createGenerator(Writer writer)
	{
		JsonGenerator result = JsonProvider.provider().createGenerator(writer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(129)]
	public static JsonGenerator createGenerator(OutputStream @out)
	{
		JsonGenerator result = JsonProvider.provider().createGenerator(@out);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/stream/JsonParserFactory;")]
	[LineNumberTable(153)]
	public static JsonParserFactory createParserFactory(Map config)
	{
		JsonParserFactory result = JsonProvider.provider().createParserFactory(config);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/stream/JsonGeneratorFactory;")]
	[LineNumberTable(178)]
	public static JsonGeneratorFactory createGeneratorFactory(Map config)
	{
		JsonGeneratorFactory result = JsonProvider.provider().createGeneratorFactory(config);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(190)]
	public static JsonWriter createWriter(Writer writer)
	{
		JsonWriter result = JsonProvider.provider().createWriter(writer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(203)]
	public static JsonWriter createWriter(OutputStream @out)
	{
		JsonWriter result = JsonProvider.provider().createWriter(@out);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(213)]
	public static JsonReader createReader(Reader reader)
	{
		JsonReader result = JsonProvider.provider().createReader(reader);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(225)]
	public static JsonReader createReader(InputStream @in)
	{
		JsonReader result = JsonProvider.provider().createReader(@in);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/JsonReaderFactory;")]
	[LineNumberTable(239)]
	public static JsonReaderFactory createReaderFactory(Map config)
	{
		JsonReaderFactory result = JsonProvider.provider().createReaderFactory(config);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/JsonWriterFactory;")]
	[LineNumberTable(253)]
	public static JsonWriterFactory createWriterFactory(Map config)
	{
		JsonWriterFactory result = JsonProvider.provider().createWriterFactory(config);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(262)]
	public static JsonArrayBuilder createArrayBuilder()
	{
		JsonArrayBuilder result = JsonProvider.provider().createArrayBuilder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(274)]
	public static JsonArrayBuilder createArrayBuilder(JsonArray array)
	{
		JsonArrayBuilder result = JsonProvider.provider().createArrayBuilder(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Ljavax/json/JsonArrayBuilder;")]
	[LineNumberTable(290)]
	public static JsonArrayBuilder createArrayBuilder(Collection collection)
	{
		JsonArrayBuilder result = JsonProvider.provider().createArrayBuilder(collection);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(299)]
	public static JsonObjectBuilder createObjectBuilder()
	{
		JsonObjectBuilder result = JsonProvider.provider().createObjectBuilder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(311)]
	public static JsonObjectBuilder createObjectBuilder(JsonObject @object)
	{
		JsonObjectBuilder result = JsonProvider.provider().createObjectBuilder(@object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Object;>;)Ljavax/json/JsonObjectBuilder;")]
	[LineNumberTable(327)]
	public static JsonObjectBuilder createObjectBuilder(Map map)
	{
		JsonObjectBuilder result = JsonProvider.provider().createObjectBuilder(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(357)]
	public static JsonPatchBuilder createPatchBuilder()
	{
		JsonPatchBuilder result = JsonProvider.provider().createPatchBuilder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(371)]
	public static JsonPatchBuilder createPatchBuilder(JsonArray array)
	{
		JsonPatchBuilder result = JsonProvider.provider().createPatchBuilder(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(384)]
	public static JsonPatch createPatch(JsonArray array)
	{
		JsonPatch result = JsonProvider.provider().createPatch(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(399)]
	public static JsonPatch createDiff(JsonStructure source, JsonStructure target)
	{
		JsonPatch result = JsonProvider.provider().createDiff(source, target);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(412)]
	public static JsonMergePatch createMergePatch(JsonValue patch)
	{
		JsonMergePatch result = JsonProvider.provider().createMergePatch(patch);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(427)]
	public static JsonMergePatch createMergeDiff(JsonValue source, JsonValue target)
	{
		JsonMergePatch result = JsonProvider.provider().createMergeDiff(source, target);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/JsonBuilderFactory;")]
	[LineNumberTable(443)]
	public static JsonBuilderFactory createBuilderFactory(Map config)
	{
		JsonBuilderFactory result = JsonProvider.provider().createBuilderFactory(config);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(455)]
	public static JsonString createValue(string value)
	{
		JsonString result = JsonProvider.provider().createValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(467)]
	public static JsonNumber createValue(int value)
	{
		JsonNumber result = JsonProvider.provider().createValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(479)]
	public static JsonNumber createValue(long value)
	{
		JsonNumber result = JsonProvider.provider().createValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(491)]
	public static JsonNumber createValue(double value)
	{
		JsonNumber result = JsonProvider.provider().createValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(503)]
	public static JsonNumber createValue(BigDecimal value)
	{
		JsonNumber result = JsonProvider.provider().createValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(515)]
	public static JsonNumber createValue(BigInteger value)
	{
		JsonNumber result = JsonProvider.provider().createValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(528)]
	public static string encodePointer(string pointer)
	{
		object __003Cref_003E = "~0";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = "~");
		CharSequence target = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string @this = String.instancehelper_replace(pointer, target, charSequence);
		obj = "~1";
		__003Cref_003E = (charSequence.___003Cref_003E = "/");
		CharSequence target2 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		string result = String.instancehelper_replace(@this, target2, charSequence);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(541)]
	public static string decodePointer(string escaped)
	{
		object __003Cref_003E = "/";
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = "~1");
		CharSequence target = charSequence;
		obj = (charSequence.___003Cref_003E = __003Cref_003E);
		string @this = String.instancehelper_replace(escaped, target, charSequence);
		obj = "~";
		__003Cref_003E = (charSequence.___003Cref_003E = "~0");
		CharSequence target2 = charSequence;
		__003Cref_003E = (charSequence.___003Cref_003E = obj);
		string result = String.instancehelper_replace(@this, target2, charSequence);
		_ = null;
		return result;
	}
}
