using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/GraphConnections<TN;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class UndirectedGraphConnections : java.lang.Object, GraphConnections
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(49)]
		static _1()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type = new int[(nint)ElementOrder.Type.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[ElementOrder.Type.___003C_003EUNORDERED.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			_ = null;
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[ElementOrder.Type.___003C_003ESTABLE.ordinal()] = 2;
				return;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}

		_1()
		{
			throw null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
	{
		private readonly object arg_00241;

		internal ___003C_003EAnon0(object P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			EndpointPair result = lambda_0024incidentEdgeIterator_00240(arg_00241, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<TN;TV;>;")]
	private Map adjacentNodeValues;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TN;TV;>;)Lcom/google/common/graph/UndirectedGraphConnections<TN;TV;>;")]
	[LineNumberTable(62)]
	internal static UndirectedGraphConnections ofImmutable(Map P_0)
	{
		UndirectedGraphConnections result = new UndirectedGraphConnections(ImmutableMap.copyOf(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ElementOrder<TN;>;)Lcom/google/common/graph/UndirectedGraphConnections<TN;TV;>;")]
	[LineNumberTable(new byte[] { 159, 191, 159, 3, 179, 179 })]
	internal static UndirectedGraphConnections of(ElementOrder P_0)
	{
		switch (_1._0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[P_0.type().ordinal()])
		{
		case 1:
		{
			UndirectedGraphConnections result2 = new UndirectedGraphConnections(new HashMap(2, 1f));
			_ = null;
			return result2;
		}
		case 2:
		{
			UndirectedGraphConnections result = new UndirectedGraphConnections(new LinkedHashMap(2, 1f));
			_ = null;
			return result;
		}
		default:
		{
			ElementOrder.Type detailMessage = P_0.type();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TN;TV;>;)V")]
	[LineNumberTable(new byte[] { 159, 186, 104, 113 })]
	private UndirectedGraphConnections(Map P_0)
	{
		adjacentNodeValues = (Map)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(67)]
	public virtual Set adjacentNodes()
	{
		Set result = Collections.unmodifiableSet(adjacentNodeValues.keySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)TV;")]
	[LineNumberTable(102)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object removeSuccessor(object P_0)
	{
		object result = adjacentNodeValues.remove(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TV;)TV;")]
	[LineNumberTable(114)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object addSuccessor(object P_0, object P_1)
	{
		object result = adjacentNodeValues.put(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	private static EndpointPair lambda_0024incidentEdgeIterator_00240(object P_0, object P_1)
	{
		EndpointPair result = EndpointPair.unordered(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(72)]
	public virtual Set predecessors()
	{
		Set result = adjacentNodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(77)]
	public virtual Set successors()
	{
		Set result = adjacentNodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Iterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[LineNumberTable(new byte[] { 32, 102, 53 })]
	public virtual Iterator incidentEdgeIterator(object P_0)
	{
		Iterator result = Iterators.transform(adjacentNodeValues.keySet().iterator(), new ___003C_003EAnon0(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)TV;")]
	[LineNumberTable(90)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object value(object P_0)
	{
		object result = adjacentNodeValues.get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)V")]
	[LineNumberTable(new byte[] { 46, 104 })]
	public virtual void removePredecessor(object P_0)
	{
		removeSuccessor(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TV;)V")]
	[LineNumberTable(new byte[] { 58, 105 })]
	public virtual void addPredecessor(object P_0, object P_1)
	{
		addSuccessor(P_0, P_1);
	}
}
