using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.net;

namespace javassist;

public class ClassClassPath : Object, ClassPath
{
	[Signature("Ljava/lang/Class<*>;")]
	private Class thisClass;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<*>;)V")]
	[LineNumberTable(new byte[] { 8, 104, 103 })]
	public ClassClassPath(Class c)
	{
		thisClass = c;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 21, 109 })]
	internal ClassClassPath()
		: this(ClassLiteral<Object>.Value)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 29, 127, 12 })]
	public virtual InputStream openClassfile(string classname)
	{
		string name = new StringBuilder().append('/').append(String.instancehelper_replace(classname, '.', '/')).append(".class")
			.toString();
		InputStream resourceAsStream = thisClass.getResourceAsStream(name);
		_ = null;
		return resourceAsStream;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 40, 127, 12 })]
	public virtual URL find(string classname)
	{
		string name = new StringBuilder().append('/').append(String.instancehelper_replace(classname, '.', '/')).append(".class")
			.toString();
		URL resource = thisClass.getResource(name);
		_ = null;
		return resource;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(96)]
	public override string toString()
	{
		string result = new StringBuilder().append(thisClass.getName()).append(".class").toString();
		_ = null;
		return result;
	}
}
