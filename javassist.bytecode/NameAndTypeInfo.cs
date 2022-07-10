using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class NameAndTypeInfo : ConstInfo
{
	internal const int tag = 12;

	internal int memberName;

	internal int typeDescriptor;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 248, 105, 103, 103 })]
	public NameAndTypeInfo(int P_0, int P_1, int P_2)
		: base(P_2)
	{
		memberName = P_0;
		typeDescriptor = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		165,
		byte.MaxValue,
		105,
		108,
		108
	})]
	public NameAndTypeInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		memberName = P_0.readUnsignedShort();
		typeDescriptor = P_0.readUnsignedShort();
	}

	public override int hashCode()
	{
		return (memberName << 16) ^ typeDescriptor;
	}

	[LineNumberTable(new byte[] { 166, 10, 104, 103, 191, 2 })]
	public override bool equals(object P_0)
	{
		if (P_0 is NameAndTypeInfo)
		{
			NameAndTypeInfo nameAndTypeInfo = (NameAndTypeInfo)P_0;
			return (nameAndTypeInfo.memberName == memberName && nameAndTypeInfo.typeDescriptor == typeDescriptor) ? true : false;
		}
		return false;
	}

	public override int getTag()
	{
		return 12;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/lang/String;Ljava/lang/String;Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;)V")]
	[LineNumberTable(new byte[] { 166, 25, 109, 105, 100, 100, 143, 105, 109, 138 })]
	public override void renameClass(ConstPool P_0, string P_1, string P_2, Map P_3)
	{
		string utf8Info = P_0.getUtf8Info(typeDescriptor);
		string text = Descriptor.rename(utf8Info, P_1, P_2);
		if ((object)utf8Info != text)
		{
			if (P_3 == null)
			{
				typeDescriptor = P_0.addUtf8Info(text);
				return;
			}
			P_3.remove(this);
			typeDescriptor = P_0.addUtf8Info(text);
			P_3.put(this, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;Ljava/util/Map<Ljavassist/bytecode/ConstInfo;Ljavassist/bytecode/ConstInfo;>;)V")]
	[LineNumberTable(new byte[] { 166, 41, 109, 104, 100, 99, 143, 104, 109, 137 })]
	public override void renameClass(ConstPool P_0, Map P_1, Map P_2)
	{
		string utf8Info = P_0.getUtf8Info(typeDescriptor);
		string text = Descriptor.rename(utf8Info, P_1);
		if ((object)utf8Info != text)
		{
			if (P_2 == null)
			{
				typeDescriptor = P_0.addUtf8Info(text);
				return;
			}
			P_2.remove(this);
			typeDescriptor = P_0.addUtf8Info(text);
			P_2.put(this, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(new byte[] { 166, 56, 109, 109, 104, 106, 37 })]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		string utf8Info = P_0.getUtf8Info(memberName);
		string utf8Info2 = P_0.getUtf8Info(typeDescriptor);
		utf8Info2 = Descriptor.rename(utf8Info2, P_2);
		int result = P_1.addNameAndTypeInfo(P_1.addUtf8Info(utf8Info), P_1.addUtf8Info(utf8Info2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 166, 65, 104, 108, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(12);
		P_0.writeShort(memberName);
		P_0.writeShort(typeDescriptor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 72, 107, 108, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("NameAndType #");
		P_0.print(memberName);
		P_0.print(", type #");
		P_0.println(typeDescriptor);
	}
}
