using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)30,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.util.concurrent.ListeningExecutorService" })]
public abstract class ForwardingListeningExecutorService : ForwardingExecutorService, ListeningExecutorService, ExecutorService, Executor
{
	protected internal new abstract ListeningExecutorService @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 30, 0, 0 })]
	[LineNumberTable(55)]
	public new virtual ListenableFuture submit(Runnable task, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object result)
	{
		ListenableFuture result2 = @delegate().submit(task, result);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;)Lcom/google/common/util/concurrent/ListenableFuture<*>;")]
	[LineNumberTable(49)]
	public new virtual ListenableFuture submit(Runnable task)
	{
		ListenableFuture result = @delegate().submit(task);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 30, 0, 0 })]
	[LineNumberTable(44)]
	public new virtual ListenableFuture submit(Callable task)
	{
		ListenableFuture result = @delegate().submit(task);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	protected internal ForwardingListeningExecutorService()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 30, 0, 0 })]
	[LineNumberTable(31)]
	public virtual Future _003Cbridge_003Esubmit(Runnable r, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object obj)
	{
		ListenableFuture result = submit(r, obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(31)]
	public virtual Future _003Cbridge_003Esubmit(Runnable r)
	{
		ListenableFuture result = submit(r);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 30, 0, 0 })]
	[LineNumberTable(31)]
	public virtual Future _003Cbridge_003Esubmit(Callable c)
	{
		ListenableFuture result = submit(c);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(31)]
	protected internal new virtual ExecutorService _003Cbridge_003Edelegate()
	{
		ListeningExecutorService result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(31)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		ListeningExecutorService result = @delegate();
		_ = null;
		return result;
	}

	Future ExecutorService.ExecutorService_003A_003Asubmit(Callable P_0)
	{
		return _003Cbridge_003Esubmit(P_0);
	}

	Future ExecutorService.ExecutorService_003A_003Asubmit(Runnable P_0, object P_1)
	{
		return _003Cbridge_003Esubmit(P_0, P_1);
	}

	Future ExecutorService.ExecutorService_003A_003Asubmit(Runnable P_0)
	{
		return _003Cbridge_003Esubmit(P_0);
	}
}
