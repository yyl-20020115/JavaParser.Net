using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.net;
using java.util;
using java.util.jar;

namespace javassist;

[SourceFile("ClassPoolTail.java")]
internal sealed class JarClassPath : Object, ClassPath
{
	[Signature("Ljava/util/Set<Ljava/lang/String;>;")]
	internal Set jarfileEntries;

	internal string jarfileURL;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		84, 104, 130, 103, 107, 127, 6, 114, 50, 130,
		108, 218, 132, 113, 99, 230, 60, 132, 113, 227,
		58, 97, 129, 132, 113, 133
	})]
	internal JarClassPath(string P_0)
	{
		JarFile jarFile = null;
		try
		{
			try
			{
				jarFile = new JarFile(P_0);
				jarfileEntries = new HashSet();
				Iterator iterator = Collections.list(jarFile.entries()).iterator();
				while (iterator.hasNext())
				{
					JarEntry jarEntry = (JarEntry)iterator.next();
					if (String.instancehelper_endsWith(jarEntry.getName(), ".class"))
					{
						jarfileEntries.add(jarEntry.getName());
					}
				}
				jarfileURL = new File(P_0).getCanonicalFile().toURI().toURL()
					.toString();
			}
			catch (IOException)
			{
				goto IL_00a8;
			}
		}
		catch
		{
			//try-fault
			if (null != jarFile)
			{
				try
				{
					jarFile.close();
				}
				catch (IOException)
				{
					goto IL_009f;
				}
			}
			goto end_IL_008d;
			IL_009f:
			_ = null;
			end_IL_008d:
			throw;
		}
		if (null != jarFile)
		{
			try
			{
				jarFile.close();
				return;
			}
			catch (IOException)
			{
			}
			_ = null;
		}
		return;
		IL_00a8:
		_ = null;
		if (null != jarFile)
		{
			try
			{
				jarFile.close();
			}
			catch (IOException)
			{
				goto IL_00d7;
			}
		}
		goto IL_00df;
		IL_00df:
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NotFoundException(P_0);
		IL_00d7:
		_ = null;
		goto IL_00df;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 65, 127, 5, 142, 159, 23, 97 })]
	public virtual URL find(string P_0)
	{
		//Discarded unreachable code: IL_005b
		string text = new StringBuilder().append(String.instancehelper_replace(P_0, '.', '/')).append(".class").toString();
		if (jarfileEntries.contains(text))
		{
			try
			{
				URL.___003Cclinit_003E();
				return new URL(String.format("jar:%s!/%s", jarfileURL, text));
			}
			catch (MalformedURLException)
			{
			}
			_ = null;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		109, 104, 135, 103, 142, 103, 103, 183, 97, 191,
		6
	})]
	public virtual InputStream openClassfile(string P_0)
	{
		//Discarded unreachable code: IL_003a
		URL uRL = find(P_0);
		if (null != uRL)
		{
			try
			{
				if (ClassPool.cacheOpenedJarFile)
				{
					return uRL.openConnection().getInputStream();
				}
				URLConnection uRLConnection = uRL.openConnection();
				uRLConnection.setUseCaches(usecaches: false);
				return uRLConnection.getInputStream();
			}
			catch (IOException)
			{
			}
			_ = null;
			string msg = new StringBuilder().append("broken jar file?: ").append(P_0).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NotFoundException(msg);
		}
		return null;
	}

	public override string toString()
	{
		return (jarfileURL != null) ? jarfileURL : "<null>";
	}
}
