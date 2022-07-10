using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)144,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Multimaps : java.lang.Object
{
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$ViewCachingAbstractMap<TK;Ljava/util/Collection<TV;>;>;")]
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
	internal sealed class AsMap : Maps.ViewCachingAbstractMap
	{
		[Signature("Lcom/google/common/collect/Maps$EntrySet<TK;Ljava/util/Collection<TV;>;>;")]
		internal class EntrySet : Maps.EntrySet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<TK;Ljava/util/Collection<TV;>;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			[Implements(new string[] { "com.google.common.base.Function" })]
			internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal EntrySet this_00241;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(TK;)Ljava/util/Collection<TV;>;")]
				[LineNumberTable(1902)]
				public virtual Collection apply([ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})] object P_0)
				{
					Collection result = access_0024200(this_00241.this_00240).get(P_0);
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(1899)]
				internal _1(EntrySet P_0)
				{
					this_00241 = P_0;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(1899)]
				public virtual object apply([ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})] object P_0)
				{
					Collection result = this.apply(P_0);
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

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1889)]
			internal EntrySet(AsMap P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
			internal override Map map()
			{
				return this_00240;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
			[LineNumberTable(new byte[] { 166, 247, 102, 48 })]
			public override Iterator iterator()
			{
				Iterator result = Maps.asMapEntryIterator(access_0024200(this_00240).keySet(), new _1(this));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 167, 3, 105, 162, 113, 113 })]
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
				this_00240.removeValuesForKey(entry.getKey());
				return true;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multimap<TK;TV;>;")]
		private Multimap multimap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 166, 220, 104, 113 })]
		internal AsMap(Multimap P_0)
		{
			multimap = (Multimap)Preconditions.checkNotNull(P_0);
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1866)]
		internal static Multimap access_0024200(AsMap P_0)
		{
			return P_0.multimap;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 235, 114 })]
		internal virtual void removeValuesForKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			multimap.keySet().remove(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1944)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = multimap.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(1929)]
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
			return (!containsKey(P_0)) ? null : multimap.removeAll(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(1923)]
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
			return (!containsKey(P_0)) ? null : multimap.get(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1876)]
		public override int size()
		{
			int result = multimap.keySet().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;>;")]
		[LineNumberTable(1881)]
		protected internal override Set createEntrySet()
		{
			EntrySet result = new EntrySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(1934)]
		public override Set keySet()
		{
			Set result = multimap.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1939)]
		public override bool isEmpty()
		{
			bool result = multimap.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 167, 43, 109 })]
		public override void clear()
		{
			multimap.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1866)]
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
		[LineNumberTable(1866)]
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractListMultimap<TK;TV;>;")]
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
	internal class CustomListMultimap : AbstractListMultimap
	{
		[NonSerialized]
		[Signature("Lcom/google/common/base/Supplier<+Ljava/util/List<TV;>;>;")]
		internal com.google.common.@base.Supplier factory;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/List<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 160, 221, 105, 113 })]
		internal CustomListMultimap(Map P_0, com.google.common.@base.Supplier P_1)
			: base(P_0)
		{
			factory = (com.google.common.@base.Supplier)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<TV;>;")]
		[LineNumberTable(351)]
		protected internal override List createCollection()
		{
			return (List)factory.get();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(341)]
		internal override Set createKeySet()
		{
			Set result = createMaybeNavigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(346)]
		internal override Map createAsMap()
		{
			Map result = createMaybeNavigableAsMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 160, 243, 102, 108, 110 })]
		private void writeObject(ObjectOutputStream P_0)
		{
			P_0.defaultWriteObject();
			P_0.writeObject(factory);
			P_0.writeObject(backingMap());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 160, 251, 102, 113, 108, 105 })]
		private void readObject(ObjectInputStream P_0)
		{
			P_0.defaultReadObject();
			factory = (com.google.common.@base.Supplier)P_0.readObject();
			Map map = (Map)P_0.readObject();
			setMap(map);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(330)]
		protected internal override Collection createCollection()
		{
			List result = this.createCollection();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CustomListMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMapBasedMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 79, 0, 0,
		17, 1, 0, 0, 0, 79, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)79,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class CustomMultimap : AbstractMapBasedMultimap
	{
		[NonSerialized]
		[Signature("Lcom/google/common/base/Supplier<+Ljava/util/Collection<TV;>;>;")]
		internal com.google.common.@base.Supplier factory;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/Collection<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 160, 106, 105, 113 })]
		internal CustomMultimap(Map P_0, com.google.common.@base.Supplier P_1)
			: base(P_0)
		{
			factory = (com.google.common.@base.Supplier)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(226)]
		internal override Set createKeySet()
		{
			Set result = createMaybeNavigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(231)]
		internal override Map createAsMap()
		{
			Map result = createMaybeNavigableAsMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(236)]
		protected internal override Collection createCollection()
		{
			return (Collection)factory.get();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/Collection<TE;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 79, 0, 0 })]
		[LineNumberTable(new byte[] { 160, 128, 104, 110, 104, 110, 104, 110, 104, 142 })]
		internal override Collection unmodifiableCollectionSubclass(Collection P_0)
		{
			if (P_0 is NavigableSet)
			{
				NavigableSet result = Sets.unmodifiableNavigableSet((NavigableSet)P_0);
				_ = null;
				return result;
			}
			if (P_0 is SortedSet)
			{
				SortedSet result2 = Collections.unmodifiableSortedSet((SortedSet)P_0);
				_ = null;
				return result2;
			}
			if (P_0 is Set)
			{
				Set result3 = Collections.unmodifiableSet((Set)P_0);
				_ = null;
				return result3;
			}
			if (P_0 is List)
			{
				List result4 = Collections.unmodifiableList((List)P_0);
				_ = null;
				return result4;
			}
			Collection result5 = Collections.unmodifiableCollection(P_0);
			_ = null;
			return result5;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/Collection<TV;>;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 160, 143, 104, 113, 104, 113, 104, 113, 104, 144 })]
		internal override Collection wrapCollection([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Collection P_1)
		{
			if (P_1 is List)
			{
				List result = wrapList(P_0, (List)P_1, null);
				_ = null;
				return result;
			}
			if (P_1 is NavigableSet)
			{
				WrappedNavigableSet result2 = new WrappedNavigableSet(this, P_0, (NavigableSet)P_1, null);
				_ = null;
				return result2;
			}
			if (P_1 is SortedSet)
			{
				WrappedSortedSet result3 = new WrappedSortedSet(this, P_0, (SortedSet)P_1, null);
				_ = null;
				return result3;
			}
			if (P_1 is Set)
			{
				WrappedSet result4 = new WrappedSet(this, P_0, (Set)P_1);
				_ = null;
				return result4;
			}
			WrappedCollection result5 = new WrappedCollection(this, P_0, P_1, null);
			_ = null;
			return result5;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 160, 162, 102, 108, 110 })]
		private void writeObject(ObjectOutputStream P_0)
		{
			P_0.defaultWriteObject();
			P_0.writeObject(factory);
			P_0.writeObject(backingMap());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 160, 170, 102, 113, 108, 105 })]
		private void readObject(ObjectInputStream P_0)
		{
			P_0.defaultReadObject();
			factory = (com.google.common.@base.Supplier)P_0.readObject();
			Map map = (Map)P_0.readObject();
			setMap(map);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CustomMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractSetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 72, 0, 0,
		17, 1, 0, 0, 0, 72, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)72,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class CustomSetMultimap : AbstractSetMultimap
	{
		[NonSerialized]
		[Signature("Lcom/google/common/base/Supplier<+Ljava/util/Set<TV;>;>;")]
		internal com.google.common.@base.Supplier factory;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/Set<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 161, 45, 105, 113 })]
		internal CustomSetMultimap(Map P_0, com.google.common.@base.Supplier P_1)
			: base(P_0)
		{
			factory = (com.google.common.@base.Supplier)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(431)]
		protected internal override Set createCollection()
		{
			return (Set)factory.get();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(421)]
		internal override Set createKeySet()
		{
			Set result = createMaybeNavigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(426)]
		internal override Map createAsMap()
		{
			Map result = createMaybeNavigableAsMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/Collection<TE;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 72, 0, 0 })]
		[LineNumberTable(new byte[] { 161, 67, 104, 110, 104, 142 })]
		internal override Collection unmodifiableCollectionSubclass(Collection P_0)
		{
			if (P_0 is NavigableSet)
			{
				NavigableSet result = Sets.unmodifiableNavigableSet((NavigableSet)P_0);
				_ = null;
				return result;
			}
			if (P_0 is SortedSet)
			{
				SortedSet result2 = Collections.unmodifiableSortedSet((SortedSet)P_0);
				_ = null;
				return result2;
			}
			Set result3 = Collections.unmodifiableSet((Set)P_0);
			_ = null;
			return result3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/Collection<TV;>;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 161, 78, 104, 113, 104, 145 })]
		internal override Collection wrapCollection([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Collection P_1)
		{
			if (P_1 is NavigableSet)
			{
				WrappedNavigableSet result = new WrappedNavigableSet(this, P_0, (NavigableSet)P_1, null);
				_ = null;
				return result;
			}
			if (P_1 is SortedSet)
			{
				WrappedSortedSet result2 = new WrappedSortedSet(this, P_0, (SortedSet)P_1, null);
				_ = null;
				return result2;
			}
			WrappedSet result3 = new WrappedSet(this, P_0, (Set)P_1);
			_ = null;
			return result3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 161, 90, 102, 108, 110 })]
		private void writeObject(ObjectOutputStream P_0)
		{
			P_0.defaultWriteObject();
			P_0.writeObject(factory);
			P_0.writeObject(backingMap());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 161, 98, 102, 113, 108, 105 })]
		private void readObject(ObjectInputStream P_0)
		{
			P_0.defaultReadObject();
			factory = (com.google.common.@base.Supplier)P_0.readObject();
			Map map = (Map)P_0.readObject();
			setMap(map);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(410)]
		protected internal override Collection createCollection()
		{
			Set result = this.createCollection();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CustomSetMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractSortedSetMultimap<TK;TV;>;")]
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
	internal class CustomSortedSetMultimap : AbstractSortedSetMultimap
	{
		[NonSerialized]
		[Signature("Lcom/google/common/base/Supplier<+Ljava/util/SortedSet<TV;>;>;")]
		internal com.google.common.@base.Supplier factory;

		[NonSerialized]
		[Signature("Ljava/util/Comparator<-TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new Comparator valueComparator;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/SortedSet<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 161, 150, 105, 113, 118 })]
		internal CustomSortedSetMultimap(Map P_0, com.google.common.@base.Supplier P_1)
			: base(P_0)
		{
			factory = (com.google.common.@base.Supplier)Preconditions.checkNotNull(P_1);
			this.valueComparator = ((SortedSet)P_1.get()).comparator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(537)]
		protected internal override SortedSet createCollection()
		{
			return (SortedSet)factory.get();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(527)]
		internal override Set createKeySet()
		{
			Set result = createMaybeNavigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(532)]
		internal override Map createAsMap()
		{
			Map result = createMaybeNavigableAsMap();
			_ = null;
			return result;
		}

		[Signature("()Ljava/util/Comparator<-TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override Comparator valueComparator()
		{
			return this.valueComparator;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 161, 179, 102, 108, 110 })]
		private void writeObject(ObjectOutputStream P_0)
		{
			P_0.defaultWriteObject();
			P_0.writeObject(factory);
			P_0.writeObject(backingMap());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 161, 187, 102, 113, 123, 108, 105 })]
		private void readObject(ObjectInputStream P_0)
		{
			P_0.defaultReadObject();
			factory = (com.google.common.@base.Supplier)P_0.readObject();
			this.valueComparator = ((SortedSet)factory.get()).comparator();
			Map map = (Map)P_0.readObject();
			setMap(map);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(513)]
		protected internal override Set createCollection()
		{
			SortedSet result = this.createCollection();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(513)]
		protected internal override Collection createCollection()
		{
			SortedSet result = this.createCollection();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CustomSortedSetMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractCollection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 46, 0, 0,
		17, 1, 0, 0, 0, 46, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)46,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class Entries : AbstractCollection
	{
		[Signature("()Lcom/google/common/collect/Multimap<TK;TV;>;")]
		internal abstract Multimap multimap();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1832)]
		internal Entries()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1838)]
		public override int size()
		{
			int result = multimap().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 193, 104, 103, 154 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				bool result = multimap().containsEntry(entry.getKey(), entry.getValue());
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 202, 104, 103, 154 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				bool result = multimap().remove(entry.getKey(), entry.getValue());
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 211, 109 })]
		public override void clear()
		{
			multimap().clear();
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultiset<TK;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 111, 0, 0,
		17, 1, 0, 0, 0, 111, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)111,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class Keys : AbstractMultiset
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/TransformedIterator<Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/collect/Multiset$Entry<TK;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal class _1 : TransformedIterator
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/Multisets$AbstractEntry<TK;>;")]
			[EnclosingMethod(null, "transform", "(Ljava.util.Map$Entry;)Lcom.google.common.collect.Multiset$Entry;")]
			internal class _1 : Multisets.AbstractEntry
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal Map.Entry val_0024backingEntry;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(1736)]
				internal _1(Keys._1 P_0, Map.Entry P_1)
				{
					val_0024backingEntry = P_1;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()TK;")]
				[LineNumberTable(1740)]
				[ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})]
				public override object getElement()
				{
					object key = val_0024backingEntry.getKey();
					_ = null;
					return key;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(1745)]
				public override int getCount()
				{
					int result = ((Collection)val_0024backingEntry.getValue()).size();
					_ = null;
					return result;
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1733)]
			internal _1(Keys P_0, Iterator P_1)
				: base(P_1)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map$Entry<TK;Ljava/util/Collection<TV;>;>;)Lcom/google/common/collect/Multiset$Entry<TK;>;")]
			[LineNumberTable(1736)]
			internal virtual Multiset.Entry transform(Map.Entry P_0)
			{
				_1 result = new _1(this, P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1733)]
			internal override object transform(object P_0)
			{
				Multiset.Entry result = transform((Map.Entry)P_0);
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
				object key = ((Map.Entry)P_0).getKey();
				_ = null;
				return key;
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
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly Consumer arg_00241;

			internal ___003C_003EAnon1(Consumer P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				lambda_0024forEach_00240(arg_00241, (Map.Entry)P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multimap<TK;TV;>;")]
		internal Multimap multimap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 166, 76, 104, 103 })]
		internal Keys(Multimap P_0)
		{
			multimap = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TK;>;>;")]
		[LineNumberTable(new byte[] { 166, 82, 103, 54 })]
		internal override Iterator entryIterator()
		{
			_1 result = new _1(this, multimap.asMap().entrySet().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 135, 119 })]
		public override int count([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int result = ((Collection)Maps.safeGet(multimap.asMap(), P_0))?.size() ?? 0;
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1760)]
		private static void lambda_0024forEach_00240(Consumer P_0, Map.Entry P_1)
		{
			P_0.accept(P_1.getKey());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TK;>;")]
		[LineNumberTable(1754)]
		public override Spliterator spliterator()
		{
			Spliterator result = CollectSpliterators.map(multimap.entries().spliterator(), new ___003C_003EAnon0());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TK;>;)V")]
		[LineNumberTable(new byte[] { 166, 109, 103, 125 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			multimap.entries().forEach(new ___003C_003EAnon1(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1765)]
		internal override int distinctElements()
		{
			int result = multimap.asMap().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1770)]
		public override int size()
		{
			int result = multimap.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1775)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = multimap.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(1780)]
		public override Iterator iterator()
		{
			Iterator result = Maps.keyIterator(multimap.entries().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			166, 141, 108, 99, 170, 151, 99, 162, 103, 100,
			136, 103, 102, 103, 6, 230, 69
		})]
		public override int remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, int P_1)
		{
			CollectPreconditions.checkNonnegative(P_1, "occurrences");
			if (P_1 == 0)
			{
				int result = count(P_0);
				_ = null;
				return result;
			}
			Collection collection = (Collection)Maps.safeGet(multimap.asMap(), P_0);
			if (collection == null)
			{
				return 0;
			}
			int num = collection.size();
			if (P_1 >= num)
			{
				collection.clear();
			}
			else
			{
				Iterator iterator = collection.iterator();
				for (int i = 0; i < P_1; i++)
				{
					iterator.next();
					iterator.remove();
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 167, 109 })]
		public override void clear()
		{
			multimap.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(1822)]
		public override Set elementSet()
		{
			Set result = multimap.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(1827)]
		internal override Iterator elementIterator()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("should never be called");
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultimap<TK;TV;>;Lcom/google/common/collect/SetMultimap<TK;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 132, 0, 0,
		17, 1, 0, 0, 0, 132, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)132,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.SetMultimap", "java.io.Serializable" })]
	internal class MapMultimap : AbstractMultimap, SetMultimap, Multimap, Serializable.__Interface, ISerializable
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/Sets$ImprovedAbstractSet<TV;>;")]
		[EnclosingMethod(null, "get", "(Ljava.lang.Object;)Ljava.util.Set;")]
		internal class _1 : Sets.ImprovedAbstractSet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/lang/Object;Ljava/util/Iterator<TV;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			internal class _1 : java.lang.Object, Iterator
			{
				internal int i;

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal MapMultimap._1 this_00241;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(1156)]
				public virtual bool hasNext()
				{
					return (i == 0 && this_00241.this_00240.map.containsKey(this_00241.val_0024key)) ? true : false;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(1151)]
				internal _1(MapMultimap._1 P_0)
				{
					this_00241 = P_0;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()TV;")]
				[LineNumberTable(new byte[] { 164, 24, 104, 139, 238, 69 })]
				[ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})]
				public virtual object next()
				{
					if (!hasNext())
					{
						Throwable.___003CsuppressFillInStackTrace_003E();
						throw new NoSuchElementException();
					}
					i++;
					object result = NullnessCasts.uncheckedCastNullableTToT(this_00241.this_00240.map.get(this_00241.val_0024key));
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(new byte[] { 164, 37, 110, 103, 127, 2 })]
				public virtual void remove()
				{
					CollectPreconditions.checkRemove(i == 1);
					i = -1;
					this_00241.this_00240.map.remove(this_00241.val_0024key);
				}

				[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
				public virtual void forEachRemaining(Consumer P_0)
				{
					Iterator._003Cdefault_003EforEachRemaining(this, P_0);
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal object val_0024key;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal MapMultimap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1148)]
			internal _1(MapMultimap P_0, object P_1)
			{
				this_00240 = P_0;
				val_0024key = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<TV;>;")]
			[LineNumberTable(1151)]
			public override Iterator iterator()
			{
				_1 result = new _1(this);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1184)]
			public override int size()
			{
				return this_00240.map.containsKey(val_0024key) ? 1 : 0;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map map;

		private const long serialVersionUID = 7845222491160860175L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 240, 104, 113 })]
		internal MapMultimap(Map P_0)
		{
			map = (Map)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(1241)]
		public new virtual Set entries()
		{
			Set result = map.entrySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(1206)]
		public new virtual Set replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(1148)]
		public new virtual Set get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			_1 result = new _1(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(new byte[] { 164, 78, 103, 110, 130, 115 })]
		public new virtual Set removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			HashSet hashSet = new HashSet(2);
			if (!map.containsKey(P_0))
			{
				return hashSet;
			}
			((Set)hashSet).add(map.remove(P_0));
			return hashSet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1128)]
		public override int size()
		{
			int result = map.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1133)]
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
		[LineNumberTable(1138)]
		public override bool containsValue([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = map.containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1143)]
		public override bool containsEntry([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			bool result = map.entrySet().contains(Maps.immutableEntry(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Z")]
		[LineNumberTable(1191)]
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
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Z")]
		[LineNumberTable(1196)]
		public override bool putAll([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Z")]
		[LineNumberTable(1201)]
		public override bool putAll(Multimap P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1211)]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			bool result = map.entrySet().remove(Maps.immutableEntry(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 88, 109 })]
		public override void clear()
		{
			map.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(1231)]
		internal override Set createKeySet()
		{
			Set result = map.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(1236)]
		internal override Collection createValues()
		{
			Collection result = map.values();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(1246)]
		internal override Collection createEntries()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("unreachable");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
		[LineNumberTable(1251)]
		internal override Multiset createKeys()
		{
			Keys result = new Keys(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(1256)]
		internal override Iterator entryIterator()
		{
			Iterator result = map.entrySet().iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(1261)]
		internal override Map createAsMap()
		{
			AsMap result = new AsMap(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1266)]
		public override int hashCode()
		{
			int result = map.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1118)]
		public override Collection entries()
		{
			Set result = entries();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1118)]
		public override Collection replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Set result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1118)]
		public override Collection get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Set result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1118)]
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

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override void forEach(BiConsumer P_0)
		{
			Multimap._003Cdefault_003EforEach(this, P_0);
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
		protected MapMultimap(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>Lcom/google/common/collect/Multimaps$TransformedEntriesMultimap<TK;TV1;TV2;>;Lcom/google/common/collect/ListMultimap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 69, 0, 0,
		17, 1, 0, 0, 0, 69, 0, 0, 17, 2,
		0, 0, 0, 69, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)69,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.ListMultimap" })]
	internal sealed class TransformedEntriesListMultimap : TransformedEntriesMultimap, ListMultimap, Multimap
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ListMultimap<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)V")]
		[LineNumberTable(new byte[] { 165, 215, 106 })]
		internal TransformedEntriesListMultimap(ListMultimap P_0, Maps.EntryTransformer P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/Collection<TV1;>;)Ljava/util/List<TV2;>;")]
		[LineNumberTable(1614)]
		internal new virtual List transform([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Collection P_1)
		{
			List result = Lists.transform((List)P_1, Maps.asValueToValueFunction(transformer, P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV2;>;)Ljava/util/List<TV2;>;")]
		[LineNumberTable(1630)]
		public new virtual List replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/List<TV2;>;")]
		[LineNumberTable(1625)]
		public new virtual List removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			List result = transform(P_0, fromMultimap.removeAll(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/List<TV2;>;")]
		[LineNumberTable(1619)]
		public new virtual List get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			List result = transform(P_0, fromMultimap.get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1603)]
		public override Collection replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			List result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1603)]
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
		[LineNumberTable(1603)]
		public override Collection get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			List result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1603)]
		internal override Collection transform([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Collection P_1)
		{
			List result = transform(P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override void forEach(BiConsumer P_0)
		{
			Multimap._003Cdefault_003EforEach(this, P_0);
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
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultimap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 128, 0, 0,
		17, 1, 0, 0, 0, 128, 0, 0, 17, 2,
		0, 0, 0, 128, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)128,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class TransformedEntriesMultimap : AbstractMultimap
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/collect/Maps$EntryTransformer<TK;Ljava/util/Collection<TV1;>;Ljava/util/Collection<TV2;>;>;")]
		[EnclosingMethod(null, "createAsMap", "()Ljava.util.Map;")]
		internal class _1 : java.lang.Object, Maps.EntryTransformer
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TransformedEntriesMultimap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1510)]
			internal _1(TransformedEntriesMultimap P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;Ljava/util/Collection<TV1;>;)Ljava/util/Collection<TV2;>;")]
			[LineNumberTable(1513)]
			public virtual Collection transformEntry([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0, Collection P_1)
			{
				Collection result = this_00240.transform(P_0, P_1);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1510)]
			public virtual object transformEntry([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0, object P_1)
			{
				Collection result = transformEntry(P_0, (Collection)P_1);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multimap<TK;TV1;>;")]
		internal Multimap fromMultimap;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;")]
		internal Maps.EntryTransformer transformer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)V")]
		[LineNumberTable(new byte[] { 165, 98, 104, 113, 113 })]
		internal TransformedEntriesMultimap(Multimap P_0, Maps.EntryTransformer P_1)
		{
			fromMultimap = (Multimap)Preconditions.checkNotNull(P_0);
			transformer = (Maps.EntryTransformer)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/Collection<TV1;>;)Ljava/util/Collection<TV2;>;")]
		[LineNumberTable(new byte[] { 165, 104, 109, 104, 143 })]
		internal virtual Collection transform([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Collection P_1)
		{
			com.google.common.@base.Function function = Maps.asValueToValueFunction(transformer, P_0);
			if (P_1 is List)
			{
				List result = Lists.transform((List)P_1, function);
				_ = null;
				return result;
			}
			Collection result2 = Collections2.transform(P_1, function);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Collection<TV2;>;")]
		[LineNumberTable(1541)]
		public override Collection get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Collection result = transform(P_0, fromMultimap.get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV2;>;>;")]
		[LineNumberTable(new byte[] { 165, 114, 102, 43 })]
		internal override Map createAsMap()
		{
			Map result = Maps.transformEntries(fromMultimap.asMap(), new _1(this));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 126, 109 })]
		public override void clear()
		{
			fromMultimap.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1525)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = fromMultimap.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV2;>;>;")]
		[LineNumberTable(1530)]
		internal override Collection createEntries()
		{
			Entries result = new Entries(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV2;>;>;")]
		[LineNumberTable(new byte[] { 165, 141, 102, 53 })]
		internal override Iterator entryIterator()
		{
			Iterator result = Iterators.transform(fromMultimap.entries().iterator(), Maps.asEntryToEntryFunction(transformer));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1546)]
		public override bool isEmpty()
		{
			bool result = fromMultimap.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(1551)]
		internal override Set createKeySet()
		{
			Set result = fromMultimap.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
		[LineNumberTable(1556)]
		internal override Multiset createKeys()
		{
			Multiset result = fromMultimap.keys();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV2;)Z")]
		[LineNumberTable(1561)]
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
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV2;>;)Z")]
		[LineNumberTable(1566)]
		public override bool putAll([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV2;>;)Z")]
		[LineNumberTable(1571)]
		public override bool putAll(Multimap P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1577)]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			bool result = get(P_0).remove(P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV2;>;")]
		[LineNumberTable(1583)]
		public override Collection removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Collection result = transform(P_0, fromMultimap.removeAll(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV2;>;)Ljava/util/Collection<TV2;>;")]
		[LineNumberTable(1588)]
		public override Collection replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1593)]
		public override int size()
		{
			int result = fromMultimap.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV2;>;")]
		[LineNumberTable(new byte[] { 165, 204, 102, 48 })]
		internal override Collection createValues()
		{
			Collection result = Collections2.transform(fromMultimap.entries(), Maps.asEntryToValueFunction(transformer));
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Multimaps$UnmodifiableMultimap<TK;TV;>;Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 63, 0, 0,
		17, 1, 0, 0, 0, 63, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)63,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.ListMultimap" })]
	internal class UnmodifiableListMultimap : UnmodifiableMultimap, ListMultimap, Multimap
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ListMultimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 155, 105 })]
		internal UnmodifiableListMultimap(ListMultimap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
		[LineNumberTable(786)]
		public new virtual ListMultimap @delegate()
		{
			return (ListMultimap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/List<TV;>;")]
		[LineNumberTable(801)]
		public new virtual List replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/List<TV;>;")]
		[LineNumberTable(796)]
		public new virtual List removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/List<TV;>;")]
		[LineNumberTable(791)]
		public new virtual List get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			List result = Collections.unmodifiableList(@delegate().get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(777)]
		public override Collection replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			List result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(777)]
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
		[LineNumberTable(777)]
		public override Collection get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			List result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(777)]
		public override Multimap @delegate()
		{
			ListMultimap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(777)]
		public override object @delegate()
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
		protected UnmodifiableListMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMultimap<TK;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 132, 0, 0,
		17, 1, 0, 0, 0, 132, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)132,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class UnmodifiableMultimap : ForwardingMultimap, Serializable.__Interface, ISerializable
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Collection<TV;>;Ljava/util/Collection<TV;>;>;")]
		[EnclosingMethod(null, "asMap", "()Ljava.util.Map;")]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(688)]
			internal _1(UnmodifiableMultimap P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<TV;>;)Ljava/util/Collection<TV;>;")]
			[LineNumberTable(691)]
			public virtual Collection apply(Collection P_0)
			{
				Collection result = access_0024000(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(688)]
			public virtual object apply(object P_0)
			{
				Collection result = apply((Collection)P_0);
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

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multimap<TK;TV;>;")]
		internal new Multimap @delegate;

		[NonSerialized]
		[Signature("Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new Collection entries;

		[NonSerialized]
		[Signature("Lcom/google/common/collect/Multiset<TK;>;")]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new Multiset keys;

		[NonSerialized]
		[Signature("Ljava/util/Set<TK;>;")]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new Set keySet;

		[NonSerialized]
		[Signature("Ljava/util/Collection<TV;>;")]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new Collection values;

		[NonSerialized]
		[Signature("Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[LazyInit(new object[]
		{
			(byte)64,
			"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Map map;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 39, 104, 113 })]
		internal UnmodifiableMultimap(Multimap P_0)
		{
			this.@delegate = (Multimap)Preconditions.checkNotNull(P_0);
		}

		[Signature("()Lcom/google/common/collect/Multimap<TK;TV;>;")]
		protected internal override Multimap @delegate()
		{
			return this.@delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(676)]
		public override void clear()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 55, 103, 99, 199, 43, 37, 240, 74 })]
		public override Map asMap()
		{
			Map map = this.map;
			if (map == null)
			{
				Map map2 = Collections.unmodifiableMap(Maps.transformValues(this.@delegate.asMap(), new _1(this)));
				this.map = map2;
				map = map2;
			}
			return map;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 74, 103, 99, 152 })]
		public override Collection entries()
		{
			Collection collection = this.entries;
			if (collection == null)
			{
				collection = (this.entries = access_0024100(this.@delegate.entries()));
			}
			return collection;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 83, 120 })]
		public override void forEach(BiConsumer P_0)
		{
			this.@delegate.forEach((BiConsumer)Preconditions.checkNotNull(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(714)]
		public override Collection get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Collection result = access_0024000(this.@delegate.get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
		[LineNumberTable(new byte[] { 162, 93, 103, 99, 152 })]
		public override Multiset keys()
		{
			Multiset multiset = this.keys;
			if (multiset == null)
			{
				multiset = (this.keys = Multisets.unmodifiableMultiset(this.@delegate.keys()));
			}
			return multiset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(new byte[] { 162, 102, 103, 99, 152 })]
		public override Set keySet()
		{
			Set set = this.keySet;
			if (set == null)
			{
				set = (this.keySet = Collections.unmodifiableSet(this.@delegate.keySet()));
			}
			return set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Z")]
		[LineNumberTable(737)]
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
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Z")]
		[LineNumberTable(742)]
		public override bool putAll([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Z")]
		[LineNumberTable(747)]
		public override bool putAll(Multimap P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(752)]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(757)]
		public override Collection removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Collection<TV;>;")]
		[LineNumberTable(762)]
		public override Collection replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 162, 141, 103, 99, 152 })]
		public override Collection values()
		{
			Collection collection = this.values;
			if (collection == null)
			{
				collection = (this.values = Collections.unmodifiableCollection(this.@delegate.values()));
			}
			return collection;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(656)]
		protected internal new virtual object @delegate()
		{
			Multimap result = this.@delegate();
			_ = null;
			return result;
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
		protected UnmodifiableMultimap(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Multimaps$UnmodifiableMultimap<TK;TV;>;Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 72, 0, 0,
		17, 1, 0, 0, 0, 72, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)72,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.SetMultimap" })]
	internal class UnmodifiableSetMultimap : UnmodifiableMultimap, SetMultimap, Multimap
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/SetMultimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 185, 105 })]
		internal UnmodifiableSetMultimap(SetMultimap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
		[LineNumberTable(816)]
		public new virtual SetMultimap @delegate()
		{
			return (SetMultimap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(840)]
		public new virtual Set replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(835)]
		public new virtual Set removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Set<TV;>;")]
		[LineNumberTable(825)]
		public new virtual Set get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Set result = Collections.unmodifiableSet(@delegate().get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(830)]
		public new virtual Set entries()
		{
			Set result = Maps.unmodifiableEntrySet(@delegate().entries());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(807)]
		public override Collection replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Set result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(807)]
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
		[LineNumberTable(807)]
		public override Collection get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Set result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(807)]
		public override Collection entries()
		{
			Set result = entries();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(807)]
		public override Multimap @delegate()
		{
			SetMultimap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(807)]
		public override object @delegate()
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
		protected UnmodifiableSetMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Multimaps$UnmodifiableSetMultimap<TK;TV;>;Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 71, 0, 0,
		17, 1, 0, 0, 0, 71, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)71,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.SortedSetMultimap" })]
	internal class UnmodifiableSortedSetMultimap : UnmodifiableSetMultimap, SortedSetMultimap, SetMultimap, Multimap
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 224, 105 })]
		internal UnmodifiableSortedSetMultimap(SortedSetMultimap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
		[LineNumberTable(855)]
		public new virtual SortedSetMultimap @delegate()
		{
			return (SortedSetMultimap)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(870)]
		public new virtual SortedSet replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(865)]
		public new virtual SortedSet removeAll([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(860)]
		public new virtual SortedSet get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = Collections.unmodifiableSortedSet(@delegate().get(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TV;>;")]
		[LineNumberTable(876)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator valueComparator()
		{
			Comparator result = @delegate().valueComparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(846)]
		public override Set replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			SortedSet result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(846)]
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
		[LineNumberTable(846)]
		public override Set get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(846)]
		public override SetMultimap @delegate()
		{
			SortedSetMultimap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(846)]
		public override Collection get([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(846)]
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
		[LineNumberTable(846)]
		public override Collection replaceValues([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, Iterable P_1)
		{
			SortedSet result = replaceValues(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(846)]
		public override Multimap @delegate()
		{
			SortedSetMultimap result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(846)]
		public override object @delegate()
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
			return ((UnmodifiableSetMultimap)this).entries();
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
		protected UnmodifiableSortedSetMultimap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multimap<**>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 168, 83, 100, 130, 104, 103, 148 })]
	internal static bool equalsImpl(Multimap P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_1 == P_0)
		{
			return true;
		}
		if (P_1 is Multimap)
		{
			Multimap multimap = (Multimap)P_1;
			bool result = P_0.asMap().equals(multimap.asMap());
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<TV;>;Lcom/google/common/base/Function<-TV;TK;>;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(1671)]
	public static ImmutableListMultimap index(Iterable values, com.google.common.@base.Function keyFunction)
	{
		ImmutableListMultimap result = index(values.iterator(), keyFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/List<TV;>;>;)Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(327)]
	public static ListMultimap newListMultimap(Map map, com.google.common.@base.Supplier factory)
	{
		CustomListMultimap result = new CustomListMultimap(map, factory);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/Set<TV;>;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(407)]
	public static SetMultimap newSetMultimap(Map map, com.google.common.@base.Supplier factory)
	{
		CustomSetMultimap result = new CustomSetMultimap(map, factory);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/SortedSet<TV;>;>;)Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(510)]
	public static SortedSetMultimap newSortedSetMultimap(Map map, com.google.common.@base.Supplier factory)
	{
		CustomSortedSetMultimap result = new CustomSortedSetMultimap(map, factory);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 163, 155, 104, 142 })]
	private static Collection unmodifiableEntries(Collection P_0)
	{
		if (P_0 is Set)
		{
			Set result = Maps.unmodifiableEntrySet((Set)P_0);
			_ = null;
			return result;
		}
		Maps.UnmodifiableEntries result2 = new Maps.UnmodifiableEntries(Collections.unmodifiableCollection(P_0));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/Collection<TV;>;)Ljava/util/Collection<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 144, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 135, 104, 110, 104, 110, 104, 142 })]
	private static Collection unmodifiableValueCollection(Collection P_0)
	{
		if (P_0 is SortedSet)
		{
			SortedSet result = Collections.unmodifiableSortedSet((SortedSet)P_0);
			_ = null;
			return result;
		}
		if (P_0 is Set)
		{
			Set result2 = Collections.unmodifiableSet((Set)P_0);
			_ = null;
			return result2;
		}
		if (P_0 is List)
		{
			List result3 = Collections.unmodifiableList((List)P_0);
			_ = null;
			return result3;
		}
		Collection result4 = Collections.unmodifiableCollection(P_0);
		_ = null;
		return result4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)Lcom/google/common/collect/Multimap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0, 18, 2,
		0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(1426)]
	public static Multimap transformEntries(Multimap fromMap, Maps.EntryTransformer transformer)
	{
		TransformedEntriesMultimap result = new TransformedEntriesMultimap(fromMap, transformer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/collect/ListMultimap<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)Lcom/google/common/collect/ListMultimap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0, 18, 2,
		0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(1481)]
	public static ListMultimap transformEntries(ListMultimap fromMap, Maps.EntryTransformer transformer)
	{
		TransformedEntriesListMultimap result = new TransformedEntriesListMultimap(fromMap, transformer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Iterator<TV;>;Lcom/google/common/base/Function<-TV;TK;>;)Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 166, 62, 103, 102, 104, 103, 104, 111, 98 })]
	public static ImmutableListMultimap index(Iterator values, com.google.common.@base.Function keyFunction)
	{
		Preconditions.checkNotNull(keyFunction);
		ImmutableListMultimap.Builder builder = ImmutableListMultimap.builder();
		while (values.hasNext())
		{
			object obj = values.next();
			Preconditions.checkNotNull(obj, values);
			builder.put(keyFunction.apply(obj), obj);
		}
		ImmutableListMultimap result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SetMultimap<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 167, 122, 104, 103, 97, 56, 129, 104, 103, 143 })]
	public static SetMultimap filterKeys(SetMultimap unfiltered, com.google.common.@base.Predicate keyPredicate)
	{
		if (unfiltered is FilteredKeySetMultimap)
		{
			FilteredKeySetMultimap filteredKeySetMultimap = (FilteredKeySetMultimap)unfiltered;
			FilteredKeySetMultimap result = new FilteredKeySetMultimap(filteredKeySetMultimap.unfiltered(), Predicates.and(filteredKeySetMultimap.keyPredicate, keyPredicate));
			_ = null;
			return result;
		}
		if (unfiltered is FilteredSetMultimap)
		{
			FilteredSetMultimap filteredSetMultimap = (FilteredSetMultimap)unfiltered;
			SetMultimap result2 = filterFiltered(filteredSetMultimap, Maps.keyPredicateOnEntries(keyPredicate));
			_ = null;
			return result2;
		}
		FilteredKeySetMultimap result3 = new FilteredKeySetMultimap(unfiltered, keyPredicate);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ListMultimap<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 167, 164, 104, 103, 97, 56, 161 })]
	public static ListMultimap filterKeys(ListMultimap unfiltered, com.google.common.@base.Predicate keyPredicate)
	{
		if (unfiltered is FilteredKeyListMultimap)
		{
			FilteredKeyListMultimap filteredKeyListMultimap = (FilteredKeyListMultimap)unfiltered;
			FilteredKeyListMultimap result = new FilteredKeyListMultimap(filteredKeyListMultimap.unfiltered(), Predicates.and(filteredKeyListMultimap.keyPredicate, keyPredicate));
			_ = null;
			return result;
		}
		FilteredKeyListMultimap result2 = new FilteredKeyListMultimap(unfiltered, keyPredicate);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/FilteredMultimap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 168, 63, 97, 108 })]
	private static Multimap filterFiltered(FilteredMultimap P_0, com.google.common.@base.Predicate P_1)
	{
		com.google.common.@base.Predicate predicate = Predicates.and(P_0.entryPredicate(), P_1);
		FilteredEntryMultimap result = new FilteredEntryMultimap(P_0.unfiltered(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/FilteredSetMultimap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 168, 77, 97, 108 })]
	private static SetMultimap filterFiltered(FilteredSetMultimap P_0, com.google.common.@base.Predicate P_1)
	{
		com.google.common.@base.Predicate predicate = Predicates.and(P_0.entryPredicate(), P_1);
		FilteredEntrySetMultimap result = new FilteredEntrySetMultimap(P_0.unfiltered(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 168, 11, 103, 104, 143, 104, 110, 17 })]
	public static Multimap filterEntries(Multimap unfiltered, com.google.common.@base.Predicate entryPredicate)
	{
		Preconditions.checkNotNull(entryPredicate);
		if (unfiltered is SetMultimap)
		{
			SetMultimap result = filterEntries((SetMultimap)unfiltered, entryPredicate);
			_ = null;
			return result;
		}
		Multimap obj = ((!(unfiltered is FilteredMultimap)) ? new FilteredEntryMultimap((Multimap)Preconditions.checkNotNull(unfiltered), entryPredicate) : filterFiltered((FilteredMultimap)unfiltered, entryPredicate));
		Multimap result2 = ((obj == null) ? null : ((obj as Multimap) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SetMultimap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 168, 48, 103, 104, 110, 17 })]
	public static SetMultimap filterEntries(SetMultimap unfiltered, com.google.common.@base.Predicate entryPredicate)
	{
		Preconditions.checkNotNull(entryPredicate);
		SetMultimap obj = ((!(unfiltered is FilteredSetMultimap)) ? new FilteredEntrySetMultimap((SetMultimap)Preconditions.checkNotNull(unfiltered), entryPredicate) : filterFiltered((FilteredSetMultimap)unfiltered, entryPredicate));
		SetMultimap result = ((obj == null) ? null : ((obj as SetMultimap) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	private Multimaps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;M::Lcom/google/common/collect/Multimap<TK;TV;>;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/Supplier<TM;>;)Ljava/util/stream/Collector<TT;*TM;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0, 18, 2,
		0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(125)]
	public static Collector toMultimap(java.util.function.Function keyFunction, java.util.function.Function valueFunction, java.util.function.Supplier multimapSupplier)
	{
		Collector result = CollectCollectors.toMultimap(keyFunction, valueFunction, multimapSupplier);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;M::Lcom/google/common/collect/Multimap<TK;TV;>;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+Ljava/util/stream/Stream<+TV;>;>;Ljava/util/function/Supplier<TM;>;)Ljava/util/stream/Collector<TT;*TM;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0, 18, 2,
		0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(171)]
	public static Collector flatteningToMultimap(java.util.function.Function keyFunction, java.util.function.Function valueFunction, java.util.function.Supplier multimapSupplier)
	{
		Collector result = CollectCollectors.flatteningToMultimap(keyFunction, valueFunction, multimapSupplier);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/Collection<TV;>;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(212)]
	public static Multimap newMultimap(Map map, com.google.common.@base.Supplier factory)
	{
		CustomMultimap result = new CustomMultimap(map, factory);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;M::Lcom/google/common/collect/Multimap<TK;TV;>;>(Lcom/google/common/collect/Multimap<+TV;+TK;>;TM;)TM;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 212, 103, 127, 1, 115, 98 })]
	public static Multimap invertFrom(Multimap source, Multimap dest)
	{
		Preconditions.checkNotNull(dest);
		Iterator iterator = source.entries().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			dest.put(entry.getValue(), entry.getKey());
		}
		return dest;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(623)]
	public static Multimap synchronizedMultimap(Multimap multimap)
	{
		Multimap result = Synchronized.multimap(multimap, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 162, 13, 112, 130 })]
	public static Multimap unmodifiableMultimap(Multimap @delegate)
	{
		if (@delegate is UnmodifiableMultimap || @delegate is ImmutableMultimap)
		{
			return @delegate;
		}
		UnmodifiableMultimap result = new UnmodifiableMultimap(@delegate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[LineNumberTable(653)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Multimap unmodifiableMultimap(ImmutableMultimap @delegate)
	{
		return (Multimap)Preconditions.checkNotNull(@delegate);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SetMultimap<TK;TV;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(894)]
	public static SetMultimap synchronizedSetMultimap(SetMultimap multimap)
	{
		SetMultimap result = Synchronized.setMultimap(multimap, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SetMultimap<TK;TV;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 163, 28, 112, 130 })]
	public static SetMultimap unmodifiableSetMultimap(SetMultimap @delegate)
	{
		if (@delegate is UnmodifiableSetMultimap || @delegate is ImmutableSetMultimap)
		{
			return @delegate;
		}
		UnmodifiableSetMultimap result = new UnmodifiableSetMultimap(@delegate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[LineNumberTable(925)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static SetMultimap unmodifiableSetMultimap(ImmutableSetMultimap @delegate)
	{
		return (SetMultimap)Preconditions.checkNotNull(@delegate);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;)Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(941)]
	public static SortedSetMultimap synchronizedSortedSetMultimap(SortedSetMultimap multimap)
	{
		SortedSetMultimap result = Synchronized.sortedSetMultimap(multimap, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;)Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 163, 75, 104, 130 })]
	public static SortedSetMultimap unmodifiableSortedSetMultimap(SortedSetMultimap @delegate)
	{
		if (@delegate is UnmodifiableSortedSetMultimap)
		{
			return @delegate;
		}
		UnmodifiableSortedSetMultimap result = new UnmodifiableSortedSetMultimap(@delegate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ListMultimap<TK;TV;>;)Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(973)]
	public static ListMultimap synchronizedListMultimap(ListMultimap multimap)
	{
		ListMultimap result = Synchronized.listMultimap(multimap, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ListMultimap<TK;TV;>;)Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 163, 107, 112, 130 })]
	public static ListMultimap unmodifiableListMultimap(ListMultimap @delegate)
	{
		if (@delegate is UnmodifiableListMultimap || @delegate is ImmutableListMultimap)
		{
			return @delegate;
		}
		UnmodifiableListMultimap result = new UnmodifiableListMultimap(@delegate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;)Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[LineNumberTable(1004)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static ListMultimap unmodifiableListMultimap(ImmutableListMultimap @delegate)
	{
		return (ListMultimap)Preconditions.checkNotNull(@delegate);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ListMultimap<TK;TV;>;)Ljava/util/Map<TK;Ljava/util/List<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(1054)]
	public static Map asMap(ListMultimap multimap)
	{
		Map result = multimap.asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SetMultimap<TK;TV;>;)Ljava/util/Map<TK;Ljava/util/Set<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(1068)]
	public static Map asMap(SetMultimap multimap)
	{
		Map result = multimap.asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;)Ljava/util/Map<TK;Ljava/util/SortedSet<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(1082)]
	public static Map asMap(SortedSetMultimap multimap)
	{
		Map result = multimap.asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;)Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(1094)]
	public static Map asMap(Multimap multimap)
	{
		Map result = multimap.asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(1114)]
	public static SetMultimap forMap(Map map)
	{
		MapMultimap result = new MapMultimap(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV1;>;Lcom/google/common/base/Function<-TV1;TV2;>;)Lcom/google/common/collect/Multimap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0, 18, 2,
		0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 164, 179, 103, 103 })]
	public static Multimap transformValues(Multimap fromMultimap, com.google.common.@base.Function function)
	{
		Preconditions.checkNotNull(function);
		Maps.EntryTransformer transformer = Maps.asEntryTransformer(function);
		Multimap result = transformEntries(fromMultimap, transformer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/collect/ListMultimap<TK;TV1;>;Lcom/google/common/base/Function<-TV1;TV2;>;)Lcom/google/common/collect/ListMultimap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0, 18, 2,
		0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[] { 164, 228, 103, 103 })]
	public static ListMultimap transformValues(ListMultimap fromMultimap, com.google.common.@base.Function function)
	{
		Preconditions.checkNotNull(function);
		Maps.EntryTransformer transformer = Maps.asEntryTransformer(function);
		ListMultimap result = transformEntries(fromMultimap, transformer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		167, 76, 104, 111, 104, 111, 104, 103, 109, 44,
		129, 104, 103, 143
	})]
	public static Multimap filterKeys(Multimap unfiltered, com.google.common.@base.Predicate keyPredicate)
	{
		if (unfiltered is SetMultimap)
		{
			SetMultimap result = filterKeys((SetMultimap)unfiltered, keyPredicate);
			_ = null;
			return result;
		}
		if (unfiltered is ListMultimap)
		{
			ListMultimap result2 = filterKeys((ListMultimap)unfiltered, keyPredicate);
			_ = null;
			return result2;
		}
		if (unfiltered is FilteredKeyMultimap)
		{
			FilteredKeyMultimap filteredKeyMultimap = (FilteredKeyMultimap)unfiltered;
			FilteredKeyMultimap result3 = new FilteredKeyMultimap(filteredKeyMultimap.unfiltered, Predicates.and(filteredKeyMultimap.keyPredicate, keyPredicate));
			_ = null;
			return result3;
		}
		if (unfiltered is FilteredMultimap)
		{
			FilteredMultimap filteredMultimap = (FilteredMultimap)unfiltered;
			Multimap result4 = filterFiltered(filteredMultimap, Maps.keyPredicateOnEntries(keyPredicate));
			_ = null;
			return result4;
		}
		FilteredKeyMultimap result5 = new FilteredKeyMultimap(unfiltered, keyPredicate);
		_ = null;
		return result5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<TK;TV;>;Lcom/google/common/base/Predicate<-TV;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(2109)]
	public static Multimap filterValues(Multimap unfiltered, com.google.common.@base.Predicate valuePredicate)
	{
		Multimap result = filterEntries(unfiltered, Maps.valuePredicateOnEntries(valuePredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/SetMultimap<TK;TV;>;Lcom/google/common/base/Predicate<-TV;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 144, 0, 0,
		18, 1, 0, 0, 0, 144, 0, 0
	})]
	[LineNumberTable(2142)]
	public static SetMultimap filterValues(SetMultimap unfiltered, com.google.common.@base.Predicate valuePredicate)
	{
		SetMultimap result = filterEntries(unfiltered, Maps.valuePredicateOnEntries(valuePredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static Collection access_0024000(Collection P_0)
	{
		Collection result = unmodifiableValueCollection(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(77)]
	internal static Collection access_0024100(Collection P_0)
	{
		Collection result = unmodifiableEntries(P_0);
		_ = null;
		return result;
	}
}
