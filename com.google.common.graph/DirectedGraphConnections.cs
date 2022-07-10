using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent.atomic;
using java.util.function;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/GraphConnections<TN;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class DirectedGraphConnections : java.lang.Object, GraphConnections
{
	[SpecialName]
	[Signature("Ljava/util/AbstractSet<TN;>;")]
	[EnclosingMethod(null, "adjacentNodes", "()Ljava.util.Set;")]
	internal class _1 : AbstractSet
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/AbstractIterator<TN;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _1 : com.google.common.collect.AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024nodeConnections;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Set val_0024seenNodes;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(244)]
			internal _1(DirectedGraphConnections._1 P_0, Iterator P_1, Set P_2)
			{
				val_0024nodeConnections = P_1;
				val_0024seenNodes = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TN;")]
			[LineNumberTable(new byte[] { 160, 134, 109, 113, 114, 99, 135, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				while (val_0024nodeConnections.hasNext())
				{
					NodeConnection nodeConnection = (NodeConnection)val_0024nodeConnections.next();
					if (val_0024seenNodes.add(nodeConnection.node))
					{
						return nodeConnection.node;
					}
				}
				object result = endOfData();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DirectedGraphConnections this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TN;>;")]
		[LineNumberTable(new byte[] { 160, 128, 113, 102 })]
		public new virtual UnmodifiableIterator iterator()
		{
			Iterator iterator = access_0024000(this_00240).iterator();
			HashSet hashSet = new HashSet();
			_1 result = new _1(this, iterator, hashSet);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(239)]
		internal _1(DirectedGraphConnections P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(262)]
		public override int size()
		{
			int result = access_0024100(this_00240).size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(267)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = access_0024100(this_00240).containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(239)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/util/AbstractSet<TN;>;")]
	[EnclosingMethod(null, "predecessors", "()Ljava.util.Set;")]
	internal class _2 : AbstractSet
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/AbstractIterator<TN;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _1 : com.google.common.collect.AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024entries;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(280)]
			internal _1(DirectedGraphConnections._2 P_0, Iterator P_1)
			{
				val_0024entries = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TN;")]
			[LineNumberTable(new byte[] { 160, 170, 109, 113, 109, 137, 98 })]
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
					if (access_0024200(entry.getValue()))
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

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/AbstractIterator<TN;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _2 : com.google.common.collect.AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024nodeConnections;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(295)]
			internal _2(DirectedGraphConnections._2 P_0, Iterator P_1)
			{
				val_0024nodeConnections = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TN;")]
			[LineNumberTable(new byte[] { 160, 185, 109, 113, 104, 135, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				while (val_0024nodeConnections.hasNext())
				{
					NodeConnection nodeConnection = (NodeConnection)val_0024nodeConnections.next();
					if (nodeConnection is NodeConnection.Pred)
					{
						return nodeConnection.node;
					}
				}
				object result = endOfData();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DirectedGraphConnections this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(275)]
		internal _2(DirectedGraphConnections P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TN;>;")]
		[LineNumberTable(new byte[] { 160, 164, 109, 118, 234, 78, 113 })]
		public new virtual UnmodifiableIterator iterator()
		{
			Iterator iterator;
			if (access_0024000(this_00240) == null)
			{
				iterator = access_0024100(this_00240).entrySet().iterator();
				_1 result = new _1(this, iterator);
				_ = null;
				return result;
			}
			iterator = access_0024000(this_00240).iterator();
			_2 result2 = new _2(this, iterator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(313)]
		public override int size()
		{
			int result = access_0024300(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(318)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = access_0024200(access_0024100(this_00240).get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(275)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/util/AbstractSet<TN;>;")]
	[EnclosingMethod(null, "successors", "()Ljava.util.Set;")]
	internal class _3 : AbstractSet
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/AbstractIterator<TN;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _1 : com.google.common.collect.AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024entries;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(330)]
			internal _1(_3 P_0, Iterator P_1)
			{
				val_0024entries = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TN;")]
			[LineNumberTable(new byte[] { 160, 220, 109, 113, 109, 137, 98 })]
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
					if (access_0024400(entry.getValue()))
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

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/AbstractIterator<TN;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _2 : com.google.common.collect.AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024nodeConnections;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(345)]
			internal _2(_3 P_0, Iterator P_1)
			{
				val_0024nodeConnections = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TN;")]
			[LineNumberTable(new byte[] { 160, 235, 109, 113, 104, 135, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				while (val_0024nodeConnections.hasNext())
				{
					NodeConnection nodeConnection = (NodeConnection)val_0024nodeConnections.next();
					if (nodeConnection is NodeConnection.Succ)
					{
						return nodeConnection.node;
					}
				}
				object result = endOfData();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DirectedGraphConnections this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(325)]
		internal _3(DirectedGraphConnections P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TN;>;")]
		[LineNumberTable(new byte[] { 160, 214, 109, 118, 234, 78, 113 })]
		public new virtual UnmodifiableIterator iterator()
		{
			Iterator iterator;
			if (access_0024000(this_00240) == null)
			{
				iterator = access_0024100(this_00240).entrySet().iterator();
				_1 result = new _1(this, iterator);
				_ = null;
				return result;
			}
			iterator = access_0024000(this_00240).iterator();
			_2 result2 = new _2(this, iterator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(363)]
		public override int size()
		{
			int result = access_0024500(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(368)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = access_0024400(access_0024100(this_00240).get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(325)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/AbstractIterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[EnclosingMethod(null, "incidentEdgeIterator", "(Ljava.lang.Object;)Ljava.util.Iterator;")]
	internal class _4 : com.google.common.collect.AbstractIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024resultWithDoubleSelfLoop;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AtomicBoolean val_0024alreadySeenSelfLoop;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(401)]
		internal _4(DirectedGraphConnections P_0, Iterator P_1, AtomicBoolean P_2)
		{
			val_0024resultWithDoubleSelfLoop = P_1;
			val_0024alreadySeenSelfLoop = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/EndpointPair<TN;>;")]
		[LineNumberTable(new byte[] { 161, 35, 109, 113, 115, 110, 162, 130, 98 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal new virtual EndpointPair computeNext()
		{
			while (val_0024resultWithDoubleSelfLoop.hasNext())
			{
				EndpointPair endpointPair = (EndpointPair)val_0024resultWithDoubleSelfLoop.next();
				if (java.lang.Object.instancehelper_equals(endpointPair.nodeU(), endpointPair.nodeV()))
				{
					if (!val_0024alreadySeenSelfLoop.getAndSet(newValue: true))
					{
						return endpointPair;
					}
					continue;
				}
				return endpointPair;
			}
			return (EndpointPair)endOfData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(401)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			EndpointPair result = computeNext();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _5 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(161)]
		static _5()
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

		_5()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal abstract class NodeConnection : java.lang.Object
	{
		[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/DirectedGraphConnections$NodeConnection<TN;>;")]
		internal sealed class Pred : NodeConnection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TN;)V")]
			[LineNumberTable(new byte[] { 32, 105 })]
			internal Pred(object P_0)
				: base(P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 37, 104, 153 })]
			public override bool equals([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (P_0 is Pred)
				{
					bool result = java.lang.Object.instancehelper_equals(node, ((Pred)P_0).node);
					_ = null;
					return result;
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(97)]
			public override int hashCode()
			{
				return java.lang.Object.instancehelper_hashCode(ClassLiteral<Pred>.Value) + java.lang.Object.instancehelper_hashCode(node);
			}
		}

		[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/DirectedGraphConnections$NodeConnection<TN;>;")]
		internal sealed class Succ : NodeConnection
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TN;)V")]
			[LineNumberTable(new byte[] { 53, 105 })]
			internal Succ(object P_0)
				: base(P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 58, 104, 153 })]
			public override bool equals([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (P_0 is Succ)
				{
					bool result = java.lang.Object.instancehelper_equals(node, ((Succ)P_0).node);
					_ = null;
					return result;
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(118)]
			public override int hashCode()
			{
				return java.lang.Object.instancehelper_hashCode(ClassLiteral<Succ>.Value) + java.lang.Object.instancehelper_hashCode(node);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("TN;")]
		internal object node;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)V")]
		[LineNumberTable(new byte[] { 26, 104, 108 })]
		internal NodeConnection(object P_0)
		{
			node = Preconditions.checkNotNull(P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class PredAndSucc : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object successorValue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 12, 104, 103 })]
		internal PredAndSucc(object P_0)
		{
			successorValue = P_0;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(59)]
		internal static object access_0024600(PredAndSucc P_0)
		{
			return P_0.successorValue;
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

	[SpecialName]
	private sealed class ___003C_003EAnon1 : com.google.common.@base.Function
	{
		private readonly object arg_00241;

		internal ___003C_003EAnon1(object P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			EndpointPair result = lambda_0024incidentEdgeIterator_00241(arg_00241, P_0);
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

	[SpecialName]
	private sealed class ___003C_003EAnon2 : com.google.common.@base.Function
	{
		private readonly object arg_00241;

		internal ___003C_003EAnon2(object P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			EndpointPair result = lambda_0024incidentEdgeIterator_00242(arg_00241, (NodeConnection)P_0);
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static object PRED;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<TN;Ljava/lang/Object;>;")]
	private Map adjacentNodeValues;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/List<Lcom/google/common/graph/DirectedGraphConnections$NodeConnection<TN;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private List orderedNodeConnections;

	private int predecessorCount;

	private int successorCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static List access_0024000(DirectedGraphConnections P_0)
	{
		return P_0.orderedNodeConnections;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static Map access_0024100(DirectedGraphConnections P_0)
	{
		return P_0.adjacentNodeValues;
	}

	private static bool isSuccessor([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (P_0 != PRED && P_0 != null) ? true : false;
	}

	[LineNumberTable(558)]
	private static bool isPredecessor([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (P_0 == PRED || P_0 is PredAndSucc) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TN;Ljava/lang/Object;>;Ljava/util/List<Lcom/google/common/graph/DirectedGraphConnections$NodeConnection<TN;>;>;II)V")]
	[LineNumberTable(new byte[] { 96, 104, 113, 103, 108, 109, 98, 106, 11, 167 })]
	private DirectedGraphConnections(Map P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] List P_1, int P_2, int P_3)
	{
		adjacentNodeValues = (Map)Preconditions.checkNotNull(P_0);
		orderedNodeConnections = P_1;
		predecessorCount = Graphs.checkNonNegative(P_2);
		successorCount = Graphs.checkNonNegative(P_3);
		Preconditions.checkState((P_2 <= P_0.size() && P_3 <= P_0.size()) ? true : false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(275)]
	public virtual Set predecessors()
	{
		_2 result = new _2(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(325)]
	public virtual Set successors()
	{
		_3 result = new _3(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(383)]
	private static EndpointPair lambda_0024incidentEdgeIterator_00240(object P_0, object P_1)
	{
		EndpointPair result = EndpointPair.ordered(P_1, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(386)]
	private static EndpointPair lambda_0024incidentEdgeIterator_00241(object P_0, object P_1)
	{
		EndpointPair result = EndpointPair.ordered(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 161, 22, 104, 143 })]
	private static EndpointPair lambda_0024incidentEdgeIterator_00242(object P_0, NodeConnection P_1)
	{
		if (P_1 is NodeConnection.Succ)
		{
			EndpointPair result = EndpointPair.ordered(P_0, P_1.node);
			_ = null;
			return result;
		}
		EndpointPair result2 = EndpointPair.ordered(P_1.node, P_0);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ElementOrder<TN;>;)Lcom/google/common/graph/DirectedGraphConnections<TN;TV;>;")]
	[LineNumberTable(new byte[] { 108, 162, 159, 3, 98, 130, 102, 130, 177 })]
	internal static DirectedGraphConnections of(ElementOrder P_0)
	{
		int initialCapacity = 4;
		ArrayList arrayList;
		switch (_5._0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[P_0.type().ordinal()])
		{
		case 1:
			arrayList = null;
			break;
		case 2:
			arrayList = new ArrayList();
			break;
		default:
		{
			ElementOrder.Type detailMessage = P_0.type();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
		}
		}
		DirectedGraphConnections result = new DirectedGraphConnections(new HashMap(initialCapacity, 1f), arrayList, 0, 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(TN;Ljava/lang/Iterable<Lcom/google/common/graph/EndpointPair<TN;>;>;Lcom/google/common/base/Function<TN;TV;>;)Lcom/google/common/graph/DirectedGraphConnections<TN;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 67, 103, 135, 134, 102, 98, 130, 127, 3,
		190, 148, 109, 109, 100, 105, 111, 137, 111, 100,
		176, 110, 100, 101, 146, 105, 138, 108, 100, 110,
		176, 110, 132, 133, 130, 14
	})]
	internal static DirectedGraphConnections ofImmutable(object P_0, Iterable P_1, com.google.common.@base.Function P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_2);
		HashMap hashMap = new HashMap();
		ImmutableList.Builder builder = ImmutableList.builder();
		int num = 0;
		int num2 = 0;
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			EndpointPair endpointPair = (EndpointPair)iterator.next();
			if (java.lang.Object.instancehelper_equals(endpointPair.nodeU(), P_0) && java.lang.Object.instancehelper_equals(endpointPair.nodeV(), P_0))
			{
				((Map)hashMap).put(P_0, (object)new PredAndSucc(P_2.apply(P_0)));
				builder.add(new NodeConnection.Pred(P_0));
				builder.add(new NodeConnection.Succ(P_0));
				num++;
				num2++;
				continue;
			}
			object obj;
			object obj2;
			if (java.lang.Object.instancehelper_equals(endpointPair.nodeV(), P_0))
			{
				obj = endpointPair.nodeU();
				obj2 = ((Map)hashMap).put(obj, PRED);
				if (obj2 != null)
				{
					((Map)hashMap).put(obj, (object)new PredAndSucc(obj2));
				}
				builder.add(new NodeConnection.Pred(obj));
				num++;
				continue;
			}
			Preconditions.checkArgument(java.lang.Object.instancehelper_equals(endpointPair.nodeU(), P_0));
			obj = endpointPair.nodeV();
			obj2 = P_2.apply(obj);
			object obj3 = ((Map)hashMap).put(obj, obj2);
			if (obj3 != null)
			{
				Preconditions.checkArgument(obj3 == PRED);
				((Map)hashMap).put(obj, (object)new PredAndSucc(obj2));
			}
			builder.add(new NodeConnection.Succ(obj));
			num2++;
		}
		DirectedGraphConnections result = new DirectedGraphConnections(hashMap, builder.build(), num, num2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(new byte[] { 160, 122, 104, 147 })]
	public virtual Set adjacentNodes()
	{
		if (orderedNodeConnections == null)
		{
			Set result = Collections.unmodifiableSet(adjacentNodeValues.keySet());
			_ = null;
			return result;
		}
		_1 result2 = new _1(this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Iterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[LineNumberTable(new byte[]
	{
		161, 5, 167, 104, 161, 53, 198, 53, 229, 60,
		232, 72, 134, 48, 230, 75, 103
	})]
	public virtual Iterator incidentEdgeIterator(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		Iterator iterator = ((orderedNodeConnections != null) ? Iterators.transform(orderedNodeConnections.iterator(), new ___003C_003EAnon2(P_0)) : Iterators.concat(Iterators.transform(predecessors().iterator(), new ___003C_003EAnon0(P_0)), Iterators.transform(successors().iterator(), new ___003C_003EAnon1(P_0))));
		AtomicBoolean atomicBoolean = new AtomicBoolean(initialValue: false);
		_4 result = new _4(this, iterator, atomicBoolean);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)TV;")]
	[LineNumberTable(new byte[] { 161, 54, 103, 109, 104, 130, 104, 142 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object value(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		object obj = adjacentNodeValues.get(P_0);
		if (obj == PRED)
		{
			return null;
		}
		if (obj is PredAndSucc)
		{
			object result = PredAndSucc.access_0024600((PredAndSucc)obj);
			_ = null;
			return result;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)V")]
	[LineNumberTable(new byte[]
	{
		161, 68, 135, 173, 104, 109, 100, 104, 120, 132,
		162, 99, 153, 104, 178
	})]
	public virtual void removePredecessor(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		object obj = adjacentNodeValues.get(P_0);
		int num;
		if (obj == PRED)
		{
			adjacentNodeValues.remove(P_0);
			num = 1;
		}
		else if (obj is PredAndSucc)
		{
			adjacentNodeValues.put(P_0, PredAndSucc.access_0024600((PredAndSucc)obj));
			num = 1;
		}
		else
		{
			num = 0;
		}
		if (num != 0)
		{
			int num2 = predecessorCount - 1;
			predecessorCount = num2;
			Graphs.checkNonNegative(num2);
			if (orderedNodeConnections != null)
			{
				orderedNodeConnections.remove(new NodeConnection.Pred(P_0));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[]
	{
		161, 96, 103, 173, 107, 100, 104, 114, 142, 109,
		162, 99, 153, 104, 242, 75
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object removeSuccessor(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		object obj = adjacentNodeValues.get(P_0);
		object obj2;
		if (obj == null || obj == PRED)
		{
			obj2 = null;
		}
		else if (obj is PredAndSucc)
		{
			adjacentNodeValues.put(P_0, PRED);
			obj2 = PredAndSucc.access_0024600((PredAndSucc)obj);
		}
		else
		{
			adjacentNodeValues.remove(P_0);
			obj2 = obj;
		}
		if (obj2 != null)
		{
			int num = successorCount - 1;
			successorCount = num;
			Graphs.checkNonNegative(num);
			if (orderedNodeConnections != null)
			{
				orderedNodeConnections.remove(new NodeConnection.Succ(P_0));
			}
		}
		return (obj2 != null) ? obj2 : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TV;)V")]
	[LineNumberTable(new byte[]
	{
		161, 130, 178, 99, 100, 136, 110, 100, 136, 115,
		132, 162, 99, 153, 104, 178
	})]
	public virtual void addPredecessor(object P_0, object P_1)
	{
		object obj = adjacentNodeValues.put(P_0, PRED);
		int num;
		if (obj == null)
		{
			num = 1;
		}
		else if (obj is PredAndSucc)
		{
			adjacentNodeValues.put(P_0, obj);
			num = 0;
		}
		else if (obj != PRED)
		{
			adjacentNodeValues.put(P_0, new PredAndSucc(obj));
			num = 1;
		}
		else
		{
			num = 0;
		}
		if (num != 0)
		{
			int num2 = predecessorCount + 1;
			predecessorCount = num2;
			Graphs.checkPositive(num2);
			if (orderedNodeConnections != null)
			{
				orderedNodeConnections.add(new NodeConnection.Pred(P_0));
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TV;)TV;")]
	[LineNumberTable(new byte[]
	{
		161, 160, 174, 99, 100, 104, 115, 110, 104, 115,
		132, 162, 99, 153, 104, 242, 69
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object addSuccessor(object P_0, object P_1)
	{
		object obj = adjacentNodeValues.put(P_0, P_1);
		object obj2;
		if (obj == null)
		{
			obj2 = null;
		}
		else if (obj is PredAndSucc)
		{
			adjacentNodeValues.put(P_0, new PredAndSucc(P_1));
			obj2 = PredAndSucc.access_0024600((PredAndSucc)obj);
		}
		else if (obj == PRED)
		{
			adjacentNodeValues.put(P_0, new PredAndSucc(P_1));
			obj2 = null;
		}
		else
		{
			obj2 = obj;
		}
		if (obj2 == null)
		{
			int num = successorCount + 1;
			successorCount = num;
			Graphs.checkPositive(num);
			if (orderedNodeConnections != null)
			{
				orderedNodeConnections.add(new NodeConnection.Succ(P_0));
			}
		}
		return (obj2 != null) ? obj2 : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static bool access_0024200(object P_0)
	{
		bool result = isPredecessor(P_0);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static int access_0024300(DirectedGraphConnections P_0)
	{
		return P_0.predecessorCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static bool access_0024400(object P_0)
	{
		bool result = isSuccessor(P_0);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(54)]
	internal static int access_0024500(DirectedGraphConnections P_0)
	{
		return P_0.successorCount;
	}

	[LineNumberTable(123)]
	static DirectedGraphConnections()
	{
		PRED = new java.lang.Object();
	}
}
