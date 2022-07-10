using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.time;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/GwtFluentFutureCatchingSpecialization<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 37, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)37,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use FluentFuture.from(Futures.immediate*Future) or SettableFuture"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public abstract class FluentFuture : GwtFluentFutureCatchingSpecialization
{
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/FluentFuture<TV;>;Lcom/google/common/util/concurrent/AbstractFuture$Trusted<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 58, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)58,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.util.concurrent.AbstractFuture$Trusted" })]
	internal new abstract class TrustedFuture : FluentFuture, Trusted, ListenableFuture, Future
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		protected internal new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(85)]
		internal TrustedFuture()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
		[Signature("()TV;")]
		[LineNumberTable(91)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		public sealed override object get()
		{
			object result = base.get();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
		[Signature("(JLjava/util/concurrent/TimeUnit;)TV;")]
		[LineNumberTable(99)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		public sealed override object get(long P_0, TimeUnit P_1)
		{
			object result = base.get(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(104)]
		public sealed override bool isDone()
		{
			bool result = base.isDone();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(109)]
		public sealed override bool isCancelled()
		{
			bool result = base.isCancelled();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 64, 106 })]
		public sealed override void addListener(Runnable P_0, Executor P_1)
		{
			base.addListener(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(120)]
		public sealed override bool cancel(bool P_0)
		{
			bool result = base.cancel(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static TrustedFuture()
		{
			FluentFuture.___003Cclinit_003E();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(JLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/ScheduledExecutorService;)Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
	[LineNumberTable(291)]
	public FluentFuture withTimeout(long timeout, TimeUnit unit, ScheduledExecutorService scheduledExecutor)
	{
		return (FluentFuture)Futures.withTimeout(this, timeout, unit, scheduledExecutor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	internal FluentFuture()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 37, 0, 0 })]
	[LineNumberTable(new byte[] { 84, 104, 104, 8 })]
	public static FluentFuture from(ListenableFuture future)
	{
		FluentFuture result = ((!(future is FluentFuture)) ? new ForwardingFluentFuture(future) : ((FluentFuture)future));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/FluentFuture<TV;>;)Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 37, 0, 0 })]
	[LineNumberTable(147)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static FluentFuture from(FluentFuture future)
	{
		return (FluentFuture)Preconditions.checkNotNull(future);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Throwable;>(Ljava/lang/Class<TX;>;Lcom/google/common/base/Function<-TX;+TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
	[LineNumberTable(191)]
	public FluentFuture catching(Class exceptionType, Function fallback, Executor executor)
	{
		return (FluentFuture)Futures.catching(this, exceptionType, fallback, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Throwable;>(Ljava/lang/Class<TX;>;Lcom/google/common/util/concurrent/AsyncFunction<-TX;+TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
	[LineNumberTable(256)]
	public FluentFuture catchingAsync(Class exceptionType, AsyncFunction fallback, Executor executor)
	{
		return (FluentFuture)Futures.catchingAsync(this, exceptionType, fallback, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/time/Duration;Ljava/util/concurrent/ScheduledExecutorService;)Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
	[LineNumberTable(273)]
	public FluentFuture withTimeout(Duration timeout, ScheduledExecutorService scheduledExecutor)
	{
		FluentFuture result = withTimeout(Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS, scheduledExecutor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/AsyncFunction<-TV;TT;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/FluentFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 37, 0, 0 })]
	[LineNumberTable(336)]
	public FluentFuture transformAsync(AsyncFunction function, Executor executor)
	{
		return (FluentFuture)Futures.transformAsync(this, function, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TV;TT;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/FluentFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 37, 0, 0 })]
	[LineNumberTable(374)]
	public FluentFuture transform(Function function, Executor executor)
	{
		return (FluentFuture)Futures.transform(this, function, executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/FutureCallback<-TV;>;Ljava/util/concurrent/Executor;)V")]
	[LineNumberTable(new byte[] { 161, 45, 106 })]
	public void addCallback(FutureCallback callback, Executor executor)
	{
		Futures.addCallback(this, callback, executor);
	}

	[HideFromJava]
	static FluentFuture()
	{
		GwtFluentFutureCatchingSpecialization.___003Cclinit_003E();
	}
}
