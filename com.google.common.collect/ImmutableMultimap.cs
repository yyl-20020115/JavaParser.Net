using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/BaseImmutableMultimap<TK;TV;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public abstract class ImmutableMultimap : BaseImmutableMultimap, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _1 : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Iterator<+Ljava/util/Map$Entry<TK;+Lcom/google/common/collect/ImmutableCollection<TV;>;>;>;")]
		internal Iterator asMapItr;

		[Signature("TK;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object currentKey;

		[Signature("Ljava/util/Iterator<TV;>;")]
		internal Iterator valueItr;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 215, 111, 108, 111, 103 })]
		internal _1(ImmutableMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			asMapItr = this_00240.map.entrySet().iterator();
			currentKey = null;
			valueItr = Iterators.emptyIterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 228, 109, 113, 108, 246, 70 })]
		public new virtual Map.Entry next()
		{
			if (!valueItr.hasNext())
			{
				Map.Entry entry = (Map.Entry)asMapItr.next();
				currentKey = entry.getKey();
				valueItr = ((ImmutableCollection)entry.getValue()).iterator();
			}
			Map.Entry result = Maps.immutableEntry(java.util.Objects.requireNonNull(currentKey), valueItr.next());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(593)]
		public override bool hasNext()
		{
			return (valueItr.hasNext() || asMapItr.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(585)]
		public override object next()
		{
			Map.Entry result = next();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TV;>;")]
	[EnclosingMethod(null, "valueIterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _2 : UnmodifiableIterator
	{
		[Signature("Ljava/util/Iterator<+Lcom/google/common/collect/ImmutableCollection<TV;>;>;")]
		internal Iterator valueCollectionItr;

		[Signature("Ljava/util/Iterator<TV;>;")]
		internal Iterator valueItr;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 94, 111, 123 })]
		internal _2(ImmutableMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			valueCollectionItr = this_00240.map.values().iterator();
			valueItr = Iterators.emptyIterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(726)]
		public override bool hasNext()
		{
			return (valueItr.hasNext() || valueCollectionItr.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(new byte[] { 162, 105, 109, 155 })]
		public override object next()
		{
			if (!valueItr.hasNext())
			{
				valueItr = ((ImmutableCollection)valueCollectionItr.next()).iterator();
			}
			object result = valueItr.next();
			_ = null;
			return result;
		}
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[DoNotMock(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/DoNotMock;"
	})]
	public class Builder : java.lang.Object
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		internal Map builderMap;

		[Signature("Ljava/util/Comparator<-TK;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Comparator keyComparator;

		[Signature("Ljava/util/Comparator<-TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Comparator valueComparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 110, 104, 107 })]
		public Builder()
		{
			builderMap = Platform.preservesInsertionOrderOnPutsMap();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(165)]
		internal virtual Collection newMutableValueCollection()
		{
			ArrayList result = new ArrayList();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 121, 103, 114, 99, 149, 104 })]
		public virtual Builder put(object key, object value)
		{
			CollectPreconditions.checkEntryNotNull(key, value);
			Collection collection = (Collection)builderMap.get(key);
			if (collection == null)
			{
				builderMap.put(key, collection = newMutableValueCollection());
			}
			collection.add(value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<+TK;+TV;>;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(187)]
		public virtual Builder put(Map.Entry entry)
		{
			Builder result = put(entry.getKey(), entry.getValue());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[]
		{
			160, 98, 99, 159, 21, 114, 99, 118, 103, 104,
			98, 130, 103, 104, 130, 103, 104, 103, 103, 104,
			98, 110
		})]
		public virtual Builder putAll(object key, Iterable values)
		{
			if (key == null)
			{
				string text = java.lang.String.valueOf(Iterables.toString(values));
				string s;
				if (java.lang.String.instancehelper_length(text) != 0)
				{
					s = java.lang.String.instancehelper_concat("null key in entry: null=", text);
				}
				else
				{
					string text2 = "null key in entry: null=";
					text2 = text2;
					s = java.lang.String.newhelper(text2);
				}
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NullPointerException(s);
			}
			Collection collection = (Collection)builderMap.get(key);
			Iterator iterator;
			if (collection != null)
			{
				iterator = values.iterator();
				while (iterator.hasNext())
				{
					object obj = iterator.next();
					CollectPreconditions.checkEntryNotNull(key, obj);
					collection.add(obj);
				}
				return this;
			}
			iterator = values.iterator();
			if (!iterator.hasNext())
			{
				return this;
			}
			collection = newMutableValueCollection();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				CollectPreconditions.checkEntryNotNull(key, obj);
				collection.add(obj);
			}
			builderMap.put(key, collection);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 84, 123, 104, 98 })]
		public virtual Builder putAll(Iterable entries)
		{
			Iterator iterator = entries.iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				put(entry);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;[TV;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(245)]
		public virtual Builder putAll(object key, params object[] values)
		{
			Builder result = putAll(key, Arrays.asList(values));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 145, 127, 6, 120, 98 })]
		public virtual Builder putAll(Multimap multimap)
		{
			Iterator iterator = multimap.asMap().entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				putAll(entry.getKey(), (Iterable)entry.getValue());
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TK;>;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 158, 113 })]
		public virtual Builder orderKeysBy(Comparator keyComparator)
		{
			this.keyComparator = (Comparator)Preconditions.checkNotNull(keyComparator);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TV;>;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 169, 113 })]
		public virtual Builder orderValuesBy(Comparator valueComparator)
		{
			this.valueComparator = (Comparator)Preconditions.checkNotNull(valueComparator);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;)Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 175, 127, 6, 120, 98 })]
		internal virtual Builder combine(Builder P_0)
		{
			Iterator iterator = P_0.builderMap.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				putAll(entry.getKey(), (Iterable)entry.getValue());
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 183, 108, 104, 156 })]
		public virtual ImmutableMultimap build()
		{
			object obj = builderMap.entrySet();
			if (keyComparator != null)
			{
				obj = Ordering.from(keyComparator).onKeys().immutableSortedCopy((Set)obj);
			}
			object obj2 = obj;
			Comparator comparator = valueComparator;
			ImmutableListMultimap result = ImmutableListMultimap.fromMapEntries((obj2 == null) ? null : ((obj2 as Collection) ?? throw new java.lang.IncompatibleClassChangeError()), comparator);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableCollection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal class EntryCollection : ImmutableCollection
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
		internal ImmutableMultimap multimap;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 182, 104, 103 })]
		internal EntryCollection(ImmutableMultimap P_0)
		{
			multimap = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(558)]
		public override UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = multimap.entryIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(563)]
		internal override bool isPartialView()
		{
			bool result = multimap.isPartialView();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(568)]
		public override int size()
		{
			int result = multimap.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 203, 104, 103, 154 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Map.Entry)
			{
				Map.Entry entry = (Map.Entry)P_0;
				bool result = multimap.containsEntry(entry.getKey(), entry.getValue());
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(549)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static EntryCollection()
		{
			ImmutableCollection.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected EntryCollection(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	internal class FieldSettersHolder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Serialization$FieldSetter<Lcom/google/common/collect/ImmutableMultimap;>;")]
		internal static Serialization.FieldSetter MAP_FIELD_SETTER;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Serialization$FieldSetter<Lcom/google/common/collect/ImmutableMultimap;>;")]
		internal static Serialization.FieldSetter SIZE_FIELD_SETTER;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(347)]
		internal FieldSettersHolder()
		{
		}

		[LineNumberTable(new byte[] { 160, 234, 106, 106, 106, 42 })]
		static FieldSettersHolder()
		{
			MAP_FIELD_SETTER = Serialization.getFieldSetter(ClassLiteral<ImmutableMultimap>.Value, "map");
			SIZE_FIELD_SETTER = Serialization.getFieldSetter(ClassLiteral<ImmutableMultimap>.Value, "size");
		}
	}

	[Serializable]
	[Signature("Lcom/google/common/collect/ImmutableMultiset<TK;>;")]
	internal class Keys : ImmutableMultiset
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(651)]
		internal Keys(ImmutableMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
		[LineNumberTable(665)]
		public override ImmutableSet elementSet()
		{
			ImmutableSet result = this_00240.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(654)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 33, 119 })]
		public override int count([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int result = ((Collection)this_00240.map.get(P_0))?.size() ?? 0;
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(670)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/Multiset$Entry<TK;>;")]
		[LineNumberTable(new byte[] { 162, 49, 127, 2 })]
		internal override Multiset.Entry getEntry(int P_0)
		{
			Map.Entry entry = (Map.Entry)this_00240.map.entrySet().asList().get(P_0);
			Multiset.Entry result = Multisets.immutableEntry(entry.getKey(), ((Collection)entry.getValue()).size());
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(687)]
		internal override object writeReplace()
		{
			KeysSerializedForm result = new KeysSerializedForm(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(649)]
		public new virtual Set elementSet()
		{
			ImmutableSet result = this.elementSet();
			_ = null;
			return result;
		}

		[HideFromJava]
		static Keys()
		{
			ImmutableMultiset.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Keys(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class KeysSerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMultimap<**>;")]
		internal ImmutableMultimap multimap;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMultimap<**>;)V")]
		[LineNumberTable(new byte[] { 162, 69, 104, 103 })]
		internal KeysSerializedForm(ImmutableMultimap P_0)
		{
			multimap = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(700)]
		internal virtual object readResolve()
		{
			ImmutableMultiset result = multimap.keys();
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
		protected KeysSerializedForm(SerializationInfo P_0, StreamingContext P_1)
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)60,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal new sealed class Values : ImmutableCollection
	{
		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
		private ImmutableMultimap multimap;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 116, 104, 103 })]
		internal Values(ImmutableMultimap P_0)
		{
			multimap = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TV;>;")]
		[LineNumberTable(753)]
		public override UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = multimap.valueIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(748)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = multimap.containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 0, 1, 0, 0, 0, 60, 0,
			0
		})]
		[LineNumberTable(new byte[] { 162, 133, 127, 11, 106, 98 })]
		internal override int copyIntoArray(object[] P_0, int P_1)
		{
			UnmodifiableIterator unmodifiableIterator = multimap.map.values().iterator();
			while (((Iterator)unmodifiableIterator).hasNext())
			{
				ImmutableCollection immutableCollection = (ImmutableCollection)((Iterator)unmodifiableIterator).next();
				P_1 = immutableCollection.copyIntoArray(P_0, P_1);
			}
			return P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(767)]
		public override int size()
		{
			int result = multimap.size();
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(739)]
		public new virtual Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static Values()
		{
			ImmutableCollection.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Values(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
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
	private sealed class ___003C_003EAnon1 : BiConsumer
	{
		private readonly BiConsumer arg_00241;

		internal ___003C_003EAnon1(BiConsumer P_0)
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
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly BiConsumer arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon2(BiConsumer P_0, object P_1)
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
	private sealed class ___003C_003EAnon3 : java.util.function.Function
	{
		private readonly object arg_00241;

		internal ___003C_003EAnon3(object P_0)
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
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TK;+Lcom/google/common/collect/ImmutableCollection<TV;>;>;")]
	internal ImmutableMap map;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	internal new int size;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(487)]
	internal virtual bool isPartialView()
	{
		bool result = map.isPartialView();
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableMap<TK;Ljava/util/Collection<TV;>;>;")]
	public new virtual ImmutableMap asMap()
	{
		return map;
	}

	public override int size()
	{
		return this.size;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TV;>;")]
	[LineNumberTable(720)]
	internal new virtual UnmodifiableIterator valueIterator()
	{
		_2 result = new _2(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(715)]
	internal new virtual ImmutableCollection createValues()
	{
		Values result = new Values(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(710)]
	public new virtual ImmutableCollection values()
	{
		return (ImmutableCollection)base.values();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMultiset<TK;>;")]
	[LineNumberTable(646)]
	internal new virtual ImmutableMultiset createKeys()
	{
		Keys result = new Keys(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMultiset<TK;>;")]
	[LineNumberTable(641)]
	public new virtual ImmutableMultiset keys()
	{
		return (ImmutableMultiset)base.keys();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	[LineNumberTable(515)]
	public new virtual ImmutableSet keySet()
	{
		ImmutableSet result = map.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(585)]
	internal new virtual UnmodifiableIterator entryIterator()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(546)]
	internal new virtual ImmutableCollection createEntries()
	{
		EntryCollection result = new EntryCollection(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(541)]
	public new virtual ImmutableCollection entries()
	{
		return (ImmutableCollection)base.entries();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(392)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual ImmutableCollection replaceValues(object key, Iterable values)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[Signature("(TK;)Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	public new abstract ImmutableCollection get(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Object;)Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(375)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new virtual ImmutableCollection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 161, 247, 103, 108, 97, 48 })]
	private static Spliterator lambda_0024entrySpliterator_00241(Map.Entry P_0)
	{
		object key = P_0.getKey();
		Collection collection = (Collection)P_0.getValue();
		Spliterator result = CollectSpliterators.map(collection.spliterator(), new ___003C_003EAnon3(key));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(631)]
	private static void lambda_0024forEach_00243(BiConsumer P_0, object P_1, Collection P_2)
	{
		P_2.forEach(new ___003C_003EAnon2(P_0, P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(631)]
	private static void lambda_0024forEach_00242(BiConsumer P_0, object P_1, object P_2)
	{
		P_0.accept(P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(620)]
	private static Map.Entry lambda_0024entrySpliterator_00240(object P_0, object P_1)
	{
		Map.Entry result = Maps.immutableEntry(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
	[LineNumberTable(83)]
	public static ImmutableMultimap of()
	{
		ImmutableListMultimap result = ImmutableListMultimap.of();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;)Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
	[LineNumberTable(88)]
	public static ImmutableMultimap of(object k1, object v1)
	{
		ImmutableListMultimap result = ImmutableListMultimap.of(k1, v1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
	[LineNumberTable(93)]
	public static ImmutableMultimap of(object k1, object v1, object k2, object v2)
	{
		ImmutableListMultimap result = ImmutableListMultimap.of(k1, v1, k2, v2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
	[LineNumberTable(101)]
	public static ImmutableMultimap of(object k1, object v1, object k2, object v2, object k3, object v3)
	{
		ImmutableListMultimap result = ImmutableListMultimap.of(k1, v1, k2, v2, k3, v3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
	[LineNumberTable(109)]
	public static ImmutableMultimap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4)
	{
		ImmutableListMultimap result = ImmutableListMultimap.of(k1, v1, k2, v2, k3, v3, k4, v4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(TK;TV;TK;TV;TK;TV;TK;TV;TK;TV;)Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
	[LineNumberTable(118)]
	public static ImmutableMultimap of(object k1, object v1, object k2, object v2, object k3, object v3, object k4, object v4, object k5, object v5)
	{
		ImmutableListMultimap result = ImmutableListMultimap.of(k1, v1, k2, v2, k3, v3, k4, v4, k5, v5);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableMultimap$Builder<TK;TV;>;")]
	[LineNumberTable(128)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 202, 136, 103, 104, 162 })]
	public static ImmutableMultimap copyOf(Multimap multimap)
	{
		if (multimap is ImmutableMultimap)
		{
			ImmutableMultimap immutableMultimap = (ImmutableMultimap)multimap;
			if (!immutableMultimap.isPartialView())
			{
				return immutableMultimap;
			}
		}
		ImmutableListMultimap result = ImmutableListMultimap.copyOf(multimap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Map$Entry<+TK;+TV;>;>;)Lcom/google/common/collect/ImmutableMultimap<TK;TV;>;")]
	[LineNumberTable(337)]
	public static ImmutableMultimap copyOf(Iterable entries)
	{
		ImmutableListMultimap result = ImmutableListMultimap.copyOf(entries);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableMap<TK;+Lcom/google/common/collect/ImmutableCollection<TV;>;>;I)V")]
	[LineNumberTable(new byte[] { 160, 240, 104, 103, 103 })]
	internal ImmutableMultimap(ImmutableMap P_0, int P_1)
	{
		map = P_0;
		this.size = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(405)]
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

	[Signature("()Lcom/google/common/collect/ImmutableMultimap<TV;TK;>;")]
	public abstract ImmutableMultimap inverse();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;TV;)Z")]
	[LineNumberTable(435)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool put(object key, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Z")]
	[LineNumberTable(449)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool putAll(object key, Iterable values)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Z")]
	[LineNumberTable(463)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool putAll(Multimap multimap)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(477)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(494)]
	public override bool containsKey([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object key)
	{
		bool result = map.containsKey(key);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(499)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		return (value != null && base.containsValue(value)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(520)]
	internal override Set createKeySet()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("unreachable");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(535)]
	internal override Map createAsMap()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 161, 244, 97, 251, 71, 110, 230, 55 })]
	internal override Spliterator entrySpliterator()
	{
		Spliterator result = CollectSpliterators.flatMap(asMap().entrySet().spliterator(), new ___003C_003EAnon0(), 0x40 | ((this is SetMultimap) ? 1 : 0), size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 162, 2, 103, 113, 135 })]
	public override void forEach(BiConsumer action)
	{
		Preconditions.checkNotNull(action);
		asMap().forEach(new ___003C_003EAnon1(action));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	public override int hashCode()
	{
		int result = base.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.equals(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(72)]
	public virtual Map _003Cbridge_003EasMap()
	{
		ImmutableMap result = asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	internal override Iterator valueIterator()
	{
		UnmodifiableIterator result = valueIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	internal override Collection createValues()
	{
		ImmutableCollection result = createValues();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(72)]
	public virtual Collection _003Cbridge_003Evalues()
	{
		ImmutableCollection result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	internal override Multiset createKeys()
	{
		ImmutableMultiset result = createKeys();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(72)]
	public virtual Multiset _003Cbridge_003Ekeys()
	{
		ImmutableMultiset result = keys();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(72)]
	public virtual Set _003Cbridge_003EkeySet()
	{
		ImmutableSet result = keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	internal override Iterator entryIterator()
	{
		UnmodifiableIterator result = entryIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	internal override Collection createEntries()
	{
		ImmutableCollection result = createEntries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(72)]
	public virtual Collection _003Cbridge_003Eentries()
	{
		ImmutableCollection result = entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(72)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual Collection _003Cbridge_003EreplaceValues(object obj, Iterable i)
	{
		ImmutableCollection result = replaceValues(obj, i);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	public override bool containsEntry([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2)
	{
		bool result = base.containsEntry(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(72)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(72)]
	public virtual Collection _003Cbridge_003Eget(object obj)
	{
		ImmutableCollection result = get(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(72)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual Collection _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		ImmutableCollection result = removeAll(obj);
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(ImmutableMultimap P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
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
	protected ImmutableMultimap(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
