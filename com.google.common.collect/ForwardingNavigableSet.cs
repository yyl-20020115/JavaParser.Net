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

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingSortedSet<TE;>;Ljava/util/NavigableSet<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 102, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)102,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.NavigableSet" })]
public abstract class ForwardingNavigableSet : ForwardingSortedSet, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable
{
	[InnerClass(null, Modifiers.Protected)]
	[Signature("Lcom/google/common/collect/Sets$DescendingSet<TE;>;")]
	public class StandardDescendingSet : Sets.DescendingSet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 74, 105 })]
		public StandardDescendingSet(ForwardingNavigableSet this_00240)
			: base(this_00240)
		{
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|delegate", "()Ljava.util.NavigableSet;")]
		protected internal new NavigableSet @delegate()
		{
			return ((Sets.DescendingSet)this).@delegate();
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E0()
		{
			return base.@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|lower", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object lower(object P_0)
		{
			return ((Sets.DescendingSet)this).lower(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E1(object P_0)
		{
			return base.lower(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|floor", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object floor(object P_0)
		{
			return ((Sets.DescendingSet)this).floor(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E2(object P_0)
		{
			return base.floor(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|ceiling", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object ceiling(object P_0)
		{
			return ((Sets.DescendingSet)this).ceiling(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E3(object P_0)
		{
			return base.ceiling(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|higher", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object higher(object P_0)
		{
			return ((Sets.DescendingSet)this).higher(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E4(object P_0)
		{
			return base.higher(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|pollFirst", "()Ljava.lang.Object;")]
		public new object pollFirst()
		{
			return ((Sets.DescendingSet)this).pollFirst();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E5()
		{
			return base.pollFirst();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|pollLast", "()Ljava.lang.Object;")]
		public new object pollLast()
		{
			return ((Sets.DescendingSet)this).pollLast();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E6()
		{
			return base.pollLast();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|descendingSet", "()Ljava.util.NavigableSet;")]
		public new NavigableSet descendingSet()
		{
			return ((Sets.DescendingSet)this).descendingSet();
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E7()
		{
			return base.descendingSet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>8|descendingIterator", "()Ljava.util.Iterator;")]
		public new Iterator descendingIterator()
		{
			return ((Sets.DescendingSet)this).descendingIterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E8()
		{
			return base.descendingIterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>9|subSet", "(Ljava.lang.Object;ZLjava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet subSet(object P_0, bool P_1, object P_2, bool P_3)
		{
			return ((Sets.DescendingSet)this).subSet(P_0, P_1, P_2, P_3);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E9(object P_0, bool P_1, object P_2, bool P_3)
		{
			return base.subSet(P_0, P_1, P_2, P_3);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>10|subSet", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet subSet(object P_0, object P_1)
		{
			return ((Sets.DescendingSet)this).subSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E10(object P_0, object P_1)
		{
			return base.subSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>11|headSet", "(Ljava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet headSet(object P_0, bool P_1)
		{
			return ((Sets.DescendingSet)this).headSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E11(object P_0, bool P_1)
		{
			return base.headSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>12|headSet", "(Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet headSet(object P_0)
		{
			return ((Sets.DescendingSet)this).headSet(P_0);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E12(object P_0)
		{
			return base.headSet(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>13|tailSet", "(Ljava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet tailSet(object P_0, bool P_1)
		{
			return ((Sets.DescendingSet)this).tailSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E13(object P_0, bool P_1)
		{
			return base.tailSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>14|tailSet", "(Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet tailSet(object P_0)
		{
			return ((Sets.DescendingSet)this).tailSet(P_0);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E14(object P_0)
		{
			return base.tailSet(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>15|comparator", "()Ljava.util.Comparator;")]
		public new Comparator comparator()
		{
			return ((Sets.DescendingSet)this).comparator();
		}

		[HideFromJava]
		protected internal Comparator _003Cnonvirtual_003E15()
		{
			return base.comparator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>16|first", "()Ljava.lang.Object;")]
		public new object first()
		{
			return ((Sets.DescendingSet)this).first();
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
			return ((Sets.DescendingSet)this).last();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E17()
		{
			return base.last();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>18|iterator", "()Ljava.util.Iterator;")]
		public new Iterator iterator()
		{
			return ((Sets.DescendingSet)this).iterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E18()
		{
			return base.iterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>19|toArray", "()[Ljava.lang.Object;")]
		public new object[] toArray()
		{
			return ((Sets.DescendingSet)this).toArray();
		}

		[HideFromJava]
		protected internal object[] _003Cnonvirtual_003E19()
		{
			return base.toArray();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>20|toArray", "([Ljava.lang.Object;)[Ljava.lang.Object;")]
		public new object[] toArray(object[] P_0)
		{
			return ((Sets.DescendingSet)this).toArray(P_0);
		}

		[HideFromJava]
		protected internal object[] _003Cnonvirtual_003E20(object[] P_0)
		{
			return base.toArray(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>21|toString", "()Ljava.lang.String;")]
		public new string toString()
		{
			return ((Sets.DescendingSet)this).toString();
		}

		[HideFromJava]
		protected internal string _003Cnonvirtual_003E21()
		{
			return base.toString();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>22|delegate", "()Ljava.util.SortedSet;")]
		protected internal new SortedSet _003Cbridge_003Edelegate()
		{
			return ((Sets.DescendingSet)this).@delegate();
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E22()
		{
			return base.@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>23|delegate", "()Ljava.util.Set;")]
		protected internal new Set _003Cbridge_003Edelegate()
		{
			return ((Sets.DescendingSet)this).@delegate();
		}

		[HideFromJava]
		protected internal Set _003Cnonvirtual_003E23()
		{
			return base.@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>24|delegate", "()Ljava.util.Collection;")]
		protected internal new Collection _003Cbridge_003Edelegate()
		{
			return ((Sets.DescendingSet)this).@delegate();
		}

		[HideFromJava]
		protected internal Collection _003Cnonvirtual_003E24()
		{
			return base.@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>25|delegate", "()Ljava.lang.Object;")]
		protected internal new object _003Cbridge_003Edelegate()
		{
			return ((Sets.DescendingSet)this).@delegate();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E25()
		{
			return base.@delegate();
		}
	}

	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	protected internal new abstract NavigableSet @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(234)]
	public virtual NavigableSet headSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toElement, bool inclusive)
	{
		NavigableSet result = @delegate().headSet(toElement, inclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(248)]
	public virtual NavigableSet tailSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromElement, bool inclusive)
	{
		NavigableSet result = @delegate().tailSet(fromElement, inclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(194)]
	public virtual Iterator descendingIterator()
	{
		Iterator result = @delegate().descendingIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(203)]
	public virtual NavigableSet subSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromElement, bool fromInclusive, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toElement, bool toInclusive)
	{
		NavigableSet result = @delegate().subSet(fromElement, fromInclusive, toElement, toInclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(59)]
	protected internal ForwardingNavigableSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(67)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object lower([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		object result = @delegate().lower(e);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(77)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardLower([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		object next = Iterators.getNext(headSet(e, inclusive: false).descendingIterator(), null);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(83)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object floor([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		object result = @delegate().floor(e);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(93)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardFloor([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		object next = Iterators.getNext(headSet(e, inclusive: true).descendingIterator(), null);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(99)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object ceiling([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		object result = @delegate().ceiling(e);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(109)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardCeiling([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		object next = Iterators.getNext(tailSet(e, inclusive: true).iterator(), null);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(115)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object higher([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		object result = @delegate().higher(e);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(125)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardHigher([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		object next = Iterators.getNext(tailSet(e, inclusive: false).iterator(), null);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(131)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object pollFirst()
	{
		object result = @delegate().pollFirst();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(141)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardPollFirst()
	{
		object result = Iterators.pollNext(iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(147)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object pollLast()
	{
		object result = @delegate().pollLast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(157)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardPollLast()
	{
		object result = Iterators.pollNext(descendingIterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(162)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	protected internal virtual object standardFirst()
	{
		object result = iterator().next();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(167)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	protected internal virtual object standardLast()
	{
		object result = descendingIterator().next();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(172)]
	public virtual NavigableSet descendingSet()
	{
		NavigableSet result = @delegate().descendingSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(217)]
	protected internal virtual NavigableSet standardSubSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromElement, bool fromInclusive, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toElement, bool toInclusive)
	{
		NavigableSet result = tailSet(fromElement, fromInclusive).headSet(toElement, toInclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
	[LineNumberTable(229)]
	protected internal override SortedSet standardSubSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromElement, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toElement)
	{
		NavigableSet result = subSet(fromElement, fromInclusive: true, toElement, toInclusive: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
	[LineNumberTable(243)]
	protected internal virtual SortedSet standardHeadSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toElement)
	{
		NavigableSet result = headSet(toElement, inclusive: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
	[LineNumberTable(257)]
	protected internal virtual SortedSet standardTailSet([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromElement)
	{
		NavigableSet result = tailSet(fromElement, inclusive: true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	protected internal new virtual SortedSet _003Cbridge_003Edelegate()
	{
		NavigableSet result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	protected internal override Set _003Cbridge_003Edelegate()
	{
		NavigableSet result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	protected internal override Collection _003Cbridge_003Edelegate()
	{
		NavigableSet result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		NavigableSet result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(Consumer P_0)
	{
		Iterable._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Spliterator spliterator()
	{
		return SortedSet._003Cdefault_003Espliterator(this);
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

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}
}
