using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;

using java.lang;

namespace com.github.javaparser.ast.validator;

public class RecordAsTypeIdentifierNotAllowed : VisitorValidator
{
	
	private string error;

	
	
	public RecordAsTypeIdentifierNotAllowed()
	{
		error = "'record' is a restricted identifier and cannot be used for type declarations";
	}

	
	
	
	private bool validUsage(Node node)
	{
		if (!node.getParentNode().isPresent())
		{
			return true;
		}
		Node node2 = (Node)node.getParentNode().get();
		return !(node2 is TypeDeclaration);
	}

	
	
	
	public virtual void visit(SimpleName n, ProblemReporter arg)
	{
		if (String.instancehelper_equals(n.getIdentifier(), "record") && !validUsage(n))
		{
			arg.report(n, error);
		}
		base.visit(n, arg);
	}

	
	
	
	public virtual void visit(Name n, ProblemReporter arg)
	{
		if (String.instancehelper_equals(n.getIdentifier(), "record") && !validUsage(n))
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
