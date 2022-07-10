using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
public class ASTList : ASTree
{
	private const long serialVersionUID = 1L;

	private ASTree left;

	private ASTList right;

	public virtual ASTree head()
	{
		return left;
	}

	public virtual ASTList tail()
	{
		return right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(78)]
	public override void accept(Visitor v)
	{
		v.atASTList(this);
	}

	public override ASTree getLeft()
	{
		return left;
	}

	public override ASTree getRight()
	{
		return right;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(102)]
	public virtual int length()
	{
		int result = length(this);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 56, 99, 130, 98, 99, 104, 166 })]
	public static int length(ASTList list)
	{
		if (list == null)
		{
			return 0;
		}
		int num = 0;
		while (list != null)
		{
			list = list.right;
			num++;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	public static ASTList make(ASTree e1, ASTree e2, ASTree e3)
	{
		ASTList result = new ASTList(e1, new ASTList(e2, new ASTList(e3)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 178, 104, 103, 103 })]
	public ASTList(ASTree _head)
	{
		left = _head;
		right = null;
	}

	public override void setLeft(ASTree _left)
	{
		left = _left;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 173, 104, 103, 103 })]
	public ASTList(ASTree _head, ASTList _tail)
	{
		left = _head;
		right = _tail;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(150)]
	public static ASTList append(ASTList a, ASTree b)
	{
		ASTList result = concat(a, new ASTList(b));
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 75, 98, 105, 137 })]
	public virtual ASTList sublist(int nth)
	{
		ASTList aSTList = this;
		while (true)
		{
			int num = nth;
			nth += -1;
			if (num <= 0)
			{
				break;
			}
			aSTList = aSTList.right;
		}
		return aSTList;
	}

	public virtual void setHead(ASTree _head)
	{
		left = _head;
	}

	[LineNumberTable(new byte[] { 107, 99, 98, 98, 104, 137, 103 })]
	public static ASTList concat(ASTList a, ASTList b)
	{
		if (a == null)
		{
			return b;
		}
		ASTList aSTList = a;
		while (aSTList.right != null)
		{
			aSTList = aSTList.right;
		}
		aSTList.right = b;
		return a;
	}

	[LineNumberTable(new byte[] { 6, 108 })]
	public override void setRight(ASTree _right)
	{
		right = (ASTList)_right;
	}

	public virtual void setTail(ASTList _tail)
	{
		right = _tail;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		32, 102, 108, 109, 105, 98, 99, 105, 103, 119,
		103, 130, 105
	})]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("(<");
		stringBuilder.append(getTag());
		stringBuilder.append('>');
		for (ASTList aSTList = this; aSTList != null; aSTList = aSTList.right)
		{
			stringBuilder.append(' ');
			ASTree aSTree = aSTList.left;
			stringBuilder.append((aSTree != null) ? aSTree.toString() : "<null>");
		}
		stringBuilder.append(')');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 87, 101, 105, 103, 226, 61, 233, 70 })]
	public virtual bool subst(ASTree newObj, ASTree oldObj)
	{
		for (ASTList aSTList = this; aSTList != null; aSTList = aSTList.right)
		{
			if (aSTList.left == oldObj)
			{
				aSTList.left = newObj;
				return true;
			}
		}
		return false;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ASTList(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
