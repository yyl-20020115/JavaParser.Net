using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)104,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class Synchronized : java.lang.Object
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedMap<TK;Ljava/util/Collection<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 78, 0, 0,
		17, 1, 0, 0, 0, 78, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)78,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class SynchronizedAsMap : SynchronizedMap
	{
		[NonSerialized]
		[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Set asMapEntrySet;

		[NonSerialized]
		[Signature("Ljava/util/Collection<Ljava/util/Collection<TV;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Collection asMapValues;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 34, 109, 104, 156, 108 })]
		public override Collection values()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (asMapValues == null)
				{
					asMapValues = new SynchronizedAsMapValues(@delegate().values(), mutex);
				}
				return asMapValues;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 165, 16, 109, 109, 120 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Collection get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_002e
			lock (mutex)
			{
				Collection collection = (Collection)base.get(P_0);
				return (collection != null) ? access_0024400(collection, mutex) : null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 165, 10, 106 })]
		internal SynchronizedAsMap(Map P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		[LineNumberTable(new byte[] { 165, 24, 109, 104, 156, 108 })]
		public override Set entrySet()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (asMapEntrySet == null)
				{
					asMapEntrySet = new SynchronizedAsMapEntries(@delegate().entrySet(), mutex);
				}
				return asMapEntrySet;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1439)]
		public override bool containsValue([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = values().contains(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1398)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Collection result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedAsMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedSet<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 61, 0, 0,
		17, 1, 0, 0, 0, 61, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)61,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class SynchronizedAsMapEntries : SynchronizedSet
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/TransformedIterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : TransformedIterator
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/ForwardingMapEntry<TK;Ljava/util/Collection<TV;>;>;")]
			[EnclosingMethod(null, "transform", "(Ljava.util.Map$Entry;)Ljava.util.Map$Entry;")]
			internal class _1 : ForwardingMapEntry
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal Map.Entry val_0024entry;

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal SynchronizedAsMapEntries._1 this_00241;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()Ljava/util/Collection<TV;>;")]
				[LineNumberTable(979)]
				public new virtual Collection getValue()
				{
					Collection result = access_0024400((Collection)val_0024entry.getValue(), this_00241.this_00240.mutex);
					_ = null;
					return result;
				}

				[Signature("()Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
				protected internal override Map.Entry @delegate()
				{
					return val_0024entry;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(971)]
				internal _1(SynchronizedAsMapEntries._1 P_0, Map.Entry P_1)
				{
					this_00241 = P_0;
					val_0024entry = P_1;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(971)]
				public override object getValue()
				{
					Collection value = getValue();
					_ = null;
					return value;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(971)]
				protected internal new virtual object @delegate()
				{
					Map.Entry result = this.@delegate();
					_ = null;
					return result;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal SynchronizedAsMapEntries this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;)Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
			[LineNumberTable(971)]
			internal virtual Map.Entry transform(Map.Entry P_0)
			{
				_1 result = new _1(this, P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(968)]
			internal _1(SynchronizedAsMapEntries P_0, Iterator P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(968)]
			internal override object transform(object P_0)
			{
				Map.Entry result = transform((Map.Entry)P_0);
				_ = null;
				return result;
			}
		}

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Set<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 163, 79, 106 })]
		internal SynchronizedAsMapEntries(Set P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		[LineNumberTable(new byte[] { 163, 85, 98, 44 })]
		public override Iterator iterator()
		{
			_1 result = new _1(this, base.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 108, 237, 71, 108, 103 })]
		public override object[] toArray()
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return ObjectArrays.toArrayImpl(@delegate());
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 61, 0, 0 })]
		[LineNumberTable(new byte[] { 163, 123, 109, 114 })]
		public override object[] toArray(object[] P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return ObjectArrays.toArrayImpl(@delegate(), P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 130, 109, 114 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return Maps.containsEntryImpl(@delegate(), P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 163, 137, 109, 114 })]
		public override bool containsAll(Collection P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return Collections2.containsAllImpl(@delegate(), P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 144, 100, 130, 109, 114 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0021
			if (P_0 == this)
			{
				return true;
			}
			lock (mutex)
			{
				return Sets.equalsImpl(@delegate(), P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 154, 109, 114 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return Maps.removeEntryImpl(@delegate(), P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 163, 161, 109, 119 })]
		public override bool removeAll(Collection P_0)
		{
			//Discarded unreachable code: IL_0020
			lock (mutex)
			{
				return Iterators.removeAll(@delegate().iterator(), P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 163, 168, 109, 119 })]
		public override bool retainAll(Collection P_0)
		{
			//Discarded unreachable code: IL_0020
			lock (mutex)
			{
				return Iterators.retainAll(@delegate().iterator(), P_0);
			}
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedAsMapEntries(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedCollection<Ljava/util/Collection<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 40, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)40,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class SynchronizedAsMapValues : SynchronizedCollection
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/TransformedIterator<Ljava/util/Collection<TV;>;Ljava/util/Collection<TV;>;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : TransformedIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal SynchronizedAsMapValues this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<TV;>;)Ljava/util/Collection<TV;>;")]
			[LineNumberTable(1457)]
			internal virtual Collection transform(Collection P_0)
			{
				Collection result = access_0024400(P_0, this_00240.mutex);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1454)]
			internal _1(SynchronizedAsMapValues P_0, Iterator P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1454)]
			internal override object transform(object P_0)
			{
				Collection result = transform((Collection)P_0);
				_ = null;
				return result;
			}
		}

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<Ljava/util/Collection<TV;>;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 165, 54, 107 })]
		internal SynchronizedAsMapValues(Collection P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1454)]
		public override Iterator iterator()
		{
			_1 result = new _1(this, base.iterator());
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedAsMapValues(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedMap<TK;TV;>;Lcom/google/common/collect/BiMap<TK;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 82, 0, 0,
		17, 1, 0, 0, 0, 82, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)82,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.BiMap", "java.io.Serializable" })]
	internal class SynchronizedBiMap : SynchronizedMap, BiMap, Map, Serializable.__Interface
	{
		[NonSerialized]
		[Signature("Ljava/util/Set<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Set valueSet;

		[NonSerialized]
		[Signature("Lcom/google/common/collect/BiMap<TV;TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private BiMap m_inverse;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1351)]
		internal SynchronizedBiMap(BiMap P_0, object P_1, BiMap P_2, _1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BiMap<TK;TV;>;Ljava/lang/Object;Lcom/google/common/collect/BiMap<TV;TK;>;)V")]
		[LineNumberTable(new byte[] { 164, 220, 106, 103 })]
		private SynchronizedBiMap(BiMap P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] BiMap P_2)
			: base(P_0, P_1)
		{
			this.m_inverse = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/BiMap<TK;TV;>;")]
		[LineNumberTable(1364)]
		internal new virtual BiMap @delegate()
		{
			return (BiMap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(new byte[] { 164, 231, 109, 104, 156, 108 })]
		public new virtual Set values()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (valueSet == null)
				{
					valueSet = set(@delegate().values(), mutex);
				}
				return valueSet;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(new byte[] { 164, 242, 109, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object forcePut(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().forcePut(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/BiMap<TV;TK;>;")]
		[LineNumberTable(new byte[] { 164, 249, 109, 104, 157, 108 })]
		public virtual BiMap inverse()
		{
			//Discarded unreachable code: IL_003a
			lock (mutex)
			{
				if (this.m_inverse == null)
				{
					this.m_inverse = new SynchronizedBiMap(@delegate().inverse(), mutex, this);
				}
				return this.m_inverse;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1350)]
		public override Collection values()
		{
			Set result = values();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1350)]
		internal override Map @delegate()
		{
			BiMap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1350)]
		internal override object @delegate()
		{
			BiMap result = @delegate();
			_ = null;
			return result;
		}

		Collection BiMap.BiMap_003A_003Avalues()
		{
			return this.values();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedBiMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedObject;Ljava/util/Collection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 108, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)108,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Collection" })]
	internal class SynchronizedCollection : SynchronizedObject, Collection, Iterable, IEnumerable
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(123)]
		internal SynchronizedCollection(Collection P_0, object P_1, _1 P_2)
			: this(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 76, 106 })]
		private SynchronizedCollection(Collection P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TE;>;")]
		[LineNumberTable(132)]
		internal new virtual Collection @delegate()
		{
			return (Collection)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(new byte[] { 87, 109, 114 })]
		public virtual bool add(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().add(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(new byte[] { 94, 109, 114 })]
		public virtual bool addAll(Collection P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().addAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 101, 109, 107, 111 })]
		public virtual void clear()
		{
			lock (mutex)
			{
				@delegate().clear();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 108, 109, 114 })]
		public virtual bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().contains(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 115, 109, 114 })]
		public virtual bool containsAll(Collection P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().containsAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 122, 109, 113 })]
		public virtual bool isEmpty()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().isEmpty();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(179)]
		public virtual Iterator iterator()
		{
			Iterator result = @delegate().iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TE;>;")]
		[LineNumberTable(new byte[] { 160, 70, 109, 113 })]
		public virtual Spliterator spliterator()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().spliterator();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(new byte[] { 160, 77, 109, 113 })]
		public virtual Stream stream()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().stream();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(new byte[] { 160, 84, 109, 113 })]
		public virtual Stream parallelStream()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().parallelStream();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
		[LineNumberTable(new byte[] { 160, 91, 109, 108, 111 })]
		public virtual void forEach(Consumer P_0)
		{
			lock (mutex)
			{
				@delegate().forEach(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 98, 109, 114 })]
		public virtual bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().remove(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 160, 105, 109, 114 })]
		public virtual bool removeAll(Collection P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().removeAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 160, 112, 109, 114 })]
		public virtual bool retainAll(Collection P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().retainAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Predicate<-TE;>;)Z")]
		[LineNumberTable(new byte[] { 160, 119, 109, 114 })]
		public virtual bool removeIf(java.util.function.Predicate P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().removeIf(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 126, 109, 113 })]
		public virtual int size()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().size();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 108, 0, 0 })]
		[LineNumberTable(new byte[] { 160, 133, 109, 113 })]
		public virtual object[] toArray()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().toArray();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 108, 0, 0 })]
		[LineNumberTable(new byte[] { 160, 141, 109, 114 })]
		public virtual object[] toArray(object[] P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().toArray(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(122)]
		internal override object @delegate()
		{
			Collection result = @delegate();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Collection.Collection_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		int Collection.Collection_003A_003AhashCode()
		{
			return java.lang.Object.instancehelper_hashCode(this);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedCollection(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedQueue<TE;>;Ljava/util/Deque<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 91, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)91,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Deque" })]
	internal sealed class SynchronizedDeque : SynchronizedQueue, Deque, java.util.Queue, Collection, Iterable, IEnumerable
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Deque<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 167, 21, 106 })]
		internal SynchronizedDeque(Deque P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Deque<TE;>;")]
		[LineNumberTable(1932)]
		internal new virtual Deque @delegate()
		{
			return (Deque)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)V")]
		[LineNumberTable(new byte[] { 167, 31, 109, 108, 111 })]
		public virtual void addFirst(object P_0)
		{
			lock (mutex)
			{
				@delegate().addFirst(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)V")]
		[LineNumberTable(new byte[] { 167, 38, 109, 108, 111 })]
		public virtual void addLast(object P_0)
		{
			lock (mutex)
			{
				@delegate().addLast(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(new byte[] { 167, 45, 109, 114 })]
		public virtual bool offerFirst(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().offerFirst(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(new byte[] { 167, 52, 109, 114 })]
		public virtual bool offerLast(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().offerLast(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 59, 109, 113 })]
		public virtual object removeFirst()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().removeFirst();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 66, 109, 113 })]
		public virtual object removeLast()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().removeLast();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 74, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollFirst()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().pollFirst();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 82, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollLast()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().pollLast();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 89, 109, 113 })]
		public virtual object getFirst()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().getFirst();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 96, 109, 113 })]
		public virtual object getLast()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().getLast();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 104, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object peekFirst()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().peekFirst();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 112, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object peekLast()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().peekLast();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 119, 109, 114 })]
		public virtual bool removeFirstOccurrence([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().removeFirstOccurrence(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 126, 109, 114 })]
		public virtual bool removeLastOccurrence([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().removeLastOccurrence(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)V")]
		[LineNumberTable(new byte[] { 167, 133, 109, 108, 111 })]
		public virtual void push(object P_0)
		{
			lock (mutex)
			{
				@delegate().push(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 140, 109, 113 })]
		public virtual object pop()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().pop();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(new byte[] { 167, 147, 109, 113 })]
		public virtual Iterator descendingIterator()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().descendingIterator();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1923)]
		internal override java.util.Queue @delegate()
		{
			Deque result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1923)]
		internal override Collection @delegate()
		{
			Deque result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1923)]
		internal override object @delegate()
		{
			Deque result = @delegate();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Collection.Collection_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		int Collection.Collection_003A_003AhashCode()
		{
			return java.lang.Object.instancehelper_hashCode(this);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedDeque(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedObject;Ljava/util/Map$Entry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 66, 0, 0,
		17, 1, 0, 0, 0, 66, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)66,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Map$Entry" })]
	internal class SynchronizedEntry : SynchronizedObject, Map.Entry
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 166, 166, 106 })]
		internal SynchronizedEntry(Map.Entry P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(1822)]
		internal new virtual Map.Entry @delegate()
		{
			return (Map.Entry)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 177, 109, 114 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().equals(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 184, 109, 113 })]
		public override int hashCode()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().hashCode();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(new byte[] { 166, 191, 109, 113 })]
		public virtual object getKey()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().getKey();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(new byte[] { 166, 198, 109, 113 })]
		public virtual object getValue()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().getValue();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(new byte[] { 166, 205, 109, 114 })]
		public virtual object setValue(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().setValue(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1811)]
		internal override object @delegate()
		{
			Map.Entry result = @delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedEntry(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedCollection<TE;>;Ljava/util/List<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 112, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)112,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.List" })]
	internal class SynchronizedList : SynchronizedCollection, List, Collection, Iterable, IEnumerable
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 161, 2, 107 })]
		internal SynchronizedList(List P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<TE;>;")]
		[LineNumberTable(377)]
		internal new virtual List @delegate()
		{
			return (List)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITE;)V")]
		[LineNumberTable(new byte[] { 161, 12, 109, 109, 111 })]
		public virtual void add(int P_0, object P_1)
		{
			lock (mutex)
			{
				@delegate().add(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILjava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(new byte[] { 161, 19, 109, 115 })]
		public virtual bool addAll(int P_0, Collection P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().addAll(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(new byte[] { 161, 26, 109, 114 })]
		public virtual object get(int P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().get(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 33, 109, 114 })]
		public virtual int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().indexOf(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 40, 109, 114 })]
		public virtual int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().lastIndexOf(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/ListIterator<TE;>;")]
		[LineNumberTable(417)]
		public virtual ListIterator listIterator()
		{
			ListIterator result = @delegate().listIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TE;>;")]
		[LineNumberTable(422)]
		public virtual ListIterator listIterator(int P_0)
		{
			ListIterator result = @delegate().listIterator(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(new byte[] { 161, 57, 109, 114 })]
		public virtual object remove(int P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().remove(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITE;)TE;")]
		[LineNumberTable(new byte[] { 161, 64, 109, 115 })]
		public virtual object set(int P_0, object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().set(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/UnaryOperator<TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 71, 109, 108, 111 })]
		public virtual void replaceAll(UnaryOperator P_0)
		{
			lock (mutex)
			{
				@delegate().replaceAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 78, 109, 108, 111 })]
		public virtual void sort(Comparator P_0)
		{
			lock (mutex)
			{
				@delegate().sort(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<TE;>;")]
		[LineNumberTable(new byte[] { 161, 85, 109, 126 })]
		public virtual List subList(int P_0, int P_1)
		{
			//Discarded unreachable code: IL_0027
			lock (mutex)
			{
				return access_0024200(@delegate().subList(P_0, P_1), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 92, 100, 130, 109, 114 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0021
			if (P_0 == this)
			{
				return true;
			}
			lock (mutex)
			{
				return @delegate().equals(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 102, 109, 113 })]
		public override int hashCode()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().hashCode();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(369)]
		internal override Collection @delegate()
		{
			List result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(369)]
		internal override object @delegate()
		{
			List result = @delegate();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedList(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedMultimap<TK;TV;>;Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 68, 0, 0,
		17, 1, 0, 0, 0, 68, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)68,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.ListMultimap" })]
	internal class SynchronizedListMultimap : SynchronizedMultimap, ListMultimap, Multimap
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ListMultimap<TK;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 162, 166, 106 })]
		internal SynchronizedListMultimap(ListMultimap P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
		[LineNumberTable(797)]
		internal new virtual ListMultimap @delegate()
		{
			return (ListMultimap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/List<TV;>;")]
		[LineNumberTable(new byte[] { 162, 183, 109, 114 })]
		public new virtual List removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().removeAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/List<TV;>;")]
		[LineNumberTable(new byte[] { 162, 190, 109, 115 })]
		public new virtual List replaceValues(object P_0, Iterable P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().replaceValues(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/List<TV;>;")]
		[LineNumberTable(new byte[] { 162, 176, 109, 125 })]
		public new virtual List get(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024200(@delegate().get(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(788)]
		public override Collection removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			List result = removeAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(788)]
		public override Collection replaceValues(object P_0, Iterable P_1)
		{
			List result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(788)]
		public override Collection get(object P_0)
		{
			List result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(788)]
		internal override Multimap @delegate()
		{
			ListMultimap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(788)]
		internal override object @delegate()
		{
			ListMultimap result = @delegate();
			_ = null;
			return result;
		}

		Collection ListMultimap.ListMultimap_003A_003Aget(object P_0)
		{
			return this.get(P_0);
		}

		Collection ListMultimap.ListMultimap_003A_003AremoveAll(object P_0)
		{
			return this.removeAll(P_0);
		}

		Collection ListMultimap.ListMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
		{
			return this.replaceValues(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedListMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedObject;Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 131, 0, 0,
		17, 1, 0, 0, 0, 131, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)131,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Map" })]
	internal class SynchronizedMap : SynchronizedObject, Map
	{
		[NonSerialized]
		[Signature("Ljava/util/Set<TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Set keySet;

		[NonSerialized]
		[Signature("Ljava/util/Collection<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Collection values;

		[NonSerialized]
		[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Set entrySet;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 163, 189, 106 })]
		internal SynchronizedMap(Map P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;TV;>;")]
		[LineNumberTable(1077)]
		internal new virtual Map @delegate()
		{
			return (Map)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 200, 109, 107, 111 })]
		public virtual void clear()
		{
			lock (mutex)
			{
				@delegate().clear();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 207, 109, 114 })]
		public virtual bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().containsKey(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 214, 109, 114 })]
		public virtual bool containsValue([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().containsValue(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 163, 221, 109, 104, 156, 108 })]
		public virtual Set entrySet()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.entrySet == null)
				{
					this.entrySet = set(@delegate().entrySet(), mutex);
				}
				return this.entrySet;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 231, 109, 108, 111 })]
		public virtual void forEach(BiConsumer P_0)
		{
			lock (mutex)
			{
				@delegate().forEach(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 163, 239, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().get(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;TV;)TV;")]
		[LineNumberTable(new byte[] { 163, 247, 109, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object getOrDefault([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().getOrDefault(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 254, 109, 113 })]
		public virtual bool isEmpty()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().isEmpty();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(new byte[] { 164, 5, 109, 104, 156, 108 })]
		public virtual Set keySet()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.keySet == null)
				{
					this.keySet = set(@delegate().keySet(), mutex);
				}
				return this.keySet;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(new byte[] { 164, 16, 109, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object put(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().put(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(new byte[] { 164, 24, 109, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object putIfAbsent(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().putIfAbsent(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;TV;)Z")]
		[LineNumberTable(new byte[] { 164, 31, 109, 116 })]
		public virtual bool replace(object P_0, object P_1, object P_2)
		{
			//Discarded unreachable code: IL_001d
			lock (mutex)
			{
				return @delegate().replace(P_0, P_1, P_2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(new byte[] { 164, 39, 109, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object replace(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().replace(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/Function<-TK;+TV;>;)TV;")]
		[LineNumberTable(new byte[] { 164, 46, 109, 115 })]
		public virtual object computeIfAbsent(object P_0, java.util.function.Function P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().computeIfAbsent(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
		[LineNumberTable(new byte[] { 164, 54, 109, 115 })]
		public virtual object computeIfPresent(object P_0, BiFunction P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().computeIfPresent(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 1, 2, 3, 1, 2, 0, 0,
			131, 0, 0
		})]
		[LineNumberTable(new byte[] { 164, 62, 109, 115 })]
		public virtual object compute(object P_0, BiFunction P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().compute(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)TV;")]
		[LineNumberTable(new byte[] { 164, 70, 109, 116 })]
		public virtual object merge(object P_0, object P_1, BiFunction P_2)
		{
			//Discarded unreachable code: IL_001d
			lock (mutex)
			{
				return @delegate().merge(P_0, P_1, P_2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
		[LineNumberTable(new byte[] { 164, 77, 109, 108, 111 })]
		public virtual void putAll(Map P_0)
		{
			lock (mutex)
			{
				@delegate().putAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
		[LineNumberTable(new byte[] { 164, 84, 109, 108, 111 })]
		public virtual void replaceAll(BiFunction P_0)
		{
			lock (mutex)
			{
				@delegate().replaceAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 164, 92, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().remove(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 99, 109, 115 })]
		public virtual bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().remove(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 106, 109, 113 })]
		public virtual int size()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().size();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 164, 113, 109, 104, 156, 108 })]
		public virtual Collection values()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.values == null)
				{
					this.values = access_0024500(@delegate().values(), mutex);
				}
				return this.values;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 123, 100, 130, 109, 114 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0021
			if (P_0 == this)
			{
				return true;
			}
			lock (mutex)
			{
				return @delegate().equals(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 133, 109, 113 })]
		public override int hashCode()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().hashCode();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1064)]
		internal override object @delegate()
		{
			Map result = @delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedObject;Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 149, 0, 0,
		17, 1, 0, 0, 0, 149, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)149,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.Multimap" })]
	internal class SynchronizedMultimap : SynchronizedObject, Multimap
	{
		[NonSerialized]
		[Signature("Ljava/util/Set<TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Set keySet;

		[NonSerialized]
		[Signature("Ljava/util/Collection<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Collection valuesCollection;

		[NonSerialized]
		[Signature("Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Collection entries;

		[NonSerialized]
		[Signature("Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Map asMap;

		[NonSerialized]
		[Signature("Lcom/google/common/collect/Multiset<TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Multiset keys;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<TK;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 161, 239, 106 })]
		internal SynchronizedMultimap(Multimap P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multimap<TK;TV;>;")]
		[LineNumberTable(605)]
		internal new virtual Multimap @delegate()
		{
			return (Multimap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 244, 109, 113 })]
		public virtual int size()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().size();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 251, 109, 113 })]
		public virtual bool isEmpty()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().isEmpty();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 2, 109, 114 })]
		public virtual bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().containsKey(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 9, 109, 114 })]
		public virtual bool containsValue([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().containsValue(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 16, 109, 115 })]
		public virtual bool containsEntry([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().containsEntry(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 162, 23, 109, 125 })]
		public virtual Collection get(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024400(@delegate().get(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Z")]
		[LineNumberTable(new byte[] { 162, 30, 109, 115 })]
		public virtual bool put(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().put(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Z")]
		[LineNumberTable(new byte[] { 162, 37, 109, 115 })]
		public virtual bool putAll(object P_0, Iterable P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().putAll(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Z")]
		[LineNumberTable(new byte[] { 162, 44, 109, 114 })]
		public virtual bool putAll(Multimap P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().putAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 162, 51, 109, 115 })]
		public virtual Collection replaceValues(object P_0, Iterable P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().replaceValues(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 58, 109, 115 })]
		public virtual bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().remove(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 162, 65, 109, 114 })]
		public virtual Collection removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().removeAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 72, 109, 107, 111 })]
		public virtual void clear()
		{
			lock (mutex)
			{
				@delegate().clear();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(new byte[] { 162, 79, 109, 104, 156, 108 })]
		public virtual Set keySet()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.keySet == null)
				{
					this.keySet = access_0024300(@delegate().keySet(), mutex);
				}
				return this.keySet;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 162, 89, 109, 104, 156, 108 })]
		public virtual Collection values()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (valuesCollection == null)
				{
					valuesCollection = access_0024500(@delegate().values(), mutex);
				}
				return valuesCollection;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 99, 109, 104, 156, 108 })]
		public virtual Collection entries()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.entries == null)
				{
					this.entries = access_0024400(@delegate().entries(), mutex);
				}
				return this.entries;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 109, 109, 108, 111 })]
		public virtual void forEach(BiConsumer P_0)
		{
			lock (mutex)
			{
				@delegate().forEach(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 116, 109, 104, 156, 108 })]
		public virtual Map asMap()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.asMap == null)
				{
					this.asMap = new SynchronizedAsMap(@delegate().asMap(), mutex);
				}
				return this.asMap;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
		[LineNumberTable(new byte[] { 162, 126, 109, 104, 156, 108 })]
		public virtual Multiset keys()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.keys == null)
				{
					this.keys = multiset(@delegate().keys(), mutex);
				}
				return this.keys;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 136, 100, 130, 109, 114 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0021
			if (P_0 == this)
			{
				return true;
			}
			lock (mutex)
			{
				return @delegate().equals(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 146, 109, 113 })]
		public override int hashCode()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().hashCode();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(594)]
		internal override object @delegate()
		{
			Multimap result = @delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedCollection<TE;>;Lcom/google/common/collect/Multiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 89, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)89,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.Multiset" })]
	internal class SynchronizedMultiset : SynchronizedCollection, Multiset, Collection, Iterable, IEnumerable
	{
		[NonSerialized]
		[Signature("Ljava/util/Set<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Set elementSet;

		[NonSerialized]
		[Signature("Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Set entrySet;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multiset<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 161, 133, 107 })]
		internal SynchronizedMultiset(Multiset P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset<TE;>;")]
		[LineNumberTable(508)]
		internal new virtual Multiset @delegate()
		{
			return (Multiset)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 143, 109, 114 })]
		public virtual int count([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().count(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)I")]
		[LineNumberTable(new byte[] { 161, 150, 109, 115 })]
		public virtual int add(object P_0, int P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().add(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 157, 109, 115 })]
		public virtual int remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, int P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().remove(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)I")]
		[LineNumberTable(new byte[] { 161, 164, 109, 115 })]
		public virtual int setCount(object P_0, int P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().setCount(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;II)Z")]
		[LineNumberTable(new byte[] { 161, 171, 109, 116 })]
		public virtual bool setCount(object P_0, int P_1, int P_2)
		{
			//Discarded unreachable code: IL_001d
			lock (mutex)
			{
				return @delegate().setCount(P_0, P_1, P_2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TE;>;")]
		[LineNumberTable(new byte[] { 161, 178, 109, 104, 156, 108 })]
		public virtual Set elementSet()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.elementSet == null)
				{
					this.elementSet = access_0024300(@delegate().elementSet(), mutex);
				}
				return this.elementSet;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(new byte[] { 161, 188, 109, 104, 156, 108 })]
		public virtual Set entrySet()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (this.entrySet == null)
				{
					this.entrySet = access_0024300(@delegate().entrySet(), mutex);
				}
				return this.entrySet;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 198, 100, 130, 109, 114 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0021
			if (P_0 == this)
			{
				return true;
			}
			lock (mutex)
			{
				return @delegate().equals(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 208, 109, 113 })]
		public override int hashCode()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().hashCode();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(497)]
		internal override Collection @delegate()
		{
			Multiset result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(497)]
		internal override object @delegate()
		{
			Multiset result = @delegate();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachEntry(ObjIntConsumer P_0)
		{
			Multiset._003Cdefault_003EforEachEntry(this, P_0);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedMultiset(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedSortedMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 127, 0, 0,
		17, 1, 0, 0, 0, 127, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)127,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableMap" })]
	internal class SynchronizedNavigableMap : SynchronizedSortedMap, NavigableMap, SortedMap, Map
	{
		[NonSerialized]
		[Signature("Ljava/util/NavigableSet<TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal NavigableSet descendingKeySet;

		[NonSerialized]
		[Signature("Ljava/util/NavigableMap<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal NavigableMap descendingMap;

		[NonSerialized]
		[Signature("Ljava/util/NavigableSet<TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal NavigableSet navigableKeySet;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<TK;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 165, 221, 106 })]
		internal SynchronizedNavigableMap(NavigableMap P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(1620)]
		internal new virtual NavigableMap @delegate()
		{
			return (NavigableMap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 157, 232, 98, 109, 126 })]
		public virtual NavigableMap headMap(object P_0, bool P_1)
		{
			//Discarded unreachable code: IL_0029
			lock (mutex)
			{
				return navigableMap(@delegate().headMap(P_0, P_1), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(new byte[] { 166, 98, 109, 104, 159, 11, 114 })]
		public virtual NavigableSet navigableKeySet()
		{
			//Discarded unreachable code: IL_004d
			object obj;
			Monitor.Enter(obj = mutex);
			try
			{
				if (this.navigableKeySet == null)
				{
					NavigableSet navigableSet = Synchronized.navigableSet(@delegate().navigableKeySet(), mutex);
					NavigableSet result = navigableSet;
					this.navigableKeySet = navigableSet;
					Monitor.Exit(obj);
					return result;
				}
				NavigableSet result2 = this.navigableKeySet;
				Monitor.Exit(obj);
				return result2;
			}
			catch
			{
				//try-fault
				Monitor.Exit(obj);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 157, 211, 165, 109, 127, 1 })]
		public virtual NavigableMap subMap(object P_0, bool P_1, object P_2, bool P_3)
		{
			//Discarded unreachable code: IL_002e
			lock (mutex)
			{
				return navigableMap(@delegate().subMap(P_0, P_1, P_2, P_3), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 157, 208, 162, 109, 126 })]
		public virtual NavigableMap tailMap(object P_0, bool P_1)
		{
			//Discarded unreachable code: IL_0029
			lock (mutex)
			{
				return navigableMap(@delegate().tailMap(P_0, P_1), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 165, 232, 109, 125 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry ceilingEntry(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024700(@delegate().ceilingEntry(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(new byte[] { 165, 240, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object ceilingKey(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().ceilingKey(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(new byte[] { 165, 249, 109, 104, 159, 11, 114 })]
		public virtual NavigableSet descendingKeySet()
		{
			//Discarded unreachable code: IL_004d
			object obj;
			Monitor.Enter(obj = mutex);
			try
			{
				if (this.descendingKeySet == null)
				{
					NavigableSet navigableSet = Synchronized.navigableSet(@delegate().descendingKeySet(), mutex);
					NavigableSet result = navigableSet;
					this.descendingKeySet = navigableSet;
					Monitor.Exit(obj);
					return result;
				}
				NavigableSet result2 = this.descendingKeySet;
				Monitor.Exit(obj);
				return result2;
			}
			catch
			{
				//try-fault
				Monitor.Exit(obj);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 166, 5, 109, 104, 159, 11, 114 })]
		public virtual NavigableMap descendingMap()
		{
			//Discarded unreachable code: IL_004d
			object obj;
			Monitor.Enter(obj = mutex);
			try
			{
				if (this.descendingMap == null)
				{
					NavigableMap navigableMap = Synchronized.navigableMap(@delegate().descendingMap(), mutex);
					NavigableMap result = navigableMap;
					this.descendingMap = navigableMap;
					Monitor.Exit(obj);
					return result;
				}
				NavigableMap result2 = this.descendingMap;
				Monitor.Exit(obj);
				return result2;
			}
			catch
			{
				//try-fault
				Monitor.Exit(obj);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 166, 16, 109, 124 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry firstEntry()
		{
			//Discarded unreachable code: IL_0025
			lock (mutex)
			{
				return access_0024700(@delegate().firstEntry(), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 166, 24, 109, 125 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry floorEntry(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024700(@delegate().floorEntry(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(new byte[] { 166, 32, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object floorKey(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().floorKey(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(1696)]
		public override SortedMap headMap(object P_0)
		{
			NavigableMap result = headMap(P_0, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 166, 52, 109, 125 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry higherEntry(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024700(@delegate().higherEntry(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(new byte[] { 166, 60, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object higherKey(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().higherKey(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 166, 68, 109, 124 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry lastEntry()
		{
			//Discarded unreachable code: IL_0025
			lock (mutex)
			{
				return access_0024700(@delegate().lastEntry(), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 166, 76, 109, 125 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry lowerEntry(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024700(@delegate().lowerEntry(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(new byte[] { 166, 84, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object lowerKey(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().lowerKey(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(1741)]
		public override Set keySet()
		{
			NavigableSet result = navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 166, 109, 109, 124 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry pollFirstEntry()
		{
			//Discarded unreachable code: IL_0025
			lock (mutex)
			{
				return access_0024700(@delegate().pollFirstEntry(), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 166, 117, 109, 124 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry pollLastEntry()
		{
			//Discarded unreachable code: IL_0025
			lock (mutex)
			{
				return access_0024700(@delegate().pollLastEntry(), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(1782)]
		public override SortedMap subMap(object P_0, object P_1)
		{
			NavigableMap result = subMap(P_0, true, P_1, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(1794)]
		public override SortedMap tailMap(object P_0)
		{
			NavigableMap result = tailMap(P_0, true);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1609)]
		internal override SortedMap @delegate()
		{
			NavigableMap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1609)]
		internal override Map @delegate()
		{
			NavigableMap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1609)]
		internal override object @delegate()
		{
			NavigableMap result = @delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedNavigableMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedSortedSet<TE;>;Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 100, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)100,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableSet" })]
	internal class SynchronizedNavigableSet : SynchronizedSortedSet, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[NonSerialized]
		[Signature("Ljava/util/NavigableSet<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal NavigableSet descendingSet;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableSet<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 165, 76, 106 })]
		internal SynchronizedNavigableSet(NavigableSet P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1475)]
		internal new virtual NavigableSet @delegate()
		{
			return (NavigableSet)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 158, 20, 162, 109, 126 })]
		public virtual NavigableSet headSet(object P_0, bool P_1)
		{
			//Discarded unreachable code: IL_0029
			lock (mutex)
			{
				return navigableSet(@delegate().headSet(P_0, P_1), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 158, 8, 69, 109, 97, 52, 139 })]
		public virtual NavigableSet subSet(object P_0, bool P_1, object P_2, bool P_3)
		{
			//Discarded unreachable code: IL_002e
			lock (mutex)
			{
				return navigableSet(@delegate().subSet(P_0, P_1, P_2, P_3), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 158, 5, 98, 109, 126 })]
		public virtual NavigableSet tailSet(object P_0, bool P_1)
		{
			//Discarded unreachable code: IL_0029
			lock (mutex)
			{
				return navigableSet(@delegate().tailSet(P_0, P_1), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(new byte[] { 165, 87, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object ceiling(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().ceiling(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(1488)]
		public virtual Iterator descendingIterator()
		{
			Iterator result = @delegate().descendingIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 165, 101, 109, 104, 119, 103, 138, 114 })]
		public virtual NavigableSet descendingSet()
		{
			//Discarded unreachable code: IL_004b
			object obj;
			Monitor.Enter(obj = mutex);
			try
			{
				if (this.descendingSet == null)
				{
					NavigableSet result = (this.descendingSet = navigableSet(@delegate().descendingSet(), mutex));
					Monitor.Exit(obj);
					return result;
				}
				NavigableSet result2 = this.descendingSet;
				Monitor.Exit(obj);
				return result2;
			}
			catch
			{
				//try-fault
				Monitor.Exit(obj);
				throw;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(new byte[] { 165, 114, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object floor(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().floor(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1522)]
		public override SortedSet headSet(object P_0)
		{
			NavigableSet result = headSet(P_0, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(new byte[] { 165, 134, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object higher(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().higher(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(new byte[] { 165, 142, 109, 114 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object lower(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().lower(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 165, 150, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollFirst()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().pollFirst();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 165, 158, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollLast()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().pollLast();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1568)]
		public override SortedSet subSet(object P_0, object P_1)
		{
			NavigableSet result = subSet(P_0, true, P_1, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1580)]
		public override SortedSet tailSet(object P_0)
		{
			NavigableSet result = tailSet(P_0, true);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1465)]
		internal override SortedSet @delegate()
		{
			NavigableSet result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1465)]
		internal override Set @delegate()
		{
			NavigableSet result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1465)]
		internal override Collection @delegate()
		{
			NavigableSet result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1465)]
		internal override object @delegate()
		{
			NavigableSet result = @delegate();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedNavigableSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class SynchronizedObject : java.lang.Object, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		internal object @delegate;

		[Modifiers(Modifiers.Final)]
		internal object mutex;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 33, 104, 108, 109 })]
		internal SynchronizedObject(object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			this.@delegate = Preconditions.checkNotNull(P_0);
			mutex = ((P_1 != null) ? P_1 : this);
		}

		internal virtual object @delegate()
		{
			return this.@delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 46, 109, 113 })]
		public override string toString()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return java.lang.Object.instancehelper_toString(this.@delegate);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 58, 109, 102, 111 })]
		private void writeObject(ObjectOutputStream P_0)
		{
			lock (mutex)
			{
				P_0.defaultWriteObject();
			}
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedObject(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedCollection<TE;>;Ljava/util/Queue<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 61, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)61,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Queue" })]
	internal class SynchronizedQueue : SynchronizedCollection, java.util.Queue, Collection, Iterable, IEnumerable
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Queue<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 166, 221, 107 })]
		internal SynchronizedQueue(java.util.Queue P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Queue<TE;>;")]
		[LineNumberTable(1876)]
		internal new virtual java.util.Queue @delegate()
		{
			return (java.util.Queue)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 166, 231, 109, 113 })]
		public virtual object element()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().element();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(new byte[] { 166, 238, 109, 114 })]
		public virtual bool offer(object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().offer(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 166, 246, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object peek()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().peek();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 166, 254, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object poll()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().poll();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 167, 5, 109, 113 })]
		public virtual object remove()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().remove();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1867)]
		internal override Collection @delegate()
		{
			java.util.Queue result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1867)]
		internal override object @delegate()
		{
			java.util.Queue result = @delegate();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Collection.Collection_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		int Collection.Collection_003A_003AhashCode()
		{
			return java.lang.Object.instancehelper_hashCode(this);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedQueue(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedList<TE;>;Ljava/util/RandomAccess;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 35, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)35,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.RandomAccess" })]
	internal class SynchronizedRandomAccessList : SynchronizedList, RandomAccess
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 161, 113, 106 })]
		internal SynchronizedRandomAccessList(List P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedRandomAccessList(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedCollection<TE;>;Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 52, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)52,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Set" })]
	internal class SynchronizedSet : SynchronizedCollection, Set, Collection, Iterable, IEnumerable
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Set<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 160, 158, 107 })]
		internal SynchronizedSet(Set P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TE;>;")]
		[LineNumberTable(277)]
		internal new virtual Set @delegate()
		{
			return (Set)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 168, 100, 130, 109, 114 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0021
			if (P_0 == this)
			{
				return true;
			}
			lock (mutex)
			{
				return @delegate().equals(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 178, 109, 113 })]
		public override int hashCode()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().hashCode();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(268)]
		internal override Collection @delegate()
		{
			Set result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(268)]
		internal override object @delegate()
		{
			Set result = @delegate();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedMultimap<TK;TV;>;Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 81, 0, 0,
		17, 1, 0, 0, 0, 81, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)81,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.SetMultimap" })]
	internal class SynchronizedSetMultimap : SynchronizedMultimap, SetMultimap, Multimap
	{
		[NonSerialized]
		[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Set entrySet;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/SetMultimap<TK;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 162, 212, 106 })]
		internal SynchronizedSetMultimap(SetMultimap P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
		[LineNumberTable(843)]
		internal new virtual SetMultimap @delegate()
		{
			return (SetMultimap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 243, 109, 104, 156, 108 })]
		public new virtual Set entries()
		{
			//Discarded unreachable code: IL_0039
			lock (mutex)
			{
				if (entrySet == null)
				{
					entrySet = set(@delegate().entries(), mutex);
				}
				return entrySet;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(new byte[] { 162, 229, 109, 114 })]
		public new virtual Set removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().removeAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(new byte[] { 162, 236, 109, 115 })]
		public new virtual Set replaceValues(object P_0, Iterable P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().replaceValues(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(new byte[] { 162, 222, 109, 125 })]
		public new virtual Set get(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return set(@delegate().get(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(832)]
		public override Collection entries()
		{
			Set result = entries();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(832)]
		public override Collection removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Set result = removeAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(832)]
		public override Collection replaceValues(object P_0, Iterable P_1)
		{
			Set result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(832)]
		public override Collection get(object P_0)
		{
			Set result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(832)]
		internal override Multimap @delegate()
		{
			SetMultimap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(832)]
		internal override object @delegate()
		{
			SetMultimap result = @delegate();
			_ = null;
			return result;
		}

		Collection SetMultimap.SetMultimap_003A_003Aentries()
		{
			return this.entries();
		}

		Collection SetMultimap.SetMultimap_003A_003Aget(object P_0)
		{
			return this.get(P_0);
		}

		Collection SetMultimap.SetMultimap_003A_003AremoveAll(object P_0)
		{
			return this.removeAll(P_0);
		}

		Collection SetMultimap.SetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
		{
			return this.replaceValues(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedSetMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedMap<TK;TV;>;Ljava/util/SortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 69, 0, 0,
		17, 1, 0, 0, 0, 69, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)69,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.SortedMap" })]
	internal class SynchronizedSortedMap : SynchronizedMap, SortedMap, Map
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedMap<TK;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 164, 150, 106 })]
		internal SynchronizedSortedMap(SortedMap P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(1293)]
		internal new virtual SortedMap @delegate()
		{
			return (SortedMap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(new byte[] { 164, 161, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().comparator();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(new byte[] { 164, 168, 109, 113 })]
		public virtual object firstKey()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().firstKey();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 164, 175, 109, 125 })]
		public virtual SortedMap headMap(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return sortedMap(@delegate().headMap(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(new byte[] { 164, 182, 109, 113 })]
		public virtual object lastKey()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().lastKey();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 164, 189, 109, 126 })]
		public virtual SortedMap subMap(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_0027
			lock (mutex)
			{
				return sortedMap(@delegate().subMap(P_0, P_1), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 164, 196, 109, 125 })]
		public virtual SortedMap tailMap(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return sortedMap(@delegate().tailMap(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1284)]
		internal override Map @delegate()
		{
			SortedMap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1284)]
		internal override object @delegate()
		{
			SortedMap result = @delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedSortedMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedSet<TE;>;Ljava/util/SortedSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 70, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)70,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.SortedSet" })]
	internal class SynchronizedSortedSet : SynchronizedSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedSet<TE;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 160, 194, 106 })]
		internal SynchronizedSortedSet(SortedSet P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(313)]
		internal new virtual SortedSet @delegate()
		{
			return (SortedSet)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TE;>;")]
		[LineNumberTable(new byte[] { 160, 205, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().comparator();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(new byte[] { 160, 212, 109, 126 })]
		public virtual SortedSet subSet(object P_0, object P_1)
		{
			//Discarded unreachable code: IL_0027
			lock (mutex)
			{
				return access_0024100(@delegate().subSet(P_0, P_1), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(new byte[] { 160, 219, 109, 125 })]
		public virtual SortedSet headSet(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024100(@delegate().headSet(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(new byte[] { 160, 226, 109, 125 })]
		public virtual SortedSet tailSet(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024100(@delegate().tailSet(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 160, 233, 109, 113 })]
		public virtual object first()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().first();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 160, 240, 109, 113 })]
		public virtual object last()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().last();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(305)]
		internal override Set @delegate()
		{
			SortedSet result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(305)]
		internal override Collection @delegate()
		{
			SortedSet result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(305)]
		internal override object @delegate()
		{
			SortedSet result = @delegate();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedSortedSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedSetMultimap<TK;TV;>;Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 76, 0, 0,
		17, 1, 0, 0, 0, 76, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)76,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.SortedSetMultimap" })]
	internal class SynchronizedSortedSetMultimap : SynchronizedSetMultimap, SortedSetMultimap, SetMultimap, Multimap
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 163, 11, 106 })]
		internal SynchronizedSortedSetMultimap(SortedSetMultimap P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
		[LineNumberTable(898)]
		internal new virtual SortedSetMultimap @delegate()
		{
			return (SortedSetMultimap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(new byte[] { 163, 35, 109, 115 })]
		public new virtual SortedSet replaceValues(object P_0, Iterable P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().replaceValues(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(new byte[] { 163, 28, 109, 114 })]
		public new virtual SortedSet removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().removeAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(new byte[] { 163, 21, 109, 125 })]
		public new virtual SortedSet get(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return access_0024100(@delegate().get(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TV;>;")]
		[LineNumberTable(new byte[] { 163, 43, 109, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator valueComparator()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().valueComparator();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		public override Set replaceValues(object P_0, Iterable P_1)
		{
			SortedSet result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		public override Set removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			SortedSet result = removeAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		public override Set get(object P_0)
		{
			SortedSet result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		internal override SetMultimap @delegate()
		{
			SortedSetMultimap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		public override Collection get(object P_0)
		{
			SortedSet result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		public override Collection removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			SortedSet result = removeAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		public override Collection replaceValues(object P_0, Iterable P_1)
		{
			SortedSet result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		internal override Multimap @delegate()
		{
			SortedSetMultimap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(889)]
		internal override object @delegate()
		{
			SortedSetMultimap result = @delegate();
			_ = null;
			return result;
		}

		Set SortedSetMultimap.SortedSetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
		{
			return this.replaceValues(P_0, P_1);
		}

		Set SortedSetMultimap.SortedSetMultimap_003A_003AremoveAll(object P_0)
		{
			return this.removeAll(P_0);
		}

		Set SortedSetMultimap.SortedSetMultimap_003A_003Aget(object P_0)
		{
			return this.get(P_0);
		}

		Collection SortedSetMultimap.SortedSetMultimap_003A_003Aget(object P_0)
		{
			return this.get(P_0);
		}

		Collection SortedSetMultimap.SortedSetMultimap_003A_003AremoveAll(object P_0)
		{
			return this.removeAll(P_0);
		}

		Collection SortedSetMultimap.SortedSetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
		{
			return this.replaceValues(P_0, P_1);
		}

		Collection SetMultimap.SetMultimap_003A_003Aentries()
		{
			return ((SynchronizedSetMultimap)this).entries();
		}

		Collection SetMultimap.SetMultimap_003A_003Aget(object P_0)
		{
			return this.get(P_0);
		}

		Collection SetMultimap.SetMultimap_003A_003AremoveAll(object P_0)
		{
			return this.removeAll(P_0);
		}

		Collection SetMultimap.SetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
		{
			return this.replaceValues(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedSortedSetMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Synchronized$SynchronizedObject;Lcom/google/common/collect/Table<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 124, 0, 0,
		17, 1, 0, 0, 0, 124, 0, 0, 17, 2,
		0, 0, 0, 124, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)124,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.Table" })]
	internal sealed class SynchronizedTable : SynchronizedObject, Table
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Map<TC;TV;>;Ljava/util/Map<TC;TV;>;>;")]
		[EnclosingMethod(null, "rowMap", "()Ljava.util.Map;")]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal SynchronizedTable this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map<TC;TV;>;)Ljava/util/Map<TC;TV;>;")]
			[LineNumberTable(2211)]
			public virtual Map apply(Map P_0)
			{
				Map result = map(P_0, this_00240.mutex);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(2208)]
			internal _1(SynchronizedTable P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(2208)]
			public virtual object apply(object P_0)
			{
				Map result = apply((Map)P_0);
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
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Map<TR;TV;>;Ljava/util/Map<TR;TV;>;>;")]
		[EnclosingMethod(null, "columnMap", "()Ljava.util.Map;")]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal class _2 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal SynchronizedTable this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(2224)]
			internal _2(SynchronizedTable P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map<TR;TV;>;)Ljava/util/Map<TR;TV;>;")]
			[LineNumberTable(2227)]
			public virtual Map apply(Map P_0)
			{
				Map result = map(P_0, this_00240.mutex);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(2224)]
			public virtual object apply(object P_0)
			{
				Map result = apply((Map)P_0);
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
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<TR;TC;TV;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 167, 165, 106 })]
		internal SynchronizedTable(Table P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Table<TR;TC;TV;>;")]
		[LineNumberTable(2077)]
		internal new virtual Table @delegate()
		{
			return (Table)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 176, 109, 115 })]
		public virtual bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().contains(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 183, 109, 114 })]
		public virtual bool containsRow([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().containsRow(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 190, 109, 114 })]
		public virtual bool containsColumn([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().containsColumn(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 197, 109, 114 })]
		public virtual bool containsValue([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_001b
			lock (mutex)
			{
				return @delegate().containsValue(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 167, 205, 109, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().get(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 212, 109, 113 })]
		public virtual bool isEmpty()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().isEmpty();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 219, 109, 113 })]
		public virtual int size()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().size();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 226, 109, 107, 111 })]
		public virtual void clear()
		{
			lock (mutex)
			{
				@delegate().clear();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TC;TV;)TV;")]
		[LineNumberTable(new byte[] { 167, 234, 109, 116 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object put(object P_0, object P_1, object P_2)
		{
			//Discarded unreachable code: IL_001d
			lock (mutex)
			{
				return @delegate().put(P_0, P_1, P_2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)V")]
		[LineNumberTable(new byte[] { 167, 241, 109, 108, 111 })]
		public virtual void putAll(Table P_0)
		{
			lock (mutex)
			{
				@delegate().putAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 167, 249, 109, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			//Discarded unreachable code: IL_001c
			lock (mutex)
			{
				return @delegate().remove(P_0, P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
		[LineNumberTable(new byte[] { 168, 0, 109, 125 })]
		public virtual Map row(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return map(@delegate().row(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Ljava/util/Map<TR;TV;>;")]
		[LineNumberTable(new byte[] { 168, 7, 109, 125 })]
		public virtual Map column(object P_0)
		{
			//Discarded unreachable code: IL_0026
			lock (mutex)
			{
				return map(@delegate().column(P_0), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 168, 14, 109, 124 })]
		public virtual Set cellSet()
		{
			//Discarded unreachable code: IL_0025
			lock (mutex)
			{
				return set(@delegate().cellSet(), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TR;>;")]
		[LineNumberTable(new byte[] { 168, 21, 109, 124 })]
		public virtual Set rowKeySet()
		{
			//Discarded unreachable code: IL_0025
			lock (mutex)
			{
				return set(@delegate().rowKeySet(), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TC;>;")]
		[LineNumberTable(new byte[] { 168, 28, 109, 124 })]
		public virtual Set columnKeySet()
		{
			//Discarded unreachable code: IL_0025
			lock (mutex)
			{
				return set(@delegate().columnKeySet(), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 168, 35, 109, 124 })]
		public virtual Collection values()
		{
			//Discarded unreachable code: IL_0025
			lock (mutex)
			{
				return access_0024500(@delegate().values(), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 168, 42, 109, 129, 48, 43, 235, 74 })]
		public virtual Map rowMap()
		{
			//Discarded unreachable code: IL_0030
			lock (mutex)
			{
				return map(Maps.transformValues(@delegate().rowMap(), new _1(this)), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TC;Ljava/util/Map<TR;TV;>;>;")]
		[LineNumberTable(new byte[] { 168, 58, 109, 129, 48, 43, 235, 74 })]
		public virtual Map columnMap()
		{
			//Discarded unreachable code: IL_0030
			lock (mutex)
			{
				return map(Maps.transformValues(@delegate().columnMap(), new _2(this)), mutex);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 74, 109, 113 })]
		public override int hashCode()
		{
			//Discarded unreachable code: IL_001a
			lock (mutex)
			{
				return @delegate().hashCode();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 81, 100, 130, 109, 114 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0021
			if (this == P_0)
			{
				return true;
			}
			lock (mutex)
			{
				return @delegate().equals(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2066)]
		internal override object @delegate()
		{
			Table result = @delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SynchronizedTable(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/BiMap<TK;TV;>;Ljava/lang/Object;)Lcom/google/common/collect/BiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(new byte[] { 164, 206, 112, 130 })]
	internal static BiMap biMap(BiMap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is SynchronizedBiMap || P_0 is ImmutableBiMap)
		{
			return P_0;
		}
		SynchronizedBiMap result = new SynchronizedBiMap(P_0, P_1, null, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(1600)]
	internal static NavigableMap navigableMap(NavigableMap P_0)
	{
		NavigableMap result = navigableMap(P_0, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;Ljava/lang/Object;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 218, 112, 130 })]
	internal static Multimap multimap(Multimap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is SynchronizedMultimap || P_0 is BaseImmutableMultimap)
		{
			return P_0;
		}
		SynchronizedMultimap result = new SynchronizedMultimap(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SetMultimap<TK;TV;>;Ljava/lang/Object;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(new byte[] { 162, 200, 112, 130 })]
	internal static SetMultimap setMultimap(SetMultimap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is SynchronizedSetMultimap || P_0 is BaseImmutableMultimap)
		{
			return P_0;
		}
		SynchronizedSetMultimap result = new SynchronizedSetMultimap(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;Ljava/lang/Object;)Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(new byte[] { 163, 1, 104, 130 })]
	internal static SortedSetMultimap sortedSetMultimap(SortedSetMultimap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is SynchronizedSortedSetMultimap)
		{
			return P_0;
		}
		SynchronizedSortedSetMultimap result = new SynchronizedSortedSetMultimap(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ListMultimap<TK;TV;>;Ljava/lang/Object;)Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(new byte[] { 162, 156, 112, 130 })]
	internal static ListMultimap listMultimap(ListMultimap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is SynchronizedListMultimap || P_0 is BaseImmutableMultimap)
		{
			return P_0;
		}
		SynchronizedListMultimap result = new SynchronizedListMultimap(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Queue<TE;>;Ljava/lang/Object;)Ljava/util/Queue<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(1864)]
	internal static java.util.Queue queue(java.util.Queue P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		java.util.Queue obj = ((!(P_0 is SynchronizedQueue)) ? new SynchronizedQueue(P_0, P_1) : P_0);
		java.util.Queue result = ((obj == null) ? null : ((obj as java.util.Queue) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Deque<TE;>;Ljava/lang/Object;)Ljava/util/Deque<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(1920)]
	internal static Deque deque(Deque P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedDeque result = new SynchronizedDeque(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/NavigableSet<TE;>;)Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(1594)]
	internal static NavigableSet navigableSet(NavigableSet P_0)
	{
		NavigableSet result = navigableSet(P_0, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map$Entry<TK;TV;>;Ljava/lang/Object;)Ljava/util/Map$Entry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(new byte[] { 166, 155, 99, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Map.Entry nullableSynchronizedEntry([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Map.Entry P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 == null)
		{
			return null;
		}
		SynchronizedEntry result = new SynchronizedEntry(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;Ljava/lang/Object;)Ljava/util/Collection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(119)]
	private static Collection collection(Collection P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedCollection result = new SynchronizedCollection(P_0, P_1, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;Ljava/lang/Object;)Ljava/util/Collection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 53, 104, 143, 104, 143, 104, 143 })]
	private static Collection typePreservingCollection(Collection P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is SortedSet)
		{
			SortedSet result = sortedSet((SortedSet)P_0, P_1);
			_ = null;
			return result;
		}
		if (P_0 is Set)
		{
			Set result2 = set((Set)P_0, P_1);
			_ = null;
			return result2;
		}
		if (P_0 is List)
		{
			List result3 = list((List)P_0, P_1);
			_ = null;
			return result3;
		}
		Collection result4 = collection(P_0, P_1);
		_ = null;
		return result4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;Ljava/lang/Object;)Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 67, 104, 143 })]
	private static Set typePreservingSet(Set P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is SortedSet)
		{
			SortedSet result = sortedSet((SortedSet)P_0, P_1);
			_ = null;
			return result;
		}
		Set result2 = set(P_0, P_1);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/List<TE;>;Ljava/lang/Object;)Ljava/util/List<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 250, 104, 105, 9 })]
	private static List list(List P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedList result = ((!(P_0 is RandomAccess)) ? new SynchronizedList(P_0, P_1) : new SynchronizedRandomAccessList(P_0, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;Ljava/lang/Object;)Ljava/util/SortedSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(302)]
	private static SortedSet sortedSet(SortedSet P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedSortedSet result = new SynchronizedSortedSet(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;Ljava/lang/Object;)Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(265)]
	internal static Set set(Set P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedSet result = new SynchronizedSet(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/NavigableSet<TE;>;Ljava/lang/Object;)Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(1589)]
	internal static NavigableSet navigableSet(NavigableSet P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedNavigableSet result = new SynchronizedNavigableSet(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV;>;Ljava/lang/Object;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(1606)]
	internal static NavigableMap navigableMap(NavigableMap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedNavigableMap result = new SynchronizedNavigableMap(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(77)]
	private Synchronized()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Ljava/lang/Object;)Lcom/google/common/collect/Multiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 104, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 121, 112, 130 })]
	internal static Multiset multiset(Multiset P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 is SynchronizedMultiset || P_0 is ImmutableMultiset)
		{
			return P_0;
		}
		SynchronizedMultiset result = new SynchronizedMultiset(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Ljava/lang/Object;)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(1061)]
	internal static Map map(Map P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedMap result = new SynchronizedMap(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV;>;Ljava/lang/Object;)Ljava/util/SortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(1281)]
	internal static SortedMap sortedMap(SortedMap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedSortedMap result = new SynchronizedSortedMap(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Table<TR;TC;TV;>;Ljava/lang/Object;)Lcom/google/common/collect/Table<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 104, 0, 0,
		18, 1, 0, 0, 0, 104, 0, 0, 18, 2,
		0, 0, 0, 104, 0, 0
	})]
	[LineNumberTable(2063)]
	internal static Table table(Table P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		SynchronizedTable result = new SynchronizedTable(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(76)]
	internal static SortedSet access_0024100(SortedSet P_0, object P_1)
	{
		SortedSet result = sortedSet(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(76)]
	internal static List access_0024200(List P_0, object P_1)
	{
		List result = list(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(76)]
	internal static Set access_0024300(Set P_0, object P_1)
	{
		Set result = typePreservingSet(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(76)]
	internal static Collection access_0024400(Collection P_0, object P_1)
	{
		Collection result = typePreservingCollection(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(76)]
	internal static Collection access_0024500(Collection P_0, object P_1)
	{
		Collection result = collection(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(76)]
	internal static Map.Entry access_0024700(Map.Entry P_0, object P_1)
	{
		Map.Entry result = nullableSynchronizedEntry(P_0, P_1);
		_ = null;
		return result;
	}
}
