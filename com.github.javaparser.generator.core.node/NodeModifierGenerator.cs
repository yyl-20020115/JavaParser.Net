
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;


namespace com.github.javaparser.generator.core.node;

public class NodeModifierGenerator : NodeGenerator
{
	
	
	public NodeModifierGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		((ClassOrInterfaceDeclaration)nodeCoid.setFinal(false)).setPublic(true);
	}
}
