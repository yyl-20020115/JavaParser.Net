using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
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
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.ClassToInstanceMap", "java.io.Serializable" })]
public sealed class MutableClassToInstanceMap : ForwardingMap, ClassToInstanceMap, Map, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/ForwardingMapEntry<Ljava/lang/Class<+TB;>;TB;>;")]
	[EnclosingMethod(null, "checkedEntry", "(Ljava.util.Map$Entry;)Ljava.util.Map$Entry;")]
	internal class _1 : ForwardingMapEntry
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Map.Entry val_0024entry;

		[Signature("()Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;")]
		protected internal override Map.Entry @delegate()
		{
			return val_0024entry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(87)]
		internal _1(Map.Entry P_0)
		{
			val_0024entry = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TB;)TB;")]
		[LineNumberTable(95)]
		public override object setValue(object P_0)
		{
			object result = base.setValue(access_0024000((Class)getKey(), P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(87)]
		protected internal new virtual object @delegate()
		{
			Map.Entry result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/ForwardingSet<Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;>;")]
	[EnclosingMethod(null, "entrySet", "()Ljava.util.Set;")]
	[ConstantPool(new object[]
	{
		(byte)49,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _2 : ForwardingSet
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/TransformedIterator<Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : TransformedIterator
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;)Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;")]
			[LineNumberTable(121)]
			internal virtual Map.Entry transform(Map.Entry P_0)
			{
				Map.Entry result = access_0024100(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(118)]
			internal _1(_2 P_0, Iterator P_1)
				: base(P_1)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(118)]
			internal override object transform(object P_0)
			{
				Map.Entry result = transform((Map.Entry)P_0);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Function
		{
			internal ___003C_003EAnon0()
			{
			}

			public object apply(object P_0)
			{
				Map.Entry result = lambda_0024spliterator_00240((Map.Entry)P_0);
				_ = null;
				return result;
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

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal MutableClassToInstanceMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(102)]
		internal _2(MutableClassToInstanceMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;>;")]
		[LineNumberTable(106)]
		protected internal override Set @delegate()
		{
			Set result = this_00240.@delegate().entrySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(112)]
		private static Map.Entry lambda_0024spliterator_00240(Map.Entry P_0)
		{
			Map.Entry result = access_0024100(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;>;")]
		[LineNumberTable(new byte[] { 61, 97, 52 })]
		public override Spliterator spliterator()
		{
			Spliterator result = CollectSpliterators.map(this.@delegate().spliterator(), new ___003C_003EAnon0());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;>;")]
		[LineNumberTable(new byte[] { 67, 98, 49 })]
		public override Iterator iterator()
		{
			_1 result = new _1(this, this.@delegate().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 85, 103 })]
		public override object[] toArray()
		{
			return standardToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 49, 0, 0 })]
		[LineNumberTable(142)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = standardToArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(102)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(102)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<B:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Map<Ljava/lang/Class<+TB;>;TB;>;")]
		private Map backingMap;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<Ljava/lang/Class<+TB;>;TB;>;)V")]
		[LineNumberTable(new byte[] { 160, 76, 104, 103 })]
		internal SerializedForm(Map P_0)
		{
			backingMap = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(195)]
		internal virtual object readResolve()
		{
			MutableClassToInstanceMap result = create(backingMap);
			_ = null;
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
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
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

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<Ljava/lang/Class<+TB;>;TB;>;")]
	private new Map m_delegate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static object access_0024000(Class P_0, object P_1)
	{
		object result = cast(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>(Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;)Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;")]
	[LineNumberTable(87)]
	private static Map.Entry checkedEntry(Map.Entry P_0)
	{
		_1 result = new _1(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;T:TB;>(Ljava/lang/Class<TT;>;TB;)TT;")]
	[LineNumberTable(179)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static object cast(Class P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		object result = Primitives.wrap(P_0).cast(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<Ljava/lang/Class<+TB;>;TB;>;)V")]
	[LineNumberTable(new byte[] { 23, 104, 113 })]
	private MutableClassToInstanceMap(Map P_0)
	{
		this.m_delegate = (Map)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<+TB;>;TB;)TB;")]
	[LineNumberTable(151)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object put(Class key, object value)
	{
		object result = base.put(key, cast(key, value));
		_ = null;
		return result;
	}

	[Signature("()Ljava/util/Map<Ljava/lang/Class<+TB;>;TB;>;")]
	protected internal override Map @delegate()
	{
		return this.m_delegate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>()Lcom/google/common/collect/MutableClassToInstanceMap<TB;>;")]
	[LineNumberTable(59)]
	public static MutableClassToInstanceMap create()
	{
		MutableClassToInstanceMap result = new MutableClassToInstanceMap(new HashMap());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>(Ljava/util/Map<Ljava/lang/Class<+TB;>;TB;>;)Lcom/google/common/collect/MutableClassToInstanceMap<TB;>;")]
	[LineNumberTable(68)]
	public static MutableClassToInstanceMap create(Map backingMap)
	{
		MutableClassToInstanceMap result = new MutableClassToInstanceMap(backingMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<Ljava/lang/Class<+TB;>;TB;>;>;")]
	[LineNumberTable(102)]
	public override Set entrySet()
	{
		_2 result = new _2(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+Ljava/lang/Class<+TB;>;+TB;>;)V")]
	[LineNumberTable(new byte[] { 106, 103, 127, 1, 119, 98, 105 })]
	public override void putAll(Map map)
	{
		LinkedHashMap linkedHashMap = new LinkedHashMap(map);
		Iterator iterator = ((Map)linkedHashMap).entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			cast((Class)entry.getKey(), entry.getValue());
		}
		base.putAll(linkedHashMap);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;TT;)TT;")]
	[LineNumberTable(167)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object putInstance(Class type, object value)
	{
		object result = cast(type, put(type, value));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:TB;>(Ljava/lang/Class<TT;>;)TT;")]
	[LineNumberTable(173)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object getInstance(Class type)
	{
		object result = cast(type, base.get(type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(183)]
	private object writeReplace()
	{
		SerializedForm result = new SerializedForm(@delegate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object put(object obj1, object obj2)
	{
		object result = put((Class)obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		Map result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal static Map.Entry access_0024100(Map.Entry P_0)
	{
		Map.Entry result = checkedEntry(P_0);
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

	[HideFromJava]
	public static implicit operator Serializable(MutableClassToInstanceMap P_0)
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
	protected MutableClassToInstanceMap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
