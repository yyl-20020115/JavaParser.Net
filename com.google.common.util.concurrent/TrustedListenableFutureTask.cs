using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/FluentFuture$TrustedFuture<TV;>;Ljava/util/concurrent/RunnableFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 46, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)46,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.RunnableFuture" })]
internal class TrustedListenableFutureTask : FluentFuture.TrustedFuture, RunnableFuture, Runnable, Future
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/InterruptibleTask<Lcom/google/common/util/concurrent/ListenableFuture<TV;>;>;")]
	internal sealed class TrustedFutureInterruptibleAsyncTask : InterruptibleTask
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/AsyncCallable<TV;>;")]
		private AsyncCallable callable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TrustedListenableFutureTask this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)V")]
		[LineNumberTable(new byte[] { 125, 109 })]
		internal virtual void afterRanInterruptiblySuccess(ListenableFuture P_0)
		{
			this_00240.setFuture(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		[LineNumberTable(new byte[] { 116, 102, 48 })]
		internal new virtual ListenableFuture runInterruptibly()
		{
			return (ListenableFuture)Preconditions.checkNotNull(callable.call(), "AsyncCallable.call returned null instead of a Future. Did you mean to return immediateFuture(null)? %s", callable);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AsyncCallable<TV;>;)V")]
		[LineNumberTable(new byte[] { 105, 111, 113 })]
		internal TrustedFutureInterruptibleAsyncTask(TrustedListenableFutureTask P_0, AsyncCallable P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			callable = (AsyncCallable)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(161)]
		internal sealed override bool isDone()
		{
			bool result = this_00240.isDone();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 66, 109 })]
		internal override void afterRanInterruptiblyFailure(System.Exception P_0)
		{
			this_00240.setException(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(185)]
		internal override string toPendingString()
		{
			string result = java.lang.Object.instancehelper_toString(callable);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(150)]
		internal override void afterRanInterruptiblySuccess(object P_0)
		{
			afterRanInterruptiblySuccess((ListenableFuture)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(150)]
		internal override object runInterruptibly()
		{
			ListenableFuture result = runInterruptibly();
			_ = null;
			return result;
		}

		[HideFromJava]
		static TrustedFutureInterruptibleAsyncTask()
		{
			InterruptibleTask.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected TrustedFutureInterruptibleAsyncTask(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/InterruptibleTask<TV;>;")]
	internal sealed class TrustedFutureInterruptibleTask : InterruptibleTask
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/concurrent/Callable<TV;>;")]
		private Callable callable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TrustedListenableFutureTask this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/Callable<TV;>;)V")]
		[LineNumberTable(new byte[] { 69, 111, 113 })]
		internal TrustedFutureInterruptibleTask(TrustedListenableFutureTask P_0, Callable P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			callable = (Callable)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(125)]
		internal sealed override bool isDone()
		{
			bool result = this_00240.isDone();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()TV;")]
		[LineNumberTable(131)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		internal override object runInterruptibly()
		{
			object result = callable.call();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)V")]
		[LineNumberTable(new byte[] { 86, 109 })]
		internal override void afterRanInterruptiblySuccess([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_0)
		{
			this_00240.set(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 91, 109 })]
		internal override void afterRanInterruptiblyFailure(System.Exception P_0)
		{
			this_00240.setException(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(146)]
		internal override string toPendingString()
		{
			string result = java.lang.Object.instancehelper_toString(callable);
			_ = null;
			return result;
		}

		[HideFromJava]
		static TrustedFutureInterruptibleTask()
		{
			InterruptibleTask.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected TrustedFutureInterruptibleTask(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("Lcom/google/common/util/concurrent/InterruptibleTask<*>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile InterruptibleTask task;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/lang/Runnable;TV;)Lcom/google/common/util/concurrent/TrustedListenableFutureTask<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 46, 0, 0 })]
	[LineNumberTable(58)]
	internal static TrustedListenableFutureTask create(Runnable P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_1)
	{
		TrustedListenableFutureTask result = new TrustedListenableFutureTask(Executors.callable(P_0, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;)Lcom/google/common/util/concurrent/TrustedListenableFutureTask<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 46, 0, 0 })]
	[LineNumberTable(44)]
	internal static TrustedListenableFutureTask create(Callable P_0)
	{
		TrustedListenableFutureTask result = new TrustedListenableFutureTask(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/AsyncCallable<TV;>;)Lcom/google/common/util/concurrent/TrustedListenableFutureTask<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 46, 0, 0 })]
	[LineNumberTable(40)]
	internal static TrustedListenableFutureTask create(AsyncCallable P_0)
	{
		TrustedListenableFutureTask result = new TrustedListenableFutureTask(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/AsyncCallable<TV;>;)V")]
	[LineNumberTable(new byte[] { 24, 104, 116 })]
	internal TrustedListenableFutureTask(AsyncCallable P_0)
	{
		task = new TrustedFutureInterruptibleAsyncTask(this, P_0);
		System.Threading.Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/Callable<TV;>;)V")]
	[LineNumberTable(new byte[] { 20, 104, 116 })]
	internal TrustedListenableFutureTask(Callable P_0)
	{
		task = new TrustedFutureInterruptibleTask(this, P_0);
		System.Threading.Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 30, 105, 99, 230, 70, 110 })]
	public virtual void run()
	{
		task?.run();
		task = null;
		System.Threading.Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 43, 134, 104, 105, 99, 198, 110 })]
	protected internal override void afterDone()
	{
		base.afterDone();
		if (wasInterrupted())
		{
			task?.interruptTask();
		}
		task = null;
		System.Threading.Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 105, 99, 159, 32 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal override string pendingToString()
	{
		InterruptibleTask interruptibleTask = task;
		if (interruptibleTask != null)
		{
			string text = java.lang.String.valueOf(interruptibleTask);
			int num = 7 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("task=[").append(text).append("]")
				.toString();
			_ = null;
			return result;
		}
		string result2 = base.pendingToString();
		_ = null;
		return result2;
	}

	[HideFromJava]
	static TrustedListenableFutureTask()
	{
		TrustedFuture.___003Cclinit_003E();
	}
}
