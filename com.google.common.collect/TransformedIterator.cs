using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.google.common.collect;

[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 45, 0, 0,
	17, 1, 0, 0, 0, 45, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)45,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class TransformedIterator : Object, Iterator
{
	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/Iterator<+TF;>;")]
	internal Iterator backingIterator;

	[Signature("(TF;)TT;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	internal abstract object transform([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<+TF;>;)V")]
	[LineNumberTable(new byte[] { 159, 179, 104, 113 })]
	internal TransformedIterator(Iterator P_0)
	{
		backingIterator = (Iterator)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	public bool hasNext()
	{
		bool result = backingIterator.hasNext();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(52)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public object next()
	{
		object result = transform(backingIterator.next());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 109 })]
	public void remove()
	{
		backingIterator.remove();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEachRemaining(Consumer P_0)
	{
		Iterator._003Cdefault_003EforEachRemaining(this, P_0);
	}
}
