


namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java14PreviewValidator : Java14Validator
{
	
	
	public Java14PreviewValidator()
	{
		remove(noPatternMatchingInstanceOf);
		remove(noRecordDeclaration);
		add(recordAsTypeIdentifierNotAllowed);
		add(recordDeclarationValidator);
		remove(noTextBlockLiteral);
	}
}
