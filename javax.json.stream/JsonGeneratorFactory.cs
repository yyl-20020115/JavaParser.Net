using IKVM.Attributes;
using java.io;
using java.nio.charset;
using java.util;

namespace javax.json.stream;

public interface JsonGeneratorFactory
{
	virtual JsonGenerator createGenerator(Writer w);

	virtual JsonGenerator createGenerator(OutputStream os);

	virtual JsonGenerator createGenerator(OutputStream os, Charset c);

	[Signature("()Ljava/util/Map<Ljava/lang/String;*>;")]
	virtual Map getConfigInUse();
}
