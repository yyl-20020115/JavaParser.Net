using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.thirdparty.publicsuffix;

internal sealed class TrieParser : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Joiner PREFIX_JOINER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/CharSequence;)Lcom/google/common/collect/ImmutableMap<Ljava/lang/String;Lcom/google/thirdparty/publicsuffix/PublicSuffixType;>;")]
	[LineNumberTable(new byte[] { 159, 134, 106, 102, 115, 99, 102, 159, 14 })]
	internal static ImmutableMap parseTrie(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		ImmutableMap.Builder builder = ImmutableMap.builder();
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		int num2 = 0;
		while (num2 < num)
		{
			int num3 = num2;
			ArrayDeque arrayDeque = Queues.newArrayDeque();
			int num4 = num2;
			ImmutableMap.Builder builder2 = builder;
			int num5 = num4;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			num2 = num3 + doParseTrieToBuilder(arrayDeque, charSequence2, num5, builder2);
		}
		ImmutableMap result = builder.buildOrThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Deque<Ljava/lang/CharSequence;>;Ljava/lang/CharSequence;ILcom/google/common/collect/ImmutableMap$Builder<Ljava/lang/String;Lcom/google/thirdparty/publicsuffix/PublicSuffixType;>;)I")]
	[LineNumberTable(new byte[]
	{
		159, 128, 138, 115, 99, 163, 102, 121, 126, 226,
		61, 235, 71, 159, 42, 248, 69, 109, 106, 176,
		134, 114, 137, 127, 8, 159, 26, 102, 194, 103
	})]
	private static int doParseTrieToBuilder(Deque P_0, CharSequence P_1, int P_2, ImmutableMap.Builder P_3)
	{
		CharSequence charSequence = P_1;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		int i = P_2;
		int num2 = 0;
		int i2;
		for (; i < num; i++)
		{
			i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			num2 = charSequence2.charAt(i2);
			if (num2 == 38 || num2 == 63 || num2 == 33 || num2 == 58 || num2 == 44)
			{
				break;
			}
		}
		int i3 = i;
		i2 = P_2;
		obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		obj = (charSequence2.___003Cref_003E = charSequence2.subSequence(i2, i3).___003Cref_003E);
		P_0.push(reverse(charSequence2).___003Cref_003E);
		if (num2 == 33 || num2 == 63 || num2 == 58 || num2 == 44)
		{
			string text = PREFIX_JOINER.join(P_0);
			if (String.instancehelper_length(text) > 0)
			{
				P_3.put(text, PublicSuffixType.fromCode((char)num2));
			}
		}
		i++;
		if (num2 != 63 && num2 != 44)
		{
			while (i < num)
			{
				int num3 = i;
				i2 = i;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				i = num3 + doParseTrieToBuilder(P_0, charSequence2, i2, P_3);
				i2 = i;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				if (charSequence2.charAt(i2) != '?')
				{
					i2 = i;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					if (charSequence2.charAt(i2) != ',')
					{
						continue;
					}
				}
				i++;
				break;
			}
		}
		P_0.pop();
		return i - P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(100)]
	private static CharSequence reverse(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence seq = default(CharSequence);
		object obj = (seq.___003Cref_003E = __003Cref_003E);
		CharSequence charSequence2 = default(CharSequence);
		object obj2 = (charSequence2.___003Cref_003E = new StringBuilder(seq).reverse());
		CharSequence result = charSequence2;
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(25)]
	internal TrieParser()
	{
	}

	[LineNumberTable(26)]
	static TrieParser()
	{
		PREFIX_JOINER = Joiner.on("");
	}
}
