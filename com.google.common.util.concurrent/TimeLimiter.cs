using System.Runtime.CompilerServices;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.time;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)40,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use FakeTimeLimiter"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public interface TimeLimiter
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static object newProxy(TimeLimiter P_0, object P_1, Class P_2, Duration P_3)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EnewProxy(P_0, P_1, P_2, P_3);
		}

		public unsafe static object callWithTimeout(TimeLimiter P_0, Callable P_1, Duration P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EcallWithTimeout(P_0, P_1, P_2);
		}

		public unsafe static object callUninterruptiblyWithTimeout(TimeLimiter P_0, Callable P_1, Duration P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EcallUninterruptiblyWithTimeout(P_0, P_1, P_2);
		}

		public unsafe static void runWithTimeout(TimeLimiter P_0, Runnable P_1, Duration P_2)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003ErunWithTimeout(P_0, P_1, P_2);
		}

		public unsafe static void runUninterruptiblyWithTimeout(TimeLimiter P_0, Runnable P_1, Duration P_2)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003ErunUninterruptiblyWithTimeout(P_0, P_1, P_2);
		}
	}

	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/Class<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	virtual object newProxy(object obj, Class c, long l, TimeUnit tu);

	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 40, 0, 0 })]
	virtual object callWithTimeout(Callable c, long l, TimeUnit tu);

	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.util.concurrent.ExecutionException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 40, 0, 0 })]
	virtual object callUninterruptiblyWithTimeout(Callable c, long l, TimeUnit tu);

	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.lang.InterruptedException" })]
	virtual void runWithTimeout(Runnable r, long l, TimeUnit tu);

	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	virtual void runUninterruptiblyWithTimeout(Runnable r, long l, TimeUnit tu);

	[Modifiers(Modifiers.Public)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/Class<TT;>;Ljava/time/Duration;)TT;")]
	virtual object newProxy(object target, Class interfaceType, Duration timeout);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(127)]
	static object _003Cdefault_003EnewProxy(TimeLimiter P_0, object P_1, Class P_2, Duration P_3)
	{
		object result = P_0.newProxy(P_1, P_2, Internal.toNanosSaturated(P_3), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Modifiers(Modifiers.Public)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;Ljava/time/Duration;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 40, 0, 0 })]
	virtual object callWithTimeout(Callable callable, Duration timeout);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(172)]
	static object _003Cdefault_003EcallWithTimeout(TimeLimiter P_0, Callable P_1, Duration P_2)
	{
		object result = P_0.callWithTimeout(P_1, Internal.toNanosSaturated(P_2), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.util.concurrent.ExecutionException" })]
	[Modifiers(Modifiers.Public)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;Ljava/time/Duration;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 40, 0, 0 })]
	virtual object callUninterruptiblyWithTimeout(Callable callable, Duration timeout);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 160, 107, 99, 42 })]
	static object _003Cdefault_003EcallUninterruptiblyWithTimeout(TimeLimiter P_0, Callable P_1, Duration P_2)
	{
		object result = P_0.callUninterruptiblyWithTimeout(P_1, Internal.toNanosSaturated(P_2), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.lang.InterruptedException" })]
	[Modifiers(Modifiers.Public)]
	virtual void runWithTimeout(Runnable runnable, Duration timeout);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 160, 146, 116 })]
	static void _003Cdefault_003ErunWithTimeout(TimeLimiter P_0, Runnable P_1, Duration P_2)
	{
		P_0.runWithTimeout(P_1, Internal.toNanosSaturated(P_2), TimeUnit.NANOSECONDS);
	}

	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[Modifiers(Modifiers.Public)]
	virtual void runUninterruptiblyWithTimeout(Runnable runnable, Duration timeout);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 160, 188, 116 })]
	static void _003Cdefault_003ErunUninterruptiblyWithTimeout(TimeLimiter P_0, Runnable P_1, Duration P_2)
	{
		P_0.runUninterruptiblyWithTimeout(P_1, Internal.toNanosSaturated(P_2), TimeUnit.NANOSECONDS);
	}
}
