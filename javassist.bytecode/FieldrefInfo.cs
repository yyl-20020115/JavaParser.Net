using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class FieldrefInfo : MemberrefInfo
{
	internal const int tag = 9;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 149, 107 })]
	public FieldrefInfo(int P_0, int P_1, int P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 166, 155, 106 })]
	public FieldrefInfo(DataInputStream P_0, int P_1)
		: base(P_0, P_1)
	{
	}

	public override int getTag()
	{
		return 9;
	}

	public override string getTagName()
	{
		return "Field";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1817)]
	protected internal override int copy2(ConstPool P_0, int P_1, int P_2)
	{
		int result = P_0.addFieldrefInfo(P_1, P_2);
		_ = null;
		return result;
	}
}
