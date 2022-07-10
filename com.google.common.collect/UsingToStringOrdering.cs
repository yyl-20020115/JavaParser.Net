using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;

namespace com.google.common.collect;

[Serializable]
[Signature("Lcom/google/common/collect/Ordering<Ljava/lang/Object;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class UsingToStringOrdering : Ordering, Serializable.__Interface, ISerializable, IObjectReference
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static UsingToStringOrdering INSTANCE;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	private UsingToStringOrdering()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(30)]
	public override int compare(object P_0, object P_1)
	{
		int result = java.lang.String.instancehelper_compareTo(java.lang.Object.instancehelper_toString(P_0), java.lang.Object.instancehelper_toString(P_1));
		_ = null;
		return result;
	}

	private object readResolve()
	{
		return INSTANCE;
	}

	public override string toString()
	{
		return "Ordering.usingToString()";
	}

	[LineNumberTable(26)]
	static UsingToStringOrdering()
	{
		INSTANCE = new UsingToStringOrdering();
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
	protected UsingToStringOrdering(SerializationInfo P_0, StreamingContext P_1)
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
