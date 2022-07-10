using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;

namespace javassist.bytecode.annotation;

public class EnumMemberValue : MemberValue
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	internal int typeIndex;

	internal int valueIndex;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 107, 103, 103 })]
	public EnumMemberValue(int type, int value, ConstPool cp)
		: base('e', cp)
	{
		typeIndex = type;
		valueIndex = value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 6, 107, 114 })]
	public EnumMemberValue(ConstPool cp)
		: base('e', cp)
	{
		int num = 0;
		valueIndex = num;
		typeIndex = num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 59, 119 })]
	public virtual void setType(string typename)
	{
		typeIndex = cp.addUtf8Info(Descriptor.of(typename));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(77)]
	internal override Class getType(ClassLoader P_0)
	{
		Class result = MemberValue.loadClass(P_0, getType());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(116)]
	public virtual string getValue()
	{
		string utf8Info = cp.getUtf8Info(valueIndex);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(100)]
	public virtual string getType()
	{
		string result = Descriptor.toClassName(cp.getUtf8Info(typeIndex));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 15, 159, 23, 97, 159, 22, 97 })]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		//Discarded unreachable code: IL_0024
		try
		{
			try
			{
				return getType(P_0).getField(getValue(), EnumMemberValue.___003CGetCallerID_003E()).get(null, EnumMemberValue.___003CGetCallerID_003E());
			}
			catch (NoSuchFieldException)
			{
			}
		}
		catch (IllegalAccessException)
		{
			goto IL_0032;
		}
		_ = null;
		string s = new StringBuilder().append(getType()).append(".").append(getValue())
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.lang.ClassNotFoundException(s);
		IL_0032:
		_ = null;
		string s2 = new StringBuilder().append(getType()).append(".").append(getValue())
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.lang.ClassNotFoundException(s2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 114, 105, 110 })]
	public override void renameClass(string oldname, string newname)
	{
		string utf8Info = cp.getUtf8Info(typeIndex);
		string descriptor = Descriptor.rename(utf8Info, oldname, newname);
		setType(Descriptor.toClassName(descriptor));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 39, 114, 104, 110 })]
	public override void renameClass(Map classnames)
	{
		string utf8Info = cp.getUtf8Info(typeIndex);
		string descriptor = Descriptor.rename(utf8Info, classnames);
		setType(Descriptor.toClassName(descriptor));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 73, 114 })]
	public virtual void setValue(string name)
	{
		valueIndex = cp.addUtf8Info(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(128)]
	public override string toString()
	{
		string result = new StringBuilder().append(getType()).append(".").append(getValue())
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 86, 127, 0 })]
	public override void write(AnnotationsWriter writer)
	{
		writer.enumConstValue(cp.getUtf8Info(typeIndex), getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 94, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitEnumMemberValue(this);
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
