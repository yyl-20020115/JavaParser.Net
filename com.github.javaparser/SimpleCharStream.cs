


namespace com.github.javaparser;

public class SimpleCharStream : AbstractCharStream
{
	private Provider inputStream;

	
	
	
	public SimpleCharStream(Provider dstream, int startline, int startcolumn)
		: this(dstream, startline, startcolumn, 4096)
	{
	}

	
	
	
	public virtual void reInit(Provider dstream, int startline, int startcolumn)
	{
		reInit(dstream, startline, startcolumn, 4096);
	}

	
	
	
	public SimpleCharStream(Provider dstream, int startline, int startcolumn, int buffersize)
		: base(startline, startcolumn, buffersize)
	{
		inputStream = dstream;
	}

	
	
	
	public virtual void reInit(Provider dstream, int startline, int startcolumn, int buffersize)
	{
		inputStream = dstream;
		reInit(startline, startcolumn, buffersize);
	}

	
	
	
	
	protected internal override int streamRead(char[] aBuf, int nOfs, int nLen)
	{
		int result = inputStream.read(aBuf, nOfs, nLen);
		
		return result;
	}

	
	
	
	protected internal override void streamClose()
	{
		inputStream.close();
	}

	
	
	
	public SimpleCharStream(Provider dstream)
		: this(dstream, 1, 1, 4096)
	{
	}

	
	
	
	public virtual void reInit(Provider dstream)
	{
		reInit(dstream, 1, 1, 4096);
	}
}
