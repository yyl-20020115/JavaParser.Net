using System.ComponentModel;

using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;

using java.lang;
using java.util;

namespace com.github.javaparser.ast.visitor;

public class NoCommentHashCodeVisitor : GenericVisitor
{
	
	private static NoCommentHashCodeVisitor SINGLETON;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
	
	
	public virtual Integer visit(PatternExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getType().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(TextBlockLiteralExpr n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getValue()));
		
		return result;
	}

	
	
	
	public virtual Integer visit(YieldStmt n, Void arg)
	{
		return (Integer)n.getExpression().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(SwitchExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getEntries().accept(this, arg)).intValue() * 31 + ((Integer)n.getSelector().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(Modifier n, Void arg)
	{
		Integer result = Integer.valueOf(n.getKeyword().GetHashCode());
		
		return result;
	}

	
	
	
	public virtual Integer visit(VarType n, Void arg)
	{
		return (Integer)n.getAnnotations().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(ReceiverParameter n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getAnnotations().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getType().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(UnparsableStmt n, Void arg)
	{
		Integer result = Integer.valueOf(0);
		
		return result;
	}

	
	
	
	public virtual Integer visit(ModuleOpensDirective n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getModuleNames().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ModuleUsesDirective n, Void arg)
	{
		return (Integer)n.getName().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(ModuleProvidesDirective n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getWith().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ModuleExportsDirective n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getModuleNames().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ModuleRequiresDirective n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ModuleDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getAnnotations().accept(this, arg)).intValue() * 31 + ((Integer)n.getDirectives().accept(this, arg)).intValue() * 31 + (n.isOpen() ? 1 : 0) * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ImportDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf((n.isAsterisk() ? 1 : 0) * 31 + (n.isStatic() ? 1 : 0) * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(SimpleName n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getIdentifier()));
		
		return result;
	}

	
	
	
	public virtual Integer visit(Name n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getIdentifier()) * 31 + (n.getQualifier().isPresent() ? ((Integer)((Name)n.getQualifier().get()).accept(this, arg)).intValue() : 0));
		
		return result;
	}

	
	
	
	public virtual Integer visit(NodeList n, Void arg)
	{
		int num = 0;
		Iterator iterator = n.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			num += 31 * ((Integer)((Visitable)obj).accept(this, arg)).intValue();
		}
		Integer result = Integer.valueOf(num);
		
		return result;
	}

	
	
	
	public virtual Integer visit(TypeExpr n, Void arg)
	{
		return (Integer)n.getType().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(MethodReferenceExpr n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getIdentifier()) * 31 + ((Integer)n.getScope().accept(this, arg)).intValue() * 31 + (n.getTypeArguments().isPresent() ? ((Integer)((NodeList)n.getTypeArguments().get()).accept(this, arg)).intValue() : 0));
		
		return result;
	}

	
	
	
	public virtual Integer visit(LambdaExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + (n.isEnclosingParameters() ? 1 : 0) * 31 + ((Integer)n.getParameters().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(CatchClause n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + ((Integer)n.getParameter().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(TryStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getCatchClauses().accept(this, arg)).intValue() * 31 + (n.getFinallyBlock().isPresent() ? ((Integer)((BlockStmt)n.getFinallyBlock().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getResources().accept(this, arg)).intValue() * 31 + ((Integer)n.getTryBlock().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(SynchronizedStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + ((Integer)n.getExpression().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ThrowStmt n, Void arg)
	{
		return (Integer)n.getExpression().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(ForStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + (n.getCompare().isPresent() ? ((Integer)((Expression)n.getCompare().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getInitialization().accept(this, arg)).intValue() * 31 + ((Integer)n.getUpdate().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ForEachStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + ((Integer)n.getIterable().accept(this, arg)).intValue() * 31 + ((Integer)n.getVariable().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(DoStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + ((Integer)n.getCondition().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ContinueStmt n, Void arg)
	{
		Integer result = ((!n.getLabel().isPresent()) ? Integer.valueOf(0) : ((Integer)((SimpleName)n.getLabel().get()).accept(this, arg)));
		
		return result;
	}

	
	
	
	public virtual Integer visit(WhileStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + ((Integer)n.getCondition().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(IfStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getCondition().accept(this, arg)).intValue() * 31 + (n.getElseStmt().isPresent() ? ((Integer)((Statement)n.getElseStmt().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getThenStmt().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ReturnStmt n, Void arg)
	{
		Integer result = ((!n.getExpression().isPresent()) ? Integer.valueOf(0) : ((Integer)((Expression)n.getExpression().get()).accept(this, arg)));
		
		return result;
	}

	
	
	
	public virtual Integer visit(BreakStmt n, Void arg)
	{
		Integer result = ((!n.getLabel().isPresent()) ? Integer.valueOf(0) : ((Integer)((SimpleName)n.getLabel().get()).accept(this, arg)));
		
		return result;
	}

	
	
	
	public virtual Integer visit(SwitchEntry n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getLabels().accept(this, arg)).intValue() * 31 + ((Integer)n.getStatements().accept(this, arg)).intValue() * 31 + n.getType().GetHashCode());
		
		return result;
	}

	
	
	
	public virtual Integer visit(SwitchStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getEntries().accept(this, arg)).intValue() * 31 + ((Integer)n.getSelector().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ExpressionStmt n, Void arg)
	{
		return (Integer)n.getExpression().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(EmptyStmt n, Void arg)
	{
		Integer result = Integer.valueOf(0);
		
		return result;
	}

	
	
	
	public virtual Integer visit(LabeledStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getLabel().accept(this, arg)).intValue() * 31 + ((Integer)n.getStatement().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(BlockStmt n, Void arg)
	{
		return (Integer)n.getStatements().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(AssertStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getCheck().accept(this, arg)).intValue() * 31 + (n.getMessage().isPresent() ? ((Integer)((Expression)n.getMessage().get()).accept(this, arg)).intValue() : 0));
		
		return result;
	}

	
	
	
	public virtual Integer visit(LocalRecordDeclarationStmt n, Void arg)
	{
		return (Integer)n.getRecordDeclaration().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(LocalClassDeclarationStmt n, Void arg)
	{
		return (Integer)n.getClassDeclaration().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(ExplicitConstructorInvocationStmt n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getArguments().accept(this, arg)).intValue() * 31 + (n.getExpression().isPresent() ? ((Integer)((Expression)n.getExpression().get()).accept(this, arg)).intValue() : 0) * 31 + (n.isThis() ? 1 : 0) * 31 + (n.getTypeArguments().isPresent() ? ((Integer)((NodeList)n.getTypeArguments().get()).accept(this, arg)).intValue() : 0));
		
		return result;
	}

	
	
	
	public virtual Integer visit(MemberValuePair n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getValue().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(NormalAnnotationExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getPairs().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(SingleMemberAnnotationExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getMemberValue().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(MarkerAnnotationExpr n, Void arg)
	{
		return (Integer)n.getName().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(VariableDeclarationExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getAnnotations().accept(this, arg)).intValue() * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getVariables().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(UnaryExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getExpression().accept(this, arg)).intValue() * 31 + n.getOperator().GetHashCode());
		
		return result;
	}

	
	
	
	public virtual Integer visit(SuperExpr n, Void arg)
	{
		Integer result = ((!n.getTypeName().isPresent()) ? Integer.valueOf(0) : ((Integer)((Name)n.getTypeName().get()).accept(this, arg)));
		
		return result;
	}

	
	
	
	public virtual Integer visit(ThisExpr n, Void arg)
	{
		Integer result = ((!n.getTypeName().isPresent()) ? Integer.valueOf(0) : ((Integer)((Name)n.getTypeName().get()).accept(this, arg)));
		
		return result;
	}

	
	
	
	public virtual Integer visit(ObjectCreationExpr n, Void arg)
	{
		Integer result = Integer.valueOf((n.getAnonymousClassBody().isPresent() ? ((Integer)((NodeList)n.getAnonymousClassBody().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getArguments().accept(this, arg)).intValue() * 31 + (n.getScope().isPresent() ? ((Integer)((Expression)n.getScope().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getType().accept(this, arg)).intValue() * 31 + (n.getTypeArguments().isPresent() ? ((Integer)((NodeList)n.getTypeArguments().get()).accept(this, arg)).intValue() : 0));
		
		return result;
	}

	
	
	
	public virtual Integer visit(NameExpr n, Void arg)
	{
		return (Integer)n.getName().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(MethodCallExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getArguments().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + (n.getScope().isPresent() ? ((Integer)((Expression)n.getScope().get()).accept(this, arg)).intValue() : 0) * 31 + (n.getTypeArguments().isPresent() ? ((Integer)((NodeList)n.getTypeArguments().get()).accept(this, arg)).intValue() : 0));
		
		return result;
	}

	
	
	
	public virtual Integer visit(NullLiteralExpr n, Void arg)
	{
		Integer result = Integer.valueOf(0);
		
		return result;
	}

	
	
	
	public virtual Integer visit(BooleanLiteralExpr n, Void arg)
	{
		Integer result = Integer.valueOf(n.isValue() ? 1 : 0);
		
		return result;
	}

	
	
	
	public virtual Integer visit(DoubleLiteralExpr n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getValue()));
		
		return result;
	}

	
	
	
	public virtual Integer visit(CharLiteralExpr n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getValue()));
		
		return result;
	}

	
	
	
	public virtual Integer visit(LongLiteralExpr n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getValue()));
		
		return result;
	}

	
	
	
	public virtual Integer visit(IntegerLiteralExpr n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getValue()));
		
		return result;
	}

	
	
	
	public virtual Integer visit(StringLiteralExpr n, Void arg)
	{
		Integer result = Integer.valueOf(String.instancehelper_hashCode(n.getValue()));
		
		return result;
	}

	
	
	
	public virtual Integer visit(InstanceOfExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getExpression().accept(this, arg)).intValue() * 31 + (n.getPattern().isPresent() ? ((Integer)((PatternExpr)n.getPattern().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getType().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(FieldAccessExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getScope().accept(this, arg)).intValue() * 31 + (n.getTypeArguments().isPresent() ? ((Integer)((NodeList)n.getTypeArguments().get()).accept(this, arg)).intValue() : 0));
		
		return result;
	}

	
	
	
	public virtual Integer visit(EnclosedExpr n, Void arg)
	{
		return (Integer)n.getInner().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(ConditionalExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getCondition().accept(this, arg)).intValue() * 31 + ((Integer)n.getElseExpr().accept(this, arg)).intValue() * 31 + ((Integer)n.getThenExpr().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ClassExpr n, Void arg)
	{
		return (Integer)n.getType().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(CastExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getExpression().accept(this, arg)).intValue() * 31 + ((Integer)n.getType().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(BinaryExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getLeft().accept(this, arg)).intValue() * 31 + n.getOperator().GetHashCode() * 31 + ((Integer)n.getRight().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(AssignExpr n, Void arg)
	{
		Integer result = Integer.valueOf(n.getOperator().GetHashCode() * 31 + ((Integer)n.getTarget().accept(this, arg)).intValue() * 31 + ((Integer)n.getValue().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ArrayInitializerExpr n, Void arg)
	{
		return (Integer)n.getValues().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(ArrayCreationExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getElementType().accept(this, arg)).intValue() * 31 + (n.getInitializer().isPresent() ? ((Integer)((ArrayInitializerExpr)n.getInitializer().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getLevels().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ArrayAccessExpr n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getIndex().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(UnknownType n, Void arg)
	{
		return (Integer)n.getAnnotations().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(WildcardType n, Void arg)
	{
		Integer result = Integer.valueOf((n.getExtendedType().isPresent() ? ((Integer)((ReferenceType)n.getExtendedType().get()).accept(this, arg)).intValue() : 0) * 31 + (n.getSuperType().isPresent() ? ((Integer)((ReferenceType)n.getSuperType().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(VoidType n, Void arg)
	{
		return (Integer)n.getAnnotations().accept(this, arg);
	}

	
	
	
	public virtual Integer visit(UnionType n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getElements().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(IntersectionType n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getElements().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ArrayCreationLevel n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getAnnotations().accept(this, arg)).intValue() * 31 + (n.getDimension().isPresent() ? ((Integer)((Expression)n.getDimension().get()).accept(this, arg)).intValue() : 0));
		
		return result;
	}

	
	
	
	public virtual Integer visit(ArrayType n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getComponentType().accept(this, arg)).intValue() * 31 + n.getOrigin().GetHashCode() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(PrimitiveType n, Void arg)
	{
		Integer result = Integer.valueOf(n.getType().GetHashCode() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ClassOrInterfaceType n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getName().accept(this, arg)).intValue() * 31 + (n.getScope().isPresent() ? ((Integer)((ClassOrInterfaceType)n.getScope().get()).accept(this, arg)).intValue() : 0) * 31 + (n.getTypeArguments().isPresent() ? ((Integer)((NodeList)n.getTypeArguments().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(JavadocComment n, Void arg)
	{
		Integer result = Integer.valueOf(0);
		
		return result;
	}

	
	
	
	public virtual Integer visit(InitializerDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + (n.isStatic() ? 1 : 0) * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(Parameter n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getAnnotations().accept(this, arg)).intValue() * 31 + (n.isVarArgs() ? 1 : 0) * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getType().accept(this, arg)).intValue() * 31 + ((Integer)n.getVarArgsAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(MethodDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf((n.getBody().isPresent() ? ((Integer)((BlockStmt)n.getBody().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getType().accept(this, arg)).intValue() * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getParameters().accept(this, arg)).intValue() * 31 + (n.getReceiverParameter().isPresent() ? ((Integer)((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getThrownExceptions().accept(this, arg)).intValue() * 31 + ((Integer)n.getTypeParameters().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ConstructorDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getParameters().accept(this, arg)).intValue() * 31 + (n.getReceiverParameter().isPresent() ? ((Integer)((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getThrownExceptions().accept(this, arg)).intValue() * 31 + ((Integer)n.getTypeParameters().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(VariableDeclarator n, Void arg)
	{
		Integer result = Integer.valueOf((n.getInitializer().isPresent() ? ((Integer)((Expression)n.getInitializer().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getType().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(FieldDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getVariables().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(AnnotationMemberDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf((n.getDefaultValue().isPresent() ? ((Integer)((Expression)n.getDefaultValue().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getType().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(AnnotationDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getMembers().accept(this, arg)).intValue() * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(EnumConstantDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getArguments().accept(this, arg)).intValue() * 31 + ((Integer)n.getClassBody().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(EnumDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getEntries().accept(this, arg)).intValue() * 31 + ((Integer)n.getImplementedTypes().accept(this, arg)).intValue() * 31 + ((Integer)n.getMembers().accept(this, arg)).intValue() * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(CompactConstructorDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getBody().accept(this, arg)).intValue() * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getThrownExceptions().accept(this, arg)).intValue() * 31 + ((Integer)n.getTypeParameters().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(RecordDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getImplementedTypes().accept(this, arg)).intValue() * 31 + ((Integer)n.getParameters().accept(this, arg)).intValue() * 31 + (n.getReceiverParameter().isPresent() ? ((Integer)((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getTypeParameters().accept(this, arg)).intValue() * 31 + ((Integer)n.getMembers().accept(this, arg)).intValue() * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(ClassOrInterfaceDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getExtendedTypes().accept(this, arg)).intValue() * 31 + ((Integer)n.getImplementedTypes().accept(this, arg)).intValue() * 31 + (n.isInterface() ? 1 : 0) * 31 + ((Integer)n.getTypeParameters().accept(this, arg)).intValue() * 31 + ((Integer)n.getMembers().accept(this, arg)).intValue() * 31 + ((Integer)n.getModifiers().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(BlockComment n, Void arg)
	{
		Integer result = Integer.valueOf(0);
		
		return result;
	}

	
	
	
	public virtual Integer visit(LineComment n, Void arg)
	{
		Integer result = Integer.valueOf(0);
		
		return result;
	}

	
	
	
	public virtual Integer visit(TypeParameter n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getName().accept(this, arg)).intValue() * 31 + ((Integer)n.getTypeBound().accept(this, arg)).intValue() * 31 + ((Integer)n.getAnnotations().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(PackageDeclaration n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getAnnotations().accept(this, arg)).intValue() * 31 + ((Integer)n.getName().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	
	public virtual Integer visit(CompilationUnit n, Void arg)
	{
		Integer result = Integer.valueOf(((Integer)n.getImports().accept(this, arg)).intValue() * 31 + (n.getModule().isPresent() ? ((Integer)((ModuleDeclaration)n.getModule().get()).accept(this, arg)).intValue() : 0) * 31 + (n.getPackageDeclaration().isPresent() ? ((Integer)((PackageDeclaration)n.getPackageDeclaration().get()).accept(this, arg)).intValue() : 0) * 31 + ((Integer)n.getTypes().accept(this, arg)).intValue());
		
		return result;
	}

	
	
	public NoCommentHashCodeVisitor()
	{
	}

	
	
	
	public static int GetHashCode(Node node)
	{
		int result = ((Integer)node.accept(SINGLETON, null)).intValue();
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(PatternExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(TextBlockLiteralExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(YieldStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SwitchExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(Modifier n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(VarType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ReceiverParameter n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(UnparsableStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleOpensDirective n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleUsesDirective n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleProvidesDirective n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleExportsDirective n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleRequiresDirective n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ModuleDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ImportDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SimpleName n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(Name n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(NodeList n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(TypeExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MethodReferenceExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LambdaExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CatchClause n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(TryStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SynchronizedStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ThrowStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ForStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ForEachStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(DoStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ContinueStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(WhileStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(IfStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ReturnStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BreakStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SwitchEntry n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SwitchStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ExpressionStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(EmptyStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LabeledStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BlockStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(AssertStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LocalRecordDeclarationStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LocalClassDeclarationStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MemberValuePair n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(NormalAnnotationExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SingleMemberAnnotationExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MarkerAnnotationExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(VariableDeclarationExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(UnaryExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(SuperExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ThisExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ObjectCreationExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(NameExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MethodCallExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(NullLiteralExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BooleanLiteralExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(DoubleLiteralExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CharLiteralExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LongLiteralExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(IntegerLiteralExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(StringLiteralExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(InstanceOfExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(FieldAccessExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(EnclosedExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ConditionalExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ClassExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CastExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BinaryExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(AssignExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayInitializerExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayCreationExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayAccessExpr n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(UnknownType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(WildcardType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(VoidType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(UnionType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(IntersectionType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayCreationLevel n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ArrayType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(PrimitiveType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ClassOrInterfaceType n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(JavadocComment n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(InitializerDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(Parameter n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(MethodDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ConstructorDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(VariableDeclarator n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(FieldDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(AnnotationMemberDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(AnnotationDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(EnumConstantDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(EnumDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CompactConstructorDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(RecordDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(ClassOrInterfaceDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(BlockComment n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(LineComment n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(TypeParameter n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(PackageDeclaration n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	
	
	
	
	public virtual object visit(CompilationUnit n, object arg)
	{
		Integer result = visit(n, (Void)arg);
		
		return result;
	}

	
	static NoCommentHashCodeVisitor()
	{
		SINGLETON = new NoCommentHashCodeVisitor();
	}
}
