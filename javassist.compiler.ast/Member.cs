using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;

namespace javassist.compiler.ast;

[Serializable]
public class Member : Symbol
{
	private const long serialVersionUID = 1L;

	private CtField field;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 175, 105, 103 })]
	public Member(string name)
		: base(name)
	{
		field = null;
	}

	public virtual CtField getField()
	{
		return field;
	}

	public virtual void setField(CtField f)
	{
		field = f;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(42)]
	public override void accept(Visitor v)
	{
		v.atMember(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Member(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}