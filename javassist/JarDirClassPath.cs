using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.net;

namespace javassist;

[SourceFile("ClassPoolTail.java")]
internal sealed class JarDirClassPath : Object, ClassPath
{
	[SpecialName]
	[EnclosingMethod(null, "<init>", "(Ljava.lang.String;)V")]
	internal class _1 : Object, FilenameFilter
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal JarDirClassPath this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(90)]
		internal _1(JarDirClassPath P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 43, 104 })]
		public virtual bool accept(File P_0, string P_1)
		{
			P_1 = String.instancehelper_toLowerCase(P_1);
			return (String.instancehelper_endsWith(P_1, ".jar") || String.instancehelper_endsWith(P_1, ".zip")) ? true : false;
		}
	}

	internal JarClassPath[] jars;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 39, 104, 242, 72, 99, 109, 103, 53, 166 })]
	internal JarDirClassPath(string P_0)
	{
		File[] array = new File(P_0).listFiles(new _1(this));
		if (array != null)
		{
			jars = new JarClassPath[(nint)array.LongLength];
			for (int i = 0; i < (nint)array.LongLength; i++)
			{
				jars[i] = new JarClassPath(array[i].getPath());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 57, 104, 108, 111, 99, 226, 61, 230, 70 })]
	public virtual InputStream openClassfile(string P_0)
	{
		if (jars != null)
		{
			for (int i = 0; i < (nint)jars.LongLength; i++)
			{
				InputStream inputStream = jars[i].openClassfile(P_0);
				if (inputStream != null)
				{
					return inputStream;
				}
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 69, 104, 108, 111, 99, 226, 61, 230, 70 })]
	public virtual URL find(string P_0)
	{
		if (jars != null)
		{
			for (int i = 0; i < (nint)jars.LongLength; i++)
			{
				URL uRL = jars[i].find(P_0);
				if (uRL != null)
				{
					return uRL;
				}
			}
		}
		return null;
	}
}
