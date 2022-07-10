using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Multimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 42, 0, 0,
	17, 1, 0, 0, 0, 42, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)42,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Multimap" })]
public interface ListMultimap : Multimap
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static Collection get(ListMultimap P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Eget(P_0, P_1);
		}

		public unsafe static Collection removeAll(ListMultimap P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EremoveAll(P_0, P_1);
		}

		public unsafe static Collection replaceValues(ListMultimap P_0, object P_1, Iterable P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EreplaceValues(P_0, P_1, P_2);
		}
	}

	[Signature("(TK;)Ljava/util/List<TV;>;")]
	List get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[Signature("(Ljava/lang/Object;)Ljava/util/List<TV;>;")]
	List removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/List<TV;>;")]
	List replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i);

	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	Map asMap();

	bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Collection _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(42)]
	static Collection _003Cdefault_003E_003Cbridge_003Eget(ListMultimap P_0, object P_1)
	{
		List result = P_0.get(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Collection _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(42)]
	static Collection _003Cdefault_003E_003Cbridge_003EremoveAll(ListMultimap P_0, object P_1)
	{
		List result = P_0.removeAll(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Collection _003Cbridge_003EreplaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(42)]
	static Collection _003Cdefault_003E_003Cbridge_003EreplaceValues(ListMultimap P_0, object P_1, Iterable P_2)
	{
		List result = P_0.replaceValues(P_1, P_2);
		_ = null;
		return result;
	}
}
