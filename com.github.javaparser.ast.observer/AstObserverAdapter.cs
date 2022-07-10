using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.ast.observer;

public abstract class AstObserverAdapter : AstObserver
{
	
	
	public AstObserverAdapter()
	{
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void propertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
	{
	}

	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void parentChange(Node observedNode, Node previousParent, Node newParent)
	{
	}

		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void listChange(NodeList observedNode, AstObserver.ListChangeType type, int index, Node nodeAddedOrRemoved)
	{
	}

		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void listReplacement(NodeList observedNode, int index, Node oldNode, Node newNode)
	{
	}
}
