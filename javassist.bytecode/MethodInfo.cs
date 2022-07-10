using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using javassist.bytecode.stackmap;

namespace javassist.bytecode;

public class MethodInfo : Object
{
	internal ConstPool constPool;

	internal int accessFlags;

	internal int name;

	internal string cachedName;

	internal int descriptor;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	internal List attribute;

	public static bool doPreverify;

	public const string nameInit = "<init>";

	public const string nameClinit = "<clinit>";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(330)]
	public virtual AttributeInfo getAttribute(string name)
	{
		AttributeInfo result = AttributeInfo.lookup(attribute, name);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(286)]
	public virtual string getDescriptor()
	{
		string utf8Info = constPool.getUtf8Info(descriptor);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 250, 145 })]
	public virtual ExceptionsAttribute getExceptionsAttribute()
	{
		AttributeInfo attributeInfo = AttributeInfo.lookup(attribute, "Exceptions");
		return (ExceptionsAttribute)attributeInfo;
	}

	public virtual int getAccessFlags()
	{
		return accessFlags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 5, 113 })]
	public virtual CodeAttribute getCodeAttribute()
	{
		AttributeInfo attributeInfo = AttributeInfo.lookup(attribute, "Code");
		return (CodeAttribute)attributeInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 69, 106, 135, 103, 105 })]
	public virtual void rebuildStackMapIf6(ClassPool pool, ClassFile cf)
	{
		if (cf.getMajorVersion() >= 50)
		{
			rebuildStackMap(pool);
		}
		if (doPreverify)
		{
			rebuildStackMapForME(pool);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 104, 104, 151 })]
	public virtual string getName()
	{
		if (cachedName == null)
		{
			cachedName = constPool.getUtf8Info(name);
		}
		return cachedName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/lang/String;Ljavassist/bytecode/MethodInfo;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 84, 105, 108 })]
	public MethodInfo(ConstPool cp, string methodname, MethodInfo src, Map classnameMap)
		: this(cp)
	{
		read(src, methodname, classnameMap);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[]
	{
		161, 154, 104, 129, 103, 103, 103, 103, 100, 104,
		107, 107, 106, 109, 141
	})]
	public virtual void setSuperclass(string superclass)
	{
		if (isConstructor())
		{
			CodeAttribute codeAttribute = getCodeAttribute();
			byte[] code = codeAttribute.getCode();
			CodeIterator codeIterator = codeAttribute.iterator();
			int num = codeIterator.skipSuperConstructor();
			if (num >= 0)
			{
				ConstPool constPool = this.constPool;
				int index = ByteArray.readU16bit(code, num + 1);
				int methodrefNameAndType = constPool.getMethodrefNameAndType(index);
				int classInfo = constPool.addClassInfo(superclass);
				int value = constPool.addMethodrefInfo(classInfo, methodrefNameAndType);
				ByteArray.write16bit(value, code, num + 1);
			}
		}
	}

	public virtual void setAccessFlags(int acc)
	{
		accessFlags = acc;
	}

	public virtual ConstPool getConstPool()
	{
		return constPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 237, 104, 139, 114, 109 })]
	public virtual void addAttribute(AttributeInfo info)
	{
		if (attribute == null)
		{
			attribute = new ArrayList();
		}
		AttributeInfo.remove(attribute, info.getName());
		attribute.add(info);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 13, 113 })]
	public virtual void removeExceptionsAttribute()
	{
		AttributeInfo.remove(attribute, "Exceptions");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 24, 102, 104, 139, 109 })]
	public virtual void setExceptionsAttribute(ExceptionsAttribute cattr)
	{
		removeExceptionsAttribute();
		if (attribute == null)
		{
			attribute = new ArrayList();
		}
		attribute.add(cattr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 46, 102, 104, 139, 109 })]
	public virtual void setCodeAttribute(CodeAttribute cattr)
	{
		removeCodeAttribute();
		if (attribute == null)
		{
			attribute = new ArrayList();
		}
		attribute.add(cattr);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 181, 110, 114 })]
	public virtual void setDescriptor(string desc)
	{
		if (!String.instancehelper_equals(desc, getDescriptor()))
		{
			descriptor = constPool.addUtf8Info(desc);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 123, 103 })]
	public virtual bool isMethod()
	{
		string @this = getName();
		return (!String.instancehelper_equals(@this, "<init>") && !String.instancehelper_equals(@this, "<clinit>")) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 50, 105, 103, 109, 103, 114 })]
	public MethodInfo(ConstPool cp, string methodname, string desc)
		: this(cp)
	{
		accessFlags = 0;
		name = cp.addUtf8Info(methodname);
		cachedName = methodname;
		descriptor = constPool.addUtf8Info(desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(252)]
	public virtual bool isConstructor()
	{
		bool result = String.instancehelper_equals(getName(), "<init>");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(259)]
	public virtual bool isStaticInitializer()
	{
		bool result = String.instancehelper_equals(getName(), "<clinit>");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 114, 114, 103 })]
	public virtual void setName(string newName)
	{
		name = constPool.addUtf8Info(newName);
		cachedName = newName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(143)]
	public override string toString()
	{
		string result = new StringBuilder().append(getName()).append(" ").append(getDescriptor())
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 105, 114, 114, 114, 103 })]
	internal virtual void compact(ConstPool P_0)
	{
		name = P_0.addUtf8Info(getName());
		descriptor = P_0.addUtf8Info(getDescriptor());
		attribute = AttributeInfo.copyAll(attribute, P_0);
		constPool = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		112, 134, 102, 102, 99, 105, 168, 102, 102, 99,
		105, 168, 102, 102, 99, 105, 168, 102, 103, 100,
		107, 169, 102, 108, 100, 137, 104, 100, 137, 102,
		103, 100, 107, 169, 103, 114, 114, 103
	})]
	internal virtual void prune(ConstPool P_0)
	{
		ArrayList arrayList = new ArrayList();
		AttributeInfo attributeInfo = getAttribute("RuntimeInvisibleAnnotations");
		if (attributeInfo != null)
		{
			attributeInfo = attributeInfo.copy(P_0, null);
			((List)arrayList).add((object)attributeInfo);
		}
		AttributeInfo attributeInfo2 = getAttribute("RuntimeVisibleAnnotations");
		if (attributeInfo2 != null)
		{
			attributeInfo2 = attributeInfo2.copy(P_0, null);
			((List)arrayList).add((object)attributeInfo2);
		}
		AttributeInfo attributeInfo3 = getAttribute("RuntimeInvisibleParameterAnnotations");
		if (attributeInfo3 != null)
		{
			attributeInfo3 = attributeInfo3.copy(P_0, null);
			((List)arrayList).add((object)attributeInfo3);
		}
		AttributeInfo attributeInfo4 = getAttribute("RuntimeVisibleParameterAnnotations");
		if (attributeInfo4 != null)
		{
			attributeInfo4 = attributeInfo4.copy(P_0, null);
			((List)arrayList).add((object)attributeInfo4);
		}
		AnnotationDefaultAttribute annotationDefaultAttribute = (AnnotationDefaultAttribute)getAttribute("AnnotationDefault");
		if (annotationDefaultAttribute != null)
		{
			((List)arrayList).add((object)annotationDefaultAttribute);
		}
		ExceptionsAttribute exceptionsAttribute = getExceptionsAttribute();
		if (exceptionsAttribute != null)
		{
			((List)arrayList).add((object)exceptionsAttribute);
		}
		AttributeInfo attributeInfo5 = getAttribute("Signature");
		if (attributeInfo5 != null)
		{
			attributeInfo5 = attributeInfo5.copy(P_0, null);
			((List)arrayList).add((object)attributeInfo5);
		}
		attribute = arrayList;
		name = P_0.addUtf8Info(getName());
		descriptor = P_0.addUtf8Info(getDescriptor());
		constPool = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	[LineNumberTable(new byte[] { 160, 196, 104, 139 })]
	public virtual List getAttributes()
	{
		if (attribute == null)
		{
			attribute = new ArrayList();
		}
		return attribute;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 58, 105, 105 })]
	internal MethodInfo(ConstPool P_0, DataInputStream P_1)
		: this(P_0)
	{
		read(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 161, 202, 108, 108, 140, 104, 137, 113, 142 })]
	internal virtual void write(DataOutputStream P_0)
	{
		P_0.writeShort(accessFlags);
		P_0.writeShort(name);
		P_0.writeShort(descriptor);
		if (attribute == null)
		{
			P_0.writeShort(0);
			return;
		}
		P_0.writeShort(attribute.size());
		AttributeInfo.writeAll(attribute, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 104, 103, 103 })]
	private MethodInfo(ConstPool P_0)
	{
		constPool = P_0;
		attribute = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 161, 192, 108, 108, 108, 103, 107, 102, 56, 134 })]
	private void read(DataInputStream P_0)
	{
		accessFlags = P_0.readUnsignedShort();
		name = P_0.readUnsignedShort();
		descriptor = P_0.readUnsignedShort();
		int num = P_0.readUnsignedShort();
		attribute = new ArrayList();
		for (int i = 0; i < num; i++)
		{
			attribute.add(AttributeInfo.read(constPool, P_0));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/MethodInfo;Ljava/lang/String;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[]
	{
		161, 172, 103, 108, 109, 103, 103, 109, 104, 141,
		107, 104, 100, 149, 104, 100, 117
	})]
	private void read(MethodInfo P_0, string P_1, Map P_2)
	{
		ConstPool constPool = this.constPool;
		accessFlags = P_0.accessFlags;
		name = constPool.addUtf8Info(P_1);
		cachedName = P_1;
		ConstPool constPool2 = P_0.constPool;
		string utf8Info = constPool2.getUtf8Info(P_0.descriptor);
		string utf = Descriptor.rename(utf8Info, P_2);
		descriptor = constPool.addUtf8Info(utf);
		attribute = new ArrayList();
		ExceptionsAttribute exceptionsAttribute = P_0.getExceptionsAttribute();
		if (exceptionsAttribute != null)
		{
			attribute.add(exceptionsAttribute.copy(constPool, P_2));
		}
		CodeAttribute codeAttribute = P_0.getCodeAttribute();
		if (codeAttribute != null)
		{
			attribute.add(codeAttribute.copy(constPool, P_2));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 35, 113 })]
	public virtual void removeCodeAttribute()
	{
		AttributeInfo.remove(attribute, "Code");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 86, 103, 99, 104, 137 })]
	public virtual void rebuildStackMap(ClassPool pool)
	{
		CodeAttribute codeAttribute = getCodeAttribute();
		if (codeAttribute != null)
		{
			StackMapTable stackMapTable = MapMaker.make(pool, this);
			codeAttribute.setAttribute(stackMapTable);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.BadBytecode" })]
	[LineNumberTable(new byte[] { 161, 103, 103, 99, 104, 137 })]
	public virtual void rebuildStackMapForME(ClassPool pool)
	{
		CodeAttribute codeAttribute = getCodeAttribute();
		if (codeAttribute != null)
		{
			StackMap stackMap = MapMaker.make2(pool, this);
			codeAttribute.setAttribute(stackMap);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(341)]
	public virtual AttributeInfo removeAttribute(string name)
	{
		AttributeInfo result = AttributeInfo.remove(attribute, name);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 120, 103, 99, 130, 102, 107, 99, 130 })]
	public virtual int getLineNumber(int pos)
	{
		CodeAttribute codeAttribute = getCodeAttribute();
		if (codeAttribute == null)
		{
			return -1;
		}
		LineNumberAttribute lineNumberAttribute = (LineNumberAttribute)codeAttribute.getAttribute("LineNumberTable");
		if (lineNumberAttribute == null)
		{
			return -1;
		}
		int result = lineNumberAttribute.toLineNumber(pos);
		_ = null;
		return result;
	}
}
