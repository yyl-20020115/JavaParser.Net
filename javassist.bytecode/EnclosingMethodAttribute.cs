using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class EnclosingMethodAttribute : AttributeInfo
{
	public const string tag = "EnclosingMethod";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	public virtual string className()
	{
		string classInfo = getConstPool().getClassInfo(classIndex());
		_ = null;
		return classInfo;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 55, 103, 103, 99, 102, 104 })]
	public virtual string methodName()
	{
		ConstPool constPool = getConstPool();
		int num = methodIndex();
		if (num == 0)
		{
			return "<clinit>";
		}
		int nameAndTypeName = constPool.getNameAndTypeName(num);
		string utf8Info = constPool.getUtf8Info(nameAndTypeName);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 67, 103, 103, 104 })]
	public virtual string methodDescriptor()
	{
		ConstPool constPool = getConstPool();
		int index = methodIndex();
		int nameAndTypeDescriptor = constPool.getNameAndTypeDescriptor(index);
		string utf8Info = constPool.getUtf8Info(nameAndTypeDescriptor);
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 177, 107 })]
	internal EnclosingMethodAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(82)]
	public virtual int classIndex()
	{
		int result = ByteArray.readU16bit(get(), 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	public virtual int methodIndex()
	{
		int result = ByteArray.readU16bit(get(), 2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 17, 110, 104, 98, 103, 103, 101, 103, 101, 105 })]
	public EnclosingMethodAttribute(ConstPool cp, string className)
		: base(cp, "EnclosingMethod")
	{
		int num = cp.addClassInfo(className);
		int num2 = 0;
		set(new byte[4]
		{
			(byte)(sbyte)((uint)num >> 8),
			(byte)(sbyte)num,
			(byte)(sbyte)((uint)num2 >> 8),
			(byte)(sbyte)num2
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 190, 110, 104, 106, 103, 103, 101, 103, 101,
		105
	})]
	public EnclosingMethodAttribute(ConstPool cp, string className, string methodName, string methodDesc)
		: base(cp, "EnclosingMethod")
	{
		int num = cp.addClassInfo(className);
		int num2 = cp.addNameAndTypeInfo(methodName, methodDesc);
		set(new byte[4]
		{
			(byte)(sbyte)((uint)num >> 8),
			(byte)(sbyte)num,
			(byte)(sbyte)((uint)num2 >> 8),
			(byte)(sbyte)num2
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 83, 104, 111, 104, 50 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		if (methodIndex() == 0)
		{
			EnclosingMethodAttribute result = new EnclosingMethodAttribute(newCp, className());
			_ = null;
			return result;
		}
		EnclosingMethodAttribute result2 = new EnclosingMethodAttribute(newCp, className(), methodName(), methodDescriptor());
		_ = null;
		return result2;
	}
}
