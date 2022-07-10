using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

public sealed class FieldInfo : Object
{
	internal ConstPool constPool;

	internal int accessFlags;

	internal int name;

	internal string cachedName;

	internal string cachedType;

	internal int descriptor;

	[IKVM.Attributes.Signature("Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	internal List attribute;

	public virtual int getAccessFlags()
	{
		return accessFlags;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 150, 104, 139, 114, 109 })]
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
	[LineNumberTable(new byte[] { 95, 104, 151 })]
	public virtual string getName()
	{
		if (cachedName == null)
		{
			cachedName = constPool.getUtf8Info(name);
		}
		return cachedName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(183)]
	public virtual string getDescriptor()
	{
		string utf8Info = constPool.getUtf8Info(descriptor);
		_ = null;
		return utf8Info;
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
	[IKVM.Attributes.Signature("()Ljava/util/List<Ljavassist/bytecode/AttributeInfo;>;")]
	[LineNumberTable(new byte[] { 160, 110, 104, 139 })]
	public virtual List getAttributes()
	{
		if (attribute == null)
		{
			attribute = new ArrayList();
		}
		return attribute;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 105, 109, 103, 109 })]
	public FieldInfo(ConstPool cp, string fieldName, string desc)
		: this(cp)
	{
		name = cp.addUtf8Info(fieldName);
		cachedName = fieldName;
		descriptor = cp.addUtf8Info(desc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 105, 114, 103 })]
	public virtual void setName(string newName)
	{
		name = constPool.addUtf8Info(newName);
		cachedName = newName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(243)]
	public virtual AttributeInfo getAttribute(string name)
	{
		AttributeInfo result = AttributeInfo.lookup(attribute, name);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 78, 110, 114 })]
	public virtual void setDescriptor(string desc)
	{
		if (!String.instancehelper_equals(desc, getDescriptor()))
		{
			descriptor = constPool.addUtf8Info(desc);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 89, 106, 130, 102, 107, 99, 98 })]
	public virtual int getConstantValue()
	{
		if ((accessFlags & 8) == 0)
		{
			return 0;
		}
		ConstantAttribute constantAttribute = (ConstantAttribute)getAttribute("ConstantValue");
		if (constantAttribute == null)
		{
			return 0;
		}
		int constantValue = constantAttribute.getConstantValue();
		_ = null;
		return constantValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 42, 114, 114, 114, 103 })]
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
		49, 102, 102, 102, 99, 105, 168, 102, 102, 99,
		105, 168, 102, 102, 99, 105, 168, 104, 100, 113,
		175, 103, 114, 114, 103
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
		AttributeInfo attributeInfo3 = getAttribute("Signature");
		if (attributeInfo3 != null)
		{
			attributeInfo3 = attributeInfo3.copy(P_0, null);
			((List)arrayList).add((object)attributeInfo3);
		}
		int constantValue = getConstantValue();
		if (constantValue != 0)
		{
			constantValue = constPool.copy(constantValue, P_0, null);
			((List)arrayList).add((object)new ConstantAttribute(P_0, constantValue));
		}
		attribute = arrayList;
		name = P_0.addUtf8Info(getName());
		descriptor = P_0.addUtf8Info(getDescriptor());
		constPool = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 21, 105, 105 })]
	internal FieldInfo(ConstPool P_0, DataInputStream P_1)
		: this(P_0)
	{
		read(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 168, 108, 108, 108, 104, 137, 113, 142 })]
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
	[LineNumberTable(new byte[] { 159, 190, 104, 103, 103, 103 })]
	private FieldInfo(ConstPool P_0)
	{
		constPool = P_0;
		accessFlags = 0;
		attribute = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 158, 108, 108, 108, 103, 107, 102, 56, 134 })]
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
	[LineNumberTable(80)]
	public override string toString()
	{
		string result = new StringBuilder().append(getName()).append(" ").append(getDescriptor())
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(254)]
	public virtual AttributeInfo removeAttribute(string name)
	{
		AttributeInfo result = AttributeInfo.remove(attribute, name);
		_ = null;
		return result;
	}
}
