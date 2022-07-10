using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public sealed class ClassFile : java.lang.Object
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	internal int major;

	internal int minor;

	internal ConstPool constPool;

	internal int thisClass;

	internal int accessFlags;

	internal int superClass;

	internal int[] interfaces;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/FieldInfo;>;")]
	internal List fields;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/MethodInfo;>;")]
	internal List methods;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	internal List attributes;

	internal string thisclassname;

	internal string[] cachedInterfaces;

	internal string cachedSuperclass;

	public const int JAVA_1 = 45;

	public const int JAVA_2 = 46;

	public const int JAVA_3 = 47;

	public const int JAVA_4 = 48;

	public const int JAVA_5 = 49;

	public const int JAVA_6 = 50;

	public const int JAVA_7 = 51;

	public const int JAVA_8 = 52;

	public const int JAVA_9 = 53;

	public const int JAVA_10 = 54;

	public const int JAVA_11 = 55;

	internal static int ___003C_003EMAJOR_VERSION;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static int MAJOR_VERSION
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMAJOR_VERSION;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 160, 104, 135, 98, 104, 137, 109, 108, 54,
		166, 162, 103
	})]
	public virtual string[] getInterfaces()
	{
		if (cachedInterfaces != null)
		{
			return cachedInterfaces;
		}
		_ = null;
		string[] result;
		if (interfaces == null)
		{
			result = new string[0];
		}
		else
		{
			string[] array = new string[(nint)interfaces.LongLength];
			for (int i = 0; i < (nint)interfaces.LongLength; i++)
			{
				array[i] = constPool.getClassInfo(interfaces[i]);
			}
			result = array;
		}
		cachedInterfaces = result;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 27, 104, 151 })]
	public virtual string getSuperclass()
	{
		if (cachedSuperclass == null)
		{
			cachedSuperclass = constPool.getClassInfo(superClass);
		}
		return cachedSuperclass;
	}

	public virtual string getName()
	{
		return thisclassname;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[]
	{
		161, 139, 140, 108, 127, 1, 103, 104, 108, 130,
		127, 1, 103, 104, 108, 98
	})]
	public void getRefClasses(Map classnames)
	{
		constPool.renameClass(classnames);
		AttributeInfo.getRefClasses(attributes, classnames);
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			string descriptor = methodInfo.getDescriptor();
			Descriptor.rename(descriptor, classnames);
			AttributeInfo.getRefClasses(methodInfo.getAttributes(), classnames);
		}
		iterator = fields.iterator();
		while (iterator.hasNext())
		{
			FieldInfo fieldInfo = (FieldInfo)iterator.next();
			string descriptor = fieldInfo.getDescriptor();
			Descriptor.rename(descriptor, classnames);
			AttributeInfo.getRefClasses(fieldInfo.getAttributes(), classnames);
		}
	}

	public virtual ConstPool getConstPool()
	{
		return constPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 70, 104, 105 })]
	public ClassFile(DataInputStream @in)
	{
		read(@in);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		162, 207, 107, 108, 108, 108, 108, 108, 140, 104,
		132, 136, 103, 102, 46, 166, 108, 103, 102, 114,
		7, 230, 69, 113, 127, 2, 138, 113, 110
	})]
	public virtual void write(DataOutputStream @out)
	{
		@out.writeInt(-889275714);
		@out.writeShort(minor);
		@out.writeShort(major);
		constPool.write(@out);
		@out.writeShort(accessFlags);
		@out.writeShort(thisClass);
		@out.writeShort(superClass);
		int num = ((interfaces != null) ? interfaces.Length : 0);
		@out.writeShort(num);
		for (int i = 0; i < num; i++)
		{
			@out.writeShort(interfaces[i]);
		}
		num = fields.size();
		@out.writeShort(num);
		for (int i = 0; i < num; i++)
		{
			FieldInfo fieldInfo = (FieldInfo)fields.get(i);
			fieldInfo.write(@out);
		}
		@out.writeShort(methods.size());
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			methodInfo.write(@out);
		}
		@out.writeShort(attributes.size());
		AttributeInfo.writeAll(attributes, @out);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 20, 111 })]
	public virtual void setName(string name)
	{
		renameClass(thisclassname, name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 119, 127, 1, 110, 34, 130 })]
	public virtual AttributeInfo getAttribute(string name)
	{
		Iterator iterator = attributes.iterator();
		while (iterator.hasNext())
		{
			AttributeInfo attributeInfo = (AttributeInfo)iterator.next();
			if (java.lang.String.instancehelper_equals(attributeInfo.getName(), name))
			{
				return attributeInfo;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 143, 114, 109 })]
	public virtual void addAttribute(AttributeInfo info)
	{
		AttributeInfo.remove(attributes, info.getName());
		attributes.add(info);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[]
	{
		161, 113, 103, 37, 139, 99, 140, 140, 108, 127,
		1, 103, 109, 108, 130, 127, 2, 104, 110, 109,
		98
	})]
	public void renameClass(Map classnames)
	{
		string text = (string)classnames.get(Descriptor.toJvmName(thisclassname));
		if (text != null)
		{
			thisclassname = Descriptor.toJavaName(text);
		}
		constPool.renameClass(classnames);
		AttributeInfo.renameClass(attributes, classnames);
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			string descriptor = methodInfo.getDescriptor();
			methodInfo.setDescriptor(Descriptor.rename(descriptor, classnames));
			AttributeInfo.renameClass(methodInfo.getAttributes(), classnames);
		}
		iterator = fields.iterator();
		while (iterator.hasNext())
		{
			FieldInfo fieldInfo = (FieldInfo)iterator.next();
			string descriptor = fieldInfo.getDescriptor();
			fieldInfo.setDescriptor(Descriptor.rename(descriptor, classnames));
			AttributeInfo.renameClass(fieldInfo.getAttributes(), classnames);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 79, 105, 129, 110, 135, 104, 104, 141, 109,
		127, 1, 103, 110, 109, 130, 127, 1, 103, 110,
		109, 98
	})]
	public void renameClass(string oldname, string newname)
	{
		if (!java.lang.String.instancehelper_equals(oldname, newname))
		{
			if (java.lang.String.instancehelper_equals(oldname, thisclassname))
			{
				thisclassname = newname;
			}
			oldname = Descriptor.toJvmName(oldname);
			newname = Descriptor.toJvmName(newname);
			constPool.renameClass(oldname, newname);
			AttributeInfo.renameClass(attributes, oldname, newname);
			Iterator iterator = methods.iterator();
			while (iterator.hasNext())
			{
				MethodInfo methodInfo = (MethodInfo)iterator.next();
				string descriptor = methodInfo.getDescriptor();
				methodInfo.setDescriptor(Descriptor.rename(descriptor, oldname, newname));
				AttributeInfo.renameClass(methodInfo.getAttributes(), oldname, newname);
			}
			iterator = fields.iterator();
			while (iterator.hasNext())
			{
				FieldInfo fieldInfo = (FieldInfo)iterator.next();
				string descriptor = fieldInfo.getDescriptor();
				fieldInfo.setDescriptor(Descriptor.rename(descriptor, oldname, newname));
				AttributeInfo.renameClass(fieldInfo.getAttributes(), oldname, newname);
			}
		}
	}

	public virtual int getAccessFlags()
	{
		return accessFlags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 250, 102, 107, 99, 130, 103, 103, 102, 111,
		10, 198
	})]
	public virtual int getInnerAccessFlags()
	{
		InnerClassesAttribute innerClassesAttribute = (InnerClassesAttribute)getAttribute("InnerClasses");
		if (innerClassesAttribute == null)
		{
			return -1;
		}
		string name = getName();
		int num = innerClassesAttribute.tableLength();
		for (int i = 0; i < num; i++)
		{
			if (java.lang.String.instancehelper_equals(name, innerClassesAttribute.innerClass(i)))
			{
				int result = innerClassesAttribute.accessFlags(i);
				_ = null;
				return result;
			}
		}
		return -1;
	}

	public virtual void setAccessFlags(int acc)
	{
		if ((acc & 0x200) == 0)
		{
			acc |= 0x20;
		}
		accessFlags = acc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[]
	{
		161, 50, 99, 167, 114, 127, 1, 217, 2, 97,
		140, 103
	})]
	public virtual void setSuperclass(string superclass)
	{
		if (superclass == null)
		{
			superclass = "java.lang.Object";
		}
		BadBytecode badBytecode;
		try
		{
			superClass = constPool.addClassInfo(superclass);
			Iterator iterator = methods.iterator();
			while (iterator.hasNext())
			{
				MethodInfo methodInfo = (MethodInfo)iterator.next();
				methodInfo.setSuperclass(superclass);
			}
		}
		catch (BadBytecode x)
		{
			badBytecode = ByteCodeHelper.MapException<BadBytecode>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0052;
		}
		cachedSuperclass = superclass;
		return;
		IL_0052:
		BadBytecode e = badBytecode;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 185, 103, 99, 109, 103, 54, 166 })]
	public virtual void setInterfaces(string[] nameList)
	{
		cachedInterfaces = null;
		if (nameList != null)
		{
			interfaces = new int[(nint)nameList.LongLength];
			for (int i = 0; i < (nint)nameList.LongLength; i++)
			{
				interfaces[i] = constPool.addClassInfo(nameList[i]);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 197, 103, 109, 104, 108, 171, 104, 105, 111,
		100, 135
	})]
	public virtual void addInterface(string name)
	{
		cachedInterfaces = null;
		int num = constPool.addClassInfo(name);
		if (interfaces == null)
		{
			interfaces = new int[1];
			interfaces[0] = num;
			return;
		}
		int num2 = interfaces.Length;
		int[] array = new int[num2 + 1];
		ByteCodeHelper.arraycopy_primitive_4(interfaces, 0, array, 0, num2);
		array[num2] = num;
		interfaces = array;
	}

	[IKVM.Attributes.Signature("()Ljava/util/List<Ljavassist/bytecode/FieldInfo;>;")]
	public virtual List getFields()
	{
		return fields;
	}

	[IKVM.Attributes.Signature("()Ljava/util/List<Ljavassist/bytecode/MethodInfo;>;")]
	public virtual List getMethods()
	{
		return methods;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.DuplicateMemberException" })]
	[LineNumberTable(new byte[] { 161, 228, 114, 109 })]
	public virtual void addField(FieldInfo finfo)
	{
		testExistingField(finfo.getName(), finfo.getDescriptor());
		fields.add(finfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.DuplicateMemberException" })]
	[LineNumberTable(new byte[] { 162, 34, 103, 109 })]
	public virtual void addMethod(MethodInfo minfo)
	{
		testExistingMethod(minfo);
		methods.add(minfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 159, 103, 102, 102, 102, 99, 105, 168, 102,
		102, 99, 105, 168, 102, 103, 100, 107, 169, 127,
		5, 138, 127, 5, 138, 103, 103
	})]
	public virtual void prune()
	{
		ConstPool constPool = compact0();
		ArrayList arrayList = new ArrayList();
		AttributeInfo attribute = getAttribute("RuntimeInvisibleAnnotations");
		if (attribute != null)
		{
			attribute = attribute.copy(constPool, null);
			((List)arrayList).add((object)attribute);
		}
		AttributeInfo attribute2 = getAttribute("RuntimeVisibleAnnotations");
		if (attribute2 != null)
		{
			attribute2 = attribute2.copy(constPool, null);
			((List)arrayList).add((object)attribute2);
		}
		AttributeInfo attribute3 = getAttribute("Signature");
		if (attribute3 != null)
		{
			attribute3 = attribute3.copy(constPool, null);
			((List)arrayList).add((object)attribute3);
		}
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			methodInfo.prune(constPool);
		}
		iterator = fields.iterator();
		while (iterator.hasNext())
		{
			FieldInfo fieldInfo = (FieldInfo)iterator.next();
			fieldInfo.prune(constPool);
		}
		attributes = arrayList;
		this.constPool = constPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 126, 103, 127, 1, 137, 127, 1, 137, 114,
		103
	})]
	public virtual void compact()
	{
		ConstPool constPool = compact0();
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			methodInfo.compact(constPool);
		}
		iterator = fields.iterator();
		while (iterator.hasNext())
		{
			FieldInfo fieldInfo = (FieldInfo)iterator.next();
			fieldInfo.compact(constPool);
		}
		attributes = AttributeInfo.copyAll(attributes, constPool);
		this.constPool = constPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(649)]
	public virtual MethodInfo getStaticInitializer()
	{
		MethodInfo method = getMethod("<clinit>");
		_ = null;
		return method;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 93, 130, 104, 107, 103, 108, 113, 99, 141,
		136, 103, 103, 107, 107, 135, 107, 114, 42, 134
	})]
	public ClassFile(bool isInterface, string classname, string superclass)
	{
		major = ___003C_003EMAJOR_VERSION;
		minor = 0;
		constPool = new ConstPool(classname);
		thisClass = constPool.getThisClassInfo();
		if (isInterface)
		{
			accessFlags = 1536;
		}
		else
		{
			accessFlags = 32;
		}
		initSuperclass(superclass);
		interfaces = null;
		fields = new ArrayList();
		methods = new ArrayList();
		thisclassname = classname;
		attributes = new ArrayList();
		attributes.add(new SourceFileAttribute(constPool, getSourcefileName(thisclassname)));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 12, 127, 1, 110, 34, 130 })]
	public virtual MethodInfo getMethod(string name)
	{
		Iterator iterator = methods.iterator();
		while (iterator.hasNext())
		{
			MethodInfo methodInfo = (MethodInfo)iterator.next();
			if (java.lang.String.instancehelper_equals(methodInfo.getName(), name))
			{
				return methodInfo;
			}
		}
		return null;
	}

	public virtual int getSuperclassId()
	{
		return superClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		162, 162, 103, 104, 159, 11, 108, 108, 108, 108,
		108, 113, 108, 103, 99, 137, 108, 102, 46, 198,
		103, 103, 107, 102, 45, 166, 103, 107, 102, 45,
		166, 107, 103, 102, 45, 166, 119
	})]
	private void read(DataInputStream P_0)
	{
		int num = P_0.readInt();
		if (num != -889275714)
		{
			string message = new StringBuilder().append("bad magic number: ").append(Integer.toHexString(num)).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IOException(message);
		}
		minor = P_0.readUnsignedShort();
		major = P_0.readUnsignedShort();
		this.constPool = new ConstPool(P_0);
		accessFlags = P_0.readUnsignedShort();
		thisClass = P_0.readUnsignedShort();
		this.constPool.setThisClassInfo(thisClass);
		superClass = P_0.readUnsignedShort();
		int num2 = P_0.readUnsignedShort();
		if (num2 == 0)
		{
			interfaces = null;
		}
		else
		{
			interfaces = new int[num2];
			for (int i = 0; i < num2; i++)
			{
				interfaces[i] = P_0.readUnsignedShort();
			}
		}
		ConstPool constPool = this.constPool;
		num2 = P_0.readUnsignedShort();
		fields = new ArrayList();
		for (int i = 0; i < num2; i++)
		{
			addField2(new FieldInfo(constPool, P_0));
		}
		num2 = P_0.readUnsignedShort();
		methods = new ArrayList();
		for (int i = 0; i < num2; i++)
		{
			addMethod2(new MethodInfo(constPool, P_0));
		}
		attributes = new ArrayList();
		num2 = P_0.readUnsignedShort();
		for (int i = 0; i < num2; i++)
		{
			addAttribute(AttributeInfo.read(constPool, P_0));
		}
		thisclassname = this.constPool.getClassInfo(thisClass);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 106, 99, 114, 169, 118, 139 })]
	private void initSuperclass(string P_0)
	{
		if (P_0 != null)
		{
			superClass = constPool.addClassInfo(P_0);
			cachedSuperclass = P_0;
		}
		else
		{
			superClass = constPool.addClassInfo("java.lang.Object");
			cachedSuperclass = "java.lang.Object";
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(231)]
	private static string getSourcefileName(string P_0)
	{
		string result = new StringBuilder().append(java.lang.String.instancehelper_replaceAll(P_0, "^.*\\.", "")).append(".java").toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 138, 108, 108, 103, 99, 146, 104, 108, 118,
		11, 198
	})]
	private ConstPool compact0()
	{
		ConstPool constPool = new ConstPool(thisclassname);
		thisClass = constPool.getThisClassInfo();
		string superclass = getSuperclass();
		if (superclass != null)
		{
			superClass = constPool.addClassInfo(getSuperclass());
		}
		if (interfaces != null)
		{
			for (int i = 0; i < (nint)interfaces.LongLength; i++)
			{
				interfaces[i] = constPool.addClassInfo(this.constPool.getClassInfo(interfaces[i]));
			}
		}
		return constPool;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.DuplicateMemberException" })]
	[LineNumberTable(new byte[] { 161, 246, 127, 1, 110, 63, 6, 130 })]
	private void testExistingField(string P_0, string P_1)
	{
		Iterator iterator = fields.iterator();
		while (iterator.hasNext())
		{
			FieldInfo fieldInfo = (FieldInfo)iterator.next();
			if (java.lang.String.instancehelper_equals(fieldInfo.getName(), P_0))
			{
				string msg = new StringBuilder().append("duplicate field: ").append(P_0).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new DuplicateMemberException(msg);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.bytecode.DuplicateMemberException" })]
	[LineNumberTable(new byte[] { 162, 53, 103, 103, 109, 104, 118, 127, 1, 122 })]
	private void testExistingMethod(MethodInfo P_0)
	{
		string name = P_0.getName();
		string descriptor = P_0.getDescriptor();
		ListIterator listIterator = methods.listIterator(0);
		while (listIterator.hasNext())
		{
			if (isDuplicated(P_0, name, descriptor, (MethodInfo)listIterator.next(), listIterator))
			{
				string msg = new StringBuilder().append("duplicate method: ").append(name).append(" in ")
					.append(getName())
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new DuplicateMemberException(msg);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/MethodInfo;Ljava/lang/String;Ljava/lang/String;Ljavassist/bytecode/MethodInfo;Ljava/util/ListIterator<Ljavassist/bytecode/MethodInfo;>;)Z")]
	[LineNumberTable(new byte[]
	{
		162, 66, 110, 130, 103, 105, 130, 105, 104, 162,
		103, 130
	})]
	private static bool isDuplicated(MethodInfo P_0, string P_1, string P_2, MethodInfo P_3, ListIterator P_4)
	{
		if (!java.lang.String.instancehelper_equals(P_3.getName(), P_1))
		{
			return false;
		}
		string descriptor = P_3.getDescriptor();
		if (!Descriptor.eqParamTypes(descriptor, P_2))
		{
			return false;
		}
		if (java.lang.String.instancehelper_equals(descriptor, P_2))
		{
			if (notBridgeMethod(P_3))
			{
				return true;
			}
			P_4.remove();
			return false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(714)]
	private static bool notBridgeMethod(MethodInfo P_0)
	{
		return ((P_0.getAccessFlags() & 0x40) == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 241, 109 })]
	public void addField2(FieldInfo finfo)
	{
		fields.add(finfo);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 47, 109 })]
	public void addMethod2(MethodInfo minfo)
	{
		methods.add(minfo);
	}

	public virtual bool isInterface()
	{
		return (((uint)accessFlags & 0x200u) != 0) ? true : false;
	}

	public virtual bool isFinal()
	{
		return (((uint)accessFlags & 0x10u) != 0) ? true : false;
	}

	public virtual bool isAbstract()
	{
		return (((uint)accessFlags & 0x400u) != 0) ? true : false;
	}

	[IKVM.Attributes.Signature("()Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	public virtual List getAttributes()
	{
		return attributes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(759)]
	public virtual AttributeInfo removeAttribute(string name)
	{
		AttributeInfo result = AttributeInfo.remove(attributes, name);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 153, 102, 107, 99, 98 })]
	public virtual string getSourceFile()
	{
		SourceFileAttribute sourceFileAttribute = (SourceFileAttribute)getAttribute("SourceFile");
		if (sourceFileAttribute == null)
		{
			return null;
		}
		string fileName = sourceFileAttribute.getFileName();
		_ = null;
		return fileName;
	}

	public virtual int getMajorVersion()
	{
		return major;
	}

	public virtual void setMajorVersion(int major)
	{
		this.major = major;
	}

	public virtual int getMinorVersion()
	{
		return minor;
	}

	public virtual void setMinorVersion(int minor)
	{
		this.minor = minor;
	}

	public virtual void setVersionToJava5()
	{
		major = 49;
		minor = 0;
	}

	[LineNumberTable(new byte[]
	{
		110, 131, 112, 99, 112, 99, 123, 99, 112, 99,
		112, 99, 127, 4, 99, 127, 6, 148, 99, 102
	})]
	static ClassFile()
	{
		int __003C_003EMAJOR_VERSION = 47;
		try
		{
			Class.forName("java.lang.StringBuilder", ClassFile.___003CGetCallerID_003E());
			__003C_003EMAJOR_VERSION = 49;
			Class.forName("java.util.zip.DeflaterInputStream", ClassFile.___003CGetCallerID_003E());
			__003C_003EMAJOR_VERSION = 50;
			Class.forName("java.lang.invoke.CallSite", false, ClassLoader.getSystemClassLoader(ClassFile.___003CGetCallerID_003E()), ClassFile.___003CGetCallerID_003E());
			__003C_003EMAJOR_VERSION = 51;
			Class.forName("java.util.function.Function", ClassFile.___003CGetCallerID_003E());
			__003C_003EMAJOR_VERSION = 52;
			Class.forName("java.lang.Module", ClassFile.___003CGetCallerID_003E());
			__003C_003EMAJOR_VERSION = 53;
			ClassLiteral<List>.Value.getMethod("copyOf", new Class[1] { ClassLiteral<Collection>.Value }, ClassFile.___003CGetCallerID_003E());
			__003C_003EMAJOR_VERSION = 54;
			Class.forName("java.util.Optional", ClassFile.___003CGetCallerID_003E()).getMethod("isEmpty", new Class[0], ClassFile.___003CGetCallerID_003E());
			__003C_003EMAJOR_VERSION = 55;
		}
		catch (System.Exception x)
		{
			ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
			goto IL_00c9;
		}
		goto IL_00cf;
		IL_00c9:
		_ = null;
		goto IL_00cf;
		IL_00cf:
		___003C_003EMAJOR_VERSION = __003C_003EMAJOR_VERSION;
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
