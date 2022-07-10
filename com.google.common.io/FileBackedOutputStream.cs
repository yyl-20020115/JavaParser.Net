using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class FileBackedOutputStream : OutputStream
{
	[SpecialName]
	[EnclosingMethod(null, "<init>", "(IZLjava.io.File;)V")]
	internal class _1 : ByteSource
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal FileBackedOutputStream this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(123)]
		internal _1(FileBackedOutputStream P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(126)]
		public override InputStream openStream()
		{
			InputStream result = access_0024100(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 82, 189, 2, 97, 139 })]
		protected internal override void finalize()
		{
			System.Exception ex;
			try
			{
				this_00240.reset();
				return;
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception @this = ex;
			Throwable.instancehelper_printStackTrace(@this, java.lang.System.err);
		}

		[HideFromJava]
		~_1()
		{
			if (!ByteCodeHelper.SkipFinalizer())
			{
				try
				{
					finalize();
				}
				catch
				{
				}
			}
		}
	}

	[SpecialName]
	[EnclosingMethod(null, "<init>", "(IZLjava.io.File;)V")]
	internal class _2 : ByteSource
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal FileBackedOutputStream this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(140)]
		internal _2(FileBackedOutputStream P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(143)]
		public override InputStream openStream()
		{
			InputStream result = access_0024100(this_00240);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class MemoryOutput : ByteArrayOutputStream
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(74)]
		internal MemoryOutput(_1 P_0)
			: this()
		{
		}

		internal virtual byte[] getBuffer()
		{
			return buf;
		}

		internal virtual int getCount()
		{
			return count;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(74)]
		private MemoryOutput()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int fileThreshold;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool resetOnFinalize;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ByteSource source;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private File parentDirectory;

	private OutputStream @out;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private MemoryOutput memory;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private File file;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(56)]
	internal static InputStream access_0024100(FileBackedOutputStream P_0)
	{
		InputStream result = P_0.openInputStream();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		126, 141, 104, 142, 139, 108, 104, 103, 103, 104,
		191, 31, 227, 51, 104, 142, 139, 108, 104, 103,
		103, 104, 159, 34, 130
	})]
	public virtual void reset()
	{
		try
		{
			close();
		}
		catch
		{
			//try-fault
			if (memory == null)
			{
				memory = new MemoryOutput(null);
			}
			else
			{
				memory.reset();
			}
			@out = memory;
			if (this.file != null)
			{
				File file = this.file;
				this.file = null;
				if (!file.delete())
				{
					string text = java.lang.String.valueOf(file);
					int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
					num = num;
					string message = new StringBuilder(num).append("Could not delete: ").append(text).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new IOException(message);
				}
			}
			throw;
		}
		if (memory == null)
		{
			memory = new MemoryOutput(null);
		}
		else
		{
			memory.reset();
		}
		@out = memory;
		if (this.file != null)
		{
			File file2 = this.file;
			this.file = null;
			if (!file2.delete())
			{
				string text2 = java.lang.String.valueOf(file2);
				int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
				num = num;
				string message2 = new StringBuilder(num).append("Could not delete: ").append(text2).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException(message2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 109, 104, 179, 108 })]
	private InputStream openInputStream()
	{
		if (file != null)
		{
			FileInputStream.___003Cclinit_003E();
			FileInputStream result = new FileInputStream(file);
			_ = null;
			return result;
		}
		Objects.requireNonNull(memory);
		ByteArrayInputStream result2 = new ByteArrayInputStream(memory.getBuffer(), 0, memory.getCount());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 115, 130, 107 })]
	public FileBackedOutputStream(int fileThreshold, bool resetOnFinalize)
		: this(fileThreshold, resetOnFinalize, null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 114, 130, 104, 103, 103, 103, 108, 140, 99,
		238, 81, 236, 72
	})]
	private FileBackedOutputStream(int P_0, bool P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] File P_2)
	{
		fileThreshold = P_0;
		resetOnFinalize = P_1;
		parentDirectory = P_2;
		memory = new MemoryOutput(null);
		@out = memory;
		if (P_1)
		{
			source = new _1(this);
		}
		else
		{
			source = new _2(this);
		}
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 99, 109 })]
	public override void close()
	{
		@out.close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 113, 127, 4, 114, 168, 166, 103, 125, 134,
		217, 226, 61, 97, 103, 167, 103, 135
	})]
	private void update(int P_0)
	{
		File file;
		IOException ex;
		if (memory != null && memory.getCount() + P_0 > fileThreshold)
		{
			file = File.createTempFile("FileBackedOutputStream", null, parentDirectory);
			if (resetOnFinalize)
			{
				file.deleteOnExit();
			}
			try
			{
				FileOutputStream fileOutputStream = new FileOutputStream(file);
				fileOutputStream.write(memory.getBuffer(), 0, memory.getCount());
				fileOutputStream.flush();
				@out = fileOutputStream;
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0083;
			}
			this.file = file;
			memory = null;
		}
		return;
		IL_0083:
		IOException ex2 = ex;
		file.delete();
		throw Throwable.___003Cunmap_003E(ex2);
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 93, 103, 112 })]
	public override void write(byte[] b, int off, int len)
	{
		update(len);
		@out.write(b, off, len);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual File getFile()
	{
		return file;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 48, 106 })]
	public FileBackedOutputStream(int fileThreshold)
		: this(fileThreshold, resetOnFinalize: false)
	{
	}

	public virtual ByteSource asByteSource()
	{
		return source;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 82, 103, 110 })]
	public override void write(int b)
	{
		update(1);
		@out.write(b);
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 88, 108 })]
	public override void write(byte[] b)
	{
		write(b, 0, b.Length);
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 104, 109 })]
	public override void flush()
	{
		@out.flush();
	}
}
