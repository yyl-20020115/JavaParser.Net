using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace javassist.bytecode.stackmap;

public abstract class Tracer : java.lang.Object, TypeTag
{
	protected internal ClassPool classPool;

	protected internal ConstPool cpool;

	protected internal string returnType;

	protected internal int stackTop;

	protected internal TypeData[] stackTypes;

	protected internal TypeData[] localsTypes;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		81, 103, 159, 160, 132, 133, 122, 229, 72, 122,
		165, 122, 122, 197, 122, 165, 122, 122, 165, 122,
		138, 107, 162, 111, 130, 144, 144, 144, 144, 238,
		69, 122, 229, 69, 122, 122, 229, 69, 122, 229,
		69, 122, 122, 229, 69, 101, 125, 133, 124, 133,
		111, 111, 133, 124, 133, 111, 111, 133, 119, 102,
		107, 194, 124, 130, 176
	})]
	private int doOpcode0_53(int P_0, byte[] P_1, int P_2)
	{
		TypeData[] array = stackTypes;
		switch (P_2)
		{
		case 1:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num17 = num;
			tracer.stackTop = num + 1;
			array[num17] = new TypeData.NullType();
			break;
		}
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num16 = num;
			tracer.stackTop = num + 1;
			array[num16] = TypeTag.INTEGER;
			break;
		}
		case 9:
		case 10:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num18 = num;
			tracer.stackTop = num + 1;
			array[num18] = TypeTag.LONG;
			num = stackTop;
			tracer = this;
			int num19 = num;
			tracer.stackTop = num + 1;
			array[num19] = TypeTag.TOP;
			break;
		}
		case 11:
		case 12:
		case 13:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num22 = num;
			tracer.stackTop = num + 1;
			array[num22] = TypeTag.FLOAT;
			break;
		}
		case 14:
		case 15:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num20 = num;
			tracer.stackTop = num + 1;
			array[num20] = TypeTag.DOUBLE;
			num = stackTop;
			tracer = this;
			int num21 = num;
			tracer.stackTop = num + 1;
			array[num21] = TypeTag.TOP;
			break;
		}
		case 16:
		case 17:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num15 = num;
			tracer.stackTop = num + 1;
			array[num15] = TypeTag.INTEGER;
			return (P_2 != 17) ? 2 : 3;
		}
		case 18:
			doLDC(P_1[P_0 + 1]);
			return 2;
		case 19:
		case 20:
			doLDC(ByteArray.readU16bit(P_1, P_0 + 1));
			return 3;
		case 21:
		{
			int result5 = doXLOAD(TypeTag.INTEGER, P_1, P_0);
			_ = null;
			return result5;
		}
		case 22:
		{
			int result4 = doXLOAD(TypeTag.LONG, P_1, P_0);
			_ = null;
			return result4;
		}
		case 23:
		{
			int result3 = doXLOAD(TypeTag.FLOAT, P_1, P_0);
			_ = null;
			return result3;
		}
		case 24:
		{
			int result2 = doXLOAD(TypeTag.DOUBLE, P_1, P_0);
			_ = null;
			return result2;
		}
		case 25:
		{
			int result = doALOAD(P_1[P_0 + 1]);
			_ = null;
			return result;
		}
		case 26:
		case 27:
		case 28:
		case 29:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num14 = num;
			tracer.stackTop = num + 1;
			array[num14] = TypeTag.INTEGER;
			break;
		}
		case 30:
		case 31:
		case 32:
		case 33:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num12 = num;
			tracer.stackTop = num + 1;
			array[num12] = TypeTag.LONG;
			num = stackTop;
			tracer = this;
			int num13 = num;
			tracer.stackTop = num + 1;
			array[num13] = TypeTag.TOP;
			break;
		}
		case 34:
		case 35:
		case 36:
		case 37:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num11 = num;
			tracer.stackTop = num + 1;
			array[num11] = TypeTag.FLOAT;
			break;
		}
		case 38:
		case 39:
		case 40:
		case 41:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num9 = num;
			tracer.stackTop = num + 1;
			array[num9] = TypeTag.DOUBLE;
			num = stackTop;
			tracer = this;
			int num10 = num;
			tracer.stackTop = num + 1;
			array[num10] = TypeTag.TOP;
			break;
		}
		case 42:
		case 43:
		case 44:
		case 45:
		{
			int num7 = P_2 - 42;
			int num = stackTop;
			Tracer tracer = this;
			int num8 = num;
			tracer.stackTop = num + 1;
			array[num8] = localsTypes[num7];
			break;
		}
		case 46:
		{
			int num = stackTop - 1;
			Tracer tracer = this;
			int num6 = num;
			tracer.stackTop = num;
			array[num6 - 1] = TypeTag.INTEGER;
			break;
		}
		case 47:
			array[stackTop - 2] = TypeTag.LONG;
			array[stackTop - 1] = TypeTag.TOP;
			break;
		case 48:
		{
			int num = stackTop - 1;
			Tracer tracer = this;
			int num5 = num;
			tracer.stackTop = num;
			array[num5 - 1] = TypeTag.FLOAT;
			break;
		}
		case 49:
			array[stackTop - 2] = TypeTag.DOUBLE;
			array[stackTop - 1] = TypeTag.TOP;
			break;
		case 50:
		{
			int num = stackTop - 1;
			Tracer tracer = this;
			int num3 = num;
			tracer.stackTop = num;
			int num4 = num3 - 1;
			TypeData array2 = array[num4];
			array[num4] = TypeData.ArrayElement.make(array2);
			break;
		}
		case 51:
		case 52:
		case 53:
		{
			int num = stackTop - 1;
			Tracer tracer = this;
			int num2 = num;
			tracer.stackTop = num;
			array[num2 - 1] = TypeTag.INTEGER;
			break;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("fatal");
		case 0:
			break;
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 179, 159, 160, 87, 144, 144, 144, 144, 238,
		69, 101, 109, 110, 229, 69, 101, 109, 111, 110,
		229, 69, 101, 109, 110, 229, 69, 101, 109, 111,
		110, 229, 69, 101, 104, 229, 69, 123, 133, 191,
		10, 110, 197, 110, 133, 110, 133, 110, 133, 103,
		114, 105, 165, 103, 104, 103, 114, 105, 133, 104,
		110, 165, 103, 104, 103, 114, 118, 105, 130, 105,
		105, 114, 107, 130, 176
	})]
	private int doOpcode54_95(int P_0, byte[] P_1, int P_2)
	{
		switch (P_2)
		{
		case 54:
		{
			int result2 = doXSTORE(P_0, P_1, TypeTag.INTEGER);
			_ = null;
			return result2;
		}
		case 55:
		{
			int result = doXSTORE(P_0, P_1, TypeTag.LONG);
			_ = null;
			return result;
		}
		case 56:
		{
			int result3 = doXSTORE(P_0, P_1, TypeTag.FLOAT);
			_ = null;
			return result3;
		}
		case 57:
		{
			int result4 = doXSTORE(P_0, P_1, TypeTag.DOUBLE);
			_ = null;
			return result4;
		}
		case 58:
		{
			int result5 = doASTORE(P_1[P_0 + 1]);
			_ = null;
			return result5;
		}
		case 59:
		case 60:
		case 61:
		case 62:
		{
			int num = P_2 - 59;
			localsTypes[num] = TypeTag.INTEGER;
			stackTop--;
			break;
		}
		case 63:
		case 64:
		case 65:
		case 66:
		{
			int num = P_2 - 63;
			localsTypes[num] = TypeTag.LONG;
			localsTypes[num + 1] = TypeTag.TOP;
			stackTop -= 2;
			break;
		}
		case 67:
		case 68:
		case 69:
		case 70:
		{
			int num = P_2 - 67;
			localsTypes[num] = TypeTag.FLOAT;
			stackTop--;
			break;
		}
		case 71:
		case 72:
		case 73:
		case 74:
		{
			int num = P_2 - 71;
			localsTypes[num] = TypeTag.DOUBLE;
			localsTypes[num + 1] = TypeTag.TOP;
			stackTop -= 2;
			break;
		}
		case 75:
		case 76:
		case 77:
		case 78:
		{
			int num = P_2 - 75;
			doASTORE(num);
			break;
		}
		case 79:
		case 80:
		case 81:
		case 82:
			stackTop -= ((P_2 != 80 && P_2 != 82) ? 3 : 4);
			break;
		case 83:
			TypeData.aastore(stackTypes[stackTop - 3], stackTypes[stackTop - 1], classPool);
			stackTop -= 3;
			break;
		case 84:
		case 85:
		case 86:
			stackTop -= 3;
			break;
		case 87:
			stackTop--;
			break;
		case 88:
			stackTop -= 2;
			break;
		case 89:
		{
			int num = stackTop;
			stackTypes[num] = stackTypes[num - 1];
			stackTop = num + 1;
			break;
		}
		case 90:
		case 91:
		{
			int num = P_2 - 90 + 2;
			doDUP_XX(1, num);
			int num2 = stackTop;
			stackTypes[num2 - num] = stackTypes[num2];
			stackTop = num2 + 1;
			break;
		}
		case 92:
			doDUP_XX(2, 2);
			stackTop += 2;
			break;
		case 93:
		case 94:
		{
			int num = P_2 - 93 + 3;
			doDUP_XX(2, num);
			int num2 = stackTop;
			stackTypes[num2 - num] = stackTypes[num2];
			stackTypes[num2 - num + 1] = stackTypes[num2 + 1];
			stackTop = num2 + 2;
			break;
		}
		case 95:
		{
			int num = stackTop - 1;
			TypeData typeData = stackTypes[num];
			stackTypes[num] = stackTypes[num - 1];
			stackTypes[num - 1] = typeData;
			break;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("fatal");
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 71, 104, 116, 162, 191, 50, 130, 116, 114,
		110, 133, 116, 133, 116, 114, 110, 133, 127, 2,
		133, 127, 2, 133, 116, 133, 116, 133, 116, 114,
		110, 133, 116, 114, 110, 133, 127, 2, 130, 116,
		130, 127, 2, 194, 130, 176
	})]
	private int doOpcode96_147(int P_0, byte[] P_1, int P_2)
	{
		if (P_2 <= 131)
		{
			stackTop += Opcode.STACK_GROW[P_2];
			return 1;
		}
		switch (P_2)
		{
		case 132:
			return 3;
		case 133:
			stackTypes[stackTop - 1] = TypeTag.LONG;
			stackTypes[stackTop] = TypeTag.TOP;
			stackTop++;
			break;
		case 134:
			stackTypes[stackTop - 1] = TypeTag.FLOAT;
			break;
		case 135:
			stackTypes[stackTop - 1] = TypeTag.DOUBLE;
			stackTypes[stackTop] = TypeTag.TOP;
			stackTop++;
			break;
		case 136:
		{
			TypeData[] array4 = stackTypes;
			int num = stackTop - 1;
			Tracer tracer = this;
			int num5 = num;
			tracer.stackTop = num;
			array4[num5 - 1] = TypeTag.INTEGER;
			break;
		}
		case 137:
		{
			TypeData[] array3 = stackTypes;
			int num = stackTop - 1;
			Tracer tracer = this;
			int num4 = num;
			tracer.stackTop = num;
			array3[num4 - 1] = TypeTag.FLOAT;
			break;
		}
		case 138:
			stackTypes[stackTop - 2] = TypeTag.DOUBLE;
			break;
		case 139:
			stackTypes[stackTop - 1] = TypeTag.INTEGER;
			break;
		case 140:
			stackTypes[stackTop - 1] = TypeTag.LONG;
			stackTypes[stackTop] = TypeTag.TOP;
			stackTop++;
			break;
		case 141:
			stackTypes[stackTop - 1] = TypeTag.DOUBLE;
			stackTypes[stackTop] = TypeTag.TOP;
			stackTop++;
			break;
		case 142:
		{
			TypeData[] array2 = stackTypes;
			int num = stackTop - 1;
			Tracer tracer = this;
			int num3 = num;
			tracer.stackTop = num;
			array2[num3 - 1] = TypeTag.INTEGER;
			break;
		}
		case 143:
			stackTypes[stackTop - 2] = TypeTag.LONG;
			break;
		case 144:
		{
			TypeData[] array = stackTypes;
			int num = stackTop - 1;
			Tracer tracer = this;
			int num2 = num;
			tracer.stackTop = num;
			array[num2 - 1] = TypeTag.FLOAT;
			break;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("fatal");
		case 145:
		case 146:
		case 147:
			break;
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		161, 136, 159, 160, 138, 116, 110, 165, 127, 2,
		165, 116, 110, 229, 71, 110, 113, 226, 73, 110,
		113, 130, 113, 130, 104, 130, 104, 130, 110, 103,
		104, 107, 104, 118, 140, 110, 103, 104, 117, 139,
		110, 104, 133, 110, 104, 133, 110, 104, 133, 110,
		104, 133, 127, 12, 104, 133, 104, 133, 140, 140,
		140, 172, 140, 140, 139, 139, 106, 127, 2, 107,
		130, 139, 106, 119, 108, 159, 0, 159, 8, 150,
		130, 127, 0, 116, 133, 127, 11, 104, 165, 106,
		110, 108, 141, 118, 162, 116, 162, 142, 130, 139,
		171, 110, 113, 130, 113, 130, 104, 130
	})]
	private int doOpcode148_201(int P_0, byte[] P_1, int P_2)
	{
		switch (P_2)
		{
		case 148:
			stackTypes[stackTop - 4] = TypeTag.INTEGER;
			stackTop -= 3;
			break;
		case 149:
		case 150:
		{
			TypeData[] array2 = stackTypes;
			int num = stackTop - 1;
			Tracer tracer = this;
			int num3 = num;
			tracer.stackTop = num;
			array2[num3 - 1] = TypeTag.INTEGER;
			break;
		}
		case 151:
		case 152:
			stackTypes[stackTop - 4] = TypeTag.INTEGER;
			stackTop -= 3;
			break;
		case 153:
		case 154:
		case 155:
		case 156:
		case 157:
		case 158:
			stackTop--;
			visitBranch(P_0, P_1, ByteArray.readS16bit(P_1, P_0 + 1));
			return 3;
		case 159:
		case 160:
		case 161:
		case 162:
		case 163:
		case 164:
		case 165:
		case 166:
			stackTop -= 2;
			visitBranch(P_0, P_1, ByteArray.readS16bit(P_1, P_0 + 1));
			return 3;
		case 167:
			visitGoto(P_0, P_1, ByteArray.readS16bit(P_1, P_0 + 1));
			return 3;
		case 168:
			visitJSR(P_0, P_1);
			return 3;
		case 169:
			visitRET(P_0, P_1);
			return 2;
		case 170:
		{
			stackTop--;
			int index = (P_0 & -4) + 8;
			int num6 = ByteArray.read32bit(P_1, index);
			int num7 = ByteArray.read32bit(P_1, index + 4);
			int num8 = num7 - num6 + 1;
			visitTableSwitch(P_0, P_1, num8, index + 8, ByteArray.read32bit(P_1, index - 4));
			return num8 * 4 + 16 - (P_0 & 3);
		}
		case 171:
		{
			stackTop--;
			int index = (P_0 & -4) + 8;
			int num6 = ByteArray.read32bit(P_1, index);
			visitLookupSwitch(P_0, P_1, num6, index + 4, ByteArray.read32bit(P_1, index - 4));
			return num6 * 8 + 12 - (P_0 & 3);
		}
		case 172:
			stackTop--;
			visitReturn(P_0, P_1);
			break;
		case 173:
			stackTop -= 2;
			visitReturn(P_0, P_1);
			break;
		case 174:
			stackTop--;
			visitReturn(P_0, P_1);
			break;
		case 175:
			stackTop -= 2;
			visitReturn(P_0, P_1);
			break;
		case 176:
		{
			TypeData[] array4 = stackTypes;
			int num = stackTop - 1;
			Tracer tracer = this;
			int num5 = num;
			tracer.stackTop = num;
			array4[num5].setType(returnType, classPool);
			visitReturn(P_0, P_1);
			break;
		}
		case 177:
			visitReturn(P_0, P_1);
			break;
		case 178:
		{
			int result11 = doGetField(P_0, P_1, false);
			_ = null;
			return result11;
		}
		case 179:
		{
			int result10 = doPutField(P_0, P_1, false);
			_ = null;
			return result10;
		}
		case 180:
		{
			int result9 = doGetField(P_0, P_1, true);
			_ = null;
			return result9;
		}
		case 181:
		{
			int result8 = doPutField(P_0, P_1, true);
			_ = null;
			return result8;
		}
		case 182:
		case 183:
		{
			int result7 = doInvokeMethod(P_0, P_1, true);
			_ = null;
			return result7;
		}
		case 184:
		{
			int result6 = doInvokeMethod(P_0, P_1, false);
			_ = null;
			return result6;
		}
		case 185:
		{
			int result5 = doInvokeIntfMethod(P_0, P_1);
			_ = null;
			return result5;
		}
		case 186:
		{
			int result4 = doInvokeDynamic(P_0, P_1);
			_ = null;
			return result4;
		}
		case 187:
		{
			int index = ByteArray.readU16bit(P_1, P_0 + 1);
			TypeData[] array3 = stackTypes;
			int num = stackTop;
			Tracer tracer = this;
			int num4 = num;
			tracer.stackTop = num + 1;
			array3[num4] = new TypeData.UninitData(P_0, cpool.getClassInfo(index));
			return 3;
		}
		case 188:
		{
			int result3 = doNEWARRAY(P_0, P_1);
			_ = null;
			return result3;
		}
		case 189:
		{
			int index = ByteArray.readU16bit(P_1, P_0 + 1);
			string text = java.lang.String.instancehelper_replace(cpool.getClassInfo(index), '.', '/');
			text = ((java.lang.String.instancehelper_charAt(text, 0) != '[') ? new StringBuilder().append("[L").append(text).append(";")
				.toString() : new StringBuilder().append("[").append(text).toString());
			stackTypes[stackTop - 1] = new TypeData.ClassName(text);
			return 3;
		}
		case 190:
			stackTypes[stackTop - 1].setType("[Ljava.lang.Object;", classPool);
			stackTypes[stackTop - 1] = TypeTag.INTEGER;
			break;
		case 191:
		{
			TypeData[] array = stackTypes;
			int num = stackTop - 1;
			Tracer tracer = this;
			int num2 = num;
			tracer.stackTop = num;
			array[num2].setType("java.lang.Throwable", classPool);
			visitThrow(P_0, P_1);
			break;
		}
		case 192:
		{
			int index = ByteArray.readU16bit(P_1, P_0 + 1);
			string text = cpool.getClassInfo(index);
			if (java.lang.String.instancehelper_charAt(text, 0) == '[')
			{
				text = java.lang.String.instancehelper_replace(text, '.', '/');
			}
			stackTypes[stackTop - 1] = new TypeData.ClassName(text);
			return 3;
		}
		case 193:
			stackTypes[stackTop - 1] = TypeTag.INTEGER;
			return 3;
		case 194:
		case 195:
			stackTop--;
			break;
		case 196:
		{
			int result2 = doWIDE(P_0, P_1);
			_ = null;
			return result2;
		}
		case 197:
		{
			int result = doMultiANewArray(P_0, P_1);
			_ = null;
			return result;
		}
		case 198:
		case 199:
			stackTop--;
			visitBranch(P_0, P_1, ByteArray.readS16bit(P_1, P_0 + 1));
			return 3;
		case 200:
			visitGoto(P_0, P_1, ByteArray.read32bit(P_1, P_0 + 1));
			return 5;
		case 201:
			visitJSR(P_0, P_1);
			return 5;
		}
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 134, 103, 109, 100, 127, 5, 100, 127, 0,
		100, 127, 0, 100, 122, 159, 0, 100, 122, 159,
		0, 100, 127, 2, 101, 110, 104, 130, 127, 6
	})]
	private void doLDC(int P_0)
	{
		TypeData[] array = stackTypes;
		int tag = cpool.getTag(P_0);
		switch (tag)
		{
		case 8:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num9 = num;
			tracer.stackTop = num + 1;
			array[num9] = new TypeData.ClassName("java.lang.String");
			break;
		}
		case 3:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num8 = num;
			tracer.stackTop = num + 1;
			array[num8] = TypeTag.INTEGER;
			break;
		}
		case 4:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num7 = num;
			tracer.stackTop = num + 1;
			array[num7] = TypeTag.FLOAT;
			break;
		}
		case 5:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num5 = num;
			tracer.stackTop = num + 1;
			array[num5] = TypeTag.LONG;
			num = stackTop;
			tracer = this;
			int num6 = num;
			tracer.stackTop = num + 1;
			array[num6] = TypeTag.TOP;
			break;
		}
		case 6:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num3 = num;
			tracer.stackTop = num + 1;
			array[num3] = TypeTag.DOUBLE;
			num = stackTop;
			tracer = this;
			int num4 = num;
			tracer.stackTop = num + 1;
			array[num4] = TypeTag.TOP;
			break;
		}
		case 7:
		{
			int num = stackTop;
			Tracer tracer = this;
			int num2 = num;
			tracer.stackTop = num + 1;
			array[num2] = new TypeData.ClassName("java.lang.Class");
			break;
		}
		case 17:
		{
			string dynamicType = cpool.getDynamicType(P_0);
			pushMemberType(dynamicType);
			break;
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
	[LineNumberTable(new byte[] { 160, 161, 102 })]
	private int doXLOAD(TypeData P_0, byte[] P_1, int P_2)
	{
		int num = P_1[P_2 + 1];
		int result = doXLOAD(num, P_0);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 174, 127, 3 })]
	private int doALOAD(int P_0)
	{
		TypeData[] array = stackTypes;
		int num = stackTop;
		stackTop = num + 1;
		array[num] = localsTypes[P_0];
		return 2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 232, 98, 107, 107, 100, 223, 6, 103, 103,
		159, 39, 111, 133, 111, 130, 104, 106, 110, 129,
		104, 130, 104, 106, 110, 129, 129, 200, 110
	})]
	private void pushMemberType(string P_0)
	{
		int num = 0;
		if (java.lang.String.instancehelper_charAt(P_0, 0) == '(')
		{
			num = java.lang.String.instancehelper_indexOf(P_0, 41) + 1;
			if (num < 1)
			{
				string s = new StringBuilder().append("bad descriptor: ").append(P_0).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IndexOutOfBoundsException(s);
			}
		}
		TypeData[] array = stackTypes;
		int num2 = stackTop;
		switch (java.lang.String.instancehelper_charAt(P_0, num))
		{
		case 'V':
			return;
		case '[':
			array[num2] = new TypeData.ClassName(java.lang.String.instancehelper_substring(P_0, num));
			break;
		case 'L':
			array[num2] = new TypeData.ClassName(getFieldClassName(P_0, num));
			break;
		case 'J':
			array[num2] = TypeTag.LONG;
			array[num2 + 1] = TypeTag.TOP;
			stackTop += 2;
			return;
		case 'F':
			array[num2] = TypeTag.FLOAT;
			break;
		case 'D':
			array[num2] = TypeTag.DOUBLE;
			array[num2 + 1] = TypeTag.TOP;
			stackTop += 2;
			return;
		default:
			array[num2] = TypeTag.INTEGER;
			break;
		}
		stackTop++;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 166, 123, 104, 159, 0 })]
	private int doXLOAD(int P_0, TypeData P_1)
	{
		TypeData[] array = stackTypes;
		int num = stackTop;
		Tracer tracer = this;
		int num2 = num;
		tracer.stackTop = num + 1;
		array[num2] = P_1;
		if (P_1.is2WordType())
		{
			TypeData[] array2 = stackTypes;
			num = stackTop;
			tracer = this;
			int num3 = num;
			tracer.stackTop = num + 1;
			array2[num3] = TypeTag.TOP;
		}
		return 2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 38, 102 })]
	private int doXSTORE(int P_0, byte[] P_1, TypeData P_2)
	{
		int num = P_1[P_0 + 1];
		int result = doXSTORE(num, P_2);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 161, 54, 142, 117 })]
	private int doASTORE(int P_0)
	{
		stackTop--;
		localsTypes[P_0] = stackTypes[stackTop];
		return 2;
	}

	[LineNumberTable(new byte[] { 161, 61, 103, 105, 100, 100, 104, 134 })]
	private void doDUP_XX(int P_0, int P_1)
	{
		TypeData[] array = stackTypes;
		int i = stackTop - 1;
		for (int num = i - P_1; i > num; i += -1)
		{
			array[i + P_0] = array[i];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 43, 110, 105, 104, 110, 175 })]
	private int doXSTORE(int P_0, TypeData P_1)
	{
		stackTop--;
		localsTypes[P_0] = P_1;
		if (P_1.is2WordType())
		{
			stackTop--;
			localsTypes[P_0 + 1] = TypeTag.TOP;
		}
		return 2;
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	protected internal virtual void visitBranch(int pos, byte[] code, int offset)
	{
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	protected internal virtual void visitGoto(int pos, byte[] code, int offset)
	{
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	protected internal virtual void visitJSR(int pos, byte[] code)
	{
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	protected internal virtual void visitRET(int pos, byte[] code)
	{
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	protected internal virtual void visitTableSwitch(int pos, byte[] code, int n, int offsetPos, int defaultOffset)
	{
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	protected internal virtual void visitLookupSwitch(int pos, byte[] code, int n, int pairsPos, int defaultOffset)
	{
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	protected internal virtual void visitReturn(int pos, byte[] code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 158, 214, 162, 106, 104, 109, 103 })]
	private int doGetField(int P_0, byte[] P_1, bool P_2)
	{
		int num = ByteArray.readU16bit(P_1, P_0 + 1);
		setFieldTarget(P_2, num);
		string fieldrefType = cpool.getFieldrefType(num);
		pushMemberType(fieldrefType);
		return 3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		158, 217, 98, 106, 109, 115, 104, 101, 127, 2,
		101, 153, 104
	})]
	private int doPutField(int P_0, byte[] P_1, bool P_2)
	{
		int num = ByteArray.readU16bit(P_1, P_0 + 1);
		string fieldrefType = cpool.getFieldrefType(num);
		stackTop -= Descriptor.dataSize(fieldrefType);
		switch (java.lang.String.instancehelper_charAt(fieldrefType, 0))
		{
		case 'L':
			stackTypes[stackTop].setType(getFieldClassName(fieldrefType, 0), classPool);
			break;
		case '[':
			stackTypes[stackTop].setType(fieldrefType, classPool);
			break;
		}
		setFieldTarget(P_2, num);
		return 3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		158, 198, 66, 106, 109, 104, 102, 109, 127, 2,
		114, 118, 105, 148, 174, 103
	})]
	private int doInvokeMethod(int P_0, byte[] P_1, bool P_2)
	{
		int index = ByteArray.readU16bit(P_1, P_0 + 1);
		string methodrefType = cpool.getMethodrefType(index);
		checkParamTypes(methodrefType, 1);
		if (P_2)
		{
			string methodrefClassName = cpool.getMethodrefClassName(index);
			TypeData[] array = stackTypes;
			int num = stackTop - 1;
			stackTop = num;
			TypeData typeData = array[num];
			if (typeData is TypeData.UninitTypeVar && typeData.isUninit())
			{
				constructorCalled(typeData, ((TypeData.UninitTypeVar)typeData).offset());
			}
			else if (typeData is TypeData.UninitData)
			{
				constructorCalled(typeData, ((TypeData.UninitData)typeData).offset());
			}
			typeData.setType(methodrefClassName, classPool);
		}
		pushMemberType(methodrefType);
		return 3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 162, 207, 106, 109, 104, 109, 127, 9, 103 })]
	private int doInvokeIntfMethod(int P_0, byte[] P_1)
	{
		int index = ByteArray.readU16bit(P_1, P_0 + 1);
		string interfaceMethodrefType = cpool.getInterfaceMethodrefType(index);
		checkParamTypes(interfaceMethodrefType, 1);
		string interfaceMethodrefClassName = cpool.getInterfaceMethodrefClassName(index);
		TypeData[] array = stackTypes;
		int num = stackTop - 1;
		stackTop = num;
		array[num].setType(interfaceMethodrefClassName, classPool);
		pushMemberType(interfaceMethodrefType);
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 162, 217, 106, 109, 232, 72, 103 })]
	private int doInvokeDynamic(int P_0, byte[] P_1)
	{
		int index = ByteArray.readU16bit(P_1, P_0 + 1);
		string invokeDynamicType = cpool.getInvokeDynamicType(index);
		checkParamTypes(invokeDynamicType, 1);
		pushMemberType(invokeDynamicType);
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 128, 137, 159, 15, 102, 130, 102, 130, 102,
		130, 102, 130, 102, 130, 102, 130, 102, 130, 102,
		130, 176, 110
	})]
	private int doNEWARRAY(int P_0, byte[] P_1)
	{
		int num = stackTop - 1;
		string n;
		switch (P_1[P_0 + 1])
		{
		case 4:
			n = "[Z";
			break;
		case 5:
			n = "[C";
			break;
		case 6:
			n = "[F";
			break;
		case 7:
			n = "[D";
			break;
		case 8:
			n = "[B";
			break;
		case 9:
			n = "[S";
			break;
		case 10:
			n = "[I";
			break;
		case 11:
			n = "[J";
			break;
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("bad newarray");
		}
		stackTypes[num] = new TypeData.ClassName(n);
		return 2;
	}

	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	protected internal virtual void visitThrow(int pos, byte[] code)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 41, 102, 159, 114, 109, 133, 109, 133, 109,
		133, 109, 133, 106, 104, 133, 109, 133, 109, 130,
		109, 130, 109, 130, 106, 104, 162, 130, 104, 130,
		191, 6
	})]
	private int doWIDE(int P_0, byte[] P_1)
	{
		int num = P_1[P_0 + 1];
		switch (num)
		{
		case 21:
			doWIDE_XLOAD(P_0, P_1, TypeTag.INTEGER);
			break;
		case 22:
			doWIDE_XLOAD(P_0, P_1, TypeTag.LONG);
			break;
		case 23:
			doWIDE_XLOAD(P_0, P_1, TypeTag.FLOAT);
			break;
		case 24:
			doWIDE_XLOAD(P_0, P_1, TypeTag.DOUBLE);
			break;
		case 25:
		{
			int num2 = ByteArray.readU16bit(P_1, P_0 + 2);
			doALOAD(num2);
			break;
		}
		case 54:
			doWIDE_STORE(P_0, P_1, TypeTag.INTEGER);
			break;
		case 55:
			doWIDE_STORE(P_0, P_1, TypeTag.LONG);
			break;
		case 56:
			doWIDE_STORE(P_0, P_1, TypeTag.FLOAT);
			break;
		case 57:
			doWIDE_STORE(P_0, P_1, TypeTag.DOUBLE);
			break;
		case 58:
		{
			int num2 = ByteArray.readU16bit(P_1, P_0 + 2);
			doASTORE(num2);
			break;
		}
		case 132:
			return 6;
		case 169:
			visitRET(P_0, P_1);
			break;
		default:
		{
			string message = new StringBuilder().append("bad WIDE instruction: ").append(num).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		}
		return 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 164, 106, 102, 144, 118, 117 })]
	private int doMultiANewArray(int P_0, byte[] P_1)
	{
		int index = ByteArray.readU16bit(P_1, P_0 + 1);
		int num = P_1[P_0 + 3];
		stackTop -= num - 1;
		string n = java.lang.String.instancehelper_replace(cpool.getClassInfo(index), '.', '/');
		stackTypes[stackTop - 1] = new TypeData.ClassName(n);
		return 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 89, 106, 105 })]
	private void doWIDE_XLOAD(int P_0, byte[] P_1, TypeData P_2)
	{
		int num = ByteArray.readU16bit(P_1, P_0 + 2);
		doXLOAD(num, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 94, 106, 105 })]
	private void doWIDE_STORE(int P_0, byte[] P_1, TypeData P_2)
	{
		int num = ByteArray.readU16bit(P_1, P_0 + 2);
		doXSTORE(num, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(899)]
	private static string getFieldClassName(string P_0, int P_1)
	{
		string result = java.lang.String.instancehelper_replace(java.lang.String.instancehelper_substring(P_0, P_1 + 1, java.lang.String.instancehelper_length(P_0) - 1), '/', '.');
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 158, 212, 162, 99, 109, 159, 9 })]
	private void setFieldTarget(bool P_0, int P_1)
	{
		if (P_0)
		{
			string fieldrefClassName = cpool.getFieldrefClassName(P_1);
			TypeData[] array = stackTypes;
			int num = stackTop - 1;
			stackTop = num;
			array[num].setType(fieldrefClassName, classPool);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		163, 21, 104, 101, 129, 98, 98, 101, 98, 174,
		101, 108, 100, 176, 132, 104, 109, 144, 142, 99,
		127, 3, 101, 159, 16
	})]
	private void checkParamTypes(string P_0, int P_1)
	{
		int num = java.lang.String.instancehelper_charAt(P_0, P_1);
		if (num == 41)
		{
			return;
		}
		int num2 = P_1;
		int num3 = 0;
		while (true)
		{
			switch (num)
			{
			case 91:
				goto IL_0017;
			case 76:
				num2 = java.lang.String.instancehelper_indexOf(P_0, 59, num2) + 1;
				if (num2 <= 0)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new IndexOutOfBoundsException("bad descriptor");
				}
				break;
			default:
				num2++;
				break;
			}
			break;
			IL_0017:
			num3 = 1;
			num2++;
			num = java.lang.String.instancehelper_charAt(P_0, num2);
		}
		checkParamTypes(P_0, num2);
		if (num3 == 0 && (num == 74 || num == 68))
		{
			stackTop -= 2;
		}
		else
		{
			stackTop--;
		}
		if (num3 != 0)
		{
			stackTypes[stackTop].setType(java.lang.String.instancehelper_substring(P_0, P_1, num2), classPool);
		}
		else if (num == 76)
		{
			stackTypes[stackTop].setType(java.lang.String.instancehelper_replace(java.lang.String.instancehelper_substring(P_0, P_1 + 1, num2 - 1), '/', '.'), classPool);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 198, 103, 107, 46, 166, 108, 46, 134 })]
	private void constructorCalled(TypeData P_0, int P_1)
	{
		P_0.constructorCalled(P_1);
		for (int i = 0; i < stackTop; i++)
		{
			stackTypes[i].constructorCalled(P_1);
		}
		for (int i = 0; i < (nint)localsTypes.LongLength; i++)
		{
			localsTypes[i].constructorCalled(P_1);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 104, 103, 103, 104, 103, 108, 109 })]
	public Tracer(ClassPool classes, ConstPool cp, int maxStack, int maxLocals, string retType)
	{
		classPool = classes;
		cpool = cp;
		returnType = retType;
		stackTop = 0;
		stackTypes = TypeData.make(maxStack);
		localsTypes = TypeData.make(maxLocals);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 0, 104, 108, 108, 108, 108, 114, 114 })]
	public Tracer(Tracer t)
	{
		classPool = t.classPool;
		cpool = t.cpool;
		returnType = t.returnType;
		stackTop = t.stackTop;
		stackTypes = TypeData.make(t.stackTypes.Length);
		localsTypes = TypeData.make(t.localsTypes.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		21, 100, 101, 108, 101, 108, 104, 108, 159, 11,
		97
	})]
	protected internal virtual int doOpcode(int pos, byte[] code)
	{
		//Discarded unreachable code: IL_0045
		ArrayIndexOutOfBoundsException ex2;
		try
		{
			int num = code[pos];
			if (num < 54)
			{
				return doOpcode0_53(pos, code, num);
			}
			if (num < 96)
			{
				return doOpcode54_95(pos, code, num);
			}
			if (num < 148)
			{
				return doOpcode96_147(pos, code, num);
			}
			return doOpcode148_201(pos, code, num);
		}
		catch (System.Exception x)
		{
			ArrayIndexOutOfBoundsException ex = ByteCodeHelper.MapException<ArrayIndexOutOfBoundsException>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		ArrayIndexOutOfBoundsException ex3 = ex2;
		string msg = new StringBuilder().append("inconsistent stack height ").append(Throwable.instancehelper_getMessage(ex3)).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg, ex3);
	}
}
