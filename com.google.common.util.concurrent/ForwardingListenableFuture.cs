using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ForwardingFuture<TV;>;Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 40, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)40,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.util.concurrent.ListenableFuture" })]
public abstract class ForwardingListenableFuture : ForwardingFuture, ListenableFuture, Future
{
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ForwardingListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 32, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)32,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public abstract class SimpleForwardingListenableFuture : ForwardingListenableFuture
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		private new ListenableFuture m_delegate;

		[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		protected internal sealed override ListenableFuture @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)V")]
		[LineNumberTable(new byte[] { 11, 104, 113 })]
		protected internal SimpleForwardingListenableFuture(ListenableFuture @delegate)
		{
			this.m_delegate = (ListenableFuture)Preconditions.checkNotNull(@delegate);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(57)]
		protected internal override Future _003Cbridge_003Edelegate()
		{
			ListenableFuture result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(57)]
		protected internal override object _003Cbridge_003Edelegate()
		{
			ListenableFuture result = @delegate();
			_ = null;
			return result;
		}
	}

	[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;")]
	protected internal new abstract ListenableFuture @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	protected internal ForwardingListenableFuture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 111 })]
	public virtual void addListener(Runnable listener, Executor exec)
	{
		@delegate().addListener(listener, exec);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(33)]
	protected internal new virtual Future _003Cbridge_003Edelegate()
	{
		ListenableFuture result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(33)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		ListenableFuture result = @delegate();
		_ = null;
		return result;
	}
}
