

using java.lang;

namespace com.github.javaparser.ast.observer;

public abstract class AstObserverAdapter : AstObserver
{
	
	
	public AstObserverAdapter()
	{
	}

	
	public virtual void propertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
	{
	}

	
	public virtual void parentChange(Node observedNode, Node previousParent, Node newParent)
	{
	}

		
	public virtual void listChange(NodeList observedNode, AstObserver.ListChangeType type, int index, Node nodeAddedOrRemoved)
	{
	}

		
	public virtual void listReplacement(NodeList observedNode, int index, Node oldNode, Node newNode)
	{
	}
}
