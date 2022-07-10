using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class StringInfo : ConstInfo
{
	internal const int tag = 8;

	internal int @string;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 234, 105, 103 })]
	public StringInfo(int P_0, int P_1)
		: base(P_1)
	{
		@string = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 166, 240, 105, 108 })]
	public StringInfo(DataInputStream P_0, int P_1)
		: base(P_1)
	{
		@string = P_0.readUnsignedShort();
	}

	public override int hashCode()
	{
		return @string;
	}

	[LineNumberTable(1900)]
	public override bool equals(object P_0)
	{
		return (P_0 is StringInfo && ((StringInfo)P_0).@string == @string) ? true : false;
	}

	public override int getTag()
	{
		return 8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(1909)]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addStringInfo(P_0.getUtf8Info(@string));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 167, 9, 103, 110 })]
	public override void write(DataOutputStream P_0)
	{
		P_0.writeByte(8);
		P_0.writeShort(@string);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 167, 16, 107, 110 })]
	public override void print(PrintWriter P_0)
	{
		P_0.print("String #");
		P_0.println(@string);
	}
}
