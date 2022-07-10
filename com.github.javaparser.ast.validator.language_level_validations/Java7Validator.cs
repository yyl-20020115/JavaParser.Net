using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java7Validator : Java6Validator
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

	
	private sealed class ___003C_003EAnon1 : TypedValidator
	{
		internal ___003C_003EAnon1()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00241((UnionType)P_0, P_1);
			
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

	
		internal SingleNodeTypeValidator tryWithLimitedResources;

	
		private SingleNodeTypeValidator multiCatch;

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	[LineNumberTable(new byte[]
	{
		159, 176, 110, 109, 108, 146, 127, 1, 104, 146,
		98
	})]
	private static void lambda_0024new_00240(TryStmt n, ProblemReporter reporter)
	{
		if (n.getCatchClauses().isEmpty() && n.getResources().isEmpty() && !n.getFinallyBlock().isPresent())
		{
			reporter.report(n, "Try has no finally, no catch, and no resources.");
		}
		Iterator iterator = n.getResources().iterator();
		while (iterator.hasNext())
		{
			Expression expression = (Expression)iterator.next();
			if (!expression.isVariableDeclarationExpr())
			{
				reporter.report(n, "Try with resources only supports variable declarations.");
			}
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024new_00241(UnionType n, ProblemReporter reporter)
	{
		if (n.getElements().size() == 1)
		{
			reporter.report(n, "Union type (multi catch) must have at least two elements.");
		}
	}

	
	[LineNumberTable(new byte[]
	{
		3, 232, 44, 250, 76, 250, 73, 109, 115, 109,
		109, 115
	})]
	public Java7Validator()
	{
		tryWithLimitedResources = new SingleNodeTypeValidator(ClassLiteral<TryStmt>.Value, new ___003C_003EAnon0());
		multiCatch = new SingleNodeTypeValidator(ClassLiteral<UnionType>.Value, new ___003C_003EAnon1());
		remove(genericsWithoutDiamondOperator);
		replace(tryWithoutResources, tryWithLimitedResources);
		remove(noBinaryIntegerLiterals);
		remove(noUnderscoresInIntegerLiterals);
		replace(noMultiCatch, multiCatch);
	}
}
