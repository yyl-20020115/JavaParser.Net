using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class InnerClassesAttribute : AttributeInfo
{
	public const string tag = "InnerClasses";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	public virtual int tableLength()
	{
		int result = ByteArray.readU16bit(get(), 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 23, 104, 99, 98 })]
	public virtual string innerClass(int nth)
	{
		int num = innerClassIndex(nth);
		if (num == 0)
		{
			return null;
		}
		string classInfo = constPool.getClassInfo(num);
		_ = null;
		return classInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 116, 103, 102, 111, 2, 198 })]
	public virtual int find(string name)
	{
		int num = tableLength();
		for (int i = 0; i < num; i++)
		{
			if (String.instancehelper_equals(name, innerClass(i)))
			{
				return i;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(147)]
	public virtual int accessFlags(int nth)
	{
		int result = ByteArray.readU16bit(get(), nth * 8 + 8);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 105, 115 })]
	public virtual void setAccessFlags(int nth, int flags)
	{
		ByteArray.write16bit(flags, get(), nth * 8 + 8);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 51, 104, 99, 98 })]
	public virtual string outerClass(int nth)
	{
		int num = outerClassIndex(nth);
		if (num == 0)
		{
			return null;
		}
		string classInfo = constPool.getClassInfo(num);
		_ = null;
		return classInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 190, 116, 111 })]
	public InnerClassesAttribute(ConstPool cp)
		: base(cp, "InnerClasses", new byte[2])
	{
		ByteArray.write16bit(0, get(), 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 69, 109, 109, 109, 109 })]
	public virtual void append(string inner, string outer, string name, int flags)
	{
		int inner2 = constPool.addClassInfo(inner);
		int outer2 = constPool.addClassInfo(outer);
		int num = constPool.addUtf8Info(name);
		append(inner2, outer2, num, flags);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[]
	{
		160, 145, 103, 104, 103, 104, 105, 105, 99, 108,
		106, 108, 108, 140, 100, 140, 138, 100, 140, 140,
		100, 140, 108, 108, 230, 43, 235, 88
	})]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		byte[] array = get();
		byte[] array2 = new byte[(nint)array.LongLength];
		ConstPool constPool = getConstPool();
		InnerClassesAttribute result = new InnerClassesAttribute(newCp, array2);
		int num = ByteArray.readU16bit(array, 0);
		ByteArray.write16bit(num, array2, 0);
		int num2 = 2;
		for (int i = 0; i < num; i++)
		{
			int num3 = ByteArray.readU16bit(array, num2);
			int num4 = ByteArray.readU16bit(array, num2 + 2);
			int num5 = ByteArray.readU16bit(array, num2 + 4);
			int value = ByteArray.readU16bit(array, num2 + 6);
			if (num3 != 0)
			{
				num3 = constPool.copy(num3, newCp, classnames);
			}
			ByteArray.write16bit(num3, array2, num2);
			if (num4 != 0)
			{
				num4 = constPool.copy(num4, newCp, classnames);
			}
			ByteArray.write16bit(num4, array2, num2 + 2);
			if (num5 != 0)
			{
				num5 = constPool.copy(num5, newCp, classnames);
			}
			ByteArray.write16bit(num5, array2, num2 + 4);
			ByteArray.write16bit(value, array2, num2 + 6);
			num2 += 8;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 177, 107 })]
	internal InnerClassesAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(61)]
	public virtual int innerClassIndex(int nth)
	{
		int result = ByteArray.readU16bit(get(), nth * 8 + 2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(91)]
	public virtual int outerClassIndex(int nth)
	{
		int result = ByteArray.readU16bit(get(), nth * 8 + 4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(119)]
	public virtual int innerNameIndex(int nth)
	{
		int result = ByteArray.readU16bit(get(), nth * 8 + 6);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 84, 103, 99, 105, 102, 38, 166, 104, 138,
		104, 106, 106, 139, 105
	})]
	public virtual void append(int inner, int outer, int name, int flags)
	{
		byte[] array = get();
		int num = array.Length;
		byte[] array2 = new byte[num + 8];
		int i;
		for (i = 2; i < num; i++)
		{
			array2[i] = array[i];
		}
		i = ByteArray.readU16bit(array, 0);
		ByteArray.write16bit(i + 1, array2, 0);
		ByteArray.write16bit(inner, array2, num);
		ByteArray.write16bit(outer, array2, num + 2);
		ByteArray.write16bit(name, array2, num + 4);
		ByteArray.write16bit(flags, array2, num + 6);
		set(array2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 111 })]
	private InnerClassesAttribute(ConstPool P_0, byte[] P_1)
		: base(P_0, "InnerClasses", P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 115 })]
	public virtual void setInnerClassIndex(int nth, int index)
	{
		ByteArray.write16bit(index, get(), nth * 8 + 2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 62, 115 })]
	public virtual void setOuterClassIndex(int nth, int index)
	{
		ByteArray.write16bit(index, get(), nth * 8 + 4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 79, 104, 99, 98 })]
	public virtual string innerName(int nth)
	{
		int num = innerNameIndex(nth);
		if (num == 0)
		{
			return null;
		}
		string utf8Info = constPool.getUtf8Info(num);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 90, 115 })]
	public virtual void setInnerNameIndex(int nth, int index)
	{
		ByteArray.write16bit(index, get(), nth * 8 + 6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 112, 103, 99, 101, 130, 104, 102, 100, 130,
		106, 107, 102, 101, 101, 136, 151, 104
	})]
	public virtual int remove(int nth)
	{
		byte[] array = get();
		int num = array.Length;
		if (num < 10)
		{
			return 0;
		}
		int num2 = ByteArray.readU16bit(array, 0);
		int num3 = 2 + nth * 8;
		if (num2 <= nth)
		{
			return num2;
		}
		byte[] array2 = new byte[num - 8];
		ByteArray.write16bit(num2 - 1, array2, 0);
		int num4 = 2;
		int num5 = 2;
		while (num4 < num)
		{
			if (num4 == num3)
			{
				num4 += 8;
				continue;
			}
			int num6 = num5;
			num5++;
			int num7 = num4;
			num4++;
			array2[num6] = array[num7];
		}
		set(array2);
		return num2 - 1;
	}
}
