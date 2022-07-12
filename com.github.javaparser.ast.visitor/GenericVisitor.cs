using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;


namespace com.github.javaparser.ast.visitor;

public class GenericVisitor
{
		
	virtual object visit(ArrayCreationLevel n, object arg);

		
	virtual object visit(AnnotationDeclaration n, object arg);

		
	virtual object visit(AnnotationMemberDeclaration n, object arg);

		
	virtual object visit(ClassOrInterfaceDeclaration n, object arg);

		
	virtual object visit(CompactConstructorDeclaration n, object arg);

		
	virtual object visit(ConstructorDeclaration n, object arg);

		
	virtual object visit(EnumConstantDeclaration n, object arg);

		
	virtual object visit(EnumDeclaration n, object arg);

		
	virtual object visit(FieldDeclaration n, object arg);

		
	virtual object visit(InitializerDeclaration n, object arg);

		
	virtual object visit(MethodDeclaration n, object arg);

		
	virtual object visit(Parameter n, object arg);

		
	virtual object visit(ReceiverParameter n, object arg);

		
	virtual object visit(RecordDeclaration n, object arg);

		
	virtual object visit(VariableDeclarator n, object arg);

		
	virtual object visit(BlockComment n, object arg);

		
	virtual object visit(JavadocComment n, object arg);

		
	virtual object visit(LineComment n, object arg);

		
	virtual object visit(CompilationUnit n, object arg);

		
	virtual object visit(ArrayAccessExpr n, object arg);

		
	virtual object visit(ArrayCreationExpr n, object arg);

		
	virtual object visit(ArrayInitializerExpr n, object arg);

		
	virtual object visit(AssignExpr n, object arg);

		
	virtual object visit(BinaryExpr n, object arg);

		
	virtual object visit(BooleanLiteralExpr n, object arg);

		
	virtual object visit(CastExpr n, object arg);

		
	virtual object visit(CharLiteralExpr n, object arg);

		
	virtual object visit(ClassExpr n, object arg);

		
	virtual object visit(ConditionalExpr n, object arg);

		
	virtual object visit(DoubleLiteralExpr n, object arg);

		
	virtual object visit(EnclosedExpr n, object arg);

		
	virtual object visit(FieldAccessExpr n, object arg);

		
	virtual object visit(InstanceOfExpr n, object arg);

		
	virtual object visit(IntegerLiteralExpr n, object arg);

		
	virtual object visit(LambdaExpr n, object arg);

		
	virtual object visit(LongLiteralExpr n, object arg);

		
	virtual object visit(MarkerAnnotationExpr n, object arg);

		
	virtual object visit(MemberValuePair n, object arg);

		
	virtual object visit(MethodCallExpr n, object arg);

		
	virtual object visit(MethodReferenceExpr n, object arg);

		
	virtual object visit(Name n, object arg);

		
	virtual object visit(NameExpr n, object arg);

		
	virtual object visit(NormalAnnotationExpr n, object arg);

		
	virtual object visit(NullLiteralExpr n, object arg);

		
	virtual object visit(ObjectCreationExpr n, object arg);

		
	virtual object visit(PatternExpr n, object arg);

		
	virtual object visit(SimpleName n, object arg);

		
	virtual object visit(SingleMemberAnnotationExpr n, object arg);

		
	virtual object visit(StringLiteralExpr n, object arg);

		
	virtual object visit(SuperExpr n, object arg);

		
	virtual object visit(SwitchExpr n, object arg);

		
	virtual object visit(TextBlockLiteralExpr n, object arg);

		
	virtual object visit(ThisExpr n, object arg);

		
	virtual object visit(TypeExpr n, object arg);

		
	virtual object visit(UnaryExpr n, object arg);

		
	virtual object visit(VariableDeclarationExpr n, object arg);

		
	virtual object visit(ImportDeclaration n, object arg);

		
	virtual object visit(Modifier n, object arg);

		
	virtual object visit(ModuleDeclaration n, object arg);

		
	virtual object visit(ModuleExportsDirective n, object arg);

		
	virtual object visit(ModuleOpensDirective n, object arg);

		
	virtual object visit(ModuleProvidesDirective n, object arg);

		
	virtual object visit(ModuleRequiresDirective n, object arg);

		
	virtual object visit(ModuleUsesDirective n, object arg);

		
	virtual object visit(NodeList n, object arg);

		
	virtual object visit(PackageDeclaration n, object arg);

		
	virtual object visit(AssertStmt n, object arg);

		
	virtual object visit(BlockStmt n, object arg);

		
	virtual object visit(BreakStmt n, object arg);

		
	virtual object visit(CatchClause n, object arg);

		
	virtual object visit(ContinueStmt n, object arg);

		
	virtual object visit(DoStmt n, object arg);

		
	virtual object visit(EmptyStmt n, object arg);

		
	virtual object visit(ExplicitConstructorInvocationStmt n, object arg);

		
	virtual object visit(ExpressionStmt n, object arg);

		
	virtual object visit(ForEachStmt n, object arg);

		
	virtual object visit(ForStmt n, object arg);

		
	virtual object visit(IfStmt n, object arg);

		
	virtual object visit(LabeledStmt n, object arg);

		
	virtual object visit(LocalClassDeclarationStmt n, object arg);

		
	virtual object visit(LocalRecordDeclarationStmt n, object arg);

		
	virtual object visit(ReturnStmt n, object arg);

		
	virtual object visit(SwitchEntry n, object arg);

		
	virtual object visit(SwitchStmt n, object arg);

		
	virtual object visit(SynchronizedStmt n, object arg);

		
	virtual object visit(ThrowStmt n, object arg);

		
	virtual object visit(TryStmt n, object arg);

		
	virtual object visit(UnparsableStmt n, object arg);

		
	virtual object visit(WhileStmt n, object arg);

		
	virtual object visit(YieldStmt n, object arg);

		
	virtual object visit(ArrayType n, object arg);

		
	virtual object visit(ClassOrInterfaceType n, object arg);

		
	virtual object visit(IntersectionType n, object arg);

		
	virtual object visit(PrimitiveType n, object arg);

		
	virtual object visit(TypeParameter n, object arg);

		
	virtual object visit(UnionType n, object arg);

		
	virtual object visit(UnknownType n, object arg);

		
	virtual object visit(VarType n, object arg);

		
	virtual object visit(VoidType n, object arg);

		
	virtual object visit(WildcardType n, object arg);
}
