using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.reflect;

[Signature("<B:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMap<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;Lcom/google/common/reflect/TypeToInstanceMap<TB;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/reflect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.reflect.TypeToInstanceMap" })]
public sealed class ImmutableTypeToInstanceMap : ForwardingMap, TypeToInstanceMap, Map
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[Signature("<B:Ljava/lang/Object;>Ljava/lang/Object;")]
	public sealed class Builder : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap$Builder<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;")]
		private ImmutableMap.Builder mapBuilder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(61)]
		internal Builder(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 15, 232, 61, 97, 138 })]
		private Builder()
		{
			mapBuilder = ImmutableMap.builder();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:TB;>(Ljava/lang/Class<TT;>;TT;)Lcom/google/common/reflect/ImmutableTypeToInstanceMap$Builder<TB;>;")]
		[LineNumberTable(new byte[] { 23, 115 })]
		public virtual Builder put(Class key, object value)
		{
			mapBuilder.put(TypeToken.of(key), value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;TT;)Lcom/google/common/reflect/ImmutableTypeToInstanceMap$Builder<TB;>;")]
		[LineNumberTable(new byte[] { 33, 115 })]
		public virtual Builder put(TypeToken key, object value)
		{
			mapBuilder.put(key.rejectTypeVariables(), value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/reflect/ImmutableTypeToInstanceMap<TB;>;")]
		[LineNumberTable(93)]
		public virtual ImmutableTypeToInstanceMap build()
		{
			ImmutableTypeToInstanceMap result = new ImmutableTypeToInstanceMap(mapBuilder.buildOrThrow(), null);
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;")]
	private new ImmutableMap m_delegate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableMap<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;)V")]
	[LineNumberTable(new byte[] { 49, 104, 103 })]
	private ImmutableTypeToInstanceMap(ImmutableMap P_0)
	{
		this.m_delegate = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;)TT;")]
	[LineNumberTable(181)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object trustedGet(TypeToken P_0)
	{
		object result = this.m_delegate.get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/reflect/TypeToken<+TB;>;TB;)TB;")]
	[LineNumberTable(157)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object put(TypeToken key, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Signature("()Ljava/util/Map<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;")]
	protected internal override Map @delegate()
	{
		return this.m_delegate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>()Lcom/google/common/reflect/ImmutableTypeToInstanceMap<TB;>;")]
	[LineNumberTable(37)]
	public static ImmutableTypeToInstanceMap of()
	{
		ImmutableTypeToInstanceMap result = new ImmutableTypeToInstanceMap(ImmutableMap.of());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>()Lcom/google/common/reflect/ImmutableTypeToInstanceMap$Builder<TB;>;")]
	[LineNumberTable(42)]
	public static Builder builder()
	{
		Builder result = new Builder(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;)TT;")]
	[LineNumberTable(106)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object getInstance(TypeToken type)
	{
		object result = trustedGet(type.rejectTypeVariables());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;)TT;")]
	[LineNumberTable(112)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object getInstance(Class type)
	{
		object result = trustedGet(TypeToken.of(type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;TT;)TT;")]
	[LineNumberTable(127)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object putInstance(TypeToken type, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;TT;)TT;")]
	[LineNumberTable(142)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object putInstance(Class type, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/Map<+Lcom/google/common/reflect/TypeToken<+TB;>;+TB;>;)V")]
	[LineNumberTable(170)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void putAll(Map map)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(31)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object put(object obj1, object obj2)
	{
		object result = put((TypeToken)obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(31)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		Map result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(32)]
	internal ImmutableTypeToInstanceMap(ImmutableMap P_0, _1 P_1)
		: this(P_0)
	{
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object putIfAbsent(object P_0, object P_1)
	{
		return Map._003Cdefault_003EputIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object getOrDefault(object P_0, object P_1)
	{
		return Map._003Cdefault_003EgetOrDefault(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		Map._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void replaceAll(BiFunction P_0)
	{
		Map._003Cdefault_003EreplaceAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool remove(object P_0, object P_1)
	{
		return Map._003Cdefault_003Eremove(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool replace(object P_0, object P_1, object P_2)
	{
		return Map._003Cdefault_003Ereplace(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object replace(object P_0, object P_1)
	{
		return Map._003Cdefault_003Ereplace(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object computeIfAbsent(object P_0, Function P_1)
	{
		return Map._003Cdefault_003EcomputeIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object computeIfPresent(object P_0, BiFunction P_1)
	{
		return Map._003Cdefault_003EcomputeIfPresent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object compute(object P_0, BiFunction P_1)
	{
		return Map._003Cdefault_003Ecompute(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override object merge(object P_0, object P_1, BiFunction P_2)
	{
		return Map._003Cdefault_003Emerge(this, P_0, P_1, P_2);
	}
}
