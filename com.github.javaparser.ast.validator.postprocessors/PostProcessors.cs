

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.validator.postprocessors;

public class PostProcessors
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly ParseResult arg_00241;

		private readonly ParserConfiguration arg_00242;

		internal ___003C_003EAnon0(ParseResult P_0, ParserConfiguration P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024postProcess_00240(arg_00241, arg_00242, (Processor)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
		private List postProcessors;

	
	
	
	public virtual PostProcessors remove(Processor postProcessor)
	{
		if (!postProcessors.remove(postProcessor))
		{
			
			throw new AssertionError("Trying to remove a post processor that isn't there.");
		}
		return this;
	}

	
	
	
	public virtual PostProcessors add(Processor newProcessor)
	{
		postProcessors.add(newProcessor);
		return this;
	}

	
	
	
	
	private static void lambda_0024postProcess_00240(ParseResult result, ParserConfiguration configuration, Processor pp)
	{
		pp.postProcess(result, configuration);
	}

	
	
	
	public PostProcessors(params Processor[] postProcessors)
	{
		this.postProcessors = new ArrayList();
		this.postProcessors.addAll(Arrays.asList(postProcessors));
	}

		public virtual List getPostProcessors()
	{
		return postProcessors;
	}

	
	
	
	public virtual PostProcessors replace(Processor oldProcessor, Processor newProcessor)
	{
		remove(oldProcessor);
		add(newProcessor);
		return this;
	}

	
		
	
	public virtual void postProcess(ParseResult result, ParserConfiguration configuration)
	{
		postProcessors.forEach(new ___003C_003EAnon0(result, configuration));
	}
}
