using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class ExceptionsAttribute : AttributeInfo
{
	public const string tag = "Exceptions";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		71, 103, 99, 100, 130, 107, 98, 104, 111, 20,
		232, 69
	})]
	public virtual string[] getExceptions()
	{
		byte[] array = info;
		int num = array.Length;
		if (num <= 2)
		{
			return null;
		}
		string[] array2 = new string[num / 2 - 1];
		int num2 = 0;
		for (int i = 2; i < num; i += 2)
		{
			int index = (array[i] << 8) | array[i + 1];
			int num3 = num2;
			num2++;
			array2[num3] = constPool.getClassInfo(index);
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 6, 110, 103, 112, 103 })]
	public ExceptionsAttribute(ConstPool cp)
		: base(cp, "Exceptions")
	{
		byte[] array = new byte[2];
		int num = 0;
		int num2 = 1;
		byte[] array2 = array;
		array2[num2] = (byte)num;
		array[0] = (byte)num;
		info = array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 103, 99, 107, 104, 102, 57, 198, 103 })]
	public virtual void setExceptions(string[] elist)
	{
		int num = elist.Length;
		byte[] code = new byte[num * 2 + 2];
		ByteArray.write16bit(num, code, 0);
		for (int i = 0; i < num; i++)
		{
			ByteArray.write16bit(constPool.addClassInfo(elist[i]), code, i * 2 + 2);
		}
		info = code;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(72)]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		ExceptionsAttribute result = new ExceptionsAttribute(newCp, this, classnames);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 177, 107 })]
	internal ExceptionsAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ExceptionsAttribute;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[]
	{
		34, 103, 103, 103, 99, 104, 103, 103, 104, 106,
		19, 232, 70, 104
	})]
	private void copyFrom(ExceptionsAttribute P_0, Map P_1)
	{
		ConstPool constPool = P_0.constPool;
		ConstPool dest = base.constPool;
		byte[] array = P_0.info;
		int num = array.Length;
		byte[] array2 = new byte[num];
		array2[0] = array[0];
		array2[1] = array[1];
		for (int i = 2; i < num; i += 2)
		{
			int n = ByteArray.readU16bit(array, i);
			ByteArray.write16bit(constPool.copy(n, dest, P_1), array2, i);
		}
		info = array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ExceptionsAttribute;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 159, 188, 110, 106 })]
	private ExceptionsAttribute(ConstPool P_0, ExceptionsAttribute P_1, Map P_2)
		: base(P_0, "Exceptions")
	{
		copyFrom(P_1, P_2);
	}

	[LineNumberTable(new byte[] { 54, 103, 99, 100, 130, 107, 98, 104, 52, 168 })]
	public virtual int[] getExceptionIndexes()
	{
		byte[] array = info;
		int num = array.Length;
		if (num <= 2)
		{
			return null;
		}
		int[] array2 = new int[num / 2 - 1];
		int num2 = 0;
		for (int i = 2; i < num; i += 2)
		{
			int num3 = num2;
			num2++;
			array2[num3] = (array[i] << 8) | array[i + 1];
		}
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 90, 99, 107, 104, 102, 46, 166, 103 })]
	public virtual void setExceptionIndexes(int[] elist)
	{
		int num = elist.Length;
		byte[] code = new byte[num * 2 + 2];
		ByteArray.write16bit(num, code, 0);
		for (int i = 0; i < num; i++)
		{
			ByteArray.write16bit(elist[i], code, i * 2 + 2);
		}
		info = code;
	}

	[LineNumberTable(166)]
	public virtual int tableLength()
	{
		return (int)((nint)info.LongLength / 2 - 1);
	}

	[LineNumberTable(new byte[] { 122, 102 })]
	public virtual int getException(int nth)
	{
		int num = nth * 2 + 2;
		return (info[num] << 8) | info[num + 1];
	}
}
