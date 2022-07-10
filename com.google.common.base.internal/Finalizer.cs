using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.lang.@ref;
using java.lang.reflect;
using java.util.logging;
using javax.annotation;

namespace com.google.common.@base.@internal;

public class Finalizer : java.lang.Object, Runnable
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	private const string FINALIZABLE_REFERENCE = "com.google.common.base.FinalizableReference";

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/lang/ref/WeakReference<Ljava/lang/Class<*>;>;")]
	private java.lang.@ref.WeakReference finalizableReferenceClassReference;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/lang/ref/PhantomReference<Ljava/lang/Object;>;")]
	private PhantomReference frqReference;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/lang/ref/ReferenceQueue<Ljava/lang/Object;>;")]
	private ReferenceQueue queue;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/lang/reflect/Constructor<Ljava/lang/Thread;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Constructor bigThreadConstructor;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Field inheritableThreadLocals;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/ref/ReferenceQueue<Ljava/lang/Object;>;Ljava/lang/ref/PhantomReference<Ljava/lang/Object;>;)V")]
	[LineNumberTable(new byte[] { 81, 104, 135, 172, 103 })]
	private Finalizer(Class P_0, ReferenceQueue P_1, PhantomReference P_2)
	{
		queue = P_1;
		finalizableReferenceClassReference = new java.lang.@ref.WeakReference(P_0);
		frqReference = P_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/ref/Reference<*>;)Z")]
	[LineNumberTable(new byte[]
	{
		112, 103, 99, 226, 71, 134, 201, 194, 191, 6,
		2, 97, 245, 71, 115
	})]
	private bool cleanUp(Reference P_0)
	{
		Method finalizeReferentMethod = getFinalizeReferentMethod();
		if (finalizeReferentMethod == null)
		{
			return false;
		}
		do
		{
			P_0.clear();
			if (P_0 == frqReference)
			{
				return false;
			}
			System.Exception ex;
			try
			{
				finalizeReferentMethod.invoke(P_0, new object[0], Finalizer.___003CGetCallerID_003E());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_003f;
			}
			continue;
			IL_003f:
			System.Exception thrown = ex;
			logger.log(Level.SEVERE, "Error cleaning up after reference.", thrown);
		}
		while ((P_0 = queue.poll()) != null);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 83, 113, 227, 71, 162, 127, 13, 97 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Method getFinalizeReferentMethod()
	{
		//Discarded unreachable code: IL_002e
		Class @class = (Class)finalizableReferenceClassReference.get();
		if (@class == null)
		{
			return null;
		}
		NoSuchMethodException ex;
		try
		{
			return @class.getMethod("finalizeReferent", new Class[0], Finalizer.___003CGetCallerID_003E());
		}
		catch (NoSuchMethodException x)
		{
			ex = ByteCodeHelper.MapException<NoSuchMethodException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NoSuchMethodException detailMessage = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError(detailMessage);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/lang/reflect/Constructor<Ljava/lang/Thread;>;")]
	[LineNumberTable(new byte[] { 160, 118, 159, 51, 129 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Constructor getBigThreadConstructor()
	{
		//Discarded unreachable code: IL_003f
		try
		{
			return ClassLiteral<Thread>.Value.getConstructor(new Class[5]
			{
				ClassLiteral<ThreadGroup>.Value,
				ClassLiteral<Runnable>.Value,
				ClassLiteral<java.lang.String>.Value,
				Long.TYPE,
				java.lang.Boolean.TYPE
			}, Finalizer.___003CGetCallerID_003E());
		}
		catch (System.Exception x)
		{
			ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
		}
		_ = null;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 103, 117, 103, 118, 97, 212 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static Field getInheritableThreadLocalsField()
	{
		//Discarded unreachable code: IL_001f
		try
		{
			Field declaredField = ClassLiteral<Thread>.Value.getDeclaredField("inheritableThreadLocals", Finalizer.___003CGetCallerID_003E());
			declaredField.setAccessible(flag: true);
			return declaredField;
		}
		catch (System.Exception x)
		{
			ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.Unused);
		}
		_ = null;
		logger.log(Level.INFO, "Couldn't access Thread.inheritableThreadLocals. Reference finalizer threads will inherit thread local values.");
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;Ljava/lang/ref/ReferenceQueue<Ljava/lang/Object;>;Ljava/lang/ref/PhantomReference<Ljava/lang/Object;>;)V")]
	[LineNumberTable(new byte[]
	{
		25,
		114,
		176,
		105,
		107,
		98,
		138,
		98,
		100,
		159,
		1,
		47,
		byte.MaxValue,
		5,
		69,
		226,
		61,
		98,
		214,
		99,
		147,
		167,
		103,
		byte.MaxValue,
		6,
		71,
		226,
		59,
		98,
		246,
		70,
		102
	})]
	public static void startFinalizer(Class finalizableReferenceClass, ReferenceQueue queue, PhantomReference frqReference)
	{
		if (!java.lang.String.instancehelper_equals(finalizableReferenceClass.getName(), "com.google.common.base.FinalizableReference"))
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException("Expected com.google.common.base.FinalizableReference.");
		}
		Finalizer finalizer = new Finalizer(finalizableReferenceClass, queue, frqReference);
		string name = ClassLiteral<Finalizer>.Value.getName();
		Thread thread = null;
		System.Exception ex;
		if (bigThreadConstructor != null)
		{
			try
			{
				int b = 0;
				long l = 0L;
				thread = (Thread)bigThreadConstructor.newInstance(new object[5]
				{
					(ThreadGroup)null,
					finalizer,
					name,
					Long.valueOf(l),
					java.lang.Boolean.valueOf((byte)b != 0)
				}, Finalizer.___003CGetCallerID_003E());
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0097;
			}
		}
		goto IL_00b5;
		IL_00b5:
		if (thread == null)
		{
			Thread.___003Cclinit_003E();
			thread = new Thread(null, finalizer, name);
		}
		thread.setDaemon(on: true);
		System.Exception ex2;
		try
		{
			if (inheritableThreadLocals != null)
			{
				inheritableThreadLocals.set(thread, null, Finalizer.___003CGetCallerID_003E());
			}
		}
		catch (System.Exception x2)
		{
			ex2 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
			goto IL_00fa;
		}
		goto IL_0118;
		IL_0118:
		thread.start();
		return;
		IL_00fa:
		System.Exception thrown = ex2;
		logger.log(Level.INFO, "Failed to clear thread local values inherited by reference finalizer thread.", thrown);
		goto IL_0118;
		IL_0097:
		thrown = ex;
		logger.log(Level.INFO, "Failed to create a thread without inherited thread-local values", thrown);
		goto IL_00b5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 96, 127, 3, 194, 2, 129, 130 })]
	public virtual void run()
	{
		while (true)
		{
			try
			{
				if (!cleanUp(queue.remove()))
				{
					break;
				}
			}
			catch (InterruptedException)
			{
				goto IL_001f;
			}
			continue;
			IL_001f:
			_ = null;
		}
	}

	[LineNumberTable(new byte[] { 159, 191, 249, 160, 72, 202, 52 })]
	static Finalizer()
	{
		logger = Logger.getLogger(ClassLiteral<Finalizer>.Value.getName(), Finalizer.___003CGetCallerID_003E());
		bigThreadConstructor = getBigThreadConstructor();
		inheritableThreadLocals = ((bigThreadConstructor != null) ? null : getInheritableThreadLocalsField());
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
