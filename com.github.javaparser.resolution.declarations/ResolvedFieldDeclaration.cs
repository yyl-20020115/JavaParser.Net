


namespace com.github.javaparser.resolution.declarations;


public interface ResolvedFieldDeclaration : ResolvedValueDeclaration, ResolvedDeclaration, HasAccessSpecifier, AssociableToAST
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isField(ResolvedFieldDeclaration P_0)
		{
			
			return _003Cdefault_003EisField(P_0);
		}

		public unsafe static ResolvedFieldDeclaration asField(ResolvedFieldDeclaration P_0)
		{
			
			return _003Cdefault_003EasField(P_0);
		}
	}

	virtual ResolvedTypeDeclaration declaringType();

	virtual bool isStatic();

	virtual bool isVolatile();

	
	bool isField();

	
	static bool _003Cdefault_003EisField(ResolvedFieldDeclaration P_0)
	{
		return true;
	}

	
	ResolvedFieldDeclaration asField();

	
	static ResolvedFieldDeclaration _003Cdefault_003EasField(ResolvedFieldDeclaration P_0)
	{
		return P_0;
	}
}
