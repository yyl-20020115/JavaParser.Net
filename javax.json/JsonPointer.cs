using IKVM.Attributes;

namespace javax.json;

public interface JsonPointer
{
	virtual JsonValue getValue(JsonStructure js);

	[Signature("<T::Ljavax/json/JsonStructure;>(TT;Ljavax/json/JsonValue;)TT;")]
	virtual JsonStructure add(JsonStructure js, JsonValue jv);

	[Signature("<T::Ljavax/json/JsonStructure;>(TT;)TT;")]
	virtual JsonStructure remove(JsonStructure js);

	[Signature("<T::Ljavax/json/JsonStructure;>(TT;Ljavax/json/JsonValue;)TT;")]
	virtual JsonStructure replace(JsonStructure js, JsonValue jv);

	virtual bool containsValue(JsonStructure js);
}
