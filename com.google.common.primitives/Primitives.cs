using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
public sealed class Primitives : Object
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/Map<Ljava/lang/Class<*>;Ljava/lang/Class<*>;>;")]
	private static Map PRIMITIVE_TO_WRAPPER_TYPE;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/Map<Ljava/lang/Class<*>;Ljava/lang/Class<*>;>;")]
	private static Map WRAPPER_TO_PRIMITIVE_TYPE;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Ljava/lang/Class<TT;>;")]
	[LineNumberTable(new byte[] { 63, 199, 113 })]
	public static Class wrap(Class type)
	{
		Preconditions.checkNotNull(type);
		Class @class = (Class)PRIMITIVE_TO_WRAPPER_TYPE.get(type);
		return (@class != null) ? @class : type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/Class<*>;Ljava/lang/Class<*>;>;Ljava/util/Map<Ljava/lang/Class<*>;Ljava/lang/Class<*>;>;Ljava/lang/Class<*>;Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[] { 18, 105, 105 })]
	private static void add(Map P_0, Map P_1, Class P_2, Class P_3)
	{
		P_0.put(P_2, P_3);
		P_1.put(P_3, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	private Primitives()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/lang/Class<*>;>;")]
	[LineNumberTable(80)]
	public static Set allPrimitiveTypes()
	{
		Set result = PRIMITIVE_TO_WRAPPER_TYPE.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/lang/Class<*>;>;")]
	[LineNumberTable(89)]
	public static Set allWrapperTypes()
	{
		Set result = WRAPPER_TO_PRIMITIVE_TYPE.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Z")]
	[LineNumberTable(99)]
	public static bool isWrapperType(Class type)
	{
		bool result = WRAPPER_TO_PRIMITIVE_TYPE.containsKey(Preconditions.checkNotNull(type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Ljava/lang/Class<TT;>;")]
	[LineNumberTable(new byte[] { 82, 199, 113 })]
	public static Class unwrap(Class type)
	{
		Preconditions.checkNotNull(type);
		Class @class = (Class)WRAPPER_TO_PRIMITIVE_TYPE.get(type);
		return (@class != null) ? @class : type;
	}

	[LineNumberTable(new byte[]
	{
		159, 188, 104, 136, 113, 113, 113, 113, 113, 113,
		113, 113, 145, 107, 107
	})]
	static Primitives()
	{
		LinkedHashMap linkedHashMap = new LinkedHashMap(16);
		LinkedHashMap linkedHashMap2 = new LinkedHashMap(16);
		add(linkedHashMap, linkedHashMap2, Boolean.TYPE, ClassLiteral<Boolean>.Value);
		add(linkedHashMap, linkedHashMap2, Byte.TYPE, ClassLiteral<Byte>.Value);
		add(linkedHashMap, linkedHashMap2, Character.TYPE, ClassLiteral<Character>.Value);
		add(linkedHashMap, linkedHashMap2, Double.TYPE, ClassLiteral<Double>.Value);
		add(linkedHashMap, linkedHashMap2, Float.TYPE, ClassLiteral<Float>.Value);
		add(linkedHashMap, linkedHashMap2, Integer.TYPE, ClassLiteral<Integer>.Value);
		add(linkedHashMap, linkedHashMap2, Long.TYPE, ClassLiteral<Long>.Value);
		add(linkedHashMap, linkedHashMap2, Short.TYPE, ClassLiteral<Short>.Value);
		add(linkedHashMap, linkedHashMap2, Void.TYPE, ClassLiteral<Void>.Value);
		PRIMITIVE_TO_WRAPPER_TYPE = Collections.unmodifiableMap(linkedHashMap);
		WRAPPER_TO_PRIMITIVE_TYPE = Collections.unmodifiableMap(linkedHashMap2);
	}
}
