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
	0, 2, 17, 0, 0, 0, 0, 124, 0, 0,
	17, 1, 0, 0, 0, 124, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)124,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.FilteredMultimap" })]
internal class FilteredKeyMultimap : AbstractMultimap, FilteredMultimap, Multimap
{
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingList<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 69, 0, 0,
		17, 1, 0, 0, 0, 69, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)69,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class AddRejectingList : ForwardingList
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object key;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)V")]
		[LineNumberTable(new byte[] { 95, 104, 103 })]
		internal AddRejectingList([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			key = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITV;)V")]
		[LineNumberTable(new byte[] { 107, 104 })]
		public override void add(int P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			Preconditions.checkPositionIndex(P_0, 0);
			string text = String.valueOf(key);
			int num = 32 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("Key does not satisfy predicate: ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILjava/util/Collection<+TV;>;)Z")]
		[LineNumberTable(new byte[] { 120, 103, 104 })]
		public override bool addAll(int P_0, Collection P_1)
		{
			Preconditions.checkNotNull(P_1);
			Preconditions.checkPositionIndex(P_0, 0);
			string text = String.valueOf(key);
			int num = 32 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("Key does not satisfy predicate: ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<TV;>;")]
		[LineNumberTable(177)]
		protected internal override List @delegate()
		{
			List result = Collections.emptyList();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)Z")]
		[LineNumberTable(new byte[] { 101, 104 })]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			add(0, P_0);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TV;>;)Z")]
		[LineNumberTable(new byte[] { 113, 105 })]
		public override bool addAll(Collection P_0)
		{
			addAll(0, P_0);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(141)]
		protected internal new virtual Collection @delegate()
		{
			List result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(141)]
		protected internal new virtual object @delegate()
		{
			List result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingSet<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 56, 0, 0,
		17, 1, 0, 0, 0, 56, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)56,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class AddRejectingSet : ForwardingSet
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object key;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)V")]
		[LineNumberTable(new byte[] { 70, 104, 103 })]
		internal AddRejectingSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			key = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(137)]
		protected internal override Set @delegate()
		{
			Set result = Collections.emptySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)Z")]
		[LineNumberTable(126)]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			string text = String.valueOf(key);
			int num = 32 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("Key does not satisfy predicate: ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TV;>;)Z")]
		[LineNumberTable(new byte[] { 81, 103 })]
		public override bool addAll(Collection P_0)
		{
			Preconditions.checkNotNull(P_0);
			string text = String.valueOf(key);
			int num = 32 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("Key does not satisfy predicate: ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(116)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(116)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[Signature("Lcom/google/common/collect/ForwardingCollection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal new class Entries : ForwardingCollection
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal FilteredKeyMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(192)]
		internal Entries(FilteredKeyMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(195)]
		protected internal override Collection @delegate()
		{
			Collection result = Collections2.filter(this_00240.unfiltered.entries(), this_00240.entryPredicate());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 87, 104, 103, 159, 5, 108, 191, 0 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				if (this_00240.unfiltered.containsKey(entry.getKey()) && this_00240.keyPredicate.apply(entry.getKey()))
				{
					bool result = this_00240.unfiltered.remove(entry.getKey(), entry.getValue());
					_ = null;
					return result;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(191)]
		protected internal new virtual object @delegate()
		{
			Collection result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Multimap<TK;TV;>;")]
	internal Multimap unfiltered;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/base/Predicate<-TK;>;")]
	internal com.google.common.@base.Predicate keyPredicate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 24, 142, 98, 143 })]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (this.unfiltered.containsKey(P_0))
		{
			bool result = keyPredicate.apply(P_0);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 38, 109, 136 })]
	internal virtual Collection unmodifiableEmptyCollection()
	{
		if (this.unfiltered is SetMultimap)
		{
			Set result = Collections.emptySet();
			_ = null;
			return result;
		}
		List result2 = Collections.emptyList();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multimap<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)V")]
	[LineNumberTable(new byte[] { 159, 190, 104, 113, 113 })]
	internal FilteredKeyMultimap(Multimap P_0, com.google.common.@base.Predicate P_1)
	{
		this.unfiltered = (Multimap)Preconditions.checkNotNull(P_0);
		keyPredicate = (com.google.common.@base.Predicate)Preconditions.checkNotNull(P_1);
	}

	[Signature("()Lcom/google/common/collect/Multimap<TK;TV;>;")]
	public virtual Multimap unfiltered()
	{
		return this.unfiltered;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(60)]
	public virtual com.google.common.@base.Predicate entryPredicate()
	{
		com.google.common.@base.Predicate result = Maps.keyPredicateOnEntries(keyPredicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 98, 127, 6, 105, 98 })]
	public override int size()
	{
		int num = 0;
		Iterator iterator = asMap().values().iterator();
		while (iterator.hasNext())
		{
			Collection collection = (Collection)iterator.next();
			num += collection.size();
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(84)]
	public override Collection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Collection result = ((!containsKey(P_0)) ? unmodifiableEmptyCollection() : this.unfiltered.removeAll(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 47, 109 })]
	public override void clear()
	{
		keySet().clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(102)]
	internal override Set createKeySet()
	{
		Set result = Sets.filter(this.unfiltered.keySet(), keyPredicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 57, 110, 111, 109, 137 })]
	public override Collection get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		if (keyPredicate.apply(P_0))
		{
			Collection result = this.unfiltered.get(P_0);
			_ = null;
			return result;
		}
		if (this.unfiltered is SetMultimap)
		{
			AddRejectingSet result2 = new AddRejectingSet(P_0);
			_ = null;
			return result2;
		}
		AddRejectingList result3 = new AddRejectingList(P_0);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(183)]
	internal override Iterator entryIterator()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(188)]
	internal override Collection createEntries()
	{
		Entries result = new Entries(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(215)]
	internal override Collection createValues()
	{
		FilteredMultimapValues result = new FilteredMultimapValues(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(220)]
	internal override Map createAsMap()
	{
		Map result = Maps.filterKeys(this.unfiltered.asMap(), keyPredicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
	[LineNumberTable(225)]
	internal override Multiset createKeys()
	{
		Multiset result = Multisets.filter(this.unfiltered.keys(), keyPredicate);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		Multimap._003Cdefault_003EforEach(this, P_0);
	}
}
