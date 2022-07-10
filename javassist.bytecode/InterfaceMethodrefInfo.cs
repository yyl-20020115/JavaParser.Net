using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class InterfaceMethodrefInfo : MemberrefInfo
{
	internal const int tag = 11;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 205, 107 })]
	public InterfaceMethodrefInfo(int P_0, int P_1, int P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 166, 211, 106 })]
	public InterfaceMethodrefInfo(DataInputStream P_0, int P_1)
		: base(P_0, P_1)
	{
	}

	public override int getTag()
	{
		return 11;
	}

	public override string getTagName()
	{
		return "Interface";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1873)]
	protected internal override int copy2(ConstPool P_0, int P_1, int P_2)
	{
		int result = P_0.addInterfaceMethodrefInfo(P_1, P_2);
		_ = null;
		return result;
	}
}
