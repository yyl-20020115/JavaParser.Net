using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Threading;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.reflect;
using java.security;
using java.util;
using javax.annotation;
using sun.misc;

namespace com.google.common.cache;

[Serializable]
[ConstantPool(new object[]
{
	(byte)56,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
internal abstract class Striped64 : Number
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
		[LineNumberTable(297)]
		internal _1()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.lang.Exception" })]
		[LineNumberTable(new byte[] { 160, 186, 102, 122, 104, 111, 248, 61, 230, 69 })]
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
		[Throws(new string[] { "java.lang.Exception" })]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(297)]
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

	internal sealed class Cell : java.lang.Object
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		internal volatile long p0;

		internal volatile long p1;

		internal volatile long p2;

		internal volatile long p3;

		internal volatile long p4;

		internal volatile long p5;

		internal volatile long p6;

		internal volatile long value;

		internal volatile long q0;

		internal volatile long q1;

		internal volatile long q2;

		internal volatile long q3;

		internal volatile long q4;

		internal volatile long q5;

		internal volatile long q6;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static Unsafe UNSAFE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static long valueOffset;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 52, 104, 110 })]
		internal Cell(long P_0)
		{
			ByteCodeHelper.VolatileWrite(ref value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(107)]
		internal bool cas(long P_0, long P_1)
		{
			bool result = UNSAFE.compareAndSwapLong(this, valueOffset, P_0, P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 66, 106, 102, 191, 23, 2, 97, 140 })]
		static Cell()
		{
			java.lang.Exception ex2;
			try
			{
				UNSAFE = access_0024000();
				Class @class = ClassLiteral<Cell>.Value;
				valueOffset = UNSAFE.objectFieldOffset(@class.getDeclaredField("value", Cell.___003CGetCallerID_003E()));
				return;
			}
			catch (System.Exception x)
			{
				java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
			}
			java.lang.Exception cause = ex2;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new Error(cause);
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

	private sealed class ___003Ctls_003E_1 : IntrinsicThreadLocal
	{
		[ThreadStatic]
		private static object field;

		public sealed override object get()
		{
			return field;
		}

		public sealed override void set(object P_0)
		{
			field = P_0;
		}

		internal ___003Ctls_003E_1()
		{
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/lang/ThreadLocal<[I>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 3, 0, 0, 56, 0, 0 })]
	internal static ThreadLocal threadHashCode;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static java.util.Random rng;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static int NCPU;

	[NonSerialized]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal volatile Cell[] cells;

	[NonSerialized]
	internal volatile long @base;

	[NonSerialized]
	internal volatile int busy;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Unsafe UNSAFE;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static long baseOffset;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static long busyOffset;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		178,
		121,
		161,
		byte.MaxValue,
		11,
		77,
		97
	})]
	private static Unsafe getUnsafe()
	{
		//Discarded unreachable code: IL_000c, IL_0030
		try
		{
			return Unsafe.getUnsafe(Striped64.___003CGetCallerID_003E());
		}
		catch (SecurityException)
		{
		}
		_ = null;
		PrivilegedActionException ex2;
		try
		{
			return (Unsafe)AccessController.doPrivileged(new _1(), Striped64.___003CGetCallerID_003E());
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
	[LineNumberTable(160)]
	internal bool casBusy()
	{
		bool result = UNSAFE.compareAndSwapInt(this, busyOffset, 0, 1);
		_ = null;
		return result;
	}

	internal abstract long fn(long P_0, long P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(155)]
	internal bool casBase(long P_0, long P_1)
	{
		bool result = UNSAFE.compareAndSwapLong(this, baseOffset, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(151)]
	internal Striped64()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 96, 66, 99, 115, 107, 117, 103, 226, 70,
		124, 114, 109, 104, 120, 195, 127, 6, 103, 167,
		110, 35, 110, 98, 204, 103, 99, 103, 127, 7,
		124, 106, 152, 108, 107, 123, 179, 110, 35, 110,
		98, 98, 133, 106, 106, 105, 106, 127, 8, 131,
		108, 104, 109, 111, 167, 110, 35, 98, 98, 102,
		127, 4, 101
	})]
	internal void retryUpdate(long P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] int[] P_1, bool P_2)
	{
		int num = (P_2 ? 1 : 0);
		int num2;
		int num5;
		if (P_1 == null)
		{
			threadHashCode.set(P_1 = new int[1]);
			num2 = rng.nextInt();
			int[] array = P_1;
			int num3 = ((num2 == 0) ? 1 : num2);
			int num4 = 0;
			int[] array2 = array;
			array2[num4] = num3;
			num5 = num3;
		}
		else
		{
			num5 = P_1[0];
		}
		num2 = 0;
		while (true)
		{
			Cell[] array3;
			long num10;
			if ((array3 = cells) != null)
			{
				IntPtr intPtr = (nint)array3.LongLength;
				int num6 = (int)(nint)intPtr;
				if ((nint)intPtr > 0)
				{
					Cell cell;
					if ((cell = array3[(num6 - 1) & num5]) == null)
					{
						if (busy == 0)
						{
							Cell cell2 = new Cell(P_0);
							if (busy == 0 && casBusy())
							{
								int num7 = 0;
								try
								{
									Cell[] array4;
									if ((array4 = cells) != null)
									{
										IntPtr intPtr2 = (nint)array4.LongLength;
										int num8 = (int)(nint)intPtr2;
										int num9;
										if ((nint)intPtr2 > 0 && array4[num9 = (num8 - 1) & num5] == null)
										{
											array4[num9] = cell2;
											num7 = 1;
										}
									}
								}
								catch
								{
									//try-fault
									busy = 0;
									System.Threading.Thread.MemoryBarrier();
									throw;
								}
								busy = 0;
								System.Threading.Thread.MemoryBarrier();
								if (num7 != 0)
								{
									break;
								}
								continue;
							}
						}
						num2 = 0;
					}
					else if (num == 0)
					{
						num = 1;
					}
					else
					{
						if (cell.cas(num10 = ByteCodeHelper.VolatileRead(ref cell.value), fn(num10, P_0)))
						{
							break;
						}
						if (num6 >= NCPU || cells != array3)
						{
							num2 = 0;
						}
						else if (num2 == 0)
						{
							num2 = 1;
						}
						else if (busy == 0 && casBusy())
						{
							try
							{
								if (cells == array3)
								{
									Cell[] array5 = new Cell[num6 << 1];
									for (int num7 = 0; num7 < num6; num7++)
									{
										array5[num7] = array3[num7];
									}
									cells = array5;
									System.Threading.Thread.MemoryBarrier();
								}
							}
							catch
							{
								//try-fault
								busy = 0;
								System.Threading.Thread.MemoryBarrier();
								throw;
							}
							busy = 0;
							System.Threading.Thread.MemoryBarrier();
							num2 = 0;
							continue;
						}
					}
					num5 ^= num5 << 13;
					num5 ^= (int)((uint)num5 >> 17);
					num5 = (P_1[0] = num5 ^ (num5 << 5));
					continue;
				}
			}
			if (busy == 0 && cells == array3 && casBusy())
			{
				int num11 = 0;
				try
				{
					if (cells == array3)
					{
						Cell[] array6 = new Cell[2];
						array6[num5 & 1] = new Cell(P_0);
						cells = array6;
						System.Threading.Thread.MemoryBarrier();
						num11 = 1;
					}
				}
				finally
				{
					busy = 0;
					System.Threading.Thread.MemoryBarrier();
				}
				if (num11 != 0)
				{
					break;
				}
			}
			else if (casBase(num10 = ByteCodeHelper.VolatileRead(ref @base), fn(num10, P_0)))
			{
				break;
			}
		}
	}

	[LineNumberTable(new byte[]
	{
		160, 143, 105, 110, 99, 99, 102, 101, 21, 230,
		69
	})]
	internal void internalReset(long P_0)
	{
		Cell[] array = cells;
		ByteCodeHelper.VolatileWrite(ref @base, P_0);
		if (array == null)
		{
			return;
		}
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			Cell cell = array[i];
			if (cell != null)
			{
				ByteCodeHelper.VolatileWrite(ref cell.value, P_0);
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	internal static Unsafe access_0024000()
	{
		Unsafe @unsafe = getUnsafe();
		_ = null;
		return @unsafe;
	}

	[LineNumberTable(new byte[]
	{
		80, 170, 170, 239, 160, 139, 106, 102, 127, 0,
		191, 23, 2, 97, 140
	})]
	static Striped64()
	{
		threadHashCode = new ___003Ctls_003E_1();
		rng = new java.util.Random();
		NCPU = Runtime.getRuntime().availableProcessors();
		java.lang.Exception ex2;
		try
		{
			UNSAFE = getUnsafe();
			Class value = ClassLiteral<Striped64>.Value;
			baseOffset = UNSAFE.objectFieldOffset(value.getDeclaredField("base", Striped64.___003CGetCallerID_003E()));
			busyOffset = UNSAFE.objectFieldOffset(value.getDeclaredField("busy", Striped64.___003CGetCallerID_003E()));
			return;
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception cause = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new Error(cause);
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected Striped64(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
