using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedAnnotationDeclaration : ResolvedReferenceTypeDeclaration, ResolvedTypeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, AssociableToAST
{
	
	public new static class __DefaultMethods
	{
		public unsafe static bool isAnnotation(ResolvedAnnotationDeclaration P_0)
		{
			
			return _003Cdefault_003EisAnnotation(P_0);
		}

		public unsafe static ResolvedAnnotationDeclaration asAnnotation(ResolvedAnnotationDeclaration P_0)
		{
			
			return _003Cdefault_003EasAnnotation(P_0);
		}
	}

	
	bool isAnnotation();

	
	static bool _003Cdefault_003EisAnnotation(ResolvedAnnotationDeclaration P_0)
	{
		return true;
	}

	
	ResolvedAnnotationDeclaration asAnnotation();

	
	static ResolvedAnnotationDeclaration _003Cdefault_003EasAnnotation(ResolvedAnnotationDeclaration P_0)
	{
		return P_0;
	}

		virtual List getAnnotationMembers();

	virtual bool isInheritable();
}
