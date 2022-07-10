using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;

namespace javassist.bytecode.annotation;

public class AnnotationsWriter : Object
{
	protected internal OutputStream output;

	private ConstPool pool;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 104, 103, 103 })]
	public AnnotationsWriter(OutputStream os, ConstPool cp)
	{
		output = os;
		pool = cp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 38, 109 })]
	public virtual void close()
	{
		output.close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 48, 110 })]
	public virtual void numParameters(int num)
	{
		output.write(num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 58, 105 })]
	public virtual void numAnnotations(int num)
	{
		write16bit(num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 88, 103, 105 })]
	public virtual void annotation(int typeIndex, int numMemberValuePairs)
	{
		write16bit(typeIndex);
		write16bit(numMemberValuePairs);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 116, 105 })]
	public virtual void memberValuePair(int memberNameIndex)
	{
		write16bit(memberNameIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 156, 108, 105 })]
	public virtual void constValueIndex(int tag, int index)
	{
		output.write(tag);
		write16bit(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 186, 109, 103, 105 })]
	public virtual void enumConstValue(int typeNameIndex, int constNameIndex)
	{
		output.write(101);
		write16bit(typeNameIndex);
		write16bit(constNameIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 208, 109, 105 })]
	public virtual void classInfoIndex(int index)
	{
		output.write(99);
		write16bit(index);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 218, 111 })]
	public virtual void annotationValue()
	{
		output.write(64);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 232, 109, 105 })]
	public virtual void arrayValue(int numValues)
	{
		output.write(91);
		write16bit(numValues);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 73, 117 })]
	public virtual void annotation(string type, int numMemberValuePairs)
	{
		annotation(pool.addUtf8Info(type), numMemberValuePairs);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 237, 103, 104, 110 })]
	protected internal virtual void write16bit(int value)
	{
		byte[] array = new byte[2];
		ByteArray.write16bit(value, array, 0);
		output.write(array);
	}

	public virtual ConstPool getConstPool()
	{
		return pool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 102, 116 })]
	public virtual void memberValuePair(string memberName)
	{
		memberValuePair(pool.addUtf8Info(memberName));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 98, 66, 124 })]
	public virtual void constValueIndex(bool value)
	{
		constValueIndex(90, pool.addIntegerInfo(value ? 1 : 0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 96, 131, 118 })]
	public virtual void constValueIndex(byte value)
	{
		int i = (sbyte)value;
		constValueIndex(66, pool.addIntegerInfo(i));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 93, 66, 118 })]
	public virtual void constValueIndex(char value)
	{
		constValueIndex(67, pool.addIntegerInfo(value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 91, 130, 118 })]
	public virtual void constValueIndex(short value)
	{
		constValueIndex(83, pool.addIntegerInfo(value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 102, 118 })]
	public virtual void constValueIndex(int value)
	{
		constValueIndex(73, pool.addIntegerInfo(value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 112, 118 })]
	public virtual void constValueIndex(long value)
	{
		constValueIndex(74, pool.addLongInfo(value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 122, 119 })]
	public virtual void constValueIndex(float value)
	{
		constValueIndex(70, pool.addFloatInfo(value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 132, 119 })]
	public virtual void constValueIndex(double value)
	{
		constValueIndex(68, pool.addDoubleInfo(value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 142, 118 })]
	public virtual void constValueIndex(string value)
	{
		constValueIndex(115, pool.addUtf8Info(value));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 170, 116, 37, 135 })]
	public virtual void enumConstValue(string typeName, string constName)
	{
		enumConstValue(pool.addUtf8Info(typeName), pool.addUtf8Info(constName));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 198, 116 })]
	public virtual void classInfoIndex(string name)
	{
		classInfoIndex(pool.addUtf8Info(name));
	}
}
