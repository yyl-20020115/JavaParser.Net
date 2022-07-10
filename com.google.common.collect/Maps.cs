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
	(ushort)283,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Maps : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/TransformedIterator<Ljava/util/Map$Entry<TK;TV;>;TK;>;")]
	[EnclosingMethod(null, "keyIterator", "(Ljava.util.Iterator;)Ljava.util.Iterator;")]
	internal class _1 : TransformedIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV;>;)TK;")]
		[LineNumberTable(128)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal virtual object transform(Map.Entry P_0)
		{
			object key = P_0.getKey();
			_ = null;
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(124)]
		internal _1(Iterator P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(124)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object transform(object P_0)
		{
			object result = transform((Map.Entry)P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<TV1;TV2;>;")]
	[EnclosingMethod(null, "asValueToValueFunction", "(Lcom.google.common.collect.Maps$EntryTransformer;Ljava.lang.Object;)Lcom.google.common.base.Function;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class _10 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal EntryTransformer val_0024transformer;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024key;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2126)]
		internal _10(EntryTransformer P_0, object P_1)
		{
			val_0024transformer = P_0;
			val_0024key = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV1;)TV2;")]
		[LineNumberTable(2130)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = val_0024transformer.transformEntry(val_0024key, P_0);
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
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Map$Entry<TK;TV1;>;TV2;>;")]
	[EnclosingMethod(null, "asEntryToValueFunction", "(Lcom.google.common.collect.Maps$EntryTransformer;)Lcom.google.common.base.Function;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class _11 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal EntryTransformer val_0024transformer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2140)]
		internal _11(EntryTransformer P_0)
		{
			val_0024transformer = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV1;>;)TV2;")]
		[LineNumberTable(2144)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object apply(Map.Entry P_0)
		{
			object result = val_0024transformer.transformEntry(P_0.getKey(), P_0.getValue());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2140)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object apply(object P_0)
		{
			object result = apply((Map.Entry)P_0);
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
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/AbstractMapEntry<TK;TV2;>;")]
	[EnclosingMethod(null, "transformEntry", "(Lcom.google.common.collect.Maps$EntryTransformer;Ljava.util.Map$Entry;)Ljava.util.Map$Entry;")]
	internal class _12 : AbstractMapEntry
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Map.Entry val_0024entry;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal EntryTransformer val_0024transformer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2155)]
		internal _12(Map.Entry P_0, EntryTransformer P_1)
		{
			val_0024entry = P_0;
			val_0024transformer = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(2159)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getKey()
		{
			object key = val_0024entry.getKey();
			_ = null;
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV2;")]
		[LineNumberTable(2165)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getValue()
		{
			object result = val_0024transformer.transformEntry(val_0024entry.getKey(), val_0024entry.getValue());
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Map$Entry<TK;TV1;>;Ljava/util/Map$Entry<TK;TV2;>;>;")]
	[EnclosingMethod(null, "asEntryToEntryFunction", "(Lcom.google.common.collect.Maps$EntryTransformer;)Lcom.google.common.base.Function;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class _13 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal EntryTransformer val_0024transformer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2175)]
		internal _13(EntryTransformer P_0)
		{
			val_0024transformer = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV1;>;)Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2178)]
		public virtual Map.Entry apply(Map.Entry P_0)
		{
			Map.Entry result = transformEntry(val_0024transformer, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2175)]
		public virtual object apply(object P_0)
		{
			Map.Entry result = apply((Map.Entry)P_0);
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
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/TransformedIterator<Ljava/util/Map$Entry<TK;TV;>;TV;>;")]
	[EnclosingMethod(null, "valueIterator", "(Ljava.util.Iterator;)Ljava.util.Iterator;")]
	internal class _2 : TransformedIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(135)]
		internal _2(Iterator P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV;>;)TV;")]
		[LineNumberTable(139)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal virtual object transform(Map.Entry P_0)
		{
			object value = P_0.getValue();
			_ = null;
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(135)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object transform(object P_0)
		{
			object result = transform((Map.Entry)P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/TransformedIterator<TK;Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "asMapEntryIterator", "(Ljava.util.Set;Lcom.google.common.base.Function;)Ljava.util.Iterator;")]
	internal class _3 : TransformedIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal com.google.common.@base.Function val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(998)]
		internal _3(Iterator P_0, com.google.common.@base.Function P_1)
		{
			val_0024function = P_1;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(1001)]
		internal new virtual Map.Entry transform([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map.Entry result = immutableEntry(P_0, val_0024function.apply(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(998)]
		internal override object transform([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map.Entry result = transform(P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/ForwardingSet<TE;>;")]
	[EnclosingMethod(null, "removeOnlySet", "(Ljava.util.Set;)Ljava.util.Set;")]
	internal class _4 : ForwardingSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024set;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1159)]
		internal _4(Set P_0)
		{
			val_0024set = P_0;
			base._002Ector();
		}

		[Signature("()Ljava/util/Set<TE;>;")]
		protected internal override Set @delegate()
		{
			return val_0024set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(1167)]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(1172)]
		public override bool addAll(Collection P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1159)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1159)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/ForwardingSortedSet<TE;>;")]
	[EnclosingMethod(null, "removeOnlySortedSet", "(Ljava.util.SortedSet;)Ljava.util.SortedSet;")]
	internal class _5 : ForwardingSortedSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal SortedSet val_0024set;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1179)]
		internal _5(SortedSet P_0)
		{
			val_0024set = P_0;
			base._002Ector();
		}

		[Signature("()Ljava/util/SortedSet<TE;>;")]
		protected internal override SortedSet @delegate()
		{
			return val_0024set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(1187)]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(1192)]
		public override bool addAll(Collection P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1197)]
		public override SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = access_0024300(base.headSet(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1203)]
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
			SortedSet result = access_0024300(base.subSet(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1208)]
		public override SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = access_0024300(base.tailSet(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1179)]
		protected internal new virtual Set @delegate()
		{
			SortedSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1179)]
		protected internal new virtual Collection @delegate()
		{
			SortedSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1179)]
		protected internal new virtual object @delegate()
		{
			SortedSet result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/ForwardingNavigableSet<TE;>;")]
	[EnclosingMethod(null, "removeOnlyNavigableSet", "(Ljava.util.NavigableSet;)Ljava.util.NavigableSet;")]
	internal class _6 : ForwardingNavigableSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal NavigableSet val_0024set;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1216)]
		internal _6(NavigableSet P_0)
		{
			val_0024set = P_0;
			base._002Ector();
		}

		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		protected internal override NavigableSet @delegate()
		{
			return val_0024set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(1224)]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(1229)]
		public override bool addAll(Collection P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1234)]
		public override SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = access_0024300(base.headSet(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1239)]
		public override NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = access_0024400(base.headSet(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1245)]
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
			SortedSet result = access_0024300(base.subSet(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 158, 85, 133, 101, 37 })]
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
			NavigableSet result = access_0024400(base.subSet(P_0, P_1, P_2, P_3));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(1260)]
		public override SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedSet result = access_0024300(base.tailSet(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1265)]
		public override NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = access_0024400(base.tailSet(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(1270)]
		public override NavigableSet descendingSet()
		{
			NavigableSet result = access_0024400(base.descendingSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1216)]
		protected internal new virtual SortedSet @delegate()
		{
			NavigableSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1216)]
		protected internal new virtual Set @delegate()
		{
			NavigableSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1216)]
		protected internal new virtual Collection @delegate()
		{
			NavigableSet result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1216)]
		protected internal new virtual object @delegate()
		{
			NavigableSet result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/AbstractMapEntry<TK;TV;>;")]
	[EnclosingMethod(null, "unmodifiableEntry", "(Ljava.util.Map$Entry;)Ljava.util.Map$Entry;")]
	internal class _7 : AbstractMapEntry
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Map.Entry val_0024entry;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1494)]
		internal _7(Map.Entry P_0)
		{
			val_0024entry = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1498)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getKey()
		{
			object key = val_0024entry.getKey();
			_ = null;
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(1504)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getValue()
		{
			object value = val_0024entry.getValue();
			_ = null;
			return value;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "unmodifiableEntryIterator", "(Ljava.util.Iterator;)Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _8 : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024entryIterator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1512)]
		internal _8(Iterator P_0)
		{
			val_0024entryIterator = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(1520)]
		public new virtual Map.Entry next()
		{
			Map.Entry result = unmodifiableEntry((Map.Entry)val_0024entryIterator.next());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1515)]
		public override bool hasNext()
		{
			bool result = val_0024entryIterator.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1512)]
		public override object next()
		{
			Map.Entry result = next();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/collect/Maps$EntryTransformer<TK;TV1;TV2;>;")]
	[EnclosingMethod(null, "asEntryTransformer", "(Lcom.google.common.base.Function;)Lcom.google.common.collect.Maps$EntryTransformer;")]
	internal class _9 : java.lang.Object, EntryTransformer
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal com.google.common.@base.Function val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2113)]
		internal _9(com.google.common.@base.Function P_0)
		{
			val_0024function = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV1;)TV2;")]
		[LineNumberTable(2117)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object transformEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			object result = val_0024function.apply(P_1);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$ViewCachingAbstractMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 90, 0, 0,
		17, 1, 0, 0, 0, 90, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)90,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class AbstractFilteredMap : ViewCachingAbstractMap
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map unfiltered;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal com.google.common.@base.Predicate predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;TV;)Z")]
		[LineNumberTable(new byte[] { 170, 250, 98 })]
		internal virtual bool apply([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			bool result = predicate.apply(immutableEntry(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2945)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (unfiltered.containsKey(P_0) && apply(P_0, unfiltered.get(P_0))) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 170, 241, 104, 103, 103 })]
		internal AbstractFilteredMap(Map P_0, com.google.common.@base.Predicate P_1)
		{
			unfiltered = P_0;
			predicate = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(new byte[] { 171, 1, 109 })]
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
			Preconditions.checkArgument(apply(P_0, P_1));
			object result = unfiltered.put(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
		[LineNumberTable(new byte[] { 171, 7, 127, 1, 119, 98, 110 })]
		public override void putAll(Map P_0)
		{
			Iterator iterator = P_0.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				Preconditions.checkArgument(apply(entry.getKey(), entry.getValue()));
			}
			unfiltered.putAll(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 171, 21, 109 })]
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
			object obj = unfiltered.get(P_0);
			return (obj == null || !apply(P_0, obj)) ? null : obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2957)]
		public override bool isEmpty()
		{
			bool result = entrySet().isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(2963)]
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
			return (!containsKey(P_0)) ? null : unfiltered.remove(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(2968)]
		internal override Collection createValues()
		{
			FilteredMapValues result = new FilteredMapValues(this, unfiltered, predicate);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$ViewCachingAbstractMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 91, 0, 0,
		17, 1, 0, 0, 0, 91, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)91,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class AsMapView : ViewCachingAbstractMap
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/Maps$EntrySet<TK;TV;>;")]
		[EnclosingMethod(null, "createEntrySet", "()Ljava.util.Set;")]
		internal class _1EntrySetImpl : EntrySet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AsMapView this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(974)]
			internal _1EntrySetImpl(AsMapView P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[Signature("()Ljava/util/Map<TK;TV;>;")]
			internal override Map map()
			{
				return this_00240;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(982)]
			public override Iterator iterator()
			{
				Iterator result = asMapEntryIterator(this_00240.backingSet(), this_00240.function);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly AsMapView arg_00241;

			private readonly BiConsumer arg_00242;

			internal ___003C_003EAnon0(AsMapView P_0, BiConsumer P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024forEach_00240(arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Set<TK;>;")]
		private Set set;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TK;TV;>;")]
		internal com.google.common.@base.Function function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Set<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 29, 104, 113, 113 })]
		internal AsMapView(Set P_0, com.google.common.@base.Function P_1)
		{
			set = (Set)Preconditions.checkNotNull(P_0);
			function = (com.google.common.@base.Function)Preconditions.checkNotNull(P_1);
		}

		[Signature("()Ljava/util/Set<TK;>;")]
		internal virtual Set backingSet()
		{
			return set;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;TV;)TV;")]
		[LineNumberTable(new byte[] { 163, 63, 142, 98, 143 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object getOrDefault([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			if (Collections2.safeContains(backingSet(), P_0))
			{
				object result = function.apply(P_0);
				_ = null;
				return result;
			}
			return P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(992)]
		private void lambda_0024forEach_00240(BiConsumer P_0, object P_1)
		{
			P_0.accept(P_1, function.apply(P_1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(918)]
		public override Set createKeySet()
		{
			Set result = access_0024200(backingSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(923)]
		internal override Collection createValues()
		{
			Collection result = Collections2.transform(set, function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(928)]
		public override int size()
		{
			int result = backingSet().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(933)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = backingSet().contains(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(939)]
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
			object orDefault = getOrDefault(P_0, null);
			_ = null;
			return orDefault;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 163, 75, 142, 98, 143 })]
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
			if (backingSet().remove(P_0))
			{
				object result = function.apply(P_0);
				_ = null;
				return result;
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 86, 109 })]
		public override void clear()
		{
			backingSet().clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(985)]
		protected internal override Set createEntrySet()
		{
			_1EntrySetImpl result = new _1EntrySetImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 108, 135, 121 })]
		public override void forEach(BiConsumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			backingSet().forEach(new ___003C_003EAnon0(this, P_0));
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>Lcom/google/common/base/Converter<TA;TB;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class BiMapConverter : Converter, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/BiMap<TA;TB;>;")]
		private BiMap bimap;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BiMap<TA;TB;>;)V")]
		[LineNumberTable(new byte[] { 165, 208, 104, 113 })]
		internal BiMapConverter(BiMap P_0)
		{
			bimap = (BiMap)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<X:Ljava/lang/Object;Y:Ljava/lang/Object;>(Lcom/google/common/collect/BiMap<TX;TY;>;TX;)TY;")]
		[LineNumberTable(new byte[] { 165, 223, 104, 114 })]
		private static object convert(BiMap P_0, object P_1)
		{
			object obj = P_0.get(P_1);
			Preconditions.checkArgument(obj != null, "No non-null mapping present for input: %s", P_1);
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;)TB;")]
		[LineNumberTable(1608)]
		protected internal override object doForward(object P_0)
		{
			object result = convert(bimap, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TB;)TA;")]
		[LineNumberTable(1613)]
		protected internal override object doBackward(object P_0)
		{
			object result = convert(bimap.inverse(), P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 230, 104, 103, 148 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is BiMapConverter)
			{
				BiMapConverter biMapConverter = (BiMapConverter)P_0;
				bool result = java.lang.Object.instancehelper_equals(bimap, biMapConverter.bimap);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1633)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(bimap);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1639)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(bimap);
			int num = 18 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("Maps.asConverter(").append(text).append(")")
				.toString();
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
		protected BiMapConverter(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 89, 0, 0,
		17, 1, 0, 0, 0, 89, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)89,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableMap" })]
	internal abstract class DescendingMap : ForwardingMap, NavigableMap, SortedMap, Map
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/Maps$EntrySet<TK;TV;>;")]
		[EnclosingMethod(null, "createEntrySet", "()Ljava.util.Set;")]
		internal class _1EntrySetImpl : EntrySet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal DescendingMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(4510)]
			internal _1EntrySetImpl(DescendingMap P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[Signature("()Ljava/util/Map<TK;TV;>;")]
			internal override Map map()
			{
				return this_00240;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(4518)]
			public override Iterator iterator()
			{
				Iterator result = this_00240.entryIterator();
				_ = null;
				return result;
			}
		}

		[NonSerialized]
		[Signature("Ljava/util/Comparator<-TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Comparator m_comparator;

		[NonSerialized]
		[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new Set m_entrySet;

		[NonSerialized]
		[Signature("Ljava/util/NavigableSet<TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private NavigableSet m_navigableKeySet;

		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		internal abstract NavigableMap forward();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<TT;>;)Lcom/google/common/collect/Ordering<TT;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 89, 0, 0 })]
		[LineNumberTable(4406)]
		private static Ordering reverse(Comparator P_0)
		{
			Ordering result = Ordering.from(P_0).reverse();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(4521)]
		internal virtual Set createEntrySet()
		{
			_1EntrySetImpl result = new _1EntrySetImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(new byte[] { 177, 67, 103 })]
		public virtual NavigableSet navigableKeySet()
		{
			NavigableSet navigableSet = this.m_navigableKeySet;
			object navigableSet2;
			if (navigableSet == null)
			{
				NavigableKeySet navigableKeySet = new NavigableKeySet(this);
				navigableSet2 = navigableKeySet;
				this.m_navigableKeySet = navigableKeySet;
			}
			else
			{
				navigableSet2 = navigableSet;
			}
			return (navigableSet2 == null) ? null : ((navigableSet2 as NavigableSet) ?? throw new java.lang.IncompatibleClassChangeError());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(4548)]
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
			NavigableMap result = forward().subMap(P_2, P_3, P_0, P_1).descendingMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(4558)]
		public virtual NavigableMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = forward().tailMap(P_0, P_1).descendingMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(4568)]
		public virtual NavigableMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = forward().headMap(P_0, P_1).descendingMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TK;TV;>;")]
		[LineNumberTable(4385)]
		protected internal sealed override Map @delegate()
		{
			NavigableMap result = forward();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4378)]
		internal DescendingMap()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(new byte[] { 176, 183, 103, 104, 108, 104, 134, 159, 6 })]
		public virtual Comparator comparator()
		{
			object obj = this.m_comparator;
			if ((Comparator)obj == null)
			{
				object obj2 = forward().comparator();
				if ((Comparator)obj2 == null)
				{
					obj2 = Ordering.natural();
				}
				object obj3 = obj2;
				Ordering ordering = reverse((obj3 == null) ? null : ((obj3 as Comparator) ?? throw new java.lang.IncompatibleClassChangeError()));
				this.m_comparator = ordering;
				obj = ordering;
			}
			object obj4 = obj;
			return (obj4 == null) ? null : ((obj4 as Comparator) ?? throw new java.lang.IncompatibleClassChangeError());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(4412)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object firstKey()
		{
			object result = forward().lastKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(4418)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object lastKey()
		{
			object result = forward().firstKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4424)]
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
			Map.Entry result = forward().higherEntry(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(4430)]
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
			object result = forward().higherKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4436)]
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
			Map.Entry result = forward().ceilingEntry(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(4442)]
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
			object result = forward().ceilingKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4448)]
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
			Map.Entry result = forward().floorEntry(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(4454)]
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
			object result = forward().floorKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4460)]
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
			Map.Entry result = forward().lowerEntry(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(4466)]
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
			object result = forward().lowerKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4472)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry firstEntry()
		{
			Map.Entry result = forward().lastEntry();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4478)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry lastEntry()
		{
			Map.Entry result = forward().firstEntry();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4484)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry pollFirstEntry()
		{
			Map.Entry result = forward().pollLastEntry();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(4490)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry pollLastEntry()
		{
			Map.Entry result = forward().pollFirstEntry();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(4495)]
		public virtual NavigableMap descendingMap()
		{
			NavigableMap result = forward();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 177, 36, 103 })]
		public override Set entrySet()
		{
			Set set = this.m_entrySet;
			Set result;
			if (set == null)
			{
				Set set2 = createEntrySet();
				result = set2;
				this.m_entrySet = set2;
			}
			else
			{
				result = set;
			}
			return result;
		}

		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal abstract Iterator entryIterator();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(4526)]
		public override Set keySet()
		{
			NavigableSet result = navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(4539)]
		public virtual NavigableSet descendingKeySet()
		{
			NavigableSet result = forward().navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(4553)]
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
			NavigableMap result = subMap(P_0, true, P_1, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(4563)]
		public virtual SortedMap headMap([ParametricNullness(new object[]
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
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(4573)]
		public virtual SortedMap tailMap([ParametricNullness(new object[]
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
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(4578)]
		public override Collection values()
		{
			Values result = new Values(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4583)]
		public override string toString()
		{
			string result = standardToString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(4377)]
		protected internal new virtual object @delegate()
		{
			Map result = this.@delegate();
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/Maps$EntryFunction;>;Lcom/google/common/base/Function<Ljava/util/Map$Entry<**>;Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 16, 0, 0, 1, 3, 1, 0, 55,
		0, 0
	})]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)55,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal abstract class EntryFunction : java.lang.Enum, com.google.common.@base.Function, java.util.function.Function
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : EntryFunction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(96)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map$Entry<**>;)Ljava/lang/Object;")]
			[LineNumberTable(100)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public virtual object apply(Map.Entry P_0)
			{
				object key = P_0.getKey();
				_ = null;
				return key;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(96)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public override object apply(object P_0)
			{
				object result = apply((Map.Entry)P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _1()
			{
				EntryFunction.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : EntryFunction
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(103)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map$Entry<**>;)Ljava/lang/Object;")]
			[LineNumberTable(107)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public virtual object apply(Map.Entry P_0)
			{
				object value = P_0.getValue();
				_ = null;
				return value;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(103)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public override object apply(object P_0)
			{
				object result = apply((Map.Entry)P_0);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _2()
			{
				EntryFunction.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFunction KEY;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EntryFunction VALUE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static EntryFunction[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(95)]
		private EntryFunction(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(95)]
		private static EntryFunction[] _0024values()
		{
			return new EntryFunction[2] { KEY, VALUE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(95)]
		public static EntryFunction[] values()
		{
			return (EntryFunction[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(95)]
		public static EntryFunction valueOf(string P_0)
		{
			return (EntryFunction)java.lang.Enum.valueOf(ClassLiteral<EntryFunction>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(95)]
		internal EntryFunction(string P_0, int P_1, Maps._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 46, 240, 71, 240, 56 })]
		static EntryFunction()
		{
			KEY = new _1("KEY", 0);
			VALUE = new _2("VALUE", 1);
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract object apply(object P_0);

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
			return equals(P_0);
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Sets$ImprovedAbstractSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
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
	internal abstract class EntrySet : Sets.ImprovedAbstractSet
	{
		[Signature("()Ljava/util/Map<TK;TV;>;")]
		internal abstract Map map();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 108, 104, 103, 103, 109, 159, 5 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				object key = entry.getKey();
				object obj = safeGet(map(), key);
				return (com.google.common.@base.Objects.equal(obj, entry.getValue()) && (obj != null || map().containsKey(key))) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4302)]
		internal EntrySet()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4308)]
		public override int size()
		{
			int result = map().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 103, 109 })]
		public override void clear()
		{
			map().clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4329)]
		public override bool isEmpty()
		{
			bool result = map().isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 128, 113, 103, 153 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (contains(P_0) && P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				bool result = map().keySet().remove(entry.getKey());
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 176, 138, 127, 1, 129 })]
		public override bool removeAll(Collection P_0)
		{
			//Discarded unreachable code: IL_0013
			try
			{
				return base.removeAll((Collection)Preconditions.checkNotNull(P_0));
			}
			catch (UnsupportedOperationException)
			{
			}
			_ = null;
			return Sets.removeAllImpl(this, P_0.iterator());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[]
		{
			176, 148, 127, 1, 129, 108, 246, 69, 113, 104,
			142, 98
		})]
		public override bool retainAll(Collection P_0)
		{
			//Discarded unreachable code: IL_0013
			try
			{
				return base.retainAll((Collection)Preconditions.checkNotNull(P_0));
			}
			catch (UnsupportedOperationException)
			{
			}
			_ = null;
			HashSet hashSet = Sets.newHashSetWithExpectedSize(P_0.size());
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (contains(obj) && obj is Map.Entry)
				{
					Map.Entry entry = (Map.Entry)obj;
					((Set)hashSet).add(entry.getKey());
				}
			}
			return map().keySet().retainAll(hashSet);
		}
	}

	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 15, 0, 0,
		17, 1, 0, 0, 0, 15, 0, 0, 17, 2,
		0, 0, 0, 15, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)15,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[FunctionalInterface(new object[]
	{
		(byte)64,
		"Ljava/lang/FunctionalInterface;"
	})]
	public interface EntryTransformer
	{
		[Signature("(TK;TV1;)TV2;")]
		virtual object transformEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object obj1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object obj2);
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$FilteredEntryMap<TK;TV;>;Lcom/google/common/collect/BiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 45, 0, 0,
		17, 1, 0, 0, 0, 45, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.BiMap" })]
	internal sealed class FilteredEntryBiMap : FilteredEntryMap, BiMap, Map
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<Ljava/util/Map$Entry<TV;TK;>;>;")]
		[EnclosingMethod(null, "inversePredicate", "(Lcom.google.common.base.Predicate;)Lcom.google.common.base.Predicate;")]
		[Implements(new string[] { "com.google.common.base.Predicate" })]
		internal class _1 : java.lang.Object, com.google.common.@base.Predicate, java.util.function.Predicate
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal com.google.common.@base.Predicate val_0024forwardPredicate;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map$Entry<TV;TK;>;)Z")]
			[LineNumberTable(3447)]
			public virtual bool apply(Map.Entry P_0)
			{
				bool result = val_0024forwardPredicate.apply(immutableEntry(P_0.getValue(), P_0.getKey()));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(3444)]
			internal _1(com.google.common.@base.Predicate P_0)
			{
				val_0024forwardPredicate = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(3444)]
			public virtual bool apply(object P_0)
			{
				bool result = apply((Map.Entry)P_0);
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool test(object P_0)
			{
				return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}

			bool com.google.common.@base.Predicate.Predicate_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiFunction
		{
			private readonly FilteredEntryBiMap arg_00241;

			private readonly BiFunction arg_00242;

			internal ___003C_003EAnon0(FilteredEntryBiMap P_0, BiFunction P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public object apply(object P_0, object P_1)
			{
				object result = arg_00241.lambda_0024replaceAll_00240(arg_00242, P_0, P_1);
				_ = null;
				return result;
			}

			[SpecialName]
			public BiFunction andThen(java.util.function.Function P_0)
			{
				return BiFunction._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/BiMap<TV;TK;>;")]
		private BiMap m_inverse;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BiMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 173, 11, 106, 98, 118 })]
		internal FilteredEntryBiMap(BiMap P_0, com.google.common.@base.Predicate P_1)
			: base(P_0, P_1)
		{
			this.m_inverse = new FilteredEntryBiMap(P_0.inverse(), inversePredicate(P_1), this);
		}

		[Signature("()Lcom/google/common/collect/BiMap<TK;TV;>;")]
		[LineNumberTable(3465)]
		internal new virtual BiMap unfiltered()
		{
			return (BiMap)base.unfiltered;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Lcom/google/common/base/Predicate<Ljava/util/Map$Entry<TV;TK;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 45, 0, 0,
			18, 1, 0, 0, 0, 45, 0, 0
		})]
		[LineNumberTable(3444)]
		private static com.google.common.@base.Predicate inversePredicate(com.google.common.@base.Predicate P_0)
		{
			_1 result = new _1(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BiMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;Lcom/google/common/collect/BiMap<TV;TK;>;)V")]
		[LineNumberTable(new byte[] { 173, 18, 106, 103 })]
		private FilteredEntryBiMap(BiMap P_0, com.google.common.@base.Predicate P_1, BiMap P_2)
			: base(P_0, P_1)
		{
			this.m_inverse = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(3492)]
		public new virtual Set values()
		{
			Set result = this.m_inverse.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(new byte[] { 173, 38, 116, 106, 1 })]
		private object lambda_0024replaceAll_00240(BiFunction P_0, object P_1, object P_2)
		{
			return (!predicate.apply(immutableEntry(P_1, P_2))) ? P_2 : P_0.apply(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(new byte[] { 173, 29, 109 })]
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
			Preconditions.checkArgument(base.apply(P_0, P_1));
			object result = unfiltered().forcePut(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
		[LineNumberTable(new byte[] { 173, 35, 114, 231, 69 })]
		public override void replaceAll(BiFunction P_0)
		{
			unfiltered().replaceAll(new ___003C_003EAnon0(this, P_0));
		}

		[Signature("()Lcom/google/common/collect/BiMap<TV;TK;>;")]
		public virtual BiMap inverse()
		{
			return this.m_inverse;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3437)]
		public override Collection values()
		{
			Set result = values();
			_ = null;
			return result;
		}

		Collection BiMap.BiMap_003A_003Avalues()
		{
			return this.values();
		}

		int Map.Map_003A_003Asize()
		{
			return size();
		}

		object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
		{
			return putIfAbsent(P_0, P_1);
		}

		bool Map.Map_003A_003AcontainsValue(object P_0)
		{
			return containsValue(P_0);
		}

		void Map.Map_003A_003Aclear()
		{
			clear();
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

		void Map.Map_003A_003AforEach(BiConsumer P_0)
		{
			forEach(P_0);
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

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$AbstractFilteredMap<TK;TV;>;")]
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
	internal class FilteredEntryMap : AbstractFilteredMap
	{
		[InnerClass(null, Modifiers.Private)]
		[Signature("Lcom/google/common/collect/ForwardingSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal class EntrySet : ForwardingSet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/TransformedIterator<Ljava/util/Map$Entry<TK;TV;>;Ljava/util/Map$Entry<TK;TV;>;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			internal class _1 : TransformedIterator
			{
				[SpecialName]
				[InnerClass(null, (Modifiers)0)]
				[Signature("Lcom/google/common/collect/ForwardingMapEntry<TK;TV;>;")]
				[EnclosingMethod(null, "transform", "(Ljava.util.Map$Entry;)Ljava.util.Map$Entry;")]
				internal class _1 : ForwardingMapEntry
				{
					[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
					internal Map.Entry val_0024entry;

					[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
					internal EntrySet._1 this_00242;

					[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
					protected internal override Map.Entry @delegate()
					{
						return val_0024entry;
					}

					[MethodImpl(MethodImplOptions.NoInlining)]
					[LineNumberTable(3100)]
					internal _1(EntrySet._1 P_0, Map.Entry P_1)
					{
						this_00242 = P_0;
						val_0024entry = P_1;
						base._002Ector();
					}

					[MethodImpl(MethodImplOptions.NoInlining)]
					[Signature("(TV;)TV;")]
					[LineNumberTable(new byte[] { 171, 179, 127, 2 })]
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
						Preconditions.checkArgument(this_00242.this_00241.this_00240.apply(getKey(), P_0));
						object result = base.setValue(P_0);
						_ = null;
						return result;
					}

					[MethodImpl(MethodImplOptions.NoInlining)]
					[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
					[LineNumberTable(3100)]
					protected internal new virtual object @delegate()
					{
						Map.Entry result = this.@delegate();
						_ = null;
						return result;
					}
				}

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal EntrySet this_00241;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(Ljava/util/Map$Entry<TK;TV;>;)Ljava/util/Map$Entry<TK;TV;>;")]
				[LineNumberTable(3100)]
				internal virtual Map.Entry transform(Map.Entry P_0)
				{
					_1 result = new _1(this, P_0);
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(3097)]
				internal _1(EntrySet P_0, Iterator P_1)
				{
					this_00241 = P_0;
					base._002Ector(P_1);
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(3097)]
				internal override object transform(object P_0)
				{
					Map.Entry result = transform((Map.Entry)P_0);
					_ = null;
					return result;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal FilteredEntryMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Synthetic)]
			[LineNumberTable(3089)]
			internal EntrySet(FilteredEntryMap P_0, Maps._1 P_1)
				: this(P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(3089)]
			private EntrySet(FilteredEntryMap P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(3092)]
			protected internal override Set @delegate()
			{
				return this_00240.filteredEntrySet;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(3097)]
			public override Iterator iterator()
			{
				_1 result = new _1(this, this_00240.filteredEntrySet.iterator());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(3088)]
			protected internal new virtual Collection @delegate()
			{
				Set result = this.@delegate();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(3088)]
			protected internal new virtual object @delegate()
			{
				Set result = this.@delegate();
				_ = null;
				return result;
			}
		}

		[Signature("Lcom/google/common/collect/Maps$KeySet<TK;TV;>;")]
		[ConstantPool(new object[]
		{
			(byte)48,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal class KeySet : Maps.KeySet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal FilteredEntryMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 171, 223, 103, 105 })]
			internal KeySet(FilteredEntryMap P_0)
			{
				this_00240 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 171, 229, 110, 114, 130 })]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (this_00240.containsKey(P_0))
				{
					this_00240.unfiltered.remove(P_0);
					return true;
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(3168)]
			public override bool removeAll(Collection P_0)
			{
				bool result = removeAllKeys(this_00240.unfiltered, this_00240.predicate, P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(3173)]
			public override bool retainAll(Collection P_0)
			{
				bool result = retainAllKeys(this_00240.unfiltered, this_00240.predicate, P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 48, 0, 0 })]
			[LineNumberTable(3179)]
			public override object[] toArray()
			{
				object[] result = Lists.newArrayList(iterator()).toArray();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 48, 0, 0 })]
			[LineNumberTable(3185)]
			public override object[] toArray(object[] P_0)
			{
				object[] result = Lists.newArrayList(iterator()).toArray(P_0);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal Set filteredEntrySet;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 171, 149, 106, 119 })]
		internal FilteredEntryMap(Map P_0, com.google.common.@base.Predicate P_1)
			: base(P_0, P_1)
		{
			filteredEntrySet = Sets.filter(P_0.entrySet(), predicate);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(3085)]
		protected internal override Set createEntrySet()
		{
			EntrySet result = new EntrySet(this, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(3120)]
		internal override Set createKeySet()
		{
			KeySet result = new KeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;Ljava/util/Collection<*>;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 68, 0, 0,
			18, 1, 0, 0, 0, 68, 0, 0
		})]
		[LineNumberTable(new byte[] { 171, 195, 108, 98, 104, 108, 119, 102, 130, 98 })]
		internal static bool removeAllKeys(Map P_0, com.google.common.@base.Predicate P_1, Collection P_2)
		{
			Iterator iterator = P_0.entrySet().iterator();
			int result = 0;
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (P_1.apply(entry) && P_2.contains(entry.getKey()))
				{
					iterator.remove();
					result = 1;
				}
			}
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;Ljava/util/Collection<*>;)Z")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 68, 0, 0,
			18, 1, 0, 0, 0, 68, 0, 0
		})]
		[LineNumberTable(new byte[] { 171, 209, 108, 98, 104, 108, 119, 102, 130, 98 })]
		internal static bool retainAllKeys(Map P_0, com.google.common.@base.Predicate P_1, Collection P_2)
		{
			Iterator iterator = P_0.entrySet().iterator();
			int result = 0;
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (P_1.apply(entry) && !P_2.contains(entry.getKey()))
				{
					iterator.remove();
					result = 1;
				}
			}
			return (byte)result != 0;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractNavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 135, 0, 0,
		17, 1, 0, 0, 0, 135, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)135,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class FilteredEntryNavigableMap : AbstractNavigableMap
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/Maps$NavigableKeySet<TK;TV;>;")]
		[EnclosingMethod(null, "navigableKeySet", "()Ljava.util.NavigableSet;")]
		internal new class _1 : NavigableKeySet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal FilteredEntryNavigableMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(3323)]
			internal _1(FilteredEntryNavigableMap P_0, NavigableMap P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(3326)]
			public override bool removeAll(Collection P_0)
			{
				bool result = FilteredEntryMap.removeAllKeys(access_0024600(this_00240), access_0024500(this_00240), P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(3331)]
			public override bool retainAll(Collection P_0)
			{
				bool result = FilteredEntryMap.retainAllKeys(access_0024600(this_00240), access_0024500(this_00240), P_0);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableMap<TK;TV;>;")]
		private NavigableMap unfiltered;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;")]
		private com.google.common.@base.Predicate entryPredicate;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		private Map filteredDelegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 172, 123, 104, 113, 103, 109 })]
		internal FilteredEntryNavigableMap(NavigableMap P_0, com.google.common.@base.Predicate P_1)
		{
			unfiltered = (NavigableMap)Preconditions.checkNotNull(P_0);
			entryPredicate = P_1;
			filteredDelegate = new FilteredEntryMap(P_0, P_1);
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(3295)]
		internal static com.google.common.@base.Predicate access_0024500(FilteredEntryNavigableMap P_0)
		{
			return P_0.entryPredicate;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(3295)]
		internal static NavigableMap access_0024600(FilteredEntryNavigableMap P_0)
		{
			return P_0.unfiltered;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(3318)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override Comparator comparator()
		{
			Comparator result = unfiltered.comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(3323)]
		public override NavigableSet navigableKeySet()
		{
			_1 result = new _1(this, this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(3338)]
		public override Collection values()
		{
			FilteredMapValues result = new FilteredMapValues(this, unfiltered, entryPredicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(3343)]
		internal override Iterator entryIterator()
		{
			UnmodifiableIterator result = Iterators.filter(unfiltered.entrySet().iterator(), entryPredicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(3348)]
		internal override Iterator descendingEntryIterator()
		{
			UnmodifiableIterator result = Iterators.filter(unfiltered.descendingMap().entrySet().iterator(), entryPredicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3353)]
		public override int size()
		{
			int result = filteredDelegate.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3358)]
		public override bool isEmpty()
		{
			return (!Iterables.any(unfiltered.entrySet(), entryPredicate)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(3364)]
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
			object result = filteredDelegate.get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3369)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = filteredDelegate.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(3375)]
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
			object result = filteredDelegate.put(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(3381)]
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
			object result = filteredDelegate.remove(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
		[LineNumberTable(new byte[] { 172, 200, 110 })]
		public override void putAll(Map P_0)
		{
			filteredDelegate.putAll(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 172, 205, 109 })]
		public override void clear()
		{
			filteredDelegate.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(3396)]
		public override Set entrySet()
		{
			Set result = filteredDelegate.entrySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3402)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override Map.Entry pollFirstEntry()
		{
			return (Map.Entry)Iterables.removeFirstMatching(unfiltered.entrySet(), entryPredicate);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3408)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override Map.Entry pollLastEntry()
		{
			return (Map.Entry)Iterables.removeFirstMatching(unfiltered.descendingMap().entrySet(), entryPredicate);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(3413)]
		public override NavigableMap descendingMap()
		{
			NavigableMap result = filterEntries(unfiltered.descendingMap(), entryPredicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 156, 55, 133, 106, 43 })]
		public override NavigableMap subMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2, bool P_3)
		{
			NavigableMap result = filterEntries(unfiltered.subMap(P_0, P_1, P_2, P_3), entryPredicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(3428)]
		public override NavigableMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = filterEntries(unfiltered.headMap(P_0, P_1), entryPredicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(3433)]
		public override NavigableMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = filterEntries(unfiltered.tailMap(P_0, P_1), entryPredicate);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$FilteredEntryMap<TK;TV;>;Ljava/util/SortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 85, 0, 0,
		17, 1, 0, 0, 0, 85, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)85,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.SortedMap" })]
	internal class FilteredEntrySortedMap : FilteredEntryMap, SortedMap, Map
	{
		[Signature("Lcom/google/common/collect/Maps$FilteredEntryMap<TK;TV;>.KeySet;Ljava/util/SortedSet<TK;>;")]
		[Implements(new string[] { "java.util.SortedSet" })]
		internal class SortedKeySet : KeySet, SortedSet, Set, Collection, Iterable, IEnumerable
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal new FilteredEntrySortedMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(3214)]
			internal SortedKeySet(FilteredEntrySortedMap P_0)
			{
				this_00240 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Comparator<-TK;>;")]
			[LineNumberTable(3218)]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public virtual Comparator comparator()
			{
				Comparator result = this_00240.sortedMap().comparator();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;TK;)Ljava/util/SortedSet<TK;>;")]
			[LineNumberTable(3224)]
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
				return (SortedSet)this_00240.subMap(P_0, P_1).keySet();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;)Ljava/util/SortedSet<TK;>;")]
			[LineNumberTable(3229)]
			public virtual SortedSet headSet([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				return (SortedSet)this_00240.headMap(P_0).keySet();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TK;)Ljava/util/SortedSet<TK;>;")]
			[LineNumberTable(3234)]
			public virtual SortedSet tailSet([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				return (SortedSet)this_00240.tailMap(P_0).keySet();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TK;")]
			[LineNumberTable(3240)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public virtual object first()
			{
				object result = this_00240.firstKey();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TK;")]
			[LineNumberTable(3246)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public virtual object last()
			{
				object result = this_00240.lastKey();
				_ = null;
				return result;
			}

			[SpecialName]
			[HideFromJava]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return new IterableEnumerator(this);
			}

			Spliterator SortedSet.SortedSet_003A_003Aspliterator()
			{
				return spliterator();
			}

			bool Set.Set_003A_003Aadd(object P_0)
			{
				return add(P_0);
			}

			bool Set.Set_003A_003AcontainsAll(Collection P_0)
			{
				return containsAll(P_0);
			}

			bool Set.Set_003A_003AaddAll(Collection P_0)
			{
				return addAll(P_0);
			}

			bool Set.Set_003A_003Aequals(object P_0)
			{
				return equals(P_0);
			}

			int Set.Set_003A_003AhashCode()
			{
				return hashCode();
			}

			Spliterator Set.Set_003A_003Aspliterator()
			{
				return spliterator();
			}

			bool Collection.Collection_003A_003Aadd(object P_0)
			{
				return add(P_0);
			}

			Spliterator Collection.Collection_003A_003Aspliterator()
			{
				return spliterator();
			}

			bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
			{
				return containsAll(P_0);
			}

			bool Collection.Collection_003A_003AaddAll(Collection P_0)
			{
				return addAll(P_0);
			}

			bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
			{
				return removeIf(P_0);
			}

			bool Collection.Collection_003A_003Aequals(object P_0)
			{
				return equals(P_0);
			}

			int Collection.Collection_003A_003AhashCode()
			{
				return hashCode();
			}

			Stream Collection.Collection_003A_003Astream()
			{
				return stream();
			}

			Stream Collection.Collection_003A_003AparallelStream()
			{
				return parallelStream();
			}

			Spliterator Iterable.Iterable_003A_003Aspliterator()
			{
				return spliterator();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 172, 10, 106 })]
		internal FilteredEntrySortedMap(SortedMap P_0, com.google.common.@base.Predicate P_1)
			: base(P_0, P_1)
		{
		}

		[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(3200)]
		internal virtual SortedMap sortedMap()
		{
			return (SortedMap)unfiltered;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(3285)]
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
			FilteredEntrySortedMap result = new FilteredEntrySortedMap(sortedMap().subMap(P_0, P_1), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(3280)]
		public virtual SortedMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			FilteredEntrySortedMap result = new FilteredEntrySortedMap(sortedMap().headMap(P_0), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(3290)]
		public virtual SortedMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			FilteredEntrySortedMap result = new FilteredEntrySortedMap(sortedMap().tailMap(P_0), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(3260)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object firstKey()
		{
			object result = keySet().iterator().next();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(new byte[] { 172, 80, 167, 135, 122, 130, 109 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object lastKey()
		{
			SortedMap sortedMap = this.sortedMap();
			object obj;
			while (true)
			{
				obj = sortedMap.lastKey();
				if (apply(obj, NullnessCasts.uncheckedCastNullableTToT(unfiltered.get(obj))))
				{
					break;
				}
				sortedMap = this.sortedMap().headMap(obj);
			}
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(3205)]
		public new virtual SortedSet keySet()
		{
			return (SortedSet)base.keySet();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(3210)]
		internal new virtual SortedSet createKeySet()
		{
			SortedKeySet result = new SortedKeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(3253)]
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
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3190)]
		internal override Set createKeySet()
		{
			SortedSet result = createKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3190)]
		public override Set keySet()
		{
			SortedSet result = keySet();
			_ = null;
			return result;
		}

		int Map.Map_003A_003Asize()
		{
			return size();
		}

		object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
		{
			return putIfAbsent(P_0, P_1);
		}

		bool Map.Map_003A_003AcontainsValue(object P_0)
		{
			return containsValue(P_0);
		}

		void Map.Map_003A_003Aclear()
		{
			clear();
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$AbstractFilteredMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 52, 0, 0,
		17, 1, 0, 0, 0, 52, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)52,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class FilteredKeyMap : AbstractFilteredMap
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<-TK;>;")]
		internal com.google.common.@base.Predicate keyPredicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 171, 117, 106, 103 })]
		internal FilteredKeyMap(Map P_0, com.google.common.@base.Predicate P_1, com.google.common.@base.Predicate P_2)
			: base(P_0, P_2)
		{
			keyPredicate = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(3053)]
		protected internal override Set createEntrySet()
		{
			Set result = Sets.filter(unfiltered.entrySet(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(3058)]
		internal override Set createKeySet()
		{
			Set result = Sets.filter(unfiltered.keySet(), keyPredicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3066)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (unfiltered.containsKey(P_0) && keyPredicate.apply(P_0)) ? true : false;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$Values<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 67, 0, 0,
		17, 1, 0, 0, 0, 67, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)67,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class FilteredMapValues : Values
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map unfiltered;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal com.google.common.@base.Predicate predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 171, 50, 105, 103, 103 })]
		internal FilteredMapValues(Map P_0, Map P_1, com.google.common.@base.Predicate P_2)
			: base(P_0)
		{
			unfiltered = P_1;
			predicate = P_2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 171, 57, 113, 104, 108, 124, 102, 130, 98 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Iterator iterator = unfiltered.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (predicate.apply(entry) && com.google.common.@base.Objects.equal(entry.getValue(), P_0))
				{
					iterator.remove();
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 171, 70, 113, 98, 104, 108, 124, 102, 130, 98 })]
		public override bool removeAll(Collection P_0)
		{
			Iterator iterator = unfiltered.entrySet().iterator();
			int result = 0;
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (predicate.apply(entry) && P_0.contains(entry.getValue()))
				{
					iterator.remove();
					result = 1;
				}
			}
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[] { 171, 84, 113, 98, 104, 108, 124, 102, 130, 98 })]
		public override bool retainAll(Collection P_0)
		{
			Iterator iterator = unfiltered.entrySet().iterator();
			int result = 0;
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (predicate.apply(entry) && !P_0.contains(entry.getValue()))
				{
					iterator.remove();
					result = 1;
				}
			}
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 67, 0, 0 })]
		[LineNumberTable(3029)]
		public override object[] toArray()
		{
			object[] result = Lists.newArrayList(iterator()).toArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 67, 0, 0 })]
		[LineNumberTable(3035)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = Lists.newArrayList(iterator()).toArray(P_0);
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 48, 0, 0,
		17, 1, 0, 0, 0, 48, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)48,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class IteratorBasedAbstractMap : AbstractMap
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/Maps$EntrySet<TK;TV;>;")]
		[EnclosingMethod(null, "entrySet", "()Ljava.util.Set;")]
		internal class _1 : EntrySet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal IteratorBasedAbstractMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(3854)]
			internal _1(IteratorBasedAbstractMap P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[Signature("()Ljava/util/Map<TK;TV;>;")]
			internal override Map map()
			{
				return this_00240;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(3862)]
			public override Iterator iterator()
			{
				Iterator result = this_00240.entryIterator();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
			[LineNumberTable(3867)]
			public override Spliterator spliterator()
			{
				Spliterator result = this_00240.entrySpliterator();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/function/Consumer<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
			[LineNumberTable(new byte[] { 174, 174, 110 })]
			public override void forEach(Consumer P_0)
			{
				this_00240.forEachEntry(P_0);
			}
		}

		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal abstract Iterator entryIterator();

		public abstract override int size();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3839)]
		internal IteratorBasedAbstractMap()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 174, 150, 97, 46 })]
		internal virtual Spliterator entrySpliterator()
		{
			Spliterator result = Spliterators.spliterator(entryIterator(), size(), 65);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(3854)]
		public override Set entrySet()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 174, 180, 110 })]
		internal virtual void forEachEntry(Consumer P_0)
		{
			entryIterator().forEachRemaining(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 174, 185, 109 })]
		public override void clear()
		{
			Iterators.clear(entryIterator());
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Sets$ImprovedAbstractSet<TK;>;")]
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
	internal class KeySet : Sets.ImprovedAbstractSet
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiConsumer
		{
			private readonly Consumer arg_00241;

			internal ___003C_003EAnon0(Consumer P_0)
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

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map map;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 175, 60, 104, 113 })]
		internal KeySet(Map P_0)
		{
			this.map = (Map)Preconditions.checkNotNull(P_0);
		}

		[Signature("()Ljava/util/Map<TK;TV;>;")]
		internal virtual Map map()
		{
			return this.map;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4046)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = map().containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(4031)]
		private static void lambda_0024forEach_00240(Consumer P_0, object P_1, object P_2)
		{
			P_0.accept(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(4024)]
		public override Iterator iterator()
		{
			Iterator result = keyIterator(map().entrySet().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TK;>;)V")]
		[LineNumberTable(new byte[] { 175, 75, 135, 120 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			this.map.forEach(new ___003C_003EAnon0(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4036)]
		public override int size()
		{
			int result = map().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4041)]
		public override bool isEmpty()
		{
			bool result = map().isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 175, 97, 105, 109, 130 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (contains(P_0))
			{
				map().remove(P_0);
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 175, 106, 109 })]
		public override void clear()
		{
			map().clear();
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapDifference<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 83, 0, 0,
		17, 1, 0, 0, 0, 83, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)83,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class MapDifferenceImpl : java.lang.Object, MapDifference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map onlyOnLeft;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map onlyOnRight;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map onBoth;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;>;")]
		internal Map differences;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;Ljava/util/Map<TK;TV;>;Ljava/util/Map<TK;TV;>;Ljava/util/Map<TK;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 162, 23, 104, 108, 108, 108, 109 })]
		internal MapDifferenceImpl(Map P_0, Map P_1, Map P_2, Map P_3)
		{
			onlyOnLeft = access_0024100(P_0);
			onlyOnRight = access_0024100(P_1);
			onBoth = access_0024100(P_2);
			differences = access_0024100(P_3);
		}

		[Signature("()Ljava/util/Map<TK;TV;>;")]
		public virtual Map entriesOnlyOnLeft()
		{
			return onlyOnLeft;
		}

		[Signature("()Ljava/util/Map<TK;TV;>;")]
		public virtual Map entriesOnlyOnRight()
		{
			return onlyOnRight;
		}

		[Signature("()Ljava/util/Map<TK;TV;>;")]
		public virtual Map entriesInCommon()
		{
			return onBoth;
		}

		[Signature("()Ljava/util/Map<TK;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;>;")]
		public virtual Map entriesDiffering()
		{
			return differences;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(658)]
		public virtual bool areEqual()
		{
			return (onlyOnLeft.isEmpty() && onlyOnRight.isEmpty() && differences.isEmpty()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 57, 100, 130, 104, 103, 116, 115, 115, 246,
			61, 225, 69
		})]
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
			if (P_0 is MapDifference)
			{
				MapDifference mapDifference = (MapDifference)P_0;
				return (entriesOnlyOnLeft().equals(mapDifference.entriesOnlyOnLeft()) && entriesOnlyOnRight().equals(mapDifference.entriesOnlyOnRight()) && entriesInCommon().equals(mapDifference.entriesInCommon()) && entriesDiffering().equals(mapDifference.entriesDiffering())) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 72, 105, 63, 2 })]
		public override int hashCode()
		{
			int result = com.google.common.@base.Objects.hashCode(entriesOnlyOnLeft(), entriesOnlyOnRight(), entriesInCommon(), entriesDiffering());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 78, 104, 166, 107, 109, 151, 109, 151, 109,
			151
		})]
		public override string toString()
		{
			if (areEqual())
			{
				return "equal";
			}
			StringBuilder stringBuilder = new StringBuilder("not equal");
			if (!onlyOnLeft.isEmpty())
			{
				stringBuilder.append(": only on left=").append(onlyOnLeft);
			}
			if (!onlyOnRight.isEmpty())
			{
				stringBuilder.append(": only on right=").append(onlyOnRight);
			}
			if (!differences.isEmpty())
			{
				stringBuilder.append(": value differences=").append(differences);
			}
			string result = stringBuilder.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractNavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 122, 0, 0,
		17, 1, 0, 0, 0, 122, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)122,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class NavigableAsMapView : AbstractNavigableMap
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Function
		{
			private readonly NavigableAsMapView arg_00241;

			internal ___003C_003EAnon0(NavigableAsMapView P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				Map.Entry result = arg_00241.lambda_0024entrySpliterator_00240(P_0);
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
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly NavigableAsMapView arg_00241;

			private readonly BiConsumer arg_00242;

			internal ___003C_003EAnon1(NavigableAsMapView P_0, BiConsumer P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024forEach_00241(arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableSet<TK;>;")]
		private NavigableSet set;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TK;TV;>;")]
		private com.google.common.@base.Function function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableSet<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 187, 104, 113, 113 })]
		internal NavigableAsMapView(NavigableSet P_0, com.google.common.@base.Function P_1)
		{
			set = (NavigableSet)Preconditions.checkNotNull(P_0);
			function = (com.google.common.@base.Function)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;TV;)TV;")]
		[LineNumberTable(new byte[] { 163, 226, 142, 98, 143 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object getOrDefault([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			if (Collections2.safeContains(set, P_0))
			{
				object result = function.apply(P_0);
				_ = null;
				return result;
			}
			return P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(1154)]
		public override NavigableMap descendingMap()
		{
			NavigableMap result = asMap(set.descendingSet(), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(1129)]
		private Map.Entry lambda_0024entrySpliterator_00240(object P_0)
		{
			Map.Entry result = immutableEntry(P_0, function.apply(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(1134)]
		private void lambda_0024forEach_00241(BiConsumer P_0, object P_1)
		{
			P_0.accept(P_1, function.apply(P_1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(1080)]
		public override NavigableMap subMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2, bool P_3)
		{
			NavigableMap result = asMap(set.subSet(P_0, P_1, P_2, P_3), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(1085)]
		public override NavigableMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = asMap(set.headSet(P_0, P_1), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(1090)]
		public override NavigableMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = asMap(set.tailSet(P_0, P_1), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(1096)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override Comparator comparator()
		{
			Comparator result = set.comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(1102)]
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
			object orDefault = getOrDefault(P_0, null);
			_ = null;
			return orDefault;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 237, 109 })]
		public override void clear()
		{
			set.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(1124)]
		internal override Iterator entryIterator()
		{
			Iterator result = asMapEntryIterator(set, function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(1129)]
		internal override Spliterator entrySpliterator()
		{
			Spliterator result = CollectSpliterators.map(set.spliterator(), new ___003C_003EAnon0(this));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 252, 121 })]
		public override void forEach(BiConsumer P_0)
		{
			set.forEach(new ___003C_003EAnon1(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(1139)]
		internal override Iterator descendingEntryIterator()
		{
			Iterator result = descendingMap().entrySet().iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(1144)]
		public override NavigableSet navigableKeySet()
		{
			NavigableSet result = access_0024400(set);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1149)]
		public override int size()
		{
			int result = set.size();
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$SortedKeySet<TK;TV;>;Ljava/util/NavigableSet<TK;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 92, 0, 0,
		17, 1, 0, 0, 0, 92, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)92,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableSet" })]
	internal class NavigableKeySet : SortedKeySet, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 175, 169, 105 })]
		internal NavigableKeySet(NavigableMap P_0)
			: base(P_0)
		{
		}

		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(4128)]
		internal new virtual NavigableMap map()
		{
			return (NavigableMap)((KeySet)this).map;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(4169)]
		public virtual NavigableSet descendingSet()
		{
			NavigableSet result = map().descendingKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(4183)]
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
			NavigableSet result = map().subMap(P_0, P_1, P_2, P_3).navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(4193)]
		public virtual NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = map().headMap(P_0, P_1).navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(4203)]
		public virtual NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableSet result = map().tailMap(P_0, P_1).navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(4134)]
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
			object result = map().lowerKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(4140)]
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
			object result = map().floorKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(4146)]
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
			object result = map().ceilingKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(4152)]
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
			object result = map().higherKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(4158)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollFirst()
		{
			object result = keyOrNull(map().pollFirstEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(4164)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollLast()
		{
			object result = keyOrNull(map().pollLastEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(4174)]
		public virtual Iterator descendingIterator()
		{
			Iterator result = descendingSet().iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(4188)]
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
			NavigableSet result = subSet(P_0, true, P_1, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(4198)]
		public override SortedSet headSet([ParametricNullness(new object[]
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
		[Signature("(TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(4208)]
		public override SortedSet tailSet([ParametricNullness(new object[]
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
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(4119)]
		internal override SortedMap map()
		{
			NavigableMap result = map();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(4119)]
		internal override Map map()
		{
			NavigableMap result = map();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		Spliterator SortedSet.SortedSet_003A_003Aspliterator()
		{
			return spliterator();
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

		bool Set.Set_003A_003AcontainsAll(Collection P_0)
		{
			return containsAll(P_0);
		}

		bool Set.Set_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Set.Set_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Set.Set_003A_003AhashCode()
		{
			return hashCode();
		}

		Spliterator Set.Set_003A_003Aspliterator()
		{
			return spliterator();
		}

		bool Collection.Collection_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		Spliterator Collection.Collection_003A_003Aspliterator()
		{
			return spliterator();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
		{
			return containsAll(P_0);
		}

		bool Collection.Collection_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		bool Collection.Collection_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Collection.Collection_003A_003AhashCode()
		{
			return hashCode();
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}

		Spliterator Iterable.Iterable_003A_003Aspliterator()
		{
			return spliterator();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$AsMapView<TK;TV;>;Ljava/util/SortedMap<TK;TV;>;")]
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
	internal class SortedAsMapView : AsMapView, SortedMap, Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedSet<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 163, 128, 106 })]
		internal SortedAsMapView(SortedSet P_0, com.google.common.@base.Function P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(1015)]
		internal new virtual SortedSet backingSet()
		{
			return (SortedSet)base.backingSet();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(1021)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			Comparator result = backingSet().comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(1026)]
		public override Set keySet()
		{
			SortedSet result = access_0024300(backingSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(1031)]
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
			SortedMap result = asMap(backingSet().subSet(P_0, P_1), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(1036)]
		public virtual SortedMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedMap result = asMap(backingSet().headSet(P_0), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(1041)]
		public virtual SortedMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedMap result = asMap(backingSet().tailSet(P_0), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1047)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object firstKey()
		{
			object result = backingSet().first();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(1053)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object lastKey()
		{
			object result = backingSet().last();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1006)]
		internal override Set backingSet()
		{
			SortedSet result = backingSet();
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

		bool Map.Map_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Map.Map_003A_003AhashCode()
		{
			return hashCode();
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

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$KeySet<TK;TV;>;Ljava/util/SortedSet<TK;>;")]
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
	[Implements(new string[] { "java.util.SortedSet" })]
	internal class SortedKeySet : KeySet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(4082)]
		internal new virtual SortedMap map()
		{
			return (SortedMap)base.map();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 175, 123, 105 })]
		internal SortedKeySet(SortedMap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(4088)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			Comparator result = map().comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(4093)]
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
			SortedKeySet result = new SortedKeySet(map().subMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(4098)]
		public virtual SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedKeySet result = new SortedKeySet(map().headMap(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedSet<TK;>;")]
		[LineNumberTable(4103)]
		public virtual SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedKeySet result = new SortedKeySet(map().tailMap(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(4109)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object first()
		{
			object result = map().firstKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(4115)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object last()
		{
			object result = map().lastKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(4074)]
		internal override Map map()
		{
			SortedMap result = map();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		Spliterator SortedSet.SortedSet_003A_003Aspliterator()
		{
			return spliterator();
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

		bool Set.Set_003A_003AcontainsAll(Collection P_0)
		{
			return containsAll(P_0);
		}

		bool Set.Set_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Set.Set_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Set.Set_003A_003AhashCode()
		{
			return hashCode();
		}

		Spliterator Set.Set_003A_003Aspliterator()
		{
			return spliterator();
		}

		bool Collection.Collection_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		Spliterator Collection.Collection_003A_003Aspliterator()
		{
			return spliterator();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
		{
			return containsAll(P_0);
		}

		bool Collection.Collection_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		bool Collection.Collection_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Collection.Collection_003A_003AhashCode()
		{
			return hashCode();
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}

		Spliterator Iterable.Iterable_003A_003Aspliterator()
		{
			return spliterator();
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$MapDifferenceImpl<TK;TV;>;Lcom/google/common/collect/SortedMapDifference<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 49, 0, 0,
		17, 1, 0, 0, 0, 49, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)49,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.SortedMapDifference" })]
	internal class SortedMapDifferenceImpl : MapDifferenceImpl, SortedMapDifference, MapDifference
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedMap<TK;TV;>;Ljava/util/SortedMap<TK;TV;>;Ljava/util/SortedMap<TK;TV;>;Ljava/util/SortedMap<TK;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;>;)V")]
		[LineNumberTable(new byte[] { 162, 151, 109 })]
		internal SortedMapDifferenceImpl(SortedMap P_0, SortedMap P_1, SortedMap P_2, SortedMap P_3)
			: base(P_0, P_1, P_2, P_3)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TK;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;>;")]
		[LineNumberTable(782)]
		public new virtual SortedMap entriesDiffering()
		{
			return (SortedMap)base.entriesDiffering();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(787)]
		public new virtual SortedMap entriesInCommon()
		{
			return (SortedMap)base.entriesInCommon();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(797)]
		public new virtual SortedMap entriesOnlyOnRight()
		{
			return (SortedMap)base.entriesOnlyOnRight();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(792)]
		public new virtual SortedMap entriesOnlyOnLeft()
		{
			return (SortedMap)base.entriesOnlyOnLeft();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(770)]
		public override Map entriesDiffering()
		{
			SortedMap result = entriesDiffering();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(770)]
		public override Map entriesInCommon()
		{
			SortedMap result = entriesInCommon();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(770)]
		public override Map entriesOnlyOnRight()
		{
			SortedMap result = entriesOnlyOnRight();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(770)]
		public override Map entriesOnlyOnLeft()
		{
			SortedMap result = entriesOnlyOnLeft();
			_ = null;
			return result;
		}

		Map SortedMapDifference.SortedMapDifference_003A_003AentriesDiffering()
		{
			return this.entriesDiffering();
		}

		Map SortedMapDifference.SortedMapDifference_003A_003AentriesInCommon()
		{
			return this.entriesInCommon();
		}

		Map SortedMapDifference.SortedMapDifference_003A_003AentriesOnlyOnRight()
		{
			return this.entriesOnlyOnRight();
		}

		Map SortedMapDifference.SortedMapDifference_003A_003AentriesOnlyOnLeft()
		{
			return this.entriesOnlyOnLeft();
		}
	}

	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>Lcom/google/common/collect/Maps$IteratorBasedAbstractMap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 102, 0, 0,
		17, 1, 0, 0, 0, 102, 0, 0, 17, 2,
		0, 0, 0, 102, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)102,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class TransformedEntriesMap : IteratorBasedAbstractMap
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiConsumer
		{
			private readonly TransformedEntriesMap arg_00241;

			private readonly BiConsumer arg_00242;

			internal ___003C_003EAnon0(TransformedEntriesMap P_0, BiConsumer P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0, object P_1)
			{
				arg_00241.lambda_0024forEach_00240(arg_00242, P_0, P_1);
				_ = null;
			}

			[SpecialName]
			public BiConsumer andThen(BiConsumer P_0)
			{
				return BiConsumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV1;>;")]
		internal Map fromMap;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;")]
		internal EntryTransformer transformer;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)V")]
		[LineNumberTable(new byte[] { 168, 28, 104, 113, 113 })]
		internal TransformedEntriesMap(Map P_0, EntryTransformer P_1)
		{
			fromMap = (Map)Preconditions.checkNotNull(P_0);
			transformer = (EntryTransformer)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;TV2;)TV2;")]
		[LineNumberTable(new byte[] { 168, 54, 109, 145, 149 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object getOrDefault([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			object obj = fromMap.get(P_0);
			if (obj != null || fromMap.containsKey(P_0))
			{
				object result = transformer.transformEntry(P_0, NullnessCasts.uncheckedCastNullableTToT(obj));
				_ = null;
				return result;
			}
			return P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(2261)]
		private void lambda_0024forEach_00240(BiConsumer P_0, object P_1, object P_2)
		{
			P_0.accept(P_1, transformer.transformEntry(P_1, P_2));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2197)]
		public override int size()
		{
			int result = fromMap.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(2202)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = fromMap.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV2;")]
		[LineNumberTable(2208)]
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
			object orDefault = getOrDefault(P_0, null);
			_ = null;
			return orDefault;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV2;")]
		[LineNumberTable(new byte[] { 168, 67, 142, 127, 0, 225, 61 })]
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
			return (!fromMap.containsKey(P_0)) ? null : transformer.transformEntry(P_0, NullnessCasts.uncheckedCastNullableTToT(fromMap.remove(P_0)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 168, 75, 109 })]
		public override void clear()
		{
			fromMap.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(2242)]
		public override Set keySet()
		{
			Set result = fromMap.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV2;>;>;")]
		[LineNumberTable(new byte[] { 168, 85, 102, 53 })]
		internal override Iterator entryIterator()
		{
			Iterator result = Iterators.transform(fromMap.entrySet().iterator(), asEntryToEntryFunction(transformer));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV2;>;>;")]
		[LineNumberTable(new byte[] { 168, 91, 102, 53 })]
		internal override Spliterator entrySpliterator()
		{
			Spliterator result = CollectSpliterators.map(fromMap.entrySet().spliterator(), asEntryToEntryFunction(transformer));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiConsumer<-TK;-TV2;>;)V")]
		[LineNumberTable(new byte[] { 168, 97, 135, 121 })]
		public override void forEach(BiConsumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			fromMap.forEach(new ___003C_003EAnon0(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV2;>;")]
		[LineNumberTable(2266)]
		public override Collection values()
		{
			Values result = new Values(this);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>Lcom/google/common/collect/Maps$TransformedEntriesSortedMap<TK;TV1;TV2;>;Ljava/util/NavigableMap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 125, 0, 0,
		17, 1, 0, 0, 0, 125, 0, 0, 17, 2,
		0, 0, 0, 125, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)125,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableMap" })]
	internal class TransformedEntriesNavigableMap : TransformedEntriesSortedMap, NavigableMap, SortedMap, Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)V")]
		[LineNumberTable(new byte[] { 168, 162, 106 })]
		internal TransformedEntriesNavigableMap(NavigableMap P_0, EntryTransformer P_1)
			: base(P_0, P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;TV1;>;")]
		[LineNumberTable(2456)]
		protected internal new virtual NavigableMap fromMap()
		{
			return (NavigableMap)base.fromMap();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV1;>;)Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2451)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Map.Entry transformEntry([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Map.Entry P_0)
		{
			Map.Entry result = ((P_0 != null) ? Maps.transformEntry(transformer, P_0) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV2;>;")]
		[LineNumberTable(2374)]
		public virtual NavigableMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = transformEntries(fromMap().headMap(P_0, P_1), transformer);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV2;>;")]
		[LineNumberTable(new byte[] { 157, 47, 133, 97, 52 })]
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
			NavigableMap result = transformEntries(fromMap().subMap(P_0, P_1, P_2, P_3), transformer);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV2;>;")]
		[LineNumberTable(2446)]
		public virtual NavigableMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = transformEntries(fromMap().tailMap(P_0, P_1), transformer);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/NavigableMap<TK;TV2;>;")]
		[LineNumberTable(2441)]
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
		[Signature("(TK;TK;)Ljava/util/NavigableMap<TK;TV2;>;")]
		[LineNumberTable(2436)]
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
		[Signature("(TK;)Ljava/util/NavigableMap<TK;TV2;>;")]
		[LineNumberTable(2369)]
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
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2330)]
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
			Map.Entry result = transformEntry(fromMap().ceilingEntry(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(2336)]
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
			object result = fromMap().ceilingKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(2341)]
		public virtual NavigableSet descendingKeySet()
		{
			NavigableSet result = fromMap().descendingKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;TV2;>;")]
		[LineNumberTable(2346)]
		public virtual NavigableMap descendingMap()
		{
			NavigableMap result = transformEntries(fromMap().descendingMap(), transformer);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2352)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry firstEntry()
		{
			Map.Entry result = transformEntry(fromMap().firstEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2358)]
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
			Map.Entry result = transformEntry(fromMap().floorEntry(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(2364)]
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
			object result = fromMap().floorKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2380)]
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
			Map.Entry result = transformEntry(fromMap().higherEntry(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(2386)]
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
			object result = fromMap().higherKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2392)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry lastEntry()
		{
			Map.Entry result = transformEntry(fromMap().lastEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2398)]
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
			Map.Entry result = transformEntry(fromMap().lowerEntry(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(2404)]
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
			object result = fromMap().lowerKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(2409)]
		public virtual NavigableSet navigableKeySet()
		{
			NavigableSet result = fromMap().navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2415)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry pollFirstEntry()
		{
			Map.Entry result = transformEntry(fromMap().pollFirstEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV2;>;")]
		[LineNumberTable(2421)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry pollLastEntry()
		{
			Map.Entry result = transformEntry(fromMap().pollLastEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2317)]
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
		[LineNumberTable(2317)]
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
		[LineNumberTable(2317)]
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
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(2317)]
		protected internal override SortedMap fromMap()
		{
			NavigableMap result = fromMap();
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

		bool Map.Map_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Map.Map_003A_003AhashCode()
		{
			return hashCode();
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

	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>Lcom/google/common/collect/Maps$TransformedEntriesMap<TK;TV1;TV2;>;Ljava/util/SortedMap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 65, 0, 0,
		17, 1, 0, 0, 0, 65, 0, 0, 17, 2,
		0, 0, 0, 65, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)65,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.SortedMap" })]
	internal class TransformedEntriesSortedMap : TransformedEntriesMap, SortedMap, Map
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/SortedMap<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)V")]
		[LineNumberTable(new byte[] { 168, 118, 106 })]
		internal TransformedEntriesSortedMap(SortedMap P_0, EntryTransformer P_1)
			: base(P_0, P_1)
		{
		}

		[Signature("()Ljava/util/SortedMap<TK;TV1;>;")]
		[LineNumberTable(2275)]
		protected internal new virtual SortedMap fromMap()
		{
			return (SortedMap)base.fromMap;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TK;>;")]
		[LineNumberTable(2286)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			Comparator result = fromMap().comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(2292)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object firstKey()
		{
			object result = fromMap().firstKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV2;>;")]
		[LineNumberTable(2297)]
		public virtual SortedMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedMap result = transformEntries(fromMap().headMap(P_0), transformer);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TK;")]
		[LineNumberTable(2303)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object lastKey()
		{
			object result = fromMap().lastKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV2;>;")]
		[LineNumberTable(2308)]
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
			SortedMap result = transformEntries(fromMap().subMap(P_0, P_1), transformer);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV2;>;")]
		[LineNumberTable(2313)]
		public virtual SortedMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			SortedMap result = transformEntries(fromMap().tailMap(P_0), transformer);
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

		bool Map.Map_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Map.Map_003A_003AhashCode()
		{
			return hashCode();
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMap<TK;TV;>;Lcom/google/common/collect/BiMap<TK;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 74, 0, 0,
		17, 1, 0, 0, 0, 74, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)74,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.BiMap", "java.io.Serializable" })]
	internal class UnmodifiableBiMap : ForwardingMap, BiMap, Map, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map unmodifiableMap;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/BiMap<+TK;+TV;>;")]
		internal new BiMap @delegate;

		[Signature("Lcom/google/common/collect/BiMap<TV;TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal BiMap inverse;

		[NonSerialized]
		[Signature("Ljava/util/Set<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new Set values;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BiMap<+TK;+TV;>;Lcom/google/common/collect/BiMap<TV;TK;>;)V")]
		[LineNumberTable(new byte[] { 166, 53, 104, 108, 103, 103 })]
		internal UnmodifiableBiMap(BiMap P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] BiMap P_1)
		{
			unmodifiableMap = Collections.unmodifiableMap(P_0);
			this.@delegate = P_0;
			this.inverse = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(new byte[] { 166, 131, 103 })]
		public new virtual Set values()
		{
			Set set = this.values;
			Set result;
			if (set == null)
			{
				Set set2 = Collections.unmodifiableSet(this.@delegate.values());
				result = set2;
				this.values = set2;
			}
			else
			{
				result = set;
			}
			return result;
		}

		[Signature("()Ljava/util/Map<TK;TV;>;")]
		protected internal override Map @delegate()
		{
			return unmodifiableMap;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(1717)]
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
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
		[LineNumberTable(1722)]
		public override void replaceAll(BiFunction P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(1728)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object putIfAbsent(object P_0, object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 22, 0, 0, 0, 74, 0, 0, 22,
			1, 0, 0, 74, 0, 0
		})]
		[LineNumberTable(1733)]
		public override bool remove(object P_0, object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;TV;)Z")]
		[LineNumberTable(1738)]
		public override bool replace(object P_0, object P_1, object P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(1744)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object replace(object P_0, object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/Function<-TK;+TV;>;)TV;")]
		[LineNumberTable(1750)]
		public override object computeIfAbsent(object P_0, java.util.function.Function P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
		[LineNumberTable(1756)]
		public override object computeIfPresent(object P_0, BiFunction P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 1, 2, 3, 1, 2, 0, 0,
			74, 0, 0
		})]
		[LineNumberTable(1762)]
		public override object compute(object P_0, BiFunction P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)TV;")]
		[LineNumberTable(1768)]
		public override object merge(object P_0, object P_1, BiFunction P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/BiMap<TV;TK;>;")]
		[LineNumberTable(new byte[] { 166, 123, 103, 99, 126, 1 })]
		public virtual BiMap inverse()
		{
			BiMap biMap = this.inverse;
			object obj;
			if (biMap == null)
			{
				UnmodifiableBiMap unmodifiableBiMap = new UnmodifiableBiMap(this.@delegate.inverse(), this);
				obj = unmodifiableBiMap;
				this.inverse = unmodifiableBiMap;
			}
			else
			{
				obj = biMap;
			}
			return (obj == null) ? null : ((obj as BiMap) ?? throw new java.lang.IncompatibleClassChangeError());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1696)]
		public override Collection values()
		{
			Set result = values();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1696)]
		protected internal new virtual object @delegate()
		{
			Map result = this.@delegate();
			_ = null;
			return result;
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

		Collection BiMap.BiMap_003A_003Avalues()
		{
			return this.values();
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
		protected UnmodifiableBiMap(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingCollection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 43, 0, 0,
		17, 1, 0, 0, 0, 43, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)43,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class UnmodifiableEntries : ForwardingCollection
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
		private Collection entries;

		[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
		protected internal override Collection @delegate()
		{
			return entries;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 165, 136, 104, 103 })]
		internal UnmodifiableEntries(Collection P_0)
		{
			entries = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(1541)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = unmodifiableEntryIterator(entries.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 160, 103 })]
		public override object[] toArray()
		{
			return standardToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 43, 0, 0 })]
		[LineNumberTable(1561)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = standardToArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1526)]
		protected internal new virtual object @delegate()
		{
			Collection result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$UnmodifiableEntries<TK;TV;>;Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 38, 0, 0,
		17, 1, 0, 0, 0, 38, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)38,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Set" })]
	internal class UnmodifiableEntrySet : UnmodifiableEntries, Set, Collection, Iterable, IEnumerable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 165, 175, 105 })]
		internal UnmodifiableEntrySet(Set P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1576)]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = Sets.equalsImpl(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1581)]
		public override int hashCode()
		{
			int result = Sets.hashCodeImpl(this);
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

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingSortedMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 98, 0, 0,
		17, 1, 0, 0, 0, 98, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)98,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableMap", "java.io.Serializable" })]
	internal class UnmodifiableNavigableMap : ForwardingSortedMap, NavigableMap, SortedMap, Map, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableMap<TK;+TV;>;")]
		private new NavigableMap m_delegate;

		[NonSerialized]
		[Signature("Lcom/google/common/collect/Maps$UnmodifiableNavigableMap<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private UnmodifiableNavigableMap m_descendingMap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<TK;+TV;>;)V")]
		[LineNumberTable(new byte[] { 173, 96, 104, 103 })]
		internal UnmodifiableNavigableMap(NavigableMap P_0)
		{
			this.m_delegate = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<TK;+TV;>;Lcom/google/common/collect/Maps$UnmodifiableNavigableMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 173, 101, 104, 103, 103 })]
		internal UnmodifiableNavigableMap(NavigableMap P_0, UnmodifiableNavigableMap P_1)
		{
			this.m_delegate = P_0;
			this.m_descendingMap = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(3693)]
		public virtual NavigableSet navigableKeySet()
		{
			NavigableSet result = Sets.unmodifiableNavigableSet(this.m_delegate.navigableKeySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 155, 238, 69, 106, 37 })]
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
			NavigableMap result = unmodifiableNavigableMap(this.m_delegate.subMap(P_0, P_1, P_2, P_3));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(3723)]
		public virtual NavigableMap headMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = unmodifiableNavigableMap(this.m_delegate.headMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(3733)]
		public virtual NavigableMap tailMap([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableMap result = unmodifiableNavigableMap(this.m_delegate.tailMap(P_0, P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(3550)]
		protected internal override SortedMap @delegate()
		{
			SortedMap result = Collections.unmodifiableSortedMap(this.m_delegate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3556)]
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
			Map.Entry result = access_0024800(this.m_delegate.lowerEntry(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(3562)]
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
			object result = this.m_delegate.lowerKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3568)]
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
			Map.Entry result = access_0024800(this.m_delegate.floorEntry(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(3574)]
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
			object result = this.m_delegate.floorKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3580)]
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
			Map.Entry result = access_0024800(this.m_delegate.ceilingEntry(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(3586)]
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
			object result = this.m_delegate.ceilingKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3592)]
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
			Map.Entry result = access_0024800(this.m_delegate.higherEntry(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(3598)]
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
			object result = this.m_delegate.higherKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3604)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry firstEntry()
		{
			Map.Entry result = access_0024800(this.m_delegate.firstEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3610)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry lastEntry()
		{
			Map.Entry result = access_0024800(this.m_delegate.lastEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3616)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public Map.Entry pollFirstEntry()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(3622)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public Map.Entry pollLastEntry()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
		[LineNumberTable(3627)]
		public override void replaceAll(BiFunction P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(3633)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object putIfAbsent(object P_0, object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 22, 0, 0, 0, 98, 0, 0, 22,
			1, 0, 0, 98, 0, 0
		})]
		[LineNumberTable(3638)]
		public override bool remove(object P_0, object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;TV;)Z")]
		[LineNumberTable(3643)]
		public override bool replace(object P_0, object P_1, object P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(3649)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object replace(object P_0, object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/Function<-TK;+TV;>;)TV;")]
		[LineNumberTable(3655)]
		public override object computeIfAbsent(object P_0, java.util.function.Function P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
		[LineNumberTable(3661)]
		public override object computeIfPresent(object P_0, BiFunction P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)TV;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 1, 2, 3, 1, 2, 0, 0,
			98, 0, 0
		})]
		[LineNumberTable(3667)]
		public override object compute(object P_0, BiFunction P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)TV;")]
		[LineNumberTable(3673)]
		public override object merge(object P_0, object P_1, BiFunction P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 173, 238, 103, 99, 126, 1 })]
		public virtual NavigableMap descendingMap()
		{
			UnmodifiableNavigableMap unmodifiableNavigableMap = this.m_descendingMap;
			UnmodifiableNavigableMap result;
			if (unmodifiableNavigableMap == null)
			{
				UnmodifiableNavigableMap unmodifiableNavigableMap2 = new UnmodifiableNavigableMap(this.m_delegate.descendingMap(), this);
				result = unmodifiableNavigableMap2;
				this.m_descendingMap = unmodifiableNavigableMap2;
			}
			else
			{
				result = unmodifiableNavigableMap;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(3688)]
		public override Set keySet()
		{
			NavigableSet result = navigableKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TK;>;")]
		[LineNumberTable(3698)]
		public virtual NavigableSet descendingKeySet()
		{
			NavigableSet result = Sets.unmodifiableNavigableSet(this.m_delegate.descendingKeySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(3703)]
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
			NavigableMap result = subMap(P_0, true, P_1, false);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(3718)]
		public override SortedMap headMap([ParametricNullness(new object[]
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
		[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
		[LineNumberTable(3728)]
		public override SortedMap tailMap([ParametricNullness(new object[]
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
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3533)]
		protected internal new virtual Map @delegate()
		{
			SortedMap result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(3533)]
		protected internal new virtual object @delegate()
		{
			SortedMap result = this.@delegate();
			_ = null;
			return result;
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
		protected UnmodifiableNavigableMap(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 38, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)38,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ValueDifferenceImpl : java.lang.Object, MapDifference.ValueDifference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object left;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object right;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<V:Ljava/lang/Object;>(TV;TV;)Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 38, 0, 0 })]
		[LineNumberTable(729)]
		internal static MapDifference.ValueDifference create([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			ValueDifferenceImpl result = new ValueDifferenceImpl(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;TV;)V")]
		[LineNumberTable(new byte[] { 162, 106, 104, 103, 103 })]
		private ValueDifferenceImpl([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			left = P_0;
			right = P_1;
		}

		[Signature("()TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object leftValue()
		{
			return left;
		}

		[Signature("()TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object rightValue()
		{
			return right;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 125, 104, 103, 122, 48, 161 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is MapDifference.ValueDifference)
			{
				MapDifference.ValueDifference valueDifference = (MapDifference.ValueDifference)P_0;
				return (com.google.common.@base.Objects.equal(left, valueDifference.leftValue()) && com.google.common.@base.Objects.equal(right, valueDifference.rightValue())) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(761)]
		public override int hashCode()
		{
			int result = com.google.common.@base.Objects.hashCode(left, right);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(766)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(left);
			string text2 = java.lang.String.valueOf(right);
			int num = 4 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string result = new StringBuilder(num).append("(").append(text).append(", ")
				.append(text2)
				.append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractCollection<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 106, 0, 0,
		17, 1, 0, 0, 0, 106, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)106,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class Values : AbstractCollection
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiConsumer
		{
			private readonly Consumer arg_00241;

			internal ___003C_003EAnon0(Consumer P_0)
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

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;TV;>;")]
		internal Map map;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 176, 6, 104, 113 })]
		internal Values(Map P_0)
		{
			this.map = (Map)Preconditions.checkNotNull(P_0);
		}

		[Signature("()Ljava/util/Map<TK;TV;>;")]
		internal Map map()
		{
			return this.map;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(4233)]
		private static void lambda_0024forEach_00240(Consumer P_0, object P_1, object P_2)
		{
			P_0.accept(P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(4226)]
		public override Iterator iterator()
		{
			Iterator result = valueIterator(map().entrySet().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TV;>;)V")]
		[LineNumberTable(new byte[] { 176, 21, 135, 120 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			this.map.forEach(new ___003C_003EAnon0(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 29, 118, 97, 127, 6, 110, 114, 130, 98 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0009
			try
			{
				return base.remove(P_0);
			}
			catch (UnsupportedOperationException)
			{
			}
			_ = null;
			Iterator iterator = map().entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (com.google.common.@base.Objects.equal(P_0, entry.getValue()))
				{
					map().remove(entry.getKey());
					return true;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[]
		{
			176, 44, 127, 1, 97, 102, 127, 6, 110, 141,
			98
		})]
		public override bool removeAll(Collection P_0)
		{
			//Discarded unreachable code: IL_0013
			try
			{
				return base.removeAll((Collection)Preconditions.checkNotNull(P_0));
			}
			catch (UnsupportedOperationException)
			{
			}
			_ = null;
			HashSet hashSet = Sets.newHashSet();
			Iterator iterator = map().entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (P_0.contains(entry.getValue()))
				{
					((Set)hashSet).add(entry.getKey());
				}
			}
			return map().keySet().removeAll(hashSet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[]
		{
			176, 59, 127, 1, 97, 102, 127, 6, 110, 141,
			98
		})]
		public override bool retainAll(Collection P_0)
		{
			//Discarded unreachable code: IL_0013
			try
			{
				return base.retainAll((Collection)Preconditions.checkNotNull(P_0));
			}
			catch (UnsupportedOperationException)
			{
			}
			_ = null;
			HashSet hashSet = Sets.newHashSet();
			Iterator iterator = map().entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (P_0.contains(entry.getValue()))
				{
					((Set)hashSet).add(entry.getKey());
				}
			}
			return map().keySet().retainAll(hashSet);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4283)]
		public override int size()
		{
			int result = map().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4288)]
		public override bool isEmpty()
		{
			bool result = map().isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(4293)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = map().containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 176, 88, 109 })]
		public override void clear()
		{
			map().clear();
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 56, 0, 0,
		17, 1, 0, 0, 0, 56, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)56,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class ViewCachingAbstractMap : AbstractMap
	{
		[NonSerialized]
		[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new Set m_entrySet;

		[NonSerialized]
		[Signature("Ljava/util/Set<TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new Set m_keySet;

		[NonSerialized]
		[Signature("Ljava/util/Collection<TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private new Collection m_values;

		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal abstract Set createEntrySet();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(3823)]
		internal virtual Set createKeySet()
		{
			KeySet result = new KeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(3835)]
		internal virtual Collection createValues()
		{
			Values result = new Values(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(3797)]
		internal ViewCachingAbstractMap()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(new byte[] { 174, 112, 103 })]
		public override Set entrySet()
		{
			Set set = this.m_entrySet;
			Set result;
			if (set == null)
			{
				Set set2 = createEntrySet();
				result = set2;
				this.m_entrySet = set2;
			}
			else
			{
				result = set;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(new byte[] { 174, 120, 103 })]
		public override Set keySet()
		{
			Set set = this.m_keySet;
			Set result;
			if (set == null)
			{
				Set set2 = createKeySet();
				result = set2;
				this.m_keySet = set2;
			}
			else
			{
				result = set;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(new byte[] { 174, 132, 103 })]
		public override Collection values()
		{
			Collection collection = this.m_values;
			Collection result;
			if (collection == null)
			{
				Collection collection2 = createValues();
				result = collection2;
				this.m_values = collection2;
			}
			else
			{
				result = collection;
			}
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/LinkedHashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(308)]
	public static LinkedHashMap newLinkedHashMap()
	{
		LinkedHashMap result = new LinkedHashMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Ljava/util/Map$Entry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1466)]
	public static Map.Entry immutableEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		ImmutableEntry result = new ImmutableEntry(key, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Ljava/util/Map<+TK;+TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 175, 51, 127, 1, 115, 98 })]
	internal static void putAllImpl(Map P_0, Map P_1)
	{
		Iterator iterator = P_1.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			P_0.put(entry.getKey(), entry.getValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<**>;Ljava/lang/Object;)Z")]
	[LineNumberTable(3930)]
	internal static bool containsKeyImpl(Map P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		bool result = Iterators.contains(keyIterator(P_0.entrySet().iterator()), P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<**>;Ljava/lang/Object;)Z")]
	[LineNumberTable(3935)]
	internal static bool containsValueImpl(Map P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		bool result = Iterators.contains(valueIterator(P_0.entrySet().iterator()), P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<**>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 175, 25, 100, 98, 104, 103, 148 })]
	internal static bool equalsImpl(Map P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 == P_1)
		{
			return true;
		}
		if (P_1 is Map)
		{
			Map map = (Map)P_1;
			bool result = P_0.entrySet().equals(map.entrySet());
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<**>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[]
	{
		175, 36, 115, 98, 127, 1, 99, 140, 98, 127,
		0, 98
	})]
	internal static string toStringImpl(Map P_0)
	{
		StringBuilder stringBuilder = Collections2.newStringBuilderForCollection(P_0.size()).append('{');
		int num = 1;
		Iterator iterator = P_0.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			if (num == 0)
			{
				stringBuilder.append(", ");
			}
			num = 0;
			stringBuilder.append(entry.getKey()).append('=').append(entry.getValue());
		}
		string result = stringBuilder.append('}').toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;Ljava/lang/Object;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 174, 254, 104, 130 })]
	internal static bool containsEntryImpl(Collection P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (!(P_1 is Map.Entry))
		{
			return false;
		}
		bool result = P_0.contains(unmodifiableEntry((Map.Entry)P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/Iterator<TK;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(124)]
	internal static Iterator keyIterator(Iterator P_0)
	{
		_1 result = new _1(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/Iterator<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(135)]
	internal static Iterator valueIterator(Iterator P_0)
	{
		_2 result = new _2(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/Map<*TV;>;Ljava/lang/Object;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(new byte[] { 174, 222, 135, 127, 16, 97 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static object safeRemove(Map P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		//Discarded unreachable code: IL_0010
		Preconditions.checkNotNull(P_0);
		try
		{
			try
			{
				return P_0.remove(P_1);
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0032;
		}
		object obj = null;
		goto IL_0036;
		IL_0032:
		obj = null;
		goto IL_0036;
		IL_0036:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/Map<*TV;>;Ljava/lang/Object;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(new byte[] { 174, 195, 135, 127, 16, 97 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static object safeGet(Map P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		//Discarded unreachable code: IL_0010
		Preconditions.checkNotNull(P_0);
		try
		{
			try
			{
				return P_0.get(P_1);
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0032;
		}
		object obj = null;
		goto IL_0036;
		IL_0032:
		obj = null;
		goto IL_0036;
		IL_0036:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<**>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 174, 208, 135, 127, 16, 97 })]
	internal static bool safeContainsKey(Map P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		//Discarded unreachable code: IL_0010
		Preconditions.checkNotNull(P_0);
		try
		{
			try
			{
				return P_0.containsKey(P_1);
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0032;
		}
		object obj = null;
		goto IL_0036;
		IL_0032:
		obj = null;
		goto IL_0036;
		IL_0036:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;>(Ljava/util/Map$Entry<TK;*>;)TK;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(4066)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static object keyOrNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Map.Entry P_0)
	{
		object result = P_0?.getKey();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;>()Lcom/google/common/base/Function<Ljava/util/Map$Entry<TK;*>;TK;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(114)]
	internal static com.google.common.@base.Function keyFunction()
	{
		return EntryFunction.KEY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/HashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(239)]
	public static HashMap newHashMap()
	{
		HashMap result = new HashMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Lcom/google/common/collect/ImmutableMap<TE;Ljava/lang/Integer;>;")]
	[LineNumberTable(new byte[] { 177, 123, 108, 98, 118, 114, 98 })]
	internal static ImmutableMap indexMap(Collection P_0)
	{
		ImmutableMap.Builder builder = new ImmutableMap.Builder(P_0.size());
		int num = 0;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object key = iterator.next();
			int i = num;
			num++;
			builder.put(key, Integer.valueOf(i));
		}
		ImmutableMap result = builder.buildOrThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Ljava/util/HashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(274)]
	public static HashMap newHashMapWithExpectedSize(int expectedSize)
	{
		HashMap result = new HashMap(capacity(expectedSize));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<-TK;>;)Lcom/google/common/base/Predicate<Ljava/util/Map$Entry<TK;*>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(2462)]
	internal static com.google.common.@base.Predicate keyPredicateOnEntries(com.google.common.@base.Predicate P_0)
	{
		com.google.common.@base.Predicate result = Predicates.compose(P_0, keyFunction());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/base/Predicate<-TV;>;)Lcom/google/common/base/Predicate<Ljava/util/Map$Entry<*TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(2467)]
	internal static com.google.common.@base.Predicate valuePredicateOnEntries(com.google.common.@base.Predicate P_0)
	{
		com.google.common.@base.Predicate result = Predicates.compose(P_0, valueFunction());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 169, 77, 103, 103, 104, 110, 18 })]
	public static Map filterKeys(Map unfiltered, com.google.common.@base.Predicate keyPredicate)
	{
		Preconditions.checkNotNull(keyPredicate);
		com.google.common.@base.Predicate predicate = keyPredicateOnEntries(keyPredicate);
		Map obj = ((!(unfiltered is AbstractFilteredMap)) ? new FilteredKeyMap((Map)Preconditions.checkNotNull(unfiltered), keyPredicate, predicate) : filterFiltered((AbstractFilteredMap)unfiltered, predicate));
		Map result = ((obj == null) ? null : ((obj as Map) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(1293)]
	public static ImmutableMap toMap(Iterable keys, com.google.common.@base.Function valueFunction)
	{
		ImmutableMap result = toMap(keys.iterator(), valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<TV;>;Lcom/google/common/base/Function<-TV;TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(1353)]
	public static ImmutableMap uniqueIndex(Iterable values, com.google.common.@base.Function keyFunction)
	{
		ImmutableMap result = uniqueIndex(values.iterator(), keyFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I)Ljava/util/LinkedHashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(343)]
	public static LinkedHashMap newLinkedHashMapWithExpectedSize(int expectedSize)
	{
		LinkedHashMap result = new LinkedHashMap(capacity(expectedSize));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/Map$Entry<*TV;>;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(4071)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static object valueOrNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Map.Entry P_0)
	{
		object result = P_0?.getValue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>()Lcom/google/common/base/Function<Ljava/util/Map$Entry<*TV;>;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(119)]
	internal static com.google.common.@base.Function valueFunction()
	{
		return EntryFunction.VALUE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;)Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1512)]
	internal static UnmodifiableIterator unmodifiableEntryIterator(Iterator P_0)
	{
		_8 result = new _8(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map$Entry<+TK;+TV;>;)Ljava/util/Map$Entry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 165, 99, 103 })]
	internal static Map.Entry unmodifiableEntry(Map.Entry P_0)
	{
		Preconditions.checkNotNull(P_0);
		_7 result = new _7(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 168, 100, 108, 132, 200, 150 })]
	internal static int capacity(int P_0)
	{
		if (P_0 < 3)
		{
			CollectPreconditions.checkNonnegative(P_0, "expectedSize");
			return P_0 + 1;
		}
		if (P_0 < 1073741824)
		{
			return ByteCodeHelper.f2i((float)P_0 / 0.75f + 1f);
		}
		return int.MaxValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map$Entry<TK;+TV;>;)Ljava/util/Map$Entry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(3530)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Map.Entry unmodifiableOrNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Map.Entry P_0)
	{
		Map.Entry result = ((P_0 != null) ? unmodifiableEntry(P_0) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/NavigableSet<TE;>;)Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(1216)]
	private static NavigableSet removeOnlyNavigableSet(NavigableSet P_0)
	{
		_6 result = new _6(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/SortedSet<TE;>;)Ljava/util/SortedSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(1179)]
	private static SortedSet removeOnlySortedSet(SortedSet P_0)
	{
		_5 result = new _5(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Set<TE;>;)Ljava/util/Set<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(1159)]
	private static Set removeOnlySet(Set P_0)
	{
		_4 result = new _4(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;+TV;>;)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 162, 5, 104, 142 })]
	private static Map unmodifiableMap(Map P_0)
	{
		if (P_0 is SortedMap)
		{
			SortedMap result = Collections.unmodifiableSortedMap((SortedMap)P_0);
			_ = null;
			return result;
		}
		Map result2 = Collections.unmodifiableMap(P_0);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;+TV;>;Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/SortedMapDifference<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		161, 200, 103, 103, 108, 103, 103, 103, 103, 232,
		76, 135, 110
	})]
	public static SortedMapDifference difference(SortedMap left, Map right)
	{
		Preconditions.checkNotNull(left);
		Preconditions.checkNotNull(right);
		Comparator comparator = orNaturalOrder(left.comparator());
		TreeMap treeMap = newTreeMap(comparator);
		TreeMap treeMap2 = newTreeMap(comparator);
		((Map)treeMap2).putAll(right);
		TreeMap treeMap3 = newTreeMap(comparator);
		TreeMap treeMap4 = newTreeMap(comparator);
		Equivalence equivalence = Equivalence.equals();
		doDifference(left, right, equivalence, treeMap, treeMap2, treeMap3, treeMap4);
		SortedMapDifferenceImpl result = new SortedMapDifferenceImpl(treeMap, treeMap2, treeMap3, treeMap4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;Ljava/util/Map<+TK;+TV;>;Lcom/google/common/base/Equivalence<-TV;>;)Lcom/google/common/collect/MapDifference<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 170, 135, 102, 103, 102, 102, 108 })]
	public static MapDifference difference(Map left, Map right, Equivalence valueEquivalence)
	{
		Preconditions.checkNotNull(valueEquivalence);
		LinkedHashMap linkedHashMap = newLinkedHashMap();
		LinkedHashMap linkedHashMap2 = new LinkedHashMap(right);
		LinkedHashMap linkedHashMap3 = newLinkedHashMap();
		LinkedHashMap linkedHashMap4 = newLinkedHashMap();
		doDifference(left, right, valueEquivalence, linkedHashMap, linkedHashMap2, linkedHashMap3, linkedHashMap4);
		MapDifferenceImpl result = new MapDifferenceImpl(linkedHashMap, linkedHashMap2, linkedHashMap3, linkedHashMap4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;Ljava/util/Map<+TK;+TV;>;Lcom/google/common/base/Equivalence<-TV;>;Ljava/util/Map<TK;TV;>;Ljava/util/Map<TK;TV;>;Ljava/util/Map<TK;TV;>;Ljava/util/Map<TK;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		161, 233, 127, 4, 103, 103, 233, 75, 111, 107,
		140, 145, 98, 137, 101
	})]
	private static void doDifference(Map P_0, Map P_1, Equivalence P_2, Map P_3, Map P_4, Map P_5, Map P_6)
	{
		Iterator iterator = P_0.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			object key = entry.getKey();
			object value = entry.getValue();
			if (P_1.containsKey(key))
			{
				object obj = NullnessCasts.uncheckedCastNullableTToT(P_4.remove(key));
				if (P_2.equivalent(value, obj))
				{
					P_5.put(key, value);
				}
				else
				{
					P_6.put(key, ValueDifferenceImpl.create(value, obj));
				}
			}
			else
			{
				P_3.put(key, value);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;)Ljava/util/Comparator<-TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 183, 99, 130 })]
	internal static Comparator orNaturalOrder([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_0)
	{
		if (P_0 != null)
		{
			return P_0;
		}
		Ordering result = Ordering.natural();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C:Ljava/lang/Object;K:TC;V:Ljava/lang/Object;>(Ljava/util/Comparator<TC;>;)Ljava/util/TreeMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 2, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(412)]
	public static TreeMap newTreeMap([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator comparator)
	{
		TreeMap result = new TreeMap(comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Iterator<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 164, 173, 103, 102, 104, 103, 111, 130 })]
	public static ImmutableMap toMap(Iterator keys, com.google.common.@base.Function valueFunction)
	{
		Preconditions.checkNotNull(valueFunction);
		ImmutableMap.Builder builder = ImmutableMap.builder();
		while (keys.hasNext())
		{
			object obj = keys.next();
			builder.put(obj, valueFunction.apply(obj));
		}
		ImmutableMap result = builder.buildKeepingLast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Iterator<TV;>;Lcom/google/common/base/Function<-TV;TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		164, 250, 103, 102, 104, 103, 111, 130, 124, 98,
		98
	})]
	public static ImmutableMap uniqueIndex(Iterator values, com.google.common.@base.Function keyFunction)
	{
		//Discarded unreachable code: IL_0035
		Preconditions.checkNotNull(keyFunction);
		ImmutableMap.Builder builder = ImmutableMap.builder();
		while (values.hasNext())
		{
			object obj = values.next();
			builder.put(keyFunction.apply(obj), obj);
		}
		IllegalArgumentException ex;
		try
		{
			return builder.buildOrThrow();
		}
		catch (IllegalArgumentException x)
		{
			ex = ByteCodeHelper.MapException<IllegalArgumentException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IllegalArgumentException @this = ex;
		string s = java.lang.String.instancehelper_concat(java.lang.String.valueOf(Throwable.instancehelper_getMessage(@this)), ". To index multiple values under a key, use Multimaps.index.");
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TV1;TV2;>;)Lcom/google/common/collect/Maps$EntryTransformer<TK;TV1;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 167, 206, 103 })]
	internal static EntryTransformer asEntryTransformer(com.google.common.@base.Function P_0)
	{
		Preconditions.checkNotNull(P_0);
		_9 result = new _9(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Ljava/util/Map<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)Ljava/util/Map<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1967)]
	public static Map transformEntries(Map fromMap, EntryTransformer transformer)
	{
		TransformedEntriesMap result = new TransformedEntriesMap(fromMap, transformer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)Ljava/util/SortedMap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(2021)]
	public static SortedMap transformEntries(SortedMap fromMap, EntryTransformer transformer)
	{
		TransformedEntriesSortedMap result = new TransformedEntriesSortedMap(fromMap, transformer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV1;>;Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)Ljava/util/NavigableMap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(2077)]
	public static NavigableMap transformEntries(NavigableMap fromMap, EntryTransformer transformer)
	{
		TransformedEntriesNavigableMap result = new TransformedEntriesNavigableMap(fromMap, transformer);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Maps$AbstractFilteredMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 170, 196, 109, 44 })]
	private static Map filterFiltered(AbstractFilteredMap P_0, com.google.common.@base.Predicate P_1)
	{
		FilteredEntryMap result = new FilteredEntryMap(P_0.unfiltered, Predicates.and(P_0.predicate, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/SortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 170, 112, 103, 104, 110, 17 })]
	public static SortedMap filterEntries(SortedMap unfiltered, com.google.common.@base.Predicate entryPredicate)
	{
		Preconditions.checkNotNull(entryPredicate);
		SortedMap obj = ((!(unfiltered is FilteredEntrySortedMap)) ? new FilteredEntrySortedMap((SortedMap)Preconditions.checkNotNull(unfiltered), entryPredicate) : filterFiltered((FilteredEntrySortedMap)unfiltered, entryPredicate));
		SortedMap result = ((obj == null) ? null : ((obj as SortedMap) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 170, 148, 103, 104, 110, 17 })]
	public static NavigableMap filterEntries(NavigableMap unfiltered, com.google.common.@base.Predicate entryPredicate)
	{
		Preconditions.checkNotNull(entryPredicate);
		NavigableMap obj = ((!(unfiltered is FilteredEntryNavigableMap)) ? new FilteredEntryNavigableMap((NavigableMap)Preconditions.checkNotNull(unfiltered), entryPredicate) : filterFiltered((FilteredEntryNavigableMap)unfiltered, entryPredicate));
		NavigableMap result = ((obj == null) ? null : ((obj as NavigableMap) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/BiMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Lcom/google/common/collect/BiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 170, 183, 103, 103, 104, 110, 7 })]
	public static BiMap filterEntries(BiMap unfiltered, com.google.common.@base.Predicate entryPredicate)
	{
		Preconditions.checkNotNull(unfiltered);
		Preconditions.checkNotNull(entryPredicate);
		BiMap obj = ((!(unfiltered is FilteredEntryBiMap)) ? new FilteredEntryBiMap(unfiltered, entryPredicate) : filterFiltered((FilteredEntryBiMap)unfiltered, entryPredicate));
		BiMap result = ((obj == null) ? null : ((obj as BiMap) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 170, 77, 103, 104, 110, 17 })]
	public static Map filterEntries(Map unfiltered, com.google.common.@base.Predicate entryPredicate)
	{
		Preconditions.checkNotNull(entryPredicate);
		Map obj = ((!(unfiltered is AbstractFilteredMap)) ? new FilteredEntryMap((Map)Preconditions.checkNotNull(unfiltered), entryPredicate) : filterFiltered((AbstractFilteredMap)unfiltered, entryPredicate));
		Map result = ((obj == null) ? null : ((obj as Map) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Maps$FilteredEntrySortedMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/SortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 170, 207, 109 })]
	private static SortedMap filterFiltered(FilteredEntrySortedMap P_0, com.google.common.@base.Predicate P_1)
	{
		com.google.common.@base.Predicate predicate = Predicates.and(P_0.predicate, P_1);
		FilteredEntrySortedMap result = new FilteredEntrySortedMap(P_0.sortedMap(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Maps$FilteredEntryNavigableMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 170, 219, 97, 108 })]
	private static NavigableMap filterFiltered(FilteredEntryNavigableMap P_0, com.google.common.@base.Predicate P_1)
	{
		com.google.common.@base.Predicate predicate = Predicates.and(FilteredEntryNavigableMap.access_0024500(P_0), P_1);
		FilteredEntryNavigableMap result = new FilteredEntryNavigableMap(FilteredEntryNavigableMap.access_0024600(P_0), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Maps$FilteredEntryBiMap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)Lcom/google/common/collect/BiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 170, 231, 109 })]
	private static BiMap filterFiltered(FilteredEntryBiMap P_0, com.google.common.@base.Predicate P_1)
	{
		com.google.common.@base.Predicate predicate = Predicates.and(P_0.predicate, P_1);
		FilteredEntryBiMap result = new FilteredEntryBiMap(P_0.unfiltered(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(93)]
	private Maps()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/util/Map<TK;+TV;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		108, 136, 103, 130, 108, 104, 136, 108, 108, 104,
		104, 104, 105, 107, 104, 109, 110, 105, 105, 108,
		98
	})]
	public static ImmutableMap immutableEnumMap(Map map)
	{
		if (map is ImmutableEnumMap)
		{
			return (ImmutableEnumMap)map;
		}
		Iterator iterator = map.entrySet().iterator();
		if (!iterator.hasNext())
		{
			ImmutableMap result = ImmutableMap.of();
			_ = null;
			return result;
		}
		Map.Entry entry = (Map.Entry)iterator.next();
		java.lang.Enum @enum = (java.lang.Enum)entry.getKey();
		object value = entry.getValue();
		CollectPreconditions.checkEntryNotNull(@enum, value);
		Class declaringClass = @enum.getDeclaringClass();
		EnumMap enumMap = new EnumMap(declaringClass);
		enumMap.put(@enum, value);
		while (iterator.hasNext())
		{
			Map.Entry entry2 = (Map.Entry)iterator.next();
			java.lang.Enum enum2 = (java.lang.Enum)entry2.getKey();
			object value2 = entry2.getValue();
			CollectPreconditions.checkEntryNotNull(enum2, value2);
			enumMap.put(enum2, value2);
		}
		ImmutableMap result2 = ImmutableEnumMap.asImmutable(enumMap);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(202)]
	public static Collector toImmutableEnumMap(java.util.function.Function keyFunction, java.util.function.Function valueFunction)
	{
		Collector result = CollectCollectors.toImmutableEnumMap(keyFunction, valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(221)]
	public static Collector toImmutableEnumMap(java.util.function.Function keyFunction, java.util.function.Function valueFunction, BinaryOperator mergeFunction)
	{
		Collector result = CollectCollectors.toImmutableEnumMap(keyFunction, valueFunction, mergeFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;)Ljava/util/HashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(258)]
	public static HashMap newHashMap(Map map)
	{
		HashMap result = new HashMap(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;)Ljava/util/LinkedHashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(326)]
	public static LinkedHashMap newLinkedHashMap(Map map)
	{
		LinkedHashMap result = new LinkedHashMap(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/concurrent/ConcurrentMap<TK;TV;>;")]
	[LineNumberTable(352)]
	public static ConcurrentMap newConcurrentMap()
	{
		ConcurrentHashMap result = new ConcurrentHashMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable;V:Ljava/lang/Object;>()Ljava/util/TreeMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(368)]
	public static TreeMap newTreeMap()
	{
		TreeMap result = new TreeMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;+TV;>;)Ljava/util/TreeMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(389)]
	public static TreeMap newTreeMap(SortedMap map)
	{
		TreeMap result = new TreeMap(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/lang/Class<TK;>;)Ljava/util/EnumMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(423)]
	public static EnumMap newEnumMap(Class type)
	{
		EnumMap.___003Cclinit_003E();
		EnumMap result = new EnumMap((Class)Preconditions.checkNotNull(type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/util/Map<TK;+TV;>;)Ljava/util/EnumMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(440)]
	public static EnumMap newEnumMap(Map map)
	{
		EnumMap result = new EnumMap(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/IdentityHashMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(454)]
	public static IdentityHashMap newIdentityHashMap()
	{
		IdentityHashMap result = new IdentityHashMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<+TK;+TV;>;Ljava/util/Map<+TK;+TV;>;)Lcom/google/common/collect/MapDifference<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 106, 104, 103, 234, 77, 98, 107 })]
	public static MapDifference difference(Map left, Map right)
	{
		if (left is SortedMap)
		{
			SortedMap left2 = (SortedMap)left;
			SortedMapDifference result = difference(left2, right);
			_ = null;
			return result;
		}
		return difference(left, right, Equivalence.equals());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Set<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(841)]
	public static Map asMap(Set set, com.google.common.@base.Function function)
	{
		AsMapView result = new AsMapView(set, function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedSet<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)Ljava/util/SortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(869)]
	public static SortedMap asMap(SortedSet set, com.google.common.@base.Function function)
	{
		SortedAsMapView result = new SortedAsMapView(set, function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/NavigableSet<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(898)]
	public static NavigableMap asMap(NavigableSet set, com.google.common.@base.Function function)
	{
		NavigableAsMapView result = new NavigableAsMapView(set, function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Set<TK;>;Lcom/google/common/base/Function<-TK;TV;>;)Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(998)]
	internal static Iterator asMapEntryIterator(Set P_0, com.google.common.@base.Function P_1)
	{
		_3 result = new _3(P_0.iterator(), P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Properties;)Lcom/google/common/collect/ImmutableMap<Ljava/lang/String;Ljava/lang/String;>;")]
	[LineNumberTable(new byte[] { 165, 21, 134, 239, 77, 241, 79, 121, 130 })]
	public static ImmutableMap fromProperties(Properties properties)
	{
		ImmutableMap.Builder builder = ImmutableMap.builder();
		Enumeration enumeration = properties.propertyNames();
		while (enumeration.hasMoreElements())
		{
			string key = (string)java.util.Objects.requireNonNull(enumeration.nextElement());
			builder.put(key, (string)java.util.Objects.requireNonNull(properties.getProperty(key)));
		}
		ImmutableMap result = builder.buildOrThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;)Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1479)]
	internal static Set unmodifiableEntrySet(Set P_0)
	{
		UnmodifiableEntrySet result = new UnmodifiableEntrySet(Collections.unmodifiableSet(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>(Lcom/google/common/collect/BiMap<TA;TB;>;)Lcom/google/common/base/Converter<TA;TB;>;")]
	[LineNumberTable(1596)]
	public static Converter asConverter(BiMap bimap)
	{
		BiMapConverter result = new BiMapConverter(bimap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/BiMap<TK;TV;>;)Lcom/google/common/collect/BiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1676)]
	public static BiMap synchronizedBiMap(BiMap bimap)
	{
		BiMap result = Synchronized.biMap(bimap, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/BiMap<+TK;+TV;>;)Lcom/google/common/collect/BiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1692)]
	public static BiMap unmodifiableBiMap(BiMap bimap)
	{
		UnmodifiableBiMap result = new UnmodifiableBiMap(bimap, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Ljava/util/Map<TK;TV1;>;Lcom/google/common/base/Function<-TV1;TV2;>;)Ljava/util/Map<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1824)]
	public static Map transformValues(Map fromMap, com.google.common.@base.Function function)
	{
		Map result = transformEntries(fromMap, asEntryTransformer(function));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV1;>;Lcom/google/common/base/Function<-TV1;TV2;>;)Ljava/util/SortedMap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1867)]
	public static SortedMap transformValues(SortedMap fromMap, com.google.common.@base.Function function)
	{
		SortedMap result = transformEntries(fromMap, asEntryTransformer(function));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV1;>;Lcom/google/common/base/Function<-TV1;TV2;>;)Ljava/util/NavigableMap<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(1913)]
	public static NavigableMap transformValues(NavigableMap fromMap, com.google.common.@base.Function function)
	{
		NavigableMap result = transformEntries(fromMap, asEntryTransformer(function));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/collect/Maps$EntryTransformer<-TK;TV1;TV2;>;TK;)Lcom/google/common/base/Function<TV1;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 167, 219, 103 })]
	internal static com.google.common.@base.Function asValueToValueFunction(EntryTransformer P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		Preconditions.checkNotNull(P_0);
		_10 result = new _10(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)Lcom/google/common/base/Function<Ljava/util/Map$Entry<TK;TV1;>;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 167, 233, 103 })]
	internal static com.google.common.@base.Function asEntryToValueFunction(EntryTransformer P_0)
	{
		Preconditions.checkNotNull(P_0);
		_11 result = new _11(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V2:Ljava/lang/Object;K:Ljava/lang/Object;V1:Ljava/lang/Object;>(Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;Ljava/util/Map$Entry<TK;TV1;>;)Ljava/util/Map$Entry<TK;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 167, 247, 103, 103 })]
	internal static Map.Entry transformEntry(EntryTransformer P_0, Map.Entry P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		_12 result = new _12(P_1, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/collect/Maps$EntryTransformer<-TK;-TV1;TV2;>;)Lcom/google/common/base/Function<Ljava/util/Map$Entry<TK;TV1;>;Ljava/util/Map$Entry<TK;TV2;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0, 18, 2,
		0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 168, 12, 103 })]
	internal static com.google.common.@base.Function asEntryToEntryFunction(EntryTransformer P_0)
	{
		Preconditions.checkNotNull(P_0);
		_13 result = new _13(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)Ljava/util/SortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(2532)]
	public static SortedMap filterKeys(SortedMap unfiltered, com.google.common.@base.Predicate keyPredicate)
	{
		SortedMap result = filterEntries(unfiltered, keyPredicateOnEntries(keyPredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(2567)]
	public static NavigableMap filterKeys(NavigableMap unfiltered, com.google.common.@base.Predicate keyPredicate)
	{
		NavigableMap result = filterEntries(unfiltered, keyPredicateOnEntries(keyPredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/BiMap<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)Lcom/google/common/collect/BiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 169, 178, 103 })]
	public static BiMap filterKeys(BiMap unfiltered, com.google.common.@base.Predicate keyPredicate)
	{
		Preconditions.checkNotNull(keyPredicate);
		BiMap result = filterEntries(unfiltered, keyPredicateOnEntries(keyPredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TK;TV;>;Lcom/google/common/base/Predicate<-TV;>;)Ljava/util/Map<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(2625)]
	public static Map filterValues(Map unfiltered, com.google.common.@base.Predicate valuePredicate)
	{
		Map result = filterEntries(unfiltered, valuePredicateOnEntries(valuePredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/SortedMap<TK;TV;>;Lcom/google/common/base/Predicate<-TV;>;)Ljava/util/SortedMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(2657)]
	public static SortedMap filterValues(SortedMap unfiltered, com.google.common.@base.Predicate valuePredicate)
	{
		SortedMap result = filterEntries(unfiltered, valuePredicateOnEntries(valuePredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV;>;Lcom/google/common/base/Predicate<-TV;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(2690)]
	public static NavigableMap filterValues(NavigableMap unfiltered, com.google.common.@base.Predicate valuePredicate)
	{
		NavigableMap result = filterEntries(unfiltered, valuePredicateOnEntries(valuePredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/BiMap<TK;TV;>;Lcom/google/common/base/Predicate<-TV;>;)Lcom/google/common/collect/BiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(2722)]
	public static BiMap filterValues(BiMap unfiltered, com.google.common.@base.Predicate valuePredicate)
	{
		BiMap result = filterEntries(unfiltered, valuePredicateOnEntries(valuePredicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;+TV;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 173, 75, 103, 136, 98, 130 })]
	public static NavigableMap unmodifiableNavigableMap(NavigableMap map)
	{
		Preconditions.checkNotNull(map);
		if (map is UnmodifiableNavigableMap)
		{
			return map;
		}
		UnmodifiableNavigableMap result = new UnmodifiableNavigableMap(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(3789)]
	public static NavigableMap synchronizedNavigableMap(NavigableMap navigableMap)
	{
		NavigableMap result = Synchronized.navigableMap(navigableMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;Ljava/lang/Object;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 1, 27, 0, 0,
		18, 1, 0, 0, 1, 27, 0, 0
	})]
	[LineNumberTable(new byte[] { 175, 17, 104, 130 })]
	internal static bool removeEntryImpl(Collection P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (!(P_1 is Map.Entry))
		{
			return false;
		}
		bool result = P_0.remove(unmodifiableEntry((Map.Entry)P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(Ljava/util/NavigableMap<TK;TV;>;Lcom/google/common/collect/Range<TK;>;)Ljava/util/NavigableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 1, 27, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		177, 151, 105, 109, 104, 103, 97, 63, 2, 197,
		112, 98, 102, 109, 102, 236, 60, 232, 69, 104,
		124, 104, 156
	})]
	public static NavigableMap subMap(NavigableMap map, Range range)
	{
		if (map.comparator() != null && map.comparator() != Ordering.natural() && range.hasLowerBound() && range.hasUpperBound())
		{
			Preconditions.checkArgument(map.comparator().compare(range.lowerEndpoint(), range.upperEndpoint()) <= 0, (object)"map is using a custom comparator which is inconsistent with the natural ordering.");
		}
		if (range.hasLowerBound() && range.hasUpperBound())
		{
			NavigableMap result = map.subMap(range.lowerEndpoint(), range.lowerBoundType() == BoundType.___003C_003ECLOSED, range.upperEndpoint(), range.upperBoundType() == BoundType.___003C_003ECLOSED);
			_ = null;
			return result;
		}
		if (range.hasLowerBound())
		{
			NavigableMap result2 = map.tailMap(range.lowerEndpoint(), range.lowerBoundType() == BoundType.___003C_003ECLOSED);
			_ = null;
			return result2;
		}
		if (range.hasUpperBound())
		{
			NavigableMap result3 = map.headMap(range.upperEndpoint(), range.upperBoundType() == BoundType.___003C_003ECLOSED);
			_ = null;
			return result3;
		}
		return (NavigableMap)Preconditions.checkNotNull(map);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static Map access_0024100(Map P_0)
	{
		Map result = unmodifiableMap(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static Set access_0024200(Set P_0)
	{
		Set result = removeOnlySet(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static SortedSet access_0024300(SortedSet P_0)
	{
		SortedSet result = removeOnlySortedSet(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static NavigableSet access_0024400(NavigableSet P_0)
	{
		NavigableSet result = removeOnlyNavigableSet(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	internal static Map.Entry access_0024800(Map.Entry P_0)
	{
		Map.Entry result = unmodifiableOrNull(P_0);
		_ = null;
		return result;
	}
}
