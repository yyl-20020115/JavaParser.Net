using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class MethodrefInfo : MemberrefInfo
{
	internal const int tag = 10;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 177, 107 })]
	public MethodrefInfo(int P_0, int P_1, int P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 166, 183, 106 })]
	public MethodrefInfo(DataInputStream P_0, int P_1)
		: base(P_0, P_1)
	{
	}

	public override int getTag()
	{
		return 10;
	}

	public override string getTagName()
	{
		return "Method";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1845)]
	protected internal override int copy2(ConstPool P_0, int P_1, int P_2)
	{
		int result = P_0.addMethodrefInfo(P_1, P_2);
		_ = null;
		return result;
	}
}
