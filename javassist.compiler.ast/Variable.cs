using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
public class Variable : Symbol
{
	private const long serialVersionUID = 1L;

	protected internal Declarator declarator;

	public virtual Declarator getDeclarator()
	{
		return declarator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 172, 105, 103 })]
	public Variable(string sym, Declarator d)
		: base(sym)
	{
		declarator = d;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	public override string toString()
	{
		string result = new StringBuilder().append(identifier).append(":").append(declarator.getType())
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(42)]
	public override void accept(Visitor v)
	{
		v.atVariable(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Variable(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
