using IKVM.Attributes;
using java.io;
using java.lang;
using java.math;

namespace javax.json.stream;

[Implements(new string[] { "java.io.Flushable", "java.io.Closeable" })]
public interface JsonGenerator : Flushable, Closeable, AutoCloseable
{
	[HideFromJava]
	public static class __Fields
	{
		public const string PRETTY_PRINTING = "javax.json.stream.JsonGenerator.prettyPrinting";
	}

	const string PRETTY_PRINTING = "javax.json.stream.JsonGenerator.prettyPrinting";

	void close();

	virtual JsonGenerator writeStartObject();

	virtual JsonGenerator writeStartObject(string str);

	virtual JsonGenerator write(string str1, string str2);

	virtual JsonGenerator writeStartArray(string str);

	virtual JsonGenerator writeEnd();

	virtual JsonGenerator write(string str, int i);

	virtual JsonGenerator writeKey(string str);

	virtual JsonGenerator writeStartArray();

	virtual JsonGenerator write(string str, JsonValue jv);

	virtual JsonGenerator write(string str, BigInteger bi);

	virtual JsonGenerator write(string str, BigDecimal bd);

	virtual JsonGenerator write(string str, long l);

	virtual JsonGenerator write(string str, double d);

	virtual JsonGenerator write(string str, bool b);

	virtual JsonGenerator writeNull(string str);

	virtual JsonGenerator write(JsonValue jv);

	virtual JsonGenerator write(string str);

	virtual JsonGenerator write(BigDecimal bd);

	virtual JsonGenerator write(BigInteger bi);

	virtual JsonGenerator write(int i);

	virtual JsonGenerator write(long l);

	virtual JsonGenerator write(double d);

	virtual JsonGenerator write(bool b);

	virtual JsonGenerator writeNull();

	void flush();
}
