using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.validator.language_level_validations.chunks;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java11Validator : Java10Validator
{
	
	internal Validator varAlsoInLambdaParameters;

	
	
	public Java11Validator()
	{
		varAlsoInLambdaParameters = new SingleNodeTypeValidator(ClassLiteral<VarType>.Value, new VarValidator(varAllowedInLambdaParameters: true));
		replace(varOnlyOnLocalVariableDefinitionAndForAndTry, varAlsoInLambdaParameters);
	}
}
