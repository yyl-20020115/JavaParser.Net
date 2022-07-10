using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.stream;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public abstract class CharSink : java.lang.Object
{
	[Throws(new string[] { "java.io.IOException" })]
	public abstract Writer openStream();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/CharSequence;>;Ljava/lang/String;)V")]
	[LineNumberTable(new byte[] { 77, 111 })]
	public virtual void writeLines(Iterable lines, string lineSeparator)
	{
		writeLines(lines.iterator(), lineSeparator);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/util/Iterator<+Ljava/lang/CharSequence;>;Ljava/lang/String;)V")]
	[LineNumberTable(new byte[]
	{
		108,
		135,
		103,
		104,
		159,
		45,
		235,
		60,
		byte.MaxValue,
		21,
		69
	})]
	private void writeLines(Iterator P_0, string P_1)
	{
		Preconditions.checkNotNull(P_1);
		Writer writer = openBufferedStream();
		System.Exception ex;
		try
		{
			CharSequence csq = default(CharSequence);
			while (P_0.hasNext())
			{
				object obj = P_0.next();
				CharSequence.Cast(obj);
				object obj2 = (csq.___003Cref_003E = obj);
				Writer writer2 = writer.append(csq);
				obj2 = (csq.___003Cref_003E = P_1);
				writer2.append(csq);
			}
		}
		catch (System.Exception x)
		{
			ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			goto IL_005f;
		}
		writer?.close();
		return;
		IL_005f:
		System.Exception ex2 = ex;
		System.Exception ex3;
		if (writer != null)
		{
			try
			{
				writer.close();
			}
			catch (System.Exception x2)
			{
				ex3 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
				goto IL_0088;
			}
		}
		goto IL_0099;
		IL_0099:
		throw Throwable.___003Cunmap_003E(ex2);
		IL_0088:
		System.Exception exception = ex3;
		Throwable.instancehelper_addSuppressed(ex2, exception);
		goto IL_0099;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/util/stream/Stream<+Ljava/lang/CharSequence;>;Ljava/lang/String;)V")]
	[LineNumberTable(new byte[] { 103, 111 })]
	public virtual void writeLines(Stream lines, string lineSeparator)
	{
		writeLines(lines.iterator(), lineSeparator);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 32, 103, 104, 104, 8 })]
	public virtual Writer openBufferedStream()
	{
		Writer writer = openStream();
		BufferedWriter result = ((!(writer is BufferedWriter)) ? new BufferedWriter(writer) : ((BufferedWriter)writer));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	protected internal CharSink()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		159, 119, 138, 135, 134, 114, 122, 212, 102, 39,
		102, 230, 60, 98, 142, 102, 97
	})]
	public virtual void write(CharSequence charSequence)
	{
		CharSequence charSequence2 = charSequence;
		object __003Cref_003E = charSequence2.___003Cref_003E;
		Preconditions.checkNotNull(__003Cref_003E);
		Closer closer = Closer.create();
		System.Exception ex;
		try
		{
			try
			{
				Writer writer = (Writer)closer.register(openStream());
				CharSequence csq = default(CharSequence);
				object obj = (csq.___003Cref_003E = __003Cref_003E);
				writer.append(csq);
				writer.flush();
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0060;
			}
		}
		catch
		{
			//try-fault
			closer.close();
			throw;
		}
		closer.close();
		return;
		IL_0060:
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
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/CharSequence;>;)V")]
	[LineNumberTable(new byte[] { 66, 115 })]
	public virtual void writeLines(Iterable lines)
	{
		writeLines(lines, java.lang.System.getProperty("line.separator"));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[Signature("(Ljava/util/stream/Stream<+Ljava/lang/CharSequence;>;)V")]
	[LineNumberTable(new byte[] { 90, 115 })]
	public virtual void writeLines(Stream lines)
	{
		writeLines(lines, java.lang.System.getProperty("line.separator"));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		127, 135, 134, 114, 104, 102, 208, 102, 39, 230,
		60, 102, 98, 142, 102
	})]
	public virtual long writeFrom(Readable readable)
	{
		Preconditions.checkNotNull(readable);
		Closer closer = Closer.create();
		long result;
		System.Exception ex;
		try
		{
			try
			{
				Writer writer = (Writer)closer.register(openStream());
				long num = CharStreams.copy(readable, writer);
				writer.flush();
				result = num;
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0046;
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
		IL_0046:
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
}
