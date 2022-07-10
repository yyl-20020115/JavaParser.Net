using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.math;
using javax.annotation;

namespace com.google.common.primitives;

[Serializable]
[Signature("Ljava/lang/Number;Ljava/lang/Comparable<Lcom/google/common/primitives/UnsignedLong;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Comparable", "java.io.Serializable" })]
public sealed class UnsignedLong : Number, Comparable, Serializable.__Interface
{
	private const long UNSIGNED_MASK = long.MaxValue;

	internal static UnsignedLong ___003C_003EZERO;

	internal static UnsignedLong ___003C_003EONE;

	internal static UnsignedLong ___003C_003EMAX_VALUE;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private long value;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static UnsignedLong ZERO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EZERO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static UnsignedLong ONE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EONE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static UnsignedLong MAX_VALUE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EMAX_VALUE;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 104, 103 })]
	private UnsignedLong(long P_0)
	{
		value = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(71)]
	public static UnsignedLong fromLongBits(long bits)
	{
		UnsignedLong result = new UnsignedLong(bits);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	public static UnsignedLong valueOf(string @string, int radix)
	{
		UnsignedLong result = fromLongBits(UnsignedLongs.parseUnsignedLong(@string, radix));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 121, 103 })]
	public virtual int compareTo(UnsignedLong o)
	{
		Preconditions.checkNotNull(o);
		int result = UnsignedLongs.compare(value, o.value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 32, 115 })]
	public static UnsignedLong valueOf(long value)
	{
		Preconditions.checkArgument(value >= 0, "value (%s) is outside the range for an unsigned long value", value);
		UnsignedLong result = fromLongBits(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 44, 103, 97, 60, 197 })]
	public static UnsignedLong valueOf(BigInteger value)
	{
		Preconditions.checkNotNull(value);
		Preconditions.checkArgument((value.signum() >= 0 && value.bitLength() <= 64) ? true : false, "value (%s) is outside the range for an unsigned long value", value);
		UnsignedLong result = fromLongBits(value.longValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(111)]
	public static UnsignedLong valueOf(string @string)
	{
		UnsignedLong result = valueOf(@string, 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(134)]
	public virtual UnsignedLong plus(UnsignedLong val)
	{
		UnsignedLong result = fromLongBits(value + ((UnsignedLong)Preconditions.checkNotNull(val)).value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(144)]
	public virtual UnsignedLong minus(UnsignedLong val)
	{
		UnsignedLong result = fromLongBits(value - ((UnsignedLong)Preconditions.checkNotNull(val)).value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(154)]
	public virtual UnsignedLong times(UnsignedLong val)
	{
		UnsignedLong result = fromLongBits(value * ((UnsignedLong)Preconditions.checkNotNull(val)).value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(163)]
	public virtual UnsignedLong dividedBy(UnsignedLong val)
	{
		UnsignedLong result = fromLongBits(UnsignedLongs.divide(value, ((UnsignedLong)Preconditions.checkNotNull(val)).value));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(172)]
	public virtual UnsignedLong mod(UnsignedLong val)
	{
		UnsignedLong result = fromLongBits(UnsignedLongs.remainder(value, ((UnsignedLong)Preconditions.checkNotNull(val)).value));
		_ = null;
		return result;
	}

	public override int intValue()
	{
		return (int)value;
	}

	public override long longValue()
	{
		return value;
	}

	public override float floatValue()
	{
		if (value >= 0)
		{
			return value;
		}
		return (float)((long)((ulong)value >> 1) | (value & 1)) * 2f;
	}

	public override double doubleValue()
	{
		if (value >= 0)
		{
			return value;
		}
		return (double)((long)((ulong)value >> 1) | (value & 1)) * 2.0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 112, 118, 106, 137 })]
	public virtual BigInteger bigIntegerValue()
	{
		BigInteger bigInteger = BigInteger.valueOf(value & 0x7FFFFFFFFFFFFFFFL);
		if (value < 0)
		{
			bigInteger = bigInteger.setBit(63);
		}
		return bigInteger;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(241)]
	public override int hashCode()
	{
		int result = Longs.hashCode(value);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 160, 132, 104, 103, 143 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (obj is UnsignedLong)
		{
			UnsignedLong unsignedLong = (UnsignedLong)obj;
			return value == unsignedLong.value;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(256)]
	public override string toString()
	{
		string result = UnsignedLongs.toString(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(265)]
	public virtual string toString(int radix)
	{
		string result = UnsignedLongs.toString(value, radix);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(40)]
	public virtual int compareTo(object obj)
	{
		int result = compareTo((UnsignedLong)obj);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 188, 108, 108 })]
	static UnsignedLong()
	{
		___003C_003EZERO = new UnsignedLong(0L);
		___003C_003EONE = new UnsignedLong(1L);
		___003C_003EMAX_VALUE = new UnsignedLong(-1L);
	}

	[HideFromJava]
	public static implicit operator Serializable(UnsignedLong P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	int IComparable.Comparable_003A_003AcompareTo(object P_0)
	{
		return compareTo(P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected UnsignedLong(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
