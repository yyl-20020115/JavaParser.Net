using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)84,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class JdkBackedImmutableBiMap : ImmutableBiMap
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
	[Signature("Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TV;TK;>;>;")]
	internal sealed class InverseEntries : ImmutableList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal JdkBackedImmutableBiMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(89)]
		internal InverseEntries(JdkBackedImmutableBiMap P_0, JdkBackedImmutableBiMap._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(89)]
		private InverseEntries(JdkBackedImmutableBiMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/Map$Entry<TV;TK;>;")]
		[LineNumberTable(new byte[] { 42, 119 })]
		public new virtual Map.Entry get(int P_0)
		{
			Map.Entry entry = (Map.Entry)access_0024100(this_00240).get(P_0);
			Map.Entry result = Maps.immutableEntry(entry.getValue(), entry.getKey());
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(103)]
		public override int size()
		{
			int result = access_0024100(this_00240).size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(88)]
		public override object get(int P_0)
		{
			Map.Entry result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static InverseEntries()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected InverseEntries(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TK;TV;>;>;")]
	private ImmutableList entries;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<TK;TV;>;")]
	private Map forwardDelegate;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<TV;TK;>;")]
	private Map backwardDelegate;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/JdkBackedImmutableBiMap<TV;TK;>;")]
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
	private new JdkBackedImmutableBiMap m_inverse;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TK;TV;>;>;Ljava/util/Map<TK;TV;>;Ljava/util/Map<TV;TK;>;)V")]
	[LineNumberTable(new byte[] { 12, 104, 103, 103, 103 })]
	private JdkBackedImmutableBiMap(ImmutableList P_0, Map P_1, Map P_2)
	{
		entries = P_0;
		forwardDelegate = P_1;
		backwardDelegate = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableBiMap<TV;TK;>;")]
	[LineNumberTable(new byte[] { 27, 103, 99, 223, 1, 135 })]
	public override ImmutableBiMap inverse()
	{
		JdkBackedImmutableBiMap jdkBackedImmutableBiMap = this.m_inverse;
		if (jdkBackedImmutableBiMap == null)
		{
			jdkBackedImmutableBiMap = (this.m_inverse = new JdkBackedImmutableBiMap(new InverseEntries(this, null), backwardDelegate, forwardDelegate));
			jdkBackedImmutableBiMap.m_inverse = this;
		}
		return jdkBackedImmutableBiMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I[Ljava/util/Map$Entry<TK;TV;>;)Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 84, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		159,
		180,
		103,
		103,
		137,
		115,
		100,
		116,
		103,
		159,
		79,
		116,
		103,
		byte.MaxValue,
		79,
		54,
		233,
		77,
		105
	})]
	internal static ImmutableBiMap create(int P_0, Map.Entry[] P_1)
	{
		HashMap hashMap = Maps.newHashMapWithExpectedSize(P_0);
		HashMap hashMap2 = Maps.newHashMapWithExpectedSize(P_0);
		for (int i = 0; i < P_0; i++)
		{
			ImmutableMapEntry immutableMapEntry = (ImmutableMapEntry)(P_1[i] = RegularImmutableMap.makeImmutable((Map.Entry)Objects.requireNonNull(P_1[i])));
			object obj = ((Map)hashMap).putIfAbsent(((Map.Entry)immutableMapEntry).getKey(), ((Map.Entry)immutableMapEntry).getValue());
			if (obj != null)
			{
				string text = java.lang.String.valueOf(((Map.Entry)immutableMapEntry).getKey());
				string text2 = java.lang.String.valueOf(obj);
				int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
				num = num;
				throw Throwable.___003Cunmap_003E(ImmutableMap.conflictException("key", new StringBuilder(num).append(text).append("=").append(text2)
					.toString(), P_1[i]));
			}
			object obj2 = ((Map)hashMap2).putIfAbsent(((Map.Entry)immutableMapEntry).getValue(), ((Map.Entry)immutableMapEntry).getKey());
			if (obj2 != null)
			{
				string text2 = java.lang.String.valueOf(obj2);
				string text3 = java.lang.String.valueOf(((Map.Entry)immutableMapEntry).getValue());
				int num = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3));
				num = num;
				throw Throwable.___003Cunmap_003E(ImmutableMap.conflictException("value", new StringBuilder(num).append(text2).append("=").append(text3)
					.toString(), P_1[i]));
			}
		}
		ImmutableList immutableList = ImmutableList.asImmutableList(P_1, P_0);
		JdkBackedImmutableBiMap result = new JdkBackedImmutableBiMap(immutableList, hashMap, hashMap2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(70)]
	public override int size()
	{
		int result = entries.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)TV;")]
	[LineNumberTable(110)]
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
		object result = forwardDelegate.get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(115)]
	internal override ImmutableSet createEntrySet()
	{
		ImmutableMapEntrySet.RegularEntrySet.___003Cclinit_003E();
		ImmutableMapEntrySet.RegularEntrySet result = new ImmutableMapEntrySet.RegularEntrySet(this, entries);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	[LineNumberTable(120)]
	internal override ImmutableSet createKeySet()
	{
		ImmutableMapKeySet result = new ImmutableMapKeySet(this);
		_ = null;
		return result;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual BiMap inverse()
	{
		ImmutableBiMap result = this.inverse();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(35)]
	internal static ImmutableList access_0024100(JdkBackedImmutableBiMap P_0)
	{
		return P_0.entries;
	}

	[HideFromJava]
	static JdkBackedImmutableBiMap()
	{
		ImmutableBiMap.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected JdkBackedImmutableBiMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
