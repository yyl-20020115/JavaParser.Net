using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.util.concurrent.@internal;

public abstract class InternalFutureFailureAccess : java.lang.Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	protected internal InternalFutureFailureAccess()
	{
	}

	protected internal abstract System.Exception tryInternalFastPathGetFailure();
}
