using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.core.visitor;

public class VoidVisitorAdapterGenerator : VisitorGenerator
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

	
	
	public VoidVisitorAdapterGenerator(SourceRoot sourceRoot)
		: base(sourceRoot, "com.github.javaparser.ast.visitor", "VoidVisitorAdapter", "void", "A", createMissingVisitMethods: true)
	{
	}

	
	
	
	private static void lambda_0024generateVisitMethodBody_00240(Parameter P_0)
	{
		_ = (Parameter)P_0.setFinal(true);
	}

	
	[LineNumberTable(new byte[]
	{
		159, 186, 149, 113, 139, 127, 4, 127, 1, 112,
		112, 127, 1, 104, 125, 104, 157, 187, 101
	})]
	protected internal override void generateVisitMethodBody(BaseNodeMetaModel node, MethodDeclaration visitMethod, CompilationUnit compilationUnit)
	{
		visitMethod.getParameters().forEach(new ___003C_003EAnon0());
		BlockStmt blockStmt = (BlockStmt)visitMethod.getBody().get();
		blockStmt.getStatements().clear();
		Iterator iterator = node.getAllPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			string text = new StringBuilder().append(propertyMetaModel.getGetterMethodName()).append("()").ToString();
			if (propertyMetaModel.getNodeReference().isPresent())
			{
				if (propertyMetaModel.isOptional() && propertyMetaModel.isNodeList())
				{
					blockStmt.addStatement(CodeGenerationUtils.f("n.%s.ifPresent( l -> l.forEach( v -> v.accept(this, arg)));", text));
				}
				else if (propertyMetaModel.isOptional())
				{
					blockStmt.addStatement(CodeGenerationUtils.f("n.%s.ifPresent(l -> l.accept(this, arg));", text));
				}
				else if (propertyMetaModel.isNodeList())
				{
					blockStmt.addStatement(CodeGenerationUtils.f("n.%s.forEach(p -> p.accept(this, arg));", text));
				}
				else
				{
					blockStmt.addStatement(CodeGenerationUtils.f("n.%s.accept(this, arg);", text));
				}
			}
		}
	}
}
