using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Lcom/google/common/util/concurrent/FluentFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 65, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)65,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class ForwardingFluentFuture : FluentFuture
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	private ListenableFuture @delegate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)V")]
	[LineNumberTable(new byte[] { 159, 183, 104, 113 })]
	internal ForwardingFluentFuture(ListenableFuture P_0)
	{
		@delegate = (ListenableFuture)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 111 })]
	public override void addListener(Runnable P_0, Executor P_1)
	{
		@delegate.addListener(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(52)]
	public override bool cancel(bool P_0)
	{
		bool result = @delegate.cancel(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	public override bool isCancelled()
	{
		bool result = @delegate.isCancelled();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	public override bool isDone()
	{
		bool result = @delegate.isDone();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Signature("()TV;")]
	[LineNumberTable(68)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public override object get()
	{
		object result = @delegate.get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TV;")]
	[LineNumberTable(75)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public override object get(long P_0, TimeUnit P_1)
	{
		object result = @delegate.get(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(80)]
	public override string toString()
	{
		string result = Object.instancehelper_toString(@delegate);
		_ = null;
		return result;
	}

	[HideFromJava]
	static ForwardingFluentFuture()
	{
		FluentFuture.___003Cclinit_003E();
	}
}
