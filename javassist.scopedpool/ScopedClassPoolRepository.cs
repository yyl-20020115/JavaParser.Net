using IKVM.Attributes;
using java.lang;
using java.util;

namespace javassist.scopedpool;

public interface ScopedClassPoolRepository
{
	virtual bool isPrune();

	[Signature("()Ljava/util/Map<Ljava/lang/ClassLoader;Ljavassist/scopedpool/ScopedClassPool;>;")]
	virtual Map getRegisteredCLs();

	virtual void unregisterClassLoader(ClassLoader cl);

	virtual void setClassPoolFactory(ScopedClassPoolFactory scpf);

	virtual ScopedClassPoolFactory getClassPoolFactory();

	virtual void setPrune(bool b);

	virtual ScopedClassPool createScopedClassPool(ClassLoader cl, ClassPool cp);

	virtual ClassPool findClassPool(ClassLoader cl);

	virtual ClassPool registerClassLoader(ClassLoader cl);

	virtual void clearUnregisteredClassLoaders();
}
