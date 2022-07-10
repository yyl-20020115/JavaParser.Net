using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;

namespace com.google.common.hash;

[Serializable]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable", "com.google.common.hash.LongAddable" })]
internal sealed class LongAdder : Striped64, Serializable.__Interface, LongAddable
{
	private const long serialVersionUID = 7249069246863182397L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(52)]
	public LongAdder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 16, 127, 8, 98, 223, 35, 148 })]
	public virtual void add(long P_0)
	{
		Cell[] array;
		long num;
		if ((array = cells) == null && casBase(num = ByteCodeHelper.VolatileRead(ref @base), num + P_0))
		{
			return;
		}
		int num2 = 1;
		int[] array2;
		if ((array2 = (int[])Striped64.threadHashCode.get()) != null && array != null)
		{
			IntPtr intPtr = (nint)array.LongLength;
			int num3 = (int)(nint)intPtr;
			Cell cell;
			long num4;
			if ((nint)intPtr >= 1 && (cell = array[(num3 - 1) & array2[0]]) != null && (num2 = (cell.cas(num4 = ByteCodeHelper.VolatileRead(ref cell.value), num4 + P_0) ? 1 : 0)) != 0)
			{
				return;
			}
		}
		retryUpdate(P_0, array2, (byte)num2 != 0);
	}

	[LineNumberTable(new byte[] { 46, 108, 105, 99, 99, 102, 101, 19, 230, 69 })]
	public virtual long sum()
	{
		long num = ByteCodeHelper.VolatileRead(ref @base);
		Cell[] array = cells;
		if (array != null)
		{
			int num2 = array.Length;
			for (int i = 0; i < num2; i++)
			{
				Cell cell = array[i];
				if (cell != null)
				{
					num += ByteCodeHelper.VolatileRead(ref cell.value);
				}
			}
		}
		return num;
	}

	internal sealed override long fn(long P_0, long P_1)
	{
		return P_0 + P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 29, 106 })]
	public virtual void increment()
	{
		add(1L);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 106 })]
	public virtual void decrement()
	{
		add(-1L);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 65, 106 })]
	public virtual void reset()
	{
		internalReset(0L);
	}

	[LineNumberTable(new byte[]
	{
		77, 108, 105, 111, 99, 99, 104, 102, 100, 111,
		242, 60, 232, 72
	})]
	public virtual long sumThenReset()
	{
		long num = ByteCodeHelper.VolatileRead(ref @base);
		Cell[] array = cells;
		long newValue = 0L;
		ByteCodeHelper.VolatileWrite(ref @base, newValue);
		if (array != null)
		{
			int num2 = array.Length;
			for (int i = 0; i < num2; i++)
			{
				Cell cell = array[i];
				if (cell != null)
				{
					num += ByteCodeHelper.VolatileRead(ref cell.value);
					long newValue2 = 0L;
					ByteCodeHelper.VolatileWrite(ref cell.value, newValue2);
				}
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(150)]
	public override string toString()
	{
		string result = Long.toString(sum());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(160)]
	public override long longValue()
	{
		long result = sum();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(166)]
	public override int intValue()
	{
		return (int)sum();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(172)]
	public override float floatValue()
	{
		return sum();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(178)]
	public override double doubleValue()
	{
		return sum();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 68, 102, 110 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeLong(sum());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 160, 73, 102, 105, 110, 115 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		busy = 0;
		cells = null;
		System.Threading.Thread.MemoryBarrier();
		ByteCodeHelper.VolatileWrite(newValue: P_0.readLong(), v: ref @base);
	}

	[HideFromJava]
	static LongAdder()
	{
		Striped64.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected LongAdder(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
