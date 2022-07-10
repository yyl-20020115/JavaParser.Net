using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util.logging;

namespace com.google.common.io;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/io/ElementTypesAreNonnullByDefault;"
})]
public sealed class Flushables : Object
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		159, 129, 98, 248, 71, 226, 58, 97, 99, 151,
		167
	})]
	public static void flush(Flushable flushable, bool swallowIOException)
	{
		IOException ex;
		try
		{
			flushable.flush();
			return;
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException ex2 = ex;
		if (swallowIOException)
		{
			logger.log(Level.WARNING, "IOException thrown while flushing Flushable.", ex2);
			return;
		}
		throw Throwable.___003Cunmap_003E(ex2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	private Flushables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 185, 2, 97, 149 })]
	public static void flushQuietly(Flushable flushable)
	{
		IOException ex;
		try
		{
			flush(flushable, swallowIOException: true);
			return;
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException thrown = ex;
		logger.log(Level.SEVERE, "IOException should not have been thrown.", thrown);
	}

	[LineNumberTable(34)]
	static Flushables()
	{
		logger = Logger.getLogger(ClassLiteral<Flushables>.Value.getName(), Flushables.___003CGetCallerID_003E());
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
