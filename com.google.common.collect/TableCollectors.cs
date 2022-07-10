using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)76,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class TableCollectors : Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal sealed class ImmutableTableCollectorState : Object
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/List<Lcom/google/common/collect/TableCollectors$MutableCell<TR;TC;TV;>;>;")]
		internal List insertionOrder;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Table<TR;TC;Lcom/google/common/collect/TableCollectors$MutableCell<TR;TC;TV;>;>;")]
		internal Table table;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
		[LineNumberTable(162)]
		internal virtual ImmutableTable toTable()
		{
			ImmutableTable result = ImmutableTable.copyOf(insertionOrder);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/TableCollectors$ImmutableTableCollectorState<TR;TC;TV;>;Ljava/util/function/BinaryOperator<TV;>;)Lcom/google/common/collect/TableCollectors$ImmutableTableCollectorState<TR;TC;TV;>;")]
		[LineNumberTable(new byte[] { 105, 127, 1, 121, 98 })]
		internal virtual ImmutableTableCollectorState combine(ImmutableTableCollectorState P_0, BinaryOperator P_1)
		{
			Iterator iterator = P_0.insertionOrder.iterator();
			while (iterator.hasNext())
			{
				MutableCell mutableCell = (MutableCell)iterator.next();
				put(mutableCell.getRowKey(), mutableCell.getColumnKey(), mutableCell.getValue(), P_1);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TC;TV;Ljava/util/function/BinaryOperator<TV;>;)V")]
		[LineNumberTable(new byte[] { 93, 115, 99, 105, 109, 111, 98, 139 })]
		internal virtual void put(object P_0, object P_1, object P_2, BinaryOperator P_3)
		{
			MutableCell mutableCell = (MutableCell)table.get(P_0, P_1);
			if (mutableCell == null)
			{
				MutableCell mutableCell2 = new MutableCell(P_0, P_1, P_2);
				insertionOrder.add(mutableCell2);
				table.put(P_0, P_1, mutableCell2);
			}
			else
			{
				mutableCell.merge(P_2, P_3);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(138)]
		internal ImmutableTableCollectorState(_1 P_0)
			: this()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 88, 104, 107 })]
		private ImmutableTableCollectorState()
		{
			insertionOrder = new ArrayList();
			table = HashBasedTable.create();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Tables$AbstractCell<TR;TC;TV;>;")]
	internal sealed class MutableCell : Tables.AbstractCell
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TR;")]
		private object row;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TC;")]
		private object column;

		[Signature("TV;")]
		private object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TC;TV;)V")]
		[LineNumberTable(new byte[] { 121, 104, 113, 113, 113 })]
		internal MutableCell(object P_0, object P_1, object P_2)
		{
			row = Preconditions.checkNotNull(P_0, (object)"row");
			column = Preconditions.checkNotNull(P_1, (object)"column");
			value = Preconditions.checkNotNull(P_2, (object)"value");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TV;Ljava/util/function/BinaryOperator<TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 79, 108, 125 })]
		internal virtual void merge(object P_0, BinaryOperator P_1)
		{
			Preconditions.checkNotNull(P_0, (object)"value");
			value = Preconditions.checkNotNull(P_1.apply(value, P_0), (object)"mergeFunction.apply");
		}

		[Signature("()TR;")]
		public override object getRowKey()
		{
			return row;
		}

		[Signature("()TC;")]
		public override object getColumnKey()
		{
			return column;
		}

		[Signature("()TV;")]
		public override object getValue()
		{
			return value;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Supplier
	{
		internal ___003C_003EAnon0()
		{
		}

		public object get()
		{
			ImmutableTable.Builder result = new ImmutableTable.Builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		private readonly java.util.function.Function arg_00243;

		internal ___003C_003EAnon1(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableTable_00240(arg_00241, arg_00242, arg_00243, (ImmutableTable.Builder)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BinaryOperator
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableTable.Builder result = ((ImmutableTable.Builder)P_0).combine((ImmutableTable.Builder)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : java.util.function.Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			ImmutableTable result = ((ImmutableTable.Builder)P_0).build();
			_ = null;
			return result;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : java.util.function.Supplier
	{
		internal ___003C_003EAnon4()
		{
		}

		public object get()
		{
			ImmutableTableCollectorState result = lambda_0024toImmutableTable_00241();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon5 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		private readonly java.util.function.Function arg_00243;

		private readonly BinaryOperator arg_00244;

		internal ___003C_003EAnon5(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2, BinaryOperator P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableTable_00242(arg_00241, arg_00242, arg_00243, arg_00244, (ImmutableTableCollectorState)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon6 : BinaryOperator
	{
		private readonly BinaryOperator arg_00241;

		internal ___003C_003EAnon6(BinaryOperator P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableTableCollectorState result = lambda_0024toImmutableTable_00243(arg_00241, (ImmutableTableCollectorState)P_0, (ImmutableTableCollectorState)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon7 : java.util.function.Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			ImmutableTable result = lambda_0024toImmutableTable_00244((ImmutableTableCollectorState)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon8 : BinaryOperator
	{
		internal ___003C_003EAnon8()
		{
		}

		public object apply(object P_0, object P_1)
		{
			object result = lambda_0024toTable_00245(P_0, P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon9 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		private readonly java.util.function.Function arg_00243;

		private readonly BinaryOperator arg_00244;

		internal ___003C_003EAnon9(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2, BinaryOperator P_3)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toTable_00246(arg_00241, arg_00242, arg_00243, arg_00244, (Table)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon10 : BinaryOperator
	{
		private readonly BinaryOperator arg_00241;

		internal ___003C_003EAnon10(BinaryOperator P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0, object P_1)
		{
			Table result = lambda_0024toTable_00247(arg_00241, (Table)P_0, (Table)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TR;>;Ljava/util/function/Function<-TT;+TC;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 76, 0, 0 })]
	[LineNumberTable(new byte[] { 159, 183, 108, 108, 108 })]
	internal static Collector toImmutableTable(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2)
	{
		Preconditions.checkNotNull((object)P_0, (object)"rowFunction");
		Preconditions.checkNotNull((object)P_1, (object)"columnFunction");
		Preconditions.checkNotNull((object)P_2, (object)"valueFunction");
		Collector result = Collector.of(new ___003C_003EAnon0(), new ___003C_003EAnon1(P_0, P_1, P_2), new ___003C_003EAnon2(), new ___003C_003EAnon3());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TR;>;Ljava/util/function/Function<-TT;+TC;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 76, 0, 0 })]
	[LineNumberTable(new byte[] { 9, 108, 108, 108, 236, 72 })]
	internal static Collector toImmutableTable(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2, BinaryOperator P_3)
	{
		Preconditions.checkNotNull((object)P_0, (object)"rowFunction");
		Preconditions.checkNotNull((object)P_1, (object)"columnFunction");
		Preconditions.checkNotNull((object)P_2, (object)"valueFunction");
		Preconditions.checkNotNull((object)P_3, (object)"mergeFunction");
		Collector result = Collector.of(new ___003C_003EAnon4(), new ___003C_003EAnon5(P_0, P_1, P_2, P_3), new ___003C_003EAnon6(P_3), new ___003C_003EAnon7());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;I::Lcom/google/common/collect/Table<TR;TC;TV;>;>(Ljava/util/function/Function<-TT;+TR;>;Ljava/util/function/Function<-TT;+TC;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;Ljava/util/function/Supplier<TI;>;)Ljava/util/stream/Collector<TT;*TI;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 4, 18, 0, 0, 0, 0, 76, 0, 0,
		18, 1, 0, 0, 0, 76, 0, 0, 18, 2,
		0, 0, 0, 76, 0, 0, 18, 3, 0, 0,
		0, 76, 0, 0
	})]
	[LineNumberTable(new byte[] { 65, 103, 103, 103, 103, 104 })]
	internal static Collector toTable(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2, BinaryOperator P_3, java.util.function.Supplier P_4)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		Preconditions.checkNotNull(P_3);
		Preconditions.checkNotNull(P_4);
		Collector result = Collector.of(P_4, new ___003C_003EAnon9(P_0, P_1, P_2, P_3), new ___003C_003EAnon10(P_3));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Table<TR;TC;TV;>;TR;TC;TV;Ljava/util/function/BinaryOperator<TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 76, 0, 0,
		18, 1, 0, 0, 0, 76, 0, 0, 18, 2,
		0, 0, 0, 76, 0, 0
	})]
	[LineNumberTable(new byte[] { 160, 92, 103, 105, 99, 140, 106, 99, 139, 170 })]
	private static void mergeTables(Table P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_3, BinaryOperator P_4)
	{
		Preconditions.checkNotNull(P_3);
		object obj = P_0.get(P_1, P_2);
		if (obj == null)
		{
			P_0.put(P_1, P_2, P_3);
			return;
		}
		object obj2 = P_4.apply(obj, P_3);
		if (obj2 == null)
		{
			P_0.remove(P_1, P_2);
		}
		else
		{
			P_0.put(P_1, P_2, obj2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(47)]
	private static void lambda_0024toImmutableTable_00240(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2, ImmutableTable.Builder P_3, object P_4)
	{
		P_3.put(P_0.apply(P_4), P_1.apply(P_4), P_2.apply(P_4));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(71)]
	private static ImmutableTableCollectorState lambda_0024toImmutableTable_00241()
	{
		ImmutableTableCollectorState result = new ImmutableTableCollectorState(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 23, 101, 104, 104, 230, 61 })]
	private static void lambda_0024toImmutableTable_00242(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2, BinaryOperator P_3, ImmutableTableCollectorState P_4, object P_5)
	{
		P_4.put(P_0.apply(P_5), P_1.apply(P_5), P_2.apply(P_5), P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(78)]
	private static ImmutableTableCollectorState lambda_0024toImmutableTable_00243(BinaryOperator P_0, ImmutableTableCollectorState P_1, ImmutableTableCollectorState P_2)
	{
		ImmutableTableCollectorState result = P_1.combine(P_2, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(79)]
	private static ImmutableTable lambda_0024toImmutableTable_00244(ImmutableTableCollectorState P_0)
	{
		ImmutableTable result = P_0.toTable();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(98)]
	private static object lambda_0024toTable_00245(object P_0, object P_1)
	{
		string text = String.valueOf(P_0);
		string text2 = String.valueOf(P_1);
		int num = 24 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
		num = num;
		string s = new StringBuilder(num).append("Conflicting values ").append(text).append(" and ")
			.append(text2)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalStateException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 73, 133, 104, 104, 230, 60 })]
	private static void lambda_0024toTable_00246(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2, BinaryOperator P_3, Table P_4, object P_5)
	{
		mergeTables(P_4, P_0.apply(P_5), P_1.apply(P_5), P_2.apply(P_5), P_3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 80, 127, 1, 98, 50, 133, 98 })]
	private static Table lambda_0024toTable_00247(BinaryOperator P_0, Table P_1, Table P_2)
	{
		Iterator iterator = P_2.cellSet().iterator();
		while (iterator.hasNext())
		{
			Table.Cell cell = (Table.Cell)iterator.next();
			mergeTables(P_1, cell.getRowKey(), cell.getColumnKey(), cell.getValue(), P_0);
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;I::Lcom/google/common/collect/Table<TR;TC;TV;>;>(Ljava/util/function/Function<-TT;+TR;>;Ljava/util/function/Function<-TT;+TC;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/Supplier<TI;>;)Ljava/util/stream/Collector<TT;*TI;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 4, 18, 0, 0, 0, 0, 76, 0, 0,
		18, 1, 0, 0, 0, 76, 0, 0, 18, 2,
		0, 0, 0, 76, 0, 0, 18, 3, 0, 0,
		0, 76, 0, 0
	})]
	[LineNumberTable(93)]
	internal static Collector toTable(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Function P_2, java.util.function.Supplier P_3)
	{
		Collector result = toTable(P_0, P_1, P_2, new ___003C_003EAnon8(), P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(220)]
	private TableCollectors()
	{
	}
}
