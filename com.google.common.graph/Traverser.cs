using System;
using System.Collections;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Call forGraph or forTree, passing a lambda or a Graph with the desired edges (built with GraphBuilder)"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public abstract class Traverser : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/graph/Traverser<TN;>;")]
	[EnclosingMethod(null, "forGraph", "(Lcom.google.common.graph.SuccessorsFunction;)Lcom.google.common.graph.Traverser;")]
	internal class _1 : Traverser
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal SuccessorsFunction val_0024graph;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(100)]
		internal _1(SuccessorsFunction P_0, SuccessorsFunction P_1)
		{
			val_0024graph = P_1;
			base._002Ector(P_0, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/Traverser$Traversal<TN;>;")]
		[LineNumberTable(103)]
		internal override Traversal newTraversal()
		{
			Traversal result = Traversal.inGraph(val_0024graph);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/graph/Traverser<TN;>;")]
	[EnclosingMethod(null, "forTree", "(Lcom.google.common.graph.SuccessorsFunction;)Lcom.google.common.graph.Traverser;")]
	internal class _2 : Traverser
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal SuccessorsFunction val_0024tree;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(188)]
		internal _2(SuccessorsFunction P_0, SuccessorsFunction P_1)
		{
			val_0024tree = P_1;
			base._002Ector(P_0, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/Traverser$Traversal<TN;>;")]
		[LineNumberTable(191)]
		internal override Traversal newTraversal()
		{
			Traversal result = Traversal.inTree(val_0024tree);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/lang/Iterable<TN;>;")]
	[EnclosingMethod(null, "breadthFirst", "(Ljava.lang.Iterable;)Ljava.lang.Iterable;")]
	[Implements(new string[] { "java.lang.Iterable" })]
	internal class _3 : java.lang.Object, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableSet val_0024validated;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Traverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(243)]
		internal _3(Traverser P_0, ImmutableSet P_1)
		{
			this_00240 = P_0;
			val_0024validated = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TN;>;")]
		[LineNumberTable(246)]
		public virtual Iterator iterator()
		{
			Iterator result = this_00240.newTraversal().breadthFirst(val_0024validated.iterator());
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Spliterator spliterator()
		{
			return Iterable._003Cdefault_003Espliterator(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/lang/Iterable<TN;>;")]
	[EnclosingMethod(null, "depthFirstPreOrder", "(Ljava.lang.Iterable;)Ljava.lang.Iterable;")]
	[Implements(new string[] { "java.lang.Iterable" })]
	internal class _4 : java.lang.Object, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableSet val_0024validated;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Traverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(298)]
		internal _4(Traverser P_0, ImmutableSet P_1)
		{
			this_00240 = P_0;
			val_0024validated = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TN;>;")]
		[LineNumberTable(301)]
		public virtual Iterator iterator()
		{
			Iterator result = this_00240.newTraversal().preOrder(val_0024validated.iterator());
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Spliterator spliterator()
		{
			return Iterable._003Cdefault_003Espliterator(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/lang/Iterable<TN;>;")]
	[EnclosingMethod(null, "depthFirstPostOrder", "(Ljava.lang.Iterable;)Ljava.lang.Iterable;")]
	[Implements(new string[] { "java.lang.Iterable" })]
	internal class _5 : java.lang.Object, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableSet val_0024validated;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Traverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(353)]
		internal _5(Traverser P_0, ImmutableSet P_1)
		{
			this_00240 = P_0;
			val_0024validated = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TN;>;")]
		[LineNumberTable(356)]
		public virtual Iterator iterator()
		{
			Iterator result = this_00240.newTraversal().postOrder(val_0024validated.iterator());
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Spliterator spliterator()
		{
			return Iterable._003Cdefault_003Espliterator(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/graph/Traverser$InsertionOrder;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	internal abstract class InsertionOrder : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : InsertionOrder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(506)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<T:Ljava/lang/Object;>(Ljava/util/Deque<TT;>;TT;)V")]
			[LineNumberTable(new byte[] { 161, 139, 105 })]
			internal override void insertInto(Deque P_0, object P_1)
			{
				P_0.addFirst(P_1);
			}

			[HideFromJava]
			static _1()
			{
				InsertionOrder.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : InsertionOrder
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(512)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<T:Ljava/lang/Object;>(Ljava/util/Deque<TT;>;TT;)V")]
			[LineNumberTable(new byte[] { 161, 145, 105 })]
			internal override void insertInto(Deque P_0, object P_1)
			{
				P_0.addLast(P_1);
			}

			[HideFromJava]
			static _2()
			{
				InsertionOrder.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static InsertionOrder FRONT;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static InsertionOrder BACK;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static InsertionOrder[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(505)]
		private InsertionOrder(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(505)]
		private static InsertionOrder[] _0024values()
		{
			return new InsertionOrder[2] { FRONT, BACK };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(505)]
		public static InsertionOrder[] values()
		{
			return (InsertionOrder[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(505)]
		public static InsertionOrder valueOf(string P_0)
		{
			return (InsertionOrder)java.lang.Enum.valueOf(ClassLiteral<InsertionOrder>.Value, P_0);
		}

		[Signature("<T:Ljava/lang/Object;>(Ljava/util/Deque<TT;>;TT;)V")]
		internal abstract void insertInto(Deque P_0, object P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(505)]
		internal InsertionOrder(string P_0, int P_1, Traverser._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 161, 136, 240, 70, 240, 57 })]
		static InsertionOrder()
		{
			FRONT = new _1("FRONT", 0);
			BACK = new _2("BACK", 1);
			_0024VALUES = _0024values();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal abstract class Traversal : java.lang.Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/graph/Traverser$Traversal<TN;>;")]
		[EnclosingMethod(null, "inGraph", "(Lcom.google.common.graph.SuccessorsFunction;)Lcom.google.common.graph.Traverser$Traversal;")]
		internal class _1 : Traversal
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Set val_0024visited;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(386)]
			internal _1(SuccessorsFunction P_0, Set P_1)
			{
				val_0024visited = P_1;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Deque<Ljava/util/Iterator<+TN;>;>;)TN;")]
			[LineNumberTable(new byte[]
			{
				161, 20, 108, 104, 231, 73, 103, 110, 130, 98,
				103
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal override object visitNext(Deque P_0)
			{
				Iterator iterator = (Iterator)P_0.getFirst();
				while (iterator.hasNext())
				{
					object obj = iterator.next();
					java.util.Objects.requireNonNull(obj);
					if (val_0024visited.add(obj))
					{
						return obj;
					}
				}
				P_0.removeFirst();
				return null;
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/graph/Traverser$Traversal<TN;>;")]
		[EnclosingMethod(null, "inTree", "(Lcom.google.common.graph.SuccessorsFunction;)Lcom.google.common.graph.Traverser$Traversal;")]
		internal class _2 : Traversal
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(413)]
			internal _2(SuccessorsFunction P_0)
				: base(P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Deque<Ljava/util/Iterator<+TN;>;>;)TN;")]
			[LineNumberTable(new byte[] { 161, 47, 108, 104, 142, 103 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal override object visitNext(Deque P_0)
			{
				Iterator iterator = (Iterator)P_0.getFirst();
				if (iterator.hasNext())
				{
					object result = Preconditions.checkNotNull(iterator.next());
					_ = null;
					return result;
				}
				P_0.removeFirst();
				return null;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<TN;>;")]
		[EnclosingMethod(null, "topDown", "(Ljava.util.Iterator;Lcom.google.common.graph.Traverser$InsertionOrder;)Ljava.util.Iterator;")]
		internal class _3 : com.google.common.collect.AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Deque val_0024horizon;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal InsertionOrder val_0024order;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Traversal this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(444)]
			internal _3(Traversal P_0, Deque P_1, InsertionOrder P_2)
			{
				this_00240 = P_0;
				val_0024horizon = P_1;
				val_0024order = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TN;")]
			[LineNumberTable(new byte[] { 161, 79, 114, 99, 119, 168, 146, 130, 109 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				do
				{
					object obj = this_00240.visitNext(val_0024horizon);
					if (obj != null)
					{
						Iterator iterator = this_00240.successorFunction.successors(obj).iterator();
						if (iterator.hasNext())
						{
							val_0024order.insertInto(val_0024horizon, iterator);
						}
						return obj;
					}
				}
				while (!val_0024horizon.isEmpty());
				object result = endOfData();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<TN;>;")]
		[EnclosingMethod(null, "postOrder", "(Ljava.util.Iterator;)Ljava.util.Iterator;")]
		internal class _4 : com.google.common.collect.AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Deque val_0024horizon;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Deque val_0024ancestorStack;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Traversal this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(469)]
			internal _4(Traversal P_0, Deque P_1, Deque P_2)
			{
				this_00240 = P_0;
				val_0024horizon = P_1;
				val_0024ancestorStack = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TN;")]
			[LineNumberTable(new byte[]
			{
				161, 103, 117, 119, 104, 130, 108, 236, 58, 244,
				73, 109, 142
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				for (object obj = this_00240.visitNext(val_0024horizon); obj != null; obj = this_00240.visitNext(val_0024horizon))
				{
					Iterator iterator = this_00240.successorFunction.successors(obj).iterator();
					if (!iterator.hasNext())
					{
						return obj;
					}
					val_0024horizon.addFirst(iterator);
					val_0024ancestorStack.push(obj);
				}
				if (!val_0024ancestorStack.isEmpty())
				{
					object result = val_0024ancestorStack.pop();
					_ = null;
					return result;
				}
				object result2 = endOfData();
				_ = null;
				return result2;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/graph/SuccessorsFunction<TN;>;")]
		internal SuccessorsFunction successorFunction;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/SuccessorsFunction<TN;>;)Lcom/google/common/graph/Traverser$Traversal<TN;>;")]
		[LineNumberTable(new byte[] { 161, 15, 102 })]
		internal static Traversal inGraph(SuccessorsFunction P_0)
		{
			HashSet hashSet = new HashSet();
			_1 result = new _1(P_0, hashSet);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/SuccessorsFunction<TN;>;)Lcom/google/common/graph/Traverser$Traversal<TN;>;")]
		[LineNumberTable(413)]
		internal static Traversal inTree(SuccessorsFunction P_0)
		{
			_2 result = new _2(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TN;>;)Ljava/util/Iterator<TN;>;")]
		[LineNumberTable(428)]
		internal Iterator breadthFirst(Iterator P_0)
		{
			Iterator result = topDown(P_0, InsertionOrder.BACK);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TN;>;)Ljava/util/Iterator<TN;>;")]
		[LineNumberTable(432)]
		internal Iterator preOrder(Iterator P_0)
		{
			Iterator result = topDown(P_0, InsertionOrder.FRONT);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TN;>;)Ljava/util/Iterator<TN;>;")]
		[LineNumberTable(new byte[] { 161, 96, 102, 102, 104 })]
		internal Iterator postOrder(Iterator P_0)
		{
			ArrayDeque arrayDeque = new ArrayDeque();
			ArrayDeque arrayDeque2 = new ArrayDeque();
			((Deque)arrayDeque2).add((object)P_0);
			_4 result = new _4(this, arrayDeque2, arrayDeque);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TN;>;Lcom/google/common/graph/Traverser$InsertionOrder;)Ljava/util/Iterator<TN;>;")]
		[LineNumberTable(new byte[] { 161, 72, 102, 104 })]
		private Iterator topDown(Iterator P_0, InsertionOrder P_1)
		{
			ArrayDeque arrayDeque = new ArrayDeque();
			((Deque)arrayDeque).add((object)P_0);
			_3 result = new _3(this, arrayDeque, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/SuccessorsFunction<TN;>;)V")]
		[LineNumberTable(new byte[] { 161, 10, 104, 103 })]
		internal Traversal(SuccessorsFunction P_0)
		{
			successorFunction = P_0;
		}

		[Signature("(Ljava/util/Deque<Ljava/util/Iterator<+TN;>;>;)TN;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal abstract object visitNext(Deque P_0);
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/SuccessorsFunction<TN;>;")]
	private SuccessorsFunction successorFunction;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/SuccessorsFunction<TN;>;)Lcom/google/common/graph/Traverser<TN;>;")]
	[LineNumberTable(100)]
	public static Traverser forGraph(SuccessorsFunction graph)
	{
		_1 result = new _1(graph, graph);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/lang/Iterable<TN;>;")]
	[LineNumberTable(228)]
	public Iterable breadthFirst(object startNode)
	{
		Iterable result = breadthFirst(ImmutableSet.of(startNode));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/SuccessorsFunction<TN;>;)V")]
	[LineNumberTable(new byte[] { 21, 104, 113 })]
	private Traverser(SuccessorsFunction P_0)
	{
		successorFunction = (SuccessorsFunction)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TN;>;)Ljava/lang/Iterable<TN;>;")]
	[LineNumberTable(new byte[] { 160, 128, 104 })]
	public Iterable breadthFirst(Iterable startNodes)
	{
		ImmutableSet immutableSet = validate(startNodes);
		_3 result = new _3(this, immutableSet);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TN;>;)Lcom/google/common/collect/ImmutableSet<TN;>;")]
	[LineNumberTable(new byte[] { 160, 251, 103, 118, 109, 98 })]
	private ImmutableSet validate(Iterable P_0)
	{
		ImmutableSet immutableSet = ImmutableSet.copyOf(P_0);
		UnmodifiableIterator unmodifiableIterator = immutableSet.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			object obj = ((Iterator)unmodifiableIterator).next();
			successorFunction.successors(obj);
		}
		return immutableSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TN;>;)Ljava/lang/Iterable<TN;>;")]
	[LineNumberTable(new byte[] { 160, 183, 104 })]
	public Iterable depthFirstPreOrder(Iterable startNodes)
	{
		ImmutableSet immutableSet = validate(startNodes);
		_4 result = new _4(this, immutableSet);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TN;>;)Ljava/lang/Iterable<TN;>;")]
	[LineNumberTable(new byte[] { 160, 238, 104 })]
	public Iterable depthFirstPostOrder(Iterable startNodes)
	{
		ImmutableSet immutableSet = validate(startNodes);
		_5 result = new _5(this, immutableSet);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/SuccessorsFunction<TN;>;)Lcom/google/common/graph/Traverser<TN;>;")]
	[LineNumberTable(new byte[] { 160, 68, 104, 149, 104, 149 })]
	public static Traverser forTree(SuccessorsFunction tree)
	{
		if (tree is BaseGraph)
		{
			Preconditions.checkArgument(((BaseGraph)tree).isDirected(), (object)"Undirected graphs can never be trees.");
		}
		if (tree is Network)
		{
			Preconditions.checkArgument(((Network)tree).isDirected(), (object)"Undirected networks can never be trees.");
		}
		_2 result = new _2(tree, tree);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/lang/Iterable<TN;>;")]
	[LineNumberTable(283)]
	public Iterable depthFirstPreOrder(object startNode)
	{
		Iterable result = depthFirstPreOrder(ImmutableSet.of(startNode));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/lang/Iterable<TN;>;")]
	[LineNumberTable(338)]
	public Iterable depthFirstPostOrder(object startNode)
	{
		Iterable result = depthFirstPostOrder(ImmutableSet.of(startNode));
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("()Lcom/google/common/graph/Traverser$Traversal<TN;>;")]
	internal virtual Traversal newTraversal()
	{
		throw new AbstractMethodError("com.google.common.graph.Traverser.newTraversal()Lcom.google.common.graph.Traverser$Traversal;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(68)]
	internal Traverser(SuccessorsFunction P_0, _1 P_1)
		: this(P_0)
	{
	}
}
