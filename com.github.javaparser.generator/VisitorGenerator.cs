using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator;

public abstract class VisitorGenerator : Generator
{
	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		private readonly VisitorGenerator arg_00241;

		internal ___003C_003EAnon0(VisitorGenerator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			object result = arg_00241.lambda_0024generate_00240();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generate_00241((BaseNodeMetaModel)P_0);
			
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
		private readonly VisitorGenerator arg_00241;

		private readonly ClassOrInterfaceDeclaration arg_00242;

		private readonly CompilationUnit arg_00243;

		internal ___003C_003EAnon2(VisitorGenerator P_0, ClassOrInterfaceDeclaration P_1, CompilationUnit P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024generate_00242(arg_00242, arg_00243, (BaseNodeMetaModel)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		internal ___003C_003EAnon3()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generateVisitMethodForNode_00243((MethodDeclaration)P_0);
			
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
		private readonly BaseNodeMetaModel arg_00241;

		internal ___003C_003EAnon4(BaseNodeMetaModel P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generateVisitMethodForNode_00244(arg_00241, (MethodDeclaration)P_0);
			
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

	
	private string pkg;

	
	private string visitorClassName;

	
	private string returnType;

	
	private string argumentType;

	
	private bool createMissingVisitMethods;

	
	
	[LineNumberTable(new byte[]
	{
		10, 158, 159, 33, 109, 104, 141, 140, 116, 114,
		101, 104
	})]
	public sealed override void generate()
	{
		Log.info("Running %s", new ___003C_003EAnon0(this));
		CompilationUnit compilationUnit = (CompilationUnit)___003C_003EsourceRoot.tryToParse(pkg, new StringBuilder().append(visitorClassName).append(".java").ToString()).getResult().get();
		Optional optional = compilationUnit.getClassByName(visitorClassName);
		if (!optional.isPresent())
		{
			optional = compilationUnit.getInterfaceByName(visitorClassName);
		}
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)optional.get();
		JavaParserMetaModel.getNodeMetaModels().stream().filter(new ___003C_003EAnon1())
			.forEach(new ___003C_003EAnon2(this, classOrInterfaceDeclaration, compilationUnit));
		after();
	}

	
	protected internal virtual void after()
	{
	}

	protected internal abstract void generateVisitMethodBody(BaseNodeMetaModel bnmm, MethodDeclaration md, CompilationUnit cu);

	
	[LineNumberTable(new byte[]
	{
		31, 117, 112, 101, 134, 104, 120, 107, 114, 127,
		0, 112, 107, 104, 117, 120, 134, 139
	})]
	private void generateVisitMethodForNode(BaseNodeMetaModel P_0, ClassOrInterfaceDeclaration P_1, CompilationUnit P_2)
	{
		Optional optional = P_1.getMethods().stream().filter(new ___003C_003EAnon3())
			.filter(new ___003C_003EAnon4(P_0))
			.findFirst();
		if (optional.isPresent())
		{
			generateVisitMethodBody(P_0, (MethodDeclaration)optional.get(), P_2);
		}
		else if (createMissingVisitMethods)
		{
			MethodDeclaration methodDeclaration = (MethodDeclaration)((MethodDeclaration)((MethodDeclaration)P_1.addMethod("visit", new Modifier.Keyword[0]).addParameter(P_0.getTypeNameGenerified(), "n")).addParameter(argumentType, "arg")).setType(returnType);
			if (!P_1.isInterface())
			{
				MarkerAnnotationExpr.___003Cclinit_003E();
				((MethodDeclaration)methodDeclaration.addAnnotation(new MarkerAnnotationExpr(new Name("Override")))).addModifier(new Modifier.Keyword[1] { Modifier.Keyword.___003C_003EPUBLIC });
			}
			generateVisitMethodBody(P_0, methodDeclaration, P_2);
		}
	}

	
	
	
	private object lambda_0024generate_00240()
	{
		string simpleName = Object.instancehelper_getClass(this).getSimpleName();
		
		return simpleName;
	}

	
	
	
	private static bool lambda_0024generate_00241(BaseNodeMetaModel P_0)
	{
		return (!P_0.isAbstract()) ? true : false;
	}

	
	
	
	private void lambda_0024generate_00242(ClassOrInterfaceDeclaration P_0, CompilationUnit P_1, BaseNodeMetaModel P_2)
	{
		generateVisitMethodForNode(P_2, P_0, P_1);
	}

	
	
	
	private static bool lambda_0024generateVisitMethodForNode_00243(MethodDeclaration P_0)
	{
		bool result = String.instancehelper_equals(P_0.getNameAsString(), "visit");
		
		return result;
	}

	
	
	
	private static bool lambda_0024generateVisitMethodForNode_00244(BaseNodeMetaModel P_0, MethodDeclaration P_1)
	{
		bool result = String.instancehelper_equals(P_1.getParameter(0).getType().ToString(), P_0.getTypeName());
		
		return result;
	}

	
	
	protected internal VisitorGenerator(SourceRoot sourceRoot, string pkg, string visitorClassName, string returnType, string argumentType, bool createMissingVisitMethods)
		: base(sourceRoot)
	{
		this.pkg = pkg;
		this.visitorClassName = visitorClassName;
		this.returnType = returnType;
		this.argumentType = argumentType;
		this.createMissingVisitMethods = createMissingVisitMethods;
	}
}
