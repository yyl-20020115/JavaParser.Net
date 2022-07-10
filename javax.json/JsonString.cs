using IKVM.Attributes;
using java.lang;

namespace javax.json;

[Implements(new string[] { "javax.json.JsonValue" })]
public interface JsonString : JsonValue
{
	virtual string getString();

	virtual CharSequence getChars();

	virtual bool equals(object obj);

	virtual int hashCode();
}
