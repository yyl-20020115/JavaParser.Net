using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class FloatMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 107, 103 })]
	public FloatMemberValue(int index, ConstPool cp)
		: base('F', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 10, 107, 109 })]
	public FloatMemberValue(ConstPool cp)
		: base('F', cp)
	{
		setValue(0f);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 35, 115 })]
	public virtual void setValue(float newValue)
	{
		valueIndex = cp.addFloatInfo(newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	public virtual float getValue()
	{
		float floatInfo = cp.getFloatInfo(valueIndex);
		_ = null;
		return floatInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 107, 106 })]
	public FloatMemberValue(float f, ConstPool cp)
		: base('F', cp)
	{
		setValue(f);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(66)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		Float result = Float.valueOf(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(71)]
	internal override Class getType(ClassLoader P_0)
	{
		return Float.TYPE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(93)]
	public override string toString()
	{
		string result = Float.toString(getValue());
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
		visitor.visitFloatMemberValue(this);
	}
}
