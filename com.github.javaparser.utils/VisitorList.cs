using System.Collections;
using System.ComponentModel;

using com.github.javaparser.ast;
using com.github.javaparser.ast.visitor;

using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.utils;


public class VisitorList: List, Collection, Iterable, IEnumerable
{
	
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
	internal class _1: Iterator
	{
		
				internal Iterator itr;

		
		internal VisitorList this_00240;

		
				
		public virtual Node next()
		{
			Node result = EqualsHashcodeOverridingFacade.access_0024000((EqualsHashcodeOverridingFacade)itr.next());
			
			return result;
		}

		
		
		
		internal _1(VisitorList this_00240)
		{
			this.this_00240 = this_00240;
			
			itr = this.this_00240.innerList.iterator();
		}

		
		
		public virtual bool hasNext()
		{
			bool result = itr.hasNext();
			
			return result;
		}

		
		
		public virtual void remove()
		{
			itr.remove();
		}

		
		
		
		public virtual object next()
		{
			Node result = this.next();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	
		[EnclosingMethod(null, "listIterator", "(I)Ljava.util.ListIterator;")]
	
	internal class _2: ListIterator, Iterator
	{
		
				internal ListIterator itr;

		
		internal int val_0024index;

		
		internal VisitorList this_00240;

		
		
		
		internal _2(VisitorList this_00240, int val_0024index)
		{
			this.this_00240 = this_00240;
			this.val_0024index = val_0024index;
			
			itr = this.this_00240.innerList.listIterator(this.val_0024index);
		}

		
				
		
		public virtual void add(Node elem)
		{
			itr.add(new EqualsHashcodeOverridingFacade(this_00240, elem));
		}

		
				
		
		public virtual void set(Node elem)
		{
			itr.set(new EqualsHashcodeOverridingFacade(this_00240, elem));
		}

		
				
		public virtual Node previous()
		{
			Node result = EqualsHashcodeOverridingFacade.access_0024000((EqualsHashcodeOverridingFacade)itr.previous());
			
			return result;
		}

		
				
		public virtual Node next()
		{
			Node result = EqualsHashcodeOverridingFacade.access_0024000((EqualsHashcodeOverridingFacade)itr.next());
			
			return result;
		}

		
		
		public virtual bool hasNext()
		{
			bool result = itr.hasNext();
			
			return result;
		}

		
		
		public virtual void remove()
		{
			itr.remove();
		}

		
		
		public virtual bool hasPrevious()
		{
			bool result = itr.hasPrevious();
			
			return result;
		}

		
		
		public virtual int nextIndex()
		{
			int result = itr.nextIndex();
			
			return result;
		}

		
		
		public virtual int previousIndex()
		{
			int result = itr.previousIndex();
			
			return result;
		}

		
		
		
		
		public virtual void add(object elem)
		{
			add((Node)elem);
		}

		
		
		
		
		public virtual void set(object elem)
		{
			set((Node)elem);
		}

		
		
		
		public virtual object previous()
		{
			Node result = this.previous();
			
			return result;
		}

		
		
		
		public virtual object next()
		{
			Node result = this.next();
			
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	
		[EnclosingMethod(null, "subList", "(II)Ljava.util.List;")]
	internal class _3 : VisitorList
	{
		
		internal int val_0024fromIndex;

		
		internal int val_0024toIndex;

		
		internal VisitorList this_00240;

		
		
		
		internal _3(VisitorList this_00240, GenericVisitor hashcodeVisitor, GenericVisitor equalsVisitor, int val_0024toIndex, int val_0024fromIndex)
		{
			this.this_00240 = this_00240;
			this.val_0024fromIndex = val_0024toIndex;
			this.val_0024toIndex = val_0024fromIndex;
			base._002Ector(hashcodeVisitor, equalsVisitor);
			innerList = this.this_00240.innerList.subList(this.val_0024fromIndex, this.val_0024toIndex);
		}

		
		
		
		
		public new virtual object remove(int index)
		{
			Node result = base.remove(index);
			
			return result;
		}

		
		
		
		
		public override void add(int index, object elem)
		{
			base.add(index, (Node)elem);
		}

		
		
		
		
		public override object set(int index, object elem)
		{
			Node result = base.set(index, (Node)elem);
			
			return result;
		}

		
		
		
		
		public new virtual object get(int index)
		{
			Node result = base.get(index);
			
			return result;
		}

		
		
		
		
		public override bool add(object elem)
		{
			bool result = base.add((Node)elem);
			
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	internal class EqualsHashcodeOverridingFacade: Visitable
	{
		
				private Node overridden;

		
		internal VisitorList this_00240;

		
		
		internal static Node access_0024000(EqualsHashcodeOverridingFacade P_0)
		{
			return P_0.overridden;
		}

		
				
		
		internal EqualsHashcodeOverridingFacade(VisitorList this_00240, Node overridden)
		{
			this.this_00240 = this_00240;
			
			this.overridden = overridden;
		}

		
				
		
		public virtual object accept(GenericVisitor v, object arg)
		{
			
			throw new AssertionError();
		}

		
				
		
		public virtual void accept(VoidVisitor v, object arg)
		{
			
			throw new AssertionError();
		}

		
		
		public sealed override int GetHashCode()
		{
			int result = ((Integer)overridden.accept(this_00240.___003C_003EhashcodeVisitor, null)).intValue();
			
			return result;
		}

		
		
		
		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is EqualsHashcodeOverridingFacade))
			{
				return false;
			}
			bool result = ((Boolean)overridden.accept(this_00240.___003C_003EequalsVisitor, ((EqualsHashcodeOverridingFacade)obj).overridden)).booleanValue();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Node result = lambda_0024toArray_00240((EqualsHashcodeOverridingFacade)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Node result = lambda_0024toArray_00241((EqualsHashcodeOverridingFacade)P_0);
			
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

		protected internal List innerList;

		internal GenericVisitor ___003C_003EhashcodeVisitor;

		internal GenericVisitor ___003C_003EequalsVisitor;

	
	protected internal GenericVisitor hashcodeVisitor
	{
		
		get
		{
			return ___003C_003EhashcodeVisitor;
		}
		
		private set
		{
			___003C_003EhashcodeVisitor = value;
		}
	}

	
	protected internal GenericVisitor equalsVisitor
	{
		
		get
		{
			return ___003C_003EequalsVisitor;
		}
		
		private set
		{
			___003C_003EequalsVisitor = value;
		}
	}

	
		
	
	public virtual bool add(Node elem)
	{
		bool result = innerList.add(new EqualsHashcodeOverridingFacade(this, elem));
		
		return result;
	}

	
	
	public virtual int size()
	{
		int result = innerList.size();
		
		return result;
	}

	
		
	
	public virtual void add(int index, Node elem)
	{
		innerList.add(index, new EqualsHashcodeOverridingFacade(this, elem));
	}

	
	
	
	public virtual bool contains(object elem)
	{
		bool result = innerList.contains(new EqualsHashcodeOverridingFacade(this, (Node)elem));
		
		return result;
	}

	
		
	
	public virtual ListIterator listIterator(int index)
	{
		_2 result = new _2(this, index);
		
		return result;
	}

	
	
	
	public virtual bool remove(object elem)
	{
		bool result = innerList.remove(new EqualsHashcodeOverridingFacade(this, (Node)elem));
		
		return result;
	}

	
	
	public virtual void clear()
	{
		innerList.clear();
	}

	
		
	
	public virtual bool addAll(Collection col)
	{
		int result = 0;
		Iterator iterator = col.iterator();
		while (iterator.hasNext())
		{
			Node elem = (Node)iterator.next();
			if (add(elem))
			{
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	
		
	
	public virtual Node remove(int index)
	{
		Node result = EqualsHashcodeOverridingFacade.access_0024000((EqualsHashcodeOverridingFacade)innerList.remove(index));
		
		return result;
	}

	
		
	
	public virtual Node set(int index, Node elem)
	{
		Node result = EqualsHashcodeOverridingFacade.access_0024000((EqualsHashcodeOverridingFacade)innerList.set(index, new EqualsHashcodeOverridingFacade(this, elem)));
		
		return result;
	}

	
		
	
	public virtual Node get(int index)
	{
		Node result = EqualsHashcodeOverridingFacade.access_0024000((EqualsHashcodeOverridingFacade)innerList.get(index));
		
		return result;
	}

	
	
	
	
	private static Node lambda_0024toArray_00240(EqualsHashcodeOverridingFacade facade)
	{
		Node result = EqualsHashcodeOverridingFacade.access_0024000(facade);
		
		return result;
	}

	
	
	
	
	private static Node lambda_0024toArray_00241(EqualsHashcodeOverridingFacade facade)
	{
		Node result = EqualsHashcodeOverridingFacade.access_0024000(facade);
		
		return result;
	}

	
		
	
	public VisitorList(GenericVisitor hashcodeVisitor, GenericVisitor equalsVisitor)
	{
		___003C_003EhashcodeVisitor = hashcodeVisitor;
		___003C_003EequalsVisitor = equalsVisitor;
		innerList = new java.util.ArrayList();
	}

	
		
	
	public virtual bool addAll(int index, Collection col)
	{
		if (col.isEmpty())
		{
			return false;
		}
		Iterator iterator = col.iterator();
		while (iterator.hasNext())
		{
			Node elem = (Node)iterator.next();
			if (index == size())
			{
				add(elem);
			}
			else
			{
				add(index, elem);
			}
			index++;
		}
		return true;
	}

	
		
	
	public virtual bool containsAll(Collection col)
	{
		Iterator iterator = col.iterator();
		while (iterator.hasNext())
		{
			object elem = iterator.next();
			if (!contains(elem))
			{
				return false;
			}
		}
		return true;
	}

	
	
	
	public virtual int indexOf(object elem)
	{
		int result = innerList.indexOf(new EqualsHashcodeOverridingFacade(this, (Node)elem));
		
		return result;
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = innerList.isEmpty();
		
		return result;
	}

	
		
	public virtual Iterator iterator()
	{
		_1 result = new _1(this);
		
		return result;
	}

	
	
	
	public virtual int lastIndexOf(object elem)
	{
		int result = innerList.lastIndexOf(new EqualsHashcodeOverridingFacade(this, (Node)elem));
		
		return result;
	}

	
		
	public virtual ListIterator listIterator()
	{
		ListIterator result = listIterator(0);
		
		return result;
	}

	
		
	
	public virtual bool removeAll(Collection col)
	{
		int result = 0;
		Iterator iterator = col.iterator();
		while (iterator.hasNext())
		{
			object elem = iterator.next();
			if (remove(elem))
			{
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	
		
	
	public virtual bool retainAll(Collection col)
	{
		int num = size();
		clear();
		addAll(col);
		return size() != num;
	}

	
		
	
	public virtual List subList(int fromIndex, int toIndex)
	{
		_3 result = new _3(this, ___003C_003EhashcodeVisitor, ___003C_003EequalsVisitor, fromIndex, toIndex);
		
		return result;
	}

	
	
	public virtual object[] toArray()
	{
		object[] result = ((List)innerList.stream().map(new ___003C_003EAnon0()).collect(Collectors.toList())).toArray();
		
		return result;
	}

	
		
	
	public virtual object[] toArray(object[] arr)
	{
		object[] result = ((List)innerList.stream().map(new ___003C_003EAnon1()).collect(Collectors.toList())).toArray(arr);
		
		return result;
	}

	
	
	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder("[");
		if (size() == 0)
		{
			string result = stringBuilder.append("]").ToString();
			
			return result;
		}
		Iterator iterator = innerList.iterator();
		while (iterator.hasNext())
		{
			EqualsHashcodeOverridingFacade equalsHashcodeOverridingFacade = (EqualsHashcodeOverridingFacade)iterator.next();
			stringBuilder.append(new StringBuilder().append(EqualsHashcodeOverridingFacade.access_0024000(equalsHashcodeOverridingFacade).ToString()).append(", ").ToString());
		}
		string result2 = stringBuilder.replace(stringBuilder.length() - 2, stringBuilder.length(), "]").ToString();
		
		return result2;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Eremove(int index)
	{
		Node result = remove(index);
		
		return result;
	}

	
	
	
	
	
	public virtual void add(int index, object elem)
	{
		add(index, (Node)elem);
	}

	
	
	
	
	
	public virtual object set(int index, object elem)
	{
		Node result = set(index, (Node)elem);
		
		return result;
	}

	
	
	
	
	
	public virtual object _003Cbridge_003Eget(int index)
	{
		Node result = get(index);
		
		return result;
	}

	
	
	
	
	
	public virtual bool add(object elem)
	{
		bool result = add((Node)elem);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(Consumer P_0)
	{
		Iterable._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Spliterator spliterator()
	{
		return List._003Cdefault_003Espliterator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool removeIf(Predicate P_0)
	{
		return Collection._003Cdefault_003EremoveIf(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Stream stream()
	{
		return Collection._003Cdefault_003Estream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Stream parallelStream()
	{
		return Collection._003Cdefault_003EparallelStream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void replaceAll(UnaryOperator P_0)
	{
		List._003Cdefault_003EreplaceAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void sort(Comparator P_0)
	{
		List._003Cdefault_003Esort(this, P_0);
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

	bool List.List_003A_003Aequals(object P_0)
	{
		return Object.instancehelper_equals(this, P_0);
	}

	int List.List_003A_003AhashCode()
	{
		return Object.instancehelper_hashCode(this);
	}

	bool Collection.Collection_003A_003Aequals(object P_0)
	{
		return Object.instancehelper_equals(this, P_0);
	}

	int Collection.Collection_003A_003AhashCode()
	{
		return Object.instancehelper_hashCode(this);
	}
}
