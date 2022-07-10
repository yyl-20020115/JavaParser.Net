using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.validator.language_level_validations.chunks;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java10Validator : Java9Validator
{
	
	internal Validator varOnlyOnLocalVariableDefinitionAndForAndTry;

	
	
	public Java10Validator()
	{
		varOnlyOnLocalVariableDefinitionAndForAndTry = new SingleNodeTypeValidator(ClassLiteral<VarType>.Value, new VarValidator(varAllowedInLambdaParameters: false));
		add(varOnlyOnLocalVariableDefinitionAndForAndTry);
	}
}
