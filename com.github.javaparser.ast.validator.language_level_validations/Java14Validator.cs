using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.validator.language_level_validations.chunks;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java14Validator : Java13Validator
{
	
	internal Validator recordAsTypeIdentifierNotAllowed;

	
	internal Validator recordDeclarationValidator;

	
	
	public Java14Validator()
	{
		recordAsTypeIdentifierNotAllowed = new RecordAsTypeIdentifierNotAllowed();
		recordDeclarationValidator = new SingleNodeTypeValidator(ClassLiteral<RecordDeclaration>.Value, new RecordDeclarationValidator());
		remove(noSwitchExpressions);
		remove(onlyOneLabelInSwitchCase);
		remove(noYield);
	}
}
