using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Serializable]
[Signature("Ljava/lang/Enum<Lorg/checkerframework/framework/qual/TypeKind;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
public sealed class TypeKind : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		BOOLEAN,
		BYTE,
		SHORT,
		INT,
		LONG,
		CHAR,
		FLOAT,
		DOUBLE,
		VOID,
		NONE,
		NULL,
		ARRAY,
		DECLARED,
		ERROR,
		TYPEVAR,
		WILDCARD,
		PACKAGE,
		EXECUTABLE,
		OTHER,
		UNION,
		INTERSECTION
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EBOOLEAN;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EBYTE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003ESHORT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EINT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003ELONG;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003ECHAR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EFLOAT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EDOUBLE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EVOID;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003ENONE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003ENULL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EARRAY;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EDECLARED;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EERROR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003ETYPEVAR;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EWILDCARD;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EPACKAGE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EEXECUTABLE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EOTHER;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EUNION;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeKind ___003C_003EINTERSECTION;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static TypeKind[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind BOOLEAN
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBOOLEAN;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind BYTE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EBYTE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind SHORT
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESHORT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind INT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EINT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind LONG
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELONG;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind CHAR
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECHAR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind FLOAT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFLOAT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind DOUBLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EDOUBLE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind VOID
	{
		[HideFromJava]
		get
		{
			return ___003C_003EVOID;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind NONE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ENONE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind NULL
	{
		[HideFromJava]
		get
		{
			return ___003C_003ENULL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind ARRAY
	{
		[HideFromJava]
		get
		{
			return ___003C_003EARRAY;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind DECLARED
	{
		[HideFromJava]
		get
		{
			return ___003C_003EDECLARED;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind ERROR
	{
		[HideFromJava]
		get
		{
			return ___003C_003EERROR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind TYPEVAR
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETYPEVAR;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind WILDCARD
	{
		[HideFromJava]
		get
		{
			return ___003C_003EWILDCARD;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind PACKAGE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPACKAGE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind EXECUTABLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EEXECUTABLE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind OTHER
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOTHER;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind UNION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUNION;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeKind INTERSECTION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EINTERSECTION;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()V")]
	[LineNumberTable(12)]
	private TypeKind(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(12)]
	public static TypeKind[] values()
	{
		return (TypeKind[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(12)]
	public static TypeKind valueOf(string name)
	{
		return (TypeKind)java.lang.Enum.valueOf(ClassLiteral<TypeKind>.Value, name);
	}

	[LineNumberTable(new byte[]
	{
		159, 156, 176, 176, 176, 176, 176, 176, 176, 176,
		176, 177, 177, 177, 177, 177, 177, 177, 177, 177,
		177, 177, 241, 2
	})]
	static TypeKind()
	{
		___003C_003EBOOLEAN = new TypeKind("BOOLEAN", 0);
		___003C_003EBYTE = new TypeKind("BYTE", 1);
		___003C_003ESHORT = new TypeKind("SHORT", 2);
		___003C_003EINT = new TypeKind("INT", 3);
		___003C_003ELONG = new TypeKind("LONG", 4);
		___003C_003ECHAR = new TypeKind("CHAR", 5);
		___003C_003EFLOAT = new TypeKind("FLOAT", 6);
		___003C_003EDOUBLE = new TypeKind("DOUBLE", 7);
		___003C_003EVOID = new TypeKind("VOID", 8);
		___003C_003ENONE = new TypeKind("NONE", 9);
		___003C_003ENULL = new TypeKind("NULL", 10);
		___003C_003EARRAY = new TypeKind("ARRAY", 11);
		___003C_003EDECLARED = new TypeKind("DECLARED", 12);
		___003C_003EERROR = new TypeKind("ERROR", 13);
		___003C_003ETYPEVAR = new TypeKind("TYPEVAR", 14);
		___003C_003EWILDCARD = new TypeKind("WILDCARD", 15);
		___003C_003EPACKAGE = new TypeKind("PACKAGE", 16);
		___003C_003EEXECUTABLE = new TypeKind("EXECUTABLE", 17);
		___003C_003EOTHER = new TypeKind("OTHER", 18);
		___003C_003EUNION = new TypeKind("UNION", 19);
		___003C_003EINTERSECTION = new TypeKind("INTERSECTION", 20);
		_0024VALUES = new TypeKind[21]
		{
			___003C_003EBOOLEAN, ___003C_003EBYTE, ___003C_003ESHORT, ___003C_003EINT, ___003C_003ELONG, ___003C_003ECHAR, ___003C_003EFLOAT, ___003C_003EDOUBLE, ___003C_003EVOID, ___003C_003ENONE,
			___003C_003ENULL, ___003C_003EARRAY, ___003C_003EDECLARED, ___003C_003EERROR, ___003C_003ETYPEVAR, ___003C_003EWILDCARD, ___003C_003EPACKAGE, ___003C_003EEXECUTABLE, ___003C_003EOTHER, ___003C_003EUNION,
			___003C_003EINTERSECTION
		};
	}
}
