
using com.github.javaparser.ast;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class NodeMetaModel : BaseNodeMetaModel
{
	public PropertyMetaModel commentPropertyMetaModel;

	
		
	
	internal NodeMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<Node>.Value, "Node", "com.github.javaparser.ast", isAbstract: true, hasWildcard: false)
	{
	}

	
		
	
	protected internal NodeMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
