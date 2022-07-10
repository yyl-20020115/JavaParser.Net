using System.Runtime.CompilerServices;
using com.github.javaparser.ast.comments;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser;

public class ParseResult
{
	
		private object result;

	
		private List problems;

	
	private CommentsCollection commentsCollection;

	
		
	public virtual Optional getResult()
	{
		Optional optional = Optional.ofNullable(result);
		
		return optional;
	}

		public virtual List getProblems()
	{
		return problems;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public ParseResult(object result, List problems, CommentsCollection commentsCollection)
	{
		this.commentsCollection = commentsCollection;
		this.result = result;
		this.problems = problems;
	}

	
		
	
	public virtual void ifSuccessful(Consumer consumer)
	{
		if (isSuccessful())
		{
			consumer.accept(result);
		}
	}

	
		
	public virtual Optional getCommentsCollection()
	{
		Optional optional = Optional.ofNullable(commentsCollection);
		
		return optional;
	}

	
	
	public virtual bool isSuccessful()
	{
		return (problems.isEmpty() && result != null) ? true : false;
	}

	
	
	
	public virtual Problem getProblem(int i)
	{
		return (Problem)getProblems().get(i);
	}

	
	
	public override string ToString()
	{
		if (isSuccessful())
		{
			return "Parsing successful";
		}
		StringBuilder stringBuilder = new StringBuilder("Parsing failed:").append(Utils.___003C_003ESYSTEM_EOL);
		Iterator iterator = problems.iterator();
		while (iterator.hasNext())
		{
			Problem problem = (Problem)iterator.next();
			stringBuilder.append(problem.ToString()).append(Utils.___003C_003ESYSTEM_EOL);
		}
		string text = stringBuilder.ToString();
		
		return text;
	}
}
