using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace com.google.common.escape;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/escape/ElementTypesAreNonnullByDefault;"
})]
public sealed class ArrayBasedEscaperMap : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private char[][] replacementArray;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static char[][] EMPTY_REPLACEMENT_ARRAY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/Character;Ljava/lang/String;>;)Lcom/google/common/escape/ArrayBasedEscaperMap;")]
	[LineNumberTable(48)]
	public static ArrayBasedEscaperMap create(Map replacements)
	{
		ArrayBasedEscaperMap result = new ArrayBasedEscaperMap(createReplacementArray(replacements));
		_ = null;
		return result;
	}

	internal virtual char[][] getReplacementArray()
	{
		return replacementArray;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/Character;Ljava/lang/String;>;)[[C")]
	[LineNumberTable(new byte[] { 19, 103, 104, 134, 118, 105, 127, 1, 121, 98 })]
	internal static char[][] createReplacementArray(Map P_0)
	{
		Preconditions.checkNotNull(P_0);
		if (P_0.isEmpty())
		{
			return EMPTY_REPLACEMENT_ARRAY;
		}
		int num = ((Character)Collections.max(P_0.keySet())).charValue();
		char[][] array = new char[num + 1][];
		Iterator iterator = P_0.keySet().iterator();
		while (iterator.hasNext())
		{
			Character character = (Character)iterator.next();
			array[(uint)character.charValue()] = String.instancehelper_toCharArray((string)P_0.get(character));
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 5, 104, 103 })]
	private ArrayBasedEscaperMap(char[][] P_0)
	{
		replacementArray = P_0;
	}

	[LineNumberTable(82)]
	static ArrayBasedEscaperMap()
	{
		int[] array = new int[2];
		int num = (array[1] = 0);
		num = (array[0] = 0);
		EMPTY_REPLACEMENT_ARRAY = (char[][])ByteCodeHelper.multianewarray(typeof(char[][]).TypeHandle, array);
	}
}
