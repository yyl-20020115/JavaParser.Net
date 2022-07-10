using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal abstract class MemberrefInfo : ConstInfo
{
	internal int classIndex;

	internal int nameAndTypeIndex;

	protected internal abstract int copy2(ConstPool P_0, int P_1, int P_2);

	public abstract string getTagName();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 86, 105, 103, 103 })]
	public MemberrefInfo(int P_0, int P_1, int P_2)
		: base(P_2)
	{
		classIndex = P_0;
		nameAndTypeIndex = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 166, 94, 105, 108, 108 })]
	public MemberrefInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		classIndex = P_0.readUnsignedShort();
		nameAndTypeIndex = P_0.readUnsignedShort();
	}

	public override int hashCode()
	{
		return (classIndex << 16) ^ nameAndTypeIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 104, 104, 103, 157, 17, 193 })]
	public override bool equals(object P_0)
	{
		if (P_0 is MemberrefInfo)
		{
			MemberrefInfo memberrefInfo = (MemberrefInfo)P_0;
			return (memberrefInfo.classIndex == classIndex && memberrefInfo.nameAndTypeIndex == nameAndTypeIndex && ((object)memberrefInfo).GetType() == ((object)this).GetType()) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(new byte[] { 166, 116, 117, 117 })]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int num = P_0.getItem(classIndex).copy(P_0, P_1, P_2);
		int num2 = P_0.getItem(nameAndTypeIndex).copy(P_0, P_1, P_2);
		int result = copy2(P_1, num, num2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 166, 126, 108, 108, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(getTag());
		P_0.writeShort(classIndex);
		P_0.writeShort(nameAndTypeIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 134, 127, 6, 108, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print(new StringBuilder().append(getTagName()).append(" #").toString());
		P_0.print(classIndex);
		P_0.print(", name&type #");
		P_0.println(nameAndTypeIndex);
	}
}
