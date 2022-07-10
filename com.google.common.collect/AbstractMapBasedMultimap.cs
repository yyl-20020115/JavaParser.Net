using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
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

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultimap<TK;TV;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 184, 0, 0,
	17, 1, 0, 0, 0, 184, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)184,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal abstract class AbstractMapBasedMultimap : AbstractMultimap, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.Itr<TV;>;")]
	[EnclosingMethod(null, "valueIterator", "()Ljava.util.Iterator;")]
	internal class _1 : Itr
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1237)]
		internal _1(AbstractMapBasedMultimap P_0)
			: base(P_0)
		{
		}

		[Signature("(TK;TV;)TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object output([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			return P_1;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.Itr<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
	internal class _2 : Itr
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1296)]
		internal _2(AbstractMapBasedMultimap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(1299)]
		internal new virtual Map.Entry output([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			Map.Entry result = Maps.immutableEntry(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1296)]
		internal override object output([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			Map.Entry result = output(P_0, P_1);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/Maps$ViewCachingAbstractMap<TK;Ljava/util/Collection<TV;>;>;")]
	internal class AsMap : Maps.ViewCachingAbstractMap
	{
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/Maps$EntrySet<TK;Ljava/util/Collection<TV;>;>;")]
		internal class AsMapEntries : Maps.EntrySet
		{
			[SpecialName]
			private sealed class ___003C_003EAnon0 : java.util.function.Function
			{
				private readonly AsMap arg_00241;

				internal ___003C_003EAnon0(AsMap P_0)
				{
					arg_00241 = P_0;
				}

				public object apply(object P_0)
				{
					Map.Entry result = arg_00241.wrapEntry((Map.Entry)P_0);
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
			internal AsMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1451)]
			public override bool contains([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				bool result = Collections2.safeContains(this_00241.submap.entrySet(), P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1431)]
			internal AsMapEntries(AsMap P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
			internal override Map map()
			{
				return this_00241;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
			[LineNumberTable(1439)]
			public override Iterator iterator()
			{
				AsMapIterator result = new AsMapIterator(this_00241);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
			[LineNumberTable(1444)]
			public override Spliterator spliterator()
			{
				Spliterator result = CollectSpliterators.map(this_00241.submap.entrySet().spliterator(), new ___003C_003EAnon0(this_00241));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 165, 62, 105, 162, 113, 118 })]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (!contains(P_0))
				{
					return false;
				}
				Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull((Map.Entry)P_0);
				access_0024300(this_00241.this_00240, entry.getKey());
				return true;
			}
		}

		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		internal class AsMapIterator : java.lang.Object, Iterator
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
			internal Iterator delegateIterator;

			[Signature("Ljava/util/Collection<TV;>;")]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal Collection collection;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 165, 73, 111 })]
			internal AsMapIterator(AsMap P_0)
			{
				this_00241 = P_0;
				base._002Ector();
				delegateIterator = this_00241.submap.entrySet().iterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
			[LineNumberTable(new byte[] { 165, 84, 113, 113 })]
			public virtual Map.Entry next()
			{
				Map.Entry entry = (Map.Entry)delegateIterator.next();
				collection = (Collection)entry.getValue();
				Map.Entry result = this_00241.wrapEntry(entry);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1473)]
			public virtual bool hasNext()
			{
				bool result = delegateIterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 165, 91, 118, 107, 124, 107, 103 })]
			public virtual void remove()
			{
				Preconditions.checkState(collection != null, (object)"no calls to next() since the last call to remove()");
				delegateIterator.remove();
				access_0024220(this_00241.this_00240, collection.size());
				collection.clear();
				collection = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1467)]
			public virtual object next()
			{
				Map.Entry result = this.next();
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[NonSerialized]
		[Modifiers(Modifiers.Final | Modifiers.Transient)]
		[Signature("Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		internal Map submap;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 164, 210, 111, 103 })]
		internal AsMap(AbstractMapBasedMultimap P_0, Map P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			submap = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;)Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 32, 103 })]
		internal virtual Map.Entry wrapEntry(Map.Entry P_0)
		{
			object key = P_0.getKey();
			Map.Entry result = Maps.immutableEntry(key, this_00240.wrapCollection(key, (Collection)P_0.getValue()));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 164, 251, 114, 99, 162, 108, 104, 114, 102 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Collection remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Collection collection = (Collection)submap.remove(P_0);
			if (collection == null)
			{
				return null;
			}
			Collection collection2 = this_00240.createCollection();
			collection2.addAll(collection);
			access_0024220(this_00240, collection.size());
			collection.clear();
			return collection2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 164, 229, 114, 99, 162, 98 })]
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
			Collection collection = (Collection)Maps.safeGet(submap, P_0);
			if (collection == null)
			{
				return null;
			}
			Collection result = this_00240.wrapCollection(P_0, collection);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		[LineNumberTable(1354)]
		protected internal override Set createEntrySet()
		{
			AsMapEntries result = new AsMapEntries(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1361)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = Maps.safeContainsKey(submap, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(1378)]
		public override Set keySet()
		{
			Set result = this_00240.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1383)]
		public override int size()
		{
			int result = submap.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1403)]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (this == P_0 || submap.equals(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1408)]
		public override int hashCode()
		{
			int result = submap.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1413)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(submap);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 24, 115, 141, 141 })]
		public override void clear()
		{
			if (submap == access_0024000(this_00240))
			{
				this_00240.clear();
			}
			else
			{
				Iterators.clear(new AsMapIterator(this));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1340)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Collection result = remove(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1340)]
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
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Abstract)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 75, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)75,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class Itr : java.lang.Object, Iterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		internal Iterator keyIterator;

		[Signature("TK;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object key;

		[Signature("Ljava/util/Collection<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Collection collection;

		[Signature("Ljava/util/Iterator<TV;>;")]
		internal Iterator valueIterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMapBasedMultimap this_00240;

		[Signature("(TK;TV;)TT;")]
		internal abstract object output([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 38, 111, 118, 103, 103, 107 })]
		internal Itr(AbstractMapBasedMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			keyIterator = access_0024000(P_0).entrySet().iterator();
			key = null;
			collection = null;
			valueIterator = Iterators.emptyModifiableIterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1187)]
		public virtual bool hasNext()
		{
			return (keyIterator.hasNext() || valueIterator.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 164, 54, 109, 113, 108, 113, 241, 70 })]
		public virtual object next()
		{
			if (!valueIterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)keyIterator.next();
				key = entry.getKey();
				collection = (Collection)entry.getValue();
				valueIterator = collection.iterator();
			}
			object result = output(NullnessCasts.uncheckedCastNullableTToT(key), valueIterator.next());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 69, 235, 69, 119, 139, 108 })]
		public virtual void remove()
		{
			valueIterator.remove();
			if (((Collection)java.util.Objects.requireNonNull(collection)).isEmpty())
			{
				keyIterator.remove();
			}
			access_0024210(this_00240);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/Maps$KeySet<TK;Ljava/util/Collection<TV;>;>;")]
	internal class KeySet : Maps.KeySet
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/Iterator<TK;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : java.lang.Object, Iterator
		{
			[Signature("Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			internal Map.Entry entry;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024entryIterator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal KeySet this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(953)]
			internal _1(KeySet P_0, Iterator P_1)
			{
				this_00241 = P_0;
				val_0024entryIterator = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(958)]
			public virtual bool hasNext()
			{
				bool result = val_0024entryIterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TK;")]
			[LineNumberTable(new byte[] { 163, 82, 118 })]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public virtual object next()
			{
				entry = (Map.Entry)val_0024entryIterator.next();
				object key = entry.getKey();
				_ = null;
				return key;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 88, 118, 113, 107, 119, 102, 103 })]
			public virtual void remove()
			{
				Preconditions.checkState(entry != null, (object)"no calls to next() since the last call to remove()");
				Collection collection = (Collection)entry.getValue();
				val_0024entryIterator.remove();
				access_0024220(this_00241.this_00240, collection.size());
				collection.clear();
				entry = null;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 163, 64, 103, 105 })]
		internal KeySet(AbstractMapBasedMultimap P_0, Map P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(new byte[] { 163, 70, 113 })]
		public override Iterator iterator()
		{
			Iterator iterator = map().entrySet().iterator();
			_1 result = new _1(this, iterator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TK;>;")]
		[LineNumberTable(984)]
		public override Spliterator spliterator()
		{
			Spliterator result = map().keySet().spliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 107, 98, 114, 99, 103, 102, 141 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int num = 0;
			Collection collection = (Collection)map().remove(P_0);
			if (collection != null)
			{
				num = collection.size();
				collection.clear();
				access_0024220(this_00240, num);
			}
			return num > 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 119, 109 })]
		public override void clear()
		{
			Iterators.clear(iterator());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(1006)]
		public override bool containsAll(Collection P_0)
		{
			bool result = map().keySet().containsAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1011)]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (this == P_0 || map().keySet().equals(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1016)]
		public override int hashCode()
		{
			int result = map().keySet().hashCode();
			_ = null;
			return result;
		}
	}

	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.SortedAsMap;Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
	[Implements(new string[] { "java.util.NavigableMap" })]
	internal class NavigableAsMap : SortedAsMap, NavigableMap, SortedMap, Map
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 165, 162, 103, 106 })]
		internal NavigableAsMap(AbstractMapBasedMultimap P_0, NavigableMap P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1562)]
		internal new virtual NavigableMap sortedMap()
		{
			return (NavigableMap)base.sortedMap();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;)Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 251, 104, 130, 108, 108, 114, 102 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal virtual Map.Entry pollAsMapEntry(Iterator P_0)
		{
			if (!P_0.hasNext())
			{
				return null;
			}
			Map.Entry entry = (Map.Entry)P_0.next();
			Collection collection = this_00240.createCollection();
			collection.addAll((Collection)entry.getValue());
			P_0.remove();
			Map.Entry result = Maps.immutableEntry(entry.getKey(), this_00240.unmodifiableCollectionSubclass(collection));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1657)]
		public virtual NavigableMap descendingMap()
		{
			NavigableAsMap result = new NavigableAsMap(this_00240, sortedMap().descendingMap());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1662)]
		public new virtual NavigableSet keySet()
		{
			return (NavigableSet)base.keySet();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1692)]
		public virtual NavigableMap subMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2, bool P_3)
		{
			NavigableAsMap result = new NavigableAsMap(this_00240, sortedMap().subMap(P_0, P_1, P_2, P_3));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1702)]
		public virtual NavigableMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableAsMap result = new NavigableAsMap(this_00240, sortedMap().headMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1713)]
		public virtual NavigableMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableAsMap result = new NavigableAsMap(this_00240, sortedMap().tailMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1667)]
		internal new virtual NavigableSet createKeySet()
		{
			NavigableKeySet result = new NavigableKeySet(this_00240, sortedMap());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1707)]
		public new virtual NavigableMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableMap result = tailMap(P_0, true);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1683)]
		public new virtual NavigableMap subMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			NavigableMap result = subMap(P_0, true, P_1, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1697)]
		public new virtual NavigableMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableMap result = headMap(P_0, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 174, 109 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry lowerEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map.Entry entry = sortedMap().lowerEntry(P_0);
			Map.Entry result = ((entry != null) ? wrapEntry(entry) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(1575)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object lowerKey([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = sortedMap().lowerKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 187, 109 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry floorEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map.Entry entry = sortedMap().floorEntry(P_0);
			Map.Entry result = ((entry != null) ? wrapEntry(entry) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(1588)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object floorKey([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = sortedMap().floorKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 200, 109 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry ceilingEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map.Entry entry = sortedMap().ceilingEntry(P_0);
			Map.Entry result = ((entry != null) ? wrapEntry(entry) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(1601)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object ceilingKey([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = sortedMap().ceilingKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 213, 109 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry higherEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map.Entry entry = sortedMap().higherEntry(P_0);
			Map.Entry result = ((entry != null) ? wrapEntry(entry) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(1614)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object higherKey([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = sortedMap().higherKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 226, 108 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry firstEntry()
		{
			Map.Entry entry = sortedMap().firstEntry();
			Map.Entry result = ((entry != null) ? wrapEntry(entry) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 165, 233, 108 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry lastEntry()
		{
			Map.Entry entry = sortedMap().lastEntry();
			Map.Entry result = ((entry != null) ? wrapEntry(entry) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1634)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry pollFirstEntry()
		{
			Map.Entry result = pollAsMapEntry(entrySet().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1640)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry pollLastEntry()
		{
			Map.Entry result = pollAsMapEntry(descendingMap().entrySet().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1672)]
		public virtual NavigableSet navigableKeySet()
		{
			NavigableSet result = keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1677)]
		public virtual NavigableSet descendingKeySet()
		{
			NavigableSet result = descendingMap().navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1554)]
		internal override SortedSet createKeySet()
		{
			NavigableSet result = createKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1554)]
		public override SortedSet keySet()
		{
			NavigableSet result = keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1554)]
		public override SortedMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableMap result = tailMap(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1554)]
		public override SortedMap subMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			NavigableMap result = subMap(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1554)]
		public override SortedMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableMap result = headMap(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1554)]
		internal override SortedMap sortedMap()
		{
			NavigableMap result = sortedMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1554)]
		public override Set keySet()
		{
			NavigableSet result = keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1554)]
		internal override Set createKeySet()
		{
			NavigableSet result = createKeySet();
			_ = null;
			return result;
		}

		object Map.Map_003A_003Aput(object P_0, object P_1)
		{
			return put(P_0, P_1);
		}

		void Map.Map_003A_003AputAll(Map P_0)
		{
			putAll(P_0);
		}

		object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
		{
			return putIfAbsent(P_0, P_1);
		}

		bool Map.Map_003A_003AisEmpty()
		{
			return isEmpty();
		}

		bool Map.Map_003A_003AcontainsValue(object P_0)
		{
			return containsValue(P_0);
		}

		object Map.Map_003A_003AgetOrDefault(object P_0, object P_1)
		{
			return getOrDefault(P_0, P_1);
		}

		void Map.Map_003A_003AforEach(BiConsumer P_0)
		{
			forEach(P_0);
		}

		void Map.Map_003A_003AreplaceAll(BiFunction P_0)
		{
			replaceAll(P_0);
		}

		bool Map.Map_003A_003Aremove(object P_0, object P_1)
		{
			return remove(P_0, P_1);
		}

		bool Map.Map_003A_003Areplace(object P_0, object P_1, object P_2)
		{
			return replace(P_0, P_1, P_2);
		}

		object Map.Map_003A_003Areplace(object P_0, object P_1)
		{
			return replace(P_0, P_1);
		}

		object Map.Map_003A_003AcomputeIfAbsent(object P_0, java.util.function.Function P_1)
		{
			return computeIfAbsent(P_0, P_1);
		}

		object Map.Map_003A_003AcomputeIfPresent(object P_0, BiFunction P_1)
		{
			return computeIfPresent(P_0, P_1);
		}

		object Map.Map_003A_003Acompute(object P_0, BiFunction P_1)
		{
			return compute(P_0, P_1);
		}

		object Map.Map_003A_003Amerge(object P_0, object P_1, BiFunction P_2)
		{
			return merge(P_0, P_1, P_2);
		}
	}

	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.SortedKeySet;Ljava/util/NavigableSet<TK;>;")]
	[Implements(new string[] { "java.util.NavigableSet" })]
	internal class NavigableKeySet : SortedKeySet, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 163, 185, 103, 106 })]
		internal NavigableKeySet(AbstractMapBasedMultimap P_0, NavigableMap P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1073)]
		internal new virtual NavigableMap sortedMap()
		{
			return (NavigableMap)base.sortedMap();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(1119)]
		public virtual Iterator descendingIterator()
		{
			Iterator result = descendingSet().iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1114)]
		public virtual NavigableSet descendingSet()
		{
			NavigableKeySet result = new NavigableKeySet(this_00240, sortedMap().descendingMap());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1129)]
		public virtual NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableKeySet result = new NavigableKeySet(this_00240, sortedMap().headMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(new byte[] { 158, 112, 69, 103, 53 })]
		public virtual NavigableSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2, bool P_3)
		{
			NavigableKeySet result = new NavigableKeySet(this_00240, sortedMap().subMap(P_0, P_1, P_2, P_3));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1155)]
		public virtual NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableKeySet result = new NavigableKeySet(this_00240, sortedMap().tailMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1150)]
		public new virtual NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableSet result = tailSet(P_0, true);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1135)]
		public new virtual NavigableSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			NavigableSet result = subSet(P_0, true, P_1, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1124)]
		public new virtual NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableSet result = headSet(P_0, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(1079)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object lower([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = sortedMap().lowerKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(1085)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object floor([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = sortedMap().floorKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(1091)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object ceiling([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = sortedMap().ceilingKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(1097)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object higher([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = sortedMap().higherKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1103)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollFirst()
		{
			object result = Iterators.pollNext(iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1109)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollLast()
		{
			object result = Iterators.pollNext(descendingIterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1065)]
		public override SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableSet result = tailSet(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1065)]
		public override SortedSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			NavigableSet result = subSet(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1065)]
		public override SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableSet result = headSet(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1065)]
		internal override SortedMap sortedMap()
		{
			NavigableMap result = sortedMap();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Set.Set_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Set.Set_003A_003AtoArray()
		{
			return toArray();
		}

		object[] Set.Set_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Set.Set_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedList;Ljava/util/RandomAccess;")]
	[Implements(new string[] { "java.util.RandomAccess" })]
	internal class RandomAccessWrappedList : WrappedList, RandomAccess
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/List<TV;>;Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;)V")]
		[LineNumberTable(new byte[] { 163, 43, 109 })]
		internal RandomAccessWrappedList([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] AbstractMapBasedMultimap P_0, object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] List P_2, WrappedCollection P_3)
			: base(P_0, P_1, P_2, P_3)
		{
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.AsMap;Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;")]
	[Implements(new string[] { "java.util.SortedMap" })]
	internal class SortedAsMap : AsMap, SortedMap, Map
	{
		[Signature("Ljava/util/SortedSet<TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal SortedSet sortedKeySet;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 165, 102, 103, 106 })]
		internal SortedAsMap(AbstractMapBasedMultimap P_0, SortedMap P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1);
		}

		[Signature("()Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1501)]
		internal virtual SortedMap sortedMap()
		{
			return (SortedMap)submap;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(1550)]
		internal new virtual SortedSet createKeySet()
		{
			SortedKeySet result = new SortedKeySet(this_00240, sortedMap());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(new byte[] { 165, 150, 103 })]
		public new virtual SortedSet keySet()
		{
			SortedSet sortedSet = sortedKeySet;
			SortedSet result;
			if (sortedSet == null)
			{
				SortedSet sortedSet2 = createKeySet();
				result = sortedSet2;
				sortedKeySet = sortedSet2;
			}
			else
			{
				result = sortedSet;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(1507)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			Comparator result = sortedMap().comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1513)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object firstKey()
		{
			object result = sortedMap().firstKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1519)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object lastKey()
		{
			object result = sortedMap().lastKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1524)]
		public virtual SortedMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedAsMap result = new SortedAsMap(this_00240, sortedMap().headMap(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1530)]
		public virtual SortedMap subMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			SortedAsMap result = new SortedAsMap(this_00240, sortedMap().subMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1535)]
		public virtual SortedMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedAsMap result = new SortedAsMap(this_00240, sortedMap().tailMap(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1494)]
		public override Set keySet()
		{
			SortedSet result = keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1494)]
		internal override Set createKeySet()
		{
			SortedSet result = createKeySet();
			_ = null;
			return result;
		}

		object Map.Map_003A_003Aput(object P_0, object P_1)
		{
			return put(P_0, P_1);
		}

		void Map.Map_003A_003AputAll(Map P_0)
		{
			putAll(P_0);
		}

		object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
		{
			return putIfAbsent(P_0, P_1);
		}

		bool Map.Map_003A_003AisEmpty()
		{
			return isEmpty();
		}

		bool Map.Map_003A_003AcontainsValue(object P_0)
		{
			return containsValue(P_0);
		}

		object Map.Map_003A_003AgetOrDefault(object P_0, object P_1)
		{
			return getOrDefault(P_0, P_1);
		}

		void Map.Map_003A_003AforEach(BiConsumer P_0)
		{
			forEach(P_0);
		}

		void Map.Map_003A_003AreplaceAll(BiFunction P_0)
		{
			replaceAll(P_0);
		}

		bool Map.Map_003A_003Aremove(object P_0, object P_1)
		{
			return remove(P_0, P_1);
		}

		bool Map.Map_003A_003Areplace(object P_0, object P_1, object P_2)
		{
			return replace(P_0, P_1, P_2);
		}

		object Map.Map_003A_003Areplace(object P_0, object P_1)
		{
			return replace(P_0, P_1);
		}

		object Map.Map_003A_003AcomputeIfAbsent(object P_0, java.util.function.Function P_1)
		{
			return computeIfAbsent(P_0, P_1);
		}

		object Map.Map_003A_003AcomputeIfPresent(object P_0, BiFunction P_1)
		{
			return computeIfPresent(P_0, P_1);
		}

		object Map.Map_003A_003Acompute(object P_0, BiFunction P_1)
		{
			return compute(P_0, P_1);
		}

		object Map.Map_003A_003Amerge(object P_0, object P_1, BiFunction P_2)
		{
			return merge(P_0, P_1, P_2);
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.KeySet;Ljava/util/SortedSet<TK;>;")]
	[Implements(new string[] { "java.util.SortedSet" })]
	internal class SortedKeySet : KeySet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 163, 141, 103, 106 })]
		internal SortedKeySet(AbstractMapBasedMultimap P_0, SortedMap P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1028)]
		internal virtual SortedMap sortedMap()
		{
			return (SortedMap)base.map();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(1034)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			Comparator result = sortedMap().comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1040)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object first()
		{
			object result = sortedMap().firstKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(1045)]
		public virtual SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedKeySet result = new SortedKeySet(this_00240, sortedMap().headMap(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1051)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object last()
		{
			object result = sortedMap().lastKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(1056)]
		public virtual SortedSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			SortedKeySet result = new SortedKeySet(this_00240, sortedMap().subMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(1061)]
		public virtual SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedKeySet result = new SortedKeySet(this_00240, sortedMap().tailMap(P_0));
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Set.Set_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Set.Set_003A_003AtoArray()
		{
			return toArray();
		}

		object[] Set.Set_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Set.Set_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}
	}

	[Signature("Ljava/util/AbstractCollection<TV;>;")]
	internal class WrappedCollection : AbstractCollection
	{
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/Iterator<TV;>;")]
		internal class WrappedIterator : java.lang.Object, Iterator
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<TV;>;")]
			internal Iterator delegateIterator;

			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Collection<TV;>;")]
			internal Collection originalDelegate;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal WrappedCollection this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 75, 15, 177, 113 })]
			internal WrappedIterator(WrappedCollection P_0)
			{
				this_00241 = P_0;
				base._002Ector();
				originalDelegate = this_00241.@delegate;
				delegateIterator = access_0024100(P_0.@delegate);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 87, 107, 115, 139 })]
			internal virtual void validateIterator()
			{
				this_00241.refreshIfEmpty();
				if (this_00241.@delegate != originalDelegate)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new ConcurrentModificationException();
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Iterator<TV;>;)V")]
			[LineNumberTable(new byte[] { 161, 79, 239, 58, 241, 71, 103 })]
			internal WrappedIterator(WrappedCollection P_0, Iterator P_1)
			{
				this_00241 = P_0;
				base._002Ector();
				originalDelegate = this_00241.@delegate;
				delegateIterator = P_1;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 95, 102 })]
			public virtual bool hasNext()
			{
				validateIterator();
				bool result = delegateIterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TV;")]
			[LineNumberTable(new byte[] { 161, 102, 102 })]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public virtual object next()
			{
				validateIterator();
				object result = delegateIterator.next();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 108, 107, 113, 109 })]
			public virtual void remove()
			{
				delegateIterator.remove();
				access_0024210(this_00241.this_00240);
				this_00241.removeIfEmpty();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<TV;>;")]
			[LineNumberTable(new byte[] { 161, 114, 102 })]
			internal virtual Iterator getDelegateIterator()
			{
				validateIterator();
				return delegateIterator;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object key;

		[Signature("Ljava/util/Collection<TV;>;")]
		internal Collection @delegate;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal WrappedCollection ancestor;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Collection<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Collection ancestorDelegate;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/Collection<TV;>;Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;)V")]
		[LineNumberTable(new byte[] { 160, 224, 111, 103, 103, 104, 116 })]
		internal WrappedCollection([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] AbstractMapBasedMultimap P_0, object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Collection P_2, WrappedCollection P_3)
		{
			this_00240 = P_0;
			base._002Ector();
			key = P_1;
			@delegate = P_2;
			ancestor = P_3;
			ancestorDelegate = P_3?.getDelegate();
		}

		[Signature("()Ljava/util/Collection<TV;>;")]
		internal virtual Collection getDelegate()
		{
			return @delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 239, 104, 107, 115, 139, 109, 124, 99, 167 })]
		internal virtual void refreshIfEmpty()
		{
			if (ancestor != null)
			{
				ancestor.refreshIfEmpty();
				if (ancestor.getDelegate() != ancestorDelegate)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new ConcurrentModificationException();
				}
			}
			else if (@delegate.isEmpty())
			{
				Collection collection = (Collection)access_0024000(this_00240).get(key);
				if (collection != null)
				{
					@delegate = collection;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 1, 104, 109, 109, 151 })]
		internal virtual void removeIfEmpty()
		{
			if (ancestor != null)
			{
				ancestor.removeIfEmpty();
			}
			else if (@delegate.isEmpty())
			{
				access_0024000(this_00240).remove(key);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 20, 104, 141, 157 })]
		internal virtual void addToMap()
		{
			if (ancestor != null)
			{
				ancestor.addToMap();
			}
			else
			{
				access_0024000(this_00240).put(key, @delegate);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 29, 102 })]
		public override int size()
		{
			refreshIfEmpty();
			int result = @delegate.size();
			_ = null;
			return result;
		}

		[Signature("()TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal virtual object getKey()
		{
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 35, 100, 130, 102 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 == this)
			{
				return true;
			}
			refreshIfEmpty();
			bool result = @delegate.equals(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 44, 102 })]
		public override int hashCode()
		{
			refreshIfEmpty();
			int result = @delegate.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 50, 102 })]
		public override string toString()
		{
			refreshIfEmpty();
			string result = java.lang.Object.instancehelper_toString(@delegate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(new byte[] { 161, 60, 102 })]
		public override Iterator iterator()
		{
			refreshIfEmpty();
			WrappedIterator result = new WrappedIterator(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TV;>;")]
		[LineNumberTable(new byte[] { 161, 66, 102 })]
		public override Spliterator spliterator()
		{
			refreshIfEmpty();
			Spliterator result = @delegate.spliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)Z")]
		[LineNumberTable(new byte[] { 161, 121, 102, 108, 109, 99, 108, 99, 166 })]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			refreshIfEmpty();
			int num = (@delegate.isEmpty() ? 1 : 0);
			int num2 = (@delegate.add(P_0) ? 1 : 0);
			if (num2 != 0)
			{
				access_0024208(this_00240);
				if (num != 0)
				{
					addToMap();
				}
			}
			return (byte)num2 != 0;
		}

		[Signature("()Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal virtual WrappedCollection getAncestor()
		{
			return ancestor;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TV;>;)Z")]
		[LineNumberTable(new byte[]
		{
			161, 142, 104, 130, 103, 109, 99, 108, 111, 99,
			166
		})]
		public override bool addAll(Collection P_0)
		{
			if (P_0.isEmpty())
			{
				return false;
			}
			int num = size();
			int num2 = (@delegate.addAll(P_0) ? 1 : 0);
			if (num2 != 0)
			{
				int num3 = @delegate.size();
				access_0024212(this_00240, num3 - num);
				if (num == 0)
				{
					addToMap();
				}
			}
			return (byte)num2 != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 159, 102 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			refreshIfEmpty();
			bool result = @delegate.contains(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 161, 165, 102 })]
		public override bool containsAll(Collection P_0)
		{
			refreshIfEmpty();
			bool result = @delegate.containsAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 171, 103, 99, 129, 107, 109, 104 })]
		public override void clear()
		{
			int num = size();
			if (num != 0)
			{
				@delegate.clear();
				access_0024220(this_00240, num);
				removeIfEmpty();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 182, 102, 109, 99, 108, 134 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			refreshIfEmpty();
			int num = (@delegate.remove(P_0) ? 1 : 0);
			if (num != 0)
			{
				access_0024210(this_00240);
				removeIfEmpty();
			}
			return (byte)num != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 161, 193, 104, 130, 103, 109, 99, 108, 111, 134 })]
		public override bool removeAll(Collection P_0)
		{
			if (P_0.isEmpty())
			{
				return false;
			}
			int num = size();
			int num2 = (@delegate.removeAll(P_0) ? 1 : 0);
			if (num2 != 0)
			{
				int num3 = @delegate.size();
				access_0024212(this_00240, num3 - num);
				removeIfEmpty();
			}
			return (byte)num2 != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 161, 208, 103, 103, 109, 99, 108, 111, 134 })]
		public override bool retainAll(Collection P_0)
		{
			Preconditions.checkNotNull(P_0);
			int num = size();
			int num2 = (@delegate.retainAll(P_0) ? 1 : 0);
			if (num2 != 0)
			{
				int num3 = @delegate.size();
				access_0024212(this_00240, num3 - num);
				removeIfEmpty();
			}
			return (byte)num2 != 0;
		}
	}

	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;Ljava/util/List<TV;>;")]
	[Implements(new string[] { "java.util.List" })]
	internal class WrappedList : WrappedCollection, List, Collection, Iterable, IEnumerable
	{
		[InnerClass(null, Modifiers.Private)]
		[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection.WrappedIterator;Ljava/util/ListIterator<TV;>;")]
		[Implements(new string[] { "java.util.ListIterator" })]
		internal class WrappedListIterator : WrappedIterator, ListIterator, Iterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal new WrappedList this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(870)]
			internal WrappedListIterator(WrappedList P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 246, 103, 117 })]
			public WrappedListIterator(WrappedList P_0, int P_1)
			{
				this_00241 = P_0;
				base._002Ector(P_0, P_0.getListDelegate().listIterator(P_1));
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/ListIterator<TV;>;")]
			[LineNumberTable(877)]
			private ListIterator getDelegateListIterator()
			{
				return (ListIterator)getDelegateIterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(882)]
			public virtual bool hasPrevious()
			{
				bool result = getDelegateListIterator().hasPrevious();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TV;")]
			[LineNumberTable(888)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public virtual object previous()
			{
				object result = getDelegateListIterator().previous();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(893)]
			public virtual int nextIndex()
			{
				int result = getDelegateListIterator().nextIndex();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(898)]
			public virtual int previousIndex()
			{
				int result = getDelegateListIterator().previousIndex();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TV;)V")]
			[LineNumberTable(new byte[] { 163, 21, 110 })]
			public virtual void set([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				getDelegateListIterator().set(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TV;)V")]
			[LineNumberTable(new byte[] { 163, 26, 108, 108, 113, 99, 141 })]
			public virtual void add([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				int num = (this_00241.isEmpty() ? 1 : 0);
				getDelegateListIterator().add(P_0);
				access_0024208(this_00241.this_00240);
				if (num != 0)
				{
					this_00241.addToMap();
				}
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public override void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/List<TV;>;Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;)V")]
		[LineNumberTable(new byte[] { 162, 149, 103, 109 })]
		internal WrappedList([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] AbstractMapBasedMultimap P_0, object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] List P_2, WrappedCollection P_3)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<TV;>;")]
		[LineNumberTable(780)]
		internal virtual List getListDelegate()
		{
			return (List)getDelegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILjava/util/Collection<+TV;>;)Z")]
		[LineNumberTable(new byte[]
		{
			162, 159, 104, 130, 103, 110, 99, 108, 111, 99,
			166
		})]
		public virtual bool addAll(int P_0, Collection P_1)
		{
			if (P_1.isEmpty())
			{
				return false;
			}
			int num = size();
			int num2 = (getListDelegate().addAll(P_0, P_1) ? 1 : 0);
			if (num2 != 0)
			{
				int num3 = getDelegate().size();
				access_0024212(this_00240, num3 - num);
				if (num == 0)
				{
					addToMap();
				}
			}
			return (byte)num2 != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(new byte[] { 162, 177, 102 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object get(int P_0)
		{
			refreshIfEmpty();
			object result = getListDelegate().get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITV;)TV;")]
		[LineNumberTable(new byte[] { 162, 184, 102 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object set(int P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			refreshIfEmpty();
			object result = getListDelegate().set(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITV;)V")]
		[LineNumberTable(new byte[] { 162, 190, 102, 108, 109, 108, 99, 136 })]
		public virtual void add(int P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			refreshIfEmpty();
			int num = (getDelegate().isEmpty() ? 1 : 0);
			getListDelegate().add(P_0, P_1);
			access_0024208(this_00240);
			if (num != 0)
			{
				addToMap();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(new byte[] { 162, 202, 102, 109, 108, 102 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object remove(int P_0)
		{
			refreshIfEmpty();
			object result = getListDelegate().remove(P_0);
			access_0024210(this_00240);
			removeIfEmpty();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 211, 102 })]
		public virtual int indexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			refreshIfEmpty();
			int result = getListDelegate().indexOf(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 217, 102 })]
		public virtual int lastIndexOf([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			refreshIfEmpty();
			int result = getListDelegate().lastIndexOf(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/ListIterator<TV;>;")]
		[LineNumberTable(new byte[] { 162, 223, 102 })]
		public virtual ListIterator listIterator()
		{
			refreshIfEmpty();
			WrappedListIterator result = new WrappedListIterator(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/ListIterator<TV;>;")]
		[LineNumberTable(new byte[] { 162, 229, 102 })]
		public virtual ListIterator listIterator(int P_0)
		{
			refreshIfEmpty();
			WrappedListIterator result = new WrappedListIterator(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(II)Ljava/util/List<TV;>;")]
		[LineNumberTable(new byte[] { 162, 235, 102, 103, 102, 108, 241, 61 })]
		public virtual List subList(int P_0, int P_1)
		{
			refreshIfEmpty();
			List result = this_00240.wrapList(getKey(), getListDelegate().subList(P_0, P_1), (getAncestor() != null) ? getAncestor() : this);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void replaceAll(UnaryOperator P_0)
		{
			List._003Cdefault_003EreplaceAll(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void sort(Comparator P_0)
		{
			List._003Cdefault_003Esort(this, P_0);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		object[] List.List_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		object[] List.List_003A_003AtoArray()
		{
			return toArray();
		}

		bool List.List_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Collection.Collection_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}

		void Iterable.Iterable_003A_003AforEach(Consumer P_0)
		{
			forEach(P_0);
		}
	}

	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedSortedSet;Ljava/util/NavigableSet<TV;>;")]
	[Implements(new string[] { "java.util.NavigableSet" })]
	internal class WrappedNavigableSet : WrappedSortedSet, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TV;>;")]
		[LineNumberTable(697)]
		internal new virtual NavigableSet getSortedSetDelegate()
		{
			return (NavigableSet)base.getSortedSetDelegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(747)]
		public virtual Iterator descendingIterator()
		{
			WrappedIterator result = new WrappedIterator(this, getSortedSetDelegate().descendingIterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/NavigableSet<TV;>;Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;)V")]
		[LineNumberTable(new byte[] { 162, 65, 103, 109 })]
		internal WrappedNavigableSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] AbstractMapBasedMultimap P_0, object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] NavigableSet P_2, WrappedCollection P_3)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableSet<TV;>;)Ljava/util/NavigableSet<TV;>;")]
		[LineNumberTable(737)]
		private NavigableSet wrap(NavigableSet P_0)
		{
			WrappedNavigableSet result = new WrappedNavigableSet(this_00240, key, P_0, (getAncestor() != null) ? getAncestor() : this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(703)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object lower([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = getSortedSetDelegate().lower(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(709)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object floor([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = getSortedSetDelegate().floor(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(715)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object ceiling([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = getSortedSetDelegate().ceiling(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(721)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object higher([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = getSortedSetDelegate().higher(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(727)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollFirst()
		{
			object result = Iterators.pollNext(iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(733)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollLast()
		{
			object result = Iterators.pollNext(descendingIterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TV;>;")]
		[LineNumberTable(742)]
		public virtual NavigableSet descendingSet()
		{
			NavigableSet result = wrap(getSortedSetDelegate().descendingSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;ZTV;Z)Ljava/util/NavigableSet<TV;>;")]
		[LineNumberTable(new byte[] { 158, 209, 69, 98, 46 })]
		public virtual NavigableSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2, bool P_3)
		{
			NavigableSet result = wrap(getSortedSetDelegate().subSet(P_0, P_1, P_2, P_3));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;Z)Ljava/util/NavigableSet<TV;>;")]
		[LineNumberTable(762)]
		public virtual NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = wrap(getSortedSetDelegate().headSet(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;Z)Ljava/util/NavigableSet<TV;>;")]
		[LineNumberTable(767)]
		public virtual NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = wrap(getSortedSetDelegate().tailSet(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(686)]
		internal override SortedSet getSortedSetDelegate()
		{
			NavigableSet sortedSetDelegate = getSortedSetDelegate();
			_ = null;
			return sortedSetDelegate;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Set.Set_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Set.Set_003A_003AtoArray()
		{
			return toArray();
		}

		object[] Set.Set_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Collection.Collection_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}

		void Iterable.Iterable_003A_003AforEach(Consumer P_0)
		{
			forEach(P_0);
		}
	}

	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;Ljava/util/Set<TV;>;")]
	[Implements(new string[] { "java.util.Set" })]
	internal class WrappedSet : WrappedCollection, Set, Collection, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/Set<TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 230, 103, 108 })]
		internal WrappedSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] AbstractMapBasedMultimap P_0, object P_1, Set P_2)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1, P_2, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[]
		{
			161, 236, 104, 130, 231, 69, 114, 99, 108, 111,
			134
		})]
		public override bool removeAll(Collection P_0)
		{
			if (P_0.isEmpty())
			{
				return false;
			}
			int num = size();
			int num2 = (Sets.removeAllImpl((Set)@delegate, P_0) ? 1 : 0);
			if (num2 != 0)
			{
				int num3 = @delegate.size();
				access_0024212(this_00240, num3 - num);
				removeIfEmpty();
			}
			return (byte)num2 != 0;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Set.Set_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Set.Set_003A_003AtoArray()
		{
			return toArray();
		}

		object[] Set.Set_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Collection.Collection_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}

		void Iterable.Iterable_003A_003AforEach(Consumer P_0)
		{
			forEach(P_0);
		}
	}

	[Signature("Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;Ljava/util/SortedSet<TV;>;")]
	[Implements(new string[] { "java.util.SortedSet" })]
	internal class WrappedSortedSet : WrappedCollection, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new AbstractMapBasedMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(635)]
		internal virtual SortedSet getSortedSetDelegate()
		{
			return (SortedSet)getDelegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/SortedSet<TV;>;Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;)V")]
		[LineNumberTable(new byte[] { 162, 4, 103, 109 })]
		internal WrappedSortedSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] AbstractMapBasedMultimap P_0, object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] SortedSet P_2, WrappedCollection P_3)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1, P_2, P_3);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TV;>;")]
		[LineNumberTable(641)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			Comparator result = getSortedSetDelegate().comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(new byte[] { 162, 21, 102 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object first()
		{
			refreshIfEmpty();
			object result = getSortedSetDelegate().first();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(new byte[] { 162, 28, 102 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object last()
		{
			refreshIfEmpty();
			object result = getSortedSetDelegate().last();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(new byte[] { 162, 34, 102, 103, 102, 107, 248, 61 })]
		public virtual SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			refreshIfEmpty();
			WrappedSortedSet result = new WrappedSortedSet(this_00240, getKey(), getSortedSetDelegate().headSet(P_0), (getAncestor() != null) ? getAncestor() : this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;TV;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(new byte[] { 162, 43, 102, 103, 102, 108, 248, 61 })]
		public virtual SortedSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			refreshIfEmpty();
			WrappedSortedSet result = new WrappedSortedSet(this_00240, getKey(), getSortedSetDelegate().subSet(P_0, P_1), (getAncestor() != null) ? getAncestor() : this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(new byte[] { 162, 52, 102, 103, 102, 107, 248, 61 })]
		public virtual SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			refreshIfEmpty();
			WrappedSortedSet result = new WrappedSortedSet(this_00240, getKey(), getSortedSetDelegate().tailSet(P_0), (getAncestor() != null) ? getAncestor() : this);
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Set.Set_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Set.Set_003A_003AtoArray()
		{
			return toArray();
		}

		object[] Set.Set_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Collection.Collection_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}

		void Iterable.Iterable_003A_003AforEach(Consumer P_0)
		{
			forEach(P_0);
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
			Spliterator result = ((Collection)P_0).spliterator();
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

	[SpecialName]
	private sealed class ___003C_003EAnon1 : java.util.function.Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Spliterator result = lambda_0024entrySpliterator_00241((Map.Entry)P_0);
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

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BiConsumer
	{
		private readonly BiConsumer arg_00241;

		internal ___003C_003EAnon2(BiConsumer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024forEach_00243(arg_00241, P_0, (Collection)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly BiConsumer arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon3(BiConsumer P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024forEach_00242(arg_00241, arg_00242, P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : java.util.function.Function
	{
		private readonly object arg_00241;

		internal ___003C_003EAnon4(object P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Map.Entry result = lambda_0024entrySpliterator_00240(arg_00241, P_0);
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

	[NonSerialized]
	[Signature("Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	private Map map;

	[NonSerialized]
	private int totalSize;

	private const long serialVersionUID = 2447537837011683357L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 23, 146, 99, 103, 102, 142 })]
	private void removeValuesForKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Collection collection = (Collection)Maps.safeRemove(map, P_0);
		if (collection != null)
		{
			int num = collection.size();
			collection.clear();
			totalSize -= num;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/Iterator<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 184, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 222, 104, 109, 6 })]
	private static Iterator iteratorOrListIterator(Collection P_0)
	{
		Iterator obj = ((!(P_0 is List)) ? P_0.iterator() : ((List)P_0).listIterator());
		Iterator result = ((obj == null) ? null : ((obj as Iterator) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[Signature("()Ljava/util/Collection<TV;>;")]
	internal abstract Collection createCollection();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/Collection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 184, 0, 0 })]
	[LineNumberTable(269)]
	internal virtual Collection unmodifiableCollectionSubclass(Collection P_0)
	{
		Collection result = Collections.unmodifiableCollection(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(165)]
	internal virtual Collection createCollection([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Collection result = createCollection();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 160, 139, 146, 99, 169, 103, 104, 115, 134 })]
	public override Collection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Collection collection = (Collection)map.remove(P_0);
		if (collection == null)
		{
			Collection result = createUnmodifiableEmptyCollection();
			_ = null;
			return result;
		}
		Collection collection2 = createCollection();
		collection2.addAll(collection);
		totalSize -= collection.size();
		collection.clear();
		Collection result2 = unmodifiableCollectionSubclass(collection2);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 160, 93, 114, 99, 104, 142 })]
	private Collection getOrCreateCollection([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Collection collection = (Collection)map.get(P_0);
		if (collection == null)
		{
			collection = createCollection(P_0);
			map.put(P_0, collection);
		}
		return collection;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(141)]
	internal virtual Collection createUnmodifiableEmptyCollection()
	{
		Collection result = unmodifiableCollectionSubclass(createCollection());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/Collection<TV;>;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(303)]
	internal virtual Collection wrapCollection([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Collection P_1)
	{
		WrappedCollection result = new WrappedCollection(this, P_0, P_1, null);
		_ = null;
		return result;
	}

	public override int size()
	{
		return totalSize;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 164, 171, 103, 108, 97, 48 })]
	private static Spliterator lambda_0024entrySpliterator_00241(Map.Entry P_0)
	{
		object key = P_0.getKey();
		Collection collection = (Collection)P_0.getValue();
		Spliterator result = CollectSpliterators.map(collection.spliterator(), new ___003C_003EAnon4(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(1322)]
	private static void lambda_0024forEach_00243(BiConsumer P_0, object P_1, Collection P_2)
	{
		P_2.forEach(new ___003C_003EAnon3(P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(1322)]
	private static void lambda_0024forEach_00242(BiConsumer P_0, object P_1, object P_2)
	{
		P_0.accept(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(1312)]
	private static Map.Entry lambda_0024entrySpliterator_00240(object P_0, object P_1)
	{
		Map.Entry result = Maps.immutableEntry(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;)V")]
	[LineNumberTable(new byte[] { 70, 104, 107, 103 })]
	protected internal AbstractMapBasedMultimap(Map P_0)
	{
		Preconditions.checkArgument(P_0.isEmpty());
		map = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;)V")]
	[LineNumberTable(new byte[] { 77, 103, 103, 127, 1, 113, 115, 98 })]
	internal void setMap(Map P_0)
	{
		map = P_0;
		totalSize = 0;
		Iterator iterator = P_0.values().iterator();
		while (iterator.hasNext())
		{
			Collection collection = (Collection)iterator.next();
			Preconditions.checkArgument((!collection.isEmpty()) ? true : false);
			totalSize += collection.size();
		}
	}

	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	internal virtual Map backingMap()
	{
		return map;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(181)]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = map.containsKey(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)Z")]
	[LineNumberTable(new byte[]
	{
		160, 74, 114, 99, 104, 105, 110, 110, 130, 144,
		105, 110, 130
	})]
	public override bool put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		Collection collection = (Collection)map.get(P_0);
		if (collection == null)
		{
			collection = createCollection(P_0);
			if (collection.add(P_1))
			{
				totalSize++;
				map.put(P_0, collection);
				return true;
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("New Collection violated the Collection spec");
		}
		if (collection.add(P_1))
		{
			totalSize++;
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 110, 103, 104, 202, 104, 103, 136, 115, 134,
		104, 110, 208
	})]
	public override Collection replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		Iterator iterator = P_1.iterator();
		if (!iterator.hasNext())
		{
			Collection result = removeAll(P_0);
			_ = null;
			return result;
		}
		Collection orCreateCollection = getOrCreateCollection(P_0);
		Collection collection = createCollection();
		collection.addAll(orCreateCollection);
		totalSize -= orCreateCollection.size();
		orCreateCollection.clear();
		while (iterator.hasNext())
		{
			if (orCreateCollection.add(iterator.next()))
			{
				totalSize++;
			}
		}
		Collection result2 = unmodifiableCollectionSubclass(collection);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 161, 127, 6, 102, 98, 107, 103 })]
	public override void clear()
	{
		Iterator iterator = map.values().iterator();
		while (iterator.hasNext())
		{
			Collection collection = (Collection)iterator.next();
			collection.clear();
		}
		map.clear();
		totalSize = 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 160, 177, 114, 99, 136 })]
	public override Collection get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Collection collection = (Collection)map.get(P_0);
		if (collection == null)
		{
			collection = createCollection(P_0);
		}
		Collection result = wrapCollection(P_0, collection);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/List<TV;>;Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>.WrappedCollection;)Ljava/util/List<TV;>;")]
	[LineNumberTable(new byte[] { 160, 194, 104, 107, 11 })]
	internal List wrapList([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, List P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] WrappedCollection P_2)
	{
		WrappedList result = ((!(P_1 is RandomAccess)) ? new WrappedList(this, P_0, P_1, P_2) : new RandomAccessWrappedList(this, P_0, P_1, P_2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(931)]
	internal override Set createKeySet()
	{
		KeySet result = new KeySet(this, map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(new byte[] { 163, 53, 109, 116, 109, 148 })]
	internal Set createMaybeNavigableKeySet()
	{
		if (map is NavigableMap)
		{
			NavigableKeySet result = new NavigableKeySet(this, (NavigableMap)map);
			_ = null;
			return result;
		}
		if (map is SortedMap)
		{
			SortedKeySet result2 = new SortedKeySet(this, (SortedMap)map);
			_ = null;
			return result2;
		}
		KeySet result3 = new KeySet(this, map);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(1227)]
	public override Collection values()
	{
		Collection result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(1232)]
	internal override Collection createValues()
	{
		Values result = new Values(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TV;>;")]
	[LineNumberTable(1237)]
	internal override Iterator valueIterator()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TV;>;")]
	[LineNumberTable(new byte[] { 164, 110, 102, 61 })]
	internal override Spliterator valueSpliterator()
	{
		Spliterator result = CollectSpliterators.flatMap(map.values().spliterator(), new ___003C_003EAnon0(), 64, size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
	[LineNumberTable(1260)]
	internal override Multiset createKeys()
	{
		Multimaps.Keys result = new Multimaps.Keys(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(1274)]
	public override Collection entries()
	{
		Collection result = base.entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 164, 141, 104, 137 })]
	internal override Collection createEntries()
	{
		if (this is SetMultimap)
		{
			EntrySet result = new EntrySet(this);
			_ = null;
			return result;
		}
		Entries result2 = new Entries(this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(1296)]
	internal override Iterator entryIterator()
	{
		_2 result = new _2(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 164, 168, 102, 247, 72, 230, 55 })]
	internal override Spliterator entrySpliterator()
	{
		Spliterator result = CollectSpliterators.flatMap(map.entrySet().spliterator(), new ___003C_003EAnon1(), 64, size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 164, 182, 103, 152 })]
	public override void forEach(BiConsumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		map.forEach(new ___003C_003EAnon2(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(1327)]
	internal override Map createAsMap()
	{
		AsMap result = new AsMap(this, map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(new byte[] { 164, 193, 109, 116, 109, 148 })]
	internal Map createMaybeNavigableAsMap()
	{
		if (map is NavigableMap)
		{
			NavigableAsMap result = new NavigableAsMap(this, (NavigableMap)map);
			_ = null;
			return result;
		}
		if (map is SortedMap)
		{
			SortedAsMap result2 = new SortedAsMap(this, (SortedMap)map);
			_ = null;
			return result2;
		}
		AsMap result3 = new AsMap(this, map);
		_ = null;
		return result3;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(90)]
	internal static Map access_0024000(AbstractMapBasedMultimap P_0)
	{
		return P_0.map;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(90)]
	internal static Iterator access_0024100(Collection P_0)
	{
		Iterator result = iteratorOrListIterator(P_0);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(90)]
	internal static int access_0024210(AbstractMapBasedMultimap P_0)
	{
		int num = P_0.totalSize;
		P_0.totalSize = num - 1;
		return num;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(90)]
	internal static int access_0024208(AbstractMapBasedMultimap P_0)
	{
		int num = P_0.totalSize;
		P_0.totalSize = num + 1;
		return num;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(90)]
	internal static int access_0024212(AbstractMapBasedMultimap P_0, int P_1)
	{
		int result = P_0.totalSize + P_1;
		P_0.totalSize = result;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(90)]
	internal static int access_0024220(AbstractMapBasedMultimap P_0, int P_1)
	{
		int result = P_0.totalSize - P_1;
		P_0.totalSize = result;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(90)]
	internal static void access_0024300(AbstractMapBasedMultimap P_0, object P_1)
	{
		P_0.removeValuesForKey(P_1);
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
	protected AbstractMapBasedMultimap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
