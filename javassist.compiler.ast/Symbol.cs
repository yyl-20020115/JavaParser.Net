using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;

namespace javassist.compiler.ast;

[Serializable]
public class Symbol : ASTree
{
	private const long serialVersionUID = 1L;

	protected internal string identifier;

	public virtual string get()
	{
		return identifier;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 171, 104, 103 })]
	public Symbol(string sym)
	{
		identifier = sym;
	}

	public override string toString()
	{
		return identifier;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(39)]
	public override void accept(Visitor v)
	{
		v.atSymbol(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Symbol(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
