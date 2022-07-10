using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.comments;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.modules;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.ast.type;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.github.javaparser.ast.visitor;

public class NoCommentEqualsVisitor : GenericVisitor
{
	
	private static NoCommentEqualsVisitor SINGLETON;

	
	
	public static void ___003Cclinit_003E()
	{
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	private bool nodeEquals(Node n, Node n2)
	{
		if (n == n2)
		{
			return true;
		}
		if (n == null || n2 == null)
		{
			return false;
		}
		if (((object)n).GetType() != ((object)n2).GetType())
		{
			return false;
		}
		bool result = ((Boolean)n.accept(this, n2)).booleanValue();
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	[LineNumberTable(new byte[]
	{
		159, 185, 100, 130, 102, 130, 110, 130, 107, 118,
		2, 230, 69
	})]
	private bool nodesEquals(NodeList n, NodeList n2)
	{
		if (n == n2)
		{
			return true;
		}
		if (n == null || n2 == null)
		{
			return false;
		}
		if (n.size() != n2.size())
		{
			return false;
		}
		for (int i = 0; i < n.size(); i++)
		{
			if (!nodeEquals(n.get(i), n2.get(i)))
			{
				return false;
			}
		}
		return true;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	private bool nodeEquals(Optional n, Optional n2)
	{
		bool result = nodeEquals((Node)n.orElse(null), (Node)n2.orElse(null));
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	private bool objEquals(object n, object n2)
	{
		if (n == n2)
		{
			return true;
		}
		if (n == null || n2 == null)
		{
			return false;
		}
		bool result = Object.instancehelper_equals(n, n2);
		
		return result;
	}

	
		[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	private bool nodesEquals(Optional n, Optional n2)
	{
		bool result = nodesEquals((NodeList)n.orElse(null), (NodeList)n2.orElse(null));
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(PatternExpr n, Visitable arg)
	{
		PatternExpr patternExpr = (PatternExpr)arg;
		if (!nodeEquals(n.getName(), patternExpr.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getType(), patternExpr.getType()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(TextBlockLiteralExpr n, Visitable arg)
	{
		TextBlockLiteralExpr textBlockLiteralExpr = (TextBlockLiteralExpr)arg;
		if (!objEquals(n.getValue(), textBlockLiteralExpr.getValue()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(YieldStmt n, Visitable arg)
	{
		YieldStmt yieldStmt = (YieldStmt)arg;
		if (!nodeEquals(n.getExpression(), yieldStmt.getExpression()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(SwitchExpr n, Visitable arg)
	{
		SwitchExpr switchExpr = (SwitchExpr)arg;
		if (!nodesEquals(n.getEntries(), switchExpr.getEntries()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getSelector(), switchExpr.getSelector()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(Modifier n, Visitable arg)
	{
		Modifier modifier = (Modifier)arg;
		if (!objEquals(n.getKeyword(), modifier.getKeyword()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(VarType n, Visitable arg)
	{
		VarType varType = (VarType)arg;
		if (!nodesEquals(n.getAnnotations(), varType.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ReceiverParameter n, Visitable arg)
	{
		ReceiverParameter receiverParameter = (ReceiverParameter)arg;
		if (!nodesEquals(n.getAnnotations(), receiverParameter.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), receiverParameter.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getType(), receiverParameter.getType()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(UnparsableStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(b: true);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ModuleOpensDirective n, Visitable arg)
	{
		ModuleOpensDirective moduleOpensDirective = (ModuleOpensDirective)arg;
		if (!nodesEquals(n.getModuleNames(), moduleOpensDirective.getModuleNames()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), moduleOpensDirective.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ModuleUsesDirective n, Visitable arg)
	{
		ModuleUsesDirective moduleUsesDirective = (ModuleUsesDirective)arg;
		if (!nodeEquals(n.getName(), moduleUsesDirective.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ModuleProvidesDirective n, Visitable arg)
	{
		ModuleProvidesDirective moduleProvidesDirective = (ModuleProvidesDirective)arg;
		if (!nodeEquals(n.getName(), moduleProvidesDirective.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getWith(), moduleProvidesDirective.getWith()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ModuleExportsDirective n, Visitable arg)
	{
		ModuleExportsDirective moduleExportsDirective = (ModuleExportsDirective)arg;
		if (!nodesEquals(n.getModuleNames(), moduleExportsDirective.getModuleNames()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), moduleExportsDirective.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ModuleRequiresDirective n, Visitable arg)
	{
		ModuleRequiresDirective moduleRequiresDirective = (ModuleRequiresDirective)arg;
		if (!nodesEquals(n.getModifiers(), moduleRequiresDirective.getModifiers()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), moduleRequiresDirective.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 107, 103, 116, 105, 116, 105, 126, 105, 116,
		105
	})]
	public virtual Boolean visit(ModuleDeclaration n, Visitable arg)
	{
		ModuleDeclaration moduleDeclaration = (ModuleDeclaration)arg;
		if (!nodesEquals(n.getAnnotations(), moduleDeclaration.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getDirectives(), moduleDeclaration.getDirectives()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!objEquals(Boolean.valueOf(n.isOpen()), Boolean.valueOf(moduleDeclaration.isOpen())))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodeEquals(n.getName(), moduleDeclaration.getName()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ImportDeclaration n, Visitable arg)
	{
		ImportDeclaration importDeclaration = (ImportDeclaration)arg;
		if (!objEquals(Boolean.valueOf(n.isAsterisk()), Boolean.valueOf(importDeclaration.isAsterisk())))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!objEquals(Boolean.valueOf(n.isStatic()), Boolean.valueOf(importDeclaration.isStatic())))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getName(), importDeclaration.getName()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(SimpleName n, Visitable arg)
	{
		SimpleName simpleName = (SimpleName)arg;
		if (!objEquals(n.getIdentifier(), simpleName.getIdentifier()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(Name n, Visitable arg)
	{
		Name name = (Name)arg;
		if (!objEquals(n.getIdentifier(), name.getIdentifier()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getQualifier(), name.getQualifier()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		(Modifiers)0,
		(Modifiers)0
	})]
	
	public virtual Boolean visit(NodeList n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(nodesEquals(n, (NodeList)arg));
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(TypeExpr n, Visitable arg)
	{
		TypeExpr typeExpr = (TypeExpr)arg;
		if (!nodeEquals(n.getType(), typeExpr.getType()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(MethodReferenceExpr n, Visitable arg)
	{
		MethodReferenceExpr methodReferenceExpr = (MethodReferenceExpr)arg;
		if (!objEquals(n.getIdentifier(), methodReferenceExpr.getIdentifier()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getScope(), methodReferenceExpr.getScope()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getTypeArguments(), methodReferenceExpr.getTypeArguments()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(LambdaExpr n, Visitable arg)
	{
		LambdaExpr lambdaExpr = (LambdaExpr)arg;
		if (!nodeEquals(n.getBody(), lambdaExpr.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!objEquals(Boolean.valueOf(n.isEnclosingParameters()), Boolean.valueOf(lambdaExpr.isEnclosingParameters())))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getParameters(), lambdaExpr.getParameters()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(CatchClause n, Visitable arg)
	{
		CatchClause catchClause = (CatchClause)arg;
		if (!nodeEquals(n.getBody(), catchClause.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getParameter(), catchClause.getParameter()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 34, 103, 116, 105, 116, 105, 116, 105, 116,
		105
	})]
	public virtual Boolean visit(TryStmt n, Visitable arg)
	{
		TryStmt tryStmt = (TryStmt)arg;
		if (!nodesEquals(n.getCatchClauses(), tryStmt.getCatchClauses()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getFinallyBlock(), tryStmt.getFinallyBlock()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getResources(), tryStmt.getResources()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodeEquals(n.getTryBlock(), tryStmt.getTryBlock()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(SynchronizedStmt n, Visitable arg)
	{
		SynchronizedStmt synchronizedStmt = (SynchronizedStmt)arg;
		if (!nodeEquals(n.getBody(), synchronizedStmt.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getExpression(), synchronizedStmt.getExpression()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ThrowStmt n, Visitable arg)
	{
		ThrowStmt throwStmt = (ThrowStmt)arg;
		if (!nodeEquals(n.getExpression(), throwStmt.getExpression()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 2, 103, 116, 105, 116, 105, 116, 105, 116,
		105
	})]
	public virtual Boolean visit(ForStmt n, Visitable arg)
	{
		ForStmt forStmt = (ForStmt)arg;
		if (!nodeEquals(n.getBody(), forStmt.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getCompare(), forStmt.getCompare()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getInitialization(), forStmt.getInitialization()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getUpdate(), forStmt.getUpdate()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ForEachStmt n, Visitable arg)
	{
		ForEachStmt forEachStmt = (ForEachStmt)arg;
		if (!nodeEquals(n.getBody(), forEachStmt.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getIterable(), forEachStmt.getIterable()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getVariable(), forEachStmt.getVariable()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(DoStmt n, Visitable arg)
	{
		DoStmt doStmt = (DoStmt)arg;
		if (!nodeEquals(n.getBody(), doStmt.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getCondition(), doStmt.getCondition()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ContinueStmt n, Visitable arg)
	{
		ContinueStmt continueStmt = (ContinueStmt)arg;
		if (!nodeEquals(n.getLabel(), continueStmt.getLabel()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(WhileStmt n, Visitable arg)
	{
		WhileStmt whileStmt = (WhileStmt)arg;
		if (!nodeEquals(n.getBody(), whileStmt.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getCondition(), whileStmt.getCondition()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(IfStmt n, Visitable arg)
	{
		IfStmt ifStmt = (IfStmt)arg;
		if (!nodeEquals(n.getCondition(), ifStmt.getCondition()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getElseStmt(), ifStmt.getElseStmt()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getThenStmt(), ifStmt.getThenStmt()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ReturnStmt n, Visitable arg)
	{
		ReturnStmt returnStmt = (ReturnStmt)arg;
		if (!nodeEquals(n.getExpression(), returnStmt.getExpression()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(BreakStmt n, Visitable arg)
	{
		BreakStmt breakStmt = (BreakStmt)arg;
		if (!nodeEquals(n.getLabel(), breakStmt.getLabel()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(SwitchEntry n, Visitable arg)
	{
		SwitchEntry switchEntry = (SwitchEntry)arg;
		if (!nodesEquals(n.getLabels(), switchEntry.getLabels()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getStatements(), switchEntry.getStatements()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!objEquals(n.getType(), switchEntry.getType()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(SwitchStmt n, Visitable arg)
	{
		SwitchStmt switchStmt = (SwitchStmt)arg;
		if (!nodesEquals(n.getEntries(), switchStmt.getEntries()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getSelector(), switchStmt.getSelector()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ExpressionStmt n, Visitable arg)
	{
		ExpressionStmt expressionStmt = (ExpressionStmt)arg;
		if (!nodeEquals(n.getExpression(), expressionStmt.getExpression()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(EmptyStmt n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(b: true);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(LabeledStmt n, Visitable arg)
	{
		LabeledStmt labeledStmt = (LabeledStmt)arg;
		if (!nodeEquals(n.getLabel(), labeledStmt.getLabel()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getStatement(), labeledStmt.getStatement()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(BlockStmt n, Visitable arg)
	{
		BlockStmt blockStmt = (BlockStmt)arg;
		if (!nodesEquals(n.getStatements(), blockStmt.getStatements()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(AssertStmt n, Visitable arg)
	{
		AssertStmt assertStmt = (AssertStmt)arg;
		if (!nodeEquals(n.getCheck(), assertStmt.getCheck()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getMessage(), assertStmt.getMessage()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(LocalRecordDeclarationStmt n, Visitable arg)
	{
		LocalRecordDeclarationStmt localRecordDeclarationStmt = (LocalRecordDeclarationStmt)arg;
		if (!nodeEquals(n.getRecordDeclaration(), localRecordDeclarationStmt.getRecordDeclaration()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(LocalClassDeclarationStmt n, Visitable arg)
	{
		LocalClassDeclarationStmt localClassDeclarationStmt = (LocalClassDeclarationStmt)arg;
		if (!nodeEquals(n.getClassDeclaration(), localClassDeclarationStmt.getClassDeclaration()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		162, 97, 103, 116, 105, 116, 105, 126, 105, 116,
		105
	})]
	public virtual Boolean visit(ExplicitConstructorInvocationStmt n, Visitable arg)
	{
		ExplicitConstructorInvocationStmt explicitConstructorInvocationStmt = (ExplicitConstructorInvocationStmt)arg;
		if (!nodesEquals(n.getArguments(), explicitConstructorInvocationStmt.getArguments()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getExpression(), explicitConstructorInvocationStmt.getExpression()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!objEquals(Boolean.valueOf(n.isThis()), Boolean.valueOf(explicitConstructorInvocationStmt.isThis())))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getTypeArguments(), explicitConstructorInvocationStmt.getTypeArguments()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(MemberValuePair n, Visitable arg)
	{
		MemberValuePair memberValuePair = (MemberValuePair)arg;
		if (!nodeEquals(n.getName(), memberValuePair.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getValue(), memberValuePair.getValue()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(NormalAnnotationExpr n, Visitable arg)
	{
		NormalAnnotationExpr normalAnnotationExpr = (NormalAnnotationExpr)arg;
		if (!nodesEquals(n.getPairs(), normalAnnotationExpr.getPairs()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), normalAnnotationExpr.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(SingleMemberAnnotationExpr n, Visitable arg)
	{
		SingleMemberAnnotationExpr singleMemberAnnotationExpr = (SingleMemberAnnotationExpr)arg;
		if (!nodeEquals(n.getMemberValue(), singleMemberAnnotationExpr.getMemberValue()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), singleMemberAnnotationExpr.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(MarkerAnnotationExpr n, Visitable arg)
	{
		MarkerAnnotationExpr markerAnnotationExpr = (MarkerAnnotationExpr)arg;
		if (!nodeEquals(n.getName(), markerAnnotationExpr.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(VariableDeclarationExpr n, Visitable arg)
	{
		VariableDeclarationExpr variableDeclarationExpr = (VariableDeclarationExpr)arg;
		if (!nodesEquals(n.getAnnotations(), variableDeclarationExpr.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getModifiers(), variableDeclarationExpr.getModifiers()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getVariables(), variableDeclarationExpr.getVariables()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(UnaryExpr n, Visitable arg)
	{
		UnaryExpr unaryExpr = (UnaryExpr)arg;
		if (!nodeEquals(n.getExpression(), unaryExpr.getExpression()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!objEquals(n.getOperator(), unaryExpr.getOperator()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(SuperExpr n, Visitable arg)
	{
		SuperExpr superExpr = (SuperExpr)arg;
		if (!nodeEquals(n.getTypeName(), superExpr.getTypeName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ThisExpr n, Visitable arg)
	{
		ThisExpr thisExpr = (ThisExpr)arg;
		if (!nodeEquals(n.getTypeName(), thisExpr.getTypeName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 243, 103, 116, 105, 116, 105, 116, 105, 116,
		105, 116, 105
	})]
	public virtual Boolean visit(ObjectCreationExpr n, Visitable arg)
	{
		ObjectCreationExpr objectCreationExpr = (ObjectCreationExpr)arg;
		if (!nodesEquals(n.getAnonymousClassBody(), objectCreationExpr.getAnonymousClassBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getArguments(), objectCreationExpr.getArguments()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getScope(), objectCreationExpr.getScope()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodeEquals(n.getType(), objectCreationExpr.getType()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodesEquals(n.getTypeArguments(), objectCreationExpr.getTypeArguments()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		Boolean result6 = Boolean.valueOf(b: true);
		
		return result6;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(NameExpr n, Visitable arg)
	{
		NameExpr nameExpr = (NameExpr)arg;
		if (!nodeEquals(n.getName(), nameExpr.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		161, 221, 103, 116, 105, 116, 105, 116, 105, 116,
		105
	})]
	public virtual Boolean visit(MethodCallExpr n, Visitable arg)
	{
		MethodCallExpr methodCallExpr = (MethodCallExpr)arg;
		if (!nodesEquals(n.getArguments(), methodCallExpr.getArguments()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), methodCallExpr.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getScope(), methodCallExpr.getScope()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getTypeArguments(), methodCallExpr.getTypeArguments()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(NullLiteralExpr n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(b: true);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(BooleanLiteralExpr n, Visitable arg)
	{
		BooleanLiteralExpr booleanLiteralExpr = (BooleanLiteralExpr)arg;
		if (!objEquals(Boolean.valueOf(n.isValue()), Boolean.valueOf(booleanLiteralExpr.isValue())))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(DoubleLiteralExpr n, Visitable arg)
	{
		DoubleLiteralExpr doubleLiteralExpr = (DoubleLiteralExpr)arg;
		if (!objEquals(n.getValue(), doubleLiteralExpr.getValue()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(CharLiteralExpr n, Visitable arg)
	{
		CharLiteralExpr charLiteralExpr = (CharLiteralExpr)arg;
		if (!objEquals(n.getValue(), charLiteralExpr.getValue()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(LongLiteralExpr n, Visitable arg)
	{
		LongLiteralExpr longLiteralExpr = (LongLiteralExpr)arg;
		if (!objEquals(n.getValue(), longLiteralExpr.getValue()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(IntegerLiteralExpr n, Visitable arg)
	{
		IntegerLiteralExpr integerLiteralExpr = (IntegerLiteralExpr)arg;
		if (!objEquals(n.getValue(), integerLiteralExpr.getValue()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(StringLiteralExpr n, Visitable arg)
	{
		StringLiteralExpr stringLiteralExpr = (StringLiteralExpr)arg;
		if (!objEquals(n.getValue(), stringLiteralExpr.getValue()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(InstanceOfExpr n, Visitable arg)
	{
		InstanceOfExpr instanceOfExpr = (InstanceOfExpr)arg;
		if (!nodeEquals(n.getExpression(), instanceOfExpr.getExpression()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getPattern(), instanceOfExpr.getPattern()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getType(), instanceOfExpr.getType()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(FieldAccessExpr n, Visitable arg)
	{
		FieldAccessExpr fieldAccessExpr = (FieldAccessExpr)arg;
		if (!nodeEquals(n.getName(), fieldAccessExpr.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getScope(), fieldAccessExpr.getScope()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getTypeArguments(), fieldAccessExpr.getTypeArguments()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(EnclosedExpr n, Visitable arg)
	{
		EnclosedExpr enclosedExpr = (EnclosedExpr)arg;
		if (!nodeEquals(n.getInner(), enclosedExpr.getInner()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ConditionalExpr n, Visitable arg)
	{
		ConditionalExpr conditionalExpr = (ConditionalExpr)arg;
		if (!nodeEquals(n.getCondition(), conditionalExpr.getCondition()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getElseExpr(), conditionalExpr.getElseExpr()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getThenExpr(), conditionalExpr.getThenExpr()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ClassExpr n, Visitable arg)
	{
		ClassExpr classExpr = (ClassExpr)arg;
		if (!nodeEquals(n.getType(), classExpr.getType()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(CastExpr n, Visitable arg)
	{
		CastExpr castExpr = (CastExpr)arg;
		if (!nodeEquals(n.getExpression(), castExpr.getExpression()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getType(), castExpr.getType()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(BinaryExpr n, Visitable arg)
	{
		BinaryExpr binaryExpr = (BinaryExpr)arg;
		if (!nodeEquals(n.getLeft(), binaryExpr.getLeft()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!objEquals(n.getOperator(), binaryExpr.getOperator()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getRight(), binaryExpr.getRight()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(AssignExpr n, Visitable arg)
	{
		AssignExpr assignExpr = (AssignExpr)arg;
		if (!objEquals(n.getOperator(), assignExpr.getOperator()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getTarget(), assignExpr.getTarget()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getValue(), assignExpr.getValue()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ArrayInitializerExpr n, Visitable arg)
	{
		ArrayInitializerExpr arrayInitializerExpr = (ArrayInitializerExpr)arg;
		if (!nodesEquals(n.getValues(), arrayInitializerExpr.getValues()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ArrayCreationExpr n, Visitable arg)
	{
		ArrayCreationExpr arrayCreationExpr = (ArrayCreationExpr)arg;
		if (!nodeEquals(n.getElementType(), arrayCreationExpr.getElementType()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getInitializer(), arrayCreationExpr.getInitializer()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getLevels(), arrayCreationExpr.getLevels()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ArrayAccessExpr n, Visitable arg)
	{
		ArrayAccessExpr arrayAccessExpr = (ArrayAccessExpr)arg;
		if (!nodeEquals(n.getIndex(), arrayAccessExpr.getIndex()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), arrayAccessExpr.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(UnknownType n, Visitable arg)
	{
		UnknownType unknownType = (UnknownType)arg;
		if (!nodesEquals(n.getAnnotations(), unknownType.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(WildcardType n, Visitable arg)
	{
		WildcardType wildcardType = (WildcardType)arg;
		if (!nodeEquals(n.getExtendedType(), wildcardType.getExtendedType()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getSuperType(), wildcardType.getSuperType()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getAnnotations(), wildcardType.getAnnotations()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(VoidType n, Visitable arg)
	{
		VoidType voidType = (VoidType)arg;
		if (!nodesEquals(n.getAnnotations(), voidType.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		Boolean result2 = Boolean.valueOf(b: true);
		
		return result2;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(UnionType n, Visitable arg)
	{
		UnionType unionType = (UnionType)arg;
		if (!nodesEquals(n.getElements(), unionType.getElements()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getAnnotations(), unionType.getAnnotations()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(IntersectionType n, Visitable arg)
	{
		IntersectionType intersectionType = (IntersectionType)arg;
		if (!nodesEquals(n.getElements(), intersectionType.getElements()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getAnnotations(), intersectionType.getAnnotations()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ArrayCreationLevel n, Visitable arg)
	{
		ArrayCreationLevel arrayCreationLevel = (ArrayCreationLevel)arg;
		if (!nodesEquals(n.getAnnotations(), arrayCreationLevel.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getDimension(), arrayCreationLevel.getDimension()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(ArrayType n, Visitable arg)
	{
		ArrayType arrayType = (ArrayType)arg;
		if (!nodeEquals(n.getComponentType(), arrayType.getComponentType()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!objEquals(n.getOrigin(), arrayType.getOrigin()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getAnnotations(), arrayType.getAnnotations()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(PrimitiveType n, Visitable arg)
	{
		PrimitiveType primitiveType = (PrimitiveType)arg;
		if (!objEquals(n.getType(), primitiveType.getType()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getAnnotations(), primitiveType.getAnnotations()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 214, 103, 116, 105, 116, 105, 116, 105, 116,
		105
	})]
	public virtual Boolean visit(ClassOrInterfaceType n, Visitable arg)
	{
		ClassOrInterfaceType classOrInterfaceType = (ClassOrInterfaceType)arg;
		if (!nodeEquals(n.getName(), classOrInterfaceType.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getScope(), classOrInterfaceType.getScope()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getTypeArguments(), classOrInterfaceType.getTypeArguments()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getAnnotations(), classOrInterfaceType.getAnnotations()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(JavadocComment n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(b: true);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(InitializerDeclaration n, Visitable arg)
	{
		InitializerDeclaration initializerDeclaration = (InitializerDeclaration)arg;
		if (!nodeEquals(n.getBody(), initializerDeclaration.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!objEquals(Boolean.valueOf(n.isStatic()), Boolean.valueOf(initializerDeclaration.isStatic())))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getAnnotations(), initializerDeclaration.getAnnotations()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 179, 103, 116, 105, 126, 105, 116, 105, 116,
		105, 116, 105, 116, 105
	})]
	public virtual Boolean visit(Parameter n, Visitable arg)
	{
		Parameter parameter = (Parameter)arg;
		if (!nodesEquals(n.getAnnotations(), parameter.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!objEquals(Boolean.valueOf(n.isVarArgs()), Boolean.valueOf(parameter.isVarArgs())))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getModifiers(), parameter.getModifiers()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodeEquals(n.getName(), parameter.getName()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodeEquals(n.getType(), parameter.getType()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		if (!nodesEquals(n.getVarArgsAnnotations(), parameter.getVarArgsAnnotations()))
		{
			Boolean result6 = Boolean.valueOf(b: false);
			
			return result6;
		}
		Boolean result7 = Boolean.valueOf(b: true);
		
		return result7;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 155, 103, 116, 105, 116, 105, 116, 105, 116,
		105, 116, 105, 116, 105, 116, 105, 116, 105, 116,
		105
	})]
	public virtual Boolean visit(MethodDeclaration n, Visitable arg)
	{
		MethodDeclaration methodDeclaration = (MethodDeclaration)arg;
		if (!nodeEquals(n.getBody(), methodDeclaration.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getType(), methodDeclaration.getType()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getModifiers(), methodDeclaration.getModifiers()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodeEquals(n.getName(), methodDeclaration.getName()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodesEquals(n.getParameters(), methodDeclaration.getParameters()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		if (!nodeEquals(n.getReceiverParameter(), methodDeclaration.getReceiverParameter()))
		{
			Boolean result6 = Boolean.valueOf(b: false);
			
			return result6;
		}
		if (!nodesEquals(n.getThrownExceptions(), methodDeclaration.getThrownExceptions()))
		{
			Boolean result7 = Boolean.valueOf(b: false);
			
			return result7;
		}
		if (!nodesEquals(n.getTypeParameters(), methodDeclaration.getTypeParameters()))
		{
			Boolean result8 = Boolean.valueOf(b: false);
			
			return result8;
		}
		if (!nodesEquals(n.getAnnotations(), methodDeclaration.getAnnotations()))
		{
			Boolean result9 = Boolean.valueOf(b: false);
			
			return result9;
		}
		Boolean result10 = Boolean.valueOf(b: true);
		
		return result10;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 133, 103, 116, 105, 116, 105, 116, 105, 116,
		105, 116, 105, 116, 105, 116, 105, 116, 105
	})]
	public virtual Boolean visit(ConstructorDeclaration n, Visitable arg)
	{
		ConstructorDeclaration constructorDeclaration = (ConstructorDeclaration)arg;
		if (!nodeEquals(n.getBody(), constructorDeclaration.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getModifiers(), constructorDeclaration.getModifiers()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getName(), constructorDeclaration.getName()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getParameters(), constructorDeclaration.getParameters()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodeEquals(n.getReceiverParameter(), constructorDeclaration.getReceiverParameter()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		if (!nodesEquals(n.getThrownExceptions(), constructorDeclaration.getThrownExceptions()))
		{
			Boolean result6 = Boolean.valueOf(b: false);
			
			return result6;
		}
		if (!nodesEquals(n.getTypeParameters(), constructorDeclaration.getTypeParameters()))
		{
			Boolean result7 = Boolean.valueOf(b: false);
			
			return result7;
		}
		if (!nodesEquals(n.getAnnotations(), constructorDeclaration.getAnnotations()))
		{
			Boolean result8 = Boolean.valueOf(b: false);
			
			return result8;
		}
		Boolean result9 = Boolean.valueOf(b: true);
		
		return result9;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(VariableDeclarator n, Visitable arg)
	{
		VariableDeclarator variableDeclarator = (VariableDeclarator)arg;
		if (!nodeEquals(n.getInitializer(), variableDeclarator.getInitializer()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), variableDeclarator.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getType(), variableDeclarator.getType()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(FieldDeclaration n, Visitable arg)
	{
		FieldDeclaration fieldDeclaration = (FieldDeclaration)arg;
		if (!nodesEquals(n.getModifiers(), fieldDeclaration.getModifiers()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getVariables(), fieldDeclaration.getVariables()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getAnnotations(), fieldDeclaration.getAnnotations()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 93, 103, 116, 105, 116, 105, 116, 105, 116,
		105, 116, 105
	})]
	public virtual Boolean visit(AnnotationMemberDeclaration n, Visitable arg)
	{
		AnnotationMemberDeclaration annotationMemberDeclaration = (AnnotationMemberDeclaration)arg;
		if (!nodeEquals(n.getDefaultValue(), annotationMemberDeclaration.getDefaultValue()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getModifiers(), annotationMemberDeclaration.getModifiers()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getName(), annotationMemberDeclaration.getName()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodeEquals(n.getType(), annotationMemberDeclaration.getType()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodesEquals(n.getAnnotations(), annotationMemberDeclaration.getAnnotations()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		Boolean result6 = Boolean.valueOf(b: true);
		
		return result6;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 79, 103, 116, 105, 116, 105, 116, 105, 116,
		105
	})]
	public virtual Boolean visit(AnnotationDeclaration n, Visitable arg)
	{
		AnnotationDeclaration annotationDeclaration = (AnnotationDeclaration)arg;
		if (!nodesEquals(n.getMembers(), annotationDeclaration.getMembers()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getModifiers(), annotationDeclaration.getModifiers()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getName(), annotationDeclaration.getName()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getAnnotations(), annotationDeclaration.getAnnotations()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		160, 65, 103, 116, 105, 116, 105, 116, 105, 116,
		105
	})]
	public virtual Boolean visit(EnumConstantDeclaration n, Visitable arg)
	{
		EnumConstantDeclaration enumConstantDeclaration = (EnumConstantDeclaration)arg;
		if (!nodesEquals(n.getArguments(), enumConstantDeclaration.getArguments()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getClassBody(), enumConstantDeclaration.getClassBody()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getName(), enumConstantDeclaration.getName()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getAnnotations(), enumConstantDeclaration.getAnnotations()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		111, 103, 116, 105, 116, 105, 116, 105, 116, 105,
		116, 105, 116, 105
	})]
	public virtual Boolean visit(EnumDeclaration n, Visitable arg)
	{
		EnumDeclaration enumDeclaration = (EnumDeclaration)arg;
		if (!nodesEquals(n.getEntries(), enumDeclaration.getEntries()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getImplementedTypes(), enumDeclaration.getImplementedTypes()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getMembers(), enumDeclaration.getMembers()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getModifiers(), enumDeclaration.getModifiers()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodeEquals(n.getName(), enumDeclaration.getName()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		if (!nodesEquals(n.getAnnotations(), enumDeclaration.getAnnotations()))
		{
			Boolean result6 = Boolean.valueOf(b: false);
			
			return result6;
		}
		Boolean result7 = Boolean.valueOf(b: true);
		
		return result7;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		164, 4, 103, 116, 105, 116, 105, 116, 105, 116,
		105, 116, 105, 116, 105
	})]
	public virtual Boolean visit(CompactConstructorDeclaration n, Visitable arg)
	{
		CompactConstructorDeclaration compactConstructorDeclaration = (CompactConstructorDeclaration)arg;
		if (!nodeEquals(n.getBody(), compactConstructorDeclaration.getBody()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getModifiers(), compactConstructorDeclaration.getModifiers()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getName(), compactConstructorDeclaration.getName()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getThrownExceptions(), compactConstructorDeclaration.getThrownExceptions()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodesEquals(n.getTypeParameters(), compactConstructorDeclaration.getTypeParameters()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		if (!nodesEquals(n.getAnnotations(), compactConstructorDeclaration.getAnnotations()))
		{
			Boolean result6 = Boolean.valueOf(b: false);
			
			return result6;
		}
		Boolean result7 = Boolean.valueOf(b: true);
		
		return result7;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		163, 238, 103, 116, 105, 116, 105, 116, 105, 116,
		105, 116, 105, 116, 105, 116, 105, 116, 105
	})]
	public virtual Boolean visit(RecordDeclaration n, Visitable arg)
	{
		RecordDeclaration recordDeclaration = (RecordDeclaration)arg;
		if (!nodesEquals(n.getImplementedTypes(), recordDeclaration.getImplementedTypes()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getParameters(), recordDeclaration.getParameters()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getReceiverParameter(), recordDeclaration.getReceiverParameter()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getTypeParameters(), recordDeclaration.getTypeParameters()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodesEquals(n.getMembers(), recordDeclaration.getMembers()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		if (!nodesEquals(n.getModifiers(), recordDeclaration.getModifiers()))
		{
			Boolean result6 = Boolean.valueOf(b: false);
			
			return result6;
		}
		if (!nodeEquals(n.getName(), recordDeclaration.getName()))
		{
			Boolean result7 = Boolean.valueOf(b: false);
			
			return result7;
		}
		if (!nodesEquals(n.getAnnotations(), recordDeclaration.getAnnotations()))
		{
			Boolean result8 = Boolean.valueOf(b: false);
			
			return result8;
		}
		Boolean result9 = Boolean.valueOf(b: true);
		
		return result9;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	[LineNumberTable(new byte[]
	{
		89, 103, 116, 105, 116, 105, 126, 105, 116, 105,
		116, 105, 116, 105, 116, 105, 116, 105
	})]
	public virtual Boolean visit(ClassOrInterfaceDeclaration n, Visitable arg)
	{
		ClassOrInterfaceDeclaration classOrInterfaceDeclaration = (ClassOrInterfaceDeclaration)arg;
		if (!nodesEquals(n.getExtendedTypes(), classOrInterfaceDeclaration.getExtendedTypes()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getImplementedTypes(), classOrInterfaceDeclaration.getImplementedTypes()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!objEquals(Boolean.valueOf(n.isInterface()), Boolean.valueOf(classOrInterfaceDeclaration.isInterface())))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getTypeParameters(), classOrInterfaceDeclaration.getTypeParameters()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		if (!nodesEquals(n.getMembers(), classOrInterfaceDeclaration.getMembers()))
		{
			Boolean result5 = Boolean.valueOf(b: false);
			
			return result5;
		}
		if (!nodesEquals(n.getModifiers(), classOrInterfaceDeclaration.getModifiers()))
		{
			Boolean result6 = Boolean.valueOf(b: false);
			
			return result6;
		}
		if (!nodeEquals(n.getName(), classOrInterfaceDeclaration.getName()))
		{
			Boolean result7 = Boolean.valueOf(b: false);
			
			return result7;
		}
		if (!nodesEquals(n.getAnnotations(), classOrInterfaceDeclaration.getAnnotations()))
		{
			Boolean result8 = Boolean.valueOf(b: false);
			
			return result8;
		}
		Boolean result9 = Boolean.valueOf(b: true);
		
		return result9;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(BlockComment n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(b: true);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(LineComment n, Visitable arg)
	{
		Boolean result = Boolean.valueOf(b: true);
		
		return result;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(TypeParameter n, Visitable arg)
	{
		TypeParameter typeParameter = (TypeParameter)arg;
		if (!nodeEquals(n.getName(), typeParameter.getName()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodesEquals(n.getTypeBound(), typeParameter.getTypeBound()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodesEquals(n.getAnnotations(), typeParameter.getAnnotations()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		Boolean result4 = Boolean.valueOf(b: true);
		
		return result4;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(PackageDeclaration n, Visitable arg)
	{
		PackageDeclaration packageDeclaration = (PackageDeclaration)arg;
		if (!nodesEquals(n.getAnnotations(), packageDeclaration.getAnnotations()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getName(), packageDeclaration.getName()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		Boolean result3 = Boolean.valueOf(b: true);
		
		return result3;
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public virtual Boolean visit(CompilationUnit n, Visitable arg)
	{
		CompilationUnit compilationUnit = (CompilationUnit)arg;
		if (!nodesEquals(n.getImports(), compilationUnit.getImports()))
		{
			Boolean result = Boolean.valueOf(b: false);
			
			return result;
		}
		if (!nodeEquals(n.getModule(), compilationUnit.getModule()))
		{
			Boolean result2 = Boolean.valueOf(b: false);
			
			return result2;
		}
		if (!nodeEquals(n.getPackageDeclaration(), compilationUnit.getPackageDeclaration()))
		{
			Boolean result3 = Boolean.valueOf(b: false);
			
			return result3;
		}
		if (!nodesEquals(n.getTypes(), compilationUnit.getTypes()))
		{
			Boolean result4 = Boolean.valueOf(b: false);
			
			return result4;
		}
		Boolean result5 = Boolean.valueOf(b: true);
		
		return result5;
	}

	
	
	public NoCommentEqualsVisitor()
	{
	}

	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final,
		Modifiers.Final
	})]
	
	public static bool equals(Node n, Node n2)
	{
		bool result = SINGLETON.nodeEquals(n, n2);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(PatternExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(TextBlockLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(YieldStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(SwitchExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(Modifier n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(VarType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ReceiverParameter n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(UnparsableStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ModuleOpensDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ModuleUsesDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ModuleProvidesDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ModuleExportsDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ModuleRequiresDirective n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ModuleDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ImportDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(SimpleName n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(Name n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Synthetic,
		Modifiers.Synthetic
	})]
	
	public virtual object visit(NodeList n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(TypeExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(MethodReferenceExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(LambdaExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(CatchClause n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(TryStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(SynchronizedStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ThrowStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ForStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ForEachStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(DoStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ContinueStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(WhileStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(IfStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ReturnStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(BreakStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(SwitchEntry n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(SwitchStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ExpressionStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(EmptyStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(LabeledStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(BlockStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(AssertStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(LocalRecordDeclarationStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(LocalClassDeclarationStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ExplicitConstructorInvocationStmt n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(MemberValuePair n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(NormalAnnotationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(SingleMemberAnnotationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(MarkerAnnotationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(VariableDeclarationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(UnaryExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(SuperExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ThisExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ObjectCreationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(NameExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(MethodCallExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(NullLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(BooleanLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(DoubleLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(CharLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(LongLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(IntegerLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(StringLiteralExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(InstanceOfExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(FieldAccessExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(EnclosedExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ConditionalExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ClassExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(CastExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(BinaryExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(AssignExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ArrayInitializerExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ArrayCreationExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ArrayAccessExpr n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(UnknownType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(WildcardType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(VoidType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(UnionType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(IntersectionType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ArrayCreationLevel n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ArrayType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(PrimitiveType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ClassOrInterfaceType n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(JavadocComment n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(InitializerDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(Parameter n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(MethodDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ConstructorDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(VariableDeclarator n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(FieldDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(AnnotationMemberDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(AnnotationDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(EnumConstantDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(EnumDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(CompactConstructorDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(RecordDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(ClassOrInterfaceDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(BlockComment n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(LineComment n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(TypeParameter n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(PackageDeclaration n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	
	
	[MethodParameters(new Modifiers[]
	{
		Modifiers.Final | Modifiers.Synthetic,
		Modifiers.Final | Modifiers.Synthetic
	})]
	
	public virtual object visit(CompilationUnit n, object arg)
	{
		Boolean result = visit(n, (Visitable)arg);
		
		return result;
	}

	
	static NoCommentEqualsVisitor()
	{
		SINGLETON = new NoCommentEqualsVisitor();
	}
}
