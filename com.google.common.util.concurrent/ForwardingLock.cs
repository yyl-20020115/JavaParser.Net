using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;
using java.util.concurrent.locks;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ForwardingLock : Object, Lock
{
	internal abstract Lock @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(23)]
	internal ForwardingLock()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 170, 109 })]
	public virtual void @lock()
	{
		@delegate().@lock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[] { 159, 175, 109 })]
	public virtual void lockInterruptibly()
	{
		@delegate().lockInterruptibly();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	public virtual bool tryLock()
	{
		bool result = @delegate().tryLock();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(43)]
	public virtual bool tryLock(long P_0, TimeUnit P_1)
	{
		bool result = @delegate().tryLock(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 190, 109 })]
	public virtual void unlock()
	{
		@delegate().unlock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public virtual Condition newCondition()
	{
		Condition result = @delegate().newCondition();
		_ = null;
		return result;
	}
}
