using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java12PreviewValidator : Java12Validator
{
	
	
	public Java12PreviewValidator()
	{
		remove(noSwitchExpressions);
		remove(onlyOneLabelInSwitchCase);
	}
}
