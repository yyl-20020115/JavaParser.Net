using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)58,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class FakeTimeLimiter : java.lang.Object, TimeLimiter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 58, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		5, 103, 135, 127, 50, 98, 109, 98, 109, 98,
		109, 162
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public virtual object callWithTimeout(Callable callable, long timeoutDuration, TimeUnit timeoutUnit)
	{
		//Discarded unreachable code: IL_0016
		Preconditions.checkNotNull(callable);
		Preconditions.checkNotNull(timeoutUnit);
		RuntimeException ex2;
		java.lang.Exception ex4;
		Error error2;
		System.Exception ex5;
		try
		{
			try
			{
				try
				{
					try
					{
						return callable.call();
					}
					catch (System.Exception x)
					{
						RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
						if (ex == null)
						{
							throw;
						}
						ex2 = ex;
					}
				}
				catch (System.Exception x2)
				{
					java.lang.Exception ex3 = ByteCodeHelper.MapException<java.lang.Exception>(x2, ByteCodeHelper.MapFlags.None);
					if (ex3 == null)
					{
						throw;
					}
					ex4 = ex3;
					goto IL_0054;
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
				goto IL_0057;
			}
		}
		catch (System.Exception x4)
		{
			ex5 = ByteCodeHelper.MapException<System.Exception>(x4, ByteCodeHelper.MapFlags.None);
			goto IL_005a;
		}
		RuntimeException cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UncheckedExecutionException(cause);
		IL_005a:
		System.Exception cause2 = ex5;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new ExecutionException(cause2);
		IL_0057:
		Error cause3 = error2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new ExecutionError(cause3);
		IL_0054:
		java.lang.Exception cause4 = ex4;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new ExecutionException(cause4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		31,
		103,
		135,
		byte.MaxValue,
		27,
		73,
		226,
		56,
		97,
		108,
		98,
		109,
		162,
		141
	})]
	public virtual void runWithTimeout(Runnable runnable, long timeoutDuration, TimeUnit timeoutUnit)
	{
		Preconditions.checkNotNull(runnable);
		Preconditions.checkNotNull(timeoutUnit);
		RuntimeException ex2;
		Error error2;
		System.Exception ex3;
		try
		{
			try
			{
				try
				{
					runnable.run();
					return;
				}
				catch (System.Exception x)
				{
					RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
					if (ex == null)
					{
						throw;
					}
					ex2 = ex;
				}
			}
			catch (System.Exception x2)
			{
				Error error = ByteCodeHelper.MapException<Error>(x2, ByteCodeHelper.MapFlags.None);
				if (error == null)
				{
					throw;
				}
				error2 = error;
				goto IL_0042;
			}
		}
		catch (System.Exception x3)
		{
			ex3 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
			goto IL_0045;
		}
		RuntimeException cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UncheckedExecutionException(cause);
		IL_0045:
		System.Exception cause2 = ex3;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UncheckedExecutionException(cause2);
		IL_0042:
		Error cause3 = error2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new ExecutionError(cause3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	public FakeTimeLimiter()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/Class<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[LineNumberTable(new byte[] { 159, 187, 103, 103, 104 })]
	public virtual object newProxy(object target, Class interfaceType, long timeoutDuration, TimeUnit timeoutUnit)
	{
		Preconditions.checkNotNull(target);
		Preconditions.checkNotNull(interfaceType);
		Preconditions.checkNotNull(timeoutUnit);
		return target;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 58, 0, 0 })]
	[LineNumberTable(76)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public virtual object callUninterruptiblyWithTimeout(Callable callable, long timeoutDuration, TimeUnit timeoutUnit)
	{
		object result = callWithTimeout(callable, timeoutDuration, timeoutUnit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 49, 107 })]
	public virtual void runUninterruptiblyWithTimeout(Runnable runnable, long timeoutDuration, TimeUnit timeoutUnit)
	{
		runWithTimeout(runnable, timeoutDuration, timeoutUnit);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object newProxy(object P_0, Class P_1, Duration P_2)
	{
		return TimeLimiter._003Cdefault_003EnewProxy(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object callWithTimeout(Callable P_0, Duration P_1)
	{
		return TimeLimiter._003Cdefault_003EcallWithTimeout(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object callUninterruptiblyWithTimeout(Callable P_0, Duration P_1)
	{
		return TimeLimiter._003Cdefault_003EcallUninterruptiblyWithTimeout(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void runWithTimeout(Runnable P_0, Duration P_1)
	{
		TimeLimiter._003Cdefault_003ErunWithTimeout(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void runUninterruptiblyWithTimeout(Runnable P_0, Duration P_1)
	{
		TimeLimiter._003Cdefault_003ErunUninterruptiblyWithTimeout(this, P_0, P_1);
	}
}
