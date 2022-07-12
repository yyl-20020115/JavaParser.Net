
using com.github.javaparser.ast.expr;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.ast.nodeTypes;

public class NodeWithAnnotations
{
	private static class ___003C_003EPIM
	{
		
		
		
		
		internal static bool lambda_0024isAnnotationPresent_00240(string annotationName, AnnotationExpr a)
		{
			bool result = String.instancehelper_equals(a.getName().getIdentifier(), annotationName);
			
			return result;
		}

		
		
		
		
		internal static bool lambda_0024getAnnotationByName_00241(string annotationName, AnnotationExpr a)
		{
			bool result = String.instancehelper_equals(a.getName().getIdentifier(), annotationName);
			
			return result;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static AnnotationExpr getAnnotation(NodeWithAnnotations P_0, int P_1)
		{
			
			return _003Cdefault_003EgetAnnotation(P_0, P_1);
		}

		public unsafe static Node setAnnotation(NodeWithAnnotations P_0, int P_1, AnnotationExpr P_2)
		{
			
			return _003Cdefault_003EsetAnnotation(P_0, P_1, P_2);
		}

		public unsafe static Node addAnnotation(NodeWithAnnotations P_0, AnnotationExpr P_1)
		{
			
			return _003Cdefault_003EaddAnnotation(P_0, P_1);
		}

		public unsafe static Node addAnnotation(NodeWithAnnotations P_0, string P_1)
		{
			
			return _003Cdefault_003EaddAnnotation(P_0, P_1);
		}

		public unsafe static NormalAnnotationExpr addAndGetAnnotation(NodeWithAnnotations P_0, string P_1)
		{
			
			return _003Cdefault_003EaddAndGetAnnotation(P_0, P_1);
		}

		public unsafe static Node addAnnotation(NodeWithAnnotations P_0, Class P_1)
		{
			
			return _003Cdefault_003EaddAnnotation(P_0, P_1);
		}

		public unsafe static NormalAnnotationExpr addAndGetAnnotation(NodeWithAnnotations P_0, Class P_1)
		{
			
			return _003Cdefault_003EaddAndGetAnnotation(P_0, P_1);
		}

		public unsafe static Node addMarkerAnnotation(NodeWithAnnotations P_0, string P_1)
		{
			
			return _003Cdefault_003EaddMarkerAnnotation(P_0, P_1);
		}

		public unsafe static Node addMarkerAnnotation(NodeWithAnnotations P_0, Class P_1)
		{
			
			return _003Cdefault_003EaddMarkerAnnotation(P_0, P_1);
		}

		public unsafe static Node addSingleMemberAnnotation(NodeWithAnnotations P_0, string P_1, Expression P_2)
		{
			
			return _003Cdefault_003EaddSingleMemberAnnotation(P_0, P_1, P_2);
		}

		public unsafe static Node addSingleMemberAnnotation(NodeWithAnnotations P_0, Class P_1, Expression P_2)
		{
			
			return _003Cdefault_003EaddSingleMemberAnnotation(P_0, P_1, P_2);
		}

		public unsafe static Node addSingleMemberAnnotation(NodeWithAnnotations P_0, string P_1, string P_2)
		{
			
			return _003Cdefault_003EaddSingleMemberAnnotation(P_0, P_1, P_2);
		}

		public unsafe static Node addSingleMemberAnnotation(NodeWithAnnotations P_0, Class P_1, string P_2)
		{
			
			return _003Cdefault_003EaddSingleMemberAnnotation(P_0, P_1, P_2);
		}

		public unsafe static bool isAnnotationPresent(NodeWithAnnotations P_0, string P_1)
		{
			
			return _003Cdefault_003EisAnnotationPresent(P_0, P_1);
		}

		public unsafe static bool isAnnotationPresent(NodeWithAnnotations P_0, Class P_1)
		{
			
			return _003Cdefault_003EisAnnotationPresent(P_0, P_1);
		}

		public unsafe static Optional getAnnotationByName(NodeWithAnnotations P_0, string P_1)
		{
			
			return _003Cdefault_003EgetAnnotationByName(P_0, P_1);
		}

		public unsafe static Optional getAnnotationByClass(NodeWithAnnotations P_0, Class P_1)
		{
			
			return _003Cdefault_003EgetAnnotationByClass(P_0, P_1);
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
			bool result = ___003C_003EPIM.lambda_0024isAnnotationPresent_00240(arg_00241, (AnnotationExpr)P_0);
			
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
			bool result = ___003C_003EPIM.lambda_0024getAnnotationByName_00241(arg_00241, (AnnotationExpr)P_0);
			
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

		virtual NodeList getAnnotations();

		
	virtual Node setAnnotations(NodeList annotations);

	
		
	virtual Node addSingleMemberAnnotation(string name, Expression expression);

	
	
	
	static Node _003Cdefault_003EaddSingleMemberAnnotation(NodeWithAnnotations P_0, string P_1, Expression P_2)
	{
		SingleMemberAnnotationExpr.___003Cclinit_003E();
		SingleMemberAnnotationExpr element = new SingleMemberAnnotationExpr(StaticJavaParser.parseName(P_1), P_2);
		Node result = P_0.addAnnotation(element);
		
		return result;
	}

	
		
	virtual Node addMarkerAnnotation(string name);

	
	
	
	static Node _003Cdefault_003EaddMarkerAnnotation(NodeWithAnnotations P_0, string P_1)
	{
		MarkerAnnotationExpr.___003Cclinit_003E();
		MarkerAnnotationExpr element = new MarkerAnnotationExpr(StaticJavaParser.parseName(P_1));
		P_0.addAnnotation(element);
		return (Node)P_0;
	}

	
		
	virtual Node addAnnotation(AnnotationExpr element);

	
	
	
	static Node _003Cdefault_003EaddAnnotation(NodeWithAnnotations P_0, AnnotationExpr P_1)
	{
		P_0.getAnnotations().add(P_1);
		return (Node)P_0;
	}

		
	virtual void tryAddImportToParentCompilationUnit(Class clazz);

	
		
	virtual Node addAnnotation(string name);

	
	
	
	static Node _003Cdefault_003EaddAnnotation(NodeWithAnnotations P_0, string P_1)
	{
		NormalAnnotationExpr.___003Cclinit_003E();
		NormalAnnotationExpr element = new NormalAnnotationExpr(StaticJavaParser.parseName(P_1), new NodeList());
		P_0.addAnnotation(element);
		return (Node)P_0;
	}

	
	
	virtual NormalAnnotationExpr addAndGetAnnotation(string name);

	
	
	
	static NormalAnnotationExpr _003Cdefault_003EaddAndGetAnnotation(NodeWithAnnotations P_0, string P_1)
	{
		NormalAnnotationExpr.___003Cclinit_003E();
		NormalAnnotationExpr normalAnnotationExpr = new NormalAnnotationExpr(StaticJavaParser.parseName(P_1), new NodeList());
		P_0.addAnnotation(normalAnnotationExpr);
		return normalAnnotationExpr;
	}

	
		
	virtual Node addSingleMemberAnnotation(string name, string value);

	
	
	
	static Node _003Cdefault_003EaddSingleMemberAnnotation(NodeWithAnnotations P_0, string P_1, string P_2)
	{
		Node result = P_0.addSingleMemberAnnotation(P_1, StaticJavaParser.parseExpression(P_2));
		
		return result;
	}

	
	
	virtual bool isAnnotationPresent(string annotationName);

	
	
	
	static bool _003Cdefault_003EisAnnotationPresent(NodeWithAnnotations P_0, string P_1)
	{
		bool result = P_0.getAnnotations().stream().anyMatch(new ___003C_003EAnon1(P_1));
		
		return result;
	}

	
		
	virtual Optional getAnnotationByName(string annotationName);

	
	
	
	static Optional _003Cdefault_003EgetAnnotationByName(NodeWithAnnotations P_0, string P_1)
	{
		Optional result = P_0.getAnnotations().stream().filter(new ___003C_003EAnon2(P_1))
			.findFirst();
		
		return result;
	}

	
	
	virtual AnnotationExpr getAnnotation(int i);

	
	
	
	static AnnotationExpr _003Cdefault_003EgetAnnotation(NodeWithAnnotations P_0, int P_1)
	{
		return (AnnotationExpr)P_0.getAnnotations().get(P_1);
	}

	
		
	virtual Node setAnnotation(int i, AnnotationExpr element);

	
	
	
	static Node _003Cdefault_003EsetAnnotation(NodeWithAnnotations P_0, int P_1, AnnotationExpr P_2)
	{
		P_0.getAnnotations().set(P_1, P_2);
		return (Node)P_0;
	}

	
		
	virtual Node addAnnotation(Class clazz);

	
	
	
	static Node _003Cdefault_003EaddAnnotation(NodeWithAnnotations P_0, Class P_1)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.addAnnotation(P_1.getSimpleName());
		
		return result;
	}

	
		
	virtual NormalAnnotationExpr addAndGetAnnotation(Class clazz);

	
	
	
	static NormalAnnotationExpr _003Cdefault_003EaddAndGetAnnotation(NodeWithAnnotations P_0, Class P_1)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		NormalAnnotationExpr result = P_0.addAndGetAnnotation(P_1.getSimpleName());
		
		return result;
	}

	
		
