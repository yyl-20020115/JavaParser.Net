using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class LongInfo : ConstInfo
{
	internal const int tag = 5;

	internal long value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 128, 105, 103 })]
	public LongInfo(long P_0, int P_1)
		: base(P_1)
	{
		value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 134, 105, 108 })]
	public LongInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		value = P_0.readLong();
	}

	public override int hashCode()
	{
		return (int)(value ^ (long)((ulong)value >> 32));
	}

	[LineNumberTable(2049)]
	public override bool equals(object P_0)
	{
		return (P_0 is LongInfo && ((LongInfo)P_0).value == value) ? true : false;
	}

	public override int getTag()
	{
		return 5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(2058)]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addLongInfo(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 158, 103, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(5);
		P_0.writeLong(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 165, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("Long ");
		P_0.println(value);
	}
}
