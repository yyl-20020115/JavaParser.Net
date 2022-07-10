using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
[Implements(new string[] { "javassist.compiler.TokenId" })]
public class Expr : ASTList, TokenId
{
	private const long serialVersionUID = 1L;

	protected internal int operatorId;

	public virtual int getOperator()
	{
		return operatorId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	public virtual ASTree oprand1()
	{
		ASTree result = getLeft();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	public virtual ASTree oprand2()
	{
		ASTree result = getRight().getLeft();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 24, 103, 104, 106, 112, 110, 104, 134 })]
	public virtual string getName()
	{
		int num = operatorId;
		if (num < 128)
		{
			string result = java.lang.String.valueOf((char)num);
			_ = null;
			return result;
		}
		if (350 <= num && num <= 371)
		{
			return TokenId.opNames[num - 350];
		}
		if (num == 323)
		{
			return "instanceof";
		}
		string result2 = java.lang.String.valueOf(num);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	public static Expr make(int op, ASTree oprand1, ASTree oprand2)
	{
		Expr result = new Expr(op, oprand1, new ASTList(oprand2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(71)]
	public override void accept(Visitor v)
	{
		v.atExpr(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 105 })]
	public virtual void setOprand1(ASTree expr)
	{
		setLeft(expr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 17, 110 })]
	public virtual void setOprand2(ASTree expr)
	{
		getRight().setLeft(expr);
	}

	public virtual void setOperator(int op)
	{
		operatorId = op;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	public static Expr make(int op, ASTree oprand1)
	{
		Expr result = new Expr(op, oprand1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 179, 106, 103 })]
	internal Expr(int P_0, ASTree P_1, ASTList P_2)
		: base(P_1, P_2)
	{
		operatorId = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 105, 103 })]
	internal Expr(int P_0, ASTree P_1)
		: base(P_1)
	{
		operatorId = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(87)]
	protected internal override string getTag()
	{
		string result = new StringBuilder().append("op:").append(getName()).toString();
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Expr(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
