using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/graph/MapIteratorCache<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class MapRetrievalCache : MapIteratorCache
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal sealed class CacheEntry : java.lang.Object
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		internal object key;

		[Modifiers(Modifiers.Final)]
		[Signature("TV;")]
		internal object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)V")]
		[LineNumberTable(new byte[] { 57, 104, 103, 103 })]
		internal CacheEntry(object P_0, object P_1)
		{
			key = P_0;
			value = P_1;
		}
	}

	[NonSerialized]
	[Signature("Lcom/google/common/graph/MapRetrievalCache$CacheEntry<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile CacheEntry cacheEntry1;

	[NonSerialized]
	[Signature("Lcom/google/common/graph/MapRetrievalCache$CacheEntry<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile CacheEntry cacheEntry2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 159, 179, 105 })]
	internal MapRetrievalCache(Map P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[]
	{
		12, 104, 99, 226, 72, 105, 108, 135, 105, 172,
		103, 135
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal override object getIfCached([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		object ifCached = base.getIfCached(P_0);
		if (ifCached != null)
		{
			return ifCached;
		}
		CacheEntry cacheEntry = cacheEntry1;
		if (cacheEntry != null && cacheEntry.key == P_0)
		{
			return cacheEntry.value;
		}
		cacheEntry = cacheEntry2;
		if (cacheEntry != null && cacheEntry.key == P_0)
		{
			addToCache(cacheEntry);
			return cacheEntry.value;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)V")]
	[LineNumberTable(new byte[] { 44, 111 })]
	private void addToCache(object P_0, object P_1)
	{
		addToCache(new CacheEntry(P_0, P_1));
	}

	[Signature("(Lcom/google/common/graph/MapRetrievalCache$CacheEntry<TK;TV;>;)V")]
	private void addToCache(CacheEntry P_0)
	{
		cacheEntry2 = cacheEntry1;
		cacheEntry1 = P_0;
		System.Threading.Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 159, 186, 103, 104, 99, 162, 104, 99, 136 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal override object get(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		object ifCached = getIfCached(P_0);
		if (ifCached != null)
		{
			return ifCached;
		}
		ifCached = getWithoutCaching(P_0);
		if (ifCached != null)
		{
			addToCache(P_0, ifCached);
		}
		return ifCached;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 38, 102, 105, 110 })]
	internal override void clearCache()
	{
		base.clearCache();
		cacheEntry1 = null;
		cacheEntry2 = null;
		System.Threading.Thread.MemoryBarrier();
	}
}
