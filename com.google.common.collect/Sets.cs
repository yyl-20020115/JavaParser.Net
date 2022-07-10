using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.math;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)196,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Sets : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Sets$SetView<TE;>;")]
	[EnclosingMethod(null, "union", "(Ljava.util.Set;Ljava.util.Set;)Lcom.google.common.collect.Sets$SetView;")]
	internal class _1 : SetView
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<TE;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<+TE;>;")]
			internal Iterator itr1;

			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<+TE;>;")]
			internal Iterator itr2;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Sets._1 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 103, 111, 118 })]
			internal _1(Sets._1 P_0)
			{
				this_00240 = P_0;
				base._002Ector();
				itr1 = this_00240.val_0024set1.iterator();
				itr2 = this_00240.val_0024set2.iterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TE;")]
			[LineNumberTable(new byte[] { 162, 110, 109, 142, 109, 108, 115, 130, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				if (itr1.hasNext())
				{
					object result = itr1.next();
					_ = null;
					return result;
				}
				while (itr2.hasNext())
				{
					object obj = itr2.next();
					if (!this_00240.val_0024set1.contains(obj))
					{
						return obj;
					}
				}
				object result2 = endOfData();
				_ = null;
				return result2;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Predicate
		{
			private readonly Set arg_00241;

			internal ___003C_003EAnon0(Set P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024stream_00240(arg_00241, P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set1;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(752)]
		public override Stream stream()
		{
			Stream result = Stream.concat(val_0024set1.stream(), val_0024set2.stream().filter(new ___003C_003EAnon0(val_0024set1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		[LineNumberTable(729)]
		public override UnmodifiableIterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(752)]
		private static bool lambda_0024stream_00240(Set P_0, object P_1)
		{
			return (!P_0.contains(P_1)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(710)]
		internal _1(Set P_0, Set P_1)
		{
			val_0024set1 = P_0;
			val_0024set2 = P_1;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 87, 108, 123, 110, 132, 98 })]
		public override int size()
		{
			int num = val_0024set1.size();
			Iterator iterator = val_0024set2.iterator();
			while (iterator.hasNext())
			{
				object o = iterator.next();
				if (!val_0024set1.contains(o))
				{
					num++;
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(724)]
		public override bool isEmpty()
		{
			return (val_0024set1.isEmpty() && val_0024set2.isEmpty()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(757)]
		public override Stream parallelStream()
		{
			return (Stream)stream().parallel();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(762)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (val_0024set1.contains(P_0) || val_0024set2.contains(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<S::Ljava/util/Set<TE;>;>(TS;)TS;")]
		[LineNumberTable(new byte[] { 162, 141, 109, 109 })]
		public override Set copyInto(Set P_0)
		{
			P_0.addAll(val_0024set1);
			P_0.addAll(val_0024set2);
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
		[LineNumberTable(775)]
		public override ImmutableSet immutableCopy()
		{
			ImmutableSet result = new ImmutableSet.Builder().addAll(val_0024set1).addAll(val_0024set2).build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(710)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Sets$SetView<TE;>;")]
	[EnclosingMethod(null, "intersection", "(Ljava.util.Set;Ljava.util.Set;)Lcom.google.common.collect.Sets$SetView;")]
	internal class _2 : SetView
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<TE;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<TE;>;")]
			internal Iterator itr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _2 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 189, 111 })]
			internal _1(_2 P_0)
			{
				this_00240 = P_0;
				base._002Ector();
				itr = this_00240.val_0024set1.iterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TE;")]
			[LineNumberTable(new byte[] { 162, 195, 109, 108, 115, 130, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				while (itr.hasNext())
				{
					object obj = itr.next();
					if (this_00240.val_0024set2.contains(obj))
					{
						return obj;
					}
				}
				object result = endOfData();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Predicate
		{
			private readonly Set arg_00241;

			internal ___003C_003EAnon0(Set P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.contains(P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set1;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(812)]
		internal _2(Set P_0, Set P_1)
		{
			val_0024set1 = P_0;
			val_0024set2 = P_1;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		[LineNumberTable(815)]
		public override UnmodifiableIterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(834)]
		public override Stream stream()
		{
			Stream obj = val_0024set1.stream();
			Set set = val_0024set2;
			java.util.Objects.requireNonNull(set);
			Stream result = obj.filter(new ___003C_003EAnon0(set));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(839)]
		public override Stream parallelStream()
		{
			Stream obj = val_0024set1.parallelStream();
			Set set = val_0024set2;
			java.util.Objects.requireNonNull(set);
			Stream result = obj.filter(new ___003C_003EAnon0(set));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 218, 98, 123, 110, 132, 98 })]
		public override int size()
		{
			int num = 0;
			Iterator iterator = val_0024set1.iterator();
			while (iterator.hasNext())
			{
				object o = iterator.next();
				if (val_0024set2.contains(o))
				{
					num++;
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(855)]
		public override bool isEmpty()
		{
			bool result = Collections.disjoint(val_0024set2, val_0024set1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(860)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (val_0024set1.contains(P_0) && val_0024set2.contains(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(865)]
		public override bool containsAll(Collection P_0)
		{
			return (val_0024set1.containsAll(P_0) && val_0024set2.containsAll(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(812)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Sets$SetView<TE;>;")]
	[EnclosingMethod(null, "difference", "(Ljava.util.Set;Ljava.util.Set;)Lcom.google.common.collect.Sets$SetView;")]
	internal class _3 : SetView
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<TE;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<TE;>;")]
			internal Iterator itr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _3 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 6, 111 })]
			internal _1(_3 P_0)
			{
				this_00240 = P_0;
				base._002Ector();
				itr = this_00240.val_0024set1.iterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TE;")]
			[LineNumberTable(new byte[] { 163, 12, 109, 108, 115, 130, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				while (itr.hasNext())
				{
					object obj = itr.next();
					if (!this_00240.val_0024set2.contains(obj))
					{
						return obj;
					}
				}
				object result = endOfData();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Predicate
		{
			private readonly Set arg_00241;

			internal ___003C_003EAnon0(Set P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024stream_00240(arg_00241, P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : java.util.function.Predicate
		{
			private readonly Set arg_00241;

			internal ___003C_003EAnon1(Set P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024parallelStream_00241(arg_00241, P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set1;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(885)]
		internal _3(Set P_0, Set P_1)
		{
			val_0024set1 = P_0;
			val_0024set2 = P_1;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		[LineNumberTable(888)]
		public override UnmodifiableIterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(907)]
		private static bool lambda_0024stream_00240(Set P_0, object P_1)
		{
			return (!P_0.contains(P_1)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(912)]
		private static bool lambda_0024parallelStream_00241(Set P_0, object P_1)
		{
			return (!P_0.contains(P_1)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(907)]
		public override Stream stream()
		{
			Stream result = val_0024set1.stream().filter(new ___003C_003EAnon0(val_0024set2));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(912)]
		public override Stream parallelStream()
		{
			Stream result = val_0024set1.parallelStream().filter(new ___003C_003EAnon1(val_0024set2));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 35, 98, 123, 110, 132, 98 })]
		public override int size()
		{
			int num = 0;
			Iterator iterator = val_0024set1.iterator();
			while (iterator.hasNext())
			{
				object o = iterator.next();
				if (!val_0024set2.contains(o))
				{
					num++;
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(928)]
		public override bool isEmpty()
		{
			bool result = val_0024set2.containsAll(val_0024set1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(933)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (val_0024set1.contains(P_0) && !val_0024set2.contains(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(885)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Sets$SetView<TE;>;")]
	[EnclosingMethod(null, "symmetricDifference", "(Ljava.util.Set;Ljava.util.Set;)Lcom.google.common.collect.Sets$SetView;")]
	internal class _4 : SetView
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<TE;>;")]
		[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024itr1;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024itr2;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _4 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(959)]
			internal _1(_4 P_0, Iterator P_1, Iterator P_2)
			{
				this_00240 = P_0;
				val_0024itr1 = P_1;
				val_0024itr2 = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TE;")]
			[LineNumberTable(new byte[]
			{
				163, 81, 109, 108, 115, 130, 98, 109, 108, 115,
				130, 98
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public override object computeNext()
			{
				while (val_0024itr1.hasNext())
				{
					object obj = val_0024itr1.next();
					if (!this_00240.val_0024set2.contains(obj))
					{
						return obj;
					}
				}
				while (val_0024itr2.hasNext())
				{
					object obj = val_0024itr2.next();
					if (!this_00240.val_0024set1.contains(obj))
					{
						return obj;
					}
				}
				object result = endOfData();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set1;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(954)]
		internal _4(Set P_0, Set P_1)
		{
			val_0024set1 = P_0;
			val_0024set2 = P_1;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		[LineNumberTable(new byte[] { 163, 75, 108, 108 })]
		public override UnmodifiableIterator iterator()
		{
			Iterator iterator = val_0024set1.iterator();
			Iterator iterator2 = val_0024set2.iterator();
			_1 result = new _1(this, iterator, iterator2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			163, 100, 98, 123, 110, 132, 98, 123, 110, 132,
			98
		})]
		public override int size()
		{
			int num = 0;
			Iterator iterator = val_0024set1.iterator();
			while (iterator.hasNext())
			{
				object o = iterator.next();
				if (!val_0024set2.contains(o))
				{
					num++;
				}
			}
			iterator = val_0024set2.iterator();
			while (iterator.hasNext())
			{
				object o = iterator.next();
				if (!val_0024set1.contains(o))
				{
					num++;
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(998)]
		public override bool isEmpty()
		{
			bool result = val_0024set1.equals(val_0024set2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1003)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return val_0024set1.contains(P_0) ^ val_0024set2.contains(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(954)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/AbstractSet<Ljava/util/Set<TE;>;>;")]
	[EnclosingMethod(null, "combinations", "(Ljava.util.Set;I)Ljava.util.Set;")]
	internal class _5 : AbstractSet
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Set<TE;>;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : AbstractIterator
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/util/AbstractSet<TE;>;")]
			[EnclosingMethod(null, "computeNext", "()Ljava.util.Set;")]
			internal new class _1 : AbstractSet
			{
				[SpecialName]
				[InnerClass(null, (Modifiers)0)]
				[Signature("Lcom/google/common/collect/AbstractIterator<TE;>;")]
				[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
				internal class _1 : AbstractIterator
				{
					internal int i;

					[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
					internal _5._1._1 this_00242;

					[MethodImpl(MethodImplOptions.NoInlining)]
					[LineNumberTable(new byte[] { 166, 65, 111 })]
					internal _1(_5._1._1 P_0)
					{
						this_00242 = P_0;
						base._002Ector();
						i = -1;
					}

					[MethodImpl(MethodImplOptions.NoInlining)]
					[Signature("()TE;")]
					[LineNumberTable(new byte[] { 166, 71, 126, 105, 137 })]
					[CheckForNull(new object[]
					{
						(byte)64,
						"Ljavax/annotation/CheckForNull;"
					})]
					protected internal override object computeNext()
					{
						i = this_00242.val_0024copy.nextSetBit(i + 1);
						if (i == -1)
						{
							object result = endOfData();
							_ = null;
							return result;
						}
						object result2 = this_00242.this_00241.this_00240.val_0024index.keySet().asList().get(i);
						_ = null;
						return result2;
					}
				}

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal BitSet val_0024copy;

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal _5._1 this_00241;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(1706)]
				internal _1(_5._1 P_0, BitSet P_1)
				{
					this_00241 = P_0;
					val_0024copy = P_1;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(new byte[] { 166, 59, 124 })]
				public override bool contains([CheckForNull(new object[]
				{
					(byte)64,
					"Ljavax/annotation/CheckForNull;"
				})] object P_0)
				{
					Integer integer = (Integer)this_00241.this_00240.val_0024index.get(P_0);
					return (integer != null && val_0024copy.get(integer.intValue())) ? true : false;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()Ljava/util/Iterator<TE;>;")]
				[LineNumberTable(1715)]
				public override Iterator iterator()
				{
					_1 result = new _1(this);
					_ = null;
					return result;
				}

				[LineNumberTable(1732)]
				public override int size()
				{
					return this_00241.this_00240.val_0024size;
				}
			}

			[Modifiers(Modifiers.Final)]
			internal BitSet bits;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _5 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Set<TE;>;")]
			[LineNumberTable(new byte[]
			{
				166, 28, 109, 156, 109, 141, 115, 236, 80, 113,
				113, 140, 113
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Set computeNext()
			{
				if (bits.isEmpty())
				{
					bits.set(0, this_00240.val_0024size);
				}
				else
				{
					int num = bits.nextSetBit(0);
					int num2 = bits.nextClearBit(num);
					if (num2 == this_00240.val_0024index.size())
					{
						return (Set)endOfData();
					}
					bits.set(0, num2 - num - 1);
					bits.clear(num2 - num - 1, num2);
					bits.set(num2);
				}
				BitSet bitSet = (BitSet)bits.clone();
				_1 result = new _1(this, bitSet);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 166, 22, 111 })]
			internal _1(_5 P_0)
			{
				this_00240 = P_0;
				base._002Ector();
				BitSet.___003Cclinit_003E();
				bits = new BitSet(this_00240.val_0024index.size());
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1672)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				Set result = computeNext();
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024size;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableMap val_0024index;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1660)]
		internal _5(int P_0, ImmutableMap P_1)
		{
			val_0024size = P_0;
			val_0024index = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 166, 13, 104, 103, 159, 7 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Set)
			{
				Set set = (Set)P_0;
				return (set.size() == val_0024size && val_0024index.keySet().containsAll(set)) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Set<TE;>;>;")]
		[LineNumberTable(1672)]
		public override Iterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1741)]
		public override int size()
		{
			int result = IntMath.binomial(val_0024index.size(), val_0024size);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1746)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(val_0024index.keySet());
			int i = val_0024size;
			int num = 32 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Sets.combinations(").append(text).append(", ")
				.append(i)
				.append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingCollection<Ljava/util/List<TE;>;>;Ljava/util/Set<Ljava/util/List<TE;>;>;")]
	[Implements(new string[] { "java.util.Set" })]
	internal sealed class CartesianSet : ForwardingCollection, Set, Collection, Iterable, IEnumerable
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/ImmutableList<Ljava/util/List<TE;>;>;")]
		[EnclosingMethod(null, "create", "(Ljava.util.List;)Ljava.util.Set;")]
		internal class _1 : ImmutableList
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ImmutableList val_0024axes;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(I)Ljava/util/List<TE;>;")]
			[LineNumberTable(1416)]
			public new virtual List get(int P_0)
			{
				ImmutableList result = ((ImmutableSet)val_0024axes.get(P_0)).asList();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1408)]
			internal _1(ImmutableList P_0)
			{
				val_0024axes = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1411)]
			public override int size()
			{
				int result = val_0024axes.size();
				_ = null;
				return result;
			}

			internal override bool isPartialView()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1408)]
			public override object get(int P_0)
			{
				List result = get(P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				ImmutableList.___003Cclinit_003E();
			}

			[HideFromJava]
			[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
			protected _1(SerializationInfo P_0, StreamingContext P_1)
				: base(P_0, P_1)
			{
			}
		}

		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/ImmutableSet<TE;>;>;")]
		private ImmutableList axes;

		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/CartesianList<TE;>;")]
		private new CartesianList m_delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<E:Ljava/lang/Object;>(Ljava/util/List<+Ljava/util/Set<+TE;>;>;)Ljava/util/Set<Ljava/util/List<TE;>;>;")]
		[LineNumberTable(new byte[]
		{
			165, 4, 108, 123, 103, 104, 136, 104, 98, 104,
			233, 81
		})]
		internal static Set create(List P_0)
		{
			ImmutableList.Builder builder = new ImmutableList.Builder(P_0.size());
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				Set elements = (Set)iterator.next();
				ImmutableSet immutableSet = ImmutableSet.copyOf(elements);
				if (immutableSet.isEmpty())
				{
					ImmutableSet result = ImmutableSet.of();
					_ = null;
					return result;
				}
				builder.add(immutableSet);
			}
			ImmutableList immutableList = builder.build();
			_1  = new _1(immutableList);
			CartesianSet result2 = new CartesianSet(immutableList, new CartesianList());
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/ImmutableSet<TE;>;>;Lcom/google/common/collect/CartesianList<TE;>;)V")]
		[LineNumberTable(new byte[] { 165, 33, 104, 103, 103 })]
		private CartesianSet(ImmutableList P_0, CartesianList P_1)
		{
			axes = P_0;
			this.m_delegate = P_1;
		}

		[Signature("()Ljava/util/Collection<Ljava/util/List<TE;>;>;")]
		protected internal override Collection @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			165, 45, 104, 130, 103, 115, 130, 98, 118, 121,
			130, 100, 98
		})]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (!(P_0 is List))
			{
				return false;
			}
			List list = (List)P_0;
			if (list.size() != axes.size())
			{
				return false;
			}
			int num = 0;
			Iterator iterator = list.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (!((ImmutableSet)axes.get(num)).contains(obj))
				{
					return false;
				}
				num++;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 66, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is CartesianSet)
			{
				CartesianSet cartesianSet = (CartesianSet)P_0;
				bool result = axes.equals(cartesianSet.axes);
				_ = null;
				return result;
			}
			bool result2 = base.equals(P_0);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			165, 79, 105, 112, 101, 6, 230, 69, 98, 127,
			1, 159, 3, 102, 98, 100
		})]
		public override int hashCode()
		{
			int num = base.size() - 1;
			int i;
			for (i = 0; i < axes.size(); i++)
			{
				num *= 31;
				num = num ^ -1 ^ -1;
			}
			i = 1;
			UnmodifiableIterator unmodifiableIterator = axes.iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				Set set = (Set)((Iterator)unmodifiableIterator).next();
				int num2 = 31 * i;
				int num3 = base.size();
				int num4 = set.size();
				i = num2 + ((num4 != -1) ? (num3 / num4) : (-num3)) * set.hashCode();
				i = i ^ -1 ^ -1;
			}
			i += num;
			return i ^ -1 ^ -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1392)]
		protected internal new virtual object @delegate()
		{
			Collection result = this.@delegate();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Spliterator spliterator()
		{
			return Set._003Cdefault_003Espliterator(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			return Collection._003Cdefault_003EremoveIf(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Stream stream()
		{
			return Collection._003Cdefault_003Estream(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Stream parallelStream()
		{
			return Collection._003Cdefault_003EparallelStream(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}
	}

	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingNavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 101, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)101,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class DescendingSet : ForwardingNavigableSet
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableSet<TE;>;")]
		private NavigableSet forward;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<TT;>;)Lcom/google/common/collect/Ordering<TT;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 101, 0, 0 })]
		[LineNumberTable(2099)]
		private static Ordering reverse(Comparator P_0)
		{
			Ordering result = Ordering.from(P_0).reverse();
			_ = null;
			return result;
		}

		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		protected internal override NavigableSet @delegate()
		{
			return forward;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableSet<TE;>;)V")]
		[LineNumberTable(new byte[] { 167, 91, 104, 103 })]
		internal DescendingSet(NavigableSet P_0)
		{
			forward = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(2009)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object lower([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = forward.higher(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(2015)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object floor([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = forward.ceiling(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(2021)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object ceiling([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = forward.floor(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(2027)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object higher([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = forward.lower(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(2033)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object pollFirst()
		{
			object result = forward.pollLast();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(2039)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object pollLast()
		{
			object result = forward.pollFirst();
			_ = null;
			return result;
		}

		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		public override NavigableSet descendingSet()
		{
			return forward;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(2049)]
		public override Iterator descendingIterator()
		{
			Iterator result = forward.iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(2058)]
		public override NavigableSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2, bool P_3)
		{
			NavigableSet result = forward.subSet(P_2, P_3, P_0, P_1).descendingSet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(2063)]
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
			SortedSet result = standardSubSet(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(2068)]
		public override NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = forward.tailSet(P_0, P_1).descendingSet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(2073)]
		public override SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = standardHeadSet(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(2078)]
		public override NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = forward.headSet(P_0, P_1).descendingSet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(2083)]
		public override SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = standardTailSet(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TE;>;")]
		[LineNumberTable(new byte[] { 167, 183, 108, 99, 141 })]
		public override Comparator comparator()
		{
			Comparator comparator = forward.comparator();
			if (comparator == null)
			{
				Ordering result = Ordering.natural().reverse();
				_ = null;
				return result;
			}
			Ordering result2 = reverse(comparator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(2105)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object first()
		{
			object result = forward.last();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(2111)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object last()
		{
			object result = forward.first();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(2116)]
		public override Iterator iterator()
		{
			Iterator result = forward.descendingIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 101, 0, 0 })]
		[LineNumberTable(2121)]
		public override object[] toArray()
		{
			object[] result = standardToArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 101, 0, 0 })]
		[LineNumberTable(2127)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = standardToArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2132)]
		public override string toString()
		{
			string result = standardToString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1993)]
		protected internal new virtual SortedSet @delegate()
		{
			NavigableSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1993)]
		protected internal new virtual Set @delegate()
		{
			NavigableSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1993)]
		protected internal new virtual Collection @delegate()
		{
			NavigableSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1993)]
		protected internal new virtual object @delegate()
		{
			NavigableSet result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Sets$FilteredSortedSet<TE;>;Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 82, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)82,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableSet" })]
	internal class FilteredNavigableSet : FilteredSortedSet, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableSet<TE;>;Lcom/google/common/base/Predicate<-TE;>;)V")]
		[LineNumberTable(new byte[] { 164, 59, 106 })]
		internal FilteredNavigableSet(NavigableSet P_0, com.google.common.@base.Predicate P_1)
			: base(P_0, P_1)
		{
		}

		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1201)]
		internal new virtual NavigableSet unfiltered()
		{
			return (NavigableSet)base.unfiltered;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(1207)]
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
			object result = Iterators.find(unfiltered().headSet(P_0, inclusive: false).descendingIterator(), predicate, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(1213)]
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
			object result = Iterators.find(unfiltered().headSet(P_0, inclusive: true).descendingIterator(), predicate, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(1219)]
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
			object result = Iterables.find(unfiltered().tailSet(P_0, inclusive: true), predicate, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(1225)]
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
			object result = Iterables.find(unfiltered().tailSet(P_0, inclusive: false), predicate, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(1231)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollFirst()
		{
			object result = Iterables.removeFirstMatching(unfiltered(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(1237)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollLast()
		{
			object result = Iterables.removeFirstMatching(unfiltered().descendingSet(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1242)]
		public virtual NavigableSet descendingSet()
		{
			NavigableSet result = filter(unfiltered().descendingSet(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(1247)]
		public virtual Iterator descendingIterator()
		{
			UnmodifiableIterator result = Iterators.filter(unfiltered().descendingIterator(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(1253)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object last()
		{
			object result = Iterators.find(unfiltered().descendingIterator(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 158, 83, 133, 97, 52 })]
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
			NavigableSet result = filter(unfiltered().subSet(P_0, P_1, P_2, P_3), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1268)]
		public virtual NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = filter(unfiltered().headSet(P_0, P_1), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1273)]
		public virtual NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = filter(unfiltered().tailSet(P_0, P_1), predicate);
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Collections2$FilteredCollection<TE;>;Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 39, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)39,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Set" })]
	internal class FilteredSet : Collections2.FilteredCollection, Set, Collection, Iterable, IEnumerable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Set<TE;>;Lcom/google/common/base/Predicate<-TE;>;)V")]
		[LineNumberTable(new byte[] { 163, 248, 106 })]
		internal FilteredSet(Set P_0, com.google.common.@base.Predicate P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1135)]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = equalsImpl(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1140)]
		public override int hashCode()
		{
			int result = hashCodeImpl(this);
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Sets$FilteredSet<TE;>;Ljava/util/SortedSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 66, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)66,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.SortedSet" })]
	internal class FilteredSortedSet : FilteredSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedSet<TE;>;Lcom/google/common/base/Predicate<-TE;>;)V")]
		[LineNumberTable(new byte[] { 164, 10, 106 })]
		internal FilteredSortedSet(SortedSet P_0, com.google.common.@base.Predicate P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TE;>;")]
		[LineNumberTable(1154)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			Comparator result = ((SortedSet)unfiltered).comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(new byte[] { 164, 21, 109, 50 })]
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
			FilteredSortedSet result = new FilteredSortedSet(((SortedSet)unfiltered).subSet(P_0, P_1), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1165)]
		public virtual SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			FilteredSortedSet result = new FilteredSortedSet(((SortedSet)unfiltered).headSet(P_0), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1170)]
		public virtual SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			FilteredSortedSet result = new FilteredSortedSet(((SortedSet)unfiltered).tailSet(P_0), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(1176)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object first()
		{
			object result = Iterators.find(unfiltered.iterator(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 164, 44, 140, 103, 110, 130, 104 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object last()
		{
			SortedSet sortedSet = (SortedSet)unfiltered;
			object obj;
			while (true)
			{
				obj = sortedSet.last();
				if (predicate.apply(obj))
				{
					break;
				}
				sortedSet = sortedSet.headSet(obj);
			}
			return obj;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
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

	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 31, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)31,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class ImprovedAbstractSet : AbstractSet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(79)]
		internal ImprovedAbstractSet()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(82)]
		public override bool removeAll(Collection P_0)
		{
			bool result = removeAllImpl(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(87)]
		public override bool retainAll(Collection P_0)
		{
			bool result = base.retainAll((Collection)Preconditions.checkNotNull(P_0));
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractSet<Ljava/util/Set<TE;>;>;")]
	internal sealed class PowerSet : AbstractSet
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIndexedListIterator<Ljava/util/Set<TE;>;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : AbstractIndexedListIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal PowerSet this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(I)Ljava/util/Set<TE;>;")]
			[LineNumberTable(1587)]
			protected internal new virtual Set get(int P_0)
			{
				SubSet result = new SubSet(this_00240.inputSet, P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1584)]
			internal _1(PowerSet P_0, int P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(1584)]
			protected internal override object get(int P_0)
			{
				Set result = get(P_0);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap<TE;Ljava/lang/Integer;>;")]
		internal ImmutableMap inputSet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Set<TE;>;)V")]
		[LineNumberTable(new byte[] { 165, 172, 104, 97, 55, 133, 108 })]
		internal PowerSet(Set P_0)
		{
			Preconditions.checkArgument(P_0.size() <= 30, "Too many elements to create power set: %s > 30", P_0.size());
			inputSet = Maps.indexMap(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1574)]
		public override int size()
		{
			return 1 << inputSet.size();
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Set<TE;>;>;")]
		[LineNumberTable(1584)]
		public override Iterator iterator()
		{
			_1 result = new _1(this, size());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 200, 104, 103, 148 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Set)
			{
				Set c = (Set)P_0;
				bool result = inputSet.keySet().containsAll(c);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 209, 104, 103, 158 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is PowerSet)
			{
				PowerSet powerSet = (PowerSet)P_0;
				bool result = inputSet.keySet().equals(powerSet.inputSet.keySet());
				_ = null;
				return result;
			}
			bool result2 = base.equals(P_0);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1617)]
		public override int hashCode()
		{
			return inputSet.keySet().hashCode() << inputSet.size() - 1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1622)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(inputSet);
			int num = 10 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("powerSet(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 81, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)81,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public abstract class SetView : AbstractSet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(559)]
		private SetView()
		{
		}

		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		public new abstract UnmodifiableIterator iterator();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
		[LineNumberTable(571)]
		public virtual ImmutableSet immutableCopy()
		{
			ImmutableSet result = ImmutableSet.copyOf(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<S::Ljava/util/Set<TE;>;>(TS;)TS;")]
		[LineNumberTable(new byte[] { 161, 215, 104 })]
		public virtual Set copyInto(Set set)
		{
			set.addAll(this);
			return set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[Signature("(TE;)Z")]
		[LineNumberTable(600)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public sealed override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object e)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[LineNumberTable(614)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public sealed override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object @object)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[Signature("(Ljava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(628)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public sealed override bool addAll(Collection newElements)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(642)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public sealed override bool removeAll(Collection oldElements)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[Signature("(Ljava/util/function/Predicate<-TE;>;)Z")]
		[LineNumberTable(656)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public sealed override bool removeIf(java.util.function.Predicate filter)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(670)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public sealed override bool retainAll(Collection elementsToKeep)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Obsolete]
		[LineNumberTable(683)]
		[Deprecated(new object[]
		{
			(byte)64,
			"Ljava/lang/Deprecated;"
		})]
		public sealed override void clear()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(558)]
		public virtual Iterator _003Cbridge_003Eiterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(558)]
		internal SetView(_1 P_0)
			: this()
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;")]
	internal sealed class SubSet : AbstractSet
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal class _1 : UnmodifiableIterator
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
			internal ImmutableList elements;

			internal int remainingSetBits;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal SubSet this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 165, 136, 111, 123 })]
			internal _1(SubSet P_0)
			{
				this_00240 = P_0;
				base._002Ector();
				elements = access_0024100(this_00240).keySet().asList();
				remainingSetBits = access_0024200(this_00240);
			}

			public override bool hasNext()
			{
				return (remainingSetBits != 0) ? true : false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TE;")]
			[LineNumberTable(new byte[] { 165, 147, 108, 101, 139, 117 })]
			public override object next()
			{
				int num = Integer.numberOfTrailingZeros(remainingSetBits);
				if (num == 32)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new NoSuchElementException();
				}
				remainingSetBits &= (1 << num) ^ -1;
				object result = elements.get(num);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap<TE;Ljava/lang/Integer;>;")]
		private ImmutableMap inputSet;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int mask;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<TE;Ljava/lang/Integer;>;I)V")]
		[LineNumberTable(new byte[] { 165, 129, 104, 103, 103 })]
		internal SubSet(ImmutableMap P_0, int P_1)
		{
			inputSet = P_0;
			mask = P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1519)]
		internal static ImmutableMap access_0024100(SubSet P_0)
		{
			return P_0.inputSet;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1519)]
		internal static int access_0024200(SubSet P_0)
		{
			return P_0.mask;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(1530)]
		public override Iterator iterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1553)]
		public override int size()
		{
			int result = Integer.bitCount(mask);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 164, 114 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Integer integer = (Integer)inputSet.get(P_0);
			return (integer != null && (mask & (1 << integer.intValue())) != 0) ? true : false;
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingSortedSet<TE;>;Ljava/util/NavigableSet<TE;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 115, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)115,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableSet", "java.io.Serializable" })]
	internal sealed class UnmodifiableNavigableSet : ForwardingSortedSet, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableSet<TE;>;")]
		private new NavigableSet m_delegate;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/SortedSet<TE;>;")]
		private SortedSet unmodifiableDelegate;

		[NonSerialized]
		[Signature("Lcom/google/common/collect/Sets$UnmodifiableNavigableSet<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private UnmodifiableNavigableSet m_descendingSet;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableSet<TE;>;)V")]
		[LineNumberTable(new byte[] { 166, 156, 104, 113, 108 })]
		internal UnmodifiableNavigableSet(NavigableSet P_0)
		{
			this.m_delegate = (NavigableSet)Preconditions.checkNotNull(P_0);
			unmodifiableDelegate = Collections.unmodifiableSortedSet(P_0);
		}

		[Signature("()Ljava/util/SortedSet<TE;>;")]
		protected internal override SortedSet @delegate()
		{
			return unmodifiableDelegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Predicate<-TE;>;)Z")]
		[LineNumberTable(1820)]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(1825)]
		public override Stream stream()
		{
			Stream result = this.m_delegate.stream();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/stream/Stream<TE;>;")]
		[LineNumberTable(1830)]
		public override Stream parallelStream()
		{
			Stream result = this.m_delegate.parallelStream();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
		[LineNumberTable(new byte[] { 166, 185, 110 })]
		public override void forEach(Consumer P_0)
		{
			this.m_delegate.forEach(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(1841)]
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
			object result = this.m_delegate.lower(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(1847)]
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
			object result = this.m_delegate.floor(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(1853)]
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
			object result = this.m_delegate.ceiling(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(1859)]
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
			object result = this.m_delegate.higher(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(1865)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollFirst()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(1871)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollLast()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 166, 228, 103, 99, 124, 135 })]
		public virtual NavigableSet descendingSet()
		{
			UnmodifiableNavigableSet unmodifiableNavigableSet = this.m_descendingSet;
			if (unmodifiableNavigableSet == null)
			{
				UnmodifiableNavigableSet unmodifiableNavigableSet2 = new UnmodifiableNavigableSet(this.m_delegate.descendingSet());
				this.m_descendingSet = unmodifiableNavigableSet2;
				unmodifiableNavigableSet = unmodifiableNavigableSet2;
				unmodifiableNavigableSet.m_descendingSet = this;
			}
			return unmodifiableNavigableSet;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(1888)]
		public virtual Iterator descendingIterator()
		{
			UnmodifiableIterator result = Iterators.unmodifiableIterator(this.m_delegate.descendingIterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 157, 180, 101, 106, 37 })]
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
			NavigableSet result = unmodifiableNavigableSet(this.m_delegate.subSet(P_0, P_1, P_2, P_3));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1903)]
		public virtual NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = unmodifiableNavigableSet(this.m_delegate.headSet(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1908)]
		public virtual NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = unmodifiableNavigableSet(this.m_delegate.tailSet(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1801)]
		protected internal new virtual Set @delegate()
		{
			SortedSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1801)]
		protected internal new virtual Collection @delegate()
		{
			SortedSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1801)]
		protected internal new virtual object @delegate()
		{
			SortedSet result = this.@delegate();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Spliterator spliterator()
		{
			return SortedSet._003Cdefault_003Espliterator(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
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
		protected UnmodifiableNavigableSet(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/LinkedHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(309)]
	public static LinkedHashSet newLinkedHashSet()
	{
		LinkedHashSet result = new LinkedHashSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Set<*>;)I")]
	[LineNumberTable(new byte[] { 166, 103, 98, 118, 143, 134, 98 })]
	internal static int hashCodeImpl(Set P_0)
	{
		int num = 0;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			num += ((obj != null) ? java.lang.Object.instancehelper_hashCode(obj) : 0);
			num = num ^ -1 ^ -1;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Set<*>;Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[]
	{
		157, 161, 162, 108, 109, 241, 73, 127, 10, 159,
		3
	})]
	internal static bool removeAllImpl(Set P_0, Collection P_1)
	{
		object obj = P_1;
		Preconditions.checkNotNull((Collection)obj);
		if (((Collection)obj) is Multiset)
		{
			obj = ((Multiset)(Collection)obj).elementSet();
		}
		if (obj is Set)
		{
			object obj2 = obj;
			if (((obj2 == null) ? null : ((obj2 as Collection) ?? throw new java.lang.IncompatibleClassChangeError())).size() > P_0.size())
			{
				Iterator removeFrom = P_0.iterator();
				object obj3 = obj;
				bool result = Iterators.removeAll(removeFrom, (obj3 == null) ? null : ((obj3 as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
				_ = null;
				return result;
			}
		}
		object obj4 = obj;
		bool result2 = removeAllImpl(P_0, ((obj4 == null) ? null : ((obj4 as Collection) ?? throw new java.lang.IncompatibleClassChangeError())).iterator());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Set<*>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 166, 115, 100, 130, 107, 167, 127, 36, 97, 162 })]
	internal static bool equalsImpl(Set P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		//Discarded unreachable code: IL_0035
		if (P_0 == P_1)
		{
			return true;
		}
		object obj;
		if (P_1 is Set)
		{
			Set set = (Set)P_1;
			try
			{
				try
				{
					return (P_0.size() == set.size() && P_0.containsAll(set)) ? true : false;
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<NullPointerException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
				}
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0057;
			}
			obj = null;
			goto IL_005b;
		}
		return false;
		IL_005b:
		return false;
		IL_0057:
		obj = null;
		goto IL_005b;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Set<*>;Ljava/util/Iterator<*>;)Z")]
	[LineNumberTable(new byte[] { 167, 61, 98, 104, 145 })]
	internal static bool removeAllImpl(Set P_0, Iterator P_1)
	{
		int num = 0;
		while (P_1.hasNext())
		{
			num |= (P_0.remove(P_1.next()) ? 1 : 0);
		}
		return (byte)num != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/HashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(259)]
	public static HashSet newHashSetWithExpectedSize(int expectedSize)
	{
		HashSet.___003Cclinit_003E();
		HashSet result = new HashSet(Maps.capacity(expectedSize));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/NavigableSet<TE;>;)Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 166, 145, 112, 130 })]
	public static NavigableSet unmodifiableNavigableSet(NavigableSet set)
	{
		if (set is ImmutableCollection || set is UnmodifiableNavigableSet)
		{
			return set;
		}
		UnmodifiableNavigableSet result = new UnmodifiableNavigableSet(set);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/HashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(181)]
	public static HashSet newHashSet()
	{
		HashSet result = new HashSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/LinkedHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 215, 104, 147, 102, 104 })]
	public static LinkedHashSet newLinkedHashSet(Iterable elements)
	{
		if (elements is Collection)
		{
			LinkedHashSet.___003Cclinit_003E();
			LinkedHashSet result = new LinkedHashSet((Collection)elements);
			_ = null;
			return result;
		}
		LinkedHashSet linkedHashSet = newLinkedHashSet();
		Iterables.addAll(linkedHashSet, elements);
		return linkedHashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;Lcom/google/common/base/Predicate<-TE;>;)Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 155, 104, 143, 168, 103, 109, 180 })]
	public static Set filter(Set unfiltered, com.google.common.@base.Predicate predicate)
	{
		if (unfiltered is SortedSet)
		{
			SortedSet result = filter((SortedSet)unfiltered, predicate);
			_ = null;
			return result;
		}
		if (unfiltered is FilteredSet)
		{
			FilteredSet filteredSet = (FilteredSet)unfiltered;
			com.google.common.@base.Predicate predicate2 = Predicates.and(filteredSet.predicate, predicate);
			FilteredSet result2 = new FilteredSet((Set)filteredSet.unfiltered, predicate2);
			_ = null;
			return result2;
		}
		FilteredSet result3 = new FilteredSet((Set)Preconditions.checkNotNull(unfiltered), (com.google.common.@base.Predicate)Preconditions.checkNotNull(predicate));
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<+TE;>;Ljava/util/Set<+TE;>;)Lcom/google/common/collect/Sets$SetView<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 81, 108, 140 })]
	public static SetView union(Set set1, Set set2)
	{
		Preconditions.checkNotNull((object)set1, (object)"set1");
		Preconditions.checkNotNull((object)set2, (object)"set2");
		_1 result = new _1(set1, set2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;Ljava/util/Set<*>;)Lcom/google/common/collect/Sets$SetView<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 183, 108, 140 })]
	public static SetView intersection(Set set1, Set set2)
	{
		Preconditions.checkNotNull((object)set1, (object)"set1");
		Preconditions.checkNotNull((object)set2, (object)"set2");
		_2 result = new _2(set1, set2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/LinkedHashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(351)]
	public static LinkedHashSet newLinkedHashSetWithExpectedSize(int expectedSize)
	{
		LinkedHashSet.___003Cclinit_003E();
		LinkedHashSet result = new LinkedHashSet(Maps.capacity(expectedSize));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Iterator<+TE;>;)Ljava/util/HashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 126, 102, 104 })]
	public static HashSet newHashSet(Iterator elements)
	{
		HashSet hashSet = newHashSet();
		Iterators.addAll(hashSet, elements);
		return hashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/Set<TE;>;")]
	[LineNumberTable(273)]
	public static Set newConcurrentHashSet()
	{
		Set result = Platform.newConcurrentHashSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>()Ljava/util/TreeSet<TE;>;")]
	[LineNumberTable(369)]
	public static TreeSet newTreeSet()
	{
		TreeSet result = new TreeSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/util/Collection<TE;>;Ljava/lang/Class<TE;>;)Ljava/util/EnumSet<TE;>;")]
	[LineNumberTable(new byte[] { 161, 139, 103, 104 })]
	private static EnumSet makeComplementByHand(Collection P_0, Class P_1)
	{
		EnumSet enumSet = EnumSet.allOf(P_1);
		enumSet.removeAll(P_0);
		return enumSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;Lcom/google/common/base/Predicate<-TE;>;)Ljava/util/SortedSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 195, 168, 103, 109, 180 })]
	public static SortedSet filter(SortedSet unfiltered, com.google.common.@base.Predicate predicate)
	{
		if (unfiltered is FilteredSet)
		{
			FilteredSet filteredSet = (FilteredSet)unfiltered;
			com.google.common.@base.Predicate predicate2 = Predicates.and(filteredSet.predicate, predicate);
			FilteredSortedSet result = new FilteredSortedSet((SortedSet)filteredSet.unfiltered, predicate2);
			_ = null;
			return result;
		}
		FilteredSortedSet result2 = new FilteredSortedSet((SortedSet)Preconditions.checkNotNull(unfiltered), (com.google.common.@base.Predicate)Preconditions.checkNotNull(predicate));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>(Ljava/util/List<+Ljava/util/Set<+TB;>;>;)Ljava/util/Set<Ljava/util/List<TB;>;>;")]
	[LineNumberTable(1331)]
	public static Set cartesianProduct(List sets)
	{
		Set result = CartesianSet.create(sets);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	private Sets()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(TE;[TE;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(106)]
	public static ImmutableSet immutableEnumSet(java.lang.Enum anElement, params java.lang.Enum[] otherElements)
	{
		ImmutableSet result = ImmutableEnumSet.asImmutable(EnumSet.of(anElement, otherElements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Iterable<TE;>;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[]
	{
		72, 104, 103, 104, 103, 104, 136, 174, 103, 104,
		113, 104, 137
	})]
	public static ImmutableSet immutableEnumSet(Iterable elements)
	{
		if (elements is ImmutableEnumSet)
		{
			return (ImmutableEnumSet)elements;
		}
		if (elements is Collection)
		{
			Collection collection = (Collection)elements;
			if (collection.isEmpty())
			{
				ImmutableSet result = ImmutableSet.of();
				_ = null;
				return result;
			}
			ImmutableSet result2 = ImmutableEnumSet.asImmutable(EnumSet.copyOf(collection));
			_ = null;
			return result2;
		}
		Iterator iterator = elements.iterator();
		if (iterator.hasNext())
		{
			EnumSet enumSet = EnumSet.of((java.lang.Enum)iterator.next());
			Iterators.addAll(enumSet, iterator);
			ImmutableSet result3 = ImmutableEnumSet.asImmutable(enumSet);
			_ = null;
			return result3;
		}
		ImmutableSet result4 = ImmutableSet.of();
		_ = null;
		return result4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>()Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableSet<TE;>;>;")]
	[LineNumberTable(151)]
	public static Collector toImmutableEnumSet()
	{
		Collector result = CollectCollectors.toImmutableEnumSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/lang/Iterable<TE;>;Ljava/lang/Class<TE;>;)Ljava/util/EnumSet<TE;>;")]
	[LineNumberTable(new byte[] { 111, 103, 104 })]
	public static EnumSet newEnumSet(Iterable iterable, Class elementType)
	{
		EnumSet enumSet = EnumSet.noneOf(elementType);
		Iterables.addAll(enumSet, iterable);
		return enumSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Ljava/util/HashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 84, 104, 104 })]
	public static HashSet newHashSet(params object[] elements)
	{
		HashSet hashSet = newHashSetWithExpectedSize(elements.Length);
		Collections.addAll(hashSet, elements);
		return hashSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/HashSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 108, 104, 114, 13 })]
	public static HashSet newHashSet(Iterable elements)
	{
		HashSet result;
		if (elements is Collection)
		{
			HashSet.___003Cclinit_003E();
			result = new HashSet((Collection)elements);
		}
		else
		{
			result = newHashSet(elements.iterator());
		}
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 160, 176, 102, 104 })]
	public static Set newConcurrentHashSet(Iterable elements)
	{
		Set set = newConcurrentHashSet();
		Iterables.addAll(set, elements);
		return set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/TreeSet<TE;>;")]
	[LineNumberTable(new byte[] { 161, 24, 102, 104 })]
	public static TreeSet newTreeSet(Iterable elements)
	{
		TreeSet treeSet = newTreeSet();
		Iterables.addAll(treeSet, elements);
		return treeSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;)Ljava/util/TreeSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(417)]
	public static TreeSet newTreeSet(Comparator comparator)
	{
		TreeSet.___003Cclinit_003E();
		TreeSet result = new TreeSet((Comparator)Preconditions.checkNotNull(comparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(430)]
	public static Set newIdentityHashSet()
	{
		Set result = Collections.newSetFromMap(Maps.newIdentityHashMap());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/concurrent/CopyOnWriteArraySet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(444)]
	public static CopyOnWriteArraySet newCopyOnWriteArraySet()
	{
		CopyOnWriteArraySet result = new CopyOnWriteArraySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/concurrent/CopyOnWriteArraySet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 90, 104, 104, 103 })]
	public static CopyOnWriteArraySet newCopyOnWriteArraySet(Iterable elements)
	{
		object obj = ((!(elements is Collection)) ? Lists.newArrayList(elements) : ((Collection)elements));
		CopyOnWriteArraySet result = new CopyOnWriteArraySet((obj == null) ? null : ((obj as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/util/Collection<TE;>;)Ljava/util/EnumSet<TE;>;")]
	[LineNumberTable(new byte[] { 161, 110, 104, 142, 97, 48, 133, 118 })]
	public static EnumSet complementOf(Collection collection)
	{
		if (collection is EnumSet)
		{
			EnumSet result = EnumSet.complementOf((EnumSet)collection);
			_ = null;
			return result;
		}
		Preconditions.checkArgument((!collection.isEmpty()) ? true : false, (object)"collection is empty; use the other version of this method");
		Class declaringClass = ((java.lang.Enum)collection.iterator().next()).getDeclaringClass();
		EnumSet result2 = makeComplementByHand(collection, declaringClass);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>(Ljava/util/Collection<TE;>;Ljava/lang/Class<TE;>;)Ljava/util/EnumSet<TE;>;")]
	[LineNumberTable(new byte[] { 161, 131, 103, 104, 109, 9 })]
	public static EnumSet complementOf(Collection collection, Class type)
	{
		Preconditions.checkNotNull(collection);
		EnumSet result = ((!(collection is EnumSet)) ? makeComplementByHand(collection, type) : EnumSet.complementOf((EnumSet)collection));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Map<TE;Ljava/lang/Boolean;>;)Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(546)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Set newSetFromMap(Map map)
	{
		Set result = Collections.newSetFromMap(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;Ljava/util/Set<*>;)Lcom/google/common/collect/Sets$SetView<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 0, 108, 140 })]
	public static SetView difference(Set set1, Set set2)
	{
		Preconditions.checkNotNull((object)set1, (object)"set1");
		Preconditions.checkNotNull((object)set2, (object)"set2");
		_3 result = new _3(set1, set2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<+TE;>;Ljava/util/Set<+TE;>;)Lcom/google/common/collect/Sets$SetView<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 69, 108, 140 })]
	public static SetView symmetricDifference(Set set1, Set set2)
	{
		Preconditions.checkNotNull((object)set1, (object)"set1");
		Preconditions.checkNotNull((object)set2, (object)"set2");
		_4 result = new _4(set1, set2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/NavigableSet<TE;>;Lcom/google/common/base/Predicate<-TE;>;)Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 234, 168, 103, 109, 180 })]
	public static NavigableSet filter(NavigableSet unfiltered, com.google.common.@base.Predicate predicate)
	{
		if (unfiltered is FilteredSet)
		{
			FilteredSet filteredSet = (FilteredSet)unfiltered;
			com.google.common.@base.Predicate predicate2 = Predicates.and(filteredSet.predicate, predicate);
			FilteredNavigableSet result = new FilteredNavigableSet((NavigableSet)filteredSet.unfiltered, predicate2);
			_ = null;
			return result;
		}
		FilteredNavigableSet result2 = new FilteredNavigableSet((NavigableSet)Preconditions.checkNotNull(unfiltered), (com.google.common.@base.Predicate)Preconditions.checkNotNull(predicate));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<B:Ljava/lang/Object;>([Ljava/util/Set<+TB;>;)Ljava/util/Set<Ljava/util/List<TB;>;>;")]
	[LineNumberTable(1389)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static Set cartesianProduct(params Set[] sets)
	{
		Set result = cartesianProduct(Arrays.asList(sets));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;)Ljava/util/Set<Ljava/util/Set<TE;>;>;")]
	[LineNumberTable(1516)]
	public static Set powerSet(Set set)
	{
		PowerSet result = new PowerSet(set);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;I)Ljava/util/Set<Ljava/util/Set<TE;>;>;")]
	[LineNumberTable(new byte[] { 166, 2, 103, 108, 125, 99, 109, 105, 142 })]
	public static Set combinations(Set set, int size)
	{
		ImmutableMap immutableMap = Maps.indexMap(set);
		CollectPreconditions.checkNonnegative(size, "size");
		Preconditions.checkArgument(size <= immutableMap.size(), "size (%s) must be <= set.size() (%s)", size, immutableMap.size());
		if (size == 0)
		{
			ImmutableSet result = ImmutableSet.of(ImmutableSet.of());
			_ = null;
			return result;
		}
		if (size == immutableMap.size())
		{
			ImmutableSet result2 = ImmutableSet.of(immutableMap.keySet());
			_ = null;
			return result2;
		}
		_5 result3 = new _5(size, immutableMap);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/NavigableSet<TE;>;)Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 196, 0, 0 })]
	[LineNumberTable(1962)]
	public static NavigableSet synchronizedNavigableSet(NavigableSet navigableSet)
	{
		NavigableSet result = Synchronized.navigableSet(navigableSet);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;>(Ljava/util/NavigableSet<TK;>;Lcom/google/common/collect/Range<TK;>;)Ljava/util/NavigableSet<TK;>;")]
	[LineNumberTable(new byte[]
	{
		167, 250, 105, 109, 104, 103, 97, 63, 2, 197,
		112, 98, 102, 109, 102, 236, 60, 232, 69, 104,
		124, 104, 156
	})]
	public static NavigableSet subSet(NavigableSet set, Range range)
	{
		if (set.comparator() != null && set.comparator() != Ordering.natural() && range.hasLowerBound() && range.hasUpperBound())
		{
			Preconditions.checkArgument(set.comparator().compare(range.lowerEndpoint(), range.upperEndpoint()) <= 0, (object)"set is using a custom comparator which is inconsistent with the natural ordering.");
		}
		if (range.hasLowerBound() && range.hasUpperBound())
		{
			NavigableSet result = set.subSet(range.lowerEndpoint(), range.lowerBoundType() == BoundType.___003C_003ECLOSED, range.upperEndpoint(), range.upperBoundType() == BoundType.___003C_003ECLOSED);
			_ = null;
			return result;
		}
		if (range.hasLowerBound())
		{
			NavigableSet result2 = set.tailSet(range.lowerEndpoint(), range.lowerBoundType() == BoundType.___003C_003ECLOSED);
			_ = null;
			return result2;
		}
		if (range.hasUpperBound())
		{
			NavigableSet result3 = set.headSet(range.upperEndpoint(), range.upperBoundType() == BoundType.___003C_003ECLOSED);
			_ = null;
			return result3;
		}
		return (NavigableSet)Preconditions.checkNotNull(set);
	}
}
