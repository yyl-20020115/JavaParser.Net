using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMap<TK;TV;>;Ljava/util/SortedMap<TK;TV;>;")]
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
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.SortedMap" })]
public abstract class ForwardingSortedMap : ForwardingMap, SortedMap, Map
{
	[InnerClass(null, Modifiers.Protected)]
	[Signature("Lcom/google/common/collect/Maps$SortedKeySet<TK;TV;>;")]
	public new class StandardKeySet : Maps.SortedKeySet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 60, 105 })]
		public StandardKeySet(ForwardingSortedMap this_00240)
			: base(this_00240)
		{
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|comparator", "()Ljava.util.Comparator;")]
		public new Comparator comparator()
		{
			return ((Maps.SortedKeySet)this).comparator();
		}

		[HideFromJava]
		protected internal Comparator _003Cnonvirtual_003E0()
		{
			return base.comparator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|subSet", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet subSet(object P_0, object P_1)
		{
			return ((Maps.SortedKeySet)this).subSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E1(object P_0, object P_1)
		{
			return base.subSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|headSet", "(Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet headSet(object P_0)
		{
			return ((Maps.SortedKeySet)this).headSet(P_0);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E2(object P_0)
		{
			return base.headSet(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|tailSet", "(Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet tailSet(object P_0)
		{
			return ((Maps.SortedKeySet)this).tailSet(P_0);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E3(object P_0)
		{
			return base.tailSet(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|first", "()Ljava.lang.Object;")]
		public new object first()
		{
			return ((Maps.SortedKeySet)this).first();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E4()
		{
			return base.first();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|last", "()Ljava.lang.Object;")]
		public new object last()
		{
			return ((Maps.SortedKeySet)this).last();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E5()
		{
			return base.last();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|iterator", "()Ljava.util.Iterator;")]
		public new Iterator iterator()
		{
			return ((Maps.KeySet)this).iterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E6()
		{
			return base.iterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|forEach", "(Ljava.util.function.Consumer;)V")]
		public new void forEach(Consumer P_0)
		{
			((Maps.KeySet)this).forEach(P_0);
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E7(Consumer P_0)
		{
			base.forEach(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>8|size", "()I")]
		public new int size()
		{
			return ((Maps.KeySet)this).size();
		}

		[HideFromJava]
		protected internal int _003Cnonvirtual_003E8()
		{
			return base.size();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>9|isEmpty", "()Z")]
		public new bool isEmpty()
		{
			return ((Maps.KeySet)this).isEmpty();
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E9()
		{
			return base.isEmpty();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>10|contains", "(Ljava.lang.Object;)Z")]
		public new bool contains(object P_0)
		{
			return ((Maps.KeySet)this).contains(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E10(object P_0)
		{
			return base.contains(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>11|remove", "(Ljava.lang.Object;)Z")]
		public new bool remove(object P_0)
		{
			return ((Maps.KeySet)this).remove(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E11(object P_0)
		{
			return base.remove(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>12|clear", "()V")]
		public new void clear()
		{
			((Maps.KeySet)this).clear();
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E12()
		{
			base.clear();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>13|removeAll", "(Ljava.util.Collection;)Z")]
		public new bool removeAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).removeAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E13(Collection P_0)
		{
			return base.removeAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>14|retainAll", "(Ljava.util.Collection;)Z")]
		public new bool retainAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).retainAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E14(Collection P_0)
		{
			return base.retainAll(P_0);
		}
	}

	[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
	protected internal new abstract SortedMap @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TK;>;")]
	[LineNumberTable(69)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Comparator comparator()
	{
		Comparator result = @delegate().comparator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<*>;Ljava/lang/Object;Ljava/lang/Object;)I")]
	[LineNumberTable(new byte[] { 68, 99, 143 })]
	internal static int unsafeCompare([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2)
	{
		if (P_0 == null)
		{
			int result = Comparable.__Helper.compareTo((IComparable)P_1, P_2);
			_ = null;
			return result;
		}
		int result2 = P_0.compare(P_1, P_2);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(96)]
	public virtual SortedMap tailMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromKey)
	{
		SortedMap result = @delegate().tailMap(fromKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(61)]
	protected internal ForwardingSortedMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(75)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object firstKey()
	{
		object result = @delegate().firstKey();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(80)]
	public virtual SortedMap headMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toKey)
	{
		SortedMap result = @delegate().headMap(toKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(86)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object lastKey()
	{
		object result = @delegate().lastKey();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(91)]
	public virtual SortedMap subMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromKey, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toKey)
	{
		SortedMap result = @delegate().subMap(fromKey, toKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 88, 98, 109, 127, 33, 97 })]
	protected internal override bool standardContainsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		//Discarded unreachable code: IL_0024
		try
		{
			try
			{
				try
				{
					object obj = ((SortedMap)this).tailMap(key).firstKey();
					return (unsafeCompare(comparator(), obj, key) == 0) ? true : false;
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
				}
			}
			catch (NoSuchElementException)
			{
				goto IL_0048;
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_004b;
		}
		object obj2 = null;
		goto IL_004f;
		IL_004b:
		obj2 = null;
		goto IL_004f;
		IL_0048:
		obj2 = null;
		goto IL_004f;
		IL_004f:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 105, 125 })]
	protected internal virtual SortedMap standardSubMap(object fromKey, object toKey)
	{
		Preconditions.checkArgument(unsafeCompare(comparator(), fromKey, toKey) <= 0, (object)"fromKey must be <= toKey");
		SortedMap result = tailMap(fromKey).headMap(toKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(54)]
	protected internal new virtual Map _003Cbridge_003Edelegate()
	{
		SortedMap result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(54)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		SortedMap result = @delegate();
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
