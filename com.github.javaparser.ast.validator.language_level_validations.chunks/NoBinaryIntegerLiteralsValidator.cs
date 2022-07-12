using System.ComponentModel;

using com.github.javaparser.ast.expr;

using java.lang;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;

public class NoBinaryIntegerLiteralsValidator : VisitorValidator
{
	
	
	
	private static void validate(LiteralStringValueExpr n, ProblemReporter arg)
	{
		if (String.instancehelper_startsWith(String.instancehelper_toUpperCase(n.getValue()), "0B"))
		{
			arg.report(n, "Binary literal values are not supported.");
		}
	}

	
	
	
	public virtual void visit(LongLiteralExpr n, ProblemReporter arg)
	{
		validate(n, arg);
		base.visit(n, arg);
	}

	
	
	
	public virtual void visit(IntegerLiteralExpr n, ProblemReporter arg)
	{
		validate(n, arg);
		base.visit(n, arg);
	}

	
	
	public NoBinaryIntegerLiteralsValidator()
	{
	}

	
	
	
	
	
	public override void visit(LongLiteralExpr n, object arg)
	{
		visit(n, (ProblemReporter)arg);
	}

	
	
	
	
	
	public override void visit(IntegerLiteralExpr n, object arg)
	{
		visit(n, (ProblemReporter)arg);
	}
}
