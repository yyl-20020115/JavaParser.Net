using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/Ordering<TT;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class ExplicitOrdering : Ordering, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TT;Ljava/lang/Integer;>;")]
	internal ImmutableMap rankMap;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<TT;>;)V")]
	[LineNumberTable(new byte[] { 159, 173, 110 })]
	internal ExplicitOrdering(List P_0)
		: this(Maps.indexMap(P_0))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableMap<TT;Ljava/lang/Integer;>;)V")]
	[LineNumberTable(new byte[] { 159, 176, 104, 103 })]
	internal ExplicitOrdering(ImmutableMap P_0)
	{
		rankMap = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)I")]
	[LineNumberTable(new byte[] { 159, 186, 114, 99, 140 })]
	private int rank(object P_0)
	{
		Integer integer = (Integer)rankMap.get(P_0);
		if (integer == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IncomparableValueException(P_0);
		}
		int result = integer.intValue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;TT;)I")]
	[LineNumberTable(40)]
	public override int compare(object P_0, object P_1)
	{
		return rank(P_0) - rank(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 3, 104, 103, 148 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is ExplicitOrdering)
		{
			ExplicitOrdering explicitOrdering = (ExplicitOrdering)P_0;
			bool result = rankMap.equals(explicitOrdering.rankMap);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	public override int hashCode()
	{
		int result = rankMap.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(67)]
	public override string toString()
	{
		string text = java.lang.String.valueOf(rankMap.keySet());
		int num = 19 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append("Ordering.explicit(").append(text).append(")")
			.toString();
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
	protected ExplicitOrdering(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
