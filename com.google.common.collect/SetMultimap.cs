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
	0, 2, 17, 0, 0, 0, 0, 50, 0, 0,
	17, 1, 0, 0, 0, 50, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)50,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Multimap" })]
public interface SetMultimap : Multimap
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static Collection entries(SetMultimap P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Eentries(P_0);
		}

		public unsafe static Collection get(SetMultimap P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Eget(P_0, P_1);
		}

		public unsafe static Collection removeAll(SetMultimap P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EremoveAll(P_0, P_1);
		}

		public unsafe static Collection replaceValues(SetMultimap P_0, object P_1, Iterable P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EreplaceValues(P_0, P_1, P_2);
		}
	}

	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	Set entries();

	[Signature("(TK;)Ljava/util/Set<TV;>;")]
	Set get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[Signature("(Ljava/lang/Object;)Ljava/util/Set<TV;>;")]
	Set removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Set<TV;>;")]
	Set replaceValues([ParametricNullness(new object[]
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
	virtual Collection _003Cbridge_003Eentries();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(54)]
	static Collection _003Cdefault_003E_003Cbridge_003Eentries(SetMultimap P_0)
	{
		Set result = P_0.entries();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Collection _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(54)]
	static Collection _003Cdefault_003E_003Cbridge_003Eget(SetMultimap P_0, object P_1)
	{
		Set result = P_0.get(P_1);
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
	[LineNumberTable(54)]
	static Collection _003Cdefault_003E_003Cbridge_003EremoveAll(SetMultimap P_0, object P_1)
	{
		Set result = P_0.removeAll(P_1);
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
	[LineNumberTable(54)]
	static Collection _003Cdefault_003E_003Cbridge_003EreplaceValues(SetMultimap P_0, object P_1, Iterable P_2)
	{
		Set result = P_0.replaceValues(P_1, P_2);
		_ = null;
		return result;
	}
}
