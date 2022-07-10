namespace javax.json;

public interface JsonMergePatch
{
	virtual JsonValue apply(JsonValue jv);

	virtual JsonValue toJsonValue();
}
