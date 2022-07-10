using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingCollection<TE;>;Lcom/google/common/collect/Multiset<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 127, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)127,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Multiset" })]
public abstract class ForwardingMultiset : ForwardingCollection, Multiset, Collection, Iterable, IEnumerable
{
	[InnerClass(null, Modifiers.Protected)]
	[Signature("Lcom/google/common/collect/Multisets$ElementSet<TE;>;")]
	public class StandardElementSet : Multisets.ElementSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ForwardingMultiset this_00240;

		[Signature("()Lcom/google/common/collect/Multiset<TE;>;")]
		internal override Multiset multiset()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(249)]
		public StandardElementSet(ForwardingMultiset this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(258)]
		public override Iterator iterator()
		{
			Iterator result = Multisets.elementIterator(multiset().entrySet().iterator());
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|clear", "()V")]
		public new void clear()
		{
			((Multisets.ElementSet)this).clear();
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E0()
		{
			base.clear();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|contains", "(Ljava.lang.Object;)Z")]
		public new bool contains(object P_0)
		{
			return ((Multisets.ElementSet)this).contains(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E1(object P_0)
		{
			return base.contains(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|containsAll", "(Ljava.util.Collection;)Z")]
		public new bool containsAll(Collection P_0)
		{
			return ((Multisets.ElementSet)this).containsAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E2(Collection P_0)
		{
			return base.containsAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|isEmpty", "()Z")]
		public new bool isEmpty()
		{
			return ((Multisets.ElementSet)this).isEmpty();
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E3()
		{
			return base.isEmpty();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|remove", "(Ljava.lang.Object;)Z")]
		public new bool remove(object P_0)
		{
			return ((Multisets.ElementSet)this).remove(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E4(object P_0)
		{
			return base.remove(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|size", "()I")]
		public new int size()
		{
			return ((Multisets.ElementSet)this).size();
		}

		[HideFromJava]
		protected internal int _003Cnonvirtual_003E5()
		{
			return base.size();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|removeAll", "(Ljava.util.Collection;)Z")]
		public new bool removeAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).removeAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E6(Collection P_0)
		{
			return base.removeAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|retainAll", "(Ljava.util.Collection;)Z")]
		public new bool retainAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).retainAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E7(Collection P_0)
		{
			return base.retainAll(P_0);
		}
	}

	[Signature("()Lcom/google/common/collect/Multiset<TE;>;")]
	protected internal new abstract Multiset @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	public virtual int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		int result = @delegate().count(element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(86)]
	public virtual Set entrySet()
	{
		Set result = @delegate().entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(70)]
	public virtual int add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, int occurrences)
	{
		int result = @delegate().add(element, occurrences);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	public virtual int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element, int occurrences)
	{
		int result = @delegate().remove(element, occurrences);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	protected internal ForwardingMultiset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(81)]
	public virtual Set elementSet()
	{
		Set result = @delegate().elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(91)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		return (@object == this || @delegate().equals(@object)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	public override int hashCode()
	{
		int result = @delegate().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(102)]
	public virtual int setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, int count)
	{
		int result = @delegate().setCount(element, count);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;II)Z")]
	[LineNumberTable(108)]
	public virtual bool setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, int oldCount, int newCount)
	{
		bool result = @delegate().setCount(element, oldCount, newCount);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(119)]
	protected internal override bool standardContains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		return count(@object) > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 81, 114 })]
	protected internal override void standardClear()
	{
		Iterators.clear(entrySet().iterator());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 93, 127, 1, 110, 137, 98 })]
	protected internal virtual int standardCount([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		Iterator iterator = entrySet().iterator();
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			if (com.google.common.@base.Objects.equal(entry.getElement(), @object))
			{
				int result = entry.getCount();
				_ = null;
				return result;
			}
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[] { 109, 105 })]
	protected internal virtual bool standardAdd([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element)
	{
		add(element, 1);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+TE;>;)Z")]
	[LineNumberTable(173)]
	protected internal override bool standardAddAll(Collection elementsToAdd)
	{
		bool result = Multisets.addAllImpl(this, elementsToAdd);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(185)]
	protected internal override bool standardRemove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		return remove(element, 1) > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(197)]
	protected internal override bool standardRemoveAll(Collection elementsToRemove)
	{
		bool result = Multisets.removeAllImpl(this, elementsToRemove);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(209)]
	protected internal override bool standardRetainAll(Collection elementsToRetain)
	{
		bool result = Multisets.retainAllImpl(this, elementsToRetain);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(221)]
	protected internal virtual int standardSetCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, int count)
	{
		int result = Multisets.setCountImpl(this, element, count);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;II)Z")]
	[LineNumberTable(232)]
	protected internal virtual bool standardSetCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, int oldCount, int newCount)
	{
		bool result = Multisets.setCountImpl(this, element, oldCount, newCount);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(270)]
	protected internal virtual Iterator standardIterator()
	{
		Iterator result = Multisets.iteratorImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(281)]
	protected internal virtual int standardSize()
	{
		int result = Multisets.linearTimeSizeImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(292)]
	protected internal virtual bool standardEquals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		bool result = Multisets.equalsImpl(this, @object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(303)]
	protected internal virtual int standardHashCode()
	{
		int result = entrySet().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(315)]
	protected internal override string standardToString()
	{
		string result = Object.instancehelper_toString(entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	protected internal new virtual Collection _003Cbridge_003Edelegate()
	{
		Multiset result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		Multiset result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(Consumer P_0)
	{
		Multiset._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Spliterator spliterator()
	{
		return Multiset._003Cdefault_003Espliterator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool removeIf(java.util.function.Predicate P_0)
	{
		return Collection._003Cdefault_003EremoveIf(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Stream stream()
	{
		return Collection._003Cdefault_003Estream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Stream parallelStream()
	{
		return Collection._003Cdefault_003EparallelStream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEachEntry(ObjIntConsumer P_0)
	{
		Multiset._003Cdefault_003EforEachEntry(this, P_0);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}
}
