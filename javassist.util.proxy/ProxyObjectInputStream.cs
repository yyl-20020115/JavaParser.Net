using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;

namespace javassist.util.proxy;

public class ProxyObjectInputStream : ObjectInputStream
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	private ClassLoader loader;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 159, 188, 105, 112, 104, 144 })]
	public ProxyObjectInputStream(InputStream @in)
		: base(@in)
	{
		loader = Thread.currentThread().getContextClassLoader();
		if (loader == null)
		{
			loader = ClassLoader.getSystemClassLoader(ProxyObjectInputStream.___003CGetCallerID_003E());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 99, 137, 139 })]
	public virtual void setClassLoader(ClassLoader loader)
	{
		if (loader != null)
		{
			this.loader = loader;
		}
		else
		{
			ClassLoader.getSystemClassLoader(ProxyObjectInputStream.___003CGetCallerID_003E());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[]
	{
		18, 103, 102, 108, 109, 103, 104, 104, 108, 17,
		200, 103, 104, 105, 167, 104, 104, 104, 105, 107,
		138
	})]
	protected internal override ObjectStreamClass readClassDescriptor()
	{
		if (readBoolean())
		{
			string name = (string)readObject();
			Class superclass = loader.loadClass(name);
			int num = readInt();
			Class[] array = new Class[num];
			for (int i = 0; i < num; i++)
			{
				name = (string)readObject();
				array[i] = loader.loadClass(name);
			}
			num = readInt();
			byte[] array2 = new byte[num];
			read(array2);
			ProxyFactory proxyFactory = new ProxyFactory();
			proxyFactory.setUseCache(useCache: true);
			proxyFactory.setUseWriteReplace(useWriteReplace: false);
			proxyFactory.setSuperclass(superclass);
			proxyFactory.setInterfaces(array);
			Class cl = proxyFactory.createClass(array2);
			ObjectStreamClass result = ObjectStreamClass.lookup(cl);
			_ = null;
			return result;
		}
		ObjectStreamClass result2 = base.readClassDescriptor();
		_ = null;
		return result2;
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
	static ProxyObjectInputStream()
	{
		ObjectInputStream.___003Cclinit_003E();
	}
}
