using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace javax.json.stream;

public sealed class JsonCollectors : Object
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : Supplier
	{
		internal ___003C_003EAnon0()
		{
		}

		public object get()
		{
			JsonArrayBuilder result = Json.createArrayBuilder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : BiConsumer
	{
		internal ___003C_003EAnon1()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((JsonArrayBuilder)P_0).add((JsonValue)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BinaryOperator
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0, object P_1)
		{
			JsonArrayBuilder result = ((JsonArrayBuilder)P_0).addAll((JsonArrayBuilder)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			JsonArray result = ((JsonArrayBuilder)P_0).build();
			_ = null;
			return result;
		}

		[SpecialName]
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : Supplier
	{
		internal ___003C_003EAnon4()
		{
		}

		public object get()
		{
			JsonObjectBuilder result = Json.createObjectBuilder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon5 : BiConsumer
	{
		internal ___003C_003EAnon5()
		{
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toJsonObject_00240((JsonObjectBuilder)P_0, (Map.Entry)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon6 : BinaryOperator
	{
		internal ___003C_003EAnon6()
		{
		}

		public object apply(object P_0, object P_1)
		{
			JsonObjectBuilder result = ((JsonObjectBuilder)P_0).addAll((JsonObjectBuilder)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon7 : Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			JsonObject result = ((JsonObjectBuilder)P_0).build();
			_ = null;
			return result;
		}

		[SpecialName]
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon8 : BiConsumer
	{
		private readonly Function arg_00241;

		private readonly Function arg_00242;

		internal ___003C_003EAnon8(Function P_0, Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toJsonObject_00241(arg_00241, arg_00242, (JsonObjectBuilder)P_0, (JsonValue)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon9 : BiConsumer
	{
		private readonly Function arg_00241;

		private readonly Collector arg_00242;

		internal ___003C_003EAnon9(Function P_0, Collector P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024groupingBy_00243(arg_00241, arg_00242, (Map)P_0, (JsonValue)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon10 : Function
	{
		private readonly Collector arg_00241;

		internal ___003C_003EAnon10(Collector P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JsonObject result = lambda_0024groupingBy_00245(arg_00241, (Map)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon11 : BinaryOperator
	{
		internal ___003C_003EAnon11()
		{
		}

		public object apply(object P_0, object P_1)
		{
			Map result = lambda_0024groupingBy_00246((Map)P_0, (Map)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon12 : Supplier
	{
		internal ___003C_003EAnon12()
		{
		}

		public object get()
		{
			Map result = new HashMap();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon13 : BiConsumer
	{
		private readonly Collector arg_00241;

		private readonly JsonObjectBuilder arg_00242;

		internal ___003C_003EAnon13(Collector P_0, JsonObjectBuilder P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024groupingBy_00244(arg_00241, arg_00242, (string)P_0, (JsonArrayBuilder)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon14 : Function
	{
		private readonly Collector arg_00241;

		internal ___003C_003EAnon14(Collector P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			JsonArrayBuilder result = lambda_0024groupingBy_00242(arg_00241, (string)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/stream/Collector<Ljavax/json/JsonValue;Ljavax/json/JsonArrayBuilder;Ljavax/json/JsonArray;>;")]
	[LineNumberTable(77)]
	public static Collector toJsonArray()
	{
		Collector result = Collector.of(new ___003C_003EAnon0(), new ___003C_003EAnon1(), new ___003C_003EAnon2(), new ___003C_003EAnon3());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T::Ljavax/json/JsonArrayBuilder;>(Ljava/util/function/Function<Ljavax/json/JsonValue;Ljava/lang/String;>;Ljava/util/stream/Collector<Ljavax/json/JsonValue;TT;Ljavax/json/JsonArray;>;)Ljava/util/stream/Collector<Ljavax/json/JsonValue;Ljava/util/Map<Ljava/lang/String;TT;>;Ljavax/json/JsonObject;>;")]
	[LineNumberTable(new byte[] { 86, 237, 76, 236, 76, 235, 69 })]
	public static Collector groupingBy(Function classifier, Collector downstream)
	{
		BiConsumer accumulator = new ___003C_003EAnon9(classifier, downstream);
		Function finisher = new ___003C_003EAnon10(downstream);
		BinaryOperator combiner = new ___003C_003EAnon11();
		Collector result = Collector.of(new ___003C_003EAnon12(), accumulator, combiner, finisher, Collector.Characteristics.UNORDERED);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(93)]
	private static void lambda_0024toJsonObject_00240(JsonObjectBuilder P_0, Map.Entry P_1)
	{
		P_0.add((string)P_1.getKey(), (JsonValue)P_1.getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(112)]
	private static void lambda_0024toJsonObject_00241(Function P_0, Function P_1, JsonObjectBuilder P_2, JsonValue P_3)
	{
		P_2.add((string)P_0.apply(P_3), (JsonValue)P_1.apply(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 88, 109, 99, 176, 109, 139, 111 })]
	private static void lambda_0024groupingBy_00243(Function P_0, Collector P_1, Map P_2, JsonValue P_3)
	{
		string text = (string)P_0.apply(P_3);
		if (text == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new JsonException("element cannot be mapped to a null key");
		}
		JsonArrayBuilder t = (JsonArrayBuilder)P_2.computeIfAbsent(text, new ___003C_003EAnon14(P_1));
		P_1.accumulator().accept(t, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 103, 102, 210 })]
	private static JsonObject lambda_0024groupingBy_00245(Collector P_0, Map P_1)
	{
		JsonObjectBuilder jsonObjectBuilder = Json.createObjectBuilder();
		P_1.forEach(new ___003C_003EAnon13(P_0, jsonObjectBuilder));
		JsonObject result = jsonObjectBuilder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 112, 103 })]
	private static Map lambda_0024groupingBy_00246(Map P_0, Map P_1)
	{
		P_0.putAll(P_1);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 105, 114, 105 })]
	private static void lambda_0024groupingBy_00244(Collector P_0, JsonObjectBuilder P_1, string P_2, JsonArrayBuilder P_3)
	{
		JsonArray jv = (JsonArray)P_0.finisher().apply(P_3);
		P_1.add(P_2, jv);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(144)]
	private static JsonArrayBuilder lambda_0024groupingBy_00242(Collector P_0, string P_1)
	{
		return (JsonArrayBuilder)P_0.supplier().get();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 17, 104 })]
	private JsonCollectors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/stream/Collector<Ljava/util/Map$Entry<Ljava/lang/String;Ljavax/json/JsonValue;>;Ljavax/json/JsonObjectBuilder;Ljavax/json/JsonObject;>;")]
	[LineNumberTable(91)]
	public static Collector toJsonObject()
	{
		Collector result = Collector.of(new ___003C_003EAnon4(), new ___003C_003EAnon5(), new ___003C_003EAnon6(), new ___003C_003EAnon7());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Function<Ljavax/json/JsonValue;Ljava/lang/String;>;Ljava/util/function/Function<Ljavax/json/JsonValue;Ljavax/json/JsonValue;>;)Ljava/util/stream/Collector<Ljavax/json/JsonValue;Ljavax/json/JsonObjectBuilder;Ljavax/json/JsonObject;>;")]
	[LineNumberTable(110)]
	public static Collector toJsonObject(Function keyMapper, Function valueMapper)
	{
		Collector result = Collector.of(new ___003C_003EAnon4(), new ___003C_003EAnon8(keyMapper, valueMapper), new ___003C_003EAnon6(), new ___003C_003EAnon7(), Collector.Characteristics.UNORDERED);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Function<Ljavax/json/JsonValue;Ljava/lang/String;>;)Ljava/util/stream/Collector<Ljavax/json/JsonValue;Ljava/util/Map<Ljava/lang/String;Ljavax/json/JsonArrayBuilder;>;Ljavax/json/JsonObject;>;")]
	[LineNumberTable(181)]
	public static Collector groupingBy(Function classifier)
	{
		Collector result = groupingBy(classifier, toJsonArray());
		_ = null;
		return result;
	}
}
