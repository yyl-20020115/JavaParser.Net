using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public class AttributeInfo : Object
{
	protected internal ConstPool constPool;

	internal int name;

	internal byte[] info;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(190)]
	public virtual AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		AttributeInfo result = new AttributeInfo(newCp, getName(), Arrays.copyOf(info, info.Length));
		_ = null;
		return result;
	}

	public virtual byte[] get()
	{
		return info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 11, 113 })]
	public AttributeInfo(ConstPool cp, string attrname, byte[] attrinfo)
		: this(cp, cp.addUtf8Info(attrname), attrinfo)
	{
	}

	public virtual ConstPool getConstPool()
	{
		return constPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 104, 103, 103, 103 })]
	protected internal AttributeInfo(ConstPool cp, int attrname, byte[] attrinfo)
	{
		constPool = cp;
		name = attrname;
		info = attrinfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 16, 104, 103, 103, 103, 108, 100, 110 })]
	protected internal AttributeInfo(ConstPool cp, int n, DataInputStream @in)
	{
		constPool = cp;
		name = n;
		int num = @in.readInt();
		info = new byte[num];
		if (num > 0)
		{
			@in.readFully(info);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(145)]
	public virtual string getName()
	{
		string utf8Info = constPool.getUtf8Info(name);
		_ = null;
		return utf8Info;
	}

	[LineNumberTable(159)]
	public virtual int length()
	{
		return (int)((nint)info.LongLength + 6);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 81, 108, 109, 106, 110 })]
	internal virtual void write(DataOutputStream P_0)
	{
		P_0.writeShort(name);
		P_0.writeInt(info.Length);
		if ((nint)info.LongLength > 0)
		{
			P_0.write(info);
		}
	}

	internal virtual void renameClass(string P_0, string P_1)
	{
	}

	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	internal virtual void renameClass(Map P_0)
	{
	}

	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	internal virtual void getRefClasses(Map P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 191, 112 })]
	protected internal AttributeInfo(ConstPool cp, string attrname)
		: this(cp, attrname, null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		28, 103, 104, 104, 104, 109, 107, 109, 107, 109,
		107, 109, 107, 109, 139, 104, 109, 107, 109, 107,
		109, 107, 109, 107, 109, 107, 109, 139, 136, 109,
		107, 109, 107, 109, 107, 115, 135, 107, 115, 103,
		107, 115, 103, 139, 104, 109, 107, 109, 107, 109,
		107, 109, 107, 109, 139
	})]
	internal static AttributeInfo read(ConstPool P_0, DataInputStream P_1)
	{
		int num = P_1.readUnsignedShort();
		string utf8Info = P_0.getUtf8Info(num);
		int num2 = String.instancehelper_charAt(utf8Info, 0);
		if (num2 < 69)
		{
			if (String.instancehelper_equals(utf8Info, "AnnotationDefault"))
			{
				AnnotationDefaultAttribute result = new AnnotationDefaultAttribute(P_0, num, P_1);
				_ = null;
				return result;
			}
			if (String.instancehelper_equals(utf8Info, "BootstrapMethods"))
			{
				BootstrapMethodsAttribute result2 = new BootstrapMethodsAttribute(P_0, num, P_1);
				_ = null;
				return result2;
			}
			if (String.instancehelper_equals(utf8Info, "Code"))
			{
				CodeAttribute result3 = new CodeAttribute(P_0, num, P_1);
				_ = null;
				return result3;
			}
			if (String.instancehelper_equals(utf8Info, "ConstantValue"))
			{
				ConstantAttribute result4 = new ConstantAttribute(P_0, num, P_1);
				_ = null;
				return result4;
			}
			if (String.instancehelper_equals(utf8Info, "Deprecated"))
			{
				DeprecatedAttribute result5 = new DeprecatedAttribute(P_0, num, P_1);
				_ = null;
				return result5;
			}
		}
		if (num2 < 77)
		{
			if (String.instancehelper_equals(utf8Info, "EnclosingMethod"))
			{
				EnclosingMethodAttribute result6 = new EnclosingMethodAttribute(P_0, num, P_1);
				_ = null;
				return result6;
			}
			if (String.instancehelper_equals(utf8Info, "Exceptions"))
			{
				ExceptionsAttribute result7 = new ExceptionsAttribute(P_0, num, P_1);
				_ = null;
				return result7;
			}
			if (String.instancehelper_equals(utf8Info, "InnerClasses"))
			{
				InnerClassesAttribute result8 = new InnerClassesAttribute(P_0, num, P_1);
				_ = null;
				return result8;
			}
			if (String.instancehelper_equals(utf8Info, "LineNumberTable"))
			{
				LineNumberAttribute result9 = new LineNumberAttribute(P_0, num, P_1);
				_ = null;
				return result9;
			}
			if (String.instancehelper_equals(utf8Info, "LocalVariableTable"))
			{
				LocalVariableAttribute result10 = new LocalVariableAttribute(P_0, num, P_1);
				_ = null;
				return result10;
			}
			if (String.instancehelper_equals(utf8Info, "LocalVariableTypeTable"))
			{
				LocalVariableTypeAttribute result11 = new LocalVariableTypeAttribute(P_0, num, P_1);
				_ = null;
				return result11;
			}
		}
		if (num2 < 83)
		{
			if (String.instancehelper_equals(utf8Info, "MethodParameters"))
			{
				MethodParametersAttribute result12 = new MethodParametersAttribute(P_0, num, P_1);
				_ = null;
				return result12;
			}
			if (String.instancehelper_equals(utf8Info, "NestHost"))
			{
				NestHostAttribute result13 = new NestHostAttribute(P_0, num, P_1);
				_ = null;
				return result13;
			}
			if (String.instancehelper_equals(utf8Info, "NestMembers"))
			{
				NestMembersAttribute result14 = new NestMembersAttribute(P_0, num, P_1);
				_ = null;
				return result14;
			}
			if (String.instancehelper_equals(utf8Info, "RuntimeVisibleAnnotations") || String.instancehelper_equals(utf8Info, "RuntimeInvisibleAnnotations"))
			{
				AnnotationsAttribute result15 = new AnnotationsAttribute(P_0, num, P_1);
				_ = null;
				return result15;
			}
			if (String.instancehelper_equals(utf8Info, "RuntimeVisibleParameterAnnotations") || String.instancehelper_equals(utf8Info, "RuntimeInvisibleParameterAnnotations"))
			{
				ParameterAnnotationsAttribute result16 = new ParameterAnnotationsAttribute(P_0, num, P_1);
				_ = null;
				return result16;
			}
			if (String.instancehelper_equals(utf8Info, "RuntimeVisibleTypeAnnotations") || String.instancehelper_equals(utf8Info, "RuntimeInvisibleTypeAnnotations"))
			{
				TypeAnnotationsAttribute result17 = new TypeAnnotationsAttribute(P_0, num, P_1);
				_ = null;
				return result17;
			}
		}
		if (num2 >= 83)
		{
			if (String.instancehelper_equals(utf8Info, "Signature"))
			{
				SignatureAttribute result18 = new SignatureAttribute(P_0, num, P_1);
				_ = null;
				return result18;
			}
			if (String.instancehelper_equals(utf8Info, "SourceFile"))
			{
				SourceFileAttribute result19 = new SourceFileAttribute(P_0, num, P_1);
				_ = null;
				return result19;
			}
			if (String.instancehelper_equals(utf8Info, "Synthetic"))
			{
				SyntheticAttribute result20 = new SyntheticAttribute(P_0, num, P_1);
				_ = null;
				return result20;
			}
			if (String.instancehelper_equals(utf8Info, "StackMap"))
			{
				StackMap result21 = new StackMap(P_0, num, P_1);
				_ = null;
				return result21;
			}
			if (String.instancehelper_equals(utf8Info, "StackMapTable"))
			{
				StackMapTable result22 = new StackMapTable(P_0, num, P_1);
				_ = null;
				return result22;
			}
		}
		AttributeInfo result23 = new AttributeInfo(P_0, num, P_1);
		_ = null;
		return result23;
	}

	public virtual void set(byte[] newinfo)
	{
		info = newinfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;)I")]
	[LineNumberTable(new byte[] { 160, 88, 130, 123, 139 })]
	internal static int getLength(List P_0)
	{
		int num = 0;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
			num += attributeInfo.length();
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;Ljava/lang/String;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 160, 97, 99, 130, 123, 110, 34, 162 })]
	internal static AttributeInfo lookup(List P_0, string P_1)
	{
		if (P_0 == null)
		{
			return null;
		}
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
			if (String.instancehelper_equals(attributeInfo.getName(), P_1))
			{
				return attributeInfo;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Super)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;Ljava/lang/String;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 159, 87, 140, 99, 132, 123, 110, 105, 4, 194 })]
	internal static AttributeInfo remove(List P_0, string P_1)
	{
		lock (ClassLiteral<AttributeInfo>.Value)
		{
			if (P_0 == null)
			{
				return null;
			}
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
				if (String.instancehelper_equals(attributeInfo.getName(), P_1) && P_0.remove(attributeInfo))
				{
					return attributeInfo;
				}
			}
			return null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;Ljava/io/DataOutputStream;)V")]
	[LineNumberTable(new byte[] { 160, 122, 99, 129, 123, 105 })]
	internal static void writeAll(List P_0, DataOutputStream P_1)
	{
		if (P_0 != null)
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
				attributeInfo.write(P_1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;Ljavassist/bytecode/ConstPool;)Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	[LineNumberTable(new byte[] { 160, 130, 99, 130, 102, 123, 145 })]
	internal static List copyAll(List P_0, ConstPool P_1)
	{
		if (P_0 == null)
		{
			return null;
		}
		ArrayList arrayList = new ArrayList();
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
			((List)arrayList).add((object)attributeInfo.copy(P_1, null));
		}
		return arrayList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;Ljava/lang/String;Ljava/lang/String;)V")]
	[LineNumberTable(new byte[] { 160, 150, 99, 129, 123, 106 })]
	internal static void renameClass(List P_0, string P_1, string P_2)
	{
		if (P_0 != null)
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
				attributeInfo.renameClass(P_1, P_2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 160, 158, 99, 129, 123, 105 })]
	internal static void renameClass(List P_0, Map P_1)
	{
		if (P_0 != null)
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
				attributeInfo.renameClass(P_1);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 160, 168, 99, 129, 123, 105 })]
	internal static void getRefClasses(List P_0, Map P_1)
	{
		if (P_0 != null)
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
				attributeInfo.getRefClasses(P_1);
			}
		}
	}
}
