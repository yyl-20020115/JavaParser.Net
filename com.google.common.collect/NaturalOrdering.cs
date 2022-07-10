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
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("Lcom/google/common/collect/Ordering<Ljava/lang/Comparable<*>;>;Ljava/io/Serializable;")]
[ConstantPool(new object[]
{
	(byte)26,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class NaturalOrdering : Ordering, Serializable.__Interface, ISerializable, IObjectReference
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static NaturalOrdering INSTANCE;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/Ordering<Ljava/lang/Comparable<*>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 3, 0, 0, 26, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Ordering m_nullsFirst;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/Ordering<Ljava/lang/Comparable<*>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 3, 0, 0, 26, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Ordering m_nullsLast;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Comparable<*>;Ljava/lang/Comparable<*>;)I")]
	[LineNumberTable(new byte[] { 159, 180, 103, 103 })]
	public virtual int compare(IComparable P_0, IComparable P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		int result = Comparable.__Helper.compareTo(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	private NaturalOrdering()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 26, 0, 0 })]
	[LineNumberTable(new byte[] { 159, 187, 103, 99, 146 })]
	public override Ordering nullsFirst()
	{
		Ordering ordering = this.m_nullsFirst;
		if (ordering == null)
		{
			Ordering ordering2 = base.nullsFirst();
			this.m_nullsFirst = ordering2;
			ordering = ordering2;
		}
		return ordering;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 26, 0, 0 })]
	[LineNumberTable(new byte[] { 4, 103, 99, 146 })]
	public override Ordering nullsLast()
	{
		Ordering ordering = this.m_nullsLast;
		if (ordering == null)
		{
			Ordering ordering2 = base.nullsLast();
			this.m_nullsLast = ordering2;
			ordering = ordering2;
		}
		return ordering;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[LineNumberTable(63)]
	public override Ordering reverse()
	{
		return ReverseNaturalOrdering.INSTANCE;
	}

	private object readResolve()
	{
		return INSTANCE;
	}

	public override string toString()
	{
		return "Ordering.natural()";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(27)]
	public override int compare(object P_0, object P_1)
	{
		int result = compare((IComparable)P_0, (IComparable)P_1);
		_ = null;
		return result;
	}

	[LineNumberTable(31)]
	static NaturalOrdering()
	{
		INSTANCE = new NaturalOrdering();
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
	protected NaturalOrdering(SerializationInfo P_0, StreamingContext P_1)
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
