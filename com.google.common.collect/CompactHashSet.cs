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
[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 132, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)132,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal class CompactHashSet : AbstractSet, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<TE;>;")]
	[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
	internal class _1 : java.lang.Object, Iterator
	{
		internal int expectedMetadata;

		internal int currentIndex;

		internal int indexToRemove;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CompactHashSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 216, 115, 139 })]
		private void checkForConcurrentModification()
		{
			if (access_0024000(this_00240) != expectedMetadata)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
		}

		public virtual bool hasNext()
		{
			return currentIndex >= 0;
		}

		[LineNumberTable(new byte[] { 161, 212, 111 })]
		internal virtual void incrementExpectedModCount()
		{
			expectedMetadata += 32;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 178, 111, 113, 113 })]
		internal _1(CompactHashSet P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			expectedMetadata = access_0024000(this_00240);
			currentIndex = this_00240.firstEntryIndex();
			indexToRemove = -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 161, 191, 102, 104, 139, 108, 114, 119 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			checkForConcurrentModification();
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			indexToRemove = currentIndex;
			object result = access_0024100(this_00240, currentIndex);
			currentIndex = this_00240.getSuccessor(currentIndex);
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 203, 102, 113, 102, 125, 125, 103 })]
		public virtual void remove()
		{
			checkForConcurrentModification();
			CollectPreconditions.checkRemove(indexToRemove >= 0);
			incrementExpectedModCount();
			this_00240.remove(access_0024100(this_00240, indexToRemove));
			currentIndex = this_00240.adjustAfterRemove(currentIndex, indexToRemove);
			indexToRemove = -1;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	internal const double HASH_FLOODING_FPP = 0.001;

	private const int MAX_HASH_BUCKET_LENGTH = 9;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object table;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private int[] entries;

	[NonSerialized]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 132, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal object[] elements;

	[NonSerialized]
	private int metadata;

	[NonSerialized]
	private new int m_size;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(80)]
	internal static int access_0024000(CompactHashSet P_0)
	{
		return P_0.metadata;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(526)]
	internal virtual int firstEntryIndex()
	{
		return isEmpty() ? (-1) : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(80)]
	internal static object access_0024100(CompactHashSet P_0, int P_1)
	{
		object result = P_0.element(P_1);
		_ = null;
		return result;
	}

	internal virtual int getSuccessor(int P_0)
	{
		return (P_0 + 1 >= this.m_size) ? (-1) : (P_0 + 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 84, 104, 130, 103, 99, 138, 103, 228, 69,
		102, 102, 230, 58, 230, 72, 100, 162, 104, 110,
		134
	})]
	public override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (needsAllocArrays())
		{
			return false;
		}
		Set set = delegateOrNull();
		if (set != null)
		{
			bool result = set.remove(P_0);
			_ = null;
			return result;
		}
		int num = hashTableMask();
		int num2 = CompactHashing.remove(P_0, null, num, requireTable(), requireEntries(), requireElements(), null);
		if (num2 == -1)
		{
			return false;
		}
		moveLastEntry(num2, num);
		this.m_size--;
		incrementModCount();
		return true;
	}

	internal virtual int adjustAfterRemove(int P_0, int P_1)
	{
		return P_0 - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(742)]
	private object element(int P_0)
	{
		return requireElements()[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 90, 104, 105 })]
	internal CompactHashSet()
	{
		init(3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Lcom/google/common/collect/CompactHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 132, 0, 0 })]
	[LineNumberTable(127)]
	public static CompactHashSet createWithExpectedSize(int P_0)
	{
		CompactHashSet result = new CompactHashSet(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 99, 104, 105 })]
	internal CompactHashSet(int P_0)
	{
		init(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 105, 177, 114 })]
	internal virtual void init(int P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, (object)"Expected size must be >= 0");
		metadata = Ints.constrainToRange(P_0, 1, 1073741823);
	}

	internal virtual bool needsAllocArrays()
	{
		return table == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 168, 106, 106, 106 })]
	private void setHashTableMask(int P_0)
	{
		int num = 32 - Integer.numberOfLeadingZeros(P_0);
		metadata = CompactHashing.maskCombine(metadata, num, 31);
	}

	private int hashTableMask()
	{
		return (1 << (metadata & 0x1F)) - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Ljava/util/Set<TE;>;")]
	[LineNumberTable(258)]
	private Set createHashFloodingResistantDelegate(int P_0)
	{
		LinkedHashSet result = new LinkedHashSet(P_0, 1f);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 179, 111 })]
	internal virtual void incrementModCount()
	{
		metadata += 32;
	}

	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 160, 137, 109, 140 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual Set delegateOrNull()
	{
		if (table is Set)
		{
			return (Set)table;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 120, 144, 103, 103, 108, 137, 108, 140 })]
	internal virtual int allocArrays()
	{
		Preconditions.checkState(needsAllocArrays(), (object)"Arrays already allocated");
		int num = metadata;
		int num2 = CompactHashing.tableSize(num);
		table = CompactHashing.createTable(num2);
		setHashTableMask(num2 - 1);
		entries = new int[num];
		elements = new object[num];
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(733)]
	private int[] requireEntries()
	{
		return (int[])java.util.Objects.requireNonNull(entries);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 132, 0, 0 })]
	[LineNumberTable(737)]
	private object[] requireElements()
	{
		return (object[])java.util.Objects.requireNonNull(elements);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(729)]
	private object requireTable()
	{
		object result = java.util.Objects.requireNonNull(table);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 18, 103, 132, 132, 173, 103, 167, 107, 106,
		103, 102, 166, 141, 102, 106, 106, 142, 106, 229,
		49, 235, 82, 103, 103
	})]
	private int resizeTable(int P_0, int P_1, int P_2, int P_3)
	{
		object obj = CompactHashing.createTable(P_1);
		int num = P_1 - 1;
		if (P_3 != 0)
		{
			CompactHashing.tableSet(obj, P_2 & num, P_3 + 1);
		}
		object obj2 = requireTable();
		int[] array = requireEntries();
		for (int i = 0; i <= P_0; i++)
		{
			int num2 = CompactHashing.tableGet(obj2, i);
			while (num2 != 0)
			{
				int num3 = num2 - 1;
				int num4 = array[num3];
				int num5 = CompactHashing.getHashPrefix(num4, P_0) | i;
				int num6 = num5 & num;
				int num7 = CompactHashing.tableGet(obj, num6);
				CompactHashing.tableSet(obj, num6, num2);
				array[num3] = CompactHashing.maskCombine(num5, num7, num);
				num2 = CompactHashing.getNext(num4, P_0);
			}
		}
		table = obj;
		setHashTableMask(num);
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 160, 150, 111, 107, 46, 170, 103, 103, 103, 102 })]
	internal virtual Set convertToHashFloodingResistantImplementation()
	{
		Set set = createHashFloodingResistantDelegate(hashTableMask() + 1);
		for (int num = firstEntryIndex(); num >= 0; num = getSuccessor(num))
		{
			set.add(element(num));
		}
		table = set;
		entries = null;
		elements = null;
		incrementModCount();
		return set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 252, 104, 132, 106, 110, 100, 169 })]
	private void resizeMeMaybe(int P_0)
	{
		int num = requireEntries().Length;
		if (P_0 > num)
		{
			int num2 = java.lang.Math.min(1073741823, (num + java.lang.Math.max(1, (int)((uint)num >> 1))) | 1);
			if (num2 != num)
			{
				resizeEntries(num2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITE;II)V")]
	[LineNumberTable(new byte[] { 160, 246, 112, 106 })]
	internal virtual void insertEntry(int P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, int P_2, int P_3)
	{
		setEntry(P_0, CompactHashing.maskCombine(P_2, 0, P_3));
		setElement(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 128, 105 })]
	private void setEntry(int P_0, int P_1)
	{
		requireEntries()[P_0] = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITE;)V")]
	[LineNumberTable(new byte[] { 162, 124, 105 })]
	private void setElement(int P_0, object P_1)
	{
		requireElements()[P_0] = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 12, 114, 114 })]
	internal virtual void resizeEntries(int P_0)
	{
		entries = Arrays.copyOf(requireEntries(), P_0);
		elements = Arrays.copyOf(requireElements(), P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(746)]
	private int entry(int P_0)
	{
		return requireEntries()[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 116, 103, 103, 103, 105, 135, 101, 101, 164,
		102, 164, 107, 106, 101, 134, 237, 70, 102, 102,
		106, 134, 143, 98, 100, 132
	})]
	internal virtual void moveLastEntry(int P_0, int P_1)
	{
		object obj = requireTable();
		int[] array = requireEntries();
		object[] array2 = requireElements();
		int num = size() - 1;
		if (P_0 < num)
		{
			object obj2 = (array2[P_0] = array2[num]);
			array2[num] = null;
			array[P_0] = array[num];
			array[num] = 0;
			int num2 = Hashing.smearedHash(obj2) & P_1;
			int num3 = CompactHashing.tableGet(obj, num2);
			int num4 = num + 1;
			if (num3 == num4)
			{
				CompactHashing.tableSet(obj, num2, P_0 + 1);
				return;
			}
			int num5;
			int num6;
			do
			{
				num5 = num3 - 1;
				num6 = array[num5];
				num3 = CompactHashing.getNext(num6, P_1);
			}
			while (num3 != num4);
			array[num5] = CompactHashing.maskCombine(num6, P_0 + 1, P_1);
		}
		else
		{
			array2[P_0] = null;
			array[P_0] = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 250, 103 })]
	public override int size()
	{
		return delegateOrNull()?.size() ?? this.m_size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(626)]
	public override bool isEmpty()
	{
		return (size() == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(new byte[] { 161, 174, 103, 99, 137 })]
	public override Iterator iterator()
	{
		Set set = delegateOrNull();
		if (set != null)
		{
			Iterator result = set.iterator();
			_ = null;
			return result;
		}
		_1 result2 = new _1(this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[]
	{
		160, 185, 104, 135, 103, 99, 138, 103, 135, 103,
		101, 104, 104, 103, 111, 100, 134, 153, 245, 69,
		107, 131, 102, 102, 114, 103, 130, 107, 102, 132,
		102, 175, 134, 150, 176, 104, 108, 104, 102
	})]
	public override bool add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		if (needsAllocArrays())
		{
			allocArrays();
		}
		Set set = delegateOrNull();
		if (set != null)
		{
			bool result = set.add(P_0);
			_ = null;
			return result;
		}
		int[] array = requireEntries();
		object[] array2 = requireElements();
		int num = this.m_size;
		int num2 = num + 1;
		int num3 = Hashing.smearedHash(P_0);
		int num4 = hashTableMask();
		int num5 = num3 & num4;
		int num6 = CompactHashing.tableGet(requireTable(), num5);
		if (num6 == 0)
		{
			if (num2 > num4)
			{
				num4 = resizeTable(num4, CompactHashing.newCapacity(num4), num3, num);
			}
			else
			{
				CompactHashing.tableSet(requireTable(), num5, num + 1);
			}
		}
		else
		{
			int hashPrefix = CompactHashing.getHashPrefix(num3, num4);
			int num7 = 0;
			int num8;
			int num9;
			do
			{
				num8 = num6 - 1;
				num9 = array[num8];
				if (CompactHashing.getHashPrefix(num9, num4) == hashPrefix && com.google.common.@base.Objects.equal(P_0, array2[num8]))
				{
					return false;
				}
				num6 = CompactHashing.getNext(num9, num4);
				num7++;
			}
			while (num6 != 0);
			if (num7 >= 9)
			{
				bool result2 = convertToHashFloodingResistantImplementation().add(P_0);
				_ = null;
				return result2;
			}
			if (num2 > num4)
			{
				num4 = resizeTable(num4, CompactHashing.newCapacity(num4), num3, num);
			}
			else
			{
				array[num8] = CompactHashing.maskCombine(num9, num + 1, num4);
			}
		}
		resizeMeMaybe(num2);
		insertEntry(num, P_0, num3, num4);
		this.m_size = num2;
		incrementModCount();
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/CompactHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 132, 0, 0 })]
	[LineNumberTable(85)]
	public static CompactHashSet create()
	{
		CompactHashSet result = new CompactHashSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<+TE;>;)Lcom/google/common/collect/CompactHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 132, 0, 0 })]
	[LineNumberTable(new byte[] { 47, 108, 104 })]
	public static CompactHashSet create(Collection P_0)
	{
		CompactHashSet compactHashSet = createWithExpectedSize(P_0.size());
		compactHashSet.addAll(P_0);
		return compactHashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Lcom/google/common/collect/CompactHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 132, 0, 0 })]
	[LineNumberTable(new byte[] { 61, 104, 104 })]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static CompactHashSet create(params object[] P_0)
	{
		CompactHashSet compactHashSet = createWithExpectedSize(P_0.Length);
		Collections.addAll(compactHashSet, P_0);
		return compactHashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(277)]
	internal virtual bool isUsingHashFloodingResistance()
	{
		return delegateOrNull() != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 55, 104, 130, 103, 99, 138, 103, 103, 111,
		99, 130, 137, 101, 106, 112, 108, 130, 105, 99
	})]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (needsAllocArrays())
		{
			return false;
		}
		Set set = delegateOrNull();
		if (set != null)
		{
			bool result = set.contains(P_0);
			_ = null;
			return result;
		}
		int num = Hashing.smearedHash(P_0);
		int num2 = hashTableMask();
		int num3 = CompactHashing.tableGet(requireTable(), num & num2);
		if (num3 == 0)
		{
			return false;
		}
		int hashPrefix = CompactHashing.getHashPrefix(num, num2);
		do
		{
			int num4 = num3 - 1;
			int num5 = entry(num4);
			if (CompactHashing.getHashPrefix(num5, num2) == hashPrefix && com.google.common.@base.Objects.equal(P_0, element(num4)))
			{
				return true;
			}
			num3 = CompactHashing.getNext(num5, num2);
		}
		while (num3 != 0);
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(new byte[] { 161, 225, 104, 144, 103, 99, 104, 97, 46, 7 })]
	public override Spliterator spliterator()
	{
		if (needsAllocArrays())
		{
			Spliterator result = Spliterators.spliterator(new object[0], 17);
			_ = null;
			return result;
		}
		Set set = delegateOrNull();
		Spliterator result2 = ((set == null) ? Spliterators.spliterator(requireElements(), 0, this.m_size, 17) : set.spliterator());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 161, 237, 103, 103, 99, 137, 107, 45, 202 })]
	public override void forEach(Consumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		Set set = delegateOrNull();
		if (set != null)
		{
			set.forEach(P_0);
			return;
		}
		for (int num = firstEntryIndex(); num >= 0; num = getSuccessor(num))
		{
			P_0.accept(element(num));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 132, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 5, 104, 135, 103 })]
	public override object[] toArray()
	{
		if (needsAllocArrays())
		{
			return new object[0];
		}
		Set set = delegateOrNull();
		object[] result = ((set == null) ? Arrays.copyOf(requireElements(), this.m_size) : set.toArray());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 132, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 16, 104, 101, 132, 130, 103, 99, 105, 21 })]
	public override object[] toArray(object[] P_0)
	{
		if (needsAllocArrays())
		{
			if ((nint)P_0.LongLength > 0)
			{
				P_0[0] = null;
			}
			return P_0;
		}
		Set set = delegateOrNull();
		object[] result = ((set == null) ? ObjectArrays.toArrayImpl(requireElements(), 0, this.m_size, P_0) : set.toArray(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 33, 104, 129, 103, 99, 109, 104, 103, 129,
		103, 106, 135, 103, 104, 101, 140
	})]
	public virtual void trimToSize()
	{
		if (needsAllocArrays())
		{
			return;
		}
		Set set = delegateOrNull();
		if (set != null)
		{
			Set set2 = createHashFloodingResistantDelegate(size());
			set2.addAll(set);
			table = set2;
			return;
		}
		int num = this.m_size;
		if (num < (nint)requireEntries().LongLength)
		{
			resizeEntries(num);
		}
		int num2 = CompactHashing.tableSize(num);
		int num3 = hashTableMask();
		if (num2 < num3)
		{
			resizeTable(num3, num2, 0, 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 56, 104, 129, 102, 103, 99, 98, 117, 102,
		103, 137, 115, 107, 115, 135
	})]
	public override void clear()
	{
		if (!needsAllocArrays())
		{
			incrementModCount();
			Set set = delegateOrNull();
			if (set != null)
			{
				metadata = Ints.constrainToRange(size(), 3, 1073741823);
				set.clear();
				table = null;
				this.m_size = 0;
			}
			else
			{
				Arrays.fill(requireElements(), 0, this.m_size, null);
				CompactHashing.tableClear(requireTable());
				Arrays.fill(requireEntries(), 0, this.m_size, 0);
				this.m_size = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 76, 102, 108, 118, 103, 98 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeInt(size());
		Iterator iterator = this.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			P_0.writeObject(obj);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		162, 85, 102, 103, 100, 159, 12, 103, 102, 103,
		8, 198
	})]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		int num = P_0.readInt();
		if (num < 0)
		{
			int num2 = 25;
			num2 = num2;
			string reason = new StringBuilder(num2).append("Invalid size: ").append(num).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new InvalidObjectException(reason);
		}
		init(num);
		for (int i = 0; i < num; i++)
		{
			object obj = P_0.readObject();
			add(obj);
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
	protected CompactHashSet(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
