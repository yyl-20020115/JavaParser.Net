using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmElement
{
	
	public static class __Methods
	{
		public static CsmElement child(ObservableProperty P_0)
		{
			return CsmElement.child(P_0);
		}

		public static CsmElement attribute(ObservableProperty P_0)
		{
			return CsmElement.attribute(P_0);
		}

		public static CsmElement sequence(CsmElement[] P_0)
		{
			return CsmElement.sequence(P_0);
		}

		public static CsmElement @string(int P_0, string P_1)
		{
			return CsmElement.@string(P_0, P_1);
		}

		public static CsmElement @string(int P_0)
		{
			return CsmElement.@string(P_0);
		}

		public static CsmElement stringToken(ObservableProperty P_0)
		{
			return CsmElement.stringToken(P_0);
		}

		public static CsmElement textBlockToken(ObservableProperty P_0)
		{
			return CsmElement.textBlockToken(P_0);
		}

		public static CsmElement charToken(ObservableProperty P_0)
		{
			return CsmElement.charToken(P_0);
		}

		public static CsmElement token(int P_0)
		{
			return CsmElement.token(P_0);
		}

		public static CsmElement token(int P_0, CsmToken.TokenContentCalculator P_1)
		{
			return CsmElement.token(P_0, P_1);
		}

		public static CsmElement conditional(ObservableProperty P_0, CsmConditional.Condition P_1, CsmElement P_2)
		{
			return CsmElement.conditional(P_0, P_1, P_2);
		}

		public static CsmElement conditional(ObservableProperty P_0, CsmConditional.Condition P_1, CsmElement P_2, CsmElement P_3)
		{
			return CsmElement.conditional(P_0, P_1, P_2, P_3);
		}

		public static CsmElement conditional(List P_0, CsmConditional.Condition P_1, CsmElement P_2, CsmElement P_3)
		{
			return CsmElement.conditional(P_0, P_1, P_2, P_3);
		}

		public static CsmElement space()
		{
			return CsmElement.space();
		}

		public static CsmElement semicolon()
		{
			return CsmElement.semicolon();
		}

		public static CsmElement comment()
		{
			return CsmElement.comment();
		}

		public static CsmElement newline()
		{
			return CsmElement.newline();
		}

		public static CsmElement newline(LineSeparator P_0)
		{
			return CsmElement.newline(P_0);
		}

		public static CsmElement none()
		{
			return CsmElement.none();
		}

		public static CsmElement comma()
		{
			return CsmElement.comma();
		}

		public static CsmElement list(ObservableProperty P_0)
		{
			return CsmElement.list(P_0);
		}

		public static CsmElement list(ObservableProperty P_0, CsmElement P_1)
		{
			return CsmElement.list(P_0, P_1);
		}

		public static CsmElement list(ObservableProperty P_0, CsmElement P_1, CsmElement P_2, CsmElement P_3)
		{
			return CsmElement.list(P_0, P_1, P_2, P_3);
		}

		public static CsmElement list(ObservableProperty P_0, CsmElement P_1, CsmElement P_2, CsmElement P_3, CsmElement P_4)
		{
			return CsmElement.list(P_0, P_1, P_2, P_3, P_4);
		}

		public static CsmElement orphanCommentsEnding()
		{
			return CsmElement.orphanCommentsEnding();
		}

		public static CsmElement orphanCommentsBeforeThis()
		{
			return CsmElement.orphanCommentsBeforeThis();
		}

		public static CsmElement indent()
		{
			return CsmElement.indent();
		}

		public static CsmElement unindent()
		{
			return CsmElement.unindent();
		}

		public static CsmElement block(CsmElement P_0)
		{
			return CsmElement.block(P_0);
		}
	}

	
	
	
	static CsmElement newline(LineSeparator lineSeparator)
	{
		CsmToken result = new CsmToken(TokenTypes.eolTokenKind(lineSeparator), lineSeparator.asRawString());
		
		return result;
	}

	
	
	static CsmElement none()
	{
		CsmNone result = new CsmNone();
		
		return result;
	}

	
	
	
	static CsmElement token(int tokenType)
	{
		CsmToken result = new CsmToken(tokenType);
		
		return result;
	}

	
	
	static CsmElement indent()
	{
		CsmIndent result = new CsmIndent();
		
		return result;
	}

	
	
	static CsmElement unindent()
	{
		CsmUnindent result = new CsmUnindent();
		
		return result;
	}

	
	
	
	static CsmElement sequence(params CsmElement[] elements)
	{
		CsmSequence result = new CsmSequence(Arrays.asList(elements));
		
		return result;
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual void prettyPrint(Node node, SourcePrinter printer);

	
	
	
	static CsmElement child(ObservableProperty property)
	{
		CsmSingleReference result = new CsmSingleReference(property);
		
		return result;
	}

	
	
	
	static CsmElement attribute(ObservableProperty property)
	{
		CsmAttribute result = new CsmAttribute(property);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	static CsmElement @string(int tokenType, string content)
	{
		CsmToken result = new CsmToken(tokenType, content);
		
		return result;
	}

	
	
	
	static CsmElement @string(int tokenType)
	{
		CsmToken result = new CsmToken(tokenType);
		
		return result;
	}

	
	
	
	static CsmElement stringToken(ObservableProperty property)
	{
		CsmString result = new CsmString(property);
		
		return result;
	}

	
	
	
	static CsmElement textBlockToken(ObservableProperty property)
	{
		CsmString result = new CsmString(property);
		
		return result;
	}

	
	
	
	static CsmElement charToken(ObservableProperty property)
	{
		CsmChar result = new CsmChar(property);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	static CsmElement token(int tokenType, CsmToken.TokenContentCalculator tokenContentCalculator)
	{
		CsmToken result = new CsmToken(tokenType, tokenContentCalculator);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	static CsmElement conditional(ObservableProperty property, CsmConditional.Condition condition, CsmElement thenElement)
	{
		CsmConditional result = new CsmConditional(property, condition, thenElement);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	static CsmElement conditional(ObservableProperty property, CsmConditional.Condition condition, CsmElement thenElement, CsmElement elseElement)
	{
		CsmConditional result = new CsmConditional(property, condition, thenElement, elseElement);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	static CsmElement conditional(List properties, CsmConditional.Condition condition, CsmElement thenElement, CsmElement elseElement)
	{
		CsmConditional result = new CsmConditional(properties, condition, thenElement, elseElement);
		
		return result;
	}

	
	
	static CsmElement space()
	{
		CsmToken result = new CsmToken(TokenTypes.spaceTokenKind(), " ");
		
		return result;
	}

	
	
	static CsmElement semicolon()
	{
		CsmToken result = new CsmToken(103);
		
		return result;
	}

	
	
	static CsmElement comment()
	{
		CsmComment result = new CsmComment();
		
		return result;
	}

	
	
	static CsmElement newline()
	{
		CsmElement result = newline(LineSeparator.___003C_003ESYSTEM);
		
		return result;
	}

	
	
	static CsmElement comma()
	{
		CsmToken result = new CsmToken(104);
		
		return result;
	}

	
	
	
	static CsmElement list(ObservableProperty property)
	{
		CsmList result = new CsmList(property);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	static CsmElement list(ObservableProperty property, CsmElement separator)
	{
		CsmList result = new CsmList(property, none(), separator, new CsmNone(), new CsmNone());
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	static CsmElement list(ObservableProperty property, CsmElement separator, CsmElement preceeding, CsmElement following)
	{
		CsmList result = new CsmList(property, none(), separator, preceeding, following);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	static CsmElement list(ObservableProperty property, CsmElement separatorPre, CsmElement separatorPost, CsmElement preceeding, CsmElement following)
	{
		CsmList result = new CsmList(property, separatorPre, separatorPost, preceeding, following);
		
		return result;
	}

	
	
	static CsmElement orphanCommentsEnding()
	{
		CsmOrphanCommentsEnding result = new CsmOrphanCommentsEnding();
		
		return result;
	}

	
	
	static CsmElement orphanCommentsBeforeThis()
	{
		CsmNone result = new CsmNone();
		
		return result;
	}

	
	
	
	static CsmElement block(CsmElement content)
	{
		CsmElement result = sequence(token(99), indent(), content, unindent(), token(100));
		
		return result;
	}
}
