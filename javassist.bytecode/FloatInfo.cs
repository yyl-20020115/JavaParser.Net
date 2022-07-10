using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class FloatInfo : ConstInfo
{
	internal const int tag = 4;

	internal float value;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 78, 105, 104 })]
	public FloatInfo(float P_0, int P_1)
		: base(P_1)
	{
		value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 84, 105, 108 })]
	public FloatInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		value = P_0.readFloat();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1995)]
	public override int hashCode()
	{
		int result = Float.floatToIntBits(value);
		_ = null;
		return result;
	}

	[LineNumberTable(2000)]
	public override bool equals(object P_0)
	{
		return (P_0 is FloatInfo && ((FloatInfo)P_0).value == value) ? true : false;
	}

	public override int getTag()
	{
		return 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(2009)]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addFloatInfo(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 109, 103, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(4);
		P_0.writeFloat(value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 116, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("Float ");
		P_0.println(value);
	}
}
