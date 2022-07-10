using System;
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
[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Enum<TV;>;>Lcom/google/common/collect/AbstractBiMap<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class EnumBiMap : AbstractBiMap
{
	[NonSerialized]
	[Signature("Ljava/lang/Class<TK;>;")]
	private Class m_keyType;

	[NonSerialized]
	[Signature("Ljava/lang/Class<TV;>;")]
	private Class m_valueType;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<TK;>;Ljava/lang/Class<TV;>;)V")]
	[LineNumberTable(new byte[] { 23, 116, 103, 103 })]
	private EnumBiMap(Class P_0, Class P_1)
		: base(new EnumMap(P_0), new EnumMap(P_1))
	{
		this.m_keyType = P_0;
		this.m_valueType = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;>(Ljava/util/Map<TK;*>;)Ljava/lang/Class<TK;>;")]
	[LineNumberTable(new byte[] { 29, 104, 142, 104, 142, 113 })]
	internal static Class inferKeyType(Map P_0)
	{
		if (P_0 is EnumBiMap)
		{
			Class result = ((EnumBiMap)P_0).keyType();
			_ = null;
			return result;
		}
		if (P_0 is EnumHashBiMap)
		{
			Class result2 = ((EnumHashBiMap)P_0).keyType();
			_ = null;
			return result2;
		}
		Preconditions.checkArgument((!P_0.isEmpty()) ? true : false);
		Class declaringClass = ((java.lang.Enum)P_0.keySet().iterator().next()).getDeclaringClass();
		_ = null;
		return declaringClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Enum<TV;>;>(Ljava/util/Map<*TV;>;)Ljava/lang/Class<TV;>;")]
	[LineNumberTable(new byte[] { 40, 104, 140, 113 })]
	private static Class inferValueType(Map P_0)
	{
		if (P_0 is EnumBiMap)
		{
			return ((EnumBiMap)P_0).m_valueType;
		}
		Preconditions.checkArgument((!P_0.isEmpty()) ? true : false);
		Class declaringClass = ((java.lang.Enum)P_0.values().iterator().next()).getDeclaringClass();
		_ = null;
		return declaringClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Enum<TV;>;>(Ljava/lang/Class<TK;>;Ljava/lang/Class<TV;>;)Lcom/google/common/collect/EnumBiMap<TK;TV;>;")]
	[LineNumberTable(54)]
	public static EnumBiMap create(Class keyType, Class valueType)
	{
		EnumBiMap result = new EnumBiMap(keyType, valueType);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	public override void putAll(Map m)
	{
		base.putAll(m);
	}

	[Signature("()Ljava/lang/Class<TK;>;")]
	public virtual Class keyType()
	{
		return this.m_keyType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TV;)TV;")]
	[LineNumberTable(114)]
	internal virtual java.lang.Enum checkValue(java.lang.Enum P_0)
	{
		return (java.lang.Enum)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(109)]
	internal virtual java.lang.Enum checkKey(java.lang.Enum P_0)
	{
		return (java.lang.Enum)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Enum<TV;>;>(Ljava/util/Map<TK;TV;>;)Lcom/google/common/collect/EnumBiMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 17, 114, 103 })]
	public static EnumBiMap create(Map map)
	{
		EnumBiMap enumBiMap = create(inferKeyType(map), inferValueType(map));
		enumBiMap.putAll(map);
		return enumBiMap;
	}

	[Signature("()Ljava/lang/Class<TV;>;")]
	public virtual Class valueType()
	{
		return this.m_valueType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 73, 102, 108, 108, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeObject(this.m_keyType);
		P_0.writeObject(this.m_valueType);
		Serialization.writeMap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 82, 102, 113, 113, 127, 7, 105 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		this.m_keyType = (Class)P_0.readObject();
		this.m_valueType = (Class)P_0.readObject();
		EnumMap.___003Cclinit_003E();
		EnumMap enumMap = new EnumMap(this.m_keyType);
		EnumMap.___003Cclinit_003E();
		base.setDelegates(enumMap, new EnumMap(this.m_valueType));
		Serialization.populateMap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	public override Set entrySet()
	{
		Set result = base.entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	public override Set values()
	{
		Set result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	public override Set keySet()
	{
		Set result = base.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	public override BiMap inverse()
	{
		BiMap result = base.inverse();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	public override void clear()
	{
		base.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	public override void replaceAll(BiFunction bf)
	{
		base.replaceAll(bf);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
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
	[LineNumberTable(40)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object forcePut([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2)
	{
		object result = base.forcePut(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2)
	{
		object result = base.put(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
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
	[LineNumberTable(40)]
	internal override object checkValue(object P_0)
	{
		java.lang.Enum result = checkValue((java.lang.Enum)P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(40)]
	internal override object checkKey(object P_0)
	{
		java.lang.Enum result = checkKey((java.lang.Enum)P_0);
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected EnumBiMap(SerializationInfo P_0, StreamingContext P_1)
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
