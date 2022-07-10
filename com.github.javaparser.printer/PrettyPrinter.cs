using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.printer.configuration;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.printer;


[Deprecated(new object[]
{
	(byte)64,
	"Ljava/lang/Deprecated;"
})]
public class PrettyPrinter :  Printer
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			VoidVisitor result = new PrettyPrintVisitor((PrettyPrinterConfiguration)P_0);
			
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

		private Function visitorFactory;

	
	
	
	public PrettyPrinter(PrettyPrinterConfiguration configuration)
		: this(configuration, new ___003C_003EAnon0())
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public PrettyPrinter(PrettyPrinterConfiguration configuration, Function visitorFactory)
	{
		this.configuration = configuration;
		this.visitorFactory = visitorFactory;
	}

	
	
	public PrettyPrinter()
		: this(new PrettyPrinterConfiguration())
	{
	}

	public virtual PrinterConfiguration getConfiguration()
	{
		return configuration;
	}

	
	
	
	public virtual Printer setConfiguration(PrinterConfiguration configuration)
	{
		if (!(configuration is PrettyPrinterConfiguration))
		{
			
			throw new IllegalArgumentException("PrettyPrinter must be configured with a PrettyPrinterConfiguration class");
		}
		this.configuration = configuration;
		return this;
	}

	
	
	
	public virtual string print(Node node)
	{
		VoidVisitor voidVisitor = (VoidVisitor)visitorFactory.apply((PrettyPrinterConfiguration)configuration);
		node.accept(voidVisitor, null);
		string result = java.lang.Object.instancehelper_toString(voidVisitor);
		
		return result;
	}
}
