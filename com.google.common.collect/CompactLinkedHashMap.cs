using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/CompactHashMap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 73, 0, 0,
	17, 1, 0, 0, 0, 73, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)73,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class CompactLinkedHashMap : CompactHashMap
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/CompactHashMap<TK;TV;>.EntrySetView;")]
	[EnclosingMethod(null, "createEntrySet", "()Ljava.util.Set;")]
	internal class _1EntrySetImpl : EntrySetView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(233)]
		internal _1EntrySetImpl(CompactLinkedHashMap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(236)]
		public override Spliterator spliterator()
		{
			Spliterator result = Spliterators.spliterator(this, 17);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/CompactHashMap<TK;TV;>.KeySetView;")]
	[EnclosingMethod(null, "createKeySet", "()Ljava.util.Set;")]
	[ConstantPool(new object[]
	{
		(byte)23,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _1KeySetImpl : KeySetView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(245)]
		internal _1KeySetImpl(CompactLinkedHashMap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 23, 0, 0 })]
		[LineNumberTable(248)]
		public override object[] toArray()
		{
			object[] result = ObjectArrays.toArrayImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 23, 0, 0 })]
		[LineNumberTable(254)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = ObjectArrays.toArrayImpl(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TK;>;")]
		[LineNumberTable(259)]
		public override Spliterator spliterator()
		{
			Spliterator result = Spliterators.spliterator(this, 17);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/CompactHashMap<TK;TV;>.ValuesView;")]
	[EnclosingMethod(null, "createValues", "()Ljava.util.Collection;")]
	[ConstantPool(new object[]
	{
		(byte)23,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _1ValuesImpl : ValuesView
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(268)]
		internal _1ValuesImpl(CompactLinkedHashMap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 23, 0, 0 })]
		[LineNumberTable(271)]
		public override object[] toArray()
		{
			object[] result = ObjectArrays.toArrayImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 23, 0, 0 })]
		[LineNumberTable(277)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = ObjectArrays.toArrayImpl(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TV;>;")]
		[LineNumberTable(282)]
		public override Spliterator spliterator()
		{
			Spliterator result = Spliterators.spliterator(this, 16);
			_ = null;
			return result;
		}
	}

	private const int ENDPOINT = -2;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal long[] links;

	[NonSerialized]
	private int firstEntry;

	[NonSerialized]
	private int lastEntry;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool accessOrder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 53, 105 })]
	internal CompactLinkedHashMap()
		: this(3)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 57, 106 })]
	internal CompactLinkedHashMap(int P_0)
		: this(P_0, false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 115, 162, 105, 103 })]
	internal CompactLinkedHashMap(int P_0, bool P_1)
		: base(P_0)
	{
		accessOrder = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(311)]
	private long link(int P_0)
	{
		return requireLinks()[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 201, 105 })]
	private void setLink(int P_0, long P_1)
	{
		requireLinks()[P_0] = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 108, 103, 124 })]
	private void setSuccessor(int P_0, int P_1)
	{
		long num = 4294967295L;
		setLink(P_0, (link(P_0) & (num ^ -1)) | ((P_1 + 1) & num));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 113, 106, 125 })]
	private void setPredecessor(int P_0, int P_1)
	{
		long num = -4294967296L;
		setLink(P_0, (link(P_0) & (num ^ -1)) | ((long)(P_1 + 1) << 32));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 118, 101, 137, 168, 101, 137, 138 })]
	private void setSucceeds(int P_0, int P_1)
	{
		if (P_0 == -2)
		{
			firstEntry = P_1;
		}
		else
		{
			setSuccessor(P_0, P_1);
		}
		if (P_1 == -2)
		{
			lastEntry = P_0;
		}
		else
		{
			setPredecessor(P_1, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(149)]
	private int getPredecessor(int P_0)
	{
		return (int)((ulong)link(P_0) >> 32) - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(154)]
	internal override int getSuccessor(int P_0)
	{
		return (int)link(P_0) - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(307)]
	private long[] requireLinks()
	{
		return (long[])Objects.requireNonNull(links);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/CompactLinkedHashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 73, 0, 0,
		18, 1, 0, 0, 0, 73, 0, 0
	})]
	[LineNumberTable(64)]
	public new static CompactLinkedHashMap create()
	{
		CompactLinkedHashMap result = new CompactLinkedHashMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Lcom/google/common/collect/CompactLinkedHashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 73, 0, 0,
		18, 1, 0, 0, 0, 73, 0, 0
	})]
	[LineNumberTable(78)]
	public new static CompactLinkedHashMap createWithExpectedSize(int P_0)
	{
		CompactLinkedHashMap result = new CompactLinkedHashMap(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 67, 103, 104, 104 })]
	internal override void init(int P_0)
	{
		base.init(P_0);
		firstEntry = -2;
		lastEntry = -2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 74, 103, 108 })]
	internal override int allocArrays()
	{
		int num = base.allocArrays();
		links = new long[num];
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Ljava/util/Map<TK;TV;>;")]
	[LineNumberTable(131)]
	internal override Map createHashFloodingResistantDelegate(int P_0)
	{
		LinkedHashMap result = new LinkedHashMap(P_0, 1f, accessOrder);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;TV;>;")]
	[LineNumberTable(new byte[] { 87, 103, 103 })]
	internal override Map convertToHashFloodingResistantImplementation()
	{
		Map result = base.convertToHashFloodingResistantImplementation();
		links = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITK;TV;II)V")]
	[LineNumberTable(new byte[] { 160, 70, 109, 109, 107 })]
	internal override void insertEntry(int P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2, int P_3, int P_4)
	{
		base.insertEntry(P_0, P_1, P_2, P_3, P_4);
		setSucceeds(lastEntry, P_0);
		setSucceeds(P_0, -2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 77, 136, 148, 109, 105, 136 })]
	internal override void accessEntry(int P_0)
	{
		if (accessOrder)
		{
			setSucceeds(getPredecessor(P_0), getSuccessor(P_0));
			setSucceeds(lastEntry, P_0);
			setSucceeds(P_0, -2);
			incrementModCount();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 89, 105, 136, 116, 100, 110, 142, 107 })]
	internal override void moveLastEntry(int P_0, int P_1)
	{
		int num = size() - 1;
		base.moveLastEntry(P_0, P_1);
		setSucceeds(getPredecessor(P_0), getSuccessor(P_0));
		if (P_0 < num)
		{
			setSucceeds(getPredecessor(num), P_0);
			setSucceeds(P_0, getSuccessor(num));
		}
		setLink(num, 0L);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 102, 103, 114 })]
	internal override void resizeEntries(int P_0)
	{
		base.resizeEntries(P_0);
		links = Arrays.copyOf(requireLinks(), P_0);
	}

	internal override int firstEntryIndex()
	{
		return firstEntry;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(227)]
	internal override int adjustAfterRemove(int P_0, int P_1)
	{
		return (P_0 < size()) ? P_0 : P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(239)]
	internal override Set createEntrySet()
	{
		_1EntrySetImpl result = new _1EntrySetImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(262)]
	internal override Set createKeySet()
	{
		_1KeySetImpl result = new _1KeySetImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(285)]
	internal override Collection createValues()
	{
		_1ValuesImpl result = new _1ValuesImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 176, 104, 129, 104, 104, 104, 148, 104 })]
	public override void clear()
	{
		if (!needsAllocArrays())
		{
			firstEntry = -2;
			lastEntry = -2;
			if (links != null)
			{
				Arrays.fill(links, 0, size(), 0L);
			}
			base.clear();
		}
	}

	[HideFromJava]
	static CompactLinkedHashMap()
	{
		CompactHashMap.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected CompactLinkedHashMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
