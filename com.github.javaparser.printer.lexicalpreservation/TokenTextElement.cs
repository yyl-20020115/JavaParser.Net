
using com.github.javaparser.ast;

using java.lang;
using java.util;

namespace com.github.javaparser.printer.lexicalpreservation;

internal class TokenTextElement : TextElement
{
	
	private JavaToken token;

	
	
	
	internal TokenTextElement(int tokenKind, string text)
		: this(new JavaToken(tokenKind, text))
	{
	}

	
	
	
	internal TokenTextElement(int tokenKind)
		: this(new JavaToken(tokenKind))
	{
	}

	
	
	internal virtual int getTokenKind()
	{
		int kind = token.getKind();
		
		return kind;
	}

	public virtual JavaToken getToken()
	{
		return token;
	}

	
	
	public override bool isNewline()
	{
		bool result = token.getCategory().isEndOfLine();
		
		return result;
	}

	
	
	public override bool isSpaceOrTab()
	{
		bool result = token.getCategory().isWhitespaceButNotEndOfLine();
		
		return result;
	}

	
	
	public override bool isSeparator()
	{
		bool result = token.getCategory().isSeparator();
		
		return result;
	}

	
	
	
	internal TokenTextElement(JavaToken token)
	{
		this.token = token;
	}

	
	
	internal virtual string getText()
	{
		string text = token.getText();
		
		return text;
	}

	
	
	internal override string expand()
	{
		string text = token.getText();
		
		return text;
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
		TokenTextElement tokenTextElement = (TokenTextElement)o;
		bool result = token.equals(tokenTextElement.token);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = token.GetHashCode();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = token.ToString();
		
		return result;
	}

	
	
	
	internal override bool isToken(int tokenKind)
	{
		return token.getKind() == tokenKind;
	}

	
	internal override bool isNode(Node node)
	{
		return false;
	}

	
	
	public override bool isWhiteSpace()
	{
		bool result = token.getCategory().isWhitespace();
		
		return result;
	}

	
	
	public override bool isComment()
	{
		bool result = token.getCategory().isComment();
		
		return result;
	}

		
	public override bool isChildOfClass(Class nodeClass)
	{
		return false;
	}

	
	
	public override bool isIdentifier()
	{
		bool result = getToken().getCategory().isIdentifier();
		
		return result;
	}

	
	
	public override bool isKeyword()
	{
		bool result = getToken().getCategory().isKeyword();
		
		return result;
	}

	
	
	public override bool isLiteral()
	{
		bool result = getToken().getCategory().isLiteral();
		
		return result;
	}

	
	
	public override bool isPrimitive()
	{
		bool result = JavaToken.Kind.valueOf(getTokenKind()).isPrimitive();
		
		return result;
	}

	
		
	internal override Optional getRange()
	{
		Optional range = token.getRange();
		
		return range;
	}
}
