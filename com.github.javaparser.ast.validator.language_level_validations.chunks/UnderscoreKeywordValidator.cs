using System.ComponentModel;

using com.github.javaparser.ast.expr;

using java.lang;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;

public class UnderscoreKeywordValidator : VisitorValidator
{
	
	
	
	private static void validateIdentifier(Node n, string id, ProblemReporter arg)
	{
		if (String.instancehelper_equals(id, "_"))
		{
			arg.report(n, "'_' is a reserved keyword.");
		}
	}

	
	
	
	public virtual void visit(SimpleName n, ProblemReporter arg)
	{
		validateIdentifier(n, n.getIdentifier(), arg);
		base.visit(n, arg);
	}

	
	
	
	public virtual void visit(Name n, ProblemReporter arg)
	{
		validateIdentifier(n, n.getIdentifier(), arg);
		base.visit(n, arg);
	}

	
	
	public UnderscoreKeywordValidator()
	{
	}

	
	
	
	
	
	public override void visit(SimpleName n, object arg)
	{
		visit(n, (ProblemReporter)arg);
	}

	
	
	
	
	
	public override void visit(Name n, object arg)
	{
		visit(n, (ProblemReporter)arg);
	}
}
