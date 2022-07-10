using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace com.google.common.eventbus;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/eventbus/ElementTypesAreNonnullByDefault;"
})]
public class SubscriberExceptionContext : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private EventBus eventBus;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private object @event;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private object subscriber;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Method subscriberMethod;

	public virtual EventBus getEventBus()
	{
		return eventBus;
	}

	public virtual Method getSubscriberMethod()
	{
		return subscriberMethod;
	}

	public virtual object getSubscriber()
	{
		return subscriber;
	}

	public virtual object getEvent()
	{
		return @event;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 104, 113, 108, 108, 114 })]
	internal SubscriberExceptionContext(EventBus P_0, object P_1, object P_2, Method P_3)
	{
		eventBus = (EventBus)Preconditions.checkNotNull(P_0);
		@event = Preconditions.checkNotNull(P_1);
		subscriber = Preconditions.checkNotNull(P_2);
		subscriberMethod = (Method)Preconditions.checkNotNull(P_3);
	}
}
