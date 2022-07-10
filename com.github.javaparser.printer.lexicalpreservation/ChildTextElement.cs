using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.comments;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.printer.lexicalpreservation;

internal class ChildTextElement : TextElement
{
	
	private Node child;

	
	
	
	internal ChildTextElement(Node child)
	{
		this.child = child;
	}

	
	
	internal override string expand()
	{
		string result = LexicalPreservingPrinter.print(child);
		
		return result;
	}

	internal virtual Node getChild()
	{
		return child;
	}

	
	internal override bool isToken(int tokenKind)
	{
		return false;
	}

	
	internal override bool isNode(Node node)
	{
		return node == child;
	}

	
	
	internal virtual NodeText getNodeTextForWrappedNode()
	{
		NodeText orCreateNodeText = LexicalPreservingPrinter.getOrCreateNodeText(child);
		
		return orCreateNodeText;
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
		ChildTextElement childTextElement = (ChildTextElement)o;
		bool result = child.equals(childTextElement.child);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = child.GetHashCode();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("ChildTextElement{").append(child).append('}')
			.ToString();
		
		return result;
	}

	public override bool isWhiteSpace()
	{
		return false;
	}

	public override bool isSpaceOrTab()
	{
		return false;
	}

	public override bool isNewline()
	{
		return false;
	}

	
	public override bool isComment()
	{
		return child is Comment;
	}

	public override bool isSeparator()
	{
		return false;
	}

	public override bool isIdentifier()
	{
		return false;
	}

	public override bool isKeyword()
	{
		return false;
	}

	public override bool isPrimitive()
	{
		return false;
	}

	public override bool isLiteral()
	{
		return false;
	}

	
		
	
	public override bool isChildOfClass(Class nodeClass)
	{
		bool result = nodeClass.isInstance(child);
		
		return result;
	}

	
		
	internal override Optional getRange()
	{
		Optional range = child.getRange();
		
		return range;
	}
}
