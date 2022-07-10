using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.bytecode;

internal class CodeAnalyzer : Object, Opcode
{
	private ConstPool constPool;

	private CodeAttribute codeAttr;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 100, 103, 99, 103, 102, 43, 166 })]
	private void initStack(int[] P_0, CodeAttribute P_1)
	{
		P_0[0] = -1;
		ExceptionTable exceptionTable = P_1.getExceptionTable();
		if (exceptionTable != null)
		{
			int num = exceptionTable.size();
			for (int i = 0; i < num; i++)
			{
				P_0[exceptionTable.handlerPc(i)] = -2;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		25, 99, 103, 101, 103, 100, 107, 104, 100, 104,
		107, 100, 159, 6, 111, 130, 104, 130, 112, 100,
		101
	})]
	private void visitBytecode(CodeIterator P_0, int[] P_1, int P_2)
	{
		int num = P_1.Length;
		P_0.move(P_2);
		int num2 = -P_1[P_2];
		int[] array = new int[1] { -1 };
		while (P_0.hasNext())
		{
			P_2 = P_0.next();
			P_1[P_2] = num2;
			int num3 = P_0.byteAt(P_2);
			num2 = visitInst(num3, P_0, P_2, num2);
			if (num2 < 1)
			{
				string msg = new StringBuilder().append("stack underflow at ").append(P_2).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadBytecode(msg);
			}
			if (processBranch(num3, P_0, P_2, num, P_1, num2, array) || isEnd(num3))
			{
				break;
			}
			if (num3 == 168 || num3 == 201)
			{
				num2 += -1;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 102, 159, 66, 111, 133, 111, 133, 109, 133,
		109, 165, 117, 109, 133, 117, 107, 133, 106, 37,
		134, 109, 130, 117, 107, 130, 99, 130, 112, 130,
		171, 172
	})]
	private int visitInst(int P_0, CodeIterator P_1, int P_2, int P_3)
	{
		switch (P_0)
		{
		case 180:
			P_3 += getFieldSize(P_1, P_2) - 1;
			break;
		case 181:
			P_3 -= getFieldSize(P_1, P_2) + 1;
			break;
		case 178:
			P_3 += getFieldSize(P_1, P_2);
			break;
		case 179:
			P_3 -= getFieldSize(P_1, P_2);
			break;
		case 182:
		case 183:
		{
			string invokeDynamicType = constPool.getMethodrefType(P_1.u16bitAt(P_2 + 1));
			P_3 += Descriptor.dataSize(invokeDynamicType) - 1;
			break;
		}
		case 184:
		{
			string invokeDynamicType = constPool.getMethodrefType(P_1.u16bitAt(P_2 + 1));
			P_3 += Descriptor.dataSize(invokeDynamicType);
			break;
		}
		case 185:
		{
			string invokeDynamicType = constPool.getInterfaceMethodrefType(P_1.u16bitAt(P_2 + 1));
			P_3 += Descriptor.dataSize(invokeDynamicType) - 1;
			break;
		}
		case 186:
		{
			string invokeDynamicType = constPool.getInvokeDynamicType(P_1.u16bitAt(P_2 + 1));
			P_3 += Descriptor.dataSize(invokeDynamicType);
			break;
		}
		case 191:
			P_3 = 1;
			break;
		case 197:
			P_3 += 1 - P_1.byteAt(P_2 + 3);
			break;
		case 196:
			P_0 = P_1.byteAt(P_2 + 1);
			goto default;
		default:
			P_3 += Opcode.STACK_GROW[P_0];
			break;
		}
		return P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		53,
		159,
		1,
		108,
		110,
		165,
		159,
		65,
		108,
		110,
		130,
		108,
		110,
		162,
		104,
		142,
		140,
		238,
		72,
		103,
		102,
		130,
		104,
		130,
		223,
		26,
		103,
		104,
		130,
		106,
		130,
		byte.MaxValue,
		26,
		69,
		103,
		106,
		110,
		104,
		106,
		101,
		102,
		106,
		142,
		228,
		60,
		230,
		70,
		133,
		106,
		106,
		103,
		101,
		105,
		106,
		142,
		228,
		60,
		232,
		72,
		194
	})]
	private bool processBranch(int P_0, CodeIterator P_1, int P_2, int P_3, int[] P_4, int P_5, int[] P_6)
	{
		if ((153 <= P_0 && P_0 <= 166) || P_0 == 198 || P_0 == 199)
		{
			int num = P_2 + P_1.s16bitAt(P_2 + 1);
			checkTarget(P_2, num, P_3, P_4, P_5);
		}
		else
		{
			switch (P_0)
			{
			case 167:
			{
				int num = P_2 + P_1.s16bitAt(P_2 + 1);
				checkTarget(P_2, num, P_3, P_4, P_5);
				return true;
			}
			case 200:
			{
				int num = P_2 + P_1.s32bitAt(P_2 + 1);
				checkTarget(P_2, num, P_3, P_4, P_5);
				return true;
			}
			case 168:
			case 201:
			{
				int num = ((P_0 != 168) ? (P_2 + P_1.s32bitAt(P_2 + 1)) : (P_2 + P_1.s16bitAt(P_2 + 1)));
				checkTarget(P_2, num, P_3, P_4, P_5);
				if (P_6[0] < 0)
				{
					P_6[0] = P_5;
					return false;
				}
				if (P_5 == P_6[0])
				{
					return false;
				}
				string msg2 = new StringBuilder().append("sorry, cannot compute this data flow due to JSR: ").append(P_5).append(",")
					.append(P_6[0])
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadBytecode(msg2);
			}
			case 169:
			{
				if (P_6[0] < 0)
				{
					P_6[0] = P_5 + 1;
					return false;
				}
				if (P_5 + 1 == P_6[0])
				{
					return true;
				}
				string msg = new StringBuilder().append("sorry, cannot compute this data flow due to RET: ").append(P_5).append(",")
					.append(P_6[0])
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadBytecode(msg);
			}
			case 170:
			case 171:
			{
				int num2 = (P_2 & -4) + 4;
				int num = P_2 + P_1.s32bitAt(num2);
				checkTarget(P_2, num, P_3, P_4, P_5);
				if (P_0 == 171)
				{
					int num3 = P_1.s32bitAt(num2 + 4);
					num2 += 12;
					for (int i = 0; i < num3; i++)
					{
						num = P_2 + P_1.s32bitAt(num2);
						checkTarget(P_2, num, P_3, P_4, P_5);
						num2 += 8;
					}
				}
				else
				{
					int num3 = P_1.s32bitAt(num2 + 4);
					int i = P_1.s32bitAt(num2 + 8);
					int num4 = i - num3 + 1;
					num2 += 12;
					for (int j = 0; j < num4; j++)
					{
						num = P_2 + P_1.s32bitAt(num2);
						checkTarget(P_2, num, P_3, P_4, P_5);
						num2 += 4;
					}
				}
				return true;
			}
			}
		}
		return false;
	}

	private static bool isEnd(int P_0)
	{
		return ((172 <= P_0 && P_0 <= 177) || P_0 == 191) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 80, 104, 159, 6, 101, 99, 105, 107, 159,
		39
	})]
	private void checkTarget(int P_0, int P_1, int P_2, int[] P_3, int P_4)
	{
		if (P_1 < 0 || P_2 <= P_1)
		{
			string msg = new StringBuilder().append("bad branch offset at ").append(P_0).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		int num = P_3[P_1];
		if (num == 0)
		{
			P_3[P_1] = -P_4;
		}
		else if (num != P_4 && num != -P_4)
		{
			string msg2 = new StringBuilder().append("verification error (").append(P_4).append(",")
				.append(num)
				.append(") at ")
				.append(P_0)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 150, 117 })]
	private int getFieldSize(CodeIterator P_0, int P_1)
	{
		string fieldrefType = constPool.getFieldrefType(P_0.u16bitAt(P_1 + 1));
		int result = Descriptor.dataSize(fieldrefType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 168, 104, 103, 108 })]
	public CodeAnalyzer(CodeAttribute P_0)
	{
		codeAttr = P_0;
		constPool = P_0.getConstPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		159, 181, 108, 103, 103, 113, 173, 98, 104, 103,
		98, 234, 61, 232, 69, 131, 99, 104, 104, 6,
		200
	})]
	public virtual int computeMaxStack()
	{
		CodeIterator codeIterator = codeAttr.iterator();
		int codeLength = codeIterator.getCodeLength();
		int[] array = new int[codeLength];
		constPool = codeAttr.getConstPool();
		initStack(array, codeAttr);
		int num;
		int i;
		do
		{
			num = 0;
			for (i = 0; i < codeLength; i++)
			{
				if (array[i] < 0)
				{
					num = 1;
					visitBytecode(codeIterator, array, i);
				}
			}
		}
		while (num != 0);
		i = 1;
		for (int j = 0; j < codeLength; j++)
		{
			if (array[j] > i)
			{
				i = array[j];
			}
		}
		return i - 1;
	}
}
