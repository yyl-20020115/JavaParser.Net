using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang.@ref;
using javax.annotation;

namespace com.google.common.@base;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/ref/PhantomReference<TT;>;Lcom/google/common/base/FinalizableReference;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.base.FinalizableReference" })]
public abstract class FinalizablePhantomReference : PhantomReference, FinalizableReference
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;Lcom/google/common/base/FinalizableReferenceQueue;)V")]
	[LineNumberTable(new byte[] { 159, 185, 109, 104 })]
	protected internal FinalizablePhantomReference([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object referent, FinalizableReferenceQueue queue)
		: base(referent, queue.queue)
	{
		queue.cleanUp();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract void finalizeReferent();
}
