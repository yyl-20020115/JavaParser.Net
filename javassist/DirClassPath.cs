using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.net;

namespace javassist;

[SourceFile("ClassPoolTail.java")]
internal sealed class DirClassPath : Object, ClassPath
{
	internal string directory;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 189, 104, 103 })]
	internal DirClassPath(string P_0)
	{
		directory = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 4, 102, 122, 122, 154, 97, 99 })]
	public virtual InputStream openClassfile(string P_0)
	{
		//Discarded unreachable code: IL_0042
		try
		{
			try
			{
				int separatorChar = File.separatorChar;
				string name = new StringBuilder().append(directory).append((char)separatorChar).append(String.instancehelper_replace(P_0, '.', (char)separatorChar))
					.append(".class")
					.toString();
				return new FileInputStream(name);
			}
			catch (FileNotFoundException)
			{
			}
		}
		catch (SecurityException)
		{
			goto IL_0050;
		}
		_ = null;
		goto IL_0058;
		IL_0050:
		_ = null;
		goto IL_0058;
		IL_0058:
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 16, 102, 122, 122, 103, 136, 159, 5, 97, 131 })]
	public virtual URL find(string P_0)
	{
		//Discarded unreachable code: IL_005b
		int separatorChar = File.separatorChar;
		string pathname = new StringBuilder().append(directory).append((char)separatorChar).append(String.instancehelper_replace(P_0, '.', (char)separatorChar))
			.append(".class")
			.toString();
		File file = new File(pathname);
		if (file.exists())
		{
			try
			{
				try
				{
					return file.getCanonicalFile().toURI().toURL();
				}
				catch (MalformedURLException)
				{
				}
			}
			catch (IOException)
			{
				goto IL_0069;
			}
			_ = null;
		}
		goto IL_0071;
		IL_0071:
		return null;
		IL_0069:
		_ = null;
		goto IL_0071;
	}

	public override string toString()
	{
		return directory;
	}
}
