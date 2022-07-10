using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingObject;Ljava/util/Map<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 126, 0, 0,
	17, 1, 0, 0, 0, 126, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)126,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Map" })]
public abstract class ForwardingMap : ForwardingObject, Map
{
	[InnerClass(null, Modifiers.Protected | Modifiers.Abstract)]
	[Signature("Lcom/google/common/collect/Maps$EntrySet<TK;TV;>;")]
	public abstract class StandardEntrySet : Maps.EntrySet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ForwardingMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(261)]
		public StandardEntrySet(ForwardingMap this_00240)
		{
			this.this_00240 = this_00240;
			base._002Ector();
		}

		[Signature("()Ljava/util/Map<TK;TV;>;")]
		internal override Map map()
		{
			return this_00240;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|size", "()I")]
		public new int size()
		{
			return ((Maps.EntrySet)this).size();
		}

		[HideFromJava]
		protected internal int _003Cnonvirtual_003E0()
		{
			return base.size();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|clear", "()V")]
		public new void clear()
		{
			((Maps.EntrySet)this).clear();
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E1()
		{
			base.clear();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|contains", "(Ljava.lang.Object;)Z")]
		public new bool contains(object P_0)
		{
			return ((Maps.EntrySet)this).contains(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E2(object P_0)
		{
			return base.contains(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|isEmpty", "()Z")]
		public new bool isEmpty()
		{
			return ((Maps.EntrySet)this).isEmpty();
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E3()
		{
			return base.isEmpty();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|remove", "(Ljava.lang.Object;)Z")]
		public new bool remove(object P_0)
		{
			return ((Maps.EntrySet)this).remove(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E4(object P_0)
		{
			return base.remove(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|removeAll", "(Ljava.util.Collection;)Z")]
		public new bool removeAll(Collection P_0)
		{
			return ((Maps.EntrySet)this).removeAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E5(Collection P_0)
		{
			return base.removeAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|retainAll", "(Ljava.util.Collection;)Z")]
		public new bool retainAll(Collection P_0)
		{
			return ((Maps.EntrySet)this).retainAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E6(Collection P_0)
		{
			return base.retainAll(P_0);
		}
	}

	[InnerClass(null, Modifiers.Protected)]
	[Signature("Lcom/google/common/collect/Maps$KeySet<TK;TV;>;")]
	public class StandardKeySet : Maps.KeySet
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 91, 105 })]
		public StandardKeySet(ForwardingMap this_00240)
			: base(this_00240)
		{
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|iterator", "()Ljava.util.Iterator;")]
		public new Iterator iterator()
		{
			return ((Maps.KeySet)this).iterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E0()
		{
			return base.iterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|forEach", "(Ljava.util.function.Consumer;)V")]
		public new void forEach(Consumer P_0)
		{
			((Maps.KeySet)this).forEach(P_0);
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E1(Consumer P_0)
		{
			base.forEach(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|size", "()I")]
		public new int size()
		{
			return ((Maps.KeySet)this).size();
		}

		[HideFromJava]
		protected internal int _003Cnonvirtual_003E2()
		{
			return base.size();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|isEmpty", "()Z")]
		public new bool isEmpty()
		{
			return ((Maps.KeySet)this).isEmpty();
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E3()
		{
			return base.isEmpty();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|contains", "(Ljava.lang.Object;)Z")]
		public new bool contains(object P_0)
		{
			return ((Maps.KeySet)this).contains(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E4(object P_0)
		{
			return base.contains(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|remove", "(Ljava.lang.Object;)Z")]
		public new bool remove(object P_0)
		{
			return ((Maps.KeySet)this).remove(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E5(object P_0)
		{
			return base.remove(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|clear", "()V")]
		public new void clear()
		{
			((Maps.KeySet)this).clear();
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E6()
		{
			base.clear();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|removeAll", "(Ljava.util.Collection;)Z")]
		public new bool removeAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).removeAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E7(Collection P_0)
		{
			return base.removeAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>8|retainAll", "(Ljava.util.Collection;)Z")]
		public new bool retainAll(Collection P_0)
		{
			return ((Sets.ImprovedAbstractSet)this).retainAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E8(Collection P_0)
		{
			return base.retainAll(P_0);
		}
	}

	[InnerClass(null, Modifiers.Protected)]
	[Signature("Lcom/google/common/collect/Maps$Values<TK;TV;>;")]
	public class StandardValues : Maps.Values
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 120, 105 })]
		public StandardValues(ForwardingMap this_00240)
			: base(this_00240)
		{
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>0|iterator", "()Ljava.util.Iterator;")]
		public new Iterator iterator()
		{
			return ((Maps.Values)this).iterator();
		}

		[HideFromJava]
		protected internal Iterator _003Cnonvirtual_003E0()
		{
			return base.iterator();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>1|forEach", "(Ljava.util.function.Consumer;)V")]
		public new void forEach(Consumer P_0)
		{
			((Maps.Values)this).forEach(P_0);
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E1(Consumer P_0)
		{
			base.forEach(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>2|remove", "(Ljava.lang.Object;)Z")]
		public new bool remove(object P_0)
		{
			return ((Maps.Values)this).remove(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E2(object P_0)
		{
			return base.remove(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>3|removeAll", "(Ljava.util.Collection;)Z")]
		public new bool removeAll(Collection P_0)
		{
			return ((Maps.Values)this).removeAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E3(Collection P_0)
		{
			return base.removeAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>4|retainAll", "(Ljava.util.Collection;)Z")]
		public new bool retainAll(Collection P_0)
		{
			return ((Maps.Values)this).retainAll(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E4(Collection P_0)
		{
			return base.retainAll(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>5|size", "()I")]
		public new int size()
		{
			return ((Maps.Values)this).size();
		}

		[HideFromJava]
		protected internal int _003Cnonvirtual_003E5()
		{
			return base.size();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>6|isEmpty", "()Z")]
		public new bool isEmpty()
		{
			return ((Maps.Values)this).isEmpty();
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E6()
		{
			return base.isEmpty();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>7|contains", "(Ljava.lang.Object;)Z")]
		public new bool contains(object P_0)
		{
			return ((Maps.Values)this).contains(P_0);
		}

		[HideFromJava]
		protected internal bool _003Cnonvirtual_003E7(object P_0)
		{
			return base.contains(P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		[NameSig("<accessstub>8|clear", "()V")]
		public new void clear()
		{
			((Maps.Values)this).clear();
		}

		[HideFromJava]
		protected internal void _003Cnonvirtual_003E8()
		{
			base.clear();
		}
	}

	[Signature("()Ljava/util/Map<TK;TV;>;")]
	protected internal new abstract Map @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(132)]
	public virtual Set entrySet()
	{
		Set result = @delegate().entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	protected internal ForwardingMap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(72)]
	public virtual int size()
	{
		int result = @delegate().size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(77)]
	public virtual bool isEmpty()
	{
		bool result = @delegate().isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(84)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		object result = @delegate().remove(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 39, 109 })]
	public virtual void clear()
	{
		@delegate().clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(94)]
	public virtual bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		bool result = @delegate().containsKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(99)]
	public virtual bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		bool result = @delegate().containsValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(105)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		object result = @delegate().get(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(112)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		object result = @delegate().put(key, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 67, 110 })]
	public virtual void putAll(Map map)
	{
		@delegate().putAll(map);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(122)]
	public virtual Set keySet()
	{
		Set result = @delegate().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(127)]
	public virtual Collection values()
	{
		Collection result = @delegate().values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(137)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		return (@object == this || @delegate().equals(@object)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(142)]
	public override int hashCode()
	{
		int result = @delegate().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 103, 105 })]
	protected internal virtual void standardPutAll(Map map)
	{
		Maps.putAllImpl(this, map);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 119, 108, 104, 108, 110, 103, 102, 130, 98 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardRemove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		Iterator iterator = entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			if (com.google.common.@base.Objects.equal(entry.getKey(), key))
			{
				object value = entry.getValue();
				iterator.remove();
				return value;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 75, 114 })]
	protected internal virtual void standardClear()
	{
		Iterators.clear(entrySet().iterator());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(218)]
	protected internal virtual bool standardContainsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		bool result = Maps.containsKeyImpl(this, key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(246)]
	protected internal virtual bool standardContainsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		bool result = Maps.containsValueImpl(this, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(277)]
	protected internal virtual bool standardIsEmpty()
	{
		return (!entrySet().iterator().hasNext()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(288)]
	protected internal virtual bool standardEquals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		bool result = Maps.equalsImpl(this, @object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(299)]
	protected internal virtual int standardHashCode()
	{
		int result = Sets.hashCodeImpl(entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(310)]
	protected internal virtual string standardToString()
	{
		string result = Maps.toStringImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(58)]
	protected internal virtual object _003Cbridge_003Edelegate()
	{
		Map result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object putIfAbsent(object P_0, object P_1)
	{
		return Map._003Cdefault_003EputIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object getOrDefault(object P_0, object P_1)
	{
		return Map._003Cdefault_003EgetOrDefault(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(BiConsumer P_0)
	{
		Map._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void replaceAll(BiFunction P_0)
	{
		Map._003Cdefault_003EreplaceAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool remove(object P_0, object P_1)
	{
		return Map._003Cdefault_003Eremove(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool replace(object P_0, object P_1, object P_2)
	{
		return Map._003Cdefault_003Ereplace(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object replace(object P_0, object P_1)
	{
		return Map._003Cdefault_003Ereplace(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object computeIfAbsent(object P_0, java.util.function.Function P_1)
	{
		return Map._003Cdefault_003EcomputeIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object computeIfPresent(object P_0, BiFunction P_1)
	{
		return Map._003Cdefault_003EcomputeIfPresent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object compute(object P_0, BiFunction P_1)
	{
		return Map._003Cdefault_003Ecompute(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object merge(object P_0, object P_1, BiFunction P_2)
	{
		return Map._003Cdefault_003Emerge(this, P_0, P_1, P_2);
	}
}
