using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.@base;

[Serializable]
[Signature("<E:Ljava/lang/Object;T:TE;>Lcom/google/common/base/Equivalence<Ljava/lang/Iterable<TT;>;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 1, 0, 0, 0, 90, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)90,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class PairwiseEquivalence : Equivalence, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/base/Equivalence<TE;>;")]
	internal Equivalence elementEquivalence;

	private const long serialVersionUID = 1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Equivalence<TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 171, 104, 113 })]
	internal PairwiseEquivalence(Equivalence P_0)
	{
		elementEquivalence = (Equivalence)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<TT;>;)I")]
	[LineNumberTable(new byte[] { 159, 191, 102, 118, 117, 98 })]
	protected internal virtual int doHash(Iterable P_0)
	{
		int num = 78721;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object t = iterator.next();
			num = num * 24943 + elementEquivalence.hash(t);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<TT;>;Ljava/lang/Iterable<TT;>;)Z")]
	[LineNumberTable(new byte[] { 159, 177, 103, 135, 112, 121, 194 })]
	protected internal virtual bool doEquivalent(Iterable P_0, Iterable P_1)
	{
		Iterator iterator = P_0.iterator();
		Iterator iterator2 = P_1.iterator();
		while (iterator.hasNext() && iterator2.hasNext())
		{
			if (!elementEquivalence.equivalent(iterator.next(), iterator2.next()))
			{
				return false;
			}
		}
		return (!iterator.hasNext() && !iterator2.hasNext()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 8, 104, 103, 180 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is PairwiseEquivalence)
		{
			PairwiseEquivalence pairwiseEquivalence = (PairwiseEquivalence)P_0;
			bool result = java.lang.Object.instancehelper_equals(elementEquivalence, pairwiseEquivalence.elementEquivalence);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	public override int hashCode()
	{
		return java.lang.Object.instancehelper_hashCode(elementEquivalence) ^ 0x46A3EB07;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public override string toString()
	{
		string text = java.lang.String.valueOf(elementEquivalence);
		int num = 11 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append(text).append(".pairwise()").toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(23)]
	protected internal override int doHash(object P_0)
	{
		int result = doHash((Iterable)P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(23)]
	protected internal override bool doEquivalent(object P_0, object P_1)
	{
		bool result = doEquivalent((Iterable)P_0, (Iterable)P_1);
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
	protected PairwiseEquivalence(SerializationInfo P_0, StreamingContext P_1)
	{
		Serialization.readObject(this, P_0);
	}
}
