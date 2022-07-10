using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMapBasedMultiset<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 45, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)45,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class LinkedHashMultiset : AbstractMapBasedMultiset
{
	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/LinkedHashMultiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(48)]
	public static LinkedHashMultiset create()
	{
		LinkedHashMultiset result = new LinkedHashMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/LinkedHashMultiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(new byte[] { 21, 108, 104 })]
	public static LinkedHashMultiset create(Iterable elements)
	{
		LinkedHashMultiset linkedHashMultiset = create(Multisets.inferDistinctElements(elements));
		Iterables.addAll(linkedHashMultiset, elements);
		return linkedHashMultiset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Lcom/google/common/collect/LinkedHashMultiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(59)]
	public static LinkedHashMultiset create(int distinctElements)
	{
		LinkedHashMultiset result = new LinkedHashMultiset(distinctElements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override int add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, int i)
	{
		int result = base.add(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 27, 109 })]
	private LinkedHashMultiset()
		: base(new LinkedHashMap())
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 110 })]
	private LinkedHashMultiset(int P_0)
		: base(Maps.newLinkedHashMapWithExpectedSize(P_0))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 40, 102, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		Serialization.writeMultiset(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 46, 102, 103, 107, 106 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		int num = Serialization.readCount(P_0);
		base.setBackingMap(new LinkedHashMap());
		Serialization.populateMultiset(this, P_0, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override int setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, int i)
	{
		int result = base.setCount(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, int i)
	{
		int result = base.remove(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		int result = base.count(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override Iterator iterator()
	{
		Iterator result = base.iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override int size()
	{
		int result = base.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override void clear()
	{
		base.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override void forEachEntry(ObjIntConsumer oic)
	{
		base.forEachEntry(oic);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override Set entrySet()
	{
		Set result = base.entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override Set elementSet()
	{
		Set result = base.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override bool setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, int i1, int i2)
	{
		bool result = base.setCount(obj, i1, i2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.contains(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected LinkedHashMultiset(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|add", "(Ljava.lang.Object;)Z")]
	public new bool add(object P_0)
	{
		return ((AbstractMultiset)this).add(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|remove", "(Ljava.lang.Object;)Z")]
	public new bool remove(object P_0)
	{
		return ((AbstractMultiset)this).remove(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|addAll", "(Ljava.util.Collection;)Z")]
	public new bool addAll(Collection P_0)
	{
		return ((AbstractMultiset)this).addAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|removeAll", "(Ljava.util.Collection;)Z")]
	public new bool removeAll(Collection P_0)
	{
		return ((AbstractMultiset)this).removeAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|retainAll", "(Ljava.util.Collection;)Z")]
	public new bool retainAll(Collection P_0)
	{
		return ((AbstractMultiset)this).retainAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|equals", "(Ljava.lang.Object;)Z")]
	public new bool equals(object P_0)
	{
		return ((AbstractMultiset)this).equals(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>6|hashCode", "()I")]
	public new int hashCode()
	{
		return ((AbstractMultiset)this).hashCode();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>7|toString", "()Ljava.lang.String;")]
	public new string toString()
	{
		return ((AbstractMultiset)this).toString();
	}
}
