using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;

using java.lang;

namespace com.github.javaparser.ast.visitor;

public class ObjectIdentityEqualsVisitor : GenericVisitor
{
	
	private static ObjectIdentityEqualsVisitor SINGLETON;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public virtual Boolean visit(PatternExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(TextBlockLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(YieldStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(SwitchExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(Modifier n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(VarType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ReceiverParameter n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(UnparsableStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ModuleOpensDirective n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ModuleUsesDirective n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ModuleProvidesDirective n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ModuleExportsDirective n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ModuleRequiresDirective n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ModuleDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ImportDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(SimpleName n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(Name n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(NodeList n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(TypeExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(MethodReferenceExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(LambdaExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(CatchClause n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(TryStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(SynchronizedStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ThrowStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ForStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ForEachStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(DoStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ContinueStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(WhileStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(IfStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ReturnStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(BreakStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(SwitchEntry n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(SwitchStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ExpressionStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(EmptyStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(LabeledStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(BlockStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(AssertStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(LocalRecordDeclarationStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(LocalClassDeclarationStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ExplicitConstructorInvocationStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(MemberValuePair n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(NormalAnnotationExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(SingleMemberAnnotationExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(MarkerAnnotationExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(VariableDeclarationExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(UnaryExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(SuperExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ThisExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ObjectCreationExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(NameExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(MethodCallExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(NullLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(BooleanLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(DoubleLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(CharLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(LongLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(IntegerLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(StringLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(InstanceOfExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(FieldAccessExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(EnclosedExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ConditionalExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ClassExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(CastExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(BinaryExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(AssignExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ArrayInitializerExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ArrayCreationExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ArrayAccessExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(UnknownType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(WildcardType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(VoidType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(UnionType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(IntersectionType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ArrayCreationLevel n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ArrayType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(PrimitiveType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ClassOrInterfaceType n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(JavadocComment n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(InitializerDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(Parameter n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(MethodDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ConstructorDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(VariableDeclarator n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(FieldDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(AnnotationMemberDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(AnnotationDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(EnumConstantDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(EnumDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(CompactConstructorDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(RecordDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(ClassOrInterfaceDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(BlockComment n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(LineComment n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(TypeParameter n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(PackageDeclaration n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	
	public virtual Boolean visit(CompilationUnit n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(n == arg);
		
		return result;
	}

	
	
	public ObjectIdentityEqualsVisitor()
	{
	}

	
	
	
	public static bool equals(Node n, Node n2)
	{
		bool result = ((Boolean)n.accept(SINGLETON, n2)).booleanValue();
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(PatternExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(TextBlockLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(YieldStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SwitchExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(Modifier n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(VarType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ReceiverParameter n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(UnparsableStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleOpensDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleUsesDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleProvidesDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleExportsDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleRequiresDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ImportDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SimpleName n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(Name n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(NodeList n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(TypeExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MethodReferenceExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LambdaExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CatchClause n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(TryStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SynchronizedStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ThrowStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ForStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ForEachStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(DoStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ContinueStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(WhileStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(IfStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ReturnStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BreakStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SwitchEntry n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SwitchStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ExpressionStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(EmptyStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LabeledStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BlockStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(AssertStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LocalRecordDeclarationStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LocalClassDeclarationStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MemberValuePair n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(NormalAnnotationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SingleMemberAnnotationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MarkerAnnotationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(VariableDeclarationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(UnaryExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SuperExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ThisExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ObjectCreationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(NameExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MethodCallExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(NullLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BooleanLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(DoubleLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CharLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LongLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(IntegerLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(StringLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(InstanceOfExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(FieldAccessExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(EnclosedExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ConditionalExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ClassExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CastExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BinaryExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(AssignExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayInitializerExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayCreationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayAccessExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(UnknownType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(WildcardType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(VoidType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(UnionType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(IntersectionType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayCreationLevel n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(PrimitiveType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ClassOrInterfaceType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(JavadocComment n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(InitializerDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(Parameter n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MethodDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ConstructorDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(VariableDeclarator n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(FieldDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(AnnotationMemberDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(AnnotationDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(EnumConstantDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(EnumDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CompactConstructorDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(RecordDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ClassOrInterfaceDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BlockComment n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LineComment n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(TypeParameter n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(PackageDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CompilationUnit n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	static ObjectIdentityEqualsVisitor()
	{
		SINGLETON = new ObjectIdentityEqualsVisitor();
	}
}
