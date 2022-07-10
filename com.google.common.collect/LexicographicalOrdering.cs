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
[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/Ordering<Ljava/lang/Iterable<TT;>;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 79, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)79,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal sealed class LexicographicalOrdering : Ordering, Serializable.__Interface, ISerializable
{
	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/Comparator<-TT;>;")]
	internal Comparator elementOrder;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TT;>;)V")]
	[LineNumberTable(new byte[] { 159, 175, 104, 103 })]
	internal LexicographicalOrdering(Comparator P_0)
	{
		elementOrder = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<TT;>;Ljava/lang/Iterable<TT;>;)I")]
	[LineNumberTable(new byte[]
	{
		159, 181, 103, 103, 104, 104, 130, 120, 99, 130,
		98, 104, 130
	})]
	public virtual int compare(Iterable P_0, Iterable P_1)
	{
		Iterator iterator = P_0.iterator();
		Iterator iterator2 = P_1.iterator();
		while (iterator.hasNext())
		{
			if (!iterator2.hasNext())
			{
				return 1;
			}
			int num = elementOrder.compare(iterator.next(), iterator2.next());
			if (num != 0)
			{
				return num;
			}
		}
		if (iterator2.hasNext())
		{
			return -1;
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 8, 100, 130, 104, 103, 148 })]
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
		if (P_0 is LexicographicalOrdering)
		{
			LexicographicalOrdering lexicographicalOrdering = (LexicographicalOrdering)P_0;
			bool result = elementOrder.equals(lexicographicalOrdering.elementOrder);
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(70)]
	public override int hashCode()
	{
		return java.lang.Object.instancehelper_hashCode(elementOrder) ^ 0x7BB78CF5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(75)]
	public override string toString()
	{
		string text = java.lang.String.valueOf(elementOrder);
		int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
		num = num;
		string result = new StringBuilder(num).append(text).append(".lexicographical()").toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(27)]
	public override int compare(object P_0, object P_1)
	{
		int result = compare((Iterable)P_0, (Iterable)P_1);
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
	protected LexicographicalOrdering(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
