using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.printer.configuration;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.printer;

public class DefaultPrettyPrinter: Printer
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			VoidVisitor result = lambda_0024createDefaultVisitor_00240((PrinterConfiguration)P_0);
			
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	private PrinterConfiguration configuration;

		internal Function visitorFactory;

	
	
	
	public DefaultPrettyPrinter(PrinterConfiguration configuration)
		: this(createDefaultVisitor(configuration), configuration)
	{
	}

	
	
	private static PrinterConfiguration createDefaultConfiguration()
	{
		DefaultPrinterConfiguration result = new DefaultPrinterConfiguration();
		
		return result;
	}

	
		
	
	private static Function createDefaultVisitor(PrinterConfiguration configuration)
	{
		return new ___003C_003EAnon0();
	}

	
		
	private static Function createDefaultVisitor()
	{
		PrinterConfiguration printerConfiguration = createDefaultConfiguration();
		Function result = createDefaultVisitor(printerConfiguration);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public DefaultPrettyPrinter(Function visitorFactory, PrinterConfiguration configuration)
	{
		this.configuration = configuration;
		this.visitorFactory = visitorFactory;
	}

	
	
	
	
	private static VoidVisitor lambda_0024createDefaultVisitor_00240(PrinterConfiguration config)
	{
		DefaultPrettyPrinterVisitor result = new DefaultPrettyPrinterVisitor(config, new SourcePrinter(config));
		
		return result;
	}

	
	
	public DefaultPrettyPrinter()
		: this(createDefaultVisitor(), createDefaultConfiguration())
	{
	}

	public virtual PrinterConfiguration getConfiguration()
	{
		return configuration;
	}

	
	public virtual Printer setConfiguration(PrinterConfiguration configuration)
	{
		this.configuration = configuration;
		return this;
	}

	
	
	
	public virtual string print(Node node)
	{
		VoidVisitor voidVisitor = (VoidVisitor)visitorFactory.apply(configuration);
		node.accept(voidVisitor, null);
		string result = Object.instancehelper_toString(voidVisitor);
		
		return result;
	}
}
