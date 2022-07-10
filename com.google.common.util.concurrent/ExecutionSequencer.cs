using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)44,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class ExecutionSequencer : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/AsyncCallable<TT;>;")]
	[EnclosingMethod(null, "submit", "(Ljava.util.concurrent.Callable;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ListenableFuture;")]
	internal class _1 : java.lang.Object, AsyncCallable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Callable val_0024callable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(150)]
		internal _1(ExecutionSequencer P_0, Callable P_1)
		{
			val_0024callable = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
		[LineNumberTable(153)]
		public virtual ListenableFuture call()
		{
			ListenableFuture result = Futures.immediateFuture(val_0024callable.call());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(158)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024callable);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/util/concurrent/AsyncCallable<TT;>;")]
	[EnclosingMethod(null, "submitAsync", "(Lcom.google.common.util.concurrent.AsyncCallable;Ljava.util.concurrent.Executor;)Lcom.google.common.util.concurrent.ListenableFuture;")]
	internal class _2 : java.lang.Object, AsyncCallable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TaskNonReentrantExecutor val_0024taskExecutor;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AsyncCallable val_0024callable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(177)]
		internal _2(ExecutionSequencer P_0, TaskNonReentrantExecutor P_1, AsyncCallable P_2)
		{
			val_0024taskExecutor = P_1;
			val_0024callable = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
		[LineNumberTable(new byte[] { 160, 66, 109, 136 })]
		public virtual ListenableFuture call()
		{
			if (!TaskNonReentrantExecutor.access_0024200(val_0024taskExecutor))
			{
				ListenableFuture result = Futures.immediateCancelledFuture();
				_ = null;
				return result;
			}
			ListenableFuture result2 = val_0024callable.call();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(188)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(val_0024callable);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/util/concurrent/ExecutionSequencer$RunningState;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class RunningState : java.lang.Enum
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static RunningState NOT_RUN;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static RunningState CANCELLED;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static RunningState STARTED;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static RunningState[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(262)]
		private RunningState(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(262)]
		private static RunningState[] _0024values()
		{
			return new RunningState[3] { NOT_RUN, CANCELLED, STARTED };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(262)]
		public static RunningState[] values()
		{
			return (RunningState[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(262)]
		public static RunningState valueOf(string P_0)
		{
			return (RunningState)java.lang.Enum.valueOf(ClassLiteral<RunningState>.Value, P_0);
		}

		[LineNumberTable(new byte[] { 160, 149, 112, 112, 240, 61 })]
		static RunningState()
		{
			NOT_RUN = new RunningState("NOT_RUN", 0);
			CANCELLED = new RunningState("CANCELLED", 1);
			STARTED = new RunningState("STARTED", 2);
			_0024VALUES = _0024values();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/concurrent/atomic/AtomicReference<Lcom/google/common/util/concurrent/ExecutionSequencer$RunningState;>;Ljava/util/concurrent/Executor;Ljava/lang/Runnable;")]
	[Implements(new string[] { "java.util.concurrent.Executor", "java.lang.Runnable" })]
	internal sealed class TaskNonReentrantExecutor : AtomicReference, Executor, Runnable
	{
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal ExecutionSequencer sequencer;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Executor @delegate;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Runnable task;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Thread submitting;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(286)]
		internal TaskNonReentrantExecutor(Executor P_0, ExecutionSequencer P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(286)]
		internal static bool access_0024400(TaskNonReentrantExecutor P_0)
		{
			bool result = P_0.trySetCancelled();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(286)]
		internal static bool access_0024200(TaskNonReentrantExecutor P_0)
		{
			bool result = P_0.trySetStarted();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(445)]
		private bool trySetCancelled()
		{
			bool result = compareAndSet(RunningState.NOT_RUN, RunningState.CANCELLED);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(441)]
		private bool trySetStarted()
		{
			bool result = compareAndSet(RunningState.NOT_RUN, RunningState.STARTED);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 197, 109, 103, 103 })]
		private TaskNonReentrantExecutor(Executor P_0, ExecutionSequencer P_1)
			: base(RunningState.NOT_RUN)
		{
			@delegate = P_0;
			sequencer = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 213, 109, 103, 103, 129, 235, 76, 118, 110,
			231, 69, 113, 135, 118, 169, 113, 103, 103, 235,
			71, 103, 35, 98, 98
		})]
		public virtual void execute(Runnable P_0)
		{
			if (get() == RunningState.CANCELLED)
			{
				@delegate = null;
				sequencer = null;
				return;
			}
			submitting = Thread.currentThread();
			try
			{
				ThreadConfinedTaskQueue threadConfinedTaskQueue = access_0024300((ExecutionSequencer)java.util.Objects.requireNonNull(sequencer));
				if (threadConfinedTaskQueue.thread == submitting)
				{
					sequencer = null;
					Preconditions.checkState(threadConfinedTaskQueue.nextTask == null);
					threadConfinedTaskQueue.nextTask = P_0;
					threadConfinedTaskQueue.nextExecutor = (Executor)java.util.Objects.requireNonNull(@delegate);
					@delegate = null;
				}
				else
				{
					Executor executor = (Executor)java.util.Objects.requireNonNull(@delegate);
					@delegate = null;
					task = P_0;
					executor.execute(this);
				}
			}
			finally
			{
				submitting = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 5, 102, 233, 69, 113, 103, 102, 225, 69,
			103, 231, 86, 119, 167, 113, 103, 230, 69, 150,
			103, 103, 237, 73, 103, 35, 98, 98
		})]
		public virtual void run()
		{
			Thread thread = Thread.currentThread();
			if (thread != submitting)
			{
				Runnable runnable = (Runnable)java.util.Objects.requireNonNull(task);
				task = null;
				runnable.run();
				return;
			}
			ThreadConfinedTaskQueue threadConfinedTaskQueue = new ThreadConfinedTaskQueue(null);
			threadConfinedTaskQueue.thread = thread;
			access_0024302((ExecutionSequencer)java.util.Objects.requireNonNull(sequencer), threadConfinedTaskQueue);
			sequencer = null;
			try
			{
				Runnable runnable2 = (Runnable)java.util.Objects.requireNonNull(task);
				task = null;
				runnable2.run();
				Runnable nextTask;
				Executor nextExecutor;
				while ((nextTask = threadConfinedTaskQueue.nextTask) != null && (nextExecutor = threadConfinedTaskQueue.nextExecutor) != null)
				{
					threadConfinedTaskQueue.nextTask = null;
					threadConfinedTaskQueue.nextExecutor = null;
					nextExecutor.execute(nextTask);
				}
			}
			finally
			{
				threadConfinedTaskQueue.thread = null;
			}
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected TaskNonReentrantExecutor(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ThreadConfinedTaskQueue : java.lang.Object
	{
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Thread thread;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Runnable nextTask;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Executor nextExecutor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(107)]
		internal ThreadConfinedTaskQueue(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(107)]
		private ThreadConfinedTaskQueue()
		{
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : Runnable
	{
		private readonly TrustedListenableFutureTask arg_00241;

		private readonly SettableFuture arg_00242;

		private readonly ListenableFuture arg_00243;

		private readonly ListenableFuture arg_00244;

		private readonly TaskNonReentrantExecutor arg_00245;

		internal ___003C_003EAnon0(TrustedListenableFutureTask P_0, SettableFuture P_1, ListenableFuture P_2, ListenableFuture P_3, TaskNonReentrantExecutor P_4)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
			arg_00245 = P_4;
		}

		public void run()
		{
			lambda_0024submitAsync_00240(arg_00241, arg_00242, arg_00243, arg_00244, arg_00245);
			_ = null;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/concurrent/atomic/AtomicReference<Lcom/google/common/util/concurrent/ListenableFuture<Ljava/lang/Void;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 19, 2, 3, 0, 3, 0, 0, 44,
		0, 0
	})]
	private AtomicReference @ref;

	private ThreadConfinedTaskQueue latestTaskQueue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 39, 232, 72, 97, 143, 236, 53 })]
	private ExecutionSequencer()
	{
		@ref = new AtomicReference(Futures.immediateVoidFuture());
		latestTaskQueue = new ThreadConfinedTaskQueue(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/AsyncCallable<TT;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 44, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		123, 103, 103, 105, 233, 90, 134, 178, 104, 137,
		233, 70, 243, 104, 110, 142
	})]
	public virtual ListenableFuture submitAsync(AsyncCallable callable, Executor executor)
	{
		Preconditions.checkNotNull(callable);
		Preconditions.checkNotNull(executor);
		TaskNonReentrantExecutor taskNonReentrantExecutor = new TaskNonReentrantExecutor(executor, this, null);
		_2  = new _2(this, taskNonReentrantExecutor, callable);
		SettableFuture settableFuture = SettableFuture.create();
		ListenableFuture listenableFuture = (ListenableFuture)@ref.getAndSet(settableFuture);
		TrustedListenableFutureTask trustedListenableFutureTask = TrustedListenableFutureTask.create();
		listenableFuture.addListener(trustedListenableFutureTask, taskNonReentrantExecutor);
		ListenableFuture listenableFuture2 = Futures.nonCancellationPropagating(trustedListenableFutureTask);
		Runnable runnable = new ___003C_003EAnon0(trustedListenableFutureTask, settableFuture, listenableFuture, listenableFuture2, taskNonReentrantExecutor);
		listenableFuture2.addListener(runnable, MoreExecutors.directExecutor());
		trustedListenableFutureTask.addListener(runnable, MoreExecutors.directExecutor());
		return listenableFuture2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 160, 104, 200, 106, 241, 91, 136 })]
	private static void lambda_0024submitAsync_00240(TrustedListenableFutureTask P_0, SettableFuture P_1, ListenableFuture P_2, ListenableFuture P_3, TaskNonReentrantExecutor P_4)
	{
		if (P_0.isDone())
		{
			P_1.setFuture(P_2);
		}
		else if (P_3.isCancelled() && TaskNonReentrantExecutor.access_0024400(P_4))
		{
			P_0.cancel(false);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(93)]
	public static ExecutionSequencer create()
	{
		ExecutionSequencer result = new ExecutionSequencer();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 44, 0, 0 })]
	[LineNumberTable(new byte[] { 97, 103, 103 })]
	public virtual ListenableFuture submit(Callable callable, Executor executor)
	{
		Preconditions.checkNotNull(callable);
		Preconditions.checkNotNull(executor);
		ListenableFuture result = submitAsync(new _1(this, callable), executor);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(87)]
	internal static ThreadConfinedTaskQueue access_0024300(ExecutionSequencer P_0)
	{
		return P_0.latestTaskQueue;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(87)]
	internal static ThreadConfinedTaskQueue access_0024302(ExecutionSequencer P_0, ThreadConfinedTaskQueue P_1)
	{
		P_0.latestTaskQueue = P_1;
		return P_1;
	}
}
