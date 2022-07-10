using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.google.common.@base;

[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<Ljava/lang/Character;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.base.Predicate" })]
public abstract class CharMatcher : java.lang.Object, Predicate, java.util.function.Predicate
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "precomputedInternal", "()Lcom.google.common.base.CharMatcher;")]
	internal class _1 : NegatedFastMatcher
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024description;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(433)]
		internal _1(CharMatcher P_0, CharMatcher P_1, string P_2)
		{
			val_0024description = P_2;
			base._002Ector(P_1);
		}

		public override string toString()
		{
			return val_0024description;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class And : CharMatcher
	{
		[Modifiers(Modifiers.Final)]
		internal CharMatcher first;

		[Modifiers(Modifiers.Final)]
		internal CharMatcher second;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 154, 104, 113, 113 })]
		internal And(CharMatcher P_0, CharMatcher P_1)
		{
			first = (CharMatcher)Preconditions.checkNotNull(P_0);
			second = (CharMatcher)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1555)]
		public override bool matches(char P_0)
		{
			return (first.matches(P_0) && second.matches(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 167, 102, 108, 102, 108, 103, 105 })]
		internal override void setBits(BitSet P_0)
		{
			BitSet bitSet = new BitSet();
			first.setBits(bitSet);
			BitSet bitSet2 = new BitSet();
			second.setBits(bitSet2);
			bitSet.and(bitSet2);
			P_0.or(bitSet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1571)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(first);
			string text2 = java.lang.String.valueOf(second);
			int num = 19 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("CharMatcher.and(").append(text).append(", ")
				.append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1543)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1543)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Any : NamedFastMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Any INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1102)]
		public override CharMatcher negate()
		{
			CharMatcher result = none();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 133, 109 })]
		private Any()
			: base("CharMatcher.any()")
		{
		}

		public override bool matches(char P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1025)]
		public override int indexIn(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			return (charSequence2.length() == 0) ? (-1) : 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 141, 138, 115, 105 })]
		public override int indexIn(CharSequence P_0, int P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num = charSequence2.length();
			Preconditions.checkPositionIndex(P_1, num);
			return (P_1 != num) ? P_1 : (-1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1037)]
		public override int lastIndexIn(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			return charSequence2.length() - 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 138, 138, 103 })]
		public override bool matchesAllOf(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1048)]
		public override bool matchesNoneOf(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			return (charSequence2.length() == 0) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 135, 106, 103 })]
		public override string removeFrom(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			return "";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 134, 172, 120, 104 })]
		public override string replaceFrom(CharSequence P_0, char P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			char[] array = new char[charSequence2.length()];
			Arrays.fill(array, P_1);
			string result = java.lang.String.newhelper(array);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 132, 148, 127, 15, 122, 59, 168 })]
		public override string replaceFrom(CharSequence P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = P_1;
			object __003Cref_003E2 = charSequence2.___003Cref_003E;
			CharSequence s = default(CharSequence);
			object obj = (s.___003Cref_003E = __003Cref_003E);
			int num = s.length();
			obj = (s.___003Cref_003E = __003Cref_003E2);
			StringBuilder stringBuilder = new StringBuilder(num * s.length());
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				obj = (s.___003Cref_003E = __003Cref_003E);
				if (num3 >= s.length())
				{
					break;
				}
				obj = (s.___003Cref_003E = __003Cref_003E2);
				stringBuilder.append(s);
				num2++;
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1075)]
		public override string collapseFrom(CharSequence P_0, char P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = ((charSequence2.length() != 0) ? java.lang.String.valueOf(P_1) : "");
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 128, 74, 103 })]
		public override string trimFrom(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			return "";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1086)]
		public override int countIn(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int result = charSequence2.length();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1091)]
		public override CharMatcher and(CharMatcher P_0)
		{
			return (CharMatcher)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 214, 103 })]
		public override CharMatcher or(CharMatcher P_0)
		{
			Preconditions.checkNotNull(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1010)]
		public override java.util.function.Predicate negate()
		{
			CharMatcher result = this.negate();
			_ = null;
			return result;
		}

		[LineNumberTable(1012)]
		static Any()
		{
			INSTANCE = new Any();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class AnyOf : CharMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char[] chars;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 157, 221, 74, 104, 124, 109 })]
		public AnyOf(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			base._002Ector();
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			chars = java.lang.String.instancehelper_toCharArray(charSequence2.toString());
			Arrays.sort(chars);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1739)]
		public override bool matches(char P_0)
		{
			return Arrays.binarySearch(chars, P_0) >= 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 95, 116, 39, 166 })]
		internal override void setBits(BitSet P_0)
		{
			char[] array = chars;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				int bitIndex = array[i];
				P_0.set(bitIndex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 102, 107, 117, 46, 166, 108 })]
		public override string toString()
		{
			StringBuilder stringBuilder = new StringBuilder("CharMatcher.anyOf(\"");
			char[] array = chars;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				int num2 = array[i];
				stringBuilder.append(access_0024100((char)num2));
			}
			stringBuilder.append("\")");
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1728)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1728)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Ascii : NamedFastMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Ascii INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 147, 109 })]
		internal Ascii()
			: base("CharMatcher.ascii()")
		{
		}

		public override bool matches(char P_0)
		{
			return P_0 <= '\u007f';
		}

		[LineNumberTable(1282)]
		static Ascii()
		{
			INSTANCE = new Ascii();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class BitSetMatcher : NamedFastMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private BitSet table;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(983)]
		internal BitSetMatcher(BitSet P_0, string P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 106, 105, 113, 173, 103 })]
		private BitSetMatcher(BitSet P_0, string P_1)
			: base(P_1)
		{
			if (P_0.length() + 64 < P_0.size())
			{
				P_0 = (BitSet)P_0.clone();
			}
			table = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(998)]
		public override bool matches(char P_0)
		{
			bool result = table.get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 121, 110 })]
		internal override void setBits(BitSet P_0)
		{
			P_0.or(table);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class BreakingWhitespace : CharMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static CharMatcher INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1246)]
		private BreakingWhitespace()
		{
		}

		public override bool matches(char P_0)
		{
			switch (P_0)
			{
			case '\t':
			case '\n':
			case '\v':
			case '\f':
			case '\r':
			case ' ':
			case '\u0085':
			case '\u1680':
			case '\u2028':
			case '\u2029':
			case '\u205f':
			case '\u3000':
				return true;
			case '\u2007':
				return false;
			default:
				return (P_0 >= '\u2000' && P_0 <= '\u200a') ? true : false;
			}
		}

		public override string toString()
		{
			return "CharMatcher.breakingWhitespace()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1246)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1246)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}

		[LineNumberTable(1248)]
		static BreakingWhitespace()
		{
			INSTANCE = new BreakingWhitespace();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Digit : RangesMatcher
	{
		private const string ZEROES = "0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０";

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Digit INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1345)]
		private static char[] zeroes()
		{
			char[] result = java.lang.String.instancehelper_toCharArray("0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０");
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 211, 112, 111, 50, 166 })]
		private static char[] nines()
		{
			char[] array = new char[java.lang.String.instancehelper_length("0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０")];
			for (int i = 0; i < java.lang.String.instancehelper_length("0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０"); i++)
			{
				array[i] = (char)(java.lang.String.instancehelper_charAt("0٠۰߀०০੦૦୦௦౦೦൦෦๐໐༠၀႐០᠐᥆᧐᪀᪐᭐᮰᱀᱐꘠꣐꤀꧐꧰꩐꯰０", i) + 9);
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 221, 119 })]
		private Digit()
			: base("CharMatcher.digit()", zeroes(), nines())
		{
		}

		[LineNumberTable(1356)]
		static Digit()
		{
			INSTANCE = new Digit();
		}
	}

	internal abstract class FastMatcher : CharMatcher
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(949)]
		public override CharMatcher negate()
		{
			NegatedFastMatcher result = new NegatedFastMatcher(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(940)]
		internal FastMatcher()
		{
		}

		public sealed override CharMatcher precomputed()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(940)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(940)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = this.negate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ForPredicate : CharMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<-Ljava/lang/Character;>;")]
		private Predicate predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Predicate<-Ljava/lang/Character;>;)V")]
		[LineNumberTable(new byte[] { 166, 149, 104, 113 })]
		internal ForPredicate(Predicate P_0)
		{
			predicate = (Predicate)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1811)]
		public override bool apply(Character P_0)
		{
			bool result = predicate.apply(Preconditions.checkNotNull(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1805)]
		public override bool matches(char P_0)
		{
			bool result = predicate.apply(Character.valueOf(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1816)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(predicate);
			int num = 26 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("CharMatcher.forPredicate(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1795)]
		public override bool apply(object P_0)
		{
			bool result = apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1795)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class InRange : FastMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char startInclusive;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char endInclusive;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 157, 213, 164, 104, 108, 103, 103 })]
		internal InRange(char P_0, char P_1)
		{
			Preconditions.checkArgument(P_1 >= P_0);
			startInclusive = P_0;
			endInclusive = P_1;
		}

		public override bool matches(char P_0)
		{
			return (startInclusive <= P_0 && P_0 <= endInclusive) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 131, 118 })]
		internal override void setBits(BitSet P_0)
		{
			P_0.set(startInclusive, endInclusive + 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			166,
			136,
			102,
			140,
			byte.MaxValue,
			59,
			61
		})]
		public override string toString()
		{
			string text = access_0024100(startInclusive);
			string text2 = access_0024100(endInclusive);
			int num = 27 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("CharMatcher.inRange('").append(text).append("', '")
				.append(text2)
				.append("')")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Invisible : RangesMatcher
	{
		private const string RANGE_STARTS = "\0\u007f\u00ad\u0600\u061c\u06dd\u070f\u0890\u08e2\u1680\u180e\u2000\u2028\u205f\u2066\u3000\ud800\ufeff\ufff9";

		private const string RANGE_ENDS = " \u00a0\u00ad\u0605\u061c\u06dd\u070f\u0891\u08e2\u1680\u180e\u200f\u202f\u2064\u206f\u3000\uf8ff\ufeff\ufffb";

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Invisible INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 80, 127, 2 })]
		private Invisible()
			: base("CharMatcher.invisible()", java.lang.String.instancehelper_toCharArray("\0\u007f\u00ad\u0600\u061c\u06dd\u070f\u0890\u08e2\u1680\u180e\u2000\u2028\u205f\u2066\u3000\ud800\ufeff\ufff9"), java.lang.String.instancehelper_toCharArray(" \u00a0\u00ad\u0605\u061c\u06dd\u070f\u0891\u08e2\u1680\u180e\u200f\u202f\u2064\u206f\u3000\uf8ff\ufeff\ufffb"))
		{
		}

		[LineNumberTable(1471)]
		static Invisible()
		{
			INSTANCE = new Invisible();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Is : FastMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char match;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 157, 252, 162, 104, 103 })]
		internal Is(char P_0)
		{
			match = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1637)]
		public override CharMatcher negate()
		{
			CharMatcher result = isNot(match);
			_ = null;
			return result;
		}

		public override bool matches(char P_0)
		{
			return P_0 == match;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1622)]
		public override string replaceFrom(CharSequence P_0, char P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = java.lang.String.instancehelper_replace(charSequence2.toString(), match, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1627)]
		public override CharMatcher and(CharMatcher P_0)
		{
			CharMatcher result = ((!P_0.matches(match)) ? none() : this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1632)]
		public override CharMatcher or(CharMatcher P_0)
		{
			CharMatcher result = ((!P_0.matches(match)) ? base.or(P_0) : P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 249, 110 })]
		internal override void setBits(BitSet P_0)
		{
			P_0.set(match);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1648)]
		public override string toString()
		{
			string text = access_0024100(match);
			int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("CharMatcher.is('").append(text).append("')")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1607)]
		public override java.util.function.Predicate negate()
		{
			CharMatcher result = this.negate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class IsEither : FastMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char match1;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char match2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 157, 228, 68, 104, 103, 103 })]
		internal IsEither(char P_0, char P_1)
		{
			match1 = P_0;
			match2 = P_1;
		}

		public override bool matches(char P_0)
		{
			return (P_0 == match1 || P_0 == match2) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 67, 108, 110 })]
		internal override void setBits(BitSet P_0)
		{
			P_0.set(match1);
			P_0.set(match2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1723)]
		public override string toString()
		{
			string text = access_0024100(match1);
			string text2 = access_0024100(match2);
			int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("CharMatcher.anyOf(\"").append(text).append(text2)
				.append("\")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class IsNot : FastMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char match;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 157, 240, 98, 104, 103 })]
		internal IsNot(char P_0)
		{
			match = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1685)]
		public override CharMatcher negate()
		{
			CharMatcher result = @is(match);
			_ = null;
			return result;
		}

		public override bool matches(char P_0)
		{
			return P_0 != match;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1668)]
		public override CharMatcher and(CharMatcher P_0)
		{
			return (!P_0.matches(match)) ? P_0 : base.and(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1673)]
		public override CharMatcher or(CharMatcher P_0)
		{
			return (!P_0.matches(match)) ? this : any();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 29, 109, 117 })]
		internal override void setBits(BitSet P_0)
		{
			P_0.set(0, match);
			P_0.set(match + 1, 65536);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1690)]
		public override string toString()
		{
			string text = access_0024100(match);
			int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("CharMatcher.isNot('").append(text).append("')")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1653)]
		public override java.util.function.Predicate negate()
		{
			CharMatcher result = this.negate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class JavaDigit : CharMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static JavaDigit INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1364)]
		private JavaDigit()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1370)]
		public override bool matches(char P_0)
		{
			bool result = Character.isDigit(P_0);
			_ = null;
			return result;
		}

		public override string toString()
		{
			return "CharMatcher.javaDigit()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1364)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1364)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}

		[LineNumberTable(1366)]
		static JavaDigit()
		{
			INSTANCE = new JavaDigit();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class JavaIsoControl : NamedFastMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static JavaIsoControl INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 55, 109 })]
		private JavaIsoControl()
			: base("CharMatcher.javaIsoControl()")
		{
		}

		public override bool matches(char P_0)
		{
			return (P_0 <= '\u001f' || (P_0 >= '\u007f' && P_0 <= '\u009f')) ? true : false;
		}

		[LineNumberTable(1446)]
		static JavaIsoControl()
		{
			INSTANCE = new JavaIsoControl();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class JavaLetter : CharMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static JavaLetter INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1380)]
		private JavaLetter()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1386)]
		public override bool matches(char P_0)
		{
			bool result = Character.isLetter(P_0);
			_ = null;
			return result;
		}

		public override string toString()
		{
			return "CharMatcher.javaLetter()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1380)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1380)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}

		[LineNumberTable(1382)]
		static JavaLetter()
		{
			INSTANCE = new JavaLetter();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class JavaLetterOrDigit : CharMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static JavaLetterOrDigit INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1396)]
		private JavaLetterOrDigit()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1402)]
		public override bool matches(char P_0)
		{
			bool result = Character.isLetterOrDigit(P_0);
			_ = null;
			return result;
		}

		public override string toString()
		{
			return "CharMatcher.javaLetterOrDigit()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1396)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1396)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}

		[LineNumberTable(1398)]
		static JavaLetterOrDigit()
		{
			INSTANCE = new JavaLetterOrDigit();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class JavaLowerCase : CharMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static JavaLowerCase INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1428)]
		private JavaLowerCase()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1434)]
		public override bool matches(char P_0)
		{
			bool result = Character.isLowerCase(P_0);
			_ = null;
			return result;
		}

		public override string toString()
		{
			return "CharMatcher.javaLowerCase()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1428)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1428)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}

		[LineNumberTable(1430)]
		static JavaLowerCase()
		{
			INSTANCE = new JavaLowerCase();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class JavaUpperCase : CharMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static JavaUpperCase INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1412)]
		private JavaUpperCase()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1418)]
		public override bool matches(char P_0)
		{
			bool result = Character.isUpperCase(P_0);
			_ = null;
			return result;
		}

		public override string toString()
		{
			return "CharMatcher.javaUpperCase()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1412)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1412)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}

		[LineNumberTable(1414)]
		static JavaUpperCase()
		{
			INSTANCE = new JavaUpperCase();
		}
	}

	internal abstract class NamedFastMatcher : FastMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string description;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 76, 104, 113 })]
		internal NamedFastMatcher(string P_0)
		{
			description = (string)Preconditions.checkNotNull(P_0);
		}

		public sealed override string toString()
		{
			return description;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class Negated : CharMatcher
	{
		[Modifiers(Modifiers.Final)]
		internal CharMatcher original;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 104, 104, 113 })]
		internal Negated(CharMatcher P_0)
		{
			original = (CharMatcher)Preconditions.checkNotNull(P_0);
		}

		public override CharMatcher negate()
		{
			return original;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1504)]
		public override bool matches(char P_0)
		{
			return (!original.matches(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1509)]
		public override bool matchesAllOf(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharMatcher charMatcher = original;
			CharSequence sequence = default(CharSequence);
			object obj = (sequence.___003Cref_003E = __003Cref_003E);
			bool result = charMatcher.matchesNoneOf(sequence);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1514)]
		public override bool matchesNoneOf(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharMatcher charMatcher = original;
			CharSequence sequence = default(CharSequence);
			object obj = (sequence.___003Cref_003E = __003Cref_003E);
			bool result = charMatcher.matchesAllOf(sequence);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1519)]
		public override int countIn(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence sequence = default(CharSequence);
			object obj = (sequence.___003Cref_003E = __003Cref_003E);
			int num = sequence.length();
			CharMatcher charMatcher = original;
			obj = (sequence.___003Cref_003E = __003Cref_003E);
			return num - charMatcher.countIn(sequence);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 131, 102, 108, 108, 105 })]
		internal override void setBits(BitSet P_0)
		{
			BitSet bitSet = new BitSet();
			original.setBits(bitSet);
			bitSet.flip(0, 65536);
			P_0.or(bitSet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1538)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(original);
			int num = 9 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append(text).append(".negate()").toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1494)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1494)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = this.negate();
			_ = null;
			return result;
		}
	}

	internal class NegatedFastMatcher : Negated
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 90, 105 })]
		internal NegatedFastMatcher(CharMatcher P_0)
			: base(P_0)
		{
		}

		public sealed override CharMatcher precomputed()
		{
			return this;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class None : NamedFastMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static None INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1205)]
		public override CharMatcher negate()
		{
			CharMatcher result = any();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 230, 109 })]
		private None()
			: base("CharMatcher.none()")
		{
		}

		public override bool matches(char P_0)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 118, 138, 103 })]
		public override int indexIn(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 116, 74, 115, 105 })]
		public override int indexIn(CharSequence P_0, int P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int size = charSequence2.length();
			Preconditions.checkPositionIndex(P_1, size);
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 115, 170, 103 })]
		public override int lastIndexIn(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1141)]
		public override bool matchesAllOf(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			return (charSequence2.length() == 0) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 112, 138, 103 })]
		public override bool matchesNoneOf(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1152)]
		public override string removeFrom(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = charSequence2.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1157)]
		public override string replaceFrom(CharSequence P_0, char P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = charSequence2.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 108, 148, 103 })]
		public override string replaceFrom(CharSequence P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = P_0;
			object __003Cref_003E2 = charSequence2.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			CharSequence charSequence3 = default(CharSequence);
			object obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			string result = charSequence3.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1168)]
		public override string collapseFrom(CharSequence P_0, char P_1)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = charSequence2.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1173)]
		public override string trimFrom(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = charSequence2.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1178)]
		public override string trimLeadingFrom(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = charSequence2.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1183)]
		public override string trimTrailingFrom(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = charSequence2.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 101, 74, 103 })]
		public override int countIn(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			Preconditions.checkNotNull(__003Cref_003E);
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 56, 103 })]
		public override CharMatcher and(CharMatcher P_0)
		{
			Preconditions.checkNotNull(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1200)]
		public override CharMatcher or(CharMatcher P_0)
		{
			return (CharMatcher)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1107)]
		public override java.util.function.Predicate negate()
		{
			CharMatcher result = this.negate();
			_ = null;
			return result;
		}

		[LineNumberTable(1109)]
		static None()
		{
			INSTANCE = new None();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class Or : CharMatcher
	{
		[Modifiers(Modifiers.Final)]
		internal CharMatcher first;

		[Modifiers(Modifiers.Final)]
		internal CharMatcher second;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 187, 104, 113, 113 })]
		internal Or(CharMatcher P_0, CharMatcher P_1)
		{
			first = (CharMatcher)Preconditions.checkNotNull(P_0);
			second = (CharMatcher)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 195, 108, 110 })]
		internal override void setBits(BitSet P_0)
		{
			first.setBits(P_0);
			second.setBits(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1595)]
		public override bool matches(char P_0)
		{
			return (first.matches(P_0) || second.matches(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1600)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(first);
			string text2 = java.lang.String.valueOf(second);
			int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("CharMatcher.or(").append(text).append(", ")
				.append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1576)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1576)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class RangesMatcher : CharMatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string description;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char[] rangeStarts;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private char[] rangeEnds;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			164, 163, 104, 103, 103, 103, 107, 103, 112, 103,
			239, 61, 230, 70
		})]
		internal RangesMatcher(string P_0, char[] P_1, char[] P_2)
		{
			description = P_0;
			rangeStarts = P_1;
			rangeEnds = P_2;
			Preconditions.checkArgument((nint)P_1.LongLength == (nint)P_2.LongLength);
			for (int i = 0; i < (nint)P_1.LongLength; i++)
			{
				Preconditions.checkArgument(P_1[i] <= P_2[i]);
				if (i + 1 < (nint)P_1.LongLength)
				{
					Preconditions.checkArgument(P_2[i] < P_1[i + 1]);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 69, 66, 109, 100, 130, 102 })]
		public override bool matches(char P_0)
		{
			int num = Arrays.binarySearch(rangeStarts, P_0);
			if (num >= 0)
			{
				return true;
			}
			num = (num ^ -1) - 1;
			return (num >= 0 && P_0 <= rangeEnds[num]) ? true : false;
		}

		public override string toString()
		{
			return description;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1295)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public override bool apply(object P_0)
		{
			bool result = base.apply((Character)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1295)]
		public new virtual java.util.function.Predicate negate()
		{
			CharMatcher result = base.negate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class SingleWidth : RangesMatcher
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static SingleWidth INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 90, 139, 106, 229, 61, 199 })]
		private SingleWidth()
			: base("CharMatcher.singleWidth()", java.lang.String.instancehelper_toCharArray("\0־א׳\u0600ݐ\u0e00Ḁ℀ﭐﹰ｡"), java.lang.String.instancehelper_toCharArray("ӹ־ת״ۿݿ\u0e7f₯℺\ufdff\ufeffￜ"))
		{
		}

		[LineNumberTable(1481)]
		static SingleWidth()
		{
			INSTANCE = new SingleWidth();
		}
	}

	internal sealed class Whitespace : NamedFastMatcher
	{
		internal const string TABLE = "\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\v\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001\u202f\u00a0\f\u2009\u3000\u2004\u3000\u3000\u2028\n\u2007\u3000";

		internal const int MULTIPLIER = 1682554634;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static int SHIFT;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static Whitespace INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 90, 109 })]
		internal Whitespace()
			: base("CharMatcher.whitespace()")
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1233)]
		public override bool matches(char P_0)
		{
			return java.lang.String.instancehelper_charAt("\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\v\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001\u202f\u00a0\f\u2009\u3000\u2004\u3000\u3000\u2028\n\u2007\u3000", (int)((uint)(1682554634 * P_0) >> SHIFT)) == P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 101, 111, 49, 166 })]
		internal override void setBits(BitSet P_0)
		{
			for (int i = 0; i < java.lang.String.instancehelper_length("\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\v\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001\u202f\u00a0\f\u2009\u3000\u2004\u3000\u3000\u2028\n\u2007\u3000"); i++)
			{
				P_0.set(java.lang.String.instancehelper_charAt("\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\v\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001\u202f\u00a0\f\u2009\u3000\u2004\u3000\u3000\u2028\n\u2007\u3000", i));
			}
		}

		[LineNumberTable(new byte[] { 164, 85, 150 })]
		static Whitespace()
		{
			SHIFT = Integer.numberOfLeadingZeros(java.lang.String.instancehelper_length("\u2002\u3000\r\u0085\u200a\u2005\u2000\u3000\u2029\v\u3000\u2008\u2003\u205f\u3000\u1680\t \u2006\u2001\u202f\u00a0\f\u2009\u3000\u2004\u3000\u3000\u2028\n\u2007\u3000") - 1);
			INSTANCE = new Whitespace();
		}
	}

	private const int DISTINCT_CHARS = 65536;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 2, 138, 115, 105, 105, 127, 0, 3, 232,
		69
	})]
	public virtual int indexIn(CharSequence sequence, int start)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		Preconditions.checkPositionIndex(start, num);
		for (int i = start; i < num; i++)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (matches(charSequence2.charAt(i2)))
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(296)]
	public static CharMatcher @is(char match)
	{
		Is result = new Is(match);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(343)]
	public static CharMatcher inRange(char startInclusive, char endInclusive)
	{
		InRange result = new InRange(startInclusive, endInclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 166, 66, 102, 127, 2, 102, 111, 5, 198 })]
	private static string showCharacter(char P_0)
	{
		int num = P_0;
		string @this = "0123456789ABCDEF";
		char[] array = new char[6] { '\\', 'u', '\0', '\0', '\0', '\0' };
		for (int i = 0; i < 4; i++)
		{
			array[5 - i] = java.lang.String.instancehelper_charAt(@this, num & 0xF);
			num = (ushort)(num >> 4);
		}
		string result = java.lang.String.copyValueOf(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(128)]
	public static CharMatcher none()
	{
		return None.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1695)]
	private static IsEither isEither(char P_0, char P_1)
	{
		IsEither result = new IsEither(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 64, 106, 159, 8, 136, 158, 223, 21 })]
	public static CharMatcher anyOf(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		switch (charSequence2.length())
		{
		case 0:
		{
			CharMatcher result4 = none();
			_ = null;
			return result4;
		}
		case 1:
		{
			int i = 0;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			CharMatcher result3 = @is(charSequence2.charAt(i));
			_ = null;
			return result3;
		}
		case 2:
		{
			int i = 0;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			char num = charSequence2.charAt(i);
			i = 1;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			IsEither result2 = isEither(num, charSequence2.charAt(i));
			_ = null;
			return result2;
		}
		default:
		{
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			AnyOf result = new AnyOf(charSequence2);
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(373)]
	public virtual CharMatcher negate()
	{
		Negated result = new Negated(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 104, 106, 106, 7, 230, 69 })]
	internal virtual void setBits(BitSet P_0)
	{
		for (int i = 65535; i >= 0; i += -1)
		{
			if (matches((char)i))
			{
				P_0.set(i);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(920)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 78, 148, 136, 144, 105, 107, 138, 110, 105,
		10
	})]
	private static CharMatcher precomputedPositive(int P_0, BitSet P_1, string P_2)
	{
		switch (P_0)
		{
		case 0:
		{
			CharMatcher result3 = none();
			_ = null;
			return result3;
		}
		case 1:
		{
			CharMatcher result2 = @is((char)P_1.nextSetBit(0));
			_ = null;
			return result2;
		}
		case 2:
		{
			int num = (ushort)P_1.nextSetBit(0);
			int num2 = (ushort)P_1.nextSetBit(num + 1);
			IsEither result4 = isEither((char)num, (char)num2);
			_ = null;
			return result4;
		}
		default:
		{
			CharMatcher result = ((!isSmall(P_0, P_1.length())) ? new BitSetMatcher(P_1, P_2, null) : SmallCharMatcher.from(P_1, P_2));
			_ = null;
			return result;
		}
		}
	}

	private static bool isSmall(int P_0, int P_1)
	{
		return (P_0 <= 1023 && P_1 > P_0 * 4 * 16) ? true : false;
	}

	public abstract bool matches(char ch);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(529)]
	public virtual bool matchesNoneOf(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence sequence2 = default(CharSequence);
		object obj = (sequence2.___003Cref_003E = __003Cref_003E);
		return indexIn(sequence2) == -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(543)]
	public virtual int indexIn(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		int start = 0;
		CharSequence sequence2 = default(CharSequence);
		object obj = (sequence2.___003Cref_003E = __003Cref_003E);
		int result = indexIn(sequence2, start);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 244, 106, 115, 122, 101, 163, 105, 227, 69,
		134, 103, 130, 109, 130, 109, 136, 136
	})]
	public virtual string removeFrom(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence sequence2 = default(CharSequence);
		object obj = (sequence2.___003Cref_003E = __003Cref_003E);
		string text = sequence2.toString();
		obj = (sequence2.___003Cref_003E = text);
		int num = indexIn(sequence2);
		if (num == -1)
		{
			return text;
		}
		char[] array = java.lang.String.instancehelper_toCharArray(text);
		int num2 = 1;
		while (true)
		{
			num++;
			while (true)
			{
				if ((nint)num != (nint)array.LongLength)
				{
					if (matches(array[num]))
					{
						break;
					}
					array[num - num2] = array[num];
					num++;
					continue;
				}
				string result = java.lang.String.newhelper(array, 0, num - num2);
				_ = null;
				return result;
			}
			num2++;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 229, 172, 115, 122, 101, 131, 105, 102, 109,
		109, 6, 232, 69
	})]
	public virtual string replaceFrom(CharSequence sequence, char replacement)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence sequence2 = default(CharSequence);
		object obj = (sequence2.___003Cref_003E = __003Cref_003E);
		string text = sequence2.toString();
		obj = (sequence2.___003Cref_003E = text);
		int num = indexIn(sequence2);
		if (num == -1)
		{
			return text;
		}
		char[] array = java.lang.String.instancehelper_toCharArray(text);
		array[num] = replacement;
		for (int i = num + 1; i < (nint)array.LongLength; i++)
		{
			if (matches(array[i]))
			{
				array[i] = replacement;
			}
		}
		string result = java.lang.String.newhelper(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 176, 112, 104, 123, 106, 99, 105, 164, 106,
		226, 55, 235, 76
	})]
	private string finishCollapseFrom(CharSequence P_0, int P_1, int P_2, char P_3, StringBuilder P_4, bool P_5)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		int num = (P_5 ? 1 : 0);
		CharSequence charSequence2 = default(CharSequence);
		for (int i = P_1; i < P_2; i++)
		{
			int i2 = i;
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num2 = charSequence2.charAt(i2);
			if (matches((char)num2))
			{
				if (num == 0)
				{
					P_4.append(P_3);
					num = 1;
				}
			}
			else
			{
				P_4.append((char)num2);
				num = 0;
			}
		}
		string result = P_4.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158,
		188,
		76,
		115,
		108,
		121,
		109,
		159,
		15,
		139,
		127,
		17,
		byte.MaxValue,
		25,
		56,
		235,
		77
	})]
	public virtual string collapseFrom(CharSequence sequence, char replacement)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		for (int i = 0; i < num; i++)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			int num2 = charSequence2.charAt(i2);
			if (!matches((char)num2))
			{
				continue;
			}
			if (num2 == replacement)
			{
				if (i != num - 1)
				{
					i2 = i + 1;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					if (matches(charSequence2.charAt(i2)))
					{
						goto IL_008a;
					}
				}
				i++;
				continue;
			}
			goto IL_008a;
			IL_008a:
			StringBuilder stringBuilder = new StringBuilder(num);
			int end = i;
			i2 = 0;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			StringBuilder stringBuilder2 = stringBuilder.append(charSequence2, i2, end).append(replacement);
			int num3 = i + 1;
			bool flag = true;
			StringBuilder stringBuilder3 = stringBuilder2;
			char c = replacement;
			end = num;
			i2 = num3;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string result = finishCollapseFrom(charSequence2, i2, end, c, stringBuilder3, flag);
			_ = null;
			return result;
		}
		obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		string result2 = charSequence2.toString();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(911)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual bool apply(Character character)
	{
		bool result = matches(character.charValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(119)]
	public static CharMatcher any()
	{
		return Any.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(146)]
	public static CharMatcher whitespace()
	{
		return Whitespace.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(157)]
	public static CharMatcher breakingWhitespace()
	{
		return BreakingWhitespace.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(166)]
	public static CharMatcher ascii()
	{
		return Ascii.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(179)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CharMatcher digit()
	{
		return Digit.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(192)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CharMatcher javaDigit()
	{
		return JavaDigit.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(205)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CharMatcher javaLetter()
	{
		return JavaLetter.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(217)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CharMatcher javaLetterOrDigit()
	{
		return JavaLetterOrDigit.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(230)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CharMatcher javaUpperCase()
	{
		return JavaUpperCase.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(243)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CharMatcher javaLowerCase()
	{
		return JavaLowerCase.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(255)]
	public static CharMatcher javaIsoControl()
	{
		return JavaIsoControl.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(271)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CharMatcher invisible()
	{
		return Invisible.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(289)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CharMatcher singleWidth()
	{
		return SingleWidth.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(305)]
	public static CharMatcher isNot(char match)
	{
		IsNot result = new IsNot(match);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(332)]
	public static CharMatcher noneOf(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence sequence2 = default(CharSequence);
		object obj = (sequence2.___003Cref_003E = __003Cref_003E);
		CharMatcher result = anyOf(sequence2).negate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Predicate<-Ljava/lang/Character;>;)Lcom/google/common/base/CharMatcher;")]
	[LineNumberTable(351)]
	public static CharMatcher forPredicate(Predicate predicate)
	{
		CharMatcher result = ((!(predicate is CharMatcher)) ? new ForPredicate(predicate) : ((CharMatcher)predicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(360)]
	protected internal CharMatcher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(380)]
	public virtual CharMatcher and(CharMatcher other)
	{
		And result = new And(this, other);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(387)]
	public virtual CharMatcher or(CharMatcher other)
	{
		Or result = new Or(this, other);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(400)]
	public virtual CharMatcher precomputed()
	{
		CharMatcher result = Platform.precomputeCharMatcher(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 47, 102, 103, 103, 106, 176, 108, 104, 102,
		136, 106, 120, 127, 13, 101, 46
	})]
	internal virtual CharMatcher precomputedInternal()
	{
		BitSet bitSet = new BitSet();
		setBits(bitSet);
		int num = bitSet.cardinality();
		if (num * 2 <= 65536)
		{
			CharMatcher result = precomputedPositive(num, bitSet, toString());
			_ = null;
			return result;
		}
		bitSet.flip(0, 65536);
		int num2 = 65536 - num;
		string text = ".negate()";
		string text2 = toString();
		string text3;
		if (java.lang.String.instancehelper_endsWith(text2, text))
		{
			text3 = java.lang.String.instancehelper_substring(text2, 0, java.lang.String.instancehelper_length(text2) - java.lang.String.instancehelper_length(text));
		}
		else
		{
			string text4 = java.lang.String.valueOf(text2);
			string text5 = java.lang.String.valueOf(text);
			if (java.lang.String.instancehelper_length(text5) != 0)
			{
				text3 = java.lang.String.instancehelper_concat(text4, text5);
			}
			else
			{
				string text6 = text4;
				text6 = text6;
				text3 = java.lang.String.newhelper(text6);
			}
		}
		string text7 = text3;
		_1 result2 = new _1(this, precomputedPositive(num2, bitSet, text7), text2);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(495)]
	public virtual bool matchesAnyOf(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence sequence2 = default(CharSequence);
		object obj = (sequence2.___003Cref_003E = __003Cref_003E);
		return (!matchesNoneOf(sequence2)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 15, 106, 122, 127, 0, 2, 232, 69 })]
	public virtual bool matchesAllOf(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		for (int i = charSequence2.length() - 1; i >= 0; i += -1)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (!matches(charSequence2.charAt(i2)))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 253, 170, 122, 127, 0, 3, 232, 69 })]
	public virtual int lastIndexIn(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		for (int i = charSequence2.length() - 1; i >= 0; i += -1)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (matches(charSequence2.charAt(i2)))
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 249, 106, 98, 120, 127, 1, 4, 230, 69 })]
	public virtual int countIn(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		int num = 0;
		int num2 = 0;
		CharSequence charSequence2 = default(CharSequence);
		while (true)
		{
			int num3 = num2;
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (num3 >= charSequence2.length())
			{
				break;
			}
			int i = num2;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (matches(charSequence2.charAt(i)))
			{
				num++;
			}
			num2++;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(656)]
	public virtual string retainFrom(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharMatcher charMatcher = negate();
		CharSequence sequence2 = default(CharSequence);
		object obj = (sequence2.___003Cref_003E = __003Cref_003E);
		string result = charMatcher.removeFrom(sequence2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 220, 116, 117, 100, 156, 101, 191, 25, 117,
		124, 101, 163, 105, 144, 131, 127, 9, 123, 102,
		127, 3, 136, 127, 9
	})]
	public virtual string replaceFrom(CharSequence sequence, CharSequence replacement)
	{
		CharSequence charSequence = replacement;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = sequence;
		object __003Cref_003E2 = charSequence2.___003Cref_003E;
		CharSequence charSequence3 = default(CharSequence);
		object obj = (charSequence3.___003Cref_003E = __003Cref_003E);
		switch (charSequence3.length())
		{
		case 0:
		{
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			string result3 = removeFrom(charSequence3);
			_ = null;
			return result3;
		}
		case 1:
		{
			int start = 0;
			obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			char replacement2 = charSequence3.charAt(start);
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			string result2 = replaceFrom(charSequence3, replacement2);
			_ = null;
			return result2;
		}
		default:
		{
			obj = (charSequence3.___003Cref_003E = __003Cref_003E2);
			string text = charSequence3.toString();
			obj = (charSequence3.___003Cref_003E = text);
			int num = indexIn(charSequence3);
			if (num == -1)
			{
				return text;
			}
			int num2 = java.lang.String.instancehelper_length(text);
			StringBuilder stringBuilder = new StringBuilder(num2 * 3 / 2 + 16);
			int num3 = 0;
			int end;
			int start;
			do
			{
				int num4 = num3;
				end = num;
				start = num4;
				obj = (charSequence3.___003Cref_003E = text);
				stringBuilder.append(charSequence3, start, end);
				obj = (charSequence3.___003Cref_003E = __003Cref_003E);
				stringBuilder.append(charSequence3);
				num3 = num + 1;
				start = num3;
				obj = (charSequence3.___003Cref_003E = text);
				num = indexIn(charSequence3, start);
			}
			while (num != -1);
			int num5 = num3;
			end = num2;
			start = num5;
			obj = (charSequence3.___003Cref_003E = text);
			stringBuilder.append(charSequence3, start, end);
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 208, 106, 211, 105, 127, 0, 2, 232, 69,
		108, 127, 0, 2, 232, 70
	})]
	public virtual string trimFrom(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		int i;
		int i2;
		for (i = 0; i < num; i++)
		{
			i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (!matches(charSequence2.charAt(i2)))
			{
				break;
			}
		}
		int j;
		for (j = num - 1; j > i; j += -1)
		{
			i2 = j;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (!matches(charSequence2.charAt(i2)))
			{
				break;
			}
		}
		int num2 = i;
		int i3 = j + 1;
		i2 = num2;
		obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		obj = (charSequence2.___003Cref_003E = charSequence2.subSequence(i2, i3).___003Cref_003E);
		string result = charSequence2.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 201, 138, 115, 108, 127, 0, 31, 26, 235,
		69
	})]
	public virtual string trimLeadingFrom(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		for (int i = 0; i < num; i++)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (!matches(charSequence2.charAt(i2)))
			{
				int num2 = i;
				int i3 = num;
				i2 = num2;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				obj = (charSequence2.___003Cref_003E = charSequence2.subSequence(i2, i3).___003Cref_003E);
				string result = charSequence2.toString();
				_ = null;
				return result;
			}
		}
		return "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 196, 138, 115, 110, 127, 0, 31, 27, 235,
		69
	})]
	public virtual string trimTrailingFrom(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		for (int i = num - 1; i >= 0; i += -1)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (!matches(charSequence2.charAt(i2)))
			{
				int i3 = i + 1;
				i2 = 0;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				obj = (charSequence2.___003Cref_003E = charSequence2.subSequence(i2, i3).___003Cref_003E);
				string result = charSequence2.toString();
				_ = null;
				return result;
			}
		}
		return "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 182, 76, 115, 99, 134, 127, 6, 168, 127,
		6, 168, 108, 126, 31, 34
	})]
	public virtual string trimAndCollapseFrom(CharSequence sequence, char replacement)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		int num = charSequence2.length();
		int i = 0;
		int j = num - 1;
		for (; i < num; i++)
		{
			int i2 = i;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (!matches(charSequence2.charAt(i2)))
			{
				break;
			}
		}
		for (; j > i; j += -1)
		{
			int i2 = j;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			if (!matches(charSequence2.charAt(i2)))
			{
				break;
			}
		}
		string result;
		if (i == 0 && j == num - 1)
		{
			char replacement2 = replacement;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			result = collapseFrom(charSequence2, replacement2);
		}
		else
		{
			int num2 = i;
			int num3 = j + 1;
			StringBuilder stringBuilder = new StringBuilder(j + 1 - i);
			bool flag = false;
			StringBuilder stringBuilder2 = stringBuilder;
			char replacement2 = replacement;
			int num4 = num3;
			int i2 = num2;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			result = finishCollapseFrom(charSequence2, i2, num4, replacement2, stringBuilder2, flag);
		}
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual bool apply(object obj)
	{
		bool result = apply((Character)obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual java.util.function.Predicate _003Cbridge_003Enegate()
	{
		CharMatcher result = negate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(65)]
	internal static string access_0024100(char P_0)
	{
		string result = showCharacter(P_0);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool test(object P_0)
	{
		return Predicate._003Cdefault_003Etest(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
	{
		return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
	{
		return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
	}

	bool Predicate.Predicate_003A_003Aequals(object P_0)
	{
		return java.lang.Object.instancehelper_equals(this, P_0);
	}

	java.util.function.Predicate java.util.function.Predicate.Predicate_003A_003Anegate()
	{
		return _003Cbridge_003Enegate();
	}
}
