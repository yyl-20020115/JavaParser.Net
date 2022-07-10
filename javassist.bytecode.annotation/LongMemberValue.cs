using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class LongMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(77)]
	public virtual long getValue()
	{
		long longInfo = cp.getLongInfo(valueIndex);
		_ = null;
		return longInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 107, 103 })]
	public LongMemberValue(int index, ConstPool cp)
		: base('J', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 107, 106 })]
	public LongMemberValue(ConstPool cp)
		: base('J', cp)
	{
		setValue(0L);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 114 })]
	public virtual void setValue(long newValue)
	{
		valueIndex = cp.addLongInfo(newValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 1, 107, 105 })]
	public LongMemberValue(long j, ConstPool cp)
		: base('J', cp)
	{
		setValue(j);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		Long result = Long.valueOf(getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(70)]
	internal override Class getType(ClassLoader P_0)
	{
		return Long.TYPE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(92)]
	public override string toString()
	{
		string result = Long.toString(getValue());
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
		visitor.visitLongMemberValue(this);
	}
}
