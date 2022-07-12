

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.utils;

public class ClassUtils
{
	
		private static Map primitiveWrapperMap;

	
		private static Map wrapperPrimitiveMap;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		
	
	public static bool isPrimitiveOrWrapper(Class type)
	{
		if (type == null)
		{
			return false;
		}
		return (type.isPrimitive() || isPrimitiveWrapper(type)) ? true : false;
	}

	
		
	
	public static bool isPrimitiveWrapper(Class type)
	{
		bool result = wrapperPrimitiveMap.containsKey(type);
		
		return result;
	}

	
	
	public ClassUtils()
	{
	}

	
	static ClassUtils()
	{
		primitiveWrapperMap = new HashMap();
		primitiveWrapperMap.put(Boolean.TYPE, ClassLiteral<Boolean>.Value);
		primitiveWrapperMap.put(Byte.TYPE, ClassLiteral<Byte>.Value);
		primitiveWrapperMap.put(Character.TYPE, ClassLiteral<Character>.Value);
		primitiveWrapperMap.put(Short.TYPE, ClassLiteral<Short>.Value);
		primitiveWrapperMap.put(Integer.TYPE, ClassLiteral<Integer>.Value);
		primitiveWrapperMap.put(Long.TYPE, ClassLiteral<Long>.Value);
		primitiveWrapperMap.put(Double.TYPE, ClassLiteral<Double>.Value);
		primitiveWrapperMap.put(Float.TYPE, ClassLiteral<Float>.Value);
		primitiveWrapperMap.put(Void.TYPE, Void.TYPE);
		wrapperPrimitiveMap = new HashMap();
		Iterator iterator = primitiveWrapperMap.keySet().iterator();
		while (iterator.hasNext())
		{
			Class @class = (Class)iterator.next();
			Class class2 = (Class)primitiveWrapperMap.get(@class);
			if (!Object.instancehelper_equals(@class, class2))
			{
				wrapperPrimitiveMap.put(class2, @class);
			}
		}
	}
}
