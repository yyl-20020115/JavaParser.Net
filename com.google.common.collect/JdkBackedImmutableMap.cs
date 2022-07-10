using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)83,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class JdkBackedImmutableMap : ImmutableMap
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly BiConsumer arg_00241;

		internal ___003C_003EAnon0(BiConsumer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024forEach_00240(arg_00241, (Map.Entry)P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Ljava/util/Map<TK;TV;>;")]
	private Map delegateMap;

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
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>(I[Ljava/util/Map$Entry<TK;TV;>;Z)Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 1, 1, 0, 0, 0, 83, 0,
		0
	})]
	[LineNumberTable(new byte[]
	{
		159, 131, 66, 231, 69, 98, 98, 139, 119, 107,
		107, 108, 103, 102, 159, 83, 99, 134, 107, 228,
		50, 235, 81, 134, 106, 110, 112, 110, 106, 106,
		100, 130, 107, 138, 237, 53, 235, 77, 132
	})]
	internal static ImmutableMap create(int P_0, Map.Entry[] P_1, bool P_2)
	{
		HashMap hashMap = Maps.newHashMapWithExpectedSize(P_0);
		HashMap hashMap2 = null;
		int num = 0;
		for (int i = 0; i < P_0; i++)
		{
			P_1[i] = RegularImmutableMap.makeImmutable((Map.Entry)java.util.Objects.requireNonNull(P_1[i]));
			object key = P_1[i].getKey();
			object value = P_1[i].getValue();
			object obj = ((Map)hashMap).put(key, value);
			if (obj != null)
			{
				if (P_2)
				{
					Map.Entry obj2 = P_1[i];
					string text = java.lang.String.valueOf(P_1[i].getKey());
					string text2 = java.lang.String.valueOf(obj);
					int num2 = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
					num2 = num2;
					throw Throwable.___003Cunmap_003E(ImmutableMap.conflictException("key", obj2, new StringBuilder(num2).append(text).append("=").append(text2)
						.toString()));
				}
				if (hashMap2 == null)
				{
					hashMap2 = new HashMap();
				}
				((Map)hashMap2).put(key, value);
				num++;
			}
		}
		if (hashMap2 != null)
		{
			Map.Entry[] array = new Map.Entry[P_0 - num];
			int j = 0;
			int num3 = 0;
			for (; j < P_0; j++)
			{
				object obj = (Map.Entry)java.util.Objects.requireNonNull(P_1[j]);
				object key2 = ((Map.Entry)obj).getKey();
				if (((Map)hashMap2).containsKey(key2))
				{
					object obj3 = ((Map)hashMap2).get(key2);
					if (obj3 == null)
					{
						continue;
					}
					obj = new ImmutableMapEntry(key2, obj3);
					((Map)hashMap2).put(key2, (object)null);
				}
				int num4 = num3;
				num3++;
				array[num4] = (Map.Entry)obj;
			}
			P_1 = array;
		}
		JdkBackedImmutableMap result = new JdkBackedImmutableMap(hashMap, ImmutableList.asImmutableList(P_1, P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;TV;>;Lcom/google/common/collect/ImmutableList<Ljava/util/Map$Entry<TK;TV;>;>;)V")]
	[LineNumberTable(new byte[] { 42, 104, 103, 103 })]
	internal JdkBackedImmutableMap(Map P_0, ImmutableList P_1)
	{
		delegateMap = P_0;
		entries = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(116)]
	private static void lambda_0024forEach_00240(BiConsumer P_0, Map.Entry P_1)
	{
		P_0.accept(P_1.getKey(), P_1.getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(99)]
	public override int size()
	{
		int result = entries.size();
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
	public override object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		object result = delegateMap.get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(110)]
	internal override ImmutableSet createEntrySet()
	{
		ImmutableMapEntrySet.RegularEntrySet.___003Cclinit_003E();
		ImmutableMapEntrySet.RegularEntrySet result = new ImmutableMapEntrySet.RegularEntrySet(this, entries);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/BiConsumer<-TK;-TV;>;)V")]
	[LineNumberTable(new byte[] { 65, 103, 120 })]
	public override void forEach(BiConsumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		entries.forEach(new ___003C_003EAnon0(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
	[LineNumberTable(121)]
	internal override ImmutableSet createKeySet()
	{
		ImmutableMapKeySet result = new ImmutableMapKeySet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(126)]
	internal override ImmutableCollection createValues()
	{
		ImmutableMapValues result = new ImmutableMapValues(this);
		_ = null;
		return result;
	}

	internal override bool isPartialView()
	{
		return false;
	}

	[HideFromJava]
	static JdkBackedImmutableMap()
	{
		ImmutableMap.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected JdkBackedImmutableMap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
