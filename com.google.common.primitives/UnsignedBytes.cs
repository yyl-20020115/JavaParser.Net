using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.nio;
using java.security;
using java.util;
using java.util.function;
using sun.misc;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
public sealed class UnsignedBytes : java.lang.Object
{
	internal class LexicographicalComparatorHolder : java.lang.Object
	{
		[Serializable]
		[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/UnsignedBytes$LexicographicalComparatorHolder$PureJavaComparator;>;Ljava/util/Comparator<[B>;")]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[Implements(new string[] { "java.util.Comparator" })]
		internal sealed class PureJavaComparator : java.lang.Enum, Comparator
		{
			[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
			public static PureJavaComparator INSTANCE;

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
			private static PureJavaComparator[] _0024VALUES;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 48, 106, 102, 108, 99, 226, 61, 230, 70 })]
			public virtual int compare(byte[] P_0, byte[] P_1)
			{
				int num = java.lang.Math.min(P_0.Length, P_1.Length);
				for (int i = 0; i < num; i++)
				{
					int num2 = UnsignedBytes.compare(P_0[i], P_1[i]);
					if (num2 != 0)
					{
						return num2;
					}
				}
				return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()V")]
			[LineNumberTable(413)]
			private PureJavaComparator(string P_0, int P_1)
				: base(P_0, P_1)
			{
				System.GC.KeepAlive(this);
			}

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(413)]
			private static PureJavaComparator[] _0024values()
			{
				return new PureJavaComparator[1] { INSTANCE };
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(413)]
			public static PureJavaComparator[] values()
			{
				return (PureJavaComparator[])_0024VALUES.Clone();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(413)]
			public static PureJavaComparator valueOf(string P_0)
			{
				return (PureJavaComparator)java.lang.Enum.valueOf(ClassLiteral<PureJavaComparator>.Value, P_0);
			}

			public override string toString()
			{
				return "UnsignedBytes.lexicographicalComparator() (pure Java version)";
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(413)]
			public virtual int compare(object P_0, object P_1)
			{
				int result = compare((byte[])P_0, (byte[])P_1);
				_ = null;
				return result;
			}

			[LineNumberTable(new byte[] { 161, 44, 48 })]
			static PureJavaComparator()
			{
				INSTANCE = new PureJavaComparator("INSTANCE", 0);
				_0024VALUES = _0024values();
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparing(Comparator P_0)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator reversed()
			{
				return Comparator._003Cdefault_003Ereversed(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparing(java.util.function.Function P_0, Comparator P_1)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparing(java.util.function.Function P_0)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparingInt(ToIntFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparingLong(ToLongFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
			}

			bool Comparator.Comparator_003A_003Aequals(object P_0)
			{
				return equals(P_0);
			}
		}

		[Serializable]
		[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/UnsignedBytes$LexicographicalComparatorHolder$UnsafeComparator;>;Ljava/util/Comparator<[B>;")]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		[Implements(new string[] { "java.util.Comparator" })]
		internal sealed class UnsafeComparator : java.lang.Enum, Comparator
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Lsun/misc/Unsafe;>;")]
			[EnclosingMethod(null, "getUnsafe", "()Lsun.misc.Unsafe;")]
			internal class _1 : java.lang.Object, PrivilegedExceptionAction
			{
				private sealed class ___003CCallerID_003E : CallerID
				{
					internal ___003CCallerID_003E()
					{
					}
				}

				[SpecialName]
				private static CallerID ___003CcallerID_003E;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Throws(new string[] { "java.lang.Exception" })]
				[LineNumberTable(new byte[]
				{
					160, 236, 102, 122, 104, 111, 106, 238, 60, 230,
					71
				})]
				public virtual Unsafe run()
				{
					Class value = ClassLiteral<Unsafe>.Value;
					Field[] declaredFields = value.getDeclaredFields(_1.___003CGetCallerID_003E());
					int num = declaredFields.Length;
					for (int i = 0; i < num; i++)
					{
						Field field = declaredFields[i];
						field.setAccessible(flag: true);
						object obj = field.get(null, _1.___003CGetCallerID_003E());
						if (value.isInstance(obj))
						{
							return (Unsafe)value.cast(obj);
						}
					}
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new NoSuchFieldError("the Unsafe");
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(347)]
				internal _1()
				{
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Throws(new string[] { "java.lang.Exception" })]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(347)]
				public virtual object run()
				{
					Unsafe result = this.run();
					_ = null;
					return result;
				}

				static CallerID ___003CGetCallerID_003E()
				{
					if (___003CcallerID_003E == null)
					{
						___003CcallerID_003E = new ___003CCallerID_003E();
					}
					return ___003CcallerID_003E;
				}
			}

			private sealed class ___003CCallerID_003E : CallerID
			{
				internal ___003CCallerID_003E()
				{
				}
			}

			[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
			public static UnsafeComparator INSTANCE;

			[Modifiers(Modifiers.Static | Modifiers.Final)]
			internal static bool BIG_ENDIAN;

			[Modifiers(Modifiers.Static | Modifiers.Final)]
			internal static Unsafe theUnsafe;

			[Modifiers(Modifiers.Static | Modifiers.Final)]
			internal static int BYTE_ARRAY_BASE_OFFSET;

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
			private static UnsafeComparator[] _0024VALUES;

			[SpecialName]
			private static CallerID ___003CcallerID_003E;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				160,
				254,
				98,
				106,
				232,
				71,
				105,
				118,
				118,
				102,
				103,
				236,
				74,
				111,
				byte.MaxValue,
				3,
				48,
				233,
				85,
				100,
				109,
				100,
				227,
				61,
				230,
				70
			})]
			public virtual int compare(byte[] P_0, byte[] P_1)
			{
				int num = 8;
				int num2 = java.lang.Math.min(P_0.Length, P_1.Length);
				int num3 = num2 & ((num - 1) ^ -1);
				int i;
				for (i = 0; i < num3; i += num)
				{
					long @long = theUnsafe.getLong(P_0, (long)BYTE_ARRAY_BASE_OFFSET + (long)i);
					long long2 = theUnsafe.getLong(P_1, (long)BYTE_ARRAY_BASE_OFFSET + (long)i);
					if (@long != long2)
					{
						if (BIG_ENDIAN)
						{
							int result = UnsignedLongs.compare(@long, long2);
							_ = null;
							return result;
						}
						int num4 = Long.numberOfTrailingZeros(@long ^ long2) & -8;
						return (int)(((ulong)@long >> num4) & 0xFFu) - (int)(((ulong)long2 >> num4) & 0xFFu);
					}
				}
				for (; i < num2; i++)
				{
					int num5 = UnsignedBytes.compare(P_0[i], P_1[i]);
					if (num5 != 0)
					{
						return num5;
					}
				}
				return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()V")]
			[LineNumberTable(296)]
			private UnsafeComparator(string P_0, int P_1)
				: base(P_0, P_1)
			{
				System.GC.KeepAlive(this);
			}

			[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(295)]
			private static UnsafeComparator[] _0024values()
			{
				return new UnsafeComparator[1] { INSTANCE };
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				160,
				227,
				121,
				193,
				byte.MaxValue,
				11,
				79,
				97
			})]
			private static Unsafe getUnsafe()
			{
				//Discarded unreachable code: IL_000c, IL_0030
				try
				{
					return Unsafe.getUnsafe(UnsafeComparator.___003CGetCallerID_003E());
				}
				catch (SecurityException)
				{
				}
				_ = null;
				PrivilegedActionException ex2;
				try
				{
					return (Unsafe)AccessController.doPrivileged(new _1(), UnsafeComparator.___003CGetCallerID_003E());
				}
				catch (PrivilegedActionException x)
				{
					ex2 = ByteCodeHelper.MapException<PrivilegedActionException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				}
				PrivilegedActionException ex3 = ex2;
				System.Exception cause = ex3.getCause();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new RuntimeException("Could not initialize intrinsics", cause);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(295)]
			public static UnsafeComparator[] values()
			{
				return (UnsafeComparator[])_0024VALUES.Clone();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(295)]
			public static UnsafeComparator valueOf(string P_0)
			{
				return (UnsafeComparator)java.lang.Enum.valueOf(ClassLiteral<UnsafeComparator>.Value, P_0);
			}

			public override string toString()
			{
				return "UnsignedBytes.lexicographicalComparator() (sun.misc.Unsafe version)";
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(295)]
			public virtual int compare(object P_0, object P_1)
			{
				int result = compare((byte[])P_0, (byte[])P_1);
				_ = null;
				return result;
			}

			[LineNumberTable(new byte[]
			{
				160, 183, 16, 202, 244, 82, 170, 244, 69, 191,
				19, 104, 139
			})]
			static UnsafeComparator()
			{
				INSTANCE = new UnsafeComparator("INSTANCE", 0);
				_0024VALUES = _0024values();
				BIG_ENDIAN = java.lang.Object.instancehelper_equals(ByteOrder.nativeOrder(), ByteOrder.BIG_ENDIAN);
				theUnsafe = getUnsafe();
				BYTE_ARRAY_BASE_OFFSET = theUnsafe.arrayBaseOffset(ClassLiteral<byte[]>.Value);
				if (java.lang.String.instancehelper_equals("64", java.lang.System.getProperty("sun.arch.data.model")))
				{
					int bYTE_ARRAY_BASE_OFFSET = BYTE_ARRAY_BASE_OFFSET;
					if ((8 == -1 || bYTE_ARRAY_BASE_OFFSET % 8 == 0) && theUnsafe.arrayIndexScale(ClassLiteral<byte[]>.Value) == 1)
					{
						return;
					}
				}
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new Error();
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparing(Comparator P_0)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator reversed()
			{
				return Comparator._003Cdefault_003Ereversed(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparing(java.util.function.Function P_0, Comparator P_1)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparing(java.util.function.Function P_0)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparingInt(ToIntFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparingLong(ToLongFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
			}

			static CallerID ___003CGetCallerID_003E()
			{
				if (___003CcallerID_003E == null)
				{
					___003CcallerID_003E = new ___003CCallerID_003E();
				}
				return ___003CcallerID_003E;
			}

			bool Comparator.Comparator_003A_003Aequals(object P_0)
			{
				return equals(P_0);
			}
		}

		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static string UNSAFE_COMPARATOR_NAME;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Ljava/util/Comparator<[B>;")]
		internal static Comparator BEST_COMPARATOR;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<[B>;")]
		[LineNumberTable(new byte[] { 161, 70, 176, 209, 105, 118, 97 })]
		internal static Comparator getBestComparator()
		{
			//Discarded unreachable code: IL_002d
			try
			{
				Class @class = Class.forName(UNSAFE_COMPARATOR_NAME, LexicographicalComparatorHolder.___003CGetCallerID_003E());
				object[] array = (object[])java.util.Objects.requireNonNull(@class.getEnumConstants());
				return (Comparator)array[0];
			}
			catch (System.Exception x)
			{
				ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
			}
			_ = null;
			return lexicographicalComparatorJavaImpl();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(289)]
		internal LexicographicalComparatorHolder()
		{
		}

		[LineNumberTable(new byte[] { 160, 176, 101, 153 })]
		static LexicographicalComparatorHolder()
		{
			UNSAFE_COMPARATOR_NAME = java.lang.String.instancehelper_concat(java.lang.String.valueOf(ClassLiteral<LexicographicalComparatorHolder>.Value.getName()), "$UnsafeComparator");
			BEST_COMPARATOR = getBestComparator();
		}

		static CallerID ___003CGetCallerID_003E()
		{
			if (___003CcallerID_003E == null)
			{
				___003CcallerID_003E = new ___003CCallerID_003E();
			}
			return ___003CcallerID_003E;
		}
	}

	public const byte MAX_POWER_OF_TWO = 128;

	public const byte MAX_VALUE = byte.MaxValue;

	private const int UNSIGNED_MASK = 255;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 39, 114 })]
	public static byte checkedCast(long value)
	{
		Preconditions.checkArgument(value >> 8 == 0, "out of range: %s", value);
		return (byte)(sbyte)value;
	}

	public static int toInt(byte value)
	{
		int num = (sbyte)value;
		return num & 0xFF;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(122)]
	public static int compare(byte a, byte b)
	{
		int value = (sbyte)a;
		int value2 = (sbyte)b;
		return toInt((byte)value) - toInt((byte)value2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<[B>;")]
	[LineNumberTable(278)]
	internal static Comparator lexicographicalComparatorJavaImpl()
	{
		return LexicographicalComparatorHolder.PureJavaComparator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 96, 163, 248, 69 })]
	public static string toString(byte x, int radix)
	{
		int value = (sbyte)x;
		Preconditions.checkArgument((radix >= 2 && radix <= 36) ? true : false, "radix (%s) must be between Character.MIN_RADIX and Character.MAX_RADIX", radix);
		string result = Integer.toString(toInt((byte)value), radix);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 111, 146, 101, 131 })]
	public static byte parseUnsignedByte(string @string, int radix)
	{
		int num = Integer.parseInt((string)Preconditions.checkNotNull(@string), radix);
		if (num >> 8 == 0)
		{
			return (byte)(sbyte)num;
		}
		int num2 = 25;
		num2 = num2;
		string s = new StringBuilder(num2).append("out of range: ").append(num).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NumberFormatException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(172)]
	public static string toString(byte x)
	{
		int x2 = (sbyte)x;
		string result = toString((byte)x2, 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 106, 103, 105, 102, 44, 166, 104, 102, 44,
		166
	})]
	public static void sort(byte[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		for (int i = fromIndex; i < toIndex; i++)
		{
			array[i] = (byte)(sbyte)flip(array[i]);
		}
		Arrays.sort(array, fromIndex, toIndex);
		for (int i = fromIndex; i < toIndex; i++)
		{
			array[i] = (byte)(sbyte)flip(array[i]);
		}
	}

	private static byte flip(byte P_0)
	{
		int num = (sbyte)P_0;
		return (byte)(sbyte)((uint)num ^ 0x80u);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 135, 103, 105, 102, 46, 166, 104, 102, 46,
		166
	})]
	public static void sortDescending(byte[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		for (int i = fromIndex; i < toIndex; i++)
		{
			int num = i;
			byte[] array2 = array;
			array2[num] = (byte)(sbyte)(array2[num] ^ 0x7Fu);
		}
		Arrays.sort(array, fromIndex, toIndex);
		for (int i = fromIndex; i < toIndex; i++)
		{
			int num = i;
			byte[] array2 = array;
			array2[num] = (byte)(sbyte)(array2[num] ^ 0x7Fu);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(49)]
	private UnsignedBytes()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 52, 106, 130, 101, 130 })]
	public static byte saturatedCast(long value)
	{
		if (value > toInt(byte.MaxValue))
		{
			return byte.MaxValue;
		}
		if (value < 0)
		{
			return 0;
		}
		return (byte)(sbyte)value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 84, 106, 105, 103, 105, 100, 226, 61, 230, 70 })]
	public static byte min(params byte[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		int num = toInt(array[0]);
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			int num2 = toInt(array[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		return (byte)(sbyte)num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 104, 106, 105, 103, 105, 100, 226, 61, 230, 70 })]
	public static byte max(params byte[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		int num = toInt(array[0]);
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			int num2 = toInt(array[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		return (byte)(sbyte)num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(207)]
	public static byte parseUnsignedByte(string @string)
	{
		sbyte result = (sbyte)parseUnsignedByte(@string, 10);
		_ = null;
		return (byte)result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 130, 103, 100, 198, 113, 111, 103, 53, 166 })]
	public static string join(string separator, params byte[] array)
	{
		Preconditions.checkNotNull(separator);
		if (array.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder((int)((nint)array.LongLength * (3 + java.lang.String.instancehelper_length(separator))));
		stringBuilder.append(toInt(array[0]));
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			stringBuilder.append(separator).append(toString(array[i]));
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<[B>;")]
	[LineNumberTable(273)]
	public static Comparator lexicographicalComparator()
	{
		return LexicographicalComparatorHolder.BEST_COMPARATOR;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 95, 103, 107 })]
	public static void sort(byte[] array)
	{
		Preconditions.checkNotNull(array);
		sort(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 124, 103, 107 })]
	public static void sortDescending(byte[] array)
	{
		Preconditions.checkNotNull(array);
		sortDescending(array, 0, array.Length);
	}
}
