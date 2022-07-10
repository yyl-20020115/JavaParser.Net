using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.math;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.math;
using java.util;
using java.util.concurrent;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)119,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Lists : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Lists$RandomAccessListWrapper<TE;>;")]
	[EnclosingMethod(null, "subListImpl", "(Ljava.util.List;II)Ljava.util.List;")]
	internal class _1 : RandomAccessListWrapper
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1101)]
		internal _1(List P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TE;>;")]
		[LineNumberTable(1104)]
		public override ListIterator listIterator(int P_0)
		{
			ListIterator result = backingList.listIterator(P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Lists$AbstractListWrapper<TE;>;")]
	[EnclosingMethod(null, "subListImpl", "(Ljava.util.List;II)Ljava.util.List;")]
	internal class _2 : AbstractListWrapper
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1111)]
		internal _2(List P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TE;>;")]
		[LineNumberTable(1114)]
		public override ListIterator listIterator(int P_0)
		{
			ListIterator result = backingList.listIterator(P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 64, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class AbstractListWrapper : AbstractList
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/List<TE;>;")]
		internal List backingList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TE;>;)V")]
		[LineNumberTable(new byte[] { 163, 244, 104, 113 })]
		internal AbstractListWrapper(List P_0)
		{
			backingList = (List)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITE;)V")]
		[LineNumberTable(new byte[] { 163, 250, 111 })]
		public override void add(int P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			backingList.add(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILjava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(1137)]
		public override bool addAll(int P_0, Collection P_1)
		{
			bool result = backingList.addAll(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(1143)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object get(int P_0)
		{
			object result = backingList.get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(1149)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object remove(int P_0)
		{
			object result = backingList.remove(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITE;)TE;")]
		[LineNumberTable(1155)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object set(int P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			object result = backingList.set(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1160)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = backingList.contains(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1165)]
		public override int size()
		{
			int result = backingList.size();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/AbstractList<Ljava/lang/Character;>;")]
	internal sealed class CharSequenceAsList : AbstractList
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private CharSequence sequence;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 158, 203, 106, 104, 119 })]
		internal CharSequenceAsList(CharSequence P_0)
		{
			CharSequence charSequence = P_0;
			object __003Cref_003E = charSequence.___003Cref_003E;
			base._002Ector();
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = __003Cref_003E);
			sequence = charSequence2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(793)]
		public override int size()
		{
			CharSequence charSequence = sequence;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
			int result = charSequence2.length();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 161, 109 })]
		public new virtual Character get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			CharSequence charSequence = sequence;
			CharSequence charSequence2 = default(CharSequence);
			object obj = (charSequence2.___003Cref_003E = charSequence.___003Cref_003E);
			Character result = Character.valueOf(charSequence2.charAt(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(778)]
		public override object get(int P_0)
		{
			Character result = get(P_0);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;Ljava/io/Serializable;Ljava/util/RandomAccess;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 53, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)53,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable", "java.util.RandomAccess" })]
	internal class OnePlusArrayList : AbstractList, Serializable.__Interface, RandomAccess, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TE;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object first;

		[Modifiers(Modifiers.Final)]
		[Signature("[TE;")]
		internal object[] rest;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;[TE;)V")]
		[LineNumberTable(new byte[] { 160, 209, 104, 103, 113 })]
		internal OnePlusArrayList([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, object[] P_1)
		{
			first = P_0;
			rest = (object[])Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(330)]
		public override int size()
		{
			int result = IntMath.saturatedAdd(rest.Length, 1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(new byte[] { 160, 223, 109 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			return (P_0 != 0) ? rest[P_0 - 1] : first;
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
		protected OnePlusArrayList(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/util/AbstractList<Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 47, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)47,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class Partition : AbstractList
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/List<TT;>;")]
		internal List list;

		[Modifiers(Modifiers.Final)]
		internal new int size;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TT;>;I)V")]
		[LineNumberTable(new byte[] { 162, 56, 104, 103, 103 })]
		internal Partition(List P_0, int P_1)
		{
			list = P_0;
			this.size = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(697)]
		public override int size()
		{
			int result = IntMath.divide(list.size(), this.size, RoundingMode.CEILING);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/List<TT;>;")]
		[LineNumberTable(new byte[] { 162, 63, 109, 105, 121 })]
		public new virtual List get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			int num = P_0 * this.size;
			int toIndex = java.lang.Math.min(num + this.size, list.size());
			List result = list.subList(num, toIndex);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(702)]
		public override bool isEmpty()
		{
			bool result = list.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(678)]
		public override object get(int P_0)
		{
			List result = get(P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Lists$AbstractListWrapper<TE;>;Ljava/util/RandomAccess;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 26, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)26,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.RandomAccess" })]
	internal class RandomAccessListWrapper : AbstractListWrapper, RandomAccess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TE;>;)V")]
		[LineNumberTable(new byte[] { 164, 34, 105 })]
		internal RandomAccessListWrapper(List P_0)
			: base(P_0)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/Lists$Partition<TT;>;Ljava/util/RandomAccess;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 28, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)28,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.RandomAccess" })]
	internal class RandomAccessPartition : Partition, RandomAccess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TT;>;I)V")]
		[LineNumberTable(new byte[] { 162, 83, 106 })]
		internal RandomAccessPartition(List P_0, int P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/Lists$ReverseList<TT;>;Ljava/util/RandomAccess;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 26, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)26,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.RandomAccess" })]
	internal class RandomAccessReverseList : ReverseList, RandomAccess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TT;>;)V")]
		[LineNumberTable(new byte[] { 163, 88, 105 })]
		internal RandomAccessReverseList(List P_0)
			: base(P_0)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/util/AbstractList<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 95, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)95,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ReverseList : AbstractList
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Ljava/util/ListIterator<TT;>;")]
		[EnclosingMethod(null, "listIterator", "(I)Ljava.util.ListIterator;")]
		[Implements(new string[] { "java.util.ListIterator" })]
		internal class _1 : java.lang.Object, ListIterator, Iterator
		{
			internal bool canRemoveOrSet;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ListIterator val_0024forwardIterator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ReverseList this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(900)]
			internal _1(ReverseList P_0, ListIterator P_1)
			{
				this_00240 = P_0;
				val_0024forwardIterator = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(913)]
			public virtual bool hasNext()
			{
				bool result = val_0024forwardIterator.hasPrevious();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(918)]
			public virtual bool hasPrevious()
			{
				bool result = val_0024forwardIterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(933)]
			public virtual int nextIndex()
			{
				int result = access_0024000(this_00240, val_0024forwardIterator.nextIndex());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TT;)V")]
			[LineNumberTable(new byte[] { 163, 24, 108, 108, 103 })]
			public virtual void add([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				val_0024forwardIterator.add(P_0);
				val_0024forwardIterator.previous();
				canRemoveOrSet = false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TT;")]
			[LineNumberTable(new byte[] { 163, 42, 104, 139, 103 })]
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
				canRemoveOrSet = true;
				object result = val_0024forwardIterator.previous();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TT;")]
			[LineNumberTable(new byte[] { 163, 57, 104, 139, 103 })]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public virtual object previous()
			{
				if (!hasPrevious())
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new NoSuchElementException();
				}
				canRemoveOrSet = true;
				object result = val_0024forwardIterator.next();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(948)]
			public virtual int previousIndex()
			{
				return nextIndex() - 1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 71, 107, 107, 103 })]
			public virtual void remove()
			{
				CollectPreconditions.checkRemove(canRemoveOrSet);
				val_0024forwardIterator.remove();
				canRemoveOrSet = false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TT;)V")]
			[LineNumberTable(new byte[] { 163, 78, 107, 110 })]
			public virtual void set([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				Preconditions.checkState(canRemoveOrSet);
				val_0024forwardIterator.set(P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/List<TT;>;")]
		private List forwardList;

		[Signature("()Ljava/util/List<TT;>;")]
		internal virtual List getForwardList()
		{
			return forwardList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TT;>;)V")]
		[LineNumberTable(new byte[] { 162, 201, 104, 113 })]
		internal ReverseList(List P_0)
		{
			forwardList = (List)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 216, 103, 104 })]
		private int reversePosition(int P_0)
		{
			int num = size();
			Preconditions.checkPositionIndex(P_0, num);
			return num - P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(882)]
		public override int size()
		{
			int result = forwardList.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 210, 103, 104 })]
		private int reverseIndex(int P_0)
		{
			int num = size();
			Preconditions.checkElementIndex(P_0, num);
			return num - 1 - P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<TT;>;")]
		[LineNumberTable(new byte[] { 163, 5, 109 })]
		public override List subList(int P_0, int P_1)
		{
			Preconditions.checkPositionIndexes(P_0, P_1, size());
			List result = reverse(forwardList.subList(reversePosition(P_1), reversePosition(P_0)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITT;)V")]
		[LineNumberTable(new byte[] { 162, 223, 117 })]
		public override void add(int P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			forwardList.add(reversePosition(P_0), P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 228, 109 })]
		public override void clear()
		{
			forwardList.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TT;")]
		[LineNumberTable(860)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object remove(int P_0)
		{
			object result = forwardList.remove(reverseIndex(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 239, 111 })]
		protected internal override void removeRange(int P_0, int P_1)
		{
			subList(P_0, P_1).clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITT;)TT;")]
		[LineNumberTable(871)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object set(int P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			object result = forwardList.set(reverseIndex(P_0), P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TT;")]
		[LineNumberTable(877)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object get(int P_0)
		{
			object result = forwardList.get(reverseIndex(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(893)]
		public override Iterator iterator()
		{
			ListIterator result = listIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TT;>;")]
		[LineNumberTable(new byte[] { 163, 16, 104, 109 })]
		public override ListIterator listIterator(int P_0)
		{
			int index = reversePosition(P_0);
			ListIterator listIterator = forwardList.listIterator(index);
			_1 result = new _1(this, listIterator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(824)]
		internal static int access_0024000(ReverseList P_0, int P_1)
		{
			int result = P_0.reversePosition(P_1);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<Ljava/lang/Character;>;")]
	internal sealed class StringAsImmutableList : ImmutableList
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private string @string;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 115, 104, 103 })]
		internal StringAsImmutableList(string P_0)
		{
			@string = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(774)]
		public override int size()
		{
			int result = java.lang.String.instancehelper_length(@string);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Lcom/google/common/collect/ImmutableList<Ljava/lang/Character;>;")]
		[LineNumberTable(new byte[] { 162, 131, 109 })]
		public override ImmutableList subList(int P_0, int P_1)
		{
			Preconditions.checkPositionIndexes(P_0, P_1, size());
			ImmutableList result = charactersOf(java.lang.String.instancehelper_substring(@string, P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 142, 109 })]
		public new virtual Character get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			Character result = Character.valueOf(java.lang.String.instancehelper_charAt(@string, P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(747)]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!(P_0 is Character)) ? (-1) : java.lang.String.instancehelper_indexOf(@string, ((Character)P_0).charValue());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(752)]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!(P_0 is Character)) ? (-1) : java.lang.String.instancehelper_lastIndexOf(@string, ((Character)P_0).charValue());
		}

		internal override bool isPartialView()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(736)]
		public new virtual List subList(int P_0, int P_1)
		{
			ImmutableList result = this.subList(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(736)]
		public override object get(int P_0)
		{
			Character result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static StringAsImmutableList()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected StringAsImmutableList(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Ljava/util/AbstractList<TT;>;Ljava/util/RandomAccess;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 82, 0, 0,
		17, 1, 0, 0, 0, 82, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)82,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.RandomAccess", "java.io.Serializable" })]
	internal class TransformingRandomAccessList : AbstractList, RandomAccess, Serializable.__Interface, ISerializable
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/TransformedListIterator<TF;TT;>;")]
		[EnclosingMethod(null, "listIterator", "(I)Ljava.util.ListIterator;")]
		internal class _1 : TransformedListIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TransformingRandomAccessList this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(622)]
			internal _1(TransformingRandomAccessList P_0, ListIterator P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TF;)TT;")]
			[LineNumberTable(625)]
			internal override object transform(object P_0)
			{
				object result = this_00240.function.apply(P_0);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Predicate
		{
			private readonly TransformingRandomAccessList arg_00241;

			private readonly java.util.function.Predicate arg_00242;

			internal ___003C_003EAnon0(TransformingRandomAccessList P_0, java.util.function.Predicate P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.lambda_0024removeIf_00240(arg_00242, P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/List<TF;>;")]
		internal List fromList;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TF;+TT;>;")]
		internal com.google.common.@base.Function function;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TF;>;Lcom/google/common/base/Function<-TF;+TT;>;)V")]
		[LineNumberTable(new byte[] { 161, 229, 104, 113, 113 })]
		internal TransformingRandomAccessList(List P_0, com.google.common.@base.Function P_1)
		{
			fromList = (List)Preconditions.checkNotNull(P_0);
			function = (com.google.common.@base.Function)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(638)]
		private bool lambda_0024removeIf_00240(java.util.function.Predicate P_0, object P_1)
		{
			bool result = P_0.test(function.apply(P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 236, 109 })]
		public override void clear()
		{
			fromList.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TT;")]
		[LineNumberTable(612)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object get(int P_0)
		{
			object result = function.apply(fromList.get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(617)]
		public override Iterator iterator()
		{
			ListIterator result = listIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TT;>;")]
		[LineNumberTable(622)]
		public override ListIterator listIterator(int P_0)
		{
			_1 result = new _1(this, fromList.listIterator(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(632)]
		public override bool isEmpty()
		{
			bool result = fromList.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Predicate<-TT;>;)Z")]
		[LineNumberTable(new byte[] { 162, 11, 103 })]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			Preconditions.checkNotNull(P_0);
			bool result = fromList.removeIf(new ___003C_003EAnon0(this, P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TT;")]
		[LineNumberTable(644)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object remove(int P_0)
		{
			object result = function.apply(fromList.remove(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(649)]
		public override int size()
		{
			int result = fromList.size();
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
		protected TransformingRandomAccessList(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Ljava/util/AbstractSequentialList<TT;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 66, 0, 0,
		17, 1, 0, 0, 0, 66, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)66,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class TransformingSequentialList : AbstractSequentialList, Serializable.__Interface, ISerializable
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/TransformedListIterator<TF;TT;>;")]
		[EnclosingMethod(null, "listIterator", "(I)Ljava.util.ListIterator;")]
		internal class _1 : TransformedListIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TransformingSequentialList this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(568)]
			internal _1(TransformingSequentialList P_0, ListIterator P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TF;)TT;")]
			[LineNumberTable(572)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			internal override object transform([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				object result = this_00240.function.apply(P_0);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Predicate
		{
			private readonly TransformingSequentialList arg_00241;

			private readonly java.util.function.Predicate arg_00242;

			internal ___003C_003EAnon0(TransformingSequentialList P_0, java.util.function.Predicate P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.lambda_0024removeIf_00240(arg_00242, P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/List<TF;>;")]
		internal List fromList;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TF;+TT;>;")]
		internal com.google.common.@base.Function function;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TF;>;Lcom/google/common/base/Function<-TF;+TT;>;)V")]
		[LineNumberTable(new byte[] { 161, 177, 104, 113, 113 })]
		internal TransformingSequentialList(List P_0, com.google.common.@base.Function P_1)
		{
			fromList = (List)Preconditions.checkNotNull(P_0);
			function = (com.google.common.@base.Function)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(580)]
		private bool lambda_0024removeIf_00240(java.util.function.Predicate P_0, object P_1)
		{
			bool result = P_0.test(function.apply(P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 188, 109 })]
		public override void clear()
		{
			fromList.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(563)]
		public override int size()
		{
			int result = fromList.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TT;>;")]
		[LineNumberTable(568)]
		public override ListIterator listIterator(int P_0)
		{
			_1 result = new _1(this, fromList.listIterator(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Predicate<-TT;>;)Z")]
		[LineNumberTable(new byte[] { 161, 209, 103 })]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			Preconditions.checkNotNull(P_0);
			bool result = fromList.removeIf(new ___003C_003EAnon0(this, P_0));
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
		protected TransformingSequentialList(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractList<TE;>;Ljava/io/Serializable;Ljava/util/RandomAccess;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 54, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)54,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable", "java.util.RandomAccess" })]
	internal class TwoPlusArrayList : AbstractList, Serializable.__Interface, RandomAccess, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TE;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object first;

		[Modifiers(Modifiers.Final)]
		[Signature("TE;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object second;

		[Modifiers(Modifiers.Final)]
		[Signature("[TE;")]
		internal object[] rest;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;[TE;)V")]
		[LineNumberTable(new byte[] { 160, 237, 104, 103, 103, 113 })]
		internal TwoPlusArrayList([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, object[] P_2)
		{
			first = P_0;
			second = P_1;
			rest = (object[])Preconditions.checkNotNull(P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(359)]
		public override int size()
		{
			int result = IntMath.saturatedAdd(rest.Length, 2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(new byte[] { 160, 251, 146, 135, 167, 109 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object get(int P_0)
		{
			switch (P_0)
			{
			case 0:
				return first;
			case 1:
				return second;
			default:
				Preconditions.checkElementIndex(P_0, size());
				return rest[P_0 - 2];
			}
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
		protected TwoPlusArrayList(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/ArrayList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(85)]
	public static ArrayList newArrayList()
	{
		ArrayList result = new ArrayList();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;[TE;)Ljava/util/List<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(293)]
	public static List asList([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object first, object[] rest)
	{
		OnePlusArrayList result = new OnePlusArrayList(first, rest);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Iterator<+TE;>;)Ljava/util/ArrayList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 95, 102, 104 })]
	public static ArrayList newArrayList(Iterator elements)
	{
		ArrayList arrayList = newArrayList();
		Iterators.addAll(arrayList, elements);
		return arrayList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/ArrayList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 78, 135, 104, 114, 13 })]
	public static ArrayList newArrayList(Iterable elements)
	{
		Preconditions.checkNotNull(elements);
		ArrayList result;
		if (elements is Collection)
		{
			ArrayList.___003Cclinit_003E();
			result = new ArrayList((Collection)elements);
		}
		else
		{
			result = newArrayList(elements.iterator());
		}
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<*>;Ljava/lang/Object;)I")]
	[LineNumberTable(new byte[] { 163, 145, 104, 138, 103, 104, 110, 169 })]
	internal static int indexOfImpl(List P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is RandomAccess)
		{
			int result = indexOfRandomAccess(P_0, P_1);
			_ = null;
			return result;
		}
		ListIterator listIterator = P_0.listIterator();
		while (listIterator.hasNext())
		{
			if (com.google.common.@base.Objects.equal(P_1, listIterator.next()))
			{
				int result2 = listIterator.previousIndex();
				_ = null;
				return result2;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<*>;Ljava/lang/Object;)I")]
	[LineNumberTable(new byte[] { 163, 178, 104, 138, 109, 104, 110, 169 })]
	internal static int lastIndexOfImpl(List P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is RandomAccess)
		{
			int result = lastIndexOfRandomAccess(P_0, P_1);
			_ = null;
			return result;
		}
		ListIterator listIterator = P_0.listIterator(P_0.size());
		while (listIterator.hasPrevious())
		{
			if (com.google.common.@base.Objects.equal(P_1, listIterator.previous()))
			{
				int result2 = listIterator.nextIndex();
				_ = null;
				return result2;
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<*>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[]
	{
		163, 107, 105, 130, 104, 130, 103, 103, 105, 130,
		144, 102, 117, 2, 230, 69, 130
	})]
	internal static bool equalsImpl(List P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_1 == Preconditions.checkNotNull(P_0))
		{
			return true;
		}
		if (!(P_1 is List))
		{
			return false;
		}
		List list = (List)P_1;
		int num = P_0.size();
		if (num != list.size())
		{
			return false;
		}
		if (P_0 is RandomAccess && list is RandomAccess)
		{
			for (int i = 0; i < num; i++)
			{
				if (!com.google.common.@base.Objects.equal(P_0.get(i), list.get(i)))
				{
					return false;
				}
			}
			return true;
		}
		bool result = Iterators.elementsEqual(P_0.iterator(), list.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/ArrayList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(197)]
	public static ArrayList newArrayListWithExpectedSize(int estimatedSize)
	{
		ArrayList.___003Cclinit_003E();
		ArrayList result = new ArrayList(computeArrayListCapacity(estimatedSize));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/ArrayList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 127, 108 })]
	public static ArrayList newArrayListWithCapacity(int initialArraySize)
	{
		CollectPreconditions.checkNonnegative(initialArraySize, "initialArraySize");
		ArrayList result = new ArrayList(initialArraySize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/List<TE;>;ILjava/lang/Iterable<+TE;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 134, 98, 104, 118, 103, 98, 98 })]
	internal static bool addAllImpl(List P_0, int P_1, Iterable P_2)
	{
		int result = 0;
		ListIterator listIterator = P_0.listIterator(P_1);
		Iterator iterator = P_2.iterator();
		while (iterator.hasNext())
		{
			object e = iterator.next();
			listIterator.add(e);
			result = 1;
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/List<TE;>;I)Ljava/util/ListIterator<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(1092)]
	internal static ListIterator listIteratorImpl(List P_0, int P_1)
	{
		ListIterator result = new AbstractListWrapper(P_0).listIterator(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/List<TE;>;II)Ljava/util/List<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 217, 104, 233, 74, 231, 74 })]
	internal static List subListImpl(List P_0, int P_1, int P_2)
	{
		AbstractListWrapper abstractListWrapper = ((!(P_0 is RandomAccess)) ? ((AbstractListWrapper)new _2(P_0)) : ((AbstractListWrapper)new _1(P_0)));
		List result = ((List)abstractListWrapper).subList(P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<*>;)I")]
	[LineNumberTable(new byte[] { 163, 95, 98, 118, 146, 134, 98 })]
	internal static int hashCodeImpl(List P_0)
	{
		int num = 1;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			num = 31 * num + ((obj != null) ? java.lang.Object.instancehelper_hashCode(obj) : 0);
			num = num ^ -1 ^ -1;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Ljava/util/ArrayList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 55, 135, 104, 103, 104 })]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static ArrayList newArrayList(params object[] elements)
	{
		Preconditions.checkNotNull(elements);
		int initialCapacity = computeArrayListCapacity(elements.Length);
		ArrayList arrayList = new ArrayList(initialCapacity);
		Collections.addAll(arrayList, elements);
		return arrayList;
	}

	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)Ljava/util/List<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(1178)]
	internal static List cast(Iterable P_0)
	{
		return (List)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 102, 172 })]
	internal static int computeArrayListCapacity(int P_0)
	{
		CollectPreconditions.checkNonnegative(P_0, "arraySize");
		int result = Ints.saturatedCast(5L + (long)P_0 + P_0 / 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/LinkedList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(218)]
	public static LinkedList newLinkedList()
	{
		LinkedList result = new LinkedList();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>(Ljava/util/List<+Ljava/util/List<+TB;>;>;)Ljava/util/List<Ljava/util/List<TB;>;>;")]
	[LineNumberTable(435)]
	public static List cartesianProduct(List lists)
	{
		List result = CartesianList.create(lists);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<*>;Ljava/lang/Object;)I")]
	[LineNumberTable(new byte[]
	{
		163, 159, 103, 99, 102, 105, 2, 232, 70, 102,
		111, 2, 230, 70
	})]
	private static int indexOfRandomAccess(List P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		int num = P_0.size();
		if (P_1 == null)
		{
			for (int i = 0; i < num; i++)
			{
				if (P_0.get(i) == null)
				{
					return i;
				}
			}
		}
		else
		{
			for (int i = 0; i < num; i++)
			{
				if (java.lang.Object.instancehelper_equals(P_1, P_0.get(i)))
				{
					return i;
				}
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<*>;Ljava/lang/Object;)I")]
	[LineNumberTable(new byte[]
	{
		163, 192, 99, 109, 105, 2, 232, 70, 109, 111,
		2, 230, 70
	})]
	private static int lastIndexOfRandomAccess(List P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_1 == null)
		{
			for (int i = P_0.size() - 1; i >= 0; i += -1)
			{
				if (P_0.get(i) == null)
				{
					return i;
				}
			}
		}
		else
		{
			for (int i = P_0.size() - 1; i >= 0; i += -1)
			{
				if (java.lang.Object.instancehelper_equals(P_1, P_0.get(i)))
				{
					return i;
				}
			}
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(70)]
	private Lists()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/LinkedList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 126, 102, 104 })]
	public static LinkedList newLinkedList(Iterable elements)
	{
		LinkedList linkedList = newLinkedList();
		Iterables.addAll(linkedList, elements);
		return linkedList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/concurrent/CopyOnWriteArrayList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(256)]
	public static CopyOnWriteArrayList newCopyOnWriteArrayList()
	{
		CopyOnWriteArrayList result = new CopyOnWriteArrayList();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/concurrent/CopyOnWriteArrayList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 158, 104, 104, 103 })]
	public static CopyOnWriteArrayList newCopyOnWriteArrayList(Iterable elements)
	{
		object obj = ((!(elements is Collection)) ? newArrayList(elements) : ((Collection)elements));
		CopyOnWriteArrayList result = new CopyOnWriteArrayList((obj == null) ? null : ((obj as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;[TE;)Ljava/util/List<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(314)]
	public static List asList([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object first, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object second, object[] rest)
	{
		TwoPlusArrayList result = new TwoPlusArrayList(first, second, rest);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>([Ljava/util/List<+TB;>;)Ljava/util/List<Ljava/util/List<TB;>;>;")]
	[LineNumberTable(494)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static List cartesianProduct(params List[] lists)
	{
		List result = cartesianProduct(Arrays.asList(lists));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>(Ljava/util/List<TF;>;Lcom/google/common/base/Function<-TF;+TT;>;)Ljava/util/List<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 119, 0, 0,
		18, 1, 0, 0, 0, 119, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 161, 104, 105, 9 })]
	public static List transform(List fromList, com.google.common.@base.Function function)
	{
		object result = ((!(fromList is RandomAccess)) ? ((object)new TransformingSequentialList(fromList, function)) : ((object)new TransformingRandomAccessList(fromList, function)));
		_ = null;
		return (List)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;I)Ljava/util/List<Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 45, 103, 105, 104, 105, 9 })]
	public static List partition(List list, int size)
	{
		Preconditions.checkNotNull(list);
		Preconditions.checkArgument(size > 0);
		Partition result = ((!(list is RandomAccess)) ? new Partition(list, size) : new RandomAccessPartition(list, size));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/String;)Lcom/google/common/collect/ImmutableList<Ljava/lang/Character;>;")]
	[LineNumberTable(719)]
	public static ImmutableList charactersOf(string @string)
	{
		StringAsImmutableList.___003Cclinit_003E();
		StringAsImmutableList result = new StringAsImmutableList((string)Preconditions.checkNotNull(@string));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/CharSequence;)Ljava/util/List<Ljava/lang/Character;>;")]
	[LineNumberTable(733)]
	public static List charactersOf(CharSequence sequence)
	{
		CharSequence charSequence = sequence;
		object __003Cref_003E = charSequence.___003Cref_003E;
		object obj = Preconditions.checkNotNull(__003Cref_003E);
		CharSequence.Cast(obj);
		CharSequence charSequence2 = default(CharSequence);
		object obj2 = (charSequence2.___003Cref_003E = obj);
		CharSequenceAsList result = new CharSequenceAsList(charSequence2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;)Ljava/util/List<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 119, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 183, 136, 140, 98, 98, 104, 110, 104, 137 })]
	public static List reverse(List list)
	{
		if (list is ImmutableList)
		{
			return ((ImmutableList)list).reverse();
		}
		if (list is ReverseList)
		{
			List forwardList = ((ReverseList)list).getForwardList();
			_ = null;
			return forwardList;
		}
		if (list is RandomAccess)
		{
			RandomAccessReverseList result = new RandomAccessReverseList(list);
			_ = null;
			return result;
		}
		ReverseList result2 = new ReverseList(list);
		_ = null;
		return result2;
	}
}
