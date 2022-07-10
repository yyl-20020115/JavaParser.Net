using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.utils;

public class PositionUtils
{
	
	private sealed class ___003C_003EAnon0 : Comparator
	{
		private readonly bool arg_00241;

		internal ___003C_003EAnon0(bool P_0)
		{
			arg_00241 = P_0;
		}

		public int compare(object P_0, object P_1)
		{
			int result = lambda_0024sortByBeginPosition_00240(arg_00241, (Node)P_0, (Node)P_1);
			
			return result;
		}

		
		public Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public bool equals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}

		
		public Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		
		public Comparator thenComparing(Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		
		public Comparator thenComparing(Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		
		public Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		
		public Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		
		public Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024firstNonAnnotationNode_00241((Modifier)P_0);
			
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
			Position result = lambda_0024firstNonAnnotationNode_00242((Modifier)P_0);
			
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

	
	private sealed class ___003C_003EAnon3 : Predicate
	{
		internal ___003C_003EAnon3()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024firstNonAnnotationNode_00243((Modifier)P_0);
			
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
			Position result = lambda_0024firstNonAnnotationNode_00244((Modifier)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Predicate
	{
		internal ___003C_003EAnon5()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024firstNonAnnotationNode_00245((Modifier)P_0);
			
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

	
	private sealed class ___003C_003EAnon6 : Function
	{
		internal ___003C_003EAnon6()
		{
		}

		public object apply(object P_0)
		{
			Position result = lambda_0024firstNonAnnotationNode_00246((Modifier)P_0);
			
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

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static bool areInOrder(Node a, Node b)
	{
		bool result = areInOrder(a, b, ignoringAnnotations: false);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		Modifiers.Final
	})]
	
	public static void sortByBeginPosition(List nodes, bool ignoringAnnotations)
	{
		nodes.sort(new ___003C_003EAnon0(ignoringAnnotations));
	}

	
		
	
	public static void sortByBeginPosition(List nodes)
	{
		sortByBeginPosition(nodes, ignoringAnnotations: false);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159, 98, 66, 104, 144, 104, 240, 74, 138, 139,
		170, 105, 162, 99, 226, 69, 103, 113, 117, 130,
		22
	})]
	public static bool nodeContains(Node container, Node other, bool ignoringAnnotations)
	{
		if (!container.hasRange())
		{
			
			throw new IllegalArgumentException("Cannot compare the positions of nodes if container node does not have a range.");
		}
		if (!other.hasRange())
		{
			
			throw new IllegalArgumentException("Cannot compare the positions of nodes if contained node does not have a range.");
		}
		int num = ((container is NodeWithAnnotations) ? 1 : 0);
		if (!ignoringAnnotations || getLastAnnotation(container) == null)
		{
			bool result = container.containsWithinRange(other);
			
			return result;
		}
		if (!container.containsWithinRange(other))
		{
			return false;
		}
		if (num == 0)
		{
			return true;
		}
		Node node = firstNonAnnotationNode(container);
		Range range = ((Range)container.getRange().get()).withBegin((Position)node.getBegin().get());
		bool result2 = range.strictlyContains((Range)other.getRange().get());
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public static bool areInOrder(Node a, Node b, bool ignoringAnnotations)
	{
		return compare(a, b, ignoringAnnotations) <= 0;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159, 126, 162, 112, 130, 112, 130, 112, 130, 99,
		115, 99, 149, 194, 113, 145, 116, 100, 149
	})]
	private static int compare(Node a, Node b, bool ignoringAnnotations)
	{
		if (a.hasRange() && !b.hasRange())
		{
			return -1;
		}
		if (!a.hasRange() && b.hasRange())
		{
			return 1;
		}
		if (!a.hasRange() && !b.hasRange())
		{
			return 0;
		}
		if (ignoringAnnotations)
		{
			int num = Integer.signum(beginLineWithoutConsideringAnnotation(a) - beginLineWithoutConsideringAnnotation(b));
			if (num == 0)
			{
				int result = Integer.signum(beginColumnWithoutConsideringAnnotation(a) - beginColumnWithoutConsideringAnnotation(b));
				
				return result;
			}
			return num;
		}
		Position position = (Position)a.getBegin().get();
		Position position2 = (Position)b.getBegin().get();
		int num2 = Integer.signum(position.___003C_003Eline - position2.___003C_003Eline);
		if (num2 == 0)
		{
			int result2 = Integer.signum(position.___003C_003Ecolumn - position2.___003C_003Ecolumn);
			
			return result2;
		}
		return num2;
	}

	
	
	
	private static int beginLineWithoutConsideringAnnotation(Node node)
	{
		return ((Range)firstNonAnnotationNode(node).getRange().get()).___003C_003Ebegin.___003C_003Eline;
	}

	
	
	
	private static int beginColumnWithoutConsideringAnnotation(Node node)
	{
		return ((Range)firstNonAnnotationNode(node).getRange().get()).___003C_003Ebegin.___003C_003Ecolumn;
	}

	
		
	
	public static void sortByBeginPosition(NodeList nodes)
	{
		sortByBeginPosition(nodes, ignoringAnnotations: false);
	}

	
	
	[LineNumberTable(new byte[]
	{
		70, 136, 103, 102, 111, 111, 107, 107, 99, 137,
		130, 136, 103, 102, 111, 111, 107, 107, 99, 137,
		130, 136, 103, 102, 111, 111, 107, 107, 99, 143,
		162
	})]
	private static Node firstNonAnnotationNode(Node node)
	{
		if (node is ClassOrInterfaceDeclaration)
		{
			ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)node;
			Modifier modifier = (Modifier)classOrInterfaceDeclaration.getModifiers().stream().filter(new ___003C_003EAnon1())
				.min(Comparator.comparing(new ___003C_003EAnon2()))
				.orElse(null);
			if (modifier == null)
			{
				SimpleName name = classOrInterfaceDeclaration.getName();
				
				return name;
			}
			return modifier;
		}
		if (node is MethodDeclaration)
		{
			MethodDeclaration methodDeclaration = (MethodDeclaration)node;
			Modifier modifier = (Modifier)methodDeclaration.getModifiers().stream().filter(new ___003C_003EAnon3())
				.min(Comparator.comparing(new ___003C_003EAnon4()))
				.orElse(null);
			if (modifier == null)
			{
				Type type = methodDeclaration.getType();
				
				return type;
			}
			return modifier;
		}
		if (node is FieldDeclaration)
		{
			FieldDeclaration fieldDeclaration = (FieldDeclaration)node;
			Modifier modifier = (Modifier)fieldDeclaration.getModifiers().stream().filter(new ___003C_003EAnon5())
				.min(Comparator.comparing(new ___003C_003EAnon6()))
				.orElse(null);
			if (modifier == null)
			{
				Type type2 = fieldDeclaration.getVariable(0).getType();
				
				return type2;
			}
			return modifier;
		}
		return node;
	}

	
	
	
	public static AnnotationExpr getLastAnnotation(Node node)
	{
		if (node is NodeWithAnnotations)
		{
			NodeList nodeList = NodeList.nodeList(((NodeWithAnnotations)node).getAnnotations());
			if (nodeList.isEmpty())
			{
				return null;
			}
			sortByBeginPosition(nodeList);
			return (AnnotationExpr)nodeList.get(nodeList.size() - 1);
		}
		return null;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static int lambda_0024sortByBeginPosition_00240(bool ignoringAnnotations, Node o1, Node o2)
	{
		int result = compare(o1, o2, ignoringAnnotations);
		
		return result;
	}

	
	
	
	
	private static bool lambda_0024firstNonAnnotationNode_00241(Modifier modifier)
	{
		bool result = modifier.hasRange();
		
		return result;
	}

	
	
	
	
	private static Position lambda_0024firstNonAnnotationNode_00242(Modifier o)
	{
		return ((Range)o.getRange().get()).___003C_003Ebegin;
	}

	
	
	
	
	private static bool lambda_0024firstNonAnnotationNode_00243(Modifier modifier)
	{
		bool result = modifier.hasRange();
		
		return result;
	}

	
	
	
	
	private static Position lambda_0024firstNonAnnotationNode_00244(Modifier o)
	{
		return ((Range)o.getRange().get()).___003C_003Ebegin;
	}

	
	
	
	
	private static bool lambda_0024firstNonAnnotationNode_00245(Modifier modifier)
	{
		bool result = modifier.hasRange();
		
		return result;
	}

	
	
	
	
	private static Position lambda_0024firstNonAnnotationNode_00246(Modifier o)
	{
		return ((Range)o.getRange().get()).___003C_003Ebegin;
	}

	
	
	private PositionUtils()
	{
	}
}
