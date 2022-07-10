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
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)66,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Tables : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Map<Ljava/lang/Object;Ljava/lang/Object;>;Ljava/util/Map<Ljava/lang/Object;Ljava/lang/Object;>;>;")]
	[EnclosingMethod(null, null, null)]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map<Ljava/lang/Object;Ljava/lang/Object;>;)Ljava/util/Map<Ljava/lang/Object;Ljava/lang/Object;>;")]
		[LineNumberTable(716)]
		public virtual Map apply(Map P_0)
		{
			Map result = Collections.unmodifiableMap(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(713)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(713)]
		public virtual object apply(object P_0)
		{
			Map result = apply((Map)P_0);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}

		bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}
	}

	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 53, 0, 0,
		17, 1, 0, 0, 0, 53, 0, 0, 17, 2,
		0, 0, 0, 53, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)53,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class AbstractCell : java.lang.Object, Table.Cell
	{
		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract object getRowKey();

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract object getColumnKey();

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract object getValue();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(173)]
		internal AbstractCell()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 127, 100, 130, 104, 103, 116, 115, 22, 193 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 == this)
			{
				return true;
			}
			if (P_0 is Table.Cell)
			{
				Table.Cell cell = (Table.Cell)P_0;
				return (com.google.common.@base.Objects.equal(getRowKey(), cell.getRowKey()) && com.google.common.@base.Objects.equal(getColumnKey(), cell.getColumnKey()) && com.google.common.@base.Objects.equal(getValue(), cell.getValue())) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(191)]
		public override int hashCode()
		{
			int result = com.google.common.@base.Objects.hashCode(getRowKey(), getColumnKey(), getValue());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(196)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(getRowKey());
			string text2 = java.lang.String.valueOf(getColumnKey());
			string text3 = java.lang.String.valueOf(getValue());
			int num = 4 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text3));
			num = num;
			string result = new StringBuilder(num).append("(").append(text).append(",")
				.append(text2)
				.append(")=")
				.append(text3)
				.toString();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Tables$AbstractCell<TR;TC;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 48, 0, 0,
		17, 1, 0, 0, 0, 48, 0, 0, 17, 2,
		0, 0, 0, 48, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)48,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class ImmutableCell : AbstractCell, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TR;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object rowKey;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TC;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object columnKey;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object value;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TC;TV;)V")]
		[LineNumberTable(new byte[] { 92, 104, 103, 103, 103 })]
		internal ImmutableCell([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2)
		{
			rowKey = P_0;
			columnKey = P_1;
			value = P_2;
		}

		[Signature("()TR;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getRowKey()
		{
			return rowKey;
		}

		[Signature("()TC;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getColumnKey()
		{
			return columnKey;
		}

		[Signature("()TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object getValue()
		{
			return value;
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
		protected ImmutableCell(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>Lcom/google/common/collect/AbstractTable<TR;TC;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 4, 17, 0, 0, 0, 0, 127, 0, 0,
		17, 1, 0, 0, 0, 127, 0, 0, 17, 2,
		0, 0, 0, 127, 0, 0, 17, 3, 0, 0,
		0, 127, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)127,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class TransformedTable : AbstractTable
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Lcom/google/common/collect/Table$Cell<TR;TC;TV1;>;Lcom/google/common/collect/Table$Cell<TR;TC;TV2;>;>;")]
		[EnclosingMethod(null, "cellFunction", "()Lcom.google.common.base.Function;")]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal new class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TransformedTable this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/Table$Cell<TR;TC;TV1;>;)Lcom/google/common/collect/Table$Cell<TR;TC;TV2;>;")]
			[LineNumberTable(new byte[] { 161, 127, 97, 63, 2 })]
			public virtual Table.Cell apply(Table.Cell P_0)
			{
				Table.Cell result = immutableCell(P_0.getRowKey(), P_0.getColumnKey(), this_00240.function.apply(P_0.getValue()));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(494)]
			internal _1(TransformedTable P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(494)]
			public virtual object apply(object P_0)
			{
				Table.Cell result = apply((Table.Cell)P_0);
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}

			bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Map<TC;TV1;>;Ljava/util/Map<TC;TV2;>;>;")]
		[EnclosingMethod(null, "rowMap", "()Ljava.util.Map;")]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal class _2 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TransformedTable this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(531)]
			internal _2(TransformedTable P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map<TC;TV1;>;)Ljava/util/Map<TC;TV2;>;")]
			[LineNumberTable(534)]
			public virtual Map apply(Map P_0)
			{
				Map result = Maps.transformValues(P_0, this_00240.function);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(531)]
			public virtual object apply(object P_0)
			{
				Map result = apply((Map)P_0);
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}

			bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/util/Map<TR;TV1;>;Ljava/util/Map<TR;TV2;>;>;")]
		[EnclosingMethod(null, "columnMap", "()Ljava.util.Map;")]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal class _3 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TransformedTable this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(543)]
			internal _3(TransformedTable P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Map<TR;TV1;>;)Ljava/util/Map<TR;TV2;>;")]
			[LineNumberTable(546)]
			public virtual Map apply(Map P_0)
			{
				Map result = Maps.transformValues(P_0, this_00240.function);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(543)]
			public virtual object apply(object P_0)
			{
				Map result = apply((Map)P_0);
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}

			bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Table<TR;TC;TV1;>;")]
		internal Table fromTable;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TV1;TV2;>;")]
		internal com.google.common.@base.Function function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<TR;TC;TV1;>;Lcom/google/common/base/Function<-TV1;TV2;>;)V")]
		[LineNumberTable(new byte[] { 161, 59, 104, 113, 113 })]
		internal TransformedTable(Table P_0, com.google.common.@base.Function P_1)
		{
			fromTable = (Table)Preconditions.checkNotNull(P_0);
			function = (com.google.common.@base.Function)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(436)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			bool result = fromTable.contains(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/base/Function<Lcom/google/common/collect/Table$Cell<TR;TC;TV1;>;Lcom/google/common/collect/Table$Cell<TR;TC;TV2;>;>;")]
		[LineNumberTable(494)]
		internal virtual com.google.common.@base.Function cellFunction()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV2;")]
		[LineNumberTable(new byte[] { 161, 75, 106, 127, 0, 1 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			return (!contains(P_0, P_1)) ? null : function.apply(NullnessCasts.uncheckedCastNullableTToT(fromTable.get(P_0, P_1)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(452)]
		public override int size()
		{
			int result = fromTable.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 87, 109 })]
		public override void clear()
		{
			fromTable.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TC;TV2;)TV2;")]
		[LineNumberTable(466)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV2;>;)V")]
		[LineNumberTable(471)]
		public override void putAll(Table P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV2;")]
		[LineNumberTable(new byte[] { 161, 107, 138, 127, 0, 225, 61 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			return (!contains(P_0, P_1)) ? null : function.apply(NullnessCasts.uncheckedCastNullableTToT(fromTable.remove(P_0, P_1)));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;)Ljava/util/Map<TC;TV2;>;")]
		[LineNumberTable(485)]
		public override Map row([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map result = Maps.transformValues(fromTable.row(P_0), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Ljava/util/Map<TR;TV2;>;")]
		[LineNumberTable(490)]
		public override Map column([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map result = Maps.transformValues(fromTable.column(P_0), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV2;>;>;")]
		[LineNumberTable(505)]
		internal override Iterator cellIterator()
		{
			Iterator result = Iterators.transform(fromTable.cellSet().iterator(), cellFunction());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV2;>;>;")]
		[LineNumberTable(510)]
		internal override Spliterator cellSpliterator()
		{
			Spliterator result = CollectSpliterators.map(fromTable.cellSet().spliterator(), cellFunction());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TR;>;")]
		[LineNumberTable(515)]
		public override Set rowKeySet()
		{
			Set result = fromTable.rowKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TC;>;")]
		[LineNumberTable(520)]
		public override Set columnKeySet()
		{
			Set result = fromTable.columnKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV2;>;")]
		[LineNumberTable(525)]
		internal override Collection createValues()
		{
			Collection result = Collections2.transform(fromTable.values(), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV2;>;>;")]
		[LineNumberTable(new byte[] { 161, 160, 231, 71 })]
		public override Map rowMap()
		{
			_2  = new _2(this);
			Map result = Maps.transformValues(fromTable.rowMap(), );
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TC;Ljava/util/Map<TR;TV2;>;>;")]
		[LineNumberTable(new byte[] { 161, 172, 231, 71 })]
		public override Map columnMap()
		{
			_3  = new _3(this);
			Map result = Maps.transformValues(fromTable.columnMap(), );
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<C:Ljava/lang/Object;R:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractTable<TC;TR;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 115, 0, 0,
		17, 1, 0, 0, 0, 115, 0, 0, 17, 2,
		0, 0, 0, 115, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)115,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class TransposeTable : AbstractTable
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Lcom/google/common/collect/Table$Cell<***>;Lcom/google/common/collect/Table$Cell<***>;>;")]
		[EnclosingMethod(null, null, null)]
		[Implements(new string[] { "com.google.common.base.Function" })]
		internal new class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/Table$Cell<***>;)Lcom/google/common/collect/Table$Cell<***>;")]
			[LineNumberTable(324)]
			public virtual Table.Cell apply(Table.Cell P_0)
			{
				Table.Cell result = immutableCell(P_0.getColumnKey(), P_0.getRowKey(), P_0.getValue());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(321)]
			internal _1()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(321)]
			public virtual object apply(object P_0)
			{
				Table.Cell result = apply((Table.Cell)P_0);
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}

			bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Table<TR;TC;TV;>;")]
		internal Table original;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<Lcom/google/common/collect/Table$Cell<***>;Lcom/google/common/collect/Table$Cell<***>;>;")]
		private static com.google.common.@base.Function TRANSPOSE_CELL;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<TR;TC;TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 110, 104, 113 })]
		internal TransposeTable(Table P_0)
		{
			original = (Table)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 116, 109 })]
		public override void clear()
		{
			original.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
		[LineNumberTable(235)]
		public override Map column([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map result = original.row(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TR;>;")]
		[LineNumberTable(240)]
		public override Set columnKeySet()
		{
			Set result = original.rowKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
		[LineNumberTable(245)]
		public override Map columnMap()
		{
			Map result = original.rowMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(250)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			bool result = original.contains(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(255)]
		public override bool containsColumn([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = original.containsRow(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(260)]
		public override bool containsRow([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = original.containsColumn(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(265)]
		public override bool containsValue([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = original.containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
		[LineNumberTable(271)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			object result = original.get(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;TR;TV;)TV;")]
		[LineNumberTable(280)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2)
		{
			object result = original.put(P_1, P_0, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<+TC;+TR;+TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 171, 115 })]
		public override void putAll(Table P_0)
		{
			original.putAll(transpose(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
		[LineNumberTable(291)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			object result = original.remove(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Ljava/util/Map<TR;TV;>;")]
		[LineNumberTable(296)]
		public override Map row([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map result = original.column(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TC;>;")]
		[LineNumberTable(301)]
		public override Set rowKeySet()
		{
			Set result = original.columnKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TC;Ljava/util/Map<TR;TV;>;>;")]
		[LineNumberTable(306)]
		public override Map rowMap()
		{
			Map result = original.columnMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(311)]
		public override int size()
		{
			int result = original.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(316)]
		public override Collection values()
		{
			Collection result = original.values();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Table$Cell<TC;TR;TV;>;>;")]
		[LineNumberTable(331)]
		internal override Iterator cellIterator()
		{
			Iterator result = Iterators.transform(original.cellSet().iterator(), TRANSPOSE_CELL);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Lcom/google/common/collect/Table$Cell<TC;TR;TV;>;>;")]
		[LineNumberTable(337)]
		internal override Spliterator cellSpliterator()
		{
			Spliterator result = CollectSpliterators.map(original.cellSet().spliterator(), TRANSPOSE_CELL);
			_ = null;
			return result;
		}

		[LineNumberTable(320)]
		static TransposeTable()
		{
			TRANSPOSE_CELL = new _1();
		}
	}

	[Serializable]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Tables$UnmodifiableTable<TR;TC;TV;>;Lcom/google/common/collect/RowSortedTable<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 56, 0, 0,
		17, 1, 0, 0, 0, 56, 0, 0, 17, 2,
		0, 0, 0, 56, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)56,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.RowSortedTable" })]
	internal sealed class UnmodifiableRowSortedMap : UnmodifiableTable, RowSortedTable, Table
	{
		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/RowSortedTable<TR;+TC;+TV;>;)V")]
		[LineNumberTable(new byte[] { 162, 58, 105 })]
		public UnmodifiableRowSortedMap(RowSortedTable P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/RowSortedTable<TR;TC;TV;>;")]
		[LineNumberTable(689)]
		protected internal new virtual RowSortedTable @delegate()
		{
			return (RowSortedTable)base.@delegate();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 68, 102 })]
		public new virtual SortedMap rowMap()
		{
			com.google.common.@base.Function function = access_0024000();
			SortedMap result = Collections.unmodifiableSortedMap(Maps.transformValues(@delegate().rowMap(), function));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TR;>;")]
		[LineNumberTable(700)]
		public new virtual SortedSet rowKeySet()
		{
			SortedSet result = Collections.unmodifiableSortedSet(@delegate().rowKeySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(679)]
		public override Map rowMap()
		{
			SortedMap result = rowMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(679)]
		public override Set rowKeySet()
		{
			SortedSet result = rowKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(679)]
		protected internal override Table @delegate()
		{
			RowSortedTable result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(679)]
		protected internal override object @delegate()
		{
			RowSortedTable result = @delegate();
			_ = null;
			return result;
		}

		Map RowSortedTable.RowSortedTable_003A_003ArowMap()
		{
			return this.rowMap();
		}

		Set RowSortedTable.RowSortedTable_003A_003ArowKeySet()
		{
			return this.rowKeySet();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected UnmodifiableRowSortedMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingTable<TR;TC;TV;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 99, 0, 0,
		17, 1, 0, 0, 0, 99, 0, 0, 17, 2,
		0, 0, 0, 99, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)99,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class UnmodifiableTable : ForwardingTable, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Table<+TR;+TC;+TV;>;")]
		internal new Table @delegate;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 205, 104, 113 })]
		internal UnmodifiableTable(Table P_0)
		{
			this.@delegate = (Table)Preconditions.checkNotNull(P_0);
		}

		[Signature("()Lcom/google/common/collect/Table<TR;TC;TV;>;")]
		protected internal override Table @delegate()
		{
			return this.@delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
		[LineNumberTable(587)]
		public override Set cellSet()
		{
			Set result = Collections.unmodifiableSet(base.cellSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(592)]
		public override void clear()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Ljava/util/Map<TR;TV;>;")]
		[LineNumberTable(597)]
		public override Map column([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map result = Collections.unmodifiableMap(base.column(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TC;>;")]
		[LineNumberTable(602)]
		public override Set columnKeySet()
		{
			Set result = Collections.unmodifiableSet(base.columnKeySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TC;Ljava/util/Map<TR;TV;>;>;")]
		[LineNumberTable(new byte[] { 161, 237, 102 })]
		public override Map columnMap()
		{
			com.google.common.@base.Function function = access_0024000();
			Map result = Collections.unmodifiableMap(Maps.transformValues(base.columnMap(), function));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TC;TV;)TV;")]
		[LineNumberTable(617)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)V")]
		[LineNumberTable(622)]
		public override void putAll(Table P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
		[LineNumberTable(628)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
		[LineNumberTable(633)]
		public override Map row([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Map result = Collections.unmodifiableMap(base.row(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TR;>;")]
		[LineNumberTable(638)]
		public override Set rowKeySet()
		{
			Set result = Collections.unmodifiableSet(base.rowKeySet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 162, 17, 102 })]
		public override Map rowMap()
		{
			com.google.common.@base.Function function = access_0024000();
			Map result = Collections.unmodifiableMap(Maps.transformValues(base.rowMap(), function));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(649)]
		public override Collection values()
		{
			Collection result = Collections.unmodifiableCollection(base.values());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(570)]
		protected internal new virtual object @delegate()
		{
			Table result = this.@delegate();
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
		protected UnmodifiableTable(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Function<+Ljava/util/Map<**>;+Ljava/util/Map<**>;>;")]
	private static com.google.common.@base.Function UNMODIFIABLE_WRAPPER;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Table<***>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 162, 129, 100, 98, 104, 103, 148 })]
	internal static bool equalsImpl(Table P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_1 == P_0)
		{
			return true;
		}
		if (P_1 is Table)
		{
			Table table = (Table)P_1;
			bool result = P_0.cellSet().equals(table.cellSet());
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(TR;TC;TV;)Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0, 18, 2,
		0, 0, 0, 66, 0, 0
	})]
	[LineNumberTable(129)]
	public static Table.Cell immutableCell([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object rowKey, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object columnKey, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		ImmutableCell result = new ImmutableCell(rowKey, columnKey, value);
		_ = null;
		return result;
	}

	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/base/Function<Ljava/util/Map<TK;TV;>;Ljava/util/Map<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0
	})]
	private static com.google.common.@base.Function unmodifiableWrapper()
	{
		return UNMODIFIABLE_WRAPPER;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(56)]
	private Tables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;I::Lcom/google/common/collect/Table<TR;TC;TV;>;>(Ljava/util/function/Function<-TT;+TR;>;Ljava/util/function/Function<-TT;+TC;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/Supplier<TI;>;)Ljava/util/stream/Collector<TT;*TI;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 4, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0, 18, 2,
		0, 0, 0, 66, 0, 0, 18, 3, 0, 0,
		0, 66, 0, 0
	})]
	[LineNumberTable(82)]
	public static Collector toTable(java.util.function.Function rowFunction, java.util.function.Function columnFunction, java.util.function.Function valueFunction, java.util.function.Supplier tableSupplier)
	{
		Collector result = TableCollectors.toTable(rowFunction, columnFunction, valueFunction, tableSupplier);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;I::Lcom/google/common/collect/Table<TR;TC;TV;>;>(Ljava/util/function/Function<-TT;+TR;>;Ljava/util/function/Function<-TT;+TC;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;Ljava/util/function/Supplier<TI;>;)Ljava/util/stream/Collector<TT;*TI;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 4, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0, 18, 2,
		0, 0, 0, 66, 0, 0, 18, 3, 0, 0,
		0, 66, 0, 0
	})]
	[LineNumberTable(111)]
	public static Collector toTable(java.util.function.Function rowFunction, java.util.function.Function columnFunction, java.util.function.Function valueFunction, BinaryOperator mergeFunction, java.util.function.Supplier tableSupplier)
	{
		Collector result = TableCollectors.toTable(rowFunction, columnFunction, valueFunction, mergeFunction, tableSupplier);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Table<TR;TC;TV;>;)Lcom/google/common/collect/Table<TC;TR;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0, 18, 2,
		0, 0, 0, 66, 0, 0
	})]
	[LineNumberTable(new byte[] { 160, 100, 104, 109, 6 })]
	public static Table transpose(Table table)
	{
		Table obj = ((!(table is TransposeTable)) ? new TransposeTable(table) : ((TransposeTable)table).original);
		Table result = ((obj == null) ? null : ((obj as Table) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/Map<TC;TV;>;>;)Lcom/google/common/collect/Table<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 161, 12, 107, 135 })]
	public static Table newCustomTable(Map backingMap, com.google.common.@base.Supplier factory)
	{
		Preconditions.checkArgument(backingMap.isEmpty());
		Preconditions.checkNotNull(factory);
		StandardTable result = new StandardTable(backingMap, factory);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V1:Ljava/lang/Object;V2:Ljava/lang/Object;>(Lcom/google/common/collect/Table<TR;TC;TV1;>;Lcom/google/common/base/Function<-TV1;TV2;>;)Lcom/google/common/collect/Table<TR;TC;TV2;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 4, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0, 18, 2,
		0, 0, 0, 66, 0, 0, 18, 3, 0, 0,
		0, 66, 0, 0
	})]
	[LineNumberTable(417)]
	public static Table transformValues(Table fromTable, com.google.common.@base.Function function)
	{
		TransformedTable result = new TransformedTable(fromTable, function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)Lcom/google/common/collect/Table<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0, 18, 2,
		0, 0, 0, 66, 0, 0
	})]
	[LineNumberTable(567)]
	public static Table unmodifiableTable(Table table)
	{
		UnmodifiableTable result = new UnmodifiableTable(table);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/RowSortedTable<TR;+TC;+TV;>;)Lcom/google/common/collect/RowSortedTable<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0, 18, 2,
		0, 0, 0, 66, 0, 0
	})]
	[LineNumberTable(676)]
	public static RowSortedTable unmodifiableRowSortedTable(RowSortedTable table)
	{
		UnmodifiableRowSortedMap result = new UnmodifiableRowSortedMap(table);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Table<TR;TC;TV;>;)Lcom/google/common/collect/Table<TR;TC;TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 66, 0, 0,
		18, 1, 0, 0, 0, 66, 0, 0, 18, 2,
		0, 0, 0, 66, 0, 0
	})]
	[LineNumberTable(751)]
	public static Table synchronizedTable(Table table)
	{
		Table result = Synchronized.table(table, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(55)]
	internal static com.google.common.@base.Function access_0024000()
	{
		com.google.common.@base.Function result = unmodifiableWrapper();
		_ = null;
		return result;
	}

	[LineNumberTable(712)]
	static Tables()
	{
		UNMODIFIABLE_WRAPPER = new _1();
	}
}
