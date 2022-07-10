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
internal abstract class ImmutableBiMapFauxverideShim : ImmutableMap
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	internal ImmutableBiMapFauxverideShim()
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

	[HideFromJava]
	static ImmutableBiMapFauxverideShim()
	{
		ImmutableMap.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableBiMapFauxverideShim(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
