using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
[Implements(new string[] { "javassist.compiler.TokenId" })]
public class Stmnt : ASTList, TokenId
{
	private const long serialVersionUID = 1L;

	protected internal int operatorId;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(53)]
	public override void accept(Visitor v)
	{
		v.atStmnt(this);
	}

	public virtual int getOperator()
	{
		return operatorId;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 106 })]
	public Stmnt(int op)
		: this(op, null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	public static Stmnt make(int op, ASTree oprand1, ASTree oprand2)
	{
		Stmnt result = new Stmnt(op, oprand1, new ASTList(oprand2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 178, 105, 103 })]
	public Stmnt(int op, ASTree _head)
		: base(_head)
	{
		operatorId = op;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 173, 106, 103 })]
	public Stmnt(int op, ASTree _head, ASTList _tail)
		: base(_head, _tail)
	{
		operatorId = op;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(49)]
	public static Stmnt make(int op, ASTree op1, ASTree op2, ASTree op3)
	{
		Stmnt result = new Stmnt(op, op1, new ASTList(op2, new ASTList(op3)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 109, 127, 4 })]
	protected internal override string getTag()
	{
		if (operatorId < 128)
		{
			string result = new StringBuilder().append("stmnt:").append((char)operatorId).toString();
			_ = null;
			return result;
		}
		string result2 = new StringBuilder().append("stmnt:").append(operatorId).toString();
		_ = null;
		return result2;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Stmnt(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
