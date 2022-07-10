using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("Lcom/google/common/collect/Ordering<Ljava/lang/Comparable<*>;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class ReverseNaturalOrdering : Ordering, Serializable.__Interface, ISerializable, IObjectReference
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static ReverseNaturalOrdering INSTANCE;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>(TE;TE;TE;[TE;)TE;")]
	[LineNumberTable(76)]
	public virtual IComparable max(IComparable P_0, IComparable P_1, IComparable P_2, params IComparable[] P_3)
	{
		return (IComparable)NaturalOrdering.INSTANCE.min(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>(TE;TE;)TE;")]
	[LineNumberTable(71)]
	public virtual IComparable max(IComparable P_0, IComparable P_1)
	{
		return (IComparable)NaturalOrdering.INSTANCE.min(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>(Ljava/lang/Iterable<TE;>;)TE;")]
	[LineNumberTable(86)]
	public new virtual IComparable max(Iterable P_0)
	{
		return (IComparable)NaturalOrdering.INSTANCE.min(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>(Ljava/util/Iterator<TE;>;)TE;")]
	[LineNumberTable(81)]
	public new virtual IComparable max(Iterator P_0)
	{
		return (IComparable)NaturalOrdering.INSTANCE.min(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>(TE;TE;TE;[TE;)TE;")]
	[LineNumberTable(56)]
	public virtual IComparable min(IComparable P_0, IComparable P_1, IComparable P_2, params IComparable[] P_3)
	{
		return (IComparable)NaturalOrdering.INSTANCE.max(P_0, P_1, P_2, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>(TE;TE;)TE;")]
	[LineNumberTable(51)]
	public virtual IComparable min(IComparable P_0, IComparable P_1)
	{
		return (IComparable)NaturalOrdering.INSTANCE.max(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>(Ljava/lang/Iterable<TE;>;)TE;")]
	[LineNumberTable(66)]
	public new virtual IComparable min(Iterable P_0)
	{
		return (IComparable)NaturalOrdering.INSTANCE.max(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<*>;>(Ljava/util/Iterator<TE;>;)TE;")]
	[LineNumberTable(61)]
	public new virtual IComparable min(Iterator P_0)
	{
		return (IComparable)NaturalOrdering.INSTANCE.max(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Comparable<*>;Ljava/lang/Comparable<*>;)I")]
	[LineNumberTable(new byte[] { 159, 176, 103, 100, 162 })]
	public virtual int compare(IComparable P_0, IComparable P_1)
	{
		Preconditions.checkNotNull(P_0);
		if (P_0 == P_1)
		{
			return 0;
		}
		int result = Comparable.__Helper.compareTo(P_1, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(99)]
	private ReverseNaturalOrdering()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[LineNumberTable(44)]
	public override Ordering reverse()
	{
		Ordering result = Ordering.natural();
		_ = null;
		return result;
	}

	private object readResolve()
	{
		return INSTANCE;
	}

	public override string toString()
	{
		return "Ordering.natural().reverse()";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override object max(object P_0, object P_1, object P_2, object[] P_3)
	{
		IComparable result = max((IComparable)P_0, (IComparable)P_1, (IComparable)P_2, (IComparable[])P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override object max(object P_0, object P_1)
	{
		IComparable result = max((IComparable)P_0, (IComparable)P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override object max(Iterable P_0)
	{
		IComparable result = max(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override object max(Iterator P_0)
	{
		IComparable result = max(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override object min(object P_0, object P_1, object P_2, object[] P_3)
	{
		IComparable result = min((IComparable)P_0, (IComparable)P_1, (IComparable)P_2, (IComparable[])P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override object min(object P_0, object P_1)
	{
		IComparable result = min((IComparable)P_0, (IComparable)P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override object min(Iterable P_0)
	{
		IComparable result = min(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override object min(Iterator P_0)
	{
		IComparable result = min(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public override int compare(object P_0, object P_1)
	{
		int result = compare((IComparable)P_0, (IComparable)P_1);
		_ = null;
		return result;
	}

	[LineNumberTable(30)]
	static ReverseNaturalOrdering()
	{
		INSTANCE = new ReverseNaturalOrdering();
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
	protected ReverseNaturalOrdering(SerializationInfo P_0, StreamingContext P_1)
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
