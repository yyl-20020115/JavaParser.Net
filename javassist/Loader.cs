using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.reflect;
using java.security;
using java.util;
using javassist.bytecode;

namespace javassist;

public class Loader : ClassLoader
{
	public class Simple : ClassLoader
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(163)]
		public Simple()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 120, 105 })]
		public Simple(ClassLoader parent)
			: base(parent)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Throws(new string[] { "java.io.IOException", "javassist.CannotCompileException" })]
		[IKVM.Attributes.Signature("(Ljavassist/CtClass;)Ljava/lang/Class<*>;")]
		[LineNumberTable(new byte[] { 160, 64, 103 })]
		public virtual Class invokeDefineClass(CtClass cc)
		{
			byte[] array = cc.toBytecode();
			Class result = defineClass(cc.getName(), array, 0, array.Length);
			_ = null;
			return result;
		}

		[HideFromJava]
		static Simple()
		{
			ClassLoader.___003Cclinit_003E();
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[IKVM.Attributes.Signature("Ljava/util/HashMap<Ljava/lang/String;Ljava/lang/ClassLoader;>;")]
	private HashMap notDefinedHere;

	[IKVM.Attributes.Signature("Ljava/util/Vector<Ljava/lang/String;>;")]
	private Vector notDefinedPackages;

	private ClassPool source;

	private Translator translator;

	private ProtectionDomain domain;

	public bool doDelegation;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 100, 232, 50, 231, 79, 105 })]
	public Loader(ClassPool cp)
	{
		doDelegation = true;
		init(cp);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 117, 107, 107, 103, 103, 103, 109 })]
	private void init(ClassPool P_0)
	{
		notDefinedHere = new HashMap();
		notDefinedPackages = new Vector();
		source = P_0;
		translator = null;
		domain = null;
		delegateLoadingOf("javassist.Loader");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 134, 109, 142, 110 })]
	public virtual void delegateLoadingOf(string classname)
	{
		if (java.lang.String.instancehelper_endsWith(classname, "."))
		{
			notDefinedPackages.addElement(classname);
		}
		else
		{
			notDefinedHere.put(classname, this);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 92, 105 })]
	public Loader()
		: this(null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 160, 201, 101, 121 })]
	public virtual void run(string[] args)
	{
		if ((nint)args.LongLength >= 1)
		{
			run(args[0], (string[])Arrays.copyOfRange(args, 1, args.Length));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[]
	{
		160,
		212,
		136,
		byte.MaxValue,
		39,
		70,
		2,
		97,
		140
	})]
	public virtual void run(string classname, string[] args)
	{
		Class @class = loadClass(classname);
		InvocationTargetException ex;
		try
		{
			@class.getDeclaredMethod("main", new Class[1] { ClassLiteral<string[]>.Value }, Loader.___003CGetCallerID_003E()).invoke(null, new object[1] { args }, Loader.___003CGetCallerID_003E());
			return;
		}
		catch (InvocationTargetException x)
		{
			ex = ByteCodeHelper.MapException<InvocationTargetException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		InvocationTargetException ex2 = ex;
		throw Throwable.___003Cunmap_003E(ex2.getTargetException());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		161, 73, 98, 107, 115, 109, 109, 109, 109, 109,
		105, 103, 136
	})]
	protected internal virtual Class loadClassByDelegation(string name)
	{
		Class result = null;
		if (doDelegation && (java.lang.String.instancehelper_startsWith(name, "java.") || java.lang.String.instancehelper_startsWith(name, "javax.") || java.lang.String.instancehelper_startsWith(name, "jdk.internal.") || java.lang.String.instancehelper_startsWith(name, "sun.") || java.lang.String.instancehelper_startsWith(name, "com.sun.") || java.lang.String.instancehelper_startsWith(name, "org.w3c.") || java.lang.String.instancehelper_startsWith(name, "org.xml.") || notDelegated(name)))
		{
			result = delegateToParent(name);
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		161,
		8,
		104,
		104,
		178,
		218,
		31,
		5,
		97,
		194,
		127,
		15,
		109,
		99,
		133,
		byte.MaxValue,
		4,
		71,
		226,
		60,
		98,
		byte.MaxValue,
		8,
		69,
		106,
		101,
		107,
		138,
		251,
		70,
		226,
		61,
		225,
		70,
		104,
		108
	})]
	protected internal override Class findClass(string name)
	{
		byte[] array;
		java.lang.Exception ex3;
		try
		{
			if (source != null)
			{
				if (translator != null)
				{
					translator.onLoad(source, name);
				}
				try
				{
					array = source.get(name).toBytecode();
				}
				catch (NotFoundException)
				{
					goto IL_0052;
				}
				goto IL_00f4;
			}
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex2 = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex2 == null)
			{
				throw;
			}
			ex3 = ex2;
			goto IL_005a;
		}
		java.lang.Exception ex5;
		try
		{
			string name2 = new StringBuilder().append("/").append(java.lang.String.instancehelper_replace(name, '.', '/')).append(".class")
				.toString();
			InputStream resourceAsStream = java.lang.Object.instancehelper_getClass(this).getResourceAsStream(name2);
			if (resourceAsStream == null)
			{
				return null;
			}
			array = ClassPoolTail.readStream(resourceAsStream);
		}
		catch (System.Exception x2)
		{
			java.lang.Exception ex4 = ByteCodeHelper.MapException<java.lang.Exception>(x2, ByteCodeHelper.MapFlags.None);
			if (ex4 == null)
			{
				throw;
			}
			ex5 = ex4;
			goto IL_00c5;
		}
		goto IL_00f4;
		IL_005a:
		java.lang.Exception ex6 = ex3;
		goto IL_00cb;
		IL_0130:
		_ = null;
		goto IL_0136;
		IL_00c5:
		ex6 = ex5;
		goto IL_00cb;
		IL_00cb:
		java.lang.Exception ex7 = ex6;
		string s = new StringBuilder().append("caught an exception while obtaining a class file for ").append(name).toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new java.lang.ClassNotFoundException(s, ex7);
		IL_00f4:
		int num = java.lang.String.instancehelper_lastIndexOf(name, 46);
		if (num != -1)
		{
			string text = java.lang.String.instancehelper_substring(name, 0, num);
			if (isDefinedPackage(text))
			{
				try
				{
					definePackage(text, null, null, null, null, null, null, null);
				}
				catch (IllegalArgumentException)
				{
					goto IL_0130;
				}
			}
		}
		goto IL_0136;
		IL_0136:
		if (domain == null)
		{
			return defineClass(name, array, 0, array.Length);
		}
		return defineClass(name, array, 0, array.Length, domain);
		IL_0052:
		_ = null;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/String;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 161, 102, 103, 99, 106 })]
	protected internal virtual Class delegateToParent(string classname)
	{
		ClassLoader classLoader = getParent();
		if (classLoader != null)
		{
			Class result = classLoader.loadClass(classname);
			_ = null;
			return result;
		}
		Class result2 = findSystemClass(classname);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 54, 105, 141 })]
	private bool isDefinedPackage(string P_0)
	{
		if (ClassFile.___003C_003EMAJOR_VERSION >= 53)
		{
			throw new NoSuchMethodError("javassist.Loader.getDefinedPackage(Ljava.lang.String;)Ljava.lang.Package;");
		}
		return getPackage(P_0) == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 89, 110, 130, 127, 1, 105, 34, 162 })]
	private bool notDelegated(string P_0)
	{
		if (notDefinedHere.containsKey(P_0))
		{
			return true;
		}
		Iterator iterator = notDefinedPackages.iterator();
		while (iterator.hasNext())
		{
			string prefix = (string)iterator.next();
			if (java.lang.String.instancehelper_startsWith(P_0, prefix))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 112, 233, 38, 231, 91, 105 })]
	public Loader(ClassLoader parent, ClassPool cp)
		: base(parent)
	{
		doDelegation = true;
		init(cp);
	}

	public virtual void setDomain(ProtectionDomain d)
	{
		domain = d;
	}

	public virtual void setClassPool(ClassPool cp)
	{
		source = cp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 160, 168, 103, 103, 105 })]
	public virtual void addTranslator(ClassPool cp, Translator t)
	{
		source = cp;
		translator = t;
		t.start(cp);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.Throwable" })]
	[LineNumberTable(new byte[] { 160, 187, 102, 105 })]
	public static void main(string[] args)
	{
		Loader loader = new Loader();
		loader.run(args);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.ClassFormatError", "java.lang.ClassNotFoundException" })]
	[IKVM.Attributes.Signature("(Ljava/lang/String;Z)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[]
	{
		159, 57, 162, 104, 104, 104, 99, 136, 99, 136,
		99, 136, 99, 135, 103
	})]
	protected internal override Class loadClass(string name, bool resolve)
	{
		//Discarded unreachable code: IL_0048
		name = java.lang.String.instancehelper_intern(name);
		lock (name)
		{
			Class @class = findLoadedClass(name);
			if (@class == null)
			{
				@class = loadClassByDelegation(name);
			}
			if (@class == null)
			{
				@class = findClass(name);
			}
			if (@class == null)
			{
				@class = delegateToParent(name);
			}
			if (resolve)
			{
				resolveClass(@class);
			}
			return @class;
		}
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
	static Loader()
	{
		ClassLoader.___003Cclinit_003E();
	}
}
