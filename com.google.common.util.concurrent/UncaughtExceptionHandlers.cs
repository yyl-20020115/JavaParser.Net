using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.logging;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class UncaughtExceptionHandlers : java.lang.Object
{
	internal sealed class Exiter : java.lang.Object, Thread.UncaughtExceptionHandler
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
		private static Logger logger;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Runtime runtime;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 12, 104, 103 })]
		internal Exiter(Runtime P_0)
		{
			runtime = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			19, 126, 38, 242, 72, 108, 38, 108, 228, 57,
			161, 112, 148, 108, 35, 98, 98
		})]
		public virtual void uncaughtException(Thread P_0, System.Exception P_1)
		{
			System.Exception ex;
			try
			{
				try
				{
					logger.log(Level.SEVERE, java.lang.String.format(Locale.ROOT, "Caught an exception in %s.  Shutting down.", P_0), P_1);
				}
				catch (System.Exception x)
				{
					ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_0045;
				}
			}
			catch
			{
				//try-fault
				runtime.exit(1);
				throw;
			}
			runtime.exit(1);
			return;
			IL_0045:
			System.Exception ex2 = ex;
			try
			{
				System.Exception @this = ex2;
				java.lang.System.err.println(Throwable.instancehelper_getMessage(P_1));
				java.lang.System.err.println(Throwable.instancehelper_getMessage(@this));
			}
			finally
			{
				runtime.exit(1);
			}
		}

		[LineNumberTable(58)]
		static Exiter()
		{
			logger = Logger.getLogger(ClassLiteral<Exiter>.Value.getName(), Exiter.___003CGetCallerID_003E());
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(34)]
	private UncaughtExceptionHandlers()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public static Thread.UncaughtExceptionHandler systemExit()
	{
		Exiter.___003Cclinit_003E();
		Exiter result = new Exiter(Runtime.getRuntime());
		_ = null;
		return result;
	}
}
