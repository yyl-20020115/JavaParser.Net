using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Lcom/google/common/collect/Ordering<TF;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 75, 0, 0,
	17, 1, 0, 0, 0, 75, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)75,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class ByFunctionOrdering : Ordering, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/base/Function<TF;+TT;>;")]
	internal Function function;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Ordering<TT;>;")]
	internal Ordering ordering;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Function<TF;+TT;>;Lcom/google/common/collect/Ordering<TT;>;)V")]
	[LineNumberTable(new byte[] { 159, 181, 104, 113, 113 })]
	internal ByFunctionOrdering(Function P_0, Ordering P_1)
	{
		function = (Function)Preconditions.checkNotNull(P_0);
		ordering = (Ordering)Preconditions.checkNotNull(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TF;TF;)I")]
	[LineNumberTable(46)]
	public override int compare([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		int result = ordering.compare(function.apply(P_0), function.apply(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 1, 100, 130, 104, 103, 159, 12 })]
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
		if (P_0 is ByFunctionOrdering)
		{
			ByFunctionOrdering byFunctionOrdering = (ByFunctionOrdering)P_0;
			return (function.equals(byFunctionOrdering.function) && java.lang.Object.instancehelper_equals(ordering, byFunctionOrdering.ordering)) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(63)]
	public override int hashCode()
	{
		int result = Objects.hashCode(function, ordering);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	public override string toString()
	{
		string text = java.lang.String.valueOf(ordering);
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
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ByFunctionOrdering(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
