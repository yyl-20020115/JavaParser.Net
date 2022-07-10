using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractBiMap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 1, 0, 0, 0, 59, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)59,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class EnumHashBiMap : AbstractBiMap
{
	[NonSerialized]
	[Signature("Ljava/lang/Class<TK;>;")]
	private Class m_keyType;

	private const long serialVersionUID = 0L;

	[Signature("()Ljava/lang/Class<TK;>;")]
	public virtual Class keyType()
	{
		return this.m_keyType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<TK;>;)V")]
	[LineNumberTable(new byte[] { 28, 136, 16, 167, 103 })]
	private EnumHashBiMap(Class P_0)
		: base(new EnumMap(P_0), Maps.newHashMapWithExpectedSize(((java.lang.Enum[])P_0.getEnumConstants()).Length))
	{
		this.m_keyType = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/lang/Class<TK;>;)Lcom/google/common/collect/EnumHashBiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 59, 0, 0 })]
	[LineNumberTable(57)]
	public static EnumHashBiMap create(Class keyType)
	{
		EnumHashBiMap result = new EnumHashBiMap(keyType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override void putAll(Map m)
	{
		base.putAll(m);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(106)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object forcePut(java.lang.Enum key, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		object result = base.forcePut(key, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(97)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object put(java.lang.Enum key, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		object result = base.put((object)key, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(88)]
	internal virtual java.lang.Enum checkKey(java.lang.Enum P_0)
	{
		return (java.lang.Enum)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/util/Map<TK;+TV;>;)Lcom/google/common/collect/EnumHashBiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 59, 0, 0 })]
	[LineNumberTable(new byte[] { 22, 108, 103 })]
	public static EnumHashBiMap create(Map map)
	{
		EnumHashBiMap enumHashBiMap = create(EnumBiMap.inferKeyType(map));
		enumHashBiMap.putAll(map);
		return enumHashBiMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 70, 102, 108, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeObject(this.m_keyType);
		Serialization.writeMap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 78, 102, 113, 119, 52, 133, 105 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		this.m_keyType = (Class)P_0.readObject();
		EnumMap.___003Cclinit_003E();
		base.setDelegates(new EnumMap(this.m_keyType), new HashMap((int)((nint)((java.lang.Enum[])this.m_keyType.getEnumConstants()).LongLength * 3 / 2)));
		Serialization.populateMap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override Set entrySet()
	{
		Set result = base.entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override Set values()
	{
		Set result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override Set keySet()
	{
		Set result = base.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override BiMap inverse()
	{
		BiMap result = base.inverse();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override void clear()
	{
		base.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override void replaceAll(BiFunction bf)
	{
		base.replaceAll(bf);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		object result = base.remove(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(44)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object forcePut(object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2)
	{
		object result = forcePut((java.lang.Enum)obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(44)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object put(object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2)
	{
		object result = put((java.lang.Enum)obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.containsValue(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal override object checkKey(object P_0)
	{
		java.lang.Enum result = checkKey((java.lang.Enum)P_0);
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected EnumHashBiMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|values", "()Ljava.util.Collection;")]
	public Collection _003Cbridge_003Evalues()
	{
		return ((AbstractBiMap)this).values();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|putIfAbsent", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.lang.Object;")]
	public new object putIfAbsent(object P_0, object P_1)
	{
		return ((AbstractBiMap)this).putIfAbsent(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|getOrDefault", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.lang.Object;")]
	public new object getOrDefault(object P_0, object P_1)
	{
		return ((AbstractBiMap)this).getOrDefault(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|forEach", "(Ljava.util.function.BiConsumer;)V")]
	public new void forEach(BiConsumer P_0)
	{
		((AbstractBiMap)this).forEach(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|remove", "(Ljava.lang.Object;Ljava.lang.Object;)Z")]
	public new bool remove(object P_0, object P_1)
	{
		return ((AbstractBiMap)this).remove(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|replace", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Z")]
	public new bool replace(object P_0, object P_1, object P_2)
	{
		return ((AbstractBiMap)this).replace(P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>6|replace", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.lang.Object;")]
	public new object replace(object P_0, object P_1)
	{
		return ((AbstractBiMap)this).replace(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>7|computeIfAbsent", "(Ljava.lang.Object;Ljava.util.function.Function;)Ljava.lang.Object;")]
	public new object computeIfAbsent(object P_0, java.util.function.Function P_1)
	{
		return ((AbstractBiMap)this).computeIfAbsent(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>8|computeIfPresent", "(Ljava.lang.Object;Ljava.util.function.BiFunction;)Ljava.lang.Object;")]
	public new object computeIfPresent(object P_0, BiFunction P_1)
	{
		return ((AbstractBiMap)this).computeIfPresent(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>9|compute", "(Ljava.lang.Object;Ljava.util.function.BiFunction;)Ljava.lang.Object;")]
	public new object compute(object P_0, BiFunction P_1)
	{
		return ((AbstractBiMap)this).compute(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>10|merge", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.util.function.BiFunction;)Ljava.lang.Object;")]
	public new object merge(object P_0, object P_1, BiFunction P_2)
	{
		return ((AbstractBiMap)this).merge(P_0, P_1, P_2);
	}
}
