using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.@ref;
using java.util;
using java.util.logging;
using java.util.regex;
using javax.annotation;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Platform : Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class JdkPatternCompiler : Object, PatternCompiler
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(100)]
		internal JdkPatternCompiler(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(100)]
		private JdkPatternCompiler()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(103)]
		public virtual CommonPattern compile(string P_0)
		{
			JdkPattern result = new JdkPattern(Pattern.compile(P_0));
			_ = null;
			return result;
		}

		public virtual bool isPcreLike()
		{
			return true;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static PatternCompiler patternCompiler;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	internal static CharMatcher precomputeCharMatcher(CharMatcher P_0)
	{
		CharMatcher result = P_0.precomputedInternal();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 103 })]
	internal static CommonPattern compilePattern(string P_0)
	{
		Preconditions.checkNotNull(P_0);
		CommonPattern result = patternCompiler.compile(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	internal static bool patternCompilerIsPcreLike()
	{
		bool result = patternCompiler.isPcreLike();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Enum<TT;>;>(Ljava/lang/Class<TT;>;Ljava/lang/String;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(new byte[] { 0, 114 })]
	internal static Optional getEnumIfPresent(Class P_0, string P_1)
	{
		WeakReference weakReference = (WeakReference)Enums.getEnumConstants(P_0).get(P_1);
		Optional result = ((weakReference != null) ? Optional.of((Enum)P_0.cast(weakReference.get())) : Optional.absent());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(59)]
	internal static bool stringIsNullOrEmpty([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string P_0)
	{
		return (P_0 == null || String.instancehelper_isEmpty(P_0)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(93)]
	private static PatternCompiler loadPatternCompiler()
	{
		JdkPatternCompiler result = new JdkPatternCompiler(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	private Platform()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	internal static long systemNanoTime()
	{
		long result = java.lang.System.nanoTime();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	internal static string formatCompact4Digits(double P_0)
	{
		string result = String.format(Locale.ROOT, "%.4g", Double.valueOf(P_0));
		_ = null;
		return result;
	}

	internal static string nullToEmpty([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string P_0)
	{
		return (P_0 != null) ? P_0 : "";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(80)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static string emptyToNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] string P_0)
	{
		return (!stringIsNullOrEmpty(P_0)) ? P_0 : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 47, 119 })]
	private static void logPatternCompilerError(ServiceConfigurationError P_0)
	{
		logger.log(Level.WARNING, "Error loading regex compiler, falling back to next option", P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 63, 134, 114, 127, 0, 240, 72, 251, 70 })]
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

	[LineNumberTable(new byte[] { 159, 176, 121 })]
	static Platform()
	{
		logger = Logger.getLogger(ClassLiteral<Platform>.Value.getName(), Platform.___003CGetCallerID_003E());
		patternCompiler = loadPatternCompiler();
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
