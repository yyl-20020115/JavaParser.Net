using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public sealed class ConstPool : Object
{
	internal LongVector items;

	internal int numOfItems;

	internal int thisClassInfo;

	[IKVM.Attributes.Signature("Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;")]
	internal Map itemsCache;

	public const int CONST_Class = 7;

	public const int CONST_Fieldref = 9;

	public const int CONST_Methodref = 10;

	public const int CONST_InterfaceMethodref = 11;

	public const int CONST_String = 8;

	public const int CONST_Integer = 3;

	public const int CONST_Float = 4;

	public const int CONST_Long = 5;

	public const int CONST_Double = 6;

	public const int CONST_NameAndType = 12;

	public const int CONST_Utf8 = 1;

	public const int CONST_MethodHandle = 15;

	public const int CONST_MethodType = 16;

	public const int CONST_Dynamic = 17;

	public const int CONST_DynamicCallSite = 18;

	public const int CONST_InvokeDynamic = 18;

	public const int CONST_Module = 19;

	public const int CONST_Package = 20;

	internal static CtClass ___003C_003ETHIS;

	public const int REF_getField = 1;

	public const int REF_getStatic = 2;

	public const int REF_putField = 3;

	public const int REF_putStatic = 4;

	public const int REF_invokeVirtual = 5;

	public const int REF_invokeStatic = 6;

	public const int REF_invokeSpecial = 7;

	public const int REF_newInvokeSpecial = 8;

	public const int REF_invokeInterface = 9;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static CtClass THIS
	{
		[HideFromJava]
		get
		{
			return ___003C_003ETHIS;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1203)]
	public virtual int addUtf8Info(string utf8)
	{
		int result = addItem(new Utf8Info(utf8, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 88, 104, 103, 104, 239, 71 })]
	public virtual int addClassInfo(CtClass c)
	{
		if (c == ___003C_003ETHIS)
		{
			return thisClassInfo;
		}
		if (!c.isArray())
		{
			int result = addClassInfo(c.getName());
			_ = null;
			return result;
		}
		int result2 = addClassInfo(Descriptor.toJvmName(c));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(857)]
	public virtual int isConstructor(string classname, int index)
	{
		int result = isMember(classname, "<init>", index);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 48, 109 })]
	public virtual string getUtf8Info(int index)
	{
		Utf8Info utf8Info = (Utf8Info)getItem(index);
		return utf8Info.@string;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 123, 109, 99, 98, 103, 107, 99, 98 })]
	public virtual string getMethodrefType(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		if (memberrefInfo == null)
		{
			return null;
		}
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(memberrefInfo.nameAndTypeIndex);
		if (nameAndTypeInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(nameAndTypeInfo.typeDescriptor);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(257)]
	public virtual int getTag(int index)
	{
		int tag = getItem(index).getTag();
		_ = null;
		return tag;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 12, 109 })]
	public virtual long getLongInfo(int index)
	{
		LongInfo longInfo = (LongInfo)getItem(index);
		return longInfo.value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 0, 109 })]
	public virtual float getFloatInfo(int index)
	{
		FloatInfo floatInfo = (FloatInfo)getItem(index);
		return floatInfo.value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 24, 109 })]
	public virtual double getDoubleInfo(int index)
	{
		DoubleInfo doubleInfo = (DoubleInfo)getItem(index);
		return doubleInfo.value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 244, 109 })]
	public virtual int getIntegerInfo(int index)
	{
		IntegerInfo integerInfo = (IntegerInfo)getItem(index);
		return integerInfo.value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 36, 109 })]
	public virtual string getStringInfo(int index)
	{
		StringInfo stringInfo = (StringInfo)getItem(index);
		string utf8Info = getUtf8Info(stringInfo.@string);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 50, 116, 107, 135 })]
	public virtual int addDoubleInfo(double d)
	{
		int num = addItem(new DoubleInfo(d, numOfItems));
		if (num == numOfItems - 1)
		{
			addConstInfoPadding();
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1162)]
	public virtual int addFloatInfo(float f)
	{
		int result = addItem(new FloatInfo(f, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 35, 115, 107, 135 })]
	public virtual int addLongInfo(long l)
	{
		int num = addItem(new LongInfo(l, numOfItems));
		if (num == numOfItems - 1)
		{
			addConstInfoPadding();
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1151)]
	public virtual int addIntegerInfo(int i)
	{
		int result = addItem(new IntegerInfo(i, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 1, 104 })]
	public virtual int addStringInfo(string str)
	{
		int num = addUtf8Info(str);
		int result = addItem(new StringInfo(num, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(ILjavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(new byte[] { 163, 67, 99, 130, 104 })]
	public virtual int copy(int n, ConstPool dest, Map classnames)
	{
		if (n == 0)
		{
			return 0;
		}
		ConstInfo item = getItem(n);
		int result = item.copy(this, dest, classnames);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(226)]
	public virtual string getClassName()
	{
		string classInfo = getClassInfo(thisClassInfo);
		_ = null;
		return classInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 114, 109 })]
	public virtual int addClassInfo(string qname)
	{
		int num = addUtf8Info(Descriptor.toJvmName(qname));
		int result = addItem(new ClassInfo(num, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 159, 105 })]
	public virtual int addFieldrefInfo(int classInfo, string name, string type)
	{
		int nameAndTypeInfo = addNameAndTypeInfo(name, type);
		int result = addFieldrefInfo(classInfo, nameAndTypeInfo);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 226, 105 })]
	public virtual int addInterfaceMethodrefInfo(int classInfo, string name, string type)
	{
		int nameAndTypeInfo = addNameAndTypeInfo(name, type);
		int result = addInterfaceMethodrefInfo(classInfo, nameAndTypeInfo);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 191, 105 })]
	public virtual int addMethodrefInfo(int classInfo, string name, string type)
	{
		int nameAndTypeInfo = addNameAndTypeInfo(name, type);
		int result = addMethodrefInfo(classInfo, nameAndTypeInfo);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1011)]
	public virtual int addNameAndTypeInfo(string name, string type)
	{
		int result = addNameAndTypeInfo(addUtf8Info(name), addUtf8Info(type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1248)]
	public virtual int addInvokeDynamicInfo(int bootstrap, int nameAndType)
	{
		int result = addItem(new InvokeDynamicInfo(bootstrap, nameAndType, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 72, 104, 107, 103, 103, 104, 109 })]
	public ConstPool(string thisclass)
	{
		items = new LongVector();
		itemsCache = null;
		numOfItems = 0;
		addItem0(null);
		thisClassInfo = addClassInfo(thisclass);
	}

	public virtual int getThisClassInfo()
	{
		return thisClassInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 159, 109, 99, 98 })]
	public virtual string getClassInfo(int index)
	{
		ClassInfo classInfo = (ClassInfo)getItem(index);
		if (classInfo == null)
		{
			return null;
		}
		string result = Descriptor.toJavaName(getUtf8Info(classInfo.name));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 173, 103, 103, 102, 104, 15, 198 })]
	public virtual void renameClass(string oldName, string newName)
	{
		LongVector longVector = items;
		int num = numOfItems;
		for (int i = 1; i < num; i++)
		{
			ConstInfo constInfo = longVector.elementAt(i);
			constInfo.renameClass(this, oldName, newName, itemsCache);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[] { 164, 189, 103, 103, 102, 104, 14, 198 })]
	public virtual void renameClass(Map classnames)
	{
		LongVector longVector = items;
		int num = numOfItems;
		for (int i = 1; i < num; i++)
		{
			ConstInfo constInfo = longVector.elementAt(i);
			constInfo.renameClass(this, classnames, itemsCache);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 86, 104, 103, 167, 105 })]
	public ConstPool(DataInputStream @in)
	{
		itemsCache = null;
		thisClassInfo = 0;
		read(@in);
	}

	internal virtual void setThisClassInfo(int P_0)
	{
		thisClassInfo = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 165, 42, 108, 103, 103, 102, 45, 134 })]
	public virtual void write(DataOutputStream @out)
	{
		@out.writeShort(numOfItems);
		LongVector longVector = items;
		int num = numOfItems;
		for (int i = 1; i < num; i++)
		{
			longVector.elementAt(i).write(@out);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 200, 109, 99, 98, 103, 107, 99, 98 })]
	public virtual string getInterfaceMethodrefType(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		if (memberrefInfo == null)
		{
			return null;
		}
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(memberrefInfo.nameAndTypeIndex);
		if (nameAndTypeInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(nameAndTypeInfo.typeDescriptor);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 137, 109, 99, 98, 114, 99, 98 })]
	public virtual string getInvokeDynamicType(int index)
	{
		InvokeDynamicInfo invokeDynamicInfo = (InvokeDynamicInfo)getItem(index);
		if (invokeDynamicInfo == null)
		{
			return null;
		}
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(invokeDynamicInfo.nameAndType);
		if (nameAndTypeInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(nameAndTypeInfo.typeDescriptor);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 47, 109, 99, 98, 114, 99, 98 })]
	public virtual string getFieldrefType(int index)
	{
		FieldrefInfo fieldrefInfo = (FieldrefInfo)getItem(index);
		if (fieldrefInfo == null)
		{
			return null;
		}
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(fieldrefInfo.nameAndTypeIndex);
		if (nameAndTypeInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(nameAndTypeInfo.typeDescriptor);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 103, 109, 99, 98, 103, 107, 99, 98 })]
	public virtual string getMethodrefName(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		if (memberrefInfo == null)
		{
			return null;
		}
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(memberrefInfo.nameAndTypeIndex);
		if (nameAndTypeInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(nameAndTypeInfo.memberName);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 76, 109, 99, 98 })]
	public virtual string getMethodrefClassName(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		if (memberrefInfo == null)
		{
			return null;
		}
		string classInfo = getClassInfo(memberrefInfo.classIndex);
		_ = null;
		return classInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(957)]
	internal virtual int addConstInfoPadding()
	{
		int result = addItem0(new ConstInfoPadding(numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 37, 108 })]
	private int addItem0(ConstInfo P_0)
	{
		items.addElement(P_0);
		int num = numOfItems;
		numOfItems = num + 1;
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		164, 199, 135, 108, 103, 136, 104, 104, 104, 103,
		132, 98
	})]
	private void read(DataInputStream P_0)
	{
		int num = P_0.readUnsignedShort();
		items = new LongVector(num);
		numOfItems = 0;
		addItem0(null);
		while (true)
		{
			num += -1;
			if (num > 0)
			{
				int num2 = readOne(P_0);
				if (num2 == 5 || num2 == 6)
				{
					addConstInfoPadding();
					num += -1;
				}
				continue;
			}
			break;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(245)]
	internal virtual ConstInfo getItem(int P_0)
	{
		ConstInfo result = items.elementAt(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 252, 109, 116, 103, 107, 116, 167 })]
	public virtual int isMember(string classname, string membername, int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		if (String.instancehelper_equals(getClassInfo(memberrefInfo.classIndex), classname))
		{
			NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(memberrefInfo.nameAndTypeIndex);
			if (String.instancehelper_equals(getUtf8Info(nameAndTypeInfo.memberName), membername))
			{
				return nameAndTypeInfo.typeDescriptor;
			}
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/LongVector;)Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;")]
	[LineNumberTable(new byte[] { 164, 216, 102, 130, 108, 99, 98, 105, 130 })]
	private static Map makeItemsCache(LongVector P_0)
	{
		HashMap hashMap = new HashMap();
		int num = 1;
		while (true)
		{
			int num2 = num;
			num++;
			ConstInfo constInfo = P_0.elementAt(num2);
			if (constInfo == null)
			{
				break;
			}
			((Map)hashMap).put((object)constInfo, (object)constInfo);
		}
		return hashMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 43, 104, 145, 114, 99, 103, 108, 110 })]
	private int addItem(ConstInfo P_0)
	{
		if (itemsCache == null)
		{
			itemsCache = makeItemsCache(items);
		}
		ConstInfo constInfo = (ConstInfo)itemsCache.get(P_0);
		if (constInfo != null)
		{
			return constInfo.index;
		}
		items.addElement(P_0);
		itemsCache.put(P_0, P_0);
		int num = numOfItems;
		numOfItems = num + 1;
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1023)]
	public virtual int addNameAndTypeInfo(int name, int type)
	{
		int result = addItem(new NameAndTypeInfo(name, type, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1054)]
	public virtual int addFieldrefInfo(int classInfo, int nameAndTypeInfo)
	{
		int result = addItem(new FieldrefInfo(classInfo, nameAndTypeInfo, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1086)]
	public virtual int addMethodrefInfo(int classInfo, int nameAndTypeInfo)
	{
		int result = addItem(new MethodrefInfo(classInfo, nameAndTypeInfo, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1123)]
	public virtual int addInterfaceMethodrefInfo(int classInfo, int nameAndTypeInfo)
	{
		int result = addItem(new InterfaceMethodrefInfo(classInfo, nameAndTypeInfo, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		164, 231, 103, 159, 62, 109, 133, 109, 133, 109,
		133, 109, 133, 109, 133, 109, 133, 109, 133, 109,
		133, 109, 133, 109, 133, 109, 133, 109, 133, 109,
		133, 109, 130, 109, 130, 109, 130, 109, 130, 223,
		27, 104
	})]
	private int readOne(DataInputStream P_0)
	{
		int num = P_0.readUnsignedByte();
		ConstInfo constInfo;
		switch (num)
		{
		case 1:
			constInfo = new Utf8Info(P_0, numOfItems);
			break;
		case 3:
			constInfo = new IntegerInfo(P_0, numOfItems);
			break;
		case 4:
			constInfo = new FloatInfo(P_0, numOfItems);
			break;
		case 5:
			constInfo = new LongInfo(P_0, numOfItems);
			break;
		case 6:
			constInfo = new DoubleInfo(P_0, numOfItems);
			break;
		case 7:
			constInfo = new ClassInfo(P_0, numOfItems);
			break;
		case 8:
			constInfo = new StringInfo(P_0, numOfItems);
			break;
		case 9:
			constInfo = new FieldrefInfo(P_0, numOfItems);
			break;
		case 10:
			constInfo = new MethodrefInfo(P_0, numOfItems);
			break;
		case 11:
			constInfo = new InterfaceMethodrefInfo(P_0, numOfItems);
			break;
		case 12:
			constInfo = new NameAndTypeInfo(P_0, numOfItems);
			break;
		case 15:
			constInfo = new MethodHandleInfo(P_0, numOfItems);
			break;
		case 16:
			constInfo = new MethodTypeInfo(P_0, numOfItems);
			break;
		case 17:
			constInfo = new DynamicInfo(P_0, numOfItems);
			break;
		case 18:
			constInfo = new InvokeDynamicInfo(P_0, numOfItems);
			break;
		case 19:
			constInfo = new ModuleInfo(P_0, numOfItems);
			break;
		case 20:
			constInfo = new PackageInfo(P_0, numOfItems);
			break;
		default:
		{
			string message = new StringBuilder().append("invalid constant type: ").append(num).append(" at ")
				.append(numOfItems)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IOException(message);
		}
		}
		addItem0(constInfo);
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 62, 103, 102, 103, 107, 242, 61, 230, 69 })]
	public virtual void print(PrintWriter @out)
	{
		int num = numOfItems;
		for (int i = 1; i < num; i++)
		{
			@out.print(i);
			@out.print(" ");
			items.elementAt(i).print(@out);
		}
	}

	internal virtual void prune()
	{
		itemsCache = null;
	}

	public virtual int getSize()
	{
		return numOfItems;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 176, 109, 99, 98, 109, 107, 98 })]
	public virtual string getClassInfoByDescriptor(int index)
	{
		ClassInfo classInfo = (ClassInfo)getItem(index);
		if (classInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(classInfo.name);
		if (String.instancehelper_charAt(utf8Info, 0) == '[')
		{
			return utf8Info;
		}
		string result = Descriptor.of(utf8Info);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 192, 109 })]
	public virtual int getNameAndTypeName(int index)
	{
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(index);
		return nameAndTypeInfo.memberName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 203, 109 })]
	public virtual int getNameAndTypeDescriptor(int index)
	{
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(index);
		return nameAndTypeInfo.typeDescriptor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 218, 109 })]
	public virtual int getMemberClass(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		return memberrefInfo.classIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 233, 109 })]
	public virtual int getMemberNameAndType(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		return memberrefInfo.nameAndTypeIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 244, 109 })]
	public virtual int getFieldrefClass(int index)
	{
		FieldrefInfo fieldrefInfo = (FieldrefInfo)getItem(index);
		return fieldrefInfo.classIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 1, 109, 99, 98 })]
	public virtual string getFieldrefClassName(int index)
	{
		FieldrefInfo fieldrefInfo = (FieldrefInfo)getItem(index);
		if (fieldrefInfo == null)
		{
			return null;
		}
		string classInfo = getClassInfo(fieldrefInfo.classIndex);
		_ = null;
		return classInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 14, 109 })]
	public virtual int getFieldrefNameAndType(int index)
	{
		FieldrefInfo fieldrefInfo = (FieldrefInfo)getItem(index);
		return fieldrefInfo.nameAndTypeIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 28, 109, 99, 98, 114, 99, 98 })]
	public virtual string getFieldrefName(int index)
	{
		FieldrefInfo fieldrefInfo = (FieldrefInfo)getItem(index);
		if (fieldrefInfo == null)
		{
			return null;
		}
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(fieldrefInfo.nameAndTypeIndex);
		if (nameAndTypeInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(nameAndTypeInfo.memberName);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 63, 109 })]
	public virtual int getMethodrefClass(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		return memberrefInfo.classIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 89, 109 })]
	public virtual int getMethodrefNameAndType(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		return memberrefInfo.nameAndTypeIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 140, 109 })]
	public virtual int getInterfaceMethodrefClass(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		return memberrefInfo.classIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 153, 109 })]
	public virtual string getInterfaceMethodrefClassName(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		string classInfo = getClassInfo(memberrefInfo.classIndex);
		_ = null;
		return classInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 164, 109 })]
	public virtual int getInterfaceMethodrefNameAndType(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		return memberrefInfo.nameAndTypeIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 179, 109, 99, 98, 103, 107, 99, 98 })]
	public virtual string getInterfaceMethodrefName(int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		if (memberrefInfo == null)
		{
			return null;
		}
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(memberrefInfo.nameAndTypeIndex);
		if (nameAndTypeInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(nameAndTypeInfo.memberName);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 220, 104, 98, 104, 109, 104, 111, 104, 111,
		104, 111, 104, 141
	})]
	public virtual object getLdcValue(int index)
	{
		ConstInfo item = getItem(index);
		object result = null;
		if (item is StringInfo)
		{
			result = getStringInfo(index);
		}
		else if (item is FloatInfo)
		{
			result = Float.valueOf(getFloatInfo(index));
		}
		else if (item is IntegerInfo)
		{
			result = Integer.valueOf(getIntegerInfo(index));
		}
		else if (item is LongInfo)
		{
			result = Long.valueOf(getLongInfo(index));
		}
		else if (item is DoubleInfo)
		{
			result = Double.valueOf(getDoubleInfo(index));
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 70, 109 })]
	public virtual int getMethodHandleKind(int index)
	{
		MethodHandleInfo methodHandleInfo = (MethodHandleInfo)getItem(index);
		return methodHandleInfo.refKind;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 83, 109 })]
	public virtual int getMethodHandleIndex(int index)
	{
		MethodHandleInfo methodHandleInfo = (MethodHandleInfo)getItem(index);
		return methodHandleInfo.refIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 96, 109 })]
	public virtual int getMethodTypeInfo(int index)
	{
		MethodTypeInfo methodTypeInfo = (MethodTypeInfo)getItem(index);
		return methodTypeInfo.descriptor;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 109, 109 })]
	public virtual int getInvokeDynamicBootstrap(int index)
	{
		InvokeDynamicInfo invokeDynamicInfo = (InvokeDynamicInfo)getItem(index);
		return invokeDynamicInfo.bootstrap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 122, 109 })]
	public virtual int getInvokeDynamicNameAndType(int index)
	{
		InvokeDynamicInfo invokeDynamicInfo = (InvokeDynamicInfo)getItem(index);
		return invokeDynamicInfo.nameAndType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 155, 109 })]
	public virtual int getDynamicBootstrap(int index)
	{
		DynamicInfo dynamicInfo = (DynamicInfo)getItem(index);
		return dynamicInfo.bootstrap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 168, 109 })]
	public virtual int getDynamicNameAndType(int index)
	{
		DynamicInfo dynamicInfo = (DynamicInfo)getItem(index);
		return dynamicInfo.nameAndType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 183, 109, 99, 98, 114, 99, 98 })]
	public virtual string getDynamicType(int index)
	{
		DynamicInfo dynamicInfo = (DynamicInfo)getItem(index);
		if (dynamicInfo == null)
		{
			return null;
		}
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(dynamicInfo.nameAndType);
		if (nameAndTypeInfo == null)
		{
			return null;
		}
		string utf8Info = getUtf8Info(nameAndTypeInfo.typeDescriptor);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 201, 109 })]
	public virtual string getModuleInfo(int index)
	{
		ModuleInfo moduleInfo = (ModuleInfo)getItem(index);
		string utf8Info = getUtf8Info(moduleInfo.name);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 215, 109 })]
	public virtual string getPackageInfo(int index)
	{
		PackageInfo packageInfo = (PackageInfo)getItem(index);
		string utf8Info = getUtf8Info(packageInfo.name);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 26, 109, 103, 107, 123, 109, 111 })]
	public virtual string eqMember(string membername, string desc, int index)
	{
		MemberrefInfo memberrefInfo = (MemberrefInfo)getItem(index);
		NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)getItem(memberrefInfo.nameAndTypeIndex);
		if (String.instancehelper_equals(getUtf8Info(nameAndTypeInfo.memberName), membername) && String.instancehelper_equals(getUtf8Info(nameAndTypeInfo.typeDescriptor), desc))
		{
			string classInfo = getClassInfo(memberrefInfo.classIndex);
			_ = null;
			return classInfo;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1219)]
	public virtual int addMethodHandleInfo(int kind, int index)
	{
		int result = addItem(new MethodHandleInfo(kind, index, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1233)]
	public virtual int addMethodTypeInfo(int desc)
	{
		int result = addItem(new MethodTypeInfo(desc, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1260)]
	public virtual int addDynamicInfo(int bootstrap, int nameAndType)
	{
		int result = addItem(new DynamicInfo(bootstrap, nameAndType, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1271)]
	public virtual int addModuleInfo(int nameIndex)
	{
		int result = addItem(new ModuleInfo(nameIndex, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1282)]
	public virtual int addPackageInfo(int nameIndex)
	{
		int result = addItem(new PackageInfo(nameIndex, numOfItems));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/util/Set<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[]
	{
		164, 154, 102, 103, 103, 102, 111, 100, 233, 61,
		230, 69
	})]
	public virtual Set getClassNames()
	{
		HashSet hashSet = new HashSet();
		LongVector longVector = items;
		int num = numOfItems;
		for (int i = 1; i < num; i++)
		{
			string className = longVector.elementAt(i).getClassName(this);
			if (className != null)
			{
				((Set)hashSet).add((object)className);
			}
		}
		return hashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 54, 115 })]
	public virtual void print()
	{
		print(new PrintWriter(java.lang.System.@out, autoFlush: true));
	}
}
