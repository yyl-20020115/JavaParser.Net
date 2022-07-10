using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.time;
using java.util;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)179,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class MoreExecutors : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "submitAndAddQueueListener", "(Lcom.google.common.util.concurrent.ListeningExecutorService;Ljava.util.concurrent.Callable;Ljava.util.concurrent.BlockingQueue;)Lcom.google.common.util.concurrent.ListenableFuture;")]
	internal class _1 : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal BlockingQueue val_0024queue;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ListenableFuture val_0024future;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(864)]
		internal _1(BlockingQueue P_0, ListenableFuture P_1)
		{
			val_0024queue = P_0;
			val_0024future = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 241, 114 })]
		public virtual void run()
		{
			val_0024queue.add(val_0024future);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "renamingDecorator", "(Ljava.util.concurrent.Executor;Lcom.google.common.base.Supplier;)Ljava.util.concurrent.Executor;")]
	internal class _2 : java.lang.Object, Executor
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Executor val_0024executor;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Supplier val_0024nameSupplier;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(977)]
		internal _2(Executor P_0, Supplier P_1)
		{
			val_0024executor = P_0;
			val_0024nameSupplier = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 98, 121 })]
		public virtual void execute(Runnable P_0)
		{
			val_0024executor.execute(Callables.threadRenaming(P_0, val_0024nameSupplier));
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "renamingDecorator", "(Ljava.util.concurrent.ExecutorService;Lcom.google.common.base.Supplier;)Ljava.util.concurrent.ExecutorService;")]
	[ConstantPool(new object[]
	{
		(byte)28,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _3 : WrappingExecutorService
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Supplier val_0024nameSupplier;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1001)]
		internal _3(ExecutorService P_0, Supplier P_1)
		{
			val_0024nameSupplier = P_1;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent/Callable<TT;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 28, 0, 0 })]
		[LineNumberTable(1004)]
		protected internal override Callable wrapTask(Callable P_0)
		{
			Callable result = Callables.threadRenaming(P_0, val_0024nameSupplier);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1009)]
		protected internal override Runnable wrapTask(Runnable P_0)
		{
			Runnable result = Callables.threadRenaming(P_0, val_0024nameSupplier);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "renamingDecorator", "(Ljava.util.concurrent.ScheduledExecutorService;Lcom.google.common.base.Supplier;)Ljava.util.concurrent.ScheduledExecutorService;")]
	[ConstantPool(new object[]
	{
		(byte)28,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _4 : WrappingScheduledExecutorService
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Supplier val_0024nameSupplier;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1030)]
		internal _4(ScheduledExecutorService P_0, Supplier P_1)
		{
			val_0024nameSupplier = P_1;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent/Callable<TT;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 28, 0, 0 })]
		[LineNumberTable(1033)]
		protected internal override Callable wrapTask(Callable P_0)
		{
			Callable result = Callables.threadRenaming(P_0, val_0024nameSupplier);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1038)]
		protected internal override Runnable wrapTask(Runnable P_0)
		{
			Runnable result = Callables.threadRenaming(P_0, val_0024nameSupplier);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "rejectionPropagatingExecutor", "(Ljava.util.concurrent.Executor;Lcom.google.common.util.concurrent.AbstractFuture;)Ljava.util.concurrent.Executor;")]
	internal class _5 : java.lang.Object, Executor
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Executor val_0024delegate;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractFuture val_0024future;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1137)]
		internal _5(Executor P_0, AbstractFuture P_1)
		{
			val_0024delegate = P_0;
			val_0024future = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 3, 190, 2, 97, 141 })]
		public virtual void execute(Runnable P_0)
		{
			RejectedExecutionException ex;
			try
			{
				val_0024delegate.execute(P_0);
				return;
			}
			catch (RejectedExecutionException x)
			{
				ex = ByteCodeHelper.MapException<RejectedExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			RejectedExecutionException exception = ex;
			val_0024future.setException(exception);
		}
	}

	internal class Application : java.lang.Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "addDelayedShutdownHook", "(Ljava.util.concurrent.ExecutorService;JLjava.util.concurrent.TimeUnit;)V")]
		internal class _1 : java.lang.Object, Runnable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ExecutorService val_0024service;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal long val_0024terminationTimeout;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TimeUnit val_0024timeUnit;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(267)]
			internal _1(Application P_0, ExecutorService P_1, long P_2, TimeUnit P_3)
			{
				val_0024service = P_1;
				val_0024terminationTimeout = P_2;
				val_0024timeUnit = P_3;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 162, 107, 191, 4, 2, 161 })]
			public virtual void run()
			{
				try
				{
					val_0024service.shutdown();
					val_0024service.awaitTermination(val_0024terminationTimeout, val_0024timeUnit);
					return;
				}
				catch (InterruptedException)
				{
				}
				_ = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(233)]
		internal Application()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 123, 102, 103, 105 })]
		internal ExecutorService getExitingExecutorService(ThreadPoolExecutor P_0, long P_1, TimeUnit P_2)
		{
			access_0024000(P_0);
			ExecutorService result = Executors.unconfigurableExecutorService(P_0);
			addDelayedShutdownHook(P_0, P_1, P_2);
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(244)]
		internal ExecutorService getExitingExecutorService(ThreadPoolExecutor P_0)
		{
			ExecutorService exitingExecutorService = getExitingExecutorService(P_0, 120L, TimeUnit.SECONDS);
			_ = null;
			return exitingExecutorService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 135, 102, 103, 105 })]
		internal ScheduledExecutorService getExitingScheduledExecutorService(ScheduledThreadPoolExecutor P_0, long P_1, TimeUnit P_2)
		{
			access_0024000(P_0);
			ScheduledExecutorService result = Executors.unconfigurableScheduledExecutorService(P_0);
			addDelayedShutdownHook(P_0, P_1, P_2);
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(257)]
		internal ScheduledExecutorService getExitingScheduledExecutorService(ScheduledThreadPoolExecutor P_0)
		{
			ScheduledExecutorService exitingScheduledExecutorService = getExitingScheduledExecutorService(P_0, 120L, TimeUnit.SECONDS);
			_ = null;
			return exitingScheduledExecutorService;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 148, 103, 103, 127, 30, 37, 231, 83 })]
		internal void addDelayedShutdownHook(ExecutorService P_0, long P_1, TimeUnit P_2)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkNotNull(P_2);
			string text = java.lang.String.valueOf(P_0);
			int num = 24 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			addShutdownHook(newThread(new StringBuilder(num).append("DelayedShutdownHook-for-").append(text).toString(), new _1(this, P_0, P_1, P_2)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 173, 109 })]
		internal virtual void addShutdownHook(java.lang.Thread P_0)
		{
			Runtime.getRuntime().addShutdownHook(P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class DirectExecutorService : AbstractListeningExecutorService
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object @lock;

		private int runningTasks;

		private new bool m_shutdown;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(302)]
		internal DirectExecutorService(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 188, 136, 235, 73, 167 })]
		private DirectExecutorService()
		{
			@lock = new java.lang.Object();
			runningTasks = 0;
			this.m_shutdown = false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 14, 109, 104, 144, 110, 111 })]
		private void startTask()
		{
			lock (@lock)
			{
				if (this.m_shutdown)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new RejectedExecutionException("Executor already shutdown");
				}
				runningTasks++;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 24, 109, 116, 99, 139, 111 })]
		private void endTask()
		{
			lock (@lock)
			{
				int num = runningTasks - 1;
				runningTasks = num;
				if (num == 0)
				{
					java.lang.Object.instancehelper_notifyAll(@lock);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 224, 109, 103, 104, 139, 111 })]
		public override void shutdown()
		{
			lock (@lock)
			{
				this.m_shutdown = true;
				if (runningTasks == 0)
				{
					java.lang.Object.instancehelper_notifyAll(@lock);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 207, 134, 138, 102, 35, 98, 98 })]
		public override void execute(Runnable P_0)
		{
			startTask();
			try
			{
				P_0.run();
			}
			finally
			{
				endTask();
			}
		}

		[LineNumberTable(new byte[] { 160, 217, 109, 108 })]
		public override bool isShutdown()
		{
			//Discarded unreachable code: IL_0015
			lock (@lock)
			{
				return this.m_shutdown;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<Ljava/lang/Runnable;>;")]
		[LineNumberTable(new byte[] { 160, 235, 102 })]
		public override List shutdownNow()
		{
			shutdown();
			List result = Collections.emptyList();
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 160, 241, 109, 122 })]
		public override bool isTerminated()
		{
			//Discarded unreachable code: IL_0023
			lock (@lock)
			{
				return (this.m_shutdown && runningTasks == 0) ? true : false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException" })]
		[LineNumberTable(new byte[]
		{
			160, 248, 104, 141, 112, 106, 101, 138, 102, 113,
			106, 152
		})]
		public override bool awaitTermination(long P_0, TimeUnit P_1)
		{
			long num = P_1.toNanos(P_0);
			object obj;
			System.Threading.Monitor.Enter(obj = @lock);
			System.Exception ex;
			try
			{
				while (true)
				{
					if (this.m_shutdown && runningTasks == 0)
					{
						System.Threading.Monitor.Exit(obj);
						return true;
					}
					if (num <= 0)
					{
						break;
					}
					long num2 = java.lang.System.nanoTime();
					TimeUnit.NANOSECONDS.timedWait(@lock, num);
					num -= java.lang.System.nanoTime() - num2;
				}
				System.Threading.Monitor.Exit(obj);
				return false;
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception ex2 = ex;
			System.Exception ex4;
			while (true)
			{
				System.Exception ex3 = ex2;
				try
				{
					ex4 = ex3;
					System.Threading.Monitor.Exit(obj);
				}
				catch (System.Exception x2)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
					goto IL_008f;
				}
				break;
				IL_008f:
				ex2 = ex3;
			}
			throw Throwable.___003Cunmap_003E(ex4);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class ListeningDecorator : AbstractListeningExecutorService
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ExecutorService @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 230, 104, 113 })]
		internal ListeningDecorator(ExecutorService P_0)
		{
			@delegate = (ExecutorService)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.InterruptedException" })]
		[LineNumberTable(606)]
		public sealed override bool awaitTermination(long P_0, TimeUnit P_1)
		{
			bool result = @delegate.awaitTermination(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(611)]
		public sealed override bool isShutdown()
		{
			bool result = @delegate.isShutdown();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(616)]
		public sealed override bool isTerminated()
		{
			bool result = @delegate.isTerminated();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 251, 109 })]
		public sealed override void shutdown()
		{
			@delegate.shutdown();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<Ljava/lang/Runnable;>;")]
		[LineNumberTable(626)]
		public sealed override List shutdownNow()
		{
			List result = @delegate.shutdownNow();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 5, 110 })]
		public sealed override void execute(Runnable P_0)
		{
			@delegate.execute(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(636)]
		public sealed override string toString()
		{
			string text = base.toString();
			string text2 = java.lang.String.valueOf(@delegate);
			int num = 2 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append("[").append(text2)
				.append("]")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[ConstantPool(new object[]
	{
		(byte)50,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.util.concurrent.ListeningScheduledExecutorService" })]
	internal sealed class ScheduledListeningDecorator : ListeningDecorator, ListeningScheduledExecutorService, ScheduledExecutorService, ExecutorService, Executor, ListeningExecutorService
	{
		[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ForwardingListenableFuture$SimpleForwardingListenableFuture<TV;>;Lcom/google/common/util/concurrent/ListenableScheduledFuture<TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 53, 0, 0 })]
		[ConstantPool(new object[]
		{
			(byte)53,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[Implements(new string[] { "com.google.common.util.concurrent.ListenableScheduledFuture" })]
		internal sealed class ListenableScheduledTask : ForwardingListenableFuture.SimpleForwardingListenableFuture, ListenableScheduledFuture, ScheduledFuture, Delayed, Comparable, Future, ListenableFuture
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			[Signature("Ljava/util/concurrent/ScheduledFuture<*>;")]
			private ScheduledFuture scheduledDelegate;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(714)]
			public virtual int compareTo(Delayed P_0)
			{
				int result = Comparable.__Helper.compareTo(scheduledDelegate, P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;Ljava/util/concurrent/ScheduledFuture<*>;)V")]
			[LineNumberTable(new byte[] { 162, 65, 105, 103 })]
			public ListenableScheduledTask(ListenableFuture P_0, ScheduledFuture P_1)
				: base(P_0)
			{
				scheduledDelegate = P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 158, 224, 98, 104, 131, 205 })]
			public override bool cancel(bool P_0)
			{
				int num = (base.cancel(P_0) ? 1 : 0);
				if (num != 0)
				{
					scheduledDelegate.cancel(P_0);
				}
				return (byte)num != 0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(709)]
			public virtual long getDelay(TimeUnit P_0)
			{
				long delay = scheduledDelegate.getDelay(P_0);
				_ = null;
				return delay;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(684)]
			public virtual int compareTo(object P_0)
			{
				int result = compareTo((Delayed)P_0);
				_ = null;
				return result;
			}

			int IComparable.Comparable_003A_003AcompareTo(object P_0)
			{
				return compareTo(P_0);
			}
		}

		[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/AbstractFuture$TrustedFuture<Ljava/lang/Void;>;Ljava/lang/Runnable;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0,
			1,
			16,
			byte.MaxValue,
			byte.MaxValue,
			1,
			3,
			0,
			0,
			47,
			0,
			0
		})]
		[ConstantPool(new object[]
		{
			(byte)47,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[Implements(new string[] { "java.lang.Runnable" })]
		internal sealed class NeverSuccessfulListenableFutureTask : AbstractFuture.TrustedFuture, Runnable
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private Runnable @delegate;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 97, 104, 113 })]
			public NeverSuccessfulListenableFutureTask(Runnable P_0)
			{
				@delegate = (Runnable)Preconditions.checkNotNull(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 104, 221, 226, 61, 97, 104, 140 })]
			public virtual void run()
			{
				System.Exception ex;
				try
				{
					@delegate.run();
					return;
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				}
				System.Exception ex2 = ex;
				base.setException(ex2);
				throw Throwable.___003Cunmap_003E(Throwables.propagate(ex2));
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(739)]
			protected internal override string pendingToString()
			{
				string text = java.lang.String.valueOf(@delegate);
				int num = 7 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string result = new StringBuilder(num).append("task=[").append(text).append("]")
					.toString();
				_ = null;
				return result;
			}

			[HideFromJava]
			static NeverSuccessfulListenableFutureTask()
			{
				TrustedFuture.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Final)]
		internal ScheduledExecutorService @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 21, 105, 113 })]
		internal ScheduledListeningDecorator(ScheduledExecutorService P_0)
			: base(P_0)
		{
			@delegate = (ScheduledExecutorService)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
		[LineNumberTable(new byte[] { 162, 52, 103, 107, 102 })]
		public virtual ListenableScheduledFuture scheduleWithFixedDelay(Runnable P_0, long P_1, long P_2, TimeUnit P_3)
		{
			NeverSuccessfulListenableFutureTask neverSuccessfulListenableFutureTask = new NeverSuccessfulListenableFutureTask(P_0);
			ScheduledFuture scheduledFuture = @delegate.scheduleWithFixedDelay(neverSuccessfulListenableFutureTask, P_1, P_2, P_3);
			ListenableScheduledTask result = new ListenableScheduledTask(neverSuccessfulListenableFutureTask, scheduledFuture);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
		[LineNumberTable(new byte[] { 162, 44, 103, 113 })]
		public virtual ListenableScheduledFuture scheduleAtFixedRate(Runnable P_0, long P_1, long P_2, TimeUnit P_3)
		{
			NeverSuccessfulListenableFutureTask neverSuccessfulListenableFutureTask = new NeverSuccessfulListenableFutureTask(P_0);
			ScheduledFuture scheduledFuture = @delegate.scheduleAtFixedRate(neverSuccessfulListenableFutureTask, P_1, P_2, P_3);
			ListenableScheduledTask result = new ListenableScheduledTask(neverSuccessfulListenableFutureTask, scheduledFuture);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;JLjava/util/concurrent/TimeUnit;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 50, 0, 0 })]
		[LineNumberTable(new byte[] { 162, 36, 103, 111 })]
		public virtual ListenableScheduledFuture schedule(Callable P_0, long P_1, TimeUnit P_2)
		{
			TrustedListenableFutureTask trustedListenableFutureTask = TrustedListenableFutureTask.create(P_0);
			ScheduledFuture scheduledFuture = @delegate.schedule(trustedListenableFutureTask, P_1, P_2);
			ListenableScheduledTask result = new ListenableScheduledTask(trustedListenableFutureTask, scheduledFuture);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
		[LineNumberTable(new byte[] { 162, 27, 98, 102, 111 })]
		public virtual ListenableScheduledFuture schedule(Runnable P_0, long P_1, TimeUnit P_2)
		{
			TrustedListenableFutureTask trustedListenableFutureTask = TrustedListenableFutureTask.create(P_0, null);
			ScheduledFuture scheduledFuture = @delegate.schedule(trustedListenableFutureTask, P_1, P_2);
			ListenableScheduledTask result = new ListenableScheduledTask(trustedListenableFutureTask, scheduledFuture);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(640)]
		public virtual ScheduledFuture scheduleWithFixedDelay(Runnable P_0, long P_1, long P_2, TimeUnit P_3)
		{
			ListenableScheduledFuture result = this.scheduleWithFixedDelay(P_0, P_1, P_2, P_3);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(640)]
		public virtual ScheduledFuture scheduleAtFixedRate(Runnable P_0, long P_1, long P_2, TimeUnit P_3)
		{
			ListenableScheduledFuture result = this.scheduleAtFixedRate(P_0, P_1, P_2, P_3);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 50, 0, 0 })]
		[LineNumberTable(640)]
		public virtual ScheduledFuture schedule(Callable P_0, long P_1, TimeUnit P_2)
		{
			ListenableScheduledFuture result = this.schedule(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(640)]
		public virtual ScheduledFuture schedule(Runnable P_0, long P_1, TimeUnit P_2)
		{
			ListenableScheduledFuture result = this.schedule(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ListenableScheduledFuture schedule(Runnable P_0, Duration P_1)
		{
			return ListeningScheduledExecutorService._003Cdefault_003Eschedule(this, P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ListenableScheduledFuture schedule(Callable P_0, Duration P_1)
		{
			return ListeningScheduledExecutorService._003Cdefault_003Eschedule(this, P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ListenableScheduledFuture scheduleAtFixedRate(Runnable P_0, Duration P_1, Duration P_2)
		{
			return ListeningScheduledExecutorService._003Cdefault_003EscheduleAtFixedRate(this, P_0, P_1, P_2);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual ListenableScheduledFuture scheduleWithFixedDelay(Runnable P_0, Duration P_1, Duration P_2)
		{
			return ListeningScheduledExecutorService._003Cdefault_003EscheduleWithFixedDelay(this, P_0, P_1, P_2);
		}

		ScheduledFuture ListeningScheduledExecutorService.ListeningScheduledExecutorService_003A_003AscheduleWithFixedDelay(Runnable P_0, long P_1, long P_2, TimeUnit P_3)
		{
			return this.scheduleWithFixedDelay(P_0, P_1, P_2, P_3);
		}

		ScheduledFuture ListeningScheduledExecutorService.ListeningScheduledExecutorService_003A_003AscheduleAtFixedRate(Runnable P_0, long P_1, long P_2, TimeUnit P_3)
		{
			return this.scheduleAtFixedRate(P_0, P_1, P_2, P_3);
		}

		ScheduledFuture ListeningScheduledExecutorService.ListeningScheduledExecutorService_003A_003Aschedule(Callable P_0, long P_1, TimeUnit P_2)
		{
			return this.schedule(P_0, P_1, P_2);
		}

		ScheduledFuture ListeningScheduledExecutorService.ListeningScheduledExecutorService_003A_003Aschedule(Runnable P_0, long P_1, TimeUnit P_2)
		{
			return this.schedule(P_0, P_1, P_2);
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

		List ExecutorService.ExecutorService_003A_003AinvokeAll(Collection P_0)
		{
			return invokeAll(P_0);
		}

		List ExecutorService.ExecutorService_003A_003AinvokeAll(Collection P_0, long P_1, TimeUnit P_2)
		{
			return invokeAll(P_0, P_1, P_2);
		}

		object ExecutorService.ExecutorService_003A_003AinvokeAny(Collection P_0)
		{
			return invokeAny(P_0);
		}

		object ExecutorService.ExecutorService_003A_003AinvokeAny(Collection P_0, long P_1, TimeUnit P_2)
		{
			return invokeAny(P_0, P_1, P_2);
		}

		List ListeningExecutorService.ListeningExecutorService_003A_003AinvokeAll(Collection P_0)
		{
			return invokeAll(P_0);
		}

		List ListeningExecutorService.ListeningExecutorService_003A_003AinvokeAll(Collection P_0, long P_1, TimeUnit P_2)
		{
			return invokeAll(P_0, P_1, P_2);
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(496)]
	public static Executor directExecutor()
	{
		return DirectExecutor.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/Executor;Lcom/google/common/util/concurrent/AbstractFuture<*>;)Ljava/util/concurrent/Executor;")]
	[LineNumberTable(new byte[] { 163, 249, 103, 103, 136, 130 })]
	internal static Executor rejectionPropagatingExecutor(Executor P_0, AbstractFuture P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		if (P_0 == directExecutor())
		{
			return P_0;
		}
		_5 result = new _5(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/Executor;Lcom/google/common/base/Supplier<Ljava/lang/String;>;)Ljava/util/concurrent/Executor;")]
	[LineNumberTable(new byte[] { 163, 93, 103, 103 })]
	internal static Executor renamingDecorator(Executor P_0, Supplier P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		_2 result = new _2(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 66, 103, 103, 140, 178, 2, 161 })]
	internal static java.lang.Thread newThread(string P_0, Runnable P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		java.lang.Thread thread = platformThreadFactory().newThread(P_1);
		try
		{
			thread.setName(P_0);
			return thread;
		}
		catch (SecurityException)
		{
		}
		_ = null;
		return thread;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/ScheduledExecutorService;Lcom/google/common/base/Supplier<Ljava/lang/String;>;)Ljava/util/concurrent/ScheduledExecutorService;")]
	[LineNumberTable(new byte[] { 163, 146, 103, 103 })]
	internal static ScheduledExecutorService renamingDecorator(ScheduledExecutorService P_0, Supplier P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		_4 result = new _4(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 179, 135, 102, 106, 229, 60, 231, 69 })]
	private static void useDaemonThreadFactory(ThreadPoolExecutor P_0)
	{
		P_0.setThreadFactory(new ThreadFactoryBuilder().setDaemon(daemon: true).setThreadFactory(P_0.getThreadFactory()).build());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(109)]
	public static ExecutorService getExitingExecutorService(ThreadPoolExecutor executor, long terminationTimeout, TimeUnit timeUnit)
	{
		ExecutorService exitingExecutorService = new Application().getExitingExecutorService(executor, terminationTimeout, timeUnit);
		_ = null;
		return exitingExecutorService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 120, 104, 39 })]
	public static ScheduledExecutorService getExitingScheduledExecutorService(ScheduledThreadPoolExecutor executor, long terminationTimeout, TimeUnit timeUnit)
	{
		ScheduledExecutorService exitingScheduledExecutorService = new Application().getExitingScheduledExecutorService(executor, terminationTimeout, timeUnit);
		_ = null;
		return exitingScheduledExecutorService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 113, 111 })]
	public static void addDelayedShutdownHook(ExecutorService service, long terminationTimeout, TimeUnit timeUnit)
	{
		new Application().addDelayedShutdownHook(service, terminationTimeout, timeUnit);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListeningExecutorService;Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;ZJLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 179, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		158,
		202,
		98,
		103,
		104,
		103,
		105,
		103,
		102,
		234,
		75,
		99,
		110,
		136,
		122,
		100,
		231,
		104,
		127,
		0,
		105,
		98,
		227,
		24,
		109,
		103,
		100,
		100,
		122,
		107,
		100,
		101,
		99,
		116,
		100,
		139,
		103,
		106,
		100,
		98,
		173,
		100,
		134,
		byte.MaxValue,
		11,
		78,
		127,
		0,
		105,
		98,
		245,
		61,
		127,
		0,
		105,
		226,
		48,
		99,
		98,
		164,
		6,
		98,
		237,
		74,
		127,
		0,
		105,
		98,
		227,
		54,
		133,
		100,
		136,
		136,
		127,
		0,
		105,
		98
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	internal static object invokeAnyImpl(ListeningExecutorService P_0, Collection P_1, bool P_2, long P_3, TimeUnit P_4)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_4);
		int num = P_1.size();
		Preconditions.checkArgument(num > 0);
		ArrayList arrayList = Lists.newArrayListWithCapacity(num);
		LinkedBlockingQueue linkedBlockingQueue = Queues.newLinkedBlockingQueue();
		long num2 = P_4.toNanos(P_3);
		ExecutionException ex;
		long num3;
		Iterator iterator;
		int num4;
		try
		{
			ex = null;
			num3 = ((!P_2) ? 0 : java.lang.System.nanoTime());
			iterator = P_1.iterator();
			((List)arrayList).add((object)submitAndAddQueueListener(P_0, (Callable)iterator.next(), linkedBlockingQueue));
			num += -1;
			num4 = 1;
		}
		catch
		{
			//try-fault
			Iterator iterator2 = ((List)arrayList).iterator();
			while (iterator2.hasNext())
			{
				Future future = (Future)iterator2.next();
				future.cancel(mayInterruptIfRunning: true);
			}
			throw;
		}
		while (true)
		{
			object result;
			ExecutionException ex2;
			RuntimeException ex4;
			try
			{
				Future future2 = (Future)((Queue)linkedBlockingQueue).poll();
				if (future2 != null)
				{
					goto IL_0137;
				}
				if (num > 0)
				{
					num += -1;
					((List)arrayList).add((object)submitAndAddQueueListener(P_0, (Callable)iterator.next(), linkedBlockingQueue));
					num4++;
					goto IL_0137;
				}
				if (num4 == 0)
				{
					break;
				}
				if (P_2)
				{
					future2 = (Future)((BlockingQueue)linkedBlockingQueue).poll(num2, TimeUnit.NANOSECONDS);
					if (future2 == null)
					{
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new java.util.concurrent.TimeoutException();
					}
					long num5 = java.lang.System.nanoTime();
					num2 -= num5 - num3;
					num3 = num5;
				}
				else
				{
					future2 = (Future)((BlockingQueue)linkedBlockingQueue).take();
				}
				goto IL_0137;
				IL_0137:
				if (future2 == null)
				{
					continue;
				}
				num4 += -1;
				try
				{
					try
					{
						result = future2.get();
					}
					catch (ExecutionException x)
					{
						ex2 = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
						goto IL_01a2;
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
					goto IL_01a6;
				}
				goto IL_01aa;
			}
			catch
			{
				//try-fault
				Iterator iterator2 = ((List)arrayList).iterator();
				while (iterator2.hasNext())
				{
					Future future = (Future)iterator2.next();
					future.cancel(mayInterruptIfRunning: true);
				}
				throw;
			}
			IL_01aa:
			Iterator iterator3 = ((List)arrayList).iterator();
			while (iterator3.hasNext())
			{
				Future future3 = (Future)iterator3.next();
				future3.cancel(mayInterruptIfRunning: true);
			}
			return result;
			IL_01a6:
			RuntimeException ex5 = ex4;
			try
			{
				RuntimeException cause = ex5;
				ex = new ExecutionException(cause);
			}
			catch
			{
				//try-fault
				Iterator iterator2 = ((List)arrayList).iterator();
				while (iterator2.hasNext())
				{
					Future future = (Future)iterator2.next();
					future.cancel(mayInterruptIfRunning: true);
				}
				throw;
			}
			continue;
			IL_01a2:
			ExecutionException ex6 = ex2;
			ex = ex6;
		}
		try
		{
			if (ex == null)
			{
				ex = new ExecutionException(null);
			}
			throw Throwable.___003Cunmap_003E(ex);
		}
		catch
		{
			//try-fault
			Iterator iterator2 = ((List)arrayList).iterator();
			while (iterator2.hasNext())
			{
				Future future = (Future)iterator2.next();
				future.cancel(mayInterruptIfRunning: true);
			}
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListeningExecutorService;Ljava/util/concurrent/Callable<TT;>;Ljava/util/concurrent/BlockingQueue<Ljava/util/concurrent/Future<TT;>;>;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 179, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 236, 104, 232, 71, 229, 57, 229, 72 })]
	private static ListenableFuture submitAndAddQueueListener(ListeningExecutorService P_0, Callable P_1, BlockingQueue P_2)
	{
		ListenableFuture listenableFuture = P_0.submit(P_1);
		listenableFuture.addListener(new _1(P_2, listenableFuture), directExecutor());
		return listenableFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 31, 108, 162, 187, 2, 97, 194, 122, 113,
		31, 14, 193, 129, 98, 129, 98, 129, 98, 129
	})]
	private static bool isAppEngineWithApiClasses()
	{
		//Discarded unreachable code: IL_006b
		if (java.lang.System.getProperty("com.google.appengine.runtime.environment") == null)
		{
			return false;
		}
		try
		{
			Class.forName("com.google.appengine.api.utils.SystemProperty", MoreExecutors.___003CGetCallerID_003E());
		}
		catch (java.lang.ClassNotFoundException)
		{
			goto IL_0026;
		}
		try
		{
			try
			{
				try
				{
					try
					{
						return Class.forName("com.google.apphosting.api.ApiProxy", MoreExecutors.___003CGetCallerID_003E()).getMethod("getCurrentEnvironment", new Class[0], MoreExecutors.___003CGetCallerID_003E()).invoke(null, new object[0], MoreExecutors.___003CGetCallerID_003E()) != null;
					}
					catch (java.lang.ClassNotFoundException)
					{
					}
				}
				catch (InvocationTargetException)
				{
					goto IL_007d;
				}
			}
			catch (IllegalAccessException)
			{
				goto IL_0080;
			}
		}
		catch (NoSuchMethodException)
		{
			goto IL_0083;
		}
		_ = null;
		return false;
		IL_0083:
		_ = null;
		return false;
		IL_0080:
		_ = null;
		return false;
		IL_0026:
		_ = null;
		return false;
		IL_007d:
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163,
		5,
		103,
		166,
		101,
		117,
		113,
		byte.MaxValue,
		43,
		61,
		225,
		73,
		98,
		114,
		98,
		114,
		98,
		114,
		98
	})]
	public static ThreadFactory platformThreadFactory()
	{
		//Discarded unreachable code: IL_0049
		if (!isAppEngineWithApiClasses())
		{
			return Executors.defaultThreadFactory();
		}
		IllegalAccessException ex;
		java.lang.ClassNotFoundException ex2;
		NoSuchMethodException ex3;
		InvocationTargetException ex4;
		try
		{
			try
			{
				try
				{
					try
					{
						return (ThreadFactory)Class.forName("com.google.appengine.api.ThreadManager", MoreExecutors.___003CGetCallerID_003E()).getMethod("currentRequestThreadFactory", new Class[0], MoreExecutors.___003CGetCallerID_003E()).invoke(null, new object[0], MoreExecutors.___003CGetCallerID_003E());
					}
					catch (IllegalAccessException x)
					{
						ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					}
				}
				catch (java.lang.ClassNotFoundException x2)
				{
					ex2 = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0078;
				}
			}
			catch (NoSuchMethodException x3)
			{
				ex3 = ByteCodeHelper.MapException<NoSuchMethodException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_007b;
			}
		}
		catch (InvocationTargetException x4)
		{
			ex4 = ByteCodeHelper.MapException<InvocationTargetException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_007e;
		}
		IllegalAccessException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("Couldn't invoke ThreadManager.currentRequestThreadFactory", cause);
		IL_007b:
		NoSuchMethodException cause2 = ex3;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("Couldn't invoke ThreadManager.currentRequestThreadFactory", cause2);
		IL_0078:
		java.lang.ClassNotFoundException cause3 = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("Couldn't invoke ThreadManager.currentRequestThreadFactory", cause3);
		IL_007e:
		InvocationTargetException ex5 = ex4;
		throw Throwable.___003Cunmap_003E(Throwables.propagate(ex5.getCause()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 221, 139, 166, 142, 135, 248, 71, 226, 59,
		129, 138, 135
	})]
	public static bool shutdownAndAwaitTermination(ExecutorService service, long timeout, TimeUnit unit)
	{
		long timeout2 = unit.toNanos(timeout) / 2;
		service.shutdown();
		try
		{
			if (!service.awaitTermination(timeout2, TimeUnit.NANOSECONDS))
			{
				service.shutdownNow();
				service.awaitTermination(timeout2, TimeUnit.NANOSECONDS);
			}
		}
		catch (InterruptedException)
		{
			goto IL_003b;
		}
		goto IL_0052;
		IL_003b:
		_ = null;
		java.lang.Thread.currentThread().interrupt();
		service.shutdownNow();
		goto IL_0052;
		IL_0052:
		return service.isTerminated();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	private MoreExecutors()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 37, 98, 42 })]
	public static ExecutorService getExitingExecutorService(ThreadPoolExecutor executor, Duration terminationTimeout)
	{
		ExecutorService exitingExecutorService = getExitingExecutorService(executor, Internal.toNanosSaturated(terminationTimeout), TimeUnit.NANOSECONDS);
		_ = null;
		return exitingExecutorService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(128)]
	public static ExecutorService getExitingExecutorService(ThreadPoolExecutor executor)
	{
		ExecutorService exitingExecutorService = new Application().getExitingExecutorService(executor);
		_ = null;
		return exitingExecutorService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 98, 98, 42 })]
	public static ScheduledExecutorService getExitingScheduledExecutorService(ScheduledThreadPoolExecutor executor, Duration terminationTimeout)
	{
		ScheduledExecutorService exitingScheduledExecutorService = getExitingScheduledExecutorService(executor, Internal.toNanosSaturated(terminationTimeout), TimeUnit.NANOSECONDS);
		_ = null;
		return exitingScheduledExecutorService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(191)]
	public static ScheduledExecutorService getExitingScheduledExecutorService(ScheduledThreadPoolExecutor executor)
	{
		ScheduledExecutorService exitingScheduledExecutorService = new Application().getExitingScheduledExecutorService(executor);
		_ = null;
		return exitingScheduledExecutorService;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 94, 115 })]
	public static void addDelayedShutdownHook(ExecutorService service, Duration terminationTimeout)
	{
		addDelayedShutdownHook(service, Internal.toNanosSaturated(terminationTimeout), TimeUnit.NANOSECONDS);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(431)]
	public static ListeningExecutorService newDirectExecutorService()
	{
		DirectExecutorService result = new DirectExecutorService(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(545)]
	public static Executor newSequentialExecutor(Executor @delegate)
	{
		SequentialExecutor result = new SequentialExecutor(@delegate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 195, 104, 104, 104, 109, 230, 60 })]
	public static ListeningExecutorService listeningDecorator(ExecutorService @delegate)
	{
		ListeningExecutorService obj = ((@delegate is ListeningExecutorService) ? ((ListeningExecutorService)@delegate) : ((!(@delegate is ScheduledExecutorService)) ? new ListeningDecorator(@delegate) : new ScheduledListeningDecorator((ScheduledExecutorService)@delegate)));
		ListeningExecutorService result = ((obj == null) ? null : ((obj as ListeningExecutorService) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 221, 104, 104, 6 })]
	public static ListeningScheduledExecutorService listeningDecorator(ScheduledExecutorService @delegate)
	{
		ListeningScheduledExecutorService obj = ((!(@delegate is ListeningScheduledExecutorService)) ? new ScheduledListeningDecorator(@delegate) : ((ListeningScheduledExecutorService)@delegate));
		ListeningScheduledExecutorService result = ((obj == null) ? null : ((obj as ListeningScheduledExecutorService) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListeningExecutorService;Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;ZLjava/time/Duration;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 179, 0, 0 })]
	[LineNumberTable(new byte[] { 158, 207, 162, 100, 42 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	internal static object invokeAnyImpl(ListeningExecutorService P_0, Collection P_1, bool P_2, Duration P_3)
	{
		object result = invokeAnyImpl(P_0, P_1, P_2, Internal.toNanosSaturated(P_3), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/ExecutorService;Lcom/google/common/base/Supplier<Ljava/lang/String;>;)Ljava/util/concurrent/ExecutorService;")]
	[LineNumberTable(new byte[] { 163, 117, 103, 103 })]
	internal static ExecutorService renamingDecorator(ExecutorService P_0, Supplier P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		_3 result = new _3(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1070)]
	public static bool shutdownAndAwaitTermination(ExecutorService service, Duration timeout)
	{
		bool result = shutdownAndAwaitTermination(service, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(67)]
	internal static void access_0024000(ThreadPoolExecutor P_0)
	{
		useDaemonThreadFactory(P_0);
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
