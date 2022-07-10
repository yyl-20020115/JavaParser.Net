using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class DynamicInfo : ConstInfo
{
	internal const int tag = 17;

	internal int bootstrap;

	internal int nameAndType;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 168, 237, 105, 103, 103 })]
	public DynamicInfo(int P_0, int P_1, int P_2)
		: base(P_2)
	{
		bootstrap = P_0;
		nameAndType = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 168, 243, 105, 108, 108 })]
	public DynamicInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		bootstrap = P_0.readUnsignedShort();
		nameAndType = P_0.readUnsignedShort();
	}

	public override int hashCode()
	{
		return (bootstrap << 16) ^ nameAndType;
	}

	[LineNumberTable(new byte[]
	{
		168,
		byte.MaxValue,
		104,
		103,
		159,
		2
	})]
	public override bool equals(object P_0)
	{
		if (P_0 is DynamicInfo)
		{
			DynamicInfo dynamicInfo = (DynamicInfo)P_0;
			return (dynamicInfo.bootstrap == bootstrap && dynamicInfo.nameAndType == nameAndType) ? true : false;
		}
		return false;
	}

	public override int getTag()
	{
		return 17;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(2431)]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addDynamicInfo(bootstrap, P_0.getItem(nameAndType).copy(P_0, P_1, P_2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 169, 18, 104, 108, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(17);
		P_0.writeShort(bootstrap);
		P_0.writeShort(nameAndType);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 169, 25, 107, 108, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("Dynamic #");
		P_0.print(bootstrap);
		P_0.print(", name&type #");
		P_0.println(nameAndType);
	}
}
