using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.escape;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/escape/ElementTypesAreNonnullByDefault;"
})]
public abstract class ArrayBasedCharEscaper : CharEscaper
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char[][] replacements;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int replacementsLength;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char safeMin;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char safeMax;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 121, 100, 136, 103, 108, 109, 164, 98, 134,
		103, 103
	})]
	protected internal ArrayBasedCharEscaper(ArrayBasedEscaperMap escaperMap, char safeMin, char safeMax)
	{
		int num = safeMax;
		int num2 = safeMin;
		base._002Ector();
		Preconditions.checkNotNull(escaperMap);
		replacements = escaperMap.getReplacementArray();
		replacementsLength = replacements.Length;
		if (num < num2)
		{
			num = 0;
			num2 = 65535;
		}
		this.safeMin = (char)num2;
		this.safeMax = (char)num;
	}

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal abstract char[] escapeUnsafe(char ch);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/Character;Ljava/lang/String;>;CC)V")]
	[LineNumberTable(new byte[] { 159, 125, 100, 112 })]
	protected internal ArrayBasedCharEscaper(Map replacementMap, char safeMin, char safeMax)
		: this(ArrayBasedEscaperMap.create(replacementMap), safeMin, safeMax)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 56, 103, 107, 104, 127, 6, 235, 61, 230, 70 })]
	public sealed override string escape(string s)
	{
		Preconditions.checkNotNull(s);
		for (int i = 0; i < String.instancehelper_length(s); i++)
		{
			int num = String.instancehelper_charAt(s, i);
			if ((num < replacementsLength && replacements[num] != null) || num > safeMax || num < safeMin)
			{
				string result = escapeSlow(s, i);
				_ = null;
				return result;
			}
		}
		return s;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 111, 130, 105, 105, 99, 162, 114, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal sealed override char[] escape(char c)
	{
		if (c < replacementsLength)
		{
			char[] array = replacements[(uint)c];
			if (array != null)
			{
				return array;
			}
		}
		if (c >= safeMin && c <= safeMax)
		{
			return null;
		}
		char[] result = escapeUnsafe(c);
		_ = null;
		return result;
	}
}
