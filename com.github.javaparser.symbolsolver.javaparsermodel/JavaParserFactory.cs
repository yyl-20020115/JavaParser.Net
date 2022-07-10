using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparser;
using com.github.javaparser.symbolsolver.javaparsermodel.contexts;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.javaparsermodel.declarators;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.resolution;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.symbolsolver.javaparsermodel;

public class JavaParserFactory
{
	
	[LineNumberTable(new byte[]
	{
		5, 99, 208, 104, 111, 104, 111, 104, 111, 104,
		111, 104, 111, 104, 111, 104, 111, 104, 111, 104,
		111, 104, 111, 104, 111, 104, 111, 104, 111, 104,
		111, 104, 111, 104, 111, 104, 111, 104, 111, 104,
		111, 104, 111, 104, 111, 104, 111, 104, 111, 104,
		111, 104, 111, 110, 108, 111, 104, 143, 171, 127,
		0, 113, 109, 113, 104, 162, 138, 127, 28, 191,
		9, 103, 112, 103, 111, 173, 170
	})]
	public static Context getContext(Node node, TypeSolver typeSolver)
	{
		if (node == null)
		{
			
			throw new NullPointerException("Node should not be null");
		}
		if (node is ArrayAccessExpr)
		{
			ArrayAccessExprContext result = new ArrayAccessExprContext((ArrayAccessExpr)node, typeSolver);
			
			return result;
		}
		if (node is AnnotationDeclaration)
		{
			AnnotationDeclarationContext result2 = new AnnotationDeclarationContext((AnnotationDeclaration)node, typeSolver);
			
			return result2;
		}
		if (node is BinaryExpr)
		{
			BinaryExprContext result3 = new BinaryExprContext((BinaryExpr)node, typeSolver);
			
			return result3;
		}
		if (node is BlockStmt)
		{
			BlockStmtContext result4 = new BlockStmtContext((BlockStmt)node, typeSolver);
			
			return result4;
		}
		if (node is CompilationUnit)
		{
			CompilationUnitContext result5 = new CompilationUnitContext((CompilationUnit)node, typeSolver);
			
			return result5;
		}
		if (node is EnclosedExpr)
		{
			EnclosedExprContext result6 = new EnclosedExprContext((EnclosedExpr)node, typeSolver);
			
			return result6;
		}
		if (node is ForEachStmt)
		{
			ForEachStatementContext result7 = new ForEachStatementContext((ForEachStmt)node, typeSolver);
			
			return result7;
		}
		if (node is ForStmt)
		{
			ForStatementContext result8 = new ForStatementContext((ForStmt)node, typeSolver);
			
			return result8;
		}
		if (node is IfStmt)
		{
			IfStatementContext result9 = new IfStatementContext((IfStmt)node, typeSolver);
			
			return result9;
		}
		if (node is InstanceOfExpr)
		{
			InstanceOfExprContext result10 = new InstanceOfExprContext((InstanceOfExpr)node, typeSolver);
			
			return result10;
		}
		if (node is LambdaExpr)
		{
			LambdaExprContext result11 = new LambdaExprContext((LambdaExpr)node, typeSolver);
			
			return result11;
		}
		if (node is MethodDeclaration)
		{
			MethodContext result12 = new MethodContext((MethodDeclaration)node, typeSolver);
			
			return result12;
		}
		if (node is ConstructorDeclaration)
		{
			ConstructorContext result13 = new ConstructorContext((ConstructorDeclaration)node, typeSolver);
			
			return result13;
		}
		if (node is ClassOrInterfaceDeclaration)
		{
			ClassOrInterfaceDeclarationContext result14 = new ClassOrInterfaceDeclarationContext((ClassOrInterfaceDeclaration)node, typeSolver);
			
			return result14;
		}
		if (node is MethodCallExpr)
		{
			MethodCallExprContext result15 = new MethodCallExprContext((MethodCallExpr)node, typeSolver);
			
			return result15;
		}
		if (node is MethodReferenceExpr)
		{
			MethodReferenceExprContext result16 = new MethodReferenceExprContext((MethodReferenceExpr)node, typeSolver);
			
			return result16;
		}
		if (node is EnumDeclaration)
		{
			EnumDeclarationContext result17 = new EnumDeclarationContext((EnumDeclaration)node, typeSolver);
			
			return result17;
		}
		if (node is FieldAccessExpr)
		{
			FieldAccessContext result18 = new FieldAccessContext((FieldAccessExpr)node, typeSolver);
			
			return result18;
		}
		if (node is SwitchEntry)
		{
			SwitchEntryContext result19 = new SwitchEntryContext((SwitchEntry)node, typeSolver);
			
			return result19;
		}
		if (node is TryStmt)
		{
			TryWithResourceContext result20 = new TryWithResourceContext((TryStmt)node, typeSolver);
			
			return result20;
		}
		if (node is Statement)
		{
			StatementContext result21 = new StatementContext((Statement)node, typeSolver);
			
			return result21;
		}
		if (node is CatchClause)
		{
			CatchClauseContext result22 = new CatchClauseContext((CatchClause)node, typeSolver);
			
			return result22;
		}
		if (node is UnaryExpr)
		{
			UnaryExprContext result23 = new UnaryExprContext((UnaryExpr)node, typeSolver);
			
			return result23;
		}
		if (node is VariableDeclarator)
		{
			VariableDeclaratorContext result24 = new VariableDeclaratorContext((VariableDeclarator)node, typeSolver);
			
			return result24;
		}
		if (node is VariableDeclarationExpr)
		{
			VariableDeclarationExprContext result25 = new VariableDeclarationExprContext((VariableDeclarationExpr)node, typeSolver);
			
			return result25;
		}
		if (node is ObjectCreationExpr && ((ObjectCreationExpr)node).getAnonymousClassBody().isPresent())
		{
			AnonymousClassDeclarationContext result26 = new AnonymousClassDeclarationContext((ObjectCreationExpr)node, typeSolver);
			
			return result26;
		}
		if (node is ObjectCreationExpr)
		{
			ObjectCreationContext result27 = new ObjectCreationContext((ObjectCreationExpr)node, typeSolver);
			
			return result27;
		}
		Node node2;
		if (node is NameExpr)
		{
			if (node.getParentNode().isPresent() && node.getParentNode().get() is FieldAccessExpr)
			{
				node2 = (Node)node.getParentNode().get();
				while (node2.getParentNode().isPresent())
				{
					node2 = (Node)node2.getParentNode().get();
					if (!(node2 is FieldAccessExpr))
					{
						break;
					}
				}
				Context context = getContext(node2, typeSolver);
				
				return context;
			}
			if (node.getParentNode().isPresent() && node.getParentNode().get() is ObjectCreationExpr && ((Node)node.getParentNode().get()).getParentNode().isPresent())
			{
				Context context2 = getContext((Node)((Node)node.getParentNode().get()).getParentNode().get(), typeSolver);
				
				return context2;
			}
		}
		node2 = Navigator.demandParentNode(node);
		if (node is ClassOrInterfaceType && node2 is ClassOrInterfaceDeclaration)
		{
			ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)node2;
			if (classOrInterfaceDeclaration.getImplementedTypes().contains((object)node) || classOrInterfaceDeclaration.getExtendedTypes().contains((object)node))
			{
				ClassOrInterfaceDeclarationExtendsContext result28 = new ClassOrInterfaceDeclarationExtendsContext(classOrInterfaceDeclaration, typeSolver);
				
				return result28;
			}
		}
		Context context3 = getContext(node2, typeSolver);
		
