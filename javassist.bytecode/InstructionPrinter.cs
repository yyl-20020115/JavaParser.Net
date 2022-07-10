using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;

namespace javassist.bytecode;

public class InstructionPrinter : Object, Opcode
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static string[] opcodes;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private PrintStream stream;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 177, 104, 103 })]
	public InstructionPrinter(PrintStream stream)
	{
		this.stream = stream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		0, 103, 103, 103, 99, 129, 103, 171, 188, 2,
		98, 173, 127, 21, 101
	})]
	public virtual void print(CtMethod method)
	{
		MethodInfo methodInfo = method.getMethodInfo2();
		ConstPool constPool = methodInfo.getConstPool();
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			return;
		}
		CodeIterator codeIterator = codeAttribute.iterator();
		while (codeIterator.hasNext())
		{
			int num;
			BadBytecode badBytecode;
			try
			{
				num = codeIterator.next();
			}
			catch (BadBytecode x)
			{
				badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0043;
			}
			stream.println(new StringBuilder().append(num).append(": ").append(instructionString(codeIterator, num, constPool))
				.toString());
			continue;
			IL_0043:
			BadBytecode cause = badBytecode;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(cause);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		24,
		136,
		109,
		159,
		22,
		104,
		159,
		162,
		151,
		159,
		12,
		159,
		12,
		191,
		18,
		byte.MaxValue,
		18,
		75,
		byte.MaxValue,
		12,
		81,
		159,
		14,
		191,
		36,
		159,
		14,
		159,
		12,
		138,
		234,
		69,
		223,
		18,
		159,
		18,
		159,
		18,
		159,
		12,
		159,
		18,
		191,
		17,
		159,
		18,
		138,
		191,
		18,
		159,
		14
	})]
	public static string instructionString(CodeIterator iter, int pos, ConstPool pool)
	{
		int num = iter.byteAt(pos);
		if (num > (nint)opcodes.LongLength || num < 0)
		{
			string s = new StringBuilder().append("Invalid opcode, opcode: ").append(num).append(" pos: ")
				.append(pos)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		string text = opcodes[num];
		switch (num)
		{
		case 16:
		{
			string result21 = new StringBuilder().append(text).append(" ").append(iter.byteAt(pos + 1))
				.toString();
			_ = null;
			return result21;
		}
		case 17:
		{
			string result20 = new StringBuilder().append(text).append(" ").append(iter.s16bitAt(pos + 1))
				.toString();
			_ = null;
			return result20;
		}
		case 18:
		{
			string result19 = new StringBuilder().append(text).append(" ").append(ldc(pool, iter.byteAt(pos + 1)))
				.toString();
			_ = null;
			return result19;
		}
		case 19:
		case 20:
		{
			string result18 = new StringBuilder().append(text).append(" ").append(ldc(pool, iter.u16bitAt(pos + 1)))
				.toString();
			_ = null;
			return result18;
		}
		case 21:
		case 22:
		case 23:
		case 24:
		case 25:
		case 54:
		case 55:
		case 56:
		case 57:
		case 58:
		{
			string result17 = new StringBuilder().append(text).append(" ").append(iter.byteAt(pos + 1))
				.toString();
			_ = null;
			return result17;
		}
		case 153:
		case 154:
		case 155:
		case 156:
		case 157:
		case 158:
		case 159:
		case 160:
		case 161:
		case 162:
		case 163:
		case 164:
		case 165:
		case 166:
		case 198:
		case 199:
		{
			string result16 = new StringBuilder().append(text).append(" ").append(iter.s16bitAt(pos + 1) + pos)
				.toString();
			_ = null;
			return result16;
		}
		case 132:
		{
			string result15 = new StringBuilder().append(text).append(" ").append(iter.byteAt(pos + 1))
				.append(", ")
				.append(iter.signedByteAt(pos + 2))
				.toString();
			_ = null;
			return result15;
		}
		case 167:
		case 168:
		{
			string result14 = new StringBuilder().append(text).append(" ").append(iter.s16bitAt(pos + 1) + pos)
				.toString();
			_ = null;
			return result14;
		}
		case 169:
		{
			string result13 = new StringBuilder().append(text).append(" ").append(iter.byteAt(pos + 1))
				.toString();
			_ = null;
			return result13;
		}
		case 170:
		{
			string result12 = tableSwitch(iter, pos);
			_ = null;
			return result12;
		}
		case 171:
		{
			string result11 = lookupSwitch(iter, pos);
			_ = null;
			return result11;
		}
		case 178:
		case 179:
		case 180:
		case 181:
		{
			string result10 = new StringBuilder().append(text).append(" ").append(fieldInfo(pool, iter.u16bitAt(pos + 1)))
				.toString();
			_ = null;
			return result10;
		}
		case 182:
		case 183:
		case 184:
		{
			string result9 = new StringBuilder().append(text).append(" ").append(methodInfo(pool, iter.u16bitAt(pos + 1)))
				.toString();
			_ = null;
			return result9;
		}
		case 185:
		{
			string result8 = new StringBuilder().append(text).append(" ").append(interfaceMethodInfo(pool, iter.u16bitAt(pos + 1)))
				.toString();
			_ = null;
			return result8;
		}
		case 186:
		{
			string result7 = new StringBuilder().append(text).append(" ").append(iter.u16bitAt(pos + 1))
				.toString();
			_ = null;
			return result7;
		}
		case 187:
		{
			string result6 = new StringBuilder().append(text).append(" ").append(classInfo(pool, iter.u16bitAt(pos + 1)))
				.toString();
			_ = null;
			return result6;
		}
		case 188:
		{
			string result5 = new StringBuilder().append(text).append(" ").append(arrayInfo(iter.byteAt(pos + 1)))
				.toString();
			_ = null;
			return result5;
		}
		case 189:
		case 192:
		{
			string result4 = new StringBuilder().append(text).append(" ").append(classInfo(pool, iter.u16bitAt(pos + 1)))
				.toString();
			_ = null;
			return result4;
		}
		case 196:
		{
			string result3 = wide(iter, pos);
			_ = null;
			return result3;
		}
		case 197:
		{
			string result2 = new StringBuilder().append(text).append(" ").append(classInfo(pool, iter.u16bitAt(pos + 1)))
				.toString();
			_ = null;
			return result2;
		}
		case 200:
		case 201:
		{
			string result = new StringBuilder().append(text).append(" ").append(iter.s32bitAt(pos + 1) + pos)
				.toString();
			_ = null;
			return result;
		}
		default:
			return text;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 163, 104, 159, 6, 159, 30, 159, 20, 159,
		20, 159, 20, 159, 20, 138
	})]
	private static string ldc(ConstPool P_0, int P_1)
	{
		int tag = P_0.getTag(P_1);
		switch (tag)
		{
		case 8:
		{
			string result6 = new StringBuilder().append("#").append(P_1).append(" = \"")
				.append(P_0.getStringInfo(P_1))
				.append("\"")
				.toString();
			_ = null;
			return result6;
		}
		case 3:
		{
			string result5 = new StringBuilder().append("#").append(P_1).append(" = int ")
				.append(P_0.getIntegerInfo(P_1))
				.toString();
			_ = null;
			return result5;
		}
		case 4:
		{
			string result4 = new StringBuilder().append("#").append(P_1).append(" = float ")
				.append(P_0.getFloatInfo(P_1))
				.toString();
			_ = null;
			return result4;
		}
		case 5:
		{
			string result3 = new StringBuilder().append("#").append(P_1).append(" = long ")
				.append(P_0.getLongInfo(P_1))
				.toString();
			_ = null;
			return result3;
		}
		case 6:
		{
			string result2 = new StringBuilder().append("#").append(P_1).append(" = double ")
				.append(P_0.getDoubleInfo(P_1))
				.toString();
			_ = null;
			return result2;
		}
		case 7:
		{
			string result = classInfo(P_0, P_1);
			_ = null;
			return result;
		}
		default:
		{
			string message = new StringBuilder().append("bad LDC: ").append(tag).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 143, 107, 135, 127, 2, 108, 108, 175, 104,
		107, 31, 12, 236, 69, 112
	})]
	private static string tableSwitch(CodeIterator P_0, int P_1)
	{
		StringBuilder stringBuilder = new StringBuilder("tableswitch {\n");
		int num = (P_1 & -4) + 4;
		stringBuilder.append("\t\tdefault: ").append(P_1 + P_0.s32bitAt(num)).append('\n');
		num += 4;
		int num2 = P_0.s32bitAt(num);
		num += 4;
		int num3 = P_0.s32bitAt(num);
		int num4 = (num3 - num2 + 1) * 4;
		num += 4;
		int num5 = num4 + num;
		int num6 = num2;
		while (num < num5)
		{
			int i = P_0.s32bitAt(num) + P_1;
			stringBuilder.append("\t\t").append(num6).append(": ")
				.append(i)
				.append('\n');
			num += 4;
			num6++;
		}
		stringBuilder.setCharAt(stringBuilder.length() - 1, '}');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		124,
		107,
		135,
		127,
		2,
		108,
		138,
		100,
		105,
		109,
		byte.MaxValue,
		12,
		61,
		230,
		70,
		112
	})]
	private static string lookupSwitch(CodeIterator P_0, int P_1)
	{
		StringBuilder stringBuilder = new StringBuilder("lookupswitch {\n");
		int num = (P_1 & -4) + 4;
		stringBuilder.append("\t\tdefault: ").append(P_1 + P_0.s32bitAt(num)).append('\n');
		num += 4;
		int num2 = P_0.s32bitAt(num);
		int num3 = num2 * 8;
		num += 4;
		for (int num4 = num3 + num; num < num4; num += 8)
		{
			int i = P_0.s32bitAt(num);
			int i2 = P_0.s32bitAt(num + 4) + P_1;
			stringBuilder.append("\t\t").append(i).append(": ")
				.append(i2)
				.append('\n');
		}
		stringBuilder.setCharAt(stringBuilder.length() - 1, '}');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 116, 127, 2, 118, 118, 251, 61 })]
	private static string fieldInfo(ConstPool P_0, int P_1)
	{
		string result = new StringBuilder().append("#").append(P_1).append(" = Field ")
			.append(P_0.getFieldrefClassName(P_1))
			.append(".")
			.append(P_0.getFieldrefName(P_1))
			.append("(")
			.append(P_0.getFieldrefType(P_1))
			.append(")")
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 108, 127, 2, 118, 118, 251, 61 })]
	private static string methodInfo(ConstPool P_0, int P_1)
	{
		string result = new StringBuilder().append("#").append(P_1).append(" = Method ")
			.append(P_0.getMethodrefClassName(P_1))
			.append(".")
			.append(P_0.getMethodrefName(P_1))
			.append("(")
			.append(P_0.getMethodrefType(P_1))
			.append(")")
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 101, 127, 2, 118, 118, 251, 61 })]
	private static string interfaceMethodInfo(ConstPool P_0, int P_1)
	{
		string result = new StringBuilder().append("#").append(P_1).append(" = Method ")
			.append(P_0.getInterfaceMethodrefClassName(P_1))
			.append(".")
			.append(P_0.getInterfaceMethodrefName(P_1))
			.append("(")
			.append(P_0.getInterfaceMethodrefType(P_1))
			.append(")")
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(210)]
	private static string classInfo(ConstPool P_0, int P_1)
	{
		string result = new StringBuilder().append("#").append(P_1).append(" = Class ")
			.append(P_0.getClassInfo(P_1))
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 72, 159, 11, 134, 134, 134, 134, 134, 134,
		134, 134
	})]
	private static string arrayInfo(int P_0)
	{
		switch (P_0)
		{
		case 4:
			return "boolean";
		case 5:
			return "char";
		case 8:
			return "byte";
		case 9:
			return "short";
		case 10:
			return "int";
		case 11:
			return "long";
		case 6:
			return "float";
		case 7:
			return "double";
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("Invalid array type");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		113,
		106,
		106,
		byte.MaxValue,
		84,
		77,
		159,
		10
	})]
	private static string wide(CodeIterator P_0, int P_1)
	{
		int num = P_0.byteAt(P_1 + 1);
		int i = P_0.u16bitAt(P_1 + 2);
		if (num == 21 || num == 22 || num == 23 || num == 24 || num == 25 || num == 54 || num == 55 || num == 56 || num == 57 || num == 58 || num == 132 || num == 169)
		{
			string result = new StringBuilder().append(opcodes[num]).append(" ").append(i)
				.toString();
			_ = null;
			return result;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException("Invalid WIDE operand");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 185, 110 })]
	public static void print(CtMethod method, PrintStream stream)
	{
		new InstructionPrinter(stream).print(method);
	}

	[LineNumberTable(29)]
	static InstructionPrinter()
	{
		opcodes = Mnemonic.OPCODE;
	}
}
