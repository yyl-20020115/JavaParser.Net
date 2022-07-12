using System.ComponentModel;


using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.printer.lexicalpreservation;

public class WrappingRangeIterator: Iterator
{
	
	private int limit;

	private int currentValue;

	
	
	
	public WrappingRangeIterator(int limit)
	{
		currentValue = 0;
		this.limit = limit;
	}

	
	
	public virtual Integer next()
	{
		int i = currentValue;
		currentValue++;
		if (currentValue == limit)
		{
			currentValue = 0;
		}
		Integer result = Integer.valueOf(i);
		
		return result;
	}

	public virtual bool hasNext()
	{
		return true;
	}

	
	
	
	
	public virtual object _003Cbridge_003Enext()
	{
		Integer result = next();
		
		return result;
	}


	public virtual void remove()
	{
		Iterator._003Cdefault_003Eremove(this);
	}


	public virtual void forEachRemaining(Consumer P_0)
	{
		Iterator._003Cdefault_003EforEachRemaining(this, P_0);
	}

	object Iterator.Iterator_003A_003Anext()
	{
		return _003Cbridge_003Enext();
	}
}
