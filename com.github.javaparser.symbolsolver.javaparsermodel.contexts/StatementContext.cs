
using com.github.javaparser.ast;
using com.github.javaparser.ast.body;
using com.github.javaparser.ast.expr;
using com.github.javaparser.ast.nodeTypes;
using com.github.javaparser.ast.stmt;
using com.github.javaparser.resolution.declarations;
using com.github.javaparser.symbolsolver.core.resolution;
using com.github.javaparser.symbolsolver.javaparsermodel.declarations;
using com.github.javaparser.symbolsolver.model.resolution;
using com.github.javaparser.symbolsolver.resolution;

using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;

namespace com.github.javaparser.symbolsolver.javaparsermodel.contexts;

public class StatementContext : AbstractJavaParserContext
{
	
	private sealed class ___003C_003EAnon0 : Function
	{
		private readonly string arg_00241;

		internal ___003C_003EAnon0(string P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Optional result = lambda_0024solveSymbolAsValue_00240(arg_00241, (Context)P_0);
			_ = null;
			return result;
		}

		
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	
		
	public static SymbolReference solveInBlock(string name, TypeSolver typeSolver, Statement stmt)
	{
		Optional parentNode = stmt.getParentNode();
		if (!parentNode.isPresent())
		{
			SymbolReference result = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
			_ = null;
			return result;
		}
		Node node = (Node)parentNode.get();
		if (!(node is NodeWithStatements))
		{
			
			throw new IllegalArgumentException();
		}
		NodeWithStatements nodeWithStatements = (NodeWithStatements)node;
		int num = -1;
		for (int i = 0; i < nodeWithStatements.getStatements().size(); i++)
		{
			if (((Statement)nodeWithStatements.getStatements().get(i)).equals(stmt))
			{
				num = i;
			}
		}
		if (num == -1)
		{
			
			throw new RuntimeException();
		}
		for (int i = num - 1; i >= 0; i += -1)
		{
			SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(nodeWithStatements.getStatements().get(i), typeSolver);
			SymbolReference symbolReference = AbstractJavaParserContext.solveWith(symbolDeclarator, name);
			if (symbolReference.isSolved())
			{
				return symbolReference;
			}
		}
		SymbolReference result2 = JavaParserFactory.getContext(node, typeSolver).solveSymbol(name);
		_ = null;
		return result2;
	}

	
		
	protected internal override Optional solveWithAsValue(SymbolDeclarator symbolDeclarator, string name)
	{
		Optional result = base.solveWithAsValue(symbolDeclarator, name);
		_ = null;
		return result;
	}

	
		
	private SymbolReference solveSymbol(string P_0, bool P_1)
	{
		SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(wrappedNode, typeSolver);
		SymbolReference symbolReference = AbstractJavaParserContext.solveWith(symbolDeclarator, P_0);
		if (symbolReference.isSolved())
		{
			return symbolReference;
		}
		List list = patternExprsExposedFromChildren();
		for (int i = 0; i < list.size(); i++)
		{
			PatternExpr patternExpr = (PatternExpr)list.get(i);
			if (String.instancehelper_equals(patternExpr.getNameAsString(), P_0))
			{
				SymbolReference result = SymbolReference.solved(JavaParserSymbolDeclaration.patternVar(patternExpr, typeSolver));
				_ = null;
				return result;
			}
		}
		Optional parentNode = ((Statement)wrappedNode).getParentNode();
		if (!parentNode.isPresent())
		{
			SymbolReference result2 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
			_ = null;
			return result2;
		}
		Node node = (Node)parentNode.get();
		if (node is MethodDeclaration)
		{
			SymbolReference result3 = solveSymbolInParentContext(P_0);
			_ = null;
			return result3;
		}
		if (node is ConstructorDeclaration)
		{
			SymbolReference result4 = solveSymbolInParentContext(P_0);
			_ = null;
			return result4;
		}
		if (node is LambdaExpr)
		{
			SymbolReference result5 = solveSymbolInParentContext(P_0);
			_ = null;
			return result5;
		}
		if (node is NodeWithStatements)
		{
			if (!P_1)
			{
				SymbolReference result6 = SymbolReference.unsolved(ClassLiteral<ResolvedValueDeclaration>.Value);
				_ = null;
				return result6;
			}
			NodeWithStatements nodeWithStatements = (NodeWithStatements)node;
			int num = nodeWithStatements.getStatements().indexOf(wrappedNode);
			if (num == -1)
			{
				
				throw new IllegalStateException("This node is not a statement within the current NodeWithStatements");
			}
			ListIterator listIterator = nodeWithStatements.getStatements().listIterator(num);
			while (listIterator.hasPrevious())
			{
				Context context = JavaParserFactory.getContext((Node)listIterator.previous(), typeSolver);
				if (!(context is BlockStmtContext))
				{
					symbolReference = ((!(context is StatementContext)) ? context.solveSymbol(P_0) : ((StatementContext)context).solveSymbol(P_0, false));
					if (symbolReference.isSolved())
					{
						return symbolReference;
					}
				}
			}
		}
		SymbolReference result7 = solveSymbolInParentContext(P_0);
		_ = null;
		return result7;
	}

	
		
