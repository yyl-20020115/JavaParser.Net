
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;

using java.lang;
using java.util;

namespace com.github.javaparser.ast.visitor;

public abstract class GenericVisitorAdapter : GenericVisitor
{
	
	
	public GenericVisitorAdapter()
	{
	}

	
		
	
	public virtual object visit(AnnotationDeclaration n, object arg)
	{
		object obj = n.getMembers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(AnnotationMemberDeclaration n, object arg)
	{
		object obj;
		if (n.getDefaultValue().isPresent())
		{
			obj = ((Expression)n.getDefaultValue().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ArrayAccessExpr n, object arg)
	{
		object obj = n.getIndex().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ArrayCreationExpr n, object arg)
	{
		object obj = n.getElementType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getInitializer().isPresent())
		{
			obj = ((ArrayInitializerExpr)n.getInitializer().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getLevels().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ArrayInitializerExpr n, object arg)
	{
		object obj = n.getValues().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(AssertStmt n, object arg)
	{
		object obj = n.getCheck().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getMessage().isPresent())
		{
			obj = ((Expression)n.getMessage().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(AssignExpr n, object arg)
	{
		object obj = n.getTarget().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getValue().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(BinaryExpr n, object arg)
	{
		object obj = n.getLeft().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getRight().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(BlockStmt n, object arg)
	{
		object obj = n.getStatements().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(BooleanLiteralExpr n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(BreakStmt n, object arg)
	{
		if (n.getLabel().isPresent())
		{
			object obj = ((SimpleName)n.getLabel().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(CastExpr n, object arg)
	{
		object obj = n.getExpression().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(CatchClause n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getParameter().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(CharLiteralExpr n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ClassExpr n, object arg)
	{
		object obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ClassOrInterfaceDeclaration n, object arg)
	{
		object obj = n.getExtendedTypes().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getImplementedTypes().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getTypeParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getMembers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ClassOrInterfaceType n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getScope().isPresent())
		{
			obj = ((ClassOrInterfaceType)n.getScope().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getTypeArguments().isPresent())
		{
			obj = ((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(CompilationUnit n, object arg)
	{
		object obj = n.getImports().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getModule().isPresent())
		{
			obj = ((ModuleDeclaration)n.getModule().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getPackageDeclaration().isPresent())
		{
			obj = ((PackageDeclaration)n.getPackageDeclaration().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getTypes().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ConditionalExpr n, object arg)
	{
		object obj = n.getCondition().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getElseExpr().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getThenExpr().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ConstructorDeclaration n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getReceiverParameter().isPresent())
		{
			obj = ((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getThrownExceptions().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getTypeParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ContinueStmt n, object arg)
	{
		if (n.getLabel().isPresent())
		{
			object obj = ((SimpleName)n.getLabel().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(DoStmt n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getCondition().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(DoubleLiteralExpr n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(EmptyStmt n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(EnclosedExpr n, object arg)
	{
		object obj = n.getInner().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(EnumConstantDeclaration n, object arg)
	{
		object obj = n.getArguments().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getClassBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(EnumDeclaration n, object arg)
	{
		object obj = n.getEntries().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getImplementedTypes().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getMembers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		object obj = n.getArguments().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getExpression().isPresent())
		{
			obj = ((Expression)n.getExpression().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getTypeArguments().isPresent())
		{
			obj = ((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ExpressionStmt n, object arg)
	{
		object obj = n.getExpression().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(FieldAccessExpr n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getScope().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getTypeArguments().isPresent())
		{
			obj = ((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(FieldDeclaration n, object arg)
	{
		object obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getVariables().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ForEachStmt n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getIterable().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getVariable().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ForStmt n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getCompare().isPresent())
		{
			obj = ((Expression)n.getCompare().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getInitialization().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getUpdate().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(IfStmt n, object arg)
	{
		object obj = n.getCondition().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getElseStmt().isPresent())
		{
			obj = ((Statement)n.getElseStmt().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getThenStmt().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(InitializerDeclaration n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(InstanceOfExpr n, object arg)
	{
		object obj = n.getExpression().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getPattern().isPresent())
		{
			obj = ((PatternExpr)n.getPattern().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(IntegerLiteralExpr n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(JavadocComment n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(LabeledStmt n, object arg)
	{
		object obj = n.getLabel().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getStatement().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(LongLiteralExpr n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(MarkerAnnotationExpr n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(MemberValuePair n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getValue().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(MethodCallExpr n, object arg)
	{
		object obj = n.getArguments().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getScope().isPresent())
		{
			obj = ((Expression)n.getScope().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getTypeArguments().isPresent())
		{
			obj = ((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(MethodDeclaration n, object arg)
	{
		object obj;
		if (n.getBody().isPresent())
		{
			obj = ((BlockStmt)n.getBody().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getReceiverParameter().isPresent())
		{
			obj = ((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getThrownExceptions().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getTypeParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(NameExpr n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(NormalAnnotationExpr n, object arg)
	{
		object obj = n.getPairs().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(NullLiteralExpr n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ObjectCreationExpr n, object arg)
	{
		object obj;
		if (n.getAnonymousClassBody().isPresent())
		{
			obj = ((NodeList)n.getAnonymousClassBody().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getArguments().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getScope().isPresent())
		{
			obj = ((Expression)n.getScope().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getTypeArguments().isPresent())
		{
			obj = ((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(PackageDeclaration n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(Parameter n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getVarArgsAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(PrimitiveType n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(Name n, object arg)
	{
		if (n.getQualifier().isPresent())
		{
			object obj = ((Name)n.getQualifier().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(SimpleName n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ArrayType n, object arg)
	{
		object obj = n.getComponentType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ArrayCreationLevel n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getDimension().isPresent())
		{
			obj = ((Expression)n.getDimension().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(IntersectionType n, object arg)
	{
		object obj = n.getElements().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(UnionType n, object arg)
	{
		object obj = n.getElements().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ReturnStmt n, object arg)
	{
		if (n.getExpression().isPresent())
		{
			object obj = ((Expression)n.getExpression().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(SingleMemberAnnotationExpr n, object arg)
	{
		object obj = n.getMemberValue().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(StringLiteralExpr n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(SuperExpr n, object arg)
	{
		if (n.getTypeName().isPresent())
		{
			object obj = ((Name)n.getTypeName().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(SwitchEntry n, object arg)
	{
		object obj = n.getLabels().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getStatements().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(SwitchStmt n, object arg)
	{
		object obj = n.getEntries().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getSelector().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(SynchronizedStmt n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getExpression().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ThisExpr n, object arg)
	{
		if (n.getTypeName().isPresent())
		{
			object obj = ((Name)n.getTypeName().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ThrowStmt n, object arg)
	{
		object obj = n.getExpression().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(TryStmt n, object arg)
	{
		object obj = n.getCatchClauses().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getFinallyBlock().isPresent())
		{
			obj = ((BlockStmt)n.getFinallyBlock().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getResources().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getTryBlock().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(LocalClassDeclarationStmt n, object arg)
	{
		object obj = n.getClassDeclaration().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(LocalRecordDeclarationStmt n, object arg)
	{
		object obj = n.getRecordDeclaration().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(TypeParameter n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getTypeBound().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(UnaryExpr n, object arg)
	{
		object obj = n.getExpression().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(UnknownType n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(VariableDeclarationExpr n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getVariables().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(VariableDeclarator n, object arg)
	{
		object obj;
		if (n.getInitializer().isPresent())
		{
			obj = ((Expression)n.getInitializer().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(VoidType n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(WhileStmt n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getCondition().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(WildcardType n, object arg)
	{
		object obj;
		if (n.getExtendedType().isPresent())
		{
			obj = ((ReferenceType)n.getExtendedType().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getSuperType().isPresent())
		{
			obj = ((ReferenceType)n.getSuperType().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(LambdaExpr n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(MethodReferenceExpr n, object arg)
	{
		object obj = n.getScope().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getTypeArguments().isPresent())
		{
			obj = ((NodeList)n.getTypeArguments().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(TypeExpr n, object arg)
	{
		object obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ImportDeclaration n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(BlockComment n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(LineComment n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(NodeList n, object arg)
	{
		Iterator iterator = n.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			object obj2 = ((Node)obj).accept(this, arg);
			if (obj2 != null)
			{
				return obj2;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ModuleDeclaration n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getDirectives().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ModuleRequiresDirective n, object arg)
	{
		object obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ModuleExportsDirective n, object arg)
	{
		object obj = n.getModuleNames().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ModuleProvidesDirective n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getWith().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ModuleUsesDirective n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ModuleOpensDirective n, object arg)
	{
		object obj = n.getModuleNames().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(UnparsableStmt n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(ReceiverParameter n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(VarType n, object arg)
	{
		object obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(Modifier n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(SwitchExpr n, object arg)
	{
		object obj = n.getEntries().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getSelector().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(YieldStmt n, object arg)
	{
		object obj = n.getExpression().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(TextBlockLiteralExpr n, object arg)
	{
		if (n.getComment().isPresent())
		{
			object obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(PatternExpr n, object arg)
	{
		object obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getType().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(RecordDeclaration n, object arg)
	{
		object obj = n.getImplementedTypes().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getReceiverParameter().isPresent())
		{
			obj = ((ReceiverParameter)n.getReceiverParameter().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		obj = n.getTypeParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getMembers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}

	
		
	
	public virtual object visit(CompactConstructorDeclaration n, object arg)
	{
		object obj = n.getBody().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getModifiers().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getName().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getThrownExceptions().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getTypeParameters().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		obj = n.getAnnotations().accept(this, arg);
		if (obj != null)
		{
			return obj;
		}
		if (n.getComment().isPresent())
		{
			obj = ((Comment)n.getComment().get()).accept(this, arg);
			if (obj != null)
			{
				return obj;
			}
		}
		return null;
	}
}
