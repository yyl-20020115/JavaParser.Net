using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/AbstractSortedMultiset<TE;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 159, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)159,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class TreeMultiset : AbstractSortedMultiset, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/Multisets$AbstractEntry<TE;>;")]
	[EnclosingMethod(null, "wrapEntry", "(Lcom.google.common.collect.TreeMultiset$AvlNode;)Lcom.google.common.collect.Multiset$Entry;")]
	internal class _1 : Multisets.AbstractEntry
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AvlNode val_0024baseEntry;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(378)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getElement()
		{
			object element = val_0024baseEntry.getElement();
			_ = null;
			return element;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(374)]
		internal _1(TreeMultiset P_0, AvlNode P_1)
		{
			this_00240 = P_0;
			val_0024baseEntry = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 13, 108, 99, 148 })]
		public override int getCount()
		{
			int count = val_0024baseEntry.getCount();
			if (count == 0)
			{
				int result = this_00240.count(getElement());
				_ = null;
				return result;
			}
			return count;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
	internal class _2 : java.lang.Object, Iterator
	{
		[Signature("Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal AvlNode current;

		[Signature("Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Multiset.Entry prevEntry;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 79, 111 })]
		internal _2(TreeMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			current = access_00241300(this_00240);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 85, 104, 98, 125, 103, 130 })]
		public virtual bool hasNext()
		{
			if (current == null)
			{
				return false;
			}
			if (access_00241400(this_00240).tooHigh(current.getElement()))
			{
				current = null;
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[LineNumberTable(new byte[] { 161, 97, 104, 171, 124, 103, 120, 137, 145 })]
		public virtual Multiset.Entry next()
		{
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			Multiset.Entry result = (prevEntry = access_00241500(this_00240, (AvlNode)java.util.Objects.requireNonNull(current)));
			if (AvlNode.access_0024700(current) == access_00241600(this_00240))
			{
				current = null;
			}
			else
			{
				current = AvlNode.access_0024700(current);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 113, 118, 120, 103 })]
		public virtual void remove()
		{
			Preconditions.checkState(prevEntry != null, (object)"no calls to next() since the last call to remove()");
			this_00240.setCount(prevEntry.getElement(), 0);
			prevEntry = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(449)]
		public virtual object next()
		{
			Multiset.Entry result = this.next();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[EnclosingMethod(null, "descendingEntryIterator", "()Ljava.util.Iterator;")]
	internal class _3 : java.lang.Object, Iterator
	{
		[Signature("Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal AvlNode current;

		[Signature("Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Multiset.Entry prevEntry;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 122, 111, 113 })]
		internal _3(TreeMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			current = access_00241700(this_00240);
			prevEntry = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 128, 104, 98, 125, 103, 130 })]
		public virtual bool hasNext()
		{
			if (current == null)
			{
				return false;
			}
			if (access_00241400(this_00240).tooLow(current.getElement()))
			{
				current = null;
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[LineNumberTable(new byte[] { 161, 140, 104, 171, 108, 114, 103, 120, 137, 145 })]
		public virtual Multiset.Entry next()
		{
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			java.util.Objects.requireNonNull(current);
			Multiset.Entry result = (prevEntry = access_00241500(this_00240, current));
			if (AvlNode.access_00241200(current) == access_00241600(this_00240))
			{
				current = null;
			}
			else
			{
				current = AvlNode.access_00241200(current);
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 157, 118, 120, 103 })]
		public virtual void remove()
		{
			Preconditions.checkState(prevEntry != null, (object)"no calls to next() since the last call to remove()");
			this_00240.setCount(prevEntry.getElement(), 0);
			prevEntry = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(492)]
		public virtual object next()
		{
			Multiset.Entry result = this.next();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _4 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(187)]
		static _4()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType = new int[(nint)BoundType.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[BoundType.___003C_003EOPEN.ordinal()] = 1;
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
				_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[BoundType.___003C_003ECLOSED.ordinal()] = 2;
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

		_4()
		{
			throw null;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/TreeMultiset$Aggregate;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	internal abstract class Aggregate : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : Aggregate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(136)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)I")]
			[LineNumberTable(139)]
			internal override int nodeAggregate(AvlNode P_0)
			{
				int result = AvlNode.access_0024200(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)J")]
			[LineNumberTable(144)]
			internal override long treeAggregate([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] AvlNode P_0)
			{
				long result = ((P_0 != null) ? AvlNode.access_0024300(P_0) : 0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				Aggregate.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : Aggregate
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(147)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)I")]
			internal override int nodeAggregate(AvlNode P_0)
			{
				return 1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)J")]
			[LineNumberTable(155)]
			internal override long treeAggregate([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] AvlNode P_0)
			{
				return (P_0 != null) ? AvlNode.access_0024400(P_0) : 0;
			}

			[HideFromJava]
			static _2()
			{
				Aggregate.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Aggregate SIZE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Aggregate DISTINCT;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Aggregate[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)J")]
		internal abstract long treeAggregate([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] AvlNode P_0);

		[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)I")]
		internal abstract int nodeAggregate(AvlNode P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(135)]
		private Aggregate(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(135)]
		private static Aggregate[] _0024values()
		{
			return new Aggregate[2] { SIZE, DISTINCT };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(135)]
		public static Aggregate[] values()
		{
			return (Aggregate[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(135)]
		public static Aggregate valueOf(string P_0)
		{
			return (Aggregate)java.lang.Enum.valueOf(ClassLiteral<Aggregate>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(135)]
		internal Aggregate(string P_0, int P_1, TreeMultiset._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 86, 240, 75, 240, 52 })]
		static Aggregate()
		{
			SIZE = new _1("SIZE", 0);
			DISTINCT = new _2("DISTINCT", 1);
			_0024VALUES = _0024values();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 170, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)170,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class AvlNode : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TE;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private object elem;

		private int elemCount;

		private int distinctElements;

		private long m_totalCount;

		private int m_height;

		[Signature("Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode left;

		[Signature("Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode right;

		[Signature("Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode m_pred;

		[Signature("Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode m_succ;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(1042)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal virtual object getElement()
		{
			object result = NullnessCasts.uncheckedCastNullableTToT(elem);
			_ = null;
			return result;
		}

		internal virtual int getCount()
		{
			return elemCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 6, 104, 103, 103 })]
		internal AvlNode()
		{
			elem = null;
			elemCount = 1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_0024500(AvlNode P_0)
		{
			return P_0.left;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_0024600(AvlNode P_0)
		{
			return P_0.right;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static int access_0024400(AvlNode P_0)
		{
			return P_0.distinctElements;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;TE;)I")]
		[LineNumberTable(new byte[] { 162, 22, 110, 100, 123, 100, 155 })]
		internal virtual int count(Comparator P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			int num = P_0.compare(P_1, getElement());
			if (num < 0)
			{
				int result = ((left != null) ? left.count(P_0, P_1) : 0);
				_ = null;
				return result;
			}
			if (num > 0)
			{
				int result2 = ((right != null) ? right.count(P_0, P_1) : 0);
				_ = null;
				return result2;
			}
			return elemCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)V")]
		[LineNumberTable(new byte[]
		{
			161, 250, 104, 105, 103, 103, 104, 103, 103, 103,
			103
		})]
		internal AvlNode([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1)
		{
			Preconditions.checkArgument(P_1 > 0);
			elem = P_0;
			elemCount = P_1;
			this.m_totalCount = P_1;
			distinctElements = 1;
			this.m_height = 1;
			left = null;
			right = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;TE;I[I)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[]
		{
			162, 56, 110, 103, 103, 99, 101, 139, 135, 113,
			102, 142, 111, 122, 103, 103, 99, 101, 139, 135,
			113, 102, 142, 111, 218, 106, 107, 113, 110, 111
		})]
		internal virtual AvlNode add(Comparator P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, int P_2, int[] P_3)
		{
			int num = P_0.compare(P_1, getElement());
			if (num < 0)
			{
				AvlNode avlNode = left;
				if (avlNode == null)
				{
					P_3[0] = 0;
					AvlNode result = addLeftChild(P_1, P_2);
					_ = null;
					return result;
				}
				int num2 = avlNode.m_height;
				left = avlNode.add(P_0, P_1, P_2, P_3);
				if (P_3[0] == 0)
				{
					distinctElements++;
				}
				this.m_totalCount += P_2;
				AvlNode result2 = ((left.m_height != num2) ? rebalance() : this);
				_ = null;
				return result2;
			}
			if (num > 0)
			{
				AvlNode avlNode = right;
				if (avlNode == null)
				{
					P_3[0] = 0;
					AvlNode result3 = addRightChild(P_1, P_2);
					_ = null;
					return result3;
				}
				int num2 = avlNode.m_height;
				right = avlNode.add(P_0, P_1, P_2, P_3);
				if (P_3[0] == 0)
				{
					distinctElements++;
				}
				this.m_totalCount += P_2;
				AvlNode result4 = ((right.m_height != num2) ? rebalance() : this);
				_ = null;
				return result4;
			}
			P_3[0] = elemCount;
			long num3 = (long)elemCount + (long)P_2;
			Preconditions.checkArgument(num3 <= 2147483647u);
			elemCount += P_2;
			this.m_totalCount += P_2;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;TE;I[I)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[]
		{
			162, 99, 110, 103, 103, 99, 101, 162, 145, 103,
			103, 110, 148, 175, 114, 103, 103, 99, 101, 162,
			145, 103, 103, 110, 148, 175, 201, 106, 105, 137,
			110, 111
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal virtual AvlNode remove(Comparator P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, int P_2, int[] P_3)
		{
			int num = P_0.compare(P_1, getElement());
			if (num < 0)
			{
				AvlNode avlNode = left;
				if (avlNode == null)
				{
					P_3[0] = 0;
					return this;
				}
				left = avlNode.remove(P_0, P_1, P_2, P_3);
				if (P_3[0] > 0)
				{
					if (P_2 >= P_3[0])
					{
						distinctElements--;
						this.m_totalCount -= P_3[0];
					}
					else
					{
						this.m_totalCount -= P_2;
					}
				}
				AvlNode result = ((P_3[0] != 0) ? rebalance() : this);
				_ = null;
				return result;
			}
			if (num > 0)
			{
				AvlNode avlNode = right;
				if (avlNode == null)
				{
					P_3[0] = 0;
					return this;
				}
				right = avlNode.remove(P_0, P_1, P_2, P_3);
				if (P_3[0] > 0)
				{
					if (P_2 >= P_3[0])
					{
						distinctElements--;
						this.m_totalCount -= P_3[0];
					}
					else
					{
						this.m_totalCount -= P_2;
					}
				}
				AvlNode result2 = rebalance();
				_ = null;
				return result2;
			}
			P_3[0] = elemCount;
			if (P_2 >= elemCount)
			{
				AvlNode result3 = deleteMe();
				_ = null;
				return result3;
			}
			elemCount -= P_2;
			this.m_totalCount -= P_2;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;TE;I[I)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[]
		{
			162, 152, 110, 103, 103, 99, 101, 176, 145, 105,
			112, 106, 174, 116, 105, 103, 103, 99, 101, 176,
			145, 105, 112, 106, 174, 116, 201, 106, 99, 137,
			118, 103
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal virtual AvlNode setCount(Comparator P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, int P_2, int[] P_3)
		{
			int num = P_0.compare(P_1, getElement());
			if (num < 0)
			{
				AvlNode avlNode = left;
				if (avlNode == null)
				{
					P_3[0] = 0;
					return (P_2 <= 0) ? this : addLeftChild(P_1, P_2);
				}
				left = avlNode.setCount(P_0, P_1, P_2, P_3);
				if (P_2 == 0 && P_3[0] != 0)
				{
					distinctElements--;
				}
				else if (P_2 > 0 && P_3[0] == 0)
				{
					distinctElements++;
				}
				this.m_totalCount += P_2 - P_3[0];
				AvlNode result = rebalance();
				_ = null;
				return result;
			}
			if (num > 0)
			{
				AvlNode avlNode = right;
				if (avlNode == null)
				{
					P_3[0] = 0;
					return (P_2 <= 0) ? this : addRightChild(P_1, P_2);
				}
				right = avlNode.setCount(P_0, P_1, P_2, P_3);
				if (P_2 == 0 && P_3[0] != 0)
				{
					distinctElements--;
				}
				else if (P_2 > 0 && P_3[0] == 0)
				{
					distinctElements++;
				}
				this.m_totalCount += P_2 - P_3[0];
				AvlNode result2 = rebalance();
				_ = null;
				return result2;
			}
			P_3[0] = elemCount;
			if (P_2 == 0)
			{
				AvlNode result3 = deleteMe();
				_ = null;
				return result3;
			}
			this.m_totalCount += P_2 - elemCount;
			elemCount = P_2;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;TE;II[I)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[]
		{
			162, 206, 110, 103, 103, 99, 101, 104, 140, 162,
			147, 103, 106, 112, 107, 142, 149, 105, 103, 103,
			99, 101, 104, 140, 162, 147, 103, 106, 112, 107,
			142, 149, 201, 106, 105, 100, 137, 119, 136
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal virtual AvlNode setCount(Comparator P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, int P_2, int P_3, int[] P_4)
		{
			int num = P_0.compare(P_1, getElement());
			if (num < 0)
			{
				AvlNode avlNode = left;
				if (avlNode == null)
				{
					P_4[0] = 0;
					if (P_2 == 0 && P_3 > 0)
					{
						AvlNode result = addLeftChild(P_1, P_3);
						_ = null;
						return result;
					}
					return this;
				}
				left = avlNode.setCount(P_0, P_1, P_2, P_3, P_4);
				if (P_4[0] == P_2)
				{
					if (P_3 == 0 && P_4[0] != 0)
					{
						distinctElements--;
					}
					else if (P_3 > 0 && P_4[0] == 0)
					{
						distinctElements++;
					}
					this.m_totalCount += P_3 - P_4[0];
				}
				AvlNode result2 = rebalance();
				_ = null;
				return result2;
			}
			if (num > 0)
			{
				AvlNode avlNode = right;
				if (avlNode == null)
				{
					P_4[0] = 0;
					if (P_2 == 0 && P_3 > 0)
					{
						AvlNode result3 = addRightChild(P_1, P_3);
						_ = null;
						return result3;
					}
					return this;
				}
				right = avlNode.setCount(P_0, P_1, P_2, P_3, P_4);
				if (P_4[0] == P_2)
				{
					if (P_3 == 0 && P_4[0] != 0)
					{
						distinctElements--;
					}
					else if (P_3 > 0 && P_4[0] == 0)
					{
						distinctElements++;
					}
					this.m_totalCount += P_3 - P_4[0];
				}
				AvlNode result4 = rebalance();
				_ = null;
				return result4;
			}
			P_4[0] = elemCount;
			if (P_2 == elemCount)
			{
				if (P_3 == 0)
				{
					AvlNode result5 = deleteMe();
					_ = null;
					return result5;
				}
				this.m_totalCount += P_3 - elemCount;
				elemCount = P_3;
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_0024700(AvlNode P_0)
		{
			AvlNode result = P_0.succ();
			_ = null;
			return result;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static int access_0024202(AvlNode P_0, int P_1)
		{
			P_0.elemCount = P_1;
			return P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_0024502(AvlNode P_0, AvlNode P_1)
		{
			P_0.left = P_1;
			return P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_0024602(AvlNode P_0, AvlNode P_1)
		{
			P_0.right = P_1;
			return P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_0024802(AvlNode P_0, AvlNode P_1)
		{
			P_0.m_pred = P_1;
			return P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_0024902(AvlNode P_0, AvlNode P_1)
		{
			P_0.m_succ = P_1;
			return P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_00241000(AvlNode P_0, Comparator P_1, object P_2)
		{
			AvlNode result = P_0.ceiling(P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_00241100(AvlNode P_0, Comparator P_1, object P_2)
		{
			AvlNode result = P_0.floor(P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static AvlNode access_00241200(AvlNode P_0)
		{
			AvlNode result = P_0.pred();
			_ = null;
			return result;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static int access_0024200(AvlNode P_0)
		{
			return P_0.elemCount;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		internal static long access_0024300(AvlNode P_0)
		{
			return P_0.m_totalCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(640)]
		private AvlNode pred()
		{
			return (AvlNode)java.util.Objects.requireNonNull(this.m_pred);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;TE;)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[] { 163, 147, 110, 100, 127, 5, 99, 130 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode floor(Comparator P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			int num = P_0.compare(P_1, getElement());
			if (num > 0)
			{
				return (right != null) ? ((AvlNode)MoreObjects.firstNonNull(right.floor(P_0, P_1), this)) : this;
			}
			if (num == 0)
			{
				return this;
			}
			AvlNode result = ((left != null) ? left.floor(P_0, P_1) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;TE;)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[] { 163, 135, 110, 100, 127, 5, 99, 130 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode ceiling(Comparator P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			int num = P_0.compare(P_1, getElement());
			if (num < 0)
			{
				return (left != null) ? ((AvlNode)MoreObjects.firstNonNull(left.ceiling(P_0, P_1), this)) : this;
			}
			if (num == 0)
			{
				return this;
			}
			AvlNode result = ((right != null) ? right.ceiling(P_0, P_1) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(644)]
		private AvlNode succ()
		{
			return (AvlNode)java.util.Objects.requireNonNull(this.m_succ);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[] { 162, 42, 109, 114, 114, 110, 111 })]
		private AvlNode addLeftChild([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1)
		{
			left = new AvlNode(P_0, P_1);
			access_00241800(pred(), left, this);
			this.m_height = java.lang.Math.max(2, this.m_height);
			distinctElements++;
			this.m_totalCount += P_1;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[]
		{
			163, 76, 184, 108, 110, 145, 169, 108, 110, 145,
			137, 102
		})]
		private AvlNode rebalance()
		{
			switch (balanceFactor())
			{
			case -2:
			{
				java.util.Objects.requireNonNull(right);
				if (right.balanceFactor() > 0)
				{
					right = right.rotateRight();
				}
				AvlNode result2 = rotateLeft();
				_ = null;
				return result2;
			}
			case 2:
			{
				java.util.Objects.requireNonNull(left);
				if (left.balanceFactor() < 0)
				{
					left = left.rotateLeft();
				}
				AvlNode result = rotateRight();
				_ = null;
				return result;
			}
			default:
				recomputeHeight();
				return this;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[] { 162, 33, 109, 114, 114, 110, 111 })]
		private AvlNode addRightChild([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1)
		{
			right = new AvlNode(P_0, P_1);
			access_00241800(this, right, succ());
			this.m_height = java.lang.Math.max(2, this.m_height);
			distinctElements++;
			this.m_totalCount += P_1;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[]
		{
			163, 9, 103, 103, 113, 104, 103, 104, 103, 120,
			135, 114, 108, 110, 111, 137, 103, 114, 108, 110,
			111
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode deleteMe()
		{
			int num = elemCount;
			elemCount = 0;
			access_00241900(pred(), succ());
			if (left == null)
			{
				return right;
			}
			if (right == null)
			{
				return left;
			}
			AvlNode avlNode;
			if (left.m_height >= right.m_height)
			{
				avlNode = pred();
				avlNode.left = left.removeMax(avlNode);
				avlNode.right = right;
				avlNode.distinctElements = distinctElements - 1;
				avlNode.m_totalCount = this.m_totalCount - num;
				AvlNode result = avlNode.rebalance();
				_ = null;
				return result;
			}
			avlNode = succ();
			avlNode.right = right.removeMin(avlNode);
			avlNode.left = left;
			avlNode.distinctElements = distinctElements - 1;
			avlNode.m_totalCount = this.m_totalCount - num;
			AvlNode result2 = avlNode.rebalance();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[] { 163, 50, 104, 135, 114, 110, 116 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode removeMax(AvlNode P_0)
		{
			if (right == null)
			{
				return left;
			}
			right = right.removeMax(P_0);
			distinctElements--;
			this.m_totalCount -= P_0.elemCount;
			AvlNode result = rebalance();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;)Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[] { 163, 37, 104, 135, 114, 110, 116 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private AvlNode removeMin(AvlNode P_0)
		{
			if (left == null)
			{
				return right;
			}
			left = left.removeMin(P_0);
			distinctElements--;
			this.m_totalCount -= P_0.elemCount;
			AvlNode result = rebalance();
			_ = null;
			return result;
		}

		[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)J")]
		[LineNumberTable(1008)]
		private static long totalCount([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] AvlNode P_0)
		{
			return P_0?.m_totalCount ?? 0;
		}

		[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)I")]
		[LineNumberTable(1012)]
		private static int height([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] AvlNode P_0)
		{
			return P_0?.m_height ?? 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 61, 104, 119, 127, 6 })]
		private void recomputeMultiset()
		{
			distinctElements = 1 + distinctElements(left) + distinctElements(right);
			this.m_totalCount = elemCount + totalCount(left) + totalCount(right);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 67, 127, 4 })]
		private void recomputeHeight()
		{
			this.m_height = 1 + java.lang.Math.max(height(left), height(right));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(980)]
		private int balanceFactor()
		{
			return height(left) - height(right);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[] { 163, 114, 113, 103, 108, 103, 108, 108, 102, 102 })]
		private AvlNode rotateRight()
		{
			Preconditions.checkState(left != null);
			AvlNode avlNode = left;
			left = avlNode.right;
			avlNode.right = this;
			avlNode.m_totalCount = this.m_totalCount;
			avlNode.distinctElements = distinctElements;
			recompute();
			avlNode.recomputeHeight();
			return avlNode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
		[LineNumberTable(new byte[] { 163, 102, 113, 103, 108, 103, 108, 108, 102, 102 })]
		private AvlNode rotateLeft()
		{
			Preconditions.checkState(right != null);
			AvlNode avlNode = right;
			right = avlNode.left;
			avlNode.left = this;
			avlNode.m_totalCount = this.m_totalCount;
			avlNode.distinctElements = distinctElements;
			recompute();
			avlNode.recomputeHeight();
			return avlNode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 71, 102, 104 })]
		private void recompute()
		{
			recomputeMultiset();
			recomputeHeight();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1051)]
		public override string toString()
		{
			string result = Multisets.immutableEntry(getElement(), getCount()).toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal sealed class Reference : java.lang.Object
	{
		[Signature("TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(565)]
		internal Reference(_1 P_0)
			: this()
		{
		}

		[Signature("()TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object get()
		{
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TT;TT;)V")]
		[LineNumberTable(new byte[] { 161, 204, 105, 139, 103 })]
		public virtual void checkAndSet([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			if (value != P_0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
			value = P_1;
		}

		internal virtual void clear()
		{
			value = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(565)]
		private Reference()
		{
		}
	}

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/TreeMultiset$Reference<Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;>;")]
	private Reference rootReference;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/GeneralRange<TE;>;")]
	private GeneralRange range;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
	private AvlNode header;

	private const long serialVersionUID = 1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;)Lcom/google/common/collect/TreeMultiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 159, 0, 0 })]
	[LineNumberTable(new byte[] { 45, 99, 108, 8 })]
	public static TreeMultiset create([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator comparator)
	{
		TreeMultiset result = ((comparator != null) ? new TreeMultiset(comparator) : new TreeMultiset(Ordering.natural()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	public override Set entrySet()
	{
		Set result = base.entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 132, 98, 113, 113, 159, 14, 127, 22, 97 })]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		//Discarded unreachable code: IL_0029, IL_0060
		AvlNode avlNode;
		try
		{
			try
			{
				avlNode = (AvlNode)rootReference.get();
				if (!range.contains(element) || avlNode == null)
				{
					return 0;
				}
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_004a;
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_004d;
		}
		try
		{
			try
			{
				return avlNode.count(comparator(), element);
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
		}
		catch (System.Exception x4)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x4, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0082;
		}
		object obj = null;
		goto IL_0086;
		IL_004d:
		obj = null;
		goto IL_0086;
		IL_004a:
		obj = null;
		goto IL_0086;
		IL_0086:
		return 0;
		IL_0082:
		obj = null;
		goto IL_0086;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/collect/TreeMultiset$AvlNode<TT;>;Lcom/google/common/collect/TreeMultiset$AvlNode<TT;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 159, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 174, 104, 104 })]
	private static void successor(AvlNode P_0, AvlNode P_1)
	{
		AvlNode.access_0024902(P_0, P_1);
		AvlNode.access_0024802(P_1, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/collect/TreeMultiset$AvlNode<TT;>;Lcom/google/common/collect/TreeMultiset$AvlNode<TT;>;Lcom/google/common/collect/TreeMultiset$AvlNode<TT;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 159, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 180, 103, 105 })]
	private static void successor(AvlNode P_0, AvlNode P_1, AvlNode P_2)
	{
		successor(P_0, P_1);
		successor(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
	[LineNumberTable(new byte[]
	{
		161, 50, 113, 99, 162, 141, 113, 110, 99, 130,
		115, 115, 135, 98, 140
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private AvlNode lastNode()
	{
		AvlNode avlNode = (AvlNode)rootReference.get();
		if (avlNode == null)
		{
			return null;
		}
		AvlNode avlNode2;
		if (range.hasUpperBound())
		{
			object obj = NullnessCasts.uncheckedCastNullableTToT(range.getUpperEndpoint());
			avlNode2 = AvlNode.access_00241100(avlNode, comparator(), obj);
			if (avlNode2 == null)
			{
				return null;
			}
			if (range.getUpperBoundType() == BoundType.___003C_003EOPEN && comparator().compare(obj, avlNode2.getElement()) == 0)
			{
				avlNode2 = AvlNode.access_00241200(avlNode2);
			}
		}
		else
		{
			avlNode2 = AvlNode.access_00241200(header);
		}
		return (avlNode2 != header && range.contains(avlNode2.getElement())) ? avlNode2 : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(374)]
	private Multiset.Entry wrapEntry(AvlNode P_0)
	{
		_1 result = new _1(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;")]
	[LineNumberTable(new byte[]
	{
		161, 26, 113, 99, 162, 141, 113, 110, 99, 130,
		115, 115, 135, 98, 140
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private AvlNode firstNode()
	{
		AvlNode avlNode = (AvlNode)rootReference.get();
		if (avlNode == null)
		{
			return null;
		}
		AvlNode avlNode2;
		if (range.hasLowerBound())
		{
			object obj = NullnessCasts.uncheckedCastNullableTToT(range.getLowerEndpoint());
			avlNode2 = AvlNode.access_00241000(avlNode, comparator(), obj);
			if (avlNode2 == null)
			{
				return null;
			}
			if (range.getLowerBoundType() == BoundType.___003C_003EOPEN && comparator().compare(obj, avlNode2.getElement()) == 0)
			{
				avlNode2 = AvlNode.access_0024700(avlNode2);
			}
		}
		else
		{
			avlNode2 = AvlNode.access_0024700(header);
		}
		return (avlNode2 != header && range.contains(avlNode2.getElement())) ? avlNode2 : null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TE;>;)V")]
	[LineNumberTable(new byte[] { 77, 105, 108, 107, 113, 108 })]
	internal TreeMultiset(Comparator P_0)
		: base(P_0)
	{
		range = GeneralRange.all(P_0);
		header = new AvlNode();
		successor(header, header);
		rootReference = new Reference(null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>()Lcom/google/common/collect/TreeMultiset<TE;>;")]
	[LineNumberTable(78)]
	public static TreeMultiset create()
	{
		TreeMultiset result = new TreeMultiset(Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/TreeMultiset$Aggregate;Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;)J")]
	[LineNumberTable(new byte[]
	{
		127, 99, 163, 97, 107, 118, 100, 112, 99, 159,
		8, 150, 143, 171, 110, 106, 11
	})]
	private long aggregateBelowRange(Aggregate P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] AvlNode P_1)
	{
		if (P_1 == null)
		{
			return 0L;
		}
		int num = comparator().compare(NullnessCasts.uncheckedCastNullableTToT(range.getLowerEndpoint()), P_1.getElement());
		if (num < 0)
		{
			long result = aggregateBelowRange(P_0, AvlNode.access_0024500(P_1));
			_ = null;
			return result;
		}
		if (num == 0)
		{
			switch (_4._0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[range.getLowerBoundType().ordinal()])
			{
			case 1:
				return P_0.nodeAggregate(P_1) + P_0.treeAggregate(AvlNode.access_0024500(P_1));
			case 2:
			{
				long result2 = P_0.treeAggregate(AvlNode.access_0024500(P_1));
				_ = null;
				return result2;
			}
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}
		return P_0.treeAggregate(AvlNode.access_0024500(P_1)) + P_0.nodeAggregate(P_1) + aggregateBelowRange(P_0, AvlNode.access_0024600(P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/TreeMultiset$Aggregate;Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;)J")]
	[LineNumberTable(new byte[]
	{
		160, 89, 99, 163, 97, 107, 118, 100, 112, 99,
		159, 8, 150, 143, 171, 110, 106, 11
	})]
	private long aggregateAboveRange(Aggregate P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] AvlNode P_1)
	{
		if (P_1 == null)
		{
			return 0L;
		}
		int num = comparator().compare(NullnessCasts.uncheckedCastNullableTToT(range.getUpperEndpoint()), P_1.getElement());
		if (num > 0)
		{
			long result = aggregateAboveRange(P_0, AvlNode.access_0024600(P_1));
			_ = null;
			return result;
		}
		if (num == 0)
		{
			switch (_4._0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[range.getUpperBoundType().ordinal()])
			{
			case 1:
				return P_0.nodeAggregate(P_1) + P_0.treeAggregate(AvlNode.access_0024600(P_1));
			case 2:
			{
				long result2 = P_0.treeAggregate(AvlNode.access_0024600(P_1));
				_ = null;
				return result2;
			}
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}
		return P_0.treeAggregate(AvlNode.access_0024600(P_1)) + P_0.nodeAggregate(P_1) + aggregateAboveRange(P_0, AvlNode.access_0024500(P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	public override Comparator comparator()
	{
		Comparator result = base.comparator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 115, 113, 104, 109, 139, 109, 139 })]
	private long aggregateForEntries(Aggregate P_0)
	{
		AvlNode avlNode = (AvlNode)rootReference.get();
		long num = P_0.treeAggregate(avlNode);
		if (range.hasLowerBound())
		{
			num -= aggregateBelowRange(P_0, avlNode);
		}
		if (range.hasUpperBound())
		{
			num -= aggregateAboveRange(P_0, avlNode);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(new byte[]
	{
		160, 146, 108, 99, 138, 113, 113, 99, 110, 104,
		114, 109, 130, 103, 112, 109
	})]
	public override int add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, int occurrences)
	{
		CollectPreconditions.checkNonnegative(occurrences, "occurrences");
		if (occurrences == 0)
		{
			int result = count(element);
			_ = null;
			return result;
		}
		Preconditions.checkArgument(range.contains(element));
		AvlNode avlNode = (AvlNode)rootReference.get();
		if (avlNode == null)
		{
			comparator().compare(element, element);
			AvlNode avlNode2 = new AvlNode(element, occurrences);
			successor(header, avlNode2, header);
			rootReference.checkAndSet(avlNode, avlNode2);
			return 0;
		}
		int[] array = new int[1];
		AvlNode avlNode3 = avlNode.add(comparator(), element, occurrences, array);
		rootReference.checkAndSet(avlNode, avlNode3);
		return array[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(449)]
	internal override Iterator entryIterator()
	{
		_2 result = new _2(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/TreeMultiset$Reference<Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;>;Lcom/google/common/collect/GeneralRange<TE;>;Lcom/google/common/collect/TreeMultiset$AvlNode<TE;>;)V")]
	[LineNumberTable(new byte[] { 70, 110, 103, 103, 103 })]
	internal TreeMultiset(Reference P_0, GeneralRange P_1, AvlNode P_2)
		: base(P_1.comparator())
	{
		rootReference = P_0;
		range = P_1;
		header = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	public override NavigableSet elementSet()
	{
		NavigableSet result = base.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/TreeMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 60, 102, 104 })]
	public static TreeMultiset create(Iterable elements)
	{
		TreeMultiset treeMultiset = create();
		Iterables.addAll(treeMultiset, elements);
		return treeMultiset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(230)]
	public override int size()
	{
		int result = Ints.saturatedCast(aggregateForEntries(Aggregate.SIZE));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(235)]
	internal override int distinctElements()
	{
		int result = Ints.saturatedCast(aggregateForEntries(Aggregate.DISTINCT));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/TreeMultiset$AvlNode<*>;)I")]
	[LineNumberTable(239)]
	internal static int distinctElements([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] AvlNode P_0)
	{
		int result = ((P_0 != null) ? AvlNode.access_0024400(P_0) : 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 168, 108, 99, 136, 113, 199, 98, 113, 159,
		14, 191, 22, 2, 97, 130, 110
	})]
	public override int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element, int occurrences)
	{
		//Discarded unreachable code: IL_0047
		CollectPreconditions.checkNonnegative(occurrences, "occurrences");
		if (occurrences == 0)
		{
			return count(element);
		}
		AvlNode avlNode = (AvlNode)rootReference.get();
		int[] array = new int[1];
		try
		{
			try
			{
				if (!range.contains(element) || avlNode == null)
				{
					return 0;
				}
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0068;
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_006b;
		}
		AvlNode avlNode2;
		try
		{
			try
			{
				avlNode2 = avlNode.remove(comparator(), element, occurrences, array);
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_009e;
			}
		}
		catch (System.Exception x4)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x4, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_00a1;
		}
		rootReference.checkAndSet(avlNode, avlNode2);
		return array[0];
		IL_009e:
		object obj = null;
		goto IL_00a6;
		IL_00a1:
		obj = null;
		goto IL_00a6;
		IL_006b:
		obj = null;
		goto IL_00a6;
		IL_0068:
		obj = null;
		goto IL_00a6;
		IL_00a6:
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(new byte[]
	{
		160, 192, 108, 110, 108, 162, 113, 99, 100, 137,
		130, 103, 112, 109
	})]
	public override int setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, int count)
	{
		CollectPreconditions.checkNonnegative(count, "count");
		if (!range.contains(element))
		{
			Preconditions.checkArgument((count == 0) ? true : false);
			return 0;
		}
		AvlNode avlNode = (AvlNode)rootReference.get();
		if (avlNode == null)
		{
			if (count > 0)
			{
				add(element, count);
			}
			return 0;
		}
		int[] array = new int[1];
		AvlNode avlNode2 = avlNode.setCount(comparator(), element, count, array);
		rootReference.checkAndSet(avlNode, avlNode2);
		return array[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;II)Z")]
	[LineNumberTable(new byte[]
	{
		160, 214, 108, 108, 145, 113, 99, 99, 100, 137,
		130, 162, 103, 113, 109
	})]
	public override bool setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, int oldCount, int newCount)
	{
		CollectPreconditions.checkNonnegative(newCount, "newCount");
		CollectPreconditions.checkNonnegative(oldCount, "oldCount");
		Preconditions.checkArgument(range.contains(element));
		AvlNode avlNode = (AvlNode)rootReference.get();
		if (avlNode == null)
		{
			if (oldCount == 0)
			{
				if (newCount > 0)
				{
					add(element, newCount);
				}
				return true;
			}
			return false;
		}
		int[] array = new int[1];
		AvlNode avlNode2 = avlNode.setCount(comparator(), element, oldCount, newCount, array);
		rootReference.checkAndSet(avlNode, avlNode2);
		return array[0] == oldCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 237, 159, 1, 117, 135, 136, 104, 104, 104,
		136, 98, 98, 113, 173, 141
	})]
	public override void clear()
	{
		if (!range.hasLowerBound() && !range.hasUpperBound())
		{
			AvlNode avlNode = AvlNode.access_0024700(header);
			while (avlNode != header)
			{
				AvlNode avlNode2 = AvlNode.access_0024700(avlNode);
				AvlNode.access_0024202(avlNode, 0);
				AvlNode.access_0024502(avlNode, null);
				AvlNode.access_0024602(avlNode, null);
				AvlNode.access_0024802(avlNode, null);
				AvlNode.access_0024902(avlNode, null);
				avlNode = avlNode2;
			}
			successor(header, header);
			rootReference.clear();
		}
		else
		{
			Iterators.clear(entryIterator());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(444)]
	internal override Iterator elementIterator()
	{
		Iterator result = Multisets.elementIterator(entryIterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(492)]
	internal override Iterator descendingEntryIterator()
	{
		_3 result = new _3(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/ObjIntConsumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 161, 166, 103, 103, 159, 0, 50, 169 })]
	public override void forEachEntry(ObjIntConsumer action)
	{
		Preconditions.checkNotNull(action);
		AvlNode avlNode = firstNode();
		while (avlNode != header && avlNode != null && !range.tooHigh(avlNode.getElement()))
		{
			action.accept(avlNode.getElement(), avlNode.getCount());
			avlNode = AvlNode.access_0024700(avlNode);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(546)]
	public override Iterator iterator()
	{
		Iterator result = Multisets.iteratorImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 161, 181, 141, 30 })]
	public override SortedMultiset headMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object upperBound, BoundType boundType)
	{
		TreeMultiset result = new TreeMultiset(rootReference, range.intersect(GeneralRange.upTo(comparator(), upperBound, boundType)), header);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 161, 189, 141, 30 })]
	public override SortedMultiset tailMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object lowerBound, BoundType boundType)
	{
		TreeMultiset result = new TreeMultiset(rootReference, range.intersect(GeneralRange.downTo(comparator(), lowerBound, boundType)), header);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 163, 196, 102, 113, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeObject(this.elementSet().comparator());
		Serialization.writeMultiset(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		163, 203, 166, 108, 118, 113, 106, 118, 101, 102,
		118, 103, 105
	})]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		Comparator comparator = (Comparator)P_0.readObject();
		Serialization.getFieldSetter(ClassLiteral<AbstractSortedMultiset>.Value, "comparator").set(this, comparator);
		Serialization.getFieldSetter(ClassLiteral<TreeMultiset>.Value, "range").set(this, GeneralRange.all(comparator));
		Serialization.getFieldSetter(ClassLiteral<TreeMultiset>.Value, "rootReference").set(this, new Reference(null));
		AvlNode avlNode = new AvlNode();
		Serialization.getFieldSetter(ClassLiteral<TreeMultiset>.Value, "header").set(this, avlNode);
		successor(avlNode, avlNode);
		Serialization.populateMultiset(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	public override SortedMultiset descendingMultiset()
	{
		SortedMultiset result = base.descendingMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	public override SortedMultiset subMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, BoundType bt1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2, BoundType bt2)
	{
		SortedMultiset result = base.subMultiset(obj1, bt1, obj2, bt2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Multiset.Entry pollLastEntry()
	{
		Multiset.Entry result = base.pollLastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Multiset.Entry pollFirstEntry()
	{
		Multiset.Entry result = base.pollFirstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Multiset.Entry lastEntry()
	{
		Multiset.Entry result = base.lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Multiset.Entry firstEntry()
	{
		Multiset.Entry result = base.firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.contains(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(62)]
	internal static AvlNode access_00241300(TreeMultiset P_0)
	{
		AvlNode result = P_0.firstNode();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(62)]
	internal static GeneralRange access_00241400(TreeMultiset P_0)
	{
		return P_0.range;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(62)]
	internal static Multiset.Entry access_00241500(TreeMultiset P_0, AvlNode P_1)
	{
		Multiset.Entry result = P_0.wrapEntry(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(62)]
	internal static AvlNode access_00241600(TreeMultiset P_0)
	{
		return P_0.header;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(62)]
	internal static AvlNode access_00241700(TreeMultiset P_0)
	{
		AvlNode result = P_0.lastNode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(62)]
	internal static void access_00241800(AvlNode P_0, AvlNode P_1, AvlNode P_2)
	{
		successor(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(62)]
	internal static void access_00241900(AvlNode P_0, AvlNode P_1)
	{
		successor(P_0, P_1);
	}

	[HideFromJava]
	public static implicit operator Serializable(TreeMultiset P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected TreeMultiset(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|elementSet", "()Ljava.util.Set;")]
	public Set _003Cbridge_003EelementSet()
	{
		return ((AbstractSortedMultiset)this).elementSet();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|elementSet", "()Ljava.util.SortedSet;")]
	public SortedSet _003Cbridge_003EelementSet()
	{
		return ((AbstractSortedMultiset)this).elementSet();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|add", "(Ljava.lang.Object;)Z")]
	public new bool add(object P_0)
	{
		return ((AbstractMultiset)this).add(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|remove", "(Ljava.lang.Object;)Z")]
	public new bool remove(object P_0)
	{
		return ((AbstractMultiset)this).remove(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|addAll", "(Ljava.util.Collection;)Z")]
	public new bool addAll(Collection P_0)
	{
		return ((AbstractMultiset)this).addAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|removeAll", "(Ljava.util.Collection;)Z")]
	public new bool removeAll(Collection P_0)
	{
		return ((AbstractMultiset)this).removeAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>6|retainAll", "(Ljava.util.Collection;)Z")]
	public new bool retainAll(Collection P_0)
	{
		return ((AbstractMultiset)this).retainAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>7|equals", "(Ljava.lang.Object;)Z")]
	public new bool equals(object P_0)
	{
		return ((AbstractMultiset)this).equals(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>8|hashCode", "()I")]
	public new int hashCode()
	{
		return ((AbstractMultiset)this).hashCode();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>9|toString", "()Ljava.lang.String;")]
	public new string toString()
	{
		return ((AbstractMultiset)this).toString();
	}
}
