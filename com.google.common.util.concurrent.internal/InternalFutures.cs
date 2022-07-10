using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.util.concurrent.@internal;

public sealed class InternalFutures : java.lang.Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	public static System.Exception tryInternalFastPathGetFailure(InternalFutureFailureAccess future)
	{
		System.Exception result = future.tryInternalFastPathGetFailure();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(44)]
	private InternalFutures()
	{
	}
}
