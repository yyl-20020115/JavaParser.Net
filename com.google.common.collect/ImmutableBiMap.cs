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
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableBiMapFauxverideShim<TK;TV;>;Lcom/google/common/collect/BiMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)55,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.BiMap" })]
public abstract class ImmutableBiMap : ImmutableBiMapFauxverideShim, BiMap, Map
{
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
	public new sealed class Builder : ImmutableMap.Builder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 242, 105 })]
		public new virtual Builder put(object key, object value)
		{
			base.put(key, value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(343)]
		public Builder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;)Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 52, 104 })]
		internal new virtual Builder combine(ImmutableMap.Builder P_0)
		{
			base.combine(P_0);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
		[LineNumberTable(439)]
		public new virtual ImmutableBiMap build()
		{
			ImmutableBiMap result = buildOrThrow();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
		[LineNumberTable(new byte[]
		{
			161, 83, 151, 168, 115, 244, 73, 104, 104, 156,
			211, 239, 60, 229, 70, 103
		})]
		public new virtual ImmutableBiMap buildOrThrow()
		{
			switch (size)
			{
			case 0:
			{
				ImmutableBiMap result3 = of();
				_ = null;
				return result3;
			}
			case 1:
			{
				Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull(entries[0]);
				ImmutableBiMap result2 = of(entry.getKey(), entry.getValue());
				_ = null;
				return result2;
			}
			default:
			{
				if (valueComparator != null)
				{
					if (entriesUsed)
					{
						entries = (Map.Entry[])Arrays.copyOf(entries, size);
					}
					Arrays.sort(entries, 0, size, Ordering.from(valueComparator).onResultOf(Maps.valueFunction()));
				}
				entriesUsed = true;
				ImmutableBiMap result = RegularImmutableBiMap.fromEntryArray(size, entries);
				_ = null;
				return result;
			}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 131, 182, 151, 168, 115, 148, 103 })]
		internal new virtual ImmutableBiMap buildJdkBacked()
		{
			Preconditions.checkState(valueComparator == null, (object)"buildJdkBacked is for tests only, doesn't support orderEntriesByValue");
			switch (size)
			{
			case 0:
			{
				ImmutableBiMap result3 = of();
				_ = null;
				return result3;
			}
			case 1:
			{
				Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull(entries[0]);
				ImmutableBiMap result2 = of(entry.getKey(), entry.getValue());
				_ = null;
				return result2;
			}
			default:
			{
				entriesUsed = true;
				ImmutableBiMap result = RegularImmutableBiMap.fromEntryArray(size, entries);
				_ = null;
				return result;
			}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[Signature("()Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
		[LineNumberTable(495)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public new virtual ImmutableBiMap buildKeepingLast()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("Not supported for bimaps");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 45, 104 })]
		public new virtual Builder orderEntriesByValue(Comparator valueComparator)
		{
			base.orderEntriesByValue(valueComparator);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 27, 104 })]
		public new virtual Builder putAll(Iterable entries)
		{
			base.putAll(entries);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 12, 104 })]
		public new virtual Builder putAll(Map map)
		{
			base.putAll(map);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[]
		{
			160,
			byte.MaxValue,
			104
		})]
		public new virtual Builder put(Map.Entry entry)
		{
			base.put(entry);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 232, 105 })]
		internal Builder(int P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(337)]
		internal override ImmutableMap buildJdkBacked()
		{
			ImmutableBiMap result = buildJdkBacked();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(337)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public virtual ImmutableMap _003Cbridge_003EbuildKeepingLast()
		{
			ImmutableBiMap result = buildKeepingLast();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(337)]
		public virtual ImmutableMap _003Cbridge_003EbuildOrThrow()
		{
			ImmutableBiMap result = buildOrThrow();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(337)]
		public virtual ImmutableMap _003Cbridge_003Ebuild()
		{
			ImmutableBiMap result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(337)]
		internal override ImmutableMap.Builder combine(ImmutableMap.Builder P_0)
		{
			Builder result = combine(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(337)]
		public virtual ImmutableMap.Builder _003Cbridge_003EorderEntriesByValue(Comparator c)
		{
			Builder result = orderEntriesByValue(c);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(337)]
		public virtual ImmutableMap.Builder _003Cbridge_003EputAll(Iterable i)
		{
			Builder result = putAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(337)]
		public virtual ImmutableMap.Builder _003Cbridge_003EputAll(Map m)
		{
			Builder result = putAll(m);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(337)]
		public virtual ImmutableMap.Builder _003Cbridge_003Eput(Map.Entry me)
		{
			Builder result = put(me);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(337)]
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
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[]
		{
			161,
			byte.MaxValue,
			105
		})]
		internal SerializedForm(ImmutableBiMap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
		[LineNumberTable(630)]
		internal new virtual Builder makeBuilder(int P_0)
		{
			Builder result = new Builder(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(623)]
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(81)]
	public new static ImmutableBiMap of(object k1, object v1)
	{
		SingletonImmutableBiMap result = new SingletonImmutableBiMap(k1, v1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(76)]
	public new static ImmutableBiMap of()
	{
		return RegularImmutableBiMap.EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 190, 113, 147, 136, 100, 244, 70 })]
	public new static ImmutableBiMap copyOf(Iterable entries)
	{
		Map.Entry[] array = (Map.Entry[])Iterables.toArray(entries, ImmutableMap.EMPTY_ENTRY_ARRAY);
		switch (array.LongLength)
		{
		case 0L:
		{
			ImmutableBiMap result3 = of();
			_ = null;
			return result3;
		}
		case 1L:
		{
			Map.Entry entry = array[0];
			ImmutableBiMap result2 = of(entry.getKey(), entry.getValue());
			_ = null;
			return result2;
		}
		default:
		{
			ImmutableBiMap result = RegularImmutableBiMap.fromEntries(array);
			_ = null;
			return result;
		}
		}
	}

	[Signature("()Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;")]
	public abstract ImmutableBiMap inverse();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TV;>;")]
	[LineNumberTable(597)]
	internal new ImmutableSet createValues()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TV;>;")]
	[LineNumberTable(592)]
	public new virtual ImmutableSet values()
	{
		ImmutableSet result = inverse().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 55, 0, 0 })]
	[LineNumberTable(65)]
	public static Collector toImmutableBiMap(java.util.function.Function keyFunction, java.util.function.Function valueFunction)
	{
		Collector result = CollectCollectors.toImmutableBiMap(keyFunction, valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(90)]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(99)]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2, object k3, object v3)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 58, 106, 63, 9 })]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 69, 106, 63, 21 })]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 81, 106, 106, 108, 108, 108, 108, 230, 58 })]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 98, 106, 106, 108, 108, 108, 108, 108, 230, 57 })]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6, object k7, object v7)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6), ImmutableMap.entryOf(k7, v7));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 67, 106, 106, 108, 108, 108, 108, 108, 108,
		230, 56
	})]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6, object k7, object v7, object k8, object v8)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6), ImmutableMap.entryOf(k7, v7), ImmutableMap.entryOf(k8, v8));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 103, 107, 106, 108, 108, 108, 108, 108, 108,
		108, 230, 55
	})]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6, object k7, object v7, object k8, object v8, object k9, object v9)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6), ImmutableMap.entryOf(k7, v7), ImmutableMap.entryOf(k8, v8), ImmutableMap.entryOf(k9, v9));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 141, 107, 106, 108, 108, 108, 108, 108, 108,
		108, 109, 230, 54
	})]
	public new static ImmutableBiMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6, object k7, object v7, object k8, object v8, object k9, object v9, object k10, object v10)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(ImmutableMap.entryOf(k1, v1), ImmutableMap.entryOf(k2, v2), ImmutableMap.entryOf(k3, v3), ImmutableMap.entryOf(k4, v4), ImmutableMap.entryOf(k5, v5), ImmutableMap.entryOf(k6, v6), ImmutableMap.entryOf(k7, v7), ImmutableMap.entryOf(k8, v8), ImmutableMap.entryOf(k9, v9), ImmutableMap.entryOf(k10, v10));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>([Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 165, 98 })]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public new static ImmutableBiMap ofEntries(params Map.Entry[] entries)
	{
		ImmutableBiMap result = RegularImmutableBiMap.fromEntries(entries);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
	[LineNumberTable(288)]
	public new static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Lcom/google/common/collect/ImmutableBiMap$Builder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 191, 108 })]
	public new static Builder builderWithExpectedSize(int expectedSize)
	{
		CollectPreconditions.checkNonnegative(expectedSize, "expectedSize");
		Builder result = new Builder(expectedSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 165, 136, 167, 104, 162 })]
	public new static ImmutableBiMap copyOf(Map map)
	{
		if (map is ImmutableBiMap)
		{
			ImmutableBiMap immutableBiMap = (ImmutableBiMap)map;
			if (!immutableBiMap.isPartialView())
			{
				return immutableBiMap;
			}
		}
		ImmutableBiMap result = copyOf(map.entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(576)]
	internal ImmutableBiMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(612)]
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
	public object forcePut(object key, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(638)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal override ImmutableCollection createValues()
	{
		ImmutableSet result = createValues();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(44)]
	public new virtual ImmutableCollection _003Cbridge_003Evalues()
	{
		ImmutableSet result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(44)]
	public override Collection _003Cbridge_003Evalues()
	{
		ImmutableSet result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(44)]
	public virtual BiMap _003Cbridge_003Einverse()
	{
		ImmutableBiMap result = inverse();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(44)]
	public new virtual Set _003Cbridge_003Evalues()
	{
		ImmutableSet result = values();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override int size();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		Map._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava]
	static ImmutableBiMap()
	{
		ImmutableBiMapFauxverideShim.___003Cclinit_003E();
	}

	Set BiMap.BiMap_003A_003Avalues()
	{
		return this._003Cbridge_003Evalues();
	}

	BiMap BiMap.BiMap_003A_003Ainverse()
	{
		return _003Cbridge_003Einverse();
	}

	Set Map.Map_003A_003AkeySet()
	{
		return _003Cbridge_003EkeySet();
	}

	Set Map.Map_003A_003AentrySet()
	{
		return _003Cbridge_003EentrySet();
	}

	Collection Map.Map_003A_003Avalues()
	{
		return this._003Cbridge_003Evalues();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableBiMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|toImmutableMap", "(Ljava.util.function.Function;Ljava.util.function.Function;)Ljava.util.stream.Collector;")]
	public new static Collector toImmutableMap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		return ImmutableBiMapFauxverideShim.toImmutableMap(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|toImmutableMap", "(Ljava.util.function.Function;Ljava.util.function.Function;Ljava.util.function.BinaryOperator;)Ljava.util.stream.Collector;")]
	public new static Collector toImmutableMap(java.util.function.Function P_0, java.util.function.Function P_1, BinaryOperator P_2)
	{
		return ImmutableBiMapFauxverideShim.toImmutableMap(P_0, P_1, P_2);
	}
}
