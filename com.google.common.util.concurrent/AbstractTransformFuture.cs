using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;F:Ljava/lang/Object;T:Ljava/lang/Object;>Lcom/google/common/util/concurrent/FluentFuture$TrustedFuture<TO;>;Ljava/lang/Runnable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 3, 17, 0, 0, 0, 0, 74, 0, 0,
	17, 1, 0, 0, 0, 74, 0, 0, 17, 3,
	0, 0, 0, 74, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)74,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Runnable" })]
internal abstract class AbstractTransformFuture : FluentFuture.TrustedFuture, Runnable
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractTransformFuture<TI;TO;Lcom/google/common/util/concurrent/AsyncFunction<-TI;+TO;>;Lcom/google/common/util/concurrent/ListenableFuture<+TO;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 53, 0, 0,
		17, 1, 0, 0, 0, 53, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)53,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class AsyncTransformFuture : AbstractTransformFuture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TI;>;Lcom/google/common/util/concurrent/AsyncFunction<-TI;+TO;>;)V")]
		[LineNumberTable(new byte[] { 160, 100, 106 })]
		internal AsyncTransformFuture(ListenableFuture P_0, AsyncFunction P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TO;>;)V")]
		[LineNumberTable(new byte[] { 160, 118, 104 })]
		internal virtual void setResult(ListenableFuture P_0)
		{
			base.setFuture(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Signature("(Lcom/google/common/util/concurrent/AsyncFunction<-TI;+TO;>;TI;)Lcom/google/common/util/concurrent/ListenableFuture<+TO;>;")]
		[LineNumberTable(new byte[] { 160, 107, 104, 237, 69 })]
		internal virtual ListenableFuture doTransform(AsyncFunction P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_1)
		{
			ListenableFuture listenableFuture = P_0.apply(P_1);
			Preconditions.checkNotNull(listenableFuture, "AsyncFunction.apply returned null instead of a Future. Did you mean to return immediateFuture(null)? %s", P_0);
			return listenableFuture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(208)]
		internal override void setResult(object P_0)
		{
			setResult((ListenableFuture)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(208)]
		internal override object doTransform(object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_1)
		{
			ListenableFuture result = doTransform((AsyncFunction)P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava]
		static AsyncTransformFuture()
		{
			AbstractTransformFuture.___003Cclinit_003E();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractTransformFuture<TI;TO;Lcom/google/common/base/Function<-TI;+TO;>;TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 48, 0, 0,
		17, 1, 0, 0, 0, 48, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)48,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class TransformFuture : AbstractTransformFuture
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TI;>;Lcom/google/common/base/Function<-TI;+TO;>;)V")]
		[LineNumberTable(new byte[] { 160, 130, 106 })]
		internal TransformFuture(ListenableFuture P_0, Function P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Function<-TI;+TO;>;TI;)TO;")]
		[LineNumberTable(250)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		internal virtual object doTransform(Function P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_1)
		{
			object result = P_0.apply(P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TO;)V")]
		[LineNumberTable(new byte[] { 160, 141, 104 })]
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
		[LineNumberTable(240)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})]
		internal override object doTransform(object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/util/concurrent/ParametricNullness;"
		})] object P_1)
		{
			object result = doTransform((Function)P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava]
		static TransformFuture()
		{
			AbstractTransformFuture.___003Cclinit_003E();
		}
	}

	[Signature("Lcom/google/common/util/concurrent/ListenableFuture<+TI;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal ListenableFuture inputFuture;

	[Signature("TF;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal object function;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("(TF;TI;)TT;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	internal abstract object doTransform(object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_1);

	[Signature("(TT;)V")]
	internal abstract void setResult([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TI;>;Lcom/google/common/util/concurrent/AsyncFunction<-TI;+TO;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 74, 0, 0,
		18, 1, 0, 0, 0, 74, 0, 0
	})]
	[LineNumberTable(new byte[] { 159, 183, 103, 104, 110 })]
	internal static ListenableFuture create(ListenableFuture P_0, AsyncFunction P_1, Executor P_2)
	{
		Preconditions.checkNotNull(P_2);
		AsyncTransformFuture asyncTransformFuture = new AsyncTransformFuture(P_0, P_1);
		P_0.addListener(asyncTransformFuture, MoreExecutors.rejectionPropagatingExecutor(P_2, asyncTransformFuture));
		return asyncTransformFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;>(Lcom/google/common/util/concurrent/ListenableFuture<TI;>;Lcom/google/common/base/Function<-TI;+TO;>;Ljava/util/concurrent/Executor;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 74, 0, 0,
		18, 1, 0, 0, 0, 74, 0, 0
	})]
	[LineNumberTable(new byte[] { 159, 191, 103, 104, 110 })]
	internal static ListenableFuture create(ListenableFuture P_0, Function P_1, Executor P_2)
	{
		Preconditions.checkNotNull(P_1);
		TransformFuture transformFuture = new TransformFuture(P_0, P_1);
		P_0.addListener(transformFuture, MoreExecutors.rejectionPropagatingExecutor(P_2, transformFuture));
		return transformFuture;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TI;>;TF;)V")]
	[LineNumberTable(new byte[] { 12, 104, 113, 108 })]
	internal AbstractTransformFuture(ListenableFuture P_0, object P_1)
	{
		inputFuture = (ListenableFuture)Preconditions.checkNotNull(P_0);
		function = Preconditions.checkNotNull(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		19,
		103,
		103,
		120,
		129,
		135,
		136,
		98,
		102,
		225,
		77,
		byte.MaxValue,
		37,
		89,
		226,
		40,
		225,
		70,
		104,
		97,
		130,
		110,
		97,
		130,
		105,
		97,
		226,
		70,
		105,
		225,
		69,
		248,
		70,
		103,
		39,
		103,
		230,
		58,
		130,
		173,
		103,
		35,
		2,
		225,
		105,
		104
	})]
	public void run()
	{
		ListenableFuture listenableFuture = inputFuture;
		object obj = function;
		if (isCancelled() || listenableFuture == null || obj == null)
		{
			return;
		}
		inputFuture = null;
		if (listenableFuture.isCancelled())
		{
			setFuture(listenableFuture);
			return;
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
					try
					{
						done = Futures.getDone(listenableFuture);
					}
					catch (CancellationException)
					{
						goto IL_0075;
					}
				}
				catch (ExecutionException x)
				{
					ex2 = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0078;
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
				goto IL_007b;
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
			goto IL_007f;
		}
		object result;
		System.Exception ex5;
		try
		{
			try
			{
				result = doTransform(obj, done);
			}
			catch (System.Exception x4)
			{
				ex5 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
				goto IL_00da;
			}
		}
		catch
		{
			//try-fault
			function = null;
			throw;
		}
		function = null;
		setResult(result);
		return;
		IL_0078:
		ExecutionException @this = ex2;
		setException(Throwable.instancehelper_getCause(@this));
		return;
		IL_0075:
		_ = null;
		cancel(false);
		return;
		IL_00da:
		System.Exception ex6 = ex5;
		try
		{
			System.Exception exception = ex6;
			setException(exception);
			return;
		}
		finally
		{
			function = null;
		}
		IL_007f:
		Error exception2 = error2;
		setException(exception2);
		return;
		IL_007b:
		RuntimeException exception3 = ex4;
		setException(exception3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 67, 108, 103, 103 })]
	protected internal sealed override void afterDone()
	{
		maybePropagateCancellationTo(inputFuture);
		inputFuture = null;
		function = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 75, 103, 103, 103, 102, 99, 159, 38, 99,
		127, 63, 99, 159, 13
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal override string pendingToString()
	{
		ListenableFuture listenableFuture = inputFuture;
		object obj = function;
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
		if (obj != null)
		{
			string text3 = text2;
			string text4 = java.lang.String.valueOf(obj);
			int num = 11 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text4));
			num = num;
			string result = new StringBuilder(num).append(text3).append("function=[").append(text4)
				.append("]")
				.toString();
			_ = null;
			return result;
		}
		if (text != null)
		{
			string text5 = java.lang.String.valueOf(text2);
			string text6 = java.lang.String.valueOf(text);
			string result2;
			if (java.lang.String.instancehelper_length(text6) != 0)
			{
				result2 = java.lang.String.instancehelper_concat(text5, text6);
			}
			else
			{
				string text7 = text5;
				text7 = text7;
				result2 = java.lang.String.newhelper(text7);
			}
			_ = null;
			return result2;
		}
		return null;
	}

	[HideFromJava]
	static AbstractTransformFuture()
	{
		TrustedFuture.___003Cclinit_003E();
	}
}
