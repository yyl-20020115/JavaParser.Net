using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.ast;

public abstract class DataKey
{
	
	
	public DataKey()
	{
	}

	
	
	public override int GetHashCode()
	{
		int result = Object.instancehelper_hashCode(Object.instancehelper_getClass(this));
		
		return result;
	}

	
	
	
	public override bool Equals(object obj)
	{
		return (obj != null && Object.instancehelper_equals(Object.instancehelper_getClass(this), Object.instancehelper_getClass(obj))) ? true : false;
	}
}
