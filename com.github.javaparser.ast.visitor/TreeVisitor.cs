using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.visitor;

public abstract class TreeVisitor : Object
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly TreeVisitor arg_00241;

		internal ___003C_003EAnon0(TreeVisitor P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.visitPreOrder((Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly TreeVisitor arg_00241;

		internal ___003C_003EAnon1(TreeVisitor P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.visitPostOrder((Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly TreeVisitor arg_00241;

		internal ___003C_003EAnon2(TreeVisitor P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.process((Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	
	public virtual void visitLeavesFirst(Node node)
	{
		Iterator iterator = node.getChildNodes().iterator();
		while (iterator.hasNext())
		{
			Node node2 = (Node)iterator.next();
			visitLeavesFirst(node2);
		}
		process(node);
	}

	
	public abstract void process(Node node);

	
	
	
	public virtual void visitPreOrder(Node node)
	{
		process(node);
		
		new ArrayList(node.getChildNodes()).forEach(new ___003C_003EAnon0(this));
	}

	
	
	
	public virtual void visitPostOrder(Node node)
	{
		
		new ArrayList(node.getChildNodes()).forEach(new ___003C_003EAnon1(this));
		process(node);
	}

	
	
	public TreeVisitor()
	{
	}

	
	
	[LineNumberTable(new byte[]
	{
		24, 102, 104, 105, 108, 127, 1, 104, 98, 113,
		98
	})]
	public virtual void visitBreadthFirst(Node node)
	{
		LinkedList linkedList = new LinkedList();
		((Queue)linkedList).offer((object)node);
		while (((Collection)linkedList).size() > 0)
		{
			Node node2 = (Node)((Queue)linkedList).peek();
			Iterator iterator = node2.getChildNodes().iterator();
			while (iterator.hasNext())
			{
				Node e = (Node)iterator.next();
				((Queue)linkedList).offer((object)e);
			}
			process((Node)((Queue)linkedList).poll());
		}
	}

	
	
	
	public virtual void visitDirectChildren(Node node)
	{
		
		new ArrayList(node.getChildNodes()).forEach(new ___003C_003EAnon2(this));
	}
}
