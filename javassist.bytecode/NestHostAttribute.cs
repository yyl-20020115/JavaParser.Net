using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class NestHostAttribute : AttributeInfo
{
	public const string tag = "NestHost";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 178, 107 })]
	internal NestHostAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 182, 116, 111 })]
	private NestHostAttribute(ConstPool P_0, int P_1)
		: base(P_0, "NestHost", new byte[2])
	{
		ByteArray.write16bit(P_1, get(), 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 4, 109, 111 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		int n = ByteArray.readU16bit(get(), 0);
		int num = getConstPool().copy(n, newCp, classnames);
		NestHostAttribute result = new NestHostAttribute(newCp, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	public virtual int hostClassIndex()
	{
		int result = ByteArray.readU16bit(info, 0);
		_ = null;
		return result;
	}
}
