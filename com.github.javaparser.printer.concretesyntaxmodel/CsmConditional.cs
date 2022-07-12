using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmConditional :  CsmElement
{
	
	
		
	public class Condition : java.lang.Enum
	{
		
		
		public enum __Enum
		{
			IS_EMPTY,
			IS_NOT_EMPTY,
			IS_PRESENT,
			FLAG
		}

		
		internal static Condition ___003C_003EIS_EMPTY;

		
		internal static Condition ___003C_003EIS_NOT_EMPTY;

		
		internal static Condition ___003C_003EIS_PRESENT;

		
		internal static Condition ___003C_003EFLAG;

		
		private static Condition[] _0024VALUES;

		
		public static Condition IS_EMPTY
		{
			
			get
			{
				return ___003C_003EIS_EMPTY;
			}
		}

		
		public static Condition IS_NOT_EMPTY
		{
			
			get
			{
				return ___003C_003EIS_NOT_EMPTY;
			}
		}

		
		public static Condition IS_PRESENT
		{
			
			get
			{
				return ___003C_003EIS_PRESENT;
			}
		}

		
		public static Condition FLAG
		{
			
			get
			{
				return ___003C_003EFLAG;
			}
		}

		
		
		public static void ___003Cclinit_003E()
		{
		}

		
				
		
		private Condition(string _0024enum_0024name, int _0024enum_0024ordinal)
			: base(_0024enum_0024name, _0024enum_0024ordinal)
		{
			GC.KeepAlive(this);
		}

		
		
		public static Condition[] values()
		{
			return (Condition[])_0024VALUES.Clone();
		}

		
		
		
		public static Condition valueOf(string name)
		{
			return (Condition)java.lang.Enum.valueOf(ClassLiteral<Condition>.Value, name);
		}

		
		
		
		internal virtual bool evaluate(Node node, ObservableProperty property)
		{
			if (this == ___003C_003EIS_PRESENT)
			{
				return (!property.isNullOrNotPresent(node)) ? true : false;
			}
			if (this == ___003C_003EFLAG)
			{
				bool result = property.getValueAsBooleanAttribute(node).booleanValue();
				
				return result;
			}
			if (this == ___003C_003EIS_EMPTY)
			{
				NodeList valueAsMultipleReference = property.getValueAsMultipleReference(node);
				return (valueAsMultipleReference == null || valueAsMultipleReference.isEmpty()) ? true : false;
			}
			if (this == ___003C_003EIS_NOT_EMPTY)
			{
				NodeList valueAsMultipleReference = property.getValueAsMultipleReference(node);
				return (valueAsMultipleReference != null && !valueAsMultipleReference.isEmpty()) ? true : false;
			}
			string message = name();
			
			throw new UnsupportedOperationException(message);
		}

		
		static Condition()
		{
			___003C_003EIS_EMPTY = new Condition("IS_EMPTY", 0);
			___003C_003EIS_NOT_EMPTY = new Condition("IS_NOT_EMPTY", 1);
			___003C_003EIS_PRESENT = new Condition("IS_PRESENT", 2);
			___003C_003EFLAG = new Condition("FLAG", 3);
			_0024VALUES = new Condition[4] { ___003C_003EIS_EMPTY, ___003C_003EIS_NOT_EMPTY, ___003C_003EIS_PRESENT, ___003C_003EFLAG };
		}
	}

	
	private Condition condition;

	
		private List properties;

	
	private CsmElement thenElement;

	
	private CsmElement elseElement;

	
	
	
	public CsmConditional(ObservableProperty property, Condition condition, CsmElement thenElement)
		: this(property, condition, thenElement, new CsmNone())
	{
	}

	
	
	
	public CsmConditional(ObservableProperty property, Condition condition, CsmElement thenElement, CsmElement elseElement)
	{
		properties = Arrays.asList(property);
		this.condition = condition;
		this.thenElement = thenElement;
		this.elseElement = elseElement;
	}

	
		
	
	public CsmConditional(List properties, Condition condition, CsmElement thenElement, CsmElement elseElement)
	{
		if (properties.size() < 1)
		{
			
			throw new IllegalArgumentException();
		}
		this.properties = properties;
		this.condition = condition;
		this.thenElement = thenElement;
		this.elseElement = elseElement;
	}

	public virtual Condition getCondition()
	{
		return condition;
	}

	
	
	public virtual ObservableProperty getProperty()
	{
		if (properties.size() > 1)
		{
			
			throw new IllegalStateException();
		}
		return (ObservableProperty)properties.get(0);
	}

		public virtual List getProperties()
	{
		return properties;
	}

	public virtual CsmElement getThenElement()
	{
		return thenElement;
	}

	public virtual CsmElement getElseElement()
	{
		return elseElement;
	}

	
	
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		int num = 0;
		Iterator iterator = properties.iterator();
		while (iterator.hasNext())
		{
			ObservableProperty property = (ObservableProperty)iterator.next();
			num = ((num != 0 || condition.evaluate(node, property)) ? 1 : 0);
		}
		if (num != 0)
		{
			thenElement.prettyPrint(node, printer);
		}
		else
		{
			elseElement.prettyPrint(node, printer);
		}
	}
}
