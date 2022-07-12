
using com.github.javaparser.ast;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.printer.lexicalpreservation;

public abstract class TextElement: TextElementMatcher
{
	
	private sealed class ___003C_003EAnon0 : TextElementMatcher
	{
		private readonly TextElement arg_00241;

		internal ___003C_003EAnon0(TextElement P_0)
		{
			arg_00241 = P_0;
		}

		public bool match(TextElement P_0)
		{
			bool result = arg_00241.lambda_0024matchByRange_00241(P_0);
			
			return result;
		}

		
		public TextElementMatcher and(TextElementMatcher P_0)
		{
			return TextElementMatcher._003Cdefault_003Eand(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		private readonly TextElement arg_00241;

		internal ___003C_003EAnon1(TextElement P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024null_00240(arg_00241, (Range)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		private readonly Range arg_00241;

		internal ___003C_003EAnon2(Range P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Boolean result = Boolean.valueOf(arg_00241.equals((Range)P_0));
			
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

	
	
	internal virtual bool isToken(int tokenKind)
	{
		throw new AbstractMethodError("com.github.javaparser.printer.lexicalpreservation.TextElement.isToken(I)Z");
	}

	public abstract bool isWhiteSpace();

	public abstract bool isComment();

		
	public abstract bool isChildOfClass(Class nodeClass);

	
		internal virtual Optional getRange()
	{
		throw new AbstractMethodError("com.github.javaparser.printer.lexicalpreservation.TextElement.getRange()Ljava.util.Optional;");
	}

	
	
	
	
	private bool lambda_0024matchByRange_00241(TextElement textElement)
	{
		bool result = ((Boolean)getRange().flatMap(new ___003C_003EAnon1(textElement)).orElse(Boolean.valueOf(b: true))).booleanValue();
		
		return result;
	}

	
	
	
	
	private unsafe static Optional lambda_0024null_00240(TextElement textElement, Range r1)
	{
		Optional range = textElement.getRange();
		
		Optional result = range.map(new ___003C_003EAnon2(r1));
		
		return result;
	}

	
	
	public TextElement()
	{
	}

	
	internal virtual string expand()
	{
		throw new AbstractMethodError("com.github.javaparser.printer.lexicalpreservation.TextElement.expand()Ljava.lang.String;");
	}

	
	
	internal bool isCommentToken()
	{
		return (isToken(8) || isToken(5) || isToken(9)) ? true : false;
	}

	
	
	
	public virtual bool match(TextElement textElement)
	{
		bool result = Object.instancehelper_equals(this, textElement);
		
		return result;
	}

	
	
	internal virtual bool isNode(Node node)
	{
		throw new AbstractMethodError("com.github.javaparser.printer.lexicalpreservation.TextElement.isNode(Lcom.github.javaparser.ast.Node;)Z");
	}

	public abstract bool isLiteral();

	public abstract bool isSpaceOrTab();

	public abstract bool isNewline();

	public abstract bool isSeparator();

	public abstract bool isIdentifier();

	public abstract bool isKeyword();

	public abstract bool isPrimitive();

	
	
	public bool isWhiteSpaceOrComment()
	{
		return (isWhiteSpace() || isComment()) ? true : false;
	}

	
	
	public virtual bool isChild()
	{
		bool result = isChildOfClass(ClassLiteral<Node>.Value);
		
		return result;
	}

	
	
	internal virtual TextElementMatcher matchByRange()
	{
		return new ___003C_003EAnon0(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual TextElementMatcher and(TextElementMatcher P_0)
	{
		return TextElementMatcher._003Cdefault_003Eand(this, P_0);
	}
}
