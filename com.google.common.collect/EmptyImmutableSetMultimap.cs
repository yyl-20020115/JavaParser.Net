using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;

namespace com.google.common.collect;

[Serializable]
[Signature("Lcom/google/common/collect/ImmutableSetMultimap<Ljava/lang/Object;Ljava/lang/Object;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class EmptyImmutableSetMultimap : ImmutableSetMultimap, IObjectReference
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static EmptyImmutableSetMultimap INSTANCE;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 111 })]
	private EmptyImmutableSetMultimap()
		: base(ImmutableMap.of(), 0, null)
	{
	}

	private object readResolve()
	{
		return INSTANCE;
	}

	[LineNumberTable(29)]
	static EmptyImmutableSetMultimap()
	{
		INSTANCE = new EmptyImmutableSetMultimap();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected EmptyImmutableSetMultimap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[SecurityCritical]
	[HideFromJava]
	object IObjectReference.GetRealObject(StreamingContext P_0)
	{
		if (((object)this).GetType() != typeof(EmptyImmutableSetMultimap))
		{
			return this;
		}
		return readResolve();
	}
}
