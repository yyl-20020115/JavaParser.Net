using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMultisetGwtSerializationDependencies<TE;>;Lcom/google/common/collect/Multiset<TE;>;")]
[ConstantPool(new object[]
{
	(byte)90,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Multiset" })]
public abstract class ImmutableMultiset : ImmutableMultisetGwtSerializationDependencies, Multiset, Collection, Iterable, IEnumerable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[EnclosingMethod(null, "iterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _1 : UnmodifiableIterator
	{
		internal int remaining;

		[Signature("TE;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object element;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024entryIterator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(231)]
		internal _1(ImmutableMultiset P_0, Iterator P_1)
		{
			val_0024entryIterator = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(237)]
		public override bool hasNext()
		{
			return (remaining > 0 || val_0024entryIterator.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 160, 128, 105, 113, 108, 140, 238, 69 })]
		public override object next()
		{
			if (remaining <= 0)
			{
				Multiset.Entry entry = (Multiset.Entry)val_0024entryIterator.next();
				element = entry.getElement();
				remaining = entry.getCount();
			}
			remaining--;
			object result = java.util.Objects.requireNonNull(element);
			_ = null;
			return result;
		}
	}

	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableCollection$Builder<TE;>;")]
	public new class Builder : ImmutableCollection.Builder
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : ObjIntConsumer
		{
			private readonly Builder arg_00241;

			internal ___003C_003EAnon0(Builder P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0, int P_1)
			{
				arg_00241.lambda_0024addAll_00240(P_0, P_1);
				_ = null;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multiset<TE;>;")]
		internal Multiset contents;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 97, 109 })]
		public Builder()
			: this(LinkedHashMultiset.create())
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 114, 114 })]
		public new virtual Builder add(object element)
		{
			contents.add(Preconditions.checkNotNull(element));
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([TE;)Lcom/google/common/collect/ImmutableMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 128, 104 })]
		public new virtual Builder add(params object[] elements)
		{
			base.add(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
		[LineNumberTable(574)]
		public new virtual ImmutableMultiset build()
		{
			ImmutableMultiset result = copyOf(contents);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multiset<TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 100, 104, 103 })]
		internal Builder(Multiset P_0)
		{
			contents = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 194, 104 })]
		public new virtual Builder addAll(Iterator elements)
		{
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 175, 104, 103, 113, 98, 136 })]
		public new virtual Builder addAll(Iterable elements)
		{
			if (elements is Multiset)
			{
				Multiset multiset = Multisets.cast(elements);
				multiset.forEachEntry(new ___003C_003EAnon0(this));
			}
			else
			{
				base.addAll(elements);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(547)]
		private void lambda_0024addAll_00240(object P_0, int P_1)
		{
			contents.add(Preconditions.checkNotNull(P_0), P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)Lcom/google/common/collect/ImmutableMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 145, 115 })]
		public virtual Builder addCopies(object element, int occurrences)
		{
			contents.add(Preconditions.checkNotNull(element), occurrences);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)Lcom/google/common/collect/ImmutableMultiset$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 161, 115 })]
		public virtual Builder setCount(object element, int count)
		{
			contents.setCount(Preconditions.checkNotNull(element), count);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
		[LineNumberTable(new byte[] { 161, 209, 109, 136 })]
		internal virtual ImmutableMultiset buildJdkBacked()
		{
			if (contents.isEmpty())
			{
				ImmutableMultiset result = of();
				_ = null;
				return result;
			}
			ImmutableMultiset result2 = JdkBackedImmutableMultiset.create(contents.entrySet());
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(459)]
		public virtual ImmutableCollection _003Cbridge_003Ebuild()
		{
			ImmutableMultiset result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(459)]
		public virtual ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterator i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(459)]
		public virtual ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterable i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(459)]
		public virtual ImmutableCollection.Builder _003Cbridge_003Eadd(object[] objarr)
		{
			Builder result = add(objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(459)]
		public virtual ImmutableCollection.Builder _003Cbridge_003Eadd(object obj)
		{
			Builder result = add(obj);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$Indexed<TE;>;")]
	internal sealed class ElementSet : ImmutableSet.Indexed
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/List<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		private List entries;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multiset<TE;>;")]
		private Multiset @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<Lcom/google/common/collect/Multiset$Entry<TE;>;>;Lcom/google/common/collect/Multiset<TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 221, 104, 103, 103 })]
		internal ElementSet(List P_0, Multiset P_1)
		{
			entries = P_0;
			@delegate = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(598)]
		internal override object get(int P_0)
		{
			object element = ((Multiset.Entry)entries.get(P_0)).getElement();
			_ = null;
			return element;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(603)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = @delegate.contains(P_0);
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(613)]
		public override int size()
		{
			int result = entries.size();
			_ = null;
			return result;
		}

		[HideFromJava]
		static ElementSet()
		{
			Indexed.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ElementSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/IndexedImmutableSet<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	internal sealed class EntrySet : IndexedImmutableSet
	{
		private const long serialVersionUID = 0L;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ImmutableMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(370)]
		internal EntrySet(ImmutableMultiset P_0, ImmutableMultiset._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(370)]
		private EntrySet(ImmutableMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[LineNumberTable(378)]
		internal new virtual Multiset.Entry get(int P_0)
		{
			Multiset.Entry entry = this_00240.getEntry(P_0);
			_ = null;
			return entry;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(373)]
		internal override bool isPartialView()
		{
			bool result = this_00240.isPartialView();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(383)]
		public override int size()
		{
			int result = this_00240.elementSet().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 18, 104, 103, 105, 130, 114, 138 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Multiset.Entry)
			{
				Multiset.Entry entry = (Multiset.Entry)P_0;
				if (entry.getCount() <= 0)
				{
					return false;
				}
				int num = this_00240.count(entry.getElement());
				return num == entry.getCount();
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(401)]
		public override int hashCode()
		{
			int result = this_00240.hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(407)]
		internal override object writeReplace()
		{
			EntrySetSerializedForm result = new EntrySetSerializedForm(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(369)]
		internal override object get(int P_0)
		{
			Multiset.Entry result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static EntrySet()
		{
			IndexedImmutableSet.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected EntrySet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class EntrySetSerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
		internal ImmutableMultiset multiset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMultiset<TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 47, 104, 103 })]
		internal EntrySetSerializedForm(ImmutableMultiset P_0)
		{
			multiset = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(422)]
		internal virtual object readResolve()
		{
			ImmutableSet result = multiset.entrySet();
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
		protected EntrySetSerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(EntrySetSerializedForm))
			{
				return this;
			}
			return readResolve();
		}
	}

	[Serializable]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		internal object[] elements;

		[Modifiers(Modifiers.Final)]
		internal int[] counts;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multiset<+Ljava/lang/Object;>;)V")]
		[LineNumberTable(new byte[]
		{
			161, 252, 104, 108, 108, 108, 98, 127, 2, 111,
			111, 100, 98
		})]
		internal SerializedForm(Multiset P_0)
		{
			int num = P_0.entrySet().size();
			elements = new object[num];
			counts = new int[num];
			int num2 = 0;
			Iterator iterator = P_0.entrySet().iterator();
			while (iterator.hasNext())
			{
				Multiset.Entry entry = (Multiset.Entry)iterator.next();
				elements[num2] = entry.getElement();
				counts[num2] = entry.getCount();
				num2++;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 9, 109, 108, 55, 166 })]
		internal virtual object readResolve()
		{
			LinkedHashMultiset linkedHashMultiset = LinkedHashMultiset.create(elements.Length);
			for (int i = 0; i < (nint)elements.LongLength; i++)
			{
				linkedHashMultiset.add(elements[i], counts[i]);
			}
			ImmutableMultiset result = copyOf(linkedHashMultiset);
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
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
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

	[SpecialName]
	private sealed class ___003C_003EAnon0 : ToIntFunction
	{
		internal ___003C_003EAnon0()
		{
		}

		public int applyAsInt(object P_0)
		{
			int result = lambda_0024toImmutableMultiset_00240(P_0);
			_ = null;
			return result;
		}
	}

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
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
	private new ImmutableList m_asList;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
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
	private ImmutableSet m_entrySet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<+Lcom/google/common/collect/Multiset$Entry<+TE;>;>;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 105, 104, 136 })]
	internal static ImmutableMultiset copyFromEntries(Collection P_0)
	{
		if (P_0.isEmpty())
		{
			ImmutableMultiset result = of();
			_ = null;
			return result;
		}
		ImmutableMultiset result2 = RegularImmutableMultiset.create(P_0);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 98, 102, 104 })]
	private static ImmutableMultiset copyFromElements(params object[] P_0)
	{
		LinkedHashMultiset linkedHashMultiset = LinkedHashMultiset.create();
		Collections.addAll(linkedHashMultiset, P_0);
		ImmutableMultiset result = copyFromEntries(((Multiset)linkedHashMultiset).entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(98)]
	public static ImmutableMultiset of()
	{
		return RegularImmutableMultiset.EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(new byte[] { 160, 245, 103 })]
	public virtual ImmutableSet entrySet()
	{
		ImmutableSet immutableSet = this.m_entrySet;
		ImmutableSet result;
		if (immutableSet == null)
		{
			ImmutableSet immutableSet2 = createEntrySet();
			result = immutableSet2;
			this.m_entrySet = immutableSet2;
		}
		else
		{
			result = immutableSet;
		}
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract int count(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(364)]
	private ImmutableSet createEntrySet()
	{
		ImmutableSet result = ((!isEmpty()) ? new EntrySet(this, null) : ImmutableSet.of());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(new byte[] { 160, 116, 108 })]
	public override UnmodifiableIterator iterator()
	{
		UnmodifiableIterator unmodifiableIterator = entrySet().iterator();
		_1 result = new _1(this, unmodifiableIterator);
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
	public abstract ImmutableSet elementSet();

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static int lambda_0024toImmutableMultiset_00240(object P_0)
	{
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableMultiset<TE;>;>;")]
	[LineNumberTable(70)]
	public static Collector toImmutableMultiset()
	{
		Collector result = CollectCollectors.toImmutableMultiset(java.util.function.Function.identity(), new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;E:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TE;>;Ljava/util/function/ToIntFunction<-TT;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMultiset<TE;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 90, 0, 0 })]
	[LineNumberTable(88)]
	public static Collector toImmutableMultiset(java.util.function.Function elementFunction, ToIntFunction countFunction)
	{
		Collector result = CollectCollectors.toImmutableMultiset(elementFunction, countFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(108)]
	public static ImmutableMultiset of(object element)
	{
		ImmutableMultiset result = copyFromElements(element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(118)]
	public static ImmutableMultiset of(object e1, object e2)
	{
		ImmutableMultiset result = copyFromElements(e1, e2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(129)]
	public static ImmutableMultiset of(object e1, object e2, object e3)
	{
		ImmutableMultiset result = copyFromElements(e1, e2, e3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(140)]
	public static ImmutableMultiset of(object e1, object e2, object e3, object e4)
	{
		ImmutableMultiset result = copyFromElements(e1, e2, e3, e4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(151)]
	public static ImmutableMultiset of(object e1, object e2, object e3, object e4, object e5)
	{
		ImmutableMultiset result = copyFromElements(e1, e2, e3, e4, e5);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;[TE;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(162)]
	public static ImmutableMultiset of(object e1, object e2, object e3, object e4, object e5, object e6, params object[] others)
	{
		ImmutableMultiset result = new Builder().add(e1).add(e2).add(e3)
			.add(e4)
			.add(e5)
			.add(e6)
			.add(others)
			.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(173)]
	public static ImmutableMultiset copyOf(object[] elements)
	{
		ImmutableMultiset result = copyFromElements(elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 69, 136, 103, 104, 226, 69, 104, 104, 135 })]
	public static ImmutableMultiset copyOf(Iterable elements)
	{
		if (elements is ImmutableMultiset)
		{
			ImmutableMultiset immutableMultiset = (ImmutableMultiset)elements;
			if (!immutableMultiset.isPartialView())
			{
				return immutableMultiset;
			}
		}
		object obj = ((!(elements is Multiset)) ? LinkedHashMultiset.create(elements) : Multisets.cast(elements));
		ImmutableMultiset result = copyFromEntries(((obj == null) ? null : ((obj as Multiset) ?? throw new java.lang.IncompatibleClassChangeError())).entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 160, 92, 102, 104 })]
	public static ImmutableMultiset copyOf(Iterator elements)
	{
		LinkedHashMultiset linkedHashMultiset = LinkedHashMultiset.create();
		Iterators.addAll(linkedHashMultiset, elements);
		ImmutableMultiset result = copyFromEntries(((Multiset)linkedHashMultiset).entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(226)]
	internal ImmutableMultiset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 160, 147, 103 })]
	public override ImmutableList asList()
	{
		ImmutableList immutableList = this.m_asList;
		ImmutableList result;
		if (immutableList == null)
		{
			ImmutableList immutableList2 = base.asList();
			result = immutableList2;
			this.m_asList = immutableList2;
		}
		else
		{
			result = immutableList;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(267)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		return count(@object) > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TE;I)I")]
	[LineNumberTable(281)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public int add(object element, int occurrences)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(295)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element, int occurrences)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TE;I)I")]
	[LineNumberTable(309)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public int setCount(object element, int count)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TE;II)Z")]
	[LineNumberTable(323)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public bool setCount(object element, int oldCount, int newCount)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 90, 0,
		0
	})]
	[LineNumberTable(new byte[] { 160, 215, 127, 1, 117, 106, 98 })]
	internal override int copyIntoArray(object[] P_0, int P_1)
	{
		UnmodifiableIterator unmodifiableIterator = entrySet().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)((Iterator)unmodifiableIterator).next();
			Arrays.fill(P_0, P_1, P_1 + entry.getCount(), entry.getElement());
			P_1 += entry.getCount();
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(338)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		bool result = Multisets.equalsImpl(this, @object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(343)]
	public override int hashCode()
	{
		int result = Sets.hashCodeImpl(entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(348)]
	public override string toString()
	{
		string result = entrySet().toString();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("(I)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	internal virtual Multiset.Entry getEntry(int P_0)
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableMultiset.getEntry(I)Lcom.google.common.collect.Multiset$Entry;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(429)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableMultiset$Builder<TE;>;")]
	[LineNumberTable(437)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(56)]
	public override Iterator _003Cbridge_003Eiterator()
	{
		UnmodifiableIterator result = iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(56)]
	public virtual Set _003Cbridge_003EentrySet()
	{
		ImmutableSet result = entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(56)]
	public virtual Set _003Cbridge_003EelementSet()
	{
		ImmutableSet result = elementSet();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEachEntry(ObjIntConsumer P_0)
	{
		Multiset._003Cdefault_003EforEachEntry(this, P_0);
	}

	[HideFromJava]
	static ImmutableMultiset()
	{
		ImmutableMultisetGwtSerializationDependencies.___003Cclinit_003E();
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	int Multiset.Multiset_003A_003Asize()
	{
		return size();
	}

	Set Multiset.Multiset_003A_003AelementSet()
	{
		return _003Cbridge_003EelementSet();
	}

	Set Multiset.Multiset_003A_003AentrySet()
	{
		return _003Cbridge_003EentrySet();
	}

	Iterator Multiset.Multiset_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	bool Multiset.Multiset_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	void Multiset.Multiset_003A_003AforEach(Consumer P_0)
	{
		forEach(P_0);
	}

	Iterator Collection.Collection_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	int Collection.Collection_003A_003Asize()
	{
		return size();
	}

	bool Collection.Collection_003A_003AisEmpty()
	{
		return isEmpty();
	}

	bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	Stream Collection.Collection_003A_003Astream()
	{
		return stream();
	}

	Stream Collection.Collection_003A_003AparallelStream()
	{
		return parallelStream();
	}

	Iterator Iterable.Iterable_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	void Iterable.Iterable_003A_003AforEach(Consumer P_0)
	{
		forEach(P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableMultiset(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
