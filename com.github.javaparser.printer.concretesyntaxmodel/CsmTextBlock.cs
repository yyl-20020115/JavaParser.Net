using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmTextBlock: CsmElement
{
	
	private ObservableProperty property;

	public virtual ObservableProperty getProperty()
	{
		return property;
	}

	
	
	
	public CsmTextBlock(ObservableProperty property)
	{
		this.property = property;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		printer.print("\"\"\"\n");
		printer.print(property.getValueAsStringAttribute(node));
		printer.print("\"\"\"");
	}

	
	
	public override string ToString()
	{
		string result = String.format("%s(property:%s)", Object.instancehelper_getClass(this).getSimpleName(), getProperty());
		
		return result;
	}
}
