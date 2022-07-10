using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmSingleReference: CsmElement
{
	
	private ObservableProperty property;

	
	
	
	public CsmSingleReference(ObservableProperty property)
	{
		this.property = property;
	}

	public virtual ObservableProperty getProperty()
	{
		return property;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		Node valueAsSingleReference = property.getValueAsSingleReference(node);
		if (valueAsSingleReference != null)
		{
			ConcreteSyntaxModel.genericPrettyPrint(valueAsSingleReference, printer);
		}
	}

	
	
	public override string ToString()
	{
		string result = String.format("%s(property:%s)", Object.instancehelper_getClass(this).getSimpleName(), getProperty());
		
		return result;
	}
}
