using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using IKVM.Attributes;
using ikvm.@internal;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java1_1Validator : Java1_0Validator
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
		private readonly ClassOrInterfaceDeclaration arg_00241;

		private readonly ProblemReporter arg_00242;

		internal ___003C_003EAnon1(ClassOrInterfaceDeclaration P_0, ProblemReporter P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00240(arg_00241, arg_00242, (Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	internal Validator innerClasses;

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024new_00241(ClassOrInterfaceDeclaration n, ProblemReporter reporter)
	{
		n.getParentNode().ifPresent(new ___003C_003EAnon1(n, reporter));
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024null_00240(ClassOrInterfaceDeclaration n, ProblemReporter reporter, Node p)
	{
		if (p is LocalClassDeclarationStmt && n.isInterface())
		{
			reporter.report(n, "There is no such thing as a local interface.");
		}
	}

	
	
	public Java1_1Validator()
	{
		innerClasses = new SingleNodeTypeValidator(ClassLiteral<ClassOrInterfaceDeclaration>.Value, new ___003C_003EAnon0());
		replace(noInnerClasses, innerClasses);
		remove(noReflection);
	}
}