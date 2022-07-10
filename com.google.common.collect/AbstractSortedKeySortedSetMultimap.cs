using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractSortedSetMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 46, 0, 0,
	17, 1, 0, 0, 0, 46, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)46,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractSortedKeySortedSetMultimap : AbstractSortedSetMultimap
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(46)]
	public new virtual SortedMap asMap()
	{
		return (SortedMap)base.asMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedSet<TK;>;")]
	[LineNumberTable(56)]
	public new virtual SortedSet keySet()
	{
		return (SortedSet)base.keySet();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(51)]
	internal new virtual SortedMap backingMap()
	{
		return (SortedMap)base.backingMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;)V")]
	[LineNumberTable(new byte[] { 159, 183, 105 })]
	internal AbstractSortedKeySortedSetMultimap(SortedMap P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(61)]
	internal override Set createKeySet()
	{
		Set result = createMaybeNavigableKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override Map asMap()
	{
		SortedMap result = asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override Set keySet()
	{
		SortedSet result = keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal override Map backingMap()
	{
		SortedMap result = backingMap();
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected AbstractSortedKeySortedSetMultimap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
