using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
[ConstantPool(new object[]
{
	(byte)140,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class RegularImmutableSortedSet : ImmutableSortedSet
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/RegularImmutableSortedSet<Ljava/lang/Comparable;>;")]
	internal static RegularImmutableSortedSet NATURAL_EMPTY_SET;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
	private ImmutableList elements;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableList<TE;>;Ljava/util/Comparator<-TE;>;)V")]
	[LineNumberTable(new byte[] { 1, 105, 103 })]
	internal RegularImmutableSortedSet(ImmutableList P_0, Comparator P_1)
		: base(P_1)
	{
		elements = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 194, 99, 194, 191, 9, 2, 97, 130 })]
	internal override int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 == null)
		{
			return -1;
		}
		int num;
		try
		{
			num = Collections.binarySearch(elements, P_0, unsafeComparator());
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_002a;
		}
		return (num < 0) ? (-1) : num;
		IL_002a:
		_ = null;
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(164)]
	internal override bool isPartialView()
	{
		bool result = elements.isPartialView();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/RegularImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 182, 108, 98, 100, 104, 50, 161 })]
	internal virtual RegularImmutableSortedSet getSubSet(int P_0, int P_1)
	{
		if (P_0 == 0 && P_1 == size())
		{
			return this;
		}
		if (P_0 < P_1)
		{
			RegularImmutableSortedSet result = new RegularImmutableSortedSet(elements.subList(P_0, P_1), base.comparator);
			_ = null;
			return result;
		}
		RegularImmutableSortedSet result2 = ImmutableSortedSet.emptySet(base.comparator);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)I")]
	[LineNumberTable(new byte[] { 159, 78, 162, 120, 100, 138 })]
	internal virtual int headIndex(object P_0, bool P_1)
	{
		int num = Collections.binarySearch(elements, Preconditions.checkNotNull(P_0), base.comparator());
		if (num >= 0)
		{
			return (!P_1) ? num : (num + 1);
		}
		return num ^ -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)I")]
	[LineNumberTable(new byte[] { 159, 73, 162, 120, 100, 138 })]
	internal virtual int tailIndex(object P_0, bool P_1)
	{
		int num = Collections.binarySearch(elements, Preconditions.checkNotNull(P_0), base.comparator());
		if (num >= 0)
		{
			return (!P_1) ? (num + 1) : num;
		}
		return num ^ -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassCastException" })]
	[LineNumberTable(159)]
	private int unsafeBinarySearch(object P_0)
	{
		int result = Collections.binarySearch(elements, P_0, unsafeComparator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(73)]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableIterator result = elements.iterator();
		_ = null;
		return result;
	}

	[Signature("()Ljava/util/Comparator<Ljava/lang/Object;>;")]
	internal virtual Comparator unsafeComparator()
	{
		return base.comparator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(94)]
	public override int size()
	{
		int result = elements.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[]
	{
		159, 114, 66, 109, 145, 127, 30, 251, 71, 135,
		186, 104, 162, 103, 168, 139, 101, 104, 159, 27,
		127, 22, 100, 104, 159, 21, 159, 12, 101, 130,
		101, 97
	})]
	public override bool containsAll(Collection P_0)
	{
		//Discarded unreachable code: IL_00d1, IL_014c
		object obj = P_0;
		if (((Collection)obj) is Multiset)
		{
			obj = ((Multiset)(Collection)obj).elementSet();
		}
		Comparator obj2 = base.comparator();
		object obj3 = obj;
		if (SortedIterables.hasSameComparator(obj2, (obj3 == null) ? null : ((obj3 as Iterable) ?? throw new java.lang.IncompatibleClassChangeError())))
		{
			object obj4 = obj;
			if (((obj4 == null) ? null : ((obj4 as Collection) ?? throw new java.lang.IncompatibleClassChangeError())).size() > 1)
			{
				UnmodifiableIterator unmodifiableIterator = this.iterator();
				object obj5 = obj;
				Iterator iterator = ((obj5 == null) ? null : ((obj5 as Collection) ?? throw new java.lang.IncompatibleClassChangeError())).iterator();
				if (!((Iterator)unmodifiableIterator).hasNext())
				{
					return false;
				}
				object obj6 = iterator.next();
				object obj7 = ((Iterator)unmodifiableIterator).next();
				while (true)
				{
					int num;
					try
					{
						try
						{
							num = base.unsafeCompare(obj7, obj6);
							if (num < 0)
							{
								if (!((Iterator)unmodifiableIterator).hasNext())
								{
									return false;
								}
								goto IL_0104;
							}
						}
						catch (System.Exception x)
						{
							if (ByteCodeHelper.MapException<NullPointerException>(x, ByteCodeHelper.MapFlags.Unused) == null)
							{
								throw;
							}
							goto IL_00f7;
						}
					}
					catch (System.Exception x2)
					{
						if (ByteCodeHelper.MapException<ClassCastException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
						{
							throw;
						}
						goto IL_00fd;
					}
					try
					{
						try
						{
							if (num == 0)
							{
								if (!iterator.hasNext())
								{
									return true;
								}
								goto IL_0179;
							}
						}
						catch (System.Exception x3)
						{
							if (ByteCodeHelper.MapException<NullPointerException>(x3, ByteCodeHelper.MapFlags.Unused) == null)
							{
								throw;
							}
							goto IL_0172;
						}
					}
					catch (System.Exception x4)
					{
						if (ByteCodeHelper.MapException<ClassCastException>(x4, ByteCodeHelper.MapFlags.Unused) == null)
						{
							throw;
						}
						goto IL_0175;
					}
					if (num > 0)
					{
						return false;
					}
					continue;
					IL_0104:
					try
					{
						try
						{
							obj7 = ((Iterator)unmodifiableIterator).next();
						}
						catch (System.Exception x5)
						{
							if (ByteCodeHelper.MapException<NullPointerException>(x5, ByteCodeHelper.MapFlags.Unused) == null)
							{
								throw;
							}
							goto IL_012d;
						}
					}
					catch (System.Exception x6)
					{
						if (ByteCodeHelper.MapException<ClassCastException>(x6, ByteCodeHelper.MapFlags.Unused) == null)
						{
							throw;
						}
						goto IL_0133;
					}
					continue;
					IL_0133:
					object obj8 = null;
					break;
					IL_012d:
					obj8 = null;
					break;
					IL_0175:
					obj8 = null;
					break;
					IL_0172:
					obj8 = null;
					break;
					IL_0179:
					try
					{
						try
						{
							obj6 = iterator.next();
						}
						catch (System.Exception x7)
						{
							if (ByteCodeHelper.MapException<NullPointerException>(x7, ByteCodeHelper.MapFlags.Unused) == null)
							{
								throw;
							}
							goto IL_019e;
						}
					}
					catch (System.Exception x8)
					{
						if (ByteCodeHelper.MapException<ClassCastException>(x8, ByteCodeHelper.MapFlags.Unused) == null)
						{
							throw;
						}
						goto IL_01a1;
					}
					continue;
					IL_01a1:
					obj8 = null;
					break;
					IL_019e:
					obj8 = null;
					break;
					IL_00fd:
					obj8 = null;
					break;
					IL_00f7:
					obj8 = null;
					break;
				}
				return false;
			}
		}
		object obj9 = obj;
		return base.containsAll((obj9 == null) ? null : ((obj9 as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(275)]
	internal override ImmutableSortedSet tailSetImpl(object P_0, bool P_1)
	{
		RegularImmutableSortedSet result = getSubSet(tailIndex(P_0, P_1), size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(79)]
	public override UnmodifiableIterator descendingIterator()
	{
		UnmodifiableIterator result = elements.reverse().iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal override object[] internalArray()
	{
		object[] result = elements.internalArray();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(63)]
	internal override int internalArrayStart()
	{
		int result = elements.internalArrayStart();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	internal override int internalArrayEnd()
	{
		int result = elements.internalArrayEnd();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(84)]
	public override Spliterator spliterator()
	{
		Spliterator result = asList().spliterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 39, 110 })]
	public override void forEach(Consumer P_0)
	{
		elements.forEach(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 50, 127, 11, 97 })]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		//Discarded unreachable code: IL_0013
		try
		{
			return (P_0 != null && unsafeBinarySearch(P_0) >= 0) ? true : false;
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
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 140, 0,
		0
	})]
	[LineNumberTable(169)]
	internal override int copyIntoArray(object[] P_0, int P_1)
	{
		int result = elements.copyIntoArray(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		124, 100, 130, 104, 162, 103, 110, 98, 104, 162,
		113, 135, 103, 104, 103, 104, 111, 133, 98, 127,
		6, 97, 98, 97, 162
	})]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		//Discarded unreachable code: IL_0080
		if (P_0 == this)
		{
			return true;
		}
		if (!(P_0 is Set))
		{
			return false;
		}
		Set set = (Set)P_0;
		if (size() != set.size())
		{
			return false;
		}
		if (base.isEmpty())
		{
			return true;
		}
		if (SortedIterables.hasSameComparator(base.comparator, set))
		{
			Iterator iterator = set.iterator();
			try
			{
				try
				{
					UnmodifiableIterator unmodifiableIterator = this.iterator();
					while (((Iterator)unmodifiableIterator).hasNext())
					{
						object obj = ((Iterator)unmodifiableIterator).next();
						object obj2 = iterator.next();
						if (obj2 == null || base.unsafeCompare(obj, obj2) != 0)
						{
							return false;
						}
					}
					return true;
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
				}
			}
			catch (NoSuchElementException)
			{
				goto IL_009e;
			}
			_ = null;
			return false;
		}
		return containsAll(set);
		IL_009e:
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(new byte[] { 160, 97, 104, 139 })]
	public override object first()
	{
		if (base.isEmpty())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object result = elements.get(0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(new byte[] { 160, 105, 104, 139 })]
	public override object last()
	{
		if (base.isEmpty())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object result = elements.get(size() - 1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(new byte[] { 160, 114, 107 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object lower(object P_0)
	{
		int num = headIndex(P_0, false) - 1;
		object result = ((num != -1) ? elements.get(num) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(new byte[] { 160, 121, 107 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object floor(object P_0)
	{
		int num = headIndex(P_0, true) - 1;
		object result = ((num != -1) ? elements.get(num) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(new byte[] { 160, 128, 105 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object ceiling(object P_0)
	{
		int num = tailIndex(P_0, true);
		object result = ((num != size()) ? elements.get(num) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TE;")]
	[LineNumberTable(new byte[] { 160, 135, 105 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object higher(object P_0)
	{
		int num = tailIndex(P_0, false);
		object result = ((num != size()) ? elements.get(num) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(255)]
	internal override ImmutableSortedSet headSetImpl(object P_0, bool P_1)
	{
		RegularImmutableSortedSet result = getSubSet(0, headIndex(P_0, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;ZTE;Z)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(270)]
	internal override ImmutableSortedSet subSetImpl(object P_0, bool P_1, object P_2, bool P_3)
	{
		ImmutableSortedSet result = tailSetImpl(P_0, P_1).headSetImpl(P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(322)]
	internal override ImmutableList createAsList()
	{
		object result;
		if (size() <= 1)
		{
			result = elements;
		}
		else
		{
			ImmutableSortedAsList.___003Cclinit_003E();
			result = new ImmutableSortedAsList(this, elements);
		}
		_ = null;
		return (ImmutableList)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 213, 108, 104, 104, 19 })]
	internal override ImmutableSortedSet createDescendingSet()
	{
		Comparator comparator = Collections.reverseOrder(base.comparator);
		RegularImmutableSortedSet result = ((!base.isEmpty()) ? new RegularImmutableSortedSet(elements.reverse(), comparator) : ImmutableSortedSet.emptySet(comparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public new virtual Iterator descendingIterator()
	{
		UnmodifiableIterator result = this.descendingIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public new virtual Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 131, 133, 52 })]
	static RegularImmutableSortedSet()
	{
		ImmutableSortedSet.___003Cclinit_003E();
		NATURAL_EMPTY_SET = new RegularImmutableSortedSet(ImmutableList.of(), Ordering.natural());
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableSortedSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
