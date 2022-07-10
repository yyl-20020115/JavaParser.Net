using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class MemberValuePairMetaModel : NodeMetaModel
{
	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel valuePropertyMetaModel;

	
		
	
	internal MemberValuePairMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<MemberValuePair>.Value, "MemberValuePair", "com.github.javaparser.ast.expr", isAbstract: false, hasWildcard: false)
	{
	}
}
