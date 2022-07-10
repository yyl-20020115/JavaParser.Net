using System.Runtime.CompilerServices;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class CatchClauseMetaModel : NodeMetaModel
{
	public PropertyMetaModel bodyPropertyMetaModel;

	public PropertyMetaModel parameterPropertyMetaModel;

	
		
	
	internal CatchClauseMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<CatchClause>.Value, "CatchClause", "com.github.javaparser.ast.stmt", isAbstract: false, hasWildcard: false)
	{
	}
}
