using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.util;

namespace javassist.bytecode.annotation;

public class ClassMemberValue : MemberValue
{
	internal int valueIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 107, 103 })]
	public ClassMemberValue(int index, ConstPool cp)
		: base('c', cp)
	{
		valueIndex = index;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 107, 109 })]
	public ClassMemberValue(ConstPool cp)
		: base('c', cp)
	{
		setValue("java.lang.Class");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 103, 114 })]
	public virtual void setValue(string newClassName)
	{
		string utf = Descriptor.of(newClassName);
		valueIndex = cp.addUtf8Info(utf);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 69, 146, 127, 2, 97 })]
	public virtual string getValue()
	{
		//Discarded unreachable code: IL_001f
		string utf8Info = cp.getUtf8Info(valueIndex);
		BadBytecode badBytecode;
		try
		{
			return SignatureAttribute.toTypeSignature(utf8Info).jvmTypeName();
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		BadBytecode cause = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 5, 107, 105 })]
	public ClassMemberValue(string className, ConstPool cp)
		: base('c', cp)
	{
		setValue(className);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		21, 103, 109, 102, 109, 102, 109, 102, 109, 102,
		109, 102, 109, 102, 109, 102, 109, 102, 109, 134
	})]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		string value = getValue();
		if (String.instancehelper_equals(value, "void"))
		{
			return Void.TYPE;
		}
		if (String.instancehelper_equals(value, "int"))
		{
			return Integer.TYPE;
		}
		if (String.instancehelper_equals(value, "byte"))
		{
			return Byte.TYPE;
		}
		if (String.instancehelper_equals(value, "long"))
		{
			return Long.TYPE;
		}
		if (String.instancehelper_equals(value, "double"))
		{
			return Double.TYPE;
		}
		if (String.instancehelper_equals(value, "float"))
		{
			return Float.TYPE;
		}
		if (String.instancehelper_equals(value, "char"))
		{
			return Character.TYPE;
		}
		if (String.instancehelper_equals(value, "short"))
		{
			return Short.TYPE;
		}
		if (String.instancehelper_equals(value, "boolean"))
		{
			return Boolean.TYPE;
		}
		Class result = MemberValue.loadClass(P_0, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(96)]
	internal override Class getType(ClassLoader P_0)
	{
		Class result = MemberValue.loadClass(P_0, "java.lang.Class");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 51, 114, 105, 110 })]
	public override void renameClass(string oldname, string newname)
	{
		string utf8Info = cp.getUtf8Info(valueIndex);
		string descriptor = Descriptor.rename(utf8Info, oldname, newname);
		setValue(Descriptor.toClassName(descriptor));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 58, 114, 104, 110 })]
	public override void renameClass(Map classnames)
	{
		string utf8Info = cp.getUtf8Info(valueIndex);
		string descriptor = Descriptor.rename(utf8Info, classnames);
		setValue(Descriptor.toClassName(descriptor));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(142)]
	public override string toString()
	{
		string result = new StringBuilder().append(String.instancehelper_replace(getValue(), '$', '.')).append(".class").toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 100, 121 })]
	public override void write(AnnotationsWriter writer)
	{
		writer.classInfoIndex(cp.getUtf8Info(valueIndex));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 108, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitClassMemberValue(this);
	}
}
