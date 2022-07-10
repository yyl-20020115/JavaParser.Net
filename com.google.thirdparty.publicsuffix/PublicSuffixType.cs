using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.google.thirdparty.publicsuffix;

[Serializable]
[Signature("Ljava/lang/Enum<Lcom/google/thirdparty/publicsuffix/PublicSuffixType;>;")]
[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
public sealed class PublicSuffixType : java.lang.Enum
{
	[Serializable]
	[HideFromJava]
	public enum __Enum
	{
		PRIVATE,
		REGISTRY
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static PublicSuffixType ___003C_003EPRIVATE;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	internal static PublicSuffixType ___003C_003EREGISTRY;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char innerNodeCode;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char leafNodeCode;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	private static PublicSuffixType[] _0024VALUES;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static PublicSuffixType PRIVATE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EPRIVATE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	public static PublicSuffixType REGISTRY
	{
		[HideFromJava]
		get
		{
			return ___003C_003EREGISTRY;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	public static PublicSuffixType[] values()
	{
		return (PublicSuffixType[])_0024VALUES.Clone();
	}

	internal virtual char getInnerNodeCode()
	{
		return innerNodeCode;
	}

	internal virtual char getLeafNodeCode()
	{
		return leafNodeCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(CC)V")]
	[LineNumberTable(new byte[] { 159, 132, 165, 106, 103, 103 })]
	private PublicSuffixType(string P_0, int P_1, char P_2, char P_3)
		: base(P_0, P_1)
	{
		innerNodeCode = P_2;
		leafNodeCode = P_3;
		GC.KeepAlive(this);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	private static PublicSuffixType[] _0024values()
	{
		return new PublicSuffixType[2] { ___003C_003EPRIVATE, ___003C_003EREGISTRY };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	public static PublicSuffixType valueOf(string name)
	{
		return (PublicSuffixType)java.lang.Enum.valueOf(ClassLiteral<PublicSuffixType>.Value, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 128, 130, 116, 116, 3, 230, 69 })]
	internal static PublicSuffixType fromCode(char P_0)
	{
		PublicSuffixType[] array = values();
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			PublicSuffixType publicSuffixType = array[i];
			if (publicSuffixType.getInnerNodeCode() == P_0 || publicSuffixType.getLeafNodeCode() == P_0)
			{
				return publicSuffixType;
			}
		}
		int num2 = 38;
		num2 = num2;
		string s = new StringBuilder(num2).append("No enum corresponding to given code: ").append(P_0).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[LineNumberTable(new byte[] { 159, 175, 148, 244, 57 })]
	static PublicSuffixType()
	{
		___003C_003EPRIVATE = new PublicSuffixType("PRIVATE", 0, ':', ',');
		___003C_003EREGISTRY = new PublicSuffixType("REGISTRY", 1, '!', '?');
		_0024VALUES = _0024values();
	}
}
