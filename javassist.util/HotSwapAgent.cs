using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.instrument;
using java.lang.management;
using java.util.jar;

namespace javassist.util;

public class HotSwapAgent : java.lang.Object
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private static Instrumentation m_instrumentation;

	private static MH<string, object> ___003C_003EinvokeCache;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	private static MHV<object, string, string> ___003C_003EinvokeCache;

	private static MHV<object> ___003C_003EinvokeCache;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 51, 104, 144, 102 })]
	public static void agentmain(string agentArgs, Instrumentation inst)
	{
		if (!inst.isRedefineClassesSupported())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException("this JVM does not support redefinition of classes");
		}
		HotSwapAgent.m_instrumentation = inst;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException", "java.io.IOException", "javassist.CannotCompileException" })]
	[Signature("([Ljava/lang/Class<*>;[Ljavassist/CtClass;)V")]
	[LineNumberTable(new byte[]
	{
		74,
		101,
		104,
		103,
		51,
		198,
		byte.MaxValue,
		10,
		71,
		226,
		59,
		98,
		148,
		98,
		148
	})]
	public static void redefine(Class[] oldClasses, CtClass[] newClasses)
	{
		startAgent();
		ClassDefinition[] array = new ClassDefinition[(nint)oldClasses.LongLength];
		for (int i = 0; i < (nint)oldClasses.LongLength; i++)
		{
			array[i] = new ClassDefinition(oldClasses[i], newClasses[i].toBytecode());
		}
		java.lang.ClassNotFoundException ex;
		UnmodifiableClassException ex2;
		try
		{
			try
			{
				HotSwapAgent.m_instrumentation.redefineClasses(array);
				return;
			}
			catch (java.lang.ClassNotFoundException x)
			{
				ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
		}
		catch (UnmodifiableClassException x2)
		{
			ex2 = ByteCodeHelper.MapException<UnmodifiableClassException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0053;
		}
		java.lang.ClassNotFoundException ex3 = ex;
		string msg = Throwable.instancehelper_getMessage(ex3);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(msg, ex3);
		IL_0053:
		UnmodifiableClassException ex4 = ex2;
		string msg2 = Throwable.instancehelper_getMessage(ex4);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(msg2, ex4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		95, 103, 161, 134, 107, 112, 103, 117, 223, 0,
		2, 98, 178, 105, 103, 161, 246, 69, 226, 61,
		97, 106, 226, 55, 232, 77
	})]
	private static void startAgent()
	{
		if (HotSwapAgent.m_instrumentation != null)
		{
			return;
		}
		java.lang.Exception ex2;
		try
		{
			File file = createJarFile();
			string name = ManagementFactory.getRuntimeMXBean().getName();
			string text = java.lang.String.instancehelper_substring(name, 0, java.lang.String.instancehelper_indexOf(name, 64));
			object obj = HotSwapAgent.___003C_003EMHC(text);
			string absolutePath = file.getAbsolutePath();
			string text2 = null;
			string text3 = absolutePath;
			HotSwapAgent.___003C_003EMHC(obj, text3, text2);
			HotSwapAgent.___003C_003EMHC(obj);
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
			goto IL_0060;
		}
		for (int i = 0; i < 10; i++)
		{
			if (HotSwapAgent.m_instrumentation != null)
			{
				return;
			}
			try
			{
				Thread.sleep(1000L);
			}
			catch (InterruptedException)
			{
				goto IL_009e;
			}
			continue;
			IL_009e:
			_ = null;
			Thread.currentThread().interrupt();
			break;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException("hotswap agent (timeout)");
		IL_0060:
		java.lang.Exception e = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException("hotswap agent", e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 160, 75, 112, 102 })]
	private static File createJarFile()
	{
		File file = File.createTempFile("agent", ".jar");
		file.deleteOnExit();
		File result = createJarFile(file);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 83, 102, 103, 113, 123, 123, 118, 150, 130,
		114, 107, 127, 11, 104, 103, 106, 109, 170, 99,
		102, 3, 99, 168
	})]
	private static File createJarFile(File P_0)
	{
		Manifest manifest = new Manifest();
		Attributes mainAttributes = manifest.getMainAttributes();
		mainAttributes.put(Attributes.Name.MANIFEST_VERSION, "1.0");
		mainAttributes.put(new Attributes.Name("Premain-Class"), ClassLiteral<HotSwapAgent>.Value.getName());
		mainAttributes.put(new Attributes.Name("Agent-Class"), ClassLiteral<HotSwapAgent>.Value.getName());
		mainAttributes.put(new Attributes.Name("Can-Retransform-Classes"), "true");
		mainAttributes.put(new Attributes.Name("Can-Redefine-Classes"), "true");
		JarOutputStream jarOutputStream = null;
		try
		{
			JarOutputStream.___003Cclinit_003E();
			jarOutputStream = new JarOutputStream(new FileOutputStream(P_0), manifest);
			string name = ClassLiteral<HotSwapAgent>.Value.getName();
			JarEntry ze = new JarEntry(new StringBuilder().append(java.lang.String.instancehelper_replace(name, '.', '/')).append(".class").toString());
			jarOutputStream.putNextEntry(ze);
			ClassPool @default = ClassPool.getDefault();
			CtClass ctClass = @default.get(name);
			jarOutputStream.write(ctClass.toBytecode());
			jarOutputStream.closeEntry();
		}
		catch
		{
			//try-fault
			jarOutputStream?.close();
			throw;
		}
		jarOutputStream?.close();
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(80)]
	public HotSwapAgent()
	{
	}

	public virtual Instrumentation instrumentation()
	{
		return HotSwapAgent.m_instrumentation;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 44, 105 })]
	public static void premain(string agentArgs, Instrumentation inst)
	{
		agentmain(agentArgs, inst);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException", "java.io.IOException", "javassist.CannotCompileException" })]
	[Signature("(Ljava/lang/Class<*>;Ljavassist/CtClass;)V")]
	[LineNumberTable(new byte[] { 63, 107, 107, 105 })]
	public static void redefine(Class oldClass, CtClass newClass)
	{
		Class[] oldClasses = new Class[1] { oldClass };
		CtClass[] newClasses = new CtClass[1] { newClass };
		redefine(oldClasses, newClasses);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.CannotCompileException", "javassist.NotFoundException" })]
	[LineNumberTable(183)]
	public static File createAgentJarFile(string fileName)
	{
		File result = createJarFile(new File(fileName));
		_ = null;
		return result;
	}

	static object ___003C_003EMHC(string P_0)
	{
		if (HotSwapAgent.___003C_003EinvokeCache == null)
		{
			HotSwapAgent.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MH<string, object>>(6, "com.sun.tools.attach.VirtualMachine", "attach", "(Ljava.lang.String;)Lcom.sun.tools.attach.VirtualMachine;", HotSwapAgent.___003CGetCallerID_003E());
		}
		return HotSwapAgent.___003C_003EinvokeCache(P_0);
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	static void ___003C_003EMHC(object P_0, string P_1, string P_2)
	{
		if (HotSwapAgent.___003C_003EinvokeCache == null)
		{
			HotSwapAgent.___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object, string, string>>(5, "com.sun.tools.attach.VirtualMachine", "loadAgent", "(Ljava.lang.String;Ljava.lang.String;)V", HotSwapAgent.___003CGetCallerID_003E());
		}
		HotSwapAgent.___003C_003EinvokeCache(P_0, P_1, P_2);
	}

	static void ___003C_003EMHC(object P_0)
	{
		if (___003C_003EinvokeCache == null)
		{
			___003C_003EinvokeCache = ByteCodeHelper.DynamicBinderMemberLookup<MHV<object>>(5, "com.sun.tools.attach.VirtualMachine", "detach", "()V", HotSwapAgent.___003CGetCallerID_003E());
		}
		___003C_003EinvokeCache(P_0);
	}
}
