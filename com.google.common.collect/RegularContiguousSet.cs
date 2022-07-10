using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
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
internal sealed class RegularContiguousSet : ContiguousSet
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/AbstractSequentialIterator<TC;>;")]
	[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
	internal new class _1 : AbstractSequentialIterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TC;")]
		internal IComparable last;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal RegularContiguousSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)TC;")]
		[LineNumberTable(89)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal virtual IComparable computeNext(IComparable P_0)
		{
			IComparable result = ((!access_0024000(P_0, last)) ? this_00240.domain.next(P_0) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 33, 112 })]
		internal _1(RegularContiguousSet P_0, IComparable P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
			last = this_00240.last();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(83)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext(object P_0)
		{
			IComparable result = computeNext((IComparable)P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/AbstractSequentialIterator<TC;>;")]
	[EnclosingMethod(null, "descendingIterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _2 : AbstractSequentialIterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TC;")]
		internal IComparable first;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal RegularContiguousSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 47, 112 })]
		internal _2(RegularContiguousSet P_0, IComparable P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
			first = this_00240.first();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)TC;")]
		[LineNumberTable(103)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal virtual IComparable computeNext(IComparable P_0)
		{
			IComparable result = ((!access_0024000(P_0, first)) ? this_00240.domain.previous(P_0) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(97)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext(object P_0)
		{
			IComparable result = computeNext((IComparable)P_0);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[SpecialName]
	[Signature("Lcom/google/common/collect/ImmutableAsList<TC;>;")]
	[EnclosingMethod(null, "createAsList", "()Lcom.google.common.collect.ImmutableList;")]
	internal class _3 : ImmutableAsList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal RegularContiguousSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(132)]
		internal _3(RegularContiguousSet P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
		internal new virtual ImmutableSortedSet delegateCollection()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TC;")]
		[LineNumberTable(new byte[] { 90, 109 })]
		public new virtual IComparable get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			IComparable result = this_00240.domain.offset(this_00240.first(), P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(132)]
		internal override ImmutableCollection delegateCollection()
		{
			ImmutableSortedSet result = delegateCollection();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(132)]
		public override object get(int P_0)
		{
			IComparable result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static _3()
		{
			ImmutableAsList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _3(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<C::Ljava/lang/Comparable;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal new sealed class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Range<TC;>;")]
		internal Range range;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/DiscreteDomain<TC;>;")]
		internal DiscreteDomain domain;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(224)]
		internal SerializedForm(Range P_0, DiscreteDomain P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;Lcom/google/common/collect/DiscreteDomain<TC;>;)V")]
		[LineNumberTable(new byte[] { 160, 114, 104, 103, 103 })]
		private SerializedForm(Range P_0, DiscreteDomain P_1)
		{
			range = P_0;
			domain = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(234)]
		private object readResolve()
		{
			___003Cclinit_003E();
			RegularContiguousSet result = new RegularContiguousSet(range, domain);
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

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Range<TC;>;")]
	private new Range m_range;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;Lcom/google/common/collect/DiscreteDomain<TC;>;)V")]
	[LineNumberTable(new byte[] { 159, 183, 105, 103 })]
	internal RegularContiguousSet(Range P_0, DiscreteDomain P_1)
		: base(P_1)
	{
		this.m_range = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TC;")]
	[LineNumberTable(126)]
	public new virtual IComparable last()
	{
		return (IComparable)java.util.Objects.requireNonNull(this.m_range.upperBound.greatestValueBelow(domain));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(37)]
	internal static bool access_0024000(IComparable P_0, IComparable P_1)
	{
		bool result = equalsOrThrow(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Comparable<*>;Ljava/lang/Comparable<*>;)Z")]
	[LineNumberTable(109)]
	private static bool equalsOrThrow(IComparable P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] IComparable P_1)
	{
		return (P_1 != null && Range.compareOrThrow(P_0, P_1) == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(new byte[] { 159, 188, 110, 121, 18 })]
	private ContiguousSet intersectionInCurrentDomain(Range P_0)
	{
		object result;
		if (this.m_range.isConnected(P_0))
		{
			result = ContiguousSet.create(this.m_range.intersection(P_0), domain);
		}
		else
		{
			EmptyContiguousSet.___003Cclinit_003E();
			result = new EmptyContiguousSet(domain);
		}
		_ = null;
		return (ContiguousSet)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 107, 99, 162, 127, 11, 97 })]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		//Discarded unreachable code: IL_0018
		if (P_0 == null)
		{
			return false;
		}
		try
		{
			return this.m_range.contains((IComparable)P_0);
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TC;")]
	[LineNumberTable(120)]
	public new virtual IComparable first()
	{
		return (IComparable)java.util.Objects.requireNonNull(this.m_range.lowerBound.leastValueAbove(domain));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 160, 85, 114, 119, 5 })]
	public override Range range(BoundType P_0, BoundType P_1)
	{
		Range result = Range.create(this.m_range.lowerBound.withLowerBoundType(P_0, domain), this.m_range.upperBound.withUpperBoundType(P_1, domain));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(71)]
	internal override ContiguousSet tailSetImpl(IComparable P_0, bool P_1)
	{
		ContiguousSet result = intersectionInCurrentDomain(Range.downTo(P_0, BoundType.forBoolean(P_1)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;ZTC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(new byte[] { 159, 128, 165, 143, 147, 131, 103, 5, 37 })]
	internal override ContiguousSet subSetImpl(IComparable P_0, bool P_1, IComparable P_2, bool P_3)
	{
		if (Comparable.__Helper.compareTo(P_0, P_2) == 0 && !P_1 && !P_3)
		{
			EmptyContiguousSet.___003Cclinit_003E();
			EmptyContiguousSet result = new EmptyContiguousSet(domain);
			_ = null;
			return result;
		}
		ContiguousSet result2 = intersectionInCurrentDomain(Range.range(P_0, BoundType.forBoolean(P_1), P_2, BoundType.forBoolean(P_3)));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(53)]
	internal override ContiguousSet headSetImpl(IComparable P_0, bool P_1)
	{
		ContiguousSet result = intersectionInCurrentDomain(Range.upTo(P_0, BoundType.forBoolean(P_1)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TC;>;")]
	[LineNumberTable(97)]
	public override UnmodifiableIterator descendingIterator()
	{
		_2 result = new _2(this, last());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TC;>;")]
	[LineNumberTable(83)]
	public override UnmodifiableIterator iterator()
	{
		_1 result = new _1(this, first());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	internal override int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (int)((!contains(P_0)) ? (-1) : domain.distance(first(), (IComparable)java.util.Objects.requireNonNull(P_0)));
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TC;>;")]
	[LineNumberTable(new byte[] { 81, 109, 233, 77 })]
	internal override ImmutableList createAsList()
	{
		if (domain.supportsFastOffset)
		{
			_3 result = new _3(this);
			_ = null;
			return result;
		}
		ImmutableList result2 = base.createAsList();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 101, 120 })]
	public override int size()
	{
		long num = domain.distance(first(), last());
		return (num < 2147483647u) ? ((int)num + 1) : int.MaxValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(169)]
	public override bool containsAll(Collection P_0)
	{
		bool result = Collections2.containsAllImpl(this, P_0);
		_ = null;
		return result;
	}

	public override bool isEmpty()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ContiguousSet<TC;>;)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(new byte[]
	{
		160, 65, 103, 118, 104, 130, 127, 2, 127, 2,
		106, 116, 18
	})]
	public override ContiguousSet intersection(ContiguousSet P_0)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument(java.lang.Object.instancehelper_equals(domain, P_0.domain));
		if (P_0.isEmpty())
		{
			return P_0;
		}
		IComparable o = (IComparable)Ordering.natural().max(first(), (IComparable)P_0.first());
		IComparable comparable = (IComparable)Ordering.natural().min(last(), (IComparable)P_0.last());
		object result;
		if (Comparable.__Helper.compareTo(o, comparable) <= 0)
		{
			result = ContiguousSet.create(Range.closed(o, comparable), domain);
		}
		else
		{
			EmptyContiguousSet.___003Cclinit_003E();
			result = new EmptyContiguousSet(domain);
		}
		_ = null;
		return (ContiguousSet)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(194)]
	public override Range range()
	{
		Range result = range(BoundType.___003C_003ECLOSED, BoundType.___003C_003ECLOSED);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 92, 100, 98, 104, 103, 115, 191, 12 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 == this)
		{
			return true;
		}
		if (P_0 is RegularContiguousSet)
		{
			RegularContiguousSet regularContiguousSet = (RegularContiguousSet)P_0;
			if (java.lang.Object.instancehelper_equals(domain, regularContiguousSet.domain))
			{
				return (java.lang.Object.instancehelper_equals(first(), regularContiguousSet.first()) && java.lang.Object.instancehelper_equals(last(), regularContiguousSet.last())) ? true : false;
			}
		}
		bool result = base.equals(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(220)]
	public override int hashCode()
	{
		int result = Sets.hashCodeImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(241)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(this.m_range, domain, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override object last()
	{
		IComparable result = last();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override object first()
	{
		IComparable result = first();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal override ImmutableSortedSet tailSetImpl(object P_0, bool P_1)
	{
		ContiguousSet result = tailSetImpl((IComparable)P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal override ImmutableSortedSet subSetImpl(object P_0, bool P_1, object P_2, bool P_3)
	{
		ContiguousSet result = subSetImpl((IComparable)P_0, P_1, (IComparable)P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal override ImmutableSortedSet headSetImpl(object P_0, bool P_1)
	{
		ContiguousSet result = headSetImpl((IComparable)P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public new virtual Iterator descendingIterator()
	{
		UnmodifiableIterator result = this.descendingIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public new virtual Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[HideFromJava]
	static RegularContiguousSet()
	{
		ContiguousSet.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularContiguousSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
