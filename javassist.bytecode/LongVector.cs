using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;

namespace javassist.bytecode;

internal sealed class LongVector : Object
{
	internal const int ASIZE = 128;

	internal const int ABITS = 7;

	internal const int VSIZE = 8;

	private ConstInfo[][] objects;

	private int elements;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 168, 104, 108, 103 })]
	public LongVector()
	{
		objects = new ConstInfo[8][];
		elements = 0;
	}

	[LineNumberTable(new byte[] { 159, 184, 109, 130 })]
	public virtual ConstInfo elementAt(int P_0)
	{
		if (P_0 < 0 || elements <= P_0)
		{
			return null;
		}
		return objects[P_0 >> 7][P_0 & 0x7F];
	}

	[LineNumberTable(new byte[]
	{
		159, 191, 105, 106, 104, 100, 105, 111, 167, 106,
		146, 107, 110
	})]
	public virtual void addElement(ConstInfo P_0)
	{
		int num = elements >> 7;
		int num2 = elements & 0x7F;
		int num3 = objects.Length;
		if (num >= num3)
		{
			ConstInfo[][] dest = new ConstInfo[num3 + 8][];
			ByteCodeHelper.arraycopy(objects, 0, dest, 0, num3);
			objects = dest;
		}
		if (objects[num] == null)
		{
			objects[num] = new ConstInfo[128];
		}
		objects[num][num2] = P_0;
		elements++;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 173, 104, 105, 108, 103 })]
	public LongVector(int P_0)
	{
		int num = ((P_0 >> 7) & -8) + 8;
		objects = new ConstInfo[num][];
		elements = 0;
	}

	public virtual int size()
	{
		return elements;
	}

	[LineNumberTable(39)]
	public virtual int capacity()
	{
		return (int)((nint)objects.LongLength * 128);
	}
}
