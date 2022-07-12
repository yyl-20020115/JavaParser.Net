using System.ComponentModel;

using com.github.javaparser.printer.concretesyntaxmodel;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.printer.lexicalpreservation;

public class Reshuffled: DifferenceElement
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly Reshuffled arg_00241;

		private readonly CsmElement arg_00242;

		internal ___003C_003EAnon0(Reshuffled P_0, CsmElement P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			CsmElement result = arg_00241.lambda_0024replaceTokens_00240(arg_00242, (CsmElement)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private CsmMix previousOrder;

	
	private CsmMix nextOrder;

	public virtual CsmMix getPreviousOrder()
	{
		return previousOrder;
	}

	public virtual CsmMix getNextOrder()
	{
		return nextOrder;
	}

	
	
	
	internal Reshuffled(CsmMix previousOrder, CsmMix nextOrder)
	{
		this.previousOrder = previousOrder;
		this.nextOrder = nextOrder;
	}

	
		
	
	private List replaceTokens(List elements, CsmElement lineSeparator)
	{
		return (List)elements.stream().map(new ___003C_003EAnon0(this, lineSeparator)).collect(Collectors.toList());
	}

	
	
	private bool isToken(CsmElement element)
	{
		return element is CsmToken;
	}

	public virtual CsmMix getElement()
	{
		return nextOrder;
	}

	
	
	
	private bool isNewLineToken(CsmElement element)
	{
		return (isToken(element) && ((CsmToken)element).isNewLine()) ? true : false;
	}

	
	
	
	
	private CsmElement lambda_0024replaceTokens_00240(CsmElement lineSeparator, CsmElement element)
	{
		return (!isNewLineToken(element)) ? element : lineSeparator;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("Reshuffled{").append(nextOrder).append(", previous=")
			.append(previousOrder)
			.append('}')
			.ToString();
		
		return result;
	}

	
	
	
	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || ((object)this).GetType() != o.GetType())
		{
			return false;
		}
		Reshuffled reshuffled = (Reshuffled)o;
		if (!previousOrder.equals(reshuffled.previousOrder))
		{
			return false;
		}
		bool result = nextOrder.equals(reshuffled.nextOrder);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int num = previousOrder.GetHashCode();
		return 31 * num + nextOrder.GetHashCode();
	}

	public virtual bool isAdded()
	{
		return false;
	}

	public virtual bool isRemoved()
	{
		return false;
	}

	
	
	
	public virtual DifferenceElement replaceEolTokens(CsmElement lineSeparator)
	{
		CsmMix csmMix = new CsmMix(replaceTokens(nextOrder.getElements(), lineSeparator));
		CsmMix csmMix2 = new CsmMix(replaceTokens(previousOrder.getElements(), lineSeparator));
		Reshuffled result = new Reshuffled(csmMix2, csmMix);
		
		return result;
	}

	
	
	
	
	public virtual CsmElement _003Cbridge_003EgetElement()
	{
		CsmMix element = getElement();
		
		return element;
	}


	public virtual bool isChild()
	{
		return DifferenceElement._003Cdefault_003EisChild(this);
	}

	CsmElement DifferenceElement.DifferenceElement_003A_003AgetElement()
	{
		return _003Cbridge_003EgetElement();
	}
}
