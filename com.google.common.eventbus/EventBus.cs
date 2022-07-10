using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.util.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.concurrent;
using java.util.logging;

namespace com.google.common.eventbus;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/eventbus/ElementTypesAreNonnullByDefault;"
})]
public class EventBus : java.lang.Object
{
	internal sealed class LoggingHandler : java.lang.Object, SubscriberExceptionHandler
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static LoggingHandler INSTANCE;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(292)]
		private static Logger logger(SubscriberExceptionContext P_0)
		{
			string name = ClassLiteral<EventBus>.Value.getName();
			string text = P_0.getEventBus().identifier();
			int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(name)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			Logger result = Logger.getLogger(new StringBuilder(num).append(name).append(".").append(text)
				.toString(), LoggingHandler.___003CGetCallerID_003E());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160,
			182,
			103,
			97,
			135,
			174,
			140,
			byte.MaxValue,
			121,
			56
		})]
		private static string message(SubscriberExceptionContext P_0)
		{
			Method subscriberMethod = P_0.getSubscriberMethod();
			string name = subscriberMethod.getName();
			string name2 = subscriberMethod.getParameterTypes()[0].getName();
			string text = java.lang.String.valueOf(P_0.getSubscriber());
			string text2 = java.lang.String.valueOf(P_0.getEvent());
			int num = 80 + java.lang.String.instancehelper_length(java.lang.String.valueOf(name)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(name2)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("Exception thrown by subscriber method ").append(name).append('(')
				.append(name2)
				.append(')')
				.append(" on subscriber ")
				.append(text)
				.append(" when dispatching event: ")
				.append(text2)
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(280)]
		internal LoggingHandler()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 171, 103, 109, 148 })]
		public virtual void handleException(System.Exception P_0, SubscriberExceptionContext P_1)
		{
			Logger logger = LoggingHandler.logger(P_1);
			if (logger.isLoggable(Level.SEVERE))
			{
				logger.log(Level.SEVERE, message(P_1), P_0);
			}
		}

		[LineNumberTable(281)]
		static LoggingHandler()
		{
			INSTANCE = new LoggingHandler();
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private string m_identifier;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Executor m_executor;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private SubscriberExceptionHandler exceptionHandler;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private SubscriberRegistry subscribers;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Dispatcher dispatcher;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 124, 130, 101, 234, 61, 231, 69 })]
	public EventBus(string identifier)
		: this(identifier, MoreExecutors.directExecutor(), Dispatcher.perThreadDispatchQueue(), LoggingHandler.INSTANCE)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 85, 232, 24, 236, 105, 113, 113, 113, 114 })]
	internal EventBus(string P_0, Executor P_1, Dispatcher P_2, SubscriberExceptionHandler P_3)
	{
		subscribers = new SubscriberRegistry(this);
		this.m_identifier = (string)Preconditions.checkNotNull(P_0);
		this.m_executor = (Executor)Preconditions.checkNotNull(P_1);
		dispatcher = (Dispatcher)Preconditions.checkNotNull(P_2);
		exceptionHandler = (SubscriberExceptionHandler)Preconditions.checkNotNull(P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 151, 109, 104, 111, 136, 143 })]
	public virtual void post(object @event)
	{
		Iterator iterator = subscribers.getSubscribers(@event);
		if (iterator.hasNext())
		{
			dispatcher.dispatch(@event, iterator);
		}
		else if (!(@event is DeadEvent))
		{
			post(new DeadEvent(this, @event));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 114, 109 })]
	public EventBus()
		: this("default")
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 74, 134, 101, 230, 61, 231, 69 })]
	public EventBus(SubscriberExceptionHandler exceptionHandler)
		: this("default", MoreExecutors.directExecutor(), Dispatcher.perThreadDispatchQueue(), exceptionHandler)
	{
	}

	public string identifier()
	{
		return this.m_identifier;
	}

	internal Executor executor()
	{
		return this.m_executor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		108,
		103,
		135,
		byte.MaxValue,
		0,
		71,
		226,
		58,
		129,
		159,
		3,
		6,
		229,
		69
	})]
	internal virtual void handleSubscriberException(System.Exception P_0, SubscriberExceptionContext P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		System.Exception ex;
		try
		{
			exceptionHandler.handleException(P_0, P_1);
			return;
		}
		catch (System.Exception x)
		{
			ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
		}
		System.Exception ex2 = ex;
		logger.log(Level.SEVERE, java.lang.String.format(Locale.ROOT, "Exception %s thrown while handling exception: %s", ex2, P_0), ex2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 127, 110 })]
	public virtual void register(object @object)
	{
		subscribers.register(@object);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 137, 110 })]
	public virtual void unregister(object @object)
	{
		subscribers.unregister(@object);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(276)]
	public override string toString()
	{
		string result = MoreObjects.toStringHelper(this).addValue(this.m_identifier).toString();
		_ = null;
		return result;
	}

	[LineNumberTable(153)]
	static EventBus()
	{
		logger = Logger.getLogger(ClassLiteral<EventBus>.Value.getName(), EventBus.___003CGetCallerID_003E());
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
