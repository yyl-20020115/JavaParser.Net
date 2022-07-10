using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java1_4Validator : Java1_3Validator
{
	
	
	public Java1_4Validator()
	{
		remove(noAssertKeyword);
	}
}
