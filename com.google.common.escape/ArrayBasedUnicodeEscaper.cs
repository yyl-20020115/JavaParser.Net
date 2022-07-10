using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.escape;

[ConstantPool(new object[]
{
	(byte)51,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/escape/ElementTypesAreNonnullByDefault;"
})]
public abstract class ArrayBasedUnicodeEscaper : UnicodeEscaper
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char[][] replacements;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int replacementsLength;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int safeMin;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int safeMax;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char safeMinChar;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char safeMaxChar;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 51, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		49, 104, 103, 108, 109, 164, 99, 135, 103, 231,
		79, 168, 107, 201, 104, 146
	})]
	protected internal ArrayBasedUnicodeEscaper(ArrayBasedEscaperMap escaperMap, int safeMin, int safeMax, string unsafeReplacement)
	{
		Preconditions.checkNotNull(escaperMap);
		replacements = escaperMap.getReplacementArray();
		replacementsLength = replacements.Length;
		if (safeMax < safeMin)
		{
			safeMax = -1;
			safeMin = int.MaxValue;
		}
		this.safeMin = safeMin;
		this.safeMax = safeMax;
		if (safeMin >= 55296)
		{
			safeMinChar = '\uffff';
			safeMaxChar = '\0';
		}
		else
		{
			safeMinChar = (char)safeMin;
			safeMaxChar = (char)Math.min(safeMax, 55295);
		}
	}

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal abstract char[] escapeUnsafe(int i);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/Character;Ljava/lang/String;>;IILjava/lang/String;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 51, 0, 0 })]
	[LineNumberTable(new byte[] { 27, 114 })]
	protected internal ArrayBasedUnicodeEscaper(Map replacementMap, int safeMin, int safeMax, string unsafeReplacement)
		: this(ArrayBasedEscaperMap.create(replacementMap), safeMin, safeMax, unsafeReplacement)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 94, 103, 107, 104, 191, 6, 235, 59, 230, 72 })]
	public sealed override string escape(string s)
	{
		Preconditions.checkNotNull(s);
		for (int i = 0; i < String.instancehelper_length(s); i++)
		{
			int num = String.instancehelper_charAt(s, i);
			if ((num < replacementsLength && replacements[num] != null) || num > safeMaxChar || num < safeMinChar)
			{
				string result = escapeSlow(s, i);
				_ = null;
				return result;
			}
		}
		return s;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 116, 105, 105, 99, 162, 114, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal sealed override char[] escape(int cp)
	{
		if (cp < replacementsLength)
		{
			char[] array = replacements[cp];
			if (array != null)
			{
				return array;
			}
		}
		if (cp >= safeMin && cp <= safeMax)
		{
			return null;
		}
		char[] result = escapeUnsafe(cp);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 97, 106, 100, 118, 191, 10, 130, 101, 98 })]
	protected internal sealed override int nextEscapeIndex(CharSequence csq, int index, int end)
	{
		CharSequence charSequence = csq;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		while (index < end)
		{
			int i = index;
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num = charSequence2.charAt(i);
			if ((num < replacementsLength && replacements[num] != null) || num > safeMaxChar || num < safeMinChar)
			{
				break;
			}
			index++;
		}
		return index;
	}
}
