using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class JdkBackedImmutableMultiset : ImmutableMultiset
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<TE;Ljava/lang/Integer;>;")]
	private Map delegateMap;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	private ImmutableList entries;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new long m_size;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSet<TE;>;")]
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
		159, 182, 114, 104, 99, 106, 101, 105, 102, 110,
		112, 105, 236, 57, 233, 74, 98, 45
	})]
	internal static ImmutableMultiset create(Collection P_0)
	{
		Multiset.Entry[] array = (Multiset.Entry[])P_0.toArray(new Multiset.Entry[0]);
		HashMap hashMap = Maps.newHashMapWithExpectedSize(array.Length);
		long num = 0L;
		for (int i = 0; i < (nint)array.LongLength; i++)
		{
			Multiset.Entry entry = array[i];
			int num2 = entry.getCount();
			num += num2;
			object obj = Preconditions.checkNotNull(entry.getElement());
			((Map)hashMap).put(obj, (object)Integer.valueOf(num2));
			if (!(entry is Multisets.ImmutableEntry))
			{
				array[i] = Multisets.immutableEntry(obj, num2);
			}
		}
		JdkBackedImmutableMultiset result = new JdkBackedImmutableMultiset(hashMap, ImmutableList.asImmutableList(array), num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;Ljava/lang/Integer;>;Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Multiset$Entry<TE;>;>;J)V")]
	[LineNumberTable(new byte[] { 8, 104, 103, 103, 103 })]
	private JdkBackedImmutableMultiset(Map P_0, ImmutableList P_1, long P_2)
	{
		delegateMap = P_0;
		entries = P_1;
		this.m_size = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[] { 23, 103 })]
	public override ImmutableSet elementSet()
	{
		ImmutableSet immutableSet = this.m_elementSet;
		object result;
		if (immutableSet == null)
		{
			ElementSet.___003Cclinit_003E();
			ElementSet elementSet = new ElementSet(entries, this);
			result = elementSet;
			this.m_elementSet = elementSet;
		}
		else
		{
			result = immutableSet;
		}
		return (ImmutableSet)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(66)]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		int result = ((Integer)delegateMap.getOrDefault(P_0, Integer.valueOf(0))).intValue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(79)]
	internal override Multiset.Entry getEntry(int P_0)
	{
		return (Multiset.Entry)entries.get(P_0);
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(89)]
	public override int size()
	{
		int result = Ints.saturatedCast(this.m_size);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public new virtual Set elementSet()
	{
		ImmutableSet result = this.elementSet();
		_ = null;
		return result;
	}

	[HideFromJava]
	static JdkBackedImmutableMultiset()
	{
		ImmutableMultiset.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected JdkBackedImmutableMultiset(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
