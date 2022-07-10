using com.github.javaparser.ast.expr;
using IKVM.Attributes;

namespace com.github.javaparser.resolution.declarations;


public interface ResolvedAnnotationMemberDeclaration : ResolvedValueDeclaration, ResolvedDeclaration
{
	Expression getDefaultValue();
}
