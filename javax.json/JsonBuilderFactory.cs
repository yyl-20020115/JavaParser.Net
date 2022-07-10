using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace javax.json;

public interface JsonBuilderFactory
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static JsonObjectBuilder createObjectBuilder(JsonBuilderFactory P_0, JsonObject P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EcreateObjectBuilder(P_0, P_1);
		}

		public unsafe static JsonObjectBuilder createObjectBuilder(JsonBuilderFactory P_0, Map P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EcreateObjectBuilder(P_0, P_1);
		}

		public unsafe static JsonArrayBuilder createArrayBuilder(JsonBuilderFactory P_0, JsonArray P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EcreateArrayBuilder(P_0, P_1);
		}

		public unsafe static JsonArrayBuilder createArrayBuilder(JsonBuilderFactory P_0, Collection P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EcreateArrayBuilder(P_0, P_1);
		}
	}

	virtual JsonObjectBuilder createObjectBuilder();

	[Modifiers(Modifiers.Public)]
	virtual JsonObjectBuilder createObjectBuilder(JsonObject @object);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(95)]
	static JsonObjectBuilder _003Cdefault_003EcreateObjectBuilder(JsonBuilderFactory P_0, JsonObject P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/Object;>;)Ljavax/json/JsonObjectBuilder;")]
	virtual JsonObjectBuilder createObjectBuilder(Map @object);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(108)]
	static JsonObjectBuilder _003Cdefault_003EcreateObjectBuilder(JsonBuilderFactory P_0, Map P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	virtual JsonArrayBuilder createArrayBuilder();

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder createArrayBuilder(JsonArray array);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(129)]
	static JsonArrayBuilder _003Cdefault_003EcreateArrayBuilder(JsonBuilderFactory P_0, JsonArray P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/util/Collection<*>;)Ljavax/json/JsonArrayBuilder;")]
	virtual JsonArrayBuilder createArrayBuilder(Collection collection);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(143)]
	static JsonArrayBuilder _003Cdefault_003EcreateArrayBuilder(JsonBuilderFactory P_0, Collection P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Signature("()Ljava/util/Map<Ljava/lang/String;*>;")]
	virtual Map getConfigInUse();
}
