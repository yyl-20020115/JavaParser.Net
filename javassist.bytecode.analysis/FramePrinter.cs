using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;

namespace javassist.bytecode.analysis;

public sealed class FramePrinter : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private PrintStream stream;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 186, 104, 103 })]
	public FramePrinter(PrintStream stream)
	{
		this.stream = stream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 103, 103, 41, 166 })]
	public virtual void print(CtClass clazz)
	{
		CtMethod[] declaredMethods = clazz.getDeclaredMethods();
		for (int i = 0; i < (nint)declaredMethods.LongLength; i++)
		{
			print(declaredMethods[i]);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		29, 127, 12, 103, 103, 103, 99, 193, 191, 7,
		2, 98, 173, 146, 104, 172, 189, 2, 98, 173,
		159, 22, 106, 102, 100, 112, 133, 136, 106, 104,
		133
	})]
	public virtual void print(CtMethod method)
	{
		stream.println(new StringBuilder().append("\n").append(getMethodString(method)).toString());
		MethodInfo methodInfo = method.getMethodInfo2();
		ConstPool constPool = methodInfo.getConstPool();
		CodeAttribute codeAttribute = methodInfo.getCodeAttribute();
		if (codeAttribute == null)
		{
			return;
		}
		Frame[] array;
		BadBytecode badBytecode;
		try
		{
			array = new Analyzer().analyze(method.getDeclaringClass(), methodInfo);
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0066;
		}
		int num = String.instancehelper_length(String.valueOf(codeAttribute.getCodeLength()));
		CodeIterator codeIterator = codeAttribute.iterator();
		while (codeIterator.hasNext())
		{
			int num2;
			BadBytecode badBytecode2;
			try
			{
				num2 = codeIterator.next();
			}
			catch (BadBytecode x2)
			{
				badBytecode2 = ByteCodeHelper.MapException<BadBytecode>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00ba;
			}
			stream.println(new StringBuilder().append(num2).append(": ").append(InstructionPrinter.instructionString(codeIterator, num2, constPool))
				.toString());
			addSpacing(num + 3);
			Frame frame = array[num2];
			if (frame == null)
			{
				stream.println("--DEAD CODE--");
				continue;
			}
			printStack(frame);
			addSpacing(num + 3);
			printLocals(frame);
			continue;
			IL_00ba:
			BadBytecode cause = badBytecode2;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(cause);
		}
		return;
		IL_0066:
		BadBytecode cause2 = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 17, 127, 1, 127, 6, 31, 20, 161, 97 })]
	private string getMethodString(CtMethod P_0)
	{
		//Discarded unreachable code: IL_0065
		NotFoundException ex;
		try
		{
			return new StringBuilder().append(Modifier.toString(P_0.getModifiers())).append(" ").append(P_0.getReturnType().getName())
				.append(" ")
				.append(P_0.getName())
				.append(Descriptor.toString(P_0.getSignature()))
				.append(";")
				.toString();
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 95, 105, 111 })]
	private void addSpacing(int P_0)
	{
		while (true)
		{
			int num = P_0;
			P_0 += -1;
			if (num > 0)
			{
				stream.print(' ');
				continue;
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		71, 112, 103, 102, 100, 112, 104, 236, 60, 230,
		70, 114
	})]
	private void printStack(Frame P_0)
	{
		stream.print("stack [");
		int topIndex = P_0.getTopIndex();
		for (int i = 0; i <= topIndex; i++)
		{
			if (i > 0)
			{
				stream.print(", ");
			}
			Type stack = P_0.getStack(i);
			stream.print(stack);
		}
		stream.println("]");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		83, 112, 103, 102, 100, 112, 104, 251, 60, 230,
		70, 114
	})]
	private void printLocals(Frame P_0)
	{
		stream.print("locals [");
		int num = P_0.localsLength();
		for (int i = 0; i < num; i++)
		{
			if (i > 0)
			{
				stream.print(", ");
			}
			Type local = P_0.getLocal(i);
			stream.print((local != null) ? local.toString() : "empty");
		}
		stream.println("]");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 110 })]
	public static void print(CtClass clazz, PrintStream stream)
	{
		new FramePrinter(stream).print(clazz);
	}
}
