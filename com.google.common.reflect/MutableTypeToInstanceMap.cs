using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
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
public sealed class MutableTypeToInstanceMap : ForwardingMap, TypeToInstanceMap, Map
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMapEntry<TK;TV;>;")]
	internal sealed class UnmodifiableEntry : ForwardingMapEntry
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/ForwardingSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[EnclosingMethod(null, "transformEntries", "(Ljava.util.Set;)Ljava.util.Set;")]
		[ConstantPool(new object[]
		{
			(byte)41,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal class _1 : ForwardingSet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Set val_0024entries;

			[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
			protected internal override Set @delegate()
			{
				return val_0024entries;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(128)]
			internal _1(Set P_0)
			{
				val_0024entries = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(136)]
			public override Iterator iterator()
			{
				Iterator result = access_0024000(base.iterator());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 98, 103 })]
			public override object[] toArray()
			{
				return standardToArray();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 41, 0, 0 })]
			[LineNumberTable(155)]
			public override object[] toArray(object[] P_0)
			{
				object[] result = standardToArray(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(128)]
			protected internal new virtual Collection @delegate()
			{
				Set result = this.@delegate();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(128)]
			protected internal new virtual object @delegate()
			{
				Set result = this.@delegate();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
		{
			internal ___003C_003EAnon0()
			{
			}

			public object apply(object P_0)
			{
				Map.Entry result = new UnmodifiableEntry((Map.Entry)P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public bool equals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}

			[SpecialName]
			public java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[SpecialName]
			public java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Map$Entry<TK;TV;>;")]
		private new Map.Entry m_delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(123)]
		internal static Iterator access_0024000(Iterator P_0)
		{
			Iterator result = transformEntries(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(161)]
		private static Iterator transformEntries(Iterator P_0)
		{
			Iterator result = Iterators.transform(P_0, new ___003C_003EAnon0());
			_ = null;
			return result;
		}

		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		protected internal override Map.Entry @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 114, 104, 113 })]
		private UnmodifiableEntry(Map.Entry P_0)
		{
			this.m_delegate = (Map.Entry)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(128)]
		internal static Set transformEntries(Set P_0)
		{
			_1 result = new _1(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(175)]
		public override object setValue(object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(123)]
		protected internal new virtual object @delegate()
		{
			Map.Entry result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;")]
	private Map backingMap;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;)TT;")]
	[LineNumberTable(120)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object trustedGet(TypeToken P_0)
	{
		object result = backingMap.get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;TT;)TT;")]
	[LineNumberTable(114)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object trustedPut(TypeToken P_0, object P_1)
	{
		object result = backingMap.put(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/reflect/TypeToken<+TB;>;TB;)TB;")]
	[LineNumberTable(85)]
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
		throw new UnsupportedOperationException("Please use putInstance() instead.");
	}

	[Signature("()Ljava/util/Map<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;")]
	protected internal override Map @delegate()
	{
		return backingMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 184, 168 })]
	public MutableTypeToInstanceMap()
	{
		backingMap = Maps.newHashMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;)TT;")]
	[LineNumberTable(50)]
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
	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;)TT;")]
	[LineNumberTable(56)]
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
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;TT;)TT;")]
	[LineNumberTable(63)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object putInstance(Class type, object value)
	{
		object result = trustedPut(TypeToken.of(type), value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Lcom/google/common/reflect/TypeToken<TT;>;TT;)TT;")]
	[LineNumberTable(70)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object putInstance(TypeToken type, object value)
	{
		object result = trustedPut(type.rejectTypeVariables(), value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/Map<+Lcom/google/common/reflect/TypeToken<+TB;>;+TB;>;)V")]
	[LineNumberTable(98)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void putAll(Map map)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException("Please use putInstance() instead.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<Lcom/google/common/reflect/TypeToken<+TB;>;TB;>;>;")]
	[LineNumberTable(103)]
	public override Set entrySet()
	{
		Set result = UnmodifiableEntry.transformEntries(base.entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(41)]
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
	[LineNumberTable(41)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		Map result = @delegate();
		_ = null;
		return result;
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
	public override object computeIfAbsent(object P_0, java.util.function.Function P_1)
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
