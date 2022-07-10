using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractGraphBuilder : Object
{
	[Modifiers(Modifiers.Final)]
	internal bool directed;

	internal bool allowsSelfLoops;

	[Signature("Lcom/google/common/graph/ElementOrder<TN;>;")]
	internal ElementOrder nodeOrder;

	[Signature("Lcom/google/common/graph/ElementOrder<TN;>;")]
	internal ElementOrder incidentEdgeOrder;

	[Signature("Lcom/google/common/base/Optional<Ljava/lang/Integer;>;")]
	internal Optional expectedNodeCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 132, 98, 232, 52, 103, 107, 139, 235, 73,
		103
	})]
	internal AbstractGraphBuilder(bool P_0)
	{
		allowsSelfLoops = false;
		nodeOrder = ElementOrder.insertion();
		incidentEdgeOrder = ElementOrder.unordered();
		expectedNodeCount = Optional.absent();
		directed = P_0;
	}
}
