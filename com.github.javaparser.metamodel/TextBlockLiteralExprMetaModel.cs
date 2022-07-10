using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class TextBlockLiteralExprMetaModel : LiteralStringValueExprMetaModel
{
	
		
	
	internal TextBlockLiteralExprMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<TextBlockLiteralExpr>.Value, "TextBlockLiteralExpr", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
