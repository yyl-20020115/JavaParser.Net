using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.math;
using javax.annotation;

namespace com.google.common.primitives;

[Serializable]
[Signature("Ljava/lang/Number;Ljava/lang/Comparable<Lcom/google/common/primitives/UnsignedInteger;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Comparable" })]
public sealed class UnsignedInteger : Number, Comparable
{
	internal static UnsignedInteger ___003C_003EZERO;

	internal static UnsignedInteger ___003C_003EONE;

	internal static UnsignedInteger ___003C_003EMAX_VALUE;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int value;

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static UnsignedInteger ZERO
	{
		[HideFromJava]
		get
		{
			return ___003C_003EZERO;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static UnsignedInteger ONE
	{
		[HideFromJava]
		get
		{
			return ___003C_003EONE;
		}
	}

	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final)]
	public static UnsignedInteger MAX_VALUE
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
	[LineNumberTable(new byte[] { 0, 136, 105 })]
	private UnsignedInteger(int P_0)
	{
		value = P_0 & -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(68)]
	public static UnsignedInteger fromIntBits(int bits)
	{
		UnsignedInteger result = new UnsignedInteger(bits);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(117)]
	public static UnsignedInteger valueOf(string @string, int radix)
	{
		UnsignedInteger result = fromIntBits(UnsignedInts.parseUnsignedInt(@string, radix));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(187)]
	public override long longValue()
	{
		long result = UnsignedInts.toLong(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(250)]
	public virtual string toString(int radix)
	{
		string result = UnsignedInts.toString(value, radix);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 106, 103 })]
	public virtual int compareTo(UnsignedInteger other)
	{
		Preconditions.checkNotNull(other);
		int result = UnsignedInts.compare(value, other.value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 26, 214 })]
	public static UnsignedInteger valueOf(long value)
	{
		Preconditions.checkArgument((value & 0xFFFFFFFFu) == value, "value (%s) is outside the range for an unsigned integer value", value);
		UnsignedInteger result = fromIntBits((int)value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 40, 103, 97, 60, 197 })]
	public static UnsignedInteger valueOf(BigInteger value)
	{
		Preconditions.checkNotNull(value);
		Preconditions.checkArgument((value.signum() >= 0 && value.bitLength() <= 32) ? true : false, "value (%s) is outside the range for an unsigned integer value", value);
		UnsignedInteger result = fromIntBits(value.intValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(106)]
	public static UnsignedInteger valueOf(string @string)
	{
		UnsignedInteger result = valueOf(@string, 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(127)]
	public virtual UnsignedInteger plus(UnsignedInteger val)
	{
		UnsignedInteger result = fromIntBits(value + ((UnsignedInteger)Preconditions.checkNotNull(val)).value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(137)]
	public virtual UnsignedInteger minus(UnsignedInteger val)
	{
		UnsignedInteger result = fromIntBits(value - ((UnsignedInteger)Preconditions.checkNotNull(val)).value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(149)]
	public virtual UnsignedInteger times(UnsignedInteger val)
	{
		UnsignedInteger result = fromIntBits(value * ((UnsignedInteger)Preconditions.checkNotNull(val)).value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(159)]
	public virtual UnsignedInteger dividedBy(UnsignedInteger val)
	{
		UnsignedInteger result = fromIntBits(UnsignedInts.divide(value, ((UnsignedInteger)Preconditions.checkNotNull(val)).value));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(169)]
	public virtual UnsignedInteger mod(UnsignedInteger val)
	{
		UnsignedInteger result = fromIntBits(UnsignedInts.remainder(value, ((UnsignedInteger)Preconditions.checkNotNull(val)).value));
		_ = null;
		return result;
	}

	public override int intValue()
	{
		return value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(196)]
	public override float floatValue()
	{
		return longValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(205)]
	public override double doubleValue()
	{
		return longValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(210)]
	public virtual BigInteger bigIntegerValue()
	{
		BigInteger result = BigInteger.valueOf(longValue());
		_ = null;
		return result;
	}

	public override int hashCode()
	{
		return value;
	}

	[LineNumberTable(new byte[] { 160, 117, 104, 103, 143 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (obj is UnsignedInteger)
		{
			UnsignedInteger unsignedInteger = (UnsignedInteger)obj;
			return value == unsignedInteger.value;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(241)]
	public override string toString()
	{
		string result = toString(10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(41)]
	public virtual int compareTo(object obj)
	{
		int result = compareTo((UnsignedInteger)obj);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 186, 107, 107 })]
	static UnsignedInteger()
	{
		___003C_003EZERO = fromIntBits(0);
		___003C_003EONE = fromIntBits(1);
		___003C_003EMAX_VALUE = fromIntBits(-1);
	}

	int IComparable.Comparable_003A_003AcompareTo(object P_0)
	{
		return compareTo(P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected UnsignedInteger(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
