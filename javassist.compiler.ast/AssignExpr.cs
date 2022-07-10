using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;

namespace javassist.compiler.ast;

[Serializable]
public class AssignExpr : Expr
{
	private const long serialVersionUID = 1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	public static AssignExpr makeAssign(int op, ASTree oprand1, ASTree oprand2)
	{
		AssignExpr result = new AssignExpr(op, oprand1, new ASTList(oprand2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 175, 107 })]
	private AssignExpr(int P_0, ASTree P_1, ASTList P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 159, 185, 105 })]
	public override void accept(Visitor v)
	{
		v.atAssignExpr(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected AssignExpr(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
