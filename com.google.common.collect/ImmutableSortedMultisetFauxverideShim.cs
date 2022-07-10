using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util.function;
using java.util.stream;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
[ConstantPool(new object[]
{
	(byte)35,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ImmutableSortedMultisetFauxverideShim : ImmutableMultiset
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	internal ImmutableSortedMultisetFauxverideShim()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableMultiset<TE;>;>;")]
	[LineNumberTable(56)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static Collector toImmutableMultiset()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;E:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TE;>;Ljava/util/function/ToIntFunction<-TT;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMultiset<TE;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 35, 0, 0 })]
	[LineNumberTable(74)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static Collector toImmutableMultiset(Function P_0, ToIntFunction P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSortedMultiset$Builder<TE;>;")]
	[LineNumberTable(88)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMultiset.Builder builder()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(103)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMultiset of(object P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(118)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMultiset of(object P_0, object P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(133)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMultiset of(object P_0, object P_1, object P_2)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(148)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMultiset of(object P_0, object P_1, object P_2, object P_3)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(164)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMultiset of(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;[TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(181)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMultiset of(object P_0, object P_1, object P_2, object P_3, object P_4, object P_5, params object[] P_6)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>([TE;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(196)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static ImmutableSortedMultiset copyOf(object[] P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[HideFromJava]
	static ImmutableSortedMultisetFauxverideShim()
	{
		ImmutableMultiset.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableSortedMultisetFauxverideShim(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
