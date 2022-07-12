using System;

using com.github.javaparser.ast;
using com.github.javaparser.utils;

using IKVM.Runtime;
using java.io;
using java.lang;
using java.nio.charset;
using java.nio.file;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.github.javaparser;

public class JavaParser
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Processor result = (Processor)((Supplier)P_0).get();
			
			return result;
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

	
	private sealed class ___003C_003EAnon1 : Consumer
	{
		private readonly File arg_00241;

		private readonly Charset arg_00242;

		internal ___003C_003EAnon1(File P_0, Charset P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024parse_00240(arg_00241, arg_00242, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		private readonly JavaParser arg_00241;

		private readonly File arg_00242;

		internal ___003C_003EAnon2(JavaParser P_0, File P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024parse_00241(arg_00242, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon3 : Consumer
	{
		private readonly Path arg_00241;

		private readonly Charset arg_00242;

		internal ___003C_003EAnon3(Path P_0, Charset P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			lambda_0024parse_00242(arg_00241, arg_00242, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon4 : Consumer
	{
		private readonly JavaParser arg_00241;

		private readonly Path arg_00242;

		internal ___003C_003EAnon4(JavaParser P_0, Path P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0)
		{
			arg_00241.lambda_0024parse_00243(arg_00242, (CompilationUnit)P_0);
			
		}

		
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	
	private ParserConfiguration configuration;

	private GeneratedJavaParser astParser;

	
		
	
	public virtual ParseResult parse(ParseStart start, Provider provider)
	{
		Utils.assertNotNull(start);
		Utils.assertNotNull(provider);
		List list = (List)configuration.getProcessors().stream().map(new ___003C_003EAnon0())
			.collect(Collectors.toList());
		Iterator iterator = list.iterator();
		while (iterator.hasNext())
		{
			Processor processor = (Processor)iterator.next();
			provider = processor.preProcess(provider);
		}
		GeneratedJavaParser parserForProvider = getParserForProvider(provider);
		System.Exception ex2;
		ParseResult result2;
		try
		{
			try
			{
				Node result = (Node)start.parse(parserForProvider);
				ParseResult parseResult = new ParseResult(result, parserForProvider.problems, parserForProvider.getCommentsCollection());
				Iterator iterator2 = list.iterator();
				while (iterator2.hasNext())
				{
					Processor processor2 = (Processor)iterator2.next();
					processor2.postProcess(parseResult, configuration);
				}
				parseResult.getProblems().sort(Problem.PROBLEM_BY_BEGIN_POSITION);
				result2 = parseResult;
			}
			catch (System.Exception x)
			{
				System.Exception ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
				if (ex == null)
				{
					throw;
				}
				ex2 = ex;
				goto IL_00fd;
			}
		}
		catch
		{
			//try-fault
			try
			{
				provider.close();
			}
			catch (IOException)
			{
				goto IL_00f4;
			}
			goto end_IL_00e6;
			IL_00f4:
			
			end_IL_00e6:
			throw;
		}
		try
		{
			provider.close();
			return result2;
		}
		catch (IOException)
		{
		}
		
		return result2;
		IL_00fd:
		System.Exception ex5 = ex2;
		try
		{
			System.Exception ex6 = ex5;
			string message = ((Throwable.instancehelper_getMessage(ex6) != null) ? Throwable.instancehelper_getMessage(ex6) : "Unknown error");
			parserForProvider.problems.add(new Problem(message, null, ex6));
			result2 = new ParseResult(null, parserForProvider.problems, parserForProvider.getCommentsCollection());
		}
		catch
		{
			//try-fault
			try
			{
				provider.close();
			}
			catch (IOException)
			{
				goto IL_0173;
			}
			goto end_IL_0165;
			IL_0173:
			
			end_IL_0165:
			throw;
		}
		try
		{
			provider.close();
			return result2;
		}
		catch (IOException)
		{
		}
		
		return result2;
	}

	
	
	
	public JavaParser(ParserConfiguration configuration)
	{
		astParser = null;
		this.configuration = configuration;
	}

	
	
	
	private GeneratedJavaParser getParserForProvider(Provider provider)
	{
		if (astParser == null)
		{
			astParser = new GeneratedJavaParser(provider);
		}
		else
		{
			astParser.reset(provider);
		}
		astParser.setTabSize(configuration.getTabSize());
		astParser.setStoreTokens(configuration.isStoreTokens());
		ParserConfiguration.LanguageLevel languageLevel = configuration.getLanguageLevel();
		if (languageLevel != null && languageLevel.isYieldSupported())
		{
			astParser.setYieldSupported();
		}
		return astParser;
	}

	
		
	
	public virtual ParseResult parse(InputStream @in, Charset encoding)
	{
		ParseResult result = parse(ParseStart.COMPILATION_UNIT, Providers.provider(@in, encoding));
		
		return result;
	}

	
	
	
	
	private static void lambda_0024parse_00240(File file, Charset encoding, CompilationUnit cu)
	{
		cu.setStorage(file.toPath(), encoding);
	}

	
	
	
	
	private void lambda_0024parse_00241(File file, CompilationUnit cu)
	{
		cu.setStorage(file.toPath(), configuration.getCharacterEncoding());
	}

	
	
	
	
	private static void lambda_0024parse_00242(Path path, Charset encoding, CompilationUnit cu)
	{
		cu.setStorage(path, encoding);
	}

	
	
	
	
	private void lambda_0024parse_00243(Path path, CompilationUnit cu)
	{
		cu.setStorage(path, configuration.getCharacterEncoding());
	}

	
	
	public JavaParser()
		: this(new ParserConfiguration())
	{
	}

	public virtual ParserConfiguration getParserConfiguration()
	{
		return configuration;
	}

	
		
	
	public virtual ParseResult parse(InputStream @in)
	{
		ParseResult result = parse(@in, configuration.getCharacterEncoding());
		
		return result;
	}

	public virtual ParseResult parse(File file, Charset encoding)
	{
		ParseResult parseResult = parse(ParseStart.COMPILATION_UNIT, Providers.provider(file, encoding));
		parseResult.getResult().ifPresent(new ___003C_003EAnon1(file, encoding));
		return parseResult;
	}
		
	
	public virtual ParseResult parse(File file)
	{
		ParseResult parseResult = parse(ParseStart.COMPILATION_UNIT, Providers.provider(file, configuration.getCharacterEncoding()));
		parseResult.getResult().ifPresent(new ___003C_003EAnon2(this, file));
		return parseResult;
	}

	
	public virtual ParseResult parse(Path path, Charset encoding)
	{
		ParseResult parseResult = parse(ParseStart.COMPILATION_UNIT, Providers.provider(path, encoding));
		parseResult.getResult().ifPresent(new ___003C_003EAnon3(path, encoding));
		return parseResult;
	}
		
	
	public virtual ParseResult parse(Path path)
	{
		ParseResult parseResult = parse(ParseStart.COMPILATION_UNIT, Providers.provider(path, configuration.getCharacterEncoding()));
		parseResult.getResult().ifPresent(new ___003C_003EAnon4(this, path));
		return parseResult;
	}

	
	
		
	
	public virtual ParseResult parseResource(string path)
	{
		ParseResult result = parse(ParseStart.COMPILATION_UNIT, Providers.resourceProvider(path, configuration.getCharacterEncoding()));
		
		return result;
	}

	
	
	
		
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual ParseResult parseResource(string path, Charset encoding)
	{
		ParseResult result = parse(ParseStart.COMPILATION_UNIT, Providers.resourceProvider(path, encoding));
		
		return result;
	}

	
	
	
		
	
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual ParseResult parseResource(ClassLoader classLoader, string path, Charset encoding)
	{
		ParseResult result = parse(ParseStart.COMPILATION_UNIT, Providers.resourceProvider(classLoader, path, encoding));
		
		return result;
	}

	
		
	
	public virtual ParseResult parse(Reader reader)
	{
		ParseResult result = parse(ParseStart.COMPILATION_UNIT, Providers.provider(reader));
		
		return result;
	}

	
		
	
	public virtual ParseResult parse(string code)
	{
		ParseResult result = parse(ParseStart.COMPILATION_UNIT, Providers.provider(code));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseBlock(string blockStatement)
	{
		ParseResult result = parse(ParseStart.BLOCK, Providers.provider(blockStatement));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseStatement(string statement)
	{
		ParseResult result = parse(ParseStart.STATEMENT, Providers.provider(statement));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseImport(string importDeclaration)
	{
		ParseResult result = parse(ParseStart.IMPORT_DECLARATION, Providers.provider(importDeclaration));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseExpression(string expression)
	{
		ParseResult result = parse(ParseStart.EXPRESSION, Providers.provider(expression));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseAnnotation(string annotation)
	{
		ParseResult result = parse(ParseStart.ANNOTATION, Providers.provider(annotation));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseAnnotationBodyDeclaration(string body)
	{
		ParseResult result = parse(ParseStart.ANNOTATION_BODY, Providers.provider(body));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseBodyDeclaration(string body)
	{
		ParseResult result = parse(ParseStart.CLASS_BODY, Providers.provider(body));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseClassOrInterfaceType(string type)
	{
		ParseResult result = parse(ParseStart.CLASS_OR_INTERFACE_TYPE, Providers.provider(type));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseType(string type)
	{
		ParseResult result = parse(ParseStart.TYPE, Providers.provider(type));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseVariableDeclarationExpr(string declaration)
	{
		ParseResult result = parse(ParseStart.VARIABLE_DECLARATION_EXPR, Providers.provider(declaration));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseExplicitConstructorInvocationStmt(string statement)
	{
		ParseResult result = parse(ParseStart.EXPLICIT_CONSTRUCTOR_INVOCATION_STMT, Providers.provider(statement));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseName(string qualifiedName)
	{
		ParseResult result = parse(ParseStart.NAME, Providers.provider(qualifiedName));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseSimpleName(string name)
	{
		ParseResult result = parse(ParseStart.SIMPLE_NAME, Providers.provider(name));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseParameter(string parameter)
	{
		ParseResult result = parse(ParseStart.PARAMETER, Providers.provider(parameter));
		
		return result;
	}

	
		
	
	public virtual ParseResult parsePackageDeclaration(string packageDeclaration)
	{
		ParseResult result = parse(ParseStart.PACKAGE_DECLARATION, Providers.provider(packageDeclaration));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseTypeDeclaration(string typeDeclaration)
	{
		ParseResult result = parse(ParseStart.TYPE_DECLARATION, Providers.provider(typeDeclaration));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseModuleDeclaration(string moduleDeclaration)
	{
		ParseResult result = parse(ParseStart.MODULE_DECLARATION, Providers.provider(moduleDeclaration));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseModuleDirective(string moduleDirective)
	{
		ParseResult result = parse(ParseStart.MODULE_DIRECTIVE, Providers.provider(moduleDirective));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseTypeParameter(string typeParameter)
	{
		ParseResult result = parse(ParseStart.TYPE_PARAMETER, Providers.provider(typeParameter));
		
		return result;
	}

	
		
	
	public virtual ParseResult parseMethodDeclaration(string methodDeclaration)
	{
		ParseResult result = parse(ParseStart.METHOD_DECLARATION, Providers.provider(methodDeclaration));
		
		return result;
	}
}
