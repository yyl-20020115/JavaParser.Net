using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Serializable]
[Signature("Ljava/lang/Enum<Lorg/checkerframework/framework/qual/TypeUseLocation;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
public sealed class TypeUseLocation : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		FIELD,
		LOCAL_VARIABLE,
		RESOURCE_VARIABLE,
		EXCEPTION_PARAMETER,
		RECEIVER,
		PARAMETER,
		RETURN,
		CONSTRUCTOR_RESULT,
		LOWER_BOUND,
		EXPLICIT_LOWER_BOUND,
		IMPLICIT_LOWER_BOUND,
		UPPER_BOUND,
		EXPLICIT_UPPER_BOUND,
		IMPLICIT_UPPER_BOUND,
		OTHERWISE,
		ALL
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EFIELD;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003ELOCAL_VARIABLE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003ERESOURCE_VARIABLE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EEXCEPTION_PARAMETER;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003ERECEIVER;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EPARAMETER;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003ERETURN;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003ECONSTRUCTOR_RESULT;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003ELOWER_BOUND;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EEXPLICIT_LOWER_BOUND;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EIMPLICIT_LOWER_BOUND;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EUPPER_BOUND;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EEXPLICIT_UPPER_BOUND;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EIMPLICIT_UPPER_BOUND;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EOTHERWISE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static TypeUseLocation ___003C_003EALL;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static TypeUseLocation[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation FIELD
	{
		[HideFromJava]
		get
		{
			return ___003C_003EFIELD;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation LOCAL_VARIABLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELOCAL_VARIABLE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation RESOURCE_VARIABLE
	{
		[HideFromJava]
		get
		{
			return ___003C_003ERESOURCE_VARIABLE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation EXCEPTION_PARAMETER
	{
		[HideFromJava]
		get
		{
			return ___003C_003EEXCEPTION_PARAMETER;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation RECEIVER
	{
		[HideFromJava]
		get
		{
			return ___003C_003ERECEIVER;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation PARAMETER
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPARAMETER;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation RETURN
	{
		[HideFromJava]
		get
		{
			return ___003C_003ERETURN;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation CONSTRUCTOR_RESULT
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECONSTRUCTOR_RESULT;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation LOWER_BOUND
	{
		[HideFromJava]
		get
		{
			return ___003C_003ELOWER_BOUND;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation EXPLICIT_LOWER_BOUND
	{
		[HideFromJava]
		get
		{
			return ___003C_003EEXPLICIT_LOWER_BOUND;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation IMPLICIT_LOWER_BOUND
	{
		[HideFromJava]
		get
		{
			return ___003C_003EIMPLICIT_LOWER_BOUND;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation UPPER_BOUND
	{
		[HideFromJava]
		get
		{
			return ___003C_003EUPPER_BOUND;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation EXPLICIT_UPPER_BOUND
	{
		[HideFromJava]
		get
		{
			return ___003C_003EEXPLICIT_UPPER_BOUND;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation IMPLICIT_UPPER_BOUND
	{
		[HideFromJava]
		get
		{
			return ___003C_003EIMPLICIT_UPPER_BOUND;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation OTHERWISE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOTHERWISE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static TypeUseLocation ALL
	{
		[HideFromJava]
		get
		{
			return ___003C_003EALL;
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
	private TypeUseLocation(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(12)]
	public static TypeUseLocation[] values()
	{
		return (TypeUseLocation[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(12)]
	public static TypeUseLocation valueOf(string name)
	{
		return (TypeUseLocation)java.lang.Enum.valueOf(ClassLiteral<TypeUseLocation>.Value, name);
	}

	[LineNumberTable(new byte[]
	{
		159, 157, 240, 72, 176, 176, 176, 240, 70, 176,
		176, 240, 71, 240, 69, 241, 69, 241, 74, 241,
		70, 177, 177, 241, 70, 241, 159, 179
	})]
	static TypeUseLocation()
	{
		___003C_003EFIELD = new TypeUseLocation("FIELD", 0);
		___003C_003ELOCAL_VARIABLE = new TypeUseLocation("LOCAL_VARIABLE", 1);
		___003C_003ERESOURCE_VARIABLE = new TypeUseLocation("RESOURCE_VARIABLE", 2);
		___003C_003EEXCEPTION_PARAMETER = new TypeUseLocation("EXCEPTION_PARAMETER", 3);
		___003C_003ERECEIVER = new TypeUseLocation("RECEIVER", 4);
		___003C_003EPARAMETER = new TypeUseLocation("PARAMETER", 5);
		___003C_003ERETURN = new TypeUseLocation("RETURN", 6);
		___003C_003ECONSTRUCTOR_RESULT = new TypeUseLocation("CONSTRUCTOR_RESULT", 7);
		___003C_003ELOWER_BOUND = new TypeUseLocation("LOWER_BOUND", 8);
		___003C_003EEXPLICIT_LOWER_BOUND = new TypeUseLocation("EXPLICIT_LOWER_BOUND", 9);
		___003C_003EIMPLICIT_LOWER_BOUND = new TypeUseLocation("IMPLICIT_LOWER_BOUND", 10);
		___003C_003EUPPER_BOUND = new TypeUseLocation("UPPER_BOUND", 11);
		___003C_003EEXPLICIT_UPPER_BOUND = new TypeUseLocation("EXPLICIT_UPPER_BOUND", 12);
		___003C_003EIMPLICIT_UPPER_BOUND = new TypeUseLocation("IMPLICIT_UPPER_BOUND", 13);
		___003C_003EOTHERWISE = new TypeUseLocation("OTHERWISE", 14);
		___003C_003EALL = new TypeUseLocation("ALL", 15);
		_0024VALUES = new TypeUseLocation[16]
		{
			___003C_003EFIELD, ___003C_003ELOCAL_VARIABLE, ___003C_003ERESOURCE_VARIABLE, ___003C_003EEXCEPTION_PARAMETER, ___003C_003ERECEIVER, ___003C_003EPARAMETER, ___003C_003ERETURN, ___003C_003ECONSTRUCTOR_RESULT, ___003C_003ELOWER_BOUND, ___003C_003EEXPLICIT_LOWER_BOUND,
			___003C_003EIMPLICIT_LOWER_BOUND, ___003C_003EUPPER_BOUND, ___003C_003EEXPLICIT_UPPER_BOUND, ___003C_003EIMPLICIT_UPPER_BOUND, ___003C_003EOTHERWISE, ___003C_003EALL
		};
	}
}
