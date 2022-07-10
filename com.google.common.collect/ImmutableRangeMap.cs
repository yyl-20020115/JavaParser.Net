using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/RangeMap<TK;TV;>;Ljava/io/Serializable;")]
[ConstantPool(new object[]
{
	(byte)105,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.RangeMap", "java.io.Serializable" })]
public class ImmutableRangeMap : java.lang.Object, RangeMap, Serializable.__Interface, ISerializable
{
	[Serializable]
	[SpecialName]
	[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TK;>;>;")]
	[EnclosingMethod(null, "subRangeMap", "(Lcom.google.common.collect.Range;)Lcom.google.common.collect.ImmutableRangeMap;")]
	internal class _1 : ImmutableList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024len;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024off;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Range val_0024range;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableRangeMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/Range<TK;>;")]
		[LineNumberTable(new byte[] { 160, 248, 109, 110, 159, 12 })]
		public new virtual Range get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, val_0024len);
			if (P_0 == 0 || P_0 == val_0024len - 1)
			{
				Range result = ((Range)access_0024000(this_00240).get(P_0 + val_0024off)).intersection(val_0024range);
				_ = null;
				return result;
			}
			return (Range)access_0024000(this_00240).get(P_0 + val_0024off);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(354)]
		internal _1(ImmutableRangeMap P_0, int P_1, int P_2, Range P_3)
		{
			this_00240 = P_0;
			val_0024len = P_1;
			val_0024off = P_2;
			val_0024range = P_3;
			base._002Ector();
		}

		public override int size()
		{
			return val_0024len;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(354)]
		public override object get(int P_0)
		{
			Range result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static _1()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _1(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;")]
	[EnclosingMethod(null, "subRangeMap", "(Lcom.google.common.collect.Range;)Lcom.google.common.collect.ImmutableRangeMap;")]
	internal class _2 : ImmutableRangeMap
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Range val_0024range;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableRangeMap val_0024outer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(376)]
		internal _2(ImmutableRangeMap P_0, ImmutableList P_1, ImmutableList P_2, Range P_3, ImmutableRangeMap P_4)
		{
			val_0024range = P_3;
			val_0024outer = P_4;
			base._002Ector(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;)Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 9, 110, 154 })]
		public override ImmutableRangeMap subRangeMap(Range P_0)
		{
			if (val_0024range.isConnected(P_0))
			{
				ImmutableRangeMap result = val_0024outer.subRangeMap(P_0.intersection(val_0024range));
				_ = null;
				return result;
			}
			ImmutableRangeMap result2 = of();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(376)]
		public new virtual RangeMap subRangeMap(Range P_0)
		{
			ImmutableRangeMap result = this.subRangeMap(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(376)]
		public new virtual Map asDescendingMapOfRanges()
		{
			ImmutableMap result = base.asDescendingMapOfRanges();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(376)]
		public new virtual Map asMapOfRanges()
		{
			ImmutableMap result = base.asMapOfRanges();
			_ = null;
			return result;
		}

		[HideFromJava]
		static _2()
		{
			ImmutableRangeMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _2(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[DoNotMock(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/DoNotMock;"
	})]
	public sealed class Builder : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/List<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
		private List entries;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)Lcom/google/common/collect/ImmutableRangeMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 74, 103, 103, 119, 115 })]
		public virtual Builder put(Range range, object value)
		{
			Preconditions.checkNotNull(range);
			Preconditions.checkNotNull(value);
			Preconditions.checkArgument((!range.isEmpty()) ? true : false, "Range must not be empty, but was %s", range);
			entries.add(Maps.immutableEntry(range, value));
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableRangeMap$Builder<TK;TV;>;)Lcom/google/common/collect/ImmutableRangeMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 92, 114 })]
		internal virtual Builder combine(Builder P_0)
		{
			entries.addAll(P_0.entries);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;")]
		[LineNumberTable(new byte[]
		{
			103, 117, 113, 113, 115, 124, 103, 127, 0, 127,
			0, 223, 77, 104, 253, 54, 233, 76
		})]
		public virtual ImmutableRangeMap build()
		{
			Collections.sort(entries, Range.rangeLexOrdering().onKeys());
			ImmutableList.Builder builder = new ImmutableList.Builder(entries.size());
			ImmutableList.Builder builder2 = new ImmutableList.Builder(entries.size());
			for (int i = 0; i < entries.size(); i++)
			{
				Range range = (Range)((Map.Entry)entries.get(i)).getKey();
				if (i > 0)
				{
					Range range2 = (Range)((Map.Entry)entries.get(i - 1)).getKey();
					if (range.isConnected(range2) && !range.intersection(range2).isEmpty())
					{
						string text = java.lang.String.valueOf(range2);
						string text2 = java.lang.String.valueOf(range);
						int num = 47 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
						num = num;
						string s = new StringBuilder(num).append("Overlapping ranges: range ").append(text).append(" overlaps with entry ")
							.append(text2)
							.toString();
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new IllegalArgumentException(s);
					}
				}
				builder.add(range);
				builder2.add(((Map.Entry)entries.get(i)).getValue());
			}
			___003Cclinit_003E();
			ImmutableRangeMap result = new ImmutableRangeMap(builder.build(), builder2.build());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 63, 104, 107 })]
		public Builder()
		{
			entries = Lists.newArrayList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/RangeMap<TK;+TV;>;)Lcom/google/common/collect/ImmutableRangeMap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 84, 127, 6, 120, 98 })]
		public virtual Builder putAll(RangeMap rangeMap)
		{
			Iterator iterator = rangeMap.asMapOfRanges().entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				put((Range)entry.getKey(), entry.getValue());
			}
			return this;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap<Lcom/google/common/collect/Range<TK;>;TV;>;")]
		private ImmutableMap mapOfRanges;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<Lcom/google/common/collect/Range<TK;>;TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 45, 104, 103 })]
		internal SerializedForm(ImmutableMap P_0)
		{
			mapOfRanges = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 58, 102, 127, 6, 120, 98 })]
		internal virtual object createRangeMap()
		{
			Builder builder = new Builder();
			UnmodifiableIterator unmodifiableIterator = mapOfRanges.entrySet().iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				Map.Entry entry = (Map.Entry)((Iterator)unmodifiableIterator).next();
				builder.put((Range)entry.getKey(), entry.getValue());
			}
			ImmutableRangeMap result = builder.build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 50, 109, 136 })]
		internal virtual object readResolve()
		{
			if (mapOfRanges.isEmpty())
			{
				ImmutableRangeMap result = of();
				_ = null;
				return result;
			}
			object result2 = createRangeMap();
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableRangeMap<Ljava/lang/Comparable<*>;Ljava/lang/Object;>;")]
	private static ImmutableRangeMap EMPTY;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TK;>;>;")]
	private ImmutableList ranges;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableList<TV;>;")]
	private ImmutableList values;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableRangeMap$Builder<TK;TV;>;")]
	[LineNumberTable(101)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(50)]
	internal static ImmutableList access_0024000(ImmutableRangeMap P_0)
	{
		return P_0.ranges;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TK;>;>;Lcom/google/common/collect/ImmutableList<TV;>;)V")]
	[LineNumberTable(new byte[] { 125, 104, 103, 103 })]
	internal ImmutableRangeMap(ImmutableList P_0, ImmutableList P_1)
	{
		ranges = P_0;
		values = P_1;
	}

	[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;")]
	public static ImmutableRangeMap of()
	{
		return EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Range<TK;>;")]
	[LineNumberTable(new byte[] { 160, 104, 109, 139, 114, 126 })]
	public virtual Range span()
	{
		if (ranges.isEmpty())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		Range range = (Range)ranges.get(0);
		Range range2 = (Range)ranges.get(ranges.size() - 1);
		Range result = Range.create(range.lowerBound, range2.upperBound);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	[LineNumberTable(new byte[] { 160, 195, 109, 136, 107, 107 })]
	public virtual ImmutableMap asMapOfRanges()
	{
		if (ranges.isEmpty())
		{
			ImmutableMap result = ImmutableMap.of();
			_ = null;
			return result;
		}
		RegularImmutableSortedSet.___003Cclinit_003E();
		RegularImmutableSortedSet regularImmutableSortedSet = new RegularImmutableSortedSet(ranges, Range.rangeLexOrdering());
		ImmutableSortedMap.___003Cclinit_003E();
		ImmutableSortedMap result2 = new ImmutableSortedMap(regularImmutableSortedSet, values);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TK;>;)Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 215, 114, 104, 123, 130, 166, 21, 230, 70,
		166, 21, 230, 70, 100, 136, 98, 100, 235, 86,
		99
	})]
	public virtual ImmutableRangeMap subRangeMap(Range range)
	{
		if (((Range)Preconditions.checkNotNull(range)).isEmpty())
		{
			ImmutableRangeMap result = of();
			_ = null;
			return result;
		}
		if (ranges.isEmpty() || range.encloses(span()))
		{
			return this;
		}
		int num = SortedLists.binarySearch(ranges, Range.upperBoundFn(), range.lowerBound, SortedLists.KeyPresentBehavior.FIRST_AFTER, SortedLists.KeyAbsentBehavior.NEXT_HIGHER);
		int num2 = SortedLists.binarySearch(ranges, Range.lowerBoundFn(), range.upperBound, SortedLists.KeyPresentBehavior.ANY_PRESENT, SortedLists.KeyAbsentBehavior.NEXT_HIGHER);
		if (num >= num2)
		{
			ImmutableRangeMap result2 = of();
			_ = null;
			return result2;
		}
		int num3 = num;
		int num4 = num2 - num;
		_1  = new _1(this, num4, num3, range);
		_2.___003Cclinit_003E();
		_2 result3 = new _2(this, , values.subList(num, num2), range, this);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	[LineNumberTable(new byte[] { 160, 205, 109, 136, 107, 117 })]
	public virtual ImmutableMap asDescendingMapOfRanges()
	{
		if (ranges.isEmpty())
		{
			ImmutableMap result = ImmutableMap.of();
			_ = null;
			return result;
		}
		RegularImmutableSortedSet.___003Cclinit_003E();
		RegularImmutableSortedSet regularImmutableSortedSet = new RegularImmutableSortedSet(ranges.reverse(), Range.rangeLexOrdering().reverse());
		ImmutableSortedMap.___003Cclinit_003E();
		ImmutableSortedMap result2 = new ImmutableSortedMap(regularImmutableSortedSet, values.reverse());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;Lcom/google/common/collect/Range<TK;>;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 105, 0, 0 })]
	[LineNumberTable(65)]
	public static Collector toImmutableRangeMap(java.util.function.Function keyFunction, java.util.function.Function valueFunction)
	{
		Collector result = CollectCollectors.toImmutableRangeMap(keyFunction, valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>(Lcom/google/common/collect/Range<TK;>;TV;)Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;")]
	[LineNumberTable(80)]
	public static ImmutableRangeMap of(Range range, object value)
	{
		ImmutableRangeMap result = new ImmutableRangeMap(ImmutableList.of(range), ImmutableList.of(value));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<*>;V:Ljava/lang/Object;>(Lcom/google/common/collect/RangeMap<TK;+TV;>;)Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		36, 104, 135, 103, 108, 108, 127, 2, 115, 110,
		98
	})]
	public static ImmutableRangeMap copyOf(RangeMap rangeMap)
	{
		if (rangeMap is ImmutableRangeMap)
		{
			return (ImmutableRangeMap)rangeMap;
		}
		Map map = rangeMap.asMapOfRanges();
		ImmutableList.Builder builder = new ImmutableList.Builder(map.size());
		ImmutableList.Builder builder2 = new ImmutableList.Builder(map.size());
		Iterator iterator = map.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			builder.add((Range)entry.getKey());
			builder2.add(entry.getValue());
		}
		ImmutableRangeMap result = new ImmutableRangeMap(builder.build(), builder2.build());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TV;")]
	[LineNumberTable(new byte[]
	{
		160, 69, 166, 102, 239, 61, 230, 70, 100, 130,
		114
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object get(IComparable key)
	{
		int num = SortedLists.binarySearch(ranges, Range.lowerBoundFn(), Cut.belowValue(key), SortedLists.KeyPresentBehavior.ANY_PRESENT, SortedLists.KeyAbsentBehavior.NEXT_LOWER);
		if (num == -1)
		{
			return null;
		}
		Range range = (Range)ranges.get(num);
		return (!range.contains(key)) ? null : values.get(num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 87, 166, 102, 239, 61, 230, 70, 100, 130,
		114
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry getEntry(IComparable key)
	{
		int num = SortedLists.binarySearch(ranges, Range.lowerBoundFn(), Cut.belowValue(key), SortedLists.KeyPresentBehavior.ANY_PRESENT, SortedLists.KeyAbsentBehavior.NEXT_LOWER);
		if (num == -1)
		{
			return null;
		}
		Range range = (Range)ranges.get(num);
		return (!range.contains(key)) ? null : Maps.immutableEntry(range, values.get(num));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
	[LineNumberTable(236)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void put(Range range, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
	[LineNumberTable(249)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void putCoalescing(Range range, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/RangeMap<TK;TV;>;)V")]
	[LineNumberTable(262)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void putAll(RangeMap rangeMap)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(275)]
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
	[Obsolete]
	[Signature("(Lcom/google/common/collect/Range<TK;>;)V")]
	[LineNumberTable(288)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void remove(Range range)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 2, 2, 3, 1, 2, 0, 0,
		105, 0, 0, 22, 2, 2, 3, 2, 2, 0,
		0, 105, 0, 0
	})]
	[LineNumberTable(304)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void merge(Range range, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value, BiFunction remappingFunction)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(390)]
	public override int hashCode()
	{
		int result = asMapOfRanges().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 25, 104, 103, 148 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object o)
	{
		if (o is RangeMap)
		{
			RangeMap rangeMap = (RangeMap)o;
			bool result = asMapOfRanges().equals(rangeMap.asMapOfRanges());
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(404)]
	public override string toString()
	{
		string result = asMapOfRanges().toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(439)]
	internal virtual object writeReplace()
	{
		SerializedForm result = new SerializedForm(asMapOfRanges());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(47)]
	public virtual RangeMap _003Cbridge_003EsubRangeMap(Range r)
	{
		ImmutableRangeMap result = subRangeMap(r);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(47)]
	public virtual Map _003Cbridge_003EasDescendingMapOfRanges()
	{
		ImmutableMap result = asDescendingMapOfRanges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(47)]
	public virtual Map _003Cbridge_003EasMapOfRanges()
	{
		ImmutableMap result = asMapOfRanges();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 3, 52 })]
	static ImmutableRangeMap()
	{
		EMPTY = new ImmutableRangeMap(ImmutableList.of(), ImmutableList.of());
	}

	[HideFromJava]
	public static implicit operator Serializable(ImmutableRangeMap P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	Map RangeMap.RangeMap_003A_003AasMapOfRanges()
	{
		return _003Cbridge_003EasMapOfRanges();
	}

	Map RangeMap.RangeMap_003A_003AasDescendingMapOfRanges()
	{
		return _003Cbridge_003EasDescendingMapOfRanges();
	}

	RangeMap RangeMap.RangeMap_003A_003AsubRangeMap(Range P_0)
	{
		return _003Cbridge_003EsubRangeMap(P_0);
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
	protected ImmutableRangeMap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
