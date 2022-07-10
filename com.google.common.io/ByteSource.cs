using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.hash;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.charset;
using java.util;

namespace com.google.common.io;

[ConstantPool(new object[]
{
	(byte)126,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public abstract class ByteSource : java.lang.Object
{
	internal class AsCharSource : CharSource
	{
		[Modifiers(Modifiers.Final)]
		internal Charset charset;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ByteSource this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 90, 111, 113 })]
		internal AsCharSource(ByteSource P_0, Charset P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			charset = (Charset)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 96, 110, 135 })]
		public override ByteSource asByteSource(Charset P_0)
		{
			if (P_0.equals(charset))
			{
				return this_00240;
			}
			ByteSource result = base.asByteSource(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(474)]
		public override Reader openStream()
		{
			InputStreamReader result = new InputStreamReader(this_00240.openStream(), charset);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(486)]
		public override string read()
		{
			string result = java.lang.String.newhelper(this_00240.read(), charset);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(491)]
		public override string toString()
		{
			string text = java.lang.Object.instancehelper_toString(this_00240);
			string text2 = java.lang.String.valueOf(charset);
			int num = 15 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".asCharSource(").append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[ConstantPool(new object[]
	{
		(byte)74,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ByteArrayByteSource : ByteSource
	{
		[Modifiers(Modifiers.Final)]
		internal byte[] bytes;

		[Modifiers(Modifiers.Final)]
		internal int offset;

		[Modifiers(Modifiers.Final)]
		internal int length;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 211, 108 })]
		internal ByteArrayByteSource(byte[] P_0)
			: this(P_0, 0, P_0.Length)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 215, 104, 103, 103, 103 })]
		internal ByteArrayByteSource(byte[] P_0, int P_1, int P_2)
		{
			bytes = P_0;
			offset = P_1;
			length = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(593)]
		public override InputStream openStream()
		{
			ByteArrayInputStream result = new ByteArrayInputStream(bytes, offset, length);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(598)]
		public override InputStream openBufferedStream()
		{
			InputStream result = openStream();
			_ = null;
			return result;
		}

		public override bool isEmpty()
		{
			return (length == 0) ? true : false;
		}

		public override long size()
		{
			return length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
		[LineNumberTable(613)]
		public override com.google.common.@base.Optional sizeIfKnown()
		{
			com.google.common.@base.Optional result = com.google.common.@base.Optional.of(Long.valueOf(length));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(618)]
		public override byte[] read()
		{
			byte[] result = Arrays.copyOfRange(bytes, offset, offset + length);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/io/ByteProcessor<TT;>;)TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 74, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			161,
			byte.MaxValue,
			121
		})]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/io/ParametricNullness;"
		})]
		public override object read(ByteProcessor P_0)
		{
			P_0.processBytes(bytes, offset, length);
			object result = P_0.getResult();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 5, 120 })]
		public override long copyTo(OutputStream P_0)
		{
			P_0.write(bytes, offset, length);
			return length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(637)]
		public override HashCode hash(HashFunction P_0)
		{
			HashCode result = P_0.hashBytes(bytes, offset, length);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 16, 115, 147, 111, 113, 106 })]
		public override ByteSource slice(long P_0, long P_1)
		{
			Preconditions.checkArgument(P_0 >= 0, "offset (%s) may not be negative", P_0);
			Preconditions.checkArgument(P_1 >= 0, "length (%s) may not be negative", P_1);
			P_0 = java.lang.Math.min(P_0, length);
			P_1 = java.lang.Math.min(P_1, length - P_0);
			int num = offset + (int)P_0;
			ByteArrayByteSource result = new ByteArrayByteSource(bytes, num, (int)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 28, 63, 89 })]
		public override string toString()
		{
			string __003Cref_003E = BaseEncoding.base16().encode(bytes, offset, length);
			string truncationIndicator = "...";
			int maxLength = 30;
			CharSequence seq = default(CharSequence);
			object obj = (seq.___003Cref_003E = __003Cref_003E);
			string text = Ascii.truncate(seq, maxLength, truncationIndicator);
			maxLength = 17 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			maxLength = maxLength;
			string result = new StringBuilder(maxLength).append("ByteSource.wrap(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ConcatenatedByteSource : ByteSource
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/lang/Iterable<+Lcom/google/common/io/ByteSource;>;")]
		internal Iterable sources;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Lcom/google/common/io/ByteSource;>;)V")]
		[LineNumberTable(new byte[] { 162, 62, 104, 113 })]
		internal ConcatenatedByteSource(Iterable P_0)
		{
			sources = (Iterable)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(694)]
		public override InputStream openStream()
		{
			MultiInputStream result = new MultiInputStream(sources.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 73, 127, 1, 104, 130, 98 })]
		public override bool isEmpty()
		{
			Iterator iterator = sources.iterator();
			while (iterator.hasNext())
			{
				ByteSource byteSource = (ByteSource)iterator.next();
				if (!byteSource.isEmpty())
				{
					return false;
				}
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
		[LineNumberTable(new byte[]
		{
			162, 83, 237, 70, 136, 99, 127, 1, 103, 104,
			136, 115, 229, 70, 150, 101
		})]
		public override com.google.common.@base.Optional sizeIfKnown()
		{
			if (!(sources is Collection))
			{
				com.google.common.@base.Optional result = com.google.common.@base.Optional.absent();
				_ = null;
				return result;
			}
			long num = 0L;
			Iterator iterator = sources.iterator();
			while (iterator.hasNext())
			{
				ByteSource byteSource = (ByteSource)iterator.next();
				com.google.common.@base.Optional optional = byteSource.sizeIfKnown();
				if (!optional.isPresent())
				{
					com.google.common.@base.Optional result2 = com.google.common.@base.Optional.absent();
					_ = null;
					return result2;
				}
				num += ((Long)optional.get()).longValue();
				if (num < 0)
				{
					com.google.common.@base.Optional result3 = com.google.common.@base.Optional.of(Long.valueOf(long.MaxValue));
					_ = null;
					return result3;
				}
			}
			com.google.common.@base.Optional result4 = com.google.common.@base.Optional.of(Long.valueOf(num));
			_ = null;
			return result4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 112, 99, 127, 1, 105, 229, 70, 138, 98 })]
		public override long size()
		{
			long num = 0L;
			Iterator iterator = sources.iterator();
			while (iterator.hasNext())
			{
				ByteSource byteSource = (ByteSource)iterator.next();
				num += byteSource.size();
				if (num < 0)
				{
					return long.MaxValue;
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(755)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(sources);
			int num = 19 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("ByteSource.concat(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class EmptyByteSource : ByteArrayByteSource
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static EmptyByteSource INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 38, 110 })]
		internal EmptyByteSource()
			: base(new byte[0])
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 43, 103 })]
		public override CharSource asCharSource(Charset P_0)
		{
			Preconditions.checkNotNull(P_0);
			CharSource result = CharSource.empty();
			_ = null;
			return result;
		}

		public override byte[] read()
		{
			return bytes;
		}

		public override string toString()
		{
			return "ByteSource.empty()";
		}

		[LineNumberTable(661)]
		static EmptyByteSource()
		{
			INSTANCE = new EmptyByteSource();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class SlicedByteSource : ByteSource
	{
		[Modifiers(Modifiers.Final)]
		internal long offset;

		[Modifiers(Modifiers.Final)]
		internal long length;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ByteSource this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 131, 111, 115, 115, 103, 103 })]
		internal SlicedByteSource(ByteSource P_0, long P_1, long P_2)
		{
			this_00240 = P_0;
			base._002Ector();
			Preconditions.checkArgument(P_1 >= 0, "offset (%s) may not be negative", P_1);
			Preconditions.checkArgument(P_2 >= 0, "length (%s) may not be negative", P_2);
			offset = P_1;
			length = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[]
		{
			161,
			149,
			173,
			byte.MaxValue,
			0,
			73,
			226,
			56,
			97,
			102,
			136,
			141,
			102,
			161,
			137,
			102,
			172
		})]
		private InputStream sliceStream(InputStream P_0)
		{
			System.Exception ex;
			if (offset > 0)
			{
				long num;
				try
				{
					num = ByteStreams.skipUpTo(P_0, offset);
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_0029;
				}
				if (num < offset)
				{
					P_0.close();
					return new ByteArrayInputStream(new byte[0]);
				}
			}
			return ByteStreams.limit(P_0, length);
			IL_0029:
			System.Exception e = ex;
			Closer closer = Closer.create();
			closer.register(P_0);
			try
			{
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
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(510)]
		public override InputStream openStream()
		{
			InputStream result = sliceStream(this_00240.openStream());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(515)]
		public override InputStream openBufferedStream()
		{
			InputStream result = sliceStream(this_00240.openBufferedStream());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 174, 115, 115, 105, 101, 103, 28 })]
		public override ByteSource slice(long P_0, long P_1)
		{
			Preconditions.checkArgument(P_0 >= 0, "offset (%s) may not be negative", P_0);
			Preconditions.checkArgument(P_1 >= 0, "length (%s) may not be negative", P_1);
			long num = length - P_0;
			ByteSource result = ((num > 0) ? this_00240.slice(offset + P_0, java.lang.Math.min(P_1, num)) : empty());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(554)]
		public override bool isEmpty()
		{
			return (length == 0 || base.isEmpty()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
		[LineNumberTable(new byte[] { 161, 189, 108, 104, 113, 109, 155 })]
		public override com.google.common.@base.Optional sizeIfKnown()
		{
			com.google.common.@base.Optional optional = this_00240.sizeIfKnown();
			if (optional.isPresent())
			{
				long num = ((Long)optional.get()).longValue();
				long num2 = java.lang.Math.min(offset, num);
				com.google.common.@base.Optional result = com.google.common.@base.Optional.of(Long.valueOf(java.lang.Math.min(length, num - num2)));
				_ = null;
				return result;
			}
			com.google.common.@base.Optional result2 = com.google.common.@base.Optional.absent();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(570)]
		public override string toString()
		{
			string text = java.lang.Object.instancehelper_toString(this_00240);
			long lng = offset;
			long lng2 = length;
			int num = 50 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append(text).append(".slice(").append(lng)
				.append(", ")
				.append(lng2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[Throws(new string[] { "java.io.IOException" })]
	public abstract InputStream openStream();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
	[LineNumberTable(183)]
	public virtual com.google.common.@base.Optional sizeIfKnown()
	{
		com.google.common.@base.Optional result = com.google.common.@base.Optional.absent();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 120, 131, 114, 134 })]
	private long countBySkipping(InputStream P_0)
	{
		long num = 0L;
		long num2;
		while ((num2 = ByteStreams.skipUpTo(P_0, 2147483647L)) > 0)
		{
			num += num2;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 138, 135, 134, 114, 213, 102, 38, 230, 60,
		102, 98, 142, 102
	})]
	public virtual long copyTo(OutputStream output)
	{
		Preconditions.checkNotNull(output);
		Closer closer = Closer.create();
		long result;
		System.Exception ex;
		try
		{
			try
			{
				InputStream from = (InputStream)closer.register(openStream());
				result = ByteStreams.copy(from, output);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_003d;
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
		IL_003d:
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
	[Signature("(Ljava/lang/Iterable<+Lcom/google/common/io/ByteSource;>;)Lcom/google/common/io/ByteSource;")]
	[LineNumberTable(388)]
	public static ByteSource concat(Iterable sources)
	{
		ConcatenatedByteSource result = new ConcatenatedByteSource(sources);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(81)]
	protected internal ByteSource()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(93)]
	public virtual CharSource asCharSource(Charset charset)
	{
		AsCharSource result = new AsCharSource(this, charset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 69, 103, 104, 104, 8 })]
	public virtual InputStream openBufferedStream()
	{
		InputStream inputStream = openStream();
		BufferedInputStream result = ((!(inputStream is BufferedInputStream)) ? new BufferedInputStream(inputStream) : ((BufferedInputStream)inputStream));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(135)]
	public virtual ByteSource slice(long offset, long length)
	{
		SlicedByteSource result = new SlicedByteSource(this, offset, length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		102, 103, 104, 149, 134, 114, 216, 102, 39, 230,
		60, 102, 98, 142, 102
	})]
	public virtual bool isEmpty()
	{
		com.google.common.@base.Optional optional = sizeIfKnown();
		if (optional.isPresent())
		{
			return ((Long)optional.get()).longValue() == 0;
		}
		Closer closer = Closer.create();
		int result;
		System.Exception ex;
		try
		{
			try
			{
				InputStream inputStream = (InputStream)closer.register(openStream());
				result = ((inputStream.read() == -1) ? 1 : 0);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_005d;
			}
		}
		catch
		{
			//try-fault
			closer.close();
			throw;
		}
		closer.close();
		return (byte)result != 0;
		IL_005d:
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
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 92, 103, 104, 177, 134, 114, 206, 102, 38,
		230, 60, 98, 161, 102, 130, 134, 114, 213, 102,
		39, 230, 60, 102, 98, 142, 102
	})]
	public virtual long size()
	{
		com.google.common.@base.Optional optional = sizeIfKnown();
		if (optional.isPresent())
		{
			return ((Long)optional.get()).longValue();
		}
		Closer closer = Closer.create();
		long result;
		try
		{
			try
			{
				InputStream inputStream = (InputStream)closer.register(openStream());
				result = countBySkipping(inputStream);
			}
			catch (IOException)
			{
				goto IL_004f;
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
		IL_004f:
		_ = null;
		closer.close();
		closer = Closer.create();
		System.Exception ex2;
		try
		{
			try
			{
				InputStream inputStream = (InputStream)closer.register(openStream());
				result = ByteStreams.exhaust(inputStream);
			}
			catch (System.Exception x)
			{
				ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0099;
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
		IL_0099:
		System.Exception ex3 = ex2;
		try
		{
			System.Exception e = ex3;
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
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 160, 135, 134, 114, 114, 214, 102, 39, 230,
		60, 102, 98, 142, 102
	})]
	public virtual long copyTo(ByteSink sink)
	{
		Preconditions.checkNotNull(sink);
		Closer closer = Closer.create();
		long result;
		System.Exception ex;
		try
		{
			try
			{
				InputStream from = (InputStream)closer.register(openStream());
				OutputStream to = (OutputStream)closer.register(sink.openStream());
				result = ByteStreams.copy(from, to);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0050;
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
		IL_0050:
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
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 180, 134, 114, 103, 104, 120, 213, 102, 39,
		230, 58, 166, 98, 142, 102
	})]
	public virtual byte[] read()
	{
		Closer closer = Closer.create();
		byte[] result;
		System.Exception ex;
		try
		{
			try
			{
				InputStream inputStream = (InputStream)closer.register(openStream());
				com.google.common.@base.Optional optional = sizeIfKnown();
				result = ((!optional.isPresent()) ? ByteStreams.toByteArray(inputStream) : ByteStreams.toByteArray(inputStream, ((Long)optional.get()).longValue()));
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_005d;
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
		IL_005d:
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
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/io/ByteProcessor<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 126, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		160, 206, 135, 134, 114, 213, 102, 38, 230, 60,
		102, 98, 142, 102
	})]
	public virtual object read(ByteProcessor processor)
	{
		Preconditions.checkNotNull(processor);
		Closer closer = Closer.create();
		object result;
		System.Exception ex;
		try
		{
			try
			{
				InputStream input = (InputStream)closer.register(openStream());
				result = ByteStreams.readBytes(input, processor);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_003d;
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
		IL_003d:
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
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 225, 103, 109 })]
	public virtual HashCode hash(HashFunction hashFunction)
	{
		Hasher hasher = hashFunction.newHasher();
		copyTo(Funnels.asOutputStream(hasher));
		HashCode result = hasher.hash();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160,
		237,
		135,
		102,
		134,
		134,
		114,
		byte.MaxValue,
		2,
		77,
		102,
		234,
		52,
		108,
		109,
		111,
		243,
		72,
		102,
		41,
		230,
		56,
		99,
		102,
		243,
		70,
		102,
		41,
		230,
		58,
		131,
		105,
		98,
		142,
		102
	})]
	public virtual bool contentEquals(ByteSource other)
	{
		Preconditions.checkNotNull(other);
		byte[] array = ByteStreams.createBuffer();
		byte[] array2 = ByteStreams.createBuffer();
		Closer closer = Closer.create();
		InputStream @in;
		InputStream in2;
		System.Exception ex;
		try
		{
			try
			{
				@in = (InputStream)closer.register(openStream());
				in2 = (InputStream)closer.register(other.openStream());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0055;
			}
		}
		catch
		{
			//try-fault
			closer.close();
			throw;
		}
		System.Exception ex4;
		while (true)
		{
			int num;
			System.Exception ex2;
			int result;
			try
			{
				try
				{
					num = ByteStreams.read(@in, array, 0, array.Length);
					int num2 = ByteStreams.read(in2, array2, 0, array2.Length);
					if (num != num2 || !Arrays.equals(array, array2))
					{
						result = 0;
						goto IL_00a6;
					}
				}
				catch (System.Exception x2)
				{
					ex2 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
					goto IL_00a2;
				}
			}
			catch
			{
				//try-fault
				closer.close();
				throw;
			}
			System.Exception ex3;
			try
			{
				try
				{
					if ((nint)num != (nint)array.LongLength)
					{
						result = 1;
						goto IL_00d7;
					}
				}
				catch (System.Exception x3)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
					goto IL_00d3;
				}
			}
			catch
			{
				//try-fault
				closer.close();
				throw;
			}
			continue;
			IL_00a6:
			closer.close();
			return (byte)result != 0;
			IL_00d3:
			ex4 = ex3;
			break;
			IL_00d7:
			closer.close();
			return (byte)result != 0;
			IL_00a2:
			ex4 = ex2;
			break;
		}
		goto IL_00e5;
		IL_0055:
		ex4 = ex;
		goto IL_00e5;
		IL_00e5:
		System.Exception ex5 = ex4;
		try
		{
			System.Exception e = ex5;
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
	[Signature("(Ljava/util/Iterator<+Lcom/google/common/io/ByteSource;>;)Lcom/google/common/io/ByteSource;")]
	[LineNumberTable(410)]
	public static ByteSource concat(Iterator sources)
	{
		ByteSource result = concat(ImmutableList.copyOf(sources));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(426)]
	public static ByteSource concat(params ByteSource[] sources)
	{
		ByteSource result = concat(ImmutableList.copyOf(sources));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(441)]
	public static ByteSource wrap(byte[] b)
	{
		ByteArrayByteSource result = new ByteArrayByteSource(b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(450)]
	public static ByteSource empty()
	{
		return EmptyByteSource.INSTANCE;
	}
}
