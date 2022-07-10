using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AggregateFuture<Ljava/lang/Object;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0,
	2,
	16,
	byte.MaxValue,
	byte.MaxValue,
	1,
	3,
	0,
	0,
	78,
	0,
	0,
	17,
	0,
	0,
	0,
	0,
	78,
	0,
	0
})]
[ConstantPool(new object[]
{
	(byte)78,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class CombinedFuture : AggregateFuture
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/CombinedFuture<TV;>.CombinedFutureInterruptibleTask<Lcom/google/common/util/concurrent/ListenableFuture<TV;>;>;")]
	internal sealed class AsyncCallableInterruptibleTask : CombinedFutureInterruptibleTask
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/AsyncCallable<TV;>;")]
		private AsyncCallable callable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new CombinedFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)V")]
		[LineNumberTable(new byte[] { 125, 109 })]
		internal virtual void setValue(ListenableFuture P_0)
		{
			this_00240.setFuture(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		[LineNumberTable(new byte[] { 115, 108 })]
		internal new virtual ListenableFuture runInterruptibly()
		{
			ListenableFuture obj = callable.call();
			return (ListenableFuture)Preconditions.checkNotNull(obj, "AsyncCallable.call returned null instead of a Future. Did you mean to return immediateFuture(null)? %s", callable);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/AsyncCallable<TV;>;Ljava/util/concurrent/Executor;)V")]
		[LineNumberTable(new byte[] { 108, 103, 106, 113 })]
		internal AsyncCallableInterruptibleTask(CombinedFuture P_0, AsyncCallable P_1, Executor P_2)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_2);
			callable = (AsyncCallable)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(180)]
		internal override string toPendingString()
		{
			string result = java.lang.Object.instancehelper_toString(callable);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(153)]
		internal override void setValue(object P_0)
		{
			setValue((ListenableFuture)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(153)]
		internal override object runInterruptibly()
		{
			ListenableFuture result = runInterruptibly();
			_ = null;
			return result;
		}

		[HideFromJava]
		static AsyncCallableInterruptibleTask()
		{
			CombinedFutureInterruptibleTask.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected AsyncCallableInterruptibleTask(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/CombinedFuture<TV;>.CombinedFutureInterruptibleTask<TV;>;")]
	internal sealed class CallableInterruptibleTask : CombinedFutureInterruptibleTask
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/concurrent/Callable<TV;>;")]
		private Callable callable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new CombinedFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/Callable<TV;>;Ljava/util/concurrent/Executor;)V")]
		[LineNumberTable(new byte[] { 160, 74, 103, 106, 113 })]
		internal CallableInterruptibleTask(CombinedFuture P_0, Callable P_1, Executor P_2)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_2);
			callable = (Callable)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("()TV;")]
		[LineNumberTable(196)]
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
		[LineNumberTable(new byte[] { 160, 87, 109 })]
		internal override void setValue([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_0)
		{
			this_00240.set(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(206)]
		internal override string toPendingString()
		{
			string result = java.lang.Object.instancehelper_toString(callable);
			_ = null;
			return result;
		}

		[HideFromJava]
		static CallableInterruptibleTask()
		{
			CombinedFutureInterruptibleTask.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CallableInterruptibleTask(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Abstract)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/util/concurrent/InterruptibleTask<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 58, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)58,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class CombinedFutureInterruptibleTask : InterruptibleTask
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Executor listenerExecutor;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CombinedFuture this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		protected internal new static void ___003Cclinit_003E()
		{
		}

		[Signature("(TT;)V")]
		internal abstract void setValue([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 47, 111, 113 })]
		internal CombinedFutureInterruptibleTask(CombinedFuture P_0, Executor P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			listenerExecutor = (Executor)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(103)]
		internal sealed override bool isDone()
		{
			bool result = this_00240.isDone();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 58, 190, 2, 97, 141 })]
		internal void execute()
		{
			RejectedExecutionException ex;
			try
			{
				listenerExecutor.execute(this);
				return;
			}
			catch (RejectedExecutionException x)
			{
				ex = ByteCodeHelper.MapException<RejectedExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			RejectedExecutionException exception = ex;
			this_00240.setException(exception);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)V")]
		[LineNumberTable(new byte[] { 77, 141, 105 })]
		internal sealed override void afterRanInterruptiblySuccess([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_0)
		{
			access_0024002(this_00240, null);
			setValue(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 85, 141, 232, 69, 121, 104, 143, 141 })]
		internal sealed override void afterRanInterruptiblyFailure(System.Exception P_0)
		{
			access_0024002(this_00240, null);
			if (P_0 is ExecutionException)
			{
				this_00240.setException(Throwable.instancehelper_getCause((ExecutionException)P_0));
			}
			else if (P_0 is CancellationException)
			{
				this_00240.cancel(false);
			}
			else
			{
				this_00240.setException(P_0);
			}
		}

		[HideFromJava]
		static CombinedFutureInterruptibleTask()
		{
			InterruptibleTask.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CombinedFutureInterruptibleTask(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("Lcom/google/common/util/concurrent/CombinedFuture<TV;>.CombinedFutureInterruptibleTask<*>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private CombinedFutureInterruptibleTask task;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal static CombinedFutureInterruptibleTask access_0024002(CombinedFuture P_0, CombinedFutureInterruptibleTask P_1)
	{
		P_0.task = P_1;
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableCollection<+Lcom/google/common/util/concurrent/ListenableFuture<*>;>;ZLjava/util/concurrent/Executor;Lcom/google/common/util/concurrent/AsyncCallable<TV;>;)V")]
	[LineNumberTable(new byte[] { 159, 132, 162, 107, 111, 104 })]
	internal CombinedFuture(ImmutableCollection P_0, bool P_1, Executor P_2, AsyncCallable P_3)
		: base(P_0, P_1, false)
	{
		task = new AsyncCallableInterruptibleTask(this, P_3, P_2);
		init();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableCollection<+Lcom/google/common/util/concurrent/ListenableFuture<*>;>;ZLjava/util/concurrent/Executor;Ljava/util/concurrent/Callable<TV;>;)V")]
	[LineNumberTable(new byte[] { 159, 129, 98, 107, 111, 104 })]
	internal CombinedFuture(ImmutableCollection P_0, bool P_1, Executor P_2, Callable P_3)
		: base(P_0, P_1, false)
	{
		task = new CallableInterruptibleTask(this, P_3, P_2);
		init();
	}

	internal override void collectOneValue(int P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 103, 99, 136 })]
	internal override void handleAllCompleted()
	{
		task?.execute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 231, 72, 104, 135 })]
	internal override void releaseResources(ReleaseResourcesReason P_0)
	{
		base.releaseResources(P_0);
		if (P_0 == ReleaseResourcesReason.OUTPUT_FUTURE_DONE)
		{
			task = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 36, 103, 99, 136 })]
	protected internal override void interruptTask()
	{
		task?.interruptTask();
	}

	[HideFromJava]
	static CombinedFuture()
	{
		AggregateFuture.___003Cclinit_003E();
	}
}
