using System.Runtime.CompilerServices;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/cache/Cache<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public abstract class AbstractCache : Object, Cache
{
	public sealed class SimpleStatsCounter : Object, StatsCounter
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LongAddable hitCount;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LongAddable missCount;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LongAddable loadSuccessCount;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LongAddable loadExceptionCount;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LongAddable totalLoadTime;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private LongAddable evictionCount;

		private static long negativeToMaxValue(long P_0)
		{
			return (P_0 < 0) ? long.MaxValue : P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 97, 232, 56, 107, 107, 107, 107, 107, 171 })]
		public SimpleStatsCounter()
		{
			hitCount = LongAddables.create();
			missCount = LongAddables.create();
			loadSuccessCount = LongAddables.create();
			loadExceptionCount = LongAddables.create();
			totalLoadTime = LongAddables.create();
			evictionCount = LongAddables.create();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 102, 111 })]
		public virtual void recordHits(int count)
		{
			hitCount.add(count);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 108, 111 })]
		public virtual void recordMisses(int count)
		{
			missCount.add(count);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 114, 107, 110 })]
		public virtual void recordLoadSuccess(long loadTime)
		{
			loadSuccessCount.increment();
			totalLoadTime.add(loadTime);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 121, 107, 110 })]
		public virtual void recordLoadException(long loadTime)
		{
			loadExceptionCount.increment();
			totalLoadTime.add(loadTime);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 127, 109 })]
		public virtual void recordEviction()
		{
			evictionCount.increment();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 132, 102, 112, 112, 112, 112, 112, 241, 58 })]
		public virtual CacheStats snapshot()
		{
			CacheStats result = new CacheStats(negativeToMaxValue(hitCount.sum()), negativeToMaxValue(missCount.sum()), negativeToMaxValue(loadSuccessCount.sum()), negativeToMaxValue(loadExceptionCount.sum()), negativeToMaxValue(totalLoadTime.sum()), negativeToMaxValue(evictionCount.sum()));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 148, 103, 113, 113, 113, 113, 113, 115 })]
		public virtual void incrementBy(StatsCounter other)
		{
			CacheStats cacheStats = other.snapshot();
			hitCount.add(cacheStats.hitCount());
			missCount.add(cacheStats.missCount());
			loadSuccessCount.add(cacheStats.loadSuccessCount());
			loadExceptionCount.add(cacheStats.loadExceptionCount());
			totalLoadTime.add(cacheStats.totalLoadTime());
			evictionCount.add(cacheStats.evictionCount());
		}
	}

	public interface StatsCounter
	{
		virtual void recordHits(int i);

		virtual void recordMisses(int i);

		virtual void recordLoadSuccess(long l);

		virtual void recordLoadException(long l);

		virtual void recordEviction();

		virtual CacheStats snapshot();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract object getIfPresent(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)V")]
	[LineNumberTable(85)]
	public virtual void put(object key, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(106)]
	public virtual void invalidate(object key)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	protected internal AbstractCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(TK;Ljava/util/concurrent/Callable<+TV;>;)TV;")]
	[LineNumberTable(50)]
	public virtual object get(object key, Callable valueLoader)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 18, 102, 118, 137, 98, 105, 100, 170, 98 })]
	public virtual ImmutableMap getAllPresent(Iterable keys)
	{
		LinkedHashMap linkedHashMap = Maps.newLinkedHashMap();
		Iterator iterator = keys.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (!((Map)linkedHashMap).containsKey(obj))
			{
				object key = obj;
				object ifPresent = getIfPresent(obj);
				if (ifPresent != null)
				{
					((Map)linkedHashMap).put(key, ifPresent);
				}
			}
		}
		ImmutableMap result = ImmutableMap.copyOf(linkedHashMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 41, 127, 1, 114, 98 })]
	public virtual void putAll(Map m)
	{
		Iterator iterator = m.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			put(entry.getKey(), entry.getValue());
		}
	}

	public virtual void cleanUp()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(101)]
	public virtual long size()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;)V")]
	[LineNumberTable(new byte[] { 63, 118, 103, 98 })]
	public virtual void invalidateAll(Iterable keys)
	{
		Iterator iterator = keys.iterator();
		while (iterator.hasNext())
		{
			object key = iterator.next();
			invalidate(key);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(120)]
	public virtual void invalidateAll()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(125)]
	public virtual CacheStats stats()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
	[LineNumberTable(130)]
	public virtual ConcurrentMap asMap()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}
}
