using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace javax.json;

[Implements(new string[] { "java.io.Closeable" })]
public interface JsonWriter : Closeable, AutoCloseable
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static void write(JsonWriter P_0, JsonValue P_1)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003Ewrite(P_0, P_1);
		}
	}

	virtual void writeArray(JsonArray ja);

	virtual void writeObject(JsonObject jo);

	virtual void write(JsonStructure js);

	[Modifiers(Modifiers.Public)]
	virtual void write(JsonValue value);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(141)]
	static void _003Cdefault_003Ewrite(JsonWriter P_0, JsonValue P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	void close();
}
