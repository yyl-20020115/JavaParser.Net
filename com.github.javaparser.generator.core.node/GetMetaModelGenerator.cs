using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.generator.core.node;

public class GetMetaModelGenerator : NodeGenerator
{
	
	
	public GetMetaModelGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	[LineNumberTable(new byte[]
	{
		159, 184, 110, 119, 110, 230, 61, 240, 69, 104,
		114, 108
	})]
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		MethodDeclaration callable = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("%s public %s getMetaModel() { return JavaParserMetaModel.%s; }", (!nodeMetaModel.isRootNode()) ? "@Override" : "", Object.instancehelper_getClass(nodeMetaModel).getSimpleName(), nodeMetaModel.getMetaModelFieldName()));
		addOrReplaceWhenSameSignature(nodeCoid, callable);
		nodeCu.addImport(Object.instancehelper_getClass(nodeMetaModel).getName());
		nodeCu.addImport(ClassLiteral<JavaParserMetaModel>.Value);
	}
}
