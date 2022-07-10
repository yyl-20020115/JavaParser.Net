using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.collect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class MapMaker : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/MapMaker$Dummy;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class Dummy : java.lang.Enum
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Dummy VALUE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Dummy[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(251)]
		private Dummy(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(251)]
		private static Dummy[] _0024values()
		{
			return new Dummy[1] { VALUE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(251)]
		public static Dummy[] values()
		{
			return (Dummy[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(251)]
		public static Dummy valueOf(string P_0)
		{
			return (Dummy)java.lang.Enum.valueOf(ClassLiteral<Dummy>.Value, P_0);
		}

		[LineNumberTable(new byte[] { 160, 138, 48 })]
		static Dummy()
		{
			VALUE = new Dummy("VALUE", 0);
			_0024VALUES = _0024values();
		}
	}

	private const int DEFAULT_INITIAL_CAPACITY = 16;

	private const int DEFAULT_CONCURRENCY_LEVEL = 4;

	internal const int UNSET_INT = -1;

	internal bool useCustomMap;

	internal int initialCapacity;

	internal int concurrencyLevel;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal MapMakerInternalMap.Strength keyStrength;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal MapMakerInternalMap.Strength valueStrength;

	[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal Equivalence keyEquivalence;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 61, 232, 52, 103, 231, 75 })]
	public MapMaker()
	{
		this.initialCapacity = -1;
		this.concurrencyLevel = -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 65, 217, 105, 103 })]
	public virtual MapMaker concurrencyLevel(int concurrencyLevel)
	{
		Preconditions.checkState(this.concurrencyLevel == -1, "concurrency level was already set to %s", this.concurrencyLevel);
		Preconditions.checkArgument(concurrencyLevel > 0);
		this.concurrencyLevel = concurrencyLevel;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(206)]
	public virtual MapMaker weakKeys()
	{
		MapMaker result = setKeyStrength(MapMakerInternalMap.Strength.WEAK);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;)Lcom/google/common/collect/MapMaker;")]
	[LineNumberTable(new byte[] { 73, 124, 113, 103 })]
	internal virtual MapMaker keyEquivalence(Equivalence P_0)
	{
		Preconditions.checkState(this.keyEquivalence == null, "key equivalence was already set to %s", this.keyEquivalence);
		this.keyEquivalence = (Equivalence)Preconditions.checkNotNull(P_0);
		useCustomMap = true;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(220)]
	internal virtual MapMakerInternalMap.Strength getKeyStrength()
	{
		return (MapMakerInternalMap.Strength)MoreObjects.firstNonNull(keyStrength, MapMakerInternalMap.Strength.STRONG);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 96, 124, 113, 136, 135 })]
	internal virtual MapMaker setKeyStrength(MapMakerInternalMap.Strength P_0)
	{
		Preconditions.checkState(keyStrength == null, "Key strength was already set to %s", keyStrength);
		keyStrength = (MapMakerInternalMap.Strength)Preconditions.checkNotNull(P_0);
		if (P_0 != MapMakerInternalMap.Strength.STRONG)
		{
			useCustomMap = true;
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 142, 124, 113, 136, 135 })]
	internal virtual MapMaker setValueStrength(MapMakerInternalMap.Strength P_0)
	{
		Preconditions.checkState(valueStrength == null, "Value strength was already set to %s", valueStrength);
		valueStrength = (MapMakerInternalMap.Strength)Preconditions.checkNotNull(P_0);
		if (P_0 != MapMakerInternalMap.Strength.STRONG)
		{
			useCustomMap = true;
		}
		return this;
	}

	internal virtual int getInitialCapacity()
	{
		return (this.initialCapacity != -1) ? this.initialCapacity : 16;
	}

	internal virtual int getConcurrencyLevel()
	{
		return (this.concurrencyLevel != -1) ? this.concurrencyLevel : 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[LineNumberTable(130)]
	internal virtual Equivalence getKeyEquivalence()
	{
		return (Equivalence)MoreObjects.firstNonNull(this.keyEquivalence, getKeyStrength().defaultEquivalence());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 95, 217, 108, 103 })]
	public virtual MapMaker initialCapacity(int initialCapacity)
	{
		Preconditions.checkState(this.initialCapacity == -1, "initial capacity was already set to %s", this.initialCapacity);
		Preconditions.checkArgument(initialCapacity >= 0);
		this.initialCapacity = initialCapacity;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(242)]
	public virtual MapMaker weakValues()
	{
		MapMaker result = setValueStrength(MapMakerInternalMap.Strength.WEAK);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(266)]
	internal virtual MapMakerInternalMap.Strength getValueStrength()
	{
		return (MapMakerInternalMap.Strength)MoreObjects.firstNonNull(valueStrength, MapMakerInternalMap.Strength.STRONG);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 167, 104, 158 })]
	public virtual ConcurrentMap makeMap()
	{
		if (!useCustomMap)
		{
			ConcurrentHashMap.___003Cclinit_003E();
			ConcurrentHashMap result = new ConcurrentHashMap(getInitialCapacity(), 0.75f, getConcurrencyLevel());
			_ = null;
			return result;
		}
		MapMakerInternalMap result2 = MapMakerInternalMap.create(this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 179, 103, 105, 146, 105, 146, 104, 156, 104,
		156, 104, 140
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
		string result = toStringHelper.toString();
		_ = null;
		return result;
	}
}
