
using com.github.javaparser.resolution;
using com.github.javaparser.resolution.declarations;

using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.symbolsolver.model.resolution;

public interface TypeSolver
{
	
	public static class __DefaultMethods
	{
		public unsafe static TypeSolver getRoot(TypeSolver P_0)
		{
			
			return _003Cdefault_003EgetRoot(P_0);
		}

		public unsafe static ResolvedReferenceTypeDeclaration solveType(TypeSolver P_0, string P_1)
		{
			
			return _003Cdefault_003EsolveType(P_0, P_1);
		}

		public unsafe static ResolvedReferenceTypeDeclaration getSolvedJavaLangObject(TypeSolver P_0)
		{
			
			return _003Cdefault_003EgetSolvedJavaLangObject(P_0);
		}

		public unsafe static bool hasType(TypeSolver P_0, string P_1)
		{
			
			return _003Cdefault_003EhasType(P_0, P_1);
		}
	}

	
	public static class __Fields
	{
		public static readonly string JAVA_LANG_OBJECT;

		static __Fields()
		{
			JAVA_LANG_OBJECT = TypeSolver.JAVA_LANG_OBJECT;
		}
	}

	static readonly string JAVA_LANG_OBJECT;

	
	
	static void ___003Cclinit_003E()
	{
	}

	
	
	virtual ResolvedReferenceTypeDeclaration solveType(string name);

	
	
	
	static ResolvedReferenceTypeDeclaration _003Cdefault_003EsolveType(TypeSolver P_0, string P_1)
	{
		SymbolReference symbolReference = P_0.tryToSolveType(P_1);
		if (symbolReference.isSolved())
		{
			return (ResolvedReferenceTypeDeclaration)symbolReference.getCorrespondingDeclaration();
		}
		string context = Object.instancehelper_toString(P_0);
		
		throw new UnsolvedSymbolException(P_1, context);
	}

		virtual SymbolReference tryToSolveType(string str);

	
	
	virtual ResolvedReferenceTypeDeclaration getSolvedJavaLangObject();

	
	
	
	static ResolvedReferenceTypeDeclaration _003Cdefault_003EgetSolvedJavaLangObject(TypeSolver P_0)
	{
		ResolvedReferenceTypeDeclaration result = P_0.solveType(JAVA_LANG_OBJECT);
		
		return result;
	}

	
	virtual TypeSolver getRoot();

	
	
	
	static TypeSolver _003Cdefault_003EgetRoot(TypeSolver P_0)
	{
		if (P_0.getParent() == null)
		{
			return P_0;
		}
		TypeSolver root = P_0.getParent().getRoot();
		
		return root;
	}

	virtual TypeSolver getParent();

	virtual void setParent(TypeSolver ts);

	
	virtual bool hasType(string name);

	
	
	
	static bool _003Cdefault_003EhasType(TypeSolver P_0, string P_1)
	{
		bool result = P_0.tryToSolveType(P_1).isSolved();
		
		return result;
	}

	
	static TypeSolver()
	{
		JAVA_LANG_OBJECT = ClassLiteral<Object>.Value.getCanonicalName();
	}
}
