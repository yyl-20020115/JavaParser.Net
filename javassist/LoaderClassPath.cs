using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.lang.@ref;
using java.net;

namespace javassist;

public class LoaderClassPath : Object, ClassPath
{
	[Signature("Ljava/lang/ref/Reference<Ljava/lang/ClassLoader;>;")]
	private Reference clref;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 3, 104, 108 })]
	public LoaderClassPath(ClassLoader cl)
	{
		clref = new WeakReference(cl);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(59)]
	public override string toString()
	{
		string result = ((clref.get() != null) ? Object.instancehelper_toString((ClassLoader)clref.get()) : "<null>");
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 19, 127, 5, 113, 99, 98, 104 })]
	public virtual InputStream openClassfile(string classname)
	{
		string name = new StringBuilder().append(String.instancehelper_replace(classname, '.', '/')).append(".class").toString();
		return ((ClassLoader)clref.get())?.getResourceAsStream(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 36, 127, 5, 113, 99, 98, 104 })]
	public virtual URL find(string classname)
	{
		string name = new StringBuilder().append(String.instancehelper_replace(classname, '.', '/')).append(".class").toString();
		return ((ClassLoader)clref.get())?.getResource(name);
	}
}
