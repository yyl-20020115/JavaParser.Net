
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;

using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.metamodel;

public class NodeMetaModelGenerator : AbstractGenerator
{
	
	private sealed class ___003C_003EAnon0 : Consumer
	{
		internal ___003C_003EAnon0()
		{
		}

		public void accept(object P_0)
		{
			((FieldDeclaration)P_0).remove();
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	private sealed class ___003CCallerID_003E : CallerID
	{
		internal ___003CCallerID_003E()
		{
		}
	}

	
	private sealed class ___003C_003EAnon2 : Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			string name = ((Field)P_0).getName();
			
			return name;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			string name = ((Method)P_0).getName();
			
			return name;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private InitializePropertyMetaModelsStatementsGenerator initializePropertyMetaModelsStatementsGenerator;

	
	private InitializeConstructorParametersStatementsGenerator initializeConstructorParametersStatementsGenerator;

	public const string GENERATED_CLASS_COMMENT = "This file, class, and its contents are completely generated based on:\n<ul>\n    <li>The contents and annotations within the package `com.github.javaparser.ast`, and</li>\n    <li>`ALL_NODE_CLASSES` within the class `com.github.javaparser.generator.metamodel.MetaModelGenerator`.</li>\n</ul>\n\nFor this reason, any changes made directly to this file will be overwritten the next time generators are run.";

	private const string GENERATED_JAVADOC_COMMENT = "Warning: The content of this class is partially or completely generated - manual edits risk being overwritten.";

	
	private static CallerID ___003CcallerID_003E;

	
	
	protected internal NodeMetaModelGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
		initializePropertyMetaModelsStatementsGenerator = new InitializePropertyMetaModelsStatementsGenerator();
		initializeConstructorParametersStatementsGenerator = new InitializeConstructorParametersStatementsGenerator();
	}

	
	
		
	public virtual void generate(Class nodeClass, ClassOrInterfaceDeclaration metaModelCoid, NodeList initializeNodeMetaModelsStatements, NodeList initializePropertyMetaModelsStatements, NodeList initializeConstructorParametersStatements, SourceRoot sourceRoot)
	{
		metaModelCoid.setJavadocComment("Warning: The content of this class is partially or completely generated - manual edits risk being overwritten.");
		AstTypeAnalysis astTypeAnalysis = new AstTypeAnalysis(nodeClass);
		string text = MetaModelGenerator.nodeMetaModelName(nodeClass);
		string text2 = Utils.decapitalize(text);
		metaModelCoid.getFieldByName(text2).ifPresent(new ___003C_003EAnon0());
		initializeNodeMetaModelsStatements.add(StaticJavaParser.parseStatement(CodeGenerationUtils.f("nodeMetaModels.add(%s);", text2)));
		initializeConstructorParametersStatementsGenerator.generate(nodeClass, initializeConstructorParametersStatements);
		Class superclass = nodeClass.getSuperclass();
		string text3 = MetaModelGenerator.nodeMetaModelName(superclass);
		int num = ((!MetaModelGenerator.isNode(superclass)) ? 1 : 0);
		FieldDeclaration fieldDeclaration = metaModelCoid.addField(text, text2, new com.github.javaparser.ast.Modifier.Keyword[3]
		{
			com.github.javaparser.ast.Modifier.Keyword.___003C_003EPUBLIC,
			com.github.javaparser.ast.Modifier.Keyword.___003C_003ESTATIC,
			com.github.javaparser.ast.Modifier.Keyword.___003C_003EFINAL
		});
		annotateGenerated(fieldDeclaration);
		fieldDeclaration.getVariable(0).setInitializer(StaticJavaParser.parseExpression(CodeGenerationUtils.f("new %s(%s)", text, CodeGenerationUtils.optionalOf(Utils.decapitalize(text3), (num == 0) ? true : false))));
		CompilationUnit compilationUnit = new CompilationUnit("com.github.javaparser.metamodel");
		compilationUnit.setBlockComment("\n * Copyright (C) 2007-2010 Júlio Vilmar Gesser.\n * Copyright (C) 2011, 2013-2021 The JavaParser Team.\n *\n * This file is part of JavaParser.\n *\n * JavaParser can be used either under the terms of\n * a) the GNU Lesser General Public License as published by\n *     the Free Software Foundation, either version 3 of the License, or\n *     (at your option) any later version.\n * b) the terms of the Apache License\n *\n * You should have received a copy of both licenses in LICENCE.LGPL and\n * LICENCE.APACHE. Please refer to those files for details.\n *\n * JavaParser is distributed in the hope that it will be useful,\n * but WITHOUT ANY WARRANTY; without even the implied warranty of\n * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\n * GNU Lesser General Public License for more details.\n ");
		compilationUnit.addImport(ClassLiteral<Optional>.Value);
		compilationUnit.addImport(nodeClass);
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = compilationUnit.addClass(text, com.github.javaparser.ast.Modifier.Keyword.___003C_003EPUBLIC);
		annotateGenerated(classOrInterfaceDeclaration);
		classOrInterfaceDeclaration.setJavadocComment("This file, class, and its contents are completely generated based on:\n<ul>\n    <li>The contents and annotations within the package `com.github.javaparser.ast`, and</li>\n    <li>`ALL_NODE_CLASSES` within the class `com.github.javaparser.generator.metamodel.MetaModelGenerator`.</li>\n</ul>\n\nFor this reason, any changes made directly to this file will be overwritten the next time generators are run.");
		if (num != 0)
		{
			classOrInterfaceDeclaration.addExtendedType("BaseNodeMetaModel");
		}
		else
		{
			classOrInterfaceDeclaration.addExtendedType(text3);
		}
		ConstructorDeclaration constructorDeclaration = (ConstructorDeclaration)classOrInterfaceDeclaration.addConstructor(new com.github.javaparser.ast.Modifier.Keyword[0]).addParameter(CodeGenerationUtils.f("Optional<%s>", "BaseNodeMetaModel"), CodeGenerationUtils.f("super%s", "BaseNodeMetaModel"));
		constructorDeclaration.getBody().addStatement(StaticJavaParser.parseExplicitConstructorInvocationStmt(CodeGenerationUtils.f("super(super%s, %s.class, \"%s\", \"%s\", %s, %s);", "BaseNodeMetaModel", nodeClass.getSimpleName(), nodeClass.getSimpleName(), nodeClass.getPackage().getName(), Boolean.valueOf(astTypeAnalysis.isAbstract), Boolean.valueOf(astTypeAnalysis.isSelfType))));
		annotateGenerated(constructorDeclaration);
		if (astTypeAnalysis.isAbstract)
		{
			compilationUnit.addImport(ClassLiteral<Node>.Value);
			BodyDeclaration bodyDeclaration = StaticJavaParser.parseBodyDeclaration(CodeGenerationUtils.f("protected %s(Optional<%s> superNodeMetaModel, Class<? extends Node> type, String name, String packageName, boolean isAbstract, boolean hasWildcard) {super(superNodeMetaModel, type, name, packageName, isAbstract, hasWildcard); }", text, "BaseNodeMetaModel"));
			annotateGenerated(bodyDeclaration);
			classOrInterfaceDeclaration.addMember(bodyDeclaration);
		}
		
		ArrayList arrayList = new ArrayList(Arrays.asList(nodeClass.getDeclaredFields(NodeMetaModelGenerator.___003CGetCallerID_003E())));
		((List)arrayList).sort(Comparator.comparing(new ___003C_003EAnon2()));
		Iterator iterator = ((List)arrayList).iterator();
		while (iterator.hasNext())
		{
			Field field = (Field)iterator.next();
			if (!fieldShouldBeIgnored(field))
			{
				initializePropertyMetaModelsStatementsGenerator.generate(field, classOrInterfaceDeclaration, text2, initializePropertyMetaModelsStatements);
			}
		}
		
		ArrayList arrayList2 = new ArrayList(Arrays.asList(nodeClass.getMethods(NodeMetaModelGenerator.___003CGetCallerID_003E())));
		((List)arrayList2).sort(Comparator.comparing(new ___003C_003EAnon3()));
		Iterator iterator2 = ((List)arrayList2).iterator();
		while (iterator2.hasNext())
		{
			Method method = (Method)iterator2.next();
			if (method.isAnnotationPresent(ClassLiteral<DerivedProperty>.Value))
			{
				initializePropertyMetaModelsStatementsGenerator.generateDerivedProperty(method, classOrInterfaceDeclaration, text2, initializePropertyMetaModelsStatements);
			}
		}
		moveStaticInitializeToTheEndOfTheClassBecauseWeNeedTheFieldsToInitializeFirst(metaModelCoid);
		sourceRoot.add("com.github.javaparser.metamodel", new StringBuilder().append(text).append(".java").ToString(), compilationUnit);
	}

	
	
	private bool fieldShouldBeIgnored(Field P_0)
	{
		return (java.lang.reflect.Modifier.isStatic(P_0.getModifiers()) || P_0.isAnnotationPresent(ClassLiteral<InternalProperty>.Value)) ? true : false;
	}

	
	
	private void moveStaticInitializeToTheEndOfTheClassBecauseWeNeedTheFieldsToInitializeFirst(ClassOrInterfaceDeclaration P_0)
	{
		Iterator iterator = P_0.getMembers().iterator();
		while (iterator.hasNext())
		{
			BodyDeclaration bodyDeclaration = (BodyDeclaration)iterator.next();
			if (bodyDeclaration is InitializerDeclaration)
			{
				bodyDeclaration.remove();
				P_0.addMember(bodyDeclaration);
				break;
			}
		}
	}

	static CallerID ___003CGetCallerID_003E()
	{
		if (___003CcallerID_003E == null)
		{
			___003CcallerID_003E = new ___003CCallerID_003E();
		}
		return ___003CcallerID_003E;
	}
}
