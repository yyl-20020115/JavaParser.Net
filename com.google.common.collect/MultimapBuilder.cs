using System;
using System.ComponentModel;
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

namespace com.google.common.collect;

[Signature("<K0:Ljava/lang/Object;V0:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 61, 0, 0,
	17, 1, 0, 0, 0, 61, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)61,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class MultimapBuilder : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<Ljava/lang/Object;>;")]
	[EnclosingMethod(null, "hashKeys", "(I)Lcom.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		1,
		3,
		0,
		0,
		21,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)21,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _1 : MultimapBuilderWithKeys
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024expectedKeys;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(89)]
		internal _1(int P_0)
		{
			val_0024expectedKeys = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 21, 0, 0,
			18, 1, 0, 0, 0, 21, 0, 0
		})]
		[LineNumberTable(92)]
		internal override Map createMap()
		{
			Map result = Platform.newHashMapWithExpectedSize(val_0024expectedKeys);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<Ljava/lang/Object;>;")]
	[EnclosingMethod(null, "linkedHashKeys", "(I)Lcom.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		1,
		3,
		0,
		0,
		21,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)21,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _2 : MultimapBuilderWithKeys
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024expectedKeys;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(120)]
		internal _2(int P_0)
		{
			val_0024expectedKeys = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 18, 0, 0, 0, 0, 21, 0, 0,
			18, 1, 0, 0, 0, 21, 0, 0
		})]
		[LineNumberTable(123)]
		internal override Map createMap()
		{
			Map result = Platform.newLinkedHashMapWithExpectedSize(val_0024expectedKeys);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<TK0;>;")]
	[EnclosingMethod(null, "treeKeys", "(Ljava.util.Comparator;)Lcom.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys;")]
	[ConstantPool(new object[]
	{
		(byte)22,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _3 : MultimapBuilderWithKeys
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Comparator val_0024comparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(159)]
		internal _3(Comparator P_0)
		{
			val_0024comparator = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:TK0;V:Ljava/lang/Object;>()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 22, 0, 0 })]
		[LineNumberTable(162)]
		internal override Map createMap()
		{
			TreeMap.___003Cclinit_003E();
			TreeMap result = new TreeMap(val_0024comparator);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<TK0;>;")]
	[EnclosingMethod(null, "enumKeys", "(Ljava.lang.Class;)Lcom.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys;")]
	[ConstantPool(new object[]
	{
		(byte)22,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _4 : MultimapBuilderWithKeys
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Class val_0024keyClass;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(174)]
		internal _4(Class P_0)
		{
			val_0024keyClass = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:TK0;V:Ljava/lang/Object;>()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 22, 0, 0 })]
		[LineNumberTable(180)]
		internal override Map createMap()
		{
			EnumMap.___003Cclinit_003E();
			EnumMap result = new EnumMap(val_0024keyClass);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/util/List<TV;>;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 34, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)34,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal sealed class ArrayListSupplier : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int expectedValuesPerKey;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<TV;>;")]
		[LineNumberTable(195)]
		public virtual List get()
		{
			ArrayList.___003Cclinit_003E();
			ArrayList result = new ArrayList(expectedValuesPerKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 75, 104, 113 })]
		internal ArrayListSupplier(int P_0)
		{
			expectedValuesPerKey = CollectPreconditions.checkNonnegative(P_0, "expectedValuesPerKey");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(185)]
		public virtual object get()
		{
			List result = this.get();
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
		protected ArrayListSupplier(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Enum<TV;>;>Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/util/Set<TV;>;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal sealed class EnumSetSupplier : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/Class<TV;>;")]
		private Class clazz;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(267)]
		public virtual Set get()
		{
			EnumSet result = EnumSet.noneOf(clazz);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Class<TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 147, 104, 113 })]
		internal EnumSetSupplier(Class P_0)
		{
			clazz = (Class)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(257)]
		public virtual object get()
		{
			Set result = this.get();
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
		protected EnumSetSupplier(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/util/Set<TV;>;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 33, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)33,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal sealed class HashSetSupplier : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int expectedValuesPerKey;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(225)]
		public virtual Set get()
		{
			Set result = Platform.newHashSetWithExpectedSize(expectedValuesPerKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 105, 104, 113 })]
		internal HashSetSupplier(int P_0)
		{
			expectedValuesPerKey = CollectPreconditions.checkNonnegative(P_0, "expectedValuesPerKey");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(215)]
		public virtual object get()
		{
			Set result = this.get();
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
		protected HashSetSupplier(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/util/Set<TV;>;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 33, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)33,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal sealed class LinkedHashSetSupplier : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int expectedValuesPerKey;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TV;>;")]
		[LineNumberTable(239)]
		public virtual Set get()
		{
			Set result = Platform.newLinkedHashSetWithExpectedSize(expectedValuesPerKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 119, 104, 113 })]
		internal LinkedHashSetSupplier(int P_0)
		{
			expectedValuesPerKey = CollectPreconditions.checkNonnegative(P_0, "expectedValuesPerKey");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(229)]
		public virtual object get()
		{
			Set result = this.get();
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
		protected LinkedHashSetSupplier(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/MultimapBuilder$LinkedListSupplier;>;Lcom/google/common/base/Supplier<Ljava/util/List<*>;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[ConstantPool(new object[]
	{
		(byte)44,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier" })]
	internal sealed class LinkedListSupplier : java.lang.Enum, com.google.common.@base.Supplier, java.util.function.Supplier
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static LinkedListSupplier INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static LinkedListSupplier[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<*>;")]
		[LineNumberTable(211)]
		public virtual List get()
		{
			LinkedList result = new LinkedList();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(199)]
		private LinkedListSupplier(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(199)]
		private static LinkedListSupplier[] _0024values()
		{
			return new LinkedListSupplier[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(199)]
		public static LinkedListSupplier[] values()
		{
			return (LinkedListSupplier[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(199)]
		public static LinkedListSupplier valueOf(string P_0)
		{
			return (LinkedListSupplier)java.lang.Enum.valueOf(ClassLiteral<LinkedListSupplier>.Value, P_0);
		}

		[Signature("<V:Ljava/lang/Object;>()Lcom/google/common/base/Supplier<Ljava/util/List<TV;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 44, 0, 0 })]
		public static com.google.common.@base.Supplier instance()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(199)]
		public virtual object get()
		{
			List result = this.get();
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 160, 86, 48 })]
		static LinkedListSupplier()
		{
			INSTANCE = new LinkedListSupplier("INSTANCE", 0);
			_0024VALUES = _0024values();
		}
	}

	[Signature("<K0:Ljava/lang/Object;V0:Ljava/lang/Object;>Lcom/google/common/collect/MultimapBuilder<TK0;TV0;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 34, 0, 0,
		17, 1, 0, 0, 0, 34, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)34,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public abstract class ListMultimapBuilder : MultimapBuilder
	{
		[Signature("<K:TK0;V:TV0;>()Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
		public new abstract ListMultimap build();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:TK0;V:TV0;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
		[LineNumberTable(436)]
		public new virtual ListMultimap build(Multimap multimap)
		{
			return (ListMultimap)base.build(multimap);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(428)]
		internal ListMultimapBuilder()
			: base(null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(425)]
		public virtual Multimap _003Cbridge_003Ebuild(Multimap m)
		{
			ListMultimap result = build(m);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(425)]
		public virtual Multimap _003Cbridge_003Ebuild()
		{
			ListMultimap result = build();
			_ = null;
			return result;
		}
	}

	[Signature("<K0:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 46, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)46,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public abstract class MultimapBuilderWithKeys : java.lang.Object
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[EnclosingMethod(null, "arrayListValues", "(I)Lcom.google.common.collect.MultimapBuilder$ListMultimapBuilder;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0,
			1,
			16,
			byte.MaxValue,
			byte.MaxValue,
			1,
			3,
			1,
			0,
			31,
			0,
			0
		})]
		[ConstantPool(new object[]
		{
			(byte)31,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal class _1 : ListMultimapBuilder
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal int val_0024expectedValuesPerKey;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal MultimapBuilderWithKeys this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(299)]
			internal _1(MultimapBuilderWithKeys P_0, int P_1)
			{
				this_00240 = P_0;
				val_0024expectedValuesPerKey = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:TK0;V:Ljava/lang/Object;>()Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 31, 0, 0 })]
			[LineNumberTable(new byte[] { 160, 188, 102, 48 })]
			public override ListMultimap build()
			{
				ListMultimap result = Multimaps.newListMultimap(this_00240.createMap(), new ArrayListSupplier(val_0024expectedValuesPerKey));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 31, 0, 0 })]
			[LineNumberTable(299)]
			public new virtual Multimap build()
			{
				ListMultimap result = this.build();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[EnclosingMethod(null, "linkedListValues", "()Lcom.google.common.collect.MultimapBuilder$ListMultimapBuilder;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0,
			1,
			16,
			byte.MaxValue,
			byte.MaxValue,
			1,
			3,
			1,
			0,
			27,
			0,
			0
		})]
		[ConstantPool(new object[]
		{
			(byte)27,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal class _2 : ListMultimapBuilder
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal MultimapBuilderWithKeys this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(311)]
			internal _2(MultimapBuilderWithKeys P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:TK0;V:Ljava/lang/Object;>()Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 27, 0, 0 })]
			[LineNumberTable(new byte[] { 160, 200, 102, 42 })]
			public override ListMultimap build()
			{
				ListMultimap result = Multimaps.newListMultimap(this_00240.createMap(), LinkedListSupplier.instance());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 27, 0, 0 })]
			[LineNumberTable(311)]
			public new virtual Multimap build()
			{
				ListMultimap result = this.build();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[EnclosingMethod(null, "hashSetValues", "(I)Lcom.google.common.collect.MultimapBuilder$SetMultimapBuilder;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0,
			1,
			16,
			byte.MaxValue,
			byte.MaxValue,
			1,
			3,
			1,
			0,
			31,
			0,
			0
		})]
		[ConstantPool(new object[]
		{
			(byte)31,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal class _3 : SetMultimapBuilder
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal int val_0024expectedValuesPerKey;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal MultimapBuilderWithKeys this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(333)]
			internal _3(MultimapBuilderWithKeys P_0, int P_1)
			{
				this_00240 = P_0;
				val_0024expectedValuesPerKey = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:TK0;V:Ljava/lang/Object;>()Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 31, 0, 0 })]
			[LineNumberTable(new byte[] { 160, 222, 102, 48 })]
			public override SetMultimap build()
			{
				SetMultimap result = Multimaps.newSetMultimap(this_00240.createMap(), new HashSetSupplier(val_0024expectedValuesPerKey));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 31, 0, 0 })]
			[LineNumberTable(333)]
			public new virtual Multimap build()
			{
				SetMultimap result = this.build();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[EnclosingMethod(null, "linkedHashSetValues", "(I)Lcom.google.common.collect.MultimapBuilder$SetMultimapBuilder;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0,
			1,
			16,
			byte.MaxValue,
			byte.MaxValue,
			1,
			3,
			1,
			0,
			31,
			0,
			0
		})]
		[ConstantPool(new object[]
		{
			(byte)31,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		internal class _4 : SetMultimapBuilder
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal int val_0024expectedValuesPerKey;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal MultimapBuilderWithKeys this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(356)]
			internal _4(MultimapBuilderWithKeys P_0, int P_1)
			{
				this_00240 = P_0;
				val_0024expectedValuesPerKey = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:TK0;V:Ljava/lang/Object;>()Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 31, 0, 0 })]
			[LineNumberTable(new byte[] { 160, 245, 102, 48 })]
			public override SetMultimap build()
			{
				SetMultimap result = Multimaps.newSetMultimap(this_00240.createMap(), new LinkedHashSetSupplier(val_0024expectedValuesPerKey));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 31, 0, 0 })]
			[LineNumberTable(356)]
			public new virtual Multimap build()
			{
				SetMultimap result = this.build();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/MultimapBuilder$SortedSetMultimapBuilder<TK0;TV0;>;")]
		[EnclosingMethod(null, "treeSetValues", "(Ljava.util.Comparator;)Lcom.google.common.collect.MultimapBuilder$SortedSetMultimapBuilder;")]
		internal class _5 : SortedSetMultimapBuilder
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Comparator val_0024comparator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal MultimapBuilderWithKeys this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(381)]
			internal _5(MultimapBuilderWithKeys P_0, Comparator P_1)
			{
				this_00240 = P_0;
				val_0024comparator = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:TK0;V:TV0;>()Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 14, 102, 48 })]
			public override SortedSetMultimap build()
			{
				SortedSetMultimap result = Multimaps.newSortedSetMultimap(this_00240.createMap(), new TreeSetSupplier(val_0024comparator));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(381)]
			public new virtual SetMultimap build()
			{
				SortedSetMultimap result = this.build();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(381)]
			public new virtual Multimap build()
			{
				SortedSetMultimap result = this.build();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;TV0;>;")]
		[EnclosingMethod(null, "enumSetValues", "(Ljava.lang.Class;)Lcom.google.common.collect.MultimapBuilder$SetMultimapBuilder;")]
		internal class _6 : SetMultimapBuilder
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Class val_0024valueClass;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal MultimapBuilderWithKeys this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(393)]
			internal _6(MultimapBuilderWithKeys P_0, Class P_1)
			{
				this_00240 = P_0;
				val_0024valueClass = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("<K:TK0;V:TV0;>()Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
			[LineNumberTable(new byte[] { 161, 29, 108 })]
			public override SetMultimap build()
			{
				EnumSetSupplier factory = new EnumSetSupplier(val_0024valueClass);
				SetMultimap result = Multimaps.newSetMultimap(this_00240.createMap(), factory);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(393)]
			public new virtual Multimap build()
			{
				SetMultimap result = this.build();
				_ = null;
				return result;
			}
		}

		private const int DEFAULT_EXPECTED_VALUES_PER_KEY = 2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 46, 0, 0 })]
		[LineNumberTable(288)]
		public virtual ListMultimapBuilder arrayListValues()
		{
			ListMultimapBuilder result = arrayListValues(2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 46, 0, 0 })]
		[LineNumberTable(345)]
		public virtual SetMultimapBuilder linkedHashSetValues()
		{
			SetMultimapBuilder result = linkedHashSetValues(2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 46, 0, 0 })]
		[LineNumberTable(new byte[] { 160, 184, 108 })]
		public virtual ListMultimapBuilder arrayListValues(int expectedValuesPerKey)
		{
			CollectPreconditions.checkNonnegative(expectedValuesPerKey, "expectedValuesPerKey");
			_1 result = new _1(this, expectedValuesPerKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 46, 0, 0 })]
		[LineNumberTable(new byte[] { 160, 218, 108 })]
		public virtual SetMultimapBuilder hashSetValues(int expectedValuesPerKey)
		{
			CollectPreconditions.checkNonnegative(expectedValuesPerKey, "expectedValuesPerKey");
			_3 result = new _3(this, expectedValuesPerKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 46, 0, 0 })]
		[LineNumberTable(new byte[] { 160, 241, 108 })]
		public virtual SetMultimapBuilder linkedHashSetValues(int expectedValuesPerKey)
		{
			CollectPreconditions.checkNonnegative(expectedValuesPerKey, "expectedValuesPerKey");
			_4 result = new _4(this, expectedValuesPerKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<V0:Ljava/lang/Object;>(Ljava/util/Comparator<TV0;>;)Lcom/google/common/collect/MultimapBuilder$SortedSetMultimapBuilder<TK0;TV0;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 46, 0, 0 })]
		[LineNumberTable(new byte[] { 161, 10, 108 })]
		public virtual SortedSetMultimapBuilder treeSetValues(Comparator comparator)
		{
			Preconditions.checkNotNull((object)comparator, (object)"comparator");
			_5 result = new _5(this, comparator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(282)]
		internal MultimapBuilderWithKeys()
		{
		}

		[Modifiers(Modifiers.Abstract)]
		[Signature("<K:TK0;V:Ljava/lang/Object;>()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 1, 0, 0, 0, 46, 0, 0 })]
		internal virtual Map createMap()
		{
			throw new AbstractMethodError("com.google.common.collect.MultimapBuilder$MultimapBuilderWithKeys.createMap()Ljava.util.Map;");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/MultimapBuilder$ListMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 46, 0, 0 })]
		[LineNumberTable(311)]
		public virtual ListMultimapBuilder linkedListValues()
		{
			_2 result = new _2(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 46, 0, 0 })]
		[LineNumberTable(322)]
		public virtual SetMultimapBuilder hashSetValues()
		{
			SetMultimapBuilder result = hashSetValues(2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/MultimapBuilder$SortedSetMultimapBuilder<TK0;Ljava/lang/Comparable;>;")]
		[LineNumberTable(369)]
		public virtual SortedSetMultimapBuilder treeSetValues()
		{
			SortedSetMultimapBuilder result = treeSetValues(Ordering.natural());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<V0:Ljava/lang/Enum<TV0;>;>(Ljava/lang/Class<TV0;>;)Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;TV0;>;")]
		[LineNumberTable(new byte[] { 161, 22, 108 })]
		public virtual SetMultimapBuilder enumSetValues(Class valueClass)
		{
			Preconditions.checkNotNull((object)valueClass, (object)"valueClass");
			_6 result = new _6(this, valueClass);
			_ = null;
			return result;
		}
	}

	[Signature("<K0:Ljava/lang/Object;V0:Ljava/lang/Object;>Lcom/google/common/collect/MultimapBuilder<TK0;TV0;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 34, 0, 0,
		17, 1, 0, 0, 0, 34, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)34,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public abstract class SetMultimapBuilder : MultimapBuilder
	{
		[Signature("<K:TK0;V:TV0;>()Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
		public new abstract SetMultimap build();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:TK0;V:TV0;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
		[LineNumberTable(456)]
		public new virtual SetMultimap build(Multimap multimap)
		{
			return (SetMultimap)base.build(multimap);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(448)]
		internal SetMultimapBuilder()
			: base(null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(445)]
		public virtual Multimap _003Cbridge_003Ebuild(Multimap m)
		{
			SetMultimap result = build(m);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(445)]
		public virtual Multimap _003Cbridge_003Ebuild()
		{
			SetMultimap result = build();
			_ = null;
			return result;
		}
	}

	[Signature("<K0:Ljava/lang/Object;V0:Ljava/lang/Object;>Lcom/google/common/collect/MultimapBuilder$SetMultimapBuilder<TK0;TV0;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 37, 0, 0,
		17, 1, 0, 0, 0, 37, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)37,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public abstract class SortedSetMultimapBuilder : SetMultimapBuilder
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<K:TK0;V:TV0;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
		[LineNumberTable(476)]
		public new virtual SortedSetMultimap build(Multimap multimap)
		{
			return (SortedSetMultimap)base.build(multimap);
		}

		[Signature("<K:TK0;V:TV0;>()Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
		public new abstract SortedSetMultimap build();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(468)]
		internal SortedSetMultimapBuilder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(465)]
		public new virtual SetMultimap _003Cbridge_003Ebuild(Multimap m)
		{
			SortedSetMultimap result = build(m);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(465)]
		public new virtual SetMultimap _003Cbridge_003Ebuild()
		{
			SortedSetMultimap result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(465)]
		public override Multimap _003Cbridge_003Ebuild(Multimap m)
		{
			SortedSetMultimap result = build(m);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(465)]
		public override Multimap _003Cbridge_003Ebuild()
		{
			SortedSetMultimap result = build();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/util/SortedSet<TV;>;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 36, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)36,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal sealed class TreeSetSupplier : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TV;>;")]
		private Comparator comparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 133, 104, 113 })]
		internal TreeSetSupplier(Comparator P_0)
		{
			comparator = (Comparator)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TV;>;")]
		[LineNumberTable(253)]
		public virtual SortedSet get()
		{
			TreeSet.___003Cclinit_003E();
			TreeSet result = new TreeSet(comparator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(243)]
		public virtual object get()
		{
			SortedSet result = this.get();
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
		protected TreeSetSupplier(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	private const int DEFAULT_EXPECTED_KEYS = 8;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 61, 0, 0 })]
	[LineNumberTable(106)]
	public static MultimapBuilderWithKeys linkedHashKeys()
	{
		MultimapBuilderWithKeys result = linkedHashKeys(8);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(72)]
	private MultimapBuilder()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 61, 0, 0 })]
	[LineNumberTable(new byte[] { 38, 108 })]
	public static MultimapBuilderWithKeys hashKeys(int expectedKeys)
	{
		CollectPreconditions.checkNonnegative(expectedKeys, "expectedKeys");
		_1 result = new _1(expectedKeys);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 61, 0, 0 })]
	[LineNumberTable(new byte[] { 69, 108 })]
	public static MultimapBuilderWithKeys linkedHashKeys(int expectedKeys)
	{
		CollectPreconditions.checkNonnegative(expectedKeys, "expectedKeys");
		_2 result = new _2(expectedKeys);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K0:Ljava/lang/Object;>(Ljava/util/Comparator<TK0;>;)Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<TK0;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 61, 0, 0 })]
	[LineNumberTable(new byte[] { 108, 103 })]
	public static MultimapBuilderWithKeys treeKeys(Comparator comparator)
	{
		Preconditions.checkNotNull(comparator);
		_3 result = new _3(comparator);
		_ = null;
		return result;
	}

	[Signature("<K:TK0;V:TV0;>()Lcom/google/common/collect/Multimap<TK;TV;>;")]
	public abstract Multimap build();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 61, 0, 0 })]
	[LineNumberTable(78)]
	public static MultimapBuilderWithKeys hashKeys()
	{
		MultimapBuilderWithKeys result = hashKeys(8);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<Ljava/lang/Comparable;>;")]
	[LineNumberTable(140)]
	public static MultimapBuilderWithKeys treeKeys()
	{
		MultimapBuilderWithKeys result = treeKeys(Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K0:Ljava/lang/Enum<TK0;>;>(Ljava/lang/Class<TK0;>;)Lcom/google/common/collect/MultimapBuilder$MultimapBuilderWithKeys<TK0;>;")]
	[LineNumberTable(new byte[] { 123, 103 })]
	public static MultimapBuilderWithKeys enumKeys(Class keyClass)
	{
		Preconditions.checkNotNull(keyClass);
		_4 result = new _4(keyClass);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:TK0;V:TV0;>(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Lcom/google/common/collect/Multimap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 45, 103, 104 })]
	public virtual Multimap build(Multimap multimap)
	{
		Multimap multimap2 = build();
		multimap2.putAll(multimap);
		return multimap2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(66)]
	internal MultimapBuilder(_1 P_0)
		: this()
	{
	}
}
