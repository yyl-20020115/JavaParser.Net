using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.math;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.cache;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public sealed class CacheStats : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long m_hitCount;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long m_missCount;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long m_loadSuccessCount;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long m_loadExceptionCount;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long m_totalLoadTime;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long m_evictionCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		35, 104, 109, 109, 109, 110, 110, 142, 103, 103,
		103, 104, 104, 104
	})]
	public CacheStats(long hitCount, long missCount, long loadSuccessCount, long loadExceptionCount, long totalLoadTime, long evictionCount)
	{
		Preconditions.checkArgument(hitCount >= 0);
		Preconditions.checkArgument(missCount >= 0);
		Preconditions.checkArgument(loadSuccessCount >= 0);
		Preconditions.checkArgument(loadExceptionCount >= 0);
		Preconditions.checkArgument(totalLoadTime >= 0);
		Preconditions.checkArgument(evictionCount >= 0);
		this.m_hitCount = hitCount;
		this.m_missCount = missCount;
		this.m_loadSuccessCount = loadSuccessCount;
		this.m_loadExceptionCount = loadExceptionCount;
		this.m_totalLoadTime = totalLoadTime;
		this.m_evictionCount = evictionCount;
	}

	public virtual long hitCount()
	{
		return this.m_hitCount;
	}

	public virtual long missCount()
	{
		return this.m_missCount;
	}

	public virtual long loadSuccessCount()
	{
		return this.m_loadSuccessCount;
	}

	public virtual long loadExceptionCount()
	{
		return this.m_loadExceptionCount;
	}

	public virtual long totalLoadTime()
	{
		return this.m_totalLoadTime;
	}

	public virtual long evictionCount()
	{
		return this.m_evictionCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(110)]
	public virtual long requestCount()
	{
		long result = LongMath.saturatedAdd(this.m_hitCount, this.m_missCount);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 74, 103 })]
	public virtual double hitRate()
	{
		long num = requestCount();
		return (num != 0) ? ((double)this.m_hitCount / (double)num) : 1.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 98, 103 })]
	public virtual double missRate()
	{
		long num = requestCount();
		return (num != 0) ? ((double)this.m_missCount / (double)num) : 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(162)]
	public virtual long loadCount()
	{
		long result = LongMath.saturatedAdd(this.m_loadSuccessCount, this.m_loadExceptionCount);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 89, 114 })]
	public virtual double loadExceptionRate()
	{
		long num = LongMath.saturatedAdd(this.m_loadSuccessCount, this.m_loadExceptionCount);
		return (num != 0) ? ((double)this.m_loadExceptionCount / (double)num) : 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 112, 114 })]
	public virtual double averageLoadPenalty()
	{
		long num = LongMath.saturatedAdd(this.m_loadSuccessCount, this.m_loadExceptionCount);
		return (num != 0) ? ((double)this.m_totalLoadTime / (double)num) : 0.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 130, 110, 120, 120, 120, 120, 120, 241, 58 })]
	public virtual CacheStats minus(CacheStats other)
	{
		CacheStats result = new CacheStats(Math.max(0L, LongMath.saturatedSubtract(this.m_hitCount, other.m_hitCount)), Math.max(0L, LongMath.saturatedSubtract(this.m_missCount, other.m_missCount)), Math.max(0L, LongMath.saturatedSubtract(this.m_loadSuccessCount, other.m_loadSuccessCount)), Math.max(0L, LongMath.saturatedSubtract(this.m_loadExceptionCount, other.m_loadExceptionCount)), Math.max(0L, LongMath.saturatedSubtract(this.m_totalLoadTime, other.m_totalLoadTime)), Math.max(0L, LongMath.saturatedSubtract(this.m_evictionCount, other.m_evictionCount)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 150, 108, 113, 113, 113, 113, 113, 236, 58 })]
	public virtual CacheStats plus(CacheStats other)
	{
		CacheStats result = new CacheStats(LongMath.saturatedAdd(this.m_hitCount, other.m_hitCount), LongMath.saturatedAdd(this.m_missCount, other.m_missCount), LongMath.saturatedAdd(this.m_loadSuccessCount, other.m_loadSuccessCount), LongMath.saturatedAdd(this.m_loadExceptionCount, other.m_loadExceptionCount), LongMath.saturatedAdd(this.m_totalLoadTime, other.m_totalLoadTime), LongMath.saturatedAdd(this.m_evictionCount, other.m_evictionCount));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 161, 110, 63, 45 })]
	public override int hashCode()
	{
		int result = Objects.hashCode(Long.valueOf(this.m_hitCount), Long.valueOf(this.m_missCount), Long.valueOf(this.m_loadSuccessCount), Long.valueOf(this.m_loadExceptionCount), Long.valueOf(this.m_totalLoadTime), Long.valueOf(this.m_evictionCount));
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		160,
		167,
		107,
		103,
		byte.MaxValue,
		58,
		71
	})]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		if (@object is CacheStats)
		{
			CacheStats cacheStats = (CacheStats)@object;
			return (this.m_hitCount == cacheStats.m_hitCount && this.m_missCount == cacheStats.m_missCount && this.m_loadSuccessCount == cacheStats.m_loadSuccessCount && this.m_loadExceptionCount == cacheStats.m_loadExceptionCount && this.m_totalLoadTime == cacheStats.m_totalLoadTime && this.m_evictionCount == cacheStats.m_evictionCount) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 181, 113, 112, 112, 112, 112, 112, 101, 231,
		57
	})]
	public override string toString()
	{
		string result = MoreObjects.toStringHelper(this).add("hitCount", this.m_hitCount).add("missCount", this.m_missCount)
			.add("loadSuccessCount", this.m_loadSuccessCount)
			.add("loadExceptionCount", this.m_loadExceptionCount)
			.add("totalLoadTime", this.m_totalLoadTime)
			.add("evictionCount", this.m_evictionCount)
			.toString();
		_ = null;
		return result;
	}
}
