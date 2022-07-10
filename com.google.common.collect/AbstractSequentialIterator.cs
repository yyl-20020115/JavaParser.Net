using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class AbstractSequentialIterator : UnmodifiableIterator
{
	[Signature("TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object nextOrNull;

	[Signature("(TT;)TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal abstract object computeNext(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)V")]
	[LineNumberTable(new byte[] { 1, 104, 103 })]
	protected internal AbstractSequentialIterator([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object firstOrNull)
	{
		nextOrNull = firstOrNull;
	}

	public sealed override bool hasNext()
	{
		return nextOrNull != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(new byte[] { 20, 104, 139, 103, 109 })]
	public sealed override object next()
	{
		if (nextOrNull == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object obj = nextOrNull;
		nextOrNull = computeNext(obj);
		return obj;
	}
}
