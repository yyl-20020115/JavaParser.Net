using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;

namespace com.github.javaparser.generator.core.node;

public class ReplaceMethodGenerator : NodeGenerator
{
	
	
	public ReplaceMethodGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	[LineNumberTable(new byte[]
	{
		40,
		238,
		69,
		byte.MaxValue,
		2,
		59
	})]
	private string nodeListCheck(PropertyMetaModel P_0)
	{
		string result = CodeGenerationUtils.f("for (int i = 0; i < %s.size(); i++) {  if (%s.get(i) == node) {    %s.set(i, (%s) replacementNode);    return true;  }}", P_0.getName(), P_0.getName(), P_0.getName(), P_0.getTypeName());
		
		return result;
	}

	
	
	private string attributeCheck(PropertyMetaModel P_0, string P_1)
	{
		string result = CodeGenerationUtils.f("if (node == %s) {    %s((%s) replacementNode);    return true;\n}", P_0.getName(), P_1, P_0.getTypeName());
		
		return result;
	}

	
	[LineNumberTable(new byte[]
	{
		159, 186, 112, 108, 136, 145, 140, 98, 127, 5,
		105, 162, 105, 140, 145, 105, 159, 2, 105, 100,
		101, 109, 142, 172, 107, 138, 138
	})]
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		MethodDeclaration methodDeclaration = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration("public boolean replace(Node node, Node replacementNode) {}");
		nodeCu.addImport(ClassLiteral<Node>.Value);
		annotateWhenOverridden(nodeMetaModel, methodDeclaration);
		BlockStmt blockStmt = (BlockStmt)methodDeclaration.getBody().get();
		blockStmt.addStatement("if (node == null) { return false; }");
		int num = 0;
		Iterator iterator = nodeMetaModel.getDeclaredPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			if (propertyMetaModel.isNode())
			{
				string text = ((!propertyMetaModel.isNodeList()) ? attributeCheck(propertyMetaModel, propertyMetaModel.getSetterMethodName()) : nodeListCheck(propertyMetaModel));
				if (propertyMetaModel.isOptional())
				{
					text = CodeGenerationUtils.f("if (%s != null) { %s }", propertyMetaModel.getName(), text);
				}
				blockStmt.addStatement(text);
				num++;
			}
		}
		if (nodeMetaModel.getSuperNodeMetaModel().isPresent())
		{
			blockStmt.addStatement("return super.replace(node, replacementNode);");
		}
		else
		{
			blockStmt.addStatement("return false;");
		}
		if (!nodeMetaModel.isRootNode() && num == 0)
		{
			removeMethodWithSameSignature(nodeCoid, methodDeclaration);
		}
		else
		{
			addOrReplaceWhenSameSignature(nodeCoid, methodDeclaration);
		}
	}
}
