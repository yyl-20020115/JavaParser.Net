using com.github.javaparser.ast;
using com.github.javaparser.printer.configuration;


namespace com.github.javaparser.printer;

public interface Printer
{
	virtual PrinterConfiguration getConfiguration();

	
	virtual Printer setConfiguration(PrinterConfiguration configuration);

	
	virtual string print(Node node);
}
