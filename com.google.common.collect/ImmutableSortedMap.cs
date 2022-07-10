using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSortedMapFauxverideShim<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)154,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.NavigableMap" })]
public sealed class ImmutableSortedMap : ImmutableSortedMapFauxverideShim, NavigableMap, SortedMap, Map
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/util/Comparator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "fromEntries", "(Ljava.util.Comparator;Z[Ljava.util.Map$Entry;I)Lcom.google.common.collect.ImmutableSortedMap;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 16, 0, 0, 1, 3, 0, 0, 38,
		0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)38,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal new class _1 : java.lang.Object, Comparator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Comparator val_0024comparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV;>;Ljava/util/Map$Entry<TK;TV;>;)I")]
		[LineNumberTable(new byte[] { 161, 172, 103, 103 })]
		public virtual int compare([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Map.Entry P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Map.Entry P_1)
		{
			java.util.Objects.requireNonNull(P_0);
			java.util.Objects.requireNonNull(P_1);
			int result = val_0024comparator.compare(P_0.getKey(), P_1.getKey());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(538)]
		internal _1(Comparator P_0)
		{
			val_0024comparator = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(538)]
		public virtual int compare([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			int result = compare((Map.Entry)P_0, (Map.Entry)P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(java.util.function.Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(java.util.function.Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}

		bool Comparator.Comparator_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}
	}

	[Serializable]
	[SpecialName]
	[Signature("Lcom/google/common/collect/ImmutableMapEntrySet<TK;TV;>;")]
	[EnclosingMethod(null, "createEntrySet", "()Lcom.google.common.collect.ImmutableSet;")]
	internal class _1EntrySet : ImmutableMapEntrySet
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/ImmutableAsList<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[EnclosingMethod(null, "createAsList", "()Lcom.google.common.collect.ImmutableList;")]
		internal class _1 : ImmutableAsList
		{
			[SpecialName]
			private sealed class ___003C_003EAnon0 : IntFunction
			{
				private readonly _1EntrySet._1 arg_00241;

				internal ___003C_003EAnon0(_1EntrySet._1 P_0)
				{
					arg_00241 = P_0;
				}

				public object apply(int P_0)
				{
					Map.Entry result = arg_00241.get(P_0);
					_ = null;
					return result;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _1EntrySet this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(I)Ljava/util/Map$Entry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 162, 212, 107, 63, 14 })]
			public new virtual Map.Entry get(int P_0)
			{
				AbstractMap.SimpleImmutableEntry result = new AbstractMap.SimpleImmutableEntry(access_0024200(this_00241.this_00240).asList().get(P_0), access_0024300(this_00241.this_00240).get(P_0));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(835)]
			internal _1(_1EntrySet P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(new byte[] { 162, 218, 97, 53 })]
			public override Spliterator spliterator()
			{
				Spliterator result = CollectSpliterators.indexed(size(), 1297, new ___003C_003EAnon0(this));
				_ = null;
				return result;
			}

			[Signature("()Lcom/google/common/collect/ImmutableCollection<Ljava/util/Map$Entry<TK;TV;>;>;")]
			internal override ImmutableCollection delegateCollection()
			{
				return this_00241;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(835)]
			public override object get(int P_0)
			{
				Map.Entry result = get(P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				ImmutableAsList.___003Cclinit_003E();
			}

			[HideFromJava]
			[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
			protected _1(SerializationInfo P_0, StreamingContext P_1)
				: base(P_0, P_1)
			{
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableSortedMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(817)]
		internal _1EntrySet(ImmutableSortedMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(820)]
		public override UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = asList().iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(825)]
		public override Spliterator spliterator()
		{
			Spliterator result = asList().spliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 162, 204, 110 })]
		public override void forEach(Consumer P_0)
		{
			asList().forEach(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(835)]
		internal override ImmutableList createAsList()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[Signature("()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		internal override ImmutableMap map()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(817)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static _1EntrySet()
		{
			ImmutableMapEntrySet.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _1EntrySet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
	public new class Builder : ImmutableMap.Builder
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TK;>;")]
		private Comparator comparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 162, 15, 105 })]
		public new virtual Builder put(object key, object value)
		{
			base.put(key, value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TK;>;)V")]
		[LineNumberTable(new byte[] { 162, 3, 104, 113 })]
		public Builder(Comparator comparator)
		{
			this.comparator = (Comparator)Preconditions.checkNotNull(comparator);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 162, 80, 104 })]
		internal new virtual Builder combine(ImmutableMap.Builder P_0)
		{
			base.combine(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
		[LineNumberTable(722)]
		public new virtual ImmutableSortedMap build()
		{
			ImmutableSortedMap result = buildOrThrow();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 162, 109, 151, 174, 115, 154 })]
		public new virtual ImmutableSortedMap buildOrThrow()
		{
			switch (size)
			{
			case 0:
			{
				ImmutableSortedMap result3 = emptyMap(comparator);
				_ = null;
				return result3;
			}
			case 1:
			{
				Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull(entries[0]);
				ImmutableSortedMap result2 = access_0024000(comparator, entry.getKey(), entry.getValue());
				_ = null;
				return result2;
			}
			default:
			{
				ImmutableSortedMap result = access_0024100(comparator, false, entries, size);
				_ = null;
				return result;
			}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[Signature("()Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
		[LineNumberTable(761)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public new ImmutableSortedMap buildKeepingLast()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("ImmutableSortedMap.Builder does not yet implement buildKeepingLast()");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[Signature("(Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
		[LineNumberTable(701)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public new Builder orderEntriesByValue(Comparator valueComparator)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("Not available on ImmutableSortedMap.Builder");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 162, 59, 104 })]
		public new virtual Builder putAll(Iterable entries)
		{
			base.putAll(entries);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 162, 43, 104 })]
		public new virtual Builder putAll(Map map)
		{
			base.putAll(map);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 162, 29, 104 })]
		public new virtual Builder put(Map.Entry entry)
		{
			base.put(entry);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(621)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public virtual ImmutableMap _003Cbridge_003EbuildKeepingLast()
		{
			ImmutableSortedMap result = buildKeepingLast();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(621)]
		public virtual ImmutableMap _003Cbridge_003EbuildOrThrow()
		{
			ImmutableSortedMap result = buildOrThrow();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(621)]
		public virtual ImmutableMap _003Cbridge_003Ebuild()
		{
			ImmutableSortedMap result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(621)]
		internal override ImmutableMap.Builder combine(ImmutableMap.Builder P_0)
		{
			Builder result = combine(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(621)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public virtual ImmutableMap.Builder _003Cbridge_003EorderEntriesByValue(Comparator c)
		{
			Builder result = orderEntriesByValue(c);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(621)]
		public virtual ImmutableMap.Builder _003Cbridge_003EputAll(Iterable i)
		{
			Builder result = putAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(621)]
		public virtual ImmutableMap.Builder _003Cbridge_003EputAll(Map m)
		{
			Builder result = putAll(m);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(621)]
		public virtual ImmutableMap.Builder _003Cbridge_003Eput(Map.Entry me)
		{
			Builder result = put(me);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(621)]
		public virtual ImmutableMap.Builder _003Cbridge_003Eput(object obj1, object obj2)
		{
			Builder result = put(obj1, obj2);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMap$SerializedForm<TK;TV;>;")]
	internal new class SerializedForm : ImmutableMap.SerializedForm
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TK;>;")]
		private Comparator comparator;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 164, 8, 105, 108 })]
		internal SerializedForm(ImmutableSortedMap P_0)
			: base(P_0)
		{
			comparator = P_0.comparator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
		[LineNumberTable(1152)]
		internal new virtual Builder makeBuilder(int P_0)
		{
			Builder result = new Builder(comparator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1142)]
		internal override ImmutableMap.Builder makeBuilder(int P_0)
		{
			Builder result = makeBuilder(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/Comparator<Ljava/lang/Comparable;>;")]
	private static Comparator NATURAL_ORDER;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableSortedMap<Ljava/lang/Comparable;Ljava/lang/Object;>;")]
	private static ImmutableSortedMap NATURAL_EMPTY_MAP;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/RegularImmutableSortedSet<TK;>;")]
	private new RegularImmutableSortedSet m_keySet;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableList<TV;>;")]
	private ImmutableList valueList;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ImmutableSortedMap m_descendingMap;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;+TV;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 73, 103, 163, 134, 200, 103, 104, 162 })]
	public static ImmutableSortedMap copyOfSorted(SortedMap map)
	{
		Comparator comparator = map.comparator();
		if (comparator == null)
		{
			comparator = NATURAL_ORDER;
		}
		if (map is ImmutableSortedMap)
		{
			ImmutableSortedMap immutableSortedMap = (ImmutableSortedMap)map;
			if (!immutableSortedMap.isPartialView())
			{
				return immutableSortedMap;
			}
		}
		ImmutableSortedMap result = fromEntries(comparator, true, map.entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RegularImmutableSortedSet<TK;>;Lcom/google/common/collect/ImmutableList<TV;>;)V")]
	[LineNumberTable(new byte[] { 162, 145, 107 })]
	internal ImmutableSortedMap(RegularImmutableSortedSet P_0, ImmutableList P_1)
		: this(P_0, P_1, null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;Z[Ljava/util/Map$Entry<TK;TV;>;I)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 154, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		159, 15, 98, 146, 169, 110, 149, 103, 103, 131,
		136, 112, 105, 105, 105, 102, 230, 57, 237, 77,
		238, 78, 111, 105, 101, 106, 107, 139, 114, 112,
		105, 105, 105, 102, 102, 126, 228, 54, 235, 77
	})]
	private static ImmutableSortedMap fromEntries(Comparator P_0, bool P_1, Map.Entry[] P_2, int P_3)
	{
		switch (P_3)
		{
		case 0:
		{
			ImmutableSortedMap result2 = emptyMap(P_0);
			_ = null;
			return result2;
		}
		case 1:
		{
			Map.Entry entry5 = (Map.Entry)java.util.Objects.requireNonNull(P_2[0]);
			ImmutableSortedMap result3 = of(P_0, entry5.getKey(), entry5.getValue());
			_ = null;
			return result3;
		}
		default:
		{
			object[] array = new object[P_3];
			object[] array2 = new object[P_3];
			if (P_1)
			{
				for (int i = 0; i < P_3; i++)
				{
					Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull(P_2[i]);
					object key = entry.getKey();
					object value = entry.getValue();
					CollectPreconditions.checkEntryNotNull(key, value);
					array[i] = key;
					array2[i] = value;
				}
			}
			else
			{
				Arrays.sort(P_2, 0, P_3, new _1(P_0));
				Map.Entry entry2 = (Map.Entry)java.util.Objects.requireNonNull(P_2[0]);
				object o = (array[0] = entry2.getKey());
				array2[0] = entry2.getValue();
				CollectPreconditions.checkEntryNotNull(array[0], array2[0]);
				for (int j = 1; j < P_3; j++)
				{
					Map.Entry entry3 = (Map.Entry)java.util.Objects.requireNonNull(P_2[j - 1]);
					Map.Entry entry4 = (Map.Entry)java.util.Objects.requireNonNull(P_2[j]);
					object key2 = entry4.getKey();
					object value2 = entry4.getValue();
					CollectPreconditions.checkEntryNotNull(key2, value2);
					array[j] = key2;
					array2[j] = value2;
					ImmutableMap.checkNoConflict((P_0.compare(o, key2) != 0) ? true : false, "key", entry3, entry4);
					o = key2;
				}
			}
			RegularImmutableSortedSet.___003Cclinit_003E();
			ImmutableSortedMap result = new ImmutableSortedMap(new RegularImmutableSortedSet(new RegularImmutableList(array), P_0), new RegularImmutableList(array2));
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 96, 102, 118, 12 })]
	private static ImmutableSortedMap of(Comparator P_0, object P_1, object P_2)
	{
		RegularImmutableSortedSet.___003Cclinit_003E();
		ImmutableSortedMap result = new ImmutableSortedMap(new RegularImmutableSortedSet(ImmutableList.of(P_1), (Comparator)Preconditions.checkNotNull(P_0)), ImmutableList.of(P_2));
		_ = null;
		return result;
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	public new static ImmutableSortedMap of()
	{
		return NATURAL_EMPTY_MAP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>([Ljava/util/Map$Entry<TK;TV;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(485)]
	private static ImmutableSortedMap fromEntries(params Map.Entry[] P_0)
	{
		ImmutableSortedMap result = fromEntries(Ordering.natural(), false, P_0, P_0.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;Ljava/util/Comparator<-TK;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		161, 93, 98, 104, 103, 135, 185, 203, 103, 104,
		162
	})]
	private static ImmutableSortedMap copyOfInternal(Map P_0, Comparator P_1)
	{
		int num = 0;
		if (P_0 is SortedMap)
		{
			SortedMap sortedMap = (SortedMap)P_0;
			Comparator comparator = sortedMap.comparator();
			num = ((comparator != null) ? (P_1.equals(comparator) ? 1 : 0) : ((P_1 == NATURAL_ORDER) ? 1 : 0));
		}
		if (num != 0 && P_0 is ImmutableSortedMap)
		{
			ImmutableSortedMap immutableSortedMap = (ImmutableSortedMap)P_0;
			if (!immutableSortedMap.isPartialView())
			{
				return immutableSortedMap;
			}
		}
		ImmutableSortedMap result = fromEntries(P_1, (byte)num != 0, P_0.entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;Ljava/util/Comparator<-TK;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(428)]
	public static ImmutableSortedMap copyOf(Iterable entries, Comparator comparator)
	{
		ImmutableSortedMap result = fromEntries((Comparator)Preconditions.checkNotNull(comparator), false, entries);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;ZLjava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 159, 17, 66, 113 })]
	private static ImmutableSortedMap fromEntries(Comparator P_0, bool P_1, Iterable P_2)
	{
		Map.Entry[] array = (Map.Entry[])Iterables.toArray(P_2, ImmutableMap.EMPTY_ENTRY_ARRAY);
		ImmutableSortedMap result = fromEntries(P_0, P_1, array, array.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(806)]
	internal override bool isPartialView()
	{
		return (this.m_keySet.isPartialView() || valueList.isPartialView()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 69, 109, 136, 97, 49 })]
	internal static ImmutableSortedMap emptyMap(Comparator P_0)
	{
		if (java.lang.Object.instancehelper_equals(Ordering.natural(), P_0))
		{
			ImmutableSortedMap result = of();
			_ = null;
			return result;
		}
		ImmutableSortedMap result2 = new ImmutableSortedMap(ImmutableSortedSet.emptySet(P_0), ImmutableList.of());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RegularImmutableSortedSet<TK;>;Lcom/google/common/collect/ImmutableList<TV;>;Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 162, 151, 104, 103, 103, 103 })]
	internal ImmutableSortedMap(RegularImmutableSortedSet P_0, ImmutableList P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableSortedMap P_2)
	{
		this.m_keySet = P_0;
		valueList = P_1;
		this.m_descendingMap = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(785)]
	public override int size()
	{
		int result = valueList.size();
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TK;>;")]
	public new virtual ImmutableSortedSet keySet()
	{
		return this.m_keySet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TK;>;")]
	[LineNumberTable(895)]
	public virtual Comparator comparator()
	{
		Comparator result = keySet().comparator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Z)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(946)]
	public virtual ImmutableSortedMap headMap(object toKey, bool inclusive)
	{
		ImmutableSortedMap result = getSubMap(0, this.m_keySet.headIndex(Preconditions.checkNotNull(toKey), inclusive));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 163, 27, 108, 98, 100, 142, 104, 57 })]
	private ImmutableSortedMap getSubMap(int P_0, int P_1)
	{
		if (P_0 == 0 && P_1 == size())
		{
			return this;
		}
		if (P_0 == P_1)
		{
			ImmutableSortedMap result = emptyMap(comparator());
			_ = null;
			return result;
		}
		ImmutableSortedMap result2 = new ImmutableSortedMap(this.m_keySet.getSubSet(P_0, P_1), valueList.subList(P_0, P_1));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;ZTK;Z)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 158, 153, 69, 103, 103, 97, 57, 229, 69 })]
	public virtual ImmutableSortedMap subMap(object fromKey, bool fromInclusive, object toKey, bool toInclusive)
	{
		Preconditions.checkNotNull(fromKey);
		Preconditions.checkNotNull(toKey);
		Preconditions.checkArgument(comparator().compare(fromKey, toKey) <= 0, "expected fromKey <= toKey but %s > %s", fromKey, toKey);
		ImmutableSortedMap result = headMap(toKey, toInclusive).tailMap(fromKey, fromInclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Z)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(1017)]
	public virtual ImmutableSortedMap tailMap(object fromKey, bool inclusive)
	{
		ImmutableSortedMap result = getSubMap(this.m_keySet.tailIndex(Preconditions.checkNotNull(fromKey), inclusive), size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(1077)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry lastEntry()
	{
		return (!base.isEmpty()) ? ((Map.Entry)entrySet().asList().get(size() - 1)) : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(1023)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry lowerEntry(object key)
	{
		Map.Entry result = headMap(key, inclusive: false).lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(1035)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry floorEntry(object key)
	{
		Map.Entry result = headMap(key, inclusive: true).lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(1071)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry firstEntry()
	{
		return (!base.isEmpty()) ? ((Map.Entry)entrySet().asList().get(0)) : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(1047)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry ceilingEntry(object key)
	{
		Map.Entry result = tailMap(key, inclusive: true).firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(1059)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry higherEntry(object key)
	{
		Map.Entry result = tailMap(key, inclusive: false).firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(812)]
	public override ImmutableSet entrySet()
	{
		ImmutableSet result = base.entrySet();
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	public override ImmutableCollection values()
	{
		return valueList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(1001)]
	public virtual ImmutableSortedMap tailMap(object fromKey)
	{
		ImmutableSortedMap result = tailMap(fromKey, inclusive: true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(930)]
	public virtual ImmutableSortedMap headMap(object toKey)
	{
		ImmutableSortedMap result = headMap(toKey, inclusive: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TK;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(961)]
	public virtual ImmutableSortedMap subMap(object fromKey, object toKey)
	{
		ImmutableSortedMap result = subMap(fromKey, fromInclusive: true, toKey, toInclusive: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TK;>;")]
	[LineNumberTable(1134)]
	public virtual ImmutableSortedSet descendingKeySet()
	{
		ImmutableSortedSet result = this.m_keySet.descendingSet();
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TK;>;")]
	public virtual ImmutableSortedSet navigableKeySet()
	{
		return this.m_keySet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 163, 232, 103, 99, 104, 152, 134, 29, 225, 69 })]
	public virtual ImmutableSortedMap descendingMap()
	{
		ImmutableSortedMap immutableSortedMap = this.m_descendingMap;
		if (immutableSortedMap == null)
		{
			if (base.isEmpty())
			{
				return emptyMap(Ordering.from(comparator()).reverse());
			}
			return new ImmutableSortedMap((RegularImmutableSortedSet)this.m_keySet.descendingSet(), valueList.reverse(), this);
		}
		return immutableSortedMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 154, 0, 0 })]
	[LineNumberTable(84)]
	public static Collector toImmutableSortedMap(Comparator comparator, java.util.function.Function keyFunction, java.util.function.Function valueFunction)
	{
		Collector result = CollectCollectors.toImmutableSortedMap(comparator, keyFunction, valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 154, 0, 0 })]
	[LineNumberTable(104)]
	public static Collector toImmutableSortedMap(Comparator comparator, java.util.function.Function keyFunction, java.util.function.Function valueFunction, BinaryOperator mergeFunction)
	{
		Collector result = CollectCollectors.toImmutableSortedMap(comparator, keyFunction, valueFunction, mergeFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(141)]
	public static ImmutableSortedMap of(IComparable k1, object v1)
	{
		ImmutableSortedMap result = of(Ordering.natural(), k1, v1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(160)]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(172)]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2, IComparable k3, object v3)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(184)]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2, IComparable k3, object v3, IComparable k4, object v4)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 82, 106, 63, 21 })]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2, IComparable k3, object v3, IComparable k4, object v4, IComparable k5, object v5)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 96, 106, 106, 108, 108, 108, 108, 230, 58 })]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2, IComparable k3, object v3, IComparable k4, object v4, IComparable k5, object v5, IComparable k6, object v6)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 115, 106, 106, 108, 108, 108, 108, 108, 230,
		57
	})]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2, IComparable k3, object v3, IComparable k4, object v4, IComparable k5, object v5, IComparable k6, object v6, IComparable k7, object v7)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6), ImmutableMap.entryOf(k7, v7));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 150, 106, 106, 108, 108, 108, 108, 108, 108,
		230, 56
	})]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2, IComparable k3, object v3, IComparable k4, object v4, IComparable k5, object v5, IComparable k6, object v6, IComparable k7, object v7, IComparable k8, object v8)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6), ImmutableMap.entryOf(k7, v7), ImmutableMap.entryOf(k8, v8));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 188, 107, 106, 108, 108, 108, 108, 108, 108,
		108, 230, 55
	})]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2, IComparable k3, object v3, IComparable k4, object v4, IComparable k5, object v5, IComparable k6, object v6, IComparable k7, object v7, IComparable k8, object v8, IComparable k9, object v9)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6), ImmutableMap.entryOf(k7, v7), ImmutableMap.entryOf(k8, v8), ImmutableMap.entryOf(k9, v9));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 229, 107, 106, 108, 108, 108, 108, 108, 108,
		108, 109, 230, 54
	})]
	public static ImmutableSortedMap of(IComparable k1, object v1, IComparable k2, object v2, IComparable k3, object v3, IComparable k4, object v4, IComparable k5, object v5, IComparable k6, object v6, IComparable k7, object v7, IComparable k8, object v8, IComparable k9, object v9, IComparable k10, object v10)
	{
		ImmutableSortedMap result = fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6), ImmutableMap.entryOf(k7, v7), ImmutableMap.entryOf(k8, v8), ImmutableMap.entryOf(k9, v9), ImmutableMap.entryOf(k10, v10));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 5, 107 })]
	public new static ImmutableSortedMap copyOf(Map map)
	{
		Ordering ordering = (Ordering)NATURAL_ORDER;
		ImmutableSortedMap result = copyOfInternal(map, ordering);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;Ljava/util/Comparator<-TK;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(392)]
	public static ImmutableSortedMap copyOf(Map map, Comparator comparator)
	{
		ImmutableSortedMap result = copyOfInternal(map, (Comparator)Preconditions.checkNotNull(comparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 42, 107 })]
	public new static ImmutableSortedMap copyOf(Iterable entries)
	{
		Ordering ordering = (Ordering)NATURAL_ORDER;
		ImmutableSortedMap result = copyOf(entries, ordering);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
	[LineNumberTable(577)]
	public static Builder naturalOrder()
	{
		Builder result = new Builder(Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<TK;>;)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
	[LineNumberTable(589)]
	public static Builder orderedBy(Comparator comparator)
	{
		Builder result = new Builder(comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
	[LineNumberTable(597)]
	public static Builder reverseOrder()
	{
		Builder result = new Builder(Ordering.natural().reverse());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 162, 164, 103, 108, 107, 57, 166 })]
	public override void forEach(BiConsumer action)
	{
		Preconditions.checkNotNull(action);
		ImmutableList immutableList = this.m_keySet.asList();
		for (int i = 0; i < size(); i++)
		{
			action.accept(immutableList.get(i), valueList.get(i));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 162, 174, 109 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		int num = this.m_keySet.indexOf(key);
		object result = ((num != -1) ? valueList.get(num) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(860)]
	internal override ImmutableSet createEntrySet()
	{
		ImmutableSet result = ((!base.isEmpty()) ? new _1EntrySet(this) : ImmutableSet.of());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	[LineNumberTable(871)]
	internal override ImmutableSet createKeySet()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(885)]
	internal override ImmutableCollection createValues()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(900)]
	public virtual object firstKey()
	{
		object result = keySet().first();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(905)]
	public virtual object lastKey()
	{
		object result = keySet().last();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(1029)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object lowerKey(object key)
	{
		object result = Maps.keyOrNull(lowerEntry(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(1041)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object floorKey(object key)
	{
		object result = Maps.keyOrNull(floorEntry(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(1053)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object ceilingKey(object key)
	{
		object result = Maps.keyOrNull(ceilingEntry(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(1065)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object higherKey(object key)
	{
		object result = Maps.keyOrNull(higherEntry(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(1092)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public Map.Entry pollFirstEntry()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(1107)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public Map.Entry pollLastEntry()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1160)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public new virtual ImmutableSet _003Cbridge_003EkeySet()
	{
		ImmutableSortedSet result = keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public override Set _003Cbridge_003EentrySet()
	{
		ImmutableSet result = entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public override Collection _003Cbridge_003Evalues()
	{
		ImmutableCollection result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public override Set _003Cbridge_003EkeySet()
	{
		ImmutableSortedSet result = keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual SortedMap _003Cbridge_003EtailMap(object obj)
	{
		ImmutableSortedMap result = tailMap(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual SortedMap _003Cbridge_003EheadMap(object obj)
	{
		ImmutableSortedMap result = headMap(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual SortedMap _003Cbridge_003EsubMap(object obj1, object obj2)
	{
		ImmutableSortedMap result = subMap(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableMap _003Cbridge_003EtailMap(object obj, bool b)
	{
		ImmutableSortedMap result = tailMap(obj, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableMap _003Cbridge_003EheadMap(object obj, bool b)
	{
		ImmutableSortedMap result = headMap(obj, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableMap _003Cbridge_003EsubMap(object obj1, bool b1, object obj2, bool b2)
	{
		ImmutableSortedMap result = subMap(obj1, b1, obj2, b2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableSet _003Cbridge_003EdescendingKeySet()
	{
		ImmutableSortedSet result = descendingKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableSet _003Cbridge_003EnavigableKeySet()
	{
		ImmutableSortedSet result = navigableKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableMap _003Cbridge_003EdescendingMap()
	{
		ImmutableSortedMap result = descendingMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(65)]
	internal static ImmutableSortedMap access_0024000(Comparator P_0, object P_1, object P_2)
	{
		ImmutableSortedMap result = of(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(65)]
	internal static ImmutableSortedMap access_0024100(Comparator P_0, bool P_1, Map.Entry[] P_2, int P_3)
	{
		ImmutableSortedMap result = fromEntries(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(65)]
	internal static RegularImmutableSortedSet access_0024200(ImmutableSortedMap P_0)
	{
		return P_0.m_keySet;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(65)]
	internal static ImmutableList access_0024300(ImmutableSortedMap P_0)
	{
		return P_0.valueList;
	}

	[LineNumberTable(new byte[] { 159, 114, 69, 202, 25 })]
	static ImmutableSortedMap()
	{
		ImmutableSortedMapFauxverideShim.___003Cclinit_003E();
		NATURAL_ORDER = Ordering.natural();
		NATURAL_EMPTY_MAP = new ImmutableSortedMap(ImmutableSortedSet.emptySet(Ordering.natural()), ImmutableList.of());
	}

	NavigableMap NavigableMap.NavigableMap_003A_003AdescendingMap()
	{
		return _003Cbridge_003EdescendingMap();
	}

	NavigableSet NavigableMap.NavigableMap_003A_003AnavigableKeySet()
	{
		return _003Cbridge_003EnavigableKeySet();
	}

	NavigableSet NavigableMap.NavigableMap_003A_003AdescendingKeySet()
	{
		return _003Cbridge_003EdescendingKeySet();
	}

	NavigableMap NavigableMap.NavigableMap_003A_003AsubMap(object P_0, bool P_1, object P_2, bool P_3)
	{
		return _003Cbridge_003EsubMap(P_0, P_1, P_2, P_3);
	}

	NavigableMap NavigableMap.NavigableMap_003A_003AheadMap(object P_0, bool P_1)
	{
		return _003Cbridge_003EheadMap(P_0, P_1);
	}

	NavigableMap NavigableMap.NavigableMap_003A_003AtailMap(object P_0, bool P_1)
	{
		return _003Cbridge_003EtailMap(P_0, P_1);
	}

	SortedMap NavigableMap.NavigableMap_003A_003AsubMap(object P_0, object P_1)
	{
		return _003Cbridge_003EsubMap(P_0, P_1);
	}

	SortedMap NavigableMap.NavigableMap_003A_003AheadMap(object P_0)
	{
		return _003Cbridge_003EheadMap(P_0);
	}

	SortedMap NavigableMap.NavigableMap_003A_003AtailMap(object P_0)
	{
		return _003Cbridge_003EtailMap(P_0);
	}

	SortedMap SortedMap.SortedMap_003A_003AsubMap(object P_0, object P_1)
	{
		return _003Cbridge_003EsubMap(P_0, P_1);
	}

	SortedMap SortedMap.SortedMap_003A_003AheadMap(object P_0)
	{
		return _003Cbridge_003EheadMap(P_0);
	}

	SortedMap SortedMap.SortedMap_003A_003AtailMap(object P_0)
	{
		return _003Cbridge_003EtailMap(P_0);
	}

	Set SortedMap.SortedMap_003A_003AkeySet()
	{
		return this._003Cbridge_003EkeySet();
	}

	Collection SortedMap.SortedMap_003A_003Avalues()
	{
		return _003Cbridge_003Evalues();
	}

	Set SortedMap.SortedMap_003A_003AentrySet()
	{
		return _003Cbridge_003EentrySet();
	}

	Set Map.Map_003A_003AkeySet()
	{
		return this._003Cbridge_003EkeySet();
	}

	Set Map.Map_003A_003AentrySet()
	{
		return _003Cbridge_003EentrySet();
	}

	Collection Map.Map_003A_003Avalues()
	{
		return _003Cbridge_003Evalues();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableSortedMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|toImmutableMap", "(Ljava.util.function.Function;Ljava.util.function.Function;)Ljava.util.stream.Collector;")]
	public new static Collector toImmutableMap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		return ImmutableSortedMapFauxverideShim.toImmutableMap(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|toImmutableMap", "(Ljava.util.function.Function;Ljava.util.function.Function;Ljava.util.function.BinaryOperator;)Ljava.util.stream.Collector;")]
	public new static Collector toImmutableMap(java.util.function.Function P_0, java.util.function.Function P_1, BinaryOperator P_2)
	{
		return ImmutableSortedMapFauxverideShim.toImmutableMap(P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|builder", "()Lcom.google.common.collect.ImmutableSortedMap$Builder;")]
	public new static Builder builder()
	{
		return ImmutableSortedMapFauxverideShim.builder();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|builderWithExpectedSize", "(I)Lcom.google.common.collect.ImmutableSortedMap$Builder;")]
	public new static Builder builderWithExpectedSize(int P_0)
	{
		return ImmutableSortedMapFauxverideShim.builderWithExpectedSize(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|of", "(Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>6|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>7|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>8|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>9|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9, P_10, P_11);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>10|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11, object P_12, object P_13)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9, P_10, P_11, P_12, P_13);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>11|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11, object P_12, object P_13, object P_14, object P_15)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9, P_10, P_11, P_12, P_13, P_14, P_15);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>12|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11, object P_12, object P_13, object P_14, object P_15, object P_16, object P_17)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9, P_10, P_11, P_12, P_13, P_14, P_15, P_16, P_17);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>13|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11, object P_12, object P_13, object P_14, object P_15, object P_16, object P_17, object P_18, object P_19)
	{
		return ImmutableSortedMapFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6, P_7, P_8, P_9, P_10, P_11, P_12, P_13, P_14, P_15, P_16, P_17, P_18, P_19);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>14|ofEntries", "([Ljava.util.Map$Entry;)Lcom.google.common.collect.ImmutableSortedMap;")]
	public static ImmutableSortedMap ofEntries(Map.Entry[] P_0)
	{
		return ImmutableSortedMapFauxverideShim.ofEntries(P_0);
	}
}
