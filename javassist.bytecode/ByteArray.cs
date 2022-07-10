using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.bytecode;

public class ByteArray : Object
{
	[LineNumberTable(27)]
	public static int readU16bit(byte[] code, int index)
	{
		return (code[index] << 8) | code[index + 1];
	}

	[LineNumberTable(new byte[] { 159, 183, 103, 103 })]
	public static void write16bit(int value, byte[] code, int index)
	{
		code[index] = (byte)(sbyte)((uint)value >> 8);
		code[index + 1] = (byte)(sbyte)value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(22)]
	public ByteArray()
	{
	}

	[LineNumberTable(34)]
	public static int readS16bit(byte[] code, int index)
	{
		return (code[index] << 8) | code[index + 1];
	}

	[LineNumberTable(49)]
	public static int read32bit(byte[] code, int index)
	{
		return (code[index] << 24) | (code[index + 1] << 16) | (code[index + 2] << 8) | code[index + 3];
	}

	[LineNumberTable(new byte[] { 7, 104, 106, 105, 103 })]
	public static void write32bit(int value, byte[] code, int index)
	{
		code[index] = (byte)(sbyte)((uint)value >> 24);
		code[index + 1] = (byte)(sbyte)((uint)value >> 16);
		code[index + 2] = (byte)(sbyte)((uint)value >> 8);
		code[index + 3] = (byte)(sbyte)value;
	}

	[LineNumberTable(new byte[] { 22, 102, 106, 106, 106 })]
	internal static void copy32bit(byte[] P_0, int P_1, byte[] P_2, int P_3)
	{
		P_2[P_3] = P_0[P_1];
		P_2[P_3 + 1] = P_0[P_1 + 1];
		P_2[P_3 + 2] = P_0[P_1 + 2];
		P_2[P_3 + 3] = P_0[P_1 + 3];
	}
}
