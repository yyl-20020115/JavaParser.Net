using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.charset;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.io;

[ConstantPool(new object[]
{
	(byte)147,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public abstract class CharSource : java.lang.Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class AsByteSource : ByteSource
	{
		[Modifiers(Modifiers.Final)]
		internal Charset charset;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CharSource this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 145, 111, 113 })]
		internal AsByteSource(CharSource P_0, Charset P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			charset = (Charset)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 151, 110, 135 })]
		public override CharSource asCharSource(Charset P_0)
		{
			if (P_0.equals(charset))
			{
				return this_00240;
			}
			CharSource result = base.asCharSource(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(529)]
		public override InputStream openStream()
		{
			ReaderInputStream result = new ReaderInputStream(this_00240.openStream(), charset, 8192);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(534)]
		public override string toString()
		{
			string text = java.lang.Object.instancehelper_toString(this_00240);
			string text2 = java.lang.String.valueOf(charset);
			int num = 15 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".asByteSource(").append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[ConstantPool(new object[]
	{
		(byte)87,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class CharSequenceCharSource : CharSource
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/lang/String;>;")]
		[EnclosingMethod(null, "linesIterator", "()Ljava.util.Iterator;")]
		internal class _1 : com.google.common.collect.AbstractIterator
		{
			[Signature("Ljava/util/Iterator<Ljava/lang/String;>;")]
			internal Iterator lines;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal CharSequenceCharSource this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 214, 109, 145, 117, 162 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual string computeNext()
			{
				if (lines.hasNext())
				{
					string text = (string)lines.next();
					if (lines.hasNext() || !java.lang.String.instancehelper_isEmpty(text))
					{
						return text;
					}
				}
				return (string)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 208, 111 })]
			internal _1(CharSequenceCharSource P_0)
			{
				this_00240 = P_0;
				base._002Ector();
				Splitter splitter = access_0024100();
				CharSequence seq = this_00240.seq;
				CharSequence sequence = default(CharSequence);
				object obj = (sequence.___003Cref_003E = seq.___003Cref_003E);
				lines = splitter.split(sequence).iterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(578)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				string result = computeNext();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static Splitter LINE_SPLITTER;

		[Modifiers(Modifiers.Protected | Modifiers.Final)]
		protected internal CharSequence seq;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 6, 74, 104, 127, 4 })]
		protected internal CharSequenceCharSource(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			base._002Ector();
			object obj = Preconditions.checkNotNull(__003Cref_003E);
			CharSequence.Cast(obj);
			CharSequence charSequence2 = default(CharSequence);
			object obj2 = (charSequence2.___003Cref_003E = obj);
			seq = charSequence2;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static Splitter access_0024100()
		{
			return LINE_SPLITTER;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/lang/String;>;")]
		[LineNumberTable(578)]
		private Iterator linesIterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(550)]
		public override Reader openStream()
		{
			CharSequence charSequence = seq;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
			CharSequenceReader result = new CharSequenceReader(charSequence2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(555)]
		public override string read()
		{
			CharSequence charSequence = seq;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
			string result = charSequence2.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(560)]
		public override bool isEmpty()
		{
			CharSequence charSequence = seq;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
			return (charSequence2.length() == 0) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(565)]
		public override long length()
		{
			CharSequence charSequence = seq;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
			return charSequence2.length();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
		[LineNumberTable(570)]
		public override com.google.common.@base.Optional lengthIfKnown()
		{
			CharSequence charSequence = seq;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
			com.google.common.@base.Optional result = com.google.common.@base.Optional.of(Long.valueOf(charSequence2.length()));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<Ljava/lang/String;>;")]
		[LineNumberTable(598)]
		public override Stream lines()
		{
			Stream result = Streams.stream(linesIterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 234, 103 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override string readFirstLine()
		{
			Iterator iterator = linesIterator();
			return (!iterator.hasNext()) ? null : ((string)iterator.next());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableList<Ljava/lang/String;>;")]
		[LineNumberTable(610)]
		public override ImmutableList readLines()
		{
			ImmutableList result = ImmutableList.copyOf(linesIterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/io/LineProcessor<TT;>;)TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 87, 0, 0 })]
		[LineNumberTable(new byte[] { 161, 246, 103, 104, 115, 162 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/io/ParametricNullness;"
		})]
		public override object readLines(LineProcessor P_0)
		{
			Iterator iterator = linesIterator();
			while (iterator.hasNext() && P_0.processLine((string)iterator.next()))
			{
			}
			object result = P_0.getResult();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(627)]
		public override string toString()
		{
			CharSequence charSequence = seq;
			object __003Cref_003E = charSequence.___003Cref_003E;
			string truncationIndicator = "...";
			int maxLength = 30;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			string text = Ascii.truncate(charSequence2, maxLength, truncationIndicator);
			maxLength = 17 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			maxLength = maxLength;
			string result = new StringBuilder(maxLength).append("CharSource.wrap(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}

		[LineNumberTable(540)]
		static CharSequenceCharSource()
		{
			LINE_SPLITTER = Splitter.onPattern("\r\n|\n|\r");
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ConcatenatedCharSource : CharSource
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/Iterable<+Lcom/google/common/io/CharSource;>;")]
		private Iterable sources;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Lcom/google/common/io/CharSource;>;)V")]
		[LineNumberTable(new byte[] { 162, 70, 104, 113 })]
		internal ConcatenatedCharSource(Iterable P_0)
		{
			sources = (Iterable)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(702)]
		public override Reader openStream()
		{
			MultiReader result = new MultiReader(sources.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 81, 127, 1, 104, 130, 98 })]
		public override bool isEmpty()
		{
			Iterator iterator = sources.iterator();
			while (iterator.hasNext())
			{
				CharSource charSource = (CharSource)iterator.next();
				if (!charSource.isEmpty())
				{
					return false;
				}
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
		[LineNumberTable(new byte[] { 162, 91, 99, 127, 1, 103, 104, 136, 115, 98 })]
		public override com.google.common.@base.Optional lengthIfKnown()
		{
			long num = 0L;
			Iterator iterator = sources.iterator();
			while (iterator.hasNext())
			{
				CharSource charSource = (CharSource)iterator.next();
				com.google.common.@base.Optional optional = charSource.lengthIfKnown();
				if (!optional.isPresent())
				{
					com.google.common.@base.Optional result = com.google.common.@base.Optional.absent();
					_ = null;
					return result;
				}
				num += ((Long)optional.get()).longValue();
			}
			com.google.common.@base.Optional result2 = com.google.common.@base.Optional.of(Long.valueOf(num));
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 104, 99, 127, 1, 105, 98 })]
		public override long length()
		{
			long num = 0L;
			Iterator iterator = sources.iterator();
			while (iterator.hasNext())
			{
				CharSource charSource = (CharSource)iterator.next();
				num += charSource.length();
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(739)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(sources);
			int num = 19 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("CharSource.concat(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class EmptyCharSource : StringCharSource
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static EmptyCharSource INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static EmptyCharSource access_0024000()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 57, 109 })]
		private EmptyCharSource()
			: base("")
		{
		}

		public override string toString()
		{
			return "CharSource.empty()";
		}

		[LineNumberTable(680)]
		static EmptyCharSource()
		{
			StringCharSource.___003Cclinit_003E();
			INSTANCE = new EmptyCharSource();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class StringCharSource : CharSequenceCharSource
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 22, 121 })]
		protected internal StringCharSource(string P_0)
		{
			CharSequence charSequence = default(CharSequence);
			charSequence.___003Cref_003E = P_0;
			base._002Ector(charSequence);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(653)]
		public override Reader openStream()
		{
			CharSequence charSequence = seq;
			StringReader result = new StringReader((string)charSequence.___003Cref_003E);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 162, 32, 127, 6 })]
		public override long copyTo(Appendable P_0)
		{
			CharSequence charSequence = seq;
			CharSequence csq = default(CharSequence);
			object obj = (csq.___003Cref_003E = charSequence.___003Cref_003E);
			P_0.append(csq);
			CharSequence charSequence2 = seq;
			obj = (csq.___003Cref_003E = charSequence2.___003Cref_003E);
			return csq.length();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[]
		{
			162, 38, 103, 134, 114, 121, 223, 18, 102, 39,
			230, 60, 103, 98, 142, 102
		})]
		public override long copyTo(CharSink P_0)
		{
			Preconditions.checkNotNull(P_0);
			Closer closer = Closer.create();
			long result;
			System.Exception ex;
			try
			{
				try
				{
					Writer writer = (Writer)closer.register(P_0.openStream());
					CharSequence charSequence = seq;
					writer.write((string)charSequence.___003Cref_003E);
					CharSequence charSequence2 = seq;
					CharSequence charSequence3 = default(CharSequence);
					object obj = (charSequence3.___003Cref_003E = charSequence2.___003Cref_003E);
					result = charSequence3.length();
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_0072;
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
			IL_0072:
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

		[HideFromJava]
		static StringCharSource()
		{
			CharSequenceCharSource.___003Cclinit_003E();
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : Runnable
	{
		private readonly BufferedReader arg_00241;

		internal ___003C_003EAnon0(BufferedReader P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			lambda_0024lines_00240(arg_00241);
			_ = null;
		}
	}

	[Throws(new string[] { "java.io.IOException" })]
	public abstract Reader openStream();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 76, 103, 104, 104, 8 })]
	public virtual BufferedReader openBufferedStream()
	{
		Reader reader = openStream();
		BufferedReader result = ((!(reader is BufferedReader)) ? new BufferedReader(reader) : ((BufferedReader)reader));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Optional<Ljava/lang/Long;>;")]
	[LineNumberTable(190)]
	public virtual com.google.common.@base.Optional lengthIfKnown()
	{
		com.google.common.@base.Optional result = com.google.common.@base.Optional.absent();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 117, 131, 117, 134 })]
	private long countBySkipping(Reader P_0)
	{
		long num = 0L;
		long num2;
		while ((num2 = P_0.skip(long.MaxValue)) != 0)
		{
			num += num2;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("()Ljava/util/stream/Stream<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 111, 103, 97, 112, 10 })]
	public virtual Stream lines()
	{
		BufferedReader bufferedReader = openBufferedStream();
		return (Stream)bufferedReader.lines().onClose(new ___003C_003EAnon0(bufferedReader));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Lcom/google/common/io/CharSource;>;)Lcom/google/common/io/CharSource;")]
	[LineNumberTable(447)]
	public static CharSource concat(Iterable sources)
	{
		ConcatenatedCharSource result = new ConcatenatedCharSource(sources);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 117, 184, 2, 97, 140 })]
	private static void lambda_0024lines_00240(BufferedReader P_0)
	{
		IOException ex;
		try
		{
			P_0.close();
			return;
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UncheckedIOException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	protected internal CharSource()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(104)]
	public virtual ByteSource asByteSource(Charset charset)
	{
		AsByteSource result = new AsByteSource(this, charset);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 100, 103, 104, 177, 134, 114, 214, 102, 39,
		230, 60, 102, 98, 142, 102
	})]
	public virtual long length()
	{
		com.google.common.@base.Optional optional = lengthIfKnown();
		if (optional.isPresent())
		{
			return ((Long)optional.get()).longValue();
		}
		Closer closer = Closer.create();
		long result;
		System.Exception ex;
		try
		{
			try
			{
				Reader reader = (Reader)closer.register(openStream());
				result = countBySkipping(reader);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0057;
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
		IL_0057:
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
		160, 135, 135, 134, 114, 213, 102, 38, 230, 60,
		102, 98, 142, 102
	})]
	public virtual long copyTo(Appendable appendable)
	{
		Preconditions.checkNotNull(appendable);
		Closer closer = Closer.create();
		long result;
		System.Exception ex;
		try
		{
			try
			{
				Reader from = (Reader)closer.register(openStream());
				result = CharStreams.copy(from, appendable);
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
	[LineNumberTable(new byte[]
	{
		160, 157, 135, 134, 114, 114, 214, 102, 39, 230,
		60, 102, 98, 142, 102
	})]
	public virtual long copyTo(CharSink sink)
	{
		Preconditions.checkNotNull(sink);
		Closer closer = Closer.create();
		long result;
		System.Exception ex;
		try
		{
			try
			{
				Reader from = (Reader)closer.register(openStream());
				Writer to = (Writer)closer.register(sink.openStream());
				result = CharStreams.copy(from, to);
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
		160, 177, 134, 114, 212, 102, 38, 230, 60, 102,
		98, 142, 102
	})]
	public virtual string read()
	{
		Closer closer = Closer.create();
		string result;
		System.Exception ex;
		try
		{
			try
			{
				Reader r = (Reader)closer.register(openStream());
				result = CharStreams.toString(r);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0035;
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
		IL_0035:
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
		160, 200, 134, 114, 212, 102, 38, 230, 60, 102,
		98, 142, 102
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual string readFirstLine()
	{
		Closer closer = Closer.create();
		string result;
		System.Exception ex;
		try
		{
			try
			{
				BufferedReader bufferedReader = (BufferedReader)closer.register(openBufferedStream());
				result = bufferedReader.readLine();
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0035;
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
		IL_0035:
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
	[Signature("()Lcom/google/common/collect/ImmutableList<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[]
	{
		160, 223, 134, 114, 134, 106, 138, 214, 102, 39,
		230, 60, 103, 98, 142, 102
	})]
	public virtual ImmutableList readLines()
	{
		Closer closer = Closer.create();
		ImmutableList result;
		System.Exception ex;
		try
		{
			try
			{
				BufferedReader bufferedReader = (BufferedReader)closer.register(openBufferedStream());
				ArrayList arrayList = Lists.newArrayList();
				string e;
				while ((e = bufferedReader.readLine()) != null)
				{
					((List)arrayList).add((object)e);
				}
				result = ImmutableList.copyOf(arrayList);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0051;
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
		IL_0051:
		System.Exception ex2 = ex;
		try
		{
			System.Exception e2 = ex2;
			throw Throwable.___003Cunmap_003E(closer.rethrow(e2));
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
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/io/LineProcessor<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 147, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		161, 1, 135, 134, 114, 213, 102, 38, 230, 60,
		102, 98, 142, 102
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	public virtual object readLines(LineProcessor processor)
	{
		Preconditions.checkNotNull(processor);
		Closer closer = Closer.create();
		object result;
		System.Exception ex;
		try
		{
			try
			{
				Reader readable = (Reader)closer.register(openStream());
				result = CharStreams.readLines(readable, processor);
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
	[Signature("(Ljava/util/function/Consumer<-Ljava/lang/String;>;)V")]
	[LineNumberTable(new byte[]
	{
		161,
		29,
		135,
		118,
		byte.MaxValue,
		7,
		61,
		byte.MaxValue,
		75,
		69,
		2,
		98,
		141
	})]
	public virtual void forEachLine(Consumer action)
	{
		Stream stream;
		System.Exception ex;
		UncheckedIOException ex2;
		try
		{
			stream = lines();
			try
			{
				stream.forEachOrdered(action);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto end_IL_0000;
			}
			stream?.close();
			return;
			end_IL_0000:;
		}
		catch (UncheckedIOException x2)
		{
			ex2 = ByteCodeHelper.MapException<UncheckedIOException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_003b;
		}
		System.Exception ex3 = ex;
		System.Exception ex4;
		UncheckedIOException ex5;
		try
		{
			ex4 = ex3;
			if (stream != null)
			{
				try
				{
					stream.close();
				}
				catch (System.Exception x3)
				{
					ex3 = ByteCodeHelper.MapException<System.Exception>(x3, ByteCodeHelper.MapFlags.None);
					goto IL_006d;
				}
			}
		}
		catch (UncheckedIOException x4)
		{
			ex5 = ByteCodeHelper.MapException<UncheckedIOException>(x4, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0070;
		}
		goto IL_0097;
		IL_003b:
		UncheckedIOException ex6 = ex2;
		goto IL_00af;
		IL_00af:
		UncheckedIOException ex7 = ex6;
		throw Throwable.___003Cunmap_003E(ex7.getCause());
		IL_0070:
		ex6 = ex5;
		goto IL_00af;
		IL_006d:
		System.Exception ex8 = ex3;
		UncheckedIOException ex9;
		try
		{
			System.Exception exception = ex8;
			Throwable.instancehelper_addSuppressed(ex4, exception);
		}
		catch (UncheckedIOException x5)
		{
			ex9 = ByteCodeHelper.MapException<UncheckedIOException>(x5, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0093;
		}
		goto IL_0097;
		IL_0093:
		ex6 = ex9;
		goto IL_00af;
		IL_0097:
		UncheckedIOException ex10;
		try
		{
			throw Throwable.___003Cunmap_003E(ex4);
		}
		catch (UncheckedIOException x6)
		{
			ex10 = ByteCodeHelper.MapException<UncheckedIOException>(x6, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ex6 = ex10;
		goto IL_00af;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 50, 103, 104, 149, 134, 114, 216, 102, 39,
		230, 60, 102, 98, 142, 102
	})]
	public virtual bool isEmpty()
	{
		com.google.common.@base.Optional optional = lengthIfKnown();
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
				Reader reader = (Reader)closer.register(openStream());
				result = ((reader.read() == -1) ? 1 : 0);
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
	[Signature("(Ljava/util/Iterator<+Lcom/google/common/io/CharSource;>;)Lcom/google/common/io/CharSource;")]
	[LineNumberTable(469)]
	public static CharSource concat(Iterator sources)
	{
		CharSource result = concat(ImmutableList.copyOf(sources));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(485)]
	public static CharSource concat(params CharSource[] sources)
	{
		CharSource result = concat(ImmutableList.copyOf(sources));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 18, 74, 104, 114, 24 })]
	public static CharSource wrap(CharSequence charSequence)
	{
		CharSequence charSequence2 = charSequence;
		object __003Cref_003E = charSequence2.___003Cref_003E;
		object result;
		if (__003Cref_003E is string)
		{
			StringCharSource.___003Cclinit_003E();
			result = new StringCharSource((string)__003Cref_003E);
		}
		else
		{
			CharSequence charSequence3 = default(CharSequence);
			object obj = (charSequence3.___003Cref_003E = __003Cref_003E);
			result = new CharSequenceCharSource(charSequence3);
		}
		_ = null;
		return (CharSource)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(507)]
	public static CharSource empty()
	{
		EmptyCharSource result = EmptyCharSource.access_0024000();
		_ = null;
		return result;
	}
}
