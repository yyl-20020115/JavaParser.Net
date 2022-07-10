using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
public class Keyword : ASTree
{
	private const long serialVersionUID = 1L;

	protected internal int tokenId;

	public virtual int get()
	{
		return tokenId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 171, 104, 103 })]
	public Keyword(int token)
	{
		tokenId = token;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	public override string toString()
	{
		string result = new StringBuilder().append("id:").append(tokenId).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(39)]
	public override void accept(Visitor v)
	{
		v.atKeyword(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Keyword(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
