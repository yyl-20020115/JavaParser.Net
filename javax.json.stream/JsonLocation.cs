namespace javax.json.stream;

public interface JsonLocation
{
	virtual long getLineNumber();

	virtual long getColumnNumber();

	virtual long getStreamOffset();
}
