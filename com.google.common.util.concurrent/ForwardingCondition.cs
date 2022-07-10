using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.concurrent.locks;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ForwardingCondition : Object, Condition
{
	internal abstract Condition @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(23)]
	internal ForwardingCondition()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[] { 159, 170, 109 })]
	public virtual void await()
	{
		@delegate().await();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(33)]
	public virtual bool await(long P_0, TimeUnit P_1)
	{
		bool result = @delegate().await(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 109 })]
	public virtual void awaitUninterruptibly()
	{
		@delegate().awaitUninterruptibly();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(43)]
	public virtual long awaitNanos(long P_0)
	{
		long result = @delegate().awaitNanos(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(48)]
	public virtual bool awaitUntil(Date P_0)
	{
		bool result = @delegate().awaitUntil(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 3, 109 })]
	public virtual void signal()
	{
		@delegate().signal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 8, 109 })]
	public virtual void signalAll()
	{
		@delegate().signalAll();
	}
}
