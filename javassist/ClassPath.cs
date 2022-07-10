using IKVM.Attributes;
using java.io;
using java.net;

namespace javassist;

public interface ClassPath
{
	[Throws(new string[] { "javassist.NotFoundException" })]
	virtual InputStream openClassfile(string str);

	virtual URL find(string str);
}
