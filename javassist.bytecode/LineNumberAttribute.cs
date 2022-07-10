using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class LineNumberAttribute : AttributeInfo
{
	public class Pc : Object
	{
		public int index;

		public int line;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(109)]
		public Pc()
		{
		}
	}

	public const string tag = "LineNumberTable";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		80, 103, 98, 98, 100, 106, 168, 102, 107, 152,
		99, 232, 59, 230, 73, 103, 104, 106
	})]
	public virtual Pc toNearPc(int line)
	{
		int num = tableLength();
		int index = 0;
		int num2 = 0;
		if (num > 0)
		{
			num2 = lineNumber(0) - line;
			index = startPc(0);
		}
		for (int i = 1; i < num; i++)
		{
			int num3 = lineNumber(i) - line;
			if ((num3 < 0 && num3 > num2) || (num3 >= 0 && (num3 < num2 || num2 < 0)))
			{
				num2 = num3;
				index = startPc(i);
			}
		}
		Pc pc = new Pc();
		pc.index = index;
		pc.line = line + num2;
		return pc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 177, 107 })]
	internal LineNumberAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 99, 162, 103, 102, 102, 110, 109, 240, 60,
		230, 70
	})]
	internal virtual void shiftPc(int P_0, int P_1, bool P_2)
	{
		int num = tableLength();
		for (int i = 0; i < num; i++)
		{
			int index = i * 4 + 2;
			int num2 = ByteArray.readU16bit(info, index);
			if (num2 > P_0 || (P_2 && num2 == P_0))
			{
				ByteArray.write16bit(num2 + P_1, info, index);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	public virtual int tableLength()
	{
		int result = ByteArray.readU16bit(info, 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	public virtual int startPc(int i)
	{
		int result = ByteArray.readU16bit(info, i * 4 + 2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	public virtual int lineNumber(int i)
	{
		int result = ByteArray.readU16bit(info, i * 4 + 4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 111 })]
	private LineNumberAttribute(ConstPool P_0, byte[] P_1)
		: base(P_0, "LineNumberTable", P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 28, 103, 98, 100, 106, 99, 234, 61, 230, 71 })]
	public virtual int toLineNumber(int pc)
	{
		int num = tableLength();
		int i;
		for (i = 0; i < num; i++)
		{
			if (pc < startPc(i))
			{
				if (i != 0)
				{
					break;
				}
				int result = lineNumber(0);
				_ = null;
				return result;
			}
		}
		int result2 = lineNumber(i - 1);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 48, 103, 102, 106, 10, 198 })]
	public virtual int toStartPc(int line)
	{
		int num = tableLength();
		for (int i = 0; i < num; i++)
		{
			if (line == lineNumber(i))
			{
				int result = startPc(i);
				_ = null;
				return result;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 111, 103, 99, 103, 102, 38, 166, 105 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		byte[] array = info;
		int num = array.Length;
		byte[] array2 = new byte[num];
		for (int i = 0; i < num; i++)
		{
			array2[i] = array[i];
		}
		return new LineNumberAttribute(newCp, array2);
	}
}
