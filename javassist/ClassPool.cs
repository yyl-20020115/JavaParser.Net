using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.lang.invoke;
using java.net;
using java.security;
using java.util;
using javassist.bytecode;
using javassist.util.proxy;

namespace javassist;

public class ClassPool : java.lang.Object
{
	public bool childFirstLookup;

	public static bool doPruning = false;

	private int compressCount;

	private const int COMPRESS_THRESHOLD = 100;

	public static bool releaseUnmodifiedClassFile = true;

	public static bool cacheOpenedJarFile = true;

	internal ClassPoolTail ___003C_003Esource;

	protected internal ClassPool parent;

	protected internal Hashtable classes;

	private Hashtable cflow;

	private const int INIT_HASH_SIZE = 191;

	private ArrayList importedPackages;

	private static ClassPool defaultPool = null;

	[Modifiers(Modifiers.Protected)]
	protected internal object source
	{
		[HideFromJava]
		get
		{
			return ___003C_003Esource;
		}
		[HideFromJava]
		set
		{
			___003C_003Esource = (ClassPoolTail)value;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 91, 105 })]
	public ClassPool()
		: this(null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(982)]
	public virtual ClassPath appendClassPath(string pathname)
	{
		ClassPath result = ___003C_003Esource.appendClassPath(pathname);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 161, 54, 99, 132, 137, 99, 140, 102 })]
	public virtual CtClass get(string classname)
	{
		CtClass ctClass = ((classname != null) ? get0(classname, useCache: true) : null);
		if (ctClass == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NotFoundException(classname);
		}
		ctClass.incGetCounter();
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		116, 232, 159, 173, 231, 112, 231, 100, 112, 107,
		103, 99, 102, 103, 55, 198, 103, 103, 104
	})]
	public ClassPool(ClassPool parent)
	{
		childFirstLookup = false;
		cflow = null;
		classes = new Hashtable(191);
		___003C_003Esource = new ClassPoolTail();
		this.parent = parent;
		if (parent == null)
		{
			CtClass[] primitiveTypes = CtClass.primitiveTypes;
			for (int i = 0; i < (nint)primitiveTypes.LongLength; i++)
			{
				classes.put(primitiveTypes[i].getName(), primitiveTypes[i]);
			}
		}
		cflow = null;
		compressCount = 0;
		clearImportedPackages();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(920)]
	public virtual ClassPath appendSystemPath()
	{
		ClassPath result = ___003C_003Esource.appendSystemPath();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 185, 107, 113 })]
	public virtual void clearImportedPackages()
	{
		importedPackages = new ArrayList();
		importedPackages.add("java.lang");
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		159, 16, 98, 98, 99, 104, 99, 162, 112, 110,
		99, 162, 105, 131, 99, 142, 162, 112, 142
	})]
	protected internal virtual CtClass get0(string classname, bool useCache)
	{
		_ = null;
		CtClass cached;
		if (useCache)
		{
			cached = getCached(classname);
			if (cached != null)
			{
				return cached;
			}
		}
		if (!childFirstLookup && parent != null)
		{
			cached = parent.get0(classname, useCache);
			if (cached != null)
			{
				return cached;
			}
		}
		cached = createCtClass(classname, useCache);
		if (cached != null)
		{
			if (useCache)
			{
				cacheCtClass(cached.getName(), cached, dynamic: false);
			}
			return cached;
		}
		if (childFirstLookup && parent != null)
		{
			cached = parent.get0(classname, useCache);
		}
		return cached;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(225)]
	protected internal virtual CtClass getCached(string classname)
	{
		return (CtClass)classes.get(classname);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(247)]
	protected internal virtual CtClass removeCached(string classname)
	{
		return (CtClass)classes.remove(classname);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[]
	{
		161,
		211,
		104,
		99,
		150,
		153,
		99,
		99,
		byte.MaxValue,
		6,
		69,
		104,
		159,
		6
	})]
	internal virtual void checkNotFrozen(string P_0)
	{
		CtClass ctClass = getCached(P_0);
		if (ctClass == null)
		{
			if (!childFirstLookup && parent != null)
			{
				try
				{
					ctClass = parent.get0(P_0, useCache: true);
				}
				catch (NotFoundException)
				{
					goto IL_0037;
				}
				goto IL_003d;
			}
			return;
		}
		if (ctClass.isFrozen())
		{
			string message = new StringBuilder().append(P_0).append(": frozen class (cannot edit)").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message);
		}
		return;
		IL_0037:
		_ = null;
		goto IL_003d;
		IL_003d:
		if (ctClass != null)
		{
			string message2 = new StringBuilder().append(P_0).append(" is in a parent ClassPool.  Use the parent.").toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new RuntimeException(message2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 122, 110 })]
	protected internal virtual void cacheCtClass(string classname, CtClass c, bool dynamic)
	{
		classes.put(classname, c);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 7, 130, 107, 136, 109, 112, 117, 130, 170,
		105, 130
	})]
	protected internal virtual CtClass createCtClass(string classname, bool useCache)
	{
		if (java.lang.String.instancehelper_charAt(classname, 0) == '[')
		{
			classname = Descriptor.toClassName(classname);
		}
		if (java.lang.String.instancehelper_endsWith(classname, "[]"))
		{
			string classname2 = java.lang.String.instancehelper_substring(classname, 0, java.lang.String.instancehelper_indexOf(classname, 91));
			if ((!useCache || getCached(classname2) == null) && find(classname2) == null)
			{
				return null;
			}
			CtArray result = new CtArray(classname, this);
			_ = null;
			return result;
		}
		if (find(classname) == null)
		{
			return null;
		}
		CtClassType result2 = new CtClassType(classname, this);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(569)]
	public virtual URL find(string classname)
	{
		URL result = ___003C_003Esource.find(classname);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[]
	{
		158, 222, 98, 102, 103, 104, 102, 103, 99, 135,
		105
	})]
	public virtual CtClass makeClass(InputStream classfile, bool ifNotFrozen)
	{
		compress();
		BufferedInputStream bufferedInputStream = new BufferedInputStream(classfile);
		CtClassType ctClassType = new CtClassType(bufferedInputStream, this);
		ctClassType.checkModify();
		string name = ctClassType.getName();
		if (ifNotFrozen)
		{
			checkNotFrozen(name);
		}
		cacheCtClass(name, ctClassType, dynamic: true);
		return ctClassType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 148, 119, 103, 108, 104, 146 })]
	internal virtual void compress()
	{
		int num = compressCount;
		compressCount = num + 1;
		if (num > 100)
		{
			compressCount = 0;
			Enumeration enumeration = classes.elements();
			while (enumeration.hasMoreElements())
			{
				((CtClass)enumeration.nextElement()).compress();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[] { 158, 210, 130, 102, 104, 102, 103, 99, 135, 105 })]
	public virtual CtClass makeClass(ClassFile classfile, bool ifNotFrozen)
	{
		compress();
		CtClassType ctClassType = new CtClassType(classfile, this);
		ctClassType.checkModify();
		string name = ctClassType.getName();
		if (ifNotFrozen)
		{
			checkNotFrozen(name);
		}
		cacheCtClass(name, ctClassType, dynamic: true);
		return ctClassType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 236, 104, 99, 144, 153, 163 })]
	internal virtual CtClass checkNotExists(string P_0)
	{
		CtClass ctClass = getCached(P_0);
		if (ctClass == null && !childFirstLookup && parent != null)
		{
			try
			{
				ctClass = parent.get0(P_0, useCache: true);
				return ctClass;
			}
			catch (NotFoundException)
			{
			}
			_ = null;
		}
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[] { 162, 211, 103, 106, 105 })]
	public virtual CtClass makeClass(string classname, CtClass superclass)
	{
		checkNotFrozen(classname);
		CtNewClass ctNewClass = new CtNewClass(classname, this, false, superclass);
		cacheCtClass(classname, ctNewClass, dynamic: true);
		return ctNewClass;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[]
	{
		162,
		byte.MaxValue,
		103,
		106,
		105
	})]
	public virtual CtClass makeInterface(string name, CtClass superclass)
	{
		checkNotFrozen(name);
		CtNewClass ctNewClass = new CtNewClass(name, this, true, superclass);
		cacheCtClass(name, ctNewClass, dynamic: true);
		return ctNewClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1070)]
	public virtual ClassLoader getClassLoader()
	{
		ClassLoader contextClassLoader = getContextClassLoader();
		_ = null;
		return contextClassLoader;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[Obsolete]
	[LineNumberTable(1098)]
	public virtual Class toClass(CtClass ct, ClassLoader loader)
	{
		Class result = toClass(ct, null, loader, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1078)]
	internal static ClassLoader getContextClassLoader()
	{
		ClassLoader contextClassLoader = Thread.currentThread().getContextClassLoader();
		_ = null;
		return contextClassLoader;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljavassist/CtClass;Ljava/lang/Class<*>;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class;")]
	[LineNumberTable(new byte[] { 164, 102, 107, 37, 187, 97 })]
	public virtual Class toClass(CtClass ct, Class neighbor, ClassLoader loader, ProtectionDomain domain)
	{
		//Discarded unreachable code: IL_0017
		IOException ex;
		try
		{
			return DefineClassHelper.toClass(ct.getName(), neighbor, loader, domain, ct.toBytecode());
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 104, 130, 105, 99, 103 })]
	public ClassPool(bool useDefaultPath)
		: this(null)
	{
		if (useDefaultPath)
		{
			appendSystemPath();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Super)]
	[LineNumberTable(new byte[] { 159, 91, 172, 103, 107, 171 })]
	public static ClassPool getDefault()
	{
		lock (ClassLiteral<ClassPool>.Value)
		{
			if (defaultPool == null)
			{
				defaultPool = new ClassPool(null);
				defaultPool.appendSystemPath();
			}
			return defaultPool;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(254)]
	public override string toString()
	{
		string result = ___003C_003Esource.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 174, 109 })]
	public virtual void importPackage(string packageName)
	{
		importedPackages.add(packageName);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[IKVM.Attributes.Signature("()Ljava/util/Iterator<Ljava/lang/String;>;")]
	[LineNumberTable(310)]
	public virtual Iterator getImportedPackages()
	{
		Iterator result = importedPackages.iterator();
		_ = null;
		return result;
	}

	[Obsolete]
	public virtual void recordInvalidClassName(string name)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 226, 104, 139, 123 })]
	internal virtual void recordCflow(string P_0, string P_1, string P_2)
	{
		if (cflow == null)
		{
			cflow = new Hashtable();
		}
		cflow.put(P_0, new object[2] { P_1, P_2 });
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 238, 104, 139 })]
	public virtual object[] lookupCflow(string name)
	{
		if (cflow == null)
		{
			cflow = new Hashtable();
		}
		return (object[])cflow.get(name);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 161, 9, 105, 99, 140, 104, 140, 135 })]
	public virtual CtClass getAndRename(string orgName, string newName)
	{
		CtClass ctClass = get0(orgName, useCache: false);
		if (ctClass == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NotFoundException(orgName);
		}
		if (ctClass is CtClassType)
		{
			((CtClassType)ctClass).setClassPool(this);
		}
		ctClass.setName(newName);
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 27, 104, 100, 136, 103, 103, 107 })]
	internal virtual void classNameChanged(string P_0, CtClass P_1)
	{
		CtClass cached = getCached(P_0);
		if (cached == P_1)
		{
			removeCached(P_0);
		}
		string name = P_1.getName();
		checkNotFrozen(name);
		cacheCtClass(name, P_1, dynamic: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 82, 98, 99, 228, 71, 148, 131, 99, 134 })]
	public virtual CtClass getOrNull(string classname)
	{
		CtClass ctClass = null;
		if (classname == null)
		{
			ctClass = null;
		}
		else
		{
			try
			{
				ctClass = get0(classname, useCache: true);
			}
			catch (NotFoundException)
			{
				goto IL_001a;
			}
		}
		goto IL_0020;
		IL_001a:
		_ = null;
		goto IL_0020;
		IL_0020:
		ctClass?.incGetCounter();
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 161, 122, 107, 138 })]
	public virtual CtClass getCtClass(string classname)
	{
		if (java.lang.String.instancehelper_charAt(classname, 0) == '[')
		{
			CtClass result = Descriptor.toCtClass(classname, this);
			_ = null;
			return result;
		}
		CtClass result2 = get(classname);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(621)]
	internal virtual InputStream openClassfile(string P_0)
	{
		InputStream result = ___003C_003Esource.openClassfile(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException", "java.io.IOException", "javassist.CannotCompileException" })]
	[LineNumberTable(new byte[] { 162, 1, 111 })]
	internal virtual void writeClassfile(string P_0, OutputStream P_1)
	{
		___003C_003Esource.writeClassfile(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 162, 16, 99, 135, 99, 103, 102, 44, 166 })]
	public virtual CtClass[] get(string[] classnames)
	{
		if (classnames == null)
		{
			return new CtClass[0];
		}
		int num = classnames.Length;
		CtClass[] array = new CtClass[num];
		for (int i = 0; i < num; i++)
		{
			array[i] = get(classnames[i]);
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 162, 37, 104 })]
	public virtual CtMethod getMethod(string classname, string methodname)
	{
		CtClass ctClass = get(classname);
		CtMethod declaredMethod = ctClass.getDeclaredMethod(methodname);
		_ = null;
		return declaredMethod;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.RuntimeException" })]
	[LineNumberTable(685)]
	public virtual CtClass makeClass(InputStream classfile)
	{
		CtClass result = makeClass(classfile, ifNotFrozen: true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(734)]
	public virtual CtClass makeClass(ClassFile classfile)
	{
		CtClass result = makeClass(classfile, ifNotFrozen: true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[]
	{
		162, 157, 102, 103, 104, 102, 103, 104, 99, 130,
		105
	})]
	public virtual CtClass makeClassIfNew(InputStream classfile)
	{
		compress();
		BufferedInputStream bufferedInputStream = new BufferedInputStream(classfile);
		CtClassType ctClassType = new CtClassType(bufferedInputStream, this);
		ctClassType.checkModify();
		string name = ctClassType.getName();
		CtClass ctClass = checkNotExists(name);
		if (ctClass != null)
		{
			return ctClass;
		}
		cacheCtClass(name, ctClassType, dynamic: true);
		return ctClassType;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(814)]
	public virtual CtClass makeClass(string classname)
	{
		CtClass result = makeClass(classname, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 225, 103, 106, 105 })]
	internal virtual CtClass makeNestedClass(string P_0)
	{
		checkNotFrozen(P_0);
		CtNewClass ctNewClass = new CtNewClass(P_0, this, false, null);
		cacheCtClass(P_0, ctNewClass, dynamic: true);
		return ctNewClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(866)]
	public virtual CtClass makeInterface(string name)
	{
		CtClass result = makeInterface(name, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.RuntimeException" })]
	[LineNumberTable(new byte[] { 163, 17, 115, 114, 151, 129 })]
	public virtual CtClass makeAnnotation(string name)
	{
		//Discarded unreachable code: IL_0028
		NotFoundException ex;
		try
		{
			CtClass ctClass = makeInterface(name, get("java.lang.annotation.Annotation"));
			ctClass.setModifiers(ctClass.getModifiers() | 0x2000);
			return ctClass;
		}
		catch (NotFoundException x)
		{
			ex = ByteCodeHelper.MapException<NotFoundException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NotFoundException ex2 = ex;
		string message = Throwable.instancehelper_getMessage(ex2);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(message, ex2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(933)]
	public virtual ClassPath insertClassPath(ClassPath cp)
	{
		ClassPath result = ___003C_003Esource.insertClassPath(cp);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(946)]
	public virtual ClassPath appendClassPath(ClassPath cp)
	{
		ClassPath result = ___003C_003Esource.appendClassPath(cp);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(964)]
	public virtual ClassPath insertClassPath(string pathname)
	{
		ClassPath result = ___003C_003Esource.insertClassPath(pathname);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 109, 110 })]
	public virtual void removeClassPath(ClassPath cp)
	{
		___003C_003Esource.removeClassPath(cp);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[]
	{
		163, 125, 102, 130, 105, 100, 110, 162, 111, 132,
		98
	})]
	public virtual void appendPathList(string pathlist)
	{
		int pathSeparatorChar = File.pathSeparatorChar;
		int num = 0;
		while (true)
		{
			int num2 = java.lang.String.instancehelper_indexOf(pathlist, pathSeparatorChar, num);
			if (num2 < 0)
			{
				break;
			}
			appendClassPath(java.lang.String.instancehelper_substring(pathlist, num, num2));
			num = num2 + 1;
		}
		appendClassPath(java.lang.String.instancehelper_substring(pathlist, num));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[LineNumberTable(1056)]
	public virtual Class toClass(CtClass clazz)
	{
		Class result = toClass(clazz, getClassLoader());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[Obsolete]
	[LineNumberTable(1136)]
	public virtual Class toClass(CtClass ct, ClassLoader loader, ProtectionDomain domain)
	{
		Class result = toClass(ct, null, loader, domain);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljavassist/CtClass;Ljava/lang/Class<*>;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 164, 20, 98, 37, 187, 97 })]
	public virtual Class toClass(CtClass ct, Class neighbor)
	{
		//Discarded unreachable code: IL_000e
		IOException ex;
		try
		{
			return DefineClassHelper.toClass(neighbor, ct.toBytecode());
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[IKVM.Attributes.Signature("(Ljavassist/CtClass;Ljava/lang/invoke/MethodHandles$Lookup;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 164, 46, 98, 37, 187, 97 })]
	public virtual Class toClass(CtClass ct, MethodHandles.Lookup lookup)
	{
		//Discarded unreachable code: IL_000e
		IOException ex;
		try
		{
			return DefineClassHelper.toClass(lookup, ct.toBytecode());
		}
		catch (IOException x)
		{
			ex = ByteCodeHelper.MapException<IOException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		IOException e = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new CannotCompileException(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[Obsolete]
	[LineNumberTable(new byte[] { 164, 133, 105 })]
	public virtual void makePackage(ClassLoader loader, string name)
	{
		DefinePackageHelper.definePackage(name, loader);
	}
}
