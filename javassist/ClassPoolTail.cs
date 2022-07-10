using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.net;
using javassist.bytecode;

namespace javassist;

internal sealed class ClassPoolTail : Object
{
	protected internal ClassPathList pathList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 83, 104, 103 })]
	public ClassPoolTail()
	{
		pathList = null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 89, 102, 108, 103, 99, 114, 108, 169, 105 })]
	public override string toString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.append("[class path: ");
		for (ClassPathList next = pathList; next != null; next = next.next)
		{
			stringBuilder.append(Object.instancehelper_toString(next.path));
			stringBuilder.append(File.pathSeparatorChar);
		}
		stringBuilder.append(']');
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 253, 103, 98, 99, 109, 99, 137, 162 })]
	public virtual URL find(string P_0)
	{
		ClassPathList next = pathList;
		_ = null;
		while (next != null)
		{
			URL uRL = next.path.find(P_0);
			if (uRL == null)
			{
				next = next.next;
				continue;
			}
			return uRL;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160,
		221,
		103,
		98,
		98,
		131,
		byte.MaxValue,
		0,
		69,
		226,
		61,
		98,
		99,
		163,
		99,
		137,
		162,
		99,
		103
	})]
	internal virtual InputStream openClassfile(string P_0)
	{
		ClassPathList next = pathList;
		InputStream inputStream = null;
		NotFoundException ex = null;
		while (next != null)
		{
			NotFoundException ex2;
			try
			{
				inputStream = next.path.openClassfile(P_0);
			}
			catch (NotFoundException x)
			{
				ex2 = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
				goto IL_002a;
			}
			goto IL_0037;
			IL_0037:
			if (inputStream == null)
			{
				next = next.next;
				continue;
			}
			return inputStream;
			IL_002a:
			NotFoundException ex3 = ex2;
			if (ex == null)
			{
				ex = ex3;
			}
			goto IL_0037;
		}
		if (ex != null)
		{
			throw Throwable.___003Cunmap_003E(ex);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException", "java.io.IOException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 179, 104, 99, 172, 171, 102, 35, 98, 98 })]
	internal virtual void writeClassfile(string P_0, OutputStream P_1)
	{
		InputStream inputStream = openClassfile(P_0);
		if (inputStream == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NotFoundException(P_0);
		}
		try
		{
			copyStream(inputStream, P_1);
		}
		finally
		{
			inputStream.close();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 137, 105, 110, 107 })]
	public virtual ClassPath appendSystemPath()
	{
		if (ClassFile.___003C_003EMAJOR_VERSION < 53)
		{
			ClassPath result = appendClassPath(new ClassClassPath());
			_ = null;
			return result;
		}
		ClassLoader contextClassLoader = Thread.currentThread().getContextClassLoader();
		ClassPath result2 = appendClassPath(new LoaderClassPath(contextClassLoader));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 103, 114 })]
	public virtual ClassPath insertClassPath(ClassPath P_0)
	{
		pathList = new ClassPathList(P_0, pathList);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 108, 104, 103, 99, 137, 104, 137, 167 })]
	public virtual ClassPath appendClassPath(ClassPath P_0)
	{
		ClassPathList next = new ClassPathList(P_0, null);
		ClassPathList next2 = pathList;
		if (next2 == null)
		{
			pathList = next;
		}
		else
		{
			while (next2.next != null)
			{
				next2 = next2.next;
			}
			next2.next = next;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(260)]
	public virtual ClassPath insertClassPath(string P_0)
	{
		ClassPath result = insertClassPath(makePathObject(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(266)]
	public virtual ClassPath appendClassPath(string P_0)
	{
		ClassPath result = appendClassPath(makePathObject(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[LineNumberTable(new byte[] { 160, 123, 103, 99, 105, 142, 104, 110, 147, 137 })]
	public virtual void removeClassPath(ClassPath P_0)
	{
		ClassPathList next = pathList;
		if (next == null)
		{
			return;
		}
		if (next.path == P_0)
		{
			pathList = next.next;
			return;
		}
		while (next.next != null)
		{
			if (next.next.path == P_0)
			{
				next.next = next.next.next;
			}
			else
			{
				next = next.next;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		160, 158, 103, 122, 137, 103, 117, 109, 108, 107,
		169
	})]
	private static ClassPath makePathObject(string P_0)
	{
		string @this = String.instancehelper_toLowerCase(P_0);
		if (String.instancehelper_endsWith(@this, ".jar") || String.instancehelper_endsWith(@this, ".zip"))
		{
			JarClassPath result = new JarClassPath(P_0);
			_ = null;
			return result;
		}
		int num = String.instancehelper_length(P_0);
		if (num > 2 && String.instancehelper_charAt(P_0, num - 1) == '*' && (String.instancehelper_charAt(P_0, num - 2) == '/' || String.instancehelper_charAt(P_0, num - 2) == File.separatorChar))
		{
			string text = String.instancehelper_substring(P_0, 0, num - 2);
			JarDirClassPath result2 = new JarDirClassPath(text);
			_ = null;
			return result2;
		}
		DirClassPath result3 = new DirClassPath(P_0);
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 53, 102, 98, 106, 100, 100, 135, 98, 130,
		109, 101, 135, 107, 129, 100, 231, 48, 233, 83
	})]
	public static void copyStream(InputStream P_0, OutputStream P_1)
	{
		int num = 4096;
		byte[] b = null;
		for (int i = 0; i < 64; i++)
		{
			if (i < 8)
			{
				num *= 2;
				b = new byte[num];
			}
			int num2 = 0;
			_ = 0;
			do
			{
				int num3 = P_0.read(b, num2, num - num2);
				if (num3 >= 0)
				{
					num2 += num3;
					continue;
				}
				P_1.write(b, 0, num2);
				return;
			}
			while (num2 < num);
			P_1.write(b);
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IOException("too much data");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[]
	{
		161, 16, 103, 134, 105, 105, 98, 130, 111, 101,
		138, 112, 99, 104, 118, 13, 232, 69, 110, 131,
		103, 228, 44, 233, 87
	})]
	public static byte[] readStream(InputStream P_0)
	{
		byte[][] array = new byte[8][];
		int num = 4096;
		for (int i = 0; i < 8; i++)
		{
			array[i] = new byte[num];
			int num2 = 0;
			_ = 0;
			do
			{
				int num3 = P_0.read(array[i], num2, num - num2);
				if (num3 >= 0)
				{
					num2 += num3;
					continue;
				}
				byte[] array2 = new byte[num - 4096 + num2];
				int num4 = 0;
				for (int j = 0; j < i; j++)
				{
					ByteCodeHelper.arraycopy_primitive_1(array[j], 0, array2, num4, num4 + 4096);
					num4 = num4 + num4 + 4096;
				}
				ByteCodeHelper.arraycopy_primitive_1(array[i], 0, array2, num4, num2);
				return array2;
			}
			while (num2 < num);
			num *= 2;
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IOException("too much data");
	}
}
