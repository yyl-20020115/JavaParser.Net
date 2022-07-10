using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/AbstractIterator<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 37, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)37,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class ConsumingQueueIterator : AbstractIterator
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Queue<TT;>;")]
	private Queue queue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Queue<TT;>;)V")]
	[LineNumberTable(new byte[] { 159, 175, 104, 113 })]
	internal ConsumingQueueIterator(Queue P_0)
	{
		queue = (Queue)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(new byte[] { 159, 183, 109, 137 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object computeNext()
	{
		if (queue.isEmpty())
		{
			object result = endOfData();
			_ = null;
			return result;
		}
		object result2 = queue.remove();
		_ = null;
		return result2;
	}
}
