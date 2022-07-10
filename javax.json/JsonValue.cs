using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace javax.json;

public interface JsonValue
{
	[Serializable]
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Ljavax/json/JsonValue$ValueType;>;")]
	[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	public sealed class ValueType : java.lang.Enum
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			ARRAY,
			OBJECT,
			STRING,
			NUMBER,
			TRUE,
			FALSE,
			NULL
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static ValueType ___003C_003EARRAY;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static ValueType ___003C_003EOBJECT;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static ValueType ___003C_003ESTRING;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static ValueType ___003C_003ENUMBER;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static ValueType ___003C_003ETRUE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static ValueType ___003C_003EFALSE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static ValueType ___003C_003ENULL;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static ValueType[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ValueType ARRAY
		{
			[HideFromJava]
			get
			{
				return ___003C_003EARRAY;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ValueType OBJECT
		{
			[HideFromJava]
			get
			{
				return ___003C_003EOBJECT;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ValueType STRING
		{
			[HideFromJava]
			get
			{
				return ___003C_003ESTRING;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ValueType NUMBER
		{
			[HideFromJava]
			get
			{
				return ___003C_003ENUMBER;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ValueType TRUE
		{
			[HideFromJava]
			get
			{
				return ___003C_003ETRUE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ValueType FALSE
		{
			[HideFromJava]
			get
			{
				return ___003C_003EFALSE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static ValueType NULL
		{
			[HideFromJava]
			get
			{
				return ___003C_003ENULL;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(73)]
		private ValueType(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(73)]
		public static ValueType[] values()
		{
			return (ValueType[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(73)]
		public static ValueType valueOf(string name)
		{
			return (ValueType)java.lang.Enum.valueOf(ClassLiteral<ValueType>.Value, name);
		}

		[LineNumberTable(new byte[]
		{
			27, 240, 69, 240, 69, 240, 69, 240, 69, 240,
			69, 240, 69, 240, 30
		})]
		static ValueType()
		{
			___003C_003EARRAY = new ValueType("ARRAY", 0);
			___003C_003EOBJECT = new ValueType("OBJECT", 1);
			___003C_003ESTRING = new ValueType("STRING", 2);
			___003C_003ENUMBER = new ValueType("NUMBER", 3);
			___003C_003ETRUE = new ValueType("TRUE", 4);
			___003C_003EFALSE = new ValueType("FALSE", 5);
			___003C_003ENULL = new ValueType("NULL", 6);
			_0024VALUES = new ValueType[7] { ___003C_003EARRAY, ___003C_003EOBJECT, ___003C_003ESTRING, ___003C_003ENUMBER, ___003C_003ETRUE, ___003C_003EFALSE, ___003C_003ENULL };
		}
	}

	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static JsonObject asJsonObject(JsonValue P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EasJsonObject(P_0);
		}

		public unsafe static JsonArray asJsonArray(JsonValue P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EasJsonArray(P_0);
		}
	}

	[HideFromJava]
	public static class __Fields
	{
		public static readonly JsonObject EMPTY_JSON_OBJECT;

		public static readonly JsonArray EMPTY_JSON_ARRAY;

		public static readonly JsonValue NULL;

		public static readonly JsonValue TRUE;

		public static readonly JsonValue FALSE;

		static __Fields()
		{
			EMPTY_JSON_OBJECT = JsonValue.EMPTY_JSON_OBJECT;
			EMPTY_JSON_ARRAY = JsonValue.EMPTY_JSON_ARRAY;
			NULL = JsonValue.NULL;
			TRUE = JsonValue.TRUE;
			FALSE = JsonValue.FALSE;
		}
	}

	static readonly JsonObject EMPTY_JSON_OBJECT;

	static readonly JsonArray EMPTY_JSON_ARRAY;

	static readonly JsonValue NULL;

	static readonly JsonValue TRUE;

	static readonly JsonValue FALSE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	static void ___003Cclinit_003E()
	{
	}

	virtual ValueType getValueType();

	[Modifiers(Modifiers.Public)]
	virtual JsonObject asJsonObject();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(141)]
	static JsonObject _003Cdefault_003EasJsonObject(JsonValue P_0)
	{
		return (JsonObject)ClassLiteral<JsonObject>.Value.cast(P_0);
	}

	[Modifiers(Modifiers.Public)]
	virtual JsonArray asJsonArray();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(153)]
	static JsonArray _003Cdefault_003EasJsonArray(JsonValue P_0)
	{
		return (JsonArray)ClassLiteral<JsonArray>.Value.cast(P_0);
	}

	virtual string toString();

	[LineNumberTable(new byte[] { 11, 234, 71, 234, 109, 239, 69, 239, 69 })]
	static JsonValue()
	{
		EMPTY_JSON_OBJECT = new EmptyObject();
		EMPTY_JSON_ARRAY = new EmptyArray();
		NULL = new JsonValueImpl(ValueType.___003C_003ENULL);
		TRUE = new JsonValueImpl(ValueType.___003C_003ETRUE);
		FALSE = new JsonValueImpl(ValueType.___003C_003EFALSE);
	}
}
