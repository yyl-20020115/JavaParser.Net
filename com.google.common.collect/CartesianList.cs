using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.math;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractList<Ljava/util/List<TE;>;>;Ljava/util/RandomAccess;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.RandomAccess" })]
internal sealed class CartesianList : AbstractList, RandomAccess
{
	[Serializable]
	[SpecialName]
	[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
	[EnclosingMethod(null, "get", "(I)Lcom.google.common.collect.ImmutableList;")]
	internal class _1 : ImmutableList
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024index;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal CartesianList this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(121)]
		public override int size()
		{
			int result = access_0024000(this_00240).size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(117)]
		internal _1(CartesianList P_0, int P_1)
		{
			this_00240 = P_0;
			val_0024index = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TE;")]
		[LineNumberTable(new byte[] { 76, 109, 115 })]
		public override object get(int P_0)
		{
			Preconditions.checkElementIndex(P_0, size());
			int index = access_0024100(this_00240, val_0024index, P_0);
			object result = ((List)access_0024000(this_00240).get(P_0)).get(index);
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[HideFromJava]
		static _1()
		{
			ImmutableList.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _1(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/ImmutableList<Ljava/util/List<TE;>;>;")]
	private ImmutableList axes;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private int[] axesSizeProduct;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal static ImmutableList access_0024000(CartesianList P_0)
	{
		return P_0.axes;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	internal static int access_0024100(CartesianList P_0, int P_1, int P_2)
	{
		int axisIndexForProductIndex = P_0.getAxisIndexForProductIndex(P_1, P_2);
		_ = null;
		return axisIndexForProductIndex;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(67)]
	private int getAxisIndexForProductIndex(int P_0, int P_1)
	{
		int num = axesSizeProduct[P_1 + 1];
		int num2 = ((num != -1) ? (P_0 / num) : (-P_0));
		int num3 = ((List)axes.get(P_1)).size();
		return (num3 != -1) ? (num2 % num3) : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableList<Ljava/util/List<TE;>;>;)V")]
	[LineNumberTable(new byte[]
	{
		1, 104, 103, 110, 137, 109, 62, 249, 70, 226,
		61, 97, 176, 103
	})]
	internal CartesianList(ImmutableList P_0)
	{
		axes = P_0;
		int[] array = new int[P_0.size() + 1];
		array[P_0.size()] = 1;
		try
		{
			for (int i = P_0.size() - 1; i >= 0; i += -1)
			{
				array[i] = IntMath.checkedMultiply(array[i + 1], ((List)P_0.get(i)).size());
			}
		}
		catch (System.Exception x)
		{
			if (ByteCodeHelper.MapException<java.lang.ArithmeticException>(x, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0067;
		}
		axesSizeProduct = array;
		return;
		IL_0067:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException("Cartesian product too large; must have size at most Integer.MAX_VALUE");
	}

	[LineNumberTable(140)]
	public override int size()
	{
		return axesSizeProduct[0];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(new byte[] { 66, 109 })]
	public new virtual ImmutableList get(int P_0)
	{
		Preconditions.checkElementIndex(P_0, size());
		_1 result = new _1(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/List<+Ljava/util/List<+TE;>;>;)Ljava/util/List<Ljava/util/List<TE;>;>;")]
	[LineNumberTable(new byte[] { 159, 182, 108, 123, 103, 104, 136, 104, 98 })]
	internal static List create(List P_0)
	{
		ImmutableList.Builder builder = new ImmutableList.Builder(P_0.size());
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			List elements = (List)iterator.next();
			ImmutableList immutableList = ImmutableList.copyOf(elements);
			if (((List)immutableList).isEmpty())
			{
				ImmutableList result = ImmutableList.of();
				_ = null;
				return result;
			}
			builder.add(immutableList);
		}
		CartesianList result2 = new CartesianList(builder.build());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		22, 104, 130, 103, 115, 130, 103, 98, 104, 103,
		126, 101, 130, 112, 98
	})]
	public override int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (!(P_0 is List))
		{
			return -1;
		}
		List list = (List)P_0;
		if (list.size() != axes.size())
		{
			return -1;
		}
		ListIterator listIterator = list.listIterator();
		int num = 0;
		while (listIterator.hasNext())
		{
			int num2 = listIterator.nextIndex();
			int num3 = ((List)axes.get(num2)).indexOf(listIterator.next());
			if (num3 == -1)
			{
				return -1;
			}
			num += num3 * axesSizeProduct[num2 + 1];
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		44, 104, 130, 103, 115, 130, 103, 98, 104, 103,
		126, 101, 130, 112, 98
	})]
	public override int lastIndexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (!(P_0 is List))
		{
			return -1;
		}
		List list = (List)P_0;
		if (list.size() != axes.size())
		{
			return -1;
		}
		ListIterator listIterator = list.listIterator();
		int num = 0;
		while (listIterator.hasNext())
		{
			int num2 = listIterator.nextIndex();
			int num3 = ((List)axes.get(num2)).lastIndexOf(listIterator.next());
			if (num3 == -1)
			{
				return -1;
			}
			num += num3 * axesSizeProduct[num2 + 1];
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		95, 104, 130, 103, 115, 130, 98, 118, 121, 130,
		100, 98
	})]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (!(P_0 is List))
		{
			return false;
		}
		List list = (List)P_0;
		if (list.size() != axes.size())
		{
			return false;
		}
		int num = 0;
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			object o = iterator.next();
			if (!((List)axes.get(num)).contains(o))
			{
				return false;
			}
			num++;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(32)]
	public override object get(int P_0)
	{
		ImmutableList result = get(P_0);
		_ = null;
		return result;
	}
}
