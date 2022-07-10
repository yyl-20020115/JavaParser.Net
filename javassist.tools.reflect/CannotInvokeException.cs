using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.tools.reflect;

[Serializable]
public class CannotInvokeException : RuntimeException
{
	private const long serialVersionUID = 1L;

	private System.Exception err;

	public virtual System.Exception getReason()
	{
		return err;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 186, 233, 53, 231, 76 })]
	public CannotInvokeException(string reason)
		: base(reason)
	{
		err = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		1,
		byte.MaxValue,
		13,
		46,
		231,
		83,
		108
	})]
	public CannotInvokeException(InvocationTargetException e)
		: base(new StringBuilder().append("by ").append(Throwable.instancehelper_toString(e.getTargetException())).toString())
	{
		err = null;
		err = e.getTargetException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		9,
		byte.MaxValue,
		8,
		38,
		231,
		91,
		103
	})]
	public CannotInvokeException(IllegalAccessException e)
		: base(new StringBuilder().append("by ").append(Throwable.instancehelper_toString(e)).toString())
	{
		err = null;
		err = e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		17,
		byte.MaxValue,
		8,
		30,
		231,
		99,
		103
	})]
	public CannotInvokeException(java.lang.ClassNotFoundException e)
		: base(new StringBuilder().append("by ").append(Throwable.instancehelper_toString(e)).toString())
	{
		err = null;
		err = e;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected CannotInvokeException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
