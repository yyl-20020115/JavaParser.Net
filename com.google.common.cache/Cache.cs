using com.google.common.collect;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use CacheBuilder.newBuilder().build()"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public interface Cache
{
	[Signature("(TK;TV;)V")]
	virtual void put(object obj1, object obj2);

	[Signature("(Ljava/lang/Object;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object getIfPresent(object obj);

	virtual void invalidate(object obj);

	virtual void invalidateAll();

	[com.google.errorprone.annotations.CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	virtual long size();

	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(TK;Ljava/util/concurrent/Callable<+TV;>;)TV;")]
	virtual object get(object obj, Callable c);

	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	virtual ImmutableMap getAllPresent(Iterable i);

	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	virtual void putAll(Map m);

	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;)V")]
	virtual void invalidateAll(Iterable i);

	[com.google.errorprone.annotations.CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	virtual CacheStats stats();

	[Signature("()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
	[com.google.errorprone.annotations.CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	virtual ConcurrentMap asMap();

	virtual void cleanUp();
}
