

using java.util;

namespace com.github.javaparser.resolution.declarations;

public interface ResolvedTypeParametrizable
{
	
	public static class __DefaultMethods
	{
		public unsafe static bool isGeneric(ResolvedTypeParametrizable P_0)
		{
			
			return _003Cdefault_003EisGeneric(P_0);
		}
	}

		virtual List getTypeParameters();

		
	virtual Optional findTypeParameter(string name);

	
	virtual bool isGeneric();

	
	
	
	static bool _003Cdefault_003EisGeneric(ResolvedTypeParametrizable P_0)
	{
		return (!P_0.getTypeParameters().isEmpty()) ? true : false;
	}
}
