using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class IntegerInfo : ConstInfo
{
	internal const int tag = 3;

	internal int value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 28, 105, 103 })]
	public IntegerInfo(int P_0, int P_1)
		: base(P_1)
	{
		value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 34, 105, 108 })]
	public IntegerInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		value = P_0.readInt();
	}

	public override int hashCode()
	{
		return value;
	}

	[LineNumberTable(1950)]
	public override bool equals(object P_0)
	{
		return (P_0 is IntegerInfo && ((IntegerInfo)P_0).value == value) ? true : false;
	}

	public override int getTag()
	{
		return 3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(1959)]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addIntegerInfo(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 59, 103, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(3);
		P_0.writeInt(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 66, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("Integer ");
		P_0.println(value);
	}
}
