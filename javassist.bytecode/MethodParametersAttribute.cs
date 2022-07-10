using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class MethodParametersAttribute : AttributeInfo
{
	public const string tag = "MethodParameters";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 161, 107 })]
	internal MethodParametersAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(56)]
	public new virtual int name(int i)
	{
		int result = ByteArray.readU16bit(info, i * 4 + 1);
		_ = null;
		return result;
	}

	[LineNumberTable(47)]
	public virtual int size()
	{
		return info[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public virtual int accessFlags(int i)
	{
		int result = ByteArray.readU16bit(info, i * 4 + 3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 173, 110, 108, 102, 103, 116, 14, 230, 69,
		105
	})]
	public MethodParametersAttribute(ConstPool cp, string[] names, int[] flags)
		: base(cp, "MethodParameters")
	{
		byte[] array = new byte[(nint)names.LongLength * 4 + 1];
		array[0] = (byte)names.Length;
		for (int i = 0; i < (nint)names.LongLength; i++)
		{
			ByteArray.write16bit(cp.addUtf8Info(names[i]), array, i * 4 + 1);
			ByteArray.write16bit(flags[i], array, i * 4 + 3);
		}
		set(array);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	public virtual string parameterName(int i)
	{
		string utf8Info = getConstPool().getUtf8Info(name(i));
		_ = null;
		return utf8Info;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[] { 35, 103, 103, 103, 103, 104, 114, 12, 232, 69 })]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		int num = size();
		ConstPool constPool = getConstPool();
		string[] array = new string[num];
		int[] array2 = new int[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = constPool.getUtf8Info(name(i));
			array2[i] = accessFlags(i);
		}
		MethodParametersAttribute result = new MethodParametersAttribute(newCp, array, array2);
		_ = null;
		return result;
	}
}
