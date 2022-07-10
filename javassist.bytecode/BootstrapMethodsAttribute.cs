using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class BootstrapMethodsAttribute : AttributeInfo
{
	public class BootstrapMethod : Object
	{
		public int methodRef;

		public int[] arguments;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 165, 104, 103, 103 })]
		public BootstrapMethod(int method, int[] args)
		{
			methodRef = method;
			arguments = args;
		}
	}

	public const string tag = "BootstrapMethods";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 185, 107 })]
	internal BootstrapMethodsAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		33, 103, 104, 103, 98, 107, 105, 107, 105, 100,
		105, 108, 4, 232, 69, 237, 54, 235, 77
	})]
	public virtual BootstrapMethod[] getMethods()
	{
		byte[] code = get();
		int num = ByteArray.readU16bit(code, 0);
		BootstrapMethod[] array = new BootstrapMethod[num];
		int num2 = 2;
		for (int i = 0; i < num; i++)
		{
			int method = ByteArray.readU16bit(code, num2);
			int num3 = ByteArray.readU16bit(code, num2 + 2);
			int[] array2 = new int[num3];
			num2 += 4;
			for (int j = 0; j < num3; j++)
			{
				array2[j] = ByteArray.readU16bit(code, num2);
				num2 += 2;
			}
			array[i] = new BootstrapMethod(method, array2);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		3, 110, 98, 103, 48, 166, 103, 105, 99, 108,
		113, 116, 107, 102, 106, 109, 6, 232, 59, 235,
		75, 105
	})]
	public BootstrapMethodsAttribute(ConstPool cp, BootstrapMethod[] methods)
		: base(cp, "BootstrapMethods")
	{
		int num = 2;
		for (int i = 0; i < (nint)methods.LongLength; i++)
		{
			num = (int)(num + (4 + (nint)methods[i].arguments.LongLength * 2));
		}
		byte[] array = new byte[num];
		ByteArray.write16bit(methods.Length, array, 0);
		int num2 = 2;
		for (int j = 0; j < (nint)methods.LongLength; j++)
		{
			ByteArray.write16bit(methods[j].methodRef, array, num2);
			ByteArray.write16bit(methods[j].arguments.Length, array, num2 + 2);
			int[] arguments = methods[j].arguments;
			num2 += 4;
			for (int k = 0; k < (nint)arguments.LongLength; k++)
			{
				ByteArray.write16bit(arguments[k], array, num2);
				num2 += 2;
			}
		}
		set(array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[]
	{
		63, 103, 103, 106, 100, 116, 110, 58, 232, 61,
		233, 71
	})]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		BootstrapMethod[] methods = getMethods();
		ConstPool constPool = getConstPool();
		for (int i = 0; i < (nint)methods.LongLength; i++)
		{
			BootstrapMethod bootstrapMethod = methods[i];
			bootstrapMethod.methodRef = constPool.copy(bootstrapMethod.methodRef, newCp, classnames);
			for (int j = 0; j < (nint)bootstrapMethod.arguments.LongLength; j++)
			{
				bootstrapMethod.arguments[j] = constPool.copy(bootstrapMethod.arguments[j], newCp, classnames);
			}
		}
		BootstrapMethodsAttribute result = new BootstrapMethodsAttribute(newCp, methods);
		_ = null;
		return result;
	}
}
