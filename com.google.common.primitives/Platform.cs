using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util.logging;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Platform : Object
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
	[LineNumberTable(new byte[] { 159, 169, 134, 114, 127, 0, 240, 72, 251, 70 })]
	internal static void checkGwtRpcEnabled()
	{
		string text = "guava.gwt.emergency_reenable_rpc";
		if (!Boolean.parseBoolean(java.lang.System.getProperty(text, "false")))
		{
			string message = Strings.lenientFormat("We are removing GWT-RPC support for Guava types. You can temporarily reenable support by setting the system property %s to true. For more about system properties, see %s. For more about Guava's GWT-RPC support, see %s.", text, "https://stackoverflow.com/q/5189914/28465", "https://groups.google.com/d/msg/guava-announce/zHZTFg7YF3o/rQNnwdHeEwAJ");
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException(message);
		}
		logger.log(Level.WARNING, "Later in 2020, we will remove GWT-RPC support for Guava types. You are seeing this warning because you are sending a Guava type over GWT-RPC, which will break. You can identify which type by looking at the class name in the attached stack trace.", new Throwable());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	private Platform()
	{
	}

	[LineNumberTable(new byte[] { 159, 165, 101, 52 })]
	static Platform()
	{
		logger = Logger.getLogger(ClassLiteral<Platform>.Value.getName(), Platform.___003CGetCallerID_003E());
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
