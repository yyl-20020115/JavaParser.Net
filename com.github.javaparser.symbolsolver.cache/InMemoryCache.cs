using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.cache;

public class InMemoryCache: Cache
{
	
		private Map mappedValues;

	
	
	public InMemoryCache()
	{
		mappedValues = new WeakHashMap();
	}

	
		
	public static InMemoryCache create()
	{
		InMemoryCache result = new InMemoryCache();
		
		return result;
	}

	
		
	public virtual void put(object key, object value)
	{
		mappedValues.put(key, value);
	}

	
		
	public virtual Optional get(object key)
	{
		Optional result = Optional.ofNullable(mappedValues.get(key));
		
		return result;
	}

	
		
	public virtual void remove(object key)
	{
		mappedValues.remove(key);
	}

	
	
	public virtual void removeAll()
	{
		mappedValues.clear();
	}

	
		
	public virtual bool contains(object key)
	{
		bool result = mappedValues.containsKey(key);
		
		return result;
	}

	
	
	public virtual long size()
	{
		return mappedValues.size();
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = mappedValues.isEmpty();
		
		return result;
	}
}
