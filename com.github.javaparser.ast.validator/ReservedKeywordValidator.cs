using System.ComponentModel;

using com.github.javaparser.ast.expr;
using com.github.javaparser.utils;

using java.lang;

namespace com.github.javaparser.ast.validator;

public class ReservedKeywordValidator : VisitorValidator
{
	
	private string keyword;

	
	private string error;

	
	
	
	public ReservedKeywordValidator(string keyword)
	{
		this.keyword = keyword;
		error = CodeGenerationUtils.f("'%s' cannot be used as an identifier as it is a keyword.", keyword);
	}

	
	
	
	public virtual void visit(SimpleName n, ProblemReporter arg)
	{
		if (String.instancehelper_equals(n.getIdentifier(), keyword))
		{
			arg.report(n, error);
		}
		base.visit(n, arg);
	}

	
	
	
	public virtual void visit(Name n, ProblemReporter arg)
	{
		if (String.instancehelper_equals(n.getIdentifier(), keyword))
		{
			arg.report(n, error);
		}
		base.visit(n, arg);
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
