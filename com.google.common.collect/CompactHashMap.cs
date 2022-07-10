using System;
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
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 165, 0, 0,
	17, 1, 0, 0, 0, 165, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)165,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal class CompactHashMap : AbstractMap, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/CompactHashMap<TK;TV;>.Itr<TK;>;")]
	[EnclosingMethod(null, "keySetIterator", "()Ljava.util.Iterator;")]
	internal class _1 : Itr
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new CompactHashMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(778)]
		internal _1(CompactHashMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TK;")]
		[LineNumberTable(782)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object getOutput(int P_0)
		{
			object result = access_0024100(this_00240, P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/CompactHashMap<TK;TV;>.Itr<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "entrySetIterator", "()Ljava.util.Iterator;")]
	internal class _2 : Itr
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new CompactHashMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(884)]
		internal _2(CompactHashMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(887)]
		internal new virtual Map.Entry getOutput(int P_0)
		{
			MapEntry result = new MapEntry(this_00240, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(884)]
		internal override object getOutput(int P_0)
		{
			Map.Entry output = getOutput(P_0);
			_ = null;
			return output;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/CompactHashMap<TK;TV;>.Itr<TV;>;")]
	[EnclosingMethod(null, "valuesIterator", "()Ljava.util.Iterator;")]
	internal class _3 : Itr
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new CompactHashMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1062)]
		internal _3(CompactHashMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(1066)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object getOutput(int P_0)
		{
			object result = access_0024800(this_00240, P_0);
			_ = null;
			return result;
		}
	}

	[Signature("Lcom/google/common/collect/Maps$EntrySet<TK;TV;>;")]
	internal class EntrySetView : Maps.EntrySet
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : IntFunction
		{
			private readonly EntrySetView arg_00241;

			internal ___003C_003EAnon0(EntrySetView P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(int P_0)
			{
				Map.Entry result = arg_00241.lambda_0024spliterator_00240(P_0);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CompactHashMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(812)]
		internal EntrySetView(CompactHashMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(829)]
		private Map.Entry lambda_0024spliterator_00240(int P_0)
		{
			MapEntry result = new MapEntry(this_00240, P_0);
			_ = null;
			return result;
		}

		[Signature("()Ljava/util/Map<TK;TV;>;")]
		internal override Map map()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(820)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.entrySetIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 199, 108, 99, 109, 102, 50, 7 })]
		public override Spliterator spliterator()
		{
			Map map = this_00240.delegateOrNull();
			Spliterator result = ((map == null) ? CollectSpliterators.indexed(access_0024300(this_00240), 17, new ___003C_003EAnon0(this)) : map.entrySet().spliterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 208, 108, 99, 111, 104, 103, 114, 159, 3 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Map map = this_00240.delegateOrNull();
			if (map != null)
			{
				bool result = map.entrySet().contains(P_0);
				_ = null;
				return result;
			}
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				int num = access_0024700(this_00240, entry.getKey());
				return (num != -1 && com.google.common.@base.Objects.equal(access_0024800(this_00240, num), entry.getValue())) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 221, 108, 99, 111, 107, 103, 109, 130, 108,
			129, 102, 140, 107, 107, 107, 229, 57, 230, 72,
			100, 162, 109, 108, 139, 130
		})]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Map map = this_00240.delegateOrNull();
			if (map != null)
			{
				bool result = map.entrySet().remove(P_0);
				_ = null;
				return result;
			}
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				if (this_00240.needsAllocArrays())
				{
					return false;
				}
				int num = access_0024900(this_00240);
				int num2 = CompactHashing.remove(entry.getKey(), entry.getValue(), num, access_00241000(this_00240), access_00241100(this_00240), access_0024200(this_00240), access_00241200(this_00240));
				if (num2 == -1)
				{
					return false;
				}
				this_00240.moveLastEntry(num2, num);
				access_0024310(this_00240);
				this_00240.incrementModCount();
				return true;
			}
			return false;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Abstract)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 71, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)71,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class Itr : java.lang.Object, Iterator
	{
		internal int expectedMetadata;

		internal int currentIndex;

		internal int indexToRemove;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CompactHashMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 4, 111, 113, 113 })]
		private Itr(CompactHashMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			expectedMetadata = access_0024000(this_00240);
			currentIndex = this_00240.firstEntryIndex();
			indexToRemove = -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 45, 115, 139 })]
		private void checkForConcurrentModification()
		{
			if (access_0024000(this_00240) != expectedMetadata)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new ConcurrentModificationException();
			}
		}

		public virtual bool hasNext()
		{
			return currentIndex >= 0;
		}

		[Signature("(I)TT;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal abstract object getOutput(int P_0);

		[LineNumberTable(new byte[] { 162, 41, 111 })]
		internal virtual void incrementExpectedModCount()
		{
			expectedMetadata += 32;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 162, 20, 102, 104, 139, 108, 109, 119 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			checkForConcurrentModification();
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			indexToRemove = currentIndex;
			object output = getOutput(currentIndex);
			currentIndex = this_00240.getSuccessor(currentIndex);
			return output;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 32, 102, 113, 102, 125, 125, 103 })]
		public virtual void remove()
		{
			checkForConcurrentModification();
			CollectPreconditions.checkRemove(indexToRemove >= 0);
			incrementExpectedModCount();
			this_00240.remove(access_0024100(this_00240, indexToRemove));
			currentIndex = this_00240.adjustAfterRemove(currentIndex, indexToRemove);
			indexToRemove = -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(630)]
		internal Itr(CompactHashMap P_0, _1 P_1)
			: this(P_0)
		{
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[Signature("Lcom/google/common/collect/Maps$KeySet<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)51,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class KeySetView : Maps.KeySet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CompactHashMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 77, 103, 105 })]
		internal KeySetView(CompactHashMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 51, 0, 0 })]
		[LineNumberTable(new byte[] { 162, 83, 109, 135, 108, 99, 109, 30 })]
		public override object[] toArray()
		{
			if (this_00240.needsAllocArrays())
			{
				return new object[0];
			}
			Map map = this_00240.delegateOrNull();
			object[] result = ((map == null) ? ObjectArrays.copyAsObjectArray(access_0024200(this_00240), 0, access_0024300(this_00240)) : map.keySet().toArray());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			162, 95, 109, 101, 98, 132, 130, 108, 99, 110,
			31, 0
		})]
		public override object[] toArray(object[] P_0)
		{
			if (this_00240.needsAllocArrays())
			{
				if ((nint)P_0.LongLength > 0)
				{
					P_0[0] = null;
				}
				return P_0;
			}
			Map map = this_00240.delegateOrNull();
			object[] result = ((map == null) ? ObjectArrays.toArrayImpl(access_0024200(this_00240), 0, access_0024300(this_00240), P_0) : map.keySet().toArray(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 110, 108, 99, 110, 23 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (byte)(((int?)this_00240.delegateOrNull()?.keySet().remove(P_0)) ?? ((access_0024400(this_00240, P_0) != access_0024500()) ? 1 : 0)) != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(744)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.keySetIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TK;>;")]
		[LineNumberTable(new byte[] { 162, 123, 109, 144, 108, 99, 109, 102, 51, 7 })]
		public override Spliterator spliterator()
		{
			if (this_00240.needsAllocArrays())
			{
				Spliterator result = Spliterators.spliterator(new object[0], 17);
				_ = null;
				return result;
			}
			Map map = this_00240.delegateOrNull();
			Spliterator result2 = ((map == null) ? Spliterators.spliterator(access_0024200(this_00240), 0, access_0024300(this_00240), 17) : map.keySet().spliterator());
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TK;>;)V")]
		[LineNumberTable(new byte[] { 162, 135, 103, 108, 99, 142, 112, 50, 207 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			Map map = this_00240.delegateOrNull();
			if (map != null)
			{
				map.keySet().forEach(P_0);
				return;
			}
			for (int num = this_00240.firstEntryIndex(); num >= 0; num = this_00240.getSuccessor(num))
			{
				P_0.accept(access_0024100(this_00240, num));
			}
		}
	}

	[Signature("Lcom/google/common/collect/AbstractMapEntry<TK;TV;>;")]
	internal sealed class MapEntry : AbstractMapEntry
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object key;

		private int lastKnownIndex;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CompactHashMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 15, 111, 109, 103 })]
		internal MapEntry(CompactHashMap P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			key = access_0024100(P_0, P_1);
			lastKnownIndex = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 27, 117, 121, 108, 151 })]
		private void updateLastKnownIndex()
		{
			if (lastKnownIndex == -1 || lastKnownIndex >= this_00240.size() || !com.google.common.@base.Objects.equal(key, access_0024100(this_00240, lastKnownIndex)))
			{
				lastKnownIndex = access_0024700(this_00240, key);
			}
		}

		[Signature("()TK;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getKey()
		{
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(new byte[] { 163, 37, 108, 227, 69, 148, 230, 73 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getValue()
		{
			Map map = this_00240.delegateOrNull();
			if (map != null)
			{
				object result = NullnessCasts.uncheckedCastNullableTToT(map.get(key));
				_ = null;
				return result;
			}
			updateLastKnownIndex();
			object result2 = ((lastKnownIndex != -1) ? access_0024800(this_00240, lastKnownIndex) : NullnessCasts.unsafeNull());
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(new byte[]
		{
			163, 60, 108, 99, 149, 102, 105, 115, 136, 114,
			114
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
			Map map = this_00240.delegateOrNull();
			if (map != null)
			{
				object result = NullnessCasts.uncheckedCastNullableTToT(map.put(key, P_0));
				_ = null;
				return result;
			}
			updateLastKnownIndex();
			if (lastKnownIndex == -1)
			{
				this_00240.put(key, P_0);
				object result2 = NullnessCasts.unsafeNull();
				_ = null;
				return result2;
			}
			object result3 = access_0024800(this_00240, lastKnownIndex);
			access_00241300(this_00240, lastKnownIndex, P_0);
			return result3;
		}
	}

	[Signature("Lcom/google/common/collect/Maps$Values<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)63,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ValuesView : Maps.Values
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CompactHashMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 114, 103, 105 })]
		internal ValuesView(CompactHashMap P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(1002)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.valuesIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 125, 103, 108, 99, 142, 112, 50, 207 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			Map map = this_00240.delegateOrNull();
			if (map != null)
			{
				map.values().forEach(P_0);
				return;
			}
			for (int num = this_00240.firstEntryIndex(); num >= 0; num = this_00240.getSuccessor(num))
			{
				P_0.accept(access_0024800(this_00240, num));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TV;>;")]
		[LineNumberTable(new byte[] { 163, 138, 109, 144, 108, 99, 109, 31, 1 })]
		public override Spliterator spliterator()
		{
			if (this_00240.needsAllocArrays())
			{
				Spliterator result = Spliterators.spliterator(new object[0], 16);
				_ = null;
				return result;
			}
			Map map = this_00240.delegateOrNull();
			Spliterator result2 = ((map == null) ? Spliterators.spliterator(access_00241200(this_00240), 0, access_0024300(this_00240), 16) : map.values().spliterator());
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 63, 0, 0 })]
		[LineNumberTable(new byte[] { 163, 149, 109, 135, 108, 99, 109, 30 })]
		public override object[] toArray()
		{
			if (this_00240.needsAllocArrays())
			{
				return new object[0];
			}
			Map map = this_00240.delegateOrNull();
			object[] result = ((map == null) ? ObjectArrays.copyAsObjectArray(access_00241200(this_00240), 0, access_0024300(this_00240)) : map.values().toArray());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 63, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			163, 161, 109, 101, 98, 132, 130, 108, 99, 110,
			31, 0
		})]
		public override object[] toArray(object[] P_0)
		{
			if (this_00240.needsAllocArrays())
			{
				if ((nint)P_0.LongLength > 0)
				{
					P_0[0] = null;
				}
				return P_0;
			}
			Map map = this_00240.delegateOrNull();
			object[] result = ((map == null) ? ObjectArrays.toArrayImpl(access_00241200(this_00240), 0, access_0024300(this_00240), P_0) : map.values().toArray(P_0));
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static object NOT_FOUND;

	internal const double HASH_FLOODING_FPP = 0.001;

	private const int MAX_HASH_BUCKET_LENGTH = 9;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object table;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal int[] entries;

	[NonSerialized]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 165, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal object[] keys;

	[NonSerialized]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 165, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal new object[] values;

	[NonSerialized]
	private int metadata;

	[NonSerialized]
	private new int m_size;

	[NonSerialized]
	[Signature("Ljava/util/Set<TK;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Set keySetView;

	[NonSerialized]
	[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Set entrySetView;

	[NonSerialized]
	[Signature("Ljava/util/Collection<TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Collection valuesView;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static int access_0024000(CompactHashMap P_0)
	{
		return P_0.metadata;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(614)]
	internal virtual int firstEntryIndex()
	{
		return isEmpty() ? (-1) : 0;
	}

	internal virtual int getSuccessor(int P_0)
	{
		return (P_0 + 1 >= this.m_size) ? (-1) : (P_0 + 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static object access_0024100(CompactHashMap P_0, int P_1)
	{
		object result = P_0.key(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 161, 161, 103, 99, 138, 104 })]
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
		Map map = delegateOrNull();
		if (map != null)
		{
			object result = map.remove(P_0);
			_ = null;
			return result;
		}
		object obj = removeHelper(P_0);
		return (obj != NOT_FOUND) ? obj : null;
	}

	internal virtual int adjustAfterRemove(int P_0, int P_1)
	{
		return P_0 - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITV;)V")]
	[LineNumberTable(new byte[] { 164, 62, 105 })]
	private void setValue(int P_0, object P_1)
	{
		requireValues()[P_0] = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 165, 0, 0 })]
	[LineNumberTable(1170)]
	private object[] requireValues()
	{
		return (object[])java.util.Objects.requireNonNull(this.values);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1162)]
	private int[] requireEntries()
	{
		return (int[])java.util.Objects.requireNonNull(entries);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1158)]
	private object requireTable()
	{
		object result = java.util.Objects.requireNonNull(table);
		_ = null;
		return result;
	}

	private int hashTableMask()
	{
		return (1 << (metadata & 0x1F)) - 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TV;")]
	[LineNumberTable(1188)]
	private object value(int P_0)
	{
		return requireValues()[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 113, 104, 130, 103, 103, 111, 99, 130, 136,
		101, 106, 111, 108, 131, 105, 99
	})]
	private int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (needsAllocArrays())
		{
			return -1;
		}
		int num = Hashing.smearedHash(P_0);
		int num2 = hashTableMask();
		int num3 = CompactHashing.tableGet(requireTable(), num & num2);
		if (num3 == 0)
		{
			return -1;
		}
		int hashPrefix = CompactHashing.getHashPrefix(num, num2);
		do
		{
			int num4 = num3 - 1;
			int num5 = entry(num4);
			if (CompactHashing.getHashPrefix(num5, num2) == hashPrefix && com.google.common.@base.Objects.equal(P_0, key(num4)))
			{
				return num4;
			}
			num3 = CompactHashing.getNext(num5, num2);
		}
		while (num3 != 0);
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 165, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		161, 170, 104, 134, 103, 228, 69, 102, 102, 230,
		58, 230, 72, 100, 166, 136, 104, 110, 134
	})]
	private object removeHelper([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (needsAllocArrays())
		{
			return NOT_FOUND;
		}
		int num = hashTableMask();
		int num2 = CompactHashing.remove(P_0, null, num, requireTable(), requireEntries(), requireKeys(), null);
		if (num2 == -1)
		{
			return NOT_FOUND;
		}
		object result = value(num2);
		moveLastEntry(num2, num);
		this.m_size--;
		incrementModCount();
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 165, 0, 0 })]
	[LineNumberTable(1166)]
	private object[] requireKeys()
	{
		return (object[])java.util.Objects.requireNonNull(keys);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TK;")]
	[LineNumberTable(1183)]
	private object key(int P_0)
	{
		return requireKeys()[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 124, 104, 105 })]
	internal CompactHashMap()
	{
		init(3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 133, 104, 105 })]
	internal CompactHashMap(int P_0)
	{
		init(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 139, 177, 114 })]
	internal virtual void init(int P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, (object)"Expected size must be >= 0");
		metadata = Ints.constrainToRange(P_0, 1, 1073741823);
	}

	internal virtual bool needsAllocArrays()
	{
		return table == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 199, 106, 106, 106 })]
	private void setHashTableMask(int P_0)
	{
		int num = 32 - Integer.numberOfLeadingZeros(P_0);
		metadata = CompactHashing.maskCombine(metadata, num, 31);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Ljava/util/Map<TK;TV;>;")]
	[LineNumberTable(293)]
	internal virtual Map createHashFloodingResistantDelegate(int P_0)
	{
		LinkedHashMap result = new LinkedHashMap(P_0, 1f);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 210, 111 })]
	internal virtual void incrementModCount()
	{
		metadata += 32;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 154, 144, 103, 103, 108, 137, 108, 108, 140 })]
	internal virtual int allocArrays()
	{
		Preconditions.checkState(needsAllocArrays(), (object)"Arrays already allocated");
		int num = metadata;
		int num2 = CompactHashing.tableSize(num);
		table = CompactHashing.createTable(num2);
		setHashTableMask(num2 - 1);
		entries = new int[num];
		keys = new object[num];
		this.values = new object[num];
		return num;
	}

	[Signature("()Ljava/util/Map<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 172, 109, 140 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal virtual Map delegateOrNull()
	{
		if (table is Map)
		{
			return (Map)table;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 67, 103, 132, 132, 173, 103, 231, 71, 107,
		234, 71, 103, 102, 166, 141, 102, 106, 106, 142,
		106, 229, 43, 235, 88, 103, 103
	})]
	private int resizeTable(int P_0, int P_1, int P_2, int P_3)
	{
		object obj = CompactHashing.createTable(P_1);
		int num = P_1 - 1;
		if (P_3 != 0)
		{
			CompactHashing.tableSet(obj, P_2 & num, P_3 + 1);
		}
		object obj2 = requireTable();
		int[] array = requireEntries();
		for (int i = 0; i <= P_0; i++)
		{
			int num2 = CompactHashing.tableGet(obj2, i);
			while (num2 != 0)
			{
				int num3 = num2 - 1;
				int num4 = array[num3];
				int num5 = CompactHashing.getHashPrefix(num4, P_0) | i;
				int num6 = num5 & num;
				int num7 = CompactHashing.tableGet(obj, num6);
				CompactHashing.tableSet(obj, num6, num2);
				array[num3] = CompactHashing.maskCombine(num5, num7, num);
				num2 = CompactHashing.getNext(num4, P_0);
			}
		}
		table = obj;
		setHashTableMask(num);
		return num;
	}

	internal virtual void accessEntry(int P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 185, 111, 107, 53, 170, 103, 103, 103, 103,
		102
	})]
	internal virtual Map convertToHashFloodingResistantImplementation()
	{
		Map map = createHashFloodingResistantDelegate(hashTableMask() + 1);
		for (int num = firstEntryIndex(); num >= 0; num = getSuccessor(num))
		{
			map.put(key(num), value(num));
		}
		table = map;
		entries = null;
		keys = null;
		this.values = null;
		incrementModCount();
		return map;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 44, 104, 132, 106, 110, 100, 169 })]
	private void resizeMeMaybe(int P_0)
	{
		int num = requireEntries().Length;
		if (P_0 > num)
		{
			int num2 = java.lang.Math.min(1073741823, (num + java.lang.Math.max(1, (int)((uint)num >> 1))) | 1);
			if (num2 != num)
			{
				resizeEntries(num2);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITK;TV;II)V")]
	[LineNumberTable(new byte[] { 161, 37, 113, 104, 106 })]
	internal virtual void insertEntry(int P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2, int P_3, int P_4)
	{
		setEntry(P_0, CompactHashing.maskCombine(P_3, 0, P_4));
		setKey(P_0, P_1);
		setValue(P_0, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 164, 66, 105 })]
	private void setEntry(int P_0, int P_1)
	{
		requireEntries()[P_0] = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITK;)V")]
	[LineNumberTable(new byte[] { 164, 58, 105 })]
	private void setKey(int P_0, object P_1)
	{
		requireKeys()[P_0] = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 60, 114, 114, 114 })]
	internal virtual void resizeEntries(int P_0)
	{
		entries = Arrays.copyOf(requireEntries(), P_0);
		keys = Arrays.copyOf(requireKeys(), P_0);
		this.values = Arrays.copyOf(requireValues(), P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1192)]
	private int entry(int P_0)
	{
		return requireEntries()[P_0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 200, 103, 103, 103, 103, 106, 136, 102, 101,
		103, 101, 165, 103, 165, 107, 106, 102, 134, 237,
		70, 102, 102, 106, 134, 143, 98, 100, 100, 132
	})]
	internal virtual void moveLastEntry(int P_0, int P_1)
	{
		object obj = requireTable();
		int[] array = requireEntries();
		object[] array2 = requireKeys();
		object[] array3 = requireValues();
		int num = size() - 1;
		if (P_0 < num)
		{
			object obj2 = (array2[P_0] = array2[num]);
			array3[P_0] = array3[num];
			array2[num] = null;
			array3[num] = null;
			array[P_0] = array[num];
			array[num] = 0;
			int num2 = Hashing.smearedHash(obj2) & P_1;
			int num3 = CompactHashing.tableGet(obj, num2);
			int num4 = num + 1;
			if (num3 == num4)
			{
				CompactHashing.tableSet(obj, num2, P_0 + 1);
				return;
			}
			int num5;
			int num6;
			do
			{
				num5 = num3 - 1;
				num6 = array[num5];
				num3 = CompactHashing.getNext(num6, P_1);
			}
			while (num3 != num4);
			array[num5] = CompactHashing.maskCombine(num6, P_0 + 1, P_1);
		}
		else
		{
			array2[P_0] = null;
			array3[P_0] = null;
			array[P_0] = 0;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 78, 103 })]
	public override int size()
	{
		return delegateOrNull()?.size() ?? this.m_size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(966)]
	public override bool isEmpty()
	{
		return (size() == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(698)]
	internal virtual Set createKeySet()
	{
		KeySetView result = new KeySetView(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(808)]
	internal virtual Set createEntrySet()
	{
		EntrySetView result = new EntrySetView(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(991)]
	internal virtual Collection createValues()
	{
		ValuesView result = new ValuesView(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 162, 254, 103, 99, 142 })]
	internal virtual Iterator entrySetIterator()
	{
		Map map = delegateOrNull();
		if (map != null)
		{
			Iterator result = map.entrySet().iterator();
			_ = null;
			return result;
		}
		_2 result2 = new _2(this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(new byte[]
	{
		160, 225, 104, 135, 103, 99, 139, 103, 103, 135,
		104, 102, 104, 104, 103, 111, 100, 134, 154, 246,
		69, 107, 131, 102, 102, 114, 135, 134, 101, 104,
		131, 107, 102, 135, 102, 176, 134, 151, 177, 104,
		110, 104, 102
	})]
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
		if (needsAllocArrays())
		{
			allocArrays();
		}
		Map map = delegateOrNull();
		if (map != null)
		{
			object result = map.put(P_0, P_1);
			_ = null;
			return result;
		}
		int[] array = requireEntries();
		object[] array2 = requireKeys();
		object[] array3 = requireValues();
		int num = this.m_size;
		int num2 = num + 1;
		int num3 = Hashing.smearedHash(P_0);
		int num4 = hashTableMask();
		int num5 = num3 & num4;
		int num6 = CompactHashing.tableGet(requireTable(), num5);
		if (num6 == 0)
		{
			if (num2 > num4)
			{
				num4 = resizeTable(num4, CompactHashing.newCapacity(num4), num3, num);
			}
			else
			{
				CompactHashing.tableSet(requireTable(), num5, num + 1);
			}
		}
		else
		{
			int hashPrefix = CompactHashing.getHashPrefix(num3, num4);
			int num7 = 0;
			int num8;
			int num9;
			do
			{
				num8 = num6 - 1;
				num9 = array[num8];
				if (CompactHashing.getHashPrefix(num9, num4) == hashPrefix && com.google.common.@base.Objects.equal(P_0, array2[num8]))
				{
					object result2 = array3[num8];
					array3[num8] = P_1;
					accessEntry(num8);
					return result2;
				}
				num6 = CompactHashing.getNext(num9, num4);
				num7++;
			}
			while (num6 != 0);
			if (num7 >= 9)
			{
				object result3 = convertToHashFloodingResistantImplementation().put(P_0, P_1);
				_ = null;
				return result3;
			}
			if (num2 > num4)
			{
				num4 = resizeTable(num4, CompactHashing.newCapacity(num4), num3, num);
			}
			else
			{
				array[num8] = CompactHashing.maskCombine(num9, num + 1, num4);
			}
		}
		resizeMeMaybe(num2);
		insertEntry(num, P_0, P_1, num3, num4);
		this.m_size = num2;
		incrementModCount();
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/CompactHashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 165, 0, 0,
		18, 1, 0, 0, 0, 165, 0, 0
	})]
	[LineNumberTable(97)]
	public static CompactHashMap create()
	{
		CompactHashMap result = new CompactHashMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Lcom/google/common/collect/CompactHashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 165, 0, 0,
		18, 1, 0, 0, 0, 165, 0, 0
	})]
	[LineNumberTable(111)]
	public static CompactHashMap createWithExpectedSize(int P_0)
	{
		CompactHashMap result = new CompactHashMap(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 137, 103 })]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return delegateOrNull()?.containsKey(P_0) ?? (indexOf(P_0) != -1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 161, 144, 103, 99, 138, 104, 100, 130, 103 })]
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
		Map map = delegateOrNull();
		if (map != null)
		{
			object result = map.get(P_0);
			_ = null;
			return result;
		}
		int num = indexOf(P_0);
		if (num == -1)
		{
			return null;
		}
		accessEntry(num);
		object result2 = value(num);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
	[LineNumberTable(new byte[] { 162, 53, 103, 103, 99, 137, 107, 59, 198 })]
	public override void replaceAll(BiFunction P_0)
	{
		Preconditions.checkNotNull(P_0);
		Map map = delegateOrNull();
		if (map != null)
		{
			map.replaceAll(P_0);
			return;
		}
		for (int i = 0; i < this.m_size; i++)
		{
			setValue(i, P_0.apply(key(i), value(i)));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(694)]
	public override Set keySet()
	{
		Set result;
		if (keySetView == null)
		{
			Set set = createKeySet();
			result = set;
			keySetView = set;
		}
		else
		{
			result = keySetView;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TK;>;")]
	[LineNumberTable(new byte[] { 162, 148, 103, 99, 142 })]
	internal virtual Iterator keySetIterator()
	{
		Map map = delegateOrNull();
		if (map != null)
		{
			Iterator result = map.keySet().iterator();
			_ = null;
			return result;
		}
		_1 result2 = new _1(this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 162, 163, 103, 103, 99, 137, 107, 52, 202 })]
	public override void forEach(BiConsumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		Map map = delegateOrNull();
		if (map != null)
		{
			map.forEach(P_0);
			return;
		}
		for (int num = firstEntryIndex(); num >= 0; num = getSuccessor(num))
		{
			P_0.accept(key(num), value(num));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(804)]
	public override Set entrySet()
	{
		Set result;
		if (entrySetView == null)
		{
			Set set = createEntrySet();
			result = set;
			entrySetView = set;
		}
		else
		{
			result = entrySetView;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 89, 103, 99, 138, 107, 111, 2, 230, 69 })]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Map map = delegateOrNull();
		if (map != null)
		{
			bool result = map.containsValue(P_0);
			_ = null;
			return result;
		}
		for (int i = 0; i < this.m_size; i++)
		{
			if (com.google.common.@base.Objects.equal(P_0, value(i)))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(987)]
	public override Collection values()
	{
		Collection result;
		if (valuesView == null)
		{
			Collection collection = createValues();
			result = collection;
			valuesView = collection;
		}
		else
		{
			result = valuesView;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TV;>;")]
	[LineNumberTable(new byte[] { 163, 176, 103, 99, 142 })]
	internal virtual Iterator valuesIterator()
	{
		Map map = delegateOrNull();
		if (map != null)
		{
			Iterator result = map.values().iterator();
			_ = null;
			return result;
		}
		_3 result2 = new _3(this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 194, 104, 129, 103, 99, 109, 103, 103, 129,
		103, 106, 135, 103, 104, 101, 140
	})]
	public virtual void trimToSize()
	{
		if (needsAllocArrays())
		{
			return;
		}
		Map map = delegateOrNull();
		if (map != null)
		{
			Map map2 = createHashFloodingResistantDelegate(size());
			map2.putAll(map);
			table = map2;
			return;
		}
		int num = this.m_size;
		if (num < (nint)requireEntries().LongLength)
		{
			resizeEntries(num);
		}
		int num2 = CompactHashing.tableSize(num);
		int num3 = hashTableMask();
		if (num2 < num3)
		{
			resizeTable(num3, num2, 0, 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 217, 104, 129, 102, 103, 99, 98, 117, 102,
		103, 137, 115, 115, 107, 115, 135
	})]
	public override void clear()
	{
		if (!needsAllocArrays())
		{
			incrementModCount();
			Map map = delegateOrNull();
			if (map != null)
			{
				metadata = Ints.constrainToRange(size(), 3, 1073741823);
				map.clear();
				table = null;
				this.m_size = 0;
			}
			else
			{
				Arrays.fill(requireKeys(), 0, this.m_size, null);
				Arrays.fill(requireValues(), 0, this.m_size, null);
				CompactHashing.tableClear(requireTable());
				Arrays.fill(requireEntries(), 0, this.m_size, 0);
				this.m_size = 0;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 163, 238, 102, 108, 103, 104, 108, 108, 108, 98 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeInt(size());
		Iterator iterator = entrySetIterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			P_0.writeObject(entry.getKey());
			P_0.writeObject(entry.getValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		163, 250, 102, 103, 100, 159, 12, 103, 102, 103,
		104, 234, 61, 230, 69
	})]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		int num = P_0.readInt();
		if (num < 0)
		{
			int num2 = 25;
			num2 = num2;
			string reason = new StringBuilder(num2).append("Invalid size: ").append(num).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new InvalidObjectException(reason);
		}
		init(num);
		for (int i = 0; i < num; i++)
		{
			object obj = P_0.readObject();
			object obj2 = P_0.readObject();
			put(obj, obj2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static object[] access_0024200(CompactHashMap P_0)
	{
		object[] result = P_0.requireKeys();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static int access_0024300(CompactHashMap P_0)
	{
		return P_0.m_size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static object access_0024400(CompactHashMap P_0, object P_1)
	{
		object result = P_0.removeHelper(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static object access_0024500()
	{
		return NOT_FOUND;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static int access_0024700(CompactHashMap P_0, object P_1)
	{
		int result = P_0.indexOf(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static object access_0024800(CompactHashMap P_0, int P_1)
	{
		object result = P_0.value(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static int access_0024900(CompactHashMap P_0)
	{
		int result = P_0.hashTableMask();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static object access_00241000(CompactHashMap P_0)
	{
		object result = P_0.requireTable();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static int[] access_00241100(CompactHashMap P_0)
	{
		int[] result = P_0.requireEntries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static object[] access_00241200(CompactHashMap P_0)
	{
		object[] result = P_0.requireValues();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static int access_0024310(CompactHashMap P_0)
	{
		int num = P_0.m_size;
		P_0.m_size = num - 1;
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(84)]
	internal static void access_00241300(CompactHashMap P_0, int P_1, object P_2)
	{
		P_0.setValue(P_1, P_2);
	}

	[LineNumberTable(114)]
	static CompactHashMap()
	{
		NOT_FOUND = new java.lang.Object();
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
	protected CompactHashMap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
