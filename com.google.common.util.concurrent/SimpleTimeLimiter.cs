using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.time;
using java.util;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)116,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class SimpleTimeLimiter : java.lang.Object, TimeLimiter
{
	[SpecialName]
	[EnclosingMethod(null, "newProxy", "(Ljava.lang.Object;Ljava.lang.Class;JLjava.util.concurrent.TimeUnit;)Ljava.lang.Object;")]
	[ConstantPool(new object[]
	{
		(byte)46,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _1 : java.lang.Object, InvocationHandler
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Callable
		{
			private readonly Method arg_00241;

			private readonly object arg_00242;

			private readonly object[] arg_00243;

			internal ___003C_003EAnon0(Method P_0, object P_1, object[] P_2)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
				arg_00243 = P_2;
			}

			public object call()
			{
				object result = lambda_0024invoke_00240(arg_00241, arg_00242, arg_00243);
				_ = null;
				return result;
			}
		}

		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024target;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal long val_0024timeoutDuration;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TimeUnit val_0024timeoutUnit;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024interruptibleMethods;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal SimpleTimeLimiter this_00240;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(new byte[] { 44, 127, 4, 97 })]
		private static object lambda_0024invoke_00240(Method P_0, object P_1, object[] P_2)
		{
			//Discarded unreachable code: IL_000f
			InvocationTargetException ex;
			try
			{
				return P_0.invoke(P_1, P_2, _1.___003CGetCallerID_003E());
			}
			catch (InvocationTargetException x)
			{
				ex = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			InvocationTargetException ex2 = ex;
			throw Throwable.___003Cunmap_003E(access_0024100(ex2, false));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(86)]
		internal _1(SimpleTimeLimiter P_0, object P_1, long P_2, TimeUnit P_3, Set P_4)
		{
			this_00240 = P_0;
			val_0024target = P_1;
			val_0024timeoutDuration = P_2;
			val_0024timeoutUnit = P_3;
			val_0024interruptibleMethods = P_4;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Throwable" })]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 2, 1, 0, 0, 0, 46, 0,
			0
		})]
		[LineNumberTable(new byte[] { 41, 243, 72, 122, 37 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object invoke(object P_0, Method P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object[] P_2)
		{
			Callable callable = new ___003C_003EAnon0(P_1, val_0024target, P_2);
			object result = access_0024000(this_00240, callable, val_0024timeoutDuration, val_0024timeoutUnit, val_0024interruptibleMethods.contains(P_1));
			_ = null;
			return result;
		}

		static CallerID ___003CGetCallerID_003E()
		{
			if (___003CcallerID_003E == null)
			{
				___003CcallerID_003E = new ___003CCallerID_003E();
			}
			return ___003CcallerID_003E;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ExecutorService executor;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static object access_0024000(SimpleTimeLimiter P_0, Callable P_1, long P_2, TimeUnit P_3, bool P_4)
	{
		object result = P_0.callWithTimeout(P_1, P_2, P_3, P_4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static java.lang.Exception access_0024100(java.lang.Exception P_0, bool P_1)
	{
		java.lang.Exception result = throwCause(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[LineNumberTable(new byte[]
	{
		159, 86, 162, 103, 99, 135, 99, 97, 123, 135,
		104, 140, 104, 172
	})]
	private static java.lang.Exception throwCause(java.lang.Exception P_0, bool P_1)
	{
		System.Exception ex = Throwable.instancehelper_getCause(P_0);
		if (ex == null)
		{
			throw Throwable.___003Cunmap_003E(P_0);
		}
		if (P_1)
		{
			StackTraceElement[] stackTrace = (StackTraceElement[])ObjectArrays.concat(Throwable.instancehelper_getStackTrace(ex), Throwable.instancehelper_getStackTrace(P_0), ClassLiteral<StackTraceElement>.Value);
			Throwable.instancehelper_setStackTrace(ex, stackTrace);
		}
		if (ex is java.lang.Exception)
		{
			throw Throwable.___003Cunmap_003E((java.lang.Exception)ex);
		}
		if (ex is Error)
		{
			throw Throwable.___003Cunmap_003E((Error)ex);
		}
		throw Throwable.___003Cunmap_003E(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;JLjava/util/concurrent/TimeUnit;Z)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 116, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		159, 113, 99, 103, 103, 134, 173, 131, 127, 51,
		98, 104, 191, 5, 159, 18, 98, 110, 98, 104
	})]
	private object callWithTimeout(Callable P_0, long P_1, TimeUnit P_2, bool P_3)
	{
		//Discarded unreachable code: IL_0031, IL_00b1
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_2);
		checkPositiveTimeout(P_1);
		Future future = executor.submit(P_0);
		InterruptedException ex;
		ExecutionException ex2;
		java.util.concurrent.TimeoutException ex3;
		try
		{
			try
			{
				if (P_3)
				{
					try
					{
						return future.get(P_1, P_2);
					}
					catch (InterruptedException x)
					{
						ex = ByteCodeHelper.MapException<InterruptedException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					}
					goto IL_005d;
				}
			}
			catch (ExecutionException x2)
			{
				ex2 = ByteCodeHelper.MapException<ExecutionException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0063;
			}
		}
		catch (java.util.concurrent.TimeoutException x3)
		{
			ex3 = ByteCodeHelper.MapException<java.util.concurrent.TimeoutException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_006a;
		}
		ExecutionException ex4;
		java.util.concurrent.TimeoutException ex5;
		try
		{
			try
			{
				return Uninterruptibles.getUninterruptibly(future, P_1, P_2);
			}
			catch (ExecutionException x4)
			{
				ex4 = ByteCodeHelper.MapException<ExecutionException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (java.util.concurrent.TimeoutException x5)
		{
			ex5 = ByteCodeHelper.MapException<java.util.concurrent.TimeoutException>(x5, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00d3;
		}
		ExecutionException ex6 = ex4;
		goto IL_00d8;
		IL_006a:
		java.util.concurrent.TimeoutException ex7 = ex3;
		goto IL_00e8;
		IL_0063:
		ex6 = ex2;
		goto IL_00d8;
		IL_00a3:
		java.util.concurrent.TimeoutException ex8;
		ex7 = ex8;
		goto IL_00e8;
		IL_00d3:
		ex7 = ex5;
		goto IL_00e8;
		IL_00e8:
		java.util.concurrent.TimeoutException cause = ex7;
		future.cancel(mayInterruptIfRunning: true);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UncheckedTimeoutException(cause);
		IL_00d8:
		ExecutionException ex9 = ex6;
		throw Throwable.___003Cunmap_003E(throwCause(ex9, true));
		IL_005d:
		InterruptedException ex10 = ex;
		ExecutionException ex12;
		try
		{
			ex10 = ex10;
			try
			{
				InterruptedException ex11 = ex10;
				future.cancel(mayInterruptIfRunning: true);
				throw Throwable.___003Cunmap_003E(ex11);
			}
			catch (ExecutionException x6)
			{
				ex12 = ByteCodeHelper.MapException<ExecutionException>(x6, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (java.util.concurrent.TimeoutException x7)
		{
			ex8 = ByteCodeHelper.MapException<java.util.concurrent.TimeoutException>(x7, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00a3;
		}
		ex6 = ex12;
		goto IL_00d8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 5, 104, 113 })]
	private SimpleTimeLimiter(ExecutorService P_0)
	{
		executor = (ExecutorService)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 171, 114 })]
	private static void checkPositiveTimeout(long P_0)
	{
		Preconditions.checkArgument(P_0 > 0, "timeout must be positive: %s", P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Ljava/util/Set<Ljava/lang/reflect/Method;>;")]
	[LineNumberTable(new byte[] { 160, 133, 102, 122, 105, 9, 230, 69 })]
	private static Set findInterruptibleMethods(Class P_0)
	{
		HashSet hashSet = Sets.newHashSet();
		Method[] methods = P_0.getMethods(SimpleTimeLimiter.___003CGetCallerID_003E());
		int num = methods.Length;
		for (int i = 0; i < num; i++)
		{
			Method method = methods[i];
			if (declaresInterruptedEx(method))
			{
				((Set)hashSet).add((object)method);
			}
		}
		return hashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;Ljava/lang/reflect/InvocationHandler;)TT;")]
	[LineNumberTable(new byte[] { 58, 129, 53, 139 })]
	private static object newProxy(Class P_0, InvocationHandler P_1)
	{
		object obj = Proxy.newProxyInstance(P_0.getClassLoader(SimpleTimeLimiter.___003CGetCallerID_003E()), new Class[1] { P_0 }, P_1, SimpleTimeLimiter.___003CGetCallerID_003E());
		object result = P_0.cast(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[LineNumberTable(new byte[] { 160, 153, 104, 113, 104, 140 })]
	private void wrapAndThrowExecutionExceptionOrError(System.Exception P_0)
	{
		if (P_0 is Error)
		{
			Error cause = (Error)P_0;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionError(cause);
		}
		if (P_0 is RuntimeException)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UncheckedExecutionException(P_0);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new ExecutionException(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 163, 104, 145 })]
	private void wrapAndThrowRuntimeExecutionExceptionOrError(System.Exception P_0)
	{
		if (P_0 is Error)
		{
			Error cause = (Error)P_0;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionError(cause);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UncheckedExecutionException(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 143, 148, 104, 226, 61, 230, 70 })]
	private static bool declaresInterruptedEx(Method P_0)
	{
		Class[] exceptionTypes = P_0.getExceptionTypes();
		int num = exceptionTypes.Length;
		for (int i = 0; i < num; i++)
		{
			Class @class = exceptionTypes[i];
			if (@class == ClassLiteral<InterruptedException>.Value)
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(71)]
	public static SimpleTimeLimiter create(ExecutorService executor)
	{
		SimpleTimeLimiter result = new SimpleTimeLimiter(executor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;Ljava/lang/Class<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[LineNumberTable(new byte[] { 27, 103, 103, 104, 102, 144, 135, 236, 82 })]
	public virtual object newProxy(object target, Class interfaceType, long timeoutDuration, TimeUnit timeoutUnit)
	{
		Preconditions.checkNotNull(target);
		Preconditions.checkNotNull(interfaceType);
		Preconditions.checkNotNull(timeoutUnit);
		checkPositiveTimeout(timeoutDuration);
		Preconditions.checkArgument(interfaceType.isInterface(), (object)"interfaceType must be an interface type");
		Set set = findInterruptibleMethods(interfaceType);
		_1  = new _1(this, target, timeoutDuration, timeoutUnit, set);
		object result = newProxy(interfaceType, );
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 116, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		97, 103, 103, 134, 173, 127, 25, 98, 104, 104,
		98, 109
	})]
	public virtual object callWithTimeout(Callable callable, long timeoutDuration, TimeUnit timeoutUnit)
	{
		//Discarded unreachable code: IL_002b
		Preconditions.checkNotNull(callable);
		Preconditions.checkNotNull(timeoutUnit);
		checkPositiveTimeout(timeoutDuration);
		Future future = executor.submit(callable);
		InterruptedException ex;
		java.util.concurrent.TimeoutException ex2;
		ExecutionException ex3;
		try
		{
			try
			{
				try
				{
					return future.get(timeoutDuration, timeoutUnit);
				}
				catch (InterruptedException x)
				{
					ex = ByteCodeHelper.MapException<InterruptedException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (java.util.concurrent.TimeoutException x2)
			{
				ex2 = ByteCodeHelper.MapException<java.util.concurrent.TimeoutException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0051;
			}
		}
		catch (ExecutionException x3)
		{
			ex3 = ByteCodeHelper.MapException<ExecutionException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0054;
		}
		object ex4 = ex;
		goto IL_0059;
		IL_0054:
		ExecutionException @this = ex3;
		wrapAndThrowExecutionExceptionOrError(Throwable.instancehelper_getCause(@this));
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
		IL_0051:
		ex4 = ex2;
		goto IL_0059;
		IL_0059:
		java.lang.Exception ex5 = (java.lang.Exception)ex4;
		future.cancel(mayInterruptIfRunning: true);
		throw Throwable.___003Cunmap_003E(ex5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.util.concurrent.ExecutionException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 116, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		119, 103, 103, 134, 173, 127, 11, 98, 104, 104,
		98, 109
	})]
	public virtual object callUninterruptiblyWithTimeout(Callable callable, long timeoutDuration, TimeUnit timeoutUnit)
	{
		//Discarded unreachable code: IL_002b
		Preconditions.checkNotNull(callable);
		Preconditions.checkNotNull(timeoutUnit);
		checkPositiveTimeout(timeoutDuration);
		Future future = executor.submit(callable);
		java.util.concurrent.TimeoutException ex;
		ExecutionException ex2;
		try
		{
			try
			{
				return Uninterruptibles.getUninterruptibly(future, timeoutDuration, timeoutUnit);
			}
			catch (java.util.concurrent.TimeoutException x)
			{
				ex = ByteCodeHelper.MapException<java.util.concurrent.TimeoutException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (ExecutionException x2)
		{
			ex2 = ByteCodeHelper.MapException<ExecutionException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0047;
		}
		java.util.concurrent.TimeoutException ex3 = ex;
		future.cancel(mayInterruptIfRunning: true);
		throw Throwable.___003Cunmap_003E(ex3);
		IL_0047:
		ExecutionException @this = ex2;
		wrapAndThrowExecutionExceptionOrError(Throwable.instancehelper_getCause(@this));
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[]
	{
		160,
		75,
		103,
		103,
		134,
		173,
		byte.MaxValue,
		20,
		71,
		226,
		58,
		98,
		104,
		104,
		98,
		109,
		139
	})]
	public virtual void runWithTimeout(Runnable runnable, long timeoutDuration, TimeUnit timeoutUnit)
	{
		Preconditions.checkNotNull(runnable);
		Preconditions.checkNotNull(timeoutUnit);
		checkPositiveTimeout(timeoutDuration);
		Future future = executor.submit(runnable);
		InterruptedException ex;
		java.util.concurrent.TimeoutException ex2;
		ExecutionException ex3;
		try
		{
			try
			{
				try
				{
					future.get(timeoutDuration, timeoutUnit);
					return;
				}
				catch (InterruptedException x)
				{
					ex = ByteCodeHelper.MapException<InterruptedException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (java.util.concurrent.TimeoutException x2)
			{
				ex2 = ByteCodeHelper.MapException<java.util.concurrent.TimeoutException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_004e;
			}
		}
		catch (ExecutionException x3)
		{
			ex3 = ByteCodeHelper.MapException<ExecutionException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0051;
		}
		object ex4 = ex;
		goto IL_0056;
		IL_0051:
		ExecutionException @this = ex3;
		wrapAndThrowRuntimeExecutionExceptionOrError(Throwable.instancehelper_getCause(@this));
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
		IL_004e:
		ex4 = ex2;
		goto IL_0056;
		IL_0056:
		java.lang.Exception ex5 = (java.lang.Exception)ex4;
		future.cancel(mayInterruptIfRunning: true);
		throw Throwable.___003Cunmap_003E(ex5);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException" })]
	[LineNumberTable(new byte[]
	{
		160,
		95,
		103,
		103,
		134,
		173,
		byte.MaxValue,
		8,
		71,
		226,
		58,
		97,
		104,
		103,
		98,
		109,
		139
	})]
	public virtual void runUninterruptiblyWithTimeout(Runnable runnable, long timeoutDuration, TimeUnit timeoutUnit)
	{
		Preconditions.checkNotNull(runnable);
		Preconditions.checkNotNull(timeoutUnit);
		checkPositiveTimeout(timeoutDuration);
		Future future = executor.submit(runnable);
		java.util.concurrent.TimeoutException ex;
		ExecutionException ex2;
		try
		{
			try
			{
				Uninterruptibles.getUninterruptibly(future, timeoutDuration, timeoutUnit);
				return;
			}
			catch (java.util.concurrent.TimeoutException x)
			{
				ex = ByteCodeHelper.MapException<java.util.concurrent.TimeoutException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (ExecutionException x2)
		{
			ex2 = ByteCodeHelper.MapException<ExecutionException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0045;
		}
		java.util.concurrent.TimeoutException ex3 = ex;
		future.cancel(mayInterruptIfRunning: true);
		throw Throwable.___003Cunmap_003E(ex3);
		IL_0045:
		ExecutionException @this = ex2;
		wrapAndThrowRuntimeExecutionExceptionOrError(Throwable.instancehelper_getCause(@this));
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
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

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
