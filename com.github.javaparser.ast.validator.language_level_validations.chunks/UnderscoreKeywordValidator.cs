using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.expr;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;

public class UnderscoreKeywordValidator : VisitorValidator
{
	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	private static void validateIdentifier(Node n, string id, ProblemReporter arg)
	{
		if (String.instancehelper_equals(id, "_"))
		{
			arg.report(n, "'_' is a reserved keyword.");
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(SimpleName n, ProblemReporter arg)
	{
		validateIdentifier(n, n.getIdentifier(), arg);
		base.visit(n, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(Name n, ProblemReporter arg)
	{
		validateIdentifier(n, n.getIdentifier(), arg);
		base.visit(n, arg);
	}

	
	
	public UnderscoreKeywordValidator()
	{
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public override void visit(SimpleName n, object arg)
	{
		visit(n, (ProblemReporter)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public override void visit(Name n, object arg)
	{
		visit(n, (ProblemReporter)arg);
	}
}
