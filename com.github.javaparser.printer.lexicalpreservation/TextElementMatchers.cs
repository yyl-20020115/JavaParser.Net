
using com.github.javaparser.ast;

using java.lang;

namespace com.github.javaparser.printer.lexicalpreservation;

internal class TextElementMatchers
{
	
	[EnclosingMethod(null, "byNode", "(Lcom.github.javaparser.ast.Node;)Lcom.github.javaparser.printer.lexicalpreservation.TextElementMatcher;")]
	internal sealed class _1: TextElementMatcher
	{
		
		internal Node val_0024node;

		
		
		
		internal _1(Node val_0024node)
		{
			this.val_0024node = val_0024node;
			base._002Ector();
		}

		
		
		
		public virtual bool match(TextElement textElement)
		{
			bool result = textElement.isNode(val_0024node);
			
			return result;
		}

		
		
		public override string ToString()
		{
			string result = new StringBuilder().append("match node ").append(val_0024node).ToString();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual TextElementMatcher and(TextElementMatcher P_0)
		{
			return TextElementMatcher._003Cdefault_003Eand(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon0 : TextElementMatcher
	{
		private readonly int arg_00241;

		internal ___003C_003EAnon0(int P_0)
		{
			arg_00241 = P_0;
		}

		public bool match(TextElement P_0)
		{
			bool result = lambda_0024byTokenType_00240(arg_00241, P_0);
			
			return result;
		}

		
		public TextElementMatcher and(TextElementMatcher P_0)
		{
			return TextElementMatcher._003Cdefault_003Eand(this, P_0);
		}
	}

	
	
	
	internal static TextElementMatcher byNode(Node node)
	{
		_1 result = new _1(node);
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024byTokenType_00240(int tokenType, TextElement textElement)
	{
		bool result = textElement.isToken(tokenType);
		
		return result;
	}

	
	
	internal TextElementMatchers()
	{
	}

	
	
	
	internal static TextElementMatcher byTokenType(int tokenType)
	{
		return new ___003C_003EAnon0(tokenType);
	}
}
