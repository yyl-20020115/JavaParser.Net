using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;

namespace javassist.bytecode.annotation;

public class ArrayMemberValue : MemberValue
{
	internal MemberValue type;

	internal MemberValue[] values;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 182, 107, 103, 103 })]
	public ArrayMemberValue(ConstPool cp)
		: base('[', cp)
	{
		type = null;
		values = null;
	}

	[LineNumberTable(new byte[] { 85, 103, 104, 105 })]
	public virtual void setValue(MemberValue[] elements)
	{
		values = elements;
		if (elements != null && (nint)elements.LongLength > 0)
		{
			type = elements[0];
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 1, 107, 103, 103 })]
	public ArrayMemberValue(MemberValue t, ConstPool cp)
		: base('[', cp)
	{
		type = t;
		values = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		10, 104, 112, 154, 136, 104, 108, 103, 112, 186,
		141, 104, 102, 55, 166
	})]
	internal override object getValue(ClassLoader P_0, ClassPool P_1, Method P_2)
	{
		if (values == null)
		{
			string s = new StringBuilder().append("no array elements found: ").append(P_2.getName()).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ClassNotFoundException(s);
		}
		int num = values.Length;
		Class componentType;
		if (type == null)
		{
			componentType = P_2.getReturnType().getComponentType();
			if (componentType == null || num > 0)
			{
				string s2 = new StringBuilder().append("broken array type: ").append(P_2.getName()).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new java.lang.ClassNotFoundException(s2);
			}
		}
		else
		{
			componentType = type.getType(P_0);
		}
		object obj = Array.newInstance(componentType, num);
		for (int i = 0; i < num; i++)
		{
			Array.set(obj, i, values[i].getValue(P_0, P_1, P_2));
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/ClassLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 34, 104, 144, 115 })]
	internal override Class getType(ClassLoader P_0)
	{
		if (type == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ClassNotFoundException("no array type specified");
		}
		object @this = Array.newInstance(type.getType(P_0), 0);
		Class result = Object.instancehelper_getClass(@this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 43, 104, 141, 104, 116, 40, 198 })]
	public override void renameClass(string oldname, string newname)
	{
		if (type != null)
		{
			type.renameClass(oldname, newname);
		}
		if (values != null)
		{
			MemberValue[] array = values;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				MemberValue memberValue = array[i];
				memberValue.renameClass(oldname, newname);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 55, 104, 140, 104, 116, 39, 198 })]
	public override void renameClass(Map classnames)
	{
		if (type != null)
		{
			type.renameClass(classnames);
		}
		if (values != null)
		{
			MemberValue[] array = values;
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				MemberValue memberValue = array[i];
				memberValue.renameClass(classnames);
			}
		}
	}

	public virtual MemberValue getType()
	{
		return type;
	}

	public virtual MemberValue[] getValue()
	{
		return values;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		95, 102, 105, 104, 108, 116, 108, 236, 61, 230,
		71, 105
	})]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append('{');
		if (values != null)
		{
			for (int i = 0; i < (nint)values.LongLength; i++)
			{
				stringBuilder.append(Object.instancehelper_toString(values[i]));
				if (i + 1 < (nint)values.LongLength)
				{
					stringBuilder.append(", ");
				}
			}
		}
		stringBuilder.append('}');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 114, 115, 103, 102, 46, 134 })]
	public override void write(AnnotationsWriter writer)
	{
		int num = (int)((values != null) ? values.LongLength : 0);
		writer.arrayValue(num);
		for (int i = 0; i < num; i++)
		{
			values[i].write(writer);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 125, 105 })]
	public override void accept(MemberValueVisitor visitor)
	{
		visitor.visitArrayMemberValue(this);
	}
}
