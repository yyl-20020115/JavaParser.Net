using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class DescendingImmutableSortedSet : ImmutableSortedSet
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	private ImmutableSortedSet forward;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableSortedSet<TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 175, 120, 103 })]
	internal DescendingImmutableSortedSet(ImmutableSortedSet P_0)
		: base(Ordering.from(P_0.comparator()).reverse())
	{
		forward = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(44)]
	public override int size()
	{
		int result = forward.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(77)]
	public override UnmodifiableIterator descendingIterator()
	{
		UnmodifiableIterator result = forward.iterator();
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	public override ImmutableSortedSet descendingSet()
	{
		return forward;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(49)]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableIterator result = forward.descendingIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(39)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = forward.contains(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(54)]
	internal override ImmutableSortedSet headSetImpl(object P_0, bool P_1)
	{
		ImmutableSortedSet result = forward.tailSet(P_0, P_1).descendingSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;ZTE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(60)]
	internal override ImmutableSortedSet subSetImpl(object P_0, bool P_1, object P_2, bool P_3)
	{
		ImmutableSortedSet result = forward.subSet(P_2, P_3, P_0, P_1).descendingSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(65)]
	internal override ImmutableSortedSet tailSetImpl(object P_0, bool P_1)
	{
		ImmutableSortedSet result = forward.headSet(P_0, P_1).descendingSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(83)]
	internal override ImmutableSortedSet createDescendingSet()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(89)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object lower(object P_0)
	{
		object result = forward.higher(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(95)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object floor(object P_0)
	{
		object result = forward.ceiling(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(101)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object ceiling(object P_0)
	{
		object result = forward.floor(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(107)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object higher(object P_0)
	{
		object result = forward.lower(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 62, 109, 100, 130 })]
	internal override int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		int num = forward.indexOf(P_0);
		if (num == -1)
		{
			return num;
		}
		return size() - 1 - num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(122)]
	internal override bool isPartialView()
	{
		bool result = forward.isPartialView();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(27)]
	public new virtual Iterator descendingIterator()
	{
		UnmodifiableIterator result = this.descendingIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(27)]
	public new virtual NavigableSet descendingSet()
	{
		ImmutableSortedSet result = this.descendingSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(27)]
	public new virtual Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[HideFromJava]
	static DescendingImmutableSortedSet()
	{
		ImmutableSortedSet.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected DescendingImmutableSortedSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
