using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
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
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Map<TK;TV;>;Ljava/io/Serializable;")]
[ConstantPool(new object[]
{
	(byte)125,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ImmutableMap.of or another implementation"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Map", "java.io.Serializable" })]
public abstract class ImmutableMap : java.lang.Object, Map, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TK;>;")]
	[EnclosingMethod(null, "keyIterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _1 : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal UnmodifiableIterator val_0024entryIterator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1043)]
		internal _1(ImmutableMap P_0, UnmodifiableIterator P_1)
		{
			val_0024entryIterator = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1046)]
		public override bool hasNext()
		{
			bool result = val_0024entryIterator.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1051)]
		public override object next()
		{
			object key = ((Map.Entry)val_0024entryIterator.next()).getKey();
			_ = null;
			return key;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[ConstantPool(new object[]
	{
		(byte)68,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[DoNotMock(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/DoNotMock;"
	})]
	public class Builder : java.lang.Object
	{
		[Signature("Ljava/util/Comparator<-TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Comparator valueComparator;

		[Signature("[Ljava/util/Map$Entry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 68, 0, 0 })]
		internal Map.Entry[] entries;

		internal int size;

		internal bool entriesUsed;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 78, 110, 136, 123 })]
		public virtual Builder put(object key, object value)
		{
			ensureCapacity(size + 1);
			Map.Entry entry = entryOf(key, value);
			Map.Entry[] array = entries;
			int num = size;
			size = num + 1;
			array[num] = entry;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(601)]
		public virtual ImmutableMap buildOrThrow()
		{
			ImmutableMap result = build(true);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(620)]
		public virtual ImmutableMap buildKeepingLast()
		{
			ImmutableMap result = build(false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 52, 105 })]
		public Builder()
			: this(4)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;)Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 149, 103, 115, 126, 115 })]
		internal virtual Builder combine(Builder P_0)
		{
			Preconditions.checkNotNull(P_0);
			ensureCapacity(size + P_0.size);
			ByteCodeHelper.arraycopy(P_0.entries, 0, entries, size, P_0.size);
			size += P_0.size;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(588)]
		public virtual ImmutableMap build()
		{
			ImmutableMap result = buildOrThrow();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 56, 104, 108, 103, 103 })]
		internal Builder(int P_0)
		{
			entries = new Map.Entry[P_0];
			size = 0;
			entriesUsed = false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 63, 106, 143, 37, 143, 135 })]
		private void ensureCapacity(int P_0)
		{
			if (P_0 > (nint)entries.LongLength)
			{
				entries = (Map.Entry[])Arrays.copyOf(entries, ImmutableCollection.Builder.expandedCapacity(entries.Length, P_0));
				entriesUsed = false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 120, 104, 152, 123, 104, 98 })]
		public virtual Builder putAll(Iterable entries)
		{
			if (entries is Collection)
			{
				ensureCapacity(size + ((Collection)entries).size());
			}
			Iterator iterator = entries.iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				put(entry);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
		[LineNumberTable(464)]
		public virtual Builder put(Map.Entry entry)
		{
			Builder result = put(entry.getKey(), entry.getValue());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>([Ljava/util/Map$Entry<TK;TV;>;I)[Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[]
		{
			162, 15, 102, 102, 104, 112, 7, 230, 69, 104,
			162, 110, 107, 106, 14, 232, 69
		})]
		private static Map.Entry[] lastEntryForEachKey(Map.Entry[] P_0, int P_1)
		{
			HashSet hashSet = new HashSet();
			BitSet bitSet = new BitSet();
			for (int i = P_1 - 1; i >= 0; i += -1)
			{
				if (!((Set)hashSet).add(P_0[i].getKey()))
				{
					bitSet.set(i);
				}
			}
			if (bitSet.isEmpty())
			{
				return P_0;
			}
			Map.Entry[] array = new Map.Entry[P_1 - bitSet.cardinality()];
			int j = 0;
			int num = 0;
			for (; j < P_1; j++)
			{
				if (!bitSet.get(j))
				{
					int num2 = num;
					num++;
					array[num2] = P_0[j];
				}
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Z)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(new byte[]
		{
			159, 9, 130, 151, 168, 115, 244, 74, 103, 104,
			140, 104, 156, 103, 195, 99, 110, 131, 201, 239,
			60, 229, 70, 103
		})]
		private ImmutableMap build(bool P_0)
		{
			switch (size)
			{
			case 0:
			{
				ImmutableMap result3 = of();
				_ = null;
				return result3;
			}
			case 1:
			{
				Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull(entries[0]);
				ImmutableMap result2 = of(entry.getKey(), entry.getValue());
				_ = null;
				return result2;
			}
			default:
			{
				int num = size;
				Map.Entry[] array;
				if (valueComparator == null)
				{
					array = entries;
				}
				else
				{
					if (entriesUsed)
					{
						entries = (Map.Entry[])Arrays.copyOf(entries, size);
					}
					array = entries;
					if (!P_0)
					{
						Map.Entry[] array2 = array;
						array = lastEntryForEachKey(array2, size);
						num = array.Length;
					}
					Arrays.sort(array, 0, num, Ordering.from(valueComparator).onResultOf(Maps.valueFunction()));
				}
				entriesUsed = true;
				ImmutableMap result = RegularImmutableMap.fromEntryArray(num, array, P_0);
				_ = null;
				return result;
			}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
		[LineNumberTable(476)]
		public virtual Builder putAll(Map map)
		{
			Builder result = putAll(map.entrySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 142, 118, 118 })]
		public virtual Builder orderEntriesByValue(Comparator valueComparator)
		{
			Preconditions.checkState(this.valueComparator == null, (object)"valueComparator was already set");
			this.valueComparator = (Comparator)Preconditions.checkNotNull((object)valueComparator, (object)"valueComparator");
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(new byte[]
		{
			161,
			byte.MaxValue,
			150,
			151,
			168,
			115,
			148,
			103
		})]
		internal virtual ImmutableMap buildJdkBacked()
		{
			Preconditions.checkState(valueComparator == null, (object)"buildJdkBacked is only for testing; can't use valueComparator");
			switch (size)
			{
			case 0:
			{
				ImmutableMap result3 = of();
				_ = null;
				return result3;
			}
			case 1:
			{
				Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull(entries[0]);
				ImmutableMap result2 = of(entry.getKey(), entry.getValue());
				_ = null;
				return result2;
			}
			default:
			{
				entriesUsed = true;
				ImmutableMap result = JdkBackedImmutableMap.create(size, entries, true);
				_ = null;
				return result;
			}
			}
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	internal abstract class IteratorBasedImmutableMap : ImmutableMap
	{
		[Serializable]
		[SpecialName]
		[Signature("Lcom/google/common/collect/ImmutableMapEntrySet<TK;TV;>;")]
		[EnclosingMethod(null, "createEntrySet", "()Lcom.google.common.collect.ImmutableSet;")]
		internal class _1EntrySetImpl : ImmutableMapEntrySet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal IteratorBasedImmutableMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(746)]
			internal _1EntrySetImpl(IteratorBasedImmutableMap P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(754)]
			public override UnmodifiableIterator iterator()
			{
				UnmodifiableIterator result = this_00240.entryIterator();
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
			[LineNumberTable(746)]
			public override Iterator iterator()
			{
				UnmodifiableIterator result = this.iterator();
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1EntrySetImpl()
			{
				ImmutableMapEntrySet.___003Cclinit_003E();
			}

			[HideFromJava]
			[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
			protected _1EntrySetImpl(SerializationInfo P_0, StreamingContext P_1)
				: base(P_0, P_1)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		protected internal new static void ___003Cclinit_003E()
		{
		}

		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal abstract UnmodifiableIterator entryIterator();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(729)]
		internal IteratorBasedImmutableMap()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 107, 97, 102, 11 })]
		internal virtual Spliterator entrySpliterator()
		{
			Spliterator result = Spliterators.spliterator(entryIterator(), size(), 1297);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
		[LineNumberTable(741)]
		internal override ImmutableSet createKeySet()
		{
			ImmutableMapKeySet result = new ImmutableMapKeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(757)]
		internal override ImmutableSet createEntrySet()
		{
			_1EntrySetImpl result = new _1EntrySetImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
		[LineNumberTable(762)]
		internal override ImmutableCollection createValues()
		{
			ImmutableMapValues result = new ImmutableMapValues(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(729)]
		public new virtual Set entrySet()
		{
			ImmutableSet result = base.entrySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(729)]
		public new virtual Collection values()
		{
			ImmutableCollection result = base.values();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(729)]
		public new virtual Set keySet()
		{
			ImmutableSet result = base.keySet();
			_ = null;
			return result;
		}

		[HideFromJava]
		static IteratorBasedImmutableMap()
		{
			ImmutableMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected IteratorBasedImmutableMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap$IteratorBasedImmutableMap<TK;Lcom/google/common/collect/ImmutableSet<TV;>;>;")]
	internal sealed class MapViewOfValuesAsSingletonSets : IteratorBasedImmutableMap
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;Lcom/google/common/collect/ImmutableSet<TV;>;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal new class _1 : UnmodifiableIterator
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/AbstractMapEntry<TK;Lcom/google/common/collect/ImmutableSet<TV;>;>;")]
			[EnclosingMethod(null, "next", "()Ljava.util.Map$Entry;")]
			internal class _1 : AbstractMapEntry
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal Map.Entry val_0024backingEntry;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()Lcom/google/common/collect/ImmutableSet<TV;>;")]
				[LineNumberTable(1160)]
				public new virtual ImmutableSet getValue()
				{
					ImmutableSet result = ImmutableSet.of(val_0024backingEntry.getValue());
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(1152)]
				internal _1(MapViewOfValuesAsSingletonSets._1 P_0, Map.Entry P_1)
				{
					val_0024backingEntry = P_1;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()TK;")]
				[LineNumberTable(1155)]
				public override object getKey()
				{
					object key = val_0024backingEntry.getKey();
					_ = null;
					return key;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(1152)]
				public override object getValue()
				{
					ImmutableSet value = getValue();
					_ = null;
					return value;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024backingIterator;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<TK;Lcom/google/common/collect/ImmutableSet<TV;>;>;")]
			[LineNumberTable(new byte[] { 164, 13, 113 })]
			public new virtual Map.Entry next()
			{
				Map.Entry entry = (Map.Entry)val_0024backingIterator.next();
				_1 result = new _1(this, entry);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1143)]
			internal _1(MapViewOfValuesAsSingletonSets P_0, Iterator P_1)
			{
				val_0024backingIterator = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1146)]
			public override bool hasNext()
			{
				bool result = val_0024backingIterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1143)]
			public override object next()
			{
				Map.Entry result = next();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1099)]
		internal MapViewOfValuesAsSingletonSets(ImmutableMap P_0, ImmutableMap._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1099)]
		private MapViewOfValuesAsSingletonSets(ImmutableMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSet<TV;>;")]
		[LineNumberTable(new byte[] { 163, 238, 109 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual ImmutableSet get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			object obj = this_00240.get(P_0);
			ImmutableSet result = ((obj != null) ? ImmutableSet.of(obj) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1104)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
		[LineNumberTable(1109)]
		internal override ImmutableSet createKeySet()
		{
			ImmutableSet result = this_00240.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1114)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1126)]
		internal override bool isPartialView()
		{
			bool result = this_00240.isPartialView();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1132)]
		public override int hashCode()
		{
			int result = this_00240.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1137)]
		internal override bool isHashCodeFast()
		{
			bool result = this_00240.isHashCodeFast();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;Lcom/google/common/collect/ImmutableSet<TV;>;>;>;")]
		[LineNumberTable(new byte[] { 164, 4, 113 })]
		internal override UnmodifiableIterator entryIterator()
		{
			UnmodifiableIterator unmodifiableIterator = this_00240.entrySet().iterator();
			_1 result = new _1(this, unmodifiableIterator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1098)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			ImmutableSet result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static MapViewOfValuesAsSingletonSets()
		{
			IteratorBasedImmutableMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected MapViewOfValuesAsSingletonSets(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		private const bool USE_LEGACY_SERIALIZATION = true;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object keys;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object values;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[]
		{
			164, 67, 136, 108, 108, 130, 127, 5, 106, 106,
			100, 98, 103, 103
		})]
		internal SerializedForm(ImmutableMap P_0)
		{
			object[] array = new object[P_0.size()];
			object[] array2 = new object[P_0.size()];
			int num = 0;
			UnmodifiableIterator unmodifiableIterator = P_0.entrySet().iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				Map.Entry entry = (Map.Entry)((Iterator)unmodifiableIterator).next();
				array[num] = entry.getKey();
				array2[num] = entry.getValue();
				num++;
			}
			keys = array;
			values = array2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 109, 108, 140, 137, 103, 45, 166 })]
		internal object legacyReadResolve()
		{
			object[] array = (object[])keys;
			object[] array2 = (object[])values;
			Builder builder = makeBuilder(array.Length);
			for (int i = 0; i < (nint)array.LongLength; i++)
			{
				builder.put(array[i], array2[i]);
			}
			ImmutableMap result = builder.buildOrThrow();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
		[LineNumberTable(1262)]
		internal virtual Builder makeBuilder(int P_0)
		{
			Builder result = new Builder(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			164, 88, 109, 169, 108, 140, 141, 103, 136, 104,
			182
		})]
		internal object readResolve()
		{
			if (!(keys is ImmutableSet))
			{
				object result = legacyReadResolve();
				_ = null;
				return result;
			}
			ImmutableSet immutableSet = (ImmutableSet)keys;
			ImmutableCollection immutableCollection = (ImmutableCollection)values;
			Builder builder = makeBuilder(immutableSet.size());
			UnmodifiableIterator unmodifiableIterator = immutableSet.iterator();
			UnmodifiableIterator unmodifiableIterator2 = immutableCollection.iterator();
			while (unmodifiableIterator.hasNext())
			{
				builder.put(unmodifiableIterator.next(), unmodifiableIterator2.next());
			}
			ImmutableMap result2 = builder.buildOrThrow();
			_ = null;
			return result2;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(SerializedForm))
			{
				return this;
			}
			return readResolve();
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			object key = ((Map.Entry)P_0).getKey();
			_ = null;
			return key;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("[Ljava/util/Map$Entry<**>;")]
	internal static Map.Entry[] EMPTY_ENTRY_ARRAY;

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
	private ImmutableSet m_entrySet;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSet<TK;>;")]
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
	private ImmutableSet m_keySet;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableCollection<TV;>;")]
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
	private ImmutableCollection m_values;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
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
	private ImmutableSetMultimap multimapView;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 162, 49, 144, 103, 104, 130, 138, 108, 130 })]
	public static ImmutableMap copyOf(Map map)
	{
		if (map is ImmutableMap && !(map is SortedMap))
		{
			ImmutableMap immutableMap = (ImmutableMap)map;
			if (!immutableMap.isPartialView())
			{
				return immutableMap;
			}
		}
		else if (map is EnumMap)
		{
			return copyOfEnumMap((EnumMap)map);
		}
		ImmutableMap result = copyOf(map.entrySet());
		_ = null;
		return result;
	}

	[Signature("(Ljava/lang/Object;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public abstract object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
	[LineNumberTable(347)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(953)]
	public virtual bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		return get(key) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	[LineNumberTable(new byte[] { 163, 148, 103 })]
	public virtual ImmutableSet keySet()
	{
		ImmutableSet immutableSet = this.m_keySet;
		ImmutableSet result;
		if (immutableSet == null)
		{
			ImmutableSet immutableSet2 = createKeySet();
			result = immutableSet2;
			this.m_keySet = immutableSet2;
		}
		else
		{
			result = immutableSet;
		}
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract int size();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(948)]
	public virtual bool isEmpty()
	{
		return (size() == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(119)]
	public static ImmutableMap of()
	{
		return RegularImmutableMap.EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(339)]
	internal static Map.Entry entryOf(object P_0, object P_1)
	{
		ImmutableMapEntry result = new ImmutableMapEntry(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(377)]
	internal static IllegalArgumentException conflictException(string P_0, object P_1, object P_2)
	{
		string text = java.lang.String.valueOf(P_1);
		string text2 = java.lang.String.valueOf(P_2);
		int num = 34 + java.lang.String.instancehelper_length(java.lang.String.valueOf(P_0)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		IllegalArgumentException result = new IllegalArgumentException(new StringBuilder(num).append("Multiple entries with same ").append(P_0).append(": ")
			.append(text)
			.append(" and ")
			.append(text2)
			.toString());
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual bool isPartialView()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableMap.isPartialView()Z");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/util/EnumMap<TK;+TV;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 162, 94, 103, 127, 1, 113, 98 })]
	private static ImmutableMap copyOfEnumMap(EnumMap P_0)
	{
		EnumMap enumMap = new EnumMap(P_0);
		Iterator iterator = enumMap.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			CollectPreconditions.checkEntryNotNull(entry.getKey(), entry.getValue());
		}
		ImmutableMap result = ImmutableEnumMap.asImmutable(enumMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 162, 75, 113, 147, 168, 110, 244, 70 })]
	public static ImmutableMap copyOf(Iterable entries)
	{
		Map.Entry[] array = (Map.Entry[])Iterables.toArray(entries, EMPTY_ENTRY_ARRAY);
		switch (array.LongLength)
		{
		case 0L:
		{
			ImmutableMap result3 = of();
			_ = null;
			return result3;
		}
		case 1L:
		{
			Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull(array[0]);
			ImmutableMap result2 = of(entry.getKey(), entry.getValue());
			_ = null;
			return result2;
		}
		default:
		{
			ImmutableMap result = RegularImmutableMap.fromEntries(array);
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(128)]
	public static ImmutableMap of(object k1, object v1)
	{
		ImmutableBiMap result = ImmutableBiMap.of(k1, v1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(new byte[] { 163, 186, 103 })]
	public virtual ImmutableCollection values()
	{
		ImmutableCollection immutableCollection = this.m_values;
		ImmutableCollection result;
		if (immutableCollection == null)
		{
			ImmutableCollection immutableCollection2 = createValues();
			result = immutableCollection2;
			this.m_values = immutableCollection2;
		}
		else
		{
			result = immutableCollection;
		}
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal virtual ImmutableSet createEntrySet()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableMap.createEntrySet()Lcom.google.common.collect.ImmutableSet;");
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	internal virtual ImmutableSet createKeySet()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableMap.createKeySet()Lcom.google.common.collect.ImmutableSet;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 163, 134, 103 })]
	public virtual ImmutableSet entrySet()
	{
		ImmutableSet immutableSet = this.m_entrySet;
		ImmutableSet result;
		if (immutableSet == null)
		{
			ImmutableSet immutableSet2 = createEntrySet();
			result = immutableSet2;
			this.m_entrySet = immutableSet2;
		}
		else
		{
			result = immutableSet;
		}
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	internal virtual ImmutableCollection createValues()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableMap.createValues()Lcom.google.common.collect.ImmutableCollection;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 125, 0, 0 })]
	[LineNumberTable(89)]
	public static Collector toImmutableMap(java.util.function.Function keyFunction, java.util.function.Function valueFunction)
	{
		Collector result = CollectCollectors.toImmutableMap(keyFunction, valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 125, 0, 0 })]
	[LineNumberTable(107)]
	public static Collector toImmutableMap(java.util.function.Function keyFunction, java.util.function.Function valueFunction, BinaryOperator mergeFunction)
	{
		Collector result = CollectCollectors.toImmutableMap(keyFunction, valueFunction, mergeFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(137)]
	public static ImmutableMap of(object k1, object v1, object k2, object v2)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(146)]
	public static ImmutableMap of(object k1, object v1, object k2, object v2, object k3, object v3)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2), entryOf(k3, v3));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 105, 106, 63, 9 })]
	public static ImmutableMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2), entryOf(k3, v3), entryOf(k4, v4));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 116, 106, 63, 21 })]
	public static ImmutableMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2), entryOf(k3, v3), entryOf(k4, v4), entryOf(k5, v5));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 64, 106, 106, 108, 108, 108, 108, 230, 58 })]
	public static ImmutableMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2), entryOf(k3, v3), entryOf(k4, v4), entryOf(k5, v5), entryOf(k6, v6));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 81, 106, 106, 108, 108, 108, 108, 108, 230,
		57
	})]
	public static ImmutableMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6, object k7, object v7)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2), entryOf(k3, v3), entryOf(k4, v4), entryOf(k5, v5), entryOf(k6, v6), entryOf(k7, v7));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 114, 106, 106, 108, 108, 108, 108, 108, 108,
		230, 56
	})]
	public static ImmutableMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6, object k7, object v7, object k8, object v8)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2), entryOf(k3, v3), entryOf(k4, v4), entryOf(k5, v5), entryOf(k6, v6), entryOf(k7, v7), entryOf(k8, v8));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 150, 107, 106, 108, 108, 108, 108, 108, 108,
		108, 230, 55
	})]
	public static ImmutableMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6, object k7, object v7, object k8, object v8, object k9, object v9)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2), entryOf(k3, v3), entryOf(k4, v4), entryOf(k5, v5), entryOf(k6, v6), entryOf(k7, v7), entryOf(k8, v8), entryOf(k9, v9));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 189, 107, 106, 108, 108, 108, 108, 108, 108,
		108, 109, 230, 54
	})]
	public static ImmutableMap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5, object k6, object v6, object k7, object v7, object k8, object v8, object k9, object v9, object k10, object v10)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entryOf(k1, v1), entryOf(k2, v2), entryOf(k3, v3), entryOf(k4, v4), entryOf(k5, v5), entryOf(k6, v6), entryOf(k7, v7), entryOf(k8, v8), entryOf(k9, v9), entryOf(k10, v10));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>([Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 213, 98 })]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static ImmutableMap ofEntries(params Map.Entry[] entries)
	{
		ImmutableMap result = RegularImmutableMap.fromEntries(entries);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Lcom/google/common/collect/ImmutableMap$Builder<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 250, 108 })]
	public static Builder builderWithExpectedSize(int expectedSize)
	{
		CollectPreconditions.checkNonnegative(expectedSize, "expectedSize");
		Builder result = new Builder(expectedSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 50, 130, 99, 142 })]
	internal static void checkNoConflict(bool P_0, string P_1, object P_2, object P_3)
	{
		if (!P_0)
		{
			throw Throwable.___003Cunmap_003E(conflictException(P_1, P_2, P_3));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(766)]
	internal ImmutableMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(780)]
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
	public object put(object k, object v)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(795)]
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
	public object putIfAbsent(object key, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;TV;TV;)Z")]
	[LineNumberTable(808)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public bool replace(object key, object oldValue, object newValue)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(822)]
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
	public object replace(object key, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;Ljava/util/function/Function<-TK;+TV;>;)TV;")]
	[LineNumberTable(835)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public object computeIfAbsent(object key, java.util.function.Function mappingFunction)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
	[LineNumberTable(849)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public object computeIfPresent(object key, BiFunction remappingFunction)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 2, 3, 1, 2, 0, 0,
		125, 0, 0
	})]
	[LineNumberTable(863)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public object compute(object key, BiFunction remappingFunction)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)TV;")]
	[LineNumberTable(877)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public object merge(object key, object value, BiFunction remappingFunction)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(890)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void putAll(Map map)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
	[LineNumberTable(903)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void replaceAll(BiFunction function)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(917)]
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
	public object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object o)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(930)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(943)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void clear()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(958)]
	public virtual bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		bool result = values().contains(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;TV;)TV;")]
	[LineNumberTable(new byte[] { 163, 117, 136, 99, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public object getOrDefault([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object defaultValue)
	{
		object obj = get(key);
		if (obj != null)
		{
			return obj;
		}
		return defaultValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TK;>;")]
	[LineNumberTable(new byte[] { 163, 160, 108 })]
	internal virtual UnmodifiableIterator keyIterator()
	{
		UnmodifiableIterator unmodifiableIterator = entrySet().iterator();
		_1 result = new _1(this, unmodifiableIterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TK;>;")]
	[LineNumberTable(1057)]
	internal virtual Spliterator keySpliterator()
	{
		Spliterator result = CollectSpliterators.map(entrySet().spliterator(), new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 163, 206, 104, 136, 103, 99, 105, 119, 225, 61 })]
	public virtual ImmutableSetMultimap asMultimap()
	{
		if (isEmpty())
		{
			ImmutableSetMultimap result = ImmutableSetMultimap.of();
			_ = null;
			return result;
		}
		ImmutableSetMultimap immutableSetMultimap = multimapView;
		ImmutableSetMultimap result2;
		if (immutableSetMultimap == null)
		{
			ImmutableSetMultimap immutableSetMultimap2 = new ImmutableSetMultimap(new MapViewOfValuesAsSingletonSets(this, null), size(), null);
			result2 = immutableSetMultimap2;
			multimapView = immutableSetMultimap2;
		}
		else
		{
			result2 = immutableSetMultimap;
		}
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1170)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		bool result = Maps.equalsImpl(this, @object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1177)]
	public override int hashCode()
	{
		int result = Sets.hashCodeImpl(entrySet());
		_ = null;
		return result;
	}

	internal virtual bool isHashCodeFast()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1186)]
	public override string toString()
	{
		string result = Maps.toStringImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1274)]
	internal virtual object writeReplace()
	{
		SerializedForm result = new SerializedForm(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(67)]
	public virtual Set _003Cbridge_003EentrySet()
	{
		ImmutableSet result = entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(67)]
	public virtual Collection _003Cbridge_003Evalues()
	{
		ImmutableCollection result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(67)]
	public virtual Set _003Cbridge_003EkeySet()
	{
		ImmutableSet result = keySet();
		_ = null;
		return result;
	}

	[LineNumberTable(727)]
	static ImmutableMap()
	{
		EMPTY_ENTRY_ARRAY = new Map.Entry[0];
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(BiConsumer P_0)
	{
		Map._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava]
	public static implicit operator Serializable(ImmutableMap P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
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
		return _003Cbridge_003Evalues();
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
		this.GetObjectData(P_0, P_1);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableMap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
