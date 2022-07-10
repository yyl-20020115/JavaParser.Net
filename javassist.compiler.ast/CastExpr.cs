using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
[Implements(new string[] { "javassist.compiler.TokenId" })]
public class CastExpr : ASTList, TokenId
{
	private const long serialVersionUID = 1L;

	protected internal int castType;

	protected internal int arrayDim;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(49)]
	public virtual ASTList getClassName()
	{
		return (ASTList)getLeft();
	}

	public virtual int getType()
	{
		return castType;
	}

	public virtual int getArrayDim()
	{
		return arrayDim;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	public virtual ASTree getOprand()
	{
		ASTree result = getRight().getLeft();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 111, 103, 103 })]
	public CastExpr(int type, int dim, ASTree expr)
		: base(null, new ASTList(expr))
	{
		castType = type;
		arrayDim = dim;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 111, 107, 103 })]
	public CastExpr(ASTList className, int dim, ASTree expr)
		: base(className, new ASTList(expr))
	{
		castType = 307;
		arrayDim = dim;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public virtual void setOprand(ASTree t)
	{
		getRight().setLeft(t);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(56)]
	public override string getTag()
	{
		string result = new StringBuilder().append("cast:").append(castType).append(":")
			.append(arrayDim)
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(59)]
	public override void accept(Visitor v)
	{
		v.atCastExpr(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected CastExpr(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
