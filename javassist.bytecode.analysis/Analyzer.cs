using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace javassist.bytecode.analysis;

public class Analyzer : java.lang.Object, Opcode
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[IKVM.Attributes.EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class ExceptionInfo : java.lang.Object
	{
		private int end;

		private int handler;

		private int start;

		private Type type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(91)]
		internal ExceptionInfo(int P_0, int P_1, int P_2, Type P_3, _1 P_4)
			: this(P_0, P_1, P_2, P_3)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(91)]
		internal static int access_0024100(ExceptionInfo P_0)
		{
			return P_0.start;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(91)]
		internal static int access_0024200(ExceptionInfo P_0)
		{
			return P_0.end;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(91)]
		internal static Type access_0024300(ExceptionInfo P_0)
		{
			return P_0.type;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(91)]
		internal static int access_0024400(ExceptionInfo P_0)
		{
			return P_0.handler;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 47, 104, 103, 103, 103, 104 })]
		private ExceptionInfo(int P_0, int P_1, int P_2, Type P_3)
		{
			start = P_0;
			end = P_1;
			handler = P_2;
			type = P_3;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private SubroutineScanner scanner;

	private CtClass clazz;

	private ExceptionInfo[] exceptions;

	private Frame[] frames;

	private Subroutine[] subroutines;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		98,
		103,
		140,
		108,
		108,
		112,
		170,
		191,
		21,
		2,
		98,
		178,
		byte.MaxValue,
		5,
		55,
		235,
		76
	})]
	private ExceptionInfo[] buildExceptionInfo(MethodInfo P_0)
	{
		ConstPool constPool = P_0.getConstPool();
		ClassPool classPool = clazz.getClassPool();
		ExceptionTable exceptionTable = P_0.getCodeAttribute().getExceptionTable();
		ExceptionInfo[] array = new ExceptionInfo[exceptionTable.size()];
		for (int i = 0; i < exceptionTable.size(); i++)
		{
			int num = exceptionTable.catchType(i);
			Type type;
			NotFoundException ex;
			try
			{
				type = ((num != 0) ? Type.get(classPool.get(constPool.getClassInfo(num))) : Type.___003C_003ETHROWABLE);
			}
			catch (NotFoundException x)
			{
				ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0075;
			}
			array[i] = new ExceptionInfo(exceptionTable.startPc(i), exceptionTable.endPc(i), exceptionTable.handlerPc(i), type, null);
			continue;
			IL_0075:
			NotFoundException @this = ex;
			string s = Throwable.instancehelper_getMessage(@this);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(s);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 119, 130, 104, 106, 246, 69, 191, 10, 2,
		98, 173, 105, 113, 109, 106, 240, 60, 232, 71
	})]
	private Frame firstFrame(MethodInfo P_0, int P_1, int P_2)
	{
		int num = 0;
		Frame frame = new Frame(P_1, P_2);
		if ((P_0.getAccessFlags() & 8) == 0)
		{
			int index = num;
			num++;
			frame.setLocal(index, Type.get(clazz));
		}
		CtClass[] parameterTypes;
		NotFoundException ex;
		try
		{
			parameterTypes = Descriptor.getParameterTypes(P_0.getDescriptor(), clazz.getClassPool());
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0050;
		}
		for (int i = 0; i < (nint)parameterTypes.LongLength; i++)
		{
			Type type = zeroExtend(Type.get(parameterTypes[i]));
			int index2 = num;
			num++;
			frame.setLocal(index2, type);
			if (type.getSize() == 2)
			{
				int index3 = num;
				num++;
				frame.setLocal(index3, Type.___003C_003ETOP);
			}
		}
		return frame;
		IL_0050:
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		118, 103, 103, 135, 110, 169, 191, 4, 2, 98,
		191, 30, 137, 105, 111, 105, 111, 105, 112, 108,
		137, 137, 127, 4, 105, 176, 106, 148, 240, 70,
		106
	})]
	private void analyzeNextEntry(MethodInfo P_0, CodeIterator P_1, IntQueue P_2, Executor P_3)
	{
		int num = P_2.take();
		P_1.move(num);
		P_1.next();
		Frame frame = frames[num].copy();
		Subroutine subroutine = subroutines[num];
		RuntimeException ex2;
		try
		{
			P_3.execute(P_0, num, P_1, frame, subroutine);
		}
		catch (System.Exception x)
		{
			RuntimeException ex = ByteCodeHelper.MapException<RuntimeException>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
			goto IL_004c;
		}
		int num2 = P_1.byteAt(num);
		switch (num2)
		{
		case 170:
			mergeTableSwitch(P_2, num, P_1, frame);
			break;
		case 171:
			mergeLookupSwitch(P_2, num, P_1, frame);
			break;
		case 169:
			mergeRet(P_2, P_1, num, frame, subroutine);
			break;
		default:
			if (Util.isJumpInstruction(num2))
			{
				int jumpTarget = Util.getJumpTarget(num, P_1);
				if (Util.isJsr(num2))
				{
					mergeJsr(P_2, frames[num], subroutines[jumpTarget], num, lookAhead(P_1, num));
				}
				else if (!Util.isGoto(num2))
				{
					merge(P_2, frame, lookAhead(P_1, num));
				}
				merge(P_2, frame, jumpTarget);
			}
			else if (num2 != 191 && !Util.isReturn(num2))
			{
				merge(P_2, frame, lookAhead(P_1, num));
			}
			break;
		}
		mergeExceptionHandlers(P_2, P_0, num, frame);
		return;
		IL_004c:
		RuntimeException ex3 = ex2;
		string msg = new StringBuilder().append(Throwable.instancehelper_getMessage(ex3)).append("[pos = ").append(num)
			.append("]")
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadBytecode(msg, ex3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		71, 103, 135, 99, 130, 103, 103, 135, 104, 135,
		109, 146, 115, 108, 119, 110, 105, 175
	})]
	public virtual Frame[] analyze(CtClass clazz, MethodInfo method)
	{
		this.clazz = clazz;
		CodeAttribute codeAttribute = method.getCodeAttribute();
		if (codeAttribute == null)
		{
			return null;
		}
		int maxLocals = codeAttribute.getMaxLocals();
		int maxStack = codeAttribute.getMaxStack();
		int codeLength = codeAttribute.getCodeLength();
		CodeIterator codeIterator = codeAttribute.iterator();
		IntQueue intQueue = new IntQueue();
		exceptions = buildExceptionInfo(method);
		subroutines = scanner.scan(method);
		Executor executor = new Executor(clazz.getClassPool(), method.getConstPool());
		frames = new Frame[codeLength];
		frames[codeIterator.lookAhead()] = firstFrame(method, maxLocals, maxStack);
		intQueue.add(codeIterator.next());
		while (!intQueue.isEmpty())
		{
			analyzeNextEntry(method, codeIterator, intQueue, executor);
		}
		return frames;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		161, 28, 135, 114, 108, 108, 174, 100, 107, 11,
		198
	})]
	private void mergeTableSwitch(IntQueue P_0, int P_1, CodeIterator P_2, Frame P_3)
	{
		int num = (P_1 & -4) + 4;
		merge(P_0, P_3, P_1 + P_2.s32bitAt(num));
		num += 4;
		int num2 = P_2.s32bitAt(num);
		num += 4;
		int num3 = P_2.s32bitAt(num);
		int num4 = (num3 - num2 + 1) * 4;
		num += 4;
		for (int num5 = num4 + num; num < num5; num += 4)
		{
			int num6 = P_2.s32bitAt(num) + P_1;
			merge(P_0, P_3, num6);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 233, 135, 114, 108, 170, 104, 106, 10, 198 })]
	private void mergeLookupSwitch(IntQueue P_0, int P_1, CodeIterator P_2, Frame P_3)
	{
		int num = (P_1 & -4) + 4;
		merge(P_0, P_3, P_1 + P_2.s32bitAt(num));
		num += 4;
		int num2 = P_2.s32bitAt(num);
		int num3 = num2 * 8;
		num += 4;
		int num4 = num3 + num;
		for (num += 4; num < num4; num += 8)
		{
			int num5 = P_2.s32bitAt(num) + P_1;
			merge(P_0, P_3, num5);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 247, 100, 159, 16, 127, 10, 106, 130, 105,
		99, 126, 133, 170, 127, 11, 106, 107, 102, 106,
		131, 130, 104, 103, 163, 108, 103, 101
	})]
	private void mergeRet(IntQueue P_0, CodeIterator P_1, int P_2, Frame P_3, Subroutine P_4)
	{
		if (P_4 == null)
		{
			string msg = new StringBuilder().append("Ret on no subroutine! [pos = ").append(P_2).append("]")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		Iterator iterator = P_4.callers().iterator();
		while (iterator.hasNext())
		{
			int num = ((Integer)iterator.next()).intValue();
			int next = getNext(P_1, num, P_2);
			_ = 0;
			Frame frame = frames[next];
			int num3;
			if (frame == null)
			{
				Frame[] array = frames;
				Frame frame2 = P_3.copyStack();
				int num2 = next;
				Frame[] array2 = array;
				array2[num2] = frame2;
				frame = frame2;
				num3 = 1;
			}
			else
			{
				num3 = (frame.mergeStack(P_3) ? 1 : 0);
			}
			Iterator iterator2 = P_4.accessed().iterator();
			while (iterator2.hasNext())
			{
				int index = ((Integer)iterator2.next()).intValue();
				Type local = frame.getLocal(index);
				Type local2 = P_3.getLocal(index);
				if (local != local2)
				{
					frame.setLocal(index, local2);
					num3 = 1;
				}
			}
			if (!frame.isRetMerged())
			{
				frame.setRetMerged(true);
				num3 = 1;
			}
			if (num3 != 0 && frame.isJsrMerged())
			{
				P_0.add(next);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 160, 154, 104, 159, 16 })]
	private int lookAhead(CodeIterator P_0, int P_1)
	{
		if (!P_0.hasNext())
		{
			string msg = new StringBuilder().append("Execution falls off end! [pos = ").append(P_1).append("]")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		int result = P_0.lookAhead();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		160, 192, 99, 159, 17, 106, 130, 99, 121, 135,
		144, 109, 106, 106, 100, 106, 98, 162, 139, 106,
		116, 226, 49, 235, 84, 104, 103, 162, 107, 138
	})]
	private void mergeJsr(IntQueue P_0, Frame P_1, Subroutine P_2, int P_3, int P_4)
	{
		if (P_2 == null)
		{
			string msg = new StringBuilder().append("No subroutine at jsr target! [pos = ").append(P_3).append("]")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadBytecode(msg);
		}
		Frame frame = frames[P_4];
		int num = 0;
		if (frame == null)
		{
			Frame[] array = frames;
			Frame frame2 = P_1.copy();
			Frame[] array2 = array;
			array2[P_4] = frame2;
			frame = frame2;
			num = 1;
		}
		else
		{
			for (int i = 0; i < P_1.localsLength(); i++)
			{
				if (P_2.isAccessed(i))
				{
					continue;
				}
				Type local = frame.getLocal(i);
				Type local2 = P_1.getLocal(i);
				if (local == null)
				{
					frame.setLocal(i, local2);
					num = 1;
					continue;
				}
				local2 = local.merge(local2);
				frame.setLocal(i, local2);
				if (!local2.equals(local) || local2.popChanged())
				{
					num = 1;
				}
			}
		}
		if (!frame.isJsrMerged())
		{
			frame.setJsrMerged(true);
			num = 1;
		}
		if (num != 0 && frame.isRetMerged())
		{
			P_0.add(P_4);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 162, 169, 99, 110, 132, 168, 99, 137 })]
	private void merge(IntQueue P_0, Frame P_1, int P_2)
	{
		Frame frame = frames[P_2];
		int num;
		if (frame == null)
		{
			frames[P_2] = P_1.copy();
			num = 1;
		}
		else
		{
			num = (frame.merge(P_1) ? 1 : 0);
		}
		if (num != 0)
		{
			P_0.add(P_2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 178, 108, 169, 114, 104, 102, 108, 238, 56,
		233, 75
	})]
	private void mergeExceptionHandlers(IntQueue P_0, MethodInfo P_1, int P_2, Frame P_3)
	{
		for (int i = 0; i < (nint)exceptions.LongLength; i++)
		{
			ExceptionInfo exceptionInfo = exceptions[i];
			if (P_2 >= ExceptionInfo.access_0024100(exceptionInfo) && P_2 < ExceptionInfo.access_0024200(exceptionInfo))
			{
				Frame frame = P_3.copy();
				frame.clearStack();
				frame.push(ExceptionInfo.access_0024300(exceptionInfo));
				merge(P_0, frame, ExceptionInfo.access_0024400(exceptionInfo));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 43, 127, 1, 134 })]
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
	[LineNumberTable(new byte[] { 160, 144, 103, 103, 103, 103, 135 })]
	private int getNext(CodeIterator P_0, int P_1, int P_2)
	{
		P_0.move(P_1);
		P_0.next();
		int result = P_0.lookAhead();
		P_0.move(P_2);
		P_0.next();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 104 })]
	public Analyzer()
	{
		scanner = new SubroutineScanner();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(163)]
	public virtual Frame[] analyze(CtMethod method)
	{
		Frame[] result = analyze(method.getDeclaringClass(), method.getMethodInfo2());
		_ = null;
		return result;
	}
}
