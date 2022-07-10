using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.math;
using java.util;
using javax.json.stream;

namespace javax.json.spi;

public abstract class JsonProvider : java.lang.Object
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const string DEFAULT_PROVIDER = "org.glassfish.json.JsonProviderImpl";

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		40, 107, 103, 104, 172, 112, 127, 28, 98, 146,
		98
	})]
	public static JsonProvider provider()
	{
		//Discarded unreachable code: IL_0048
		ServiceLoader serviceLoader = ServiceLoader.load(ClassLiteral<JsonProvider>.Value);
		Iterator iterator = serviceLoader.iterator();
		if (iterator.hasNext())
		{
			return (JsonProvider)iterator.next();
		}
		java.lang.ClassNotFoundException ex;
		java.lang.Exception ex3;
		try
		{
			try
			{
				Class @class = Class.forName("org.glassfish.json.JsonProviderImpl", JsonProvider.___003CGetCallerID_003E());
				return (JsonProvider)@class.newInstance(JsonProvider.___003CGetCallerID_003E());
			}
			catch (java.lang.ClassNotFoundException x)
			{
				ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (System.Exception x2)
		{
			java.lang.Exception ex2 = ByteCodeHelper.MapException<java.lang.Exception>(x2, ByteCodeHelper.MapFlags.None);
			if (ex2 == null)
			{
				throw;
			}
			ex3 = ex2;
			goto IL_006c;
		}
		java.lang.ClassNotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new JsonException("Provider org.glassfish.json.JsonProviderImpl not found", cause);
		IL_006c:
		java.lang.Exception ex4 = ex3;
		string message = new StringBuilder().append("Provider org.glassfish.json.JsonProviderImpl could not be instantiated: ").append(ex4).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new JsonException(message, ex4);
	}

	public abstract JsonParser createParser(Reader r);

	public abstract JsonParser createParser(InputStream @is);

	public abstract JsonGenerator createGenerator(Writer w);

	public abstract JsonGenerator createGenerator(OutputStream os);

	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/stream/JsonParserFactory;")]
	public abstract JsonParserFactory createParserFactory(Map m);

	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/stream/JsonGeneratorFactory;")]
	public abstract JsonGeneratorFactory createGeneratorFactory(Map m);

	public abstract JsonWriter createWriter(Writer w);

	public abstract JsonWriter createWriter(OutputStream os);

	public abstract JsonReader createReader(Reader r);

	public abstract JsonReader createReader(InputStream @is);

	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/JsonReaderFactory;")]
	public abstract JsonReaderFactory createReaderFactory(Map m);

	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/JsonWriterFactory;")]
	public abstract JsonWriterFactory createWriterFactory(Map m);

	public abstract JsonArrayBuilder createArrayBuilder();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(300)]
	public virtual JsonArrayBuilder createArrayBuilder(JsonArray array)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Ljavax/json/JsonArrayBuilder;")]
	[LineNumberTable(416)]
	public virtual JsonArrayBuilder createArrayBuilder(Collection collection)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	public abstract JsonObjectBuilder createObjectBuilder();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(265)]
	public virtual JsonObjectBuilder createObjectBuilder(JsonObject @object)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Object;>;)Ljavax/json/JsonObjectBuilder;")]
	[LineNumberTable(281)]
	public virtual JsonObjectBuilder createObjectBuilder(Map map)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(319)]
	public virtual JsonPointer createPointer(string jsonPointer)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(330)]
	public virtual JsonPatchBuilder createPatchBuilder()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(344)]
	public virtual JsonPatchBuilder createPatchBuilder(JsonArray array)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(357)]
	public virtual JsonPatch createPatch(JsonArray array)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(372)]
	public virtual JsonPatch createDiff(JsonStructure source, JsonStructure target)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(385)]
	public virtual JsonMergePatch createMergePatch(JsonValue patch)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(400)]
	public virtual JsonMergePatch createMergeDiff(JsonValue source, JsonValue target)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Signature("(Ljava/util/Map<Ljava/lang/String;*>;)Ljavax/json/JsonBuilderFactory;")]
	public abstract JsonBuilderFactory createBuilderFactory(Map m);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(442)]
	public virtual JsonString createValue(string value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(454)]
	public virtual JsonNumber createValue(int value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(466)]
	public virtual JsonNumber createValue(long value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(478)]
	public virtual JsonNumber createValue(double value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(490)]
	public virtual JsonNumber createValue(BigDecimal value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(502)]
	public virtual JsonNumber createValue(BigInteger value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 27, 104 })]
	protected internal JsonProvider()
	{
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
