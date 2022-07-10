using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.util.concurrent;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.function;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/AbstractCache<TK;TV;>;Lcom/google/common/cache/LoadingCache<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.cache.LoadingCache" })]
public abstract class AbstractLoadingCache : AbstractCache, LoadingCache, Cache, com.google.common.@base.Function, java.util.function.Function
{
	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract object get(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TV;")]
	[LineNumberTable(new byte[] { 1, 125, 97 })]
	public virtual object getUnchecked(object key)
	{
		//Discarded unreachable code: IL_0009
		ExecutionException ex;
		try
		{
			return get(key);
		}
		catch (ExecutionException x)
		{
			ex = ByteCodeHelper.MapException<ExecutionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		ExecutionException @this = ex;
		System.Exception cause = Throwable.instancehelper_getCause(@this);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UncheckedExecutionException(cause);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	protected internal AbstractLoadingCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(Ljava/lang/Iterable<+TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 9, 102, 118, 105, 143, 98 })]
	public virtual ImmutableMap getAll(Iterable keys)
	{
		LinkedHashMap linkedHashMap = Maps.newLinkedHashMap();
		Iterator iterator = keys.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (!((Map)linkedHashMap).containsKey(obj))
			{
				((Map)linkedHashMap).put(obj, get(obj));
			}
		}
		ImmutableMap result = ImmutableMap.copyOf(linkedHashMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TV;")]
	[LineNumberTable(70)]
	public object apply(object key)
	{
		object @unchecked = getUnchecked(key);
		_ = null;
		return @unchecked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)V")]
	[LineNumberTable(75)]
	public virtual void refresh(object key)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override object getIfPresent(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Function compose(java.util.function.Function P_0)
	{
		return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Function andThen(java.util.function.Function P_0)
	{
		return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
	}

	bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
	{
		return java.lang.Object.instancehelper_equals(this, P_0);
	}
}
