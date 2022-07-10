using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using java.util.concurrent.atomic;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)24,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class JdkFutureAdapters : java.lang.Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/ForwardingFuture<TV;>;Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 78, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)78,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.util.concurrent.ListenableFuture" })]
	internal class ListenableFutureAdapter : ForwardingFuture, ListenableFuture, Future
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Runnable
		{
			private readonly ListenableFutureAdapter arg_00241;

			internal ___003C_003EAnon0(ListenableFutureAdapter P_0)
			{
				arg_00241 = P_0;
			}

			public void run()
			{
				arg_00241.lambda_0024addListener_00240();
				_ = null;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static ThreadFactory threadFactory;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static Executor defaultAdapterExecutor;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Executor adapterExecutor;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private ExecutionList executionList;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private AtomicBoolean hasListeners;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/concurrent/Future<TV;>;")]
		private new Future m_delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/Future<TV;>;Ljava/util/concurrent/Executor;)V")]
		[LineNumberTable(new byte[] { 77, 232, 51, 203, 236, 74, 113, 113 })]
		internal ListenableFutureAdapter(Future P_0, Executor P_1)
		{
			executionList = new ExecutionList();
			hasListeners = new AtomicBoolean(initialValue: false);
			this.m_delegate = (Future)Preconditions.checkNotNull(P_0);
			adapterExecutor = (Executor)Preconditions.checkNotNull(P_1);
		}

		[Signature("()Ljava/util/concurrent/Future<TV;>;")]
		protected internal override Future @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(new byte[] { 110, 221, 226, 61, 193, 107 })]
		private void lambda_0024addListener_00240()
		{
			try
			{
				Uninterruptibles.getUninterruptibly(this.m_delegate);
			}
			catch (System.Exception x)
			{
				ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
				goto IL_001a;
			}
			goto IL_0020;
			IL_001a:
			_ = null;
			goto IL_0020;
			IL_0020:
			executionList.execute();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/Future<TV;>;)V")]
		[LineNumberTable(new byte[] { 74, 110 })]
		internal ListenableFutureAdapter(Future P_0)
			: this(P_0, defaultAdapterExecutor)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 89, 205, 111, 173, 109, 193, 248, 80 })]
		public virtual void addListener(Runnable P_0, Executor P_1)
		{
			executionList.add(P_0, P_1);
			if (hasListeners.compareAndSet(expect: false, update: true))
			{
				if (this.m_delegate.isDone())
				{
					executionList.execute();
				}
				else
				{
					adapterExecutor.execute(new ___003C_003EAnon0(this));
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(100)]
		protected internal new virtual object @delegate()
		{
			Future result = this.@delegate();
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 53, 134, 106, 101, 106, 101, 42 })]
		static ListenableFutureAdapter()
		{
			threadFactory = new ThreadFactoryBuilder().setDaemon(daemon: true).setNameFormat("ListenableFutureAdapter-thread-%d").build();
			defaultAdapterExecutor = Executors.newCachedThreadPool(threadFactory);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TV;>;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 24, 0, 0 })]
	[LineNumberTable(new byte[] { 6, 104, 135 })]
	public static ListenableFuture listenInPoolThread(Future future)
	{
		if (future is ListenableFuture)
		{
			return (ListenableFuture)future;
		}
		ListenableFutureAdapter result = new ListenableFutureAdapter(future);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 24, 0, 0 })]
	[LineNumberTable(new byte[] { 34, 103, 104, 135 })]
	public static ListenableFuture listenInPoolThread(Future future, Executor executor)
	{
		Preconditions.checkNotNull(executor);
		if (future is ListenableFuture)
		{
			return (ListenableFuture)future;
		}
		ListenableFutureAdapter result = new ListenableFutureAdapter(future, executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(171)]
	private JdkFutureAdapters()
	{
	}
}
