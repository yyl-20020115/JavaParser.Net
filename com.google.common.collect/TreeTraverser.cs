using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Obsolete]
[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
[Deprecated(new object[]
{
	(byte)64,
	"Ljava/lang/Deprecated;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class TreeTraverser : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/TreeTraverser<TT;>;")]
	[EnclosingMethod(null, "using", "(Lcom.google.common.base.Function;)Lcom.google.common.collect.TreeTraverser;")]
	internal class _1 : TreeTraverser
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal com.google.common.@base.Function val_0024nodeToChildrenFunction;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(95)]
		internal _1(com.google.common.@base.Function P_0)
		{
			val_0024nodeToChildrenFunction = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Ljava/lang/Iterable<TT;>;")]
		[LineNumberTable(98)]
		public override Iterable children(object P_0)
		{
			return (Iterable)val_0024nodeToChildrenFunction.apply(P_0);
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "preOrderTraversal", "(Ljava.lang.Object;)Lcom.google.common.collect.FluentIterable;")]
	internal class _2 : FluentIterable
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/function/Consumer<TT;>;")]
		[EnclosingMethod(null, "forEach", "(Ljava.util.function.Consumer;)V")]
		internal new class _1 : java.lang.Object, Consumer
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Consumer val_0024action;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TreeTraverser._2 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(128)]
			internal _1(TreeTraverser._2 P_0, Consumer P_1)
			{
				this_00241 = P_0;
				val_0024action = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TT;)V")]
			[LineNumberTable(new byte[] { 81, 108, 121 })]
			public virtual void accept(object P_0)
			{
				val_0024action.accept(P_0);
				this_00241.this_00240.children(P_0).forEach(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024root;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeTraverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(119)]
		internal _2(TreeTraverser P_0, object P_1)
		{
			this_00240 = P_0;
			val_0024root = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
		[LineNumberTable(122)]
		public new virtual UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = this_00240.preOrderIterator(val_0024root);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TT;>;)V")]
		[LineNumberTable(new byte[] { 77, 103, 237, 70, 103 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			new _1(this, P_0).accept(val_0024root);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(119)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "postOrderTraversal", "(Ljava.lang.Object;)Lcom.google.common.collect.FluentIterable;")]
	internal class _3 : FluentIterable
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/function/Consumer<TT;>;")]
		[EnclosingMethod(null, "forEach", "(Ljava.util.function.Consumer;)V")]
		internal new class _1 : java.lang.Object, Consumer
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Consumer val_0024action;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TreeTraverser._3 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(193)]
			internal _1(TreeTraverser._3 P_0, Consumer P_1)
			{
				this_00241 = P_0;
				val_0024action = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TT;)V")]
			[LineNumberTable(new byte[] { 160, 82, 119, 110 })]
			public virtual void accept(object P_0)
			{
				this_00241.this_00240.children(P_0).forEach(this);
				val_0024action.accept(P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024root;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeTraverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(184)]
		internal _3(TreeTraverser P_0, object P_1)
		{
			this_00240 = P_0;
			val_0024root = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
		[LineNumberTable(187)]
		public new virtual UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = this_00240.postOrderIterator(val_0024root);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TT;>;)V")]
		[LineNumberTable(new byte[] { 160, 78, 103, 237, 70, 103 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			new _1(this, P_0).accept(val_0024root);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(184)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "breadthFirstTraversal", "(Ljava.lang.Object;)Lcom.google.common.collect.FluentIterable;")]
	internal class _4 : FluentIterable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024root;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeTraverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(260)]
		internal _4(TreeTraverser P_0, object P_1)
		{
			this_00240 = P_0;
			val_0024root = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
		[LineNumberTable(263)]
		public new virtual UnmodifiableIterator iterator()
		{
			BreadthFirstIterator result = new BreadthFirstIterator(this_00240, val_0024root);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(260)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TT;>;Lcom/google/common/collect/PeekingIterator<TT;>;")]
	[Implements(new string[] { "com.google.common.collect.PeekingIterator" })]
	internal sealed class BreadthFirstIterator : UnmodifiableIterator, PeekingIterator, Iterator
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Queue<TT;>;")]
		private Queue queue;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeTraverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)V")]
		[LineNumberTable(new byte[] { 160, 158, 111, 107, 109 })]
		internal BreadthFirstIterator(TreeTraverser P_0, object P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			queue = new ArrayDeque();
			queue.add(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(279)]
		public override bool hasNext()
		{
			return (!queue.isEmpty()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(284)]
		public virtual object peek()
		{
			object result = queue.element();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 160, 175, 108, 120 })]
		public override object next()
		{
			object obj = queue.remove();
			Iterables.addAll(queue, this_00240.children(obj));
			return obj;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/AbstractIterator<TT;>;")]
	internal sealed class PostOrderIterator : AbstractIterator
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/ArrayDeque<Lcom/google/common/collect/TreeTraverser$PostOrderNode<TT;>;>;")]
		private ArrayDeque stack;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeTraverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)V")]
		[LineNumberTable(new byte[] { 160, 107, 111, 107, 116 })]
		internal PostOrderIterator(TreeTraverser P_0, object P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			stack = new ArrayDeque();
			stack.addLast(expand(P_1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)Lcom/google/common/collect/TreeTraverser$PostOrderNode<TT;>;")]
		[LineNumberTable(243)]
		private PostOrderNode expand(object P_0)
		{
			PostOrderNode result = new PostOrderNode(P_0, this_00240.children(P_0).iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[]
		{
			160, 115, 109, 113, 109, 108, 114, 98, 108, 135,
			98
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			while (!stack.isEmpty())
			{
				PostOrderNode postOrderNode = (PostOrderNode)stack.getLast();
				if (postOrderNode.childIterator.hasNext())
				{
					object obj = postOrderNode.childIterator.next();
					stack.addLast(expand(obj));
					continue;
				}
				stack.removeLast();
				return postOrderNode.root;
			}
			object result = endOfData();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal sealed class PostOrderNode : java.lang.Object
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TT;")]
		internal object root;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Iterator<TT;>;")]
		internal Iterator childIterator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;Ljava/util/Iterator<TT;>;)V")]
		[LineNumberTable(new byte[] { 160, 98, 104, 108, 113 })]
		internal PostOrderNode(object P_0, Iterator P_1)
		{
			root = Preconditions.checkNotNull(P_0);
			childIterator = (Iterator)Preconditions.checkNotNull(P_1);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	internal sealed class PreOrderIterator : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Deque<Ljava/util/Iterator<TT;>;>;")]
		private Deque stack;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeTraverser this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;)V")]
		[LineNumberTable(new byte[] { 96, 111, 107, 120 })]
		internal PreOrderIterator(TreeTraverser P_0, object P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			stack = new ArrayDeque();
			stack.addLast(Iterators.singletonIterator(Preconditions.checkNotNull(P_1)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(153)]
		public override bool hasNext()
		{
			return (!stack.isEmpty()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 108, 113, 108, 104, 140, 114, 104, 140 })]
		public override object next()
		{
			Iterator iterator = (Iterator)stack.getLast();
			object obj = Preconditions.checkNotNull(iterator.next());
			if (!iterator.hasNext())
			{
				stack.removeLast();
			}
			Iterator iterator2 = this_00240.children(obj).iterator();
			if (iterator2.hasNext())
			{
				stack.addLast(iterator2);
			}
			return obj;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(79)]
	public TreeTraverser()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Function<TT;+Ljava/lang/Iterable<TT;>;>;)Lcom/google/common/collect/TreeTraverser<TT;>;")]
	[LineNumberTable(new byte[] { 44, 103 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static TreeTraverser @using(com.google.common.@base.Function nodeToChildrenFunction)
	{
		Preconditions.checkNotNull(nodeToChildrenFunction);
		_1 result = new _1(nodeToChildrenFunction);
		_ = null;
		return result;
	}

	[Signature("(TT;)Ljava/lang/Iterable<TT;>;")]
	public abstract Iterable children(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TT;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[LineNumberTable(new byte[] { 68, 103 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public FluentIterable preOrderTraversal(object root)
	{
		Preconditions.checkNotNull(root);
		_2 result = new _2(this, root);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[LineNumberTable(140)]
	internal virtual UnmodifiableIterator preOrderIterator(object P_0)
	{
		PreOrderIterator result = new PreOrderIterator(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TT;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[LineNumberTable(new byte[] { 160, 69, 103 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public FluentIterable postOrderTraversal(object root)
	{
		Preconditions.checkNotNull(root);
		_3 result = new _3(this, root);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[LineNumberTable(205)]
	internal virtual UnmodifiableIterator postOrderIterator(object P_0)
	{
		PostOrderIterator result = new PostOrderIterator(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TT;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[LineNumberTable(new byte[] { 160, 145, 103 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public FluentIterable breadthFirstTraversal(object root)
	{
		Preconditions.checkNotNull(root);
		_4 result = new _4(this, root);
		_ = null;
		return result;
	}
}
