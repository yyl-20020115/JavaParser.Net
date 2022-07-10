using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.math;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractQueue<TE;>;")]
[ConstantPool(new object[]
{
	(byte)90,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class MinMaxPriorityQueue : AbstractQueue
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

	[Signature("<B:Ljava/lang/Object;>Ljava/lang/Object;")]
	public sealed class Builder : Object
	{
		private const int UNSET_EXPECTED_SIZE = -1;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Comparator<TB;>;")]
		private Comparator comparator;

		private int m_expectedSize;

		private int m_maximumSize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(166)]
		internal Builder(Comparator P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:TB;>()Lcom/google/common/collect/MinMaxPriorityQueue<TT;>;")]
		[LineNumberTable(210)]
		public virtual MinMaxPriorityQueue create()
		{
			MinMaxPriorityQueue result = create(Collections.emptySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:TB;>(Ljava/lang/Iterable<+TT;>;)Lcom/google/common/collect/MinMaxPriorityQueue<TT;>;")]
		[LineNumberTable(new byte[] { 160, 104, 142, 108, 118, 104, 98 })]
		public virtual MinMaxPriorityQueue create(Iterable initialContents)
		{
			MinMaxPriorityQueue minMaxPriorityQueue = new MinMaxPriorityQueue(this, initialQueueSize(this.m_expectedSize, this.m_maximumSize, initialContents), null);
			Iterator iterator = initialContents.iterator();
			while (iterator.hasNext())
			{
				object element = iterator.next();
				minMaxPriorityQueue.offer(element);
			}
			return minMaxPriorityQueue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/MinMaxPriorityQueue$Builder<TB;>;")]
		[LineNumberTable(new byte[] { 160, 73, 108, 103 })]
		public virtual Builder expectedSize(int expectedSize)
		{
			Preconditions.checkArgument(expectedSize >= 0);
			this.m_expectedSize = expectedSize;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/MinMaxPriorityQueue$Builder<TB;>;")]
		[LineNumberTable(new byte[] { 160, 86, 105, 103 })]
		public virtual Builder maximumSize(int maximumSize)
		{
			Preconditions.checkArgument(maximumSize > 0);
			this.m_maximumSize = maximumSize;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(166)]
		internal static Ordering access_0024200(Builder P_0)
		{
			Ordering result = P_0.ordering();
			_ = null;
			return result;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(166)]
		internal static int access_0024300(Builder P_0)
		{
			return P_0.m_maximumSize;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:TB;>()Lcom/google/common/collect/Ordering<TT;>;")]
		[LineNumberTable(229)]
		private Ordering ordering()
		{
			Ordering result = Ordering.from(comparator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<TB;>;)V")]
		[LineNumberTable(new byte[] { 127, 232, 61, 103, 171, 113 })]
		private Builder(Comparator P_0)
		{
			this.m_expectedSize = -1;
			this.m_maximumSize = int.MaxValue;
			comparator = (Comparator)Preconditions.checkNotNull(P_0);
		}
	}

	[InnerClass(null, Modifiers.Private)]
	internal class Heap : Object
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Ordering<TE;>;")]
		internal Ordering ordering;

		[Signature("Lcom/google/common/collect/MinMaxPriorityQueue<TE;>.Heap;")]
		internal Heap otherHeap;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MinMaxPriorityQueue this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Ordering<TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 160, 111, 103 })]
		internal Heap(MinMaxPriorityQueue P_0, Ordering P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			ordering = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITE;)V")]
		[LineNumberTable(new byte[] { 161, 201, 169, 100, 132, 99, 135, 105 })]
		internal virtual void bubbleUp(int P_0, object P_1)
		{
			int num = crossOverUp(P_0, P_1);
			Heap heap;
			if (num == P_0)
			{
				heap = this;
			}
			else
			{
				P_0 = num;
				heap = otherHeap;
			}
			heap.bubbleUpAlternatingLevels(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(535)]
		internal virtual int compareElements(int P_0, int P_1)
		{
			int result = ordering.compare(this_00240.elementData(P_0), this_00240.elementData(P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)I")]
		[LineNumberTable(new byte[]
		{
			162, 54, 114, 102, 104, 104, 120, 109, 112, 110,
			120, 194
		})]
		internal virtual int swapWithConceptuallyLastElement(object P_0)
		{
			int parentIndex = getParentIndex(access_0024600(this_00240));
			if (parentIndex != 0)
			{
				int parentIndex2 = getParentIndex(parentIndex);
				int rightChildIndex = getRightChildIndex(parentIndex2);
				if (rightChildIndex != parentIndex && getLeftChildIndex(rightChildIndex) >= access_0024600(this_00240))
				{
					object obj = this_00240.elementData(rightChildIndex);
					if (ordering.compare(obj, P_0) < 0)
					{
						access_0024500(this_00240)[rightChildIndex] = P_0;
						access_0024500(this_00240)[access_0024600(this_00240)] = obj;
						return rightChildIndex;
					}
				}
			}
			int result = access_0024600(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 97, 108, 121, 133 })]
		internal virtual int fillHoleAt(int P_0)
		{
			int num;
			while ((num = findMinGrandChild(P_0)) > 0)
			{
				access_0024500(this_00240)[P_0] = this_00240.elementData(num);
				P_0 = num;
			}
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITE;)I")]
		[LineNumberTable(new byte[]
		{
			161, 219, 100, 104, 109, 112, 130, 110, 99, 98,
			110
		})]
		internal virtual int bubbleUpAlternatingLevels(int P_0, object P_1)
		{
			while (P_0 > 2)
			{
				int grandparentIndex = getGrandparentIndex(P_0);
				object obj = this_00240.elementData(grandparentIndex);
				if (ordering.compare(obj, P_1) <= 0)
				{
					break;
				}
				access_0024500(this_00240)[P_0] = obj;
				P_0 = grandparentIndex;
			}
			access_0024500(this_00240)[P_0] = P_1;
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(IITE;)Lcom/google/common/collect/MinMaxPriorityQueue$MoveDesc<TE;>;")]
		[LineNumberTable(new byte[]
		{
			161, 174, 105, 100, 226, 72, 164, 143, 179, 112,
			138
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal virtual MoveDesc tryCrossOverAndBubbleUp(int P_0, int P_1, object P_2)
		{
			int num = crossOver(P_1, P_2);
			if (num == P_1)
			{
				return null;
			}
			object obj = ((num >= P_0) ? this_00240.elementData(getParentIndex(P_0)) : this_00240.elementData(P_0));
			if (otherHeap.bubbleUpAlternatingLevels(num, P_2) < P_0)
			{
				MoveDesc result = new MoveDesc(P_2, obj);
				_ = null;
				return result;
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(526)]
		internal static bool access_0024400(Heap P_0, int P_1)
		{
			bool result = P_0.verifyIndex(P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 105, 127, 6, 130, 127, 6, 130, 117, 130,
			117, 130
		})]
		private bool verifyIndex(int P_0)
		{
			if (getLeftChildIndex(P_0) < access_0024600(this_00240) && compareElements(P_0, getLeftChildIndex(P_0)) > 0)
			{
				return false;
			}
			if (getRightChildIndex(P_0) < access_0024600(this_00240) && compareElements(P_0, getRightChildIndex(P_0)) > 0)
			{
				return false;
			}
			if (P_0 > 0 && compareElements(P_0, getParentIndex(P_0)) > 0)
			{
				return false;
			}
			if (P_0 > 2 && compareElements(getGrandparentIndex(P_0), P_0) > 0)
			{
				return false;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITE;)I")]
		[LineNumberTable(new byte[] { 162, 77, 168, 127, 0, 121, 110, 130 })]
		internal virtual int crossOver(int P_0, object P_1)
		{
			int num = findMinChild(P_0);
			if (num > 0 && ordering.compare(this_00240.elementData(num), P_1) < 0)
			{
				access_0024500(this_00240)[P_0] = this_00240.elementData(num);
				access_0024500(this_00240)[num] = P_1;
				return num;
			}
			int result = crossOverUp(P_0, P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(757)]
		private int getParentIndex(int P_0)
		{
			return (P_0 - 1) / 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITE;)I")]
		[LineNumberTable(new byte[]
		{
			162, 14, 99, 110, 130, 104, 109, 230, 69, 104,
			104, 120, 110, 113, 98, 195, 112, 110, 110, 130,
			110
		})]
		internal virtual int crossOverUp(int P_0, object P_1)
		{
			if (P_0 == 0)
			{
				access_0024500(this_00240)[0] = P_1;
				return 0;
			}
			int num = getParentIndex(P_0);
			object obj = this_00240.elementData(num);
			if (num != 0)
			{
				int parentIndex = getParentIndex(num);
				int rightChildIndex = getRightChildIndex(parentIndex);
				if (rightChildIndex != num && getLeftChildIndex(rightChildIndex) >= access_0024600(this_00240))
				{
					object obj2 = this_00240.elementData(rightChildIndex);
					if (ordering.compare(obj2, obj) < 0)
					{
						num = rightChildIndex;
						obj = obj2;
					}
				}
			}
			if (ordering.compare(obj, P_1) < 0)
			{
				access_0024500(this_00240)[P_0] = obj;
				access_0024500(this_00240)[num] = P_1;
				return num;
			}
			access_0024500(this_00240)[P_0] = P_1;
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(761)]
		private int getGrandparentIndex(int P_0)
		{
			int parentIndex = getParentIndex(getParentIndex(P_0));
			_ = null;
			return parentIndex;
		}

		private int getLeftChildIndex(int P_0)
		{
			return P_0 * 2 + 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 237, 110, 130, 105, 118, 98, 104, 107, 2,
			230, 69
		})]
		internal virtual int findMin(int P_0, int P_1)
		{
			if (P_0 >= access_0024600(this_00240))
			{
				return -1;
			}
			Preconditions.checkState(P_0 > 0);
			int num = Math.min(P_0, access_0024600(this_00240) - P_1) + P_1;
			int num2 = P_0;
			for (int i = P_0 + 1; i < num; i++)
			{
				if (compareElements(i, num2) < 0)
				{
					num2 = i;
				}
			}
			return num2;
		}

		private int getRightChildIndex(int P_0)
		{
			return P_0 * 2 + 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(623)]
		internal virtual int findMinChild(int P_0)
		{
			int result = findMin(getLeftChildIndex(P_0), 2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 2, 104, 100, 130 })]
		internal virtual int findMinGrandChild(int P_0)
		{
			int leftChildIndex = getLeftChildIndex(P_0);
			if (leftChildIndex < 0)
			{
				return -1;
			}
			int result = findMin(getLeftChildIndex(leftChildIndex), 4);
			_ = null;
			return result;
		}
	}

	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal class MoveDesc : Object
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TE;")]
		internal object toTrickle;

		[Modifiers(Modifiers.Final)]
		[Signature("TE;")]
		internal object replaced;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)V")]
		[LineNumberTable(new byte[] { 161, 108, 104, 103, 103 })]
		internal MoveDesc(object P_0, object P_1)
		{
			toTrickle = P_0;
			replaced = P_1;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<TE;>;")]
	internal class QueueIterator : Object, Iterator
	{
		private int cursor;

		private int nextCursor;

		private int expectedModCount;

		[Signature("Ljava/util/Queue<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Queue forgetMeNot;

		[Signature("Ljava/util/List<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private List skipMe;

		[Signature("TE;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private object lastFromForgetMeNot;

		private bool canRemove;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MinMaxPriorityQueue this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(770)]
		internal QueueIterator(MinMaxPriorityQueue P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 144, 111, 103, 103 })]
		private QueueIterator(MinMaxPriorityQueue P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			cursor = -1;
			nextCursor = -1;
			expectedModCount = access_0024700(this_00240);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 234, 115, 139 })]
		private void checkModCount()
		{
			if (access_0024700(this_00240) != expectedModCount)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 244, 105, 104, 127, 9, 167, 135 })]
		private void nextNotInSkipMe(int P_0)
		{
			if (nextCursor >= P_0)
			{
				return;
			}
			if (skipMe != null)
			{
				while (P_0 < this_00240.size() && foundAndRemovedExactReference(skipMe, this_00240.elementData(P_0)))
				{
					P_0++;
				}
			}
			nextCursor = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<TE;>;TE;)Z")]
		[LineNumberTable(new byte[] { 162, 212, 111, 103, 100, 102, 130, 98 })]
		private bool foundAndRemovedExactReference(Iterable P_0, object P_1)
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (obj == P_1)
				{
					iterator.remove();
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 224, 112, 112, 109, 226, 61, 230, 70 })]
		private bool removeExact(object P_0)
		{
			for (int i = 0; i < access_0024600(this_00240); i++)
			{
				if (access_0024500(this_00240)[i] == P_0)
				{
					this_00240.removeAt(i);
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 157, 102, 110 })]
		public virtual bool hasNext()
		{
			checkModCount();
			nextNotInSkipMe(cursor + 1);
			return (nextCursor < this_00240.size() || (forgetMeNot != null && !forgetMeNot.isEmpty())) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[]
		{
			162, 164, 102, 110, 115, 108, 103, 116, 104, 113,
			113, 104, 103, 167
		})]
		public virtual object next()
		{
			checkModCount();
			nextNotInSkipMe(cursor + 1);
			if (nextCursor < this_00240.size())
			{
				cursor = nextCursor;
				canRemove = true;
				object result = this_00240.elementData(cursor);
				_ = null;
				return result;
			}
			if (forgetMeNot != null)
			{
				cursor = this_00240.size();
				lastFromForgetMeNot = forgetMeNot.poll();
				if (lastFromForgetMeNot != null)
				{
					canRemove = true;
					return lastFromForgetMeNot;
				}
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException("iterator moved past last element in queue.");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 183, 107, 102, 103, 110, 118, 114, 134, 112,
			107, 140, 116, 146, 116, 178, 110, 110, 98, 118,
			135
		})]
		public virtual void remove()
		{
			CollectPreconditions.checkRemove(canRemove);
			checkModCount();
			canRemove = false;
			expectedModCount++;
			if (cursor < this_00240.size())
			{
				MoveDesc moveDesc = this_00240.removeAt(cursor);
				if (moveDesc != null)
				{
					if (forgetMeNot == null || skipMe == null)
					{
						forgetMeNot = new ArrayDeque();
						skipMe = new ArrayList(3);
					}
					if (!foundAndRemovedExactReference(skipMe, moveDesc.toTrickle))
					{
						forgetMeNot.add(moveDesc.toTrickle);
					}
					if (!foundAndRemovedExactReference(forgetMeNot, moveDesc.replaced))
					{
						skipMe.add(moveDesc.replaced);
					}
				}
				cursor--;
				nextCursor--;
			}
			else
			{
				Preconditions.checkState(removeExact(java.util.Objects.requireNonNull(lastFromForgetMeNot)));
				lastFromForgetMeNot = null;
			}
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/MinMaxPriorityQueue<TE;>.Heap;")]
	private Heap minHeap;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/MinMaxPriorityQueue<TE;>.Heap;")]
	private Heap maxHeap;

	[Modifiers(Modifiers.Final)]
	internal int maximumSize;

	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 90, 0, 0 })]
	private object[] queue;

	private new int m_size;

	private int modCount;

	private const int EVEN_POWERS_OF_TWO = 1431655765;

	private const int ODD_POWERS_OF_TWO = -1431655766;

	private const int DEFAULT_CAPACITY = 11;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/MinMaxPriorityQueue$Builder<-TE;>;I)V")]
	[LineNumberTable(new byte[] { 160, 126, 104, 103, 109, 114, 113, 145, 140, 108 })]
	private MinMaxPriorityQueue(Builder P_0, int P_1)
	{
		Ordering ordering = Builder.access_0024200(P_0);
		minHeap = new Heap(this, ordering);
		maxHeap = new Heap(this, ordering.reverse());
		minHeap.otherHeap = maxHeap;
		maxHeap.otherHeap = minHeap;
		this.maximumSize = Builder.access_0024300(P_0);
		queue = new object[P_1];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[] { 160, 176, 103, 110, 148, 198, 110 })]
	public override bool offer(object element)
	{
		Preconditions.checkNotNull(element);
		modCount++;
		int num = this.m_size;
		this.m_size = num + 1;
		int num2 = num;
		growIfNeeded();
		heapForIndex(num2).bubbleUp(num2, element);
		return (this.m_size <= this.maximumSize || pollLast() != element) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 76, 111, 103, 103, 117, 135 })]
	private void growIfNeeded()
	{
		if (this.m_size > (nint)queue.LongLength)
		{
			int num = calculateNewCapacity();
			object[] dest = new object[num];
			ByteCodeHelper.arraycopy(queue, 0, dest, 0, queue.Length);
			queue = dest;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/MinMaxPriorityQueue<TE;>.Heap;")]
	[LineNumberTable(492)]
	private Heap heapForIndex(int P_0)
	{
		return (!isEvenLevel(P_0)) ? maxHeap : minHeap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(374)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object pollLast()
	{
		object result = ((!base.isEmpty()) ? removeAndGet(getMaxElementIndex()) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(new byte[] { 161, 116, 104, 104 })]
	private object removeAndGet(int P_0)
	{
		object result = elementData(P_0);
		removeAt(P_0);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(315)]
	internal virtual object elementData(int P_0)
	{
		object result = java.util.Objects.requireNonNull(queue[P_0]);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(306)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object poll()
	{
		object result = ((!base.isEmpty()) ? removeAndGet(0) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(321)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object peek()
	{
		object result = ((!base.isEmpty()) ? elementData(0) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 212, 151, 130, 194 })]
	private int getMaxElementIndex()
	{
		return this.m_size switch
		{
			1 => 0, 
			2 => 1, 
			_ => (maxHeap.compareElements(1, 2) <= 0) ? 1 : 2, 
		};
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITE;)Lcom/google/common/collect/MinMaxPriorityQueue$MoveDesc<TE;>;")]
	[LineNumberTable(new byte[] { 161, 82, 232, 72, 136, 105, 196, 140 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private MoveDesc fillHole(int P_0, object P_1)
	{
		Heap heap = heapForIndex(P_0);
		int num = heap.fillHoleAt(P_0);
		int num2 = heap.bubbleUpAlternatingLevels(num, P_1);
		if (num2 == num)
		{
			MoveDesc result = heap.tryCrossOverAndBubbleUp(P_0, num, P_1);
			_ = null;
			return result;
		}
		return (num2 >= P_0) ? null : new MoveDesc(P_1, elementData(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/MinMaxPriorityQueue$MoveDesc<TE;>;")]
	[LineNumberTable(new byte[]
	{
		161, 46, 109, 110, 110, 105, 110, 130, 109, 115,
		196, 110, 130, 109, 110, 105, 132, 131, 202, 207
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual MoveDesc removeAt(int P_0)
	{
		Preconditions.checkPositionIndex(P_0, this.m_size);
		modCount++;
		this.m_size--;
		if (this.m_size == P_0)
		{
			queue[this.m_size] = null;
			return null;
		}
		object obj = elementData(this.m_size);
		int num = heapForIndex(this.m_size).swapWithConceptuallyLastElement(obj);
		if (num == P_0)
		{
			queue[this.m_size] = null;
			return null;
		}
		object obj2 = elementData(this.m_size);
		queue[this.m_size] = null;
		MoveDesc moveDesc = fillHole(P_0, obj2);
		if (num < P_0)
		{
			if (moveDesc == null)
			{
				MoveDesc result = new MoveDesc(obj, obj2);
				_ = null;
				return result;
			}
			MoveDesc result2 = new MoveDesc(obj, moveDesc.replaced);
			_ = null;
			return result2;
		}
		return moveDesc;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 130, 104, 110 })]
	internal static bool isEvenLevel(int P_0)
	{
		int num = (P_0 + 1) ^ -1 ^ -1;
		Preconditions.checkState(num > 0, (object)"negative index");
		return (num & 0x55555555) > (num & -1431655766);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(976)]
	private static int capAtMaximumSize(int P_0, int P_1)
	{
		return Math.min(P_0 - 1, P_1) + 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 86, 136, 118 })]
	private int calculateNewCapacity()
	{
		int num = queue.Length;
		int num2 = ((num >= 64) ? IntMath.checkedMultiply(num / 2, 3) : ((num + 1) * 2));
		int result = capAtMaximumSize(num2, this.maximumSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<TE;>;>()Lcom/google/common/collect/MinMaxPriorityQueue<TE;>;")]
	[LineNumberTable(111)]
	public static MinMaxPriorityQueue create()
	{
		MinMaxPriorityQueue result = new Builder(Ordering.natural(), null).create();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<TE;>;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/MinMaxPriorityQueue<TE;>;")]
	[LineNumberTable(120)]
	public static MinMaxPriorityQueue create(Iterable initialContents)
	{
		MinMaxPriorityQueue result = new Builder(Ordering.natural(), null).create(initialContents);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>(Ljava/util/Comparator<TB;>;)Lcom/google/common/collect/MinMaxPriorityQueue$Builder<TB;>;")]
	[LineNumberTable(134)]
	public static Builder orderedBy(Comparator comparator)
	{
		Builder result = new Builder(comparator, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/MinMaxPriorityQueue$Builder<Ljava/lang/Comparable;>;")]
	[LineNumberTable(142)]
	public static Builder expectedSize(int expectedSize)
	{
		Builder result = new Builder(Ordering.natural(), null).expectedSize(expectedSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/MinMaxPriorityQueue$Builder<Ljava/lang/Comparable;>;")]
	[LineNumberTable(152)]
	public static Builder maximumSize(int maximumSize)
	{
		Builder result = new Builder(Ordering.natural(), null).maximumSize(maximumSize);
		_ = null;
		return result;
	}

	public override int size()
	{
		return this.m_size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[] { 160, 153, 104 })]
	public override bool add(object element)
	{
		offer(element);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+TE;>;)Z")]
	[LineNumberTable(new byte[] { 160, 160, 98, 118, 104, 98, 98 })]
	public override bool addAll(Collection newElements)
	{
		int result = 0;
		Iterator iterator = newElements.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			offer(obj);
			result = 1;
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(345)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object pollFirst()
	{
		object result = poll();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(355)]
	public virtual object removeFirst()
	{
		object result = base.remove();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(364)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object peekFirst()
	{
		object result = peek();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(new byte[] { 161, 14, 104, 139 })]
	public virtual object removeLast()
	{
		if (base.isEmpty())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object result = removeAndGet(getMaxElementIndex());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(396)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object peekLast()
	{
		object result = ((!base.isEmpty()) ? elementData(getMaxElementIndex()) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 142, 107, 111, 2, 230, 69 })]
	internal virtual bool isIntact()
	{
		for (int i = 1; i < this.m_size; i++)
		{
			if (!Heap.access_0024400(heapForIndex(i), i))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(902)]
	public override Iterator iterator()
	{
		QueueIterator result = new QueueIterator(this, null);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 163, 25, 107, 41, 166, 103 })]
	public override void clear()
	{
		for (int i = 0; i < this.m_size; i++)
		{
			queue[i] = null;
		}
		this.m_size = 0;
	}

	[LineNumberTable(new byte[] { 163, 33, 108, 116 })]
	public override object[] toArray()
	{
		object[] array = new object[this.m_size];
		ByteCodeHelper.arraycopy(queue, 0, array, 0, this.m_size);
		return array;
	}

	[Signature("()Ljava/util/Comparator<-TE;>;")]
	[LineNumberTable(926)]
	public virtual Comparator comparator()
	{
		return minHeap.ordering;
	}

	[LineNumberTable(931)]
	internal virtual int capacity()
	{
		return queue.Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(IILjava/lang/Iterable<*>;)I")]
	[LineNumberTable(new byte[] { 163, 61, 100, 100, 162, 104, 108, 200 })]
	internal static int initialQueueSize(int P_0, int P_1, Iterable P_2)
	{
		int num = ((P_0 != -1) ? P_0 : 11);
		if (P_2 is Collection)
		{
			int b = ((Collection)P_2).size();
			num = Math.max(num, b);
		}
		int result = capAtMaximumSize(num, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(104)]
	internal MinMaxPriorityQueue(Builder P_0, int P_1, _1 P_2)
		: this(P_0, P_1)
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(104)]
	internal static object[] access_0024500(MinMaxPriorityQueue P_0)
	{
		return P_0.queue;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(104)]
	internal static int access_0024600(MinMaxPriorityQueue P_0)
	{
		return P_0.m_size;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(104)]
	internal static int access_0024700(MinMaxPriorityQueue P_0)
	{
		return P_0.modCount;
	}
}
