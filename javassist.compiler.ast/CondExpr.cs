using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;

namespace javassist.compiler.ast;

[Serializable]
public class CondExpr : ASTList
{
	private const long serialVersionUID = 1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(32)]
	public virtual ASTree condExpr()
	{
		ASTree result = head();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	public virtual ASTree elseExpr()
	{
		ASTree result = tail().tail().head();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	public virtual ASTree thenExpr()
	{
		ASTree result = tail().head();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	public virtual void setThen(ASTree t)
	{
		tail().setHead(t);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	public virtual void setElse(ASTree t)
	{
		tail().tail().setHead(t);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 171, 117 })]
	public CondExpr(ASTree cond, ASTree thenp, ASTree elsep)
		: base(cond, new ASTList(thenp, new ASTList(elsep)))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(34)]
	public virtual void setCond(ASTree t)
	{
		setHead(t);
	}

	public override string getTag()
	{
		return "?:";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(48)]
	public override void accept(Visitor v)
	{
		v.atCondExpr(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected CondExpr(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
