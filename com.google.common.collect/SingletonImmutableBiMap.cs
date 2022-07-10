using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using java.lang;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SingletonImmutableBiMap : ImmutableBiMap
{
	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("TK;")]
	internal object singleKey;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("TV;")]
	internal object singleValue;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new ImmutableBiMap m_inverse;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ImmutableBiMap lazyInverse;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)V")]
	[LineNumberTable(new byte[] { 159, 184, 104, 103, 103, 103, 103 })]
	internal SingletonImmutableBiMap(object P_0, object P_1)
	{
		CollectPreconditions.checkEntryNotNull(P_0, P_1);
		singleKey = P_0;
		singleValue = P_1;
		this.m_inverse = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;)V")]
	[LineNumberTable(new byte[] { 159, 191, 104, 103, 103, 103 })]
	private SingletonImmutableBiMap(object P_0, object P_1, ImmutableBiMap P_2)
	{
		singleKey = P_0;
		singleValue = P_1;
		this.m_inverse = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;")]
	[LineNumberTable(new byte[] { 51, 104, 167, 103, 99, 158 })]
	public override ImmutableBiMap inverse()
	{
		if (this.m_inverse != null)
		{
			return this.m_inverse;
		}
		ImmutableBiMap immutableBiMap = lazyInverse;
		if (immutableBiMap == null)
		{
			SingletonImmutableBiMap result = new SingletonImmutableBiMap(singleValue, singleKey, this);
			lazyInverse = result;
			return result;
		}
		return immutableBiMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(58)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (!java.lang.Object.instancehelper_equals(singleKey, P_0)) ? null : singleValue;
	}

	public override int size()
	{
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 18, 126 })]
	public override void forEach(BiConsumer P_0)
	{
		((BiConsumer)Preconditions.checkNotNull(P_0)).accept(singleKey, singleValue);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = java.lang.Object.instancehelper_equals(singleKey, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = java.lang.Object.instancehelper_equals(singleValue, P_0);
		_ = null;
		return result;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(88)]
	internal override ImmutableSet createEntrySet()
	{
		ImmutableSet result = ImmutableSet.of(Maps.immutableEntry(singleKey, singleValue));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	[LineNumberTable(93)]
	internal override ImmutableSet createKeySet()
	{
		ImmutableSet result = ImmutableSet.of(singleKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public new virtual BiMap inverse()
	{
		ImmutableBiMap result = this.inverse();
		_ = null;
		return result;
	}

	[HideFromJava]
	static SingletonImmutableBiMap()
	{
		ImmutableBiMap.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected SingletonImmutableBiMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
