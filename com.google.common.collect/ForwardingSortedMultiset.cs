using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMultiset<TE;>;Lcom/google/common/collect/SortedMultiset<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 108, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)108,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SortedMultiset" })]
public abstract class ForwardingSortedMultiset : ForwardingMultiset, SortedMultiset, SortedMultisetBridge, Multiset, Collection, Iterable, IEnumerable, SortedIterable
{
	[InnerClass(null, Modifiers.Protected | Modifiers.Abstract)]
	[Signature("Lcom/google/common/collect/DescendingMultiset<TE;>;")]
	public abstract class StandardDescendingMultiset : DescendingMultiset
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ForwardingSortedMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(107)]
		public StandardDescendingMultiset(ForwardingSortedMultiset this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
		internal override SortedMultiset forwardMultiset()
		{
			return this_00240;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|comparator", "()Ljava.util.Comparator;")]
		public new Comparator comparator()
		{
			return ((DescendingMultiset)this).comparator();
		}

		[HideFromJava]
		protected internal Comparator _003Cnonvirtual_003E0()
		{
			return base.comparator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|elementSet", "()Ljava.util.NavigableSet;")]
		public new NavigableSet elementSet()
		{
			return ((DescendingMultiset)this).elementSet();
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E1()
		{
			return base.elementSet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|pollFirstEntry", "()Lcom.google.common.collect.Multiset$Entry;")]
		public new Multiset.Entry pollFirstEntry()
		{
			return ((DescendingMultiset)this).pollFirstEntry();
		}

		[HideFromJava]
		protected internal Multiset.Entry _003Cnonvirtual_003E2()
		{
			return base.pollFirstEntry();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|pollLastEntry", "()Lcom.google.common.collect.Multiset$Entry;")]
		public new Multiset.Entry pollLastEntry()
		{
			return ((DescendingMultiset)this).pollLastEntry();
		}

		[HideFromJava]
		protected internal Multiset.Entry _003Cnonvirtual_003E3()
		{
			return base.pollLastEntry();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|headMultiset", "(Ljava.lang.Object;Lcom.google.common.collect.BoundType;)Lcom.google.common.collect.SortedMultiset;")]
		public new SortedMultiset headMultiset(object P_0, BoundType P_1)
		{
			return ((DescendingMultiset)this).headMultiset(P_0, P_1);
		}

		[HideFromJava]
		protected internal SortedMultiset _003Cnonvirtual_003E4(object P_0, BoundType P_1)
		{
			return base.headMultiset(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|subMultiset", "(Ljava.lang.Object;Lcom.google.common.collect.BoundType;Ljava.lang.Object;Lcom.google.common.collect.BoundType;)Lcom.google.common.collect.SortedMultiset;")]
		public new SortedMultiset subMultiset(object P_0, BoundType P_1, object P_2, BoundType P_3)
		{
			return ((DescendingMultiset)this).subMultiset(P_0, P_1, P_2, P_3);
		}

		[HideFromJava]
		protected internal SortedMultiset _003Cnonvirtual_003E5(object P_0, BoundType P_1, object P_2, BoundType P_3)
		{
			return base.subMultiset(P_0, P_1, P_2, P_3);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|tailMultiset", "(Ljava.lang.Object;Lcom.google.common.collect.BoundType;)Lcom.google.common.collect.SortedMultiset;")]
		public new SortedMultiset tailMultiset(object P_0, BoundType P_1)
		{
			return ((DescendingMultiset)this).tailMultiset(P_0, P_1);
		}

		[HideFromJava]
		protected internal SortedMultiset _003Cnonvirtual_003E6(object P_0, BoundType P_1)
		{
			return base.tailMultiset(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|delegate", "()Lcom.google.common.collect.Multiset;")]
		protected internal new Multiset @delegate()
		{
			return ((DescendingMultiset)this).@delegate();
		}

		[HideFromJava]
		protected internal Multiset _003Cnonvirtual_003E7()
		{
			return base.@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>8|descendingMultiset", "()Lcom.google.common.collect.SortedMultiset;")]
		public new SortedMultiset descendingMultiset()
		{
			return ((DescendingMultiset)this).descendingMultiset();
		}

		[HideFromJava]
		protected internal SortedMultiset _003Cnonvirtual_003E8()
		{
			return base.descendingMultiset();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>9|firstEntry", "()Lcom.google.common.collect.Multiset$Entry;")]
		public new Multiset.Entry firstEntry()
		{
			return ((DescendingMultiset)this).firstEntry();
		}

		[HideFromJava]
		protected internal Multiset.Entry _003Cnonvirtual_003E9()
		{
			return base.firstEntry();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>10|lastEntry", "()Lcom.google.common.collect.Multiset$Entry;")]
		public new Multiset.Entry lastEntry()
		{
			return ((DescendingMultiset)this).lastEntry();
		}

		[HideFromJava]
		protected internal Multiset.Entry _003Cnonvirtual_003E10()
		{
			return base.lastEntry();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>11|entrySet", "()Ljava.util.Set;")]
		public new Set entrySet()
		{
			return ((DescendingMultiset)this).entrySet();
		}

		[HideFromJava]
		protected internal Set _003Cnonvirtual_003E11()
		{
			return base.entrySet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>12|iterator", "()Ljava.util.Iterator;")]
		public new Iterator iterator()
		{
			return ((DescendingMultiset)this).iterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E12()
		{
			return base.iterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>13|toArray", "()[Ljava.lang.Object;")]
		public new object[] toArray()
		{
			return ((DescendingMultiset)this).toArray();
		}

		[HideFromJava]
		protected internal object[] _003Cnonvirtual_003E13()
		{
			return base.toArray();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>14|toArray", "([Ljava.lang.Object;)[Ljava.lang.Object;")]
		public new object[] toArray(object[] P_0)
		{
			return ((DescendingMultiset)this).toArray(P_0);
		}

		[HideFromJava]
		protected internal object[] _003Cnonvirtual_003E14(object[] P_0)
		{
			return base.toArray(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>15|toString", "()Ljava.lang.String;")]
		public new string toString()
		{
			return ((DescendingMultiset)this).toString();
		}

		[HideFromJava]
		protected internal string _003Cnonvirtual_003E15()
		{
			return base.toString();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>16|elementSet", "()Ljava.util.Set;")]
		public Set _003Cbridge_003EelementSet()
		{
			return ((DescendingMultiset)this).elementSet();
		}

		[HideFromJava]
		protected internal Set _003Cnonvirtual_003E16()
		{
			return base.elementSet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>17|delegate", "()Ljava.util.Collection;")]
		protected internal new Collection _003Cbridge_003Edelegate()
		{
			return ((DescendingMultiset)this).@delegate();
		}

		[HideFromJava]
		protected internal Collection _003Cnonvirtual_003E17()
		{
			return base.@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>18|delegate", "()Ljava.lang.Object;")]
		protected internal new object _003Cbridge_003Edelegate()
		{
			return ((DescendingMultiset)this).@delegate();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E18()
		{
			return base.@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>19|elementSet", "()Ljava.util.SortedSet;")]
		public SortedSet _003Cbridge_003EelementSet()
		{
			return ((DescendingMultiset)this).elementSet();
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E19()
		{
			return base.elementSet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>20|forEach", "(Ljava.util.function.Consumer;)V")]
		public new void forEach(Consumer P_0)
		{
			((DescendingMultiset)this).forEach(P_0);
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E20(Consumer P_0)
		{
			base.forEach(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>21|spliterator", "()Ljava.util.Spliterator;")]
		public new Spliterator spliterator()
		{
			return ((DescendingMultiset)this).spliterator();
		}

		[HideFromJava]
		protected internal Spliterator _003Cnonvirtual_003E21()
		{
			return base.spliterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>22|removeIf", "(Ljava.util.function.Predicate;)Z")]
		public new bool removeIf(Predicate P_0)
		{
			return ((DescendingMultiset)this).removeIf(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E22(Predicate P_0)
		{
			return base.removeIf(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>23|stream", "()Ljava.util.stream.Stream;")]
		public new Stream stream()
		{
			return ((DescendingMultiset)this).stream();
		}

		[HideFromJava]
		protected internal Stream _003Cnonvirtual_003E23()
		{
			return base.stream();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>24|parallelStream", "()Ljava.util.stream.Stream;")]
		public new Stream parallelStream()
		{
			return ((DescendingMultiset)this).parallelStream();
		}

		[HideFromJava]
		protected internal Stream _003Cnonvirtual_003E24()
		{
			return base.parallelStream();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>25|forEachEntry", "(Ljava.util.function.ObjIntConsumer;)V")]
		public new void forEachEntry(ObjIntConsumer P_0)
		{
			((DescendingMultiset)this).forEachEntry(P_0);
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E25(ObjIntConsumer P_0)
		{
			base.forEachEntry(P_0);
		}
	}

	[InnerClass(null, Modifiers.Protected)]
	[Signature("Lcom/google/common/collect/SortedMultisets$NavigableElementSet<TE;>;")]
	public new class StandardElementSet : SortedMultisets.NavigableElementSet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 29, 105 })]
		public StandardElementSet(ForwardingSortedMultiset this_00240)
			: base(this_00240)
		{
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|lower", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object lower(object P_0)
		{
			return ((SortedMultisets.NavigableElementSet)this).lower(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E0(object P_0)
		{
			return base.lower(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|floor", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object floor(object P_0)
		{
			return ((SortedMultisets.NavigableElementSet)this).floor(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E1(object P_0)
		{
			return base.floor(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|ceiling", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object ceiling(object P_0)
		{
			return ((SortedMultisets.NavigableElementSet)this).ceiling(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E2(object P_0)
		{
			return base.ceiling(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|higher", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object higher(object P_0)
		{
			return ((SortedMultisets.NavigableElementSet)this).higher(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E3(object P_0)
		{
			return base.higher(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|descendingSet", "()Ljava.util.NavigableSet;")]
		public new NavigableSet descendingSet()
		{
			return ((SortedMultisets.NavigableElementSet)this).descendingSet();
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E4()
		{
			return base.descendingSet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|descendingIterator", "()Ljava.util.Iterator;")]
		public new Iterator descendingIterator()
		{
			return ((SortedMultisets.NavigableElementSet)this).descendingIterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E5()
		{
			return base.descendingIterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|pollFirst", "()Ljava.lang.Object;")]
		public new object pollFirst()
		{
			return ((SortedMultisets.NavigableElementSet)this).pollFirst();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E6()
		{
			return base.pollFirst();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|pollLast", "()Ljava.lang.Object;")]
		public new object pollLast()
		{
			return ((SortedMultisets.NavigableElementSet)this).pollLast();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E7()
		{
			return base.pollLast();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>8|subSet", "(Ljava.lang.Object;ZLjava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet subSet(object P_0, bool P_1, object P_2, bool P_3)
		{
			return ((SortedMultisets.NavigableElementSet)this).subSet(P_0, P_1, P_2, P_3);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E8(object P_0, bool P_1, object P_2, bool P_3)
		{
			return base.subSet(P_0, P_1, P_2, P_3);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>9|headSet", "(Ljava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet headSet(object P_0, bool P_1)
		{
			return ((SortedMultisets.NavigableElementSet)this).headSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E9(object P_0, bool P_1)
		{
			return base.headSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>10|tailSet", "(Ljava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet tailSet(object P_0, bool P_1)
		{
			return ((SortedMultisets.NavigableElementSet)this).tailSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E10(object P_0, bool P_1)
		{
			return base.tailSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>11|iterator", "()Ljava.util.Iterator;")]
		public new Iterator iterator()
		{
			return ((SortedMultisets.ElementSet)this).iterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E11()
		{
			return base.iterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>12|comparator", "()Ljava.util.Comparator;")]
		public new Comparator comparator()
		{
			return ((SortedMultisets.ElementSet)this).comparator();
		}

		[HideFromJava]
		protected internal Comparator _003Cnonvirtual_003E12()
		{
			return base.comparator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>13|subSet", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet subSet(object P_0, object P_1)
		{
			return ((SortedMultisets.ElementSet)this).subSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E13(object P_0, object P_1)
		{
			return base.subSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>14|headSet", "(Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet headSet(object P_0)
		{
			return ((SortedMultisets.ElementSet)this).headSet(P_0);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E14(object P_0)
		{
			return base.headSet(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>15|tailSet", "(Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet tailSet(object P_0)
		{
			return ((SortedMultisets.ElementSet)this).tailSet(P_0);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E15(object P_0)
		{
			return base.tailSet(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>16|first", "()Ljava.lang.Object;")]
		public new object first()
		{
			return ((SortedMultisets.ElementSet)this).first();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E16()
		{
			return base.first();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>17|last", "()Ljava.lang.Object;")]
		public new object last()
		{
			return ((SortedMultisets.ElementSet)this).last();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E17()
		{
			return base.last();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>18|clear", "()V")]
		public new void clear()
		{
			((Multisets.ElementSet)this).clear();
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E18()
		{
			base.clear();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>19|contains", "(Ljava.lang.Object;)Z")]
		public new bool contains(object P_0)
		{
			return ((Multisets.ElementSet)this).contains(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E19(object P_0)
		{
			return base.contains(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>20|containsAll", "(Ljava.util.Collection;)Z")]
		public new bool containsAll(Collection P_0)
		{
			return ((Multisets.ElementSet)this).containsAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E20(Collection P_0)
		{
			return base.containsAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>21|isEmpty", "()Z")]
		public new bool isEmpty()
		{
			return ((Multisets.ElementSet)this).isEmpty();
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E21()
		{
			return base.isEmpty();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>22|remove", "(Ljava.lang.Object;)Z")]
		public new bool remove(object P_0)
		{
			return ((Multisets.ElementSet)this).remove(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E22(object P_0)
		{
			return base.remove(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>23|size", "()I")]
		public new int size()
		{
			return ((Multisets.ElementSet)this).size();
		}

		[HideFromJava]
		protected internal int _003Cnonvirtual_003E23()
		{
			return base.size();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>24|removeAll", "(Ljava.util.Collection;)Z")]
		public new bool removeAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).removeAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E24(Collection P_0)
		{
			return base.removeAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>25|retainAll", "(Ljava.util.Collection;)Z")]
		public new bool retainAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).retainAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E25(Collection P_0)
		{
			return base.retainAll(P_0);
		}
	}

	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	protected internal new abstract SortedMultiset @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(90)]
	public virtual SortedMultiset descendingMultiset()
	{
		SortedMultiset result = @delegate().descendingMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(241)]
	public virtual SortedMultiset tailMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object lowerBound, BoundType boundType)
	{
		SortedMultiset result = @delegate().tailMultiset(lowerBound, boundType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(60)]
	public new virtual NavigableSet elementSet()
	{
		NavigableSet result = @delegate().elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	protected internal ForwardingSortedMultiset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TE;>;")]
	[LineNumberTable(85)]
	public virtual Comparator comparator()
	{
		Comparator result = @delegate().comparator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(118)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry firstEntry()
	{
		Multiset.Entry result = @delegate().firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(new byte[] { 79, 108, 104, 130, 108 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Multiset.Entry standardFirstEntry()
	{
		Iterator iterator = entrySet().iterator();
		if (!iterator.hasNext())
		{
			return null;
		}
		Multiset.Entry entry = (Multiset.Entry)iterator.next();
		Multiset.Entry result = Multisets.immutableEntry(entry.getElement(), entry.getCount());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(140)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry lastEntry()
	{
		Multiset.Entry result = @delegate().lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(new byte[] { 102, 113, 104, 130, 108 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Multiset.Entry standardLastEntry()
	{
		Iterator iterator = descendingMultiset().entrySet().iterator();
		if (!iterator.hasNext())
		{
			return null;
		}
		Multiset.Entry entry = (Multiset.Entry)iterator.next();
		Multiset.Entry result = Multisets.immutableEntry(entry.getElement(), entry.getCount());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(163)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry pollFirstEntry()
	{
		Multiset.Entry result = @delegate().pollFirstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(new byte[] { 124, 108, 104, 130, 108, 114, 102 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Multiset.Entry standardPollFirstEntry()
	{
		Iterator iterator = entrySet().iterator();
		if (!iterator.hasNext())
		{
			return null;
		}
		Multiset.Entry entry = (Multiset.Entry)iterator.next();
		entry = Multisets.immutableEntry(entry.getElement(), entry.getCount());
		iterator.remove();
		return entry;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(187)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry pollLastEntry()
	{
		Multiset.Entry result = @delegate().pollLastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(new byte[] { 160, 85, 113, 104, 130, 108, 114, 102 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Multiset.Entry standardPollLastEntry()
	{
		Iterator iterator = descendingMultiset().entrySet().iterator();
		if (!iterator.hasNext())
		{
			return null;
		}
		Multiset.Entry entry = (Multiset.Entry)iterator.next();
		entry = Multisets.immutableEntry(entry.getElement(), entry.getCount());
		iterator.remove();
		return entry;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(211)]
	public virtual SortedMultiset headMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object upperBound, BoundType boundType)
	{
		SortedMultiset result = @delegate().headMultiset(upperBound, boundType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(220)]
	public virtual SortedMultiset subMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object lowerBound, BoundType lowerBoundType, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object upperBound, BoundType upperBoundType)
	{
		SortedMultiset result = @delegate().subMultiset(lowerBound, lowerBoundType, upperBound, upperBoundType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(236)]
	protected internal virtual SortedMultiset standardSubMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object lowerBound, BoundType lowerBoundType, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object upperBound, BoundType upperBoundType)
	{
		SortedMultiset result = tailMultiset(lowerBound, lowerBoundType).headMultiset(upperBound, upperBoundType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(47)]
	public virtual Set _003Cbridge_003EelementSet()
	{
		NavigableSet result = elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(47)]
	protected internal new virtual Multiset _003Cbridge_003Edelegate()
	{
		SortedMultiset result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(47)]
	protected internal override Collection _003Cbridge_003Edelegate()
	{
		SortedMultiset result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(47)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		SortedMultiset result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(47)]
	public virtual SortedSet _003Cbridge_003EelementSet()
	{
		NavigableSet result = elementSet();
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
	public override bool removeIf(Predicate P_0)
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
	public override void forEachEntry(ObjIntConsumer P_0)
	{
		Multiset._003Cdefault_003EforEachEntry(this, P_0);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	SortedSet SortedMultisetBridge.SortedMultisetBridge_003A_003AelementSet()
	{
		return this._003Cbridge_003EelementSet();
	}

	Set SortedMultisetBridge.SortedMultisetBridge_003A_003AelementSet()
	{
		return this._003Cbridge_003EelementSet();
	}

	Set Multiset.Multiset_003A_003AelementSet()
	{
		return this._003Cbridge_003EelementSet();
	}
}
