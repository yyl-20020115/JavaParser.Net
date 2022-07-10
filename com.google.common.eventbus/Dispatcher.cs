using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;

namespace com.google.common.eventbus;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/eventbus/ElementTypesAreNonnullByDefault;"
})]
internal abstract class Dispatcher : Object
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ImmediateDispatcher : Dispatcher
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static ImmediateDispatcher INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static ImmediateDispatcher access_0024200()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(180)]
		private ImmediateDispatcher()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/eventbus/Subscriber;>;)V")]
		[LineNumberTable(new byte[] { 160, 71, 103, 104, 147 })]
		internal override void dispatch(object P_0, Iterator P_1)
		{
			Preconditions.checkNotNull(P_0);
			while (P_1.hasNext())
			{
				((Subscriber)P_1.next()).dispatchEvent(P_0);
			}
		}

		[LineNumberTable(181)]
		static ImmediateDispatcher()
		{
			INSTANCE = new ImmediateDispatcher();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class LegacyAsyncDispatcher : Dispatcher
	{
		[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		internal sealed class EventWithSubscriber : Object
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private object @event;

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private Subscriber subscriber;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 122, 104, 103, 103 })]
			private EventWithSubscriber(object P_0, Subscriber P_1)
			{
				@event = P_0;
				subscriber = P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Synthetic)]
			[LineNumberTable(168)]
			internal EventWithSubscriber(object P_0, Subscriber P_1, _1 P_2)
				: this(P_0, P_1)
			{
			}

			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(168)]
			internal static object access_0024700(EventWithSubscriber P_0)
			{
				return P_0.@event;
			}

			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(168)]
			internal static Subscriber access_0024800(EventWithSubscriber P_0)
			{
				return P_0.subscriber;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/concurrent/ConcurrentLinkedQueue<Lcom/google/common/eventbus/Dispatcher$LegacyAsyncDispatcher$EventWithSubscriber;>;")]
		private ConcurrentLinkedQueue queue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(131)]
		internal LegacyAsyncDispatcher(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 81, 232, 85, 97, 42 })]
		private LegacyAsyncDispatcher()
		{
			queue = Queues.newConcurrentLinkedQueue();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/eventbus/Subscriber;>;)V")]
		[LineNumberTable(new byte[] { 107, 103, 104, 223, 1, 116, 147 })]
		internal override void dispatch(object P_0, Iterator P_1)
		{
			Preconditions.checkNotNull(P_0);
			while (P_1.hasNext())
			{
				queue.add(new EventWithSubscriber(P_0, (Subscriber)P_1.next(), null));
			}
			EventWithSubscriber eventWithSubscriber;
			while ((eventWithSubscriber = (EventWithSubscriber)queue.poll()) != null)
			{
				EventWithSubscriber.access_0024800(eventWithSubscriber).dispatchEvent(EventWithSubscriber.access_0024700(eventWithSubscriber));
			}
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class PerThreadQueuedDispatcher : Dispatcher
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/ThreadLocal<Ljava/util/Queue<Lcom/google/common/eventbus/Dispatcher$PerThreadQueuedDispatcher$Event;>;>;")]
		[EnclosingMethod(null, null, null)]
		internal new class _1 : ThreadLocal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Queue<Lcom/google/common/eventbus/Dispatcher$PerThreadQueuedDispatcher$Event;>;")]
			[LineNumberTable(83)]
			protected internal new virtual Queue initialValue()
			{
				ArrayDeque result = Queues.newArrayDeque();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(80)]
			internal _1(PerThreadQueuedDispatcher P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(80)]
			protected internal override object initialValue()
			{
				Queue result = initialValue();
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				ThreadLocal.___003Cclinit_003E();
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/ThreadLocal<Ljava/lang/Boolean;>;")]
		[EnclosingMethod(null, null, null)]
		internal class _2 : ThreadLocal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(89)]
			internal _2(PerThreadQueuedDispatcher P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(92)]
			protected internal new virtual Boolean initialValue()
			{
				Boolean result = Boolean.valueOf(b: false);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(89)]
			protected internal override object initialValue()
			{
				Boolean result = initialValue();
				_ = null;
				return result;
			}

			[HideFromJava]
			static _2()
			{
				ThreadLocal.___003Cclinit_003E();
			}
		}

		[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		internal sealed class Event : Object
		{
			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private object @event;

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			[Signature("Ljava/util/Iterator<Lcom/google/common/eventbus/Subscriber;>;")]
			private Iterator subscribers;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Synthetic)]
			[LineNumberTable(119)]
			internal Event(object P_0, Iterator P_1, Dispatcher._1 P_2)
				: this(P_0, P_1)
			{
			}

			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(119)]
			internal static Iterator access_0024400(Event P_0)
			{
				return P_0.subscribers;
			}

			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(119)]
			internal static object access_0024500(Event P_0)
			{
				return P_0.@event;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/eventbus/Subscriber;>;)V")]
			[LineNumberTable(new byte[] { 73, 104, 103, 103 })]
			private Event(object P_0, Iterator P_1)
			{
				@event = P_0;
				subscribers = P_1;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/ThreadLocal<Ljava/util/Queue<Lcom/google/common/eventbus/Dispatcher$PerThreadQueuedDispatcher$Event;>;>;")]
		private ThreadLocal queue;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/ThreadLocal<Ljava/lang/Boolean;>;")]
		private ThreadLocal dispatching;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(74)]
		internal PerThreadQueuedDispatcher(Dispatcher._1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 24, 232, 69, 236, 73 })]
		private PerThreadQueuedDispatcher()
		{
			queue = new _1(this);
			dispatching = new _2(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/eventbus/Subscriber;>;)V")]
		[LineNumberTable(new byte[]
		{
			48, 103, 103, 113, 143, 122, 177, 111, 109, 223,
			0, 107, 107, 3, 130, 130
		})]
		internal override void dispatch(object P_0, Iterator P_1)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkNotNull(P_1);
			Queue queue = (Queue)this.queue.get();
			queue.offer(new Event(P_0, P_1, null));
			if (((Boolean)dispatching.get()).booleanValue())
			{
				return;
			}
			dispatching.set(Boolean.valueOf(b: true));
			try
			{
				Event @event;
				while ((@event = (Event)queue.poll()) != null)
				{
					while (Event.access_0024400(@event).hasNext())
					{
						((Subscriber)Event.access_0024400(@event).next()).dispatchEvent(Event.access_0024500(@event));
					}
				}
			}
			finally
			{
				dispatching.remove();
				this.queue.remove();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(48)]
	internal static Dispatcher perThreadDispatchQueue()
	{
		PerThreadQueuedDispatcher result = new PerThreadQueuedDispatcher(null);
		_ = null;
		return result;
	}

	[Signature("(Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/eventbus/Subscriber;>;)V")]
	internal abstract void dispatch(object P_0, Iterator P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	internal static Dispatcher legacyAsync()
	{
		LegacyAsyncDispatcher result = new LegacyAsyncDispatcher(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	internal Dispatcher()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(67)]
	internal static Dispatcher immediate()
	{
		ImmediateDispatcher result = ImmediateDispatcher.access_0024200();
		_ = null;
		return result;
	}
}
