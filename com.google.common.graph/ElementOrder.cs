using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;")]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public sealed class ElementOrder : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(192)]
		static _1()
		{
			_0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type = new int[(nint)Type.values().LongLength];
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[Type.___003C_003EUNORDERED.ordinal()] = 1;
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
				_0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[Type.___003C_003EINSERTION.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			_ = null;
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[Type.___003C_003ESTABLE.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			_ = null;
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[Type.___003C_003ESORTED.ordinal()] = 4;
				return;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
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
	[InnerClass(null, Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/graph/ElementOrder$Type;>;")]
	[Modifiers(Modifiers.Public | Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	public sealed class Type : java.lang.Enum
	{
		[Serializable]
		[HideFromJava]
		public enum __Enum
		{
			UNORDERED,
			STABLE,
			INSERTION,
			SORTED
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Type ___003C_003EUNORDERED;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Type ___003C_003ESTABLE;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Type ___003C_003EINSERTION;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		internal static Type ___003C_003ESORTED;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Type[] _0024VALUES;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Type UNORDERED
		{
			[HideFromJava]
			get
			{
				return ___003C_003EUNORDERED;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Type STABLE
		{
			[HideFromJava]
			get
			{
				return ___003C_003ESTABLE;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Type INSERTION
		{
			[HideFromJava]
			get
			{
				return ___003C_003EINSERTION;
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Type SORTED
		{
			[HideFromJava]
			get
			{
				return ___003C_003ESORTED;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(68)]
		public static Type[] values()
		{
			return (Type[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(68)]
		private Type(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(68)]
		private static Type[] _0024values()
		{
			return new Type[4] { ___003C_003EUNORDERED, ___003C_003ESTABLE, ___003C_003EINSERTION, ___003C_003ESORTED };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(68)]
		public static Type valueOf(string name)
		{
			return (Type)java.lang.Enum.valueOf(ClassLiteral<Type>.Value, name);
		}

		[LineNumberTable(new byte[] { 19, 112, 112, 112, 240, 60 })]
		static Type()
		{
			___003C_003EUNORDERED = new Type("UNORDERED", 0);
			___003C_003ESTABLE = new Type("STABLE", 1);
			___003C_003EINSERTION = new Type("INSERTION", 2);
			___003C_003ESORTED = new Type("SORTED", 3);
			_0024VALUES = _0024values();
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Type m_type;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Comparator<TT;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Comparator m_comparator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:Ljava/lang/Object;>()Lcom/google/common/graph/ElementOrder<TS;>;")]
	[LineNumberTable(83)]
	public static ElementOrder unordered()
	{
		ElementOrder result = new ElementOrder(Type.___003C_003EUNORDERED, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:Ljava/lang/Object;>()Lcom/google/common/graph/ElementOrder<TS;>;")]
	[LineNumberTable(128)]
	public static ElementOrder insertion()
	{
		ElementOrder result = new ElementOrder(Type.___003C_003EINSERTION, null);
		_ = null;
		return result;
	}

	public virtual Type type()
	{
		return this.m_type;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/ElementOrder$Type;Ljava/util/Comparator<TT;>;)V")]
	[LineNumberTable(new byte[] { 25, 104, 113, 103, 120 })]
	private ElementOrder(Type P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_1)
	{
		this.m_type = (Type)Preconditions.checkNotNull(P_0);
		this.m_comparator = P_1;
		Preconditions.checkState(P_0 == Type.___003C_003ESORTED == (P_1 != null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<TT;>;")]
	[LineNumberTable(new byte[] { 107, 104, 135 })]
	public virtual Comparator comparator()
	{
		if (this.m_comparator != null)
		{
			return this.m_comparator;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException("This ordering does not define a comparator.");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:Ljava/lang/Object;>()Lcom/google/common/graph/ElementOrder<TS;>;")]
	[LineNumberTable(123)]
	public static ElementOrder stable()
	{
		ElementOrder result = new ElementOrder(Type.___003C_003ESTABLE, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S::Ljava/lang/Comparable<-TS;>;>()Lcom/google/common/graph/ElementOrder<TS;>;")]
	[LineNumberTable(135)]
	public static ElementOrder natural()
	{
		ElementOrder result = new ElementOrder(Type.___003C_003ESORTED, Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:Ljava/lang/Object;>(Ljava/util/Comparator<TS;>;)Lcom/google/common/graph/ElementOrder<TS;>;")]
	[LineNumberTable(143)]
	public static ElementOrder sorted(Comparator comparator)
	{
		ElementOrder result = new ElementOrder(Type.___003C_003ESORTED, (Comparator)Preconditions.checkNotNull(comparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 115, 100, 130, 104, 162, 103 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is ElementOrder))
		{
			return false;
		}
		ElementOrder elementOrder = (ElementOrder)obj;
		return (this.m_type == elementOrder.m_type && com.google.common.@base.Objects.equal(this.m_comparator, elementOrder.m_comparator)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(178)]
	public override int hashCode()
	{
		int result = com.google.common.@base.Objects.hashCode(this.m_type, this.m_comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 69, 119, 104, 146 })]
	public override string toString()
	{
		MoreObjects.ToStringHelper toStringHelper = MoreObjects.toStringHelper(this).add("type", this.m_type);
		if (this.m_comparator != null)
		{
			toStringHelper.add("comparator", this.m_comparator);
		}
		string result = toStringHelper.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:TT;V:Ljava/lang/Object;>(I)Ljava/util/Map<TK;TV;>;")]
	[LineNumberTable(new byte[] { 160, 78, 159, 11, 169, 137, 142 })]
	internal virtual Map createMap(int P_0)
	{
		switch (_1._0024SwitchMap_0024com_0024google_0024common_0024graph_0024ElementOrder_0024Type[this.m_type.ordinal()])
		{
		case 1:
		{
			HashMap result3 = Maps.newHashMapWithExpectedSize(P_0);
			_ = null;
			return result3;
		}
		case 2:
		case 3:
		{
			LinkedHashMap result2 = Maps.newLinkedHashMapWithExpectedSize(P_0);
			_ = null;
			return result2;
		}
		case 4:
		{
			TreeMap result = Maps.newTreeMap(comparator());
			_ = null;
			return result;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[Signature("<T1:TT;>()Lcom/google/common/graph/ElementOrder<TT1;>;")]
	internal virtual ElementOrder cast()
	{
		return this;
	}
}
