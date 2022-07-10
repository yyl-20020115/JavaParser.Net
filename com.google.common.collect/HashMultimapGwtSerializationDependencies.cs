using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractSetMultimap<TK;TV;>;")]
internal abstract class HashMultimapGwtSerializationDependencies : AbstractSetMultimap
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;)V")]
	[LineNumberTable(new byte[] { 159, 177, 105 })]
	internal HashMultimapGwtSerializationDependencies(Map P_0)
		: base(P_0)
	{
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected HashMultimapGwtSerializationDependencies(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
