
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;

using java.lang;

namespace com.github.javaparser.ast.visitor;

public abstract class GenericVisitorWithDefaults : GenericVisitor
{
		
	public virtual object defaultAction(Node n, object arg)
	{
		return null;
	}

		
	public virtual object defaultAction(NodeList n, object arg)
	{
		return null;
	}

	
	
	public GenericVisitorWithDefaults()
	{
	}

	
		
	
	public virtual object visit(AnnotationDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(AnnotationMemberDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ArrayAccessExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ArrayCreationExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ArrayInitializerExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(AssertStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(AssignExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(BinaryExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(BlockStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(BooleanLiteralExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(BreakStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(CastExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(CatchClause n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(CharLiteralExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ClassExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ClassOrInterfaceDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ClassOrInterfaceType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(CompilationUnit n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ConditionalExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ConstructorDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ContinueStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(DoStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(DoubleLiteralExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(EmptyStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(EnclosedExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(EnumConstantDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(EnumDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ExpressionStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(FieldAccessExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(FieldDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ForEachStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ForStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(IfStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(InitializerDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(InstanceOfExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(IntegerLiteralExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(JavadocComment n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(LabeledStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(LongLiteralExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(MarkerAnnotationExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(MemberValuePair n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(MethodCallExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(MethodDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(NameExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(NormalAnnotationExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(NullLiteralExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ObjectCreationExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(PackageDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(Parameter n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(PrimitiveType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(Name n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(SimpleName n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ArrayType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ArrayCreationLevel n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(IntersectionType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(UnionType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ReturnStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(SingleMemberAnnotationExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(StringLiteralExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(SuperExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(SwitchEntry n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(SwitchStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(SynchronizedStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ThisExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ThrowStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(TryStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(LocalClassDeclarationStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(LocalRecordDeclarationStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(TypeParameter n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(UnaryExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(UnknownType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(VariableDeclarationExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(VariableDeclarator n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(VoidType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(WhileStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(WildcardType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(LambdaExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(MethodReferenceExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(TypeExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ImportDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(BlockComment n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(LineComment n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(NodeList n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ModuleDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ModuleRequiresDirective n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ModuleExportsDirective n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ModuleProvidesDirective n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ModuleUsesDirective n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ModuleOpensDirective n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(UnparsableStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(ReceiverParameter n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(VarType n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(Modifier n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(SwitchExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(YieldStmt n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(TextBlockLiteralExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(PatternExpr n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(RecordDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}

	
		
	
	public virtual object visit(CompactConstructorDeclaration n, object arg)
	{
		object result = defaultAction(n, arg);
		
		return result;
	}
}
