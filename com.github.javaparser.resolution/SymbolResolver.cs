using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.types;

using java.lang;

namespace com.github.javaparser.resolution;

public interface SymbolResolver
{
		
	virtual object resolveDeclaration(Node node, Class resultClass);

	
	virtual ResolvedType calculateType(Expression expression);

		
	virtual object toResolvedType(Type javaparserType, Class resultClass);
}
