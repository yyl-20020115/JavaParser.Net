using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace javassist.bytecode.analysis;

public class Executor : java.lang.Object, Opcode
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ConstPool constPool;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ClassPool classPool;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Type STRING_TYPE;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Type CLASS_TYPE;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Type THROWABLE_TYPE;

	private int lastPos;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 183, 104, 103, 167, 113, 113, 191, 9, 2,
		97, 140
	})]
	public Executor(ClassPool classPool, ConstPool constPool)
	{
		this.constPool = constPool;
		this.classPool = classPool;
		java.lang.Exception ex2;
		try
		{
			STRING_TYPE = getType("java.lang.String");
			CLASS_TYPE = getType("java.lang.Class");
			THROWABLE_TYPE = getType("java.lang.Throwable");
			return;
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		18, 103, 200, 159, 162, 212, 133, 108, 229, 72,
		108, 165, 108, 108, 197, 108, 165, 108, 108, 165,
		108, 133, 113, 165, 113, 133, 120, 133, 120, 133,
		120, 133, 120, 133, 120, 229, 69, 115, 229, 69,
		115, 229, 69, 115, 229, 69, 115, 229, 69, 115,
		133, 109, 133, 109, 133, 109, 133, 109, 133, 109,
		197, 109, 133, 120, 133, 120, 133, 120, 133, 120,
		133, 120, 229, 69, 115, 229, 69, 115, 229, 69,
		115, 229, 69, 115, 229, 69, 115, 133, 109, 133,
		109, 133, 109, 133, 109, 133, 109, 197, 109, 133,
		113, 191, 6, 104, 104, 133, 104, 104, 159, 6,
		110, 197, 104, 104, 127, 6, 104, 105, 136, 100,
		114, 134, 105, 165, 119, 119, 165, 105, 106, 114,
		105, 105, 105, 101, 116, 136, 106, 108, 165, 104,
		105, 115, 127, 6, 104, 105, 229, 69, 109, 133,
		109, 133, 109, 133, 109, 133, 109, 133, 109, 133,
		109, 133, 109, 133, 109, 133, 109, 133, 109, 133,
		109, 133, 109, 133, 109, 133, 109, 133, 109, 133,
		109, 133, 109, 133, 109, 133, 109, 197, 115, 133,
		115, 133, 115, 133, 115, 197, 109, 133, 109, 133,
		109, 133, 109, 133, 109, 133, 109, 197, 109, 133,
		109, 133, 109, 133, 109, 133, 109, 133, 109, 165,
		107, 116, 111, 229, 69, 115, 109, 133, 115, 109,
		133, 115, 109, 133, 115, 109, 133, 115, 109, 133,
		115, 109, 133, 115, 109, 133, 115, 109, 133, 115,
		109, 133, 115, 109, 133, 115, 109, 133, 115, 109,
		197, 114, 133, 115, 115, 108, 165, 115, 115, 108,
		165, 115, 115, 108, 229, 73, 115, 229, 71, 115,
		115, 165, 115, 115, 133, 133, 108, 133, 123, 197,
		115, 133, 115, 133, 115, 133, 115, 165, 115, 191,
		10, 5, 98, 205, 133, 114, 133, 114, 133, 114,
		133, 114, 197, 114, 133, 114, 133, 114, 133, 127,
		2, 133, 106, 133, 106, 133, 105, 112, 127, 22,
		108, 165, 116, 133, 115, 127, 2, 133, 115, 108,
		162, 115, 130, 108, 130, 106, 162, 115, 130, 130,
		172
	})]
	public virtual void execute(MethodInfo method, int pos, CodeIterator iter, Frame frame, Subroutine subroutine)
	{
		lastPos = pos;
		int num = iter.byteAt(pos);
		switch (num)
		{
		case 0:
			break;
		case 1:
			frame.push(Type.___003C_003EUNINIT);
			break;
		case 2:
		case 3:
		case 4:
		case 5:
		case 6:
		case 7:
		case 8:
			frame.push(Type.___003C_003EINTEGER);
			break;
		case 9:
		case 10:
			frame.push(Type.___003C_003ELONG);
			frame.push(Type.___003C_003ETOP);
			break;
		case 11:
		case 12:
		case 13:
			frame.push(Type.___003C_003EFLOAT);
			break;
		case 14:
		case 15:
			frame.push(Type.___003C_003EDOUBLE);
			frame.push(Type.___003C_003ETOP);
			break;
		case 16:
		case 17:
			frame.push(Type.___003C_003EINTEGER);
			break;
		case 18:
			evalLDC(iter.byteAt(pos + 1), frame);
			break;
		case 19:
		case 20:
			evalLDC(iter.u16bitAt(pos + 1), frame);
			break;
		case 21:
			evalLoad(Type.___003C_003EINTEGER, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 22:
			evalLoad(Type.___003C_003ELONG, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 23:
			evalLoad(Type.___003C_003EFLOAT, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 24:
			evalLoad(Type.___003C_003EDOUBLE, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 25:
			evalLoad(Type.___003C_003EOBJECT, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 26:
		case 27:
		case 28:
		case 29:
			evalLoad(Type.___003C_003EINTEGER, num - 26, frame, subroutine);
			break;
		case 30:
		case 31:
		case 32:
		case 33:
			evalLoad(Type.___003C_003ELONG, num - 30, frame, subroutine);
			break;
		case 34:
		case 35:
		case 36:
		case 37:
			evalLoad(Type.___003C_003EFLOAT, num - 34, frame, subroutine);
			break;
		case 38:
		case 39:
		case 40:
		case 41:
			evalLoad(Type.___003C_003EDOUBLE, num - 38, frame, subroutine);
			break;
		case 42:
		case 43:
		case 44:
		case 45:
			evalLoad(Type.___003C_003EOBJECT, num - 42, frame, subroutine);
			break;
		case 46:
			evalArrayLoad(Type.___003C_003EINTEGER, frame);
			break;
		case 47:
			evalArrayLoad(Type.___003C_003ELONG, frame);
			break;
		case 48:
			evalArrayLoad(Type.___003C_003EFLOAT, frame);
			break;
		case 49:
			evalArrayLoad(Type.___003C_003EDOUBLE, frame);
			break;
		case 50:
			evalArrayLoad(Type.___003C_003EOBJECT, frame);
			break;
		case 51:
		case 52:
		case 53:
			evalArrayLoad(Type.___003C_003EINTEGER, frame);
			break;
		case 54:
			evalStore(Type.___003C_003EINTEGER, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 55:
			evalStore(Type.___003C_003ELONG, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 56:
			evalStore(Type.___003C_003EFLOAT, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 57:
			evalStore(Type.___003C_003EDOUBLE, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 58:
			evalStore(Type.___003C_003EOBJECT, iter.byteAt(pos + 1), frame, subroutine);
			break;
		case 59:
		case 60:
		case 61:
		case 62:
			evalStore(Type.___003C_003EINTEGER, num - 59, frame, subroutine);
			break;
		case 63:
		case 64:
		case 65:
		case 66:
			evalStore(Type.___003C_003ELONG, num - 63, frame, subroutine);
			break;
		case 67:
		case 68:
		case 69:
		case 70:
			evalStore(Type.___003C_003EFLOAT, num - 67, frame, subroutine);
			break;
		case 71:
		case 72:
		case 73:
		case 74:
			evalStore(Type.___003C_003EDOUBLE, num - 71, frame, subroutine);
			break;
		case 75:
		case 76:
		case 77:
		case 78:
			evalStore(Type.___003C_003EOBJECT, num - 75, frame, subroutine);
			break;
		case 79:
			evalArrayStore(Type.___003C_003EINTEGER, frame);
			break;
		case 80:
			evalArrayStore(Type.___003C_003ELONG, frame);
			break;
		case 81:
			evalArrayStore(Type.___003C_003EFLOAT, frame);
			break;
		case 82:
			evalArrayStore(Type.___003C_003EDOUBLE, frame);
			break;
		case 83:
			evalArrayStore(Type.___003C_003EOBJECT, frame);
			break;
		case 84:
		case 85:
		case 86:
			evalArrayStore(Type.___003C_003EINTEGER, frame);
			break;
		case 87:
			if (frame.pop() == Type.___003C_003ETOP)
			{
				string msg5 = new StringBuilder().append("POP can not be used with a category 2 value, pos = ").append(pos).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadBytecode(msg5);
			}
			break;
		case 88:
			frame.pop();
			frame.pop();
			break;
		case 89:
		{
			Type type = frame.peek();
			if (type == Type.___003C_003ETOP)
			{
				string msg4 = new StringBuilder().append("DUP can not be used with a category 2 value, pos = ").append(pos).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadBytecode(msg4);
			}
			frame.push(frame.peek());
			break;
		}
		case 90:
		case 91:
		{
			Type type = frame.peek();
			if (type == Type.___003C_003ETOP)
			{
				string msg3 = new StringBuilder().append("DUP can not be used with a category 2 value, pos = ").append(pos).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadBytecode(msg3);
			}
			int num3 = frame.getTopIndex();
			int num4 = num3 - (num - 90) - 1;
			frame.push(type);
			for (; num3 > num4; num3 += -1)
			{
				frame.setStack(num3, frame.getStack(num3 - 1));
			}
			frame.setStack(num4, type);
			break;
		}
		case 92:
			frame.push(frame.getStack(frame.getTopIndex() - 1));
			frame.push(frame.getStack(frame.getTopIndex() - 1));
			break;
		case 93:
		case 94:
		{
			int num2 = frame.getTopIndex();
			int num3 = num2 - (num - 93) - 1;
			Type stack = frame.getStack(frame.getTopIndex() - 1);
			Type type3 = frame.peek();
			frame.push(stack);
			frame.push(type3);
			for (; num2 > num3; num2 += -1)
			{
				frame.setStack(num2, frame.getStack(num2 - 2));
			}
			frame.setStack(num3, type3);
			frame.setStack(num3 - 1, stack);
			break;
		}
		case 95:
		{
			Type type = frame.pop();
			Type type2 = frame.pop();
			if (type.getSize() == 2 || type2.getSize() == 2)
			{
				string msg2 = new StringBuilder().append("Swap can not be used with category 2 values, pos = ").append(pos).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadBytecode(msg2);
			}
			frame.push(type);
			frame.push(type2);
			break;
		}
		case 96:
			evalBinaryMath(Type.___003C_003EINTEGER, frame);
			break;
		case 97:
			evalBinaryMath(Type.___003C_003ELONG, frame);
			break;
		case 98:
			evalBinaryMath(Type.___003C_003EFLOAT, frame);
			break;
		case 99:
			evalBinaryMath(Type.___003C_003EDOUBLE, frame);
			break;
		case 100:
			evalBinaryMath(Type.___003C_003EINTEGER, frame);
			break;
		case 101:
			evalBinaryMath(Type.___003C_003ELONG, frame);
			break;
		case 102:
			evalBinaryMath(Type.___003C_003EFLOAT, frame);
			break;
		case 103:
			evalBinaryMath(Type.___003C_003EDOUBLE, frame);
			break;
		case 104:
			evalBinaryMath(Type.___003C_003EINTEGER, frame);
			break;
		case 105:
			evalBinaryMath(Type.___003C_003ELONG, frame);
			break;
		case 106:
			evalBinaryMath(Type.___003C_003EFLOAT, frame);
			break;
		case 107:
			evalBinaryMath(Type.___003C_003EDOUBLE, frame);
			break;
		case 108:
			evalBinaryMath(Type.___003C_003EINTEGER, frame);
			break;
		case 109:
			evalBinaryMath(Type.___003C_003ELONG, frame);
			break;
		case 110:
			evalBinaryMath(Type.___003C_003EFLOAT, frame);
			break;
		case 111:
			evalBinaryMath(Type.___003C_003EDOUBLE, frame);
			break;
		case 112:
			evalBinaryMath(Type.___003C_003EINTEGER, frame);
			break;
		case 113:
			evalBinaryMath(Type.___003C_003ELONG, frame);
			break;
		case 114:
			evalBinaryMath(Type.___003C_003EFLOAT, frame);
			break;
		case 115:
			evalBinaryMath(Type.___003C_003EDOUBLE, frame);
			break;
		case 116:
			verifyAssignable(Type.___003C_003EINTEGER, simplePeek(frame));
			break;
		case 117:
			verifyAssignable(Type.___003C_003ELONG, simplePeek(frame));
			break;
		case 118:
			verifyAssignable(Type.___003C_003EFLOAT, simplePeek(frame));
			break;
		case 119:
			verifyAssignable(Type.___003C_003EDOUBLE, simplePeek(frame));
			break;
		case 120:
			evalShift(Type.___003C_003EINTEGER, frame);
			break;
		case 121:
			evalShift(Type.___003C_003ELONG, frame);
			break;
		case 122:
			evalShift(Type.___003C_003EINTEGER, frame);
			break;
		case 123:
			evalShift(Type.___003C_003ELONG, frame);
			break;
		case 124:
			evalShift(Type.___003C_003EINTEGER, frame);
			break;
		case 125:
			evalShift(Type.___003C_003ELONG, frame);
			break;
		case 126:
			evalBinaryMath(Type.___003C_003EINTEGER, frame);
			break;
		case 127:
			evalBinaryMath(Type.___003C_003ELONG, frame);
			break;
		case 128:
			evalBinaryMath(Type.___003C_003EINTEGER, frame);
			break;
		case 129:
			evalBinaryMath(Type.___003C_003ELONG, frame);
			break;
		case 130:
			evalBinaryMath(Type.___003C_003EINTEGER, frame);
			break;
		case 131:
			evalBinaryMath(Type.___003C_003ELONG, frame);
			break;
		case 132:
		{
			int num2 = iter.byteAt(pos + 1);
			verifyAssignable(Type.___003C_003EINTEGER, frame.getLocal(num2));
			access(num2, Type.___003C_003EINTEGER, subroutine);
			break;
		}
		case 133:
			verifyAssignable(Type.___003C_003EINTEGER, simplePop(frame));
			simplePush(Type.___003C_003ELONG, frame);
			break;
		case 134:
			verifyAssignable(Type.___003C_003EINTEGER, simplePop(frame));
			simplePush(Type.___003C_003EFLOAT, frame);
			break;
		case 135:
			verifyAssignable(Type.___003C_003EINTEGER, simplePop(frame));
			simplePush(Type.___003C_003EDOUBLE, frame);
			break;
		case 136:
			verifyAssignable(Type.___003C_003ELONG, simplePop(frame));
			simplePush(Type.___003C_003EINTEGER, frame);
			break;
		case 137:
			verifyAssignable(Type.___003C_003ELONG, simplePop(frame));
			simplePush(Type.___003C_003EFLOAT, frame);
			break;
		case 138:
			verifyAssignable(Type.___003C_003ELONG, simplePop(frame));
			simplePush(Type.___003C_003EDOUBLE, frame);
			break;
		case 139:
			verifyAssignable(Type.___003C_003EFLOAT, simplePop(frame));
			simplePush(Type.___003C_003EINTEGER, frame);
			break;
		case 140:
			verifyAssignable(Type.___003C_003EFLOAT, simplePop(frame));
			simplePush(Type.___003C_003ELONG, frame);
			break;
		case 141:
			verifyAssignable(Type.___003C_003EFLOAT, simplePop(frame));
			simplePush(Type.___003C_003EDOUBLE, frame);
			break;
		case 142:
			verifyAssignable(Type.___003C_003EDOUBLE, simplePop(frame));
			simplePush(Type.___003C_003EINTEGER, frame);
			break;
		case 143:
			verifyAssignable(Type.___003C_003EDOUBLE, simplePop(frame));
			simplePush(Type.___003C_003ELONG, frame);
			break;
		case 144:
			verifyAssignable(Type.___003C_003EDOUBLE, simplePop(frame));
			simplePush(Type.___003C_003EFLOAT, frame);
			break;
		case 145:
		case 146:
		case 147:
			verifyAssignable(Type.___003C_003EINTEGER, frame.peek());
			break;
		case 148:
			verifyAssignable(Type.___003C_003ELONG, simplePop(frame));
			verifyAssignable(Type.___003C_003ELONG, simplePop(frame));
			frame.push(Type.___003C_003EINTEGER);
			break;
		case 149:
		case 150:
			verifyAssignable(Type.___003C_003EFLOAT, simplePop(frame));
			verifyAssignable(Type.___003C_003EFLOAT, simplePop(frame));
			frame.push(Type.___003C_003EINTEGER);
			break;
		case 151:
		case 152:
			verifyAssignable(Type.___003C_003EDOUBLE, simplePop(frame));
			verifyAssignable(Type.___003C_003EDOUBLE, simplePop(frame));
			frame.push(Type.___003C_003EINTEGER);
			break;
		case 153:
		case 154:
		case 155:
		case 156:
		case 157:
		case 158:
			verifyAssignable(Type.___003C_003EINTEGER, simplePop(frame));
			break;
		case 159:
		case 160:
		case 161:
		case 162:
		case 163:
		case 164:
			verifyAssignable(Type.___003C_003EINTEGER, simplePop(frame));
			verifyAssignable(Type.___003C_003EINTEGER, simplePop(frame));
			break;
		case 165:
		case 166:
			verifyAssignable(Type.___003C_003EOBJECT, simplePop(frame));
			verifyAssignable(Type.___003C_003EOBJECT, simplePop(frame));
			break;
		case 167:
			break;
		case 168:
			frame.push(Type.___003C_003ERETURN_ADDRESS);
			break;
		case 169:
			verifyAssignable(Type.___003C_003ERETURN_ADDRESS, frame.getLocal(iter.byteAt(pos + 1)));
			break;
		case 170:
		case 171:
		case 172:
			verifyAssignable(Type.___003C_003EINTEGER, simplePop(frame));
			break;
		case 173:
			verifyAssignable(Type.___003C_003ELONG, simplePop(frame));
			break;
		case 174:
			verifyAssignable(Type.___003C_003EFLOAT, simplePop(frame));
			break;
		case 175:
			verifyAssignable(Type.___003C_003EDOUBLE, simplePop(frame));
			break;
		case 176:
		{
			NotFoundException ex;
			try
			{
				CtClass returnType = Descriptor.getReturnType(method.getDescriptor(), classPool);
				verifyAssignable(Type.get(returnType), simplePop(frame));
				break;
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			NotFoundException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(cause);
		}
		case 177:
			break;
		case 178:
			evalGetField(num, iter.u16bitAt(pos + 1), frame);
			break;
		case 179:
			evalPutField(num, iter.u16bitAt(pos + 1), frame);
			break;
		case 180:
			evalGetField(num, iter.u16bitAt(pos + 1), frame);
			break;
		case 181:
			evalPutField(num, iter.u16bitAt(pos + 1), frame);
			break;
		case 182:
		case 183:
		case 184:
			evalInvokeMethod(num, iter.u16bitAt(pos + 1), frame);
			break;
		case 185:
			evalInvokeIntfMethod(num, iter.u16bitAt(pos + 1), frame);
			break;
		case 186:
			evalInvokeDynamic(num, iter.u16bitAt(pos + 1), frame);
			break;
		case 187:
			frame.push(resolveClassInfo(constPool.getClassInfo(iter.u16bitAt(pos + 1))));
			break;
		case 188:
			evalNewArray(pos, iter, frame);
			break;
		case 189:
			evalNewObjectArray(pos, iter, frame);
			break;
		case 190:
		{
			Type type = simplePop(frame);
			if (!type.isArray() && type != Type.___003C_003EUNINIT)
			{
				string msg = new StringBuilder().append("Array length passed a non-array [pos = ").append(pos).append("]: ")
					.append(type)
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadBytecode(msg);
			}
			frame.push(Type.___003C_003EINTEGER);
			break;
		}
		case 191:
			verifyAssignable(THROWABLE_TYPE, simplePop(frame));
			break;
		case 192:
			verifyAssignable(Type.___003C_003EOBJECT, simplePop(frame));
			frame.push(typeFromDesc(constPool.getClassInfoByDescriptor(iter.u16bitAt(pos + 1))));
			break;
		case 193:
			verifyAssignable(Type.___003C_003EOBJECT, simplePop(frame));
			frame.push(Type.___003C_003EINTEGER);
			break;
		case 194:
		case 195:
			verifyAssignable(Type.___003C_003EOBJECT, simplePop(frame));
			break;
		case 196:
			evalWide(pos, iter, frame, subroutine);
			break;
		case 197:
			evalNewObjectArray(pos, iter, frame);
			break;
		case 198:
		case 199:
			verifyAssignable(Type.___003C_003EOBJECT, simplePop(frame));
			break;
		case 200:
			break;
		case 201:
			frame.push(Type.___003C_003ERETURN_ADDRESS);
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 60, 127, 1, 97 })]
	private Type getType(string P_0)
	{
		//Discarded unreachable code: IL_0013
		try
		{
			return Type.get(classPool.get(P_0));
		}
		catch (NotFoundException)
		{
		}
		_ = null;
		string msg = new StringBuilder().append("Could not find class [pos = ").append(lastPos).append("]: ")
			.append(P_0)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 142, 141, 159, 3, 103, 133, 102, 130, 102,
		130, 102, 130, 102, 130, 103, 130, 191, 27, 106
	})]
	private void evalLDC(int P_0, Frame P_1)
	{
		int tag = constPool.getTag(P_0);
		Type type;
		switch (tag)
		{
		case 8:
			type = STRING_TYPE;
			break;
		case 3:
			type = Type.___003C_003EINTEGER;
			break;
		case 4:
			type = Type.___003C_003EFLOAT;
			break;
		case 5:
			type = Type.___003C_003ELONG;
			break;
		case 6:
			type = Type.___003C_003EDOUBLE;
			break;
		case 7:
			type = CLASS_TYPE;
			break;
		default:
		{
			string msg = new StringBuilder().append("bad LDC [pos = ").append(lastPos).append("]: ")
				.append(tag)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		}
		simplePush(type, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 162, 171, 136, 136, 104, 108 })]
	private void evalLoad(Type P_0, int P_1, Frame P_2, Subroutine P_3)
	{
		Type local = P_2.getLocal(P_1);
		verifyAssignable(P_0, local);
		simplePush(local, P_2);
		access(P_1, local, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 10, 103, 199, 104, 108, 104, 142, 138, 161,
		135, 99, 159, 27, 136, 104, 108, 106
	})]
	private void evalArrayLoad(Type P_0, Frame P_1)
	{
		Type type = P_1.pop();
		Type type2 = P_1.pop();
		if (type2 == Type.___003C_003EUNINIT)
		{
			verifyAssignable(Type.___003C_003EINTEGER, type);
			if (P_0 == Type.___003C_003EOBJECT)
			{
				simplePush(Type.___003C_003EUNINIT, P_1);
			}
			else
			{
				simplePush(P_0, P_1);
			}
			return;
		}
		Type component = type2.getComponent();
		if (component == null)
		{
			string msg = new StringBuilder().append("Not an array! [pos = ").append(lastPos).append("]: ")
				.append(component)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		component = zeroExtend(component);
		verifyAssignable(P_0, component);
		verifyAssignable(Type.___003C_003EINTEGER, type);
		simplePush(component, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 3, 168, 112, 104, 105, 108 })]
	private void evalStore(Type P_0, int P_1, Frame P_2, Subroutine P_3)
	{
		Type type = simplePop(P_2);
		if (P_0 != Type.___003C_003EOBJECT || type != Type.___003C_003ERETURN_ADDRESS)
		{
			verifyAssignable(P_0, type);
		}
		simpleSetLocal(P_1, type, P_2);
		access(P_1, type, P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 38, 104, 103, 135, 104, 110, 161, 135, 99,
		159, 27, 136, 104, 236, 72, 104, 138, 138
	})]
	private void evalArrayStore(Type P_0, Frame P_1)
	{
		Type type = simplePop(P_1);
		Type type2 = P_1.pop();
		Type type3 = P_1.pop();
		if (type3 == Type.___003C_003EUNINIT)
		{
			verifyAssignable(Type.___003C_003EINTEGER, type2);
			return;
		}
		Type component = type3.getComponent();
		if (component == null)
		{
			string msg = new StringBuilder().append("Not an array! [pos = ").append(lastPos).append("]: ")
				.append(component)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		component = zeroExtend(component);
		verifyAssignable(P_0, component);
		verifyAssignable(Type.___003C_003EINTEGER, type2);
		if (P_0 == Type.___003C_003EOBJECT)
		{
			verifyAssignable(P_0, type);
		}
		else
		{
			verifyAssignable(component, type);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 162, 71, 104, 136, 104, 104, 106 })]
	private void evalBinaryMath(Type P_0, Frame P_1)
	{
		Type type = simplePop(P_1);
		Type type2 = simplePop(P_1);
		verifyAssignable(P_0, type);
		verifyAssignable(P_0, type2);
		simplePush(type2, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 99, 103 })]
	private Type simplePeek(Frame P_0)
	{
		Type type = P_0.peek();
		return (type != Type.___003C_003ETOP) ? type : P_0.getStack(P_0.getTopIndex() - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 163, 162, 105, 127, 53 })]
	private void verifyAssignable(Type P_0, Type P_1)
	{
		if (!P_0.isAssignableFrom(P_1))
		{
			string msg = new StringBuilder().append("Expected type: ").append(P_0).append(" Got: ")
				.append(P_1)
				.append(" [pos = ")
				.append(lastPos)
				.append("]")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 162, 250, 104, 136, 108, 104, 106 })]
	private void evalShift(Type P_0, Frame P_1)
	{
		Type type = simplePop(P_1);
		Type type2 = simplePop(P_1);
		verifyAssignable(Type.___003C_003EINTEGER, type);
		verifyAssignable(P_0, type2);
		simplePush(type2, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 115, 99, 97, 103, 105, 107 })]
	private void access(int P_0, Type P_1, Subroutine P_2)
	{
		if (P_2 != null)
		{
			P_2.access(P_0);
			if (P_1.getSize() == 2)
			{
				P_2.access(P_0 + 1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 104, 103 })]
	private Type simplePop(Frame P_0)
	{
		Type type = P_0.pop();
		return (type != Type.___003C_003ETOP) ? type : P_0.pop();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 109, 103, 105, 109 })]
	private void simplePush(Type P_0, Frame P_1)
	{
		P_1.push(P_0);
		if (P_0.getSize() == 2)
		{
			P_1.push(Type.___003C_003ETOP);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 162, 80, 109, 142, 104, 115, 174, 106 })]
	private void evalGetField(int P_0, int P_1, Frame P_2)
	{
		string fieldrefType = constPool.getFieldrefType(P_1);
		Type type = zeroExtend(typeFromDesc(fieldrefType));
		if (P_0 == 180)
		{
			Type type2 = resolveClassInfo(constPool.getFieldrefClassName(P_1));
			verifyAssignable(type2, simplePop(P_2));
		}
		simplePush(type, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 162, 238, 109, 142, 142, 104, 115, 144 })]
	private void evalPutField(int P_0, int P_1, Frame P_2)
	{
		string fieldrefType = constPool.getFieldrefType(P_1);
		Type type = zeroExtend(typeFromDesc(fieldrefType));
		verifyAssignable(type, simplePop(P_2));
		if (P_0 == 181)
		{
			Type type2 = resolveClassInfo(constPool.getFieldrefClassName(P_1));
			verifyAssignable(type2, simplePop(P_2));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 109, 109, 104, 131, 100, 156, 104, 115, 174,
		104, 104, 112
	})]
	private void evalInvokeMethod(int P_0, int P_1, Frame P_2)
	{
		string methodrefType = constPool.getMethodrefType(P_1);
		Type[] array = paramTypesFromDesc(methodrefType);
		int num = array.Length;
		while (num > 0)
		{
			num += -1;
			verifyAssignable(zeroExtend(array[num]), simplePop(P_2));
		}
		Type type;
		if (P_0 != 184)
		{
			type = resolveClassInfo(constPool.getMethodrefClassName(P_1));
			verifyAssignable(type, simplePop(P_2));
		}
		type = returnTypeFromDesc(methodrefType);
		if (type != Type.___003C_003EVOID)
		{
			simplePush(zeroExtend(type), P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 92, 109, 104, 131, 100, 156, 109, 105, 143,
		105, 105, 113
	})]
	private void evalInvokeIntfMethod(int P_0, int P_1, Frame P_2)
	{
		string interfaceMethodrefType = constPool.getInterfaceMethodrefType(P_1);
		Type[] array = paramTypesFromDesc(interfaceMethodrefType);
		int num = array.Length;
		while (num > 0)
		{
			num += -1;
			verifyAssignable(zeroExtend(array[num]), simplePop(P_2));
		}
		string interfaceMethodrefClassName = constPool.getInterfaceMethodrefClassName(P_1);
		Type type = resolveClassInfo(interfaceMethodrefClassName);
		verifyAssignable(type, simplePop(P_2));
		Type type2 = returnTypeFromDesc(interfaceMethodrefType);
		if (type2 != Type.___003C_003EVOID)
		{
			simplePush(zeroExtend(type2), P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 162, 127, 109, 104, 131, 100, 220, 104, 104, 112 })]
	private void evalInvokeDynamic(int P_0, int P_1, Frame P_2)
	{
		string invokeDynamicType = constPool.getInvokeDynamicType(P_1);
		Type[] array = paramTypesFromDesc(invokeDynamicType);
		int num = array.Length;
		while (num > 0)
		{
			num += -1;
			verifyAssignable(zeroExtend(array[num]), simplePop(P_2));
		}
		Type type = returnTypeFromDesc(invokeDynamicType);
		if (type != Type.___003C_003EVOID)
		{
			simplePush(zeroExtend(type), P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		163,
		129,
		130,
		107,
		143,
		byte.MaxValue,
		0,
		69,
		2,
		97,
		191,
		32,
		99,
		159,
		27
	})]
	private Type resolveClassInfo(string P_0)
	{
		_ = null;
		CtClass ctClass;
		NotFoundException ex;
		try
		{
			ctClass = ((java.lang.String.instancehelper_charAt(P_0, 0) != '[') ? classPool.get(P_0) : Descriptor.toCtClass(P_0, classPool));
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0038;
		}
		if (ctClass == null)
		{
			string msg = new StringBuilder().append("Could not obtain type for descriptor [pos = ").append(lastPos).append("]: ")
				.append(P_0)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		return Type.get(ctClass);
		IL_0038:
		NotFoundException @this = ex;
		string msg2 = new StringBuilder().append("Could not find class in descriptor [pos = ").append(lastPos).append("]: ")
			.append(Throwable.instancehelper_getMessage(@this))
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 180, 114, 98, 106, 159, 14, 108, 133, 108,
		133, 108, 133, 108, 133, 108, 130, 108, 130, 108,
		130, 108, 130, 223, 22, 105
	})]
	private void evalNewArray(int P_0, CodeIterator P_1, Frame P_2)
	{
		verifyAssignable(Type.___003C_003EINTEGER, simplePop(P_2));
		_ = null;
		int num = P_1.byteAt(P_0 + 1);
		Type type;
		switch (num)
		{
		case 4:
			type = getType("boolean[]");
			break;
		case 5:
			type = getType("char[]");
			break;
		case 8:
			type = getType("byte[]");
			break;
		case 9:
			type = getType("short[]");
			break;
		case 10:
			type = getType("int[]");
			break;
		case 11:
			type = getType("long[]");
			break;
		case 6:
			type = getType("float[]");
			break;
		case 7:
			type = getType("double[]");
			break;
		default:
		{
			string msg = new StringBuilder().append("Invalid array type [pos = ").append(P_0).append("]: ")
				.append(num)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		}
		P_2.push(type);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		162, 218, 123, 108, 168, 104, 140, 123, 162, 104,
		180, 112
	})]
	private void evalNewObjectArray(int P_0, CodeIterator P_1, Frame P_2)
	{
		Type type = resolveClassInfo(constPool.getClassInfo(P_1.u16bitAt(P_0 + 1)));
		string text = type.getCtClass().getName();
		int num = P_1.byteAt(P_0);
		int num2;
		if (num == 197)
		{
			num2 = P_1.byteAt(P_0 + 3);
		}
		else
		{
			text = new StringBuilder().append(text).append("[]").toString();
			num2 = 1;
		}
		while (true)
		{
			int num3 = num2;
			num2 += -1;
			if (num3 <= 0)
			{
				break;
			}
			verifyAssignable(Type.___003C_003EINTEGER, simplePop(P_2));
		}
		simplePush(getType(text), P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		163, 148, 130, 191, 0, 2, 97, 191, 32, 99,
		159, 27
	})]
	private Type typeFromDesc(string P_0)
	{
		_ = null;
		CtClass ctClass;
		NotFoundException ex;
		try
		{
			ctClass = Descriptor.toCtClass(P_0, classPool);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_001e;
		}
		if (ctClass == null)
		{
			string msg = new StringBuilder().append("Could not obtain type for descriptor [pos = ").append(lastPos).append("]: ")
				.append(P_0)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		return Type.get(ctClass);
		IL_001e:
		NotFoundException @this = ex;
		string msg2 = new StringBuilder().append("Could not find class in descriptor [pos = ").append(lastPos).append("]: ")
			.append(Throwable.instancehelper_getMessage(@this))
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		163, 13, 106, 106, 159, 114, 111, 133, 111, 133,
		111, 133, 111, 133, 111, 133, 111, 133, 111, 133,
		111, 133, 111, 133, 111, 130, 114, 130, 114, 130,
		191, 22
	})]
	private void evalWide(int P_0, CodeIterator P_1, Frame P_2, Subroutine P_3)
	{
		int num = P_1.byteAt(P_0 + 1);
		int num2 = P_1.u16bitAt(P_0 + 2);
		switch (num)
		{
		case 21:
			evalLoad(Type.___003C_003EINTEGER, num2, P_2, P_3);
			break;
		case 22:
			evalLoad(Type.___003C_003ELONG, num2, P_2, P_3);
			break;
		case 23:
			evalLoad(Type.___003C_003EFLOAT, num2, P_2, P_3);
			break;
		case 24:
			evalLoad(Type.___003C_003EDOUBLE, num2, P_2, P_3);
			break;
		case 25:
			evalLoad(Type.___003C_003EOBJECT, num2, P_2, P_3);
			break;
		case 54:
			evalStore(Type.___003C_003EINTEGER, num2, P_2, P_3);
			break;
		case 55:
			evalStore(Type.___003C_003ELONG, num2, P_2, P_3);
			break;
		case 56:
			evalStore(Type.___003C_003EFLOAT, num2, P_2, P_3);
			break;
		case 57:
			evalStore(Type.___003C_003EDOUBLE, num2, P_2, P_3);
			break;
		case 58:
			evalStore(Type.___003C_003EOBJECT, num2, P_2, P_3);
			break;
		case 132:
			verifyAssignable(Type.___003C_003EINTEGER, P_2.getLocal(num2));
			break;
		case 169:
			verifyAssignable(Type.___003C_003ERETURN_ADDRESS, P_2.getLocal(num2));
			break;
		default:
		{
			string msg = new StringBuilder().append("Invalid WIDE operand [pos = ").append(P_0).append("]: ")
				.append(num)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 3, 127, 1, 134 })]
	private Type zeroExtend(Type P_0)
	{
		if (P_0 == Type.___003C_003ESHORT || P_0 == Type.___003C_003EBYTE || P_0 == Type.___003C_003ECHAR || P_0 == Type.___003C_003EBOOLEAN)
		{
			return Type.___003C_003EINTEGER;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		163, 67, 130, 191, 0, 2, 97, 191, 32, 99,
		159, 27, 104, 105, 45, 168
	})]
	private Type[] paramTypesFromDesc(string P_0)
	{
		_ = null;
		CtClass[] parameterTypes;
		NotFoundException ex;
		try
		{
			parameterTypes = Descriptor.getParameterTypes(P_0, classPool);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_001e;
		}
		if (parameterTypes == null)
		{
			string msg = new StringBuilder().append("Could not obtain parameters for descriptor [pos = ").append(lastPos).append("]: ")
				.append(P_0)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		Type[] array = new Type[(nint)parameterTypes.LongLength];
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			array[i] = Type.get(parameterTypes[i]);
		}
		return array;
		IL_001e:
		NotFoundException @this = ex;
		string msg2 = new StringBuilder().append("Could not find class in descriptor [pos = ").append(lastPos).append("]: ")
			.append(Throwable.instancehelper_getMessage(@this))
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		163, 85, 130, 191, 0, 2, 97, 191, 32, 99,
		159, 27
	})]
	private Type returnTypeFromDesc(string P_0)
	{
		_ = null;
		CtClass returnType;
		NotFoundException ex;
		try
		{
			returnType = Descriptor.getReturnType(P_0, classPool);
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_001e;
		}
		if (returnType == null)
		{
			string msg = new StringBuilder().append("Could not obtain return type for descriptor [pos = ").append(lastPos).append("]: ")
				.append(P_0)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		return Type.get(returnType);
		IL_001e:
		NotFoundException @this = ex;
		string msg2 = new StringBuilder().append("Could not find class in descriptor [pos = ").append(lastPos).append("]: ")
			.append(Throwable.instancehelper_getMessage(@this))
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 123, 104, 105, 112 })]
	private void simpleSetLocal(int P_0, Type P_1, Frame P_2)
	{
		P_2.setLocal(P_0, P_1);
		if (P_1.getSize() == 2)
		{
			P_2.setLocal(P_0 + 1, Type.___003C_003ETOP);
		}
	}
}
