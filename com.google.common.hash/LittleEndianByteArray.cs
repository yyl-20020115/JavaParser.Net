using System;
using System.Runtime.CompilerServices;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.nio;
using java.security;
using sun.misc;

namespace com.google.common.hash;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
internal sealed class LittleEndianByteArray : java.lang.Object
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
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/hash/LittleEndianByteArray$JavaLittleEndianBytes;>;Lcom/google/common/hash/LittleEndianByteArray$LittleEndianBytes;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.hash.LittleEndianByteArray$LittleEndianBytes" })]
	internal abstract class JavaLittleEndianBytes : java.lang.Enum, LittleEndianBytes
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : JavaLittleEndianBytes
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(208)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				System.GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(211)]
			public override long getLongLittleEndian(byte[] P_0, int P_1)
			{
				long result = Longs.fromBytes(P_0[P_1 + 7], P_0[P_1 + 6], P_0[P_1 + 5], P_0[P_1 + 4], P_0[P_1 + 3], P_0[P_1 + 2], P_0[P_1 + 1], P_0[P_1]);
				_ = null;
				return result;
			}

			[LineNumberTable(new byte[] { 160, 110, 103, 102, 49, 170 })]
			public override void putLongLittleEndian(byte[] P_0, int P_1, long P_2)
			{
				long num = 255L;
				for (int i = 0; i < 8; i++)
				{
					P_0[P_1 + i] = (byte)(sbyte)((P_2 & num) >> i * 8);
					num <<= 8;
				}
			}

			[HideFromJava]
			static _1()
			{
				JavaLittleEndianBytes.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static JavaLittleEndianBytes INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static JavaLittleEndianBytes[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(207)]
		private JavaLittleEndianBytes(string P_0, int P_1)
			: base(P_0, P_1)
		{
			System.GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(207)]
		private static JavaLittleEndianBytes[] _0024values()
		{
			return new JavaLittleEndianBytes[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(207)]
		public static JavaLittleEndianBytes[] values()
		{
			return (JavaLittleEndianBytes[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(207)]
		public static JavaLittleEndianBytes valueOf(string P_0)
		{
			return (JavaLittleEndianBytes)java.lang.Enum.valueOf(ClassLiteral<JavaLittleEndianBytes>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(207)]
		internal JavaLittleEndianBytes(string P_0, int P_1, LittleEndianByteArray._1 P_2)
			: this(P_0, P_1)
		{
			System.GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 160, 94, 48 })]
		static JavaLittleEndianBytes()
		{
			INSTANCE = new _1("INSTANCE", 0);
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract long getLongLittleEndian(byte[] P_0, int P_1);

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract void putLongLittleEndian(byte[] P_0, int P_1, long P_2);
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Interface | Modifiers.Abstract)]
	internal interface LittleEndianBytes
	{
		virtual long getLongLittleEndian(byte[] P_0, int P_1);

		virtual void putLongLittleEndian(byte[] P_0, int P_1, long P_2);
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/hash/LittleEndianByteArray$UnsafeByteArray;>;Lcom/google/common/hash/LittleEndianByteArray$LittleEndianBytes;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	[Implements(new string[] { "com.google.common.hash.LittleEndianByteArray$LittleEndianBytes" })]
	internal abstract class UnsafeByteArray : java.lang.Enum, LittleEndianBytes
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : UnsafeByteArray
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(129)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				System.GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(132)]
			public override long getLongLittleEndian(byte[] P_0, int P_1)
			{
				long @long = access_0024200().getLong(P_0, (long)P_1 + (long)access_0024100());
				_ = null;
				return @long;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 87, 119 })]
			public override void putLongLittleEndian(byte[] P_0, int P_1, long P_2)
			{
				access_0024200().putLong(P_0, (long)P_1 + (long)access_0024100(), P_2);
			}

			[HideFromJava]
			static _1()
			{
				UnsafeByteArray.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : UnsafeByteArray
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(140)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				System.GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 93, 149 })]
			public override long getLongLittleEndian(byte[] P_0, int P_1)
			{
				long @long = access_0024200().getLong(P_0, (long)P_1 + (long)access_0024100());
				long result = Long.reverseBytes(@long);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 101, 103, 119 })]
			public override void putLongLittleEndian(byte[] P_0, int P_1, long P_2)
			{
				long newValue = Long.reverseBytes(P_2);
				access_0024200().putLong(P_0, (long)P_1 + (long)access_0024100(), newValue);
			}

			[HideFromJava]
			static _2()
			{
				UnsafeByteArray.___003Cclinit_003E();
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/security/PrivilegedExceptionAction<Lsun/misc/Unsafe;>;")]
		[EnclosingMethod(null, "getUnsafe", "()Lsun.misc.Unsafe;")]
		internal class _3 : java.lang.Object, PrivilegedExceptionAction
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
			[LineNumberTable(176)]
			internal _3()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[LineNumberTable(new byte[]
			{
				160, 65, 102, 122, 104, 111, 106, 238, 60, 230,
				71
			})]
			public virtual Unsafe run()
			{
				Class value = ClassLiteral<Unsafe>.Value;
				Field[] declaredFields = value.getDeclaredFields(_3.___003CGetCallerID_003E());
				int num = declaredFields.Length;
				for (int i = 0; i < num; i++)
				{
					Field field = declaredFields[i];
					field.setAccessible(flag: true);
					object obj = field.get(null, _3.___003CGetCallerID_003E());
					if (value.isInstance(obj))
					{
						return (Unsafe)value.cast(obj);
					}
				}
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchFieldError("the Unsafe");
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Throws(new string[] { "java.lang.Exception" })]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(176)]
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
		public static UnsafeByteArray UNSAFE_LITTLE_ENDIAN;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static UnsafeByteArray UNSAFE_BIG_ENDIAN;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static Unsafe theUnsafe;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static int BYTE_ARRAY_BASE_OFFSET;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static UnsafeByteArray[] _0024VALUES;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(127)]
		private UnsafeByteArray(string P_0, int P_1)
			: base(P_0, P_1)
		{
			System.GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(127)]
		private static UnsafeByteArray[] _0024values()
		{
			return new UnsafeByteArray[2] { UNSAFE_LITTLE_ENDIAN, UNSAFE_BIG_ENDIAN };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			120,
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
				return Unsafe.getUnsafe(UnsafeByteArray.___003CGetCallerID_003E());
			}
			catch (SecurityException)
			{
			}
			_ = null;
			PrivilegedActionException ex2;
			try
			{
				return (Unsafe)AccessController.doPrivileged(new _3(), UnsafeByteArray.___003CGetCallerID_003E());
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
		[LineNumberTable(127)]
		public static UnsafeByteArray[] values()
		{
			return (UnsafeByteArray[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(127)]
		public static UnsafeByteArray valueOf(string P_0)
		{
			return (UnsafeByteArray)java.lang.Enum.valueOf(ClassLiteral<UnsafeByteArray>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(127)]
		internal UnsafeByteArray(string P_0, int P_1, LittleEndianByteArray._1 P_2)
			: this(P_0, P_1)
		{
			System.GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static int access_0024100()
		{
			return BYTE_ARRAY_BASE_OFFSET;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		internal static Unsafe access_0024200()
		{
			return theUnsafe;
		}

		[LineNumberTable(new byte[]
		{
			79, 240, 75, 240, 51, 234, 160, 69, 106, 180,
			114, 139
		})]
		static UnsafeByteArray()
		{
			UNSAFE_LITTLE_ENDIAN = new _1("UNSAFE_LITTLE_ENDIAN", 0);
			UNSAFE_BIG_ENDIAN = new _2("UNSAFE_BIG_ENDIAN", 1);
			_0024VALUES = _0024values();
			theUnsafe = getUnsafe();
			BYTE_ARRAY_BASE_OFFSET = theUnsafe.arrayBaseOffset(ClassLiteral<byte[]>.Value);
			if (theUnsafe.arrayIndexScale(ClassLiteral<byte[]>.Value) != 1)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract long getLongLittleEndian(byte[] P_0, int P_1);

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract void putLongLittleEndian(byte[] P_0, int P_1, long P_2);

		static CallerID ___003CGetCallerID_003E()
		{
			if (___003CcallerID_003E == null)
			{
				___003CcallerID_003E = new ___003CCallerID_003E();
			}
			return ___003CcallerID_003E;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static LittleEndianBytes byteArray;

	[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
	internal static bool _0024assertionsDisabled;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 185, 153 })]
	internal static long load64(byte[] P_0, int P_1)
	{
		if (!_0024assertionsDisabled && (nint)P_0.LongLength < P_1 + 8)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
		long longLittleEndian = byteArray.getLongLittleEndian(P_0, P_1);
		_ = null;
		return longLittleEndian;
	}

	[LineNumberTable(95)]
	internal static int load32(byte[] P_0, int P_1)
	{
		return P_0[P_1] | (P_0[P_1 + 1] << 8) | (P_0[P_1 + 2] << 16) | (P_0[P_1 + 3] << 24);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 227, 69, 104, 134, 16, 198 })]
	internal static long load64Safely(byte[] P_0, int P_1, int P_2)
	{
		long num = 0L;
		int num2 = java.lang.Math.min(P_2, 8);
		for (int i = 0; i < num2; i++)
		{
			num |= (long)(int)P_0[P_1 + i] << i * 8;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 31, 157, 111 })]
	internal static void store64(byte[] P_0, int P_1, long P_2)
	{
		if (!_0024assertionsDisabled && (P_1 < 0 || P_1 + 8 > (nint)P_0.LongLength))
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
		byteArray.putLongLittleEndian(P_0, P_1, P_2);
	}

	[LineNumberTable(107)]
	internal static bool usingUnsafe()
	{
		return byteArray is UnsafeByteArray;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(260)]
	private LittleEndianByteArray()
	{
	}

	[LineNumberTable(new byte[]
	{
		159, 169, 245, 160, 206, 230, 77, 107, 141, 113,
		103, 215, 2, 161, 121
	})]
	static LittleEndianByteArray()
	{
		_0024assertionsDisabled = ((!ClassLiteral<LittleEndianByteArray>.Value.desiredAssertionStatus()) ? true : false);
		java.lang.Enum @enum = JavaLittleEndianBytes.INSTANCE;
		try
		{
			string property = java.lang.System.getProperty("os.arch");
			if (java.lang.String.instancehelper_equals("amd64", property))
			{
				@enum = ((!java.lang.Object.instancehelper_equals(ByteOrder.nativeOrder(), ByteOrder.LITTLE_ENDIAN)) ? UnsafeByteArray.UNSAFE_BIG_ENDIAN : UnsafeByteArray.UNSAFE_LITTLE_ENDIAN);
			}
		}
		catch (System.Exception x)
		{
			ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
			goto IL_005f;
		}
		goto IL_0065;
		IL_005f:
		_ = null;
		goto IL_0065;
		IL_0065:
		java.lang.Enum enum2 = @enum;
		byteArray = ((enum2 == null) ? null : ((enum2 as LittleEndianBytes) ?? throw new java.lang.IncompatibleClassChangeError()));
	}
}
