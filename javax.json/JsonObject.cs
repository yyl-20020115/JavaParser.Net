using IKVM.Attributes;
using java.util;

namespace javax.json;

[Signature("Ljava/lang/Object;Ljavax/json/JsonStructure;Ljava/util/Map<Ljava/lang/String;Ljavax/json/JsonValue;>;")]
[Implements(new string[] { "javax.json.JsonStructure", "java.util.Map" })]
public interface JsonObject : JsonStructure, JsonValue, Map
{
	virtual string getString(string str);

	virtual JsonArray getJsonArray(string str);

	virtual JsonObject getJsonObject(string str);

	virtual int getInt(string str);

	virtual JsonNumber getJsonNumber(string str);

	virtual JsonString getJsonString(string str);

	virtual string getString(string str1, string str2);

	virtual int getInt(string str, int i);

	virtual bool getBoolean(string str);

	virtual bool getBoolean(string str, bool b);

	virtual bool isNull(string str);
}
