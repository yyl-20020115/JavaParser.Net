using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Ljava/io/Serializable;")]
[ConstantPool(new object[]
{
	(byte)69,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ImmutableList.of or another implementation"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public abstract class ImmutableCollection : AbstractCollection, Serializable.__Interface, ISerializable
{
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;")]
	[DoNotMock(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/DoNotMock;"
	})]
	public abstract class Builder : java.lang.Object
	{
		internal const int DEFAULT_INITIAL_CAPACITY = 4;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 35, 100, 176, 104, 100, 139, 100, 166 })]
		internal static int expandedCapacity(int P_0, int P_1)
		{
			if (P_1 < 0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError("cannot store more than MAX_VALUE elements");
			}
			int num = P_0 + (P_0 >> 1) + 1;
			if (num < P_1)
			{
				num = Integer.highestOneBit(P_1 - 1) << 1;
			}
			if (num < 0)
			{
				num = int.MaxValue;
			}
			return num;
		}

		[Signature("(TE;)Lcom/google/common/collect/ImmutableCollection$Builder<TE;>;")]
		public abstract Builder add(object obj);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(420)]
		internal Builder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([TE;)Lcom/google/common/collect/ImmutableCollection$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 76, 111, 40, 166 })]
		public virtual Builder add(params object[] elements)
		{
			int num = elements.Length;
			for (int i = 0; i < num; i++)
			{
				object obj = elements[i];
				add(obj);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableCollection$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 94, 118, 104, 98 })]
		public virtual Builder addAll(Iterable elements)
		{
			Iterator iterator = elements.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				add(obj);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableCollection$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 112, 104, 143 })]
		public virtual Builder addAll(Iterator elements)
		{
			while (elements.hasNext())
			{
				add(elements.next());
			}
			return this;
		}

		[Signature("()Lcom/google/common/collect/ImmutableCollection<TE;>;")]
		public abstract ImmutableCollection build();
	}

	internal const int SPLITERATOR_CHARACTERISTICS = 1296;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static object[] EMPTY_ARRAY;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	public new abstract UnmodifiableIterator iterator();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 160, 246, 151, 136, 147 })]
	public virtual ImmutableList asList()
	{
		switch (size())
		{
		case 0:
		{
			ImmutableList result3 = ImmutableList.of();
			_ = null;
			return result3;
		}
		case 1:
		{
			ImmutableList result2 = ImmutableList.of(iterator().next());
			_ = null;
			return result2;
		}
		default:
		{
			RegularImmutableAsList.___003Cclinit_003E();
			RegularImmutableAsList result = new RegularImmutableAsList(this, toArray());
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 69, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		160, 98, 103, 135, 101, 103, 99, 150, 105, 103,
		132, 105
	})]
	public sealed override object[] toArray(object[] other)
	{
		Preconditions.checkNotNull(other);
		int num = size();
		if ((nint)other.LongLength < num)
		{
			object[] array = internalArray();
			if (array != null)
			{
				object[] result = Platform.copy(array, internalArrayStart(), internalArrayEnd(), other);
				_ = null;
				return result;
			}
			other = ObjectArrays.newArray(other, num);
		}
		else if ((nint)other.LongLength > num)
		{
			other[num] = null;
		}
		copyIntoArray(other, 0);
		return other;
	}

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual object[] internalArray()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(239)]
	internal virtual int internalArrayStart()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(247)]
	internal virtual int internalArrayEnd()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 69, 0,
		0
	})]
	[LineNumberTable(new byte[] { 161, 14, 118, 105, 98 })]
	internal virtual int copyIntoArray(object[] P_0, int P_1)
	{
		UnmodifiableIterator unmodifiableIterator = iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			object obj = ((Iterator)unmodifiableIterator).next();
			int num = P_1;
			P_1++;
			P_0[num] = obj;
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(193)]
	public sealed override object[] toArray()
	{
		object[] result = toArray(EMPTY_ARRAY);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(178)]
	internal ImmutableCollection()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(186)]
	public override Spliterator spliterator()
	{
		Spliterator result = Spliterators.spliterator(this, 1296);
		_ = null;
		return result;
	}

	public abstract override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TE;)Z")]
	[LineNumberTable(264)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool add(object e)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(278)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/Collection<+TE;>;)Z")]
	[LineNumberTable(292)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool addAll(Collection newElements)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(306)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool removeAll(Collection oldElements)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/function/Predicate<-TE;>;)Z")]
	[LineNumberTable(320)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool removeIf(java.util.function.Predicate filter)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(333)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool retainAll(Collection elementsToKeep)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(346)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override void clear()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual bool isPartialView()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableCollection.isPartialView()Z");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(392)]
	internal virtual object writeReplace()
	{
		ImmutableList.SerializedForm result = new ImmutableList.SerializedForm(toArray());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(163)]
	public virtual Iterator _003Cbridge_003Eiterator()
	{
		UnmodifiableIterator result = iterator();
		_ = null;
		return result;
	}

	[LineNumberTable(189)]
	static ImmutableCollection()
	{
		EMPTY_ARRAY = new object[0];
	}

	[HideFromJava]
	public static implicit operator Serializable(ImmutableCollection P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
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
	protected ImmutableCollection(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
