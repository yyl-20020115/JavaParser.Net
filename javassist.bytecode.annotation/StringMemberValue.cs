using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class StringMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(77)]
	public virtual string getValue()
	{
		string utf8Info = cp.getUtf8Info(valueIndex);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 107, 103 })]
	public StringMemberValue(int index, ConstPool cp)
		: base('s', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 107, 109 })]
	public StringMemberValue(ConstPool cp)
		: base('s', cp)
	{
		setValue("");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 114 })]
	public virtual void setValue(string newValue)
	{
		valueIndex = cp.addUtf8Info(newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 1, 107, 105 })]
	public StringMemberValue(string str, ConstPool cp)
		: base('s', cp)
	{
		setValue(str);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		string value = getValue();
		_ = null;
		return value;
	}

	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(70)]
	internal override Class getType(ClassLoader P_0)
	{
		return ClassLiteral<String>.Value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(92)]
	public override string toString()
	{
		string result = new StringBuilder().append("\"").append(getValue()).append("\"")
			.toString();
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
		visitor.visitStringMemberValue(this);
	}
}
