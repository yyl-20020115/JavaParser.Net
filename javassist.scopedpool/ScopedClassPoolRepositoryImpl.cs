using System.Runtime.CompilerServices;
using System.Threading;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace javassist.scopedpool;

public class ScopedClassPoolRepositoryImpl : Object, ScopedClassPoolRepository
{
	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static ScopedClassPoolRepositoryImpl instance;

	private bool prune;

	internal bool pruneWhenCached;

	[Signature("Ljava/util/Map<Ljava/lang/ClassLoader;Ljavassist/scopedpool/ScopedClassPool;>;")]
	protected internal Map registeredCLs;

	protected internal ClassPool classpool;

	protected internal ScopedClassPoolFactory factory;

	[SpecialName]
	private static CallerID ___003CcallerID_003E;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 72, 237, 70, 110, 154, 110, 110, 109 })]
	public virtual ClassPool registerClassLoader(ClassLoader ucl)
	{
		//Discarded unreachable code: IL_005a
		Map obj;
		Monitor.Enter(obj = registeredCLs);
		try
		{
			if (registeredCLs.containsKey(ucl))
			{
				ClassPool result = (ClassPool)registeredCLs.get(ucl);
				Monitor.Exit(obj);
				return result;
			}
			ScopedClassPool scopedClassPool = createScopedClassPool(ucl, classpool);
			registeredCLs.put(ucl, scopedClassPool);
			Monitor.Exit(obj);
			return scopedClassPool;
		}
		catch
		{
			//try-fault
			Monitor.Exit(obj);
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(103)]
	public virtual ScopedClassPool createScopedClassPool(ClassLoader cl, ClassPool src)
	{
		ScopedClassPool result = factory.create(cl, src, this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		102, 98, 109, 127, 9, 114, 114, 100, 99, 102,
		137, 146, 101, 99, 124, 106, 111
	})]
	public virtual void clearUnregisteredClassLoaders()
	{
		ArrayList arrayList = null;
		lock (registeredCLs)
		{
			Iterator iterator = registeredCLs.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				if (!((ScopedClassPool)entry.getValue()).isUnloadedClassLoader())
				{
					continue;
				}
				ClassLoader classLoader = ((ScopedClassPool)entry.getValue()).getClassLoader();
				if (classLoader != null)
				{
					if (arrayList == null)
					{
						arrayList = new ArrayList();
					}
					((List)arrayList).add((object)classLoader);
				}
				registeredCLs.remove(entry.getKey());
			}
			if (arrayList != null)
			{
				iterator = ((List)arrayList).iterator();
				while (iterator.hasNext())
				{
					ClassLoader cl = (ClassLoader)iterator.next();
					unregisterClassLoader(cl);
				}
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 123, 109, 114, 99, 102, 111 })]
	public virtual void unregisterClassLoader(ClassLoader cl)
	{
		lock (registeredCLs)
		{
			((ScopedClassPool)registeredCLs.remove(cl))?.close();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		17, 232, 37, 231, 70, 102, 234, 70, 235, 79,
		139, 107, 114
	})]
	private ScopedClassPoolRepositoryImpl()
	{
		prune = true;
		registeredCLs = Collections.synchronizedMap(new WeakHashMap());
		factory = new ScopedClassPoolFactoryImpl();
		classpool = ClassPool.getDefault();
		ClassLoader contextClassLoader = java.lang.Thread.currentThread().getContextClassLoader();
		classpool.insertClassPath(new LoaderClassPath(contextClassLoader));
	}

	public static ScopedClassPoolRepository getInstance()
	{
		return instance;
	}

	public virtual bool isPrune()
	{
		return prune;
	}

	public virtual void setPrune(bool prune)
	{
		int num = ((this.prune = prune) ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 58, 99, 147 })]
	public virtual ClassPool findClassPool(ClassLoader cl)
	{
		if (cl == null)
		{
			ClassPool result = registerClassLoader(ClassLoader.getSystemClassLoader(ScopedClassPoolRepositoryImpl.___003CGetCallerID_003E()));
			_ = null;
			return result;
		}
		ClassPool result2 = registerClassLoader(cl);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<Ljava/lang/ClassLoader;Ljavassist/scopedpool/ScopedClassPool;>;")]
	[LineNumberTable(new byte[] { 92, 102 })]
	public virtual Map getRegisteredCLs()
	{
		clearUnregisteredClassLoaders();
		return registeredCLs;
	}

	public virtual void insertDelegate(ScopedClassPoolRepository @delegate)
	{
	}

	public virtual void setClassPoolFactory(ScopedClassPoolFactory factory)
	{
		this.factory = factory;
	}

	public virtual ScopedClassPoolFactory getClassPoolFactory()
	{
		return factory;
	}

	[LineNumberTable(37)]
	static ScopedClassPoolRepositoryImpl()
	{
		instance = new ScopedClassPoolRepositoryImpl();
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
