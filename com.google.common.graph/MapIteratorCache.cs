using System;
using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal class MapIteratorCache : java.lang.Object
{
	[SpecialName]
	[Signature("Ljava/util/AbstractSet<TK;>;")]
	[EnclosingMethod(null, "unmodifiableKeySet", "()Ljava.util.Set;")]
	internal class _1 : AbstractSet
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/UnmodifiableIterator<TK;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _1 : UnmodifiableIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024entryIterator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal MapIteratorCache._1 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(113)]
			internal _1(MapIteratorCache._1 P_0, Iterator P_1)
			{
				this_00241 = P_0;
				val_0024entryIterator = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(116)]
			public override bool hasNext()
			{
				bool result = val_0024entryIterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TK;")]
			[LineNumberTable(new byte[] { 71, 113, 114 })]
			public override object next()
			{
				Map.Entry entry = (Map.Entry)val_0024entryIterator.next();
				access_0024102(this_00241.this_00240, entry);
				object key = entry.getKey();
				_ = null;
				return key;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MapIteratorCache this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TK;>;")]
		[LineNumberTable(new byte[] { 61, 150 })]
		public new virtual UnmodifiableIterator iterator()
		{
			Iterator iterator = access_0024000(this_00240).entrySet().iterator();
			_1 result = new _1(this, iterator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(108)]
		internal _1(MapIteratorCache P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(130)]
		public override int size()
		{
			int result = access_0024000(this_00240).size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(135)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(108)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<TK;TV;>;")]
	private Map backingMap;

	[NonSerialized]
	[Signature("Ljava/util/Map$Entry<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile Map.Entry cacheEntry;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 9, 104, 113 })]
	internal MapIteratorCache(Map P_0)
	{
		backingMap = (Map)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(108)]
	internal Set unmodifiableKeySet()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 37, 103, 136, 99, 138 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual object get(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		object ifCached = getIfCached(P_0);
		if (ifCached == null)
		{
			object withoutCaching = getWithoutCaching(P_0);
			_ = null;
			return withoutCaching;
		}
		return ifCached;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(104)]
	internal bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (getIfCached(P_0) != null || backingMap.containsKey(P_0)) ? true : false;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(45)]
	internal static Map.Entry access_0024102(MapIteratorCache P_0, Map.Entry P_1)
	{
		P_0.cacheEntry = P_1;
		System.Threading.Thread.MemoryBarrier();
		return P_1;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(45)]
	internal static Map access_0024000(MapIteratorCache P_0)
	{
		return P_0.backingMap;
	}

	internal virtual void clearCache()
	{
		cacheEntry = null;
		System.Threading.Thread.MemoryBarrier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 94, 169, 108, 137 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual object getIfCached([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Map.Entry entry = cacheEntry;
		if (entry != null && entry.getKey() == P_0)
		{
			object value = entry.getValue();
			_ = null;
			return value;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 49, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal object getWithoutCaching(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		object result = backingMap.get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(new byte[] { 16, 103, 103, 102 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal object put(object P_0, object P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		clearCache();
		object result = backingMap.put(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 25, 103, 102 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal object remove(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		clearCache();
		object result = backingMap.remove(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 102, 109 })]
	internal void clear()
	{
		clearCache();
		backingMap.clear();
	}
}
