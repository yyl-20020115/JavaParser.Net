using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.core.node;

public class TypeCastingGenerator : NodeGenerator
{
	
		private Set baseNodes;

	
	[LineNumberTable(new byte[]
	{
		2,
		233,
		54,
		byte.MaxValue,
		34,
		75
	})]
	public TypeCastingGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
		baseNodes = Utils.set(JavaParserMetaModel.___003C_003EstatementMetaModel, JavaParserMetaModel.___003C_003EexpressionMetaModel, JavaParserMetaModel.___003C_003EtypeMetaModel, JavaParserMetaModel.___003C_003EmoduleDirectiveMetaModel, JavaParserMetaModel.___003C_003EbodyDeclarationMetaModel, JavaParserMetaModel.___003C_003EcommentMetaModel);
	}

	
	
	private void generateIsType(BaseNodeMetaModel P_0, CompilationUnit P_1, ClassOrInterfaceDeclaration P_2, ClassOrInterfaceDeclaration P_3, string P_4)
	{
		MethodDeclaration callable = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("public boolean is%s() { return false; }", P_4));
		MethodDeclaration methodDeclaration = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("@Override public boolean is%s() { return true; }", P_4));
		annotateWhenOverridden(P_0, methodDeclaration);
		addOrReplaceWhenSameSignature(P_2, methodDeclaration);
		addOrReplaceWhenSameSignature(P_3, callable);
	}

	
	
	private void generateAsType(BaseNodeMetaModel P_0, CompilationUnit P_1, ClassOrInterfaceDeclaration P_2, ClassOrInterfaceDeclaration P_3, string P_4)
	{
		P_1.addImport("com.github.javaparser.utils.CodeGenerationUtils.f", isStatic: true, isAsterisk: false);
		MethodDeclaration callable = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("public %s as%s() { throw new IllegalStateException(f(\"%%s is not %s, it is %%s\", this, this.getClass().getSimpleName())); }", P_4, P_4, P_4));
		MethodDeclaration methodDeclaration = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("@Override public %s as%s() { return this; }", P_4, P_4));
		annotateWhenOverridden(P_0, methodDeclaration);
		addOrReplaceWhenSameSignature(P_3, callable);
		addOrReplaceWhenSameSignature(P_2, methodDeclaration);
	}

	
	
	private void generateToType(BaseNodeMetaModel P_0, CompilationUnit P_1, CompilationUnit P_2, ClassOrInterfaceDeclaration P_3, ClassOrInterfaceDeclaration P_4, string P_5)
	{
		P_2.addImport(ClassLiteral<Optional>.Value);
		P_1.addImport(ClassLiteral<Optional>.Value);
		MethodDeclaration callable = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("public Optional<%s> to%s() { return Optional.empty(); }", P_5, P_5, P_5));
		MethodDeclaration methodDeclaration = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("@Override public Optional<%s> to%s() { return Optional.of(this); }", P_5, P_5));
		annotateWhenOverridden(P_0, methodDeclaration);
		addOrReplaceWhenSameSignature(P_4, callable);
		addOrReplaceWhenSameSignature(P_3, methodDeclaration);
	}

	
	
	private void generateIfType(BaseNodeMetaModel P_0, CompilationUnit P_1, CompilationUnit P_2, ClassOrInterfaceDeclaration P_3, ClassOrInterfaceDeclaration P_4, string P_5)
	{
		P_2.addImport(ClassLiteral<Consumer>.Value);
		P_1.addImport(ClassLiteral<Consumer>.Value);
		MethodDeclaration callable = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("public void if%s(Consumer<%s> action) { }", P_5, P_5));
		MethodDeclaration methodDeclaration = (MethodDeclaration)StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("public void if%s(Consumer<%s> action) { action.accept(this); }", P_5, P_5));
		annotateWhenOverridden(P_0, methodDeclaration);
		addOrReplaceWhenSameSignature(P_4, callable);
		addOrReplaceWhenSameSignature(P_3, methodDeclaration);
	}

	
	
	[LineNumberTable(new byte[]
	{
		7, 98, 127, 1, 164, 129, 105, 136, 130, 131,
		161, 103, 109, 141, 109, 109, 110, 112
	})]
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		Pair pair = null;
		Iterator iterator = baseNodes.iterator();
		while (iterator.hasNext())
		{
			BaseNodeMetaModel baseNodeMetaModel = (BaseNodeMetaModel)iterator.next();
			if (nodeMetaModel == baseNodeMetaModel)
			{
				return;
			}
			if (nodeMetaModel.isInstanceOfMetaModel(baseNodeMetaModel))
			{
				pair = parseNode(baseNodeMetaModel);
			}
		}
		if (pair != null)
		{
			string typeName = nodeMetaModel.getTypeName();
			ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)pair.___003C_003Eb;
			CompilationUnit compilationUnit = (CompilationUnit)pair.___003C_003Ea;
			generateIsType(nodeMetaModel, compilationUnit, nodeCoid, classOrInterfaceDeclaration, typeName);
			generateAsType(nodeMetaModel, compilationUnit, nodeCoid, classOrInterfaceDeclaration, typeName);
			generateToType(nodeMetaModel, nodeCu, compilationUnit, nodeCoid, classOrInterfaceDeclaration, typeName);
			generateIfType(nodeMetaModel, nodeCu, compilationUnit, nodeCoid, classOrInterfaceDeclaration, typeName);
		}
	}
}
