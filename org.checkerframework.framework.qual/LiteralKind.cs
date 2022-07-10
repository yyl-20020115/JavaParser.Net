using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace org.checkerframework.framework.qual;

[Serializable]
[Signature("Ljava/lang/Enum<Lorg/checkerframework/framework/qual/LiteralKind;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
public sealed class LiteralKind : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		NULL,
		INT,
		LONG,
		FLOAT,
		DOUBLE,
		BOOLEAN,
		CHAR,
		STRING,
		ALL,
		PRIMITIVE
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003ENULL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003EINT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003ELONG;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003EFLOAT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003EDOUBLE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003EBOOLEAN;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003ECHAR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003ESTRING;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003EALL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static LiteralKind ___003C_003EPRIMITIVE;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static LiteralKind[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind NULL
	{
		[HideFromJava]
		get
		{
			return ___003C_003ENULL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind INT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EINT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind LONG
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELONG;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind FLOAT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFLOAT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind DOUBLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EDOUBLE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind BOOLEAN
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBOOLEAN;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind CHAR
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECHAR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind STRING
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESTRING;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind ALL
	{
		[HideFromJava]
		get
		{
			return ___003C_003EALL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static LiteralKind PRIMITIVE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPRIMITIVE;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(15)]
	public static LiteralKind[] values()
	{
		return (LiteralKind[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()V")]
	[LineNumberTable(15)]
	private LiteralKind(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(15)]
	public static LiteralKind valueOf(string name)
	{
		return (LiteralKind)java.lang.Enum.valueOf(ClassLiteral<LiteralKind>.Value, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<Lorg/checkerframework/framework/qual/LiteralKind;>;")]
	[LineNumberTable(new byte[] { 159, 186, 117, 108, 108 })]
	public static List allLiteralKinds()
	{
		ArrayList.___003Cclinit_003E();
		ArrayList arrayList = new ArrayList(Arrays.asList(values()));
		((List)arrayList).remove((object)___003C_003EALL);
		((List)arrayList).remove((object)___003C_003EPRIMITIVE);
		return arrayList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<Lorg/checkerframework/framework/qual/LiteralKind;>;")]
	[LineNumberTable(58)]
	public static List primitiveLiteralKinds()
	{
		List result = Arrays.asList(___003C_003EINT, ___003C_003ELONG, ___003C_003EFLOAT, ___003C_003EDOUBLE, ___003C_003EBOOLEAN, ___003C_003ECHAR);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		159, 159, 144, 144, 144, 144, 144, 144, 144, 144,
		144, 241, 44
	})]
	static LiteralKind()
	{
		___003C_003ENULL = new LiteralKind("NULL", 0);
		___003C_003EINT = new LiteralKind("INT", 1);
		___003C_003ELONG = new LiteralKind("LONG", 2);
		___003C_003EFLOAT = new LiteralKind("FLOAT", 3);
		___003C_003EDOUBLE = new LiteralKind("DOUBLE", 4);
		___003C_003EBOOLEAN = new LiteralKind("BOOLEAN", 5);
		___003C_003ECHAR = new LiteralKind("CHAR", 6);
		___003C_003ESTRING = new LiteralKind("STRING", 7);
		___003C_003EALL = new LiteralKind("ALL", 8);
		___003C_003EPRIMITIVE = new LiteralKind("PRIMITIVE", 9);
		_0024VALUES = new LiteralKind[10] { ___003C_003ENULL, ___003C_003EINT, ___003C_003ELONG, ___003C_003EFLOAT, ___003C_003EDOUBLE, ___003C_003EBOOLEAN, ___003C_003ECHAR, ___003C_003ESTRING, ___003C_003EALL, ___003C_003EPRIMITIVE };
	}
}
