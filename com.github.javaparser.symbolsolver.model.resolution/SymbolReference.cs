
using com.github.javaparser.resolution.declarations;

using java.lang;
using java.util;

namespace com.github.javaparser.symbolsolver.model.resolution;

public class SymbolReference
{
		private Optional correspondingDeclaration;

	
		
	public static SymbolReference unsolved(Class clazz)
	{
		SymbolReference result = new SymbolReference(Optional.empty());
		
		return result;
	}

	
	
	public virtual bool isSolved()
	{
		bool result = correspondingDeclaration.isPresent();
		
		return result;
	}

	
		
	public virtual ResolvedDeclaration getCorrespondingDeclaration()
	{
		if (!isSolved())
		{
			
			throw new UnsupportedOperationException("CorrespondingDeclaration not available for unsolved symbol.");
		}
		return (ResolvedDeclaration)correspondingDeclaration.get();
	}

	
		
	public static SymbolReference solved(ResolvedDeclaration symbolDeclaration)
	{
		SymbolReference result = new SymbolReference(Optional.of(symbolDeclaration));
		
		return result;
	}

	
		
	public static SymbolReference adapt(SymbolReference @ref, Class clazz)
	{
		if (@ref.isSolved())
		{
			SymbolReference result = solved(@ref.getCorrespondingDeclaration());
			
			return result;
		}
		SymbolReference result2 = unsolved(clazz);
		
		return result2;
	}

	
		
	private SymbolReference(Optional P_0)
	{
		correspondingDeclaration = P_0;
	}

	
	
	public override string ToString()
	{
		string result = new StringBuilder().append("SymbolReference{").append(correspondingDeclaration).append("}")
			.ToString();
		
		return result;
	}
}
