using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Iterable<TN;>;")]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;",
	"containerOf",
	new object[]
	{
		(byte)91,
		"N"
	}
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Iterable" })]
public abstract class EndpointPair : Object, Iterable, IEnumerable
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/EndpointPair<TN;>;")]
	internal sealed class Ordered : EndpointPair
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(147)]
		internal Ordered(object P_0, object P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)V")]
		[LineNumberTable(new byte[] { 99, 107 })]
		private Ordered(object P_0, object P_1)
			: base(P_0, P_1, null)
		{
		}

		public override bool isOrdered()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TN;")]
		[LineNumberTable(154)]
		public override object source()
		{
			object result = nodeU();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TN;")]
		[LineNumberTable(159)]
		public override object target()
		{
			object result = nodeV();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 119, 100, 130, 104, 162, 103, 110, 162 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 == this)
			{
				return true;
			}
			if (!(P_0 is EndpointPair))
			{
				return false;
			}
			EndpointPair endpointPair = (EndpointPair)P_0;
			if (isOrdered() != endpointPair.isOrdered())
			{
				return false;
			}
			return (Object.instancehelper_equals(source(), endpointPair.source()) && Object.instancehelper_equals(target(), endpointPair.target())) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(186)]
		public override int hashCode()
		{
			int result = com.google.common.@base.Objects.hashCode(source(), target());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(191)]
		public override string toString()
		{
			string text = String.valueOf(source());
			string text2 = String.valueOf(target());
			int num = 6 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("<").append(text).append(" -> ")
				.append(text2)
				.append(">")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(147)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = base.iterator();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/EndpointPair<TN;>;")]
	internal sealed class Unordered : EndpointPair
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(195)]
		internal Unordered(object P_0, object P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)V")]
		[LineNumberTable(new byte[] { 160, 83, 107 })]
		private Unordered(object P_0, object P_1)
			: base(P_0, P_1, null)
		{
		}

		public override bool isOrdered()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TN;")]
		[LineNumberTable(202)]
		public override object source()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("Cannot call source()/target() on a EndpointPair from an undirected graph. Consider calling adjacentNode(node) if you already have a node, or nodeU()/nodeV() if you don't.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TN;")]
		[LineNumberTable(207)]
		public override object target()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException("Cannot call source()/target() on a EndpointPair from an undirected graph. Consider calling adjacentNode(node) if you already have a node, or nodeU()/nodeV() if you don't.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 103, 100, 130, 104, 162, 103, 110, 226, 71,
			243, 70, 148
		})]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 == this)
			{
				return true;
			}
			if (!(P_0 is EndpointPair))
			{
				return false;
			}
			EndpointPair endpointPair = (EndpointPair)P_0;
			if (isOrdered() != endpointPair.isOrdered())
			{
				return false;
			}
			if (Object.instancehelper_equals(nodeU(), endpointPair.nodeU()))
			{
				bool result = Object.instancehelper_equals(nodeV(), endpointPair.nodeV());
				_ = null;
				return result;
			}
			return (Object.instancehelper_equals(nodeU(), endpointPair.nodeV()) && Object.instancehelper_equals(nodeV(), endpointPair.nodeU())) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(246)]
		public override int hashCode()
		{
			return Object.instancehelper_hashCode(nodeU()) + Object.instancehelper_hashCode(nodeV());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(251)]
		public override string toString()
		{
			string text = String.valueOf(nodeU());
			string text2 = String.valueOf(nodeV());
			int num = 4 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("[").append(text).append(", ")
				.append(text2)
				.append("]")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(195)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = base.iterator();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("TN;")]
	private object m_nodeU;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("TN;")]
	private object m_nodeV;

	[Signature("()TN;")]
	public object nodeU()
	{
		return this.m_nodeU;
	}

	[Signature("()TN;")]
	public object nodeV()
	{
		return this.m_nodeV;
	}

	public abstract bool isOrdered();

	[Signature("()TN;")]
	public abstract object source();

	[Signature("()TN;")]
	public abstract object target();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(TN;TN;)Lcom/google/common/graph/EndpointPair<TN;>;")]
	[LineNumberTable(60)]
	public static EndpointPair unordered(object nodeU, object nodeV)
	{
		Unordered result = new Unordered(nodeV, nodeU, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(TN;TN;)Lcom/google/common/graph/EndpointPair<TN;>;")]
	[LineNumberTable(54)]
	public static EndpointPair ordered(object source, object target)
	{
		Ordered result = new Ordered(source, target, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)TN;")]
	[LineNumberTable(new byte[] { 60, 110, 103, 110, 135 })]
	public object adjacentNode(object node)
	{
		if (Object.instancehelper_equals(node, this.m_nodeU))
		{
			return this.m_nodeV;
		}
		if (Object.instancehelper_equals(node, this.m_nodeV))
		{
			return this.m_nodeU;
		}
		string text = String.valueOf(this);
		string text2 = String.valueOf(node);
		int num = 36 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
		num = num;
		string s = new StringBuilder(num).append("EndpointPair ").append(text).append(" does not contain node ")
			.append(text2)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)V")]
	[LineNumberTable(new byte[] { 159, 189, 104, 108, 108 })]
	private EndpointPair(object P_0, object P_1)
	{
		this.m_nodeU = Preconditions.checkNotNull(P_0);
		this.m_nodeV = Preconditions.checkNotNull(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TN;>;")]
	[LineNumberTable(128)]
	public UnmodifiableIterator iterator()
	{
		UnmodifiableIterator result = Iterators.forArray(this.m_nodeU, this.m_nodeV);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<*>;TN;TN;)Lcom/google/common/graph/EndpointPair<TN;>;")]
	[LineNumberTable(65)]
	internal static EndpointPair of(Graph P_0, object P_1, object P_2)
	{
		EndpointPair result = ((!P_0.isDirected()) ? unordered(P_1, P_2) : ordered(P_1, P_2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Network<**>;TN;TN;)Lcom/google/common/graph/EndpointPair<TN;>;")]
	[LineNumberTable(70)]
	internal static EndpointPair of(Network P_0, object P_1, object P_2)
	{
		EndpointPair result = ((!P_0.isDirected()) ? unordered(P_1, P_2) : ordered(P_1, P_2));
		_ = null;
		return result;
	}

	public abstract override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	public abstract override int hashCode();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(40)]
	public virtual Iterator _003Cbridge_003Eiterator()
	{
		UnmodifiableIterator result = iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(43)]
	internal EndpointPair(object P_0, object P_1, _1 P_2)
		: this(P_0, P_1)
	{
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

	Iterator Iterable.Iterable_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}
}
