using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace javassist.scopedpool;

public class ScopedClassPoolFactoryImpl : Object, ScopedClassPoolFactory
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(27)]
	public ScopedClassPoolFactoryImpl()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(33)]
	public virtual ScopedClassPool create(ClassLoader cl, ClassPool src, ScopedClassPoolRepository repository)
	{
		ScopedClassPool result = new ScopedClassPool(cl, src, repository, isTemp: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	public virtual ScopedClassPool create(ClassPool src, ScopedClassPoolRepository repository)
	{
		ScopedClassPool result = new ScopedClassPool(null, src, repository, isTemp: true);
		_ = null;
		return result;
	}
}
