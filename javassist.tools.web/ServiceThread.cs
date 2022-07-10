using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.net;

namespace javassist.tools.web;

[SourceFile("Webserver.java")]
internal class ServiceThread : Thread
{
	internal Webserver web;

	internal Socket sock;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 37, 104, 103, 103 })]
	public ServiceThread(Webserver P_0, Socket P_1)
	{
		web = P_0;
		sock = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 45, 188, 34, 129 })]
	public override void run()
	{
		try
		{
			web.process(sock);
			return;
		}
		catch (IOException)
		{
		}
		_ = null;
	}

	[HideFromJava]
	static ServiceThread()
	{
		Thread.___003Cclinit_003E();
	}
}
