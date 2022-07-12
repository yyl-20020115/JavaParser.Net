

using java.lang;
using java.util;

namespace com.github.javaparser.resolution.declarations;

public interface AssociableToAST
{
	
	public static class __DefaultMethods
	{
		public unsafe static Optional toAst(AssociableToAST P_0)
		{
			
			return _003Cdefault_003EtoAst(P_0);
		}
	}

	
		virtual Optional toAst();

	
	
	
	static Optional _003Cdefault_003EtoAst(AssociableToAST P_0)
	{
		
		throw new UnsupportedOperationException();
	}
}
