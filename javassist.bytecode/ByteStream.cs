using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;

namespace javassist.bytecode;

internal sealed class ByteStream : OutputStream
{
	private byte[] buf;

	private int count;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 170, 104, 108, 103 })]
	public ByteStream(int P_0)
	{
		buf = new byte[P_0];
		count = 0;
	}

	[LineNumberTable(new byte[] { 160, 75, 105, 106, 106, 110, 116, 135 })]
	public virtual void enlarge(int P_0)
	{
		int num = count + P_0;
		if (num > (nint)buf.LongLength)
		{
			int num2 = (int)((nint)buf.LongLength << 1);
			byte[] dest = new byte[(num2 <= num) ? num : num2];
			ByteCodeHelper.arraycopy_primitive_1(buf, 0, dest, 0, count);
			buf = dest;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 190, 103, 116, 110 })]
	public override void write(byte[] P_0, int P_1, int P_2)
	{
		enlarge(P_2);
		ByteCodeHelper.arraycopy_primitive_1(P_0, P_1, buf, count, P_2);
		count += P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 20, 103, 103, 109, 111, 110, 108, 105 })]
	public virtual void writeInt(int P_0)
	{
		enlarge(4);
		int num = count;
		buf[num] = (byte)(sbyte)((uint)P_0 >> 24);
		buf[num + 1] = (byte)(sbyte)((uint)P_0 >> 16);
		buf[num + 2] = (byte)(sbyte)((uint)P_0 >> 8);
		buf[num + 3] = (byte)(sbyte)P_0;
		count = num + 4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		30, 103, 103, 110, 112, 112, 112, 112, 112, 111,
		109, 105
	})]
	public virtual void writeLong(long P_0)
	{
		enlarge(8);
		int num = count;
		buf[num] = (byte)(sbyte)((ulong)P_0 >> 56);
		buf[num + 1] = (byte)(sbyte)((ulong)P_0 >> 48);
		buf[num + 2] = (byte)(sbyte)((ulong)P_0 >> 40);
		buf[num + 3] = (byte)(sbyte)((ulong)P_0 >> 32);
		buf[num + 4] = (byte)(sbyte)((ulong)P_0 >> 24);
		buf[num + 5] = (byte)(sbyte)((ulong)P_0 >> 16);
		buf[num + 6] = (byte)(sbyte)((ulong)P_0 >> 8);
		buf[num + 7] = (byte)(sbyte)P_0;
		count = num + 8;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		73, 98, 102, 104, 104, 102, 104, 228, 59, 230,
		72, 104, 191, 22, 105, 103, 103, 103, 103, 102,
		107, 106, 107, 111, 105, 114, 115, 113, 166, 113,
		113, 228, 51, 235, 81, 103
	})]
	private void writeUTF2(string P_0, int P_1, int P_2)
	{
		int num = P_1;
		int i;
		for (i = P_2; i < P_1; i++)
		{
			int num2 = String.instancehelper_charAt(P_0, i);
			if (num2 > 2047)
			{
				num += 2;
			}
			else if (num2 == 0 || num2 > 127)
			{
				num++;
			}
		}
		if (num > 65535)
		{
			string message = new StringBuilder().append("encoded string too long: ").append(P_1).append(num)
				.append(" bytes")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		enlarge(num + 2);
		i = count;
		byte[] array = buf;
		array[i] = (byte)(sbyte)((uint)num >> 8);
		array[i + 1] = (byte)(sbyte)num;
		i += 2 + P_2;
		for (int j = P_2; j < P_1; j++)
		{
			int num3 = String.instancehelper_charAt(P_0, j);
			if (1 <= num3 && num3 <= 127)
			{
				int num4 = i;
				i++;
				array[num4] = (byte)(sbyte)num3;
			}
			else if (num3 > 2047)
			{
				array[i] = (byte)(sbyte)(0xE0u | ((uint)(num3 >> 12) & 0xFu));
				array[i + 1] = (byte)(sbyte)(0x80u | ((uint)(num3 >> 6) & 0x3Fu));
				array[i + 2] = (byte)(sbyte)(0x80u | ((uint)num3 & 0x3Fu));
				i += 3;
			}
			else
			{
				array[i] = (byte)(sbyte)(0xC0u | ((uint)(num3 >> 6) & 0x1Fu));
				array[i + 1] = (byte)(sbyte)(0x80u | ((uint)num3 & 0x3Fu));
				i += 2;
			}
		}
		count = i;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	public ByteStream()
		: this(32)
	{
	}

	public virtual int getPos()
	{
		return count;
	}

	public virtual int size()
	{
		return count;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 179, 103, 110 })]
	public virtual void writeBlank(int P_0)
	{
		enlarge(P_0);
		count += P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 185, 108 })]
	public override void write(byte[] P_0)
	{
		write(P_0, 0, P_0.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 5, 103, 103, 106, 105 })]
	public override void write(int P_0)
	{
		enlarge(1);
		int num = count;
		buf[num] = (byte)(sbyte)P_0;
		count = num + 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 12, 103, 103, 108, 108, 105 })]
	public virtual void writeShort(int P_0)
	{
		enlarge(2);
		int num = count;
		buf[num] = (byte)(sbyte)((uint)P_0 >> 8);
		buf[num + 1] = (byte)(sbyte)P_0;
		count = num + 2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 44, 111 })]
	public virtual void writeFloat(float P_0)
	{
		writeInt(Float.floatToIntBits(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 48, 111 })]
	public virtual void writeDouble(double P_0)
	{
		writeLong(Double.doubleToLongBits(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		52, 103, 103, 137, 103, 107, 105, 102, 105, 107,
		140, 107, 225, 58, 230, 74, 103
	})]
	public virtual void writeUTF(string P_0)
	{
		int num = String.instancehelper_length(P_0);
		int num2 = count;
		enlarge(num + 2);
		byte[] array = buf;
		int num3 = num2;
		num2++;
		array[num3] = (byte)(sbyte)((uint)num >> 8);
		int num4 = num2;
		num2++;
		array[num4] = (byte)(sbyte)num;
		for (int i = 0; i < num; i++)
		{
			int num5 = String.instancehelper_charAt(P_0, i);
			if (1 <= num5 && num5 <= 127)
			{
				int num6 = num2;
				num2++;
				array[num6] = (byte)(sbyte)num5;
				continue;
			}
			writeUTF2(P_0, num, i);
			return;
		}
		count = num2;
	}

	[LineNumberTable(new byte[] { 113, 106 })]
	public virtual void write(int P_0, int P_1)
	{
		buf[P_0] = (byte)(sbyte)P_1;
	}

	[LineNumberTable(new byte[] { 117, 108, 108 })]
	public virtual void writeShort(int P_0, int P_1)
	{
		buf[P_0] = (byte)(sbyte)((uint)P_1 >> 8);
		buf[P_0 + 1] = (byte)(sbyte)P_1;
	}

	[LineNumberTable(new byte[] { 122, 109, 111, 110, 108 })]
	public virtual void writeInt(int P_0, int P_1)
	{
		buf[P_0] = (byte)(sbyte)((uint)P_1 >> 24);
		buf[P_0 + 1] = (byte)(sbyte)((uint)P_1 >> 16);
		buf[P_0 + 2] = (byte)(sbyte)((uint)P_1 >> 8);
		buf[P_0 + 3] = (byte)(sbyte)P_1;
	}

	[LineNumberTable(new byte[] { 160, 65, 108, 116 })]
	public virtual byte[] toByteArray()
	{
		byte[] array = new byte[count];
		ByteCodeHelper.arraycopy_primitive_1(buf, 0, array, 0, count);
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 71, 117 })]
	public virtual void writeTo(OutputStream P_0)
	{
		P_0.write(buf, 0, count);
	}
}
