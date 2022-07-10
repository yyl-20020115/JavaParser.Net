using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.comments;
using IKVM.Attributes;
using java.lang;
using java.util.function;

namespace com.github.javaparser.printer.concretesyntaxmodel;

public class CsmComment: CsmElement
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		private readonly SourcePrinter arg_00241;

		internal ___003C_003EAnon0(SourcePrinter P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024prettyPrint_00240(arg_00241, (Comment)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	public CsmComment()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159, 176, 109, 104, 108, 104, 110, 104, 108, 104,
		110, 104, 108, 104, 137, 150
	})]
	internal static void process(Comment comment, SourcePrinter printer)
	{
		string arg = printer.normalizeEolInTextBlock(comment.getContent());
		if (comment is BlockComment)
		{
			printer.print("/*");
			printer.print(arg);
			printer.println("*/");
			return;
		}
		if (comment is JavadocComment)
		{
			printer.print("/**");
			printer.print(arg);
			printer.println("*/");
			return;
		}
		if (comment is LineComment)
		{
			printer.print("//");
			printer.print(arg);
			printer.println();
			return;
		}
		string simpleName = Object.instancehelper_getClass(comment).getSimpleName();
		
		throw new UnsupportedOperationException(simpleName);
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	private static void lambda_0024prettyPrint_00240(SourcePrinter printer, Comment c)
	{
		process(c, printer);
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void prettyPrint(Node node, SourcePrinter printer)
	{
		node.getComment().ifPresent(new ___003C_003EAnon0(printer));
	}
}
