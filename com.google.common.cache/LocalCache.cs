using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.primitives;
using com.google.common.util.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.@ref;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using java.util.concurrent.locks;
using java.util.function;
using java.util.logging;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(ushort)341,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[Implements(new string[] { "java.util.concurrent.ConcurrentMap" })]
internal class LocalCache : AbstractMap, ConcurrentMap, Map
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/cache/LocalCache$ValueReference<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[EnclosingMethod(null, null, null)]
	[ConstantPool(new object[]
	{
		(byte)35,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _1 : java.lang.Object, ValueReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(684)]
		internal _1()
		{
		}

		public virtual object get()
		{
			return null;
		}

		public virtual int getWeight()
		{
			return 0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public virtual ReferenceEntry getEntry()
		{
			return null;
		}

		[Signature("(Ljava/lang/ref/ReferenceQueue<Ljava/lang/Object;>;Ljava/lang/Object;Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;)Lcom/google/common/cache/LocalCache$ValueReference<Ljava/lang/Object;Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 1, 0, 0, 35, 0, 0 })]
		public virtual ValueReference copyFor(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
		{
			return this;
		}

		public virtual bool isLoading()
		{
			return false;
		}

		public virtual bool isActive()
		{
			return false;
		}

		public virtual object waitForValue()
		{
			return null;
		}

		public virtual void notifyNewValue(object P_0)
		{
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/AbstractQueue<Ljava/lang/Object;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _2 : AbstractQueue
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(901)]
		internal _2()
		{
		}

		public override bool offer(object P_0)
		{
			return true;
		}

		public override object peek()
		{
			return null;
		}

		public override object poll()
		{
			return null;
		}

		public override int size()
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/lang/Object;>;")]
		[LineNumberTable(924)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = ImmutableSet.of().iterator();
			_ = null;
			return result;
		}
	}

	[Signature("<T:Ljava/lang/Object;>Ljava/util/AbstractSet<TT;>;")]
	internal abstract class AbstractCacheSet : AbstractSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LocalCache this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4511)]
		internal AbstractCacheSet(LocalCache P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4514)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4519)]
		public override bool isEmpty()
		{
			bool result = this_00240.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 177, 58, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4532)]
		public override object[] toArray()
		{
			object[] result = access_0024200(this).toArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<E:Ljava/lang/Object;>([TE;)[TE;")]
		[LineNumberTable(4537)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = access_0024200(this).toArray(P_0);
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	internal abstract class AbstractReferenceEntry : java.lang.Object, ReferenceEntry
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(808)]
		internal AbstractReferenceEntry()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		[LineNumberTable(811)]
		public virtual ValueReference getValueReference()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)V")]
		[LineNumberTable(816)]
		public virtual void setValueReference(ValueReference P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(821)]
		public virtual ReferenceEntry getNext()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(826)]
		public virtual int getHash()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(831)]
		public virtual object getKey()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(836)]
		public virtual long getAccessTime()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(841)]
		public virtual void setAccessTime(long P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(846)]
		public virtual ReferenceEntry getNextInAccessQueue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(851)]
		public virtual void setNextInAccessQueue(ReferenceEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(856)]
		public virtual ReferenceEntry getPreviousInAccessQueue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(861)]
		public virtual void setPreviousInAccessQueue(ReferenceEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(866)]
		public virtual long getWriteTime()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(871)]
		public virtual void setWriteTime(long P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(876)]
		public virtual ReferenceEntry getNextInWriteQueue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(881)]
		public virtual void setNextInWriteQueue(ReferenceEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(886)]
		public virtual ReferenceEntry getPreviousInWriteQueue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(891)]
		public virtual void setPreviousInWriteQueue(ReferenceEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractQueue<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
	internal sealed class AccessQueue : AbstractQueue
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/cache/LocalCache$AbstractReferenceEntry<TK;TV;>;")]
		[EnclosingMethod(null, null, null)]
		internal class _1 : AbstractReferenceEntry
		{
			[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			internal ReferenceEntry nextAccess;

			[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			internal ReferenceEntry previousAccess;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 174, 77, 232, 74, 231, 76 })]
			internal _1(AccessQueue P_0)
			{
				nextAccess = this;
				previousAccess = this;
			}

			public override long getAccessTime()
			{
				return long.MaxValue;
			}

			public override void setAccessTime(long P_0)
			{
			}

			[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			public override ReferenceEntry getNextInAccessQueue()
			{
				return nextAccess;
			}

			[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
			public override void setNextInAccessQueue(ReferenceEntry P_0)
			{
				nextAccess = P_0;
			}

			[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			public override ReferenceEntry getPreviousInAccessQueue()
			{
				return previousAccess;
			}

			[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
			public override void setPreviousInAccessQueue(ReferenceEntry P_0)
			{
				previousAccess = P_0;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractSequentialIterator<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _2 : AbstractSequentialIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AccessQueue this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(3891)]
			internal _2(AccessQueue P_0, ReferenceEntry P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 174, 196, 103 })]
			protected internal virtual ReferenceEntry computeNext(ReferenceEntry P_0)
			{
				ReferenceEntry nextInAccessQueue = P_0.getNextInAccessQueue();
				return (nextInAccessQueue != this_00240.head) ? nextInAccessQueue : null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(3891)]
			protected internal override object computeNext(object P_0)
			{
				ReferenceEntry result = computeNext((ReferenceEntry)P_0);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry head;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 146, 103, 103, 103, 103, 134 })]
		public override bool remove(object P_0)
		{
			ReferenceEntry referenceEntry = (ReferenceEntry)P_0;
			ReferenceEntry previousInAccessQueue = referenceEntry.getPreviousInAccessQueue();
			ReferenceEntry nextInAccessQueue = referenceEntry.getNextInAccessQueue();
			connectAccessOrder(previousInAccessQueue, nextInAccessQueue);
			nullifyAccessOrder(referenceEntry);
			return nextInAccessQueue != NullEntry.INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 174, 128, 108 })]
		public new virtual ReferenceEntry peek()
		{
			ReferenceEntry nextInAccessQueue = head.getNextInAccessQueue();
			return (nextInAccessQueue != head) ? nextInAccessQueue : null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 174, 134, 108, 105, 162, 104 })]
		public new virtual ReferenceEntry poll()
		{
			ReferenceEntry nextInAccessQueue = head.getNextInAccessQueue();
			if (nextInAccessQueue == head)
			{
				return null;
			}
			remove(nextInAccessQueue);
			return nextInAccessQueue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Z")]
		[LineNumberTable(new byte[] { 174, 117, 177, 113, 140 })]
		public virtual bool offer(ReferenceEntry P_0)
		{
			connectAccessOrder(P_0.getPreviousInAccessQueue(), P_0.getNextInAccessQueue());
			connectAccessOrder(head.getPreviousInAccessQueue(), P_0);
			connectAccessOrder(P_0, head);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 75, 104 })]
		internal AccessQueue()
		{
			head = new _1(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 158, 103 })]
		public override bool contains(object P_0)
		{
			ReferenceEntry referenceEntry = (ReferenceEntry)P_0;
			return referenceEntry.getNextInAccessQueue() != NullEntry.INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3862)]
		public override bool isEmpty()
		{
			return head.getNextInAccessQueue() == head;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 169, 98, 108, 137, 36, 169 })]
		public override int size()
		{
			int num = 0;
			for (ReferenceEntry nextInAccessQueue = head.getNextInAccessQueue(); nextInAccessQueue != head; nextInAccessQueue = nextInAccessQueue.getNextInAccessQueue())
			{
				num++;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 180, 108, 105, 103, 102, 98, 130, 113, 115 })]
		public override void clear()
		{
			ReferenceEntry referenceEntry = head.getNextInAccessQueue();
			while (referenceEntry != head)
			{
				ReferenceEntry nextInAccessQueue = referenceEntry.getNextInAccessQueue();
				nullifyAccessOrder(referenceEntry);
				referenceEntry = nextInAccessQueue;
			}
			head.setNextInAccessQueue(head);
			head.setPreviousInAccessQueue(head);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		[LineNumberTable(3891)]
		public override Iterator iterator()
		{
			_2 result = new _2(this, peek());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3773)]
		public override object peek()
		{
			ReferenceEntry result = peek();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3773)]
		public override object poll()
		{
			ReferenceEntry result = poll();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3773)]
		public override bool offer(object P_0)
		{
			bool result = offer((ReferenceEntry)P_0);
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$LoadingValueReference<TK;TV;>;")]
	internal class ComputingValueReference : LoadingValueReference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 173, 170, 105 })]
		internal ComputingValueReference(ValueReference P_0)
			: base(P_0)
		{
		}

		public override bool isLoading()
		{
			return false;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/cache/LocalCache$EntryFactory;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)112,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class EntryFactory : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)34,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _1 : EntryFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(444)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 34, 0, 0 })]
			[LineNumberTable(448)]
			internal override ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3)
			{
				StrongEntry result = new StrongEntry(P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				EntryFactory.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)36,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _2 : EntryFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(451)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 36, 0, 0 })]
			[LineNumberTable(455)]
			internal override ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3)
			{
				StrongAccessEntry result = new StrongAccessEntry(P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 91, 106, 104 })]
			internal override ReferenceEntry copyEntry(Segment P_0, ReferenceEntry P_1, ReferenceEntry P_2)
			{
				ReferenceEntry referenceEntry = base.copyEntry(P_0, P_1, P_2);
				base.copyAccessEntry(P_1, referenceEntry);
				return referenceEntry;
			}

			[HideFromJava]
			static _2()
			{
				EntryFactory.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)36,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _3 : EntryFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(466)]
			internal _3(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 36, 0, 0 })]
			[LineNumberTable(470)]
			internal override ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3)
			{
				StrongWriteEntry result = new StrongWriteEntry(P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 106, 106, 104 })]
			internal override ReferenceEntry copyEntry(Segment P_0, ReferenceEntry P_1, ReferenceEntry P_2)
			{
				ReferenceEntry referenceEntry = base.copyEntry(P_0, P_1, P_2);
				base.copyWriteEntry(P_1, referenceEntry);
				return referenceEntry;
			}

			[HideFromJava]
			static _3()
			{
				EntryFactory.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)37,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _4 : EntryFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(481)]
			internal _4(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 37, 0, 0 })]
			[LineNumberTable(485)]
			internal override ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3)
			{
				StrongAccessWriteEntry result = new StrongAccessWriteEntry(P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 121, 106, 104, 104 })]
			internal override ReferenceEntry copyEntry(Segment P_0, ReferenceEntry P_1, ReferenceEntry P_2)
			{
				ReferenceEntry referenceEntry = base.copyEntry(P_0, P_1, P_2);
				base.copyAccessEntry(P_1, referenceEntry);
				base.copyWriteEntry(P_1, referenceEntry);
				return referenceEntry;
			}

			[HideFromJava]
			static _4()
			{
				EntryFactory.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)35,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _5 : EntryFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(497)]
			internal _5(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 35, 0, 0 })]
			[LineNumberTable(501)]
			internal override ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3)
			{
				WeakEntry result = new WeakEntry(P_0.keyReferenceQueue, P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _5()
			{
				EntryFactory.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)37,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _6 : EntryFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(504)]
			internal _6(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 37, 0, 0 })]
			[LineNumberTable(508)]
			internal override ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3)
			{
				WeakAccessEntry result = new WeakAccessEntry(P_0.keyReferenceQueue, P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 144, 106, 104 })]
			internal override ReferenceEntry copyEntry(Segment P_0, ReferenceEntry P_1, ReferenceEntry P_2)
			{
				ReferenceEntry referenceEntry = base.copyEntry(P_0, P_1, P_2);
				base.copyAccessEntry(P_1, referenceEntry);
				return referenceEntry;
			}

			[HideFromJava]
			static _6()
			{
				EntryFactory.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)37,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _7 : EntryFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(519)]
			internal _7(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 37, 0, 0 })]
			[LineNumberTable(523)]
			internal override ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3)
			{
				WeakWriteEntry result = new WeakWriteEntry(P_0.keyReferenceQueue, P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 159, 106, 104 })]
			internal override ReferenceEntry copyEntry(Segment P_0, ReferenceEntry P_1, ReferenceEntry P_2)
			{
				ReferenceEntry referenceEntry = base.copyEntry(P_0, P_1, P_2);
				base.copyWriteEntry(P_1, referenceEntry);
				return referenceEntry;
			}

			[HideFromJava]
			static _7()
			{
				EntryFactory.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[ConstantPool(new object[]
		{
			(byte)38,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class _8 : EntryFactory
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(534)]
			internal _8(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 38, 0, 0 })]
			[LineNumberTable(538)]
			internal override ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3)
			{
				WeakAccessWriteEntry result = new WeakAccessWriteEntry(P_0.keyReferenceQueue, P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 174, 106, 104, 104 })]
			internal override ReferenceEntry copyEntry(Segment P_0, ReferenceEntry P_1, ReferenceEntry P_2)
			{
				ReferenceEntry referenceEntry = base.copyEntry(P_0, P_1, P_2);
				base.copyAccessEntry(P_1, referenceEntry);
				base.copyWriteEntry(P_1, referenceEntry);
				return referenceEntry;
			}

			[HideFromJava]
			static _8()
			{
				EntryFactory.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFactory STRONG;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFactory STRONG_ACCESS;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFactory STRONG_WRITE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFactory STRONG_ACCESS_WRITE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFactory WEAK;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFactory WEAK_ACCESS;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFactory WEAK_WRITE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFactory WEAK_ACCESS_WRITE;

		internal const int ACCESS_MASK = 1;

		internal const int WRITE_MASK = 2;

		internal const int WEAK_MASK = 4;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static EntryFactory[] factories;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static EntryFactory[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			158,
			byte.MaxValue,
			68,
			108,
			104,
			105
		})]
		internal static EntryFactory getFactory(Strength P_0, bool P_1, bool P_2)
		{
			int num = ((P_0 == Strength.WEAK) ? 4 : 0) | (P_1 ? 1 : 0) | (P_2 ? 2 : 0);
			return factories[num];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(443)]
		private EntryFactory(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 112, 0, 0 })]
		internal abstract ReferenceEntry newEntry(Segment P_0, object P_1, int P_2, ReferenceEntry P_3);

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(443)]
		private static EntryFactory[] _0024values()
		{
			return new EntryFactory[8] { STRONG, STRONG_ACCESS, STRONG_WRITE, STRONG_ACCESS_WRITE, WEAK, WEAK_ACCESS, WEAK_WRITE, WEAK_ACCESS_WRITE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(443)]
		public static EntryFactory[] values()
		{
			return (EntryFactory[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(443)]
		public static EntryFactory valueOf(string P_0)
		{
			return (EntryFactory)java.lang.Enum.valueOf(ClassLiteral<EntryFactory>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(598)]
		internal virtual ReferenceEntry copyEntry(Segment P_0, ReferenceEntry P_1, ReferenceEntry P_2)
		{
			ReferenceEntry result = newEntry(P_0, P_1.getKey(), P_1.getHash(), P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 235, 140, 108, 140, 104 })]
		internal virtual void copyAccessEntry(ReferenceEntry P_0, ReferenceEntry P_1)
		{
			P_1.setAccessTime(P_0.getAccessTime());
			connectAccessOrder(P_0.getPreviousInAccessQueue(), P_1);
			connectAccessOrder(P_1, P_0.getNextInAccessQueue());
			nullifyAccessOrder(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 247, 140, 108, 140, 104 })]
		internal virtual void copyWriteEntry(ReferenceEntry P_0, ReferenceEntry P_1)
		{
			P_1.setWriteTime(P_0.getWriteTime());
			connectWriteOrder(P_0.getPreviousInWriteQueue(), P_1);
			connectWriteOrder(P_1, P_0.getNextInWriteQueue());
			nullifyWriteOrder(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(443)]
		internal EntryFactory(string P_0, int P_1, LocalCache._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[]
		{
			161, 74, 240, 71, 240, 79, 240, 79, 240, 80,
			240, 71, 240, 79, 240, 79, 240, 159, 165, 234,
			160, 115
		})]
		static EntryFactory()
		{
			STRONG = new _1("STRONG", 0);
			STRONG_ACCESS = new _2("STRONG_ACCESS", 1);
			STRONG_WRITE = new _3("STRONG_WRITE", 2);
			STRONG_ACCESS_WRITE = new _4("STRONG_ACCESS_WRITE", 3);
			WEAK = new _5("WEAK", 4);
			WEAK_ACCESS = new _6("WEAK_ACCESS", 5);
			WEAK_WRITE = new _7("WEAK_WRITE", 6);
			WEAK_ACCESS_WRITE = new _8("WEAK_ACCESS_WRITE", 7);
			_0024VALUES = _0024values();
			factories = new EntryFactory[8] { STRONG, STRONG_ACCESS, STRONG_WRITE, STRONG_ACCESS_WRITE, WEAK, WEAK_ACCESS, WEAK_WRITE, WEAK_ACCESS_WRITE };
		}
	}

	[InnerClass(null, Modifiers.Final)]
	[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>.HashIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal sealed class EntryIterator : HashIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4507)]
		public new virtual Map.Entry next()
		{
			WriteThroughEntry result = base.nextEntry();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4503)]
		internal EntryIterator(LocalCache P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(4503)]
		public override object next()
		{
			Map.Entry result = next();
			_ = null;
			return result;
		}
	}

	[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>.AbstractCacheSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal sealed class EntrySet : AbstractCacheSet
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiPredicate
		{
			private readonly java.util.function.Predicate arg_00241;

			internal ___003C_003EAnon0(java.util.function.Predicate P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0, object P_1)
			{
				bool result = lambda_0024removeIf_00240(arg_00241, P_0, P_1);
				_ = null;
				return result;
			}

			[SpecialName]
			public BiPredicate and(BiPredicate P_0)
			{
				return BiPredicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public BiPredicate negate()
			{
				return BiPredicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public BiPredicate or(BiPredicate P_0)
			{
				return BiPredicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new LocalCache this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4629)]
		internal EntrySet(LocalCache P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(4639)]
		private static bool lambda_0024removeIf_00240(java.util.function.Predicate P_0, object P_1, object P_2)
		{
			bool result = P_0.test(Maps.immutableEntry(P_1, P_2));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(4633)]
		public override Iterator iterator()
		{
			EntryIterator result = new EntryIterator(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Z")]
		[LineNumberTable(new byte[] { 177, 172, 103 })]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			Preconditions.checkNotNull(P_0);
			bool result = this_00240.removeIf(new ___003C_003EAnon0(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 177, 178, 104, 130, 103, 103, 99, 130, 141 })]
		public override bool contains(object P_0)
		{
			if (!(P_0 is Map.Entry))
			{
				return false;
			}
			Map.Entry entry = (Map.Entry)P_0;
			object key = entry.getKey();
			if (key == null)
			{
				return false;
			}
			object obj = this_00240.get(key);
			return (obj != null && this_00240.valueEquivalence.equivalent(entry.getValue(), obj)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 177, 193, 104, 130, 103, 103 })]
		public override bool remove(object P_0)
		{
			if (!(P_0 is Map.Entry))
			{
				return false;
			}
			Map.Entry entry = (Map.Entry)P_0;
			object key = entry.getKey();
			return (key != null && this_00240.remove(key, entry.getValue())) ? true : false;
		}
	}

	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	[ConstantPool(new object[]
	{
		(byte)47,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class HashIterator : java.lang.Object, Iterator
	{
		internal int nextSegmentIndex;

		internal int nextTableIndex;

		[Signature("Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 47, 0, 0 })]
		internal Segment currentSegment;

		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceArray<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 47, 0, 0 })]
		internal AtomicReferenceArray currentTable;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 47, 0, 0 })]
		internal ReferenceEntry nextEntry;

		[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>.WriteThroughEntry;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 1, 0, 0, 47, 0, 0 })]
		internal WriteThroughEntry nextExternal;

		[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>.WriteThroughEntry;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 1, 0, 0, 47, 0, 0 })]
		internal WriteThroughEntry lastReturned;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LocalCache this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			176, 136, 135, 104, 161, 104, 161, 105, 127, 6,
			111, 115, 115, 104, 193
		})]
		internal void advance()
		{
			nextExternal = null;
			if (nextInChain() || nextInTable())
			{
				return;
			}
			while (nextSegmentIndex >= 0)
			{
				Segment[] segments = this_00240.segments;
				int num = nextSegmentIndex;
				nextSegmentIndex = num - 1;
				currentSegment = segments[num];
				if (currentSegment.count != 0)
				{
					currentTable = currentSegment.table;
					nextTableIndex = currentTable.length() - 1;
					if (nextInTable())
					{
						break;
					}
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 160, 104, 121, 110, 2, 243, 70 })]
		internal virtual bool nextInChain()
		{
			if (this.nextEntry != null)
			{
				this.nextEntry = this.nextEntry.getNext();
				while (this.nextEntry != null)
				{
					if (advanceTo(this.nextEntry))
					{
						return true;
					}
					this.nextEntry = this.nextEntry.getNext();
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 172, 105, 127, 17, 118, 194 })]
		internal virtual bool nextInTable()
		{
			while (nextTableIndex >= 0)
			{
				AtomicReferenceArray atomicReferenceArray = currentTable;
				int num = nextTableIndex;
				nextTableIndex = num - 1;
				ReferenceEntry referenceEntry = (ReferenceEntry)atomicReferenceArray.get(num);
				this.nextEntry = referenceEntry;
				if (referenceEntry != null && (advanceTo(this.nextEntry) || nextInChain()))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Z")]
		[LineNumberTable(new byte[]
		{
			176, 188, 113, 103, 110, 99, 115, 232, 70, 107,
			37, 235, 58, 162, 166, 107, 35, 226, 61
		})]
		internal virtual bool advanceTo(ReferenceEntry P_0)
		{
			int result;
			try
			{
				long num = this_00240.ticker.read();
				object key = P_0.getKey();
				object liveValue = this_00240.getLiveValue(P_0, num);
				if (liveValue != null)
				{
					nextExternal = new WriteThroughEntry(this_00240, key, liveValue);
					result = 1;
					goto IL_0054;
				}
			}
			catch
			{
				//try-fault
				currentSegment.postReadCleanup();
				throw;
			}
			try
			{
				return false;
			}
			finally
			{
				currentSegment.postReadCleanup();
			}
			IL_0054:
			currentSegment.postReadCleanup();
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 126, 111, 111, 103, 104 })]
		internal HashIterator(LocalCache P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			nextSegmentIndex = (int)((nint)P_0.segments.LongLength - 1);
			nextTableIndex = -1;
			advance();
		}

		[Signature("()TT;")]
		public abstract object next();

		public virtual bool hasNext()
		{
			return nextExternal != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/LocalCache<TK;TV;>.WriteThroughEntry;")]
		[LineNumberTable(new byte[] { 176, 209, 104, 139, 108, 102 })]
		internal virtual WriteThroughEntry nextEntry()
		{
			if (nextExternal == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			lastReturned = nextExternal;
			advance();
			return lastReturned;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 219, 113, 119, 103 })]
		public virtual void remove()
		{
			Preconditions.checkState(lastReturned != null);
			this_00240.remove(lastReturned.getKey());
			lastReturned = null;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Final)]
	[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>.HashIterator<TK;>;")]
	internal sealed class KeyIterator : HashIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4435)]
		internal KeyIterator(LocalCache P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(4439)]
		public override object next()
		{
			object key = base.nextEntry().getKey();
			_ = null;
			return key;
		}
	}

	[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>.AbstractCacheSet<TK;>;")]
	internal sealed class KeySet : AbstractCacheSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new LocalCache this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4565)]
		internal KeySet(LocalCache P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(4569)]
		public override Iterator iterator()
		{
			KeyIterator result = new KeyIterator(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4574)]
		public override bool contains(object P_0)
		{
			bool result = this_00240.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4579)]
		public override bool remove(object P_0)
		{
			return this_00240.remove(P_0) != null;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$ManualSerializationProxy<TK;TV;>;Lcom/google/common/cache/LoadingCache<TK;TV;>;Ljava/io/Serializable;")]
	[ConstantPool(new object[]
	{
		(byte)26,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.cache.LoadingCache", "java.io.Serializable" })]
	internal sealed class LoadingSerializationProxy : ManualSerializationProxy, LoadingCache, Cache, com.google.common.@base.Function, java.util.function.Function, Serializable.__Interface, IObjectReference
	{
		private const long serialVersionUID = 1L;

		[NonSerialized]
		[Signature("Lcom/google/common/cache/LoadingCache<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 26, 0, 0 })]
		internal LoadingCache autoDelegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LocalCache<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 178, 81, 105 })]
		internal LoadingSerializationProxy(LocalCache P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 178, 85, 102, 103, 114 })]
		private void readObject(ObjectInputStream P_0)
		{
			P_0.defaultReadObject();
			CacheBuilder cacheBuilder = base.recreateCacheBuilder();
			autoDelegate = cacheBuilder.build(loader);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(TK;)TV;")]
		[LineNumberTable(4814)]
		public virtual object get(object P_0)
		{
			object result = autoDelegate.get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TV;")]
		[LineNumberTable(4819)]
		public virtual object getUnchecked(object P_0)
		{
			object @unchecked = autoDelegate.getUnchecked(P_0);
			_ = null;
			return @unchecked;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(Ljava/lang/Iterable<+TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(4824)]
		public virtual ImmutableMap getAll(Iterable P_0)
		{
			ImmutableMap all = autoDelegate.getAll(P_0);
			_ = null;
			return all;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TV;")]
		[LineNumberTable(4829)]
		public object apply(object P_0)
		{
			object result = autoDelegate.apply(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)V")]
		[LineNumberTable(new byte[] { 178, 112, 110 })]
		public virtual void refresh(object P_0)
		{
			autoDelegate.refresh(P_0);
		}

		private object readResolve()
		{
			return autoDelegate;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}

		bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected LoadingSerializationProxy(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			return readResolve();
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)75,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class LoadingValueReference : java.lang.Object, ValueReference
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<TV;TV;>;")]
		[EnclosingMethod(null, "loadFuture", "(Ljava.lang.Object;Lcom.google.common.cache.CacheLoader;)Lcom.google.common.util.concurrent.ListenableFuture;")]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal LoadingValueReference this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(3544)]
			internal _1(LoadingValueReference P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TV;)TV;")]
			[LineNumberTable(new byte[] { 173, 105, 109 })]
			public virtual object apply(object P_0)
			{
				this_00240.set(P_0);
				return P_0;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}

			bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[Signature("Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		internal volatile ValueReference oldValue;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/util/concurrent/SettableFuture<TV;>;")]
		internal SettableFuture futureValue;

		[Modifiers(Modifiers.Final)]
		internal Stopwatch stopwatch;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 173, 41, 232, 57, 107, 235, 71, 120 })]
		public LoadingValueReference(ValueReference P_0)
		{
			futureValue = SettableFuture.create();
			stopwatch = Stopwatch.createUnstarted();
			oldValue = ((P_0 != null) ? P_0 : unset());
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 75, 0, 0 })]
		[LineNumberTable(3503)]
		public virtual bool set(object P_0)
		{
			bool result = futureValue.set(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3507)]
		public virtual bool setException(System.Exception P_0)
		{
			bool result = futureValue.setException(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Throwable;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		[LineNumberTable(3511)]
		private ListenableFuture fullyFailedFuture(System.Exception P_0)
		{
			ListenableFuture result = Futures.immediateFailedFuture(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 173, 38, 105 })]
		public LoadingValueReference()
			: this(null)
		{
		}

		public virtual bool isLoading()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3494)]
		public virtual bool isActive()
		{
			bool result = oldValue.isActive();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3499)]
		public virtual int getWeight()
		{
			int weight = oldValue.getWeight();
			_ = null;
			return weight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 75, 0, 0 })]
		[LineNumberTable(new byte[] { 173, 74, 163, 170, 210 })]
		public virtual void notifyNewValue(object P_0)
		{
			if (P_0 != null)
			{
				set(P_0);
				return;
			}
			oldValue = unset();
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Lcom/google/common/cache/CacheLoader<-TK;TV;>;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		[LineNumberTable(new byte[]
		{
			173,
			88,
			108,
			110,
			99,
			104,
			159,
			14,
			105,
			99,
			201,
			231,
			73,
			229,
			55,
			byte.MaxValue,
			2,
			74,
			98,
			123,
			105,
			138
		})]
		public virtual ListenableFuture loadFuture(object P_0, CacheLoader P_1)
		{
			//Discarded unreachable code: IL_007a
			System.Exception ex;
			object obj2;
			try
			{
				stopwatch.start();
				object obj = oldValue.get();
				if (obj == null)
				{
					obj2 = P_1.load(P_0);
					ListenableFuture obj3 = ((!set(obj2)) ? Futures.immediateFuture(obj2) : futureValue);
					return (obj3 == null) ? null : ((obj3 as ListenableFuture) ?? throw new java.lang.IncompatibleClassChangeError());
				}
				ListenableFuture listenableFuture = P_1.reload(P_0, obj);
				if (listenableFuture == null)
				{
					return Futures.immediateFuture(null);
				}
				return Futures.transform(listenableFuture, new _1(this), MoreExecutors.directExecutor());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
			}
			System.Exception ex2 = ex;
			obj2 = ((!setException(ex2)) ? fullyFailedFuture(ex2) : futureValue);
			if (ex2 is InterruptedException)
			{
				java.lang.Thread.currentThread().interrupt();
			}
			object obj4 = obj2;
			return (obj4 == null) ? null : ((obj4 as ListenableFuture) ?? throw new java.lang.IncompatibleClassChangeError());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 1, 2, 3, 1, 2, 0, 0,
			75, 0, 0
		})]
		[LineNumberTable(new byte[]
		{
			173, 120, 172, 185, 2, 97, 194, 219, 226, 61,
			97, 104, 135, 104
		})]
		public virtual object compute(object P_0, BiFunction P_1)
		{
			stopwatch.start();
			object u;
			try
			{
				u = oldValue.waitForValue();
			}
			catch (ExecutionException)
			{
				goto IL_0022;
			}
			goto IL_002a;
			IL_0022:
			_ = null;
			u = null;
			goto IL_002a;
			IL_002a:
			object obj;
			System.Exception ex2;
			try
			{
				obj = P_1.apply(P_0, u);
			}
			catch (System.Exception x)
			{
				ex2 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0042;
			}
			set(obj);
			return obj;
			IL_0042:
			System.Exception ex3 = ex2;
			setException(ex3);
			throw Throwable.___003Cunmap_003E(ex3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3581)]
		public virtual long elapsedNanos()
		{
			long result = stopwatch.elapsed(TimeUnit.NANOSECONDS);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("()TV;")]
		[LineNumberTable(3586)]
		public virtual object waitForValue()
		{
			object uninterruptibly = Uninterruptibles.getUninterruptibly(futureValue);
			_ = null;
			return uninterruptibly;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(3591)]
		public virtual object get()
		{
			object result = oldValue.get();
			_ = null;
			return result;
		}

		[Signature("()Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		public virtual ValueReference getOldValue()
		{
			return oldValue;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public virtual ReferenceEntry getEntry()
		{
			return null;
		}

		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 1, 0, 0, 75, 0, 0 })]
		public virtual ValueReference copyFor(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
		{
			return this;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$LocalManualCache<TK;TV;>;Lcom/google/common/cache/LoadingCache<TK;TV;>;")]
	[Implements(new string[] { "com.google.common.cache.LoadingCache" })]
	internal class LocalLoadingCache : LocalManualCache, LoadingCache, Cache, com.google.common.@base.Function, java.util.function.Function
	{
		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/CacheBuilder<-TK;-TV;>;Lcom/google/common/cache/CacheLoader<-TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 178, 221, 127, 0 })]
		internal LocalLoadingCache(CacheBuilder P_0, CacheLoader P_1)
		{
			___003Cclinit_003E();
			base._002Ector(new LocalCache(P_0, (CacheLoader)Preconditions.checkNotNull(P_1)), null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(TK;)TV;")]
		[LineNumberTable(4950)]
		public virtual object get(object P_0)
		{
			object orLoad = localCache.getOrLoad(P_0);
			_ = null;
			return orLoad;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TV;")]
		[LineNumberTable(new byte[] { 178, 234, 125, 97 })]
		public virtual object getUnchecked(object P_0)
		{
			//Discarded unreachable code: IL_0009
			ExecutionException ex;
			try
			{
				return get(P_0);
			}
			catch (ExecutionException x)
			{
				ex = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			ExecutionException @this = ex;
			System.Exception cause = Throwable.instancehelper_getCause(@this);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UncheckedExecutionException(cause);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(Ljava/lang/Iterable<+TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(4964)]
		public virtual ImmutableMap getAll(Iterable P_0)
		{
			ImmutableMap all = localCache.getAll(P_0);
			_ = null;
			return all;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)V")]
		[LineNumberTable(new byte[] { 178, 247, 110 })]
		public virtual void refresh(object P_0)
		{
			localCache.refresh(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TV;")]
		[LineNumberTable(4974)]
		public object apply(object P_0)
		{
			object @unchecked = getUnchecked(P_0);
			_ = null;
			return @unchecked;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4983)]
		internal override object writeReplace()
		{
			LoadingSerializationProxy result = new LoadingSerializationProxy(localCache);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}

		bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected LocalLoadingCache(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/cache/Cache<TK;TV;>;Ljava/io/Serializable;")]
	[ConstantPool(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.cache.Cache", "java.io.Serializable" })]
	internal class LocalManualCache : java.lang.Object, Cache, Serializable.__Interface, ISerializable
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/cache/CacheLoader<Ljava/lang/Object;TV;>;")]
		[EnclosingMethod(null, "get", "(Ljava.lang.Object;Ljava.util.concurrent.Callable;)Ljava.lang.Object;")]
		internal class _1 : CacheLoader
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Callable val_0024valueLoader;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(4865)]
			internal _1(LocalManualCache P_0, Callable P_1)
			{
				val_0024valueLoader = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Signature("(Ljava/lang/Object;)TV;")]
			[LineNumberTable(4868)]
			public override object load(object P_0)
			{
				object result = val_0024valueLoader.call();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>;")]
		internal LocalCache localCache;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/CacheBuilder<-TK;-TV;>;)V")]
		[LineNumberTable(new byte[] { 178, 124, 111 })]
		internal LocalManualCache(CacheBuilder P_0)
			: this(new LocalCache(P_0, null))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LocalCache<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 178, 127, 104, 103 })]
		private LocalManualCache(LocalCache P_0)
		{
			localCache = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 64, 0, 0 })]
		[LineNumberTable(4857)]
		public virtual object getIfPresent(object P_0)
		{
			object ifPresent = localCache.getIfPresent(P_0);
			_ = null;
			return ifPresent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(TK;Ljava/util/concurrent/Callable<+TV;>;)TV;")]
		[LineNumberTable(new byte[] { 178, 140, 103 })]
		public virtual object get(object P_0, Callable P_1)
		{
			Preconditions.checkNotNull(P_1);
			object result = localCache.get(P_0, new _1(this, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<*>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(4875)]
		public virtual ImmutableMap getAllPresent(Iterable P_0)
		{
			ImmutableMap allPresent = localCache.getAllPresent(P_0);
			_ = null;
			return allPresent;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)V")]
		[LineNumberTable(new byte[] { 178, 158, 110 })]
		public virtual void put(object P_0, object P_1)
		{
			localCache.put(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
		[LineNumberTable(new byte[] { 178, 163, 110 })]
		public virtual void putAll(Map P_0)
		{
			localCache.putAll(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 178, 168, 103, 109 })]
		public virtual void invalidate(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			localCache.remove(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<*>;)V")]
		[LineNumberTable(new byte[] { 178, 174, 110 })]
		public virtual void invalidateAll(Iterable P_0)
		{
			localCache.invalidateAll(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 178, 179, 109 })]
		public virtual void invalidateAll()
		{
			localCache.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4906)]
		public virtual long size()
		{
			long result = localCache.longSize();
			_ = null;
			return result;
		}

		[Signature("()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
		public virtual ConcurrentMap asMap()
		{
			return localCache;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 178, 194, 102, 113, 122, 45, 166 })]
		public virtual CacheStats stats()
		{
			AbstractCache.SimpleStatsCounter simpleStatsCounter = new AbstractCache.SimpleStatsCounter();
			simpleStatsCounter.incrementBy(localCache.globalStatsCounter);
			Segment[] segments = localCache.segments;
			int num = segments.Length;
			for (int i = 0; i < num; i++)
			{
				Segment segment = segments[i];
				simpleStatsCounter.incrementBy(segment.statsCounter);
			}
			CacheStats result = simpleStatsCounter.snapshot();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 178, 204, 109 })]
		public virtual void cleanUp()
		{
			localCache.cleanUp();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4934)]
		internal virtual object writeReplace()
		{
			ManualSerializationProxy result = new ManualSerializationProxy(localCache);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(4842)]
		internal LocalManualCache(LocalCache P_0, LocalCache._1 P_1)
			: this(P_0)
		{
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
		protected LocalManualCache(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/ForwardingCache<TK;TV;>;Ljava/io/Serializable;")]
	[ConstantPool(new object[]
	{
		(byte)86,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class ManualSerializationProxy : ForwardingCache, Serializable.__Interface, ISerializable, IObjectReference
	{
		private const long serialVersionUID = 1L;

		[Modifiers(Modifiers.Final)]
		internal Strength keyStrength;

		[Modifiers(Modifiers.Final)]
		internal Strength valueStrength;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
		internal Equivalence keyEquivalence;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
		internal Equivalence valueEquivalence;

		[Modifiers(Modifiers.Final)]
		internal long expireAfterWriteNanos;

		[Modifiers(Modifiers.Final)]
		internal long expireAfterAccessNanos;

		[Modifiers(Modifiers.Final)]
		internal long maxWeight;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/Weigher<TK;TV;>;")]
		internal Weigher weigher;

		[Modifiers(Modifiers.Final)]
		internal int concurrencyLevel;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/RemovalListener<-TK;-TV;>;")]
		internal RemovalListener removalListener;

		[Modifiers(Modifiers.Final)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 86, 0, 0 })]
		internal Ticker ticker;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/CacheLoader<-TK;TV;>;")]
		internal CacheLoader loader;

		[NonSerialized]
		[Signature("Lcom/google/common/cache/Cache<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 86, 0, 0 })]
		internal new Cache @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LocalCache$Strength;Lcom/google/common/cache/LocalCache$Strength;Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;JJJLcom/google/common/cache/Weigher<TK;TV;>;ILcom/google/common/cache/RemovalListener<-TK;-TV;>;Lcom/google/common/base/Ticker;Lcom/google/common/cache/CacheLoader<-TK;TV;>;)V")]
		[LineNumberTable(new byte[]
		{
			178, 3, 104, 103, 103, 103, 104, 104, 104, 104,
			104, 104, 104, 125, 104
		})]
		private ManualSerializationProxy(Strength P_0, Strength P_1, Equivalence P_2, Equivalence P_3, long P_4, long P_5, long P_6, Weigher P_7, int P_8, RemovalListener P_9, Ticker P_10, CacheLoader P_11)
		{
			keyStrength = P_0;
			valueStrength = P_1;
			keyEquivalence = P_2;
			valueEquivalence = P_3;
			expireAfterWriteNanos = P_4;
			expireAfterAccessNanos = P_5;
			maxWeight = P_6;
			weigher = P_7;
			concurrencyLevel = P_8;
			removalListener = P_9;
			ticker = ((P_10 != Ticker.systemTicker() && P_10 != CacheBuilder.NULL_TICKER) ? P_10 : null);
			loader = P_11;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/CacheBuilder<TK;TV;>;")]
		[LineNumberTable(new byte[]
		{
			178, 20, 107, 107, 107, 107, 107, 107, 102, 103,
			106, 146, 106, 146, 109, 109, 106, 175, 106, 173,
			104, 141
		})]
		internal virtual CacheBuilder recreateCacheBuilder()
		{
			CacheBuilder cacheBuilder = CacheBuilder.newBuilder().setKeyStrength(keyStrength).setValueStrength(valueStrength)
				.keyEquivalence(keyEquivalence)
				.valueEquivalence(valueEquivalence)
				.concurrencyLevel(concurrencyLevel)
				.removalListener(removalListener);
			cacheBuilder.strictParsing = false;
			if (expireAfterWriteNanos > 0)
			{
				cacheBuilder.expireAfterWrite(expireAfterWriteNanos, TimeUnit.NANOSECONDS);
			}
			if (expireAfterAccessNanos > 0)
			{
				cacheBuilder.expireAfterAccess(expireAfterAccessNanos, TimeUnit.NANOSECONDS);
			}
			if (weigher != CacheBuilder.OneWeigher.INSTANCE)
			{
				cacheBuilder.weigher(weigher);
				if (maxWeight != -1)
				{
					cacheBuilder.maximumWeight(maxWeight);
				}
			}
			else if (maxWeight != -1)
			{
				cacheBuilder.maximumSize(maxWeight);
			}
			if (ticker != null)
			{
				cacheBuilder.ticker(ticker);
			}
			return cacheBuilder;
		}

		[Signature("()Lcom/google/common/cache/Cache<TK;TV;>;")]
		protected internal override Cache @delegate()
		{
			return this.@delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LocalCache<TK;TV;>;)V")]
		[LineNumberTable(new byte[]
		{
			177,
			232,
			byte.MaxValue,
			49,
			77
		})]
		internal ManualSerializationProxy(LocalCache P_0)
			: this(P_0.keyStrength, P_0.valueStrength, P_0.keyEquivalence, P_0.valueEquivalence, P_0.expireAfterWriteNanos, P_0.expireAfterAccessNanos, P_0.maxWeight, P_0.weigher, P_0.concurrencyLevel, P_0.removalListener, P_0.ticker, P_0.defaultLoader)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 178, 51, 102, 103, 108 })]
		private void readObject(ObjectInputStream P_0)
		{
			P_0.defaultReadObject();
			CacheBuilder cacheBuilder = recreateCacheBuilder();
			this.@delegate = cacheBuilder.build();
		}

		private object readResolve()
		{
			return this.@delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(4678)]
		protected internal new virtual object @delegate()
		{
			Cache result = this.@delegate();
			_ = null;
			return result;
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
		protected ManualSerializationProxy(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(ManualSerializationProxy))
			{
				return this;
			}
			return readResolve();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/cache/LocalCache$NullEntry;>;Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.cache.ReferenceEntry" })]
	internal sealed class NullEntry : java.lang.Enum, ReferenceEntry
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static NullEntry INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static NullEntry[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(733)]
		private NullEntry(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(733)]
		private static NullEntry[] _0024values()
		{
			return new NullEntry[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(733)]
		public static NullEntry[] values()
		{
			return (NullEntry[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(733)]
		public static NullEntry valueOf(string P_0)
		{
			return (NullEntry)java.lang.Enum.valueOf(ClassLiteral<NullEntry>.Value, P_0);
		}

		[Signature("()Lcom/google/common/cache/LocalCache$ValueReference<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public virtual ValueReference getValueReference()
		{
			return null;
		}

		[Signature("(Lcom/google/common/cache/LocalCache$ValueReference<Ljava/lang/Object;Ljava/lang/Object;>;)V")]
		public virtual void setValueReference(ValueReference P_0)
		{
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public virtual ReferenceEntry getNext()
		{
			return null;
		}

		public virtual int getHash()
		{
			return 0;
		}

		public virtual object getKey()
		{
			return null;
		}

		public virtual long getAccessTime()
		{
			return 0L;
		}

		public virtual void setAccessTime(long P_0)
		{
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public virtual ReferenceEntry getNextInAccessQueue()
		{
			return this;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;)V")]
		public virtual void setNextInAccessQueue(ReferenceEntry P_0)
		{
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public virtual ReferenceEntry getPreviousInAccessQueue()
		{
			return this;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;)V")]
		public virtual void setPreviousInAccessQueue(ReferenceEntry P_0)
		{
		}

		public virtual long getWriteTime()
		{
			return 0L;
		}

		public virtual void setWriteTime(long P_0)
		{
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public virtual ReferenceEntry getNextInWriteQueue()
		{
			return this;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;)V")]
		public virtual void setNextInWriteQueue(ReferenceEntry P_0)
		{
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;")]
		public virtual ReferenceEntry getPreviousInWriteQueue()
		{
			return this;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<Ljava/lang/Object;Ljava/lang/Object;>;)V")]
		public virtual void setPreviousInWriteQueue(ReferenceEntry P_0)
		{
		}

		[LineNumberTable(new byte[] { 162, 108, 48 })]
		static NullEntry()
		{
			INSTANCE = new NullEntry("INSTANCE", 0);
			_0024VALUES = _0024values();
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/concurrent/locks/ReentrantLock;")]
	[ConstantPool(new object[]
	{
		(byte)228,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class Segment : ReentrantLock
	{
		[SpecialName]
		[EnclosingMethod(null, "loadAsync", "(Ljava.lang.Object;ILcom.google.common.cache.LocalCache$LoadingValueReference;Lcom.google.common.cache.CacheLoader;)Lcom.google.common.util.concurrent.ListenableFuture;")]
		internal class _1 : java.lang.Object, Runnable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal object val_0024key;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal int val_0024hash;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal LoadingValueReference val_0024loadingValueReference;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ListenableFuture val_0024loadingFuture;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Segment this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(2293)]
			internal _1(Segment P_0, object P_1, int P_2, LoadingValueReference P_3, ListenableFuture P_4)
			{
				this_00240 = P_0;
				val_0024key = P_1;
				val_0024hash = P_2;
				val_0024loadingValueReference = P_3;
				val_0024loadingFuture = P_4;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 168, 135, 223, 23, 226, 61, 97, 117, 141 })]
			public virtual void run()
			{
				System.Exception ex;
				try
				{
					this_00240.getAndRecordStats(val_0024key, val_0024hash, val_0024loadingValueReference, val_0024loadingFuture);
					return;
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				}
				System.Exception ex2 = ex;
				logger.log(Level.WARNING, "Exception thrown during refresh", ex2);
				val_0024loadingValueReference.setException(ex2);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>;")]
		internal LocalCache map;

		internal volatile int count;

		internal long totalWeight;

		internal int modCount;

		internal int threshold;

		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceArray<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 228, 0, 0 })]
		internal volatile AtomicReferenceArray table;

		[Modifiers(Modifiers.Final)]
		internal long maxSegmentWeight;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/lang/ref/ReferenceQueue<TK;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 228, 0, 0 })]
		internal ReferenceQueue keyReferenceQueue;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/lang/ref/ReferenceQueue<TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 228, 0, 0 })]
		internal ReferenceQueue valueReferenceQueue;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Queue<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		internal Queue recencyQueue;

		[Modifiers(Modifiers.Final)]
		internal AtomicInteger readCount;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Queue<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		internal Queue writeQueue;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Queue<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		internal Queue accessQueue;

		[Modifiers(Modifiers.Final)]
		internal AbstractCache.StatsCounter statsCounter;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 228, 0, 0 })]
		[LineNumberTable(1984)]
		internal virtual ReferenceEntry newEntry(object P_0, int P_1, ReferenceEntry P_2)
		{
			ReferenceEntry result = map.entryFactory.newEntry(this, Preconditions.checkNotNull(P_0), P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 167, 87, 136, 162, 103, 103, 139, 162, 116, 116 })]
		internal virtual ReferenceEntry copyEntry(ReferenceEntry P_0, ReferenceEntry P_1)
		{
			if (P_0.getKey() == null)
			{
				return null;
			}
			ValueReference valueReference = P_0.getValueReference();
			object obj = valueReference.get();
			if (obj == null && valueReference.isActive())
			{
				return null;
			}
			ReferenceEntry referenceEntry = map.entryFactory.copyEntry(this, P_0, P_1);
			referenceEntry.setValueReference(valueReference.copyFor(valueReferenceQueue, obj, referenceEntry));
			return referenceEntry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)Z")]
		[LineNumberTable(new byte[]
		{
			172, 129, 134, 107, 105, 107, 141, 230, 92, 102,
			104, 134, 233, 33, 104, 159, 2, 106, 104, 101,
			110, 231, 70, 235, 59, 231, 72, 108, 105, 111,
			237, 72, 102, 104, 134, 236, 60, 102, 104, 230,
			54, 131, 231, 70, 102, 104, 134, 227, 60, 102,
			104, 230, 56, 227, 42, 235, 92, 102, 104, 134,
			230, 58, 135, 102, 104, 134, 227, 60, 2
		})]
		internal virtual bool reclaimValue(object P_0, int P_1, ValueReference P_2)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				_ = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				if (!isHeldByCurrentThread())
				{
					postWriteCleanup();
				}
				throw;
			}
			while (true)
			{
				int result;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					object key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						ValueReference valueReference = referenceEntry2.getValueReference();
						if (valueReference == P_2)
						{
							modCount++;
							ReferenceEntry newValue = removeValueFromChain(referenceEntry, referenceEntry2, key, P_1, P_2.get(), P_2, RemovalCause.___003C_003ECOLLECTED);
							int num = count - 1;
							atomicReferenceArray.set(i, newValue);
							count = num;
							System.Threading.Thread.MemoryBarrier();
							result = 1;
							goto IL_010d;
						}
						goto IL_0124;
					}
					goto IL_0159;
				}
				catch
				{
					//try-fault
					unlock();
					if (!isHeldByCurrentThread())
					{
						postWriteCleanup();
					}
					throw;
				}
				IL_010d:
				unlock();
				if (!isHeldByCurrentThread())
				{
					postWriteCleanup();
				}
				return (byte)result != 0;
				IL_0159:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					if (!isHeldByCurrentThread())
					{
						postWriteCleanup();
					}
					throw;
				}
				continue;
				IL_0124:
				int result2;
				try
				{
					result2 = 0;
				}
				catch
				{
					//try-fault
					unlock();
					if (!isHeldByCurrentThread())
					{
						postWriteCleanup();
					}
					throw;
				}
				unlock();
				if (!isHeldByCurrentThread())
				{
					postWriteCleanup();
				}
				return (byte)result2 != 0;
			}
			try
			{
				return false;
			}
			finally
			{
				unlock();
				if (!isHeldByCurrentThread())
				{
					postWriteCleanup();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;I)Z")]
		[LineNumberTable(new byte[]
		{
			172, 94, 134, 107, 105, 107, 141, 230, 85, 102,
			102, 233, 42, 103, 110, 196, 135, 107, 234, 58,
			231, 72, 108, 105, 111, 235, 70, 102, 102, 7,
			102, 230, 57, 227, 49, 235, 85, 102, 102, 230,
			60, 135, 102, 102, 3, 2
		})]
		internal virtual bool reclaimKey(ReferenceEntry P_0, int P_1)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				_ = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				int result;
				try
				{
					if (referenceEntry2 != null)
					{
						if (referenceEntry2 == P_0)
						{
							modCount++;
							ReferenceEntry newValue = removeValueFromChain(referenceEntry, referenceEntry2, referenceEntry2.getKey(), P_1, referenceEntry2.getValueReference().get(), referenceEntry2.getValueReference(), RemovalCause.___003C_003ECOLLECTED);
							int num = count - 1;
							atomicReferenceArray.set(i, newValue);
							count = num;
							System.Threading.Thread.MemoryBarrier();
							result = 1;
							goto IL_00cb;
						}
						goto IL_00da;
					}
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				break;
				IL_00cb:
				unlock();
				postWriteCleanup();
				return (byte)result != 0;
				IL_00da:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				return false;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;J)TV;")]
		[LineNumberTable(new byte[]
		{
			170, 35, 104, 102, 130, 108, 99, 102, 162, 111,
			103, 130
		})]
		internal virtual object getLiveValue(ReferenceEntry P_0, long P_1)
		{
			if (P_0.getKey() == null)
			{
				tryDrainReferenceQueues();
				return null;
			}
			object obj = P_0.getValueReference().get();
			if (obj == null)
			{
				tryDrainReferenceQueues();
				return null;
			}
			if (map.isExpired(P_0, P_1))
			{
				tryExpireEntries(P_1);
				return null;
			}
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LocalCache<TK;TV;>;IJLcom/google/common/cache/AbstractCache$StatsCounter;)V")]
		[LineNumberTable(new byte[]
		{
			167, 37, 232, 41, 235, 88, 103, 103, 114, 141,
			150, 150, 97, 104, 103, 157, 97, 104, 103, 157,
			97, 104, 103, 125
		})]
		internal Segment(LocalCache P_0, int P_1, long P_2, AbstractCache.StatsCounter P_3)
		{
			readCount = new AtomicInteger();
			map = P_0;
			maxSegmentWeight = P_2;
			statsCounter = (AbstractCache.StatsCounter)Preconditions.checkNotNull(P_3);
			initTable(newEntryArray(P_1));
			keyReferenceQueue = ((!P_0.usesKeyReferences()) ? null : new ReferenceQueue());
			valueReferenceQueue = ((!P_0.usesValueReferences()) ? null : new ReferenceQueue());
			Queue obj = ((!P_0.usesAccessQueue()) ? discardingQueue() : new ConcurrentLinkedQueue());
			recencyQueue = ((obj == null) ? null : ((obj as Queue) ?? throw new java.lang.IncompatibleClassChangeError()));
			Queue obj2 = ((!P_0.usesWriteQueue()) ? discardingQueue() : new WriteQueue());
			writeQueue = ((obj2 == null) ? null : ((obj2 as Queue) ?? throw new java.lang.IncompatibleClassChangeError()));
			Queue obj3 = ((!P_0.usesAccessQueue()) ? discardingQueue() : new AccessQueue());
			accessQueue = ((obj3 == null) ? null : ((obj3 as Queue) ?? throw new java.lang.IncompatibleClassChangeError()));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 173, 5, 113, 103, 104 })]
		internal virtual void cleanUp()
		{
			long num = map.ticker.read();
			runLockedCleanup(num);
			runUnlockedCleanup();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;I)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			167,
			160,
			106,
			113,
			106,
			99,
			234,
			76,
			102,
			42,
			230,
			52,
			162,
			108,
			99,
			104,
			byte.MaxValue,
			3,
			70,
			102,
			37,
			230,
			58,
			130,
			202,
			102,
			227,
			61,
			134,
			102,
			35,
			2
		})]
		internal virtual object get(object P_0, int P_1)
		{
			long num;
			ReferenceEntry liveEntry;
			try
			{
				if (count != 0)
				{
					num = map.ticker.read();
					liveEntry = getLiveEntry(P_0, P_1, num);
					if (liveEntry == null)
					{
						_ = null;
						goto IL_0042;
					}
					goto IL_004a;
				}
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			goto IL_00a9;
			IL_004a:
			object result;
			try
			{
				object obj = liveEntry.getValueReference().get();
				if (obj != null)
				{
					recordRead(liveEntry, num);
					result = scheduleRefresh(liveEntry, liveEntry.getKey(), P_1, obj, num, map.defaultLoader);
					goto IL_008e;
				}
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			try
			{
				tryDrainReferenceQueues();
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			goto IL_00a9;
			IL_008e:
			postReadCleanup();
			return result;
			IL_00a9:
			try
			{
				_ = null;
			}
			finally
			{
				postReadCleanup();
			}
			return null;
			IL_0042:
			postReadCleanup();
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(TK;ILcom/google/common/cache/CacheLoader<-TK;TV;>;)TV;")]
		[LineNumberTable(new byte[]
		{
			167,
			121,
			103,
			135,
			138,
			105,
			99,
			113,
			105,
			99,
			104,
			108,
			byte.MaxValue,
			0,
			84,
			102,
			49,
			230,
			44,
			130,
			104,
			105,
			252,
			80,
			102,
			41,
			230,
			48,
			227,
			70,
			249,
			74,
			102,
			39,
			230,
			54,
			103,
			98,
			105,
			105,
			114,
			105,
			141,
			136,
			102
		})]
		internal virtual object get(object P_0, int P_1, CacheLoader P_2)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkNotNull(P_2);
			ReferenceEntry entry;
			object result;
			ExecutionException ex;
			try
			{
				try
				{
					if (count != 0)
					{
						entry = getEntry(P_0, P_1);
						if (entry != null)
						{
							long num = map.ticker.read();
							object liveValue = getLiveValue(entry, num);
							if (liveValue != null)
							{
								recordRead(entry, num);
								statsCounter.recordHits(1);
								result = scheduleRefresh(entry, P_0, P_1, liveValue, num, P_2);
								goto IL_008b;
							}
							goto IL_0093;
						}
					}
				}
				catch (ExecutionException x)
				{
					ex = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_0084;
				}
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			goto IL_00d8;
			IL_0084:
			ExecutionException ex2 = ex;
			goto IL_0107;
			IL_0093:
			object result2;
			ExecutionException ex3;
			try
			{
				try
				{
					ValueReference valueReference = entry.getValueReference();
					if (valueReference.isLoading())
					{
						result2 = waitForLoadingValue(entry, P_0, valueReference);
						goto IL_00cf;
					}
				}
				catch (ExecutionException x2)
				{
					ex3 = ByteCodeHelper.MapException<ExecutionException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00cb;
				}
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			goto IL_00d8;
			IL_00cb:
			ex2 = ex3;
			goto IL_0107;
			IL_00d8:
			object result3;
			ExecutionException ex4;
			try
			{
				try
				{
					result3 = lockedGetOrLoad(P_0, P_1, P_2);
				}
				catch (ExecutionException x3)
				{
					ex4 = ByteCodeHelper.MapException<ExecutionException>(x3, ByteCodeHelper.MapFlags.NoRemapping);
					goto IL_00fa;
				}
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			postReadCleanup();
			return result3;
			IL_00fa:
			ex2 = ex4;
			goto IL_0107;
			IL_0107:
			ExecutionException ex5 = ex2;
			try
			{
				ExecutionException ex6 = ex5;
				System.Exception ex7 = Throwable.instancehelper_getCause(ex6);
				if (ex7 is Error)
				{
					Error cause = (Error)ex7;
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new ExecutionError(cause);
				}
				if (ex7 is RuntimeException)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new UncheckedExecutionException(ex7);
				}
				throw Throwable.___003Cunmap_003E(ex6);
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			IL_008b:
			postReadCleanup();
			return result;
			IL_00cf:
			postReadCleanup();
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;I)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			169,
			byte.MaxValue,
			107,
			105,
			162,
			103,
			99,
			102,
			162,
			116,
			226,
			52,
			233,
			80
		})]
		internal virtual ReferenceEntry getEntry(object P_0, int P_1)
		{
			for (ReferenceEntry referenceEntry = getFirst(P_1); referenceEntry != null; referenceEntry = referenceEntry.getNext())
			{
				if (referenceEntry.getHash() == P_1)
				{
					object key = referenceEntry.getKey();
					if (key == null)
					{
						tryDrainReferenceQueues();
					}
					else if (map.keyEquivalence.equivalent(P_0, key))
					{
						return referenceEntry;
					}
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/CacheLoader<-TK;TV;>;Z)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			157, 65, 131, 100, 102, 99, 162, 107, 136, 123,
			193
		})]
		internal virtual object refresh(object P_0, int P_1, CacheLoader P_2, bool P_3)
		{
			//Discarded unreachable code: IL_002d
			LoadingValueReference loadingValueReference = insertLoadingValueReference(P_0, P_1, P_3);
			if (loadingValueReference == null)
			{
				return null;
			}
			ListenableFuture listenableFuture = loadAsync(P_0, P_1, loadingValueReference, P_2);
			if (listenableFuture.isDone())
			{
				try
				{
					return Uninterruptibles.getUninterruptibly(listenableFuture);
				}
				catch (System.Exception x)
				{
					ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
				}
				_ = null;
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			170, 54, 106, 113, 106, 99, 234, 71, 102, 39,
			230, 57, 130, 246, 69, 102, 35, 230, 59, 162,
			134, 102, 35, 2
		})]
		internal virtual bool containsKey(object P_0, int P_1)
		{
			ReferenceEntry liveEntry;
			int result;
			try
			{
				if (count != 0)
				{
					long num = map.ticker.read();
					liveEntry = getLiveEntry(P_0, P_1, num);
					if (liveEntry == null)
					{
						result = 0;
						goto IL_003f;
					}
					goto IL_0047;
				}
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			try
			{
				return false;
			}
			finally
			{
				postReadCleanup();
			}
			IL_003f:
			postReadCleanup();
			return (byte)result != 0;
			IL_0047:
			try
			{
				result = ((liveEntry.getValueReference().get() != null) ? 1 : 0);
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			postReadCleanup();
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITV;Z)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			156, 217, 163, 134, 113, 135, 107, 105, 102, 171,
			105, 108, 175, 232, 116, 102, 102, 234, 11, 105,
			159, 3, 170, 105, 137, 103, 110, 105, 103, 42,
			133, 107, 139, 107, 139, 110, 104, 236, 93, 102,
			102, 15, 102, 230, 34, 98, 195, 105, 234, 87,
			102, 102, 5, 102, 230, 40, 163, 110, 103, 42,
			133, 107, 104, 232, 79, 102, 102, 3, 102, 230,
			48, 227, 27, 237, 116, 102, 102, 230, 53, 110,
			108, 107, 106, 107, 110, 104, 134, 102, 102, 3,
			2
		})]
		internal virtual object put(object P_0, int P_1, object P_2, bool P_3)
		{
			@lock();
			long num;
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				num = map.ticker.read();
				preWriteCleanup(num);
				int num2 = count + 1;
				if (num2 > threshold)
				{
					expand();
					_ = count + 1;
				}
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				ValueReference valueReference;
				object obj;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					object key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						valueReference = referenceEntry2.getValueReference();
						obj = valueReference.get();
						if (obj == null)
						{
							modCount++;
							int num2;
							if (valueReference.isActive())
							{
								enqueueNotification(P_0, P_1, obj, valueReference.getWeight(), RemovalCause.___003C_003ECOLLECTED);
								setValue(referenceEntry2, P_0, P_2, num);
								num2 = count;
							}
							else
							{
								setValue(referenceEntry2, P_0, P_2, num);
								num2 = count + 1;
							}
							count = num2;
							System.Threading.Thread.MemoryBarrier();
							evictEntries(referenceEntry2);
							_ = null;
							goto IL_016c;
						}
						goto IL_017a;
					}
					goto IL_020d;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_016c:
				unlock();
				postWriteCleanup();
				return null;
				IL_017a:
				object result;
				try
				{
					if (P_3)
					{
						recordLockedRead(referenceEntry2, num);
						result = obj;
						goto IL_01a1;
					}
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				try
				{
					modCount++;
					enqueueNotification(P_0, P_1, obj, valueReference.getWeight(), RemovalCause.___003C_003EREPLACED);
					setValue(referenceEntry2, P_0, P_2, num);
					evictEntries(referenceEntry2);
					result = obj;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				unlock();
				postWriteCleanup();
				return result;
				IL_01a1:
				unlock();
				postWriteCleanup();
				return result;
				IL_020d:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				modCount++;
				referenceEntry2 = newEntry(P_0, P_1, referenceEntry);
				setValue(referenceEntry2, P_0, P_2, num);
				atomicReferenceArray.set(i, referenceEntry2);
				count++;
				System.Threading.Thread.MemoryBarrier();
				evictEntries(referenceEntry2);
				_ = null;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILjava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 2, 2, 3, 1, 2, 0, 0,
			228, 0, 0
		})]
		[LineNumberTable(new byte[]
		{
			168, 32, 98, 98, 162, 166, 113, 135, 105, 108,
			143, 107, 105, 159, 3, 103, 104, 176, 165, 102,
			234, 60, 229, 73, 110, 110, 98, 226, 43, 238,
			91, 136, 100, 98, 108, 105, 140, 169, 107, 100,
			109, 106, 104, 106, 236, 80, 102, 102, 10, 102,
			230, 47, 163, 103, 37, 237, 77, 102, 102, 6,
			102, 230, 50, 135, 97, 240, 74, 102, 102, 225,
			54, 107, 107, 232, 70, 102, 102, 5, 102, 230,
			57, 130, 111, 166, 102, 102, 3, 226, 61
		})]
		internal virtual object compute(object P_0, int P_1, BiFunction P_2)
		{
			ValueReference valueReference = null;
			_ = null;
			int num = 1;
			@lock();
			ReferenceEntry referenceEntry2;
			ComputingValueReference computingValueReference;
			object obj;
			object key;
			try
			{
				long num2 = map.ticker.read();
				preWriteCleanup(num2);
				AtomicReferenceArray atomicReferenceArray = table;
				int i = P_1 & (atomicReferenceArray.length() - 1);
				ReferenceEntry referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				for (referenceEntry2 = referenceEntry; referenceEntry2 != null; referenceEntry2 = referenceEntry2.getNext())
				{
					key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						valueReference = referenceEntry2.getValueReference();
						if (map.isExpired(referenceEntry2, num2))
						{
							enqueueNotification(key, P_1, valueReference.get(), valueReference.getWeight(), RemovalCause.___003C_003EEXPIRED);
						}
						writeQueue.remove(referenceEntry2);
						accessQueue.remove(referenceEntry2);
						num = 0;
						break;
					}
				}
				computingValueReference = new ComputingValueReference(valueReference);
				if (referenceEntry2 == null)
				{
					num = 1;
					referenceEntry2 = newEntry(P_0, P_1, referenceEntry);
					referenceEntry2.setValueReference(computingValueReference);
					atomicReferenceArray.set(i, referenceEntry2);
				}
				else
				{
					referenceEntry2.setValueReference(computingValueReference);
				}
				obj = computingValueReference.compute(P_0, P_2);
				if (obj != null)
				{
					if (valueReference != null && obj == valueReference.get())
					{
						computingValueReference.set(obj);
						referenceEntry2.setValueReference(valueReference);
						recordWrite(referenceEntry2, 0, num2);
						key = obj;
						goto IL_0177;
					}
					goto IL_0186;
				}
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			try
			{
				if (num != 0 || valueReference.isLoading())
				{
					removeLoadingValue(P_0, P_1, computingValueReference);
					_ = null;
					goto IL_0211;
				}
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			try
			{
				removeEntry(referenceEntry2, P_1, RemovalCause.___003C_003EEXPLICIT);
				_ = null;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
			return null;
			IL_0186:
			try
			{
				try
				{
					key = getAndRecordStats(P_0, P_1, computingValueReference, Futures.immediateFuture(obj));
				}
				catch (ExecutionException)
				{
					goto IL_01ae;
				}
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			unlock();
			postWriteCleanup();
			return key;
			IL_0211:
			unlock();
			postWriteCleanup();
			return null;
			IL_01ae:
			ExecutionException ex2 = null;
			try
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError("impossible; Futures.immediateFuture can't throw");
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			IL_0177:
			unlock();
			postWriteCleanup();
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;I)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			171, 106, 134, 113, 135, 107, 105, 107, 141, 231,
			94, 102, 102, 234, 33, 105, 156, 103, 105, 169,
			100, 105, 105, 169, 236, 79, 102, 102, 15, 102,
			230, 48, 162, 110, 109, 103, 108, 105, 111, 232,
			70, 102, 102, 3, 102, 230, 57, 227, 40, 237,
			94, 102, 102, 230, 60, 134, 102, 102, 3, 2
		})]
		internal virtual object remove(object P_0, int P_1)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				long num = map.ticker.read();
				preWriteCleanup(num);
				_ = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				object key;
				ValueReference valueReference;
				object obj;
				RemovalCause removalCause;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						valueReference = referenceEntry2.getValueReference();
						obj = valueReference.get();
						if (obj != null)
						{
							removalCause = RemovalCause.___003C_003EEXPLICIT;
						}
						else
						{
							if (!valueReference.isActive())
							{
								_ = null;
								goto IL_00eb;
							}
							removalCause = RemovalCause.___003C_003ECOLLECTED;
						}
						goto IL_00f9;
					}
					goto IL_0165;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_00eb:
				unlock();
				postWriteCleanup();
				return null;
				IL_00f9:
				object result;
				try
				{
					modCount++;
					ReferenceEntry newValue = removeValueFromChain(referenceEntry, referenceEntry2, key, P_1, obj, valueReference, removalCause);
					int num2 = count - 1;
					atomicReferenceArray.set(i, newValue);
					count = num2;
					System.Threading.Thread.MemoryBarrier();
					result = obj;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				unlock();
				postWriteCleanup();
				return result;
				IL_0165:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				_ = null;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			171, 152, 134, 113, 135, 107, 105, 107, 141, 231,
			94, 102, 102, 234, 33, 105, 159, 3, 103, 105,
			169, 117, 105, 109, 169, 237, 79, 102, 102, 15,
			102, 230, 48, 163, 110, 109, 103, 108, 105, 111,
			239, 70, 102, 102, 3, 102, 230, 57, 227, 40,
			237, 94, 102, 102, 230, 60, 135, 102, 102, 3,
			2
		})]
		internal virtual bool remove(object P_0, int P_1, object P_2)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				long num = map.ticker.read();
				preWriteCleanup(num);
				_ = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				object key;
				ValueReference valueReference;
				object obj;
				RemovalCause removalCause;
				int result;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						valueReference = referenceEntry2.getValueReference();
						obj = valueReference.get();
						if (map.valueEquivalence.equivalent(P_2, obj))
						{
							removalCause = RemovalCause.___003C_003EEXPLICIT;
						}
						else
						{
							if (obj != null || !valueReference.isActive())
							{
								result = 0;
								goto IL_0107;
							}
							removalCause = RemovalCause.___003C_003ECOLLECTED;
						}
						goto IL_0116;
					}
					goto IL_0189;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_0107:
				unlock();
				postWriteCleanup();
				return (byte)result != 0;
				IL_0116:
				int result2;
				try
				{
					modCount++;
					ReferenceEntry newValue = removeValueFromChain(referenceEntry, referenceEntry2, key, P_1, obj, valueReference, removalCause);
					int num2 = count - 1;
					atomicReferenceArray.set(i, newValue);
					count = num2;
					System.Threading.Thread.MemoryBarrier();
					result2 = ((removalCause == RemovalCause.___003C_003EEXPLICIT) ? 1 : 0);
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				unlock();
				postWriteCleanup();
				return (byte)result2 != 0;
				IL_0189:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				return false;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITV;TV;)Z")]
		[LineNumberTable(new byte[]
		{
			170, 245, 134, 113, 135, 105, 107, 141, 231, 110,
			102, 102, 234, 17, 105, 159, 3, 106, 105, 105,
			103, 137, 107, 110, 112, 231, 72, 108, 105, 143,
			237, 85, 102, 102, 15, 102, 230, 42, 163, 117,
			110, 103, 42, 133, 108, 104, 233, 76, 102, 102,
			5, 102, 230, 51, 195, 105, 231, 71, 102, 102,
			3, 102, 230, 56, 227, 25, 237, 110, 102, 102,
			230, 60, 135, 102, 102, 3, 2
		})]
		internal virtual bool replace(object P_0, int P_1, object P_2, object P_3)
		{
			@lock();
			long num;
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				num = map.ticker.read();
				preWriteCleanup(num);
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				ValueReference valueReference;
				object obj;
				int num2;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					object key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						valueReference = referenceEntry2.getValueReference();
						obj = valueReference.get();
						if (obj == null)
						{
							if (valueReference.isActive())
							{
								_ = count - 1;
								modCount++;
								ReferenceEntry newValue = removeValueFromChain(referenceEntry, referenceEntry2, key, P_1, obj, valueReference, RemovalCause.___003C_003ECOLLECTED);
								num2 = count - 1;
								atomicReferenceArray.set(i, newValue);
								count = num2;
								System.Threading.Thread.MemoryBarrier();
							}
							num2 = 0;
							goto IL_012f;
						}
						goto IL_013e;
					}
					goto IL_01e2;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_012f:
				unlock();
				postWriteCleanup();
				return (byte)num2 != 0;
				IL_013e:
				try
				{
					if (map.valueEquivalence.equivalent(P_2, obj))
					{
						modCount++;
						enqueueNotification(P_0, P_1, obj, valueReference.getWeight(), RemovalCause.___003C_003EREPLACED);
						setValue(referenceEntry2, P_0, P_3, num);
						evictEntries(referenceEntry2);
						num2 = 1;
						goto IL_01a5;
					}
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				try
				{
					recordLockedRead(referenceEntry2, num);
					num2 = 0;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				unlock();
				postWriteCleanup();
				return (byte)num2 != 0;
				IL_01a5:
				unlock();
				postWriteCleanup();
				return (byte)num2 != 0;
				IL_01e2:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				return false;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITV;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			171, 51, 134, 113, 135, 105, 107, 141, 231, 103,
			102, 102, 234, 24, 105, 159, 3, 106, 105, 105,
			103, 137, 107, 110, 112, 231, 72, 108, 105, 143,
			236, 78, 102, 102, 15, 102, 230, 49, 162, 110,
			103, 42, 133, 107, 104, 232, 70, 102, 102, 3,
			102, 230, 57, 227, 31, 237, 103, 102, 102, 230,
			60, 134, 102, 102, 3, 2
		})]
		internal virtual object replace(object P_0, int P_1, object P_2)
		{
			@lock();
			long num;
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				num = map.ticker.read();
				preWriteCleanup(num);
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				ValueReference valueReference;
				object obj;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					object key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						valueReference = referenceEntry2.getValueReference();
						obj = valueReference.get();
						if (obj == null)
						{
							if (valueReference.isActive())
							{
								_ = count - 1;
								modCount++;
								ReferenceEntry newValue = removeValueFromChain(referenceEntry, referenceEntry2, key, P_1, obj, valueReference, RemovalCause.___003C_003ECOLLECTED);
								int num2 = count - 1;
								atomicReferenceArray.set(i, newValue);
								count = num2;
								System.Threading.Thread.MemoryBarrier();
							}
							_ = null;
							goto IL_012e;
						}
						goto IL_013c;
					}
					goto IL_0199;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_012e:
				unlock();
				postWriteCleanup();
				return null;
				IL_013c:
				object result;
				try
				{
					modCount++;
					enqueueNotification(P_0, P_1, obj, valueReference.getWeight(), RemovalCause.___003C_003EREPLACED);
					setValue(referenceEntry2, P_0, P_2, num);
					evictEntries(referenceEntry2);
					result = obj;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				unlock();
				postWriteCleanup();
				return result;
				IL_0199:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				_ = null;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			172, 2, 109, 134, 113, 135, 105, 110, 147, 109,
			104, 141, 118, 100, 52, 229, 57, 44, 233, 77,
			107, 40, 166, 102, 107, 107, 140, 110, 146, 102,
			102, 3, 130, 130
		})]
		internal virtual void clear()
		{
			if (count == 0)
			{
				return;
			}
			@lock();
			try
			{
				long num = map.ticker.read();
				preWriteCleanup(num);
				AtomicReferenceArray atomicReferenceArray = table;
				for (int i = 0; i < atomicReferenceArray.length(); i++)
				{
					for (ReferenceEntry referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i); referenceEntry != null; referenceEntry = referenceEntry.getNext())
					{
						if (referenceEntry.getValueReference().isActive())
						{
							object key = referenceEntry.getKey();
							object obj = referenceEntry.getValueReference().get();
							RemovalCause removalCause = ((key != null && obj != null) ? RemovalCause.___003C_003EEXPLICIT : RemovalCause.___003C_003ECOLLECTED);
							enqueueNotification(key, referenceEntry.getHash(), obj, referenceEntry.getValueReference().getWeight(), removalCause);
						}
					}
				}
				for (int i = 0; i < atomicReferenceArray.length(); i++)
				{
					atomicReferenceArray.set(i, null);
				}
				clearReferenceQueues();
				writeQueue.clear();
				accessQueue.clear();
				readCount.set(0);
				modCount++;
				count = 0;
				System.Threading.Thread.MemoryBarrier();
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 172, 239, 112, 136 })]
		internal virtual void postReadCleanup()
		{
			if ((readCount.incrementAndGet() & 0x3F) == 0)
			{
				cleanUp();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(TK;ILcom/google/common/cache/LocalCache$LoadingValueReference<TK;TV;>;Lcom/google/common/util/concurrent/ListenableFuture<TV;>;)TV;")]
		[LineNumberTable(new byte[]
		{
			168, 153, 130, 104, 99, 159, 41, 113, 107, 134,
			99, 113, 138, 227, 60, 2
		})]
		internal virtual object getAndRecordStats(object P_0, int P_1, LoadingValueReference P_2, ListenableFuture P_3)
		{
			object obj = null;
			try
			{
				obj = Uninterruptibles.getUninterruptibly(P_3);
				if (obj == null)
				{
					string text = java.lang.String.valueOf(P_0);
					int num = 35 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
					num = num;
					string message = new StringBuilder(num).append("CacheLoader returned null for key ").append(text).append(".")
						.toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CacheLoader.InvalidCacheLoadException(message);
				}
				statsCounter.recordLoadSuccess(P_2.elapsedNanos());
				storeLoadedValue(P_0, P_1, P_2, obj);
				return obj;
			}
			finally
			{
				if (obj == null)
				{
					statsCounter.recordLoadException(P_2.elapsedNanos());
					removeLoadingValue(P_0, P_1, P_2);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/concurrent/atomic/AtomicReferenceArray<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		[LineNumberTable(1970)]
		internal virtual AtomicReferenceArray newEntryArray(int P_0)
		{
			AtomicReferenceArray result = new AtomicReferenceArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/atomic/AtomicReferenceArray<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 167, 68, 112, 156, 142, 110 })]
		internal virtual void initTable(AtomicReferenceArray P_0)
		{
			threshold = P_0.length() * 3 / 4;
			if (!map.customWeigher() && threshold == maxSegmentWeight)
			{
				threshold++;
			}
			table = P_0;
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;IJ)V")]
		[LineNumberTable(new byte[] { 169, 123, 102, 143, 109, 135, 109, 135, 109, 109 })]
		internal virtual void recordWrite(ReferenceEntry P_0, int P_1, long P_2)
		{
			drainRecencyQueue();
			totalWeight += P_1;
			if (map.recordsAccess())
			{
				P_0.setAccessTime(P_2);
			}
			if (map.recordsWrite())
			{
				P_0.setWriteTime(P_2);
			}
			accessQueue.add(P_0);
			writeQueue.add(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;J)V")]
		[LineNumberTable(new byte[] { 169, 95, 109, 135, 109 })]
		internal virtual void recordRead(ReferenceEntry P_0, long P_1)
		{
			if (map.recordsAccess())
			{
				P_0.setAccessTime(P_1);
			}
			recencyQueue.add(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TK;ITV;JLcom/google/common/cache/CacheLoader<-TK;TV;>;)TV;")]
		[LineNumberTable(new byte[] { 168, 177, 112, 116, 108, 108, 99, 162 })]
		internal virtual object scheduleRefresh(ReferenceEntry P_0, object P_1, int P_2, object P_3, long P_4, CacheLoader P_5)
		{
			if (map.refreshes() && P_4 - P_0.getWriteTime() > map.refreshNanos && !P_0.getValueReference().isLoading())
			{
				object obj = refresh(P_1, P_2, P_5, true);
				if (obj != null)
				{
					return obj;
				}
			}
			return P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TK;Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)TV;")]
		[LineNumberTable(new byte[]
		{
			168, 10, 104, 171, 183, 103, 99, 191, 41, 113,
			104, 135, 108, 35, 2
		})]
		internal virtual object waitForLoadingValue(ReferenceEntry P_0, object P_1, ValueReference P_2)
		{
			if (!P_2.isLoading())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
			Preconditions.checkState((!java.lang.Thread.holdsLock(P_0)) ? true : false, "Recursive load of: %s", P_1);
			try
			{
				object obj = P_2.waitForValue();
				if (obj == null)
				{
					string text = java.lang.String.valueOf(P_1);
					int num = 35 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
					num = num;
					string message = new StringBuilder(num).append("CacheLoader returned null for key ").append(text).append(".")
						.toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new CacheLoader.InvalidCacheLoadException(message);
				}
				long num2 = map.ticker.read();
				recordRead(P_0, num2);
				return obj;
			}
			finally
			{
				statsCounter.recordMisses(1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(TK;ILcom/google/common/cache/CacheLoader<-TK;TV;>;)TV;")]
		[LineNumberTable(new byte[]
		{
			167, 182, 98, 98, 130, 166, 113, 135, 108, 106,
			109, 144, 232, 110, 102, 102, 234, 17, 105, 159,
			3, 106, 104, 104, 135, 104, 100, 103, 42, 135,
			176, 103, 42, 167, 105, 140, 238, 88, 102, 102,
			12, 102, 230, 39, 195, 110, 110, 143, 228, 80,
			102, 102, 227, 16, 237, 110, 102, 102, 230, 50,
			99, 134, 100, 108, 104, 141, 204, 102, 102, 3,
			102, 102, 130, 230, 69, 106, 191, 2, 108, 39,
			236, 61, 103, 145, 108, 161
		})]
		internal virtual object lockedGetOrLoad(object P_0, int P_1, CacheLoader P_2)
		{
			ValueReference valueReference = null;
			LoadingValueReference loadingValueReference = null;
			int num = 1;
			@lock();
			long num2;
			int num3;
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				num2 = map.ticker.read();
				preWriteCleanup(num2);
				num3 = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				object result;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					object key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						valueReference = referenceEntry2.getValueReference();
						if (valueReference.isLoading())
						{
							num = 0;
							break;
						}
						object obj = valueReference.get();
						if (obj == null)
						{
							enqueueNotification(key, P_1, obj, valueReference.getWeight(), RemovalCause.___003C_003ECOLLECTED);
						}
						else
						{
							if (!map.isExpired(referenceEntry2, num2))
							{
								recordLockedRead(referenceEntry2, num2);
								statsCounter.recordHits(1);
								result = obj;
								goto IL_0148;
							}
							enqueueNotification(key, P_1, obj, valueReference.getWeight(), RemovalCause.___003C_003EEXPIRED);
						}
						goto IL_0157;
					}
					goto IL_0195;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_0148:
				unlock();
				postWriteCleanup();
				return result;
				IL_0157:
				try
				{
					writeQueue.remove(referenceEntry2);
					accessQueue.remove(referenceEntry2);
					count = num3;
					System.Threading.Thread.MemoryBarrier();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				break;
				IL_0195:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				if (num != 0)
				{
					loadingValueReference = new LoadingValueReference();
					if (referenceEntry2 == null)
					{
						referenceEntry2 = newEntry(P_0, P_1, referenceEntry);
						referenceEntry2.setValueReference(loadingValueReference);
						atomicReferenceArray.set(i, referenceEntry2);
					}
					else
					{
						referenceEntry2.setValueReference(loadingValueReference);
					}
				}
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			unlock();
			postWriteCleanup();
			ReferenceEntry obj2;
			System.Exception ex;
			if (num != 0)
			{
				object result2;
				try
				{
					System.Threading.Monitor.Enter(obj2 = referenceEntry2);
					try
					{
						result2 = loadSync(P_0, P_1, loadingValueReference, P_2);
						System.Threading.Monitor.Exit(obj2);
					}
					catch (System.Exception x)
					{
						ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
						goto IL_024b;
					}
				}
				catch
				{
					//try-fault
					statsCounter.recordMisses(1);
					throw;
				}
				statsCounter.recordMisses(1);
				return result2;
			}
			return waitForLoadingValue(referenceEntry2, P_0, valueReference);
			IL_024b:
			System.Exception ex2 = ex;
			try
			{
				System.Exception ex3 = ex2;
				System.Threading.Monitor.Exit(obj2);
				throw Throwable.___003Cunmap_003E(ex3);
			}
			catch
			{
				//try-fault
				statsCounter.recordMisses(1);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;IJ)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[] { 170, 20, 105, 99, 98, 111, 103, 130 })]
		internal virtual ReferenceEntry getLiveEntry(object P_0, int P_1, long P_2)
		{
			ReferenceEntry entry = getEntry(P_0, P_1);
			if (entry == null)
			{
				return null;
			}
			if (map.isExpired(entry, P_2))
			{
				tryExpireEntries(P_2);
				return null;
			}
			return entry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 16, 136, 138, 102, 35, 98, 130 })]
		internal virtual void tryDrainReferenceQueues()
		{
			if (tryLock())
			{
				try
				{
					drainReferenceQueues();
				}
				finally
				{
					unlock();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 172, 252, 105 })]
		internal virtual void preWriteCleanup(long P_0)
		{
			runLockedCleanup(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITV;ILcom/google/common/cache/RemovalCause;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 22, 0, 0, 0, 228, 0, 0, 22,
			2, 0, 0, 228, 0, 0
		})]
		[LineNumberTable(new byte[] { 169, 192, 112, 105, 139, 114, 106, 146 })]
		internal virtual void enqueueNotification(object P_0, int P_1, object P_2, int P_3, RemovalCause P_4)
		{
			totalWeight -= P_3;
			if (P_4.wasEvicted())
			{
				statsCounter.recordEviction();
			}
			if (map.removalNotificationQueue != DISCARDING_QUEUE)
			{
				RemovalNotification e = RemovalNotification.create(P_0, P_2, P_4);
				map.removalNotificationQueue.offer(e);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;J)V")]
		[LineNumberTable(new byte[] { 169, 110, 109, 135, 109 })]
		internal virtual void recordLockedRead(ReferenceEntry P_0, long P_1)
		{
			if (map.recordsAccess())
			{
				P_0.setAccessTime(P_1);
			}
			accessQueue.add(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 173, 1, 104 })]
		internal virtual void postWriteCleanup()
		{
			runUnlockedCleanup();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("(TK;ILcom/google/common/cache/LocalCache$LoadingValueReference<TK;TV;>;Lcom/google/common/cache/CacheLoader<-TK;TV;>;)TV;")]
		[LineNumberTable(new byte[] { 168, 120, 106 })]
		internal virtual object loadSync(object P_0, int P_1, LoadingValueReference P_2, CacheLoader P_3)
		{
			ListenableFuture listenableFuture = P_2.loadFuture(P_0, P_3);
			object andRecordStats = getAndRecordStats(P_0, P_1, P_2, listenableFuture);
			_ = null;
			return andRecordStats;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/LocalCache$LoadingValueReference<TK;TV;>;)Z")]
		[LineNumberTable(new byte[]
		{
			172, 172, 134, 105, 107, 141, 230, 85, 102, 102,
			233, 42, 104, 159, 2, 103, 104, 101, 104, 142,
			106, 137, 237, 72, 102, 102, 9, 102, 230, 55,
			131, 231, 70, 102, 102, 3, 102, 230, 57, 227,
			49, 235, 85, 102, 102, 230, 60, 135, 102, 102,
			3, 2
		})]
		internal virtual bool removeLoadingValue(object P_0, int P_1, LoadingValueReference P_2)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				int result;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					object key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						ValueReference valueReference = referenceEntry2.getValueReference();
						if (valueReference == P_2)
						{
							if (P_2.isActive())
							{
								referenceEntry2.setValueReference(P_2.getOldValue());
							}
							else
							{
								ReferenceEntry newValue = removeEntryFromChain(referenceEntry, referenceEntry2);
								atomicReferenceArray.set(i, newValue);
							}
							result = 1;
							goto IL_00ca;
						}
						goto IL_00d9;
					}
					goto IL_00fe;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_00ca:
				unlock();
				postWriteCleanup();
				return (byte)result != 0;
				IL_00d9:
				try
				{
					result = 0;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				unlock();
				postWriteCleanup();
				return (byte)result != 0;
				IL_00fe:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				return false;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;ILcom/google/common/cache/RemovalCause;)Z")]
		[LineNumberTable(new byte[]
		{
			172, 207, 107, 105, 107, 141, 104, 100, 110, 196,
			135, 107, 230, 58, 231, 72, 108, 105, 111, 226,
			49, 236, 83
		})]
		internal virtual bool removeEntry(ReferenceEntry P_0, int P_1, RemovalCause P_2)
		{
			_ = count - 1;
			AtomicReferenceArray atomicReferenceArray = table;
			int i = P_1 & (atomicReferenceArray.length() - 1);
			ReferenceEntry referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
			for (ReferenceEntry referenceEntry2 = referenceEntry; referenceEntry2 != null; referenceEntry2 = referenceEntry2.getNext())
			{
				if (referenceEntry2 == P_0)
				{
					modCount++;
					ReferenceEntry newValue = removeValueFromChain(referenceEntry, referenceEntry2, referenceEntry2.getKey(), P_1, referenceEntry2.getValueReference().get(), referenceEntry2.getValueReference(), P_2);
					int num = count - 1;
					atomicReferenceArray.set(i, newValue);
					count = num;
					System.Threading.Thread.MemoryBarrier();
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/LocalCache$LoadingValueReference<TK;TV;>;TV;)Z")]
		[LineNumberTable(new byte[]
		{
			171, 199, 134, 113, 135, 107, 105, 102, 171, 105,
			107, 142, 232, 102, 102, 102, 234, 25, 105, 159,
			3, 106, 105, 169, 152, 110, 136, 114, 114, 132,
			108, 110, 104, 237, 81, 102, 102, 12, 102, 230,
			46, 195, 112, 231, 76, 102, 102, 3, 102, 230,
			51, 227, 38, 237, 102, 102, 102, 230, 54, 110,
			108, 108, 105, 110, 104, 135, 102, 102, 3, 2
		})]
		internal virtual bool storeLoadedValue(object P_0, int P_1, LoadingValueReference P_2, object P_3)
		{
			@lock();
			long num;
			int num2;
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				num = map.ticker.read();
				preWriteCleanup(num);
				num2 = count + 1;
				if (num2 > threshold)
				{
					expand();
					num2 = count + 1;
				}
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				int result;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					object key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						ValueReference valueReference = referenceEntry2.getValueReference();
						object obj = valueReference.get();
						if (P_2 == valueReference || (obj == null && valueReference != UNSET))
						{
							modCount++;
							if (P_2.isActive())
							{
								RemovalCause removalCause = ((obj != null) ? RemovalCause.___003C_003EREPLACED : RemovalCause.___003C_003ECOLLECTED);
								enqueueNotification(P_0, P_1, obj, P_2.getWeight(), removalCause);
								num2 += -1;
							}
							setValue(referenceEntry2, P_0, P_3, num);
							count = num2;
							System.Threading.Thread.MemoryBarrier();
							evictEntries(referenceEntry2);
							result = 1;
							goto IL_0167;
						}
						goto IL_0176;
					}
					goto IL_01ab;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_0167:
				unlock();
				postWriteCleanup();
				return (byte)result != 0;
				IL_0176:
				try
				{
					enqueueNotification(P_0, P_1, P_3, 0, RemovalCause.___003C_003EREPLACED);
					result = 0;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				unlock();
				postWriteCleanup();
				return (byte)result != 0;
				IL_01ab:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				modCount++;
				referenceEntry2 = newEntry(P_0, P_1, referenceEntry);
				setValue(referenceEntry2, P_0, P_3, num);
				atomicReferenceArray.set(i, referenceEntry2);
				count = num2;
				System.Threading.Thread.MemoryBarrier();
				evictEntries(referenceEntry2);
				return true;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;IZ)Lcom/google/common/cache/LocalCache$LoadingValueReference<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			157, 59, 130, 98, 134, 113, 135, 105, 107, 174,
			232, 96, 102, 102, 234, 31, 105, 156, 167, 105,
			111, 211, 236, 83, 102, 102, 12, 102, 230, 44,
			194, 110, 137, 105, 232, 75, 102, 102, 3, 102,
			230, 52, 227, 43, 237, 96, 102, 102, 230, 55,
			110, 103, 108, 105, 105, 136, 102, 102, 3, 2
		})]
		internal virtual LoadingValueReference insertLoadingValueReference(object P_0, int P_1, bool P_2)
		{
			_ = null;
			@lock();
			long num;
			AtomicReferenceArray atomicReferenceArray;
			int i;
			ReferenceEntry referenceEntry;
			ReferenceEntry referenceEntry2;
			try
			{
				num = map.ticker.read();
				preWriteCleanup(num);
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				referenceEntry2 = referenceEntry;
			}
			catch
			{
				//try-fault
				unlock();
				postWriteCleanup();
				throw;
			}
			while (true)
			{
				ValueReference valueReference;
				try
				{
					if (referenceEntry2 == null)
					{
						break;
					}
					object key = referenceEntry2.getKey();
					if (referenceEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						valueReference = referenceEntry2.getValueReference();
						if (valueReference.isLoading() || (P_2 && num - referenceEntry2.getWriteTime() < map.refreshNanos))
						{
							_ = null;
							goto IL_00dd;
						}
						goto IL_00eb;
					}
					goto IL_0131;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				IL_00dd:
				unlock();
				postWriteCleanup();
				return null;
				IL_00eb:
				LoadingValueReference result;
				try
				{
					modCount++;
					LoadingValueReference loadingValueReference = new LoadingValueReference(valueReference);
					referenceEntry2.setValueReference(loadingValueReference);
					result = loadingValueReference;
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
				unlock();
				postWriteCleanup();
				return result;
				IL_0131:
				try
				{
					referenceEntry2 = referenceEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					postWriteCleanup();
					throw;
				}
			}
			try
			{
				modCount++;
				LoadingValueReference loadingValueReference2 = new LoadingValueReference();
				referenceEntry2 = newEntry(P_0, P_1, referenceEntry);
				referenceEntry2.setValueReference(loadingValueReference2);
				atomicReferenceArray.set(i, referenceEntry2);
				return loadingValueReference2;
			}
			finally
			{
				unlock();
				postWriteCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/LocalCache$LoadingValueReference<TK;TV;>;Lcom/google/common/cache/CacheLoader<-TK;TV;>;)Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
		[LineNumberTable(new byte[] { 168, 129, 106, 235, 76, 229, 52, 229, 77 })]
		internal virtual ListenableFuture loadAsync(object P_0, int P_1, LoadingValueReference P_2, CacheLoader P_3)
		{
			ListenableFuture listenableFuture = P_2.loadFuture(P_0, P_3);
			listenableFuture.addListener(new _1(this, P_0, P_1, P_2, listenableFuture), MoreExecutors.directExecutor());
			return listenableFuture;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 31, 109, 134, 109, 136 })]
		internal virtual void drainReferenceQueues()
		{
			if (map.usesKeyReferences())
			{
				drainKeyReferenceQueue();
			}
			if (map.usesValueReferences())
			{
				drainValueReferenceQueue();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 42, 98, 143, 103, 108, 105, 130, 98 })]
		internal virtual void drainKeyReferenceQueue()
		{
			int num = 0;
			Reference reference;
			while ((reference = keyReferenceQueue.poll()) != null)
			{
				ReferenceEntry referenceEntry = (ReferenceEntry)reference;
				map.reclaimKey(referenceEntry);
				num++;
				if (num == 16)
				{
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 56, 98, 143, 103, 108, 105, 130, 98 })]
		internal virtual void drainValueReferenceQueue()
		{
			int num = 0;
			Reference reference;
			while ((reference = valueReferenceQueue.poll()) != null)
			{
				ValueReference valueReference = (ValueReference)reference;
				map.reclaimValue(valueReference);
				num++;
				if (num == 16)
				{
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 78, 111 })]
		internal virtual void clearKeyReferenceQueue()
		{
			while (keyReferenceQueue.poll() != null)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 82, 111 })]
		internal virtual void clearValueReferenceQueue()
		{
			while (valueReferenceQueue.poll() != null)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 145, 244, 69, 110, 175 })]
		internal virtual void drainRecencyQueue()
		{
			ReferenceEntry referenceEntry;
			while ((referenceEntry = (ReferenceEntry)recencyQueue.poll()) != null)
			{
				if (accessQueue.contains(referenceEntry))
				{
					accessQueue.add(referenceEntry);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			169, 172, 166, 127, 4, 116, 171, 127, 4, 116,
			171
		})]
		internal virtual void expireEntries(long P_0)
		{
			drainRecencyQueue();
			ReferenceEntry referenceEntry;
			while ((referenceEntry = (ReferenceEntry)writeQueue.peek()) != null && map.isExpired(referenceEntry, P_0))
			{
				if (!removeEntry(referenceEntry, referenceEntry.getHash(), RemovalCause.___003C_003EEXPIRED))
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new AssertionError();
				}
			}
			while ((referenceEntry = (ReferenceEntry)accessQueue.peek()) != null && map.isExpired(referenceEntry, P_0))
			{
				if (!removeEntry(referenceEntry, referenceEntry.getHash(), RemovalCause.___003C_003EEXPIRED))
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new AssertionError();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 169, 235, 127, 1, 108, 100, 130, 98 })]
		internal virtual ReferenceEntry getNextEvictable()
		{
			Iterator iterator = accessQueue.iterator();
			while (iterator.hasNext())
			{
				ReferenceEntry referenceEntry = (ReferenceEntry)iterator.next();
				int weight = referenceEntry.getValueReference().getWeight();
				if (weight > 0)
				{
					return referenceEntry;
				}
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 169, 247, 105 })]
		internal virtual ReferenceEntry getFirst(int P_0)
		{
			AtomicReferenceArray atomicReferenceArray = table;
			return (ReferenceEntry)atomicReferenceArray.get(P_0 & (atomicReferenceArray.length() - 1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 160, 136, 139, 134, 3, 130, 130 })]
		internal virtual void tryExpireEntries(long P_0)
		{
			if (tryLock())
			{
				try
				{
					expireEntries(P_0);
				}
				finally
				{
					unlock();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			170, 177, 105, 103, 104, 225, 77, 105, 106, 112,
			106, 171, 143, 103, 105, 172, 100, 239, 69, 100,
			100, 104, 108, 134, 100, 228, 59, 235, 72, 170,
			109, 108, 111, 108, 100, 140, 104, 228, 56, 238,
			35, 235, 107, 105, 110
		})]
		internal virtual void expand()
		{
			AtomicReferenceArray atomicReferenceArray = table;
			int num = atomicReferenceArray.length();
			if (num >= 1073741824)
			{
				return;
			}
			int num2 = count;
			AtomicReferenceArray atomicReferenceArray2 = newEntryArray(num << 1);
			threshold = atomicReferenceArray2.length() * 3 / 4;
			int num3 = atomicReferenceArray2.length() - 1;
			for (int i = 0; i < num; i++)
			{
				ReferenceEntry referenceEntry = (ReferenceEntry)atomicReferenceArray.get(i);
				if (referenceEntry == null)
				{
					continue;
				}
				ReferenceEntry next = referenceEntry.getNext();
				int num4 = referenceEntry.getHash() & num3;
				if (next == null)
				{
					atomicReferenceArray2.set(num4, referenceEntry);
					continue;
				}
				ReferenceEntry referenceEntry2 = referenceEntry;
				int num5 = num4;
				for (ReferenceEntry referenceEntry3 = next; referenceEntry3 != null; referenceEntry3 = referenceEntry3.getNext())
				{
					int num6 = referenceEntry3.getHash() & num3;
					if (num6 != num5)
					{
						num5 = num6;
						referenceEntry2 = referenceEntry3;
					}
				}
				atomicReferenceArray2.set(num5, referenceEntry2);
				for (ReferenceEntry referenceEntry3 = referenceEntry; referenceEntry3 != referenceEntry2; referenceEntry3 = referenceEntry3.getNext())
				{
					int num6 = referenceEntry3.getHash() & num3;
					ReferenceEntry referenceEntry4 = (ReferenceEntry)atomicReferenceArray2.get(num6);
					ReferenceEntry referenceEntry5 = copyEntry(referenceEntry3, referenceEntry4);
					if (referenceEntry5 != null)
					{
						atomicReferenceArray2.set(num6, referenceEntry5);
					}
					else
					{
						removeCollectedEntry(referenceEntry3);
						num2 += -1;
					}
				}
			}
			table = atomicReferenceArray2;
			count = num2;
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TK;TV;J)V")]
		[LineNumberTable(new byte[] { 167, 107, 103, 115, 145, 111, 102, 103, 106, 105 })]
		internal virtual void setValue(ReferenceEntry P_0, object P_1, object P_2, long P_3)
		{
			ValueReference valueReference = P_0.getValueReference();
			int num = map.weigher.weigh(P_1, P_2);
			Preconditions.checkState(num >= 0, (object)"Weights must be non-negative");
			ValueReference valueReference2 = map.valueStrength.referenceValue(this, P_0, P_2, num);
			P_0.setValueReference(valueReference2);
			recordWrite(P_0, num, P_3);
			valueReference.notifyNewValue(P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[]
		{
			169, 210, 109, 161, 198, 116, 116, 203, 110, 103,
			116, 139, 98
		})]
		internal virtual void evictEntries(ReferenceEntry P_0)
		{
			if (!map.evictsBySize())
			{
				return;
			}
			drainRecencyQueue();
			if (P_0.getValueReference().getWeight() > maxSegmentWeight && !removeEntry(P_0, P_0.getHash(), RemovalCause.___003C_003ESIZE))
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
			while (totalWeight > maxSegmentWeight)
			{
				ReferenceEntry nextEvictable = getNextEvictable();
				if (!removeEntry(nextEvictable, nextEvictable.getHash(), RemovalCause.___003C_003ESIZE))
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new AssertionError();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[]
		{
			172, 82, 98, 102, 102, 107, 239, 60, 229, 70,
			109, 109
		})]
		internal virtual void removeCollectedEntry(ReferenceEntry P_0)
		{
			enqueueNotification(P_0.getKey(), P_0.getHash(), P_0.getValueReference().get(), P_0.getValueReference().getWeight(), RemovalCause.___003C_003ECOLLECTED);
			writeQueue.remove(P_0);
			accessQueue.remove(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TK;ITV;Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;Lcom/google/common/cache/RemovalCause;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 0, 0, 228, 0, 0, 22, 2,
			0, 0, 228, 0, 0
		})]
		[LineNumberTable(new byte[] { 172, 49, 116, 109, 141, 105, 104, 130 })]
		internal virtual ReferenceEntry removeValueFromChain(ReferenceEntry P_0, ReferenceEntry P_1, object P_2, int P_3, object P_4, ValueReference P_5, RemovalCause P_6)
		{
			enqueueNotification(P_2, P_3, P_4, P_5.getWeight(), P_6);
			writeQueue.remove(P_1);
			accessQueue.remove(P_1);
			if (P_5.isLoading())
			{
				P_5.notifyNewValue(null);
				return P_0;
			}
			ReferenceEntry result = removeEntryFromChain(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 69, 109, 134, 109, 136 })]
		internal virtual void clearReferenceQueues()
		{
			if (map.usesKeyReferences())
			{
				clearKeyReferenceQueue();
			}
			if (map.usesValueReferences())
			{
				clearValueReferenceQueue();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 228, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			172, 65, 105, 103, 102, 105, 99, 132, 103, 228,
			58, 233, 73, 110
		})]
		internal virtual ReferenceEntry removeEntryFromChain(ReferenceEntry P_0, ReferenceEntry P_1)
		{
			int num = count;
			ReferenceEntry referenceEntry = P_1.getNext();
			for (ReferenceEntry referenceEntry2 = P_0; referenceEntry2 != P_1; referenceEntry2 = referenceEntry2.getNext())
			{
				ReferenceEntry referenceEntry3 = copyEntry(referenceEntry2, referenceEntry);
				if (referenceEntry3 != null)
				{
					referenceEntry = referenceEntry3;
				}
				else
				{
					removeCollectedEntry(referenceEntry2);
					num += -1;
				}
			}
			count = num;
			System.Threading.Thread.MemoryBarrier();
			return referenceEntry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 173, 11, 136, 102, 103, 144, 102, 35, 98, 130 })]
		internal virtual void runLockedCleanup(long P_0)
		{
			if (tryLock())
			{
				try
				{
					drainReferenceQueues();
					expireEntries(P_0);
					readCount.set(0);
				}
				finally
				{
					unlock();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 173, 24, 104, 141 })]
		internal virtual void runUnlockedCleanup()
		{
			if (!isHeldByCurrentThread())
			{
				map.processPendingNotifications();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			170, 76, 106, 113, 105, 103, 232, 79, 102, 236,
			49, 244, 78, 102, 236, 50, 107, 100, 130, 117,
			235, 72, 102, 39, 230, 56, 227, 58, 237, 78,
			102, 230, 48, 232, 79, 102, 230, 61, 135, 102,
			35, 2
		})]
		internal virtual bool containsValue(object P_0)
		{
			long num;
			AtomicReferenceArray atomicReferenceArray;
			int num2;
			int num3;
			try
			{
				if (count != 0)
				{
					num = map.ticker.read();
					atomicReferenceArray = table;
					num2 = atomicReferenceArray.length();
					num3 = 0;
					goto IL_0041;
				}
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			goto IL_00df;
			IL_0041:
			while (true)
			{
				ReferenceEntry referenceEntry;
				try
				{
					if (num3 < num2)
					{
						referenceEntry = (ReferenceEntry)atomicReferenceArray.get(num3);
						goto IL_0067;
					}
				}
				catch
				{
					//try-fault
					postReadCleanup();
					throw;
				}
				break;
				IL_0067:
				while (true)
				{
					int result;
					try
					{
						if (referenceEntry != null)
						{
							object liveValue = getLiveValue(referenceEntry, num);
							if (liveValue == null || !map.valueEquivalence.equivalent(P_0, liveValue))
							{
								goto IL_00b2;
							}
							result = 1;
							goto IL_00a9;
						}
					}
					catch
					{
						//try-fault
						postReadCleanup();
						throw;
					}
					break;
					IL_00a9:
					postReadCleanup();
					return (byte)result != 0;
					IL_00b2:
					try
					{
						referenceEntry = referenceEntry.getNext();
					}
					catch
					{
						//try-fault
						postReadCleanup();
						throw;
					}
				}
				try
				{
					num3++;
				}
				catch
				{
					//try-fault
					postReadCleanup();
					throw;
				}
			}
			goto IL_00df;
			IL_00df:
			try
			{
				return false;
			}
			finally
			{
				postReadCleanup();
			}
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Segment(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/ref/SoftReference<TV;>;Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
	[Implements(new string[] { "com.google.common.cache.LocalCache$ValueReference" })]
	internal class SoftValueReference : SoftReference, ValueReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry entry;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 165, 105, 106, 103 })]
		internal SoftValueReference(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
			: base(P_1, P_0)
		{
			entry = P_2;
		}

		public virtual int getWeight()
		{
			return 1;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public virtual ReferenceEntry getEntry()
		{
			return entry;
		}

		[Signature("(TV;)V")]
		public virtual void notifyNewValue(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		[LineNumberTable(1519)]
		public virtual ValueReference copyFor(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
		{
			SoftValueReference result = new SoftValueReference(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		public virtual bool isLoading()
		{
			return false;
		}

		public virtual bool isActive()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(1534)]
		public virtual object waitForValue()
		{
			object result = get();
			_ = null;
			return result;
		}

		object ValueReference.LocalCache_0024ValueReference_003A_003Aget()
		{
			return get();
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/cache/LocalCache$Strength;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	internal abstract class Strength : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : Strength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(385)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TV;I)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 19, 101, 104, 10 })]
			internal override ValueReference referenceValue(Segment P_0, ReferenceEntry P_1, object P_2, int P_3)
			{
				StrongValueReference result = ((P_3 != 1) ? new WeightedStrongValueReference(P_2, P_3) : new StrongValueReference(P_2));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
			[LineNumberTable(396)]
			internal override Equivalence defaultEquivalence()
			{
				Equivalence result = Equivalence.equals();
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				Strength.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : Strength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(399)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TV;I)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 33, 101, 111, 17 })]
			internal override ValueReference referenceValue(Segment P_0, ReferenceEntry P_1, object P_2, int P_3)
			{
				SoftValueReference result = ((P_3 != 1) ? new WeightedSoftValueReference(P_0.valueReferenceQueue, P_2, P_1, P_3) : new SoftValueReference(P_0.valueReferenceQueue, P_2, P_1));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
			[LineNumberTable(411)]
			internal override Equivalence defaultEquivalence()
			{
				Equivalence result = Equivalence.identity();
				_ = null;
				return result;
			}

			[HideFromJava]
			static _2()
			{
				Strength.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _3 : Strength
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(414)]
			internal _3(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TV;I)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 48, 101, 111, 17 })]
			internal override ValueReference referenceValue(Segment P_0, ReferenceEntry P_1, object P_2, int P_3)
			{
				WeakValueReference result = ((P_3 != 1) ? new WeightedWeakValueReference(P_0.valueReferenceQueue, P_2, P_1, P_3) : new WeakValueReference(P_0.valueReferenceQueue, P_2, P_1));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
			[LineNumberTable(426)]
			internal override Equivalence defaultEquivalence()
			{
				Equivalence result = Equivalence.identity();
				_ = null;
				return result;
			}

			[HideFromJava]
			static _3()
			{
				Strength.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Strength STRONG;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Strength SOFT;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Strength WEAK;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Strength[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
		internal abstract Equivalence defaultEquivalence();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(379)]
		public static Strength[] values()
		{
			return (Strength[])_0024VALUES.Clone();
		}

		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TV;I)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		internal abstract ValueReference referenceValue(Segment P_0, ReferenceEntry P_1, object P_2, int P_3);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(379)]
		private Strength(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(379)]
		private static Strength[] _0024values()
		{
			return new Strength[3] { STRONG, SOFT, WEAK };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(379)]
		public static Strength valueOf(string P_0)
		{
			return (Strength)java.lang.Enum.valueOf(ClassLiteral<Strength>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(379)]
		internal Strength(string P_0, int P_1, LocalCache._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 161, 15, 240, 78, 240, 79, 240, 29 })]
		static Strength()
		{
			STRONG = new _1("STRONG", 0);
			SOFT = new _2("SOFT", 1);
			WEAK = new _3("WEAK", 2);
			_0024VALUES = _0024values();
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$StrongEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)39,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class StrongAccessEntry : StrongEntry
	{
		internal volatile long accessTime;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry nextAccess;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry previousAccess;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 39, 0, 0 })]
		[LineNumberTable(new byte[] { 163, 104, 235, 69, 246, 77, 235, 77, 235, 34 })]
		internal StrongAccessEntry(object P_0, int P_1, ReferenceEntry P_2)
			: base(P_0, P_1, P_2)
		{
			long newValue = long.MaxValue;
			ByteCodeHelper.VolatileWrite(ref accessTime, newValue);
			nextAccess = nullEntry();
			previousAccess = nullEntry();
		}

		public override long getAccessTime()
		{
			return ByteCodeHelper.VolatileRead(ref accessTime);
		}

		public override void setAccessTime(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref accessTime, P_0);
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNextInAccessQueue()
		{
			return nextAccess;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setNextInAccessQueue(ReferenceEntry P_0)
		{
			nextAccess = P_0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getPreviousInAccessQueue()
		{
			return previousAccess;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setPreviousInAccessQueue(ReferenceEntry P_0)
		{
			previousAccess = P_0;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$StrongEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class StrongAccessWriteEntry : StrongEntry
	{
		internal volatile long accessTime;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry nextAccess;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry previousAccess;

		internal volatile long writeTime;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry nextWrite;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry previousWrite;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 45, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			163, 196, 235, 69, 246, 77, 235, 77, 235, 78,
			246, 77, 235, 77, 235, 159, 186
		})]
		internal StrongAccessWriteEntry(object P_0, int P_1, ReferenceEntry P_2)
			: base(P_0, P_1, P_2)
		{
			long newValue = long.MaxValue;
			ByteCodeHelper.VolatileWrite(ref accessTime, newValue);
			nextAccess = nullEntry();
			previousAccess = nullEntry();
			long newValue2 = long.MaxValue;
			ByteCodeHelper.VolatileWrite(ref writeTime, newValue2);
			nextWrite = nullEntry();
			previousWrite = nullEntry();
		}

		public override long getAccessTime()
		{
			return ByteCodeHelper.VolatileRead(ref accessTime);
		}

		public override void setAccessTime(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref accessTime, P_0);
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNextInAccessQueue()
		{
			return nextAccess;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setNextInAccessQueue(ReferenceEntry P_0)
		{
			nextAccess = P_0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getPreviousInAccessQueue()
		{
			return previousAccess;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setPreviousInAccessQueue(ReferenceEntry P_0)
		{
			previousAccess = P_0;
		}

		public override long getWriteTime()
		{
			return ByteCodeHelper.VolatileRead(ref writeTime);
		}

		public override void setWriteTime(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref writeTime, P_0);
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNextInWriteQueue()
		{
			return nextWrite;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setNextInWriteQueue(ReferenceEntry P_0)
		{
			nextWrite = P_0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getPreviousInWriteQueue()
		{
			return previousWrite;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setPreviousInWriteQueue(ReferenceEntry P_0)
		{
			previousWrite = P_0;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$AbstractReferenceEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)19,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class StrongEntry : AbstractReferenceEntry
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		internal object key;

		[Modifiers(Modifiers.Final)]
		internal int hash;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 19, 0, 0 })]
		internal ReferenceEntry next;

		[Signature("Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		internal volatile ValueReference valueReference;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 19, 0, 0 })]
		[LineNumberTable(new byte[] { 163, 64, 232, 79, 242, 50, 103, 103, 103 })]
		internal StrongEntry(object P_0, int P_1, ReferenceEntry P_2)
		{
			valueReference = unset();
			System.Threading.Thread.MemoryBarrier();
			key = P_0;
			hash = P_1;
			next = P_2;
		}

		[Signature("()TK;")]
		public override object getKey()
		{
			return key;
		}

		[Signature("()Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		public override ValueReference getValueReference()
		{
			return valueReference;
		}

		[Signature("(Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)V")]
		public override void setValueReference(ValueReference P_0)
		{
			valueReference = P_0;
			System.Threading.Thread.MemoryBarrier();
		}

		public override int getHash()
		{
			return hash;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNext()
		{
			return next;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
	internal class StrongValueReference : java.lang.Object, ValueReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TV;")]
		internal object referent;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)V")]
		[LineNumberTable(new byte[] { 165, 148, 104, 103 })]
		internal StrongValueReference(object P_0)
		{
			referent = P_0;
		}

		[Signature("()TV;")]
		public virtual object get()
		{
			return referent;
		}

		public virtual int getWeight()
		{
			return 1;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public virtual ReferenceEntry getEntry()
		{
			return null;
		}

		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		public virtual ValueReference copyFor(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
		{
			return this;
		}

		public virtual bool isLoading()
		{
			return false;
		}

		public virtual bool isActive()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(1579)]
		public virtual object waitForValue()
		{
			object result = get();
			_ = null;
			return result;
		}

		[Signature("(TV;)V")]
		public virtual void notifyNewValue(object P_0)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$StrongEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)39,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class StrongWriteEntry : StrongEntry
	{
		internal volatile long writeTime;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry nextWrite;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry previousWrite;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 39, 0, 0 })]
		[LineNumberTable(new byte[] { 163, 150, 235, 69, 246, 77, 235, 77, 235, 34 })]
		internal StrongWriteEntry(object P_0, int P_1, ReferenceEntry P_2)
			: base(P_0, P_1, P_2)
		{
			long newValue = long.MaxValue;
			ByteCodeHelper.VolatileWrite(ref writeTime, newValue);
			nextWrite = nullEntry();
			previousWrite = nullEntry();
		}

		public override long getWriteTime()
		{
			return ByteCodeHelper.VolatileRead(ref writeTime);
		}

		public override void setWriteTime(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref writeTime, P_0);
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNextInWriteQueue()
		{
			return nextWrite;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setNextInWriteQueue(ReferenceEntry P_0)
		{
			nextWrite = P_0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getPreviousInWriteQueue()
		{
			return previousWrite;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setPreviousInWriteQueue(ReferenceEntry P_0)
		{
			previousWrite = P_0;
		}
	}

	[InnerClass(null, Modifiers.Final)]
	[Signature("Lcom/google/common/cache/LocalCache<TK;TV;>.HashIterator<TV;>;")]
	internal sealed class ValueIterator : HashIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4443)]
		internal ValueIterator(LocalCache P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(4447)]
		public override object next()
		{
			object value = base.nextEntry().getValue();
			_ = null;
			return value;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[ConstantPool(new object[]
	{
		(byte)8,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal interface ValueReference
	{
		[Signature("()TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 8, 0, 0 })]
		virtual object get();

		[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
		[Signature("()TV;")]
		virtual object waitForValue();

		virtual int getWeight();

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 8, 0, 0 })]
		virtual ReferenceEntry getEntry();

		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 1, 0, 0, 8, 0, 0 })]
		virtual ValueReference copyFor(ReferenceQueue P_0, object P_1, ReferenceEntry P_2);

		[Signature("(TV;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 8, 0, 0 })]
		virtual void notifyNewValue(object P_0);

		virtual bool isLoading();

		virtual bool isActive();
	}

	[Signature("Ljava/util/AbstractCollection<TV;>;")]
	internal sealed class Values : AbstractCollection
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiPredicate
		{
			private readonly java.util.function.Predicate arg_00241;

			internal ___003C_003EAnon0(java.util.function.Predicate P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0, object P_1)
			{
				bool result = lambda_0024removeIf_00240(arg_00241, P_0, P_1);
				_ = null;
				return result;
			}

			[SpecialName]
			public BiPredicate and(BiPredicate P_0)
			{
				return BiPredicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public BiPredicate negate()
			{
				return BiPredicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public BiPredicate or(BiPredicate P_0)
			{
				return BiPredicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LocalCache this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4583)]
		internal Values(LocalCache P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(4607)]
		private static bool lambda_0024removeIf_00240(java.util.function.Predicate P_0, object P_1, object P_2)
		{
			bool result = P_0.test(P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4586)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4591)]
		public override bool isEmpty()
		{
			bool result = this_00240.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 177, 130, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(4601)]
		public override Iterator iterator()
		{
			ValueIterator result = new ValueIterator(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Predicate<-TV;>;)Z")]
		[LineNumberTable(new byte[] { 177, 140, 103 })]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			Preconditions.checkNotNull(P_0);
			bool result = this_00240.removeIf(new ___003C_003EAnon0(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4612)]
		public override bool contains(object P_0)
		{
			bool result = this_00240.containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4620)]
		public override object[] toArray()
		{
			object[] result = access_0024200(this).toArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<E:Ljava/lang/Object;>([TE;)[TE;")]
		[LineNumberTable(4625)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = access_0024200(this).toArray(P_0);
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$WeakEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)42,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class WeakAccessEntry : WeakEntry
	{
		internal volatile long accessTime;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry nextAccess;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry previousAccess;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 42, 0, 0 })]
		[LineNumberTable(new byte[] { 164, 135, 237, 69, 246, 77, 235, 77, 235, 34 })]
		internal WeakAccessEntry(ReferenceQueue P_0, object P_1, int P_2, ReferenceEntry P_3)
			: base(P_0, P_1, P_2, P_3)
		{
			long newValue = long.MaxValue;
			ByteCodeHelper.VolatileWrite(ref accessTime, newValue);
			nextAccess = nullEntry();
			previousAccess = nullEntry();
		}

		public override long getAccessTime()
		{
			return ByteCodeHelper.VolatileRead(ref accessTime);
		}

		public override void setAccessTime(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref accessTime, P_0);
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNextInAccessQueue()
		{
			return nextAccess;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setNextInAccessQueue(ReferenceEntry P_0)
		{
			nextAccess = P_0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getPreviousInAccessQueue()
		{
			return previousAccess;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setPreviousInAccessQueue(ReferenceEntry P_0)
		{
			previousAccess = P_0;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$WeakEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)48,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class WeakAccessWriteEntry : WeakEntry
	{
		internal volatile long accessTime;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry nextAccess;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry previousAccess;

		internal volatile long writeTime;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry nextWrite;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry previousWrite;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 48, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			164, 228, 237, 69, 246, 77, 235, 77, 235, 78,
			246, 77, 235, 77, 235, 159, 186
		})]
		internal WeakAccessWriteEntry(ReferenceQueue P_0, object P_1, int P_2, ReferenceEntry P_3)
			: base(P_0, P_1, P_2, P_3)
		{
			long newValue = long.MaxValue;
			ByteCodeHelper.VolatileWrite(ref accessTime, newValue);
			nextAccess = nullEntry();
			previousAccess = nullEntry();
			long newValue2 = long.MaxValue;
			ByteCodeHelper.VolatileWrite(ref writeTime, newValue2);
			nextWrite = nullEntry();
			previousWrite = nullEntry();
		}

		public override long getAccessTime()
		{
			return ByteCodeHelper.VolatileRead(ref accessTime);
		}

		public override void setAccessTime(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref accessTime, P_0);
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNextInAccessQueue()
		{
			return nextAccess;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setNextInAccessQueue(ReferenceEntry P_0)
		{
			nextAccess = P_0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getPreviousInAccessQueue()
		{
			return previousAccess;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setPreviousInAccessQueue(ReferenceEntry P_0)
		{
			previousAccess = P_0;
		}

		public override long getWriteTime()
		{
			return ByteCodeHelper.VolatileRead(ref writeTime);
		}

		public override void setWriteTime(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref writeTime, P_0);
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNextInWriteQueue()
		{
			return nextWrite;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setNextInWriteQueue(ReferenceEntry P_0)
		{
			nextWrite = P_0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getPreviousInWriteQueue()
		{
			return previousWrite;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setPreviousInWriteQueue(ReferenceEntry P_0)
		{
			previousWrite = P_0;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/ref/WeakReference<TK;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)19,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.cache.ReferenceEntry" })]
	internal class WeakEntry : java.lang.@ref.WeakReference, ReferenceEntry
	{
		[Modifiers(Modifiers.Final)]
		internal int hash;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 19, 0, 0 })]
		internal ReferenceEntry next;

		[Signature("Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		internal volatile ValueReference valueReference;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 19, 0, 0 })]
		[LineNumberTable(new byte[] { 164, 27, 234, 160, 83, 242, 159, 174, 103, 104 })]
		internal WeakEntry(ReferenceQueue P_0, object P_1, int P_2, ReferenceEntry P_3)
			: base(P_1, P_0)
		{
			valueReference = unset();
			System.Threading.Thread.MemoryBarrier();
			hash = P_2;
			next = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1172)]
		public virtual object getKey()
		{
			object result = get();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1184)]
		public virtual long getAccessTime()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1189)]
		public virtual void setAccessTime(long P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(1194)]
		public virtual ReferenceEntry getNextInAccessQueue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(1199)]
		public virtual void setNextInAccessQueue(ReferenceEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(1204)]
		public virtual ReferenceEntry getPreviousInAccessQueue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(1209)]
		public virtual void setPreviousInAccessQueue(ReferenceEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1216)]
		public virtual long getWriteTime()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1221)]
		public virtual void setWriteTime(long P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(1226)]
		public virtual ReferenceEntry getNextInWriteQueue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(1231)]
		public virtual void setNextInWriteQueue(ReferenceEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(1236)]
		public virtual ReferenceEntry getPreviousInWriteQueue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(1241)]
		public virtual void setPreviousInWriteQueue(ReferenceEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[Signature("()Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		public virtual ValueReference getValueReference()
		{
			return valueReference;
		}

		[Signature("(Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)V")]
		public virtual void setValueReference(ValueReference P_0)
		{
			valueReference = P_0;
			System.Threading.Thread.MemoryBarrier();
		}

		public virtual int getHash()
		{
			return hash;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public virtual ReferenceEntry getNext()
		{
			return next;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/ref/WeakReference<TV;>;Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
	[Implements(new string[] { "com.google.common.cache.LocalCache$ValueReference" })]
	internal class WeakValueReference : java.lang.@ref.WeakReference, ValueReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry entry;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 165, 61, 106, 103 })]
		internal WeakValueReference(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
			: base(P_1, P_0)
		{
			entry = P_2;
		}

		public virtual int getWeight()
		{
			return 1;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public virtual ReferenceEntry getEntry()
		{
			return entry;
		}

		[Signature("(TV;)V")]
		public virtual void notifyNewValue(object P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		[LineNumberTable(1475)]
		public virtual ValueReference copyFor(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
		{
			WeakValueReference result = new WeakValueReference(P_0, P_1, P_2);
			_ = null;
			return result;
		}

		public virtual bool isLoading()
		{
			return false;
		}

		public virtual bool isActive()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(1490)]
		public virtual object waitForValue()
		{
			object result = get();
			_ = null;
			return result;
		}

		object ValueReference.LocalCache_0024ValueReference_003A_003Aget()
		{
			return get();
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$WeakEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)42,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class WeakWriteEntry : WeakEntry
	{
		internal volatile long writeTime;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry nextWrite;

		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry previousWrite;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 42, 0, 0 })]
		[LineNumberTable(new byte[] { 164, 181, 237, 69, 246, 77, 235, 77, 235, 34 })]
		internal WeakWriteEntry(ReferenceQueue P_0, object P_1, int P_2, ReferenceEntry P_3)
			: base(P_0, P_1, P_2, P_3)
		{
			long newValue = long.MaxValue;
			ByteCodeHelper.VolatileWrite(ref writeTime, newValue);
			nextWrite = nullEntry();
			previousWrite = nullEntry();
		}

		public override long getWriteTime()
		{
			return ByteCodeHelper.VolatileRead(ref writeTime);
		}

		public override void setWriteTime(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref writeTime, P_0);
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getNextInWriteQueue()
		{
			return nextWrite;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setNextInWriteQueue(ReferenceEntry P_0)
		{
			nextWrite = P_0;
		}

		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		public override ReferenceEntry getPreviousInWriteQueue()
		{
			return previousWrite;
		}

		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
		public override void setPreviousInWriteQueue(ReferenceEntry P_0)
		{
			previousWrite = P_0;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$SoftValueReference<TK;TV;>;")]
	internal sealed class WeightedSoftValueReference : SoftValueReference
	{
		[Modifiers(Modifiers.Final)]
		internal int weight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;I)V")]
		[LineNumberTable(new byte[] { 165, 220, 107, 104 })]
		internal WeightedSoftValueReference(ReferenceQueue P_0, object P_1, ReferenceEntry P_2, int P_3)
			: base(P_0, P_1, P_2)
		{
			weight = P_3;
		}

		public override int getWeight()
		{
			return weight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		[LineNumberTable(1626)]
		public override ValueReference copyFor(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
		{
			WeightedSoftValueReference result = new WeightedSoftValueReference(P_0, P_1, P_2, weight);
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$StrongValueReference<TK;TV;>;")]
	internal sealed class WeightedStrongValueReference : StrongValueReference
	{
		[Modifiers(Modifiers.Final)]
		internal int weight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;I)V")]
		[LineNumberTable(new byte[] { 165, 241, 105, 103 })]
		internal WeightedStrongValueReference(object P_0, int P_1)
			: base(P_0)
		{
			weight = P_1;
		}

		public override int getWeight()
		{
			return weight;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/LocalCache$WeakValueReference<TK;TV;>;")]
	internal sealed class WeightedWeakValueReference : WeakValueReference
	{
		[Modifiers(Modifiers.Final)]
		internal int weight;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;I)V")]
		[LineNumberTable(new byte[] { 165, 198, 107, 104 })]
		internal WeightedWeakValueReference(ReferenceQueue P_0, object P_1, ReferenceEntry P_2, int P_3)
			: base(P_0, P_1, P_2)
		{
			weight = P_3;
		}

		public override int getWeight()
		{
			return weight;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
		[LineNumberTable(1604)]
		public override ValueReference copyFor(ReferenceQueue P_0, object P_1, ReferenceEntry P_2)
		{
			WeightedWeakValueReference result = new WeightedWeakValueReference(P_0, P_1, P_2, weight);
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractQueue<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
	internal sealed class WriteQueue : AbstractQueue
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/cache/LocalCache$AbstractReferenceEntry<TK;TV;>;")]
		[EnclosingMethod(null, null, null)]
		internal class _1 : AbstractReferenceEntry
		{
			[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			internal ReferenceEntry nextWrite;

			[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			internal ReferenceEntry previousWrite;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 173, 194, 232, 74, 231, 76 })]
			internal _1(WriteQueue P_0)
			{
				nextWrite = this;
				previousWrite = this;
			}

			public override long getWriteTime()
			{
				return long.MaxValue;
			}

			public override void setWriteTime(long P_0)
			{
			}

			[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			public override ReferenceEntry getNextInWriteQueue()
			{
				return nextWrite;
			}

			[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
			public override void setNextInWriteQueue(ReferenceEntry P_0)
			{
				nextWrite = P_0;
			}

			[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			public override ReferenceEntry getPreviousInWriteQueue()
			{
				return previousWrite;
			}

			[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
			public override void setPreviousInWriteQueue(ReferenceEntry P_0)
			{
				previousWrite = P_0;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractSequentialIterator<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _2 : AbstractSequentialIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal WriteQueue this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(3752)]
			internal _2(WriteQueue P_0, ReferenceEntry P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 174, 57, 103 })]
			protected internal virtual ReferenceEntry computeNext(ReferenceEntry P_0)
			{
				ReferenceEntry nextInWriteQueue = P_0.getNextInWriteQueue();
				return (nextInWriteQueue != this_00240.head) ? nextInWriteQueue : null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(3752)]
			protected internal override object computeNext(object P_0)
			{
				ReferenceEntry result = computeNext((ReferenceEntry)P_0);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		internal ReferenceEntry head;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 173, 192, 104 })]
		internal WriteQueue()
		{
			head = new _1(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 7, 103, 103, 103, 103, 134 })]
		public override bool remove(object P_0)
		{
			ReferenceEntry referenceEntry = (ReferenceEntry)P_0;
			ReferenceEntry previousInWriteQueue = referenceEntry.getPreviousInWriteQueue();
			ReferenceEntry nextInWriteQueue = referenceEntry.getNextInWriteQueue();
			connectWriteOrder(previousInWriteQueue, nextInWriteQueue);
			nullifyWriteOrder(referenceEntry);
			return nextInWriteQueue != NullEntry.INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 173, 245, 108 })]
		public new virtual ReferenceEntry peek()
		{
			ReferenceEntry nextInWriteQueue = head.getNextInWriteQueue();
			return (nextInWriteQueue != head) ? nextInWriteQueue : null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 173, 251, 108, 105, 162, 104 })]
		public new virtual ReferenceEntry poll()
		{
			ReferenceEntry nextInWriteQueue = head.getNextInWriteQueue();
			if (nextInWriteQueue == head)
			{
				return null;
			}
			remove(nextInWriteQueue);
			return nextInWriteQueue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Z")]
		[LineNumberTable(new byte[] { 173, 234, 177, 113, 140 })]
		public virtual bool offer(ReferenceEntry P_0)
		{
			connectWriteOrder(P_0.getPreviousInWriteQueue(), P_0.getNextInWriteQueue());
			connectWriteOrder(head.getPreviousInWriteQueue(), P_0);
			connectWriteOrder(P_0, head);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 19, 103 })]
		public override bool contains(object P_0)
		{
			ReferenceEntry referenceEntry = (ReferenceEntry)P_0;
			return referenceEntry.getNextInWriteQueue() != NullEntry.INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3723)]
		public override bool isEmpty()
		{
			return head.getNextInWriteQueue() == head;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 30, 98, 108, 137, 36, 169 })]
		public override int size()
		{
			int num = 0;
			for (ReferenceEntry nextInWriteQueue = head.getNextInWriteQueue(); nextInWriteQueue != head; nextInWriteQueue = nextInWriteQueue.getNextInWriteQueue())
			{
				num++;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 41, 108, 105, 103, 102, 98, 130, 113, 115 })]
		public override void clear()
		{
			ReferenceEntry referenceEntry = head.getNextInWriteQueue();
			while (referenceEntry != head)
			{
				ReferenceEntry nextInWriteQueue = referenceEntry.getNextInWriteQueue();
				nullifyWriteOrder(referenceEntry);
				referenceEntry = nextInWriteQueue;
			}
			head.setNextInWriteQueue(head);
			head.setPreviousInWriteQueue(head);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/cache/ReferenceEntry<TK;TV;>;>;")]
		[LineNumberTable(3752)]
		public override Iterator iterator()
		{
			_2 result = new _2(this, peek());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3634)]
		public override object peek()
		{
			ReferenceEntry result = peek();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3634)]
		public override object poll()
		{
			ReferenceEntry result = poll();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3634)]
		public override bool offer(object P_0)
		{
			bool result = offer((ReferenceEntry)P_0);
			_ = null;
			return result;
		}
	}

	[Signature("Ljava/lang/Object;Ljava/util/Map$Entry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)56,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class WriteThroughEntry : java.lang.Object, Map.Entry
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		internal object key;

		[Signature("TV;")]
		internal object value;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LocalCache this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)V")]
		[LineNumberTable(new byte[] { 176, 249, 111, 103, 103 })]
		internal WriteThroughEntry(LocalCache P_0, object P_1, object P_2)
		{
			this_00240 = P_0;
			base._002Ector();
			key = P_1;
			value = P_2;
		}

		[Signature("()TK;")]
		public virtual object getKey()
		{
			return key;
		}

		[Signature("()TV;")]
		public virtual object getValue()
		{
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 56, 0, 0 })]
		[LineNumberTable(new byte[] { 177, 11, 104, 103, 159, 12 })]
		public override bool equals(object P_0)
		{
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				return (java.lang.Object.instancehelper_equals(key, entry.getKey()) && java.lang.Object.instancehelper_equals(value, entry.getValue())) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4487)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(key) ^ java.lang.Object.instancehelper_hashCode(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(new byte[] { 177, 26, 115, 103 })]
		public virtual object setValue(object P_0)
		{
			object result = this_00240.put(key, P_0);
			value = P_0;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4499)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(getKey());
			string text2 = java.lang.String.valueOf(getValue());
			int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append(text).append("=").append(text2)
				.toString();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : BiFunction
	{
		private readonly java.util.function.Function arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon0(java.util.function.Function P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0, object P_1)
		{
			object result = lambda_0024computeIfAbsent_00240(arg_00241, arg_00242, P_0, P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : BiFunction
	{
		private readonly BiFunction arg_00241;

		internal ___003C_003EAnon1(BiFunction P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0, object P_1)
		{
			object result = lambda_0024computeIfPresent_00241(arg_00241, P_0, P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BiFunction
	{
		private readonly object arg_00241;

		private readonly BiFunction arg_00242;

		internal ___003C_003EAnon2(object P_0, BiFunction P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0, object P_1)
		{
			object result = lambda_0024merge_00242(arg_00241, arg_00242, P_0, P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	internal const int MAXIMUM_CAPACITY = 1073741824;

	internal const int MAX_SEGMENTS = 65536;

	internal const int CONTAINS_VALUE_RETRIES = 3;

	internal const int DRAIN_THRESHOLD = 63;

	internal const int DRAIN_MAX = 16;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static Logger logger;

	[Modifiers(Modifiers.Final)]
	internal int segmentMask;

	[Modifiers(Modifiers.Final)]
	internal int segmentShift;

	[Modifiers(Modifiers.Final)]
	[Signature("[Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;")]
	internal Segment[] segments;

	[Modifiers(Modifiers.Final)]
	internal int concurrencyLevel;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	internal Equivalence keyEquivalence;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	internal Equivalence valueEquivalence;

	[Modifiers(Modifiers.Final)]
	internal Strength keyStrength;

	[Modifiers(Modifiers.Final)]
	internal Strength valueStrength;

	[Modifiers(Modifiers.Final)]
	internal long maxWeight;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/cache/Weigher<TK;TV;>;")]
	internal Weigher weigher;

	[Modifiers(Modifiers.Final)]
	internal long expireAfterAccessNanos;

	[Modifiers(Modifiers.Final)]
	internal long expireAfterWriteNanos;

	[Modifiers(Modifiers.Final)]
	internal long refreshNanos;

	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/Queue<Lcom/google/common/cache/RemovalNotification<TK;TV;>;>;")]
	internal Queue removalNotificationQueue;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/cache/RemovalListener<TK;TV;>;")]
	internal RemovalListener removalListener;

	[Modifiers(Modifiers.Final)]
	internal Ticker ticker;

	[Modifiers(Modifiers.Final)]
	internal EntryFactory entryFactory;

	[Modifiers(Modifiers.Final)]
	internal AbstractCache.StatsCounter globalStatsCounter;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/cache/CacheLoader<-TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 1, 85, 0, 0 })]
	internal CacheLoader defaultLoader;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/cache/LocalCache$ValueReference<Ljava/lang/Object;Ljava/lang/Object;>;")]
	internal static ValueReference UNSET;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/Queue<*>;")]
	internal static Queue DISCARDING_QUEUE;

	[Signature("Ljava/util/Set<TK;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 1, 85, 0, 0 })]
	internal new Set keySet;

	[Signature("Ljava/util/Collection<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 1, 85, 0, 0 })]
	internal new Collection values;

	[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 1, 85, 0, 0 })]
	internal new Set entrySet;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/ArrayList<TE;>;")]
	[LineNumberTable(new byte[] { 177, 77, 113, 109 })]
	private static ArrayList toArrayList(Collection P_0)
	{
		ArrayList.___003Cclinit_003E();
		ArrayList arrayList = new ArrayList(P_0.size());
		Iterators.addAll(arrayList, P_0.iterator());
		return arrayList;
	}

	[Signature("<E:Ljava/lang/Object;>()Ljava/util/Queue<TE;>;")]
	internal static Queue discardingQueue()
	{
		return DISCARDING_QUEUE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(360)]
	internal virtual bool recordsTime()
	{
		return (recordsWrite() || recordsAccess()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(368)]
	internal virtual bool usesAccessEntries()
	{
		return (usesAccessQueue() || recordsAccess()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(364)]
	internal virtual bool usesWriteEntries()
	{
		return (usesWriteQueue() || recordsWrite()) ? true : false;
	}

	internal virtual bool evictsBySize()
	{
		return maxWeight >= 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(324)]
	internal virtual bool customWeigher()
	{
		return weigher != CacheBuilder.OneWeigher.INSTANCE;
	}

	[Signature("(I)[Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;")]
	[LineNumberTable(1823)]
	internal Segment[] newSegmentArray(int P_0)
	{
		return new Segment[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(IJLcom/google/common/cache/AbstractCache$StatsCounter;)Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;")]
	[LineNumberTable(1738)]
	internal virtual Segment createSegment(int P_0, long P_1, AbstractCache.StatsCounter P_2)
	{
		Segment result = new Segment(this, P_0, P_1, P_2);
		_ = null;
		return result;
	}

	internal virtual bool expiresAfterWrite()
	{
		return expireAfterWriteNanos > 0;
	}

	internal virtual bool expiresAfterAccess()
	{
		return expireAfterAccessNanos > 0;
	}

	internal virtual bool refreshes()
	{
		return refreshNanos > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(352)]
	internal virtual bool recordsWrite()
	{
		return (expiresAfterWrite() || refreshes()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(356)]
	internal virtual bool recordsAccess()
	{
		bool result = expiresAfterAccess();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(348)]
	internal virtual bool usesWriteQueue()
	{
		bool result = expiresAfterWrite();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(344)]
	internal virtual bool usesAccessQueue()
	{
		return (expiresAfterAccess() || evictsBySize()) ? true : false;
	}

	[Signature("(I)Lcom/google/common/cache/LocalCache$Segment<TK;TV;>;")]
	[LineNumberTable(1733)]
	internal virtual Segment segmentFor(int P_0)
	{
		return segments[((uint)P_0 >> segmentShift) & (uint)segmentMask];
	}

	internal static int rehash(int P_0)
	{
		P_0 += (P_0 << 15) ^ -12931;
		P_0 ^= (int)((uint)P_0 >> 10);
		P_0 += P_0 << 3;
		P_0 ^= (int)((uint)P_0 >> 6);
		P_0 += (P_0 << 2) + (P_0 << 14);
		return P_0 ^ (int)((uint)P_0 >> 16);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;J)Z")]
	[LineNumberTable(new byte[] { 166, 117, 103, 120, 130, 120, 130 })]
	internal virtual bool isExpired(ReferenceEntry P_0, long P_1)
	{
		Preconditions.checkNotNull(P_0);
		if (expiresAfterAccess() && P_1 - P_0.getAccessTime() >= expireAfterAccessNanos)
		{
			return true;
		}
		if (expiresAfterWrite() && P_1 - P_0.getWriteTime() >= expireAfterWriteNanos)
		{
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	[LineNumberTable(897)]
	internal static ReferenceEntry nullEntry()
	{
		return NullEntry.INSTANCE;
	}

	[LineNumberTable(new byte[] { 174, 244, 103, 99, 103, 46, 166 })]
	internal virtual long longSize()
	{
		Segment[] array = segments;
		long num = 0L;
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			num += array[i].count;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 166, 51, 109 })]
	internal virtual int hash(object P_0)
	{
		int num = keyEquivalence.hash(P_0);
		int result = rehash(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 0, 1, 85, 0, 0, 22, 0,
		0, 1, 85, 0, 0
	})]
	[LineNumberTable(new byte[] { 175, 3, 99, 130, 104 })]
	public override object get(object P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		int num = hash(P_0);
		object result = segmentFor(num).get(P_0, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(TK;Lcom/google/common/cache/CacheLoader<-TK;TV;>;)TV;")]
	[LineNumberTable(new byte[] { 175, 11, 109 })]
	internal virtual object get(object P_0, CacheLoader P_1)
	{
		int num = hash(Preconditions.checkNotNull(P_0));
		object result = segmentFor(num).get(P_0, num, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(Ljava/util/Set<+TK;>;Lcom/google/common/cache/CacheLoader<-TK;TV;>;)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		175,
		112,
		103,
		103,
		134,
		162,
		104,
		98,
		byte.MaxValue,
		43,
		78,
		99,
		150,
		byte.MaxValue,
		4,
		61,
		102,
		byte.MaxValue,
		0,
		50,
		98,
		98,
		232,
		75,
		99,
		150,
		229,
		51,
		98,
		106,
		237,
		72,
		99,
		150,
		229,
		54,
		98,
		237,
		70,
		99,
		150,
		229,
		56,
		98,
		205,
		99,
		150,
		229,
		58,
		98,
		141,
		99,
		150,
		129,
		99,
		118,
		191,
		38,
		135,
		99,
		127,
		5,
		105,
		105,
		136,
		133,
		139,
		130,
		100,
		118,
		223,
		38,
		118
	})]
	internal virtual Map loadAll(Set P_0, CacheLoader P_1)
	{
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_0);
		Stopwatch stopwatch = Stopwatch.createStarted();
		int num = 0;
		Map map2;
		CacheLoader.UnsupportedLoadingOperationException ex;
		InterruptedException ex2;
		RuntimeException ex4;
		java.lang.Exception ex6;
		Error error2;
		try
		{
			try
			{
				try
				{
					try
					{
						try
						{
							try
							{
								Map map = P_1.loadAll(P_0);
								map2 = map;
								num = 1;
							}
							catch (CacheLoader.UnsupportedLoadingOperationException x)
							{
								ex = ByteCodeHelper.MapException<CacheLoader.UnsupportedLoadingOperationException>(x, ByteCodeHelper.MapFlags.NoRemapping);
								goto IL_0086;
							}
						}
						catch (InterruptedException x2)
						{
							ex2 = ByteCodeHelper.MapException<InterruptedException>(x2, ByteCodeHelper.MapFlags.NoRemapping);
							goto IL_008a;
						}
					}
					catch (System.Exception x3)
					{
						RuntimeException ex3 = ByteCodeHelper.MapException<RuntimeException>(x3, ByteCodeHelper.MapFlags.None);
						if (ex3 == null)
						{
							throw;
						}
						ex4 = ex3;
						goto IL_0091;
					}
				}
				catch (System.Exception x4)
				{
					java.lang.Exception ex5 = ByteCodeHelper.MapException<java.lang.Exception>(x4, ByteCodeHelper.MapFlags.None);
					if (ex5 == null)
					{
						throw;
					}
					ex6 = ex5;
					goto IL_0098;
				}
			}
			catch (System.Exception x5)
			{
				Error error = ByteCodeHelper.MapException<Error>(x5, ByteCodeHelper.MapFlags.None);
				if (error == null)
				{
					throw;
				}
				error2 = error;
				goto IL_009f;
			}
		}
		catch
		{
			//try-fault
			if (num == 0)
			{
				globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
			}
			throw;
		}
		if (num == 0)
		{
			globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
		}
		if (map2 == null)
		{
			globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
			string text = java.lang.String.valueOf(P_1);
			int num2 = 31 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num2 = num2;
			string message = new StringBuilder(num2).append(text).append(" returned null map from loadAll").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CacheLoader.InvalidCacheLoadException(message);
		}
		stopwatch.stop();
		int num3 = 0;
		Iterator iterator = map2.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			object key = entry.getKey();
			object value = entry.getValue();
			if (key == null || value == null)
			{
				num3 = 1;
			}
			else
			{
				put(key, value);
			}
		}
		if (num3 != 0)
		{
			globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
			string text2 = java.lang.String.valueOf(P_1);
			int num2 = 42 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num2 = num2;
			string message2 = new StringBuilder(num2).append(text2).append(" returned null keys or values from loadAll").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new CacheLoader.InvalidCacheLoadException(message2);
		}
		globalStatsCounter.recordLoadSuccess(stopwatch.elapsed(TimeUnit.NANOSECONDS));
		return map2;
		IL_009f:
		Error error3 = error2;
		try
		{
			Error cause = error3;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionError(cause);
		}
		catch
		{
			//try-fault
			if (num == 0)
			{
				globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
			}
			throw;
		}
		IL_0098:
		java.lang.Exception ex7 = ex6;
		try
		{
			java.lang.Exception cause2 = ex7;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionException(cause2);
		}
		catch
		{
			//try-fault
			if (num == 0)
			{
				globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
			}
			throw;
		}
		IL_0091:
		RuntimeException ex8 = ex4;
		try
		{
			RuntimeException cause3 = ex8;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UncheckedExecutionException(cause3);
		}
		catch
		{
			//try-fault
			if (num == 0)
			{
				globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
			}
			throw;
		}
		IL_008a:
		InterruptedException ex9 = ex2;
		try
		{
			InterruptedException cause4 = ex9;
			java.lang.Thread.currentThread().interrupt();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ExecutionException(cause4);
		}
		catch
		{
			//try-fault
			if (num == 0)
			{
				globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
			}
			throw;
		}
		IL_0086:
		CacheLoader.UnsupportedLoadingOperationException ex10 = ex;
		try
		{
			CacheLoader.UnsupportedLoadingOperationException ex11 = ex10;
			num = 1;
			throw Throwable.___003Cunmap_003E(ex11);
		}
		catch
		{
			//try-fault
			if (num == 0)
			{
				globalStatsCounter.recordLoadException(stopwatch.elapsed(TimeUnit.NANOSECONDS));
			}
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(new byte[] { 175, 239, 103, 103, 104 })]
	public override object put(object P_0, object P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		int num = hash(P_0);
		object result = segmentFor(num).put(P_0, num, P_1, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 2, 3, 1, 2, 0, 1,
		85, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		175,
		byte.MaxValue,
		103,
		103,
		104
	})]
	public override object compute(object P_0, BiFunction P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		int num = hash(P_0);
		object result = segmentFor(num).compute(P_0, num, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 176, 37, 99, 130, 104 })]
	public override object remove(object P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		int num = hash(P_0);
		object result = segmentFor(num).remove(P_0, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(new byte[] { 176, 91, 103 })]
	public override Set keySet()
	{
		Set set = this.keySet;
		object set2;
		if (set != null)
		{
			set2 = set;
		}
		else
		{
			KeySet keySet = new KeySet(this);
			set2 = keySet;
			this.keySet = keySet;
		}
		return (set2 == null) ? null : ((set2 as Set) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 0, 0, 1, 85, 0, 0, 22,
		1, 0, 1, 85, 0, 0
	})]
	[LineNumberTable(new byte[] { 176, 46, 102, 130, 104 })]
	public override bool remove(object P_0, object P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return false;
		}
		int num = hash(P_0);
		bool result = segmentFor(num).remove(P_0, num, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(4219)]
	private static object lambda_0024computeIfAbsent_00240(java.util.function.Function P_0, object P_1, object P_2, object P_3)
	{
		return (P_3 != null) ? P_3 : P_0.apply(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(4226)]
	private static object lambda_0024computeIfPresent_00241(BiFunction P_0, object P_1, object P_2)
	{
		object result = ((P_2 != null) ? P_0.apply(P_1, P_2) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(4235)]
	private static object lambda_0024merge_00242(object P_0, BiFunction P_1, object P_2, object P_3)
	{
		object result = ((P_3 != null) ? P_1.apply(P_3, P_0) : P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/CacheBuilder<-TK;-TV;>;Lcom/google/common/cache/CacheLoader<-TK;TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 1, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		160, 129, 104, 150, 108, 140, 108, 140, 108, 108,
		108, 108, 140, 108, 97, 109, 103, 157, 114, 125,
		118, 135, 113, 112, 239, 72, 98, 98, 126, 100,
		134, 106, 137, 141, 109, 103, 166, 99, 102, 168,
		139, 119, 118, 110, 103, 135, 110, 245, 59, 232,
		71, 98, 110, 110, 21, 232, 69
	})]
	internal LocalCache(CacheBuilder P_0, CacheLoader P_1)
	{
		concurrencyLevel = java.lang.Math.min(P_0.getConcurrencyLevel(), 65536);
		keyStrength = P_0.getKeyStrength();
		valueStrength = P_0.getValueStrength();
		keyEquivalence = P_0.getKeyEquivalence();
		valueEquivalence = P_0.getValueEquivalence();
		maxWeight = P_0.getMaximumWeight();
		weigher = P_0.getWeigher();
		expireAfterAccessNanos = P_0.getExpireAfterAccessNanos();
		expireAfterWriteNanos = P_0.getExpireAfterWriteNanos();
		refreshNanos = P_0.getRefreshNanos();
		removalListener = P_0.getRemovalListener();
		Queue obj = ((removalListener != CacheBuilder.NullListener.INSTANCE) ? new ConcurrentLinkedQueue() : discardingQueue());
		removalNotificationQueue = ((obj == null) ? null : ((obj as Queue) ?? throw new java.lang.IncompatibleClassChangeError()));
		ticker = P_0.getTicker(recordsTime());
		entryFactory = EntryFactory.getFactory(keyStrength, usesAccessEntries(), usesWriteEntries());
		globalStatsCounter = (AbstractCache.StatsCounter)P_0.getStatsCounterSupplier().get();
		defaultLoader = P_1;
		int num = java.lang.Math.min(P_0.getInitialCapacity(), 1073741824);
		if (evictsBySize() && !customWeigher())
		{
			num = (int)java.lang.Math.min(num, maxWeight);
		}
		int num2 = 0;
		int num3 = 1;
		while (num3 < concurrencyLevel && (!evictsBySize() || num3 * 20 <= maxWeight))
		{
			num2++;
			num3 <<= 1;
		}
		segmentShift = 32 - num2;
		segmentMask = num3 - 1;
		segments = newSegmentArray(num3);
		int num4 = num;
		int num5 = num3;
		int num6 = ((num5 != -1) ? (num4 / num5) : (-num4));
		if (num6 * num3 < num)
		{
			num6++;
		}
		int num7;
		for (num7 = 1; num7 < num6; num7 <<= 1)
		{
		}
		if (evictsBySize())
		{
			long num8 = maxWeight;
			long num9 = num3;
			long num10 = ((num9 != -1) ? (num8 / num9) : (-num8)) + 1;
			long num11 = maxWeight;
			long num12 = num3;
			long num13 = ((num12 != -1) ? (num11 % num12) : 0);
			for (int i = 0; i < (nint)segments.LongLength; i++)
			{
				if (i == num13)
				{
					num10--;
				}
				segments[i] = createSegment(num7, num10, (AbstractCache.StatsCounter)P_0.getStatsCounterSupplier().get());
			}
		}
		else
		{
			for (int j = 0; j < (nint)segments.LongLength; j++)
			{
				segments[j] = createSegment(num7, -1L, (AbstractCache.StatsCounter)P_0.getStatsCounterSupplier().get());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(328)]
	internal virtual bool expires()
	{
		return (expiresAfterWrite() || expiresAfterAccess()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(372)]
	internal virtual bool usesKeyReferences()
	{
		return keyStrength != Strength.STRONG;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(376)]
	internal virtual bool usesValueReferences()
	{
		return valueStrength != Strength.STRONG;
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
	internal static ValueReference unset()
	{
		return UNSET;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;ILcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 166, 20, 104, 134, 142, 102, 35, 2 })]
	internal virtual ReferenceEntry newEntry(object P_0, int P_1, ReferenceEntry P_2)
	{
		Segment segment = segmentFor(P_1);
		segment.@lock();
		try
		{
			return segment.newEntry(P_0, P_1, P_2);
		}
		finally
		{
			segment.unlock();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	[LineNumberTable(new byte[] { 166, 36, 103 })]
	internal virtual ReferenceEntry copyEntry(ReferenceEntry P_0, ReferenceEntry P_1)
	{
		int num = P_0.getHash();
		ReferenceEntry result = segmentFor(num).copyEntry(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;TV;I)Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;")]
	[LineNumberTable(new byte[] { 166, 46, 103 })]
	internal virtual ValueReference newValueReference(ReferenceEntry P_0, object P_1, int P_2)
	{
		int num = P_0.getHash();
		ValueReference result = valueStrength.referenceValue(segmentFor(num), P_0, Preconditions.checkNotNull(P_1), P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/LocalCache$ValueReference<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 166, 56, 103, 103, 117 })]
	internal virtual void reclaimValue(ValueReference P_0)
	{
		ReferenceEntry entry = P_0.getEntry();
		int num = entry.getHash();
		segmentFor(num).reclaimValue(entry.getKey(), num, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 166, 62, 103, 111 })]
	internal virtual void reclaimKey(ReferenceEntry P_0)
	{
		int num = P_0.getHash();
		segmentFor(num).reclaimKey(P_0, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;J)Z")]
	[LineNumberTable(1722)]
	internal virtual bool isLive(ReferenceEntry P_0, long P_1)
	{
		return segmentFor(P_0.getHash()).getLiveValue(P_0, P_1) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;J)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 166, 99, 104, 130, 108, 99, 162, 106, 130 })]
	internal virtual object getLiveValue(ReferenceEntry P_0, long P_1)
	{
		if (P_0.getKey() == null)
		{
			return null;
		}
		object obj = P_0.getValueReference().get();
		if (obj == null)
		{
			return null;
		}
		if (isExpired(P_0, P_1))
		{
			return null;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 166, 131, 103, 105 })]
	internal static void connectAccessOrder(ReferenceEntry P_0, ReferenceEntry P_1)
	{
		P_0.setNextInAccessQueue(P_1);
		P_1.setPreviousInAccessQueue(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 166, 137, 102, 103, 105 })]
	internal static void nullifyAccessOrder(ReferenceEntry P_0)
	{
		ReferenceEntry referenceEntry = nullEntry();
		P_0.setNextInAccessQueue(referenceEntry);
		P_0.setPreviousInAccessQueue(referenceEntry);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 166, 144, 103, 105 })]
	internal static void connectWriteOrder(ReferenceEntry P_0, ReferenceEntry P_1)
	{
		P_0.setNextInWriteQueue(P_1);
		P_1.setPreviousInWriteQueue(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/cache/ReferenceEntry<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 166, 150, 102, 103, 105 })]
	internal static void nullifyWriteOrder(ReferenceEntry P_0)
	{
		ReferenceEntry referenceEntry = nullEntry();
		P_0.setNextInWriteQueue(referenceEntry);
		P_0.setPreviousInWriteQueue(referenceEntry);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 166, 162, 148, 190, 2, 97, 117, 130 })]
	internal virtual void processPendingNotifications()
	{
		RemovalNotification rn;
		while ((rn = (RemovalNotification)removalNotificationQueue.poll()) != null)
		{
			System.Exception ex;
			try
			{
				removalListener.onRemoval(rn);
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_002f;
			}
			continue;
			IL_002f:
			System.Exception thrown = ex;
			logger.log(Level.WARNING, "Exception thrown by removal listener", thrown);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 174, 206, 116, 38, 166 })]
	public virtual void cleanUp()
	{
		Segment[] array = segments;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			Segment segment = array[i];
			segment.cleanUp();
		}
	}

	[LineNumberTable(new byte[]
	{
		174, 222, 99, 103, 103, 108, 130, 236, 60, 230,
		71, 101, 103, 108, 130, 236, 60, 230, 70, 134
	})]
	public override bool isEmpty()
	{
		long num = 0L;
		Segment[] array = segments;
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			if (array[i].count != 0)
			{
				return false;
			}
			num += array[i].modCount;
		}
		if (num != 0)
		{
			for (int i = 0; i < (nint)array.LongLength; i++)
			{
				if (array[i].count != 0)
				{
					return false;
				}
				num -= array[i].modCount;
			}
			return num == 0;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(3952)]
	public override int size()
	{
		int result = Ints.saturatedCast(longSize());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 175, 16, 109, 111, 99, 142, 140 })]
	public virtual object getIfPresent(object P_0)
	{
		int num = hash(Preconditions.checkNotNull(P_0));
		object obj = segmentFor(num).get(P_0, num);
		if (obj == null)
		{
			globalStatsCounter.recordMisses(1);
		}
		else
		{
			globalStatsCounter.recordHits(1);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;TV;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 20, 0, 1, 85, 0, 0, 22, 0,
		0, 1, 85, 0, 0, 22, 1, 0, 1, 85,
		0, 0
	})]
	[LineNumberTable(new byte[] { 175, 30, 104 })]
	public override object getOrDefault(object P_0, object P_1)
	{
		object obj = get(P_0);
		return (obj == null) ? P_1 : obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(TK;)TV;")]
	[LineNumberTable(3989)]
	internal virtual object getOrLoad(object P_0)
	{
		object result = get(P_0, defaultLoader);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		175, 39, 98, 130, 102, 119, 106, 100, 198, 100,
		107, 132, 98, 108, 108
	})]
	internal virtual ImmutableMap getAllPresent(Iterable P_0)
	{
		int num = 0;
		int num2 = 0;
		ImmutableMap.Builder builder = ImmutableMap.builder();
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			object obj2 = get(obj);
			if (obj2 == null)
			{
				num2++;
				continue;
			}
			object key = obj;
			builder.put(key, obj2);
			num++;
		}
		globalStatsCounter.recordHits(num);
		globalStatsCounter.recordMisses(num2);
		ImmutableMap result = builder.buildKeepingLast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(Ljava/lang/Iterable<+TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		175, 61, 98, 130, 102, 102, 122, 106, 106, 107,
		100, 100, 139, 164, 162, 139, 116, 125, 107, 100,
		159, 39, 107, 235, 71, 196, 108, 108, 237, 52,
		129, 122, 100, 119, 228, 69, 108, 108, 227, 60,
		140, 108, 108, 3, 2
	})]
	internal virtual ImmutableMap getAll(Iterable P_0)
	{
		int num = 0;
		int num2 = 0;
		LinkedHashMap linkedHashMap = Maps.newLinkedHashMap();
		LinkedHashSet linkedHashSet = Sets.newLinkedHashSet();
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			object obj2 = get(obj);
			if (!((Map)linkedHashMap).containsKey(obj))
			{
				((Map)linkedHashMap).put(obj, obj2);
				if (obj2 == null)
				{
					num2++;
					((Set)linkedHashSet).add(obj);
				}
				else
				{
					num++;
				}
			}
		}
		try
		{
			if (!((Set)linkedHashSet).isEmpty())
			{
				try
				{
					Map map = loadAll(Collections.unmodifiableSet(linkedHashSet), defaultLoader);
					Iterator iterator2 = ((Set)linkedHashSet).iterator();
					while (iterator2.hasNext())
					{
						object obj2 = iterator2.next();
						object obj3 = map.get(obj2);
						if (obj3 == null)
						{
							string text = java.lang.String.valueOf(obj2);
							int num3 = 37 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
							num3 = num3;
							string message = new StringBuilder(num3).append("loadAll failed to return a value for ").append(text).toString();
							Throwable.___003CsuppressFillInStackTrace_003E();
							throw new CacheLoader.InvalidCacheLoadException(message);
						}
						((Map)linkedHashMap).put(obj2, obj3);
					}
				}
				catch (CacheLoader.UnsupportedLoadingOperationException)
				{
					goto IL_012b;
				}
			}
		}
		catch
		{
			//try-fault
			globalStatsCounter.recordHits(num);
			globalStatsCounter.recordMisses(num2);
			throw;
		}
		goto IL_0187;
		IL_012b:
		CacheLoader.UnsupportedLoadingOperationException ex2 = null;
		try
		{
			Iterator iterator2 = ((Set)linkedHashSet).iterator();
			while (iterator2.hasNext())
			{
				object obj2 = iterator2.next();
				num2 += -1;
				((Map)linkedHashMap).put(obj2, get(obj2, defaultLoader));
			}
		}
		catch
		{
			//try-fault
			globalStatsCounter.recordHits(num);
			globalStatsCounter.recordMisses(num2);
			throw;
		}
		goto IL_0187;
		IL_0187:
		try
		{
			return ImmutableMap.copyOf(linkedHashMap);
		}
		finally
		{
			globalStatsCounter.recordHits(num);
			globalStatsCounter.recordMisses(num2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Lcom/google/common/cache/ReferenceEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 175, 175, 99, 130, 104 })]
	internal virtual ReferenceEntry getEntry(object P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		int num = hash(P_0);
		ReferenceEntry entry = segmentFor(num).getEntry(P_0, num);
		_ = null;
		return entry;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)V")]
	[LineNumberTable(new byte[] { 175, 183, 109, 118 })]
	internal virtual void refresh(object P_0)
	{
		int num = hash(Preconditions.checkNotNull(P_0));
		segmentFor(num).refresh(P_0, num, defaultLoader, false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 175, 190, 99, 130, 104 })]
	public override bool containsKey(object P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		int num = hash(P_0);
		bool result = segmentFor(num).containsKey(P_0, num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		175, 200, 99, 226, 72, 108, 103, 99, 105, 100,
		155, 138, 107, 110, 116, 108, 116, 226, 61, 43,
		235, 72, 237, 51, 235, 79, 101, 130, 227, 44,
		233, 86
	})]
	public override bool containsValue(object P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		long num = ticker.read();
		Segment[] array = segments;
		long num2 = -1L;
		for (int i = 0; i < 3; i++)
		{
			long num3 = 0L;
			Segment[] array2 = array;
			int num4 = array2.Length;
			for (int j = 0; j < num4; j++)
			{
				Segment segment = array2[j];
				_ = segment.count;
				AtomicReferenceArray table = segment.table;
				for (int k = 0; k < table.length(); k++)
				{
					for (ReferenceEntry referenceEntry = (ReferenceEntry)table.get(k); referenceEntry != null; referenceEntry = referenceEntry.getNext())
					{
						object liveValue = segment.getLiveValue(referenceEntry, num);
						if (liveValue != null && valueEquivalence.equivalent(P_0, liveValue))
						{
							return true;
						}
					}
				}
				num3 += segment.modCount;
			}
			if (num3 == num2)
			{
				break;
			}
			num2 = num3;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(new byte[] { 175, 247, 103, 103, 104 })]
	public override object putIfAbsent(object P_0, object P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		int num = hash(P_0);
		object result = segmentFor(num).put(P_0, num, P_1, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/function/Function<-TK;+TV;>;)TV;")]
	[LineNumberTable(new byte[] { 176, 7, 103, 103 })]
	public override object computeIfAbsent(object P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		object result = compute(P_0, new ___003C_003EAnon0(P_1, P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
	[LineNumberTable(new byte[] { 176, 14, 103, 103 })]
	public override object computeIfPresent(object P_0, BiFunction P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		object result = compute(P_0, new ___003C_003EAnon1(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)TV;")]
	[LineNumberTable(new byte[] { 176, 21, 103, 103, 103 })]
	public override object merge(object P_0, object P_1, BiFunction P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		object result = compute(P_0, new ___003C_003EAnon2(P_1, P_2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 176, 30, 127, 1, 115, 98 })]
	public override void putAll(Map P_0)
	{
		Iterator iterator = P_0.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			put(entry.getKey(), entry.getValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;TV;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 1, 0, 1, 85, 0, 0 })]
	[LineNumberTable(new byte[] { 176, 55, 103, 103, 99, 130, 104 })]
	public override bool replace(object P_0, object P_1, object P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_2);
		if (P_1 == null)
		{
			return false;
		}
		int num = hash(P_0);
		bool result = segmentFor(num).replace(P_0, num, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(new byte[] { 176, 66, 103, 103, 104 })]
	public override object replace(object P_0, object P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		int num = hash(P_0);
		object result = segmentFor(num).replace(P_0, num, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 176, 74, 116, 38, 166 })]
	public override void clear()
	{
		Segment[] array = segments;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			Segment segment = array[i];
			segment.clear();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;)V")]
	[LineNumberTable(new byte[] { 176, 81, 118, 104, 98 })]
	internal virtual void invalidateAll(Iterable P_0)
	{
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			remove(obj);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 176, 100, 103 })]
	public override Collection values()
	{
		Collection collection = this.values;
		object collection2;
		if (collection != null)
		{
			collection2 = collection;
		}
		else
		{
			Values values = new Values(this);
			collection2 = values;
			this.values = values;
		}
		return (collection2 == null) ? null : ((collection2 as Collection) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 176, 110, 103 })]
	public override Set entrySet()
	{
		Set set = this.entrySet;
		object set2;
		if (set != null)
		{
			set2 = set;
		}
		else
		{
			EntrySet entrySet = new EntrySet(this);
			set2 = entrySet;
			this.entrySet = entrySet;
		}
		return (set2 == null) ? null : ((set2 as Set) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiPredicate<-TK;-TV;>;)Z")]
	[LineNumberTable(new byte[]
	{
		177, 83, 103, 98, 155, 104, 109, 98, 106, 98,
		130, 98, 98
	})]
	internal virtual bool removeIf(BiPredicate P_0)
	{
		Preconditions.checkNotNull(P_0);
		int result = 0;
		Iterator iterator = keySet().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			while (true)
			{
				object obj2 = get(obj);
				if (obj2 == null || !P_0.test(obj, obj2))
				{
					break;
				}
				if (remove(obj, obj2))
				{
					result = 1;
					break;
				}
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(106)]
	internal static ArrayList access_0024200(Collection P_0)
	{
		ArrayList result = toArrayList(P_0);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 117, 249, 162, 4, 234, 160, 217 })]
	static LocalCache()
	{
		logger = Logger.getLogger(ClassLiteral<LocalCache>.Value.getName(), LocalCache.___003CGetCallerID_003E());
		UNSET = new _1();
		DISCARDING_QUEUE = new _2();
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	void ConcurrentMap.ConcurrentMap_003A_003AforEach(BiConsumer P_0)
	{
		forEach(P_0);
	}

	void ConcurrentMap.ConcurrentMap_003A_003AreplaceAll(BiFunction P_0)
	{
		replaceAll(P_0);
	}

	bool Map.Map_003A_003Aequals(object P_0)
	{
		return equals(P_0);
	}

	int Map.Map_003A_003AhashCode()
	{
		return hashCode();
	}

	void Map.Map_003A_003AforEach(BiConsumer P_0)
	{
		forEach(P_0);
	}

	void Map.Map_003A_003AreplaceAll(BiFunction P_0)
	{
		replaceAll(P_0);
	}
}
