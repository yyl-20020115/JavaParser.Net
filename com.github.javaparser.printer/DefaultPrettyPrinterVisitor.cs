using System.ComponentModel;

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

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.concurrent.atomic;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.printer;

public class DefaultPrettyPrinterVisitor: VoidVisitor
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
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly Void arg_00242;

		internal ___003C_003EAnon2(DefaultPrettyPrinterVisitor P_0, Void P_1)
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
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly Void arg_00242;

		internal ___003C_003EAnon3(DefaultPrettyPrinterVisitor P_0, Void P_1)
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
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly Void arg_00242;

		internal ___003C_003EAnon5(DefaultPrettyPrinterVisitor P_0, Void P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_00243(arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon6 : Consumer
	{
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly VariableDeclarator arg_00242;

		private readonly Void arg_00243;

		internal ___003C_003EAnon6(DefaultPrettyPrinterVisitor P_0, VariableDeclarator P_1, Void P_2)
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
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		internal ___003C_003EAnon7(DefaultPrettyPrinterVisitor P_0)
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
			Boolean result = lambda_0024visit_00247((Statement)P_0);
			
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
			Boolean result = Boolean.valueOf(arg_00241.equals((Expression)P_0));
			
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
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly Void arg_00242;

		private readonly AtomicBoolean arg_00243;

		private readonly AtomicBoolean arg_00244;

		private readonly AtomicBoolean arg_00245;

		internal ___003C_003EAnon16(DefaultPrettyPrinterVisitor P_0, Void P_1, AtomicBoolean P_2, AtomicBoolean P_3, AtomicBoolean P_4)
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
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly Void arg_00242;

		private readonly ConstructorDeclaration arg_00243;

		internal ___003C_003EAnon17(DefaultPrettyPrinterVisitor P_0, Void P_1, ConstructorDeclaration P_2)
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

	
	private sealed class ___003C_003EAnon18 : Consumer
	{
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly Void arg_00242;

		private readonly MethodDeclaration arg_00243;

		internal ___003C_003EAnon18(DefaultPrettyPrinterVisitor P_0, Void P_1, MethodDeclaration P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002410(arg_00242, arg_00243, (ReceiverParameter)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon19 : Function
	{
		private readonly Class arg_00241;

		internal ___003C_003EAnon19(Class P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Boolean result = Boolean.valueOf(arg_00241.isInstance((Node)P_0));
			
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

	
	private sealed class ___003C_003EAnon20 : Consumer
	{
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly Void arg_00242;

		internal ___003C_003EAnon20(DefaultPrettyPrinterVisitor P_0, Void P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002411(arg_00242, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon21 : Consumer
	{
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		internal ___003C_003EAnon21(DefaultPrettyPrinterVisitor P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002412((SimpleName)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon22 : Predicate
	{
		internal ___003C_003EAnon22()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024visit_002413((EnumConstantDeclaration)P_0);
			
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

	
	private sealed class ___003C_003EAnon23 : Consumer
	{
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		internal ___003C_003EAnon23(DefaultPrettyPrinterVisitor P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024visit_002414((SimpleName)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon24 : ToIntFunction
	{
		internal ___003C_003EAnon24()
		{
		}

		public int applyAsInt(object P_0)
		{
			int result = lambda_0024visit_002415((ImportDeclaration)P_0);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon25 : Function
	{
		internal ___003C_003EAnon25()
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

	
	private sealed class ___003C_003EAnon26 : Consumer
	{
		private readonly DefaultPrettyPrinterVisitor arg_00241;

		private readonly VariableDeclarator arg_00242;

		private readonly Void arg_00243;

		internal ___003C_003EAnon26(DefaultPrettyPrinterVisitor P_0, VariableDeclarator P_1, Void P_2)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
			arg_00243 = P_2;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024null_00244(arg_00242, arg_00243, (Type)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	internal PrinterConfiguration ___003C_003Econfiguration;

	internal SourcePrinter ___003C_003Eprinter;

	
	protected internal PrinterConfiguration configuration
	{
		
		get
		{
			return ___003C_003Econfiguration;
		}
		
		private set
		{
			___003C_003Econfiguration = value;
		}
	}

	
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

	
	
	
	public DefaultPrettyPrinterVisitor(PrinterConfiguration configuration, SourcePrinter printer)
	{
		___003C_003Econfiguration = configuration;
		___003C_003Eprinter = printer;
	}

	
		
	
	private Optional getOption(DefaultPrinterConfiguration.ConfigOption cOption)
	{
		Optional result = ___003C_003Econfiguration.get(new DefaultConfigurationOption(cOption));
		
		return result;
	}

	
	
	
	private void printOrphanCommentsBeforeThisChildNode(Node node)
	{
		if (!getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS).isPresent() || node is Comment)
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
				string message = new StringBuilder().append("Expected comment, instead ").append(Object.instancehelper_getClass(node3)).append(". Position of previous child: ")
					.append(i)
					.append(", position of child ")
					.append(num)
					.ToString();
				
				throw new RuntimeException(message);
			}
			node3.accept(this, null);
		}
	}

	
		
	
	protected internal virtual void printComment(Optional comment, Void arg)
	{
		comment.ifPresent(new ___003C_003EAnon2(this, arg));
	}

	
	
	
	private void printOrphanCommentsEnding(Node node)
	{
		if (!getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS).isPresent())
		{
			return;
		}
		
		ArrayList arrayList = new ArrayList(node.getChildNodes());
		PositionUtils.sortByBeginPosition(arrayList);
		if (((List)arrayList).isEmpty())
		{
			return;
		}
		int num = 0;
		int num2 = 1;
		while (num2 != 0 && num < ((List)arrayList).size())
		{
			Node node2 = (Node)((List)arrayList).get(((List)arrayList).size() - 1 - num);
			num2 = ((node2 is Comment) ? 1 : 0);
			if (num2 != 0)
			{
				num++;
			}
		}
		for (int i = 0; i < num; i++)
		{
			((Node)((List)arrayList).get(((List)arrayList).size() - num + i)).accept(this, null);
		}
	}

	
		
	
	protected internal virtual void printMemberAnnotations(NodeList annotations, Void arg)
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

	
		
	
	protected internal virtual void printTypeParameters(NodeList args, Void arg)
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

	
		
	
	protected internal virtual void printMembers(NodeList members, Void arg)
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

	
		
	
	protected internal virtual void printAnnotations(NodeList annotations, bool prefixWithASpace, Void arg)
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

	
		
	
	protected internal virtual void printTypeArgs(NodeWithTypeArguments nodeWithTypeArguments, Void arg)
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
			Type type = (Type)iterator.next();
			type.accept(this, arg);
			if (iterator.hasNext())
			{
				___003C_003Eprinter.print(", ");
			}
		}
		___003C_003Eprinter.print(">");
	}

	
		
	
	protected internal virtual void printArguments(NodeList args, Void arg)
	{
		___003C_003Eprinter.print("(");
		if (!Utils.isNullOrEmpty(args))
		{
			int num = ((args.size() > 1 && getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ECOLUMN_ALIGN_PARAMETERS).isPresent()) ? 1 : 0);
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

	
	
	
	private void printSwitchNode(SwitchNode n, Void arg)
	{
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("switch(");
		n.getSelector().accept(this, arg);
		___003C_003Eprinter.println(") {");
		if (n.getEntries() != null)
		{
			indentIf(getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EINDENT_CASE_IN_SWITCH).isPresent());
			Iterator iterator = n.getEntries().iterator();
			while (iterator.hasNext())
			{
				SwitchEntry switchEntry = (SwitchEntry)iterator.next();
				switchEntry.accept(this, arg);
			}
			unindentIf(getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EINDENT_CASE_IN_SWITCH).isPresent());
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

	
		
	
	protected internal virtual void printPrePostFixOptionalList(NodeList args, Void arg, string prefix, string separator, string postfix)
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

	
		
	
	protected internal virtual void printPrePostFixRequiredList(NodeList args, Void arg, string prefix, string separator, string postfix)
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

	
	
	
	public virtual void visit(PatternExpr n, Void arg)
	{
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(" ");
		n.getName().accept(this, arg);
	}

	
	
	
	public virtual void visit(YieldStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("yield ");
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(";");
	}

	
	
	
	public virtual void visit(TextBlockLiteralExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("\"\"\"");
		___003C_003Eprinter.indent();
		n.stripIndentOfLines().forEach(new ___003C_003EAnon7(this));
		___003C_003Eprinter.print("\"\"\"");
		___003C_003Eprinter.unindent();
	}

	
	
	
	public virtual void visit(SwitchExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printSwitchNode(n, arg);
	}

	
	
	
	public virtual void visit(Modifier n, Void arg)
	{
		___003C_003Eprinter.print(n.getKeyword().asString());
		___003C_003Eprinter.print(" ");
	}

	
	
	
	public virtual void visit(VarType n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		___003C_003Eprinter.print("var");
	}

	
	
	
	public virtual void visit(ReceiverParameter n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(" ");
		n.getName().accept(this, arg);
	}

	
	
	
	public virtual void visit(UnparsableStmt n, Void arg)
	{
		___003C_003Eprinter.print("???;");
	}

	
	
	
	public virtual void visit(ModuleOpensDirective n, Void arg)
	{
		___003C_003Eprinter.print("opens ");
		n.getName().accept(this, arg);
		printPrePostFixOptionalList(n.getModuleNames(), arg, " to ", ", ", "");
		___003C_003Eprinter.println(";");
	}

	
	
	
	public virtual void visit(ModuleUsesDirective n, Void arg)
	{
		___003C_003Eprinter.print("uses ");
		n.getName().accept(this, arg);
		___003C_003Eprinter.println(";");
	}

	
	
	
	public virtual void visit(ModuleProvidesDirective n, Void arg)
	{
		___003C_003Eprinter.print("provides ");
		n.getName().accept(this, arg);
		printPrePostFixRequiredList(n.getWith(), arg, " with ", ", ", "");
		___003C_003Eprinter.println(";");
	}

	
	
	
	public virtual void visit(ModuleExportsDirective n, Void arg)
	{
		___003C_003Eprinter.print("exports ");
		n.getName().accept(this, arg);
		printPrePostFixOptionalList(n.getModuleNames(), arg, " to ", ", ", "");
		___003C_003Eprinter.println(";");
	}

	
	
	
	public virtual void visit(ModuleRequiresDirective n, Void arg)
	{
		___003C_003Eprinter.print("requires ");
		printModifiers(n.getModifiers());
		n.getName().accept(this, arg);
		___003C_003Eprinter.println(";");
	}

	
	
	
	public virtual void visit(ModuleDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(WildcardType n, Void arg)
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

	
	
	
	public virtual void visit(WhileStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("while (");
		n.getCondition().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getBody().accept(this, arg);
	}

	
	
	
	public virtual void visit(VoidType n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: false, arg);
		___003C_003Eprinter.print("void");
	}

	
	
	
	public virtual void visit(VariableDeclarator n, Void arg)
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

	
	
	
	public unsafe virtual void visit(VariableDeclarationExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		Optional parentNode = n.getParentNode();
		Class value = ClassLiteral<ExpressionStmt>.Value;
		
		if (((Boolean)parentNode.map(new ___003C_003EAnon19(value)).orElse(Boolean.valueOf(b: false))).booleanValue())
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
			n.getMaximumCommonType().ifPresent(new ___003C_003EAnon20(this, arg));
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

	
	public virtual void visit(UnknownType n, Void arg)
	{
	}

	
	
	
	public virtual void visit(UnionType n, Void arg)
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

	
	
	
	public virtual void visit(UnaryExpr n, Void arg)
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

	
	
	
	public virtual void visit(TypeParameter n, Void arg)
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

	
	
	
	public virtual void visit(TypeExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.getType() != null)
		{
			n.getType().accept(this, arg);
		}
	}

	
	
	
	public virtual void visit(TryStmt n, Void arg)
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

	
	
	
	public virtual void visit(ThrowStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("throw ");
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(";");
	}

	
	
	
	public virtual void visit(ThisExpr n, Void arg)
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

	
	
	
	public virtual void visit(SynchronizedStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("synchronized (");
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getBody().accept(this, arg);
	}

	
	
	
	public virtual void visit(SwitchStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printSwitchNode(n, arg);
	}

	
	
	
	public virtual void visit(SwitchEntry n, Void arg)
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

	
	
	
	public virtual void visit(SuperExpr n, Void arg)
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

	
	
	
	public virtual void visit(StringLiteralExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("\"");
		___003C_003Eprinter.print(n.getValue());
		___003C_003Eprinter.print("\"");
	}

	
	
	
	public virtual void visit(SingleMemberAnnotationExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("@");
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("(");
		n.getMemberValue().accept(this, arg);
		___003C_003Eprinter.print(")");
	}

	
	
	
	public virtual void visit(SimpleName n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(n.getIdentifier());
	}

	
	
	
	public virtual void visit(ReturnStmt n, Void arg)
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

	
	
	
	public virtual void visit(CompactConstructorDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(RecordDeclaration n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printMemberAnnotations(n.getAnnotations(), arg);
		printModifiers(n.getModifiers());
		___003C_003Eprinter.print("record ");
		n.getName().accept(this, arg);
		printTypeParameters(n.getTypeParameters(), arg);
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

	
	
	
	public virtual void visit(PrimitiveType n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		printAnnotations(n.getAnnotations(), prefixWithASpace: true, arg);
		___003C_003Eprinter.print(n.getType().asString());
	}

	
	
	
	public virtual void visit(Parameter n, Void arg)
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

	
	
	
	public virtual void visit(PackageDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(ObjectCreationExpr n, Void arg)
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

	
	
	
	public virtual void visit(NullLiteralExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("null");
	}

	
	
	
	public virtual void visit(NormalAnnotationExpr n, Void arg)
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

	
	
	
	public virtual void visit(Name n, Void arg)
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

	
	
	
	public virtual void visit(NameExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getName().accept(this, arg);
		printOrphanCommentsEnding(n);
	}

	
	
	
	public virtual void visit(MethodReferenceExpr n, Void arg)
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

	
	
	
	public virtual void visit(MethodDeclaration n, Void arg)
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
		n.getReceiverParameter().ifPresent(new ___003C_003EAnon18(this, arg, n));
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

	
	
	
	public unsafe virtual void visit(MethodCallExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		AtomicBoolean atomicBoolean = new AtomicBoolean();
		if (getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ECOLUMN_ALIGN_FIRST_METHOD_CHAIN).isPresent() && ((Boolean)n.findAncestor(new Class[1] { ClassLiteral<Statement>.Value }).map(new ___003C_003EAnon8()).orElse(Boolean.valueOf(b: false))).booleanValue())
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
				
				if (!((Boolean)optional3.map(new ___003C_003EAnon12(node2)).orElse(Boolean.valueOf(b: false))).booleanValue())
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
				
				if (!((Boolean)optional6.map(new ___003C_003EAnon12(node4)).orElse(Boolean.valueOf(b: false))).booleanValue())
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

	
	
	
	public virtual void visit(MemberValuePair n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getName().accept(this, arg);
		___003C_003Eprinter.print(" = ");
		n.getValue().accept(this, arg);
	}

	
	
	
	public virtual void visit(MarkerAnnotationExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("@");
		n.getName().accept(this, arg);
	}

	
	
	
	public virtual void visit(LongLiteralExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(n.getValue());
	}

	
	
	
	public virtual void visit(LocalRecordDeclarationStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getRecordDeclaration().accept(this, arg);
	}

	
	
	
	public virtual void visit(LocalClassDeclarationStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getClassDeclaration().accept(this, arg);
	}

	
	
	
	public virtual void visit(LineComment n, Void arg)
	{
		if (getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS).isPresent())
		{
			___003C_003Eprinter.print("// ").println(String.instancehelper_trim(Utils.normalizeEolInTextBlock(n.getContent(), "")));
		}
	}

	
	
	
	public virtual void visit(LambdaExpr n, Void arg)
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

	
	
	
	public virtual void visit(LabeledStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getLabel().accept(this, arg);
		___003C_003Eprinter.print(": ");
		n.getStatement().accept(this, arg);
	}

	
	
	
	public virtual void visit(JavadocComment n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		if (!getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS).isPresent() || !getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_JAVADOC).isPresent())
		{
			return;
		}
		___003C_003Eprinter.println("/**");
		string @this = Utils.normalizeEolInTextBlock(n.getContent(), ((ConfigurationOption)getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EEND_OF_LINE_CHARACTER).get()).asString());
		string[] array = String.instancehelper_split(@this, "\\R");
		ArrayList arrayList = new ArrayList();
		string[] array2 = array;
		int num = array2.Length;
		int i;
		for (i = 0; i < num; i++)
		{
			string text = array2[i];
			string this2 = String.instancehelper_trim(text);
			if (String.instancehelper_startsWith(this2, "*"))
			{
				text = String.instancehelper_substring(this2, 1);
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
			if (String.instancehelper_isEmpty(this2))
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

	
	
	
	public virtual void visit(IntersectionType n, Void arg)
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

	
	
	
	public virtual void visit(IntegerLiteralExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(n.getValue());
	}

	
	
	
	public virtual void visit(InstanceOfExpr n, Void arg)
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

	
	
	
	public virtual void visit(InitializerDeclaration n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		if (n.isStatic())
		{
			___003C_003Eprinter.print("static ");
		}
		n.getBody().accept(this, arg);
	}

	
	
	
	public virtual void visit(ImportDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(IfStmt n, Void arg)
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

	
	
	
	public virtual void visit(ForEachStmt n, Void arg)
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

	
	
	
	public virtual void visit(ForStmt n, Void arg)
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

	
	
	
	public virtual void visit(FieldDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(FieldAccessExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getScope().accept(this, arg);
		___003C_003Eprinter.print(".");
		n.getName().accept(this, arg);
	}

	
	
	
	public virtual void visit(ExpressionStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getExpression().accept(this, arg);
		___003C_003Eprinter.print(";");
	}

	
	
	
	public virtual void visit(ExplicitConstructorInvocationStmt n, Void arg)
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

	
	
	
	public virtual void visit(EnumDeclaration n, Void arg)
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
			int num = ((n.getEntries().size() > ((ConfigurationOption)getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EMAX_ENUM_CONSTANTS_TO_ALIGN_HORIZONTALLY).get()).asInteger().intValue() || n.getEntries().stream().anyMatch(new ___003C_003EAnon22())) ? 1 : 0);
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

	
	
	
	public virtual void visit(EnumConstantDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(EnclosedExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("(");
		n.getInner().accept(this, arg);
		___003C_003Eprinter.print(")");
	}

	
	
	
	public virtual void visit(EmptyStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(";");
	}

	
	
	
	public virtual void visit(DoubleLiteralExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(n.getValue());
	}

	
	
	
	public virtual void visit(DoStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("do ");
		n.getBody().accept(this, arg);
		___003C_003Eprinter.print(" while (");
		n.getCondition().accept(this, arg);
		___003C_003Eprinter.print(");");
	}

	
	
	
	public virtual void visit(ContinueStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("continue");
		n.getLabel().ifPresent(new ___003C_003EAnon23(this));
		___003C_003Eprinter.print(";");
	}

	
	
	
	public virtual void visit(ConstructorDeclaration n, Void arg)
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
		n.getReceiverParameter().ifPresent(new ___003C_003EAnon17(this, arg, n));
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

	
	
	
	public virtual void visit(ConditionalExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getCondition().accept(this, arg);
		___003C_003Eprinter.print(" ? ");
		n.getThenExpr().accept(this, arg);
		___003C_003Eprinter.print(" : ");
		n.getElseExpr().accept(this, arg);
	}

	
	
	
	public virtual void visit(CompilationUnit n, Void arg)
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

	
	
	
	public virtual void visit(ClassOrInterfaceType n, Void arg)
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

	
	
	
	public virtual void visit(ClassOrInterfaceDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(ClassExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(".class");
	}

	
	
	
	public virtual void visit(CharLiteralExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("'");
		___003C_003Eprinter.print(n.getValue());
		___003C_003Eprinter.print("'");
	}

	
	
	
	public virtual void visit(CatchClause n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(" catch (");
		n.getParameter().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getBody().accept(this, arg);
	}

	
	
	
	public virtual void visit(CastExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("(");
		n.getType().accept(this, arg);
		___003C_003Eprinter.print(") ");
		n.getExpression().accept(this, arg);
	}

	
	
	
	public virtual void visit(BreakStmt n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print("break");
		n.getLabel().ifPresent(new ___003C_003EAnon21(this));
		___003C_003Eprinter.print(";");
	}

	
	
	
	public virtual void visit(BooleanLiteralExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		___003C_003Eprinter.print(String.valueOf(n.getValue()));
	}

	
	
	
	public virtual void visit(BlockStmt n, Void arg)
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

	
	
	
	public virtual void visit(BlockComment n, Void arg)
	{
		if (getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EPRINT_COMMENTS).isPresent())
		{
			string @this = Utils.normalizeEolInTextBlock(n.getContent(), ((ConfigurationOption)getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EEND_OF_LINE_CHARACTER).get()).asString());
			string[] array = String.instancehelper_split(@this, "\\R", -1);
			___003C_003Eprinter.print("/*");
			for (int i = 0; i < (nint)array.LongLength - 1; i++)
			{
				___003C_003Eprinter.print(array[i]);
				___003C_003Eprinter.print((string)((ConfigurationOption)getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EEND_OF_LINE_CHARACTER).get()).asValue());
			}
			___003C_003Eprinter.print(array[(nint)array.LongLength - 1]);
			___003C_003Eprinter.println("*/");
		}
	}

	
	
	
	public virtual void visit(BinaryExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getLeft().accept(this, arg);
		if (getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ESPACE_AROUND_OPERATORS).isPresent())
		{
			___003C_003Eprinter.print(" ");
		}
		___003C_003Eprinter.print(n.getOperator().asString());
		if (getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ESPACE_AROUND_OPERATORS).isPresent())
		{
			___003C_003Eprinter.print(" ");
		}
		n.getRight().accept(this, arg);
	}

	
	
	
	public virtual void visit(AssignExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getTarget().accept(this, arg);
		if (getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ESPACE_AROUND_OPERATORS).isPresent())
		{
			___003C_003Eprinter.print(" ");
		}
		___003C_003Eprinter.print(n.getOperator().asString());
		if (getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003ESPACE_AROUND_OPERATORS).isPresent())
		{
			___003C_003Eprinter.print(" ");
		}
		n.getValue().accept(this, arg);
	}

	
	
	
	public virtual void visit(AssertStmt n, Void arg)
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

	
	
	
	public virtual void visit(ArrayType n, Void arg)
	{
		LinkedList linkedList = new LinkedList();
		Type type = n;
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

	
	
	
	public virtual void visit(ArrayInitializerExpr n, Void arg)
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

	
	
	
	public virtual void visit(ArrayCreationLevel n, Void arg)
	{
		printAnnotations(n.getAnnotations(), prefixWithASpace: true, arg);
		___003C_003Eprinter.print("[");
		if (n.getDimension().isPresent())
		{
			((Expression)n.getDimension().get()).accept(this, arg);
		}
		___003C_003Eprinter.print("]");
	}

	
	
	
	public virtual void visit(ArrayCreationExpr n, Void arg)
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

	
	
	
	public virtual void visit(ArrayAccessExpr n, Void arg)
	{
		printOrphanCommentsBeforeThisChildNode(n);
		printComment(n.getComment(), arg);
		n.getName().accept(this, arg);
		___003C_003Eprinter.print("[");
		n.getIndex().accept(this, arg);
		___003C_003Eprinter.print("]");
	}

	
	
	
	public virtual void visit(AnnotationMemberDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(AnnotationDeclaration n, Void arg)
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

	
	
	
	public virtual void visit(NodeList n, Void arg)
	{
		if (getOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EORDER_IMPORTS).isPresent() && n.size() > 0 && n.get(0) is ImportDeclaration)
		{
			NodeList nodeList = new NodeList(n);
			nodeList.sort(Comparator.comparingInt(new ___003C_003EAnon24()).thenComparing(new ___003C_003EAnon25()));
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

	
	
	
	
	private void lambda_0024printComment_00240(Void arg, Comment c)
	{
		c.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00241(Void arg, ModuleDeclaration m)
	{
		m.accept(this, arg);
	}

	
	
	
	
	private static bool lambda_0024visit_00242(string line)
	{
		return (!String.instancehelper_isEmpty(line) && !String.instancehelper_startsWith(line, " ")) ? true : false;
	}

	
	
	
	
	private void lambda_0024visit_00243(Void arg, Type t)
	{
		t.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_00245(VariableDeclarator n, Void arg, NodeWithVariables ancestor)
	{
		ancestor.getMaximumCommonType().ifPresent(new ___003C_003EAnon26(this, n, arg));
	}

	
	
	
	
	private void lambda_0024visit_00246(string line)
	{
		___003C_003Eprinter.println();
		___003C_003Eprinter.print(line);
	}

	
	
	
	
	private static Boolean lambda_0024visit_00247(Statement p)
	{
		Boolean result = Boolean.valueOf((p.isReturnStmt() || p.isThrowStmt() || p.isAssertStmt() || p.isExpressionStmt()) ? true : false);
		
		return result;
	}

	
	
	
	
	private void lambda_0024visit_00248(Void arg, AtomicBoolean columnAlignFirstMethodChain, AtomicBoolean methodCallWithScopeInScope, AtomicBoolean lastMethodInCallChain, Expression scope)
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

	
	
	
	
	private void lambda_0024visit_00249(Void arg, ConstructorDeclaration n, ReceiverParameter rp)
	{
		rp.accept(this, arg);
		if (!Utils.isNullOrEmpty(n.getParameters()))
		{
			___003C_003Eprinter.print(", ");
		}
	}

	
	
	
	
	private void lambda_0024visit_002410(Void arg, MethodDeclaration n, ReceiverParameter rp)
	{
		rp.accept(this, arg);
		if (!Utils.isNullOrEmpty(n.getParameters()))
		{
			___003C_003Eprinter.print(", ");
		}
	}

	
	
	
	
	private void lambda_0024visit_002411(Void arg, Type t)
	{
		t.accept(this, arg);
	}

	
	
	
	
	private void lambda_0024visit_002412(SimpleName l)
	{
		___003C_003Eprinter.print(" ").print(l.getIdentifier());
	}

	
	
	
	
	private static bool lambda_0024visit_002413(EnumConstantDeclaration e)
	{
		bool result = e.getComment().isPresent();
		
		return result;
	}

	
	
	
	
	private void lambda_0024visit_002414(SimpleName l)
	{
		___003C_003Eprinter.print(" ").print(l.getIdentifier());
	}

	
	
	
	
	private static int lambda_0024visit_002415(ImportDeclaration i)
	{
		return (!i.isStatic()) ? 1 : 0;
	}

	
	
	
	
	private void lambda_0024null_00244(VariableDeclarator n, Void arg, Type commonType)
	{
		Type type = n.getType();
		ArrayType arrayType = null;
		for (int i = commonType.getArrayLevel(); i < type.getArrayLevel(); i++)
		{
			arrayType = ((arrayType != null) ? ((ArrayType)arrayType.getComponentType()) : ((ArrayType)type));
			printAnnotations(arrayType.getAnnotations(), prefixWithASpace: true, arg);
			___003C_003Eprinter.print("[]");
		}
	}

	
	
	
	public DefaultPrettyPrinterVisitor(PrinterConfiguration configuration)
		: this(configuration, new SourcePrinter(configuration))
	{
	}

	
	
	public override string ToString()
	{
		string result = ___003C_003Eprinter.ToString();
		
		return result;
	}

	
	
	
	
	
	public virtual void visit(PatternExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(YieldStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(TextBlockLiteralExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(SwitchExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(Modifier n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(VarType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ReceiverParameter n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(UnparsableStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ModuleOpensDirective n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ModuleUsesDirective n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ModuleProvidesDirective n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ModuleExportsDirective n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ModuleRequiresDirective n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ModuleDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(WildcardType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(WhileStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(VoidType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(VariableDeclarator n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(VariableDeclarationExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(UnknownType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(UnionType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(UnaryExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(TypeParameter n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(TypeExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(TryStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ThrowStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ThisExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(SynchronizedStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(SwitchStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(SwitchEntry n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(SuperExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(StringLiteralExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(SingleMemberAnnotationExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(SimpleName n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ReturnStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(CompactConstructorDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(RecordDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(PrimitiveType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(Parameter n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(PackageDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ObjectCreationExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(NullLiteralExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(NormalAnnotationExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(Name n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(NameExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(MethodReferenceExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(MethodDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(MethodCallExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(MemberValuePair n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(MarkerAnnotationExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(LongLiteralExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(LocalRecordDeclarationStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(LocalClassDeclarationStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(LineComment n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(LambdaExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(LabeledStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(JavadocComment n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(IntersectionType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(IntegerLiteralExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(InstanceOfExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(InitializerDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ImportDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(IfStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ForEachStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ForStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(FieldDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(FieldAccessExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ExpressionStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(EnumDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(EnumConstantDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(EnclosedExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(EmptyStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(DoubleLiteralExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(DoStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ContinueStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ConstructorDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ConditionalExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(CompilationUnit n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ClassOrInterfaceType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ClassOrInterfaceDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ClassExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(CharLiteralExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(CatchClause n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(CastExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(BreakStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(BooleanLiteralExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(BlockStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(BlockComment n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(BinaryExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(AssignExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(AssertStmt n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ArrayType n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ArrayInitializerExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ArrayCreationLevel n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ArrayCreationExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(ArrayAccessExpr n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(AnnotationMemberDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(AnnotationDeclaration n, object arg)
	{
		visit(n, (Void)arg);
	}

	
	
	
	
	
	public virtual void visit(NodeList n, object arg)
	{
		visit(n, (Void)arg);
	}
}
