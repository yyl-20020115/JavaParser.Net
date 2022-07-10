using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<C::Ljava/lang/Comparable;>Lcom/google/common/collect/ContiguousSet<TC;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class EmptyContiguousSet : ContiguousSet
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal new class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<C::Ljava/lang/Comparable;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal new sealed class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/DiscreteDomain<TC;>;")]
		private DiscreteDomain domain;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(145)]
		internal SerializedForm(DiscreteDomain P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)V")]
		[LineNumberTable(new byte[] { 98, 104, 103 })]
		private SerializedForm(DiscreteDomain P_0)
		{
			domain = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(153)]
		private object readResolve()
		{
			___003Cclinit_003E();
			EmptyContiguousSet result = new EmptyContiguousSet(domain);
			_ = null;
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
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			return readResolve();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)V")]
	[LineNumberTable(new byte[] { 159, 175, 105 })]
	internal EmptyContiguousSet(DiscreteDomain P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TC;")]
	[LineNumberTable(43)]
	public new virtual IComparable last()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchElementException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TC;")]
	[LineNumberTable(38)]
	public new virtual IComparable first()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchElementException();
	}

	[Signature("(TC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	internal override ContiguousSet tailSetImpl(IComparable P_0, bool P_1)
	{
		return this;
	}

	[Signature("(TC;ZTC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	internal override ContiguousSet subSetImpl(IComparable P_0, bool P_1, IComparable P_2, bool P_3)
	{
		return this;
	}

	[Signature("(TC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	internal override ContiguousSet headSetImpl(IComparable P_0, bool P_1)
	{
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TC;>;")]
	[LineNumberTable(101)]
	public override UnmodifiableIterator descendingIterator()
	{
		UnmodifiableIterator result = Iterators.emptyIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TC;>;")]
	[LineNumberTable(95)]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableIterator result = Iterators.emptyIterator();
		_ = null;
		return result;
	}

	public override int size()
	{
		return 0;
	}

	[Signature("(Lcom/google/common/collect/ContiguousSet<TC;>;)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	public override ContiguousSet intersection(ContiguousSet P_0)
	{
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(58)]
	public override Range range()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchElementException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(63)]
	public override Range range(BoundType P_0, BoundType P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchElementException();
	}

	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return false;
	}

	internal override int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return -1;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	public override bool isEmpty()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TC;>;")]
	[LineNumberTable(116)]
	public override ImmutableList asList()
	{
		ImmutableList result = ImmutableList.of();
		_ = null;
		return result;
	}

	public override string toString()
	{
		return "[]";
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 76, 104, 103, 137 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is Set)
		{
			Set set = (Set)P_0;
			bool result = set.isEmpty();
			_ = null;
			return result;
		}
		return false;
	}

	internal override bool isHashCodeFast()
	{
		return true;
	}

	public override int hashCode()
	{
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(162)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(domain, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
	[LineNumberTable(168)]
	internal override ImmutableSortedSet createDescendingSet()
	{
		RegularImmutableSortedSet result = ImmutableSortedSet.emptySet(Ordering.natural().reverse());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	public override object last()
	{
		IComparable result = last();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	public override object first()
	{
		IComparable result = first();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	internal override ImmutableSortedSet tailSetImpl(object P_0, bool P_1)
	{
		ContiguousSet result = tailSetImpl((IComparable)P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	internal override ImmutableSortedSet subSetImpl(object P_0, bool P_1, object P_2, bool P_3)
	{
		ContiguousSet result = subSetImpl((IComparable)P_0, P_1, (IComparable)P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	internal override ImmutableSortedSet headSetImpl(object P_0, bool P_1)
	{
		ContiguousSet result = headSetImpl((IComparable)P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	public new virtual Iterator descendingIterator()
	{
		UnmodifiableIterator result = this.descendingIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	public new virtual Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[HideFromJava]
	static EmptyContiguousSet()
	{
		ContiguousSet.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected EmptyContiguousSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
