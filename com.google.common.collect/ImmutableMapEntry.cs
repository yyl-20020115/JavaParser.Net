using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableEntry<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class ImmutableMapEntry : ImmutableEntry
{
	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMapEntry$NonTerminalImmutableMapEntry<TK;TV;>;")]
	internal sealed class NonTerminalImmutableBiMapEntry : NonTerminalImmutableMapEntry
	{
		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private ImmutableMapEntry nextInValueBucket;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 66, 107, 104 })]
		internal NonTerminalImmutableBiMapEntry(object P_0, object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] ImmutableMapEntry P_2, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] ImmutableMapEntry P_3)
			: base(P_0, P_1, P_2)
		{
			nextInValueBucket = P_3;
		}

		[Signature("()Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override ImmutableMapEntry getNextInValueBucket()
		{
			return nextInValueBucket;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected NonTerminalImmutableBiMapEntry(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	internal class NonTerminalImmutableMapEntry : ImmutableMapEntry
	{
		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private ImmutableMapEntry nextInKeyBucket;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 41, 106, 103 })]
		internal NonTerminalImmutableMapEntry(object P_0, object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] ImmutableMapEntry P_2)
			: base(P_0, P_1)
		{
			nextInKeyBucket = P_2;
		}

		[Signature("()Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal sealed override ImmutableMapEntry getNextInKeyBucket()
		{
			return nextInKeyBucket;
		}

		internal sealed override bool isReusable()
		{
			return false;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected NonTerminalImmutableMapEntry(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)V")]
	[LineNumberTable(new byte[] { 3, 104, 105 })]
	internal ImmutableMapEntry(object P_0, object P_1)
		: base(P_0, P_1)
	{
		CollectPreconditions.checkEntryNotNull(P_0, P_1);
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)[Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[LineNumberTable(49)]
	internal static ImmutableMapEntry[] createEntryArray(int P_0)
	{
		return new ImmutableMapEntry[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 8, 148 })]
	internal ImmutableMapEntry(ImmutableMapEntry P_0)
		: base(P_0.getKey(), P_0.getValue())
	{
	}

	[Signature("()Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual ImmutableMapEntry getNextInKeyBucket()
	{
		return null;
	}

	[Signature("()Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual ImmutableMapEntry getNextInValueBucket()
	{
		return null;
	}

	internal virtual bool isReusable()
	{
		return true;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableMapEntry(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
