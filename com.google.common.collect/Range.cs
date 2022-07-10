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
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<C::Ljava/lang/Comparable;>Lcom/google/common/collect/RangeGwtSerializationDependencies;Lcom/google/common/base/Predicate<TC;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.base.Predicate", "java.io.Serializable" })]
public sealed class Range : RangeGwtSerializationDependencies, com.google.common.@base.Predicate, java.util.function.Predicate, Serializable.__Interface, IObjectReference
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(255)]
		static _1()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType = new int[(nint)BoundType.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[BoundType.___003C_003EOPEN.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			_ = null;
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[BoundType.___003C_003ECLOSED.ordinal()] = 2;
				return;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}

		_1()
		{
			throw null;
		}
	}

	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Lcom/google/common/collect/Range;Lcom/google/common/collect/Cut;>;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class LowerBoundFn : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static LowerBoundFn INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(130)]
		public virtual Cut apply(Range P_0)
		{
			return P_0.lowerBound;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(125)]
		internal LowerBoundFn()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(125)]
		public virtual object apply(object P_0)
		{
			Cut result = apply((Range)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(126)]
		static LowerBoundFn()
		{
			INSTANCE = new LowerBoundFn();
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Lcom/google/common/collect/Ordering<Lcom/google/common/collect/Range<*>;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class RangeLexOrdering : Ordering, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Ordering<Lcom/google/common/collect/Range<*>;>;")]
		internal static Ordering INSTANCE;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<*>;Lcom/google/common/collect/Range<*>;)I")]
		[LineNumberTable(new byte[] { 162, 101, 113, 113, 101, 231, 61 })]
		public virtual int compare(Range P_0, Range P_1)
		{
			int result = ComparisonChain.start().compare(P_0.lowerBound, P_1.lowerBound).compare(P_0.upperBound, P_1.upperBound)
				.result();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(722)]
		private RangeLexOrdering()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(722)]
		public override int compare(object P_0, object P_1)
		{
			int result = compare((Range)P_0, (Range)P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(723)]
		static RangeLexOrdering()
		{
			INSTANCE = new RangeLexOrdering();
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
		protected RangeLexOrdering(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Lcom/google/common/collect/Range;Lcom/google/common/collect/Cut;>;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class UpperBoundFn : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static UpperBoundFn INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(139)]
		public virtual Cut apply(Range P_0)
		{
			return P_0.upperBound;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(134)]
		internal UpperBoundFn()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(134)]
		public virtual object apply(object P_0)
		{
			Cut result = apply((Range)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(135)]
		static UpperBoundFn()
		{
			INSTANCE = new UpperBoundFn();
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Range<Ljava/lang/Comparable;>;")]
	private static Range ALL;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Cut<TC;>;")]
	internal Cut lowerBound;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Cut<TC;>;")]
	internal Cut upperBound;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Signature("<C::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/Range<TC;>;")]
	public static Range all()
	{
		return ALL;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(366)]
	public virtual bool hasLowerBound()
	{
		return lowerBound != Cut.belowAll();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(280)]
	public static Range atLeast(IComparable endpoint)
	{
		Range result = create(Cut.belowValue(endpoint), Cut.aboveAll());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[]
	{
		161, 181, 114, 114, 104, 98, 104, 130, 115, 179,
		98, 50, 229, 71
	})]
	public virtual Range intersection(Range connectedRange)
	{
		int num = lowerBound.compareTo(connectedRange.lowerBound);
		int num2 = upperBound.compareTo(connectedRange.upperBound);
		if (num >= 0 && num2 <= 0)
		{
			return this;
		}
		if (num <= 0 && num2 >= 0)
		{
			return connectedRange;
		}
		Cut cut = ((num < 0) ? connectedRange.lowerBound : lowerBound);
		Cut cut2 = ((num2 > 0) ? connectedRange.upperBound : upperBound);
		Preconditions.checkArgument(cut.compareTo(cut2) <= 0, "intersection is undefined for disconnected ranges %s and %s", this, connectedRange);
		Range result = create(cut, cut2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(392)]
	public virtual bool hasUpperBound()
	{
		return upperBound != Cut.aboveAll();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(245)]
	public static Range atMost(IComparable endpoint)
	{
		Range result = create(Cut.belowAll(), Cut.aboveValue(endpoint));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(426)]
	public virtual bool isEmpty()
	{
		bool result = lowerBound.equals(upperBound);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(718)]
	internal static int compareOrThrow(IComparable P_0, IComparable P_1)
	{
		int result = Comparable.__Helper.compareTo(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(183)]
	public static Range closed(IComparable lower, IComparable upper)
	{
		Range result = create(Cut.belowValue(lower), Cut.aboveValue(upper));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(195)]
	public static Range closedOpen(IComparable lower, IComparable upper)
	{
		Range result = create(Cut.belowValue(lower), Cut.belowValue(upper));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(697)]
	public override string toString()
	{
		string result = toString(lowerBound, upperBound);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TC;")]
	[LineNumberTable(376)]
	public virtual IComparable lowerEndpoint()
	{
		IComparable result = lowerBound.endpoint();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(387)]
	public virtual BoundType lowerBoundType()
	{
		BoundType result = lowerBound.typeAsLowerBound();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TC;")]
	[LineNumberTable(402)]
	public virtual IComparable upperEndpoint()
	{
		IComparable result = upperBound.endpoint();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(413)]
	public virtual BoundType upperBoundType()
	{
		BoundType result = upperBound.typeAsUpperBound();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>()Lcom/google/common/base/Function<Lcom/google/common/collect/Range<TC;>;Lcom/google/common/collect/Cut<TC;>;>;")]
	[LineNumberTable(145)]
	internal static com.google.common.@base.Function lowerBoundFn()
	{
		return LowerBoundFn.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Z")]
	[LineNumberTable(new byte[] { 161, 65, 135 })]
	public virtual bool contains(IComparable value)
	{
		Preconditions.checkNotNull(value);
		return (lowerBound.isLessThan(value) && !upperBound.isLessThan(value)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Cut<TC;>;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(158)]
	internal static Range create(Cut P_0, Cut P_1)
	{
		Range result = new Range(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/Ordering<Lcom/google/common/collect/Range<TC;>;>;")]
	[LineNumberTable(154)]
	internal static Ordering rangeLexOrdering()
	{
		return RangeLexOrdering.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	[LineNumberTable(new byte[] { 161, 130, 127, 1, 44 })]
	public virtual bool encloses(Range other)
	{
		return (lowerBound.compareTo(other.lowerBound) <= 0 && upperBound.compareTo(other.upperBound) >= 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>()Lcom/google/common/base/Function<Lcom/google/common/collect/Range<TC;>;Lcom/google/common/collect/Cut<TC;>;>;")]
	[LineNumberTable(150)]
	internal static com.google.common.@base.Function upperBoundFn()
	{
		return UpperBoundFn.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	[LineNumberTable(new byte[] { 161, 160, 127, 1, 44 })]
	public virtual bool isConnected(Range other)
	{
		return (lowerBound.compareTo(other.upperBound) <= 0 && other.lowerBound.compareTo(upperBound) <= 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 52, 104, 103, 159, 12 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		if (@object is Range)
		{
			Range range = (Range)@object;
			return (lowerBound.equals(range.lowerBound) && upperBound.equals(range.upperBound)) ? true : false;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 162, 37, 103, 109, 109 })]
	public virtual Range canonical(DiscreteDomain domain)
	{
		Preconditions.checkNotNull(domain);
		Cut cut = lowerBound.canonical(domain);
		Cut cut2 = upperBound.canonical(domain);
		Range result = ((cut != lowerBound || cut2 != upperBound) ? create(cut, cut2) : this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 160, 141, 157, 137, 137 })]
	public static Range upTo(IComparable endpoint, BoundType boundType)
	{
		switch (_1._0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[boundType.ordinal()])
		{
		case 1:
		{
			Range result2 = lessThan(endpoint);
			_ = null;
			return result2;
		}
		case 2:
		{
			Range result = atMost(endpoint);
			_ = null;
			return result;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;Lcom/google/common/collect/BoundType;TC;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 160, 106, 103, 167, 151, 119 })]
	public static Range range(IComparable lower, BoundType lowerType, IComparable upper, BoundType upperType)
	{
		Preconditions.checkNotNull(lowerType);
		Preconditions.checkNotNull(upperType);
		Cut cut = ((lowerType != BoundType.___003C_003EOPEN) ? Cut.belowValue(lower) : Cut.aboveValue(lower));
		Cut cut2 = ((upperType != BoundType.___003C_003EOPEN) ? Cut.aboveValue(upper) : Cut.belowValue(upper));
		Range result = create(cut, cut2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 160, 176, 157, 137, 137 })]
	public static Range downTo(IComparable endpoint, BoundType boundType)
	{
		switch (_1._0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[boundType.ordinal()])
		{
		case 1:
		{
			Range result2 = greaterThan(endpoint);
			_ = null;
			return result2;
		}
		case 2:
		{
			Range result = atLeast(endpoint);
			_ = null;
			return result;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[]
	{
		161,
		byte.MaxValue,
		114,
		114,
		104,
		98,
		104,
		130,
		115,
		115
	})]
	public virtual Range span(Range other)
	{
		int num = lowerBound.compareTo(other.lowerBound);
		int num2 = upperBound.compareTo(other.upperBound);
		if (num <= 0 && num2 >= 0)
		{
			return this;
		}
		if (num >= 0 && num2 <= 0)
		{
			return other;
		}
		Cut cut = ((num > 0) ? other.lowerBound : lowerBound);
		Cut cut2 = ((num2 < 0) ? other.upperBound : upperBound);
		Range result = create(cut, cut2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Cut<TC;>;)V")]
	[LineNumberTable(new byte[] { 160, 240, 104, 113, 113, 107, 104, 103, 159, 22 })]
	private Range(Cut P_0, Cut P_1)
	{
		lowerBound = (Cut)Preconditions.checkNotNull(P_0);
		upperBound = (Cut)Preconditions.checkNotNull(P_1);
		if (P_0.compareTo(P_1) > 0 || P_0 == Cut.aboveAll() || P_1 == Cut.belowAll())
		{
			string text = java.lang.String.valueOf(toString(P_0, P_1));
			string s;
			if (java.lang.String.instancehelper_length(text) != 0)
			{
				s = java.lang.String.instancehelper_concat("Invalid range: ", text);
			}
			else
			{
				string text2 = "Invalid range: ";
				text2 = text2;
				s = java.lang.String.newhelper(text2);
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(236)]
	public static Range lessThan(IComparable endpoint)
	{
		Range result = create(Cut.belowAll(), Cut.belowValue(endpoint));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(271)]
	public static Range greaterThan(IComparable endpoint)
	{
		Range result = create(Cut.aboveValue(endpoint), Cut.aboveAll());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Cut<*>;Lcom/google/common/collect/Cut<*>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[] { 162, 75, 104, 103, 108, 103 })]
	private static string toString(Cut P_0, Cut P_1)
	{
		StringBuilder stringBuilder = new StringBuilder(16);
		P_0.describeAsLowerBound(stringBuilder);
		stringBuilder.append("..");
		P_1.describeAsUpperBound(stringBuilder);
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TC;)Z")]
	[LineNumberTable(447)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual bool apply(IComparable input)
	{
		bool result = contains(input);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(171)]
	public static Range open(IComparable lower, IComparable upper)
	{
		Range result = create(Cut.aboveValue(lower), Cut.belowValue(upper));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(207)]
	public static Range openClosed(IComparable lower, IComparable upper)
	{
		Range result = create(Cut.aboveValue(lower), Cut.aboveValue(upper));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(319)]
	public static Range singleton(IComparable value)
	{
		Range result = closed(value, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(Ljava/lang/Iterable<TC;>;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[]
	{
		160, 218, 103, 104, 103, 103, 112, 190, 103, 118,
		99, 104, 119, 115, 117, 98
	})]
	public static Range encloseAll(Iterable values)
	{
		Preconditions.checkNotNull(values);
		if (values is SortedSet)
		{
			SortedSet sortedSet = (SortedSet)values;
			Comparator comparator = sortedSet.comparator();
			if (java.lang.Object.instancehelper_equals(Ordering.natural(), comparator) || comparator == null)
			{
				Range result = closed((IComparable)sortedSet.first(), (IComparable)sortedSet.last());
				_ = null;
				return result;
			}
		}
		Iterator iterator = values.iterator();
		IComparable comparable = (IComparable)Preconditions.checkNotNull((IComparable)iterator.next());
		IComparable comparable2 = comparable;
		while (iterator.hasNext())
		{
			IComparable b = (IComparable)Preconditions.checkNotNull((IComparable)iterator.next());
			comparable = (IComparable)Ordering.natural().min(comparable, b);
			comparable2 = (IComparable)Ordering.natural().max(comparable2, b);
		}
		Range result2 = closed(comparable, comparable2);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TC;>;)Z")]
	[LineNumberTable(new byte[]
	{
		161, 85, 104, 194, 104, 103, 103, 112, 223, 12,
		123, 105, 130, 98
	})]
	public virtual bool containsAll(Iterable values)
	{
		if (Iterables.isEmpty(values))
		{
			return true;
		}
		if (values is SortedSet)
		{
			SortedSet sortedSet = (SortedSet)values;
			Comparator comparator = sortedSet.comparator();
			if (java.lang.Object.instancehelper_equals(Ordering.natural(), comparator) || comparator == null)
			{
				return (contains((IComparable)sortedSet.first()) && contains((IComparable)sortedSet.last())) ? true : false;
			}
		}
		Iterator iterator = values.iterator();
		while (iterator.hasNext())
		{
			IComparable value = (IComparable)iterator.next();
			if (!contains(value))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 161, 231, 127, 4, 107, 223, 66, 117, 105, 105 })]
	public virtual Range gap(Range otherRange)
	{
		if (lowerBound.compareTo(otherRange.upperBound) < 0 && otherRange.lowerBound.compareTo(upperBound) < 0)
		{
			string text = java.lang.String.valueOf(this);
			string text2 = java.lang.String.valueOf(otherRange);
			int num = 39 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
			num = num;
			string s = new StringBuilder(num).append("Ranges have a nonempty intersection: ").append(text).append(", ")
				.append(text2)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		int num2 = ((lowerBound.compareTo(otherRange.lowerBound) < 0) ? 1 : 0);
		Range range = ((num2 == 0) ? otherRange : this);
		Range range2 = ((num2 == 0) ? this : otherRange);
		Range result = create(range.upperBound, range2.lowerBound);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(688)]
	public override int hashCode()
	{
		return lowerBound.hashCode() * 31 + upperBound.hashCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 83, 109, 136 })]
	internal virtual object readResolve()
	{
		if (equals(ALL))
		{
			Range result = all();
			_ = null;
			return result;
		}
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(119)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual bool apply(object obj)
	{
		bool result = apply((IComparable)obj);
		_ = null;
		return result;
	}

	[LineNumberTable(300)]
	static Range()
	{
		ALL = new Range(Cut.belowAll(), Cut.aboveAll());
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool test(object P_0)
	{
		return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
	{
		return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Predicate negate()
	{
		return java.util.function.Predicate._003Cdefault_003Enegate(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
	{
		return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
	}

	[HideFromJava]
	public static implicit operator Serializable(Range P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Range(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}

	[SecurityCritical]
	[HideFromJava]
	object IObjectReference.GetRealObject(StreamingContext P_0)
	{
		return readResolve();
	}
}
