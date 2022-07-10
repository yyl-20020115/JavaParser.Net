using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.google.common.collect;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/common/collect/BoundType;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class BoundType : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		OPEN,
		CLOSED
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static BoundType ___003C_003EOPEN;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static BoundType ___003C_003ECLOSED;

	[Modifiers(Modifiers.Final)]
	internal bool inclusive;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static BoundType[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static BoundType OPEN
	{
		[HideFromJava]
		get
		{
			return ___003C_003EOPEN;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static BoundType CLOSED
	{
		[HideFromJava]
		get
		{
			return ___003C_003ECLOSED;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Z)V")]
	[LineNumberTable(new byte[] { 159, 134, 162, 106, 103 })]
	private BoundType(string P_0, int P_1, bool P_2)
		: base(P_0, P_1)
	{
		inclusive = P_2;
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	private static BoundType[] _0024values()
	{
		return new BoundType[2] { ___003C_003EOPEN, ___003C_003ECLOSED };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	public static BoundType[] values()
	{
		return (BoundType[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	public static BoundType valueOf(string name)
	{
		return (BoundType)java.lang.Enum.valueOf(ClassLiteral<BoundType>.Value, name);
	}

	internal static BoundType forBoolean(bool P_0)
	{
		return (!P_0) ? ___003C_003EOPEN : ___003C_003ECLOSED;
	}

	[LineNumberTable(new byte[] { 159, 172, 113, 241, 59 })]
	static BoundType()
	{
		___003C_003EOPEN = new BoundType("OPEN", 0, false);
		___003C_003ECLOSED = new BoundType("CLOSED", 1, true);
		_0024VALUES = _0024values();
	}
}
