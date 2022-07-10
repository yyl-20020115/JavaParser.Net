using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMultimap<TK;TV;>;Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 55, 0, 0,
	17, 1, 0, 0, 0, 55, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)55,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.ListMultimap" })]
public abstract class ForwardingListMultimap : ForwardingMultimap, ListMultimap, Multimap
{
	[Signature("()Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	protected internal new abstract ListMultimap @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/List<TV;>;")]
	[LineNumberTable(62)]
	public new virtual List replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key, Iterable values)
	{
		List result = @delegate().replaceValues(key, values);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/List<TV;>;")]
	[LineNumberTable(56)]
	public new virtual List removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		List result = @delegate().removeAll(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/List<TV;>;")]
	[LineNumberTable(50)]
	public new virtual List get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		List result = @delegate().get(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	protected internal ForwardingListMultimap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(37)]
	public virtual Collection _003Cbridge_003EreplaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i)
	{
		List result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(37)]
	public virtual Collection _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		List result = removeAll(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(37)]
	public virtual Collection _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj)
	{
		List result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(37)]
	protected internal new virtual Multimap _003Cbridge_003Edelegate()
	{
		ListMultimap result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(37)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		ListMultimap result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		Multimap._003Cdefault_003EforEach(this, P_0);
	}

	Collection Multimap.Multimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return _003Cbridge_003EreplaceValues(P_0, P_1);
	}

	Collection Multimap.Multimap_003A_003AremoveAll(object P_0)
	{
		return _003Cbridge_003EremoveAll(P_0);
	}

	Collection Multimap.Multimap_003A_003Aget(object P_0)
	{
		return _003Cbridge_003Eget(P_0);
	}
}
