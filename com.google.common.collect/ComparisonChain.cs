using System;
using System.Runtime.CompilerServices;
using com.google.common.primitives;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)35,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class ComparisonChain : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, null, null)]
	[ConstantPool(new object[]
	{
		(byte)40,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _1 : ComparisonChain
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(70)]
		internal _1()
			: base(null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(114)]
		internal virtual ComparisonChain classify(int P_0)
		{
			ComparisonChain obj = ((P_0 < 0) ? access_0024100() : ((P_0 <= 0) ? access_0024300() : access_0024200()));
			_ = null;
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Comparable<*>;Ljava/lang/Comparable<*>;)Lcom/google/common/collect/ComparisonChain;")]
		[LineNumberTable(74)]
		public override ComparisonChain compare(IComparable P_0, IComparable P_1)
		{
			ComparisonChain comparisonChain = classify(Comparable.__Helper.compareTo(P_0, P_1));
			_ = null;
			return comparisonChain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(TT;TT;Ljava/util/Comparator<TT;>;)Lcom/google/common/collect/ComparisonChain;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 40, 0, 0 })]
		[LineNumberTable(80)]
		public override ComparisonChain compare([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, Comparator P_2)
		{
			ComparisonChain comparisonChain = classify(P_2.compare(P_0, P_1));
			_ = null;
			return comparisonChain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(85)]
		public override ComparisonChain compare(int P_0, int P_1)
		{
			ComparisonChain comparisonChain = classify(Ints.compare(P_0, P_1));
			_ = null;
			return comparisonChain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(90)]
		public override ComparisonChain compare(long P_0, long P_1)
		{
			ComparisonChain comparisonChain = classify(Longs.compare(P_0, P_1));
			_ = null;
			return comparisonChain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(95)]
		public override ComparisonChain compare(float P_0, float P_1)
		{
			ComparisonChain comparisonChain = classify(Float.compare(P_0, P_1));
			_ = null;
			return comparisonChain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(100)]
		public override ComparisonChain compare(double P_0, double P_1)
		{
			ComparisonChain comparisonChain = classify(java.lang.Double.compare(P_0, P_1));
			_ = null;
			return comparisonChain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(105)]
		public override ComparisonChain compareTrueFirst(bool P_0, bool P_1)
		{
			ComparisonChain comparisonChain = classify(Booleans.compare(P_1, P_0));
			_ = null;
			return comparisonChain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(110)]
		public override ComparisonChain compareFalseFirst(bool P_0, bool P_1)
		{
			ComparisonChain comparisonChain = classify(Booleans.compare(P_0, P_1));
			_ = null;
			return comparisonChain;
		}

		public override int result()
		{
			return 0;
		}

		[HideFromJava]
		static _1()
		{
			ComparisonChain.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[ConstantPool(new object[]
	{
		(byte)33,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class InactiveComparisonChain : ComparisonChain
	{
		[Modifiers(Modifiers.Final)]
		internal new int result;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 80, 105, 103 })]
		internal InactiveComparisonChain(int P_0)
			: base(null)
		{
			this.result = P_0;
		}

		[Signature("(Ljava/lang/Comparable<*>;Ljava/lang/Comparable<*>;)Lcom/google/common/collect/ComparisonChain;")]
		public override ComparisonChain compare(IComparable P_0, IComparable P_1)
		{
			return this;
		}

		[Signature("<T:Ljava/lang/Object;>(TT;TT;Ljava/util/Comparator<TT;>;)Lcom/google/common/collect/ComparisonChain;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 33, 0, 0 })]
		public override ComparisonChain compare([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, Comparator P_2)
		{
			return this;
		}

		public override ComparisonChain compare(int P_0, int P_1)
		{
			return this;
		}

		public override ComparisonChain compare(long P_0, long P_1)
		{
			return this;
		}

		public override ComparisonChain compare(float P_0, float P_1)
		{
			return this;
		}

		public override ComparisonChain compare(double P_0, double P_1)
		{
			return this;
		}

		public override ComparisonChain compareTrueFirst(bool P_0, bool P_1)
		{
			return this;
		}

		public override ComparisonChain compareFalseFirst(bool P_0, bool P_1)
		{
			return this;
		}

		public override int result()
		{
			return this.result;
		}

		[HideFromJava]
		static InactiveComparisonChain()
		{
			ComparisonChain.___003Cclinit_003E();
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static ComparisonChain ACTIVE;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static ComparisonChain LESS;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static ComparisonChain GREATER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	private ComparisonChain()
	{
	}

	public abstract ComparisonChain compareFalseFirst(bool b1, bool b2);

	public static ComparisonChain start()
	{
		return ACTIVE;
	}

	[Signature("(Ljava/lang/Comparable<*>;Ljava/lang/Comparable<*>;)Lcom/google/common/collect/ComparisonChain;")]
	public abstract ComparisonChain compare(IComparable c1, IComparable c2);

	[Signature("<T:Ljava/lang/Object;>(TT;TT;Ljava/util/Comparator<TT;>;)Lcom/google/common/collect/ComparisonChain;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 35, 0, 0 })]
	public abstract ComparisonChain compare([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2, Comparator c);

	public abstract ComparisonChain compare(int i1, int i2);

	public abstract ComparisonChain compare(long l1, long l2);

	public abstract ComparisonChain compare(float f1, float f2);

	public abstract ComparisonChain compare(double d1, double d2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(239)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public ComparisonChain compare(java.lang.Boolean left, java.lang.Boolean right)
	{
		ComparisonChain comparisonChain = compareFalseFirst(left.booleanValue(), right.booleanValue());
		_ = null;
		return comparisonChain;
	}

	public abstract ComparisonChain compareTrueFirst(bool b1, bool b2);

	public abstract int result();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal ComparisonChain(_1 P_0)
		: this()
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static ComparisonChain access_0024100()
	{
		return LESS;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static ComparisonChain access_0024200()
	{
		return GREATER;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static ComparisonChain access_0024300()
	{
		return ACTIVE;
	}

	[LineNumberTable(new byte[] { 19, 234, 118, 139 })]
	static ComparisonChain()
	{
		ACTIVE = new _1();
		LESS = new InactiveComparisonChain(-1);
		GREATER = new InactiveComparisonChain(1);
	}
}
