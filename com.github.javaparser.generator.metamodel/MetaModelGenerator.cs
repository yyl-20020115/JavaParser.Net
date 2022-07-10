using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.printer;
using com.github.javaparser.printer.configuration;
using com.github.javaparser.utils;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.lang.reflect;
using java.nio.file;
using java.util;
using java.util.function;

namespace com.github.javaparser.generator.metamodel;

public class MetaModelGenerator : AbstractGenerator
{
	[Serializable]
	
		
	internal sealed class _1 : ArrayList
	{
		
		
		public new static void ___003Cclinit_003E()
		{
		}

		
		[LineNumberTable(new byte[]
		{
			9, 232, 72, 140, 108, 108, 108, 108, 140, 108,
			108, 140, 108, 108, 140, 108, 172, 108, 108, 108,
			108, 172, 108, 108, 108, 108, 108, 108, 108, 108,
			108, 108, 108, 108, 108, 140, 108, 108, 108, 140,
			108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
			108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
			108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
			108, 108, 108, 108, 108, 140, 108, 108, 108, 108,
			108, 108, 108, 108, 108, 108, 108, 108, 108, 108,
			108, 108, 108, 108, 108, 108, 108, 108, 108, 140,
			108, 108, 108, 108, 108, 108, 108, 108, 108, 140,
			108, 108, 108, 108, 108
		})]
		internal _1()
		{
			add(ClassLiteral<Node>.Value);
			add(ClassLiteral<BodyDeclaration>.Value);
			add(ClassLiteral<CallableDeclaration>.Value);
			add(ClassLiteral<Expression>.Value);
			add(ClassLiteral<Statement>.Value);
			add(ClassLiteral<com.github.javaparser.ast.type.Type>.Value);
			add(ClassLiteral<AnnotationExpr>.Value);
			add(ClassLiteral<ReferenceType>.Value);
			add(ClassLiteral<TypeDeclaration>.Value);
			add(ClassLiteral<LiteralExpr>.Value);
			add(ClassLiteral<LiteralStringValueExpr>.Value);
			add(ClassLiteral<StringLiteralExpr>.Value);
			add(ClassLiteral<ModuleDeclaration>.Value);
			add(ClassLiteral<ModuleDirective>.Value);
			add(ClassLiteral<ArrayCreationLevel>.Value);
			add(ClassLiteral<CompilationUnit>.Value);
			add(ClassLiteral<ImportDeclaration>.Value);
			add(ClassLiteral<com.github.javaparser.ast.Modifier>.Value);
			add(ClassLiteral<PackageDeclaration>.Value);
			add(ClassLiteral<AnnotationDeclaration>.Value);
			add(ClassLiteral<AnnotationMemberDeclaration>.Value);
			add(ClassLiteral<ClassOrInterfaceDeclaration>.Value);
			add(ClassLiteral<ConstructorDeclaration>.Value);
			add(ClassLiteral<EnumConstantDeclaration>.Value);
			add(ClassLiteral<EnumDeclaration>.Value);
			add(ClassLiteral<FieldDeclaration>.Value);
			add(ClassLiteral<InitializerDeclaration>.Value);
			add(ClassLiteral<MethodDeclaration>.Value);
			add(ClassLiteral<com.github.javaparser.ast.body.Parameter>.Value);
			add(ClassLiteral<ReceiverParameter>.Value);
			add(ClassLiteral<RecordDeclaration>.Value);
			add(ClassLiteral<CompactConstructorDeclaration>.Value);
			add(ClassLiteral<VariableDeclarator>.Value);
			add(ClassLiteral<Comment>.Value);
			add(ClassLiteral<BlockComment>.Value);
			add(ClassLiteral<JavadocComment>.Value);
			add(ClassLiteral<LineComment>.Value);
			add(ClassLiteral<ArrayAccessExpr>.Value);
			add(ClassLiteral<ArrayCreationExpr>.Value);
			add(ClassLiteral<ArrayInitializerExpr>.Value);
			add(ClassLiteral<AssignExpr>.Value);
			add(ClassLiteral<BinaryExpr>.Value);
			add(ClassLiteral<BooleanLiteralExpr>.Value);
			add(ClassLiteral<CastExpr>.Value);
			add(ClassLiteral<CharLiteralExpr>.Value);
			add(ClassLiteral<ClassExpr>.Value);
			add(ClassLiteral<ConditionalExpr>.Value);
			add(ClassLiteral<DoubleLiteralExpr>.Value);
			add(ClassLiteral<EnclosedExpr>.Value);
			add(ClassLiteral<FieldAccessExpr>.Value);
			add(ClassLiteral<InstanceOfExpr>.Value);
			add(ClassLiteral<IntegerLiteralExpr>.Value);
			add(ClassLiteral<LambdaExpr>.Value);
			add(ClassLiteral<LongLiteralExpr>.Value);
			add(ClassLiteral<MarkerAnnotationExpr>.Value);
			add(ClassLiteral<MemberValuePair>.Value);
			add(ClassLiteral<MethodCallExpr>.Value);
			add(ClassLiteral<MethodReferenceExpr>.Value);
			add(ClassLiteral<NameExpr>.Value);
			add(ClassLiteral<Name>.Value);
			add(ClassLiteral<NormalAnnotationExpr>.Value);
			add(ClassLiteral<NullLiteralExpr>.Value);
			add(ClassLiteral<ObjectCreationExpr>.Value);
			add(ClassLiteral<PatternExpr>.Value);
			add(ClassLiteral<SingleMemberAnnotationExpr>.Value);
			add(ClassLiteral<SimpleName>.Value);
			add(ClassLiteral<SuperExpr>.Value);
			add(ClassLiteral<SwitchExpr>.Value);
			add(ClassLiteral<TextBlockLiteralExpr>.Value);
			add(ClassLiteral<ThisExpr>.Value);
			add(ClassLiteral<TypeExpr>.Value);
			add(ClassLiteral<UnaryExpr>.Value);
			add(ClassLiteral<VariableDeclarationExpr>.Value);
			add(ClassLiteral<AssertStmt>.Value);
			add(ClassLiteral<BlockStmt>.Value);
			add(ClassLiteral<BreakStmt>.Value);
			add(ClassLiteral<CatchClause>.Value);
			add(ClassLiteral<ContinueStmt>.Value);
			add(ClassLiteral<DoStmt>.Value);
			add(ClassLiteral<EmptyStmt>.Value);
			add(ClassLiteral<ExplicitConstructorInvocationStmt>.Value);
			add(ClassLiteral<ExpressionStmt>.Value);
			add(ClassLiteral<ForEachStmt>.Value);
			add(ClassLiteral<ForStmt>.Value);
			add(ClassLiteral<IfStmt>.Value);
			add(ClassLiteral<LabeledStmt>.Value);
			add(ClassLiteral<LocalClassDeclarationStmt>.Value);
			add(ClassLiteral<LocalRecordDeclarationStmt>.Value);
			add(ClassLiteral<ReturnStmt>.Value);
			add(ClassLiteral<SwitchEntry>.Value);
			add(ClassLiteral<SwitchStmt>.Value);
			add(ClassLiteral<SynchronizedStmt>.Value);
			add(ClassLiteral<ThrowStmt>.Value);
			add(ClassLiteral<TryStmt>.Value);
			add(ClassLiteral<UnparsableStmt>.Value);
			add(ClassLiteral<WhileStmt>.Value);
			add(ClassLiteral<YieldStmt>.Value);
			add(ClassLiteral<ArrayType>.Value);
			add(ClassLiteral<ClassOrInterfaceType>.Value);
			add(ClassLiteral<IntersectionType>.Value);
			add(ClassLiteral<PrimitiveType>.Value);
			add(ClassLiteral<TypeParameter>.Value);
			add(ClassLiteral<UnionType>.Value);
			add(ClassLiteral<UnknownType>.Value);
			add(ClassLiteral<VarType>.Value);
			add(ClassLiteral<VoidType>.Value);
			add(ClassLiteral<com.github.javaparser.ast.type.WildcardType>.Value);
			add(ClassLiteral<ModuleExportsDirective>.Value);
			add(ClassLiteral<ModuleOpensDirective>.Value);
			add(ClassLiteral<ModuleProvidesDirective>.Value);
			add(ClassLiteral<ModuleRequiresDirective>.Value);
			add(ClassLiteral<ModuleUsesDirective>.Value);
		}

		
		static _1()
		{
			
		}

		
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected _1(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly Printer arg_00241;

		internal ___003C_003EAnon0(Printer P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			string result = arg_00241.print((CompilationUnit)P_0);
			
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

	
	private sealed class ___003C_003EAnon1 : Predicate
	{
		internal ___003C_003EAnon1()
		{
		}

		public bool test(object P_0)
		{
			bool result = lambda_0024generateNodeMetaModels_00240((FieldDeclaration)P_0);
			
			return result;
		}

		
		public Predicate and(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eand(this, P_0);
		}

		
		public Predicate negate()
		{
			return Predicate._003Cdefault_003Enegate(this);
		}

		
		public Predicate or(Predicate P_0)
		{
			return Predicate._003Cdefault_003Eor(this, P_0);
		}
	}

	
	private sealed class ___003C_003EAnon2 : Consumer
	{
		internal ___003C_003EAnon2()
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

	
	private sealed class ___003C_003EAnon3 : Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			string result = ((Statement)P_0).ToString();
			
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

	internal const string BASE_NODE_META_MODEL = "BaseNodeMetaModel";

	internal const string METAMODEL_PACKAGE = "com.github.javaparser.metamodel";

	
		private static List ALL_NODE_CLASSES;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		
	internal static string nodeMetaModelFieldName(Class P_0)
	{
		string result = Utils.decapitalize(nodeMetaModelName(P_0));
		
		return result;
	}

	
	
	internal static string propertyMetaModelFieldName(Field P_0)
	{
		string result = new StringBuilder().append(P_0.getName()).append("PropertyMetaModel").ToString();
		
		return result;
	}

	
		
	internal static string nodeMetaModelName(Class P_0)
	{
		string result = new StringBuilder().append(P_0.getSimpleName()).append("MetaModel").ToString();
		
		return result;
	}

	
		
	internal static bool isNode(Class P_0)
	{
		bool result = ClassLiteral<Node>.Value.isAssignableFrom(P_0);
		
		return result;
	}

	
	
	public MetaModelGenerator(SourceRoot sourceRoot)
		: base(sourceRoot)
	{
	}

	
	
	
	public virtual void generate()
	{
		CompilationUnit compilationUnit = ___003C_003EsourceRoot.parse("com.github.javaparser.metamodel", "JavaParserMetaModel.java");
		compilationUnit.setBlockComment("\n * Copyright (C) 2007-2010 Júlio Vilmar Gesser.\n * Copyright (C) 2011, 2013-2021 The JavaParser Team.\n *\n * This file is part of JavaParser.\n *\n * JavaParser can be used either under the terms of\n * a) the GNU Lesser General Public License as published by\n *     the Free Software Foundation, either version 3 of the License, or\n *     (at your option) any later version.\n * b) the terms of the Apache License\n *\n * You should have received a copy of both licenses in LICENCE.LGPL and\n * LICENCE.APACHE. Please refer to those files for details.\n *\n * JavaParser is distributed in the hope that it will be useful,\n * but WITHOUT ANY WARRANTY; without even the implied warranty of\n * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the\n * GNU Lesser General Public License for more details.\n ");
		generateNodeMetaModels(compilationUnit, ___003C_003EsourceRoot);
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 111, 182, 119, 119, 183, 103, 103, 167, 119,
		119, 119, 103, 103, 167, 117, 111, 165, 104, 127,
		4, 241, 72, 162, 120
	})]
	private void generateNodeMetaModels(CompilationUnit P_0, SourceRoot P_1)
	{
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)P_0.getClassByName("JavaParserMetaModel").get();
		MethodDeclaration methodDeclaration = (MethodDeclaration)classOrInterfaceDeclaration.getMethodsByName("initializeNodeMetaModels").get(0);
		MethodDeclaration methodDeclaration2 = (MethodDeclaration)classOrInterfaceDeclaration.getMethodsByName("initializePropertyMetaModels").get(0);
		MethodDeclaration methodDeclaration3 = (MethodDeclaration)classOrInterfaceDeclaration.getMethodsByName("initializeConstructorParameters").get(0);
		annotateGenerated(methodDeclaration);
		annotateGenerated(methodDeclaration2);
		annotateGenerated(methodDeclaration3);
		NodeList statements = ((BlockStmt)methodDeclaration.getBody().get()).getStatements();
		NodeList statements2 = ((BlockStmt)methodDeclaration2.getBody().get()).getStatements();
		NodeList statements3 = ((BlockStmt)methodDeclaration3.getBody().get()).getStatements();
		statements.clear();
		statements2.clear();
		statements3.clear();
		classOrInterfaceDeclaration.getFields().stream().filter(new ___003C_003EAnon1())
			.forEach(new ___003C_003EAnon2());
		NodeMetaModelGenerator nodeMetaModelGenerator = new NodeMetaModelGenerator(P_1);
		Iterator iterator = ALL_NODE_CLASSES.iterator();
		while (iterator.hasNext())
		{
			Class nodeClass = (Class)iterator.next();
			nodeMetaModelGenerator.generate(nodeClass, classOrInterfaceDeclaration, statements, statements2, statements3, P_1);
		}
		statements.sort(Comparator.comparing(new ___003C_003EAnon3()));
	}

	
	
	
	private static bool lambda_0024generateNodeMetaModels_00240(FieldDeclaration P_0)
	{
		bool result = java.lang.String.instancehelper_endsWith(P_0.getVariable(0).getNameAsString(), "MetaModel");
		
		return result;
	}

	
	
