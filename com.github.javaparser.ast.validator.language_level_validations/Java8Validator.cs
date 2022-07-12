
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.validator.language_level_validations.chunks;

using ikvm.@internal;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java8Validator : Java7Validator
{
	
	private sealed class ___003C_003EAnon0 : TypedValidator
	{
		internal ___003C_003EAnon0()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00241((ClassOrInterfaceDeclaration)P_0, P_1);
			
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

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly ProblemReporter arg_00241;

		internal ___003C_003EAnon1(ProblemReporter P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00240(arg_00241, (MethodDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	internal Validator modifiersWithoutPrivateInterfaceMethods;

	
	internal Validator defaultMethodsInInterface;

	
	
	
	
	private static void lambda_0024new_00241(ClassOrInterfaceDeclaration n, ProblemReporter reporter)
	{
		if (n.isInterface())
		{
			n.getMethods().forEach(new ___003C_003EAnon1(reporter));
		}
	}

	
	
	
	
	private static void lambda_0024null_00240(ProblemReporter reporter, MethodDeclaration m)
	{
		if (m.isDefault() && !m.getBody().isPresent())
		{
			reporter.report(m, "'default' methods must have a body.");
		}
	}

	
	
	public Java8Validator()
	{
		modifiersWithoutPrivateInterfaceMethods = new ModifierValidator(hasStrictfp: true, hasDefaultAndStaticInterfaceMethods: true, hasPrivateInterfaceMethods: false);
		defaultMethodsInInterface = new SingleNodeTypeValidator(ClassLiteral<ClassOrInterfaceDeclaration>.Value, new ___003C_003EAnon0());
		replace(modifiersWithoutDefaultAndStaticInterfaceMethodsAndPrivateInterfaceMethods, modifiersWithoutPrivateInterfaceMethods);
		add(defaultMethodsInInterface);
		remove(noLambdas);
	}
}
