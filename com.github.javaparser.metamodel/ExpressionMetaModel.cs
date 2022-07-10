using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class ExpressionMetaModel : NodeMetaModel
{
	
		
	
	internal ExpressionMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Expression>.Value, "Expression", "com.github.javaparser.ast.expr", isAbstract: true, hasWildcard: false)
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	protected internal ExpressionMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
