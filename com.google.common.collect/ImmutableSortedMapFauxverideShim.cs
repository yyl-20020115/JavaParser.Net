using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)32,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ImmutableSortedMapFauxverideShim : ImmutableMap
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	internal ImmutableSortedMapFauxverideShim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
	[LineNumberTable(50)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static Collector toImmutableMap(Function P_0, Function P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
	[LineNumberTable(68)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static Collector toImmutableMap(Function P_0, Function P_1, BinaryOperator P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
	[LineNumberTable(82)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap.Builder builder()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Lcom/google/common/collect/ImmutableSortedMap$Builder<TK;TV;>;")]
	[LineNumberTable(94)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap.Builder builderWithExpectedSize(int P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(109)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(124)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(139)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(155)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(172)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(189)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(206)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11, object P_12, object P_13)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(238)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11, object P_12, object P_13, object P_14, object P_15)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(272)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11, object P_12, object P_13, object P_14, object P_15, object P_16, object P_17)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(308)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, object P_6, object P_7, object P_8, object P_9, object P_10, object P_11, object P_12, object P_13, object P_14, object P_15, object P_16, object P_17, object P_18, object P_19)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>([Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;")]
	[LineNumberTable(320)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMap ofEntries(params Map.Entry[] P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[HideFromJava]
	static ImmutableSortedMapFauxverideShim()
	{
		ImmutableMap.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableSortedMapFauxverideShim(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
