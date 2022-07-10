using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.math;

namespace javax.json;

public interface JsonArrayBuilder
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static JsonArrayBuilder addAll(JsonArrayBuilder P_0, JsonArrayBuilder P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EaddAll(P_0, P_1);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, JsonValue P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, string P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, BigDecimal P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, BigInteger P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, int P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, long P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, double P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, bool P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder addNull(JsonArrayBuilder P_0, int P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EaddNull(P_0, P_1);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, JsonObjectBuilder P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder add(JsonArrayBuilder P_0, int P_1, JsonArrayBuilder P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eadd(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, JsonValue P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, string P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, BigDecimal P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, BigInteger P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, int P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, long P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, double P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, bool P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder setNull(JsonArrayBuilder P_0, int P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EsetNull(P_0, P_1);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, JsonObjectBuilder P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder set(JsonArrayBuilder P_0, int P_1, JsonArrayBuilder P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eset(P_0, P_1, P_2);
		}

		public unsafe static JsonArrayBuilder remove(JsonArrayBuilder P_0, int P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eremove(P_0, P_1);
		}
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, JsonValue value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(238)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, JsonValue P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, JsonValue value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(442)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, JsonValue P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	virtual JsonArrayBuilder add(JsonValue jv);

	virtual JsonArrayBuilder add(string str);

	virtual JsonArrayBuilder add(BigDecimal bd);

	virtual JsonArrayBuilder add(BigInteger bi);

	virtual JsonArrayBuilder add(int i);

	virtual JsonArrayBuilder add(long l);

	virtual JsonArrayBuilder add(double d);

	virtual JsonArrayBuilder add(bool b);

	virtual JsonArrayBuilder addNull();

	virtual JsonArrayBuilder add(JsonObjectBuilder job);

	virtual JsonArrayBuilder add(JsonArrayBuilder jab);

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder addAll(JsonArrayBuilder builder);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(220)]
	static JsonArrayBuilder _003Cdefault_003EaddAll(JsonArrayBuilder P_0, JsonArrayBuilder P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(256)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, string P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, BigDecimal value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(276)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, BigDecimal P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, BigInteger value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(296)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, BigInteger P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, int value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(315)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, int P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, long value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(334)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, long P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, double value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(355)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, double P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, bool value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(373)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, bool P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder addNull(int index);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(389)]
	static JsonArrayBuilder _003Cdefault_003EaddNull(JsonArrayBuilder P_0, int P_1)
	{
		JsonArrayBuilder result = P_0.add(P_1, JsonValue.NULL);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, JsonObjectBuilder builder);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(407)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, JsonObjectBuilder P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder add(int index, JsonArrayBuilder builder);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(425)]
	static JsonArrayBuilder _003Cdefault_003Eadd(JsonArrayBuilder P_0, int P_1, JsonArrayBuilder P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, string value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(459)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, string P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, BigDecimal value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(478)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, BigDecimal P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, BigInteger value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(497)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, BigInteger P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, int value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(515)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, int P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, long value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(533)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, long P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, double value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(553)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, double P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, bool value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(570)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, bool P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder setNull(int index);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(585)]
	static JsonArrayBuilder _003Cdefault_003EsetNull(JsonArrayBuilder P_0, int P_1)
	{
		JsonArrayBuilder result = P_0.set(P_1, JsonValue.NULL);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, JsonObjectBuilder builder);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(602)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, JsonObjectBuilder P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder set(int index, JsonArrayBuilder builder);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(619)]
	static JsonArrayBuilder _003Cdefault_003Eset(JsonArrayBuilder P_0, int P_1, JsonArrayBuilder P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArrayBuilder remove(int index);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(635)]
	static JsonArrayBuilder _003Cdefault_003Eremove(JsonArrayBuilder P_0, int P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	virtual JsonArray build();
}
