using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using javax.annotation;

namespace com.google.common.@base;

[Serializable]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public class VerifyException : RuntimeException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public VerifyException()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 177, 105 })]
	public VerifyException([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string message)
		: base(message)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 105 })]
	public VerifyException([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] System.Exception cause)
		: base(cause)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 5, 106 })]
	public VerifyException([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string message, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] System.Exception cause)
		: base(message, cause)
	{
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected VerifyException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
