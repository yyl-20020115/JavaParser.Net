
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;

using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmChar: CsmElement
{
	
	private ObservableProperty property;

	
	
	
	public CsmChar(ObservableProperty property)
	{
		this.property = property;
	}

	public virtual ObservableProperty getProperty()
	{
		return property;
	}

	
	
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		printer.print("'");
		printer.print(property.getValueAsStringAttribute(node));
		printer.print("'");
	}

	
	
	public override string ToString()
	{
		string result = String.format("%s(property:%s)", Object.instancehelper_getClass(this).getSimpleName(), getProperty());
		
		return result;
	}
}
