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

namespace com.google.common.collect;

[Serializable]
[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/Ordering<TT;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 81, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)81,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class CompoundOrdering : Ordering, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Final)]
	[Signature("[Ljava/util/Comparator<-TT;>;")]
	internal Comparator[] comparators;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TT;>;Ljava/util/Comparator<-TT;>;)V")]
	[LineNumberTable(new byte[] { 159, 175, 104, 116 })]
	internal CompoundOrdering(Comparator P_0, Comparator P_1)
	{
		comparators = new Comparator[2] { P_0, P_1 };
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/util/Comparator<-TT;>;>;)V")]
	[LineNumberTable(new byte[] { 159, 179, 104, 119 })]
	internal CompoundOrdering(Iterable P_0)
	{
		comparators = (Comparator[])Iterables.toArray(P_0, new Comparator[0]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TT;TT;)I")]
	[LineNumberTable(new byte[] { 159, 185, 108, 112, 99, 226, 61, 230, 70 })]
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
		for (int i = 0; i < (nint)comparators.LongLength; i++)
		{
			int num = comparators[i].compare(P_0, P_1);
			if (num != 0)
			{
				return num;
			}
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 100, 130, 104, 103, 148 })]
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
		if (P_0 is CompoundOrdering)
		{
			CompoundOrdering compoundOrdering = (CompoundOrdering)P_0;
			bool result = Arrays.equals(comparators, compoundOrdering.comparators);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(66)]
	public override int hashCode()
	{
		int result = Arrays.hashCode(comparators);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(71)]
	public override string toString()
	{
		string text = Arrays.toString(comparators);
		int num = 19 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append("Ordering.compound(").append(text).append(")")
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
	protected CompoundOrdering(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
