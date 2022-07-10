using java.lang;

namespace javassist.scopedpool;

public interface ScopedClassPoolFactory
{
	virtual ScopedClassPool create(ClassLoader cl, ClassPool cp, ScopedClassPoolRepository scpr);

	virtual ScopedClassPool create(ClassPool cp, ScopedClassPoolRepository scpr);
}
