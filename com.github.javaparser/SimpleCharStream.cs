using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser;

public class SimpleCharStream : AbstractCharStream
{
	private Provider inputStream;

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public SimpleCharStream(Provider dstream, int startline, int startcolumn)
		: this(dstream, startline, startcolumn, 4096)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void reInit(Provider dstream, int startline, int startcolumn)
	{
		reInit(dstream, startline, startcolumn, 4096);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public SimpleCharStream(Provider dstream, int startline, int startcolumn, int buffersize)
		: base(startline, startcolumn, buffersize)
	{
		inputStream = dstream;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void reInit(Provider dstream, int startline, int startcolumn, int buffersize)
	{
		inputStream = dstream;
		reInit(startline, startcolumn, buffersize);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		Modifiers.Final
	})]
	
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
