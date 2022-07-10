using System.Runtime.CompilerServices;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithThrownExceptions
{
	private static class ___003C_003EPIM
	{
		
		
		[MethodParameters(new Modifiers[]
		{
			Modifiers.Final | Modifiers.Synthetic,
			Modifiers.Synthetic
		})]
		
		internal static bool lambda_0024isThrown_00240(string throwableName, ReferenceType t)
		{
			bool result = String.instancehelper_equals(t.ToString(), throwableName);
			
			return result;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static ReferenceType getThrownException(NodeWithThrownExceptions P_0, int P_1)
		{
			
			return _003Cdefault_003EgetThrownException(P_0, P_1);
		}

		public unsafe static Node addThrownException(NodeWithThrownExceptions P_0, ReferenceType P_1)
		{
			
			return _003Cdefault_003EaddThrownException(P_0, P_1);
		}

		public unsafe static Node addThrownException(NodeWithThrownExceptions P_0, Class P_1)
		{
			
			return _003Cdefault_003EaddThrownException(P_0, P_1);
		}

		public unsafe static bool isThrown(NodeWithThrownExceptions P_0, Class P_1)
		{
			
			return _003Cdefault_003EisThrown(P_0, P_1);
		}

		public unsafe static bool isThrown(NodeWithThrownExceptions P_0, string P_1)
		{
			
			return _003Cdefault_003EisThrown(P_0, P_1);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon1(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024isThrown_00240(arg_00241, (ReferenceType)P_0);
			
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

		virtual NodeList getThrownExceptions();

		
	virtual void tryAddImportToParentCompilationUnit(Class clazz);

	
		
	virtual Node addThrownException(ReferenceType throwType);

	
	
	
	static Node _003Cdefault_003EaddThrownException(NodeWithThrownExceptions P_0, ReferenceType P_1)
	{
		P_0.getThrownExceptions().add(P_1);
		return (Node)P_0;
	}

	
	
	virtual bool isThrown(string throwableName);

	
	
	
	static bool _003Cdefault_003EisThrown(NodeWithThrownExceptions P_0, string P_1)
	{
		bool result = P_0.getThrownExceptions().stream().anyMatch(new ___003C_003EAnon1(P_1));
		
		return result;
	}

		
	virtual Node setThrownExceptions(NodeList thrownExceptions);

	
	
	virtual ReferenceType getThrownException(int i);

	
	
	
	static ReferenceType _003Cdefault_003EgetThrownException(NodeWithThrownExceptions P_0, int P_1)
	{
		return (ReferenceType)P_0.getThrownExceptions().get(P_1);
	}

	
		
	virtual Node addThrownException(Class clazz);

	
	
	
	static Node _003Cdefault_003EaddThrownException(NodeWithThrownExceptions P_0, Class P_1)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.addThrownException(StaticJavaParser.parseClassOrInterfaceType(P_1.getSimpleName()));
		
		return result;
	}

	
		
	virtual bool isThrown(Class clazz);

	
	
	
	static bool _003Cdefault_003EisThrown(NodeWithThrownExceptions P_0, Class P_1)
	{
		bool result = P_0.isThrown(P_1.getSimpleName());
		
		return result;
	}
}
