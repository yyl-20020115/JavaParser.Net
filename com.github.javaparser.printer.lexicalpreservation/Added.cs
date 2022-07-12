
using com.github.javaparser.printer.concretesyntaxmodel;

using java.lang;

namespace com.github.javaparser.printer.lexicalpreservation;

public class Added : DifferenceElement
{
	
	private CsmElement element;

	
	
	
	internal Added(CsmElement element)
	{
		this.element = element;
	}

	
	
	private bool isNewLineToken()
	{
		return (isToken() && ((CsmToken)element).isNewLine()) ? true : false;
	}

	
	private bool isToken()
	{
		return element is CsmToken;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("Added{").append(element).append('}')
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
		Added added = (Added)o;
		bool result = Object.instancehelper_equals(element, added.element);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = Object.instancehelper_hashCode(element);
		
		return result;
	}

	public virtual CsmElement getElement()
	{
		return element;
	}

	public virtual bool isAdded()
	{
		return true;
	}

	public virtual bool isRemoved()
	{
		return false;
	}

	
	public virtual bool isIndent()
	{
		return element is CsmIndent;
	}

	
	public virtual bool isUnindent()
	{
		return element is CsmUnindent;
	}

	
	
	public virtual TextElement toTextElement()
	{
		if (element is LexicalDifferenceCalculator.CsmChild)
		{
			ChildTextElement result = new ChildTextElement(((LexicalDifferenceCalculator.CsmChild)element).getChild());
			
			return result;
		}
		if (element is CsmToken)
		{
			TokenTextElement result2 = new TokenTextElement(((CsmToken)element).getTokenType(), ((CsmToken)element).getContent(null));
			
			return result2;
		}
		string simpleName = Object.instancehelper_getClass(element).getSimpleName();
		
		throw new UnsupportedOperationException(simpleName);
	}

	
	
	
	public virtual DifferenceElement replaceEolTokens(CsmElement lineSeparator)
	{
		return (!isNewLineToken()) ? this : new Added(lineSeparator);
	}


	public virtual bool isChild()
	{
		return DifferenceElement._003Cdefault_003EisChild(this);
	}
}
