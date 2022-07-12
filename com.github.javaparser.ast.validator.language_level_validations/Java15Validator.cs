


namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java15Validator : Java14Validator
{
	
	
	public Java15Validator()
	{
		remove(noTextBlockLiteral);
	}
}
