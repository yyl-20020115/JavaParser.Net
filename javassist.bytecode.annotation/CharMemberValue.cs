using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class CharMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(77)]
	public virtual char getValue()
	{
		return (char)cp.getIntegerInfo(valueIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 107, 103 })]
	public CharMemberValue(int index, ConstPool cp)
		: base('C', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 107, 105 })]
	public CharMemberValue(ConstPool cp)
		: base('C', cp)
	{
		setValue('\0');
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 121, 66, 114 })]
	public virtual void setValue(char newValue)
	{
		valueIndex = cp.addIntegerInfo(newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 130, 162, 107, 105 })]
	public CharMemberValue(char c, ConstPool cp)
		: base('C', cp)
	{
		setValue(c);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		Character result = Character.valueOf(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(70)]
	internal override Class getType(ClassLoader P_0)
	{
		return Character.TYPE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(92)]
	public override string toString()
	{
		string result = Character.toString(getValue());
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
		visitor.visitCharMemberValue(this);
	}
}
