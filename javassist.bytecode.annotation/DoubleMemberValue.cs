using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class DoubleMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	public virtual double getValue()
	{
		double doubleInfo = cp.getDoubleInfo(valueIndex);
		_ = null;
		return doubleInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 107, 103 })]
	public DoubleMemberValue(int index, ConstPool cp)
		: base('D', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 10, 107, 109 })]
	public DoubleMemberValue(ConstPool cp)
		: base('D', cp)
	{
		setValue(0.0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 35, 115 })]
	public virtual void setValue(double newValue)
	{
		valueIndex = cp.addDoubleInfo(newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 107, 106 })]
	public DoubleMemberValue(double d, ConstPool cp)
		: base('D', cp)
	{
		setValue(d);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(66)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		Double result = Double.valueOf(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(71)]
	internal override Class getType(ClassLoader P_0)
	{
		return Double.TYPE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(93)]
	public override string toString()
	{
		string result = Double.toString(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 51, 110 })]
	public override void write(AnnotationsWriter writer)
	{
		writer.constValueIndex(getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 59, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitDoubleMemberValue(this);
	}
}