	public override List patternExprsExposedFromChildren()
	{
		List result = Collections.emptyList();
		_ = null;
		return result;
	}

	
	
	
	private static Optional lambda_0024solveSymbolAsValue_00240(string P_0, Context P_1)
	{
		Optional result = P_1.solveSymbolAsValue(P_0);
		_ = null;
		return result;
	}

	
		
	public StatementContext(Statement wrappedNode, TypeSolver typeSolver)
		: base(wrappedNode, typeSolver)
	{
	}

	
		
	public static Optional solveInBlockAsValue(string name, TypeSolver typeSolver, Statement stmt)
	{
		Optional parentNode = stmt.getParentNode();
		if (!parentNode.isPresent())
		{
			Optional result = Optional.empty();
			_ = null;
			return result;
		}
		Node node = (Node)parentNode.get();
		if (!(node is NodeWithStatements))
		{
			
			throw new IllegalArgumentException();
		}
		NodeWithStatements nodeWithStatements = (NodeWithStatements)node;
		int num = -1;
		for (int i = 0; i < nodeWithStatements.getStatements().size(); i++)
		{
			if (((Statement)nodeWithStatements.getStatements().get(i)).equals(stmt))
			{
				num = i;
			}
		}
		if (num == -1)
		{
			
			throw new RuntimeException();
		}
		for (int i = num - 1; i >= 0; i += -1)
		{
			SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(nodeWithStatements.getStatements().get(i), typeSolver);
			SymbolReference symbolReference = AbstractJavaParserContext.solveWith(symbolDeclarator, name);
			if (symbolReference.isSolved())
			{
				Optional result2 = Optional.of(Value.from((ResolvedValueDeclaration)symbolReference.getCorrespondingDeclaration()));
				_ = null;
				return result2;
			}
		}
		Optional result3 = JavaParserFactory.getContext(node, typeSolver).solveSymbolAsValue(name);
		_ = null;
		return result3;
	}

	
		
	public override Optional solveSymbolAsValue(string name)
	{
		SymbolDeclarator symbolDeclarator = JavaParserFactory.getSymbolDeclarator(wrappedNode, typeSolver);
		Optional optional = solveWithAsValue(symbolDeclarator, name);
		if (optional.isPresent())
		{
			return optional;
		}
		if (!getParent().isPresent())
		{
			Optional result = Optional.empty();
			_ = null;
			return result;
		}
		Context context = (Context)getParent().get();
		Optional parentNode = ((Statement)wrappedNode).getParentNode();
		if (!parentNode.isPresent())
		{
			Optional result2 = Optional.empty();
			_ = null;
			return result2;
		}
		Node node = (Node)parentNode.get();
		if (node is MethodDeclaration)
		{
			Optional result3 = context.solveSymbolAsValue(name);
			_ = null;
			return result3;
		}
		if (node is LambdaExpr)
		{
			Optional result4 = context.solveSymbolAsValue(name);
			_ = null;
			return result4;
		}
		if (!(node is NodeWithStatements))
		{
			Optional result5 = context.solveSymbolAsValue(name);
			_ = null;
			return result5;
		}
		NodeWithStatements nodeWithStatements = (NodeWithStatements)node;
		int num = -1;
		for (int i = 0; i < nodeWithStatements.getStatements().size(); i++)
		{
			if (((Statement)nodeWithStatements.getStatements().get(i)).equals(wrappedNode))
			{
				num = i;
			}
		}
		if (num == -1)
		{
			
			throw new RuntimeException();
		}
		for (int i = num - 1; i >= 0; i += -1)
		{
			Statement node2 = (Statement)nodeWithStatements.getStatements().get(i);
			symbolDeclarator = JavaParserFactory.getSymbolDeclarator(node2, typeSolver);
			optional = solveWithAsValue(symbolDeclarator, name);
			if (optional.isPresent())
			{
				return optional;
			}
		}
		return (Optional)context.getParent().map(new ___003C_003EAnon0(name)).orElse(Optional.empty());
	}

	
		
	public override SymbolReference solveSymbol(string name)
	{
		SymbolReference result = solveSymbol(name, true);
		_ = null;
		return result;
	}

	
		
	public override SymbolReference solveMethod(string name, List argumentsTypes, bool staticOnly)
	{
		SymbolReference result = solveMethodInParentContext(name, argumentsTypes, false);
		_ = null;
		return result;
	}

	
		
	public override List negatedPatternExprsExposedFromChildren()
	{
		List result = Collections.emptyList();
		_ = null;
		return result;
	}
}
