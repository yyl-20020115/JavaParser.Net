using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.ast.visitor;

public abstract class VoidVisitorWithDefaults:VoidVisitor
{
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void defaultAction(Node n, object arg)
	{
	}

		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	public virtual void defaultAction(NodeList n, object arg)
	{
	}

	
	
	public VoidVisitorWithDefaults()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(AnnotationDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(AnnotationMemberDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ArrayAccessExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ArrayCreationExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ArrayInitializerExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(AssertStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(AssignExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(BinaryExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(BlockComment n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(BlockStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(BooleanLiteralExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(BreakStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(CastExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(CatchClause n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(CharLiteralExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ClassExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ClassOrInterfaceDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ClassOrInterfaceType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(CompilationUnit n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ConditionalExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ConstructorDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ContinueStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(DoStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(DoubleLiteralExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(EmptyStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(EnclosedExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(EnumConstantDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(EnumDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ExpressionStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(FieldAccessExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(FieldDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ForEachStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ForStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(IfStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(InitializerDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(InstanceOfExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(IntegerLiteralExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(JavadocComment n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LabeledStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LineComment n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LongLiteralExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(MarkerAnnotationExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(MemberValuePair n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(MethodCallExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(MethodDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(NameExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(NormalAnnotationExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(NullLiteralExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ObjectCreationExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(PackageDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(Parameter n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(PrimitiveType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(Name n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SimpleName n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ArrayType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ArrayCreationLevel n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(IntersectionType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(UnionType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ReturnStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SingleMemberAnnotationExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(StringLiteralExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SuperExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SwitchEntry n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SwitchStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SynchronizedStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ThisExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ThrowStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(TryStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LocalClassDeclarationStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LocalRecordDeclarationStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(TypeParameter n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(UnaryExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(UnknownType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(VariableDeclarationExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(VariableDeclarator n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(VoidType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(WhileStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(WildcardType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(LambdaExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(MethodReferenceExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(TypeExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual void visit(NodeList n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ImportDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ModuleDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ModuleRequiresDirective n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ModuleExportsDirective n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ModuleProvidesDirective n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ModuleUsesDirective n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ModuleOpensDirective n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(UnparsableStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(ReceiverParameter n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(Modifier n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(VarType n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(SwitchExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(TextBlockLiteralExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(YieldStmt n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(PatternExpr n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(RecordDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual void visit(CompactConstructorDeclaration n, object arg)
	{
		defaultAction(n, arg);
	}
}
