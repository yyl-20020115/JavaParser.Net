

using java.lang;

namespace com.github.javaparser;

public class Processor
{
	
	
	public Processor()
	{
	}

		
	public virtual void postProcess(ParseResult result, ParserConfiguration configuration)
	{
	}

	
	public virtual Provider preProcess(Provider innerProvider)
	{
		return innerProvider;
	}
}
