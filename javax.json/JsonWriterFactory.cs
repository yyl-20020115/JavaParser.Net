using IKVM.Attributes;
using java.io;
using java.nio.charset;
using java.util;

namespace javax.json;

public interface JsonWriterFactory
{
	virtual JsonWriter createWriter(Writer w);

	virtual JsonWriter createWriter(OutputStream os);

	virtual JsonWriter createWriter(OutputStream os, Charset c);

	[Signature("()Ljava/util/Map<Ljava/lang/String;*>;")]
	virtual Map getConfigInUse();
}
