using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class VariableDeclarationExprMetaModel : ExpressionMetaModel
{
	public PropertyMetaModel annotationsPropertyMetaModel;

	public PropertyMetaModel modifiersPropertyMetaModel;

	public PropertyMetaModel variablesPropertyMetaModel;

	public PropertyMetaModel maximumCommonTypePropertyMetaModel;

	
		
	
	internal VariableDeclarationExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<VariableDeclarationExpr>.Value, "VariableDeclarationExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
