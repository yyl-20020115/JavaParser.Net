using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class SourceFileAttribute : AttributeInfo
{
	public const string tag = "SourceFile";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 177, 107 })]
	internal SourceFileAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 110, 104, 103, 103, 101, 105 })]
	public SourceFileAttribute(ConstPool cp, string filename)
		: base(cp, "SourceFile")
	{
		int num = cp.addUtf8Info(filename);
		set(new byte[2]
		{
			(byte)(sbyte)((uint)num >> 8),
			(byte)(sbyte)num
		});
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	public virtual string getFileName()
	{
		string utf8Info = getConstPool().getUtf8Info(ByteArray.readU16bit(get(), 0));
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(70)]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		SourceFileAttribute result = new SourceFileAttribute(newCp, getFileName());
		_ = null;
		return result;
	}
}
