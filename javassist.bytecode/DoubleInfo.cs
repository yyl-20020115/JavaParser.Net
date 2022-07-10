using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class DoubleInfo : ConstInfo
{
	internal const int tag = 6;

	internal double value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 177, 105, 105 })]
	public DoubleInfo(double P_0, int P_1)
		: base(P_1)
	{
		value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 183, 105, 109 })]
	public DoubleInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		value = P_0.readDouble();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 189, 108 })]
	public override int hashCode()
	{
		long num = Double.doubleToLongBits(value);
		return (int)(num ^ (long)((ulong)num >> 32));
	}

	[LineNumberTable(2102)]
	public override bool equals(object P_0)
	{
		return (P_0 is DoubleInfo && ((DoubleInfo)P_0).value == value) ? true : false;
	}

	public override int getTag()
	{
		return 6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(2112)]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addDoubleInfo(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 212, 103, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(6);
		P_0.writeDouble(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 219, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("Double ");
		P_0.println(value);
	}
}
