using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using javax.annotation;

namespace com.google.common.@base;

[Serializable]
[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Lcom/google/common/base/Equivalence<TF;>;Ljava/io/Serializable;")]
[ConstantPool(new object[]
{
	(byte)34,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class FunctionalEquivalence : Equivalence, Serializable.__Interface, ISerializable
{
	private const long serialVersionUID = 0L;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Function<-TF;+TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 19, 2, 3, 1, 2, 0, 0, 34,
		0, 0
	})]
	private Function function;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Equivalence<TT;>;")]
	private Equivalence resultEquivalence;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Function<-TF;+TT;>;Lcom/google/common/base/Equivalence<TT;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 2, 3, 1, 2, 0, 0,
		34, 0, 0
	})]
	[LineNumberTable(new byte[] { 159, 184, 104, 113, 113 })]
	internal FunctionalEquivalence(Function P_0, Equivalence P_1)
	{
		function = (Function)Preconditions.checkNotNull(P_0);
		resultEquivalence = (Equivalence)Preconditions.checkNotNull(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TF;TF;)Z")]
	[LineNumberTable(49)]
	protected internal override bool doEquivalent(object P_0, object P_1)
	{
		bool result = resultEquivalence.equivalent(function.apply(P_0), function.apply(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TF;)I")]
	[LineNumberTable(54)]
	protected internal override int doHash(object P_0)
	{
		int result = resultEquivalence.hash(function.apply(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 100, 130, 104, 103, 159, 12 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 == this)
		{
			return true;
		}
		if (P_0 is FunctionalEquivalence)
		{
			FunctionalEquivalence functionalEquivalence = (FunctionalEquivalence)P_0;
			return (function.equals(functionalEquivalence.function) && java.lang.Object.instancehelper_equals(resultEquivalence, functionalEquivalence.resultEquivalence)) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(71)]
	public override int hashCode()
	{
		int result = Objects.hashCode(function, resultEquivalence);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	public override string toString()
	{
		string text = java.lang.String.valueOf(resultEquivalence);
		string text2 = java.lang.String.valueOf(function);
		int num = 13 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num = num;
		string result = new StringBuilder(num).append(text).append(".onResultOf(").append(text2)
			.append(")")
			.toString();
		_ = null;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected FunctionalEquivalence(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
