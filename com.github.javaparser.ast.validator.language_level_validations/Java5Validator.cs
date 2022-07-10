using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.validator.language_level_validations;

public class Java5Validator : Java1_4Validator
{
	
	private sealed class ___003C_003EAnon0 : Validator
	{
		internal ___003C_003EAnon0()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00240(P_0, P_1);
			
		}

		
		public void accept(object P_0, object P_1)
		{
			Validator._003Cdefault_003Eaccept(this, P_0, P_1);
		}

		
		public Processor processor()
		{
			return TypedValidator._003Cdefault_003Eprocessor(this);
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Validator
	{
		internal ___003C_003EAnon1()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00243(P_0, P_1);
			
		}

		
		public void accept(object P_0, object P_1)
		{
			Validator._003Cdefault_003Eaccept(this, P_0, P_1);
		}

		
		public Processor processor()
		{
			return TypedValidator._003Cdefault_003Eprocessor(this);
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : TypedValidator
	{
		internal ___003C_003EAnon2()
		{
		}

		public void accept(Node P_0, ProblemReporter P_1)
		{
			lambda_0024new_00244((ForEachStmt)P_0, P_1);
			
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

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly ProblemReporter arg_00241;

		private readonly Node arg_00242;

		internal ___003C_003EAnon3(ProblemReporter P_0, Node P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00242(arg_00241, arg_00242, (NodeList)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly ProblemReporter arg_00241;

		private readonly Node arg_00242;

		internal ___003C_003EAnon4(ProblemReporter P_0, Node P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024null_00241(arg_00241, arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	internal Validator genericsWithoutDiamondOperator;

	internal Validator ___003C_003EnoPrimitiveGenericArguments;

	
	internal Validator forEachStmt;

	
	internal Validator enumNotAllowed;

	
	protected internal Validator noPrimitiveGenericArguments
	{
		
		get
		{
			return ___003C_003EnoPrimitiveGenericArguments;
		}
		
		private set
		{
			___003C_003EnoPrimitiveGenericArguments = value;
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024new_00240(Node node, ProblemReporter reporter)
	{
		if (node is NodeWithTypeArguments)
		{
			Optional typeArguments = ((NodeWithTypeArguments)node).getTypeArguments();
			if (typeArguments.isPresent() && ((NodeList)typeArguments.get()).isEmpty())
			{
				reporter.report(node, "The diamond operator is not supported.");
			}
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024new_00243(Node node, ProblemReporter reporter)
	{
		if (node is NodeWithTypeArguments)
		{
			Optional typeArguments = ((NodeWithTypeArguments)node).getTypeArguments();
			typeArguments.ifPresent(new ___003C_003EAnon3(reporter, node));
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024new_00244(ForEachStmt node, ProblemReporter reporter)
	{
		VariableDeclarationExpr variable = node.getVariable();
		if (variable.getVariables().size() != 1)
		{
			reporter.report(node, new StringBuilder().append("A foreach statement's variable declaration must have exactly one variable declarator. Given: ").append(variable.getVariables().size()).append(".")
				.ToString());
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024null_00242(ProblemReporter reporter, Node node, NodeList types)
	{
		types.forEach(new ___003C_003EAnon4(reporter, node));
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024null_00241(ProblemReporter reporter, Node node, Type ty)
	{
		if (ty is PrimitiveType)
		{
			reporter.report(node, "Type arguments may not be primitive.");
		}
	}

	
	[LineNumberTable(new byte[]
	{
		26, 232, 30, 245, 73, 245, 77, 250, 73, 208,
		115, 109, 109, 205, 141, 109, 109, 109, 109
	})]
	public Java5Validator()
	{
		genericsWithoutDiamondOperator = new TreeVisitorValidator(new ___003C_003EAnon0());
		___003C_003EnoPrimitiveGenericArguments = new TreeVisitorValidator(new ___003C_003EAnon1());
		forEachStmt = new SingleNodeTypeValidator(ClassLiteral<ForEachStmt>.Value, new ___003C_003EAnon2());
		enumNotAllowed = new ReservedKeywordValidator("enum");
		replace(noGenerics, genericsWithoutDiamondOperator);
		add(___003C_003EnoPrimitiveGenericArguments);
		add(enumNotAllowed);
		add(forEachStmt);
		remove(noAnnotations);
		remove(noEnums);
		remove(noVarargs);
		remove(noForEach);
		remove(noStaticImports);
	}
}
