using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)71,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class RegularImmutableBiMap : ImmutableBiMap
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal new class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;")]
	internal sealed class Inverse : ImmutableBiMap
	{
		[Serializable]
		[InnerClass(null, Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMapEntrySet<TV;TK;>;")]
		internal sealed class InverseEntrySet : ImmutableMapEntrySet
		{
			[Serializable]
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/ImmutableAsList<Ljava/util/Map$Entry<TV;TK;>;>;")]
			[EnclosingMethod(null, "createAsList", "()Lcom.google.common.collect.ImmutableList;")]
			internal class _1 : ImmutableAsList
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal InverseEntrySet this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[SpecialName]
				public new static void ___003Cclinit_003E()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(I)Ljava/util/Map$Entry<TV;TK;>;")]
				[LineNumberTable(new byte[] { 160, 163, 120 })]
				public new virtual Map.Entry get(int P_0)
				{
					Map.Entry entry = this_00242.this_00241.this_00240.entries[P_0];
					Map.Entry result = Maps.immutableEntry(entry.getValue(), entry.getKey());
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(274)]
				internal _1(InverseEntrySet P_0)
				{
					this_00242 = P_0;
					base._002Ector();
				}

				[Signature("()Lcom/google/common/collect/ImmutableCollection<Ljava/util/Map$Entry<TV;TK;>;>;")]
				internal override ImmutableCollection delegateCollection()
				{
					return this_00242;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(274)]
				public override object get(int P_0)
				{
					Map.Entry result = get(P_0);
					_ = null;
					return result;
				}

				[HideFromJava]
				static _1()
				{
					ImmutableAsList.___003Cclinit_003E();
				}

				[HideFromJava]
				[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
				protected _1(SerializationInfo P_0, StreamingContext P_1)
					: base(P_0, P_1)
				{
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Inverse this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TV;TK;>;>;")]
			[LineNumberTable(264)]
			public override UnmodifiableIterator iterator()
			{
				UnmodifiableIterator result = asList().iterator();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(246)]
			internal InverseEntrySet(Inverse P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[Signature("()Lcom/google/common/collect/ImmutableMap<TV;TK;>;")]
			internal override ImmutableMap map()
			{
				return this_00241;
			}

			internal override bool isHashCodeFast()
			{
				return true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(259)]
			public override int hashCode()
			{
				int result = access_0024300(this_00241.this_00240);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/function/Consumer<-Ljava/util/Map$Entry<TV;TK;>;>;)V")]
			[LineNumberTable(new byte[] { 160, 155, 110 })]
			public override void forEach(Consumer P_0)
			{
				asList().forEach(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TV;TK;>;>;")]
			[LineNumberTable(274)]
			internal override ImmutableList createAsList()
			{
				_1 result = new _1(this);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(246)]
			public override Iterator iterator()
			{
				UnmodifiableIterator result = this.iterator();
				_ = null;
				return result;
			}

			[HideFromJava]
			static InverseEntrySet()
			{
				ImmutableMapEntrySet.___003Cclinit_003E();
			}

			[HideFromJava]
			[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
			protected InverseEntrySet(SerializationInfo P_0, StreamingContext P_1)
				: base(P_0, P_1)
			{
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiConsumer
		{
			private readonly BiConsumer arg_00241;

			internal ___003C_003EAnon0(BiConsumer P_0)
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

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal RegularImmutableBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(201)]
		internal Inverse(RegularImmutableBiMap P_0, RegularImmutableBiMap._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(201)]
		private Inverse(RegularImmutableBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[Signature("()Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
		public override ImmutableBiMap inverse()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(216)]
		private static void lambda_0024forEach_00240(BiConsumer P_0, object P_1, object P_2)
		{
			P_0.accept(P_2, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(205)]
		public override int size()
		{
			int result = this.inverse().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BiConsumer<-TV;-TK;>;)V")]
		[LineNumberTable(new byte[] { 160, 101, 103, 120 })]
		public override void forEach(BiConsumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			this_00240.forEach(new ___003C_003EAnon0(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TK;")]
		[LineNumberTable(new byte[]
		{
			160, 108, 112, 130, 120, 110, 131, 110, 9, 233,
			69
		})]
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
			if (P_0 == null || access_0024100(this_00240) == null)
			{
				return null;
			}
			int num = Hashing.smear(java.lang.Object.instancehelper_hashCode(P_0)) & access_0024200(this_00240);
			for (ImmutableMapEntry immutableMapEntry = access_0024100(this_00240)[num]; immutableMapEntry != null; immutableMapEntry = immutableMapEntry.getNextInValueBucket())
			{
				if (java.lang.Object.instancehelper_equals(P_0, immutableMapEntry.getValue()))
				{
					object key = immutableMapEntry.getKey();
					_ = null;
					return key;
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TV;>;")]
		[LineNumberTable(238)]
		internal override ImmutableSet createKeySet()
		{
			ImmutableMapKeySet result = new ImmutableMapKeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TV;TK;>;>;")]
		[LineNumberTable(243)]
		internal override ImmutableSet createEntrySet()
		{
			InverseEntrySet result = new InverseEntrySet(this);
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(296)]
		internal override object writeReplace()
		{
			InverseSerializedForm result = new InverseSerializedForm(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(201)]
		public new virtual BiMap inverse()
		{
			ImmutableBiMap result = this.inverse();
			_ = null;
			return result;
		}

		[HideFromJava]
		static Inverse()
		{
			ImmutableBiMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Inverse(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class InverseSerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
		private ImmutableBiMap forward;

		private const long serialVersionUID = 1L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 189, 104, 103 })]
		internal InverseSerializedForm(ImmutableBiMap P_0)
		{
			forward = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(308)]
		internal virtual object readResolve()
		{
			ImmutableBiMap result = forward.inverse();
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
		protected InverseSerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			if (((object)this).GetType() != typeof(InverseSerializedForm))
			{
				return this;
			}
			return readResolve();
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/RegularImmutableBiMap<Ljava/lang/Object;Ljava/lang/Object;>;")]
	internal static RegularImmutableBiMap EMPTY;

	internal const double MAX_LOAD_FACTOR = 1.2;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("[Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 71, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ImmutableMapEntry[] keyTable;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("[Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 0, 0, 0, 71, 0, 0 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private ImmutableMapEntry[] valueTable;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("[Ljava/util/Map$Entry<TK;TV;>;")]
	internal Map.Entry[] entries;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private int mask;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private new int m_hashCode;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;")]
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
	private new ImmutableBiMap m_inverse;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I[Ljava/util/Map$Entry<TK;TV;>;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 71, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		15, 105, 112, 100, 103, 231, 72, 112, 131, 139,
		112, 105, 105, 105, 105, 105, 107, 139, 102, 134,
		109, 182, 2, 97, 168, 104, 109, 143, 102, 102,
		103, 234, 37, 235, 93
	})]
	internal static ImmutableBiMap fromEntryArray(int P_0, Map.Entry[] P_1)
	{
		Preconditions.checkPositionIndex(P_0, P_1.Length);
		int num = Hashing.closedTableSize(P_0, 1.2);
		int num2 = num - 1;
		ImmutableMapEntry[] array = ImmutableMapEntry.createEntryArray(num);
		ImmutableMapEntry[] array2 = ImmutableMapEntry.createEntryArray(num);
		object[] array3 = (((nint)P_0 != (nint)P_1.LongLength) ? ImmutableMapEntry.createEntryArray(P_0) : P_1);
		int num3 = 0;
		for (int i = 0; i < P_0; i++)
		{
			Map.Entry entry = (Map.Entry)java.util.Objects.requireNonNull(P_1[i]);
			object key = entry.getKey();
			object value = entry.getValue();
			CollectPreconditions.checkEntryNotNull(key, value);
			int num4 = java.lang.Object.instancehelper_hashCode(key);
			int num5 = java.lang.Object.instancehelper_hashCode(value);
			int num6 = Hashing.smear(num4) & num2;
			int num7 = Hashing.smear(num5) & num2;
			ImmutableMapEntry immutableMapEntry = array[num6];
			ImmutableMapEntry immutableMapEntry2 = array2[num7];
			try
			{
				RegularImmutableMap.checkNoConflictInKeyBucket(key, value, immutableMapEntry, true);
				checkNoConflictInValueBucket(value, entry, immutableMapEntry2);
			}
			catch (RegularImmutableMap.BucketOverflowException)
			{
				goto IL_00c8;
			}
			array3[i] = (array2[num7] = (array[num6] = ((immutableMapEntry2 != null || immutableMapEntry != null) ? new ImmutableMapEntry.NonTerminalImmutableBiMapEntry(key, value, immutableMapEntry, immutableMapEntry2) : RegularImmutableMap.makeImmutable(entry, key, value))));
			num3 += num4 ^ num5;
			continue;
			IL_00c8:
			_ = null;
			return JdkBackedImmutableBiMap.create(P_0, P_1);
		}
		int num8 = num3;
		int num9 = num2;
		return new RegularImmutableBiMap(array, array2, (array3 == null) ? null : ((array3 as Map.Entry[]) ?? throw new java.lang.IncompatibleClassChangeError()), num9, num8);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>([Ljava/util/Map$Entry<TK;TV;>;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[LineNumberTable(61)]
	internal static ImmutableBiMap fromEntries(params Map.Entry[] P_0)
	{
		ImmutableBiMap result = fromEntryArray(P_0.Length, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "com.google.common.collect.RegularImmutableMap$BucketOverflowException" })]
	[Signature("(Ljava/lang/Object;Ljava/util/Map$Entry<**>;Lcom/google/common/collect/ImmutableMapEntry<**>;)V")]
	[LineNumberTable(new byte[] { 85, 98, 99, 126, 104, 235, 61, 234, 70 })]
	private static void checkNoConflictInValueBucket(object P_0, Map.Entry P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableMapEntry P_2)
	{
		int num = 0;
		while (P_2 != null)
		{
			ImmutableMap.checkNoConflict((!java.lang.Object.instancehelper_equals(P_0, P_2.getValue())) ? true : false, "value", P_1, P_2);
			num++;
			if (num > 8)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RegularImmutableMap.BucketOverflowException();
			}
			P_2 = P_2.getNextInValueBucket();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;[Lcom/google/common/collect/ImmutableMapEntry<TK;TV;>;[Ljava/util/Map$Entry<TK;TV;>;II)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 0, 1, 0, 0, 0, 71, 0,
		0, 22, 1, 1, 0, 0, 0, 71, 0, 0
	})]
	[LineNumberTable(new byte[] { 67, 104, 103, 103, 103, 104, 104 })]
	private RegularImmutableBiMap([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableMapEntry[] P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] ImmutableMapEntry[] P_1, Map.Entry[] P_2, int P_3, int P_4)
	{
		keyTable = P_0;
		valueTable = P_1;
		entries = P_2;
		mask = P_3;
		this.m_hashCode = P_4;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;")]
	[LineNumberTable(new byte[] { 160, 80, 104, 136, 103 })]
	public override ImmutableBiMap inverse()
	{
		if (isEmpty())
		{
			ImmutableBiMap result = ImmutableBiMap.of();
			_ = null;
			return result;
		}
		ImmutableBiMap immutableBiMap = this.m_inverse;
		object result2;
		if (immutableBiMap == null)
		{
			Inverse inverse = new Inverse(this, null);
			result2 = inverse;
			this.m_inverse = inverse;
		}
		else
		{
			result2 = immutableBiMap;
		}
		return (ImmutableBiMap)result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(147)]
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
		object result = RegularImmutableMap.get(P_0, keyTable, mask);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 102, 104, 103, 19 })]
	internal override ImmutableSet createEntrySet()
	{
		object result;
		if (isEmpty())
		{
			result = ImmutableSet.of();
		}
		else
		{
			ImmutableMapEntrySet.RegularEntrySet.___003Cclinit_003E();
			result = new ImmutableMapEntrySet.RegularEntrySet(this, entries);
		}
		_ = null;
		return (ImmutableSet)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	[LineNumberTable(159)]
	internal override ImmutableSet createKeySet()
	{
		ImmutableMapKeySet result = new ImmutableMapKeySet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 114, 103, 116, 50, 166 })]
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

	internal override bool isHashCodeFast()
	{
		return true;
	}

	public override int hashCode()
	{
		return this.m_hashCode;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[LineNumberTable(187)]
	public override int size()
	{
		return entries.Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public new virtual BiMap inverse()
	{
		ImmutableBiMap result = this.inverse();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(47)]
	internal static ImmutableMapEntry[] access_0024100(RegularImmutableBiMap P_0)
	{
		return P_0.valueTable;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(47)]
	internal static int access_0024200(RegularImmutableBiMap P_0)
	{
		return P_0.mask;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(47)]
	internal static int access_0024300(RegularImmutableBiMap P_0)
	{
		return P_0.m_hashCode;
	}

	[LineNumberTable(48)]
	static RegularImmutableBiMap()
	{
		ImmutableBiMap.___003Cclinit_003E();
		EMPTY = new RegularImmutableBiMap(null, null, ImmutableMap.EMPTY_ENTRY_ARRAY, 0, 0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableBiMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
