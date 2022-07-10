using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)12,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use TestingExecutors.sameThreadScheduledExecutor, or wrap a real Executor from java.util.concurrent.Executors with MoreExecutors.listeningDecorator"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.ExecutorService" })]
public interface ListeningExecutorService : ExecutorService, Executor
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static Future submit(ListeningExecutorService P_0, Runnable P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Esubmit(P_0, P_1);
		}

		public unsafe static Future submit(ListeningExecutorService P_0, Runnable P_1, object P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Esubmit(P_0, P_1, P_2);
		}

		public unsafe static Future submit(ListeningExecutorService P_0, Callable P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Esubmit(P_0, P_1);
		}
	}

	[Signature("(Ljava/lang/Runnable;)Lcom/google/common/util/concurrent/ListenableFuture<*>;")]
	ListenableFuture submit(Runnable r);

	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 12, 0, 0 })]
	ListenableFuture submit(Runnable r, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object obj);

	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 12, 0, 0 })]
	ListenableFuture submit(Callable c);

	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 12, 0, 0 })]
	List invokeAll(Collection c);

	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 12, 0, 0 })]
	List invokeAll(Collection c, long l, TimeUnit tu);

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Future _003Cbridge_003Esubmit(Runnable r);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(36)]
	static Future _003Cdefault_003E_003Cbridge_003Esubmit(ListeningExecutorService P_0, Runnable P_1)
	{
		ListenableFuture result = P_0.submit(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 12, 0, 0 })]
	virtual Future _003Cbridge_003Esubmit(Runnable r, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(36)]
	static Future _003Cdefault_003E_003Cbridge_003Esubmit(ListeningExecutorService P_0, Runnable P_1, object P_2)
	{
		ListenableFuture result = P_0.submit(P_1, P_2);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 12, 0, 0 })]
	virtual Future _003Cbridge_003Esubmit(Callable c);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(36)]
	static Future _003Cdefault_003E_003Cbridge_003Esubmit(ListeningExecutorService P_0, Callable P_1)
	{
		ListenableFuture result = P_0.submit(P_1);
		_ = null;
		return result;
	}
}
