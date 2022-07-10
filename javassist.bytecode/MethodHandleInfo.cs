using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class MethodHandleInfo : ConstInfo
{
	internal const int tag = 15;

	internal int refKind;

	internal int refIndex;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 168, 28, 105, 103, 103 })]
	public MethodHandleInfo(int P_0, int P_1, int P_2)
		: base(P_2)
	{
		refKind = P_0;
		refIndex = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 168, 36, 105, 108, 108 })]
	public MethodHandleInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		refKind = P_0.readUnsignedByte();
		refIndex = P_0.readUnsignedShort();
	}

	public override int hashCode()
	{
		return (refKind << 16) ^ refIndex;
	}

	[LineNumberTable(new byte[] { 168, 47, 104, 103, 159, 2 })]
	public override bool equals(object P_0)
	{
		if (P_0 is MethodHandleInfo)
		{
			MethodHandleInfo methodHandleInfo = (MethodHandleInfo)P_0;
			return (methodHandleInfo.refKind == refKind && methodHandleInfo.refIndex == refIndex) ? true : false;
		}
		return false;
	}

	public override int getTag()
	{
		return 15;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(new byte[] { 168, 61, 110, 45 })]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addMethodHandleInfo(refKind, P_0.getItem(refIndex).copy(P_0, P_1, P_2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 168, 68, 104, 108, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(15);
		P_0.writeByte(refKind);
		P_0.writeShort(refIndex);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 168, 75, 107, 108, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("MethodHandle #");
		P_0.print(refKind);
		P_0.print(", index #");
		P_0.println(refIndex);
	}
}
