using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>;Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 53, 0, 0,
	17, 1, 0, 0, 0, 53, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)53,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SetMultimap" })]
internal abstract class AbstractSetMultimap : AbstractMapBasedMultimap, SetMultimap, Multimap
{
	private const long serialVersionUID = 7431625294878419160L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(89)]
	public new virtual Set entries()
	{
		return (Set)base.entries();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Set<TV;>;")]
	[LineNumberTable(78)]
	public new virtual Set get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		return (Set)base.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/Set<TV;>;")]
	[LineNumberTable(101)]
	public new virtual Set removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (Set)base.removeAll(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Set<TV;>;")]
	[LineNumberTable(115)]
	public new virtual Set replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		return (Set)base.replaceValues(P_0, P_1);
	}

	[Signature("()Ljava/util/Set<TV;>;")]
	internal new abstract Set createCollection();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TV;>;")]
	[LineNumberTable(54)]
	internal new virtual Set createUnmodifiableEmptyCollection()
	{
		Set result = Collections.emptySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;)V")]
	[LineNumberTable(new byte[] { 159, 188, 105 })]
	protected internal AbstractSetMultimap(Map P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/Collection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 53, 0, 0 })]
	[LineNumberTable(60)]
	internal override Collection unmodifiableCollectionSubclass(Collection P_0)
	{
		Set result = Collections.unmodifiableSet((Set)P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/Collection<TV;>;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(65)]
	internal override Collection wrapCollection([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Collection P_1)
	{
		WrappedSet result = new WrappedSet(this, P_0, (Set)P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(126)]
	public override Map asMap()
	{
		Map result = base.asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)Z")]
	[LineNumberTable(140)]
	public override bool put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		bool result = base.put(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(151)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = base.equals(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Collection entries()
	{
		Set result = entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Collection get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Set result = get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Collection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Set result = removeAll(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Collection replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		Set result = replaceValues(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal override Collection createCollection()
	{
		Set result = createCollection();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal override Collection createUnmodifiableEmptyCollection()
	{
		Set result = createUnmodifiableEmptyCollection();
		_ = null;
		return result;
	}

	Collection SetMultimap.SetMultimap_003A_003Aentries()
	{
		return this.entries();
	}

	Collection SetMultimap.SetMultimap_003A_003Aget(object P_0)
	{
		return this.get(P_0);
	}

	Collection SetMultimap.SetMultimap_003A_003AremoveAll(object P_0)
	{
		return this.removeAll(P_0);
	}

	Collection SetMultimap.SetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return this.replaceValues(P_0, P_1);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected AbstractSetMultimap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
