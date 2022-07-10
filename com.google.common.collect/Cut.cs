using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<C::Ljava/lang/Comparable;>Ljava/lang/Object;Ljava/lang/Comparable<Lcom/google/common/collect/Cut<TC;>;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Comparable", "java.io.Serializable" })]
internal abstract class Cut : java.lang.Object, Comparable, Serializable.__Interface, ISerializable
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

		[LineNumberTable(336)]
		static _1()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType = new int[(nint)BoundType.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[BoundType.___003C_003ECLOSED.ordinal()] = 1;
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
				_0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[BoundType.___003C_003EOPEN.ordinal()] = 2;
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;")]
	internal sealed class AboveAll : Cut, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static AboveAll INSTANCE;

		private new const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static AboveAll access_0024100()
		{
			return INSTANCE;
		}

		[Signature("(Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;)I")]
		public override int compareTo(Cut P_0)
		{
			return (P_0 != this) ? 1 : 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 119, 109 })]
		private AboveAll()
			: base("")
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/lang/Comparable<*>;")]
		[LineNumberTable(238)]
		internal override IComparable endpoint()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException("range unbounded on this side");
		}

		[Signature("(Ljava/lang/Comparable<*>;)Z")]
		internal override bool isLessThan(IComparable P_0)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(248)]
		internal override BoundType typeAsLowerBound()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("this statement should be unreachable");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(253)]
		internal override BoundType typeAsUpperBound()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;")]
		[LineNumberTable(259)]
		internal override Cut withLowerBoundType(BoundType P_0, DiscreteDomain P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("this statement should be unreachable");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;")]
		[LineNumberTable(265)]
		internal override Cut withUpperBoundType(BoundType P_0, DiscreteDomain P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(270)]
		internal override void describeAsLowerBound(StringBuilder P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 161, 108 })]
		internal override void describeAsUpperBound(StringBuilder P_0)
		{
			P_0.append("+∞)");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Ljava/lang/Comparable<*>;")]
		[LineNumberTable(280)]
		internal override IComparable leastValueAbove(DiscreteDomain P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Ljava/lang/Comparable<*>;")]
		[LineNumberTable(285)]
		internal override IComparable greatestValueBelow(DiscreteDomain P_0)
		{
			IComparable result = P_0.maxValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(295)]
		public override int hashCode()
		{
			int result = java.lang.System.identityHashCode(this);
			_ = null;
			return result;
		}

		public override string toString()
		{
			return "+∞";
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(228)]
		public override int compareTo(object P_0)
		{
			int result = compareTo((Cut)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(229)]
		static AboveAll()
		{
			INSTANCE = new AboveAll();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected AboveAll(SerializationInfo P_0, StreamingContext P_1)
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<C::Ljava/lang/Comparable;>Lcom/google/common/collect/Cut<TC;>;")]
	internal sealed class AboveValue : Cut
	{
		private new const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)V")]
		[LineNumberTable(new byte[] { 161, 30, 115 })]
		internal AboveValue(IComparable P_0)
			: base((IComparable)Preconditions.checkNotNull(P_0))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)TC;")]
		[LineNumberTable(457)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override IComparable leastValueAbove(DiscreteDomain P_0)
		{
			IComparable result = P_0.next(base.endpoint);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Z")]
		[LineNumberTable(405)]
		internal override bool isLessThan(IComparable P_0)
		{
			return Range.compareOrThrow(base.endpoint, P_0) < 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(410)]
		internal override BoundType typeAsLowerBound()
		{
			return BoundType.___003C_003EOPEN;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(415)]
		internal override BoundType typeAsUpperBound()
		{
			return BoundType.___003C_003ECLOSED;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Cut<TC;>;")]
		[LineNumberTable(new byte[] { 161, 50, 157, 130, 109, 147 })]
		internal override Cut withLowerBoundType(BoundType P_0, DiscreteDomain P_1)
		{
			switch (_1._0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[P_0.ordinal()])
			{
			case 2:
				return this;
			case 1:
			{
				IComparable comparable = P_1.next(base.endpoint);
				Cut result = ((comparable != null) ? belowValue(comparable) : belowAll());
				_ = null;
				return result;
			}
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Cut<TC;>;")]
		[LineNumberTable(new byte[] { 161, 63, 157, 109, 147, 130 })]
		internal override Cut withUpperBoundType(BoundType P_0, DiscreteDomain P_1)
		{
			switch (_1._0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[P_0.ordinal()])
			{
			case 2:
			{
				IComparable comparable = P_1.next(base.endpoint);
				Cut result = ((comparable != null) ? belowValue(comparable) : aboveAll());
				_ = null;
				return result;
			}
			case 1:
				return this;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 76, 116 })]
		internal override void describeAsLowerBound(StringBuilder P_0)
		{
			P_0.append('(').append(base.endpoint);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 81, 116 })]
		internal override void describeAsUpperBound(StringBuilder P_0)
		{
			P_0.append(base.endpoint).append(']');
		}

		[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)TC;")]
		internal override IComparable greatestValueBelow(DiscreteDomain P_0)
		{
			return base.endpoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Cut<TC;>;")]
		[LineNumberTable(new byte[] { 161, 97, 104 })]
		internal override Cut canonical(DiscreteDomain P_0)
		{
			IComparable comparable = leastValueAbove(P_0);
			Cut result = ((comparable == null) ? aboveAll() : belowValue(comparable));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(473)]
		public override int hashCode()
		{
			return java.lang.Object.instancehelper_hashCode(base.endpoint) ^ -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(478)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(base.endpoint);
			int num = 2 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("/").append(text).append("\\")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(398)]
		public override int compareTo(object P_0)
		{
			int result = base.compareTo((Cut)P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected AboveValue(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;")]
	internal sealed class BelowAll : Cut, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static BelowAll INSTANCE;

		private new const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static BelowAll access_0024000()
		{
			return INSTANCE;
		}

		[Signature("(Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;)I")]
		public override int compareTo(Cut P_0)
		{
			return (P_0 != this) ? (-1) : 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 83, 109 })]
		private BelowAll()
			: base("")
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/lang/Comparable<*>;")]
		[LineNumberTable(138)]
		internal override IComparable endpoint()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException("range unbounded on this side");
		}

		[Signature("(Ljava/lang/Comparable<*>;)Z")]
		internal override bool isLessThan(IComparable P_0)
		{
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(148)]
		internal override BoundType typeAsLowerBound()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(153)]
		internal override BoundType typeAsUpperBound()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("this statement should be unreachable");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;")]
		[LineNumberTable(159)]
		internal override Cut withLowerBoundType(BoundType P_0, DiscreteDomain P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;")]
		[LineNumberTable(165)]
		internal override Cut withUpperBoundType(BoundType P_0, DiscreteDomain P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("this statement should be unreachable");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 120, 108 })]
		internal override void describeAsLowerBound(StringBuilder P_0)
		{
			P_0.append("(-∞");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(175)]
		internal override void describeAsUpperBound(StringBuilder P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Ljava/lang/Comparable<*>;")]
		[LineNumberTable(180)]
		internal override IComparable leastValueAbove(DiscreteDomain P_0)
		{
			IComparable result = P_0.minValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Ljava/lang/Comparable<*>;")]
		[LineNumberTable(185)]
		internal override IComparable greatestValueBelow(DiscreteDomain P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Comparable<*>;>;)Lcom/google/common/collect/Cut<Ljava/lang/Comparable<*>;>;")]
		[LineNumberTable(new byte[] { 160, 77, 122, 97 })]
		internal override Cut canonical(DiscreteDomain P_0)
		{
			//Discarded unreachable code: IL_000d
			try
			{
				return belowValue(P_0.minValue());
			}
			catch (NoSuchElementException)
			{
			}
			_ = null;
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(204)]
		public override int hashCode()
		{
			int result = java.lang.System.identityHashCode(this);
			_ = null;
			return result;
		}

		public override string toString()
		{
			return "-∞";
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(123)]
		public override int compareTo(object P_0)
		{
			int result = compareTo((Cut)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(124)]
		static BelowAll()
		{
			INSTANCE = new BelowAll();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected BelowAll(SerializationInfo P_0, StreamingContext P_1)
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<C::Ljava/lang/Comparable;>Lcom/google/common/collect/Cut<TC;>;")]
	internal sealed class BelowValue : Cut
	{
		private new const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)V")]
		[LineNumberTable(new byte[] { 160, 202, 115 })]
		internal BelowValue(IComparable P_0)
			: base((IComparable)Preconditions.checkNotNull(P_0))
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Z")]
		[LineNumberTable(321)]
		internal override bool isLessThan(IComparable P_0)
		{
			return Range.compareOrThrow(base.endpoint, P_0) <= 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(326)]
		internal override BoundType typeAsLowerBound()
		{
			return BoundType.___003C_003ECLOSED;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(331)]
		internal override BoundType typeAsUpperBound()
		{
			return BoundType.___003C_003EOPEN;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Cut<TC;>;")]
		[LineNumberTable(new byte[] { 160, 222, 157, 130, 109, 147 })]
		internal override Cut withLowerBoundType(BoundType P_0, DiscreteDomain P_1)
		{
			switch (_1._0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[P_0.ordinal()])
			{
			case 1:
				return this;
			case 2:
			{
				IComparable comparable = P_1.previous(base.endpoint);
				Cut result = ((comparable != null) ? new AboveValue(comparable) : belowAll());
				_ = null;
				return result;
			}
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Cut<TC;>;")]
		[LineNumberTable(new byte[] { 160, 235, 157, 109, 147, 130 })]
		internal override Cut withUpperBoundType(BoundType P_0, DiscreteDomain P_1)
		{
			switch (_1._0024SwitchMap_0024com_0024google_0024common_0024collect_0024BoundType[P_0.ordinal()])
			{
			case 1:
			{
				IComparable comparable = P_1.previous(base.endpoint);
				Cut result = ((comparable != null) ? new AboveValue(comparable) : aboveAll());
				_ = null;
				return result;
			}
			case 2:
				return this;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 248, 116 })]
		internal override void describeAsLowerBound(StringBuilder P_0)
		{
			P_0.append('[').append(base.endpoint);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 253, 116 })]
		internal override void describeAsUpperBound(StringBuilder P_0)
		{
			P_0.append(base.endpoint).append(')');
		}

		[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)TC;")]
		internal override IComparable leastValueAbove(DiscreteDomain P_0)
		{
			return base.endpoint;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)TC;")]
		[LineNumberTable(378)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override IComparable greatestValueBelow(DiscreteDomain P_0)
		{
			IComparable result = P_0.previous(base.endpoint);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(383)]
		public override int hashCode()
		{
			int result = java.lang.Object.instancehelper_hashCode(base.endpoint);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(388)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(base.endpoint);
			int num = 2 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("\\").append(text).append("/")
				.toString();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(314)]
		public override int compareTo(object P_0)
		{
			int result = base.compareTo((Cut)P_0);
			_ = null;
			return result;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected BelowValue(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Modifiers(Modifiers.Final)]
	[Signature("TC;")]
	internal IComparable endpoint;

	private const long serialVersionUID = 0L;

	[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)TC;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal abstract IComparable leastValueAbove(DiscreteDomain P_0);

	[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)TC;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal abstract IComparable greatestValueBelow(DiscreteDomain P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable;>()Lcom/google/common/collect/Cut<TC;>;")]
	[LineNumberTable(118)]
	internal static Cut belowAll()
	{
		BelowAll result = BelowAll.access_0024000();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable;>()Lcom/google/common/collect/Cut<TC;>;")]
	[LineNumberTable(225)]
	internal static Cut aboveAll()
	{
		AboveAll result = AboveAll.access_0024100();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Cut<TC;>;)I")]
	[LineNumberTable(new byte[] { 24, 104, 130, 104, 130, 114, 99, 162 })]
	public virtual int compareTo(Cut P_0)
	{
		if (P_0 == belowAll())
		{
			return 1;
		}
		if (P_0 == aboveAll())
		{
			return -1;
		}
		int num = Range.compareOrThrow(this.endpoint, P_0.endpoint);
		if (num != 0)
		{
			return num;
		}
		int result = Booleans.compare(this is AboveValue, P_0 is AboveValue);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)V")]
	[LineNumberTable(new byte[] { 159, 181, 104, 103 })]
	internal Cut(IComparable P_0)
	{
		this.endpoint = P_0;
	}

	[Signature("(TC;)Z")]
	internal abstract bool isLessThan(IComparable P_0);

	internal abstract BoundType typeAsLowerBound();

	internal abstract BoundType typeAsUpperBound();

	[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Cut<TC;>;")]
	internal abstract Cut withLowerBoundType(BoundType P_0, DiscreteDomain P_1);

	[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Cut<TC;>;")]
	internal abstract Cut withUpperBoundType(BoundType P_0, DiscreteDomain P_1);

	internal abstract void describeAsLowerBound(StringBuilder P_0);

	internal abstract void describeAsUpperBound(StringBuilder P_0);

	[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/Cut<TC;>;")]
	internal virtual Cut canonical(DiscreteDomain P_0)
	{
		return this;
	}

	[Signature("()TC;")]
	internal virtual IComparable endpoint()
	{
		return this.endpoint;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 45, 136, 135, 104, 127, 1, 97, 162 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		//Discarded unreachable code: IL_0020
		if (P_0 is Cut)
		{
			Cut cut = (Cut)P_0;
			try
			{
				return (compareTo(cut) == 0) ? true : false;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
			return false;
		}
		return false;
	}

	public abstract override int hashCode();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable;>(TC;)Lcom/google/common/collect/Cut<TC;>;")]
	[LineNumberTable(311)]
	internal static Cut belowValue(IComparable P_0)
	{
		BelowValue result = new BelowValue(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable;>(TC;)Lcom/google/common/collect/Cut<TC;>;")]
	[LineNumberTable(395)]
	internal static Cut aboveValue(IComparable P_0)
	{
		AboveValue result = new AboveValue(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public virtual int compareTo(object P_0)
	{
		int result = compareTo((Cut)P_0);
		_ = null;
		return result;
	}

	int IComparable.Comparable_003A_003AcompareTo(object P_0)
	{
		return compareTo(P_0);
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
	protected Cut(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
