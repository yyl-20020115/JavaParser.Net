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
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/Ordering<TT;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 98, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)98,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class ReverseOrdering : Ordering, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Ordering<-TT;>;")]
	internal Ordering forwardOrder;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Ordering<-TT;>;)V")]
	[LineNumberTable(new byte[] { 159, 176, 104, 113 })]
	internal ReverseOrdering(Ordering P_0)
	{
		forwardOrder = (Ordering)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;TT;)I")]
	[LineNumberTable(40)]
	public override int compare([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		int result = forwardOrder.compare(P_1, P_0);
		_ = null;
		return result;
	}

	[Signature("<S:TT;>()Lcom/google/common/collect/Ordering<TS;>;")]
	public override Ordering reverse()
	{
		return forwardOrder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(TE;TE;)TE;")]
	[LineNumberTable(53)]
	public override object min([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		object result = forwardOrder.max(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(TE;TE;TE;[TE;)TE;")]
	[LineNumberTable(59)]
	public override object min([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2, params object[] P_3)
	{
		object result = forwardOrder.max(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/util/Iterator<TE;>;)TE;")]
	[LineNumberTable(64)]
	public override object min(Iterator P_0)
	{
		object result = forwardOrder.max(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/lang/Iterable<TE;>;)TE;")]
	[LineNumberTable(69)]
	public override object min(Iterable P_0)
	{
		object result = forwardOrder.max(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(TE;TE;)TE;")]
	[LineNumberTable(74)]
	public override object max([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		object result = forwardOrder.min(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(TE;TE;TE;[TE;)TE;")]
	[LineNumberTable(80)]
	public override object max([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2, params object[] P_3)
	{
		object result = forwardOrder.min(P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/util/Iterator<TE;>;)TE;")]
	[LineNumberTable(85)]
	public override object max(Iterator P_0)
	{
		object result = forwardOrder.min(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/lang/Iterable<TE;>;)TE;")]
	[LineNumberTable(90)]
	public override object max(Iterable P_0)
	{
		object result = forwardOrder.min(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(95)]
	public override int hashCode()
	{
		return -java.lang.Object.instancehelper_hashCode(forwardOrder);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 50, 100, 130, 104, 103, 148 })]
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
		if (P_0 is ReverseOrdering)
		{
			ReverseOrdering reverseOrdering = (ReverseOrdering)P_0;
			bool result = java.lang.Object.instancehelper_equals(forwardOrder, reverseOrdering.forwardOrder);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(112)]
	public override string toString()
	{
		string text = java.lang.String.valueOf(forwardOrder);
		int num = 10 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append(text).append(".reverse()").toString();
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
	protected ReverseOrdering(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
