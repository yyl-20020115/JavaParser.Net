using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.google.common.io;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/common/io/RecursiveDeleteOption;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class RecursiveDeleteOption : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		ALLOW_INSECURE
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static RecursiveDeleteOption ___003C_003EALLOW_INSECURE;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static RecursiveDeleteOption[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static RecursiveDeleteOption ALLOW_INSECURE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EALLOW_INSECURE;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()V")]
	[LineNumberTable(35)]
	private RecursiveDeleteOption(string P_0, int P_1)
		: base(P_0, P_1)
	{
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	private static RecursiveDeleteOption[] _0024values()
	{
		return new RecursiveDeleteOption[1] { ___003C_003EALLOW_INSECURE };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public static RecursiveDeleteOption[] values()
	{
		return (RecursiveDeleteOption[])_0024VALUES.Clone();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public static RecursiveDeleteOption valueOf(string name)
	{
		return (RecursiveDeleteOption)java.lang.Enum.valueOf(ClassLiteral<RecursiveDeleteOption>.Value, name);
	}

	[LineNumberTable(new byte[] { 159, 190, 240, 47 })]
	static RecursiveDeleteOption()
	{
		___003C_003EALLOW_INSECURE = new RecursiveDeleteOption("ALLOW_INSECURE", 0);
		_0024VALUES = _0024values();
	}
}
