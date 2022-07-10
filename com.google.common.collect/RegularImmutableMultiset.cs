using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
[ConstantPool(new object[]
{
	(byte)70,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class RegularImmutableMultiset : ImmutableMultiset
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Multisets$ImmutableEntry<TE;>;")]
	internal sealed class NonTerminalEntry : Multisets.ImmutableEntry
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multisets$ImmutableEntry<TE;>;")]
		private new Multisets.ImmutableEntry m_nextInBucket;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;ILcom/google/common/collect/Multisets$ImmutableEntry<TE;>;)V")]
		[LineNumberTable(new byte[] { 94, 106, 103 })]
		internal NonTerminalEntry(object P_0, int P_1, Multisets.ImmutableEntry P_2)
			: base(P_0, P_1)
		{
			this.m_nextInBucket = P_2;
		}

		[Signature("()Lcom/google/common/collect/Multisets$ImmutableEntry<TE;>;")]
		public override Multisets.ImmutableEntry nextInBucket()
		{
			return this.m_nextInBucket;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected NonTerminalEntry(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("[Lcom/google/common/collect/Multisets$ImmutableEntry<*>;")]
	private static Multisets.ImmutableEntry[] EMPTY_ARRAY;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMultiset<Ljava/lang/Object;>;")]
	internal static ImmutableMultiset EMPTY;

	internal const double MAX_LOAD_FACTOR = 1.0;

	internal const double HASH_FLOODING_FPP = 0.001;

	internal const int MAX_HASH_BUCKET_LENGTH = 9;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("[Lcom/google/common/collect/Multisets$ImmutableEntry<TE;>;")]
	private Multisets.ImmutableEntry[] entries;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("[Lcom/google/common/collect/Multisets$ImmutableEntry<*>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 70, 0, 0 })]
	private Multisets.ImmutableEntry[] hashTable;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private new int m_size;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private new int m_hashCode;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSet<TE;>;")]
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
	private new ImmutableSet m_elementSet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<+Lcom/google/common/collect/Multiset$Entry<+TE;>;>;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(new byte[]
	{
		159, 186, 135, 103, 99, 149, 108, 164, 136, 99,
		99, 100, 159, 3, 100, 110, 105, 105, 107, 135,
		100, 184, 120, 98, 141, 106, 108, 103, 104, 133,
		105, 109, 101, 239, 61
	})]
	internal static ImmutableMultiset create(Collection P_0)
	{
		int num = P_0.size();
		Multisets.ImmutableEntry[] array = new Multisets.ImmutableEntry[num];
		if (num == 0)
		{
			RegularImmutableMultiset result = new RegularImmutableMultiset(array, EMPTY_ARRAY, 0, 0, ImmutableSet.of());
			_ = null;
			return result;
		}
		int num2 = Hashing.closedTableSize(num, 1.0);
		int num3 = num2 - 1;
		Multisets.ImmutableEntry[] array2 = new Multisets.ImmutableEntry[num2];
		int num4 = 0;
		int num5 = 0;
		long num6 = 0L;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			Multiset.Entry entry2 = entry;
			object obj = Preconditions.checkNotNull(entry2.getElement());
			int num7 = entry2.getCount();
			int num8 = java.lang.Object.instancehelper_hashCode(obj);
			int num9 = Hashing.smear(num8) & num3;
			Multisets.ImmutableEntry immutableEntry = array2[num9];
			Multisets.ImmutableEntry immutableEntry2 = ((immutableEntry != null) ? new NonTerminalEntry(obj, num7, immutableEntry) : (((!(entry2 is Multisets.ImmutableEntry) || entry2 is NonTerminalEntry) && 0 == 0) ? new Multisets.ImmutableEntry(obj, num7) : ((Multisets.ImmutableEntry)entry2)));
			num5 += num8 ^ num7;
			int num10 = num4;
			num4++;
			array[num10] = immutableEntry2;
			array2[num9] = immutableEntry2;
			num6 += num7;
		}
		ImmutableMultiset result2 = ((!hashFloodingDetected(array2)) ? new RegularImmutableMultiset(array, array2, Ints.saturatedCast(num6), num5, null) : JdkBackedImmutableMultiset.create(ImmutableList.asImmutableList(array)));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Lcom/google/common/collect/Multisets$ImmutableEntry<TE;>;[Lcom/google/common/collect/Multisets$ImmutableEntry<*>;IILcom/google/common/collect/ImmutableSet<TE;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 70, 0,
		0
	})]
	[LineNumberTable(new byte[] { 82, 104, 103, 103, 103, 104, 104 })]
	private RegularImmutableMultiset(Multisets.ImmutableEntry[] P_0, Multisets.ImmutableEntry[] P_1, int P_2, int P_3, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableSet P_4)
	{
		entries = P_0;
		hashTable = P_1;
		this.m_size = P_2;
		this.m_hashCode = P_3;
		this.m_elementSet = P_4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Lcom/google/common/collect/Multisets$ImmutableEntry<*>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 70, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		39, 103, 98, 103, 100, 101, 226, 61, 9, 230,
		73
	})]
	private static bool hashFloodingDetected(Multisets.ImmutableEntry[] P_0)
	{
		for (int i = 0; i < (nint)P_0.LongLength; i++)
		{
			int num = 0;
			for (Multisets.ImmutableEntry immutableEntry = P_0[i]; immutableEntry != null; immutableEntry = immutableEntry.nextInBucket())
			{
				num++;
				if (num > 9)
				{
					return true;
				}
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 70, 103 })]
	public override ImmutableSet elementSet()
	{
		ImmutableSet immutableSet = this.m_elementSet;
		object result;
		if (immutableSet == null)
		{
			ElementSet.___003Cclinit_003E();
			ElementSet elementSet = new ElementSet(Arrays.asList(entries), this);
			result = elementSet;
			this.m_elementSet = elementSet;
		}
		else
		{
			result = immutableSet;
		}
		return (ImmutableSet)result;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		111, 103, 103, 130, 103, 101, 102, 131, 110, 9,
		233, 69
	})]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Multisets.ImmutableEntry[] array = hashTable;
		if (P_0 == null || array.Length == 0)
		{
			return 0;
		}
		int num = Hashing.smearedHash(P_0);
		int num2 = (int)((nint)array.LongLength - 1);
		for (Multisets.ImmutableEntry immutableEntry = array[num & num2]; immutableEntry != null; immutableEntry = immutableEntry.nextInBucket())
		{
			if (com.google.common.@base.Objects.equal(P_0, immutableEntry.getElement()))
			{
				int result = immutableEntry.getCount();
				_ = null;
				return result;
			}
		}
		return 0;
	}

	public override int size()
	{
		return this.m_size;
	}

	[Signature("(I)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(190)]
	internal override Multiset.Entry getEntry(int P_0)
	{
		return entries[P_0];
	}

	public override int hashCode()
	{
		return this.m_hashCode;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public new virtual Set elementSet()
	{
		ImmutableSet result = this.elementSet();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 132, 69, 107 })]
	static RegularImmutableMultiset()
	{
		ImmutableMultiset.___003Cclinit_003E();
		EMPTY_ARRAY = new Multisets.ImmutableEntry[0];
		EMPTY = create(ImmutableList.of());
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableMultiset(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
