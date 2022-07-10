using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.cache;

public class NoCache: Cache
{
	
	
	public NoCache()
	{
	}

	
		
	public static NoCache create()
	{
		NoCache result = new NoCache();
		
		return result;
	}

		public virtual void put(object key, object value)
	{
	}

	
		
	public virtual Optional get(object key)
	{
		Optional result = Optional.empty();
		
		return result;
	}

		public virtual void remove(object key)
	{
	}

	public virtual void removeAll()
	{
	}

		public virtual bool contains(object key)
	{
		return false;
	}

	public virtual long size()
	{
		return 0L;
	}

	public virtual bool isEmpty()
	{
		return true;
	}
}
