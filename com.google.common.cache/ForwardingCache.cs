using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingObject;Lcom/google/common/cache/Cache<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.cache.Cache" })]
public abstract class ForwardingCache : ForwardingObject, Cache
{
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/ForwardingCache<TK;TV;>;")]
	public abstract class SimpleForwardingCache : ForwardingCache
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/cache/Cache<TK;TV;>;")]
		private new Cache m_delegate;

		[Signature("()Lcom/google/common/cache/Cache<TK;TV;>;")]
		protected internal sealed override Cache @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/Cache<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 76, 104, 113 })]
		protected internal SimpleForwardingCache(Cache @delegate)
		{
			this.m_delegate = (Cache)Preconditions.checkNotNull(@delegate);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(123)]
		protected internal override object _003Cbridge_003Edelegate()
		{
			Cache result = @delegate();
			_ = null;
			return result;
		}
	}

	[Signature("()Lcom/google/common/cache/Cache<TK;TV;>;")]
	protected internal new abstract Cache @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	protected internal ForwardingCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(49)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object getIfPresent(object key)
	{
		object ifPresent = @delegate().getIfPresent(key);
		_ = null;
		return ifPresent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(TK;Ljava/util/concurrent/Callable<+TV;>;)TV;")]
	[LineNumberTable(55)]
	public virtual object get(object key, Callable valueLoader)
	{
		object result = @delegate().get(key, valueLoader);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(65)]
	public virtual ImmutableMap getAllPresent(Iterable keys)
	{
		ImmutableMap allPresent = @delegate().getAllPresent(keys);
		_ = null;
		return allPresent;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)V")]
	[LineNumberTable(new byte[] { 21, 111 })]
	public virtual void put(object key, object value)
	{
		@delegate().put(key, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 27, 110 })]
	public virtual void putAll(Map m)
	{
		@delegate().putAll(m);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 110 })]
	public virtual void invalidate(object key)
	{
		@delegate().invalidate(key);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;)V")]
	[LineNumberTable(new byte[] { 39, 110 })]
	public virtual void invalidateAll(Iterable keys)
	{
		@delegate().invalidateAll(keys);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 44, 109 })]
	public virtual void invalidateAll()
	{
		@delegate().invalidateAll();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(99)]
	public virtual long size()
	{
		long result = @delegate().size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(104)]
	public virtual CacheStats stats()
	{
		CacheStats result = @delegate().stats();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
	[LineNumberTable(109)]
	public virtual ConcurrentMap asMap()
	{
		ConcurrentMap result = @delegate().asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 64, 109 })]
	public virtual void cleanUp()
	{
		@delegate().cleanUp();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(35)]
	protected internal virtual object _003Cbridge_003Edelegate()
	{
		Cache result = @delegate();
		_ = null;
		return result;
	}
}
