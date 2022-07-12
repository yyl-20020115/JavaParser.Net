using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;


namespace com.github.javaparser.ast.visitor;

public interface VoidVisitor
{
		
	virtual void visit(ArrayCreationLevel n, object arg);

		
	virtual void visit(AnnotationDeclaration n, object arg);

		
	virtual void visit(AnnotationMemberDeclaration n, object arg);

		
	virtual void visit(ClassOrInterfaceDeclaration n, object arg);

		
	virtual void visit(CompactConstructorDeclaration n, object arg);

		
	virtual void visit(ConstructorDeclaration n, object arg);

		
	virtual void visit(EnumConstantDeclaration n, object arg);

		
	virtual void visit(EnumDeclaration n, object arg);

		
	virtual void visit(FieldDeclaration n, object arg);

		
	virtual void visit(InitializerDeclaration n, object arg);

		
	virtual void visit(MethodDeclaration n, object arg);

		
	virtual void visit(Parameter n, object arg);

		
	virtual void visit(ReceiverParameter n, object arg);

		
	virtual void visit(RecordDeclaration n, object arg);

		
	virtual void visit(VariableDeclarator n, object arg);

		
	virtual void visit(BlockComment n, object arg);

		
	virtual void visit(JavadocComment n, object arg);

		
	virtual void visit(LineComment n, object arg);

		
	virtual void visit(CompilationUnit n, object arg);

		
	virtual void visit(ArrayAccessExpr n, object arg);

		
	virtual void visit(ArrayCreationExpr n, object arg);

		
	virtual void visit(ArrayInitializerExpr n, object arg);

		
	virtual void visit(AssignExpr n, object arg);

		
	virtual void visit(BinaryExpr n, object arg);

		
	virtual void visit(BooleanLiteralExpr n, object arg);

		
	virtual void visit(CastExpr n, object arg);

		
	virtual void visit(CharLiteralExpr n, object arg);

		
	virtual void visit(ClassExpr n, object arg);

		
	virtual void visit(ConditionalExpr n, object arg);

		
	virtual void visit(DoubleLiteralExpr n, object arg);

		
	virtual void visit(EnclosedExpr n, object arg);

		
	virtual void visit(FieldAccessExpr n, object arg);

		
	virtual void visit(InstanceOfExpr n, object arg);

		
	virtual void visit(IntegerLiteralExpr n, object arg);

		
	virtual void visit(LambdaExpr n, object arg);

		
	virtual void visit(LongLiteralExpr n, object arg);

		
	virtual void visit(MarkerAnnotationExpr n, object arg);

		
	virtual void visit(MemberValuePair n, object arg);

		
	virtual void visit(MethodCallExpr n, object arg);

		
	virtual void visit(MethodReferenceExpr n, object arg);

		
	virtual void visit(Name n, object arg);

		
	virtual void visit(NameExpr n, object arg);

		
	virtual void visit(NormalAnnotationExpr n, object arg);

		
	virtual void visit(NullLiteralExpr n, object arg);

		
	virtual void visit(ObjectCreationExpr n, object arg);

		
	virtual void visit(PatternExpr n, object arg);

		
	virtual void visit(SimpleName n, object arg);

		
	virtual void visit(SingleMemberAnnotationExpr n, object arg);

		
	virtual void visit(StringLiteralExpr n, object arg);

		
	virtual void visit(SuperExpr n, object arg);

		
	virtual void visit(SwitchExpr switchExpr, object arg);

		
	virtual void visit(TextBlockLiteralExpr n, object arg);

		
	virtual void visit(ThisExpr n, object arg);

		
	virtual void visit(TypeExpr n, object arg);

		
	virtual void visit(UnaryExpr n, object arg);

		
	virtual void visit(VariableDeclarationExpr n, object arg);

		
	virtual void visit(ImportDeclaration n, object arg);

		
	virtual void visit(Modifier n, object arg);

		
	virtual void visit(ModuleDeclaration n, object arg);

		
	virtual void visit(ModuleExportsDirective n, object arg);

		
	virtual void visit(ModuleOpensDirective n, object arg);

		
	virtual void visit(ModuleProvidesDirective n, object arg);

		
	virtual void visit(ModuleRequiresDirective n, object arg);

		
	virtual void visit(ModuleUsesDirective n, object arg);

		
	virtual void visit(NodeList n, object arg);

		
	virtual void visit(PackageDeclaration n, object arg);

		
	virtual void visit(AssertStmt n, object arg);

		
	virtual void visit(BlockStmt n, object arg);

		
	virtual void visit(BreakStmt n, object arg);

		
	virtual void visit(CatchClause n, object arg);

		
	virtual void visit(ContinueStmt n, object arg);

		
	virtual void visit(DoStmt n, object arg);

		
	virtual void visit(EmptyStmt n, object arg);

		
	virtual void visit(ExplicitConstructorInvocationStmt n, object arg);

		
	virtual void visit(ExpressionStmt n, object arg);

		
	virtual void visit(ForEachStmt n, object arg);

		
	virtual void visit(ForStmt n, object arg);

		
	virtual void visit(IfStmt n, object arg);

		
	virtual void visit(LabeledStmt n, object arg);

		
	virtual void visit(LocalClassDeclarationStmt n, object arg);

		
	virtual void visit(LocalRecordDeclarationStmt n, object arg);

		
	virtual void visit(ReturnStmt n, object arg);

		
	virtual void visit(SwitchEntry n, object arg);

		
	virtual void visit(SwitchStmt n, object arg);

		
	virtual void visit(SynchronizedStmt n, object arg);

		
	virtual void visit(ThrowStmt n, object arg);

		
	virtual void visit(TryStmt n, object arg);

		
	virtual void visit(UnparsableStmt n, object arg);

		
	virtual void visit(WhileStmt n, object arg);

		
	virtual void visit(YieldStmt yieldStmt, object arg);

		
	virtual void visit(ArrayType n, object arg);

		
	virtual void visit(ClassOrInterfaceType n, object arg);

		
	virtual void visit(IntersectionType n, object arg);

		
	virtual void visit(PrimitiveType n, object arg);

		
	virtual void visit(TypeParameter n, object arg);

		
	virtual void visit(UnionType n, object arg);

		
	virtual void visit(UnknownType n, object arg);

		
	virtual void visit(VarType n, object arg);

		
	virtual void visit(VoidType n, object arg);

		
	virtual void visit(WildcardType n, object arg);
}
