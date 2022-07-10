using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.math;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.math;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableCollection<TE;>;Ljava/util/Set<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Set" })]
public abstract class ImmutableSet : ImmutableCollection, Set, Collection, Iterable, IEnumerable
{
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableCollection$Builder<TE;>;")]
	public new class Builder : ImmutableCollection.Builder
	{
		[Signature("Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private SetBuilderImpl impl;

		internal bool forceCopy;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 146, 108, 103, 102, 114 })]
		public new virtual Builder add(object element)
		{
			java.util.Objects.requireNonNull(impl);
			Preconditions.checkNotNull(element);
			copyIfNecessary();
			impl = impl.add(element);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableSet$Builder<TE;>;)Lcom/google/common/collect/ImmutableSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 183, 108, 236, 73, 102, 119 })]
		internal virtual Builder combine(Builder P_0)
		{
			java.util.Objects.requireNonNull(impl);
			java.util.Objects.requireNonNull(P_0.impl);
			copyIfNecessary();
			impl = impl.combine(P_0.impl);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
		[LineNumberTable(new byte[] { 161, 200, 108, 103, 113 })]
		public new virtual ImmutableSet build()
		{
			java.util.Objects.requireNonNull(impl);
			forceCopy = true;
			impl = impl.review();
			ImmutableSet result = impl.build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 110, 105 })]
		public Builder()
			: this(0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 178, 104 })]
		public new virtual Builder addAll(Iterator elements)
		{
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 113, 104, 100, 142, 139 })]
		internal Builder(int P_0)
		{
			if (P_0 > 0)
			{
				impl = new RegularSetBuilderImpl(P_0);
			}
			else
			{
				impl = EmptySetBuilderImpl.instance();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 139, 108, 113 })]
		internal virtual void copy()
		{
			java.util.Objects.requireNonNull(impl);
			impl = impl.copy();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 132, 104, 102, 135 })]
		internal void copyIfNecessary()
		{
			if (forceCopy)
			{
				copy();
				forceCopy = false;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 171, 104 })]
		public new virtual Builder addAll(Iterable elements)
		{
			base.addAll(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([TE;)Lcom/google/common/collect/ImmutableSet$Builder<TE;>;")]
		[LineNumberTable(new byte[] { 161, 156, 104 })]
		public new virtual Builder add(params object[] elements)
		{
			base.add(elements);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 121, 104, 103 })]
		internal Builder(bool P_0)
		{
			impl = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 127, 108, 113 })]
		internal virtual void forceJdk()
		{
			java.util.Objects.requireNonNull(impl);
			impl = new JdkBackedSetBuilderImpl(impl);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(470)]
		public virtual ImmutableCollection _003Cbridge_003Ebuild()
		{
			ImmutableSet result = build();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(470)]
		public virtual ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterator i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(470)]
		public virtual ImmutableCollection.Builder _003Cbridge_003EaddAll(Iterable i)
		{
			Builder result = addAll(i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(470)]
		public virtual ImmutableCollection.Builder _003Cbridge_003Eadd(object[] objarr)
		{
			Builder result = add(objarr);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[LineNumberTable(470)]
		public virtual ImmutableCollection.Builder _003Cbridge_003Eadd(object obj)
		{
			Builder result = add(obj);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet<TE;>;")]
	internal abstract class CachingAsList : ImmutableSet
	{
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

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		protected internal new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
		[LineNumberTable(353)]
		internal virtual ImmutableList createAsList()
		{
			RegularImmutableAsList.___003Cclinit_003E();
			RegularImmutableAsList result = new RegularImmutableAsList(this, toArray());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(339)]
		internal CachingAsList()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
		[LineNumberTable(new byte[] { 160, 230, 103, 99, 146 })]
		public override ImmutableList asList()
		{
			ImmutableList immutableList = this.m_asList;
			if (immutableList == null)
			{
				ImmutableList result = createAsList();
				this.m_asList = result;
				return result;
			}
			return immutableList;
		}

		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(338)]
		public new virtual Iterator iterator()
		{
			throw new AbstractMethodError("com.google.common.collect.ImmutableSet.iterator()Lcom.google.common.collect.UnmodifiableIterator;");
		}

		[HideFromJava]
		static CachingAsList()
		{
			ImmutableSet.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CachingAsList(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
	internal sealed class EmptySetBuilderImpl : SetBuilderImpl
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableSet$EmptySetBuilderImpl<Ljava/lang/Object;>;")]
		private static EmptySetBuilderImpl INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		internal static SetBuilderImpl instance()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 33, 105 })]
		private EmptySetBuilderImpl()
			: base(0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[LineNumberTable(664)]
		internal override SetBuilderImpl add(object P_0)
		{
			SetBuilderImpl result = new RegularSetBuilderImpl(4).add(P_0);
			_ = null;
			return result;
		}

		[Signature("()Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		internal override SetBuilderImpl copy()
		{
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
		[LineNumberTable(674)]
		internal override ImmutableSet build()
		{
			ImmutableSet result = of();
			_ = null;
			return result;
		}

		[LineNumberTable(651)]
		static EmptySetBuilderImpl()
		{
			INSTANCE = new EmptySetBuilderImpl();
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$CachingAsList<TE;>;")]
	[ConstantPool(new object[]
	{
		(byte)54,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class Indexed : CachingAsList
	{
		[Serializable]
		[SpecialName]
		[Signature("Lcom/google/common/collect/ImmutableAsList<TE;>;")]
		[EnclosingMethod(null, "createAsList", "()Lcom.google.common.collect.ImmutableList;")]
		internal class _1 : ImmutableAsList
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Indexed this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(386)]
			internal _1(Indexed P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[Signature("()Lcom/google/common/collect/ImmutableSet$Indexed<TE;>;")]
			internal new virtual Indexed delegateCollection()
			{
				return this_00240;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(I)TE;")]
			[LineNumberTable(389)]
			public override object get(int P_0)
			{
				object result = this_00240.get(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(386)]
			internal override ImmutableCollection delegateCollection()
			{
				Indexed result = delegateCollection();
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

		[SpecialName]
		private sealed class ___003C_003EAnon0 : IntFunction
		{
			private readonly Indexed arg_00241;

			internal ___003C_003EAnon0(Indexed P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(int P_0)
			{
				object result = arg_00241.get(P_0);
				_ = null;
				return result;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		protected internal new static void ___003Cclinit_003E()
		{
		}

		[Signature("(I)TE;")]
		internal abstract object get(int P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		[LineNumberTable(362)]
		public override UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = asList().iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(357)]
		internal Indexed()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TE;>;")]
		[LineNumberTable(367)]
		public override Spliterator spliterator()
		{
			Spliterator result = CollectSpliterators.indexed(size(), 1297, new ___003C_003EAnon0(this));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 2, 103, 103, 102, 45, 166 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			int num = size();
			for (int i = 0; i < num; i++)
			{
				P_0.accept(get(i));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 0, 1, 0, 0, 0, 54, 0,
			0
		})]
		[LineNumberTable(381)]
		internal override int copyIntoArray(object[] P_0, int P_1)
		{
			int result = asList().copyIntoArray(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
		[LineNumberTable(386)]
		internal override ImmutableList createAsList()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(357)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = this.iterator();
			_ = null;
			return result;
		}

		[HideFromJava]
		static Indexed()
		{
			CachingAsList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Indexed(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
	internal sealed class JdkBackedSetBuilderImpl : SetBuilderImpl
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Set<Ljava/lang/Object;>;")]
		private Set @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;)V")]
		[LineNumberTable(new byte[] { 163, 59, 105, 113, 235, 69, 249, 59, 230, 71 })]
		internal JdkBackedSetBuilderImpl(SetBuilderImpl P_0)
			: base(P_0)
		{
			@delegate = Sets.newHashSetWithExpectedSize(distinct);
			for (int i = 0; i < distinct; i++)
			{
				@delegate.add(java.util.Objects.requireNonNull(dedupedElements[i]));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[LineNumberTable(new byte[] { 163, 72, 103, 110, 135 })]
		internal override SetBuilderImpl add(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			if (@delegate.add(P_0))
			{
				addDedupedElement(P_0);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[LineNumberTable(963)]
		internal override SetBuilderImpl copy()
		{
			JdkBackedSetBuilderImpl result = new JdkBackedSetBuilderImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
		[LineNumberTable(new byte[] { 163, 86, 151, 232, 70, 149, 119, 44 })]
		internal override ImmutableSet build()
		{
			switch (distinct)
			{
			case 0:
			{
				ImmutableSet result3 = of();
				_ = null;
				return result3;
			}
			case 1:
			{
				ImmutableSet result2 = of(java.util.Objects.requireNonNull(dedupedElements[0]));
				_ = null;
				return result2;
			}
			default:
			{
				JdkBackedImmutableSet.___003Cclinit_003E();
				JdkBackedImmutableSet result = new JdkBackedImmutableSet(@delegate, ImmutableList.asImmutableList(dedupedElements, distinct));
				_ = null;
				return result;
			}
			}
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
	[ConstantPool(new object[]
	{
		(byte)45,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class RegularSetBuilderImpl : SetBuilderImpl
	{
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 19, 0, 0, 45, 0, 0, 19, 1,
			0, 0, 0, 45, 0, 0
		})]
		private object[] hashTable;

		private int m_maxRunBeforeFallback;

		private int expandTableThreshold;

		private new int hashCode;

		internal const int MAX_RUN_MULTIPLIER = 13;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 100, 105, 103, 103, 103 })]
		internal RegularSetBuilderImpl(int P_0)
			: base(P_0)
		{
			hashTable = null;
			this.m_maxRunBeforeFallback = 0;
			expandTableThreshold = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[LineNumberTable(new byte[]
		{
			162, 116, 103, 104, 104, 103, 130, 109, 105, 110,
			176
		})]
		internal override SetBuilderImpl add(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			if (hashTable == null)
			{
				if (distinct == 0)
				{
					addDedupedElement(P_0);
					return this;
				}
				ensureTableCapacity(dedupedElements.Length);
				object obj = dedupedElements[0];
				distinct--;
				SetBuilderImpl result = insertInHashTable(obj).add(P_0);
				_ = null;
				return result;
			}
			SetBuilderImpl result2 = insertInHashTable(P_0);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 219, 104, 103, 110, 119, 106, 154, 129, 108,
			119
		})]
		internal virtual void ensureTableCapacity(int P_0)
		{
			int num;
			if (hashTable == null)
			{
				num = chooseTableSize(P_0);
				hashTable = new object[num];
			}
			else
			{
				if (P_0 <= expandTableThreshold || (nint)hashTable.LongLength >= 1073741824)
				{
					return;
				}
				num = (int)((nint)hashTable.LongLength * 2);
				hashTable = rebuildHashTable(num, dedupedElements, distinct);
			}
			this.m_maxRunBeforeFallback = maxRunBeforeFallback(num);
			expandTableThreshold = ByteCodeHelper.d2i(0.7 * (double)num);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[LineNumberTable(new byte[]
		{
			162, 132, 108, 103, 103, 106, 109, 101, 107, 100,
			103, 106, 110, 108, 98, 106, 226, 54, 233, 78
		})]
		private SetBuilderImpl insertInHashTable(object P_0)
		{
			java.util.Objects.requireNonNull(hashTable);
			int num = java.lang.Object.instancehelper_hashCode(P_0);
			int num2 = Hashing.smear(num);
			int num3 = (int)((nint)hashTable.LongLength - 1);
			for (int i = num2; i - num2 < this.m_maxRunBeforeFallback; i++)
			{
				int num4 = i & num3;
				object obj = hashTable[num4];
				if (obj == null)
				{
					addDedupedElement(P_0);
					hashTable[num4] = P_0;
					hashCode += num;
					ensureTableCapacity(distinct);
					return this;
				}
				if (java.lang.Object.instancehelper_equals(obj, P_0))
				{
					return this;
				}
			}
			SetBuilderImpl result = new JdkBackedSetBuilderImpl(this).add(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableSet$RegularSetBuilderImpl<TE;>;)V")]
		[LineNumberTable(new byte[] { 162, 107, 105, 127, 2, 108, 108, 108 })]
		internal RegularSetBuilderImpl(RegularSetBuilderImpl P_0)
			: base(P_0)
		{
			hashTable = ((P_0.hashTable != null) ? ((object[])P_0.hashTable.Clone()) : null);
			this.m_maxRunBeforeFallback = P_0.m_maxRunBeforeFallback;
			expandTableThreshold = P_0.expandTableThreshold;
			hashCode = P_0.hashCode;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 45, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			162, 200, 103, 101, 134, 105, 109, 100, 102, 102,
			101, 226, 60, 232, 60, 230, 76
		})]
		internal static object[] rebuildHashTable(int P_0, object[] P_1, int P_2)
		{
			object[] array = new object[P_0];
			int num = (int)((nint)array.LongLength - 1);
			for (int i = 0; i < P_2; i++)
			{
				object obj = java.util.Objects.requireNonNull(P_1[i]);
				int num2 = Hashing.smear(java.lang.Object.instancehelper_hashCode(obj));
				int num3 = num2;
				int num4;
				while (true)
				{
					num4 = num3 & num;
					if (array[num4] == null)
					{
						break;
					}
					num3++;
				}
				array[num4] = obj;
			}
			return array;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(930)]
		internal static int maxRunBeforeFallback(int P_0)
		{
			return 13 * IntMath.log2(P_0, RoundingMode.UNNECESSARY);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 22, 0, 1, 0, 0, 0, 45, 0,
			0
		})]
		[LineNumberTable(new byte[]
		{
			163, 5, 104, 229, 70, 98, 162, 104, 105, 203,
			134, 164, 132, 108, 104, 100, 101, 229, 60, 232,
			71, 162
		})]
		internal static bool hashFloodingDetected(object[] P_0)
		{
			int num = maxRunBeforeFallback(P_0.Length);
			int num2 = (int)((nint)P_0.LongLength - 1);
			int num3 = 0;
			int num4 = 0;
			while (num3 < (nint)P_0.LongLength)
			{
				if (num3 == num4 && P_0[num3] == null)
				{
					num3 = ((P_0[(num3 + num - 1) & num2] != null) ? (num3 + 1) : (num3 + num));
					num4 = num3;
					continue;
				}
				int num5 = num3 + num - 1;
				while (true)
				{
					if (num5 >= num4)
					{
						if (P_0[num5 & num2] == null)
						{
							break;
						}
						num5 += -1;
						continue;
					}
					return true;
				}
				num4 = num3 + num;
				num3 = num5 + 1;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[LineNumberTable(781)]
		internal override SetBuilderImpl copy()
		{
			RegularSetBuilderImpl result = new RegularSetBuilderImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[LineNumberTable(new byte[] { 162, 160, 104, 130, 108, 108, 120, 108, 151 })]
		internal override SetBuilderImpl review()
		{
			if (hashTable == null)
			{
				return this;
			}
			int num = chooseTableSize(distinct);
			if (num * 2 < (nint)hashTable.LongLength)
			{
				hashTable = rebuildHashTable(num, dedupedElements, distinct);
				this.m_maxRunBeforeFallback = maxRunBeforeFallback(num);
				expandTableThreshold = ByteCodeHelper.d2i(0.7 * (double)num);
			}
			return (!hashFloodingDetected(hashTable)) ? ((SetBuilderImpl)this) : ((SetBuilderImpl)new JdkBackedSetBuilderImpl(this));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
		[LineNumberTable(new byte[]
		{
			162, 174, 151, 232, 70, 245, 72, 111, 104, 114,
			114, 58
		})]
		internal override ImmutableSet build()
		{
			switch (distinct)
			{
			case 0:
			{
				ImmutableSet result3 = of();
				_ = null;
				return result3;
			}
			case 1:
			{
				ImmutableSet result2 = of(java.util.Objects.requireNonNull(dedupedElements[0]));
				_ = null;
				return result2;
			}
			default:
			{
				object[] array = (((nint)distinct != (nint)dedupedElements.LongLength) ? Arrays.copyOf(dedupedElements, distinct) : dedupedElements);
				RegularImmutableSet.___003Cclinit_003E();
				RegularImmutableSet result = new RegularImmutableSet(array, hashCode, (object[])java.util.Objects.requireNonNull(hashTable), (int)((nint)hashTable.LongLength - 1));
				_ = null;
				return result;
			}
			}
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Final)]
		internal object[] elements;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 40, 104, 103 })]
		internal SerializedForm(object[] P_0)
		{
			elements = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(415)]
		internal virtual object readResolve()
		{
			ImmutableSet result = copyOf(elements);
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal abstract class SetBuilderImpl : java.lang.Object
	{
		[Signature("[TE;")]
		internal object[] dedupedElements;

		internal int distinct;

		[Signature("(TE;)Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		internal abstract SetBuilderImpl add(object P_0);

		[Signature("()Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		internal virtual SetBuilderImpl review()
		{
			return this;
		}

		[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
		internal abstract ImmutableSet build();

		[Signature("()Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		internal abstract SetBuilderImpl copy();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;)Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;")]
		[LineNumberTable(new byte[] { 161, 252, 98, 235, 69, 244, 59, 230, 71 })]
		internal SetBuilderImpl combine(SetBuilderImpl P_0)
		{
			SetBuilderImpl setBuilderImpl = this;
			for (int i = 0; i < P_0.distinct; i++)
			{
				setBuilderImpl = setBuilderImpl.add(java.util.Objects.requireNonNull(P_0.dedupedElements[i]));
			}
			return setBuilderImpl;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 231, 106, 104, 102, 146 })]
		private void ensureCapacity(int P_0)
		{
			if (P_0 > (nint)dedupedElements.LongLength)
			{
				int newLength = ImmutableCollection.Builder.expandedCapacity(dedupedElements.Length, P_0);
				dedupedElements = Arrays.copyOf(dedupedElements, newLength);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 215, 104, 108, 103 })]
		internal SetBuilderImpl(int P_0)
		{
			dedupedElements = new object[P_0];
			distinct = 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableSet$SetBuilderImpl<TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 221, 104, 120, 108 })]
		internal SetBuilderImpl(SetBuilderImpl P_0)
		{
			dedupedElements = Arrays.copyOf(P_0.dedupedElements, P_0.dedupedElements.Length);
			distinct = P_0.distinct;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)V")]
		[LineNumberTable(new byte[] { 161, 240, 110, 123 })]
		internal void addDedupedElement(object P_0)
		{
			ensureCapacity(distinct + 1);
			object[] array = dedupedElements;
			int num = distinct;
			distinct = num + 1;
			array[num] = P_0;
		}
	}

	internal new const int SPLITERATOR_CHARACTERISTICS = 1297;

	internal const int MAX_TABLE_SIZE = 1073741824;

	private const double DESIRED_LOAD_FACTOR = 0.7;

	private const int CUTOFF = 751619276;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(80)]
	public static ImmutableSet of()
	{
		return RegularImmutableSet.EMPTY;
	}

	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	public abstract override UnmodifiableIterator iterator();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSet$Builder<TE;>;")]
	[LineNumberTable(431)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(II[Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[]
	{
		160, 79, 146, 168, 100, 137, 103, 134, 105, 232,
		61, 230, 69
	})]
	private static ImmutableSet construct(int P_0, int P_1, params object[] P_2)
	{
		switch (P_0)
		{
		case 0:
		{
			ImmutableSet result3 = of();
			_ = null;
			return result3;
		}
		case 1:
		{
			object element = P_2[0];
			ImmutableSet result2 = of(element);
			_ = null;
			return result2;
		}
		default:
		{
			SetBuilderImpl setBuilderImpl = new RegularSetBuilderImpl(P_1);
			for (int i = 0; i < P_0; i++)
			{
				object obj = Preconditions.checkNotNull(P_2[i]);
				setBuilderImpl = setBuilderImpl.add(obj);
			}
			ImmutableSet result = setBuilderImpl.review().build();
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(89)]
	public static ImmutableSet of(object element)
	{
		SingletonImmutableSet result = new SingletonImmutableSet(element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(304)]
	private static ImmutableSet copyOfEnumSet(EnumSet P_0)
	{
		ImmutableSet result = ImmutableEnumSet.asImmutable(EnumSet.copyOf(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I[Ljava/lang/Object;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[] { 120, 200, 5, 6 })]
	private static ImmutableSet constructUnknownDuplication(int P_0, params object[] P_1)
	{
		ImmutableSet result = construct(P_0, java.lang.Math.max(4, IntMath.sqrt(P_0, RoundingMode.CEILING)), P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<+TE;>;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[]
	{
		160, 115, 144, 103, 104, 130, 106, 142, 103, 136,
		141
	})]
	public static ImmutableSet copyOf(Collection elements)
	{
		if (elements is ImmutableSet && !(elements is SortedSet))
		{
			ImmutableSet immutableSet = (ImmutableSet)elements;
			if (!immutableSet.isPartialView())
			{
				return immutableSet;
			}
		}
		else if (elements is EnumSet)
		{
			ImmutableSet result = copyOfEnumSet((EnumSet)elements);
			_ = null;
			return result;
		}
		object[] array = elements.toArray();
		if (elements is Set)
		{
			ImmutableSet result2 = construct(array.Length, array.Length, array);
			_ = null;
			return result2;
		}
		ImmutableSet result3 = constructUnknownDuplication(array.Length, array);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Iterator<+TE;>;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 159, 104, 136, 103, 104, 137 })]
	public static ImmutableSet copyOf(Iterator elements)
	{
		if (!elements.hasNext())
		{
			ImmutableSet result = of();
			_ = null;
			return result;
		}
		object element = elements.next();
		if (!elements.hasNext())
		{
			ImmutableSet result2 = of(element);
			_ = null;
			return result2;
		}
		ImmutableSet result3 = new Builder().add(element).addAll(elements).build();
		_ = null;
		return result3;
	}

	internal virtual bool isHashCodeFast()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(330)]
	public override int hashCode()
	{
		int result = Sets.hashCodeImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableSet<TE;>;>;")]
	[LineNumberTable(69)]
	public static Collector toImmutableSet()
	{
		Collector result = CollectCollectors.toImmutableSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(98)]
	public static ImmutableSet of(object e1, object e2)
	{
		ImmutableSet result = construct(2, 2, e1, e2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(107)]
	public static ImmutableSet of(object e1, object e2, object e3)
	{
		ImmutableSet result = construct(3, 3, e1, e2, e3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(116)]
	public static ImmutableSet of(object e1, object e2, object e3, object e4)
	{
		ImmutableSet result = construct(4, 4, e1, e2, e3, e4);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(125)]
	public static ImmutableSet of(object e1, object e2, object e3, object e4, object e5)
	{
		ImmutableSet result = construct(5, 5, e1, e2, e3, e4, e5);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;TE;TE;TE;TE;TE;[TE;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[]
	{
		89, 151, 98, 107, 100, 100, 100, 100, 101, 101,
		109
	})]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static ImmutableSet of(object e1, object e2, object e3, object e4, object e5, object e6, params object[] others)
	{
		Preconditions.checkArgument((nint)others.LongLength <= 2147483641, (object)"the total number of elements must fit in an int");
		_ = 6;
		object[] array = new object[6 + (nint)others.LongLength];
		array[0] = e1;
		array[1] = e2;
		array[2] = e3;
		array[3] = e4;
		array[4] = e5;
		array[5] = e6;
		ByteCodeHelper.arraycopy(others, 0, array, 6, others.Length);
		ImmutableSet result = construct(array.Length, array.Length, array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 146, 104, 109, 13 })]
	public static ImmutableSet copyOf(Iterable elements)
	{
		ImmutableSet result = ((!(elements is Collection)) ? copyOf(elements.iterator()) : copyOf((Collection)elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(new byte[] { 160, 178, 147, 136, 139 })]
	public static ImmutableSet copyOf(object[] elements)
	{
		switch (elements.LongLength)
		{
		case 0L:
		{
			ImmutableSet result3 = of();
			_ = null;
			return result3;
		}
		case 1L:
		{
			ImmutableSet result2 = of(elements[0]);
			_ = null;
			return result2;
		}
		default:
		{
			ImmutableSet result = constructUnknownDuplication(elements.Length, (object[])elements.Clone());
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(307)]
	internal ImmutableSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 202, 100, 130, 105, 109, 104, 109, 130 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		if (@object == this)
		{
			return true;
		}
		if (@object is ImmutableSet && isHashCodeFast() && ((ImmutableSet)@object).isHashCodeFast() && hashCode() != java.lang.Object.instancehelper_hashCode(@object))
		{
			return false;
		}
		bool result = Sets.equalsImpl(this, @object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(423)]
	internal override object writeReplace()
	{
		SerializedForm result = new SerializedForm(toArray());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Lcom/google/common/collect/ImmutableSet$Builder<TE;>;")]
	[LineNumberTable(new byte[] { 161, 78, 108 })]
	public static Builder builderWithExpectedSize(int expectedSize)
	{
		CollectPreconditions.checkNonnegative(expectedSize, "expectedSize");
		Builder result = new Builder(expectedSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 68, 137, 136, 107, 112, 134, 194, 114 })]
	internal static int chooseTableSize(int P_0)
	{
		P_0 = java.lang.Math.max(P_0, 2);
		if (P_0 < 751619276)
		{
			int num = Integer.highestOneBit(P_0 - 1) << 1;
			while ((double)num * 0.7 < (double)P_0)
			{
				num <<= 1;
			}
			return num;
		}
		Preconditions.checkArgument(P_0 < 1073741824, (object)"collection too large");
		return 1073741824;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(53)]
	public override Iterator _003Cbridge_003Eiterator()
	{
		UnmodifiableIterator result = iterator();
		_ = null;
		return result;
	}

	[HideFromJava]
	static ImmutableSet()
	{
		ImmutableCollection.___003Cclinit_003E();
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	Iterator Set.Set_003A_003Aiterator()
	{
		return _003Cbridge_003Eiterator();
	}

	bool Set.Set_003A_003AisEmpty()
	{
		return isEmpty();
	}

	int Set.Set_003A_003Asize()
	{
		return size();
	}

	bool Set.Set_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
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
	protected ImmutableSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
