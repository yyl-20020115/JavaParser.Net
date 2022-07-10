using System;
using System.ComponentModel;
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
[Signature("<E:Ljava/lang/Enum<TE;>;>Lcom/google/common/collect/AbstractMultiset<TE;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class EnumMultiset : AbstractMultiset, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/EnumMultiset<TE;>.Itr<TE;>;")]
	[EnclosingMethod(null, "elementIterator", "()Ljava.util.Iterator;")]
	internal class _1 : Itr
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new EnumMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(255)]
		internal new virtual java.lang.Enum output(int P_0)
		{
			return access_0024000(this_00240)[P_0];
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(252)]
		internal _1(EnumMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(252)]
		internal override object output(int P_0)
		{
			java.lang.Enum result = output(P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/EnumMultiset<TE;>.Itr<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
	internal class _2 : Itr
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/Multisets$AbstractEntry<TE;>;")]
		[EnclosingMethod(null, "output", "(I)Lcom.google.common.collect.Multiset$Entry;")]
		internal class _1 : Multisets.AbstractEntry
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal int val_0024index;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _2 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TE;")]
			[LineNumberTable(268)]
			public new virtual java.lang.Enum getElement()
			{
				return access_0024000(this_00241.this_00240)[val_0024index];
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(265)]
			internal _1(_2 P_0, int P_1)
			{
				this_00241 = P_0;
				val_0024index = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(273)]
			public override int getCount()
			{
				return access_0024100(this_00241.this_00240)[val_0024index];
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(265)]
			public override object getElement()
			{
				java.lang.Enum element = getElement();
				_ = null;
				return element;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new EnumMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(262)]
		internal _2(EnumMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[LineNumberTable(265)]
		internal new virtual Multiset.Entry output(int P_0)
		{
			_1 result = new _1(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(262)]
		internal override object output(int P_0)
		{
			Multiset.Entry result = output(P_0);
			_ = null;
			return result;
		}
	}

	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	internal abstract class Itr : java.lang.Object, Iterator
	{
		internal int index;

		internal int toRemove;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal EnumMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 105, 116, 117, 2, 240, 69 })]
		public virtual bool hasNext()
		{
			while (index < (nint)access_0024000(this_00240).LongLength)
			{
				if (access_0024100(this_00240)[index] > 0)
				{
					return true;
				}
				index++;
			}
			return false;
		}

		[Signature("(I)TT;")]
		internal abstract object output(int P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 97, 111, 103 })]
		internal Itr(EnumMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			index = 0;
			toRemove = -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 160, 115, 104, 139, 109, 108, 110 })]
		public virtual object next()
		{
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			object result = output(index);
			toRemove = index;
			index++;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 126, 113, 117, 108, 127, 0, 147, 103 })]
		public virtual void remove()
		{
			CollectPreconditions.checkRemove(toRemove >= 0);
			if (access_0024100(this_00240)[toRemove] > 0)
			{
				access_0024210(this_00240);
				access_0024322(this_00240, access_0024100(this_00240)[toRemove]);
				access_0024100(this_00240)[toRemove] = 0;
			}
			toRemove = -1;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[NonSerialized]
	[Signature("Ljava/lang/Class<TE;>;")]
	private Class type;

	[NonSerialized]
	[Signature("[TE;")]
	private java.lang.Enum[] enumConstants;

	[NonSerialized]
	private int[] counts;

	[NonSerialized]
	private new int m_distinctElements;

	[NonSerialized]
	private new long m_size;

	private const long serialVersionUID = 0L;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal static java.lang.Enum[] access_0024000(EnumMultiset P_0)
	{
		return P_0.enumConstants;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal static int[] access_0024100(EnumMultiset P_0)
	{
		return P_0.counts;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal static int access_0024210(EnumMultiset P_0)
	{
		int num = P_0.m_distinctElements;
		P_0.m_distinctElements = num - 1;
		return num;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal static long access_0024322(EnumMultiset P_0, long P_1)
	{
		long result = P_0.m_size - P_1;
		P_0.m_size = result;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<TE;>;)V")]
	[LineNumberTable(new byte[] { 40, 104, 103, 107, 113, 114 })]
	private EnumMultiset(Class P_0)
	{
		type = P_0;
		Preconditions.checkArgument(P_0.isEnum());
		enumConstants = (java.lang.Enum[])P_0.getEnumConstants();
		counts = new int[(nint)enumConstants.LongLength];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Class<TE;>;)Lcom/google/common/collect/EnumMultiset<TE;>;")]
	[LineNumberTable(52)]
	public static EnumMultiset create(Class type)
	{
		EnumMultiset result = new EnumMultiset(type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 48, 104, 103, 103, 154 })]
	private bool isActuallyE([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is java.lang.Enum)
		{
			java.lang.Enum @enum = (java.lang.Enum)P_0;
			int num = @enum.ordinal();
			return (num < (nint)enumConstants.LongLength && enumConstants[num] == @enum) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 61, 103, 108, 159, 71 })]
	private void checkIsE(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		if (!isActuallyE(P_0))
		{
			string text = java.lang.String.valueOf(type);
			string text2 = java.lang.String.valueOf(P_0);
			int num = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string s = new StringBuilder(num).append("Expected an ").append(text).append(" but got ")
				.append(text2)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ClassCastException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 80, 108, 130, 103 })]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		if (element == null || !isActuallyE(element))
		{
			return 0;
		}
		java.lang.Enum @enum = (java.lang.Enum)element;
		return counts[@enum.ordinal()];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(new byte[]
	{
		160, 76, 103, 108, 103, 105, 105, 113, 103, 112,
		103, 142
	})]
	public virtual int setCount(java.lang.Enum element, int count)
	{
		checkIsE(element);
		CollectPreconditions.checkNonnegative(count, "count");
		int num = element.ordinal();
		int num2 = counts[num];
		counts[num] = count;
		this.m_size += count - num2;
		if (num2 == 0 && count > 0)
		{
			this.m_distinctElements++;
		}
		else if (num2 > 0 && count == 0)
		{
			this.m_distinctElements--;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(new byte[]
	{
		91, 103, 108, 99, 138, 103, 105, 102, 119, 106,
		99, 142, 111
	})]
	public virtual int add(java.lang.Enum element, int occurrences)
	{
		checkIsE(element);
		CollectPreconditions.checkNonnegative(occurrences, "occurrences");
		if (occurrences == 0)
		{
			int result = count(element);
			_ = null;
			return result;
		}
		int num = element.ordinal();
		int num2 = counts[num];
		long num3 = (long)num2 + (long)occurrences;
		Preconditions.checkArgument(num3 <= 2147483647u, "too many occurrences: %s", num3);
		counts[num] = (int)num3;
		if (num2 == 0)
		{
			this.m_distinctElements++;
		}
		this.m_size += occurrences;
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Iterable<TE;>;)Lcom/google/common/collect/EnumMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 14, 103, 112, 118, 104 })]
	public static EnumMultiset create(Iterable elements)
	{
		Iterator iterator = elements.iterator();
		Preconditions.checkArgument(iterator.hasNext(), (object)"EnumMultiset constructor passed empty Iterable");
		EnumMultiset enumMultiset = new EnumMultiset(((java.lang.Enum)iterator.next()).getDeclaringClass());
		Iterables.addAll(enumMultiset, elements);
		return enumMultiset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Iterable<TE;>;Ljava/lang/Class<TE;>;)Lcom/google/common/collect/EnumMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 28, 103, 104 })]
	public static EnumMultiset create(Iterable elements, Class type)
	{
		EnumMultiset enumMultiset = create(type);
		Iterables.addAll(enumMultiset, elements);
		return enumMultiset;
	}

	internal override int distinctElements()
	{
		return this.m_distinctElements;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	public override int size()
	{
		int result = Ints.saturatedCast(this.m_size);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		113, 108, 130, 103, 108, 99, 138, 103, 105, 99,
		98, 100, 105, 110, 145, 107, 143
	})]
	public override int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element, int occurrences)
	{
		if (element == null || !isActuallyE(element))
		{
			return 0;
		}
		java.lang.Enum @enum = (java.lang.Enum)element;
		CollectPreconditions.checkNonnegative(occurrences, "occurrences");
		if (occurrences == 0)
		{
			int result = count(element);
			_ = null;
			return result;
		}
		int num = @enum.ordinal();
		int num2 = counts[num];
		if (num2 == 0)
		{
			return 0;
		}
		if (num2 <= occurrences)
		{
			counts[num] = 0;
			this.m_distinctElements--;
			this.m_size -= num2;
		}
		else
		{
			counts[num] = num2 - occurrences;
			this.m_size -= occurrences;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 92, 108, 104, 103 })]
	public override void clear()
	{
		Arrays.fill(counts, 0);
		this.m_size = 0L;
		this.m_distinctElements = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(252)]
	internal override Iterator elementIterator()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(262)]
	internal override Iterator entryIterator()
	{
		_2 result = new _2(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/ObjIntConsumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 160, 168, 103, 108, 107, 22, 230, 69 })]
	public override void forEachEntry(ObjIntConsumer action)
	{
		Preconditions.checkNotNull(action);
		for (int i = 0; i < (nint)enumConstants.LongLength; i++)
		{
			if (counts[i] > 0)
			{
				action.accept(enumConstants[i], counts[i]);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(292)]
	public override Iterator iterator()
	{
		Iterator result = Multisets.iteratorImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 183, 102, 108, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeObject(type);
		Serialization.writeMultiset(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 160, 194, 134, 108, 103, 118, 114, 105 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		Class @class = (type = (Class)P_0.readObject());
		enumConstants = (java.lang.Enum[])type.getEnumConstants();
		counts = new int[(nint)enumConstants.LongLength];
		Serialization.populateMultiset(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set entrySet()
	{
		Set result = base.entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set elementSet()
	{
		Set result = base.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override bool setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, int i1, int i2)
	{
		bool result = base.setCount(obj, i1, i2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(46)]
	public override int setCount(object obj, int i)
	{
		int result = setCount((java.lang.Enum)obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(46)]
	public override int add(object obj, int i)
	{
		int result = add((java.lang.Enum)obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
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
	[LineNumberTable(46)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(EnumMultiset P_0)
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
	protected EnumMultiset(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|add", "(Ljava.lang.Object;)Z")]
	public new bool add(object P_0)
	{
		return ((AbstractMultiset)this).add(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|remove", "(Ljava.lang.Object;)Z")]
	public new bool remove(object P_0)
	{
		return ((AbstractMultiset)this).remove(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|addAll", "(Ljava.util.Collection;)Z")]
	public new bool addAll(Collection P_0)
	{
		return ((AbstractMultiset)this).addAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|removeAll", "(Ljava.util.Collection;)Z")]
	public new bool removeAll(Collection P_0)
	{
		return ((AbstractMultiset)this).removeAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|retainAll", "(Ljava.util.Collection;)Z")]
	public new bool retainAll(Collection P_0)
	{
		return ((AbstractMultiset)this).retainAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|equals", "(Ljava.lang.Object;)Z")]
	public new bool equals(object P_0)
	{
		return ((AbstractMultiset)this).equals(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>6|hashCode", "()I")]
	public new int hashCode()
	{
		return ((AbstractMultiset)this).hashCode();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>7|toString", "()Ljava.lang.String;")]
	public new string toString()
	{
		return ((AbstractMultiset)this).toString();
	}
}
