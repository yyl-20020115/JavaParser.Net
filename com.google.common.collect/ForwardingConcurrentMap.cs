using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;
using java.util.concurrent;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMap<TK;TV;>;Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.ConcurrentMap" })]
public abstract class ForwardingConcurrentMap : ForwardingMap, ConcurrentMap, Map
{
	[Signature("()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
	protected internal new abstract ConcurrentMap @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(45)]
	protected internal ForwardingConcurrentMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(54)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object putIfAbsent(object key, object value)
	{
		object result = @delegate().putIfAbsent(key, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(60)]
	public override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		bool result = @delegate().remove(key, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(67)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object replace(object key, object value)
	{
		object result = @delegate().replace(key, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;TV;)Z")]
	[LineNumberTable(73)]
	public override bool replace(object key, object oldValue, object newValue)
	{
		bool result = @delegate().replace(key, oldValue, newValue);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(39)]
	protected internal new virtual Map _003Cbridge_003Edelegate()
	{
		ConcurrentMap result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(39)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		ConcurrentMap result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object getOrDefault(object P_0, object P_1)
	{
		return ConcurrentMap._003Cdefault_003EgetOrDefault(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		ConcurrentMap._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void replaceAll(BiFunction P_0)
	{
		ConcurrentMap._003Cdefault_003EreplaceAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object computeIfAbsent(object P_0, Function P_1)
	{
		return ConcurrentMap._003Cdefault_003EcomputeIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object computeIfPresent(object P_0, BiFunction P_1)
	{
		return ConcurrentMap._003Cdefault_003EcomputeIfPresent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object compute(object P_0, BiFunction P_1)
	{
		return ConcurrentMap._003Cdefault_003Ecompute(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object merge(object P_0, object P_1, BiFunction P_2)
	{
		return ConcurrentMap._003Cdefault_003Emerge(this, P_0, P_1, P_2);
	}
}
