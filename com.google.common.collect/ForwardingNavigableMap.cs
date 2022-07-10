using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingSortedMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 144, 0, 0,
	17, 1, 0, 0, 0, 144, 0, 0
})]
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
[Implements(new string[] { "java.util.NavigableMap" })]
public abstract class ForwardingNavigableMap : ForwardingSortedMap, NavigableMap, SortedMap, Map
{
	[InnerClass(null, Modifiers.Protected)]
	[Signature("Lcom/google/common/collect/Maps$DescendingMap<TK;TV;>;")]
	public class StandardDescendingMap : Maps.DescendingMap
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal class _1 : Object, Iterator
		{
			[Signature("Ljava/util/Map$Entry<TK;TV;>;")]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			private Map.Entry toRemove;

			[Signature("Ljava/util/Map$Entry<TK;TV;>;")]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			private Map.Entry nextOrNull;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal StandardDescendingMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 160, 218, 104, 171, 139, 108, 127, 2, 3, 2 })]
			public virtual Map.Entry next()
			{
				if (nextOrNull == null)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new NoSuchElementException();
				}
				try
				{
					return nextOrNull;
				}
				finally
				{
					toRemove = nextOrNull;
					nextOrNull = this_00241.forward().lowerEntry(nextOrNull.getKey());
				}
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 207, 111, 103 })]
			internal _1(StandardDescendingMap P_0)
			{
				this_00241 = P_0;
				base._002Ector();
				toRemove = null;
				nextOrNull = this_00241.forward().lastEntry();
			}

			public virtual bool hasNext()
			{
				return nextOrNull != null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 160, 231, 104, 144, 124, 103 })]
			public virtual void remove()
			{
				if (toRemove == null)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new IllegalStateException("no calls to next() since the last call to remove()");
				}
				this_00241.forward().remove(toRemove.getKey());
				toRemove = null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(321)]
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

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ForwardingNavigableMap this_00240;

		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		internal override NavigableMap forward()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(307)]
		public StandardDescendingMap(ForwardingNavigableMap this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 202, 110 })]
		public override void replaceAll(BiFunction function)
		{
			forward().replaceAll(function);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(321)]
		protected internal override Iterator entryIterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|delegate", "()Ljava.util.Map;")]
		protected internal new Map @delegate()
		{
			return ((Maps.DescendingMap)this).@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|comparator", "()Ljava.util.Comparator;")]
		public new Comparator comparator()
		{
			return ((Maps.DescendingMap)this).comparator();
		}

		[HideFromJava]
		protected internal Comparator _003Cnonvirtual_003E1()
		{
			return base.comparator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|firstKey", "()Ljava.lang.Object;")]
		public new object firstKey()
		{
			return ((Maps.DescendingMap)this).firstKey();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E2()
		{
			return base.firstKey();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|lastKey", "()Ljava.lang.Object;")]
		public new object lastKey()
		{
			return ((Maps.DescendingMap)this).lastKey();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E3()
		{
			return base.lastKey();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|lowerEntry", "(Ljava.lang.Object;)Ljava.util.Map$Entry;")]
		public new Map.Entry lowerEntry(object P_0)
		{
			return ((Maps.DescendingMap)this).lowerEntry(P_0);
		}

		[HideFromJava]
		protected internal Map.Entry _003Cnonvirtual_003E4(object P_0)
		{
			return base.lowerEntry(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|lowerKey", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object lowerKey(object P_0)
		{
			return ((Maps.DescendingMap)this).lowerKey(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E5(object P_0)
		{
			return base.lowerKey(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|floorEntry", "(Ljava.lang.Object;)Ljava.util.Map$Entry;")]
		public new Map.Entry floorEntry(object P_0)
		{
			return ((Maps.DescendingMap)this).floorEntry(P_0);
		}

		[HideFromJava]
		protected internal Map.Entry _003Cnonvirtual_003E6(object P_0)
		{
			return base.floorEntry(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|floorKey", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object floorKey(object P_0)
		{
			return ((Maps.DescendingMap)this).floorKey(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E7(object P_0)
		{
			return base.floorKey(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>8|ceilingEntry", "(Ljava.lang.Object;)Ljava.util.Map$Entry;")]
		public new Map.Entry ceilingEntry(object P_0)
		{
			return ((Maps.DescendingMap)this).ceilingEntry(P_0);
		}

		[HideFromJava]
		protected internal Map.Entry _003Cnonvirtual_003E8(object P_0)
		{
			return base.ceilingEntry(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>9|ceilingKey", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object ceilingKey(object P_0)
		{
			return ((Maps.DescendingMap)this).ceilingKey(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E9(object P_0)
		{
			return base.ceilingKey(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>10|higherEntry", "(Ljava.lang.Object;)Ljava.util.Map$Entry;")]
		public new Map.Entry higherEntry(object P_0)
		{
			return ((Maps.DescendingMap)this).higherEntry(P_0);
		}

		[HideFromJava]
		protected internal Map.Entry _003Cnonvirtual_003E10(object P_0)
		{
			return base.higherEntry(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>11|higherKey", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object higherKey(object P_0)
		{
			return ((Maps.DescendingMap)this).higherKey(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E11(object P_0)
		{
			return base.higherKey(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>12|firstEntry", "()Ljava.util.Map$Entry;")]
		public new Map.Entry firstEntry()
		{
			return ((Maps.DescendingMap)this).firstEntry();
		}

		[HideFromJava]
		protected internal Map.Entry _003Cnonvirtual_003E12()
		{
			return base.firstEntry();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>13|lastEntry", "()Ljava.util.Map$Entry;")]
		public new Map.Entry lastEntry()
		{
			return ((Maps.DescendingMap)this).lastEntry();
		}

		[HideFromJava]
		protected internal Map.Entry _003Cnonvirtual_003E13()
		{
			return base.lastEntry();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>14|pollFirstEntry", "()Ljava.util.Map$Entry;")]
		public new Map.Entry pollFirstEntry()
		{
			return ((Maps.DescendingMap)this).pollFirstEntry();
		}

		[HideFromJava]
		protected internal Map.Entry _003Cnonvirtual_003E14()
		{
			return base.pollFirstEntry();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>15|pollLastEntry", "()Ljava.util.Map$Entry;")]
		public new Map.Entry pollLastEntry()
		{
			return ((Maps.DescendingMap)this).pollLastEntry();
		}

		[HideFromJava]
		protected internal Map.Entry _003Cnonvirtual_003E15()
		{
			return base.pollLastEntry();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>16|descendingMap", "()Ljava.util.NavigableMap;")]
		public new NavigableMap descendingMap()
		{
			return ((Maps.DescendingMap)this).descendingMap();
		}

		[HideFromJava]
		protected internal NavigableMap _003Cnonvirtual_003E16()
		{
			return base.descendingMap();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>17|entrySet", "()Ljava.util.Set;")]
		public new Set entrySet()
		{
			return ((Maps.DescendingMap)this).entrySet();
		}

		[HideFromJava]
		protected internal Set _003Cnonvirtual_003E17()
		{
			return base.entrySet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>18|keySet", "()Ljava.util.Set;")]
		public new Set keySet()
		{
			return ((Maps.DescendingMap)this).keySet();
		}

		[HideFromJava]
		protected internal Set _003Cnonvirtual_003E18()
		{
			return base.keySet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>19|navigableKeySet", "()Ljava.util.NavigableSet;")]
		public new NavigableSet navigableKeySet()
		{
			return ((Maps.DescendingMap)this).navigableKeySet();
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E19()
		{
			return base.navigableKeySet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>20|descendingKeySet", "()Ljava.util.NavigableSet;")]
		public new NavigableSet descendingKeySet()
		{
			return ((Maps.DescendingMap)this).descendingKeySet();
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E20()
		{
			return base.descendingKeySet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>21|subMap", "(Ljava.lang.Object;ZLjava.lang.Object;Z)Ljava.util.NavigableMap;")]
		public new NavigableMap subMap(object P_0, bool P_1, object P_2, bool P_3)
		{
			return ((Maps.DescendingMap)this).subMap(P_0, P_1, P_2, P_3);
		}

		[HideFromJava]
		protected internal NavigableMap _003Cnonvirtual_003E21(object P_0, bool P_1, object P_2, bool P_3)
		{
			return base.subMap(P_0, P_1, P_2, P_3);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>22|subMap", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.util.SortedMap;")]
		public new SortedMap subMap(object P_0, object P_1)
		{
			return ((Maps.DescendingMap)this).subMap(P_0, P_1);
		}

		[HideFromJava]
		protected internal SortedMap _003Cnonvirtual_003E22(object P_0, object P_1)
		{
			return base.subMap(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>23|headMap", "(Ljava.lang.Object;Z)Ljava.util.NavigableMap;")]
		public new NavigableMap headMap(object P_0, bool P_1)
		{
			return ((Maps.DescendingMap)this).headMap(P_0, P_1);
		}

		[HideFromJava]
		protected internal NavigableMap _003Cnonvirtual_003E23(object P_0, bool P_1)
		{
			return base.headMap(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>24|headMap", "(Ljava.lang.Object;)Ljava.util.SortedMap;")]
		public new SortedMap headMap(object P_0)
		{
			return ((Maps.DescendingMap)this).headMap(P_0);
		}

		[HideFromJava]
		protected internal SortedMap _003Cnonvirtual_003E24(object P_0)
		{
			return base.headMap(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>25|tailMap", "(Ljava.lang.Object;Z)Ljava.util.NavigableMap;")]
		public new NavigableMap tailMap(object P_0, bool P_1)
		{
			return ((Maps.DescendingMap)this).tailMap(P_0, P_1);
		}

		[HideFromJava]
		protected internal NavigableMap _003Cnonvirtual_003E25(object P_0, bool P_1)
		{
			return base.tailMap(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>26|tailMap", "(Ljava.lang.Object;)Ljava.util.SortedMap;")]
		public new SortedMap tailMap(object P_0)
		{
			return ((Maps.DescendingMap)this).tailMap(P_0);
		}

		[HideFromJava]
		protected internal SortedMap _003Cnonvirtual_003E26(object P_0)
		{
			return base.tailMap(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>27|values", "()Ljava.util.Collection;")]
		public new Collection values()
		{
			return ((Maps.DescendingMap)this).values();
		}

		[HideFromJava]
		protected internal Collection _003Cnonvirtual_003E27()
		{
			return base.values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>28|toString", "()Ljava.lang.String;")]
		public new string toString()
		{
			return ((Maps.DescendingMap)this).toString();
		}

		[HideFromJava]
		protected internal string _003Cnonvirtual_003E28()
		{
			return base.toString();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>29|delegate", "()Ljava.lang.Object;")]
		protected internal new object _003Cbridge_003Edelegate()
		{
			return ((Maps.DescendingMap)this).@delegate();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E29()
		{
			return base.@delegate();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>30|putIfAbsent", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object putIfAbsent(object P_0, object P_1)
		{
			return ((Maps.DescendingMap)this).putIfAbsent(P_0, P_1);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E30(object P_0, object P_1)
		{
			return base.putIfAbsent(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>31|getOrDefault", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object getOrDefault(object P_0, object P_1)
		{
			return ((Maps.DescendingMap)this).getOrDefault(P_0, P_1);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E31(object P_0, object P_1)
		{
			return base.getOrDefault(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>32|forEach", "(Ljava.util.function.BiConsumer;)V")]
		public new void forEach(BiConsumer P_0)
		{
			((Maps.DescendingMap)this).forEach(P_0);
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E32(BiConsumer P_0)
		{
			base.forEach(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>33|remove", "(Ljava.lang.Object;Ljava.lang.Object;)Z")]
		public new bool remove(object P_0, object P_1)
		{
			return ((Maps.DescendingMap)this).remove(P_0, P_1);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E33(object P_0, object P_1)
		{
			return base.remove(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>34|replace", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.lang.Object;)Z")]
		public new bool replace(object P_0, object P_1, object P_2)
		{
			return ((Maps.DescendingMap)this).replace(P_0, P_1, P_2);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E34(object P_0, object P_1, object P_2)
		{
			return base.replace(P_0, P_1, P_2);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>35|replace", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object replace(object P_0, object P_1)
		{
			return ((Maps.DescendingMap)this).replace(P_0, P_1);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E35(object P_0, object P_1)
		{
			return base.replace(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>36|computeIfAbsent", "(Ljava.lang.Object;Ljava.util.function.Function;)Ljava.lang.Object;")]
		public new object computeIfAbsent(object P_0, Function P_1)
		{
			return ((Maps.DescendingMap)this).computeIfAbsent(P_0, P_1);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E36(object P_0, Function P_1)
		{
			return base.computeIfAbsent(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>37|computeIfPresent", "(Ljava.lang.Object;Ljava.util.function.BiFunction;)Ljava.lang.Object;")]
		public new object computeIfPresent(object P_0, BiFunction P_1)
		{
			return ((Maps.DescendingMap)this).computeIfPresent(P_0, P_1);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E37(object P_0, BiFunction P_1)
		{
			return base.computeIfPresent(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>38|compute", "(Ljava.lang.Object;Ljava.util.function.BiFunction;)Ljava.lang.Object;")]
		public new object compute(object P_0, BiFunction P_1)
		{
			return ((Maps.DescendingMap)this).compute(P_0, P_1);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E38(object P_0, BiFunction P_1)
		{
			return base.compute(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>39|merge", "(Ljava.lang.Object;Ljava.lang.Object;Ljava.util.function.BiFunction;)Ljava.lang.Object;")]
		public new object merge(object P_0, object P_1, BiFunction P_2)
		{
			return ((Maps.DescendingMap)this).merge(P_0, P_1, P_2);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E39(object P_0, object P_1, BiFunction P_2)
		{
			return base.merge(P_0, P_1, P_2);
		}
	}

	[InnerClass(null, Modifiers.Protected)]
	[Signature("Lcom/google/common/collect/Maps$NavigableKeySet<TK;TV;>;")]
	public class StandardNavigableKeySet : Maps.NavigableKeySet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 2, 105 })]
		public StandardNavigableKeySet(ForwardingNavigableMap this_00240)
			: base(this_00240)
		{
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|lower", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object lower(object P_0)
		{
			return ((Maps.NavigableKeySet)this).lower(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E0(object P_0)
		{
			return base.lower(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|floor", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object floor(object P_0)
		{
			return ((Maps.NavigableKeySet)this).floor(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E1(object P_0)
		{
			return base.floor(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|ceiling", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object ceiling(object P_0)
		{
			return ((Maps.NavigableKeySet)this).ceiling(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E2(object P_0)
		{
			return base.ceiling(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|higher", "(Ljava.lang.Object;)Ljava.lang.Object;")]
		public new object higher(object P_0)
		{
			return ((Maps.NavigableKeySet)this).higher(P_0);
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E3(object P_0)
		{
			return base.higher(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|pollFirst", "()Ljava.lang.Object;")]
		public new object pollFirst()
		{
			return ((Maps.NavigableKeySet)this).pollFirst();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E4()
		{
			return base.pollFirst();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|pollLast", "()Ljava.lang.Object;")]
		public new object pollLast()
		{
			return ((Maps.NavigableKeySet)this).pollLast();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E5()
		{
			return base.pollLast();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|descendingSet", "()Ljava.util.NavigableSet;")]
		public new NavigableSet descendingSet()
		{
			return ((Maps.NavigableKeySet)this).descendingSet();
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E6()
		{
			return base.descendingSet();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|descendingIterator", "()Ljava.util.Iterator;")]
		public new Iterator descendingIterator()
		{
			return ((Maps.NavigableKeySet)this).descendingIterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E7()
		{
			return base.descendingIterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>8|subSet", "(Ljava.lang.Object;ZLjava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet subSet(object P_0, bool P_1, object P_2, bool P_3)
		{
			return ((Maps.NavigableKeySet)this).subSet(P_0, P_1, P_2, P_3);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E8(object P_0, bool P_1, object P_2, bool P_3)
		{
			return base.subSet(P_0, P_1, P_2, P_3);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>9|subSet", "(Ljava.lang.Object;Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet subSet(object P_0, object P_1)
		{
			return ((Maps.NavigableKeySet)this).subSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E9(object P_0, object P_1)
		{
			return base.subSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>10|headSet", "(Ljava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet headSet(object P_0, bool P_1)
		{
			return ((Maps.NavigableKeySet)this).headSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E10(object P_0, bool P_1)
		{
			return base.headSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>11|headSet", "(Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet headSet(object P_0)
		{
			return ((Maps.NavigableKeySet)this).headSet(P_0);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E11(object P_0)
		{
			return base.headSet(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>12|tailSet", "(Ljava.lang.Object;Z)Ljava.util.NavigableSet;")]
		public new NavigableSet tailSet(object P_0, bool P_1)
		{
			return ((Maps.NavigableKeySet)this).tailSet(P_0, P_1);
		}

		[HideFromJava]
		protected internal NavigableSet _003Cnonvirtual_003E12(object P_0, bool P_1)
		{
			return base.tailSet(P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>13|tailSet", "(Ljava.lang.Object;)Ljava.util.SortedSet;")]
		public new SortedSet tailSet(object P_0)
		{
			return ((Maps.NavigableKeySet)this).tailSet(P_0);
		}

		[HideFromJava]
		protected internal SortedSet _003Cnonvirtual_003E13(object P_0)
		{
			return base.tailSet(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>14|comparator", "()Ljava.util.Comparator;")]
		public new Comparator comparator()
		{
			return ((Maps.SortedKeySet)this).comparator();
		}

		[HideFromJava]
		protected internal Comparator _003Cnonvirtual_003E14()
		{
			return base.comparator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>15|first", "()Ljava.lang.Object;")]
		public new object first()
		{
			return ((Maps.SortedKeySet)this).first();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E15()
		{
			return base.first();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>16|last", "()Ljava.lang.Object;")]
		public new object last()
		{
			return ((Maps.SortedKeySet)this).last();
		}

		[HideFromJava]
		protected internal object _003Cnonvirtual_003E16()
		{
			return base.last();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>17|iterator", "()Ljava.util.Iterator;")]
		public new Iterator iterator()
		{
			return ((Maps.KeySet)this).iterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E17()
		{
			return base.iterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>18|forEach", "(Ljava.util.function.Consumer;)V")]
		public new void forEach(Consumer P_0)
		{
			((Maps.KeySet)this).forEach(P_0);
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E18(Consumer P_0)
		{
			base.forEach(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>19|size", "()I")]
		public new int size()
		{
			return ((Maps.KeySet)this).size();
		}

		[HideFromJava]
		protected internal int _003Cnonvirtual_003E19()
		{
			return base.size();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>20|isEmpty", "()Z")]
		public new bool isEmpty()
		{
			return ((Maps.KeySet)this).isEmpty();
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E20()
		{
			return base.isEmpty();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>21|contains", "(Ljava.lang.Object;)Z")]
		public new bool contains(object P_0)
		{
			return ((Maps.KeySet)this).contains(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E21(object P_0)
		{
			return base.contains(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>22|remove", "(Ljava.lang.Object;)Z")]
		public new bool remove(object P_0)
		{
			return ((Maps.KeySet)this).remove(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E22(object P_0)
		{
			return base.remove(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>23|clear", "()V")]
		public new void clear()
		{
			((Maps.KeySet)this).clear();
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E23()
		{
			base.clear();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>24|removeAll", "(Ljava.util.Collection;)Z")]
		public new bool removeAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).removeAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E24(Collection P_0)
		{
			return base.removeAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>25|retainAll", "(Ljava.util.Collection;)Z")]
		public new bool retainAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).retainAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E25(Collection P_0)
		{
			return base.retainAll(P_0);
		}
	}

	[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
	protected internal new abstract NavigableMap @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
	[LineNumberTable(415)]
	public virtual NavigableMap headMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toKey, bool inclusive)
	{
		NavigableMap result = @delegate().headMap(toKey, inclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(72)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry lowerEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		Map.Entry result = @delegate().lowerEntry(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(104)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry floorEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		Map.Entry result = @delegate().floorEntry(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
	[LineNumberTable(420)]
	public virtual NavigableMap tailMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromKey, bool inclusive)
	{
		NavigableMap result = @delegate().tailMap(fromKey, inclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(136)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry ceilingEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		Map.Entry result = @delegate().ceilingEntry(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(168)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry higherEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		Map.Entry result = @delegate().higherEntry(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(200)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry firstEntry()
	{
		Map.Entry result = @delegate().firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
	[LineNumberTable(290)]
	public virtual NavigableMap descendingMap()
	{
		NavigableMap result = @delegate().descendingMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(230)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry lastEntry()
	{
		Map.Entry result = @delegate().lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;ZTK;Z)Ljava/util/NavigableMap<TK;TV;>;")]
	[LineNumberTable(410)]
	public virtual NavigableMap subMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromKey, bool fromInclusive, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toKey, bool toInclusive)
	{
		NavigableMap result = @delegate().subMap(fromKey, fromInclusive, toKey, toInclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(64)]
	protected internal ForwardingNavigableMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(82)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Map.Entry standardLowerEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		Map.Entry result = headMap(key, inclusive: false).lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(88)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object lowerKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		object result = @delegate().lowerKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(98)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardLowerKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		object result = Maps.keyOrNull(lowerEntry(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(114)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Map.Entry standardFloorEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		Map.Entry result = headMap(key, inclusive: true).lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(120)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object floorKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		object result = @delegate().floorKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(130)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardFloorKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		object result = Maps.keyOrNull(floorEntry(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(146)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Map.Entry standardCeilingEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		Map.Entry result = tailMap(key, inclusive: true).firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(152)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object ceilingKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		object result = @delegate().ceilingKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(162)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardCeilingKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		object result = Maps.keyOrNull(ceilingEntry(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(178)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Map.Entry standardHigherEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		Map.Entry result = tailMap(key, inclusive: false).firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(184)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object higherKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		object result = @delegate().higherKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(194)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardHigherKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		object result = Maps.keyOrNull(higherEntry(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(210)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Map.Entry standardFirstEntry()
	{
		return (Map.Entry)Iterables.getFirst(entrySet(), null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(new byte[] { 160, 105, 103, 99, 139 })]
	protected internal virtual object standardFirstKey()
	{
		Map.Entry entry = firstEntry();
		if (entry == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object key = entry.getKey();
		_ = null;
		return key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(240)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Map.Entry standardLastEntry()
	{
		return (Map.Entry)Iterables.getFirst(descendingMap().entrySet(), null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(new byte[] { 160, 134, 103, 99, 139 })]
	protected internal virtual object standardLastKey()
	{
		Map.Entry entry = lastEntry();
		if (entry == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object key = entry.getKey();
		_ = null;
		return key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(259)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry pollFirstEntry()
	{
		Map.Entry result = @delegate().pollFirstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(269)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Map.Entry standardPollFirstEntry()
	{
		return (Map.Entry)Iterators.pollNext(entrySet().iterator());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(275)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry pollLastEntry()
	{
		Map.Entry result = @delegate().pollLastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(285)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual Map.Entry standardPollLastEntry()
	{
		return (Map.Entry)Iterators.pollNext(descendingMap().entrySet().iterator());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TK;>;")]
	[LineNumberTable(357)]
	public virtual NavigableSet navigableKeySet()
	{
		NavigableSet result = @delegate().navigableKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TK;>;")]
	[LineNumberTable(378)]
	public virtual NavigableSet descendingKeySet()
	{
		NavigableSet result = @delegate().descendingKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TK;>;")]
	[LineNumberTable(390)]
	protected internal virtual NavigableSet standardDescendingKeySet()
	{
		NavigableSet result = descendingMap().navigableKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(401)]
	protected internal override SortedMap standardSubMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromKey, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toKey)
	{
		NavigableMap result = subMap(fromKey, fromInclusive: true, toKey, toInclusive: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(429)]
	protected internal virtual SortedMap standardHeadMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object toKey)
	{
		NavigableMap result = headMap(toKey, inclusive: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(438)]
	protected internal virtual SortedMap standardTailMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object fromKey)
	{
		NavigableMap result = tailMap(fromKey, inclusive: true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(58)]
	protected internal new virtual SortedMap _003Cbridge_003Edelegate()
	{
		NavigableMap result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(58)]
	protected internal override Map _003Cbridge_003Edelegate()
	{
		NavigableMap result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(58)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		NavigableMap result = @delegate();
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
	public override object computeIfAbsent(object P_0, Function P_1)
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
