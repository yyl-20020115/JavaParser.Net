using IKVM.Attributes;

namespace javassist.util.proxy;

[Implements(new string[] { "javassist.util.proxy.Proxy" })]
public interface ProxyObject : Proxy
{
	void setHandler(MethodHandler mh);

	virtual MethodHandler getHandler();
}
