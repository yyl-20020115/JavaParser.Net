using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;

namespace javassist.compiler.ast;

[Serializable]
public class IntConst : ASTree
{
	private const long serialVersionUID = 1L;

	protected internal long value;

	protected internal int type;

	public virtual long get()
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
			IntConst result = compute0(op, (IntConst)right);
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
	public IntConst(long v, int tokenId)
	{
		value = v;
		type = tokenId;
	}

	public virtual void set(long v)
	{
		value = v;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		9, 103, 135, 112, 104, 144, 136, 134, 103, 136,
		159, 100, 102, 133, 102, 133, 102, 133, 111, 133,
		113, 133, 102, 133, 102, 130, 102, 130, 111, 98,
		130, 111, 98, 130, 111, 98, 130, 162
	})]
	private IntConst compute0(int P_0, IntConst P_1)
	{
		int num = type;
		int num2 = P_1.type;
		int tokenId = ((num == 403 || num2 == 403) ? 403 : ((num != 401 || num2 != 401) ? 402 : 401));
		long num3 = value;
		long num4 = P_1.value;
		long v;
		switch (P_0)
		{
		case 43:
			v = num3 + num4;
			break;
		case 45:
			v = num3 - num4;
			break;
		case 42:
			v = num3 * num4;
			break;
		case 47:
			v = ((num4 != -1) ? (num3 / num4) : (-num3));
			break;
		case 37:
			v = ((num4 != -1) ? (num3 % num4) : 0);
			break;
		case 124:
			v = num3 | num4;
			break;
		case 94:
			v = num3 ^ num4;
			break;
		case 38:
			v = num3 & num4;
			break;
		case 364:
			v = value << (int)num4;
			tokenId = num;
			break;
		case 366:
			v = value >> (int)num4;
			tokenId = num;
			break;
		case 370:
			v = (long)((ulong)value >> (int)num4);
			tokenId = num;
			break;
		default:
			return null;
		}
		IntConst result = new IntConst(v, tokenId);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		68, 104, 135, 159, 24, 101, 130, 101, 130, 101,
		130, 101, 130, 101, 130, 162
	})]
	private DoubleConst compute0(int P_0, DoubleConst P_1)
	{
		double num = value;
		double num2 = P_1.value;
		double v;
		switch (P_0)
		{
		case 43:
			v = num + num2;
			break;
		case 45:
			v = num - num2;
			break;
		case 42:
			v = num * num2;
			break;
		case 47:
			v = num / num2;
			break;
		case 37:
			v = num % num2;
			break;
		default:
			return null;
		}
		DoubleConst result = new DoubleConst(v, P_1.type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	public override string toString()
	{
		string result = Long.toString(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.compiler.CompileError" })]
	[LineNumberTable(new byte[] { 159, 188, 105 })]
	public override void accept(Visitor v)
	{
		v.atIntConst(this);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected IntConst(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
