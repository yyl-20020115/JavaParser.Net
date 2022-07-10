using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)107,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.ListMultimap" })]
public class ImmutableListMultimap : ImmutableMultimap, ListMultimap, Multimap
{
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
	public new sealed class Builder : ImmutableMultimap.Builder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 111, 105 })]
		public new virtual Builder put(object key, object value)
		{
			base.put(key, value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 164, 104 })]
		internal new virtual Builder combine(ImmutableMultimap.Builder P_0)
		{
			base.combine(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
		[LineNumberTable(309)]
		public new virtual ImmutableListMultimap build()
		{
			return (ImmutableListMultimap)base.build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(220)]
		public Builder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 136, 104 })]
		public new virtual Builder putAll(Iterable entries)
		{
			base.putAll(entries);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 188, 104 })]
		public new virtual Builder orderValuesBy(Comparator valueComparator)
		{
			base.orderValuesBy(valueComparator);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TK;>;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 176, 104 })]
		public new virtual Builder orderKeysBy(Comparator keyComparator)
		{
			base.orderKeysBy(keyComparator);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 157, 104 })]
		public new virtual Builder putAll(Multimap multimap)
		{
			base.putAll(multimap);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;[TV;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 150, 105 })]
		public new virtual Builder putAll(object key, params object[] values)
		{
			base.putAll(key, values);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 143, 105 })]
		public new virtual Builder putAll(object key, Iterable values)
		{
			base.putAll(key, values);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 123, 104 })]
		public new virtual Builder put(Map.Entry entry)
		{
			base.put(entry);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap _003Cbridge_003Ebuild()
		{
			ImmutableListMultimap result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(215)]
		internal override ImmutableMultimap.Builder combine(ImmutableMultimap.Builder P_0)
		{
			Builder result = combine(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EorderValuesBy(Comparator c)
		{
			Builder result = orderValuesBy(c);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EorderKeysBy(Comparator c)
		{
			Builder result = orderKeysBy(c);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EputAll(Multimap m)
		{
			Builder result = putAll(m);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EputAll(object obj, object[] objarr)
		{
			Builder result = putAll(obj, objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EputAll(object obj, Iterable i)
		{
			Builder result = putAll(obj, i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EputAll(Iterable i)
		{
			Builder result = putAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003Eput(Map.Entry me)
		{
			Builder result = put(me);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(215)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003Eput(object obj1, object obj2)
		{
			Builder result = put(obj1, obj2);
			_ = null;
			return result;
		}
	}

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableListMultimap<TV;TK;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new ImmutableListMultimap m_inverse;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableListMultimap$Builder<TK;TV;>;")]
	[LineNumberTable(193)]
	public new static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 212, 104, 200, 136, 103, 104, 194 })]
	public new static ImmutableListMultimap copyOf(Multimap multimap)
	{
		if (multimap.isEmpty())
		{
			ImmutableListMultimap result = of();
			_ = null;
			return result;
		}
		if (multimap is ImmutableListMultimap)
		{
			ImmutableListMultimap immutableListMultimap = (ImmutableListMultimap)multimap;
			if (!immutableListMultimap.isPartialView())
			{
				return immutableListMultimap;
			}
		}
		ImmutableListMultimap result2 = fromMapEntries(multimap.asMap().entrySet(), null);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(136)]
	public new static ImmutableListMultimap of()
	{
		return EmptyImmutableListMultimap.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 91, 102, 105 })]
	public new static ImmutableListMultimap of(object k1, object v1)
	{
		Builder builder = ImmutableListMultimap.builder();
		builder.put(k1, v1);
		ImmutableListMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 98, 102, 105, 105 })]
	public new static ImmutableListMultimap of(object k1, object v1, object k2, object v2)
	{
		Builder builder = ImmutableListMultimap.builder();
		builder.put(k1, v1);
		builder.put(k2, v2);
		ImmutableListMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 106, 102, 105, 105, 107 })]
	public new static ImmutableListMultimap of(object k1, object v1, object k2, object v2, object k3, object v3)
	{
		Builder builder = ImmutableListMultimap.builder();
		builder.put(k1, v1);
		builder.put(k2, v2);
		builder.put(k3, v3);
		ImmutableListMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 116, 102, 105, 105, 107, 107 })]
	public new static ImmutableListMultimap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4)
	{
		Builder builder = ImmutableListMultimap.builder();
		builder.put(k1, v1);
		builder.put(k2, v2);
		builder.put(k3, v3);
		builder.put(k4, v4);
		ImmutableListMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 127, 102, 105, 105, 107, 107, 107 })]
	public new static ImmutableListMultimap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5)
	{
		Builder builder = ImmutableListMultimap.builder();
		builder.put(k1, v1);
		builder.put(k2, v2);
		builder.put(k3, v3);
		builder.put(k4, v4);
		builder.put(k5, v5);
		ImmutableListMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(353)]
	public new static ImmutableListMultimap copyOf(Iterable entries)
	{
		ImmutableListMultimap result = new Builder().putAll(entries).build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/Map$Entry<+TK;+Ljava/util/Collection<+TV;>;>;>;Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 1, 0, 0, 107, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		160, 246, 104, 136, 97, 107, 130, 126, 104, 141,
		99, 105, 106, 105, 107, 138, 133
	})]
	internal static ImmutableListMultimap fromMapEntries(Collection P_0, Comparator P_1)
	{
		if (P_0.isEmpty())
		{
			ImmutableListMultimap result = of();
			_ = null;
			return result;
		}
		ImmutableMap.Builder builder = new ImmutableMap.Builder(P_0.size());
		int num = 0;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			object key = entry.getKey();
			Collection elements = (Collection)entry.getValue();
			ImmutableList immutableList = ((P_1 != null) ? ImmutableList.sortedCopyOf(P_1, elements) : ImmutableList.copyOf(elements));
			if (!immutableList.isEmpty())
			{
				builder.put(key, immutableList);
				num += immutableList.size();
			}
		}
		ImmutableListMultimap result2 = new ImmutableListMultimap(builder.buildOrThrow(), num);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableMap<TK;Lcom/google/common/collect/ImmutableList<TV;>;>;I)V")]
	[LineNumberTable(new byte[] { 161, 14, 106 })]
	internal ImmutableListMultimap(ImmutableMap P_0, int P_1)
		: base(P_0, P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableListMultimap<TV;TK;>;")]
	[LineNumberTable(new byte[] { 161, 49, 102, 127, 1, 115, 98, 103, 103 })]
	private ImmutableListMultimap invert()
	{
		Builder builder = ImmutableListMultimap.builder();
		UnmodifiableIterator unmodifiableIterator = entries().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Map.Entry entry = (Map.Entry)((Iterator)unmodifiableIterator).next();
			builder.put(entry.getValue(), entry.getKey());
		}
		ImmutableListMultimap immutableListMultimap = builder.build();
		immutableListMultimap.m_inverse = this;
		return immutableListMultimap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableListMultimap<TV;TK;>;")]
	[LineNumberTable(new byte[] { 161, 44, 103 })]
	public new virtual ImmutableListMultimap inverse()
	{
		ImmutableListMultimap immutableListMultimap = this.m_inverse;
		ImmutableListMultimap result;
		if (immutableListMultimap == null)
		{
			ImmutableListMultimap immutableListMultimap2 = invert();
			result = immutableListMultimap2;
			this.m_inverse = immutableListMultimap2;
		}
		else
		{
			result = immutableListMultimap;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Lcom/google/common/collect/ImmutableList<TV;>;")]
	[LineNumberTable(new byte[] { 161, 27, 114 })]
	public new virtual ImmutableList get(object key)
	{
		ImmutableList immutableList = (ImmutableList)map.get(key);
		return (immutableList != null) ? immutableList : ImmutableList.of();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Lcom/google/common/collect/ImmutableList<TV;>;")]
	[LineNumberTable(453)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new ImmutableList replaceValues(object key, Iterable values)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList<TV;>;")]
	[LineNumberTable(439)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new ImmutableList removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 107, 0, 0 })]
	[LineNumberTable(87)]
	public static Collector toImmutableListMultimap(Function keyFunction, Function valueFunction)
	{
		Collector result = CollectCollectors.toImmutableListMultimap(keyFunction, valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+Ljava/util/stream/Stream<+TV;>;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 107, 0, 0 })]
	[LineNumberTable(125)]
	public static Collector flatteningToImmutableListMultimap(Function keyFunction, Function valuesFunction)
	{
		Collector result = CollectCollectors.flatteningToImmutableListMultimap(keyFunction, valuesFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 161, 92, 102, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		Serialization.writeMultimap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 98, 102, 103, 100, 159, 12, 102, 130, 107,
		104, 104, 101, 191, 13, 103, 105, 46, 168, 112,
		229, 52, 235, 81, 188, 2, 98, 190, 109, 108
	})]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		int num = P_0.readInt();
		if (num < 0)
		{
			int num2 = 29;
			num2 = num2;
			string reason = new StringBuilder(num2).append("Invalid key count ").append(num).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new InvalidObjectException(reason);
		}
		ImmutableMap.Builder builder = ImmutableMap.builder();
		int num3 = 0;
		for (int i = 0; i < num; i++)
		{
			object key = P_0.readObject();
			int num4 = P_0.readInt();
			if (num4 <= 0)
			{
				int num2 = 31;
				num2 = num2;
				string reason2 = new StringBuilder(num2).append("Invalid value count ").append(num4).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new InvalidObjectException(reason2);
			}
			ImmutableList.Builder builder2 = ImmutableList.builder();
			for (int j = 0; j < num4; j++)
			{
				builder2.add(P_0.readObject());
			}
			builder.put(key, builder2.build());
			num3 += num4;
		}
		ImmutableMap immutableMap;
		IllegalArgumentException ex;
		try
		{
			immutableMap = builder.buildOrThrow();
		}
		catch (IllegalArgumentException x)
		{
			ex = ByteCodeHelper.MapException<IllegalArgumentException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00ee;
		}
		FieldSettersHolder.MAP_FIELD_SETTER.set(this, immutableMap);
		FieldSettersHolder.SIZE_FIELD_SETTER.set(this, num3);
		return;
		IL_00ee:
		IllegalArgumentException ex2 = ex;
		throw Throwable.___003Cunmap_003E((InvalidObjectException)Throwable.instancehelper_initCause(new InvalidObjectException(Throwable.instancehelper_getMessage(ex2)), ex2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public virtual ImmutableMultimap _003Cbridge_003Einverse()
	{
		ImmutableListMultimap result = inverse();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public new virtual ImmutableCollection _003Cbridge_003Eget(object obj)
	{
		ImmutableList result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual ImmutableCollection _003Cbridge_003EreplaceValues(object obj, Iterable i)
	{
		ImmutableList result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual ImmutableCollection _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		ImmutableList result = removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override Collection _003Cbridge_003EreplaceValues(object obj, Iterable i)
	{
		ImmutableList result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public override Collection _003Cbridge_003Eget(object obj)
	{
		ImmutableList result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override Collection _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		ImmutableList result = removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual List _003Cbridge_003EreplaceValues(object obj, Iterable i)
	{
		ImmutableList result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual List _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		ImmutableList result = removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public new virtual List _003Cbridge_003Eget(object obj)
	{
		ImmutableList result = get(obj);
		_ = null;
		return result;
	}

	List ListMultimap.ListMultimap_003A_003Aget(object P_0)
	{
		return this._003Cbridge_003Eget(P_0);
	}

	List ListMultimap.ListMultimap_003A_003AremoveAll(object P_0)
	{
		return this._003Cbridge_003EremoveAll(P_0);
	}

	List ListMultimap.ListMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return this._003Cbridge_003EreplaceValues(P_0, P_1);
	}

	Map ListMultimap.ListMultimap_003A_003AasMap()
	{
		return _003Cbridge_003EasMap();
	}

	Collection Multimap.Multimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return this._003Cbridge_003EreplaceValues(P_0, P_1);
	}

	Collection Multimap.Multimap_003A_003AremoveAll(object P_0)
	{
		return this._003Cbridge_003EremoveAll(P_0);
	}

	Collection Multimap.Multimap_003A_003Aget(object P_0)
	{
		return this._003Cbridge_003Eget(P_0);
	}

	Set Multimap.Multimap_003A_003AkeySet()
	{
		return _003Cbridge_003EkeySet();
	}

	Multiset Multimap.Multimap_003A_003Akeys()
	{
		return _003Cbridge_003Ekeys();
	}

	Collection Multimap.Multimap_003A_003Avalues()
	{
		return _003Cbridge_003Evalues();
	}

	Collection Multimap.Multimap_003A_003Aentries()
	{
		return _003Cbridge_003Eentries();
	}

	Map Multimap.Multimap_003A_003AasMap()
	{
		return _003Cbridge_003EasMap();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableListMultimap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
