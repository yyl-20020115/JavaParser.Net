using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class DescendingImmutableSortedMultiset : ImmutableSortedMultiset
{
	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	private ImmutableSortedMultiset forward;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 173, 104, 103 })]
	internal DescendingImmutableSortedMultiset(ImmutableSortedMultiset P_0)
	{
		forward = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(79)]
	public override ImmutableSortedMultiset tailMultiset(object P_0, BoundType P_1)
	{
		ImmutableSortedMultiset result = forward.headMultiset(P_0, P_1).descendingMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(74)]
	public override ImmutableSortedMultiset headMultiset(object P_0, BoundType P_1)
	{
		ImmutableSortedMultiset result = forward.tailMultiset(P_0, P_1).descendingMultiset();
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	public override ImmutableSortedMultiset descendingMultiset()
	{
		return forward;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(59)]
	public override ImmutableSortedSet elementSet()
	{
		ImmutableSortedSet result = forward.elementSet().descendingSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		int result = forward.count(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(43)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Multiset.Entry firstEntry()
	{
		Multiset.Entry result = forward.lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(49)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Multiset.Entry lastEntry()
	{
		Multiset.Entry result = forward.firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	public override int size()
	{
		int result = forward.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(64)]
	internal override Multiset.Entry getEntry(int P_0)
	{
		return (Multiset.Entry)forward.entrySet().asList().reverse()
			.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(84)]
	internal override bool isPartialView()
	{
		bool result = forward.isPartialView();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(25)]
	public new virtual SortedMultiset tailMultiset(object P_0, BoundType P_1)
	{
		ImmutableSortedMultiset result = this.tailMultiset(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(25)]
	public new virtual SortedMultiset headMultiset(object P_0, BoundType P_1)
	{
		ImmutableSortedMultiset result = this.headMultiset(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(25)]
	public new virtual SortedMultiset descendingMultiset()
	{
		ImmutableSortedMultiset result = this.descendingMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(25)]
	public new virtual NavigableSet elementSet()
	{
		ImmutableSortedSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(25)]
	public new virtual SortedSet elementSet()
	{
		ImmutableSortedSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(25)]
	public new virtual Set elementSet()
	{
		ImmutableSortedSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(25)]
	public new virtual ImmutableSet elementSet()
	{
		ImmutableSortedSet result = this.elementSet();
		_ = null;
		return result;
	}

	[HideFromJava]
	static DescendingImmutableSortedMultiset()
	{
		ImmutableSortedMultiset.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected DescendingImmutableSortedMultiset(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
