using java.lang.reflect;

namespace javassist.util.proxy;

public interface MethodFilter
{
	virtual bool isHandled(Method m);
}
