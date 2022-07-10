using System.Runtime.CompilerServices;
using System.Threading;
using IKVM.Attributes;
using java.lang;
using java.lang.@ref;
using java.security;
using java.util;

namespace javassist.scopedpool;

public class ScopedClassPool : ClassPool
{
	protected internal ScopedClassPoolRepository repository;

	[Signature("Ljava/lang/ref/Reference<Ljava/lang/ClassLoader;>;")]
	protected internal Reference classLoader;

	protected internal LoaderClassPath classPath;

	[Signature("Ljava/util/Map<Ljava/lang/String;Ljavassist/CtClass;>;")]
	protected internal Map softcache;

	internal bool isBootstrapCl;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		159, 121, 67, 233, 24, 139, 231, 103, 103, 108,
		99, 108, 141, 103, 134, 135
	})]
	protected internal ScopedClassPool(ClassLoader cl, ClassPool src, ScopedClassPoolRepository repository, bool isTemp)
		: base(src)
	{
		softcache = new SoftValueHashMap();
		isBootstrapCl = true;
		this.repository = repository;
		classLoader = new WeakReference(cl);
		if (cl != null)
		{
			classPath = new LoaderClassPath(cl);
			insertClassPath(classPath);
		}
		childFirstLookup = true;
		if (!isTemp && cl == null)
		{
			isBootstrapCl = true;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(114)]
	protected internal virtual ClassLoader getClassLoader0()
	{
		return (ClassLoader)classLoader.get();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 136, 114, 99, 98, 109, 119 })]
	protected internal virtual CtClass getCachedLocally(string classname)
	{
		//Discarded unreachable code: IL_0037
		CtClass ctClass = (CtClass)classes.get(classname);
		if (ctClass != null)
		{
			return ctClass;
		}
		lock (softcache)
		{
			return (CtClass)softcache.get(classname);
		}
	}

	public virtual bool isUnloadedClassLoader()
	{
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 54, 103, 139, 176 })]
	public override ClassLoader getClassLoader()
	{
		ClassLoader classLoader = getClassLoader0();
		if (classLoader == null && !isBootstrapCl)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException("ClassLoader has been garbage collected");
		}
		return classLoader;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 125, 112 })]
	public virtual void lockInCache(CtClass c)
	{
		base.cacheCtClass(c.getName(), c, dynamic: false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 16, 108 })]
	protected internal ScopedClassPool(ClassLoader cl, ClassPool src, ScopedClassPoolRepository repository)
		: this(cl, src, repository, isTemp: false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 71, 108, 107, 109 })]
	public virtual void close()
	{
		removeClassPath(classPath);
		classes.clear();
		softcache.clear();
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 109, 109 })]
	public virtual void flushClass(string classname)
	{
		classes.remove(classname);
		softcache.remove(classname);
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 94, 109, 102, 114, 115 })]
	public virtual void soften(CtClass clazz)
	{
		if (repository.isPrune())
		{
			clazz.prune();
		}
		classes.remove(clazz.getName());
		softcache.put(clazz.getName(), clazz);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		118, 104, 102, 130, 103, 102, 105, 98, 100, 223,
		14, 119, 108, 187, 175, 102, 109, 106, 127, 6,
		105, 104, 37, 133, 162, 105, 99, 140, 98, 218
	})]
	protected internal override CtClass getCached(string classname)
	{
		CtClass cachedLocally = getCachedLocally(classname);
		if (cachedLocally == null)
		{
			int num = 0;
			ClassLoader classLoader = getClassLoader0();
			if (classLoader != null)
			{
				int num2 = String.instancehelper_lastIndexOf(classname, 36);
				_ = null;
				string name = ((num2 >= 0) ? new StringBuilder().append(String.instancehelper_replaceAll(String.instancehelper_substring(classname, 0, num2), "[\\.]", "/")).append(String.instancehelper_substring(classname, num2)).append(".class")
					.toString() : new StringBuilder().append(String.instancehelper_replaceAll(classname, "[\\.]", "/")).append(".class").toString());
				num = ((classLoader.getResource(name) != null) ? 1 : 0);
			}
			if (num == 0)
			{
				Map registeredCLs = repository.getRegisteredCLs();
				Map obj;
				Monitor.Enter(obj = registeredCLs);
				try
				{
					Iterator iterator = registeredCLs.values().iterator();
					while (iterator.hasNext())
					{
						ScopedClassPool scopedClassPool = (ScopedClassPool)iterator.next();
						if (scopedClassPool.isUnloadedClassLoader())
						{
							repository.unregisterClassLoader(scopedClassPool.getClassLoader());
							continue;
						}
						cachedLocally = scopedClassPool.getCachedLocally(classname);
						if (cachedLocally == null)
						{
							continue;
						}
						CtClass result = cachedLocally;
						Monitor.Exit(obj);
						return result;
					}
					Monitor.Exit(obj);
					return cachedLocally;
				}
				catch
				{
					//try-fault
					Monitor.Exit(obj);
					throw;
				}
			}
		}
		return cachedLocally;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 87, 130, 99, 171, 109, 102, 142 })]
	protected internal override void cacheCtClass(string classname, CtClass c, bool dynamic)
	{
		if (dynamic)
		{
			base.cacheCtClass(classname, c, dynamic);
			return;
		}
		if (repository.isPrune())
		{
			c.prune();
		}
		softcache.put(classname, c);
	}

	[MethodImpl(MethodImplOptions.Synchronized | MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.NotFoundException" })]
	[LineNumberTable(new byte[] { 160, 155, 109, 114, 99, 105, 99, 108, 169 })]
	public virtual CtClass getLocally(string classname)
	{
		softcache.remove(classname);
		CtClass ctClass = (CtClass)classes.get(classname);
		if (ctClass == null)
		{
			ctClass = createCtClass(classname, useCache: true);
			if (ctClass == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NotFoundException(classname);
			}
			base.cacheCtClass(classname, ctClass, dynamic: false);
		}
		return ctClass;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "javassist.CannotCompileException" })]
	[Signature("(Ljavassist/CtClass;Ljava/lang/ClassLoader;Ljava/security/ProtectionDomain;)Ljava/lang/Class<*>;")]
	[LineNumberTable(new byte[] { 160, 191, 103 })]
	public override Class toClass(CtClass ct, ClassLoader loader, ProtectionDomain domain)
	{
		lockInCache(ct);
		Class result = base.toClass(ct, getClassLoader0(), domain);
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 191, 102, 102 })]
	static ScopedClassPool()
	{
		ClassPool.doPruning = false;
		ClassPool.releaseUnmodifiedClassFile = false;
	}
}
