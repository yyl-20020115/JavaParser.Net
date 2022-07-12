
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.validator.language_level_validations.chunks;

using ikvm.@internal;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java9Validator : Java8Validator
{
	
	private sealed class ___003C_003EAnon0 : TypedValidator
	{
		internal ___003C_003EAnon0()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00240((TryStmt)P_0, P_1);
			
		}

		
		public Processor processor()
		{
			return TypedValidator._003Cdefault_003Eprocessor(this);
		}

		
		public void accept(object P_0, object P_1)
		{
			TypedValidator._003Cdefault_003Eaccept(this, P_0, P_1);
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	internal Validator underscoreKeywordValidator;

	
	internal Validator modifiers;

	
		internal SingleNodeTypeValidator tryWithResources;

	
	
	
	
	private static void lambda_0024new_00240(TryStmt n, ProblemReporter reporter)
	{
		if (n.getCatchClauses().isEmpty() && n.getResources().isEmpty() && !n.getFinallyBlock().isPresent())
		{
			reporter.report(n, "Try has no finally, no catch, and no resources.");
		}
	}

	
	
	public Java9Validator()
	{
		underscoreKeywordValidator = new UnderscoreKeywordValidator();
		modifiers = new ModifierValidator(hasStrictfp: true, hasDefaultAndStaticInterfaceMethods: true, hasPrivateInterfaceMethods: true);
		tryWithResources = new SingleNodeTypeValidator(ClassLiteral<TryStmt>.Value, new ___003C_003EAnon0());
		add(underscoreKeywordValidator);
		remove(noModules);
		replace(modifiersWithoutPrivateInterfaceMethods, modifiers);
		replace(tryWithLimitedResources, tryWithResources);
	}
}
