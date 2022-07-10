using IKVM.Attributes;
using java.io;
using java.nio.charset;
using java.util;

namespace javax.json.stream;

public interface JsonParserFactory
{
	virtual JsonParser createParser(Reader r);

	virtual JsonParser createParser(InputStream @is);

	virtual JsonParser createParser(InputStream @is, Charset c);

	virtual JsonParser createParser(JsonObject jo);

	virtual JsonParser createParser(JsonArray ja);

	[Signature("()Ljava/util/Map<Ljava/lang/String;*>;")]
	virtual Map getConfigInUse();
}
