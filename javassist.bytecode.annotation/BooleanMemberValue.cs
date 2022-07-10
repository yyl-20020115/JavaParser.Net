using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class BooleanMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	public virtual bool getValue()
	{
		return (cp.getIntegerInfo(valueIndex) != 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 182, 107, 103 })]
	public BooleanMemberValue(int index, ConstPool cp)
		: base('Z', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 8, 107, 105 })]
	public BooleanMemberValue(ConstPool cp)
		: base('Z', cp)
	{
		setValue(newValue: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 122, 162, 120 })]
	public virtual void setValue(bool newValue)
	{
		valueIndex = cp.addIntegerInfo(newValue ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 130, 130, 107, 105 })]
	public BooleanMemberValue(bool b, ConstPool cp)
		: base('Z', cp)
	{
		setValue(b);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		Boolean result = Boolean.valueOf(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(69)]
	internal override Class getType(ClassLoader P_0)
	{
		return Boolean.TYPE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(91)]
	public override string toString()
	{
		return (!getValue()) ? "false" : "true";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 49, 110 })]
	public override void write(AnnotationsWriter writer)
	{
		writer.constValueIndex(getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 57, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitBooleanMemberValue(this);
	}
}
