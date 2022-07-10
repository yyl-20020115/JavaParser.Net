using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedClassDeclaration : ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isClass(ResolvedClassDeclaration P_0)
		{
			
			return _003Cdefault_003EisClass(P_0);
		}
	}

	
	bool isClass();

	
	static bool _003Cdefault_003EisClass(ResolvedClassDeclaration P_0)
	{
		return true;
	}

		virtual Optional getSuperClass();

		virtual List getInterfaces();

		virtual List getAllSuperClasses();

		virtual List getAllInterfaces();

		List getConstructors();
}
