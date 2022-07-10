using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.net;
using java.util;

namespace javassist.tools.web;

public class Webserver : java.lang.Object
{
	private ServerSocket socket;

	private ClassPool classPool;

	protected internal Translator translator;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static byte[] endofline;

	private const int typeHtml = 1;

	private const int typeClass = 2;

	private const int typeGif = 3;

	private const int typeJpeg = 4;

	private const int typeText = 5;

	public string debugDir;

	public string htmlfileBase;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 57, 110 })]
	public Webserver(string port)
		: this(Integer.parseInt(port))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 77, 175, 119, 216, 2, 97, 108 })]
	public virtual void run()
	{
		java.lang.System.err.println("ready to service...");
		while (true)
		{
			IOException ex;
			try
			{
				ServiceThread.___003Cclinit_003E();
				ServiceThread serviceThread = new ServiceThread(this, socket.accept());
				serviceThread.start();
			}
			catch (IOException x)
			{
				ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_003b;
			}
			continue;
			IL_003b:
			IOException @this = ex;
			logging(Throwable.instancehelper_toString(@this));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 65, 232, 18, 231, 80, 231, 95, 108, 103, 103 })]
	public Webserver(int port)
	{
		debugDir = null;
		htmlfileBase = null;
		socket = new ServerSocket(port);
		classPool = null;
		translator = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 106, 109 })]
	public virtual void logging(string msg)
	{
		java.lang.System.@out.println(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 111, 134, 112, 139, 103 })]
	private string readLine(InputStream P_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num;
		while ((num = P_0.read()) >= 0 && num != 13)
		{
			stringBuilder.append((char)num);
		}
		P_0.read();
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 122, 107, 111, 107, 111, 109 })]
	public virtual void logging(string msg1, string msg2, string msg3)
	{
		java.lang.System.@out.print(msg1);
		java.lang.System.@out.print(" ");
		java.lang.System.@out.print(msg2);
		java.lang.System.@out.print(" ");
		java.lang.System.@out.println(msg3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 160, 122, 98, 112, 134, 103 })]
	private int skipLine(InputStream P_0)
	{
		int num = 0;
		int num2;
		while ((num2 = P_0.read()) >= 0 && num2 != 13)
		{
			num++;
		}
		P_0.read();
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.tools.web.BadHttpRequest" })]
	[LineNumberTable(new byte[]
	{
		160, 143, 109, 149, 139, 109, 100, 122, 100, 109,
		100, 109, 132, 130, 103, 104, 103, 129, 104, 104,
		156, 105, 142, 104, 105, 111, 105, 140, 106, 100,
		98, 172, 105, 225, 70, 103, 97, 127, 7, 103,
		103, 140, 106, 100, 98, 173, 105, 108, 104, 105,
		193
	})]
	public virtual void doReply(InputStream @in, OutputStream @out, string cmd)
	{
		if (java.lang.String.instancehelper_startsWith(cmd, "GET /"))
		{
			string str;
			string text = (str = java.lang.String.instancehelper_substring(cmd, 5, java.lang.String.instancehelper_indexOf(cmd, 32, 5)));
			int num = (java.lang.String.instancehelper_endsWith(text, ".class") ? 2 : ((java.lang.String.instancehelper_endsWith(text, ".html") || java.lang.String.instancehelper_endsWith(text, ".htm")) ? 1 : (java.lang.String.instancehelper_endsWith(text, ".gif") ? 3 : ((!java.lang.String.instancehelper_endsWith(text, ".jpg")) ? 5 : 4))));
			int num2 = java.lang.String.instancehelper_length(text);
			if (num == 2 && letUsersSendClassfile(@out, text, num2))
			{
				return;
			}
			checkFilename(text, num2);
			if (htmlfileBase != null)
			{
				text = new StringBuilder().append(htmlfileBase).append(text).toString();
			}
			if (File.separatorChar != '/')
			{
				text = java.lang.String.instancehelper_replace(text, '/', File.separatorChar);
			}
			File file = new File(text);
			if (file.canRead())
			{
				sendHeader(@out, file.length(), num);
				FileInputStream fileInputStream = new FileInputStream(file);
				byte[] b = new byte[4096];
				while (true)
				{
					num2 = fileInputStream.read(b);
					if (num2 <= 0)
					{
						break;
					}
					@out.write(b, 0, num2);
				}
				fileInputStream.close();
				return;
			}
			if (num == 2)
			{
				InputStream resourceAsStream = java.lang.Object.instancehelper_getClass(this).getResourceAsStream(new StringBuilder().append("/").append(str).toString());
				if (resourceAsStream != null)
				{
					ByteArrayOutputStream byteArrayOutputStream = new ByteArrayOutputStream();
					byte[] b2 = new byte[4096];
					while (true)
					{
						num2 = resourceAsStream.read(b2);
						if (num2 <= 0)
						{
							break;
						}
						byteArrayOutputStream.write(b2, 0, num2);
					}
					byte[] array = byteArrayOutputStream.toByteArray();
					sendHeader(@out, array.LongLength, 2);
					@out.write(array);
					resourceAsStream.close();
					return;
				}
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadHttpRequest();
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadHttpRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 161, 25, 127, 6, 112, 107, 107, 114 })]
	private void replyError(OutputStream P_0, BadHttpRequest P_1)
	{
		logging2(new StringBuilder().append("bad request: ").append(P_1.toString()).toString());
		P_0.write(java.lang.String.instancehelper_getBytes("HTTP/1.0 400 Bad Request"));
		P_0.write(endofline);
		P_0.write(endofline);
		P_0.write(java.lang.String.instancehelper_getBytes("<H1>Bad Request</H1>"));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "javassist.tools.web.BadHttpRequest" })]
	[LineNumberTable(new byte[]
	{
		160, 231, 104, 162, 101, 143, 104, 146, 109, 103,
		104, 223, 4, 2, 98, 173, 107, 103
	})]
	private bool letUsersSendClassfile(OutputStream P_0, string P_1, int P_2)
	{
		if (classPool == null)
		{
			return false;
		}
		string text = java.lang.String.instancehelper_replace(java.lang.String.instancehelper_substring(P_1, 0, P_2 - 6), '/', '.');
		byte[] array;
		java.lang.Exception ex2;
		try
		{
			if (translator != null)
			{
				translator.onLoad(classPool, text);
			}
			CtClass ctClass = classPool.get(text);
			array = ctClass.toBytecode();
			if (debugDir != null)
			{
				ctClass.writeFile(debugDir);
			}
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
			goto IL_0074;
		}
		sendHeader(P_0, array.LongLength, 2);
		P_0.write(array);
		return true;
		IL_0074:
		java.lang.Exception e = ex2;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new BadHttpRequest(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.tools.web.BadHttpRequest" })]
	[LineNumberTable(new byte[]
	{
		160, 217, 102, 104, 114, 235, 61, 230, 70, 110,
		107
	})]
	private void checkFilename(string P_0, int P_1)
	{
		for (int i = 0; i < P_1; i++)
		{
			int num = java.lang.String.instancehelper_charAt(P_0, i);
			if (!Character.isJavaIdentifierPart((char)num) && num != 46 && num != 47)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new BadHttpRequest();
			}
		}
		if (java.lang.String.instancehelper_indexOf(P_0, "..") >= 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new BadHttpRequest();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 2, 112, 107, 112, 113, 107, 100, 114, 100,
		114, 100, 114, 100, 114, 100, 144, 107, 109
	})]
	private void sendHeader(OutputStream P_0, long P_1, int P_2)
	{
		P_0.write(java.lang.String.instancehelper_getBytes("HTTP/1.0 200 OK"));
		P_0.write(endofline);
		P_0.write(java.lang.String.instancehelper_getBytes("Content-Length: "));
		P_0.write(java.lang.String.instancehelper_getBytes(Long.toString(P_1)));
		P_0.write(endofline);
		switch (P_2)
		{
		case 2:
			P_0.write(java.lang.String.instancehelper_getBytes("Content-Type: application/octet-stream"));
			break;
		case 1:
			P_0.write(java.lang.String.instancehelper_getBytes("Content-Type: text/html"));
			break;
		case 3:
			P_0.write(java.lang.String.instancehelper_getBytes("Content-Type: image/gif"));
			break;
		case 4:
			P_0.write(java.lang.String.instancehelper_getBytes("Content-Type: image/jpg"));
			break;
		case 5:
			P_0.write(java.lang.String.instancehelper_getBytes("Content-Type: text/plain"));
			break;
		}
		P_0.write(endofline);
		P_0.write(endofline);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 69, 111, 109 })]
	public virtual void logging2(string msg)
	{
		java.lang.System.@out.print("    ");
		java.lang.System.@out.println(msg);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 42, 101, 105, 102, 130, 145 })]
	public static void main(string[] args)
	{
		if ((nint)args.LongLength == 1)
		{
			Webserver webserver = new Webserver(args[0]);
			webserver.run();
		}
		else
		{
			java.lang.System.err.println("Usage: java javassist.tools.web.Webserver <port number>");
		}
	}

	public virtual void setClassPool(ClassPool loader)
	{
		classPool = loader;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 90, 103, 103, 110 })]
	public virtual void addTranslator(ClassPool cp, Translator t)
	{
		classPool = cp;
		translator = t;
		t.start(classPool);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 99, 109 })]
	public virtual void end()
	{
		socket.close();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 113, 107, 111, 109 })]
	public virtual void logging(string msg1, string msg2)
	{
		java.lang.System.@out.print(msg1);
		java.lang.System.@out.print(" ");
		java.lang.System.@out.println(msg2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		160, 89, 113, 104, 113, 38, 133, 172, 140, 219,
		2, 98, 169, 102, 102, 102, 102
	})]
	internal void process(Socket P_0)
	{
		BufferedInputStream.___003Cclinit_003E();
		BufferedInputStream bufferedInputStream = new BufferedInputStream(P_0.getInputStream());
		string text = readLine(bufferedInputStream);
		logging(P_0.getInetAddress().getHostName(), new Date().toString(), text);
		while (skipLine(bufferedInputStream) > 0)
		{
		}
		BufferedOutputStream bufferedOutputStream = new BufferedOutputStream(P_0.getOutputStream());
		BadHttpRequest badHttpRequest;
		try
		{
			doReply(bufferedInputStream, bufferedOutputStream, text);
		}
		catch (BadHttpRequest x)
		{
			badHttpRequest = ByteCodeHelper.MapException<BadHttpRequest>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0065;
		}
		goto IL_0075;
		IL_0065:
		BadHttpRequest badHttpRequest2 = badHttpRequest;
		replyError(bufferedOutputStream, badHttpRequest2);
		goto IL_0075;
		IL_0075:
		bufferedOutputStream.flush();
		bufferedInputStream.close();
		bufferedOutputStream.close();
		P_0.close();
	}

	[LineNumberTable(55)]
	static Webserver()
	{
		endofline = new byte[2] { 13, 10 };
	}
}
