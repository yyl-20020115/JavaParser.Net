
using com.github.javaparser.ast.comments;
using com.github.javaparser.javadoc;

using java.util;
using java.util.function;

namespace com.github.javaparser.ast.nodeTypes;

public class NodeWithJavadoc
{
	private static class ___003C_003EPIM
	{
		
		
		
		internal static bool lambda_0024getJavadocComment_00240(Comment comment)
		{
			return comment is JavadocComment;
		}

		
		
		
		internal static JavadocComment lambda_0024getJavadocComment_00241(Comment comment)
		{
			return (JavadocComment)comment;
		}
	}

	
	public static class __DefaultMethods
	{
		public unsafe static Optional getJavadocComment(NodeWithJavadoc P_0)
		{
			
			return _003Cdefault_003EgetJavadocComment(P_0);
		}

		public unsafe static Optional getJavadoc(NodeWithJavadoc P_0)
		{
			
			return _003Cdefault_003EgetJavadoc(P_0);
		}

		public unsafe static Node setJavadocComment(NodeWithJavadoc P_0, string P_1)
		{
			
			return _003Cdefault_003EsetJavadocComment(P_0, P_1);
		}

		public unsafe static Node setJavadocComment(NodeWithJavadoc P_0, JavadocComment P_1)
		{
			
			return _003Cdefault_003EsetJavadocComment(P_0, P_1);
		}

		public unsafe static Node setJavadocComment(NodeWithJavadoc P_0, string P_1, Javadoc P_2)
		{
			
			return _003Cdefault_003EsetJavadocComment(P_0, P_1, P_2);
		}

		public unsafe static Node setJavadocComment(NodeWithJavadoc P_0, Javadoc P_1)
		{
			
			return _003Cdefault_003EsetJavadocComment(P_0, P_1);
		}

		public unsafe static bool removeJavaDocComment(NodeWithJavadoc P_0)
		{
			
			return _003Cdefault_003EremoveJavaDocComment(P_0);
		}

		public unsafe static bool hasJavaDocComment(NodeWithJavadoc P_0)
		{
			
			return _003Cdefault_003EhasJavaDocComment(P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = ___003C_003EPIM.lambda_0024getJavadocComment_00240((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			JavadocComment result = ___003C_003EPIM.lambda_0024getJavadocComment_00241((Comment)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			Javadoc result = ((JavadocComment)P_0).parse();
			
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

	
		virtual Optional getJavadocComment();

	
	
	
	static Optional _003Cdefault_003EgetJavadocComment(NodeWithJavadoc P_0)
	{
		Optional result = P_0.getComment().filter(new ___003C_003EAnon1()).map(new ___003C_003EAnon2());
		
		return result;
	}

	
		
	virtual Node setJavadocComment(JavadocComment comment);

	
	
	
	static Node _003Cdefault_003EsetJavadocComment(NodeWithJavadoc P_0, JavadocComment P_1)
	{
		P_0.setComment(P_1);
		return (Node)P_0;
	}

	
		
	virtual Node setJavadocComment(string comment);

	
	
	
	static Node _003Cdefault_003EsetJavadocComment(NodeWithJavadoc P_0, string P_1)
	{
		Node result = P_0.setJavadocComment(new JavadocComment(P_1));
		
		return result;
	}

		virtual Optional getComment();

	
	virtual Node setComment(Comment comment);

	
	virtual bool hasJavaDocComment();

	
	
	
	static bool _003Cdefault_003EhasJavaDocComment(NodeWithJavadoc P_0)
	{
		return (P_0.getComment().isPresent() && P_0.getComment().get() is JavadocComment) ? true : false;
	}

	
		virtual Optional getJavadoc();

	
	
	
	static Optional _003Cdefault_003EgetJavadoc(NodeWithJavadoc P_0)
	{
		Optional result = P_0.getJavadocComment().map(new ___003C_003EAnon3());
		
		return result;
	}


	virtual Node setJavadocComment(string indentation, Javadoc javadoc);

	
	
	
	static Node _003Cdefault_003EsetJavadocComment(NodeWithJavadoc P_0, string P_1, Javadoc P_2)
	{
		Node result = P_0.setJavadocComment(P_2.toComment(P_1));
		
		return result;
	}

	
		
	virtual Node setJavadocComment(Javadoc javadoc);

	
	
	
	static Node _003Cdefault_003EsetJavadocComment(NodeWithJavadoc P_0, Javadoc P_1)
	{
		Node result = P_0.setJavadocComment(P_1.toComment());
		
		return result;
	}

	
	virtual bool removeJavaDocComment();

	
	
	
	static bool _003Cdefault_003EremoveJavaDocComment(NodeWithJavadoc P_0)
	{
		return (P_0.hasJavaDocComment() && ((Comment)P_0.getComment().get()).remove()) ? true : false;
	}
}
