using IKVM.Attributes;
using java.io;
using java.nio.charset;
using java.util;

namespace javax.json;

public interface JsonReaderFactory
{
	virtual JsonReader createReader(Reader r);

	virtual JsonReader createReader(InputStream @is);

	virtual JsonReader createReader(InputStream @is, Charset c);

	[Signature("()Ljava/util/Map<Ljava/lang/String;*>;")]
	virtual Map getConfigInUse();
}
