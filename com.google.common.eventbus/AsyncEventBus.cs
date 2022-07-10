using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util.concurrent;

namespace com.google.common.eventbus;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/eventbus/ElementTypesAreNonnullByDefault;"
})]
public class AsyncEventBus : EventBus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 116 })]
	public AsyncEventBus(string identifier, Executor executor)
		: base(identifier, executor, Dispatcher.legacyAsync(), LoggingHandler.INSTANCE)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 1, 116 })]
	public AsyncEventBus(Executor executor, SubscriberExceptionHandler subscriberExceptionHandler)
		: base("default", executor, Dispatcher.legacyAsync(), subscriberExceptionHandler)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 120 })]
	public AsyncEventBus(Executor executor)
		: base("default", executor, Dispatcher.legacyAsync(), LoggingHandler.INSTANCE)
	{
	}

	[HideFromJava]
	static AsyncEventBus()
	{
		EventBus.___003Cclinit_003E();
	}
}
