using System;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;
using java.util.function;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/cache/Cache<TK;TV;>;Lcom/google/common/base/Function<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.cache.Cache", "com.google.common.base.Function" })]
public interface LoadingCache : Cache, com.google.common.@base.Function, java.util.function.Function
{
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(TK;)TV;")]
	virtual object get(object obj);

	[Signature("(TK;)TV;")]
	virtual object getUnchecked(object obj);

	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(Ljava/lang/Iterable<+TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	virtual ImmutableMap getAll(Iterable i);

	[Obsolete]
	[Signature("(TK;)TV;")]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	object apply(object obj);

	[Signature("(TK;)V")]
	virtual void refresh(object obj);

	[Signature("()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
	ConcurrentMap asMap();
}
