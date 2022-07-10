using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.google.common.collect;

[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Lcom/google/common/collect/TransformedIterator<TF;TT;>;Ljava/util/ListIterator<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 56, 0, 0,
	17, 1, 0, 0, 0, 56, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)56,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.ListIterator" })]
internal abstract class TransformedListIterator : TransformedIterator, ListIterator, Iterator
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/ListIterator<+TF;>;")]
	[LineNumberTable(39)]
	private new ListIterator backingIterator()
	{
		ListIterator result = Iterators.cast(base.backingIterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/ListIterator<+TF;>;)V")]
	[LineNumberTable(new byte[] { 159, 177, 105 })]
	internal TransformedListIterator(ListIterator P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(44)]
	public bool hasPrevious()
	{
		bool result = backingIterator().hasPrevious();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(50)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public object previous()
	{
		object result = transform(backingIterator().previous());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	public int nextIndex()
	{
		int result = backingIterator().nextIndex();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(60)]
	public int previousIndex()
	{
		int result = backingIterator().previousIndex();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)V")]
	[LineNumberTable(65)]
	public virtual void set([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)V")]
	[LineNumberTable(70)]
	public virtual void add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEachRemaining(Consumer P_0)
	{
		Iterator._003Cdefault_003EforEachRemaining(this, P_0);
	}
}
