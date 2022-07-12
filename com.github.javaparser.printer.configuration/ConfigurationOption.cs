
using java.lang;

namespace com.github.javaparser.printer.configuration;

public interface ConfigurationOption
{
	
	virtual ConfigurationOption value(object value);

	virtual bool hasValue();

	virtual Integer asInteger();

	virtual string asString();

	virtual Boolean asBoolean();

		virtual object asValue();
}
