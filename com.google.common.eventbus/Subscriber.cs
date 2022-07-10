using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.eventbus;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/eventbus/ElementTypesAreNonnullByDefault;"
})]
internal class Subscriber : Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	internal sealed class SynchronizedSubscriber : Subscriber
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(133)]
		internal SynchronizedSubscriber(EventBus P_0, object P_1, Method P_2, _1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 86, 108 })]
		private SynchronizedSubscriber(EventBus P_0, object P_1, Method P_2)
			: base(P_0, P_1, P_2, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.reflect.InvocationTargetException" })]
		[LineNumberTable(new byte[] { 91, 104, 103, 111 })]
		internal override void invokeSubscriberMethod(object P_0)
		{
			lock (this)
			{
				base.invokeSubscriberMethod(P_0);
			}
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : Runnable
	{
		private readonly Subscriber arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon0(Subscriber P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void run()
		{
			arg_00241.lambda_0024dispatchEvent_00240(arg_00242);
			_ = null;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private EventBus bus;

	[Modifiers(Modifiers.Final)]
	internal object target;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Method method;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Executor executor;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 18, 249, 72 })]
	internal void dispatchEvent(object P_0)
	{
		executor.execute(new ___003C_003EAnon0(this, P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 104, 103, 108, 103, 135, 108 })]
	private Subscriber(EventBus P_0, object P_1, Method P_2)
	{
		bus = P_0;
		target = Preconditions.checkNotNull(P_1);
		method = P_2;
		P_2.setAccessible(flag: true);
		executor = P_0.executor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(125)]
	private static bool isDeclaredThreadSafe(Method P_0)
	{
		return P_0.getAnnotation(ClassLiteral<AllowConcurrentEvents>.Value) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.reflect.InvocationTargetException" })]
	[LineNumberTable(new byte[]
	{
		35,
		byte.MaxValue,
		52,
		74,
		229,
		55,
		97,
		127,
		39,
		98,
		127,
		40,
		98,
		110,
		146,
		136
	})]
	internal virtual void invokeSubscriberMethod(object P_0)
	{
		IllegalArgumentException ex;
		IllegalAccessException ex2;
		InvocationTargetException ex3;
		try
		{
			try
			{
				try
				{
					method.invoke(target, new object[1] { Preconditions.checkNotNull(P_0) }, Subscriber.___003CGetCallerID_003E());
					return;
				}
				catch (IllegalArgumentException x)
				{
					ex = ByteCodeHelper.MapException<IllegalArgumentException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (IllegalAccessException x2)
			{
				ex2 = ByteCodeHelper.MapException<IllegalAccessException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_004a;
			}
		}
		catch (InvocationTargetException x3)
		{
			ex3 = ByteCodeHelper.MapException<InvocationTargetException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_004d;
		}
		IllegalArgumentException cause = ex;
		string text = String.valueOf(P_0);
		int num = 33 + String.instancehelper_length(String.valueOf(text));
		num = num;
		string message = new StringBuilder(num).append("Method rejected target/argument: ").append(text).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new Error(message, cause);
		IL_004d:
		InvocationTargetException ex4 = ex3;
		if (ex4.getCause() is Error)
		{
			throw Throwable.___003Cunmap_003E((Error)ex4.getCause());
		}
		throw Throwable.___003Cunmap_003E(ex4);
		IL_004a:
		IllegalAccessException cause2 = ex2;
		text = String.valueOf(P_0);
		num = 28 + String.instancehelper_length(String.valueOf(text));
		num = num;
		string message2 = new StringBuilder(num).append("Method became inaccessible: ").append(text).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new Error(message2, cause2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(100)]
	private SubscriberExceptionContext context(object P_0)
	{
		SubscriberExceptionContext result = new SubscriberExceptionContext(bus, P_0, target, method);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 21, 185, 2, 97, 152 })]
	private void lambda_0024dispatchEvent_00240(object P_0)
	{
		InvocationTargetException ex;
		try
		{
			invokeSubscriberMethod(P_0);
			return;
		}
		catch (InvocationTargetException x)
		{
			ex = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		InvocationTargetException ex2 = ex;
		bus.handleSubscriberException(ex2.getCause(), context(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 182, 104, 106, 11 })]
	internal static Subscriber create(EventBus P_0, object P_1, Method P_2)
	{
		Subscriber result = ((!isDeclaredThreadSafe(P_2)) ? new SynchronizedSubscriber(P_0, P_1, P_2, null) : new Subscriber(P_0, P_1, P_2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(105)]
	public sealed override int hashCode()
	{
		return (31 + method.hashCode()) * 31 + java.lang.System.identityHashCode(target);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 60, 104, 199, 159, 7 })]
	public sealed override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is Subscriber)
		{
			Subscriber subscriber = (Subscriber)P_0;
			return (target == subscriber.target && method.equals(subscriber.method)) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal Subscriber(EventBus P_0, object P_1, Method P_2, _1 P_3)
		: this(P_0, P_1, P_2)
	{
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
