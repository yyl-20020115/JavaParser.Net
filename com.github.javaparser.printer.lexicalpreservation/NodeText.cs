using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.printer.lexicalpreservation;

internal class NodeText
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly StringBuffer arg_00241;

		internal ___003C_003EAnon0(StringBuffer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024expand_00240(arg_00241, (TextElement)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
		private List elements;

	public const int NOT_FOUND = -1;

		internal virtual List getElements()
	{
		return elements;
	}

	
	
	
	internal virtual void removeElement(int index)
	{
		elements.remove(index);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual void addElement(int index, TextElement nodeTextElement)
	{
		elements.add(index, nodeTextElement);
	}

	
	
	
	internal virtual TextElement getTextElement(int index)
	{
		return (TextElement)elements.get(index);
	}

	
	
	internal virtual int numberOfElements()
	{
		int result = elements.size();
		
		return result;
	}

	
		
	
	internal NodeText(List elements)
	{
		this.elements = elements;
	}

	
	
	
	internal virtual int tryToFindChild(Node child)
	{
		int result = tryToFindChild(child, 0);
		
		return result;
	}

	
	
	internal virtual string expand()
	{
		StringBuffer stringBuffer = new StringBuffer();
		elements.forEach(new ___003C_003EAnon0(stringBuffer));
		string result = stringBuffer.ToString();
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual void addToken(int tokenKind, string text)
	{
		elements.add(new TokenTextElement(tokenKind, text));
	}

	
	
	
	internal virtual void addChild(Node child)
	{
		addElement(new ChildTextElement(child));
	}

	
	
	internal NodeText()
		: this(new LinkedList())
	{
	}

	
	
	
	internal virtual void addElement(TextElement nodeTextElement)
	{
		elements.add(nodeTextElement);
	}

	
	
	
	internal virtual int findChild(Node child)
	{
		int result = findChild(child, 0);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual void addToken(int index, int tokenKind, string text)
	{
		elements.add(index, new TokenTextElement(tokenKind, text));
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual void replace(TextElementMatcher position, TextElement newElement)
	{
		int index = findElement(position, 0);
		elements.remove(index);
		elements.add(index, newElement);
	}

	
	
	
	internal virtual int findElement(TextElementMatcher matcher)
	{
		int result = findElement(matcher, 0);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual int findElement(TextElementMatcher matcher, int from)
	{
		int num = tryToFindElement(matcher, from);
		if (num == -1)
		{
			string s = String.format("I could not find child '%s' from position %d. Elements: %s", matcher, Integer.valueOf(from), elements);
			
			throw new IllegalArgumentException(s);
		}
		return num;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual int tryToFindElement(TextElementMatcher matcher, int from)
	{
		for (int i = from; i < elements.size(); i++)
		{
			TextElement textElement = (TextElement)elements.get(i);
			if (matcher.match(textElement))
			{
				return i;
			}
		}
		return -1;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual int findChild(Node child, int from)
	{
		int result = findElement(TextElementMatchers.byNode(child), from);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual int tryToFindChild(Node child, int from)
	{
		int result = tryToFindElement(TextElementMatchers.byNode(child), from);
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024expand_00240(StringBuffer sb, TextElement e)
	{
		sb.append(e.expand());
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	internal virtual void addChild(int index, Node child)
	{
		addElement(index, new ChildTextElement(child));
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159, 109, 162, 98, 127, 4, 105, 109, 99, 110,
		120, 175, 171, 129, 101
	})]
	public virtual void remove(TextElementMatcher matcher, bool potentiallyFollowingWhitespace)
	{
		int num = 0;
		Iterator iterator = elements.iterator();
		while (iterator.hasNext())
		{
			TextElement textElement = (TextElement)iterator.next();
			if (!matcher.match(textElement))
			{
				continue;
			}
			elements.remove(textElement);
			if (potentiallyFollowingWhitespace)
			{
				if (num >= elements.size())
				{
					
					throw new UnsupportedOperationException();
				}
				if (((TextElement)elements.get(num)).isWhiteSpace())
				{
					elements.remove(num);
				}
			}
			return;
		}
		
		throw new IllegalArgumentException();
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("NodeText{").append(elements).append('}')
			.ToString();
		
		return result;
	}
}
