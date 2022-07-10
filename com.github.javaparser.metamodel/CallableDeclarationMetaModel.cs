using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.metamodel;

public class CallableDeclarationMetaModel : BodyDeclarationMetaModel
{
	public PropertyMetaModel modifiersPropertyMetaModel;

	public PropertyMetaModel namePropertyMetaModel;

	public PropertyMetaModel parametersPropertyMetaModel;

	public PropertyMetaModel receiverParameterPropertyMetaModel;

	public PropertyMetaModel thrownExceptionsPropertyMetaModel;

	public PropertyMetaModel typeParametersPropertyMetaModel;

	
		
	
	internal CallableDeclarationMetaModel(Optional superBaseNodeMetaModel)
		: base(superBaseNodeMetaModel, ClassLiteral<CallableDeclaration>.Value, "CallableDeclaration", "com.github.javaparser.ast.body", isAbstract: true, hasWildcard: true)
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
	
	protected internal CallableDeclarationMetaModel(Optional superNodeMetaModel, Class type, string name, string packageName, bool isAbstract, bool hasWildcard)
		: base(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard)
	{
	}
}
