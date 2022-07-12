using System.ComponentModel;

using com.github.javaparser.ast;
using com.github.javaparser.ast.visitor;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.utils;

public class VisitorMap: Map
{
	[InnerClass(null, Modifiers.Private)]
	internal class EqualsHashcodeOverridingFacade: Visitable
	{
		
				private Node overridden;

		
		internal VisitorMap this_00240;

		
				
		
		internal EqualsHashcodeOverridingFacade(VisitorMap this_00240, Node overridden)
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
			int result = ((Integer)overridden.accept(access_0024000(this_00240), null)).intValue();
			
			return result;
		}

		
		
		
		public override bool Equals(object obj)
		{
			if (obj == null || !(obj is EqualsHashcodeOverridingFacade))
			{
				return false;
			}
			bool result = ((Boolean)overridden.accept(access_0024100(this_00240), ((EqualsHashcodeOverridingFacade)obj).overridden)).booleanValue();
			
			return result;
		}

		
		
		internal static Node access_0024200(EqualsHashcodeOverridingFacade P_0)
		{
			return P_0.overridden;
		}
	}

	
	private sealed class ___003C_003EAnon0 : BiConsumer
	{
		private readonly VisitorMap arg_00241;

		internal ___003C_003EAnon0(VisitorMap P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0, object P_1)
		{
			arg_00241.put((Node)P_0, P_1);
			
		}

		
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			Node result = lambda_0024keySet_00240((EqualsHashcodeOverridingFacade)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			AbstractMap.SimpleEntry result = lambda_0024entrySet_00241((Map.Entry)P_0);
			
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

	
		private Map innerMap;

	
		private GenericVisitor hashcodeVisitor;

	
		private GenericVisitor equalsVisitor;

	
	
	internal static GenericVisitor access_0024000(VisitorMap P_0)
	{
		return P_0.hashcodeVisitor;
	}

	
	
	internal static GenericVisitor access_0024100(VisitorMap P_0)
	{
		return P_0.equalsVisitor;
	}

	
		
	
	public virtual object put(Node key, object value)
	{
		object result = innerMap.put(new EqualsHashcodeOverridingFacade(this, key), value);
		
		return result;
	}

	
	
	
	
	private static Node lambda_0024keySet_00240(EqualsHashcodeOverridingFacade k)
	{
		Node result = EqualsHashcodeOverridingFacade.access_0024200(k);
		
		return result;
	}

	
	
	
	
	private static AbstractMap.SimpleEntry lambda_0024entrySet_00241(Map.Entry e)
	{
		AbstractMap.SimpleEntry result = new AbstractMap.SimpleEntry(EqualsHashcodeOverridingFacade.access_0024200((EqualsHashcodeOverridingFacade)e.getKey()), e.getValue());
		
		return result;
	}

	
		
	
	public VisitorMap(GenericVisitor hashcodeVisitor, GenericVisitor equalsVisitor)
	{
		innerMap = new HashMap();
		this.hashcodeVisitor = hashcodeVisitor;
		this.equalsVisitor = equalsVisitor;
	}

	
	
	public virtual int size()
	{
		int result = innerMap.size();
		
		return result;
	}

	
	
	public virtual bool isEmpty()
	{
		bool result = innerMap.isEmpty();
		
		return result;
	}

	
	
	
	public virtual bool containsKey(object key)
	{
		bool result = innerMap.containsKey(new EqualsHashcodeOverridingFacade(this, (Node)key));
		
		return result;
	}

	
	
	
	public virtual bool containsValue(object value)
	{
		bool result = innerMap.containsValue(value);
		
		return result;
	}

	
		
	
	public virtual object get(object key)
	{
		object result = innerMap.get(new EqualsHashcodeOverridingFacade(this, (Node)key));
		
		return result;
	}

	
		
	
	public virtual object remove(object key)
	{
		object result = innerMap.remove(new EqualsHashcodeOverridingFacade(this, (Node)key));
		
		return result;
	}

	
		
	
	public virtual void putAll(Map m)
	{
		m.forEach(new ___003C_003EAnon0(this));
	}

	
	
	public virtual void clear()
	{
		innerMap.clear();
	}

	
		
	public virtual Set keySet()
	{
		return (Set)innerMap.keySet().stream().map(new ___003C_003EAnon1())
			.collect(Collectors.toSet());
	}

	
		
	public virtual Collection values()
	{
		Collection result = innerMap.values();
		
		return result;
	}

	
		
	public virtual Set entrySet()
	{
		return (Set)innerMap.entrySet().stream().map(new ___003C_003EAnon2())
			.collect(Collectors.toSet());
	}

	
	
	
	
	
	public virtual object put(object key, object value)
	{
		object result = put((Node)key, value);
		
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object putIfAbsent(object P_0, object P_1)
	{
		return Map._003Cdefault_003EputIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object getOrDefault(object P_0, object P_1)
	{
		return Map._003Cdefault_003EgetOrDefault(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(BiConsumer P_0)
	{
		Map._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void replaceAll(BiFunction P_0)
	{
		Map._003Cdefault_003EreplaceAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool remove(object P_0, object P_1)
	{
		return Map._003Cdefault_003Eremove(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool replace(object P_0, object P_1, object P_2)
	{
		return Map._003Cdefault_003Ereplace(this, P_0, P_1, P_2);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object replace(object P_0, object P_1)
	{
		return Map._003Cdefault_003Ereplace(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object computeIfAbsent(object P_0, Function P_1)
	{
		return Map._003Cdefault_003EcomputeIfAbsent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object computeIfPresent(object P_0, BiFunction P_1)
	{
		return Map._003Cdefault_003EcomputeIfPresent(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object compute(object P_0, BiFunction P_1)
	{
		return Map._003Cdefault_003Ecompute(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual object merge(object P_0, object P_1, BiFunction P_2)
	{
		return Map._003Cdefault_003Emerge(this, P_0, P_1, P_2);
	}

	bool Map.Map_003A_003Aequals(object P_0)
	{
		return Object.instancehelper_equals(this, P_0);
	}

	int Map.Map_003A_003AhashCode()
	{
		return Object.instancehelper_hashCode(this);
	}
}
