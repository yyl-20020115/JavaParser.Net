using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;

namespace javassist.compiler.ast;

[Serializable]
public class CallExpr : Expr
{
	private const long serialVersionUID = 1L;

	private MemberResolver.Method method;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	public static CallExpr makeCall(ASTree target, ASTree args)
	{
		CallExpr result = new CallExpr(target, new ASTList(args));
		_ = null;
		return result;
	}

	public virtual MemberResolver.Method getMethod()
	{
		return method;
	}

	public virtual void setMethod(MemberResolver.Method m)
	{
		method = m;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 108, 103 })]
	private CallExpr(ASTree P_0, ASTList P_1)
		: base(67, P_0, P_1)
	{
		method = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(49)]
	public override void accept(Visitor v)
	{
		v.atCallExpr(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected CallExpr(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
