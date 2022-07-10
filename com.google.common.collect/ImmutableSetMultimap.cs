using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)139,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SetMultimap" })]
public class ImmutableSetMultimap : ImmutableMultimap, SetMultimap, Multimap
{
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
	public new sealed class Builder : ImmutableMultimap.Builder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 145, 105 })]
		public new virtual Builder put(object key, object value)
		{
			base.put(key, value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 200, 104 })]
		internal new virtual Builder combine(ImmutableMultimap.Builder P_0)
		{
			base.combine(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 237, 108, 104, 156 })]
		public new virtual ImmutableSetMultimap build()
		{
			object obj = builderMap.entrySet();
			if (keyComparator != null)
			{
				obj = Ordering.from(keyComparator).onKeys().immutableSortedCopy((Set)obj);
			}
			object obj2 = obj;
			Comparator comparator = valueComparator;
			ImmutableSetMultimap result = fromMapEntries((obj2 == null) ? null : ((obj2 as Collection) ?? throw new java.lang.IncompatibleClassChangeError()), comparator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 133, 104 })]
		public Builder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 170, 104 })]
		public new virtual Builder putAll(Iterable entries)
		{
			base.putAll(entries);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 177, 105 })]
		public new virtual Builder putAll(object key, Iterable values)
		{
			base.putAll(key, values);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 230, 104 })]
		public new virtual Builder orderValuesBy(Comparator valueComparator)
		{
			base.orderValuesBy(valueComparator);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TK;>;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 212, 104 })]
		public new virtual Builder orderKeysBy(Comparator keyComparator)
		{
			base.orderKeysBy(keyComparator);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 191, 127, 6, 120, 98 })]
		public new virtual Builder putAll(Multimap multimap)
		{
			Iterator iterator = multimap.asMap().entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				putAll(entry.getKey(), (Iterable)entry.getValue());
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;[TV;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(298)]
		public new virtual Builder putAll(object key, params object[] values)
		{
			Builder result = putAll(key, Arrays.asList(values));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 157, 104 })]
		public new virtual Builder put(Map.Entry entry)
		{
			base.put(entry);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(252)]
		internal override Collection newMutableValueCollection()
		{
			Set result = Platform.preservesInsertionOrderOnAddsSet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap _003Cbridge_003Ebuild()
		{
			ImmutableSetMultimap result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(241)]
		internal override ImmutableMultimap.Builder combine(ImmutableMultimap.Builder P_0)
		{
			Builder result = combine(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EorderValuesBy(Comparator c)
		{
			Builder result = orderValuesBy(c);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EorderKeysBy(Comparator c)
		{
			Builder result = orderKeysBy(c);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EputAll(Multimap m)
		{
			Builder result = putAll(m);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EputAll(object obj, object[] objarr)
		{
			Builder result = putAll(obj, objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EputAll(object obj, Iterable i)
		{
			Builder result = putAll(obj, i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003EputAll(Iterable i)
		{
			Builder result = putAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003Eput(Map.Entry me)
		{
			Builder result = put(me);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(241)]
		public virtual ImmutableMultimap.Builder _003Cbridge_003Eput(object obj1, object obj2)
		{
			Builder result = put(obj1, obj2);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal new sealed class EntrySet : ImmutableSet
	{
		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
		private ImmutableSetMultimap multimap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 160, 104, 103 })]
		internal EntrySet(ImmutableSetMultimap P_0)
		{
			multimap = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(550)]
		public override UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = multimap.entryIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 166, 104, 103, 154 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				bool result = multimap.containsEntry(entry.getKey(), entry.getValue());
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(545)]
		public override int size()
		{
			int result = multimap.size();
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(527)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static EntrySet()
		{
			ImmutableSet.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected EntrySet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class SetFieldSettersHolder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Serialization$FieldSetter<Lcom/google/common/collect/ImmutableSetMultimap;>;")]
		internal static Serialization.FieldSetter EMPTY_SET_FIELD_SETTER;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(598)]
		private SetFieldSettersHolder()
		{
		}

		[LineNumberTable(new byte[] { 161, 229, 106, 42 })]
		static SetFieldSettersHolder()
		{
			EMPTY_SET_FIELD_SETTER = Serialization.getFieldSetter(ClassLiteral<ImmutableSetMultimap>.Value, "emptySet");
		}
	}

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableSet<TV;>;")]
	private ImmutableSet m_emptySet;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSetMultimap<TV;TK;>;")]
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
	private new ImmutableSetMultimap m_inverse;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
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
	private new ImmutableSet m_entries;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSetMultimap$Builder<TK;TV;>;")]
	[LineNumberTable(219)]
	public new static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(373)]
	public new static ImmutableSetMultimap copyOf(Multimap multimap)
	{
		ImmutableSetMultimap result = copyOf(multimap, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(153)]
	public new static ImmutableSetMultimap of()
	{
		return EmptyImmutableSetMultimap.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableMap<TK;Lcom/google/common/collect/ImmutableSet<TV;>;>;ILjava/util/Comparator<-TV;>;)V")]
	[LineNumberTable(new byte[] { 161, 74, 106, 108 })]
	internal ImmutableSetMultimap(ImmutableMap P_0, int P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_2)
		: base(P_0, P_1)
	{
		this.m_emptySet = emptySet(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 9, 103, 107, 168, 136, 103, 104, 194 })]
	private static ImmutableSetMultimap copyOf(Multimap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_1)
	{
		Preconditions.checkNotNull(P_0);
		if (P_0.isEmpty() && P_1 == null)
		{
			ImmutableSetMultimap result = of();
			_ = null;
			return result;
		}
		if (P_0 is ImmutableSetMultimap)
		{
			ImmutableSetMultimap immutableSetMultimap = (ImmutableSetMultimap)P_0;
			if (!immutableSetMultimap.isPartialView())
			{
				return immutableSetMultimap;
			}
		}
		ImmutableSetMultimap result2 = fromMapEntries(P_0.asMap().entrySet(), P_1);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/Map$Entry<+TK;+Ljava/util/Collection<+TV;>;>;>;Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		161, 44, 104, 136, 97, 107, 130, 123, 104, 109,
		106, 105, 107, 138, 133
	})]
	internal static ImmutableSetMultimap fromMapEntries(Collection P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_1)
	{
		if (P_0.isEmpty())
		{
			ImmutableSetMultimap result = of();
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
			Collection collection = (Collection)entry.getValue();
			ImmutableSet immutableSet = valueSet(P_1, collection);
			if (!immutableSet.isEmpty())
			{
				builder.put(key, immutableSet);
				num += immutableSet.size();
			}
		}
		ImmutableSetMultimap result2 = new ImmutableSetMultimap(builder.buildOrThrow(), num, P_1);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/Comparator<-TV;>;Ljava/util/Collection<+TV;>;)Lcom/google/common/collect/ImmutableSet<TV;>;")]
	[LineNumberTable(new byte[] { 161, 191, 99, 104, 9 })]
	private static ImmutableSet valueSet([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_0, Collection P_1)
	{
		ImmutableSet result = ((P_0 != null) ? ImmutableSortedSet.copyOf(P_0, P_1) : ImmutableSet.copyOf(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableSet<TV;>;")]
	[LineNumberTable(new byte[] { 161, 197, 99, 103, 8 })]
	private static ImmutableSet emptySet([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_0)
	{
		ImmutableSet result = ((P_0 != null) ? ImmutableSortedSet.emptySet(P_0) : ImmutableSet.of());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSetMultimap<TV;TK;>;")]
	[LineNumberTable(new byte[] { 161, 108, 102, 127, 1, 115, 98, 103, 103 })]
	private ImmutableSetMultimap invert()
	{
		Builder builder = ImmutableSetMultimap.builder();
		UnmodifiableIterator unmodifiableIterator = entries().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Map.Entry entry = (Map.Entry)((Iterator)unmodifiableIterator).next();
			builder.put(entry.getValue(), entry.getKey());
		}
		ImmutableSetMultimap immutableSetMultimap = builder.build();
		immutableSetMultimap.m_inverse = this;
		return immutableSetMultimap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 161, 153, 103 })]
	public new virtual ImmutableSet entries()
	{
		ImmutableSet immutableSet = this.m_entries;
		object result;
		if (immutableSet == null)
		{
			EntrySet entrySet = new EntrySet(this);
			result = entrySet;
			this.m_entries = entrySet;
		}
		else
		{
			result = immutableSet;
		}
		return (ImmutableSet)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TV;>;")]
	[LineNumberTable(new byte[] { 161, 222, 109, 114, 1 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual Comparator valueComparator()
	{
		return (!(this.m_emptySet is ImmutableSortedSet)) ? null : ((ImmutableSortedSet)this.m_emptySet).comparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableSet$Builder<TV;>;")]
	[LineNumberTable(new byte[] { 161, 204, 99, 103, 8 })]
	private static ImmutableSet.Builder valuesBuilder([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_0)
	{
		ImmutableSet.Builder result = ((P_0 != null) ? new ImmutableSortedSet.Builder(P_0) : new ImmutableSet.Builder());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSetMultimap<TV;TK;>;")]
	[LineNumberTable(new byte[] { 161, 103, 103 })]
	public new virtual ImmutableSetMultimap inverse()
	{
		ImmutableSetMultimap immutableSetMultimap = this.m_inverse;
		ImmutableSetMultimap result;
		if (immutableSetMultimap == null)
		{
			ImmutableSetMultimap immutableSetMultimap2 = invert();
			result = immutableSetMultimap2;
			this.m_inverse = immutableSetMultimap2;
		}
		else
		{
			result = immutableSetMultimap;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Lcom/google/common/collect/ImmutableSet<TV;>;")]
	[LineNumberTable(new byte[] { 161, 88, 114 })]
	public new virtual ImmutableSet get(object key)
	{
		ImmutableSet first = (ImmutableSet)map.get(key);
		return (ImmutableSet)MoreObjects.firstNonNull(first, this.m_emptySet);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Lcom/google/common/collect/ImmutableSet<TV;>;")]
	[LineNumberTable(512)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new ImmutableSet replaceValues(object key, Iterable values)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSet<TV;>;")]
	[LineNumberTable(498)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new ImmutableSet removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 139, 0, 0 })]
	[LineNumberTable(95)]
	public static Collector toImmutableSetMultimap(java.util.function.Function keyFunction, java.util.function.Function valueFunction)
	{
		Collector result = CollectCollectors.toImmutableSetMultimap(keyFunction, valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+Ljava/util/stream/Stream<+TV;>;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 139, 0, 0 })]
	[LineNumberTable(142)]
	public static Collector flatteningToImmutableSetMultimap(java.util.function.Function keyFunction, java.util.function.Function valuesFunction)
	{
		Collector result = CollectCollectors.flatteningToImmutableSetMultimap(keyFunction, valuesFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 108, 102, 105 })]
	public new static ImmutableSetMultimap of(object k1, object v1)
	{
		Builder builder = ImmutableSetMultimap.builder();
		builder.put(k1, v1);
		ImmutableSetMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 118, 102, 105, 105 })]
	public new static ImmutableSetMultimap of(object k1, object v1, object k2, object v2)
	{
		Builder builder = ImmutableSetMultimap.builder();
		builder.put(k1, v1);
		builder.put(k2, v2);
		ImmutableSetMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 65, 102, 105, 105, 107 })]
	public new static ImmutableSetMultimap of(object k1, object v1, object k2, object v2, object k3, object v3)
	{
		Builder builder = ImmutableSetMultimap.builder();
		builder.put(k1, v1);
		builder.put(k2, v2);
		builder.put(k3, v3);
		ImmutableSetMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 78, 102, 105, 105, 107, 107 })]
	public new static ImmutableSetMultimap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4)
	{
		Builder builder = ImmutableSetMultimap.builder();
		builder.put(k1, v1);
		builder.put(k2, v2);
		builder.put(k3, v3);
		builder.put(k4, v4);
		ImmutableSetMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 92, 102, 105, 105, 107, 107, 107 })]
	public new static ImmutableSetMultimap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5)
	{
		Builder builder = ImmutableSetMultimap.builder();
		builder.put(k1, v1);
		builder.put(k2, v2);
		builder.put(k3, v3);
		builder.put(k4, v4);
		builder.put(k5, v5);
		ImmutableSetMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(407)]
	public new static ImmutableSetMultimap copyOf(Iterable entries)
	{
		ImmutableSetMultimap result = new Builder().putAll(entries).build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 161, 215, 102, 108, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeObject(valueComparator());
		Serialization.writeMultimap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		161, 237, 102, 108, 103, 100, 159, 12, 102, 131,
		107, 104, 104, 101, 191, 13, 104, 105, 46, 168,
		105, 107, 159, 35, 107, 231, 48, 235, 85, 188,
		2, 98, 190, 109, 109, 113
	})]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		Comparator comparator = (Comparator)P_0.readObject();
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
			object obj = P_0.readObject();
			int num4 = P_0.readInt();
			if (num4 <= 0)
			{
				int num2 = 31;
				num2 = num2;
				string reason2 = new StringBuilder(num2).append("Invalid value count ").append(num4).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new InvalidObjectException(reason2);
			}
			ImmutableSet.Builder builder2 = valuesBuilder(comparator);
			for (int j = 0; j < num4; j++)
			{
				builder2.add(P_0.readObject());
			}
			ImmutableSet immutableSet = builder2.build();
			if (immutableSet.size() != num4)
			{
				string text = java.lang.String.valueOf(obj);
				int num2 = 40 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num2 = num2;
				string reason3 = new StringBuilder(num2).append("Duplicate key-value pairs exist for key ").append(text).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new InvalidObjectException(reason3);
			}
			builder.put(obj, immutableSet);
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
			goto IL_014f;
		}
		FieldSettersHolder.MAP_FIELD_SETTER.set(this, immutableMap);
		FieldSettersHolder.SIZE_FIELD_SETTER.set(this, num3);
		SetFieldSettersHolder.EMPTY_SET_FIELD_SETTER.set(this, emptySet(comparator));
		return;
		IL_014f:
		IllegalArgumentException ex2 = ex;
		throw Throwable.___003Cunmap_003E((InvalidObjectException)Throwable.instancehelper_initCause(new InvalidObjectException(Throwable.instancehelper_getMessage(ex2)), ex2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	public new virtual ImmutableCollection _003Cbridge_003Eentries()
	{
		ImmutableSet result = entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	public virtual ImmutableMultimap _003Cbridge_003Einverse()
	{
		ImmutableSetMultimap result = inverse();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	public new virtual ImmutableCollection _003Cbridge_003Eget(object obj)
	{
		ImmutableSet result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual ImmutableCollection _003Cbridge_003EreplaceValues(object obj, Iterable i)
	{
		ImmutableSet result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
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
		ImmutableSet result = removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	public override Collection _003Cbridge_003Eentries()
	{
		ImmutableSet result = entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override Collection _003Cbridge_003EreplaceValues(object obj, Iterable i)
	{
		ImmutableSet result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	public override Collection _003Cbridge_003Eget(object obj)
	{
		ImmutableSet result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
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
		ImmutableSet result = removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	public new virtual Set _003Cbridge_003Eentries()
	{
		ImmutableSet result = entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual Set _003Cbridge_003EreplaceValues(object obj, Iterable i)
	{
		ImmutableSet result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual Set _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		ImmutableSet result = removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	public new virtual Set _003Cbridge_003Eget(object obj)
	{
		ImmutableSet result = get(obj);
		_ = null;
		return result;
	}

	Set SetMultimap.SetMultimap_003A_003Aget(object P_0)
	{
		return this._003Cbridge_003Eget(P_0);
	}

	Set SetMultimap.SetMultimap_003A_003AremoveAll(object P_0)
	{
		return this._003Cbridge_003EremoveAll(P_0);
	}

	Set SetMultimap.SetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return this._003Cbridge_003EreplaceValues(P_0, P_1);
	}

	Set SetMultimap.SetMultimap_003A_003Aentries()
	{
		return this._003Cbridge_003Eentries();
	}

	Map SetMultimap.SetMultimap_003A_003AasMap()
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
		return this._003Cbridge_003Eentries();
	}

	Map Multimap.Multimap_003A_003AasMap()
	{
		return _003Cbridge_003EasMap();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableSetMultimap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
