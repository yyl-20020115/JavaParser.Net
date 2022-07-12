
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;

namespace com.github.javaparser.generator.core.node;

public class GetMetaModelGenerator : NodeGenerator
{
	
	
	public GetMetaModelGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		MethodDeclaration callable = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("%s public %s getMetaModel() { return JavaParserMetaModel.%s; }", (!nodeMetaModel.isRootNode()) ? "@Override" : "", Object.instancehelper_getClass(nodeMetaModel).getSimpleName(), nodeMetaModel.getMetaModelFieldName()));
		addOrReplaceWhenSameSignature(nodeCoid, callable);
		nodeCu.addImport(Object.instancehelper_getClass(nodeMetaModel).getName());
		nodeCu.addImport(ClassLiteral<JavaParserMetaModel>.Value);
	}
}
