using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.concurrent;
using java.util.logging;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)47,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
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
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 47, 0, 0,
		18, 1, 0, 0, 0, 47, 0, 0
	})]
	[LineNumberTable(41)]
	internal static Map newHashMapWithExpectedSize(int P_0)
	{
		HashMap result = Maps.newHashMapWithExpectedSize(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Ljava/lang/Object;II[TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(121)]
	internal static object[] copy(object[] P_0, int P_1, int P_2, object[] P_3)
	{
		object[] result = Arrays.copyOfRange(P_0, P_1, P_2, Object.instancehelper_getClass(P_3));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(55)]
	internal static Set newHashSetWithExpectedSize(int P_0)
	{
		HashSet result = Sets.newHashSetWithExpectedSize(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 47, 0, 0,
		18, 1, 0, 0, 0, 47, 0, 0
	})]
	[LineNumberTable(77)]
	internal static Map preservesInsertionOrderOnPutsMap()
	{
		LinkedHashMap result = Maps.newLinkedHashMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(85)]
	internal static Set preservesInsertionOrderOnAddsSet()
	{
		LinkedHashSet result = Sets.newLinkedHashSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 47, 0, 0,
		18, 1, 0, 0, 0, 47, 0, 0
	})]
	[LineNumberTable(50)]
	internal static Map newLinkedHashMapWithExpectedSize(int P_0)
	{
		LinkedHashMap result = Maps.newLinkedHashMapWithExpectedSize(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(68)]
	internal static Set newLinkedHashSetWithExpectedSize(int P_0)
	{
		LinkedHashSet result = Sets.newLinkedHashSetWithExpectedSize(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;I)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(new byte[] { 51, 236, 69, 109 })]
	internal static object[] newArray(object[] P_0, int P_1)
	{
		Class componentType = Object.instancehelper_getClass(P_0).getComponentType();
		return (object[])Array.newInstance(componentType, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(130)]
	internal static MapMaker tryWeakKeys(MapMaker P_0)
	{
		MapMaker result = P_0.weakKeys();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/Set<TE;>;")]
	[LineNumberTable(60)]
	internal static Set newConcurrentHashSet()
	{
		ConcurrentHashMap.KeySetView result = ConcurrentHashMap.newKeySet();
		_ = null;
		return result;
	}

	internal static int reduceIterationsIfGwt(int P_0)
	{
		return P_0;
	}

	internal static int reduceExponentIfGwt(int P_0)
	{
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 92, 134, 114, 127, 0, 240, 72, 251, 70 })]
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
	[LineNumberTable(162)]
	private Platform()
	{
	}

	[LineNumberTable(new byte[] { 159, 177, 101, 52 })]
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
