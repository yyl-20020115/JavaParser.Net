using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/ForwardingCache<TK;TV;>;Lcom/google/common/cache/LoadingCache<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.cache.LoadingCache" })]
public abstract class ForwardingLoadingCache : ForwardingCache, LoadingCache, Cache, com.google.common.@base.Function, java.util.function.Function
{
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/cache/ForwardingLoadingCache<TK;TV;>;")]
	public abstract class SimpleForwardingLoadingCache : ForwardingLoadingCache
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/cache/LoadingCache<TK;TV;>;")]
		private new LoadingCache m_delegate;

		[Signature("()Lcom/google/common/cache/LoadingCache<TK;TV;>;")]
		protected internal sealed override LoadingCache @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/cache/LoadingCache<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 29, 104, 113 })]
		protected internal SimpleForwardingLoadingCache(LoadingCache @delegate)
		{
			this.m_delegate = (LoadingCache)Preconditions.checkNotNull(@delegate);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(75)]
		protected internal override Cache _003Cbridge_003Edelegate()
		{
			LoadingCache result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(75)]
		protected internal override object _003Cbridge_003Edelegate()
		{
			LoadingCache result = @delegate();
			_ = null;
			return result;
		}
	}

	[Signature("()Lcom/google/common/cache/LoadingCache<TK;TV;>;")]
	protected internal new abstract LoadingCache @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(39)]
	protected internal ForwardingLoadingCache()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(TK;)TV;")]
	[LineNumberTable(46)]
	public virtual object get(object key)
	{
		object result = @delegate().get(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TV;")]
	[LineNumberTable(51)]
	public virtual object getUnchecked(object key)
	{
		object @unchecked = @delegate().getUnchecked(key);
		_ = null;
		return @unchecked;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("(Ljava/lang/Iterable<+TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(56)]
	public virtual ImmutableMap getAll(Iterable keys)
	{
		ImmutableMap all = @delegate().getAll(keys);
		_ = null;
		return all;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TV;")]
	[LineNumberTable(61)]
	public virtual object apply(object key)
	{
		object result = @delegate().apply(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)V")]
	[LineNumberTable(new byte[] { 16, 110 })]
	public virtual void refresh(object key)
	{
		@delegate().refresh(key);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(33)]
	protected internal new virtual Cache _003Cbridge_003Edelegate()
	{
		LoadingCache result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(33)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		LoadingCache result = @delegate();
		_ = null;
		return result;
	}

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
		return Object.instancehelper_equals(this, P_0);
	}
}
