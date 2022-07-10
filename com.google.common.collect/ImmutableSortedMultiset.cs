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
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSortedMultisetFauxverideShim<TE;>;Lcom/google/common/collect/SortedMultiset<TE;>;")]
[ConstantPool(new object[]
{
	(byte)113,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SortedMultiset" })]
public abstract class ImmutableSortedMultiset : ImmutableSortedMultisetFauxverideShim, SortedMultiset, SortedMultisetBridge, Multiset, Collection, Iterable, IEnumerable, SortedIterable
{
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultiset$Builder<TE;>;")]
	public new class Builder : ImmutableMultiset.Builder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 92, 120 })]
		public Builder(Comparator comparator)
			: base(TreeMultiset.create((Comparator)Preconditions.checkNotNull(comparator)))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 182, 104 })]
		public new virtual Builder addAll(Iterator elements)
		{
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
		[LineNumberTable(562)]
		public new virtual ImmutableSortedMultiset build()
		{
			ImmutableSortedMultiset result = copyOfSorted((SortedMultiset)contents);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 168, 104 })]
		public new virtual Builder addAll(Iterable elements)
		{
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 154, 105 })]
		public new virtual Builder setCount(object element, int count)
		{
			base.setCount(element, count);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 137, 105 })]
		public new virtual Builder addCopies(object element, int occurrences)
		{
			base.addCopies(element, occurrences);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([TE;)Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 119, 104 })]
		public new virtual Builder add(params object[] elements)
		{
			base.add(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 105, 104 })]
		public new virtual Builder add(object element)
		{
			base.add(element);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public new virtual ImmutableMultiset _003Cbridge_003Ebuild()
		{
			ImmutableSortedMultiset result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public new virtual ImmutableMultiset.Builder _003Cbridge_003EaddAll(Iterator i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public new virtual ImmutableMultiset.Builder _003Cbridge_003EaddAll(Iterable i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public virtual ImmutableMultiset.Builder _003Cbridge_003EsetCount(object obj, int i)
		{
			Builder result = setCount(obj, i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public virtual ImmutableMultiset.Builder _003Cbridge_003EaddCopies(object obj, int i)
		{
			Builder result = addCopies(obj, i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public new virtual ImmutableMultiset.Builder _003Cbridge_003Eadd(object[] objarr)
		{
			Builder result = add(objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public new virtual ImmutableMultiset.Builder _003Cbridge_003Eadd(object obj)
		{
			Builder result = add(obj);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public override ImmutableCollection _003Cbridge_003Ebuild()
		{
			ImmutableSortedMultiset result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public override ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterator i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public override ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterable i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public override ImmutableCollection.Builder _003Cbridge_003Eadd(object[] objarr)
		{
			Builder result = add(objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(456)]
		public override ImmutableCollection.Builder _003Cbridge_003Eadd(object obj)
		{
			Builder result = add(obj);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal new sealed class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TE;>;")]
		internal Comparator comparator;

		[Modifiers(Modifiers.Final)]
		[Signature("[TE;")]
		internal object[] elements;

		[Modifiers(Modifiers.Final)]
		internal int[] counts;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/SortedMultiset<TE;>;)V")]
		[LineNumberTable(new byte[]
		{
			161, 202, 104, 108, 108, 108, 108, 98, 127, 2,
			111, 111, 100, 98
		})]
		internal SerializedForm(SortedMultiset P_0)
		{
			comparator = P_0.comparator();
			int num = P_0.entrySet().size();
			elements = new object[num];
			counts = new int[num];
			int num2 = 0;
			Iterator iterator = P_0.entrySet().iterator();
			while (iterator.hasNext())
			{
				Multiset.Entry entry = (Multiset.Entry)iterator.next();
				elements[num2] = entry.getElement();
				counts[num2] = entry.getCount();
				num2++;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 216, 104, 108, 102, 55, 166 })]
		internal virtual object readResolve()
		{
			int num = elements.Length;
			Builder builder = new Builder(comparator);
			for (int i = 0; i < num; i++)
			{
				builder.addCopies(elements[i], counts[i]);
			}
			ImmutableSortedMultiset result = builder.build();
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
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
			return readResolve();
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : ToIntFunction
	{
		internal ___003C_003EAnon0()
		{
		}

		public int applyAsInt(object P_0)
		{
			int result = lambda_0024toImmutableSortedMultiset_00240(P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : java.util.function.Supplier
	{
		private readonly Comparator arg_00241;

		internal ___003C_003EAnon1(Comparator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			Multiset result = lambda_0024toImmutableSortedMultiset_00241(arg_00241);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly ToIntFunction arg_00242;

		internal ___003C_003EAnon2(java.util.function.Function P_0, ToIntFunction P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableSortedMultiset_00242(arg_00241, arg_00242, (Multiset)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : BinaryOperator
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0, object P_1)
		{
			Multiset result = lambda_0024toImmutableSortedMultiset_00243((Multiset)P_0, (Multiset)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : java.util.function.Function
	{
		private readonly Comparator arg_00241;

		internal ___003C_003EAnon4(Comparator P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			ImmutableSortedMultiset result = lambda_0024toImmutableSortedMultiset_00244(arg_00241, (Multiset)P_0);
			_ = null;
			return result;
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

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
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
	internal ImmutableSortedMultiset descendingMultiset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;Ljava/util/function/Function<-TT;+TE;>;Ljava/util/function/ToIntFunction<-TT;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 113, 0, 0 })]
	[LineNumberTable(new byte[] { 39, 103, 103, 103 })]
	public static Collector toImmutableSortedMultiset(Comparator comparator, java.util.function.Function elementFunction, ToIntFunction countFunction)
	{
		Preconditions.checkNotNull(comparator);
		Preconditions.checkNotNull(elementFunction);
		Preconditions.checkNotNull(countFunction);
		Collector result = Collector.of(new ___003C_003EAnon1(comparator), new ___003C_003EAnon2(elementFunction, countFunction), new ___003C_003EAnon3(), new ___003C_003EAnon4(comparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[]
	{
		160, 145, 136, 103, 110, 104, 148, 194, 103, 113,
		104
	})]
	public static ImmutableSortedMultiset copyOf(Comparator comparator, Iterable elements)
	{
		if (elements is ImmutableSortedMultiset)
		{
			ImmutableSortedMultiset immutableSortedMultiset = (ImmutableSortedMultiset)elements;
			if (comparator.equals(immutableSortedMultiset.comparator()))
			{
				if (immutableSortedMultiset.isPartialView())
				{
					ImmutableSortedMultiset result = copyOfSortedEntries(comparator, immutableSortedMultiset.entrySet().asList());
					_ = null;
					return result;
				}
				return immutableSortedMultiset;
			}
		}
		java.util.ArrayList elementsToAdd = Lists.newArrayList(elements);
		TreeMultiset treeMultiset = TreeMultiset.create((Comparator)Preconditions.checkNotNull(comparator));
		Iterables.addAll(treeMultiset, elementsToAdd);
		ImmutableSortedMultiset result2 = copyOfSortedEntries(comparator, treeMultiset.entrySet());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 129, 103 })]
	public static ImmutableSortedMultiset copyOf(Comparator comparator, Iterator elements)
	{
		Preconditions.checkNotNull(comparator);
		ImmutableSortedMultiset result = new Builder(comparator).addAll(elements).build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TE;>;")]
	[LineNumberTable(328)]
	public Comparator comparator()
	{
		Comparator result = elementSet().comparator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;Ljava/util/Collection<Lcom/google/common/collect/Multiset$Entry<TE;>;>;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[]
	{
		160, 183, 104, 137, 108, 110, 98, 124, 110, 113,
		100, 98, 107, 174, 236, 60
	})]
	private static ImmutableSortedMultiset copyOfSortedEntries(Comparator P_0, Collection P_1)
	{
		if (P_1.isEmpty())
		{
			ImmutableSortedMultiset result = emptyMultiset(P_0);
			_ = null;
			return result;
		}
		ImmutableList.Builder builder = new ImmutableList.Builder(P_1.size());
		long[] array = new long[P_1.size() + 1];
		int num = 0;
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			builder.add(entry.getElement());
			array[num + 1] = array[num] + entry.getCount();
			num++;
		}
		RegularImmutableSortedMultiset.___003Cclinit_003E();
		RegularImmutableSortedSet.___003Cclinit_003E();
		RegularImmutableSortedMultiset result2 = new RegularImmutableSortedMultiset(new RegularImmutableSortedSet(builder.build(), P_0), array, 0, P_1.size());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 203, 109, 134 })]
	internal static ImmutableSortedMultiset emptyMultiset(Comparator P_0)
	{
		if (java.lang.Object.instancehelper_equals(Ordering.natural(), P_0))
		{
			return RegularImmutableSortedMultiset.NATURAL_EMPTY_MULTISET;
		}
		RegularImmutableSortedMultiset result = new RegularImmutableSortedMultiset(P_0);
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	public new abstract ImmutableSortedSet elementSet();

	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	public abstract ImmutableSortedMultiset tailMultiset(object obj, BoundType bt);

	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	public abstract ImmutableSortedMultiset headMultiset(object obj, BoundType bt);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 161, 18, 97, 57, 229, 69 })]
	public virtual ImmutableSortedMultiset subMultiset(object lowerBound, BoundType lowerBoundType, object upperBound, BoundType upperBoundType)
	{
		Preconditions.checkArgument(comparator().compare(lowerBound, upperBound) <= 0, "Expected lowerBound <= upperBound but %s > %s", lowerBound, upperBound);
		ImmutableSortedMultiset result = tailMultiset(lowerBound, lowerBoundType).headMultiset(upperBound, upperBoundType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[]
	{
		160, 224, 103, 99, 97, 104, 119, 240, 61, 225,
		69
	})]
	public virtual ImmutableSortedMultiset descendingMultiset()
	{
		ImmutableSortedMultiset immutableSortedMultiset = this.descendingMultiset;
		if (immutableSortedMultiset == null)
		{
			ImmutableSortedMultiset result = ((!isEmpty()) ? new DescendingImmutableSortedMultiset(this) : emptyMultiset(Ordering.from(comparator()).reverse()));
			this.descendingMultiset = result;
			return result;
		}
		return immutableSortedMultiset;
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static int lambda_0024toImmutableSortedMultiset_00240(object P_0)
	{
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(93)]
	private static Multiset lambda_0024toImmutableSortedMultiset_00241(Comparator P_0)
	{
		TreeMultiset result = TreeMultiset.create(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(95)]
	private static void lambda_0024toImmutableSortedMultiset_00242(java.util.function.Function P_0, ToIntFunction P_1, Multiset P_2, object P_3)
	{
		P_2.add(Preconditions.checkNotNull(P_0.apply(P_3)), P_1.applyAsInt(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 47, 104 })]
	private static Multiset lambda_0024toImmutableSortedMultiset_00243(Multiset P_0, Multiset P_1)
	{
		P_0.addAll(P_1);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	private static ImmutableSortedMultiset lambda_0024toImmutableSortedMultiset_00244(Comparator P_0, Multiset P_1)
	{
		ImmutableSortedMultiset result = copyOfSortedEntries(P_0, P_1.entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;)Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;>;")]
	[LineNumberTable(70)]
	public static Collector toImmutableSortedMultiset(Comparator comparator)
	{
		Collector result = toImmutableSortedMultiset(comparator, java.util.function.Function.identity(), new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(110)]
	public new static ImmutableSortedMultiset of()
	{
		return RegularImmutableSortedMultiset.NATURAL_EMPTY_MULTISET;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 65, 97, 107, 113 })]
	public static ImmutableSortedMultiset of(IComparable element)
	{
		RegularImmutableSortedSet regularImmutableSortedSet = (RegularImmutableSortedSet)ImmutableSortedSet.of(element);
		long[] array = new long[2] { 0L, 1L };
		RegularImmutableSortedMultiset result = new RegularImmutableSortedMultiset(regularImmutableSortedSet, array, 0, 1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(128)]
	public static ImmutableSortedMultiset of(IComparable e1, IComparable e2)
	{
		ImmutableSortedMultiset result = copyOf(Ordering.natural(), Arrays.asList(e1, e2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(138)]
	public static ImmutableSortedMultiset of(IComparable e1, IComparable e2, IComparable e3)
	{
		ImmutableSortedMultiset result = copyOf(Ordering.natural(), Arrays.asList(e1, e2, e3));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(149)]
	public static ImmutableSortedMultiset of(IComparable e1, IComparable e2, IComparable e3, IComparable e4)
	{
		ImmutableSortedMultiset result = copyOf(Ordering.natural(), Arrays.asList(e1, e2, e3, e4));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(160)]
	public static ImmutableSortedMultiset of(IComparable e1, IComparable e2, IComparable e3, IComparable e4, IComparable e5)
	{
		ImmutableSortedMultiset result = copyOf(Ordering.natural(), Arrays.asList(e1, e2, e3, e4, e5));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(TE;TE;TE;TE;TE;TE;[TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 121, 102, 103, 127, 8, 105 })]
	public static ImmutableSortedMultiset of(IComparable e1, IComparable e2, IComparable e3, IComparable e4, IComparable e5, IComparable e6, params IComparable[] remaining)
	{
		int initialArraySize = (int)((nint)remaining.LongLength + 6);
		java.util.ArrayList arrayList = Lists.newArrayListWithCapacity(initialArraySize);
		Collections.addAll(arrayList, e1, e2, e3, e4, e5, e6);
		Collections.addAll(arrayList, remaining);
		ImmutableSortedMultiset result = copyOf(Ordering.natural(), arrayList);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>([TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(185)]
	public static ImmutableSortedMultiset copyOf(IComparable[] elements)
	{
		ImmutableSortedMultiset result = copyOf(Ordering.natural(), Arrays.asList(elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 99, 102 })]
	public new static ImmutableSortedMultiset copyOf(Iterable elements)
	{
		Ordering ordering = Ordering.natural();
		ImmutableSortedMultiset result = copyOf(ordering, elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 117, 102 })]
	public new static ImmutableSortedMultiset copyOf(Iterator elements)
	{
		Ordering ordering = Ordering.natural();
		ImmutableSortedMultiset result = copyOf(ordering, elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/SortedMultiset<TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 177, 97, 48 })]
	public static ImmutableSortedMultiset copyOfSorted(SortedMultiset sortedMultiset)
	{
		ImmutableSortedMultiset result = copyOfSortedEntries(sortedMultiset.comparator(), Lists.newArrayList(sortedMultiset.entrySet()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(324)]
	internal ImmutableSortedMultiset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(362)]
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
	public Multiset.Entry pollFirstEntry()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(379)]
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
	public Multiset.Entry pollLastEntry()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<TE;>;)Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
	[LineNumberTable(408)]
	public static Builder orderedBy(Comparator comparator)
	{
		Builder result = new Builder(comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
	[LineNumberTable(420)]
	public static Builder reverseOrder()
	{
		Builder result = new Builder(Ordering.natural().reverse());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
	[LineNumberTable(434)]
	public static Builder naturalOrder()
	{
		Builder result = new Builder(Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(597)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public new virtual ImmutableSet _003Cbridge_003EelementSet()
	{
		ImmutableSortedSet result = elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public override Set _003Cbridge_003EelementSet()
	{
		ImmutableSortedSet result = elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public virtual SortedMultiset _003Cbridge_003EtailMultiset(object obj, BoundType bt)
	{
		ImmutableSortedMultiset result = tailMultiset(obj, bt);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public virtual SortedMultiset _003Cbridge_003EsubMultiset(object obj1, BoundType bt1, object obj2, BoundType bt2)
	{
		ImmutableSortedMultiset result = subMultiset(obj1, bt1, obj2, bt2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public virtual SortedMultiset _003Cbridge_003EheadMultiset(object obj, BoundType bt)
	{
		ImmutableSortedMultiset result = headMultiset(obj, bt);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public virtual SortedMultiset _003Cbridge_003EdescendingMultiset()
	{
		ImmutableSortedMultiset result = descendingMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public new virtual NavigableSet _003Cbridge_003EelementSet()
	{
		ImmutableSortedSet result = elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public new virtual SortedSet _003Cbridge_003EelementSet()
	{
		ImmutableSortedSet result = elementSet();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override int count(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEachEntry(ObjIntConsumer P_0)
	{
		Multiset._003Cdefault_003EforEachEntry(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Multiset.Entry firstEntry();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Multiset.Entry lastEntry();

	[HideFromJava]
	static ImmutableSortedMultiset()
	{
		ImmutableSortedMultisetFauxverideShim.___003Cclinit_003E();
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	NavigableSet SortedMultiset.SortedMultiset_003A_003AelementSet()
	{
		return this._003Cbridge_003EelementSet();
	}

	Set SortedMultiset.SortedMultiset_003A_003AentrySet()
	{
		return _003Cbridge_003EentrySet();
	}

	Iterator SortedMultiset.SortedMultiset_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	SortedMultiset SortedMultiset.SortedMultiset_003A_003AdescendingMultiset()
	{
		return _003Cbridge_003EdescendingMultiset();
	}

	SortedMultiset SortedMultiset.SortedMultiset_003A_003AheadMultiset(object P_0, BoundType P_1)
	{
		return _003Cbridge_003EheadMultiset(P_0, P_1);
	}

	SortedMultiset SortedMultiset.SortedMultiset_003A_003AsubMultiset(object P_0, BoundType P_1, object P_2, BoundType P_3)
	{
		return _003Cbridge_003EsubMultiset(P_0, P_1, P_2, P_3);
	}

	SortedMultiset SortedMultiset.SortedMultiset_003A_003AtailMultiset(object P_0, BoundType P_1)
	{
		return _003Cbridge_003EtailMultiset(P_0, P_1);
	}

	SortedSet SortedMultisetBridge.SortedMultisetBridge_003A_003AelementSet()
	{
		return this._003Cbridge_003EelementSet();
	}

	Set SortedMultisetBridge.SortedMultisetBridge_003A_003AelementSet()
	{
		return this._003Cbridge_003EelementSet();
	}

	int Multiset.Multiset_003A_003Asize()
	{
		return size();
	}

	Set Multiset.Multiset_003A_003AelementSet()
	{
		return this._003Cbridge_003EelementSet();
	}

	Set Multiset.Multiset_003A_003AentrySet()
	{
		return _003Cbridge_003EentrySet();
	}

	Iterator Multiset.Multiset_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	bool Multiset.Multiset_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	void Multiset.Multiset_003A_003AforEach(Consumer P_0)
	{
		forEach(P_0);
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
	protected ImmutableSortedMultiset(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|toImmutableMultiset", "()Ljava.util.stream.Collector;")]
	public new static Collector toImmutableMultiset()
	{
		return ImmutableSortedMultisetFauxverideShim.toImmutableMultiset();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|toImmutableMultiset", "(Ljava.util.function.Function;Ljava.util.function.ToIntFunction;)Ljava.util.stream.Collector;")]
	public new static Collector toImmutableMultiset(java.util.function.Function P_0, ToIntFunction P_1)
	{
		return ImmutableSortedMultisetFauxverideShim.toImmutableMultiset(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|builder", "()Lcom.google.common.collect.ImmutableSortedMultiset$Builder;")]
	public new static Builder builder()
	{
		return ImmutableSortedMultisetFauxverideShim.builder();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|of", "(Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMultiset;")]
	public new static ImmutableSortedMultiset of(object P_0)
	{
		return ImmutableSortedMultisetFauxverideShim.of(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|of", "(Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMultiset;")]
	public new static ImmutableSortedMultiset of(object P_0, object P_1)
	{
		return ImmutableSortedMultisetFauxverideShim.of(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMultiset;")]
	public new static ImmutableSortedMultiset of(object P_0, object P_1, object P_2)
	{
		return ImmutableSortedMultisetFauxverideShim.of(P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>6|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMultiset;")]
	public new static ImmutableSortedMultiset of(object P_0, object P_1, object P_2, object P_3)
	{
		return ImmutableSortedMultisetFauxverideShim.of(P_0, P_1, P_2, P_3);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>7|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMultiset;")]
	public new static ImmutableSortedMultiset of(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		return ImmutableSortedMultisetFauxverideShim.of(P_0, P_1, P_2, P_3, P_4);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>8|of", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;[Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMultiset;")]
	public static ImmutableSortedMultiset of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object[] P_6)
	{
		return ImmutableSortedMultisetFauxverideShim.of(P_0, P_1, P_2, P_3, P_4, P_5, P_6);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>9|copyOf", "([Ljava.lang.Object;)Lcom.google.common.collect.ImmutableSortedMultiset;")]
	public new static ImmutableSortedMultiset copyOf(object[] P_0)
	{
		return ImmutableSortedMultisetFauxverideShim.copyOf(P_0);
	}
}
