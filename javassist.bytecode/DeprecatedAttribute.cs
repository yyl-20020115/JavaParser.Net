using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class DeprecatedAttribute : AttributeInfo
{
	public const string tag = "Deprecated";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 177, 107 })]
	internal DeprecatedAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 186, 116 })]
	public DeprecatedAttribute(ConstPool cp)
		: base(cp, "Deprecated", new byte[0])
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(55)]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		DeprecatedAttribute result = new DeprecatedAttribute(newCp);
		_ = null;
		return result;
	}
}
