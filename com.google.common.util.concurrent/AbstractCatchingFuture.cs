using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.util.concurrent.@internal;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Throwable;F:Ljava/lang/Object;T:Ljava/lang/Object;>Lcom/google/common/util/concurrent/FluentFuture$TrustedFuture<TV;>;Ljava/lang/Runnable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 85, 0, 0,
	17, 3, 0, 0, 0, 85, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)85,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Runnable" })]
internal abstract class AbstractCatchingFuture : FluentFuture.TrustedFuture, Runnable
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Throwable;>Lcom/google/common/util/concurrent/AbstractCatchingFuture<TV;TX;Lcom/google/common/util/concurrent/AsyncFunction<-TX;+TV;>;Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 53, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)53,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class AsyncCatchingFuture : AbstractCatchingFuture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;Ljava/lang/Class<TX;>;Lcom/google/common/util/concurrent/AsyncFunction<-TX;+TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 83, 107 })]
		internal AsyncCatchingFuture(ListenableFuture P_0, Class P_1, AsyncFunction P_2)
			: base(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 100, 104 })]
		internal virtual void setResult(ListenableFuture P_0)
		{
			base.setFuture(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Lcom/google/common/util/concurrent/AsyncFunction<-TX;+TV;>;TX;)Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;")]
		[LineNumberTable(new byte[] { 160, 89, 104, 237, 69 })]
		internal virtual ListenableFuture doFallback(AsyncFunction P_0, System.Exception P_1)
		{
			ListenableFuture listenableFuture = P_0.apply(P_1);
			Preconditions.checkNotNull(listenableFuture, "AsyncFunction.apply returned null instead of a Future. Did you mean to return immediateFuture(null)? %s", P_0);
			return listenableFuture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(190)]
		internal override void setResult(object P_0)
		{
			setResult((ListenableFuture)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(190)]
		internal override object doFallback(object P_0, System.Exception P_1)
		{
			ListenableFuture result = doFallback((AsyncFunction)P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava]
		static AsyncCatchingFuture()
		{
			AbstractCatchingFuture.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Throwable;>Lcom/google/common/util/concurrent/AbstractCatchingFuture<TV;TX;Lcom/google/common/base/Function<-TX;+TV;>;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 52, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)52,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class CatchingFuture : AbstractCatchingFuture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;Ljava/lang/Class<TX;>;Lcom/google/common/base/Function<-TX;+TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 114, 107 })]
		internal CatchingFuture(ListenableFuture P_0, Class P_1, Function P_2)
			: base(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Lcom/google/common/base/Function<-TX;+TV;>;TX;)TV;")]
		[LineNumberTable(234)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		internal virtual object doFallback(Function P_0, System.Exception P_1)
		{
			object result = P_0.apply(P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)V")]
		[LineNumberTable(new byte[] { 160, 125, 104 })]
		internal override void setResult([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_0)
		{
			base.set(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(222)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		internal override object doFallback(object P_0, System.Exception P_1)
		{
			object result = doFallback((Function)P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava]
		static CatchingFuture()
		{
			AbstractCatchingFuture.___003Cclinit_003E();
		}
	}

	[Signature("Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal ListenableFuture inputFuture;

	[Signature("Ljava/lang/Class<TX;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal Class exceptionType;

	[Signature("TF;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal object fallback;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("(TF;TX;)TT;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	internal abstract object doFallback(object P_0, System.Exception P_1);

	[Signature("(TT;)V")]
	internal abstract void setResult([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;X:Ljava/lang/Throwable;>(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;Ljava/lang/Class<TX;>;Lcom/google/common/base/Function<-TX;+TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 159, 187, 105, 110 })]
	internal static ListenableFuture create(ListenableFuture P_0, Class P_1, Function P_2, Executor P_3)
	{
		CatchingFuture catchingFuture = new CatchingFuture(P_0, P_1, P_2);
		P_0.addListener(catchingFuture, MoreExecutors.rejectionPropagatingExecutor(P_3, catchingFuture));
		return catchingFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<X:Ljava/lang/Throwable;V:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;Ljava/lang/Class<TX;>;Lcom/google/common/util/concurrent/AsyncFunction<-TX;+TV;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 5, 105, 110 })]
	internal static ListenableFuture create(ListenableFuture P_0, Class P_1, AsyncFunction P_2, Executor P_3)
	{
		AsyncCatchingFuture asyncCatchingFuture = new AsyncCatchingFuture(P_0, P_1, P_2);
		P_0.addListener(asyncCatchingFuture, MoreExecutors.rejectionPropagatingExecutor(P_3, asyncCatchingFuture));
		return asyncCatchingFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;Ljava/lang/Class<TX;>;TF;)V")]
	[LineNumberTable(new byte[] { 19, 104, 113, 113, 108 })]
	internal AbstractCatchingFuture(ListenableFuture P_0, Class P_1, object P_2)
	{
		inputFuture = (ListenableFuture)Preconditions.checkNotNull(P_0);
		exceptionType = (Class)Preconditions.checkNotNull(P_1);
		fallback = Preconditions.checkNotNull(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		27,
		103,
		103,
		103,
		154,
		103,
		129,
		167,
		98,
		131,
		104,
		102,
		167,
		100,
		byte.MaxValue,
		13,
		79,
		229,
		51,
		98,
		105,
		103,
		161,
		142,
		byte.MaxValue,
		78,
		69,
		2,
		98,
		164,
		228,
		69,
		109,
		161,
		106,
		136,
		193,
		164,
		249,
		69,
		103,
		103,
		7,
		103,
		103,
		230,
		58,
		98,
		173,
		103,
		103,
		3,
		2,
		225,
		70,
		104
	})]
	public void run()
	{
		ListenableFuture listenableFuture = inputFuture;
		Class @class = exceptionType;
		object obj = fallback;
		if (listenableFuture == null || @class == null || obj == null || isCancelled())
		{
			return;
		}
		inputFuture = null;
		object obj2 = null;
		System.Exception ex = null;
		ExecutionException ex2;
		System.Exception ex3;
		try
		{
			try
			{
				if (listenableFuture is InternalFutureFailureAccess)
				{
					ex = InternalFutures.tryInternalFastPathGetFailure((InternalFutureFailureAccess)listenableFuture);
				}
				if (ex == null)
				{
					obj2 = Futures.getDone(listenableFuture);
				}
			}
			catch (ExecutionException x)
			{
				ex2 = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_007d;
			}
		}
		catch (System.Exception x2)
		{
			ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
			goto IL_0081;
		}
		goto IL_0123;
		IL_007d:
		ExecutionException @this = ex2;
		ex = Throwable.instancehelper_getCause(@this);
		if (ex == null)
		{
			string text = java.lang.String.valueOf(java.lang.Object.instancehelper_getClass(listenableFuture));
			string text2 = java.lang.String.valueOf(java.lang.Object.instancehelper_getClass(@this));
			int num = 35 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			ex = new NullPointerException(new StringBuilder(num).append("Future type ").append(text).append(" threw ")
				.append(text2)
				.append(" without a cause")
				.toString());
		}
		goto IL_0123;
		IL_0081:
		System.Exception ex4 = ex3;
		ex = ex4;
		goto IL_0123;
		IL_0176:
		System.Exception ex5;
		System.Exception ex6 = ex5;
		try
		{
			System.Exception exception = ex6;
			setException(exception);
			return;
		}
		finally
		{
			exceptionType = null;
			fallback = null;
		}
		IL_0123:
		if (ex == null)
		{
			set(NullnessCasts.uncheckedCastNullableTToT(obj2));
			return;
		}
		if (!Platform.isInstanceOfThrowableClass(ex, @class))
		{
			setFuture(listenableFuture);
			return;
		}
		ex4 = ex;
		object result;
		try
		{
			try
			{
				result = doFallback(obj, ex4);
			}
			catch (System.Exception x3)
			{
				ex5 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
				goto IL_0176;
			}
		}
		catch
		{
			//try-fault
			exceptionType = null;
			fallback = null;
			throw;
		}
		exceptionType = null;
		fallback = null;
		setResult(result);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		98,
		103,
		103,
		103,
		103,
		103,
		99,
		159,
		39,
		108,
		byte.MaxValue,
		102,
		70,
		99,
		159,
		14
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal override string pendingToString()
	{
		ListenableFuture listenableFuture = inputFuture;
		Class @class = exceptionType;
		object obj = fallback;
		string text = base.pendingToString();
		string text2 = "";
		if (listenableFuture != null)
		{
			string text3 = java.lang.String.valueOf(listenableFuture);
			int num = 16 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3));
			num = num;
			text2 = new StringBuilder(num).append("inputFuture=[").append(text3).append("], ")
				.toString();
		}
		if (@class != null && obj != null)
		{
			string text3 = text2;
			string text4 = java.lang.String.valueOf(@class);
			string text5 = java.lang.String.valueOf(obj);
			int num = 29 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text4)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text5));
			num = num;
			string result = new StringBuilder(num).append(text3).append("exceptionType=[").append(text4)
				.append("], fallback=[")
				.append(text5)
				.append("]")
				.toString();
			_ = null;
			return result;
		}
		if (text != null)
		{
			string text6 = java.lang.String.valueOf(text2);
			string text7 = java.lang.String.valueOf(text);
			string result2;
			if (java.lang.String.instancehelper_length(text7) != 0)
			{
				result2 = java.lang.String.instancehelper_concat(text6, text7);
			}
			else
			{
				string text8 = text6;
				text8 = text8;
				result2 = java.lang.String.newhelper(text8);
			}
			_ = null;
			return result2;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 66, 108, 103, 103, 103 })]
	protected internal sealed override void afterDone()
	{
		maybePropagateCancellationTo(inputFuture);
		inputFuture = null;
		exceptionType = null;
		fallback = null;
	}

	[HideFromJava]
	static AbstractCatchingFuture()
	{
		TrustedFuture.___003Cclinit_003E();
	}
}
