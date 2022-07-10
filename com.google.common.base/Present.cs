using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.@base;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Lcom/google/common/base/Optional<TT;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Present : Optional
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("TT;")]
	private object reference;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)V")]
	[LineNumberTable(new byte[] { 159, 172, 104, 103 })]
	internal Present(object P_0)
	{
		reference = P_0;
	}

	public override bool isPresent()
	{
		return true;
	}

	[Signature("()TT;")]
	public override object get()
	{
		return reference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)TT;")]
	[LineNumberTable(new byte[] { 159, 188, 108 })]
	public override object or(object P_0)
	{
		Preconditions.checkNotNull(P_0, (object)"use Optional.orNull() instead of Optional.or(null)");
		return reference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Optional<+TT;>;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(new byte[] { 2, 103 })]
	public override Optional or(Optional P_0)
	{
		Preconditions.checkNotNull(P_0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Supplier<+TT;>;)TT;")]
	[LineNumberTable(new byte[] { 8, 103 })]
	public override object or(Supplier P_0)
	{
		Preconditions.checkNotNull(P_0);
		return reference;
	}

	[Signature("()TT;")]
	public override object orNull()
	{
		return reference;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TT;>;")]
	[LineNumberTable(69)]
	public override Set asSet()
	{
		Set result = Collections.singleton(reference);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TT;TV;>;)Lcom/google/common/base/Optional<TV;>;")]
	[LineNumberTable(new byte[] { 24, 135, 42, 44 })]
	public override Optional transform(Function P_0)
	{
		Present result = new Present(Preconditions.checkNotNull(P_0.apply(reference), (object)"the Function passed to Optional.transform() must not return null."));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 104, 103, 148 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is Present)
		{
			Present present = (Present)P_0;
			bool result = java.lang.Object.instancehelper_equals(reference, present.reference);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(91)]
	public override int hashCode()
	{
		return 1502476572 + java.lang.Object.instancehelper_hashCode(reference);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	public override string toString()
	{
		string text = java.lang.String.valueOf(reference);
		int num = 13 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append("Optional.of(").append(text).append(")")
			.toString();
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Present(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
