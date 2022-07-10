using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.nio;
using java.util;
using javax.annotation;

namespace com.google.common.io;

[ConstantPool(new object[]
{
	(byte)113,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class CharStreams : Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class NullWriter : Writer
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static NullWriter INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		public override Writer append(char P_0)
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 159, 63, 138, 127, 8 })]
		public override Writer append([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] CharSequence P_0, int P_1, int P_2)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			int size;
			if (__003Cref_003E == null)
			{
				size = String.instancehelper_length("null");
			}
			else
			{
				CharSequence charSequence2 = default(CharSequence);
				object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
				size = charSequence2.length();
			}
			Preconditions.checkPositionIndexes(P_1, P_2, size);
			return this;
		}

		public override Writer append([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] CharSequence P_0)
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(284)]
		private NullWriter()
		{
		}

		public override void write(int P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 179, 103 })]
		public override void write(char[] P_0)
		{
			Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 184, 109 })]
		public override void write(char[] P_0, int P_1, int P_2)
		{
			Preconditions.checkPositionIndexes(P_1, P_1 + P_2, P_0.Length);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 189, 103 })]
		public override void write(string P_0)
		{
			Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 194, 113 })]
		public override void write(string P_0, int P_1, int P_2)
		{
			Preconditions.checkPositionIndexes(P_1, P_1 + P_2, String.instancehelper_length(P_0));
		}

		public override void flush()
		{
		}

		public override void close()
		{
		}

		public override string toString()
		{
			return "CharStreams.nullWriter()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(284)]
		public new virtual Appendable append(char P_0)
		{
			Writer result = this.append(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(284)]
		public new virtual Appendable append([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] CharSequence P_0, int P_1, int P_2)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			Writer result = this.append(charSequence2, P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(284)]
		public new virtual Appendable append([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			Writer result = this.append(charSequence2);
			_ = null;
			return result;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static NullWriter access_0024000()
		{
			return INSTANCE;
		}

		[LineNumberTable(286)]
		static NullWriter()
		{
			INSTANCE = new NullWriter();
		}
	}

	private const int DEFAULT_BUF_SIZE = 2048;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		23, 136, 104, 148, 212, 103, 103, 99, 102, 106,
		102, 120, 106, 136
	})]
	public static long copy(Readable from, Appendable to)
	{
		if (from is Reader)
		{
			if (to is StringBuilder)
			{
				long result = copyReaderToBuilder((Reader)from, (StringBuilder)to);
				_ = null;
				return result;
			}
			long result2 = copyReaderToWriter((Reader)from, asWriter(to));
			_ = null;
			return result2;
		}
		Preconditions.checkNotNull(from);
		Preconditions.checkNotNull(to);
		long num = 0L;
		CharBuffer charBuffer = createBuffer();
		CharSequence csq = default(CharSequence);
		while (from.read(charBuffer) != -1)
		{
			Java8Compatibility.flip(charBuffer);
			object obj = (csq.___003Cref_003E = charBuffer);
			to.append(csq);
			num += charBuffer.remaining();
			Java8Compatibility.clear(charBuffer);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(164)]
	public static string toString(Readable r)
	{
		string result = toStringBuilder(r).toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Readable;Lcom/google/common/io/LineProcessor<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 113, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 107, 103, 135, 135, 106, 105, 162 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/io/ParametricNullness;"
	})]
	public static object readLines(Readable readable, LineProcessor processor)
	{
		Preconditions.checkNotNull(readable);
		Preconditions.checkNotNull(processor);
		LineReader lineReader = new LineReader(readable);
		string str;
		while ((str = lineReader.readLine()) != null && processor.processLine(str))
		{
		}
		object result = processor.getResult();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 65, 103, 103, 139, 99, 108, 106, 135 })]
	internal static long copyReaderToBuilder(Reader P_0, StringBuilder P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		char[] array = new char[2048];
		long num = 0L;
		int num2;
		while ((num2 = P_0.read(array)) != -1)
		{
			P_1.append(array, 0, num2);
			num += num2;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 235, 104, 135 })]
	public static Writer asWriter(Appendable target)
	{
		if (target is Writer)
		{
			return (Writer)target;
		}
		AppendableWriter result = new AppendableWriter(target);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 93, 103, 103, 139, 99, 108, 105, 135 })]
	internal static long copyReaderToWriter(Reader P_0, Writer P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		char[] cbuf = new char[2048];
		long num = 0L;
		int num2;
		while ((num2 = P_0.read(cbuf)) != -1)
		{
			P_1.write(cbuf, 0, num2);
			num += num2;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	internal static CharBuffer createBuffer()
	{
		CharBuffer result = CharBuffer.allocate(2048);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 126, 102, 104, 143, 136 })]
	private static StringBuilder toStringBuilder(Readable P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (P_0 is Reader)
		{
			copyReaderToBuilder((Reader)P_0, stringBuilder);
		}
		else
		{
			copy(P_0, stringBuilder);
		}
		return stringBuilder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	private CharStreams()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/lang/Readable;)Ljava/util/List<Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 160, 84, 102, 135, 106, 138 })]
	public static List readLines(Readable r)
	{
		ArrayList arrayList = new ArrayList();
		LineReader lineReader = new LineReader(r);
		string e;
		while ((e = lineReader.readLine()) != null)
		{
			((List)arrayList).add((object)e);
		}
		return arrayList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 129, 131, 102, 110, 100, 136 })]
	public static long exhaust(Readable readable)
	{
		long num = 0L;
		CharBuffer charBuffer = createBuffer();
		long num2;
		while ((num2 = readable.read(charBuffer)) != -1)
		{
			num += num2;
			Java8Compatibility.clear(charBuffer);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 150, 103, 101, 104, 101, 139, 101, 98 })]
	public static void skipFully(Reader reader, long n)
	{
		Preconditions.checkNotNull(reader);
		while (n > 0)
		{
			long num = reader.skip(n);
			if (num == 0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new EOFException();
			}
			n -= num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(281)]
	public static Writer nullWriter()
	{
		NullWriter result = NullWriter.access_0024000();
		_ = null;
		return result;
	}
}
