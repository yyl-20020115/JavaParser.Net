using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser;

public class Processor
{
	
	
	public Processor()
	{
	}

		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void postProcess(ParseResult result, ParserConfiguration configuration)
	{
	}

	
	public virtual Provider preProcess(Provider innerProvider)
	{
		return innerProvider;
	}
}
