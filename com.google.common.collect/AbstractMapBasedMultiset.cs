using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultiset<TE;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 152, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)152,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal abstract class AbstractMapBasedMultiset : AbstractMultiset, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<TE;>;")]
	[EnclosingMethod(null, "elementIterator", "()Ljava.util.Iterator;")]
	internal class _1 : java.lang.Object, Iterator
	{
		[Signature("Ljava/util/Map$Entry<TE;Lcom/google/common/collect/Count;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Map.Entry toRemove;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024backingEntries;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMapBasedMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(91)]
		internal _1(AbstractMapBasedMultiset P_0, Iterator P_1)
		{
			this_00240 = P_0;
			val_0024backingEntries = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(96)]
		public virtual bool hasNext()
		{
			bool result = val_0024backingEntries.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 52, 113, 103 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			object key = (toRemove = (Map.Entry)val_0024backingEntries.next()).getKey();
			_ = null;
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 59, 118, 127, 4, 107, 103 })]
		public virtual void remove()
		{
			Preconditions.checkState(toRemove != null, (object)"no calls to next() since the last call to remove()");
			access_0024022(this_00240, ((Count)toRemove.getValue()).getAndSet(0));
			val_0024backingEntries.remove();
			toRemove = null;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
	internal class _2 : java.lang.Object, Iterator
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/Multisets$AbstractEntry<TE;>;")]
		[EnclosingMethod(null, "next", "()Lcom.google.common.collect.Multiset$Entry;")]
		internal class _1 : Multisets.AbstractEntry
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Map.Entry val_0024mapEntry;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _2 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TE;")]
			[LineNumberTable(136)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public override object getElement()
			{
				object key = val_0024mapEntry.getKey();
				_ = null;
				return key;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(132)]
			internal _1(_2 P_0, Map.Entry P_1)
			{
				this_00241 = P_0;
				val_0024mapEntry = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 91, 113, 107, 127, 2, 99, 169 })]
			public override int getCount()
			{
				Count count = (Count)val_0024mapEntry.getValue();
				if (count == null || count.get() == 0)
				{
					Count count2 = (Count)access_0024100(this_00241.this_00240).get(getElement());
					if (count2 != null)
					{
						int result = count2.get();
						_ = null;
						return result;
					}
				}
				int result2 = count?.get() ?? 0;
				_ = null;
				return result2;
			}
		}

		[Signature("Ljava/util/Map$Entry<TE;Lcom/google/common/collect/Count;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Map.Entry toRemove;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024backingEntries;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMapBasedMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(120)]
		internal _2(AbstractMapBasedMultiset P_0, Iterator P_1)
		{
			this_00240 = P_0;
			val_0024backingEntries = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[LineNumberTable(new byte[] { 80, 113, 103 })]
		public virtual Multiset.Entry next()
		{
			_1 result = new _1(this, toRemove = (Map.Entry)val_0024backingEntries.next());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(125)]
		public virtual bool hasNext()
		{
			bool result = val_0024backingEntries.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 105, 118, 127, 4, 107, 103 })]
		public virtual void remove()
		{
			Preconditions.checkState(toRemove != null, (object)"no calls to next() since the last call to remove()");
			access_0024022(this_00240, ((Count)toRemove.getValue()).getAndSet(0));
			val_0024backingEntries.remove();
			toRemove = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(120)]
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

	[InnerClass(null, Modifiers.Private)]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<TE;>;")]
	internal class MapBasedMultisetIterator : java.lang.Object, Iterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TE;Lcom/google/common/collect/Count;>;>;")]
		internal Iterator entryIterator;

		[Signature("Ljava/util/Map$Entry<TE;Lcom/google/common/collect/Count;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Map.Entry currentEntry;

		internal int occurrencesLeft;

		internal bool canRemove;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMapBasedMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 92, 111, 118 })]
		internal MapBasedMultisetIterator(AbstractMapBasedMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			entryIterator = access_0024100(P_0).entrySet().iterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(212)]
		public virtual bool hasNext()
		{
			return (occurrencesLeft > 0 || entryIterator.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 160, 104, 104, 118, 155, 110, 231, 69 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			if (occurrencesLeft == 0)
			{
				currentEntry = (Map.Entry)entryIterator.next();
				occurrencesLeft = ((Count)currentEntry.getValue()).get();
			}
			occurrencesLeft--;
			canRemove = true;
			object key = ((Map.Entry)java.util.Objects.requireNonNull(currentEntry)).getKey();
			_ = null;
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 119, 235, 69, 127, 1, 100, 139, 120, 139,
			108, 103
		})]
		public virtual void remove()
		{
			CollectPreconditions.checkRemove(canRemove);
			int num = ((Count)((Map.Entry)java.util.Objects.requireNonNull(currentEntry)).getValue()).get();
			if (num <= 0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
			if (((Count)currentEntry.getValue()).addAndGet(-1) == 0)
			{
				entryIterator.remove();
			}
			access_0024010(this_00240);
			canRemove = false;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : BiConsumer
	{
		private readonly ObjIntConsumer arg_00241;

		internal ___003C_003EAnon0(ObjIntConsumer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024forEachEntry_00240(arg_00241, P_0, (Count)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[NonSerialized]
	[Signature("Ljava/util/Map<TE;Lcom/google/common/collect/Count;>;")]
	private Map backingMap;

	[NonSerialized]
	private new long m_size;

	private const long serialVersionUID = -2250766705698539974L;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static long access_0024022(AbstractMapBasedMultiset P_0, long P_1)
	{
		long result = P_0.m_size - P_1;
		P_0.m_size = result;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 138, 114 })]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		int result = ((Count)Maps.safeGet(backingMap, P_0))?.get() ?? 0;
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 224, 99, 162 })]
	private static int getAndSet([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Count P_0, int P_1)
	{
		if (P_0 == null)
		{
			return 0;
		}
		int andSet = P_0.getAndSet(P_1);
		_ = null;
		return andSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(166)]
	private static void lambda_0024forEachEntry_00240(ObjIntConsumer P_0, object P_1, Count P_2)
	{
		P_0.accept(P_1, P_2.get());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;Lcom/google/common/collect/Count;>;)V")]
	[LineNumberTable(new byte[] { 14, 104, 107, 103 })]
	protected internal AbstractMapBasedMultiset(Map P_0)
	{
		Preconditions.checkArgument(P_0.isEmpty());
		backingMap = P_0;
	}

	[Signature("(Ljava/util/Map<TE;Lcom/google/common/collect/Count;>;)V")]
	internal virtual void setBackingMap(Map P_0)
	{
		backingMap = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(85)]
	public override Set entrySet()
	{
		Set result = base.entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(new byte[] { 40, 113 })]
	internal override Iterator elementIterator()
	{
		Iterator iterator = backingMap.entrySet().iterator();
		_1 result = new _1(this, iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(new byte[] { 69, 113 })]
	internal override Iterator entryIterator()
	{
		Iterator iterator = backingMap.entrySet().iterator();
		_2 result = new _2(this, iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/ObjIntConsumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 115, 103, 120 })]
	public override void forEachEntry(ObjIntConsumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		backingMap.forEach(new ___003C_003EAnon0(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 121, 127, 6, 103, 98, 107, 104 })]
	public override void clear()
	{
		Iterator iterator = backingMap.values().iterator();
		while (iterator.hasNext())
		{
			Count count = (Count)iterator.next();
			count.set(0);
		}
		backingMap.clear();
		this.m_size = 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(180)]
	internal override int distinctElements()
	{
		int result = backingMap.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(187)]
	public override int size()
	{
		int result = Ints.saturatedCast(this.m_size);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(192)]
	public override Iterator iterator()
	{
		MapBasedMultisetIterator result = new MapBasedMultisetIterator(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(new byte[]
	{
		160, 153, 99, 138, 111, 146, 99, 98, 149, 103,
		102, 119, 135, 111
	})]
	public override int add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, int P_1)
	{
		if (P_1 == 0)
		{
			int result = this.count(P_0);
			_ = null;
			return result;
		}
		Preconditions.checkArgument(P_1 > 0, "occurrences cannot be negative: %s", P_1);
		Count count = (Count)backingMap.get(P_0);
		int num;
		if (count == null)
		{
			num = 0;
			backingMap.put(P_0, new Count(P_1));
		}
		else
		{
			num = count.get();
			long num2 = (long)num + (long)P_1;
			Preconditions.checkArgument(num2 <= 2147483647u, "too many occurrences: %s", num2);
			count.add(P_1);
		}
		this.m_size += P_1;
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 175, 99, 138, 111, 114, 99, 162, 167, 100,
		132, 98, 173, 104, 111
	})]
	public override int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, int P_1)
	{
		if (P_1 == 0)
		{
			int result = this.count(P_0);
			_ = null;
			return result;
		}
		Preconditions.checkArgument(P_1 > 0, "occurrences cannot be negative: %s", P_1);
		Count count = (Count)backingMap.get(P_0);
		if (count == null)
		{
			return 0;
		}
		int num = count.get();
		int num2;
		if (num > P_1)
		{
			num2 = P_1;
		}
		else
		{
			num2 = num;
			backingMap.remove(P_0);
		}
		count.add(-num2);
		this.m_size -= num2;
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(new byte[]
	{
		160, 203, 204, 99, 114, 138, 114, 136, 99, 211,
		113
	})]
	public override int setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, int P_1)
	{
		CollectPreconditions.checkNonnegative(P_1, "count");
		int andSet;
		if (P_1 == 0)
		{
			Count count = (Count)backingMap.remove(P_0);
			andSet = getAndSet(count, P_1);
		}
		else
		{
			Count count = (Count)backingMap.get(P_0);
			andSet = getAndSet(count, P_1);
			if (count == null)
			{
				backingMap.put(P_0, new Count(P_1));
			}
		}
		this.m_size += P_1 - andSet;
		return andSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.ObjectStreamException" })]
	[LineNumberTable(348)]
	private void readObjectNoData()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidObjectException("Stream data required");
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static Map access_0024100(AbstractMapBasedMultiset P_0)
	{
		return P_0.backingMap;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static long access_0024010(AbstractMapBasedMultiset P_0)
	{
		long num = P_0.m_size;
		P_0.m_size = num - 1;
		return num;
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
	protected AbstractMapBasedMultiset(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
