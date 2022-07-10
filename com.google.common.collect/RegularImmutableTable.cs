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
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class RegularImmutableTable : ImmutableTable
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
	[Signature("Lcom/google/common/collect/IndexedImmutableSet<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	internal new sealed class CellSet : IndexedImmutableSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal RegularImmutableTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(47)]
		internal CellSet(RegularImmutableTable P_0, RegularImmutableTable._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(47)]
		private CellSet(RegularImmutableTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
		[LineNumberTable(55)]
		internal new virtual Table.Cell get(int P_0)
		{
			Table.Cell cell = this_00240.getCell(P_0);
			_ = null;
			return cell;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(50)]
		public override int size()
		{
			int result = ((AbstractTable)this_00240).size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 10, 104, 103, 120, 150 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Table.Cell)
			{
				Table.Cell cell = (Table.Cell)P_0;
				object obj = this_00240.get(cell.getRowKey(), cell.getColumnKey());
				return (obj != null && java.lang.Object.instancehelper_equals(obj, cell.getValue())) ? true : false;
			}
			return false;
		}

		internal override bool isPartialView()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(46)]
		internal override object get(int P_0)
		{
			Table.Cell result = get(P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		static CellSet()
		{
			IndexedImmutableSet.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected CellSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableList<TV;>;")]
	internal new sealed class Values : ImmutableList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal RegularImmutableTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(82)]
		internal Values(RegularImmutableTable P_0, RegularImmutableTable._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(82)]
		private Values(RegularImmutableTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(85)]
		public override int size()
		{
			int result = ((AbstractTable)this_00240).size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(90)]
		public override object get(int P_0)
		{
			object value = this_00240.getValue(P_0);
			_ = null;
			return value;
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

	[SpecialName]
	private sealed class ___003C_003EAnon0 : Comparator
	{
		private readonly Comparator arg_00241;

		private readonly Comparator arg_00242;

		internal ___003C_003EAnon0(Comparator P_0, Comparator P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public int compare(object P_0, object P_1)
		{
			int result = lambda_0024forCells_00240(arg_00241, arg_00242, (Table.Cell)P_0, (Table.Cell)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		[SpecialName]
		public Comparator thenComparing(java.util.function.Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		[SpecialName]
		public Comparator thenComparing(java.util.function.Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[SpecialName]
		public Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		[SpecialName]
		public Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		[SpecialName]
		public Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;Ljava/util/Comparator<-TR;>;Ljava/util/Comparator<-TC;>;)Lcom/google/common/collect/RegularImmutableTable<TR;TC;TV;>;")]
	[LineNumberTable(new byte[]
	{
		88, 102, 102, 103, 124, 110, 110, 162, 99, 104,
		142, 99, 104, 142
	})]
	private static RegularImmutableTable forCellsInternal(Iterable P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_2)
	{
		LinkedHashSet linkedHashSet = new LinkedHashSet();
		LinkedHashSet linkedHashSet2 = new LinkedHashSet();
		ImmutableList immutableList = ImmutableList.copyOf(P_0);
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			Table.Cell cell = (Table.Cell)iterator.next();
			((Set)linkedHashSet).add(cell.getRowKey());
			((Set)linkedHashSet2).add(cell.getColumnKey());
		}
		ImmutableSet immutableSet = ((P_1 != null) ? ImmutableSet.copyOf(ImmutableList.sortedCopyOf(P_1, linkedHashSet)) : ImmutableSet.copyOf(linkedHashSet));
		ImmutableSet immutableSet2 = ((P_2 != null) ? ImmutableSet.copyOf(ImmutableList.sortedCopyOf(P_2, linkedHashSet2)) : ImmutableSet.copyOf(linkedHashSet2));
		RegularImmutableTable result = forOrderedComponents(immutableList, immutableSet, immutableSet2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;Lcom/google/common/collect/ImmutableSet<TR;>;Lcom/google/common/collect/ImmutableSet<TC;>;)Lcom/google/common/collect/RegularImmutableTable<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 115, 123, 106, 10 })]
	internal static RegularImmutableTable forOrderedComponents(ImmutableList P_0, ImmutableSet P_1, ImmutableSet P_2)
	{
		RegularImmutableTable result = ((P_0.size() <= (long)P_1.size() * (long)P_2.size() / 2) ? ((RegularImmutableTable)new SparseImmutableTable(P_0, P_1, P_2)) : ((RegularImmutableTable)new DenseImmutableTable(P_0, P_1, P_2)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(78)]
	internal sealed override ImmutableCollection createValues()
	{
		ImmutableList result = ((!isEmpty()) ? new Values(this, null) : ImmutableList.of());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(43)]
	internal sealed override ImmutableSet createCellSet()
	{
		ImmutableSet result = ((!isEmpty()) ? new CellSet(this, null) : ImmutableSet.of());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 65, 99, 99, 115, 99, 130, 99, 99, 20 })]
	private static int lambda_0024forCells_00240(Comparator P_0, Comparator P_1, Table.Cell P_2, Table.Cell P_3)
	{
		int num = P_0?.compare(P_2.getRowKey(), P_3.getRowKey()) ?? 0;
		if (num != 0)
		{
			return num;
		}
		int result = P_1?.compare(P_2.getColumnKey(), P_3.getColumnKey()) ?? 0;
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	internal RegularImmutableTable()
	{
	}

	[Signature("(I)Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
	internal abstract Table.Cell getCell(int P_0);

	[Signature("(I)TV;")]
	internal abstract object getValue(int P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/List<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;Ljava/util/Comparator<-TR;>;Ljava/util/Comparator<-TC;>;)Lcom/google/common/collect/RegularImmutableTable<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 53, 103, 230, 72, 237, 77, 135 })]
	internal static RegularImmutableTable forCells(List P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_2)
	{
		Preconditions.checkNotNull(P_0);
		if (P_1 != null || P_2 != null)
		{
			Comparator c = new ___003C_003EAnon0(P_1, P_2);
			Collections.sort(P_0, c);
		}
		RegularImmutableTable result = forCellsInternal(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;)Lcom/google/common/collect/RegularImmutableTable<TR;TC;TV;>;")]
	[LineNumberTable(131)]
	internal static RegularImmutableTable forCells(Iterable P_0)
	{
		RegularImmutableTable result = forCellsInternal(P_0, null, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;TC;TV;TV;)V")]
	[LineNumberTable(new byte[] { 126, 248, 71 })]
	internal void checkNoDuplicate(object P_0, object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2, object P_3)
	{
		Preconditions.checkArgument(P_2 == null, "Duplicate key: (row=%s, column=%s), values: [%s, %s].", P_0, P_1, P_3, P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal override Collection createValues()
	{
		ImmutableCollection result = this.createValues();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal override Set createCellSet()
	{
		ImmutableSet result = this.createCellSet();
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableTable(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
