using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

[IKVM.Attributes.SourceFile("ConstPool.java")]
internal class ConstInfoPadding : ConstInfo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1498)]
	public ConstInfoPadding(int P_0)
		: base(P_0)
	{
	}

	public override int getTag()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)I")]
	[LineNumberTable(1506)]
	public override int copy(ConstPool P_0, ConstPool P_1, Map P_2)
	{
		int result = P_1.addConstInfoPadding();
		_ = null;
		return result;
	}

	[Throws(new string[] { "java.io.IOException" })]
	public override void write(DataOutputStream P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 165, 121, 109 })]
	public override void print(PrintWriter P_0)
	{
		P_0.println("padding");
	}
}
