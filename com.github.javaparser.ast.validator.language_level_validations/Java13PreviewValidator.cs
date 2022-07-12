


namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java13PreviewValidator : Java13Validator
{
	
	
	public Java13PreviewValidator()
	{
		remove(noTextBlockLiteral);
		remove(noSwitchExpressions);
		remove(onlyOneLabelInSwitchCase);
		remove(noYield);
	}
}
