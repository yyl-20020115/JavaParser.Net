using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.escape;

[ConstantPool(new object[]
{
	(byte)67,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/escape/ElementTypesAreNonnullByDefault;"
})]
public sealed class CharEscaperBuilder : Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[ConstantPool(new object[]
	{
		(byte)12,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class CharArrayDecorator : CharEscaper
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 12, 0, 0 })]
		private char[][] replacements;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int replaceLength;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 0, 1, 0, 0, 0, 12, 0,
			0
		})]
		[LineNumberTable(new byte[] { 159, 189, 104, 103, 104 })]
		internal CharArrayDecorator(char[][] P_0)
		{
			replacements = P_0;
			replaceLength = P_0.Length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 8, 103, 102, 104, 116, 235, 61, 230, 70 })]
		public override string escape(string P_0)
		{
			int num = String.instancehelper_length(P_0);
			for (int i = 0; i < num; i++)
			{
				int num2 = String.instancehelper_charAt(P_0, i);
				if (num2 < (nint)replacements.LongLength && replacements[num2] != null)
				{
					string result = escapeSlow(P_0, i);
					_ = null;
					return result;
				}
			}
			return P_0;
		}

		[LineNumberTable(71)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override char[] escape(char P_0)
		{
			return (P_0 >= replaceLength) ? null : replacements[(uint)P_0];
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<Ljava/lang/Character;Ljava/lang/String;>;")]
	private Map map;

	private int max;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 120, 98, 125, 105, 135 })]
	public virtual CharEscaperBuilder addEscape(char c, string r)
	{
		map.put(Character.valueOf(c), (string)Preconditions.checkNotNull(r));
		if (c > max)
		{
			max = c;
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 67, 0, 0 })]
	[LineNumberTable(new byte[] { 64, 110, 127, 6, 127, 3, 98 })]
	public virtual char[][] toArray()
	{
		char[][] array = new char[max + 1][];
		Iterator iterator = map.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			array[(uint)((Character)entry.getKey()).charValue()] = String.instancehelper_toCharArray((string)entry.getValue());
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 232, 61, 199, 107 })]
	public CharEscaperBuilder()
	{
		max = -1;
		map = new HashMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 49, 103, 111, 41, 166 })]
	public virtual CharEscaperBuilder addEscapes(char[] cs, string r)
	{
		Preconditions.checkNotNull(r);
		int num = cs.Length;
		for (int i = 0; i < num; i++)
		{
			int c = cs[i];
			addEscape((char)c, r);
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(128)]
	public virtual Escaper toEscaper()
	{
		CharArrayDecorator result = new CharArrayDecorator(toArray());
		_ = null;
		return result;
	}
}
