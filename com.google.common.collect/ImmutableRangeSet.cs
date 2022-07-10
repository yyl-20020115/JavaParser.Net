using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<C::Ljava/lang/Comparable;>Lcom/google/common/collect/AbstractRangeSet<TC;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class ImmutableRangeSet : AbstractRangeSet, Serializable.__Interface, ISerializable
{
	[Serializable]
	[SpecialName]
	[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;")]
	[EnclosingMethod(null, "intersectRanges", "(Lcom.google.common.collect.Range;)Lcom.google.common.collect.ImmutableList;")]
	internal class _1 : ImmutableList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024length;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024fromIndex;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Range val_0024range;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableRangeSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/Range<TC;>;")]
		[LineNumberTable(new byte[] { 161, 107, 109, 110, 159, 12 })]
		public new virtual Range get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, val_0024length);
			if (P_0 == 0 || P_0 == val_0024length - 1)
			{
				Range result = ((Range)access_0024000(this_00240).get(P_0 + val_0024fromIndex)).intersection(val_0024range);
				_ = null;
				return result;
			}
			return (Range)access_0024000(this_00240).get(P_0 + val_0024fromIndex);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(469)]
		internal _1(ImmutableRangeSet P_0, int P_1, int P_2, Range P_3)
		{
			this_00240 = P_0;
			val_0024length = P_1;
			val_0024fromIndex = P_2;
			val_0024range = P_3;
			base._002Ector();
		}

		public override int size()
		{
			return val_0024length;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(469)]
		public override object get(int P_0)
		{
			Range result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static _1()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _1(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
	internal sealed class AsSet : ImmutableSortedSet
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/AbstractIterator<TC;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal new class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<Lcom/google/common/collect/Range<TC;>;>;")]
			internal Iterator rangeItr;

			[Signature("Ljava/util/Iterator<TC;>;")]
			internal Iterator elemItr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsSet this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TC;")]
			[LineNumberTable(new byte[] { 161, 215, 109, 109, 159, 14, 172 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual IComparable computeNext()
			{
				while (!elemItr.hasNext())
				{
					if (rangeItr.hasNext())
					{
						elemItr = ContiguousSet.create((Range)rangeItr.next(), access_0024100(this_00241)).iterator();
						continue;
					}
					return (IComparable)endOfData();
				}
				return (IComparable)elemItr.next();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 208, 111, 123 })]
			internal _1(AsSet P_0)
			{
				this_00241 = P_0;
				base._002Ector();
				rangeItr = access_0024000(this_00241.this_00240).iterator();
				elemItr = Iterators.emptyIterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(578)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				IComparable result = computeNext();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/AbstractIterator<TC;>;")]
		[EnclosingMethod(null, "descendingIterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _2 : AbstractIterator
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<Lcom/google/common/collect/Range<TC;>;>;")]
			internal Iterator rangeItr;

			[Signature("Ljava/util/Iterator<TC;>;")]
			internal Iterator elemItr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsSet this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 230, 111, 127, 1 })]
			internal _2(AsSet P_0)
			{
				this_00241 = P_0;
				base._002Ector();
				rangeItr = access_0024000(this_00241.this_00240).reverse().iterator();
				elemItr = Iterators.emptyIterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TC;")]
			[LineNumberTable(new byte[] { 161, 237, 109, 109, 159, 14, 172 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual IComparable computeNext()
			{
				while (!elemItr.hasNext())
				{
					if (rangeItr.hasNext())
					{
						elemItr = ContiguousSet.create((Range)rangeItr.next(), access_0024100(this_00241)).descendingIterator();
						continue;
					}
					return (IComparable)endOfData();
				}
				return (IComparable)elemItr.next();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(600)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				IComparable result = computeNext();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/DiscreteDomain<TC;>;")]
		private DiscreteDomain domain;

		[NonSerialized]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new Integer m_size;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableRangeSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)V")]
		[LineNumberTable(new byte[] { 161, 182, 103, 109, 103 })]
		internal AsSet(ImmutableRangeSet P_0, DiscreteDomain P_1)
		{
			this_00240 = P_0;
			base._002Ector(Ordering.natural());
			domain = P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(549)]
		internal static DiscreteDomain access_0024100(AsSet P_0)
		{
			return P_0.domain;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
		[LineNumberTable(620)]
		internal virtual ImmutableSortedSet subSet(Range P_0)
		{
			ImmutableSortedSet result = this_00240.subRangeSet(P_0).asSet(domain);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 21, 99, 194, 103, 127, 6, 97 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001a
			if (P_0 == null)
			{
				return false;
			}
			try
			{
				IComparable c = (IComparable)P_0;
				return this_00240.contains(c);
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
		[Signature("(TC;Z)Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
		[LineNumberTable(642)]
		internal virtual ImmutableSortedSet tailSetImpl(IComparable P_0, bool P_1)
		{
			ImmutableSortedSet result = subSet(Range.downTo(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;ZTC;Z)Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
		[LineNumberTable(new byte[] { 158, 241, 165, 111, 136, 131, 103, 5, 37 })]
		internal virtual ImmutableSortedSet subSetImpl(IComparable P_0, bool P_1, IComparable P_2, bool P_3)
		{
			if (!P_1 && !P_3 && Range.compareOrThrow(P_0, P_2) == 0)
			{
				ImmutableSortedSet result = ImmutableSortedSet.of();
				_ = null;
				return result;
			}
			ImmutableSortedSet result2 = subSet(Range.range(P_0, BoundType.forBoolean(P_1), P_2, BoundType.forBoolean(P_3)));
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;Z)Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
		[LineNumberTable(625)]
		internal virtual ImmutableSortedSet headSetImpl(IComparable P_0, bool P_1)
		{
			ImmutableSortedSet result = subSet(Range.upTo(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TC;>;")]
		[LineNumberTable(600)]
		public override UnmodifiableIterator descendingIterator()
		{
			_2 result = new _2(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TC;>;")]
		[LineNumberTable(578)]
		public override UnmodifiableIterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 192, 103, 102, 99, 127, 6, 117, 105, 130,
			98, 154
		})]
		public override int size()
		{
			Integer integer = this.m_size;
			if (integer == null)
			{
				long num = 0L;
				UnmodifiableIterator unmodifiableIterator = access_0024000(this_00240).iterator();
				while (((Iterator)unmodifiableIterator).hasNext())
				{
					Range range = (Range)((Iterator)unmodifiableIterator).next();
					num += ContiguousSet.create(range, domain).size();
					if (num >= 2147483647u)
					{
						break;
					}
				}
				Integer integer2 = Integer.valueOf(Ints.saturatedCast(num));
				this.m_size = integer2;
				integer = integer2;
			}
			int result = integer.intValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 35, 140, 108, 99, 127, 6, 105, 157, 149,
			98, 144
		})]
		internal override int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (contains(P_0))
			{
				IComparable comparable = (IComparable)java.util.Objects.requireNonNull(P_0);
				long num = 0L;
				UnmodifiableIterator unmodifiableIterator = access_0024000(this_00240).iterator();
				while (((Iterator)unmodifiableIterator).hasNext())
				{
					Range range = (Range)((Iterator)unmodifiableIterator).next();
					if (range.contains(comparable))
					{
						int result = Ints.saturatedCast(num + ContiguousSet.create(range, domain).indexOf(comparable));
						_ = null;
						return result;
					}
					num += ContiguousSet.create(range, domain).size();
				}
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError("impossible");
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
		[LineNumberTable(679)]
		internal override ImmutableSortedSet createDescendingSet()
		{
			DescendingImmutableSortedSet result = new DescendingImmutableSortedSet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(684)]
		internal override bool isPartialView()
		{
			bool result = access_0024000(this_00240).isPartialView();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(689)]
		public override string toString()
		{
			string result = access_0024000(this_00240).toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(694)]
		internal override object writeReplace()
		{
			AsSetSerializedForm result = new AsSetSerializedForm(access_0024000(this_00240), domain);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(549)]
		internal override ImmutableSortedSet tailSetImpl(object P_0, bool P_1)
		{
			ImmutableSortedSet result = tailSetImpl((IComparable)P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(549)]
		internal override ImmutableSortedSet subSetImpl(object P_0, bool P_1, object P_2, bool P_3)
		{
			ImmutableSortedSet result = subSetImpl((IComparable)P_0, P_1, (IComparable)P_2, P_3);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(549)]
		internal override ImmutableSortedSet headSetImpl(object P_0, bool P_1)
		{
			ImmutableSortedSet result = headSetImpl((IComparable)P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(549)]
		public new virtual Iterator descendingIterator()
		{
			UnmodifiableIterator result = this.descendingIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(549)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static AsSet()
		{
			ImmutableSortedSet.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected AsSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<C::Ljava/lang/Comparable;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class AsSetSerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;")]
		private ImmutableList ranges;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/DiscreteDomain<TC;>;")]
		private DiscreteDomain domain;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;Lcom/google/common/collect/DiscreteDomain<TC;>;)V")]
		[LineNumberTable(new byte[] { 162, 76, 104, 103, 103 })]
		internal AsSetSerializedForm(ImmutableList P_0, DiscreteDomain P_1)
		{
			ranges = P_0;
			domain = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(708)]
		internal virtual object readResolve()
		{
			___003Cclinit_003E();
			ImmutableSortedSet result = new ImmutableRangeSet(ranges).asSet(domain);
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
		protected AsSetSerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(AsSetSerializedForm))
			{
				return this;
			}
			return readResolve();
		}
	}

	[Signature("<C::Ljava/lang/Comparable<*>;>Ljava/lang/Object;")]
	public class Builder : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/List<Lcom/google/common/collect/Range<TC;>;>;")]
		private List ranges;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/ImmutableRangeSet$Builder<TC;>;")]
		[LineNumberTable(new byte[] { 162, 123, 119, 109 })]
		public virtual Builder add(Range range)
		{
			Preconditions.checkArgument((!range.isEmpty()) ? true : false, "range must not be empty, but was %s", range);
			ranges.add(range);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableRangeSet$Builder<TC;>;)Lcom/google/common/collect/ImmutableRangeSet$Builder<TC;>;")]
		[LineNumberTable(new byte[] { 162, 155, 109 })]
		internal virtual Builder combine(Builder P_0)
		{
			addAll(P_0.ranges);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
		[LineNumberTable(new byte[]
		{
			162, 165, 102, 107, 112, 113, 107, 108, 104, 108,
			105, 98, 49, 229, 69, 210, 98, 104, 101, 104,
			105, 104, 108, 118, 136
		})]
		public virtual ImmutableRangeSet build()
		{
			ImmutableList.Builder builder = new ImmutableList.Builder(ranges.size());
			Collections.sort(ranges, Range.rangeLexOrdering());
			PeekingIterator peekingIterator = Iterators.peekingIterator(ranges.iterator());
			while (peekingIterator.hasNext())
			{
				Range range = (Range)peekingIterator.next();
				while (peekingIterator.hasNext())
				{
					Range range2 = (Range)peekingIterator.peek();
					if (!range.isConnected(range2))
					{
						break;
					}
					Preconditions.checkArgument(range.intersection(range2).isEmpty(), "Overlapping ranges not permitted but found %s overlapping %s", range, range2);
					range = range.span((Range)peekingIterator.next());
				}
				builder.add(range);
			}
			ImmutableList immutableList = builder.build();
			if (immutableList.isEmpty())
			{
				ImmutableRangeSet result = of();
				_ = null;
				return result;
			}
			if (immutableList.size() == 1 && ((Range)Iterables.getOnlyElement(immutableList)).equals(Range.all()))
			{
				ImmutableRangeSet result2 = all();
				_ = null;
				return result2;
			}
			ImmutableRangeSet result3 = new ImmutableRangeSet(immutableList);
			_ = null;
			return result3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 109, 104, 107 })]
		public Builder()
		{
			ranges = Lists.newArrayList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)Lcom/google/common/collect/ImmutableRangeSet$Builder<TC;>;")]
		[LineNumberTable(new byte[] { 162, 147, 123, 104, 98 })]
		public virtual Builder addAll(Iterable ranges)
		{
			Iterator iterator = ranges.iterator();
			while (iterator.hasNext())
			{
				Range range = (Range)iterator.next();
				add(range);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)Lcom/google/common/collect/ImmutableRangeSet$Builder<TC;>;")]
		[LineNumberTable(761)]
		public virtual Builder addAll(RangeSet ranges)
		{
			Builder result = addAll(ranges.asRanges());
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;")]
	internal sealed class ComplementRanges : ImmutableList
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private bool positiveBoundedBelow;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private bool positiveBoundedAbove;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private new int m_size;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableRangeSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 212, 111, 124, 155, 110, 104, 132, 104, 132,
			103
		})]
		internal ComplementRanges(ImmutableRangeSet P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			positiveBoundedBelow = ((Range)access_0024000(P_0).get(0)).hasLowerBound();
			positiveBoundedAbove = ((Range)Iterables.getLast(access_0024000(P_0))).hasUpperBound();
			int num = access_0024000(P_0).size() - 1;
			if (positiveBoundedBelow)
			{
				num++;
			}
			if (positiveBoundedAbove)
			{
				num++;
			}
			this.m_size = num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/Range<TC;>;")]
		[LineNumberTable(new byte[]
		{
			160, 233, 173, 104, 159, 11, 220, 115, 136, 191,
			10
		})]
		public new virtual Range get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, this.m_size);
			Cut cut = ((!positiveBoundedBelow) ? ((Range)access_0024000(this_00240).get(P_0)).upperBound : ((P_0 != 0) ? ((Range)access_0024000(this_00240).get(P_0 - 1)).upperBound : Cut.belowAll()));
			Cut cut2 = ((!positiveBoundedAbove || P_0 != this.m_size - 1) ? ((Range)access_0024000(this_00240).get(P_0 + ((!positiveBoundedBelow) ? 1 : 0))).lowerBound : Cut.aboveAll());
			Range result = Range.create(cut, cut2);
			_ = null;
			return result;
		}

		public override int size()
		{
			return this.m_size;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(317)]
		public override object get(int P_0)
		{
			Range result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static ComplementRanges()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ComplementRanges(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<C::Ljava/lang/Comparable;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;")]
		private ImmutableList ranges;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;)V")]
		[LineNumberTable(new byte[] { 162, 201, 104, 103 })]
		internal SerializedForm(ImmutableList P_0)
		{
			ranges = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 206, 109, 104, 119, 136 })]
		internal virtual object readResolve()
		{
			if (ranges.isEmpty())
			{
				ImmutableRangeSet result = of();
				_ = null;
				return result;
			}
			if (ranges.equals(ImmutableList.of(Range.all())))
			{
				ImmutableRangeSet result2 = all();
				_ = null;
				return result2;
			}
			___003Cclinit_003E();
			ImmutableRangeSet result3 = new ImmutableRangeSet(ranges);
			_ = null;
			return result3;
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableRangeSet<Ljava/lang/Comparable<*>;>;")]
	private static ImmutableRangeSet EMPTY;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableRangeSet<Ljava/lang/Comparable<*>;>;")]
	private static ImmutableRangeSet ALL;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;")]
	private ImmutableList ranges;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new ImmutableRangeSet m_complement;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/ImmutableRangeSet$Builder<TC;>;")]
	[LineNumberTable(724)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static ImmutableList access_0024000(ImmutableRangeSet P_0)
	{
		return P_0.ranges;
	}

	[Signature("<C::Ljava/lang/Comparable;>()Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	public static ImmutableRangeSet of()
	{
		return EMPTY;
	}

	[Signature("<C::Ljava/lang/Comparable;>()Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	internal static ImmutableRangeSet all()
	{
		return ALL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;)V")]
	[LineNumberTable(new byte[] { 96, 104, 103 })]
	internal ImmutableRangeSet(ImmutableList P_0)
	{
		ranges = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(719)]
	internal virtual bool isPartialView()
	{
		bool result = ranges.isPartialView();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable;>(Lcom/google/common/collect/RangeSet<TC;>;)Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(new byte[] { 56, 103, 104, 104, 109, 168, 104, 103, 104, 162 })]
	public static ImmutableRangeSet copyOf(RangeSet rangeSet)
	{
		Preconditions.checkNotNull(rangeSet);
		if (rangeSet.isEmpty())
		{
			ImmutableRangeSet result = of();
			_ = null;
			return result;
		}
		if (rangeSet.encloses(Range.all()))
		{
			ImmutableRangeSet result2 = all();
			_ = null;
			return result2;
		}
		if (rangeSet is ImmutableRangeSet)
		{
			ImmutableRangeSet immutableRangeSet = (ImmutableRangeSet)rangeSet;
			if (!immutableRangeSet.isPartialView())
			{
				return immutableRangeSet;
			}
		}
		ImmutableRangeSet result3 = new ImmutableRangeSet(ImmutableList.copyOf(rangeSet.asRanges()));
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;Lcom/google/common/collect/ImmutableRangeSet<TC;>;)V")]
	[LineNumberTable(new byte[] { 100, 104, 103, 103 })]
	private ImmutableRangeSet(ImmutableList P_0, ImmutableRangeSet P_1)
	{
		ranges = P_0;
		this.m_complement = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Range<TC;>;>;")]
	[LineNumberTable(new byte[] { 160, 187, 109, 136 })]
	public new virtual ImmutableSet asRanges()
	{
		if (ranges.isEmpty())
		{
			ImmutableSet result = ImmutableSet.of();
			_ = null;
			return result;
		}
		RegularImmutableSortedSet.___003Cclinit_003E();
		RegularImmutableSortedSet result2 = new RegularImmutableSortedSet(ranges, Range.rangeLexOrdering());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(143)]
	public static ImmutableRangeSet unionOf(Iterable ranges)
	{
		ImmutableRangeSet result = copyOf(TreeRangeSet.create(ranges));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 160, 96, 109, 139 })]
	public override Range span()
	{
		if (ranges.isEmpty())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		Range result = Range.create(((Range)ranges.get(0)).lowerBound, ((Range)ranges.get(ranges.size() - 1)).upperBound);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(218)]
	public override bool isEmpty()
	{
		bool result = ranges.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Range<TC;>;>;")]
	[LineNumberTable(new byte[]
	{
		161, 64, 117, 104, 110, 199, 104, 166, 21, 232,
		71, 194, 104, 166, 21, 232, 71, 140, 100, 99,
		136
	})]
	private ImmutableList intersectRanges(Range P_0)
	{
		if (ranges.isEmpty() || P_0.isEmpty())
		{
			ImmutableList result = ImmutableList.of();
			_ = null;
			return result;
		}
		if (P_0.encloses(span()))
		{
			return ranges;
		}
		int num = (P_0.hasLowerBound() ? SortedLists.binarySearch(ranges, Range.upperBoundFn(), P_0.lowerBound, SortedLists.KeyPresentBehavior.FIRST_AFTER, SortedLists.KeyAbsentBehavior.NEXT_HIGHER) : 0);
		int num2 = ((!P_0.hasUpperBound()) ? ranges.size() : SortedLists.binarySearch(ranges, Range.lowerBoundFn(), P_0.upperBound, SortedLists.KeyPresentBehavior.FIRST_PRESENT, SortedLists.KeyAbsentBehavior.NEXT_HIGHER));
		int num3 = num2 - num;
		if (num3 == 0)
		{
			ImmutableList result2 = ImmutableList.of();
			_ = null;
			return result2;
		}
		_1 result3 = new _1(this, num3, num, P_0);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(new byte[] { 161, 126, 104, 103, 105, 98, 105, 175 })]
	public new virtual ImmutableRangeSet subRangeSet(Range range)
	{
		if (!isEmpty())
		{
			Range other = span();
			if (range.encloses(other))
			{
				return this;
			}
			if (range.isConnected(other))
			{
				ImmutableRangeSet result = new ImmutableRangeSet(intersectRanges(range));
				_ = null;
				return result;
			}
		}
		ImmutableRangeSet result2 = of();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(new byte[]
	{
		161, 4, 103, 99, 98, 109, 113, 127, 12, 145,
		103, 147
	})]
	public new virtual ImmutableRangeSet complement()
	{
		ImmutableRangeSet immutableRangeSet = this.m_complement;
		if (immutableRangeSet != null)
		{
			return immutableRangeSet;
		}
		ImmutableRangeSet immutableRangeSet2;
		if (ranges.isEmpty())
		{
			immutableRangeSet2 = all();
			ImmutableRangeSet result = immutableRangeSet2;
			this.m_complement = immutableRangeSet2;
			return result;
		}
		if (ranges.size() == 1 && ((Range)ranges.get(0)).equals(Range.all()))
		{
			immutableRangeSet2 = of();
			ImmutableRangeSet result2 = immutableRangeSet2;
			this.m_complement = immutableRangeSet2;
			return result2;
		}
		ComplementRanges complementRanges = new ComplementRanges(this);
		immutableRangeSet2 = new ImmutableRangeSet(complementRanges, this);
		ImmutableRangeSet result3 = immutableRangeSet2;
		this.m_complement = immutableRangeSet2;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Range<TC;>;>;")]
	[LineNumberTable(new byte[] { 160, 195, 109, 136 })]
	public new virtual ImmutableSet asDescendingSetOfRanges()
	{
		if (ranges.isEmpty())
		{
			ImmutableSet result = ImmutableSet.of();
			_ = null;
			return result;
		}
		RegularImmutableSortedSet.___003Cclinit_003E();
		RegularImmutableSortedSet result2 = new RegularImmutableSortedSet(ranges.reverse(), Range.rangeLexOrdering().reverse());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>()Ljava/util/stream/Collector<Lcom/google/common/collect/Range<TE;>;*Lcom/google/common/collect/ImmutableRangeSet<TE;>;>;")]
	[LineNumberTable(70)]
	public static Collector toImmutableRangeSet()
	{
		Collector result = CollectCollectors.toImmutableRangeSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable;>(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(new byte[] { 38, 103, 104, 104, 109, 136 })]
	public static ImmutableRangeSet of(Range range)
	{
		Preconditions.checkNotNull(range);
		if (range.isEmpty())
		{
			ImmutableRangeSet result = of();
			_ = null;
			return result;
		}
		if (range.equals(Range.all()))
		{
			ImmutableRangeSet result2 = all();
			_ = null;
			return result2;
		}
		ImmutableRangeSet result3 = new ImmutableRangeSet(ImmutableList.of(range));
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(131)]
	public static ImmutableRangeSet copyOf(Iterable ranges)
	{
		ImmutableRangeSet result = new Builder().addAll(ranges).build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	[LineNumberTable(new byte[]
	{
		109, 166, 139, 239, 60, 230, 71, 117, 121, 119,
		130, 109, 123, 27
	})]
	public override bool intersects(Range otherRange)
	{
		int num = SortedLists.binarySearch(ranges, Range.lowerBoundFn(), otherRange.lowerBound, Ordering.natural(), SortedLists.KeyPresentBehavior.ANY_PRESENT, SortedLists.KeyAbsentBehavior.NEXT_HIGHER);
		if (num < ranges.size() && ((Range)ranges.get(num)).isConnected(otherRange) && !((Range)ranges.get(num)).intersection(otherRange).isEmpty())
		{
			return true;
		}
		return (num > 0 && ((Range)ranges.get(num - 1)).isConnected(otherRange) && !((Range)ranges.get(num - 1)).intersection(otherRange).isEmpty()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	[LineNumberTable(new byte[] { 160, 65, 166, 139, 239, 60, 230, 71 })]
	public override bool encloses(Range otherRange)
	{
		int num = SortedLists.binarySearch(ranges, Range.lowerBoundFn(), otherRange.lowerBound, Ordering.natural(), SortedLists.KeyPresentBehavior.ANY_PRESENT, SortedLists.KeyAbsentBehavior.NEXT_LOWER);
		return (num != -1 && ((Range)ranges.get(num)).encloses(otherRange)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[]
	{
		160, 79, 166, 102, 101, 239, 60, 230, 71, 100,
		114, 142
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Range rangeContaining(IComparable value)
	{
		int num = SortedLists.binarySearch(ranges, Range.lowerBoundFn(), Cut.belowValue(value), Ordering.natural(), SortedLists.KeyPresentBehavior.ANY_PRESENT, SortedLists.KeyAbsentBehavior.NEXT_LOWER);
		if (num != -1)
		{
			Range range = (Range)ranges.get(num);
			return (!range.contains(value)) ? null : range;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	[LineNumberTable(231)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void add(Range range)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)V")]
	[LineNumberTable(244)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void addAll(RangeSet other)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)V")]
	[LineNumberTable(257)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void addAll(Iterable other)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	[LineNumberTable(270)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void remove(Range range)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)V")]
	[LineNumberTable(283)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void removeAll(RangeSet other)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)V")]
	[LineNumberTable(296)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void removeAll(Iterable other)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(397)]
	public virtual ImmutableRangeSet union(RangeSet other)
	{
		ImmutableRangeSet result = unionOf(Iterables.concat(asRanges(), other.asRanges()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(new byte[] { 161, 40, 103, 108 })]
	public virtual ImmutableRangeSet intersection(RangeSet other)
	{
		TreeRangeSet treeRangeSet = TreeRangeSet.create(this);
		((RangeSet)treeRangeSet).removeAll(other.complement());
		ImmutableRangeSet result = copyOf(treeRangeSet);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)Lcom/google/common/collect/ImmutableRangeSet<TC;>;")]
	[LineNumberTable(new byte[] { 161, 54, 103, 103 })]
	public virtual ImmutableRangeSet difference(RangeSet other)
	{
		TreeRangeSet treeRangeSet = TreeRangeSet.create(this);
		((RangeSet)treeRangeSet).removeAll(other);
		ImmutableRangeSet result = copyOf(treeRangeSet);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
	[LineNumberTable(new byte[]
	{
		161, 157, 103, 104, 134, 109, 168, 144, 136, 210,
		226, 61, 97, 240, 69
	})]
	public virtual ImmutableSortedSet asSet(DiscreteDomain domain)
	{
		Preconditions.checkNotNull(domain);
		if (isEmpty())
		{
			return ImmutableSortedSet.of();
		}
		Range range = span().canonical(domain);
		if (!range.hasLowerBound())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException("Neither the DiscreteDomain nor this range set are bounded below");
		}
		if (!range.hasUpperBound())
		{
			try
			{
				domain.maxValue();
			}
			catch (NoSuchElementException)
			{
				goto IL_0051;
			}
		}
		return new AsSet(this, domain);
		IL_0051:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException("Neither the DiscreteDomain nor this range set are bounded above");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(843)]
	internal virtual object writeReplace()
	{
		SerializedForm result = new SerializedForm(ranges);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(49)]
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
	[LineNumberTable(49)]
	public override bool enclosesAll(RangeSet rs)
	{
		bool result = base.enclosesAll(rs);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(49)]
	public override void clear()
	{
		base.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(49)]
	public override bool contains(IComparable c)
	{
		bool result = base.contains(c);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(49)]
	public virtual RangeSet _003Cbridge_003EsubRangeSet(Range r)
	{
		ImmutableRangeSet result = subRangeSet(r);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(49)]
	public virtual RangeSet _003Cbridge_003Ecomplement()
	{
		ImmutableRangeSet result = complement();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(49)]
	public virtual Set _003Cbridge_003EasDescendingSetOfRanges()
	{
		ImmutableSet result = asDescendingSetOfRanges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(49)]
	public virtual Set _003Cbridge_003EasRanges()
	{
		ImmutableSet result = asRanges();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 6, 175, 52 })]
	static ImmutableRangeSet()
	{
		EMPTY = new ImmutableRangeSet(ImmutableList.of());
		ALL = new ImmutableRangeSet(ImmutableList.of(Range.all()));
	}

	[HideFromJava]
	public static implicit operator Serializable(ImmutableRangeSet P_0)
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
	protected ImmutableRangeSet(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|hashCode", "()I")]
	public new int hashCode()
	{
		return ((AbstractRangeSet)this).hashCode();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|toString", "()Ljava.lang.String;")]
	public new string toString()
	{
		return ((AbstractRangeSet)this).toString();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|enclosesAll", "(Ljava.lang.Iterable;)Z")]
	public new bool enclosesAll(Iterable P_0)
	{
		return ((AbstractRangeSet)this).enclosesAll(P_0);
	}
}
