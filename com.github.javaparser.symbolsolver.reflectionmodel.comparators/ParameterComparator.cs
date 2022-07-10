using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.reflectionmodel.comparators;

public class ParameterComparator: Comparator
{
	
	
	public ParameterComparator()
	{
	}

	
	
	public virtual int compare(Parameter o1, Parameter o2)
	{
		int num = String.instancehelper_compareTo(o1.getName(), o2.getName());
		if (num != 0)
		{
			return num;
		}
		int num2 = new ClassComparator().compare(o1.getType(), o2.getType());
		if (num2 != 0)
		{
			return num2;
		}
		return 0;
	}

	
	
	
	
	public virtual int compare(object obj1, object obj2)
	{
		int result = compare((Parameter)obj1, (Parameter)obj2);
		
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
