using com.github.javaparser.ast;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.resolution;

public interface SymbolResolver
{
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual object resolveDeclaration(Node node, Class resultClass);

	
	virtual ResolvedType calculateType(Expression expression);

		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	virtual object toResolvedType(Type javaparserType, Class resultClass);
}
