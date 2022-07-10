using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java16Validator : Java15Validator
{
	
	
	public Java16Validator()
	{
		remove(noPatternMatchingInstanceOf);
		remove(noRecordDeclaration);
		add(recordAsTypeIdentifierNotAllowed);
		add(recordDeclarationValidator);
	}
}
