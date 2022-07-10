using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace javassist.bytecode.stackmap;

public class TypedBlock : BasicBlock
{
	public new class Maker : BasicBlock.Maker
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(117)]
		public Maker()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(120)]
		protected internal override BasicBlock makeBlock(int pos)
		{
			TypedBlock result = new TypedBlock(pos);
			_ = null;
			return result;
		}

		[LineNumberTable(125)]
		protected internal override BasicBlock[] makeArray(int size)
		{
			return new TypedBlock[size];
		}
	}

	public int stackTop;

	public int numLocals;

	public TypeData[] localsTypes;

	public TypeData[] stackTypes;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		159, 132, 162, 113, 104, 110, 130, 103, 111, 112,
		109, 5, 165
	})]
	public static TypedBlock[] makeBlocks(MethodInfo minfo, CodeAttribute ca, bool optimize)
	{
		TypedBlock[] array = (TypedBlock[])new Maker().make(minfo);
		if (optimize && (nint)array.LongLength < 2 && (array.Length == 0 || array[0].incoming == 0))
		{
			return null;
		}
		ConstPool constPool = minfo.getConstPool();
		int num = ((((uint)minfo.getAccessFlags() & 8u) != 0) ? 1 : 0);
		array[0].initFirstBlock(ca.getMaxStack(), ca.getMaxLocals(), constPool.getClassName(), minfo.getDescriptor(), (byte)num != 0, minfo.isConstructor());
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 115, 105, 100, 134, 106, 101, 108, 101, 157 })]
	public static string getRetType(string desc)
	{
		int num = java.lang.String.instancehelper_indexOf(desc, 41);
		if (num < 0)
		{
			return "java.lang.Object";
		}
		switch (java.lang.String.instancehelper_charAt(desc, num + 1))
		{
		case '[':
		{
			string result2 = java.lang.String.instancehelper_substring(desc, num + 1);
			_ = null;
			return result2;
		}
		case 'L':
		{
			string result = java.lang.String.instancehelper_replace(java.lang.String.instancehelper_substring(desc, num + 2, java.lang.String.instancehelper_length(desc) - 1), '/', '.');
			_ = null;
			return result;
		}
		default:
			return "java.lang.Object";
		}
	}

	public virtual bool alreadySet()
	{
		return localsTypes != null;
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	public virtual void setStackMap(int st, TypeData[] stack, int nl, TypeData[] locals)
	{
		stackTop = st;
		stackTypes = stack;
		numLocals = nl;
		localsTypes = locals;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 52, 104, 104, 122, 100, 113, 162, 166, 135 })]
	public virtual void resetNumLocals()
	{
		if (localsTypes != null)
		{
			int i;
			for (i = localsTypes.Length; i > 0 && localsTypes[i - 1].isBasicType() == TypeTag.TOP && (i <= 1 || !localsTypes[i - 2].is2WordType()); i += -1)
			{
			}
			numLocals = i;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 105, 103 })]
	protected internal TypedBlock(int pos)
		: base(pos)
	{
		localsTypes = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		159,
		107,
		166,
		108,
		159,
		7,
		103,
		108,
		103,
		99,
		107,
		99,
		137,
		104,
		131,
		117,
		106,
		byte.MaxValue,
		2,
		69,
		226,
		61,
		97,
		223,
		7,
		103,
		103
	})]
	internal virtual void initFirstBlock(int P_0, int P_1, string P_2, string P_3, bool P_4, bool P_5)
	{
		if (java.lang.String.instancehelper_charAt(P_3, 0) != '(')
		{
			string msg = new StringBuilder().append("no method descriptor: ").append(P_3).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		stackTop = 0;
		stackTypes = TypeData.make(P_0);
		TypeData[] array = TypeData.make(P_1);
		if (P_5)
		{
			array[0] = new TypeData.UninitThis(P_2);
		}
		else if (!P_4)
		{
			array[0] = new TypeData.ClassName(P_2);
		}
		int num = (P_4 ? (-1) : 0);
		int num2 = 1;
		try
		{
			while (true)
			{
				int num3 = num2;
				num++;
				if ((num2 = descToTag(P_3, num3, num, array)) > 0)
				{
					if (array[num].is2WordType())
					{
						num++;
						array[num] = TypeTag.TOP;
					}
					continue;
				}
				break;
			}
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<StringIndexOutOfBoundsException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_00b4;
		}
		numLocals = num;
		localsTypes = array;
		return;
		IL_00b4:
		_ = null;
		string msg2 = new StringBuilder().append("bad method descriptor: ").append(P_3).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		23, 99, 129, 102, 100, 140, 100, 247, 59, 230,
		71
	})]
	private void printTypes(StringBuilder P_0, int P_1, TypeData[] P_2)
	{
		if (P_2 == null)
		{
			return;
		}
		for (int i = 0; i < P_1; i++)
		{
			if (i > 0)
			{
				P_0.append(", ");
			}
			TypeData typeData = P_2[i];
			P_0.append((typeData != null) ? typeData.toString() : "<>");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		124, 98, 98, 104, 101, 130, 101, 100, 175, 101,
		111, 100, 150, 118, 107, 130, 100, 117, 162, 104,
		100, 159, 6, 101
	})]
	private static int descToTag(string P_0, int P_1, int P_2, TypeData[] P_3)
	{
		int num = P_1;
		int num2 = 0;
		int num3 = java.lang.String.instancehelper_charAt(P_0, P_1);
		if (num3 == 41)
		{
			return 0;
		}
		while (true)
		{
			switch (num3)
			{
			case 91:
				break;
			case 76:
			{
				P_1++;
				int num4 = java.lang.String.instancehelper_indexOf(P_0, 59, P_1);
				if (num2 > 0)
				{
					num4++;
					P_3[P_2] = new TypeData.ClassName(java.lang.String.instancehelper_substring(P_0, num, num4));
				}
				else
				{
					int beginIndex = num + 1;
					num4++;
					P_3[P_2] = new TypeData.ClassName(java.lang.String.instancehelper_replace(java.lang.String.instancehelper_substring(P_0, beginIndex, num4 - 1), '/', '.'));
				}
				return num4;
			}
			default:
			{
				if (num2 > 0)
				{
					P_1++;
					P_3[P_2] = new TypeData.ClassName(java.lang.String.instancehelper_substring(P_0, num, P_1));
					return P_1;
				}
				TypeData typeData = toPrimitiveTag((char)num3);
				if (typeData == null)
				{
					string msg = new StringBuilder().append("bad method descriptor: ").append(P_0).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new BadBytecode(msg);
				}
				P_3[P_2] = typeData;
				return P_1 + 1;
			}
			}
			num2++;
			P_1++;
			num3 = java.lang.String.instancehelper_charAt(P_0, P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159,
		90,
		98,
		byte.MaxValue,
		80,
		70,
		134,
		134,
		134,
		166
	})]
	private static TypeData toPrimitiveTag(char P_0)
	{
		switch (P_0)
		{
		case 'B':
		case 'C':
		case 'I':
		case 'S':
		case 'Z':
			return TypeTag.INTEGER;
		case 'J':
			return TypeTag.LONG;
		case 'F':
			return TypeTag.FLOAT;
		case 'D':
			return TypeTag.DOUBLE;
		default:
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 103, 108, 115, 108, 115, 105 })]
	protected internal override void toString2(StringBuilder sbuf)
	{
		base.toString2(sbuf);
		sbuf.append(",\n stack={");
		printTypes(sbuf, stackTop, stackTypes);
		sbuf.append("}, locals={");
		printTypes(sbuf, numLocals, localsTypes);
		sbuf.append('}');
	}
}
