using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultimap<TK;TV;>;Lcom/google/common/collect/FilteredMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 101, 0, 0,
	17, 1, 0, 0, 0, 101, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)101,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.FilteredMultimap" })]
internal class FilteredEntryMultimap : AbstractMultimap, FilteredMultimap, Multimap
{
	[Signature("Lcom/google/common/collect/Maps$ViewCachingAbstractMap<TK;Ljava/util/Collection<TV;>;>;")]
	internal class AsMap : Maps.ViewCachingAbstractMap
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/Maps$EntrySet<TK;Ljava/util/Collection<TV;>;>;")]
		[EnclosingMethod(null, "createEntrySet", "()Ljava.util.Set;")]
		internal class _1EntrySetImpl : Maps.EntrySet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			internal class _1 : AbstractIterator
			{
				[Modifiers(Modifiers.Final)]
				[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
				internal Iterator backingIterator;

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal _1EntrySetImpl this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
				[LineNumberTable(new byte[]
				{
					160, 151, 109, 113, 103, 97, 127, 7, 104, 138,
					101
				})]
				[CheckForNull(new object[]
				{
					(byte)64,
					"Ljavax/annotation/CheckForNull;"
				})]
				protected internal new virtual Map.Entry computeNext()
				{
					while (backingIterator.hasNext())
					{
						Map.Entry entry = (Map.Entry)backingIterator.next();
						object key = entry.getKey();
						Collection collection = filterCollection((Collection)entry.getValue(), new ValuePredicate(this_00242.this_00241.this_00240, key));
						if (!collection.isEmpty())
						{
							Map.Entry result = Maps.immutableEntry(key, collection);
							_ = null;
							return result;
						}
					}
					return (Map.Entry)endOfData();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(new byte[] { 160, 144, 111, 118, 52 })]
				internal _1(_1EntrySetImpl P_0)
				{
					this_00242 = P_0;
					base._002Ector();
					backingIterator = this_00242.this_00241.this_00240.unfiltered.asMap().entrySet().iterator();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(258)]
				[CheckForNull(new object[]
				{
					(byte)64,
					"Ljavax/annotation/CheckForNull;"
				})]
				protected internal override object computeNext()
				{
					Map.Entry result = computeNext();
					_ = null;
					return result;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
			[LineNumberTable(258)]
			public override Iterator iterator()
			{
				_1 result = new _1(this);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(250)]
			internal _1EntrySetImpl(AsMap P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
			internal override Map map()
			{
				return this_00241;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(281)]
			public override bool removeAll(Collection P_0)
			{
				bool result = this_00241.this_00240.removeEntriesIf(Predicates.@in(P_0));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(286)]
			public override bool retainAll(Collection P_0)
			{
				bool result = this_00241.this_00240.removeEntriesIf(Predicates.not(Predicates.@in(P_0)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(291)]
			public override int size()
			{
				int result = Iterators.size(iterator());
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/Maps$KeySet<TK;Ljava/util/Collection<TV;>;>;")]
		[EnclosingMethod(null, "createKeySet", "()Ljava.util.Set;")]
		internal class _1KeySetImpl : Maps.KeySet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 111, 103, 105 })]
			internal _1KeySetImpl(AsMap P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(231)]
			public override bool removeAll(Collection P_0)
			{
				bool result = this_00241.this_00240.removeEntriesIf(Maps.keyPredicateOnEntries(Predicates.@in(P_0)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(236)]
			public override bool retainAll(Collection P_0)
			{
				bool result = this_00241.this_00240.removeEntriesIf(Maps.keyPredicateOnEntries(Predicates.not(Predicates.@in(P_0))));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(241)]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				return this_00241.remove(P_0) != null;
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/Maps$Values<TK;Ljava/util/Collection<TV;>;>;")]
		[EnclosingMethod(null, "createValues", "()Ljava.util.Collection;")]
		internal class _1ValuesImpl : Maps.Values
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 187, 103, 105 })]
			internal _1ValuesImpl(AsMap P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				160, 193, 107, 103, 112, 112, 107, 108, 103, 97,
				127, 3, 115, 121, 136, 135, 130, 133
			})]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (P_0 is Collection)
				{
					Collection collection = (Collection)P_0;
					Iterator iterator = this_00241.this_00240.unfiltered.asMap().entrySet().iterator();
					while (iterator.hasNext())
					{
						Map.Entry entry = (Map.Entry)iterator.next();
						object key = entry.getKey();
						Collection collection2 = filterCollection((Collection)entry.getValue(), new ValuePredicate(this_00241.this_00240, key));
						if (!collection2.isEmpty() && collection.equals(collection2))
						{
							if (collection2.size() == ((Collection)entry.getValue()).size())
							{
								iterator.remove();
							}
							else
							{
								collection2.clear();
							}
							return true;
						}
					}
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(331)]
			public override bool removeAll(Collection P_0)
			{
				bool result = this_00241.this_00240.removeEntriesIf(Maps.valuePredicateOnEntries(Predicates.@in(P_0)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(336)]
			public override bool retainAll(Collection P_0)
			{
				bool result = this_00241.this_00240.removeEntriesIf(Maps.valuePredicateOnEntries(Predicates.not(Predicates.@in(P_0))));
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal FilteredEntryMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 160, 70, 124, 99, 162, 98, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Collection get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Collection collection = (Collection)this_00240.unfiltered.asMap().get(P_0);
			if (collection == null)
			{
				return null;
			}
			collection = filterCollection(collection, new ValuePredicate(this_00240, P_0));
			return (!collection.isEmpty()) ? collection : null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[]
		{
			160, 83, 124, 99, 162, 98, 102, 103, 104, 104,
			112, 102, 137, 98, 104, 98, 114, 142
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Collection remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Collection collection = (Collection)this_00240.unfiltered.asMap().get(P_0);
			if (collection == null)
			{
				return null;
			}
			ArrayList arrayList = Lists.newArrayList();
			Iterator iterator = collection.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (access_0024000(this_00240, P_0, obj))
				{
					iterator.remove();
					((List)arrayList).add(obj);
				}
			}
			if (((List)arrayList).isEmpty())
			{
				return null;
			}
			if (this_00240.unfiltered is SetMultimap)
			{
				Set result = Collections.unmodifiableSet(Sets.newLinkedHashSet(arrayList));
				_ = null;
				return result;
			}
			List result2 = Collections.unmodifiableList(arrayList);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(170)]
		internal AsMap(FilteredEntryMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(173)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return get(P_0) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 64, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(244)]
		internal override Set createKeySet()
		{
			_1KeySetImpl result = new _1KeySetImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		[LineNumberTable(294)]
		internal override Set createEntrySet()
		{
			_1EntrySetImpl result = new _1EntrySetImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(339)]
		internal override Collection createValues()
		{
			_1ValuesImpl result = new _1ValuesImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(169)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Collection result = remove(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(169)]
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
			Collection result = get(P_0);
			_ = null;
			return result;
		}
	}

	[Signature("Lcom/google/common/collect/Multimaps$Keys<TK;TV;>;")]
	internal class Keys : Multimaps.Keys
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/Multisets$EntrySet<TK;>;")]
		[EnclosingMethod(null, "entrySet", "()Ljava.util.Set;")]
		internal new class _1 : Multisets.EntrySet
		{
			[SpecialName]
			private sealed class ___003C_003EAnon0 : com.google.common.@base.Predicate
			{
				private readonly com.google.common.@base.Predicate arg_00241;

				internal ___003C_003EAnon0(com.google.common.@base.Predicate P_0)
				{
					arg_00241 = P_0;
				}

				public bool apply(object P_0)
				{
					bool result = lambda_0024removeEntriesIf_00240(arg_00241, (Map.Entry)P_0);
					_ = null;
					return result;
				}

				[SpecialName]
				public bool equals(object P_0)
				{
					return Object.instancehelper_equals(this, P_0);
				}

				[SpecialName]
				public bool test(object P_0)
				{
					return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
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

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Keys this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/base/Predicate<-Lcom/google/common/collect/Multiset$Entry<TK;>;>;)Z")]
			[LineNumberTable(400)]
			private bool removeEntriesIf(com.google.common.@base.Predicate P_0)
			{
				bool result = this_00241.this_00240.removeEntriesIf(new ___003C_003EAnon0(P_0));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(new byte[] { 161, 32, 98, 58 })]
			private static bool lambda_0024removeEntriesIf_00240(com.google.common.@base.Predicate P_0, Map.Entry P_1)
			{
				bool result = P_0.apply(Multisets.immutableEntry(P_1.getKey(), ((Collection)P_1.getValue()).size()));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(382)]
			internal _1(Keys P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
			internal override Multiset multiset()
			{
				return this_00241;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TK;>;>;")]
			[LineNumberTable(391)]
			public override Iterator iterator()
			{
				Iterator result = this_00241.entryIterator();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(396)]
			public override int size()
			{
				int result = this_00241.this_00240.keySet().size();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(408)]
			public override bool removeAll(Collection P_0)
			{
				bool result = removeEntriesIf(Predicates.@in(P_0));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(413)]
			public override bool retainAll(Collection P_0)
			{
				bool result = removeEntriesIf(Predicates.not(Predicates.@in(P_0)));
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal FilteredEntryMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 236, 103, 105 })]
		internal Keys(FilteredEntryMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 242, 108, 99, 138, 124, 99, 162, 98, 98,
			103, 104, 104, 112, 100, 100, 166, 98
		})]
		public override int remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, int P_1)
		{
			CollectPreconditions.checkNonnegative(P_1, "occurrences");
			if (P_1 == 0)
			{
				int result = count(P_0);
				_ = null;
				return result;
			}
			Collection collection = (Collection)this_00240.unfiltered.asMap().get(P_0);
			if (collection == null)
			{
				return 0;
			}
			int num = 0;
			Iterator iterator = collection.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (access_0024000(this_00240, P_0, obj))
				{
					num++;
					if (num <= P_1)
					{
						iterator.remove();
					}
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TK;>;>;")]
		[LineNumberTable(382)]
		public override Set entrySet()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}
	}

	[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<TV;>;")]
	[Implements(new string[] { "com.google.common.base.Predicate" })]
	internal sealed class ValuePredicate : Object, com.google.common.@base.Predicate, java.util.function.Predicate
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object key;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal FilteredEntryMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)V")]
		[LineNumberTable(new byte[] { 29, 111, 103 })]
		internal ValuePredicate([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] FilteredEntryMultimap P_0, object P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			key = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)Z")]
		[LineNumberTable(85)]
		public virtual bool apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			bool result = access_0024000(this_00240, key, P_0);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool test(object P_0)
		{
			return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}

		bool com.google.common.@base.Predicate.Predicate_003A_003Aequals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}
	}

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Multimap<TK;TV;>;")]
	internal Multimap unfiltered;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal com.google.common.@base.Predicate predicate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;Lcom/google/common/base/Predicate<-TE;>;)Ljava/util/Collection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 101, 0, 0 })]
	[LineNumberTable(new byte[] { 41, 104, 143 })]
	internal static Collection filterCollection(Collection P_0, com.google.common.@base.Predicate P_1)
	{
		if (P_0 is Set)
		{
			Set result = Sets.filter((Set)P_0, P_1);
			_ = null;
			return result;
		}
		Collection result2 = Collections2.filter(P_0, P_1);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;)Z")]
	[LineNumberTable(new byte[]
	{
		101, 118, 98, 107, 108, 103, 121, 121, 121, 136,
		135, 130, 101
	})]
	internal virtual bool removeEntriesIf(com.google.common.@base.Predicate P_0)
	{
		Iterator iterator = this.unfiltered.asMap().entrySet().iterator();
		int result = 0;
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			object key = entry.getKey();
			Collection collection = filterCollection((Collection)entry.getValue(), new ValuePredicate(this, key));
			if (!collection.isEmpty() && P_0.apply(Maps.immutableEntry(key, collection)))
			{
				if (collection.size() == ((Collection)entry.getValue()).size())
				{
					iterator.remove();
				}
				else
				{
					collection.clear();
				}
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 67, 109 })]
	public override void clear()
	{
		entries().clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(47)]
	internal static bool access_0024000(FilteredEntryMultimap P_0, object P_1, object P_2)
	{
		bool result = P_0.satisfies(P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)Z")]
	[LineNumberTable(73)]
	private bool satisfies([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		bool result = predicate.apply(Maps.immutableEntry(P_0, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 60, 109, 103, 5 })]
	internal virtual Collection unmodifiableEmptyCollection()
	{
		Collection obj = ((!(this.unfiltered is SetMultimap)) ? ((Collection)Collections.emptyList()) : ((Collection)Collections.emptySet()));
		Collection result = ((obj == null) ? null : ((obj as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multimap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
	[LineNumberTable(new byte[] { 2, 104, 113, 113 })]
	internal FilteredEntryMultimap(Multimap P_0, com.google.common.@base.Predicate P_1)
	{
		this.unfiltered = (Multimap)Preconditions.checkNotNull(P_0);
		predicate = (com.google.common.@base.Predicate)Preconditions.checkNotNull(P_1);
	}

	[Signature("()Lcom/google/common/collect/Multimap<TK;TV;>;")]
	public virtual Multimap unfiltered()
	{
		return this.unfiltered;
	}

	[Signature("()Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;")]
	public virtual com.google.common.@base.Predicate entryPredicate()
	{
		return predicate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	public override int size()
	{
		int result = entries().size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(100)]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return asMap().get(P_0) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(105)]
	public override Collection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (Collection)MoreObjects.firstNonNull((Collection)asMap().remove(P_0), unmodifiableEmptyCollection());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(122)]
	public override Collection get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Collection result = filterCollection(this.unfiltered.get(P_0), new ValuePredicate(this, P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(127)]
	internal override Collection createEntries()
	{
		Collection result = filterCollection(this.unfiltered.entries(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(132)]
	internal override Collection createValues()
	{
		FilteredMultimapValues result = new FilteredMultimapValues(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(137)]
	internal override Iterator entryIterator()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(142)]
	internal override Map createAsMap()
	{
		AsMap result = new AsMap(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(147)]
	internal override Set createKeySet()
	{
		Set result = asMap().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
	[LineNumberTable(345)]
	internal override Multiset createKeys()
	{
		Keys result = new Keys(this);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		Multimap._003Cdefault_003EforEach(this, P_0);
	}
}
