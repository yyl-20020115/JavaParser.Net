using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$CachingAsList<TE;>;")]
[ConstantPool(new object[]
{
	(byte)35,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class RegularImmutableSet : ImmutableSet.CachingAsList
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static object[] EMPTY_ARRAY;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/RegularImmutableSet<Ljava/lang/Object;>;")]
	internal static RegularImmutableSet EMPTY;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private object[] elements;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private new int m_hashCode;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 35, 0, 0 })]
	internal object[] table;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private int mask;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 2, 1, 0, 0, 0, 35, 0,
		0
	})]
	[LineNumberTable(new byte[] { 159, 188, 104, 103, 103, 103, 104 })]
	internal RegularImmutableSet(object[] P_0, int P_1, object[] P_2, int P_3)
	{
		elements = P_0;
		this.m_hashCode = P_1;
		table = P_2;
		mask = P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(77)]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableIterator result = Iterators.forArray(elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		5, 103, 103, 130, 103, 105, 100, 99, 98, 105,
		226, 58
	})]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		object[] array = table;
		if (P_0 == null || array.Length == 0)
		{
			return false;
		}
		int num = Hashing.smearedHash(P_0);
		while (true)
		{
			num &= mask;
			object obj = array[num];
			if (obj == null)
			{
				return false;
			}
			if (java.lang.Object.instancehelper_equals(obj, P_0))
			{
				break;
			}
			num++;
		}
		return true;
	}

	[LineNumberTable(72)]
	public override int size()
	{
		return elements.Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(82)]
	public override Spliterator spliterator()
	{
		Spliterator result = Spliterators.spliterator(elements, 1297);
		_ = null;
		return result;
	}

	internal override object[] internalArray()
	{
		return elements;
	}

	internal override int internalArrayStart()
	{
		return 0;
	}

	[LineNumberTable(97)]
	internal override int internalArrayEnd()
	{
		return elements.Length;
	}

	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 35, 0,
		0
	})]
	[LineNumberTable(new byte[] { 52, 117 })]
	internal override int copyIntoArray(object[] P_0, int P_1)
	{
		ByteCodeHelper.arraycopy(elements, 0, P_0, P_1, elements.Length);
		return (int)(P_1 + (nint)elements.LongLength);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 58, 105, 103, 19 })]
	internal override ImmutableList createAsList()
	{
		object result;
		if (table.Length == 0)
		{
			result = ImmutableList.of();
		}
		else
		{
			RegularImmutableAsList.___003Cclinit_003E();
			result = new RegularImmutableAsList(this, elements);
		}
		_ = null;
		return (ImmutableList)result;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	public override int hashCode()
	{
		return this.m_hashCode;
	}

	internal override bool isHashCodeFast()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 134, 165, 107 })]
	static RegularImmutableSet()
	{
		CachingAsList.___003Cclinit_003E();
		EMPTY_ARRAY = new object[0];
		EMPTY = new RegularImmutableSet(EMPTY_ARRAY, 0, EMPTY_ARRAY, 0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
