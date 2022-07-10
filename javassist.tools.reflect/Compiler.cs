using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace javassist.tools.reflect;

public class Compiler : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 111, 107, 109 })]
	private static void help(PrintStream P_0)
	{
		P_0.println("Usage: java javassist.tools.reflect.Compiler");
		P_0.println("            (<class> [-m <metaobject>] [-c <class metaobject>])+");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		83, 98, 106, 100, 109, 107, 130, 116, 109, 107,
		130, 113, 107, 130, 102, 103, 103, 103, 232, 45,
		233, 87
	})]
	private static int parse(string[] P_0, CompiledClass[] P_1)
	{
		int num = -1;
		for (int i = 0; i < (nint)P_0.LongLength; i++)
		{
			string text = P_0[i];
			if (String.instancehelper_equals(text, "-m"))
			{
				if (num < 0 || i + 1 > (nint)P_0.LongLength)
				{
					return -1;
				}
				CompiledClass obj = P_1[num];
				i++;
				obj.metaobject = P_0[i];
				continue;
			}
			if (String.instancehelper_equals(text, "-c"))
			{
				if (num < 0 || i + 1 > (nint)P_0.LongLength)
				{
					return -1;
				}
				CompiledClass obj2 = P_1[num];
				i++;
				obj2.classobject = P_0[i];
				continue;
			}
			if (String.instancehelper_charAt(text, 0) == '-')
			{
				return -1;
			}
			CompiledClass compiledClass = new CompiledClass();
			compiledClass.classname = text;
			compiledClass.metaobject = null;
			compiledClass.classobject = null;
			num++;
			P_1[num] = compiledClass;
		}
		return num + 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[LineNumberTable(new byte[]
	{
		44,
		102,
		102,
		135,
		105,
		111,
		215,
		106,
		137,
		138,
		106,
		137,
		138,
		109,
		37,
		135,
		191,
		20,
		159,
		34,
		130,
		byte.MaxValue,
		10,
		39,
		233,
		92,
		102,
		111,
		19,
		198
	})]
	private static void processClasses(CompiledClass[] P_0, int P_1)
	{
		Reflection reflection = new Reflection();
		ClassPool @default = ClassPool.getDefault();
		reflection.start(@default);
		for (int i = 0; i < P_1; i++)
		{
			CtClass ctClass = @default.get(P_0[i].classname);
			if (P_0[i].metaobject != null || P_0[i].classobject != null)
			{
				string text = ((P_0[i].metaobject != null) ? P_0[i].metaobject : "javassist.tools.reflect.Metaobject");
				string text2 = ((P_0[i].classobject != null) ? P_0[i].classobject : "javassist.tools.reflect.ClassMetaobject");
				if (!reflection.makeReflective(ctClass, @default.get(text), @default.get(text2)))
				{
					java.lang.System.err.println(new StringBuilder().append("Warning: ").append(ctClass.getName()).append(" is reflective.  It was not changed.")
						.toString());
				}
				java.lang.System.err.println(new StringBuilder().append(ctClass.getName()).append(": ").append(text)
					.append(", ")
					.append(text2)
					.toString());
			}
			else
			{
				java.lang.System.err.println(new StringBuilder().append(ctClass.getName()).append(": not reflective").toString());
			}
		}
		for (int i = 0; i < P_1; i++)
		{
			reflection.onLoad(@default, P_0[i].classname);
			@default.get(P_0[i].classname).writeFile();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(72)]
	public Compiler()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[LineNumberTable(new byte[] { 25, 100, 108, 161, 104, 136, 100, 113, 161, 105 })]
	public static void main(string[] args)
	{
		if (args.Length == 0)
		{
			help(java.lang.System.err);
			return;
		}
		CompiledClass[] array = new CompiledClass[(nint)args.LongLength];
		int num = parse(args, array);
		if (num < 1)
		{
			java.lang.System.err.println("bad parameter.");
		}
		else
		{
			processClasses(array, num);
		}
	}
}
