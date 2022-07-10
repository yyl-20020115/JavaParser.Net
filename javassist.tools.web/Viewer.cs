using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.net;

namespace javassist.tools.web;

public class Viewer : ClassLoader
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private string server;

	private int port;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 28, 104, 103, 103 })]
	public Viewer(string host, int p)
	{
		server = host;
		port = p;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 52, 136, 127, 10, 221, 2, 97, 140 })]
	public virtual void run(string classname, string[] args)
	{
		Class @class = loadClass(classname);
		InvocationTargetException ex;
		try
		{
			@class.getDeclaredMethod("main", new Class[1] { ClassLiteral<string[]>.Value }, Viewer.___003CGetCallerID_003E()).invoke(null, new object[1] { args }, Viewer.___003CGetCallerID_003E());
			return;
		}
		catch (InvocationTargetException x)
		{
			ex = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		InvocationTargetException ex2 = ex;
		throw Throwable.___003Cunmap_003E(ex2.getTargetException());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		94, 98, 127, 1, 103, 136, 131, 104, 99, 191,
		2, 34, 161
	})]
	protected internal override Class findClass(string name)
	{
		Class @class = null;
		if (java.lang.String.instancehelper_startsWith(name, "java.") || java.lang.String.instancehelper_startsWith(name, "javax.") || java.lang.String.instancehelper_equals(name, "javassist.tools.web.Viewer"))
		{
			@class = findSystemClass(name);
		}
		if (@class == null)
		{
			try
			{
				byte[] array = fetchClass(name);
				if (array != null)
				{
					@class = defineClass(name, array, 0, array.Length);
					return @class;
				}
				return @class;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}
		return @class;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Exception" })]
	[LineNumberTable(new byte[]
	{
		118, 127, 11, 127, 0, 103, 102, 103, 103, 100,
		142, 104, 131, 112, 101, 102, 191, 6, 103, 165,
		102
	})]
	protected internal virtual byte[] fetchClass(string classname)
	{
		URL.___003Cclinit_003E();
		URL uRL = new URL("http", server, port, new StringBuilder().append("/").append(java.lang.String.instancehelper_replace(classname, '.', '/')).append(".class")
			.toString());
		URLConnection uRLConnection = uRL.openConnection();
		uRLConnection.connect();
		int contentLength = uRLConnection.getContentLength();
		InputStream inputStream = uRLConnection.getInputStream();
		byte[] array;
		if (contentLength <= 0)
		{
			array = readStream(inputStream);
		}
		else
		{
			array = new byte[contentLength];
			int num = 0;
			do
			{
				int num2 = inputStream.read(array, num, contentLength - num);
				if (num2 < 0)
				{
					inputStream.close();
					string message = new StringBuilder().append("the stream was closed: ").append(classname).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new IOException(message);
				}
				num += num2;
			}
			while (num < contentLength);
		}
		inputStream.close();
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 81, 107, 98, 130, 100, 103, 106, 106, 162,
		109, 132, 103, 106
	})]
	private byte[] readStream(InputStream P_0)
	{
		byte[] array = new byte[4096];
		int num = 0;
		int num2 = 0;
		byte[] array2;
		do
		{
			num += num2;
			if ((nint)array.LongLength - num <= 0)
			{
				array2 = new byte[(nint)array.LongLength * 2];
				ByteCodeHelper.arraycopy_primitive_1(array, 0, array2, 0, num);
				array = array2;
			}
			num2 = P_0.read(array, num, (int)((nint)array.LongLength - num));
		}
		while (num2 >= 0);
		array2 = new byte[num];
		ByteCodeHelper.arraycopy_primitive_1(array, 0, array2, 0, num);
		return array2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 11, 101, 113, 106, 109, 106, 130, 145 })]
	public static void main(string[] args)
	{
		if ((nint)args.LongLength >= 3)
		{
			Viewer viewer = new Viewer(args[0], Integer.parseInt(args[1]));
			string[] array = new string[(nint)args.LongLength - 3];
			ByteCodeHelper.arraycopy_fast(args, 3, array, 0, (int)((nint)args.LongLength - 3));
			viewer.run(args[2], array);
		}
		else
		{
			java.lang.System.err.println("Usage: java javassist.tools.web.Viewer <host> <port> class [args ...]");
		}
	}

	public virtual string getServer()
	{
		return server;
	}

	public virtual int getPort()
	{
		return port;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[Signature("(Ljava/lang/String;Z)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 159, 113, 162, 104, 99, 136, 99, 140, 99, 135 })]
	protected internal override Class loadClass(string name, bool resolve)
	{
		Class @class = findLoadedClass(name);
		if (@class == null)
		{
			@class = findClass(name);
		}
		if (@class == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ClassNotFoundException(name);
		}
		if (resolve)
		{
			resolveClass(@class);
		}
		return @class;
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
	static Viewer()
	{
		ClassLoader.___003Cclinit_003E();
	}
}