	virtual Node addMarkerAnnotation(Class clazz);

	
	
	
	static Node _003Cdefault_003EaddMarkerAnnotation(NodeWithAnnotations P_0, Class P_1)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.addMarkerAnnotation(P_1.getSimpleName());
		
		return result;
	}

	
		
	virtual Node addSingleMemberAnnotation(Class clazz, Expression expression);

	
	
	
	static Node _003Cdefault_003EaddSingleMemberAnnotation(NodeWithAnnotations P_0, Class P_1, Expression P_2)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.addSingleMemberAnnotation(P_1.getSimpleName(), P_2);
		
		return result;
	}

	
		
	virtual Node addSingleMemberAnnotation(Class clazz, string value);

	
	
	
	static Node _003Cdefault_003EaddSingleMemberAnnotation(NodeWithAnnotations P_0, Class P_1, string P_2)
	{
		P_0.tryAddImportToParentCompilationUnit(P_1);
		Node result = P_0.addSingleMemberAnnotation(P_1.getSimpleName(), P_2);
		
		return result;
	}

	
		
	virtual bool isAnnotationPresent(Class annotationClass);

	
	
	
	static bool _003Cdefault_003EisAnnotationPresent(NodeWithAnnotations P_0, Class P_1)
	{
		bool result = P_0.isAnnotationPresent(P_1.getSimpleName());
		
		return result;
	}

	
		
	virtual Optional getAnnotationByClass(Class annotationClass);

	
	
	
	static Optional _003Cdefault_003EgetAnnotationByClass(NodeWithAnnotations P_0, Class P_1)
	{
		Optional annotationByName = P_0.getAnnotationByName(P_1.getSimpleName());
		
		return annotationByName;
	}
}
