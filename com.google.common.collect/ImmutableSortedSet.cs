using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSortedSetFauxverideShim<TE;>;Ljava/util/NavigableSet<TE;>;Lcom/google/common/collect/SortedIterable<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.NavigableSet", "com.google.common.collect.SortedIterable" })]
public abstract class ImmutableSortedSet : ImmutableSortedSetFauxverideShim, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable, SortedIterable
{
	[SpecialName]
	[Signature("Ljava/util/Spliterators$AbstractSpliterator<TE;>;")]
	[EnclosingMethod(null, "spliterator", "()Ljava.util.Spliterator;")]
	internal class _1 : Spliterators.AbstractSpliterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		internal UnmodifiableIterator iterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableSortedSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 168, 113 })]
		internal _1(ImmutableSortedSet P_0, long P_1, int P_2)
		{
			this_00240 = P_0;
			base._002Ector(P_1, P_2);
			iterator = this_00240.iterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TE;>;)Z")]
		[LineNumberTable(new byte[] { 162, 173, 109, 113, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (iterator.hasNext())
			{
				P_0.accept(iterator.next());
				return true;
			}
			return false;
		}

		[Signature("()Ljava/util/Comparator<-TE;>;")]
		[LineNumberTable(809)]
		public override Comparator getComparator()
		{
			return this_00240.comparator;
		}
	}

	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$Builder<TE;>;")]
	public new sealed class Builder : ImmutableSet.Builder
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TE;>;")]
		private Comparator comparator;

		[Signature("[TE;")]
		private object[] elements;

		private int n;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 74, 105, 113, 108, 103 })]
		public Builder(Comparator comparator)
			: base(true)
		{
			this.comparator = (Comparator)Preconditions.checkNotNull(comparator);
			elements = new object[4];
			n = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
		[LineNumberTable(new byte[]
		{
			161, 116, 103, 102, 111, 230, 70, 116, 106, 178,
			123
		})]
		public new virtual Builder add(object element)
		{
			Preconditions.checkNotNull(element);
			copyIfNecessary();
			if ((nint)n == (nint)elements.LongLength)
			{
				sortAndDedup();
				int num = ImmutableCollection.Builder.expandedCapacity(n, n + 1);
				if (num > (nint)elements.LongLength)
				{
					elements = Arrays.copyOf(elements, num);
				}
			}
			object[] array = elements;
			int num2 = n;
			n = num2 + 1;
			array[num2] = element;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableSet$Builder<TE;>;)Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 185, 102, 103, 107, 47, 166 })]
		internal new virtual Builder combine(ImmutableSet.Builder P_0)
		{
			copyIfNecessary();
			Builder builder = (Builder)P_0;
			for (int i = 0; i < builder.n; i++)
			{
				add(builder.elements[i]);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
		[LineNumberTable(new byte[] { 161, 199, 102, 104, 142, 103, 113, 50 })]
		public new virtual ImmutableSortedSet build()
		{
			sortAndDedup();
			if (n == 0)
			{
				RegularImmutableSortedSet result = emptySet(comparator);
				_ = null;
				return result;
			}
			forceCopy = true;
			RegularImmutableSortedSet.___003Cclinit_003E();
			RegularImmutableSortedSet result2 = new RegularImmutableSortedSet(ImmutableList.asImmutableList(elements, n), comparator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 178, 104 })]
		public new virtual Builder addAll(Iterator elements)
		{
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161,
			86,
			104,
			129,
			120,
			98,
			110,
			126,
			100,
			118,
			100,
			byte.MaxValue,
			50,
			59,
			233,
			73,
			115,
			103
		})]
		private void sortAndDedup()
		{
			if (n == 0)
			{
				return;
			}
			Arrays.sort(elements, 0, n, comparator);
			int num = 1;
			for (int i = 1; i < n; i++)
			{
				int num2 = comparator.compare(elements[num - 1], elements[i]);
				if (num2 < 0)
				{
					object[] array = elements;
					int num3 = num;
					num++;
					array[num3] = elements[i];
				}
				else if (num2 > 0)
				{
					string text = java.lang.String.valueOf(comparator);
					int num4 = 48 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
					num4 = num4;
					string detailMessage = new StringBuilder(num4).append("Comparator ").append(text).append(" compare method violates its contract")
						.toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new AssertionError(detailMessage);
				}
			}
			Arrays.fill(elements, num, n, null);
			n = num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 163, 104 })]
		public new virtual Builder addAll(Iterable elements)
		{
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([TE;)Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 145, 103, 111, 40, 166 })]
		public new virtual Builder add(params object[] elements)
		{
			ObjectArrays.checkElementsNotNull(elements);
			int num = elements.Length;
			for (int i = 0; i < num; i++)
			{
				object element = elements[i];
				add(element);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 82, 120 })]
		internal override void copy()
		{
			elements = Arrays.copyOf(elements, elements.Length);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public new virtual ImmutableSet _003Cbridge_003Ebuild()
		{
			ImmutableSortedSet result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(434)]
		internal override ImmutableSet.Builder combine(ImmutableSet.Builder P_0)
		{
			Builder result = combine(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public new virtual ImmutableSet.Builder _003Cbridge_003EaddAll(Iterator i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public new virtual ImmutableSet.Builder _003Cbridge_003EaddAll(Iterable i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public new virtual ImmutableSet.Builder _003Cbridge_003Eadd(object[] objarr)
		{
			Builder result = add(objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public new virtual ImmutableSet.Builder _003Cbridge_003Eadd(object obj)
		{
			Builder result = add(obj);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public override ImmutableCollection _003Cbridge_003Ebuild()
		{
			ImmutableSortedSet result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public override ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterator i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public override ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterable i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public override ImmutableCollection.Builder _003Cbridge_003Eadd(object[] objarr)
		{
			Builder result = add(objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(434)]
		public override ImmutableCollection.Builder _003Cbridge_003Eadd(object obj)
		{
			Builder result = add(obj);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal new class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TE;>;")]
		internal Comparator comparator;

		[Modifiers(Modifiers.Final)]
		internal object[] elements;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;[Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 162, 206, 104, 103, 103 })]
		public SerializedForm(Comparator P_0, object[] P_1)
		{
			comparator = P_0;
			elements = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(839)]
		internal virtual object readResolve()
		{
			ImmutableSortedSet result = new Builder(comparator).add(elements).build();
			_ = null;
			return result;
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

	internal new const int SPLITERATOR_CHARACTERISTICS = 1301;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("Ljava/util/Comparator<-TE;>;")]
	internal Comparator comparator;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
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
	internal ImmutableSortedSet descendingSet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;I[TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[]
	{
		160,
		byte.MaxValue,
		99,
		137,
		104,
		105,
		98,
		102,
		100,
		102,
		106,
		232,
		60,
		230,
		71,
		105,
		103,
		45
	})]
	internal static ImmutableSortedSet construct(Comparator P_0, int P_1, params object[] P_2)
	{
		if (P_1 == 0)
		{
			RegularImmutableSortedSet result = emptySet(P_0);
			_ = null;
			return result;
		}
		ObjectArrays.checkElementsNotNull(P_2, P_1);
		Arrays.sort(P_2, 0, P_1, P_0);
		int num = 1;
		for (int i = 1; i < P_1; i++)
		{
			object obj = P_2[i];
			object o = P_2[num - 1];
			if (P_0.compare(obj, o) != 0)
			{
				int num2 = num;
				num++;
				P_2[num2] = obj;
			}
		}
		Arrays.fill(P_2, num, P_1, null);
		RegularImmutableSortedSet.___003Cclinit_003E();
		RegularImmutableSortedSet result2 = new RegularImmutableSortedSet(ImmutableList.asImmutableList(P_2, num), P_0);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 183, 103, 136, 139, 103, 104, 194, 103 })]
	public static ImmutableSortedSet copyOf(Comparator comparator, Iterable elements)
	{
		Preconditions.checkNotNull(comparator);
		if (SortedIterables.hasSameComparator(comparator, elements) && elements is ImmutableSortedSet)
		{
			ImmutableSortedSet immutableSortedSet = (ImmutableSortedSet)elements;
			if (!immutableSortedSet.isPartialView())
			{
				return immutableSortedSet;
			}
		}
		object[] array = Iterables.toArray(elements);
		ImmutableSortedSet result = construct(comparator, array.Length, array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;Ljava/util/Collection<+TE;>;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(329)]
	public static ImmutableSortedSet copyOf(Comparator comparator, Collection elements)
	{
		ImmutableSortedSet result = copyOf(comparator, (Iterable)elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(281)]
	public static ImmutableSortedSet copyOf(Comparator comparator, Iterator elements)
	{
		ImmutableSortedSet result = new Builder(comparator).addAll(elements).build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;)Lcom/google/common/collect/RegularImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 36, 109, 134 })]
	internal static RegularImmutableSortedSet emptySet(Comparator P_0)
	{
		if (java.lang.Object.instancehelper_equals(Ordering.natural(), P_0))
		{
			return RegularImmutableSortedSet.NATURAL_EMPTY_SET;
		}
		RegularImmutableSortedSet.___003Cclinit_003E();
		RegularImmutableSortedSet result = new RegularImmutableSortedSet(ImmutableList.of(), P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<*>;Ljava/lang/Object;Ljava/lang/Object;)I")]
	[LineNumberTable(new byte[] { 161, 219, 98 })]
	internal static int unsafeCompare(Comparator P_0, object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2)
	{
		int result = P_0.compare(P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(630)]
	public virtual ImmutableSortedSet headSet(object toElement, bool inclusive)
	{
		ImmutableSortedSet result = headSetImpl(Preconditions.checkNotNull(toElement), inclusive);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("(TE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	internal virtual ImmutableSortedSet headSetImpl(object P_0, bool P_1)
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableSortedSet.headSetImpl(Ljava.lang.Object;Z)Lcom.google.common.collect.ImmutableSortedSet;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;ZTE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 158, 235, 165, 103, 103, 120 })]
	public virtual ImmutableSortedSet subSet(object fromElement, bool fromInclusive, object toElement, bool toInclusive)
	{
		Preconditions.checkNotNull(fromElement);
		Preconditions.checkNotNull(toElement);
		Preconditions.checkArgument(this.comparator.compare(fromElement, toElement) <= 0);
		ImmutableSortedSet result = subSetImpl(fromElement, fromInclusive, toElement, toInclusive);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("(TE;ZTE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	internal virtual ImmutableSortedSet subSetImpl(object P_0, bool P_1, object P_2, bool P_3)
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableSortedSet.subSetImpl(Ljava.lang.Object;ZLjava.lang.Object;Z)Lcom.google.common.collect.ImmutableSortedSet;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(679)]
	public virtual ImmutableSortedSet tailSet(object fromElement, bool inclusive)
	{
		ImmutableSortedSet result = tailSetImpl(Preconditions.checkNotNull(fromElement), inclusive);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("(TE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	internal virtual ImmutableSortedSet tailSetImpl(object P_0, bool P_1)
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableSortedSet.tailSetImpl(Ljava.lang.Object;Z)Lcom.google.common.collect.ImmutableSortedSet;");
	}

	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	public abstract UnmodifiableIterator descendingIterator();

	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	public abstract override UnmodifiableIterator iterator();

	[Modifiers(Modifiers.Abstract)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	internal virtual ImmutableSortedSet createDescendingSet()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableSortedSet.createDescendingSet()Lcom.google.common.collect.ImmutableSortedSet;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(673)]
	public virtual ImmutableSortedSet tailSet(object fromElement)
	{
		ImmutableSortedSet result = tailSet(fromElement, inclusive: true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(624)]
	public virtual ImmutableSortedSet headSet(object toElement)
	{
		ImmutableSortedSet result = headSet(toElement, inclusive: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(647)]
	public virtual ImmutableSortedSet subSet(object fromElement, object toElement)
	{
		ImmutableSortedSet result = subSet(fromElement, fromInclusive: true, toElement, toInclusive: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 162, 151, 103, 99, 114, 135 })]
	public virtual ImmutableSortedSet descendingSet()
	{
		ImmutableSortedSet immutableSortedSet = this.descendingSet;
		if (immutableSortedSet == null)
		{
			ImmutableSortedSet immutableSortedSet2 = createDescendingSet();
			this.descendingSet = immutableSortedSet2;
			immutableSortedSet = immutableSortedSet2;
			immutableSortedSet.descendingSet = this;
		}
		return immutableSortedSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;)Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableSortedSet<TE;>;>;")]
	[LineNumberTable(82)]
	public static Collector toImmutableSortedSet(Comparator comparator)
	{
		Collector result = CollectCollectors.toImmutableSortedSet(comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(99)]
	public new static ImmutableSortedSet of()
	{
		return RegularImmutableSortedSet.NATURAL_EMPTY_SET;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(104)]
	public static ImmutableSortedSet of(IComparable element)
	{
		RegularImmutableSortedSet.___003Cclinit_003E();
		RegularImmutableSortedSet result = new RegularImmutableSortedSet(ImmutableList.of(element), Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(116)]
	public static ImmutableSortedSet of(IComparable e1, IComparable e2)
	{
		ImmutableSortedSet result = construct(Ordering.natural(), 2, e1, e2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(128)]
	public static ImmutableSortedSet of(IComparable e1, IComparable e2, IComparable e3)
	{
		ImmutableSortedSet result = construct(Ordering.natural(), 3, e1, e2, e3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(140)]
	public static ImmutableSortedSet of(IComparable e1, IComparable e2, IComparable e3, IComparable e4)
	{
		ImmutableSortedSet result = construct(Ordering.natural(), 4, e1, e2, e3, e4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(153)]
	public static ImmutableSortedSet of(IComparable e1, IComparable e2, IComparable e3, IComparable e4, IComparable e5)
	{
		ImmutableSortedSet result = construct(Ordering.natural(), 5, e1, e2, e3, e4, e5);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;TE;TE;TE;TE;[TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 117, 107, 100, 100, 100, 100, 101, 101, 109 })]
	public static ImmutableSortedSet of(IComparable e1, IComparable e2, IComparable e3, IComparable e4, IComparable e5, IComparable e6, params IComparable[] remaining)
	{
		IComparable[] array = new IComparable[6 + (nint)remaining.LongLength];
		array[0] = e1;
		array[1] = e2;
		array[2] = e3;
		array[3] = e4;
		array[4] = e5;
		array[5] = e6;
		ByteCodeHelper.arraycopy(remaining, 0, array, 6, remaining.Length);
		ImmutableSortedSet result = construct(Ordering.natural(), array.Length, array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>([TE;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(189)]
	public static ImmutableSortedSet copyOf(IComparable[] elements)
	{
		ImmutableSortedSet result = construct(Ordering.natural(), elements.Length, (IComparable[])elements.Clone());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 103, 102 })]
	public new static ImmutableSortedSet copyOf(Iterable elements)
	{
		Ordering ordering = Ordering.natural();
		ImmutableSortedSet result = copyOf(ordering, elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<+TE;>;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 135, 102 })]
	public new static ImmutableSortedSet copyOf(Collection elements)
	{
		Ordering ordering = Ordering.natural();
		ImmutableSortedSet result = copyOf(ordering, elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 154, 102 })]
	public new static ImmutableSortedSet copyOf(Iterator elements)
	{
		Ordering ordering = Ordering.natural();
		ImmutableSortedSet result = copyOf(ordering, elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 233, 103, 103, 104, 137 })]
	public static ImmutableSortedSet copyOfSorted(SortedSet sortedSet)
	{
		Comparator comparator = SortedIterables.comparator(sortedSet);
		ImmutableList immutableList = ImmutableList.copyOf(sortedSet);
		if (immutableList.isEmpty())
		{
			RegularImmutableSortedSet result = emptySet(comparator);
			_ = null;
			return result;
		}
		RegularImmutableSortedSet result2 = new RegularImmutableSortedSet(immutableList, comparator);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<TE;>;)Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
	[LineNumberTable(396)]
	public static Builder orderedBy(Comparator comparator)
	{
		Builder result = new Builder(comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
	[LineNumberTable(404)]
	public static Builder reverseOrder()
	{
		Builder result = new Builder(Collections.reverseOrder());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
	[LineNumberTable(414)]
	public static Builder naturalOrder()
	{
		Builder result = new Builder(Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(581)]
	internal virtual int unsafeCompare(object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		int result = unsafeCompare(this.comparator, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TE;>;)V")]
	[LineNumberTable(new byte[] { 161, 225, 104, 103 })]
	internal ImmutableSortedSet(Comparator P_0)
	{
		this.comparator = P_0;
	}

	[Signature("()Ljava/util/Comparator<-TE;>;")]
	public virtual Comparator comparator()
	{
		return this.comparator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(698)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object lower(object e)
	{
		object next = Iterators.getNext(headSet(e, inclusive: false).descendingIterator(), null);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(705)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object floor(object e)
	{
		object next = Iterators.getNext(headSet(e, inclusive: true).descendingIterator(), null);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(712)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object ceiling(object e)
	{
		object result = Iterables.getFirst(tailSet(e, inclusive: true), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(720)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object higher(object e)
	{
		object result = Iterables.getFirst(tailSet(e, inclusive: false), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(725)]
	public virtual object first()
	{
		object result = iterator().next();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(730)]
	public virtual object last()
	{
		object result = descendingIterator().next();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("()TE;")]
	[LineNumberTable(747)]
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
	public object pollFirst()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("()TE;")]
	[LineNumberTable(764)]
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
	public object pollLast()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(new byte[] { 162, 167, 98, 50 })]
	public override Spliterator spliterator()
	{
		_1 result = new _1(this, size(), 1365);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableSortedSet.indexOf(Ljava.lang.Object;)I");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.InvalidObjectException" })]
	[LineNumberTable(846)]
	private void readObject(ObjectInputStream P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidObjectException("Use SerializedForm");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(851)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(this.comparator, toArray());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(63)]
	public override ImmutableList asList()
	{
		ImmutableList result = base.asList();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public new virtual Iterator _003Cbridge_003Eiterator()
	{
		UnmodifiableIterator result = iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual SortedSet _003Cbridge_003EtailSet(object obj)
	{
		ImmutableSortedSet result = tailSet(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual SortedSet _003Cbridge_003EheadSet(object obj)
	{
		ImmutableSortedSet result = headSet(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual SortedSet _003Cbridge_003EsubSet(object obj1, object obj2)
	{
		ImmutableSortedSet result = subSet(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableSet _003Cbridge_003EtailSet(object obj, bool b)
	{
		ImmutableSortedSet result = tailSet(obj, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableSet _003Cbridge_003EheadSet(object obj, bool b)
	{
		ImmutableSortedSet result = headSet(obj, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableSet _003Cbridge_003EsubSet(object obj1, bool b1, object obj2, bool b2)
	{
		ImmutableSortedSet result = subSet(obj1, b1, obj2, b2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual Iterator _003Cbridge_003EdescendingIterator()
	{
		UnmodifiableIterator result = descendingIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual NavigableSet _003Cbridge_003EdescendingSet()
	{
		ImmutableSortedSet result = descendingSet();
		_ = null;
		return result;
	}

	[HideFromJava]
	static ImmutableSortedSet()
	{
		ImmutableSortedSetFauxverideShim.___003Cclinit_003E();
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	Iterator NavigableSet.NavigableSet_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	NavigableSet NavigableSet.NavigableSet_003A_003AdescendingSet()
	{
		return _003Cbridge_003EdescendingSet();
	}

	Iterator NavigableSet.NavigableSet_003A_003AdescendingIterator()
	{
		return _003Cbridge_003EdescendingIterator();
	}

	NavigableSet NavigableSet.NavigableSet_003A_003AsubSet(object P_0, bool P_1, object P_2, bool P_3)
	{
		return _003Cbridge_003EsubSet(P_0, P_1, P_2, P_3);
	}

	NavigableSet NavigableSet.NavigableSet_003A_003AheadSet(object P_0, bool P_1)
	{
		return _003Cbridge_003EheadSet(P_0, P_1);
	}

	NavigableSet NavigableSet.NavigableSet_003A_003AtailSet(object P_0, bool P_1)
	{
		return _003Cbridge_003EtailSet(P_0, P_1);
	}

	SortedSet NavigableSet.NavigableSet_003A_003AsubSet(object P_0, object P_1)
	{
		return _003Cbridge_003EsubSet(P_0, P_1);
	}

	SortedSet NavigableSet.NavigableSet_003A_003AheadSet(object P_0)
	{
		return _003Cbridge_003EheadSet(P_0);
	}

	SortedSet NavigableSet.NavigableSet_003A_003AtailSet(object P_0)
	{
		return _003Cbridge_003EtailSet(P_0);
	}

	SortedSet SortedSet.SortedSet_003A_003AsubSet(object P_0, object P_1)
	{
		return _003Cbridge_003EsubSet(P_0, P_1);
	}

	SortedSet SortedSet.SortedSet_003A_003AheadSet(object P_0)
	{
		return _003Cbridge_003EheadSet(P_0);
	}

	SortedSet SortedSet.SortedSet_003A_003AtailSet(object P_0)
	{
		return _003Cbridge_003EtailSet(P_0);
	}

	Iterator Set.Set_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	bool Set.Set_003A_003AisEmpty()
	{
		return isEmpty();
	}

	int Set.Set_003A_003Asize()
	{
		return size();
	}

	bool Set.Set_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	Iterator Collection.Collection_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	int Collection.Collection_003A_003Asize()
	{
		return size();
	}

	bool Collection.Collection_003A_003AisEmpty()
	{
		return isEmpty();
	}

	bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	Stream Collection.Collection_003A_003Astream()
	{
		return stream();
	}

	Stream Collection.Collection_003A_003AparallelStream()
	{
		return parallelStream();
	}

	Iterator Iterable.Iterable_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	void Iterable.Iterable_003A_003AforEach(Consumer P_0)
	{
		forEach(P_0);
	}

	Iterator SortedIterable.SortedIterable_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableSortedSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|toImmutableSet", "()Ljava.util.stream.Collector;")]
	public new static Collector toImmutableSet()
	{
		return ImmutableSortedSetFauxverideShim.toImmutableSet();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|builder", "()Lcom.google.common.collect.ImmutableSortedSet$Builder;")]
	public new static Builder builder()
	{
		return ImmutableSortedSetFauxverideShim.builder();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|builderWithExpectedSize", "(I)Lcom.google.common.collect.ImmutableSortedSet$Builder;")]
	public new static Builder builderWithExpectedSize(int P_0)
	{
		return ImmutableSortedSetFauxverideShim.builderWithExpectedSize(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|of", "(Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedSet;")]
	public new static ImmutableSortedSet of(object P_0)
	{
		return ImmutableSortedSetFauxverideShim.of(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|of", "(Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedSet;")]
	public new static ImmutableSortedSet of(object P_0, object P_1)
	{
		return ImmutableSortedSetFauxverideShim.of(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedSet;")]
	public new static ImmutableSortedSet of(object P_0, object P_1, object P_2)
	{
		return ImmutableSortedSetFauxverideShim.of(P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>6|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedSet;")]
	public new static ImmutableSortedSet of(object P_0, object P_1, object P_2, object P_3)
	{
		return ImmutableSortedSetFauxverideShim.of(P_0, P_1, P_2, P_3);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>7|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedSet;")]
	public new static ImmutableSortedSet of(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ImmutableSortedSetFauxverideShim.of(P_0, P_1, P_2, P_3, P_4);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>8|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;[Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedSet;")]
	public static ImmutableSortedSet of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object[] P_6)
	{
		return ImmutableSortedSetFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>9|copyOf", "([Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedSet;")]
	public new static ImmutableSortedSet copyOf(object[] P_0)
	{
		return ImmutableSortedSetFauxverideShim.copyOf(P_0);
	}
}
