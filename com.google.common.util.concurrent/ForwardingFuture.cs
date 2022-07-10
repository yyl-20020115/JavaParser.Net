using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingObject;Ljava/util/concurrent/Future<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 57, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)57,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.Future" })]
public abstract class ForwardingFuture : ForwardingObject, Future
{
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ForwardingFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 31, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)31,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public abstract class SimpleForwardingFuture : ForwardingFuture
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/concurrent/Future<TV;>;")]
		private new Future m_delegate;

		[Signature("()Ljava/util/concurrent/Future<TV;>;")]
		protected internal sealed override Future @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/Future<TV;>;)V")]
		[LineNumberTable(new byte[] { 37, 104, 113 })]
		protected internal SimpleForwardingFuture(Future @delegate)
		{
			this.m_delegate = (Future)Preconditions.checkNotNull(@delegate);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(83)]
		protected internal override object _003Cbridge_003Edelegate()
		{
			Future result = @delegate();
			_ = null;
			return result;
		}
	}

	[Signature("()Ljava/util/concurrent/Future<+TV;>;")]
	protected internal new abstract Future @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	protected internal ForwardingFuture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(50)]
	public virtual bool cancel(bool mayInterruptIfRunning)
	{
		bool result = @delegate().cancel(mayInterruptIfRunning);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	public virtual bool isCancelled()
	{
		bool result = @delegate().isCancelled();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(60)]
	public virtual bool isDone()
	{
		bool result = @delegate().isDone();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Signature("()TV;")]
	[LineNumberTable(66)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public virtual object get()
	{
		object result = @delegate().get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TV;")]
	[LineNumberTable(73)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public virtual object get(long timeout, TimeUnit unit)
	{
		object result = @delegate().get(timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(37)]
	protected internal virtual object _003Cbridge_003Edelegate()
	{
		Future result = @delegate();
		_ = null;
		return result;
	}
}
