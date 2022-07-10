using System;
using System.ComponentModel;
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
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$IteratorBasedAbstractMap<TK;TV;>;Lcom/google/common/collect/BiMap<TK;TV;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 94, 0, 0,
	17, 1, 0, 0, 0, 94, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)94,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.BiMap", "java.io.Serializable" })]
public sealed class HashBiMap : Maps.IteratorBasedAbstractMap, BiMap, Map, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/HashBiMap<TK;TV;>.Itr<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
	internal new class _1 : Itr
	{
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/AbstractMapEntry<TK;TV;>;")]
		internal class MapEntry : AbstractMapEntry
		{
			[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
			internal BiEntry @delegate;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _1 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)V")]
			[LineNumberTable(new byte[] { 161, 159, 111, 103 })]
			internal MapEntry(_1 P_0, BiEntry P_1)
			{
				this_00241 = P_0;
				base._002Ector();
				@delegate = P_1;
			}

			[Signature("()TK;")]
			[LineNumberTable(536)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public override object getKey()
			{
				return @delegate.key;
			}

			[Signature("()TV;")]
			[LineNumberTable(542)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public override object getValue()
			{
				return @delegate.value;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TV;)TV;")]
			[LineNumberTable(new byte[]
			{
				161, 178, 108, 103, 119, 130, 127, 4, 118, 126,
				119, 108, 108, 123, 115, 140, 103
			})]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public override object setValue([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				object value = @delegate.value;
				int num = Hashing.smearedHash(P_0);
				if (num == @delegate.valueHash && com.google.common.@base.Objects.equal(P_0, value))
				{
					return P_0;
				}
				Preconditions.checkArgument(access_0024400(this_00241.this_00240, P_0, num) == null, "value already present: %s", P_0);
				access_0024200(this_00241.this_00240, @delegate);
				BiEntry biEntry = new BiEntry(@delegate.key, @delegate.keyHash, P_0, num);
				access_0024500(this_00241.this_00240, biEntry, @delegate);
				@delegate.prevInKeyInsertionOrder = null;
				@delegate.nextInKeyInsertionOrder = null;
				this_00241.expectedModCount = access_0024100(this_00241.this_00240);
				if (this_00241.toRemove == @delegate)
				{
					this_00241.toRemove = biEntry;
				}
				@delegate = biEntry;
				return value;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new HashBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(523)]
		internal new virtual Map.Entry output(BiEntry P_0)
		{
			MapEntry result = new MapEntry(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(520)]
		internal _1(HashBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(520)]
		internal override object output(BiEntry P_0)
		{
			Map.Entry result = output(P_0);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 41, 0, 0,
		17, 1, 0, 0, 0, 41, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)41,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class BiEntry : ImmutableEntry
	{
		[Modifiers(Modifiers.Final)]
		internal int keyHash;

		[Modifiers(Modifiers.Final)]
		internal int valueHash;

		[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal BiEntry nextInKToVBucket;

		[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal BiEntry nextInVToKBucket;

		[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal BiEntry nextInKeyInsertionOrder;

		[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal BiEntry prevInKeyInsertionOrder;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ITV;I)V")]
		[LineNumberTable(new byte[] { 59, 106, 103, 104 })]
		internal BiEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2, int P_3)
			: base(P_0, P_2)
		{
			keyHash = P_1;
			valueHash = P_3;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected BiEntry(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Maps$IteratorBasedAbstractMap<TV;TK;>;Lcom/google/common/collect/BiMap<TV;TK;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "com.google.common.collect.BiMap", "java.io.Serializable" })]
	internal sealed class Inverse : Maps.IteratorBasedAbstractMap, BiMap, Map, Serializable.__Interface, ISerializable
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/HashBiMap<TK;TV;>.Itr<Ljava/util/Map$Entry<TV;TK;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal new class _1 : Itr
		{
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/AbstractMapEntry<TV;TK;>;")]
			internal class InverseEntry : AbstractMapEntry
			{
				[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
				internal BiEntry @delegate;

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal _1 this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)V")]
				[LineNumberTable(new byte[] { 162, 80, 111, 103 })]
				internal InverseEntry(_1 P_0, BiEntry P_1)
				{
					this_00242 = P_0;
					base._002Ector();
					@delegate = P_1;
				}

				[Signature("()TV;")]
				[LineNumberTable(713)]
				[ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})]
				public override object getKey()
				{
					return @delegate.value;
				}

				[Signature("()TK;")]
				[LineNumberTable(719)]
				[ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})]
				public override object getValue()
				{
					return @delegate.key;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(TK;)TK;")]
				[LineNumberTable(new byte[]
				{
					162, 99, 108, 103, 119, 130, 127, 9, 123, 158,
					103, 119, 127, 1
				})]
				[ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})]
				public override object setValue([ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})] object P_0)
				{
					object key = @delegate.key;
					int num = Hashing.smearedHash(P_0);
					if (num == @delegate.keyHash && com.google.common.@base.Objects.equal(P_0, key))
					{
						return P_0;
					}
					Preconditions.checkArgument(access_0024300(this_00242.this_00241.this_00240, P_0, num) == null, "value already present: %s", P_0);
					access_0024200(this_00242.this_00241.this_00240, @delegate);
					BiEntry biEntry = (@delegate = new BiEntry(P_0, num, @delegate.value, @delegate.valueHash));
					access_0024500(this_00242.this_00241.this_00240, biEntry, null);
					this_00242.expectedModCount = access_0024100(this_00242.this_00241.this_00240);
					return key;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Inverse this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)Ljava/util/Map$Entry<TV;TK;>;")]
			[LineNumberTable(700)]
			internal new virtual Map.Entry output(BiEntry P_0)
			{
				InverseEntry result = new InverseEntry(this, P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(697)]
			internal _1(Inverse P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0.this_00240);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(697)]
			internal override object output(BiEntry P_0)
			{
				Map.Entry result = output(P_0);
				_ = null;
				return result;
			}
		}

		[InnerClass(null, Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Maps$KeySet<TV;TK;>;")]
		internal sealed class InverseKeySet : Maps.KeySet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/HashBiMap<TK;TV;>.Itr<TV;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			internal class _1 : Itr
			{
				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(680)]
				internal _1(InverseKeySet P_0)
					: base(P_0.this_00241.this_00240)
				{
				}

				[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)TV;")]
				[LineNumberTable(684)]
				[ParametricNullness(new object[]
				{
					(byte)64,
					"Lcom/google/common/collect/ParametricNullness;"
				})]
				internal override object output(BiEntry P_0)
				{
					return P_0.value;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Inverse this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 37, 103, 105 })]
			internal InverseKeySet(Inverse P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 43, 120, 99, 130, 113 })]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				BiEntry biEntry = access_0024400(this_00241.this_00240, P_0, Hashing.smearedHash(P_0));
				if (biEntry == null)
				{
					return false;
				}
				access_0024200(this_00241.this_00240, biEntry);
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<TV;>;")]
			[LineNumberTable(680)]
			public override Iterator iterator()
			{
				_1 result = new _1(this);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiConsumer
		{
			private readonly BiConsumer arg_00241;

			internal ___003C_003EAnon0(BiConsumer P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0, object P_1)
			{
				lambda_0024forEach_00240(arg_00241, P_0, P_1);
				_ = null;
			}

			[SpecialName]
			public BiConsumer andThen(BiConsumer P_0)
			{
				return BiConsumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal HashBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(598)]
		internal Inverse(HashBiMap P_0, HashBiMap._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(598)]
		private Inverse(HashBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[Signature("()Lcom/google/common/collect/BiMap<TK;TV;>;")]
		internal virtual BiMap forward()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 241, 109 })]
		public override void clear()
		{
			forward().clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;TK;)TK;")]
		[LineNumberTable(629)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			object result = access_0024800(this_00240, P_0, P_1, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(692)]
		public new virtual Set values()
		{
			Set result = forward().keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(746)]
		private static void lambda_0024forEach_00240(BiConsumer P_0, object P_1, object P_2)
		{
			P_0.accept(P_2, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(606)]
		public override int size()
		{
			int result = access_0024700(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(616)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = forward().containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TK;")]
		[LineNumberTable(622)]
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
			object result = Maps.keyOrNull(access_0024400(this_00240, P_0, Hashing.smearedHash(P_0)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;TK;)TK;")]
		[LineNumberTable(635)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object forcePut([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			object result = access_0024800(this_00240, P_0, P_1, true);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TK;")]
		[LineNumberTable(new byte[] { 162, 15, 115, 99, 130, 108, 103, 103 })]
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
			BiEntry biEntry = access_0024400(this_00240, P_0, Hashing.smearedHash(P_0));
			if (biEntry == null)
			{
				return null;
			}
			access_0024200(this_00240, biEntry);
			biEntry.prevInKeyInsertionOrder = null;
			biEntry.nextInKeyInsertionOrder = null;
			return biEntry.key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/BiMap<TK;TV;>;")]
		[LineNumberTable(654)]
		public virtual BiMap inverse()
		{
			BiMap result = forward();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(659)]
		public override Set keySet()
		{
			InverseKeySet result = new InverseKeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TV;TK;>;>;")]
		[LineNumberTable(697)]
		internal override Iterator entryIterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiConsumer<-TV;-TK;>;)V")]
		[LineNumberTable(new byte[] { 162, 119, 103, 120 })]
		public override void forEach(BiConsumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			this_00240.forEach(new ___003C_003EAnon0(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiFunction<-TV;-TK;+TK;>;)V")]
		[LineNumberTable(new byte[] { 162, 125, 103, 108, 102, 101, 63, 0, 169 })]
		public override void replaceAll(BiFunction P_0)
		{
			Preconditions.checkNotNull(P_0);
			BiEntry biEntry = access_0024000(this_00240);
			clear();
			for (BiEntry biEntry2 = biEntry; biEntry2 != null; biEntry2 = biEntry2.nextInKeyInsertionOrder)
			{
				put(biEntry2.value, P_0.apply(biEntry2.value, biEntry2.key));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(760)]
		internal virtual object writeReplace()
		{
			InverseSerializedForm result = new InverseSerializedForm(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(598)]
		public override Collection values()
		{
			Set result = values();
			_ = null;
			return result;
		}

		void BiMap.BiMap_003A_003AputAll(Map P_0)
		{
			putAll(P_0);
		}

		Collection BiMap.BiMap_003A_003Avalues()
		{
			return this.values();
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

		bool Map.Map_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Map.Map_003A_003AhashCode()
		{
			return hashCode();
		}

		object Map.Map_003A_003AgetOrDefault(object P_0, object P_1)
		{
			return getOrDefault(P_0, P_1);
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

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Inverse(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 29, 0, 0,
		17, 1, 0, 0, 0, 29, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)29,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class InverseSerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/HashBiMap<TK;TV;>;")]
		private HashBiMap bimap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/HashBiMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 143, 104, 103 })]
		internal InverseSerializedForm(HashBiMap P_0)
		{
			bimap = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(774)]
		internal virtual object readResolve()
		{
			BiMap result = bimap.inverse();
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
		protected InverseSerializedForm(SerializationInfo P_0, StreamingContext P_1)
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

	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 65, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)65,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class Itr : java.lang.Object, Iterator
	{
		[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal BiEntry next;

		[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal BiEntry toRemove;

		internal int expectedModCount;

		internal int remaining;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal HashBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 72, 115, 139 })]
		public virtual bool hasNext()
		{
			if (access_0024100(this_00240) != expectedModCount)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
			return (this.next != null && remaining > 0) ? true : false;
		}

		[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)TT;")]
		internal abstract object output(BiEntry P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 64, 111, 113, 103, 113 })]
		internal Itr(HashBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			this.next = access_0024000(this_00240);
			toRemove = null;
			expectedModCount = access_0024100(this_00240);
			remaining = this_00240.size();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 161, 80, 104, 203, 113, 108, 103, 110 })]
		public virtual object next()
		{
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			BiEntry biEntry = (BiEntry)java.util.Objects.requireNonNull(this.next);
			this.next = biEntry.nextInKeyInsertionOrder;
			toRemove = biEntry;
			remaining--;
			object result = output(biEntry);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 94, 115, 139, 104, 144, 113, 113, 103 })]
		public virtual void remove()
		{
			if (access_0024100(this_00240) != expectedModCount)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
			if (toRemove == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("no calls to next() since the last call to remove()");
			}
			access_0024200(this_00240, toRemove);
			expectedModCount = access_0024100(this_00240);
			toRemove = null;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Maps$KeySet<TK;TV;>;")]
	internal sealed class KeySet : Maps.KeySet
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/HashBiMap<TK;TV;>.Itr<TK;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : Itr
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(490)]
			internal _1(KeySet P_0)
				: base(P_0.this_00240)
			{
			}

			[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)TK;")]
			[LineNumberTable(494)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			internal override object output(BiEntry P_0)
			{
				return P_0.key;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal HashBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 114, 103, 105 })]
		internal KeySet(HashBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(490)]
		public override Iterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 131, 115, 99, 130, 108, 103, 103 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			BiEntry biEntry = access_0024300(this_00240, P_0, Hashing.smearedHash(P_0));
			if (biEntry == null)
			{
				return false;
			}
			access_0024200(this_00240, biEntry);
			biEntry.prevInKeyInsertionOrder = null;
			biEntry.nextInKeyInsertionOrder = null;
			return true;
		}
	}

	private const double LOAD_FACTOR = 1.0;

	[NonSerialized]
	[Signature("[Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 94, 0, 0 })]
	private BiEntry[] hashTableKToV;

	[NonSerialized]
	[Signature("[Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 94, 0, 0 })]
	private BiEntry[] hashTableVToK;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private BiEntry firstInKeyInsertionOrder;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private BiEntry lastInKeyInsertionOrder;

	[NonSerialized]
	private new int m_size;

	[NonSerialized]
	private int mask;

	[NonSerialized]
	private int modCount;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/BiMap<TV;TK;>;")]
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
	private BiMap m_inverse;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal static BiEntry access_0024400(HashBiMap P_0, object P_1, int P_2)
	{
		BiEntry result = P_0.seekByValue(P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal static void access_0024200(HashBiMap P_0, BiEntry P_1)
	{
		P_0.delete(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal static void access_0024500(HashBiMap P_0, BiEntry P_1, BiEntry P_2)
	{
		P_0.insert(P_1, P_2);
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal static int access_0024100(HashBiMap P_0)
	{
		return P_0.modCount;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal static BiEntry access_0024000(HashBiMap P_0)
	{
		return P_0.firstInKeyInsertionOrder;
	}

	public override int size()
	{
		return this.m_size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TV;TK;Z)TK;")]
	[LineNumberTable(new byte[]
	{
		159,
		58,
		98,
		103,
		135,
		105,
		106,
		147,
		103,
		98,
		103,
		byte.MaxValue,
		38,
		74,
		99,
		167,
		100,
		168,
		107,
		138,
		100,
		104,
		136,
		99,
		103,
		135,
		102
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object putInverse([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, bool P_2)
	{
		int num = Hashing.smearedHash(P_0);
		int num2 = Hashing.smearedHash(P_1);
		BiEntry biEntry = seekByValue(P_0, num);
		BiEntry biEntry2 = seekByKey(P_1, num2);
		if (biEntry != null && num2 == biEntry.keyHash && com.google.common.@base.Objects.equal(P_1, biEntry.key))
		{
			return P_1;
		}
		if (biEntry2 != null && !P_2)
		{
			string text = java.lang.String.valueOf(P_1);
			int num3 = 21 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num3 = num3;
			string s = new StringBuilder(num3).append("key already present: ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		if (biEntry != null)
		{
			delete(biEntry);
		}
		if (biEntry2 != null)
		{
			delete(biEntry2);
		}
		BiEntry biEntry3 = new BiEntry(P_1, num2, P_0, num);
		insert(biEntry3, biEntry2);
		if (biEntry2 != null)
		{
			biEntry2.prevInKeyInsertionOrder = null;
			biEntry2.nextInKeyInsertionOrder = null;
		}
		if (biEntry != null)
		{
			biEntry.prevInKeyInsertionOrder = null;
			biEntry.nextInKeyInsertionOrder = null;
		}
		rehashIfNecessary();
		object result = Maps.keyOrNull(biEntry);
		_ = null;
		return result;
	}

	[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 86, 110, 110, 137, 110, 110, 137, 99, 108,
		103, 104, 137, 140, 137, 108, 104, 137, 140, 108,
		104, 137, 204, 110, 110
	})]
	private void insert(BiEntry P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] BiEntry P_1)
	{
		int num = P_0.keyHash & mask;
		P_0.nextInKToVBucket = hashTableKToV[num];
		hashTableKToV[num] = P_0;
		int num2 = P_0.valueHash & mask;
		P_0.nextInVToKBucket = hashTableVToK[num2];
		hashTableVToK[num2] = P_0;
		if (P_1 == null)
		{
			P_0.prevInKeyInsertionOrder = lastInKeyInsertionOrder;
			P_0.nextInKeyInsertionOrder = null;
			if (lastInKeyInsertionOrder == null)
			{
				firstInKeyInsertionOrder = P_0;
			}
			else
			{
				lastInKeyInsertionOrder.nextInKeyInsertionOrder = P_0;
			}
			lastInKeyInsertionOrder = P_0;
		}
		else
		{
			P_0.prevInKeyInsertionOrder = P_1.prevInKeyInsertionOrder;
			if (P_0.prevInKeyInsertionOrder == null)
			{
				firstInKeyInsertionOrder = P_0;
			}
			else
			{
				P_0.prevInKeyInsertionOrder.nextInKeyInsertionOrder = P_0;
			}
			P_0.nextInKeyInsertionOrder = P_1.nextInKeyInsertionOrder;
			if (P_0.nextInKeyInsertionOrder == null)
			{
				lastInKeyInsertionOrder = P_0;
			}
			else
			{
				P_0.nextInKeyInsertionOrder.prevInKeyInsertionOrder = P_0;
			}
		}
		this.m_size++;
		modCount++;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;I)Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 136, 112, 131, 119, 2, 233, 69 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private BiEntry seekByValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, int P_1)
	{
		for (BiEntry biEntry = hashTableVToK[P_1 & mask]; biEntry != null; biEntry = biEntry.nextInVToKBucket)
		{
			if (P_1 == biEntry.valueHash && com.google.common.@base.Objects.equal(P_0, biEntry.value))
			{
				return biEntry;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;I)Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 124, 112, 131, 119, 2, 233, 69 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private BiEntry seekByKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, int P_1)
	{
		for (BiEntry biEntry = hashTableKToV[P_1 & mask]; biEntry != null; biEntry = biEntry.nextInKToVBucket)
		{
			if (P_1 == biEntry.keyHash && com.google.common.@base.Objects.equal(P_0, biEntry.key))
			{
				return biEntry;
			}
		}
		return null;
	}

	[Signature("(Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;)V")]
	[LineNumberTable(new byte[]
	{
		101, 110, 98, 169, 100, 99, 144, 140, 130, 226,
		55, 233, 76, 110, 98, 170, 101, 99, 144, 140,
		130, 227, 55, 235, 76, 104, 142, 177, 104, 142,
		177, 110, 110
	})]
	private void delete(BiEntry P_0)
	{
		int num = P_0.keyHash & mask;
		BiEntry biEntry = null;
		for (BiEntry biEntry2 = hashTableKToV[num]; biEntry2 != P_0; biEntry2 = biEntry2.nextInKToVBucket)
		{
			biEntry = biEntry2;
		}
		if (biEntry == null)
		{
			hashTableKToV[num] = P_0.nextInKToVBucket;
		}
		else
		{
			biEntry.nextInKToVBucket = P_0.nextInKToVBucket;
		}
		int num2 = P_0.valueHash & mask;
		biEntry = null;
		for (BiEntry biEntry3 = hashTableVToK[num2]; biEntry3 != P_0; biEntry3 = biEntry3.nextInVToKBucket)
		{
			biEntry = biEntry3;
		}
		if (biEntry == null)
		{
			hashTableVToK[num2] = P_0.nextInVToKBucket;
		}
		else
		{
			biEntry.nextInVToKBucket = P_0.nextInVToKBucket;
		}
		if (P_0.prevInKeyInsertionOrder == null)
		{
			firstInKeyInsertionOrder = P_0.nextInKeyInsertionOrder;
		}
		else
		{
			P_0.prevInKeyInsertionOrder.nextInKeyInsertionOrder = P_0.nextInKeyInsertionOrder;
		}
		if (P_0.nextInKeyInsertionOrder == null)
		{
			lastInKeyInsertionOrder = P_0.prevInKeyInsertionOrder;
		}
		else
		{
			P_0.nextInKeyInsertionOrder.prevInKeyInsertionOrder = P_0.prevInKeyInsertionOrder;
		}
		this.m_size--;
		modCount++;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Lcom/google/common/collect/HashBiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 94, 0, 0,
		18, 1, 0, 0, 0, 94, 0, 0
	})]
	[LineNumberTable(77)]
	public static HashBiMap create(int expectedSize)
	{
		HashBiMap result = new HashBiMap(expectedSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 80, 104, 105 })]
	private HashBiMap(int P_0)
	{
		init(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 85, 108, 108, 109, 109, 103, 103, 103, 105, 103 })]
	private void init(int P_0)
	{
		CollectPreconditions.checkNonnegative(P_0, "expectedSize");
		int num = Hashing.closedTableSize(P_0, 1.0);
		hashTableKToV = createTable(num);
		hashTableVToK = createTable(num);
		firstInKeyInsertionOrder = null;
		lastInKeyInsertionOrder = null;
		this.m_size = 0;
		mask = num - 1;
		modCount = 0;
	}

	[Signature("(I)[Lcom/google/common/collect/HashBiMap$BiEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 94, 0, 0 })]
	[LineNumberTable(401)]
	private BiEntry[] createTable(int P_0)
	{
		return new BiEntry[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;Z)TV;")]
	[LineNumberTable(new byte[]
	{
		159, 69, 162, 103, 135, 105, 147, 103, 162, 106,
		100, 99, 138, 223, 38, 107, 99, 103, 105, 103,
		103, 135, 105, 102
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, bool P_2)
	{
		int num = Hashing.smearedHash(P_0);
		int num2 = Hashing.smearedHash(P_1);
		BiEntry biEntry = seekByKey(P_0, num);
		if (biEntry != null && num2 == biEntry.valueHash && com.google.common.@base.Objects.equal(P_1, biEntry.value))
		{
			return P_1;
		}
		BiEntry biEntry2 = seekByValue(P_1, num2);
		if (biEntry2 != null)
		{
			if (!P_2)
			{
				string text = java.lang.String.valueOf(P_1);
				int num3 = 23 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num3 = num3;
				string s = new StringBuilder(num3).append("value already present: ").append(text).toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
			delete(biEntry2);
		}
		BiEntry biEntry3 = new BiEntry(P_0, num, P_1, num2);
		if (biEntry != null)
		{
			delete(biEntry);
			insert(biEntry3, biEntry);
			biEntry.prevInKeyInsertionOrder = null;
			biEntry.nextInKeyInsertionOrder = null;
			return biEntry.value;
		}
		insert(biEntry3, null);
		rehashIfNecessary();
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 11, 103, 119, 133, 109, 109, 105, 135, 103,
		131, 40, 169, 142
	})]
	private void rehashIfNecessary()
	{
		BiEntry[] array = hashTableKToV;
		if (Hashing.needsResizing(this.m_size, array.Length, 1.0))
		{
			int num = (int)((nint)array.LongLength * 2);
			hashTableKToV = createTable(num);
			hashTableVToK = createTable(num);
			mask = num - 1;
			this.m_size = 0;
			for (BiEntry nextInKeyInsertionOrder = firstInKeyInsertionOrder; nextInKeyInsertionOrder != null; nextInKeyInsertionOrder = nextInKeyInsertionOrder.nextInKeyInsertionOrder)
			{
				insert(nextInKeyInsertionOrder, nextInKeyInsertionOrder);
			}
			modCount++;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/BiMap<TV;TK;>;")]
	[LineNumberTable(new byte[] { 161, 224, 103 })]
	public virtual BiMap inverse()
	{
		BiMap biMap = this.m_inverse;
		object biMap2;
		if (biMap == null)
		{
			Inverse inverse = new Inverse(this, null);
			biMap2 = inverse;
			this.m_inverse = inverse;
		}
		else
		{
			biMap2 = biMap;
		}
		return (biMap2 == null) ? null : ((biMap2 as BiMap) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 51, 103, 108, 108, 103, 103, 110 })]
	public override void clear()
	{
		this.m_size = 0;
		Arrays.fill(hashTableKToV, null);
		Arrays.fill(hashTableVToK, null);
		firstInKeyInsertionOrder = null;
		lastInKeyInsertionOrder = null;
		modCount++;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(290)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		object result = put(key, value, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TV;>;")]
	[LineNumberTable(515)]
	public new virtual Set values()
	{
		Set result = inverse().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/HashBiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 94, 0, 0,
		18, 1, 0, 0, 0, 94, 0, 0
	})]
	[LineNumberTable(66)]
	public static HashBiMap create()
	{
		HashBiMap result = create(16);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/HashBiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 94, 0, 0,
		18, 1, 0, 0, 0, 94, 0, 0
	})]
	[LineNumberTable(new byte[] { 36, 108, 103 })]
	public static HashBiMap create(Map map)
	{
		HashBiMap hashBiMap = create(map.size());
		hashBiMap.putAll(map);
		return hashBiMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(262)]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		return seekByKey(key, Hashing.smearedHash(key)) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(277)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		return seekByValue(value, Hashing.smearedHash(value)) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(283)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		object result = Maps.valueOrNull(seekByKey(key, Hashing.smearedHash(key)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(332)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object forcePut([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		object result = put(key, value, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 161, 38, 110, 99, 130, 103, 103, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		BiEntry biEntry = seekByKey(key, Hashing.smearedHash(key));
		if (biEntry == null)
		{
			return null;
		}
		delete(biEntry);
		biEntry.prevInKeyInsertionOrder = null;
		biEntry.nextInKeyInsertionOrder = null;
		return biEntry.value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(480)]
	public override Set keySet()
	{
		KeySet result = new KeySet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(520)]
	internal override Iterator entryIterator()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 161, 202, 103, 103, 131, 50, 169 })]
	public override void forEach(BiConsumer action)
	{
		Preconditions.checkNotNull(action);
		for (BiEntry nextInKeyInsertionOrder = firstInKeyInsertionOrder; nextInKeyInsertionOrder != null; nextInKeyInsertionOrder = nextInKeyInsertionOrder.nextInKeyInsertionOrder)
		{
			action.accept(nextInKeyInsertionOrder.key, nextInKeyInsertionOrder.value);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
	[LineNumberTable(new byte[] { 161, 212, 103, 103, 102, 101, 63, 0, 169 })]
	public override void replaceAll(BiFunction function)
	{
		Preconditions.checkNotNull(function);
		BiEntry biEntry = firstInKeyInsertionOrder;
		clear();
		for (BiEntry biEntry2 = biEntry; biEntry2 != null; biEntry2 = biEntry2.nextInKeyInsertionOrder)
		{
			put(biEntry2.key, function.apply(biEntry2.key, biEntry2.value));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 162, 157, 102, 105 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		Serialization.writeMap(this, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 162, 163, 102, 103, 104, 106 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		int num = Serialization.readCount(P_0);
		init(16);
		Serialization.populateMap(this, P_0, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(59)]
	public override Set entrySet()
	{
		Set result = base.entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(59)]
	public virtual Collection _003Cbridge_003Evalues()
	{
		Set result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal static BiEntry access_0024300(HashBiMap P_0, object P_1, int P_2)
	{
		BiEntry result = P_0.seekByKey(P_1, P_2);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal static int access_0024700(HashBiMap P_0)
	{
		return P_0.m_size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(61)]
	internal static object access_0024800(HashBiMap P_0, object P_1, object P_2, bool P_3)
	{
		object result = P_0.putInverse(P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(HashBiMap P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	void BiMap.BiMap_003A_003AputAll(Map P_0)
	{
		putAll(P_0);
	}

	void Map.Map_003A_003AputAll(Map P_0)
	{
		putAll(P_0);
	}

	object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
	{
		return putIfAbsent(P_0, P_1);
	}

	Collection Map.Map_003A_003Avalues()
	{
		return _003Cbridge_003Evalues();
	}

	bool Map.Map_003A_003AisEmpty()
	{
		return isEmpty();
	}

	bool Map.Map_003A_003Aequals(object P_0)
	{
		return equals(P_0);
	}

	int Map.Map_003A_003AhashCode()
	{
		return hashCode();
	}

	object Map.Map_003A_003AgetOrDefault(object P_0, object P_1)
	{
		return getOrDefault(P_0, P_1);
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

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected HashBiMap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
