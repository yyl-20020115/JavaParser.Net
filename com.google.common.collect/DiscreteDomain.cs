using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.math;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<C::Ljava/lang/Comparable;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class DiscreteDomain : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/DiscreteDomain<Ljava/math/BigInteger;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class BigIntegerDomain : DiscreteDomain, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static BigIntegerDomain INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static BigInteger MIN_LONG;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static BigInteger MAX_LONG;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static BigIntegerDomain access_0024300()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(225)]
		public virtual long distance(BigInteger P_0, BigInteger P_1)
		{
			long result = P_1.subtract(P_0).max(MIN_LONG).min(MAX_LONG)
				.longValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(214)]
		public virtual BigInteger previous(BigInteger P_0)
		{
			BigInteger result = P_0.subtract(BigInteger.ONE);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(209)]
		public virtual BigInteger next(BigInteger P_0)
		{
			BigInteger result = P_0.add(BigInteger.ONE);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 105, 108 })]
		internal virtual BigInteger offset(BigInteger P_0, long P_1)
		{
			CollectPreconditions.checkNonnegative(P_1, "distance");
			BigInteger result = P_0.add(BigInteger.valueOf(P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 87, 106 })]
		internal BigIntegerDomain()
			: base(true, null)
		{
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		public override string toString()
		{
			return "DiscreteDomain.bigIntegers()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(196)]
		public override long distance(IComparable P_0, IComparable P_1)
		{
			long result = distance((BigInteger)P_0, (BigInteger)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(196)]
		public override IComparable previous(IComparable P_0)
		{
			BigInteger result = previous((BigInteger)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(196)]
		public override IComparable next(IComparable P_0)
		{
			BigInteger result = next((BigInteger)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(196)]
		internal override IComparable offset(IComparable P_0, long P_1)
		{
			BigInteger result = offset((BigInteger)P_0, P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 160, 84, 234, 70, 115 })]
		static BigIntegerDomain()
		{
			INSTANCE = new BigIntegerDomain();
			MIN_LONG = BigInteger.valueOf(long.MinValue);
			MAX_LONG = BigInteger.valueOf(long.MaxValue);
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
		protected BigIntegerDomain(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
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
	[Signature("Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Integer;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class IntegerDomain : DiscreteDomain, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static IntegerDomain INSTANCE;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static IntegerDomain access_0024000()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(98)]
		public new virtual Integer maxValue()
		{
			Integer result = Integer.valueOf(int.MaxValue);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(93)]
		public new virtual Integer minValue()
		{
			Integer result = Integer.valueOf(int.MinValue);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(88)]
		public virtual long distance(Integer P_0, Integer P_1)
		{
			return (long)P_1.intValue() - (long)P_0.intValue();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 26, 103 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Integer previous(Integer P_0)
		{
			int num = P_0.intValue();
			Integer result = ((num != int.MinValue) ? Integer.valueOf(num - 1) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 19, 103 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Integer next(Integer P_0)
		{
			int num = P_0.intValue();
			Integer result = ((num != int.MaxValue) ? Integer.valueOf(num + 1) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 32, 108 })]
		internal virtual Integer offset(Integer P_0, long P_1)
		{
			CollectPreconditions.checkNonnegative(P_1, "distance");
			Integer result = Integer.valueOf(Ints.checkedCast(P_0.longValue() + P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 13, 106 })]
		internal IntegerDomain()
			: base(true, null)
		{
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		public override string toString()
		{
			return "DiscreteDomain.integers()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(59)]
		public override IComparable maxValue()
		{
			Integer result = maxValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(59)]
		public override IComparable minValue()
		{
			Integer result = minValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(59)]
		public override long distance(IComparable P_0, IComparable P_1)
		{
			long result = distance((Integer)P_0, (Integer)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(59)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override IComparable previous(IComparable P_0)
		{
			Integer result = previous((Integer)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(59)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override IComparable next(IComparable P_0)
		{
			Integer result = next((Integer)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(59)]
		internal override IComparable offset(IComparable P_0, long P_1)
		{
			Integer result = offset((Integer)P_0, P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(60)]
		static IntegerDomain()
		{
			INSTANCE = new IntegerDomain();
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
		protected IntegerDomain(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
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
	[Signature("Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Long;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class LongDomain : DiscreteDomain, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static LongDomain INSTANCE;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static LongDomain access_0024200()
		{
			return INSTANCE;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(172)]
		public new virtual Long maxValue()
		{
			Long result = Long.valueOf(long.MaxValue);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(167)]
		public new virtual Long minValue()
		{
			Long result = Long.valueOf(long.MinValue);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 105, 110, 115, 138, 115, 138 })]
		public virtual long distance(Long P_0, Long P_1)
		{
			long num = P_1.longValue() - P_0.longValue();
			if (P_1.longValue() > P_0.longValue() && num < 0)
			{
				return long.MaxValue;
			}
			if (P_1.longValue() < P_0.longValue() && num > 0)
			{
				return long.MinValue;
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 89, 103 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Long previous(Long P_0)
		{
			long num = P_0.longValue();
			Long result = ((num != long.MinValue) ? Long.valueOf(num - 1) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 82, 103 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Long next(Long P_0)
		{
			long num = P_0.longValue();
			Long result = ((num != long.MaxValue) ? Long.valueOf(num + 1) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 95, 108, 105, 101, 148 })]
		internal virtual Long offset(Long P_0, long P_1)
		{
			CollectPreconditions.checkNonnegative(P_1, "distance");
			long num = P_0.longValue() + P_1;
			if (num < 0)
			{
				Preconditions.checkArgument(P_0.longValue() < 0, (object)"overflow");
			}
			Long result = Long.valueOf(num);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 76, 106 })]
		internal LongDomain()
			: base(true, null)
		{
		}

		private object readResolve()
		{
			return INSTANCE;
		}

		public override string toString()
		{
			return "DiscreteDomain.longs()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(122)]
		public override IComparable maxValue()
		{
			Long result = maxValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(122)]
		public override IComparable minValue()
		{
			Long result = minValue();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(122)]
		public override long distance(IComparable P_0, IComparable P_1)
		{
			long result = distance((Long)P_0, (Long)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(122)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override IComparable previous(IComparable P_0)
		{
			Long result = previous((Long)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(122)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override IComparable next(IComparable P_0)
		{
			Long result = next((Long)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(122)]
		internal override IComparable offset(IComparable P_0, long P_1)
		{
			Long result = offset((Long)P_0, P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(123)]
		static LongDomain()
		{
			INSTANCE = new LongDomain();
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
		protected LongDomain(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			return readResolve();
		}
	}

	[Modifiers(Modifiers.Final)]
	internal bool supportsFastOffset;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TC;")]
	[LineNumberTable(317)]
	public virtual IComparable minValue()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchElementException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TC;")]
	[LineNumberTable(333)]
	public virtual IComparable maxValue()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchElementException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Integer;>;")]
	[LineNumberTable(56)]
	public static DiscreteDomain integers()
	{
		IntegerDomain result = IntegerDomain.access_0024000();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/DiscreteDomain<Ljava/lang/Long;>;")]
	[LineNumberTable(119)]
	public static DiscreteDomain longs()
	{
		LongDomain result = LongDomain.access_0024200();
		_ = null;
		return result;
	}

	[Signature("(TC;)TC;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public abstract IComparable next(IComparable c);

	[Signature("(TC;)TC;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public abstract IComparable previous(IComparable c);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 80, 66, 104, 103 })]
	private DiscreteDomain(bool P_0)
	{
		supportsFastOffset = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/DiscreteDomain<Ljava/math/BigInteger;>;")]
	[LineNumberTable(193)]
	public static DiscreteDomain bigIntegers()
	{
		BigIntegerDomain result = BigIntegerDomain.access_0024300();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 130, 105 })]
	protected internal DiscreteDomain()
		: this(false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;J)TC;")]
	[LineNumberTable(new byte[]
	{
		160,
		143,
		98,
		108,
		106,
		104,
		99,
		byte.MaxValue,
		57,
		61,
		234,
		71
	})]
	internal virtual IComparable offset(IComparable P_0, long P_1)
	{
		IComparable comparable = P_0;
		CollectPreconditions.checkNonnegative(P_1, "distance");
		for (long num = 0L; num < P_1; num++)
		{
			comparable = next(comparable);
			if (comparable == null)
			{
				string text = java.lang.String.valueOf(P_0);
				int num2 = 51 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num2 = num2;
				string s = new StringBuilder(num2).append("overflowed computing offset(").append(text).append(", ")
					.append(P_1)
					.append(")")
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
		}
		return comparable;
	}

	[Signature("(TC;TC;)J")]
	public abstract long distance(IComparable c1, IComparable c2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal DiscreteDomain(bool P_0, _1 P_1)
		: this(P_0)
	{
	}
}
