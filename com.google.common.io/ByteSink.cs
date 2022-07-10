using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.charset;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public abstract class ByteSink : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	internal sealed class AsCharSink : CharSink
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Charset charset;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ByteSink this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(140)]
		internal AsCharSink(ByteSink P_0, Charset P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 94, 111, 113 })]
		private AsCharSink(ByteSink P_0, Charset P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			charset = (Charset)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(150)]
		public override Writer openStream()
		{
			OutputStreamWriter result = new OutputStreamWriter(this_00240.openStream(), charset);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(155)]
		public override string toString()
		{
			string text = java.lang.Object.instancehelper_toString(this_00240);
			string text2 = java.lang.String.valueOf(charset);
			int num = 13 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append(".asCharSink(").append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[Throws(new string[] { "java.io.IOException" })]
	public abstract OutputStream openStream();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	protected internal ByteSink()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(60)]
	public virtual CharSink asCharSink(Charset charset)
	{
		AsCharSink result = new AsCharSink(this, charset, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 36, 103, 104, 104, 8 })]
	public virtual OutputStream openBufferedStream()
	{
		OutputStream outputStream = openStream();
		BufferedOutputStream result = ((!(outputStream is BufferedOutputStream)) ? new BufferedOutputStream(outputStream) : ((BufferedOutputStream)outputStream));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		48, 135, 134, 114, 103, 211, 102, 38, 102, 228,
		60, 98, 142, 102, 97
	})]
	public virtual void write(byte[] bytes)
	{
		Preconditions.checkNotNull(bytes);
		Closer closer = Closer.create();
		System.Exception ex;
		try
		{
			try
			{
				OutputStream outputStream = (OutputStream)closer.register(openStream());
				outputStream.write(bytes);
				outputStream.flush();
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0042;
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
		IL_0042:
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
		71, 135, 134, 114, 104, 102, 208, 102, 39, 230,
		60, 102, 98, 142, 102
	})]
	public virtual long writeFrom(InputStream input)
	{
		Preconditions.checkNotNull(input);
		Closer closer = Closer.create();
		long result;
		System.Exception ex;
		try
		{
			try
			{
				OutputStream outputStream = (OutputStream)closer.register(openStream());
				long num = ByteStreams.copy(input, outputStream);
				outputStream.flush();
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
