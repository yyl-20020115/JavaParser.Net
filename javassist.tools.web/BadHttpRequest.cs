using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.tools.web;

[Serializable]
public class BadHttpRequest : java.lang.Exception
{
	private const long serialVersionUID = 1L;

	private java.lang.Exception e;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(27)]
	public BadHttpRequest()
	{
		e = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	public BadHttpRequest(java.lang.Exception _e)
	{
		e = _e;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 175, 104, 105 })]
	public override string toString()
	{
		if (e == null)
		{
			string result = base.toString();
			_ = null;
			return result;
		}
		string result2 = Throwable.instancehelper_toString(e);
		_ = null;
		return result2;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected BadHttpRequest(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
