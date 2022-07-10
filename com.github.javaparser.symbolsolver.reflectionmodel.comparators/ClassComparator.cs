using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.reflectionmodel.comparators;

public class ClassComparator : Comparator
{
	
		[LineNumberTable(new byte[]
	{
		159, 176, 114, 101, 114, 101, 114, 101, 114, 101,
		114, 101
	})]
	public virtual int compare(Class o1, Class o2)
	{
		int num = String.instancehelper_compareTo(o1.getCanonicalName(), o2.getCanonicalName());
		if (num != 0)
		{
			return num;
		}
		num = Boolean.compare(o1.isAnnotation(), o2.isAnnotation());
		if (num != 0)
		{
			return num;
		}
		num = Boolean.compare(o1.isArray(), o2.isArray());
		if (num != 0)
		{
			return num;
		}
		num = Boolean.compare(o1.isEnum(), o2.isEnum());
		if (num != 0)
		{
			return num;
		}
		num = Boolean.compare(o1.isInterface(), o2.isInterface());
		if (num != 0)
		{
			return num;
		}
		return 0;
	}

	
	
	public ClassComparator()
	{
	}

	
	
	
	
	public virtual int compare(object obj1, object obj2)
	{
		int result = compare((Class)obj1, (Class)obj2);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparing(Comparator P_0)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator reversed()
	{
		return Comparator._003Cdefault_003Ereversed(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparing(Function P_0, Comparator P_1)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparing(Function P_0)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparingInt(ToIntFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparingLong(ToLongFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
	}

	bool Comparator.Comparator_003A_003Aequals(object P_0)
	{
		return Object.instancehelper_equals(this, P_0);
	}
}
