
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.generator.core.node;

public class RemoveMethodGenerator : NodeGenerator
{
	
	
	public RemoveMethodGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	
	private string nodeListCheck(PropertyMetaModel P_0)
	{
		string result = CodeGenerationUtils.f("for (int i = 0; i < %s.size(); i++) {  if (%s.get(i) == node) {    %s.remove(i);    return true;  }}", P_0.getName(), P_0.getName(), P_0.getName());
		
		return result;
	}

	
	
	private string generateRemoveMethodForAttribute(ClassOrInterfaceDeclaration P_0, BaseNodeMetaModel P_1, PropertyMetaModel P_2)
	{
		string text = new StringBuilder().append("remove").append(Utils.capitalize(P_2.getName())).ToString();
		MethodDeclaration methodDeclaration = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("public %s %s() {}", P_1.getTypeName(), text));
		BlockStmt blockStmt = (BlockStmt)methodDeclaration.getBody().get();
		blockStmt.addStatement(CodeGenerationUtils.f("return %s((%s) null);", P_2.getSetterMethodName(), P_2.getTypeNameForSetter()));
		addOrReplaceWhenSameSignature(P_0, methodDeclaration);
		return text;
	}

	
	
	private string attributeCheck(PropertyMetaModel P_0, string P_1)
	{
		string result = CodeGenerationUtils.f("if (node == %s) {    %s();    return true;\n}", P_0.getName(), P_1);
		
		return result;
	}

	
	
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		MethodDeclaration methodDeclaration = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration("public boolean remove(Node node) {}");
		nodeCu.addImport(ClassLiteral<Node>.Value);
		annotateWhenOverridden(nodeMetaModel, methodDeclaration);
		BlockStmt blockStmt = (BlockStmt)methodDeclaration.getBody().get();
		blockStmt.addStatement("if (node == null) { return false; }");
		int num = 0;
		Iterator iterator = nodeMetaModel.getDeclaredPropertyMetaModels().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			if (!propertyMetaModel.isNode())
			{
				continue;
			}
			string text;
			if (propertyMetaModel.isNodeList())
			{
				text = nodeListCheck(propertyMetaModel);
			}
			else
			{
				if (propertyMetaModel.isRequired())
				{
					continue;
				}
				string text2 = generateRemoveMethodForAttribute(nodeCoid, nodeMetaModel, propertyMetaModel);
				text = attributeCheck(propertyMetaModel, text2);
			}
			if (propertyMetaModel.isOptional())
			{
				text = CodeGenerationUtils.f("if (%s != null) { %s }", propertyMetaModel.getName(), text);
			}
			blockStmt.addStatement(text);
			num++;
		}
		if (nodeMetaModel.getSuperNodeMetaModel().isPresent())
		{
			blockStmt.addStatement("return super.remove(node);");
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
