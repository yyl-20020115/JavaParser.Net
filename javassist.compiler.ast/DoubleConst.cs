using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
public class DoubleConst : ASTree
{
	private const long serialVersionUID = 1L;

	protected internal double value;

	protected internal int type;

	public virtual double get()
	{
		return value;
	}

	public virtual int getType()
	{
		return type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 0, 104, 112, 104, 144 })]
	public virtual ASTree compute(int op, ASTree right)
	{
		if (right is IntConst)
		{
			DoubleConst result = compute0(op, (IntConst)right);
			_ = null;
			return result;
		}
		if (right is DoubleConst)
		{
			DoubleConst result2 = compute0(op, (DoubleConst)right);
			_ = null;
			return result2;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	public DoubleConst(double v, int tokenId)
	{
		value = v;
		type = tokenId;
	}

	public virtual void set(double v)
	{
		value = v;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(70)]
	private DoubleConst compute0(int P_0, IntConst P_1)
	{
		DoubleConst result = compute(P_0, value, P_1.value, type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 10, 154, 136, 134 })]
	private DoubleConst compute0(int P_0, DoubleConst P_1)
	{
		int num = ((type != 405 && P_1.type != 405) ? 404 : 405);
		DoubleConst result = compute(P_0, value, P_1.value, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		27, 159, 24, 103, 130, 103, 130, 103, 130, 103,
		130, 103, 130, 162
	})]
	private static DoubleConst compute(int P_0, double P_1, double P_2, int P_3)
	{
		double v;
		switch (P_0)
		{
		case 43:
			v = P_1 + P_2;
			break;
		case 45:
			v = P_1 - P_2;
			break;
		case 42:
			v = P_1 * P_2;
			break;
		case 47:
			v = P_1 / P_2;
			break;
		case 37:
			v = P_1 % P_2;
			break;
		default:
			return null;
		}
		DoubleConst result = new DoubleConst(v, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	public override string toString()
	{
		string result = java.lang.Double.toString(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 159, 188, 105 })]
	public override void accept(Visitor v)
	{
		v.atDoubleConst(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected DoubleConst(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
