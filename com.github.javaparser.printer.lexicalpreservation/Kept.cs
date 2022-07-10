using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using com.github.javaparser.printer.concretesyntaxmodel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.printer.lexicalpreservation;

public class Kept: DifferenceElement
{
	
	private CsmElement element;

	
	
	
	internal Kept(CsmElement element)
	{
		this.element = element;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isChild()
	{
		return DifferenceElement._003Cdefault_003EisChild(this);
	}

	public virtual CsmElement getElement()
	{
		return element;
	}

	
	
	public virtual bool isPrimitiveType()
	{
		if (isChild())
		{
			LexicalDifferenceCalculator.CsmChild csmChild = (LexicalDifferenceCalculator.CsmChild)element;
			return csmChild.getChild() is PrimitiveType;
		}
		return false;
	}

	
	public virtual bool isToken()
	{
		return element is CsmToken;
	}

	
	
	public virtual int getTokenType()
	{
		if (isToken())
		{
			CsmToken csmToken = (CsmToken)element;
			int tokenType = csmToken.getTokenType();
			
			return tokenType;
		}
		string s = new StringBuilder().append("Kept is not a ").append(ClassLiteral<CsmToken>.Value.getSimpleName()).ToString();
		
		throw new IllegalStateException(s);
	}

	
	
	public virtual bool isNewLine()
	{
		if (isToken())
		{
			CsmToken csmToken = (CsmToken)element;
			bool result = csmToken.isNewLine();
			
			return result;
		}
		return false;
	}

	
	
	public virtual bool isWhiteSpaceOrComment()
	{
		if (isToken())
		{
			CsmToken csmToken = (CsmToken)element;
			bool result = TokenTypes.isWhitespaceOrComment(csmToken.getTokenType());
			
			return result;
		}
		return false;
	}

	
	
	public virtual bool isWhiteSpace()
	{
		if (isToken())
		{
			CsmToken csmToken = (CsmToken)element;
			bool result = csmToken.isWhiteSpace();
			
			return result;
		}
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

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("Kept{").append(element).append('}')
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
		Kept kept = (Kept)o;
		bool result = Object.instancehelper_equals(element, kept.element);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = Object.instancehelper_hashCode(element);
		
		return result;
	}

	public virtual bool isAdded()
	{
		return false;
	}

	public virtual bool isRemoved()
	{
		return false;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual DifferenceElement replaceEolTokens(CsmElement P_0)
	{
		return DifferenceElement._003Cdefault_003EreplaceEolTokens(this, P_0);
	}
}
