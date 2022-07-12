using System.ComponentModel;


using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.reflectionmodel.comparators;

public class MethodComparator: Comparator
{
	
	
	public virtual int compare(Method o1, Method o2)
	{
		int num = String.instancehelper_compareTo(o1.getName(), o2.getName());
		if (num != 0)
		{
			return num;
		}
		int num2 = o1.getParameterCount() - o2.getParameterCount();
		if (num2 != 0)
		{
			return num2;
		}
		int i;
		for (i = 0; i < o1.getParameterCount(); i++)
		{
			int num3 = new ParameterComparator().compare(o1.getParameters()[i], o2.getParameters()[i]);
			if (num3 != 0)
			{
				return num3;
			}
		}
		i = new ClassComparator().compare(o1.getReturnType(), o2.getReturnType());
		if (i != 0)
		{
			return i;
		}
		return 0;
	}

	
	
	public MethodComparator()
	{
	}

	
	
	
	
	public virtual int compare(object obj1, object obj2)
	{
		int result = compare((Method)obj1, (Method)obj2);
		
		return result;
	}


	public virtual Comparator thenComparing(Comparator P_0)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0);
	}


	public virtual Comparator reversed()
	{
		return Comparator._003Cdefault_003Ereversed(this);
	}


	public virtual Comparator thenComparing(Function P_0, Comparator P_1)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
	}


	public virtual Comparator thenComparing(Function P_0)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0);
	}


	public virtual Comparator thenComparingInt(ToIntFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
	}


	public virtual Comparator thenComparingLong(ToLongFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
	}


	public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
	}

	bool Comparator.Comparator_003A_003Aequals(object P_0)
	{
		return Object.instancehelper_equals(this, P_0);
	}
}
