using System;


using java.io;
using java.lang;
using java.nio.charset;

namespace com.github.javaparser;


public class StreamProvider :  Provider, Closeable, AutoCloseable
{
	private Reader m_aReader;

	
	
	
	public StreamProvider(Reader reader)
	{
		m_aReader = reader;
	}

	
	
	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public StreamProvider(InputStream stream, string charsetName)
		: this(new BufferedReader(new InputStreamReader(stream, charsetName)))
	{
	}

	
	
	
	public StreamProvider(InputStream stream, Charset charset)
		: this(new BufferedReader(new InputStreamReader(stream, charset)))
	{
	}

	
	
	
	
	public virtual int read(char[] aDest, int nOfs, int nLen)
	{
		int num = m_aReader.read(aDest, nOfs, nLen);
		if (num == 0 && nOfs < (nint)aDest.LongLength && nLen > 0)
		{
			num = -1;
		}
		return num;
	}

	
	
	
	public virtual void close()
	{
		if (m_aReader != null)
		{
			m_aReader.close();
		}
	}

	void IDisposable.AutoCloseable_003A_003Aclose()
	{
		close();
	}
}
