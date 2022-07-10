using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.metamodel;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;

namespace com.github.javaparser.generator.metamodel;

internal class InitializePropertyMetaModelsStatementsGenerator
{
	
	
	private bool isOptional(Field P_0)
	{
		bool result = P_0.isAnnotationPresent(ClassLiteral<OptionalProperty>.Value);
		
		return result;
	}

	
	
	private bool isNonEmpty(Field P_0)
	{
		bool result = P_0.isAnnotationPresent(ClassLiteral<NonEmptyProperty>.Value);
		
		return result;
	}

	
	
	private bool isNonEmpty(Method P_0)
	{
		bool result = P_0.isAnnotationPresent(ClassLiteral<NonEmptyProperty>.Value);
		
		return result;
	}

	
	
	internal InitializePropertyMetaModelsStatementsGenerator()
	{
	}

	
		[LineNumberTable(new byte[]
	{
		159, 184, 140, 103, 112, 127, 1, 123, 146, 141,
		122, 111, 115, 110, 230, 56, 231, 73, 127, 0,
		158, 111, 111
	})]
	internal virtual void generate(Field P_0, ClassOrInterfaceDeclaration P_1, string P_2, NodeList P_3)
	{
		AstTypeAnalysis astTypeAnalysis = new AstTypeAnalysis(P_0.getGenericType());
		Class innerType = astTypeAnalysis.innerType;
		string text = String.instancehelper_replace(innerType.getTypeName(), '$', '.');
		string text2 = new StringBuilder().append(P_0.getName()).append("PropertyMetaModel").ToString();
		P_1.addField("PropertyMetaModel", text2, new com.github.javaparser.ast.Modifier.Keyword[1] { com.github.javaparser.ast.Modifier.Keyword.___003C_003EPUBLIC });
		string text3 = CodeGenerationUtils.f("new PropertyMetaModel(%s, \"%s\", %s.class, %s, %s, %s, %s, %s)", P_2, P_0.getName(), text, CodeGenerationUtils.optionalOf(Utils.decapitalize(MetaModelGenerator.nodeMetaModelName(innerType)), MetaModelGenerator.isNode(innerType)), Boolean.valueOf(isOptional(P_0)), Boolean.valueOf(isNonEmpty(P_0)), Boolean.valueOf(astTypeAnalysis.isNodeList), Boolean.valueOf(astTypeAnalysis.isSelfType));
		string statement = CodeGenerationUtils.f("%s.%s=%s;", P_2, text2, text3);
		string statement2 = CodeGenerationUtils.f("%s.getDeclaredPropertyMetaModels().add(%s.%s);", P_2, P_2, text2);
		P_3.add(StaticJavaParser.parseStatement(statement));
		P_3.add(StaticJavaParser.parseStatement(statement2));
	}

	
		[LineNumberTable(new byte[]
	{
		15, 140, 103, 112, 127, 6, 123, 146, 146, 126,
		106, 115, 110, 230, 56, 231, 73, 127, 0, 158,
		111, 111
	})]
	internal virtual void generateDerivedProperty(Method P_0, ClassOrInterfaceDeclaration P_1, string P_2, NodeList P_3)
	{
		AstTypeAnalysis astTypeAnalysis = new AstTypeAnalysis(P_0.getGenericReturnType());
		Class innerType = astTypeAnalysis.innerType;
		string text = String.instancehelper_replace(innerType.getTypeName(), '$', '.');
		string text2 = new StringBuilder().append(CodeGenerationUtils.getterToPropertyName(P_0.getName())).append("PropertyMetaModel").ToString();
		P_1.addField("PropertyMetaModel", text2, new com.github.javaparser.ast.Modifier.Keyword[1] { com.github.javaparser.ast.Modifier.Keyword.___003C_003EPUBLIC });
		string text3 = CodeGenerationUtils.f("new PropertyMetaModel(%s, \"%s\", %s.class, %s, %s, %s, %s, %s)", P_2, CodeGenerationUtils.getterToPropertyName(P_0.getName()), text, CodeGenerationUtils.optionalOf(Utils.decapitalize(MetaModelGenerator.nodeMetaModelName(innerType)), MetaModelGenerator.isNode(innerType)), Boolean.valueOf(astTypeAnalysis.isOptional), Boolean.valueOf(isNonEmpty(P_0)), Boolean.valueOf(astTypeAnalysis.isNodeList), Boolean.valueOf(astTypeAnalysis.isSelfType));
		string statement = CodeGenerationUtils.f("%s.%s=%s;", P_2, text2, text3);
		string statement2 = CodeGenerationUtils.f("%s.getDerivedPropertyMetaModels().add(%s.%s);", P_2, P_2, text2);
		P_3.add(StaticJavaParser.parseStatement(statement));
		P_3.add(StaticJavaParser.parseStatement(statement2));
	}
}
