using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;

namespace javassist.compiler.ast;

[Serializable]
[Implements(new string[] { "javassist.compiler.TokenId" })]
public class NewExpr : ASTList, TokenId
{
	private const long serialVersionUID = 1L;

	protected internal bool newArray;

	protected internal int arrayType;

	public virtual bool isArray()
	{
		return newArray;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(61)]
	public virtual ASTList getClassName()
	{
		return (ASTList)getLeft();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(63)]
	public virtual ASTList getArguments()
	{
		return (ASTList)getRight().getLeft();
	}

	public virtual int getArrayType()
	{
		return arrayType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	public virtual ASTList getArraySize()
	{
		ASTList arguments = getArguments();
		_ = null;
		return arguments;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 18, 108, 99, 98 })]
	public virtual ArrayInit getInitializer()
	{
		ASTree aSTree = getRight().getRight();
		if (aSTree == null)
		{
			return null;
		}
		return (ArrayInit)aSTree.getLeft();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 111, 103, 107 })]
	public NewExpr(ASTList className, ASTList args)
		: base(className, new ASTList(args))
	{
		newArray = false;
		arrayType = 307;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 111, 103, 103, 99, 104 })]
	public NewExpr(int type, ASTList arraySize, ArrayInit init)
		: base(null, new ASTList(arraySize))
	{
		newArray = true;
		arrayType = type;
		if (init != null)
		{
			ASTList.append(this, init);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 104, 103, 99, 136 })]
	public static NewExpr makeObjectArray(ASTList className, ASTList arraySize, ArrayInit init)
	{
		NewExpr newExpr = new NewExpr(className, arraySize);
		newExpr.newArray = true;
		if (init != null)
		{
			ASTList.append(newExpr, init);
		}
		return newExpr;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(75)]
	public override void accept(Visitor v)
	{
		v.atNewExpr(this);
	}

	protected internal override string getTag()
	{
		return (!newArray) ? "new" : "new[]";
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected NewExpr(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
