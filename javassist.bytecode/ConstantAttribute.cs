using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class ConstantAttribute : AttributeInfo
{
	public const string tag = "ConstantValue";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 110, 103, 103, 101, 105 })]
	public ConstantAttribute(ConstPool cp, int index)
		: base(cp, "ConstantValue")
	{
		set(new byte[2]
		{
			(byte)(sbyte)((uint)index >> 8),
			(byte)(sbyte)index
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 177, 107 })]
	internal ConstantAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	public virtual int getConstantValue()
	{
		int result = ByteArray.readU16bit(get(), 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 20, 148 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		int index = getConstPool().copy(getConstantValue(), newCp, classnames);
		ConstantAttribute result = new ConstantAttribute(newCp, index);
		_ = null;
		return result;
	}
}
