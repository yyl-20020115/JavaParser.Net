using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using com.github.javaparser.ast.visitor;
using com.github.javaparser.resolution.types;
using IKVM.Attributes;
using java.lang;

namespace com.github.javaparser.symbolsolver.javaparsermodel;

public class DefaultVisitorAdapter: GenericVisitor
{
	
	
	public virtual ResolvedType visit(PatternExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(TextBlockLiteralExpr node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(YieldStmt node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(SwitchExpr node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(Modifier node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(VarType node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ReceiverParameter node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(UnparsableStmt node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ModuleOpensDirective node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ModuleUsesDirective node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ModuleProvidesDirective node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ModuleExportsDirective node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ModuleRequiresDirective node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ModuleDeclaration node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ImportDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(SimpleName node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(Name node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(NodeList node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(TypeExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(MethodReferenceExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(LambdaExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(CatchClause node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(TryStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(SynchronizedStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ThrowStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ForStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ForEachStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(DoStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ContinueStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(WhileStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(IfStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ReturnStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(BreakStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(SwitchEntry node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(SwitchStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ExpressionStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(EmptyStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(LabeledStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(BlockStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(AssertStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(LocalRecordDeclarationStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(LocalClassDeclarationStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ExplicitConstructorInvocationStmt node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(MemberValuePair node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(NormalAnnotationExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(SingleMemberAnnotationExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(MarkerAnnotationExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(VariableDeclarationExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(UnaryExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(SuperExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ThisExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ObjectCreationExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(NameExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(MethodCallExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(NullLiteralExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(BooleanLiteralExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(DoubleLiteralExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(CharLiteralExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(LongLiteralExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(IntegerLiteralExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(StringLiteralExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(InstanceOfExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(FieldAccessExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(EnclosedExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ConditionalExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ClassExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(CastExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(BinaryExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(AssignExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ArrayInitializerExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ArrayCreationExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ArrayAccessExpr node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(UnknownType node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(WildcardType node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(VoidType node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(UnionType node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(IntersectionType node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ArrayCreationLevel node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ArrayType node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(PrimitiveType node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ClassOrInterfaceType node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(JavadocComment node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(InitializerDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(Parameter node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(MethodDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ConstructorDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(VariableDeclarator node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(FieldDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(AnnotationMemberDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(AnnotationDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(EnumConstantDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(EnumDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(CompactConstructorDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(RecordDeclaration node, Boolean arg)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(ClassOrInterfaceDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(BlockComment node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(LineComment node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(TypeParameter node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(PackageDeclaration node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public virtual ResolvedType visit(CompilationUnit node, Boolean aBoolean)
	{
		string canonicalName = Object.instancehelper_getClass(node).getCanonicalName();
		
		throw new UnsupportedOperationException(canonicalName);
	}

	
	
	public DefaultVisitorAdapter()
	{
	}

	
	
	
	
	public virtual object visit(PatternExpr pe, object obj)
	{
		ResolvedType result = visit(pe, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(TextBlockLiteralExpr tble, object obj)
	{
		ResolvedType result = visit(tble, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(YieldStmt ys, object obj)
	{
		ResolvedType result = visit(ys, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(SwitchExpr se, object obj)
	{
		ResolvedType result = visit(se, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(Modifier m, object obj)
	{
		ResolvedType result = visit(m, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(VarType vt, object obj)
	{
		ResolvedType result = visit(vt, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ReceiverParameter rp, object obj)
	{
		ResolvedType result = visit(rp, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(UnparsableStmt us, object obj)
	{
		ResolvedType result = visit(us, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ModuleOpensDirective mod, object obj)
	{
		ResolvedType result = visit(mod, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ModuleUsesDirective mud, object obj)
	{
		ResolvedType result = visit(mud, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ModuleProvidesDirective mpd, object obj)
	{
		ResolvedType result = visit(mpd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ModuleExportsDirective med, object obj)
	{
		ResolvedType result = visit(med, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ModuleRequiresDirective mrd, object obj)
	{
		ResolvedType result = visit(mrd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ModuleDeclaration md, object obj)
	{
		ResolvedType result = visit(md, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ImportDeclaration id, object obj)
	{
		ResolvedType result = visit(id, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(SimpleName sn, object obj)
	{
		ResolvedType result = visit(sn, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(Name n, object obj)
	{
		ResolvedType result = visit(n, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(NodeList nl, object obj)
	{
		ResolvedType result = visit(nl, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(TypeExpr te, object obj)
	{
		ResolvedType result = visit(te, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(MethodReferenceExpr mre, object obj)
	{
		ResolvedType result = visit(mre, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(LambdaExpr le, object obj)
	{
		ResolvedType result = visit(le, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(CatchClause cc, object obj)
	{
		ResolvedType result = visit(cc, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(TryStmt ts, object obj)
	{
		ResolvedType result = visit(ts, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(SynchronizedStmt ss, object obj)
	{
		ResolvedType result = visit(ss, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ThrowStmt ts, object obj)
	{
		ResolvedType result = visit(ts, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ForStmt fs, object obj)
	{
		ResolvedType result = visit(fs, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ForEachStmt fes, object obj)
	{
		ResolvedType result = visit(fes, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(DoStmt ds, object obj)
	{
		ResolvedType result = visit(ds, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ContinueStmt cs, object obj)
	{
		ResolvedType result = visit(cs, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(WhileStmt ws, object obj)
	{
		ResolvedType result = visit(ws, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(IfStmt @is, object obj)
	{
		ResolvedType result = visit(@is, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ReturnStmt rs, object obj)
	{
		ResolvedType result = visit(rs, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(BreakStmt bs, object obj)
	{
		ResolvedType result = visit(bs, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(SwitchEntry se, object obj)
	{
		ResolvedType result = visit(se, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(SwitchStmt ss, object obj)
	{
		ResolvedType result = visit(ss, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ExpressionStmt es, object obj)
	{
		ResolvedType result = visit(es, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(EmptyStmt es, object obj)
	{
		ResolvedType result = visit(es, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(LabeledStmt ls, object obj)
	{
		ResolvedType result = visit(ls, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(BlockStmt bs, object obj)
	{
		ResolvedType result = visit(bs, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(AssertStmt @as, object obj)
	{
		ResolvedType result = visit(@as, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(LocalRecordDeclarationStmt lrds, object obj)
	{
		ResolvedType result = visit(lrds, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(LocalClassDeclarationStmt lcds, object obj)
	{
		ResolvedType result = visit(lcds, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ExplicitConstructorInvocationStmt ecis, object obj)
	{
		ResolvedType result = visit(ecis, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(MemberValuePair mvp, object obj)
	{
		ResolvedType result = visit(mvp, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(NormalAnnotationExpr nae, object obj)
	{
		ResolvedType result = visit(nae, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(SingleMemberAnnotationExpr smae, object obj)
	{
		ResolvedType result = visit(smae, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(MarkerAnnotationExpr mae, object obj)
	{
		ResolvedType result = visit(mae, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(VariableDeclarationExpr vde, object obj)
	{
		ResolvedType result = visit(vde, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(UnaryExpr ue, object obj)
	{
		ResolvedType result = visit(ue, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(SuperExpr se, object obj)
	{
		ResolvedType result = visit(se, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ThisExpr te, object obj)
	{
		ResolvedType result = visit(te, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ObjectCreationExpr oce, object obj)
	{
		ResolvedType result = visit(oce, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(NameExpr ne, object obj)
	{
		ResolvedType result = visit(ne, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(MethodCallExpr mce, object obj)
	{
		ResolvedType result = visit(mce, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(NullLiteralExpr nle, object obj)
	{
		ResolvedType result = visit(nle, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(BooleanLiteralExpr ble, object obj)
	{
		ResolvedType result = visit(ble, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(DoubleLiteralExpr dle, object obj)
	{
		ResolvedType result = visit(dle, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(CharLiteralExpr cle, object obj)
	{
		ResolvedType result = visit(cle, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(LongLiteralExpr lle, object obj)
	{
		ResolvedType result = visit(lle, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(IntegerLiteralExpr ile, object obj)
	{
		ResolvedType result = visit(ile, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(StringLiteralExpr sle, object obj)
	{
		ResolvedType result = visit(sle, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(InstanceOfExpr ioe, object obj)
	{
		ResolvedType result = visit(ioe, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(FieldAccessExpr fae, object obj)
	{
		ResolvedType result = visit(fae, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(EnclosedExpr ee, object obj)
	{
		ResolvedType result = visit(ee, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ConditionalExpr ce, object obj)
	{
		ResolvedType result = visit(ce, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ClassExpr ce, object obj)
	{
		ResolvedType result = visit(ce, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(CastExpr ce, object obj)
	{
		ResolvedType result = visit(ce, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(BinaryExpr be, object obj)
	{
		ResolvedType result = visit(be, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(AssignExpr ae, object obj)
	{
		ResolvedType result = visit(ae, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ArrayInitializerExpr aie, object obj)
	{
		ResolvedType result = visit(aie, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ArrayCreationExpr ace, object obj)
	{
		ResolvedType result = visit(ace, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ArrayAccessExpr aae, object obj)
	{
		ResolvedType result = visit(aae, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(UnknownType ut, object obj)
	{
		ResolvedType result = visit(ut, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(WildcardType wt, object obj)
	{
		ResolvedType result = visit(wt, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(VoidType vt, object obj)
	{
		ResolvedType result = visit(vt, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(UnionType ut, object obj)
	{
		ResolvedType result = visit(ut, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(IntersectionType it, object obj)
	{
		ResolvedType result = visit(it, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ArrayCreationLevel acl, object obj)
	{
		ResolvedType result = visit(acl, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ArrayType at, object obj)
	{
		ResolvedType result = visit(at, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(PrimitiveType pt, object obj)
	{
		ResolvedType result = visit(pt, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ClassOrInterfaceType coit, object obj)
	{
		ResolvedType result = visit(coit, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(JavadocComment jc, object obj)
	{
		ResolvedType result = visit(jc, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(InitializerDeclaration id, object obj)
	{
		ResolvedType result = visit(id, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(Parameter p, object obj)
	{
		ResolvedType result = visit(p, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(MethodDeclaration md, object obj)
	{
		ResolvedType result = visit(md, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ConstructorDeclaration cd, object obj)
	{
		ResolvedType result = visit(cd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(VariableDeclarator vd, object obj)
	{
		ResolvedType result = visit(vd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(FieldDeclaration fd, object obj)
	{
		ResolvedType result = visit(fd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(AnnotationMemberDeclaration amd, object obj)
	{
		ResolvedType result = visit(amd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(AnnotationDeclaration ad, object obj)
	{
		ResolvedType result = visit(ad, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(EnumConstantDeclaration ecd, object obj)
	{
		ResolvedType result = visit(ecd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(EnumDeclaration ed, object obj)
	{
		ResolvedType result = visit(ed, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(CompactConstructorDeclaration ccd, object obj)
	{
		ResolvedType result = visit(ccd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(RecordDeclaration rd, object obj)
	{
		ResolvedType result = visit(rd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(ClassOrInterfaceDeclaration coid, object obj)
	{
		ResolvedType result = visit(coid, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(BlockComment bc, object obj)
	{
		ResolvedType result = visit(bc, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(LineComment lc, object obj)
	{
		ResolvedType result = visit(lc, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(TypeParameter tp, object obj)
	{
		ResolvedType result = visit(tp, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(PackageDeclaration pd, object obj)
	{
		ResolvedType result = visit(pd, (Boolean)obj);
		
		return result;
	}

	
	
	
	
	public virtual object visit(CompilationUnit cu, object obj)
	{
		ResolvedType result = visit(cu, (Boolean)obj);
		
		return result;
	}
}
