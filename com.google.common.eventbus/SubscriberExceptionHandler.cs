using System;

namespace com.google.common.eventbus;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/eventbus/ElementTypesAreNonnullByDefault;"
})]
public interface SubscriberExceptionHandler
{
	virtual void handleException(Exception t, SubscriberExceptionContext sec);
}
