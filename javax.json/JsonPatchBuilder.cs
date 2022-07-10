namespace javax.json;

public interface JsonPatchBuilder
{
	virtual JsonPatchBuilder add(string str, JsonValue jv);

	virtual JsonPatchBuilder add(string str1, string str2);

	virtual JsonPatchBuilder add(string str, int i);

	virtual JsonPatchBuilder add(string str, bool b);

	virtual JsonPatchBuilder remove(string str);

	virtual JsonPatchBuilder replace(string str, JsonValue jv);

	virtual JsonPatchBuilder replace(string str1, string str2);

	virtual JsonPatchBuilder replace(string str, int i);

	virtual JsonPatchBuilder replace(string str, bool b);

	virtual JsonPatchBuilder move(string str1, string str2);

	virtual JsonPatchBuilder copy(string str1, string str2);

	virtual JsonPatchBuilder test(string str, JsonValue jv);

	virtual JsonPatchBuilder test(string str1, string str2);

	virtual JsonPatchBuilder test(string str, int i);

	virtual JsonPatchBuilder test(string str, bool b);

	virtual JsonPatch build();
}
