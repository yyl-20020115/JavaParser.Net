

using java.lang;

namespace com.github.javaparser.resolution.declarations;

public interface ResolvedDeclaration
{
	
	public static class __DefaultMethods
	{
		public unsafe static bool hasName(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EhasName(P_0);
		}

		public unsafe static bool isField(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EisField(P_0);
		}

		public unsafe static bool isVariable(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EisVariable(P_0);
		}

		public unsafe static bool isEnumConstant(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EisEnumConstant(P_0);
		}

		public unsafe static bool isPattern(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EisPattern(P_0);
		}

		public unsafe static bool isParameter(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EisParameter(P_0);
		}

		public unsafe static bool isType(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EisType(P_0);
		}

		public unsafe static bool isMethod(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EisMethod(P_0);
		}

		public unsafe static ResolvedFieldDeclaration asField(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EasField(P_0);
		}

		public unsafe static ResolvedParameterDeclaration asParameter(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EasParameter(P_0);
		}

		public unsafe static ResolvedTypeDeclaration asType(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EasType(P_0);
		}

		public unsafe static ResolvedMethodDeclaration asMethod(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EasMethod(P_0);
		}

		public unsafe static ResolvedEnumConstantDeclaration asEnumConstant(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EasEnumConstant(P_0);
		}

		public unsafe static ResolvedPatternDeclaration asPattern(ResolvedDeclaration P_0)
		{
			
			return _003Cdefault_003EasPattern(P_0);
		}
	}

	
	virtual bool hasName();

	
	static bool _003Cdefault_003EhasName(ResolvedDeclaration P_0)
	{
		return true;
	}

	virtual string getName();

	
	virtual bool isField();

	
	static bool _003Cdefault_003EisField(ResolvedDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isVariable();

	
	static bool _003Cdefault_003EisVariable(ResolvedDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isEnumConstant();

	
	static bool _003Cdefault_003EisEnumConstant(ResolvedDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isPattern();

	
	static bool _003Cdefault_003EisPattern(ResolvedDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isParameter();

	
	static bool _003Cdefault_003EisParameter(ResolvedDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isType();

	
	static bool _003Cdefault_003EisType(ResolvedDeclaration P_0)
	{
		return false;
	}

	
	virtual bool isMethod();

	
	static bool _003Cdefault_003EisMethod(ResolvedDeclaration P_0)
	{
		return false;
	}

	
	virtual ResolvedFieldDeclaration asField();

	
	
	
	static ResolvedFieldDeclaration _003Cdefault_003EasField(ResolvedDeclaration P_0)
	{
		string message = String.format("%s is not a FieldDeclaration", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedParameterDeclaration asParameter();

	
	
	
	static ResolvedParameterDeclaration _003Cdefault_003EasParameter(ResolvedDeclaration P_0)
	{
		string message = String.format("%s is not a ParameterDeclaration", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedTypeDeclaration asType();

	
	
	
	static ResolvedTypeDeclaration _003Cdefault_003EasType(ResolvedDeclaration P_0)
	{
		string message = String.format("%s is not a TypeDeclaration", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedMethodDeclaration asMethod();

	
	
	
	static ResolvedMethodDeclaration _003Cdefault_003EasMethod(ResolvedDeclaration P_0)
	{
		string message = String.format("%s is not a MethodDeclaration", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedEnumConstantDeclaration asEnumConstant();

	
	
	
	static ResolvedEnumConstantDeclaration _003Cdefault_003EasEnumConstant(ResolvedDeclaration P_0)
	{
		string message = String.format("%s is not an EnumConstantDeclaration", P_0);
		
		throw new UnsupportedOperationException(message);
	}

	
	virtual ResolvedPatternDeclaration asPattern();

	
	
	
	static ResolvedPatternDeclaration _003Cdefault_003EasPattern(ResolvedDeclaration P_0)
	{
		string message = String.format("%s is not a Pattern", P_0);
		
		throw new UnsupportedOperationException(message);
	}
}
