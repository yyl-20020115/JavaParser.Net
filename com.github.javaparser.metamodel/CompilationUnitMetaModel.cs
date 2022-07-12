
using com.github.javaparser.ast;

using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class CompilationUnitMetaModel : NodeMetaModel
{
	public PropertyMetaModel importsPropertyMetaModel;

	public PropertyMetaModel modulePropertyMetaModel;

	public PropertyMetaModel packageDeclarationPropertyMetaModel;

	public PropertyMetaModel typesPropertyMetaModel;

	
		
	
	internal CompilationUnitMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<CompilationUnit>.Value, "CompilationUnit", "com.github.javaparser.ast", isAbstract: false, hasWildcard: false)
	{
	}
}
