using System.Collections;
using System.ComponentModel;

using com.github.javaparser.ast.observer;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;

using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast;


public class NodeList: List, Collection, Iterable, IEnumerable, HasParentNode, com.github.javaparser.ast.observer.Observable, Visitable
{
	[InnerClass(null, Modifiers.Protected)]
		
	public class NodeListIterator: ListIterator, Iterator
	{
				internal ListIterator iterator;

				internal Node current;

		
		internal NodeList this_00240;

		
				
		
		public virtual void add(Node n)
		{
			access_0024400(this_00240, access_0024000(this_00240).size(), n);
			access_0024500(this_00240, n);
			iterator.add(n);
		}

		
				
		
		public virtual void set(Node n)
		{
			int num = access_0024000(this_00240).indexOf(current);
			if (num < 0 || num >= access_0024000(this_00240).size())
			{
				string s = new StringBuilder().append("Illegal index. The index should be between 0 and ").append(access_0024000(this_00240).size()).append(" excluded. It is instead ")
					.append(num)
					.ToString();
				
				throw new IllegalArgumentException(s);
			}
			if (n != access_0024000(this_00240).get(num))
			{
				access_0024200(this_00240, num, n);
				((Node)access_0024000(this_00240).get(num)).setParentNode(null);
				access_0024300(this_00240, n);
				iterator.set(n);
			}
		}

		
				
		public virtual Node previous()
		{
			current = (Node)iterator.previous();
			return current;
		}

		
				
		public virtual Node next()
		{
			current = (Node)iterator.next();
			return current;
		}

		
				
		
		public NodeListIterator(NodeList this_00240, List list)
		{
			this.this_00240 = this_00240;
			
			current = null;
			iterator = list.listIterator();
		}

		
				
		
		public NodeListIterator(NodeList this_00240, List list, int index)
		{
			this.this_00240 = this_00240;
			
			current = null;
			iterator = list.listIterator(index);
		}

		
		
		public virtual bool hasNext()
		{
			bool result = iterator.hasNext();
			
			return result;
		}

		
		
		public virtual bool hasPrevious()
		{
			bool result = iterator.hasPrevious();
			
			return result;
		}

		
		
		public virtual int nextIndex()
		{
			int result = iterator.nextIndex();
			
			return result;
		}

		
		
		public virtual int previousIndex()
		{
			int result = iterator.previousIndex();
			
			return result;
		}

		
		
		public virtual void remove()
		{
			int num = access_0024000(this_00240).indexOf(current);
			if (num != -1)
			{
				access_0024100(this_00240, num, current);
				current.setParentNode(null);
			}
			iterator.remove();
		}

		
				
		
		public virtual void forEachRemaining(Consumer action)
		{
			iterator.forEachRemaining(action);
		}

		
		
		
		
		
		public virtual void add(object n)
		{
			add((Node)n);
		}

		
		
		
		
		
		public virtual void set(object n)
		{
			set((Node)n);
		}

		
		
		
		
		public virtual object _003Cbridge_003Eprevious()
		{
			Node result = previous();
			
			return result;
		}

		
		
		
		
		public virtual object _003Cbridge_003Enext()
		{
			Node result = next();
			
			return result;
		}

		object ListIterator_003A_003Anext()
		{
			return _003Cbridge_003Enext();
		}

		object ListIterator_003A_003Aprevious()
		{
			return _003Cbridge_003Eprevious();
		}

		object Iterator.Iterator_003A_003Anext()
		{
			return _003Cbridge_003Enext();
		}
	}

	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly NodeList arg_00241;

