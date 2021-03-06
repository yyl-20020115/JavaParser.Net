
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.utils;

using java.lang;
using java.util.function;

namespace com.github.javaparser.ast.validator;

public class ProblemReporter
{
	
		private Consumer problemConsumer;

	
		
	
	public virtual void report(NodeWithTokenRange node, string message, params object[] args)
	{
		report((TokenRange)node.getTokenRange().orElse(null), message, args);
	}

	
	
	
	public virtual void report(TokenRange range, string message, params object[] args)
	{
		Consumer consumer = problemConsumer;
		Problem.___003Cclinit_003E();
		consumer.accept(new Problem(CodeGenerationUtils.f(message, args), range, null));
	}

	
		
	
	public ProblemReporter(Consumer problemConsumer)
	{
		this.problemConsumer = problemConsumer;
	}
}
