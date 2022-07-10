using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
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
internal sealed class Absent : Optional, IObjectReference
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Absent<Ljava/lang/Object;>;")]
	internal static Absent INSTANCE;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Optional<TT;>;")]
	internal static Optional withType()
	{
		return INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(35)]
	private Absent()
	{
	}

	public override bool isPresent()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TT;")]
	[LineNumberTable(44)]
	public override object get()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalStateException("Optional.get() cannot be called on an absent value");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;)TT;")]
	[LineNumberTable(49)]
	public override object or(object P_0)
	{
		object result = Preconditions.checkNotNull(P_0, (object)"use Optional.orNull() instead of Optional.or(null)");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Optional<+TT;>;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(55)]
	public override Optional or(Optional P_0)
	{
		return (Optional)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Supplier<+TT;>;)TT;")]
	[LineNumberTable(new byte[] { 10, 97, 42 })]
	public override object or(Supplier P_0)
	{
		object result = Preconditions.checkNotNull(P_0.get(), (object)"use Optional.orNull() instead of a Supplier that returns null");
		_ = null;
		return result;
	}

	[Signature("()TT;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object orNull()
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TT;>;")]
	[LineNumberTable(72)]
	public override Set asSet()
	{
		Set result = Collections.emptySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TT;TV;>;)Lcom/google/common/base/Optional<TV;>;")]
	[LineNumberTable(new byte[] { 27, 103 })]
	public override Optional transform(Function P_0)
	{
		Preconditions.checkNotNull(P_0);
		Optional result = Optional.absent();
		_ = null;
		return result;
	}

	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return P_0 == this;
	}

	public override int hashCode()
	{
		return 2040732332;
	}

	public override string toString()
	{
		return "Optional.absent()";
	}

	private object readResolve()
	{
		return INSTANCE;
	}

	[LineNumberTable(28)]
	static Absent()
	{
		INSTANCE = new Absent();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Absent(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[SecurityCritical]
	[HideFromJava]
	object IObjectReference.GetRealObject(StreamingContext P_0)
	{
		return readResolve();
	}
}
