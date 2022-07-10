using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java15PreviewValidator : Java15Validator
{
	
	
	public Java15PreviewValidator()
	{
		remove(noPatternMatchingInstanceOf);
		remove(noRecordDeclaration);
		add(recordAsTypeIdentifierNotAllowed);
		add(recordDeclarationValidator);
	}
}
