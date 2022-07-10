using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.cache;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap$SimpleImmutableEntry<TK;TV;>;")]
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
	51,
	0,
	0,
	16,
	byte.MaxValue,
	byte.MaxValue,
	1,
	3,
	1,
	0,
	51,
	0,
	0
})]
[ConstantPool(new object[]
{
	(byte)51,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public sealed class RemovalNotification : AbstractMap.SimpleImmutableEntry
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private RemovalCause cause;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;Lcom/google/common/cache/RemovalCause;)Lcom/google/common/cache/RemovalNotification<TK;TV;>;")]
	[LineNumberTable(50)]
	public static RemovalNotification create([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value, RemovalCause cause)
	{
		RemovalNotification result = new RemovalNotification(key, value, cause);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;Lcom/google/common/cache/RemovalCause;)V")]
	[LineNumberTable(new byte[] { 4, 106, 113 })]
	private RemovalNotification([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1, RemovalCause P_2)
		: base(P_0, P_1)
	{
		cause = (RemovalCause)Preconditions.checkNotNull(P_2);
	}

	public virtual RemovalCause getCause()
	{
		return cause;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	public virtual bool wasEvicted()
	{
		bool result = cause.wasEvicted();
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RemovalNotification(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
