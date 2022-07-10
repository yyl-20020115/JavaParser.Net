using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/LinkedHashMultimapGwtSerializationDependencies<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 120, 0, 0,
	17, 1, 0, 0, 0, 120, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)120,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class LinkedHashMultimap : LinkedHashMultimapGwtSerializationDependencies
{
	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
	internal new class _1 : java.lang.Object, Iterator
	{
		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		internal ValueEntry nextEntry;

		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal ValueEntry toRemove;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedHashMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(570)]
		public virtual bool hasNext()
		{
			return nextEntry != access_0024300(this_00240);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 205, 104, 139, 103, 103, 113 })]
		public virtual Map.Entry next()
		{
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			ValueEntry result = (toRemove = nextEntry);
			nextEntry = nextEntry.getSuccessorInMultimap();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 194, 111 })]
		internal _1(LinkedHashMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			nextEntry = access_0024300(this_00240).getSuccessorInMultimap();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 216, 118, 127, 3, 103 })]
		public virtual void remove()
		{
			Preconditions.checkState(toRemove != null, (object)"no calls to next() since the last call to remove()");
			this_00240.remove(toRemove.getKey(), toRemove.getValue());
			toRemove = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(564)]
		public virtual object next()
		{
			Map.Entry result = this.next();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableEntry<TK;TV;>;Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 51, 0, 0,
		17, 1, 0, 0, 0, 51, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)51,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.LinkedHashMultimap$ValueSetLink" })]
	internal sealed class ValueEntry : ImmutableEntry, ValueSetLink
	{
		[Modifiers(Modifiers.Final)]
		internal int smearedValueHash;

		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal ValueEntry nextInValueBucket;

		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal ValueSetLink predecessorInValueSet;

		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal ValueSetLink successorInValueSet;

		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal ValueEntry predecessorInMultimap;

		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal ValueEntry successorInMultimap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		[LineNumberTable(245)]
		public virtual ValueEntry getSuccessorInMultimap()
		{
			return (ValueEntry)java.util.Objects.requireNonNull(successorInMultimap);
		}

		[Signature("(Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;)V")]
		public virtual void setSuccessorInMultimap(ValueEntry P_0)
		{
			successorInMultimap = P_0;
		}

		[Signature("(Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;)V")]
		public virtual void setPredecessorInMultimap(ValueEntry P_0)
		{
			predecessorInMultimap = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		[LineNumberTable(241)]
		public virtual ValueEntry getPredecessorInMultimap()
		{
			return (ValueEntry)java.util.Objects.requireNonNull(predecessorInMultimap);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 51, 0, 0,
			18, 1, 0, 0, 0, 51, 0, 0
		})]
		[LineNumberTable(213)]
		internal static ValueEntry newHeader()
		{
			ValueEntry result = new ValueEntry(null, null, 0, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;ILcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 92, 106, 103, 104 })]
		internal ValueEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, int P_2, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] ValueEntry P_3)
			: base(P_0, P_1)
		{
			smearedValueHash = P_2;
			nextInValueBucket = P_3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(217)]
		internal virtual bool matchesValue([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, int P_1)
		{
			return (smearedValueHash == P_1 && com.google.common.@base.Objects.equal(getValue(), P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		[LineNumberTable(222)]
		public virtual ValueSetLink getPredecessorInValueSet()
		{
			return (ValueSetLink)java.util.Objects.requireNonNull(predecessorInValueSet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		[LineNumberTable(227)]
		public virtual ValueSetLink getSuccessorInValueSet()
		{
			return (ValueSetLink)java.util.Objects.requireNonNull(successorInValueSet);
		}

		[Signature("(Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;)V")]
		public virtual void setPredecessorInValueSet(ValueSetLink P_0)
		{
			predecessorInValueSet = P_0;
		}

		[Signature("(Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;)V")]
		public virtual void setSuccessorInValueSet(ValueSetLink P_0)
		{
			successorInValueSet = P_0;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ValueEntry(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("Lcom/google/common/collect/Sets$ImprovedAbstractSet<TV;>;Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)51,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.LinkedHashMultimap$ValueSetLink" })]
	internal sealed class ValueSet : Sets.ImprovedAbstractSet, ValueSetLink
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/Iterator<TV;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : java.lang.Object, Iterator
		{
			[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
			internal ValueSetLink nextEntry;

			[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal ValueEntry toRemove;

			internal int expectedModCount;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ValueSet this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 48, 115, 139 })]
			private void checkForComodification()
			{
				if (access_0024100(this_00241) != expectedModCount)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new ConcurrentModificationException();
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 55, 102 })]
			public virtual bool hasNext()
			{
				checkForComodification();
				return nextEntry != this_00241;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 42, 111, 145 })]
			internal _1(ValueSet P_0)
			{
				this_00241 = P_0;
				base._002Ector();
				nextEntry = access_0024000(this_00241);
				expectedModCount = access_0024100(this_00241);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TV;")]
			[LineNumberTable(new byte[] { 161, 62, 104, 139, 108, 103, 103, 108 })]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public virtual object next()
			{
				if (!hasNext())
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new NoSuchElementException();
				}
				ValueEntry valueEntry = (ValueEntry)nextEntry;
				object value = valueEntry.getValue();
				toRemove = valueEntry;
				nextEntry = valueEntry.getSuccessorInValueSet();
				return value;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 74, 102, 118, 119, 113, 103 })]
			public virtual void remove()
			{
				checkForComodification();
				Preconditions.checkState(toRemove != null, (object)"no calls to next() since the last call to remove()");
				this_00241.remove(toRemove.getValue());
				expectedModCount = access_0024100(this_00241);
				toRemove = null;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object key;

		[Signature("[Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 51, 0, 0 })]
		internal ValueEntry[] hashTable;

		private new int m_size;

		private int modCount;

		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		private ValueSetLink firstEntry;

		[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		private ValueSetLink lastEntry;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LinkedHashMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;I)V")]
		[LineNumberTable(new byte[]
		{
			161, 3, 239, 56, 103, 231, 72, 103, 103, 135,
			204, 103, 103
		})]
		internal ValueSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] LinkedHashMultimap P_0, object P_1, int P_2)
		{
			this_00240 = P_0;
			base._002Ector();
			this.m_size = 0;
			modCount = 0;
			key = P_1;
			firstEntry = this;
			lastEntry = this;
			int num = Hashing.closedTableSize(P_2, 1.0);
			ValueEntry[] array = (hashTable = new ValueEntry[num]);
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(357)]
		internal static ValueSetLink access_0024000(ValueSet P_0)
		{
			return P_0.firstEntry;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(357)]
		internal static int access_0024100(ValueSet P_0)
		{
			return P_0.modCount;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 154, 103, 105, 98, 105, 134, 106, 131, 144,
			140, 102, 102, 110, 110, 226, 52, 238, 79
		})]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int num = Hashing.smearedHash(P_0);
			int num2 = num & mask();
			ValueEntry valueEntry = null;
			for (ValueEntry valueEntry2 = hashTable[num2]; valueEntry2 != null; valueEntry2 = valueEntry2.nextInValueBucket)
			{
				if (valueEntry2.matchesValue(P_0, num))
				{
					if (valueEntry == null)
					{
						hashTable[num2] = valueEntry2.nextInValueBucket;
					}
					else
					{
						valueEntry.nextInValueBucket = valueEntry2.nextInValueBucket;
					}
					access_0024500(valueEntry2);
					access_0024600(valueEntry2);
					this.m_size--;
					modCount++;
					return true;
				}
				valueEntry = valueEntry2;
			}
			return false;
		}

		[LineNumberTable(387)]
		private int mask()
		{
			return (int)((nint)hashTable.LongLength - 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 135, 156, 111, 103, 101, 103, 132, 103, 106,
			106, 229, 60, 233, 71
		})]
		private void rehashIfNecessary()
		{
			if (Hashing.needsResizing(this.m_size, hashTable.Length, 1.0))
			{
				ValueEntry[] array = (hashTable = new ValueEntry[(nint)hashTable.LongLength * 2]);
				int num = (int)((nint)array.LongLength - 1);
				for (ValueSetLink successorInValueSet = firstEntry; successorInValueSet != this; successorInValueSet = successorInValueSet.getSuccessorInValueSet())
				{
					ValueEntry valueEntry = (ValueEntry)successorInValueSet;
					int num2 = valueEntry.smearedValueHash & num;
					valueEntry.nextInValueBucket = array[num2];
					array[num2] = valueEntry;
				}
			}
		}

		[Signature("()Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		public virtual ValueSetLink getPredecessorInValueSet()
		{
			return lastEntry;
		}

		[Signature("()Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		public virtual ValueSetLink getSuccessorInValueSet()
		{
			return firstEntry;
		}

		[Signature("(Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;)V")]
		public virtual void setPredecessorInValueSet(ValueSetLink P_0)
		{
			lastEntry = P_0;
		}

		[Signature("(Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;)V")]
		public virtual void setSuccessorInValueSet(ValueSetLink P_0)
		{
			firstEntry = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(412)]
		public override Iterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 85, 103, 103, 132, 49, 169 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			for (ValueSetLink successorInValueSet = firstEntry; successorInValueSet != this; successorInValueSet = successorInValueSet.getSuccessorInValueSet())
			{
				P_0.accept(((ValueEntry)successorInValueSet).getValue());
			}
		}

		public override int size()
		{
			return this.m_size;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 100, 103, 112, 131, 106, 2, 233, 69 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int num = Hashing.smearedHash(P_0);
			for (ValueEntry valueEntry = hashTable[num & mask()]; valueEntry != null; valueEntry = valueEntry.nextInValueBucket)
			{
				if (valueEntry.matchesValue(P_0, num))
				{
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)Z")]
		[LineNumberTable(new byte[]
		{
			161, 113, 103, 105, 105, 101, 106, 2, 233, 70,
			111, 108, 103, 118, 113, 105, 110, 110, 102
		})]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			int num = Hashing.smearedHash(P_0);
			int num2 = num & mask();
			ValueEntry valueEntry = hashTable[num2];
			ValueEntry valueEntry2;
			for (valueEntry2 = valueEntry; valueEntry2 != null; valueEntry2 = valueEntry2.nextInValueBucket)
			{
				if (valueEntry2.matchesValue(P_0, num))
				{
					return false;
				}
			}
			valueEntry2 = new ValueEntry(key, P_0, num, valueEntry);
			access_0024200(lastEntry, valueEntry2);
			access_0024200(valueEntry2, this);
			access_0024400(access_0024300(this_00240).getPredecessorInMultimap(), valueEntry2);
			access_0024400(valueEntry2, access_0024300(this_00240));
			hashTable[num2] = valueEntry2;
			this.m_size++;
			modCount++;
			rehashIfNecessary();
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 179, 108, 103, 103, 132, 103, 6, 201, 103,
			110
		})]
		public override void clear()
		{
			Arrays.fill(hashTable, null);
			this.m_size = 0;
			for (ValueSetLink successorInValueSet = firstEntry; successorInValueSet != this; successorInValueSet = successorInValueSet.getSuccessorInValueSet())
			{
				ValueEntry valueEntry = (ValueEntry)successorInValueSet;
				access_0024600(valueEntry);
			}
			access_0024200(this, this);
			modCount++;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 18, 0, 0,
		17, 1, 0, 0, 0, 18, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)18,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal interface ValueSetLink
	{
		[Signature("(Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;)V")]
		virtual void setSuccessorInValueSet(ValueSetLink P_0);

		[Signature("(Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;)V")]
		virtual void setPredecessorInValueSet(ValueSetLink P_0);

		[Signature("()Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		virtual ValueSetLink getPredecessorInValueSet();

		[Signature("()Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;")]
		virtual ValueSetLink getSuccessorInValueSet();
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			object value = ((Map.Entry)P_0).getValue();
			_ = null;
			return value;
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

	private const int DEFAULT_KEY_CAPACITY = 16;

	private const int DEFAULT_VALUE_SET_CAPACITY = 2;

	internal const double VALUE_SET_LOAD_FACTOR = 1.0;

	[NonSerialized]
	internal int valueSetCapacity;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;")]
	private ValueEntry multimapHeaderEntry;

	private const long serialVersionUID = 1L;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(87)]
	internal static ValueEntry access_0024300(LinkedHashMultimap P_0)
	{
		return P_0.multimapHeaderEntry;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
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
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 120, 0, 0,
		18, 1, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(new byte[] { 105, 115 })]
	private static void deleteFromMultimap(ValueEntry P_0)
	{
		succeedsInMultimap(P_0.getPredecessorInMultimap(), P_0.getSuccessorInMultimap());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 120, 0, 0,
		18, 1, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(new byte[] { 100, 115 })]
	private static void deleteFromValueSet(ValueSetLink P_0)
	{
		succeedsInValueSet(P_0.getPredecessorInValueSet(), P_0.getSuccessorInValueSet());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;Lcom/google/common/collect/LinkedHashMultimap$ValueEntry<TK;TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 120, 0, 0,
		18, 1, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(new byte[] { 94, 103, 105 })]
	private static void succeedsInMultimap(ValueEntry P_0, ValueEntry P_1)
	{
		P_0.setSuccessorInMultimap(P_1);
		P_1.setPredecessorInMultimap(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;Lcom/google/common/collect/LinkedHashMultimap$ValueSetLink<TK;TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 120, 0, 0,
		18, 1, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(new byte[] { 88, 103, 105 })]
	private static void succeedsInValueSet(ValueSetLink P_0, ValueSetLink P_1)
	{
		P_0.setSuccessorInValueSet(P_1);
		P_1.setPredecessorInValueSet(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 151, 238, 60, 231, 69, 140, 103, 107, 115 })]
	private LinkedHashMultimap(int P_0, int P_1)
		: base(Platform.newLinkedHashMapWithExpectedSize(P_0))
	{
		valueSetCapacity = 2;
		CollectPreconditions.checkNonnegative(P_1, "expectedValuesPerKey");
		valueSetCapacity = P_1;
		multimapHeaderEntry = ValueEntry.newHeader();
		succeedsInMultimap(multimapHeaderEntry, multimapHeaderEntry);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(II)Lcom/google/common/collect/LinkedHashMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 120, 0, 0,
		18, 1, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(new byte[] { 57, 97, 50 })]
	public static LinkedHashMultimap create(int expectedKeys, int expectedValuesPerKey)
	{
		LinkedHashMultimap result = new LinkedHashMultimap(Maps.capacity(expectedKeys), Maps.capacity(expectedValuesPerKey));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override bool putAll(Multimap m)
	{
		bool result = base.putAll(m);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(325)]
	public override Set entries()
	{
		Set result = base.entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(564)]
	internal override Iterator entryIterator()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(595)]
	internal override Spliterator entrySpliterator()
	{
		Spliterator result = Spliterators.spliterator(entries(), 17);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(340)]
	public override Set keySet()
	{
		Set result = base.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override int size()
	{
		int result = base.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(296)]
	internal override Collection createCollection([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		ValueSet result = new ValueSet(this, P_0, valueSetCapacity);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Set<TV;>;")]
	[LineNumberTable(309)]
	public override Set replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key, Iterable values)
	{
		Set result = base.replaceValues(key, values);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TV;>;")]
	[LineNumberTable(282)]
	internal override Set createCollection()
	{
		Set result = Platform.newLinkedHashSetWithExpectedSize(valueSetCapacity);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/LinkedHashMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 120, 0, 0,
		18, 1, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(93)]
	public static LinkedHashMultimap create()
	{
		LinkedHashMultimap result = new LinkedHashMultimap(16, 2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/LinkedHashMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 120, 0, 0,
		18, 1, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(new byte[] { 71, 114, 104 })]
	public static LinkedHashMultimap create(Multimap multimap)
	{
		LinkedHashMultimap linkedHashMultimap = create(multimap.keySet().size(), 2);
		linkedHashMultimap.putAll(multimap);
		return linkedHashMultimap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(352)]
	public override Collection values()
	{
		Collection result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TV;>;")]
	[LineNumberTable(600)]
	internal override Iterator valueIterator()
	{
		Iterator result = Maps.valueIterator(entryIterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TV;>;")]
	[LineNumberTable(605)]
	internal override Spliterator valueSpliterator()
	{
		Spliterator result = CollectSpliterators.map(entrySpliterator(), new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 240, 102, 115 })]
	public override void clear()
	{
		base.clear();
		succeedsInMultimap(multimapHeaderEntry, multimapHeaderEntry);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 250, 102, 113, 123, 103, 98, 108, 127, 1,
		108, 108, 98
	})]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeInt(keySet().size());
		Iterator iterator = keySet().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			P_0.writeObject(obj);
		}
		P_0.writeInt(size());
		iterator = entries().iterator();
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
		162,
		8,
		102,
		107,
		113,
		103,
		103,
		104,
		134,
		103,
		239,
		61,
		230,
		69,
		103,
		136,
		136,
		232,
		69,
		byte.MaxValue,
		0,
		55,
		232,
		75,
		105
	})]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		multimapHeaderEntry = ValueEntry.newHeader();
		succeedsInMultimap(multimapHeaderEntry, multimapHeaderEntry);
		valueSetCapacity = 2;
		int num = P_0.readInt();
		Map map = Platform.newLinkedHashMapWithExpectedSize(12);
		int i;
		for (i = 0; i < num; i++)
		{
			object obj = P_0.readObject();
			map.put(obj, createCollection(obj));
		}
		i = P_0.readInt();
		for (int j = 0; j < i; j++)
		{
			object key = P_0.readObject();
			object e = P_0.readObject();
			((Collection)java.util.Objects.requireNonNull((Collection)map.get(key))).add(e);
		}
		setMap(map);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
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
	[LineNumberTable(85)]
	public override bool put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2)
	{
		bool result = base.put(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override Map asMap()
	{
		Map result = base.asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override Set removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		Set result = base.removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override Set get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj)
	{
		Set result = base.get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(85)]
	public virtual Collection _003Cbridge_003Eentries()
	{
		Set result = entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(85)]
	public virtual Collection _003Cbridge_003EreplaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i)
	{
		Set result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override void forEach(BiConsumer bc)
	{
		base.forEach(bc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.containsKey(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	internal override Collection createCollection()
	{
		Set result = this.createCollection();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override int hashCode()
	{
		int result = base.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override Multiset keys()
	{
		Multiset result = base.keys();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
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
	[LineNumberTable(85)]
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
	[LineNumberTable(85)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.containsValue(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(85)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(87)]
	internal static void access_0024200(ValueSetLink P_0, ValueSetLink P_1)
	{
		succeedsInValueSet(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(87)]
	internal static void access_0024400(ValueEntry P_0, ValueEntry P_1)
	{
		succeedsInMultimap(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(87)]
	internal static void access_0024500(ValueSetLink P_0)
	{
		deleteFromValueSet(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(87)]
	internal static void access_0024600(ValueEntry P_0)
	{
		deleteFromMultimap(P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected LinkedHashMultimap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|get", "(Ljava.lang.Object;)Ljava.util.Collection;")]
	public Collection _003Cbridge_003Eget(object P_0)
	{
		return ((AbstractSetMultimap)this).get(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|removeAll", "(Ljava.lang.Object;)Ljava.util.Collection;")]
	public Collection _003Cbridge_003EremoveAll(object P_0)
	{
		return ((AbstractSetMultimap)this).removeAll(P_0);
	}
}
