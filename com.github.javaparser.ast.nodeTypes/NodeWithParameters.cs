
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.type;

using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.ast.nodeTypes;

public interface NodeWithParameters
{
	private static class ___003C_003EPIM
	{
		
		
		
		
		internal static bool lambda_0024getParameterByName_00240(string name, Parameter p)
		{
			bool result = String.instancehelper_equals(p.getNameAsString(), name);
			
			return result;
		}

		
		
		
		
		internal static bool lambda_0024getParameterByType_00241(string type, Parameter p)
		{
			bool result = String.instancehelper_equals(p.getType().ToString(), type);
			
			return result;
		}

		
		
		
		
		internal static bool lambda_0024getParameterByType_00242(Class type, Parameter p)
		{
			bool result = String.instancehelper_equals(p.getType().ToString(), type.getSimpleName());
			
			return result;
		}

		
		
		
		
		internal static string lambda_0024hasParametersOfType_00243(Parameter p)
		{
			string result = p.getType().asString();
			
			return result;
		}

		
		
		
		
		internal static string lambda_0024hasParametersOfType_00244(Parameter p)
		{
			return (string)p.getType().toClassOrInterfaceType().map(new ___003C_003EAnon7())
				.orElse(p.getType().asString());
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static Parameter getParameter(NodeWithParameters P_0, int P_1)
		{
			
			return _003Cdefault_003EgetParameter(P_0, P_1);
		}

		public unsafe static Node setParameter(NodeWithParameters P_0, int P_1, Parameter P_2)
		{
			
			return _003Cdefault_003EsetParameter(P_0, P_1, P_2);
		}

		public unsafe static Node addParameter(NodeWithParameters P_0, Type P_1, string P_2)
		{
			
			return _003Cdefault_003EaddParameter(P_0, P_1, P_2);
		}

		public unsafe static Node addParameter(NodeWithParameters P_0, Class P_1, string P_2)
		{
			
			return _003Cdefault_003EaddParameter(P_0, P_1, P_2);
		}

		public unsafe static Node addParameter(NodeWithParameters P_0, string P_1, string P_2)
		{
			
			return _003Cdefault_003EaddParameter(P_0, P_1, P_2);
		}

		public unsafe static Node addParameter(NodeWithParameters P_0, Parameter P_1)
		{
			
			return _003Cdefault_003EaddParameter(P_0, P_1);
		}

		public unsafe static Parameter addAndGetParameter(NodeWithParameters P_0, Type P_1, string P_2)
		{
			
			return _003Cdefault_003EaddAndGetParameter(P_0, P_1, P_2);
		}

		public unsafe static Parameter addAndGetParameter(NodeWithParameters P_0, Class P_1, string P_2)
		{
			
			return _003Cdefault_003EaddAndGetParameter(P_0, P_1, P_2);
		}

		public unsafe static Parameter addAndGetParameter(NodeWithParameters P_0, string P_1, string P_2)
		{
			
			return _003Cdefault_003EaddAndGetParameter(P_0, P_1, P_2);
		}

		public unsafe static Parameter addAndGetParameter(NodeWithParameters P_0, Parameter P_1)
		{
			
			return _003Cdefault_003EaddAndGetParameter(P_0, P_1);
		}

		public unsafe static Optional getParameterByName(NodeWithParameters P_0, string P_1)
		{
			
			return _003Cdefault_003EgetParameterByName(P_0, P_1);
		}

		public unsafe static Optional getParameterByType(NodeWithParameters P_0, string P_1)
		{
			
			return _003Cdefault_003EgetParameterByType(P_0, P_1);
		}

		public unsafe static Optional getParameterByType(NodeWithParameters P_0, Class P_1)
		{
			
			return _003Cdefault_003EgetParameterByType(P_0, P_1);
		}

		public unsafe static bool hasParametersOfType(NodeWithParameters P_0, string[] P_1)
		{
			
			return _003Cdefault_003EhasParametersOfType(P_0, P_1);
		}

		public unsafe static bool hasParametersOfType(NodeWithParameters P_0, Class[] P_1)
		{
			
			return _003Cdefault_003EhasParametersOfType(P_0, P_1);
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
			bool result = ___003C_003EPIM.lambda_0024getParameterByName_00240(arg_00241, (Parameter)P_0);
			
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
		private readonly string arg_00241;

		internal ___003C_003EAnon2(string P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getParameterByType_00241(arg_00241, (Parameter)P_0);
			
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
		private readonly Class arg_00241;

		internal ___003C_003EAnon3(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getParameterByType_00242(arg_00241, (Parameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Function
	{
		internal ___003C_003EAnon4()
		{
		}

		public object apply(object P_0)
		{
			string result = ___003C_003EPIM.lambda_0024hasParametersOfType_00243((Parameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Function
	{
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			string result = ___003C_003EPIM.lambda_0024hasParametersOfType_00244((Parameter)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Function
	{
		internal ___003C_003EAnon6()
		{
		}

		public object apply(object P_0)
		{
			string simpleName = ((Class)P_0).getSimpleName();
			
			return simpleName;
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

	
	private sealed class ___003C_003EAnon7 : Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			string nameAsString = ((NodeWithSimpleName)(ClassOrInterfaceType)P_0).getNameAsString();
			
			return nameAsString;
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

	
		
	virtual Node addParameter(Class paramClass, string name);

	
	
	
	static Node _003Cdefault_003EaddParameter(NodeWithParameters P_0, Class P_1, string P_2)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.addParameter(StaticJavaParser.parseType(P_1.getSimpleName()), P_2);
		
		return result;
	}

	
		
	virtual Node addParameter(string className, string name);

	
	
	
	static Node _003Cdefault_003EaddParameter(NodeWithParameters P_0, string P_1, string P_2)
	{
		Node result = P_0.addParameter(StaticJavaParser.parseType(P_1), P_2);
		
		return result;
	}

	
	
	virtual Parameter addAndGetParameter(string className, string name);

	
	
	
	static Parameter _003Cdefault_003EaddAndGetParameter(NodeWithParameters P_0, string P_1, string P_2)
	{
		Parameter result = P_0.addAndGetParameter(StaticJavaParser.parseType(P_1), P_2);
		
		return result;
	}

	
	
	virtual Parameter getParameter(int i);

	
	
	
	static Parameter _003Cdefault_003EgetParameter(NodeWithParameters P_0, int P_1)
	{
		return (Parameter)P_0.getParameters().get(P_1);
	}

	
		
	virtual bool hasParametersOfType(params Class[] paramTypes);

	
	
	
	static bool _003Cdefault_003EhasParametersOfType(NodeWithParameters P_0, Class[] P_1)
	{
		bool result = ((List)P_0.getParameters().stream().map(new ___003C_003EAnon5())
			.collect(Collectors.toList())).equals(Stream.of(P_1).map(new ___003C_003EAnon6()).collect(Collectors.toList()));
		
		return result;
	}

	
	
	virtual bool hasParametersOfType(params string[] paramTypes);

	
	
	
	static bool _003Cdefault_003EhasParametersOfType(NodeWithParameters P_0, string[] P_1)
	{
		bool result = ((List)P_0.getParameters().stream().map(new ___003C_003EAnon4())
			.collect(Collectors.toList())).equals(Arrays.asList(P_1));
		
		return result;
	}

		virtual NodeList getParameters();

	
		
	virtual Node addParameter(Parameter parameter);

	
	
	
	static Node _003Cdefault_003EaddParameter(NodeWithParameters P_0, Parameter P_1)
	{
		P_0.getParameters().add(P_1);
		return (Node)P_0;
	}

		
	virtual void tryAddImportToParentCompilationUnit(Class clazz);

	
		
	virtual Node addParameter(Type type, string name);

	
	
	
	static Node _003Cdefault_003EaddParameter(NodeWithParameters P_0, Type P_1, string P_2)
	{
		Node result = P_0.addParameter(new Parameter(P_1, P_2));
		
		return result;
	}

	
	
	virtual Parameter addAndGetParameter(Parameter parameter);

	
	
	
	static Parameter _003Cdefault_003EaddAndGetParameter(NodeWithParameters P_0, Parameter P_1)
	{
		P_0.getParameters().add(P_1);
		return P_1;
	}

	
	
	virtual Parameter addAndGetParameter(Type type, string name);

	
	
	
	static Parameter _003Cdefault_003EaddAndGetParameter(NodeWithParameters P_0, Type P_1, string P_2)
	{
		Parameter result = P_0.addAndGetParameter(new Parameter(P_1, P_2));
		
		return result;
	}

	
		
	virtual Node setParameter(int i, Parameter parameter);

	
	
	
	static Node _003Cdefault_003EsetParameter(NodeWithParameters P_0, int P_1, Parameter P_2)
	{
		P_0.getParameters().set(P_1, P_2);
		return (Node)P_0;
	}

		
	virtual Node setParameters(NodeList parameters);

	
		
	virtual Parameter addAndGetParameter(Class paramClass, string name);

	
	
	
	static Parameter _003Cdefault_003EaddAndGetParameter(NodeWithParameters P_0, Class P_1, string P_2)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Parameter result = P_0.addAndGetParameter(StaticJavaParser.parseType(P_1.getSimpleName()), P_2);
		
		return result;
	}

	
		
	virtual Optional getParameterByName(string name);

	
	
	
	static Optional _003Cdefault_003EgetParameterByName(NodeWithParameters P_0, string P_1)
	{
		Optional result = P_0.getParameters().stream().filter(new ___003C_003EAnon1(P_1))
			.findFirst();
		
		return result;
	}

	
		
	virtual Optional getParameterByType(string type);

	
	
	
	static Optional _003Cdefault_003EgetParameterByType(NodeWithParameters P_0, string P_1)
	{
		Optional result = P_0.getParameters().stream().filter(new ___003C_003EAnon2(P_1))
			.findFirst();
		
		return result;
	}

	
		
	virtual Optional getParameterByType(Class type);

	
	
	
	static Optional _003Cdefault_003EgetParameterByType(NodeWithParameters P_0, Class P_1)
	{
		Optional result = P_0.getParameters().stream().filter(new ___003C_003EAnon3(P_1))
			.findFirst();
		
		return result;
	}
}
