using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;

namespace com.github.javaparser.generator.core.node;

public class MainConstructorGenerator : NodeGenerator
{
	
	
	public MainConstructorGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	[LineNumberTable(new byte[]
	{
		159, 188, 109, 129, 102, 107, 121, 111, 139, 135,
		117, 127, 7, 127, 8, 117, 111, 159, 14, 159,
		9, 133, 151, 140, 104, 108
	})]
	protected internal override void generateNode(BaseNodeMetaModel nodeMetaModel, CompilationUnit nodeCu, ClassOrInterfaceDeclaration nodeCoid)
	{
		if (nodeMetaModel.@is(ClassLiteral<Node>.Value))
		{
			return;
		}
		ConstructorDeclaration constructorDeclaration = (ConstructorDeclaration)((ConstructorDeclaration)((ConstructorDeclaration)((ConstructorDeclaration)new ConstructorDeclaration().setPublic(true)).setName(nodeCoid.getNameAsString())).addParameter(ClassLiteral<TokenRange>.Value, "tokenRange")).setJavadocComment("\n     * This constructor is used by the parser and is considered private.\n     ");
		BlockStmt body = constructorDeclaration.getBody();
		SeparatedItemStringBuilder separatedItemStringBuilder = new SeparatedItemStringBuilder("super(", ", ", ");");
		object[] args = new object[0];
		CharSequence format = default(CharSequence);
		object obj = (format.___003Cref_003E = "tokenRange");
		separatedItemStringBuilder.append(format, args);
		Iterator iterator = nodeMetaModel.getConstructorParameters().iterator();
		while (iterator.hasNext())
		{
			PropertyMetaModel propertyMetaModel = (PropertyMetaModel)iterator.next();
			constructorDeclaration.addParameter(propertyMetaModel.getTypeNameForSetter(), propertyMetaModel.getName());
			if (nodeMetaModel.getDeclaredPropertyMetaModels().contains(propertyMetaModel))
			{
				body.addStatement(CodeGenerationUtils.f("%s(%s);", propertyMetaModel.getSetterMethodName(), propertyMetaModel.getName()));
			}
			else
			{
				string name = propertyMetaModel.getName();
				args = new object[0];
				obj = (format.___003Cref_003E = name);
				separatedItemStringBuilder.append(format, args);
			}
		}
		body.getStatements().addFirst(StaticJavaParser.parseExplicitConstructorInvocationStmt(separatedItemStringBuilder.ToString()));
		body.addStatement("customInitialization();");
		addOrReplaceWhenSameSignature(nodeCoid, constructorDeclaration);
		nodeCu.addImport(ClassLiteral<TokenRange>.Value);
	}
}
