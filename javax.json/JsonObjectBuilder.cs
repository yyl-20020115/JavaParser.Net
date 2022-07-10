using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.math;

namespace javax.json;

public interface JsonObjectBuilder
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static JsonObjectBuilder addAll(JsonObjectBuilder P_0, JsonObjectBuilder P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EaddAll(P_0, P_1);
		}

		public unsafe static JsonObjectBuilder remove(JsonObjectBuilder P_0, string P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eremove(P_0, P_1);
		}
	}

	virtual JsonObjectBuilder add(string str, JsonValue jv);

	virtual JsonObjectBuilder add(string str1, string str2);

	virtual JsonObjectBuilder add(string str, BigInteger bi);

	virtual JsonObjectBuilder add(string str, BigDecimal bd);

	virtual JsonObjectBuilder add(string str, int i);

	virtual JsonObjectBuilder add(string str, long l);

	virtual JsonObjectBuilder add(string str, double d);

	virtual JsonObjectBuilder add(string str, bool b);

	virtual JsonObjectBuilder addNull(string str);

	virtual JsonObjectBuilder add(string str, JsonObjectBuilder job);

	virtual JsonObjectBuilder add(string str, JsonArrayBuilder jab);

	[Modifiers(Modifiers.Public)]
	virtual JsonObjectBuilder addAll(JsonObjectBuilder builder);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(281)]
	static JsonObjectBuilder _003Cdefault_003EaddAll(JsonObjectBuilder P_0, JsonObjectBuilder P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonObjectBuilder remove(string name);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(294)]
	static JsonObjectBuilder _003Cdefault_003Eremove(JsonObjectBuilder P_0, string P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	virtual JsonObject build();
}
