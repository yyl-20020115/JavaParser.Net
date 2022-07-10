using IKVM.Attributes;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedConstructorDeclaration : ResolvedMethodLikeDeclaration, ResolvedDeclaration, ResolvedTypeParametrizable, HasAccessSpecifier, AssociableToAST
{
	ResolvedReferenceTypeDeclaration declaringType();
}