		internal ___003C_003EAnon0(NodeList P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add((Node)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly Collection arg_00241;

		internal ___003C_003EAnon1(Collection P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024retainAll_00240(arg_00241, (Node)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly NodeList arg_00241;

		private readonly int arg_00242;

		private readonly Node arg_00243;

		internal ___003C_003EAnon2(NodeList P_0, int P_1, Node P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024notifyElementAdded_00241(arg_00242, arg_00243, (AstObserver)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly NodeList arg_00241;

		private readonly int arg_00242;

		private readonly Node arg_00243;

		internal ___003C_003EAnon3(NodeList P_0, int P_1, Node P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024notifyElementRemoved_00242(arg_00242, arg_00243, (AstObserver)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly NodeList arg_00241;

		private readonly int arg_00242;

		private readonly Node arg_00243;

		internal ___003C_003EAnon4(NodeList P_0, int P_1, Node P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024notifyElementReplaced_00243(arg_00242, arg_00243, (AstObserver)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon5 : Supplier
	{
		internal ___003C_003EAnon5()
		{
		}

		public object get()
		{
			NodeList result = new NodeList();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : BiConsumer
	{
		internal ___003C_003EAnon6()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((NodeList)P_0).add((Node)P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : BinaryOperator
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0, object P_1)
		{
			NodeList result = lambda_0024toNodeList_00244((NodeList)P_0, (NodeList)P_1);
			
			return result;
		}

		
		public BiFunction andThen(Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon8 : Function
	{
		internal ___003C_003EAnon8()
		{
		}

		public object apply(object P_0)
		{
			string result = ((Node)P_0).ToString();
			
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

	
		[InternalProperty(new object[]
	{
		(byte)64,
		"Lcom/github/javaparser/metamodel/InternalProperty;"
	})]
	private List innerList;

	private Node parentNode;

	
		private List observers;

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Stream stream()
	{
		return Collection._003Cdefault_003Estream(this);
	}

	
		
	public static Collector toNodeList()
	{
		Collector result = Collector.of(new ___003C_003EAnon5(), new ___003C_003EAnon6(), new ___003C_003EAnon7());
		
		return result;
	}

	
		
	
	public virtual bool replace(Node old, Node replacement)
	{
		int num = indexOf(old);
		if (num == -1)
		{
			return false;
		}
		set(num, replacement);
		return true;
	}

	
	
	public virtual int size()
	{
		int result = innerList.size();
		
		return result;
	}

	
		
	
	public virtual NodeList addFirst(Node node)
	{
		add(0, node);
		return this;
	}

	
	
	public virtual void clear()
	{
		while (!isEmpty())
		{
			remove(0);
		}
	}

	
		
	public virtual Iterator iterator()
	{
		NodeListIterator result = new NodeListIterator(this, innerList);
		
		return result;
	}

	
		
	
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public NodeList(params Node[] n)
	{
		innerList = new java.util.ArrayList(0);
		observers = new java.util.ArrayList();
		addAll(Arrays.asList(n));
	}

	
		
	
	public virtual bool add(Node node)
	{
		notifyElementAdded(innerList.size(), node);
		own(node);
		bool result = innerList.add(node);
		
		return result;
	}

	
	
	public virtual bool isNonEmpty()
	{
		return (!isEmpty()) ? true : false;
	}

	
		
	
	public virtual void forEach(Consumer action)
	{
		innerList.forEach(action);
	}

	
		
	
	public virtual NodeList setParentNode(Node parentNode)
	{
		this.parentNode = parentNode;
		setAsParentNodeOf(innerList);
		return this;
	}

	
	
	
	public virtual void register(AstObserver observer)
	{
		if (!observers.contains(observer))
		{
			observers.add(observer);
		}
	}

	
		
	
	public virtual Node get(int i)
	{
		return (Node)innerList.get(i);
	}

	
		
	
	public virtual Node set(int index, Node element)
	{
		if (index < 0 || index >= innerList.size())
		{
			string s = new StringBuilder().append("Illegal index. The index should be between 0 and ").append(innerList.size()).append(" excluded. It is instead ")
				.append(index)
				.ToString();
			
			throw new IllegalArgumentException(s);
		}
		if (element == innerList.get(index))
		{
			return element;
		}
		notifyElementReplaced(index, element);
		((Node)innerList.get(index)).setParentNode(null);
		setAsParentNodeOf(element);
		return (Node)innerList.set(index, element);
	}

	
	
	public NodeList()
	{
		innerList = new java.util.ArrayList(0);
		observers = new java.util.ArrayList();
		parentNode = null;
	}

	
		
	
	public virtual Node remove(int index)
	{
		notifyElementRemoved(index, (Node)innerList.get(index));
		Node node = (Node)innerList.remove(index);
		node?.setParentNode(null);
		return node;
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = innerList.isEmpty();
		
		return result;
	}

	
		
	
	public NodeList(Collection n)
	{
		innerList = new java.util.ArrayList(0);
		observers = new java.util.ArrayList();
		addAll(n);
	}

	
		
	public virtual Optional getLast()
	{
		if (isEmpty())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional result2 = Optional.of(get(size() - 1));
		
		return result2;
	}

	
		
	
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static NodeList nodeList(params Node[] nodes)
	{
		NodeList nodeList = new NodeList();
		Collections.addAll(nodeList, nodes);
		return nodeList;
	}

	
	
	
	public virtual int indexOf(object o)
	{
		int result = innerList.indexOf(o);
		
		return result;
	}

	
		
	
	public virtual bool removeIf(Predicate filter)
	{
		int num = 0;
		object[] array = stream().filter(filter).toArray();
		int num2 = array.Length;
		for (int i = 0; i < num2; i++)
		{
			object o = array[i];
			num = ((remove(o) || num != 0) ? 1 : 0);
		}
		return (byte)num != 0;
	}

	
		
	
	public virtual void addAll(NodeList otherList)
	{
		Iterator iterator = otherList.iterator();
		while (iterator.hasNext())
		{
			Node node = (Node)iterator.next();
			add(node);
		}
	}

	
	
	internal static List access_0024000(NodeList P_0)
	{
		return P_0.innerList;
	}

	
	
	
	internal static void access_0024100(NodeList P_0, int P_1, Node P_2)
	{
		P_0.notifyElementRemoved(P_1, P_2);
	}

	
	
	
	internal static void access_0024200(NodeList P_0, int P_1, Node P_2)
	{
		P_0.notifyElementReplaced(P_1, P_2);
	}

	
	
	
	internal static void access_0024300(NodeList P_0, Node P_1)
	{
		P_0.setAsParentNodeOf(P_1);
	}

	
	
	
	internal static void access_0024400(NodeList P_0, int P_1, Node P_2)
	{
		P_0.notifyElementAdded(P_1, P_2);
	}

	
	
	
	internal static void access_0024500(NodeList P_0, Node P_1)
	{
		P_0.own(P_1);
	}

	
		
	
	private void own(Node node)
	{
		if (node != null)
		{
			setAsParentNodeOf(node);
		}
	}

	
	
	
	private void notifyElementAdded(int index, Node nodeAddedOrRemoved)
	{
		observers.forEach(new ___003C_003EAnon2(this, index, nodeAddedOrRemoved));
	}

	
	
	
	private void setAsParentNodeOf(Node childNode)
	{
		childNode?.setParentNode(getParentNodeForChildren());
	}

	
	
	
	private void notifyElementReplaced(int index, Node nodeAddedOrRemoved)
	{
		observers.forEach(new ___003C_003EAnon4(this, index, nodeAddedOrRemoved));
	}

	
	
	
	private void notifyElementRemoved(int index, Node nodeAddedOrRemoved)
	{
		observers.forEach(new ___003C_003EAnon3(this, index, nodeAddedOrRemoved));
	}

	
		
	
	public virtual bool addAll(Collection c)
	{
		c.forEach(new ___003C_003EAnon0(this));
		return (!c.isEmpty()) ? true : false;
	}

	
		
	
	public virtual void add(int index, Node node)
	{
		notifyElementAdded(index, node);
		own(node);
		innerList.add(index, node);
	}

	
		
	
	private void setAsParentNodeOf(List childNodes)
	{
		if (childNodes != null)
		{
			Iterator iterator = childNodes.iterator();
			while (iterator.hasNext())
			{
				HasParentNode hasParentNode = (HasParentNode)iterator.next();
				hasParentNode.setParentNode(getParentNodeForChildren());
			}
		}
	}

	
	
	
	public virtual bool remove(Node node)
	{
		int num = innerList.indexOf(node);
		if (num != -1)
		{
			notifyElementRemoved(num, node);
			node.setParentNode(null);
		}
		bool result = innerList.remove(node);
		
		return result;
	}

	
	
	
	public virtual bool remove(object o)
	{
		if (o is Node)
		{
			bool result = remove((Node)o);
			
			return result;
		}
		return false;
	}

	public virtual Node getParentNodeForChildren()
	{
		return parentNode;
	}

	
	
	
	
	private static bool lambda_0024retainAll_00240(Collection c, Node it)
	{
		return (!c.contains(it)) ? true : false;
	}

	
	
	
	
	private void lambda_0024notifyElementAdded_00241(int index, Node nodeAddedOrRemoved, AstObserver o)
	{
		o.listChange(this, AstObserver.ListChangeType.___003C_003EADDITION, index, nodeAddedOrRemoved);
	}

	
	
	
	
	private void lambda_0024notifyElementRemoved_00242(int index, Node nodeAddedOrRemoved, AstObserver o)
	{
		o.listChange(this, AstObserver.ListChangeType.___003C_003EREMOVAL, index, nodeAddedOrRemoved);
	}

	
	
	
	
	private void lambda_0024notifyElementReplaced_00243(int index, Node nodeAddedOrRemoved, AstObserver o)
	{
		o.listReplacement(this, index, get(index), nodeAddedOrRemoved);
	}

	
	
	
	
	private static NodeList lambda_0024toNodeList_00244(NodeList left, NodeList right)
	{
		left.addAll(right);
		return left;
	}

	
		
	public virtual Node removeFirst()
	{
		Node result = remove(0);
		
		return result;
	}

	
		
	public virtual Node removeLast()
	{
		Node result = remove(innerList.size() - 1);
		
		return result;
	}

	
		
	
	public static NodeList nodeList(Collection nodes)
	{
		NodeList nodeList = new NodeList();
		nodeList.addAll(nodes);
		return nodeList;
	}

	
		
	
	public static NodeList nodeList(NodeList nodes)
	{
		NodeList nodeList = new NodeList();
		nodeList.addAll(nodes);
		return nodeList;
	}

	
		
	
	public virtual bool contains(Node node)
	{
		bool result = innerList.contains(node);
		
		return result;
	}

	
		
	
	public virtual void sort(Comparator comparator)
	{
		innerList.sort(comparator);
	}

	
		
	
	public virtual NodeList addLast(Node node)
	{
		add(node);
		return this;
	}

	
		
	
	public virtual NodeList addAfter(Node node, Node afterThisNode)
	{
		int num = indexOf(afterThisNode);
		if (num == -1)
		{
			
			throw new IllegalArgumentException("Can't find node to insert after.");
		}
		add(num + 1, node);
		return this;
	}

	
		
	
	public virtual NodeList addBefore(Node node, Node beforeThisNode)
	{
		int num = indexOf(beforeThisNode);
		if (num == -1)
		{
			
			throw new IllegalArgumentException("Can't find node to insert before.");
		}
		add(num, node);
		return this;
	}

	
		
	public virtual Optional getFirst()
	{
		if (isEmpty())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Optional result2 = Optional.of(get(0));
		
		return result2;
	}

	
		
	public virtual Optional getParentNode()
	{
		Optional result = Optional.ofNullable(parentNode);
		
		return result;
	}

	
		
	
	public virtual object accept(GenericVisitor v, object arg)
	{
		object result = v.visit(this, arg);
		
		return result;
	}

	
		
	
	public virtual void accept(VoidVisitor v, object arg)
	{
		v.visit(this, arg);
	}

	
	
	
	public virtual bool contains(object o)
	{
		bool result = innerList.contains(o);
		
		return result;
	}

	
	
	public virtual object[] toArray()
	{
		object[] result = innerList.toArray();
		
		return result;
	}

	
		
	
	public virtual object[] toArray(object[] a)
	{
		object[] result = innerList.toArray(a);
		
		return result;
	}

	
		
	
	public virtual bool containsAll(Collection c)
	{
		bool result = innerList.containsAll(c);
		
		return result;
	}

	
		
	
	public virtual bool addAll(int index, Collection c)
	{
		Iterator iterator = c.iterator();
		while (iterator.hasNext())
		{
			Node node = (Node)iterator.next();
			int index2 = index;
			index++;
			add(index2, node);
		}
		return (!c.isEmpty()) ? true : false;
	}

	
		
	
	public virtual bool removeAll(Collection c)
	{
		int num = 0;
		Iterator iterator = c.iterator();
		while (iterator.hasNext())
		{
			object o = iterator.next();
			num = ((remove(o) || num != 0) ? 1 : 0);
		}
		return (byte)num != 0;
	}

	
		
	
	public virtual bool retainAll(Collection c)
	{
		int num = 0;
		object[] array = stream().filter(new ___003C_003EAnon1(c)).toArray();
		int num2 = array.Length;
		for (int i = 0; i < num2; i++)
		{
			object o = array[i];
			if (!c.contains(o))
			{
				num = ((remove(o) || num != 0) ? 1 : 0);
			}
		}
		return (byte)num != 0;
	}

	
		
	
	public virtual void replaceAll(UnaryOperator @operator)
	{
		for (int i = 0; i < size(); i++)
		{
			set(i, (Node)@operator.apply(get(i)));
		}
	}

	
	
	
	public override bool Equals(object o)
	{
		bool result = innerList.equals(o);
		
		return result;
	}

	
	
	public override int GetHashCode()
	{
		int result = innerList.GetHashCode();
		
		return result;
	}

	
	
	
	public virtual int lastIndexOf(object o)
	{
		int result = innerList.lastIndexOf(o);
		
		return result;
	}

	
		
	public virtual ListIterator listIterator()
	{
		NodeListIterator result = new NodeListIterator(this, innerList);
		
		return result;
	}

	
		
	
	public virtual ListIterator listIterator(int index)
	{
		NodeListIterator result = new NodeListIterator(this, innerList, index);
		
		return result;
	}

	
		
	public virtual Stream parallelStream()
	{
		Stream result = innerList.parallelStream();
		
		return result;
	}

	
		
	
	public virtual List subList(int fromIndex, int toIndex)
	{
		List result = innerList.subList(fromIndex, toIndex);
		
		return result;
	}

	
		
	public virtual Spliterator spliterator()
	{
		Spliterator result = innerList.spliterator();
		
		return result;
	}

	
	
	
	public virtual void unregister(AstObserver observer)
	{
		observers.remove(observer);
	}

	
	
	
	public virtual bool isRegistered(AstObserver observer)
	{
		bool result = observers.contains(observer);
		
		return result;
	}

	
		
	
	public virtual void ifNonEmpty(Consumer consumer)
	{
		if (isNonEmpty())
		{
			consumer.accept(this);
		}
	}

	
	
	public override string ToString()
	{
		Stream obj = innerList.stream().map(new ___003C_003EAnon8());
		object __003Cref_003E = "]";
		object __003Cref_003E2 = "[";
		CharSequence charSequence = default(CharSequence);
		object obj2 = (charSequence.___003Cref_003E = ", ");
		CharSequence delimiter = charSequence;
		obj2 = (charSequence.___003Cref_003E = __003Cref_003E2);
		CharSequence prefix = charSequence;
		obj2 = (charSequence.___003Cref_003E = __003Cref_003E);
		return (string)obj.collect(Collectors.joining(delimiter, prefix, charSequence));
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Eremove(int index)
	{
		Node result = remove(index);
		
		return result;
	}

	
	
	
	
	
	public virtual void add(int index, object node)
	{
		add(index, (Node)node);
	}

	
	
	
	
	
	public virtual object set(int index, object element)
	{
		Node result = set(index, (Node)element);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Eget(int i)
	{
		Node result = get(i);
		
		return result;
	}

	
	
	
	
	
	public virtual bool add(object node)
	{
		bool result = add((Node)node);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003EsetParentNode(Node parentNode)
	{
		NodeList result = setParentNode(parentNode);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool hasParentNode()
	{
		return HasParentNode._003Cdefault_003EhasParentNode(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional findAncestor(Class[] P_0)
	{
		return HasParentNode._003Cdefault_003EfindAncestor(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional findAncestor(Class P_0, Predicate P_1)
	{
		return HasParentNode._003Cdefault_003EfindAncestor(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Optional findAncestor(Predicate P_0, Class[] P_1)
	{
		return HasParentNode._003Cdefault_003EfindAncestor(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool isDescendantOf(Node P_0)
	{
		return HasParentNode._003Cdefault_003EisDescendantOf(this, P_0);
	}

	
	
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	object List.List_003A_003Aget(int P_0)
	{
		return _003Cbridge_003Eget(P_0);
	}

	object List.List_003A_003Aremove(int P_0)
	{
		return _003Cbridge_003Eremove(P_0);
	}

	object HasParentNode.HasParentNode_003A_003AsetParentNode(Node P_0)
	{
		return _003Cbridge_003EsetParentNode(P_0);
	}
}
