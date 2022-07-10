using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/Ordering<TT;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0,
	2,
	16,
	byte.MaxValue,
	byte.MaxValue,
	1,
	3,
	0,
	0,
	52,
	0,
	0,
	17,
	0,
	0,
	0,
	0,
	52,
	0,
	0
})]
[ConstantPool(new object[]
{
	(byte)52,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class NullsFirstOrdering : Ordering, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Ordering<-TT;>;")]
	internal Ordering ordering;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Ordering<-TT;>;)V")]
	[LineNumberTable(new byte[] { 159, 173, 104, 103 })]
	internal NullsFirstOrdering(Ordering P_0)
	{
		ordering = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;TT;)I")]
	[LineNumberTable(new byte[] { 159, 179, 100, 130, 99, 130, 99, 130 })]
	public override int compare([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 == P_1)
		{
			return 0;
		}
		if (P_0 == null)
		{
			return -1;
		}
		if (P_1 == null)
		{
			return 1;
		}
		int result = ordering.compare(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:TT;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 52, 0, 0 })]
	[LineNumberTable(53)]
	public override Ordering reverse()
	{
		Ordering result = ordering.reverse().nullsLast();
		_ = null;
		return result;
	}

	[Signature("<S:TT;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 52, 0, 0 })]
	public override Ordering nullsFirst()
	{
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:TT;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 52, 0, 0 })]
	[LineNumberTable(64)]
	public override Ordering nullsLast()
	{
		Ordering result = ordering.nullsLast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 19, 100, 130, 104, 103, 148 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 == this)
		{
			return true;
		}
		if (P_0 is NullsFirstOrdering)
		{
			NullsFirstOrdering nullsFirstOrdering = (NullsFirstOrdering)P_0;
			bool result = java.lang.Object.instancehelper_equals(ordering, nullsFirstOrdering.ordering);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(81)]
	public override int hashCode()
	{
		return java.lang.Object.instancehelper_hashCode(ordering) ^ 0x39153A74;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(86)]
	public override string toString()
	{
		string text = java.lang.String.valueOf(ordering);
		int num = 13 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append(text).append(".nullsFirst()").toString();
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
	protected NullsFirstOrdering(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
