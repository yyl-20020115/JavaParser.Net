using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.math;
using java.util.stream;

namespace javax.json.stream;

[Implements(new string[] { "java.io.Closeable" })]
public interface JsonParser : Closeable, AutoCloseable
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Ljavax/json/stream/JsonParser$Event;>;")]
	[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	public sealed class Event : java.lang.Enum
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			START_ARRAY,
			START_OBJECT,
			KEY_NAME,
			VALUE_STRING,
			VALUE_NUMBER,
			VALUE_TRUE,
			VALUE_FALSE,
			VALUE_NULL,
			END_OBJECT,
			END_ARRAY
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003ESTART_ARRAY;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003ESTART_OBJECT;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003EKEY_NAME;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003EVALUE_STRING;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003EVALUE_NUMBER;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003EVALUE_TRUE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003EVALUE_FALSE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003EVALUE_NULL;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003EEND_OBJECT;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Event ___003C_003EEND_ARRAY;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Event[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event START_ARRAY
		{
			[HideFromJava]
			get
			{
				return ___003C_003ESTART_ARRAY;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event START_OBJECT
		{
			[HideFromJava]
			get
			{
				return ___003C_003ESTART_OBJECT;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event KEY_NAME
		{
			[HideFromJava]
			get
			{
				return ___003C_003EKEY_NAME;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event VALUE_STRING
		{
			[HideFromJava]
			get
			{
				return ___003C_003EVALUE_STRING;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event VALUE_NUMBER
		{
			[HideFromJava]
			get
			{
				return ___003C_003EVALUE_NUMBER;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event VALUE_TRUE
		{
			[HideFromJava]
			get
			{
				return ___003C_003EVALUE_TRUE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event VALUE_FALSE
		{
			[HideFromJava]
			get
			{
				return ___003C_003EVALUE_FALSE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event VALUE_NULL
		{
			[HideFromJava]
			get
			{
				return ___003C_003EVALUE_NULL;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event END_OBJECT
		{
			[HideFromJava]
			get
			{
				return ___003C_003EEND_OBJECT;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Event END_ARRAY
		{
			[HideFromJava]
			get
			{
				return ___003C_003EEND_ARRAY;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(201)]
		private Event(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(201)]
		public static Event[] values()
		{
			return (Event[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(201)]
		public static Event valueOf(string name)
		{
			return (Event)java.lang.Enum.valueOf(ClassLiteral<Event>.Value, name);
		}

		[LineNumberTable(new byte[]
		{
			160, 91, 208, 240, 70, 240, 70, 240, 71, 240,
			69, 240, 69, 240, 69, 208, 208, 241, 14
		})]
		static Event()
		{
			___003C_003ESTART_ARRAY = new Event("START_ARRAY", 0);
			___003C_003ESTART_OBJECT = new Event("START_OBJECT", 1);
			___003C_003EKEY_NAME = new Event("KEY_NAME", 2);
			___003C_003EVALUE_STRING = new Event("VALUE_STRING", 3);
			___003C_003EVALUE_NUMBER = new Event("VALUE_NUMBER", 4);
			___003C_003EVALUE_TRUE = new Event("VALUE_TRUE", 5);
			___003C_003EVALUE_FALSE = new Event("VALUE_FALSE", 6);
			___003C_003EVALUE_NULL = new Event("VALUE_NULL", 7);
			___003C_003EEND_OBJECT = new Event("END_OBJECT", 8);
			___003C_003EEND_ARRAY = new Event("END_ARRAY", 9);
			_0024VALUES = new Event[10] { ___003C_003ESTART_ARRAY, ___003C_003ESTART_OBJECT, ___003C_003EKEY_NAME, ___003C_003EVALUE_STRING, ___003C_003EVALUE_NUMBER, ___003C_003EVALUE_TRUE, ___003C_003EVALUE_FALSE, ___003C_003EVALUE_NULL, ___003C_003EEND_OBJECT, ___003C_003EEND_ARRAY };
		}
	}

	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static JsonObject getObject(JsonParser P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EgetObject(P_0);
		}

		public unsafe static JsonValue getValue(JsonParser P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EgetValue(P_0);
		}

		public unsafe static JsonArray getArray(JsonParser P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EgetArray(P_0);
		}

		public unsafe static Stream getArrayStream(JsonParser P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EgetArrayStream(P_0);
		}

		public unsafe static Stream getObjectStream(JsonParser P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EgetObjectStream(P_0);
		}

		public unsafe static Stream getValueStream(JsonParser P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EgetValueStream(P_0);
		}

		public unsafe static void skipArray(JsonParser P_0)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EskipArray(P_0);
		}

		public unsafe static void skipObject(JsonParser P_0)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EskipObject(P_0);
		}
	}

	virtual bool hasNext();

	virtual Event next();

	virtual string getString();

	virtual bool isIntegralNumber();

	virtual int getInt();

	virtual long getLong();

	virtual BigDecimal getBigDecimal();

	virtual JsonLocation getLocation();

	[Modifiers(Modifiers.Public)]
	virtual JsonObject getObject();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(383)]
	static JsonObject _003Cdefault_003EgetObject(JsonParser P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonValue getValue();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(401)]
	static JsonValue _003Cdefault_003EgetValue(JsonParser P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArray getArray();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(416)]
	static JsonArray _003Cdefault_003EgetArray(JsonParser P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	[Signature("()Ljava/util/stream/Stream<Ljavax/json/JsonValue;>;")]
	virtual Stream getArrayStream();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(436)]
	static Stream _003Cdefault_003EgetArrayStream(JsonParser P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	[Signature("()Ljava/util/stream/Stream<Ljava/util/Map$Entry<Ljava/lang/String;Ljavax/json/JsonValue;>;>;")]
	virtual Stream getObjectStream();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(456)]
	static Stream _003Cdefault_003EgetObjectStream(JsonParser P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	[Signature("()Ljava/util/stream/Stream<Ljavax/json/JsonValue;>;")]
	virtual Stream getValueStream();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(471)]
	static Stream _003Cdefault_003EgetValueStream(JsonParser P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual void skipArray();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(485)]
	static void _003Cdefault_003EskipArray(JsonParser P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Public)]
	virtual void skipObject();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(499)]
	static void _003Cdefault_003EskipObject(JsonParser P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	void close();
}
