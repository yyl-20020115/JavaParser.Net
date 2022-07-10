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
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)95,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class RegularImmutableMap : ImmutableMap
{
	[Serializable]
	internal class BucketOverflowException : java.lang.Exception
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(253)]
		internal BucketOverflowException()
		{
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected BucketOverflowException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;>Lcom/google/common/collect/IndexedImmutableSet<TK;>;")]
	internal sealed class KeySet : IndexedImmutableSet
	{
		[Serializable]
		[InnerClass(null, Modifiers.Private | Modifiers.Static)]
		[Signature("<K:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
		[Implements(new string[] { "java.io.Serializable" })]
		internal new class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Lcom/google/common/collect/ImmutableMap<TK;*>;")]
			internal ImmutableMap map;

			private const long serialVersionUID = 0L;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/ImmutableMap<TK;*>;)V")]
			[LineNumberTable(new byte[] { 160, 236, 104, 103 })]
			internal SerializedForm(ImmutableMap P_0)
			{
				map = P_0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(355)]
			internal virtual object readResolve()
			{
				ImmutableSet result = map.keySet();
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
			protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
			{
				ikvm.@internal.Serialization.readObject(this, P_0);
			}

			[SecurityCritical]
			[HideFromJava]
			object IObjectReference.GetRealObject(StreamingContext P_0)
			{
				if (((object)this).GetType() != typeof(SerializedForm))
				{
					return this;
				}
				return readResolve();
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/RegularImmutableMap<TK;*>;")]
		private RegularImmutableMap map;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/RegularImmutableMap<TK;*>;)V")]
		[LineNumberTable(new byte[] { 160, 206, 104, 103 })]
		internal KeySet(RegularImmutableMap P_0)
		{
			map = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TK;")]
		[LineNumberTable(326)]
		internal override object get(int P_0)
		{
			object key = map.entries[P_0].getKey();
			_ = null;
			return key;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(331)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = map.containsKey(P_0);
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(341)]
		public override int size()
		{
			int result = map.size();
			_ = null;
			return result;
		}

		[HideFromJava]
		static KeySet()
		{
			IndexedImmutableSet.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected KeySet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableList<TV;>;")]
	internal sealed class Values : ImmutableList
	{
		[Serializable]
		[InnerClass(null, Modifiers.Private | Modifiers.Static)]
		[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
		[Implements(new string[] { "java.io.Serializable" })]
		internal new class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
		{
			[Modifiers(Modifiers.Final)]
			[Signature("Lcom/google/common/collect/ImmutableMap<*TV;>;")]
			internal ImmutableMap map;

			private const long serialVersionUID = 0L;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/ImmutableMap<*TV;>;)V")]
			[LineNumberTable(new byte[] { 161, 26, 104, 103 })]
			internal SerializedForm(ImmutableMap P_0)
			{
				map = P_0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(401)]
			internal virtual object readResolve()
			{
				ImmutableCollection result = map.values();
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
			protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
			{
				ikvm.@internal.Serialization.readObject(this, P_0);
			}

			[SecurityCritical]
			[HideFromJava]
			object IObjectReference.GetRealObject(StreamingContext P_0)
			{
				if (((object)this).GetType() != typeof(SerializedForm))
				{
					return this;
				}
				return readResolve();
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/RegularImmutableMap<TK;TV;>;")]
		internal RegularImmutableMap map;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/RegularImmutableMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 1, 104, 103 })]
		internal Values(RegularImmutableMap P_0)
		{
			map = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(377)]
		public override object get(int P_0)
		{
			object value = map.entries[P_0].getValue();
			_ = null;
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(382)]
		public override int size()
		{
			int result = map.size();
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[HideFromJava]
		static Values()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Values(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<Ljava/lang/Object;Ljava/lang/Object;>;")]
	internal static ImmutableMap EMPTY;

	internal const double MAX_LOAD_FACTOR = 1.2;

	internal const double HASH_FLOODING_FPP = 0.001;

	internal const int MAX_HASH_BUCKET_LENGTH = 8;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("[Ljava/util/Map$Entry<TK;TV;>;")]
	internal Map.Entry[] entries;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("[Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 95, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ImmutableMapEntry[] table;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private int mask;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>([Ljava/util/Map$Entry<TK;TV;>;)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[LineNumberTable(77)]
	internal static ImmutableMap fromEntries(params Map.Entry[] P_0)
	{
		ImmutableMap result = fromEntryArray(P_0.Length, P_0, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I[Ljava/util/Map$Entry<TK;TV;>;Z)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 95, 0,
		0
	})]
	[LineNumberTable(new byte[] { 159, 121, 162, 105, 131, 102, 162, 119, 161 })]
	internal static ImmutableMap fromEntryArray(int P_0, Map.Entry[] P_1, bool P_2)
	{
		//Discarded unreachable code: IL_0020
		Preconditions.checkPositionIndex(P_0, P_1.Length);
		if (P_0 == 0)
		{
			return EMPTY;
		}
		try
		{
			return fromEntryArrayCheckingBucketOverflow(P_0, P_1, P_2);
		}
		catch (BucketOverflowException)
		{
		}
		_ = null;
		return JdkBackedImmutableMap.create(P_0, P_1, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map$Entry<TK;TV;>;)Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[LineNumberTable(209)]
	internal static ImmutableMapEntry makeImmutable(Map.Entry P_0)
	{
		ImmutableMapEntry result = makeImmutable(P_0, P_0.getKey(), P_0.getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "com.google.common.collect.RegularImmutableMap$BucketOverflowException" })]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Object;Ljava/lang/Object;Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;Z)Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 0, 0, 95, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		159, 83, 98, 98, 102, 113, 99, 159, 62, 162,
		104, 235, 55, 237, 76
	})]
	internal static ImmutableMapEntry checkNoConflictInKeyBucket(object P_0, object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableMapEntry P_2, bool P_3)
	{
		int num = 0;
		while (P_2 != null)
		{
			if (java.lang.Object.instancehelper_equals(P_2.getKey(), P_0))
			{
				if (!P_3)
				{
					return P_2;
				}
				ImmutableMapEntry immutableMapEntry = P_2;
				string text = java.lang.String.valueOf(P_0);
				string text2 = java.lang.String.valueOf(P_1);
				int num2 = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
				num2 = num2;
				ImmutableMap.checkNoConflict(false, "key", immutableMapEntry, new StringBuilder(num2).append(text).append("=").append(text2)
					.toString());
			}
			num++;
			if (num > 8)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BucketOverflowException();
			}
			P_2 = P_2.getNextInKeyBucket();
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map$Entry<TK;TV;>;TK;TV;)Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 88, 110, 108 })]
	internal static ImmutableMapEntry makeImmutable(Map.Entry P_0, object P_1, object P_2)
	{
		ImmutableMapEntry result = (((!(P_0 is ImmutableMapEntry) || !((ImmutableMapEntry)P_0).isReusable()) && 0 == 0) ? new ImmutableMapEntry(P_1, P_2) : ((ImmutableMapEntry)P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/lang/Object;[Lcom/google/common/collect/ImmutableMapEntry<*TV;>;I)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 95, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		160, 152, 102, 130, 110, 100, 131, 231, 72, 105,
		233, 54, 233, 77
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableMapEntry[] P_1, int P_2)
	{
		if (P_0 == null || P_1 == null)
		{
			return null;
		}
		int num = Hashing.smear(java.lang.Object.instancehelper_hashCode(P_0)) & P_2;
		for (ImmutableMapEntry immutableMapEntry = P_1[num]; immutableMapEntry != null; immutableMapEntry = immutableMapEntry.getNextInKeyBucket())
		{
			object key = immutableMapEntry.getKey();
			if (java.lang.Object.instancehelper_equals(P_0, key))
			{
				object value = immutableMapEntry.getValue();
				_ = null;
				return value;
			}
		}
		return null;
	}

	[Throws(new string[] { "com.google.common.collect.RegularImmutableMap$BucketOverflowException" })]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I[Ljava/util/Map$Entry<TK;TV;>;Z)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 95, 0,
		0
	})]
	private static ImmutableMap fromEntryArrayCheckingBucketOverflow(int P_0, Map.Entry[] P_1, bool P_2)
	{
		throw new java.lang.VerifyError("Incompatible object argument for function call (class: com.google.common.collect.RegularImmutableMap, method: fromEntryArrayCheckingBucketOverflow, signature: (I[Ljava.util.Map$Entry;Z)Lcom.google.common.collect.ImmutableMap;, offset: 204, instruction: invokevirtual)");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>([Ljava/util/Map$Entry<TK;TV;>;IILjava/util/IdentityHashMap<Ljava/util/Map$Entry<TK;TV;>;Ljava/lang/Boolean;>;)[Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(new byte[]
	{
		160, 69, 103, 104, 100, 142, 100, 105, 238, 69,
		232, 53, 230, 77
	})]
	internal static Map.Entry[] removeDuplicates(Map.Entry[] P_0, int P_1, int P_2, IdentityHashMap P_3)
	{
		ImmutableMapEntry[] array = ImmutableMapEntry.createEntryArray(P_2);
		int i = 0;
		int num = 0;
		for (; i < P_1; i++)
		{
			Map.Entry entry = P_0[i];
			java.lang.Boolean boolean = (java.lang.Boolean)P_3.get(entry);
			if (boolean != null)
			{
				if (!boolean.booleanValue())
				{
					continue;
				}
				P_3.put(entry, java.lang.Boolean.valueOf(b: false));
			}
			int num2 = num;
			num++;
			array[num2] = (ImmutableMapEntry)entry;
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Ljava/util/Map$Entry<TK;TV;>;[Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;I)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 95, 0,
		0
	})]
	[LineNumberTable(new byte[] { 160, 99, 104, 103, 103, 103 })]
	private RegularImmutableMap(Map.Entry[] P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableMapEntry[] P_1, int P_2)
	{
		entries = P_0;
		table = P_1;
		mask = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(258)]
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
		object result = get(P_0, table, mask);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 160, 176, 103, 116, 50, 166 })]
	public override void forEach(BiConsumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		Map.Entry[] array = entries;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			Map.Entry entry = array[i];
			P_0.accept(entry.getKey(), entry.getValue());
		}
	}

	[LineNumberTable(298)]
	public override int size()
	{
		return entries.Length;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(308)]
	internal override ImmutableSet createEntrySet()
	{
		ImmutableMapEntrySet.RegularEntrySet.___003Cclinit_003E();
		ImmutableMapEntrySet.RegularEntrySet result = new ImmutableMapEntrySet.RegularEntrySet(this, entries);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	[LineNumberTable(313)]
	internal override ImmutableSet createKeySet()
	{
		KeySet result = new KeySet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(364)]
	internal override ImmutableCollection createValues()
	{
		Values result = new Values(this);
		_ = null;
		return result;
	}

	[LineNumberTable(47)]
	static RegularImmutableMap()
	{
		ImmutableMap.___003Cclinit_003E();
		EMPTY = new RegularImmutableMap(ImmutableMap.EMPTY_ENTRY_ARRAY, null, 0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
