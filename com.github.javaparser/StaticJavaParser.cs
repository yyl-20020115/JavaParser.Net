using System;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.javadoc;
using IKVM.Attributes;
using java.io;
using java.lang;
using java.nio.charset;
using java.nio.file;
using java.util;
using java.util.function;

namespace com.github.javaparser;

public class StaticJavaParser
{
	
	private sealed class ___003C_003EAnon0 : Supplier
	{
		internal ___003C_003EAnon0()
		{
		}

		public object get()
		{
			ParserConfiguration result = lambda_0024static_00240();
			
			return result;
		}
	}

		private static ThreadLocal localConfiguration;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public static void setConfiguration(ParserConfiguration configuration)
	{
		localConfiguration.set(configuration);
	}

	
		
	
	public static BodyDeclaration parseBodyDeclaration(string body)
	{
		return (BodyDeclaration)handleResult(newParser().parseBodyDeclaration(body));
	}

	
	
	
	public static ExplicitConstructorInvocationStmt parseExplicitConstructorInvocationStmt(string statement)
	{
		return (ExplicitConstructorInvocationStmt)handleResult(newParser().parseExplicitConstructorInvocationStmt(statement));
	}

	
	
	
	public static com.github.javaparser.ast.type.Type parseType(string type)
	{
		return (com.github.javaparser.ast.type.Type)handleResult(newParser().parseType(type));
	}

	
	
	
	public static Statement parseStatement(string statement)
	{
		return (Statement)handleResult(newParser().parseStatement(statement));
	}

	
	
	
	public static Name parseName(string qualifiedName)
	{
		return (Name)handleResult(newParser().parseName(qualifiedName));
	}

	
		
	
	public static Expression parseExpression(string expression)
	{
		return (Expression)handleResult(newParser().parseExpression(expression));
	}

	
	
	
	public static ClassOrInterfaceType parseClassOrInterfaceType(string type)
	{
		return (ClassOrInterfaceType)handleResult(newParser().parseClassOrInterfaceType(type));
	}

	
	
	
	public static TypeParameter parseTypeParameter(string typeParameter)
	{
		return (TypeParameter)handleResult(newParser().parseTypeParameter(typeParameter));
	}

	
	
	
	public static Javadoc parseJavadoc(string content)
	{
		Javadoc result = JavadocParser.parse(content);
		
		return result;
	}

	
	
	
	public static ImportDeclaration parseImport(string importDeclaration)
	{
		return (ImportDeclaration)handleResult(newParser().parseImport(importDeclaration));
	}

	
	
	
	public static ModuleDirective parseModuleDirective(string moduleDirective)
	{
		return (ModuleDirective)handleResult(newParser().parseModuleDirective(moduleDirective));
	}

	
	
	public static ParserConfiguration getConfiguration()
	{
		return (ParserConfiguration)localConfiguration.get();
	}

	
	
	private static JavaParser newParser()
	{
		JavaParser result = new JavaParser(getConfiguration());
		
		return result;
	}

	
		
	
	private static Node handleResult(ParseResult result)
	{
		if (result.isSuccessful())
		{
			return (Node)result.getResult().get();
		}
		List problems = result.getProblems();
		
		throw new ParseProblemException(problems);
	}

	
	
	
	private static ParserConfiguration lambda_0024static_00240()
	{
		ParserConfiguration result = new ParserConfiguration();
		
		return result;
	}

	
	
	private StaticJavaParser()
	{
	}

	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		(Modifiers)0
	})]
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CompilationUnit parse(InputStream @in, Charset encoding)
	{
		return (CompilationUnit)handleResult(newParser().parse(@in, encoding));
	}

	
	
	
	public static CompilationUnit parse(InputStream @in)
	{
		return (CompilationUnit)handleResult(newParser().parse(@in));
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CompilationUnit parse(File file, Charset encoding)
	{
		return (CompilationUnit)handleResult(newParser().parse(file, encoding));
	}

	
	
	
	
	public static CompilationUnit parse(File file)
	{
		return (CompilationUnit)handleResult(newParser().parse(file));
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CompilationUnit parse(Path path, Charset encoding)
	{
		return (CompilationUnit)handleResult(newParser().parse(path, encoding));
	}

	
	
	
	
	public static CompilationUnit parse(Path path)
	{
		return (CompilationUnit)handleResult(newParser().parse(path));
	}

	
	
	
	
	public static CompilationUnit parseResource(string path)
	{
		return (CompilationUnit)handleResult(newParser().parseResource(path));
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		(Modifiers)0
	})]
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CompilationUnit parseResource(string path, Charset encoding)
	{
		return (CompilationUnit)handleResult(newParser().parseResource(path, encoding));
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final,
		(Modifiers)0
	})]
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static CompilationUnit parseResource(ClassLoader classLoader, string path, Charset encoding)
	{
		return (CompilationUnit)handleResult(newParser().parseResource(classLoader, path, encoding));
	}

	
	
	
	public static CompilationUnit parse(Reader reader)
	{
		return (CompilationUnit)handleResult(newParser().parse(reader));
	}

	
	
	
	public static CompilationUnit parse(string code)
	{
		return (CompilationUnit)handleResult(newParser().parse(code));
	}

	
	
	
	public static BlockStmt parseBlock(string blockStatement)
	{
		return (BlockStmt)handleResult(newParser().parseBlock(blockStatement));
	}

	
	
	
	public static AnnotationExpr parseAnnotation(string annotation)
	{
		return (AnnotationExpr)handleResult(newParser().parseAnnotation(annotation));
	}

	
		
	
	public static BodyDeclaration parseAnnotationBodyDeclaration(string body)
	{
		return (BodyDeclaration)handleResult(newParser().parseAnnotationBodyDeclaration(body));
	}

	
	
	
	public static VariableDeclarationExpr parseVariableDeclarationExpr(string declaration)
	{
		return (VariableDeclarationExpr)handleResult(newParser().parseVariableDeclarationExpr(declaration));
	}

	
	
	
	public static SimpleName parseSimpleName(string name)
	{
		return (SimpleName)handleResult(newParser().parseSimpleName(name));
	}

	
	
	
	public static Parameter parseParameter(string parameter)
	{
		return (Parameter)handleResult(newParser().parseParameter(parameter));
	}

	
	
	
	public static PackageDeclaration parsePackageDeclaration(string packageDeclaration)
	{
		return (PackageDeclaration)handleResult(newParser().parsePackageDeclaration(packageDeclaration));
	}

	
		
	
	public static TypeDeclaration parseTypeDeclaration(string typeDeclaration)
	{
		return (TypeDeclaration)handleResult(newParser().parseTypeDeclaration(typeDeclaration));
	}

	
	
	
	public static ModuleDeclaration parseModuleDeclaration(string moduleDeclaration)
	{
		return (ModuleDeclaration)handleResult(newParser().parseModuleDeclaration(moduleDeclaration));
	}

	
	
	
	public static MethodDeclaration parseMethodDeclaration(string methodDeclaration)
	{
		return (MethodDeclaration)handleResult(newParser().parseMethodDeclaration(methodDeclaration));
	}

	
	static StaticJavaParser()
	{
		localConfiguration = ThreadLocal.withInitial(new ___003C_003EAnon0());
	}
}
