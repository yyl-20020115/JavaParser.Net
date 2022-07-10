using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.lang.@ref;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using java.util.concurrent.locks;
using java.util.function;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;S:Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;TE;TS;>;>Ljava/util/AbstractMap<TK;TV;>;Ljava/util/concurrent/ConcurrentMap<TK;TV;>;Ljava/io/Serializable;")]
[ConstantPool(new object[]
{
	(byte)205,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[Implements(new string[] { "java.util.concurrent.ConcurrentMap", "java.io.Serializable" })]
internal class MapMakerInternalMap : AbstractMap, ConcurrentMap, Map, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<Ljava/lang/Object;Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$DummyInternalEntry;>;")]
	[EnclosingMethod(null, null, null)]
	internal class _1 : java.lang.Object, WeakValueReference
	{
		[Signature("(Ljava/lang/ref/ReferenceQueue<Ljava/lang/Object;>;Lcom/google/common/collect/MapMakerInternalMap$DummyInternalEntry;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<Ljava/lang/Object;Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$DummyInternalEntry;>;")]
		public virtual WeakValueReference copyFor(ReferenceQueue P_0, DummyInternalEntry P_1)
		{
			return this;
		}

		public virtual DummyInternalEntry getEntry()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1005)]
		internal _1()
		{
		}

		public virtual void clear()
		{
		}

		public virtual object get()
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1005)]
		public virtual WeakValueReference copyFor(ReferenceQueue P_0, InternalEntry P_1)
		{
			WeakValueReference result = copyFor(P_0, (DummyInternalEntry)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1005)]
		public virtual InternalEntry getEntry()
		{
			DummyInternalEntry entry = this.getEntry();
			_ = null;
			return entry;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingConcurrentMap<TK;TV;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal abstract class AbstractSerializationProxy : ForwardingConcurrentMap, Serializable.__Interface, ISerializable
	{
		private const long serialVersionUID = 3L;

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
		internal int concurrencyLevel;

		[NonSerialized]
		[Signature("Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
		internal new ConcurrentMap @delegate;

		[Signature("()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
		protected internal override ConcurrentMap @delegate()
		{
			return this.@delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$Strength;Lcom/google/common/collect/MapMakerInternalMap$Strength;Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;ILjava/util/concurrent/ConcurrentMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 170, 191, 104, 103, 103, 103, 104, 104, 104 })]
		internal AbstractSerializationProxy(Strength P_0, Strength P_1, Equivalence P_2, Equivalence P_3, int P_4, ConcurrentMap P_5)
		{
			keyStrength = P_0;
			valueStrength = P_1;
			keyEquivalence = P_2;
			valueEquivalence = P_3;
			concurrencyLevel = P_4;
			this.@delegate = P_5;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 170, 206, 113, 127, 6, 108, 108, 98, 105 })]
		internal virtual void writeMapTo(ObjectOutputStream P_0)
		{
			P_0.writeInt(this.@delegate.size());
			Iterator iterator = this.@delegate.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				P_0.writeObject(entry.getKey());
				P_0.writeObject(entry.getValue());
			}
			P_0.writeObject(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 170, 216, 103, 102, 107, 107, 107, 107, 231, 59 })]
		internal virtual MapMaker readMapMaker(ObjectInputStream P_0)
		{
			int initialCapacity = P_0.readInt();
			MapMaker result = new MapMaker().initialCapacity(initialCapacity).setKeyStrength(keyStrength).setValueStrength(valueStrength)
				.keyEquivalence(keyEquivalence)
				.concurrencyLevel(concurrencyLevel);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 170, 228, 103, 99, 130, 103, 110, 98 })]
		internal virtual void readEntries(ObjectInputStream P_0)
		{
			while (true)
			{
				object obj = P_0.readObject();
				if (obj == null)
				{
					break;
				}
				object value = P_0.readObject();
				this.@delegate.put(obj, value);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2847)]
		protected internal new virtual Map @delegate()
		{
			ConcurrentMap result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2847)]
		protected internal new virtual object @delegate()
		{
			ConcurrentMap result = this.@delegate();
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
		protected AbstractSerializationProxy(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;")]
	[ConstantPool(new object[]
	{
		(byte)20,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class AbstractStrongKeyEntry : java.lang.Object, InternalEntry
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		internal object key;

		[Modifiers(Modifiers.Final)]
		internal int hash;

		[Modifiers(Modifiers.Final)]
		[Signature("TE;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 20, 0, 0 })]
		internal InternalEntry next;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITE;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 20, 0, 0 })]
		[LineNumberTable(new byte[] { 160, 234, 104, 103, 103, 103 })]
		internal AbstractStrongKeyEntry(object P_0, int P_1, InternalEntry P_2)
		{
			key = P_0;
			hash = P_1;
			next = P_2;
		}

		[Signature("()TK;")]
		public virtual object getKey()
		{
			return key;
		}

		public virtual int getHash()
		{
			return hash;
		}

		[Signature("()TE;")]
		public virtual InternalEntry getNext()
		{
			return next;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract object getValue();
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>Ljava/lang/ref/WeakReference<TK;>;Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;")]
	[ConstantPool(new object[]
	{
		(byte)17,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$InternalEntry" })]
	internal abstract class AbstractWeakKeyEntry : java.lang.@ref.WeakReference, InternalEntry
	{
		[Modifiers(Modifiers.Final)]
		internal int hash;

		[Modifiers(Modifiers.Final)]
		[Signature("TE;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 17, 0, 0 })]
		internal InternalEntry next;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;TK;ITE;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 17, 0, 0 })]
		[LineNumberTable(new byte[] { 162, 29, 106, 103, 104 })]
		internal AbstractWeakKeyEntry(ReferenceQueue P_0, object P_1, int P_2, InternalEntry P_3)
			: base(P_1, P_0)
		{
			hash = P_2;
			next = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(662)]
		public virtual object getKey()
		{
			object result = get();
			_ = null;
			return result;
		}

		public virtual int getHash()
		{
			return hash;
		}

		[Signature("()TE;")]
		public virtual InternalEntry getNext()
		{
			return next;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract object getValue();
	}

	internal sealed class CleanupMapTask : java.lang.Object, Runnable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/lang/ref/WeakReference<Lcom/google/common/collect/MapMakerInternalMap<****>;>;")]
		internal java.lang.@ref.WeakReference mapReference;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<****>;)V")]
		[LineNumberTable(new byte[] { 168, 100, 104, 108 })]
		public CleanupMapTask(MapMakerInternalMap P_0)
		{
			mapReference = new java.lang.@ref.WeakReference(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 106, 113, 99, 171, 117, 39, 166 })]
		public virtual void run()
		{
			MapMakerInternalMap mapMakerInternalMap = (MapMakerInternalMap)mapReference.get();
			if (mapMakerInternalMap == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new CancellationException();
			}
			Segment[] segments = mapMakerInternalMap.segments;
			int num = segments.Length;
			for (int i = 0; i < num; i++)
			{
				Segment segment = segments[i];
				segment.runCleanup();
			}
		}
	}

	[Signature("Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<Ljava/lang/Object;Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$DummyInternalEntry;>;")]
	internal sealed class DummyInternalEntry : java.lang.Object, InternalEntry
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(981)]
		public virtual DummyInternalEntry getNext()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 93, 102 })]
		private DummyInternalEntry()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(986)]
		public virtual int getHash()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(991)]
		public virtual object getKey()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(996)]
		public virtual object getValue()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(973)]
		public virtual InternalEntry getNext()
		{
			DummyInternalEntry next = this.getNext();
			_ = null;
			return next;
		}
	}

	[InnerClass(null, Modifiers.Final)]
	[Signature("Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>.HashIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal sealed class EntryIterator : HashIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(2678)]
		public new virtual Map.Entry next()
		{
			WriteThroughEntry result = base.nextEntry();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2674)]
		internal EntryIterator(MapMakerInternalMap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2674)]
		public override object next()
		{
			Map.Entry result = next();
			_ = null;
			return result;
		}
	}

	[Signature("Lcom/google/common/collect/MapMakerInternalMap$SafeToArraySet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal sealed class EntrySet : SafeToArraySet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MapMakerInternalMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2759)]
		internal EntrySet(MapMakerInternalMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(2763)]
		public override Iterator iterator()
		{
			EntryIterator result = new EntryIterator(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 170, 94, 104, 130, 103, 103, 99, 130, 141 })]
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
			return (obj != null && this_00240.valueEquivalence().equivalent(entry.getValue(), obj)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 170, 109, 104, 130, 103, 103 })]
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2793)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2798)]
		public override bool isEmpty()
		{
			bool result = this_00240.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 170, 129, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}
	}

	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class HashIterator : java.lang.Object, Iterator
	{
		internal int nextSegmentIndex;

		internal int nextTableIndex;

		[Signature("Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;TE;TS;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 45, 0, 0 })]
		internal Segment currentSegment;

		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceArray<TE;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 45, 0, 0 })]
		internal AtomicReferenceArray currentTable;

		[Signature("TE;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 45, 0, 0 })]
		internal InternalEntry nextEntry;

		[Signature("Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>.WriteThroughEntry;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 1, 0, 0, 45, 0, 0 })]
		internal WriteThroughEntry nextExternal;

		[Signature("Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>.WriteThroughEntry;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 1, 0, 0, 45, 0, 0 })]
		internal WriteThroughEntry lastReturned;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MapMakerInternalMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			169, 105, 135, 104, 161, 104, 161, 105, 127, 6,
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
		[LineNumberTable(new byte[] { 169, 129, 104, 121, 110, 2, 243, 70 })]
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
		[LineNumberTable(new byte[] { 169, 141, 105, 127, 17, 118, 194 })]
		internal virtual bool nextInTable()
		{
			while (nextTableIndex >= 0)
			{
				AtomicReferenceArray atomicReferenceArray = currentTable;
				int num = nextTableIndex;
				nextTableIndex = num - 1;
				InternalEntry internalEntry = (InternalEntry)atomicReferenceArray.get(num);
				this.nextEntry = internalEntry;
				if (internalEntry != null && (advanceTo(this.nextEntry) || nextInChain()))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(new byte[]
		{
			169, 157, 103, 109, 99, 115, 232, 70, 107, 37,
			235, 58, 162, 166, 107, 35, 226, 61
		})]
		internal virtual bool advanceTo(InternalEntry P_0)
		{
			int result;
			try
			{
				object key = P_0.getKey();
				object liveValue = this_00240.getLiveValue(P_0);
				if (liveValue != null)
				{
					nextExternal = new WriteThroughEntry(this_00240, key, liveValue);
					result = 1;
					goto IL_0042;
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
			IL_0042:
			currentSegment.postReadCleanup();
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 169, 95, 111, 111, 103, 104 })]
		internal HashIterator(MapMakerInternalMap P_0)
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
		[Signature("()Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>.WriteThroughEntry;")]
		[LineNumberTable(new byte[] { 169, 177, 104, 139, 108, 102 })]
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
		[LineNumberTable(new byte[] { 169, 187, 113, 119, 103 })]
		public virtual void remove()
		{
			CollectPreconditions.checkRemove(lastReturned != null);
			this_00240.remove(lastReturned.getKey());
			lastReturned = null;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>Ljava/lang/Object;")]
	internal interface InternalEntry
	{
		[Signature("()TK;")]
		virtual object getKey();

		virtual int getHash();

		[Signature("()TV;")]
		virtual object getValue();

		[Signature("()TE;")]
		virtual InternalEntry getNext();
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;S:Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;TE;TS;>;>Ljava/lang/Object;")]
	[ConstantPool(new object[]
	{
		(byte)21,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal interface InternalEntryHelper
	{
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>;II)TS;")]
		virtual Segment newSegment(MapMakerInternalMap P_0, int P_1, int P_2);

		virtual Strength keyStrength();

		virtual Strength valueStrength();

		[Signature("(TS;TK;ITE;)TE;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 21, 0, 0 })]
		virtual InternalEntry newEntry(Segment P_0, object P_1, int P_2, InternalEntry P_3);

		[Signature("(TS;TE;TE;)TE;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 21, 0, 0 })]
		virtual InternalEntry copy(Segment P_0, InternalEntry P_1, InternalEntry P_2);

		[Signature("(TS;TE;TV;)V")]
		virtual void setValue(Segment P_0, InternalEntry P_1, object P_2);
	}

	[InnerClass(null, Modifiers.Final)]
	[Signature("Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>.HashIterator<TK;>;")]
	internal sealed class KeyIterator : HashIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2611)]
		internal KeyIterator(MapMakerInternalMap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(2615)]
		public override object next()
		{
			object key = base.nextEntry().getKey();
			_ = null;
			return key;
		}
	}

	[Signature("Lcom/google/common/collect/MapMakerInternalMap$SafeToArraySet<TK;>;")]
	internal sealed class KeySet : SafeToArraySet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MapMakerInternalMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2683)]
		internal KeySet(MapMakerInternalMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(2687)]
		public override Iterator iterator()
		{
			KeyIterator result = new KeyIterator(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2692)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2697)]
		public override bool isEmpty()
		{
			bool result = this_00240.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2702)]
		public override bool contains(object P_0)
		{
			bool result = this_00240.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2707)]
		public override bool remove(object P_0)
		{
			return this_00240.remove(P_0) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 170, 38, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;")]
	internal abstract class SafeToArraySet : AbstractSet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2807)]
		private SafeToArraySet()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2813)]
		public override object[] toArray()
		{
			object[] result = access_0024900(this).toArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[LineNumberTable(2818)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = access_0024900(this).toArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(2807)]
		internal SafeToArraySet(_1 P_0)
			: this()
		{
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;S:Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;TE;TS;>;>Ljava/util/concurrent/locks/ReentrantLock;")]
	[ConstantPool(new object[]
	{
		(byte)80,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class Segment : ReentrantLock
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>;")]
		internal MapMakerInternalMap map;

		internal volatile int count;

		internal int modCount;

		internal int threshold;

		[Signature("Ljava/util/concurrent/atomic/AtomicReferenceArray<TE;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 80, 0, 0 })]
		internal volatile AtomicReferenceArray table;

		[Modifiers(Modifiers.Final)]
		internal int maxSegmentSize;

		[Modifiers(Modifiers.Final)]
		internal AtomicInteger readCount;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)TE;")]
		[LineNumberTable(1234)]
		internal virtual InternalEntry copyEntry(InternalEntry P_0, InternalEntry P_1)
		{
			InternalEntry result = map.entryHelper.copy(self(), P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;)Z")]
		[LineNumberTable(new byte[]
		{
			166, 198, 134, 107, 105, 107, 141, 230, 84, 102,
			233, 44, 104, 159, 2, 103, 109, 101, 110, 106,
			108, 105, 111, 237, 72, 102, 41, 230, 56, 131,
			231, 70, 102, 35, 230, 58, 227, 50, 235, 84,
			102, 230, 61, 135, 102, 35, 2
		})]
		internal virtual bool reclaimValue(object P_0, int P_1, WeakValueReference P_2)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			InternalEntry internalEntry;
			InternalEntry internalEntry2;
			try
			{
				_ = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				internalEntry2 = internalEntry;
			}
			catch
			{
				//try-fault
				unlock();
				throw;
			}
			while (true)
			{
				int result;
				try
				{
					if (internalEntry2 == null)
					{
						break;
					}
					object key = internalEntry2.getKey();
					if (internalEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						WeakValueReference valueReference = ((WeakValueEntry)internalEntry2).getValueReference();
						if (valueReference == P_2)
						{
							modCount++;
							InternalEntry newValue = removeFromChain(internalEntry, internalEntry2);
							int num = count - 1;
							atomicReferenceArray.set(i, newValue);
							count = num;
							System.Threading.Thread.MemoryBarrier();
							result = 1;
							goto IL_00e1;
						}
						goto IL_00ea;
					}
					goto IL_0103;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				IL_00e1:
				unlock();
				return (byte)result != 0;
				IL_00ea:
				int result2;
				try
				{
					result2 = 0;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				unlock();
				return (byte)result2 != 0;
				IL_0103:
				try
				{
					internalEntry2 = internalEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
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
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)Z")]
		[LineNumberTable(new byte[]
		{
			166, 171, 134, 107, 105, 107, 141, 230, 77, 102,
			230, 51, 100, 110, 106, 108, 105, 111, 235, 70,
			102, 39, 230, 58, 227, 57, 235, 77, 102, 230,
			61, 135, 102, 35, 2
		})]
		internal virtual bool reclaimKey(InternalEntry P_0, int P_1)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			InternalEntry internalEntry;
			InternalEntry internalEntry2;
			try
			{
				_ = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				internalEntry2 = internalEntry;
			}
			catch
			{
				//try-fault
				unlock();
				throw;
			}
			while (true)
			{
				int result;
				try
				{
					if (internalEntry2 != null)
					{
						if (internalEntry2 == P_0)
						{
							modCount++;
							InternalEntry newValue = removeFromChain(internalEntry, internalEntry2);
							int num = count - 1;
							atomicReferenceArray.set(i, newValue);
							count = num;
							System.Threading.Thread.MemoryBarrier();
							result = 1;
							goto IL_009c;
						}
						goto IL_00a5;
					}
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				break;
				IL_009c:
				unlock();
				return (byte)result != 0;
				IL_00a5:
				try
				{
					internalEntry2 = internalEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
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
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 80, 0, 0 })]
		[LineNumberTable(1333)]
		internal virtual object getLiveValueForTesting(InternalEntry P_0)
		{
			object liveValue = getLiveValue(castForTesting(P_0));
			_ = null;
			return liveValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;I)TV;")]
		[LineNumberTable(new byte[]
		{
			165, 24, 105, 99, 232, 73, 102, 37, 230, 55,
			162, 103, 99, 134, 134, 102, 35, 2
		})]
		internal virtual object get(object P_0, int P_1)
		{
			InternalEntry liveEntry;
			try
			{
				liveEntry = getLiveEntry(P_0, P_1);
				if (liveEntry == null)
				{
					_ = null;
					goto IL_001f;
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
				object value = liveEntry.getValue();
				if (value == null)
				{
					tryDrainReferenceQueues();
				}
				return value;
			}
			finally
			{
				postReadCleanup();
			}
			IL_001f:
			postReadCleanup();
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;I)TE;")]
		[LineNumberTable(new byte[]
		{
			164, 253, 106, 107, 105, 162, 103, 99, 102, 162,
			116, 226, 52, 233, 81
		})]
		internal virtual InternalEntry getEntry(object P_0, int P_1)
		{
			if (count != 0)
			{
				for (InternalEntry internalEntry = getFirst(P_1); internalEntry != null; internalEntry = internalEntry.getNext())
				{
					if (internalEntry.getHash() == P_1)
					{
						object key = internalEntry.getKey();
						if (key == null)
						{
							tryDrainReferenceQueues();
						}
						else if (map.keyEquivalence.equivalent(P_0, key))
						{
							return internalEntry;
						}
					}
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			165, 41, 106, 105, 246, 69, 102, 37, 230, 59,
			162, 134, 102, 35, 2
		})]
		internal virtual bool containsKey(object P_0, int P_1)
		{
			int result;
			try
			{
				if (count != 0)
				{
					InternalEntry liveEntry = getLiveEntry(P_0, P_1);
					result = ((liveEntry != null && liveEntry.getValue() != null) ? 1 : 0);
					goto IL_0034;
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
			IL_0034:
			postReadCleanup();
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 80, 0, 0 })]
		[LineNumberTable(new byte[] { 167, 42, 104, 102, 130, 103, 99, 102, 162 })]
		internal virtual object getLiveValue(InternalEntry P_0)
		{
			if (P_0.getKey() == null)
			{
				tryDrainReferenceQueues();
				return null;
			}
			object value = P_0.getValue();
			if (value == null)
			{
				tryDrainReferenceQueues();
				return null;
			}
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITV;Z)TV;")]
		[LineNumberTable(new byte[]
		{
			158, 29, 67, 134, 134, 107, 105, 102, 171, 105,
			107, 174, 232, 101, 102, 234, 27, 105, 156, 167,
			137, 100, 110, 105, 105, 110, 236, 87, 102, 47,
			230, 41, 98, 195, 234, 82, 102, 37, 230, 46,
			163, 110, 105, 232, 77, 102, 35, 230, 51, 227,
			40, 237, 101, 102, 230, 56, 110, 124, 105, 105,
			110, 134, 102, 35, 2
		})]
		internal virtual object put(object P_0, int P_1, object P_2, bool P_3)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			InternalEntry internalEntry;
			int num;
			InternalEntry internalEntry2;
			try
			{
				preWriteCleanup();
				num = count + 1;
				if (num > threshold)
				{
					expand();
					num = count + 1;
				}
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				internalEntry2 = internalEntry;
			}
			catch
			{
				//try-fault
				unlock();
				throw;
			}
			while (true)
			{
				object value;
				try
				{
					if (internalEntry2 == null)
					{
						break;
					}
					object key = internalEntry2.getKey();
					if (internalEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						value = internalEntry2.getValue();
						if (value == null)
						{
							modCount++;
							setValue(internalEntry2, P_2);
							num = (count = count);
							System.Threading.Thread.MemoryBarrier();
							_ = null;
							goto IL_00f6;
						}
						goto IL_00fe;
					}
					goto IL_0150;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				IL_00f6:
				unlock();
				return null;
				IL_00fe:
				object result;
				try
				{
					if (P_3)
					{
						result = value;
						goto IL_0116;
					}
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				try
				{
					modCount++;
					setValue(internalEntry2, P_2);
					result = value;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				unlock();
				return result;
				IL_0116:
				unlock();
				return result;
				IL_0150:
				try
				{
					internalEntry2 = internalEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
			}
			try
			{
				modCount++;
				internalEntry2 = map.entryHelper.newEntry(self(), P_0, P_1, internalEntry);
				setValue(internalEntry2, P_2);
				atomicReferenceArray.set(i, internalEntry2);
				count = num;
				System.Threading.Thread.MemoryBarrier();
				_ = null;
			}
			finally
			{
				unlock();
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;I)TV;")]
		[LineNumberTable(new byte[]
		{
			166, 41, 134, 134, 107, 105, 107, 141, 230, 90,
			102, 230, 38, 104, 155, 103, 136, 134, 170, 236,
			78, 102, 47, 230, 50, 162, 110, 106, 108, 105,
			111, 232, 70, 102, 35, 230, 58, 227, 44, 235,
			90, 102, 230, 61, 134, 102, 35, 2
		})]
		internal virtual object remove(object P_0, int P_1)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			InternalEntry internalEntry;
			InternalEntry internalEntry2;
			try
			{
				preWriteCleanup();
				_ = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				internalEntry2 = internalEntry;
			}
			catch
			{
				//try-fault
				unlock();
				throw;
			}
			while (true)
			{
				object value;
				try
				{
					if (internalEntry2 == null)
					{
						break;
					}
					object key = internalEntry2.getKey();
					if (internalEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						value = internalEntry2.getValue();
						if (value != null || isCollected(internalEntry2))
						{
							goto IL_00b5;
						}
						_ = null;
						goto IL_00ad;
					}
					goto IL_010b;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				IL_00ad:
				unlock();
				return null;
				IL_00b5:
				object result;
				try
				{
					modCount++;
					InternalEntry newValue = removeFromChain(internalEntry, internalEntry2);
					int num = count - 1;
					atomicReferenceArray.set(i, newValue);
					count = num;
					System.Threading.Thread.MemoryBarrier();
					result = value;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				unlock();
				return result;
				IL_010b:
				try
				{
					internalEntry2 = internalEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
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
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			166, 81, 134, 134, 107, 105, 107, 141, 230, 91,
			102, 233, 37, 104, 155, 103, 136, 99, 117, 101,
			170, 237, 78, 102, 47, 230, 50, 163, 110, 106,
			108, 105, 111, 232, 70, 102, 35, 230, 58, 227,
			43, 235, 91, 102, 230, 61, 135, 102, 35, 2
		})]
		internal virtual bool remove(object P_0, int P_1, object P_2)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			InternalEntry internalEntry;
			InternalEntry internalEntry2;
			try
			{
				preWriteCleanup();
				_ = count - 1;
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				internalEntry2 = internalEntry;
			}
			catch
			{
				//try-fault
				unlock();
				throw;
			}
			while (true)
			{
				int num;
				int result;
				try
				{
					if (internalEntry2 == null)
					{
						break;
					}
					object key = internalEntry2.getKey();
					if (internalEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						object value = internalEntry2.getValue();
						num = 0;
						if (map.valueEquivalence().equivalent(P_2, value))
						{
							num = 1;
						}
						else if (!isCollected(internalEntry2))
						{
							result = 0;
							goto IL_00c8;
						}
						goto IL_00d1;
					}
					goto IL_0127;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				IL_00c8:
				unlock();
				return (byte)result != 0;
				IL_00d1:
				int result2;
				try
				{
					modCount++;
					InternalEntry newValue = removeFromChain(internalEntry, internalEntry2);
					int num2 = count - 1;
					atomicReferenceArray.set(i, newValue);
					count = num2;
					System.Threading.Thread.MemoryBarrier();
					result2 = num;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				unlock();
				return (byte)result2 != 0;
				IL_0127:
				try
				{
					internalEntry2 = internalEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
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
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITV;TV;)Z")]
		[LineNumberTable(new byte[]
		{
			165, 208, 134, 134, 105, 107, 141, 230, 98, 102,
			233, 30, 104, 159, 2, 170, 104, 103, 104, 107,
			110, 106, 108, 105, 143, 237, 81, 102, 47, 230,
			47, 163, 117, 110, 105, 233, 75, 102, 37, 230,
			53, 195, 231, 71, 102, 35, 230, 57, 227, 37,
			235, 98, 102, 230, 61, 135, 102, 35, 2
		})]
		internal virtual bool replace(object P_0, int P_1, object P_2, object P_3)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			InternalEntry internalEntry;
			InternalEntry internalEntry2;
			try
			{
				preWriteCleanup();
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				internalEntry2 = internalEntry;
			}
			catch
			{
				//try-fault
				unlock();
				throw;
			}
			while (true)
			{
				object value;
				int num;
				try
				{
					if (internalEntry2 == null)
					{
						break;
					}
					object key = internalEntry2.getKey();
					if (internalEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						value = internalEntry2.getValue();
						if (value == null)
						{
							if (isCollected(internalEntry2))
							{
								_ = count - 1;
								modCount++;
								InternalEntry newValue = removeFromChain(internalEntry, internalEntry2);
								num = count - 1;
								atomicReferenceArray.set(i, newValue);
								count = num;
								System.Threading.Thread.MemoryBarrier();
							}
							num = 0;
							goto IL_00f5;
						}
						goto IL_00fe;
					}
					goto IL_0160;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				IL_00f5:
				unlock();
				return (byte)num != 0;
				IL_00fe:
				try
				{
					if (map.valueEquivalence().equivalent(P_2, value))
					{
						modCount++;
						setValue(internalEntry2, P_3);
						num = 1;
						goto IL_013e;
					}
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				try
				{
					num = 0;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				unlock();
				return (byte)num != 0;
				IL_013e:
				unlock();
				return (byte)num != 0;
				IL_0160:
				try
				{
					internalEntry2 = internalEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
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
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITV;)TV;")]
		[LineNumberTable(new byte[]
		{
			165,
			byte.MaxValue,
			134,
			134,
			105,
			107,
			141,
			230,
			92,
			102,
			233,
			36,
			104,
			159,
			2,
			170,
			104,
			100,
			104,
			107,
			110,
			106,
			108,
			105,
			143,
			236,
			75,
			102,
			41,
			230,
			53,
			162,
			110,
			104,
			232,
			70,
			102,
			35,
			230,
			58,
			227,
			42,
			235,
			92,
			102,
			230,
			61,
			134,
			102,
			35,
			2
		})]
		internal virtual object replace(object P_0, int P_1, object P_2)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			InternalEntry internalEntry;
			InternalEntry internalEntry2;
			try
			{
				preWriteCleanup();
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				internalEntry2 = internalEntry;
			}
			catch
			{
				//try-fault
				unlock();
				throw;
			}
			while (true)
			{
				object value;
				try
				{
					if (internalEntry2 == null)
					{
						break;
					}
					object key = internalEntry2.getKey();
					if (internalEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						value = internalEntry2.getValue();
						if (value == null)
						{
							if (isCollected(internalEntry2))
							{
								_ = count - 1;
								modCount++;
								InternalEntry newValue = removeFromChain(internalEntry, internalEntry2);
								int num = count - 1;
								atomicReferenceArray.set(i, newValue);
								count = num;
								System.Threading.Thread.MemoryBarrier();
							}
							_ = null;
							goto IL_00eb;
						}
						goto IL_00f3;
					}
					goto IL_0123;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				IL_00eb:
				unlock();
				return null;
				IL_00f3:
				object result;
				try
				{
					modCount++;
					setValue(internalEntry2, P_2);
					result = value;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				unlock();
				return result;
				IL_0123:
				try
				{
					internalEntry2 = internalEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
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
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			166, 122, 109, 134, 105, 107, 40, 166, 102, 140,
			110, 146, 102, 35, 98, 130
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
				AtomicReferenceArray atomicReferenceArray = table;
				for (int i = 0; i < atomicReferenceArray.length(); i++)
				{
					atomicReferenceArray.set(i, null);
				}
				maybeClearReferenceQueues();
				readCount.set(0);
				modCount++;
				count = 0;
				System.Threading.Thread.MemoryBarrier();
			}
			finally
			{
				unlock();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 76, 104 })]
		internal virtual void runCleanup()
		{
			runLockedCleanup();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 61, 112, 136 })]
		internal virtual void postReadCleanup()
		{
			if ((readCount.incrementAndGet() & 0x3F) == 0)
			{
				runCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/concurrent/atomic/AtomicReferenceArray<TE;>;")]
		[LineNumberTable(1238)]
		internal virtual AtomicReferenceArray newEntryArray(int P_0)
		{
			AtomicReferenceArray result = new AtomicReferenceArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/concurrent/atomic/AtomicReferenceArray<TE;>;)V")]
		[LineNumberTable(new byte[] { 164, 104, 112, 142, 142, 110 })]
		internal virtual void initTable(AtomicReferenceArray P_0)
		{
			threshold = P_0.length() * 3 / 4;
			if (threshold == maxSegmentSize)
			{
				threshold++;
			}
			table = P_0;
			System.Threading.Thread.MemoryBarrier();
		}

		[Signature("()TS;")]
		internal abstract Segment self();

		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)TE;")]
		internal abstract InternalEntry castForTesting(InternalEntry P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(new byte[]
		{
			167, 8, 103, 107, 105, 107, 141, 103, 101, 110,
			107, 108, 105, 111, 226, 57, 235, 75
		})]
		internal virtual bool removeEntryForTesting(InternalEntry P_0)
		{
			int hash = P_0.getHash();
			_ = count - 1;
			AtomicReferenceArray atomicReferenceArray = table;
			int i = hash & (atomicReferenceArray.length() - 1);
			InternalEntry internalEntry = (InternalEntry)atomicReferenceArray.get(i);
			for (InternalEntry internalEntry2 = internalEntry; internalEntry2 != null; internalEntry2 = internalEntry2.getNext())
			{
				if (internalEntry2 == P_0)
				{
					modCount++;
					InternalEntry newValue = removeFromChain(internalEntry, internalEntry2);
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
		[Signature("(TE;TE;)TE;")]
		[LineNumberTable(new byte[]
		{
			166, 154, 105, 103, 102, 105, 99, 132, 228, 59,
			233, 72, 110
		})]
		internal virtual InternalEntry removeFromChain(InternalEntry P_0, InternalEntry P_1)
		{
			int num = count;
			InternalEntry internalEntry = P_1.getNext();
			for (InternalEntry internalEntry2 = P_0; internalEntry2 != P_1; internalEntry2 = internalEntry2.getNext())
			{
				InternalEntry internalEntry3 = copyEntry(internalEntry2, internalEntry);
				if (internalEntry3 != null)
				{
					internalEntry = internalEntry3;
				}
				else
				{
					num += -1;
				}
			}
			count = num;
			System.Threading.Thread.MemoryBarrier();
			return internalEntry;
		}

		internal virtual void maybeDrainReferenceQueues()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(new byte[] { 164, 246, 105 })]
		internal virtual InternalEntry getFirst(int P_0)
		{
			AtomicReferenceArray atomicReferenceArray = table;
			return (InternalEntry)atomicReferenceArray.get(P_0 & (atomicReferenceArray.length() - 1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 202, 136, 138, 102, 35, 98, 130 })]
		internal virtual void tryDrainReferenceQueues()
		{
			if (tryLock())
			{
				try
				{
					maybeDrainReferenceQueues();
				}
				finally
				{
					unlock();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;I)TE;")]
		[LineNumberTable(1413)]
		internal virtual InternalEntry getLiveEntry(object P_0, int P_1)
		{
			InternalEntry entry = getEntry(P_0, P_1);
			_ = null;
			return entry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 72, 104 })]
		internal virtual void preWriteCleanup()
		{
			runLockedCleanup();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			165, 141, 105, 103, 104, 225, 77, 105, 106, 112,
			106, 171, 143, 103, 105, 172, 100, 239, 69, 100,
			100, 104, 108, 134, 100, 228, 59, 235, 72, 170,
			106, 108, 111, 108, 100, 140, 228, 57, 235, 35,
			235, 106, 105, 110
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
				InternalEntry internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				if (internalEntry == null)
				{
					continue;
				}
				InternalEntry next = internalEntry.getNext();
				int num4 = internalEntry.getHash() & num3;
				if (next == null)
				{
					atomicReferenceArray2.set(num4, internalEntry);
					continue;
				}
				InternalEntry internalEntry2 = internalEntry;
				int num5 = num4;
				for (InternalEntry internalEntry3 = next; internalEntry3 != null; internalEntry3 = internalEntry3.getNext())
				{
					int num6 = internalEntry3.getHash() & num3;
					if (num6 != num5)
					{
						num5 = num6;
						internalEntry2 = internalEntry3;
					}
				}
				atomicReferenceArray2.set(num5, internalEntry2);
				for (InternalEntry internalEntry3 = internalEntry; internalEntry3 != internalEntry2; internalEntry3 = internalEntry3.getNext())
				{
					int num6 = internalEntry3.getHash() & num3;
					InternalEntry internalEntry4 = (InternalEntry)atomicReferenceArray2.get(num6);
					InternalEntry internalEntry5 = copyEntry(internalEntry3, internalEntry4);
					if (internalEntry5 != null)
					{
						atomicReferenceArray2.set(num6, internalEntry5);
					}
					else
					{
						num2 += -1;
					}
				}
			}
			table = atomicReferenceArray2;
			count = num2;
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TV;)V")]
		[LineNumberTable(new byte[] { 164, 91, 122 })]
		internal virtual void setValue(InternalEntry P_0, object P_1)
		{
			map.entryHelper.setValue(self(), P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>(TE;)Z")]
		[LineNumberTable(1939)]
		internal static bool isCollected(InternalEntry P_0)
		{
			return P_0.getValue() == null;
		}

		internal virtual void maybeClearReferenceQueues()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 80, 136, 102, 144, 102, 35, 98, 130 })]
		internal virtual void runLockedCleanup()
		{
			if (tryLock())
			{
				try
				{
					maybeDrainReferenceQueues();
					readCount.set(0);
				}
				finally
				{
					unlock();
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>;II)V")]
		[LineNumberTable(new byte[] { 164, 68, 8, 171, 103, 103, 111 })]
		internal Segment(MapMakerInternalMap P_0, int P_1, int P_2)
		{
			readCount = new AtomicInteger();
			map = P_0;
			maxSegmentSize = P_2;
			initTable(newEntryArray(P_1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/lang/ref/ReferenceQueue<TK;>;")]
		[LineNumberTable(1263)]
		internal virtual ReferenceQueue getKeyReferenceQueueForTesting()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/lang/ref/ReferenceQueue<TV;>;")]
		[LineNumberTable(1268)]
		internal virtual ReferenceQueue getValueReferenceQueueForTesting()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;")]
		[LineNumberTable(1273)]
		internal virtual WeakValueReference getWeakValueReferenceForTesting(InternalEntry P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;TV;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;")]
		[LineNumberTable(1282)]
		internal virtual WeakValueReference newWeakValueReferenceForTesting(InternalEntry P_0, object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;+Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;>;)V")]
		[LineNumberTable(1292)]
		internal virtual void setWeakValueReferenceForTesting(InternalEntry P_0, WeakValueReference P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)V")]
		[LineNumberTable(new byte[] { 164, 161, 119 })]
		internal virtual void setTableEntryForTesting(int P_0, InternalEntry P_1)
		{
			table.set(P_0, castForTesting(P_1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)TE;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 1, 0, 0, 80, 0, 0 })]
		[LineNumberTable(1304)]
		internal virtual InternalEntry copyForTesting(InternalEntry P_0, InternalEntry P_1)
		{
			InternalEntry result = map.entryHelper.copy(self(), castForTesting(P_0), castForTesting(P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;TV;)V")]
		[LineNumberTable(new byte[] { 164, 171, 127, 1 })]
		internal virtual void setValueForTesting(InternalEntry P_0, object P_1)
		{
			map.entryHelper.setValue(self(), castForTesting(P_0), P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)TE;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 80, 0, 0 })]
		[LineNumberTable(1314)]
		internal virtual InternalEntry newEntryForTesting(object P_0, int P_1, InternalEntry P_2)
		{
			InternalEntry result = map.entryHelper.newEntry(self(), P_0, P_1, castForTesting(P_2));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Z")]
		[LineNumberTable(1320)]
		internal virtual bool removeTableEntryForTesting(InternalEntry P_0)
		{
			bool result = removeEntryForTesting(castForTesting(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)TE;")]
		[LineNumberTable(1325)]
		internal virtual InternalEntry removeFromChainForTesting(InternalEntry P_0, InternalEntry P_1)
		{
			InternalEntry result = removeFromChain(castForTesting(P_0), castForTesting(P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;)V")]
		[LineNumberTable(new byte[] { 164, 214, 98, 138, 103, 108, 105, 130, 98 })]
		internal virtual void drainKeyReferenceQueue(ReferenceQueue P_0)
		{
			int num = 0;
			Reference reference;
			while ((reference = P_0.poll()) != null)
			{
				InternalEntry internalEntry = (InternalEntry)reference;
				map.reclaimKey(internalEntry);
				num++;
				if (num == 16)
				{
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;)V")]
		[LineNumberTable(new byte[] { 164, 228, 98, 138, 103, 108, 105, 130, 98 })]
		internal virtual void drainValueReferenceQueue(ReferenceQueue P_0)
		{
			int num = 0;
			Reference reference;
			while ((reference = P_0.poll()) != null)
			{
				WeakValueReference weakValueReference = (WeakValueReference)reference;
				map.reclaimValue(weakValueReference);
				num++;
				if (num == 16)
				{
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(Ljava/lang/ref/ReferenceQueue<TT;>;)V")]
		[LineNumberTable(new byte[] { 164, 240, 106 })]
		internal virtual void clearReferenceQueue(ReferenceQueue P_0)
		{
			while (P_0.poll() != null)
			{
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			165, 59, 106, 105, 103, 232, 79, 102, 236, 49,
			243, 78, 102, 235, 50, 105, 100, 130, 117, 235,
			72, 102, 39, 230, 56, 227, 58, 235, 78, 102,
			230, 48, 232, 79, 102, 230, 61, 135, 102, 35,
			2
		})]
		internal virtual bool containsValue(object P_0)
		{
			AtomicReferenceArray atomicReferenceArray;
			int num;
			int num2;
			try
			{
				if (count != 0)
				{
					atomicReferenceArray = table;
					num = atomicReferenceArray.length();
					num2 = 0;
					goto IL_0030;
				}
			}
			catch
			{
				//try-fault
				postReadCleanup();
				throw;
			}
			goto IL_00c8;
			IL_0030:
			while (true)
			{
				InternalEntry internalEntry;
				try
				{
					if (num2 < num)
					{
						internalEntry = (InternalEntry)atomicReferenceArray.get(num2);
						goto IL_0055;
					}
				}
				catch
				{
					//try-fault
					postReadCleanup();
					throw;
				}
				break;
				IL_0055:
				while (true)
				{
					int result;
					try
					{
						if (internalEntry != null)
						{
							object liveValue = getLiveValue(internalEntry);
							if (liveValue == null || !map.valueEquivalence().equivalent(P_0, liveValue))
							{
								goto IL_009d;
							}
							result = 1;
							goto IL_0094;
						}
					}
					catch
					{
						//try-fault
						postReadCleanup();
						throw;
					}
					break;
					IL_0094:
					postReadCleanup();
					return (byte)result != 0;
					IL_009d:
					try
					{
						internalEntry = internalEntry.getNext();
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
					num2++;
				}
				catch
				{
					//try-fault
					postReadCleanup();
					throw;
				}
			}
			goto IL_00c8;
			IL_00c8:
			try
			{
				return false;
			}
			finally
			{
				postReadCleanup();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;+Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;>;)Z")]
		[LineNumberTable(new byte[]
		{
			166, 235, 134, 105, 107, 141, 230, 81, 102, 233,
			47, 104, 155, 103, 109, 101, 106, 105, 237, 72,
			102, 41, 230, 56, 131, 231, 70, 102, 35, 230,
			58, 227, 53, 235, 81, 102, 230, 61, 135, 102,
			35, 2
		})]
		internal virtual bool clearValueForTesting(object P_0, int P_1, WeakValueReference P_2)
		{
			@lock();
			AtomicReferenceArray atomicReferenceArray;
			int i;
			InternalEntry internalEntry;
			InternalEntry internalEntry2;
			try
			{
				atomicReferenceArray = table;
				i = P_1 & (atomicReferenceArray.length() - 1);
				internalEntry = (InternalEntry)atomicReferenceArray.get(i);
				internalEntry2 = internalEntry;
			}
			catch
			{
				//try-fault
				unlock();
				throw;
			}
			while (true)
			{
				int result;
				try
				{
					if (internalEntry2 == null)
					{
						break;
					}
					object key = internalEntry2.getKey();
					if (internalEntry2.getHash() == P_1 && key != null && map.keyEquivalence.equivalent(P_0, key))
					{
						WeakValueReference valueReference = ((WeakValueEntry)internalEntry2).getValueReference();
						if (valueReference == P_2)
						{
							InternalEntry newValue = removeFromChain(internalEntry, internalEntry2);
							atomicReferenceArray.set(i, newValue);
							result = 1;
							goto IL_00a7;
						}
						goto IL_00b0;
					}
					goto IL_00c9;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				IL_00a7:
				unlock();
				return (byte)result != 0;
				IL_00b0:
				int result2;
				try
				{
					result2 = 0;
				}
				catch
				{
					//try-fault
					unlock();
					throw;
				}
				unlock();
				return (byte)result2 != 0;
				IL_00c9:
				try
				{
					internalEntry2 = internalEntry2.getNext();
				}
				catch
				{
					//try-fault
					unlock();
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
			}
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Segment(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$AbstractSerializationProxy<TK;TV;>;")]
	internal sealed class SerializationProxy : AbstractSerializationProxy, IObjectReference
	{
		private const long serialVersionUID = 3L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$Strength;Lcom/google/common/collect/MapMakerInternalMap$Strength;Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;ILjava/util/concurrent/ConcurrentMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 170, 252, 145 })]
		internal SerializationProxy(Strength P_0, Strength P_1, Equivalence P_2, Equivalence P_3, int P_4, ConcurrentMap P_5)
			: base(P_0, P_1, P_2, P_3, P_4, P_5)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 171, 1, 102, 105 })]
		private void writeObject(ObjectOutputStream P_0)
		{
			P_0.defaultWriteObject();
			base.writeMapTo(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 171, 6, 102, 104, 108, 105 })]
		private void readObject(ObjectInputStream P_0)
		{
			P_0.defaultReadObject();
			MapMaker mapMaker = base.readMapMaker(P_0);
			base.@delegate = mapMaker.makeMap();
			base.readEntries(P_0);
		}

		private object readResolve()
		{
			return base.@delegate;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SerializationProxy(SerializationInfo P_0, StreamingContext P_1)
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

	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/MapMakerInternalMap$Strength;>;")]
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
			[LineNumberTable(249)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
			[LineNumberTable(252)]
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
			[LineNumberTable(256)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
			[LineNumberTable(259)]
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

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Strength STRONG;

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
		[Signature("()V")]
		[LineNumberTable(248)]
		private Strength(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(248)]
		private static Strength[] _0024values()
		{
			return new Strength[2] { STRONG, WEAK };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(248)]
		public static Strength[] values()
		{
			return (Strength[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(248)]
		public static Strength valueOf(string P_0)
		{
			return (Strength)java.lang.Enum.valueOf(ClassLiteral<Strength>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(248)]
		internal Strength(string P_0, int P_1, MapMakerInternalMap._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 160, 135, 240, 71, 240, 56 })]
		static Strength()
		{
			STRONG = new _1("STRONG", 0);
			WEAK = new _2("WEAK", 1);
			_0024VALUES = _0024values();
		}
	}

	[Signature("<K:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$AbstractStrongKeyEntry<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;>;Lcom/google/common/collect/MapMakerInternalMap$StrongValueEntry<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;>;")]
	[ConstantPool(new object[]
	{
		(byte)32,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$StrongValueEntry" })]
	internal sealed class StrongKeyDummyValueEntry : AbstractStrongKeyEntry, StrongValueEntry, InternalEntry
	{
		[Signature("<K:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntryHelper<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;>;")]
		[ConstantPool(new object[]
		{
			(byte)63,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class Helper : java.lang.Object, InternalEntryHelper
		{
			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
			[Signature("Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry$Helper<*>;")]
			private static Helper INSTANCE;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[Signature("<K:Ljava/lang/Object;>()Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry$Helper<TK;>;")]
			internal static Helper instance()
			{
				return INSTANCE;
			}

			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMaker$Dummy;)V")]
			public virtual void setValue(StrongKeyDummyValueSegment P_0, StrongKeyDummyValueEntry P_1, MapMaker.Dummy P_2)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 63, 0, 0 })]
			[LineNumberTable(630)]
			public virtual StrongKeyDummyValueEntry copy(StrongKeyDummyValueSegment P_0, StrongKeyDummyValueEntry P_1, StrongKeyDummyValueEntry P_2)
			{
				StrongKeyDummyValueEntry result = P_1.copy(P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;TK;ILcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 63, 0, 0 })]
			[LineNumberTable(643)]
			public virtual StrongKeyDummyValueEntry newEntry(StrongKeyDummyValueSegment P_0, object P_1, int P_2, StrongKeyDummyValueEntry P_3)
			{
				StrongKeyDummyValueEntry result = new StrongKeyDummyValueEntry(P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;>;II)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;")]
			[LineNumberTable(622)]
			public virtual StrongKeyDummyValueSegment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				StrongKeyDummyValueSegment result = new StrongKeyDummyValueSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(596)]
			internal Helper()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(608)]
			public virtual Strength keyStrength()
			{
				return Strength.STRONG;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(613)]
			public virtual Strength valueStrength()
			{
				return Strength.STRONG;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(596)]
			public virtual void setValue(Segment P_0, InternalEntry P_1, object P_2)
			{
				setValue((StrongKeyDummyValueSegment)P_0, (StrongKeyDummyValueEntry)P_1, (MapMaker.Dummy)P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 63, 0, 0 })]
			[LineNumberTable(596)]
			public virtual InternalEntry copy(Segment P_0, InternalEntry P_1, InternalEntry P_2)
			{
				StrongKeyDummyValueEntry result = copy((StrongKeyDummyValueSegment)P_0, (StrongKeyDummyValueEntry)P_1, (StrongKeyDummyValueEntry)P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 63, 0, 0 })]
			[LineNumberTable(596)]
			public virtual InternalEntry newEntry(Segment P_0, object P_1, int P_2, InternalEntry P_3)
			{
				StrongKeyDummyValueEntry result = newEntry((StrongKeyDummyValueSegment)P_0, P_1, P_2, (StrongKeyDummyValueEntry)P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(596)]
			public virtual Segment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				StrongKeyDummyValueSegment result = this.newSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[LineNumberTable(599)]
			static Helper()
			{
				INSTANCE = new Helper();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;")]
		[LineNumberTable(589)]
		internal virtual StrongKeyDummyValueEntry copy(StrongKeyDummyValueEntry P_0)
		{
			StrongKeyDummyValueEntry result = new StrongKeyDummyValueEntry(key, hash, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 32, 0, 0 })]
		[LineNumberTable(new byte[] { 161, 208, 107 })]
		internal StrongKeyDummyValueEntry(object P_0, int P_1, StrongKeyDummyValueEntry P_2)
			: base(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(583)]
		public new virtual MapMaker.Dummy getValue()
		{
			return MapMaker.Dummy.VALUE;
		}

		internal virtual void setValue(MapMaker.Dummy P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(574)]
		public override object getValue()
		{
			MapMaker.Dummy value = getValue();
			_ = null;
			return value;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;>;")]
	internal sealed class StrongKeyDummyValueSegment : Segment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;>;II)V")]
		[LineNumberTable(new byte[] { 167, 188, 107 })]
		internal StrongKeyDummyValueSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			: base(P_0, P_1, P_2)
		{
		}

		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;Lcom/google/common/collect/MapMaker$Dummy;*>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueEntry<TK;>;")]
		[LineNumberTable(2105)]
		public new virtual StrongKeyDummyValueEntry castForTesting(InternalEntry P_0)
		{
			return (StrongKeyDummyValueEntry)P_0;
		}

		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$StrongKeyDummyValueSegment<TK;>;")]
		internal new virtual StrongKeyDummyValueSegment self()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2087)]
		public override InternalEntry castForTesting(InternalEntry P_0)
		{
			StrongKeyDummyValueEntry result = castForTesting(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2087)]
		internal override Segment self()
		{
			StrongKeyDummyValueSegment result = self();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected StrongKeyDummyValueSegment(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$AbstractStrongKeyEntry<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;>;Lcom/google/common/collect/MapMakerInternalMap$StrongValueEntry<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;>;")]
	[ConstantPool(new object[]
	{
		(byte)18,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$StrongValueEntry" })]
	internal sealed class StrongKeyStrongValueEntry : AbstractStrongKeyEntry, StrongValueEntry, InternalEntry
	{
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntryHelper<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;>;")]
		[ConstantPool(new object[]
		{
			(byte)62,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class Helper : java.lang.Object, InternalEntryHelper
		{
			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
			[Signature("Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry$Helper<**>;")]
			private static Helper INSTANCE;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry$Helper<TK;TV;>;")]
			internal static Helper instance()
			{
				return INSTANCE;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;TV;)V")]
			[LineNumberTable(new byte[] { 161, 92, 105 })]
			public virtual void setValue(StrongKeyStrongValueSegment P_0, StrongKeyStrongValueEntry P_1, object P_2)
			{
				P_1.setValue(P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 62, 0, 0 })]
			[LineNumberTable(454)]
			public virtual StrongKeyStrongValueEntry copy(StrongKeyStrongValueSegment P_0, StrongKeyStrongValueEntry P_1, StrongKeyStrongValueEntry P_2)
			{
				StrongKeyStrongValueEntry result = P_1.copy(P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;TK;ILcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 62, 0, 0 })]
			[LineNumberTable(471)]
			public virtual StrongKeyStrongValueEntry newEntry(StrongKeyStrongValueSegment P_0, object P_1, int P_2, StrongKeyStrongValueEntry P_3)
			{
				StrongKeyStrongValueEntry result = new StrongKeyStrongValueEntry(P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;>;II)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;")]
			[LineNumberTable(446)]
			public virtual StrongKeyStrongValueSegment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				StrongKeyStrongValueSegment result = new StrongKeyStrongValueSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(419)]
			internal Helper()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(431)]
			public virtual Strength keyStrength()
			{
				return Strength.STRONG;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(436)]
			public virtual Strength valueStrength()
			{
				return Strength.STRONG;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(419)]
			public virtual void setValue(Segment P_0, InternalEntry P_1, object P_2)
			{
				setValue((StrongKeyStrongValueSegment)P_0, (StrongKeyStrongValueEntry)P_1, P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 62, 0, 0 })]
			[LineNumberTable(419)]
			public virtual InternalEntry copy(Segment P_0, InternalEntry P_1, InternalEntry P_2)
			{
				StrongKeyStrongValueEntry result = copy((StrongKeyStrongValueSegment)P_0, (StrongKeyStrongValueEntry)P_1, (StrongKeyStrongValueEntry)P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 62, 0, 0 })]
			[LineNumberTable(419)]
			public virtual InternalEntry newEntry(Segment P_0, object P_1, int P_2, InternalEntry P_3)
			{
				StrongKeyStrongValueEntry result = newEntry((StrongKeyStrongValueSegment)P_0, P_1, P_2, (StrongKeyStrongValueEntry)P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(419)]
			public virtual Segment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				StrongKeyStrongValueSegment result = this.newSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[LineNumberTable(422)]
			static Helper()
			{
				INSTANCE = new Helper();
			}
		}

		[Signature("TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 18, 0, 0 })]
		private volatile object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 42, 147, 117 })]
		internal virtual StrongKeyStrongValueEntry copy(StrongKeyStrongValueEntry P_0)
		{
			StrongKeyStrongValueEntry strongKeyStrongValueEntry = new StrongKeyStrongValueEntry(key, hash, P_0);
			strongKeyStrongValueEntry.value = value;
			System.Threading.Thread.MemoryBarrier();
			return strongKeyStrongValueEntry;
		}

		[Signature("(TV;)V")]
		internal virtual void setValue(object P_0)
		{
			value = P_0;
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 18, 0, 0 })]
		[LineNumberTable(new byte[] { 161, 29, 235, 61, 206 })]
		internal StrongKeyStrongValueEntry(object P_0, int P_1, StrongKeyStrongValueEntry P_2)
			: base(P_0, P_1, P_2)
		{
			value = null;
			System.Threading.Thread.MemoryBarrier();
		}

		[Signature("()TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 18, 0, 0 })]
		public override object getValue()
		{
			return value;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;>;")]
	internal sealed class StrongKeyStrongValueSegment : Segment
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;>;II)V")]
		[LineNumberTable(new byte[] { 167, 100, 107 })]
		internal StrongKeyStrongValueSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			: base(P_0, P_1, P_2)
		{
		}

		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueEntry<TK;TV;>;")]
		[LineNumberTable(2017)]
		public new virtual StrongKeyStrongValueEntry castForTesting(InternalEntry P_0)
		{
			return (StrongKeyStrongValueEntry)P_0;
		}

		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$StrongKeyStrongValueSegment<TK;TV;>;")]
		internal new virtual StrongKeyStrongValueSegment self()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1998)]
		public override InternalEntry castForTesting(InternalEntry P_0)
		{
			StrongKeyStrongValueEntry result = castForTesting(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1998)]
		internal override Segment self()
		{
			StrongKeyStrongValueSegment result = self();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected StrongKeyStrongValueSegment(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$AbstractStrongKeyEntry<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;>;Lcom/google/common/collect/MapMakerInternalMap$WeakValueEntry<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;>;")]
	[ConstantPool(new object[]
	{
		(byte)42,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$WeakValueEntry" })]
	internal sealed class StrongKeyWeakValueEntry : AbstractStrongKeyEntry, WeakValueEntry, InternalEntry
	{
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntryHelper<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;>;")]
		[ConstantPool(new object[]
		{
			(byte)66,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class Helper : java.lang.Object, InternalEntryHelper
		{
			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
			[Signature("Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry$Helper<**>;")]
			private static Helper INSTANCE;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry$Helper<TK;TV;>;")]
			internal static Helper instance()
			{
				return INSTANCE;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;TV;)V")]
			[LineNumberTable(new byte[] { 161, 189, 111 })]
			public virtual void setValue(StrongKeyWeakValueSegment P_0, StrongKeyWeakValueEntry P_1, object P_2)
			{
				P_1.setValue(P_2, StrongKeyWeakValueSegment.access_0024100(P_0));
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 66, 0, 0 })]
			[LineNumberTable(new byte[] { 161, 180, 104, 130 })]
			public virtual StrongKeyWeakValueEntry copy(StrongKeyWeakValueSegment P_0, StrongKeyWeakValueEntry P_1, StrongKeyWeakValueEntry P_2)
			{
				if (Segment.isCollected(P_1))
				{
					return null;
				}
				StrongKeyWeakValueEntry result = P_1.copy(StrongKeyWeakValueSegment.access_0024100(P_0), P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;TK;ILcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 66, 0, 0 })]
			[LineNumberTable(568)]
			public virtual StrongKeyWeakValueEntry newEntry(StrongKeyWeakValueSegment P_0, object P_1, int P_2, StrongKeyWeakValueEntry P_3)
			{
				StrongKeyWeakValueEntry result = new StrongKeyWeakValueEntry(P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;>;II)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;")]
			[LineNumberTable(542)]
			public virtual StrongKeyWeakValueSegment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				StrongKeyWeakValueSegment result = new StrongKeyWeakValueSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(516)]
			internal Helper()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(528)]
			public virtual Strength keyStrength()
			{
				return Strength.STRONG;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(533)]
			public virtual Strength valueStrength()
			{
				return Strength.WEAK;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(516)]
			public virtual void setValue(Segment P_0, InternalEntry P_1, object P_2)
			{
				setValue((StrongKeyWeakValueSegment)P_0, (StrongKeyWeakValueEntry)P_1, P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 66, 0, 0 })]
			[LineNumberTable(516)]
			public virtual InternalEntry copy(Segment P_0, InternalEntry P_1, InternalEntry P_2)
			{
				StrongKeyWeakValueEntry result = copy((StrongKeyWeakValueSegment)P_0, (StrongKeyWeakValueEntry)P_1, (StrongKeyWeakValueEntry)P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 66, 0, 0 })]
			[LineNumberTable(516)]
			public virtual InternalEntry newEntry(Segment P_0, object P_1, int P_2, InternalEntry P_3)
			{
				StrongKeyWeakValueEntry result = newEntry((StrongKeyWeakValueSegment)P_0, P_1, P_2, (StrongKeyWeakValueEntry)P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(516)]
			public virtual Segment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				StrongKeyWeakValueSegment result = this.newSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[LineNumberTable(519)]
			static Helper()
			{
				INSTANCE = new Helper();
			}
		}

		[Signature("Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;>;")]
		private volatile WeakValueReference valueReference;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 135, 115, 124 })]
		internal virtual StrongKeyWeakValueEntry copy(ReferenceQueue P_0, StrongKeyWeakValueEntry P_1)
		{
			StrongKeyWeakValueEntry strongKeyWeakValueEntry = new StrongKeyWeakValueEntry(key, hash, P_1);
			strongKeyWeakValueEntry.valueReference = valueReference.copyFor(P_0, strongKeyWeakValueEntry);
			System.Threading.Thread.MemoryBarrier();
			return strongKeyWeakValueEntry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;Ljava/lang/ref/ReferenceQueue<TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 128, 105, 117, 104 })]
		internal virtual void setValue(object P_0, ReferenceQueue P_1)
		{
			WeakValueReference weakValueReference = valueReference;
			valueReference = new WeakValueReferenceImpl(P_1, P_0, this);
			System.Threading.Thread.MemoryBarrier();
			weakValueReference.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ILcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 42, 0, 0 })]
		[LineNumberTable(new byte[] { 161, 114, 235, 60, 97, 209 })]
		internal StrongKeyWeakValueEntry(object P_0, int P_1, StrongKeyWeakValueEntry P_2)
			: base(P_0, P_1, P_2)
		{
			valueReference = unsetWeakValueReference();
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(489)]
		public override object getValue()
		{
			object result = valueReference.get();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 124, 111 })]
		public virtual void clearValue()
		{
			valueReference.clear();
		}

		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;>;")]
		public virtual WeakValueReference getValueReference()
		{
			return valueReference;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(477)]
		internal static WeakValueReference access_0024600(StrongKeyWeakValueEntry P_0)
		{
			return P_0.valueReference;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(477)]
		internal static WeakValueReference access_0024602(StrongKeyWeakValueEntry P_0, WeakValueReference P_1)
		{
			P_0.valueReference = P_1;
			System.Threading.Thread.MemoryBarrier();
			return P_1;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;>;")]
	internal sealed class StrongKeyWeakValueSegment : Segment
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/ref/ReferenceQueue<TV;>;")]
		private ReferenceQueue queueForValues;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;>;II)V")]
		[LineNumberTable(new byte[] { 167, 125, 235, 57, 235, 72 })]
		internal StrongKeyWeakValueSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			: base(P_0, P_1, P_2)
		{
			queueForValues = new ReferenceQueue();
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(2022)]
		internal static ReferenceQueue access_0024100(StrongKeyWeakValueSegment P_0)
		{
			return P_0.queueForValues;
		}

		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;")]
		[LineNumberTable(2047)]
		public new virtual StrongKeyWeakValueEntry castForTesting(InternalEntry P_0)
		{
			return (StrongKeyWeakValueEntry)P_0;
		}

		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueSegment<TK;TV;>;")]
		internal new virtual StrongKeyWeakValueSegment self()
		{
			return this;
		}

		[Signature("()Ljava/lang/ref/ReferenceQueue<TV;>;")]
		internal override ReferenceQueue getValueReferenceQueueForTesting()
		{
			return queueForValues;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;>;")]
		[LineNumberTable(2053)]
		public override WeakValueReference getWeakValueReferenceForTesting(InternalEntry P_0)
		{
			WeakValueReference valueReference = castForTesting(P_0).getValueReference();
			_ = null;
			return valueReference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;TV;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$StrongKeyWeakValueEntry<TK;TV;>;>;")]
		[LineNumberTable(2059)]
		public override WeakValueReference newWeakValueReferenceForTesting(InternalEntry P_0, object P_1)
		{
			WeakValueReferenceImpl result = new WeakValueReferenceImpl(queueForValues, P_1, castForTesting(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;+Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;>;)V")]
		[LineNumberTable(new byte[] { 167, 160, 136, 130, 103, 104, 104 })]
		public override void setWeakValueReferenceForTesting(InternalEntry P_0, WeakValueReference P_1)
		{
			StrongKeyWeakValueEntry strongKeyWeakValueEntry = castForTesting(P_0);
			WeakValueReference weakValueReference = StrongKeyWeakValueEntry.access_0024600(strongKeyWeakValueEntry);
			StrongKeyWeakValueEntry.access_0024602(strongKeyWeakValueEntry, P_1);
			weakValueReference.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 171, 110 })]
		internal override void maybeDrainReferenceQueues()
		{
			base.drainValueReferenceQueue(queueForValues);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 176, 110 })]
		internal override void maybeClearReferenceQueues()
		{
			base.clearReferenceQueue(queueForValues);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2022)]
		public override InternalEntry castForTesting(InternalEntry P_0)
		{
			StrongKeyWeakValueEntry result = castForTesting(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2022)]
		internal override Segment self()
		{
			StrongKeyWeakValueSegment result = self();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected StrongKeyWeakValueSegment(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;")]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$InternalEntry" })]
	internal interface StrongValueEntry : InternalEntry
	{
	}

	[InnerClass(null, Modifiers.Final)]
	[Signature("Lcom/google/common/collect/MapMakerInternalMap<TK;TV;TE;TS;>.HashIterator<TV;>;")]
	internal sealed class ValueIterator : HashIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2619)]
		internal ValueIterator(MapMakerInternalMap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(2623)]
		public override object next()
		{
			object value = base.nextEntry().getValue();
			_ = null;
			return value;
		}
	}

	[Signature("Ljava/util/AbstractCollection<TV;>;")]
	internal sealed class Values : AbstractCollection
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MapMakerInternalMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2717)]
		internal Values(MapMakerInternalMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(2721)]
		public override Iterator iterator()
		{
			ValueIterator result = new ValueIterator(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2726)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2731)]
		public override bool isEmpty()
		{
			bool result = this_00240.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2736)]
		public override bool contains(object P_0)
		{
			bool result = this_00240.containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 170, 67, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2749)]
		public override object[] toArray()
		{
			object[] result = access_0024900(this).toArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[LineNumberTable(2754)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = access_0024900(this).toArray(P_0);
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$AbstractWeakKeyEntry<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;>;Lcom/google/common/collect/MapMakerInternalMap$StrongValueEntry<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;>;")]
	[ConstantPool(new object[]
	{
		(byte)35,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$StrongValueEntry" })]
	internal sealed class WeakKeyDummyValueEntry : AbstractWeakKeyEntry, StrongValueEntry, InternalEntry
	{
		[Signature("<K:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntryHelper<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;>;")]
		[ConstantPool(new object[]
		{
			(byte)67,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class Helper : java.lang.Object, InternalEntryHelper
		{
			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
			[Signature("Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry$Helper<*>;")]
			private static Helper INSTANCE;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[Signature("<K:Ljava/lang/Object;>()Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry$Helper<TK;>;")]
			internal static Helper instance()
			{
				return INSTANCE;
			}

			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMaker$Dummy;)V")]
			public virtual void setValue(WeakKeyDummyValueSegment P_0, WeakKeyDummyValueEntry P_1, MapMaker.Dummy P_2)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 67, 0, 0 })]
			[LineNumberTable(new byte[] { 162, 108, 136, 130 })]
			public virtual WeakKeyDummyValueEntry copy(WeakKeyDummyValueSegment P_0, WeakKeyDummyValueEntry P_1, WeakKeyDummyValueEntry P_2)
			{
				if (P_1.getKey() == null)
				{
					return null;
				}
				WeakKeyDummyValueEntry result = P_1.copy(WeakKeyDummyValueSegment.access_0024200(P_0), P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;TK;ILcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 67, 0, 0 })]
			[LineNumberTable(751)]
			public virtual WeakKeyDummyValueEntry newEntry(WeakKeyDummyValueSegment P_0, object P_1, int P_2, WeakKeyDummyValueEntry P_3)
			{
				WeakKeyDummyValueEntry result = new WeakKeyDummyValueEntry(WeakKeyDummyValueSegment.access_0024200(P_0), P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;>;II)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;")]
			[LineNumberTable(726)]
			public virtual WeakKeyDummyValueSegment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				WeakKeyDummyValueSegment result = new WeakKeyDummyValueSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(701)]
			internal Helper()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(713)]
			public virtual Strength keyStrength()
			{
				return Strength.WEAK;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(718)]
			public virtual Strength valueStrength()
			{
				return Strength.STRONG;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(701)]
			public virtual void setValue(Segment P_0, InternalEntry P_1, object P_2)
			{
				setValue((WeakKeyDummyValueSegment)P_0, (WeakKeyDummyValueEntry)P_1, (MapMaker.Dummy)P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 67, 0, 0 })]
			[LineNumberTable(701)]
			public virtual InternalEntry copy(Segment P_0, InternalEntry P_1, InternalEntry P_2)
			{
				WeakKeyDummyValueEntry result = copy((WeakKeyDummyValueSegment)P_0, (WeakKeyDummyValueEntry)P_1, (WeakKeyDummyValueEntry)P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 67, 0, 0 })]
			[LineNumberTable(701)]
			public virtual InternalEntry newEntry(Segment P_0, object P_1, int P_2, InternalEntry P_3)
			{
				WeakKeyDummyValueEntry result = newEntry((WeakKeyDummyValueSegment)P_0, P_1, P_2, (WeakKeyDummyValueEntry)P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(701)]
			public virtual Segment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				WeakKeyDummyValueSegment result = this.newSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[LineNumberTable(704)]
			static Helper()
			{
				INSTANCE = new Helper();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;")]
		[LineNumberTable(694)]
		internal virtual WeakKeyDummyValueEntry copy(ReferenceQueue P_0, WeakKeyDummyValueEntry P_1)
		{
			WeakKeyDummyValueEntry result = new WeakKeyDummyValueEntry(P_0, base.getKey(), hash, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;TK;ILcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 35, 0, 0 })]
		[LineNumberTable(new byte[] { 162, 56, 109 })]
		internal WeakKeyDummyValueEntry(ReferenceQueue P_0, object P_1, int P_2, WeakKeyDummyValueEntry P_3)
			: base(P_0, P_1, P_2, P_3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(687)]
		public new virtual MapMaker.Dummy getValue()
		{
			return MapMaker.Dummy.VALUE;
		}

		internal virtual void setValue(MapMaker.Dummy P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(677)]
		public override object getValue()
		{
			MapMaker.Dummy value = getValue();
			_ = null;
			return value;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;>;")]
	internal sealed class WeakKeyDummyValueSegment : Segment
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/ref/ReferenceQueue<TK;>;")]
		private ReferenceQueue queueForKeys;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;Lcom/google/common/collect/MapMaker$Dummy;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;>;II)V")]
		[LineNumberTable(new byte[] { 168, 67, 235, 58, 235, 71 })]
		internal WeakKeyDummyValueSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			: base(P_0, P_1, P_2)
		{
			queueForKeys = new ReferenceQueue();
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(2221)]
		internal static ReferenceQueue access_0024200(WeakKeyDummyValueSegment P_0)
		{
			return P_0.queueForKeys;
		}

		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;Lcom/google/common/collect/MapMaker$Dummy;*>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueEntry<TK;>;")]
		[LineNumberTable(2245)]
		public new virtual WeakKeyDummyValueEntry castForTesting(InternalEntry P_0)
		{
			return (WeakKeyDummyValueEntry)P_0;
		}

		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$WeakKeyDummyValueSegment<TK;>;")]
		internal new virtual WeakKeyDummyValueSegment self()
		{
			return this;
		}

		[Signature("()Ljava/lang/ref/ReferenceQueue<TK;>;")]
		internal override ReferenceQueue getKeyReferenceQueueForTesting()
		{
			return queueForKeys;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 88, 110 })]
		internal override void maybeDrainReferenceQueues()
		{
			base.drainKeyReferenceQueue(queueForKeys);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 93, 110 })]
		internal override void maybeClearReferenceQueues()
		{
			base.clearReferenceQueue(queueForKeys);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2221)]
		public override InternalEntry castForTesting(InternalEntry P_0)
		{
			WeakKeyDummyValueEntry result = castForTesting(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2221)]
		internal override Segment self()
		{
			WeakKeyDummyValueSegment result = self();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected WeakKeyDummyValueSegment(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$AbstractWeakKeyEntry<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;>;Lcom/google/common/collect/MapMakerInternalMap$StrongValueEntry<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;>;")]
	[ConstantPool(new object[]
	{
		(byte)19,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$StrongValueEntry" })]
	internal sealed class WeakKeyStrongValueEntry : AbstractWeakKeyEntry, StrongValueEntry, InternalEntry
	{
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntryHelper<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;>;")]
		[ConstantPool(new object[]
		{
			(byte)66,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class Helper : java.lang.Object, InternalEntryHelper
		{
			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
			[Signature("Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry$Helper<**>;")]
			private static Helper INSTANCE;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry$Helper<TK;TV;>;")]
			internal static Helper instance()
			{
				return INSTANCE;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;TV;)V")]
			[LineNumberTable(new byte[] { 162, 203, 105 })]
			public virtual void setValue(WeakKeyStrongValueSegment P_0, WeakKeyStrongValueEntry P_1, object P_2)
			{
				P_1.setValue(P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 66, 0, 0 })]
			[LineNumberTable(new byte[] { 162, 193, 136, 130 })]
			public virtual WeakKeyStrongValueEntry copy(WeakKeyStrongValueSegment P_0, WeakKeyStrongValueEntry P_1, WeakKeyStrongValueEntry P_2)
			{
				if (P_1.getKey() == null)
				{
					return null;
				}
				WeakKeyStrongValueEntry result = P_1.copy(WeakKeyStrongValueSegment.access_0024300(P_0), P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;TK;ILcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 66, 0, 0 })]
			[LineNumberTable(838)]
			public virtual WeakKeyStrongValueEntry newEntry(WeakKeyStrongValueSegment P_0, object P_1, int P_2, WeakKeyStrongValueEntry P_3)
			{
				WeakKeyStrongValueEntry result = new WeakKeyStrongValueEntry(WeakKeyStrongValueSegment.access_0024300(P_0), P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;>;II)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;")]
			[LineNumberTable(811)]
			public virtual WeakKeyStrongValueSegment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				WeakKeyStrongValueSegment result = new WeakKeyStrongValueSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(785)]
			internal Helper()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(797)]
			public virtual Strength keyStrength()
			{
				return Strength.WEAK;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(802)]
			public virtual Strength valueStrength()
			{
				return Strength.STRONG;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(785)]
			public virtual void setValue(Segment P_0, InternalEntry P_1, object P_2)
			{
				setValue((WeakKeyStrongValueSegment)P_0, (WeakKeyStrongValueEntry)P_1, P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 66, 0, 0 })]
			[LineNumberTable(785)]
			public virtual InternalEntry copy(Segment P_0, InternalEntry P_1, InternalEntry P_2)
			{
				WeakKeyStrongValueEntry result = copy((WeakKeyStrongValueSegment)P_0, (WeakKeyStrongValueEntry)P_1, (WeakKeyStrongValueEntry)P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 66, 0, 0 })]
			[LineNumberTable(785)]
			public virtual InternalEntry newEntry(Segment P_0, object P_1, int P_2, InternalEntry P_3)
			{
				WeakKeyStrongValueEntry result = newEntry((WeakKeyStrongValueSegment)P_0, P_1, P_2, (WeakKeyStrongValueEntry)P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(785)]
			public virtual Segment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				WeakKeyStrongValueSegment result = this.newSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[LineNumberTable(788)]
			static Helper()
			{
				INSTANCE = new Helper();
			}
		}

		[Signature("TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 19, 0, 0 })]
		private volatile object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 162, 152, 98, 114, 110 })]
		internal virtual WeakKeyStrongValueEntry copy(ReferenceQueue P_0, WeakKeyStrongValueEntry P_1)
		{
			WeakKeyStrongValueEntry weakKeyStrongValueEntry = new WeakKeyStrongValueEntry(P_0, base.getKey(), hash, P_1);
			weakKeyStrongValueEntry.setValue(value);
			return weakKeyStrongValueEntry;
		}

		[Signature("(TV;)V")]
		internal virtual void setValue(object P_0)
		{
			value = P_0;
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;TK;ILcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 19, 0, 0 })]
		[LineNumberTable(new byte[] { 162, 138, 237, 60, 238, 69 })]
		internal WeakKeyStrongValueEntry(ReferenceQueue P_0, object P_1, int P_2, WeakKeyStrongValueEntry P_3)
			: base(P_0, P_1, P_2, P_3)
		{
			value = null;
			System.Threading.Thread.MemoryBarrier();
		}

		[Signature("()TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 19, 0, 0 })]
		public override object getValue()
		{
			return value;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;>;")]
	internal sealed class WeakKeyStrongValueSegment : Segment
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/ref/ReferenceQueue<TK;>;")]
		private ReferenceQueue queueForKeys;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;>;II)V")]
		[LineNumberTable(new byte[] { 167, 213, 235, 57, 235, 72 })]
		internal WeakKeyStrongValueSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			: base(P_0, P_1, P_2)
		{
			queueForKeys = new ReferenceQueue();
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(2110)]
		internal static ReferenceQueue access_0024300(WeakKeyStrongValueSegment P_0)
		{
			return P_0.queueForKeys;
		}

		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueEntry<TK;TV;>;")]
		[LineNumberTable(2135)]
		public new virtual WeakKeyStrongValueEntry castForTesting(InternalEntry P_0)
		{
			return (WeakKeyStrongValueEntry)P_0;
		}

		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$WeakKeyStrongValueSegment<TK;TV;>;")]
		internal new virtual WeakKeyStrongValueSegment self()
		{
			return this;
		}

		[Signature("()Ljava/lang/ref/ReferenceQueue<TK;>;")]
		internal override ReferenceQueue getKeyReferenceQueueForTesting()
		{
			return queueForKeys;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 234, 110 })]
		internal override void maybeDrainReferenceQueues()
		{
			base.drainKeyReferenceQueue(queueForKeys);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 239, 110 })]
		internal override void maybeClearReferenceQueues()
		{
			base.clearReferenceQueue(queueForKeys);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2110)]
		public override InternalEntry castForTesting(InternalEntry P_0)
		{
			WeakKeyStrongValueEntry result = castForTesting(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2110)]
		internal override Segment self()
		{
			WeakKeyStrongValueSegment result = self();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected WeakKeyStrongValueSegment(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$AbstractWeakKeyEntry<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;>;Lcom/google/common/collect/MapMakerInternalMap$WeakValueEntry<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;>;")]
	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$WeakValueEntry" })]
	internal sealed class WeakKeyWeakValueEntry : AbstractWeakKeyEntry, WeakValueEntry, InternalEntry
	{
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntryHelper<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;>;")]
		[ConstantPool(new object[]
		{
			(byte)67,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal sealed class Helper : java.lang.Object, InternalEntryHelper
		{
			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
			[Signature("Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry$Helper<**>;")]
			private static Helper INSTANCE;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry$Helper<TK;TV;>;")]
			internal static Helper instance()
			{
				return INSTANCE;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;TV;)V")]
			[LineNumberTable(new byte[] { 163, 51, 111 })]
			public virtual void setValue(WeakKeyWeakValueSegment P_0, WeakKeyWeakValueEntry P_1, object P_2)
			{
				P_1.setValue(P_2, WeakKeyWeakValueSegment.access_0024500(P_0));
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 67, 0, 0 })]
			[LineNumberTable(new byte[] { 163, 38, 136, 130, 104, 130 })]
			public virtual WeakKeyWeakValueEntry copy(WeakKeyWeakValueSegment P_0, WeakKeyWeakValueEntry P_1, WeakKeyWeakValueEntry P_2)
			{
				if (P_1.getKey() == null)
				{
					return null;
				}
				if (Segment.isCollected(P_1))
				{
					return null;
				}
				WeakKeyWeakValueEntry result = P_1.copy(WeakKeyWeakValueSegment.access_0024400(P_0), WeakKeyWeakValueSegment.access_0024500(P_0), P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;TK;ILcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 67, 0, 0 })]
			[LineNumberTable(942)]
			public virtual WeakKeyWeakValueEntry newEntry(WeakKeyWeakValueSegment P_0, object P_1, int P_2, WeakKeyWeakValueEntry P_3)
			{
				WeakKeyWeakValueEntry result = new WeakKeyWeakValueEntry(WeakKeyWeakValueSegment.access_0024400(P_0), P_1, P_2, P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;>;II)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;")]
			[LineNumberTable(912)]
			public virtual WeakKeyWeakValueSegment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				WeakKeyWeakValueSegment result = new WeakKeyWeakValueSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(887)]
			internal Helper()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(899)]
			public virtual Strength keyStrength()
			{
				return Strength.WEAK;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(904)]
			public virtual Strength valueStrength()
			{
				return Strength.WEAK;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(887)]
			public virtual void setValue(Segment P_0, InternalEntry P_1, object P_2)
			{
				setValue((WeakKeyWeakValueSegment)P_0, (WeakKeyWeakValueEntry)P_1, P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 2, 0, 0, 67, 0, 0 })]
			[LineNumberTable(887)]
			public virtual InternalEntry copy(Segment P_0, InternalEntry P_1, InternalEntry P_2)
			{
				WeakKeyWeakValueEntry result = copy((WeakKeyWeakValueSegment)P_0, (WeakKeyWeakValueEntry)P_1, (WeakKeyWeakValueEntry)P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 67, 0, 0 })]
			[LineNumberTable(887)]
			public virtual InternalEntry newEntry(Segment P_0, object P_1, int P_2, InternalEntry P_3)
			{
				WeakKeyWeakValueEntry result = newEntry((WeakKeyWeakValueSegment)P_0, P_1, P_2, (WeakKeyWeakValueEntry)P_3);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(887)]
			public virtual Segment newSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			{
				WeakKeyWeakValueSegment result = this.newSegment(P_0, P_1, P_2);
				_ = null;
				return result;
			}

			[LineNumberTable(890)]
			static Helper()
			{
				INSTANCE = new Helper();
			}
		}

		[Signature("Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;>;")]
		private volatile WeakValueReference valueReference;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;Ljava/lang/ref/ReferenceQueue<TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 162, 238, 98, 114, 124 })]
		internal virtual WeakKeyWeakValueEntry copy(ReferenceQueue P_0, ReferenceQueue P_1, WeakKeyWeakValueEntry P_2)
		{
			WeakKeyWeakValueEntry weakKeyWeakValueEntry = new WeakKeyWeakValueEntry(P_0, base.getKey(), hash, P_2);
			weakKeyWeakValueEntry.valueReference = valueReference.copyFor(P_1, weakKeyWeakValueEntry);
			System.Threading.Thread.MemoryBarrier();
			return weakKeyWeakValueEntry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;Ljava/lang/ref/ReferenceQueue<TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 250, 105, 117, 104 })]
		internal virtual void setValue(object P_0, ReferenceQueue P_1)
		{
			WeakValueReference weakValueReference = valueReference;
			valueReference = new WeakValueReferenceImpl(P_1, P_0, this);
			System.Threading.Thread.MemoryBarrier();
			weakValueReference.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TK;>;TK;ILcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 3, 0, 0, 45, 0, 0 })]
		[LineNumberTable(new byte[] { 162, 226, 237, 59, 97, 241, 69 })]
		internal WeakKeyWeakValueEntry(ReferenceQueue P_0, object P_1, int P_2, WeakKeyWeakValueEntry P_3)
			: base(P_0, P_1, P_2, P_3)
		{
			valueReference = unsetWeakValueReference();
			System.Threading.Thread.MemoryBarrier();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(857)]
		public override object getValue()
		{
			object result = valueReference.get();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 246, 111 })]
		public virtual void clearValue()
		{
			valueReference.clear();
		}

		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;>;")]
		public virtual WeakValueReference getValueReference()
		{
			return valueReference;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(844)]
		internal static WeakValueReference access_0024700(WeakKeyWeakValueEntry P_0)
		{
			return P_0.valueReference;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(844)]
		internal static WeakValueReference access_0024702(WeakKeyWeakValueEntry P_0, WeakValueReference P_1)
		{
			P_0.valueReference = P_1;
			System.Threading.Thread.MemoryBarrier();
			return P_1;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;>;")]
	internal sealed class WeakKeyWeakValueSegment : Segment
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/ref/ReferenceQueue<TK;>;")]
		private ReferenceQueue queueForKeys;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/ref/ReferenceQueue<TV;>;")]
		private ReferenceQueue queueForValues;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;>;II)V")]
		[LineNumberTable(new byte[] { 167, 253, 235, 57, 107, 235, 71 })]
		internal WeakKeyWeakValueSegment(MapMakerInternalMap P_0, int P_1, int P_2)
			: base(P_0, P_1, P_2)
		{
			queueForKeys = new ReferenceQueue();
			queueForValues = new ReferenceQueue();
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(2150)]
		internal static ReferenceQueue access_0024400(WeakKeyWeakValueSegment P_0)
		{
			return P_0.queueForKeys;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(2150)]
		internal static ReferenceQueue access_0024500(WeakKeyWeakValueSegment P_0)
		{
			return P_0.queueForValues;
		}

		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;")]
		[LineNumberTable(2180)]
		public new virtual WeakKeyWeakValueEntry castForTesting(InternalEntry P_0)
		{
			return (WeakKeyWeakValueEntry)P_0;
		}

		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueSegment<TK;TV;>;")]
		internal new virtual WeakKeyWeakValueSegment self()
		{
			return this;
		}

		[Signature("()Ljava/lang/ref/ReferenceQueue<TK;>;")]
		internal override ReferenceQueue getKeyReferenceQueueForTesting()
		{
			return queueForKeys;
		}

		[Signature("()Ljava/lang/ref/ReferenceQueue<TV;>;")]
		internal override ReferenceQueue getValueReferenceQueueForTesting()
		{
			return queueForValues;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;>;")]
		[LineNumberTable(2186)]
		public override WeakValueReference getWeakValueReferenceForTesting(InternalEntry P_0)
		{
			WeakValueReference valueReference = castForTesting(P_0).getValueReference();
			_ = null;
			return valueReference;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;TV;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;Lcom/google/common/collect/MapMakerInternalMap$WeakKeyWeakValueEntry<TK;TV;>;>;")]
		[LineNumberTable(2192)]
		public override WeakValueReference newWeakValueReferenceForTesting(InternalEntry P_0, object P_1)
		{
			WeakValueReferenceImpl result = new WeakValueReferenceImpl(queueForValues, P_1, castForTesting(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;+Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;>;)V")]
		[LineNumberTable(new byte[] { 168, 37, 136, 130, 103, 104, 104 })]
		public override void setWeakValueReferenceForTesting(InternalEntry P_0, WeakValueReference P_1)
		{
			WeakKeyWeakValueEntry weakKeyWeakValueEntry = castForTesting(P_0);
			WeakValueReference weakValueReference = WeakKeyWeakValueEntry.access_0024700(weakKeyWeakValueEntry);
			WeakKeyWeakValueEntry.access_0024702(weakKeyWeakValueEntry, P_1);
			weakValueReference.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 48, 108, 110 })]
		internal override void maybeDrainReferenceQueues()
		{
			base.drainKeyReferenceQueue(queueForKeys);
			base.drainValueReferenceQueue(queueForValues);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 54, 110 })]
		internal override void maybeClearReferenceQueues()
		{
			base.clearReferenceQueue(queueForKeys);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2150)]
		public override InternalEntry castForTesting(InternalEntry P_0)
		{
			WeakKeyWeakValueEntry result = castForTesting(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2150)]
		internal override Segment self()
		{
			WeakKeyWeakValueSegment result = self();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected WeakKeyWeakValueSegment(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;")]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$InternalEntry" })]
	internal interface WeakValueEntry : InternalEntry
	{
		[Signature("()Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;")]
		virtual WeakValueReference getValueReference();

		virtual void clearValue();
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>Ljava/lang/Object;")]
	[ConstantPool(new object[]
	{
		(byte)8,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal interface WeakValueReference
	{
		[Signature("()TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 8, 0, 0 })]
		virtual object get();

		[Signature("()TE;")]
		virtual InternalEntry getEntry();

		virtual void clear();

		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TE;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;")]
		virtual WeakValueReference copyFor(ReferenceQueue P_0, InternalEntry P_1);
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>Ljava/lang/ref/WeakReference<TV;>;Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;")]
	[Implements(new string[] { "com.google.common.collect.MapMakerInternalMap$WeakValueReference" })]
	internal sealed class WeakValueReferenceImpl : java.lang.@ref.WeakReference, WeakValueReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TE;")]
		internal InternalEntry entry;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TV;TE;)V")]
		[LineNumberTable(new byte[] { 163, 150, 106, 103 })]
		internal WeakValueReferenceImpl(ReferenceQueue P_0, object P_1, InternalEntry P_2)
			: base(P_1, P_0)
		{
			entry = P_2;
		}

		[Signature("()TE;")]
		public virtual InternalEntry getEntry()
		{
			return entry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/ref/ReferenceQueue<TV;>;TE;)Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;")]
		[LineNumberTable(1043)]
		public virtual WeakValueReference copyFor(ReferenceQueue P_0, InternalEntry P_1)
		{
			WeakValueReferenceImpl result = new WeakValueReferenceImpl(P_0, base.get(), P_1);
			_ = null;
			return result;
		}

		object WeakValueReference.MapMakerInternalMap_0024WeakValueReference_003A_003Aget()
		{
			return get();
		}

		void WeakValueReference.MapMakerInternalMap_0024WeakValueReference_003A_003Aclear()
		{
			clear();
		}
	}

	[Signature("Lcom/google/common/collect/AbstractMapEntry<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)47,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class WriteThroughEntry : AbstractMapEntry
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		internal object key;

		[Signature("TV;")]
		internal object value;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MapMakerInternalMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)V")]
		[LineNumberTable(new byte[] { 169, 217, 111, 103, 103 })]
		internal WriteThroughEntry(MapMakerInternalMap P_0, object P_1, object P_2)
		{
			this_00240 = P_0;
			base._002Ector();
			key = P_1;
			value = P_2;
		}

		[Signature("()TK;")]
		public override object getKey()
		{
			return key;
		}

		[Signature("()TV;")]
		public override object getValue()
		{
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 47, 0, 0 })]
		[LineNumberTable(new byte[] { 169, 235, 104, 103, 159, 12 })]
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
		[LineNumberTable(2663)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(key) ^ java.lang.Object.instancehelper_hashCode(value);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(new byte[] { 169, 250, 115, 103 })]
		public override object setValue(object P_0)
		{
			object result = this_00240.put(key, P_0);
			value = P_0;
			return result;
		}
	}

	internal const int MAXIMUM_CAPACITY = 1073741824;

	internal const int MAX_SEGMENTS = 65536;

	internal const int CONTAINS_VALUE_RETRIES = 3;

	internal const int DRAIN_THRESHOLD = 63;

	internal const int DRAIN_MAX = 16;

	internal const long CLEANUP_EXECUTOR_DELAY_SECS = 60L;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	internal int segmentMask;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	internal int segmentShift;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("[Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;TE;TS;>;")]
	internal Segment[] segments;

	[Modifiers(Modifiers.Final)]
	internal int concurrencyLevel;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	internal Equivalence keyEquivalence;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/MapMakerInternalMap$InternalEntryHelper<TK;TV;TE;TS;>;")]
	internal InternalEntryHelper entryHelper;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<Ljava/lang/Object;Ljava/lang/Object;Lcom/google/common/collect/MapMakerInternalMap$DummyInternalEntry;>;")]
	internal static WeakValueReference UNSET_WEAK_VALUE_REFERENCE;

	[NonSerialized]
	[Signature("Ljava/util/Set<TK;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 205, 0, 0 })]
	internal new Set keySet;

	[NonSerialized]
	[Signature("Ljava/util/Collection<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 205, 0, 0 })]
	internal new Collection values;

	[NonSerialized]
	[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 0, 0, 205, 0, 0 })]
	internal new Set entrySet;

	private const long serialVersionUID = 5L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;>(Lcom/google/common/collect/MapMaker;)Lcom/google/common/collect/MapMakerInternalMap<TK;Lcom/google/common/collect/MapMaker$Dummy;+Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;Lcom/google/common/collect/MapMaker$Dummy;*>;*>;")]
	[LineNumberTable(new byte[] { 160, 120, 110, 108, 142, 110, 108, 142, 109, 144 })]
	internal static MapMakerInternalMap createWithDummyValues(MapMaker P_0)
	{
		if (P_0.getKeyStrength() == Strength.STRONG && P_0.getValueStrength() == Strength.STRONG)
		{
			MapMakerInternalMap result = new MapMakerInternalMap(P_0, StrongKeyDummyValueEntry.Helper.instance());
			_ = null;
			return result;
		}
		if (P_0.getKeyStrength() == Strength.WEAK && P_0.getValueStrength() == Strength.STRONG)
		{
			MapMakerInternalMap result2 = new MapMakerInternalMap(P_0, WeakKeyDummyValueEntry.Helper.instance());
			_ = null;
			return result2;
		}
		if (P_0.getValueStrength() == Strength.WEAK)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException("Map cannot have both weak and dummy values");
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TE;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 205, 0, 0 })]
	[LineNumberTable(new byte[] { 168, 188, 99, 130, 104 })]
	internal virtual InternalEntry getEntry(object P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		int num = hash(P_0);
		InternalEntry entry = segmentFor(num).getEntry(P_0, num);
		_ = null;
		return entry;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(new byte[] { 168, 254, 103, 103, 104 })]
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
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/MapMaker;)Lcom/google/common/collect/MapMakerInternalMap<TK;TV;+Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;*>;")]
	[LineNumberTable(new byte[]
	{
		160, 89, 110, 108, 142, 110, 108, 142, 110, 108,
		142, 122, 142
	})]
	internal static MapMakerInternalMap create(MapMaker P_0)
	{
		if (P_0.getKeyStrength() == Strength.STRONG && P_0.getValueStrength() == Strength.STRONG)
		{
			MapMakerInternalMap result = new MapMakerInternalMap(P_0, StrongKeyStrongValueEntry.Helper.instance());
			_ = null;
			return result;
		}
		if (P_0.getKeyStrength() == Strength.STRONG && P_0.getValueStrength() == Strength.WEAK)
		{
			MapMakerInternalMap result2 = new MapMakerInternalMap(P_0, StrongKeyWeakValueEntry.Helper.instance());
			_ = null;
			return result2;
		}
		if (P_0.getKeyStrength() == Strength.WEAK && P_0.getValueStrength() == Strength.STRONG)
		{
			MapMakerInternalMap result3 = new MapMakerInternalMap(P_0, WeakKeyStrongValueEntry.Helper.instance());
			_ = null;
			return result3;
		}
		if (P_0.getKeyStrength() == Strength.WEAK && P_0.getValueStrength() == Strength.WEAK)
		{
			MapMakerInternalMap result4 = new MapMakerInternalMap(P_0, WeakKeyWeakValueEntry.Helper.instance());
			_ = null;
			return result4;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/ArrayList<TE;>;")]
	[LineNumberTable(new byte[] { 170, 150, 113, 109 })]
	private static ArrayList toArrayList(Collection P_0)
	{
		ArrayList.___003Cclinit_003E();
		ArrayList arrayList = new ArrayList(P_0.size());
		Iterators.addAll(arrayList, P_0.iterator());
		return arrayList;
	}

	[Signature("(I)[Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;TE;TS;>;")]
	[LineNumberTable(1130)]
	internal Segment[] newSegmentArray(int P_0)
	{
		return new Segment[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;TE;TS;>;")]
	[LineNumberTable(1114)]
	internal virtual Segment createSegment(int P_0, int P_1)
	{
		Segment result = entryHelper.newSegment(this, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/MapMaker;Lcom/google/common/collect/MapMakerInternalMap$InternalEntryHelper<TK;TV;TE;TS;>;)V")]
	[LineNumberTable(new byte[]
	{
		114, 104, 150, 108, 135, 209, 98, 98, 105, 100,
		134, 106, 137, 141, 109, 103, 166, 99, 102, 168,
		110, 50, 168
	})]
	private MapMakerInternalMap(MapMaker P_0, InternalEntryHelper P_1)
	{
		concurrencyLevel = java.lang.Math.min(P_0.getConcurrencyLevel(), 65536);
		keyEquivalence = P_0.getKeyEquivalence();
		entryHelper = P_1;
		int num = java.lang.Math.min(P_0.getInitialCapacity(), 1073741824);
		int num2 = 0;
		int num3;
		for (num3 = 1; num3 < concurrencyLevel; num3 <<= 1)
		{
			num2++;
		}
		segmentShift = 32 - num2;
		segmentMask = num3 - 1;
		segments = newSegmentArray(num3);
		int num4 = num3;
		int num5 = ((num4 != -1) ? (num / num4) : (-num));
		if (num5 * num3 < num)
		{
			num5++;
		}
		int num6;
		for (num6 = 1; num6 < num5; num6 <<= 1)
		{
		}
		for (int i = 0; i < (nint)segments.LongLength; i++)
		{
			segments[i] = createSegment(num6, -1);
		}
	}

	[Signature("(I)Lcom/google/common/collect/MapMakerInternalMap$Segment<TK;TV;TE;TS;>;")]
	[LineNumberTable(1110)]
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
	[LineNumberTable(new byte[] { 163, 196, 109 })]
	internal virtual int hash(object P_0)
	{
		int num = keyEquivalence.hash(P_0);
		int result = rehash(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Equivalence<Ljava/lang/Object;>;")]
	[LineNumberTable(2291)]
	internal virtual Equivalence valueEquivalence()
	{
		Equivalence result = entryHelper.valueStrength().defaultEquivalence();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(new byte[] { 168, 245, 103, 103, 104 })]
	public override object put(object P_0, object P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		int num = hash(P_0);
		object result = segmentFor(num).put(P_0, num, P_1, false);
		_ = null;
		return result;
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;E::Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;TE;>;>()Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;")]
	internal static WeakValueReference unsetWeakValueReference()
	{
		return UNSET_WEAK_VALUE_REFERENCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TE;)TE;")]
	[LineNumberTable(new byte[] { 163, 191, 103 })]
	internal virtual InternalEntry copyEntry(InternalEntry P_0, InternalEntry P_1)
	{
		int num = P_0.getHash();
		InternalEntry result = segmentFor(num).copyEntry(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/MapMakerInternalMap$WeakValueReference<TK;TV;TE;>;)V")]
	[LineNumberTable(new byte[] { 163, 201, 103, 103, 117 })]
	internal virtual void reclaimValue(WeakValueReference P_0)
	{
		InternalEntry entry = P_0.getEntry();
		int num = entry.getHash();
		segmentFor(num).reclaimValue(entry.getKey(), num, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 163, 207, 103, 111 })]
	internal virtual void reclaimKey(InternalEntry P_0)
	{
		int num = P_0.getHash();
		segmentFor(num).reclaimKey(P_0, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/MapMakerInternalMap$InternalEntry<TK;TV;*>;)Z")]
	[LineNumberTable(1099)]
	internal virtual bool isLiveForTesting(InternalEntry P_0)
	{
		return segmentFor(P_0.getHash()).getLiveValueForTesting(P_0) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TV;")]
	[LineNumberTable(new byte[] { 163, 240, 104, 130 })]
	internal virtual object getLiveValue(InternalEntry P_0)
	{
		if (P_0.getKey() == null)
		{
			return null;
		}
		object value = P_0.getValue();
		_ = null;
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(2281)]
	internal virtual Strength keyStrength()
	{
		Strength result = entryHelper.keyStrength();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(2286)]
	internal virtual Strength valueStrength()
	{
		Strength result = entryHelper.valueStrength();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		168, 143, 99, 103, 103, 108, 130, 236, 60, 230,
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
	[LineNumberTable(new byte[] { 168, 166, 103, 99, 103, 46, 166 })]
	public override int size()
	{
		Segment[] array = segments;
		long num = 0L;
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			num += array[i].count;
		}
		int result = Ints.saturatedCast(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 205, 0, 0 })]
	[LineNumberTable(new byte[] { 168, 176, 99, 130, 104 })]
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
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 205, 0, 0 })]
	[LineNumberTable(new byte[] { 168, 197, 99, 130, 104 })]
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
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 205, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		168, 206, 99, 226, 72, 103, 99, 105, 99, 155,
		138, 107, 110, 116, 107, 116, 226, 61, 43, 232,
		72, 235, 51, 235, 79, 100, 130, 226, 44, 233,
		86
	})]
	public override bool containsValue(object P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		Segment[] array = segments;
		long num = -1L;
		for (int i = 0; i < 3; i++)
		{
			long num2 = 0L;
			Segment[] array2 = array;
			int num3 = array2.Length;
			for (int j = 0; j < num3; j++)
			{
				Segment segment = array2[j];
				_ = segment.count;
				AtomicReferenceArray table = segment.table;
				for (int k = 0; k < table.length(); k++)
				{
					for (InternalEntry internalEntry = (InternalEntry)table.get(k); internalEntry != null; internalEntry = internalEntry.getNext())
					{
						object liveValue = segment.getLiveValue(internalEntry);
						if (liveValue != null && valueEquivalence().equivalent(P_0, liveValue))
						{
							return true;
						}
					}
				}
				num2 += segment.modCount;
			}
			if (num2 == num)
			{
				break;
			}
			num = num2;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 169, 6, 127, 1, 115, 98 })]
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
	[Signature("(Ljava/lang/Object;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 0, 0, 0, 205, 0, 0 })]
	[LineNumberTable(new byte[] { 169, 14, 99, 130, 104 })]
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
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 0, 0, 0, 205, 0, 0, 22,
		1, 0, 0, 205, 0, 0
	})]
	[LineNumberTable(new byte[] { 169, 24, 102, 130, 104 })]
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
	[Signature("(TK;TV;TV;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 22, 1, 0, 0, 205, 0, 0 })]
	[LineNumberTable(new byte[] { 169, 34, 103, 103, 99, 130, 104 })]
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
	[LineNumberTable(new byte[] { 169, 46, 103, 103, 104 })]
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
	[LineNumberTable(new byte[] { 169, 54, 116, 38, 166 })]
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
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(new byte[] { 169, 63, 103 })]
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
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 169, 71, 103 })]
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
	[LineNumberTable(new byte[] { 169, 79, 103 })]
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
	[LineNumberTable(new byte[] { 170, 160, 102, 107, 145, 248, 60 })]
	internal virtual object writeReplace()
	{
		SerializationProxy result = new SerializationProxy(entryHelper.keyStrength(), entryHelper.valueStrength(), keyEquivalence, entryHelper.valueStrength().defaultEquivalence(), concurrencyLevel, this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	internal static ArrayList access_0024900(Collection P_0)
	{
		ArrayList result = toArrayList(P_0);
		_ = null;
		return result;
	}

	[LineNumberTable(1004)]
	static MapMakerInternalMap()
	{
		UNSET_WEAK_VALUE_REFERENCE = new _1();
	}

	void ConcurrentMap.ConcurrentMap_003A_003AforEach(BiConsumer P_0)
	{
		forEach(P_0);
	}

	object ConcurrentMap.ConcurrentMap_003A_003AgetOrDefault(object P_0, object P_1)
	{
		return getOrDefault(P_0, P_1);
	}

	void ConcurrentMap.ConcurrentMap_003A_003AreplaceAll(BiFunction P_0)
	{
		replaceAll(P_0);
	}

	object ConcurrentMap.ConcurrentMap_003A_003AcomputeIfAbsent(object P_0, java.util.function.Function P_1)
	{
		return computeIfAbsent(P_0, P_1);
	}

	object ConcurrentMap.ConcurrentMap_003A_003AcomputeIfPresent(object P_0, BiFunction P_1)
	{
		return computeIfPresent(P_0, P_1);
	}

	object ConcurrentMap.ConcurrentMap_003A_003Acompute(object P_0, BiFunction P_1)
	{
		return compute(P_0, P_1);
	}

	object ConcurrentMap.ConcurrentMap_003A_003Amerge(object P_0, object P_1, BiFunction P_2)
	{
		return merge(P_0, P_1, P_2);
	}

	bool Map.Map_003A_003Aequals(object P_0)
	{
		return equals(P_0);
	}

	int Map.Map_003A_003AhashCode()
	{
		return hashCode();
	}

	object Map.Map_003A_003AgetOrDefault(object P_0, object P_1)
	{
		return getOrDefault(P_0, P_1);
	}

	void Map.Map_003A_003AforEach(BiConsumer P_0)
	{
		forEach(P_0);
	}

	void Map.Map_003A_003AreplaceAll(BiFunction P_0)
	{
		replaceAll(P_0);
	}

	object Map.Map_003A_003AcomputeIfAbsent(object P_0, java.util.function.Function P_1)
	{
		return computeIfAbsent(P_0, P_1);
	}

	object Map.Map_003A_003AcomputeIfPresent(object P_0, BiFunction P_1)
	{
		return computeIfPresent(P_0, P_1);
	}

	object Map.Map_003A_003Acompute(object P_0, BiFunction P_1)
	{
		return compute(P_0, P_1);
	}

	object Map.Map_003A_003Amerge(object P_0, object P_1, BiFunction P_2)
	{
		return merge(P_0, P_1, P_2);
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
	protected MapMakerInternalMap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
