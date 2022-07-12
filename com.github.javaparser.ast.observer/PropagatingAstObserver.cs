

using java.lang;

namespace com.github.javaparser.ast.observer;

public abstract class PropagatingAstObserver: AstObserver
{
	
	[EnclosingMethod(null, "transformInPropagatingObserver", "(Lcom.github.javaparser.ast.observer.AstObserver;)Lcom.github.javaparser.ast.observer.PropagatingAstObserver;")]
	internal sealed class _1 : PropagatingAstObserver
	{
		
		internal AstObserver val_0024observer;

		
		
		
		internal _1(AstObserver val_0024observer)
		{
			this.val_0024observer = val_0024observer;
			
		}

		
		
		
		public override void concretePropertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
		{
			val_0024observer.propertyChange(observedNode, property, oldValue, newValue);
		}

		
				
		
		public override void concreteListChange(NodeList observedNode, AstObserver.ListChangeType type, int index, Node nodeAddedOrRemoved)
		{
			val_0024observer.listChange(observedNode, type, index, nodeAddedOrRemoved);
		}

		
		
		
		public override void parentChange(Node observedNode, Node previousParent, Node newParent)
		{
			val_0024observer.parentChange(observedNode, previousParent, newParent);
		}
	}

	
	
	
	public static PropagatingAstObserver transformInPropagatingObserver(AstObserver observer)
	{
		if (observer is PropagatingAstObserver)
		{
			return (PropagatingAstObserver)observer;
		}
		_1 result = new _1(observer);
		
		return result;
	}

	
	
	
	private void considerRemoving(object element)
	{
		if (element is Observable && ((Observable)element).isRegistered(this))
		{
			((Observable)element).unregister(this);
		}
	}

	
	
	
	private void considerAdding(object element)
	{
		if (element is Node)
		{
			((Node)element).registerForSubtree(this);
		}
		else if (element is Observable)
		{
			((Observable)element).register(this);
		}
	}

	
	public virtual void concretePropertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
	{
	}

		
	public virtual void concreteListChange(NodeList observedNode, AstObserver.ListChangeType type, int index, Node nodeAddedOrRemoved)
	{
	}

		
	public virtual void concreteListReplacement(NodeList observedNode, int index, Node oldValue, Node newValue)
	{
	}

	
	
	public PropagatingAstObserver()
	{
	}

	
	
	
	public void propertyChange(Node observedNode, ObservableProperty property, object oldValue, object newValue)
	{
		considerRemoving(oldValue);
		considerAdding(newValue);
		concretePropertyChange(observedNode, property, oldValue, newValue);
	}

	
		
	
	public void listChange(NodeList observedNode, AstObserver.ListChangeType type, int index, Node nodeAddedOrRemoved)
	{
		if (type == AstObserver.ListChangeType.___003C_003EREMOVAL)
		{
			considerRemoving(nodeAddedOrRemoved);
		}
		else if (type == AstObserver.ListChangeType.___003C_003EADDITION)
		{
			considerAdding(nodeAddedOrRemoved);
		}
		concreteListChange(observedNode, type, index, nodeAddedOrRemoved);
	}

	
		
	
	public virtual void listReplacement(NodeList observedNode, int index, Node oldNode, Node newNode)
	{
		if (oldNode != newNode)
		{
			considerRemoving(oldNode);
			considerAdding(newNode);
			concreteListReplacement(observedNode, index, oldNode, newNode);
		}
	}

	
	public virtual void parentChange(Node observedNode, Node previousParent, Node newParent)
	{
	}
}
