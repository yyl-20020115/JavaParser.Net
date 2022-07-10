using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmToken: CsmElement
{
	public interface TokenContentCalculator
	{
		
		virtual string calculate(Node node);
	}

	
	private int tokenType;

	private string content;

	private TokenContentCalculator tokenContentCalculator;

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public CsmToken(int tokenType, string content)
	{
		this.tokenType = tokenType;
		this.content = content;
	}

	
	
	[LineNumberTable(new byte[]
	{
		3,
		104,
		103,
		109,
		114,
		byte.MaxValue,
		0,
		69,
		136,
		127,
		3,
		104,
		139
	})]
	public CsmToken(int tokenType)
	{
		this.tokenType = tokenType;
		content = GeneratedJavaParserConstants.tokenImage[tokenType];
		if (String.instancehelper_startsWith(content, "\""))
		{
			content = String.instancehelper_substring(content, 1, String.instancehelper_length(content) - 1);
		}
		if (TokenTypes.isEndOfLineToken(tokenType))
		{
			content = ((LineSeparator)LineSeparator.lookupEscaped(content).get()).asRawString();
		}
		else if (TokenTypes.isWhitespaceButNotEndOfLine(tokenType))
		{
			content = " ";
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public CsmToken(int tokenType, TokenContentCalculator tokenContentCalculator)
	{
		this.tokenType = tokenType;
		this.tokenContentCalculator = tokenContentCalculator;
	}

	
	
	
	public virtual string getContent(Node node)
	{
		if (tokenContentCalculator != null)
		{
			string result = tokenContentCalculator.calculate(node);
			
			return result;
		}
		return content;
	}

	public virtual int getTokenType()
	{
		return tokenType;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		if (TokenTypes.isEndOfLineToken(tokenType))
		{
			printer.println();
		}
		else
		{
			printer.print(getContent(node));
		}
	}

	
	
	public override string ToString()
	{
		string result = String.format("%s(property:%s)", Object.instancehelper_getClass(this).getSimpleName(), content);
		
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
		CsmToken csmToken = (CsmToken)o;
		if (tokenType != csmToken.tokenType)
		{
			return false;
		}
		if (content != null)
		{
			if (!String.instancehelper_equals(content, csmToken.content))
			{
				goto IL_0055;
			}
		}
		else if (csmToken.content != null)
		{
			goto IL_0055;
		}
		return (tokenContentCalculator != null) ? Object.instancehelper_equals(tokenContentCalculator, csmToken.tokenContentCalculator) : (csmToken.tokenContentCalculator == null);
		IL_0055:
		return false;
	}

	
	
	public override int GetHashCode()
	{
		int num = tokenType;
		num = 31 * num + ((content != null) ? String.instancehelper_hashCode(content) : 0);
		return 31 * num + ((tokenContentCalculator != null) ? Object.instancehelper_hashCode(tokenContentCalculator) : 0);
	}

	
	
	public virtual bool isWhiteSpace()
	{
		bool result = TokenTypes.isWhitespace(tokenType);
		
		return result;
	}

	
	
	public virtual bool isNewLine()
	{
		bool result = TokenTypes.isEndOfLineToken(tokenType);
		
		return result;
	}
}
