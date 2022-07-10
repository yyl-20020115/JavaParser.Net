using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal abstract class MultiEdgesConnecting : AbstractSet
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/AbstractIterator<TE;>;")]
	[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _1 : com.google.common.collect.AbstractIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024entries;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MultiEdgesConnecting this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(52)]
		internal _1(MultiEdgesConnecting P_0, Iterator P_1)
		{
			this_00240 = P_0;
			val_0024entries = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 6, 109, 113, 120, 137, 98 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			while (val_0024entries.hasNext())
			{
				Map.Entry entry = (Map.Entry)val_0024entries.next();
				if (Object.instancehelper_equals(access_0024000(this_00240), entry.getValue()))
				{
					object key = entry.getKey();
					_ = null;
					return key;
				}
			}
			object result = endOfData();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<TE;*>;")]
	private Map outEdgeToNode;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private object targetNode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(new byte[] { 1, 113 })]
	public new virtual UnmodifiableIterator iterator()
	{
		Iterator iterator = outEdgeToNode.entrySet().iterator();
		_1 result = new _1(this, iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;*>;Ljava/lang/Object;)V")]
	[LineNumberTable(new byte[] { 159, 186, 104, 113, 108 })]
	internal MultiEdgesConnecting(Map P_0, object P_1)
	{
		outEdgeToNode = (Map)Preconditions.checkNotNull(P_0);
		targetNode = Preconditions.checkNotNull(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(69)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = Object.instancehelper_equals(targetNode, outEdgeToNode.get(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(38)]
	public override Iterator iterator()
	{
		UnmodifiableIterator result = iterator();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(39)]
	internal static object access_0024000(MultiEdgesConnecting P_0)
	{
		return P_0.targetNode;
	}
}
