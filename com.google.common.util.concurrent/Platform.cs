using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Platform : java.lang.Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Throwable;Ljava/lang/Class<+Ljava/lang/Throwable;>;)Z")]
	[LineNumberTable(26)]
	internal static bool isInstanceOfThrowableClass([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] System.Exception P_0, Class P_1)
	{
		bool result = P_1.isInstance(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	private Platform()
	{
	}
}
