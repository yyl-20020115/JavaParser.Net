using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.net;

namespace javassist;

public class URLClassPath : Object, ClassPath
{
	protected internal string hostname;

	protected internal int port;

	protected internal string directory;

	protected internal string packageName;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 43, 118, 117, 122, 149 })]
	private URLConnection openClassfile0(string P_0)
	{
		if (packageName == null || String.instancehelper_startsWith(P_0, packageName))
		{
			string text = new StringBuilder().append(directory).append(String.instancehelper_replace(P_0, '.', '/')).append(".class")
				.toString();
			URLConnection result = fetchClass0(hostname, port, text);
			_ = null;
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 118, 249, 69, 226, 61, 129, 176, 103, 102 })]
	private static URLConnection fetchClass0(string P_0, int P_1, string P_2)
	{
		URL uRL;
		try
		{
			uRL = new URL("http", P_0, P_1, P_2);
		}
		catch (MalformedURLException)
		{
			goto IL_0016;
		}
		URLConnection uRLConnection = uRL.openConnection();
		uRLConnection.connect();
		return uRLConnection;
		IL_0016:
		_ = null;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IOException("invalid URL?");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 104, 103, 103, 103, 104 })]
	public URLClassPath(string host, int port, string directory, string packageName)
	{
		hostname = host;
		this.port = port;
		this.directory = directory;
		this.packageName = packageName;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public override string toString()
	{
		string result = new StringBuilder().append(hostname).append(":").append(port)
			.append(directory)
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 104, 99, 153, 99 })]
	public virtual InputStream openClassfile(string classname)
	{
		//Discarded unreachable code: IL_0015
		try
		{
			URLConnection uRLConnection = openClassfile0(classname);
			if (uRLConnection != null)
			{
				return uRLConnection.getInputStream();
			}
		}
		catch (IOException)
		{
			goto IL_0020;
		}
		goto IL_0027;
		IL_0020:
		_ = null;
		goto IL_0027;
		IL_0027:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 59, 104, 103, 99, 102, 185, 99 })]
	public virtual URL find(string classname)
	{
		//Discarded unreachable code: IL_0022
		try
		{
			URLConnection uRLConnection = openClassfile0(classname);
			InputStream inputStream = uRLConnection.getInputStream();
			if (inputStream != null)
			{
				inputStream.close();
				return uRLConnection.getURL();
			}
		}
		catch (IOException)
		{
			goto IL_002d;
		}
		goto IL_0034;
		IL_002d:
		_ = null;
		goto IL_0034;
		IL_0034:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		85, 114, 57, 134, 103, 135, 100, 140, 103, 131,
		111, 101, 191, 6, 103, 201, 102, 35, 98, 130
	})]
	public static byte[] fetchClass(string host, int port, string directory, string classname)
	{
		URLConnection uRLConnection = fetchClass0(host, port, new StringBuilder().append(directory).append(String.instancehelper_replace(classname, '.', '/')).append(".class")
			.toString());
		int contentLength = uRLConnection.getContentLength();
		InputStream inputStream = uRLConnection.getInputStream();
		try
		{
			if (contentLength <= 0)
			{
				return ClassPoolTail.readStream(inputStream);
			}
			byte[] array = new byte[contentLength];
			int num = 0;
			do
			{
				int num2 = inputStream.read(array, num, contentLength - num);
				if (num2 < 0)
				{
					string message = new StringBuilder().append("the stream was closed: ").append(classname).toString();
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new IOException(message);
				}
				num += num2;
			}
			while (num < contentLength);
			return array;
		}
		finally
		{
			inputStream.close();
		}
	}
}
