
using com.google.common.cache;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.cache;

public class GuavaCache: Cache
{
	
		private com.google.common.cache.Cache guavaCache;

	
		
	public GuavaCache(com.google.common.cache.Cache guavaCache)
	{
		this.guavaCache = (com.google.common.cache.Cache)Objects.requireNonNull(guavaCache, "The argument GuavaCache can't be null.");
	}

	
		
	public virtual Optional get(object key)
	{
		Optional result = Optional.ofNullable(guavaCache.getIfPresent(key));
		
		return result;
	}

	
	
	public virtual long size()
	{
		long result = guavaCache.size();
		
		return result;
	}

	
		
	public static GuavaCache create(com.google.common.cache.Cache guavaCache)
	{
		GuavaCache result = new GuavaCache(guavaCache);
		
		return result;
	}

	
		
	public virtual void put(object key, object value)
	{
		guavaCache.put(key, value);
	}

	
		
	public virtual void remove(object key)
	{
		guavaCache.invalidate(key);
	}

	
	
	public virtual void removeAll()
	{
		guavaCache.invalidateAll();
	}

	
		
	public virtual bool contains(object key)
	{
		bool result = get(key).isPresent();
		
		return result;
	}

	
	
	public virtual bool isEmpty()
	{
		return size() == 0;
	}
}
