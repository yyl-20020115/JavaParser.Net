using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/RegularImmutableAsList<TE;>;Lcom/google/common/collect/SortedIterable<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SortedIterable" })]
internal sealed class ImmutableSortedAsList : RegularImmutableAsList, SortedIterable, Iterable, IEnumerable
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : IntFunction
	{
		private readonly ImmutableList arg_00241;

		internal ___003C_003EAnon0(ImmutableList P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(int P_0)
		{
			object result = ((List)arg_00241).get(P_0);
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(40)]
	internal new virtual ImmutableSortedSet delegateCollection()
	{
		return (ImmutableSortedSet)base.delegateCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 237, 71 })]
	public override int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		int num = delegateCollection().indexOf(P_0);
		return (num < 0 || !java.lang.Object.instancehelper_equals(get(num), P_0)) ? (-1) : num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TE;>;")]
	[LineNumberTable(45)]
	public virtual Comparator comparator()
	{
		Comparator result = delegateCollection().comparator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableSortedSet<TE;>;Lcom/google/common/collect/ImmutableList<TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 177, 106 })]
	internal ImmutableSortedAsList(ImmutableSortedSet P_0, ImmutableList P_1)
		: base(P_0, P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(67)]
	public override int lastIndexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		int result = indexOf(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return indexOf(P_0) >= 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 34, 105 })]
	internal override ImmutableList subListUnchecked(int P_0, int P_1)
	{
		ImmutableList immutableList = base.subListUnchecked(P_0, P_1);
		RegularImmutableSortedSet.___003Cclinit_003E();
		ImmutableList result = new RegularImmutableSortedSet(immutableList, comparator()).asList();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(new byte[] { 40, 97, 139, 119, 229, 60 })]
	public override Spliterator spliterator()
	{
		int num = size();
		ImmutableList immutableList = base.delegateList();
		Objects.requireNonNull(immutableList);
		Spliterator result = CollectSpliterators.indexed(num, 1301, new ___003C_003EAnon0(immutableList), comparator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	internal override ImmutableCollection delegateCollection()
	{
		ImmutableSortedSet result = delegateCollection();
		_ = null;
		return result;
	}

	[HideFromJava]
	static ImmutableSortedAsList()
	{
		RegularImmutableAsList.___003Cclinit_003E();
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	Iterator SortedIterable.SortedIterable_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	Iterator Iterable.Iterable_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableSortedAsList(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
