using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class IntegerMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(83)]
	public virtual int getValue()
	{
		int integerInfo = cp.getIntegerInfo(valueIndex);
		_ = null;
		return integerInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 107, 103 })]
	public IntegerMemberValue(int index, ConstPool cp)
		: base('I', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 107, 105 })]
	public IntegerMemberValue(ConstPool cp)
		: base('I', cp)
	{
		setValue(0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 40, 114 })]
	public virtual void setValue(int newValue)
	{
		valueIndex = cp.addIntegerInfo(newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 7, 107, 105 })]
	public IntegerMemberValue(ConstPool cp, int value)
		: base('I', cp)
	{
		setValue(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(71)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		Integer result = Integer.valueOf(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(76)]
	internal override Class getType(ClassLoader P_0)
	{
		return Integer.TYPE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(98)]
	public override string toString()
	{
		string result = Integer.toString(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 56, 110 })]
	public override void write(AnnotationsWriter writer)
	{
		writer.constValueIndex(getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 64, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitIntegerMemberValue(this);
	}
}
