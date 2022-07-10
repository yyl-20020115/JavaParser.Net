using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.util.concurrent.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)102,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class Futures : GwtFuturesCatchingSpecialization
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "scheduleAsync", "(Lcom.google.common.util.concurrent.AsyncCallable;JLjava.util.concurrent.TimeUnit;Ljava.util.concurrent.ScheduledExecutorService;)Lcom.google.common.util.concurrent.ListenableFuture;")]
	internal class _1 : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Future val_0024scheduled;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(252)]
		internal _1(Future P_0)
		{
			val_0024scheduled = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 142, 109 })]
		public virtual void run()
		{
			val_0024scheduled.cancel(mayInterruptIfRunning: false);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/util/concurrent/Future<TO;>;")]
	[EnclosingMethod(null, "lazyTransform", "(Ljava.util.concurrent.Future;Lcom.google.common.base.Function;)Ljava.util.concurrent.Future;")]
	internal class _2 : java.lang.Object, Future
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Future val_0024input;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Function val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(521)]
		internal _2(Future P_0, Function P_1)
		{
			val_0024input = P_0;
			val_0024function = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(TI;)TO;")]
		[LineNumberTable(new byte[] { 161, 181, 127, 3, 97 })]
		private object applyTransformation(object P_0)
		{
			//Discarded unreachable code: IL_000e
			System.Exception ex;
			try
			{
				return val_0024function.apply(P_0);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(525)]
		public virtual bool cancel(bool P_0)
		{
			bool result = val_0024input.cancel(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(530)]
		public virtual bool isCancelled()
		{
			bool result = val_0024input.isCancelled();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(535)]
		public virtual bool isDone()
		{
			bool result = val_0024input.isDone();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
		[Signature("()TO;")]
		[LineNumberTable(540)]
		public virtual object get()
		{
			object result = applyTransformation(val_0024input.get());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
		[Signature("(JLjava/util/concurrent/TimeUnit;)TO;")]
		[LineNumberTable(546)]
		public virtual object get(long P_0, TimeUnit P_1)
		{
			object result = applyTransformation(val_0024input.get(P_0, P_1));
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "inCompletionOrder", "(Ljava.lang.Iterable;)Lcom.google.common.collect.ImmutableList;")]
	internal class _3 : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal InCompletionOrderState val_0024state;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableList val_0024delegates;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024localI;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(921)]
		internal _3(InCompletionOrderState P_0, ImmutableList P_1, int P_2)
		{
			val_0024state = P_0;
			val_0024delegates = P_1;
			val_0024localI = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 42, 121 })]
		public virtual void run()
		{
			InCompletionOrderState.access_0024300(val_0024state, val_0024delegates, val_0024localI);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Runnable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 55, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)55,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class CallbackListener : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/concurrent/Future<TV;>;")]
		internal Future future;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/FutureCallback<-TV;>;")]
		internal FutureCallback callback;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/Future<TV;>;Lcom/google/common/util/concurrent/FutureCallback<-TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 231, 104, 103, 103 })]
		internal CallbackListener(Future P_0, FutureCallback P_1)
		{
			future = P_0;
			callback = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163,
			238,
			109,
			107,
			102,
			99,
			108,
			225,
			69,
			byte.MaxValue,
			35,
			71,
			226,
			58,
			98,
			114,
			97,
			98,
			109,
			129,
			108
		})]
		public virtual void run()
		{
			if (future is InternalFutureFailureAccess)
			{
				System.Exception ex = InternalFutures.tryInternalFastPathGetFailure((InternalFutureFailureAccess)future);
				if (ex != null)
				{
					callback.onFailure(ex);
					return;
				}
			}
			object done;
			ExecutionException ex2;
			RuntimeException ex4;
			Error error2;
			try
			{
				try
				{
					try
					{
						done = getDone(future);
					}
					catch (ExecutionException x)
					{
						ex2 = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_0066;
					}
				}
				catch (System.Exception x2)
				{
					RuntimeException ex3 = ByteCodeHelper.MapException<RuntimeException>(x2, ByteCodeHelper.MapFlags.None);
					if (ex3 == null)
					{
						throw;
					}
					ex4 = ex3;
					goto IL_0069;
				}
			}
			catch (System.Exception x3)
			{
				Error error = ByteCodeHelper.MapException<Error>(x3, ByteCodeHelper.MapFlags.None);
				if (error == null)
				{
					throw;
				}
				error2 = error;
				goto IL_006c;
			}
			callback.onSuccess(done);
			return;
			IL_0087:
			object obj;
			System.Exception t = (System.Exception)obj;
			callback.onFailure(t);
			return;
			IL_0066:
			ExecutionException @this = ex2;
			callback.onFailure(Throwable.instancehelper_getCause(@this));
			return;
			IL_0069:
			obj = ex4;
			goto IL_0087;
			IL_006c:
			obj = error2;
			goto IL_0087;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1143)]
		public override string toString()
		{
			string result = MoreObjects.toStringHelper(this).addValue(callback).toString();
			_ = null;
			return result;
		}
	}

	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 40, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)40,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public sealed class FutureCombiner : java.lang.Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/concurrent/Callable<Ljava/lang/Void;>;")]
		[EnclosingMethod(null, "run", "(Ljava.lang.Runnable;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ListenableFuture;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 16, 0, 0, 1, 3, 0, 0, 35,
			0, 0
		})]
		[ConstantPool(new object[]
		{
			(byte)35,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal class _1 : java.lang.Object, Callable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Runnable val_0024combiner;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[LineNumberTable(new byte[] { 162, 139, 107 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public virtual java.lang.Void call()
			{
				val_0024combiner.run();
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(761)]
			internal _1(FutureCombiner P_0, Runnable P_1)
			{
				val_0024combiner = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(761)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public virtual object call()
			{
				java.lang.Void result = this.call();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private bool allMustSucceed;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;")]
		private ImmutableList futures;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<C:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TC;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TC;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 40, 0, 0 })]
		[LineNumberTable(745)]
		public virtual ListenableFuture call(Callable combiner, Executor executor)
		{
			CombinedFuture.___003Cclinit_003E();
			CombinedFuture result = new CombinedFuture(futures, allMustSucceed, executor, combiner);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<C:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/AsyncCallable<TC;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TC;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 40, 0, 0 })]
		[LineNumberTable(725)]
		public virtual ListenableFuture callAsync(AsyncCallable combiner, Executor executor)
		{
			CombinedFuture.___003Cclinit_003E();
			CombinedFuture result = new CombinedFuture(futures, allMustSucceed, executor, combiner);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(699)]
		internal FutureCombiner(bool P_0, ImmutableList P_1, Futures._1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ZLcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;)V")]
		[LineNumberTable(new byte[] { 158, 222, 66, 104, 103, 103 })]
		private FutureCombiner(bool P_0, ImmutableList P_1)
		{
			allMustSucceed = P_0;
			futures = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<*>;")]
		[LineNumberTable(760)]
		public virtual ListenableFuture run(Runnable combiner, Executor executor)
		{
			ListenableFuture result = call(new _1(this, combiner), executor);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 59, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)59,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class InCompletionOrderFuture : AbstractFuture
	{
		[Signature("Lcom/google/common/util/concurrent/Futures$InCompletionOrderState<TT;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private InCompletionOrderState state;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(951)]
		internal InCompletionOrderFuture(InCompletionOrderState P_0, Futures._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/Futures$InCompletionOrderState<TT;>;)V")]
		[LineNumberTable(new byte[] { 163, 73, 104, 103 })]
		private InCompletionOrderFuture(InCompletionOrderState P_0)
		{
			state = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 158, 98, 103, 233, 73, 113, 130 })]
		public override bool cancel(bool P_0)
		{
			InCompletionOrderState obj = state;
			if (base.cancel(P_0))
			{
				InCompletionOrderState.access_0024400((InCompletionOrderState)java.util.Objects.requireNonNull(obj), P_0);
				return true;
			}
			return false;
		}

		protected internal override void afterDone()
		{
			state = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163,
			103,
			103,
			163,
			97,
			136,
			byte.MaxValue,
			40,
			61,
			225,
			70
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override string pendingToString()
		{
			InCompletionOrderState inCompletionOrderState = state;
			if (inCompletionOrderState != null)
			{
				int i = InCompletionOrderState.access_0024500(inCompletionOrderState).Length;
				int i2 = InCompletionOrderState.access_0024600(inCompletionOrderState).get();
				int num = 49;
				num = num;
				string result = new StringBuilder(num).append("inputCount=[").append(i).append("], remaining=[")
					.append(i2)
					.append("]")
					.toString();
				_ = null;
				return result;
			}
			return null;
		}

		[HideFromJava]
		static InCompletionOrderFuture()
		{
			AbstractFuture.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 33, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)33,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class InCompletionOrderState : java.lang.Object
	{
		private bool wasCancelled;

		private bool shouldInterrupt;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private AtomicInteger incompleteOutputCount;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("[Lcom/google/common/util/concurrent/ListenableFuture<+TT;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 33, 0, 0 })]
		private ListenableFuture[] inputFutures;

		private volatile int delegateIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(999)]
		internal InCompletionOrderState(ListenableFuture[] P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(999)]
		internal static void access_0024300(InCompletionOrderState P_0, ImmutableList P_1, int P_2)
		{
			P_0.recordInputCompletion(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(999)]
		internal static void access_0024400(InCompletionOrderState P_0, bool P_1)
		{
			P_0.recordOutputCancellation(P_1);
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(999)]
		internal static ListenableFuture[] access_0024500(InCompletionOrderState P_0)
		{
			return P_0.inputFutures;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(999)]
		internal static AtomicInteger access_0024600(InCompletionOrderState P_0)
		{
			return P_0.incompleteOutputCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 144, 66, 167, 99, 135, 104 })]
		private void recordOutputCancellation(bool P_0)
		{
			wasCancelled = true;
			if (!P_0)
			{
				shouldInterrupt = false;
			}
			recordCompletion();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/AbstractFuture<TT;>;>;I)V")]
		[LineNumberTable(new byte[]
		{
			163, 149, 147, 105, 114, 116, 134, 112, 225, 59,
			230, 75, 115
		})]
		private void recordInputCompletion(ImmutableList P_0, int P_1)
		{
			ListenableFuture future = (ListenableFuture)java.util.Objects.requireNonNull(inputFutures[P_1]);
			inputFutures[P_1] = null;
			for (int i = delegateIndex; i < P_0.size(); i++)
			{
				if (((AbstractFuture)P_0.get(i)).setFuture(future))
				{
					recordCompletion();
					delegateIndex = i + 1;
					System.Threading.Thread.MemoryBarrier();
					return;
				}
			}
			delegateIndex = P_0.size();
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([Lcom/google/common/util/concurrent/ListenableFuture<+TT;>;)V")]
		[LineNumberTable(new byte[] { 163, 128, 232, 57, 103, 199, 174, 103, 109 })]
		private InCompletionOrderState(ListenableFuture[] P_0)
		{
			wasCancelled = false;
			shouldInterrupt = true;
			delegateIndex = 0;
			System.Threading.Thread.MemoryBarrier();
			inputFutures = P_0;
			incompleteOutputCount = new AtomicInteger(P_0.Length);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 167, 117, 116, 99, 13, 230, 70 })]
		private void recordCompletion()
		{
			if (incompleteOutputCount.decrementAndGet() == 0 && wasCancelled)
			{
				ListenableFuture[] array = inputFutures;
				int num = array.Length;
				for (int i = 0; i < num; i++)
				{
					array[i]?.cancel(shouldInterrupt);
				}
			}
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractFuture$TrustedFuture<TV;>;Ljava/lang/Runnable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 46, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)46,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.lang.Runnable" })]
	internal sealed class NonCancellationPropagatingFuture : AbstractFuture.TrustedFuture, Runnable
	{
		[Signature("Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private ListenableFuture @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 169, 104, 103 })]
		internal NonCancellationPropagatingFuture(ListenableFuture P_0)
		{
			@delegate = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 177, 103, 99, 136 })]
		public virtual void run()
		{
			ListenableFuture listenableFuture = @delegate;
			if (listenableFuture != null)
			{
				base.setFuture(listenableFuture);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 186, 103, 99, 159, 33 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override string pendingToString()
		{
			ListenableFuture listenableFuture = @delegate;
			if (listenableFuture != null)
			{
				string text = java.lang.String.valueOf(listenableFuture);
				int num = 11 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string result = new StringBuilder(num).append("delegate=[").append(text).append("]")
					.toString();
				_ = null;
				return result;
			}
			return null;
		}

		protected internal override void afterDone()
		{
			@delegate = null;
		}

		[HideFromJava]
		static NonCancellationPropagatingFuture()
		{
			TrustedFuture.___003Cclinit_003E();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(TV;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 85, 163, 102, 130 })]
	public static ListenableFuture immediateFuture([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object value)
	{
		if (value == null)
		{
			return ImmediateFuture.NULL;
		}
		ImmediateFuture result = new ImmediateFuture(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/lang/Throwable;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 114, 103 })]
	public static ListenableFuture immediateFailedFuture(System.Exception throwable)
	{
		Preconditions.checkNotNull(throwable);
		ImmediateFuture.ImmediateFailedFuture result = new ImmediateFuture.ImmediateFailedFuture(throwable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TI;>;Lcom/google/common/base/Function<-TI;+TO;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 102, 0, 0,
		18, 1, 0, 0, 0, 102, 0, 0
	})]
	[LineNumberTable(492)]
	public static ListenableFuture transform(ListenableFuture input, Function function, Executor executor)
	{
		ListenableFuture result = AbstractTransformFuture.create(input, function, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Throwable;>(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;Ljava/lang/Class<TX;>;Lcom/google/common/base/Function<-TX;+TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(306)]
	public static ListenableFuture catching(ListenableFuture input, Class exceptionType, Function fallback, Executor executor)
	{
		ListenableFuture result = AbstractCatchingFuture.create(input, exceptionType, fallback, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Throwable;>(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;Ljava/lang/Class<TX;>;Lcom/google/common/util/concurrent/AsyncFunction<-TX;+TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(371)]
	public static ListenableFuture catchingAsync(ListenableFuture input, Class exceptionType, AsyncFunction fallback, Executor executor)
	{
		ListenableFuture result = AbstractCatchingFuture.create(input, exceptionType, fallback, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;JLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/ScheduledExecutorService;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 42, 104, 130 })]
	public static ListenableFuture withTimeout(ListenableFuture @delegate, long time, TimeUnit unit, ScheduledExecutorService scheduledExecutor)
	{
		if (@delegate.isDone())
		{
			return @delegate;
		}
		ListenableFuture result = TimeoutFuture.create(@delegate, time, unit, scheduledExecutor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TI;>;Lcom/google/common/util/concurrent/AsyncFunction<-TI;+TO;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 102, 0, 0,
		18, 1, 0, 0, 0, 102, 0, 0
	})]
	[LineNumberTable(456)]
	public static ListenableFuture transformAsync(ListenableFuture input, AsyncFunction function, Executor executor)
	{
		ListenableFuture result = AbstractTransformFuture.create(input, function, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;Lcom/google/common/util/concurrent/FutureCallback<-TV;>;Ljava/util/concurrent/Executor;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 222, 103, 112 })]
	public static void addCallback(ListenableFuture future, FutureCallback callback, Executor executor)
	{
		Preconditions.checkNotNull(callback);
		future.addListener(new CallbackListener(future, callback), executor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TV;>;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 164, 42, 113 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public static object getDone(Future future)
	{
		Preconditions.checkState(future.isDone(), "Future was expected to be done: %s", future);
		object uninterruptibly = Uninterruptibles.getUninterruptibly(future);
		_ = null;
		return uninterruptibly;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>()Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 125, 102, 99, 130 })]
	public static ListenableFuture immediateCancelledFuture()
	{
		ImmediateFuture.ImmediateCancelledFuture iNSTANCE = ImmediateFuture.ImmediateCancelledFuture.INSTANCE;
		if (iNSTANCE != null)
		{
			return iNSTANCE;
		}
		ImmediateFuture.ImmediateCancelledFuture result = new ImmediateFuture.ImmediateCancelledFuture();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 156, 104, 130, 103, 108 })]
	public static ListenableFuture nonCancellationPropagating(ListenableFuture future)
	{
		if (future.isDone())
		{
			return future;
		}
		NonCancellationPropagatingFuture nonCancellationPropagatingFuture = new NonCancellationPropagatingFuture(future);
		future.addListener(nonCancellationPropagatingFuture, MoreExecutors.directExecutor());
		return nonCancellationPropagatingFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;)Lcom/google/common/util/concurrent/Futures$FutureCombiner<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(667)]
	public static FutureCombiner whenAllSucceed(Iterable futures)
	{
		FutureCombiner result = new FutureCombiner(true, ImmutableList.copyOf(futures), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;)Lcom/google/common/util/concurrent/Futures$FutureCombiner<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(640)]
	public static FutureCombiner whenAllComplete(Iterable futures)
	{
		FutureCombiner result = new FutureCombiner(false, ImmutableList.copyOf(futures), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<Ljava/lang/Void;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 102, 0, 0 })]
	[LineNumberTable(152)]
	public static ListenableFuture immediateVoidFuture()
	{
		return ImmediateFuture.NULL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<O:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/AsyncCallable<TO;>;JLjava/util/concurrent/TimeUnit;Ljava/util/concurrent/ScheduledExecutorService;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 135, 103, 106, 231, 72, 229, 56, 229, 73 })]
	public static ListenableFuture scheduleAsync(AsyncCallable callable, long delay, TimeUnit timeUnit, ScheduledExecutorService executorService)
	{
		TrustedListenableFutureTask trustedListenableFutureTask = TrustedListenableFutureTask.create(callable);
		ScheduledFuture scheduledFuture = executorService.schedule(trustedListenableFutureTask, delay, timeUnit);
		trustedListenableFutureTask.addListener(new _1(scheduledFuture), MoreExecutors.directExecutor());
		return trustedListenableFutureTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/ListenableFuture<+TT;>;>;)[Lcom/google/common/util/concurrent/ListenableFuture<+TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 58, 104, 137, 135 })]
	private static ListenableFuture[] gwtCompatibleToArray(Iterable P_0)
	{
		object obj = ((!(P_0 is Collection)) ? ImmutableList.copyOf(P_0) : ((Collection)P_0));
		object[] a = new ListenableFuture[0];
		return (ListenableFuture[])((obj == null) ? null : ((obj as Collection) ?? throw new java.lang.IncompatibleClassChangeError())).toArray(a);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Exception;>(Ljava/util/concurrent/Future<TV;>;Ljava/lang/Class<TX;>;JLjava/util/concurrent/TimeUnit;)TV;^TX;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(1337)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public static object getChecked(Future future, Class exceptionClass, long timeout, TimeUnit unit)
	{
		object @checked = FuturesGetChecked.getChecked(future, exceptionClass, timeout, unit);
		_ = null;
		return @checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 249, 104, 241, 71 })]
	private static void wrapAndThrowUnchecked(System.Exception P_0)
	{
		if (P_0 is Error)
		{
			Error cause = (Error)P_0;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionError(cause);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UncheckedExecutionException(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(126)]
	private Futures()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<O:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TO;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 76, 103, 103 })]
	public static ListenableFuture submit(Callable callable, Executor executor)
	{
		TrustedListenableFutureTask trustedListenableFutureTask = TrustedListenableFutureTask.create(callable);
		executor.execute(trustedListenableFutureTask);
		return trustedListenableFutureTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<Ljava/lang/Void;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 89, 98, 102, 103 })]
	public static ListenableFuture submit(Runnable runnable, Executor executor)
	{
		TrustedListenableFutureTask trustedListenableFutureTask = TrustedListenableFutureTask.create(runnable, null);
		executor.execute(trustedListenableFutureTask);
		return trustedListenableFutureTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<O:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/AsyncCallable<TO;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 103, 103, 103 })]
	public static ListenableFuture submitAsync(AsyncCallable callable, Executor executor)
	{
		TrustedListenableFutureTask trustedListenableFutureTask = TrustedListenableFutureTask.create(callable);
		executor.execute(trustedListenableFutureTask);
		return trustedListenableFutureTask;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<O:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/AsyncCallable<TO;>;Ljava/time/Duration;Ljava/util/concurrent/ScheduledExecutorService;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(232)]
	public static ListenableFuture scheduleAsync(AsyncCallable callable, Duration delay, ScheduledExecutorService executorService)
	{
		ListenableFuture result = scheduleAsync(callable, Internal.toNanosSaturated(delay), TimeUnit.NANOSECONDS, executorService);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;Ljava/time/Duration;Ljava/util/concurrent/ScheduledExecutorService;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(389)]
	public static ListenableFuture withTimeout(ListenableFuture @delegate, Duration time, ScheduledExecutorService scheduledExecutor)
	{
		ListenableFuture result = withTimeout(@delegate, Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS, scheduledExecutor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TI;>;Lcom/google/common/base/Function<-TI;+TO;>;)Ljava/util/concurrent/Future<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 102, 0, 0,
		18, 1, 0, 0, 0, 102, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 149, 103, 103 })]
	public static Future lazyTransform(Future input, Function function)
	{
		Preconditions.checkNotNull(input);
		Preconditions.checkNotNull(function);
		_2 result = new _2(input, function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>([Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;)Lcom/google/common/util/concurrent/ListenableFuture<Ljava/util/List<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 209, 102, 172, 98 })]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static ListenableFuture allAsList(params ListenableFuture[] futures)
	{
		CollectionFuture.ListFuture.___003Cclinit_003E();
		return new CollectionFuture.ListFuture(ImmutableList.copyOf(futures), true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;)Lcom/google/common/util/concurrent/ListenableFuture<Ljava/util/List<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 236, 102, 172, 98 })]
	public static ListenableFuture allAsList(Iterable futures)
	{
		CollectionFuture.ListFuture.___003Cclinit_003E();
		return new CollectionFuture.ListFuture(ImmutableList.copyOf(futures), true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>([Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;)Lcom/google/common/util/concurrent/Futures$FutureCombiner<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(626)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static FutureCombiner whenAllComplete(params ListenableFuture[] futures)
	{
		FutureCombiner result = new FutureCombiner(false, ImmutableList.copyOf(futures), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>([Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;)Lcom/google/common/util/concurrent/Futures$FutureCombiner<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(654)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static FutureCombiner whenAllSucceed(params ListenableFuture[] futures)
	{
		FutureCombiner result = new FutureCombiner(true, ImmutableList.copyOf(futures), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>([Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;)Lcom/google/common/util/concurrent/ListenableFuture<Ljava/util/List<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 2, 3, 0, 3, 0, 0, 102,
		0, 0, 18, 0, 0, 0, 0, 102, 0, 0
	})]
	[LineNumberTable(859)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static ListenableFuture successfulAsList(params ListenableFuture[] futures)
	{
		CollectionFuture.ListFuture.___003Cclinit_003E();
		CollectionFuture.ListFuture result = new CollectionFuture.ListFuture(ImmutableList.copyOf(futures), false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;)Lcom/google/common/util/concurrent/ListenableFuture<Ljava/util/List<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 2, 3, 0, 3, 0, 0, 102,
		0, 0, 18, 0, 0, 0, 0, 102, 0, 0
	})]
	[LineNumberTable(883)]
	public static ListenableFuture successfulAsList(Iterable futures)
	{
		CollectionFuture.ListFuture.___003Cclinit_003E();
		CollectionFuture.ListFuture result = new CollectionFuture.ListFuture(ImmutableList.copyOf(futures), false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/util/concurrent/ListenableFuture<+TT;>;>;)Lcom/google/common/collect/ImmutableList<Lcom/google/common/util/concurrent/ListenableFuture<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		163, 27, 103, 104, 98, 102, 103, 46, 198, 104,
		105, 100, 238, 71, 229, 57, 5, 232, 77, 100
	})]
	public static ImmutableList inCompletionOrder(Iterable futures)
	{
		ListenableFuture[] array = gwtCompatibleToArray(futures);
		InCompletionOrderState inCompletionOrderState = new InCompletionOrderState(array, null);
		ImmutableList.Builder builder = ImmutableList.builderWithExpectedSize(array.Length);
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			builder.add(new InCompletionOrderFuture(inCompletionOrderState, null));
		}
		ImmutableList immutableList = builder.build();
		for (int j = 0; j < (nint)array.LongLength; j++)
		{
			int num = j;
			array[j].addListener(new _3(inCompletionOrderState, immutableList, num), MoreExecutors.directExecutor());
		}
		return immutableList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Exception;>(Ljava/util/concurrent/Future<TV;>;Ljava/lang/Class<TX;>;)TV;^TX;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(1232)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public static object getChecked(Future future, Class exceptionClass)
	{
		object @checked = FuturesGetChecked.getChecked(future, exceptionClass);
		_ = null;
		return @checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Exception;>(Ljava/util/concurrent/Future<TV;>;Ljava/lang/Class<TX;>;Ljava/time/Duration;)TV;^TX;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(1284)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public static object getChecked(Future future, Class exceptionClass, Duration timeout)
	{
		object @checked = getChecked(future, exceptionClass, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return @checked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TV;>;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 102, 0, 0 })]
	[LineNumberTable(new byte[] { 164, 239, 135, 124, 97, 107 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public static object getUnchecked(Future future)
	{
		//Discarded unreachable code: IL_000f
		Preconditions.checkNotNull(future);
		ExecutionException ex;
		try
		{
			return Uninterruptibles.getUninterruptibly(future);
		}
		catch (ExecutionException x)
		{
			ex = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ExecutionException @this = ex;
		wrapAndThrowUnchecked(Throwable.instancehelper_getCause(@this));
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
	}
}
