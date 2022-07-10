using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$CachingAsList<Ljava/util/Map$Entry<TK;TV;>;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ImmutableMapEntrySet : ImmutableSet.CachingAsList
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class EntrySetSerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		internal ImmutableMap map;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 77, 104, 103 })]
		internal EntrySetSerializedForm(ImmutableMap P_0)
		{
			map = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(132)]
		internal virtual object readResolve()
		{
			ImmutableSet result = map.entrySet();
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
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMapEntrySet<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)53,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class RegularEntrySet : ImmutableMapEntrySet
	{
		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		private new ImmutableMap m_map;

		[NonSerialized]
		[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
		[Signature("Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TK;TV;>;>;")]
		private ImmutableList entries;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<TK;TV;>;Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 159, 187, 104, 103, 103 })]
		internal RegularEntrySet(ImmutableMap P_0, ImmutableList P_1)
		{
			this.m_map = P_0;
			entries = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(63)]
		public override UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = entries.iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<TK;TV;>;[Ljava/util/Map$Entry<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 159, 184, 111 })]
		internal RegularEntrySet(ImmutableMap P_0, Map.Entry[] P_1)
			: this(P_0, ImmutableList.asImmutableList(P_1))
		{
		}

		[Signature("()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		internal override ImmutableMap map()
		{
			return this.m_map;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 0, 1, 0, 0, 0, 53, 0,
			0
		})]
		[LineNumberTable(58)]
		internal override int copyIntoArray(object[] P_0, int P_1)
		{
			int result = entries.copyIntoArray(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(68)]
		public override Spliterator spliterator()
		{
			Spliterator result = entries.spliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 23, 110 })]
		public override void forEach(Consumer P_0)
		{
			entries.forEach(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(78)]
		internal override ImmutableList createAsList()
		{
			RegularImmutableAsList.___003Cclinit_003E();
			RegularImmutableAsList result = new RegularImmutableAsList(this, entries);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(37)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static RegularEntrySet()
		{
			ImmutableMapEntrySet.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected RegularEntrySet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[Signature("()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	internal abstract ImmutableMap map();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(82)]
	internal ImmutableMapEntrySet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(88)]
	public override int size()
	{
		int result = map().size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 43, 104, 103, 114, 150 })]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 is Map.Entry)
		{
			Map.Entry entry = (Map.Entry)P_0;
			object obj = map().get(entry.getKey());
			return (obj != null && java.lang.Object.instancehelper_equals(obj, entry.getValue())) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(103)]
	internal override bool isPartialView()
	{
		bool result = map().isPartialView();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(109)]
	internal override bool isHashCodeFast()
	{
		bool result = map().isHashCodeFast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(114)]
	public override int hashCode()
	{
		int result = map().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(120)]
	internal override object writeReplace()
	{
		EntrySetSerializedForm result = new EntrySetSerializedForm(map());
		_ = null;
		return result;
	}

	[HideFromJava]
	static ImmutableMapEntrySet()
	{
		CachingAsList.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ImmutableMapEntrySet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
