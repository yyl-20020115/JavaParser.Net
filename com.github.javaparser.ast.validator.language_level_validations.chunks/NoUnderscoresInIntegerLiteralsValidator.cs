using System.ComponentModel;

using com.github.javaparser.ast.expr;

using java.lang;

namespace com.github.javaparser.ast.validator.language_level_validations.chunks;

public class NoUnderscoresInIntegerLiteralsValidator : VisitorValidator
{
	
	
	
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

	
	
	public NoUnderscoresInIntegerLiteralsValidator()
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
