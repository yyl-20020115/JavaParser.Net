using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<B:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMap<Ljava/lang/Class<+TB;>;TB;>;Lcom/google/common/collect/ClassToInstanceMap<TB;>;Ljava/io/Serializable;")]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;",
	"containerOf",
	new object[]
	{
		(byte)91,
		"B"
	}
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.ClassToInstanceMap", "java.io.Serializable" })]
public sealed class ImmutableClassToInstanceMap : ForwardingMap, ClassToInstanceMap, Map, Serializable.__Interface, ISerializable, IObjectReference
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
		[Signature("Lcom/google/common/collect/ImmutableMap$Builder<Ljava/lang/Class<+TB;>;TB;>;")]
		private ImmutableMap.Builder mapBuilder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 43, 104 })]
		public Builder()
		{
			mapBuilder = ImmutableMap.builder();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:TB;>(Ljava/util/Map<+Ljava/lang/Class<+TT;>;+TT;>;)Lcom/google/common/collect/ImmutableClassToInstanceMap$Builder<TB;>;")]
		[LineNumberTable(new byte[] { 65, 127, 1, 108, 103, 116, 98 })]
		public virtual Builder putAll(Map map)
		{
			Iterator iterator = map.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				Class @class = (Class)entry.getKey();
				object value = entry.getValue();
				mapBuilder.put(@class, cast(@class, value));
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableClassToInstanceMap<TB;>;")]
		[LineNumberTable(new byte[] { 84, 108, 104, 136 })]
		public virtual ImmutableClassToInstanceMap build()
		{
			ImmutableMap immutableMap = mapBuilder.buildOrThrow();
			if (immutableMap.isEmpty())
			{
				ImmutableClassToInstanceMap result = of();
				_ = null;
				return result;
			}
			ImmutableClassToInstanceMap result2 = new ImmutableClassToInstanceMap(immutableMap, null);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<B:Ljava/lang/Object;T:TB;>(Ljava/lang/Class<TT;>;TB;)TT;")]
		[LineNumberTable(124)]
		private static object cast(Class P_0, object P_1)
		{
			object result = Primitives.wrap(P_0).cast(P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:TB;>(Ljava/lang/Class<TT;>;TT;)Lcom/google/common/collect/ImmutableClassToInstanceMap$Builder<TB;>;")]
		[LineNumberTable(new byte[] { 52, 110 })]
		public virtual Builder put(Class key, object value)
		{
			mapBuilder.put(key, value);
			return this;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableClassToInstanceMap<Ljava/lang/Object;>;")]
	private static ImmutableClassToInstanceMap EMPTY;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<Ljava/lang/Class<+TB;>;TB;>;")]
	private new ImmutableMap m_delegate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableMap<Ljava/lang/Class<+TB;>;TB;>;)V")]
	[LineNumberTable(new byte[] { 116, 104, 103 })]
	private ImmutableClassToInstanceMap(ImmutableMap P_0)
	{
		this.m_delegate = P_0;
	}

	[Signature("<B:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableClassToInstanceMap<TB;>;")]
	public static ImmutableClassToInstanceMap of()
	{
		return EMPTY;
	}

	[Signature("()Ljava/util/Map<Ljava/lang/Class<+TB;>;TB;>;")]
	protected internal override Map @delegate()
	{
		return this.m_delegate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;T:TB;>(Ljava/lang/Class<TT;>;TT;)Lcom/google/common/collect/ImmutableClassToInstanceMap<TB;>;")]
	[LineNumberTable(new byte[] { 14, 104 })]
	public static ImmutableClassToInstanceMap of(Class type, object value)
	{
		ImmutableMap immutableMap = ImmutableMap.of(type, value);
		ImmutableClassToInstanceMap result = new ImmutableClassToInstanceMap(immutableMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableClassToInstanceMap$Builder<TB;>;")]
	[LineNumberTable(73)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;S:TB;>(Ljava/util/Map<+Ljava/lang/Class<+TS;>;+TS;>;)Lcom/google/common/collect/ImmutableClassToInstanceMap<TB;>;")]
	[LineNumberTable(new byte[] { 106, 136, 103, 130 })]
	public static ImmutableClassToInstanceMap copyOf(Map map)
	{
		if (map is ImmutableClassToInstanceMap)
		{
			return (ImmutableClassToInstanceMap)map;
		}
		ImmutableClassToInstanceMap result = new Builder().putAll(map).build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;)TT;")]
	[LineNumberTable(179)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object getInstance(Class type)
	{
		object result = this.m_delegate.get(Preconditions.checkNotNull(type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;TT;)TT;")]
	[LineNumberTable(194)]
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
	[LineNumberTable(198)]
	internal virtual object readResolve()
	{
		return (!base.isEmpty()) ? this : of();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(37)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		Map result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(40)]
	internal ImmutableClassToInstanceMap(ImmutableMap P_0, _1 P_1)
		: this(P_0)
	{
	}

	[LineNumberTable(new byte[] { 159, 186, 47 })]
	static ImmutableClassToInstanceMap()
	{
		EMPTY = new ImmutableClassToInstanceMap(ImmutableMap.of());
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

	[HideFromJava]
	public static implicit operator Serializable(ImmutableClassToInstanceMap P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableClassToInstanceMap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}

	[SecurityCritical]
	[HideFromJava]
	object IObjectReference.GetRealObject(StreamingContext P_0)
	{
		return readResolve();
	}
}
