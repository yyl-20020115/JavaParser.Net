
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;

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
