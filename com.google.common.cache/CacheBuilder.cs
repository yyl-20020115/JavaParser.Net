using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util.concurrent;
using java.util.function;
using java.util.logging;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[ConstantPool(new object[]
{
	(byte)178,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public sealed class CacheBuilder : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, null, null)]
	internal class _1 : java.lang.Object, AbstractCache.StatsCounter
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(208)]
		internal _1()
		{
		}

		public virtual void recordHits(int P_0)
		{
		}

		public virtual void recordMisses(int P_0)
		{
		}

		public virtual void recordLoadSuccess(long P_0)
		{
		}

		public virtual void recordLoadException(long P_0)
		{
		}

		public virtual void recordEviction()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(228)]
		public virtual CacheStats snapshot()
		{
			return EMPTY_STATS;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Supplier<Lcom/google/common/cache/AbstractCache$StatsCounter;>;")]
	[EnclosingMethod(null, null, null)]
	[Implements(new string[] { "com.google.common.base.Supplier" })]
	internal class _2 : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(234)]
		internal _2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(237)]
		public virtual AbstractCache.StatsCounter get()
		{
			AbstractCache.SimpleStatsCounter result = new AbstractCache.SimpleStatsCounter();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(234)]
		public virtual object get()
		{
			AbstractCache.StatsCounter result = this.get();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, null, null)]
	internal class _3 : Ticker
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(258)]
		internal _3()
		{
		}

		public override long read()
		{
			return 0L;
		}

		[HideFromJava]
		static _3()
		{
			Ticker.___003Cclinit_003E();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/cache/CacheBuilder$NullListener;>;Lcom/google/common/cache/RemovalListener<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.cache.RemovalListener" })]
	internal sealed class NullListener : java.lang.Enum, RemovalListener
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static NullListener INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static NullListener[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(241)]
		private NullListener(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(241)]
		private static NullListener[] _0024values()
		{
			return new NullListener[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(241)]
		public static NullListener[] values()
		{
			return (NullListener[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(241)]
		public static NullListener valueOf(string P_0)
		{
			return (NullListener)java.lang.Enum.valueOf(ClassLiteral<NullListener>.Value, P_0);
		}

		[Signature("(Lcom/google/common/cache/RemovalNotification<Ljava/lang/Object;Ljava/lang/Object;>;)V")]
		public virtual void onRemoval(RemovalNotification P_0)
		{
		}

		[LineNumberTable(new byte[] { 160, 128, 48 })]
		static NullListener()
		{
			INSTANCE = new NullListener("INSTANCE", 0);
			_0024VALUES = _0024values();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/cache/CacheBuilder$OneWeigher;>;Lcom/google/common/cache/Weigher<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.cache.Weigher" })]
	internal sealed class OneWeigher : java.lang.Enum, Weigher
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static OneWeigher INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static OneWeigher[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(248)]
		private OneWeigher(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(248)]
		private static OneWeigher[] _0024values()
		{
			return new OneWeigher[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(248)]
		public static OneWeigher[] values()
		{
			return (OneWeigher[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(248)]
		public static OneWeigher valueOf(string P_0)
		{
			return (OneWeigher)java.lang.Enum.valueOf(ClassLiteral<OneWeigher>.Value, P_0);
		}

		public virtual int weigh(object P_0, object P_1)
		{
			return 1;
		}

		[LineNumberTable(new byte[] { 160, 135, 48 })]
		static OneWeigher()
		{
			INSTANCE = new OneWeigher("INSTANCE", 0);
			_0024VALUES = _0024values();
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private const int DEFAULT_INITIAL_CAPACITY = 16;

	private const int DEFAULT_CONCURRENCY_LEVEL = 4;

	private const int DEFAULT_EXPIRATION_NANOS = 0;

	private const int DEFAULT_REFRESH_NANOS = 0;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Supplier<+Lcom/google/common/cache/AbstractCache$StatsCounter;>;")]
	internal static com.google.common.@base.Supplier NULL_STATS_COUNTER;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static CacheStats EMPTY_STATS;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Supplier<Lcom/google/common/cache/AbstractCache$StatsCounter;>;")]
	internal static com.google.common.@base.Supplier CACHE_STATS_COUNTER;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static Ticker NULL_TICKER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	internal const int UNSET_INT = -1;

	internal bool strictParsing;

	internal int initialCapacity;

	internal int concurrencyLevel;

	internal long maximumSize;

	internal long maximumWeight;

	[Signature("Lcom/google/common/cache/Weigher<-TK;-TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 178, 0, 0 })]
	internal Weigher weigher;

	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 178, 0, 0 })]
	internal LocalCache.Strength keyStrength;

	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 178, 0, 0 })]
	internal LocalCache.Strength valueStrength;

	internal long expireAfterWriteNanos;

	internal long expireAfterAccessNanos;

	internal long refreshNanos;

	[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 178, 0, 0 })]
	internal Equivalence keyEquivalence;

	[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 178, 0, 0 })]
	internal Equivalence valueEquivalence;

	[Signature("Lcom/google/common/cache/RemovalListener<-TK;-TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 178, 0, 0 })]
	internal RemovalListener removalListener;

	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 178, 0, 0 })]
	internal Ticker ticker;

	[Signature("Lcom/google/common/base/Supplier<+Lcom/google/common/cache/AbstractCache$StatsCounter;>;")]
	internal com.google.common.@base.Supplier statsCounterSupplier;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/cache/CacheBuilder<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[LineNumberTable(308)]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public static CacheBuilder newBuilder()
	{
		CacheBuilder result = new CacheBuilder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(665)]
	public virtual CacheBuilder softValues()
	{
		CacheBuilder result = setValueStrength(LocalCache.Strength.SOFT);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(J)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 108, 154, 218, 118, 114, 103 })]
	public virtual CacheBuilder maximumSize(long maximumSize)
	{
		Preconditions.checkState(this.maximumSize == -1, "maximum size was already set to %s", this.maximumSize);
		Preconditions.checkState(this.maximumWeight == -1, "maximum weight was already set to %s", this.maximumWeight);
		Preconditions.checkState(this.weigher == null, (object)"maximum size can not be combined with weigher");
		Preconditions.checkArgument(maximumSize >= 0, (object)"maximum size must not be negative");
		this.maximumSize = maximumSize;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K1:TK;V1:TV;>()Lcom/google/common/cache/Cache<TK1;TV1;>;")]
	[LineNumberTable(new byte[] { 163, 135, 102, 102 })]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public virtual Cache build()
	{
		checkWeightWithWeigher();
		checkNonLoadingCache();
		LocalCache.LocalManualCache result = new LocalCache.LocalManualCache(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 183, 232, 36, 135, 103, 103, 104, 232, 70,
		168, 168, 232, 73, 139
	})]
	private CacheBuilder()
	{
		strictParsing = true;
		this.initialCapacity = -1;
		this.concurrencyLevel = -1;
		this.maximumSize = -1L;
		this.maximumWeight = -1L;
		expireAfterWriteNanos = -1L;
		expireAfterAccessNanos = -1L;
		refreshNanos = -1L;
		statsCounterSupplier = NULL_STATS_COUNTER;
	}

	[Signature("()Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	internal virtual CacheBuilder lenientParsing()
	{
		strictParsing = false;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/CacheBuilderSpec;)Lcom/google/common/cache/CacheBuilder<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[LineNumberTable(319)]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public static CacheBuilder from(CacheBuilderSpec spec)
	{
		CacheBuilder result = spec.toCacheBuilder().lenientParsing();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(618)]
	internal virtual LocalCache.Strength getKeyStrength()
	{
		return (LocalCache.Strength)MoreObjects.firstNonNull(keyStrength, LocalCache.Strength.STRONG);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(675)]
	internal virtual LocalCache.Strength getValueStrength()
	{
		return (LocalCache.Strength)MoreObjects.firstNonNull(valueStrength, LocalCache.Strength.STRONG);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/LocalCache$Strength;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 242, 124, 113 })]
	internal virtual CacheBuilder setKeyStrength(LocalCache.Strength P_0)
	{
		Preconditions.checkState(keyStrength == null, "Key strength was already set to %s", keyStrength);
		keyStrength = (LocalCache.Strength)Preconditions.checkNotNull(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/LocalCache$Strength;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 162, 43, 124, 113 })]
	internal virtual CacheBuilder setValueStrength(LocalCache.Strength P_0)
	{
		Preconditions.checkState(valueStrength == null, "Value strength was already set to %s", valueStrength);
		valueStrength = (LocalCache.Strength)Preconditions.checkNotNull(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 214, 127, 0, 97 })]
	private static long toNanosSaturated(Duration P_0)
	{
		//Discarded unreachable code: IL_0008
		try
		{
			return P_0.toNanos();
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.ArithmeticException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		return (!P_0.isNegative()) ? long.MaxValue : long.MinValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(JLjava/util/concurrent/TimeUnit;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 162, 103, 218, 116, 109 })]
	public virtual CacheBuilder expireAfterWrite(long duration, TimeUnit unit)
	{
		Preconditions.checkState(expireAfterWriteNanos == -1, "expireAfterWrite was already set to %s ns", expireAfterWriteNanos);
		Preconditions.checkArgument(duration >= 0, "duration cannot be negative: %s %s", duration, unit);
		expireAfterWriteNanos = unit.toNanos(duration);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(JLjava/util/concurrent/TimeUnit;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 162, 178, 218, 116, 109 })]
	public virtual CacheBuilder expireAfterAccess(long duration, TimeUnit unit)
	{
		Preconditions.checkState(expireAfterAccessNanos == -1, "expireAfterAccess was already set to %s ns", expireAfterAccessNanos);
		Preconditions.checkArgument(duration >= 0, "duration cannot be negative: %s %s", duration, unit);
		expireAfterAccessNanos = unit.toNanos(duration);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(JLjava/util/concurrent/TimeUnit;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 163, 5, 103, 122, 113, 109 })]
	public virtual CacheBuilder refreshAfterWrite(long duration, TimeUnit unit)
	{
		Preconditions.checkNotNull(unit);
		Preconditions.checkState(refreshNanos == -1, "refresh was already set to %s ns", refreshNanos);
		Preconditions.checkArgument(duration > 0, "duration must be positive: %s %s", duration, unit);
		refreshNanos = unit.toNanos(duration);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 145, 104, 150, 104, 153, 106, 214 })]
	private void checkWeightWithWeigher()
	{
		if (this.weigher == null)
		{
			Preconditions.checkState(this.maximumWeight == -1, (object)"maximumWeight requires weigher");
		}
		else if (strictParsing)
		{
			Preconditions.checkState(this.maximumWeight != -1, (object)"weigher requires maximumWeight");
		}
		else if (this.maximumWeight == -1)
		{
			logger.log(Level.WARNING, "ignoring weigher specified without maximumWeight");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 141, 118 })]
	private void checkNonLoadingCache()
	{
		Preconditions.checkState(refreshNanos == -1, (object)"refreshAfterWrite requires a LoadingCache");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)Lcom/google/common/cache/CacheBuilder<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[LineNumberTable(332)]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public static CacheBuilder from(string spec)
	{
		CacheBuilder result = from(CacheBuilderSpec.parse(spec));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 242, 124, 113 })]
	internal virtual CacheBuilder keyEquivalence(Equivalence P_0)
	{
		Preconditions.checkState(this.keyEquivalence == null, "key equivalence was already set to %s", this.keyEquivalence);
		this.keyEquivalence = (Equivalence)Preconditions.checkNotNull(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[LineNumberTable(362)]
	internal virtual Equivalence getKeyEquivalence()
	{
		return (Equivalence)MoreObjects.firstNonNull(this.keyEquivalence, getKeyStrength().defaultEquivalence());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 6, 156, 113 })]
	internal virtual CacheBuilder valueEquivalence(Equivalence P_0)
	{
		Preconditions.checkState(this.valueEquivalence == null, "value equivalence was already set to %s", this.valueEquivalence);
		this.valueEquivalence = (Equivalence)Preconditions.checkNotNull(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[LineNumberTable(383)]
	internal virtual Equivalence getValueEquivalence()
	{
		return (Equivalence)MoreObjects.firstNonNull(this.valueEquivalence, getValueStrength().defaultEquivalence());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 28, 217, 108, 103 })]
	public virtual CacheBuilder initialCapacity(int initialCapacity)
	{
		Preconditions.checkState(this.initialCapacity == -1, "initial capacity was already set to %s", this.initialCapacity);
		Preconditions.checkArgument(initialCapacity >= 0);
		this.initialCapacity = initialCapacity;
		return this;
	}

	internal virtual int getInitialCapacity()
	{
		return (this.initialCapacity != -1) ? this.initialCapacity : 16;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 73, 217, 105, 103 })]
	public virtual CacheBuilder concurrencyLevel(int concurrencyLevel)
	{
		Preconditions.checkState(this.concurrencyLevel == -1, "concurrency level was already set to %s", this.concurrencyLevel);
		Preconditions.checkArgument(concurrencyLevel > 0);
		this.concurrencyLevel = concurrencyLevel;
		return this;
	}

	internal virtual int getConcurrencyLevel()
	{
		return (this.concurrencyLevel != -1) ? this.concurrencyLevel : 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(J)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 149, 218, 154, 114, 103 })]
	public virtual CacheBuilder maximumWeight(long maximumWeight)
	{
		Preconditions.checkState(this.maximumWeight == -1, "maximum weight was already set to %s", this.maximumWeight);
		Preconditions.checkState(this.maximumSize == -1, "maximum size was already set to %s", this.maximumSize);
		Preconditions.checkArgument(maximumWeight >= 0, (object)"maximum weight must not be negative");
		this.maximumWeight = maximumWeight;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K1:TK;V1:TV;>(Lcom/google/common/cache/Weigher<-TK1;-TV1;>;)Lcom/google/common/cache/CacheBuilder<TK1;TV1;>;")]
	[LineNumberTable(new byte[] { 161, 192, 113, 104, 250, 72, 98, 113 })]
	public virtual CacheBuilder weigher(Weigher weigher)
	{
		Preconditions.checkState(this.weigher == null);
		if (strictParsing)
		{
			Preconditions.checkState(this.maximumSize == -1, "weigher can not be combined with maximum size", this.maximumSize);
		}
		this.weigher = (Weigher)Preconditions.checkNotNull(weigher);
		return this;
	}

	internal virtual long getMaximumWeight()
	{
		if (expireAfterWriteNanos == 0 || expireAfterAccessNanos == 0)
		{
			return 0L;
		}
		return (this.weigher != null) ? this.maximumWeight : this.maximumSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K1:TK;V1:TV;>()Lcom/google/common/cache/Weigher<TK1;TV1;>;")]
	[LineNumberTable(587)]
	internal virtual Weigher getWeigher()
	{
		return (Weigher)MoreObjects.firstNonNull(this.weigher, OneWeigher.INSTANCE);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(608)]
	public virtual CacheBuilder weakKeys()
	{
		CacheBuilder result = setKeyStrength(LocalCache.Strength.WEAK);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(640)]
	public virtual CacheBuilder weakValues()
	{
		CacheBuilder result = setValueStrength(LocalCache.Strength.WEAK);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/time/Duration;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(702)]
	public virtual CacheBuilder expireAfterWrite(Duration duration)
	{
		CacheBuilder result = expireAfterWrite(toNanosSaturated(duration), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	internal virtual long getExpireAfterWriteNanos()
	{
		return (expireAfterWriteNanos != -1) ? expireAfterWriteNanos : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/time/Duration;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(772)]
	public virtual CacheBuilder expireAfterAccess(Duration duration)
	{
		CacheBuilder result = expireAfterAccess(toNanosSaturated(duration), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	internal virtual long getExpireAfterAccessNanos()
	{
		return (expireAfterAccessNanos != -1) ? expireAfterAccessNanos : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/time/Duration;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(851)]
	public virtual CacheBuilder refreshAfterWrite(Duration duration)
	{
		CacheBuilder result = refreshAfterWrite(toNanosSaturated(duration), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	internal virtual long getRefreshNanos()
	{
		return (refreshNanos != -1) ? refreshNanos : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Ticker;)Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 163, 28, 113, 113 })]
	public virtual CacheBuilder ticker(Ticker ticker)
	{
		Preconditions.checkState(this.ticker == null);
		this.ticker = (Ticker)Preconditions.checkNotNull(ticker);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 158, 169, 66, 104, 135 })]
	internal virtual Ticker getTicker(bool P_0)
	{
		if (this.ticker != null)
		{
			return this.ticker;
		}
		return (!P_0) ? NULL_TICKER : Ticker.systemTicker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K1:TK;V1:TV;>(Lcom/google/common/cache/RemovalListener<-TK1;-TV1;>;)Lcom/google/common/cache/CacheBuilder<TK1;TV1;>;")]
	[LineNumberTable(new byte[] { 163, 64, 209, 98, 113 })]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public virtual CacheBuilder removalListener(RemovalListener listener)
	{
		Preconditions.checkState(this.removalListener == null);
		this.removalListener = (RemovalListener)Preconditions.checkNotNull(listener);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K1:TK;V1:TV;>()Lcom/google/common/cache/RemovalListener<TK1;TV1;>;")]
	[LineNumberTable(new byte[] { 163, 76, 107, 42 })]
	internal virtual RemovalListener getRemovalListener()
	{
		return (RemovalListener)MoreObjects.firstNonNull(this.removalListener, NullListener.INSTANCE);
	}

	[Signature("()Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
	public virtual CacheBuilder recordStats()
	{
		statsCounterSupplier = CACHE_STATS_COUNTER;
		return this;
	}

	internal virtual bool isRecordingStats()
	{
		return statsCounterSupplier == CACHE_STATS_COUNTER;
	}

	[Signature("()Lcom/google/common/base/Supplier<+Lcom/google/common/cache/AbstractCache$StatsCounter;>;")]
	internal virtual com.google.common.@base.Supplier getStatsCounterSupplier()
	{
		return statsCounterSupplier;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K1:TK;V1:TV;>(Lcom/google/common/cache/CacheLoader<-TK1;TV1;>;)Lcom/google/common/cache/LoadingCache<TK1;TV1;>;")]
	[LineNumberTable(new byte[] { 163, 117, 102 })]
	[CheckReturnValue(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/CheckReturnValue;"
	})]
	public virtual LoadingCache build(CacheLoader loader)
	{
		checkWeightWithWeigher();
		LocalCache.LocalLoadingCache result = new LocalCache.LocalLoadingCache(this, loader);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 164, 103, 105, 146, 105, 146, 106, 146, 106,
		146, 106, 159, 20, 106, 159, 20, 104, 156, 104,
		156, 104, 140, 104, 140, 104, 140
	})]
	public override string toString()
	{
		MoreObjects.ToStringHelper toStringHelper = MoreObjects.toStringHelper(this);
		if (this.initialCapacity != -1)
		{
			toStringHelper.add("initialCapacity", this.initialCapacity);
		}
		if (this.concurrencyLevel != -1)
		{
			toStringHelper.add("concurrencyLevel", this.concurrencyLevel);
		}
		if (this.maximumSize != -1)
		{
			toStringHelper.add("maximumSize", this.maximumSize);
		}
		if (this.maximumWeight != -1)
		{
			toStringHelper.add("maximumWeight", this.maximumWeight);
		}
		if (expireAfterWriteNanos != -1)
		{
			long lng = expireAfterWriteNanos;
			int num = 22;
			num = num;
			toStringHelper.add("expireAfterWrite", new StringBuilder(num).append(lng).append("ns").toString());
		}
		if (expireAfterAccessNanos != -1)
		{
			long lng = expireAfterAccessNanos;
			int num = 22;
			num = num;
			toStringHelper.add("expireAfterAccess", new StringBuilder(num).append(lng).append("ns").toString());
		}
		if (keyStrength != null)
		{
			toStringHelper.add("keyStrength", Ascii.toLowerCase(keyStrength.toString()));
		}
		if (valueStrength != null)
		{
			toStringHelper.add("valueStrength", Ascii.toLowerCase(valueStrength.toString()));
		}
		if (this.keyEquivalence != null)
		{
			toStringHelper.addValue("keyEquivalence");
		}
		if (this.valueEquivalence != null)
		{
			toStringHelper.addValue("valueEquivalence");
		}
		if (this.removalListener != null)
		{
			toStringHelper.addValue("removalListener");
		}
		string result = toStringHelper.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 92, 101, 234, 88, 150, 234, 88, 234, 72 })]
	static CacheBuilder()
	{
		NULL_STATS_COUNTER = Suppliers.ofInstance(new _1());
		EMPTY_STATS = new CacheStats(0L, 0L, 0L, 0L, 0L, 0L);
		CACHE_STATS_COUNTER = new _2();
		NULL_TICKER = new _3();
		logger = Logger.getLogger(ClassLiteral<CacheBuilder>.Value.getName(), CacheBuilder.___003CGetCallerID_003E());
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
