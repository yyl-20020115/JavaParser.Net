using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.invoke;
using java.security;
using javassist.bytecode;

namespace javassist.util.proxy;

public class FactoryHelper : java.lang.Object
{
	[IKVM.Attributes.Signature("[Ljava/lang/Class<*>;")]
	internal static Class[] ___003C_003EprimitiveTypes;

	internal static string[] ___003C_003EwrapperTypes;

	internal static string[] ___003C_003EwrapperDesc;

	internal static string[] ___003C_003EunwarpMethods;

	internal static string[] ___003C_003EunwrapDesc;

	internal static int[] ___003C_003EdataSize;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static Class[] primitiveTypes
	{
		[HideFromJava]
		get
		{
			return ___003C_003EprimitiveTypes;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static string[] wrapperTypes
	{
		[HideFromJava]
		get
		{
			return ___003C_003EwrapperTypes;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static string[] wrapperDesc
	{
		[HideFromJava]
		get
		{
			return ___003C_003EwrapperDesc;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static string[] unwarpMethods
	{
		[HideFromJava]
		get
		{
			return ___003C_003EunwarpMethods;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static string[] unwrapDesc
	{
		[HideFromJava]
		get
		{
			return ___003C_003EunwrapDesc;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static int[] dataSize
	{
		[HideFromJava]
		get
		{
			return ___003C_003EdataSize;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ClassFile;Ljava/lang/Class<*>;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 100, 103, 103, 143, 191, 8, 97 })]
	public static Class toClass(ClassFile cf, Class neighbor, ClassLoader loader, ProtectionDomain domain)
	{
		//Discarded unreachable code: IL_002e
		IOException ex;
		try
		{
			byte[] array = toBytecode(cf);
			if (ProxyFactory.onlyPublicMethods)
			{
				return DefineClassHelper.toPublicClass(cf.getName(), array);
			}
			return DefineClassHelper.toClass(cf.getName(), neighbor, loader, domain, array);
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 67, 102, 135, 171, 102, 35, 98, 130 })]
	private static byte[] toBytecode(ClassFile P_0)
	{
		ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
		DataOutputStream dataOutputStream = new DataOutputStream(byteArrayOutputStream);
		try
		{
			P_0.write(dataOutputStream);
		}
		finally
		{
			dataOutputStream.close();
		}
		return byteArrayOutputStream.toByteArray();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException", "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 94, 103, 125, 122, 108, 100, 105, 109, 172,
		178, 246, 70, 103, 39, 103, 230, 59, 98, 168,
		103, 97
	})]
	private static void writeFile0(ClassFile P_0, string P_1)
	{
		string name = P_0.getName();
		string text = new StringBuilder().append(P_1).append(File.separatorChar).append(java.lang.String.instancehelper_replace(name, '.', File.separatorChar))
			.append(".class")
			.toString();
		int num = java.lang.String.instancehelper_lastIndexOf(text, File.separatorChar);
		if (num > 0)
		{
			string text2 = java.lang.String.instancehelper_substring(text, 0, num);
			if (!java.lang.String.instancehelper_equals(text2, "."))
			{
				new File(text2).mkdirs();
			}
		}
		DataOutputStream dataOutputStream = new DataOutputStream(new BufferedOutputStream(new FileOutputStream(text)));
		IOException ex;
		try
		{
			try
			{
				P_0.write(dataOutputStream);
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_00a2;
			}
		}
		catch
		{
			//try-fault
			dataOutputStream.close();
			throw;
		}
		dataOutputStream.close();
		return;
		IL_00a2:
		IOException ex2 = ex;
		try
		{
			IOException ex3 = ex2;
			throw Throwable.___003Cunmap_003E(ex3);
		}
		catch
		{
			//try-fault
			dataOutputStream.close();
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	public FactoryHelper()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	[IKVM.Attributes.Signature("(Ljava/lang/Class<*>;)I")]
	[LineNumberTable(new byte[] { 159, 185, 107, 106, 2, 198 })]
	public static int typeIndex(Class type)
	{
		for (int i = 0; i < (nint)___003C_003EprimitiveTypes.LongLength; i++)
		{
			if (___003C_003EprimitiveTypes[i] == type)
			{
				return i;
			}
		}
		string message = new StringBuilder().append("bad type:").append(type.getName()).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[Obsolete]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ClassFile;Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(113)]
	public static Class toClass(ClassFile cf, ClassLoader loader)
	{
		Class result = toClass(cf, null, loader, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[Obsolete]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ClassFile;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
	[LineNumberTable(131)]
	public static Class toClass(ClassFile cf, ClassLoader loader, ProtectionDomain domain)
	{
		Class result = toClass(cf, null, loader, domain);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ClassFile;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 122, 103, 157, 97 })]
	public static Class toClass(ClassFile cf, MethodHandles.Lookup lookup)
	{
		//Discarded unreachable code: IL_0010
		IOException ex;
		try
		{
			byte[] bcode = toBytecode(cf);
			return DefineClassHelper.toClass(lookup, bcode);
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 85, 217, 2, 97, 140 })]
	public static void writeFile(ClassFile cf, string directoryName)
	{
		IOException ex;
		try
		{
			writeFile0(cf, directoryName);
			return;
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[LineNumberTable(new byte[]
	{
		3,
		byte.MaxValue,
		53,
		72,
		byte.MaxValue,
		53,
		73,
		byte.MaxValue,
		44,
		75,
		byte.MaxValue,
		44,
		73,
		byte.MaxValue,
		44,
		72
	})]
	static FactoryHelper()
	{
		___003C_003EprimitiveTypes = new Class[9]
		{
			java.lang.Boolean.TYPE,
			java.lang.Byte.TYPE,
			Character.TYPE,
			Short.TYPE,
			Integer.TYPE,
			Long.TYPE,
			Float.TYPE,
			java.lang.Double.TYPE,
			java.lang.Void.TYPE
		};
		___003C_003EwrapperTypes = new string[9] { "java.lang.Boolean", "java.lang.Byte", "java.lang.Character", "java.lang.Short", "java.lang.Integer", "java.lang.Long", "java.lang.Float", "java.lang.Double", "java.lang.Void" };
		___003C_003EwrapperDesc = new string[8] { "(Z)V", "(B)V", "(C)V", "(S)V", "(I)V", "(J)V", "(F)V", "(D)V" };
		___003C_003EunwarpMethods = new string[8] { "booleanValue", "byteValue", "charValue", "shortValue", "intValue", "longValue", "floatValue", "doubleValue" };
		___003C_003EunwrapDesc = new string[8] { "()Z", "()B", "()C", "()S", "()I", "()J", "()F", "()D" };
		___003C_003EdataSize = new int[8] { 1, 1, 1, 1, 1, 2, 1, 2 };
	}
}
