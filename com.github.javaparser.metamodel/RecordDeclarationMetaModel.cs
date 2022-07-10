using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.metamodel;

public class RecordDeclarationMetaModel : TypeDeclarationMetaModel
{
	public PropertyMetaModel implementedTypesPropertyMetaModel;

	public PropertyMetaModel parametersPropertyMetaModel;

	public PropertyMetaModel receiverParameterPropertyMetaModel;

	public PropertyMetaModel typeParametersPropertyMetaModel;

	
		
	
	internal RecordDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<RecordDeclaration>.Value, "RecordDeclaration", "com.github.javaparser.ast.body", isAbstract: false, hasWildcard: false)
	{
	}
}
