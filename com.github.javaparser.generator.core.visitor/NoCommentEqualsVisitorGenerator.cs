
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.core.visitor;

public class NoCommentEqualsVisitorGenerator : VisitorGenerator
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

	
	
	public NoCommentEqualsVisitorGenerator(SourceRoot sourceRoot)
		: base(sourceRoot, "com.github.javaparser.ast.visitor", "NoCommentEqualsVisitor", "Boolean", "Visitable", createMissingVisitMethods: true)
	{
	}

	
	
	
	private static void lambda_0024generateVisitMethodBody_00240(Parameter P_0)
	{
		_ = (Parameter)P_0.setFinal(true);
	}

	
	
	protected internal override void generateVisitMethodBody(BaseNodeMetaModel node, MethodDeclaration visitMethod, CompilationUnit compilationUnit)
	{
		visitMethod.getParameters().forEach(new ___003C_003EAnon0());
		BlockStmt blockStmt = (BlockStmt)visitMethod.getBody().get();
		blockStmt.getStatements().clear();
		if (!node.equals(JavaParserMetaModel.___003C_003ElineCommentMetaModel) && !node.equals(JavaParserMetaModel.___003C_003EblockCommentMetaModel) && !node.equals(JavaParserMetaModel.___003C_003EjavadocCommentMetaModel))
		{
			blockStmt.addStatement(CodeGenerationUtils.f("final %s n2 = (%s) arg;", node.getTypeName(), node.getTypeName()));
			Iterator iterator = node.getAllPropertyMetaModels().iterator();
			while (iterator.hasNext())
			{
				PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
				string text = new StringBuilder().append(propertyMetaModel.getGetterMethodName()).append("()").ToString();
				if (propertyMetaModel.equals(JavaParserMetaModel.___003C_003EnodeMetaModel.commentPropertyMetaModel))
				{
					continue;
				}
				if (propertyMetaModel.getNodeReference().isPresent())
				{
					if (propertyMetaModel.isNodeList())
					{
						blockStmt.addStatement(CodeGenerationUtils.f("if (!nodesEquals(n.%s, n2.%s)) return false;", text, text));
					}
					else
					{
						blockStmt.addStatement(CodeGenerationUtils.f("if (!nodeEquals(n.%s, n2.%s)) return false;", text, text));
					}
				}
				else
				{
					blockStmt.addStatement(CodeGenerationUtils.f("if (!objEquals(n.%s, n2.%s)) return false;", text, text));
				}
			}
			if (blockStmt.getStatements().size() == 1)
			{
				blockStmt.getStatements().clear();
			}
		}
		blockStmt.addStatement("return true;");
	}
}
