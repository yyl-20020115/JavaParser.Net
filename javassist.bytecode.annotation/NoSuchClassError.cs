using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.bytecode.annotation;

[Serializable]
public class NoSuchClassError : Error
{
	private const long serialVersionUID = 1L;

	private string className;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 111, 103 })]
	public NoSuchClassError(string className, Error cause)
		: base(Throwable.instancehelper_toString(cause), cause)
	{
		this.className = className;
	}

	public virtual string getClassName()
	{
		return className;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected NoSuchClassError(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
