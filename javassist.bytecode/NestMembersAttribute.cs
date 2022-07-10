using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.util;

namespace javassist.bytecode;

public class NestMembersAttribute : AttributeInfo
{
	public const string tag = "NestMembers";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 178, 107 })]
	internal NestMembersAttribute(ConstPool P_0, int P_1, DataInputStream P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 182, 111 })]
	private NestMembersAttribute(ConstPool P_0, byte[] P_1)
		: base(P_0, "NestMembers", P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("(Ljavassist/bytecode/ConstPool;Ljava/util/Map<Ljava/lang/String;Ljava/lang/String;>;)Ljavassist/bytecode/AttributeInfo;")]
	[LineNumberTable(new byte[]
	{
		3, 103, 104, 135, 104, 136, 107, 106, 108, 234,
		61, 238, 70
	})]
	public override AttributeInfo copy(ConstPool newCp, Map classnames)
	{
		byte[] array = get();
		byte[] array2 = new byte[(nint)array.LongLength];
		ConstPool constPool = getConstPool();
		int num = ByteArray.readU16bit(array, 0);
		ByteArray.write16bit(num, array2, 0);
		int num2 = 0;
		int num3 = 2;
		while (num2 < num)
		{
			int n = ByteArray.readU16bit(array, num3);
			int value = constPool.copy(n, newCp, classnames);
			ByteArray.write16bit(value, array2, num3);
			num2++;
			num3 += 2;
		}
		NestMembersAttribute result = new NestMembersAttribute(newCp, array2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public virtual int numberOfClasses()
	{
		int result = ByteArray.readU16bit(info, 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(86)]
	public virtual int memberClass(int index)
	{
		int result = ByteArray.readU16bit(info, index * 2 + 2);
		_ = null;
		return result;
	}
}
