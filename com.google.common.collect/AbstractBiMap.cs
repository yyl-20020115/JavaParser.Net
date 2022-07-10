using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMap<TK;TV;>;Lcom/google/common/collect/BiMap<TK;TV;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 223, 0, 0,
	17, 1, 0, 0, 0, 223, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)223,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.BiMap", "java.io.Serializable" })]
internal abstract class AbstractBiMap : ForwardingMap, BiMap, Map, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "entrySetIterator", "()Ljava.util.Iterator;")]
	internal class _1 : java.lang.Object, Iterator
	{
		[Signature("Ljava/util/Map$Entry<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Map.Entry entry;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024iterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 251, 118 })]
		public virtual Map.Entry next()
		{
			entry = (Map.Entry)val_0024iterator.next();
			BiMapEntry result = new BiMapEntry(this_00240, entry);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(355)]
		internal _1(AbstractBiMap P_0, Iterator P_1)
		{
			this_00240 = P_0;
			val_0024iterator = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(360)]
		public virtual bool hasNext()
		{
			bool result = val_0024iterator.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 1, 104, 144, 108, 107, 108, 103 })]
		public virtual void remove()
		{
			if (entry == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("no calls to next() since the last call to remove()");
			}
			object value = entry.getValue();
			val_0024iterator.remove();
			access_0024600(this_00240, value);
			entry = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(355)]
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

	[Signature("Lcom/google/common/collect/ForwardingMapEntry<TK;TV;>;")]
	internal class BiMapEntry : ForwardingMapEntry
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Map$Entry<TK;TV;>;")]
		private new Map.Entry m_delegate;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 213, 111, 103 })]
		internal BiMapEntry(AbstractBiMap P_0, Map.Entry P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			this.m_delegate = P_1;
		}

		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		protected internal override Map.Entry @delegate()
		{
			return this.m_delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(new byte[]
		{
			160, 224, 141, 155, 110, 130, 125, 109, 127, 2,
			116
		})]
		public override object setValue(object P_0)
		{
			this_00240.checkValue(P_0);
			Preconditions.checkState(this_00240.entrySet().contains(this), (object)"entry no longer in map");
			if (com.google.common.@base.Objects.equal(P_0, getValue()))
			{
				return P_0;
			}
			Preconditions.checkArgument((!this_00240.containsValue(P_0)) ? true : false, "value already present: %s", P_0);
			object obj = this.m_delegate.setValue(P_0);
			Preconditions.checkState(com.google.common.@base.Objects.equal(P_0, this_00240.get(getKey())), (object)"entry no longer in map");
			access_0024500(this_00240, getKey(), true, obj, P_0);
			return obj;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(324)]
		protected internal new virtual object @delegate()
		{
			Map.Entry result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/ForwardingSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[ConstantPool(new object[]
	{
		(byte)69,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class EntrySet : ForwardingSet
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		internal Set esDelegate;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(383)]
		internal EntrySet(AbstractBiMap P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 13, 111 })]
		private EntrySet(AbstractBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			esDelegate = access_0024100(this_00240).entrySet();
		}

		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
		protected internal override Set @delegate()
		{
			return esDelegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 23, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 32, 118, 162, 103, 252, 70, 109 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (!esDelegate.contains(P_0) || !(P_0 is Map.Entry))
			{
				return false;
			}
			Map.Entry entry = (Map.Entry)P_0;
			access_0024100(this_00240.inverse).remove(entry.getValue());
			esDelegate.remove(entry);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(419)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.entrySetIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 62, 103 })]
		public override object[] toArray()
		{
			return standardToArray();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 69, 0, 0 })]
		[LineNumberTable(439)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = standardToArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(444)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = Maps.containsEntryImpl(this.@delegate(), P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(449)]
		public override bool containsAll(Collection P_0)
		{
			bool result = standardContainsAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(454)]
		public override bool removeAll(Collection P_0)
		{
			bool result = standardRemoveAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(459)]
		public override bool retainAll(Collection P_0)
		{
			bool result = standardRetainAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(382)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(382)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractBiMap<TK;TV;>;")]
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
	internal class Inverse : AbstractBiMap, IObjectReference
	{
		private new const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<TK;TV;>;Lcom/google/common/collect/AbstractBiMap<TV;TK;>;)V")]
		[LineNumberTable(new byte[] { 161, 97, 107 })]
		internal Inverse(Map P_0, AbstractBiMap P_1)
			: base(P_0, P_1, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TK;")]
		[LineNumberTable(482)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object checkKey([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = base.inverse.checkValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;)TV;")]
		[LineNumberTable(488)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object checkValue([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = base.inverse.checkKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[] { 161, 124, 102, 110 })]
		private void writeObject(ObjectOutputStream P_0)
		{
			P_0.defaultWriteObject();
			P_0.writeObject(inverse());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
		[LineNumberTable(new byte[] { 161, 131, 102, 115 })]
		private void readObject(ObjectInputStream P_0)
		{
			P_0.defaultReadObject();
			setInverse((AbstractBiMap)P_0.readObject());
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(507)]
		internal virtual object readResolve()
		{
			BiMap result = inverse().inverse();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(464)]
		public override Collection values()
		{
			Set result = base.values();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(464)]
		protected internal override object @delegate()
		{
			Map result = base.@delegate();
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Inverse(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(Inverse))
			{
				return this;
			}
			return readResolve();
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/ForwardingSet<TK;>;")]
	internal class KeySet : ForwardingSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(237)]
		internal KeySet(AbstractBiMap P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(237)]
		private KeySet(AbstractBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(240)]
		protected internal override Set @delegate()
		{
			Set result = access_0024100(this_00240).keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 131, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 136, 105, 130, 109 })]
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
			access_0024200(this_00240, P_0);
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(259)]
		public override bool removeAll(Collection P_0)
		{
			bool result = standardRemoveAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(264)]
		public override bool retainAll(Collection P_0)
		{
			bool result = standardRetainAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TK;>;")]
		[LineNumberTable(269)]
		public override Iterator iterator()
		{
			Iterator result = Maps.keyIterator(this_00240.entrySet().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(236)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(236)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/ForwardingSet<TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)42,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ValueSet : ForwardingSet
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Set<TV;>;")]
		internal Set valuesDelegate;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(286)]
		internal ValueSet(AbstractBiMap P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 172, 111 })]
		private ValueSet(AbstractBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			valuesDelegate = this_00240.inverse.keySet();
		}

		[Signature("()Ljava/util/Set<TV;>;")]
		protected internal override Set @delegate()
		{
			return valuesDelegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(296)]
		public override Iterator iterator()
		{
			Iterator result = Maps.valueIterator(this_00240.entrySet().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 42, 0, 0 })]
		[LineNumberTable(301)]
		public override object[] toArray()
		{
			object[] result = standardToArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 42, 0, 0 })]
		[LineNumberTable(307)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = standardToArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(312)]
		public override string toString()
		{
			string result = standardToString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(285)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(285)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[NonSerialized]
	[Signature("Ljava/util/Map<TK;TV;>;")]
	private new Map m_delegate;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/AbstractBiMap<TV;TK;>;")]
	internal AbstractBiMap inverse;

	[NonSerialized]
	[Signature("Ljava/util/Set<TK;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Set m_keySet;

	[NonSerialized]
	[Signature("Ljava/util/Set<TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Set valueSet;

	[NonSerialized]
	[Signature("Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Set m_entrySet;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static void access_0024600(AbstractBiMap P_0, object P_1)
	{
		P_0.removeFromInverseMap(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;TV;>;Lcom/google/common/collect/AbstractBiMap<TV;TK;>;)V")]
	[LineNumberTable(new byte[] { 14, 104, 103, 103 })]
	private AbstractBiMap(Map P_0, AbstractBiMap P_1)
	{
		this.m_delegate = P_0;
		this.inverse = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TV;)V")]
	[LineNumberTable(new byte[] { 160, 66, 114 })]
	private void removeFromInverseMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		this.inverse.m_delegate.remove(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;ZTV;TV;)V")]
	[LineNumberTable(new byte[] { 159, 103, 66, 131, 140, 116 })]
	private void updateInverseMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, bool P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_3)
	{
		if (P_1)
		{
			removeFromInverseMap(NullnessCasts.uncheckedCastNullableTToT(P_2));
		}
		this.inverse.m_delegate.put(P_3, P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 124, 114, 103 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	private object removeFromBothMaps([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		object obj = NullnessCasts.uncheckedCastNullableTToT(this.m_delegate.remove(P_0));
		removeFromInverseMap(obj);
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;TV;>;Ljava/util/Map<TV;TK;>;)V")]
	[LineNumberTable(new byte[] { 43, 113, 113, 107, 107, 108, 103, 109 })]
	internal virtual void setDelegates(Map P_0, Map P_1)
	{
		Preconditions.checkState(this.m_delegate == null);
		Preconditions.checkState(this.inverse == null);
		Preconditions.checkArgument(P_0.isEmpty());
		Preconditions.checkArgument(P_1.isEmpty());
		Preconditions.checkArgument(P_0 != P_1);
		this.m_delegate = P_0;
		this.inverse = makeInverse(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TV;TK;>;)Lcom/google/common/collect/AbstractBiMap<TV;TK;>;")]
	[LineNumberTable(103)]
	internal virtual AbstractBiMap makeInverse(Map P_0)
	{
		Inverse result = new Inverse(P_0, this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;Z)TV;")]
	[LineNumberTable(new byte[]
	{
		159, 109, 162, 104, 104, 104, 114, 130, 99, 143,
		152, 110, 106
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object putInBothMaps([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, bool P_2)
	{
		checkKey(P_0);
		checkValue(P_1);
		int num = (containsKey(P_0) ? 1 : 0);
		if (num != 0 && com.google.common.@base.Objects.equal(P_1, get(P_0)))
		{
			return P_1;
		}
		if (P_2)
		{
			inverse().remove(P_1);
		}
		else
		{
			Preconditions.checkArgument((!containsValue(P_1)) ? true : false, "value already present: %s", P_1);
		}
		object obj = this.m_delegate.put(P_0, P_1);
		updateInverseMap(P_0, (byte)num != 0, obj, P_1);
		return obj;
	}

	[Signature("(TK;)TK;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	internal virtual object checkKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		return P_0;
	}

	[Signature("(TV;)TV;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	internal virtual object checkValue([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		return P_0;
	}

	[Signature("()Lcom/google/common/collect/BiMap<TV;TK;>;")]
	public virtual BiMap inverse()
	{
		return this.inverse;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(114)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = this.inverse.containsKey(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(123)]
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
		object result = putInBothMaps(P_0, P_1, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TV;>;")]
	[LineNumberTable(new byte[] { 160, 167, 103 })]
	public new virtual Set values()
	{
		Set set = this.valueSet;
		object set2;
		if (set == null)
		{
			ValueSet valueSet = new ValueSet(this, null);
			set2 = valueSet;
			this.valueSet = valueSet;
		}
		else
		{
			set2 = set;
		}
		return (set2 == null) ? null : ((set2 as Set) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[Signature("()Ljava/util/Map<TK;TV;>;")]
	protected internal override Map @delegate()
	{
		return this.m_delegate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;TV;>;Ljava/util/Map<TV;TK;>;)V")]
	[LineNumberTable(new byte[] { 9, 104, 106 })]
	internal AbstractBiMap(Map P_0, Map P_1)
	{
		setDelegates(P_0, P_1);
	}

	[Signature("(Lcom/google/common/collect/AbstractBiMap<TV;TK;>;)V")]
	internal virtual void setInverse(AbstractBiMap P_0)
	{
		this.inverse = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)TV;")]
	[LineNumberTable(130)]
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
		object result = putInBothMaps(P_0, P_1, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(167)]
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
		return (!containsKey(P_0)) ? null : removeFromBothMaps(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<+TK;+TV;>;)V")]
	[LineNumberTable(new byte[] { 160, 73, 127, 1, 115, 98 })]
	public override void putAll(Map P_0)
	{
		Iterator iterator = P_0.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			put(entry.getKey(), entry.getValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiFunction<-TK;-TV;+TV;>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 80, 108, 112, 98, 113, 104, 108, 103, 104,
		117, 100, 162, 134, 98, 99, 159, 43
	})]
	public override void replaceAll(BiFunction P_0)
	{
		this.m_delegate.replaceAll(P_0);
		this.inverse.m_delegate.clear();
		Map.Entry entry = null;
		Iterator iterator = this.m_delegate.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry2 = (Map.Entry)iterator.next();
			object key = entry2.getKey();
			object value = entry2.getValue();
			object obj = this.inverse.m_delegate.putIfAbsent(value, key);
			if (obj != null)
			{
				entry = entry2;
				iterator.remove();
			}
		}
		if (entry != null)
		{
			string text = java.lang.String.valueOf(entry.getValue());
			int num = 23 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("value already present: ").append(text).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 103, 107, 114 })]
	public override void clear()
	{
		this.m_delegate.clear();
		this.inverse.m_delegate.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(new byte[] { 160, 118, 103 })]
	public override Set keySet()
	{
		Set set = this.m_keySet;
		object set2;
		if (set == null)
		{
			KeySet keySet = new KeySet(this, null);
			set2 = keySet;
			this.m_keySet = keySet;
		}
		else
		{
			set2 = set;
		}
		return (set2 == null) ? null : ((set2 as Set) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 160, 206, 103 })]
	public override Set entrySet()
	{
		Set set = this.m_entrySet;
		object set2;
		if (set == null)
		{
			EntrySet entrySet = new EntrySet(this, null);
			set2 = entrySet;
			this.m_entrySet = entrySet;
		}
		else
		{
			set2 = set;
		}
		return (set2 == null) ? null : ((set2 as Set) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 160, 240, 113 })]
	internal virtual Iterator entrySetIterator()
	{
		Iterator iterator = this.m_delegate.entrySet().iterator();
		_1 result = new _1(this, iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(50)]
	public override Collection values()
	{
		Set result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(50)]
	protected internal new virtual object @delegate()
	{
		Map result = this.@delegate();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static Map access_0024100(AbstractBiMap P_0)
	{
		return P_0.m_delegate;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static object access_0024200(AbstractBiMap P_0, object P_1)
	{
		object result = P_0.removeFromBothMaps(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal static void access_0024500(AbstractBiMap P_0, object P_1, bool P_2, object P_3, object P_4)
	{
		P_0.updateInverseMap(P_1, P_2, P_3, P_4);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(52)]
	internal AbstractBiMap(Map P_0, AbstractBiMap P_1, _1 P_2)
		: this(P_0, P_1)
	{
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
	protected AbstractBiMap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
