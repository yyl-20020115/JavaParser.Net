using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/UnmodifiableListIterator<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 50, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)50,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractIndexedListIterator : UnmodifiableListIterator
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int size;

	private int position;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 104, 104, 103, 103 })]
	protected internal AbstractIndexedListIterator(int P_0, int P_1)
	{
		Preconditions.checkPositionIndex(P_1, P_0);
		size = P_0;
		position = P_1;
	}

	public sealed override bool hasNext()
	{
		return position < size;
	}

	[Signature("(I)TE;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	protected internal abstract object get(int P_0);

	public sealed override bool hasPrevious()
	{
		return position > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 106 })]
	protected internal AbstractIndexedListIterator(int P_0)
		: this(P_0, 0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(new byte[] { 29, 104, 139 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public sealed override object next()
	{
		if (!hasNext())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		int num = position;
		position = num + 1;
		object result = get(num);
		_ = null;
		return result;
	}

	public sealed override int nextIndex()
	{
		return position;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(new byte[] { 48, 104, 139 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public sealed override object previous()
	{
		if (!hasPrevious())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		int num = position - 1;
		position = num;
		object result = get(num);
		_ = null;
		return result;
	}

	public sealed override int previousIndex()
	{
		return position - 1;
	}
}
