using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.visitor;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.utils;


public class VisitorSet: Set, Collection, Iterable, IEnumerable
{
	
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
	internal class _1: Iterator
	{
		
				internal Iterator itr;

		
		internal VisitorSet this_00240;

		
				
		public virtual Node next()
		{
			Node result = EqualsHashcodeOverridingFacade.access_0024100((EqualsHashcodeOverridingFacade)itr.next());
			
			return result;
		}

		
		
		
		internal _1(VisitorSet this_00240)
		{
			this.this_00240 = this_00240;
			
			itr = access_0024000(this.this_00240).iterator();
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

	[InnerClass(null, Modifiers.Private)]
	internal class EqualsHashcodeOverridingFacade: Visitable
	{
		
				private Node overridden;

		
		internal VisitorSet this_00240;

		
		
		internal static Node access_0024100(EqualsHashcodeOverridingFacade P_0)
		{
			return P_0.overridden;
		}

		
				[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			(Modifiers)0
		})]
		
		internal EqualsHashcodeOverridingFacade(VisitorSet this_00240, Node overridden)
		{
			this.this_00240 = this_00240;
			
			this.overridden = overridden;
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public virtual object accept(GenericVisitor v, object arg)
		{
			
			throw new AssertionError();
		}

		
				[MethodParameters(new Modifiers[]
		{
			(Modifiers)0,
			(Modifiers)0
		})]
		
		public virtual void accept(VoidVisitor v, object arg)
		{
			
			throw new AssertionError();
		}

		
		
		public sealed override int GetHashCode()
		{
			int result = ((Integer)overridden.accept(access_0024200(this_00240), null)).intValue();
			
			return result;
		}

		
		
		
		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is EqualsHashcodeOverridingFacade))
			{
				return false;
			}
			bool result = ((Boolean)overridden.accept(access_0024300(this_00240), ((EqualsHashcodeOverridingFacade)obj).overridden)).booleanValue();
			
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

	
		private Set innerSet;

	
		private GenericVisitor hashcodeVisitor;

	
		private GenericVisitor equalsVisitor;

	
	
	internal static Set access_0024000(VisitorSet P_0)
	{
		return P_0.innerSet;
	}

	
		
	
	public virtual bool add(Node elem)
	{
		bool result = innerSet.add(new EqualsHashcodeOverridingFacade(this, elem));
		
		return result;
	}

	
	
	
	public virtual bool contains(object elem)
	{
		bool result = innerSet.contains(new EqualsHashcodeOverridingFacade(this, (Node)elem));
		
		return result;
	}

	
	
	
	public virtual bool remove(object elem)
	{
		bool result = innerSet.remove(new EqualsHashcodeOverridingFacade(this, (Node)elem));
		
		return result;
	}

	
	
	public virtual int size()
	{
		int result = innerSet.size();
		
		return result;
	}

	
	
	public virtual void clear()
	{
		innerSet.clear();
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

	
	
	
	
	private static Node lambda_0024toArray_00240(EqualsHashcodeOverridingFacade facade)
	{
		Node result = EqualsHashcodeOverridingFacade.access_0024100(facade);
		
		return result;
	}

	
	
	
	
	private static Node lambda_0024toArray_00241(EqualsHashcodeOverridingFacade facade)
	{
		Node result = EqualsHashcodeOverridingFacade.access_0024100(facade);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public VisitorSet(GenericVisitor hashcodeVisitor, GenericVisitor equalsVisitor)
	{
		innerSet = new HashSet();
		this.hashcodeVisitor = hashcodeVisitor;
		this.equalsVisitor = equalsVisitor;
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

	
	
	public virtual bool isEmpty()
	{
		bool result = innerSet.isEmpty();
		
		return result;
	}

	
		
	public virtual Iterator iterator()
	{
		_1 result = new _1(this);
		
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

	
	
	public virtual object[] toArray()
	{
		object[] result = ((List)innerSet.stream().map(new ___003C_003EAnon0()).collect(Collectors.toList())).toArray();
		
		return result;
	}

	
		
	
	public virtual object[] toArray(object[] arr)
	{
		object[] result = ((List)innerSet.stream().map(new ___003C_003EAnon1()).collect(Collectors.toList())).toArray(arr);
		
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
		Iterator iterator = innerSet.iterator();
		while (iterator.hasNext())
		{
			EqualsHashcodeOverridingFacade equalsHashcodeOverridingFacade = (EqualsHashcodeOverridingFacade)iterator.next();
			stringBuilder.append(new StringBuilder().append(EqualsHashcodeOverridingFacade.access_0024100(equalsHashcodeOverridingFacade).ToString()).append(",").ToString());
		}
		string result2 = stringBuilder.replace(stringBuilder.length() - 2, stringBuilder.length(), "]").ToString();
		
		return result2;
	}

	
	
	
	
	
	public virtual bool add(object elem)
	{
		bool result = add((Node)elem);
		
		return result;
	}

	
	
	internal static GenericVisitor access_0024200(VisitorSet P_0)
	{
		return P_0.hashcodeVisitor;
	}

	
	
	internal static GenericVisitor access_0024300(VisitorSet P_0)
	{
		return P_0.equalsVisitor;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(Consumer P_0)
	{
		Iterable._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Spliterator spliterator()
	{
		return Set._003Cdefault_003Espliterator(this);
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

	
	
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	bool Set.Set_003A_003Aequals(object P_0)
	{
		return Object.instancehelper_equals(this, P_0);
	}

	int Set.Set_003A_003AhashCode()
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
