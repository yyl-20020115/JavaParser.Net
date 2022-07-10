using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class NullLiteralExprMetaModel : LiteralExprMetaModel
{
	
		
	
	internal NullLiteralExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<NullLiteralExpr>.Value, "NullLiteralExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
