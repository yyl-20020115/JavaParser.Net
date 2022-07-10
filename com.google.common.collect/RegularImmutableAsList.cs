using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableAsList<TE;>;")]
[ConstantPool(new object[]
{
	(byte)60,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class RegularImmutableAsList : ImmutableAsList
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableCollection<TE;>;")]
	private ImmutableCollection @delegate;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<+TE;>;")]
	private ImmutableList m_delegateList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableCollection<TE;>;[Ljava/lang/Object;)V")]
	[LineNumberTable(new byte[] { 159, 186, 111 })]
	internal RegularImmutableAsList(ImmutableCollection P_0, object[] P_1)
		: this(P_0, ImmutableList.asImmutableList(P_1))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableCollection<TE;>;Lcom/google/common/collect/ImmutableList<+TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 180, 104, 103, 103 })]
	internal RegularImmutableAsList(ImmutableCollection P_0, ImmutableList P_1)
	{
		@delegate = P_0;
		this.m_delegateList = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/UnmodifiableListIterator<TE;>;")]
	[LineNumberTable(59)]
	public override UnmodifiableListIterator listIterator(int P_0)
	{
		UnmodifiableListIterator result = this.m_delegateList.listIterator(P_0);
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableCollection<TE;>;")]
	internal override ImmutableCollection delegateCollection()
	{
		return @delegate;
	}

	[Signature("()Lcom/google/common/collect/ImmutableList<+TE;>;")]
	internal virtual ImmutableList delegateList()
	{
		return this.m_delegateList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 15, 110 })]
	public override void forEach(Consumer P_0)
	{
		this.m_delegateList.forEach(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 60, 0,
		0
	})]
	[LineNumberTable(71)]
	internal override int copyIntoArray(object[] P_0, int P_1)
	{
		int result = this.m_delegateList.copyIntoArray(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(77)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal override object[] internalArray()
	{
		object[] result = this.m_delegateList.internalArray();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(82)]
	internal override int internalArrayStart()
	{
		int result = this.m_delegateList.internalArrayStart();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(87)]
	internal override int internalArrayEnd()
	{
		int result = this.m_delegateList.internalArrayEnd();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(92)]
	public override object get(int P_0)
	{
		object result = this.m_delegateList.get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public new virtual ListIterator listIterator(int P_0)
	{
		UnmodifiableListIterator result = this.listIterator(P_0);
		_ = null;
		return result;
	}

	[HideFromJava]
	static RegularImmutableAsList()
	{
		ImmutableAsList.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableAsList(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
