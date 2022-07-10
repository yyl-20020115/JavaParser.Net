using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.@ref;
using java.lang.reflect;
using java.net;
using java.util.logging;
using javax.annotation;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Closeable" })]
public class FinalizableReferenceQueue : java.lang.Object, Closeable, AutoCloseable
{
	internal class DecoupledLoader : java.lang.Object, FinalizerLoader
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		private const string LOADING_ERROR = "Could not load Finalizer in its own class loader. Loading Finalizer in the current class loader instead. As a result, you will not be able to garbage collect this class loader. To support reclaiming this class loader, either resolve the underlying issue, or move Guava to your system class path.";

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException" })]
		[LineNumberTable(new byte[]
		{
			160, 193, 126, 119, 99, 204, 103, 105, 159, 16,
			117
		})]
		internal virtual URL getBaseUrl()
		{
			string text = java.lang.String.instancehelper_concat(java.lang.String.valueOf(java.lang.String.instancehelper_replace("com.google.common.base.internal.Finalizer", '.', '/')), ".class");
			URL resource = java.lang.Object.instancehelper_getClass(this).getClassLoader(DecoupledLoader.___003CGetCallerID_003E()).getResource(text);
			if (resource == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new FileNotFoundException(text);
			}
			string text2 = resource.toString();
			if (!java.lang.String.instancehelper_endsWith(text2, text))
			{
				string text3 = java.lang.String.valueOf(text2);
				string message;
				if (java.lang.String.instancehelper_length(text3) != 0)
				{
					message = java.lang.String.instancehelper_concat("Unsupported path style: ", text3);
				}
				else
				{
					string text4 = "Unsupported path style: ";
					text4 = text4;
					message = java.lang.String.newhelper(text4);
				}
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IOException(message);
			}
			text2 = java.lang.String.instancehelper_substring(text2, 0, java.lang.String.instancehelper_length(text2) - java.lang.String.instancehelper_length(text));
			URL result = new URL(resource, text2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(327)]
		internal virtual URLClassLoader newLoader(URL P_0)
		{
			URLClassLoader.___003Cclinit_003E();
			URLClassLoader result = new URLClassLoader(new URL[1] { P_0 }, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(276)]
		internal DecoupledLoader()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[] { 160, 182, 109, 127, 7, 97, 117 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Class loadFinalizer()
		{
			//Discarded unreachable code: IL_001a
			java.lang.Exception ex2;
			try
			{
				URLClassLoader uRLClassLoader = newLoader(getBaseUrl());
				return uRLClassLoader.loadClass("com.google.common.base.internal.Finalizer");
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
			java.lang.Exception thrown = ex2;
			access_0024000().log(Level.WARNING, "Could not load Finalizer in its own class loader. Loading Finalizer in the current class loader instead. As a result, you will not be able to garbage collect this class loader. To support reclaiming this class loader, either resolve the underlying issue, or move Guava to your system class path.", thrown);
			return null;
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

	internal class DirectLoader : java.lang.Object, FinalizerLoader
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
		[LineNumberTable(335)]
		internal DirectLoader()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[] { 160, 225, 127, 6, 97 })]
		public virtual Class loadFinalizer()
		{
			//Discarded unreachable code: IL_0011
			java.lang.ClassNotFoundException ex;
			try
			{
				return Class.forName("com.google.common.base.internal.Finalizer", DirectLoader.___003CGetCallerID_003E());
			}
			catch (java.lang.ClassNotFoundException x)
			{
				ex = ByteCodeHelper.MapException<java.lang.ClassNotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			}
			java.lang.ClassNotFoundException detailMessage = ex;
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError(detailMessage);
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

	internal interface FinalizerLoader
	{
		[Signature("()Ljava/lang/Class<*>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		virtual Class loadFinalizer();
	}

	internal class SystemLoader : java.lang.Object, FinalizerLoader
	{
		private sealed class ___003CCallerID_003E : CallerID
		{
			internal ___003CCallerID_003E()
			{
			}
		}

		internal static bool disabled;

		[SpecialName]
		private static CallerID ___003CcallerID_003E;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(240)]
		internal SystemLoader()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[]
		{
			160, 134, 103, 194, 214, 226, 61, 97, 111, 130,
			131, 122, 129, 162
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Class loadFinalizer()
		{
			//Discarded unreachable code: IL_0043
			if (disabled)
			{
				return null;
			}
			ClassLoader systemClassLoader;
			try
			{
				systemClassLoader = ClassLoader.getSystemClassLoader(SystemLoader.___003CGetCallerID_003E());
			}
			catch (SecurityException)
			{
				goto IL_001c;
			}
			if (systemClassLoader != null)
			{
				try
				{
					return systemClassLoader.loadClass("com.google.common.base.internal.Finalizer");
				}
				catch (java.lang.ClassNotFoundException)
				{
				}
				_ = null;
				return null;
			}
			return null;
			IL_001c:
			_ = null;
			access_0024000().info("Not allowed to access system class loader.");
			return null;
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Logger logger;

	private const string FINALIZER_CLASS_NAME = "com.google.common.base.internal.Finalizer";

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static Method startFinalizer;

	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/lang/ref/ReferenceQueue<Ljava/lang/Object;>;")]
	internal ReferenceQueue queue;

	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/lang/ref/PhantomReference<Ljava/lang/Object;>;")]
	internal PhantomReference frqRef;

	[Modifiers(Modifiers.Final)]
	internal bool threadStarted;

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
		160, 75, 104, 193, 239, 69, 134, 189, 2, 97,
		117, 130
	})]
	internal virtual void cleanUp()
	{
		if (threadStarted)
		{
			return;
		}
		Reference reference;
		while ((reference = queue.poll()) != null)
		{
			reference.clear();
			System.Exception ex;
			try
			{
				((FinalizableReference)reference).finalizeReferent();
			}
			catch (System.Exception x)
			{
				ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				goto IL_0038;
			}
			continue;
			IL_0038:
			System.Exception thrown = ex;
			logger.log(Level.SEVERE, "Error cleaning up after reference.", thrown);
		}
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	internal static Logger access_0024000()
	{
		return logger;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Lcom/google/common/base/FinalizableReferenceQueue$FinalizerLoader;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 160, 100, 111, 104, 100, 227, 61, 230, 71 })]
	private static Class loadFinalizer(params FinalizerLoader[] P_0)
	{
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			FinalizerLoader finalizerLoader = P_0[i];
			Class @class = finalizerLoader.loadFinalizer();
			if (@class != null)
			{
				return @class;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)Ljava/lang/reflect/Method;")]
	[LineNumberTable(new byte[] { 160, 235, 159, 37, 97 })]
	internal static Method getStartFinalizer(Class P_0)
	{
		//Discarded unreachable code: IL_0030
		NoSuchMethodException ex;
		try
		{
			return P_0.getMethod("startFinalizer", new Class[3]
			{
				ClassLiteral<Class>.Value,
				ClassLiteral<ReferenceQueue>.Value,
				ClassLiteral<PhantomReference>.Value
			}, FinalizableReferenceQueue.___003CGetCallerID_003E());
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
	[LineNumberTable(new byte[]
	{
		106,
		136,
		107,
		114,
		130,
		127,
		18,
		byte.MaxValue,
		1,
		73,
		226,
		56,
		98,
		109,
		98,
		246,
		71,
		103
	})]
	public FinalizableReferenceQueue()
	{
		queue = new ReferenceQueue();
		frqRef = new PhantomReference(this, queue);
		int num = 0;
		IllegalAccessException ex;
		System.Exception ex2;
		try
		{
			try
			{
				startFinalizer.invoke(null, new object[3]
				{
					ClassLiteral<FinalizableReference>.Value,
					queue,
					frqRef
				}, FinalizableReferenceQueue.___003CGetCallerID_003E());
				num = 1;
			}
			catch (IllegalAccessException x)
			{
				ex = ByteCodeHelper.MapException<IllegalAccessException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_0072;
			}
		}
		catch (System.Exception x2)
		{
			ex2 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
			goto IL_0075;
		}
		goto IL_00a1;
		IL_0075:
		System.Exception thrown = ex2;
		logger.log(Level.INFO, "Failed to start reference finalizer thread. Reference cleanup will only occur when new references are created.", thrown);
		goto IL_00a1;
		IL_0072:
		IllegalAccessException detailMessage = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError(detailMessage);
		IL_00a1:
		threadStarted = (byte)num != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 65, 108, 104 })]
	public virtual void close()
	{
		frqRef.enqueue();
		cleanUp();
	}

	[LineNumberTable(new byte[] { 84, 249, 72, 126, 102, 107 })]
	static FinalizableReferenceQueue()
	{
		logger = Logger.getLogger(ClassLiteral<FinalizableReferenceQueue>.Value.getName(), FinalizableReferenceQueue.___003CGetCallerID_003E());
		Class @class = loadFinalizer(new SystemLoader(), new DecoupledLoader(), new DirectLoader());
		startFinalizer = getStartFinalizer(@class);
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}

	void IDisposable.AutoCloseable_003A_003Aclose()
	{
		close();
	}
}
