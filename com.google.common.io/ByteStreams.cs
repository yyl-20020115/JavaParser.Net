using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.math;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio;
using java.nio.channels;
using java.util;
using javax.annotation;

namespace com.google.common.io;

[ConstantPool(new object[]
{
	(byte)222,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class ByteStreams : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, null, null)]
	internal class _1 : OutputStream
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(659)]
		internal _1()
		{
		}

		public override void write(int P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 41, 103 })]
		public override void write(byte[] P_0)
		{
			Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 47, 103, 109 })]
		public override void write(byte[] P_0, int P_1, int P_2)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		}

		public override string toString()
		{
			return "ByteStreams.nullOutputStream()";
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Implements(new string[] { "com.google.common.io.ByteArrayDataInput" })]
	internal class ByteArrayDataInputStream : Object, ByteArrayDataInput, DataInput
	{
		[Modifiers(Modifiers.Final)]
		internal DataInput input;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 220, 104, 108 })]
		internal ByteArrayDataInputStream(ByteArrayInputStream P_0)
		{
			input = new DataInputStream(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 227, 190, 2, 97, 140 })]
		public virtual void readFully(byte[] P_0)
		{
			IOException ex;
			try
			{
				input.readFully(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 236, 191, 1, 2, 97, 140 })]
		public virtual void readFully(byte[] P_0, int P_1, int P_2)
		{
			IOException ex;
			try
			{
				input.readFully(P_0, P_1, P_2);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 245, 127, 3, 97 })]
		public virtual int skipBytes(int P_0)
		{
			//Discarded unreachable code: IL_000e
			IOException ex;
			try
			{
				return input.skipBytes(P_0);
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 254, 127, 2, 97 })]
		public virtual bool readBoolean()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readBoolean();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 7, 127, 15, 97, 108, 98 })]
		public virtual byte readByte()
		{
			//Discarded unreachable code: IL_000e
			EOFException ex;
			IOException ex2;
			try
			{
				try
				{
					return (byte)(sbyte)input.readByte();
				}
				catch (EOFException x)
				{
					ex = ByteCodeHelper.MapException<EOFException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
			}
			catch (IOException x2)
			{
				ex2 = ByteCodeHelper.MapException<IOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_002a;
			}
			EOFException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
			IL_002a:
			IOException detailMessage = ex2;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 18, 127, 2, 97 })]
		public virtual int readUnsignedByte()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readUnsignedByte();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 27, 127, 2, 97 })]
		public virtual short readShort()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readShort();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 36, 127, 2, 97 })]
		public virtual int readUnsignedShort()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readUnsignedShort();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 45, 127, 2, 97 })]
		public virtual char readChar()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readChar();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 54, 127, 2, 97 })]
		public virtual int readInt()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readInt();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 63, 127, 2, 97 })]
		public virtual long readLong()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readLong();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 72, 127, 2, 97 })]
		public virtual float readFloat()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readFloat();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 81, 127, 2, 97 })]
		public virtual double readDouble()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readDouble();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 91, 127, 2, 97 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual string readLine()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readLine();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 100, 127, 2, 97 })]
		public virtual string readUTF()
		{
			//Discarded unreachable code: IL_000d
			IOException ex;
			try
			{
				return input.readUTF();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException(cause);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Implements(new string[] { "com.google.common.io.ByteArrayDataOutput" })]
	internal class ByteArrayDataOutputStream : Object, ByteArrayDataOutput, DataOutput
	{
		[Modifiers(Modifiers.Final)]
		internal DataOutput output;

		[Modifiers(Modifiers.Final)]
		internal ByteArrayOutputStream byteArrayOutputStream;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 151, 104, 103, 108 })]
		internal ByteArrayDataOutputStream(ByteArrayOutputStream P_0)
		{
			byteArrayOutputStream = P_0;
			output = new DataOutputStream(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 159, 190, 2, 97, 140 })]
		public virtual void write(int P_0)
		{
			IOException ex;
			try
			{
				output.write(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 168, 190, 2, 97, 140 })]
		public virtual void write(byte[] P_0)
		{
			IOException ex;
			try
			{
				output.write(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 177, 191, 1, 2, 97, 140 })]
		public virtual void write(byte[] P_0, int P_1, int P_2)
		{
			IOException ex;
			try
			{
				output.write(P_0, P_1, P_2);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 3, 66, 190, 2, 97, 140 })]
		public virtual void writeBoolean(bool P_0)
		{
			IOException ex;
			try
			{
				output.writeBoolean(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 195, 190, 2, 97, 140 })]
		public virtual void writeByte(int P_0)
		{
			IOException ex;
			try
			{
				output.writeByte(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 204, 190, 2, 97, 140 })]
		public virtual void writeBytes(string P_0)
		{
			IOException ex;
			try
			{
				output.writeBytes(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 213, 190, 2, 97, 140 })]
		public virtual void writeChar(int P_0)
		{
			IOException ex;
			try
			{
				output.writeChar(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 222, 190, 2, 97, 140 })]
		public virtual void writeChars(string P_0)
		{
			IOException ex;
			try
			{
				output.writeChars(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 231, 191, 0, 2, 97, 140 })]
		public virtual void writeDouble(double P_0)
		{
			IOException ex;
			try
			{
				output.writeDouble(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 240, 191, 0, 2, 97, 140 })]
		public virtual void writeFloat(float P_0)
		{
			IOException ex;
			try
			{
				output.writeFloat(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 249, 190, 2, 97, 140 })]
		public virtual void writeInt(int P_0)
		{
			IOException ex;
			try
			{
				output.writeInt(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 2, 190, 2, 97, 140 })]
		public virtual void writeLong(long P_0)
		{
			IOException ex;
			try
			{
				output.writeLong(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 11, 190, 2, 97, 140 })]
		public virtual void writeShort(int P_0)
		{
			IOException ex;
			try
			{
				output.writeShort(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 20, 190, 2, 97, 140 })]
		public virtual void writeUTF(string P_0)
		{
			IOException ex;
			try
			{
				output.writeUTF(P_0);
				return;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(654)]
		public virtual byte[] toByteArray()
		{
			byte[] result = byteArrayOutputStream.toByteArray();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class LimitedInputStream : FilterInputStream
	{
		private long left;

		private new long m_mark;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 86, 233, 61, 200, 103, 114, 103 })]
		internal LimitedInputStream(InputStream P_0, long P_1)
			: base(P_0)
		{
			this.m_mark = -1L;
			Preconditions.checkNotNull(P_0);
			Preconditions.checkArgument(P_1 >= 0, (object)"limit must be non-negative");
			left = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(720)]
		public override int available()
		{
			return (int)Math.min(@in.available(), left);
		}

		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 100, 110, 108 })]
		public override void mark(int P_0)
		{
			@in.mark(P_0);
			this.m_mark = left;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 106, 106, 162, 110, 100, 143 })]
		public override int read()
		{
			if (left == 0)
			{
				return -1;
			}
			int num = @in.read();
			if (num != -1)
			{
				left--;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 119, 106, 162, 112, 113, 100, 143 })]
		public override int read(byte[] P_0, int P_1, int P_2)
		{
			if (left == 0)
			{
				return -1;
			}
			P_2 = (int)Math.min(P_2, left);
			int num = @in.read(P_0, P_1, P_2);
			if (num != -1)
			{
				left -= num;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 133, 111, 144, 106, 176, 109, 108 })]
		public override void reset()
		{
			if (!@in.markSupported())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException("Mark not supported");
			}
			if (this.m_mark == -1)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException("Mark not set");
			}
			@in.reset();
			left = this.m_mark;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 146, 110, 111, 110 })]
		public override long skip(long P_0)
		{
			P_0 = Math.min(P_0, left);
			long num = @in.skip(P_0);
			left -= num;
			return num;
		}
	}

	private const int BUFFER_SIZE = 8192;

	private const int ZERO_COPY_CHUNK_SIZE = 524288;

	private const int MAX_ARRAY_LEN = 2147483639;

	private const int TO_BYTE_ARRAY_DEQUE_SIZE = 20;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static OutputStream NULL_OUTPUT_STREAM;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		59, 103, 103, 102, 131, 104, 100, 130, 105, 101,
		98
	})]
	public static long copy(InputStream from, OutputStream to)
	{
		Preconditions.checkNotNull(from);
		Preconditions.checkNotNull(to);
		byte[] b = createBuffer();
		long num = 0L;
		while (true)
		{
			int num2 = from.read(b);
			if (num2 == -1)
			{
				break;
			}
			to.write(b, 0, num2);
			num += num2;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 174, 131, 102, 110, 134 })]
	public static long exhaust(InputStream @in)
	{
		long num = 0L;
		byte[] b = createBuffer();
		long num2;
		while ((num2 = @in.read(b)) != -1)
		{
			num += num2;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		162, 212, 131, 130, 103, 100, 136, 165, 111, 195,
		136, 145, 194, 100, 133
	})]
	internal static long skipUpTo(InputStream P_0, long P_1)
	{
		long num = 0L;
		byte[] array = null;
		long num3;
		for (; num < P_1; num += num3)
		{
			long num2 = P_1 - num;
			num3 = skipSafely(P_0, num2);
			if (num3 == 0)
			{
				int num4 = (int)Math.min(num2, 8192L);
				if (array == null)
				{
					array = new byte[num4];
				}
				if ((num3 = P_0.read(array, 0, num4)) == -1)
				{
					break;
				}
			}
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 133, 115, 105, 191, 12, 104, 131, 100, 101,
		107, 165, 138, 101, 162, 103, 100, 194, 105, 105,
		115
	})]
	internal static byte[] toByteArray(InputStream P_0, long P_1)
	{
		Preconditions.checkArgument(P_1 >= 0, "expectedSize (%s) must be non-negative", P_1);
		if (P_1 > 2147483639u)
		{
			int num = 62;
			num = num;
			string s = new StringBuilder(num).append(P_1).append(" bytes is too large to fit in a byte array").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new OutOfMemoryError(s);
		}
		byte[] array = new byte[(int)P_1];
		int num2 = (int)P_1;
		int num3;
		while (num2 > 0)
		{
			num3 = (int)P_1 - num2;
			int num4 = P_0.read(array, num3, num2);
			if (num4 == -1)
			{
				byte[] result = Arrays.copyOf(array, num3);
				_ = null;
				return result;
			}
			num2 -= num4;
		}
		num3 = P_0.read();
		if (num3 == -1)
		{
			return array;
		}
		ArrayDeque arrayDeque = new ArrayDeque(22);
		((Queue)arrayDeque).add((object)array);
		((Queue)arrayDeque).add((object)new byte[1] { (byte)(sbyte)num3 });
		byte[] result2 = toByteArrayInternal(P_0, arrayDeque, (int)((nint)array.LongLength + 1));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 123, 103 })]
	public static byte[] toByteArray(InputStream @in)
	{
		Preconditions.checkNotNull(@in);
		byte[] result = toByteArrayInternal(@in, new ArrayDeque(20), 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/io/InputStream;Lcom/google/common/io/ByteProcessor<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 222, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 12, 103, 135, 166, 104, 111 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	public static object readBytes(InputStream input, ByteProcessor processor)
	{
		Preconditions.checkNotNull(input);
		Preconditions.checkNotNull(processor);
		byte[] array = createBuffer();
		int num;
		do
		{
			num = input.read(array);
		}
		while (num != -1 && processor.processBytes(array, 0, num));
		object result = processor.getResult();
		_ = null;
		return result;
	}

	[LineNumberTable(64)]
	internal static byte[] createBuffer()
	{
		return new byte[8192];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		163, 52, 103, 103, 100, 159, 5, 107, 98, 100,
		110, 100, 130, 100, 98
	})]
	public static int read(InputStream @in, byte[] b, int off, int len)
	{
		Preconditions.checkNotNull(@in);
		Preconditions.checkNotNull(b);
		if (len < 0)
		{
			string s = String.format("len (%s) cannot be negative", Integer.valueOf(len));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IndexOutOfBoundsException(s);
		}
		Preconditions.checkPositionIndexes(off, off + len, b.Length);
		int i;
		int num;
		for (i = 0; i < len; i += num)
		{
			num = @in.read(b, off + i, len - i);
			if (num == -1)
			{
				break;
			}
		}
		return i;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(703)]
	public static InputStream limit(InputStream @in, long limit)
	{
		LimitedInputStream result = new LimitedInputStream(@in, limit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Queue<[B>;I)[B")]
	[LineNumberTable(new byte[]
	{
		160, 96, 104, 135, 108, 101, 130, 101, 104, 100,
		108, 105, 101, 107, 100, 98
	})]
	private static byte[] combineBuffers(Queue P_0, int P_1)
	{
		if (P_0.isEmpty())
		{
			return new byte[0];
		}
		byte[] array = (byte[])P_0.remove();
		if ((nint)array.LongLength == P_1)
		{
			return array;
		}
		int num = (int)(P_1 - (nint)array.LongLength);
		array = Arrays.copyOf(array, P_1);
		while (num > 0)
		{
			byte[] array2 = (byte[])P_0.remove();
			int num2 = Math.min(num, array2.Length);
			int destStart = P_1 - num;
			ByteCodeHelper.arraycopy_primitive_1(array2, 0, array, destStart, num2);
			num -= num2;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/io/InputStream;Ljava/util/Queue<[B>;I)[B")]
	[LineNumberTable(new byte[]
	{
		127, 253, 70, 98, 139, 115, 104, 98, 133, 110,
		101, 138, 101, 102, 226, 52, 248, 80, 137, 142
	})]
	private static byte[] toByteArrayInternal(InputStream P_0, Queue P_1, int P_2)
	{
		int num = Math.min(8192, Math.max(128, Integer.highestOneBit(P_2) * 2));
		int num2 = num;
		while (P_2 < 2147483639)
		{
			byte[] array = new byte[Math.min(num2, 2147483639 - P_2)];
			P_1.add(array);
			int num3 = 0;
			while (num3 < (nint)array.LongLength)
			{
				int num4 = P_0.read(array, num3, (int)((nint)array.LongLength - num3));
				if (num4 == -1)
				{
					byte[] result = combineBuffers(P_1, P_2);
					_ = null;
					return result;
				}
				num3 += num4;
				P_2 += num4;
			}
			num2 = IntMath.saturatedMultiply(num2, (num2 >= 4096) ? 2 : 4);
		}
		if (P_0.read() == -1)
		{
			byte[] result2 = combineBuffers(P_1, 2147483639);
			_ = null;
			return result2;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new OutOfMemoryError("input is too large to fit in a byte array");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(328)]
	public static ByteArrayDataInput newDataInput(ByteArrayInputStream byteArrayInputStream)
	{
		ByteArrayDataInputStream result = new ByteArrayDataInputStream((ByteArrayInputStream)Preconditions.checkNotNull(byteArrayInputStream));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(513)]
	public static ByteArrayDataOutput newDataOutput(ByteArrayOutputStream byteArrayOutputStream)
	{
		ByteArrayDataOutputStream result = new ByteArrayDataOutputStream((ByteArrayOutputStream)Preconditions.checkNotNull(byteArrayOutputStream));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 181, 106, 100, 191, 38 })]
	public static void readFully(InputStream @in, byte[] b, int off, int len)
	{
		int num = read(@in, b, off, len);
		if (num != len)
		{
			int num2 = 81;
			num2 = num2;
			string s = new StringBuilder(num2).append("reached end of stream after reading ").append(num).append(" bytes; ")
				.append(len)
				.append(" bytes expected")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new EOFException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 250, 103 })]
	private static long skipSafely(InputStream P_0, long P_1)
	{
		int num = P_0.available();
		long result = ((num != 0) ? P_0.skip(Math.min(num, P_1)) : 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	private ByteStreams()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		85, 103, 103, 104, 103, 103, 162, 111, 100, 104,
		110, 164, 108, 99, 107, 103, 105, 142, 137
	})]
	public static long copy(ReadableByteChannel from, WritableByteChannel to)
	{
		Preconditions.checkNotNull(from);
		Preconditions.checkNotNull(to);
		long num;
		if (from is FileChannel)
		{
			FileChannel fileChannel = (FileChannel)from;
			num = fileChannel.position();
			long num2 = num;
			long num3;
			do
			{
				num3 = fileChannel.transferTo(num2, 524288L, to);
				num2 += num3;
				fileChannel.position(num2);
			}
			while (num3 > 0 || num2 < fileChannel.size());
			return num2 - num;
		}
		ByteBuffer byteBuffer = ByteBuffer.wrap(createBuffer());
		num = 0L;
		while (from.read(byteBuffer) != -1)
		{
			Java8Compatibility.flip(byteBuffer);
			while (byteBuffer.hasRemaining())
			{
				num += to.write(byteBuffer);
			}
			Java8Compatibility.clear(byteBuffer);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(303)]
	public static ByteArrayDataInput newDataInput(byte[] bytes)
	{
		ByteArrayDataInput result = newDataInput(new ByteArrayInputStream(bytes));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 201, 105 })]
	public static ByteArrayDataInput newDataInput(byte[] bytes, int start)
	{
		Preconditions.checkPositionIndex(start, bytes.Length);
		ByteArrayDataInput result = newDataInput(new ByteArrayInputStream(bytes, start, (int)((nint)bytes.LongLength - start)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(480)]
	public static ByteArrayDataOutput newDataOutput()
	{
		ByteArrayDataOutput result = newDataOutput(new ByteArrayOutputStream());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 123, 100, 159, 5 })]
	public static ByteArrayDataOutput newDataOutput(int size)
	{
		if (size < 0)
		{
			string s = String.format("Invalid size: %s", Integer.valueOf(size));
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		ByteArrayDataOutput result = newDataOutput(new ByteArrayOutputStream(size));
		_ = null;
		return result;
	}

	public static OutputStream nullOutputStream()
	{
		return NULL_OUTPUT_STREAM;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 164, 108 })]
	public static void readFully(InputStream @in, byte[] b)
	{
		readFully(@in, b, 0, b.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 199, 104, 100, 191, 38 })]
	public static void skipFully(InputStream @in, long n)
	{
		long num = skipUpTo(@in, n);
		if (num < n)
		{
			int num2 = 100;
			num2 = num2;
			string s = new StringBuilder(num2).append("reached end of stream after skipping ").append(num).append(" bytes; ")
				.append(n)
				.append(" bytes expected")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new EOFException(s);
		}
	}

	[LineNumberTable(658)]
	static ByteStreams()
	{
		NULL_OUTPUT_STREAM = new _1();
	}
}
