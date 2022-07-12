
using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;
using com.github.javaparser.printer.concretesyntaxmodel;

using java.lang;
using java.util;

namespace com.github.javaparser.printer.lexicalpreservation.changes;

public class ListReplacementChange: Change
{
	
	private ObservableProperty observableProperty;

	
	private int index;

	
	private Node newValue;

	
	
	
	public ListReplacementChange(ObservableProperty observableProperty, int index, Node newValue)
	{
		this.observableProperty = observableProperty;
		this.index = index;
		this.newValue = newValue;
	}

	
	
	
	public virtual object getValue(ObservableProperty property, Node node)
	{
		if (property == observableProperty)
		{
			object obj = new NoChange().getValue(property, node);
			if (obj is Optional)
			{
				Optional optional = (Optional)obj;
				obj = optional.orElse(null);
			}
			if (!(obj is NodeList))
			{
				string s = new StringBuilder().append("Expected NodeList, found ").append(Object.instancehelper_getClass(obj).getCanonicalName()).ToString();
				
				throw new IllegalStateException(s);
			}
			NodeList nodeList = (NodeList)obj;
			NodeList nodeList2 = new NodeList();
			nodeList2.setParentNode(nodeList.getParentNodeForChildren());
			nodeList2.addAll(nodeList);
			nodeList2.set(index, newValue);
			return nodeList2;
		}
		object value = new NoChange().getValue(property, node);
		
		return value;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool evaluate(CsmConditional P_0, Node P_1)
	{
		return Change._003Cdefault_003Eevaluate(this, P_0, P_1);
	}
}
