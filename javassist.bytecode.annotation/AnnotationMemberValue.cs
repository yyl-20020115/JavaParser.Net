using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;

namespace javassist.bytecode.annotation;

public class AnnotationMemberValue : MemberValue
{
	internal Annotation value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 107, 103 })]
	public AnnotationMemberValue(Annotation a, ConstPool cp)
		: base('@', cp)
	{
		value = a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 8, 104, 112 })]
	internal override Class getType(ClassLoader P_0)
	{
		if (value == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ClassNotFoundException("no type specified");
		}
		Class result = MemberValue.loadClass(P_0, value.getTypeName());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 179, 106 })]
	public AnnotationMemberValue(ConstPool cp)
		: this(null, cp)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(53)]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		object result = AnnotationImpl.make(P_0, getType(P_0), P_1, value);
		_ = null;
		return result;
	}

	public virtual Annotation getValue()
	{
		return value;
	}

	public virtual void setValue(Annotation newValue)
	{
		value = newValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(82)]
	public override string toString()
	{
		string result = value.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 40, 102, 110 })]
	public override void write(AnnotationsWriter writer)
	{
		writer.annotationValue();
		value.write(writer);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 49, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitAnnotationMemberValue(this);
	}
}
