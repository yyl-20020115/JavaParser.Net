using System.Collections;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.regex;
using java.util.stream;
using javax.annotation;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Splitter : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "on", "(Lcom.google.common.base.CharMatcher;)Lcom.google.common.base.Splitter;")]
	internal class _1 : Object, Strategy
	{
		[SpecialName]
		[EnclosingMethod(null, "iterator", "(Lcom.google.common.base.Splitter;Ljava.lang.CharSequence;)Lcom.google.common.base.Splitter$SplittingIterator;")]
		internal class _1 : SplittingIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Splitter._1 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(149)]
			internal _1(Splitter._1 P_0, Splitter P_1, CharSequence P_2)
			{
				CharSequence charSequence = P_2;
				object __003Cref_003E = charSequence.___003Cref_003E;
				this_00240 = P_0;
				CharSequence charSequence2 = default(CharSequence);
				charSequence2.___003Cref_003E = __003Cref_003E;
				base._002Ector(P_1, charSequence2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(152)]
			internal override int separatorStart(int P_0)
			{
				CharMatcher val_0024separatorMatcher = this_00240.val_0024separatorMatcher;
				CharSequence charSequence = toSplit;
				CharSequence sequence = default(CharSequence);
				object obj = (sequence.___003Cref_003E = charSequence.___003Cref_003E);
				int result = val_0024separatorMatcher.indexIn(sequence, P_0);
				_ = null;
				return result;
			}

			internal override int separatorEnd(int P_0)
			{
				return P_0 + 1;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CharMatcher val_0024separatorMatcher;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(149)]
		public virtual SplittingIterator iterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			_1 result = new _1(this, P_0, charSequence2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(146)]
		internal _1(CharMatcher P_0)
		{
			val_0024separatorMatcher = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(146)]
		public virtual Iterator iterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			SplittingIterator result = this.iterator(P_0, charSequence2);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "on", "(Ljava.lang.String;)Lcom.google.common.base.Splitter;")]
	internal class _2 : Object, Strategy
	{
		[SpecialName]
		[EnclosingMethod(null, "iterator", "(Lcom.google.common.base.Splitter;Ljava.lang.CharSequence;)Lcom.google.common.base.Splitter$SplittingIterator;")]
		internal class _1 : SplittingIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _2 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(181)]
			internal _1(_2 P_0, Splitter P_1, CharSequence P_2)
			{
				CharSequence charSequence = P_2;
				object __003Cref_003E = charSequence.___003Cref_003E;
				this_00240 = P_0;
				CharSequence charSequence2 = default(CharSequence);
				charSequence2.___003Cref_003E = __003Cref_003E;
				base._002Ector(P_1, charSequence2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				160, 70, 177, 127, 13, 104, 127, 28, 2, 232,
				69, 226, 58, 233, 72
			})]
			public override int separatorStart(int P_0)
			{
				int num = String.instancehelper_length(this_00240.val_0024separator);
				int i = P_0;
				CharSequence charSequence = toSplit;
				CharSequence charSequence2 = default(CharSequence);
				object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
				for (int num2 = charSequence2.length() - num; i <= num2; i++)
				{
					int num3 = 0;
					while (true)
					{
						if (num3 < num)
						{
							CharSequence charSequence3 = toSplit;
							object __003Cref_003E = charSequence3.___003Cref_003E;
							int i2 = num3 + i;
							obj = (charSequence2.___003Cref_003E = __003Cref_003E);
							if (charSequence2.charAt(i2) != String.instancehelper_charAt(this_00240.val_0024separator, num3))
							{
								break;
							}
							num3++;
							continue;
						}
						return i;
					}
				}
				return -1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(200)]
			public override int separatorEnd(int P_0)
			{
				return P_0 + String.instancehelper_length(this_00240.val_0024separator);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal string val_0024separator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(178)]
		internal _2(string P_0)
		{
			val_0024separator = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(181)]
		public virtual SplittingIterator iterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			_1 result = new _1(this, P_0, charSequence2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(178)]
		public virtual Iterator iterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			SplittingIterator result = this.iterator(P_0, charSequence2);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "on", "(Lcom.google.common.base.CommonPattern;)Lcom.google.common.base.Splitter;")]
	internal class _3 : Object, Strategy
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "iterator", "(Lcom.google.common.base.Splitter;Ljava.lang.CharSequence;)Lcom.google.common.base.Splitter$SplittingIterator;")]
		internal class _1 : SplittingIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal CommonMatcher val_0024matcher;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(233)]
			internal _1(_3 P_0, Splitter P_1, CharSequence P_2, CommonMatcher P_3)
			{
				CharSequence charSequence = P_2;
				object __003Cref_003E = charSequence.___003Cref_003E;
				val_0024matcher = P_3;
				CharSequence charSequence2 = default(CharSequence);
				charSequence2.___003Cref_003E = __003Cref_003E;
				base._002Ector(P_1, charSequence2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(236)]
			public override int separatorStart(int P_0)
			{
				return (!val_0024matcher.find(P_0)) ? (-1) : val_0024matcher.start();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(241)]
			public override int separatorEnd(int P_0)
			{
				int result = val_0024matcher.end();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CommonPattern val_0024separatorPattern;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(229)]
		internal _3(CommonPattern P_0)
		{
			val_0024separatorPattern = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 84, 74, 126 })]
		public virtual SplittingIterator iterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CommonPattern commonPattern = val_0024separatorPattern;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			CommonMatcher commonMatcher = commonPattern.matcher(charSequence2);
			CommonMatcher commonMatcher2 = commonMatcher;
			obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			_1 result = new _1(this, P_0, charSequence2, commonMatcher2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(229)]
		public virtual Iterator iterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			SplittingIterator result = this.iterator(P_0, charSequence2);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "fixedLength", "(I)Lcom.google.common.base.Splitter;")]
	internal class _4 : Object, Strategy
	{
		[SpecialName]
		[EnclosingMethod(null, "iterator", "(Lcom.google.common.base.Splitter;Ljava.lang.CharSequence;)Lcom.google.common.base.Splitter$SplittingIterator;")]
		internal class _1 : SplittingIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _4 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(290)]
			internal _1(_4 P_0, Splitter P_1, CharSequence P_2)
			{
				CharSequence charSequence = P_2;
				object __003Cref_003E = charSequence.___003Cref_003E;
				this_00240 = P_0;
				CharSequence charSequence2 = default(CharSequence);
				charSequence2.___003Cref_003E = __003Cref_003E;
				base._002Ector(P_1, charSequence2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 179, 110 })]
			public override int separatorStart(int P_0)
			{
				int num = P_0 + this_00240.val_0024length;
				CharSequence charSequence = toSplit;
				CharSequence charSequence2 = default(CharSequence);
				object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
				return (num >= charSequence2.length()) ? (-1) : num;
			}

			public override int separatorEnd(int P_0)
			{
				return P_0;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024length;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(287)]
		internal _4(int P_0)
		{
			val_0024length = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(290)]
		public virtual SplittingIterator iterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			_1 result = new _1(this, P_0, charSequence2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(287)]
		public virtual Iterator iterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			SplittingIterator result = this.iterator(P_0, charSequence2);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/lang/Iterable<Ljava/lang/String;>;")]
	[EnclosingMethod(null, "split", "(Ljava.lang.CharSequence;)Ljava.lang.Iterable;")]
	[Implements(new string[] { "java.lang.Iterable" })]
	internal class _5 : Object, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CharSequence val_0024sequence;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Splitter this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(387)]
		internal _5(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			this_00240 = P_0;
			CharSequence charSequence2 = default(CharSequence);
			charSequence2.___003Cref_003E = __003Cref_003E;
			val_0024sequence = charSequence2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/lang/String;>;")]
		[LineNumberTable(390)]
		public virtual Iterator iterator()
		{
			Splitter splitter = this_00240;
			CharSequence charSequence = val_0024sequence;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
			Iterator result = access_0024000(splitter, charSequence2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 25, 113, 109, 101, 231, 61 })]
		public override string toString()
		{
			string result = Joiner.on(", ").appendTo(new StringBuilder().append('['), this).append(']')
				.toString();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Spliterator spliterator()
		{
			return Iterable._003Cdefault_003Espliterator(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}
	}

	public sealed class MapSplitter : Object
	{
		private const string INVALID_ENTRY_MESSAGE = "Chunk [%s] is not a valid entry";

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Splitter outerSplitter;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Splitter entrySplitter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(498)]
		internal MapSplitter(Splitter P_0, Splitter P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 133, 104, 103, 113 })]
		private MapSplitter(Splitter P_0, Splitter P_1)
		{
			outerSplitter = P_0;
			entrySplitter = (Splitter)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/CharSequence;)Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;")]
		[LineNumberTable(new byte[]
		{
			159, 12, 74, 102, 127, 30, 159, 0, 115, 110,
			154, 115, 110, 139, 121, 101
		})]
		public virtual Map split(CharSequence sequence)
		{
			CharSequence charSequence = sequence;
			object __003Cref_003E = charSequence.___003Cref_003E;
			LinkedHashMap linkedHashMap = new LinkedHashMap();
			Splitter splitter = outerSplitter;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			Iterator iterator = splitter.split(charSequence2).iterator();
			while (iterator.hasNext())
			{
				string text = (string)iterator.next();
				Splitter splitter2 = entrySplitter;
				obj = (charSequence2.___003Cref_003E = text);
				Iterator iterator2 = access_0024000(splitter2, charSequence2);
				Preconditions.checkArgument(iterator2.hasNext(), "Chunk [%s] is not a valid entry", text);
				string text2 = (string)iterator2.next();
				Preconditions.checkArgument((!((Map)linkedHashMap).containsKey((object)text2)) ? true : false, "Duplicate key [%s] found.", text2);
				Preconditions.checkArgument(iterator2.hasNext(), "Chunk [%s] is not a valid entry", text);
				string value = (string)iterator2.next();
				((Map)linkedHashMap).put((object)text2, (object)value);
				Preconditions.checkArgument((!iterator2.hasNext()) ? true : false, "Chunk [%s] is not a valid entry", text);
			}
			Map result = Collections.unmodifiableMap(linkedHashMap);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("Lcom/google/common/base/AbstractIterator<Ljava/lang/String;>;")]
	internal abstract class SplittingIterator : AbstractIterator
	{
		[Modifiers(Modifiers.Final)]
		internal CharSequence toSplit;

		[Modifiers(Modifiers.Final)]
		internal CharMatcher trimmer;

		[Modifiers(Modifiers.Final)]
		internal bool omitEmptyStrings;

		internal int offset;

		internal int limit;

		internal abstract int separatorStart(int P_0);

		internal abstract int separatorEnd(int P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 207, 103, 108, 162, 109, 100, 127, 3, 137,
			99, 141, 233, 71, 110, 127, 13, 236, 69, 127,
			25, 134, 127, 28, 168, 141, 103, 165, 204, 127,
			4, 135, 127, 28, 168, 174, 159, 43
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal new virtual string computeNext()
		{
			int num = offset;
			CharSequence charSequence2 = default(CharSequence);
			while (offset != -1)
			{
				int i = num;
				int num2 = separatorStart(offset);
				int j;
				object obj;
				if (num2 == -1)
				{
					CharSequence charSequence = toSplit;
					obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
					j = charSequence2.length();
					offset = -1;
				}
				else
				{
					j = num2;
					offset = separatorEnd(num2);
				}
				if (offset == num)
				{
					offset++;
					int num3 = offset;
					CharSequence charSequence3 = toSplit;
					obj = (charSequence2.___003Cref_003E = charSequence3.___003Cref_003E);
					if (num3 > charSequence2.length())
					{
						offset = -1;
					}
					continue;
				}
				int i2;
				for (; i < j; i++)
				{
					CharMatcher charMatcher = trimmer;
					CharSequence charSequence4 = toSplit;
					object __003Cref_003E = charSequence4.___003Cref_003E;
					i2 = i;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E);
					if (!charMatcher.matches(charSequence2.charAt(i2)))
					{
						break;
					}
				}
				for (; j > i; j += -1)
				{
					CharMatcher charMatcher2 = trimmer;
					CharSequence charSequence5 = toSplit;
					object __003Cref_003E2 = charSequence5.___003Cref_003E;
					i2 = j - 1;
					obj = (charSequence2.___003Cref_003E = __003Cref_003E2);
					if (!charMatcher2.matches(charSequence2.charAt(i2)))
					{
						break;
					}
				}
				if (omitEmptyStrings && i == j)
				{
					num = offset;
					continue;
				}
				if (limit == 1)
				{
					CharSequence charSequence6 = toSplit;
					obj = (charSequence2.___003Cref_003E = charSequence6.___003Cref_003E);
					j = charSequence2.length();
					offset = -1;
					for (; j > i; j += -1)
					{
						CharMatcher charMatcher3 = trimmer;
						CharSequence charSequence7 = toSplit;
						object __003Cref_003E3 = charSequence7.___003Cref_003E;
						i2 = j - 1;
						obj = (charSequence2.___003Cref_003E = __003Cref_003E3);
						if (!charMatcher3.matches(charSequence2.charAt(i2)))
						{
							break;
						}
					}
				}
				else
				{
					limit--;
				}
				CharSequence charSequence8 = toSplit;
				object __003Cref_003E4 = charSequence8.___003Cref_003E;
				int num4 = i;
				int i3 = j;
				i2 = num4;
				obj = (charSequence2.___003Cref_003E = __003Cref_003E4);
				obj = (charSequence2.___003Cref_003E = charSequence2.subSequence(i2, i3).___003Cref_003E);
				string result = charSequence2.toString();
				_ = null;
				return result;
			}
			return (string)endOfData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 2, 138, 232, 61, 199, 108, 108, 108, 119 })]
		protected internal SplittingIterator(Splitter P_0, CharSequence P_1)
		{
			CharSequence charSequence = P_1;
			object __003Cref_003E = charSequence.___003Cref_003E;
			base._002Ector();
			offset = 0;
			trimmer = access_0024200(P_0);
			omitEmptyStrings = access_0024300(P_0);
			limit = access_0024400(P_0);
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			toSplit = charSequence2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(542)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			string result = computeNext();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract)]
	internal interface Strategy
	{
		[Signature("(Lcom/google/common/base/Splitter;Ljava/lang/CharSequence;)Ljava/util/Iterator<Ljava/lang/String;>;")]
		virtual Iterator iterator(Splitter P_0, CharSequence P_1);
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private CharMatcher trimmer;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool m_omitEmptyStrings;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Strategy strategy;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int m_limit;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(104)]
	internal static CharMatcher access_0024200(Splitter P_0)
	{
		return P_0.trimmer;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(104)]
	internal static bool access_0024300(Splitter P_0)
	{
		return P_0.m_omitEmptyStrings;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(104)]
	internal static int access_0024400(Splitter P_0)
	{
		return P_0.m_limit;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/CharSequence;)Ljava/util/Iterator<Ljava/lang/String;>;")]
	[LineNumberTable(404)]
	private Iterator splittingIterator(CharSequence P_0)
	{
		CharSequence charSequence = P_0;
		object __003Cref_003E = charSequence.___003Cref_003E;
		Strategy obj = strategy;
		CharSequence charSequence2 = default(CharSequence);
		object obj2 = (charSequence2.___003Cref_003E = __003Cref_003E);
		Iterator result = obj.iterator(this, charSequence2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 114, 130, 104, 103, 103, 103, 104 })]
	private Splitter(Strategy P_0, bool P_1, CharMatcher P_2, int P_3)
	{
		strategy = P_0;
		this.m_omitEmptyStrings = P_1;
		trimmer = P_2;
		this.m_limit = P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 93, 135 })]
	public static Splitter on(CharMatcher separatorMatcher)
	{
		Preconditions.checkNotNull(separatorMatcher);
		Splitter result = new Splitter(new _1(separatorMatcher));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 61, 116 })]
	private Splitter(Strategy P_0)
		: this(P_0, false, CharMatcher.none(), int.MaxValue)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(129)]
	public static Splitter on(char separator)
	{
		Splitter result = on(CharMatcher.@is(separator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 109, 102, 63, 7, 229, 69 })]
	private static Splitter on(CommonPattern P_0)
	{
		CharSequence charSequence = default(CharSequence);
		object obj = (charSequence.___003Cref_003E = "");
		Preconditions.checkArgument((!P_0.matcher(charSequence).matches()) ? true : false, "The pattern may not match the empty string: %s", P_0);
		Splitter result = new Splitter(new _3(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 2, 103 })]
	public virtual Splitter trimResults(CharMatcher trimmer)
	{
		Preconditions.checkNotNull(trimmer);
		Splitter result = new Splitter(strategy, this.m_omitEmptyStrings, trimmer, this.m_limit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/CharSequence;)Ljava/lang/Iterable<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 159, 46, 106, 135 })]
	public virtual Iterable split(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		Preconditions.checkNotNull(__003Cref_003E);
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		_5 result = new _5(this, charSequence2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 123, 118, 105, 143 })]
	public static Splitter on(string separator)
	{
		Preconditions.checkArgument((String.instancehelper_length(separator) != 0) ? true : false, (object)"The separator may not be the empty string.");
		if (String.instancehelper_length(separator) == 1)
		{
			Splitter result = on(String.instancehelper_charAt(separator, 0));
			_ = null;
			return result;
		}
		Splitter result2 = new Splitter(new _2(separator));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(486)]
	public virtual MapSplitter withKeyValueSeparator(Splitter keyValueSplitter)
	{
		MapSplitter result = new MapSplitter(this, keyValueSplitter, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(219)]
	public static Splitter on(Pattern separatorPattern)
	{
		Splitter result = on(new JdkPattern(separatorPattern));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(262)]
	public static Splitter onPattern(string separatorPattern)
	{
		Splitter result = on(Platform.compilePattern(separatorPattern));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 170, 142 })]
	public static Splitter fixedLength(int length)
	{
		Preconditions.checkArgument(length > 0, (object)"The length may not be less than 1");
		Splitter result = new Splitter(new _4(length));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(323)]
	public virtual Splitter omitEmptyStrings()
	{
		Splitter result = new Splitter(strategy, true, trimmer, this.m_limit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 229, 111 })]
	public virtual Splitter limit(int maxItems)
	{
		Preconditions.checkArgument(maxItems > 0, "must be greater than zero: %s", maxItems);
		Splitter result = new Splitter(strategy, this.m_omitEmptyStrings, trimmer, maxItems);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(357)]
	public virtual Splitter trimResults()
	{
		Splitter result = trimResults(CharMatcher.whitespace());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/CharSequence;)Ljava/util/List<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 159, 38, 74, 135, 121, 135, 105, 182 })]
	public virtual List splitToList(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		Preconditions.checkNotNull(__003Cref_003E);
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		Iterator iterator = splittingIterator(charSequence2);
		java.util.ArrayList arrayList = new java.util.ArrayList();
		while (iterator.hasNext())
		{
			((List)arrayList).add((object)(string)iterator.next());
		}
		List result = Collections.unmodifiableList(arrayList);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/CharSequence;)Ljava/util/stream/Stream<Ljava/lang/String;>;")]
	[LineNumberTable(440)]
	public virtual Stream splitToStream(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence sequence2 = default(CharSequence);
		object obj = (sequence2.___003Cref_003E = __003Cref_003E);
		Stream result = StreamSupport.stream(split(sequence2).spliterator(), parallel: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(451)]
	public virtual MapSplitter withKeyValueSeparator(string separator)
	{
		MapSplitter result = withKeyValueSeparator(on(separator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(462)]
	public virtual MapSplitter withKeyValueSeparator(char separator)
	{
		MapSplitter result = withKeyValueSeparator(on(separator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(104)]
	internal static Iterator access_0024000(Splitter P_0, CharSequence P_1)
	{
		CharSequence charSequence = P_1;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		Iterator result = P_0.splittingIterator(charSequence2);
		_ = null;
		return result;
	}
}
