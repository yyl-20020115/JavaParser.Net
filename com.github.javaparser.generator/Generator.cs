
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator;

public abstract class Generator
{
	
	private sealed class ___003C_003EAnon0 : Predicate
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon0(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024annotate_00240(arg_00241, (AnnotationExpr)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Runnable
	{
		private readonly ClassOrInterfaceDeclaration arg_00241;

		private readonly CallableDeclaration arg_00242;

		internal ___003C_003EAnon1(ClassOrInterfaceDeclaration P_0, CallableDeclaration P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void run()
		{
			lambda_0024addOrReplaceWhenSameSignature_00241(arg_00241, arg_00242);
			
		}
	}

	
	private sealed class ___003C_003EAnon2 : Runnable
	{
		private readonly CallableDeclaration arg_00241;

		private readonly ClassOrInterfaceDeclaration arg_00242;

		internal ___003C_003EAnon2(CallableDeclaration P_0, ClassOrInterfaceDeclaration P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void run()
		{
			lambda_0024replaceWhenSameSignature_00242(arg_00241, arg_00242);
			
		}
	}

	internal SourceRoot ___003C_003EsourceRoot;

	
	protected internal SourceRoot sourceRoot
	{
		
		get
		{
			return ___003C_003EsourceRoot;
		}
		
		private set
		{
			___003C_003EsourceRoot = value;
		}
	}

	
	public abstract void generate();

	
		
	private void annotate(Node P_0, Class P_1, Expression P_2)
	{
		((NodeWithAnnotations)P_0).setAnnotations((NodeList)((NodeWithAnnotations)P_0).getAnnotations().stream().filter(new ___003C_003EAnon0(P_1))
			.collect(NodeList.toNodeList()));
		if (P_2 != null)
		{
			((NodeWithAnnotations)P_0).addSingleMemberAnnotation(P_1.getSimpleName(), P_2);
		}
		else
		{
			((NodeWithAnnotations)P_0).addMarkerAnnotation(P_1.getSimpleName());
		}
		P_0.tryAddImportToParentCompilationUnit(P_1);
	}

	
		
	private void addMethod(ClassOrInterfaceDeclaration P_0, CallableDeclaration P_1, Runnable P_2)
	{
		List callablesWithSignature = P_0.getCallablesWithSignature(P_1.getSignature());
		if (callablesWithSignature.isEmpty())
		{
			P_2.run();
			return;
		}
		if (callablesWithSignature.size() > 1)
		{
			string detailMessage = CodeGenerationUtils.f("Wanted to regenerate a method with signature %s in %s, but found more than one.", P_1.getSignature(), P_0.getNameAsString());
			
			throw new AssertionError(detailMessage);
		}
		CallableDeclaration callableDeclaration = (CallableDeclaration)callablesWithSignature.get(0);
		P_1.setJavadocComment((JavadocComment)P_1.getJavadocComment().orElse(callableDeclaration.getJavadocComment().orElse(null)));
		annotateGenerated(P_1);
		P_0.getMembers().replace(callableDeclaration, P_1);
	}

	
		
	protected internal virtual void annotateGenerated(Node node)
	{
		Class value = ClassLiteral<Generated>.Value;
		StringLiteralExpr.___003Cclinit_003E();
		annotate(node, value, new StringLiteralExpr(Object.instancehelper_getClass(this).getName()));
	}

	
	
	
	private static bool lambda_0024annotate_00240(Class P_0, AnnotationExpr P_1)
	{
		return (!String.instancehelper_equals(P_1.getNameAsString(), P_0.getSimpleName())) ? true : false;
	}

	
	
	
	private static void lambda_0024addOrReplaceWhenSameSignature_00241(ClassOrInterfaceDeclaration P_0, CallableDeclaration P_1)
	{
		_ = (ClassOrInterfaceDeclaration)P_0.addMember(P_1);
	}

	
	
	
	private static void lambda_0024replaceWhenSameSignature_00242(CallableDeclaration P_0, ClassOrInterfaceDeclaration P_1)
	{
		string detailMessage = CodeGenerationUtils.f("Wanted to regenerate a method with signature %s in %s, but it wasn't there.", P_0.getSignature(), P_1.getNameAsString());
		
		throw new AssertionError(detailMessage);
	}

	
	
	protected internal Generator(SourceRoot sourceRoot)
	{
		___003C_003EsourceRoot = sourceRoot;
	}

	
		
	protected internal virtual void annotateSuppressWarnings(Node node)
	{
		annotate(node, ClassLiteral<SuppressWarnings>.Value, new StringLiteralExpr("unchecked"));
	}

	
	
	protected internal virtual void annotateOverridden(MethodDeclaration method)
	{
		annotate(method, ClassLiteral<Override>.Value, null);
	}

	
		
	protected internal virtual void addOrReplaceWhenSameSignature(ClassOrInterfaceDeclaration containingClassOrInterface, CallableDeclaration callable)
	{
		addMethod(containingClassOrInterface, callable, new ___003C_003EAnon1(containingClassOrInterface, callable));
	}

	
		
	protected internal virtual void replaceWhenSameSignature(ClassOrInterfaceDeclaration containingClassOrInterface, CallableDeclaration callable)
	{
		addMethod(containingClassOrInterface, callable, new ___003C_003EAnon2(callable, containingClassOrInterface));
	}

	
		
	protected internal virtual void removeMethodWithSameSignature(ClassOrInterfaceDeclaration containingClassOrInterface, CallableDeclaration callable)
	{
		Iterator iterator = containingClassOrInterface.getCallablesWithSignature(callable.getSignature()).iterator();
		while (iterator.hasNext())
		{
			CallableDeclaration node = (CallableDeclaration)iterator.next();
			containingClassOrInterface.remove(node);
		}
	}
}
