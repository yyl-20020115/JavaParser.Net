
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator;

public abstract class NodeGenerator : Generator
{
	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly NodeGenerator arg_00241;

		internal ___003C_003EAnon0(NodeGenerator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.lambda_0024generate_00240();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Supplier
	{
		internal ___003C_003EAnon1()
		{
		}

		public object get()
		{
			AssertionError result = lambda_0024parseNode_00241();
			
			return result;
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		private readonly MethodDeclaration arg_00241;

		internal ___003C_003EAnon3(MethodDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024annotateWhenOverridden_00242(arg_00241, (Method)P_0);
			
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

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		private readonly MethodDeclaration arg_00241;

		internal ___003C_003EAnon4(MethodDeclaration P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024annotateWhenOverridden_00243(arg_00241, (Method)P_0);
			
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

	
	private static CallerID ___003CcallerID_003E;

	
	
	
	public sealed override void generate()
	{
		Log.info("Running %s", new ___003C_003EAnon0(this));
		Iterator iterator = JavaParserMetaModel.getNodeMetaModels().iterator();
		while (iterator.hasNext())
		{
			BaseNodeMetaModel baseNodeMetaModel = (BaseNodeMetaModel)iterator.next();
			Pair pair = parseNode(baseNodeMetaModel);
			generateNode(baseNodeMetaModel, (CompilationUnit)pair.___003C_003Ea, (ClassOrInterfaceDeclaration)pair.___003C_003Eb);
		}
		after();
	}

	
		
	protected internal virtual Pair parseNode(BaseNodeMetaModel nodeMetaModel)
	{
		CompilationUnit compilationUnit = ___003C_003EsourceRoot.parse(nodeMetaModel.getPackageName(), new StringBuilder().append(nodeMetaModel.getTypeName()).append(".java").ToString());
		ClassOrInterfaceDeclaration b = (ClassOrInterfaceDeclaration)compilationUnit.getClassByName(nodeMetaModel.getTypeName()).orElseThrow(new ___003C_003EAnon1());
		Pair result = new Pair(compilationUnit, b);
		
		return result;
	}

	
	protected internal abstract void generateNode(BaseNodeMetaModel bnmm, CompilationUnit cu, ClassOrInterfaceDeclaration coid);

	
	protected internal virtual void after()
	{
	}

	
	
	
	private object lambda_0024generate_00240()
	{
		string simpleName = Object.instancehelper_getClass(this).getSimpleName();
		
		return simpleName;
	}

	
	
	
	private static AssertionError lambda_0024parseNode_00241()
	{
		AssertionError result = new AssertionError("Can't find class");
		
		return result;
	}

	
	
	
	private static bool lambda_0024annotateWhenOverridden_00242(MethodDeclaration P_0, Method P_1)
	{
		bool result = String.instancehelper_equals(P_1.getName(), P_0.getNameAsString());
		
		return result;
	}

	
	
	
	private static bool lambda_0024annotateWhenOverridden_00243(MethodDeclaration P_0, Method P_1)
	{
		return (nint)P_1.getParameters().LongLength == P_0.getParameters().size();
	}

	
	
	protected internal NodeGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	
	protected internal virtual void annotateWhenOverridden(BaseNodeMetaModel nodeMetaModel, MethodDeclaration methodDeclaration)
	{
		Class type = nodeMetaModel.getType();
		Class superclass = type.getSuperclass();
		if (Arrays.stream(superclass.getMethods(NodeGenerator.___003CGetCallerID_003E())).filter(new ___003C_003EAnon3(methodDeclaration)).anyMatch(new ___003C_003EAnon4(methodDeclaration)))
		{
			annotateOverridden(methodDeclaration);
		}
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
