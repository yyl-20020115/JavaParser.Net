using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/CompactHashSet<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 57, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)57,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class CompactLinkedHashSet : CompactHashSet
{
	private const int ENDPOINT = -2;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private int[] predecessor;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private int[] successor;

	[NonSerialized]
	private int firstEntry;

	[NonSerialized]
	private int lastEntry;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 79, 104 })]
	internal CompactLinkedHashSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Lcom/google/common/collect/CompactLinkedHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(101)]
	public new static CompactLinkedHashSet createWithExpectedSize(int P_0)
	{
		CompactLinkedHashSet result = new CompactLinkedHashSet(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 105 })]
	internal CompactLinkedHashSet(int P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(272)]
	private int[] requirePredecessors()
	{
		return (int[])Objects.requireNonNull(predecessor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(276)]
	private int[] requireSuccessors()
	{
		return (int[])Objects.requireNonNull(successor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 126, 107 })]
	private void setSuccessor(int P_0, int P_1)
	{
		requireSuccessors()[P_0] = P_1 + 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 66, 107 })]
	private void setPredecessor(int P_0, int P_1)
	{
		requirePredecessors()[P_0] = P_1 + 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 70, 101, 137, 168, 101, 137, 138 })]
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
	[LineNumberTable(167)]
	private int getPredecessor(int P_0)
	{
		return requirePredecessors()[P_0] - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(172)]
	internal override int getSuccessor(int P_0)
	{
		return requireSuccessors()[P_0] - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/CompactLinkedHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(59)]
	public new static CompactLinkedHashSet create()
	{
		CompactLinkedHashSet result = new CompactLinkedHashSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<+TE;>;)Lcom/google/common/collect/CompactLinkedHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(new byte[] { 21, 108, 104 })]
	public new static CompactLinkedHashSet create(Collection P_0)
	{
		CompactLinkedHashSet compactLinkedHashSet = createWithExpectedSize(P_0.size());
		compactLinkedHashSet.addAll(P_0);
		return compactLinkedHashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Lcom/google/common/collect/CompactLinkedHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(new byte[] { 35, 104, 104 })]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public new static CompactLinkedHashSet create(params object[] P_0)
	{
		CompactLinkedHashSet compactLinkedHashSet = createWithExpectedSize(P_0.Length);
		Collections.addAll(compactLinkedHashSet, P_0);
		return compactLinkedHashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 88, 103, 104, 104 })]
	internal override void init(int P_0)
	{
		base.init(P_0);
		firstEntry = -2;
		lastEntry = -2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 95, 103, 108, 108 })]
	internal override int allocArrays()
	{
		int num = base.allocArrays();
		predecessor = new int[num];
		successor = new int[num];
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 104, 103, 103, 103 })]
	internal override Set convertToHashFloodingResistantImplementation()
	{
		Set result = base.convertToHashFloodingResistantImplementation();
		predecessor = null;
		successor = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITE;II)V")]
	[LineNumberTable(new byte[] { 160, 85, 107, 109, 107 })]
	internal override void insertEntry(int P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, int P_2, int P_3)
	{
		base.insertEntry(P_0, P_1, P_2, P_3);
		setSucceeds(lastEntry, P_0);
		setSucceeds(P_0, -2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 92, 105, 136, 116, 100, 110, 142, 105, 105 })]
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
		requirePredecessors()[num] = 0;
		requireSuccessors()[num] = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 106, 103, 114, 114 })]
	internal override void resizeEntries(int P_0)
	{
		base.resizeEntries(P_0);
		predecessor = Arrays.copyOf(requirePredecessors(), P_0);
		successor = Arrays.copyOf(requireSuccessors(), P_0);
	}

	internal override int firstEntryIndex()
	{
		return firstEntry;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(232)]
	internal override int adjustAfterRemove(int P_0, int P_1)
	{
		return (P_0 < size()) ? P_0 : P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(237)]
	public override object[] toArray()
	{
		object[] result = ObjectArrays.toArrayImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(243)]
	public override object[] toArray(object[] P_0)
	{
		object[] result = ObjectArrays.toArrayImpl(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(248)]
	public override Spliterator spliterator()
	{
		Spliterator result = Spliterators.spliterator(this, 17);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 139, 104, 129, 104, 136, 112, 115, 147, 104 })]
	public override void clear()
	{
		if (!needsAllocArrays())
		{
			firstEntry = -2;
			lastEntry = -2;
			if (predecessor != null && successor != null)
			{
				Arrays.fill(predecessor, 0, size(), 0);
				Arrays.fill(successor, 0, size(), 0);
			}
			base.clear();
		}
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected CompactLinkedHashSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
