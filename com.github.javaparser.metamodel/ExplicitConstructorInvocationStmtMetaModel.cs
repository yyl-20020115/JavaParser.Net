using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class ExplicitConstructorInvocationStmtMetaModel : StatementMetaModel
{
	public PropertyMetaModel argumentsPropertyMetaModel;

	public PropertyMetaModel expressionPropertyMetaModel;

	public PropertyMetaModel isThisPropertyMetaModel;

	public PropertyMetaModel typeArgumentsPropertyMetaModel;

	public PropertyMetaModel usingDiamondOperatorPropertyMetaModel;

	
		
	
	internal ExplicitConstructorInvocationStmtMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<ExplicitConstructorInvocationStmt>.Value, "ExplicitConstructorInvocationStmt", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
