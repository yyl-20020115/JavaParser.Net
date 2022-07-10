using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableCollection<TE;>;Ljava/util/List<TE;>;Ljava/util/RandomAccess;")]
[ConstantPool(new object[]
{
	(byte)183,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.List", "java.util.RandomAccess" })]
public abstract class ImmutableList : ImmutableCollection, List, Collection, Iterable, IEnumerable, RandomAccess
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/AbstractIndexedListIterator<TE;>;")]
	[EnclosingMethod(null, "listIterator", "(I)Lcom.google.common.collect.UnmodifiableListIterator;")]
	internal class _1 : AbstractIndexedListIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableList this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(409)]
		internal _1(ImmutableList P_0, int P_1, int P_2)
		{
			this_00240 = P_0;
			base._002Ector(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(412)]
		protected internal override object get(int P_0)
		{
			object result = this_00240.get(P_0);
			_ = null;
			return result;
		}
	}

	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableCollection$Builder<TE;>;")]
	[ConstantPool(new object[]
	{
		(byte)33,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public new sealed class Builder : ImmutableCollection.Builder
	{
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 33, 0, 0 })]
		internal object[] contents;

		private int size;

		private bool forceCopy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableList$Builder<TE;>;")]
		[LineNumberTable(new byte[]
		{
			162, 232, 103, 104, 103, 115, 104, 103, 120, 162,
			104
		})]
		public new virtual Builder addAll(Iterable elements)
		{
			Preconditions.checkNotNull(elements);
			if (elements is Collection)
			{
				Collection collection = (Collection)elements;
				getReadyToExpandTo(size + collection.size());
				if (collection is ImmutableCollection)
				{
					ImmutableCollection immutableCollection = (ImmutableCollection)collection;
					size = immutableCollection.copyIntoArray(contents, size);
					return this;
				}
			}
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
		[LineNumberTable(new byte[] { 163, 16, 103 })]
		public new virtual ImmutableList build()
		{
			forceCopy = true;
			ImmutableList result = asImmutableList(contents, size);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableList$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 162, 187, 103, 110, 123 })]
		public new virtual Builder add(object element)
		{
			Preconditions.checkNotNull(element);
			getReadyToExpandTo(size + 1);
			object[] array = contents;
			int num = size;
			size = num + 1;
			array[num] = element;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 159, 105 })]
		public Builder()
			: this(4)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableList$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 163, 0, 104 })]
		public new virtual Builder addAll(Iterator elements)
		{
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 162, 104, 108, 103 })]
		internal Builder(int P_0)
		{
			contents = new object[P_0];
			size = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableList$Builder<TE;>;)Lcom/google/common/collect/ImmutableList$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 163, 6, 103, 114 })]
		internal virtual Builder combine(Builder P_0)
		{
			Preconditions.checkNotNull(P_0);
			add(P_0.contents, P_0.size);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 168, 106, 126, 105, 104, 120, 135 })]
		private void getReadyToExpandTo(int P_0)
		{
			if ((nint)contents.LongLength < P_0)
			{
				contents = Arrays.copyOf(contents, ImmutableCollection.Builder.expandedCapacity(contents.Length, P_0));
				forceCopy = false;
			}
			else if (forceCopy)
			{
				contents = Arrays.copyOf(contents, contents.Length);
				forceCopy = false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 0, 1, 0, 0, 0, 33, 0,
			0
		})]
		[LineNumberTable(new byte[] { 162, 209, 238, 73, 116, 110 })]
		private void add(object[] P_0, int P_1)
		{
			getReadyToExpandTo(size + P_1);
			ByteCodeHelper.arraycopy(P_0, 0, contents, size, P_1);
			size += P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([TE;)Lcom/google/common/collect/ImmutableList$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 162, 203, 103, 105 })]
		public new virtual Builder add(params object[] elements)
		{
			ObjectArrays.checkElementsNotNull(elements);
			add(elements, elements.Length);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(774)]
		public virtual ImmutableCollection _003Cbridge_003Ebuild()
		{
			ImmutableList result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(774)]
		public virtual ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterator i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(774)]
		public virtual ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterable i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(774)]
		public virtual ImmutableCollection.Builder _003Cbridge_003Eadd(object[] objarr)
		{
			Builder result = add(objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(774)]
		public virtual ImmutableCollection.Builder _003Cbridge_003Eadd(object obj)
		{
			Builder result = add(obj);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableList<TE;>;")]
	internal class ReverseImmutableList : ImmutableList
	{
		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
		private ImmutableList forwardList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableList<TE;>;)V")]
		[LineNumberTable(new byte[] { 162, 0, 104, 103 })]
		internal ReverseImmutableList(ImmutableList P_0)
		{
			forwardList = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(674)]
		public override int size()
		{
			int result = forwardList.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(631)]
		private int reverseIndex(int P_0)
		{
			return size() - 1 - P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(635)]
		private int reversePosition(int P_0)
		{
			return size() - P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Lcom/google/common/collect/ImmutableList<TE;>;")]
		[LineNumberTable(new byte[] { 162, 36, 109 })]
		public override ImmutableList subList(int P_0, int P_1)
		{
			Preconditions.checkPositionIndexes(P_0, P_1, size());
			ImmutableList result = forwardList.subList(reversePosition(P_1), reversePosition(P_0)).reverse();
			_ = null;
			return result;
		}

		[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
		public override ImmutableList reverse()
		{
			return forwardList;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(645)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = forwardList.contains(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 24, 109 })]
		public override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int num = forwardList.lastIndexOf(P_0);
			return (num < 0) ? (-1) : reverseIndex(num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 30, 109 })]
		public override int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int num = forwardList.indexOf(P_0);
			return (num < 0) ? (-1) : reverseIndex(num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(new byte[] { 162, 42, 109 })]
		public override object get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			object result = forwardList.get(reverseIndex(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(679)]
		internal override bool isPartialView()
		{
			bool result = forwardList.isPartialView();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(623)]
		public new virtual List subList(int P_0, int P_1)
		{
			ImmutableList result = this.subList(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(623)]
		public new virtual ListIterator listIterator(int P_0)
		{
			UnmodifiableListIterator result = base.listIterator(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(623)]
		public new virtual ListIterator listIterator()
		{
			UnmodifiableListIterator result = base.listIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(623)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = base.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static ReverseImmutableList()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ReverseImmutableList(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		internal object[] elements;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 82, 104, 103 })]
		internal SerializedForm(object[] P_0)
		{
			elements = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(713)]
		internal virtual object readResolve()
		{
			ImmutableList result = copyOf(elements);
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
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(SerializedForm))
			{
				return this;
			}
			return readResolve();
		}
	}

	[Serializable]
	[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
	internal class SubList : ImmutableList
	{
		[NonSerialized]
		[Modifiers(Modifiers.Final | Modifiers.Transient)]
		internal int offset;

		[NonSerialized]
		[Modifiers(Modifiers.Final | Modifiers.Transient)]
		internal int length;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableList this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 105, 111, 103, 103 })]
		internal SubList(ImmutableList P_0, int P_1, int P_2)
		{
			this_00240 = P_0;
			base._002Ector();
			offset = P_1;
			length = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Lcom/google/common/collect/ImmutableList<TE;>;")]
		[LineNumberTable(new byte[] { 161, 123, 109 })]
		public override ImmutableList subList(int P_0, int P_1)
		{
			Preconditions.checkPositionIndexes(P_0, P_1, length);
			ImmutableList result = this_00240.subList(P_0 + offset, P_1 + offset);
			_ = null;
			return result;
		}

		public override int size()
		{
			return length;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(new byte[] { 161, 117, 109 })]
		public override object get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, length);
			object result = this_00240.get(P_0 + offset);
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(471)]
		public new virtual List subList(int P_0, int P_1)
		{
			ImmutableList result = this.subList(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(471)]
		public new virtual ListIterator listIterator(int P_0)
		{
			UnmodifiableListIterator result = base.listIterator(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(471)]
		public new virtual ListIterator listIterator()
		{
			UnmodifiableListIterator result = base.listIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(471)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = base.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static SubList()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SubList(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : IntFunction
	{
		private readonly ImmutableList arg_00241;

		internal ___003C_003EAnon0(ImmutableList P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(int P_0)
		{
			object result = ((List)arg_00241).get(P_0);
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(100)]
	public static ImmutableList of(object element)
	{
		SingletonImmutableList result = new SingletonImmutableList(element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableList$Builder<TE;>;")]
	[LineNumberTable(733)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 160, 122, 103, 104, 109, 13 })]
	public static ImmutableList copyOf(Iterable elements)
	{
		Preconditions.checkNotNull(elements);
		ImmutableList result = ((!(elements is Collection)) ? copyOf(elements.iterator()) : copyOf((Collection)elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 160, 229, 135, 103, 103, 103 })]
	public static ImmutableList sortedCopyOf(Comparator comparator, Iterable elements)
	{
		Preconditions.checkNotNull(comparator);
		object[] array = Iterables.toArray(elements);
		ObjectArrays.checkElementsNotNull(array);
		Arrays.sort(array, comparator);
		ImmutableList result = asImmutableList(array);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract object get(int P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(89)]
	public static ImmutableList of()
	{
		return RegularImmutableList.EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(353)]
	private static ImmutableList construct(params object[] P_0)
	{
		ImmutableList result = asImmutableList(ObjectArrays.checkElementsNotNull(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<+TE;>;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 160, 146, 136, 108, 151 })]
	public static ImmutableList copyOf(Collection elements)
	{
		if (elements is ImmutableCollection)
		{
			ImmutableList immutableList = ((ImmutableCollection)elements).asList();
			return (!immutableList.isPartialView()) ? immutableList : asImmutableList(immutableList.toArray());
		}
		ImmutableList result = construct(elements.toArray());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 160, 161, 104, 136, 103, 104, 137 })]
	public static ImmutableList copyOf(Iterator elements)
	{
		if (!elements.hasNext())
		{
			ImmutableList result = of();
			_ = null;
			return result;
		}
		object element = elements.next();
		if (!elements.hasNext())
		{
			ImmutableList result2 = of(element);
			_ = null;
			return result2;
		}
		ImmutableList result3 = new Builder().add(element).addAll(elements).build();
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([Ljava/lang/Object;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(362)]
	internal static ImmutableList asImmutableList(object[] P_0)
	{
		ImmutableList result = asImmutableList(P_0, P_0.Length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([Ljava/lang/Object;I)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 183, 0,
		0
	})]
	[LineNumberTable(new byte[] { 161, 0, 146, 232, 71, 105, 233, 72, 112 })]
	internal static ImmutableList asImmutableList(object[] P_0, int P_1)
	{
		switch (P_1)
		{
		case 0:
		{
			ImmutableList result3 = of();
			_ = null;
			return result3;
		}
		case 1:
		{
			object element = java.util.Objects.requireNonNull(P_0[0]);
			ImmutableList result2 = of(element);
			_ = null;
			return result2;
		}
		default:
		{
			object[] array = ((P_1 >= (nint)P_0.LongLength) ? P_0 : Arrays.copyOf(P_0, P_1));
			RegularImmutableList result = new RegularImmutableList(array);
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableListIterator<TE;>;")]
	[LineNumberTable(404)]
	public virtual UnmodifiableListIterator listIterator()
	{
		UnmodifiableListIterator result = listIterator(0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/UnmodifiableListIterator<TE;>;")]
	[LineNumberTable(409)]
	public virtual UnmodifiableListIterator listIterator(int index)
	{
		_1 result = new _1(this, size(), index);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(428)]
	public virtual int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		int result = ((@object != null) ? Lists.indexOfImpl(this, @object) : (-1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(468)]
	internal virtual ImmutableList subListUnchecked(int P_0, int P_1)
	{
		SubList result = new SubList(this, P_0, P_1 - P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(399)]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableListIterator result = listIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 161, 80, 109, 100, 105, 98, 99, 104, 100, 143 })]
	public virtual ImmutableList subList(int fromIndex, int toIndex)
	{
		Preconditions.checkPositionIndexes(fromIndex, toIndex, size());
		int num = toIndex - fromIndex;
		if (num == size())
		{
			return this;
		}
		switch (num)
		{
		case 0:
		{
			ImmutableList result3 = of();
			_ = null;
			return result3;
		}
		case 1:
		{
			ImmutableList result2 = of(get(fromIndex));
			_ = null;
			return result2;
		}
		default:
		{
			ImmutableList result = subListUnchecked(fromIndex, toIndex);
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableList<TE;>;>;")]
	[LineNumberTable(76)]
	public static Collector toImmutableList()
	{
		Collector result = CollectCollectors.toImmutableList();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(109)]
	public static ImmutableList of(object e1, object e2)
	{
		ImmutableList result = construct(e1, e2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(118)]
	public static ImmutableList of(object e1, object e2, object e3)
	{
		ImmutableList result = construct(e1, e2, e3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(127)]
	public static ImmutableList of(object e1, object e2, object e3, object e4)
	{
		ImmutableList result = construct(e1, e2, e3, e4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(136)]
	public static ImmutableList of(object e1, object e2, object e3, object e4, object e5)
	{
		ImmutableList result = construct(e1, e2, e3, e4, e5);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(145)]
	public static ImmutableList of(object e1, object e2, object e3, object e4, object e5, object e6)
	{
		ImmutableList result = construct(e1, e2, e3, e4, e5, e6);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(154)]
	public static ImmutableList of(object e1, object e2, object e3, object e4, object e5, object e6, object e7)
	{
		ImmutableList result = construct(e1, e2, e3, e4, e5, e6, e7);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(163)]
	public static ImmutableList of(object e1, object e2, object e3, object e4, object e5, object e6, object e7, object e8)
	{
		ImmutableList result = construct(e1, e2, e3, e4, e5, e6, e7, e8);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(172)]
	public static ImmutableList of(object e1, object e2, object e3, object e4, object e5, object e6, object e7, object e8, object e9)
	{
		ImmutableList result = construct(e1, e2, e3, e4, e5, e6, e7, e8, e9);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(182)]
	public static ImmutableList of(object e1, object e2, object e3, object e4, object e5, object e6, object e7, object e8, object e9, object e10)
	{
		ImmutableList result = construct(e1, e2, e3, e4, e5, e6, e7, e8, e9, e10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(192)]
	public static ImmutableList of(object e1, object e2, object e3, object e4, object e5, object e6, object e7, object e8, object e9, object e10, object e11)
	{
		ImmutableList result = construct(e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;TE;TE;TE;TE;TE;TE;[TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[]
	{
		160, 95, 151, 108, 100, 100, 100, 100, 101, 101,
		101, 101, 101, 102, 102, 102, 110
	})]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static ImmutableList of(object e1, object e2, object e3, object e4, object e5, object e6, object e7, object e8, object e9, object e10, object e11, object e12, params object[] others)
	{
		Preconditions.checkArgument((nint)others.LongLength <= 2147483635, (object)"the total number of elements must fit in an int");
		object[] array = new object[12 + (nint)others.LongLength];
		array[0] = e1;
		array[1] = e2;
		array[2] = e3;
		array[3] = e4;
		array[4] = e5;
		array[5] = e6;
		array[6] = e7;
		array[7] = e8;
		array[8] = e9;
		array[9] = e10;
		array[10] = e11;
		array[11] = e12;
		ByteCodeHelper.arraycopy(others, 0, array, 12, others.Length);
		ImmutableList result = construct(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 160, 179, 147, 136, 139 })]
	public static ImmutableList copyOf(object[] elements)
	{
		switch (elements.LongLength)
		{
		case 0L:
		{
			ImmutableList result3 = of();
			_ = null;
			return result3;
		}
		case 1L:
		{
			ImmutableList result2 = of(elements[0]);
			_ = null;
			return result2;
		}
		default:
		{
			ImmutableList result = construct((object[])elements.Clone());
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 160, 206, 114, 108, 102 })]
	public static ImmutableList sortedCopyOf(Iterable elements)
	{
		IComparable[] array = (IComparable[])Iterables.toArray(elements, new IComparable[0]);
		ObjectArrays.checkElementsNotNull(array);
		Arrays.sort(array);
		ImmutableList result = asImmutableList(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(393)]
	internal ImmutableList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 161, 49, 103, 103, 102, 45, 166 })]
	public override void forEach(Consumer consumer)
	{
		Preconditions.checkNotNull(consumer);
		int num = size();
		for (int i = 0; i < num; i++)
		{
			consumer.accept(get(i));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(433)]
	public virtual int lastIndexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		int result = ((@object != null) ? Lists.lastIndexOfImpl(this, @object) : (-1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(438)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		return indexOf(@object) >= 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(ILjava/util/Collection<+TE;>;)Z")]
	[LineNumberTable(514)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public bool addAll(int index, Collection newElements)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(ITE;)TE;")]
	[LineNumberTable(528)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public object set(int index, object element)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(ITE;)V")]
	[LineNumberTable(541)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void add(int index, object element)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(I)TE;")]
	[LineNumberTable(555)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public object remove(int index)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/function/UnaryOperator<TE;>;)V")]
	[LineNumberTable(568)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void replaceAll(UnaryOperator @operator)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/Comparator<-TE;>;)V")]
	[LineNumberTable(581)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public void sort(Comparator c)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Obsolete]
	[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override ImmutableList asList()
	{
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(599)]
	public override Spliterator spliterator()
	{
		Spliterator result = CollectSpliterators.indexed(size(), 1296, new ___003C_003EAnon0(this));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 183, 0,
		0
	})]
	[LineNumberTable(new byte[] { 161, 235, 103, 102, 44, 166 })]
	internal override int copyIntoArray(object[] P_0, int P_1)
	{
		int num = size();
		for (int i = 0; i < num; i++)
		{
			P_0[P_1 + i] = get(i);
		}
		return P_1 + num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(620)]
	public virtual ImmutableList reverse()
	{
		ImmutableList result = ((size() > 1) ? new ReverseImmutableList(this) : this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(685)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = Lists.equalsImpl(this, obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 64, 98, 103, 102, 146, 230, 61, 230, 70 })]
	public override int hashCode()
	{
		int num = 1;
		int num2 = size();
		for (int i = 0; i < num2; i++)
		{
			num = 31 * num + java.lang.Object.instancehelper_hashCode(get(i));
			num = num ^ -1 ^ -1;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.InvalidObjectException" })]
	[LineNumberTable(720)]
	private void readObject(ObjectInputStream P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new InvalidObjectException("Use SerializedForm");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(725)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(toArray());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Lcom/google/common/collect/ImmutableList$Builder<TE;>;")]
	[LineNumberTable(new byte[] { 162, 124, 108 })]
	public static Builder builderWithExpectedSize(int expectedSize)
	{
		CollectPreconditions.checkNonnegative(expectedSize, "expectedSize");
		Builder result = new Builder(expectedSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public override Iterator _003Cbridge_003Eiterator()
	{
		UnmodifiableIterator result = iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual List _003Cbridge_003EsubList(int i1, int i2)
	{
		ImmutableList result = subList(i1, i2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual ListIterator _003Cbridge_003ElistIterator(int i)
	{
		UnmodifiableListIterator result = listIterator(i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(63)]
	public virtual ListIterator _003Cbridge_003ElistIterator()
	{
		UnmodifiableListIterator result = listIterator();
		_ = null;
		return result;
	}

	[HideFromJava]
	static ImmutableList()
	{
		ImmutableCollection.___003Cclinit_003E();
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	Iterator List.List_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	int List.List_003A_003Asize()
	{
		return size();
	}

	bool List.List_003A_003AisEmpty()
	{
		return isEmpty();
	}

	List List.List_003A_003AsubList(int P_0, int P_1)
	{
		return _003Cbridge_003EsubList(P_0, P_1);
	}

	ListIterator List.List_003A_003AlistIterator()
	{
		return _003Cbridge_003ElistIterator();
	}

	bool List.List_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	ListIterator List.List_003A_003AlistIterator(int P_0)
	{
		return _003Cbridge_003ElistIterator(P_0);
	}

	Iterator Collection.Collection_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	int Collection.Collection_003A_003Asize()
	{
		return size();
	}

	bool Collection.Collection_003A_003AisEmpty()
	{
		return isEmpty();
	}

	bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	Stream Collection.Collection_003A_003Astream()
	{
		return stream();
	}

	Stream Collection.Collection_003A_003AparallelStream()
	{
		return parallelStream();
	}

	Iterator Iterable.Iterable_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableList(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