		return context3;
	}

	
	[LineNumberTable(new byte[]
	{
		98, 104, 143, 104, 143, 104, 143, 104, 103, 109,
		185, 138, 104, 103, 143
	})]
	public static SymbolDeclarator getSymbolDeclarator(Node node, TypeSolver typeSolver)
	{
		if (node is FieldDeclaration)
		{
			FieldSymbolDeclarator result = new FieldSymbolDeclarator((FieldDeclaration)node, typeSolver);
			
			return result;
		}
		if (node is Parameter)
		{
			ParameterSymbolDeclarator result2 = new ParameterSymbolDeclarator((Parameter)node, typeSolver);
			
			return result2;
		}
		if (node is PatternExpr)
		{
			PatternSymbolDeclarator result3 = new PatternSymbolDeclarator((PatternExpr)node, typeSolver);
			
			return result3;
		}
		if (node is ExpressionStmt)
		{
			ExpressionStmt expressionStmt = (ExpressionStmt)node;
			if (expressionStmt.getExpression() is VariableDeclarationExpr)
			{
				VariableSymbolDeclarator result4 = new VariableSymbolDeclarator((VariableDeclarationExpr)expressionStmt.getExpression(), typeSolver);
				
				return result4;
			}
			NoSymbolDeclarator result5 = new NoSymbolDeclarator(expressionStmt, typeSolver);
			
			return result5;
		}
		if (node is ForEachStmt)
		{
			ForEachStmt forEachStmt = (ForEachStmt)node;
			VariableSymbolDeclarator result6 = new VariableSymbolDeclarator(forEachStmt.getVariable(), typeSolver);
			
			return result6;
		}
		NoSymbolDeclarator result7 = new NoSymbolDeclarator(node, typeSolver);
		
		return result7;
	}

	
	[LineNumberTable(new byte[]
	{
		123, 104, 109, 143, 143, 104, 143, 104, 148, 104,
		143, 104, 158
	})]
	public static ResolvedReferenceTypeDeclaration toTypeDeclaration(Node node, TypeSolver typeSolver)
	{
		if (node is ClassOrInterfaceDeclaration)
		{
			if (((ClassOrInterfaceDeclaration)node).isInterface())
			{
				JavaParserInterfaceDeclaration result = new JavaParserInterfaceDeclaration((ClassOrInterfaceDeclaration)node, typeSolver);
				
				return result;
			}
			JavaParserClassDeclaration result2 = new JavaParserClassDeclaration((ClassOrInterfaceDeclaration)node, typeSolver);
			
			return result2;
		}
		if (node is TypeParameter)
		{
			JavaParserTypeParameter result3 = new JavaParserTypeParameter((TypeParameter)node, typeSolver);
			
			return result3;
		}
		if (node is EnumDeclaration)
		{
			JavaParserEnumDeclaration.___003Cclinit_003E();
			JavaParserEnumDeclaration result4 = new JavaParserEnumDeclaration((EnumDeclaration)node, typeSolver);
			
			return result4;
		}
		if (node is AnnotationDeclaration)
		{
			JavaParserAnnotationDeclaration result5 = new JavaParserAnnotationDeclaration((AnnotationDeclaration)node, typeSolver);
			
			return result5;
		}
		if (node is EnumConstantDeclaration)
		{
			JavaParserEnumDeclaration.___003Cclinit_003E();
			JavaParserEnumDeclaration result6 = new JavaParserEnumDeclaration((EnumDeclaration)Navigator.demandParentNode((EnumConstantDeclaration)node), typeSolver);
			
			return result6;
		}
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new IllegalArgumentException(canonicalName);
	}

	
	
	public JavaParserFactory()
	{
	}
}
