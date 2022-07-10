using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.generator.core.node;

public class CloneGenerator : NodeGenerator
{
	
	
	public CloneGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		nodeCu.addImport(ClassLiteral<CloneVisitor>.Value);
		MethodDeclaration callable = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("@Override public %s clone() { return (%s) accept(new CloneVisitor(), null); }", nodeMetaModel.getTypeNameGenerified(), nodeMetaModel.getTypeNameGenerified()));
		addOrReplaceWhenSameSignature(nodeCoid, callable);
	}
}
