using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/AbstractFuture$TrustedFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 15, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)15,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class SettableFuture : AbstractFuture.TrustedFuture
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>()Lcom/google/common/util/concurrent/SettableFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 15, 0, 0 })]
	[LineNumberTable(43)]
	public static SettableFuture create()
	{
		SettableFuture result = new SettableFuture();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TV;)Z")]
	[LineNumberTable(49)]
	public override bool set([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object value)
	{
		bool result = base.set(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	public override bool setException(System.Exception throwable)
	{
		bool result = base.setException(throwable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<+TV;>;)Z")]
	[LineNumberTable(61)]
	public override bool setFuture(ListenableFuture future)
	{
		bool result = base.setFuture(future);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	private SettableFuture()
	{
	}

	[HideFromJava]
	static SettableFuture()
	{
		TrustedFuture.___003Cclinit_003E();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|get", "()Ljava.lang.Object;")]
	public new object get()
	{
		return ((TrustedFuture)this).get();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|get", "(JLjava.util.concurrent.TimeUnit;)Ljava.lang.Object;")]
	public new object get(long P_0, TimeUnit P_1)
	{
		return ((TrustedFuture)this).get(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|isDone", "()Z")]
	public new bool isDone()
	{
		return ((TrustedFuture)this).isDone();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|isCancelled", "()Z")]
	public new bool isCancelled()
	{
		return ((TrustedFuture)this).isCancelled();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|addListener", "(Ljava.lang.Runnable;Ljava.util.concurrent.Executor;)V")]
	public new void addListener(Runnable P_0, Executor P_1)
	{
		((TrustedFuture)this).addListener(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|cancel", "(Z)Z")]
	public new bool cancel(bool P_0)
	{
		return ((TrustedFuture)this).cancel(P_0);
	}
}
