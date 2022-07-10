using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using javassist.bytecode;

namespace javassist.tools;

public class Dump : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	private Dump()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[LineNumberTable(new byte[]
	{
		159, 188, 101, 113, 161, 147, 103, 108, 107, 108,
		102, 107, 105
	})]
	public static void main(string[] args)
	{
		if ((nint)args.LongLength != 1)
		{
			java.lang.System.err.println("Usage: java Dump <class file name>");
			return;
		}
		FileInputStream.___003Cclinit_003E();
		DataInputStream @in = new DataInputStream(new FileInputStream(args[0]));
		ClassFile classFile = new ClassFile(@in);
		PrintWriter printWriter = new PrintWriter(java.lang.System.@out, autoFlush: true);
		printWriter.println("*** constant pool ***");
		classFile.getConstPool().print(printWriter);
		printWriter.println();
		printWriter.println("*** members ***");
		ClassFilePrinter.print(classFile, printWriter);
	}
}
