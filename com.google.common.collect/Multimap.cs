using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 93, 0, 0,
	17, 1, 0, 0, 0, 93, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)93,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ImmutableMultimap, HashMultimap, or another implementation"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public interface Multimap
{
	private static class ___003C_003EPIM
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(345)]
		internal static void lambda_0024forEach_00240(BiConsumer P_0, Map.Entry P_1)
		{
			P_0.accept(P_1.getKey(), P_1.getValue());
		}
	}

	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static void forEach(Multimap P_0, BiConsumer P_1)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EforEach(P_0, P_1);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly BiConsumer arg_00241;

		internal ___003C_003EAnon1(BiConsumer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			___003C_003EPIM.lambda_0024forEach_00240(arg_00241, (Map.Entry)P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	virtual Collection entries();

	virtual int size();

	virtual bool isEmpty();

	virtual bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual bool containsEntry([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2);

	[Signature("(TK;TV;)Z")]
	virtual bool put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2);

	virtual bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2);

	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Z")]
	virtual bool putAll([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i);

	[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Z")]
	virtual bool putAll(Multimap m);

	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Collection<TV;>;")]
	virtual Collection replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i);

	[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
	virtual Collection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual void clear();

	[Signature("(TK;)Ljava/util/Collection<TV;>;")]
	virtual Collection get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[Signature("()Ljava/util/Set<TK;>;")]
	virtual Set keySet();

	[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
	virtual Multiset keys();

	[Signature("()Ljava/util/Collection<TV;>;")]
	virtual Collection values();

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	virtual void forEach(BiConsumer action);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 160, 230, 103, 120 })]
	static void _003Cdefault_003EforEach(Multimap P_0, BiConsumer P_1)
	{
		Preconditions.checkNotNull(P_1);
		P_0.entries().forEach(new ___003C_003EAnon1(P_1));
	}

	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	virtual Map asMap();

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual int hashCode();
}
