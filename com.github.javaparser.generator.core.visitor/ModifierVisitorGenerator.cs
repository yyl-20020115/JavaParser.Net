
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser.generator.core.visitor;

public class ModifierVisitorGenerator : VisitorGenerator
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

	
	private sealed class ___003C_003EAnon1 : ToIntFunction
	{
		private readonly List arg_00241;

		internal ___003C_003EAnon1(List P_0)
		{
			arg_00241 = P_0;
		}

		public int applyAsInt(object P_0)
		{
			int result = lambda_0024generateVisitMethodBody_00241(arg_00241, (PropertyMetaModel)P_0);
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly ModifierVisitorGenerator arg_00241;

		private readonly BlockStmt arg_00242;

		internal ___003C_003EAnon2(ModifierVisitorGenerator P_0, BlockStmt P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024generateVisitMethodBody_00242(arg_00242, (PropertyMetaModel)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly SeparatedItemStringBuilder arg_00241;

		internal ___003C_003EAnon3(SeparatedItemStringBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024generateVisitMethodBody_00243(arg_00241, (PropertyMetaModel)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly BlockStmt arg_00241;

		internal ___003C_003EAnon4(BlockStmt P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024generateVisitMethodBody_00244(arg_00241, (PropertyMetaModel)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	
	public ModifierVisitorGenerator(SourceRoot sourceRoot)
		: base(sourceRoot, "com.github.javaparser.ast.visitor", "ModifierVisitor", "Visitable", "A", createMissingVisitMethods: true)
	{
	}

	
	
	private void extracted(BlockStmt P_0, PropertyMetaModel P_1)
	{
		if (P_1.isNode())
		{
			if (P_1.isNodeList())
			{
				P_0.addStatement(CodeGenerationUtils.f("NodeList<%s> %s = modifyList(n.%s(), arg);", P_1.getTypeNameGenerified(), P_1.getName(), P_1.getGetterMethodName()));
			}
			else if (P_1.isOptional())
			{
				P_0.addStatement(CodeGenerationUtils.f("%s %s = n.%s().map(s -> (%s) s.accept(this, arg)).orElse(null);", P_1.getTypeNameGenerified(), P_1.getName(), P_1.getGetterMethodName(), P_1.getTypeNameGenerified()));
			}
			else
			{
				P_0.addStatement(CodeGenerationUtils.f("%s %s = (%s) n.%s().accept(this, arg);", P_1.getTypeNameGenerified(), P_1.getName(), P_1.getTypeNameGenerified(), P_1.getGetterMethodName()));
			}
		}
	}

	
	
	
	private static void lambda_0024generateVisitMethodBody_00240(Parameter P_0)
	{
		_ = (Parameter)P_0.setFinal(true);
	}

	
	
	
	private static int lambda_0024generateVisitMethodBody_00241(List P_0, PropertyMetaModel P_1)
	{
		int result = P_0.indexOf(P_1.getName());
		
		return result;
	}

	
	
	
	private void lambda_0024generateVisitMethodBody_00242(BlockStmt P_0, PropertyMetaModel P_1)
	{
		extracted(P_0, P_1);
	}

	
	
	
	private static void lambda_0024generateVisitMethodBody_00243(SeparatedItemStringBuilder P_0, PropertyMetaModel P_1)
	{
		if (!P_1.isRequired() || !P_1.isNode())
		{
			return;
		}
		CharSequence format = default(CharSequence);
		if (P_1.isNodeList())
		{
			if (P_1.isNonEmpty())
			{
				string __003Cref_003E = CodeGenerationUtils.f("%s.isEmpty()", P_1.getName());
				object[] args = new object[0];
				object obj = (format.___003Cref_003E = __003Cref_003E);
				P_0.append(format, args);
			}
		}
		else
		{
			string __003Cref_003E2 = CodeGenerationUtils.f("%s==null", P_1.getName());
			object[] args = new object[0];
			object obj = (format.___003Cref_003E = __003Cref_003E2);
			P_0.append(format, args);
		}
	}

	
	
	
	private static void lambda_0024generateVisitMethodBody_00244(BlockStmt P_0, PropertyMetaModel P_1)
	{
		if (P_1.isNode())
		{
			P_0.addStatement(CodeGenerationUtils.f("n.%s(%s);", P_1.getSetterMethodName(), P_1.getName()));
		}
	}

	
	
	protected internal override void generateVisitMethodBody(BaseNodeMetaModel node, MethodDeclaration visitMethod, CompilationUnit compilationUnit)
	{
		visitMethod.getParameters().forEach(new ___003C_003EAnon0());
		BlockStmt blockStmt = (BlockStmt)visitMethod.getBody().get();
		blockStmt.getStatements().clear();
		List list = Arrays.asList("modifiers", "annotations");
		List list2 = (List)node.getAllPropertyMetaModels().stream().sorted(Comparator.comparingInt(new ___003C_003EAnon1(list)).reversed())
			.collect(Collectors.toList());
		list2.forEach(new ___003C_003EAnon2(this, blockStmt));
		if (node.@is(ClassLiteral<BinaryExpr>.Value))
		{
			blockStmt.addStatement("if (left == null) return right;");
			blockStmt.addStatement("if (right == null) return left;");
		}
		else
		{
			SeparatedItemStringBuilder separatedItemStringBuilder = new SeparatedItemStringBuilder("if(", "||", ") return null;");
			list2.forEach(new ___003C_003EAnon3(separatedItemStringBuilder));
			if (separatedItemStringBuilder.hasItems())
			{
				blockStmt.addStatement(separatedItemStringBuilder.ToString());
			}
		}
		list2.forEach(new ___003C_003EAnon4(blockStmt));
		blockStmt.addStatement("return n;");
	}
}
