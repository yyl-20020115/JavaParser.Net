using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.google.errorprone.annotations;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/errorprone/annotations/Modifier;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
public sealed class Modifier : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		PUBLIC,
		PROTECTED,
		PRIVATE,
		ABSTRACT,
		DEFAULT,
		STATIC,
		FINAL,
		TRANSIENT,
		VOLATILE,
		SYNCHRONIZED,
		NATIVE,
		STRICTFP
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003EPUBLIC;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003EPROTECTED;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003EPRIVATE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003EABSTRACT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003EDEFAULT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003ESTATIC;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003EFINAL;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003ETRANSIENT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003EVOLATILE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003ESYNCHRONIZED;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003ENATIVE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static Modifier ___003C_003ESTRICTFP;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static Modifier[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier PUBLIC
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPUBLIC;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier PROTECTED
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPROTECTED;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier PRIVATE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPRIVATE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier ABSTRACT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EABSTRACT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier DEFAULT
	{
		[HideFromJava]
		get
		{
			return ___003C_003EDEFAULT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier STATIC
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESTATIC;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier FINAL
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFINAL;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier TRANSIENT
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETRANSIENT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier VOLATILE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EVOLATILE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier SYNCHRONIZED
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESYNCHRONIZED;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier NATIVE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ENATIVE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static Modifier STRICTFP
	{
		[HideFromJava]
		get
		{
			return ___003C_003ESTRICTFP;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()V")]
	[LineNumberTable(29)]
	private Modifier(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	public static Modifier[] values()
	{
		return (Modifier[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	public static Modifier valueOf(string name)
	{
		return (Modifier)java.lang.Enum.valueOf(ClassLiteral<Modifier>.Value, name);
	}

	[LineNumberTable(new byte[]
	{
		159, 172, 112, 112, 112, 112, 112, 112, 112, 112,
		112, 113, 113, 241, 52
	})]
	static Modifier()
	{
		___003C_003EPUBLIC = new Modifier("PUBLIC", 0);
		___003C_003EPROTECTED = new Modifier("PROTECTED", 1);
		___003C_003EPRIVATE = new Modifier("PRIVATE", 2);
		___003C_003EABSTRACT = new Modifier("ABSTRACT", 3);
		___003C_003EDEFAULT = new Modifier("DEFAULT", 4);
		___003C_003ESTATIC = new Modifier("STATIC", 5);
		___003C_003EFINAL = new Modifier("FINAL", 6);
		___003C_003ETRANSIENT = new Modifier("TRANSIENT", 7);
		___003C_003EVOLATILE = new Modifier("VOLATILE", 8);
		___003C_003ESYNCHRONIZED = new Modifier("SYNCHRONIZED", 9);
		___003C_003ENATIVE = new Modifier("NATIVE", 10);
		___003C_003ESTRICTFP = new Modifier("STRICTFP", 11);
		_0024VALUES = new Modifier[12]
		{
			___003C_003EPUBLIC, ___003C_003EPROTECTED, ___003C_003EPRIVATE, ___003C_003EABSTRACT, ___003C_003EDEFAULT, ___003C_003ESTATIC, ___003C_003EFINAL, ___003C_003ETRANSIENT, ___003C_003EVOLATILE, ___003C_003ESYNCHRONIZED,
			___003C_003ENATIVE, ___003C_003ESTRICTFP
		};
	}
}
