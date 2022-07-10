using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using java.util.function;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Serializable]
[Signature("<K:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class AtomicLongMap : java.lang.Object, Serializable.__Interface, ISerializable
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : LongBinaryOperator
	{
		internal ___003C_003EAnon0()
		{
		}

		public long applyAsLong(long P_0, long P_1)
		{
			long result = Long.sum(P_0, P_1);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : BiFunction
	{
		private readonly LongUnaryOperator arg_00241;

		internal ___003C_003EAnon1(LongUnaryOperator P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0, object P_1)
		{
			Long result = lambda_0024updateAndGet_00240(arg_00241, P_0, (Long)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BiFunction
	{
		private readonly AtomicLong arg_00241;

		private readonly LongUnaryOperator arg_00242;

		internal ___003C_003EAnon2(AtomicLong P_0, LongUnaryOperator P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0, object P_1)
		{
			Long result = lambda_0024getAndUpdate_00241(arg_00241, arg_00242, P_0, (Long)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : LongUnaryOperator
	{
		private readonly LongBinaryOperator arg_00241;

		private readonly long arg_00242;

		internal ___003C_003EAnon3(LongBinaryOperator P_0, long P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public long applyAsLong(long P_0)
		{
			long result = lambda_0024accumulateAndGet_00242(arg_00241, arg_00242, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public LongUnaryOperator compose(LongUnaryOperator P_0)
		{
			return LongUnaryOperator._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public LongUnaryOperator andThen(LongUnaryOperator P_0)
		{
			return LongUnaryOperator._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : LongUnaryOperator
	{
		private readonly LongBinaryOperator arg_00241;

		private readonly long arg_00242;

		internal ___003C_003EAnon4(LongBinaryOperator P_0, long P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public long applyAsLong(long P_0)
		{
			long result = lambda_0024getAndAccumulate_00243(arg_00241, arg_00242, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public LongUnaryOperator compose(LongUnaryOperator P_0)
		{
			return LongUnaryOperator._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public LongUnaryOperator andThen(LongUnaryOperator P_0)
		{
			return LongUnaryOperator._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon5 : LongUnaryOperator
	{
		private readonly long arg_00241;

		internal ___003C_003EAnon5(long P_0)
		{
			arg_00241 = P_0;
		}

		public long applyAsLong(long P_0)
		{
			long result = lambda_0024put_00244(arg_00241, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public LongUnaryOperator compose(LongUnaryOperator P_0)
		{
			return LongUnaryOperator._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public LongUnaryOperator andThen(LongUnaryOperator P_0)
		{
			return LongUnaryOperator._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon6 : BiConsumer
	{
		private readonly AtomicLongMap arg_00241;

		internal ___003C_003EAnon6(AtomicLongMap P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0, object P_1)
		{
			arg_00241.put(P_0, ((Long)P_1).longValue());
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon7 : java.util.function.Predicate
	{
		internal ___003C_003EAnon7()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024removeAllZeros_00245((Long)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		[SpecialName]
		public java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		[SpecialName]
		public java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon8 : ToLongFunction
	{
		internal ___003C_003EAnon8()
		{
		}

		public long applyAsLong(object P_0)
		{
			long result = ((Long)P_0).longValue();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon9 : BiFunction
	{
		private readonly AtomicBoolean arg_00241;

		private readonly long arg_00242;

		internal ___003C_003EAnon9(AtomicBoolean P_0, long P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0, object P_1)
		{
			Long result = lambda_0024putIfAbsent_00246(arg_00241, arg_00242, P_0, (Long)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/concurrent/ConcurrentHashMap<TK;Ljava/lang/Long;>;")]
	private ConcurrentHashMap map;

	[NonSerialized]
	[Signature("Ljava/util/Map<TK;Ljava/lang/Long;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Map m_asMap;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/ConcurrentHashMap<TK;Ljava/lang/Long;>;)V")]
	[LineNumberTable(new byte[] { 12, 104, 113 })]
	private AtomicLongMap(ConcurrentHashMap P_0)
	{
		map = (ConcurrentHashMap)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;>()Lcom/google/common/util/concurrent/AtomicLongMap<TK;>;")]
	[LineNumberTable(68)]
	public static AtomicLongMap create()
	{
		AtomicLongMap result = new AtomicLongMap(new ConcurrentHashMap());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+Ljava/lang/Long;>;)V")]
	[LineNumberTable(new byte[] { 160, 101, 115 })]
	public virtual void putAll(Map m)
	{
		m.forEach(new ___003C_003EAnon6(this));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;J)J")]
	[LineNumberTable(108)]
	public virtual long addAndGet(object key, long delta)
	{
		long result = accumulateAndGet(key, delta, new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;JLjava/util/function/LongBinaryOperator;)J")]
	[LineNumberTable(new byte[] { 160, 67, 103 })]
	public virtual long accumulateAndGet(object key, long x, LongBinaryOperator accumulatorFunction)
	{
		Preconditions.checkNotNull(accumulatorFunction);
		long result = updateAndGet(key, new ___003C_003EAnon3(accumulatorFunction, x));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;J)J")]
	[LineNumberTable(133)]
	public virtual long getAndAdd(object key, long delta)
	{
		long andAccumulate = getAndAccumulate(key, delta, new ___003C_003EAnon0());
		_ = null;
		return andAccumulate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;JLjava/util/function/LongBinaryOperator;)J")]
	[LineNumberTable(new byte[] { 160, 81, 103 })]
	public virtual long getAndAccumulate(object key, long x, LongBinaryOperator accumulatorFunction)
	{
		Preconditions.checkNotNull(accumulatorFunction);
		long andUpdate = getAndUpdate(key, new ___003C_003EAnon4(accumulatorFunction, x));
		_ = null;
		return andUpdate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/function/LongUnaryOperator;)J")]
	[LineNumberTable(new byte[] { 95, 103 })]
	public virtual long updateAndGet(object key, LongUnaryOperator updaterFunction)
	{
		Preconditions.checkNotNull(updaterFunction);
		long result = ((Long)map.compute(key, new ___003C_003EAnon1(updaterFunction))).longValue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/function/LongUnaryOperator;)J")]
	[LineNumberTable(new byte[] { 109, 103, 102, 249, 71 })]
	public virtual long getAndUpdate(object key, LongUnaryOperator updaterFunction)
	{
		Preconditions.checkNotNull(updaterFunction);
		AtomicLong atomicLong = new AtomicLong();
		map.compute(key, new ___003C_003EAnon2(atomicLong, updaterFunction));
		long result = atomicLong.get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;J)Z")]
	[LineNumberTable(233)]
	internal virtual bool remove(object P_0, long P_1)
	{
		bool result = map.remove(P_0, Long.valueOf(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/lang/Long;>;")]
	[LineNumberTable(275)]
	private Map createAsMap()
	{
		Map result = Collections.unmodifiableMap(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;J)J")]
	[LineNumberTable(new byte[] { 160, 203, 103, 115, 235, 74 })]
	internal virtual long putIfAbsent(object P_0, long P_1)
	{
		AtomicBoolean atomicBoolean = new AtomicBoolean(initialValue: false);
		Long @long = (Long)map.compute(P_0, new ___003C_003EAnon9(atomicBoolean, P_1));
		long result = ((!atomicBoolean.get()) ? @long.longValue() : 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(147)]
	private static Long lambda_0024updateAndGet_00240(LongUnaryOperator P_0, object P_1, Long P_2)
	{
		Long result = Long.valueOf(P_0.applyAsLong(P_2?.longValue() ?? 0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 114, 110, 103 })]
	private static Long lambda_0024getAndUpdate_00241(AtomicLong P_0, LongUnaryOperator P_1, object P_2, Long P_3)
	{
		long num = P_3?.longValue() ?? 0;
		P_0.set(num);
		Long result = Long.valueOf(P_1.applyAsLong(num));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(182)]
	private static long lambda_0024accumulateAndGet_00242(LongBinaryOperator P_0, long P_1, long P_2)
	{
		long result = P_0.applyAsLong(P_2, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(196)]
	private static long lambda_0024getAndAccumulate_00243(LongBinaryOperator P_0, long P_1, long P_2)
	{
		long result = P_0.applyAsLong(P_2, P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static long lambda_0024put_00244(long P_0, long P_1)
	{
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;J)J")]
	[LineNumberTable(205)]
	public virtual long put(object key, long newValue)
	{
		long andUpdate = getAndUpdate(key, new ___003C_003EAnon5(newValue));
		_ = null;
		return andUpdate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(254)]
	private static bool lambda_0024removeAllZeros_00245(Long P_0)
	{
		return P_0.longValue() == 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 160, 208, 109, 103, 137 })]
	private static Long lambda_0024putIfAbsent_00246(AtomicBoolean P_0, long P_1, object P_2, Long P_3)
	{
		if (P_3 == null || P_3.longValue() == 0)
		{
			P_0.set(newValue: true);
			Long result = Long.valueOf(P_1);
			_ = null;
			return result;
		}
		return P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;>(Ljava/util/Map<+TK;+Ljava/lang/Long;>;)Lcom/google/common/util/concurrent/AtomicLongMap<TK;>;")]
	[LineNumberTable(new byte[] { 23, 102, 103 })]
	public static AtomicLongMap create(Map m)
	{
		AtomicLongMap atomicLongMap = create();
		atomicLongMap.putAll(m);
		return atomicLongMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)J")]
	[LineNumberTable(83)]
	public virtual long get(object key)
	{
		long result = ((Long)map.getOrDefault(key, Long.valueOf(0L))).longValue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)J")]
	[LineNumberTable(91)]
	public virtual long incrementAndGet(object key)
	{
		long result = addAndGet(key, 1L);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)J")]
	[LineNumberTable(99)]
	public virtual long decrementAndGet(object key)
	{
		long result = addAndGet(key, -1L);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)J")]
	[LineNumberTable(116)]
	public virtual long getAndIncrement(object key)
	{
		long andAdd = getAndAdd(key, 1L);
		_ = null;
		return andAdd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)J")]
	[LineNumberTable(124)]
	public virtual long getAndDecrement(object key)
	{
		long andAdd = getAndAdd(key, -1L);
		_ = null;
		return andAdd;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)J")]
	[LineNumberTable(new byte[] { 160, 110, 114 })]
	public virtual long remove(object key)
	{
		long result = ((Long)map.remove(key))?.longValue() ?? 0;
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Z")]
	[LineNumberTable(244)]
	public virtual bool removeIfZero(object key)
	{
		bool result = remove(key, 0L);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 140, 123 })]
	public virtual void removeAllZeros()
	{
		map.values().removeIf(new ___003C_003EAnon7());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(263)]
	public virtual long sum()
	{
		long result = map.values().stream().mapToLong(new ___003C_003EAnon8())
			.sum();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/lang/Long;>;")]
	[LineNumberTable(new byte[] { 160, 156, 103 })]
	public virtual Map asMap()
	{
		Map map = this.m_asMap;
		Map result;
		if (map == null)
		{
			Map map2 = createAsMap();
			result = map2;
			this.m_asMap = map2;
		}
		else
		{
			result = map;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(280)]
	public virtual bool containsKey(object key)
	{
		bool result = map.containsKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(288)]
	public virtual int size()
	{
		int result = map.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(293)]
	public virtual bool isEmpty()
	{
		bool result = map.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 189, 109 })]
	public virtual void clear()
	{
		map.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(308)]
	public override string toString()
	{
		string result = map.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;JJ)Z")]
	[LineNumberTable(new byte[] { 160, 226, 105, 141 })]
	internal virtual bool replace(object P_0, long P_1, long P_2)
	{
		if (P_1 == 0)
		{
			return putIfAbsent(P_0, P_2) == 0;
		}
		bool result = map.replace(P_0, Long.valueOf(P_1), Long.valueOf(P_2));
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(AtomicLongMap P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected AtomicLongMap(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
