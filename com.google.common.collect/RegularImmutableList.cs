using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using IKVM.Runtime;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableList<TE;>;")]
[ConstantPool(new object[]
{
	(byte)44,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class RegularImmutableList : ImmutableList
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<Ljava/lang/Object;>;")]
	internal static ImmutableList EMPTY;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	internal object[] array;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 180, 104, 103 })]
	internal RegularImmutableList(object[] P_0)
	{
		array = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/UnmodifiableListIterator<TE;>;")]
	[LineNumberTable(85)]
	public override UnmodifiableListIterator listIterator(int P_0)
	{
		UnmodifiableListIterator result = Iterators.forArray(array, 0, array.Length, P_0);
		_ = null;
		return result;
	}

	[LineNumberTable(44)]
	public override int size()
	{
		return array.Length;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	internal override object[] internalArray()
	{
		return array;
	}

	internal override int internalArrayStart()
	{
		return 0;
	}

	[LineNumberTable(64)]
	internal override int internalArrayEnd()
	{
		return array.Length;
	}

	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 44, 0,
		0
	})]
	[LineNumberTable(new byte[] { 19, 117 })]
	internal override int copyIntoArray(object[] P_0, int P_1)
	{
		ByteCodeHelper.arraycopy(array, 0, P_0, P_1, array.Length);
		return (int)(P_1 + (nint)array.LongLength);
	}

	[Signature("(I)TE;")]
	[LineNumberTable(77)]
	public override object get(int P_0)
	{
		return array[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TE;>;")]
	[LineNumberTable(90)]
	public override Spliterator spliterator()
	{
		Spliterator result = Spliterators.spliterator(array, 1296);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public new virtual ListIterator listIterator(int P_0)
	{
		UnmodifiableListIterator result = this.listIterator(P_0);
		_ = null;
		return result;
	}

	[LineNumberTable(34)]
	static RegularImmutableList()
	{
		ImmutableList.___003Cclinit_003E();
		EMPTY = new RegularImmutableList(new object[0]);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableList(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
