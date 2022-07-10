using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace javax.json;

[Implements(new string[] { "java.io.Closeable" })]
public interface JsonReader : Closeable, AutoCloseable
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static JsonValue readValue(JsonReader P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EreadValue(P_0);
		}
	}

	virtual JsonObject readObject();

	virtual JsonStructure read();

	virtual JsonArray readArray();

	[Modifiers(Modifiers.Public)]
	virtual JsonValue readValue();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(144)]
	static JsonValue _003Cdefault_003EreadValue(JsonReader P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	void close();
}
