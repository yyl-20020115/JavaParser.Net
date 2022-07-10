using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist;

[Serializable]
public class NotFoundException : java.lang.Exception
{
	private const long serialVersionUID = 1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 169, 105 })]
	public NotFoundException(string msg)
		: base(msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 173, 127, 14 })]
	public NotFoundException(string msg, java.lang.Exception e)
		: base(new StringBuilder().append(msg).append(" because of ").append(Throwable.instancehelper_toString(e))
			.toString())
	{
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected NotFoundException(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
