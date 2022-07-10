using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class LocalVariableAttribute : AttributeInfo
{
	public const string tag = "LocalVariableTable";

	public const string typeTag = "LocalVariableTypeTable";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(217)]
	public virtual string variableName(int i)
	{
		string utf8Info = getConstPool().getUtf8Info(nameIndex(i));
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 116, 111 })]
	public LocalVariableAttribute(ConstPool cp)
		: base(cp, "LocalVariableTable", new byte[2])
	{
		ByteArray.write16bit(0, info, 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		33, 104, 106, 111, 102, 43, 166, 104, 106, 106,
		107, 107, 103
	})]
	public virtual void addEntry(int startPc, int length, int nameIndex, int descriptorIndex, int index)
	{
		int num = info.Length;
		byte[] array = new byte[num + 10];
		ByteArray.write16bit(tableLength() + 1, array, 0);
		for (int i = 2; i < num; i++)
		{
			array[i] = info[i];
		}
		ByteArray.write16bit(startPc, array, num);
		ByteArray.write16bit(length, array, num + 2);
		ByteArray.write16bit(nameIndex, array, num + 4);
		ByteArray.write16bit(descriptorIndex, array, num + 6);
		ByteArray.write16bit(index, array, num + 8);
		info = array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 93, 104, 102, 111, 100, 241, 61, 231, 69 })]
	public virtual void shiftIndex(int lessThan, int delta)
	{
		int num = info.Length;
		for (int i = 2; i < num; i += 10)
		{
			int num2 = ByteArray.readU16bit(info, i + 8);
			if (num2 >= lessThan)
			{
				ByteArray.write16bit(num2 + delta, info, i + 8);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 15, 107 })]
	internal LocalVariableAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 96, 98, 103, 105, 103, 110, 208, 113, 114,
		115, 242, 54, 233, 76
	})]
	internal virtual void shiftPc(int P_0, int P_1, bool P_2)
	{
		int num = tableLength();
		for (int i = 0; i < num; i++)
		{
			int num2 = i * 10 + 2;
			int num3 = ByteArray.readU16bit(info, num2);
			int num4 = ByteArray.readU16bit(info, num2 + 2);
			if (num3 > P_0 || (P_2 && num3 == P_0 && num3 != 0))
			{
				ByteArray.write16bit(num3 + P_1, info, num2);
			}
			else if (num3 + num4 > P_0 || (P_2 && num3 + num4 == P_0))
			{
				ByteArray.write16bit(num4 + P_1, info, num2 + 2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(156)]
	public virtual int tableLength()
	{
		int result = ByteArray.readU16bit(info, 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(113)]
	internal virtual string renameEntry(string P_0, string P_1, string P_2)
	{
		string result = Descriptor.rename(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljava/lang/String;")]
	[LineNumberTable(132)]
	internal virtual string renameEntry(string P_0, Map P_1)
	{
		string result = Descriptor.rename(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(207)]
	public virtual int nameIndex(int i)
	{
		int result = ByteArray.readU16bit(info, i * 10 + 6);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(304)]
	public virtual int index(int i)
	{
		int result = ByteArray.readU16bit(info, i * 10 + 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(249)]
	public virtual int descriptorIndex(int i)
	{
		int result = ByteArray.readU16bit(info, i * 10 + 8);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(277)]
	public virtual string descriptor(int i)
	{
		string utf8Info = getConstPool().getUtf8Info(descriptorIndex(i));
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(352)]
	internal virtual LocalVariableAttribute makeThisAttr(ConstPool P_0, byte[] P_1)
	{
		LocalVariableAttribute result = new LocalVariableAttribute(P_0, "LocalVariableTable", P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 19, 107 })]
	internal LocalVariableAttribute(ConstPool P_0, string P_1, byte[] P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[] { 8, 112, 111 })]
	[java.lang.Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public LocalVariableAttribute(ConstPool cp, string name)
		: base(cp, name, new byte[2])
	{
		ByteArray.write16bit(0, info, 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		49, 103, 103, 102, 103, 112, 100, 106, 108, 246,
		58, 233, 73
	})]
	internal override void renameClass(string P_0, string P_1)
	{
		ConstPool constPool = getConstPool();
		int num = tableLength();
		for (int i = 0; i < num; i++)
		{
			int num2 = i * 10 + 2;
			int num3 = ByteArray.readU16bit(info, num2 + 6);
			if (num3 != 0)
			{
				string utf8Info = constPool.getUtf8Info(num3);
				utf8Info = renameEntry(utf8Info, P_0, P_1);
				ByteArray.write16bit(constPool.addUtf8Info(utf8Info), info, num2 + 6);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[]
	{
		68, 103, 103, 102, 103, 112, 100, 106, 107, 246,
		58, 233, 73
	})]
	internal override void renameClass(Map P_0)
	{
		ConstPool constPool = getConstPool();
		int num = tableLength();
		for (int i = 0; i < num; i++)
		{
			int num2 = i * 10 + 2;
			int num3 = ByteArray.readU16bit(info, num2 + 6);
			if (num3 != 0)
			{
				string utf8Info = constPool.getUtf8Info(num3);
				utf8Info = renameEntry(utf8Info, P_0);
				ByteArray.write16bit(constPool.addUtf8Info(utf8Info), info, num2 + 6);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(167)]
	public virtual int startPc(int i)
	{
		int result = ByteArray.readU16bit(info, i * 10 + 2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(178)]
	public virtual int codeLength(int i)
	{
		int result = ByteArray.readU16bit(info, i * 10 + 4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 114, 107, 106, 10, 230, 69 })]
	public virtual string variableNameByIndex(int index)
	{
		for (int i = 0; i < tableLength(); i++)
		{
			if (this.index(i) == index)
			{
				string result = variableName(i);
				_ = null;
				return result;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new ArrayIndexOutOfBoundsException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(263)]
	public virtual int signatureIndex(int i)
	{
		int result = descriptorIndex(i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(294)]
	public virtual string signature(int i)
	{
		string result = descriptor(i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[]
	{
		160, 201, 103, 104, 103, 105, 105, 105, 99, 108,
		106, 108, 108, 108, 140, 106, 108, 100, 140, 140,
		100, 106, 106, 170, 108, 108, 231, 42, 235, 89
	})]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		byte[] array = get();
		byte[] array2 = new byte[(nint)array.LongLength];
		ConstPool constPool = getConstPool();
		LocalVariableAttribute result = makeThisAttr(newCp, array2);
		int num = ByteArray.readU16bit(array, 0);
		ByteArray.write16bit(num, array2, 0);
		int num2 = 2;
		for (int i = 0; i < num; i++)
		{
			int value = ByteArray.readU16bit(array, num2);
			int value2 = ByteArray.readU16bit(array, num2 + 2);
			int num3 = ByteArray.readU16bit(array, num2 + 4);
			int num4 = ByteArray.readU16bit(array, num2 + 6);
			int value3 = ByteArray.readU16bit(array, num2 + 8);
			ByteArray.write16bit(value, array2, num2);
			ByteArray.write16bit(value2, array2, num2 + 2);
			if (num3 != 0)
			{
				num3 = constPool.copy(num3, newCp, null);
			}
			ByteArray.write16bit(num3, array2, num2 + 4);
			if (num4 != 0)
			{
				string utf8Info = constPool.getUtf8Info(num4);
				utf8Info = Descriptor.rename(utf8Info, classnames);
				num4 = newCp.addUtf8Info(utf8Info);
			}
			ByteArray.write16bit(num4, array2, num2 + 6);
			ByteArray.write16bit(value3, array2, num2 + 8);
			num2 += 10;
		}
		return result;
	}
}
