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
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractSortedKeySortedSetMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 79, 0, 0,
	17, 1, 0, 0, 0, 79, 0, 0
})]
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
public class TreeMultimap : AbstractSortedKeySortedSetMultimap
{
	[NonSerialized]
	[Signature("Ljava/util/Comparator<-TK;>;")]
	private Comparator m_keyComparator;

	[NonSerialized]
	[Signature("Ljava/util/Comparator<-TV;>;")]
	private new Comparator m_valueComparator;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TK;>;Ljava/util/Comparator<-TV;>;)V")]
	[LineNumberTable(new byte[] { 61, 110, 103, 103 })]
	internal TreeMultimap(Comparator P_0, Comparator P_1)
		: base(new TreeMap(P_0))
	{
		this.m_keyComparator = P_0;
		this.m_valueComparator = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TK;>;Ljava/util/Comparator<-TV;>;Lcom/google/common/collect/Multimap<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 70, 106, 104 })]
	private TreeMultimap(Comparator P_0, Comparator P_1, Multimap P_2)
		: this(P_0, P_1)
	{
		putAll(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override bool putAll(Multimap m)
	{
		bool result = base.putAll(m);
		_ = null;
		return result;
	}

	[Obsolete]
	[Signature("()Ljava/util/Comparator<-TK;>;")]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual Comparator keyComparator()
	{
		return this.m_keyComparator;
	}

	[Signature("()Ljava/util/Comparator<-TV;>;")]
	public override Comparator valueComparator()
	{
		return this.m_valueComparator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TK;>;")]
	[LineNumberTable(182)]
	public new virtual NavigableSet keySet()
	{
		return (NavigableSet)base.keySet();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(196)]
	public new virtual NavigableMap asMap()
	{
		return (NavigableMap)base.asMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/NavigableSet<TV;>;")]
	[LineNumberTable(168)]
	public new virtual NavigableSet get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		return (NavigableSet)base.get(key);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedSet<TV;>;")]
	[LineNumberTable(138)]
	internal override SortedSet createCollection()
	{
		TreeSet.___003Cclinit_003E();
		TreeSet result = new TreeSet(this.m_valueComparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable;V::Ljava/lang/Comparable;>()Lcom/google/common/collect/TreeMultimap<TK;TV;>;")]
	[LineNumberTable(84)]
	public static TreeMultimap create()
	{
		TreeMultimap result = new TreeMultimap(Ordering.natural(), Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/TreeMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 79, 0, 0,
		18, 1, 0, 0, 0, 79, 0, 0
	})]
	[LineNumberTable(96)]
	public static TreeMultimap create(Comparator keyComparator, Comparator valueComparator)
	{
		TreeMultimap result = new TreeMultimap((Comparator)Preconditions.checkNotNull(keyComparator), (Comparator)Preconditions.checkNotNull(valueComparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable;V::Ljava/lang/Comparable;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/TreeMultimap<TK;TV;>;")]
	[LineNumberTable(107)]
	public static TreeMultimap create(Multimap multimap)
	{
		TreeMultimap result = new TreeMultimap(Ordering.natural(), Ordering.natural(), multimap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(126)]
	internal override Map createAsMap()
	{
		Map result = createMaybeNavigableAsMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 93, 99, 142 })]
	internal override Collection createCollection([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		if (P_0 == null)
		{
			keyComparator().compare(P_0, P_0);
		}
		Collection result = base.createCollection(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 91, 102, 108, 108, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeObject(keyComparator());
		P_0.writeObject(valueComparator());
		Serialization.writeMultimap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 160, 100, 102, 123, 123, 118, 105 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		this.m_keyComparator = (Comparator)Preconditions.checkNotNull((Comparator)P_0.readObject());
		this.m_valueComparator = (Comparator)Preconditions.checkNotNull((Comparator)P_0.readObject());
		TreeMap.___003Cclinit_003E();
		setMap(new TreeMap(this.m_keyComparator));
		Serialization.populateMultimap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(73)]
	public virtual SortedSet _003Cbridge_003EkeySet()
	{
		NavigableSet result = keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(73)]
	public virtual SortedMap _003Cbridge_003EasMap()
	{
		NavigableMap result = asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override Collection values()
	{
		Collection result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(73)]
	public virtual Map _003Cbridge_003EasMap()
	{
		NavigableMap result = asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override SortedSet replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i)
	{
		SortedSet result = base.replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override SortedSet removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		SortedSet result = base.removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(73)]
	public virtual SortedSet _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj)
	{
		NavigableSet result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(73)]
	public virtual Set _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj)
	{
		NavigableSet result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(73)]
	public virtual Set _003Cbridge_003EkeySet()
	{
		NavigableSet result = keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(73)]
	public virtual Collection _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj)
	{
		NavigableSet result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.equals(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override bool put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2)
	{
		bool result = base.put(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override Set entries()
	{
		Set result = base.entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	internal override Set createCollection()
	{
		SortedSet result = this.createCollection();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override void forEach(BiConsumer bc)
	{
		base.forEach(bc);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override void clear()
	{
		base.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.containsKey(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override int size()
	{
		int result = base.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	internal override Collection createCollection()
	{
		SortedSet result = this.createCollection();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override int hashCode()
	{
		int result = base.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override Multiset keys()
	{
		Multiset result = base.keys();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override bool putAll([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i)
	{
		bool result = base.putAll(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2)
	{
		bool result = base.remove(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override bool containsEntry([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2)
	{
		bool result = base.containsEntry(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
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
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(73)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected TreeMultimap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|replaceValues", "(Ljava.lang.Object;Ljava.lang.Iterable;)Ljava.util.Set;")]
	public Set _003Cbridge_003EreplaceValues(object P_0, Iterable P_1)
	{
		return ((AbstractSortedSetMultimap)this).replaceValues(P_0, P_1);
	}

	[HideFromJava]
	protected internal Set _003Cnonvirtual_003E0(object P_0, Iterable P_1)
	{
		return ((AbstractSortedSetMultimap)this).replaceValues(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|removeAll", "(Ljava.lang.Object;)Ljava.util.Set;")]
	public Set _003Cbridge_003EremoveAll(object P_0)
	{
		return ((AbstractSortedSetMultimap)this).removeAll(P_0);
	}

	[HideFromJava]
	protected internal Set _003Cnonvirtual_003E1(object P_0)
	{
		return ((AbstractSortedSetMultimap)this).removeAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|removeAll", "(Ljava.lang.Object;)Ljava.util.Collection;")]
	public Collection _003Cbridge_003EremoveAll(object P_0)
	{
		return ((AbstractSortedSetMultimap)this).removeAll(P_0);
	}

	[HideFromJava]
	protected internal Collection _003Cnonvirtual_003E2(object P_0)
	{
		return ((AbstractSortedSetMultimap)this).removeAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|replaceValues", "(Ljava.lang.Object;Ljava.lang.Iterable;)Ljava.util.Collection;")]
	public Collection _003Cbridge_003EreplaceValues(object P_0, Iterable P_1)
	{
		return ((AbstractSortedSetMultimap)this).replaceValues(P_0, P_1);
	}

	[HideFromJava]
	protected internal Collection _003Cnonvirtual_003E3(object P_0, Iterable P_1)
	{
		return ((AbstractSortedSetMultimap)this).replaceValues(P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|entries", "()Ljava.util.Collection;")]
	public Collection _003Cbridge_003Eentries()
	{
		return ((AbstractSetMultimap)this).entries();
	}

	[HideFromJava]
	protected internal Collection _003Cnonvirtual_003E4()
	{
		return ((AbstractSetMultimap)this).entries();
	}
}
