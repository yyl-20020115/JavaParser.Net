using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.printer.configuration;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.concurrent.atomic;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.printer;


[Deprecated(new object[]
{
	(byte)64,
	"Ljava/lang/Deprecated;"
})]
public class PrettyPrintVisitor :  VoidVisitor
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Modifier.Keyword keyword = ((Modifier)P_0).getKeyword();
			
			return keyword;
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

	
	private sealed class ___003C_003EAnon1 : Function
	{
		internal ___003C_003EAnon1()
		{
		}

		public object apply(object P_0)
		{
			string result = ((Modifier.Keyword)P_0).asString();
			
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

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		private readonly java.lang.Void arg_00242;

		internal ___003C_003EAnon2(PrettyPrintVisitor P_0, java.lang.Void P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024printComment_00240(arg_00242, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		private readonly java.lang.Void arg_00242;

		internal ___003C_003EAnon3(PrettyPrintVisitor P_0, java.lang.Void P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00241(arg_00242, (ModuleDeclaration)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Predicate
	{
		internal ___003C_003EAnon4()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024visit_00242((string)P_0);
			
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

	
	private sealed class ___003C_003EAnon5 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		private readonly java.lang.Void arg_00242;

		internal ___003C_003EAnon5(PrettyPrintVisitor P_0, java.lang.Void P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00243(arg_00242, (com.github.javaparser.ast.type.Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		private readonly VariableDeclarator arg_00242;

		private readonly java.lang.Void arg_00243;

		internal ___003C_003EAnon6(PrettyPrintVisitor P_0, VariableDeclarator P_1, java.lang.Void P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00245(arg_00242, arg_00243, (NodeWithVariables)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon7 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		internal ___003C_003EAnon7(PrettyPrintVisitor P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00246((string)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon8 : Function
	{
		internal ___003C_003EAnon8()
		{
		}

		public object apply(object P_0)
		{
			java.lang.Boolean result = lambda_0024visit_00247((Statement)P_0);
			
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

	
	private sealed class ___003C_003EAnon9 : Predicate
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon9(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.isInstance((Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon10 : Function
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon10(Class P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			NodeWithTraversableScope result = (NodeWithTraversableScope)arg_00241.cast((Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon11 : Function
	{
		internal ___003C_003EAnon11()
		{
		}

		public object apply(object P_0)
		{
			Optional result = ((NodeWithTraversableScope)P_0).traverseScope();
			
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

	
	private sealed class ___003C_003EAnon12 : Function
	{
		private readonly Node arg_00241;

		internal ___003C_003EAnon12(Node P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			java.lang.Boolean result = java.lang.Boolean.valueOf(arg_00241.equals((Expression)P_0));
			
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

	
	private sealed class ___003C_003EAnon13 : Supplier
	{
		internal ___003C_003EAnon13()
		{
		}

		public object get()
		{
			AssertionError result = new AssertionError();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon14 : Predicate
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon14(Class P_0)
		{
			arg_00241 = P_0;
		}

		public bool test(object P_0)
		{
			bool result = arg_00241.isInstance((Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon15 : Function
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon15(Class P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			NodeWithTraversableScope result = (NodeWithTraversableScope)arg_00241.cast((Expression)P_0);
			
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

	
	private sealed class ___003C_003EAnon16 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		private readonly java.lang.Void arg_00242;

		private readonly AtomicBoolean arg_00243;

		private readonly AtomicBoolean arg_00244;

		private readonly AtomicBoolean arg_00245;

		internal ___003C_003EAnon16(PrettyPrintVisitor P_0, java.lang.Void P_1, AtomicBoolean P_2, AtomicBoolean P_3, AtomicBoolean P_4)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
			arg_00244 = P_3;
			arg_00245 = P_4;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00248(arg_00242, arg_00243, arg_00244, arg_00245, (Expression)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon17 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		private readonly java.lang.Void arg_00242;

		private readonly MethodDeclaration arg_00243;

		internal ___003C_003EAnon17(PrettyPrintVisitor P_0, java.lang.Void P_1, MethodDeclaration P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00249(arg_00242, arg_00243, (ReceiverParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon18 : Function
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon18(Class P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			java.lang.Boolean result = java.lang.Boolean.valueOf(arg_00241.isInstance((Node)P_0));
			
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

	
	private sealed class ___003C_003EAnon19 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		private readonly java.lang.Void arg_00242;

		internal ___003C_003EAnon19(PrettyPrintVisitor P_0, java.lang.Void P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002410(arg_00242, (com.github.javaparser.ast.type.Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon20 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		internal ___003C_003EAnon20(PrettyPrintVisitor P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002411((SimpleName)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon21 : Predicate
	{
		internal ___003C_003EAnon21()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024visit_002412((EnumConstantDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon22 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		internal ___003C_003EAnon22(PrettyPrintVisitor P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002413((SimpleName)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon23 : ToIntFunction
	{
		internal ___003C_003EAnon23()
		{
		}

		public int applyAsInt(object P_0)
		{
			int result = lambda_0024visit_002414((ImportDeclaration)P_0);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon24 : Function
	{
		internal ___003C_003EAnon24()
		{
		}

		public object apply(object P_0)
		{
			string nameAsString = ((NodeWithName)(ImportDeclaration)P_0).getNameAsString();
			
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

	
	private sealed class ___003C_003EAnon25 : Predicate
	{
		internal ___003C_003EAnon25()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024printOrphanCommentsEnding_002415((Node)P_0);
			
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

	
	private sealed class ___003C_003EAnon26 : Consumer
	{
		private readonly PrettyPrintVisitor arg_00241;

		private readonly VariableDeclarator arg_00242;

		private readonly java.lang.Void arg_00243;

		internal ___003C_003EAnon26(PrettyPrintVisitor P_0, VariableDeclarator P_1, java.lang.Void P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_00244(arg_00242, arg_00243, (com.github.javaparser.ast.type.Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	protected internal PrettyPrinterConfiguration configuration;

	internal SourcePrinter ___003C_003Eprinter;

	
	protected internal SourcePrinter printer
	{
		
		get
		{
			return ___003C_003Eprinter;
		}
		
		private set
		{
			___003C_003Eprinter = value;
		}
	}

	
	
	
	public PrettyPrintVisitor(PrettyPrinterConfiguration prettyPrinterConfiguration)
	{
		configuration = prettyPrinterConfiguration;
		___003C_003Eprinter = new SourcePrinter(configuration);
	}

	
	
	[LineNumberTable(new byte[]
	{
		167, 37, 110, 137, 114, 100, 113, 102, 98, 107,
		106, 98, 226, 61, 230, 70, 100, 144, 98, 110,
		50, 168, 109, 111, 105, 113, 159, 27, 233, 58,
		235, 72
	})]
	private void printOrphanCommentsBeforeThisChildNode(Node node)
	{
		if (configuration.isIgnoreComments() || node is Comment)
		{
			return;
		}
		Node node2 = (Node)node.getParentNode().orElse(null);
		if (node2 == null)
		{
			return;
		}
		
		ArrayList arrayList = new ArrayList(node2.getChildNodes());
		PositionUtils.sortByBeginPosition(arrayList);
		int num = -1;
		int i;
		for (i = 0; i < ((List)arrayList).size(); i++)
		{
			if (((List)arrayList).get(i) == node)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			
			throw new AssertionError("I am not a child of my parent.");
		}
		i = -1;
		for (int j = num - 1; j >= 0; j += -1)
		{
			if (i != -1)
			{
				break;
			}
			if (!(((List)arrayList).get(j) is Comment))
			{
				i = j;
			}
		}
		for (int j = i + 1; j < num; j++)
		{
			Node node3 = (Node)((List)arrayList).get(j);
			if (!(node3 is Comment))
			{
				string message = new StringBuilder().append("Expected comment, instead ").append(java.lang.Object.instancehelper_getClass(node3)).append(". Position of previous child: ")
					.append(i)
					.append(", position of child ")
					.append(num)
					.ToString();
				
				throw new RuntimeException(message);
			}
			node3.accept(this, null);
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	protected internal virtual void printComment(Optional comment, java.lang.Void arg)
	{
		comment.ifPresent(new ___003C_003EAnon2(this, arg));
	}

	
	
	[LineNumberTable(new byte[]
	{
		167, 69, 174, 127, 11, 102, 104, 161, 98, 98,
		108, 118, 106, 99, 132, 98, 104, 61, 168
	})]
	private void printOrphanCommentsEnding(Node node)
	{
		if (configuration.isIgnoreComments())
		{
			return;
		}
		List list = (List)node.getChildNodes().stream().filter(new ___003C_003EAnon25())
			.collect(Collectors.toList());
		PositionUtils.sortByBeginPosition(list);
		if (list.isEmpty())
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		while (num2 != 0 && num < list.size())
		{
			Node node2 = (Node)list.get(list.size() - 1 - num);
			num2 = ((node2 is Comment) ? 1 : 0);
			if (num2 != 0)
			{
				num++;
			}
		}
		for (int i = 0; i < num; i++)
		{
			((Node)list.get(list.size() - num + i)).accept(this, null);
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	protected internal virtual void printMemberAnnotations(NodeList annotations, java.lang.Void arg)
	{
		if (!annotations.isEmpty())
		{
			Iterator iterator = annotations.iterator();
			while (iterator.hasNext())
			{
				AnnotationExpr annotationExpr = (AnnotationExpr)iterator.next();
				annotationExpr.accept(this, arg);
				___003C_003Eprinter.println();
			}
		}
	}

	
		
	
	protected internal virtual void printModifiers(NodeList modifiers)
	{
		if (modifiers.size() > 0)
		{
			SourcePrinter __003C_003Eprinter = ___003C_003Eprinter;
			StringBuilder stringBuilder = new StringBuilder();
			Stream stream = modifiers.stream().map(new ___003C_003EAnon0()).map(new ___003C_003EAnon1());
			CharSequence delimiter = default(CharSequence);
			object obj = (delimiter.___003Cref_003E = " ");
			__003C_003Eprinter.print(stringBuilder.append((string)stream.collect(Collectors.joining(delimiter))).append(" ").ToString());
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 94, 104, 113, 111, 108, 104, 104, 145, 98,
		145
	})]
	protected internal virtual void printTypeParameters(NodeList args, java.lang.Void arg)
	{
		if (Utils.isNullOrEmpty(args))
		{
			return;
		}
		___003C_003Eprinter.print("<");
		Iterator iterator = args.iterator();
		while (iterator.hasNext())
		{
			TypeParameter typeParameter = (TypeParameter)iterator.next();
			typeParameter.accept(this, arg);
			if (iterator.hasNext())
			{
				___003C_003Eprinter.print(", ");
			}
		}
		___003C_003Eprinter.print(">");
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	protected internal virtual void printMembers(NodeList members, java.lang.Void arg)
	{
		Iterator iterator = members.iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			___003C_003Eprinter.println();
			bodyDeclaration.accept(this, arg);
			___003C_003Eprinter.println();
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		(Modifiers)0,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		159, 97, 66, 104, 129, 99, 145, 123, 104, 113,
		98
	})]
	protected internal virtual void printAnnotations(NodeList annotations, bool prefixWithASpace, java.lang.Void arg)
	{
		if (!annotations.isEmpty())
		{
			if (prefixWithASpace)
			{
				___003C_003Eprinter.print(" ");
			}
			Iterator iterator = annotations.iterator();
			while (iterator.hasNext())
			{
				AnnotationExpr annotationExpr = (AnnotationExpr)iterator.next();
				annotationExpr.accept(this, arg);
				___003C_003Eprinter.print(" ");
			}
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 79, 114, 107, 113, 111, 108, 104, 104, 145,
		98, 145
	})]
	protected internal virtual void printTypeArgs(NodeWithTypeArguments nodeWithTypeArguments, java.lang.Void arg)
	{
		NodeList nodeList = (NodeList)nodeWithTypeArguments.getTypeArguments().orElse(null);
		if (Utils.isNullOrEmpty(nodeList))
		{
			return;
		}
		___003C_003Eprinter.print("<");
		Iterator iterator = nodeList.iterator();
		while (iterator.hasNext())
		{
			com.github.javaparser.ast.type.Type type = (com.github.javaparser.ast.type.Type)iterator.next();
			type.accept(this, arg);
			if (iterator.hasNext())
			{
				___003C_003Eprinter.print(", ");
			}
		}
		___003C_003Eprinter.print(">");
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 108, 113, 107, 123, 99, 156, 111, 108, 104,
		104, 113, 99, 142, 177, 98, 99, 172, 113
	})]
	protected internal virtual void printArguments(NodeList args, java.lang.Void arg)
	{
		___003C_003Eprinter.print("(");
		if (!Utils.isNullOrEmpty(args))
		{
			int num = ((args.size() > 1 && configuration.isColumnAlignParameters()) ? 1 : 0);
			if (num != 0)
			{
				___003C_003Eprinter.indentWithAlignTo(___003C_003Eprinter.getCursor().___003C_003Ecolumn);
			}
			Iterator iterator = args.iterator();
			while (iterator.hasNext())
			{
				Expression expression = (Expression)iterator.next();
				expression.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(",");
					if (num != 0)
					{
						___003C_003Eprinter.println();
					}
					else
					{
						___003C_003Eprinter.print(" ");
					}
				}
			}
			if (num != 0)
			{
				___003C_003Eprinter.unindent();
			}
		}
		___003C_003Eprinter.print(")");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		164, 212, 109, 113, 109, 113, 104, 113, 127, 1,
		104, 98, 145, 113
	})]
	private void printSwitchNode(SwitchNode n, java.lang.Void arg)
	{
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("switch(");
		n.getSelector().accept(this, arg);
		___003C_003Eprinter.println(") {");
		if (n.getEntries() != null)
		{
			indentIf(configuration.isIndentCaseInSwitch());
			Iterator iterator = n.getEntries().iterator();
			while (iterator.hasNext())
			{
				SwitchEntry switchEntry = (SwitchEntry)iterator.next();
				switchEntry.accept(this, arg);
			}
			unindentIf(configuration.isIndentCaseInSwitch());
		}
		___003C_003Eprinter.print("}");
	}

	
	
	
	private void indentIf(bool expr)
	{
		if (expr)
		{
			___003C_003Eprinter.indent();
		}
	}

	
	
	
	private void unindentIf(bool expr)
	{
		if (expr)
		{
			___003C_003Eprinter.unindent();
		}
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 134, 104, 109, 111, 108, 104, 104, 142, 98,
		142
	})]
	protected internal virtual void printPrePostFixOptionalList(NodeList args, java.lang.Void arg, string prefix, string separator, string postfix)
	{
		if (args.isEmpty())
		{
			return;
		}
		___003C_003Eprinter.print(prefix);
		Iterator iterator = args.iterator();
		while (iterator.hasNext())
		{
			Visitable visitable = (Visitable)iterator.next();
			visitable.accept(this, arg);
			if (iterator.hasNext())
			{
				___003C_003Eprinter.print(separator);
			}
		}
		___003C_003Eprinter.print(postfix);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		(Modifiers)0,
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		160, 148, 109, 104, 111, 108, 104, 104, 142, 130,
		110
	})]
	protected internal virtual void printPrePostFixRequiredList(NodeList args, java.lang.Void arg, string prefix, string separator, string postfix)
	{
		___003C_003Eprinter.print(prefix);
		if (!args.isEmpty())
		{
			Iterator iterator = args.iterator();
			while (iterator.hasNext())
			{
				Visitable visitable = (Visitable)iterator.next();
				visitable.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(separator);
				}
			}
		}
		___003C_003Eprinter.print(postfix);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(PatternExpr n, java.lang.Void arg)
	{
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(" ");
		n.getName().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(YieldStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("yield ");
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(TextBlockLiteralExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("\"\"\"");
		___003C_003Eprinter.indent();
		n.stripIndentOfLines().forEach(new ___003C_003EAnon7(this));
		___003C_003Eprinter.print("\"\"\"");
		___003C_003Eprinter.unindent();
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(SwitchExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printSwitchNode(n, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(Modifier n, java.lang.Void arg)
	{
		___003C_003Eprinter.print(n.getKeyword().asString());
		___003C_003Eprinter.print(" ");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(VarType n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		___003C_003Eprinter.print("var");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ReceiverParameter n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(" ");
		n.getName().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(UnparsableStmt n, java.lang.Void arg)
	{
		___003C_003Eprinter.print("???;");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(ModuleOpensDirective n, java.lang.Void arg)
	{
		___003C_003Eprinter.print("opens ");
		n.getName().accept(this, arg);
		printPrePostFixOptionalList(n.getModuleNames(), arg, " to ", ", ", "");
		___003C_003Eprinter.println(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(ModuleUsesDirective n, java.lang.Void arg)
	{
		___003C_003Eprinter.print("uses ");
		n.getName().accept(this, arg);
		___003C_003Eprinter.println(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(ModuleProvidesDirective n, java.lang.Void arg)
	{
		___003C_003Eprinter.print("provides ");
		n.getName().accept(this, arg);
		printPrePostFixRequiredList(n.getWith(), arg, " with ", ", ", "");
		___003C_003Eprinter.println(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(ModuleExportsDirective n, java.lang.Void arg)
	{
		___003C_003Eprinter.print("exports ");
		n.getName().accept(this, arg);
		printPrePostFixOptionalList(n.getModuleNames(), arg, " to ", ", ", "");
		___003C_003Eprinter.println(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(ModuleRequiresDirective n, java.lang.Void arg)
	{
		___003C_003Eprinter.print("requires ");
		printModifiers(n.getModifiers());
		n.getName().accept(this, arg);
		___003C_003Eprinter.println(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(ModuleDeclaration n, java.lang.Void arg)
	{
		printMemberAnnotations(n.getAnnotations(), arg);
		if (n.isOpen())
		{
			___003C_003Eprinter.print("open ");
		}
		___003C_003Eprinter.print("module ");
		n.getName().accept(this, arg);
		___003C_003Eprinter.println(" {").indent();
		n.getDirectives().accept(this, arg);
		___003C_003Eprinter.unindent().println("}");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 227, 103, 109, 110, 113, 109, 113, 151, 109,
		113, 153
	})]
	public virtual void visit(WildcardType n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		___003C_003Eprinter.print("?");
		if (n.getExtendedType().isPresent())
		{
			___003C_003Eprinter.print(" extends ");
			((ReferenceType)n.getExtendedType().get()).accept(this, arg);
		}
		if (n.getSuperType().isPresent())
		{
			___003C_003Eprinter.print(" super ");
			((ReferenceType)n.getSuperType().get()).accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(WhileStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("while (");
		n.getCondition().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getBody().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(VoidType n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		___003C_003Eprinter.print("void");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162,
		19,
		103,
		109,
		141,
		byte.MaxValue,
		7,
		81,
		109,
		113,
		153
	})]
	public virtual void visit(VariableDeclarator n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getName().accept(this, arg);
		n.findAncestor(new Class[1] { ClassLiteral<NodeWithVariables>.Value }).ifPresent(new ___003C_003EAnon6(this, n, arg));
		if (n.getInitializer().isPresent())
		{
			___003C_003Eprinter.print(" = ");
			((Expression)n.getInitializer().get()).accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 108, 103, 109, 127, 28, 143, 142, 140, 109,
		151, 145, 116, 108, 104, 104, 145, 98
	})]
	public unsafe virtual void visit(VariableDeclarationExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		Optional parentNode = n.getParentNode();
		Class value = ClassLiteral<ExpressionStmt>.Value;
		
		if (((java.lang.Boolean)parentNode.map(new ___003C_003EAnon18(value)).orElse(java.lang.Boolean.valueOf(b: false))).booleanValue())
		{
			printMemberAnnotations(n.getAnnotations(), arg);
		}
		else
		{
			printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		}
		printModifiers(n.getModifiers());
		if (!n.getVariables().isEmpty())
		{
			n.getMaximumCommonType().ifPresent(new ___003C_003EAnon19(this, arg));
		}
		___003C_003Eprinter.print(" ");
		Iterator iterator = n.getVariables().iterator();
		while (iterator.hasNext())
		{
			VariableDeclarator variableDeclarator = (VariableDeclarator)iterator.next();
			variableDeclarator.accept(this, arg);
			if (iterator.hasNext())
			{
				___003C_003Eprinter.print(", ");
			}
		}
	}

	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	public virtual void visit(UnknownType n, java.lang.Void arg)
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 211, 103, 109, 110, 98, 127, 1, 99, 132,
		145, 104, 98
	})]
	public virtual void visit(UnionType n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: true, arg);
		int num = 1;
		Iterator iterator = n.getElements().iterator();
		while (iterator.hasNext())
		{
			ReferenceType referenceType = (ReferenceType)iterator.next();
			if (num != 0)
			{
				num = 0;
			}
			else
			{
				___003C_003Eprinter.print(" | ");
			}
			referenceType.accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(UnaryExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.getOperator().isPrefix())
		{
			___003C_003Eprinter.print(n.getOperator().asString());
		}
		n.getExpression().accept(this, arg);
		if (n.getOperator().isPostfix())
		{
			___003C_003Eprinter.print(n.getOperator().asString());
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 142, 103, 109, 110, 109, 109, 113, 116, 108,
		104, 104, 145, 130
	})]
	public virtual void visit(TypeParameter n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		n.getName().accept(this, arg);
		if (Utils.isNullOrEmpty(n.getTypeBound()))
		{
			return;
		}
		___003C_003Eprinter.print(" extends ");
		Iterator iterator = n.getTypeBound().iterator();
		while (iterator.hasNext())
		{
			ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
			classOrInterfaceType.accept(this, arg);
			if (iterator.hasNext())
			{
				___003C_003Eprinter.print(" & ");
			}
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(TypeExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.getType() != null)
		{
			n.getType().accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		165, 245, 103, 109, 113, 112, 113, 108, 98, 104,
		114, 104, 113, 108, 99, 172, 132, 110, 140, 145,
		109, 127, 1, 104, 98, 109, 113, 153
	})]
	public virtual void visit(TryStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("try ");
		Iterator iterator;
		if (!n.getResources().isEmpty())
		{
			___003C_003Eprinter.print("(");
			iterator = n.getResources().iterator();
			int num = 1;
			while (iterator.hasNext())
			{
				((Expression)iterator.next()).accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(";");
					___003C_003Eprinter.println();
					if (num != 0)
					{
						___003C_003Eprinter.indent();
					}
				}
				num = 0;
			}
			if (n.getResources().size() > 1)
			{
				___003C_003Eprinter.unindent();
			}
			___003C_003Eprinter.print(") ");
		}
		n.getTryBlock().accept(this, arg);
		iterator = n.getCatchClauses().iterator();
		while (iterator.hasNext())
		{
			CatchClause catchClause = (CatchClause)iterator.next();
			catchClause.accept(this, arg);
		}
		if (n.getFinallyBlock().isPresent())
		{
			___003C_003Eprinter.print(" finally ");
			((BlockStmt)n.getFinallyBlock().get()).accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ThrowStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("throw ");
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ThisExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.getTypeName().isPresent())
		{
			((Name)n.getTypeName().get()).accept(this, arg);
			___003C_003Eprinter.print(".");
		}
		___003C_003Eprinter.print("this");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SynchronizedStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("synchronized (");
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getBody().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SwitchStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printSwitchNode(n, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 228, 103, 141, 122, 109, 159, 12, 113, 116,
		108, 104, 104, 145, 98, 141, 108, 108, 104, 127,
		1, 104, 108, 130, 108
	})]
	public virtual void visit(SwitchEntry n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		string text = ((n.getType() != SwitchEntry.Type.___003C_003ESTATEMENT_GROUP) ? " ->" : ":");
		if (Utils.isNullOrEmpty(n.getLabels()))
		{
			___003C_003Eprinter.print(new StringBuilder().append("default").append(text).ToString());
		}
		else
		{
			___003C_003Eprinter.print("case ");
			Iterator iterator = n.getLabels().iterator();
			while (iterator.hasNext())
			{
				Expression expression = (Expression)iterator.next();
				expression.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
			___003C_003Eprinter.print(text);
		}
		___003C_003Eprinter.println();
		___003C_003Eprinter.indent();
		if (n.getStatements() != null)
		{
			Iterator iterator = n.getStatements().iterator();
			while (iterator.hasNext())
			{
				Statement statement = (Statement)iterator.next();
				statement.accept(this, arg);
				___003C_003Eprinter.println();
			}
		}
		___003C_003Eprinter.unindent();
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SuperExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.getTypeName().isPresent())
		{
			((Name)n.getTypeName().get()).accept(this, arg);
			___003C_003Eprinter.print(".");
		}
		___003C_003Eprinter.print("super");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(StringLiteralExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("\"");
		___003C_003Eprinter.print(n.getValue());
		___003C_003Eprinter.print("\"");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SingleMemberAnnotationExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("@");
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("(");
		n.getMemberValue().accept(this, arg);
		___003C_003Eprinter.print(")");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(SimpleName n, java.lang.Void arg)
	{
		___003C_003Eprinter.print(n.getIdentifier());
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ReturnStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("return");
		if (n.getExpression().isPresent())
		{
			___003C_003Eprinter.print(" ");
			((Expression)n.getExpression().get()).accept(this, arg);
		}
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 239, 103, 109, 109, 140, 109, 104, 145, 141,
		109, 113, 116, 108, 104, 104, 145, 130, 113, 111
	})]
	public virtual void visit(CompactConstructorDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		printTypeParameters(n.getTypeParameters(), arg);
		if (n.isGeneric())
		{
			___003C_003Eprinter.print(" ");
		}
		n.getName().accept(this, arg);
		if (!Utils.isNullOrEmpty(n.getThrownExceptions()))
		{
			___003C_003Eprinter.print(" throws ");
			Iterator iterator = n.getThrownExceptions().iterator();
			while (iterator.hasNext())
			{
				ReferenceType referenceType = (ReferenceType)iterator.next();
				referenceType.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.print(" ");
		n.getBody().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		161, 33, 103, 109, 109, 140, 145, 141, 113, 109,
		116, 108, 104, 104, 145, 130, 145, 141, 109, 113,
		116, 108, 104, 104, 145, 162, 113, 108, 109, 173,
		135, 108, 113
	})]
	public virtual void visit(RecordDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		___003C_003Eprinter.print("record ");
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("(");
		if (!Utils.isNullOrEmpty(n.getParameters()))
		{
			Iterator iterator = n.getParameters().iterator();
			while (iterator.hasNext())
			{
				Parameter parameter = (Parameter)iterator.next();
				parameter.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.print(")");
		printTypeParameters(n.getTypeParameters(), arg);
		if (!n.getImplementedTypes().isEmpty())
		{
			___003C_003Eprinter.print(" implements ");
			Iterator iterator = n.getImplementedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
				classOrInterfaceType.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.println(" {");
		___003C_003Eprinter.indent();
		if (!Utils.isNullOrEmpty(n.getMembers()))
		{
			printMembers(n.getMembers(), arg);
		}
		printOrphanCommentsEnding(n);
		___003C_003Eprinter.unindent();
		___003C_003Eprinter.print("}");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(PrimitiveType n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: true, arg);
		___003C_003Eprinter.print(n.getType().asString());
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 62, 103, 109, 110, 108, 109, 104, 110, 145,
		109, 145, 111
	})]
	public virtual void visit(Parameter n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		printModifiers(n.getModifiers());
		n.getType().accept(this, arg);
		if (n.isVarArgs())
		{
			printAnnotations(n.getVarArgsAnnotations(), prefixWithASpace: false, arg);
			___003C_003Eprinter.print("...");
		}
		if (!(n.getType() is UnknownType))
		{
			___003C_003Eprinter.print(" ");
		}
		n.getName().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(PackageDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		___003C_003Eprinter.print("package ");
		n.getName().accept(this, arg);
		___003C_003Eprinter.println(";");
		___003C_003Eprinter.println();
		printOrphanCommentsEnding(n);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 155, 103, 109, 104, 119, 177, 145, 104, 120,
		177, 141, 141, 109, 113, 108, 119, 108, 145
	})]
	public virtual void visit(ObjectCreationExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.hasScope())
		{
			((Expression)n.getScope().get()).accept(this, arg);
			___003C_003Eprinter.print(".");
		}
		___003C_003Eprinter.print("new ");
		printTypeArgs(n, arg);
		if (!Utils.isNullOrEmpty((Collection)n.getTypeArguments().orElse(null)))
		{
			___003C_003Eprinter.print(" ");
		}
		n.getType().accept(this, arg);
		printArguments(n.getArguments(), arg);
		if (n.getAnonymousClassBody().isPresent())
		{
			___003C_003Eprinter.println(" {");
			___003C_003Eprinter.indent();
			printMembers((NodeList)n.getAnonymousClassBody().get(), arg);
			___003C_003Eprinter.unindent();
			___003C_003Eprinter.print("}");
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(NullLiteralExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("null");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		166, 89, 103, 109, 113, 109, 113, 104, 116, 108,
		104, 104, 145, 130, 113
	})]
	public virtual void visit(NormalAnnotationExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("@");
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("(");
		if (n.getPairs() != null)
		{
			Iterator iterator = n.getPairs().iterator();
			while (iterator.hasNext())
			{
				MemberValuePair memberValuePair = (MemberValuePair)iterator.next();
				memberValuePair.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.print(")");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(Name n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.getQualifier().isPresent())
		{
			((Name)n.getQualifier().get()).accept(this, arg);
			___003C_003Eprinter.print(".");
		}
		___003C_003Eprinter.print(n.getIdentifier());
		printOrphanCommentsEnding(n);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(NameExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getName().accept(this, arg);
		printOrphanCommentsEnding(n);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		166, 175, 103, 109, 103, 103, 99, 173, 113, 104,
		99, 141
	})]
	public virtual void visit(MethodReferenceExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		Expression scope = n.getScope();
		string identifier = n.getIdentifier();
		if (scope != null)
		{
			n.getScope().accept(this, arg);
		}
		___003C_003Eprinter.print("::");
		printTypeArgs(n, arg);
		if (identifier != null)
		{
			___003C_003Eprinter.print(identifier);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 10, 135, 109, 109, 108, 109, 109, 177, 109,
		113, 141, 113, 248, 70, 109, 116, 108, 104, 104,
		145, 130, 145, 109, 113, 116, 108, 104, 104, 145,
		130, 109, 147, 113, 153
	})]
	public virtual void visit(MethodDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		printTypeParameters(n.getTypeParameters(), arg);
		if (!Utils.isNullOrEmpty(n.getTypeParameters()))
		{
			___003C_003Eprinter.print(" ");
		}
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(" ");
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("(");
		n.getReceiverParameter().ifPresent(new ___003C_003EAnon17(this, arg, n));
		if (!Utils.isNullOrEmpty(n.getParameters()))
		{
			Iterator iterator = n.getParameters().iterator();
			while (iterator.hasNext())
			{
				Parameter parameter = (Parameter)iterator.next();
				parameter.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.print(")");
		if (!Utils.isNullOrEmpty(n.getThrownExceptions()))
		{
			___003C_003Eprinter.print(" throws ");
			Iterator iterator = n.getThrownExceptions().iterator();
			while (iterator.hasNext())
			{
				ReferenceType referenceType = (ReferenceType)iterator.next();
				referenceType.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		if (!n.getBody().isPresent())
		{
			___003C_003Eprinter.print(";");
			return;
		}
		___003C_003Eprinter.print(" ");
		((BlockStmt)n.getBody().get()).accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163,
		51,
		103,
		237,
		70,
		102,
		144,
		191,
		5,
		239,
		61,
		234,
		69,
		98,
		108,
		127,
		36,
		111,
		122,
		102,
		118,
		108,
		204,
		byte.MaxValue,
		17,
		70,
		103,
		107,
		99,
		127,
		1,
		126,
		111,
		123,
		102,
		239,
		59,
		231,
		70,
		125,
		108,
		103,
		226,
		71,
		103,
		107,
		104,
		127,
		11,
		127,
		11,
		103,
		127,
		17,
		104,
		130,
		100,
		229,
		69,
		251,
		87,
		104,
		109,
		107,
		109,
		108,
		153,
		141
	})]
	public unsafe virtual void visit(MethodCallExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		AtomicBoolean atomicBoolean = new AtomicBoolean();
		if (configuration.isColumnAlignFirstMethodChain() && ((java.lang.Boolean)n.findAncestor(new Class[1] { ClassLiteral<Statement>.Value }).map(new ___003C_003EAnon8()).orElse(java.lang.Boolean.valueOf(b: false))).booleanValue())
		{
			Node node = n;
			Optional parentNode = ((MethodCallExpr)node).getParentNode();
			while (parentNode.isPresent())
			{
				Optional optional = parentNode;
				Class value = ClassLiteral<NodeWithTraversableScope>.Value;
				
				Optional optional2 = optional.filter(new ___003C_003EAnon9(value));
				Class value2 = ClassLiteral<NodeWithTraversableScope>.Value;
				
				Optional optional3 = optional2.map(new ___003C_003EAnon10(value2)).flatMap(new ___003C_003EAnon11());
				Node node2 = node;
				
				if (!((java.lang.Boolean)optional3.map(new ___003C_003EAnon12(node2)).orElse(java.lang.Boolean.valueOf(b: false))).booleanValue())
				{
					break;
				}
				node = (Node)parentNode.get();
				parentNode = node.getParentNode();
			}
			Optional optional4 = parentNode;
			Class value3 = ClassLiteral<MethodCallExpr>.Value;
			
			atomicBoolean.set((!optional4.filter(new ___003C_003EAnon9(value3)).isPresent()) ? true : false);
		}
		AtomicBoolean atomicBoolean2 = new AtomicBoolean(initialValue: true);
		if (atomicBoolean.get())
		{
			Node node3 = n;
			while (true)
			{
				Optional parentNode2 = node3.getParentNode();
				Class value4 = ClassLiteral<NodeWithTraversableScope>.Value;
				
				Optional optional5 = parentNode2.filter(new ___003C_003EAnon9(value4));
				Class value5 = ClassLiteral<NodeWithTraversableScope>.Value;
				
				Optional optional6 = optional5.map(new ___003C_003EAnon10(value5)).flatMap(new ___003C_003EAnon11());
				Node node4 = node3;
				
				if (!((java.lang.Boolean)optional6.map(new ___003C_003EAnon12(node4)).orElse(java.lang.Boolean.valueOf(b: false))).booleanValue())
				{
					break;
				}
				node3 = (Node)node3.getParentNode().orElseThrow(new ___003C_003EAnon13());
				if (node3 is MethodCallExpr)
				{
					atomicBoolean2.set(newValue: false);
					break;
				}
			}
		}
		AtomicBoolean atomicBoolean3 = new AtomicBoolean();
		if (atomicBoolean.get())
		{
			Optional optional7 = n.getScope();
			while (true)
			{
				Optional optional8 = optional7;
				Class value6 = ClassLiteral<NodeWithTraversableScope>.Value;
				
				if (!optional8.filter(new ___003C_003EAnon14(value6)).isPresent())
				{
					break;
				}
				Optional optional9 = optional7;
				Class value7 = ClassLiteral<NodeWithTraversableScope>.Value;
				
				Optional optional10 = optional9.map(new ___003C_003EAnon15(value7)).flatMap(new ___003C_003EAnon11());
				Optional optional11 = optional7;
				Class value8 = ClassLiteral<MethodCallExpr>.Value;
				
				if (optional11.filter(new ___003C_003EAnon14(value8)).isPresent() && optional10.isPresent())
				{
					atomicBoolean3.set(newValue: true);
					break;
				}
				optional7 = optional10;
			}
		}
		n.getScope().ifPresent(new ___003C_003EAnon16(this, arg, atomicBoolean, atomicBoolean3, atomicBoolean2));
		printTypeArgs(n, arg);
		n.getName().accept(this, arg);
		___003C_003Eprinter.duplicateIndent();
		printArguments(n.getArguments(), arg);
		___003C_003Eprinter.unindent();
		if (atomicBoolean.get() && atomicBoolean3.get() && atomicBoolean2.get())
		{
			___003C_003Eprinter.reindentToPreviousLevel();
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(MemberValuePair n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getName().accept(this, arg);
		___003C_003Eprinter.print(" = ");
		n.getValue().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(MarkerAnnotationExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("@");
		n.getName().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LongLiteralExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(n.getValue());
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LocalRecordDeclarationStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getRecordDeclaration().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LocalClassDeclarationStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getClassDeclaration().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LineComment n, java.lang.Void arg)
	{
		if (!configuration.isIgnoreComments())
		{
			___003C_003Eprinter.print("// ").println(java.lang.String.instancehelper_trim(Utils.normalizeEolInTextBlock(n.getContent(), "")));
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		166, 143, 103, 141, 103, 135, 99, 145, 111, 108,
		104, 104, 145, 98, 99, 177, 113, 104, 137, 149,
		139
	})]
	public virtual void visit(LambdaExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		NodeList parameters = n.getParameters();
		int num = (n.isEnclosingParameters() ? 1 : 0);
		if (num != 0)
		{
			___003C_003Eprinter.print("(");
		}
		Iterator iterator = parameters.iterator();
		while (iterator.hasNext())
		{
			Parameter parameter = (Parameter)iterator.next();
			parameter.accept(this, arg);
			if (iterator.hasNext())
			{
				___003C_003Eprinter.print(", ");
			}
		}
		if (num != 0)
		{
			___003C_003Eprinter.print(")");
		}
		___003C_003Eprinter.print(" -> ");
		Statement body = n.getBody();
		if (body is ExpressionStmt)
		{
			((ExpressionStmt)body).getExpression().accept(this, arg);
		}
		else
		{
			body.accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LabeledStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getLabel().accept(this, arg);
		___003C_003Eprinter.print(": ");
		n.getStatement().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 81, 103, 127, 1, 113, 119, 108, 102, 117,
		105, 110, 138, 105, 233, 58, 232, 73, 99, 99,
		119, 127, 3, 105, 100, 165, 99, 100, 113, 131,
		113, 100, 145, 142, 101, 145
	})]
	public virtual void visit(JavadocComment n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		if (!configuration.isPrintComments() || !configuration.isPrintJavadoc())
		{
			return;
		}
		___003C_003Eprinter.println("/**");
		string @this = Utils.normalizeEolInTextBlock(n.getContent(), configuration.getEndOfLineCharacter());
		string[] array = java.lang.String.instancehelper_split(@this, "\\R");
		ArrayList arrayList = new ArrayList();
		string[] array2 = array;
		int num = array2.Length;
		int i;
		for (i = 0; i < num; i++)
		{
			string text = array2[i];
			string this2 = java.lang.String.instancehelper_trim(text);
			if (java.lang.String.instancehelper_startsWith(this2, "*"))
			{
				text = java.lang.String.instancehelper_substring(this2, 1);
			}
			text = Utils.trimTrailingSpaces(text);
			((List)arrayList).add((object)text);
		}
		int num2 = 1;
		num = 0;
		i = (((Collection)arrayList).stream().anyMatch(new ___003C_003EAnon4()) ? 1 : 0);
		Iterator iterator = ((List)arrayList).iterator();
		while (iterator.hasNext())
		{
			string this2 = (string)iterator.next();
			if (java.lang.String.instancehelper_isEmpty(this2))
			{
				if (num2 == 0)
				{
					num = 1;
				}
				continue;
			}
			num2 = 0;
			if (num != 0)
			{
				___003C_003Eprinter.println(" *");
				num = 0;
			}
			___003C_003Eprinter.print(" *");
			if (i != 0)
			{
				___003C_003Eprinter.print(" ");
			}
			___003C_003Eprinter.println(this2);
		}
		___003C_003Eprinter.println(" */");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 195, 103, 109, 110, 98, 127, 1, 99, 132,
		145, 104, 98
	})]
	public virtual void visit(IntersectionType n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		int num = 1;
		Iterator iterator = n.getElements().iterator();
		while (iterator.hasNext())
		{
			ReferenceType referenceType = (ReferenceType)iterator.next();
			if (num != 0)
			{
				num = 0;
			}
			else
			{
				___003C_003Eprinter.print(" & ");
			}
			referenceType.accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(IntegerLiteralExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(n.getValue());
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(InstanceOfExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(" instanceof ");
		n.getType().accept(this, arg);
		if (n.getName().isPresent())
		{
			___003C_003Eprinter.print(" ");
			((SimpleName)n.getName().get()).accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(InitializerDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.isStatic())
		{
			___003C_003Eprinter.print("static ");
		}
		n.getBody().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		166, 219, 103, 109, 113, 104, 145, 109, 104, 145,
		145, 105
	})]
	public virtual void visit(ImportDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("import ");
		if (n.isStatic())
		{
			___003C_003Eprinter.print("static ");
		}
		n.getName().accept(this, arg);
		if (n.isAsterisk())
		{
			___003C_003Eprinter.print(".*");
		}
		___003C_003Eprinter.println(";");
		printOrphanCommentsEnding(n);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		165, 116, 103, 109, 113, 109, 111, 99, 147, 113,
		140, 109, 99, 108, 112, 99, 147, 108, 117, 117,
		102, 147, 113, 140, 109, 119, 102, 140
	})]
	public virtual void visit(IfStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("if (");
		n.getCondition().accept(this, arg);
		int num = ((n.getThenStmt() is BlockStmt) ? 1 : 0);
		if (num != 0)
		{
			___003C_003Eprinter.print(") ");
		}
		else
		{
			___003C_003Eprinter.println(")");
			___003C_003Eprinter.indent();
		}
		n.getThenStmt().accept(this, arg);
		if (num == 0)
		{
			___003C_003Eprinter.unindent();
		}
		if (n.getElseStmt().isPresent())
		{
			if (num != 0)
			{
				___003C_003Eprinter.print(" ");
			}
			else
			{
				___003C_003Eprinter.println();
			}
			int num2 = ((n.getElseStmt().orElse(null) is IfStmt) ? 1 : 0);
			int num3 = ((n.getElseStmt().orElse(null) is BlockStmt) ? 1 : 0);
			if (num2 != 0 || num3 != 0)
			{
				___003C_003Eprinter.print("else ");
			}
			else
			{
				___003C_003Eprinter.println("else");
				___003C_003Eprinter.indent();
			}
			if (n.getElseStmt().isPresent())
			{
				((Statement)n.getElseStmt().get()).accept(this, arg);
			}
			if (num2 == 0 && num3 == 0)
			{
				___003C_003Eprinter.unindent();
			}
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ForEachStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("for (");
		n.getVariable().accept(this, arg);
		___003C_003Eprinter.print(" : ");
		n.getIterable().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getBody().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		165, 194, 103, 109, 113, 104, 116, 108, 104, 104,
		145, 130, 113, 109, 151, 113, 104, 116, 108, 104,
		104, 145, 130, 113, 111
	})]
	public virtual void visit(ForStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("for (");
		if (n.getInitialization() != null)
		{
			Iterator iterator = n.getInitialization().iterator();
			while (iterator.hasNext())
			{
				Expression expression = (Expression)iterator.next();
				expression.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.print("; ");
		if (n.getCompare().isPresent())
		{
			((Expression)n.getCompare().get()).accept(this, arg);
		}
		___003C_003Eprinter.print("; ");
		if (n.getUpdate() != null)
		{
			Iterator iterator = n.getUpdate().iterator();
			while (iterator.hasNext())
			{
				Expression expression = (Expression)iterator.next();
				expression.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.print(") ");
		n.getBody().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 248, 135, 109, 109, 108, 109, 103, 114, 104,
		209, 113, 116, 108, 104, 104, 145, 130, 113
	})]
	public virtual void visit(FieldDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		if (!n.getVariables().isEmpty())
		{
			Optional maximumCommonType = n.getMaximumCommonType();
			maximumCommonType.ifPresent(new ___003C_003EAnon5(this, arg));
			if (!maximumCommonType.isPresent())
			{
				___003C_003Eprinter.print("???");
			}
		}
		___003C_003Eprinter.print(" ");
		Iterator iterator = n.getVariables().iterator();
		while (iterator.hasNext())
		{
			VariableDeclarator variableDeclarator = (VariableDeclarator)iterator.next();
			variableDeclarator.accept(this, arg);
			if (iterator.hasNext())
			{
				___003C_003Eprinter.print(", ");
			}
		}
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(FieldAccessExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getScope().accept(this, arg);
		___003C_003Eprinter.print(".");
		n.getName().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ExpressionStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 89, 103, 109, 104, 104, 147, 109, 119, 145,
		104, 145, 109, 113
	})]
	public virtual void visit(ExplicitConstructorInvocationStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.isThis())
		{
			printTypeArgs(n, arg);
			___003C_003Eprinter.print("this");
		}
		else
		{
			if (n.getExpression().isPresent())
			{
				((Expression)n.getExpression().get()).accept(this, arg);
				___003C_003Eprinter.print(".");
			}
			printTypeArgs(n, arg);
			___003C_003Eprinter.print("super");
		}
		printArguments(n.getArguments(), arg);
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		165, 32, 103, 109, 109, 140, 113, 141, 109, 113,
		116, 108, 104, 104, 145, 162, 113, 108, 112, 129,
		152, 127, 1, 108, 116, 109, 105, 104, 99, 147,
		177, 130, 109, 113, 143, 109, 172, 108, 113
	})]
	public virtual void visit(EnumDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		___003C_003Eprinter.print("enum ");
		n.getName().accept(this, arg);
		if (!n.getImplementedTypes().isEmpty())
		{
			___003C_003Eprinter.print(" implements ");
			Iterator iterator = n.getImplementedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
				classOrInterfaceType.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.println(" {");
		___003C_003Eprinter.indent();
		if (n.getEntries().isNonEmpty())
		{
			int num = ((n.getEntries().size() > configuration.getMaxEnumConstantsToAlignHorizontally() || n.getEntries().stream().anyMatch(new ___003C_003EAnon21())) ? 1 : 0);
			___003C_003Eprinter.println();
			Iterator iterator2 = n.getEntries().iterator();
			while (iterator2.hasNext())
			{
				EnumConstantDeclaration enumConstantDeclaration = (EnumConstantDeclaration)iterator2.next();
				enumConstantDeclaration.accept(this, arg);
				if (iterator2.hasNext())
				{
					if (num != 0)
					{
						___003C_003Eprinter.println(",");
					}
					else
					{
						___003C_003Eprinter.print(", ");
					}
				}
			}
		}
		if (!n.getMembers().isEmpty())
		{
			___003C_003Eprinter.println(";");
			printMembers(n.getMembers(), arg);
		}
		else if (!n.getEntries().isEmpty())
		{
			___003C_003Eprinter.println();
		}
		___003C_003Eprinter.unindent();
		___003C_003Eprinter.print("}");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		165, 86, 103, 109, 109, 141, 109, 173, 109, 113,
		108, 109, 108, 145
	})]
	public virtual void visit(EnumConstantDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		n.getName().accept(this, arg);
		if (!n.getArguments().isEmpty())
		{
			printArguments(n.getArguments(), arg);
		}
		if (!n.getClassBody().isEmpty())
		{
			___003C_003Eprinter.println(" {");
			___003C_003Eprinter.indent();
			printMembers(n.getClassBody(), arg);
			___003C_003Eprinter.unindent();
			___003C_003Eprinter.println("}");
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(EnclosedExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("(");
		n.getInner().accept(this, arg);
		___003C_003Eprinter.print(")");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(EmptyStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(DoubleLiteralExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(n.getValue());
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(DoStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("do ");
		n.getBody().accept(this, arg);
		___003C_003Eprinter.print(" while (");
		n.getCondition().accept(this, arg);
		___003C_003Eprinter.print(");");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ContinueStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("continue");
		n.getLabel().ifPresent(new ___003C_003EAnon22(this));
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 199, 103, 109, 109, 140, 109, 104, 145, 141,
		113, 109, 116, 108, 104, 104, 145, 130, 145, 109,
		113, 116, 108, 104, 104, 145, 130, 113, 111
	})]
	public virtual void visit(ConstructorDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		printTypeParameters(n.getTypeParameters(), arg);
		if (n.isGeneric())
		{
			___003C_003Eprinter.print(" ");
		}
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("(");
		if (!n.getParameters().isEmpty())
		{
			Iterator iterator = n.getParameters().iterator();
			while (iterator.hasNext())
			{
				Parameter parameter = (Parameter)iterator.next();
				parameter.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.print(")");
		if (!Utils.isNullOrEmpty(n.getThrownExceptions()))
		{
			___003C_003Eprinter.print(" throws ");
			Iterator iterator = n.getThrownExceptions().iterator();
			while (iterator.hasNext())
			{
				ReferenceType referenceType = (ReferenceType)iterator.next();
				referenceType.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.print(" ");
		n.getBody().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ConditionalExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getCondition().accept(this, arg);
		___003C_003Eprinter.print(" ? ");
		n.getThenExpr().accept(this, arg);
		___003C_003Eprinter.print(" : ");
		n.getElseExpr().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 167, 103, 109, 109, 113, 161, 109, 183, 109,
		109, 172, 116, 114, 108, 104, 206, 151, 105
	})]
	public virtual void visit(CompilationUnit n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.getParsed() == Node.Parsedness.___003C_003EUNPARSABLE)
		{
			___003C_003Eprinter.println("???");
			return;
		}
		if (n.getPackageDeclaration().isPresent())
		{
			((PackageDeclaration)n.getPackageDeclaration().get()).accept(this, arg);
		}
		n.getImports().accept(this, arg);
		if (!n.getImports().isEmpty())
		{
			___003C_003Eprinter.println();
		}
		Iterator iterator = n.getTypes().iterator();
		while (iterator.hasNext())
		{
			((TypeDeclaration)iterator.next()).accept(this, arg);
			___003C_003Eprinter.println();
			if (iterator.hasNext())
			{
				___003C_003Eprinter.println();
			}
		}
		n.getModule().ifPresent(new ___003C_003EAnon3(this, arg));
		printOrphanCommentsEnding(n);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 123, 103, 109, 109, 119, 145, 142, 141, 104,
		147, 138
	})]
	public virtual void visit(ClassOrInterfaceType n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.getScope().isPresent())
		{
			((ClassOrInterfaceType)n.getScope().get()).accept(this, arg);
			___003C_003Eprinter.print(".");
		}
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		n.getName().accept(this, arg);
		if (n.isUsingDiamondOperator())
		{
			___003C_003Eprinter.print("<>");
		}
		else
		{
			printTypeArgs(n, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 238, 103, 109, 109, 140, 104, 147, 177, 141,
		141, 109, 113, 116, 108, 104, 104, 145, 162, 109,
		113, 116, 108, 104, 104, 145, 162, 113, 108, 109,
		173, 135, 108, 113
	})]
	public virtual void visit(ClassOrInterfaceDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		if (n.isInterface())
		{
			___003C_003Eprinter.print("interface ");
		}
		else
		{
			___003C_003Eprinter.print("class ");
		}
		n.getName().accept(this, arg);
		printTypeParameters(n.getTypeParameters(), arg);
		if (!n.getExtendedTypes().isEmpty())
		{
			___003C_003Eprinter.print(" extends ");
			Iterator iterator = n.getExtendedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
				classOrInterfaceType.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		if (!n.getImplementedTypes().isEmpty())
		{
			___003C_003Eprinter.print(" implements ");
			Iterator iterator = n.getImplementedTypes().iterator();
			while (iterator.hasNext())
			{
				ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)iterator.next();
				classOrInterfaceType.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
		}
		___003C_003Eprinter.println(" {");
		___003C_003Eprinter.indent();
		if (!Utils.isNullOrEmpty(n.getMembers()))
		{
			printMembers(n.getMembers(), arg);
		}
		printOrphanCommentsEnding(n);
		___003C_003Eprinter.unindent();
		___003C_003Eprinter.print("}");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ClassExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(".class");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(CharLiteralExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("'");
		___003C_003Eprinter.print(n.getValue());
		___003C_003Eprinter.print("'");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(CatchClause n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(" catch (");
		n.getParameter().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getBody().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(CastExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("(");
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getExpression().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(BreakStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("break");
		n.getLabel().ifPresent(new ___003C_003EAnon20(this));
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(BooleanLiteralExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(java.lang.String.valueOf(n.getValue()));
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 160, 103, 109, 113, 104, 108, 127, 1, 104,
		108, 130, 103, 108, 113
	})]
	public virtual void visit(BlockStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.println("{");
		if (n.getStatements() != null)
		{
			___003C_003Eprinter.indent();
			Iterator iterator = n.getStatements().iterator();
			while (iterator.hasNext())
			{
				Statement statement = (Statement)iterator.next();
				statement.accept(this, arg);
				___003C_003Eprinter.println();
			}
		}
		printOrphanCommentsEnding(n);
		___003C_003Eprinter.unindent();
		___003C_003Eprinter.print("}");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		166, 127, 109, 129, 119, 109, 113, 105, 111, 23,
		198, 114, 113
	})]
	public virtual void visit(BlockComment n, java.lang.Void arg)
	{
		if (!configuration.isIgnoreComments())
		{
			string @this = Utils.normalizeEolInTextBlock(n.getContent(), configuration.getEndOfLineCharacter());
			string[] array = java.lang.String.instancehelper_split(@this, "\\R", -1);
			___003C_003Eprinter.print("/*");
			for (int i = 0; i < (nint)array.LongLength - 1; i++)
			{
				___003C_003Eprinter.print(array[i]);
				___003C_003Eprinter.print(configuration.getEndOfLineCharacter());
			}
			___003C_003Eprinter.print(array[(nint)array.LongLength - 1]);
			___003C_003Eprinter.println("*/");
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 136, 103, 109, 109, 109, 145, 119, 109, 145,
		111
	})]
	public virtual void visit(BinaryExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getLeft().accept(this, arg);
		if (configuration.isSpaceAroundOperators())
		{
			___003C_003Eprinter.print(" ");
		}
		___003C_003Eprinter.print(n.getOperator().asString());
		if (configuration.isSpaceAroundOperators())
		{
			___003C_003Eprinter.print(" ");
		}
		n.getRight().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 115, 103, 109, 109, 109, 145, 119, 109, 145,
		111
	})]
	public virtual void visit(AssignExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getTarget().accept(this, arg);
		if (configuration.isSpaceAroundOperators())
		{
			___003C_003Eprinter.print(" ");
		}
		___003C_003Eprinter.print(n.getOperator().asString());
		if (configuration.isSpaceAroundOperators())
		{
			___003C_003Eprinter.print(" ");
		}
		n.getValue().accept(this, arg);
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(AssertStmt n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("assert ");
		n.getCheck().accept(this, arg);
		if (n.getMessage().isPresent())
		{
			___003C_003Eprinter.print(" : ");
			((Expression)n.getMessage().get()).accept(this, arg);
		}
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 168, 102, 98, 104, 103, 104, 103, 130, 104,
		124, 111, 113, 98
	})]
	public virtual void visit(ArrayType n, java.lang.Void arg)
	{
		LinkedList linkedList = new LinkedList();
		com.github.javaparser.ast.type.Type type = n;
		while (type is ArrayType)
		{
			ArrayType arrayType = (ArrayType)type;
			((List)linkedList).add((object)arrayType);
			type = arrayType.getComponentType();
		}
		type.accept(this, arg);
		Iterator iterator = ((List)linkedList).iterator();
		while (iterator.hasNext())
		{
			ArrayType arrayType2 = (ArrayType)iterator.next();
			printAnnotations(arrayType2.getAnnotations(), prefixWithASpace: true, arg);
			___003C_003Eprinter.print("[]");
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 48, 103, 109, 113, 112, 113, 116, 108, 104,
		104, 145, 98, 145, 103, 113
	})]
	public virtual void visit(ArrayInitializerExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("{");
		if (!Utils.isNullOrEmpty(n.getValues()))
		{
			___003C_003Eprinter.print(" ");
			Iterator iterator = n.getValues().iterator();
			while (iterator.hasNext())
			{
				Expression expression = (Expression)iterator.next();
				expression.accept(this, arg);
				if (iterator.hasNext())
				{
					___003C_003Eprinter.print(", ");
				}
			}
			___003C_003Eprinter.print(" ");
		}
		printOrphanCommentsEnding(n);
		___003C_003Eprinter.print("}");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ArrayCreationLevel n, java.lang.Void arg)
	{
		printAnnotations(n.getAnnotations(), prefixWithASpace: true, arg);
		___003C_003Eprinter.print("[");
		if (n.getDimension().isPresent())
		{
			((Expression)n.getDimension().get()).accept(this, arg);
		}
		___003C_003Eprinter.print("]");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 100, 103, 109, 113, 109, 127, 1, 104, 98,
		109, 113, 153
	})]
	public virtual void visit(ArrayCreationExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("new ");
		n.getElementType().accept(this, arg);
		Iterator iterator = n.getLevels().iterator();
		while (iterator.hasNext())
		{
			ArrayCreationLevel arrayCreationLevel = (ArrayCreationLevel)iterator.next();
			arrayCreationLevel.accept(this, arg);
		}
		if (n.getInitializer().isPresent())
		{
			___003C_003Eprinter.print(" ");
			((ArrayInitializerExpr)n.getInitializer().get()).accept(this, arg);
		}
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ArrayAccessExpr n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("[");
		n.getIndex().accept(this, arg);
		___003C_003Eprinter.print("]");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		166, 52, 103, 109, 109, 140, 109, 113, 109, 113,
		109, 113, 151, 113
	})]
	public virtual void visit(AnnotationMemberDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(" ");
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("()");
		if (n.getDefaultValue().isPresent())
		{
			___003C_003Eprinter.print(" default ");
			((Expression)n.getDefaultValue().get()).accept(this, arg);
		}
		___003C_003Eprinter.print(";");
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		166, 34, 103, 109, 109, 140, 113, 109, 113, 108,
		104, 141, 108, 113
	})]
	public virtual void visit(AnnotationDeclaration n, java.lang.Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		___003C_003Eprinter.print("@interface ");
		n.getName().accept(this, arg);
		___003C_003Eprinter.println(" {");
		___003C_003Eprinter.indent();
		if (n.getMembers() != null)
		{
			printMembers(n.getMembers(), arg);
		}
		___003C_003Eprinter.unindent();
		___003C_003Eprinter.print("}");
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		166, 201, 159, 11, 103, 107, 111, 5, 165, 118,
		109, 98, 98, 119, 110, 130
	})]
	public virtual void visit(NodeList n, java.lang.Void arg)
	{
		if (configuration.isOrderImports() && n.size() > 0 && n.get(0) is ImportDeclaration)
		{
			NodeList nodeList = new NodeList(n);
			nodeList.sort(Comparator.comparingInt(new ___003C_003EAnon23()).thenComparing(new ___003C_003EAnon24()));
			Iterator iterator = nodeList.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				((Node)obj).accept(this, arg);
			}
		}
		else
		{
			Iterator iterator2 = n.iterator();
			while (iterator2.hasNext())
			{
				object obj2 = iterator2.next();
				((Node)obj2).accept(this, arg);
			}
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024printComment_00240(java.lang.Void arg, Comment c)
	{
		c.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024visit_00241(java.lang.Void arg, ModuleDeclaration m)
	{
		m.accept(this, arg);
	}

	
	
	
	
	private static bool lambda_0024visit_00242(string line)
	{
		return (!java.lang.String.instancehelper_isEmpty(line) && !java.lang.String.instancehelper_startsWith(line, " ")) ? true : false;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024visit_00243(java.lang.Void arg, com.github.javaparser.ast.type.Type t)
	{
		t.accept(this, arg);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024visit_00245(VariableDeclarator n, java.lang.Void arg, NodeWithVariables ancestor)
	{
		ancestor.getMaximumCommonType().ifPresent(new ___003C_003EAnon26(this, n, arg));
	}

	
	
	
	
	private void lambda_0024visit_00246(string line)
	{
		___003C_003Eprinter.println();
		___003C_003Eprinter.print(line);
	}

	
	
	
	
	private static java.lang.Boolean lambda_0024visit_00247(Statement p)
	{
		java.lang.Boolean result = java.lang.Boolean.valueOf((p.isReturnStmt() || p.isThrowStmt() || p.isAssertStmt() || p.isExpressionStmt()) ? true : false);
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	[LineNumberTable(new byte[]
	{
		163, 120, 105, 104, 232, 71, 110, 233, 70, 171,
		113
	})]
	private void lambda_0024visit_00248(java.lang.Void arg, AtomicBoolean columnAlignFirstMethodChain, AtomicBoolean methodCallWithScopeInScope, AtomicBoolean lastMethodInCallChain, Expression scope)
	{
		scope.accept(this, arg);
		if (columnAlignFirstMethodChain.get())
		{
			if (methodCallWithScopeInScope.get())
			{
				___003C_003Eprinter.println();
			}
			else if (!lastMethodInCallChain.get())
			{
				___003C_003Eprinter.reindentWithAlignToCursor();
			}
		}
		___003C_003Eprinter.print(".");
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024visit_00249(java.lang.Void arg, MethodDeclaration n, ReceiverParameter rp)
	{
		rp.accept(this, arg);
		if (!Utils.isNullOrEmpty(n.getParameters()))
		{
			___003C_003Eprinter.print(", ");
		}
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private void lambda_0024visit_002410(java.lang.Void arg, com.github.javaparser.ast.type.Type t)
	{
		t.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002411(SimpleName l)
	{
		___003C_003Eprinter.print(" ").print(l.getIdentifier());
	}

	
	
	
	
	private static bool lambda_0024visit_002412(EnumConstantDeclaration e)
	{
		bool result = e.getComment().isPresent();
		
		return result;
	}

	
	
	
	
	private void lambda_0024visit_002413(SimpleName l)
	{
		___003C_003Eprinter.print(" ").print(l.getIdentifier());
	}

	
	
	
	
	private static int lambda_0024visit_002414(ImportDeclaration i)
	{
		return (!i.isStatic()) ? 1 : 0;
	}

	
	
	
	
	private static bool lambda_0024printOrphanCommentsEnding_002415(Node n)
	{
		bool result = n.hasRange();
		
		return result;
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	[LineNumberTable(new byte[]
	{
		162, 25, 135, 130, 112, 99, 137, 140, 110, 241,
		57, 230, 73
	})]
	private void lambda_0024null_00244(VariableDeclarator n, java.lang.Void arg, com.github.javaparser.ast.type.Type commonType)
	{
		com.github.javaparser.ast.type.Type type = n.getType();
		ArrayType arrayType = null;
		for (int i = commonType.getArrayLevel(); i < type.getArrayLevel(); i++)
		{
			arrayType = ((arrayType != null) ? ((ArrayType)arrayType.getComponentType()) : ((ArrayType)type));
			printAnnotations(arrayType.getAnnotations(), prefixWithASpace: true, arg);
			___003C_003Eprinter.print("[]");
		}
	}

	
	public virtual void setConfiguration(PrettyPrinterConfiguration prettyPrinterConfiguration)
	{
		configuration = prettyPrinterConfiguration;
	}

	
	
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual string getSource()
	{
		string result = ___003C_003Eprinter.ToString();
		
		return result;
	}

	
	
	public override string ToString()
	{
		string result = ___003C_003Eprinter.ToString();
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(PatternExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(YieldStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(TextBlockLiteralExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(SwitchExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(Modifier n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(VarType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ReceiverParameter n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(UnparsableStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(ModuleOpensDirective n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(ModuleUsesDirective n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(ModuleProvidesDirective n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(ModuleExportsDirective n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(ModuleRequiresDirective n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(ModuleDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(WildcardType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(WhileStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(VoidType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(VariableDeclarator n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(VariableDeclarationExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(UnknownType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(UnionType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(UnaryExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(TypeParameter n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(TypeExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(TryStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ThrowStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ThisExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(SynchronizedStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(SwitchStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(SwitchEntry n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(SuperExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(StringLiteralExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(SingleMemberAnnotationExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(SimpleName n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ReturnStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(CompactConstructorDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(RecordDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(PrimitiveType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(Parameter n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(PackageDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ObjectCreationExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(NullLiteralExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(NormalAnnotationExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(Name n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(NameExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(MethodReferenceExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(MethodDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(MethodCallExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(MemberValuePair n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(MarkerAnnotationExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(LongLiteralExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(LocalRecordDeclarationStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(LocalClassDeclarationStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(LineComment n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(LambdaExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(LabeledStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(JavadocComment n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(IntersectionType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(IntegerLiteralExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(InstanceOfExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(InitializerDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ImportDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(IfStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ForEachStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ForStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(FieldDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(FieldAccessExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ExpressionStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(EnumDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(EnumConstantDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(EnclosedExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(EmptyStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(DoubleLiteralExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(DoStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ContinueStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ConstructorDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ConditionalExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(CompilationUnit n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ClassOrInterfaceType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ClassOrInterfaceDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ClassExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(CharLiteralExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(CatchClause n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(CastExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(BreakStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(BooleanLiteralExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(BlockStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(BlockComment n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(BinaryExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(AssignExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(AssertStmt n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ArrayType n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ArrayInitializerExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ArrayCreationLevel n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ArrayCreationExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(ArrayAccessExpr n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(AnnotationMemberDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual void visit(AnnotationDeclaration n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual void visit(NodeList n, object arg)
	{
		visit(n, (java.lang.Void)arg);
	}
}
