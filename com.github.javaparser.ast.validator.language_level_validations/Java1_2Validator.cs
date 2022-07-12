
using com.github.javaparser.ast.validator.language_level_validations.chunks;


namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java1_2Validator : Java1_1Validator
{
	
	internal Validator modifiersWithoutDefaultAndStaticInterfaceMethodsAndPrivateInterfaceMethods;

	
	internal Validator strictfpNotAllowed;

	
	
	public Java1_2Validator()
	{
		modifiersWithoutDefaultAndStaticInterfaceMethodsAndPrivateInterfaceMethods = new ModifierValidator(hasStrictfp: true, hasDefaultAndStaticInterfaceMethods: false, hasPrivateInterfaceMethods: false);
		strictfpNotAllowed = new ReservedKeywordValidator("strictfp");
		replace(modifiersWithoutStrictfpAndDefaultAndStaticInterfaceMethodsAndPrivateInterfaceMethods, modifiersWithoutDefaultAndStaticInterfaceMethodsAndPrivateInterfaceMethods);
		add(strictfpNotAllowed);
	}
}
