
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.generator.core.visitor;

public class GenericListVisitorAdapterGenerator : VisitorGenerator
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		internal ___003C_003EAnon0()
		{
		}

		public void accept(object P_0)
		{
			lambda_0024generateVisitMethodBody_00240((Parameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		private readonly CompilationUnit arg_00241;

		internal ___003C_003EAnon1(CompilationUnit P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generateVisitMethodBody_00242(arg_00241, (Class)P_0);
			
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
		private readonly CompilationUnit arg_00241;

		internal ___003C_003EAnon2(CompilationUnit P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.addImport((Class)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
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
			bool result = lambda_0024null_00241(arg_00241, (ImportDeclaration)P_0);
			
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

	
	
	public GenericListVisitorAdapterGenerator(SourceRoot sourceRoot)
		: base(sourceRoot, "com.github.javaparser.ast.visitor", "GenericListVisitorAdapter", "List<R>", "A", createMissingVisitMethods: true)
	{
	}

	
	
	
	private static void lambda_0024generateVisitMethodBody_00240(Parameter P_0)
	{
		_ = (Parameter)P_0.setFinal(true);
	}

	
	
	
	private static bool lambda_0024generateVisitMethodBody_00242(CompilationUnit P_0, Class P_1)
	{
		bool result = P_0.getImports().stream().noneMatch(new ___003C_003EAnon3(P_1));
		
		return result;
	}

	
	
	
	private static bool lambda_0024null_00241(Class P_0, ImportDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_0.getName(), P_1.getName().asString());
		
		return result;
	}

	
	
	protected internal unsafe override void generateVisitMethodBody(BaseNodeMetaModel node, MethodDeclaration visitMethod, CompilationUnit compilationUnit)
	{
		visitMethod.getParameters().forEach(new ___003C_003EAnon0());
		BlockStmt blockStmt = (BlockStmt)visitMethod.getBody().get();
		blockStmt.getStatements().clear();
		blockStmt.addStatement("List<R> result = new ArrayList<>();");
		blockStmt.addStatement("List<R> tmp;");
		Iterator iterator = node.getAllPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			string text = new StringBuilder().append(propertyMetaModel.getGetterMethodName()).append("()").ToString();
			if (propertyMetaModel.getNodeReference().isPresent())
			{
				if (propertyMetaModel.isOptional())
				{
					blockStmt.addStatement(CodeGenerationUtils.f("if (n.%s.isPresent()) {   tmp = n.%s.get().accept(this, arg);   %s}", text, text, "if (tmp != null) result.addAll(tmp);"));
				}
				else
				{
					blockStmt.addStatement(CodeGenerationUtils.f("{ tmp = n.%s.accept(this, arg); %s }", text, "if (tmp != null) result.addAll(tmp);"));
				}
			}
		}
		blockStmt.addStatement("return result;");
		Stream stream = Arrays.stream(new Class[2]
		{
			ClassLiteral<List>.Value,
			ClassLiteral<ArrayList>.Value
		}).filter(new ___003C_003EAnon1(compilationUnit));
		
		stream.forEach(new ___003C_003EAnon2(compilationUnit));
	}
}
