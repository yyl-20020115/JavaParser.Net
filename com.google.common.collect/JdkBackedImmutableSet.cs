using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/IndexedImmutableSet<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class JdkBackedImmutableSet : IndexedImmutableSet
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Set<*>;")]
	private Set @delegate;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
	private ImmutableList delegateList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Set<*>;Lcom/google/common/collect/ImmutableList<TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 176, 104, 103, 103 })]
	internal JdkBackedImmutableSet(Set P_0, ImmutableList P_1)
	{
		@delegate = P_0;
		delegateList = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(41)]
	internal override object get(int P_0)
	{
		object result = delegateList.get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = @delegate.contains(P_0);
		_ = null;
		return result;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(56)]
	public override int size()
	{
		int result = delegateList.size();
		_ = null;
		return result;
	}

	[HideFromJava]
	static JdkBackedImmutableSet()
	{
		IndexedImmutableSet.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected JdkBackedImmutableSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
