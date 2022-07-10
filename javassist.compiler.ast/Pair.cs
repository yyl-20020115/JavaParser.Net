using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
public class Pair : ASTree
{
	private const long serialVersionUID = 1L;

	protected internal ASTree left;

	protected internal ASTree right;

	public override ASTree getLeft()
	{
		return left;
	}

	public override ASTree getRight()
	{
		return right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 172, 104, 103, 103 })]
	public Pair(ASTree _left, ASTree _right)
	{
		left = _left;
		right = _right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(36)]
	public override void accept(Visitor v)
	{
		v.atPair(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 182, 102, 108, 127, 2, 108, 127, 2, 105 })]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("(<Pair> ");
		stringBuilder.append((left != null) ? left.toString() : "<null>");
		stringBuilder.append(" . ");
		stringBuilder.append((right != null) ? right.toString() : "<null>");
		stringBuilder.append(')');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	public override void setLeft(ASTree _left)
	{
		left = _left;
	}

	public override void setRight(ASTree _right)
	{
		right = _right;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Pair(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