	[LineNumberTable(new byte[]
	{
		160, 85, 101, 144, 127, 24, 106, 102, 102, 104,
		122, 104, 125, 134, 139, 103
	})]
	public unsafe static void main(string[] args)
	{
		if ((nint)args.LongLength != 1)
		{
			
			throw new RuntimeException("Need 1 parameter: the JavaParser source checkout root directory.");
		}
		Path root = Paths.get(args[0], "..", "javaparser-core", "src", "main", "java");
		ParserConfiguration parserConfiguration = new ParserConfiguration().setLanguageLevel(ParserConfiguration.LanguageLevel.RAW).setStoreTokens(storeTokens: false);
		SourceRoot sourceRoot = new SourceRoot(root, parserConfiguration);
		PrinterConfiguration configuration = new DefaultPrinterConfiguration().addOption(new DefaultConfigurationOption(DefaultPrinterConfiguration.ConfigOption.___003C_003EEND_OF_LINE_CHARACTER, "\n"));
		DefaultPrettyPrinter defaultPrettyPrinter = new DefaultPrettyPrinter(configuration);
		
		sourceRoot.setPrinter(new ___003C_003EAnon0(defaultPrettyPrinter));
		StaticJavaParser.setConfiguration(parserConfiguration);
		new MetaModelGenerator(sourceRoot).generate();
		sourceRoot.saveAll();
	}

	
	static MetaModelGenerator()
	{
		ALL_NODE_CLASSES = new _1();
	}
}
