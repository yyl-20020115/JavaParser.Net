using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser;

public interface ParseStart
{
	
	private sealed class ___003C_003EAnon0 : ParseStart
	{
		internal ___003C_003EAnon0()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			CompilationUnit result = P_0.CompilationUnit();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon1 : ParseStart
	{
		internal ___003C_003EAnon1()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			BlockStmt result = P_0.BlockParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon2 : ParseStart
	{
		internal ___003C_003EAnon2()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			Statement result = P_0.BlockStatementParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon3 : ParseStart
	{
		internal ___003C_003EAnon3()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			ImportDeclaration result = P_0.ImportDeclarationParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon4 : ParseStart
	{
		internal ___003C_003EAnon4()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			Expression result = P_0.ExpressionParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon5 : ParseStart
	{
		internal ___003C_003EAnon5()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			AnnotationExpr result = P_0.AnnotationParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon6 : ParseStart
	{
		internal ___003C_003EAnon6()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			BodyDeclaration result = P_0.AnnotationBodyDeclarationParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon7 : ParseStart
	{
		internal ___003C_003EAnon7()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			BodyDeclaration result = P_0.ClassOrInterfaceBodyDeclarationParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon8 : ParseStart
	{
		internal ___003C_003EAnon8()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			ClassOrInterfaceType result = P_0.ClassOrInterfaceTypeParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon9 : ParseStart
	{
		internal ___003C_003EAnon9()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			Type result = P_0.ResultTypeParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon10 : ParseStart
	{
		internal ___003C_003EAnon10()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			TypeParameter result = P_0.TypeParameterParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon11 : ParseStart
	{
		internal ___003C_003EAnon11()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			VariableDeclarationExpr result = P_0.VariableDeclarationExpressionParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon12 : ParseStart
	{
		internal ___003C_003EAnon12()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			ExplicitConstructorInvocationStmt result = P_0.ExplicitConstructorInvocationParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon13 : ParseStart
	{
		internal ___003C_003EAnon13()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			Name result = P_0.NameParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon14 : ParseStart
	{
		internal ___003C_003EAnon14()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			SimpleName result = P_0.SimpleNameParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon15 : ParseStart
	{
		internal ___003C_003EAnon15()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			Parameter result = P_0.ParameterParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon16 : ParseStart
	{
		internal ___003C_003EAnon16()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			PackageDeclaration result = P_0.PackageDeclarationParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon17 : ParseStart
	{
		internal ___003C_003EAnon17()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			TypeDeclaration result = P_0.TypeDeclarationParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon18 : ParseStart
	{
		internal ___003C_003EAnon18()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			ModuleDeclaration result = P_0.ModuleDeclarationParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon19 : ParseStart
	{
		internal ___003C_003EAnon19()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			ModuleDirective result = P_0.ModuleDirectiveParseStart();
			
			return result;
		}
	}

	
	private sealed class ___003C_003EAnon20 : ParseStart
	{
		internal ___003C_003EAnon20()
		{
		}

		public object parse(GeneratedJavaParser P_0)
		{
			MethodDeclaration result = P_0.MethodDeclarationParseStart();
			
			return result;
		}
	}

	
	public static class __Fields
	{
		public static readonly ParseStart COMPILATION_UNIT;

		public static readonly ParseStart BLOCK;

		public static readonly ParseStart STATEMENT;

		public static readonly ParseStart IMPORT_DECLARATION;

		public static readonly ParseStart EXPRESSION;

		public static readonly ParseStart ANNOTATION;

		public static readonly ParseStart ANNOTATION_BODY;

		public static readonly ParseStart CLASS_BODY;

		public static readonly ParseStart CLASS_OR_INTERFACE_TYPE;

		public static readonly ParseStart TYPE;

		public static readonly ParseStart TYPE_PARAMETER;

		public static readonly ParseStart VARIABLE_DECLARATION_EXPR;

		public static readonly ParseStart EXPLICIT_CONSTRUCTOR_INVOCATION_STMT;

		public static readonly ParseStart NAME;

		public static readonly ParseStart SIMPLE_NAME;

		public static readonly ParseStart PARAMETER;

		public static readonly ParseStart PACKAGE_DECLARATION;

		public static readonly ParseStart TYPE_DECLARATION;

		public static readonly ParseStart MODULE_DECLARATION;

		public static readonly ParseStart MODULE_DIRECTIVE;

		public static readonly ParseStart METHOD_DECLARATION;

		static __Fields()
		{
			COMPILATION_UNIT = ParseStart.COMPILATION_UNIT;
			BLOCK = ParseStart.BLOCK;
			STATEMENT = ParseStart.STATEMENT;
			IMPORT_DECLARATION = ParseStart.IMPORT_DECLARATION;
			EXPRESSION = ParseStart.EXPRESSION;
			ANNOTATION = ParseStart.ANNOTATION;
			ANNOTATION_BODY = ParseStart.ANNOTATION_BODY;
			CLASS_BODY = ParseStart.CLASS_BODY;
			CLASS_OR_INTERFACE_TYPE = ParseStart.CLASS_OR_INTERFACE_TYPE;
			TYPE = ParseStart.TYPE;
			TYPE_PARAMETER = ParseStart.TYPE_PARAMETER;
			VARIABLE_DECLARATION_EXPR = ParseStart.VARIABLE_DECLARATION_EXPR;
			EXPLICIT_CONSTRUCTOR_INVOCATION_STMT = ParseStart.EXPLICIT_CONSTRUCTOR_INVOCATION_STMT;
			NAME = ParseStart.NAME;
			SIMPLE_NAME = ParseStart.SIMPLE_NAME;
			PARAMETER = ParseStart.PARAMETER;
			PACKAGE_DECLARATION = ParseStart.PACKAGE_DECLARATION;
			TYPE_DECLARATION = ParseStart.TYPE_DECLARATION;
			MODULE_DECLARATION = ParseStart.MODULE_DECLARATION;
			MODULE_DIRECTIVE = ParseStart.MODULE_DIRECTIVE;
			METHOD_DECLARATION = ParseStart.METHOD_DECLARATION;
		}
	}

		static readonly ParseStart COMPILATION_UNIT;

		static readonly ParseStart BLOCK;

		static readonly ParseStart STATEMENT;

		static readonly ParseStart IMPORT_DECLARATION;

		static readonly ParseStart EXPRESSION;

		static readonly ParseStart ANNOTATION;

		static readonly ParseStart ANNOTATION_BODY;

		static readonly ParseStart CLASS_BODY;

		static readonly ParseStart CLASS_OR_INTERFACE_TYPE;

		static readonly ParseStart TYPE;

		static readonly ParseStart TYPE_PARAMETER;

		static readonly ParseStart VARIABLE_DECLARATION_EXPR;

		static readonly ParseStart EXPLICIT_CONSTRUCTOR_INVOCATION_STMT;

		static readonly ParseStart NAME;

		static readonly ParseStart SIMPLE_NAME;

		static readonly ParseStart PARAMETER;

		static readonly ParseStart PACKAGE_DECLARATION;

		static readonly ParseStart TYPE_DECLARATION;

		static readonly ParseStart MODULE_DECLARATION;

		static readonly ParseStart MODULE_DIRECTIVE;

		static readonly ParseStart METHOD_DECLARATION;

	
	
	static void ___003Cclinit_003E()
	{
	}

	
		
	virtual object parse(GeneratedJavaParser parser);

	[LineNumberTable(new byte[]
	{
		2, 111, 111, 111, 111, 111, 111, 111, 111, 111,
		111, 111, 111, 111, 111, 111, 111, 111, 111, 111,
		111
	})]
	static ParseStart()
	{
		COMPILATION_UNIT = new ___003C_003EAnon0();
		BLOCK = new ___003C_003EAnon1();
		STATEMENT = new ___003C_003EAnon2();
		IMPORT_DECLARATION = new ___003C_003EAnon3();
		EXPRESSION = new ___003C_003EAnon4();
		ANNOTATION = new ___003C_003EAnon5();
		ANNOTATION_BODY = new ___003C_003EAnon6();
		CLASS_BODY = new ___003C_003EAnon7();
		CLASS_OR_INTERFACE_TYPE = new ___003C_003EAnon8();
		TYPE = new ___003C_003EAnon9();
		TYPE_PARAMETER = new ___003C_003EAnon10();
		VARIABLE_DECLARATION_EXPR = new ___003C_003EAnon11();
		EXPLICIT_CONSTRUCTOR_INVOCATION_STMT = new ___003C_003EAnon12();
		NAME = new ___003C_003EAnon13();
		SIMPLE_NAME = new ___003C_003EAnon14();
		PARAMETER = new ___003C_003EAnon15();
		PACKAGE_DECLARATION = new ___003C_003EAnon16();
		TYPE_DECLARATION = new ___003C_003EAnon17();
		MODULE_DECLARATION = new ___003C_003EAnon18();
		MODULE_DIRECTIVE = new ___003C_003EAnon19();
		METHOD_DECLARATION = new ___003C_003EAnon20();
	}
}
