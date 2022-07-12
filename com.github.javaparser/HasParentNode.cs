using System;

using com.github.javaparser.ast;
using com.github.javaparser.ast.observer;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser;


public interface HasParentNode : com.github.javaparser.ast.observer.Observable
{
	private static class ___003C_003EPIM
	{
		
		
		internal static bool lambda_0024findAncestor_00240(object x)
		{
			return true;
		}

		
		
		
		
		internal static bool lambda_0024findAncestor_00241(Node parent, Predicate predicate, Class type)
		{
			return (type.isAssignableFrom(java.lang.Object.instancehelper_getClass(parent)) && predicate.test(type.cast(parent))) ? true : false;
		}

		
		
		internal static bool lambda_0024isDescendantOf_00242(Node ancestor, Node n)
		{
			return n == ancestor;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static bool hasParentNode(HasParentNode P_0)
		{
			
			return _003Cdefault_003EhasParentNode(P_0);
		}

		public unsafe static Optional findAncestor(HasParentNode P_0, Class[] P_1)
		{
			
			return _003Cdefault_003EfindAncestor(P_0, P_1);
		}

		public unsafe static Optional findAncestor(HasParentNode P_0, Class P_1, Predicate P_2)
		{
			
			return _003Cdefault_003EfindAncestor(P_0, P_1, P_2);
		}

		public unsafe static Optional findAncestor(HasParentNode P_0, Predicate P_1, Class[] P_2)
		{
			
			return _003Cdefault_003EfindAncestor(P_0, P_1, P_2);
		}

		public unsafe static bool isDescendantOf(HasParentNode P_0, Node P_1)
		{
			
			return _003Cdefault_003EisDescendantOf(P_0, P_1);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024findAncestor_00240(P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Predicate
	{
		private readonly Node arg_00241;

		private readonly Predicate arg_00242;

		internal ___003C_003EAnon2(Node P_0, Predicate P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024findAncestor_00241(arg_00241, arg_00242, (Class)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon3(Node P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024isDescendantOf_00242(arg_00241, (Node)P_0);
			
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

		virtual Optional getParentNode();

	
		
	virtual Optional findAncestor(Predicate predicate, params Class[] types);

	
	
	
	static Optional _003Cdefault_003EfindAncestor(HasParentNode P_0, Predicate P_1, Class[] P_2)
	{
		if (!P_0.hasParentNode())
		{
			Optional result = Optional.empty();
			
			return result;
		}
		Node node = (Node)P_0.getParentNode().get();
		Optional optional = Arrays.stream(P_2).filter(new ___003C_003EAnon2(node, P_1)).findFirst();
		if (optional.isPresent())
		{
			Optional result2 = Optional.of(((Class)optional.get()).cast(node));
			
			return result2;
		}
		Optional result3 = node.findAncestor(P_1, P_2);
		
		return result3;
	}

	
	virtual bool hasParentNode();

	
	
	
	static bool _003Cdefault_003EhasParentNode(HasParentNode P_0)
	{
		bool result = P_0.getParentNode().isPresent();
		
		return result;
	}

		
	virtual object setParentNode(Node parentNode);

	virtual Node getParentNodeForChildren();

	
		
	virtual Optional findAncestor(params Class[] types);

	
	
	
	static Optional _003Cdefault_003EfindAncestor(HasParentNode P_0, Class[] P_1)
	{
		Optional result = P_0.findAncestor(new ___003C_003EAnon1(), P_1);
		
		return result;
	}

	
	
		
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	virtual Optional findAncestor(Class type, Predicate predicate);

	
	
	
	static Optional _003Cdefault_003EfindAncestor(HasParentNode P_0, Class P_1, Predicate P_2)
	{
		Optional result = P_0.findAncestor(P_2, P_1);
		
		return result;
	}

	
	
	virtual bool isDescendantOf(Node ancestor);

	
	
	
	static bool _003Cdefault_003EisDescendantOf(HasParentNode P_0, Node P_1)
	{
		bool result = P_0.findAncestor(new ___003C_003EAnon3(P_1), ClassLiteral<Node>.Value).isPresent();
		
		return result;
	}
}
