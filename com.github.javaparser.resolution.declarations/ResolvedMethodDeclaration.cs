using com.github.javaparser.resolution.types;
using IKVM.Attributes;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedMethodDeclaration : ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST
{
	virtual ResolvedType getReturnType();

	virtual bool isAbstract();

	virtual bool isDefaultMethod();

	virtual bool isStatic();
}
