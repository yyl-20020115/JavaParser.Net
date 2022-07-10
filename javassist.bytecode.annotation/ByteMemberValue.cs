using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class ByteMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 182, 107, 103 })]
	public ByteMemberValue(int index, ConstPool cp)
		: base('B', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 8, 107, 105 })]
	public ByteMemberValue(ConstPool cp)
		: base('B', cp)
	{
		setValue(0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 122, 163, 114 })]
	public virtual void setValue(byte newValue)
	{
		int i = (sbyte)newValue;
		valueIndex = cp.addIntegerInfo(i);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	public virtual byte getValue()
	{
		return (byte)(sbyte)cp.getIntegerInfo(valueIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 130, 131, 107, 105 })]
	public ByteMemberValue(byte b, ConstPool cp)
	{
		int value = (sbyte)b;
		base._002Ector('B', cp);
		setValue((byte)value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		Byte result = Byte.valueOf((byte)(sbyte)getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(69)]
	internal override Class getType(ClassLoader P_0)
	{
		return Byte.TYPE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(91)]
	public override string toString()
	{
		string result = Byte.toString((byte)(sbyte)getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 49, 111 })]
	public override void write(AnnotationsWriter writer)
	{
		writer.constValueIndex((byte)(sbyte)getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 57, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitByteMemberValue(this);
	}
}
