using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.generator.core.node;

public class AcceptGenerator : NodeGenerator
{
	
	private MethodDeclaration genericAccept;

	
	private MethodDeclaration voidAccept;

	
	
	public AcceptGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
		genericAccept = StaticJavaParser.parseBodyDeclaration("@Override public <R, A> R accept(final GenericVisitor<R, A> v, final A arg) { return v.visit(this, arg); }").asMethodDeclaration();
		voidAccept = StaticJavaParser.parseBodyDeclaration("@Override public <A> void accept(final VoidVisitor<A> v, final A arg) { v.visit(this, arg); }").asMethodDeclaration();
	}

	
	
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		if (!nodeMetaModel.isAbstract())
		{
			nodeCu.addImport(ClassLiteral<GenericVisitor>.Value);
			nodeCu.addImport(ClassLiteral<VoidVisitor>.Value);
			addOrReplaceWhenSameSignature(nodeCoid, genericAccept);
			addOrReplaceWhenSameSignature(nodeCoid, voidAccept);
		}
	}
}
