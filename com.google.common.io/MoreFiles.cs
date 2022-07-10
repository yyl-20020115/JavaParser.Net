using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.graph;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.channels;
using java.nio.charset;
using java.nio.file;
using java.nio.file.attribute;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class MoreFiles : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/graph/SuccessorsFunction<Ljava/nio/file/Path;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _1 : java.lang.Object, SuccessorsFunction
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/nio/file/Path;)Ljava/lang/Iterable<Ljava/nio/file/Path;>;")]
		[LineNumberTable(302)]
		public virtual Iterable successors(Path P_0)
		{
			Iterable result = access_0024300(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(299)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(299)]
		public virtual Iterable successors(object P_0)
		{
			Iterable result = successors((Path)P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<Ljava/nio/file/Path;>;")]
	[EnclosingMethod(null, "isDirectory", "([Ljava.nio.file.LinkOption;)Lcom.google.common.base.Predicate;")]
	[Implements(new string[] { "com.google.common.base.Predicate" })]
	internal class _2 : java.lang.Object, com.google.common.@base.Predicate, java.util.function.Predicate
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkOption[] val_0024optionsCopy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(324)]
		internal _2(LinkOption[] P_0)
		{
			val_0024optionsCopy = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(327)]
		public virtual bool apply(Path P_0)
		{
			bool result = java.nio.file.Files.isDirectory(P_0, val_0024optionsCopy);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(332)]
		public override string toString()
		{
			string text = Arrays.toString(val_0024optionsCopy);
			int num = 23 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("MoreFiles.isDirectory(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(324)]
		public virtual bool apply(object P_0)
		{
			bool result = apply((Path)P_0);
			_ = null;
			return result;
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

		bool com.google.common.@base.Predicate.Predicate_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<Ljava/nio/file/Path;>;")]
	[EnclosingMethod(null, "isRegularFile", "([Ljava.nio.file.LinkOption;)Lcom.google.common.base.Predicate;")]
	[Implements(new string[] { "com.google.common.base.Predicate" })]
	internal class _3 : java.lang.Object, com.google.common.@base.Predicate, java.util.function.Predicate
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkOption[] val_0024optionsCopy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(351)]
		internal _3(LinkOption[] P_0)
		{
			val_0024optionsCopy = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(354)]
		public virtual bool apply(Path P_0)
		{
			bool result = java.nio.file.Files.isRegularFile(P_0, val_0024optionsCopy);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(359)]
		public override string toString()
		{
			string text = Arrays.toString(val_0024optionsCopy);
			int num = 25 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("MoreFiles.isRegularFile(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(351)]
		public virtual bool apply(object P_0)
		{
			bool result = apply((Path)P_0);
			_ = null;
			return result;
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

		bool com.google.common.@base.Predicate.Predicate_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class PathByteSink : ByteSink
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Path path;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private OpenOption[] options;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(206)]
		internal PathByteSink(Path P_0, OpenOption[] P_1, MoreFiles._1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 97, 104, 113, 145 })]
		private PathByteSink(Path P_0, params OpenOption[] P_1)
		{
			path = (Path)Preconditions.checkNotNull(P_0);
			options = (OpenOption[])P_1.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(219)]
		public override OutputStream openStream()
		{
			OutputStream result = java.nio.file.Files.newOutputStream(path, options);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(224)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(path);
			string text2 = Arrays.toString(options);
			int num = 24 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("MoreFiles.asByteSink(").append(text).append(", ")
				.append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class PathByteSource : ByteSource
	{
		[SpecialName]
		[EnclosingMethod(null, "asCharSource", "(Ljava.nio.charset.Charset;)Lcom.google.common.io.CharSource;")]
		internal class _1 : AsCharSource
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal new PathByteSource this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(174)]
			internal _1(PathByteSource P_0, Charset P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_0, P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.io.IOException" })]
			[Signature("()Ljava/util/stream/Stream<Ljava/lang/String;>;")]
			[LineNumberTable(178)]
			public override Stream lines()
			{
				Stream result = java.nio.file.Files.lines(access_0024100(this_00240), charset);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static LinkOption[] FOLLOW_LINKS;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Path path;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private OpenOption[] options;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private bool m_followLinks;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(90)]
		internal PathByteSource(Path P_0, OpenOption[] P_1, MoreFiles._1 P_2)
			: this(P_0, P_1)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(90)]
		internal static Path access_0024100(PathByteSource P_0)
		{
			return P_0.path;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 48, 104, 113, 113, 145 })]
		private PathByteSource(Path P_0, params OpenOption[] P_1)
		{
			path = (Path)Preconditions.checkNotNull(P_0);
			options = (OpenOption[])P_1.Clone();
			this.m_followLinks = followLinks(options);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 56, 111, 104, 2, 230, 69 })]
		private static bool followLinks(OpenOption[] P_0)
		{
			int num = P_0.Length;
			for (int i = 0; i < num; i++)
			{
				OpenOption openOption = P_0[i];
				if (openOption == LinkOption.NOFOLLOW_LINKS)
				{
					return false;
				}
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 70, 171, 253, 61 })]
		private BasicFileAttributes readAttributes()
		{
			BasicFileAttributes result = java.nio.file.Files.readAttributes(path, ClassLiteral<BasicFileAttributes>.Value, this.m_followLinks ? FOLLOW_LINKS : new LinkOption[1] { LinkOption.NOFOLLOW_LINKS });
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(116)]
		public override InputStream openStream()
		{
			InputStream result = java.nio.file.Files.newInputStream(path, options);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
		[LineNumberTable(new byte[] { 80, 210, 226, 61, 129, 230, 69, 112, 166 })]
		public override com.google.common.@base.Optional sizeIfKnown()
		{
			BasicFileAttributes basicFileAttributes;
			try
			{
				basicFileAttributes = readAttributes();
			}
			catch (IOException)
			{
				goto IL_000f;
			}
			if (basicFileAttributes.isDirectory() || basicFileAttributes.isSymbolicLink())
			{
				return com.google.common.@base.Optional.absent();
			}
			return com.google.common.@base.Optional.of(Long.valueOf(basicFileAttributes.size()));
			IL_000f:
			_ = null;
			return com.google.common.@base.Optional.absent();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 97, 199, 104, 112, 104, 176 })]
		public override long size()
		{
			BasicFileAttributes basicFileAttributes = readAttributes();
			if (basicFileAttributes.isDirectory())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException("can't read: is a directory");
			}
			if (basicFileAttributes.isSymbolicLink())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException("can't read: is a symbolic link");
			}
			long result = basicFileAttributes.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 112, 114, 127, 5, 41, 34 })]
		public override byte[] read()
		{
			SeekableByteChannel seekableByteChannel = java.nio.file.Files.newByteChannel(path, options);
			byte[] result;
			System.Exception ex;
			try
			{
				result = ByteStreams.toByteArray(Channels.newInputStream(seekableByteChannel), seekableByteChannel.size());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0033;
			}
			seekableByteChannel?.close();
			return result;
			IL_0033:
			System.Exception ex2 = ex;
			System.Exception ex3;
			if (seekableByteChannel != null)
			{
				try
				{
					seekableByteChannel.close();
				}
				catch (System.Exception x2)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
					goto IL_005b;
				}
			}
			goto IL_006b;
			IL_006b:
			throw Throwable.___003Cunmap_003E(ex2);
			IL_005b:
			System.Exception exception = ex3;
			Throwable.instancehelper_addSuppressed(ex2, exception);
			goto IL_006b;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 119, 233, 69, 234, 73 })]
		public override CharSource asCharSource(Charset P_0)
		{
			if (options.Length == 0)
			{
				_1 result = new _1(this, P_0);
				_ = null;
				return result;
			}
			CharSource result2 = base.asCharSource(P_0);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(188)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(path);
			string text2 = Arrays.toString(options);
			int num = 26 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("MoreFiles.asByteSource(").append(text).append(", ")
				.append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}

		[LineNumberTable(92)]
		static PathByteSource()
		{
			FOLLOW_LINKS = new LinkOption[0];
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/SuccessorsFunction<Ljava/nio/file/Path;>;")]
	private static SuccessorsFunction FILE_TREE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(74)]
	internal static Iterable access_0024300(Path P_0)
	{
		Iterable result = fileTreeChildren(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/nio/file/Path;)Ljava/lang/Iterable<Ljava/nio/file/Path;>;")]
	[LineNumberTable(new byte[] { 160, 193, 150, 124, 129, 172 })]
	private static Iterable fileTreeChildren(Path P_0)
	{
		//Discarded unreachable code: IL_001e
		if (java.nio.file.Files.isDirectory(P_0, LinkOption.NOFOLLOW_LINKS))
		{
			IOException ex;
			try
			{
				return listFiles(P_0);
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			IOException cause = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new DirectoryIteratorException(cause);
		}
		return ImmutableList.of();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(87)]
	public static ByteSource asByteSource(Path path, params OpenOption[] options)
	{
		PathByteSource result = new PathByteSource(path, options, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(203)]
	public static ByteSink asByteSink(Path path, params OpenOption[] options)
	{
		PathByteSink result = new PathByteSink(path, options, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/nio/file/Path;)Lcom/google/common/collect/ImmutableList<Ljava/nio/file/Path;>;")]
	[LineNumberTable(new byte[] { 160, 150, 103, 118, 63, 2, 38, 159, 77, 98 })]
	public static ImmutableList listFiles(Path dir)
	{
		DirectoryStream directoryStream;
		System.Exception ex;
		DirectoryIteratorException ex2;
		try
		{
			directoryStream = java.nio.file.Files.newDirectoryStream(dir);
			ImmutableList result;
			try
			{
				result = ImmutableList.copyOf(directoryStream);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto end_IL_0000;
			}
			if (directoryStream != null)
			{
				directoryStream.close();
				return result;
			}
			return result;
			end_IL_0000:;
		}
		catch (DirectoryIteratorException x2)
		{
			ex2 = ByteCodeHelper.MapException<DirectoryIteratorException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0038;
		}
		System.Exception ex3 = ex;
		System.Exception ex4;
		DirectoryIteratorException ex5;
		try
		{
			ex4 = ex3;
			if (directoryStream != null)
			{
				try
				{
					directoryStream.close();
				}
				catch (System.Exception x3)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
					goto IL_006f;
				}
			}
		}
		catch (DirectoryIteratorException x4)
		{
			ex5 = ByteCodeHelper.MapException<DirectoryIteratorException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0073;
		}
		goto IL_009a;
		IL_0038:
		DirectoryIteratorException ex6 = ex2;
		goto IL_00b0;
		IL_00b0:
		DirectoryIteratorException ex7 = ex6;
		throw Throwable.___003Cunmap_003E(ex7.getCause());
		IL_0073:
		ex6 = ex5;
		goto IL_00b0;
		IL_006f:
		System.Exception ex8 = ex3;
		DirectoryIteratorException ex9;
		try
		{
			System.Exception exception = ex8;
			Throwable.instancehelper_addSuppressed(ex4, exception);
		}
		catch (DirectoryIteratorException x5)
		{
			ex9 = ByteCodeHelper.MapException<DirectoryIteratorException>(x5, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0096;
		}
		goto IL_009a;
		IL_0096:
		ex6 = ex9;
		goto IL_00b0;
		IL_009a:
		DirectoryIteratorException ex10;
		try
		{
			throw Throwable.___003Cunmap_003E(ex4);
		}
		catch (DirectoryIteratorException x6)
		{
			ex10 = ByteCodeHelper.MapException<DirectoryIteratorException>(x6, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ex6 = ex10;
		goto IL_00b0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 95, 167, 227, 70, 194, 232, 76, 162 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Path getParentPath(Path P_0)
	{
		Path parent = P_0.getParent();
		if (parent != null)
		{
			return parent;
		}
		if (P_0.getNameCount() == 0)
		{
			return null;
		}
		Path path = P_0.getFileSystem().getPath(".");
		_ = null;
		return path;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/nio/file/SecureDirectoryStream<Ljava/nio/file/Path;>;Ljava/nio/file/Path;)Ljava/util/Collection<Ljava/io/IOException;>;")]
	[LineNumberTable(new byte[]
	{
		162,
		1,
		130,
		119,
		118,
		118,
		31,
		16,
		byte.MaxValue,
		83,
		70,
		99,
		187,
		187,
		98,
		98
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Collection deleteRecursivelySecure(SecureDirectoryStream P_0, Path P_1)
	{
		Collection collection = null;
		SecureDirectoryStream secureDirectoryStream;
		System.Exception ex;
		IOException ex2;
		try
		{
			if (isDirectory(P_0, P_1, LinkOption.NOFOLLOW_LINKS))
			{
				secureDirectoryStream = P_0.newDirectoryStream(P_1, LinkOption.NOFOLLOW_LINKS);
				try
				{
					collection = deleteDirectoryContentsSecure(secureDirectoryStream);
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_0062;
				}
				secureDirectoryStream?.close();
				goto IL_00e6;
			}
		}
		catch (IOException x2)
		{
			ex2 = ByteCodeHelper.MapException<IOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_006a;
		}
		IOException ex3;
		try
		{
			P_0.deleteFile(P_1);
			return collection;
		}
		catch (IOException x3)
		{
			ex3 = ByteCodeHelper.MapException<IOException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException ex4 = ex3;
		goto IL_0121;
		IL_006a:
		ex4 = ex2;
		goto IL_0121;
		IL_00c9:
		IOException ex5;
		ex4 = ex5;
		goto IL_0121;
		IL_00d0:
		System.Exception ex6;
		IOException ex7;
		try
		{
			throw Throwable.___003Cunmap_003E(ex6);
		}
		catch (IOException x4)
		{
			ex7 = ByteCodeHelper.MapException<IOException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ex4 = ex7;
		goto IL_0121;
		IL_00e6:
		IOException ex8;
		try
		{
			if (collection == null)
			{
				P_0.deleteDirectory(P_1);
				return collection;
			}
			return collection;
		}
		catch (IOException x5)
		{
			ex8 = ByteCodeHelper.MapException<IOException>(x5, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ex4 = ex8;
		goto IL_0121;
		IL_0121:
		IOException ex9 = ex4;
		return addException(collection, ex9);
		IL_0062:
		System.Exception ex10 = ex;
		IOException ex11;
		try
		{
			ex6 = ex10;
			if (secureDirectoryStream != null)
			{
				try
				{
					secureDirectoryStream.close();
				}
				catch (System.Exception x6)
				{
					ex10 = ByteCodeHelper.MapException<System.Exception>(x6, ByteCodeHelper.MapFlags.None);
					goto IL_009f;
				}
			}
		}
		catch (IOException x7)
		{
			ex11 = ByteCodeHelper.MapException<IOException>(x7, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00a3;
		}
		goto IL_00d0;
		IL_00a3:
		ex4 = ex11;
		goto IL_0121;
		IL_009f:
		System.Exception ex12 = ex10;
		try
		{
			System.Exception exception = ex12;
			Throwable.instancehelper_addSuppressed(ex6, exception);
		}
		catch (IOException x8)
		{
			ex5 = ByteCodeHelper.MapException<IOException>(x8, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00c9;
		}
		goto IL_00d0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "com.google.common.io.InsecureRecursiveDeleteException" })]
	[LineNumberTable(new byte[] { 162, 130, 114, 145 })]
	private static void checkAllowsInsecure(Path P_0, RecursiveDeleteOption[] P_1)
	{
		if (!Arrays.asList(P_1).contains(RecursiveDeleteOption.___003C_003EALLOW_INSECURE))
		{
			string file = P_0.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new InsecureRecursiveDeleteException(file);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/nio/file/Path;)Ljava/util/Collection<Ljava/io/IOException;>;")]
	[LineNumberTable(new byte[]
	{
		162,
		48,
		130,
		118,
		103,
		118,
		31,
		9,
		byte.MaxValue,
		80,
		71,
		99,
		166,
		124,
		98
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Collection deleteRecursivelyInsecure(Path P_0)
	{
		//Discarded unreachable code: IL_00d8
		Collection collection = null;
		DirectoryStream directoryStream;
		System.Exception ex;
		IOException ex2;
		try
		{
			if (java.nio.file.Files.isDirectory(P_0, LinkOption.NOFOLLOW_LINKS))
			{
				directoryStream = java.nio.file.Files.newDirectoryStream(P_0);
				try
				{
					collection = deleteDirectoryContentsInsecure(directoryStream);
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_0050;
				}
				directoryStream?.close();
			}
		}
		catch (IOException x2)
		{
			ex2 = ByteCodeHelper.MapException<IOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0053;
		}
		IOException ex3;
		try
		{
			if (collection == null)
			{
				java.nio.file.Files.delete(P_0);
			}
			return collection;
		}
		catch (IOException x3)
		{
			ex3 = ByteCodeHelper.MapException<IOException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException ex4 = ex3;
		goto IL_00f1;
		IL_0053:
		ex4 = ex2;
		goto IL_00f1;
		IL_00b2:
		IOException ex5;
		ex4 = ex5;
		goto IL_00f1;
		IL_00b6:
		System.Exception ex6;
		IOException ex7;
		try
		{
			throw Throwable.___003Cunmap_003E(ex6);
		}
		catch (IOException x4)
		{
			ex7 = ByteCodeHelper.MapException<IOException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ex4 = ex7;
		goto IL_00f1;
		IL_00f1:
		IOException ex8 = ex4;
		return addException(collection, ex8);
		IL_0050:
		System.Exception ex9 = ex;
		IOException ex10;
		try
		{
			ex6 = ex9;
			if (directoryStream != null)
			{
				try
				{
					directoryStream.close();
				}
				catch (System.Exception x5)
				{
					ex9 = ByteCodeHelper.MapException<System.Exception>(x5, ByteCodeHelper.MapFlags.None);
					goto IL_0088;
				}
			}
		}
		catch (IOException x6)
		{
			ex10 = ByteCodeHelper.MapException<IOException>(x6, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_008c;
		}
		goto IL_00b6;
		IL_008c:
		ex4 = ex10;
		goto IL_00f1;
		IL_0088:
		System.Exception ex11 = ex9;
		try
		{
			System.Exception exception = ex11;
			Throwable.instancehelper_addSuppressed(ex6, exception);
		}
		catch (IOException x7)
		{
			ex5 = ByteCodeHelper.MapException<IOException>(x7, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00b2;
		}
		goto IL_00b6;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.nio.file.FileSystemException" })]
	[Signature("(Ljava/nio/file/Path;Ljava/util/Collection<Ljava/io/IOException;>;)V")]
	[LineNumberTable(new byte[]
	{
		162, 175, 104, 99, 231, 69, 129, 177, 123, 103,
		98
	})]
	private static void throwDeleteFailed(Path P_0, Collection P_1)
	{
		NoSuchFileException ex = pathNotFound(P_0, P_1);
		if (ex != null)
		{
			throw Throwable.___003Cunmap_003E(ex);
		}
		FileSystemException ex2 = new FileSystemException(P_0.toString(), null, "failed to delete one or more files; see suppressed exceptions for details");
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			IOException exception = (IOException)iterator.next();
			Throwable.instancehelper_addSuppressed(ex2, exception);
		}
		throw Throwable.___003Cunmap_003E(ex2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/nio/file/SecureDirectoryStream<Ljava/nio/file/Path;>;)Ljava/util/Collection<Ljava/io/IOException;>;")]
	[LineNumberTable(new byte[] { 162, 30, 130, 123, 115, 130, 121, 98 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Collection deleteDirectoryContentsSecure(SecureDirectoryStream P_0)
	{
		//Discarded unreachable code: IL_0035
		Collection collection = null;
		DirectoryIteratorException ex;
		try
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				Path path = (Path)iterator.next();
				collection = concat(collection, deleteRecursivelySecure(P_0, path.getFileName()));
			}
			return collection;
		}
		catch (DirectoryIteratorException x)
		{
			ex = ByteCodeHelper.MapException<DirectoryIteratorException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		DirectoryIteratorException ex2 = ex;
		return addException(collection, ex2.getCause());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/nio/file/DirectoryStream<Ljava/nio/file/Path;>;)Ljava/util/Collection<Ljava/io/IOException;>;")]
	[LineNumberTable(new byte[] { 162, 76, 130, 123, 109, 130, 121, 98 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Collection deleteDirectoryContentsInsecure(DirectoryStream P_0)
	{
		//Discarded unreachable code: IL_002f
		Collection collection = null;
		DirectoryIteratorException ex;
		try
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				Path path = (Path)iterator.next();
				collection = concat(collection, deleteRecursivelyInsecure(path));
			}
			return collection;
		}
		catch (DirectoryIteratorException x)
		{
			ex = ByteCodeHelper.MapException<DirectoryIteratorException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		DirectoryIteratorException ex2 = ex;
		return addException(collection, ex2.getCause());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/nio/file/SecureDirectoryStream<Ljava/nio/file/Path;>;Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Z")]
	[LineNumberTable(new byte[] { 160, 226, 114, 101, 7 })]
	private static bool isDirectory(SecureDirectoryStream P_0, Path P_1, params LinkOption[] P_2)
	{
		bool result = ((BasicFileAttributeView)P_0.getFileAttributeView(P_1, ClassLiteral<BasicFileAttributeView>.Value, P_2)).readAttributes().isDirectory();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<Ljava/io/IOException;>;Ljava/io/IOException;)Ljava/util/Collection<Ljava/io/IOException;>;")]
	[LineNumberTable(new byte[] { 158, 207, 162, 104, 134, 125 })]
	private static Collection addException([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Collection P_0, IOException P_1)
	{
		object obj = P_0;
		if ((Collection)obj == null)
		{
			obj = new ArrayList();
		}
		object obj2 = obj;
		((obj2 == null) ? null : ((obj2 as Collection) ?? throw new java.lang.IncompatibleClassChangeError())).add(P_1);
		object obj3 = obj;
		return (obj3 == null) ? null : ((obj3 as Collection) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<Ljava/io/IOException;>;Ljava/util/Collection<Ljava/io/IOException;>;)Ljava/util/Collection<Ljava/io/IOException;>;")]
	[LineNumberTable(new byte[] { 162, 157, 99, 98, 99, 136 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Collection concat([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Collection P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Collection P_1)
	{
		if (P_0 == null)
		{
			return P_1;
		}
		if (P_1 != null)
		{
			P_0.addAll(P_1);
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/nio/file/Path;Ljava/util/Collection<Ljava/io/IOException;>;)Ljava/nio/file/NoSuchFileException;")]
	[LineNumberTable(new byte[]
	{
		162, 195, 105, 130, 108, 104, 130, 103, 103, 227,
		69, 130, 103, 227, 84, 162, 120, 111, 130
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static NoSuchFileException pathNotFound(Path P_0, Collection P_1)
	{
		if (P_1.size() != 1)
		{
			return null;
		}
		IOException ex = (IOException)Iterables.getOnlyElement(P_1);
		if (!(ex is NoSuchFileException))
		{
			return null;
		}
		NoSuchFileException ex2 = (NoSuchFileException)ex;
		string file = ex2.getFile();
		if (file == null)
		{
			return null;
		}
		Path parentPath = getParentPath(P_0);
		if (parentPath == null)
		{
			return null;
		}
		Path path = parentPath.resolve((Path)java.util.Objects.requireNonNull(P_0.getFileName()));
		if (java.lang.String.instancehelper_equals(file, path.toString()))
		{
			return ex2;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	private MoreFiles()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(238)]
	public static CharSource asCharSource(Path path, Charset charset, params OpenOption[] options)
	{
		CharSource result = asByteSource(path, options).asCharSource(charset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(252)]
	public static CharSink asCharSink(Path path, Charset charset, params OpenOption[] options)
	{
		CharSink result = asByteSink(path, options).asCharSink(charset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/Traverser<Ljava/nio/file/Path;>;")]
	[LineNumberTable(295)]
	public static Traverser fileTraverser()
	{
		Traverser result = Traverser.forTree(FILE_TREE);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Ljava/nio/file/LinkOption;)Lcom/google/common/base/Predicate<Ljava/nio/file/Path;>;")]
	[LineNumberTable(new byte[] { 160, 209, 108 })]
	public static com.google.common.@base.Predicate isDirectory(params LinkOption[] options)
	{
		LinkOption[] array = (LinkOption[])options.Clone();
		_2 result = new _2(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Ljava/nio/file/LinkOption;)Lcom/google/common/base/Predicate<Ljava/nio/file/Path;>;")]
	[LineNumberTable(new byte[] { 160, 236, 108 })]
	public static com.google.common.@base.Predicate isRegularFile(params LinkOption[] options)
	{
		LinkOption[] array = (LinkOption[])options.Clone();
		_3 result = new _3(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 2, 103, 103, 105, 226, 72, 109, 109, 125,
		125, 110, 130
	})]
	public static bool equal(Path path1, Path path2)
	{
		Preconditions.checkNotNull(path1);
		Preconditions.checkNotNull(path2);
		if (java.nio.file.Files.isSameFile(path1, path2))
		{
			return true;
		}
		ByteSource byteSource = asByteSource(path1);
		ByteSource byteSource2 = asByteSource(path2);
		long num = ((Long)byteSource.sizeIfKnown().or(Long.valueOf(0L))).longValue();
		long num2 = ((Long)byteSource2.sizeIfKnown().or(Long.valueOf(0L))).longValue();
		if (num != 0 && num2 != 0 && num != num2)
		{
			return false;
		}
		bool result = byteSource.contentEquals(byteSource2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 29, 167, 252, 76, 226, 53, 129, 248, 72,
		226, 57, 225, 73
	})]
	public static void touch(Path path)
	{
		Preconditions.checkNotNull(path);
		try
		{
			java.nio.file.Files.setLastModifiedTime(path, FileTime.fromMillis(java.lang.System.currentTimeMillis()));
			return;
		}
		catch (NoSuchFileException)
		{
		}
		_ = null;
		try
		{
			java.nio.file.Files.createFile(path);
			return;
		}
		catch (FileAlreadyExistsException)
		{
		}
		_ = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute<*>;)V")]
	[LineNumberTable(new byte[]
	{
		161, 61, 108, 103, 227, 69, 225, 71, 110, 104,
		110, 191, 31
	})]
	public static void createParentDirectories(Path path, params FileAttribute[] attrs)
	{
		Path path2 = path.toAbsolutePath().normalize();
		Path parent = path2.getParent();
		if (parent != null && !java.nio.file.Files.isDirectory(parent))
		{
			java.nio.file.Files.createDirectories(parent, attrs);
			if (!java.nio.file.Files.isDirectory(parent))
			{
				string text = java.lang.String.valueOf(path);
				int num = 39 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				string message = new StringBuilder(num).append("Unable to create parent directories of ").append(text).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException(message);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 96, 167, 99, 166, 103, 105 })]
	public static string getFileExtension(Path path)
	{
		Path fileName = path.getFileName();
		if (fileName == null)
		{
			return "";
		}
		string @this = fileName.toString();
		int num = java.lang.String.instancehelper_lastIndexOf(@this, 46);
		string result = ((num != -1) ? java.lang.String.instancehelper_substring(@this, num + 1) : "");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 114, 167, 99, 166, 103, 105 })]
	public static string getNameWithoutExtension(Path path)
	{
		Path fileName = path.getFileName();
		if (fileName == null)
		{
			return "";
		}
		string text = fileName.toString();
		int num = java.lang.String.instancehelper_lastIndexOf(text, 46);
		string result = ((num != -1) ? java.lang.String.instancehelper_substring(text, 0, num) : text);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161,
		156,
		103,
		99,
		183,
		130,
		98,
		103,
		104,
		98,
		231,
		71,
		239,
		58,
		246,
		72,
		byte.MaxValue,
		12,
		52,
		byte.MaxValue,
		80,
		78,
		99,
		103,
		251,
		72,
		226,
		58,
		98,
		99,
		136,
		201,
		99,
		135
	})]
	public static void deleteRecursively(Path path, params RecursiveDeleteOption[] options)
	{
		Path parentPath = getParentPath(path);
		if (parentPath == null)
		{
			string file = path.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new FileSystemException(file, null, "can't delete recursively");
		}
		Collection collection = null;
		int num;
		DirectoryStream directoryStream;
		System.Exception ex;
		IOException ex2;
		try
		{
			num = 0;
			directoryStream = java.nio.file.Files.newDirectoryStream(parentPath);
			try
			{
				if (directoryStream is SecureDirectoryStream)
				{
					num = 1;
					collection = deleteRecursivelySecure((SecureDirectoryStream)directoryStream, (Path)java.util.Objects.requireNonNull(path.getFileName()));
				}
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto end_IL_0023;
			}
			directoryStream?.close();
			goto IL_00fc;
			end_IL_0023:;
		}
		catch (IOException x2)
		{
			ex2 = ByteCodeHelper.MapException<IOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0082;
		}
		System.Exception ex3 = ex;
		System.Exception ex4;
		IOException ex5;
		try
		{
			ex4 = ex3;
			if (directoryStream != null)
			{
				try
				{
					directoryStream.close();
				}
				catch (System.Exception x3)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
					goto IL_00b8;
				}
			}
		}
		catch (IOException x4)
		{
			ex5 = ByteCodeHelper.MapException<IOException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00bc;
		}
		goto IL_00e6;
		IL_00e6:
		IOException ex6;
		try
		{
			throw Throwable.___003Cunmap_003E(ex4);
		}
		catch (IOException x5)
		{
			ex6 = ByteCodeHelper.MapException<IOException>(x5, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException ex7 = ex6;
		goto IL_0123;
		IL_0139:
		if (collection != null)
		{
			throwDeleteFailed(path, collection);
		}
		return;
		IL_0082:
		ex7 = ex2;
		goto IL_0123;
		IL_00fc:
		IOException ex8;
		try
		{
			if (num == 0)
			{
				checkAllowsInsecure(path, options);
				collection = deleteRecursivelyInsecure(path);
			}
		}
		catch (IOException x6)
		{
			ex8 = ByteCodeHelper.MapException<IOException>(x6, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_011d;
		}
		goto IL_0139;
		IL_011d:
		ex7 = ex8;
		goto IL_0123;
		IL_0123:
		IOException ex9 = ex7;
		if (collection == null)
		{
			throw Throwable.___003Cunmap_003E(ex9);
		}
		collection.add(ex9);
		goto IL_0139;
		IL_00bc:
		ex7 = ex5;
		goto IL_0123;
		IL_00b8:
		System.Exception ex10 = ex3;
		IOException ex11;
		try
		{
			System.Exception exception = ex10;
			Throwable.instancehelper_addSuppressed(ex4, exception);
		}
		catch (IOException x7)
		{
			ex11 = ByteCodeHelper.MapException<IOException>(x7, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00e2;
		}
		goto IL_00e6;
		IL_00e2:
		ex7 = ex11;
		goto IL_0123;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161,
		228,
		98,
		103,
		104,
		103,
		103,
		98,
		103,
		150,
		byte.MaxValue,
		11,
		56,
		byte.MaxValue,
		77,
		78,
		226,
		58,
		98,
		99,
		136,
		201,
		99,
		135
	})]
	public static void deleteDirectoryContents(Path path, params RecursiveDeleteOption[] options)
	{
		Collection collection = null;
		DirectoryStream directoryStream;
		System.Exception ex;
		IOException ex2;
		try
		{
			directoryStream = java.nio.file.Files.newDirectoryStream(path);
			try
			{
				if (directoryStream is SecureDirectoryStream)
				{
					SecureDirectoryStream secureDirectoryStream = (SecureDirectoryStream)directoryStream;
					collection = deleteDirectoryContentsSecure(secureDirectoryStream);
				}
				else
				{
					checkAllowsInsecure(path, options);
					collection = deleteDirectoryContentsInsecure(directoryStream);
				}
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto end_IL_0002;
			}
			directoryStream?.close();
			goto IL_00ec;
			end_IL_0002:;
		}
		catch (IOException x2)
		{
			ex2 = ByteCodeHelper.MapException<IOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_005d;
		}
		System.Exception ex3 = ex;
		System.Exception ex4;
		IOException ex5;
		try
		{
			ex4 = ex3;
			if (directoryStream != null)
			{
				try
				{
					directoryStream.close();
				}
				catch (System.Exception x3)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
					goto IL_0093;
				}
			}
		}
		catch (IOException x4)
		{
			ex5 = ByteCodeHelper.MapException<IOException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0097;
		}
		goto IL_00be;
		IL_005d:
		IOException ex6 = ex2;
		goto IL_00d6;
		IL_00d6:
		IOException ex7 = ex6;
		if (collection == null)
		{
			throw Throwable.___003Cunmap_003E(ex7);
		}
		collection.add(ex7);
		goto IL_00ec;
		IL_0097:
		ex6 = ex5;
		goto IL_00d6;
		IL_0093:
		System.Exception ex8 = ex3;
		IOException ex9;
		try
		{
			System.Exception exception = ex8;
			Throwable.instancehelper_addSuppressed(ex4, exception);
		}
		catch (IOException x5)
		{
			ex9 = ByteCodeHelper.MapException<IOException>(x5, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_00ba;
		}
		goto IL_00be;
		IL_00ba:
		ex6 = ex9;
		goto IL_00d6;
		IL_00be:
		IOException ex10;
		try
		{
			throw Throwable.___003Cunmap_003E(ex4);
		}
		catch (IOException x6)
		{
			ex10 = ByteCodeHelper.MapException<IOException>(x6, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ex6 = ex10;
		goto IL_00d6;
		IL_00ec:
		if (collection != null)
		{
			throwDeleteFailed(path, collection);
		}
	}

	[LineNumberTable(298)]
	static MoreFiles()
	{
		FILE_TREE = new _1();
	}
}
