using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.graph;
using com.google.common.hash;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio;
using java.nio.channels;
using java.nio.charset;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.io;

[ConstantPool(new object[]
{
	(byte)248,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class Files : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/io/LineProcessor<Ljava/util/List<Ljava/lang/String;>;>;")]
	[EnclosingMethod(null, "readLines", "(Ljava.io.File;Ljava.nio.charset.Charset;)Ljava.util.List;")]
	internal class _1 : java.lang.Object, LineProcessor
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/List<Ljava/lang/String;>;")]
		internal List result;

		[Signature("()Ljava/util/List<Ljava/lang/String;>;")]
		public virtual List getResult()
		{
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 189, 104 })]
		internal _1()
		{
			result = Lists.newArrayList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 194, 109 })]
		public virtual bool processLine(string P_0)
		{
			result.add(P_0);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(559)]
		public virtual object getResult()
		{
			List list = this.getResult();
			_ = null;
			return list;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/graph/SuccessorsFunction<Ljava/io/File;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _2 : java.lang.Object, SuccessorsFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(856)]
		internal _2()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/io/File;)Ljava/lang/Iterable<Ljava/io/File;>;")]
		[LineNumberTable(new byte[] { 162, 234, 104, 103, 99, 206 })]
		public virtual Iterable successors(File P_0)
		{
			if (P_0.isDirectory())
			{
				File[] array = P_0.listFiles();
				if (array != null)
				{
					List result = Collections.unmodifiableList(Arrays.asList(array));
					_ = null;
					return result;
				}
			}
			ImmutableList result2 = ImmutableList.of();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(856)]
		public virtual Iterable successors(object P_0)
		{
			Iterable result = successors((File)P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class FileByteSink : ByteSink
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private File file;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableSet<Lcom/google/common/io/FileWriteMode;>;")]
		private ImmutableSet modes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(183)]
		internal FileByteSink(File P_0, FileWriteMode[] P_1, Files._1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 74, 104, 113, 108 })]
		private FileByteSink(File P_0, params FileWriteMode[] P_1)
		{
			file = (File)Preconditions.checkNotNull(P_0);
			modes = ImmutableSet.copyOf(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(195)]
		public new virtual FileOutputStream openStream()
		{
			FileOutputStream.___003Cclinit_003E();
			FileOutputStream result = new FileOutputStream(file, modes.contains(FileWriteMode.___003C_003EAPPEND));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(200)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(file);
			string text2 = java.lang.String.valueOf(modes);
			int num = 20 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("Files.asByteSink(").append(text).append(", ")
				.append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(183)]
		public override OutputStream openStream()
		{
			FileOutputStream result = openStream();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class FileByteSource : ByteSource
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private File file;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(122)]
		internal FileByteSource(File P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 76, 104, 113 })]
		private FileByteSource(File P_0)
		{
			file = (File)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(132)]
		public new virtual FileInputStream openStream()
		{
			FileInputStream.___003Cclinit_003E();
			FileInputStream result = new FileInputStream(file);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
		[LineNumberTable(new byte[] { 87, 109, 152 })]
		public override com.google.common.@base.Optional sizeIfKnown()
		{
			if (file.isFile())
			{
				com.google.common.@base.Optional result = com.google.common.@base.Optional.of(Long.valueOf(file.length()));
				_ = null;
				return result;
			}
			com.google.common.@base.Optional result2 = com.google.common.@base.Optional.absent();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 96, 109, 150 })]
		public override long size()
		{
			if (!file.isFile())
			{
				string s = file.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new FileNotFoundException(s);
			}
			long result = file.length();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[]
		{
			104, 134, 114, 223, 0, 102, 38, 230, 60, 102,
			98, 142, 102
		})]
		public override byte[] read()
		{
			Closer closer = Closer.create();
			byte[] result;
			System.Exception ex;
			try
			{
				try
				{
					FileInputStream fileInputStream = (FileInputStream)closer.register(openStream());
					result = ByteStreams.toByteArray(fileInputStream, fileInputStream.getChannel().size());
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_0040;
				}
			}
			catch
			{
				//try-fault
				closer.close();
				throw;
			}
			closer.close();
			return result;
			IL_0040:
			System.Exception ex2 = ex;
			try
			{
				System.Exception e = ex2;
				throw Throwable.___003Cunmap_003E(closer.rethrow(e));
			}
			catch
			{
				//try-fault
				closer.close();
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(167)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(file);
			int num = 20 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Files.asByteSource(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(122)]
		public override InputStream openStream()
		{
			FileInputStream result = openStream();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/io/Files$FilePredicate;>;Lcom/google/common/base/Predicate<Ljava/io/File;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.base.Predicate" })]
	internal abstract class FilePredicate : java.lang.Enum, com.google.common.@base.Predicate, java.util.function.Predicate
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : FilePredicate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(890)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(893)]
			public virtual bool apply(File P_0)
			{
				bool result = P_0.isDirectory();
				_ = null;
				return result;
			}

			public override string toString()
			{
				return "Files.isDirectory()";
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(890)]
			public override bool apply(object P_0)
			{
				bool result = apply((File)P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				FilePredicate.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : FilePredicate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(902)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(905)]
			public virtual bool apply(File P_0)
			{
				bool result = P_0.isFile();
				_ = null;
				return result;
			}

			public override string toString()
			{
				return "Files.isFile()";
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(902)]
			public override bool apply(object P_0)
			{
				bool result = apply((File)P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _2()
			{
				FilePredicate.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static FilePredicate IS_DIRECTORY;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static FilePredicate IS_FILE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static FilePredicate[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(889)]
		private FilePredicate(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		private static FilePredicate[] _0024values()
		{
			return new FilePredicate[2] { IS_DIRECTORY, IS_FILE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(889)]
		public static FilePredicate[] values()
		{
			return (FilePredicate[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(889)]
		public static FilePredicate valueOf(string P_0)
		{
			return (FilePredicate)java.lang.Enum.valueOf(ClassLiteral<FilePredicate>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(889)]
		internal FilePredicate(string P_0, int P_1, Files._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 163, 8, 240, 76, 240, 51 })]
		static FilePredicate()
		{
			IS_DIRECTORY = new _1("IS_DIRECTORY", 0);
			IS_FILE = new _2("IS_FILE", 1);
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool test(object P_0)
		{
			return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract bool apply(object P_0);

		bool com.google.common.@base.Predicate.Predicate_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}
	}

	private const int TEMP_DIR_ATTEMPTS = 10000;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/SuccessorsFunction<Ljava/io/File;>;")]
	private static SuccessorsFunction FILE_TREE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(119)]
	public static ByteSource asByteSource(File file)
	{
		FileByteSource result = new FileByteSource(file, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(180)]
	public static ByteSink asByteSink(File file, params FileWriteMode[] modes)
	{
		FileByteSink result = new FileByteSink(file, modes, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(211)]
	public static CharSource asCharSource(File file, Charset charset)
	{
		CharSource result = asByteSource(file).asCharSource(charset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(223)]
	public static CharSink asCharSink(File file, Charset charset, params FileWriteMode[] modes)
	{
		CharSink result = asByteSink(file, modes).asCharSink(charset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 211, 121, 120 })]
	public static void copy(File from, File to)
	{
		Preconditions.checkArgument((!from.equals(to)) ? true : false, "Source %s and destination %s must be different", from, to);
		asByteSource(from).copyTo(asByteSink(to));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(679)]
	public static MappedByteBuffer map(File file, FileChannel.MapMode mode)
	{
		MappedByteBuffer result = mapInternal(file, mode, -1L);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		162, 82, 103, 135, 134, 103, 127, 5, 114, 223,
		7, 102, 39, 230, 60, 102, 98, 142, 102
	})]
	private static MappedByteBuffer mapInternal(File P_0, FileChannel.MapMode P_1, long P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Closer closer = Closer.create();
		MappedByteBuffer result;
		System.Exception ex;
		try
		{
			try
			{
				RandomAccessFile.___003Cclinit_003E();
				RandomAccessFile randomAccessFile = (RandomAccessFile)closer.register(new RandomAccessFile(P_0, (P_1 != FileChannel.MapMode.READ_ONLY) ? "rw" : "r"));
				FileChannel fileChannel = (FileChannel)closer.register(randomAccessFile.getChannel());
				result = fileChannel.map(P_1, 0L, (P_2 != -1) ? P_2 : fileChannel.size());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0080;
			}
		}
		catch
		{
			//try-fault
			closer.close();
			throw;
		}
		closer.close();
		return result;
		IL_0080:
		System.Exception ex2 = ex;
		try
		{
			System.Exception e = ex2;
			throw Throwable.___003Cunmap_003E(closer.rethrow(e));
		}
		catch
		{
			//try-fault
			closer.close();
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	private Files()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.FileNotFoundException" })]
	[LineNumberTable(new byte[] { 40, 103, 103 })]
	public static BufferedReader newReader(File file, Charset charset)
	{
		Preconditions.checkNotNull(file);
		Preconditions.checkNotNull(charset);
		BufferedReader result = new BufferedReader(new InputStreamReader(new FileInputStream(file), charset));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.FileNotFoundException" })]
	[LineNumberTable(new byte[] { 58, 103, 103 })]
	public static BufferedWriter newWriter(File file, Charset charset)
	{
		Preconditions.checkNotNull(file);
		Preconditions.checkNotNull(charset);
		BufferedWriter result = new BufferedWriter(new OutputStreamWriter(new FileOutputStream(file), charset));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(238)]
	public static byte[] toByteArray(File file)
	{
		byte[] result = asByteSource(file).read();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[LineNumberTable(256)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static string toString(File file, Charset charset)
	{
		string result = asCharSource(file, charset).read();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 156, 116 })]
	public static void write(byte[] from, File to)
	{
		asByteSink(to).write(from);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[LineNumberTable(new byte[] { 159, 70, 74, 127, 6 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static void write(CharSequence from, File to, Charset charset)
	{
		CharSequence charSequence = from;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSink charSink = asCharSink(to, charset);
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		charSink.write(charSequence2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 188, 109 })]
	public static void copy(File from, OutputStream to)
	{
		asByteSource(from).copyTo(to);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[LineNumberTable(new byte[] { 160, 231, 110 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static void copy(File from, Charset charset, Appendable to)
	{
		asCharSource(from, charset).copyTo(to);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[LineNumberTable(new byte[] { 159, 51, 106, 127, 14 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static void append(CharSequence from, File to, Charset charset)
	{
		CharSequence charSequence = from;
		object __003Cref_003E = charSequence.___003Cref_003E;
		CharSink charSink = asCharSink(to, charset, FileWriteMode.___003C_003EAPPEND);
		CharSequence charSequence2 = default(CharSequence);
		object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
		charSink.write(charSequence2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 4, 103, 103, 109, 226, 72, 103, 103, 110,
		130
	})]
	public static bool equal(File file1, File file2)
	{
		Preconditions.checkNotNull(file1);
		Preconditions.checkNotNull(file2);
		if (file1 == file2 || file1.equals(file2))
		{
			return true;
		}
		long num = file1.length();
		long num2 = file2.length();
		if (num != 0 && num2 != 0 && num != num2)
		{
			return false;
		}
		bool result = asByteSource(file1).contentEquals(asByteSource(file2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[]
	{
		161, 56, 149, 159, 8, 108, 127, 27, 105, 227,
		61, 235, 70
	})]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static File createTempDir()
	{
		File.___003Cclinit_003E();
		File parent = new File(java.lang.System.getProperty("java.io.tmpdir"));
		long lng = java.lang.System.currentTimeMillis();
		int num = 21;
		num = num;
		string text = new StringBuilder(num).append(lng).append("-").toString();
		for (int i = 0; i < 10000; i++)
		{
			File.___003Cclinit_003E();
			int i2 = i;
			num = 11 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			File file = new File(parent, new StringBuilder(num).append(text).append(i2).toString());
			if (file.mkdir())
			{
				return file;
			}
		}
		num = 66 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string s = new StringBuilder(num).append("Failed to create directory within 10000 attempts (tried ").append(text).append("0 to ")
			.append(text)
			.append(9999)
			.append(')')
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalStateException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 161, 86, 103, 117, 159, 31 })]
	public static void touch(File file)
	{
		Preconditions.checkNotNull(file);
		if (!file.createNewFile() && !file.setLastModified(java.lang.System.currentTimeMillis()))
		{
			string text = java.lang.String.valueOf(file);
			int num = 38 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string message = new StringBuilder(num).append("Unable to update modification time of ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IOException(message);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 102, 103, 108, 227, 71, 129, 103, 104, 159,
		31
	})]
	public static void createParentDirs(File file)
	{
		Preconditions.checkNotNull(file);
		File parentFile = file.getCanonicalFile().getParentFile();
		if (parentFile != null)
		{
			parentFile.mkdirs();
			if (!parentFile.isDirectory())
			{
				string text = java.lang.String.valueOf(file);
				int num = 39 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string message = new StringBuilder(num).append("Unable to create parent directories of ").append(text).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException(message);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 132, 103, 103, 153, 108, 103, 107, 104, 159,
		31, 191, 31
	})]
	public static void move(File from, File to)
	{
		Preconditions.checkNotNull(from);
		Preconditions.checkNotNull(to);
		Preconditions.checkArgument((!from.equals(to)) ? true : false, "Source %s and destination %s must be different", from, to);
		if (from.renameTo(to))
		{
			return;
		}
		copy(from, to);
		if (!from.delete())
		{
			string text;
			int num;
			if (!to.delete())
			{
				text = java.lang.String.valueOf(to);
				num = 17 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string message = new StringBuilder(num).append("Unable to delete ").append(text).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException(message);
			}
			text = java.lang.String.valueOf(from);
			num = 17 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string message2 = new StringBuilder(num).append("Unable to delete ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IOException(message2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[LineNumberTable(535)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static string readFirstLine(File file, Charset charset)
	{
		string result = asCharSource(file, charset).readFirstLine();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/io/File;Ljava/nio/charset/Charset;)Ljava/util/List<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 161, 187, 108, 42 })]
	public static List readLines(File file, Charset charset)
	{
		return (List)asCharSource(file, charset).readLines(new _1());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;>(Ljava/io/File;Ljava/nio/charset/Charset;Lcom/google/common/io/LineProcessor<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 248, 0, 0 })]
	[LineNumberTable(596)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	public static object readLines(File file, Charset charset, LineProcessor callback)
	{
		object result = asCharSource(file, charset).readLines(callback);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;>(Ljava/io/File;Lcom/google/common/io/ByteProcessor<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 248, 0, 0 })]
	[LineNumberTable(619)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	public static object readBytes(File file, ByteProcessor processor)
	{
		object result = asByteSource(file).read(processor);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Obsolete]
	[LineNumberTable(638)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static HashCode hash(File file, HashFunction hashFunction)
	{
		HashCode result = asByteSource(file).hash(hashFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 31, 103 })]
	public static MappedByteBuffer map(File file)
	{
		Preconditions.checkNotNull(file);
		MappedByteBuffer result = map(file, FileChannel.MapMode.READ_ONLY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 76, 115 })]
	public static MappedByteBuffer map(File file, FileChannel.MapMode mode, long size)
	{
		Preconditions.checkArgument(size >= 0, "size (%s) may not be negative", size);
		MappedByteBuffer result = mapInternal(file, mode, size);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 119, 103, 104, 198, 127, 4, 166, 127, 3,
		159, 60, 133, 127, 9, 145, 140, 130, 169, 165,
		111, 107, 191, 12, 110, 140, 110, 105, 110, 167
	})]
	public static string simplifyPath(string pathname)
	{
		Preconditions.checkNotNull(pathname);
		if (java.lang.String.instancehelper_length(pathname) == 0)
		{
			return ".";
		}
		Splitter splitter = Splitter.on('/').omitEmptyStrings();
		CharSequence sequence = default(CharSequence);
		object obj = (sequence.___003Cref_003E = pathname);
		Iterable iterable = splitter.split(sequence);
		ArrayList arrayList = new ArrayList();
		Iterator iterator = iterable.iterator();
		while (iterator.hasNext())
		{
			string text = (string)iterator.next();
			string @this = text;
			int num = -1;
			switch (java.lang.String.instancehelper_hashCode(@this))
			{
			case 46:
				if (java.lang.String.instancehelper_equals(@this, "."))
				{
					num = 0;
				}
				break;
			case 1472:
				if (java.lang.String.instancehelper_equals(@this, ".."))
				{
					num = 1;
				}
				break;
			}
			switch (num)
			{
			case 0:
				break;
			case 1:
				if (((List)arrayList).size() > 0 && !java.lang.String.instancehelper_equals((string)((List)arrayList).get(((List)arrayList).size() - 1), ".."))
				{
					((List)arrayList).remove(((List)arrayList).size() - 1);
				}
				else
				{
					((List)arrayList).add((object)"..");
				}
				break;
			default:
				((List)arrayList).add((object)text);
				break;
			}
		}
		string text2 = Joiner.on('/').join(arrayList);
		if (java.lang.String.instancehelper_charAt(pathname, 0) == '/')
		{
			string text3 = java.lang.String.valueOf(text2);
			string text4;
			if (java.lang.String.instancehelper_length(text3) != 0)
			{
				text4 = java.lang.String.instancehelper_concat("/", text3);
			}
			else
			{
				string text5 = "/";
				text5 = text5;
				text4 = java.lang.String.newhelper(text5);
			}
			text2 = text4;
		}
		while (java.lang.String.instancehelper_startsWith(text2, "/../"))
		{
			text2 = java.lang.String.instancehelper_substring(text2, 3);
		}
		if (java.lang.String.instancehelper_equals(text2, "/.."))
		{
			text2 = "/";
		}
		else if (java.lang.String.instancehelper_equals("", text2))
		{
			text2 = ".";
		}
		return text2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 179, 103, 108, 105 })]
	public static string getFileExtension(string fullName)
	{
		Preconditions.checkNotNull(fullName);
		string name = new File(fullName).getName();
		int num = java.lang.String.instancehelper_lastIndexOf(name, 46);
		string result = ((num != -1) ? java.lang.String.instancehelper_substring(name, num + 1) : "");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 196, 103, 108, 105 })]
	public static string getNameWithoutExtension(string file)
	{
		Preconditions.checkNotNull(file);
		string name = new File(file).getName();
		int num = java.lang.String.instancehelper_lastIndexOf(name, 46);
		string result = ((num != -1) ? java.lang.String.instancehelper_substring(name, 0, num) : name);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/Traverser<Ljava/io/File;>;")]
	[LineNumberTable(852)]
	public static Traverser fileTraverser()
	{
		Traverser result = Traverser.forTree(FILE_TREE);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Predicate<Ljava/io/File;>;")]
	[LineNumberTable(877)]
	public static com.google.common.@base.Predicate isDirectory()
	{
		return FilePredicate.IS_DIRECTORY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Predicate<Ljava/io/File;>;")]
	[LineNumberTable(886)]
	public static com.google.common.@base.Predicate isFile()
	{
		return FilePredicate.IS_FILE;
	}

	[LineNumberTable(855)]
	static Files()
	{
		FILE_TREE = new _2();
	}
}
