using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using javassist.bytecode.analysis;

namespace javassist.tools;

public class framedump : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(30)]
	private framedump()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[LineNumberTable(new byte[] { 159, 180, 101, 113, 161, 102, 106, 127, 20, 109 })]
	public static void main(string[] args)
	{
		if ((nint)args.LongLength != 1)
		{
			java.lang.System.err.println("Usage: java javassist.tools.framedump <fully-qualified class name>");
			return;
		}
		ClassPool @default = ClassPool.getDefault();
		CtClass ctClass = @default.get(args[0]);
		java.lang.System.@out.println(new StringBuilder().append("Frame Dump of ").append(ctClass.getName()).append(":")
			.toString());
		FramePrinter.print(ctClass, java.lang.System.@out);
	}
}
