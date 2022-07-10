using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)54,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SortedLists : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/SortedLists$KeyAbsentBehavior;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	internal abstract class KeyAbsentBehavior : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : KeyAbsentBehavior
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(158)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			internal override int resultIndex(int P_0)
			{
				return P_0 - 1;
			}

			[HideFromJava]
			static _1()
			{
				KeyAbsentBehavior.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : KeyAbsentBehavior
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(168)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			public override int resultIndex(int P_0)
			{
				return P_0;
			}

			[HideFromJava]
			static _2()
			{
				KeyAbsentBehavior.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _3 : KeyAbsentBehavior
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(186)]
			internal _3(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			public override int resultIndex(int P_0)
			{
				return P_0 ^ -1;
			}

			[HideFromJava]
			static _3()
			{
				KeyAbsentBehavior.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static KeyAbsentBehavior NEXT_LOWER;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static KeyAbsentBehavior NEXT_HIGHER;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static KeyAbsentBehavior INVERTED_INSERTION_INDEX;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static KeyAbsentBehavior[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		internal abstract int resultIndex(int P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(153)]
		private KeyAbsentBehavior(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(153)]
		private static KeyAbsentBehavior[] _0024values()
		{
			return new KeyAbsentBehavior[3] { NEXT_LOWER, NEXT_HIGHER, INVERTED_INSERTION_INDEX };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(153)]
		public static KeyAbsentBehavior[] values()
		{
			return (KeyAbsentBehavior[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(153)]
		public static KeyAbsentBehavior valueOf(string P_0)
		{
			return (KeyAbsentBehavior)java.lang.Enum.valueOf(ClassLiteral<KeyAbsentBehavior>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(153)]
		internal KeyAbsentBehavior(string P_0, int P_1, SortedLists._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 108, 240, 74, 240, 82, 240, 31 })]
		static KeyAbsentBehavior()
		{
			NEXT_LOWER = new _1("NEXT_LOWER", 0);
			NEXT_HIGHER = new _2("NEXT_HIGHER", 1);
			INVERTED_INSERTION_INDEX = new _3("INVERTED_INSERTION_INDEX", 2);
			_0024VALUES = _0024values();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/SortedLists$KeyPresentBehavior;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)58,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class KeyPresentBehavior : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)30,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _1 : KeyPresentBehavior
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(52)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;TE;Ljava/util/List<+TE;>;I)I")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 30, 0, 0 })]
			internal override int resultIndex(Comparator P_0, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_1, List P_2, int P_3)
			{
				return P_3;
			}

			[HideFromJava]
			static _1()
			{
				KeyPresentBehavior.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)38,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _2 : KeyPresentBehavior
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(63)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;TE;Ljava/util/List<+TE;>;I)I")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 38, 0, 0 })]
			[LineNumberTable(new byte[] { 22, 99, 137, 100, 104, 111, 100, 134, 130, 98 })]
			internal override int resultIndex(Comparator P_0, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_1, List P_2, int P_3)
			{
				int num = P_3;
				int num2 = P_2.size() - 1;
				while (num < num2)
				{
					int num3 = (int)((uint)(num + num2 + 1) >> 1);
					int num4 = P_0.compare(P_2.get(num3), P_1);
					if (num4 > 0)
					{
						num2 = num3 - 1;
					}
					else
					{
						num = num3;
					}
				}
				return num;
			}

			[HideFromJava]
			static _2()
			{
				KeyPresentBehavior.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)37,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _3 : KeyPresentBehavior
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(88)]
			internal _3(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;TE;Ljava/util/List<+TE;>;I)I")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 37, 0, 0 })]
			[LineNumberTable(new byte[] { 47, 98, 163, 100, 102, 111, 100, 134, 130, 98 })]
			internal override int resultIndex(Comparator P_0, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_1, List P_2, int P_3)
			{
				int num = 0;
				int num2 = P_3;
				while (num < num2)
				{
					int num3 = (int)((uint)(num + num2) >> 1);
					int num4 = P_0.compare(P_2.get(num3), P_1);
					if (num4 < 0)
					{
						num = num3 + 1;
					}
					else
					{
						num2 = num3;
					}
				}
				return num;
			}

			[HideFromJava]
			static _3()
			{
				KeyPresentBehavior.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)32,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _4 : KeyPresentBehavior
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(117)]
			internal _4(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;TE;Ljava/util/List<+TE;>;I)I")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
			[LineNumberTable(124)]
			public override int resultIndex(Comparator P_0, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_1, List P_2, int P_3)
			{
				return LAST_PRESENT.resultIndex(P_0, P_1, P_2, P_3) + 1;
			}

			[HideFromJava]
			static _4()
			{
				KeyPresentBehavior.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)32,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _5 : KeyPresentBehavior
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(131)]
			internal _5(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;TE;Ljava/util/List<+TE;>;I)I")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
			[LineNumberTable(138)]
			public override int resultIndex(Comparator P_0, [ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_1, List P_2, int P_3)
			{
				return FIRST_PRESENT.resultIndex(P_0, P_1, P_2, P_3) - 1;
			}

			[HideFromJava]
			static _5()
			{
				KeyPresentBehavior.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static KeyPresentBehavior ANY_PRESENT;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static KeyPresentBehavior LAST_PRESENT;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static KeyPresentBehavior FIRST_PRESENT;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static KeyPresentBehavior FIRST_AFTER;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static KeyPresentBehavior LAST_BEFORE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static KeyPresentBehavior[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;TE;Ljava/util/List<+TE;>;I)I")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 58, 0, 0 })]
		internal abstract int resultIndex(Comparator P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, List P_2, int P_3);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(47)]
		private KeyPresentBehavior(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(47)]
		private static KeyPresentBehavior[] _0024values()
		{
			return new KeyPresentBehavior[5] { ANY_PRESENT, LAST_PRESENT, FIRST_PRESENT, FIRST_AFTER, LAST_BEFORE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(47)]
		public static KeyPresentBehavior[] values()
		{
			return (KeyPresentBehavior[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(47)]
		public static KeyPresentBehavior valueOf(string P_0)
		{
			return (KeyPresentBehavior)java.lang.Enum.valueOf(ClassLiteral<KeyPresentBehavior>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(47)]
		internal KeyPresentBehavior(string P_0, int P_1, SortedLists._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[]
		{
			2, 240, 75, 240, 89, 240, 93, 240, 78, 240,
			159, 172
		})]
		static KeyPresentBehavior()
		{
			ANY_PRESENT = new _1("ANY_PRESENT", 0);
			LAST_PRESENT = new _2("LAST_PRESENT", 1);
			FIRST_PRESENT = new _3("FIRST_PRESENT", 2);
			FIRST_AFTER = new _4("FIRST_AFTER", 3);
			LAST_BEFORE = new _5("LAST_BEFORE", 4);
			_0024VALUES = _0024values();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;K::Ljava/lang/Comparable;>(Ljava/util/List<TE;>;Lcom/google/common/base/Function<-TE;TK;>;TK;Lcom/google/common/collect/SortedLists$KeyPresentBehavior;Lcom/google/common/collect/SortedLists$KeyAbsentBehavior;)I")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 54, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 110, 103, 99, 40 })]
	public static int binarySearch(List P_0, Function P_1, IComparable P_2, KeyPresentBehavior P_3, KeyAbsentBehavior P_4)
	{
		Preconditions.checkNotNull(P_2);
		int result = binarySearch(P_0, P_1, P_2, Ordering.natural(), P_3, P_4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;K:Ljava/lang/Object;>(Ljava/util/List<TE;>;Lcom/google/common/base/Function<-TE;TK;>;TK;Ljava/util/Comparator<-TK;>;Lcom/google/common/collect/SortedLists$KeyPresentBehavior;Lcom/google/common/collect/SortedLists$KeyAbsentBehavior;)I")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 54, 0, 0,
		18, 1, 0, 0, 0, 54, 0, 0
	})]
	[LineNumberTable(new byte[] { 160, 129, 98, 43 })]
	public static int binarySearch(List P_0, Function P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2, Comparator P_3, KeyPresentBehavior P_4, KeyAbsentBehavior P_5)
	{
		int result = binarySearch(Lists.transform(P_0, P_1), P_2, P_3, P_4, P_5);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/List<+TE;>;TE;Ljava/util/Comparator<-TE;>;Lcom/google/common/collect/SortedLists$KeyPresentBehavior;Lcom/google/common/collect/SortedLists$KeyAbsentBehavior;)I")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 54, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		159, 73, 66, 103, 108, 103, 104, 109, 204, 98,
		156, 103, 102, 127, 8, 101, 102, 101, 134, 137,
		63, 4, 38, 193, 101
	})]
	public static int binarySearch(List P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, Comparator P_2, KeyPresentBehavior P_3, KeyAbsentBehavior P_4)
	{
		object obj = P_0;
		Preconditions.checkNotNull(P_2);
		Preconditions.checkNotNull((List)obj);
		Preconditions.checkNotNull(P_3);
		Preconditions.checkNotNull(P_4);
		if (!(((List)obj) is RandomAccess))
		{
			obj = Lists.newArrayList((List)obj);
		}
		int num = 0;
		object obj2 = obj;
		int num2 = ((obj2 == null) ? null : ((obj2 as List) ?? throw new java.lang.IncompatibleClassChangeError())).size() - 1;
		while (num <= num2)
		{
			int num3 = (int)((uint)(num + num2) >> 1);
			object obj3 = obj;
			int index = num3;
			int num4 = P_2.compare(P_1, ((obj3 == null) ? null : ((obj3 as List) ?? throw new java.lang.IncompatibleClassChangeError())).get(index));
			if (num4 < 0)
			{
				num2 = num3 - 1;
				continue;
			}
			if (num4 > 0)
			{
				num = num3 + 1;
				continue;
			}
			int num5 = num;
			object obj4 = obj;
			int num6 = num;
			int toIndex = num2 + 1;
			index = num6;
			return num5 + P_3.resultIndex(P_2, P_1, ((obj4 == null) ? null : ((obj4 as List) ?? throw new java.lang.IncompatibleClassChangeError())).subList(index, toIndex), num3 - num);
		}
		int result = P_4.resultIndex(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	private SortedLists()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>(Ljava/util/List<+TE;>;TE;Lcom/google/common/collect/SortedLists$KeyPresentBehavior;Lcom/google/common/collect/SortedLists$KeyAbsentBehavior;)I")]
	[LineNumberTable(new byte[] { 160, 94, 103 })]
	public static int binarySearch(List P_0, IComparable P_1, KeyPresentBehavior P_2, KeyAbsentBehavior P_3)
	{
		Preconditions.checkNotNull(P_1);
		int result = binarySearch(P_0, P_1, Ordering.natural(), P_2, P_3);
		_ = null;
		return result;
	}
}
