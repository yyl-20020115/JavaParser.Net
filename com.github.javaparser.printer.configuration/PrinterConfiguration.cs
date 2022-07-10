using IKVM.Attributes;
using java.util;

namespace com.github.javaparser.printer.configuration;

public interface PrinterConfiguration
{
	
	virtual PrinterConfiguration addOption(ConfigurationOption option);

	
	virtual PrinterConfiguration removeOption(ConfigurationOption option);

	
	virtual bool isActivated(ConfigurationOption option);

		
	virtual Optional get(ConfigurationOption option);

		virtual Set get();
}
