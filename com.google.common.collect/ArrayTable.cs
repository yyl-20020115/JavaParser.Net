using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractTable<TR;TC;TV;>;Ljava/io/Serializable;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0,
	1,
	16,
	byte.MaxValue,
	byte.MaxValue,
	1,
	3,
	2,
	0,
	97,
	0,
	0
})]
[ConstantPool(new object[]
{
	(byte)97,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class ArrayTable : AbstractTable, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/AbstractIndexedListIterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[EnclosingMethod(null, "cellIterator", "()Ljava.util.Iterator;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		2,
		3,
		0,
		3,
		2,
		0,
		28,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)28,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal new class _1 : AbstractIndexedListIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ArrayTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 2, 0, 28, 0, 0 })]
		[LineNumberTable(565)]
		protected internal new virtual Table.Cell get(int P_0)
		{
			Table.Cell result = access_0024000(this_00240, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(562)]
		internal _1(ArrayTable P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 2, 0, 28, 0, 0 })]
		[LineNumberTable(562)]
		protected internal override object get(int P_0)
		{
			Table.Cell result = get(P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/Tables$AbstractCell<TR;TC;TV;>;")]
	[EnclosingMethod(null, "getCell", "(I)Lcom.google.common.collect.Table$Cell;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		1,
		3,
		2,
		0,
		43,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)43,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _2 : Tables.AbstractCell
	{
		[Modifiers(Modifiers.Final)]
		internal int rowIndex;

		[Modifiers(Modifiers.Final)]
		internal int columnIndex;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024index;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ArrayTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 207, 118, 127, 6 })]
		internal _2(ArrayTable P_0, int P_1)
		{
			this_00240 = P_0;
			val_0024index = P_1;
			base._002Ector();
			int num = val_0024index;
			int num2 = access_0024100(this_00240).size();
			rowIndex = ((num2 != -1) ? (num / num2) : (-num));
			int num3 = val_0024index;
			int num4 = access_0024100(this_00240).size();
			columnIndex = ((num4 != -1) ? (num3 % num4) : 0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TR;")]
		[LineNumberTable(583)]
		public override object getRowKey()
		{
			object result = access_0024200(this_00240).get(rowIndex);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TC;")]
		[LineNumberTable(588)]
		public override object getColumnKey()
		{
			object result = access_0024100(this_00240).get(columnIndex);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TV;")]
		[LineNumberTable(594)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object getValue()
		{
			object result = this_00240.at(rowIndex, columnIndex);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/AbstractIndexedListIterator<TV;>;")]
	[EnclosingMethod(null, "valuesIterator", "()Ljava.util.Iterator;")]
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
		30,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)30,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _3 : AbstractIndexedListIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ArrayTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(812)]
		internal _3(ArrayTable P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(816)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object get(int P_0)
		{
			object result = access_0024800(this_00240, P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$IteratorBasedAbstractMap<TK;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 1, 0, 0, 0, 117, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)117,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class ArrayMap : Maps.IteratorBasedAbstractMap
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractMapEntry<TK;TV;>;")]
		[EnclosingMethod(null, "getEntry", "(I)Ljava.util.Map$Entry;")]
		internal new class _1 : AbstractMapEntry
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal int val_0024index;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ArrayMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(228)]
			internal _1(ArrayMap P_0, int P_1)
			{
				this_00240 = P_0;
				val_0024index = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TK;")]
			[LineNumberTable(231)]
			public override object getKey()
			{
				object key = this_00240.getKey(val_0024index);
				_ = null;
				return key;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TV;")]
			[LineNumberTable(237)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public override object getValue()
			{
				object value = this_00240.getValue(val_0024index);
				_ = null;
				return value;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TV;)TV;")]
			[LineNumberTable(243)]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public override object setValue([ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})] object P_0)
			{
				object result = this_00240.setValue(val_0024index, P_0);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIndexedListIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal class _2 : AbstractIndexedListIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ArrayMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(250)]
			internal _2(ArrayMap P_0, int P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(I)Ljava/util/Map$Entry<TK;TV;>;")]
			[LineNumberTable(253)]
			protected internal new virtual Map.Entry get(int P_0)
			{
				Map.Entry entry = this_00240.getEntry(P_0);
				_ = null;
				return entry;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(250)]
			protected internal override object get(int P_0)
			{
				Map.Entry result = get(P_0);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : IntFunction
		{
			private readonly ArrayMap arg_00241;

			internal ___003C_003EAnon0(ArrayMap P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(int P_0)
			{
				Map.Entry entry = arg_00241.getEntry(P_0);
				_ = null;
				return entry;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableMap<TK;Ljava/lang/Integer;>;")]
		private ImmutableMap keyIndex;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TK;")]
		[LineNumberTable(205)]
		internal virtual object getKey(int P_0)
		{
			object result = keyIndex.keySet().asList().get(P_0);
			_ = null;
			return result;
		}

		[Signature("(I)TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal abstract object getValue(int P_0);

		[Signature("(ITV;)TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal abstract object setValue(int P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableMap<TK;Ljava/lang/Integer;>;)V")]
		[LineNumberTable(new byte[] { 160, 81, 104, 103 })]
		private ArrayMap(ImmutableMap P_0)
		{
			keyIndex = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(218)]
		public override int size()
		{
			int result = keyIndex.size();
			_ = null;
			return result;
		}

		internal abstract string getKeyRole();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/Map$Entry<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 113, 109 })]
		internal virtual Map.Entry getEntry(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			_1 result = new _1(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TK;>;")]
		[LineNumberTable(201)]
		public override Set keySet()
		{
			ImmutableSet result = keyIndex.keySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(223)]
		public override bool isEmpty()
		{
			bool result = keyIndex.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(250)]
		internal override Iterator entryIterator()
		{
			_2 result = new _2(this, size());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(260)]
		internal override Spliterator entrySpliterator()
		{
			Spliterator result = CollectSpliterators.indexed(size(), 16, new ___003C_003EAnon0(this));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(267)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = keyIndex.containsKey(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 160, 159, 114, 99, 130 })]
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
			Integer integer = (Integer)keyIndex.get(P_0);
			if (integer == null)
			{
				return null;
			}
			object value = getValue(integer.intValue());
			_ = null;
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)TV;")]
		[LineNumberTable(new byte[] { 160, 170, 114, 102, 97, 159, 104 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put(object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			Integer integer = (Integer)keyIndex.get(P_0);
			if (integer == null)
			{
				string keyRole = getKeyRole();
				string text = java.lang.String.valueOf(P_0);
				string text2 = java.lang.String.valueOf(keyIndex.keySet());
				int num = 9 + java.lang.String.instancehelper_length(java.lang.String.valueOf(keyRole)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
				num = num;
				string s = new StringBuilder(num).append(keyRole).append(" ").append(text)
					.append(" not in ")
					.append(text2)
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
			object result = setValue(integer.intValue(), P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(295)]
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
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(300)]
		public override void clear()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(191)]
		internal ArrayMap(ImmutableMap P_0, ArrayTable._1 P_1)
			: this(P_0)
		{
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/ArrayTable$ArrayMap<TR;TV;>;")]
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
		46,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)46,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class Column : ArrayMap
	{
		[Modifiers(Modifiers.Final)]
		internal int columnIndex;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ArrayTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 5, 103, 111, 103 })]
		internal Column(ArrayTable P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector(access_0024300(P_0), null);
			columnIndex = P_1;
		}

		internal override string getKeyRole()
		{
			return "Row";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(644)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object getValue(int P_0)
		{
			object result = this_00240.at(P_0, columnIndex);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITV;)TV;")]
		[LineNumberTable(650)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object setValue(int P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			object result = this_00240.set(P_0, columnIndex, P_1);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/ArrayTable$ArrayMap<TC;Ljava/util/Map<TR;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		2,
		3,
		1,
		3,
		1,
		0,
		38,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)38,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ColumnMap : ArrayMap
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ArrayTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(674)]
		internal ColumnMap(ArrayTable P_0, ArrayTable._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 49, 103, 111 })]
		private ColumnMap(ArrayTable P_0)
		{
			this_00240 = P_0;
			base._002Ector(access_0024600(P_0), null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;Ljava/util/Map<TR;TV;>;)Ljava/util/Map<TR;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 1, 0, 38, 0, 0,
			22, 1, 1, 3, 1, 0, 38, 0, 0
		})]
		[LineNumberTable(697)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map put(object P_0, Map P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILjava/util/Map<TR;TV;>;)Ljava/util/Map<TR;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 1, 0, 38, 0, 0,
			22, 1, 1, 3, 1, 0, 38, 0, 0
		})]
		[LineNumberTable(691)]
		internal virtual Map setValue(int P_0, Map P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/Map<TR;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 38, 0, 0 })]
		[LineNumberTable(686)]
		internal new virtual Map getValue(int P_0)
		{
			Column result = new Column(this_00240, P_0);
			_ = null;
			return result;
		}

		internal override string getKeyRole()
		{
			return "Column";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 1, 0, 38, 0, 0,
			22, 1, 1, 3, 1, 0, 38, 0, 0
		})]
		[LineNumberTable(673)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put(object P_0, object P_1)
		{
			Map result = put(P_0, (Map)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 1, 0, 38, 0, 0,
			22, 1, 1, 3, 1, 0, 38, 0, 0
		})]
		[LineNumberTable(673)]
		internal override object setValue(int P_0, object P_1)
		{
			Map result = setValue(P_0, (Map)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 38, 0, 0 })]
		[LineNumberTable(673)]
		internal override object getValue(int P_0)
		{
			Map value = getValue(P_0);
			_ = null;
			return value;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/ArrayTable$ArrayMap<TC;TV;>;")]
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
		46,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)46,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class Row : ArrayMap
	{
		[Modifiers(Modifiers.Final)]
		internal int rowIndex;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ArrayTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 100, 103, 111, 103 })]
		internal Row(ArrayTable P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector(access_0024600(P_0), null);
			rowIndex = P_1;
		}

		internal override string getKeyRole()
		{
			return "Column";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(739)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object getValue(int P_0)
		{
			object result = this_00240.at(rowIndex, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ITV;)TV;")]
		[LineNumberTable(745)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object setValue(int P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			object result = this_00240.set(rowIndex, P_0, P_1);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/ArrayTable$ArrayMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		2,
		3,
		1,
		3,
		1,
		0,
		38,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)38,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class RowMap : ArrayMap
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ArrayTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(769)]
		internal RowMap(ArrayTable P_0, ArrayTable._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 144, 103, 111 })]
		private RowMap(ArrayTable P_0)
		{
			this_00240 = P_0;
			base._002Ector(access_0024300(P_0), null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;Ljava/util/Map<TC;TV;>;)Ljava/util/Map<TC;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 1, 0, 38, 0, 0,
			22, 1, 1, 3, 1, 0, 38, 0, 0
		})]
		[LineNumberTable(792)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map put(object P_0, Map P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(ILjava/util/Map<TC;TV;>;)Ljava/util/Map<TC;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 1, 0, 38, 0, 0,
			22, 1, 1, 3, 1, 0, 38, 0, 0
		})]
		[LineNumberTable(786)]
		internal virtual Map setValue(int P_0, Map P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Ljava/util/Map<TC;TV;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 38, 0, 0 })]
		[LineNumberTable(781)]
		internal new virtual Map getValue(int P_0)
		{
			Row result = new Row(this_00240, P_0);
			_ = null;
			return result;
		}

		internal override string getKeyRole()
		{
			return "Row";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 1, 0, 38, 0, 0,
			22, 1, 1, 3, 1, 0, 38, 0, 0
		})]
		[LineNumberTable(768)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put(object P_0, object P_1)
		{
			Map result = put(P_0, (Map)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 20, 1, 3, 1, 0, 38, 0, 0,
			22, 1, 1, 3, 1, 0, 38, 0, 0
		})]
		[LineNumberTable(768)]
		internal override object setValue(int P_0, object P_1)
		{
			Map result = setValue(P_0, (Map)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 38, 0, 0 })]
		[LineNumberTable(768)]
		internal override object getValue(int P_0)
		{
			Map value = getValue(P_0);
			_ = null;
			return value;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : IntFunction
	{
		private readonly ArrayTable arg_00241;

		internal ___003C_003EAnon0(ArrayTable P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(int P_0)
		{
			Table.Cell cell = arg_00241.getCell(P_0);
			_ = null;
			return cell;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : IntFunction
	{
		private readonly ArrayTable arg_00241;

		internal ___003C_003EAnon1(ArrayTable P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(int P_0)
		{
			object value = arg_00241.getValue(P_0);
			_ = null;
			return value;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<TR;>;")]
	private ImmutableList rowList;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<TC;>;")]
	private ImmutableList columnList;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TR;Ljava/lang/Integer;>;")]
	private ImmutableMap rowKeyToIndex;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TC;Ljava/lang/Integer;>;")]
	private ImmutableMap columnKeyToIndex;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("[[TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 19, 2, 0, 0, 0, 0, 0, 97,
		0, 0
	})]
	private object[][] array;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ArrayTable<TR;TC;TV;>.ColumnMap;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new ColumnMap m_columnMap;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/ArrayTable<TR;TC;TV;>.RowMap;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new RowMap m_rowMap;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(95)]
	internal static Table.Cell access_0024000(ArrayTable P_0, int P_1)
	{
		Table.Cell cell = P_0.getCell(P_1);
		_ = null;
		return cell;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TV;")]
	[LineNumberTable(new byte[] { 161, 231, 118, 119 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object getValue(int P_0)
	{
		int num = columnList.size();
		int rowIndex = ((num != -1) ? (P_0 / num) : (-P_0));
		int num2 = columnList.size();
		int columnIndex = ((num2 != -1) ? (P_0 % num2) : 0);
		object result = at(rowIndex, columnIndex);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 2, 0, 97, 0, 0 })]
	[LineNumberTable(577)]
	private Table.Cell getCell(int P_0)
	{
		_2 result = new _2(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TR;>;Ljava/lang/Iterable<+TC;>;)V")]
	[LineNumberTable(new byte[]
	{
		100, 104, 108, 108, 253, 72, 113, 209, 127, 25,
		135, 104
	})]
	private ArrayTable(Iterable P_0, Iterable P_1)
	{
		rowList = ImmutableList.copyOf(P_0);
		columnList = ImmutableList.copyOf(P_1);
		Preconditions.checkArgument(rowList.isEmpty() == columnList.isEmpty());
		rowKeyToIndex = Maps.indexMap(rowList);
		columnKeyToIndex = Maps.indexMap(columnList);
		int num = rowList.size();
		int num2 = columnList.size();
		int[] array = new int[2];
		int num3 = (array[1] = num2);
		num3 = (array[0] = num);
		object[][] array2 = (this.array = (object[][])ByteCodeHelper.multianewarray(typeof(object[][]).TypeHandle, array));
		eraseAll();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ArrayTable<TR;TC;TV;>;)V")]
	[LineNumberTable(new byte[]
	{
		127, 104, 108, 108, 108, 172, 127, 25, 103, 114,
		62, 168
	})]
	private ArrayTable(ArrayTable P_0)
	{
		rowList = P_0.rowList;
		columnList = P_0.columnList;
		rowKeyToIndex = P_0.rowKeyToIndex;
		columnKeyToIndex = P_0.columnKeyToIndex;
		int num = rowList.size();
		int num2 = columnList.size();
		int[] array = new int[2];
		int num3 = (array[1] = num2);
		num3 = (array[0] = num);
		object[][] array2 = (this.array = (object[][])ByteCodeHelper.multianewarray(typeof(object[][]).TypeHandle, array));
		for (int i = 0; i < rowList.size(); i++)
		{
			ByteCodeHelper.arraycopy(P_0.array[i], 0, array2[i], 0, P_0.array[i].Length);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Table<TR;TC;+TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 2, 3, 2, 2, 0, 0,
		97, 0, 0
	})]
	[LineNumberTable(new byte[] { 123, 116, 105 })]
	private ArrayTable(Table P_0)
		: this(P_0.rowKeySet(), P_0.columnKeySet())
	{
		putAll(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 29, 116, 39, 166 })]
	public virtual void eraseAll()
	{
		object[][] array = this.array;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			object[] a = array[i];
			Arrays.fill(a, null);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 2, 3, 2, 2, 0, 0,
		97, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 125, 105 })]
	public override void putAll(Table table)
	{
		base.putAll(table);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(428)]
	public override bool containsRow([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey)
	{
		bool result = rowKeyToIndex.containsKey(rowKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(419)]
	public override bool containsColumn([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		bool result = columnKeyToIndex.containsKey(columnKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)TV;")]
	[LineNumberTable(new byte[] { 160, 221, 114, 114 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object at(int rowIndex, int columnIndex)
	{
		Preconditions.checkElementIndex(rowIndex, rowList.size());
		Preconditions.checkElementIndex(columnIndex, columnList.size());
		return array[rowIndex][columnIndex];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(IITV;)TV;")]
	[LineNumberTable(new byte[] { 160, 243, 114, 114, 107, 107 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object set(int rowIndex, int columnIndex, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		Preconditions.checkElementIndex(rowIndex, rowList.size());
		Preconditions.checkElementIndex(columnIndex, columnList.size());
		object result = array[rowIndex][columnIndex];
		array[rowIndex][columnIndex] = value;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(541)]
	public override int size()
	{
		return rowList.size() * columnList.size();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TC;>;")]
	[LineNumberTable(662)]
	public new virtual ImmutableSet columnKeySet()
	{
		ImmutableSet result = columnKeyToIndex.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TR;>;")]
	[LineNumberTable(757)]
	public new virtual ImmutableSet rowKeySet()
	{
		ImmutableSet result = rowKeyToIndex.keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+TR;>;Ljava/lang/Iterable<+TC;>;)Lcom/google/common/collect/ArrayTable<TR;TC;TV;>;")]
	[LineNumberTable(109)]
	public static ArrayTable create(Iterable rowKeys, Iterable columnKeys)
	{
		ArrayTable result = new ArrayTable(rowKeys, columnKeys);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Table<TR;TC;+TV;>;)Lcom/google/common/collect/ArrayTable<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 2, 3, 2, 2, 0, 0,
		97, 0, 0
	})]
	[LineNumberTable(new byte[] { 87, 104, 109, 8 })]
	public static ArrayTable create(Table table)
	{
		ArrayTable result = ((!(table is ArrayTable)) ? new ArrayTable(table) : new ArrayTable((ArrayTable)table));
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableList<TR;>;")]
	public virtual ImmutableList rowKeyList()
	{
		return rowList;
	}

	[Signature("()Lcom/google/common/collect/ImmutableList<TC;>;")]
	public virtual ImmutableList columnKeyList()
	{
		return columnList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<TV;>;)[[TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 20, 2, 0, 0, 0, 0, 0, 97,
		0, 0
	})]
	[LineNumberTable(new byte[] { 161, 7, 127, 15, 112, 59, 166 })]
	public virtual object[][] toArray(Class valueClass)
	{
		object[][] array = (object[][])java.lang.reflect.Array.newInstance(valueClass, rowList.size(), columnList.size());
		for (int i = 0; i < rowList.size(); i++)
		{
			ByteCodeHelper.arraycopy(this.array[i], 0, array[i], 0, this.array[i].Length);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(394)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override void clear()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(410)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		return (containsRow(rowKey) && containsColumn(columnKey)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 63, 116, 120, 106, 2, 40, 230, 71 })]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		object[][] array = this.array;
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			object[] array2 = array[i];
			object[] array3 = array2;
			int num2 = array3.Length;
			for (int j = 0; j < num2; j++)
			{
				object b = array3[j];
				if (com.google.common.@base.Objects.equal(value, b))
				{
					return true;
				}
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 161, 76, 114, 114 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		Integer integer = (Integer)rowKeyToIndex.get(rowKey);
		Integer integer2 = (Integer)columnKeyToIndex.get(columnKey);
		object result = ((integer != null && integer2 != null) ? at(integer.intValue(), integer2.intValue()) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(456)]
	public override bool isEmpty()
	{
		return (rowList.isEmpty() || columnList.isEmpty()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;TC;TV;)TV;")]
	[LineNumberTable(new byte[] { 161, 99, 103, 103, 114, 120, 114, 120 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object put(object rowKey, object columnKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		Preconditions.checkNotNull(rowKey);
		Preconditions.checkNotNull(columnKey);
		Integer integer = (Integer)rowKeyToIndex.get(rowKey);
		Preconditions.checkArgument(integer != null, "Row %s not in %s", rowKey, rowList);
		Integer integer2 = (Integer)columnKeyToIndex.get(columnKey);
		Preconditions.checkArgument(integer2 != null, "Column %s not in %s", columnKey, columnList);
		object result = set(integer.intValue(), integer2.intValue(), value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(510)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 161, 159, 114, 114, 102, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object erase([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		Integer integer = (Integer)rowKeyToIndex.get(rowKey);
		Integer integer2 = (Integer)columnKeyToIndex.get(columnKey);
		if (integer == null || integer2 == null)
		{
			return null;
		}
		object result = set(integer.intValue(), integer2.intValue(), null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 20, 2, 3, 0, 3, 2, 0, 97,
		0, 0
	})]
	[LineNumberTable(557)]
	public override Set cellSet()
	{
		Set result = base.cellSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 20, 2, 3, 0, 3, 2, 0, 97,
		0, 0
	})]
	[LineNumberTable(562)]
	internal override Iterator cellIterator()
	{
		_1 result = new _1(this, size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 20, 2, 3, 0, 3, 2, 0, 97,
		0, 0
	})]
	[LineNumberTable(new byte[] { 161, 202, 97, 53 })]
	internal override Spliterator cellSpliterator()
	{
		Spliterator result = CollectSpliterators.indexed(size(), 273, new ___003C_003EAnon0(this));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Ljava/util/Map<TR;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 97, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 249, 103, 114, 99, 136 })]
	public override Map column(object columnKey)
	{
		Preconditions.checkNotNull(columnKey);
		Integer integer = (Integer)columnKeyToIndex.get(columnKey);
		if (integer == null)
		{
			Map result = Collections.emptyMap();
			_ = null;
			return result;
		}
		Column result2 = new Column(this, integer.intValue());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TC;Ljava/util/Map<TR;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 20, 2, 3, 1, 3, 1, 0, 97,
		0, 0
	})]
	[LineNumberTable(new byte[] { 162, 43, 103 })]
	public override Map columnMap()
	{
		ColumnMap columnMap = this.m_columnMap;
		ColumnMap result;
		if (columnMap == null)
		{
			ColumnMap columnMap2 = new ColumnMap(this, null);
			result = columnMap2;
			this.m_columnMap = columnMap2;
		}
		else
		{
			result = columnMap;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 1, 0, 97, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 88, 103, 114, 99, 136 })]
	public override Map row(object rowKey)
	{
		Preconditions.checkNotNull(rowKey);
		Integer integer = (Integer)rowKeyToIndex.get(rowKey);
		if (integer == null)
		{
			Map result = Collections.emptyMap();
			_ = null;
			return result;
		}
		Row result2 = new Row(this, integer.intValue());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 20, 2, 3, 1, 3, 1, 0, 97,
		0, 0
	})]
	[LineNumberTable(new byte[] { 162, 138, 103 })]
	public override Map rowMap()
	{
		RowMap rowMap = this.m_rowMap;
		RowMap result;
		if (rowMap == null)
		{
			RowMap rowMap2 = new RowMap(this, null);
			result = rowMap2;
			this.m_rowMap = rowMap2;
		}
		else
		{
			result = rowMap;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 97, 0, 0 })]
	[LineNumberTable(807)]
	public override Collection values()
	{
		Collection result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 97, 0, 0 })]
	[LineNumberTable(812)]
	internal override Iterator valuesIterator()
	{
		_3 result = new _3(this, size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 97, 0, 0 })]
	[LineNumberTable(823)]
	internal override Spliterator valuesSpliterator()
	{
		Spliterator result = CollectSpliterators.indexed(size(), 16, new ___003C_003EAnon1(this));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(92)]
	public override int hashCode()
	{
		int result = base.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(92)]
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
	[LineNumberTable(92)]
	public virtual Set _003Cbridge_003EcolumnKeySet()
	{
		ImmutableSet result = columnKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(92)]
	public virtual Set _003Cbridge_003ErowKeySet()
	{
		ImmutableSet result = rowKeySet();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(95)]
	internal static ImmutableList access_0024100(ArrayTable P_0)
	{
		return P_0.columnList;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(95)]
	internal static ImmutableList access_0024200(ArrayTable P_0)
	{
		return P_0.rowList;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(95)]
	internal static ImmutableMap access_0024300(ArrayTable P_0)
	{
		return P_0.rowKeyToIndex;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(95)]
	internal static ImmutableMap access_0024600(ArrayTable P_0)
	{
		return P_0.columnKeyToIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(95)]
	internal static object access_0024800(ArrayTable P_0, int P_1)
	{
		object value = P_0.getValue(P_1);
		_ = null;
		return value;
	}

	[HideFromJava]
	public static implicit operator Serializable(ArrayTable P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
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
	protected ArrayTable(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
