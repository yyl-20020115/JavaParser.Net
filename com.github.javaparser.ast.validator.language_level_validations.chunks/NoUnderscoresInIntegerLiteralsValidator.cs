using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;

public class NoUnderscoresInIntegerLiteralsValidator : VisitorValidator
{
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private static void validate(LiteralStringValueExpr n, ProblemReporter arg)
	{
		string value = n.getValue();
		CharSequence s = default(CharSequence);
		object obj = (s.___003Cref_003E = "_");
		if (String.instancehelper_contains(value, s))
		{
			arg.report(n, "Underscores in literal values are not supported.");
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(LongLiteralExpr n, ProblemReporter arg)
	{
		validate(n, arg);
		base.visit(n, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(IntegerLiteralExpr n, ProblemReporter arg)
	{
		validate(n, arg);
		base.visit(n, arg);
	}

	
	
	public NoUnderscoresInIntegerLiteralsValidator()
	{
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public override void visit(LongLiteralExpr n, object arg)
	{
		visit(n, (ProblemReporter)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public override void visit(IntegerLiteralExpr n, object arg)
	{
		visit(n, (ProblemReporter)arg);
	}
}
