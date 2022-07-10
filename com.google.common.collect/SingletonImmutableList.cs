using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableList<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SingletonImmutableList : ImmutableList
{
	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("TE;")]
	internal object element;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 159, 180, 104, 108 })]
	internal SingletonImmutableList(object P_0)
	{
		element = Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 15, 104 })]
	public override ImmutableList subList(int P_0, int P_1)
	{
		Preconditions.checkPositionIndexes(P_0, P_1, 1);
		return (P_0 != P_1) ? this : ImmutableList.of();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(50)]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableIterator result = Iterators.singletonIterator(element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(new byte[] { 159, 186, 104 })]
	public override object get(int P_0)
	{
		Preconditions.checkElementIndex(P_0, 1);
		return element;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(55)]
	public override Spliterator spliterator()
	{
		Spliterator result = Collections.singleton(element).spliterator();
		_ = null;
		return result;
	}

	public override int size()
	{
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(71)]
	public override string toString()
	{
		string text = java.lang.Object.instancehelper_toString(element);
		int num = 2 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append('[').append(text).append(']')
			.toString();
		_ = null;
		return result;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public new virtual List subList(int P_0, int P_1)
	{
		ImmutableList result = this.subList(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public new virtual Iterator iterator()
	{
		UnmodifiableIterator result = this.iterator();
		_ = null;
		return result;
	}

	[HideFromJava]
	static SingletonImmutableList()
	{
		ImmutableList.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected SingletonImmutableList(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
