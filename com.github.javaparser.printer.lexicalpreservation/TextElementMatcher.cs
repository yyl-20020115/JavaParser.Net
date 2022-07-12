


namespace com.github.javaparser.printer.lexicalpreservation;

public interface TextElementMatcher
{
	private static class ___003C_003EPIM
	{
		
		
		[NameSig("lambda$and$0", "(Lcom.github.javaparser.printer.lexicalpreservation.TextElementMatcher;Lcom.github.javaparser.printer.lexicalpreservation.TextElement;)Z")]
		
		
		
		internal unsafe static bool _003Cpiim_003Elambda_0024and_00240(TextElementMatcher textElementMatcher, TextElementMatcher textElement, TextElement P_2)
		{
			
			return (textElementMatcher.match(P_2) && textElement.match(P_2)) ? true : false;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static TextElementMatcher and(TextElementMatcher P_0, TextElementMatcher P_1)
		{
			
			return _003Cdefault_003Eand(P_0, P_1);
		}
	}

	
	private sealed class ___003C_003EAnon1 : TextElementMatcher
	{
		private readonly TextElementMatcher arg_00241;

		private readonly TextElementMatcher arg_00242;

		internal ___003C_003EAnon1(TextElementMatcher P_0, TextElementMatcher P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public bool match(TextElement P_0)
		{
			bool result = ___003C_003EPIM._003Cpiim_003Elambda_0024and_00240(arg_00241, arg_00242, P_0);
			
			return result;
		}

		
		public TextElementMatcher and(TextElementMatcher P_0)
		{
			return _003Cdefault_003Eand(this, P_0);
		}
	}

	
	virtual bool match(TextElement textElement);

	
	
	virtual TextElementMatcher and(TextElementMatcher textElementMatcher);

	
	
	
	static TextElementMatcher _003Cdefault_003Eand(TextElementMatcher P_0, TextElementMatcher P_1)
	{
		return new ___003C_003EAnon1(P_0, P_1);
	}
}
