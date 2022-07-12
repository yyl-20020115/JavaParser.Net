using com.github.javaparser.ast.expr;


namespace com.github.javaparser.resolution.declarations;


public interface ResolvedAnnotationMemberDeclaration : ResolvedValueDeclaration, ResolvedDeclaration
{
	Expression getDefaultValue();
}
