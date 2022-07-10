using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultimap<TK;TV;>;Lcom/google/common/collect/ListMultimap<TK;TV;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 139, 0, 0,
	17, 1, 0, 0, 0, 139, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)139,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.ListMultimap", "java.io.Serializable" })]
public class LinkedListMultimap : AbstractMultimap, ListMultimap, Multimap, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Ljava/util/AbstractSequentialList<TV;>;")]
	[EnclosingMethod(null, "get", "(Ljava.lang.Object;)Ljava.util.List;")]
	internal class _1 : AbstractSequentialList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024key;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedListMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(716)]
		internal _1(LinkedListMultimap P_0, object P_1)
		{
			this_00240 = P_0;
			val_0024key = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 93, 124 })]
		public override int size()
		{
			return ((KeyList)access_0024500(this_00240).get(val_0024key))?.count ?? 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TV;>;")]
		[LineNumberTable(725)]
		public override ListIterator listIterator(int P_0)
		{
			ValueForKeyIterator result = new ValueForKeyIterator(this_00240, val_0024key, P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/util/AbstractSequentialList<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "createEntries", "()Ljava.util.List;")]
	internal class _1EntriesImpl : AbstractSequentialList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedListMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(828)]
		internal _1EntriesImpl(LinkedListMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(831)]
		public override int size()
		{
			int result = access_0024800(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(836)]
		public override ListIterator listIterator(int P_0)
		{
			NodeIterator result = new NodeIterator(this_00240, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 162, 215, 103, 111, 39, 169 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			for (Node node = access_0024200(this_00240); node != null; node = node.next)
			{
				P_0.accept(node);
			}
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/Sets$ImprovedAbstractSet<TK;>;")]
	[EnclosingMethod(null, "createKeySet", "()Ljava.util.Set;")]
	internal class _1KeySetImpl : Sets.ImprovedAbstractSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedListMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(733)]
		internal _1KeySetImpl(LinkedListMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(736)]
		public override int size()
		{
			int result = access_0024500(this_00240).size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(741)]
		public override Iterator iterator()
		{
			DistinctKeyIterator result = new DistinctKeyIterator(this_00240, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(746)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(751)]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!this_00240.removeAll(P_0).isEmpty()) ? true : false;
		}
	}

	[SpecialName]
	[Signature("Ljava/util/AbstractSequentialList<TV;>;")]
	[EnclosingMethod(null, "createValues", "()Ljava.util.List;")]
	internal class _1ValuesImpl : AbstractSequentialList
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/TransformedListIterator<Ljava/util/Map$Entry<TK;TV;>;TV;>;")]
		[EnclosingMethod(null, "listIterator", "(I)Ljava.util.ListIterator;")]
		internal class _1 : TransformedListIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal NodeIterator val_0024nodeItr;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map$Entry<TK;TV;>;)TV;")]
			[LineNumberTable(791)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			internal virtual object transform(Map.Entry P_0)
			{
				object value = P_0.getValue();
				_ = null;
				return value;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(787)]
			internal _1(_1ValuesImpl P_0, ListIterator P_1, NodeIterator P_2)
			{
				val_0024nodeItr = P_2;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TV;)V")]
			[LineNumberTable(new byte[] { 162, 170, 110 })]
			public override void set([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				val_0024nodeItr.setValue(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(787)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			internal override object transform(object P_0)
			{
				object result = transform((Map.Entry)P_0);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedListMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(778)]
		internal _1ValuesImpl(LinkedListMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(781)]
		public override int size()
		{
			int result = access_0024800(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TV;>;")]
		[LineNumberTable(new byte[] { 162, 160, 109 })]
		public override ListIterator listIterator(int P_0)
		{
			NodeIterator nodeIterator = new NodeIterator(this_00240, P_0);
			_1 result = new _1(this, nodeIterator, nodeIterator);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<TK;>;")]
	internal class DistinctKeyIterator : java.lang.Object, Iterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Set<TK;>;")]
		internal Set seenKeys;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node next;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node current;

		internal int expectedModCount;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedListMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(436)]
		internal DistinctKeyIterator(LinkedListMultimap P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 66, 111, 123, 145 })]
		private DistinctKeyIterator(LinkedListMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			seenKeys = Sets.newHashSetWithExpectedSize(this_00240.keySet().size());
			this.next = access_0024200(this_00240);
			expectedModCount = access_0024000(this_00240);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 73, 115, 139 })]
		private void checkForConcurrentModification()
		{
			if (access_0024000(this_00240) != expectedModCount)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 80, 102 })]
		public virtual bool hasNext()
		{
			checkForConcurrentModification();
			return this.next != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(new byte[] { 161, 87, 102, 104, 139, 108, 151, 113, 127, 1 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			checkForConcurrentModification();
			if (this.next == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			current = this.next;
			seenKeys.add(current.key);
			do
			{
				this.next = this.next.next;
			}
			while (this.next != null && !seenKeys.add(this.next.key));
			return current.key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 101, 102, 118, 118, 103, 113 })]
		public virtual void remove()
		{
			checkForConcurrentModification();
			Preconditions.checkState(current != null, (object)"no calls to next() since the last call to remove()");
			access_0024400(this_00240, current.key);
			current = null;
			expectedModCount = access_0024000(this_00240);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 35, 0, 0,
		17, 1, 0, 0, 0, 35, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)35,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class KeyList : java.lang.Object
	{
		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		internal Node head;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		internal Node tail;

		internal int count;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 99, 104, 103, 103, 103, 103, 103 })]
		internal KeyList(Node P_0)
		{
			head = P_0;
			tail = P_0;
			P_0.previousSibling = null;
			P_0.nextSibling = null;
			count = 1;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMapEntry<TK;TV;>;")]
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
	internal sealed class Node : AbstractMapEntry
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object key;

		[Signature("TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object value;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node next;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node previous;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node nextSibling;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node previousSibling;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)V")]
		[LineNumberTable(new byte[] { 68, 104, 103, 103 })]
		internal Node([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			key = P_0;
			value = P_1;
		}

		[Signature("()TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getKey()
		{
			return key;
		}

		[Signature("()TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getValue()
		{
			return value;
		}

		[Signature("(TV;)TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object setValue([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = value;
			value = P_0;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Ljava/lang/Object;Ljava/util/ListIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[Implements(new string[] { "java.util.ListIterator" })]
	internal class NodeIterator : java.lang.Object, ListIterator, Iterator
	{
		internal int nextIndex;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node next;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node current;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node previous;

		internal int expectedModCount;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedListMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 218, 15, 177, 103, 104, 102, 108, 103, 105,
			169, 108, 105, 169, 103
		})]
		internal NodeIterator(LinkedListMultimap P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			expectedModCount = access_0024000(this_00240);
			int num = P_0.size();
			Preconditions.checkPositionIndex(P_1, num);
			if (P_1 >= num / 2)
			{
				this.previous = access_0024100(P_0);
				this.nextIndex = num;
				while (true)
				{
					int num2 = P_1;
					P_1++;
					if (num2 >= num)
					{
						break;
					}
					this.previous();
				}
			}
			else
			{
				this.next = access_0024200(P_0);
				while (true)
				{
					int num3 = P_1;
					P_1 += -1;
					if (num3 <= 0)
					{
						break;
					}
					this.next();
				}
			}
			current = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)V")]
		[LineNumberTable(new byte[] { 161, 60, 113, 108 })]
		internal virtual void setValue([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Preconditions.checkState(current != null);
			current.value = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 29, 102, 104, 139, 119, 113, 110 })]
		public virtual Node previous()
		{
			checkForConcurrentModification();
			if (this.previous == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			Node node = this.previous;
			current = node;
			this.next = node;
			this.previous = this.previous.previous;
			this.nextIndex--;
			return current;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 251, 102, 104, 139, 119, 113, 110 })]
		public virtual Node next()
		{
			checkForConcurrentModification();
			if (this.next == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			Node node = this.next;
			current = node;
			this.previous = node;
			this.next = this.next.next;
			this.nextIndex++;
			return current;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 237, 115, 139 })]
		private void checkForConcurrentModification()
		{
			if (access_0024000(this_00240) != expectedModCount)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV;>;)V")]
		[LineNumberTable(426)]
		public virtual void add(Map.Entry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV;>;)V")]
		[LineNumberTable(421)]
		public virtual void set(Map.Entry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 244, 102 })]
		public virtual bool hasNext()
		{
			checkForConcurrentModification();
			return this.next != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 7, 102, 118, 110, 113, 144, 145, 113, 103,
			113
		})]
		public virtual void remove()
		{
			checkForConcurrentModification();
			Preconditions.checkState(current != null, (object)"no calls to next() since the last call to remove()");
			if (current != this.next)
			{
				this.previous = current.previous;
				this.nextIndex--;
			}
			else
			{
				this.next = current.next;
			}
			access_0024300(this_00240, current);
			current = null;
			expectedModCount = access_0024000(this_00240);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 22, 102 })]
		public virtual bool hasPrevious()
		{
			checkForConcurrentModification();
			return this.previous != null;
		}

		public virtual int nextIndex()
		{
			return this.nextIndex;
		}

		public virtual int previousIndex()
		{
			return this.nextIndex - 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(325)]
		public virtual void add(object P_0)
		{
			add((Map.Entry)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(325)]
		public virtual void set(object P_0)
		{
			set((Map.Entry)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(325)]
		public virtual object previous()
		{
			Node result = this.previous();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(325)]
		public virtual object next()
		{
			Node result = this.next();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Ljava/lang/Object;Ljava/util/ListIterator<TV;>;")]
	[Implements(new string[] { "java.util.ListIterator" })]
	internal class ValueForKeyIterator : java.lang.Object, ListIterator, Iterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object key;

		internal int nextIndex;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node next;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node current;

		[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Node previous;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedListMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;I)V")]
		[LineNumberTable(new byte[]
		{
			161, 132, 111, 114, 109, 104, 102, 114, 103, 105,
			169, 114, 105, 169, 103, 103
		})]
		public ValueForKeyIterator([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] LinkedListMultimap P_0, object P_1, int P_2)
		{
			this_00240 = P_0;
			base._002Ector();
			KeyList keyList = (KeyList)access_0024500(P_0).get(P_1);
			int num = keyList?.count ?? 0;
			Preconditions.checkPositionIndex(P_2, num);
			if (P_2 >= num / 2)
			{
				this.previous = keyList?.tail;
				this.nextIndex = num;
				while (true)
				{
					int num2 = P_2;
					P_2++;
					if (num2 >= num)
					{
						break;
					}
					previous();
				}
			}
			else
			{
				this.next = keyList?.head;
				while (true)
				{
					int num3 = P_2;
					P_2 += -1;
					if (num3 <= 0)
					{
						break;
					}
					next();
				}
			}
			key = P_1;
			current = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)V")]
		[LineNumberTable(new byte[] { 161, 118, 111, 103, 114, 114 })]
		internal ValueForKeyIterator([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] LinkedListMultimap P_0, object P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			key = P_1;
			this.next = ((KeyList)access_0024500(P_0).get(P_1))?.head;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(new byte[] { 161, 179, 104, 139, 119, 113, 110 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object previous()
		{
			if (this.previous == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			Node node = this.previous;
			current = node;
			this.next = node;
			this.previous = this.previous.previousSibling;
			this.nextIndex--;
			return current.value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(new byte[] { 161, 161, 104, 139, 119, 113, 110 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			if (this.next == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			Node node = this.next;
			current = node;
			this.previous = node;
			this.next = this.next.nextSibling;
			this.nextIndex++;
			return current.value;
		}

		public virtual bool hasNext()
		{
			return this.next != null;
		}

		public virtual bool hasPrevious()
		{
			return this.previous != null;
		}

		public virtual int nextIndex()
		{
			return this.nextIndex;
		}

		public virtual int previousIndex()
		{
			return this.nextIndex - 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 200, 118, 110, 113, 144, 145, 113, 103 })]
		public virtual void remove()
		{
			Preconditions.checkState(current != null, (object)"no calls to next() since the last call to remove()");
			if (current != this.next)
			{
				this.previous = current.previousSibling;
				this.nextIndex--;
			}
			else
			{
				this.next = current.nextSibling;
			}
			access_0024300(this_00240, current);
			current = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)V")]
		[LineNumberTable(new byte[] { 161, 213, 113, 108 })]
		public virtual void set([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Preconditions.checkState(current != null);
			current.value = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)V")]
		[LineNumberTable(new byte[] { 161, 219, 126, 110, 103 })]
		public virtual void add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			this.previous = access_0024600(this_00240, key, P_0, this.next);
			this.nextIndex++;
			current = null;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[NonSerialized]
	[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Node head;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Node tail;

	[NonSerialized]
	[Signature("Ljava/util/Map<TK;Lcom/google/common/collect/LinkedListMultimap$KeyList<TK;TV;>;>;")]
	private Map keyToKeyList;

	[NonSerialized]
	private new int m_size;

	[NonSerialized]
	private int modCount;

	private const long serialVersionUID = 0L;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	internal static Map access_0024500(LinkedListMultimap P_0)
	{
		return P_0.keyToKeyList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;)Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 109, 104, 104, 114, 115, 115, 134, 118, 108,
		103, 114, 99, 117, 144, 110, 103, 103, 103, 135,
		229, 70, 124, 110, 108, 108, 103, 103, 104, 137,
		140, 104, 137, 140, 103, 135, 110
	})]
	private Node addNode([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Node P_2)
	{
		Node node = new Node(P_0, P_1);
		if (head == null)
		{
			Node node2 = node;
			tail = node2;
			head = node2;
			keyToKeyList.put(P_0, new KeyList(node));
			modCount++;
		}
		else if (P_2 == null)
		{
			((Node)java.util.Objects.requireNonNull(tail)).next = node;
			node.previous = tail;
			tail = node;
			KeyList keyList = (KeyList)keyToKeyList.get(P_0);
			if (keyList == null)
			{
				keyToKeyList.put(P_0, new KeyList(node));
				modCount++;
			}
			else
			{
				keyList.count++;
				Node node3 = keyList.tail;
				node3.nextSibling = node;
				node.previousSibling = node3;
				keyList.tail = node;
			}
		}
		else
		{
			KeyList keyList = (KeyList)java.util.Objects.requireNonNull((KeyList)keyToKeyList.get(P_0));
			keyList.count++;
			node.previous = P_2.previous;
			node.previousSibling = P_2.previousSibling;
			node.next = P_2;
			node.nextSibling = P_2;
			if (P_2.previousSibling == null)
			{
				keyList.head = node;
			}
			else
			{
				P_2.previousSibling.nextSibling = node;
			}
			if (P_2.previous == null)
			{
				head = node;
			}
			else
			{
				P_2.previous.next = node;
			}
			P_2.previous = node;
			P_2.previousSibling = node;
		}
		this.m_size++;
		return node;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)V")]
	[LineNumberTable(new byte[] { 160, 207, 110 })]
	private void removeAllNodes([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Iterators.clear(new ValueForKeyIterator(this, P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/LinkedListMultimap$Node<TK;TV;>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 164, 104, 147, 140, 104, 147, 140, 240, 70,
		127, 2, 103, 110, 133, 127, 2, 142, 136, 152,
		177, 136, 152, 177, 110
	})]
	private void removeNode(Node P_0)
	{
		if (P_0.previous != null)
		{
			P_0.previous.next = P_0.next;
		}
		else
		{
			head = P_0.next;
		}
		if (P_0.next != null)
		{
			P_0.next.previous = P_0.previous;
		}
		else
		{
			tail = P_0.previous;
		}
		if (P_0.previousSibling == null && P_0.nextSibling == null)
		{
			KeyList keyList = (KeyList)java.util.Objects.requireNonNull((KeyList)keyToKeyList.remove(P_0.key));
			keyList.count = 0;
			modCount++;
		}
		else
		{
			KeyList keyList = (KeyList)java.util.Objects.requireNonNull((KeyList)keyToKeyList.get(P_0.key));
			keyList.count--;
			if (P_0.previousSibling == null)
			{
				keyList.head = (Node)java.util.Objects.requireNonNull(P_0.nextSibling);
			}
			else
			{
				P_0.previousSibling.nextSibling = P_0.nextSibling;
			}
			if (P_0.nextSibling == null)
			{
				keyList.tail = (Node)java.util.Objects.requireNonNull(P_0.previousSibling);
			}
			else
			{
				P_0.nextSibling.previousSibling = P_0.previousSibling;
			}
		}
		this.m_size--;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 87, 106 })]
	internal LinkedListMultimap()
		: this(12)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 90, 104, 108 })]
	private LinkedListMultimap(int P_0)
	{
		keyToKeyList = Platform.newHashMapWithExpectedSize(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 160, 95, 115, 104 })]
	private LinkedListMultimap(Multimap P_0)
		: this(P_0.keySet().size())
	{
		putAll(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override bool putAll(Multimap m)
	{
		bool result = base.putAll(m);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<TV;>;")]
	[LineNumberTable(772)]
	public new virtual List values()
	{
		return (List)base.values();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/List<TV;>;")]
	[LineNumberTable(671)]
	private List getCopy([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		List result = Collections.unmodifiableList(Lists.newArrayList(new ValueForKeyIterator(this, P_0)));
		_ = null;
		return result;
	}

	public override int size()
	{
		return this.m_size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(822)]
	public new virtual List entries()
	{
		return (List)base.entries();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)Z")]
	[LineNumberTable(new byte[] { 162, 3, 106 })]
	public override bool put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		addNode(key, value, null);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<TV;>;")]
	[LineNumberTable(801)]
	internal new virtual List createValues()
	{
		_1ValuesImpl result = new _1ValuesImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(847)]
	internal new virtual List createEntries()
	{
		_1EntriesImpl result = new _1EntriesImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/List<TV;>;")]
	[LineNumberTable(new byte[]
	{
		162, 20, 104, 104, 167, 112, 103, 206, 104, 103,
		200, 104, 174
	})]
	public new virtual List replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key, Iterable values)
	{
		List copy = getCopy(key);
		ValueForKeyIterator valueForKeyIterator = new ValueForKeyIterator(this, key);
		Iterator iterator = values.iterator();
		while (((ListIterator)valueForKeyIterator).hasNext() && iterator.hasNext())
		{
			((ListIterator)valueForKeyIterator).next();
			((ListIterator)valueForKeyIterator).set(iterator.next());
		}
		while (((ListIterator)valueForKeyIterator).hasNext())
		{
			((ListIterator)valueForKeyIterator).next();
			((ListIterator)valueForKeyIterator).remove();
		}
		while (iterator.hasNext())
		{
			((ListIterator)valueForKeyIterator).add(iterator.next());
		}
		return copy;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/List<TV;>;")]
	[LineNumberTable(716)]
	public new virtual List get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		_1 result = new _1(this, key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/List<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 139, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 62, 98, 104, 103 })]
	public new virtual List removeAll(object key)
	{
		List copy = getCopy(key);
		removeAllNodes(key);
		return copy;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/LinkedListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 139, 0, 0,
		18, 1, 0, 0, 0, 139, 0, 0
	})]
	[LineNumberTable(173)]
	public static LinkedListMultimap create()
	{
		LinkedListMultimap result = new LinkedListMultimap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Lcom/google/common/collect/LinkedListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 139, 0, 0,
		18, 1, 0, 0, 0, 139, 0, 0
	})]
	[LineNumberTable(185)]
	public static LinkedListMultimap create(int expectedKeys)
	{
		LinkedListMultimap result = new LinkedListMultimap(expectedKeys);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/LinkedListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 139, 0, 0,
		18, 1, 0, 0, 0, 139, 0, 0
	})]
	[LineNumberTable(197)]
	public static LinkedListMultimap create(Multimap multimap)
	{
		LinkedListMultimap result = new LinkedListMultimap(multimap);
		_ = null;
		return result;
	}

	public override bool isEmpty()
	{
		return head == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(609)]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		bool result = keyToKeyList.containsKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(614)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		bool result = values().contains(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 70, 103, 103, 107, 103, 110 })]
	public override void clear()
	{
		head = null;
		tail = null;
		keyToKeyList.clear();
		this.m_size = 0;
		modCount++;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(754)]
	internal override Set createKeySet()
	{
		_1KeySetImpl result = new _1KeySetImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
	[LineNumberTable(759)]
	internal override Multiset createKeys()
	{
		Multimaps.Keys result = new Multimaps.Keys(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(852)]
	internal override Iterator entryIterator()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(857)]
	internal override Map createAsMap()
	{
		Multimaps.AsMap result = new Multimaps.AsMap(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 241, 102, 108, 127, 1, 108, 108, 98 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeInt(size());
		Iterator iterator = entries().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			P_0.writeObject(entry.getKey());
			P_0.writeObject(entry.getValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		162, 251, 102, 107, 103, 134, 135, 103, 233, 59,
		230, 71
	})]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		keyToKeyList = Maps.newLinkedHashMap();
		int num = P_0.readInt();
		for (int i = 0; i < num; i++)
		{
			object key = P_0.readObject();
			object value = P_0.readObject();
			put(key, value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override int hashCode()
	{
		int result = base.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.equals(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override Map asMap()
	{
		Map result = base.asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	internal override Collection createValues()
	{
		List result = createValues();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(98)]
	public virtual Collection _003Cbridge_003Evalues()
	{
		List result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override Multiset keys()
	{
		Multiset result = base.keys();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override Set keySet()
	{
		Set result = base.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	internal override Collection createEntries()
	{
		List result = createEntries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(98)]
	public virtual Collection _003Cbridge_003Eentries()
	{
		List result = entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(98)]
	public virtual Collection _003Cbridge_003EreplaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i)
	{
		List result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override bool putAll([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i)
	{
		bool result = base.putAll(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2)
	{
		bool result = base.remove(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	public override bool containsEntry([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2)
	{
		bool result = base.containsEntry(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(98)]
	public virtual Collection _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj)
	{
		List result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 139, 0, 0 })]
	[LineNumberTable(98)]
	public virtual Collection _003Cbridge_003EremoveAll(object obj)
	{
		List result = removeAll(obj);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	internal static int access_0024000(LinkedListMultimap P_0)
	{
		return P_0.modCount;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	internal static Node access_0024100(LinkedListMultimap P_0)
	{
		return P_0.tail;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	internal static Node access_0024200(LinkedListMultimap P_0)
	{
		return P_0.head;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	internal static void access_0024300(LinkedListMultimap P_0, Node P_1)
	{
		P_0.removeNode(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	internal static void access_0024400(LinkedListMultimap P_0, object P_1)
	{
		P_0.removeAllNodes(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	internal static Node access_0024600(LinkedListMultimap P_0, object P_1, object P_2, Node P_3)
	{
		Node result = P_0.addNode(P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(100)]
	internal static int access_0024800(LinkedListMultimap P_0)
	{
		return P_0.m_size;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		Multimap._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava]
	public static implicit operator Serializable(LinkedListMultimap P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	Collection Multimap.Multimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return _003Cbridge_003EreplaceValues(P_0, P_1);
	}

	Collection Multimap.Multimap_003A_003AremoveAll(object P_0)
	{
		return _003Cbridge_003EremoveAll(P_0);
	}

	Collection Multimap.Multimap_003A_003Aget(object P_0)
	{
		return _003Cbridge_003Eget(P_0);
	}

	Collection Multimap.Multimap_003A_003Avalues()
	{
		return _003Cbridge_003Evalues();
	}

	Collection Multimap.Multimap_003A_003Aentries()
	{
		return _003Cbridge_003Eentries();
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
		this.GetObjectData(P_0, P_1);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected LinkedListMultimap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
