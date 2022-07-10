using IKVM.Attributes;
using java.lang.reflect;

namespace javassist.util.proxy;

public interface MethodHandler
{
	[Throws(new string[] { "java.lang.Throwable" })]
	virtual object invoke(object obj, Method m1, Method m2, object[] objarr);
}
