using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.bytecode;

[Serializable]
public class BadBytecode : java.lang.Exception
{
	private const long serialVersionUID = 1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 169, 127, 3 })]
	public BadBytecode(int opcode)
		: base(new StringBuilder().append("bytecode ").append(opcode).toString())
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 173, 105 })]
	public BadBytecode(string msg)
		: base(msg)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 177, 106 })]
	public BadBytecode(string msg, System.Exception cause)
		: base(msg, cause)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 124, 122, 16, 167 })]
	public BadBytecode(MethodInfo minfo, System.Exception cause)
		: base(new StringBuilder().append(minfo.toString()).append(" in ").append(minfo.getConstPool().getClassName())
			.append(": ")
			.append(Throwable.instancehelper_getMessage(cause))
			.toString(), cause)
	{
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected BadBytecode(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
