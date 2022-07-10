using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class ShortMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 107, 103 })]
	public ShortMemberValue(int index, ConstPool cp)
		: base('S', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 107, 105 })]
	public ShortMemberValue(ConstPool cp)
		: base('S', cp)
	{
		setValue(0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 121, 66, 114 })]
	public virtual void setValue(short newValue)
	{
		valueIndex = cp.addIntegerInfo(newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(77)]
	public virtual short getValue()
	{
		return (short)cp.getIntegerInfo(valueIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 130, 162, 107, 105 })]
	public ShortMemberValue(short s, ConstPool cp)
		: base('S', cp)
	{
		setValue(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		Short result = Short.valueOf(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(70)]
	internal override Class getType(ClassLoader P_0)
	{
		return Short.TYPE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(92)]
	public override string toString()
	{
		string result = Short.toString(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 50, 110 })]
	public override void write(AnnotationsWriter writer)
	{
		writer.constValueIndex(getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitShortMemberValue(this);
	}
}
