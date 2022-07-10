using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.eventbus;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/eventbus/ElementTypesAreNonnullByDefault;"
})]
public class DeadEvent : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private object source;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private object @event;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 104, 108, 108 })]
	public DeadEvent(object source, object @event)
	{
		this.source = Preconditions.checkNotNull(source);
		this.@event = Preconditions.checkNotNull(@event);
	}

	public virtual object getSource()
	{
		return source;
	}

	public virtual object getEvent()
	{
		return @event;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	public override string toString()
	{
		string result = MoreObjects.toStringHelper(this).add("source", source).add("event", @event)
			.toString();
		_ = null;
		return result;
	}
}
